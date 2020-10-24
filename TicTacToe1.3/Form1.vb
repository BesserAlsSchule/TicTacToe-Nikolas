Public Class Form1

    Dim Player1 As Char
    Dim Player2 As Char
    Dim Sieger1 As Object
    Dim Sieger2 As Object


    Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles BtnStart.Click
        BtnSpielerEins.Enabled = True
        BtnSpielerZwei.Enabled = True
        BtnNeustart.Enabled = True

        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = True
        Button6.Enabled = True
        Button7.Enabled = True
        Button8.Enabled = True
        Button9.Enabled = True

        MessageBox.Show("Welcher Spieler Beginnt?")

    End Sub

    Private Sub BtnSpielerEins_Click(sender As Object, e As EventArgs) Handles BtnSpielerEins.Click
        BtnSpielerZwei.Enabled = False

        BtnStart.Enabled = False
        Player1 = "X"
        Player2 = "O"

    End Sub

    Private Sub BtnSpielerZwei_Click(sender As Object, e As EventArgs) Handles BtnSpielerZwei.Click
        BtnSpielerEins.Enabled = False

        BtnStart.Enabled = False
        Player2 = "O"
        Player1 = "X"

    End Sub

    Private Sub BtnNeustart_Click(sender As Object, e As EventArgs) Handles BtnNeustart.Click

        Button1.Text = " "
        Button2.Text = " "
        Button3.Text = " "
        Button4.Text = " "
        Button5.Text = " "
        Button6.Text = " "
        Button7.Text = " "
        Button8.Text = " "
        Button9.Text = " "

        BtnStart.Enabled = True

        BtnSpielerEins.Enabled = False
        BtnSpielerZwei.Enabled = False

        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
        Button6.Enabled = False
        Button7.Enabled = False
        Button8.Enabled = False
        Button9.Enabled = False


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button1.TextChanged


        If BtnSpielerEins.Enabled = True Then

            Button1.Text = Player1

        Else
            Button1.Text = Player2

        End If

        If Button1.Text = "X" Then
            BtnSpielerEins.Enabled = False
            BtnSpielerZwei.Enabled = True

        Else
            If Button1.Text = "O" Then
                BtnSpielerZwei.Enabled = False
                BtnSpielerEins.Enabled = True
            End If

        End If

        Button1.Enabled = False

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If BtnSpielerEins.Enabled = True Then

            Button2.Text = Player1

        Else
            Button2.Text = Player2

        End If

        If Button2.Text = "X" Then
            BtnSpielerEins.Enabled = False
            BtnSpielerZwei.Enabled = True

        Else
            If Button2.Text = "O" Then
                BtnSpielerZwei.Enabled = False
                BtnSpielerEins.Enabled = True
            End If

        End If

        Button2.Enabled = False

    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If BtnSpielerEins.Enabled = True Then

            Button3.Text = Player1

        Else
            Button3.Text = Player2

        End If

        If Button3.Text = "X" Then
            BtnSpielerEins.Enabled = False
            BtnSpielerZwei.Enabled = True

        Else
            If Button3.Text = "O" Then
                BtnSpielerZwei.Enabled = False
                BtnSpielerEins.Enabled = True
            End If

        End If

        Button3.Enabled = False



    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If BtnSpielerEins.Enabled = True Then

            Button4.Text = Player1

        Else
            Button4.Text = Player2

        End If

        If Button4.Text = "X" Then
            BtnSpielerEins.Enabled = False
            BtnSpielerZwei.Enabled = True

        Else
            If Button4.Text = "O" Then
                BtnSpielerZwei.Enabled = False
                BtnSpielerEins.Enabled = True
            End If

        End If

        Button4.Enabled = False

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If BtnSpielerEins.Enabled = True Then

            Button5.Text = Player1

        Else
            Button5.Text = Player2

        End If

        If Button5.Text = "X" Then
            BtnSpielerEins.Enabled = False
            BtnSpielerZwei.Enabled = True

        Else
            If Button5.Text = "O" Then
                BtnSpielerZwei.Enabled = False
                BtnSpielerEins.Enabled = True
            End If

        End If

        Button5.Enabled = False

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If BtnSpielerEins.Enabled = True Then

            Button6.Text = Player1

        Else
            Button6.Text = Player2

        End If

        If Button6.Text = "X" Then
            BtnSpielerEins.Enabled = False
            BtnSpielerZwei.Enabled = True

        Else
            If Button6.Text = "O" Then
                BtnSpielerZwei.Enabled = False
                BtnSpielerEins.Enabled = True
            End If

        End If

        Button6.Enabled = False

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If BtnSpielerEins.Enabled = True Then

            Button7.Text = Player1

        Else
            Button7.Text = Player2

        End If

        If Button7.Text = "X" Then
            BtnSpielerEins.Enabled = False
            BtnSpielerZwei.Enabled = True

        Else
            If Button7.Text = "O" Then
                BtnSpielerZwei.Enabled = False
                BtnSpielerEins.Enabled = True
            End If

        End If

        Button7.Enabled = False

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If BtnSpielerEins.Enabled = True Then

            Button8.Text = Player1

        Else
            Button8.Text = Player2

        End If

        If Button8.Text = "X" Then
            BtnSpielerEins.Enabled = False
            BtnSpielerZwei.Enabled = True

        Else
            If Button8.Text = "O" Then
                BtnSpielerZwei.Enabled = False
                BtnSpielerEins.Enabled = True
            End If

        End If

        Button8.Enabled = False

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If BtnSpielerEins.Enabled = True Then

            Button9.Text = Player1

        Else
            Button9.Text = Player2

        End If

        If Button9.Text = "X" Then
            BtnSpielerEins.Enabled = False
            BtnSpielerZwei.Enabled = True

        Else
            If Button9.Text = "O" Then
                BtnSpielerZwei.Enabled = False
                BtnSpielerEins.Enabled = True
            End If

        End If

        Button9.Enabled = False

    End Sub

    Private Sub BtnEnde_Click(sender As Object, e As EventArgs) Handles BtnEnde.Click
        MessageBox.Show("Das Programm wird beendet")

        Console.ReadLine()

        End

    End Sub

    Private Sub BtnErgebnis_Click(sender As Object, e As EventArgs) Handles BtnErgebnis.Click



        If Button1.Text = "X" AndAlso Button2.Text = "X" AndAlso Button3.Text = "X" Then
            MessageBox.Show("Spieler1 gewinnt!")


        ElseIf Button1.Text = "O" AndAlso Button2.Text = "O" AndAlso Button3.Text = "O" Then
            MessageBox.Show("Spieler2 gewinnt!")


        ElseIf Button1.Text = "X" AndAlso Button4.Text = "X" AndAlso Button7.Text = "X" Then
            MessageBox.Show("Spieler1 gewinnt!")

        ElseIf Button1.Text = "O" AndAlso Button4.Text = "O" AndAlso Button7.Text = "O" Then
            MessageBox.Show("Spieler2 gewinnt!")

        ElseIf Button4.Text = "X" AndAlso Button5.Text = "X" AndAlso Button6.Text = "X" Then
            MessageBox.Show("Spieler1 gewinnt!")

        ElseIf Button4.Text = "O" AndAlso Button5.Text = "O" AndAlso Button6.Text = "O" Then
            MessageBox.Show("Spieler2 gewinnt!")

        ElseIf Button3.Text = "X" AndAlso Button6.Text = "X" AndAlso Button9.Text = "X" Then
            MessageBox.Show("Spieler1 gewinnt!")

        ElseIf Button3.Text = "O" AndAlso Button6.Text = "O" AndAlso Button9.Text = "O" Then
            MessageBox.Show("Spieler2 gewinnt!")

        ElseIf Button7.Text = "X" AndAlso Button8.Text = "X" AndAlso Button9.Text = "X" Then
            MessageBox.Show("Spieler1 gewinnt!")

        ElseIf Button7.Text = "O" AndAlso Button8.Text = "O" AndAlso Button9.Text = "O" Then
            MessageBox.Show("Spieler2 gewinnt!")

        ElseIf Button2.Text = "X" AndAlso Button5.Text = "X" AndAlso Button8.Text = "X" Then
            MessageBox.Show("Spieler1 gewinnt!")

        ElseIf Button2.Text = "O" AndAlso Button5.Text = "O" AndAlso Button8.Text = "O" Then
            MessageBox.Show("Spieler2 gewinnt!")

        ElseIf Button1.Text = "X" AndAlso Button5.Text = "X" AndAlso Button9.Text = "X" Then
            MessageBox.Show("Spieler1 gewinnt!")

        ElseIf Button1.Text = "O" AndAlso Button5.Text = "O" AndAlso Button9.Text = "O" Then
            MessageBox.Show("Spieler2 gewinnt!")

        ElseIf Button3.Text = "X" AndAlso Button5.Text = "X" AndAlso Button7.Text = "X" Then
            MessageBox.Show("Spieler1 gewinnt!")

        ElseIf Button3.Text = "O" AndAlso Button5.Text = "O" AndAlso Button7.Text = "O" Then
            MessageBox.Show("Spieler2 gewinnt!")

        Else
            MessageBox.Show("Unentschieden!")
        End If


    End Sub
End Class

