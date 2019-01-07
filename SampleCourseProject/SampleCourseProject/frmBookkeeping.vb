Public Class frmBookkeeping

    Dim result As DialogResult

    'Код, относящийся к первой вкладке (Персонал)

    'Расширение окна формы до соответствующих размеров и выбор первой строки таблицы
    Private Sub tpPersonal_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tpPersonal.Enter
        If tabBookkeeping.SelectedTab Is tpPersonal Then
            With Me
                .Width = 1184
                .Height = 328
            End With
            ПерсоналBindingSource.MoveFirst()
        End If
    End Sub
    'Сохранение информации в базу данных и обновление таблицы на форме
    Private Sub cmdDatabasePersonal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDatabasePersonal.Click
        ПерсоналBindingSource.EndEdit()
        ПерсоналTableAdapter.Update(BookkeepingDatabaseDataSet.Персонал)
        MessageBox.Show("All good!")
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
    'Возврат на главное меню и закрытие формы бухгалтерии
    Private Sub cmdBackStaff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBackStaff.Click
        frmMain.Show()
        Me.Close()
    End Sub



    'Код, относящийся ко второй вкладке (Комм. услуги)

    'Расширение окна формы до соответствующих размеров
    Private Sub tpMS_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tpMS.Enter
        If tabBookkeeping.SelectedTab Is tpMS Then
            With Me
                .Width = 742
                .Height = 268
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
    'Возврат на главное меню и закрытие формы бухгалтерии
    Private Sub cmdBackMS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBackMS.Click
        frmMain.Show()
        Me.Close()
    End Sub


    'Код, относящийся к третьей вкладке (Прибыль)

    'Расширение окна формы до соответствующих размеров
    Private Sub tpIncome_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tpIncome.Enter
        If tabBookkeeping.SelectedTab Is tpIncome Then
            With Me
                .Width = 721
                .Height = 303
            End With
        End If
    End Sub
    'При переходе на вкладку "Сахар" выделяется первая строка таблицы
    Private Sub tpSugar_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tpSugar.Enter
        If tabIncome.SelectedTab Is tpSugar Then
            СахарBindingSource.MoveFirst()
        End If
    End Sub
    'При переходе на вкладку "Жом" выделяется первая строка таблицы
    Private Sub tpPulp_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tpPulp.Enter
        If tabIncome.SelectedTab Is tpPulp Then
            ЖомBindingSource.MoveFirst()
        End If
    End Sub
    'При переходе на вкладку "Меласса" выделяется первая строка таблицы
    Private Sub tpMolasses_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tpMolasses.Enter
        If tabIncome.SelectedTab Is tpMolasses Then
            МелассаBindingSource.MoveFirst()
        End If
    End Sub
    'Выделить предыдущую строку таблицы на вкладке "Сахар"
    Private Sub cmdPreviousSugar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPreviousSugar.Click
        СахарBindingSource.MovePrevious()
    End Sub
    'Создать новую строку таблицы на вкладке "Сахар"
    Private Sub cmdAddNewSugar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddNewSugar.Click
        СахарBindingSource.AddNew()
    End Sub
    'Выделить следующую строку таблицы на вкладке "Сахар"
    Private Sub cmdNextSugar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNextSugar.Click
        СахарBindingSource.MoveNext()
    End Sub
    'Сохранение информации в базу данных и обновление таблицы на вкладке "Сахар"
    Private Sub cmdSaveSugar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSaveSugar.Click
        СахарBindingSource.EndEdit()
        СахарTableAdapter.Update(BookkeepingDatabaseDataSet.Сахар)
        MessageBox.Show("All good!")
    End Sub
    'Удаление строки из таблицы на вкладке "Сахар"
    Private Sub cmdDeleteSugar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDeleteSugar.Click
        On Error GoTo ErrExite
        result = MessageBox.Show("Вы уверены?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
        If result = DialogResult.Yes Then
            СахарBindingSource.RemoveCurrent()
            СахарTableAdapter.Update(BookkeepingDatabaseDataSet.Сахар)
            Exit Sub
        Else
            Exit Sub
        End If
ErrExite:
        MsgBox("Поле пусто, ничего нельзя удалить", MsgBoxStyle.Critical, "Ошибка")
        Exit Sub
    End Sub
    'Выделить предыдущую строку таблицы на вкладке "Жом"
    Private Sub cmdPreviousPulp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPreviousPulp.Click
        ЖомBindingSource.MovePrevious()
    End Sub
    'Создать новую строку таблицы на вкладке "Жом"
    Private Sub cmdAddNewPulp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddNewPulp.Click
        ЖомBindingSource.AddNew()
    End Sub
    'Выделить следующую строку таблицы на вкладке "Жом"
    Private Sub cmdNextPulp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNextPulp.Click
        ЖомBindingSource.MoveNext()
    End Sub
    'Сохранение информации в базу данных и обновление таблицы на вкладке "Жом"
    Private Sub cmdSavePulp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSavePulp.Click
        ЖомBindingSource.EndEdit()
        ЖомTableAdapter.Update(BookkeepingDatabaseDataSet.Жом)
        MessageBox.Show("All good!")
    End Sub
    'Удаление строки из таблицы на вкладке "Жом"
    Private Sub cmdDeletePulp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDeletePulp.Click
        On Error GoTo ErrExite
        result = MessageBox.Show("Вы уверены?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
        If result = DialogResult.Yes Then
            ЖомBindingSource.RemoveCurrent()
            ЖомTableAdapter.Update(BookkeepingDatabaseDataSet.Жом)
            Exit Sub
        Else
            Exit Sub
        End If
ErrExite:
        MsgBox("Поле пусто, ничего нельзя удалить", MsgBoxStyle.Critical, "Ошибка")
        Exit Sub
    End Sub
    'Выделить предыдущую строку таблицы на вкладке "Меласса"
    Private Sub cmdPreviousMolasses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPreviousMolasses.Click
        МелассаBindingSource.MovePrevious()
    End Sub
    'Создать новую строку таблицы на вкладке "Меласса"
    Private Sub cmdAddNewMolasses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddNewMolasses.Click
        МелассаBindingSource.AddNew()
    End Sub
    'Выделить следующую строку таблицы на вкладке "Меласса"
    Private Sub cmdNextMolasses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNextMolasses.Click
        МелассаBindingSource.MoveNext()
    End Sub
    'Сохранение информации в базу данных и обновление таблицы на вкладке "Меласса"
    Private Sub cmdSaveMolasses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSaveMolasses.Click
        МелассаBindingSource.EndEdit()
        МелассаTableAdapter.Update(BookkeepingDatabaseDataSet.Меласса)
        MessageBox.Show("All good!")
    End Sub
    'Удаление строки из таблицы на вкладке "Меласса"
    Private Sub cmdDeleteMolasses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDeleteMolasses.Click
        On Error GoTo ErrExite
        result = MessageBox.Show("Вы уверены?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
        If result = DialogResult.Yes Then
            МелассаBindingSource.RemoveCurrent()
            МелассаTableAdapter.Update(BookkeepingDatabaseDataSet.Меласса)
            Exit Sub
        Else
            Exit Sub
        End If
ErrExite:
        MsgBox("Поле пусто, ничего нельзя удалить", MsgBoxStyle.Critical, "Ошибка")
        Exit Sub
    End Sub
    'Расчёт дохода от сахара по формуле (Дс = Кс * Цс), где 
    'Дс - доход от сахара
    'Кс - количество сахара
    'Цс - цена на сахар
    Private Sub cmdCalculateSugar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCalculateSugar.Click
        txtIncomeSugar.Text = Val(txtNumberSugar.Text) * Val(txtPriceSugar.Text)
    End Sub
    'Расчёт дохода от жома по формуле (Дж = Кж * Цж), где 
    'Дж - доход от жома
    'Кж - количество жома
    'Цж - цена на жом
    Private Sub cmdCalculatePulp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCalculatePulp.Click
        txtIncomePulp.Text = Val(txtNumberPulp.Text) * Val(txtPricePulp.Text)
    End Sub
    'Расчёт дохода от мелассы по формуле (Дм = Км * Цм), где 
    'Дм - доход от мелассы
    'Км - количество мелассы
    'Цм - цена на мелассу
    Private Sub cmdCalculateMolasses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCalculateMolasses.Click
        txtIncomeMolasses.Text = Val(txtNumberMolasses.Text) * Val(txtPriceMolasses.Text)
    End Sub
    'Возврат на главное меню и закрытие формы бухгалтерии
    Private Sub cmdBackIncome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBackIncome.Click
        frmMain.Show()
        Me.Close()
    End Sub

    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        MsgBox("Поиск не работает", MessageBoxIcon.Error, "Ограничение доступа")
        cmdSearch.Enabled = False
    End Sub

    Private Sub frmBookkeeping_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "BookkeepingDatabaseDataSet.Меласса". При необходимости она может быть перемещена или удалена.
        Me.МелассаTableAdapter.Fill(Me.BookkeepingDatabaseDataSet.Меласса)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "BookkeepingDatabaseDataSet.Жом". При необходимости она может быть перемещена или удалена.
        Me.ЖомTableAdapter.Fill(Me.BookkeepingDatabaseDataSet.Жом)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "BookkeepingDatabaseDataSet.Сахар". При необходимости она может быть перемещена или удалена.
        Me.СахарTableAdapter.Fill(Me.BookkeepingDatabaseDataSet.Сахар)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "BookkeepingDatabaseDataSet.Вода". При необходимости она может быть перемещена или удалена.
        Me.ВодаTableAdapter.Fill(Me.BookkeepingDatabaseDataSet.Вода)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "BookkeepingDatabaseDataSet.Газ". При необходимости она может быть перемещена или удалена.
        Me.ГазTableAdapter.Fill(Me.BookkeepingDatabaseDataSet.Газ)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "BookkeepingDatabaseDataSet.Электричество". При необходимости она может быть перемещена или удалена.
        Me.ЭлектричествоTableAdapter.Fill(Me.BookkeepingDatabaseDataSet.Электричество)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "BookkeepingDatabaseDataSet.Персонал". При необходимости она может быть перемещена или удалена.
        Me.ПерсоналTableAdapter.Fill(Me.BookkeepingDatabaseDataSet.Персонал)

    End Sub
End Class
