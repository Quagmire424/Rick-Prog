Public Class Form1
   Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      Dim f As New UWPCS3340.MyFormClass

      f.MdiParent = Me

      f.Show()

      lblDateTime.Text = Now.ToLongTimeString
      lblDate.Text = Now.ToShortDateString
   End Sub

   Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
      Application.Exit()
   End Sub

   Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
      Dim b As New Form2

      b.BranchNo = 1
      b.MdiParent = Me
      b.Show()

   End Sub

   Private Sub CascadeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CascadeToolStripMenuItem.Click
      Me.LayoutMdi(MdiLayout.Cascade)
   End Sub

   Private Sub TileVerticalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
      Me.LayoutMdi(MdiLayout.TileVertical)
   End Sub

   Private Sub TileHorizontalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
      Me.LayoutMdi(MdiLayout.TileHorizontal)
   End Sub

   Private Sub ArrangeIconsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
      Me.LayoutMdi(MdiLayout.ArrangeIcons)
   End Sub

   Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
      lblDateTime.Text = Now.ToLongTimeString
      lblDate.Text = Now.ToShortDateString

   End Sub
End Class
