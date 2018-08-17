<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormClassHouse
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
        Me.cboType = New System.Windows.Forms.ComboBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.radFourRoom = New System.Windows.Forms.RadioButton()
        Me.radThreeRoom = New System.Windows.Forms.RadioButton()
        Me.radTwoRoom = New System.Windows.Forms.RadioButton()
        Me.radOneGar = New System.Windows.Forms.RadioButton()
        Me.radTwoGar = New System.Windows.Forms.RadioButton()
        Me.radThreeGar = New System.Windows.Forms.RadioButton()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.gboRoom = New System.Windows.Forms.GroupBox()
        Me.gboGar = New System.Windows.Forms.GroupBox()
        Me.lblType = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnList = New System.Windows.Forms.Button()
        Me.btnModify = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.gboRoom.SuspendLayout()
        Me.gboGar.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboType
        '
        Me.cboType.FormattingEnabled = True
        Me.cboType.Items.AddRange(New Object() {"Platteville", "Madison", "Chicago"})
        Me.cboType.Location = New System.Drawing.Point(58, 88)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(121, 21)
        Me.cboType.TabIndex = 0
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(58, 176)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(121, 20)
        Me.txtID.TabIndex = 1
        '
        'radFourRoom
        '
        Me.radFourRoom.AutoSize = True
        Me.radFourRoom.Location = New System.Drawing.Point(172, 19)
        Me.radFourRoom.Name = "radFourRoom"
        Me.radFourRoom.Size = New System.Drawing.Size(31, 17)
        Me.radFourRoom.TabIndex = 2
        Me.radFourRoom.TabStop = True
        Me.radFourRoom.Text = "4"
        Me.radFourRoom.UseVisualStyleBackColor = True
        '
        'radThreeRoom
        '
        Me.radThreeRoom.AutoSize = True
        Me.radThreeRoom.Location = New System.Drawing.Point(88, 19)
        Me.radThreeRoom.Name = "radThreeRoom"
        Me.radThreeRoom.Size = New System.Drawing.Size(31, 17)
        Me.radThreeRoom.TabIndex = 3
        Me.radThreeRoom.TabStop = True
        Me.radThreeRoom.Text = "3"
        Me.radThreeRoom.UseVisualStyleBackColor = True
        '
        'radTwoRoom
        '
        Me.radTwoRoom.AutoSize = True
        Me.radTwoRoom.Location = New System.Drawing.Point(6, 19)
        Me.radTwoRoom.Name = "radTwoRoom"
        Me.radTwoRoom.Size = New System.Drawing.Size(31, 17)
        Me.radTwoRoom.TabIndex = 4
        Me.radTwoRoom.TabStop = True
        Me.radTwoRoom.Text = "2"
        Me.radTwoRoom.UseVisualStyleBackColor = True
        '
        'radOneGar
        '
        Me.radOneGar.AutoSize = True
        Me.radOneGar.Location = New System.Drawing.Point(20, 25)
        Me.radOneGar.Name = "radOneGar"
        Me.radOneGar.Size = New System.Drawing.Size(31, 17)
        Me.radOneGar.TabIndex = 5
        Me.radOneGar.TabStop = True
        Me.radOneGar.Text = "1"
        Me.radOneGar.UseVisualStyleBackColor = True
        '
        'radTwoGar
        '
        Me.radTwoGar.AutoSize = True
        Me.radTwoGar.Location = New System.Drawing.Point(88, 25)
        Me.radTwoGar.Name = "radTwoGar"
        Me.radTwoGar.Size = New System.Drawing.Size(31, 17)
        Me.radTwoGar.TabIndex = 6
        Me.radTwoGar.TabStop = True
        Me.radTwoGar.Text = "2"
        Me.radTwoGar.UseVisualStyleBackColor = True
        '
        'radThreeGar
        '
        Me.radThreeGar.AutoSize = True
        Me.radThreeGar.Location = New System.Drawing.Point(172, 25)
        Me.radThreeGar.Name = "radThreeGar"
        Me.radThreeGar.Size = New System.Drawing.Size(31, 17)
        Me.radThreeGar.TabIndex = 7
        Me.radThreeGar.TabStop = True
        Me.radThreeGar.Text = "3"
        Me.radThreeGar.UseVisualStyleBackColor = True
        '
        'txtPrice
        '
        Me.txtPrice.BackColor = System.Drawing.SystemColors.Window
        Me.txtPrice.Location = New System.Drawing.Point(58, 248)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.ReadOnly = True
        Me.txtPrice.Size = New System.Drawing.Size(121, 20)
        Me.txtPrice.TabIndex = 8
        '
        'gboRoom
        '
        Me.gboRoom.Controls.Add(Me.radTwoRoom)
        Me.gboRoom.Controls.Add(Me.radThreeRoom)
        Me.gboRoom.Controls.Add(Me.radFourRoom)
        Me.gboRoom.Location = New System.Drawing.Point(321, 62)
        Me.gboRoom.Name = "gboRoom"
        Me.gboRoom.Size = New System.Drawing.Size(227, 58)
        Me.gboRoom.TabIndex = 9
        Me.gboRoom.TabStop = False
        Me.gboRoom.Text = "Rooms"
        '
        'gboGar
        '
        Me.gboGar.Controls.Add(Me.radOneGar)
        Me.gboGar.Controls.Add(Me.radTwoGar)
        Me.gboGar.Controls.Add(Me.radThreeGar)
        Me.gboGar.Location = New System.Drawing.Point(321, 160)
        Me.gboGar.Name = "gboGar"
        Me.gboGar.Size = New System.Drawing.Size(227, 66)
        Me.gboGar.TabIndex = 5
        Me.gboGar.TabStop = False
        Me.gboGar.Text = "Garages"
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Location = New System.Drawing.Point(109, 62)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(31, 13)
        Me.lblType.TabIndex = 10
        Me.lblType.Text = "Type"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(109, 143)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(18, 13)
        Me.lblID.TabIndex = 11
        Me.lblID.Text = "ID"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(109, 226)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(31, 13)
        Me.lblPrice.TabIndex = 12
        Me.lblPrice.Text = "Price"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(637, 216)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnList
        '
        Me.btnList.Location = New System.Drawing.Point(637, 133)
        Me.btnList.Name = "btnList"
        Me.btnList.Size = New System.Drawing.Size(75, 23)
        Me.btnList.TabIndex = 14
        Me.btnList.Text = "List"
        Me.btnList.UseVisualStyleBackColor = True
        '
        'btnModify
        '
        Me.btnModify.Location = New System.Drawing.Point(395, 327)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(75, 23)
        Me.btnModify.TabIndex = 15
        Me.btnModify.Text = "Modify"
        Me.btnModify.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(80, 327)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 16
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'FormClassHouse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 457)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnModify)
        Me.Controls.Add(Me.btnList)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.lblType)
        Me.Controls.Add(Me.gboGar)
        Me.Controls.Add(Me.gboRoom)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.cboType)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "FormClassHouse"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Program 2 - Nick Kvigne"
        Me.gboRoom.ResumeLayout(False)
        Me.gboRoom.PerformLayout()
        Me.gboGar.ResumeLayout(False)
        Me.gboGar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboType As System.Windows.Forms.ComboBox
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents radFourRoom As System.Windows.Forms.RadioButton
    Friend WithEvents radThreeRoom As System.Windows.Forms.RadioButton
    Friend WithEvents radTwoRoom As System.Windows.Forms.RadioButton
    Friend WithEvents radOneGar As System.Windows.Forms.RadioButton
    Friend WithEvents radTwoGar As System.Windows.Forms.RadioButton
    Friend WithEvents radThreeGar As System.Windows.Forms.RadioButton
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents gboRoom As System.Windows.Forms.GroupBox
    Friend WithEvents gboGar As System.Windows.Forms.GroupBox
    Friend WithEvents lblType As System.Windows.Forms.Label
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnList As System.Windows.Forms.Button
    Friend WithEvents btnModify As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button

End Class
