﻿Module mdlStyle
    Public Function msHover(ByVal lb As Label) As Boolean
        lb.Font = New Font(lb.Font.FontFamily, lb.Font.Size, FontStyle.Underline)
        lb.BackColor = Color.Gainsboro
        lb.ForeColor = Color.Black
    End Function

    Public Function msLeave(ByVal lb As Label) As Boolean
        lb.Font = New Font(lb.Font.FontFamily, lb.Font.Size, FontStyle.Regular)
        lb.BackColor = Color.RoyalBlue
        lb.ForeColor = Color.White
    End Function

    Public Function msHoverTitle(ByVal lb As Label) As Boolean
        lb.BackColor = Color.RoyalBlue
    End Function

    Public Function msLeaveTitle(ByVal lb As Label) As Boolean
        lb.BackColor = Color.Blue
    End Function
End Module
