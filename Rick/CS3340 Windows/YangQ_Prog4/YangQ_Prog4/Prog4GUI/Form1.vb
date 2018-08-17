Imports System.Threading

Public Class Form1

   Private WithEvents w As UWPCS3340.Worker

   Private newThread As Thread

   Private total As Integer


   ' Declare a variable of Delegate ThreadStart
   Private startSub As ThreadStart

   ' The sub for the new thread to execute
   ' No parameters, Same as ThreadStart
   Private Sub DoWork()
      While True
         Console.WriteLine("Thread: " & Thread.CurrentThread.Name)
         Thread.Sleep(3000)
      End While
   End Sub

   Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      Thread.CurrentThread.Name = "Main" & Thread.CurrentThread.GetHashCode()

   End Sub

   Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
      While True
         Console.WriteLine("Thread: " & Thread.CurrentThread.Name)
         Thread.Sleep(3000)
      End While

   End Sub

   Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
      ' Delegate needs an address!
      ' Same as event handler
      'startSub = AddressOf DoWork

      'newThread = New Thread(startSub)

      ' We don't need the variable
      ' newThread = New Thread(AddressOf DoWork)

      ' newThread.Name = "QY" & Thread.CurrentThread.GetHashCode()

      ' Should be this one
      'newThread.Name = "QY" & newThread.GetHashCode()

      ''Start a new thread
      'newThread.Start()


      newThread = New Thread(AddressOf DoWork)

      newThread.Name = "QY" & newThread.GetHashCode()

      newThread.Start()

   End Sub

   Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
      w = New UWPCS3340.Worker

      w.WorkLoad = 4000
      w.DoIt = AddressOf GetTotal
      w.MainForm = Me

      w.SpinUp()

   End Sub

   Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
      w.SpinDown()

   End Sub

   Private Sub w_ItHappens(Msg As String) Handles w.ItHappens

      Console.WriteLine(Msg)
      Console.WriteLine("Event Handler executed by thread: " & Thread.CurrentThread.GetHashCode())


   End Sub

   ' Private Sub for the Delegate
   ' Must have the same procedure signature
   Private Sub GetTotal(ByVal amount As Integer)
      total += amount

      Console.WriteLine("Total: " & total)
      Console.WriteLine("Delegate Sub executed by thread: " & Thread.CurrentThread.GetHashCode())

      txtLog.Text &= "Total: " & total & vbCrLf
      txtLog.Text &= "Delegate Sub executed by thread: " & Thread.CurrentThread.GetHashCode() & Chr(Keys.LineFeed)


      txtLog.SelectionStart = txtLog.Text.Length - 1

      txtLog.ScrollToCaret()

   End Sub

   Private Sub txtLog_TextChanged(sender As Object, e As EventArgs) Handles txtLog.TextChanged

   End Sub
End Class
