<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBookkeeping
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBookkeeping))
        Me.tabBookkeeping = New System.Windows.Forms.TabControl
        Me.tpPersonal = New System.Windows.Forms.TabPage
        Me.lblReset = New System.Windows.Forms.Label
        Me.txtSearch = New System.Windows.Forms.TextBox
        Me.cmdSearch = New System.Windows.Forms.Button
        Me.cmdDatabasePersonal = New System.Windows.Forms.Button
        Me.cmdPreviousPersonal = New System.Windows.Forms.Button
        Me.cmdDeletePersonal = New System.Windows.Forms.Button
        Me.cmdAddNewPersonal = New System.Windows.Forms.Button
        Me.dgvStaff = New System.Windows.Forms.DataGridView
        Me.КодDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ФамилияDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ИмяDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ОтчествоDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ПрофессияDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.КоличествоРабочихДнейDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.КоличествоОтработанныхДнейDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ОкладDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ЗарплатаDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.СреднийДневнойЗаработокDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ОтпускныеDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ПерсоналBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BookkeepingDatabaseDataSet = New SampleCourseProject.BookkeepingDatabaseDataSet
        Me.GroupBox9 = New System.Windows.Forms.GroupBox
        Me.GroupBox12 = New System.Windows.Forms.GroupBox
        Me.txtHolidayPay = New System.Windows.Forms.TextBox
        Me.cmdCalculateHolidayPay = New System.Windows.Forms.Button
        Me.Label28 = New System.Windows.Forms.Label
        Me.GroupBox11 = New System.Windows.Forms.GroupBox
        Me.cmdCalculateSDZ = New System.Windows.Forms.Button
        Me.txtSDZ = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox10 = New System.Windows.Forms.GroupBox
        Me.cmdCalculateWage = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtSalary = New System.Windows.Forms.TextBox
        Me.txtWage = New System.Windows.Forms.TextBox
        Me.GroupBox8 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtPatronymic = New System.Windows.Forms.TextBox
        Me.txtFirstName = New System.Windows.Forms.TextBox
        Me.txtLastName = New System.Windows.Forms.TextBox
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtProfession = New System.Windows.Forms.TextBox
        Me.txtNumbWorkDay = New System.Windows.Forms.TextBox
        Me.txtNumbDaysWorked = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmdNextPersonal = New System.Windows.Forms.Button
        Me.tpMS = New System.Windows.Forms.TabPage
        Me.tabMS = New System.Windows.Forms.TabControl
        Me.tpElectricity = New System.Windows.Forms.TabPage
        Me.cmdNextElectricity = New System.Windows.Forms.Button
        Me.cmdCalculateElectricity = New System.Windows.Forms.Button
        Me.txtRashElec = New System.Windows.Forms.TextBox
        Me.ЭлектричествоBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtTarifElec = New System.Windows.Forms.TextBox
        Me.cmdPreviousElectricity = New System.Windows.Forms.Button
        Me.txtPotrElec = New System.Windows.Forms.TextBox
        Me.cmdAddNewElectricity = New System.Windows.Forms.Button
        Me.Label16 = New System.Windows.Forms.Label
        Me.cmdSaveElectricity = New System.Windows.Forms.Button
        Me.Label17 = New System.Windows.Forms.Label
        Me.cmdDeleteElectricity = New System.Windows.Forms.Button
        Me.Label18 = New System.Windows.Forms.Label
        Me.DataGridView3 = New System.Windows.Forms.DataGridView
        Me.КодDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ПотребленоDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ТарифDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.РасходDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tpGas = New System.Windows.Forms.TabPage
        Me.cmdCalculateGas = New System.Windows.Forms.Button
        Me.txtPotrGas = New System.Windows.Forms.TextBox
        Me.ГазBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmdNextGas = New System.Windows.Forms.Button
        Me.txtTarifGas = New System.Windows.Forms.TextBox
        Me.txtRashGas = New System.Windows.Forms.TextBox
        Me.cmdAddNewGas = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        Me.cmdDeleteGas = New System.Windows.Forms.Button
        Me.Label11 = New System.Windows.Forms.Label
        Me.cmdSaveGas = New System.Windows.Forms.Button
        Me.Label12 = New System.Windows.Forms.Label
        Me.cmdPreviousGas = New System.Windows.Forms.Button
        Me.DataGridView2 = New System.Windows.Forms.DataGridView
        Me.КодDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ПотребленоDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ТарифDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.РасходDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tpWater = New System.Windows.Forms.TabPage
        Me.cmdCalculateWater = New System.Windows.Forms.Button
        Me.cmdNextWater = New System.Windows.Forms.Button
        Me.txtPotrWater = New System.Windows.Forms.TextBox
        Me.ВодаBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtTarifWater = New System.Windows.Forms.TextBox
        Me.cmdAddNewWater = New System.Windows.Forms.Button
        Me.txtRashWater = New System.Windows.Forms.TextBox
        Me.cmdDeleteWater = New System.Windows.Forms.Button
        Me.Label13 = New System.Windows.Forms.Label
        Me.cmdSaveWater = New System.Windows.Forms.Button
        Me.Label14 = New System.Windows.Forms.Label
        Me.cmdPreviousWater = New System.Windows.Forms.Button
        Me.Label15 = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.КодDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ПотребленоDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ТарифDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.РасходDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ПерсоналTableAdapter = New SampleCourseProject.BookkeepingDatabaseDataSetTableAdapters.ПерсоналTableAdapter
        Me.ЭлектричествоTableAdapter = New SampleCourseProject.BookkeepingDatabaseDataSetTableAdapters.ЭлектричествоTableAdapter
        Me.ГазTableAdapter = New SampleCourseProject.BookkeepingDatabaseDataSetTableAdapters.ГазTableAdapter
        Me.ВодаTableAdapter = New SampleCourseProject.BookkeepingDatabaseDataSetTableAdapters.ВодаTableAdapter
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblMain = New System.Windows.Forms.Label
        Me.tabBookkeeping.SuspendLayout()
        Me.tpPersonal.SuspendLayout()
        CType(Me.dgvStaff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ПерсоналBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookkeepingDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tpMS.SuspendLayout()
        Me.tabMS.SuspendLayout()
        Me.tpElectricity.SuspendLayout()
        CType(Me.ЭлектричествоBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpGas.SuspendLayout()
        CType(Me.ГазBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpWater.SuspendLayout()
        CType(Me.ВодаBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabBookkeeping
        '
        Me.tabBookkeeping.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.tabBookkeeping.Controls.Add(Me.tpPersonal)
        Me.tabBookkeeping.Controls.Add(Me.tpMS)
        Me.tabBookkeeping.Location = New System.Drawing.Point(1, 67)
        Me.tabBookkeeping.Name = "tabBookkeeping"
        Me.tabBookkeeping.SelectedIndex = 0
        Me.tabBookkeeping.Size = New System.Drawing.Size(1211, 287)
        Me.tabBookkeeping.TabIndex = 2
        '
        'tpPersonal
        '
        Me.tpPersonal.Controls.Add(Me.lblReset)
        Me.tpPersonal.Controls.Add(Me.txtSearch)
        Me.tpPersonal.Controls.Add(Me.cmdSearch)
        Me.tpPersonal.Controls.Add(Me.cmdDatabasePersonal)
        Me.tpPersonal.Controls.Add(Me.cmdPreviousPersonal)
        Me.tpPersonal.Controls.Add(Me.cmdDeletePersonal)
        Me.tpPersonal.Controls.Add(Me.cmdAddNewPersonal)
        Me.tpPersonal.Controls.Add(Me.dgvStaff)
        Me.tpPersonal.Controls.Add(Me.GroupBox9)
        Me.tpPersonal.Controls.Add(Me.GroupBox8)
        Me.tpPersonal.Controls.Add(Me.GroupBox7)
        Me.tpPersonal.Controls.Add(Me.GroupBox1)
        Me.tpPersonal.Location = New System.Drawing.Point(4, 25)
        Me.tpPersonal.Name = "tpPersonal"
        Me.tpPersonal.Padding = New System.Windows.Forms.Padding(3)
        Me.tpPersonal.Size = New System.Drawing.Size(1203, 258)
        Me.tpPersonal.TabIndex = 0
        Me.tpPersonal.Text = "Персонал"
        Me.tpPersonal.UseVisualStyleBackColor = True
        '
        'lblReset
        '
        Me.lblReset.AutoSize = True
        Me.lblReset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblReset.Location = New System.Drawing.Point(502, 232)
        Me.lblReset.Name = "lblReset"
        Me.lblReset.Size = New System.Drawing.Size(55, 13)
        Me.lblReset.TabIndex = 59
        Me.lblReset.Text = "Сбросить"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(575, 228)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(538, 20)
        Me.txtSearch.TabIndex = 58
        '
        'cmdSearch
        '
        Me.cmdSearch.Location = New System.Drawing.Point(1119, 228)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(75, 20)
        Me.cmdSearch.TabIndex = 57
        Me.cmdSearch.Text = "Поиск"
        Me.cmdSearch.UseVisualStyleBackColor = True
        '
        'cmdDatabasePersonal
        '
        Me.cmdDatabasePersonal.Location = New System.Drawing.Point(786, 196)
        Me.cmdDatabasePersonal.Name = "cmdDatabasePersonal"
        Me.cmdDatabasePersonal.Size = New System.Drawing.Size(94, 23)
        Me.cmdDatabasePersonal.TabIndex = 51
        Me.cmdDatabasePersonal.Text = "Занести в базу"
        Me.cmdDatabasePersonal.UseVisualStyleBackColor = True
        '
        'cmdPreviousPersonal
        '
        Me.cmdPreviousPersonal.Location = New System.Drawing.Point(502, 196)
        Me.cmdPreviousPersonal.Name = "cmdPreviousPersonal"
        Me.cmdPreviousPersonal.Size = New System.Drawing.Size(75, 23)
        Me.cmdPreviousPersonal.TabIndex = 54
        Me.cmdPreviousPersonal.Text = "<--"
        Me.cmdPreviousPersonal.UseVisualStyleBackColor = True
        '
        'cmdDeletePersonal
        '
        Me.cmdDeletePersonal.Location = New System.Drawing.Point(886, 196)
        Me.cmdDeletePersonal.Name = "cmdDeletePersonal"
        Me.cmdDeletePersonal.Size = New System.Drawing.Size(75, 23)
        Me.cmdDeletePersonal.TabIndex = 53
        Me.cmdDeletePersonal.Text = "Удалить"
        Me.cmdDeletePersonal.UseVisualStyleBackColor = True
        '
        'cmdAddNewPersonal
        '
        Me.cmdAddNewPersonal.Location = New System.Drawing.Point(705, 196)
        Me.cmdAddNewPersonal.Name = "cmdAddNewPersonal"
        Me.cmdAddNewPersonal.Size = New System.Drawing.Size(75, 23)
        Me.cmdAddNewPersonal.TabIndex = 52
        Me.cmdAddNewPersonal.Text = "Добавить"
        Me.cmdAddNewPersonal.UseVisualStyleBackColor = True
        '
        'dgvStaff
        '
        Me.dgvStaff.AutoGenerateColumns = False
        Me.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStaff.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.КодDataGridViewTextBoxColumn, Me.ФамилияDataGridViewTextBoxColumn, Me.ИмяDataGridViewTextBoxColumn, Me.ОтчествоDataGridViewTextBoxColumn, Me.ПрофессияDataGridViewTextBoxColumn, Me.КоличествоРабочихДнейDataGridViewTextBoxColumn, Me.КоличествоОтработанныхДнейDataGridViewTextBoxColumn, Me.ОкладDataGridViewTextBoxColumn, Me.ЗарплатаDataGridViewTextBoxColumn, Me.СреднийДневнойЗаработокDataGridViewTextBoxColumn, Me.ОтпускныеDataGridViewTextBoxColumn})
        Me.dgvStaff.DataSource = Me.ПерсоналBindingSource
        Me.dgvStaff.Location = New System.Drawing.Point(502, 23)
        Me.dgvStaff.Name = "dgvStaff"
        Me.dgvStaff.Size = New System.Drawing.Size(692, 167)
        Me.dgvStaff.TabIndex = 51
        '
        'КодDataGridViewTextBoxColumn
        '
        Me.КодDataGridViewTextBoxColumn.DataPropertyName = "Код"
        Me.КодDataGridViewTextBoxColumn.HeaderText = "Код"
        Me.КодDataGridViewTextBoxColumn.Name = "КодDataGridViewTextBoxColumn"
        Me.КодDataGridViewTextBoxColumn.Width = 50
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
        'ПрофессияDataGridViewTextBoxColumn
        '
        Me.ПрофессияDataGridViewTextBoxColumn.DataPropertyName = "Профессия"
        Me.ПрофессияDataGridViewTextBoxColumn.HeaderText = "Профессия"
        Me.ПрофессияDataGridViewTextBoxColumn.Name = "ПрофессияDataGridViewTextBoxColumn"
        '
        'КоличествоРабочихДнейDataGridViewTextBoxColumn
        '
        Me.КоличествоРабочихДнейDataGridViewTextBoxColumn.DataPropertyName = "Количество рабочих дней"
        Me.КоличествоРабочихДнейDataGridViewTextBoxColumn.HeaderText = "Количество рабочих дней"
        Me.КоличествоРабочихДнейDataGridViewTextBoxColumn.Name = "КоличествоРабочихДнейDataGridViewTextBoxColumn"
        '
        'КоличествоОтработанныхДнейDataGridViewTextBoxColumn
        '
        Me.КоличествоОтработанныхДнейDataGridViewTextBoxColumn.DataPropertyName = "Количество отработанных дней"
        Me.КоличествоОтработанныхДнейDataGridViewTextBoxColumn.HeaderText = "Количество отработанных дней"
        Me.КоличествоОтработанныхДнейDataGridViewTextBoxColumn.Name = "КоличествоОтработанныхДнейDataGridViewTextBoxColumn"
        '
        'ОкладDataGridViewTextBoxColumn
        '
        Me.ОкладDataGridViewTextBoxColumn.DataPropertyName = "Оклад"
        Me.ОкладDataGridViewTextBoxColumn.HeaderText = "Оклад"
        Me.ОкладDataGridViewTextBoxColumn.Name = "ОкладDataGridViewTextBoxColumn"
        Me.ОкладDataGridViewTextBoxColumn.Width = 80
        '
        'ЗарплатаDataGridViewTextBoxColumn
        '
        Me.ЗарплатаDataGridViewTextBoxColumn.DataPropertyName = "Зарплата"
        Me.ЗарплатаDataGridViewTextBoxColumn.HeaderText = "Зарплата"
        Me.ЗарплатаDataGridViewTextBoxColumn.Name = "ЗарплатаDataGridViewTextBoxColumn"
        Me.ЗарплатаDataGridViewTextBoxColumn.Width = 95
        '
        'СреднийДневнойЗаработокDataGridViewTextBoxColumn
        '
        Me.СреднийДневнойЗаработокDataGridViewTextBoxColumn.DataPropertyName = "Средний дневной заработок"
        Me.СреднийДневнойЗаработокDataGridViewTextBoxColumn.HeaderText = "Средний дневной заработок"
        Me.СреднийДневнойЗаработокDataGridViewTextBoxColumn.Name = "СреднийДневнойЗаработокDataGridViewTextBoxColumn"
        '
        'ОтпускныеDataGridViewTextBoxColumn
        '
        Me.ОтпускныеDataGridViewTextBoxColumn.DataPropertyName = "Отпускные"
        Me.ОтпускныеDataGridViewTextBoxColumn.HeaderText = "Отпускные"
        Me.ОтпускныеDataGridViewTextBoxColumn.Name = "ОтпускныеDataGridViewTextBoxColumn"
        Me.ОтпускныеDataGridViewTextBoxColumn.Width = 90
        '
        'ПерсоналBindingSource
        '
        Me.ПерсоналBindingSource.DataMember = "Персонал"
        Me.ПерсоналBindingSource.DataSource = Me.BookkeepingDatabaseDataSet
        '
        'BookkeepingDatabaseDataSet
        '
        Me.BookkeepingDatabaseDataSet.DataSetName = "BookkeepingDatabaseDataSet"
        Me.BookkeepingDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.GroupBox12)
        Me.GroupBox9.Controls.Add(Me.GroupBox11)
        Me.GroupBox9.Controls.Add(Me.GroupBox10)
        Me.GroupBox9.Location = New System.Drawing.Point(6, 112)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(483, 137)
        Me.GroupBox9.TabIndex = 49
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Финансовые данные"
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.txtHolidayPay)
        Me.GroupBox12.Controls.Add(Me.cmdCalculateHolidayPay)
        Me.GroupBox12.Controls.Add(Me.Label28)
        Me.GroupBox12.Location = New System.Drawing.Point(314, 22)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(162, 103)
        Me.GroupBox12.TabIndex = 48
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "Отпускные"
        '
        'txtHolidayPay
        '
        Me.txtHolidayPay.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ПерсоналBindingSource, "Отпускные", True))
        Me.txtHolidayPay.Location = New System.Drawing.Point(75, 31)
        Me.txtHolidayPay.Name = "txtHolidayPay"
        Me.txtHolidayPay.ReadOnly = True
        Me.txtHolidayPay.Size = New System.Drawing.Size(78, 20)
        Me.txtHolidayPay.TabIndex = 48
        '
        'cmdCalculateHolidayPay
        '
        Me.cmdCalculateHolidayPay.Location = New System.Drawing.Point(9, 71)
        Me.cmdCalculateHolidayPay.Name = "cmdCalculateHolidayPay"
        Me.cmdCalculateHolidayPay.Size = New System.Drawing.Size(147, 21)
        Me.cmdCalculateHolidayPay.TabIndex = 10
        Me.cmdCalculateHolidayPay.Text = "Рассчитать"
        Me.cmdCalculateHolidayPay.UseVisualStyleBackColor = True
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(6, 34)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(63, 13)
        Me.Label28.TabIndex = 47
        Me.Label28.Text = "Отпускные"
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.cmdCalculateSDZ)
        Me.GroupBox11.Controls.Add(Me.txtSDZ)
        Me.GroupBox11.Controls.Add(Me.Label4)
        Me.GroupBox11.Location = New System.Drawing.Point(165, 22)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(124, 103)
        Me.GroupBox11.TabIndex = 47
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Средний дневной заработок"
        '
        'cmdCalculateSDZ
        '
        Me.cmdCalculateSDZ.Location = New System.Drawing.Point(11, 71)
        Me.cmdCalculateSDZ.Name = "cmdCalculateSDZ"
        Me.cmdCalculateSDZ.Size = New System.Drawing.Size(102, 21)
        Me.cmdCalculateSDZ.TabIndex = 9
        Me.cmdCalculateSDZ.Text = "Рассчитать"
        Me.cmdCalculateSDZ.UseVisualStyleBackColor = True
        '
        'txtSDZ
        '
        Me.txtSDZ.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ПерсоналBindingSource, "Средний дневной заработок", True))
        Me.txtSDZ.Location = New System.Drawing.Point(44, 40)
        Me.txtSDZ.Name = "txtSDZ"
        Me.txtSDZ.ReadOnly = True
        Me.txtSDZ.Size = New System.Drawing.Size(69, 20)
        Me.txtSDZ.TabIndex = 47
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "СДЗ"
        Me.ToolTip1.SetToolTip(Me.Label4, "Средний дневной заработок")
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.cmdCalculateWage)
        Me.GroupBox10.Controls.Add(Me.Label8)
        Me.GroupBox10.Controls.Add(Me.Label9)
        Me.GroupBox10.Controls.Add(Me.txtSalary)
        Me.GroupBox10.Controls.Add(Me.txtWage)
        Me.GroupBox10.Location = New System.Drawing.Point(6, 22)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(137, 103)
        Me.GroupBox10.TabIndex = 46
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Зарплата"
        '
        'cmdCalculateWage
        '
        Me.cmdCalculateWage.Location = New System.Drawing.Point(15, 71)
        Me.cmdCalculateWage.Name = "cmdCalculateWage"
        Me.cmdCalculateWage.Size = New System.Drawing.Size(115, 21)
        Me.cmdCalculateWage.TabIndex = 8
        Me.cmdCalculateWage.Text = "Рассчитать"
        Me.cmdCalculateWage.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "Оклад"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 13)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "Зарплата"
        '
        'txtSalary
        '
        Me.txtSalary.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ПерсоналBindingSource, "Оклад", True))
        Me.txtSalary.Location = New System.Drawing.Point(57, 18)
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(57, 20)
        Me.txtSalary.TabIndex = 7
        '
        'txtWage
        '
        Me.txtWage.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ПерсоналBindingSource, "Зарплата", True))
        Me.txtWage.Location = New System.Drawing.Point(73, 45)
        Me.txtWage.Name = "txtWage"
        Me.txtWage.ReadOnly = True
        Me.txtWage.Size = New System.Drawing.Size(57, 20)
        Me.txtWage.TabIndex = 44
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.Label3)
        Me.GroupBox8.Controls.Add(Me.Label2)
        Me.GroupBox8.Controls.Add(Me.Label1)
        Me.GroupBox8.Controls.Add(Me.txtPatronymic)
        Me.GroupBox8.Controls.Add(Me.txtFirstName)
        Me.GroupBox8.Controls.Add(Me.txtLastName)
        Me.GroupBox8.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(186, 100)
        Me.GroupBox8.TabIndex = 48
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Личные данные"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Отчество"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Имя"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Фамилия"
        '
        'txtPatronymic
        '
        Me.txtPatronymic.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ПерсоналBindingSource, "Отчество", True))
        Me.txtPatronymic.Location = New System.Drawing.Point(63, 71)
        Me.txtPatronymic.MaxLength = 40
        Me.txtPatronymic.Name = "txtPatronymic"
        Me.txtPatronymic.Size = New System.Drawing.Size(113, 20)
        Me.txtPatronymic.TabIndex = 3
        '
        'txtFirstName
        '
        Me.txtFirstName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ПерсоналBindingSource, "Имя", True))
        Me.txtFirstName.Location = New System.Drawing.Point(38, 44)
        Me.txtFirstName.MaxLength = 40
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(104, 20)
        Me.txtFirstName.TabIndex = 2
        '
        'txtLastName
        '
        Me.txtLastName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ПерсоналBindingSource, "Фамилия", True))
        Me.txtLastName.Location = New System.Drawing.Point(65, 17)
        Me.txtLastName.MaxLength = 40
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(111, 20)
        Me.txtLastName.TabIndex = 1
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Label5)
        Me.GroupBox7.Controls.Add(Me.txtProfession)
        Me.GroupBox7.Controls.Add(Me.txtNumbWorkDay)
        Me.GroupBox7.Controls.Add(Me.txtNumbDaysWorked)
        Me.GroupBox7.Controls.Add(Me.Label6)
        Me.GroupBox7.Controls.Add(Me.Label7)
        Me.GroupBox7.Location = New System.Drawing.Point(207, 6)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(211, 100)
        Me.GroupBox7.TabIndex = 47
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Профессиональные данные"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Профессия"
        '
        'txtProfession
        '
        Me.txtProfession.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ПерсоналBindingSource, "Профессия", True))
        Me.txtProfession.Location = New System.Drawing.Point(74, 21)
        Me.txtProfession.MaxLength = 40
        Me.txtProfession.Name = "txtProfession"
        Me.txtProfession.Size = New System.Drawing.Size(100, 20)
        Me.txtProfession.TabIndex = 4
        '
        'txtNumbWorkDay
        '
        Me.txtNumbWorkDay.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ПерсоналBindingSource, "Количество рабочих дней", True))
        Me.txtNumbWorkDay.Location = New System.Drawing.Point(145, 47)
        Me.txtNumbWorkDay.MaxLength = 2
        Me.txtNumbWorkDay.Name = "txtNumbWorkDay"
        Me.txtNumbWorkDay.Size = New System.Drawing.Size(28, 20)
        Me.txtNumbWorkDay.TabIndex = 5
        '
        'txtNumbDaysWorked
        '
        Me.txtNumbDaysWorked.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ПерсоналBindingSource, "Количество отработанных дней", True))
        Me.txtNumbDaysWorked.Location = New System.Drawing.Point(176, 73)
        Me.txtNumbDaysWorked.MaxLength = 2
        Me.txtNumbDaysWorked.Name = "txtNumbDaysWorked"
        Me.txtNumbDaysWorked.Size = New System.Drawing.Size(28, 20)
        Me.txtNumbDaysWorked.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 13)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Количество рабочих дней"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 76)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(167, 13)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Количество отработанных дней"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdNextPersonal)
        Me.GroupBox1.Location = New System.Drawing.Point(495, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(702, 217)
        Me.GroupBox1.TabIndex = 56
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "База персонала"
        '
        'cmdNextPersonal
        '
        Me.cmdNextPersonal.Location = New System.Drawing.Point(621, 190)
        Me.cmdNextPersonal.Name = "cmdNextPersonal"
        Me.cmdNextPersonal.Size = New System.Drawing.Size(75, 23)
        Me.cmdNextPersonal.TabIndex = 55
        Me.cmdNextPersonal.Text = "-->"
        Me.cmdNextPersonal.UseVisualStyleBackColor = True
        '
        'tpMS
        '
        Me.tpMS.Controls.Add(Me.tabMS)
        Me.tpMS.Location = New System.Drawing.Point(4, 25)
        Me.tpMS.Name = "tpMS"
        Me.tpMS.Padding = New System.Windows.Forms.Padding(3)
        Me.tpMS.Size = New System.Drawing.Size(1203, 258)
        Me.tpMS.TabIndex = 1
        Me.tpMS.Text = "Комм. услуги"
        Me.tpMS.UseVisualStyleBackColor = True
        '
        'tabMS
        '
        Me.tabMS.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.tabMS.Controls.Add(Me.tpElectricity)
        Me.tabMS.Controls.Add(Me.tpGas)
        Me.tabMS.Controls.Add(Me.tpWater)
        Me.tabMS.Location = New System.Drawing.Point(8, 6)
        Me.tabMS.Name = "tabMS"
        Me.tabMS.SelectedIndex = 0
        Me.tabMS.Size = New System.Drawing.Size(699, 164)
        Me.tabMS.TabIndex = 18
        '
        'tpElectricity
        '
        Me.tpElectricity.BackColor = System.Drawing.SystemColors.Control
        Me.tpElectricity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tpElectricity.Controls.Add(Me.cmdNextElectricity)
        Me.tpElectricity.Controls.Add(Me.cmdCalculateElectricity)
        Me.tpElectricity.Controls.Add(Me.txtRashElec)
        Me.tpElectricity.Controls.Add(Me.txtTarifElec)
        Me.tpElectricity.Controls.Add(Me.cmdPreviousElectricity)
        Me.tpElectricity.Controls.Add(Me.txtPotrElec)
        Me.tpElectricity.Controls.Add(Me.cmdAddNewElectricity)
        Me.tpElectricity.Controls.Add(Me.Label16)
        Me.tpElectricity.Controls.Add(Me.cmdSaveElectricity)
        Me.tpElectricity.Controls.Add(Me.Label17)
        Me.tpElectricity.Controls.Add(Me.cmdDeleteElectricity)
        Me.tpElectricity.Controls.Add(Me.Label18)
        Me.tpElectricity.Controls.Add(Me.DataGridView3)
        Me.tpElectricity.Location = New System.Drawing.Point(4, 25)
        Me.tpElectricity.Name = "tpElectricity"
        Me.tpElectricity.Padding = New System.Windows.Forms.Padding(3)
        Me.tpElectricity.Size = New System.Drawing.Size(691, 135)
        Me.tpElectricity.TabIndex = 0
        Me.tpElectricity.Text = "Электричество"
        '
        'cmdNextElectricity
        '
        Me.cmdNextElectricity.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.cmdNextElectricity.Location = New System.Drawing.Point(184, 78)
        Me.cmdNextElectricity.Name = "cmdNextElectricity"
        Me.cmdNextElectricity.Size = New System.Drawing.Size(75, 23)
        Me.cmdNextElectricity.TabIndex = 24
        Me.cmdNextElectricity.Text = "Следующий"
        Me.cmdNextElectricity.UseVisualStyleBackColor = True
        '
        'cmdCalculateElectricity
        '
        Me.cmdCalculateElectricity.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.cmdCalculateElectricity.Location = New System.Drawing.Point(184, 107)
        Me.cmdCalculateElectricity.Name = "cmdCalculateElectricity"
        Me.cmdCalculateElectricity.Size = New System.Drawing.Size(75, 23)
        Me.cmdCalculateElectricity.TabIndex = 6
        Me.cmdCalculateElectricity.Text = "Рассчитать"
        Me.cmdCalculateElectricity.UseVisualStyleBackColor = True
        '
        'txtRashElec
        '
        Me.txtRashElec.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ЭлектричествоBindingSource, "Расход", True))
        Me.txtRashElec.Location = New System.Drawing.Point(103, 52)
        Me.txtRashElec.Name = "txtRashElec"
        Me.txtRashElec.ReadOnly = True
        Me.txtRashElec.Size = New System.Drawing.Size(156, 20)
        Me.txtRashElec.TabIndex = 5
        '
        'ЭлектричествоBindingSource
        '
        Me.ЭлектричествоBindingSource.DataMember = "Электричество"
        Me.ЭлектричествоBindingSource.DataSource = Me.BookkeepingDatabaseDataSet
        '
        'txtTarifElec
        '
        Me.txtTarifElec.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ЭлектричествоBindingSource, "Тариф", True))
        Me.txtTarifElec.Location = New System.Drawing.Point(103, 29)
        Me.txtTarifElec.Name = "txtTarifElec"
        Me.txtTarifElec.Size = New System.Drawing.Size(156, 20)
        Me.txtTarifElec.TabIndex = 4
        '
        'cmdPreviousElectricity
        '
        Me.cmdPreviousElectricity.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.cmdPreviousElectricity.Location = New System.Drawing.Point(9, 78)
        Me.cmdPreviousElectricity.Name = "cmdPreviousElectricity"
        Me.cmdPreviousElectricity.Size = New System.Drawing.Size(88, 23)
        Me.cmdPreviousElectricity.TabIndex = 19
        Me.cmdPreviousElectricity.Text = "Предыдущий"
        Me.cmdPreviousElectricity.UseVisualStyleBackColor = True
        '
        'txtPotrElec
        '
        Me.txtPotrElec.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ЭлектричествоBindingSource, "Потреблено", True))
        Me.txtPotrElec.Location = New System.Drawing.Point(103, 6)
        Me.txtPotrElec.Name = "txtPotrElec"
        Me.txtPotrElec.Size = New System.Drawing.Size(156, 20)
        Me.txtPotrElec.TabIndex = 3
        '
        'cmdAddNewElectricity
        '
        Me.cmdAddNewElectricity.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.cmdAddNewElectricity.Location = New System.Drawing.Point(103, 78)
        Me.cmdAddNewElectricity.Name = "cmdAddNewElectricity"
        Me.cmdAddNewElectricity.Size = New System.Drawing.Size(75, 23)
        Me.cmdAddNewElectricity.TabIndex = 22
        Me.cmdAddNewElectricity.Text = "Добавить"
        Me.cmdAddNewElectricity.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 55)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(43, 13)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "Расход"
        '
        'cmdSaveElectricity
        '
        Me.cmdSaveElectricity.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.cmdSaveElectricity.Location = New System.Drawing.Point(9, 107)
        Me.cmdSaveElectricity.Name = "cmdSaveElectricity"
        Me.cmdSaveElectricity.Size = New System.Drawing.Size(88, 23)
        Me.cmdSaveElectricity.TabIndex = 20
        Me.cmdSaveElectricity.Text = "Сохранить"
        Me.cmdSaveElectricity.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(6, 32)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(40, 13)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "Тариф"
        '
        'cmdDeleteElectricity
        '
        Me.cmdDeleteElectricity.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.cmdDeleteElectricity.Location = New System.Drawing.Point(103, 107)
        Me.cmdDeleteElectricity.Name = "cmdDeleteElectricity"
        Me.cmdDeleteElectricity.Size = New System.Drawing.Size(75, 23)
        Me.cmdDeleteElectricity.TabIndex = 21
        Me.cmdDeleteElectricity.Text = "Удалить"
        Me.cmdDeleteElectricity.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(6, 9)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(68, 13)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "Потреблено"
        '
        'DataGridView3
        '
        Me.DataGridView3.AutoGenerateColumns = False
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.КодDataGridViewTextBoxColumn1, Me.ПотребленоDataGridViewTextBoxColumn, Me.ТарифDataGridViewTextBoxColumn, Me.РасходDataGridViewTextBoxColumn})
        Me.DataGridView3.DataSource = Me.ЭлектричествоBindingSource
        Me.DataGridView3.Location = New System.Drawing.Point(265, 6)
        Me.DataGridView3.MultiSelect = False
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.ReadOnly = True
        Me.DataGridView3.Size = New System.Drawing.Size(416, 124)
        Me.DataGridView3.TabIndex = 0
        '
        'КодDataGridViewTextBoxColumn1
        '
        Me.КодDataGridViewTextBoxColumn1.DataPropertyName = "Код"
        Me.КодDataGridViewTextBoxColumn1.HeaderText = "Код"
        Me.КодDataGridViewTextBoxColumn1.Name = "КодDataGridViewTextBoxColumn1"
        Me.КодDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'ПотребленоDataGridViewTextBoxColumn
        '
        Me.ПотребленоDataGridViewTextBoxColumn.DataPropertyName = "Потреблено"
        Me.ПотребленоDataGridViewTextBoxColumn.HeaderText = "Потреблено"
        Me.ПотребленоDataGridViewTextBoxColumn.Name = "ПотребленоDataGridViewTextBoxColumn"
        Me.ПотребленоDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ТарифDataGridViewTextBoxColumn
        '
        Me.ТарифDataGridViewTextBoxColumn.DataPropertyName = "Тариф"
        Me.ТарифDataGridViewTextBoxColumn.HeaderText = "Тариф"
        Me.ТарифDataGridViewTextBoxColumn.Name = "ТарифDataGridViewTextBoxColumn"
        Me.ТарифDataGridViewTextBoxColumn.ReadOnly = True
        '
        'РасходDataGridViewTextBoxColumn
        '
        Me.РасходDataGridViewTextBoxColumn.DataPropertyName = "Расход"
        Me.РасходDataGridViewTextBoxColumn.HeaderText = "Расход"
        Me.РасходDataGridViewTextBoxColumn.Name = "РасходDataGridViewTextBoxColumn"
        Me.РасходDataGridViewTextBoxColumn.ReadOnly = True
        '
        'tpGas
        '
        Me.tpGas.BackColor = System.Drawing.SystemColors.Control
        Me.tpGas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tpGas.Controls.Add(Me.cmdCalculateGas)
        Me.tpGas.Controls.Add(Me.txtPotrGas)
        Me.tpGas.Controls.Add(Me.cmdNextGas)
        Me.tpGas.Controls.Add(Me.txtTarifGas)
        Me.tpGas.Controls.Add(Me.txtRashGas)
        Me.tpGas.Controls.Add(Me.cmdAddNewGas)
        Me.tpGas.Controls.Add(Me.Label10)
        Me.tpGas.Controls.Add(Me.cmdDeleteGas)
        Me.tpGas.Controls.Add(Me.Label11)
        Me.tpGas.Controls.Add(Me.cmdSaveGas)
        Me.tpGas.Controls.Add(Me.Label12)
        Me.tpGas.Controls.Add(Me.cmdPreviousGas)
        Me.tpGas.Controls.Add(Me.DataGridView2)
        Me.tpGas.Location = New System.Drawing.Point(4, 25)
        Me.tpGas.Name = "tpGas"
        Me.tpGas.Padding = New System.Windows.Forms.Padding(3)
        Me.tpGas.Size = New System.Drawing.Size(691, 135)
        Me.tpGas.TabIndex = 1
        Me.tpGas.Text = "Газ"
        '
        'cmdCalculateGas
        '
        Me.cmdCalculateGas.Location = New System.Drawing.Point(184, 107)
        Me.cmdCalculateGas.Name = "cmdCalculateGas"
        Me.cmdCalculateGas.Size = New System.Drawing.Size(75, 23)
        Me.cmdCalculateGas.TabIndex = 17
        Me.cmdCalculateGas.Text = "Рассчитать"
        Me.cmdCalculateGas.UseVisualStyleBackColor = True
        '
        'txtPotrGas
        '
        Me.txtPotrGas.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ГазBindingSource, "Потреблено", True))
        Me.txtPotrGas.Location = New System.Drawing.Point(103, 6)
        Me.txtPotrGas.Name = "txtPotrGas"
        Me.txtPotrGas.Size = New System.Drawing.Size(156, 20)
        Me.txtPotrGas.TabIndex = 5
        '
        'ГазBindingSource
        '
        Me.ГазBindingSource.DataMember = "Газ"
        Me.ГазBindingSource.DataSource = Me.BookkeepingDatabaseDataSet
        '
        'cmdNextGas
        '
        Me.cmdNextGas.Location = New System.Drawing.Point(184, 78)
        Me.cmdNextGas.Name = "cmdNextGas"
        Me.cmdNextGas.Size = New System.Drawing.Size(75, 23)
        Me.cmdNextGas.TabIndex = 30
        Me.cmdNextGas.Text = "Следующий"
        Me.cmdNextGas.UseVisualStyleBackColor = True
        '
        'txtTarifGas
        '
        Me.txtTarifGas.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ГазBindingSource, "Тариф", True))
        Me.txtTarifGas.Location = New System.Drawing.Point(103, 29)
        Me.txtTarifGas.Name = "txtTarifGas"
        Me.txtTarifGas.Size = New System.Drawing.Size(156, 20)
        Me.txtTarifGas.TabIndex = 4
        '
        'txtRashGas
        '
        Me.txtRashGas.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ГазBindingSource, "Расход", True))
        Me.txtRashGas.Location = New System.Drawing.Point(103, 52)
        Me.txtRashGas.Name = "txtRashGas"
        Me.txtRashGas.ReadOnly = True
        Me.txtRashGas.Size = New System.Drawing.Size(156, 20)
        Me.txtRashGas.TabIndex = 3
        '
        'cmdAddNewGas
        '
        Me.cmdAddNewGas.Location = New System.Drawing.Point(103, 78)
        Me.cmdAddNewGas.Name = "cmdAddNewGas"
        Me.cmdAddNewGas.Size = New System.Drawing.Size(75, 23)
        Me.cmdAddNewGas.TabIndex = 28
        Me.cmdAddNewGas.Text = "Добавить"
        Me.cmdAddNewGas.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 55)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Расход"
        '
        'cmdDeleteGas
        '
        Me.cmdDeleteGas.Location = New System.Drawing.Point(103, 107)
        Me.cmdDeleteGas.Name = "cmdDeleteGas"
        Me.cmdDeleteGas.Size = New System.Drawing.Size(75, 23)
        Me.cmdDeleteGas.TabIndex = 27
        Me.cmdDeleteGas.Text = "Удалить"
        Me.cmdDeleteGas.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 32)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 13)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Тариф"
        '
        'cmdSaveGas
        '
        Me.cmdSaveGas.Location = New System.Drawing.Point(9, 107)
        Me.cmdSaveGas.Name = "cmdSaveGas"
        Me.cmdSaveGas.Size = New System.Drawing.Size(88, 23)
        Me.cmdSaveGas.TabIndex = 26
        Me.cmdSaveGas.Text = "Сохранить"
        Me.cmdSaveGas.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 9)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(68, 13)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Потреблено"
        '
        'cmdPreviousGas
        '
        Me.cmdPreviousGas.Location = New System.Drawing.Point(9, 78)
        Me.cmdPreviousGas.Name = "cmdPreviousGas"
        Me.cmdPreviousGas.Size = New System.Drawing.Size(88, 23)
        Me.cmdPreviousGas.TabIndex = 25
        Me.cmdPreviousGas.Text = "Предыдущий"
        Me.cmdPreviousGas.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.КодDataGridViewTextBoxColumn2, Me.ПотребленоDataGridViewTextBoxColumn1, Me.ТарифDataGridViewTextBoxColumn1, Me.РасходDataGridViewTextBoxColumn1})
        Me.DataGridView2.DataSource = Me.ГазBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(265, 6)
        Me.DataGridView2.MultiSelect = False
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.Size = New System.Drawing.Size(416, 124)
        Me.DataGridView2.TabIndex = 0
        '
        'КодDataGridViewTextBoxColumn2
        '
        Me.КодDataGridViewTextBoxColumn2.DataPropertyName = "Код"
        Me.КодDataGridViewTextBoxColumn2.HeaderText = "Код"
        Me.КодDataGridViewTextBoxColumn2.Name = "КодDataGridViewTextBoxColumn2"
        Me.КодDataGridViewTextBoxColumn2.ReadOnly = True
        '
        'ПотребленоDataGridViewTextBoxColumn1
        '
        Me.ПотребленоDataGridViewTextBoxColumn1.DataPropertyName = "Потреблено"
        Me.ПотребленоDataGridViewTextBoxColumn1.HeaderText = "Потреблено"
        Me.ПотребленоDataGridViewTextBoxColumn1.Name = "ПотребленоDataGridViewTextBoxColumn1"
        Me.ПотребленоDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'ТарифDataGridViewTextBoxColumn1
        '
        Me.ТарифDataGridViewTextBoxColumn1.DataPropertyName = "Тариф"
        Me.ТарифDataGridViewTextBoxColumn1.HeaderText = "Тариф"
        Me.ТарифDataGridViewTextBoxColumn1.Name = "ТарифDataGridViewTextBoxColumn1"
        Me.ТарифDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'РасходDataGridViewTextBoxColumn1
        '
        Me.РасходDataGridViewTextBoxColumn1.DataPropertyName = "Расход"
        Me.РасходDataGridViewTextBoxColumn1.HeaderText = "Расход"
        Me.РасходDataGridViewTextBoxColumn1.Name = "РасходDataGridViewTextBoxColumn1"
        Me.РасходDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'tpWater
        '
        Me.tpWater.BackColor = System.Drawing.SystemColors.Control
        Me.tpWater.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tpWater.Controls.Add(Me.cmdCalculateWater)
        Me.tpWater.Controls.Add(Me.cmdNextWater)
        Me.tpWater.Controls.Add(Me.txtPotrWater)
        Me.tpWater.Controls.Add(Me.txtTarifWater)
        Me.tpWater.Controls.Add(Me.cmdAddNewWater)
        Me.tpWater.Controls.Add(Me.txtRashWater)
        Me.tpWater.Controls.Add(Me.cmdDeleteWater)
        Me.tpWater.Controls.Add(Me.Label13)
        Me.tpWater.Controls.Add(Me.cmdSaveWater)
        Me.tpWater.Controls.Add(Me.Label14)
        Me.tpWater.Controls.Add(Me.cmdPreviousWater)
        Me.tpWater.Controls.Add(Me.Label15)
        Me.tpWater.Controls.Add(Me.DataGridView1)
        Me.tpWater.Location = New System.Drawing.Point(4, 25)
        Me.tpWater.Name = "tpWater"
        Me.tpWater.Padding = New System.Windows.Forms.Padding(3)
        Me.tpWater.Size = New System.Drawing.Size(691, 135)
        Me.tpWater.TabIndex = 2
        Me.tpWater.Text = "Вода"
        '
        'cmdCalculateWater
        '
        Me.cmdCalculateWater.Location = New System.Drawing.Point(184, 107)
        Me.cmdCalculateWater.Name = "cmdCalculateWater"
        Me.cmdCalculateWater.Size = New System.Drawing.Size(75, 23)
        Me.cmdCalculateWater.TabIndex = 7
        Me.cmdCalculateWater.Text = "Рассчитать"
        Me.cmdCalculateWater.UseVisualStyleBackColor = True
        '
        'cmdNextWater
        '
        Me.cmdNextWater.Location = New System.Drawing.Point(184, 78)
        Me.cmdNextWater.Name = "cmdNextWater"
        Me.cmdNextWater.Size = New System.Drawing.Size(75, 23)
        Me.cmdNextWater.TabIndex = 30
        Me.cmdNextWater.Text = "Следующий"
        Me.cmdNextWater.UseVisualStyleBackColor = True
        '
        'txtPotrWater
        '
        Me.txtPotrWater.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ВодаBindingSource, "Потреблено", True))
        Me.txtPotrWater.Location = New System.Drawing.Point(103, 6)
        Me.txtPotrWater.Name = "txtPotrWater"
        Me.txtPotrWater.Size = New System.Drawing.Size(156, 20)
        Me.txtPotrWater.TabIndex = 5
        '
        'ВодаBindingSource
        '
        Me.ВодаBindingSource.DataMember = "Вода"
        Me.ВодаBindingSource.DataSource = Me.BookkeepingDatabaseDataSet
        '
        'txtTarifWater
        '
        Me.txtTarifWater.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ВодаBindingSource, "Тариф", True))
        Me.txtTarifWater.Location = New System.Drawing.Point(103, 29)
        Me.txtTarifWater.Name = "txtTarifWater"
        Me.txtTarifWater.Size = New System.Drawing.Size(156, 20)
        Me.txtTarifWater.TabIndex = 4
        '
        'cmdAddNewWater
        '
        Me.cmdAddNewWater.Location = New System.Drawing.Point(103, 78)
        Me.cmdAddNewWater.Name = "cmdAddNewWater"
        Me.cmdAddNewWater.Size = New System.Drawing.Size(75, 23)
        Me.cmdAddNewWater.TabIndex = 28
        Me.cmdAddNewWater.Text = "Добавить"
        Me.cmdAddNewWater.UseVisualStyleBackColor = True
        '
        'txtRashWater
        '
        Me.txtRashWater.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ВодаBindingSource, "Расход", True))
        Me.txtRashWater.Location = New System.Drawing.Point(103, 52)
        Me.txtRashWater.Name = "txtRashWater"
        Me.txtRashWater.ReadOnly = True
        Me.txtRashWater.Size = New System.Drawing.Size(156, 20)
        Me.txtRashWater.TabIndex = 3
        '
        'cmdDeleteWater
        '
        Me.cmdDeleteWater.Location = New System.Drawing.Point(103, 107)
        Me.cmdDeleteWater.Name = "cmdDeleteWater"
        Me.cmdDeleteWater.Size = New System.Drawing.Size(75, 23)
        Me.cmdDeleteWater.TabIndex = 27
        Me.cmdDeleteWater.Text = "Удалить"
        Me.cmdDeleteWater.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 55)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(43, 13)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Расход"
        '
        'cmdSaveWater
        '
        Me.cmdSaveWater.Location = New System.Drawing.Point(9, 107)
        Me.cmdSaveWater.Name = "cmdSaveWater"
        Me.cmdSaveWater.Size = New System.Drawing.Size(88, 23)
        Me.cmdSaveWater.TabIndex = 26
        Me.cmdSaveWater.Text = "Сохранить"
        Me.cmdSaveWater.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 32)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(40, 13)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Тариф"
        '
        'cmdPreviousWater
        '
        Me.cmdPreviousWater.Location = New System.Drawing.Point(9, 78)
        Me.cmdPreviousWater.Name = "cmdPreviousWater"
        Me.cmdPreviousWater.Size = New System.Drawing.Size(88, 23)
        Me.cmdPreviousWater.TabIndex = 25
        Me.cmdPreviousWater.Text = "Предыдущий"
        Me.cmdPreviousWater.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 9)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(68, 13)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Потреблено"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.КодDataGridViewTextBoxColumn3, Me.ПотребленоDataGridViewTextBoxColumn2, Me.ТарифDataGridViewTextBoxColumn2, Me.РасходDataGridViewTextBoxColumn2})
        Me.DataGridView1.DataSource = Me.ВодаBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(265, 6)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(416, 124)
        Me.DataGridView1.TabIndex = 0
        '
        'КодDataGridViewTextBoxColumn3
        '
        Me.КодDataGridViewTextBoxColumn3.DataPropertyName = "Код"
        Me.КодDataGridViewTextBoxColumn3.HeaderText = "Код"
        Me.КодDataGridViewTextBoxColumn3.Name = "КодDataGridViewTextBoxColumn3"
        Me.КодDataGridViewTextBoxColumn3.ReadOnly = True
        '
        'ПотребленоDataGridViewTextBoxColumn2
        '
        Me.ПотребленоDataGridViewTextBoxColumn2.DataPropertyName = "Потреблено"
        Me.ПотребленоDataGridViewTextBoxColumn2.HeaderText = "Потреблено"
        Me.ПотребленоDataGridViewTextBoxColumn2.Name = "ПотребленоDataGridViewTextBoxColumn2"
        Me.ПотребленоDataGridViewTextBoxColumn2.ReadOnly = True
        '
        'ТарифDataGridViewTextBoxColumn2
        '
        Me.ТарифDataGridViewTextBoxColumn2.DataPropertyName = "Тариф"
        Me.ТарифDataGridViewTextBoxColumn2.HeaderText = "Тариф"
        Me.ТарифDataGridViewTextBoxColumn2.Name = "ТарифDataGridViewTextBoxColumn2"
        Me.ТарифDataGridViewTextBoxColumn2.ReadOnly = True
        '
        'РасходDataGridViewTextBoxColumn2
        '
        Me.РасходDataGridViewTextBoxColumn2.DataPropertyName = "Расход"
        Me.РасходDataGridViewTextBoxColumn2.HeaderText = "Расход"
        Me.РасходDataGridViewTextBoxColumn2.Name = "РасходDataGridViewTextBoxColumn2"
        Me.РасходDataGridViewTextBoxColumn2.ReadOnly = True
        '
        'ПерсоналTableAdapter
        '
        Me.ПерсоналTableAdapter.ClearBeforeFill = True
        '
        'ЭлектричествоTableAdapter
        '
        Me.ЭлектричествоTableAdapter.ClearBeforeFill = True
        '
        'ГазTableAdapter
        '
        Me.ГазTableAdapter.ClearBeforeFill = True
        '
        'ВодаTableAdapter
        '
        Me.ВодаTableAdapter.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Blue
        Me.Panel1.Controls.Add(Me.lblMain)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1241, 64)
        Me.Panel1.TabIndex = 19
        '
        'lblMain
        '
        Me.lblMain.BackColor = System.Drawing.Color.Blue
        Me.lblMain.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblMain.ForeColor = System.Drawing.Color.White
        Me.lblMain.Location = New System.Drawing.Point(-2, 0)
        Me.lblMain.Name = "lblMain"
        Me.lblMain.Size = New System.Drawing.Size(100, 64)
        Me.lblMain.TabIndex = 2
        Me.lblMain.Text = "Главная"
        Me.lblMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmBookkeeping
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1241, 347)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.tabBookkeeping)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBookkeeping"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Бухгалтерия"
        Me.tabBookkeeping.ResumeLayout(False)
        Me.tpPersonal.ResumeLayout(False)
        Me.tpPersonal.PerformLayout()
        CType(Me.dgvStaff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ПерсоналBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookkeepingDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox12.PerformLayout()
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.tpMS.ResumeLayout(False)
        Me.tabMS.ResumeLayout(False)
        Me.tpElectricity.ResumeLayout(False)
        Me.tpElectricity.PerformLayout()
        CType(Me.ЭлектричествоBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpGas.ResumeLayout(False)
        Me.tpGas.PerformLayout()
        CType(Me.ГазBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpWater.ResumeLayout(False)
        Me.tpWater.PerformLayout()
        CType(Me.ВодаBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabBookkeeping As System.Windows.Forms.TabControl
    Friend WithEvents tpPersonal As System.Windows.Forms.TabPage
    Friend WithEvents cmdDeletePersonal As System.Windows.Forms.Button
    Friend WithEvents cmdAddNewPersonal As System.Windows.Forms.Button
    Friend WithEvents dgvStaff As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox12 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdDatabasePersonal As System.Windows.Forms.Button
    Friend WithEvents txtHolidayPay As System.Windows.Forms.TextBox
    Friend WithEvents cmdCalculateHolidayPay As System.Windows.Forms.Button
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents GroupBox11 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdCalculateSDZ As System.Windows.Forms.Button
    Friend WithEvents txtSDZ As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdCalculateWage As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtSalary As System.Windows.Forms.TextBox
    Friend WithEvents txtWage As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPatronymic As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtProfession As System.Windows.Forms.TextBox
    Friend WithEvents txtNumbWorkDay As System.Windows.Forms.TextBox
    Friend WithEvents txtNumbDaysWorked As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tpMS As System.Windows.Forms.TabPage
    Friend WithEvents tabMS As System.Windows.Forms.TabControl
    Friend WithEvents tpElectricity As System.Windows.Forms.TabPage
    Friend WithEvents cmdNextElectricity As System.Windows.Forms.Button
    Friend WithEvents cmdCalculateElectricity As System.Windows.Forms.Button
    Friend WithEvents txtRashElec As System.Windows.Forms.TextBox
    Friend WithEvents txtTarifElec As System.Windows.Forms.TextBox
    Friend WithEvents cmdPreviousElectricity As System.Windows.Forms.Button
    Friend WithEvents txtPotrElec As System.Windows.Forms.TextBox
    Friend WithEvents cmdAddNewElectricity As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents cmdSaveElectricity As System.Windows.Forms.Button
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents cmdDeleteElectricity As System.Windows.Forms.Button
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents DataGridView3 As System.Windows.Forms.DataGridView
    Friend WithEvents tpGas As System.Windows.Forms.TabPage
    Friend WithEvents cmdCalculateGas As System.Windows.Forms.Button
    Friend WithEvents txtPotrGas As System.Windows.Forms.TextBox
    Friend WithEvents cmdNextGas As System.Windows.Forms.Button
    Friend WithEvents txtTarifGas As System.Windows.Forms.TextBox
    Friend WithEvents txtRashGas As System.Windows.Forms.TextBox
    Friend WithEvents cmdAddNewGas As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmdDeleteGas As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cmdSaveGas As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cmdPreviousGas As System.Windows.Forms.Button
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents tpWater As System.Windows.Forms.TabPage
    Friend WithEvents cmdCalculateWater As System.Windows.Forms.Button
    Friend WithEvents cmdNextWater As System.Windows.Forms.Button
    Friend WithEvents txtPotrWater As System.Windows.Forms.TextBox
    Friend WithEvents txtTarifWater As System.Windows.Forms.TextBox
    Friend WithEvents cmdAddNewWater As System.Windows.Forms.Button
    Friend WithEvents txtRashWater As System.Windows.Forms.TextBox
    Friend WithEvents cmdDeleteWater As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cmdSaveWater As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cmdPreviousWater As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents cmdNextPersonal As System.Windows.Forms.Button
    Friend WithEvents cmdPreviousPersonal As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents cmdSearch As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BookkeepingDatabaseDataSet As SampleCourseProject.BookkeepingDatabaseDataSet
    Friend WithEvents ПерсоналBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ПерсоналTableAdapter As SampleCourseProject.BookkeepingDatabaseDataSetTableAdapters.ПерсоналTableAdapter
    Friend WithEvents ЭлектричествоBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ЭлектричествоTableAdapter As SampleCourseProject.BookkeepingDatabaseDataSetTableAdapters.ЭлектричествоTableAdapter
    Friend WithEvents КодDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ПотребленоDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ТарифDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents РасходDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ГазBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ГазTableAdapter As SampleCourseProject.BookkeepingDatabaseDataSetTableAdapters.ГазTableAdapter
    Friend WithEvents КодDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ПотребленоDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ТарифDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents РасходDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ВодаBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ВодаTableAdapter As SampleCourseProject.BookkeepingDatabaseDataSetTableAdapters.ВодаTableAdapter
    Friend WithEvents КодDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ПотребленоDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ТарифDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents РасходDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents lblReset As System.Windows.Forms.Label
    Friend WithEvents КодDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ФамилияDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ИмяDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ОтчествоDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ПрофессияDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents КоличествоРабочихДнейDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents КоличествоОтработанныхДнейDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ОкладDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ЗарплатаDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents СреднийДневнойЗаработокDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ОтпускныеDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblMain As System.Windows.Forms.Label

End Class
