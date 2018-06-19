Imports System.Data.SqlClient
Public Class frmMainMenu


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EquipmentInventoryDataSet._EquipmentAudio__' table. You can move, or remove it, as needed.
        Me.EquipmentAudio__TableAdapter.Fill(Me.EquipmentInventoryDataSet._EquipmentAudio__)

        '/////////////////////////////LOAN TAB////////////////////////////////////////////////

        'Populate 'Category box' under 'loan' tab with SQL Query
        Try
            Me.EquipmentCategoryTableAdapter.FillCategories(Me.EquipmentInventoryDataSet.EquipmentCategory)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub CmboBxLoanCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmboBxLoanCategory.SelectedIndexChanged

    End Sub
End Class
