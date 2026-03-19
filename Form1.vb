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

    Private Sub btnListOfFruit_Click(sender As Object, e As EventArgs) Handles btnListOfFruit.Click
        Dim aiData(4) As Integer

        aiData(0) = 5
        aiData(1) = 7
        aiData(2) = 33
        aiData(3) = 22
        aiData(4) = 8

        For i = 0 To 4
            MsgBox(aiData(i))
        Next

    End Sub

    Private Sub btnExcersize2_Click(sender As Object, e As EventArgs) Handles btnExcersize2.Click
        Dim aiData(4) As Integer
        Dim stOutput As String
        Dim i As Integer

        aiData(0) = 5
        aiData(1) = 7
        aiData(2) = 33
        aiData(3) = 22
        aiData(4) = 8

        For i = 0 To 4
            stOutput = stOutput & aiData(i) & vbNewLine
        Next

        MsgBox(stOutput)
    End Sub

    Private Sub btnExcersize3_Click(sender As Object, e As EventArgs) Handles btnExcersize3.Click
        Dim aiData(4) As Integer
        Dim i As Integer
        Dim iResult As Integer

        aiData(0) = 5
        aiData(1) = 7
        aiData(2) = 33
        aiData(3) = 22
        aiData(4) = 8

        For i = 0 To 4
            iResult = iResult + aiData(i)
        Next

        MsgBox("The total is: " & iResult)

    End Sub

    Private Sub btnExcersize4_Click(sender As Object, e As EventArgs) Handles btnExcersize4.Click
        Dim aiData(4) As Integer
        Dim iResult As Integer
        Dim i As Integer

        aiData(0) = 5
        aiData(1) = 7
        aiData(2) = 33
        aiData(3) = 22
        aiData(4) = 8

        For i = 0 To 4
            iResult = iResult + aiData(i)
        Next

        MsgBox("The average is: " & iResult / 5)
    End Sub

    Private Sub btnExcersize5_Click(sender As Object, e As EventArgs) Handles btnExcersize5.Click
        Dim aiData(4) As Integer
        Dim iResult As Integer
        Dim i As Integer

        aiData(0) = 5
        aiData(1) = 7
        aiData(2) = 33
        aiData(3) = 22
        aiData(4) = 8

        For i = 0 To 4
            If aiData(i) > 20 Then
                iResult = iResult + aiData(i)
            End If
        Next
        MsgBox("The total of items bigger than 20 is: " & iResult)
    End Sub

    Private Sub btnExcersize6_Click(sender As Object, e As EventArgs) Handles btnExcersize6.Click
        Dim aiData(4) As Integer
        Dim iResult As Integer
        Dim i As Integer

        aiData(0) = 5
        aiData(1) = 7
        aiData(2) = 33
        aiData(3) = 22
        aiData(4) = 8

        For i = 0 To 4
            If aiData(i) > iResult Then
                iResult = aiData(i)
            End If
        Next
        MsgBox("The largest number is: " & iResult)


    End Sub

    Private Sub btnExcersize7_Click(sender As Object, e As EventArgs) Handles btnExcersize7.Click
        Dim aiData(4) As Integer
        Dim iResult As Integer
        Dim i As Integer

        aiData(0) = 5
        aiData(1) = 7
        aiData(2) = 33
        aiData(3) = 1
        aiData(4) = 3

        iResult = aiData(2)
        For i = 0 To 4
            If aiData(i) < iResult Then
                iResult = aiData(i)
            End If
        Next
        MsgBox("The smallest number is: " & iResult)
    End Sub

    Private Sub btnExcersize8_Click(sender As Object, e As EventArgs) Handles btnExcersize8.Click
        Dim aiData(4) As Integer
        Dim iResult As Integer
        Dim i As Integer
        Dim stOutput As String

        aiData(0) = 5
        aiData(1) = 7
        aiData(2) = 33
        aiData(3) = 22
        aiData(4) = 8

        For i = 0 To 4
            aiData(i) = aiData(i) * 2
        Next

        For i = 0 To 4
            stOutput = stOutput & aiData(i) & vbNewLine
        Next
        MsgBox(stOutput)


    End Sub
End Class
