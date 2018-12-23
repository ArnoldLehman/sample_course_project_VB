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
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txtPotrGas = New System.Windows.Forms.TextBox
        Me.txtTarifGas = New System.Windows.Forms.TextBox
        Me.txtRashGas = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtPotrWater = New System.Windows.Forms.TextBox
        Me.txtTarifWater = New System.Windows.Forms.TextBox
        Me.txtRashWater = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtRashElec = New System.Windows.Forms.TextBox
        Me.txtTarifElec = New System.Windows.Forms.TextBox
        Me.txtPotrElec = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.txtNumberPulp = New System.Windows.Forms.TextBox
        Me.txtPricePulp = New System.Windows.Forms.TextBox
        Me.txtIncomePulp = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.txtNumberMolasses = New System.Windows.Forms.TextBox
        Me.txtPriceMolasses = New System.Windows.Forms.TextBox
        Me.txtIncomeMolasses = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.txtIncomeSugar = New System.Windows.Forms.TextBox
        Me.txtPriceSugar = New System.Windows.Forms.TextBox
        Me.txtNumberSugar = New System.Windows.Forms.TextBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtWage = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtSalary = New System.Windows.Forms.TextBox
        Me.txtNumbDaysWorked = New System.Windows.Forms.TextBox
        Me.txtNumbWorkDay = New System.Windows.Forms.TextBox
        Me.txtProfession = New System.Windows.Forms.TextBox
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.GroupBox8 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtPatronymic = New System.Windows.Forms.TextBox
        Me.txtFirstName = New System.Windows.Forms.TextBox
        Me.txtLastName = New System.Windows.Forms.TextBox
        Me.GroupBox9 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.GroupBox10 = New System.Windows.Forms.GroupBox
        Me.cmdCalculateWage = New System.Windows.Forms.Button
        Me.cmdDatabaseWage = New System.Windows.Forms.Button
        Me.GroupBox11 = New System.Windows.Forms.GroupBox
        Me.txtSDZ = New System.Windows.Forms.TextBox
        Me.cmdCalculateSDZ = New System.Windows.Forms.Button
        Me.cmdDatabaseSDZ = New System.Windows.Forms.Button
        Me.GroupBox12 = New System.Windows.Forms.GroupBox
        Me.txtHolidayPay = New System.Windows.Forms.TextBox
        Me.cmdDatabaseHolidayPay = New System.Windows.Forms.Button
        Me.cmdCalculateHolidayPay = New System.Windows.Forms.Button
        Me.cmdBackStaff = New System.Windows.Forms.Button
        Me.cmdCalculateSugar = New System.Windows.Forms.Button
        Me.cmdDatabaseSugar = New System.Windows.Forms.Button
        Me.cmdDatabasePulp = New System.Windows.Forms.Button
        Me.cmdCalculatePulp = New System.Windows.Forms.Button
        Me.cmdDatabaseMolasses = New System.Windows.Forms.Button
        Me.cmdCalculateMolasses = New System.Windows.Forms.Button
        Me.cmdBackIncome = New System.Windows.Forms.Button
        Me.cmdCalculateElectricity = New System.Windows.Forms.Button
        Me.cmdCalculateWater = New System.Windows.Forms.Button
        Me.cmdCalculateGas = New System.Windows.Forms.Button
        Me.cmdDatabaseGas = New System.Windows.Forms.Button
        Me.cmdDatabaseElectricity = New System.Windows.Forms.Button
        Me.cmdDatabaseWater = New System.Windows.Forms.Button
        Me.cmdBackMS = New System.Windows.Forms.Button
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ФайлToolStripMenuItem, Me.СправкаToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(555, 24)
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
        Me.TabControl1.Size = New System.Drawing.Size(555, 295)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.cmdBackStaff)
        Me.TabPage1.Controls.Add(Me.GroupBox9)
        Me.TabPage1.Controls.Add(Me.GroupBox8)
        Me.TabPage1.Controls.Add(Me.GroupBox7)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(547, 266)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Персонал"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.cmdBackMS)
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(547, 266)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Комм. услуги"
        Me.TabPage2.UseVisualStyleBackColor = True
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
        Me.Label10.Size = New System.Drawing.Size(51, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Расходы"
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
        Me.GroupBox2.Location = New System.Drawing.Point(274, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(260, 103)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Вода"
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
        Me.Label13.Size = New System.Drawing.Size(51, 13)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Расходы"
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
        'txtRashElec
        '
        Me.txtRashElec.Location = New System.Drawing.Point(94, 73)
        Me.txtRashElec.Name = "txtRashElec"
        Me.txtRashElec.ReadOnly = True
        Me.txtRashElec.Size = New System.Drawing.Size(78, 20)
        Me.txtRashElec.TabIndex = 5
        '
        'txtTarifElec
        '
        Me.txtTarifElec.Location = New System.Drawing.Point(94, 50)
        Me.txtTarifElec.Name = "txtTarifElec"
        Me.txtTarifElec.Size = New System.Drawing.Size(78, 20)
        Me.txtTarifElec.TabIndex = 4
        '
        'txtPotrElec
        '
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
        Me.Label16.Size = New System.Drawing.Size(51, 13)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "Расходы"
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
        Me.TabPage3.Controls.Add(Me.cmdBackIncome)
        Me.TabPage3.Controls.Add(Me.GroupBox4)
        Me.TabPage3.Controls.Add(Me.GroupBox5)
        Me.TabPage3.Controls.Add(Me.GroupBox6)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(547, 266)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Прибыль"
        Me.TabPage3.UseVisualStyleBackColor = True
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
        'txtNumberPulp
        '
        Me.txtNumberPulp.Location = New System.Drawing.Point(98, 27)
        Me.txtNumberPulp.Name = "txtNumberPulp"
        Me.txtNumberPulp.Size = New System.Drawing.Size(78, 20)
        Me.txtNumberPulp.TabIndex = 5
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
        Me.GroupBox5.Location = New System.Drawing.Point(297, 6)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(283, 103)
        Me.GroupBox5.TabIndex = 22
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Меласса"
        '
        'txtNumberMolasses
        '
        Me.txtNumberMolasses.Location = New System.Drawing.Point(98, 27)
        Me.txtNumberMolasses.Name = "txtNumberMolasses"
        Me.txtNumberMolasses.Size = New System.Drawing.Size(78, 20)
        Me.txtNumberMolasses.TabIndex = 5
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
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 13)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "Зарплата"
        '
        'txtWage
        '
        Me.txtWage.Location = New System.Drawing.Point(73, 45)
        Me.txtWage.Name = "txtWage"
        Me.txtWage.ReadOnly = True
        Me.txtWage.Size = New System.Drawing.Size(57, 20)
        Me.txtWage.TabIndex = 44
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
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 76)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(167, 13)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Количество отработанных дней"
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Профессия"
        '
        'txtSalary
        '
        Me.txtSalary.Location = New System.Drawing.Point(57, 18)
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(57, 20)
        Me.txtSalary.TabIndex = 35
        '
        'txtNumbDaysWorked
        '
        Me.txtNumbDaysWorked.Location = New System.Drawing.Point(176, 73)
        Me.txtNumbDaysWorked.MaxLength = 2
        Me.txtNumbDaysWorked.Name = "txtNumbDaysWorked"
        Me.txtNumbDaysWorked.Size = New System.Drawing.Size(28, 20)
        Me.txtNumbDaysWorked.TabIndex = 33
        '
        'txtNumbWorkDay
        '
        Me.txtNumbWorkDay.Location = New System.Drawing.Point(145, 47)
        Me.txtNumbWorkDay.MaxLength = 2
        Me.txtNumbWorkDay.Name = "txtNumbWorkDay"
        Me.txtNumbWorkDay.Size = New System.Drawing.Size(28, 20)
        Me.txtNumbWorkDay.TabIndex = 32
        '
        'txtProfession
        '
        Me.txtProfession.Location = New System.Drawing.Point(74, 21)
        Me.txtProfession.MaxLength = 40
        Me.txtProfession.Name = "txtProfession"
        Me.txtProfession.Size = New System.Drawing.Size(100, 20)
        Me.txtProfession.TabIndex = 29
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
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(6, 34)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(63, 13)
        Me.Label28.TabIndex = 47
        Me.Label28.Text = "Отпускные"
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
        'cmdCalculateWage
        '
        Me.cmdCalculateWage.Location = New System.Drawing.Point(15, 71)
        Me.cmdCalculateWage.Name = "cmdCalculateWage"
        Me.cmdCalculateWage.Size = New System.Drawing.Size(115, 21)
        Me.cmdCalculateWage.TabIndex = 46
        Me.cmdCalculateWage.Text = "Рассчитать"
        Me.cmdCalculateWage.UseVisualStyleBackColor = True
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
        'txtSDZ
        '
        Me.txtSDZ.Location = New System.Drawing.Point(44, 40)
        Me.txtSDZ.Name = "txtSDZ"
        Me.txtSDZ.Size = New System.Drawing.Size(69, 20)
        Me.txtSDZ.TabIndex = 47
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
        'cmdDatabaseSDZ
        '
        Me.cmdDatabaseSDZ.Location = New System.Drawing.Point(11, 99)
        Me.cmdDatabaseSDZ.Name = "cmdDatabaseSDZ"
        Me.cmdDatabaseSDZ.Size = New System.Drawing.Size(102, 21)
        Me.cmdDatabaseSDZ.TabIndex = 49
        Me.cmdDatabaseSDZ.Text = "Занести в базу"
        Me.cmdDatabaseSDZ.UseVisualStyleBackColor = True
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
        'txtHolidayPay
        '
        Me.txtHolidayPay.Location = New System.Drawing.Point(75, 31)
        Me.txtHolidayPay.Name = "txtHolidayPay"
        Me.txtHolidayPay.Size = New System.Drawing.Size(78, 20)
        Me.txtHolidayPay.TabIndex = 48
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
        'cmdCalculateHolidayPay
        '
        Me.cmdCalculateHolidayPay.Location = New System.Drawing.Point(9, 71)
        Me.cmdCalculateHolidayPay.Name = "cmdCalculateHolidayPay"
        Me.cmdCalculateHolidayPay.Size = New System.Drawing.Size(147, 21)
        Me.cmdCalculateHolidayPay.TabIndex = 50
        Me.cmdCalculateHolidayPay.Text = "Рассчитать"
        Me.cmdCalculateHolidayPay.UseVisualStyleBackColor = True
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
        'cmdCalculateSugar
        '
        Me.cmdCalculateSugar.Location = New System.Drawing.Point(182, 27)
        Me.cmdCalculateSugar.Name = "cmdCalculateSugar"
        Me.cmdCalculateSugar.Size = New System.Drawing.Size(83, 23)
        Me.cmdCalculateSugar.TabIndex = 6
        Me.cmdCalculateSugar.Text = "Рассчитать"
        Me.cmdCalculateSugar.UseVisualStyleBackColor = True
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
        'cmdDatabasePulp
        '
        Me.cmdDatabasePulp.Location = New System.Drawing.Point(182, 53)
        Me.cmdDatabasePulp.Name = "cmdDatabasePulp"
        Me.cmdDatabasePulp.Size = New System.Drawing.Size(83, 40)
        Me.cmdDatabasePulp.TabIndex = 9
        Me.cmdDatabasePulp.Text = "Занести в базу"
        Me.cmdDatabasePulp.UseVisualStyleBackColor = True
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
        'cmdDatabaseMolasses
        '
        Me.cmdDatabaseMolasses.Location = New System.Drawing.Point(182, 53)
        Me.cmdDatabaseMolasses.Name = "cmdDatabaseMolasses"
        Me.cmdDatabaseMolasses.Size = New System.Drawing.Size(83, 40)
        Me.cmdDatabaseMolasses.TabIndex = 11
        Me.cmdDatabaseMolasses.Text = "Занести в базу"
        Me.cmdDatabaseMolasses.UseVisualStyleBackColor = True
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
        'cmdBackIncome
        '
        Me.cmdBackIncome.Location = New System.Drawing.Point(306, 193)
        Me.cmdBackIncome.Name = "cmdBackIncome"
        Me.cmdBackIncome.Size = New System.Drawing.Size(75, 23)
        Me.cmdBackIncome.TabIndex = 24
        Me.cmdBackIncome.Text = "Назад"
        Me.cmdBackIncome.UseVisualStyleBackColor = True
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
        'cmdCalculateWater
        '
        Me.cmdCalculateWater.Location = New System.Drawing.Point(178, 27)
        Me.cmdCalculateWater.Name = "cmdCalculateWater"
        Me.cmdCalculateWater.Size = New System.Drawing.Size(75, 23)
        Me.cmdCalculateWater.TabIndex = 7
        Me.cmdCalculateWater.Text = "Рассчитать"
        Me.cmdCalculateWater.UseVisualStyleBackColor = True
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
        'cmdDatabaseGas
        '
        Me.cmdDatabaseGas.Location = New System.Drawing.Point(178, 53)
        Me.cmdDatabaseGas.Name = "cmdDatabaseGas"
        Me.cmdDatabaseGas.Size = New System.Drawing.Size(75, 40)
        Me.cmdDatabaseGas.TabIndex = 18
        Me.cmdDatabaseGas.Text = "Занести в базу"
        Me.cmdDatabaseGas.UseVisualStyleBackColor = True
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
        'cmdDatabaseWater
        '
        Me.cmdDatabaseWater.Location = New System.Drawing.Point(178, 53)
        Me.cmdDatabaseWater.Name = "cmdDatabaseWater"
        Me.cmdDatabaseWater.Size = New System.Drawing.Size(75, 40)
        Me.cmdDatabaseWater.TabIndex = 20
        Me.cmdDatabaseWater.Text = "Занести в базу"
        Me.cmdDatabaseWater.UseVisualStyleBackColor = True
        '
        'cmdBackMS
        '
        Me.cmdBackMS.Location = New System.Drawing.Point(283, 192)
        Me.cmdBackMS.Name = "cmdBackMS"
        Me.cmdBackMS.Size = New System.Drawing.Size(75, 23)
        Me.cmdBackMS.TabIndex = 17
        Me.cmdBackMS.Text = "Назад"
        Me.cmdBackMS.UseVisualStyleBackColor = True
        '
        'frmBookkeeping
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(555, 319)
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
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox12.PerformLayout()
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

End Class
