Public Class frmRegistrationPersonal

    Private Sub cmdREgistration_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRegistration.Click
        StaffBindingSource.EndEdit()
        StaffTableAdapter.Update(RegistrationStaffDataSet.Staff)
    End Sub

    Private Sub txtPastEmployment_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPastEmployment.Enter
        txtPastEmployment.Height = 40
    End Sub

    Private Sub txtPastEmployment_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPastEmployment.Leave
        txtPastEmployment.Height = 20
    End Sub

    Private Sub frmRegistrationPersonal_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "RegistrationStaffDataSet.Staff". При необходимости она может быть перемещена или удалена.
        Me.StaffTableAdapter.Fill(Me.RegistrationStaffDataSet.Staff)
        StaffBindingSource.AddNew()
        cboGender.Items.Add("Мужской")
        cboGender.Items.Add("Женский")
    End Sub

    Private Sub cmdBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBack.Click
        frmMain.Show()
        Me.Close()
    End Sub
End Class