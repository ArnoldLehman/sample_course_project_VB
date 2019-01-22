<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblAccount = New System.Windows.Forms.Label
        Me.lblTitle = New System.Windows.Forms.Label
        Me.lblMain = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.lblImage = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.lblBuyers = New System.Windows.Forms.Label
        Me.lblStorage = New System.Windows.Forms.Label
        Me.lblBookkeepingOrBuy = New System.Windows.Forms.Label
        Me.lblText = New System.Windows.Forms.Label
        Me.picFourthImage = New System.Windows.Forms.PictureBox
        Me.picThirdImage = New System.Windows.Forms.PictureBox
        Me.picFirstImage = New System.Windows.Forms.PictureBox
        Me.picSecondImage = New System.Windows.Forms.PictureBox
        Me.lblBack = New System.Windows.Forms.Label
        Me.lblNext = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.picFourthImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picThirdImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFirstImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSecondImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Blue
        Me.Panel1.Controls.Add(Me.lblAccount)
        Me.Panel1.Controls.Add(Me.lblTitle)
        Me.Panel1.Controls.Add(Me.lblMain)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(816, 64)
        Me.Panel1.TabIndex = 0
        '
        'lblAccount
        '
        Me.lblAccount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblAccount.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblAccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblAccount.ForeColor = System.Drawing.Color.White
        Me.lblAccount.Location = New System.Drawing.Point(649, 0)
        Me.lblAccount.Name = "lblAccount"
        Me.lblAccount.Size = New System.Drawing.Size(167, 64)
        Me.lblAccount.TabIndex = 6
        Me.lblAccount.Text = "Гость"
        Me.lblAccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Blue
        Me.lblTitle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(-3, 0)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(25, 0, 3, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Padding = New System.Windows.Forms.Padding(35, 0, 35, 0)
        Me.lblTitle.Size = New System.Drawing.Size(178, 64)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "SugProd"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.lblTitle, "Sugar Production")
        '
        'lblMain
        '
        Me.lblMain.BackColor = System.Drawing.Color.Blue
        Me.lblMain.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblMain.ForeColor = System.Drawing.Color.White
        Me.lblMain.Location = New System.Drawing.Point(175, 0)
        Me.lblMain.Name = "lblMain"
        Me.lblMain.Size = New System.Drawing.Size(100, 64)
        Me.lblMain.TabIndex = 2
        Me.lblMain.Text = "Главная"
        Me.lblMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "254.jpg")
        Me.ImageList1.Images.SetKeyName(1, "0037460126347236-41263746182340213-263741276342-234723764927364saXaP333.jpg")
        Me.ImageList1.Images.SetKeyName(2, "thmb-2014-08-12-09h42m24s46-660x330.jpg")
        Me.ImageList1.Images.SetKeyName(3, "8a8efac9a0e10f9b2021e3485e6e2df7.jpg")
        '
        'lblImage
        '
        Me.lblImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblImage.ImageList = Me.ImageList1
        Me.lblImage.Location = New System.Drawing.Point(483, 78)
        Me.lblImage.Name = "lblImage"
        Me.lblImage.Size = New System.Drawing.Size(256, 256)
        Me.lblImage.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel2.Controls.Add(Me.lblBuyers)
        Me.Panel2.Controls.Add(Me.lblStorage)
        Me.Panel2.Controls.Add(Me.lblBookkeepingOrBuy)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 64)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(123, 345)
        Me.Panel2.TabIndex = 13
        '
        'lblBuyers
        '
        Me.lblBuyers.BackColor = System.Drawing.Color.RoyalBlue
        Me.lblBuyers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblBuyers.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblBuyers.ForeColor = System.Drawing.Color.White
        Me.lblBuyers.Location = New System.Drawing.Point(-9, 71)
        Me.lblBuyers.Name = "lblBuyers"
        Me.lblBuyers.Size = New System.Drawing.Size(132, 36)
        Me.lblBuyers.TabIndex = 17
        Me.lblBuyers.Text = "Покупатели"
        Me.lblBuyers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblBuyers.Visible = False
        '
        'lblStorage
        '
        Me.lblStorage.BackColor = System.Drawing.Color.RoyalBlue
        Me.lblStorage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblStorage.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblStorage.ForeColor = System.Drawing.Color.White
        Me.lblStorage.Location = New System.Drawing.Point(-9, 35)
        Me.lblStorage.Name = "lblStorage"
        Me.lblStorage.Size = New System.Drawing.Size(132, 36)
        Me.lblStorage.TabIndex = 16
        Me.lblStorage.Text = "Склад"
        Me.lblStorage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblStorage.Visible = False
        '
        'lblBookkeepingOrBuy
        '
        Me.lblBookkeepingOrBuy.BackColor = System.Drawing.Color.RoyalBlue
        Me.lblBookkeepingOrBuy.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblBookkeepingOrBuy.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblBookkeepingOrBuy.ForeColor = System.Drawing.Color.White
        Me.lblBookkeepingOrBuy.Location = New System.Drawing.Point(-9, -1)
        Me.lblBookkeepingOrBuy.Name = "lblBookkeepingOrBuy"
        Me.lblBookkeepingOrBuy.Size = New System.Drawing.Size(132, 36)
        Me.lblBookkeepingOrBuy.TabIndex = 14
        Me.lblBookkeepingOrBuy.Text = "Купить"
        Me.lblBookkeepingOrBuy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblText
        '
        Me.lblText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblText.Location = New System.Drawing.Point(140, 78)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(291, 256)
        Me.lblText.TabIndex = 14
        Me.lblText.Text = resources.GetString("lblText.Text")
        Me.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picFourthImage
        '
        Me.picFourthImage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picFourthImage.Image = CType(resources.GetObject("picFourthImage.Image"), System.Drawing.Image)
        Me.picFourthImage.Location = New System.Drawing.Point(689, 337)
        Me.picFourthImage.Name = "picFourthImage"
        Me.picFourthImage.Size = New System.Drawing.Size(50, 50)
        Me.picFourthImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picFourthImage.TabIndex = 18
        Me.picFourthImage.TabStop = False
        '
        'picThirdImage
        '
        Me.picThirdImage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picThirdImage.Image = CType(resources.GetObject("picThirdImage.Image"), System.Drawing.Image)
        Me.picThirdImage.Location = New System.Drawing.Point(621, 337)
        Me.picThirdImage.Name = "picThirdImage"
        Me.picThirdImage.Size = New System.Drawing.Size(50, 50)
        Me.picThirdImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picThirdImage.TabIndex = 17
        Me.picThirdImage.TabStop = False
        '
        'picFirstImage
        '
        Me.picFirstImage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picFirstImage.Image = Global.SampleCourseProject.My.Resources.Resources.perfect_circle_icon_icons_com_53928
        Me.picFirstImage.Location = New System.Drawing.Point(483, 337)
        Me.picFirstImage.Name = "picFirstImage"
        Me.picFirstImage.Size = New System.Drawing.Size(50, 50)
        Me.picFirstImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picFirstImage.TabIndex = 16
        Me.picFirstImage.TabStop = False
        '
        'picSecondImage
        '
        Me.picSecondImage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picSecondImage.Image = CType(resources.GetObject("picSecondImage.Image"), System.Drawing.Image)
        Me.picSecondImage.Location = New System.Drawing.Point(552, 337)
        Me.picSecondImage.Name = "picSecondImage"
        Me.picSecondImage.Size = New System.Drawing.Size(50, 50)
        Me.picSecondImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picSecondImage.TabIndex = 15
        Me.picSecondImage.TabStop = False
        '
        'lblBack
        '
        Me.lblBack.BackColor = System.Drawing.Color.Gainsboro
        Me.lblBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblBack.Image = Global.SampleCourseProject.My.Resources.Resources.ios7_arrow_thin_left_icon_icons_com_50347
        Me.lblBack.Location = New System.Drawing.Point(437, 78)
        Me.lblBack.Name = "lblBack"
        Me.lblBack.Size = New System.Drawing.Size(46, 256)
        Me.lblBack.TabIndex = 8
        '
        'lblNext
        '
        Me.lblNext.BackColor = System.Drawing.Color.Gainsboro
        Me.lblNext.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblNext.Image = Global.SampleCourseProject.My.Resources.Resources.ios7_arrow_thin_right_icon_icons_com_50346
        Me.lblNext.Location = New System.Drawing.Point(739, 78)
        Me.lblNext.Name = "lblNext"
        Me.lblNext.Size = New System.Drawing.Size(46, 256)
        Me.lblNext.TabIndex = 7
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(816, 409)
        Me.Controls.Add(Me.picFourthImage)
        Me.Controls.Add(Me.picThirdImage)
        Me.Controls.Add(Me.picFirstImage)
        Me.Controls.Add(Me.picSecondImage)
        Me.Controls.Add(Me.lblText)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.lblBack)
        Me.Controls.Add(Me.lblNext)
        Me.Controls.Add(Me.lblImage)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Главная"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.picFourthImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picThirdImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFirstImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSecondImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblMain As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents lblImage As System.Windows.Forms.Label
    Friend WithEvents lblNext As System.Windows.Forms.Label
    Friend WithEvents lblBack As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblBookkeepingOrBuy As System.Windows.Forms.Label
    Friend WithEvents lblText As System.Windows.Forms.Label
    Friend WithEvents lblStorage As System.Windows.Forms.Label
    Friend WithEvents lblBuyers As System.Windows.Forms.Label
    Friend WithEvents lblAccount As System.Windows.Forms.Label
    Friend WithEvents picSecondImage As System.Windows.Forms.PictureBox
    Friend WithEvents picFirstImage As System.Windows.Forms.PictureBox
    Friend WithEvents picThirdImage As System.Windows.Forms.PictureBox
    Friend WithEvents picFourthImage As System.Windows.Forms.PictureBox
End Class
