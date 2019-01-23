<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserLogin
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
        Me.cmdLogin = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtLogin = New System.Windows.Forms.TextBox
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.lnklblCreateUserAccount = New System.Windows.Forms.LinkLabel
        Me.chkShowPass = New System.Windows.Forms.CheckBox
        Me.picLogo = New System.Windows.Forms.PictureBox
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdLogin
        '
        Me.cmdLogin.Location = New System.Drawing.Point(313, 153)
        Me.cmdLogin.Name = "cmdLogin"
        Me.cmdLogin.Size = New System.Drawing.Size(114, 23)
        Me.cmdLogin.TabIndex = 3
        Me.cmdLogin.Text = "Вход"
        Me.cmdLogin.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(185, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Логин"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(185, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Пароль"
        '
        'txtLogin
        '
        Me.txtLogin.Location = New System.Drawing.Point(231, 28)
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Size = New System.Drawing.Size(196, 20)
        Me.txtLogin.TabIndex = 1
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(231, 85)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(196, 20)
        Me.txtPassword.TabIndex = 2
        '
        'lnklblCreateUserAccount
        '
        Me.lnklblCreateUserAccount.AutoSize = True
        Me.lnklblCreateUserAccount.Location = New System.Drawing.Point(185, 158)
        Me.lnklblCreateUserAccount.Name = "lnklblCreateUserAccount"
        Me.lnklblCreateUserAccount.Size = New System.Drawing.Size(113, 13)
        Me.lnklblCreateUserAccount.TabIndex = 5
        Me.lnklblCreateUserAccount.TabStop = True
        Me.lnklblCreateUserAccount.Text = "Зарегистрироваться"
        '
        'chkShowPass
        '
        Me.chkShowPass.AutoSize = True
        Me.chkShowPass.Location = New System.Drawing.Point(313, 120)
        Me.chkShowPass.Name = "chkShowPass"
        Me.chkShowPass.Size = New System.Drawing.Size(114, 17)
        Me.chkShowPass.TabIndex = 4
        Me.chkShowPass.Text = "Показать пароль"
        Me.chkShowPass.UseVisualStyleBackColor = True
        '
        'picLogo
        '
        Me.picLogo.Image = Global.SampleCourseProject.My.Resources.Resources.passwords_keys_6032__1_
        Me.picLogo.Location = New System.Drawing.Point(0, -5)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(179, 195)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLogo.TabIndex = 7
        Me.picLogo.TabStop = False
        '
        'frmUserLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 188)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.chkShowPass)
        Me.Controls.Add(Me.lnklblCreateUserAccount)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtLogin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdLogin)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUserLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Вход"
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UserBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents cmdLogin As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtLogin As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents lnklblCreateUserAccount As System.Windows.Forms.LinkLabel
    Friend WithEvents chkShowPass As System.Windows.Forms.CheckBox
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox
End Class
