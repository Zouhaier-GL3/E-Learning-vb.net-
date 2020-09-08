Public Class Loginadmin
    Dim Attempts As Integer = 0
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Username() As String
        Dim Password() As String

        Dim Menu As New Menu1

        If Attempts < 3 Then
            If (TextBox1.Text = "admin" And TextBox2.Text = "admin") Then

                Menu.Show()
                Me.Hide()
                TextBox2.Clear()
                TextBox1.Clear()
            Else
                TextBox2.Clear()
                TextBox1.Clear()
                TextBox1.Focus()
                MsgBox("erreur")

                Attempts += 1
            End If
        Else

            Application.Exit()

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim i As DialogResult
        i = MessageBox.Show("confirm if you want to exit", "Login System", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If i = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub Loginadmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class