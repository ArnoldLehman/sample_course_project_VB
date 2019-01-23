Imports System.Data.OleDb
Imports System.Data

Public Class frmBuy
    Dim dbsource As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\StorageDatabase.mdb"
    Dim conn = New OleDbConnection(dbsource)

    Dim amountSugar As String = ""
    Dim tpSugar As String = ""

    Dim Cost As Integer

    Private Sub frmBuy_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frmMain.Show()
    End Sub
    'Код, в котором из базы Storage вычитается введённо количество товара и обновляется база данных
    Private Sub cmdBuy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuy.Click
        amountSugar -= Val(txtNumber.Text)
        tpSugar = cboTypeOfSugar.Text
        Try
            conn.open()
            Dim str As String = "UPDATE Storage SET Количество=? where Виды= '" & tpSugar & "';"
            Dim cmd As New OleDbCommand(str, conn)
            cmd.Parameters.AddWithValue("Количество_сахара", amountSugar)
            cmd.ExecuteNonQuery()
            conn.close()


            Dim buy As DialogResult
            BuyersBindingSource.EndEdit()
            BuyersTableAdapter.Update(BuyersDatabaseDataSet.Buyers)
            MessageBox.Show("Ваш заказ отправлен на обработку" & vbNewLine & "В ближайшее время с вами свяжутся для уточнения деталей", "Купить", MessageBoxButtons.OK, MessageBoxIcon.Information)

            buy = MessageBox.Show("Хотите сделать ещё один заказ?", "Купить", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button1)
            If buy = Windows.Forms.DialogResult.Yes Then
                BuyersBindingSource.AddNew()
                txtOrganization.Text = " - "
                Label8.Text = "Количество на складе: "
            Else
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmBuy_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "StorageDatabaseDataSet.Storage". При необходимости она может быть перемещена или удалена.
        Me.StorageTableAdapter.Fill(Me.StorageDatabaseDataSet.Storage)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "BuyersDatabaseDataSet.Buyers". При необходимости она может быть перемещена или удалена.
        Me.BuyersTableAdapter.Fill(Me.BuyersDatabaseDataSet.Buyers)

        BuyersBindingSource.AddNew()
        Label8.Text = "Количество на складе: "

        'Задаётся начальный вид формы
        With Me
            .Height = 195
            .Width = 343
        End With
        rdoOrganization.Checked = False
        rdoPrivatePerson.Checked = False
        pnl1.Hide()
        pnl2.Hide()

    End Sub
    'При нажатии на одни из переключателей меняется внешний вид формы и некоторых элементов
    Private Sub rdoOrganization_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoOrganization.CheckedChanged
        With Me
            .Height = 386
            .Width = 343
        End With
        pnl1.Visible = True
        With txtOrganization
            .Text = ""
            .ReadOnly = False
        End With
        pnl2.Hide()
        cmdFurther.Visible = True
    End Sub

    Private Sub rdoPrivatePerson_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoPrivatePerson.CheckedChanged
        With Me
            .Height = 386
            .Width = 343
        End With
        pnl1.Visible = True
        With txtOrganization
            .Text = " - "
            .ReadOnly = True
        End With
        pnl2.Hide()
        cmdFurther.Visible = True
    End Sub

    'Меняется внешний вид формы
    Private Sub cmdFurther_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFurther.Click
        If txtOrganization.Text = "" Or txtName.Text = "" Then
            MsgBox("Введите данные", MsgBoxStyle.Critical, "")
            Exit Sub
        End If
        With Me
            .Height = 349
            .Width = 511
        End With
        pnl2.Visible = True
        cmdFurther.Hide()
    End Sub
    'В зависимости от выбора меняется выводимое количество продукции в метку...
    Private Sub cboTypeOfSugar_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTypeOfSugar.SelectedIndexChanged
        tpSugar = cboTypeOfSugar.Text
        Try
            Dim querry As String = "Select Количество From Storage where Виды= '" & tpSugar & "';"
            Dim cmd As New OleDbCommand(querry, conn)
            conn.Open()

            amountSugar = cmd.ExecuteScalar().ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        lblNumberOnStorage.Text = amountSugar & " кг"
        conn.close()

        '...а также присваивается переменно Cost цену за одни кг. продукции
        If cboTypeOfSugar.SelectedIndex = 0 Then
            Cost = 93
        ElseIf cboTypeOfSugar.SelectedIndex = 1 Then
            Cost = 119
        ElseIf cboTypeOfSugar.SelectedIndex = 2 Then
            Cost = 263
        ElseIf cboTypeOfSugar.SelectedIndex = 3 Then
            Cost = 130
        ElseIf cboTypeOfSugar.SelectedIndex = 4 Then
            Cost = 256
        ElseIf cboTypeOfSugar.SelectedIndex = 5 Then
            Cost = 2.6
        ElseIf cboTypeOfSugar.SelectedIndex = 6 Then
            Cost = 12.5
        End If
    End Sub

    'Проверка на цифры
    Private Sub ChecksNumberInBuy(ByVal txt As TextBox)
        If checksNumber(txt) = True Then
            MessageBox.Show("Некорректный ввод данных", "Ввод", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub txtName_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtName.Leave
        ChecksNumberInBuy(txtName)
    End Sub

    'Проверка на буквы
    Private Sub ChecksWordInBuy(ByVal txt As TextBox)
        If checksWord(txt) = True Then
            MessageBox.Show("Некорректный ввод данных", "Ввод", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt.Focus()
            Exit Sub
        End If
    End Sub

    'Расчитывается сумма к оплате
    Private Sub txtNumber_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNumber.Leave
        ChecksWordInBuy(txtNumber)
        txtSumm.Text = Cost * Val(txtNumber.Text)
    End Sub

    Private Sub lblMain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblMain.Click
        frmMain.Show()
        Me.Close()
    End Sub
    'Изменение внешнего вида метки при наведении курсора на неё
    Private Sub lblMain_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblMain.MouseEnter
        msHoverTitle(lblMain)
    End Sub

    Private Sub lblMain_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblMain.MouseLeave
        msLeaveTitle(lblMain)
    End Sub
End Class