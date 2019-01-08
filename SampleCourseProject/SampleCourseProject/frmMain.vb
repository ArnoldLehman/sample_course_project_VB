Public Class frmMain
    Public authMain As Boolean
    Public access As Boolean
    Private Sub cmdBookkeeping_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBookkeeping.Click
        If authMain = False Then
            frmAutorization.Show()
            Me.Close()
            MsgBox("Авторизируйтесь", MsgBoxStyle.Information, "Проверка")
        Else
            If access = True Then
                frmBookkeeping.Show()
                Me.Hide()
            Else
                MsgBox("Доступ запрещён", MsgBoxStyle.Critical, "Запрещено")
                Exit Sub
            End If
        End If
    End Sub

    Private Sub ЗарегистрироватьToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ЗарегистрироватьToolStripMenuItem.Click
        If authMain = False Then
            frmAutorization.Show()
            Me.Close()
            MsgBox("Авторизируйтесь", MsgBoxStyle.Information, "Проверка")
        Else
            If access = True Then
                frmRegistrationPersonal.Show()
                Me.Hide()
            Else
                MsgBox("Доступ запрещён", MsgBoxStyle.Critical, "Запрещено")
                Exit Sub
            End If
        End If
    End Sub

    Private Sub АвторизироватьсяToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles АвторизироватьсяToolStripMenuItem.Click
        frmAutorization.Show()
        Me.Close()
    End Sub
End Class