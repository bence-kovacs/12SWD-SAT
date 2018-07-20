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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainMenu))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.btnViewRecords = New System.Windows.Forms.Button()
        Me.lblRecordsTitle = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lblReservationLength = New System.Windows.Forms.Label()
        Me.txtReservationLength = New System.Windows.Forms.TextBox()
        Me.lblReserveName = New System.Windows.Forms.Label()
        Me.txtReserveName = New System.Windows.Forms.TextBox()
        Me.CmboBxReserveEquipment = New System.Windows.Forms.ComboBox()
        Me.CmboBxReserveCategory = New System.Windows.Forms.ComboBox()
        Me.lblReserveReturnDate = New System.Windows.Forms.Label()
        Me.DteTmeReserveReturn = New System.Windows.Forms.DateTimePicker()
        Me.lblReservationTitle = New System.Windows.Forms.Label()
        Me.btnConfirmReservation = New System.Windows.Forms.Button()
        Me.lblReserveDate = New System.Windows.Forms.Label()
        Me.DteTmeReserve = New System.Windows.Forms.DateTimePicker()
        Me.lblEquipmentReservation = New System.Windows.Forms.Label()
        Me.lblEquipmentCategoryReservation = New System.Windows.Forms.Label()
        Me.TabLoan = New System.Windows.Forms.TabPage()
        Me.lblLoanLength = New System.Windows.Forms.Label()
        Me.txtLoanLength = New System.Windows.Forms.TextBox()
        Me.lblDateLoan = New System.Windows.Forms.Label()
        Me.DteTmeLoan = New System.Windows.Forms.DateTimePicker()
        Me.lblUsernameLoan = New System.Windows.Forms.Label()
        Me.txtLoanName = New System.Windows.Forms.TextBox()
        Me.lblLoanTitle = New System.Windows.Forms.Label()
        Me.btnConfirmLoan = New System.Windows.Forms.Button()
        Me.lblLoanReturnDate = New System.Windows.Forms.Label()
        Me.DteTmeLoanReturn = New System.Windows.Forms.DateTimePicker()
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
        Me.TabLoan.SuspendLayout()
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
        Me.btnLogOut.TabIndex = 6
        Me.btnLogOut.Text = "LOG OUT"
        Me.btnLogOut.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.AutoScroll = True
        Me.TabPage3.Controls.Add(Me.btnViewRecords)
        Me.TabPage3.Controls.Add(Me.lblRecordsTitle)
        Me.TabPage3.Location = New System.Drawing.Point(4, 40)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
        'lblRecordsTitle
        '
        Me.lblRecordsTitle.AutoSize = True
        Me.lblRecordsTitle.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecordsTitle.Location = New System.Drawing.Point(322, 23)
        Me.lblRecordsTitle.Name = "lblRecordsTitle"
        Me.lblRecordsTitle.Size = New System.Drawing.Size(93, 32)
        Me.lblRecordsTitle.TabIndex = 23
        Me.lblRecordsTitle.Text = "LOANS"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.lblReservationLength)
        Me.TabPage2.Controls.Add(Me.txtReservationLength)
        Me.TabPage2.Controls.Add(Me.lblReserveName)
        Me.TabPage2.Controls.Add(Me.txtReserveName)
        Me.TabPage2.Controls.Add(Me.CmboBxReserveEquipment)
        Me.TabPage2.Controls.Add(Me.CmboBxReserveCategory)
        Me.TabPage2.Controls.Add(Me.lblReserveReturnDate)
        Me.TabPage2.Controls.Add(Me.DteTmeReserveReturn)
        Me.TabPage2.Controls.Add(Me.lblReservationTitle)
        Me.TabPage2.Controls.Add(Me.btnConfirmReservation)
        Me.TabPage2.Controls.Add(Me.lblReserveDate)
        Me.TabPage2.Controls.Add(Me.DteTmeReserve)
        Me.TabPage2.Controls.Add(Me.lblEquipmentReservation)
        Me.TabPage2.Controls.Add(Me.lblEquipmentCategoryReservation)
        Me.TabPage2.Location = New System.Drawing.Point(4, 40)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabPage2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TabPage2.Size = New System.Drawing.Size(775, 483)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "                       Reserve                       "
        '
        'lblReservationLength
        '
        Me.lblReservationLength.AutoSize = True
        Me.lblReservationLength.Location = New System.Drawing.Point(492, 284)
        Me.lblReservationLength.Name = "lblReservationLength"
        Me.lblReservationLength.Size = New System.Drawing.Size(169, 17)
        Me.lblReservationLength.TabIndex = 37
        Me.lblReservationLength.Text = "LENGTH OF RESERVATION"
        '
        'txtReservationLength
        '
        Me.txtReservationLength.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtReservationLength.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReservationLength.Location = New System.Drawing.Point(458, 305)
        Me.txtReservationLength.Name = "txtReservationLength"
        Me.txtReservationLength.ReadOnly = True
        Me.txtReservationLength.Size = New System.Drawing.Size(236, 25)
        Me.txtReservationLength.TabIndex = 36
        Me.txtReservationLength.TabStop = False
        Me.txtReservationLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblReserveName
        '
        Me.lblReserveName.AutoSize = True
        Me.lblReserveName.Location = New System.Drawing.Point(175, 284)
        Me.lblReserveName.Name = "lblReserveName"
        Me.lblReserveName.Size = New System.Drawing.Size(77, 17)
        Me.lblReserveName.TabIndex = 29
        Me.lblReserveName.Text = "USERNAME"
        '
        'txtReserveName
        '
        Me.txtReserveName.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtReserveName.Location = New System.Drawing.Point(126, 304)
        Me.txtReserveName.Name = "txtReserveName"
        Me.txtReserveName.ReadOnly = True
        Me.txtReserveName.Size = New System.Drawing.Size(169, 25)
        Me.txtReserveName.TabIndex = 28
        Me.txtReserveName.TabStop = False
        Me.txtReserveName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CmboBxReserveEquipment
        '
        Me.CmboBxReserveEquipment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmboBxReserveEquipment.FormattingEnabled = True
        Me.CmboBxReserveEquipment.Items.AddRange(New Object() {"Video", "Audio"})
        Me.CmboBxReserveEquipment.Location = New System.Drawing.Point(125, 236)
        Me.CmboBxReserveEquipment.Name = "CmboBxReserveEquipment"
        Me.CmboBxReserveEquipment.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmboBxReserveEquipment.Size = New System.Drawing.Size(170, 25)
        Me.CmboBxReserveEquipment.TabIndex = 2
        '
        'CmboBxReserveCategory
        '
        Me.CmboBxReserveCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmboBxReserveCategory.FormattingEnabled = True
        Me.CmboBxReserveCategory.ItemHeight = 17
        Me.CmboBxReserveCategory.Items.AddRange(New Object() {"Video", "Audio"})
        Me.CmboBxReserveCategory.Location = New System.Drawing.Point(125, 164)
        Me.CmboBxReserveCategory.Name = "CmboBxReserveCategory"
        Me.CmboBxReserveCategory.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmboBxReserveCategory.Size = New System.Drawing.Size(170, 25)
        Me.CmboBxReserveCategory.TabIndex = 1
        '
        'lblReserveReturnDate
        '
        Me.lblReserveReturnDate.AutoSize = True
        Me.lblReserveReturnDate.Location = New System.Drawing.Point(522, 203)
        Me.lblReserveReturnDate.Name = "lblReserveReturnDate"
        Me.lblReserveReturnDate.Size = New System.Drawing.Size(116, 17)
        Me.lblReserveReturnDate.TabIndex = 25
        Me.lblReserveReturnDate.Text = "DATE OF RETURN"
        '
        'DteTmeReserveReturn
        '
        Me.DteTmeReserveReturn.Location = New System.Drawing.Point(458, 236)
        Me.DteTmeReserveReturn.Name = "DteTmeReserveReturn"
        Me.DteTmeReserveReturn.Size = New System.Drawing.Size(236, 25)
        Me.DteTmeReserveReturn.TabIndex = 4
        '
        'lblReservationTitle
        '
        Me.lblReservationTitle.AutoSize = True
        Me.lblReservationTitle.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReservationTitle.Location = New System.Drawing.Point(236, 20)
        Me.lblReservationTitle.Name = "lblReservationTitle"
        Me.lblReservationTitle.Size = New System.Drawing.Size(275, 32)
        Me.lblReservationTitle.TabIndex = 22
        Me.lblReservationTitle.Text = "RESERVATION DETAILS"
        '
        'btnConfirmReservation
        '
        Me.btnConfirmReservation.Location = New System.Drawing.Point(334, 400)
        Me.btnConfirmReservation.Name = "btnConfirmReservation"
        Me.btnConfirmReservation.Size = New System.Drawing.Size(109, 44)
        Me.btnConfirmReservation.TabIndex = 5
        Me.btnConfirmReservation.Text = "Confirm Selection"
        Me.btnConfirmReservation.UseVisualStyleBackColor = True
        '
        'lblReserveDate
        '
        Me.lblReserveDate.AutoSize = True
        Me.lblReserveDate.Location = New System.Drawing.Point(522, 131)
        Me.lblReserveDate.Name = "lblReserveDate"
        Me.lblReserveDate.Size = New System.Drawing.Size(102, 17)
        Me.lblReserveDate.TabIndex = 17
        Me.lblReserveDate.Text = "DATE OF LOAN"
        '
        'DteTmeReserve
        '
        Me.DteTmeReserve.Location = New System.Drawing.Point(458, 164)
        Me.DteTmeReserve.Name = "DteTmeReserve"
        Me.DteTmeReserve.Size = New System.Drawing.Size(236, 25)
        Me.DteTmeReserve.TabIndex = 3
        '
        'lblEquipmentReservation
        '
        Me.lblEquipmentReservation.AutoSize = True
        Me.lblEquipmentReservation.Location = New System.Drawing.Point(154, 203)
        Me.lblEquipmentReservation.Name = "lblEquipmentReservation"
        Me.lblEquipmentReservation.Size = New System.Drawing.Size(121, 17)
        Me.lblEquipmentReservation.TabIndex = 14
        Me.lblEquipmentReservation.Text = "EQUIPMENT PIECE"
        '
        'lblEquipmentCategoryReservation
        '
        Me.lblEquipmentCategoryReservation.AutoSize = True
        Me.lblEquipmentCategoryReservation.Location = New System.Drawing.Point(133, 131)
        Me.lblEquipmentCategoryReservation.Name = "lblEquipmentCategoryReservation"
        Me.lblEquipmentCategoryReservation.Size = New System.Drawing.Size(153, 17)
        Me.lblEquipmentCategoryReservation.TabIndex = 12
        Me.lblEquipmentCategoryReservation.Text = "EQUIPMENT CATEGORY"
        '
        'TabLoan
        '
        Me.TabLoan.BackColor = System.Drawing.Color.Transparent
        Me.TabLoan.Controls.Add(Me.lblLoanLength)
        Me.TabLoan.Controls.Add(Me.txtLoanLength)
        Me.TabLoan.Controls.Add(Me.lblDateLoan)
        Me.TabLoan.Controls.Add(Me.DteTmeLoan)
        Me.TabLoan.Controls.Add(Me.lblUsernameLoan)
        Me.TabLoan.Controls.Add(Me.txtLoanName)
        Me.TabLoan.Controls.Add(Me.lblLoanTitle)
        Me.TabLoan.Controls.Add(Me.btnConfirmLoan)
        Me.TabLoan.Controls.Add(Me.lblLoanReturnDate)
        Me.TabLoan.Controls.Add(Me.DteTmeLoanReturn)
        Me.TabLoan.Controls.Add(Me.CmboBxLoanEquipment)
        Me.TabLoan.Controls.Add(Me.lblEquipment)
        Me.TabLoan.Controls.Add(Me.CmboBxLoanCategory)
        Me.TabLoan.Controls.Add(Me.lblEquipmentCategory)
        Me.TabLoan.Location = New System.Drawing.Point(4, 40)
        Me.TabLoan.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabLoan.Name = "TabLoan"
        Me.TabLoan.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabLoan.Size = New System.Drawing.Size(775, 483)
        Me.TabLoan.TabIndex = 0
        Me.TabLoan.Text = "                       Loan                       "
        '
        'lblLoanLength
        '
        Me.lblLoanLength.AutoSize = True
        Me.lblLoanLength.Location = New System.Drawing.Point(522, 284)
        Me.lblLoanLength.Name = "lblLoanLength"
        Me.lblLoanLength.Size = New System.Drawing.Size(120, 17)
        Me.lblLoanLength.TabIndex = 35
        Me.lblLoanLength.Text = "LENGTH OF LOAN"
        '
        'txtLoanLength
        '
        Me.txtLoanLength.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtLoanLength.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoanLength.Location = New System.Drawing.Point(458, 305)
        Me.txtLoanLength.Name = "txtLoanLength"
        Me.txtLoanLength.ReadOnly = True
        Me.txtLoanLength.Size = New System.Drawing.Size(236, 25)
        Me.txtLoanLength.TabIndex = 34
        Me.txtLoanLength.TabStop = False
        Me.txtLoanLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblDateLoan
        '
        Me.lblDateLoan.AutoSize = True
        Me.lblDateLoan.Location = New System.Drawing.Point(522, 131)
        Me.lblDateLoan.Name = "lblDateLoan"
        Me.lblDateLoan.Size = New System.Drawing.Size(102, 17)
        Me.lblDateLoan.TabIndex = 33
        Me.lblDateLoan.Text = "DATE OF LOAN"
        Me.lblDateLoan.Visible = False
        '
        'DteTmeLoan
        '
        Me.DteTmeLoan.Location = New System.Drawing.Point(458, 164)
        Me.DteTmeLoan.Name = "DteTmeLoan"
        Me.DteTmeLoan.Size = New System.Drawing.Size(236, 25)
        Me.DteTmeLoan.TabIndex = 3
        Me.DteTmeLoan.Visible = False
        '
        'lblUsernameLoan
        '
        Me.lblUsernameLoan.AutoSize = True
        Me.lblUsernameLoan.Location = New System.Drawing.Point(176, 284)
        Me.lblUsernameLoan.Name = "lblUsernameLoan"
        Me.lblUsernameLoan.Size = New System.Drawing.Size(77, 17)
        Me.lblUsernameLoan.TabIndex = 31
        Me.lblUsernameLoan.Text = "USERNAME"
        '
        'txtLoanName
        '
        Me.txtLoanName.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtLoanName.Location = New System.Drawing.Point(126, 304)
        Me.txtLoanName.Name = "txtLoanName"
        Me.txtLoanName.ReadOnly = True
        Me.txtLoanName.Size = New System.Drawing.Size(169, 25)
        Me.txtLoanName.TabIndex = 30
        Me.txtLoanName.TabStop = False
        Me.txtLoanName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblLoanTitle
        '
        Me.lblLoanTitle.AutoSize = True
        Me.lblLoanTitle.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoanTitle.Location = New System.Drawing.Point(291, 20)
        Me.lblLoanTitle.Name = "lblLoanTitle"
        Me.lblLoanTitle.Size = New System.Drawing.Size(180, 32)
        Me.lblLoanTitle.TabIndex = 22
        Me.lblLoanTitle.Text = "LOAN DETAILS"
        '
        'btnConfirmLoan
        '
        Me.btnConfirmLoan.Location = New System.Drawing.Point(334, 400)
        Me.btnConfirmLoan.Name = "btnConfirmLoan"
        Me.btnConfirmLoan.Size = New System.Drawing.Size(109, 44)
        Me.btnConfirmLoan.TabIndex = 5
        Me.btnConfirmLoan.Text = "Confirm Selection"
        Me.btnConfirmLoan.UseVisualStyleBackColor = True
        '
        'lblLoanReturnDate
        '
        Me.lblLoanReturnDate.AutoSize = True
        Me.lblLoanReturnDate.Location = New System.Drawing.Point(522, 203)
        Me.lblLoanReturnDate.Name = "lblLoanReturnDate"
        Me.lblLoanReturnDate.Size = New System.Drawing.Size(116, 17)
        Me.lblLoanReturnDate.TabIndex = 17
        Me.lblLoanReturnDate.Text = "DATE OF RETURN"
        '
        'DteTmeLoanReturn
        '
        Me.DteTmeLoanReturn.Location = New System.Drawing.Point(458, 236)
        Me.DteTmeLoanReturn.Name = "DteTmeLoanReturn"
        Me.DteTmeLoanReturn.Size = New System.Drawing.Size(236, 25)
        Me.DteTmeLoanReturn.TabIndex = 4
        '
        'CmboBxLoanEquipment
        '
        Me.CmboBxLoanEquipment.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.EquipmentAudioBindingSource, "Equipment", True))
        Me.CmboBxLoanEquipment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmboBxLoanEquipment.FormattingEnabled = True
        Me.CmboBxLoanEquipment.Location = New System.Drawing.Point(125, 236)
        Me.CmboBxLoanEquipment.Name = "CmboBxLoanEquipment"
        Me.CmboBxLoanEquipment.Size = New System.Drawing.Size(170, 25)
        Me.CmboBxLoanEquipment.TabIndex = 2
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
        Me.lblEquipment.Location = New System.Drawing.Point(154, 203)
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
        Me.CmboBxLoanCategory.Location = New System.Drawing.Point(125, 164)
        Me.CmboBxLoanCategory.Name = "CmboBxLoanCategory"
        Me.CmboBxLoanCategory.Size = New System.Drawing.Size(170, 25)
        Me.CmboBxLoanCategory.TabIndex = 1
        '
        'lblEquipmentCategory
        '
        Me.lblEquipmentCategory.AutoSize = True
        Me.lblEquipmentCategory.Location = New System.Drawing.Point(133, 131)
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
        Me.TbCntrl.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Equipment Booker"
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabLoan.ResumeLayout(False)
        Me.TabLoan.PerformLayout()
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
    Friend WithEvents lblReservationTitle As Label
    Friend WithEvents btnConfirmReservation As Button
    Friend WithEvents lblReserveDate As Label
    Friend WithEvents DteTmeReserve As DateTimePicker
    Friend WithEvents lblEquipmentReservation As Label
    Friend WithEvents lblEquipmentCategoryReservation As Label
    Private WithEvents TabLoan As TabPage
    Friend WithEvents lblLoanTitle As Label
    Friend WithEvents btnConfirmLoan As Button
    Friend WithEvents lblLoanReturnDate As Label
    Friend WithEvents DteTmeLoanReturn As DateTimePicker
    Friend WithEvents CmboBxLoanEquipment As ComboBox
    Friend WithEvents lblEquipment As Label
    Friend WithEvents CmboBxLoanCategory As ComboBox
    Friend WithEvents lblEquipmentCategory As Label
    Friend WithEvents TbCntrl As TabControl
    Friend WithEvents lblRecordsTitle As Label
    Friend WithEvents lblReserveReturnDate As Label
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
    Friend WithEvents txtReserveName As TextBox
    Friend WithEvents LoanRecordsDataSet As LoanRecordsDataSet
    Friend WithEvents LoanRecordsBindingSource As BindingSource
    Friend WithEvents LoanRecordsTableAdapter As LoanRecordsDataSetTableAdapters.LoanRecordsTableAdapter
    Friend WithEvents TableAdapterManager As LoanRecordsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents btnViewRecords As Button
    Friend WithEvents lblReserveName As Label
    Friend WithEvents lblUsernameLoan As Label
    Friend WithEvents txtLoanName As TextBox
    Friend WithEvents lblDateLoan As Label
    Friend WithEvents DteTmeLoan As DateTimePicker
    Friend WithEvents lblLoanLength As Label
    Friend WithEvents txtLoanLength As TextBox
    Friend WithEvents lblReservationLength As Label
    Friend WithEvents txtReservationLength As TextBox
End Class
