Public Class PayForm
    Dim nonNumberEntered As Boolean
    Dim hours, rate As Double
    Dim input As String


    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dim res As MsgBoxResult = MsgBox("The program is going to terminate." + vbCrLf + "Do you really want to exit?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo)

        If res = MsgBoxResult.Yes Then
            Application.Exit()

        End If

    End Sub


    Private Sub frmPayRoll_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.ApplicationExitCall Then
            Application.Exit()

        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub StatsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StatsToolStripMenuItem.Click
        Me.Hide()
        StatsForm.Show()
        StatsForm.BringToFront()
    End Sub


    
    Private Sub txtHours_KeyDown(sender As Object, e As KeyEventArgs) Handles txtHours.KeyDown
        nonNumberEntered = False

        If (e.KeyCode < Keys.D0 Or e.KeyCode > Keys.D9) And _
           (e.KeyCode < Keys.NumPad0 Or e.KeyCode > Keys.NumPad9) And _
           (e.KeyCode <> Keys.Back And e.KeyCode <> Keys.Decimal And e.KeyCode <> Keys.OemPeriod) Then
            nonNumberEntered = True
        End If

        If Control.ModifierKeys = Keys.Shift Then
            nonNumberEntered = True
        End If

        If InStr(txtHours.Text, ".") > 0 And (e.KeyCode = Keys.Decimal Or e.KeyCode = Keys.OemPeriod) Then
            nonNumberEntered = True
        End If
    End Sub


    Private Sub txtHours_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHours.KeyPress
        If nonNumberEntered = True Then
            Beep()
            e.Handled = True
        End If
    End Sub


    Private Sub txtRate_KeyDown(sender As Object, e As KeyEventArgs) Handles txtRate.KeyDown
        nonNumberEntered = False

        If (e.KeyCode < Keys.D0 Or e.KeyCode > Keys.D9) And _
           (e.KeyCode < Keys.NumPad0 Or e.KeyCode > Keys.NumPad9) And _
           (e.KeyCode <> Keys.Back And e.KeyCode <> Keys.Decimal And e.KeyCode <> Keys.OemPeriod) Then
            nonNumberEntered = True
        End If

        If Control.ModifierKeys = Keys.Shift Then
            nonNumberEntered = True
        End If

        If InStr(txtRate.Text, ".") > 0 And (e.KeyCode = Keys.Decimal Or e.KeyCode = Keys.OemPeriod) Then
            nonNumberEntered = True
        End If
    End Sub


    Private Sub txtRate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRate.KeyPress
        If nonNumberEntered = True Then
            Beep()
            e.Handled = True
        End If
    End Sub

    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        input = txtID.Text.Trim
        If input = "" Then
            MessageBox.Show("Invalid input.")
            txtID.Focus()
        Else
            txtID.Text = input
        End If

        input = txtHours.Text.Trim
        If input < 0 Then
            MessageBox.Show("Invalid input.")
            txtHours.Focus()
        Else
            txtHours.Text = input
        End If

        input = txtRate.Text.Trim
        If input < 1 Then
            MessageBox.Show("Invalid input.")
            txtRate.Focus()
        Else
            txtRate.Text = input
        End If

        txtID.ReadOnly = True
        txtHours.ReadOnly = True
        txtRate.ReadOnly = True
        txtHours.BackColor = SystemColors.Window
        txtID.BackColor = SystemColors.Window
        txtRate.BackColor = SystemColors.Window
        NextToolStripMenuItem.Enabled = True
        ComputeToolStripMenuItem.Enabled = False


    End Sub

    Private Sub NextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NextToolStripMenuItem.Click
        txtID.Text = ""
        txtHours.Text = ""
        txtRate.Text = ""
        txtNet.Text = ""
        txtDeduct.Text = ""
        txtGross.Text = ""
        txtID.Focus()

        NextToolStripMenuItem.Enabled = False
        ComputeToolStripMenuItem.Enabled = True
    End Sub
End Class
