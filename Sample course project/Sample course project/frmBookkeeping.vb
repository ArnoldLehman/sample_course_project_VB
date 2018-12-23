Public Class frmBookkeeping

    Private Sub TabPage1_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPage1.Enter
        If TabControl1.SelectedTab Is TabPage1 Then
            With Me
                .Width = 526
                .Height = 361
            End With
        End If
    End Sub

    Private Sub TabPage2_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPage2.Enter
        If TabControl1.SelectedTab Is TabPage2 Then
            With Me
                .Width = 447
                .Height = 337
            End With
        End If
    End Sub

    Private Sub TabPage3_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPage3.Enter
        If TabControl1.SelectedTab Is TabPage3 Then
            With Me
                .Width = 447
                .Height = 337
            End With
        End If
    End Sub
End Class
