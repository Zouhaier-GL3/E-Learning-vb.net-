Public Class QuestionsNiveau2
    Public note As Integer
    Dim j As Integer = 1
    Private Sub QuestionsNiveau2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        ProgressBar1.Value = 0


        Label1.Text = ("question1")
        Label2.Text = ("Malcolm has taken part ….. the competition for the tenth consecutive time.")

        RadioButton1.Text = ("at")
        RadioButton2.Text = ("in")
        RadioButton3.Text = ("for")
        RadioButton4.Text = ("with")
        Timer1.Start()
        j = j + 1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If j = 2 Then

            If RadioButton2.Checked Then
                note = note + 1
            End If

            RadioButton1.Checked = False
            RadioButton2.Checked = False
            RadioButton3.Checked = False
            RadioButton4.Checked = False
            ProgressBar1.Value = 0


            Me.Label1.Text = "Question2"
            Me.Label2.Text = ("We have ….. in-depth research into Molecular Biology.")
            Me.RadioButton1.Text = "did"
            Me.RadioButton2.Text = "made"
            Me.RadioButton3.Text = "carried out"
            Me.RadioButton4.Text = "conduced"
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
            Me.Label2.Text = (“... do you go to the theatre Once in a blue moon.")
            Me.RadioButton1.Text = "Whenever"
            Me.RadioButton2.Text = "How often"
            Me.RadioButton3.Text = "How about"
            Me.RadioButton4.Text = "How long"
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
            Me.Label2.Text = ("If the syllabus ….. changed, we would progress in marketing much faster.")
            Me.RadioButton1.Text = "is to be"
            Me.RadioButton2.Text = "has been"
            Me.RadioButton3.Text = "were"
            Me.RadioButton4.Text = "be"
            Timer1.Start()
            j = j + 1

        ElseIf j = 5 Then
            If RadioButton3.Checked Then
                note = note + 1
            End If

            RadioButton1.Checked = False
            RadioButton2.Checked = False
            RadioButton3.Checked = False
            RadioButton4.Checked = False
            ProgressBar1.Value = 0

            Me.Label1.Text = "Question5"
            Me.Label2.Text = ("I have no time. Well, you are just going to have to ….. the time for me then.")
            Me.RadioButton1.Text = "do"
            Me.RadioButton2.Text = "make"
            Me.RadioButton3.Text = "have"
            Me.RadioButton4.Text = "be"
            Timer1.Start()
            j = j + 1

        ElseIf j = 6 Then
            If RadioButton2.Checked Then
                note = note + 1
            End If

            RadioButton1.Checked = False
            RadioButton2.Checked = False
            RadioButton3.Checked = False
            RadioButton4.Checked = False
            ProgressBar1.Value = 0


            Me.Label1.Text = "Question6"
            Me.Label2.Text = ("If you are in search of a bargain at the sales, you ….. better get there early.")
            Me.RadioButton1.Text = "should"
            Me.RadioButton2.Text = "had"
            Me.RadioButton3.Text = "ought"
            Me.RadioButton4.Text = "did"
            Timer1.Start()
            j = j + 1

        ElseIf j = 7 Then
            If RadioButton2.Checked Then
                note = note + 1
            End If

            RadioButton1.Checked = False
            RadioButton2.Checked = False
            RadioButton3.Checked = False
            RadioButton4.Checked = False
            ProgressBar1.Value = 0


            Me.Label1.Text = "Question7"
            Me.Label2.Text = ("I’ll take care of the children while you ….. your hair done.")
            Me.RadioButton1.Text = "would get"
            Me.RadioButton2.Text = "will be getting"
            Me.RadioButton3.Text = "are getting"
            Me.RadioButton4.Text = "got"
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
            Me.Label2.Text = ("The sofa is so big that it takes ….. half the living room.")
            Me.RadioButton1.Text = "off"
            Me.RadioButton2.Text = "on"
            Me.RadioButton3.Text = "up"
            Me.RadioButton4.Text = "in"
            Timer1.Start()
            j = j + 1

        ElseIf j = 9 Then
            If RadioButton3.Checked Then
                note = note + 1
            End If

            RadioButton1.Checked = False
            RadioButton2.Checked = False
            RadioButton3.Checked = False
            RadioButton4.Checked = False
            ProgressBar1.Value = 0


            Me.Label1.Text = "Question9"
            Me.Label2.Text = ("You need to read a lot to keep ….. with new developments in the area.")
            Me.RadioButton1.Text = "out"
            Me.RadioButton2.Text = "on"
            Me.RadioButton3.Text = "in"
            Me.RadioButton4.Text = "up"
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
            Me.Label2.Text = ("We guarantee ….. the goods by the end of the week.")
            Me.RadioButton1.Text = "to be delivering"
            Me.RadioButton2.Text = "to deliver"
            Me.RadioButton3.Text = "deliver"
            Me.RadioButton4.Text = "delivering"
            Timer1.Start()
            j = j + 1

            '--------------------------------------------------------------------------------
        ElseIf j = 11 Then
            If RadioButton2.Checked Then
                note = note + 1
            End If
            Me.Hide()
            validation2.Show()

            If note >= 7 Then
                validation2.Label1.Text = "Félicitation vous aviez eu la note de " & note & "pour ce niveau "
            Else
                validation2.Label1.Text = "Désole vous aviez eu la note de " & note & "pour ce niveau "
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

                If RadioButton2.Checked Then
                    note = note + 1
                End If

                RadioButton1.Checked = False
                RadioButton2.Checked = False
                RadioButton3.Checked = False
                RadioButton4.Checked = False
                ProgressBar1.Value = 0

                Me.Label1.Text = "Question2"
                Me.Label2.Text = ("We have ….. in-depth research into Molecular Biology.")
                Me.RadioButton1.Text = "did"
                Me.RadioButton2.Text = "made"
                Me.RadioButton3.Text = "carried out"
                Me.RadioButton4.Text = "conduced"
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
                Me.Label2.Text = (“... do you go to the theatre Once in a blue moon.")
                Me.RadioButton1.Text = "Whenever"
                Me.RadioButton2.Text = "How often"
                Me.RadioButton3.Text = "How about"
                Me.RadioButton4.Text = "How long"
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
                Me.Label2.Text = ("If the syllabus ….. changed, we would progress in marketing much faster.")
                Me.RadioButton1.Text = "is to be"
                Me.RadioButton2.Text = "has been"
                Me.RadioButton3.Text = "were"
                Me.RadioButton4.Text = "be"
                Timer1.Start()
                j = j + 1

            ElseIf j = 5 Then
                If RadioButton3.Checked Then
                    note = note + 1
                End If

                RadioButton1.Checked = False
                RadioButton2.Checked = False
                RadioButton3.Checked = False
                RadioButton4.Checked = False
                ProgressBar1.Value = 0

                Me.Label1.Text = "Question5"
                Me.Label2.Text = ("I have no time. Well, you are just going to have to ….. the time for me then.")
                Me.RadioButton1.Text = "do"
                Me.RadioButton2.Text = "make"
                Me.RadioButton3.Text = "have"
                Me.RadioButton4.Text = "be"
                Timer1.Start()
                j = j + 1

            ElseIf j = 6 Then
                If RadioButton2.Checked Then
                    note = note + 1
                End If

                RadioButton1.Checked = False
                RadioButton2.Checked = False
                RadioButton3.Checked = False
                RadioButton4.Checked = False
                ProgressBar1.Value = 0

                Me.Label1.Text = "Question6"
                Me.Label2.Text = ("If you are in search of a bargain at the sales, you ….. better get there early.")
                Me.RadioButton1.Text = "should"
                Me.RadioButton2.Text = "had"
                Me.RadioButton3.Text = "ought"
                Me.RadioButton4.Text = "did"
                Timer1.Start()
                j = j + 1

            ElseIf j = 7 Then
                If RadioButton2.Checked Then
                    note = note + 1
                End If

                RadioButton1.Checked = False
                RadioButton2.Checked = False
                RadioButton3.Checked = False
                RadioButton4.Checked = False
                ProgressBar1.Value = 0

                Me.Label1.Text = "Question7"
                Me.Label2.Text = ("I’ll take care of the children while you ….. your hair done.")
                Me.RadioButton1.Text = "would get"
                Me.RadioButton2.Text = "will be getting"
                Me.RadioButton3.Text = "are getting"
                Me.RadioButton4.Text = "got"
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
                Me.Label2.Text = ("The sofa is so big that it takes ….. half the living room.")
                Me.RadioButton1.Text = "off"
                Me.RadioButton2.Text = "on"
                Me.RadioButton3.Text = "up"
                Me.RadioButton4.Text = "in"
                Timer1.Start()
                j = j + 1

            ElseIf j = 9 Then
                If RadioButton3.Checked Then
                    note = note + 1
                End If

                RadioButton1.Checked = False
                RadioButton2.Checked = False
                RadioButton3.Checked = False
                RadioButton4.Checked = False
                ProgressBar1.Value = 0

                Me.Label1.Text = "Question9"
                Me.Label2.Text = ("You need to read a lot to keep ….. with new developments in the area.")
                Me.RadioButton1.Text = "out"
                Me.RadioButton2.Text = "on"
                Me.RadioButton3.Text = "in"
                Me.RadioButton4.Text = "up"
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
                Me.Label2.Text = ("We guarantee ….. the goods by the end of the week.")
                Me.RadioButton1.Text = "to be delivering"
                Me.RadioButton2.Text = "to deliver"
                Me.RadioButton3.Text = "deliver"
                Me.RadioButton4.Text = "delivering"
                Timer1.Start()
                j = j + 1

                '--------------------------------------------------------------------------------
            ElseIf j = 11 Then
                If RadioButton2.Checked Then
                    note = note + 1
                End If
                Me.Hide()
                validation2.Show()

                If note >= 7 Then
                    validation2.Label1.Text = "Félicitation vous aviez eu la note de " & note & "pour ce niveau "
                Else
                    validation2.Label1.Text = "Désole vous aviez eu la note de " & note & "pour ce niveau "
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