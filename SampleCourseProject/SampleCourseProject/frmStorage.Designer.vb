<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStorage
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.DkdkdToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AsdfToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AsdfToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.RrrrToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RrrrrToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DkdkdToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(466, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DkdkdToolStripMenuItem
        '
        Me.DkdkdToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AsdfToolStripMenuItem, Me.AsdfToolStripMenuItem1, Me.RrrrToolStripMenuItem, Me.RrrrrToolStripMenuItem})
        Me.DkdkdToolStripMenuItem.Name = "DkdkdToolStripMenuItem"
        Me.DkdkdToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.DkdkdToolStripMenuItem.Text = "Dkdkd"
        '
        'AsdfToolStripMenuItem
        '
        Me.AsdfToolStripMenuItem.Name = "AsdfToolStripMenuItem"
        Me.AsdfToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AsdfToolStripMenuItem.Text = "asdf"
        Me.AsdfToolStripMenuItem.Visible = False
        '
        'AsdfToolStripMenuItem1
        '
        Me.AsdfToolStripMenuItem1.Name = "AsdfToolStripMenuItem1"
        Me.AsdfToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.AsdfToolStripMenuItem1.Text = "asdf"
        '
        'RrrrToolStripMenuItem
        '
        Me.RrrrToolStripMenuItem.Name = "RrrrToolStripMenuItem"
        Me.RrrrToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.RrrrToolStripMenuItem.Text = "rrrr"
        '
        'RrrrrToolStripMenuItem
        '
        Me.RrrrrToolStripMenuItem.Name = "RrrrrToolStripMenuItem"
        Me.RrrrrToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.RrrrrToolStripMenuItem.Text = "rrrrr"
        '
        'frmStorage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(466, 335)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmStorage"
        Me.Text = "frmStorage"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DkdkdToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AsdfToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AsdfToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RrrrToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RrrrrToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
