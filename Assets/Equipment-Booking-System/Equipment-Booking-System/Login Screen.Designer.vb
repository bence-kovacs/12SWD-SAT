<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.lblLoanDetails = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.lblClose = New System.Windows.Forms.Label()
        Me.chkShowPassword = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'lblLoanDetails
        '
        Me.lblLoanDetails.AutoSize = True
        Me.lblLoanDetails.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoanDetails.ForeColor = System.Drawing.Color.Azure
        Me.lblLoanDetails.Location = New System.Drawing.Point(200, 57)
        Me.lblLoanDetails.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLoanDetails.Name = "lblLoanDetails"
        Me.lblLoanDetails.Size = New System.Drawing.Size(193, 71)
        Me.lblLoanDetails.TabIndex = 23
        Me.lblLoanDetails.Text = "LOGIN"
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.Azure
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.txtUsername.Location = New System.Drawing.Point(76, 206)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(436, 36)
        Me.txtUsername.TabIndex = 24
        Me.txtUsername.Text = "USERNAME"
        Me.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.Azure
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.txtPassword.Location = New System.Drawing.Point(76, 309)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(436, 36)
        Me.txtPassword.TabIndex = 25
        Me.txtPassword.Text = "PASSWORD"
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.Azure
        Me.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.Azure
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.btnLogin.Location = New System.Drawing.Point(384, 438)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(129, 48)
        Me.btnLogin.TabIndex = 26
        Me.btnLogin.Text = "SUBMIT"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'lblClose
        '
        Me.lblClose.AutoSize = True
        Me.lblClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblClose.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClose.ForeColor = System.Drawing.Color.Azure
        Me.lblClose.Location = New System.Drawing.Point(549, 14)
        Me.lblClose.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(41, 45)
        Me.lblClose.TabIndex = 23
        Me.lblClose.Text = "X"
        '
        'chkShowPassword
        '
        Me.chkShowPassword.AutoSize = True
        Me.chkShowPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.chkShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkShowPassword.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowPassword.ForeColor = System.Drawing.Color.Azure
        Me.chkShowPassword.Location = New System.Drawing.Point(297, 355)
        Me.chkShowPassword.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkShowPassword.Name = "chkShowPassword"
        Me.chkShowPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkShowPassword.Size = New System.Drawing.Size(212, 36)
        Me.chkShowPassword.TabIndex = 28
        Me.chkShowPassword.Text = "Show Password"
        Me.chkShowPassword.UseVisualStyleBackColor = True
        '
        'frmLogin
        '
        Me.AcceptButton = Me.btnLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(608, 529)
        Me.Controls.Add(Me.chkShowPassword)
        Me.Controls.Add(Me.lblClose)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lblLoanDetails)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login_Screen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblLoanDetails As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents lblClose As Label
    Friend WithEvents chkShowPassword As CheckBox
End Class
