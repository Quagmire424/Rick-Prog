'----------------------------------------------------------
'  Name: Nick Kvigne
'  Date: 2/15/17
'  Description:  Program 2
'                Class House
'----------------------------------------------------------

Public MustInherit Class House

   Protected Shared AllHouses As List(Of House) = New List(Of House)
   Protected _type As String
   Protected _id As String
   Protected _rooms As Integer
   Protected _garages As Integer
   Protected _price As Single
   Protected _count As Single


   'Creates a new house, checks to see if ID is valid
   Public Sub New(ByVal ID As String)

      If ID.Length <> 5 Or CompareID(ID) = True Then
         Throw New Exception

      Else
         For int As Integer = 0 To ID.Length - 1
            If Not Char.IsLetterOrDigit(ID.Chars(int)) Then
               Throw New Exception
            End If
         Next
         _id = ID
         AllHouses.Add(Me)
      End If

   End Sub

   'Returns the count of created houses
   Public Shared ReadOnly Property TotalCount As Integer
      Get
         Return AllHouses.Count

      End Get
   End Property


   'Returns the house of the given index
   Public Shared ReadOnly Property HouseByIndex(ByVal index As Integer) As House
      Get
         Return AllHouses(index)

      End Get
   End Property


   'Returns the type of the house
   Public ReadOnly Property Type As String
      Get
         Return _type

      End Get
   End Property


   'Returns the ID of the house
   Public ReadOnly Property ID As String
      Get
         Return _id

      End Get
   End Property


   'Returns the number of rooms of the house
   Public ReadOnly Property Rooms As Integer
      Get
         Return _rooms

      End Get
   End Property


   'Returns the number of garages of the house
   Public ReadOnly Property Garages As Integer
      Get
         Return _garages

      End Get
   End Property


   'Returns the price of the house
   Public ReadOnly Property Price As Single
      Get
         Return _price

      End Get
   End Property

   'Modifies the price of the house, based on rooms and garages
   Public MustOverride Sub Modify(ByVal numRooms As Integer, ByVal numGarages As Integer)

   'Event handler for a price changing
   Public Event PriceChange()


   'Raising the price changing event
   Protected Sub SubToRaiseEvent()
      RaiseEvent PriceChange()

   End Sub


   'Compares a given id to all of the id's in the list, returns true if matching, false otherwise
   Public Function CompareID(ByVal ID As String) As Boolean

      For index As Integer = 0 To AllHouses.Count - 1
         If ID = HouseByIndex(index)._id Then
            Return True
         Else
            Return False
         End If

      Next


   End Function



End Class
