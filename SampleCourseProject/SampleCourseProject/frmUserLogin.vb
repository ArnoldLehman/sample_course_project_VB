Imports System.Data.OleDb
Imports System.Data

Public Class frmUserLogin
    Private Sub cmdLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLogin.Click
        Dim uname As String = ""
        Dim pword As String
        Dim pass As String = ""
        Dim old As Point = Me.Location
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
                frmTest.auth = True
                If txtLogin.Text = "Admin" Then
                    frmTest.access = True
                    frmTest.tsmiAccount.Text = "Администратор"
                    old.X = 683
                    old.Y = 20
                    frmTest.MenuStrip1.Location = New Point(old.X, old.Y)
                    frmTest.lblBookkeepingOrBuy.Text = "Бухгалтерия"
                    frmTest.lblStorage.Visible = True
                    frmTest.lblBuyers.Visible = True
                Else
                    frmTest.access = False
                    frmTest.tsmiAccount.Text = txtLogin.Text
                    frmTest.MenuStrip1.Location = New Point(old.X, old.Y)
                    frmTest.lblBookkeepingOrBuy.Text = "Купить"
                    frmTest.lblStorage.Hide()
                    frmTest.lblBuyers.Hide()
                End If
                Me.Close()
            Else
                MsgBox("login failed")
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
        frmTest.Show()
    End Sub
End Class