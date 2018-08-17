<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormClassThread
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
        Me.btnWait = New System.Windows.Forms.Button()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnTerminate = New System.Windows.Forms.Button()
        Me.lstAllUsers = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTransaction = New System.Windows.Forms.TextBox()
        Me.txtBalance = New System.Windows.Forms.TextBox()
        Me.txtLog = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnWait
        '
        Me.btnWait.Location = New System.Drawing.Point(300, 157)
        Me.btnWait.Name = "btnWait"
        Me.btnWait.Size = New System.Drawing.Size(75, 23)
        Me.btnWait.TabIndex = 0
        Me.btnWait.Text = "Wait"
        Me.btnWait.UseVisualStyleBackColor = True
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(300, 110)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(75, 23)
        Me.btnCreate.TabIndex = 1
        Me.btnCreate.Text = "New"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'btnContinue
        '
        Me.btnContinue.Location = New System.Drawing.Point(300, 203)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(75, 23)
        Me.btnContinue.TabIndex = 2
        Me.btnContinue.Text = "Continue"
        Me.btnContinue.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(300, 302)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnTerminate
        '
        Me.btnTerminate.Location = New System.Drawing.Point(300, 254)
        Me.btnTerminate.Name = "btnTerminate"
        Me.btnTerminate.Size = New System.Drawing.Size(75, 23)
        Me.btnTerminate.TabIndex = 4
        Me.btnTerminate.Text = "Terminate"
        Me.btnTerminate.UseVisualStyleBackColor = True
        '
        'lstAllUsers
        '
        Me.lstAllUsers.FormattingEnabled = True
        Me.lstAllUsers.Location = New System.Drawing.Point(399, 115)
        Me.lstAllUsers.Name = "lstAllUsers"
        Me.lstAllUsers.Size = New System.Drawing.Size(239, 212)
        Me.lstAllUsers.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(178, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Total Transactions"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(396, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Total Balance"
        '
        'txtTransaction
        '
        Me.txtTransaction.Location = New System.Drawing.Point(173, 46)
        Me.txtTransaction.Name = "txtTransaction"
        Me.txtTransaction.Size = New System.Drawing.Size(100, 20)
        Me.txtTransaction.TabIndex = 9
        '
        'txtBalance
        '
        Me.txtBalance.Location = New System.Drawing.Point(399, 46)
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.Size = New System.Drawing.Size(100, 20)
        Me.txtBalance.TabIndex = 10
        '
        'txtLog
        '
        Me.txtLog.Location = New System.Drawing.Point(34, 115)
        Me.txtLog.Multiline = True
        Me.txtLog.Name = "txtLog"
        Me.txtLog.Size = New System.Drawing.Size(239, 210)
        Me.txtLog.TabIndex = 11
        '
        'FormClassThread
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(696, 405)
        Me.Controls.Add(Me.txtLog)
        Me.Controls.Add(Me.txtBalance)
        Me.Controls.Add(Me.txtTransaction)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstAllUsers)
        Me.Controls.Add(Me.btnTerminate)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.btnWait)
        Me.Name = "FormClassThread"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnWait As Button
    Friend WithEvents btnCreate As Button
    Friend WithEvents btnContinue As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnTerminate As Button
    Friend WithEvents lstAllUsers As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTransaction As TextBox
    Friend WithEvents txtBalance As TextBox
    Friend WithEvents txtLog As TextBox
End Class
