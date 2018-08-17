<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
   Inherits System.Windows.Forms.Form

   'Form overrides dispose to clean up the component list.
   <System.Diagnostics.DebuggerNonUserCode()> _
   Protected Overrides Sub Dispose(ByVal disposing As Boolean)
      Try
         If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
         End If
      Finally
         MyBase.Dispose(disposing)
      End Try
   End Sub

   'Required by the Windows Form Designer
   Private components As System.ComponentModel.IContainer

   'NOTE: The following procedure is required by the Windows Form Designer
   'It can be modified using the Windows Form Designer.  
   'Do not modify it using the code editor.
   <System.Diagnostics.DebuggerStepThrough()> _
   Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container()
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
      Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
      Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
      Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
      Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
      Me.CascadeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.TileVerticalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.TileHorizontalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.ArrangeIconsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
      Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
      Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
      Me.lblDateTime = New System.Windows.Forms.ToolStripStatusLabel()
      Me.lblDate = New System.Windows.Forms.ToolStripStatusLabel()
      Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
      Me.ToolStrip1.SuspendLayout()
      Me.StatusStrip1.SuspendLayout()
      Me.SuspendLayout()
      '
      'ToolStrip1
      '
      Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripDropDownButton1})
      Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
      Me.ToolStrip1.Name = "ToolStrip1"
      Me.ToolStrip1.Size = New System.Drawing.Size(622, 25)
      Me.ToolStrip1.TabIndex = 1
      Me.ToolStrip1.Text = "ToolStrip1"
      '
      'ToolStripButton1
      '
      Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
      Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
      Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.ToolStripButton1.Name = "ToolStripButton1"
      Me.ToolStripButton1.Size = New System.Drawing.Size(35, 22)
      Me.ToolStripButton1.Text = "New"
      '
      'ToolStripButton2
      '
      Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
      Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
      Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.ToolStripButton2.Name = "ToolStripButton2"
      Me.ToolStripButton2.Size = New System.Drawing.Size(29, 22)
      Me.ToolStripButton2.Text = "Exit"
      '
      'ToolStripDropDownButton1
      '
      Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
      Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CascadeToolStripMenuItem, Me.TileVerticalToolStripMenuItem, Me.TileHorizontalToolStripMenuItem, Me.ArrangeIconsToolStripMenuItem})
      Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
      Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
      Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(69, 22)
      Me.ToolStripDropDownButton1.Text = "Windows"
      '
      'CascadeToolStripMenuItem
      '
      Me.CascadeToolStripMenuItem.Name = "CascadeToolStripMenuItem"
      Me.CascadeToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
      Me.CascadeToolStripMenuItem.Text = "Cascade"
      '
      'TileVerticalToolStripMenuItem
      '
      Me.TileVerticalToolStripMenuItem.Name = "TileVerticalToolStripMenuItem"
      Me.TileVerticalToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
      Me.TileVerticalToolStripMenuItem.Text = "Tile Vertical"
      '
      'TileHorizontalToolStripMenuItem
      '
      Me.TileHorizontalToolStripMenuItem.Name = "TileHorizontalToolStripMenuItem"
      Me.TileHorizontalToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
      Me.TileHorizontalToolStripMenuItem.Text = "Tile Horizontal"
      '
      'ArrangeIconsToolStripMenuItem
      '
      Me.ArrangeIconsToolStripMenuItem.Name = "ArrangeIconsToolStripMenuItem"
      Me.ArrangeIconsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
      Me.ArrangeIconsToolStripMenuItem.Text = "Arrange Icons"
      '
      'StatusStrip1
      '
      Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.lblDate, Me.lblDateTime})
      Me.StatusStrip1.Location = New System.Drawing.Point(0, 416)
      Me.StatusStrip1.Name = "StatusStrip1"
      Me.StatusStrip1.Size = New System.Drawing.Size(622, 22)
      Me.StatusStrip1.TabIndex = 2
      Me.StatusStrip1.Text = "StatusStrip1"
      '
      'ToolStripStatusLabel1
      '
      Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
      Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(77, 17)
      Me.ToolStripStatusLabel1.Text = "UWP CS 3340"
      '
      'ToolStripStatusLabel2
      '
      Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
      Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(259, 17)
      Me.ToolStripStatusLabel2.Spring = True
      '
      'lblDateTime
      '
      Me.lblDateTime.Name = "lblDateTime"
      Me.lblDateTime.Size = New System.Drawing.Size(120, 17)
      Me.lblDateTime.Text = "ToolStripStatusLabel3"
      '
      'lblDate
      '
      Me.lblDate.Name = "lblDate"
      Me.lblDate.Size = New System.Drawing.Size(120, 17)
      Me.lblDate.Text = "ToolStripStatusLabel3"
      '
      'Timer1
      '
      Me.Timer1.Enabled = True
      Me.Timer1.Interval = 3000
      '
      'Form1
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(622, 438)
      Me.Controls.Add(Me.StatusStrip1)
      Me.Controls.Add(Me.ToolStrip1)
      Me.IsMdiContainer = True
      Me.Name = "Form1"
      Me.Text = "Form1"
      Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
      Me.ToolStrip1.ResumeLayout(False)
      Me.ToolStrip1.PerformLayout()
      Me.StatusStrip1.ResumeLayout(False)
      Me.StatusStrip1.PerformLayout()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub

   Friend WithEvents ToolStrip1 As ToolStrip
   Friend WithEvents ToolStripButton1 As ToolStripButton
   Friend WithEvents ToolStripButton2 As ToolStripButton
   Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
   Friend WithEvents CascadeToolStripMenuItem As ToolStripMenuItem
   Friend WithEvents TileVerticalToolStripMenuItem As ToolStripMenuItem
   Friend WithEvents TileHorizontalToolStripMenuItem As ToolStripMenuItem
   Friend WithEvents ArrangeIconsToolStripMenuItem As ToolStripMenuItem
   Friend WithEvents StatusStrip1 As StatusStrip
   Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
   Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
   Friend WithEvents lblDateTime As ToolStripStatusLabel
   Friend WithEvents lblDate As ToolStripStatusLabel
   Friend WithEvents Timer1 As Timer
End Class
