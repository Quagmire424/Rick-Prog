Public MustInherit Class Person

   ' Shared list to store all person objects created
   Protected Shared AllPersons As List(Of Person) = New List(Of Person)


   ' Instance data, one variable for each object
   Protected _Name As String

   ' Instance data field for individual objects
   Protected _totalMiles As Single

   Protected _occupation As String

   Public Overrides Function ToString() As String
      Return _occupation & " " & _Name & ": " & _totalMiles & " miles"
   End Function

   Public Overrides Function Equals(obj As Object) As Boolean
      Dim p As Person = TryCast(obj, Person)

      If Not p Is Nothing Then
         ' Defines two objects of Person are equal when they have worked out the same miles
         Return _totalMiles = p._totalMiles
      Else
         Return False
      End If
   End Function

   ' Define event
   Public Event Over40Miles(ByVal theName As String, ByVal totalMiles As Single)

   Public ReadOnly Property Occupation As String
      Get
         Return _occupation
      End Get

      ' Could create a Set method to write the occupation
      ' We let sub-classes write the value
   End Property

   Public Shared Function GetPersonByIndex(ByVal index As Integer) As Person
      Return AllPersons(index)
   End Function

   Public Shared ReadOnly Property TotalCount As Integer
      Get
         Return AllPersons.Count
      End Get
   End Property

   Public ReadOnly Property TotalMiles()
      Get
         Return _totalMiles
      End Get
   End Property

   Public Property Name() As String
      Get
         Return _Name
      End Get
      Set(value As String)
         If value <> "" Then
            _Name = value
         Else
            Throw New Exception("Name cannot be an empty string!")
         End If
      End Set
   End Property

   'Public Sub New()
   '   _Name = "CS334"
   '   AllPersons.Add(Me)
   'End Sub

   ' Constructor
   Public Sub New(ByVal aname As String)
      _Name = aname
      AllPersons.Add(Me)
   End Sub

   Public MustOverride Sub WorkOut(ByVal Miles As String)


   'If Not IsNumeric(Miles) Or Miles.IndexOf("e", StringComparison.CurrentCultureIgnoreCase) >= 0 Then
   '   Throw New Exception("Miles must be a number!")
   'End If

   'If Miles <= 0 Then
   '   Throw New Exception("Miles must be positive!")
   'End If

   '   CheckMiles(Miles)

   '   _totalMiles += Miles

   '   ' Should use a constant
   '   If _totalMiles > 40 Then
   '      RaiseEvent Over40Miles(_Name, _totalMiles)
   '   End If
   'End Sub

   Protected Sub CheckMiles(ByVal miles As String)
      If Not IsNumeric(miles) Or miles.IndexOf("e", StringComparison.CurrentCultureIgnoreCase) >= 0 Then
         Throw New Exception("Miles must be a number!")
      End If

      If miles <= 0 Then
         Throw New Exception("Miles must be positive!")
      End If
   End Sub

   ' Using a Protected sub to raise the event
   Protected Sub SubToRaiseEvent()
      RaiseEvent Over40Miles(_Name, _totalMiles)
   End Sub

End Class
