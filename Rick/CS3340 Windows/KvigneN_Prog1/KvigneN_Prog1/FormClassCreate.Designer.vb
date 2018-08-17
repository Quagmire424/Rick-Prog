<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormClassCreate
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
        Me.txtCaption = New System.Windows.Forms.TextBox()
        Me.txtKey = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuShow = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuButton = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCreate = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRemove = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblCaption = New System.Windows.Forms.Label()
        Me.lblKey = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtCaption
        '
        Me.txtCaption.Location = New System.Drawing.Point(290, 156)
        Me.txtCaption.Name = "txtCaption"
        Me.txtCaption.Size = New System.Drawing.Size(100, 20)
        Me.txtCaption.TabIndex = 1
        Me.txtCaption.Text = "First"
        '
        'txtKey
        '
        Me.txtKey.Location = New System.Drawing.Point(111, 156)
        Me.txtKey.Name = "txtKey"
        Me.txtKey.Size = New System.Drawing.Size(100, 20)
        Me.txtKey.TabIndex = 0
        Me.txtKey.Text = "S17"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuButton})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(500, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuShow, Me.ToolStripMenuItem2, Me.mnuExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "&File"
        '
        'mnuShow
        '
        Me.mnuShow.Name = "mnuShow"
        Me.mnuShow.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuShow.Size = New System.Drawing.Size(152, 22)
        Me.mnuShow.Text = "&SHOW"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(149, 6)
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.mnuExit.Size = New System.Drawing.Size(152, 22)
        Me.mnuExit.Text = "E&XIT"
        '
        'mnuButton
        '
        Me.mnuButton.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCreate, Me.mnuRemove})
        Me.mnuButton.Name = "mnuButton"
        Me.mnuButton.Size = New System.Drawing.Size(55, 20)
        Me.mnuButton.Text = "&Button"
        '
        'mnuCreate
        '
        Me.mnuCreate.Name = "mnuCreate"
        Me.mnuCreate.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.mnuCreate.Size = New System.Drawing.Size(161, 22)
        Me.mnuCreate.Text = "&CREATE"
        '
        'mnuRemove
        '
        Me.mnuRemove.Name = "mnuRemove"
        Me.mnuRemove.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.mnuRemove.Size = New System.Drawing.Size(161, 22)
        Me.mnuRemove.Text = "&REMOVE"
        '
        'lblCaption
        '
        Me.lblCaption.AutoSize = True
        Me.lblCaption.Location = New System.Drawing.Point(302, 140)
        Me.lblCaption.Name = "lblCaption"
        Me.lblCaption.Size = New System.Drawing.Size(77, 13)
        Me.lblCaption.TabIndex = 3
        Me.lblCaption.Text = "Button Caption"
        '
        'lblKey
        '
        Me.lblKey.AutoSize = True
        Me.lblKey.Location = New System.Drawing.Point(132, 140)
        Me.lblKey.Name = "lblKey"
        Me.lblKey.Size = New System.Drawing.Size(59, 13)
        Me.lblKey.TabIndex = 4
        Me.lblKey.Text = "Button Key"
        '
        'FormClassCreate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 317)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblKey)
        Me.Controls.Add(Me.lblCaption)
        Me.Controls.Add(Me.txtKey)
        Me.Controls.Add(Me.txtCaption)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormClassCreate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Program 1 - Nick Kvigne"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCaption As System.Windows.Forms.TextBox
    Friend WithEvents txtKey As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuButton As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblCaption As System.Windows.Forms.Label
    Friend WithEvents lblKey As System.Windows.Forms.Label
    Friend WithEvents mnuShow As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCreate As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRemove As System.Windows.Forms.ToolStripMenuItem

End Class
