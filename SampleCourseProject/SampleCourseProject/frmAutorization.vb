Public Class frmAutorization

    Private Sub frmAutorization_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtPassword.PasswordChar = "*"
    End Sub

    Private Sub lblVisible_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblVisible.MouseEnter
        txtPassword.PasswordChar = ""
    End Sub

    Private Sub lblVisible_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblVisible.MouseLeave
        txtPassword.PasswordChar = "*"
    End Sub

    Private Sub cmdBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBack.Click
        frmMain.Show()
        Me.Close()
    End Sub

    Private Sub cmdAutorization_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAutorization.Click
        If My.Settings.LoginUser = txtLogin.Text And My.Settings.PasswordUser = txtPassword.Text Then
            frmMain.authMain = True
            frmMain.access = False
            frmMain.Show()
            Me.Close()
        ElseIf My.Settings.LoginAdmin = txtLogin.Text And My.Settings.PasswordAdmin = txtPassword.Text Then
            frmMain.authMain = True
            frmMain.access = True
            frmMain.Show()
            Me.Close()
        End If
    End Sub
End Class