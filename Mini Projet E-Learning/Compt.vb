Public Class Compt
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim welcomego As New Loginadmin
        welcomego.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim i As DialogResult
        i = MessageBox.Show("confirm if you want to exit", "Login System", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If i = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim welcomego As New Logincond
        welcomego.Show()
        Me.Hide()
    End Sub
End Class
