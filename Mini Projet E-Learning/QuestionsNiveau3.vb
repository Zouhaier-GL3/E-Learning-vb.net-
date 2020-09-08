Public Class QuestionsNiveau3
    Public note As Integer
    Dim j As Integer = 1
    Private Sub QuestionsNiveau3_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        ProgressBar1.Value = 0


        Label1.Text = ("question1")
        Label2.Text = ("I think we should ….. a start.")

        RadioButton1.Text = ("have")
        RadioButton2.Text = ("get")
        RadioButton3.Text = ("do")
        RadioButton4.Text = ("make")
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
            Me.Label2.Text = ("If we got a virus on our network, we ….. all our data.")
            Me.RadioButton1.Text = "will lose"
            Me.RadioButton2.Text = "would loose"
            Me.RadioButton3.Text = "would lose"
            Me.RadioButton4.Text = "will lost"
            Timer1.Start()
            j = j + 1

        ElseIf j = 3 Then
            If RadioButton3.Checked Then
                note = note + 1
            End If

            RadioButton1.Checked = False
            RadioButton2.Checked = False
            RadioButton3.Checked = False
            RadioButton4.Checked = False
            ProgressBar1.Value = 0


            Me.Label1.Text = "Question3"
            Me.Label2.Text = (“I spent ….. talking to Jane and then I went home.")
            Me.RadioButton1.Text = "a time"
            Me.RadioButton2.Text = "some time"
            Me.RadioButton3.Text = "sometimes"
            Me.RadioButton4.Text = "any time"
            Timer1.Start()
            j = j + 1


        ElseIf j = 4 Then
            If RadioButton2.Checked Then
                note = note + 1
            End If

            RadioButton1.Checked = False
            RadioButton2.Checked = False
            RadioButton3.Checked = False
            RadioButton4.Checked = False
            ProgressBar1.Value = 0


            Me.Label1.Text = "Question4"
            Me.Label2.Text = ("She is so patronising and constantly trying to …...")
            Me.RadioButton1.Text = "put me up"
            Me.RadioButton2.Text = "put me aside"
            Me.RadioButton3.Text = "put me off"
            Me.RadioButton4.Text = "put me down"
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
            Me.Label2.Text = ("People do not smoke as much as they …...")
            Me.RadioButton1.Text = "used to"
            Me.RadioButton2.Text = "used to be"
            Me.RadioButton3.Text = "used"
            Me.RadioButton4.Text = "were used to"
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
            Me.Label2.Text = ("She bored everybody by delivering ….. on the Philosophy of Human Geography.")
            Me.RadioButton1.Text = "a two-hours lecture"
            Me.RadioButton2.Text = "a lecture of two hours"
            Me.RadioButton3.Text = "a lecture two hours"
            Me.RadioButton4.Text = "a two-hour lecture"
            Timer1.Start()
            j = j + 1

        ElseIf j = 7 Then
            If RadioButton4.Checked Then
                note = note + 1
            End If

            RadioButton1.Checked = False
            RadioButton2.Checked = False
            RadioButton3.Checked = False
            RadioButton4.Checked = False
            ProgressBar1.Value = 0


            Me.Label1.Text = "Question7"
            Me.Label2.Text = ("Sales ….. rising continuously for 10 months.")
            Me.RadioButton1.Text = "has been"
            Me.RadioButton2.Text = "will be"
            Me.RadioButton3.Text = "have been"
            Me.RadioButton4.Text = "are being"
            Timer1.Start()
            j = j + 1

        ElseIf j = 8 Then
            If RadioButton1.Checked Then
                note = note + 1
            End If

            RadioButton1.Checked = False
            RadioButton2.Checked = False
            RadioButton3.Checked = False
            RadioButton4.Checked = False
            ProgressBar1.Value = 0


            Me.Label1.Text = "Question8"
            Me.Label2.Text = ("This area is quite noisy ….. night.")
            Me.RadioButton1.Text = "in"
            Me.RadioButton2.Text = "at"
            Me.RadioButton3.Text = "during"
            Me.RadioButton4.Text = "on the"
            Timer1.Start()
            j = j + 1

        ElseIf j = 9 Then
            If RadioButton2.Checked Then
                note = note + 1
            End If

            RadioButton1.Checked = False
            RadioButton2.Checked = False
            RadioButton3.Checked = False
            RadioButton4.Checked = False
            ProgressBar1.Value = 0


            Me.Label1.Text = "Question9"
            Me.Label2.Text = ("….. I wasn’t feeling very well, I still went to the party.")
            Me.RadioButton1.Text = "Even though"
            Me.RadioButton2.Text = "Whether"
            Me.RadioButton3.Text = "Thought"
            Me.RadioButton4.Text = "Despite"
            Timer1.Start()
            j = j + 1

        ElseIf j = 10 Then
            If RadioButton1.Checked Then
                note = note + 1
            End If

            RadioButton1.Checked = False
            RadioButton2.Checked = False
            RadioButton3.Checked = False
            RadioButton4.Checked = False
            ProgressBar1.Value = 0


            Me.Label1.Text = "Question10"
            Me.Label2.Text = ("He is always taking the ….. for my accomplishments")
            Me.RadioButton1.Text = "biscuit"
            Me.RadioButton2.Text = "limelight"
            Me.RadioButton3.Text = "credit"
            Me.RadioButton4.Text = "stage"
            Timer1.Start()
            j = j + 1


        ElseIf j = 11 Then
            If RadioButton3.Checked Then
                note = note + 1
            End If
            Me.Hide()
            validation3.Show()

            If note >= 7 Then
                validation3.Label1.Text = "Félicitation vous aviez eu la note de " & note & "pour ce niveau "
            Else
                validation3.Label1.Text = "Désole vous aviez eu la note de " & note & "pour ce niveau "
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
                Me.Label2.Text = ("If we got a virus on our network, we ….. all our data.")
                Me.RadioButton1.Text = "will lose"
                Me.RadioButton2.Text = "would loose"
                Me.RadioButton3.Text = "would lose"
                Me.RadioButton4.Text = "will lost"
                Timer1.Start()
                j = j + 1

            ElseIf j = 3 Then
                If RadioButton3.Checked Then
                    note = note + 1
                End If

                RadioButton1.Checked = False
                RadioButton2.Checked = False
                RadioButton3.Checked = False
                RadioButton4.Checked = False
                ProgressBar1.Value = 0


                Me.Label1.Text = "Question3"
                Me.Label2.Text = (“I spent ….. talking to Jane and then I went home.")
                Me.RadioButton1.Text = "a time"
                Me.RadioButton2.Text = "some time"
                Me.RadioButton3.Text = "sometimes"
                Me.RadioButton4.Text = "any time"
                Timer1.Start()
                j = j + 1


            ElseIf j = 4 Then
                If RadioButton2.Checked Then
                    note = note + 1
                End If

                RadioButton1.Checked = False
                RadioButton2.Checked = False
                RadioButton3.Checked = False
                RadioButton4.Checked = False
                ProgressBar1.Value = 0


                Me.Label1.Text = "Question4"
                Me.Label2.Text = ("She is so patronising and constantly trying to …...")
                Me.RadioButton1.Text = "put me up"
                Me.RadioButton2.Text = "put me aside"
                Me.RadioButton3.Text = "put me off"
                Me.RadioButton4.Text = "put me down"
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
                Me.Label2.Text = ("People do not smoke as much as they …...")
                Me.RadioButton1.Text = "used to"
                Me.RadioButton2.Text = "used to be"
                Me.RadioButton3.Text = "used"
                Me.RadioButton4.Text = "were used to"
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
                Me.Label2.Text = ("She bored everybody by delivering ….. on the Philosophy of Human Geography.")
                Me.RadioButton1.Text = "a two-hours lecture"
                Me.RadioButton2.Text = "a lecture of two hours"
                Me.RadioButton3.Text = "a lecture two hours"
                Me.RadioButton4.Text = "a two-hour lecture"
                Timer1.Start()
                j = j + 1

            ElseIf j = 7 Then
                If RadioButton4.Checked Then
                    note = note + 1
                End If

                RadioButton1.Checked = False
                RadioButton2.Checked = False
                RadioButton3.Checked = False
                RadioButton4.Checked = False
                ProgressBar1.Value = 0


                Me.Label1.Text = "Question7"
                Me.Label2.Text = ("Sales ….. rising continuously for 10 months.")
                Me.RadioButton1.Text = "has been"
                Me.RadioButton2.Text = "will be"
                Me.RadioButton3.Text = "have been"
                Me.RadioButton4.Text = "are being"
                Timer1.Start()
                j = j + 1

            ElseIf j = 8 Then
                If RadioButton1.Checked Then
                    note = note + 1
                End If

                RadioButton1.Checked = False
                RadioButton2.Checked = False
                RadioButton3.Checked = False
                RadioButton4.Checked = False
                ProgressBar1.Value = 0


                Me.Label1.Text = "Question8"
                Me.Label2.Text = ("This area is quite noisy ….. night.")
                Me.RadioButton1.Text = "in"
                Me.RadioButton2.Text = "at"
                Me.RadioButton3.Text = "during"
                Me.RadioButton4.Text = "on the"
                Timer1.Start()
                j = j + 1

            ElseIf j = 9 Then
                If RadioButton2.Checked Then
                    note = note + 1
                End If

                RadioButton1.Checked = False
                RadioButton2.Checked = False
                RadioButton3.Checked = False
                RadioButton4.Checked = False
                ProgressBar1.Value = 0


                Me.Label1.Text = "Question9"
                Me.Label2.Text = ("….. I wasn’t feeling very well, I still went to the party.")
                Me.RadioButton1.Text = "Even though"
                Me.RadioButton2.Text = "Whether"
                Me.RadioButton3.Text = "Thought"
                Me.RadioButton4.Text = "Despite"
                Timer1.Start()
                j = j + 1

            ElseIf j = 10 Then
                If RadioButton1.Checked Then
                    note = note + 1
                End If

                RadioButton1.Checked = False
                RadioButton2.Checked = False
                RadioButton3.Checked = False
                RadioButton4.Checked = False
                ProgressBar1.Value = 0


                Me.Label1.Text = "Question10"
                Me.Label2.Text = ("He is always taking the ….. for my accomplishments")
                Me.RadioButton1.Text = "biscuit"
                Me.RadioButton2.Text = "limelight"
                Me.RadioButton3.Text = "credit"
                Me.RadioButton4.Text = "stage"
                Timer1.Start()
                j = j + 1


            ElseIf j = 11 Then
                If RadioButton3.Checked Then
                    note = note + 1
                End If
                Me.Hide()
                validation3.Show()

                If note >= 7 Then
                    validation3.Label1.Text = "Félicitation vous aviez eu la note de " & note & "pour ce niveau "
                Else
                    validation3.Label1.Text = "Désole vous aviez eu la note de " & note & "pour ce niveau "
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