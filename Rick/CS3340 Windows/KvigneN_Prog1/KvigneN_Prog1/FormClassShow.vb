Public Class FormClassShow

    Private _mainForm As Form
    Private aButton As Button
    Private xPos As Integer = 100
    Private TheButtons As New SortedList()

    Private Const MAX_BUTTON_COUNT As Integer = 4
    ' For event resize
    Private Const BUTTON_HEIGHT As Integer = 23
    Private Const BUTTON_WIDTH As Integer = 75
    Private Const MENU_HEIGHT As Integer = 24
    Private Const MARGIN_SIZE As Integer = 100


    Public WriteOnly Property MainForm As Form
        Set(value As Form)
            _mainForm = value
        End Set
    End Property

    ' Private method
    Friend Sub addButton(ByVal theKey As String, ByVal theCaption As String)
        If TheButtons.Count = MAX_BUTTON_COUNT Then
            MessageBox.Show("Maximum number of buttons already created")
        Else

            ' Gets a new button object
            aButton = New Button

            ' Sets the button properties
            aButton.Text = theCaption
            aButton.Tag = theKey
            aButton.Location = New System.Drawing.Point(xPos, 250)
            xPos += 100

            'set font style 
            setFont(aButton)


            AddHandler aButton.Click, AddressOf MyEventHandler

            ' Puts the button on the form
            If TheButtons.ContainsKey(theKey) Then
                MessageBox.Show("Key already created")
            Else

                Me.Controls.Add(aButton)

                ' Adds the button to the sorted list


                TheButtons.Add(theKey, aButton)
            End If
        End If
    End Sub

    Friend Sub removeButton(ByVal theKey As String)
        Dim index As Integer
        index = TheButtons.IndexOfKey(theKey)

        If index = -1 Then
            ' not in the sorted list
            MessageBox.Show("Key not used")
        Else
            aButton = TheButtons.GetByIndex(index)
            Me.Controls.Remove(aButton)
            TheButtons.RemoveAt(index)
        End If
    End Sub

    Private Sub FormClassShow_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
        End If
    End Sub

    Private Sub FormClassShow_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub MyEventHandler(ByVal sender As Object,
                             ByVal e As System.EventArgs)

        Dim TheButton As Button

        TheButton = CType(sender, Button)

        'TheButton.Text = "Handler"
        MessageBox.Show(sender.ToString)
        'TheButton.Location = New Point(TheButton.Location.X, TheButton.Location.Y - 10)
    End Sub

    Private Sub mnuBold_Click(sender As Object, e As EventArgs) Handles mnuBold.Click

        ChangeFont(FontStyle.Bold, mnuBold)

    End Sub

    Private Sub ChangeFont(ByVal f As FontStyle, ByVal m As ToolStripMenuItem)
        m.Checked = Not m.Checked

        aButton.Font = New Font(aButton.Font, aButton.Font.Style Xor f)

    End Sub


    Private Sub setFont(ByVal b As Button)
        If mnuBold.Checked Then
            b.Font = New Font(b.Font, b.Font.Bold)
            If mnuItalic.Checked Then
                b.Font = New Font(b.Font, b.Font.Bold + b.Font.Italic)
                If mnuUnderline.Checked Then
                    b.Font = New Font(b.Font, b.Font.Bold + b.Font.Italic + b.Font.Underline)

                End If
            End If
        End If

    End Sub

    'Private Sub FormClassShow_Resize(sender As Object, e As EventArgs) Handles Me.Resize
    '    Dim FormClientWidth As Integer
    '    Dim FormClientHeight As Integer

    '    'Dim temp As Integer

    '    FormClientWidth = Me.ClientSize.Width
    '    FormClientHeight = Me.ClientSize.Height

    '    'temp = (FormClientWidth - Button2.Width - Button3.Width - 50) / 2

    '    'Button2.Left = temp

    '    'Button3.Left = Button2.Right + 50

    'End Sub

    Private Sub mnuItalic_Click(sender As Object, e As EventArgs) Handles mnuItalic.Click
        ChangeFont(FontStyle.Italic, mnuItalic)
    End Sub

    Private Sub mnuUnderline_Click(sender As Object, e As EventArgs) Handles mnuUnderline.Click
        ChangeFont(FontStyle.Underline, mnuUnderline)
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Application.Exit()
    End Sub


    Private Sub mnuReturn_Click(sender As Object, e As EventArgs) Handles mnuReturn.Click
        Me.Hide()
        FormClassCreate.Show()
        FormClassCreate.BringToFront()
    End Sub

    Private Sub ArrangeButtons()

        Dim FormClientWidth As Integer
        Dim FormClientHeight As Integer

        Dim tempWidth As Integer
        Dim tempHeight As Integer

        FormClientWidth = Me.ClientSize.Width
        FormClientHeight = Me.ClientSize.Height

        tempWidth = FormClientWidth - (MARGIN_SIZE * 2) - (TheButtons.Count * BUTTON_WIDTH) / (TheButtons.Count + 1)

        tempHeight = FormClientHeight - MENU_HEIGHT - BUTTON_HEIGHT / 2


    End Sub
End Class