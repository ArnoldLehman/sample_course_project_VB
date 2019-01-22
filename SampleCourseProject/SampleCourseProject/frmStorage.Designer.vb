<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStorage
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
        Me.ВидыDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.КоличествоDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.StorageBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StorageDatabaseDataSet = New SampleCourseProject.StorageDatabaseDataSet
        Me.cmdAddNew = New System.Windows.Forms.Button
        Me.cmdDelete = New System.Windows.Forms.Button
        Me.cmdUpdate = New System.Windows.Forms.Button
        Me.cmdSave = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtType = New System.Windows.Forms.TextBox
        Me.txtNumber = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblMain = New System.Windows.Forms.Label
        Me.StorageTableAdapter = New SampleCourseProject.StorageDatabaseDataSetTableAdapters.StorageTableAdapter
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StorageBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StorageDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ВидыDataGridViewTextBoxColumn, Me.КоличествоDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.StorageBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 67)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(244, 143)
        Me.DataGridView1.TabIndex = 0
        '
        'ВидыDataGridViewTextBoxColumn
        '
        Me.ВидыDataGridViewTextBoxColumn.DataPropertyName = "Виды"
        Me.ВидыDataGridViewTextBoxColumn.HeaderText = "Виды"
        Me.ВидыDataGridViewTextBoxColumn.Name = "ВидыDataGridViewTextBoxColumn"
        '
        'КоличествоDataGridViewTextBoxColumn
        '
        Me.КоличествоDataGridViewTextBoxColumn.DataPropertyName = "Количество"
        Me.КоличествоDataGridViewTextBoxColumn.HeaderText = "Количество"
        Me.КоличествоDataGridViewTextBoxColumn.Name = "КоличествоDataGridViewTextBoxColumn"
        '
        'StorageBindingSource
        '
        Me.StorageBindingSource.DataMember = "Storage"
        Me.StorageBindingSource.DataSource = Me.StorageDatabaseDataSet
        '
        'StorageDatabaseDataSet
        '
        Me.StorageDatabaseDataSet.DataSetName = "StorageDatabaseDataSet"
        Me.StorageDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmdAddNew
        '
        Me.cmdAddNew.Location = New System.Drawing.Point(265, 187)
        Me.cmdAddNew.Name = "cmdAddNew"
        Me.cmdAddNew.Size = New System.Drawing.Size(75, 23)
        Me.cmdAddNew.TabIndex = 1
        Me.cmdAddNew.Text = "Добавить"
        Me.cmdAddNew.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(346, 187)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(80, 23)
        Me.cmdDelete.TabIndex = 2
        Me.cmdDelete.Text = "Удалить"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Location = New System.Drawing.Point(265, 158)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(75, 23)
        Me.cmdUpdate.TabIndex = 3
        Me.cmdUpdate.Text = "Изменить"
        Me.cmdUpdate.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(346, 158)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(80, 23)
        Me.cmdSave.TabIndex = 4
        Me.cmdSave.Text = "Сохранить"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(262, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Вид"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(262, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Количество"
        '
        'txtType
        '
        Me.txtType.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StorageBindingSource, "Виды", True))
        Me.txtType.Location = New System.Drawing.Point(265, 83)
        Me.txtType.Name = "txtType"
        Me.txtType.Size = New System.Drawing.Size(161, 20)
        Me.txtType.TabIndex = 8
        '
        'txtNumber
        '
        Me.txtNumber.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StorageBindingSource, "Количество", True))
        Me.txtNumber.Location = New System.Drawing.Point(265, 132)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(161, 20)
        Me.txtNumber.TabIndex = 10
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Blue
        Me.Panel1.Controls.Add(Me.lblMain)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(435, 55)
        Me.Panel1.TabIndex = 11
        '
        'lblMain
        '
        Me.lblMain.BackColor = System.Drawing.Color.Blue
        Me.lblMain.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblMain.ForeColor = System.Drawing.Color.White
        Me.lblMain.Location = New System.Drawing.Point(-3, 0)
        Me.lblMain.Name = "lblMain"
        Me.lblMain.Size = New System.Drawing.Size(100, 55)
        Me.lblMain.TabIndex = 2
        Me.lblMain.Text = "Главная"
        Me.lblMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StorageTableAdapter
        '
        Me.StorageTableAdapter.ClearBeforeFill = True
        '
        'frmStorage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 223)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtNumber)
        Me.Controls.Add(Me.txtType)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdUpdate)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdAddNew)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmStorage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Склад"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StorageBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StorageDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents cmdAddNew As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents cmdUpdate As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtType As System.Windows.Forms.TextBox
    Friend WithEvents txtNumber As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblMain As System.Windows.Forms.Label
    Friend WithEvents StorageDatabaseDataSet As SampleCourseProject.StorageDatabaseDataSet
    Friend WithEvents StorageBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StorageTableAdapter As SampleCourseProject.StorageDatabaseDataSetTableAdapters.StorageTableAdapter
    Friend WithEvents ВидыDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents КоличествоDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
