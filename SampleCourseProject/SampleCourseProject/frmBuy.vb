Imports System.Data.OleDb
Imports System.Data

Public Class frmBuy
    Dim dbsource As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\StorageDatabase.mdb"
    Dim conn = New OleDbConnection(dbsource)

    Dim amountSugar As String = ""
    Dim tpSugar As String = ""

    Dim Income As Integer

    Private Sub frmBuy_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frmTest.Show()
    End Sub

    Private Sub cmdBuy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuy.Click
        amountSugar -= Val(txtNumber.Text)
        tpSugar = cboTypeOfSugar.Text
        Try
            conn.open()
            Dim str As String = "UPDATE Storage SET Количество=? where Виды= '" & tpSugar & "';"
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
        With txtOrganization
            .Text = " - "
            .ReadOnly = True
        End With
        rdoOrganization.Enabled = False
        rdoPrivatePerson.Enabled = False


    End Sub

    Private Sub cmdFurther_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFurther.Click
        If txtOrganization.Text = "" Or txtName.Text = "" Then
            MsgBox("Введите данные", MsgBoxStyle.Critical, "")
            Exit Sub
        End If
        With Me
            .Height = 416
            .Width = 511
        End With
        pnl2.Visible = True
        cmdFurther.Hide()
    End Sub

    Private Sub cboTypeOfSugar_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTypeOfSugar.SelectedIndexChanged
        lblNumberOnStorage.Text = "Количество на складе: "
        tpSugar = cboTypeOfSugar.Text
        Try
            Dim querry As String = "Select Количество From Storage where Виды= '" & tpSugar & "';"
            Dim cmd As New OleDbCommand(querry, conn)
            conn.Open()

            amountSugar = cmd.ExecuteScalar().ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        lblNumberOnStorage.Text = lblNumberOnStorage.Text & amountSugar & " тонн"
        conn.close()


        If cboTypeOfSugar.SelectedIndex = 0 Then
            Income = 32 * 1000
        End If
    End Sub

    Private Sub txtNumber_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNumber.Leave
        txtSumm.Text = Income * Val(txtNumber.Text)
    End Sub
End Class