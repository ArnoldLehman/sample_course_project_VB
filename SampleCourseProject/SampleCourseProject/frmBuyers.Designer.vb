<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuyers
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
        Me.dgvBuyers = New System.Windows.Forms.DataGridView
        Me.КодDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.НаименованиеорганизацииDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ИмязаказчикаDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.НаименованиетовараDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.КоличествокупленноготовараDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ОплатазазаказDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BuyersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuyersDatabaseDataSet = New SampleCourseProject.BuyersDatabaseDataSet
        Me.BuyersTableAdapter = New SampleCourseProject.BuyersDatabaseDataSetTableAdapters.BuyersTableAdapter
        Me.txtSearch = New System.Windows.Forms.TextBox
        Me.cmdSearch = New System.Windows.Forms.Button
        Me.lblReset = New System.Windows.Forms.Label
        Me.cmdAddNew = New System.Windows.Forms.Button
        Me.cmdSave = New System.Windows.Forms.Button
        Me.cmdDelete = New System.Windows.Forms.Button
        Me.txtNameOfOrganizatioin = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtNameOfCustomer = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtNameOfProduct = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtNumberProduct = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtPayment = New System.Windows.Forms.TextBox
        CType(Me.dgvBuyers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyersDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvBuyers
        '
        Me.dgvBuyers.AutoGenerateColumns = False
        Me.dgvBuyers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBuyers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.КодDataGridViewTextBoxColumn, Me.НаименованиеорганизацииDataGridViewTextBoxColumn, Me.ИмязаказчикаDataGridViewTextBoxColumn, Me.НаименованиетовараDataGridViewTextBoxColumn, Me.КоличествокупленноготовараDataGridViewTextBoxColumn, Me.ОплатазазаказDataGridViewTextBoxColumn})
        Me.dgvBuyers.DataSource = Me.BuyersBindingSource
        Me.dgvBuyers.Location = New System.Drawing.Point(12, 12)
        Me.dgvBuyers.MultiSelect = False
        Me.dgvBuyers.Name = "dgvBuyers"
        Me.dgvBuyers.ReadOnly = True
        Me.dgvBuyers.Size = New System.Drawing.Size(645, 258)
        Me.dgvBuyers.TabIndex = 0
        '
        'КодDataGridViewTextBoxColumn
        '
        Me.КодDataGridViewTextBoxColumn.DataPropertyName = "Код"
        Me.КодDataGridViewTextBoxColumn.HeaderText = "Код"
        Me.КодDataGridViewTextBoxColumn.Name = "КодDataGridViewTextBoxColumn"
        Me.КодDataGridViewTextBoxColumn.ReadOnly = True
        '
        'НаименованиеорганизацииDataGridViewTextBoxColumn
        '
        Me.НаименованиеорганизацииDataGridViewTextBoxColumn.DataPropertyName = "Наименование_организации"
        Me.НаименованиеорганизацииDataGridViewTextBoxColumn.HeaderText = "Наименование организации"
        Me.НаименованиеорганизацииDataGridViewTextBoxColumn.Name = "НаименованиеорганизацииDataGridViewTextBoxColumn"
        Me.НаименованиеорганизацииDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ИмязаказчикаDataGridViewTextBoxColumn
        '
        Me.ИмязаказчикаDataGridViewTextBoxColumn.DataPropertyName = "Имя_заказчика"
        Me.ИмязаказчикаDataGridViewTextBoxColumn.HeaderText = "Имя заказчика"
        Me.ИмязаказчикаDataGridViewTextBoxColumn.Name = "ИмязаказчикаDataGridViewTextBoxColumn"
        Me.ИмязаказчикаDataGridViewTextBoxColumn.ReadOnly = True
        '
        'НаименованиетовараDataGridViewTextBoxColumn
        '
        Me.НаименованиетовараDataGridViewTextBoxColumn.DataPropertyName = "Наименование_товара"
        Me.НаименованиетовараDataGridViewTextBoxColumn.HeaderText = "Наименование товара"
        Me.НаименованиетовараDataGridViewTextBoxColumn.Name = "НаименованиетовараDataGridViewTextBoxColumn"
        Me.НаименованиетовараDataGridViewTextBoxColumn.ReadOnly = True
        '
        'КоличествокупленноготовараDataGridViewTextBoxColumn
        '
        Me.КоличествокупленноготовараDataGridViewTextBoxColumn.DataPropertyName = "Количество_купленного_товара"
        Me.КоличествокупленноготовараDataGridViewTextBoxColumn.HeaderText = "Количество купленного товара"
        Me.КоличествокупленноготовараDataGridViewTextBoxColumn.Name = "КоличествокупленноготовараDataGridViewTextBoxColumn"
        Me.КоличествокупленноготовараDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ОплатазазаказDataGridViewTextBoxColumn
        '
        Me.ОплатазазаказDataGridViewTextBoxColumn.DataPropertyName = "Оплата_за_заказ"
        Me.ОплатазазаказDataGridViewTextBoxColumn.HeaderText = "Оплата за заказ"
        Me.ОплатазазаказDataGridViewTextBoxColumn.Name = "ОплатазазаказDataGridViewTextBoxColumn"
        Me.ОплатазазаказDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BuyersBindingSource
        '
        Me.BuyersBindingSource.DataMember = "Buyers"
        Me.BuyersBindingSource.DataSource = Me.BuyersDatabaseDataSet
        '
        'BuyersDatabaseDataSet
        '
        Me.BuyersDatabaseDataSet.DataSetName = "BuyersDatabaseDataSet"
        Me.BuyersDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BuyersTableAdapter
        '
        Me.BuyersTableAdapter.ClearBeforeFill = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(70, 277)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(506, 20)
        Me.txtSearch.TabIndex = 1
        '
        'cmdSearch
        '
        Me.cmdSearch.Location = New System.Drawing.Point(582, 276)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(75, 20)
        Me.cmdSearch.TabIndex = 2
        Me.cmdSearch.Text = "Поиск"
        Me.cmdSearch.UseVisualStyleBackColor = True
        '
        'lblReset
        '
        Me.lblReset.AutoSize = True
        Me.lblReset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblReset.Location = New System.Drawing.Point(9, 280)
        Me.lblReset.Name = "lblReset"
        Me.lblReset.Size = New System.Drawing.Size(55, 13)
        Me.lblReset.TabIndex = 3
        Me.lblReset.Text = "Сбросить"
        '
        'cmdAddNew
        '
        Me.cmdAddNew.Location = New System.Drawing.Point(674, 247)
        Me.cmdAddNew.Name = "cmdAddNew"
        Me.cmdAddNew.Size = New System.Drawing.Size(75, 23)
        Me.cmdAddNew.TabIndex = 4
        Me.cmdAddNew.Text = "Добавить"
        Me.cmdAddNew.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(761, 247)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 23)
        Me.cmdSave.TabIndex = 6
        Me.cmdSave.Text = "Сохранить"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(845, 247)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(75, 23)
        Me.cmdDelete.TabIndex = 7
        Me.cmdDelete.Text = "Удалить"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'txtNameOfOrganizatioin
        '
        Me.txtNameOfOrganizatioin.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuyersBindingSource, "Наименование_организации", True))
        Me.txtNameOfOrganizatioin.Location = New System.Drawing.Point(674, 28)
        Me.txtNameOfOrganizatioin.Name = "txtNameOfOrganizatioin"
        Me.txtNameOfOrganizatioin.Size = New System.Drawing.Size(246, 20)
        Me.txtNameOfOrganizatioin.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(671, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Наименование организации"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(671, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Имя заказчика"
        '
        'txtNameOfCustomer
        '
        Me.txtNameOfCustomer.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuyersBindingSource, "Имя_заказчика", True))
        Me.txtNameOfCustomer.Location = New System.Drawing.Point(674, 76)
        Me.txtNameOfCustomer.Name = "txtNameOfCustomer"
        Me.txtNameOfCustomer.Size = New System.Drawing.Size(246, 20)
        Me.txtNameOfCustomer.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(671, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Наименование товара"
        '
        'txtNameOfProduct
        '
        Me.txtNameOfProduct.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuyersBindingSource, "Наименование_товара", True))
        Me.txtNameOfProduct.Location = New System.Drawing.Point(674, 124)
        Me.txtNameOfProduct.Name = "txtNameOfProduct"
        Me.txtNameOfProduct.Size = New System.Drawing.Size(246, 20)
        Me.txtNameOfProduct.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(671, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(165, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Количество купленного товара"
        '
        'txtNumberProduct
        '
        Me.txtNumberProduct.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuyersBindingSource, "Количество_купленного_товара", True))
        Me.txtNumberProduct.Location = New System.Drawing.Point(674, 173)
        Me.txtNumberProduct.Name = "txtNumberProduct"
        Me.txtNumberProduct.Size = New System.Drawing.Size(246, 20)
        Me.txtNumberProduct.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(671, 205)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Оплата за заказ"
        '
        'txtPayment
        '
        Me.txtPayment.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuyersBindingSource, "Оплата_за_заказ", True))
        Me.txtPayment.Location = New System.Drawing.Point(674, 221)
        Me.txtPayment.Name = "txtPayment"
        Me.txtPayment.Size = New System.Drawing.Size(246, 20)
        Me.txtPayment.TabIndex = 16
        '
        'frmBuyers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(932, 307)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtPayment)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtNumberProduct)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNameOfProduct)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNameOfCustomer)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNameOfOrganizatioin)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdAddNew)
        Me.Controls.Add(Me.lblReset)
        Me.Controls.Add(Me.cmdSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.dgvBuyers)
        Me.Name = "frmBuyers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Покупатели"
        CType(Me.dgvBuyers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyersDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvBuyers As System.Windows.Forms.DataGridView
    Friend WithEvents BuyersDatabaseDataSet As SampleCourseProject.BuyersDatabaseDataSet
    Friend WithEvents BuyersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BuyersTableAdapter As SampleCourseProject.BuyersDatabaseDataSetTableAdapters.BuyersTableAdapter
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents cmdSearch As System.Windows.Forms.Button
    Friend WithEvents lblReset As System.Windows.Forms.Label
    Friend WithEvents КодDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents НаименованиеорганизацииDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ИмязаказчикаDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents НаименованиетовараDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents КоличествокупленноготовараDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ОплатазазаказDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmdAddNew As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents txtNameOfOrganizatioin As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNameOfCustomer As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNameOfProduct As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNumberProduct As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPayment As System.Windows.Forms.TextBox
End Class
