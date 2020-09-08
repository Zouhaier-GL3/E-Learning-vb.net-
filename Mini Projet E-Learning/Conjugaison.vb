Public Class Conjugaison
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        PDF.Show()
        PDF.AxAcroPDF1.src = ("C:\Users\pc\Music\cours anglais\conjugaison\1-Conjugaison-avoir-en-anglais.pdf")
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Me.Hide()
        PDF.Show()
        PDF.AxAcroPDF1.src = ("C:\Users\pc\Music\cours anglais\conjugaison\2-Conjugaison-anglais.pdf")
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Me.Hide()
        PDF.Show()
        PDF.AxAcroPDF1.src = ("C:\Users\pc\Music\cours anglais\conjugaison\3-Conjugaison-du-verbe-être-en-anglais-to-be.pdf")
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        Me.Hide()
        PDF.Show()
        PDF.AxAcroPDF1.src = ("C:\Users\pc\Music\cours anglais\conjugaison\4-Conjugaison-faire-en-anglais.pdf")
    End Sub

    Private Sub Conjugaison_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class