Imports System.Data.OleDb
Imports System.Data

Public Class frmStorage

    Private Sub frmStorage_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frmTest.Show()
    End Sub

    Private Sub frmStorage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "StorageDatabaseDataSet.Storage". При необходимости она может быть перемещена или удалена.
        Me.StorageTableAdapter.Fill(Me.StorageDatabaseDataSet.Storage)
    End Sub

    Private Sub cmdAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddNew.Click
        StorageBindingSource.AddNew()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        StorageBindingSource.EndEdit()
        StorageTableAdapter.Update(StorageDatabaseDataSet.Storage)
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        StorageBindingSource.RemoveCurrent()
        StorageTableAdapter.Update(StorageDatabaseDataSet.Storage)
    End Sub

    Private Sub cmdUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdate.Click
        Dim dbsource As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\StorageDatabase.mdb"
        Dim conn = New OleDbConnection(dbsource)

        Try
            conn.Open()
            Dim str As String = "UPDATE Storage SET Назначение=?, Количество=? where Виды=? "
            Dim cmd As New OleDbCommand(str, conn)
            cmd.Parameters.AddWithValue("Назначение", txtAppointment.Text)
            cmd.Parameters.AddWithValue("Количество", txtNumber.Text)
            cmd.Parameters.AddWithValue("Виды", txtType.Text)
            cmd.ExecuteNonQuery()
            MsgBox("Data has been update")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class