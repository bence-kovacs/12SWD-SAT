Public Class frmLogin
    'Switching forms on the click of the submit button TEMP
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        frmMainMenu.Show()
        Me.Hide()
    End Sub
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
    Private Sub txtUsername_MouseClick(sender As Object, e As MouseEventArgs) Handles txtUsername.MouseClick
        If txtUsername.Text = "USERNAME" Then
            txtUsername.Text = ""
        End If
    End Sub
    ''"Username" reappear when field is clicked off and left blank
    Private Sub txtUsername_LostFocus(sender As Object, e As EventArgs) Handles txtUsername.LostFocus
        If txtUsername.Text = "" Then
            txtUsername.Text = "USERNAME"
        End If
    End Sub
    ''"Password reappear in normal characters when field is blank and clicked off
    Private Sub txtPassword_LostFocus(sender As Object, e As EventArgs) Handles txtPassword.LostFocus
        If txtPassword.Text = "" Then
            txtPassword.PasswordChar = ""
            txtPassword.Text = "PASSWORD"
        End If
    End Sub
    ''Password disappear when user clicks and character type is set to secure password characters
    Private Sub txtPassword_MouseClick(sender As Object, e As MouseEventArgs) Handles txtPassword.MouseClick

        If txtPassword.Text = "PASSWORD" Then
            txtPassword.PasswordChar = "*"
            txtPassword.Text = ""
        End If
    End Sub
End Class