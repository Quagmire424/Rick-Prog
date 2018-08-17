Public Class Form1
   Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      DataGridView1.DataSource = Oracle.myTable

   End Sub

   Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
      Application.Exit()
   End Sub

   Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

      Try
         Me.BindingContext(Oracle.myTable).EndCurrentEdit()
         Oracle.myOracleDataAdapter.Update(Oracle.myTable)
      Catch ex As Exception
         MessageBox.Show(ex.Message)
      End Try

   End Sub

   Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
      Dim field, op, value As String

      field = ComboBox1.SelectedItem.ToString
      op = ComboBox2.SelectedItem.ToString
      value = TextBox1.Text.Trim

      If field = "Date_From" Or field = "Date_To" Then

         ' For Date values
         ' Could enter dates in different formats 
         Oracle.myOracleCommand.CommandText =
                       "Select * " &
                       "From Booking " &
                       "Where " & field & op & "to_Date('" & value & "', 'mm/dd/yyyy')"

      Else

         ' For string values
         Oracle.myOracleCommand.CommandText =
                          "Select * " &
                          "From Booking " &
                          "Where " & field & op & " '" & value & "'"
      End If


      Console.WriteLine(Oracle.myOracleCommand.CommandText)

      ' Catch exception
      Try
         Oracle.myTable.Clear()
         Oracle.myOracleDataAdapter.Fill(Oracle.myTable)
      Catch ex As Exception
         MessageBox.Show(ex.Message)
      End Try

   End Sub

   Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
      Oracle.myOracleCommand.CommandText =
                      "Select * " &
                      "From Booking "


      Console.WriteLine(Oracle.myOracleCommand.CommandText)

      ' Catch exception
      Try
         Oracle.myTable.Clear()
         Oracle.myOracleDataAdapter.Fill(Oracle.myTable)
      Catch ex As Exception
         MessageBox.Show(ex.Message)
      End Try

   End Sub
End Class
