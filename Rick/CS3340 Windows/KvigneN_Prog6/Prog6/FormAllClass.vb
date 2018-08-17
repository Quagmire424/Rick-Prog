Public Class FormAllClass
    Private Sub EmployeeBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles EmployeeBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EmployeeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ActivityDataSet)

    End Sub

    Private Sub FormAllClass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ActivityDataSet.Employee' table. You can move, or remove it, as needed.
        Me.EmployeeTableAdapter.Fill(Me.ActivityDataSet.Employee)

    End Sub
End Class
