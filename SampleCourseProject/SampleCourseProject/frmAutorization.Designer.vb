<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAutorization
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAutorization))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtLogin = New System.Windows.Forms.TextBox
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.cmdAutorization = New System.Windows.Forms.Button
        Me.cmdBack = New System.Windows.Forms.Button
        Me.tmrAutorization = New System.Windows.Forms.Timer(Me.components)
        Me.lblVisible = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Логин"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Пароль"
        '
        'txtLogin
        '
        Me.txtLogin.Location = New System.Drawing.Point(57, 17)
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Size = New System.Drawing.Size(175, 20)
        Me.txtLogin.TabIndex = 2
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(57, 43)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(175, 20)
        Me.txtPassword.TabIndex = 3
        '
        'cmdAutorization
        '
        Me.cmdAutorization.Location = New System.Drawing.Point(117, 69)
        Me.cmdAutorization.Name = "cmdAutorization"
        Me.cmdAutorization.Size = New System.Drawing.Size(115, 23)
        Me.cmdAutorization.TabIndex = 4
        Me.cmdAutorization.Text = "Авторизироваться"
        Me.cmdAutorization.UseVisualStyleBackColor = True
        '
        'cmdBack
        '
        Me.cmdBack.Location = New System.Drawing.Point(57, 69)
        Me.cmdBack.Name = "cmdBack"
        Me.cmdBack.Size = New System.Drawing.Size(54, 23)
        Me.cmdBack.TabIndex = 5
        Me.cmdBack.Text = "Назад"
        Me.cmdBack.UseVisualStyleBackColor = True
        '
        'lblVisible
        '
        Me.lblVisible.Image = CType(resources.GetObject("lblVisible.Image"), System.Drawing.Image)
        Me.lblVisible.Location = New System.Drawing.Point(238, 43)
        Me.lblVisible.Name = "lblVisible"
        Me.lblVisible.Size = New System.Drawing.Size(33, 20)
        Me.lblVisible.TabIndex = 9
        Me.lblVisible.Text = "            "
        '
        'frmAutorization
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(279, 100)
        Me.Controls.Add(Me.lblVisible)
        Me.Controls.Add(Me.cmdBack)
        Me.Controls.Add(Me.cmdAutorization)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtLogin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmAutorization"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Авторизация"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtLogin As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents cmdAutorization As System.Windows.Forms.Button
    Friend WithEvents cmdBack As System.Windows.Forms.Button
    Friend WithEvents tmrAutorization As System.Windows.Forms.Timer
    Friend WithEvents lblVisible As System.Windows.Forms.Label
End Class
