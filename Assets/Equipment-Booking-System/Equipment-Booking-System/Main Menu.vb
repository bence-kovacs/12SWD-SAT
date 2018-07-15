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

        'Bind the reserve category combo box with its relevant values
        With CmboBxReserveCategory
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

    Private Sub CmboBxReserveEquipment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmboBxReserveCategory.SelectedIndexChanged

        'Determine the relevent table as a viewable table
        Dim dtvEquipment As DataView = EquipmentData.Tables("Equipment").DefaultView
        dtvEquipment.RowFilter = "IDParent =" + CmboBxReserveCategory.SelectedValue.ToString

        'Bind the equipment selection category with its relevent values from the table
        With CmboBxReserveEquipment
            .DisplayMember = "Description"
            .ValueMember = "ID"
            .DataSource = dtvEquipment
        End With

    End Sub

    Private Sub btnConfirmReservation_Click(sender As Object, e As EventArgs) Handles btnConfirmReservation.Click
        Record_Viewer.LoanRecordsTableAdapter.Insert(Me.txtUsername.Text, Me.CmboBxReserveEquipment.Text, Me.DteTmeReserve.Text.ToString, Me.DteTmeReserveReturn.Text.ToString)
        Record_Viewer.LoanRecordsTableAdapter.Fill(Record_Viewer.LoanRecordsDataSet.LoanRecords)
        MsgBox("Record Added Successfully")
    End Sub

    'Private Sub LstDescription_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstDescription.SelectedIndexChanged

    '    Dim dtvdescription As DataView = EquipmentData.Tables("Description").DefaultView
    '    dtvdescription.RowFilter = "IDSelection =" + LstDescription.SelectedValue.ToString

    '    With LstDescription
    '        .DisplayMember = "Description"
    '        .ValueMember = "ID"
    '        .DataSource = dtvdescription
    '    End With
    'End Sub
End Class
