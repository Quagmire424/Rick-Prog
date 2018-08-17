<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReaderWriterForm
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
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtLog = New System.Windows.Forms.TextBox()
        Me.lstWaiting = New System.Windows.Forms.ListBox()
        Me.lblWaiting = New System.Windows.Forms.Label()
        Me.lstWorking = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnReader = New System.Windows.Forms.Button()
        Me.btnWriter = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtTotal
        '
        Me.txtTotal.ForeColor = System.Drawing.SystemColors.Window
        Me.txtTotal.Location = New System.Drawing.Point(394, 50)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(357, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Total"
        '
        'txtLog
        '
        Me.txtLog.ForeColor = System.Drawing.SystemColors.Window
        Me.txtLog.Location = New System.Drawing.Point(265, 100)
        Me.txtLog.Multiline = True
        Me.txtLog.Name = "txtLog"
        Me.txtLog.ReadOnly = True
        Me.txtLog.Size = New System.Drawing.Size(330, 191)
        Me.txtLog.TabIndex = 2
        '
        'lstWaiting
        '
        Me.lstWaiting.FormattingEnabled = True
        Me.lstWaiting.Location = New System.Drawing.Point(617, 152)
        Me.lstWaiting.Name = "lstWaiting"
        Me.lstWaiting.Size = New System.Drawing.Size(164, 134)
        Me.lstWaiting.TabIndex = 3
        '
        'lblWaiting
        '
        Me.lblWaiting.AutoSize = True
        Me.lblWaiting.Location = New System.Drawing.Point(689, 106)
        Me.lblWaiting.Name = "lblWaiting"
        Me.lblWaiting.Size = New System.Drawing.Size(43, 13)
        Me.lblWaiting.TabIndex = 4
        Me.lblWaiting.Text = "Waiting"
        '
        'lstWorking
        '
        Me.lstWorking.FormattingEnabled = True
        Me.lstWorking.Location = New System.Drawing.Point(68, 152)
        Me.lstWorking.Name = "lstWorking"
        Me.lstWorking.Size = New System.Drawing.Size(175, 134)
        Me.lstWorking.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(101, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Working"
        '
        'btnReader
        '
        Me.btnReader.Location = New System.Drawing.Point(265, 339)
        Me.btnReader.Name = "btnReader"
        Me.btnReader.Size = New System.Drawing.Size(75, 23)
        Me.btnReader.TabIndex = 7
        Me.btnReader.Text = "New Reader"
        Me.btnReader.UseVisualStyleBackColor = True
        '
        'btnWriter
        '
        Me.btnWriter.Location = New System.Drawing.Point(520, 339)
        Me.btnWriter.Name = "btnWriter"
        Me.btnWriter.Size = New System.Drawing.Size(75, 23)
        Me.btnWriter.TabIndex = 8
        Me.btnWriter.Text = "New Writer"
        Me.btnWriter.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(392, 339)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'ReaderWriterForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(830, 417)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnWriter)
        Me.Controls.Add(Me.btnReader)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lstWorking)
        Me.Controls.Add(Me.lblWaiting)
        Me.Controls.Add(Me.lstWaiting)
        Me.Controls.Add(Me.txtLog)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTotal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "ReaderWriterForm"
        Me.Text = "FIFO: Readers and Writers - Nick Kvigne"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTotal As TextBox
   Friend WithEvents Label1 As Label
   Friend WithEvents txtLog As TextBox
   Friend WithEvents lstWaiting As ListBox
   Friend WithEvents lblWaiting As Label
   Friend WithEvents lstWorking As ListBox
   Friend WithEvents Label2 As Label
   Friend WithEvents btnReader As Button
   Friend WithEvents btnWriter As Button
   Friend WithEvents btnExit As Button
End Class
