Public Class Internet_speed
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblAverage.Text = ""
        lstInternetSpeed.Items.Clear()
        btnSpeed.Enabled = True
    End Sub

    Private Sub btnSpeed_Click(sender As Object, e As EventArgs) Handles btnSpeed.Click
        'Declare and initialize varaibles
        Dim strSpeed As String
        Dim decSpeed As Decimal
        Dim decSumOfSpeeds As Decimal
        Dim decAverage As Decimal = 0D

        Dim strIBoxMsg As String = "Enter the number of Mbps of your home Internet speed user #"
        Dim strIBoxTitle As String = "Internet Speed"
        Dim strNotNumericErrMsg As String = "Error - Enter the speed of your home Internet connection"
        Dim strNegErrMsg As String = "Error - Enter a valid speed"

        'Declare and initialize loop varaibles
        Dim intMaxEntries As Integer = 10
        Dim intEntries As Integer = 1

        strSpeed = InputBox(strIBoxMsg & intEntries, strIBoxTitle)

        'Do until intNumberOfEntries > intMaxNumberOfEntries
        'or until strSpeed is empty (use Cancel Button property)
        Do Until intEntries > intMaxEntries Or strSpeed = ""
            'validates that the speed is numeric
            If IsNumeric(strSpeed) Then
                decSpeed = Convert.ToDecimal(strSpeed)
                'validates that decSpeed is positive
                If decSpeed > 0 Then
                    lstInternetSpeed.Items.Add(decSpeed)
                    decSumOfSpeeds += decSpeed
                    intEntries += 1
                    strIBoxMsg = strIBoxMsg
                Else
                    'if the speed is not positive, gives error message 
                    strIBoxMsg = strNegErrMsg
                End If
            Else
                'if not a number, give error message
                strIBoxMsg = strNotNumericErrMsg
            End If

            If intEntries <= intMaxEntries Then
                strSpeed = InputBox(strIBoxMsg & intEntries, strIBoxTitle)
            End If
        Loop

        'makes label visable
        lblAverage.Visible = True
        'calculates and displays average speed
        If intEntries > 1 Then
            decAverage = decSumOfSpeeds / (intEntries - 1)
            lblAverage.Text = "Average Internet Speed: " & decAverage.ToString("F2") & " Mbps"
        Else
            lblAverage.Text = "No Speed Values Entered"
        End If

        btnSpeed.Enabled = False
    End Sub
End Class
