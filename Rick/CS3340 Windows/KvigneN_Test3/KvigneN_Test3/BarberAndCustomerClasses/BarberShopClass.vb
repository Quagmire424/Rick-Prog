'------------------------------------------------------------------------------------------------------------
' Course     : CS 3340 
'
' Name       : Your name
'
' Date       : April 4, 2017
'
' Description: Test 3
'              BarberShopClass
'              The class is completed and you need only to understand it.
'------------------------------------------------------------------------------------------------------------

Imports System.Threading

Public Class BarberShopClass
   ' The delegate is used by both BarberClass and CustomerClass 
   Public Delegate Sub PassMessage(ByVal msg As String)

   ' All customers must be waiting in the queue to get hair cut, except 
   ' those who come when the barber shop is closing. 
   ' The queue is shared by the barber and all customers, and
   ' mutual exclusion must be enforced using Monitor.
   Friend Shared CustomerQueue As New Queue

    'Friend Shared theBarberState As BarberState = BarberState.Closed
    Friend Shared TheBarberStateObj As New Object

    Friend Shared theBarber As BarberClass

   Public Shared WriteOnly Property NewBarber As BarberClass
      Set(value As BarberClass)
         theBarber = value
      End Set
   End Property

End Class
