Imports System.Data.OleDb
Imports System.Data

Public Class frmUserLogin
    Dim kol As Integer = 0
    'Подключение к базе данных аккаунтов, проверка на наличие записи, и, в зависимости от уровня доступа аккаунта, предоставление доступа к другим формам
    'Уровень доступа "Пользователь" имеет ограниченные возможности (просмотр главной формы и переход к форме "Купить")
    'Уровень доступа "Администратор" имеет возможности переходить на формы "Бухгалтерия", "Склад" и "Покупатели", и изменять информацию, хранимую в базе
    Private Sub cmdLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLogin.Click
        Dim uname As String = ""
        Dim pword As String
        Dim pass As String = ""
        If txtLogin.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Проверьте, все ли поля заполнены", MsgBoxStyle.Exclamation, "Вход")
            kol += 1
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
                MessageBox.Show("Авторизация прошла успешно", "Авторизация")
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
                kol += 1
                txtLogin.Clear()
                txtPassword.Clear()
                If (kol >= 3) Then
                    MsgBox("Вы превысили максимальное количество попыток входа", MsgBoxStyle.Critical, "Ввод")
                    Me.tmrBlock.Enabled = True
                    txtLogin.ReadOnly = True
                    txtPassword.ReadOnly = True
                End If
            End If
        End If
    End Sub

    'Переход на форму регистрации аккаунта
    Private Sub lnklblCreateUserAccount_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnklblCreateUserAccount.LinkClicked
        frmUserCreateAccount.Show()
        If frmUserCreateAccount.Visible Then
            Me.Hide()
        End If
    End Sub

    Private Sub frmUserLogin_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frmMain.Show()
    End Sub
    'Показ пароля
    Private Sub chkShowPass_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkShowPass.CheckedChanged
        If chkShowPass.Checked = True Then
            txtPassword.PasswordChar = ""
        ElseIf chkShowPass.Checked = False Then
            txtPassword.PasswordChar = "*"
        End If
    End Sub
    'Проверка на количество вводимых символов
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
    'Таймер, для блокироваки полей на 10 секунд
    Private Sub tmrBlock_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmrBlock.Tick
        Label3.Text = Val(Label3.Text) + 1
        If Label3.Text = "10" Then
            Label3.Text = ""
            tmrBlock.Enabled = False
            txtLogin.ReadOnly = False
            txtPassword.ReadOnly = False
            kol = 0
        End If
    End Sub
End Class