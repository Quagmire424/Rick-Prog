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
        Me.lblPayroll = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtHours = New System.Windows.Forms.TextBox()
        Me.txtRate = New System.Windows.Forms.TextBox()
        Me.txtGross = New System.Windows.Forms.TextBox()
        Me.txtDeduction = New System.Windows.Forms.TextBox()
        Me.txtNet = New System.Windows.Forms.TextBox()
        Me.lblId = New System.Windows.Forms.Label()
        Me.lblHours = New System.Windows.Forms.Label()
        Me.lblRate = New System.Windows.Forms.Label()
        Me.lblGross = New System.Windows.Forms.Label()
        Me.lblDeduction = New System.Windows.Forms.Label()
        Me.lblNet = New System.Windows.Forms.Label()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblPayroll
        '
        Me.lblPayroll.AutoSize = True
        Me.lblPayroll.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayroll.Location = New System.Drawing.Point(173, 87)
        Me.lblPayroll.Name = "lblPayroll"
        Me.lblPayroll.Size = New System.Drawing.Size(138, 21)
        Me.lblPayroll.TabIndex = 0
        Me.lblPayroll.Text = "PayRoll Program"
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(49, 145)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(100, 20)
        Me.txtId.TabIndex = 0
        '
        'txtHours
        '
        Me.txtHours.Location = New System.Drawing.Point(49, 206)
        Me.txtHours.Name = "txtHours"
        Me.txtHours.Size = New System.Drawing.Size(100, 20)
        Me.txtHours.TabIndex = 1
        '
        'txtRate
        '
        Me.txtRate.Location = New System.Drawing.Point(49, 267)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(100, 20)
        Me.txtRate.TabIndex = 2
        '
        'txtGross
        '
        Me.txtGross.BackColor = System.Drawing.SystemColors.Window
        Me.txtGross.Location = New System.Drawing.Point(323, 145)
        Me.txtGross.Name = "txtGross"
        Me.txtGross.ReadOnly = True
        Me.txtGross.Size = New System.Drawing.Size(100, 20)
        Me.txtGross.TabIndex = 6
        Me.txtGross.TabStop = False
        Me.txtGross.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDeduction
        '
        Me.txtDeduction.BackColor = System.Drawing.SystemColors.Window
        Me.txtDeduction.Location = New System.Drawing.Point(322, 206)
        Me.txtDeduction.Name = "txtDeduction"
        Me.txtDeduction.ReadOnly = True
        Me.txtDeduction.Size = New System.Drawing.Size(100, 20)
        Me.txtDeduction.TabIndex = 5
        Me.txtDeduction.TabStop = False
        Me.txtDeduction.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNet
        '
        Me.txtNet.BackColor = System.Drawing.SystemColors.Window
        Me.txtNet.Location = New System.Drawing.Point(321, 267)
        Me.txtNet.Name = "txtNet"
        Me.txtNet.ReadOnly = True
        Me.txtNet.Size = New System.Drawing.Size(100, 20)
        Me.txtNet.TabIndex = 6
        Me.txtNet.TabStop = False
        Me.txtNet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Location = New System.Drawing.Point(49, 126)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(18, 13)
        Me.lblId.TabIndex = 7
        Me.lblId.Text = "ID"
        Me.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblHours
        '
        Me.lblHours.AutoSize = True
        Me.lblHours.Location = New System.Drawing.Point(49, 187)
        Me.lblHours.Name = "lblHours"
        Me.lblHours.Size = New System.Drawing.Size(35, 13)
        Me.lblHours.TabIndex = 8
        Me.lblHours.Text = "Hours"
        Me.lblHours.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRate
        '
        Me.lblRate.AutoSize = True
        Me.lblRate.Location = New System.Drawing.Point(49, 248)
        Me.lblRate.Name = "lblRate"
        Me.lblRate.Size = New System.Drawing.Size(30, 13)
        Me.lblRate.TabIndex = 9
        Me.lblRate.Text = "Rate"
        Me.lblRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblGross
        '
        Me.lblGross.AutoSize = True
        Me.lblGross.Location = New System.Drawing.Point(320, 126)
        Me.lblGross.Name = "lblGross"
        Me.lblGross.Size = New System.Drawing.Size(55, 13)
        Me.lblGross.TabIndex = 10
        Me.lblGross.Text = "Gross Pay"
        Me.lblGross.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDeduction
        '
        Me.lblDeduction.AutoSize = True
        Me.lblDeduction.Location = New System.Drawing.Point(320, 187)
        Me.lblDeduction.Name = "lblDeduction"
        Me.lblDeduction.Size = New System.Drawing.Size(56, 13)
        Me.lblDeduction.TabIndex = 11
        Me.lblDeduction.Text = "Deduction"
        Me.lblDeduction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNet
        '
        Me.lblNet.AutoSize = True
        Me.lblNet.Location = New System.Drawing.Point(320, 248)
        Me.lblNet.Name = "lblNet"
        Me.lblNet.Size = New System.Drawing.Size(45, 13)
        Me.lblNet.TabIndex = 12
        Me.lblNet.Text = "Net Pay"
        Me.lblNet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnCompute
        '
        Me.btnCompute.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCompute.Location = New System.Drawing.Point(58, 335)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(75, 23)
        Me.btnCompute.TabIndex = 3
        Me.btnCompute.Text = "&COMPUTE"
        Me.btnCompute.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(204, 334)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 4
        Me.btnReset.Text = "&RESET"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(350, 334)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&XIT"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AcceptButton = Me.btnCompute
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(484, 412)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.lblNet)
        Me.Controls.Add(Me.lblDeduction)
        Me.Controls.Add(Me.lblGross)
        Me.Controls.Add(Me.lblRate)
        Me.Controls.Add(Me.lblHours)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.txtNet)
        Me.Controls.Add(Me.txtDeduction)
        Me.Controls.Add(Me.txtGross)
        Me.Controls.Add(Me.txtRate)
        Me.Controls.Add(Me.txtHours)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.lblPayroll)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lab2kvignen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
   Friend WithEvents lblPayroll As System.Windows.Forms.Label
   Friend WithEvents txtId As System.Windows.Forms.TextBox
   Friend WithEvents txtHours As System.Windows.Forms.TextBox
   Friend WithEvents txtRate As System.Windows.Forms.TextBox
   Friend WithEvents txtGross As System.Windows.Forms.TextBox
   Friend WithEvents txtDeduction As System.Windows.Forms.TextBox
   Friend WithEvents txtNet As System.Windows.Forms.TextBox
   Friend WithEvents lblId As System.Windows.Forms.Label
   Friend WithEvents lblHours As System.Windows.Forms.Label
   Friend WithEvents lblRate As System.Windows.Forms.Label
   Friend WithEvents lblGross As System.Windows.Forms.Label
   Friend WithEvents lblDeduction As System.Windows.Forms.Label
   Friend WithEvents lblNet As System.Windows.Forms.Label
   Friend WithEvents btnCompute As System.Windows.Forms.Button
   Friend WithEvents btnReset As System.Windows.Forms.Button
   Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
