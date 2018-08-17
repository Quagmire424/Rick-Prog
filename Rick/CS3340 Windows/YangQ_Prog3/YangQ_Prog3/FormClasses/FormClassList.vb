Public Class FormClassList

   Private _mainForm As Form

   Public Property MainForm As Form
      Get
         Return _mainForm
      End Get
      Set(value As Form)
         _mainForm = value
      End Set
   End Property

   Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
      Me.Hide()
      _mainForm.Show()
      _mainForm.BringToFront()
   End Sub
End Class