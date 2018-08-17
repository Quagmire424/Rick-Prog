Public Class frmPayment
    Dim result As Integer


    Private Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToolStripMenuItem.Click
        Me.Hide()
        frmClasses.Show()
        frmClasses.BringToFront()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End

    End Sub

    Private Sub frmPayment_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If CloseReason.ApplicationExitCall Then
            MessageBox.Show("Sorry, the form cannot be closed this way!" + vbCrLf + "Use the form Shortcut menu please.")
            e.Cancel = True
        End If
    End Sub

    Private Sub frmPayment_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtPay.Text = Format(result, "C")

    End Sub

    Private Sub rdoWisco_CheckedChanged(sender As Object, e As EventArgs) Handles rdoWisco.CheckedChanged
        result = 2725
        txtPay.Text = result
    End Sub

    Private Sub rdoMinnes_CheckedChanged(sender As Object, e As EventArgs) Handles rdoMinnes.CheckedChanged
        result = 3021
        txtPay.Text = result

    End Sub

    Private Sub rdoTri_CheckedChanged(sender As Object, e As EventArgs) Handles rdoTri.CheckedChanged
        result = 4725
        txtPay.Text = result
    End Sub

    Private Sub rdoNonRes_CheckedChanged(sender As Object, e As EventArgs) Handles rdoNonRes.CheckedChanged
        result = 6463
        txtPay.Text = result
    End Sub

    Private Sub rdoInternat_CheckedChanged(sender As Object, e As EventArgs) Handles rdoInternat.CheckedChanged
        result = 6463
        txtPay.Text = result
    End Sub

    Private Sub rdoNoRes_CheckedChanged(sender As Object, e As EventArgs) Handles rdoNoRes.CheckedChanged
        If rdoWisco.Checked Then
            txtPay.Text = 2725
        Else
            If rdoMinnes.Checked Then
                txtPay.Text = 3021
            Else
                If rdoTri.Checked Then
                    txtPay.Text = 4725
                Else
                    If rdoNonRes.Checked Then
                        txtPay.Text = 6463
                    Else
                        If rdoInternat.Checked Then
                            txtPay.Text = 6463
                        End If
                    End If
                End If

            End If
        End If

    End Sub

    Private Sub rdoYesRes_CheckedChanged(sender As Object, e As EventArgs) Handles rdoYesRes.CheckedChanged
        If rdoWisco.Checked Then
            result += 1312
            txtPay.Text = result
        Else
            If rdoMinnes.Checked Then
                result += 1312
                txtPay.Text = result
            Else
                If rdoTri.Checked Then
                    result += 1312
                    txtPay.Text = result
                Else
                    If rdoNonRes.Checked Then
                        result += 1312
                        txtPay.Text = result
                    Else
                        If rdoInternat.Checked Then
                            result += 1312
                            txtPay.Text = result
                        End If
                    End If
                End If

            End If
        End If
    End Sub

    Private Sub rdoNoPark_CheckedChanged(sender As Object, e As EventArgs) Handles rdoNoPark.CheckedChanged
            If rdoWisco.Checked Then
                txtPay.Text = 2725
            Else
                If rdoMinnes.Checked Then
                    txtPay.Text = 3021
                Else
                    If rdoTri.Checked Then
                        txtPay.Text = 4725
                    Else
                        If rdoNonRes.Checked Then
                            txtPay.Text = 6463
                        Else
                            If rdoInternat.Checked Then
                                txtPay.Text = 6463
                            End If
                        End If
                    End If

                End If
            End If
    End Sub

    Private Sub rdoYesPark_CheckedChanged(sender As Object, e As EventArgs) Handles rdoYesPark.CheckedChanged
        If rdoWisco.Checked Then
            result += 30
            txtPay.Text = result
        Else
            If rdoMinnes.Checked Then
                result += 30
                txtPay.Text = result
            Else
                If rdoTri.Checked Then
                    result += 30
                    txtPay.Text = result
                Else
                    If rdoNonRes.Checked Then
                        result += 30
                        txtPay.Text = result
                    Else
                        If rdoInternat.Checked Then
                            result += 30
                            txtPay.Text = result
                        End If
                    End If
                End If

            End If
        End If
    End Sub
End Class