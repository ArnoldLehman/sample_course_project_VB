Imports System.Data.OleDb
Imports System.Data

Public Class frmUserLogin
    Private Sub cmdLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLogin.Click
        Dim uname As String = ""
        Dim pword As String
        Dim pass As String = ""
        If txtLogin.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Проверьте, все ли поля заполнены корректно", MsgBoxStyle.Exclamation, "Вход")
        Else
            uname = txtLogin.Text
            pword = txtPassword.Text
            Dim querry As String = "Select password From Account where login= '" & uname & "';"
            Dim dbsource As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\UserAccount.mdb"
            Dim conn = New OleDbConnection(dbsource)
            Dim cmd As New OleDbCommand(querry, conn)
            conn.Open()
            Try
                pass = cmd.ExecuteScalar().ToString
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            If pword = pass Then
                MsgBox("Login success")
                frmMain.auth = True
                If txtLogin.Text = "Admin" Then
                    frmMain.access = True
                    frmMain.lblAccount.Text = "Администратор"
                    frmMain.lblBookkeepingOrBuy.Text = "Бухгалтерия"
                    frmMain.lblStorage.Visible = True
                    frmMain.lblBuyers.Visible = True
                Else
                    frmMain.access = False
                    frmMain.lblAccount.Text = txtLogin.Text
                    frmMain.lblBookkeepingOrBuy.Text = "Купить"
                    frmMain.lblStorage.Hide()
                    frmMain.lblBuyers.Hide()
                End If
                Me.Close()
            Else
                txtLogin.Clear()
                txtPassword.Clear()
            End If
        End If
    End Sub

    Private Sub lnklblCreateUserAccount_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnklblCreateUserAccount.LinkClicked
        frmUserCreateAccount.Show()
        If frmUserCreateAccount.Visible Then
            Me.Hide()
        End If
    End Sub

    Private Sub frmUserLogin_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frmMain.Show()
    End Sub

    Private Sub chkShowPass_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkShowPass.CheckedChanged
        If chkShowPass.Checked = True Then
            txtPassword.PasswordChar = ""
        ElseIf chkShowPass.Checked = False Then
            txtPassword.PasswordChar = "*"
        End If
    End Sub

    Private Sub txtLogin_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLogin.Leave
        If checksAccount(txtLogin) = True Then
            Exit Sub
        Else
            MsgBox("Длина логина не должна быть меньше 3 и больше 20", MsgBoxStyle.Critical, "Ввод")
            txtLogin.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub txtPassword_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPassword.Leave
        If checksAccount(txtPassword) = True Then
            Exit Sub
        Else
            MsgBox("Длина пароля не должна быть меньше 3 и больше 20", MsgBoxStyle.Critical, "Ввод")
            txtPassword.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub frmUserLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class