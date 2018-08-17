<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MyFormClass
   Inherits System.Windows.Forms.Form

   'Form overrides dispose to clean up the component list.
   <System.Diagnostics.DebuggerNonUserCode()>
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
   <System.Diagnostics.DebuggerStepThrough()>
   Private Sub InitializeComponent()
      Me.Button1 = New System.Windows.Forms.Button()
      Me.Button2 = New System.Windows.Forms.Button()
      Me.txtName = New System.Windows.Forms.TextBox()
      Me.Button3 = New System.Windows.Forms.Button()
      Me.Button4 = New System.Windows.Forms.Button()
      Me.txtMiles = New System.Windows.Forms.TextBox()
      Me.txtIndex = New System.Windows.Forms.TextBox()
      Me.Button5 = New System.Windows.Forms.Button()
      Me.rdoPerson = New System.Windows.Forms.RadioButton()
      Me.rdoStudent = New System.Windows.Forms.RadioButton()
      Me.rdoFaculty = New System.Windows.Forms.RadioButton()
      Me.Button6 = New System.Windows.Forms.Button()
      Me.Button7 = New System.Windows.Forms.Button()
      Me.SuspendLayout()
      '
      'Button1
      '
      Me.Button1.Location = New System.Drawing.Point(103, 173)
      Me.Button1.Name = "Button1"
      Me.Button1.Size = New System.Drawing.Size(75, 23)
      Me.Button1.TabIndex = 0
      Me.Button1.Text = "Create"
      Me.Button1.UseVisualStyleBackColor = True
      '
      'Button2
      '
      Me.Button2.Location = New System.Drawing.Point(245, 173)
      Me.Button2.Name = "Button2"
      Me.Button2.Size = New System.Drawing.Size(75, 23)
      Me.Button2.TabIndex = 1
      Me.Button2.Text = "Show"
      Me.Button2.UseVisualStyleBackColor = True
      '
      'txtName
      '
      Me.txtName.Location = New System.Drawing.Point(122, 71)
      Me.txtName.Name = "txtName"
      Me.txtName.Size = New System.Drawing.Size(100, 20)
      Me.txtName.TabIndex = 2
      '
      'Button3
      '
      Me.Button3.Location = New System.Drawing.Point(103, 216)
      Me.Button3.Name = "Button3"
      Me.Button3.Size = New System.Drawing.Size(75, 23)
      Me.Button3.TabIndex = 3
      Me.Button3.Text = "Set"
      Me.Button3.UseVisualStyleBackColor = True
      '
      'Button4
      '
      Me.Button4.Location = New System.Drawing.Point(227, 216)
      Me.Button4.Name = "Button4"
      Me.Button4.Size = New System.Drawing.Size(75, 23)
      Me.Button4.TabIndex = 4
      Me.Button4.Text = "Workout"
      Me.Button4.UseVisualStyleBackColor = True
      '
      'txtMiles
      '
      Me.txtMiles.Location = New System.Drawing.Point(272, 71)
      Me.txtMiles.Name = "txtMiles"
      Me.txtMiles.Size = New System.Drawing.Size(100, 20)
      Me.txtMiles.TabIndex = 5
      '
      'txtIndex
      '
      Me.txtIndex.Location = New System.Drawing.Point(422, 71)
      Me.txtIndex.Name = "txtIndex"
      Me.txtIndex.Size = New System.Drawing.Size(100, 20)
      Me.txtIndex.TabIndex = 6
      '
      'Button5
      '
      Me.Button5.Location = New System.Drawing.Point(422, 173)
      Me.Button5.Name = "Button5"
      Me.Button5.Size = New System.Drawing.Size(75, 23)
      Me.Button5.TabIndex = 7
      Me.Button5.Text = "Select Object"
      Me.Button5.UseVisualStyleBackColor = True
      '
      'rdoPerson
      '
      Me.rdoPerson.AutoSize = True
      Me.rdoPerson.Location = New System.Drawing.Point(176, 12)
      Me.rdoPerson.Name = "rdoPerson"
      Me.rdoPerson.Size = New System.Drawing.Size(58, 17)
      Me.rdoPerson.TabIndex = 8
      Me.rdoPerson.TabStop = True
      Me.rdoPerson.Text = "Person"
      Me.rdoPerson.UseVisualStyleBackColor = True
      '
      'rdoStudent
      '
      Me.rdoStudent.AutoSize = True
      Me.rdoStudent.Location = New System.Drawing.Point(272, 12)
      Me.rdoStudent.Name = "rdoStudent"
      Me.rdoStudent.Size = New System.Drawing.Size(62, 17)
      Me.rdoStudent.TabIndex = 9
      Me.rdoStudent.TabStop = True
      Me.rdoStudent.Text = "Student"
      Me.rdoStudent.UseVisualStyleBackColor = True
      '
      'rdoFaculty
      '
      Me.rdoFaculty.AutoSize = True
      Me.rdoFaculty.Location = New System.Drawing.Point(378, 12)
      Me.rdoFaculty.Name = "rdoFaculty"
      Me.rdoFaculty.Size = New System.Drawing.Size(59, 17)
      Me.rdoFaculty.TabIndex = 10
      Me.rdoFaculty.TabStop = True
      Me.rdoFaculty.Text = "Faculty"
      Me.rdoFaculty.UseVisualStyleBackColor = True
      '
      'Button6
      '
      Me.Button6.Location = New System.Drawing.Point(422, 231)
      Me.Button6.Name = "Button6"
      Me.Button6.Size = New System.Drawing.Size(75, 23)
      Me.Button6.TabIndex = 11
      Me.Button6.Text = "Equals"
      Me.Button6.UseVisualStyleBackColor = True
      '
      'Button7
      '
      Me.Button7.Location = New System.Drawing.Point(206, 305)
      Me.Button7.Name = "Button7"
      Me.Button7.Size = New System.Drawing.Size(75, 23)
      Me.Button7.TabIndex = 12
      Me.Button7.Text = "Switch"
      Me.Button7.UseVisualStyleBackColor = True
      '
      'MyFormClass
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(554, 340)
      Me.Controls.Add(Me.Button7)
      Me.Controls.Add(Me.Button6)
      Me.Controls.Add(Me.rdoFaculty)
      Me.Controls.Add(Me.rdoStudent)
      Me.Controls.Add(Me.rdoPerson)
      Me.Controls.Add(Me.Button5)
      Me.Controls.Add(Me.txtIndex)
      Me.Controls.Add(Me.txtMiles)
      Me.Controls.Add(Me.Button4)
      Me.Controls.Add(Me.Button3)
      Me.Controls.Add(Me.txtName)
      Me.Controls.Add(Me.Button2)
      Me.Controls.Add(Me.Button1)
      Me.Name = "MyFormClass"
      Me.Text = "Form1"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub

   Friend WithEvents Button1 As Button
   Friend WithEvents Button2 As Button
   Friend WithEvents txtName As TextBox
   Friend WithEvents Button3 As Button
   Friend WithEvents Button4 As Button
   Friend WithEvents txtMiles As TextBox
   Friend WithEvents txtIndex As TextBox
   Friend WithEvents Button5 As Button
   Friend WithEvents rdoPerson As RadioButton
   Friend WithEvents rdoStudent As RadioButton
   Friend WithEvents rdoFaculty As RadioButton
   Friend WithEvents Button6 As Button
   Friend WithEvents Button7 As Button
End Class
