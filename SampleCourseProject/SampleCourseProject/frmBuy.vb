Imports System.Data.OleDb
Imports System.Data

Public Class frmBuy
    Dim dbsource As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\StorageDatabase.mdb"
    Dim conn = New OleDbConnection(dbsource)

    Dim amountSugar As String = ""
    Dim tpSugar As String = ""

    Private Sub frmBuy_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frmTest.Show()
    End Sub

    Private Sub txtTypeOfSugar_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTypeOfSugar.Leave
        If txtTypeOfSugar.Text = "" Then
            MsgBox("Pls fill all the info")
        Else
            Label2.Text = "Количество на складе: "
            tpSugar = txtTypeOfSugar.Text
            Dim querry As String = "Select Количество_сахара From Storage where Виды_сахара= '" & tpSugar & "';"
            Dim cmd As New OleDbCommand(querry, conn)
            conn.Open()
            Try
                amountSugar = cmd.ExecuteScalar().ToString
            Catch ex As Exception
                MsgBox("Username does not exist")
            End Try
            Label2.Text = Label2.Text & amountSugar
            conn.close()
        End If
    End Sub

    Private Sub cmdBuy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuy.Click
        amountSugar -= Val(txtNumber.Text)
        tpSugar = txtTypeOfSugar.Text
        Try
            conn.open()
            Dim str As String = "UPDATE Storage SET Количество_сахара=? where Виды_сахара= '" & tpSugar & "';"
            Dim cmd As New OleDbCommand(str, conn)
            cmd.Parameters.AddWithValue("Количество_сахара", amountSugar)
            cmd.ExecuteNonQuery()
            MsgBox("Data has been update")
            conn.close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub frmBuy_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "BuyersDatabaseDataSet.Buyers". При необходимости она может быть перемещена или удалена.
        Me.BuyersTableAdapter.Fill(Me.BuyersDatabaseDataSet.Buyers)

        With Me
            .Height = 195
            .Width = 343
        End With
        rdoOrganization.Checked = False
        rdoPrivatePerson.Checked = False
        pnl1.Hide()
        pnl2.Hide()
    End Sub

    Private Sub rdoOrganization_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoOrganization.CheckedChanged
        With Me
            .Height = 414
            .Width = 343
        End With
        pnl1.Visible = True
        lblOrganization.Visible = True
        txtOrganization.Visible = True
        rdoOrganization.Enabled = False
        rdoPrivatePerson.Enabled = False
    End Sub

    Private Sub rdoPrivatePerson_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoPrivatePerson.CheckedChanged
        With Me
            .Height = 414
            .Width = 343
        End With
        pnl1.Visible = True
        lblName.Text = "Введите ваше имя"
        lblOrganization.Hide()
        txtOrganization.Text = " - "
        txtOrganization.Hide()
        rdoOrganization.Enabled = False
        rdoPrivatePerson.Enabled = False
    End Sub

    Private Sub cmdFurther_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFurther.Click
        If txtOrganization.Text = "" Or txtName.Text = "" Then
            MsgBox("Введите данные", MsgBoxStyle.Critical, "")
        End If
        With Me
            .Height = 414
            .Width = 736
        End With
        pnl2.Visible = True
    End Sub
End Class