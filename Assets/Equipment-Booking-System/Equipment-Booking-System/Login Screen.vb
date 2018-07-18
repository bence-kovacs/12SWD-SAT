Imports System.Data.SqlClient
Public Class frmLogin



    ''Switching forms on the click of the submit button TEMP
    'Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
    '    frmMainMenu.Show()
    '    Me.Hide()
    'End Sub


    'Close button label thingo
    Private Sub lblClose_Click(sender As Object, e As EventArgs) Handles lblClose.Click
        Me.Close()
    End Sub

    '
    '
    'Make username and password fields have relevent descriptions in them when input
    '
    '

    ''"Username" disappear when field is clicked
    Public Sub txtUsername_MouseClick(sender As Object, e As MouseEventArgs) Handles txtUsername.MouseClick
        If txtUsername.Text = "USERNAME" Then
            txtUsername.Text = ""
        End If
    End Sub
    ''"Username" reappear when field is clicked off and left blank
    Public Sub txtUsername_LostFocus(sender As Object, e As EventArgs) Handles txtUsername.LostFocus
        If txtUsername.Text = "" Then
            txtUsername.Text = "USERNAME"
        End If
    End Sub
    ''"Password reappear in normal characters when field is blank and clicked off
    Public Sub txtPassword_LostFocus(sender As Object, e As EventArgs) Handles txtPassword.LostFocus
        If txtPassword.Text = "" Then
            txtPassword.UseSystemPasswordChar = False
            txtPassword.Text = "PASSWORD"
        End If
    End Sub
    ''Password disappear when user clicks and character type is set to secure password characters
    Public Sub txtPassword_MouseClick(sender As Object, e As MouseEventArgs) Handles txtPassword.MouseClick

        If txtPassword.Text = "PASSWORD" Then
            txtPassword.UseSystemPasswordChar = True
            txtPassword.Text = ""
        End If
    End Sub
    ''
    ''
    ''PASSWORDING
    ''
    ''

    Dim con As New SqlClient.SqlConnection
    Dim da As New SqlClient.SqlDataAdapter
    Dim ds As New DataSet
    Dim sqlquery As String
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Bence\Documents\SWD\12SWD-SAT\Assets\Equipment-Booking-System\Equipment-Booking-System\Users.mdf;Integrated Security=True"

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            'checking if the username and password field is null

            If Len(Trim(txtUsername.Text)) = 0 Then
                MessageBox.Show("Enter the user name", "Input Error !", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
                txtUsername.Focus()
            End If
            If Len(Trim(txtPassword.Text)) = 0 Then
                MessageBox.Show("Enter the password", "Input Error !", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
                txtPassword.Focus()
            End If

            'executing SQL Query for retrieving the username and password from the database table

            con.Open()
            sqlquery = "SELECT * FROM UserInfo WHERE Username='" & txtUsername.Text & "' and Password='" & txtPassword.Text & "' "
            da = New SqlClient.SqlDataAdapter(sqlquery, con)
            da.Fill(ds, "UserInfo")
            If ds.Tables("UserInfo").Rows.Count <> 0 Then
                'MessageBox.Show("Login succeed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)


                'Goto MainMenu
                Me.Hide()
                frmMainMenu.Show()

            Else
                MessageBox.Show("Invalid user name and password", "Access denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            con.Close()

            clear()    'calling clear method here

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Exception generated", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    ' declaring a method for clearing the controls
    Public Sub clear()
        txtPassword.Clear()
        txtUsername.Clear()
    End Sub

    '' code for show password
    Private Sub chkshowpassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        If chkShowPassword.Checked = True Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub

    '
    ''''''''PROBLEMS''''''''''''
    'HIGHLIGHTING OF TEXT IN USERNAME FIELD ON STARTUP
    'TABBING INTO PASSWORD FIELD DOESNT HAVE THE PASSWORD CHARACTERS ENABLED
    'EVERYTHING IS BLANK WHEN YOU PUT IN INVALID CREDS AND GET SENT BACK
End Class