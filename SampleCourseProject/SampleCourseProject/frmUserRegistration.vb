Imports System.Data.OleDb
Imports System.Data

Public Class frmUserCreateAccount

    Private Sub cmdCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCreate.Click
        If txtLoginCreate.Text = "" Or txtPasswordCreate.Text = "" Or txtConfirmPassword.Text = "" Then
            MsgBox("plz fill the info")
        Else
            Try
                Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\UserAccount.mdb")
                Dim insert As String = "Insert into Account values('" & txtLoginCreate.Text & "','" & txtPasswordCreate.Text & "');"
                Dim cmd As New OleDbCommand(insert, conn)
                conn.Open()
                cmd.ExecuteNonQuery()
                MsgBox("create success")
                Me.Close()
            Catch ex As Exception
                MsgBox("Error")
            End Try
        End If
    End Sub

    Private Sub frmUserCreateAccount_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frmUserLogin.Show()
    End Sub
End Class