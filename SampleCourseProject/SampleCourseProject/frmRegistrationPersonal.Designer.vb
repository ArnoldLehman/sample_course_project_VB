<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistrationPersonal
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cboGender = New System.Windows.Forms.ComboBox
        Me.StaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RegistrationStaffDataSet = New SampleCourseProject.RegistrationStaffDataSet
        Me.dtpDateOfBorn = New System.Windows.Forms.DateTimePicker
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtMilitaryCard = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtPatronymic = New System.Windows.Forms.TextBox
        Me.txtName = New System.Windows.Forms.TextBox
        Me.txtLastname = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtRegPlace = New System.Windows.Forms.TextBox
        Me.txtPassportNumber = New System.Windows.Forms.TextBox
        Me.txtPassportSeries = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txtPosition = New System.Windows.Forms.TextBox
        Me.txtExperience = New System.Windows.Forms.TextBox
        Me.txtPastEmployment = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.cmdRegistration = New System.Windows.Forms.Button
        Me.cmdBack = New System.Windows.Forms.Button
        Me.StaffTableAdapter = New SampleCourseProject.RegistrationStaffDataSetTableAdapters.StaffTableAdapter
        Me.GroupBox1.SuspendLayout()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegistrationStaffDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboGender)
        Me.GroupBox1.Controls.Add(Me.dtpDateOfBorn)
        Me.GroupBox1.Controls.Add(Me.txtPhoneNumber)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtMilitaryCard)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtPatronymic)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.txtLastname)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(246, 246)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Личные данные"
        '
        'cboGender
        '
        Me.cboGender.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "Пол", True))
        Me.cboGender.FormattingEnabled = True
        Me.cboGender.Location = New System.Drawing.Point(39, 140)
        Me.cboGender.Name = "cboGender"
        Me.cboGender.Size = New System.Drawing.Size(121, 21)
        Me.cboGender.TabIndex = 16
        '
        'StaffBindingSource
        '
        Me.StaffBindingSource.DataMember = "Staff"
        Me.StaffBindingSource.DataSource = Me.RegistrationStaffDataSet
        '
        'RegistrationStaffDataSet
        '
        Me.RegistrationStaffDataSet.DataSetName = "RegistrationStaffDataSet"
        Me.RegistrationStaffDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dtpDateOfBorn
        '
        Me.dtpDateOfBorn.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "Дата рождения", True))
        Me.dtpDateOfBorn.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateOfBorn.Location = New System.Drawing.Point(91, 111)
        Me.dtpDateOfBorn.Name = "dtpDateOfBorn"
        Me.dtpDateOfBorn.Size = New System.Drawing.Size(84, 20)
        Me.dtpDateOfBorn.TabIndex = 15
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "Номер телефона", True))
        Me.txtPhoneNumber.Location = New System.Drawing.Point(107, 206)
        Me.txtPhoneNumber.MaxLength = 11
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtPhoneNumber.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 209)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Номер телефона"
        '
        'txtMilitaryCard
        '
        Me.txtMilitaryCard.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "Военный билет", True))
        Me.txtMilitaryCard.Location = New System.Drawing.Point(98, 173)
        Me.txtMilitaryCard.Name = "txtMilitaryCard"
        Me.txtMilitaryCard.Size = New System.Drawing.Size(100, 20)
        Me.txtMilitaryCard.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 176)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Военный билет"
        '
        'txtPatronymic
        '
        Me.txtPatronymic.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "Отчество", True))
        Me.txtPatronymic.Location = New System.Drawing.Point(68, 80)
        Me.txtPatronymic.Name = "txtPatronymic"
        Me.txtPatronymic.Size = New System.Drawing.Size(154, 20)
        Me.txtPatronymic.TabIndex = 7
        '
        'txtName
        '
        Me.txtName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "Имя", True))
        Me.txtName.Location = New System.Drawing.Point(41, 53)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(154, 20)
        Me.txtName.TabIndex = 6
        '
        'txtLastname
        '
        Me.txtLastname.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "Фамилия", True))
        Me.txtLastname.Location = New System.Drawing.Point(68, 25)
        Me.txtLastname.Name = "txtLastname"
        Me.txtLastname.Size = New System.Drawing.Size(154, 20)
        Me.txtLastname.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 143)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Пол"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Дата рождения"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Отчество"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Имя"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Фамилия"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtRegPlace)
        Me.GroupBox2.Controls.Add(Me.txtPassportNumber)
        Me.GroupBox2.Controls.Add(Me.txtPassportSeries)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(264, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(287, 100)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Паспортные данные"
        '
        'txtRegPlace
        '
        Me.txtRegPlace.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtRegPlace.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "Прописка", True))
        Me.txtRegPlace.Location = New System.Drawing.Point(94, 51)
        Me.txtRegPlace.Multiline = True
        Me.txtRegPlace.Name = "txtRegPlace"
        Me.txtRegPlace.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRegPlace.Size = New System.Drawing.Size(187, 40)
        Me.txtRegPlace.TabIndex = 5
        '
        'txtPassportNumber
        '
        Me.txtPassportNumber.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "Паспорт номер", True))
        Me.txtPassportNumber.Location = New System.Drawing.Point(153, 25)
        Me.txtPassportNumber.MaxLength = 6
        Me.txtPassportNumber.Name = "txtPassportNumber"
        Me.txtPassportNumber.Size = New System.Drawing.Size(49, 20)
        Me.txtPassportNumber.TabIndex = 4
        '
        'txtPassportSeries
        '
        Me.txtPassportSeries.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "Паспорт серия", True))
        Me.txtPassportSeries.Location = New System.Drawing.Point(50, 24)
        Me.txtPassportSeries.MaxLength = 4
        Me.txtPassportSeries.Name = "txtPassportSeries"
        Me.txtPassportSeries.Size = New System.Drawing.Size(34, 20)
        Me.txtPassportSeries.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 65)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Место прописки"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(106, 28)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Номер"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 27)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Серия"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtPosition)
        Me.GroupBox3.Controls.Add(Me.txtExperience)
        Me.GroupBox3.Controls.Add(Me.txtPastEmployment)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Location = New System.Drawing.Point(264, 118)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(287, 104)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Профессиональные данные"
        '
        'txtPosition
        '
        Me.txtPosition.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "Должность", True))
        Me.txtPosition.Location = New System.Drawing.Point(74, 76)
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.Size = New System.Drawing.Size(156, 20)
        Me.txtPosition.TabIndex = 5
        '
        'txtExperience
        '
        Me.txtExperience.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "Страж", True))
        Me.txtExperience.Location = New System.Drawing.Point(45, 50)
        Me.txtExperience.MaxLength = 2
        Me.txtExperience.Name = "txtExperience"
        Me.txtExperience.Size = New System.Drawing.Size(23, 20)
        Me.txtExperience.TabIndex = 4
        '
        'txtPastEmployment
        '
        Me.txtPastEmployment.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "Прошлое место работы", True))
        Me.txtPastEmployment.Location = New System.Drawing.Point(139, 24)
        Me.txtPastEmployment.Multiline = True
        Me.txtPastEmployment.Name = "txtPastEmployment"
        Me.txtPastEmployment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPastEmployment.Size = New System.Drawing.Size(142, 20)
        Me.txtPastEmployment.TabIndex = 3
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 79)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(65, 13)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Должность"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 53)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(33, 13)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Стаж"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 27)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(127, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Прошлое место работы"
        '
        'cmdRegistration
        '
        Me.cmdRegistration.Location = New System.Drawing.Point(431, 228)
        Me.cmdRegistration.Name = "cmdRegistration"
        Me.cmdRegistration.Size = New System.Drawing.Size(120, 30)
        Me.cmdRegistration.TabIndex = 4
        Me.cmdRegistration.Text = "Зарегистрировать"
        Me.cmdRegistration.UseVisualStyleBackColor = True
        '
        'cmdBack
        '
        Me.cmdBack.Location = New System.Drawing.Point(264, 228)
        Me.cmdBack.Name = "cmdBack"
        Me.cmdBack.Size = New System.Drawing.Size(75, 30)
        Me.cmdBack.TabIndex = 5
        Me.cmdBack.Text = "Назад"
        Me.cmdBack.UseVisualStyleBackColor = True
        '
        'StaffTableAdapter
        '
        Me.StaffTableAdapter.ClearBeforeFill = True
        '
        'frmRegistrationPersonal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(557, 268)
        Me.Controls.Add(Me.cmdBack)
        Me.Controls.Add(Me.cmdRegistration)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRegistrationPersonal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Регистрация "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegistrationStaffDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtPatronymic As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtLastname As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdRegistration As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtMilitaryCard As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtRegPlace As System.Windows.Forms.TextBox
    Friend WithEvents txtPassportNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtPassportSeries As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtPosition As System.Windows.Forms.TextBox
    Friend WithEvents txtExperience As System.Windows.Forms.TextBox
    Friend WithEvents txtPastEmployment As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtPhoneNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboGender As System.Windows.Forms.ComboBox
    Friend WithEvents dtpDateOfBorn As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmdBack As System.Windows.Forms.Button
    Friend WithEvents RegistrationStaffDataSet As SampleCourseProject.RegistrationStaffDataSet
    Friend WithEvents StaffBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StaffTableAdapter As SampleCourseProject.RegistrationStaffDataSetTableAdapters.StaffTableAdapter
End Class
