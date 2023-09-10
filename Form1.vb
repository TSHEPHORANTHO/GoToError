Public Class Form1
    Private Sub btnResults_Click(sender As Object, e As EventArgs) Handles btnResults.Click
        'GO TO ERROR
        Dim isNumber As String
        isNumber = txtCharecters.Text


        On Error GoTo ErrorHandler

        'If entered a numeric number
        Dim numericValue As Double
        numericValue = CDbl(isNumber)

        'If entered a numeric number display the results
        MsgBox("Valid: " & numericValue)
        Exit Sub
ErrorHandler:
        'If entered a non-numeric number display results
        MsgBox("Error: " & isNumber & " Is Not a number")
    End Sub
End Class
