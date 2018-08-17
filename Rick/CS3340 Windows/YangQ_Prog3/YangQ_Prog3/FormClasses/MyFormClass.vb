Imports UWPCS3340

Public Class MyFormClass
   Dim p As Person
   Private aPerson As Person

   Protected _frmList As FormClassList

   Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
      If rdoPerson.Checked Then
         'p = New UWPCS3340.Person(txtName.Text)
      ElseIf rdoStudent.Checked Then
         p = New UWPCS3340.Student(txtName.Text)
      Else

         p = New UWPCS3340.Faculty(txtName.Text)

      End If

      AddHandler p.Over40Miles, AddressOf p_Over40Miles


   End Sub

   Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
      MessageBox.Show(p.Name & Chr(Keys.LineFeed) & p.TotalMiles)

      Console.WriteLine(p.ToString())

   End Sub

   Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
      Try
         p.Name = txtName.Text
      Catch ex As Exception
         MessageBox.Show(ex.Message)

      End Try

   End Sub

   Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
      Try
         p.WorkOut(txtMiles.Text)
      Catch ex As Exception
         MessageBox.Show(ex.Message)

      End Try
   End Sub

   Private Sub p_Over40Miles(theName As String, totalMiles As Single) 'Handles p.Over40Miles
      ' what you want to do?
      MessageBox.Show(theName & " has worked out " & totalMiles & " miles.")

   End Sub

   Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

      aPerson = Person.GetPersonByIndex(txtIndex.Text)

   End Sub

   Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
      If p Is aPerson Then
         Console.WriteLine("P and aPerson point to the same person (object)")
      Else
         Console.WriteLine("P and aPerson point to different persons (objects)")
      End If

      If p.Equals(aPerson) Then
         Console.WriteLine("P equals aPerson (have the same total miles)")
      Else
         Console.WriteLine("P does not equal aPerson (have different total miles)")
      End If

   End Sub

   Private Sub MyFormClass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      _frmList = New FormClassList
      _frmList.MainForm = Me
   End Sub

   Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
      Me.Hide()
      _frmList.Show()
      _frmList.BringToFront()
   End Sub
End Class
