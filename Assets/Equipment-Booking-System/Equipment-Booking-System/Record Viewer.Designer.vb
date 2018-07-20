<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Record_Viewer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim lblID As System.Windows.Forms.Label
        Dim lblUser As System.Windows.Forms.Label
        Dim lblEquipment As System.Windows.Forms.Label
        Dim lblLoanDate As System.Windows.Forms.Label
        Dim lblReturnDate As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Record_Viewer))
        Me.LoanRecordsDataSet = New Equipment_Booking_System.LoanRecordsDataSet()
        Me.LoanRecordsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LoanRecordsTableAdapter = New Equipment_Booking_System.LoanRecordsDataSetTableAdapters.LoanRecordsTableAdapter()
        Me.TableAdapterManager = New Equipment_Booking_System.LoanRecordsDataSetTableAdapters.TableAdapterManager()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtEquipment = New System.Windows.Forms.TextBox()
        Me.txtLoanDate = New System.Windows.Forms.TextBox()
        Me.txtReturnDate = New System.Windows.Forms.TextBox()
        Me.lstbxRecordViewer = New System.Windows.Forms.ListBox()
        Me.lblDetails = New System.Windows.Forms.Label()
        Me.lblLoans = New System.Windows.Forms.Label()
        Me.txtFind = New System.Windows.Forms.TextBox()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.lblSearchTitle = New System.Windows.Forms.Label()
        Me.lblViewAllRecordsTitle = New System.Windows.Forms.Label()
        lblID = New System.Windows.Forms.Label()
        lblUser = New System.Windows.Forms.Label()
        lblEquipment = New System.Windows.Forms.Label()
        lblLoanDate = New System.Windows.Forms.Label()
        lblReturnDate = New System.Windows.Forms.Label()
        CType(Me.LoanRecordsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoanRecordsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblID
        '
        lblID.AutoSize = True
        lblID.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblID.Location = New System.Drawing.Point(43, 99)
        lblID.Name = "lblID"
        lblID.Size = New System.Drawing.Size(28, 21)
        lblID.TabIndex = 1
        lblID.Text = "ID:"
        '
        'lblUser
        '
        lblUser.AutoSize = True
        lblUser.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblUser.Location = New System.Drawing.Point(43, 134)
        lblUser.Name = "lblUser"
        lblUser.Size = New System.Drawing.Size(45, 21)
        lblUser.TabIndex = 3
        lblUser.Text = "User:"
        '
        'lblEquipment
        '
        lblEquipment.AutoSize = True
        lblEquipment.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblEquipment.Location = New System.Drawing.Point(43, 169)
        lblEquipment.Name = "lblEquipment"
        lblEquipment.Size = New System.Drawing.Size(88, 21)
        lblEquipment.TabIndex = 5
        lblEquipment.Text = "Equipment:"
        '
        'lblLoanDate
        '
        lblLoanDate.AutoSize = True
        lblLoanDate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblLoanDate.Location = New System.Drawing.Point(43, 204)
        lblLoanDate.Name = "lblLoanDate"
        lblLoanDate.Size = New System.Drawing.Size(83, 21)
        lblLoanDate.TabIndex = 7
        lblLoanDate.Text = "Loan Date:"
        '
        'lblReturnDate
        '
        lblReturnDate.AutoSize = True
        lblReturnDate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblReturnDate.Location = New System.Drawing.Point(43, 239)
        lblReturnDate.Name = "lblReturnDate"
        lblReturnDate.Size = New System.Drawing.Size(96, 21)
        lblReturnDate.TabIndex = 9
        lblReturnDate.Text = "Return Date:"
        '
        'LoanRecordsDataSet
        '
        Me.LoanRecordsDataSet.DataSetName = "LoanRecordsDataSet"
        Me.LoanRecordsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LoanRecordsBindingSource
        '
        Me.LoanRecordsBindingSource.DataMember = "LoanRecords"
        Me.LoanRecordsBindingSource.DataSource = Me.LoanRecordsDataSet
        '
        'LoanRecordsTableAdapter
        '
        Me.LoanRecordsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.LoanRecordsTableAdapter = Me.LoanRecordsTableAdapter
        Me.TableAdapterManager.UpdateOrder = Equipment_Booking_System.LoanRecordsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'txtID
        '
        Me.txtID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LoanRecordsBindingSource, "ID", True))
        Me.txtID.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(145, 96)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(208, 29)
        Me.txtID.TabIndex = 2
        '
        'txtUser
        '
        Me.txtUser.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LoanRecordsBindingSource, "User", True))
        Me.txtUser.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUser.Location = New System.Drawing.Point(145, 131)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.ReadOnly = True
        Me.txtUser.Size = New System.Drawing.Size(208, 29)
        Me.txtUser.TabIndex = 4
        '
        'txtEquipment
        '
        Me.txtEquipment.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LoanRecordsBindingSource, "Equipment", True))
        Me.txtEquipment.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEquipment.Location = New System.Drawing.Point(145, 166)
        Me.txtEquipment.Name = "txtEquipment"
        Me.txtEquipment.ReadOnly = True
        Me.txtEquipment.Size = New System.Drawing.Size(208, 29)
        Me.txtEquipment.TabIndex = 6
        '
        'txtLoanDate
        '
        Me.txtLoanDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LoanRecordsBindingSource, "Loan Date", True))
        Me.txtLoanDate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoanDate.Location = New System.Drawing.Point(145, 201)
        Me.txtLoanDate.Name = "txtLoanDate"
        Me.txtLoanDate.ReadOnly = True
        Me.txtLoanDate.Size = New System.Drawing.Size(208, 29)
        Me.txtLoanDate.TabIndex = 8
        '
        'txtReturnDate
        '
        Me.txtReturnDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LoanRecordsBindingSource, "Return Date", True))
        Me.txtReturnDate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReturnDate.Location = New System.Drawing.Point(145, 236)
        Me.txtReturnDate.Name = "txtReturnDate"
        Me.txtReturnDate.ReadOnly = True
        Me.txtReturnDate.Size = New System.Drawing.Size(208, 29)
        Me.txtReturnDate.TabIndex = 10
        '
        'lstbxRecordViewer
        '
        Me.lstbxRecordViewer.DataSource = Me.LoanRecordsBindingSource
        Me.lstbxRecordViewer.DisplayMember = "User"
        Me.lstbxRecordViewer.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstbxRecordViewer.FormattingEnabled = True
        Me.lstbxRecordViewer.ItemHeight = 21
        Me.lstbxRecordViewer.Location = New System.Drawing.Point(483, 96)
        Me.lstbxRecordViewer.Name = "lstbxRecordViewer"
        Me.lstbxRecordViewer.Size = New System.Drawing.Size(214, 172)
        Me.lstbxRecordViewer.TabIndex = 12
        '
        'lblDetails
        '
        Me.lblDetails.AutoSize = True
        Me.lblDetails.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDetails.Location = New System.Drawing.Point(96, 27)
        Me.lblDetails.Name = "lblDetails"
        Me.lblDetails.Size = New System.Drawing.Size(106, 37)
        Me.lblDetails.TabIndex = 13
        Me.lblDetails.Text = "Details"
        '
        'lblLoans
        '
        Me.lblLoans.AutoSize = True
        Me.lblLoans.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoans.Location = New System.Drawing.Point(539, 20)
        Me.lblLoans.Name = "lblLoans"
        Me.lblLoans.Size = New System.Drawing.Size(91, 37)
        Me.lblLoans.TabIndex = 14
        Me.lblLoans.Text = "Loans"
        '
        'txtFind
        '
        Me.txtFind.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFind.Location = New System.Drawing.Point(493, 320)
        Me.txtFind.Name = "txtFind"
        Me.txtFind.Size = New System.Drawing.Size(187, 26)
        Me.txtFind.TabIndex = 15
        '
        'btnFind
        '
        Me.btnFind.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFind.Location = New System.Drawing.Point(702, 314)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(75, 36)
        Me.btnFind.TabIndex = 16
        Me.btnFind.Text = "Search"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'lblSearchTitle
        '
        Me.lblSearchTitle.AutoSize = True
        Me.lblSearchTitle.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchTitle.Location = New System.Drawing.Point(467, 286)
        Me.lblSearchTitle.Name = "lblSearchTitle"
        Me.lblSearchTitle.Size = New System.Drawing.Size(257, 25)
        Me.lblSearchTitle.TabIndex = 17
        Me.lblSearchTitle.Text = "Search by Equipment Name"
        '
        'lblViewAllRecordsTitle
        '
        Me.lblViewAllRecordsTitle.AutoSize = True
        Me.lblViewAllRecordsTitle.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblViewAllRecordsTitle.Location = New System.Drawing.Point(512, 57)
        Me.lblViewAllRecordsTitle.Name = "lblViewAllRecordsTitle"
        Me.lblViewAllRecordsTitle.Size = New System.Drawing.Size(159, 25)
        Me.lblViewAllRecordsTitle.TabIndex = 18
        Me.lblViewAllRecordsTitle.Text = "View All Records"
        '
        'Record_Viewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(789, 382)
        Me.Controls.Add(Me.lblViewAllRecordsTitle)
        Me.Controls.Add(Me.lblSearchTitle)
        Me.Controls.Add(Me.btnFind)
        Me.Controls.Add(Me.txtFind)
        Me.Controls.Add(Me.lblLoans)
        Me.Controls.Add(Me.lblDetails)
        Me.Controls.Add(Me.lstbxRecordViewer)
        Me.Controls.Add(lblID)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(lblUser)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(lblEquipment)
        Me.Controls.Add(Me.txtEquipment)
        Me.Controls.Add(lblLoanDate)
        Me.Controls.Add(Me.txtLoanDate)
        Me.Controls.Add(lblReturnDate)
        Me.Controls.Add(Me.txtReturnDate)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Record_Viewer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Equipment Booker: Records"
        CType(Me.LoanRecordsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoanRecordsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LoanRecordsDataSet As LoanRecordsDataSet
    Friend WithEvents LoanRecordsBindingSource As BindingSource
    Friend WithEvents LoanRecordsTableAdapter As LoanRecordsDataSetTableAdapters.LoanRecordsTableAdapter
    Friend WithEvents TableAdapterManager As LoanRecordsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtEquipment As TextBox
    Friend WithEvents txtLoanDate As TextBox
    Friend WithEvents txtReturnDate As TextBox
    Friend WithEvents lstbxRecordViewer As ListBox
    Friend WithEvents lblDetails As Label
    Friend WithEvents lblLoans As Label
    Friend WithEvents txtFind As TextBox
    Friend WithEvents btnFind As Button
    Friend WithEvents lblSearchTitle As Label
    Friend WithEvents lblViewAllRecordsTitle As Label
End Class
