Imports System.Data.SqlClient
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMainMenu
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.btnViewRecords = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.CmboBxReserveEquipment = New System.Windows.Forms.ComboBox()
        Me.CmboBxReserveCategory = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DteTmeReserveReturn = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnConfirmReservation = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DteTmeReserve = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TabLoan = New System.Windows.Forms.TabPage()
        Me.lblLoanEquipmentInfo = New System.Windows.Forms.Label()
        Me.lblLoanDetails = New System.Windows.Forms.Label()
        Me.LstDescription = New System.Windows.Forms.ListBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnClearLoan = New System.Windows.Forms.Button()
        Me.btnConfirmLoan = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.CmboBxLoanEquipment = New System.Windows.Forms.ComboBox()
        Me.EquipmentAudioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EquipmentInventoryDataSet = New Equipment_Booking_System.EquipmentInventoryDataSet()
        Me.lblEquipment = New System.Windows.Forms.Label()
        Me.CmboBxLoanCategory = New System.Windows.Forms.ComboBox()
        Me.lblEquipmentCategory = New System.Windows.Forms.Label()
        Me.EquipmentVideoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EquipmentCategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbCntrl = New System.Windows.Forms.TabControl()
        Me.EquipmentCategoryTableAdapter = New Equipment_Booking_System.EquipmentInventoryDataSetTableAdapters.EquipmentCategoryTableAdapter()
        Me.EquipmentAudio__TableAdapter = New Equipment_Booking_System.EquipmentInventoryDataSetTableAdapters.EquipmentAudio__TableAdapter()
        Me.EquipmentVideoTableAdapter = New Equipment_Booking_System.EquipmentInventoryDataSetTableAdapters.EquipmentVideoTableAdapter()
        Me.EquipmentInventoryDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EquipmentAudioBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.LoanRecordsDataSet = New Equipment_Booking_System.LoanRecordsDataSet()
        Me.LoanRecordsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LoanRecordsTableAdapter = New Equipment_Booking_System.LoanRecordsDataSetTableAdapters.LoanRecordsTableAdapter()
        Me.TableAdapterManager = New Equipment_Booking_System.LoanRecordsDataSetTableAdapters.TableAdapterManager()
        Me.TabPage3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabLoan.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EquipmentAudioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EquipmentInventoryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EquipmentVideoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EquipmentCategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TbCntrl.SuspendLayout()
        CType(Me.EquipmentInventoryDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EquipmentAudioBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoanRecordsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoanRecordsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(144, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(509, 37)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "MEDIA EQUIPMENT BOOKING SYSTEM"
        '
        'btnLogOut
        '
        Me.btnLogOut.Location = New System.Drawing.Point(679, 22)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(75, 23)
        Me.btnLogOut.TabIndex = 3
        Me.btnLogOut.Text = "LOG OUT"
        Me.btnLogOut.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.AutoScroll = True
        Me.TabPage3.Controls.Add(Me.btnViewRecords)
        Me.TabPage3.Controls.Add(Me.Label8)
        Me.TabPage3.Location = New System.Drawing.Point(4, 40)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage3.Size = New System.Drawing.Size(775, 483)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "                       View                       "
        '
        'btnViewRecords
        '
        Me.btnViewRecords.Location = New System.Drawing.Point(328, 204)
        Me.btnViewRecords.Name = "btnViewRecords"
        Me.btnViewRecords.Size = New System.Drawing.Size(75, 50)
        Me.btnViewRecords.TabIndex = 24
        Me.btnViewRecords.Text = "View Records"
        Me.btnViewRecords.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(288, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(154, 37)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "MY LOANS"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txtUsername)
        Me.TabPage2.Controls.Add(Me.CmboBxReserveEquipment)
        Me.TabPage2.Controls.Add(Me.CmboBxReserveCategory)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.DteTmeReserveReturn)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.ListBox2)
        Me.TabPage2.Controls.Add(Me.PictureBox2)
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.btnConfirmReservation)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.DteTmeReserve)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Location = New System.Drawing.Point(4, 40)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage2.Size = New System.Drawing.Size(775, 483)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "                       Reserve                       "
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(249, 110)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(100, 25)
        Me.txtUsername.TabIndex = 28
        '
        'CmboBxReserveEquipment
        '
        Me.CmboBxReserveEquipment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmboBxReserveEquipment.FormattingEnabled = True
        Me.CmboBxReserveEquipment.Items.AddRange(New Object() {"Video", "Audio"})
        Me.CmboBxReserveEquipment.Location = New System.Drawing.Point(51, 199)
        Me.CmboBxReserveEquipment.Name = "CmboBxReserveEquipment"
        Me.CmboBxReserveEquipment.Size = New System.Drawing.Size(170, 25)
        Me.CmboBxReserveEquipment.TabIndex = 27
        '
        'CmboBxReserveCategory
        '
        Me.CmboBxReserveCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmboBxReserveCategory.FormattingEnabled = True
        Me.CmboBxReserveCategory.Items.AddRange(New Object() {"Video", "Audio"})
        Me.CmboBxReserveCategory.Location = New System.Drawing.Point(51, 110)
        Me.CmboBxReserveCategory.Name = "CmboBxReserveCategory"
        Me.CmboBxReserveCategory.Size = New System.Drawing.Size(170, 25)
        Me.CmboBxReserveCategory.TabIndex = 26
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(102, 318)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(116, 17)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "DATE OF RETURN"
        '
        'DteTmeReserveReturn
        '
        Me.DteTmeReserveReturn.Location = New System.Drawing.Point(51, 352)
        Me.DteTmeReserveReturn.Name = "DteTmeReserveReturn"
        Me.DteTmeReserveReturn.Size = New System.Drawing.Size(236, 25)
        Me.DteTmeReserveReturn.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(340, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(372, 37)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "EQUIPMENT INFORMATION"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(308, 37)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "RESERVATION DETAILS"
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 17
        Me.ListBox2.Location = New System.Drawing.Point(370, 275)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(300, 174)
        Me.ListBox2.TabIndex = 21
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(370, 69)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(300, 200)
        Me.PictureBox2.TabIndex = 20
        Me.PictureBox2.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(178, 402)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 44)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Clear"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnConfirmReservation
        '
        Me.btnConfirmReservation.Location = New System.Drawing.Point(51, 402)
        Me.btnConfirmReservation.Name = "btnConfirmReservation"
        Me.btnConfirmReservation.Size = New System.Drawing.Size(109, 44)
        Me.btnConfirmReservation.TabIndex = 18
        Me.btnConfirmReservation.Text = "Confirm Selection"
        Me.btnConfirmReservation.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(105, 238)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 17)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "DATE OF LOAN"
        '
        'DteTmeReserve
        '
        Me.DteTmeReserve.Location = New System.Drawing.Point(51, 275)
        Me.DteTmeReserve.Name = "DteTmeReserve"
        Me.DteTmeReserve.Size = New System.Drawing.Size(236, 25)
        Me.DteTmeReserve.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(79, 166)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 17)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "EQUIPMENT PIECE"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(65, 75)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(153, 17)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "EQUIPMENT CATEGORY"
        '
        'TabLoan
        '
        Me.TabLoan.BackColor = System.Drawing.Color.Transparent
        Me.TabLoan.Controls.Add(Me.lblLoanEquipmentInfo)
        Me.TabLoan.Controls.Add(Me.lblLoanDetails)
        Me.TabLoan.Controls.Add(Me.LstDescription)
        Me.TabLoan.Controls.Add(Me.PictureBox1)
        Me.TabLoan.Controls.Add(Me.btnClearLoan)
        Me.TabLoan.Controls.Add(Me.btnConfirmLoan)
        Me.TabLoan.Controls.Add(Me.Label1)
        Me.TabLoan.Controls.Add(Me.DateTimePicker1)
        Me.TabLoan.Controls.Add(Me.CmboBxLoanEquipment)
        Me.TabLoan.Controls.Add(Me.lblEquipment)
        Me.TabLoan.Controls.Add(Me.CmboBxLoanCategory)
        Me.TabLoan.Controls.Add(Me.lblEquipmentCategory)
        Me.TabLoan.Location = New System.Drawing.Point(4, 40)
        Me.TabLoan.Margin = New System.Windows.Forms.Padding(2)
        Me.TabLoan.Name = "TabLoan"
        Me.TabLoan.Padding = New System.Windows.Forms.Padding(2)
        Me.TabLoan.Size = New System.Drawing.Size(775, 483)
        Me.TabLoan.TabIndex = 0
        Me.TabLoan.Text = "                       Loan                       "
        '
        'lblLoanEquipmentInfo
        '
        Me.lblLoanEquipmentInfo.AutoSize = True
        Me.lblLoanEquipmentInfo.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoanEquipmentInfo.Location = New System.Drawing.Point(340, 16)
        Me.lblLoanEquipmentInfo.Name = "lblLoanEquipmentInfo"
        Me.lblLoanEquipmentInfo.Size = New System.Drawing.Size(372, 37)
        Me.lblLoanEquipmentInfo.TabIndex = 23
        Me.lblLoanEquipmentInfo.Text = "EQUIPMENT INFORMATION"
        '
        'lblLoanDetails
        '
        Me.lblLoanDetails.AutoSize = True
        Me.lblLoanDetails.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoanDetails.Location = New System.Drawing.Point(34, 16)
        Me.lblLoanDetails.Name = "lblLoanDetails"
        Me.lblLoanDetails.Size = New System.Drawing.Size(202, 37)
        Me.lblLoanDetails.TabIndex = 22
        Me.lblLoanDetails.Text = "LOAN DETAILS"
        '
        'LstDescription
        '
        Me.LstDescription.FormattingEnabled = True
        Me.LstDescription.ItemHeight = 17
        Me.LstDescription.Location = New System.Drawing.Point(370, 275)
        Me.LstDescription.Name = "LstDescription"
        Me.LstDescription.Size = New System.Drawing.Size(300, 174)
        Me.LstDescription.TabIndex = 21
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(370, 69)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(300, 200)
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'btnClearLoan
        '
        Me.btnClearLoan.Location = New System.Drawing.Point(178, 402)
        Me.btnClearLoan.Name = "btnClearLoan"
        Me.btnClearLoan.Size = New System.Drawing.Size(109, 44)
        Me.btnClearLoan.TabIndex = 19
        Me.btnClearLoan.Text = "Clear"
        Me.btnClearLoan.UseVisualStyleBackColor = True
        '
        'btnConfirmLoan
        '
        Me.btnConfirmLoan.Location = New System.Drawing.Point(51, 402)
        Me.btnConfirmLoan.Name = "btnConfirmLoan"
        Me.btnConfirmLoan.Size = New System.Drawing.Size(109, 44)
        Me.btnConfirmLoan.TabIndex = 18
        Me.btnConfirmLoan.Text = "Confirm Selection"
        Me.btnConfirmLoan.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(105, 275)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 17)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "DATE OF RETURN"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(51, 308)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(236, 25)
        Me.DateTimePicker1.TabIndex = 16
        '
        'CmboBxLoanEquipment
        '
        Me.CmboBxLoanEquipment.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.EquipmentAudioBindingSource, "Equipment", True))
        Me.CmboBxLoanEquipment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmboBxLoanEquipment.FormattingEnabled = True
        Me.CmboBxLoanEquipment.Location = New System.Drawing.Point(51, 197)
        Me.CmboBxLoanEquipment.Name = "CmboBxLoanEquipment"
        Me.CmboBxLoanEquipment.Size = New System.Drawing.Size(170, 25)
        Me.CmboBxLoanEquipment.TabIndex = 15
        '
        'EquipmentAudioBindingSource
        '
        Me.EquipmentAudioBindingSource.DataMember = "EquipmentAudio" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.EquipmentAudioBindingSource.DataSource = Me.EquipmentInventoryDataSet
        '
        'EquipmentInventoryDataSet
        '
        Me.EquipmentInventoryDataSet.DataSetName = "EquipmentInventoryDataSet"
        Me.EquipmentInventoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblEquipment
        '
        Me.lblEquipment.AutoSize = True
        Me.lblEquipment.Location = New System.Drawing.Point(79, 166)
        Me.lblEquipment.Name = "lblEquipment"
        Me.lblEquipment.Size = New System.Drawing.Size(121, 17)
        Me.lblEquipment.TabIndex = 14
        Me.lblEquipment.Text = "EQUIPMENT PIECE"
        '
        'CmboBxLoanCategory
        '
        Me.CmboBxLoanCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmboBxLoanCategory.FormattingEnabled = True
        Me.CmboBxLoanCategory.Items.AddRange(New Object() {"Video", "Audio"})
        Me.CmboBxLoanCategory.Location = New System.Drawing.Point(51, 104)
        Me.CmboBxLoanCategory.Name = "CmboBxLoanCategory"
        Me.CmboBxLoanCategory.Size = New System.Drawing.Size(170, 25)
        Me.CmboBxLoanCategory.TabIndex = 13
        '
        'lblEquipmentCategory
        '
        Me.lblEquipmentCategory.AutoSize = True
        Me.lblEquipmentCategory.Location = New System.Drawing.Point(65, 75)
        Me.lblEquipmentCategory.Name = "lblEquipmentCategory"
        Me.lblEquipmentCategory.Size = New System.Drawing.Size(153, 17)
        Me.lblEquipmentCategory.TabIndex = 12
        Me.lblEquipmentCategory.Text = "EQUIPMENT CATEGORY"
        '
        'EquipmentVideoBindingSource
        '
        Me.EquipmentVideoBindingSource.DataMember = "EquipmentVideo"
        Me.EquipmentVideoBindingSource.DataSource = Me.EquipmentInventoryDataSet
        '
        'EquipmentCategoryBindingSource
        '
        Me.EquipmentCategoryBindingSource.DataMember = "EquipmentCategory"
        Me.EquipmentCategoryBindingSource.DataSource = Me.EquipmentInventoryDataSet
        '
        'TbCntrl
        '
        Me.TbCntrl.Controls.Add(Me.TabLoan)
        Me.TbCntrl.Controls.Add(Me.TabPage2)
        Me.TbCntrl.Controls.Add(Me.TabPage3)
        Me.TbCntrl.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbCntrl.Location = New System.Drawing.Point(11, 57)
        Me.TbCntrl.Margin = New System.Windows.Forms.Padding(2)
        Me.TbCntrl.Name = "TbCntrl"
        Me.TbCntrl.Padding = New System.Drawing.Point(20, 10)
        Me.TbCntrl.SelectedIndex = 0
        Me.TbCntrl.Size = New System.Drawing.Size(783, 527)
        Me.TbCntrl.TabIndex = 1
        '
        'EquipmentCategoryTableAdapter
        '
        Me.EquipmentCategoryTableAdapter.ClearBeforeFill = True
        '
        'EquipmentAudio__TableAdapter
        '
        Me.EquipmentAudio__TableAdapter.ClearBeforeFill = True
        '
        'EquipmentVideoTableAdapter
        '
        Me.EquipmentVideoTableAdapter.ClearBeforeFill = True
        '
        'EquipmentInventoryDataSetBindingSource
        '
        Me.EquipmentInventoryDataSetBindingSource.DataSource = Me.EquipmentInventoryDataSet
        Me.EquipmentInventoryDataSetBindingSource.Position = 0
        '
        'EquipmentAudioBindingSource1
        '
        Me.EquipmentAudioBindingSource1.DataMember = "EquipmentAudio" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.EquipmentAudioBindingSource1.DataSource = Me.EquipmentInventoryDataSetBindingSource
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
        'frmMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(810, 597)
        Me.Controls.Add(Me.btnLogOut)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.TbCntrl)
        Me.Name = "frmMainMenu"
        Me.Text = "Media Equipment Booking System"
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabLoan.ResumeLayout(False)
        Me.TabLoan.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EquipmentAudioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EquipmentInventoryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EquipmentVideoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EquipmentCategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TbCntrl.ResumeLayout(False)
        CType(Me.EquipmentInventoryDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EquipmentAudioBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoanRecordsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoanRecordsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnLogOut As Button
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btnConfirmReservation As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents DteTmeReserve As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Private WithEvents TabLoan As TabPage
    Friend WithEvents lblLoanEquipmentInfo As Label
    Friend WithEvents lblLoanDetails As Label
    Friend WithEvents LstDescription As ListBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnClearLoan As Button
    Friend WithEvents btnConfirmLoan As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents CmboBxLoanEquipment As ComboBox
    Friend WithEvents lblEquipment As Label
    Friend WithEvents CmboBxLoanCategory As ComboBox
    Friend WithEvents lblEquipmentCategory As Label
    Friend WithEvents TbCntrl As TabControl
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents DteTmeReserveReturn As DateTimePicker
    Friend WithEvents EquipmentInventoryDataSet As EquipmentInventoryDataSet
    Friend WithEvents EquipmentCategoryBindingSource As BindingSource
    Friend WithEvents EquipmentCategoryTableAdapter As EquipmentInventoryDataSetTableAdapters.EquipmentCategoryTableAdapter
    Friend WithEvents EquipmentAudioBindingSource As BindingSource
    Friend WithEvents EquipmentAudio__TableAdapter As EquipmentInventoryDataSetTableAdapters.EquipmentAudio__TableAdapter
    Friend WithEvents EquipmentVideoBindingSource As BindingSource
    Friend WithEvents EquipmentVideoTableAdapter As EquipmentInventoryDataSetTableAdapters.EquipmentVideoTableAdapter
    Friend WithEvents EquipmentInventoryDataSetBindingSource As BindingSource
    Friend WithEvents EquipmentAudioBindingSource1 As BindingSource
    Friend WithEvents CmboBxReserveCategory As ComboBox
    Friend WithEvents CmboBxReserveEquipment As ComboBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents LoanRecordsDataSet As LoanRecordsDataSet
    Friend WithEvents LoanRecordsBindingSource As BindingSource
    Friend WithEvents LoanRecordsTableAdapter As LoanRecordsDataSetTableAdapters.LoanRecordsTableAdapter
    Friend WithEvents TableAdapterManager As LoanRecordsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents btnViewRecords As Button
End Class
