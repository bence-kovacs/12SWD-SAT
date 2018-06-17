<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabLoan = New System.Windows.Forms.TabPage()
        Me.TbCntrl = New System.Windows.Forms.TabControl()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblLoanEquipmentInfo = New System.Windows.Forms.Label()
        Me.lblLoanDetails = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnClearLoan = New System.Windows.Forms.Button()
        Me.btnConfirmLoan = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.lblEquipment = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.lblEquipmentCategory = New System.Windows.Forms.Label()
        Me.TabPage2.SuspendLayout()
        Me.TabLoan.SuspendLayout()
        Me.TbCntrl.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.btnLogOut.Location = New System.Drawing.Point(691, 23)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(75, 23)
        Me.btnLogOut.TabIndex = 3
        Me.btnLogOut.Text = "LOG OUT"
        Me.btnLogOut.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 40)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage3.Size = New System.Drawing.Size(747, 483)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "               View               "
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.ListBox2)
        Me.TabPage2.Controls.Add(Me.PictureBox2)
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.Button2)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.DateTimePicker2)
        Me.TabPage2.Controls.Add(Me.ComboBox3)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.ComboBox4)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Location = New System.Drawing.Point(4, 40)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage2.Size = New System.Drawing.Size(747, 483)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "               Reserve               "
        '
        'TabLoan
        '
        Me.TabLoan.BackColor = System.Drawing.Color.Transparent
        Me.TabLoan.Controls.Add(Me.lblLoanEquipmentInfo)
        Me.TabLoan.Controls.Add(Me.lblLoanDetails)
        Me.TabLoan.Controls.Add(Me.ListBox1)
        Me.TabLoan.Controls.Add(Me.PictureBox1)
        Me.TabLoan.Controls.Add(Me.btnClearLoan)
        Me.TabLoan.Controls.Add(Me.btnConfirmLoan)
        Me.TabLoan.Controls.Add(Me.Label1)
        Me.TabLoan.Controls.Add(Me.DateTimePicker1)
        Me.TabLoan.Controls.Add(Me.ComboBox2)
        Me.TabLoan.Controls.Add(Me.lblEquipment)
        Me.TabLoan.Controls.Add(Me.ComboBox1)
        Me.TabLoan.Controls.Add(Me.lblEquipmentCategory)
        Me.TabLoan.Location = New System.Drawing.Point(4, 40)
        Me.TabLoan.Margin = New System.Windows.Forms.Padding(2)
        Me.TabLoan.Name = "TabLoan"
        Me.TabLoan.Padding = New System.Windows.Forms.Padding(2)
        Me.TabLoan.Size = New System.Drawing.Size(747, 483)
        Me.TabLoan.TabIndex = 0
        Me.TabLoan.Text = "               Loan               "
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
        Me.TbCntrl.Size = New System.Drawing.Size(755, 527)
        Me.TbCntrl.TabIndex = 1
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
        Me.Label3.Location = New System.Drawing.Point(34, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(202, 37)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "LOAN DETAILS"
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 17
        Me.ListBox2.Location = New System.Drawing.Point(370, 275)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(300, 191)
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
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(51, 402)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(109, 44)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "Confirm Selection"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(105, 275)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 17)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "DATE OF RETURN"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(51, 308)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(236, 25)
        Me.DateTimePicker2.TabIndex = 16
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"Equipment 1", "Equipment 2", "Equipment 3" & Global.Microsoft.VisualBasic.ChrW(9)})
        Me.ComboBox3.Location = New System.Drawing.Point(51, 197)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(170, 25)
        Me.ComboBox3.TabIndex = 15
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
        'ComboBox4
        '
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Items.AddRange(New Object() {"Category 1", "Category 2", "Category 3"})
        Me.ComboBox4.Location = New System.Drawing.Point(51, 104)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(170, 25)
        Me.ComboBox4.TabIndex = 13
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
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 17
        Me.ListBox1.Location = New System.Drawing.Point(370, 275)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(300, 191)
        Me.ListBox1.TabIndex = 21
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
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Equipment 1", "Equipment 2", "Equipment 3" & Global.Microsoft.VisualBasic.ChrW(9)})
        Me.ComboBox2.Location = New System.Drawing.Point(51, 197)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(170, 25)
        Me.ComboBox2.TabIndex = 15
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
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Category 1", "Category 2", "Category 3"})
        Me.ComboBox1.Location = New System.Drawing.Point(51, 104)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(170, 25)
        Me.ComboBox1.TabIndex = 13
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(777, 595)
        Me.Controls.Add(Me.btnLogOut)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.TbCntrl)
        Me.Name = "Form1"
        Me.Text = "Media Equipment Booking System"
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabLoan.ResumeLayout(False)
        Me.TabLoan.PerformLayout()
        Me.TbCntrl.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
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
    Friend WithEvents Button2 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents Label6 As Label
    Private WithEvents TabLoan As TabPage
    Friend WithEvents lblLoanEquipmentInfo As Label
    Friend WithEvents lblLoanDetails As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnClearLoan As Button
    Friend WithEvents btnConfirmLoan As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents lblEquipment As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents lblEquipmentCategory As Label
    Friend WithEvents TbCntrl As TabControl
End Class
