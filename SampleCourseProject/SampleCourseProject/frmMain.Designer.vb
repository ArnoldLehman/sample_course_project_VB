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
        Me.cmdBookkeeping = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.msMenu = New System.Windows.Forms.MenuStrip
        Me.ПерсоналToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ЗарегистрироватьToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.АвторизироватьсяToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.tscmdExit = New System.Windows.Forms.ToolStripButton
        Me.tslblAccount = New System.Windows.Forms.ToolStripLabel
        Me.lblShow = New System.Windows.Forms.Label
        Me.tmrShow = New System.Windows.Forms.Timer(Me.components)
        Me.tmrHide = New System.Windows.Forms.Timer(Me.components)
        Me.lblHide = New System.Windows.Forms.Label
        Me.msMenu.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdBookkeeping
        '
        Me.cmdBookkeeping.Location = New System.Drawing.Point(0, 177)
        Me.cmdBookkeeping.Name = "cmdBookkeeping"
        Me.cmdBookkeeping.Size = New System.Drawing.Size(275, 77)
        Me.cmdBookkeeping.TabIndex = 0
        Me.cmdBookkeeping.Text = "Бухгалтерия"
        Me.cmdBookkeeping.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.Location = New System.Drawing.Point(-3, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 20)
        Me.Label3.TabIndex = 10
        '
        'msMenu
        '
        Me.msMenu.AutoSize = False
        Me.msMenu.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.msMenu.Dock = System.Windows.Forms.DockStyle.Right
        Me.msMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ПерсоналToolStripMenuItem})
        Me.msMenu.Location = New System.Drawing.Point(275, 0)
        Me.msMenu.Name = "msMenu"
        Me.msMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.msMenu.Size = New System.Drawing.Size(0, 253)
        Me.msMenu.TabIndex = 11
        Me.msMenu.Text = "MenuStrip1"
        '
        'ПерсоналToolStripMenuItem
        '
        Me.ПерсоналToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ЗарегистрироватьToolStripMenuItem, Me.АвторизироватьсяToolStripMenuItem})
        Me.ПерсоналToolStripMenuItem.Name = "ПерсоналToolStripMenuItem"
        Me.ПерсоналToolStripMenuItem.Size = New System.Drawing.Size(0, 19)
        Me.ПерсоналToolStripMenuItem.Text = "Персонал"
        '
        'ЗарегистрироватьToolStripMenuItem
        '
        Me.ЗарегистрироватьToolStripMenuItem.Image = CType(resources.GetObject("ЗарегистрироватьToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ЗарегистрироватьToolStripMenuItem.Name = "ЗарегистрироватьToolStripMenuItem"
        Me.ЗарегистрироватьToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.ЗарегистрироватьToolStripMenuItem.Text = "Зарегистрировать"
        '
        'АвторизироватьсяToolStripMenuItem
        '
        Me.АвторизироватьсяToolStripMenuItem.Image = CType(resources.GetObject("АвторизироватьсяToolStripMenuItem.Image"), System.Drawing.Image)
        Me.АвторизироватьсяToolStripMenuItem.Name = "АвторизироватьсяToolStripMenuItem"
        Me.АвторизироватьсяToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.АвторизироватьсяToolStripMenuItem.Text = "Авторизироваться"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tscmdExit, Me.tslblAccount})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ToolStrip1.Size = New System.Drawing.Size(275, 25)
        Me.ToolStrip1.TabIndex = 12
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tscmdExit
        '
        Me.tscmdExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tscmdExit.Image = CType(resources.GetObject("tscmdExit.Image"), System.Drawing.Image)
        Me.tscmdExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tscmdExit.Name = "tscmdExit"
        Me.tscmdExit.Size = New System.Drawing.Size(23, 22)
        Me.tscmdExit.Text = "Выход"
        '
        'tslblAccount
        '
        Me.tslblAccount.Name = "tslblAccount"
        Me.tslblAccount.Size = New System.Drawing.Size(37, 22)
        Me.tslblAccount.Text = "Гость"
        '
        'lblShow
        '
        Me.lblShow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblShow.Image = CType(resources.GetObject("lblShow.Image"), System.Drawing.Image)
        Me.lblShow.Location = New System.Drawing.Point(245, 78)
        Me.lblShow.Name = "lblShow"
        Me.lblShow.Size = New System.Drawing.Size(30, 20)
        Me.lblShow.TabIndex = 13
        '
        'tmrShow
        '
        '
        'tmrHide
        '
        '
        'lblHide
        '
        Me.lblHide.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblHide.Image = CType(resources.GetObject("lblHide.Image"), System.Drawing.Image)
        Me.lblHide.Location = New System.Drawing.Point(145, 78)
        Me.lblHide.Name = "lblHide"
        Me.lblHide.Size = New System.Drawing.Size(30, 20)
        Me.lblHide.TabIndex = 14
        Me.lblHide.Visible = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(275, 253)
        Me.Controls.Add(Me.lblHide)
        Me.Controls.Add(Me.lblShow)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.msMenu)
        Me.Controls.Add(Me.cmdBookkeeping)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.msMenu
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Главная"
        Me.msMenu.ResumeLayout(False)
        Me.msMenu.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdBookkeeping As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents msMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents ПерсоналToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ЗарегистрироватьToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents АвторизироватьсяToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tslblAccount As System.Windows.Forms.ToolStripLabel
    Friend WithEvents lblShow As System.Windows.Forms.Label
    Friend WithEvents tmrShow As System.Windows.Forms.Timer
    Friend WithEvents tmrHide As System.Windows.Forms.Timer
    Friend WithEvents tscmdExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblHide As System.Windows.Forms.Label
End Class
