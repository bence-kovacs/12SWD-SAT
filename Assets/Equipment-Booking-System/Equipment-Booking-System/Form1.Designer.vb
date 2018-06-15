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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TbCntrl = New System.Windows.Forms.TabControl()
        Me.TabLoan = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage2.SuspendLayout()
        Me.TbCntrl.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.AutoSize = True
        Me.Button1.Location = New System.Drawing.Point(562, 297)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 35)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 48)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(769, 567)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "               Reserve               "
        '
        'TbCntrl
        '
        Me.TbCntrl.Controls.Add(Me.TabLoan)
        Me.TbCntrl.Controls.Add(Me.TabPage2)
        Me.TbCntrl.Controls.Add(Me.TabPage3)
        Me.TbCntrl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbCntrl.Location = New System.Drawing.Point(1, 3)
        Me.TbCntrl.Name = "TbCntrl"
        Me.TbCntrl.Padding = New System.Drawing.Point(20, 10)
        Me.TbCntrl.SelectedIndex = 0
        Me.TbCntrl.Size = New System.Drawing.Size(837, 619)
        Me.TbCntrl.TabIndex = 1
        '
        'TabLoan
        '
        Me.TabLoan.BackColor = System.Drawing.Color.Transparent
        Me.TabLoan.Location = New System.Drawing.Point(4, 48)
        Me.TabLoan.Name = "TabLoan"
        Me.TabLoan.Padding = New System.Windows.Forms.Padding(3)
        Me.TabLoan.Size = New System.Drawing.Size(829, 567)
        Me.TabLoan.TabIndex = 0
        Me.TabLoan.Text = "               Loan               "
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 48)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(769, 567)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "               View               "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 617)
        Me.Controls.Add(Me.TbCntrl)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TbCntrl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TbCntrl As TabControl
    Friend WithEvents TabPage3 As TabPage
    Private WithEvents TabLoan As TabPage
End Class
