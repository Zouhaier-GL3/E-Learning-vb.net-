Public Class Question10Niveau1

    Public conteur As Integer


    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click
        ProgressBar1.Value = 0.0
        ProgressBar1.Minimum = 100
        Timer1.Interval = 300
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If conteur < 100 Then
            ProgressBar1.Value = conteur
            conteur = conteur + 1
        Else
            Timer1.Enabled = False
            Me.Close()


            If RadioButton3.Checked Then

                Menu1.note += 1

            End If
            validation1.Show()
        End If
    End Sub

    Private Sub Question10Niveau1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False


        If RadioButton3.Checked Then

            Menu1.note += 1

        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click



        If RadioButton3.Checked Then

            Menu1.note += 1

        End If

        Dim welcomego As New validation1
        welcomego.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim i As DialogResult
        i = MessageBox.Show("confirm if you want to exit", "Login System", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If i = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub panel2_Paint(sender As Object, e As PaintEventArgs) Handles panel2.Paint

    End Sub
End Class