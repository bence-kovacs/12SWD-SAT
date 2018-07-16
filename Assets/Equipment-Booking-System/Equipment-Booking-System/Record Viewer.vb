Public Class Record_Viewer
    'Private Sub LoanRecordsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
    '    Me.Validate()
    '    Me.LoanRecordsBindingSource.EndEdit()
    '    Me.TableAdapterManager.UpdateAll(Me.LoanRecordsDataSet)

    'End Sub

    Private Sub Record_Viewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LoanRecordsDataSet.LoanRecords' table. You can move, or remove it, as needed.
        'Me.LoanRecordsTableAdapter.Fill(Me.LoanRecordsDataSet.LoanRecords)

    End Sub

    'Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
    '    Me.LoanRecordsBindingSource.Filter = "[Equipment] = '" & Me.txtFind.Text & " ' "
    'End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Me.Validate()
        Me.LoanRecordsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LoanRecordsDataSet)
        MsgBox("Record Details Saved Successfully")
    End Sub
End Class