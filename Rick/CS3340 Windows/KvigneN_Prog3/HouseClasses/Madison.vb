'----------------------------------------------------------
'  Name: Nick Kvigne
'  Date: 2/15/17
'  Description:  Program 2
'                Class Madison
'----------------------------------------------------------

Public Class Madison
   Inherits House

   Private minGarage As Integer = 1
   Private minRoom As Integer = 2
   Private basePrice As Single = 300000
   Private addRoom As Single = 10000
   Private addGarage As Single = 5000

   'Creates new Madison house
   Public Sub New(ByVal ID As String)

      MyBase.New(ID)
      _garages = minGarage
      _rooms = minRoom
      _price = basePrice
      _type = "Madison"
   End Sub

   'Modifies the house price based on room and garage selection
   Public Overrides Sub Modify(numRooms As Integer, numGarages As Integer)

      _rooms = numRooms
      _garages = numGarages
      If _rooms = minRoom Then
         If _garages = 2 Then
            _price = _price + ((_garages - 1) * addGarage)
         End If
         If _garages = 3 Then
            _price = _price + ((_garages - 1) * addGarage)
         End If
      End If
      If _rooms = 3 Then
         If _garages = 1 Then
            _price = _price + ((_rooms - 2) * addRoom)
         End If
         If _garages = 2 Then
            _price = _price + ((_garages - 1) * addGarage) + ((_rooms - 2) * addRoom)
         End If
         If _garages = 3 Then
            _price = _price + ((_garages - 1) * addGarage) + ((_rooms - 2) * addRoom)
         End If
      End If

      If _rooms = 4 Then
         If _garages = 1 Then
            _price = _price + ((_rooms - 2) * addRoom)
         End If
         If _garages = 2 Then
            _price = _price + ((_garages - 1) * addGarage) + ((_rooms - 2) * addRoom)
         End If
         If _garages = 3 Then
            _price = _price + ((_garages - 1) * addGarage) + ((_rooms - 2) * addRoom)
         End If
      End If
      SubToRaiseEvent()

   End Sub
End Class
