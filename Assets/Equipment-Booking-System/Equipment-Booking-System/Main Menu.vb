Imports System.Data
Imports System.Data.SqlClient
Public Class frmMainMenu

    'Set out equipment data as a new dataset
    Private EquipmentData As DataSet

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Load data
        EquipmentData = EquipmentInventory.CreateDataSet()

        'Bind the loan category combo box with its relevant values
        With CmboBxLoanCategory
            .DisplayMember = "Description"
            .ValueMember = "ID"
            .DataSource = EquipmentData.Tables("Categories")
        End With
    End Sub

    Private Sub CmboBxLoanCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmboBxLoanCategory.SelectedIndexChanged

        'Determine the relevent table as a viewable table
        Dim dtvEquipment As DataView = EquipmentData.Tables("Equipment").DefaultView
        dtvEquipment.RowFilter = "IDParent =" + CmboBxLoanCategory.SelectedValue.ToString

        'Bind the equipment selection category with its relevent values from the table
        With CmboBxLoanEquipment
            .DisplayMember = "Description"
            .ValueMember = "ID"
            .DataSource = dtvEquipment
        End With
    End Sub

End Class
