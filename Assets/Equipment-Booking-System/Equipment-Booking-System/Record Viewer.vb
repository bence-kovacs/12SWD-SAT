Public Class Record_Viewer
    Private Sub LoanRecordsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles LoanRecordsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.LoanRecordsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LoanRecordsDataSet)

    End Sub

    Private Sub Record_Viewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LoanRecordsDataSet.LoanRecords' table. You can move, or remove it, as needed.
        Me.LoanRecordsTableAdapter.Fill(Me.LoanRecordsDataSet.LoanRecords)

    End Sub
End Class