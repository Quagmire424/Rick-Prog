Imports System.Threading

Imports System.Windows.Forms

Public Class Worker

   Private _mainForm As System.Windows.Forms.Form

   Public Event ItHappens(ByVal Msg As String)

   ' Define MyDelegate as a data type (class)
   Public Delegate Sub MyDelegate(ByVal value As Integer)

   ' A private member!
   Private _DoIt As MyDelegate

   Public WriteOnly Property MainForm As Form
      Set(ByVal value As Form)
         _mainForm = value
      End Set
   End Property


   ' Public property to set and get the private data memeber
   Public Property DoIt() As MyDelegate
      Get
         Return _DoIt
      End Get
      Set(ByVal value As MyDelegate)
         _DoIt = value
      End Set
   End Property

   Private _thread As Thread
   Private WorkTime As Integer
   Private done As Boolean

   Public WriteOnly Property WorkLoad() As Integer
      Set(ByVal Value As Integer)
         WorkTime = Value
      End Set
   End Property

   Public ReadOnly Property ID() As String
      Get
         Return "QY" & _thread.GetHashCode()
      End Get
   End Property

   'Entry point for _thread
   Private Sub Run()
      Dim count As Integer

      While Not done
         'Do the work
         Thread.Sleep(WorkTime)

         'Console.WriteLine("Thread " & ID & vbCrLf &
         '                  "     Do some work" & vbCrLf &
         '                  "     count: " & count)
         Console.WriteLine("Thread " & ID & vbCrLf &
                           "     Do some work" & vbCrLf &
                           "     count: " & count &
                           "     by Thread: " & Thread.CurrentThread.GetHashCode())

         RaiseEvent ItHappens("Event raised by Thread " & Thread.CurrentThread.GetHashCode())

         '_DoIt.Invoke(count)
         ' Multiple parameters: The first is the delegate to invoke
         '                      Other parameters are the parameters of the delegate 
         _mainForm.Invoke(_DoIt, count)


         count += 1
      End While

      Console.WriteLine("Thread " & ID & vbCrLf &
                        "     I am done today." & vbCrLf &
                        "     The total count is " & count & ".")
   End Sub

   Public Sub SpinUp()
      _thread = New Thread(AddressOf Run)
      done = False
      _thread.Start()

      Console.WriteLine("Class method SpinUp executed by thread " &
                        Thread.CurrentThread.GetHashCode())

   End Sub

   Public Sub SpinDown()
      done = True

      Console.WriteLine("Class method SpinDown executed by thread " &
                        Thread.CurrentThread.GetHashCode())


   End Sub

End Class
