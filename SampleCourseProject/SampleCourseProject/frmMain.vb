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

    Private Sub tmrShow_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmrShow.Tick
        msMenu.Width += 20
        cmdBookkeeping.Width -= 20
        If msMenu.Width >= 100 Then
            tmrShow.Stop()
            lblHide.Show()
        End If
    End Sub

    Private Sub tmrHide_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmrHide.Tick
        msMenu.Width -= 20
        cmdBookkeeping.Width += 20
        If msMenu.Width <= 0 Then
            tmrHide.Stop()
            lblShow.Show()
        End If
    End Sub

    Private Sub tscmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tscmdExit.Click
        End
    End Sub

    Private Sub tslblAccount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tslblAccount.Click
        If authMain = False Then
            frmAutorization.Show()
            Me.Close()
            MsgBox("Авторизируйтесь", MsgBoxStyle.Information, "Проверка")
        Else
            If access = True Then
                Exit Sub
            End If
        End If
    End Sub

    Private Sub lblShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblShow.Click
        lblShow.Hide()
        tmrShow.Start()
    End Sub

    Private Sub lblHide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblHide.Click
        lblHide.Hide()
        tmrHide.Start()
    End Sub
End Class