Imports System.Net.Http

Public Class Form1
    Shared random As New Random()

    Private Sub Button37_Click(sender As Object, e As EventArgs) Handles Button37.Click
        Dim i As Integer
        Dim choice As Integer
        TextBox1.Visible = True
        Label2.Visible = True
        For i = 0 To 36
            TextBox1.Text = (random.Next(1, 36))
        Next

        choice = Int(TextBox5.Text)
        Dim result = Int(TextBox1.Text)
        Select Case choice
            Case 1
                If TextBox1.Text = 1 Then
                    Button1.BackColor = Color.Green
                ElseIf TextBox1.Text = 2 Then
                    Button2.BackColor = Color.Green
                ElseIf TextBox1.Text = 3 Then
                    Button3.BackColor = Color.Green
                ElseIf TextBox1.Text = 4 Then
                    Button4.BackColor = Color.Green
                ElseIf TextBox1.Text = 5 Then
                    Button5.BackColor = Color.Green
                ElseIf TextBox1.Text = 6 Then
                    Button6.BackColor = Color.Green
                ElseIf TextBox1.Text = 7 Then
                    Button7.BackColor = Color.Green
                ElseIf TextBox1.Text = 8 Then
                    Button8.BackColor = Color.Green
                ElseIf TextBox1.Text = 9 Then
                    Button9.BackColor = Color.Green
                ElseIf TextBox1.Text = 10 Then
                    Button10.BackColor = Color.Green
                ElseIf TextBox1.Text = 11 Then
                    Button11.BackColor = Color.Green
                ElseIf TextBox1.Text = 12 Then
                    Button12.BackColor = Color.Green
                ElseIf TextBox1.Text = 13 Then
                    Button13.BackColor = Color.Green
                ElseIf TextBox1.Text = 14 Then
                    Button14.BackColor = Color.Green
                ElseIf TextBox1.Text = 14 Then
                    Button14.BackColor = Color.Green
                ElseIf TextBox1.Text = 15 Then
                    Button15.BackColor = Color.Green
                ElseIf TextBox1.Text = 16 Then
                    Button16.BackColor = Color.Green
                ElseIf TextBox1.Text = 17 Then
                    Button17.BackColor = Color.Green
                ElseIf TextBox1.Text = 18 Then
                    Button18.BackColor = Color.Green
                ElseIf TextBox1.Text = 19 Then
                    Button19.BackColor = Color.Green
                ElseIf TextBox1.Text = 20 Then
                    Button20.BackColor = Color.Green
                ElseIf TextBox1.Text = 21 Then
                    Button21.BackColor = Color.Green
                ElseIf TextBox1.Text = 22 Then
                    Button22.BackColor = Color.Green
                ElseIf TextBox1.Text = 23 Then
                    Button23.BackColor = Color.Green
                ElseIf TextBox1.Text = 24 Then
                    Button24.BackColor = Color.Green
                ElseIf TextBox1.Text = 25 Then
                    Button25.BackColor = Color.Green
                ElseIf TextBox1.Text = 26 Then
                    Button26.BackColor = Color.Green
                ElseIf TextBox1.Text = 27 Then
                    Button27.BackColor = Color.Green
                ElseIf TextBox1.Text = 28 Then
                    Button28.BackColor = Color.Green
                ElseIf TextBox1.Text = 29 Then
                    Button29.BackColor = Color.Green
                ElseIf TextBox1.Text = 30 Then
                    Button30.BackColor = Color.Green
                ElseIf TextBox1.Text = 31 Then
                    Button31.BackColor = Color.Green
                ElseIf TextBox1.Text = 32 Then
                    Button32.BackColor = Color.Green
                ElseIf TextBox1.Text = 33 Then
                    Button33.BackColor = Color.Green
                ElseIf TextBox1.Text = 34 Then
                    Button34.BackColor = Color.Green
                ElseIf TextBox1.Text = 35 Then
                    Button35.BackColor = Color.Green
                Else
                    Button36.BackColor = Color.Green
                End If
                If TextBox1.Text = TextBox2.Text Then
                    'TextBox4.Text = 35 * (Int(TextBox3.Text))
                    MsgBox("Congratulations for Jackpot!!!!", MsgBoxStyle.MsgBoxRight, "WOW!!!!")

                Else
                    'TextBox4.Text = 0
                    MsgBox("Better Luck Next Time :)", MsgBoxStyle.MsgBoxRight, "SAD:(")
                    'TextBox4.Text = " "
                    TextBox3.Text = " "
                    TextBox2.Text = " "
                    TextBox1.Text = " "
                    TextBox5.Text = " "

                End If
            Case 2
                If result = 1 Or result = 2 Or result = 3 Or result = 4 Or result = 5 Or result = 6 Or result = 7 Or result = 8 Or result = 9 Or result = 10 Or result = 11 Or result = 12 Then
                    'TextBox4.Text = 2 * (Int(TextBox3.Text))
                    MsgBox("Congratulations!!!!   Your Money is Doubled", MsgBoxStyle.MsgBoxRight, "WOW!!!!")
                Else
                    'TextBox4.Text = 0
                    MsgBox("Better Luck Next Time :)", MsgBoxStyle.MsgBoxRight, "SAD:(")
                    'TextBox4.Text = " "
                    TextBox3.Text = " "
                    TextBox2.Text = " "
                    TextBox1.Text = " "
                    TextBox5.Text = " "
                End If
            Case 3

                If result = 13 Or result = 14 Or result = 15 Or result = 16 Or result = 17 Or result = 18 Or result = 19 Or result = 20 Or result = 21 Or result = 22 Or result = 23 Or result = 24 Then
                    'TextBox4.Text = 2 * (Int(TextBox3.Text))
                    MsgBox("Congratulations!!!!   Your Money is Doubled", MsgBoxStyle.MsgBoxRight, "WOW!!!!")
                Else

                    'TextBox4.Text = 0
                    MsgBox("Better Luck Next Time :)", MsgBoxStyle.MsgBoxRight, "SAD:(")
                    'TextBox4.Text = " "
                    TextBox3.Text = " "
                    TextBox2.Text = " "
                    TextBox1.Text = " "
                    TextBox5.Text = " "
                End If
            Case 4
                If result = 25 Or result = 26 Or result = 27 Or result = 28 Or result = 29 Or result = 30 Or result = 31 Or result = 32 Or result = 33 Or result = 34 Or result = 35 Or result = 36 Then
                    'TextBox4.Text = 2 * (Int(TextBox3.Text))
                    MsgBox("Congratulations!!!!   Your Money is Doubled", MsgBoxStyle.MsgBoxRight, "WOW!!!!")
                Else
                    'TextBox4.Text = 0
                    MsgBox("Better Luck Next Time :)", MsgBoxStyle.MsgBoxRight, "SAD:(")
                    'TextBox4.Text = " "
                    TextBox3.Text = " "
                    TextBox2.Text = " "
                    TextBox1.Text = " "
                    TextBox5.Text = " "
                End If
            Case 5
                If TextBox2.Text = "Even" Or TextBox2.Text = "EVEN" Or TextBox2.Text = "even" Then
                    If TextBox1.Text Mod 2 = 0 Then
                        MsgBox("'Even'    Congratulations!!!!   Your Money is Trippled", MsgBoxStyle.MsgBoxRight, "WOW!!!!")
                    Else
                        'TextBox4.Text = 0
                        MsgBox("Better Luck Next Time :)", MsgBoxStyle.MsgBoxRight, "SAD:(")
                        'TextBox4.Text = " "
                        TextBox3.Text = " "
                        TextBox2.Text = " "
                        TextBox1.Text = " "
                        TextBox5.Text = " "
                    End If
                End If
                If TextBox2.Text = "Odd" Or TextBox2.Text = "ODD" Or TextBox2.Text = "odd" Then
                    If TextBox1.Text Mod 2 = 1 Then
                        MsgBox("'Odd'    Congratulations!!!!   Your Money is Trippled", MsgBoxStyle.MsgBoxRight, "WOW!!!!")
                    Else
                        'TextBox4.Text = 0
                        MsgBox("Better Luck Next Time :)", MsgBoxStyle.MsgBoxRight, "SAD:(")
                        'TextBox4.Text = " "
                        TextBox3.Text = " "
                        TextBox2.Text = " "
                        TextBox1.Text = " "
                        TextBox5.Text = " "
                    End If

                End If
            Case 6
                If TextBox2.Text = "Black" Or TextBox2.Text = "BLACK" Or TextBox2.Text = "black" Then
                    If TextBox1.Text Mod 2 = 1 Then
                        MsgBox("'Black'   Congratulations!!!!   Your Money is Trippled", MsgBoxStyle.MsgBoxRight, "WOW!!!!")
                    Else
                        'TextBox4.Text = 0
                        MsgBox("Better Luck Next Time :)", MsgBoxStyle.MsgBoxRight, "SAD:(")
                        'TextBox4.Text = " "
                        TextBox3.Text = " "
                        TextBox2.Text = " "
                        TextBox1.Text = " "
                        TextBox5.Text = " "
                    End If
                End If
                If TextBox2.Text = "Red" Or TextBox2.Text = "RED" Or TextBox2.Text = "red" Then
                    If TextBox1.Text Mod 2 = 0 Then
                        MsgBox("'Red'    Congratulations!!!!   Your Money is Trippled", MsgBoxStyle.MsgBoxRight, "WOW!!!!")
                    Else
                        'TextBox4.Text = 0
                        MsgBox("Better Luck Next Time :)", MsgBoxStyle.MsgBoxRight, "SAD:(")
                        'TextBox4.Text = " "
                        TextBox3.Text = " "
                        TextBox2.Text = " "
                        TextBox1.Text = " "
                        TextBox5.Text = " "
                    End If

                End If

            Case Else
                TextBox1.Text = " "
                MsgBox("Invalid Selection", MsgBoxStyle.MsgBoxRight, "Oops....")

        End Select



    End Sub

    Private Sub Button38_Click(sender As Object, e As EventArgs) Handles Button38.Click
        TextBox1.Visible = False
        Label2.Visible = False
        'Label4.Visible = False
        'TextBox4.Visible = False
        Button1.BackColor = Color.Black
        Button2.BackColor = Color.Red
        Button3.BackColor = Color.Black
        Button4.BackColor = Color.Red
        Button5.BackColor = Color.Black
        Button6.BackColor = Color.Red
        Button7.BackColor = Color.Black
        Button8.BackColor = Color.Red
        Button9.BackColor = Color.Black
        Button10.BackColor = Color.Red
        Button11.BackColor = Color.Black
        Button12.BackColor = Color.Red
        Button13.BackColor = Color.Black
        Button14.BackColor = Color.Red
        Button15.BackColor = Color.Black
        Button16.BackColor = Color.Red
        Button17.BackColor = Color.Black
        Button18.BackColor = Color.Red
        Button19.BackColor = Color.Black
        Button20.BackColor = Color.Red
        Button21.BackColor = Color.Black
        Button22.BackColor = Color.Red
        Button23.BackColor = Color.Black
        Button24.BackColor = Color.Red
        Button25.BackColor = Color.Black
        Button26.BackColor = Color.Red
        Button27.BackColor = Color.Black
        Button28.BackColor = Color.Red
        Button29.BackColor = Color.Black
        Button30.BackColor = Color.Red
        Button31.BackColor = Color.Black
        Button32.BackColor = Color.Red
        Button33.BackColor = Color.Black
        Button34.BackColor = Color.Red
        Button35.BackColor = Color.Black
        Button36.BackColor = Color.Red
        TextBox3.Text = " "
        TextBox2.Text = " "
        TextBox1.Text = " "
        TextBox5.Text = " "
        Application.Restart()
    End Sub

End Class
