'------------------------------------------------------------------------------------------------------------
' Course     : CS 3340 
'
' Name       : Your name
'
' Date       : April 4, 2017
'
' Description: Test 3
'              GUI Form1 
'------------------------------------------------------------------------------------------------------------

Imports System.Threading
Imports UWPCS3340

Public Class Form1

   Dim barber As UWPCS3340.BarberClass
   Dim customer As UWPCS3340.CustomerClass

   Private Delegate Sub EnableButtons()
   Private dummyThread As Thread
   Private toEnableButtons As EnableButtons

   Private Sub ResetButtons()
      btnOpen.Enabled = True
      btnExit.Enabled = True

      btnNew.Enabled = True
      btnClose.Enabled = False
   End Sub

   ' Opens the Barbershop: 
   '           Clear txtLog, but not lstWaiting
   '           Disable btnOpen And btnExit, but enable btnNew And btnClose
   '           Call OpenBarberShop ofr the barber.
   Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
      txtLog.Text = ""
      btnOpen.Enabled = False
      btnExit.Enabled = False
      btnNew.Enabled = True
        btnClose.Enabled = True
        barber.OpenBarberShop()
    End Sub


   ' Closes the BarberShop: 
   '            Disable btnClose, btnExit And btnOpen, but enable btnCustomer.
   '            Close the barbershop by calling CloseBeaberShop. 
   '            While waiting for the barber to finish work, the form must display messages as it    
   '                  normally does and new customers can be created.
   '            After the barber finishes all waiting customers, btnNew, btnOpen and btnExit (but not btnClose) must be enabled.
   ' You should use dummyThread to wait for the barber to finish all waiting customers.
   Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
      btnOpen.Enabled = False
      btnExit.Enabled = False
      btnNew.Enabled = True
      btnClose.Enabled = False
      barber.CloseBarberShop()
      dummyThread = New Thread(AddressOf closeShop)
      dummyThread.Start()
      btnOpen.Enabled = True
      btnExit.Enabled = True
      btnNew.Enabled = True

   End Sub

   ' The delegate sub for dummyThread.
   Private Sub closeShop()


   End Sub

   ' Creates a new customer, sets the properties, and spin up the customer.
   Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        customer = New CustomerClass
        customer.MainForm = Me
        customer.SpinUp()

   End Sub

   ' Exiting the program:
   '         Clear customer queue 
   '         Uses a message box With Yes/No To ask the user If To terminate.
   '         Terminates the program if the user selects Yes, and continues otherwise.
   Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
      BarberClass.ClearCustomerQueue()

      Dim result As Microsoft.VisualBasic.MsgBoxResult
      result = MsgBox("Do you want to exit?", MsgBoxStyle.YesNo)
      If result = MsgBoxResult.Yes Then
         Application.Exit()
      Else

      End If
   End Sub

   ' Creates a new object of BarberClass and assigns to variable barber and sets its properties.
   ' Assigns barber to NewBarber of BarberShopClass.
   ' Also sets the value of toEnableButtons to ResetButtons.
   Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        barber = New BarberClass
        barber.MainForm = Me
        BarberShopClass.NewBarber = barber
        ResetButtons()

    End Sub

   ' The delegate sub for the barber and all customers.
   Private Sub HandleMessage(ByVal msg As String)
      If (msg.Contains("Waiting for the Barber" Or "Waking up the Barber")) Then
         lstWaiting.Items.Add(msg)
      ElseIf (msg.Contains("Cut Hair for Customer" Or "without hair cut")) Then
         lstWaiting.Items.RemoveAt(0)
      End If
      If Not (msg.Contains("Waiting for the Barber")) Then
            txtLog.AppendText(msg)
            txtLog.SelectionStart = txtLog.Text.Length
            txtLog.ScrollToCaret()

      End If
      ' If msg contains "Waiting for the Barber" or "Waking up the Barber"
      '    add msg to lstWaiting
      ' Else if msg contains "Cut Hair for Customer" Or "without hair cut"
      '    remove the first item from lstWaiting
      '
      ' If msg does not contain "Waiting for the Barber"
      '    add msg to the end of txtLog
      '    scroll down txtLog to show the new added msg 
   End Sub
End Class
