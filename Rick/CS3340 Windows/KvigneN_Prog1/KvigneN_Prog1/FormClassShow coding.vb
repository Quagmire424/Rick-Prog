Public Class FormClassShow

   Private _mainForm As Form
   Private aButton As Button
   Private xPos As Integer = 100
   Private TheButtons As New SortedList()

   Public WriteOnly Property MainForm As Form
      Set(value As Form)
         _mainForm = value
      End Set
   End Property

   Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
      Me.Hide()

      _mainForm.Show()
      _mainForm.BringToFront()

   End Sub

   Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
      '' Gets a new button object
      'aButton = New Button

      '' Sets the button properties
      'aButton.Location = New System.Drawing.Point(100, 250)
      'aButton.Text = "The Key"

      '' Puts the button on the form
      'Me.Controls.Add(aButton)

      addButton(txtKey.Text, txtCaption.Text)
   End Sub

   Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
      'Controls.Remove(aButton)

      removeButton(txtKey.Text)

   End Sub

   ' Private method
   Friend Sub addButton(ByVal theKey As String, ByVal theCaption As String)
      ' Gets a new button object
      aButton = New Button

      ' Sets the button properties
      aButton.Text = theCaption
      aButton.Tag = theKey
      aButton.Location = New System.Drawing.Point(xPos, 250)
      xPos += 100

      'set font style 

      AddHandler aButton.Click, AddressOf MyEventHandler

      ' Puts the button on the form
      Me.Controls.Add(aButton)

      ' Adds the button to the sorted list
      TheButtons.Add(theKey, aButton)
   End Sub

   Friend Sub removeButton(ByVal theKey As String)
      Dim index As Integer
      index = TheButtons.IndexOfKey(theKey)

      If index = -1 Then
         ' not in the sorted list
      Else
         aButton = TheButtons.GetByIndex(index)
         Me.Controls.Remove(aButton)
         TheButtons.RemoveAt(index)
      End If
   End Sub

   Private Sub FormClassShow_Load(sender As Object, e As EventArgs) Handles MyBase.Load

   End Sub

   Private Sub aButton_Click(sender As Object, e As EventArgs) ' Handles aButton.Click
      Dim TheButton As Button

      TheButton = CType(sender, Button)

      TheButton.Text = "Handler"
      MessageBox.Show("My Handler!")
      TheButton.Location = New Point(TheButton.Location.X, TheButton.Location.Y + 10)

   End Sub

   Private Sub MyEventHandler(ByVal sender As Object,
                            ByVal e As System.EventArgs)

      Dim TheButton As Button

      TheButton = CType(sender, Button)

      TheButton.Text = "Handler"
      MessageBox.Show("My Handler!")
      TheButton.Location = New Point(TheButton.Location.X, TheButton.Location.Y - 10)
   End Sub

   Private Sub BoldToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuBold.Click

      ChangeFont(FontStyle.Bold, mnuBold)

      'mnuBold.Checked = Not mnuBold.Checked

      ' aButton.Font = New Font(aButton.Font, aButton.Font.Style Xor FontStyle.Bold)

   End Sub

   Private Sub ChangeFont(ByVal f As FontStyle, ByVal m As ToolStripMenuItem)
      m.Checked = Not mnuBold.Checked

      aButton.Font = New Font(aButton.Font, aButton.Font.Style Xor f)

   End Sub


   Private Sub FormClassShow_Resize(sender As Object, e As EventArgs) Handles Me.Resize
      Dim FormClientWidth As Integer
      Dim FormClientHeight As Integer

      Dim temp As Integer

      FormClientWidth = Me.ClientSize.Width
      FormClientHeight = Me.ClientSize.Height

      temp = (FormClientWidth - Button2.Width - Button3.Width - 50) / 2

      Button2.Left = temp

      Button3.Left = Button2.Right + 50

   End Sub

End Class