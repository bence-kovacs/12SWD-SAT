Public Class Record_Viewer
    Private Sub LoanRecordsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.LoanRecordsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LoanRecordsDataSet)

    End Sub

    Private Sub Record_Viewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LoanRecordsDataSet.LoanRecords' table. You can move, or remove it, as needed.
        Me.LoanRecordsTableAdapter.Fill(Me.LoanRecordsDataSet.LoanRecords)

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        Me.LoanRecordsBindingSource.Filter = "[Equipment] = '" & Me.txtFind.Text & " ' "
    End Sub
End Class