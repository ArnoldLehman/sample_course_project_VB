<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListStaff
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.НомерDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ФамилияDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ИмяDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ОтчествоDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ДатаРожденияDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ПолDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ВоенныйБилетDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.НомерТелефонаDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ПаспортСерияDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ПаспортНомерDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ПропискаDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ПрошлоеМестоРаботыDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.СтражDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ДолжностьDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.StaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RegistrationStaffDataSet = New SampleCourseProject.RegistrationStaffDataSet
        Me.StaffTableAdapter = New SampleCourseProject.RegistrationStaffDataSetTableAdapters.StaffTableAdapter
        Me.cmdPrevious = New System.Windows.Forms.Button
        Me.cmdNext = New System.Windows.Forms.Button
        Me.cmdBack = New System.Windows.Forms.Button
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegistrationStaffDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.НомерDataGridViewTextBoxColumn, Me.ФамилияDataGridViewTextBoxColumn, Me.ИмяDataGridViewTextBoxColumn, Me.ОтчествоDataGridViewTextBoxColumn, Me.ДатаРожденияDataGridViewTextBoxColumn, Me.ПолDataGridViewTextBoxColumn, Me.ВоенныйБилетDataGridViewTextBoxColumn, Me.НомерТелефонаDataGridViewTextBoxColumn, Me.ПаспортСерияDataGridViewTextBoxColumn, Me.ПаспортНомерDataGridViewTextBoxColumn, Me.ПропискаDataGridViewTextBoxColumn, Me.ПрошлоеМестоРаботыDataGridViewTextBoxColumn, Me.СтражDataGridViewTextBoxColumn, Me.ДолжностьDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.StaffBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(557, 260)
        Me.DataGridView1.TabIndex = 0
        '
        'НомерDataGridViewTextBoxColumn
        '
        Me.НомерDataGridViewTextBoxColumn.DataPropertyName = "Номер"
        Me.НомерDataGridViewTextBoxColumn.HeaderText = "Номер"
        Me.НомерDataGridViewTextBoxColumn.Name = "НомерDataGridViewTextBoxColumn"
        '
        'ФамилияDataGridViewTextBoxColumn
        '
        Me.ФамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия"
        Me.ФамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия"
        Me.ФамилияDataGridViewTextBoxColumn.Name = "ФамилияDataGridViewTextBoxColumn"
        '
        'ИмяDataGridViewTextBoxColumn
        '
        Me.ИмяDataGridViewTextBoxColumn.DataPropertyName = "Имя"
        Me.ИмяDataGridViewTextBoxColumn.HeaderText = "Имя"
        Me.ИмяDataGridViewTextBoxColumn.Name = "ИмяDataGridViewTextBoxColumn"
        '
        'ОтчествоDataGridViewTextBoxColumn
        '
        Me.ОтчествоDataGridViewTextBoxColumn.DataPropertyName = "Отчество"
        Me.ОтчествоDataGridViewTextBoxColumn.HeaderText = "Отчество"
        Me.ОтчествоDataGridViewTextBoxColumn.Name = "ОтчествоDataGridViewTextBoxColumn"
        '
        'ДатаРожденияDataGridViewTextBoxColumn
        '
        Me.ДатаРожденияDataGridViewTextBoxColumn.DataPropertyName = "Дата рождения"
        Me.ДатаРожденияDataGridViewTextBoxColumn.HeaderText = "Дата рождения"
        Me.ДатаРожденияDataGridViewTextBoxColumn.Name = "ДатаРожденияDataGridViewTextBoxColumn"
        '
        'ПолDataGridViewTextBoxColumn
        '
        Me.ПолDataGridViewTextBoxColumn.DataPropertyName = "Пол"
        Me.ПолDataGridViewTextBoxColumn.HeaderText = "Пол"
        Me.ПолDataGridViewTextBoxColumn.Name = "ПолDataGridViewTextBoxColumn"
        '
        'ВоенныйБилетDataGridViewTextBoxColumn
        '
        Me.ВоенныйБилетDataGridViewTextBoxColumn.DataPropertyName = "Военный билет"
        Me.ВоенныйБилетDataGridViewTextBoxColumn.HeaderText = "Военный билет"
        Me.ВоенныйБилетDataGridViewTextBoxColumn.Name = "ВоенныйБилетDataGridViewTextBoxColumn"
        '
        'НомерТелефонаDataGridViewTextBoxColumn
        '
        Me.НомерТелефонаDataGridViewTextBoxColumn.DataPropertyName = "Номер телефона"
        Me.НомерТелефонаDataGridViewTextBoxColumn.HeaderText = "Номер телефона"
        Me.НомерТелефонаDataGridViewTextBoxColumn.Name = "НомерТелефонаDataGridViewTextBoxColumn"
        '
        'ПаспортСерияDataGridViewTextBoxColumn
        '
        Me.ПаспортСерияDataGridViewTextBoxColumn.DataPropertyName = "Паспорт серия"
        Me.ПаспортСерияDataGridViewTextBoxColumn.HeaderText = "Паспорт серия"
        Me.ПаспортСерияDataGridViewTextBoxColumn.Name = "ПаспортСерияDataGridViewTextBoxColumn"
        '
        'ПаспортНомерDataGridViewTextBoxColumn
        '
        Me.ПаспортНомерDataGridViewTextBoxColumn.DataPropertyName = "Паспорт номер"
        Me.ПаспортНомерDataGridViewTextBoxColumn.HeaderText = "Паспорт номер"
        Me.ПаспортНомерDataGridViewTextBoxColumn.Name = "ПаспортНомерDataGridViewTextBoxColumn"
        '
        'ПропискаDataGridViewTextBoxColumn
        '
        Me.ПропискаDataGridViewTextBoxColumn.DataPropertyName = "Прописка"
        Me.ПропискаDataGridViewTextBoxColumn.HeaderText = "Прописка"
        Me.ПропискаDataGridViewTextBoxColumn.Name = "ПропискаDataGridViewTextBoxColumn"
        '
        'ПрошлоеМестоРаботыDataGridViewTextBoxColumn
        '
        Me.ПрошлоеМестоРаботыDataGridViewTextBoxColumn.DataPropertyName = "Прошлое место работы"
        Me.ПрошлоеМестоРаботыDataGridViewTextBoxColumn.HeaderText = "Прошлое место работы"
        Me.ПрошлоеМестоРаботыDataGridViewTextBoxColumn.Name = "ПрошлоеМестоРаботыDataGridViewTextBoxColumn"
        '
        'СтражDataGridViewTextBoxColumn
        '
        Me.СтражDataGridViewTextBoxColumn.DataPropertyName = "Страж"
        Me.СтражDataGridViewTextBoxColumn.HeaderText = "Страж"
        Me.СтражDataGridViewTextBoxColumn.Name = "СтражDataGridViewTextBoxColumn"
        '
        'ДолжностьDataGridViewTextBoxColumn
        '
        Me.ДолжностьDataGridViewTextBoxColumn.DataPropertyName = "Должность"
        Me.ДолжностьDataGridViewTextBoxColumn.HeaderText = "Должность"
        Me.ДолжностьDataGridViewTextBoxColumn.Name = "ДолжностьDataGridViewTextBoxColumn"
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
        'StaffTableAdapter
        '
        Me.StaffTableAdapter.ClearBeforeFill = True
        '
        'cmdPrevious
        '
        Me.cmdPrevious.Location = New System.Drawing.Point(12, 278)
        Me.cmdPrevious.Name = "cmdPrevious"
        Me.cmdPrevious.Size = New System.Drawing.Size(85, 23)
        Me.cmdPrevious.TabIndex = 1
        Me.cmdPrevious.Text = "Предыдущий "
        Me.cmdPrevious.UseVisualStyleBackColor = True
        '
        'cmdNext
        '
        Me.cmdNext.Location = New System.Drawing.Point(494, 278)
        Me.cmdNext.Name = "cmdNext"
        Me.cmdNext.Size = New System.Drawing.Size(75, 23)
        Me.cmdNext.TabIndex = 2
        Me.cmdNext.Text = "Следующий"
        Me.cmdNext.UseVisualStyleBackColor = True
        '
        'cmdBack
        '
        Me.cmdBack.Location = New System.Drawing.Point(12, 307)
        Me.cmdBack.Name = "cmdBack"
        Me.cmdBack.Size = New System.Drawing.Size(85, 23)
        Me.cmdBack.TabIndex = 3
        Me.cmdBack.Text = "Назад"
        Me.cmdBack.UseVisualStyleBackColor = True
        '
        'frmListStaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(581, 341)
        Me.Controls.Add(Me.cmdBack)
        Me.Controls.Add(Me.cmdNext)
        Me.Controls.Add(Me.cmdPrevious)
        Me.Controls.Add(Me.DataGridView1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmListStaff"
        Me.Text = "Персонал"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegistrationStaffDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents RegistrationStaffDataSet As SampleCourseProject.RegistrationStaffDataSet
    Friend WithEvents StaffBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StaffTableAdapter As SampleCourseProject.RegistrationStaffDataSetTableAdapters.StaffTableAdapter
    Friend WithEvents НомерDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ФамилияDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ИмяDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ОтчествоDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ДатаРожденияDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ПолDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ВоенныйБилетDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents НомерТелефонаDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ПаспортСерияDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ПаспортНомерDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ПропискаDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ПрошлоеМестоРаботыDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents СтражDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ДолжностьDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmdPrevious As System.Windows.Forms.Button
    Friend WithEvents cmdNext As System.Windows.Forms.Button
    Friend WithEvents cmdBack As System.Windows.Forms.Button
End Class
