Imports System.Data.OleDb
Imports System.Data

Public Class frmUserCreateAccount
    'Подключение к базе данных и занесение в неё логина и пароля пользователя
    Private Sub cmdCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCreate.Click
        If txtLoginCreate.Text = "" Or txtPasswordCreate.Text = "" Or txtConfirmPassword.Text = "" Then
            MsgBox("Пожалуйста, заполните все поля", MsgBoxStyle.Critical, "Ввод")
        Else
            If txtPasswordCreate.Text = txtConfirmPassword.Text Then
                Try
                    Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\UserAccount.mdb")
                    Dim insert As String = "Insert into Account values('" & txtLoginCreate.Text & "','" & txtPasswordCreate.Text & "');"
                    Dim cmd As New OleDbCommand(insert, conn)
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Аккаунт был успешно создан", "Регистрация")
                    Me.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                MsgBox("Несоответствие паролей", MsgBoxStyle.Critical, "")
            End If
        End If
    End Sub

    Private Sub frmUserCreateAccount_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frmUserLogin.Show()
    End Sub
    'Проверка на количество вводимых символов
    Private Sub txtLoginCreate_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLoginCreate.Leave
        If checksAccount(txtLoginCreate) = True Then
            Exit Sub
        Else
            MsgBox("Длина логина не должна быть меньше 3 и больше 20", MsgBoxStyle.Critical, "Ввод")
            txtLoginCreate.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub txtPasswordCreate_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPasswordCreate.Leave
        If checksAccount(txtPasswordCreate) = True Then
            Exit Sub
        Else
            MsgBox("Длина пароля не должна быть меньше 3 и больше 20", MsgBoxStyle.Critical, "Ввод")
            txtPasswordCreate.Focus()
            Exit Sub
        End If
    End Sub
End Class