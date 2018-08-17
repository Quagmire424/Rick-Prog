Imports System.Threading

Public Class DatabaseClass

    Private _total As Integer
    Private ReaderCount As Integer
    Private WriterCount As Integer
    Private DataObj As New Object

    Public Enum DatabaseStatus
        Reading
        Writing
        Empty
    End Enum

    'Constructor that sets the total
    Public Sub New(int As Integer)
        _total = int
    End Sub

    ' Returns Reading when some readers are reading the database value,
    '         Writing when a writer is writing the database value,    
    '         Empty otherwise.
    Public ReadOnly Property TheDatabaseStatus As DatabaseStatus
        Get
            If (ReaderCount > 0) Then
                TheDatabaseStatus = DatabaseStatus.Reading
            ElseIf (WriterCount > 0) Then
                TheDatabaseStatus = DatabaseStatus.Writing
            Else
                TheDatabaseStatus = DatabaseStatus.Empty
            End If
        End Get
    End Property

    ' Enter Monitor before exclusive access to ReaderCount and WriterCount.
    Public Sub LockDataObj()

    End Sub

    ' Exit Monitor after exclusive access to ReaderCount and WriterCount.
    Public Sub ReleaseDataObj()

    End Sub

    ' Gets and sets the data value
    Public Property TotalValue As Integer
        Get
            Return _total
        End Get
        Set(value As Integer)
            _total = value
        End Set
    End Property

    ' Increments the ReaderCount by one
    Public Sub IncreaseReaderCount()
        ReaderCount += 1
    End Sub

    ' Decrements the ReaderCount by one.
    Public Sub DecreaseReaderCount()
        ReaderCount -= 1
    End Sub

    ' Increments the WriterCount by one.
    Public Sub IncreaseWriterCount()
        WriterCount += 1
    End Sub

    ' Decrements the WriterCount by one.
    Public Sub DecreaseWriterCount()
        WriterCount -= 1
    End Sub

End Class
