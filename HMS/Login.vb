Public Class Login

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        If UsernameText.Text = "Admin" And
          PasswordText.Text = "pass" Then
            Me.Hide()

            Hotel.Show()
            MessageBox.Show("Welcome to the TAJ PALACE HOTEL !!")
        Else

            'A Message box that displays you have entered the wrong username and password

            MessageBox.Show("Please enter correct Username or Password :(")

        End If

    End Sub


    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub
End Class
