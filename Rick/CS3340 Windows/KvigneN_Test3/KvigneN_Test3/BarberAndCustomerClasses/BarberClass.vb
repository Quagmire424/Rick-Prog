'------------------------------------------------------------------------------------------------------------
' Course     : CS 3340 
'
' Name       : Your name
'
' Date       : April 4, 2017
'
' Description: Test 3
'              BarberClass
'------------------------------------------------------------------------------------------------------------

Imports System.Threading

Public Class BarberClass

   Public Enum BarberState
      Open
      Working
      Sleeping
      Closing
      Closed
   End Enum


   Private _barberThread As Thread
   Private _barberMessage As BarberShopClass.PassMessage
   Private _mainForm As Form

   ' Indicates if the barber should exit from the while loop or not 
   Private _done As Boolean

   ' To wake up the barber.
   Friend barberEvent As New ManualResetEvent(False)

   ' Generates the amount of time needed for each haircut
   Private BarberRand As Random = New Random(Now.Second)

   ' The barber state is shared by all customers and the barber himself, and 
   ' Monitor must be used on "this" BarberClass object to enforce mutual exclusion
   ' when accessing the state inside the class.
   ' The initial state is closed.
   Private _theState As BarberState = BarberState.Closed

   ' The property does not provide exclusive access to _theState, and
   ' Monitor must be used on "this" object to enforce mutual exclusion
   ' for any customer to access the state.
   Public Property TheState As BarberState
      Set(value As BarberState)
         _theState = value
      End Set
      Get
         Return _theState
      End Get
   End Property

   Public WriteOnly Property BarberMessage As BarberShopClass.PassMessage
      Set(value As BarberShopClass.PassMessage)
         _barberMessage = value
      End Set
   End Property

   Public WriteOnly Property MainForm As Form
      Set(value As Form)
         _mainForm = value
      End Set
   End Property

   ' Creates a new barber thread, sets _done to false and the state to Open,
   ' then starts the barber thread
   Public Sub OpenBarberShop()
        _barberThread = New Thread(AddressOf run)
        _done = False
        TheState = BarberState.Open
        _barberThread.Start()

   End Sub

   ' Sets the state to Closing, wakes up the barber thread, and waits until the barber 
   ' thread is terminated
   Public Sub CloseBarberShop()
        Monitor.Enter(BarberShopClass.TheBarberStateObj)
        _theState = BarberState.Closing
        Monitor.Exit(BarberShopClass.TheBarberStateObj)

        barberEvent.Set()

        ' Wait until _barberThread is terminated 
        _barberThread.Join()

    End Sub

   ' It will be called from the main form when the user wants to exit before 
   ' the barber shop is open, since some customers might be waiting.
   ' It removes the customers from the queue, one by one, and wakes up the customer 
   ' with parameter telling the customer that hair cut is not done. 
   ' So the customer thread will terminate before the program can be terminated.
   Public Shared Sub ClearCustomerQueue()

   End Sub

   ' Remember to use Monitor on the customer queue to enforce mutual exclusion.
   Private Sub run()
      Monitor.Enter(BarberShopClass.CustomerQueue)
      While _done = False
            Monitor.Enter(BarberShopClass.TheBarberStateObj)
            If (TheState = BarberState.Open) Then
                _mainForm.Invoke(_barberMessage, "The Barber Shop is Now Open.")
                TheState = BarberState.Working
                Monitor.Exit(BarberShopClass.TheBarberStateObj)
            ElseIf TheState = BarberState.Sleeping Then
                _mainForm.Invoke(_barberMessage, "The Barber Goes to Sleep.")
                Monitor.Exit(BarberShopClass.TheBarberStateObj)
                barberEvent.WaitOne()
            ElseIf TheState = BarberState.Closing Then
                _mainForm.Invoke(_barberMessage, "The Barber Shop is Now Closing.")
                Monitor.Exit(BarberShopClass.TheBarberStateObj)
                FinishingAll()
                Monitor.Enter(BarberShopClass.TheBarberStateObj)
                TheState = BarberState.Closed
                Monitor.Exit(BarberShopClass.TheBarberStateObj)
            ElseIf TheState = BarberState.Closed Then
                _mainForm.Invoke(_barberMessage, "The Barber Shop is Now Closed.")
                _done = True
                Monitor.Exit(BarberShopClass.TheBarberStateObj)
            Else
                Monitor.Exit(BarberShopClass.TheBarberStateObj)
                If BarberShopClass.CustomerQueue.Count = 0 Then
                    Monitor.Enter(BarberShopClass.TheBarberStateObj)
                    TheState = BarberState.Sleeping
                    Monitor.Exit(BarberShopClass.TheBarberStateObj)
                Else
                    Dim cust As CustomerClass
                    cust = BarberShopClass.CustomerQueue.Dequeue
                    Monitor.Exit(cust)
                    _mainForm.Invoke(_barberMessage, "Cut Hair for Customer ", cust.ID)
                    _barberThread.Sleep(BarberRand.Next)
                    _mainForm.Invoke(_barberMessage, "Finished Hair Cut for Customer", cust.ID)
                    cust.WakeUp(True)
                End If
            End If
        End While
      'While Not done
      '   Lock this object 
      '   If the State is Open
      '      Pass a message "The Barber Shop Is Now Open."
      '      Set the state to Working
      '      Release this object 
      '   Else If the State is Sleeping
      '      Pass a message "The Barber Goes to Sleep."
      '      Release this object 
      '      Wait on barberEvent
      '   Else If the State is Closing
      '      Pass a message "The Barber Shop Is Now Closing."
      '      Release this object 
      '      Finish all waiting customers
      '      Lock this object 
      '      Set state to Closed
      '      Release this object 
      '   Else If the State is Closed
      '      Pass a message "The Barber Shop Is Now Closed."
      '      Set done to true
      '      Release this object 
      '   Else (Working)
      '      Release this object 
      '      If no customer
      '         Lock this object 
      '         Set state to Sleeping
      '         Release this object 
      '      Else
      '         Remove the first customer from CustomerQueue
      '         Release this object 
      '         Pass a message "Cut Hair for Customer " followed by the customer’s ID
      '         The barber needs 2 – 5 seconds for a customer 
      '         (A Random object should be used to generate the amount of time)
      '         Pass a message "Finished Hair Cut for Customer " followed by ID
      '         Wake up the customer with parameter that hair cut is done

   End Sub

   ' Does haircut for one customer, including passing messages before and after the haircut
   ' and waking up the customer
   Private Sub CutHairForOneCustomer(ByVal c As CustomerClass)
      _mainForm.Invoke(_barberMessage, "New Customer " & c.ID & ": Starting hair cut.")
      c.WakeUp(True)
      _mainForm.Invoke(_barberMessage, "New Customer " & c.ID & ": Done with hair cut.")
   End Sub

   ' Should be called after the barber shop is closing to do hair cut for all waiting customers.
   ' The state has been set to Closing, and no customers will enter the CustomerQueue.
   Private Sub FinishingAll()

   End Sub
End Class
