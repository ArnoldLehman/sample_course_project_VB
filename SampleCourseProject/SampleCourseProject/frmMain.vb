Public Class frmMain
    Public access As Boolean = False
    Public auth As Boolean = False

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FirstImage()
    End Sub

    'Блок кода, относящийся к списку картинок
    'Изменяет картинки и текст на форме 
    Private Sub FirstImage()
        lblImage.ImageIndex = 0
        picFirstImage.Image = My.Resources.filled_circle_icon_icons_com_72757
        picSecondImage.Image = My.Resources.perfect_circle_icon_icons_com_53928
        picThirdImage.Image = My.Resources.perfect_circle_icon_icons_com_53928
        picFourthImage.Image = My.Resources.perfect_circle_icon_icons_com_53928
        lblText.Text = "Если у вас есть какие то интересные предложения, обращайтесь! Студия Web-Boss всегда готова решить любую задачу. С другой стороны укрепление и развитие структуры обеспечивает участие в формировании систем массового участия. Равным образом постоянный количественный рост и сфера нашей активности играет важную роль в формировании системы обучения кадров, соответствует насущным потребностям."
    End Sub

    Private Sub SecondImage()
        lblImage.ImageIndex = 1
        picFirstImage.Image = My.Resources.perfect_circle_icon_icons_com_53928
        picSecondImage.Image = My.Resources.filled_circle_icon_icons_com_72757
        picThirdImage.Image = My.Resources.perfect_circle_icon_icons_com_53928
        picFourthImage.Image = My.Resources.perfect_circle_icon_icons_com_53928
        lblText.Text = "Идейные соображения высшего порядка, а также рамки и место обучения кадров обеспечивает широкому кругу (специалистов) участие в формировании новых предложений. Товарищи! сложившаяся структура организации представляет собой интересный эксперимент проверки направлений прогрессивного развития."
    End Sub

    Private Sub ThirdImage()
        lblImage.ImageIndex = 2
        picFirstImage.Image = My.Resources.perfect_circle_icon_icons_com_53928
        picSecondImage.Image = My.Resources.perfect_circle_icon_icons_com_53928
        picThirdImage.Image = My.Resources.filled_circle_icon_icons_com_72757
        picFourthImage.Image = My.Resources.perfect_circle_icon_icons_com_53928
        lblText.Text = "Если у вас есть какие то интересные предложения, обращайтесь! Студия Web-Boss всегда готова решить любую задачу. Значимость этих проблем настолько очевидна, что дальнейшее развитие различных форм деятельности обеспечивает широкому кругу (специалистов) участие в формировании новых предложений."
    End Sub

    Private Sub FourthImage()
        lblImage.ImageIndex = 3
        picFirstImage.Image = My.Resources.perfect_circle_icon_icons_com_53928
        picSecondImage.Image = My.Resources.perfect_circle_icon_icons_com_53928
        picThirdImage.Image = My.Resources.perfect_circle_icon_icons_com_53928
        picFourthImage.Image = My.Resources.filled_circle_icon_icons_com_72757
        lblText.Text = "С другой стороны постоянное информационно-пропагандистское обеспечение нашей деятельности обеспечивает широкому кругу (специалистов) участие в формировании позиций, занимаемых участниками в отношении поставленных задач. Идейные соображения высшего порядка, а также укрепление и развитие структуры играет важную роль в формировании существенных финансовых и административных условий."
    End Sub

    'Изменение внешнего вида метки при наведении курсора на неё
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

    'Изменение картинки и текста в зависимости от индекса стоящей в данный момент картинки
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

    'Отображение картинок и соответсвующего текста при нажатии на картинки кружком
    Private Sub picFirstImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picFirstImage.Click
        FirstImage()
    End Sub

    Private Sub picSecondImage_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles picSecondImage.Click
        SecondImage()
    End Sub

    Private Sub picThirdImage_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles picThirdImage.Click
        ThirdImage()
    End Sub

    Private Sub picFourthImage_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles picFourthImage.Click
        FourthImage()
    End Sub




    'Изменение внешнего вида метки при наведение курсора на неё
    Private Sub lblMain_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblMain.MouseEnter
        msHoverTitle(lblMain)
    End Sub

    Private Sub lblMain_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblMain.MouseLeave
        msLeaveTitle(lblMain)
    End Sub

    Private Sub lblBookkeepingOrBuy_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblBookkeepingOrBuy.MouseEnter
        msHover(lblBookkeepingOrBuy)
    End Sub

    Private Sub lblBookkeepingOrBuy_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblBookkeepingOrBuy.MouseLeave
        msLeave(lblBookkeepingOrBuy)
    End Sub

    Private Sub lblStorage_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblStorage.MouseEnter
        msHover(lblStorage)
    End Sub

    Private Sub lblStorage_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblStorage.MouseLeave
        msLeave(lblStorage)
    End Sub

    Private Sub lblBuyers_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblBuyers.MouseEnter
        msHover(lblBuyers)
    End Sub

    Private Sub lblBuyers_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblBuyers.MouseLeave
        msLeave(lblBuyers)
    End Sub

    'Перезагружать форму при нажатии на метку "Главная" или логотип
    Private Sub lblTitle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTitle.Click
        frmMain_Load(Nothing, Nothing)
    End Sub

    Private Sub lblMain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblMain.Click
        frmMain_Load(Nothing, Nothing)
    End Sub



    Private Sub lblBookkeepingOrBuy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBookkeepingOrBuy.Click
        If auth = False Then
            frmUserLogin.Show()
        Else
            If access = True Then
                frmBookkeeping.Show()
                Me.Hide()
            Else
                frmBuy.Show()
                Me.Hide()
            End If
        End If
    End Sub

    Private Sub lblStorage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblStorage.Click
        frmStorage.Show()
        Me.Hide()
    End Sub

    Private Sub lblBuyers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBuyers.Click
        frmBuyers.Show()
        Me.Hide()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblAccount.Click
        frmUserLogin.Show()
    End Sub

    Private Sub lblAccount_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblAccount.MouseEnter
        msHoverTitle(lblAccount)
    End Sub

    Private Sub lblAccount_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblAccount.MouseLeave
        msLeaveTitle(lblAccount)
    End Sub
End Class