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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuy))
        Me.cmdBuy = New System.Windows.Forms.Button
        Me.txtTypeOfSugar = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.pnlHelp = New System.Windows.Forms.Panel
        Me.lblInfo = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtNumber = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblMain = New System.Windows.Forms.Label
        Me.pnl2 = New System.Windows.Forms.Panel
        Me.rdoOrganization = New System.Windows.Forms.RadioButton
        Me.rdoPrivatePerson = New System.Windows.Forms.RadioButton
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblName = New System.Windows.Forms.Label
        Me.txtName = New System.Windows.Forms.TextBox
        Me.txtOrganization = New System.Windows.Forms.TextBox
        Me.lblOrganization = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.BuyersDatabaseDataSet = New SampleCourseProject.BuyersDatabaseDataSet
        Me.BuyersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuyersTableAdapter = New SampleCourseProject.BuyersDatabaseDataSetTableAdapters.BuyersTableAdapter
        Me.pnl1 = New System.Windows.Forms.Panel
        Me.cmdFurther = New System.Windows.Forms.Button
        Me.pnlHelp.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnl2.SuspendLayout()
        CType(Me.BuyersDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdBuy
        '
        Me.cmdBuy.Location = New System.Drawing.Point(3, 225)
        Me.cmdBuy.Name = "cmdBuy"
        Me.cmdBuy.Size = New System.Drawing.Size(75, 20)
        Me.cmdBuy.TabIndex = 0
        Me.cmdBuy.Text = "Купить"
        Me.cmdBuy.UseVisualStyleBackColor = True
        '
        'txtTypeOfSugar
        '
        Me.txtTypeOfSugar.Location = New System.Drawing.Point(92, 11)
        Me.txtTypeOfSugar.Name = "txtTypeOfSugar"
        Me.txtTypeOfSugar.Size = New System.Drawing.Size(100, 20)
        Me.txtTypeOfSugar.TabIndex = 1
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
        'pnlHelp
        '
        Me.pnlHelp.BackColor = System.Drawing.SystemColors.ControlLight
        Me.pnlHelp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlHelp.Controls.Add(Me.lblInfo)
        Me.pnlHelp.Location = New System.Drawing.Point(246, 14)
        Me.pnlHelp.Name = "pnlHelp"
        Me.pnlHelp.Size = New System.Drawing.Size(168, 234)
        Me.pnlHelp.TabIndex = 3
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Location = New System.Drawing.Point(14, 6)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(141, 221)
        Me.lblInfo.TabIndex = 0
        Me.lblInfo.Text = resources.GetString("lblInfo.Text")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Количество на складе: "
        '
        'txtNumber
        '
        Me.txtNumber.Location = New System.Drawing.Point(25, 94)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(61, 20)
        Me.txtNumber.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Купить"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(92, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "шт."
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Blue
        Me.Panel1.Controls.Add(Me.lblMain)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(720, 64)
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
        Me.pnl2.Controls.Add(Me.Label1)
        Me.pnl2.Controls.Add(Me.Label5)
        Me.pnl2.Controls.Add(Me.cmdBuy)
        Me.pnl2.Controls.Add(Me.Label4)
        Me.pnl2.Controls.Add(Me.txtTypeOfSugar)
        Me.pnl2.Controls.Add(Me.txtNumber)
        Me.pnl2.Controls.Add(Me.pnlHelp)
        Me.pnl2.Controls.Add(Me.Label2)
        Me.pnl2.Location = New System.Drawing.Point(283, 121)
        Me.pnl2.Name = "pnl2"
        Me.pnl2.Size = New System.Drawing.Size(433, 248)
        Me.pnl2.TabIndex = 0
        '
        'rdoOrganization
        '
        Me.rdoOrganization.AutoSize = True
        Me.rdoOrganization.Location = New System.Drawing.Point(21, 118)
        Me.rdoOrganization.Name = "rdoOrganization"
        Me.rdoOrganization.Size = New System.Drawing.Size(92, 17)
        Me.rdoOrganization.TabIndex = 1
        Me.rdoOrganization.Text = "Организации"
        Me.rdoOrganization.UseVisualStyleBackColor = True
        '
        'rdoPrivatePerson
        '
        Me.rdoPrivatePerson.AutoSize = True
        Me.rdoPrivatePerson.Location = New System.Drawing.Point(118, 118)
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
        Me.lblName.Location = New System.Drawing.Point(17, 33)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(110, 13)
        Me.lblName.TabIndex = 22
        Me.lblName.Text = "Введите ваше имя..."
        '
        'txtName
        '
        Me.txtName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuyersBindingSource, "Имя_заказчика", True))
        Me.txtName.Location = New System.Drawing.Point(20, 49)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(167, 20)
        Me.txtName.TabIndex = 23
        '
        'txtOrganization
        '
        Me.txtOrganization.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuyersBindingSource, "Наименование_организации", True))
        Me.txtOrganization.Location = New System.Drawing.Point(20, 104)
        Me.txtOrganization.Multiline = True
        Me.txtOrganization.Name = "txtOrganization"
        Me.txtOrganization.Size = New System.Drawing.Size(167, 75)
        Me.txtOrganization.TabIndex = 24
        '
        'lblOrganization
        '
        Me.lblOrganization.AutoSize = True
        Me.lblOrganization.Location = New System.Drawing.Point(17, 88)
        Me.lblOrganization.Name = "lblOrganization"
        Me.lblOrganization.Size = New System.Drawing.Size(170, 13)
        Me.lblOrganization.TabIndex = 25
        Me.lblOrganization.Text = "... и наименование организации"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(241, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "_______________________________________"
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
        Me.pnl1.Size = New System.Drawing.Size(260, 229)
        Me.pnl1.TabIndex = 27
        '
        'cmdFurther
        '
        Me.cmdFurther.Location = New System.Drawing.Point(173, 203)
        Me.cmdFurther.Name = "cmdFurther"
        Me.cmdFurther.Size = New System.Drawing.Size(75, 23)
        Me.cmdFurther.TabIndex = 27
        Me.cmdFurther.Text = "Далее"
        Me.cmdFurther.UseVisualStyleBackColor = True
        '
        'frmBuy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 375)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.rdoPrivatePerson)
        Me.Controls.Add(Me.rdoOrganization)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnl2)
        Me.Controls.Add(Me.pnl1)
        Me.Name = "frmBuy"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Покупка"
        Me.pnlHelp.ResumeLayout(False)
        Me.pnlHelp.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.pnl2.ResumeLayout(False)
        Me.pnl2.PerformLayout()
        CType(Me.BuyersDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl1.ResumeLayout(False)
        Me.pnl1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdBuy As System.Windows.Forms.Button
    Friend WithEvents txtTypeOfSugar As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pnlHelp As System.Windows.Forms.Panel
    Friend WithEvents lblInfo As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
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
    Friend WithEvents BuyersDatabaseDataSet As SampleCourseProject.BuyersDatabaseDataSet
    Friend WithEvents BuyersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BuyersTableAdapter As SampleCourseProject.BuyersDatabaseDataSetTableAdapters.BuyersTableAdapter
    Friend WithEvents pnl1 As System.Windows.Forms.Panel
    Friend WithEvents cmdFurther As System.Windows.Forms.Button
End Class
