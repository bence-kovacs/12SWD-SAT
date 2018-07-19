Imports System.Data
Imports System.Data.SqlClient
Public Class frmMainMenu

    'Set out equipment data as a new dataset
    Private EquipmentData As DataSet

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ''Load data
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

        'Fill text usernames on both loan and reserve tabs with username input from login screen

        txtLoanName.Text = Username
        txtReserveName.Text = Username
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
        'Insert information held in reserve fields to the database and show confirmation message
        Record_Viewer.LoanRecordsTableAdapter.Insert(Me.txtReserveName.Text, Me.CmboBxReserveEquipment.Text, Me.DteTmeReserve.Text.ToString, Me.DteTmeReserveReturn.Text.ToString)
        Record_Viewer.LoanRecordsTableAdapter.Fill(Record_Viewer.LoanRecordsDataSet.LoanRecords)

        'Save the database with new addition
        Me.Validate()
        Me.LoanRecordsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LoanRecordsDataSet)
        MsgBox("Reservation Added Successfully")

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnViewRecords.Click
        'Button to show the record viewer
        Record_Viewer.Show()
    End Sub
    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        'Log out button which closes everything
        Me.Close()
        Record_Viewer.Close()
        frmLogin.Close()
    End Sub

    Private Sub btnConfirmLoan_Click(sender As Object, e As EventArgs) Handles btnConfirmLoan.Click
        'Insert information from loan tab into the database and show confirmation message
        Record_Viewer.LoanRecordsTableAdapter.Insert(Me.txtLoanName.Text, Me.CmboBxLoanEquipment.Text, Me.DteTmeLoan.Text.ToString, Me.DteTmeLoanReturn.Text.ToString)
        Record_Viewer.LoanRecordsTableAdapter.Fill(Record_Viewer.LoanRecordsDataSet.LoanRecords)

        'Save database with new addtion
        Me.Validate()
        Me.LoanRecordsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LoanRecordsDataSet)
        MsgBox("Loan Added Successfully")
    End Sub

    Private Sub DteTmeLoanReturn_ValueChanged(sender As Object, e As EventArgs) Handles DteTmeLoanReturn.ValueChanged

        'Calculate length of loan with algorithm
        Dim LoanDate As Date
        Dim LoanReturndate As Date
        Dim LoanDifference As TimeSpan
        loandate = Convert.ToDateTime(DteTmeLoan.Value)
        LoanReturndate = Convert.ToDateTime(DteTmeLoanReturn.Value)
        LoanDifference = LoanReturndate - LoanDate
        txtLoanLength.Text = FormatNumber(LoanDifference.TotalDays, 0) & " DAYS"

    End Sub

    Private Sub DteTmeReserveReturn_ValueChanged(sender As Object, e As EventArgs) Handles DteTmeReserveReturn.ValueChanged

        'Calculate length of reservation with algorithm
        Dim ReservationDate As Date
        Dim ReservationReturnDate As Date
        Dim ReservationDifference As TimeSpan
        ReservationDate = Convert.ToDateTime(DteTmeReserve.Value)
        ReservationReturnDate = Convert.ToDateTime(DteTmeReserveReturn.Value)
        ReservationDifference = ReservationReturnDate - ReservationDate
        txtReservationLength.Text = FormatNumber(ReservationDifference.TotalDays, 0) & " DAYS"

    End Sub
End Class
