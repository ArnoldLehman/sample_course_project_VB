Imports System.Data.OleDb
Imports System.Data

Public Class frmBuyers
    Dim dbsource As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\BuyersDatabase.mdb"
    Dim conn = New OleDbConnection(dbsource)

    Private Sub frmBuyers_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frmMain.Show()
    End Sub

    Private Sub frmBuyers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "BuyersDatabaseDataSet.Buyers". При необходимости она может быть перемещена или удалена.
        Me.BuyersTableAdapter.Fill(Me.BuyersDatabaseDataSet.Buyers)

    End Sub

    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        Try
            If txtSearch.Text = "" Then
                Exit Sub
            Else
                Dim cantFine As String = txtSearch.Text
                BuyersBindingSource.Filter = "(Наименование_организации LIKE '" & txtSearch.Text & "') OR (Имя_заказчика LIKE '" & txtSearch.Text & "')" & _
                "OR (Наименование_товара LIKE '" & txtSearch.Text & "')"

                If BuyersBindingSource.Count <> 0 Then
                    With dgvBuyers
                        .DataSource = BuyersBindingSource
                    End With
                Else
                    MsgBox("Элемент " & cantFine & " не найден", MsgBoxStyle.Information, "Поиск")
                    BuyersBindingSource.Filter = Nothing
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cmdAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddNew.Click
        BuyersBindingSource.AddNew()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        BuyersBindingSource.EndEdit()
        BuyersTableAdapter.Update(BuyersDatabaseDataSet.Buyers)
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        BuyersBindingSource.RemoveCurrent()
    End Sub

    Private Sub lblMain_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblMain.MouseEnter
        msHoverTitle(lblMain)
    End Sub

    Private Sub lblMain_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblMain.MouseLeave
        msLeaveTitle(lblMain)
    End Sub

    Private Sub lblMain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblMain.Click
        frmMain.Show()
        Me.Close()
    End Sub

    Private Sub txtNameOfCustomer_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNameOfCustomer.Leave
        If checksNumber(txtNameOfCustomer) = True Then
            MessageBox.Show("Некорректный ввод данных", "Ввод", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNameOfCustomer.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub txtNameOfProduct_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNameOfProduct.Leave
        If checksNumber(txtNameOfProduct) = True Then
            MessageBox.Show("Некорректный ввод данных", "Ввод", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNameOfProduct.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub txtNumberProduct_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNumberProduct.Leave
        If checksWord(txtNumberProduct) = True Then
            MessageBox.Show("Некорректный ввод данных", "Ввод", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNumberProduct.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub txtPayment_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPayment.Leave
        If checksWord(txtPayment) = True Then
            MessageBox.Show("Некорректный ввод данных", "Ввод", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPayment.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub lblReset_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblReset.Click
        Try
            txtSearch.Clear()
            BuyersBindingSource.Filter = Nothing

            With dgvBuyers
                .ClearSelection()
                .ReadOnly = True
                .MultiSelect = False
                .DataSource = BuyersBindingSource
            End With
        Catch ex As Exception

        End Try
    End Sub
End Class