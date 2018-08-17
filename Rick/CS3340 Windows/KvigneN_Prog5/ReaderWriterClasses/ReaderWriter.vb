Imports System.Threading

Public MustInherit Class ReaderWriter

    Protected _thread As Threading.Thread
    Protected _passMsg As PassMessage
    Protected _mainForm As System.Windows.Forms.Form
    Protected _ReaderWriterEvent As New AutoResetEvent(False)
    Protected _randomGenerator As New System.Random
    Protected Shared FIFOQueue As New Queue
    Protected Shared _database As UWPCS3340.DatabaseClass
    Private Shared endProgram As New AutoResetEvent(False)

    Public Enum ReaderWriterType
        Reader
        Writer
    End Enum

    Public Enum State
        Waiting
        Working
        Finished
    End Enum

    Public Delegate Sub PassMessage(ByVal theID As String,
                                   ByVal theState As State,
                                   ByVal theTotal As Integer)


    Public Shared WriteOnly Property TheDatabase() As UWPCS3340.DatabaseClass
        Set(value As UWPCS3340.DatabaseClass)
            _database = value
        End Set
    End Property
    ' When a writer or a reader exits the database and no other readers/writers
    ' are in the database, the writer or reader wakes up the the first reader/writer 
    ' in the waiting queue.
    ' If the queue is empty, sets endProgram to signalled (green), since it's 
    ' possible that a thread is waiting for all readers/writers to finish the work.
    ' Mutual exclusion on the queue must be enforced.
    Protected Shared Sub WakeupNextWhenExiting()
        Monitor.Enter(FIFOQueue)
        If (FIFOQueue.Count > 0) Then
            CType(FIFOQueue.Dequeue(), ReaderWriter).WakeUp()
        Else
            endProgram.Set()

        End If
        Monitor.Exit(FIFOQueue)

    End Sub

    ' Waits for all readers and writers to finish the work in order to terminate 
    ' the program.
    ' Mutual exclusion on the DataObj and the queue must be enforced.
    Public Shared Sub FinishReadWrite()
        _database.LockDataObj()
        Monitor.Enter(FIFOQueue)
        If (_database.TheDatabaseStatus = DatabaseClass.DatabaseStatus.Empty Or FIFOQueue.Count = 0) Then
            endProgram.Set()
        Else
            endProgram.Reset()

        End If
        Monitor.Exit(FIFOQueue)
        _database.ReleaseDataObj()
        endProgram.WaitOne()

    End Sub



    Public WriteOnly Property DisplayMsg() As PassMessage
        Set(value As PassMessage)
            _passMsg = value
        End Set
    End Property
    Public WriteOnly Property MainForm() As System.Windows.Forms.Form
        Set(value As System.Windows.Forms.Form)
            _mainForm = value
        End Set
    End Property
    Public MustOverride ReadOnly Property ID() As String

    Public MustOverride ReadOnly Property type() As ReaderWriterType

    Public Sub SpinUp()
        _thread = New Thread(New ThreadStart(AddressOf run))
        _thread.Start()

    End Sub

    Public Sub WakeUp()
        _ReaderWriterEvent.Set()

    End Sub

    Protected MustOverride Sub run()
End Class
