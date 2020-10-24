﻿Public Class Form1

    Dim Player1 As Char
    Dim Player2 As Char
    Dim Sieger1 As Object
    Dim Sieger2 As Object

    Public Function SpielerMakierung(Spielerbutton)

        If BtnSpielerEins.Enabled = True Then

            Spielerbutton.Text = Player1

        Else
            Spielerbutton.Text = Player2

        End If

        If Spielerbutton.Text = "X" Then
            BtnSpielerEins.Enabled = False
            BtnSpielerZwei.Enabled = True

        Else
            If Spielerbutton.Text = "O" Then
                BtnSpielerZwei.Enabled = False
                BtnSpielerEins.Enabled = True
            End If

        End If


    End Function

    Public Sub StatusButtons(Status As Boolean)

        Button1.Enabled = Status
        Button2.Enabled = Status
        Button3.Enabled = Status
        Button4.Enabled = Status
        Button5.Enabled = Status
        Button6.Enabled = Status
        Button7.Enabled = Status
        Button8.Enabled = Status
        Button9.Enabled = Status

    End Sub


    Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles BtnStart.Click
        BtnSpielerEins.Enabled = True
        BtnSpielerZwei.Enabled = True
        BtnNeustart.Enabled = True

        StatusButtons(True)

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

        StatusButtons(False)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button1.TextChanged

        SpielerMakierung(Button1)

        Button1.Enabled = False

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        SpielerMakierung(Button2)

        Button2.Enabled = False

    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        SpielerMakierung(Button3)

        Button3.Enabled = False

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        SpielerMakierung(Button4)

        Button4.Enabled = False

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        SpielerMakierung(Button5)

        Button5.Enabled = False

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        SpielerMakierung(Button6)

        Button6.Enabled = False

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        SpielerMakierung(Button7)

        Button7.Enabled = False

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        SpielerMakierung(Button8)

        Button8.Enabled = False

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

        SpielerMakierung(Button9)

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

        StatusButtons(False)

    End Sub
End Class

