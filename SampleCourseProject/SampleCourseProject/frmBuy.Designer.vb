<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuy
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
        Me.cmdBuy = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblNumberOnStorage = New System.Windows.Forms.Label
        Me.txtNumber = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblMain = New System.Windows.Forms.Label
        Me.pnl2 = New System.Windows.Forms.Panel
        Me.cboTypeOfSugar = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtSumm = New System.Windows.Forms.TextBox
        Me.rdoOrganization = New System.Windows.Forms.RadioButton
        Me.rdoPrivatePerson = New System.Windows.Forms.RadioButton
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblName = New System.Windows.Forms.Label
        Me.txtName = New System.Windows.Forms.TextBox
        Me.txtOrganization = New System.Windows.Forms.TextBox
        Me.lblOrganization = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.pnl1 = New System.Windows.Forms.Panel
        Me.cmdFurther = New System.Windows.Forms.Button
        Me.StorageDatabaseDataSet = New SampleCourseProject.StorageDatabaseDataSet
        Me.StorageBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StorageTableAdapter = New SampleCourseProject.StorageDatabaseDataSetTableAdapters.StorageTableAdapter
        Me.BuyersDatabaseDataSet = New SampleCourseProject.BuyersDatabaseDataSet
        Me.BuyersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuyersTableAdapter = New SampleCourseProject.BuyersDatabaseDataSetTableAdapters.BuyersTableAdapter
        Me.Panel1.SuspendLayout()
        Me.pnl2.SuspendLayout()
        Me.pnl1.SuspendLayout()
        CType(Me.StorageDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StorageBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyersDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdBuy
        '
        Me.cmdBuy.Location = New System.Drawing.Point(25, 158)
        Me.cmdBuy.Name = "cmdBuy"
        Me.cmdBuy.Size = New System.Drawing.Size(75, 23)
        Me.cmdBuy.TabIndex = 0
        Me.cmdBuy.Text = "Купить"
        Me.cmdBuy.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Вид сахара"
        '
        'lblNumberOnStorage
        '
        Me.lblNumberOnStorage.AutoSize = True
        Me.lblNumberOnStorage.Location = New System.Drawing.Point(22, 39)
        Me.lblNumberOnStorage.Name = "lblNumberOnStorage"
        Me.lblNumberOnStorage.Size = New System.Drawing.Size(126, 13)
        Me.lblNumberOnStorage.TabIndex = 13
        Me.lblNumberOnStorage.Text = "Количество на складе: "
        '
        'txtNumber
        '
        Me.txtNumber.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuyersBindingSource, "Количество_купленного_товара", True))
        Me.txtNumber.Location = New System.Drawing.Point(25, 89)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(61, 20)
        Me.txtNumber.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Купить"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(90, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "тонн"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Blue
        Me.Panel1.Controls.Add(Me.lblMain)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(495, 64)
        Me.Panel1.TabIndex = 18
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
        'pnl2
        '
        Me.pnl2.Controls.Add(Me.cboTypeOfSugar)
        Me.pnl2.Controls.Add(Me.Label7)
        Me.pnl2.Controls.Add(Me.txtSumm)
        Me.pnl2.Controls.Add(Me.Label1)
        Me.pnl2.Controls.Add(Me.Label5)
        Me.pnl2.Controls.Add(Me.cmdBuy)
        Me.pnl2.Controls.Add(Me.Label4)
        Me.pnl2.Controls.Add(Me.txtNumber)
        Me.pnl2.Controls.Add(Me.lblNumberOnStorage)
        Me.pnl2.Location = New System.Drawing.Point(257, 121)
        Me.pnl2.Name = "pnl2"
        Me.pnl2.Size = New System.Drawing.Size(223, 248)
        Me.pnl2.TabIndex = 0
        '
        'cboTypeOfSugar
        '
        Me.cboTypeOfSugar.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuyersBindingSource, "Наименование_товара", True))
        Me.cboTypeOfSugar.FormattingEnabled = True
        Me.cboTypeOfSugar.Items.AddRange(New Object() {"гранулированный", "кусковой", "фруктовый", "сахарная пудра", "коричневый", "меласса", "жом"})
        Me.cboTypeOfSugar.Location = New System.Drawing.Point(92, 11)
        Me.cboTypeOfSugar.Name = "cboTypeOfSugar"
        Me.cboTypeOfSugar.Size = New System.Drawing.Size(121, 21)
        Me.cboTypeOfSugar.TabIndex = 23
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(22, 114)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Сумма"
        '
        'txtSumm
        '
        Me.txtSumm.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuyersBindingSource, "Оплата_за_заказ", True))
        Me.txtSumm.Location = New System.Drawing.Point(25, 130)
        Me.txtSumm.Name = "txtSumm"
        Me.txtSumm.ReadOnly = True
        Me.txtSumm.Size = New System.Drawing.Size(134, 20)
        Me.txtSumm.TabIndex = 19
        '
        'rdoOrganization
        '
        Me.rdoOrganization.AutoSize = True
        Me.rdoOrganization.Location = New System.Drawing.Point(59, 118)
        Me.rdoOrganization.Name = "rdoOrganization"
        Me.rdoOrganization.Size = New System.Drawing.Size(92, 17)
        Me.rdoOrganization.TabIndex = 1
        Me.rdoOrganization.Text = "Организации"
        Me.rdoOrganization.UseVisualStyleBackColor = True
        '
        'rdoPrivatePerson
        '
        Me.rdoPrivatePerson.AutoSize = True
        Me.rdoPrivatePerson.Location = New System.Drawing.Point(156, 118)
        Me.rdoPrivatePerson.Name = "rdoPrivatePerson"
        Me.rdoPrivatePerson.Size = New System.Drawing.Size(95, 17)
        Me.rdoPrivatePerson.TabIndex = 20
        Me.rdoPrivatePerson.Text = "Частное лицо"
        Me.rdoPrivatePerson.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(304, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Вы покупаете от лица организации или как частное лицо?"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(63, 16)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(110, 13)
        Me.lblName.TabIndex = 22
        Me.lblName.Text = "Введите ваше имя..."
        '
        'txtName
        '
        Me.txtName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuyersBindingSource, "Имя_заказчика", True))
        Me.txtName.Location = New System.Drawing.Point(66, 32)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(167, 20)
        Me.txtName.TabIndex = 23
        '
        'txtOrganization
        '
        Me.txtOrganization.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuyersBindingSource, "Наименование_организации", True))
        Me.txtOrganization.Location = New System.Drawing.Point(66, 87)
        Me.txtOrganization.Multiline = True
        Me.txtOrganization.Name = "txtOrganization"
        Me.txtOrganization.Size = New System.Drawing.Size(167, 75)
        Me.txtOrganization.TabIndex = 24
        '
        'lblOrganization
        '
        Me.lblOrganization.AutoSize = True
        Me.lblOrganization.Location = New System.Drawing.Point(63, 71)
        Me.lblOrganization.Name = "lblOrganization"
        Me.lblOrganization.Size = New System.Drawing.Size(170, 13)
        Me.lblOrganization.TabIndex = 25
        Me.lblOrganization.Text = "... и наименование организации"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, -4)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(241, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "_______________________________________"
        '
        'pnl1
        '
        Me.pnl1.Controls.Add(Me.cmdFurther)
        Me.pnl1.Controls.Add(Me.Label6)
        Me.pnl1.Controls.Add(Me.txtOrganization)
        Me.pnl1.Controls.Add(Me.lblOrganization)
        Me.pnl1.Controls.Add(Me.lblName)
        Me.pnl1.Controls.Add(Me.txtName)
        Me.pnl1.Location = New System.Drawing.Point(1, 140)
        Me.pnl1.Name = "pnl1"
        Me.pnl1.Size = New System.Drawing.Size(321, 229)
        Me.pnl1.TabIndex = 27
        '
        'cmdFurther
        '
        Me.cmdFurther.Location = New System.Drawing.Point(243, 179)
        Me.cmdFurther.Name = "cmdFurther"
        Me.cmdFurther.Size = New System.Drawing.Size(75, 23)
        Me.cmdFurther.TabIndex = 27
        Me.cmdFurther.Text = "Далее"
        Me.cmdFurther.UseVisualStyleBackColor = True
        '
        'StorageDatabaseDataSet
        '
        Me.StorageDatabaseDataSet.DataSetName = "StorageDatabaseDataSet"
        Me.StorageDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StorageBindingSource
        '
        Me.StorageBindingSource.DataMember = "Storage"
        Me.StorageBindingSource.DataSource = Me.StorageDatabaseDataSet
        '
        'StorageTableAdapter
        '
        Me.StorageTableAdapter.ClearBeforeFill = True
        '
        'BuyersDatabaseDataSet
        '
        Me.BuyersDatabaseDataSet.DataSetName = "BuyersDatabaseDataSet"
        Me.BuyersDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BuyersBindingSource
        '
        Me.BuyersBindingSource.DataMember = "Buyers"
        Me.BuyersBindingSource.DataSource = Me.BuyersDatabaseDataSet
        '
        'BuyersTableAdapter
        '
        Me.BuyersTableAdapter.ClearBeforeFill = True
        '
        'frmBuy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(495, 340)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.rdoPrivatePerson)
        Me.Controls.Add(Me.rdoOrganization)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnl2)
        Me.Controls.Add(Me.pnl1)
        Me.Name = "frmBuy"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Покупка"
        Me.Panel1.ResumeLayout(False)
        Me.pnl2.ResumeLayout(False)
        Me.pnl2.PerformLayout()
        Me.pnl1.ResumeLayout(False)
        Me.pnl1.PerformLayout()
        CType(Me.StorageDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StorageBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyersDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdBuy As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblNumberOnStorage As System.Windows.Forms.Label
    Friend WithEvents txtNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblMain As System.Windows.Forms.Label
    Friend WithEvents pnl2 As System.Windows.Forms.Panel
    Friend WithEvents rdoOrganization As System.Windows.Forms.RadioButton
    Friend WithEvents rdoPrivatePerson As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtOrganization As System.Windows.Forms.TextBox
    Friend WithEvents lblOrganization As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents pnl1 As System.Windows.Forms.Panel
    Friend WithEvents cmdFurther As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtSumm As System.Windows.Forms.TextBox
    Friend WithEvents cboTypeOfSugar As System.Windows.Forms.ComboBox
    Friend WithEvents StorageDatabaseDataSet As SampleCourseProject.StorageDatabaseDataSet
    Friend WithEvents StorageBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StorageTableAdapter As SampleCourseProject.StorageDatabaseDataSetTableAdapters.StorageTableAdapter
    Friend WithEvents BuyersDatabaseDataSet As SampleCourseProject.BuyersDatabaseDataSet
    Friend WithEvents BuyersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BuyersTableAdapter As SampleCourseProject.BuyersDatabaseDataSetTableAdapters.BuyersTableAdapter
End Class
