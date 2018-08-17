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
        Me.mnuFile = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCompute = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.PeriodsPerYearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuYearly = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuQuarterly = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMonthly = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDaily = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.lstFuture = New System.Windows.Forms.ListBox()
        Me.lblFutureValues = New System.Windows.Forms.Label()
        Me.txtPrinciple = New System.Windows.Forms.TextBox()
        Me.cboRate = New System.Windows.Forms.ComboBox()
        Me.txtStartYear = New System.Windows.Forms.TextBox()
        Me.txtEndYear = New System.Windows.Forms.TextBox()
        Me.lblPrinciple = New System.Windows.Forms.Label()
        Me.lblAnnualRate = New System.Windows.Forms.Label()
        Me.lblStartYear = New System.Windows.Forms.Label()
        Me.lblEndYear = New System.Windows.Forms.Label()
        Me.mnuFile.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuFile
        '
        Me.mnuFile.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.PeriodsPerYearToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.mnuFile.Location = New System.Drawing.Point(0, 0)
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(604, 24)
        Me.mnuFile.TabIndex = 0
        Me.mnuFile.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCompute, Me.ToolStripSeparator1, Me.mnuExit})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'mnuCompute
        '
        Me.mnuCompute.Name = "mnuCompute"
        Me.mnuCompute.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.mnuCompute.Size = New System.Drawing.Size(166, 22)
        Me.mnuCompute.Text = "&Compute"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(163, 6)
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.mnuExit.Size = New System.Drawing.Size(166, 22)
        Me.mnuExit.Text = "E&xit"
        '
        'PeriodsPerYearToolStripMenuItem
        '
        Me.PeriodsPerYearToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuYearly, Me.mnuQuarterly, Me.mnuMonthly, Me.mnuDaily})
        Me.PeriodsPerYearToolStripMenuItem.Name = "PeriodsPerYearToolStripMenuItem"
        Me.PeriodsPerYearToolStripMenuItem.Size = New System.Drawing.Size(108, 20)
        Me.PeriodsPerYearToolStripMenuItem.Text = "&Periods_Per_Year"
        '
        'mnuYearly
        '
        Me.mnuYearly.Name = "mnuYearly"
        Me.mnuYearly.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.mnuYearly.Size = New System.Drawing.Size(134, 22)
        Me.mnuYearly.Text = "1"
        '
        'mnuQuarterly
        '
        Me.mnuQuarterly.Name = "mnuQuarterly"
        Me.mnuQuarterly.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.mnuQuarterly.Size = New System.Drawing.Size(134, 22)
        Me.mnuQuarterly.Text = "4"
        '
        'mnuMonthly
        '
        Me.mnuMonthly.Checked = True
        Me.mnuMonthly.CheckOnClick = True
        Me.mnuMonthly.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnuMonthly.Name = "mnuMonthly"
        Me.mnuMonthly.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.mnuMonthly.Size = New System.Drawing.Size(134, 22)
        Me.mnuMonthly.Text = "12"
        '
        'mnuDaily
        '
        Me.mnuDaily.Name = "mnuDaily"
        Me.mnuDaily.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.mnuDaily.Size = New System.Drawing.Size(134, 22)
        Me.mnuDaily.Text = "365"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAbout})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'mnuAbout
        '
        Me.mnuAbout.Name = "mnuAbout"
        Me.mnuAbout.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.mnuAbout.Size = New System.Drawing.Size(149, 22)
        Me.mnuAbout.Text = "&About"
        '
        'lstFuture
        '
        Me.lstFuture.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstFuture.FormatString = "C2"
        Me.lstFuture.FormattingEnabled = True
        Me.lstFuture.ItemHeight = 21
        Me.lstFuture.Location = New System.Drawing.Point(117, 97)
        Me.lstFuture.Name = "lstFuture"
        Me.lstFuture.Size = New System.Drawing.Size(370, 193)
        Me.lstFuture.TabIndex = 4
        '
        'lblFutureValues
        '
        Me.lblFutureValues.AutoSize = True
        Me.lblFutureValues.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFutureValues.Location = New System.Drawing.Point(207, 46)
        Me.lblFutureValues.Name = "lblFutureValues"
        Me.lblFutureValues.Size = New System.Drawing.Size(141, 24)
        Me.lblFutureValues.TabIndex = 2
        Me.lblFutureValues.Text = "Future Values"
        '
        'txtPrinciple
        '
        Me.txtPrinciple.Location = New System.Drawing.Point(56, 341)
        Me.txtPrinciple.Name = "txtPrinciple"
        Me.txtPrinciple.Size = New System.Drawing.Size(100, 20)
        Me.txtPrinciple.TabIndex = 0
        '
        'cboRate
        '
        Me.cboRate.FormattingEnabled = True
        Me.cboRate.Items.AddRange(New Object() {"5%", "6%", "7%", "8%", "9%", "10%", "11%", "12%"})
        Me.cboRate.Location = New System.Drawing.Point(193, 339)
        Me.cboRate.Name = "cboRate"
        Me.cboRate.Size = New System.Drawing.Size(121, 21)
        Me.cboRate.TabIndex = 1
        '
        'txtStartYear
        '
        Me.txtStartYear.Location = New System.Drawing.Point(351, 340)
        Me.txtStartYear.Name = "txtStartYear"
        Me.txtStartYear.Size = New System.Drawing.Size(100, 20)
        Me.txtStartYear.TabIndex = 2
        '
        'txtEndYear
        '
        Me.txtEndYear.Location = New System.Drawing.Point(468, 339)
        Me.txtEndYear.Name = "txtEndYear"
        Me.txtEndYear.Size = New System.Drawing.Size(100, 20)
        Me.txtEndYear.TabIndex = 3
        '
        'lblPrinciple
        '
        Me.lblPrinciple.AutoSize = True
        Me.lblPrinciple.Location = New System.Drawing.Point(56, 309)
        Me.lblPrinciple.Name = "lblPrinciple"
        Me.lblPrinciple.Size = New System.Drawing.Size(47, 13)
        Me.lblPrinciple.TabIndex = 7
        Me.lblPrinciple.Text = "Principle"
        '
        'lblAnnualRate
        '
        Me.lblAnnualRate.AutoSize = True
        Me.lblAnnualRate.Location = New System.Drawing.Point(193, 309)
        Me.lblAnnualRate.Name = "lblAnnualRate"
        Me.lblAnnualRate.Size = New System.Drawing.Size(104, 13)
        Me.lblAnnualRate.TabIndex = 8
        Me.lblAnnualRate.Text = "Annual Interest Rate"
        '
        'lblStartYear
        '
        Me.lblStartYear.AutoSize = True
        Me.lblStartYear.Location = New System.Drawing.Point(351, 309)
        Me.lblStartYear.Name = "lblStartYear"
        Me.lblStartYear.Size = New System.Drawing.Size(54, 13)
        Me.lblStartYear.TabIndex = 9
        Me.lblStartYear.Text = "Start Year"
        '
        'lblEndYear
        '
        Me.lblEndYear.AutoSize = True
        Me.lblEndYear.Location = New System.Drawing.Point(468, 309)
        Me.lblEndYear.Name = "lblEndYear"
        Me.lblEndYear.Size = New System.Drawing.Size(51, 13)
        Me.lblEndYear.TabIndex = 10
        Me.lblEndYear.Text = "End Year"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(604, 462)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblEndYear)
        Me.Controls.Add(Me.lblStartYear)
        Me.Controls.Add(Me.lblAnnualRate)
        Me.Controls.Add(Me.lblPrinciple)
        Me.Controls.Add(Me.txtEndYear)
        Me.Controls.Add(Me.txtStartYear)
        Me.Controls.Add(Me.cboRate)
        Me.Controls.Add(Me.txtPrinciple)
        Me.Controls.Add(Me.lblFutureValues)
        Me.Controls.Add(Me.lstFuture)
        Me.Controls.Add(Me.mnuFile)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.mnuFile
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lab4NickKvigne"
        Me.mnuFile.ResumeLayout(False)
        Me.mnuFile.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnuFile As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCompute As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PeriodsPerYearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuYearly As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuQuarterly As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuMonthly As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDaily As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lstFuture As System.Windows.Forms.ListBox
   Friend WithEvents lblFutureValues As System.Windows.Forms.Label
   Friend WithEvents txtPrinciple As System.Windows.Forms.TextBox
   Friend WithEvents cboRate As System.Windows.Forms.ComboBox
   Friend WithEvents txtStartYear As System.Windows.Forms.TextBox
   Friend WithEvents txtEndYear As System.Windows.Forms.TextBox
   Friend WithEvents lblPrinciple As System.Windows.Forms.Label
   Friend WithEvents lblAnnualRate As System.Windows.Forms.Label
   Friend WithEvents lblStartYear As System.Windows.Forms.Label
   Friend WithEvents lblEndYear As System.Windows.Forms.Label

End Class
