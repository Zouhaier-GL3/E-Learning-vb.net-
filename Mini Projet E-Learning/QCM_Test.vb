Public Class QCM_Test
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim welcomego As New Question1Niveau1
        welcomego.Show()
        Me.Hide()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub QCM_Test_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim welcomego As New QuestionsNiveau2
        welcomego.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim welcomego As New QuestionsNiveau3
        welcomego.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim welcomego As New QuestionsNiveau4
        welcomego.Show()
        Me.Hide()
    End Sub
End Class