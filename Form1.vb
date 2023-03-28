Imports System.IO, System.Text

Public Class Form1
    Private Sub btnAddMovie_Click(sender As Object, e As EventArgs) Handles btnAddMovie.Click
        Dim MovieWriter As StreamWriter = File.AppendText("MovieCollection.txt")
        Dim strMovieName As String = txtMovieTitle.Text
        Dim strYearReleased As String = txtYearReleased.Text
        Dim strMovieRating As String = cbxRating.SelectedItem
        MovieWriter.WriteLine(strMovieName)
        MovieWriter.WriteLine(strYearReleased)
        MovieWriter.WriteLine(strMovieRating)
        MovieWriter.Close()
        MsgBox("The movie has been added to the database.")
        txtMovieTitle.Clear()
        txtYearReleased.Clear()
        cbxRating.ResetText()
    End Sub

    Private Sub btnDisplayAll_Click(sender As Object, e As EventArgs) Handles btnDisplayAll.Click
        Dim MovieReader As StreamReader = File.OpenText("MovieCollection.txt")
        lstDisplay.Items.Clear()
        Dim AddData As String
        Do While MovieReader.Peek <> -1
            AddData = MovieReader.ReadLine()
            lstDisplay.Items.Add(AddData)
        Loop
        MovieReader.Close()
    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        txtMovieTitle.Clear()
        txtYearReleased.Clear()
        cbxRating.ResetText()
        lstDisplay.Items.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim confirm_msg As Integer
        confirm_msg = MessageBox.Show("Are you sure you want to exit?", "Exit and Close",
                      MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If confirm_msg = vbYes Then
            Me.Close()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnFindMovie_Click(sender As Object, e As EventArgs) Handles btnFindMovie.Click
        Dim arrTitles(200) As String
        Dim arrRatings(200) As String
        Dim arrYear(200) As String
        Dim i As Integer
        Dim MovieReader As StreamReader = File.OpenText("MovieCollection.txt")
        i = 0
        Do While MovieReader.Peek <> -1
            arrTitles(i) = MovieReader.ReadLine
            arrYear(i) = MovieReader.ReadLine
            arrRatings(i) = MovieReader.ReadLine
            i = i + 1
        Loop
        MovieReader.Close()
        Dim intNumMovies As Integer = i


        Dim blnItemFound As Boolean = False
        Dim blnEndOfArray As Boolean = False
        Dim intSubscript As Integer = 0
        Dim intMaxSubscript As Integer
        intMaxSubscript = arrTitles.Length - 1
        Dim strSearchRequestItem As String
        strSearchRequestItem = txtMovieTitle.Text
        While blnItemFound = False And blnEndOfArray = False
            If strSearchRequestItem = arrTitles(intSubscript) Then
                blnItemFound = True

            ElseIf intSubscript = intMaxSubscript Then
                blnEndOfArray = True

            Else
                intSubscript = intSubscript + 1
            End If
        End While


        If blnItemFound = True Then
            lstDisplay.Items.Clear()
            lstDisplay.Items.Add(strSearchRequestItem & " is in your collection.")
        Else
            lstDisplay.Items.Clear()
            lstDisplay.Items.Add(strSearchRequestItem & " was not found")
        End If
    End Sub

    Private Sub btnDisplayByRating_Click(sender As Object, e As EventArgs) Handles btnDisplayByRating.Click
        Dim arrTitles(200) As String
        Dim arrRatings(200) As String
        Dim arrYear(200) As String
        Dim i As Integer
        Dim MovieReader As StreamReader = File.OpenText("MovieCollection.txt")
        i = 0
        Do While MovieReader.Peek <> -1
            arrTitles(i) = MovieReader.ReadLine
            arrYear(i) = MovieReader.ReadLine
            arrRatings(i) = MovieReader.ReadLine
        Loop
        MovieReader.Close()


    End Sub

    Public Structure Movie
        Friend strMovieTitle As String
        Friend strReleaseDate As String
        Friend strRating As String

    End Structure

End Class
