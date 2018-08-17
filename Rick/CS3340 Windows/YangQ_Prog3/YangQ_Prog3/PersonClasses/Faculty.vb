Public Class Faculty

   Inherits Person

   Public Sub New(ByVal aname As String)

      MyBase.New(aname)

      _occupation = "Professor"

      '_Name = aname
      'AllPersons.Add(Me)
   End Sub

   Public Overrides Sub WorkOut(ByVal Miles As String)
      'If Not IsNumeric(Miles) Or Miles.IndexOf("e", StringComparison.CurrentCultureIgnoreCase) >= 0 Then
      '   Throw New Exception("Miles must be a number!")
      'End If

      'If Miles <= 0 Then
      '   Throw New Exception("Miles must be positive!")
      'End If

      CheckMiles(Miles)

      _totalMiles += 2 * Miles

      ' Should use a constant
      If _totalMiles > 40 Then
         SubToRaiseEvent()

         'RaiseEvent Over40Miles(_Name, _totalMiles)

      End If
   End Sub

End Class
