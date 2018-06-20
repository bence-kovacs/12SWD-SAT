Imports System.Data.SqlClient
Public Class frmMainMenu


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EquipmentInventoryDataSet.EquipmentVideo' table. You can move, or remove it, as needed.
        Me.EquipmentVideoTableAdapter.Fill(Me.EquipmentInventoryDataSet.EquipmentVideo)
        'TODO: This line of code loads data into the 'EquipmentInventoryDataSet._EquipmentAudio__' table. You can move, or remove it, as needed.
        Me.EquipmentAudio__TableAdapter.Fill(Me.EquipmentInventoryDataSet._EquipmentAudio__)

        '/////////////////////////////LOAN TAB////////////////////////////////////////////////

        'Populate 'Category box' under 'loan' tab with SQL Query
        'Try
        '    Me.EquipmentCategoryTableAdapter.FillCategories(Me.EquipmentInventoryDataSet.EquipmentCategory)
        'Catch ex As System.Exception
        '    System.Windows.Forms.MessageBox.Show(ex.Message)
        'End Try
    End Sub

    Private Sub CmboBxLoanCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmboBxLoanCategory.SelectedIndexChanged

        'If CmboBxLoanEquipment.Text = "Audio" Then
        '    Try
        '        Me.EquipmentAudio__TableAdapter.FillAudio(Me.EquipmentInventoryDataSet._EquipmentAudio__)
        '    Catch ex As System.Exception
        '        System.Windows.Forms.MessageBox.Show(ex.Message)
        '    End Try
        'ElseIf CmboBxLoanEquipment.Text = "Video" Then
        '    Try
        '        Me.EquipmentVideoTableAdapter.FillVideoEquipment(Me.EquipmentInventoryDataSet.EquipmentVideo)
        '    Catch ex As System.Exception
        '        System.Windows.Forms.MessageBox.Show(ex.Message)
        '    End Try
        'End If


        '''''TRY 2''''''


        '    Dim SelectedCategory As String
        '    SelectedCategory = CmboBxLoanCategory.Text

        '    If SelectedCategory = "Audio" Then
        '        Try
        '            Me.EquipmentAudio__TableAdapter.FillAudio(Me.EquipmentInventoryDataSet._EquipmentAudio__)
        '        Catch ex As System.Exception
        '            System.Windows.Forms.MessageBox.Show(ex.Message)
        '        End Try
        '    ElseIf SelectedCategory = "Video" Then
        '        Try
        '            Me.EquipmentVideoTableAdapter.FillVideoEquipment(Me.EquipmentInventoryDataSet.EquipmentVideo)
        '        Catch ex As System.Exception
        '            System.Windows.Forms.MessageBox.Show(ex.Message)
        '        End Try
        '    End If

        ''''''''''TRY 3'''''''''
        '''

        'Select Case CmboBxLoanCategory.SelectedIndex
        '    Case "0"
        '        'Try
        '        Me.EquipmentAudio__TableAdapter.FillAudio(Me.EquipmentInventoryDataSet._EquipmentAudio__)
        '        'Catch ex As System.Exception
        '        '    System.Windows.Forms.MessageBox.Show(ex.Message)
        '        'End Try
        '    Case "1"
        '        'Try
        '        Me.EquipmentVideoTableAdapter.FillVideoEquipment(Me.EquipmentInventoryDataSet.EquipmentVideo)
        '        'Catch ex As System.Exception
        '        '    System.Windows.Forms.MessageBox.Show(ex.Message)
        '        'End Try
        'End Select

        Select Case CmboBxLoanCategory.SelectedIndex
            Case "0"
                Me.CmboBxLoanEquipment. = Me.EquipmentAudio__TableAdapter.FillAudio(Me.EquipmentInventoryDataSet._EquipmentAudio__)
            Case "1"
                Me.CmboBxLoanEquipment.Items = Me.EquipmentVideoTableAdapter.FillVideoEquipment(Me.EquipmentInventoryDataSet.EquipmentVideo)
        End Select
    End Sub

End Class
