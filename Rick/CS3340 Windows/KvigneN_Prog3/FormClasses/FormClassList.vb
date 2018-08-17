'----------------------------------------------------------
'  Name: Nick Kvigne
'  Date: 2/15/17
'  Description:  Program 2
'                Class FormClassList
'----------------------------------------------------------

Imports UWPCS3340

Public Class FormClassList

    Private _mainForm As FormClassHouse
    Private h As House

   'Sets value of _mainForm
   Public WriteOnly Property MainForm As FormClassHouse
        Set(value As FormClassHouse)
            _mainForm = value
        End Set
    End Property


   'Switches to show _mainForm, clears form of information
   Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Me.Hide()
        _mainForm.Show()
        _mainForm.BringToFront()

      ListBox1.Items.Clear()
      _mainForm.txtID.Text = ""
      _mainForm.txtPrice.Text = ""
      _mainForm.btnModify.Enabled = False
      _mainForm.gboGar.Enabled = False
      _mainForm.gboRoom.Enabled = False

   End Sub


   'Displays the selected house on the _mainForm, clears list box items
   Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim house As House

      If ListBox1.SelectedIndex = -1 Then
         MessageBox.Show("You must select a house to display")
      Else
         house = UWPCS3340.House.HouseByIndex(ListBox1.SelectedIndex)

         Me.Hide()
         _mainForm.DisplayHouse(house)
         ListBox1.Items.Clear()
      End If

      If house.Type = "Platteville" Then
         _mainForm.radFourRoom.Enabled = False
         _mainForm.radThreeGar.Enabled = False
      End If
      If house.Type = "Chicago" Then
         _mainForm.radTwoRoom.Enabled = False
         _mainForm.radOneGar.Enabled = False

      End If

   End Sub


End Class