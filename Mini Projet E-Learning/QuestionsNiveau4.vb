Public Class QuestionsNiveau4

    Public note As Integer
    Dim j As Integer = 1

    Private Sub QuestionsNiveau4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        ProgressBar1.Value = 0


        Label1.Text = ("question1")
        Label2.Text = ("I’ve never been very good ….. dealing with conflict.")

        RadioButton1.Text = ("for")
        RadioButton2.Text = ("with")
        RadioButton3.Text = ("on")
        RadioButton4.Text = ("at")
        Timer1.Start()
        j = j + 1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If j = 2 Then

            If RadioButton4.Checked Then
                note = note + 1
            End If

            RadioButton1.Checked = False
            RadioButton2.Checked = False
            RadioButton3.Checked = False
            RadioButton4.Checked = False
            ProgressBar1.Value = 0


            Me.Label1.Text = "Question2"
            Me.Label2.Text = ("Yes, I see what you mean. I ….. wrong about her.")
            Me.RadioButton1.Text = "ought to have been"
            Me.RadioButton2.Text = "could have been"
            Me.RadioButton3.Text = "might have"
            Me.RadioButton4.Text = "won’t have been"
            Timer1.Start()
            j = j + 1

        ElseIf j = 3 Then
            If RadioButton2.Checked Then
                note = note + 1
            End If

            RadioButton1.Checked = False
            RadioButton2.Checked = False
            RadioButton3.Checked = False
            RadioButton4.Checked = False
            ProgressBar1.Value = 0


            Me.Label1.Text = "Question3"
            Me.Label2.Text = (“I am ….. from my work by the incessant noise upstairs.")
            Me.RadioButton1.Text = "perturbed"
            Me.RadioButton2.Text = "disrupted"
            Me.RadioButton3.Text = "interrupted"
            Me.RadioButton4.Text = "distracted"
            Timer1.Start()
            j = j + 1


        ElseIf j = 4 Then
            If RadioButton4.Checked Then
                note = note + 1
            End If

            RadioButton1.Checked = False
            RadioButton2.Checked = False
            RadioButton3.Checked = False
            RadioButton4.Checked = False
            ProgressBar1.Value = 0


            Me.Label1.Text = "Question4"
            Me.Label2.Text = ("I feel much better since I ….. drinking.")
            Me.RadioButton1.Text = "gave up"
            Me.RadioButton2.Text = "gave in"
            Me.RadioButton3.Text = "took on"
            Me.RadioButton4.Text = "took in"
            Timer1.Start()
            j = j + 1

        ElseIf j = 5 Then
            If RadioButton1.Checked Then
                note = note + 1
            End If

            RadioButton1.Checked = False
            RadioButton2.Checked = False
            RadioButton3.Checked = False
            RadioButton4.Checked = False
            ProgressBar1.Value = 0

            Me.Label1.Text = "Question5"
            Me.Label2.Text = ("As China evolves, so …………. the people who live and work there.")
            Me.RadioButton1.Text = "do"
            Me.RadioButton2.Text = "does"
            Me.RadioButton3.Text = "did"
            Me.RadioButton4.Text = "have"
            Timer1.Start()
            j = j + 1

        ElseIf j = 6 Then
            If RadioButton1.Checked Then
                note = note + 1
            End If

            RadioButton1.Checked = False
            RadioButton2.Checked = False
            RadioButton3.Checked = False
            RadioButton4.Checked = False
            ProgressBar1.Value = 0


            Me.Label1.Text = "Question6"
            Me.Label2.Text = ("This superstore stocks a wide …………. of goods in each of its 25 aisles.")
            Me.RadioButton1.Text = "amount"
            Me.RadioButton2.Text = "sum"
            Me.RadioButton3.Text = "range"
            Me.RadioButton4.Text = "quantity"
            Timer1.Start()
            j = j + 1

        ElseIf j = 7 Then
            If RadioButton3.Checked Then
                note = note + 1
            End If

            RadioButton1.Checked = False
            RadioButton2.Checked = False
            RadioButton3.Checked = False
            RadioButton4.Checked = False
            ProgressBar1.Value = 0


            Me.Label1.Text = "Question7"
            Me.Label2.Text = ("One …………. ten American adults uses the new communication technology, Tweeter.")
            Me.RadioButton1.Text = "on"
            Me.RadioButton2.Text = "in"
            Me.RadioButton3.Text = "of"
            Me.RadioButton4.Text = "over"
            Timer1.Start()
            j = j + 1

        ElseIf j = 8 Then
            If RadioButton2.Checked Then
                note = note + 1
            End If

            RadioButton1.Checked = False
            RadioButton2.Checked = False
            RadioButton3.Checked = False
            RadioButton4.Checked = False
            ProgressBar1.Value = 0


            Me.Label1.Text = "Question8"
            Me.Label2.Text = ("Everyone is …………. for the competition, even those who entered in the last round.")
            Me.RadioButton1.Text = "eligible"
            Me.RadioButton2.Text = "illegal"
            Me.RadioButton3.Text = "legal"
            Me.RadioButton4.Text = "illegible"
            Timer1.Start()
            j = j + 1

        ElseIf j = 9 Then
            If RadioButton1.Checked Then
                note = note + 1
            End If

            RadioButton1.Checked = False
            RadioButton2.Checked = False
            RadioButton3.Checked = False
            RadioButton4.Checked = False
            ProgressBar1.Value = 0


            Me.Label1.Text = "Question9"
            Me.Label2.Text = ("Bill is at …………. six feet tall.")
            Me.RadioButton1.Text = "less"
            Me.RadioButton2.Text = "late"
            Me.RadioButton3.Text = "lease"
            Me.RadioButton4.Text = "least"
            Timer1.Start()
            j = j + 1

        ElseIf j = 10 Then
            If RadioButton4.Checked Then
                note = note + 1
            End If

            RadioButton1.Checked = False
            RadioButton2.Checked = False
            RadioButton3.Checked = False
            RadioButton4.Checked = False
            ProgressBar1.Value = 0


            Me.Label1.Text = "Question10"
            Me.Label2.Text = ("When Grandfather was dying, it was Grandmother who kept the whole family …………..")
            Me.RadioButton1.Text = "against."
            Me.RadioButton2.Text = "over."
            Me.RadioButton3.Text = "together."
            Me.RadioButton4.Text = "apart."
            Timer1.Start()
            j = j + 1


        ElseIf j = 11 Then
            If RadioButton3.Checked Then
                note = note + 1
            End If
            Me.Hide()
            Validation4.Show()

            If note >= 7 Then
                Validation4.Label1.Text = "Félicitation vous aviez eu la note de " & note & "pour ce niveau "
            Else
                Validation4.Label1.Text = "Désole vous aviez eu la note de " & note & "pour ce niveau "
            End If

        End If
    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

        ProgressBar1.Minimum = 100
        Timer1.Interval = 300
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = ProgressBar1.Maximum Then

            If j = 2 Then

                If RadioButton4.Checked Then
                    note = note + 1
                End If

                RadioButton1.Checked = False
                RadioButton2.Checked = False
                RadioButton3.Checked = False
                RadioButton4.Checked = False
                ProgressBar1.Value = 0


                Me.Label1.Text = "Question2"
                Me.Label2.Text = ("Yes, I see what you mean. I ….. wrong about her.")
                Me.RadioButton1.Text = "ought to have been"
                Me.RadioButton2.Text = "could have been"
                Me.RadioButton3.Text = "might have"
                Me.RadioButton4.Text = "won’t have been"
                Timer1.Start()
                j = j + 1

            ElseIf j = 3 Then
                If RadioButton2.Checked Then
                    note = note + 1
                End If

                RadioButton1.Checked = False
                RadioButton2.Checked = False
                RadioButton3.Checked = False
                RadioButton4.Checked = False
                ProgressBar1.Value = 0


                Me.Label1.Text = "Question3"
                Me.Label2.Text = (“I am ….. from my work by the incessant noise upstairs.")
                Me.RadioButton1.Text = "perturbed"
                Me.RadioButton2.Text = "disrupted"
                Me.RadioButton3.Text = "interrupted"
                Me.RadioButton4.Text = "distracted"
                Timer1.Start()
                j = j + 1


            ElseIf j = 4 Then
                If RadioButton4.Checked Then
                    note = note + 1
                End If

                RadioButton1.Checked = False
                RadioButton2.Checked = False
                RadioButton3.Checked = False
                RadioButton4.Checked = False
                ProgressBar1.Value = 0


                Me.Label1.Text = "Question4"
                Me.Label2.Text = ("I feel much better since I ….. drinking.")
                Me.RadioButton1.Text = "gave up"
                Me.RadioButton2.Text = "gave in"
                Me.RadioButton3.Text = "took on"
                Me.RadioButton4.Text = "took in"
                Timer1.Start()
                j = j + 1

            ElseIf j = 5 Then
                If RadioButton1.Checked Then
                    note = note + 1
                End If

                RadioButton1.Checked = False
                RadioButton2.Checked = False
                RadioButton3.Checked = False
                RadioButton4.Checked = False
                ProgressBar1.Value = 0

                Me.Label1.Text = "Question5"
                Me.Label2.Text = ("As China evolves, so …………. the people who live and work there.")
                Me.RadioButton1.Text = "do"
                Me.RadioButton2.Text = "does"
                Me.RadioButton3.Text = "did"
                Me.RadioButton4.Text = "have"
                Timer1.Start()
                j = j + 1

            ElseIf j = 6 Then
                If RadioButton1.Checked Then
                    note = note + 1
                End If

                RadioButton1.Checked = False
                RadioButton2.Checked = False
                RadioButton3.Checked = False
                RadioButton4.Checked = False
                ProgressBar1.Value = 0


                Me.Label1.Text = "Question6"
                Me.Label2.Text = ("This superstore stocks a wide …………. of goods in each of its 25 aisles.")
                Me.RadioButton1.Text = "amount"
                Me.RadioButton2.Text = "sum"
                Me.RadioButton3.Text = "range"
                Me.RadioButton4.Text = "quantity"
                Timer1.Start()
                j = j + 1

            ElseIf j = 7 Then
                If RadioButton3.Checked Then
                    note = note + 1
                End If

                RadioButton1.Checked = False
                RadioButton2.Checked = False
                RadioButton3.Checked = False
                RadioButton4.Checked = False
                ProgressBar1.Value = 0


                Me.Label1.Text = "Question7"
                Me.Label2.Text = ("One …………. ten American adults uses the new communication technology, Tweeter.")
                Me.RadioButton1.Text = "on"
                Me.RadioButton2.Text = "in"
                Me.RadioButton3.Text = "of"
                Me.RadioButton4.Text = "over"
                Timer1.Start()
                j = j + 1

            ElseIf j = 8 Then
                If RadioButton2.Checked Then
                    note = note + 1
                End If

                RadioButton1.Checked = False
                RadioButton2.Checked = False
                RadioButton3.Checked = False
                RadioButton4.Checked = False
                ProgressBar1.Value = 0


                Me.Label1.Text = "Question8"
                Me.Label2.Text = ("Everyone is …………. for the competition, even those who entered in the last round.")
                Me.RadioButton1.Text = "eligible"
                Me.RadioButton2.Text = "illegal"
                Me.RadioButton3.Text = "legal"
                Me.RadioButton4.Text = "illegible"
                Timer1.Start()
                j = j + 1

            ElseIf j = 9 Then
                If RadioButton1.Checked Then
                    note = note + 1
                End If

                RadioButton1.Checked = False
                RadioButton2.Checked = False
                RadioButton3.Checked = False
                RadioButton4.Checked = False
                ProgressBar1.Value = 0


                Me.Label1.Text = "Question9"
                Me.Label2.Text = ("Bill is at …………. six feet tall.")
                Me.RadioButton1.Text = "less"
                Me.RadioButton2.Text = "late"
                Me.RadioButton3.Text = "lease"
                Me.RadioButton4.Text = "least"
                Timer1.Start()
                j = j + 1

            ElseIf j = 10 Then
                If RadioButton4.Checked Then
                    note = note + 1
                End If

                RadioButton1.Checked = False
                RadioButton2.Checked = False
                RadioButton3.Checked = False
                RadioButton4.Checked = False
                ProgressBar1.Value = 0


                Me.Label1.Text = "Question10"
                Me.Label2.Text = ("When Grandfather was dying, it was Grandmother who kept the whole family …………..")
                Me.RadioButton1.Text = "against."
                Me.RadioButton2.Text = "over."
                Me.RadioButton3.Text = "together."
                Me.RadioButton4.Text = "apart."
                Timer1.Start()
                j = j + 1


            ElseIf j = 11 Then
                If RadioButton3.Checked Then
                    note = note + 1
                End If
                Me.Hide()
                Validation4.Show()

                If note >= 7 Then
                    Validation4.Label1.Text = "Félicitation vous aviez eu la note de " & note & "pour ce niveau "
                Else
                    Validation4.Label1.Text = "Désole vous aviez eu la note de " & note & "pour ce niveau "
                End If

            End If
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim i As DialogResult
        i = MessageBox.Show("confirm if you want to exit", "Login System", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If i = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class