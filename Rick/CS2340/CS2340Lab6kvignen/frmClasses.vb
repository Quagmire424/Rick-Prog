Public Class frmClasses

   Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
      While lstAvailable.SelectedIndex > -1
         lstSelected.Items.Add(lstAvailable.SelectedItem)
         lstAvailable.Items.Remove(lstAvailable.SelectedItem)

      End While
   End Sub


   Private Sub lstAvailable_DoubleClick(sender As Object, e As EventArgs) Handles lstAvailable.DoubleClick
      While lstAvailable.SelectedIndex > -1
         lstSelected.Items.Add(lstAvailable.SelectedItem)
         lstAvailable.Items.Remove(lstAvailable.SelectedItem)

      End While
   End Sub

   Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
      While lstSelected.SelectedIndex > -1
         lstAvailable.Items.Add(lstSelected.SelectedItem)
         lstSelected.Items.Remove(lstSelected.SelectedItem)

      End While
   End Sub

   Private Sub btnRemoveAll_Click(sender As Object, e As EventArgs) Handles btnRemoveAll.Click
      Dim x As Integer
      For x = 0 To lstSelected.Items.Count - 1
         lstAvailable.Items.Add(lstSelected.Items(x))

      Next
      lstSelected.Items.Clear()

   End Sub

   Private Sub lstSelected_DoubleClick(sender As Object, e As EventArgs) Handles lstSelected.DoubleClick
      While lstSelected.SelectedIndex > -1
         lstAvailable.Items.Add(lstSelected.SelectedItem)
         lstSelected.Items.Remove(lstSelected.SelectedItem)

      End While
   End Sub

   Private Sub SortClassesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SortClassesToolStripMenuItem.Click
      lstAvailable.Sorted = True
      lstSelected.Sorted = True

   End Sub

   Private Sub ResetListBoxesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetListBoxesToolStripMenuItem.Click
        Dim x As Integer
        For x = 0 To lstSelected.Items.Count - 1
            lstAvailable.Items.Add(lstSelected.Items(x))

        Next
        lstSelected.Items.Clear()

   End Sub

    Private Sub NextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NextToolStripMenuItem.Click
        Me.Hide()
        frmPayment.Show()
        frmPayment.BringToFront()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub frmClasses_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If CloseReason.ApplicationExitCall Then
            MessageBox.Show("Sorry, the form cannot be closed this way!" + vbCrLf + "Use the form Shortcut menu please.")
            e.Cancel = True
        End If
    End Sub

    Private Sub frmClasses_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Dim x, dx, y, a As Integer
        x = (Me.ClientSize.Width - lblTitle.Width) / 2
        lblTitle.Left = x
        dx = (Me.ClientSize.Width - 2 * lstSelected.Width - btnRemove.Width) / 3
        lstAvailable.Left = dx
        btnRemove.Left = 1.5 * dx + lstAvailable.Width
        btnRemoveAll.Left = btnRemove.Left
        btnSelect.Left = btnRemove.Left
        lstSelected.Left = Me.ClientSize.Width - dx - lstSelected.Width

        y = (Me.ClientSize.Height - lstAvailable.Height - 30 - lblAvailable.Height - lblTitle.Height) / 2.5
        lblAvailable.Top = (Me.ClientSize.Height - y - lstAvailable.Height - 30 - lblAvailable.Height)
        lblSelected.Top = lblAvailable.Top
        lstAvailable.Top = (Me.ClientSize.Height - y - lstAvailable.Height)
        lstSelected.Top = lstAvailable.Top
        lblAvailable.Left = lstAvailable.Left + 35.5
        lblSelected.Left = lstSelected.Left + 36
        btnSelect.Top = lstAvailable.Top
        btnRemoveAll.Top = lstAvailable.Top + lstAvailable.Height - btnRemoveAll.Height
        a = (lstAvailable.Height - 3 * btnRemove.Height) / 2
        btnRemove.Top = btnSelect.Top + btnSelect.Height + a
        lblTitle.Top = y



    End Sub
End Class
