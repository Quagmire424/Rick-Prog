Public Class Form1

   

    Private Sub txtNet_TextChanged(sender As Object, e As EventArgs) Handles txtNet.TextChanged

    End Sub

   Private Sub txtId_TextChanged(sender As Object, e As EventArgs) Handles txtId.TextChanged
        
    End Sub

   Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtId.Clear()
        txtHours.Clear()
        txtRate.Clear()
        txtGross.Clear()
        txtDeduction.Clear()
        txtNet.Clear()
        txtId.Focus()

   End Sub

   Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
      End
   End Sub

   Private Sub txtGross_TextChanged(sender As Object, e As EventArgs) Handles txtGross.TextChanged

   End Sub

   Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Dim rate, hours, grossPay, deduction, netPay As Double
        Dim input As String

        input = txtId.Text.Trim()

        If txtId.Text = "" Then
            MessageBox.Show("Enter the ID please", "Lab 2", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtId.Focus()
        End If

            input = txtRate.Text.Trim()

            If IsNumeric(input) And _
               InStr(input, "e", CompareMethod.Text) = 0 Then

                rate = Convert.ToDouble(input)
                If rate <= 0 Then
                    MessageBox.Show("Invalid Rate!" + vbCrLf & _
                                     "Rate must be positive!", "Lab 2", _
                                     MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtRate.Focus()
                    Exit Sub
                End If
            Else
                MessageBox.Show("Invalid Rate!" + Chr(Keys.LineFeed) & _
                                 "Rate must be a number!", "Lab 2", _
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtRate.Focus()
            Exit Sub
        End If

        input = txtHours.Text.Trim()

        If IsNumeric(input) And _
           InStr(input, "e", CompareMethod.Text) = 0 Then

            hours = Convert.ToDouble(input)
            If hours < 0 Then
                MessageBox.Show("Invalid Hours!" + vbCrLf & _
                                 "Hours must be non-negative!", "Lab 2", _
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtHours.Focus()
                Exit Sub
            End If
        Else
            MessageBox.Show("Invalid Hours!" + Chr(Keys.LineFeed) & _
                             "Hours must be a number!", "Lab 2", _
                             MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtHours.Focus()
        End If

        If hours <= 40 Then
            grossPay = hours * rate
            txtGross.Text = FormatCurrency(grossPay)

        Else
            grossPay = ((hours - 40) * (rate * 1.5)) + (40 * rate)
            txtGross.Text = FormatCurrency(grossPay)
        End If

        deduction = grossPay * 0.33
        txtDeduction.Text = FormatCurrency(deduction)

        netPay = grossPay - deduction
        txtNet.Text = FormatCurrency(netPay)
    End Sub

    Private Sub txtRate_TextChanged(sender As Object, e As EventArgs) Handles txtRate.TextChanged
        
    End Sub

    Private Sub txtHours_TextChanged(sender As Object, e As EventArgs) Handles txtHours.TextChanged
        
    End Sub

    Private Sub txtDeduction_TextChanged(sender As Object, e As EventArgs) Handles txtDeduction.TextChanged

    End Sub
End Class
