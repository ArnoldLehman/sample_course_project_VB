Module mdlChecks
    Public Function checksWord(ByVal txt As TextBox) As Boolean
        Dim simvol As String
        For i = 1 To Len(txt.Text)
            simvol = Mid(txt.Text, i, 1)

            If (simvol Like "[a-zA-Z]") Or (simvol Like "[а-яА-Я]") Then
                checksWord = True
            Else
                checksWord = False
            End If
        Next
    End Function

    Public Function checksNumber(ByVal txt As TextBox) As Boolean
        Dim simvol As String
        For i = 1 To Len(txt.Text)
            simvol = Mid(txt.Text, i, 1)

            If IsNumeric(simvol) Then
                checksNumber = True
            Else
                checksNumber = False
            End If
        Next
    End Function

    Public Function checksAccount(ByVal txt As TextBox) As Boolean
        Dim ln As Integer = Len(txt.Text)

        If (ln >= 3 And ln <= 20) Or ln = 0 Then
            checksAccount = True
        Else
            checksAccount = False
        End If
    End Function
End Module
