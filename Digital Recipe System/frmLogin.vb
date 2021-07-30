'Author: Erick Hadi
'Date: 11/07/2021
'Purpose: The form that the user can both create a password with and log into the application with.
Public Class frmLogin

    Dim password As String = My.Computer.FileSystem.ReadAllText("password.txt") 'Read text in password.txt in the debug folder

    'Sets up the login form according to if the user has opened the app for the first time or not
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If password.Length <> 0 Then 'If this is not the first time the user has opened the application
            'Change some text and hide some elements. Basically, I am reusing this same form instead of creating a different form because it is easier to do
            lblConfirmPassword.Text = "Enter Password: "
            lblSetPassword.Visible = False
            txtSetPassword.Visible = False
            'Replace btnCreatePassword with btnLogin on the form
            btnCreatePassword.Visible = False
            btnLogin.Visible = True
        End If
    End Sub

    Private Sub btnCreatePassword_Click(sender As Object, e As EventArgs) Handles btnCreatePassword.Click
        'Validate if the password exists and if the user successfully confirmed their password
        If txtSetPassword.Text = "" Or txtConfirmPassword.Text = "" Then
            MsgBox("Please fill in the required field(s).")
        ElseIf txtSetPassword.Text.Length > 30 Then
            MsgBox("Password is too long. Please enter a shorter password (less than 30 characters)")
        ElseIf txtConfirmPassword.Text <> txtSetPassword.Text Then
            'Prompt password re-entry and clear textboxes
            MsgBox("Passwords do not match. Please try again.")
            txtSetPassword.Clear()
            txtConfirmPassword.Clear()
        Else 'If the passwords are all correct, let the user proceed to the main form
            MsgBox("Password successfully created")
            My.Computer.FileSystem.WriteAllText("password.txt", txtSetPassword.Text, True) 'Write the password to password.txt
            frmMain.Show() 'Opens the next form
            Hide() 'Closes the current form
        End If
    End Sub


    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtConfirmPassword.Text = password Then 'If the password is correct, let the user go to the main form
            frmMain.Show() 'Opens the next form
            Hide() 'Closes the current form
        ElseIf txtConfirmPassword.Text = "" Then 'Existence validation: checking to see if the user has entered data
            MsgBox("Please enter a password")
        ElseIf txtConfirmPassword.Text = "adminpassword" Then 'If the admin password is typed in
            Dim newPassword As String = InputBox("Change password to: ") 'Allow user to change password
            My.Computer.FileSystem.WriteAllText("password.txt", "", False) 'Clear the file
            My.Computer.FileSystem.WriteAllText("password.txt", newPassword, True) 'Write new password
            password = My.Computer.FileSystem.ReadAllText("password.txt") 'Update variable
        Else
            MsgBox("Password incorrect. Please try again.")
            txtConfirmPassword.Clear() 'Clears the textbox so the user can enter their password again
        End If
    End Sub
End Class