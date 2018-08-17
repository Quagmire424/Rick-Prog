<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PayForm
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
        Me.lblPayRoll = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblHours = New System.Windows.Forms.Label()
        Me.lblRate = New System.Windows.Forms.Label()
        Me.lblGross = New System.Windows.Forms.Label()
        Me.lblDeduct = New System.Windows.Forms.Label()
        Me.lblNet = New System.Windows.Forms.Label()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtHours = New System.Windows.Forms.TextBox()
        Me.txtRate = New System.Windows.Forms.TextBox()
        Me.txtGross = New System.Windows.Forms.TextBox()
        Me.txtDeduct = New System.Windows.Forms.TextBox()
        Me.txtNet = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComputeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblPayRoll
        '
        Me.lblPayRoll.AutoSize = True
        Me.lblPayRoll.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayRoll.Location = New System.Drawing.Point(361, 70)
        Me.lblPayRoll.Name = "lblPayRoll"
        Me.lblPayRoll.Size = New System.Drawing.Size(188, 25)
        Me.lblPayRoll.TabIndex = 0
        Me.lblPayRoll.Text = "PayRoll Program"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(107, 135)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(18, 13)
        Me.lblID.TabIndex = 1
        Me.lblID.Text = "ID"
        '
        'lblHours
        '
        Me.lblHours.AutoSize = True
        Me.lblHours.Location = New System.Drawing.Point(94, 232)
        Me.lblHours.Name = "lblHours"
        Me.lblHours.Size = New System.Drawing.Size(35, 13)
        Me.lblHours.TabIndex = 2
        Me.lblHours.Text = "Hours"
        '
        'lblRate
        '
        Me.lblRate.AutoSize = True
        Me.lblRate.Location = New System.Drawing.Point(97, 329)
        Me.lblRate.Name = "lblRate"
        Me.lblRate.Size = New System.Drawing.Size(30, 13)
        Me.lblRate.TabIndex = 3
        Me.lblRate.Text = "Rate"
        '
        'lblGross
        '
        Me.lblGross.AutoSize = True
        Me.lblGross.Location = New System.Drawing.Point(718, 135)
        Me.lblGross.Name = "lblGross"
        Me.lblGross.Size = New System.Drawing.Size(55, 13)
        Me.lblGross.TabIndex = 4
        Me.lblGross.Text = "Gross Pay"
        '
        'lblDeduct
        '
        Me.lblDeduct.AutoSize = True
        Me.lblDeduct.Location = New System.Drawing.Point(710, 232)
        Me.lblDeduct.Name = "lblDeduct"
        Me.lblDeduct.Size = New System.Drawing.Size(56, 13)
        Me.lblDeduct.TabIndex = 5
        Me.lblDeduct.Text = "Deduction"
        '
        'lblNet
        '
        Me.lblNet.AutoSize = True
        Me.lblNet.Location = New System.Drawing.Point(713, 329)
        Me.lblNet.Name = "lblNet"
        Me.lblNet.Size = New System.Drawing.Size(45, 13)
        Me.lblNet.TabIndex = 6
        Me.lblNet.Text = "Net Pay"
        '
        'btnCompute
        '
        Me.btnCompute.Location = New System.Drawing.Point(163, 431)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(75, 23)
        Me.btnCompute.TabIndex = 7
        Me.btnCompute.Text = "&Compute"
        Me.btnCompute.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(418, 430)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 8
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(673, 430)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(97, 180)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(100, 20)
        Me.txtID.TabIndex = 10
        '
        'txtHours
        '
        Me.txtHours.Location = New System.Drawing.Point(100, 277)
        Me.txtHours.Name = "txtHours"
        Me.txtHours.Size = New System.Drawing.Size(100, 20)
        Me.txtHours.TabIndex = 11
        '
        'txtRate
        '
        Me.txtRate.Location = New System.Drawing.Point(97, 374)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(100, 20)
        Me.txtRate.TabIndex = 12
        '
        'txtGross
        '
        Me.txtGross.BackColor = System.Drawing.SystemColors.Window
        Me.txtGross.Location = New System.Drawing.Point(713, 180)
        Me.txtGross.Name = "txtGross"
        Me.txtGross.ReadOnly = True
        Me.txtGross.Size = New System.Drawing.Size(100, 20)
        Me.txtGross.TabIndex = 13
        Me.txtGross.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDeduct
        '
        Me.txtDeduct.BackColor = System.Drawing.SystemColors.Window
        Me.txtDeduct.Location = New System.Drawing.Point(716, 277)
        Me.txtDeduct.Name = "txtDeduct"
        Me.txtDeduct.ReadOnly = True
        Me.txtDeduct.Size = New System.Drawing.Size(100, 20)
        Me.txtDeduct.TabIndex = 14
        Me.txtDeduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNet
        '
        Me.txtNet.BackColor = System.Drawing.SystemColors.Window
        Me.txtNet.Location = New System.Drawing.Point(703, 374)
        Me.txtNet.Name = "txtNet"
        Me.txtNet.ReadOnly = True
        Me.txtNet.Size = New System.Drawing.Size(100, 20)
        Me.txtNet.TabIndex = 15
        Me.txtNet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(910, 24)
        Me.MenuStrip1.TabIndex = 16
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ComputeToolStripMenuItem, Me.NextToolStripMenuItem, Me.StatsToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ComputeToolStripMenuItem
        '
        Me.ComputeToolStripMenuItem.Name = "ComputeToolStripMenuItem"
        Me.ComputeToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.ComputeToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.ComputeToolStripMenuItem.Text = "&Compute"
        '
        'NextToolStripMenuItem
        '
        Me.NextToolStripMenuItem.Enabled = False
        Me.NextToolStripMenuItem.Name = "NextToolStripMenuItem"
        Me.NextToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NextToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.NextToolStripMenuItem.Text = "&Next"
        '
        'StatsToolStripMenuItem
        '
        Me.StatsToolStripMenuItem.Name = "StatsToolStripMenuItem"
        Me.StatsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.StatsToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.StatsToolStripMenuItem.Text = "&Stats"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(163, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'PayForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(910, 492)
        Me.Controls.Add(Me.txtNet)
        Me.Controls.Add(Me.txtDeduct)
        Me.Controls.Add(Me.txtGross)
        Me.Controls.Add(Me.txtRate)
        Me.Controls.Add(Me.txtHours)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.lblNet)
        Me.Controls.Add(Me.lblDeduct)
        Me.Controls.Add(Me.lblGross)
        Me.Controls.Add(Me.lblRate)
        Me.Controls.Add(Me.lblHours)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.lblPayRoll)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "PayForm"
        Me.Text = "Lab5NickKvigne"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPayRoll As System.Windows.Forms.Label
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents lblHours As System.Windows.Forms.Label
    Friend WithEvents lblRate As System.Windows.Forms.Label
    Friend WithEvents lblGross As System.Windows.Forms.Label
    Friend WithEvents lblDeduct As System.Windows.Forms.Label
    Friend WithEvents lblNet As System.Windows.Forms.Label
    Friend WithEvents btnCompute As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents txtHours As System.Windows.Forms.TextBox
    Friend WithEvents txtRate As System.Windows.Forms.TextBox
    Friend WithEvents txtGross As System.Windows.Forms.TextBox
    Friend WithEvents txtDeduct As System.Windows.Forms.TextBox
    Friend WithEvents txtNet As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComputeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NextToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
