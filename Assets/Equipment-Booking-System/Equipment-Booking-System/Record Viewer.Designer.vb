<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Record_Viewer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim IDLabel As System.Windows.Forms.Label
        Dim UserLabel As System.Windows.Forms.Label
        Dim EquipmentLabel As System.Windows.Forms.Label
        Dim Loan_DateLabel As System.Windows.Forms.Label
        Dim Return_DateLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Record_Viewer))
        Me.LoanRecordsDataSet = New Equipment_Booking_System.LoanRecordsDataSet()
        Me.LoanRecordsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LoanRecordsTableAdapter = New Equipment_Booking_System.LoanRecordsDataSetTableAdapters.LoanRecordsTableAdapter()
        Me.TableAdapterManager = New Equipment_Booking_System.LoanRecordsDataSetTableAdapters.TableAdapterManager()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.UserTextBox = New System.Windows.Forms.TextBox()
        Me.EquipmentTextBox = New System.Windows.Forms.TextBox()
        Me.Loan_DateTextBox = New System.Windows.Forms.TextBox()
        Me.Return_DateTextBox = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.lblDetails = New System.Windows.Forms.Label()
        Me.lblLoans = New System.Windows.Forms.Label()
        Me.txtFind = New System.Windows.Forms.TextBox()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        IDLabel = New System.Windows.Forms.Label()
        UserLabel = New System.Windows.Forms.Label()
        EquipmentLabel = New System.Windows.Forms.Label()
        Loan_DateLabel = New System.Windows.Forms.Label()
        Return_DateLabel = New System.Windows.Forms.Label()
        CType(Me.LoanRecordsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoanRecordsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDLabel.Location = New System.Drawing.Point(43, 99)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(28, 21)
        IDLabel.TabIndex = 1
        IDLabel.Text = "ID:"
        '
        'UserLabel
        '
        UserLabel.AutoSize = True
        UserLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        UserLabel.Location = New System.Drawing.Point(43, 134)
        UserLabel.Name = "UserLabel"
        UserLabel.Size = New System.Drawing.Size(45, 21)
        UserLabel.TabIndex = 3
        UserLabel.Text = "User:"
        '
        'EquipmentLabel
        '
        EquipmentLabel.AutoSize = True
        EquipmentLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EquipmentLabel.Location = New System.Drawing.Point(43, 169)
        EquipmentLabel.Name = "EquipmentLabel"
        EquipmentLabel.Size = New System.Drawing.Size(88, 21)
        EquipmentLabel.TabIndex = 5
        EquipmentLabel.Text = "Equipment:"
        '
        'Loan_DateLabel
        '
        Loan_DateLabel.AutoSize = True
        Loan_DateLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Loan_DateLabel.Location = New System.Drawing.Point(43, 204)
        Loan_DateLabel.Name = "Loan_DateLabel"
        Loan_DateLabel.Size = New System.Drawing.Size(83, 21)
        Loan_DateLabel.TabIndex = 7
        Loan_DateLabel.Text = "Loan Date:"
        '
        'Return_DateLabel
        '
        Return_DateLabel.AutoSize = True
        Return_DateLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Return_DateLabel.Location = New System.Drawing.Point(43, 239)
        Return_DateLabel.Name = "Return_DateLabel"
        Return_DateLabel.Size = New System.Drawing.Size(96, 21)
        Return_DateLabel.TabIndex = 9
        Return_DateLabel.Text = "Return Date:"
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
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LoanRecordsBindingSource, "ID", True))
        Me.IDTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDTextBox.Location = New System.Drawing.Point(145, 96)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.ReadOnly = True
        Me.IDTextBox.Size = New System.Drawing.Size(208, 29)
        Me.IDTextBox.TabIndex = 2
        '
        'UserTextBox
        '
        Me.UserTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LoanRecordsBindingSource, "User", True))
        Me.UserTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserTextBox.Location = New System.Drawing.Point(145, 131)
        Me.UserTextBox.Name = "UserTextBox"
        Me.UserTextBox.ReadOnly = True
        Me.UserTextBox.Size = New System.Drawing.Size(208, 29)
        Me.UserTextBox.TabIndex = 4
        '
        'EquipmentTextBox
        '
        Me.EquipmentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LoanRecordsBindingSource, "Equipment", True))
        Me.EquipmentTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EquipmentTextBox.Location = New System.Drawing.Point(145, 166)
        Me.EquipmentTextBox.Name = "EquipmentTextBox"
        Me.EquipmentTextBox.ReadOnly = True
        Me.EquipmentTextBox.Size = New System.Drawing.Size(208, 29)
        Me.EquipmentTextBox.TabIndex = 6
        '
        'Loan_DateTextBox
        '
        Me.Loan_DateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LoanRecordsBindingSource, "Loan Date", True))
        Me.Loan_DateTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Loan_DateTextBox.Location = New System.Drawing.Point(145, 201)
        Me.Loan_DateTextBox.Name = "Loan_DateTextBox"
        Me.Loan_DateTextBox.ReadOnly = True
        Me.Loan_DateTextBox.Size = New System.Drawing.Size(208, 29)
        Me.Loan_DateTextBox.TabIndex = 8
        '
        'Return_DateTextBox
        '
        Me.Return_DateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LoanRecordsBindingSource, "Return Date", True))
        Me.Return_DateTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Return_DateTextBox.Location = New System.Drawing.Point(145, 236)
        Me.Return_DateTextBox.Name = "Return_DateTextBox"
        Me.Return_DateTextBox.ReadOnly = True
        Me.Return_DateTextBox.Size = New System.Drawing.Size(208, 29)
        Me.Return_DateTextBox.TabIndex = 10
        '
        'ListBox1
        '
        Me.ListBox1.DataSource = Me.LoanRecordsBindingSource
        Me.ListBox1.DisplayMember = "User"
        Me.ListBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 21
        Me.ListBox1.Location = New System.Drawing.Point(483, 96)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(214, 172)
        Me.ListBox1.TabIndex = 12
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(467, 286)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(257, 25)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Search by Equipment Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(512, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 25)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "View All Records"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(166, 314)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 19
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Record_Viewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(789, 382)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnFind)
        Me.Controls.Add(Me.txtFind)
        Me.Controls.Add(Me.lblLoans)
        Me.Controls.Add(Me.lblDetails)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(UserLabel)
        Me.Controls.Add(Me.UserTextBox)
        Me.Controls.Add(EquipmentLabel)
        Me.Controls.Add(Me.EquipmentTextBox)
        Me.Controls.Add(Loan_DateLabel)
        Me.Controls.Add(Me.Loan_DateTextBox)
        Me.Controls.Add(Return_DateLabel)
        Me.Controls.Add(Me.Return_DateTextBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Record_Viewer"
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
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents UserTextBox As TextBox
    Friend WithEvents EquipmentTextBox As TextBox
    Friend WithEvents Loan_DateTextBox As TextBox
    Friend WithEvents Return_DateTextBox As TextBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents lblDetails As Label
    Friend WithEvents lblLoans As Label
    Friend WithEvents txtFind As TextBox
    Friend WithEvents btnFind As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSave As Button
End Class
