<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayment
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
        Me.grpState = New System.Windows.Forms.GroupBox()
        Me.rdoInternat = New System.Windows.Forms.RadioButton()
        Me.rdoNonRes = New System.Windows.Forms.RadioButton()
        Me.rdoTri = New System.Windows.Forms.RadioButton()
        Me.rdoMinnes = New System.Windows.Forms.RadioButton()
        Me.rdoWisco = New System.Windows.Forms.RadioButton()
        Me.grpResidence = New System.Windows.Forms.GroupBox()
        Me.rdoNoRes = New System.Windows.Forms.RadioButton()
        Me.rdoYesRes = New System.Windows.Forms.RadioButton()
        Me.lblMealPlan = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.grpParking = New System.Windows.Forms.GroupBox()
        Me.rdoNoPark = New System.Windows.Forms.RadioButton()
        Me.rdoYesPark = New System.Windows.Forms.RadioButton()
        Me.lblPayment = New System.Windows.Forms.Label()
        Me.txtPay = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpState.SuspendLayout()
        Me.grpResidence.SuspendLayout()
        Me.grpParking.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpState
        '
        Me.grpState.Controls.Add(Me.rdoInternat)
        Me.grpState.Controls.Add(Me.rdoNonRes)
        Me.grpState.Controls.Add(Me.rdoTri)
        Me.grpState.Controls.Add(Me.rdoMinnes)
        Me.grpState.Controls.Add(Me.rdoWisco)
        Me.grpState.Location = New System.Drawing.Point(101, 12)
        Me.grpState.Name = "grpState"
        Me.grpState.Size = New System.Drawing.Size(440, 60)
        Me.grpState.TabIndex = 0
        Me.grpState.TabStop = False
        Me.grpState.Text = "Where do you live?"
        '
        'rdoInternat
        '
        Me.rdoInternat.AutoSize = True
        Me.rdoInternat.Location = New System.Drawing.Point(340, 20)
        Me.rdoInternat.Name = "rdoInternat"
        Me.rdoInternat.Size = New System.Drawing.Size(83, 17)
        Me.rdoInternat.TabIndex = 4
        Me.rdoInternat.Text = "International"
        Me.rdoInternat.UseVisualStyleBackColor = True
        '
        'rdoNonRes
        '
        Me.rdoNonRes.AutoSize = True
        Me.rdoNonRes.Location = New System.Drawing.Point(244, 19)
        Me.rdoNonRes.Name = "rdoNonRes"
        Me.rdoNonRes.Size = New System.Drawing.Size(90, 17)
        Me.rdoNonRes.TabIndex = 3
        Me.rdoNonRes.Text = "Non-Resident"
        Me.rdoNonRes.UseVisualStyleBackColor = True
        '
        'rdoTri
        '
        Me.rdoTri.AutoSize = True
        Me.rdoTri.Location = New System.Drawing.Point(173, 20)
        Me.rdoTri.Name = "rdoTri"
        Me.rdoTri.Size = New System.Drawing.Size(65, 17)
        Me.rdoTri.TabIndex = 2
        Me.rdoTri.Text = "Tri-State"
        Me.rdoTri.UseVisualStyleBackColor = True
        '
        'rdoMinnes
        '
        Me.rdoMinnes.AutoSize = True
        Me.rdoMinnes.Location = New System.Drawing.Point(93, 19)
        Me.rdoMinnes.Name = "rdoMinnes"
        Me.rdoMinnes.Size = New System.Drawing.Size(74, 17)
        Me.rdoMinnes.TabIndex = 1
        Me.rdoMinnes.Text = "Minnesota"
        Me.rdoMinnes.UseVisualStyleBackColor = True
        '
        'rdoWisco
        '
        Me.rdoWisco.AutoSize = True
        Me.rdoWisco.Location = New System.Drawing.Point(13, 20)
        Me.rdoWisco.Name = "rdoWisco"
        Me.rdoWisco.Size = New System.Drawing.Size(74, 17)
        Me.rdoWisco.TabIndex = 0
        Me.rdoWisco.Text = "Wisconsin"
        Me.rdoWisco.UseVisualStyleBackColor = True
        '
        'grpResidence
        '
        Me.grpResidence.Controls.Add(Me.rdoNoRes)
        Me.grpResidence.Controls.Add(Me.rdoYesRes)
        Me.grpResidence.Location = New System.Drawing.Point(101, 118)
        Me.grpResidence.Name = "grpResidence"
        Me.grpResidence.Size = New System.Drawing.Size(300, 60)
        Me.grpResidence.TabIndex = 1
        Me.grpResidence.TabStop = False
        Me.grpResidence.Text = "Will you be staying in the Residence Halls?"
        '
        'rdoNoRes
        '
        Me.rdoNoRes.AutoSize = True
        Me.rdoNoRes.Location = New System.Drawing.Point(173, 37)
        Me.rdoNoRes.Name = "rdoNoRes"
        Me.rdoNoRes.Size = New System.Drawing.Size(39, 17)
        Me.rdoNoRes.TabIndex = 1
        Me.rdoNoRes.Text = "No"
        Me.rdoNoRes.UseVisualStyleBackColor = True
        '
        'rdoYesRes
        '
        Me.rdoYesRes.AutoSize = True
        Me.rdoYesRes.Location = New System.Drawing.Point(32, 37)
        Me.rdoYesRes.Name = "rdoYesRes"
        Me.rdoYesRes.Size = New System.Drawing.Size(43, 17)
        Me.rdoYesRes.TabIndex = 0
        Me.rdoYesRes.Text = "Yes"
        Me.rdoYesRes.UseVisualStyleBackColor = True
        '
        'lblMealPlan
        '
        Me.lblMealPlan.AutoSize = True
        Me.lblMealPlan.Location = New System.Drawing.Point(101, 211)
        Me.lblMealPlan.Name = "lblMealPlan"
        Me.lblMealPlan.Size = New System.Drawing.Size(100, 13)
        Me.lblMealPlan.TabIndex = 2
        Me.lblMealPlan.Text = "Choose a meal plan"
        Me.lblMealPlan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Regular", "" & Global.Microsoft.VisualBasic.ChrW(9) & "19 meals per week", "" & Global.Microsoft.VisualBasic.ChrW(9) & "15 meals per week", "" & Global.Microsoft.VisualBasic.ChrW(9) & "14 meals per week and $50 per semester", "" & Global.Microsoft.VisualBasic.ChrW(9) & "110 meals and $125 per semester", "" & Global.Microsoft.VisualBasic.ChrW(9) & "90 meals and $100 per semester", "" & Global.Microsoft.VisualBasic.ChrW(9) & "150 meals and $100 per semester", "" & Global.Microsoft.VisualBasic.ChrW(9) & "175 meals and $100 per semester", "Commute and off-campus only meal plan", "" & Global.Microsoft.VisualBasic.ChrW(9) & "No meal plan", "" & Global.Microsoft.VisualBasic.ChrW(9) & "50 meals per semester", "" & Global.Microsoft.VisualBasic.ChrW(9) & "50 meals and $75 per semester", "" & Global.Microsoft.VisualBasic.ChrW(9) & "75 meals and $100 per semester"})
        Me.ComboBox1.Location = New System.Drawing.Point(104, 227)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(220, 21)
        Me.ComboBox1.TabIndex = 3
        '
        'grpParking
        '
        Me.grpParking.Controls.Add(Me.rdoNoPark)
        Me.grpParking.Controls.Add(Me.rdoYesPark)
        Me.grpParking.Location = New System.Drawing.Point(104, 268)
        Me.grpParking.Name = "grpParking"
        Me.grpParking.Size = New System.Drawing.Size(300, 60)
        Me.grpParking.TabIndex = 4
        Me.grpParking.TabStop = False
        Me.grpParking.Text = "Are you planning to park your car on campus?"
        '
        'rdoNoPark
        '
        Me.rdoNoPark.AutoSize = True
        Me.rdoNoPark.Location = New System.Drawing.Point(170, 37)
        Me.rdoNoPark.Name = "rdoNoPark"
        Me.rdoNoPark.Size = New System.Drawing.Size(39, 17)
        Me.rdoNoPark.TabIndex = 1
        Me.rdoNoPark.Text = "No"
        Me.rdoNoPark.UseVisualStyleBackColor = True
        '
        'rdoYesPark
        '
        Me.rdoYesPark.AutoSize = True
        Me.rdoYesPark.Location = New System.Drawing.Point(20, 37)
        Me.rdoYesPark.Name = "rdoYesPark"
        Me.rdoYesPark.Size = New System.Drawing.Size(43, 17)
        Me.rdoYesPark.TabIndex = 0
        Me.rdoYesPark.Text = "Yes"
        Me.rdoYesPark.UseVisualStyleBackColor = True
        '
        'lblPayment
        '
        Me.lblPayment.AutoSize = True
        Me.lblPayment.Location = New System.Drawing.Point(167, 341)
        Me.lblPayment.Name = "lblPayment"
        Me.lblPayment.Size = New System.Drawing.Size(146, 13)
        Me.lblPayment.TabIndex = 5
        Me.lblPayment.Text = "Your payment this semester is"
        Me.lblPayment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPay
        '
        Me.txtPay.BackColor = System.Drawing.SystemColors.Window
        Me.txtPay.Location = New System.Drawing.Point(185, 370)
        Me.txtPay.Name = "txtPay"
        Me.txtPay.ReadOnly = True
        Me.txtPay.Size = New System.Drawing.Size(100, 20)
        Me.txtPay.TabIndex = 6
        Me.txtPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(141, 48)
        '
        'BackToolStripMenuItem
        '
        Me.BackToolStripMenuItem.Name = "BackToolStripMenuItem"
        Me.BackToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.BackToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.BackToolStripMenuItem.Text = "Back"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'frmPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(704, 412)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.txtPay)
        Me.Controls.Add(Me.lblPayment)
        Me.Controls.Add(Me.grpParking)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.lblMealPlan)
        Me.Controls.Add(Me.grpResidence)
        Me.Controls.Add(Me.grpState)
        Me.MinimumSize = New System.Drawing.Size(450, 330)
        Me.Name = "frmPayment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lab6NickKvigne"
        Me.grpState.ResumeLayout(False)
        Me.grpState.PerformLayout()
        Me.grpResidence.ResumeLayout(False)
        Me.grpResidence.PerformLayout()
        Me.grpParking.ResumeLayout(False)
        Me.grpParking.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpState As System.Windows.Forms.GroupBox
    Friend WithEvents rdoInternat As System.Windows.Forms.RadioButton
    Friend WithEvents rdoNonRes As System.Windows.Forms.RadioButton
    Friend WithEvents rdoTri As System.Windows.Forms.RadioButton
    Friend WithEvents rdoMinnes As System.Windows.Forms.RadioButton
    Friend WithEvents rdoWisco As System.Windows.Forms.RadioButton
    Friend WithEvents grpResidence As System.Windows.Forms.GroupBox
    Friend WithEvents rdoNoRes As System.Windows.Forms.RadioButton
    Friend WithEvents rdoYesRes As System.Windows.Forms.RadioButton
    Friend WithEvents lblMealPlan As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents grpParking As System.Windows.Forms.GroupBox
    Friend WithEvents rdoNoPark As System.Windows.Forms.RadioButton
    Friend WithEvents rdoYesPark As System.Windows.Forms.RadioButton
    Friend WithEvents lblPayment As System.Windows.Forms.Label
    Friend WithEvents txtPay As System.Windows.Forms.TextBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents BackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
