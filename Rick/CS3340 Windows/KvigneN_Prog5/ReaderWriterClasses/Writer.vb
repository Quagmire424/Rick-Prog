Imports System.Threading
Imports UWPCS3340

Public Class Writer

    Inherits ReaderWriter
    Dim _type As ReaderWriterType
    Dim _ID As String
    Dim MIN_SLEEP As Integer = 3000
    Dim MAX_SLEEP As Integer = 4000
    Dim MIN_DATA As Integer = -10
    Dim MAX_DATA As Integer = 10

    Public Overrides ReadOnly Property ID As String
        Get
            _ID = "Writer_NK" & _thread.GetHashCode.ToString
            Return _ID
        End Get
    End Property

    Public Overrides ReadOnly Property type As ReaderWriterType
        Get
            _type = ReaderWriterType.Writer
            Return _type
        End Get
    End Property

    Protected Overrides Sub run()
        Dim sleepTime As Integer
        Dim datVal As Integer

        _database.LockDataObj()
        Monitor.Enter(FIFOQueue)
        If (FIFOQueue.Count > 0 Or _database.TheDatabaseStatus = DatabaseClass.DatabaseStatus.Writing _
                Or _database.TheDatabaseStatus = DatabaseClass.DatabaseStatus.Reading) Then
            FIFOQueue.Enqueue(Me)
            _mainForm.Invoke(_passMsg, ID, ReaderWriter.State.Waiting, 0)
            Monitor.Exit(FIFOQueue)
            _database.ReleaseDataObj()
            _ReaderWriterEvent.WaitOne()
        Else
            _database.ReleaseDataObj()
            Monitor.Exit(FIFOQueue)
        End If

        _database.LockDataObj()
        _database.IncreaseWriterCount()
        _database.ReleaseDataObj()
        _mainForm.Invoke(_passMsg, ID, ReaderWriter.State.Working, _database.TotalValue)

        sleepTime = _randomGenerator.Next(MIN_SLEEP, MAX_SLEEP)
        Thread.Sleep(sleepTime)
        datVal = _randomGenerator.Next(MIN_DATA, MAX_DATA)
        _database.TotalValue += datVal
        _mainForm.Invoke(_passMsg, ID, ReaderWriter.State.Finished, _database.TotalValue)

        _database.LockDataObj()
        _database.DecreaseWriterCount()
        WakeupNextWhenExiting()
        _database.ReleaseDataObj()

    End Sub
End Class
