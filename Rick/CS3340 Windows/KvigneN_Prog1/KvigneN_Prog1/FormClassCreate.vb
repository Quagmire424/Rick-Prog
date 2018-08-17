Public Class FormClassCreate

    Private Const MAX_KEY_LENGTH As Integer = 6
    Private _frmShow As FormClassShow
    Private WithEvents aButton As Button
    Private xPos As Integer = 100
    Private TheButtons As New SortedList()

    Public Sub New()
        ' Need to call InitializeComponent definded on Desinger.vb 
        InitializeComponent()

        _frmShow = New FormClassShow
        _frmShow.MainForm = Me
    End Sub

    ' Public property (set method)
    Public WriteOnly Property FormShow As Form
        Set(ByVal value As Form)
            _frmShow = value
        End Set
    End Property

    Private _myProperty As String

    ' A Public Property with both Set and Get to access _myProperty 
    ' Type "Set" and then enter to get the template
    Public Property MyProperty As String
        Set(ByVal value As String)
            _myProperty = value
        End Set

        Get
            Return _myProperty
        End Get
    End Property
    'Public Property MyString As String
    '    Get
    '        Return _str
    '    End Get
    '    Set(value As String)
    '        _str = value
    '    End Set
    'End Property

    Private Sub mnuShow_Click(sender As Object, e As EventArgs) Handles mnuShow.Click
        Me.Hide()
        _frmShow.Show()
        _frmShow.BringToFront()
    End Sub

    Private Sub FormClassCreate_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
        End If
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Application.Exit()

    End Sub

    Private Sub mnuCreate_Click(sender As Object, e As EventArgs) Handles mnuCreate.Click
        Dim theCaption As String
        Dim theKey As String

        theCaption = txtCaption.Text.Trim()
        theKey = txtKey.Text.Trim()

        ' Checking input
        If theKey = "" Then
            MessageBox.Show("No key provided", "Prog1")
        Else
            'txtKey_KeyPress(theKey, e)

            Try
                _frmShow.addButton(theKey, theCaption)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub mnuRemove_Click(sender As Object, e As EventArgs) Handles mnuRemove.Click
        Try
            _frmShow.removeButton(txtKey.Text.Trim)
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub

    'Private Sub removeButton(ByVal theKey As String)
    '    Dim index As Integer
    '    index = TheButtons.IndexOfKey(theKey)

    '    If index = -1 Then
    '        ' not in the sorted list
    '        MessageBox.Show("Key not used")
    '    Else
    '        Try
    '            aButton = TheButtons.GetByIndex(index)
    '            Me.Controls.Remove(aButton)
    '            TheButtons.RemoveAt(index)
    '        Catch ex As Exception
    '            MessageBox.Show(ex.Message)

    '        End Try

    '    End If
    'End Sub

    Private Sub txtKey_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKey.KeyPress

        If e.KeyChar = Chr(Keys.Back) Then
            ' it is ok
        ElseIf txtKey.Text.Length >= 6 Then
            e.Handled = True
            Beep()
        ElseIf e.KeyChar >= "0" And e.KeyChar <= "9" And txtKey.SelectionStart = 0 Then
            e.Handled = True
            Beep()
        ElseIf e.KeyChar = " " Then
            e.Handled = True
            Beep()
        Else
            ' good
        End If
    End Sub


End Class
