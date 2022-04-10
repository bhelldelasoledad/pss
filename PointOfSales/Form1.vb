Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "admin" And TextBox2.Text = "admin" Then
            MsgBox("Log in Successfully!", MsgBoxStyle.OkOnly, "Log in Form")
            Form2.Show()
            Me.Hide()
        Else
            MsgBox("Sorry Incorrect Employee Id and Password", MsgBoxStyle.OkOnly, "Invalid")
        End If

    End Sub

End Class
