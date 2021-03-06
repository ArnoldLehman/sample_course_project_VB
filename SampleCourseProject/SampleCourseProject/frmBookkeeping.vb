﻿Imports System.Data
Imports System.Data.OleDb

Public Class frmBookkeeping

    Dim result As DialogResult


    'Блок кода, относящийся к шапке
    'При наведении мыши на метки цвет фона меняется...
    Private Sub lblMain_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblMain.MouseEnter
        msHoverTitle(lblMain)
    End Sub
    '...и становтся прежним при покидании курсора границ объекта
    Private Sub lblMain_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblMain.MouseLeave
        msLeaveTitle(lblMain)
    End Sub

    Private Sub lblMain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblMain.Click
        frmMain.Show()
        Me.Close()
    End Sub



    'Код, относящийся к первой вкладке (Персонал)

    'Расширение окна формы до соответствующих размеров и выбор первой строки таблицы
    Private Sub tpPersonal_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tpPersonal.Enter
        If tabBookkeeping.SelectedTab Is tpPersonal Then
            With Me
                .Width = 1230
                .Height = 386
            End With
            ПерсоналBindingSource.MoveFirst()
        End If
    End Sub
    'Сохранение информации в базу данных и обновление таблицы на форме
    Private Sub cmdDatabasePersonal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDatabasePersonal.Click
        Try
            ПерсоналBindingSource.EndEdit()
            ПерсоналTableAdapter.Update(BookkeepingDatabaseDataSet.Персонал)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    'Создание новой строки таблицы
    Private Sub cmdAddNewPrsonal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddNewPersonal.Click
        ПерсоналBindingSource.AddNew()
    End Sub
    'Удаление строки таблицы
    Private Sub cmdDeletePersonal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDeletePersonal.Click
        On Error GoTo ErrExite
        result = MessageBox.Show("Вы уверены?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
        If result = DialogResult.Yes Then
            ПерсоналBindingSource.RemoveCurrent()
            ПерсоналTableAdapter.Update(BookkeepingDatabaseDataSet.Персонал)
            Exit Sub
        Else
            Exit Sub
        End If
ErrExite:
        MsgBox("Поле пусто, ничего нельзя удалить", MsgBoxStyle.Critical, "Ошибка")
        Exit Sub
    End Sub
    'Выделение предыдущей строки таблицы 
    Private Sub cmdPreviousPersonal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPreviousPersonal.Click
        ПерсоналBindingSource.MovePrevious()
    End Sub
    'Выделение следующей строки таблицы
    Private Sub cmdNextPersonal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNextPersonal.Click
        ПерсоналBindingSource.MoveNext()
    End Sub
    'Расчёт зарплаты по формуле (ЗП = О / КРД * КОД), где
    'ЗП - зарплата
    'О - оклад
    'КРД - количество рабочих дней
    'КОД - количество отработанных дней
    Private Sub cmdCalculateWage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCalculateWage.Click
        txtWage.Text = Val(txtSalary.Text) / Val(txtNumbWorkDay.Text) * Val(txtNumbDaysWorked.Text)
        txtWage.Text = Val(txtWage.Text) - (Val(txtWage.Text) * 0.13)
    End Sub
    'Расчёт среднего дневного заработка по формуле (СДЗ = ЗП / КРД)
    Private Sub cmdCalculateSDZ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCalculateSDZ.Click
        txtSDZ.Text = Val(txtWage.Text) / Val(txtNumbWorkDay.Text)
    End Sub
    'Расчёт отпускных по формуле (Отп = СДЗ * КОД)
    Private Sub cmdCalculateHolidayPay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCalculateHolidayPay.Click
        txtHolidayPay.Text = Val(txtSDZ.Text) * Val(txtNumbDaysWorked.Text)
    End Sub

    'Очистить поле поиска и сбросить все фильтры поиска
    Private Sub lblReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblReset.Click
        Try
            txtSearch.Clear()
            ПерсоналBindingSource.Filter = Nothing

            With dgvStaff
                .ClearSelection()
                .ReadOnly = True
                .MultiSelect = False
                .DataSource = ПерсоналBindingSource
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'Поиск по базе данных
    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        Try
            If txtSearch.Text = "" Then
                Exit Sub
            Else
                Dim cantFine As String = txtSearch.Text
                ПерсоналBindingSource.Filter = "(Convert(Код, 'System.String') LIKE '" & txtSearch.Text & "')" & _
                "OR (Фамилия LIKE '" & txtSearch.Text & "') OR (Имя LIKE '" & txtSearch.Text & "')" & _
                "OR (Отчество LIKE '" & txtSearch.Text & "') OR (Профессия LIKE '" & txtSearch.Text & "')" & _
                "OR (Convert(Оклад, 'System.String') LIKE '" & txtSearch.Text & "')" & _
                "OR (Convert(Зарплата, 'System.String') LIKE '" & txtSearch.Text & "')"
                'Если что-то, искомое выше, нашлось в базе данных, тогда вывести информацию об этом в DataGridView
                If ПерсоналBindingSource.Count <> 0 Then
                    With dgvStaff
                        .DataSource = ПерсоналBindingSource
                    End With
                    'Иначе выдать сообщение об отсутсвии
                Else
                    MsgBox("Элемент " & cantFine & " не найден", MsgBoxStyle.Information, "Поиск")
                    ПерсоналBindingSource.Filter = Nothing
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub




    'Код, относящийся ко второй вкладке (Комм. услуги)

    'Расширение окна формы до соответствующих размеров
    Private Sub tpMS_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tpMS.Enter
        If tabBookkeeping.SelectedTab Is tpMS Then
            With Me
                .Width = 736
                .Height = 306
            End With
        End If
    End Sub
    'При переходе на вкладку "Электричество" выделяется первая строка таблицы
    Private Sub tpElectricity_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tpElectricity.Enter
        If tabMS.SelectedTab Is tpElectricity Then
            ЭлектричествоBindingSource.MoveFirst()
        End If
    End Sub
    'При переходе на вкладку "Газ" выделяется первая строка таблицы
    Private Sub tpGas_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tpGas.Enter
        If tabMS.SelectedTab Is tpGas Then
            ГазBindingSource.MoveFirst()
        End If
    End Sub
    'При переходе на вкладку "Вода" выделяется первая строка таблицы
    Private Sub tpWater_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tpWater.Enter
        If tabMS.SelectedTab Is tpWater Then
            ВодаBindingSource.MoveFirst()
        End If
    End Sub
    'Выделить предыдущую строку таблицы на вкладке "Электричество"
    Private Sub cmdPreviousElectricity_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPreviousElectricity.Click
        ЭлектричествоBindingSource.MovePrevious()
    End Sub
    'Создать новую строку таблицы на вкладке "Электричество"
    Private Sub cmdAddNewElectricity_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddNewElectricity.Click
        ЭлектричествоBindingSource.AddNew()
    End Sub
    'Выделить следующую строку таблицы на вкладке "Электричество"
    Private Sub cmdNextElectricity_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNextElectricity.Click
        ЭлектричествоBindingSource.MoveNext()
    End Sub
    'Сохранение информации в базу данных и обновление таблицы на вкладке "Электричество"
    Private Sub cmdSaveElectricity_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSaveElectricity.Click
        ЭлектричествоBindingSource.EndEdit()
        ЭлектричествоTableAdapter.Update(BookkeepingDatabaseDataSet.Электричество)
        MessageBox.Show("All good!")
    End Sub
    'Удаление строки из таблицы на вкладке "Электричество"
    Private Sub cmdDeleteElectricity_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDeleteElectricity.Click
        On Error GoTo ErrExite
        result = MessageBox.Show("Вы уверены?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
        If result = DialogResult.Yes Then
            ЭлектричествоBindingSource.RemoveCurrent()
            ЭлектричествоTableAdapter.Update(BookkeepingDatabaseDataSet.Электричество)
            Exit Sub
        Else
            Exit Sub
        End If
ErrExite:
        MsgBox("Поле пусто, ничего нельзя удалить", MsgBoxStyle.Critical, "Ошибка")
        Exit Sub
    End Sub
    'Выделить предыдущую строку таблицы на вкладке "Газ"
    Private Sub cmdPreviousGas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPreviousGas.Click
        ГазBindingSource.MovePrevious()
    End Sub
    'Создать новую строку таблицы на вкладке "Газ"
    Private Sub cmdAddNewGas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddNewGas.Click
        ГазBindingSource.AddNew()
    End Sub
    'Выделить следующую строку таблицы на вкладке "Газ"
    Private Sub cmdNextGas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNextGas.Click
        ГазBindingSource.MoveNext()
    End Sub
    'Сохранение информации в базу данных и обновление таблицы на вкладке "Газ"
    Private Sub cmdSaveGas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSaveGas.Click
        ГазBindingSource.EndEdit()
        ГазTableAdapter.Update(BookkeepingDatabaseDataSet.Газ)
        MessageBox.Show("All good!")
    End Sub
    'Удаление строки из таблицы на вкладке "Газ"
    Private Sub cmdDeleteGas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDeleteGas.Click
        On Error GoTo ErrExite
        result = MessageBox.Show("Вы уверены?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
        If result = DialogResult.Yes Then
            ГазBindingSource.RemoveCurrent()
            ГазTableAdapter.Update(BookkeepingDatabaseDataSet.Газ)
            Exit Sub
        Else
            Exit Sub
        End If
ErrExite:
        MsgBox("Поле пусто, ничего нельзя удалить", MsgBoxStyle.Critical, "Ошибка")
        Exit Sub
    End Sub
    'Выделить предыдущую строку таблицы на вкладке "Вода"
    Private Sub cmdPreviousWater_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPreviousWater.Click
        ВодаBindingSource.MovePrevious()
    End Sub
    'Создать новую строку таблицы на вкладке "Вода"
    Private Sub cmdAddNewWater_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddNewWater.Click
        ВодаBindingSource.AddNew()
    End Sub
    'Выделить следующую строку таблицы на вкладке "Вода"
    Private Sub cmdNextWater_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNextWater.Click
        ВодаBindingSource.MoveNext()
    End Sub
    'Сохранение информации в базу данных и обновление таблицы на вкладке "Вода"
    Private Sub cmdSaveWater_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSaveWater.Click
        ВодаBindingSource.EndEdit()
        ВодаTableAdapter.Update(BookkeepingDatabaseDataSet.Вода)
        MessageBox.Show("All good!")
    End Sub
    'Удаление строки из таблицы на вкладке "Вода"
    Private Sub cmdDeleteWater_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDeleteWater.Click
        On Error GoTo ErrExite
        result = MessageBox.Show("Вы уверены?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
        If result = DialogResult.Yes Then
            ВодаBindingSource.RemoveCurrent()
            ВодаTableAdapter.Update(BookkeepingDatabaseDataSet.Вода)
            Exit Sub
        Else
            Exit Sub
        End If
ErrExite:
        MsgBox("Поле пусто, ничего нельзя удалить", MsgBoxStyle.Critical, "Ошибка")
        Exit Sub
    End Sub
    'Расчёт затрат на газ по формуле (Рг = Пг * Тг), где
    'Рг - расход на газ
    'Пг - потреблено газа
    'Тг - тариф на газ
    Private Sub cmdCalculateGas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCalculateGas.Click
        txtRashGas.Text = Val(txtPotrGas.Text) * Val(txtTarifGas.Text)
    End Sub
    'Расчёт затрат на воду по формуле (Рв = Пв * Тв), где
    'Рв - расход на воду
    'Пв - потреблено воды
    'Тв - тариф на воду
    Private Sub cmdCalculateWater_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCalculateWater.Click
        txtRashWater.Text = Val(txtPotrWater.Text) * Val(txtTarifWater.Text)
    End Sub
    'Расчёт затрат на электричество по формуле (Рэ = Пэ * Тэ), где
    'Рэ - расход на электричество
    'Пэ - потреблено электричества
    'Тэ - тариф на электричество
    Private Sub cmdCalculateElectricity_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCalculateElectricity.Click
        txtRashElec.Text = Val(txtPotrElec.Text) * Val(txtTarifElec.Text)
    End Sub

    Private Sub frmBookkeeping_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frmMain.Show()
    End Sub

    Private Sub frmBookkeeping_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "BookkeepingDatabaseDataSet.Вода". При необходимости она может быть перемещена или удалена.
        Me.ВодаTableAdapter.Fill(Me.BookkeepingDatabaseDataSet.Вода)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "BookkeepingDatabaseDataSet.Газ". При необходимости она может быть перемещена или удалена.
        Me.ГазTableAdapter.Fill(Me.BookkeepingDatabaseDataSet.Газ)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "BookkeepingDatabaseDataSet.Электричество". При необходимости она может быть перемещена или удалена.
        Me.ЭлектричествоTableAdapter.Fill(Me.BookkeepingDatabaseDataSet.Электричество)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "BookkeepingDatabaseDataSet.Персонал". При необходимости она может быть перемещена или удалена.
        Me.ПерсоналTableAdapter.Fill(Me.BookkeepingDatabaseDataSet.Персонал)

        With dgvStaff
            .ClearSelection()
            .ReadOnly = True
            .MultiSelect = False
        End With
    End Sub
    
    'Блок проверок полей
    'Проверка на ввод цифр
    Private Sub ChecksNumberInBookkeeping(ByVal txt As TextBox)
        If checksNumber(txt) = True Then
            MessageBox.Show("Некорректный ввод данных", "Ввод", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt.Focus()
            Exit Sub
        Else
            Exit Sub
        End If
    End Sub

    Private Sub txtFirstName_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFirstName.Leave
        ChecksNumberInBookkeeping(txtFirstName)
    End Sub

    Private Sub txtLastName_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLastName.Leave
        ChecksNumberInBookkeeping(txtLastName)
    End Sub

    Private Sub txtPatronymic_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPatronymic.Leave
        ChecksNumberInBookkeeping(txtPatronymic)
    End Sub

    Private Sub txtProfession_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtProfession.Leave
        ChecksNumberInBookkeeping(txtProfession)
    End Sub


    'Проверка на ввод букв
    Private Sub ChecksWordInBookkeeping(ByVal txt As TextBox)
        If checksWord(txt) = True Then
            MessageBox.Show("Некорректный ввод данных", "Ввод", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt.Focus()
            Exit Sub
        Else
            Exit Sub
        End If
    End Sub

    Private Sub txtNumbDaysWorked_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNumbDaysWorked.Leave
        ChecksWordInBookkeeping(txtNumbDaysWorked)
    End Sub

    Private Sub txtNumbWorkDay_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNumbWorkDay.Leave
        ChecksWordInBookkeeping(txtNumbWorkDay)
    End Sub

    Private Sub txtSalary_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSalary.Leave
        ChecksWordInBookkeeping(txtSalary)
    End Sub

    Private Sub txtPotrElec_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPotrElec.Leave
        ChecksWordInBookkeeping(txtPotrElec)
    End Sub

    Private Sub txtPotrGas_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPotrGas.Leave
        ChecksWordInBookkeeping(txtPotrGas)
    End Sub

    Private Sub txtPotrWater_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPotrWater.Leave
        ChecksWordInBookkeeping(txtPotrWater)
    End Sub

    Private Sub txtTarifElec_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTarifElec.Leave
        ChecksWordInBookkeeping(txtTarifElec)
    End Sub

    Private Sub txtTarifGas_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTarifGas.Leave
        ChecksWordInBookkeeping(txtTarifGas)
    End Sub

    Private Sub txtTarifWater_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTarifWater.Leave
        ChecksWordInBookkeeping(txtTarifWater)
    End Sub
End Class
