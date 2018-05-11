Imports System.IO
Public Class Form1

    Dim FileName As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim UserProfile As String = System.Environment.ExpandEnvironmentVariables("%USERPROFILE%")
        FileName = UserProfile & "\Desktop\phony.411.txt"

        If System.IO.File.Exists(FileName) = False Then
            With ofdGetFileName
                .Filter = "Text files (*.txt)|*.txt"
                .Title = "Select a File to Open"
                If .ShowDialog() = DialogResult.OK Then
                    FileName = .FileName
                Else
                    MessageBox.Show("404 File not found")
                End If
            End With
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnSearchFile_Click(sender As Object, e As EventArgs) Handles btnSearchFile.Click
        Dim inputFile As StreamReader
        Dim lineOfText As String

        ListBox1.Items.Clear()

        inputFile = File.OpenText(FileName)

        While inputFile.Peek <> -1
            lineOfText = inputFile.ReadLine()
            If InStr(lineOfText.ToLower, txtsearchString.Text.ToLower) Then
                ListBox1.Items.Add(lineOfText)
            End If
        End While
        inputFile.Close()

    End Sub

    Private Sub btnSearchArray_Click(sender As Object, e As EventArgs) Handles btnSearchArray.Click
        Dim inputFile As StreamReader
        Dim lineOfText As String
        Dim fileArray(200) As String
        Dim lineCount As Integer = 0

        ListBox2.Items.Clear()
        inputFile = File.OpenText(FileName)

        While inputFile.Peek <> -1
            lineOfText = inputFile.ReadLine()
            fileArray(lineCount) = lineOfText
            lineCount += 1
        End While
        inputFile.Close()
        For i As Integer = 0 To lineCount - 1
            If InStr(fileArray(i).ToLower, txtsearchString.Text.ToLower) Then
                ListBox2.Items.Add(fileArray(i))
            End If
        Next
    End Sub

End Class
