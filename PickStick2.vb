ption Strict On

Public Class frmPickUpSticksBeta

    Private Sub frmPickUpSticksAlpha_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        Dim str As New String(CChar("|"), CInt(10 + 40 * Rnd()))
        Dim A As Integer = Len(str)
        NewGame(str, A)

        If A Mod 6 = 1 Then
            // && DoNothing
        ElseIf A Mod 6 = 2 Then
            // && DoNothing
        Else
            ComputerMove(n) // && yes, computer first

        End If
    End Sub
    ' This function initializes the pile
    Sub NewGame(ByVal str As String, ByVal a As Integer)
        txtPile.Text = str
        lblCounter.Text = CStr(A)
    End Sub

    Private Sub btnTwo_Click(sender As Object, e As EventArgs) Handles btnTwo.Click
        YourMove(2)

    End Sub

    Private Sub btnThree_Click(sender As Object, e As EventArgs) Handles btnThree.Click
        YourMove(3)

    End Sub

    Private Sub btnFour_Click(sender As Object, e As EventArgs) Handles btnFour.Click
        YourMove(4)

    End Sub

    ' This function implements your move of n sticks.
    Sub YourMove(ByVal n As Integer)
        MessageBox.Show("You decided to pick " & n & " sticks", "Your Move")

        Dim D As Integer
        D = CInt(lblCounter.Text) - CInt(n)
        If D > 0 Then
            lblCounter.Text = CStr(D)
            Dim H As New String(CChar("|"), D)

            txtPile.Text = H

            ComputerMove(n)
            Return
        Else
            MessageBox.Show("You lost", "Your Move")
            Randomize()
            Dim str As New String(CChar("|"), CInt(10 + 40 * Rnd()))
            Dim A As Integer = Len(str)
            NewGame(str, A)
        End If

    End Sub

    ' This function implements computer's response to your move of n sticks
    Sub ComputerMove(ByVal n As Integer)

        Threading.Thread.Sleep(100)
        Randomize()
        Dim D As Integer
        D = CInt(lblCounter.Text) - CInt(2 + 2 * Rnd())
        If D > 0 Then
            MessageBox.Show("Computer decided to pick " & CInt(lblCounter.Text) - D & " sticks", "Your Move")
            lblCounter.Text = CStr(D)
            Dim H As New String(CChar("|"), D)
            txtPile.Text = H
        Else
            MessageBox.Show("Congratulations, you win!", "Computermove")
            Randomize()
            Dim str As New String(CChar("|"), CInt(10 + 40 * Rnd()))
            Dim A As Integer = Len(str)
            NewGame(str, A)
        End If

    End Sub

    Private Sub YourMove()
        Throw New NotImplementedException
    End Sub

    Private Sub ComputerMove()
        Throw New NotImplementedException
    End Sub

    Private Function n() As Integer
        Throw New NotImplementedException
    End Function




End Class
    
