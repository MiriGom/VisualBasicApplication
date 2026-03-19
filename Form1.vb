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

    Private Sub btnDoWhile_Click(sender As Object, e As EventArgs) Handles btnDoWhile.Click
        Dim iCount As Integer
        Dim stName As String

        Do While stName <> "Miriam"
            stName = InputBox("What is your name?")
        Loop

        Do While True = True
            stName = InputBox("What is your name?")
            If stName = "Miriam" Then
                Exit Do
            End If
            iCount += 1
        Loop

        Do
            MsgBox(iCount)
            iCount += 1
        Loop While iCount < 10


        Do Until iCount < 10
            MsgBox(iCount)
            iCount += 1
        Loop


        Do
            MsgBox(iCount)
            iCount += 1
        Loop Until iCount < 10
    End Sub
End Class
