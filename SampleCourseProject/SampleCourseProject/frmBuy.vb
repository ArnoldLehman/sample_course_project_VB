Imports System.Data.OleDb
Imports System.Data

Public Class frmBuy
    Dim dbsource As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\StorageDatabase.mdb"
    Dim conn = New OleDbConnection(dbsource)

    Dim amountSugar As String = ""
    Dim tpSugar As String = ""

    Dim Cost As Integer

    Private Sub frmBuy_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frmMain.Show()
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


            Dim buy As DialogResult
            BuyersBindingSource.EndEdit()
            BuyersTableAdapter.Update(BuyersDatabaseDataSet.Buyers)
            MessageBox.Show("Ваш заказ отправлен на обработку" & vbNewLine & "В ближайшее время с вами свяжутся для уточнения деталей", "Купить", MessageBoxButtons.OK, MessageBoxIcon.Information)

            buy = MessageBox.Show("Хотите сделать ещё один заказ?", "Купить", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button1)
            If buy = Windows.Forms.DialogResult.Yes Then
                BuyersBindingSource.AddNew()
                txtOrganization.Text = " - "
                lblNumberOnStorage.Text = "Количество на складе: "
            Else
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmBuy_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "BuyersDatabaseDataSet.Buyers". При необходимости она может быть перемещена или удалена.
        Me.BuyersTableAdapter.Fill(Me.BuyersDatabaseDataSet.Buyers)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "StorageDatabaseDataSet.Storage". При необходимости она может быть перемещена или удалена.
        Me.StorageTableAdapter.Fill(Me.StorageDatabaseDataSet.Storage)
        BuyersBindingSource.AddNew()
        lblNumberOnStorage.Text = "Количество на складе: "

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
            .Height = 386
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
            .Height = 386
            .Width = 343
        End With
        pnl1.Visible = True
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
            .Height = 349
            .Width = 511
        End With
        pnl2.Visible = True
        cmdFurther.Hide()
    End Sub

    Private Sub cboTypeOfSugar_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTypeOfSugar.SelectedIndexChanged
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
            Cost = 93 * 1000
        ElseIf cboTypeOfSugar.SelectedIndex = 1 Then
            Cost = 119 * 1000
        ElseIf cboTypeOfSugar.SelectedIndex = 2 Then
            Cost = 263 * 1000
        ElseIf cboTypeOfSugar.SelectedIndex = 3 Then
            Cost = 130 * 1000
        ElseIf cboTypeOfSugar.SelectedIndex = 4 Then
            Cost = 256 * 1000
        ElseIf cboTypeOfSugar.SelectedIndex = 5 Then
            Cost = 2.6 * 1000
        ElseIf cboTypeOfSugar.SelectedIndex = 6 Then
            Cost = 12.5 * 1000
        End If
    End Sub

    Private Sub txtNumber_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNumber.Leave
        txtSumm.Text = Cost * Val(txtNumber.Text)
    End Sub

    Private Sub lblMain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblMain.Click
        frmMain.Show()
        Me.Close()
    End Sub

    Private Sub lblMain_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblMain.MouseEnter
        msHoverTitle(lblMain)
    End Sub

    Private Sub lblMain_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblMain.MouseLeave
        msLeaveTitle(lblMain)
    End Sub
End Class