Public Class Vocabilaire
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        PDF.Show()
        PDF.AxAcroPDF1.src = ("C:\Users\pc\Music\cours anglais\vocab\1-futur-simple-anglais-cours.pdf")
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Me.Hide()
        PDF.Show()
        PDF.AxAcroPDF1.src = ("C:\Users\pc\Music\cours anglais\vocab\2-futur-going-to-anglais-cours.pdf")
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Me.Hide()
        PDF.Show()
        PDF.AxAcroPDF1.src = ("C:\Users\pc\Music\cours anglais\vocab\3-futur-progressif-anglais-cours.pdf")
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        Me.Hide()
        PDF.Show()
        PDF.AxAcroPDF1.src = ("C:\Users\pc\Music\cours anglais\vocab\4-futur-perfect-anglais.pdf")
    End Sub

    Private Sub LinkLabel5_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        Me.Hide()
        PDF.Show()
        PDF.AxAcroPDF1.src = ("C:\Users\pc\Music\cours anglais\vocab\5-futur-perfect-continuous-anglais.pdf")
    End Sub
End Class