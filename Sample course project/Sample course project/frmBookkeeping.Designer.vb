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
        Me.Button1 = New System.Windows.Forms.Button
        Me.cmdRash = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txtPotrGaz = New System.Windows.Forms.TextBox
        Me.txtTarifGaz = New System.Windows.Forms.TextBox
        Me.txtRashGaz = New System.Windows.Forms.TextBox
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
        Me.cmdText2 = New System.Windows.Forms.Button
        Me.cmdIncomePrice = New System.Windows.Forms.Button
        Me.cmdBackPrice = New System.Windows.Forms.Button
        Me.cmdDatabasePrice = New System.Windows.Forms.Button
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.txtNumberJom = New System.Windows.Forms.TextBox
        Me.txtPriceJom = New System.Windows.Forms.TextBox
        Me.txtIncomeJom = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.txtNumberMel = New System.Windows.Forms.TextBox
        Me.txtPriceMel = New System.Windows.Forms.TextBox
        Me.txtIncomeMel = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.txtIncomeSah = New System.Windows.Forms.TextBox
        Me.txtPriceSah = New System.Windows.Forms.TextBox
        Me.txtNumberSah = New System.Windows.Forms.TextBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtLastName = New System.Windows.Forms.TextBox
        Me.txtFirstName = New System.Windows.Forms.TextBox
        Me.txtPatronymic = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtProfession = New System.Windows.Forms.TextBox
        Me.txtNumbWorkDay = New System.Windows.Forms.TextBox
        Me.txtNumbDaysWorked = New System.Windows.Forms.TextBox
        Me.txtSalary = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.cmdZP = New System.Windows.Forms.Button
        Me.cmdDatabase = New System.Windows.Forms.Button
        Me.cmdBack = New System.Windows.Forms.Button
        Me.txtWage = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox
        Me.cmdText = New System.Windows.Forms.Button
        Me.txtSDZ = New System.Windows.Forms.TextBox
        Me.Label28 = New System.Windows.Forms.Label
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
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ФайлToolStripMenuItem, Me.СправкаToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(581, 24)
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
        Me.TabControl1.Size = New System.Drawing.Size(581, 253)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label28)
        Me.TabPage1.Controls.Add(Me.txtSDZ)
        Me.TabPage1.Controls.Add(Me.cmdText)
        Me.TabPage1.Controls.Add(Me.MaskedTextBox1)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.txtWage)
        Me.TabPage1.Controls.Add(Me.cmdBack)
        Me.TabPage1.Controls.Add(Me.cmdDatabase)
        Me.TabPage1.Controls.Add(Me.cmdZP)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.txtSalary)
        Me.TabPage1.Controls.Add(Me.txtNumbDaysWorked)
        Me.TabPage1.Controls.Add(Me.txtNumbWorkDay)
        Me.TabPage1.Controls.Add(Me.txtProfession)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.txtPatronymic)
        Me.TabPage1.Controls.Add(Me.txtFirstName)
        Me.TabPage1.Controls.Add(Me.txtLastName)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(573, 224)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Персонал"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.cmdRash)
        Me.TabPage2.Controls.Add(Me.Button2)
        Me.TabPage2.Controls.Add(Me.Button3)
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(423, 245)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Комм. услуги"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(255, 120)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(127, 23)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Заполнение"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmdRash
        '
        Me.cmdRash.Location = New System.Drawing.Point(287, 208)
        Me.cmdRash.Name = "cmdRash"
        Me.cmdRash.Size = New System.Drawing.Size(120, 23)
        Me.cmdRash.TabIndex = 19
        Me.cmdRash.Text = "Рассчитать расходы"
        Me.cmdRash.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(220, 208)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(61, 23)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "Назад"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(220, 176)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(187, 26)
        Me.Button3.TabIndex = 17
        Me.Button3.Text = "Занести в базу данных"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtPotrGaz)
        Me.GroupBox3.Controls.Add(Me.txtTarifGaz)
        Me.GroupBox3.Controls.Add(Me.txtRashGaz)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 132)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(187, 106)
        Me.GroupBox3.TabIndex = 16
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Газ"
        '
        'txtPotrGaz
        '
        Me.txtPotrGaz.Location = New System.Drawing.Point(94, 30)
        Me.txtPotrGaz.Name = "txtPotrGaz"
        Me.txtPotrGaz.Size = New System.Drawing.Size(78, 20)
        Me.txtPotrGaz.TabIndex = 5
        '
        'txtTarifGaz
        '
        Me.txtTarifGaz.Location = New System.Drawing.Point(94, 53)
        Me.txtTarifGaz.Name = "txtTarifGaz"
        Me.txtTarifGaz.Size = New System.Drawing.Size(78, 20)
        Me.txtTarifGaz.TabIndex = 4
        '
        'txtRashGaz
        '
        Me.txtRashGaz.Location = New System.Drawing.Point(94, 76)
        Me.txtRashGaz.Name = "txtRashGaz"
        Me.txtRashGaz.ReadOnly = True
        Me.txtRashGaz.Size = New System.Drawing.Size(78, 20)
        Me.txtRashGaz.TabIndex = 3
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
        Me.GroupBox2.Controls.Add(Me.txtPotrWater)
        Me.GroupBox2.Controls.Add(Me.txtTarifWater)
        Me.GroupBox2.Controls.Add(Me.txtRashWater)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Location = New System.Drawing.Point(220, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(187, 108)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Вода"
        '
        'txtPotrWater
        '
        Me.txtPotrWater.Location = New System.Drawing.Point(94, 30)
        Me.txtPotrWater.Name = "txtPotrWater"
        Me.txtPotrWater.Size = New System.Drawing.Size(78, 20)
        Me.txtPotrWater.TabIndex = 5
        '
        'txtTarifWater
        '
        Me.txtTarifWater.Location = New System.Drawing.Point(94, 53)
        Me.txtTarifWater.Name = "txtTarifWater"
        Me.txtTarifWater.Size = New System.Drawing.Size(78, 20)
        Me.txtTarifWater.TabIndex = 4
        '
        'txtRashWater
        '
        Me.txtRashWater.Location = New System.Drawing.Point(94, 76)
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
        Me.GroupBox1.Controls.Add(Me.txtRashElec)
        Me.GroupBox1.Controls.Add(Me.txtTarifElec)
        Me.GroupBox1.Controls.Add(Me.txtPotrElec)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(187, 108)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Электричество"
        '
        'txtRashElec
        '
        Me.txtRashElec.Location = New System.Drawing.Point(94, 76)
        Me.txtRashElec.Name = "txtRashElec"
        Me.txtRashElec.ReadOnly = True
        Me.txtRashElec.Size = New System.Drawing.Size(78, 20)
        Me.txtRashElec.TabIndex = 5
        '
        'txtTarifElec
        '
        Me.txtTarifElec.Location = New System.Drawing.Point(94, 53)
        Me.txtTarifElec.Name = "txtTarifElec"
        Me.txtTarifElec.Size = New System.Drawing.Size(78, 20)
        Me.txtTarifElec.TabIndex = 4
        '
        'txtPotrElec
        '
        Me.txtPotrElec.Location = New System.Drawing.Point(94, 30)
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
        Me.TabPage3.Controls.Add(Me.cmdText2)
        Me.TabPage3.Controls.Add(Me.cmdIncomePrice)
        Me.TabPage3.Controls.Add(Me.cmdBackPrice)
        Me.TabPage3.Controls.Add(Me.cmdDatabasePrice)
        Me.TabPage3.Controls.Add(Me.GroupBox4)
        Me.TabPage3.Controls.Add(Me.GroupBox5)
        Me.TabPage3.Controls.Add(Me.GroupBox6)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(423, 245)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Прибыль"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'cmdText2
        '
        Me.cmdText2.Location = New System.Drawing.Point(255, 120)
        Me.cmdText2.Name = "cmdText2"
        Me.cmdText2.Size = New System.Drawing.Size(127, 23)
        Me.cmdText2.TabIndex = 27
        Me.cmdText2.Text = "Заполнение"
        Me.cmdText2.UseVisualStyleBackColor = True
        '
        'cmdIncomePrice
        '
        Me.cmdIncomePrice.Location = New System.Drawing.Point(287, 208)
        Me.cmdIncomePrice.Name = "cmdIncomePrice"
        Me.cmdIncomePrice.Size = New System.Drawing.Size(120, 23)
        Me.cmdIncomePrice.TabIndex = 26
        Me.cmdIncomePrice.Text = "Рассчитать доход"
        Me.cmdIncomePrice.UseVisualStyleBackColor = True
        '
        'cmdBackPrice
        '
        Me.cmdBackPrice.Location = New System.Drawing.Point(220, 208)
        Me.cmdBackPrice.Name = "cmdBackPrice"
        Me.cmdBackPrice.Size = New System.Drawing.Size(61, 23)
        Me.cmdBackPrice.TabIndex = 25
        Me.cmdBackPrice.Text = "Назад"
        Me.cmdBackPrice.UseVisualStyleBackColor = True
        '
        'cmdDatabasePrice
        '
        Me.cmdDatabasePrice.Location = New System.Drawing.Point(220, 176)
        Me.cmdDatabasePrice.Name = "cmdDatabasePrice"
        Me.cmdDatabasePrice.Size = New System.Drawing.Size(187, 26)
        Me.cmdDatabasePrice.TabIndex = 24
        Me.cmdDatabasePrice.Text = "Занести в базу данных"
        Me.cmdDatabasePrice.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtNumberJom)
        Me.GroupBox4.Controls.Add(Me.txtPriceJom)
        Me.GroupBox4.Controls.Add(Me.txtIncomeJom)
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Controls.Add(Me.Label21)
        Me.GroupBox4.Location = New System.Drawing.Point(8, 132)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(187, 106)
        Me.GroupBox4.TabIndex = 23
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Жом"
        '
        'txtNumberJom
        '
        Me.txtNumberJom.Location = New System.Drawing.Point(94, 30)
        Me.txtNumberJom.Name = "txtNumberJom"
        Me.txtNumberJom.Size = New System.Drawing.Size(78, 20)
        Me.txtNumberJom.TabIndex = 5
        '
        'txtPriceJom
        '
        Me.txtPriceJom.Location = New System.Drawing.Point(94, 53)
        Me.txtPriceJom.Name = "txtPriceJom"
        Me.txtPriceJom.Size = New System.Drawing.Size(78, 20)
        Me.txtPriceJom.TabIndex = 4
        '
        'txtIncomeJom
        '
        Me.txtIncomeJom.Location = New System.Drawing.Point(94, 76)
        Me.txtIncomeJom.Name = "txtIncomeJom"
        Me.txtIncomeJom.ReadOnly = True
        Me.txtIncomeJom.Size = New System.Drawing.Size(78, 20)
        Me.txtIncomeJom.TabIndex = 3
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
        Me.GroupBox5.Controls.Add(Me.txtNumberMel)
        Me.GroupBox5.Controls.Add(Me.txtPriceMel)
        Me.GroupBox5.Controls.Add(Me.txtIncomeMel)
        Me.GroupBox5.Controls.Add(Me.Label22)
        Me.GroupBox5.Controls.Add(Me.Label23)
        Me.GroupBox5.Controls.Add(Me.Label24)
        Me.GroupBox5.Location = New System.Drawing.Point(220, 6)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(187, 108)
        Me.GroupBox5.TabIndex = 22
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Меласса"
        '
        'txtNumberMel
        '
        Me.txtNumberMel.Location = New System.Drawing.Point(94, 30)
        Me.txtNumberMel.Name = "txtNumberMel"
        Me.txtNumberMel.Size = New System.Drawing.Size(78, 20)
        Me.txtNumberMel.TabIndex = 5
        '
        'txtPriceMel
        '
        Me.txtPriceMel.Location = New System.Drawing.Point(94, 53)
        Me.txtPriceMel.Name = "txtPriceMel"
        Me.txtPriceMel.Size = New System.Drawing.Size(78, 20)
        Me.txtPriceMel.TabIndex = 4
        '
        'txtIncomeMel
        '
        Me.txtIncomeMel.Location = New System.Drawing.Point(94, 76)
        Me.txtIncomeMel.Name = "txtIncomeMel"
        Me.txtIncomeMel.ReadOnly = True
        Me.txtIncomeMel.Size = New System.Drawing.Size(78, 20)
        Me.txtIncomeMel.TabIndex = 3
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
        Me.GroupBox6.Controls.Add(Me.txtIncomeSah)
        Me.GroupBox6.Controls.Add(Me.txtPriceSah)
        Me.GroupBox6.Controls.Add(Me.txtNumberSah)
        Me.GroupBox6.Controls.Add(Me.Label25)
        Me.GroupBox6.Controls.Add(Me.Label26)
        Me.GroupBox6.Controls.Add(Me.Label27)
        Me.GroupBox6.Location = New System.Drawing.Point(8, 6)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(187, 108)
        Me.GroupBox6.TabIndex = 21
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Сахар"
        '
        'txtIncomeSah
        '
        Me.txtIncomeSah.Location = New System.Drawing.Point(94, 76)
        Me.txtIncomeSah.Name = "txtIncomeSah"
        Me.txtIncomeSah.ReadOnly = True
        Me.txtIncomeSah.Size = New System.Drawing.Size(78, 20)
        Me.txtIncomeSah.TabIndex = 5
        '
        'txtPriceSah
        '
        Me.txtPriceSah.Location = New System.Drawing.Point(94, 53)
        Me.txtPriceSah.Name = "txtPriceSah"
        Me.txtPriceSah.Size = New System.Drawing.Size(78, 20)
        Me.txtPriceSah.TabIndex = 4
        '
        'txtNumberSah
        '
        Me.txtNumberSah.Location = New System.Drawing.Point(94, 30)
        Me.txtNumberSah.Name = "txtNumberSah"
        Me.txtNumberSah.Size = New System.Drawing.Size(78, 20)
        Me.txtNumberSah.TabIndex = 3
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
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(105, 6)
        Me.txtLastName.MaxLength = 40
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(112, 20)
        Me.txtLastName.TabIndex = 25
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(105, 32)
        Me.txtFirstName.MaxLength = 40
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(112, 20)
        Me.txtFirstName.TabIndex = 26
        '
        'txtPatronymic
        '
        Me.txtPatronymic.Location = New System.Drawing.Point(105, 58)
        Me.txtPatronymic.MaxLength = 40
        Me.txtPatronymic.Name = "txtPatronymic"
        Me.txtPatronymic.Size = New System.Drawing.Size(112, 20)
        Me.txtPatronymic.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Фамилия"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Имя"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Отчество"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 13)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Дата рождения"
        '
        'txtProfession
        '
        Me.txtProfession.Location = New System.Drawing.Point(105, 111)
        Me.txtProfession.MaxLength = 40
        Me.txtProfession.Name = "txtProfession"
        Me.txtProfession.Size = New System.Drawing.Size(112, 20)
        Me.txtProfession.TabIndex = 29
        '
        'txtNumbWorkDay
        '
        Me.txtNumbWorkDay.Location = New System.Drawing.Point(462, 6)
        Me.txtNumbWorkDay.MaxLength = 2
        Me.txtNumbWorkDay.Name = "txtNumbWorkDay"
        Me.txtNumbWorkDay.Size = New System.Drawing.Size(28, 20)
        Me.txtNumbWorkDay.TabIndex = 32
        '
        'txtNumbDaysWorked
        '
        Me.txtNumbDaysWorked.Location = New System.Drawing.Point(462, 32)
        Me.txtNumbDaysWorked.MaxLength = 2
        Me.txtNumbDaysWorked.Name = "txtNumbDaysWorked"
        Me.txtNumbDaysWorked.Size = New System.Drawing.Size(28, 20)
        Me.txtNumbDaysWorked.TabIndex = 33
        '
        'txtSalary
        '
        Me.txtSalary.Location = New System.Drawing.Point(462, 58)
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(100, 20)
        Me.txtSalary.TabIndex = 35
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 114)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Профессия"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(256, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 13)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Количество рабочих дней"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(256, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(167, 13)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Количество отработанных дней"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(256, 61)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "Оклад"
        '
        'cmdZP
        '
        Me.cmdZP.Location = New System.Drawing.Point(343, 152)
        Me.cmdZP.Name = "cmdZP"
        Me.cmdZP.Size = New System.Drawing.Size(222, 30)
        Me.cmdZP.TabIndex = 37
        Me.cmdZP.Text = "Рассчитать зарплату"
        Me.cmdZP.UseVisualStyleBackColor = True
        '
        'cmdDatabase
        '
        Me.cmdDatabase.Location = New System.Drawing.Point(343, 188)
        Me.cmdDatabase.Name = "cmdDatabase"
        Me.cmdDatabase.Size = New System.Drawing.Size(222, 28)
        Me.cmdDatabase.TabIndex = 38
        Me.cmdDatabase.Text = "Занести в базу данных"
        Me.cmdDatabase.UseVisualStyleBackColor = True
        '
        'cmdBack
        '
        Me.cmdBack.Location = New System.Drawing.Point(12, 188)
        Me.cmdBack.Name = "cmdBack"
        Me.cmdBack.Size = New System.Drawing.Size(75, 28)
        Me.cmdBack.TabIndex = 43
        Me.cmdBack.Text = "Назад"
        Me.cmdBack.UseVisualStyleBackColor = True
        '
        'txtWage
        '
        Me.txtWage.Location = New System.Drawing.Point(462, 85)
        Me.txtWage.Name = "txtWage"
        Me.txtWage.ReadOnly = True
        Me.txtWage.Size = New System.Drawing.Size(100, 20)
        Me.txtWage.TabIndex = 44
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(256, 88)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 13)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "Зарплата"
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Location = New System.Drawing.Point(105, 87)
        Me.MaskedTextBox1.Mask = "00/00/0000"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(61, 20)
        Me.MaskedTextBox1.TabIndex = 28
        Me.MaskedTextBox1.ValidatingType = GetType(Date)
        '
        'cmdText
        '
        Me.cmdText.Location = New System.Drawing.Point(142, 188)
        Me.cmdText.Name = "cmdText"
        Me.cmdText.Size = New System.Drawing.Size(88, 28)
        Me.cmdText.TabIndex = 46
        Me.cmdText.Text = "Заполнение"
        Me.cmdText.UseVisualStyleBackColor = True
        '
        'txtSDZ
        '
        Me.txtSDZ.Location = New System.Drawing.Point(462, 111)
        Me.txtSDZ.Name = "txtSDZ"
        Me.txtSDZ.ReadOnly = True
        Me.txtSDZ.Size = New System.Drawing.Size(100, 20)
        Me.txtSDZ.TabIndex = 47
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(256, 114)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(30, 13)
        Me.Label28.TabIndex = 48
        Me.Label28.Text = "СДЗ"
        Me.ToolTip1.SetToolTip(Me.Label28, "Средний дневной зарботок")
        '
        'frmBookkeeping
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(581, 277)
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
        Me.TabPage1.PerformLayout()
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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cmdRash As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtPotrGaz As System.Windows.Forms.TextBox
    Friend WithEvents txtTarifGaz As System.Windows.Forms.TextBox
    Friend WithEvents txtRashGaz As System.Windows.Forms.TextBox
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
    Friend WithEvents cmdText2 As System.Windows.Forms.Button
    Friend WithEvents cmdIncomePrice As System.Windows.Forms.Button
    Friend WithEvents cmdBackPrice As System.Windows.Forms.Button
    Friend WithEvents cmdDatabasePrice As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNumberJom As System.Windows.Forms.TextBox
    Friend WithEvents txtPriceJom As System.Windows.Forms.TextBox
    Friend WithEvents txtIncomeJom As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNumberMel As System.Windows.Forms.TextBox
    Friend WithEvents txtPriceMel As System.Windows.Forms.TextBox
    Friend WithEvents txtIncomeMel As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents txtIncomeSah As System.Windows.Forms.TextBox
    Friend WithEvents txtPriceSah As System.Windows.Forms.TextBox
    Friend WithEvents txtNumberSah As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txtSDZ As System.Windows.Forms.TextBox
    Friend WithEvents cmdText As System.Windows.Forms.Button
    Friend WithEvents MaskedTextBox1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtWage As System.Windows.Forms.TextBox
    Friend WithEvents cmdBack As System.Windows.Forms.Button
    Friend WithEvents cmdDatabase As System.Windows.Forms.Button
    Friend WithEvents cmdZP As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtSalary As System.Windows.Forms.TextBox
    Friend WithEvents txtNumbDaysWorked As System.Windows.Forms.TextBox
    Friend WithEvents txtNumbWorkDay As System.Windows.Forms.TextBox
    Friend WithEvents txtProfession As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPatronymic As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox

End Class
