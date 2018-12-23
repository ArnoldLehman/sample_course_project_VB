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
        Me.cmdBookkeeping = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'cmdBookkeeping
        '
        Me.cmdBookkeeping.Location = New System.Drawing.Point(12, 12)
        Me.cmdBookkeeping.Name = "cmdBookkeeping"
        Me.cmdBookkeeping.Size = New System.Drawing.Size(260, 80)
        Me.cmdBookkeeping.TabIndex = 0
        Me.cmdBookkeeping.Text = "Бухгалтерия"
        Me.cmdBookkeeping.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.cmdBookkeeping)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Главная"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdBookkeeping As System.Windows.Forms.Button
End Class
