Public Class Form1
    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click

        Dim iTemperature As Integer
        iTemperature = CInt(txtTemperature.Text)


        Select Case iTemperature
            Case Is = 0
                MsgBox("Freezing")
            Case Is < 15
                MsgBox("Sub Zero")
            Case 1 To 10
                MsgBox("cold")
            Case 11 To 20
                MsgBox("Warm")
        End Select


    End Sub
End Class
