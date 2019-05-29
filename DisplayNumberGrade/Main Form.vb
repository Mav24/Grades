Public Class MainForm

    ' Globle array
    Dim arr() As String
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        If IO.File.Exists("Students.txt") Then

            arr = IO.File.ReadAllLines("Students.txt")

            For index = 0 To arr.Length - 1
                lstStudentNames.Items.Add(arr(index).Split(",")(0))
            Next index

        Else
            MessageBox.Show("Sorry File was not found!", "File doesn't exist", MessageBoxButtons.OK)
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
