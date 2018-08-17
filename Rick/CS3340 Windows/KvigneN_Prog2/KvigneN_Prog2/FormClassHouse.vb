'----------------------------------------------------------
'  Name: Nick Kvigne
'  Date: 2/15/17
'  Description:  Program 2
'                Class FormClassHouse
'----------------------------------------------------------

Imports UWPCS3340

Public Class FormClassHouse

    Private h As House
    Private aHouse As House
    Protected roomCount As Integer
    Protected garCount As Integer

    Private _frmList As FormClassList


   'Initializes form
   Public Sub New()

      InitializeComponent()

        _frmList = New FormClassList
        _frmList.MainForm = Me
    End Sub


   'Sets the value of _frmList
   Public WriteOnly Property FormShow As FormClassList
        Set(ByVal value As FormClassList)
            _frmList = value
        End Set
    End Property


   'Sets the form up when loaded
   Private Sub FormClassHouse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtID.Text = ""
        txtPrice.Text = ""
        btnModify.Enabled = False
        gboGar.Enabled = False
        gboRoom.Enabled = False
    End Sub


   'Creates house of selected type if button text is save, resets selections if button text is new
   Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If btnSave.Text.Trim = "Save" Then
            Try
                If cboType.SelectedIndex = 0 Then
                    h = New UWPCS3340.Platteville(txtID.Text)
                    radTwoRoom.Checked = True
                    radOneGar.Checked = True
                ElseIf cboType.SelectedIndex = 1 Then
                    h = New UWPCS3340.Madison(txtID.Text)
                    radTwoRoom.Checked = True
                    radOneGar.Checked = True
                ElseIf cboType.SelectedIndex = 2 Then
                    h = New UWPCS3340.Chicago(txtID.Text)
                    radThreeRoom.Checked = True
                    radTwoGar.Checked = True

                End If
            AddHandler h.PriceChange, AddressOf PriceChange

            txtID.ReadOnly = True
                cboType.Enabled = False
                btnSave.Text = "NEW"
                btnModify.Enabled = True
                gboGar.Enabled = True
                gboRoom.Enabled = True
                txtPrice.Text = FormatCurrency(h.Price, 0)
                txtPrice.TextAlign = HorizontalAlignment.Right

            Catch ex As Exception
                MessageBox.Show("Duplication or ID Error")

            End Try
            

        ElseIf btnSave.Text = "NEW" Then

            txtID.ReadOnly = False
            cboType.Enabled = True
            cboType.SelectedIndex = -1
            radFourRoom.Checked = False
            radThreeRoom.Checked = False
            radTwoRoom.Checked = False
            radThreeGar.Checked = False
            radTwoGar.Checked = False
            radOneGar.Checked = False
            txtID.Text = ""
            txtPrice.Text = ""
            btnModify.Enabled = False
            btnSave.Text = "Save"

        End If


    End Sub


   'Modifies room and garage count based on radio buttons that are clicked
   Private Sub btnModify_Click(sender As Object, e As EventArgs) Handles btnModify.Click

      If radFourRoom.Checked = True Then
         roomCount = 4
      End If
      If radThreeRoom.Checked = True Then
            roomCount = 3
        End If
        If radTwoRoom.Checked = True Then
            roomCount = 2
        End If
        If radThreeGar.Checked = True Then
            garCount = 3
        End If
        If radTwoGar.Checked = True Then
            garCount = 2
        End If
        If radOneGar.Checked = True Then
            garCount = 1
        End If

        Try
            h.Modify(roomCount, garCount)
        Catch ex As Exception
            MessageBox.Show("Modify error")
        End Try
        txtPrice.Text = FormatCurrency(h.Price, 0)
      txtPrice.TextAlign = HorizontalAlignment.Right


   End Sub


   'Exits form
   Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()

    End Sub


   'Switches to _frmList and displays number of houses, also lists houses in list box
   Private Sub btnList_Click(sender As Object, e As EventArgs) Handles btnList.Click

        Me.Hide()
        _frmList.Show()
        _frmList.BringToFront()

        _frmList.txtHouseNum.Text = House.TotalCount
        _frmList.txtHouseNum.TextAlign = HorizontalAlignment.Center
        For index As Integer = 0 To House.TotalCount - 1
            If String.Equals(House.HouseByIndex(index).Type, "Platteville") Then
            _frmList.ListBox1.Items.Add(House.HouseByIndex(index).ID.PadRight(10) _
                                            + House.HouseByIndex(index).Type _
                                            + FormatCurrency(House.HouseByIndex(index).Price, 0).PadLeft(13))
         End If

         If String.Equals(House.HouseByIndex(index).Type, "Madison") _
            Or String.Equals(House.HouseByIndex(index).Type, "Chicago") Then
            _frmList.ListBox1.Items.Add(House.HouseByIndex(index).ID.PadRight(12) _
                                        + House.HouseByIndex(index).Type _
                                        + FormatCurrency(House.HouseByIndex(index).Price, 0).PadLeft(15))
         End If

      Next
      radOneGar.Enabled = True
      radTwoGar.Enabled = True
      radThreeGar.Enabled = True
      radTwoRoom.Enabled = True
      radThreeRoom.Enabled = True
      radFourRoom.Enabled = True
   End Sub


   'Shows the form and displays the current house information
   Friend Sub DisplayHouse(ByVal aHouse As House)
      Me.Show()
      Me.BringToFront()

      cboType.Text = aHouse.Type
      txtID.Text = aHouse.ID
      txtPrice.Text = FormatCurrency(aHouse.Price, 0)
      txtPrice.TextAlign = HorizontalAlignment.Right

   End Sub


   ' Displays a message box saying the price was changed
   Private Sub PriceChange()
      MessageBox.Show("Price Changed!")
   End Sub

End Class
