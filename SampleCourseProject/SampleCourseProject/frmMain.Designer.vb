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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.cmdBookkeeping = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.ПерсоналToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ЗарегистрироватьToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.АвторизироватьсяToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
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
        Me.Label3.Location = New System.Drawing.Point(21, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 20)
        Me.Label3.TabIndex = 10
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ПерсоналToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(275, 24)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ПерсоналToolStripMenuItem
        '
        Me.ПерсоналToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ЗарегистрироватьToolStripMenuItem, Me.АвторизироватьсяToolStripMenuItem})
        Me.ПерсоналToolStripMenuItem.Name = "ПерсоналToolStripMenuItem"
        Me.ПерсоналToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
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
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(275, 253)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.cmdBookkeeping)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Главная"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdBookkeeping As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ПерсоналToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ЗарегистрироватьToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents АвторизироватьсяToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
