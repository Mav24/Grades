Public Class MainForm
    Dim inFile As IO.StreamReader
    Dim arr(5) As String
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim i As Integer = 0
        Dim names As String

        If IO.File.Exists("Students.txt") Then
            inFile = IO.File.OpenText("Students.txt")
            Do Until inFile.Peek = -1

                names = inFile.ReadLine

                ' Store each line from file to an array
                arr(i) = names

                ' Split and only put first word in the list box
                lstStudentNames.Items.Add(arr(i).Split(",")(0))

                ' increment
                i += 1

            Loop
        End If
    End Sub

    Private Sub LstStudentNames_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstStudentNames.SelectedIndexChanged
        lblLetterGrade.Text = String.Empty
        Dim selectedName = lstStudentNames.SelectedIndex
        Dim name As String = arr(selectedName)

        lblNumericGrade.Text = name.Split(",")(1)

    End Sub

    Private Sub BtnGetLetterGrade_Click(sender As Object, e As EventArgs) Handles btnGetLetterGrade.Click
        Dim numericGrade As Integer
        Integer.TryParse(lblNumericGrade.Text, numericGrade)
        Select Case numericGrade
            Case 90 To 100
                lblLetterGrade.Text = "A+"
            Case 80 To 89
                lblLetterGrade.Text = "A"
            Case 70 To 79
                lblLetterGrade.Text = "B"
            Case 60 To 69
                lblLetterGrade.Text = "C"
            Case 50 To 59
                lblLetterGrade.Text = "D"
            Case Else
                lblLetterGrade.Text = "F"

        End Select
    End Sub
End Class
