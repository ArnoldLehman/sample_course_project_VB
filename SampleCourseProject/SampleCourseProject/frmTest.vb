﻿Public Class frmTest
    Public access As Boolean = False
    Public auth As Boolean = False

    Private Sub frmTest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FirstImage()
    End Sub

    'Блок кода, относящийся к списку картинок
    Private Sub FirstImage()
        lblImage.ImageIndex = 0
        lblFirstImage.Image = System.Drawing.Image.FromFile("F:\sample_course_project_VB\Image\filled-circle_icon-icons.com_72757.ico")
        lblSecondImage.Image = System.Drawing.Image.FromFile("F:\sample_course_project_VB\Image\perfect-circle_icon-icons.com_53928.ico")
        lblThirdImage.Image = System.Drawing.Image.FromFile("F:\sample_course_project_VB\Image\perfect-circle_icon-icons.com_53928.ico")
        lblFourthImage.Image = System.Drawing.Image.FromFile("F:\sample_course_project_VB\Image\perfect-circle_icon-icons.com_53928.ico")
        lblText.Text = "Если у вас есть какие то интересные предложения, обращайтесь! Студия Web-Boss всегда готова решить любую задачу. С другой стороны укрепление и развитие структуры обеспечивает участие в формировании систем массового участия. Равным образом постоянный количественный рост и сфера нашей активности играет важную роль в формировании системы обучения кадров, соответствует насущным потребностям."
    End Sub

    Private Sub SecondImage()
        lblImage.ImageIndex = 1
        lblFirstImage.Image = System.Drawing.Image.FromFile("F:\sample_course_project_VB\Image\perfect-circle_icon-icons.com_53928.ico")
        lblSecondImage.Image = System.Drawing.Image.FromFile("F:\sample_course_project_VB\Image\filled-circle_icon-icons.com_72757.ico")
        lblThirdImage.Image = System.Drawing.Image.FromFile("F:\sample_course_project_VB\Image\perfect-circle_icon-icons.com_53928.ico")
        lblFourthImage.Image = System.Drawing.Image.FromFile("F:\sample_course_project_VB\Image\perfect-circle_icon-icons.com_53928.ico")
        lblText.Text = "Идейные соображения высшего порядка, а также рамки и место обучения кадров обеспечивает широкому кругу (специалистов) участие в формировании новых предложений. Товарищи! сложившаяся структура организации представляет собой интересный эксперимент проверки направлений прогрессивного развития."
    End Sub

    Private Sub ThirdImage()
        lblImage.ImageIndex = 2
        lblFirstImage.Image = System.Drawing.Image.FromFile("F:\sample_course_project_VB\Image\perfect-circle_icon-icons.com_53928.ico")
        lblSecondImage.Image = System.Drawing.Image.FromFile("F:\sample_course_project_VB\Image\perfect-circle_icon-icons.com_53928.ico")
        lblThirdImage.Image = System.Drawing.Image.FromFile("F:\sample_course_project_VB\Image\filled-circle_icon-icons.com_72757.ico")
        lblFourthImage.Image = System.Drawing.Image.FromFile("F:\sample_course_project_VB\Image\perfect-circle_icon-icons.com_53928.ico")
        lblText.Text = "Если у вас есть какие то интересные предложения, обращайтесь! Студия Web-Boss всегда готова решить любую задачу. Значимость этих проблем настолько очевидна, что дальнейшее развитие различных форм деятельности обеспечивает широкому кругу (специалистов) участие в формировании новых предложений."
    End Sub

    Private Sub FourthImage()
        lblImage.ImageIndex = 3
        lblFirstImage.Image = System.Drawing.Image.FromFile("F:\sample_course_project_VB\Image\perfect-circle_icon-icons.com_53928.ico")
        lblSecondImage.Image = System.Drawing.Image.FromFile("F:\sample_course_project_VB\Image\perfect-circle_icon-icons.com_53928.ico")
        lblThirdImage.Image = System.Drawing.Image.FromFile("F:\sample_course_project_VB\Image\perfect-circle_icon-icons.com_53928.ico")
        lblFourthImage.Image = System.Drawing.Image.FromFile("F:\sample_course_project_VB\Image\filled-circle_icon-icons.com_72757.ico")
        lblText.Text = "С другой стороны постоянное информационно-пропагандистское обеспечение нашей деятельности обеспечивает широкому кругу (специалистов) участие в формировании позиций, занимаемых участниками в отношении поставленных задач. Идейные соображения высшего порядка, а также укрепление и развитие структуры играет важную роль в формировании существенных финансовых и административных условий."
    End Sub

    Private Sub lblBack_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblBack.MouseEnter
        lblBack.BackColor = Color.LightGray
    End Sub

    Private Sub lblBack_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblBack.MouseLeave
        lblBack.BackColor = Color.Gainsboro
    End Sub

    Private Sub lblNext_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblNext.MouseEnter
        lblNext.BackColor = Color.LightGray
    End Sub

    Private Sub lblNext_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblNext.MouseLeave
        lblNext.BackColor = Color.Gainsboro
    End Sub

    Private Sub lblNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblNext.Click
        If lblImage.ImageIndex = 0 Then
            SecondImage()
            Exit Sub
        End If
        If lblImage.ImageIndex = 1 Then
            ThirdImage()
            Exit Sub
        End If
        If lblImage.ImageIndex = 2 Then
            FourthImage()
            Exit Sub
        End If
        If lblImage.ImageIndex = 3 Then
            FirstImage()
            Exit Sub
        End If
    End Sub

    Private Sub lblBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBack.Click
        If lblImage.ImageIndex = 3 Then
            ThirdImage()
            Exit Sub
        End If
        If lblImage.ImageIndex = 2 Then
            SecondImage()
            Exit Sub
        End If
        If lblImage.ImageIndex = 1 Then
            FirstImage()
            Exit Sub
        End If
        If lblImage.ImageIndex = 0 Then
            FourthImage()
            Exit Sub
        End If
    End Sub

    Private Sub lblFirstImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFirstImage.Click
        FirstImage()
    End Sub

    Private Sub lblSecondImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblSecondImage.Click
        SecondImage()
    End Sub

    Private Sub lblThirdImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblThirdImage.Click
        ThirdImage()
    End Sub

    Private Sub lblFourthImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFourthImage.Click
        FourthImage()
    End Sub







    'Блок кода, относящийся к шапке 


    Private Sub lblMain_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblMain.MouseEnter
        lblMain.BackColor = Color.RoyalBlue
    End Sub

    Private Sub lblNews_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblNews.MouseEnter
        lblNews.BackColor = Color.RoyalBlue
    End Sub

    Private Sub lblMain_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblMain.MouseLeave
        lblMain.BackColor = Color.Blue
    End Sub

    Private Sub lblNews_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblNews.MouseLeave
        lblNews.BackColor = Color.Blue
    End Sub

    Private Sub lblTitle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTitle.Click
        frmTest_Load(Nothing, Nothing)
    End Sub

    Private Sub lblMain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblMain.Click
        frmTest_Load(Nothing, Nothing)
    End Sub

    Private Sub tsmiAccount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiAccount.Click
        frmUserLogin.Show()
        Me.Close()
    End Sub

    Private Sub lblBookkeepingOrBuy_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblBookkeepingOrBuy.MouseEnter
        msHover(lblBookkeepingOrBuy)
    End Sub

    Private Sub lblBookkeepingOrBuy_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblBookkeepingOrBuy.MouseLeave
        msLeave(lblBookkeepingOrBuy)
    End Sub

    Private Sub lblStorage_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblStorageOrComp.MouseEnter
        msHover(lblStorageOrComp)
    End Sub

    Private Sub lblStorage_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblStorageOrComp.MouseLeave
        msLeave(lblStorageOrComp)
    End Sub

    Private Sub lblBookkeepingOrBuy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBookkeepingOrBuy.Click
        If access = True Then
            frmBookkeeping.Show()
            Me.Hide()
        Else
            frmBuy.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub lblStorage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblStorageOrComp.Click
        frmStorage.Show()
        Me.Hide()
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class