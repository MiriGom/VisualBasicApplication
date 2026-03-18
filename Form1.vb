Public Class Form1
    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click

        Dim iTemperature As Integer


        If Integer.TryParse(txtTemperature.Text, iTemperature) Then

            Select Case iTemperature
                Case Is = 0
                    MsgBox("Freezing")
                Case Is < 0
                    MsgBox("Sub Zero")
                Case 1 To 10
                    MsgBox("cold")
                Case 11 To 20
                    MsgBox("Warm")
                Case Else
                    MsgBox("Hot")
            End Select
        Else
            MsgBox("Please enter a valid integer for temperature.")
        End If




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCountingApp.Click
        Dim stCountUpToVariable As String
        Dim stOddOrEven As String
        Dim iCount As Integer

        stCountUpToVariable = InputBox("What number do you want to count up to?")
        stOddOrEven = InputBox("Do you want odd or even numbers?")

        Select Case stOddOrEven.ToUpper
            Case "ODD"
                For iCount = 1 To CInt(stCountUpToVariable) Step 2
                    MsgBox(iCount)
                Next
            Case "EVEN"
                For iCount = 0 To CInt(stCountUpToVariable) Step 2
                    MsgBox(iCount)
                Next
            Case Else
                MsgBox("Please enter 'odd' or 'even'.")
        End Select



    End Sub
End Class
