Public Class Record_Viewer
    Private Sub Record_Viewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load data into table
        Me.LoanRecordsTableAdapter.Fill(Me.LoanRecordsDataSet.LoanRecords)
    End Sub
    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        'Search function
        Me.LoanRecordsBindingSource.Filter = "[Equipment] = '" & Me.txtFind.Text & " ' "
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'Saves entries
        Me.Validate()
        Me.LoanRecordsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LoanRecordsDataSet)
        MsgBox("Record Details Saved Successfully")
    End Sub
End Class