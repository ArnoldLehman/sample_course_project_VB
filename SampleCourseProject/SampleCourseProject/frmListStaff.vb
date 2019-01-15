Public Class frmListStaff

    Private Sub frmLiftStaff_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "RegistrationStaffDataSet.Staff". При необходимости она может быть перемещена или удалена.
        Me.StaffTableAdapter.Fill(Me.RegistrationStaffDataSet.Staff)

    End Sub

    Private Sub cmdPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrevious.Click
        StaffBindingSource.MovePrevious()
    End Sub

    Private Sub cmdNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNext.Click
        StaffBindingSource.MoveNext()
    End Sub

    Private Sub cmdBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBack.Click
        frmMain.Show()
        Me.Close()
    End Sub
End Class