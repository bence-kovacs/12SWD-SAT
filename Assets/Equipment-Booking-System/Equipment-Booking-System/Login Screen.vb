Public Class frmLogin
    'Switching forms on the click of the submit button
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        frmMainMenu.Show()
        Me.Hide()
    End Sub
    'Close button label thingo
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub
    Private Sub txtUsername_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUsername.GotFocus
        If txtUsername.Text = "USERNAME" Then
            txtUsername.Text = ""
        End If
    End Sub

    Private Sub TxtUsername_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUsername.LostFocus

        If txtUsername.Text = "" Then
            txtUsername.Text = "USERNAME"
        End If
    End Sub
    Private Sub txtPassword_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUsername.GotFocus
        If txtPassword.Text = "PASSWORD" Then
            txtPassword.Text = ""
        End If
    End Sub
    Private Sub txtPassword_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUsername.LostFocus

        If txtUsername.Text = "" Then
            txtUsername.Text = "PASSWORD"
        End If
    End Sub
End Class