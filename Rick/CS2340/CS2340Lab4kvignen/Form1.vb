Public Class Form1

    Dim nonNumberEntered As Boolean
    Dim rate As Single
    Dim principle, startYear, endYear, periods_per_year As Integer
    Dim futureValue As Integer


   Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
      End

   End Sub

   Private Sub txtPrinciple_TextChanged(sender As Object, e As EventArgs) Handles txtPrinciple.TextChanged

   End Sub

   Private Sub cboRate_KeyDown(sender As Object, e As KeyEventArgs) Handles cboRate.KeyDown
      nonNumberEntered = False

      If (e.KeyCode < Keys.D0 Or e.KeyCode > Keys.D9) And _
         (e.KeyCode < Keys.NumPad0 Or e.KeyCode > Keys.NumPad9) And _
         (e.KeyCode <> Keys.Back And e.KeyCode <> Keys.Decimal And e.KeyCode <> Keys.OemPeriod) And _
         (e.KeyCode <> Keys.D5 Or Control.ModifierKeys <> Keys.Shift) Then
         nonNumberEntered = True
      End If

      If Control.ModifierKeys = Keys.Shift And e.KeyCode <> Keys.D5 Then
         nonNumberEntered = True
      End If

      If InStr(cboRate.Text, ".") > 0 And (e.KeyCode = Keys.Decimal Or e.KeyCode = Keys.OemPeriod) Then
         nonNumberEntered = True
      End If

      If InStr(cboRate.Text, "%") > 0 And e.KeyCode = Keys.D5 And Control.ModifierKeys = Keys.Shift Then
         nonNumberEntered = True
      End If
   End Sub

   Private Sub cboRate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboRate.KeyPress
      If nonNumberEntered = True Then
         Beep()
         e.Handled = True
      End If
   End Sub

   Private Sub txtPrinciple_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPrinciple.KeyDown
      nonNumberEntered = False

      If (e.KeyCode < Keys.D0 Or e.KeyCode > Keys.D9) And _
         (e.KeyCode < Keys.NumPad0 Or e.KeyCode > Keys.NumPad9) And _
         (e.KeyCode <> Keys.Back And e.KeyCode <> Keys.Decimal And e.KeyCode <> Keys.OemPeriod) Then
         nonNumberEntered = True
      End If

      If Control.ModifierKeys = Keys.Shift Then
         nonNumberEntered = True
      End If

      If InStr(txtPrinciple.Text, ".") > 0 And (e.KeyCode = Keys.Decimal Or e.KeyCode = Keys.OemPeriod) Then
         nonNumberEntered = True
      End If
   End Sub

   Private Sub txtPrinciple_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrinciple.KeyPress
      If nonNumberEntered = True Then
         Beep()
         e.Handled = True
      End If
   End Sub

   Private Sub txtStartYear_KeyDown(sender As Object, e As KeyEventArgs) Handles txtStartYear.KeyDown
      nonNumberEntered = False

      If (e.KeyCode < Keys.D0 Or e.KeyCode > Keys.D9) And _
         (e.KeyCode < Keys.NumPad0 Or e.KeyCode > Keys.NumPad9) Then
         nonNumberEntered = True
      End If

      If Control.ModifierKeys = Keys.Shift Then
         nonNumberEntered = True
      End If
   End Sub

   Private Sub txtStartYear_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStartYear.KeyPress
      If nonNumberEntered = True Then
         Beep()
         e.Handled = True
      End If
   End Sub

   Private Sub txtEndYear_KeyDown(sender As Object, e As KeyEventArgs) Handles txtEndYear.KeyDown
      nonNumberEntered = False

      If (e.KeyCode < Keys.D0 Or e.KeyCode > Keys.D9) And _
         (e.KeyCode < Keys.NumPad0 Or e.KeyCode > Keys.NumPad9) Then
         nonNumberEntered = True
      End If

      If Control.ModifierKeys = Keys.Shift Then
         nonNumberEntered = True
      End If
   End Sub

   Private Sub txtEndYear_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEndYear.KeyPress
      If nonNumberEntered = True Then
         Beep()
         e.Handled = True
      End If
   End Sub

   Private Sub mnuYearly_Click(sender As Object, e As EventArgs) Handles mnuYearly.Click
      mnuYearly.Checked = True
      mnuDaily.Checked = False
      mnuQuarterly.Checked = False
        mnuMonthly.Checked = False
        periods_per_year = 1
   End Sub

   Private Sub mnuQuarterly_Click(sender As Object, e As EventArgs) Handles mnuQuarterly.Click
      mnuYearly.Checked = False
      mnuDaily.Checked = False
      mnuQuarterly.Checked = True
        mnuMonthly.Checked = False
        periods_per_year = 4
   End Sub

   Private Sub mnuMonthly_Click(sender As Object, e As EventArgs) Handles mnuMonthly.Click
      mnuYearly.Checked = False
      mnuDaily.Checked = False
      mnuQuarterly.Checked = False
        mnuMonthly.Checked = True
        periods_per_year = 12
   End Sub

   Private Sub mnuDaily_Click(sender As Object, e As EventArgs) Handles mnuDaily.Click
      mnuYearly.Checked = False
      mnuDaily.Checked = True
      mnuQuarterly.Checked = False
        mnuMonthly.Checked = False
        periods_per_year = 365
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rate = 0.05
        cboRate.Items.Clear()
        While rate < 0.12
            cboRate.Items.Add(Format(rate, "p"))
            rate += 0.01
        End While
        cboRate.SelectedItem = 2
    End Sub

    Private Sub mnuAbout_Click(sender As Object, e As EventArgs) Handles mnuAbout.Click
        MsgBox("Nick Kvigne" + vbCrLf + "Department of Computer Science and Software Engineering" +
               vbCrLf + "UW - Platteville", , "Future Values Program")
    End Sub

    Private Sub txtStartYear_TextChanged(sender As Object, e As EventArgs) Handles txtStartYear.TextChanged

    End Sub

    Private Sub mnuCompute_Click(sender As Object, e As EventArgs) Handles mnuCompute.Click
        principle = txtPrinciple.Text.Trim
        rate = cboRate.SelectedIndex
        startYear = txtStartYear.Text.Trim
        endYear = txtEndYear.Text.Trim

        If principle = 0 Then
            MessageBox.Show("Enter a valid principle!")
            txtPrinciple.Focus()
            Exit Sub
        End If
        If rate < 0 Then
            MessageBox.Show("Enter a valid rate!")
            cboRate.Focus()
            Exit Sub
        End If
        If startYear < 0 Or startYear > 99 Then
            MessageBox.Show("Enter a valid start year!")
            txtStartYear.Focus()
            Exit Sub
        End If
        If endYear < startYear Or endYear > 99 Then
            MessageBox.Show("Enter a valid end year!")
            txtEndYear.Focus()
            Exit Sub
        End If

        For index As Integer = startYear To endYear
            futureValue = -FV(rate, index * periods_per_year, 0, principle)
            lstFuture.Items.Add(index.ToString.PadLeft(8) &
            Format(futureValue, "c").PadLeft(23))
        Next
        
    End Sub


End Class

