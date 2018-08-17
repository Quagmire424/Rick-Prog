'----------------------------------------------------------
'  Name: Nick Kvigne
'  Date: 2/15/17
'  Description:  Program 2
'                Class Chicago
'----------------------------------------------------------

Public Class Chicago
   Inherits House

   Private minGarage As Integer = 2
   Private minRoom As Integer = 3
   Private basePrice As Single = 400000
   Private priceThreeRThreeG As Single = 410000
   Private priceFourRTwoG As Single = 420000
   Private priceFourRThreeG As Single = 428000

   'Creates new Chicago house
   Public Sub New(ByVal ID As String)

      MyBase.New(ID)
      _garages = minGarage
      _rooms = minRoom
      _price = basePrice
      _type = "Chicago"
   End Sub

   'Modifies the house price based on room and garage selection
   Public Overrides Sub Modify(numRooms As Integer, numGarages As Integer)

      _rooms = numRooms
      _garages = numGarages
      If _rooms = minRoom Then
         If _garages = 3 Then
            _price = priceThreeRThreeG
         End If
      End If

      If _rooms > minRoom Then
         If _garages = 2 Then
            _price = priceFourRTwoG
         End If
         If _garages = 3 Then
            _price = priceFourRThreeG
         End If
      End If

      SubToRaiseEvent()

   End Sub
End Class
