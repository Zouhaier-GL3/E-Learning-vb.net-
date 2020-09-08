Public Class validation2
    Sub switchPanel(ByVal panel As Form)
        Panel1.Controls.Clear()
        panel.TopLevel = False
        Panel1.Controls.Add(panel)
        panel.Show()


    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        QuestionsNiveau2.note += 1
        If QuestionsNiveau2.note >= 7 Then
            Label1.Text = "Félicitation vous aviez eu la note de " & Menu1.note & "pour ce niveau "
        Else
            Label1.Text = "Désole vous aviez eu la note de " & Menu1.note & "pour ce niveau "
        End If
    End Sub

    Private Sub validation2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        switchPanel(correction2)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class