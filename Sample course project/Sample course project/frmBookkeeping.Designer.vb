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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.ФайлToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.СправкаToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.TabControl4 = New System.Windows.Forms.TabControl
        Me.TabPage10 = New System.Windows.Forms.TabPage
        Me.TabPage11 = New System.Windows.Forms.TabPage
        Me.TabPage12 = New System.Windows.Forms.TabPage
        Me.cmdBackStaff = New System.Windows.Forms.Button
        Me.GroupBox9 = New System.Windows.Forms.GroupBox
        Me.GroupBox12 = New System.Windows.Forms.GroupBox
        Me.cmdDatabaseHolidayPay = New System.Windows.Forms.Button
        Me.txtHolidayPay = New System.Windows.Forms.TextBox
        Me.cmdCalculateHolidayPay = New System.Windows.Forms.Button
        Me.Label28 = New System.Windows.Forms.Label
        Me.GroupBox11 = New System.Windows.Forms.GroupBox
        Me.cmdDatabaseSDZ = New System.Windows.Forms.Button
        Me.cmdCalculateSDZ = New System.Windows.Forms.Button
        Me.txtSDZ = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox10 = New System.Windows.Forms.GroupBox
        Me.cmdDatabaseWage = New System.Windows.Forms.Button
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
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.TabControl3 = New System.Windows.Forms.TabControl
        Me.TabPage7 = New System.Windows.Forms.TabPage
        Me.cmdNext = New System.Windows.Forms.Button
        Me.cmdClose = New System.Windows.Forms.Button
        Me.cmdAddNew = New System.Windows.Forms.Button
        Me.cmdDelete = New System.Windows.Forms.Button
        Me.cmdSave = New System.Windows.Forms.Button
        Me.cmdPrevious = New System.Windows.Forms.Button
        Me.DataGridView3 = New System.Windows.Forms.DataGridView
        Me.КодDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ПотребленоDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ТарифDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.РасходDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ЭлектричествоBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabaseDataSet = New Sample_course_project.DatabaseDataSet
        Me.TabPage8 = New System.Windows.Forms.TabPage
        Me.DataGridView2 = New System.Windows.Forms.DataGridView
        Me.КодDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ПотребленоDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ТарифDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.РасходDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ГазBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPage9 = New System.Windows.Forms.TabPage
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.КодDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ПотребленоDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ТарифDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.РасходDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ВодаBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmdBackMS = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.cmdDatabaseGas = New System.Windows.Forms.Button
        Me.cmdCalculateGas = New System.Windows.Forms.Button
        Me.txtPotrGas = New System.Windows.Forms.TextBox
        Me.txtTarifGas = New System.Windows.Forms.TextBox
        Me.txtRashGas = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cmdDatabaseWater = New System.Windows.Forms.Button
        Me.cmdCalculateWater = New System.Windows.Forms.Button
        Me.txtPotrWater = New System.Windows.Forms.TextBox
        Me.txtTarifWater = New System.Windows.Forms.TextBox
        Me.txtRashWater = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmdDatabaseElectricity = New System.Windows.Forms.Button
        Me.cmdCalculateElectricity = New System.Windows.Forms.Button
        Me.txtRashElec = New System.Windows.Forms.TextBox
        Me.txtTarifElec = New System.Windows.Forms.TextBox
        Me.txtPotrElec = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.TabControl2 = New System.Windows.Forms.TabControl
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.DataGridView6 = New System.Windows.Forms.DataGridView
        Me.КодDataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.КоличествоDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ЦеназакгDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ДоходDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.СахарBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPage5 = New System.Windows.Forms.TabPage
        Me.DataGridView5 = New System.Windows.Forms.DataGridView
        Me.КодDataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.КоличествоDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ЦеназакгDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ДоходDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ЖомBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPage6 = New System.Windows.Forms.TabPage
        Me.DataGridView4 = New System.Windows.Forms.DataGridView
        Me.КодDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.КоличествоDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ЦеназакгDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ДоходDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.МелассаBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmdBackIncome = New System.Windows.Forms.Button
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.cmdDatabasePulp = New System.Windows.Forms.Button
        Me.txtNumberPulp = New System.Windows.Forms.TextBox
        Me.cmdCalculatePulp = New System.Windows.Forms.Button
        Me.txtPricePulp = New System.Windows.Forms.TextBox
        Me.txtIncomePulp = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.cmdDatabaseMolasses = New System.Windows.Forms.Button
        Me.txtNumberMolasses = New System.Windows.Forms.TextBox
        Me.cmdCalculateMolasses = New System.Windows.Forms.Button
        Me.txtPriceMolasses = New System.Windows.Forms.TextBox
        Me.txtIncomeMolasses = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.cmdDatabaseSugar = New System.Windows.Forms.Button
        Me.cmdCalculateSugar = New System.Windows.Forms.Button
        Me.txtIncomeSugar = New System.Windows.Forms.TextBox
        Me.txtPriceSugar = New System.Windows.Forms.TextBox
        Me.txtNumberSugar = New System.Windows.Forms.TextBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ВодаTableAdapter = New Sample_course_project.DatabaseDataSetTableAdapters.ВодаTableAdapter
        Me.ГазTableAdapter = New Sample_course_project.DatabaseDataSetTableAdapters.ГазTableAdapter
        Me.ЭлектричествоTableAdapter = New Sample_course_project.DatabaseDataSetTableAdapters.ЭлектричествоTableAdapter
        Me.МелассаTableAdapter = New Sample_course_project.DatabaseDataSetTableAdapters.МелассаTableAdapter
        Me.ЖомTableAdapter = New Sample_course_project.DatabaseDataSetTableAdapters.ЖомTableAdapter
        Me.СахарTableAdapter = New Sample_course_project.DatabaseDataSetTableAdapters.СахарTableAdapter
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.Button8 = New System.Windows.Forms.Button
        Me.DataGridView7 = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabControl4.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabControl3.SuspendLayout()
        Me.TabPage7.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ЭлектричествоBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage8.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ГазBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage9.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ВодаBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.DataGridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.СахарBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ЖомBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage6.SuspendLayout()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.МелассаBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.DataGridView7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ФайлToolStripMenuItem, Me.СправкаToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(879, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ФайлToolStripMenuItem
        '
        Me.ФайлToolStripMenuItem.Name = "ФайлToolStripMenuItem"
        Me.ФайлToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.ФайлToolStripMenuItem.Text = "Файл"
        '
        'СправкаToolStripMenuItem
        '
        Me.СправкаToolStripMenuItem.Name = "СправкаToolStripMenuItem"
        Me.СправкаToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.СправкаToolStripMenuItem.Text = "Справка"
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 24)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(879, 415)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TabControl4)
        Me.TabPage1.Controls.Add(Me.cmdBackStaff)
        Me.TabPage1.Controls.Add(Me.GroupBox9)
        Me.TabPage1.Controls.Add(Me.GroupBox8)
        Me.TabPage1.Controls.Add(Me.GroupBox7)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(871, 386)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Персонал"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabControl4
        '
        Me.TabControl4.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.TabControl4.Controls.Add(Me.TabPage10)
        Me.TabControl4.Controls.Add(Me.TabPage11)
        Me.TabControl4.Controls.Add(Me.TabPage12)
        Me.TabControl4.Location = New System.Drawing.Point(497, 6)
        Me.TabControl4.Name = "TabControl4"
        Me.TabControl4.SelectedIndex = 0
        Me.TabControl4.Size = New System.Drawing.Size(368, 258)
        Me.TabControl4.TabIndex = 51
        '
        'TabPage10
        '
        Me.TabPage10.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage10.Location = New System.Drawing.Point(4, 25)
        Me.TabPage10.Name = "TabPage10"
        Me.TabPage10.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage10.Size = New System.Drawing.Size(360, 229)
        Me.TabPage10.TabIndex = 0
        Me.TabPage10.Text = "Зарплата"
        '
        'TabPage11
        '
        Me.TabPage11.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage11.Location = New System.Drawing.Point(4, 25)
        Me.TabPage11.Name = "TabPage11"
        Me.TabPage11.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage11.Size = New System.Drawing.Size(360, 229)
        Me.TabPage11.TabIndex = 1
        Me.TabPage11.Text = "Средний дневной заработок"
        '
        'TabPage12
        '
        Me.TabPage12.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage12.Location = New System.Drawing.Point(4, 25)
        Me.TabPage12.Name = "TabPage12"
        Me.TabPage12.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage12.Size = New System.Drawing.Size(360, 229)
        Me.TabPage12.TabIndex = 2
        Me.TabPage12.Text = "Отпускные"
        '
        'cmdBackStaff
        '
        Me.cmdBackStaff.Location = New System.Drawing.Point(429, 83)
        Me.cmdBackStaff.Name = "cmdBackStaff"
        Me.cmdBackStaff.Size = New System.Drawing.Size(62, 23)
        Me.cmdBackStaff.TabIndex = 50
        Me.cmdBackStaff.Text = "Назад"
        Me.cmdBackStaff.UseVisualStyleBackColor = True
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.GroupBox12)
        Me.GroupBox9.Controls.Add(Me.GroupBox11)
        Me.GroupBox9.Controls.Add(Me.GroupBox10)
        Me.GroupBox9.Location = New System.Drawing.Point(8, 106)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(483, 158)
        Me.GroupBox9.TabIndex = 49
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Финансовые данные"
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.cmdDatabaseHolidayPay)
        Me.GroupBox12.Controls.Add(Me.txtHolidayPay)
        Me.GroupBox12.Controls.Add(Me.cmdCalculateHolidayPay)
        Me.GroupBox12.Controls.Add(Me.Label28)
        Me.GroupBox12.Location = New System.Drawing.Point(314, 19)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(162, 133)
        Me.GroupBox12.TabIndex = 48
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "Отпускные"
        '
        'cmdDatabaseHolidayPay
        '
        Me.cmdDatabaseHolidayPay.Location = New System.Drawing.Point(9, 99)
        Me.cmdDatabaseHolidayPay.Name = "cmdDatabaseHolidayPay"
        Me.cmdDatabaseHolidayPay.Size = New System.Drawing.Size(147, 21)
        Me.cmdDatabaseHolidayPay.TabIndex = 51
        Me.cmdDatabaseHolidayPay.Text = "Занести в базу"
        Me.cmdDatabaseHolidayPay.UseVisualStyleBackColor = True
        '
        'txtHolidayPay
        '
        Me.txtHolidayPay.Location = New System.Drawing.Point(75, 31)
        Me.txtHolidayPay.Name = "txtHolidayPay"
        Me.txtHolidayPay.Size = New System.Drawing.Size(78, 20)
        Me.txtHolidayPay.TabIndex = 48
        '
        'cmdCalculateHolidayPay
        '
        Me.cmdCalculateHolidayPay.Location = New System.Drawing.Point(9, 71)
        Me.cmdCalculateHolidayPay.Name = "cmdCalculateHolidayPay"
        Me.cmdCalculateHolidayPay.Size = New System.Drawing.Size(147, 21)
        Me.cmdCalculateHolidayPay.TabIndex = 50
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
        Me.GroupBox11.Controls.Add(Me.cmdDatabaseSDZ)
        Me.GroupBox11.Controls.Add(Me.cmdCalculateSDZ)
        Me.GroupBox11.Controls.Add(Me.txtSDZ)
        Me.GroupBox11.Controls.Add(Me.Label4)
        Me.GroupBox11.Location = New System.Drawing.Point(165, 19)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(124, 133)
        Me.GroupBox11.TabIndex = 47
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Средний дневной заработок"
        '
        'cmdDatabaseSDZ
        '
        Me.cmdDatabaseSDZ.Location = New System.Drawing.Point(11, 99)
        Me.cmdDatabaseSDZ.Name = "cmdDatabaseSDZ"
        Me.cmdDatabaseSDZ.Size = New System.Drawing.Size(102, 21)
        Me.cmdDatabaseSDZ.TabIndex = 49
        Me.cmdDatabaseSDZ.Text = "Занести в базу"
        Me.cmdDatabaseSDZ.UseVisualStyleBackColor = True
        '
        'cmdCalculateSDZ
        '
        Me.cmdCalculateSDZ.Location = New System.Drawing.Point(11, 71)
        Me.cmdCalculateSDZ.Name = "cmdCalculateSDZ"
        Me.cmdCalculateSDZ.Size = New System.Drawing.Size(102, 21)
        Me.cmdCalculateSDZ.TabIndex = 48
        Me.cmdCalculateSDZ.Text = "Рассчитать"
        Me.cmdCalculateSDZ.UseVisualStyleBackColor = True
        '
        'txtSDZ
        '
        Me.txtSDZ.Location = New System.Drawing.Point(44, 40)
        Me.txtSDZ.Name = "txtSDZ"
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
        Me.GroupBox10.Controls.Add(Me.cmdDatabaseWage)
        Me.GroupBox10.Controls.Add(Me.cmdCalculateWage)
        Me.GroupBox10.Controls.Add(Me.Label8)
        Me.GroupBox10.Controls.Add(Me.Label9)
        Me.GroupBox10.Controls.Add(Me.txtSalary)
        Me.GroupBox10.Controls.Add(Me.txtWage)
        Me.GroupBox10.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(137, 133)
        Me.GroupBox10.TabIndex = 46
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Зарплата"
        '
        'cmdDatabaseWage
        '
        Me.cmdDatabaseWage.Location = New System.Drawing.Point(15, 99)
        Me.cmdDatabaseWage.Name = "cmdDatabaseWage"
        Me.cmdDatabaseWage.Size = New System.Drawing.Size(115, 21)
        Me.cmdDatabaseWage.TabIndex = 47
        Me.cmdDatabaseWage.Text = "Занести в базу"
        Me.cmdDatabaseWage.UseVisualStyleBackColor = True
        '
        'cmdCalculateWage
        '
        Me.cmdCalculateWage.Location = New System.Drawing.Point(15, 71)
        Me.cmdCalculateWage.Name = "cmdCalculateWage"
        Me.cmdCalculateWage.Size = New System.Drawing.Size(115, 21)
        Me.cmdCalculateWage.TabIndex = 46
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
        Me.txtSalary.Location = New System.Drawing.Point(57, 18)
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(57, 20)
        Me.txtSalary.TabIndex = 35
        '
        'txtWage
        '
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
        Me.GroupBox8.Location = New System.Drawing.Point(8, 6)
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
        Me.txtPatronymic.Location = New System.Drawing.Point(63, 71)
        Me.txtPatronymic.MaxLength = 40
        Me.txtPatronymic.Name = "txtPatronymic"
        Me.txtPatronymic.Size = New System.Drawing.Size(113, 20)
        Me.txtPatronymic.TabIndex = 37
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(38, 44)
        Me.txtFirstName.MaxLength = 40
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(104, 20)
        Me.txtFirstName.TabIndex = 36
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(65, 17)
        Me.txtLastName.MaxLength = 40
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(111, 20)
        Me.txtLastName.TabIndex = 35
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Label5)
        Me.GroupBox7.Controls.Add(Me.txtProfession)
        Me.GroupBox7.Controls.Add(Me.txtNumbWorkDay)
        Me.GroupBox7.Controls.Add(Me.txtNumbDaysWorked)
        Me.GroupBox7.Controls.Add(Me.Label6)
        Me.GroupBox7.Controls.Add(Me.Label7)
        Me.GroupBox7.Location = New System.Drawing.Point(209, 6)
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
        Me.txtProfession.Location = New System.Drawing.Point(74, 21)
        Me.txtProfession.MaxLength = 40
        Me.txtProfession.Name = "txtProfession"
        Me.txtProfession.Size = New System.Drawing.Size(100, 20)
        Me.txtProfession.TabIndex = 29
        '
        'txtNumbWorkDay
        '
        Me.txtNumbWorkDay.Location = New System.Drawing.Point(145, 47)
        Me.txtNumbWorkDay.MaxLength = 2
        Me.txtNumbWorkDay.Name = "txtNumbWorkDay"
        Me.txtNumbWorkDay.Size = New System.Drawing.Size(28, 20)
        Me.txtNumbWorkDay.TabIndex = 32
        '
        'txtNumbDaysWorked
        '
        Me.txtNumbDaysWorked.Location = New System.Drawing.Point(176, 73)
        Me.txtNumbDaysWorked.MaxLength = 2
        Me.txtNumbDaysWorked.Name = "txtNumbDaysWorked"
        Me.txtNumbDaysWorked.Size = New System.Drawing.Size(28, 20)
        Me.txtNumbDaysWorked.TabIndex = 33
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
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TabControl3)
        Me.TabPage2.Controls.Add(Me.cmdBackMS)
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(871, 386)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Комм. услуги"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabControl3
        '
        Me.TabControl3.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.TabControl3.Controls.Add(Me.TabPage7)
        Me.TabControl3.Controls.Add(Me.TabPage8)
        Me.TabControl3.Controls.Add(Me.TabPage9)
        Me.TabControl3.Location = New System.Drawing.Point(274, 6)
        Me.TabControl3.Name = "TabControl3"
        Me.TabControl3.SelectedIndex = 0
        Me.TabControl3.Size = New System.Drawing.Size(438, 319)
        Me.TabControl3.TabIndex = 18
        '
        'TabPage7
        '
        Me.TabPage7.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage7.Controls.Add(Me.cmdNext)
        Me.TabPage7.Controls.Add(Me.cmdClose)
        Me.TabPage7.Controls.Add(Me.cmdAddNew)
        Me.TabPage7.Controls.Add(Me.cmdDelete)
        Me.TabPage7.Controls.Add(Me.cmdSave)
        Me.TabPage7.Controls.Add(Me.cmdPrevious)
        Me.TabPage7.Controls.Add(Me.DataGridView3)
        Me.TabPage7.Location = New System.Drawing.Point(4, 25)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage7.Size = New System.Drawing.Size(430, 290)
        Me.TabPage7.TabIndex = 0
        Me.TabPage7.Text = "Электричество"
        '
        'cmdNext
        '
        Me.cmdNext.Location = New System.Drawing.Point(255, 224)
        Me.cmdNext.Name = "cmdNext"
        Me.cmdNext.Size = New System.Drawing.Size(75, 23)
        Me.cmdNext.TabIndex = 24
        Me.cmdNext.Text = "Next"
        Me.cmdNext.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(255, 253)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 23)
        Me.cmdClose.TabIndex = 23
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdAddNew
        '
        Me.cmdAddNew.Location = New System.Drawing.Point(174, 224)
        Me.cmdAddNew.Name = "cmdAddNew"
        Me.cmdAddNew.Size = New System.Drawing.Size(75, 23)
        Me.cmdAddNew.TabIndex = 22
        Me.cmdAddNew.Text = "Add new"
        Me.cmdAddNew.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(174, 253)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(75, 23)
        Me.cmdDelete.TabIndex = 21
        Me.cmdDelete.Text = "Delete"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(93, 253)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 23)
        Me.cmdSave.TabIndex = 20
        Me.cmdSave.Text = "Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdPrevious
        '
        Me.cmdPrevious.Location = New System.Drawing.Point(93, 224)
        Me.cmdPrevious.Name = "cmdPrevious"
        Me.cmdPrevious.Size = New System.Drawing.Size(75, 23)
        Me.cmdPrevious.TabIndex = 19
        Me.cmdPrevious.Text = "Previous"
        Me.cmdPrevious.UseVisualStyleBackColor = True
        '
        'DataGridView3
        '
        Me.DataGridView3.AutoGenerateColumns = False
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.КодDataGridViewTextBoxColumn2, Me.ПотребленоDataGridViewTextBoxColumn2, Me.ТарифDataGridViewTextBoxColumn2, Me.РасходDataGridViewTextBoxColumn2})
        Me.DataGridView3.DataSource = Me.ЭлектричествоBindingSource
        Me.DataGridView3.Location = New System.Drawing.Point(6, 6)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(416, 212)
        Me.DataGridView3.TabIndex = 0
        '
        'КодDataGridViewTextBoxColumn2
        '
        Me.КодDataGridViewTextBoxColumn2.DataPropertyName = "Код"
        Me.КодDataGridViewTextBoxColumn2.HeaderText = "Код"
        Me.КодDataGridViewTextBoxColumn2.Name = "КодDataGridViewTextBoxColumn2"
        Me.КодDataGridViewTextBoxColumn2.Width = 73
        '
        'ПотребленоDataGridViewTextBoxColumn2
        '
        Me.ПотребленоDataGridViewTextBoxColumn2.DataPropertyName = "Потреблено"
        Me.ПотребленоDataGridViewTextBoxColumn2.HeaderText = "Потреблено"
        Me.ПотребленоDataGridViewTextBoxColumn2.Name = "ПотребленоDataGridViewTextBoxColumn2"
        '
        'ТарифDataGridViewTextBoxColumn2
        '
        Me.ТарифDataGridViewTextBoxColumn2.DataPropertyName = "Тариф"
        Me.ТарифDataGridViewTextBoxColumn2.HeaderText = "Тариф"
        Me.ТарифDataGridViewTextBoxColumn2.Name = "ТарифDataGridViewTextBoxColumn2"
        '
        'РасходDataGridViewTextBoxColumn2
        '
        Me.РасходDataGridViewTextBoxColumn2.DataPropertyName = "Расход"
        Me.РасходDataGridViewTextBoxColumn2.HeaderText = "Расход"
        Me.РасходDataGridViewTextBoxColumn2.Name = "РасходDataGridViewTextBoxColumn2"
        '
        'ЭлектричествоBindingSource
        '
        Me.ЭлектричествоBindingSource.DataMember = "Электричество"
        Me.ЭлектричествоBindingSource.DataSource = Me.DatabaseDataSet
        '
        'DatabaseDataSet
        '
        Me.DatabaseDataSet.DataSetName = "DatabaseDataSet"
        Me.DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabPage8
        '
        Me.TabPage8.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage8.Controls.Add(Me.DataGridView2)
        Me.TabPage8.Location = New System.Drawing.Point(4, 25)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage8.Size = New System.Drawing.Size(430, 290)
        Me.TabPage8.TabIndex = 1
        Me.TabPage8.Text = "Газ"
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.КодDataGridViewTextBoxColumn1, Me.ПотребленоDataGridViewTextBoxColumn1, Me.ТарифDataGridViewTextBoxColumn1, Me.РасходDataGridViewTextBoxColumn1})
        Me.DataGridView2.DataSource = Me.ГазBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(6, 6)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(416, 227)
        Me.DataGridView2.TabIndex = 0
        '
        'КодDataGridViewTextBoxColumn1
        '
        Me.КодDataGridViewTextBoxColumn1.DataPropertyName = "Код"
        Me.КодDataGridViewTextBoxColumn1.HeaderText = "Код"
        Me.КодDataGridViewTextBoxColumn1.Name = "КодDataGridViewTextBoxColumn1"
        Me.КодDataGridViewTextBoxColumn1.Width = 73
        '
        'ПотребленоDataGridViewTextBoxColumn1
        '
        Me.ПотребленоDataGridViewTextBoxColumn1.DataPropertyName = "Потреблено"
        Me.ПотребленоDataGridViewTextBoxColumn1.HeaderText = "Потреблено"
        Me.ПотребленоDataGridViewTextBoxColumn1.Name = "ПотребленоDataGridViewTextBoxColumn1"
        '
        'ТарифDataGridViewTextBoxColumn1
        '
        Me.ТарифDataGridViewTextBoxColumn1.DataPropertyName = "Тариф"
        Me.ТарифDataGridViewTextBoxColumn1.HeaderText = "Тариф"
        Me.ТарифDataGridViewTextBoxColumn1.Name = "ТарифDataGridViewTextBoxColumn1"
        '
        'РасходDataGridViewTextBoxColumn1
        '
        Me.РасходDataGridViewTextBoxColumn1.DataPropertyName = "Расход"
        Me.РасходDataGridViewTextBoxColumn1.HeaderText = "Расход"
        Me.РасходDataGridViewTextBoxColumn1.Name = "РасходDataGridViewTextBoxColumn1"
        '
        'ГазBindingSource
        '
        Me.ГазBindingSource.DataMember = "Газ"
        Me.ГазBindingSource.DataSource = Me.DatabaseDataSet
        '
        'TabPage9
        '
        Me.TabPage9.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage9.Controls.Add(Me.DataGridView1)
        Me.TabPage9.Location = New System.Drawing.Point(4, 25)
        Me.TabPage9.Name = "TabPage9"
        Me.TabPage9.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage9.Size = New System.Drawing.Size(430, 290)
        Me.TabPage9.TabIndex = 2
        Me.TabPage9.Text = "Вода"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.КодDataGridViewTextBoxColumn, Me.ПотребленоDataGridViewTextBoxColumn, Me.ТарифDataGridViewTextBoxColumn, Me.РасходDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ВодаBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(6, 6)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(416, 227)
        Me.DataGridView1.TabIndex = 0
        '
        'КодDataGridViewTextBoxColumn
        '
        Me.КодDataGridViewTextBoxColumn.DataPropertyName = "Код"
        Me.КодDataGridViewTextBoxColumn.HeaderText = "Код"
        Me.КодDataGridViewTextBoxColumn.Name = "КодDataGridViewTextBoxColumn"
        Me.КодDataGridViewTextBoxColumn.Width = 73
        '
        'ПотребленоDataGridViewTextBoxColumn
        '
        Me.ПотребленоDataGridViewTextBoxColumn.DataPropertyName = "Потреблено"
        Me.ПотребленоDataGridViewTextBoxColumn.HeaderText = "Потреблено"
        Me.ПотребленоDataGridViewTextBoxColumn.Name = "ПотребленоDataGridViewTextBoxColumn"
        '
        'ТарифDataGridViewTextBoxColumn
        '
        Me.ТарифDataGridViewTextBoxColumn.DataPropertyName = "Тариф"
        Me.ТарифDataGridViewTextBoxColumn.HeaderText = "Тариф"
        Me.ТарифDataGridViewTextBoxColumn.Name = "ТарифDataGridViewTextBoxColumn"
        '
        'РасходDataGridViewTextBoxColumn
        '
        Me.РасходDataGridViewTextBoxColumn.DataPropertyName = "Расход"
        Me.РасходDataGridViewTextBoxColumn.HeaderText = "Расход"
        Me.РасходDataGridViewTextBoxColumn.Name = "РасходDataGridViewTextBoxColumn"
        '
        'ВодаBindingSource
        '
        Me.ВодаBindingSource.DataMember = "Вода"
        Me.ВодаBindingSource.DataSource = Me.DatabaseDataSet
        '
        'cmdBackMS
        '
        Me.cmdBackMS.Location = New System.Drawing.Point(8, 331)
        Me.cmdBackMS.Name = "cmdBackMS"
        Me.cmdBackMS.Size = New System.Drawing.Size(75, 23)
        Me.cmdBackMS.TabIndex = 17
        Me.cmdBackMS.Text = "Назад"
        Me.cmdBackMS.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmdDatabaseGas)
        Me.GroupBox3.Controls.Add(Me.cmdCalculateGas)
        Me.GroupBox3.Controls.Add(Me.txtPotrGas)
        Me.GroupBox3.Controls.Add(Me.txtTarifGas)
        Me.GroupBox3.Controls.Add(Me.txtRashGas)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 115)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(260, 101)
        Me.GroupBox3.TabIndex = 16
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Газ"
        '
        'cmdDatabaseGas
        '
        Me.cmdDatabaseGas.Location = New System.Drawing.Point(178, 53)
        Me.cmdDatabaseGas.Name = "cmdDatabaseGas"
        Me.cmdDatabaseGas.Size = New System.Drawing.Size(75, 40)
        Me.cmdDatabaseGas.TabIndex = 18
        Me.cmdDatabaseGas.Text = "Занести в базу"
        Me.cmdDatabaseGas.UseVisualStyleBackColor = True
        '
        'cmdCalculateGas
        '
        Me.cmdCalculateGas.Location = New System.Drawing.Point(178, 27)
        Me.cmdCalculateGas.Name = "cmdCalculateGas"
        Me.cmdCalculateGas.Size = New System.Drawing.Size(75, 23)
        Me.cmdCalculateGas.TabIndex = 17
        Me.cmdCalculateGas.Text = "Рассчитать"
        Me.cmdCalculateGas.UseVisualStyleBackColor = True
        '
        'txtPotrGas
        '
        Me.txtPotrGas.Location = New System.Drawing.Point(94, 27)
        Me.txtPotrGas.Name = "txtPotrGas"
        Me.txtPotrGas.Size = New System.Drawing.Size(78, 20)
        Me.txtPotrGas.TabIndex = 5
        '
        'txtTarifGas
        '
        Me.txtTarifGas.Location = New System.Drawing.Point(94, 50)
        Me.txtTarifGas.Name = "txtTarifGas"
        Me.txtTarifGas.Size = New System.Drawing.Size(78, 20)
        Me.txtTarifGas.TabIndex = 4
        '
        'txtRashGas
        '
        Me.txtRashGas.Location = New System.Drawing.Point(94, 73)
        Me.txtRashGas.Name = "txtRashGas"
        Me.txtRashGas.ReadOnly = True
        Me.txtRashGas.Size = New System.Drawing.Size(78, 20)
        Me.txtRashGas.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 76)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Расход"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 53)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 13)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Тариф"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 30)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(68, 13)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Потреблено"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmdDatabaseWater)
        Me.GroupBox2.Controls.Add(Me.cmdCalculateWater)
        Me.GroupBox2.Controls.Add(Me.txtPotrWater)
        Me.GroupBox2.Controls.Add(Me.txtTarifWater)
        Me.GroupBox2.Controls.Add(Me.txtRashWater)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 222)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(260, 103)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Вода"
        '
        'cmdDatabaseWater
        '
        Me.cmdDatabaseWater.Location = New System.Drawing.Point(178, 53)
        Me.cmdDatabaseWater.Name = "cmdDatabaseWater"
        Me.cmdDatabaseWater.Size = New System.Drawing.Size(75, 40)
        Me.cmdDatabaseWater.TabIndex = 20
        Me.cmdDatabaseWater.Text = "Занести в базу"
        Me.cmdDatabaseWater.UseVisualStyleBackColor = True
        '
        'cmdCalculateWater
        '
        Me.cmdCalculateWater.Location = New System.Drawing.Point(178, 27)
        Me.cmdCalculateWater.Name = "cmdCalculateWater"
        Me.cmdCalculateWater.Size = New System.Drawing.Size(75, 23)
        Me.cmdCalculateWater.TabIndex = 7
        Me.cmdCalculateWater.Text = "Рассчитать"
        Me.cmdCalculateWater.UseVisualStyleBackColor = True
        '
        'txtPotrWater
        '
        Me.txtPotrWater.Location = New System.Drawing.Point(94, 27)
        Me.txtPotrWater.Name = "txtPotrWater"
        Me.txtPotrWater.Size = New System.Drawing.Size(78, 20)
        Me.txtPotrWater.TabIndex = 5
        '
        'txtTarifWater
        '
        Me.txtTarifWater.Location = New System.Drawing.Point(94, 50)
        Me.txtTarifWater.Name = "txtTarifWater"
        Me.txtTarifWater.Size = New System.Drawing.Size(78, 20)
        Me.txtTarifWater.TabIndex = 4
        '
        'txtRashWater
        '
        Me.txtRashWater.Location = New System.Drawing.Point(94, 73)
        Me.txtRashWater.Name = "txtRashWater"
        Me.txtRashWater.ReadOnly = True
        Me.txtRashWater.Size = New System.Drawing.Size(78, 20)
        Me.txtRashWater.TabIndex = 3
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 76)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(43, 13)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Расход"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 53)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(40, 13)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Тариф"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 30)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(68, 13)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Потреблено"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdDatabaseElectricity)
        Me.GroupBox1.Controls.Add(Me.cmdCalculateElectricity)
        Me.GroupBox1.Controls.Add(Me.txtRashElec)
        Me.GroupBox1.Controls.Add(Me.txtTarifElec)
        Me.GroupBox1.Controls.Add(Me.txtPotrElec)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(260, 103)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Электричество"
        '
        'cmdDatabaseElectricity
        '
        Me.cmdDatabaseElectricity.Location = New System.Drawing.Point(178, 53)
        Me.cmdDatabaseElectricity.Name = "cmdDatabaseElectricity"
        Me.cmdDatabaseElectricity.Size = New System.Drawing.Size(75, 40)
        Me.cmdDatabaseElectricity.TabIndex = 19
        Me.cmdDatabaseElectricity.Text = "Занести в базу"
        Me.cmdDatabaseElectricity.UseVisualStyleBackColor = True
        '
        'cmdCalculateElectricity
        '
        Me.cmdCalculateElectricity.Location = New System.Drawing.Point(178, 27)
        Me.cmdCalculateElectricity.Name = "cmdCalculateElectricity"
        Me.cmdCalculateElectricity.Size = New System.Drawing.Size(75, 23)
        Me.cmdCalculateElectricity.TabIndex = 6
        Me.cmdCalculateElectricity.Text = "Рассчитать"
        Me.cmdCalculateElectricity.UseVisualStyleBackColor = True
        '
        'txtRashElec
        '
        Me.txtRashElec.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ЭлектричествоBindingSource, "Расход", True))
        Me.txtRashElec.Location = New System.Drawing.Point(94, 73)
        Me.txtRashElec.Name = "txtRashElec"
        Me.txtRashElec.ReadOnly = True
        Me.txtRashElec.Size = New System.Drawing.Size(78, 20)
        Me.txtRashElec.TabIndex = 5
        '
        'txtTarifElec
        '
        Me.txtTarifElec.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ЭлектричествоBindingSource, "Тариф", True))
        Me.txtTarifElec.Location = New System.Drawing.Point(94, 50)
        Me.txtTarifElec.Name = "txtTarifElec"
        Me.txtTarifElec.Size = New System.Drawing.Size(78, 20)
        Me.txtTarifElec.TabIndex = 4
        '
        'txtPotrElec
        '
        Me.txtPotrElec.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ЭлектричествоBindingSource, "Потреблено", True))
        Me.txtPotrElec.Location = New System.Drawing.Point(94, 27)
        Me.txtPotrElec.Name = "txtPotrElec"
        Me.txtPotrElec.Size = New System.Drawing.Size(78, 20)
        Me.txtPotrElec.TabIndex = 3
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 76)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(43, 13)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "Расход"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(6, 53)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(40, 13)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "Тариф"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(6, 30)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(68, 13)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "Потреблено"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.TabControl2)
        Me.TabPage3.Controls.Add(Me.cmdBackIncome)
        Me.TabPage3.Controls.Add(Me.GroupBox4)
        Me.TabPage3.Controls.Add(Me.GroupBox5)
        Me.TabPage3.Controls.Add(Me.GroupBox6)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(871, 386)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Прибыль"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TabControl2
        '
        Me.TabControl2.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Controls.Add(Me.TabPage5)
        Me.TabControl2.Controls.Add(Me.TabPage6)
        Me.TabControl2.Location = New System.Drawing.Point(297, 6)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(415, 319)
        Me.TabControl2.TabIndex = 25
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage4.Controls.Add(Me.DataGridView6)
        Me.TabPage4.Location = New System.Drawing.Point(4, 25)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(407, 290)
        Me.TabPage4.TabIndex = 0
        Me.TabPage4.Text = "Сахар"
        '
        'DataGridView6
        '
        Me.DataGridView6.AutoGenerateColumns = False
        Me.DataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView6.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.КодDataGridViewTextBoxColumn5, Me.КоличествоDataGridViewTextBoxColumn2, Me.ЦеназакгDataGridViewTextBoxColumn2, Me.ДоходDataGridViewTextBoxColumn2})
        Me.DataGridView6.DataSource = Me.СахарBindingSource
        Me.DataGridView6.Location = New System.Drawing.Point(6, 6)
        Me.DataGridView6.Name = "DataGridView6"
        Me.DataGridView6.Size = New System.Drawing.Size(393, 227)
        Me.DataGridView6.TabIndex = 0
        '
        'КодDataGridViewTextBoxColumn5
        '
        Me.КодDataGridViewTextBoxColumn5.DataPropertyName = "Код"
        Me.КодDataGridViewTextBoxColumn5.HeaderText = "Код"
        Me.КодDataGridViewTextBoxColumn5.Name = "КодDataGridViewTextBoxColumn5"
        Me.КодDataGridViewTextBoxColumn5.Width = 50
        '
        'КоличествоDataGridViewTextBoxColumn2
        '
        Me.КоличествоDataGridViewTextBoxColumn2.DataPropertyName = "Количество"
        Me.КоличествоDataGridViewTextBoxColumn2.HeaderText = "Количество"
        Me.КоличествоDataGridViewTextBoxColumn2.Name = "КоличествоDataGridViewTextBoxColumn2"
        '
        'ЦеназакгDataGridViewTextBoxColumn2
        '
        Me.ЦеназакгDataGridViewTextBoxColumn2.DataPropertyName = "Цена_за_кг"
        Me.ЦеназакгDataGridViewTextBoxColumn2.HeaderText = "Цена_за_кг"
        Me.ЦеназакгDataGridViewTextBoxColumn2.Name = "ЦеназакгDataGridViewTextBoxColumn2"
        '
        'ДоходDataGridViewTextBoxColumn2
        '
        Me.ДоходDataGridViewTextBoxColumn2.DataPropertyName = "Доход"
        Me.ДоходDataGridViewTextBoxColumn2.HeaderText = "Доход"
        Me.ДоходDataGridViewTextBoxColumn2.Name = "ДоходDataGridViewTextBoxColumn2"
        '
        'СахарBindingSource
        '
        Me.СахарBindingSource.DataMember = "Сахар"
        Me.СахарBindingSource.DataSource = Me.DatabaseDataSet
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage5.Controls.Add(Me.DataGridView5)
        Me.TabPage5.Location = New System.Drawing.Point(4, 25)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(407, 290)
        Me.TabPage5.TabIndex = 1
        Me.TabPage5.Text = "Жом"
        '
        'DataGridView5
        '
        Me.DataGridView5.AutoGenerateColumns = False
        Me.DataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView5.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.КодDataGridViewTextBoxColumn4, Me.КоличествоDataGridViewTextBoxColumn1, Me.ЦеназакгDataGridViewTextBoxColumn1, Me.ДоходDataGridViewTextBoxColumn1})
        Me.DataGridView5.DataSource = Me.ЖомBindingSource
        Me.DataGridView5.Location = New System.Drawing.Point(6, 6)
        Me.DataGridView5.Name = "DataGridView5"
        Me.DataGridView5.Size = New System.Drawing.Size(393, 227)
        Me.DataGridView5.TabIndex = 0
        '
        'КодDataGridViewTextBoxColumn4
        '
        Me.КодDataGridViewTextBoxColumn4.DataPropertyName = "Код"
        Me.КодDataGridViewTextBoxColumn4.HeaderText = "Код"
        Me.КодDataGridViewTextBoxColumn4.Name = "КодDataGridViewTextBoxColumn4"
        Me.КодDataGridViewTextBoxColumn4.Width = 50
        '
        'КоличествоDataGridViewTextBoxColumn1
        '
        Me.КоличествоDataGridViewTextBoxColumn1.DataPropertyName = "Количество"
        Me.КоличествоDataGridViewTextBoxColumn1.HeaderText = "Количество"
        Me.КоличествоDataGridViewTextBoxColumn1.Name = "КоличествоDataGridViewTextBoxColumn1"
        '
        'ЦеназакгDataGridViewTextBoxColumn1
        '
        Me.ЦеназакгDataGridViewTextBoxColumn1.DataPropertyName = "Цена_за_кг"
        Me.ЦеназакгDataGridViewTextBoxColumn1.HeaderText = "Цена_за_кг"
        Me.ЦеназакгDataGridViewTextBoxColumn1.Name = "ЦеназакгDataGridViewTextBoxColumn1"
        '
        'ДоходDataGridViewTextBoxColumn1
        '
        Me.ДоходDataGridViewTextBoxColumn1.DataPropertyName = "Доход"
        Me.ДоходDataGridViewTextBoxColumn1.HeaderText = "Доход"
        Me.ДоходDataGridViewTextBoxColumn1.Name = "ДоходDataGridViewTextBoxColumn1"
        '
        'ЖомBindingSource
        '
        Me.ЖомBindingSource.DataMember = "Жом"
        Me.ЖомBindingSource.DataSource = Me.DatabaseDataSet
        '
        'TabPage6
        '
        Me.TabPage6.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage6.Controls.Add(Me.DataGridView4)
        Me.TabPage6.Location = New System.Drawing.Point(4, 25)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(407, 290)
        Me.TabPage6.TabIndex = 2
        Me.TabPage6.Text = "Меласса"
        '
        'DataGridView4
        '
        Me.DataGridView4.AutoGenerateColumns = False
        Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView4.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.КодDataGridViewTextBoxColumn3, Me.КоличествоDataGridViewTextBoxColumn, Me.ЦеназакгDataGridViewTextBoxColumn, Me.ДоходDataGridViewTextBoxColumn})
        Me.DataGridView4.DataSource = Me.МелассаBindingSource
        Me.DataGridView4.Location = New System.Drawing.Point(6, 6)
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.Size = New System.Drawing.Size(393, 227)
        Me.DataGridView4.TabIndex = 0
        '
        'КодDataGridViewTextBoxColumn3
        '
        Me.КодDataGridViewTextBoxColumn3.DataPropertyName = "Код"
        Me.КодDataGridViewTextBoxColumn3.HeaderText = "Код"
        Me.КодDataGridViewTextBoxColumn3.Name = "КодDataGridViewTextBoxColumn3"
        Me.КодDataGridViewTextBoxColumn3.Width = 50
        '
        'КоличествоDataGridViewTextBoxColumn
        '
        Me.КоличествоDataGridViewTextBoxColumn.DataPropertyName = "Количество"
        Me.КоличествоDataGridViewTextBoxColumn.HeaderText = "Количество"
        Me.КоличествоDataGridViewTextBoxColumn.Name = "КоличествоDataGridViewTextBoxColumn"
        '
        'ЦеназакгDataGridViewTextBoxColumn
        '
        Me.ЦеназакгDataGridViewTextBoxColumn.DataPropertyName = "Цена_за_кг"
        Me.ЦеназакгDataGridViewTextBoxColumn.HeaderText = "Цена_за_кг"
        Me.ЦеназакгDataGridViewTextBoxColumn.Name = "ЦеназакгDataGridViewTextBoxColumn"
        '
        'ДоходDataGridViewTextBoxColumn
        '
        Me.ДоходDataGridViewTextBoxColumn.DataPropertyName = "Доход"
        Me.ДоходDataGridViewTextBoxColumn.HeaderText = "Доход"
        Me.ДоходDataGridViewTextBoxColumn.Name = "ДоходDataGridViewTextBoxColumn"
        '
        'МелассаBindingSource
        '
        Me.МелассаBindingSource.DataMember = "Меласса"
        Me.МелассаBindingSource.DataSource = Me.DatabaseDataSet
        '
        'cmdBackIncome
        '
        Me.cmdBackIncome.Location = New System.Drawing.Point(8, 331)
        Me.cmdBackIncome.Name = "cmdBackIncome"
        Me.cmdBackIncome.Size = New System.Drawing.Size(75, 23)
        Me.cmdBackIncome.TabIndex = 24
        Me.cmdBackIncome.Text = "Назад"
        Me.cmdBackIncome.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cmdDatabasePulp)
        Me.GroupBox4.Controls.Add(Me.txtNumberPulp)
        Me.GroupBox4.Controls.Add(Me.cmdCalculatePulp)
        Me.GroupBox4.Controls.Add(Me.txtPricePulp)
        Me.GroupBox4.Controls.Add(Me.txtIncomePulp)
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Controls.Add(Me.Label21)
        Me.GroupBox4.Location = New System.Drawing.Point(8, 115)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(283, 101)
        Me.GroupBox4.TabIndex = 23
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Жом"
        '
        'cmdDatabasePulp
        '
        Me.cmdDatabasePulp.Location = New System.Drawing.Point(182, 53)
        Me.cmdDatabasePulp.Name = "cmdDatabasePulp"
        Me.cmdDatabasePulp.Size = New System.Drawing.Size(83, 40)
        Me.cmdDatabasePulp.TabIndex = 9
        Me.cmdDatabasePulp.Text = "Занести в базу"
        Me.cmdDatabasePulp.UseVisualStyleBackColor = True
        '
        'txtNumberPulp
        '
        Me.txtNumberPulp.Location = New System.Drawing.Point(98, 27)
        Me.txtNumberPulp.Name = "txtNumberPulp"
        Me.txtNumberPulp.Size = New System.Drawing.Size(78, 20)
        Me.txtNumberPulp.TabIndex = 5
        '
        'cmdCalculatePulp
        '
        Me.cmdCalculatePulp.Location = New System.Drawing.Point(182, 27)
        Me.cmdCalculatePulp.Name = "cmdCalculatePulp"
        Me.cmdCalculatePulp.Size = New System.Drawing.Size(83, 23)
        Me.cmdCalculatePulp.TabIndex = 8
        Me.cmdCalculatePulp.Text = "Рассчитать"
        Me.cmdCalculatePulp.UseVisualStyleBackColor = True
        '
        'txtPricePulp
        '
        Me.txtPricePulp.Location = New System.Drawing.Point(98, 50)
        Me.txtPricePulp.Name = "txtPricePulp"
        Me.txtPricePulp.Size = New System.Drawing.Size(78, 20)
        Me.txtPricePulp.TabIndex = 4
        '
        'txtIncomePulp
        '
        Me.txtIncomePulp.Location = New System.Drawing.Point(98, 73)
        Me.txtIncomePulp.Name = "txtIncomePulp"
        Me.txtIncomePulp.ReadOnly = True
        Me.txtIncomePulp.Size = New System.Drawing.Size(78, 20)
        Me.txtIncomePulp.TabIndex = 3
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(6, 76)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(39, 13)
        Me.Label19.TabIndex = 2
        Me.Label19.Text = "Доход"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(6, 53)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(62, 13)
        Me.Label20.TabIndex = 1
        Me.Label20.Text = "Цена за кг"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(6, 30)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(86, 13)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "Количество (кг)"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.cmdDatabaseMolasses)
        Me.GroupBox5.Controls.Add(Me.txtNumberMolasses)
        Me.GroupBox5.Controls.Add(Me.cmdCalculateMolasses)
        Me.GroupBox5.Controls.Add(Me.txtPriceMolasses)
        Me.GroupBox5.Controls.Add(Me.txtIncomeMolasses)
        Me.GroupBox5.Controls.Add(Me.Label22)
        Me.GroupBox5.Controls.Add(Me.Label23)
        Me.GroupBox5.Controls.Add(Me.Label24)
        Me.GroupBox5.Location = New System.Drawing.Point(8, 222)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(283, 103)
        Me.GroupBox5.TabIndex = 22
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Меласса"
        '
        'cmdDatabaseMolasses
        '
        Me.cmdDatabaseMolasses.Location = New System.Drawing.Point(182, 53)
        Me.cmdDatabaseMolasses.Name = "cmdDatabaseMolasses"
        Me.cmdDatabaseMolasses.Size = New System.Drawing.Size(83, 40)
        Me.cmdDatabaseMolasses.TabIndex = 11
        Me.cmdDatabaseMolasses.Text = "Занести в базу"
        Me.cmdDatabaseMolasses.UseVisualStyleBackColor = True
        '
        'txtNumberMolasses
        '
        Me.txtNumberMolasses.Location = New System.Drawing.Point(98, 27)
        Me.txtNumberMolasses.Name = "txtNumberMolasses"
        Me.txtNumberMolasses.Size = New System.Drawing.Size(78, 20)
        Me.txtNumberMolasses.TabIndex = 5
        '
        'cmdCalculateMolasses
        '
        Me.cmdCalculateMolasses.Location = New System.Drawing.Point(182, 27)
        Me.cmdCalculateMolasses.Name = "cmdCalculateMolasses"
        Me.cmdCalculateMolasses.Size = New System.Drawing.Size(83, 23)
        Me.cmdCalculateMolasses.TabIndex = 10
        Me.cmdCalculateMolasses.Text = "Рассчитать"
        Me.cmdCalculateMolasses.UseVisualStyleBackColor = True
        '
        'txtPriceMolasses
        '
        Me.txtPriceMolasses.Location = New System.Drawing.Point(98, 50)
        Me.txtPriceMolasses.Name = "txtPriceMolasses"
        Me.txtPriceMolasses.Size = New System.Drawing.Size(78, 20)
        Me.txtPriceMolasses.TabIndex = 4
        '
        'txtIncomeMolasses
        '
        Me.txtIncomeMolasses.Location = New System.Drawing.Point(98, 73)
        Me.txtIncomeMolasses.Name = "txtIncomeMolasses"
        Me.txtIncomeMolasses.ReadOnly = True
        Me.txtIncomeMolasses.Size = New System.Drawing.Size(78, 20)
        Me.txtIncomeMolasses.TabIndex = 3
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(6, 76)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(39, 13)
        Me.Label22.TabIndex = 2
        Me.Label22.Text = "Доход"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(6, 53)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(62, 13)
        Me.Label23.TabIndex = 1
        Me.Label23.Text = "Цена за кг"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(6, 30)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(86, 13)
        Me.Label24.TabIndex = 0
        Me.Label24.Text = "Количество (кг)"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.cmdDatabaseSugar)
        Me.GroupBox6.Controls.Add(Me.cmdCalculateSugar)
        Me.GroupBox6.Controls.Add(Me.txtIncomeSugar)
        Me.GroupBox6.Controls.Add(Me.txtPriceSugar)
        Me.GroupBox6.Controls.Add(Me.txtNumberSugar)
        Me.GroupBox6.Controls.Add(Me.Label25)
        Me.GroupBox6.Controls.Add(Me.Label26)
        Me.GroupBox6.Controls.Add(Me.Label27)
        Me.GroupBox6.Location = New System.Drawing.Point(8, 6)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(281, 103)
        Me.GroupBox6.TabIndex = 21
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Сахар"
        '
        'cmdDatabaseSugar
        '
        Me.cmdDatabaseSugar.Location = New System.Drawing.Point(182, 53)
        Me.cmdDatabaseSugar.Name = "cmdDatabaseSugar"
        Me.cmdDatabaseSugar.Size = New System.Drawing.Size(83, 40)
        Me.cmdDatabaseSugar.TabIndex = 7
        Me.cmdDatabaseSugar.Text = "Занести в базу"
        Me.cmdDatabaseSugar.UseVisualStyleBackColor = True
        '
        'cmdCalculateSugar
        '
        Me.cmdCalculateSugar.Location = New System.Drawing.Point(182, 27)
        Me.cmdCalculateSugar.Name = "cmdCalculateSugar"
        Me.cmdCalculateSugar.Size = New System.Drawing.Size(83, 23)
        Me.cmdCalculateSugar.TabIndex = 6
        Me.cmdCalculateSugar.Text = "Рассчитать"
        Me.cmdCalculateSugar.UseVisualStyleBackColor = True
        '
        'txtIncomeSugar
        '
        Me.txtIncomeSugar.Location = New System.Drawing.Point(98, 73)
        Me.txtIncomeSugar.Name = "txtIncomeSugar"
        Me.txtIncomeSugar.ReadOnly = True
        Me.txtIncomeSugar.Size = New System.Drawing.Size(78, 20)
        Me.txtIncomeSugar.TabIndex = 5
        '
        'txtPriceSugar
        '
        Me.txtPriceSugar.Location = New System.Drawing.Point(98, 50)
        Me.txtPriceSugar.Name = "txtPriceSugar"
        Me.txtPriceSugar.Size = New System.Drawing.Size(78, 20)
        Me.txtPriceSugar.TabIndex = 4
        '
        'txtNumberSugar
        '
        Me.txtNumberSugar.Location = New System.Drawing.Point(98, 27)
        Me.txtNumberSugar.Name = "txtNumberSugar"
        Me.txtNumberSugar.Size = New System.Drawing.Size(78, 20)
        Me.txtNumberSugar.TabIndex = 3
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(6, 76)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(39, 13)
        Me.Label25.TabIndex = 2
        Me.Label25.Text = "Доход"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(6, 53)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(62, 13)
        Me.Label26.TabIndex = 1
        Me.Label26.Text = "Цена за кг"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(6, 30)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(86, 13)
        Me.Label27.TabIndex = 0
        Me.Label27.Text = "Количество (кг)"
        '
        'ВодаTableAdapter
        '
        Me.ВодаTableAdapter.ClearBeforeFill = True
        '
        'ГазTableAdapter
        '
        Me.ГазTableAdapter.ClearBeforeFill = True
        '
        'ЭлектричествоTableAdapter
        '
        Me.ЭлектричествоTableAdapter.ClearBeforeFill = True
        '
        'МелассаTableAdapter
        '
        Me.МелассаTableAdapter.ClearBeforeFill = True
        '
        'ЖомTableAdapter
        '
        Me.ЖомTableAdapter.ClearBeforeFill = True
        '
        'СахарTableAdapter
        '
        Me.СахарTableAdapter.ClearBeforeFill = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(87, 224)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 22
        Me.Button5.Text = "Button3"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(87, 253)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 21
        Me.Button6.Text = "Button4"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(6, 253)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 23)
        Me.Button7.TabIndex = 20
        Me.Button7.Text = "Button2"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(6, 224)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 23)
        Me.Button8.TabIndex = 19
        Me.Button8.Text = "Button1"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'DataGridView7
        '
        Me.DataGridView7.AutoGenerateColumns = False
        Me.DataGridView7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView7.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.DataGridView7.DataSource = Me.ЭлектричествоBindingSource
        Me.DataGridView7.Location = New System.Drawing.Point(6, 6)
        Me.DataGridView7.Name = "DataGridView7"
        Me.DataGridView7.Size = New System.Drawing.Size(416, 212)
        Me.DataGridView7.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Код"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Код"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 73
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Потреблено"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Потреблено"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Тариф"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Тариф"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Расход"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Расход"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'frmBookkeeping
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(879, 439)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmBookkeeping"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Бухгалтерия"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabControl4.ResumeLayout(False)
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
        Me.TabPage2.ResumeLayout(False)
        Me.TabControl3.ResumeLayout(False)
        Me.TabPage7.ResumeLayout(False)
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ЭлектричествоBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage8.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ГазBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage9.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ВодаBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        CType(Me.DataGridView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.СахарBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ЖомBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage6.ResumeLayout(False)
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.МелассаBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.DataGridView7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ФайлToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents СправкаToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtPotrGas As System.Windows.Forms.TextBox
    Friend WithEvents txtTarifGas As System.Windows.Forms.TextBox
    Friend WithEvents txtRashGas As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtPotrWater As System.Windows.Forms.TextBox
    Friend WithEvents txtTarifWater As System.Windows.Forms.TextBox
    Friend WithEvents txtRashWater As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtRashElec As System.Windows.Forms.TextBox
    Friend WithEvents txtTarifElec As System.Windows.Forms.TextBox
    Friend WithEvents txtPotrElec As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNumberPulp As System.Windows.Forms.TextBox
    Friend WithEvents txtPricePulp As System.Windows.Forms.TextBox
    Friend WithEvents txtIncomePulp As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNumberMolasses As System.Windows.Forms.TextBox
    Friend WithEvents txtPriceMolasses As System.Windows.Forms.TextBox
    Friend WithEvents txtIncomeMolasses As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents txtIncomeSugar As System.Windows.Forms.TextBox
    Friend WithEvents txtPriceSugar As System.Windows.Forms.TextBox
    Friend WithEvents txtNumberSugar As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtProfession As System.Windows.Forms.TextBox
    Friend WithEvents txtNumbWorkDay As System.Windows.Forms.TextBox
    Friend WithEvents txtNumbDaysWorked As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtWage As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtSalary As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPatronymic As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox11 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdDatabaseWage As System.Windows.Forms.Button
    Friend WithEvents cmdCalculateWage As System.Windows.Forms.Button
    Friend WithEvents GroupBox12 As System.Windows.Forms.GroupBox
    Friend WithEvents txtHolidayPay As System.Windows.Forms.TextBox
    Friend WithEvents cmdDatabaseSDZ As System.Windows.Forms.Button
    Friend WithEvents cmdCalculateSDZ As System.Windows.Forms.Button
    Friend WithEvents txtSDZ As System.Windows.Forms.TextBox
    Friend WithEvents cmdDatabaseHolidayPay As System.Windows.Forms.Button
    Friend WithEvents cmdCalculateHolidayPay As System.Windows.Forms.Button
    Friend WithEvents cmdBackStaff As System.Windows.Forms.Button
    Friend WithEvents cmdBackIncome As System.Windows.Forms.Button
    Friend WithEvents cmdDatabasePulp As System.Windows.Forms.Button
    Friend WithEvents cmdCalculatePulp As System.Windows.Forms.Button
    Friend WithEvents cmdDatabaseMolasses As System.Windows.Forms.Button
    Friend WithEvents cmdCalculateMolasses As System.Windows.Forms.Button
    Friend WithEvents cmdDatabaseSugar As System.Windows.Forms.Button
    Friend WithEvents cmdCalculateSugar As System.Windows.Forms.Button
    Friend WithEvents cmdDatabaseGas As System.Windows.Forms.Button
    Friend WithEvents cmdCalculateGas As System.Windows.Forms.Button
    Friend WithEvents cmdDatabaseWater As System.Windows.Forms.Button
    Friend WithEvents cmdCalculateWater As System.Windows.Forms.Button
    Friend WithEvents cmdDatabaseElectricity As System.Windows.Forms.Button
    Friend WithEvents cmdCalculateElectricity As System.Windows.Forms.Button
    Friend WithEvents cmdBackMS As System.Windows.Forms.Button
    Friend WithEvents TabControl3 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage7 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage8 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage9 As System.Windows.Forms.TabPage
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DatabaseDataSet As Sample_course_project.DatabaseDataSet
    Friend WithEvents ВодаBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ВодаTableAdapter As Sample_course_project.DatabaseDataSetTableAdapters.ВодаTableAdapter
    Friend WithEvents КодDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ПотребленоDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ТарифDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents РасходDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents ГазBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ГазTableAdapter As Sample_course_project.DatabaseDataSetTableAdapters.ГазTableAdapter
    Friend WithEvents DataGridView3 As System.Windows.Forms.DataGridView
    Friend WithEvents КодDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ПотребленоDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ТарифDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents РасходDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ЭлектричествоBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ЭлектричествоTableAdapter As Sample_course_project.DatabaseDataSetTableAdapters.ЭлектричествоTableAdapter
    Friend WithEvents КодDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ПотребленоDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ТарифDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents РасходDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridView4 As System.Windows.Forms.DataGridView
    Friend WithEvents МелассаBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents МелассаTableAdapter As Sample_course_project.DatabaseDataSetTableAdapters.МелассаTableAdapter
    Friend WithEvents DataGridView5 As System.Windows.Forms.DataGridView
    Friend WithEvents КодDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents КоличествоDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ЦеназакгDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ДоходDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ЖомBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ЖомTableAdapter As Sample_course_project.DatabaseDataSetTableAdapters.ЖомTableAdapter
    Friend WithEvents DataGridView6 As System.Windows.Forms.DataGridView
    Friend WithEvents КодDataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents КоличествоDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ЦеназакгDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ДоходDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents СахарBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents СахарTableAdapter As Sample_course_project.DatabaseDataSetTableAdapters.СахарTableAdapter
    Friend WithEvents КодDataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents КоличествоDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ЦеназакгDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ДоходDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TabControl4 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage10 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage11 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage12 As System.Windows.Forms.TabPage
    Friend WithEvents cmdNext As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdAddNew As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdPrevious As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents DataGridView7 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
