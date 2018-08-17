Public Class StatsForm

    Private Sub frmStats_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.ApplicationExitCall Then
            Application.Exit()

        Else
            e.Cancel = True
        End If
    End Sub


    Private Sub frmStats_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtHighest.Text = Format(txtHighest.Text, "C")
        txtLowest.Text = Format(txtLowest.Text, "C")
        txtAverage.Text = Format(txtAverage.Text, "C")

    End Sub

    Private Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToolStripMenuItem.Click
        Me.Hide()
        PayForm.Show()
        PayForm.BringToFront()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dim res As MsgBoxResult = MsgBox("The program is going to terminate." + vbCrLf + "Do you really want to exit?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo)

        If res = MsgBoxResult.Yes Then
            Application.Exit()

        End If
    End Sub

    Private Sub StatsForm_MinimumSizeChanged(sender As Object, e As EventArgs) Handles Me.MinimumSizeChanged
        lblGrossPayStats.Top = 20
        lblCount.Top = lblGrossPayStats.Top + lblGrossPayStats.Height + 20
        txtSuccessfulNum.Top = lblCount.Top
        lblHighest.Top = lblCount.Top + lblCount.Height
        txtHighest.Top = lblHighest.Top
        lblLowest.Top = lblHighest.Top + lblHighest.Height
        txtLowest.Top = lblLowest.Top
        lblAverage.Top = Me.ClientSize.Height - 20 - lblAverage.Height
        txtAverage.Top = lblAverage.Top

    End Sub

    Private Sub StatsForm_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Dim y As Integer

        y = (Me.ClientSize.Height - 4 * lblAverage.Height - lblGrossPayStats.Height) / 6

        lblGrossPayStats.Top = y
        lblCount.Top = lblGrossPayStats.Top + lblGrossPayStats.Height + y
        txtSuccessfulNum.Top = lblCount.Top
        lblHighest.Top = lblCount.Top + lblCount.Height + y
        txtHighest.Top = lblHighest.Top
        lblLowest.Top = lblHighest.Top + lblHighest.Height + y
        txtLowest.Top = lblLowest.Top
        lblAverage.Top = Me.ClientSize.Height - y
        txtAverage.Top = lblAverage.Top

    End Sub
End Class