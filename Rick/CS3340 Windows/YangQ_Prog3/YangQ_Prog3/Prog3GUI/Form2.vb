Public Class Form2

   Private _branchMo As Integer

   Public WriteOnly Property BranchNo As Integer
      Set(value As Integer)
         _branchMo = value
         Me.Text = "Branch #" & _branchMo
         '_frmList.Text = "Branch #" & _branchMo
         '_frmList.MdiParent = Me.MdiParent
      End Set
   End Property

   Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

   End Sub
End Class
