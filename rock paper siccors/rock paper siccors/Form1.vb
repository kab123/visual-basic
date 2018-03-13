Public Class Form1
    ' Define the global variables (global means outside the subroutines)
    Dim Player1 As String
    Dim Player2 As String
    Dim rand As New Random      ' Used later when program is updated to let computer pick 

    ' Event handler for Player1
    Private Sub btnRock1_Click(sender As Object, e As EventArgs) Handles btnRock1.Click
        Player1 = "Rock"
        btnPaper1.Enabled = False
        btnScissors1.Enabled = False
    End Sub
    Private Sub btnPaper1_Click(sender As Object, e As EventArgs) Handles btnPaper1.Click
        Player1 = "Paper"
        btnRock1.Enabled = False
        btnScissors1.Enabled = False
    End Sub
    Private Sub btnScissors1_Click(sender As Object, e As EventArgs) Handles btnScissors1.Click
        Player1 = "Scissors"
        btnRock1.Enabled = False
        btnPaper1.Enabled = False
    End Sub
    ' Event handler for Player2
    Private Sub btnRock2_Click(sender As Object, e As EventArgs) Handles btnRock2.Click
        Player2 = "Rock"
        btnPaper2.Enabled = False
        btnScissors2.Enabled = False
    End Sub
    Private Sub btnPaper2_Click(sender As Object, e As EventArgs) Handles btnPaper2.Click
        Player2 = "Paper"
        btnRock2.Enabled = False
        btnScissors2.Enabled = False
    End Sub
    Private Sub btnScissors2_Click(sender As Object, e As EventArgs) Handles btnScissors2.Click
        Player2 = "Scissors"
        btnRock2.Enabled = False
        btnPaper2.Enabled = False
    End Sub

    'let AI pick button
    Private Sub btnRandomPlayer1_Click(sender As Object, e As EventArgs) Handles btnRandomPlayer1.Click
        Dim AI = rand.Next(3)
        If AI = 0 Then
            btnRock1_Click(sender, e)
        ElseIf AI = 1 Then
            btnPaper1_Click(sender, e)
        Else
            btnScissors1_Click(sender, e)
        End If
    End Sub

    Private Sub btnRandomPlayer2_Click(sender As Object, e As EventArgs) Handles btnRandomPlayer2.Click
        Dim AI = rand.Next(3)
        If AI = 0 Then
            btnRock2_Click(sender, e)
        ElseIf AI = 1 Then
            btnPaper2_Click(sender, e)
        Else
            btnScissors2_Click(sender, e)
        End If
    End Sub
    Private Sub btnWhoWon_Click(sender As Object, e As EventArgs) Handles btnWhoWon.Click
        'rock
        If Player1 = "Rock" And Player2 = "Rock" Then
            lblWinner.Text = "Tie Game"
        End If
        If Player1 = "Rock" And Player2 = "Paper" Then
            lblWinner.Text = "Player 2 wins! Paper covers rock!"
        End If
        If Player1 = "Rock" And Player2 = "Scissors" Then
            lblWinner.Text = "player 1 wins! Rock crushes scissors!"
        End If
        'Paper
        If Player1 = "Paper" And Player2 = "Rock" Then
            lblWinner.Text = "Player 1 wins! Paper overs rock!"
        End If
        If Player1 = "Paper" And Player2 = "Paper" Then
            lblWinner.Text = "Tie Game"
        End If
        If Player1 = "Paper" And Player2 = "Scissors" Then
            lblWinner.Text = "player 2 wins! Scissors rips paper!"
        End If
        'Scissors
        If Player1 = "Scissors" And Player2 = "Rock" Then
            lblWinner.Text = "player 2 wins! Rock crushes scissors!"
        End If
        If Player1 = "Scissors" And Player2 = "Paper" Then
            lblWinner.Text = "Player 1 wins! Scissors cuts paper!"
        End If
        If Player1 = "Scissors" And Player2 = "Scissors" Then
            lblWinner.Text = "Tie Game"
        End If
    End Sub


    ' Event handler for "New Game" button being clicked
    '   Clear the label that shows who won and re-enable all of the pictures
    '
    Private Sub btnNewGame_Click(sender As Object, e As EventArgs) Handles btnNewGame.Click
        lblWinner.Text = String.Empty    ' clear the label
        btnRock1.Enabled = True         ' re-enable all the pictures
        btnPaper1.Enabled = True
        btnScissors1.Enabled = True
        btnRock2.Enabled = True
        btnPaper2.Enabled = True
        btnScissors2.Enabled = True
    End Sub

    ' Event handler for "Exit" button being clicked
    '
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()      ' end the program
    End Sub
End Class
