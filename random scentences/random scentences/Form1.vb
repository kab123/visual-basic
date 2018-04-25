Public Class Form1
    Private Sub btnRandom_Click(sender As Object, e As EventArgs) Handles btnRandom.Click
        Dim article() As String = {"A", "some", "the", "one", "any"}
        Dim adjictive() As String = {"fast", "quick", "slow", "red", "blue", "green"}
        Dim noun() As String = {"house", "plane", "dog", "camel", "sea horse"}
        Dim verb() As String = {"runs", "screams", "eats", "codes", "crawls", "walked"}
        Dim preposition() As String = {"to", "over", "under", "around"}

        Dim index As Integer
        Dim i As Integer
        Dim sentence As String
        Dim rand As New Random

        lblOutput.Text = String.Empty
        For i = 1 To 20
            index = rand.Next(article.Length)
            sentence = article(index)
            Mid(sentence, 1, 1) = UCase(Mid(sentence, 1, 1))
            sentence &= " "
            sentence &= adjictive(index)
            sentence &= " "
            sentence &= noun(rand.Next(noun.Length))
            sentence &= " "
            sentence &= verb(index)
            sentence &= " "
            sentence &= preposition(rand.Next(preposition.Length))
            sentence &= " "
            sentence &= article(index)
            sentence &= " "
            sentence &= noun(rand.Next(noun.Length)) & "."
            sentence &= vbCrLf
            lblOutput.Text &= sentence
        Next i
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
