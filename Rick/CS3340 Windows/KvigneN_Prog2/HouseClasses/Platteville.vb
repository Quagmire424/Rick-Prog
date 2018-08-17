'----------------------------------------------------------
'  Name: Nick Kvigne
'  Date: 2/15/17
'  Description:  Program 2
'                Class Platteville
'----------------------------------------------------------

Public Class Platteville
   Inherits House

   Private minGarage As Integer = 1
   Private minRoom As Integer = 2
   Private basePrice As Single = 200000
   Private addRoom As Single = 8000
   Private addGarage As Single = 2500

   'Creates new Platteville house
   Public Sub New(ByVal ID As String)

      MyBase.New(ID)
      _garages = minGarage
      _rooms = minRoom
      _price = basePrice
      _type = "Platteville"
   End Sub

   'Modifies the house price based on room and garage selection
   Public Overrides Sub Modify(numRooms As Integer, numGarages As Integer)

      _rooms = numRooms
      _garages = numGarages
      If _rooms > minRoom Then
         _price = _price + ((_rooms - 2) * addRoom)
      End If

      If _garages > minGarage Then
         _price = _price + ((_garages - 1) * addGarage)
      End If
      SubToRaiseEvent()

   End Sub
End Class
