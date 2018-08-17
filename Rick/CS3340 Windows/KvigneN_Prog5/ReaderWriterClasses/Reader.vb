Imports System.Threading
Imports UWPCS3340

Public Class Reader

    Inherits ReaderWriter
    Dim _type As ReaderWriterType
    Dim _ID As String
    Dim MIN_SLEEP As Integer = 2000
    Dim MAX_SLEEP As Integer = 3000

    Public Overrides ReadOnly Property ID As String
        Get
            _ID = "Reader_NK" & _thread.GetHashCode.ToString
            Return _ID
        End Get
    End Property

    Public Overrides ReadOnly Property type As ReaderWriterType
        Get
            _type = ReaderWriterType.Reader
            Return _type
        End Get
    End Property

    Protected Overrides Sub run()
        Dim sleepTime As Integer
        Dim nextRead As ReaderWriter

        _database.LockDataObj()
        Monitor.Enter(FIFOQueue)
        If (FIFOQueue.Count > 0 Or _database.TheDatabaseStatus = DatabaseClass.DatabaseStatus.Writing) Then
            FIFOQueue.Enqueue(Me)
            _mainForm.Invoke(_passMsg, ID, ReaderWriter.State.Waiting, 0)
            Monitor.Exit(FIFOQueue)
            _database.ReleaseDataObj()
            _ReaderWriterEvent.WaitOne()
            If (FIFOQueue.Count > 0) Then
                If (FIFOQueue.Peek = ReaderWriterType.Reader) Then
                    nextRead = FIFOQueue.Dequeue
                    nextRead.WakeUp()

                End If
            End If
        Else
            _database.ReleaseDataObj()
            Monitor.Exit(FIFOQueue)
        End If

        _database.LockDataObj()
        _database.IncreaseReaderCount()
        _database.ReleaseDataObj()

        _mainForm.Invoke(_passMsg, ID, ReaderWriter.State.Working, _database.TotalValue)
        sleepTime = _randomGenerator.Next(MIN_SLEEP, MAX_SLEEP)
        Thread.Sleep(sleepTime)
        _mainForm.Invoke(_passMsg, ID, ReaderWriter.State.Finished, _database.TotalValue)

        _database.LockDataObj()
        _database.DecreaseReaderCount()
        If (_database.TheDatabaseStatus = DatabaseClass.DatabaseStatus.Empty) Then
            WakeupNextWhenExiting()

        End If
        _database.ReleaseDataObj()

    End Sub
End Class
