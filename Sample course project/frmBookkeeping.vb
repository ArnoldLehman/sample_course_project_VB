Public Class frmBookkeeping

    Private Sub TabPage1_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPage1.Enter
        If TabControl1.SelectedTab Is TabPage1 Then
            With Me
                .Width = 1173
                .Height = 365
            End With
        End If
    End Sub

    Private Sub TabPage2_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPage2.Enter
        If TabControl1.SelectedTab Is TabPage2 Then
            With Me
                .Width = 718
                .Height = 294
            End With
        End If
    End Sub

    Private Sub TabPage3_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPage3.Enter
        If TabControl1.SelectedTab Is TabPage3 Then
            With Me
                .Width = 721
                .Height = 303
            End With
        End If
    End Sub

    'Код, относящийся к первой вкладке (Персонал)
    Private Sub cmdCalculateWage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCalculateWage.Click
        txtWage.Text = Val(txtSalary.Text) / Val(txtNumbWorkDay.Text) * Val(txtNumbDaysWorked.Text)
        txtWage.Text = Val(txtWage.Text) - (Val(txtWage.Text) * 0.13)
    End Sub

    Private Sub cmdCalculateSDZ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCalculateSDZ.Click
        txtSDZ.Text = Val(txtWage.Text) / Val(txtNumbWorkDay.Text)
    End Sub

    Private Sub cmdCalculateHolidayPay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCalculateHolidayPay.Click
        txtHolidayPay.Text = Val(txtSDZ.Text) * Val(txtNumbDaysWorked.Text)
    End Sub

    Private Sub cmdBackStaff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBackStaff.Click
        frmMain.Show()
        Me.Close()
    End Sub

    'Код, относящийся ко второй вкладке (Комм. услуги)
    Private Sub cmdCalculateGas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCalculateGas.Click
        txtRashGas.Text = Val(txtPotrGas.Text) * Val(txtTarifGas.Text)
    End Sub

    Private Sub cmdCalculateWater_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCalculateWater.Click
        txtRashWater.Text = Val(txtPotrWater.Text) * Val(txtTarifWater.Text)
    End Sub

    Private Sub cmdCalculateElectricity_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCalculateElectricity.Click
        txtRashElec.Text = Val(txtPotrElec.Text) * Val(txtTarifElec.Text)
    End Sub

    Private Sub cmdBackMS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBackMS.Click
        frmMain.Show()
        Me.Close()
    End Sub

    'Код, относящийся к третьей вкладке (Прибыль)
    Private Sub cmdCalculateSugar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCalculateSugar.Click
        txtIncomeSugar.Text = Val(txtNumberSugar.Text) * Val(txtPriceSugar.Text)
    End Sub

    Private Sub cmdCalculatePulp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCalculatePulp.Click
        txtIncomePulp.Text = Val(txtNumberPulp.Text) * Val(txtPricePulp.Text)
    End Sub

    Private Sub cmdCalculateMolasses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCalculateMolasses.Click
        txtIncomeMolasses.Text = Val(txtNumberMolasses.Text) * Val(txtPriceMolasses.Text)
    End Sub

    Private Sub cmdBackIncome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBackIncome.Click
        frmMain.Show()
        Me.Close()
    End Sub

    Private Sub frmBookkeeping_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "BookkeepingDatabaseDataSet.Персонал". При необходимости она может быть перемещена или удалена.
        Me.ПерсоналTableAdapter.Fill(Me.BookkeepingDatabaseDataSet.Персонал)

    End Sub

    Private Sub cmdDatabaseHolidayPay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDatabaseHolidayPay.Click
        ПерсоналBindingSource.EndEdit()
        ПерсоналTableAdapter.Update(BookkeepingDatabaseDataSet.Персонал)
        MessageBox.Show("All good!")
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        ПерсоналBindingSource.AddNew()
    End Sub

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        ПерсоналBindingSource.RemoveCurrent()
    End Sub
End Class