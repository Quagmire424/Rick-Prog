Imports System.Threading
Imports System.Windows.Forms

Public Class UserAccount

    ' All users are stored in the list in the order they were created.
    ' A user should be removed from the list after terminated.
    Private Shared AllUsers As New List(Of UserAccount)

    ' There should be a thread to do the work for each user.
    Private _thread As Thread


    ' The user ID 
    Private _id As String

    ' To invoke the delegates
    Private _mainForm As Form

    ' A user is in one of three states after started.
    ' But cannot be re-started after being terminated.
    Private _state As UserState

    ' The working time 
    Private _workTime As Integer

    ' The transaction amount 
    Private _transactionAmount As Integer

    ' The total transaction amount 
    Private _totalTransactionAmount As Integer

    ' The transaction delegate 
    Private _trans As TransactionDelegate

    ' The pass message delegate 
    Private _report As PassMessageDelegate

    ' Used to generate the working times and transaction amounts.
    Private _randomGenerator As System.Random

    ' To manage user wait state.
    Private _userWait As New ManualResetEvent(False)

    ' To manage terminating all users.
    Private Shared _allTerminated As New ManualResetEvent(False)

    Public Enum UserState
        Working
        Waiting
        Terminated
    End Enum

    Public Delegate Sub TransactionDelegate(ByVal ID As String, ByVal Amount As Integer,
                                           ByVal Final As Boolean)
    Public Delegate Sub PassMessageDelegate(ByVal ID As String, ByVal State As UserState)


    ' Creates an Thread object for the user among other things.
    Public Sub New()

    End Sub

    ' To invoke delegates on a form.
    Public WriteOnly Property MainForm As Form

    ' To set the value for delegate _trans.
    Public WriteOnly Property TheTransaction As TransactionDelegate

    ' To Set the value of delegate _report.
    Public WriteOnly Property TheReport As PassMessageDelegate

    ' To start the user thread.
    Public Sub SpinUp()

    End Sub

    ' To terminate the user.
    Public Sub SpinDown()

    End Sub

    ' To suspend the user.
    ' Should have no effect if the user is in Waiting state.
    Public Sub UserWait()

    End Sub

    ' To wake up the user.
    ' Should have no effect if the user is in Working state.
    Public Sub UserContinue()

    End Sub

    ' To terminate all user threads.
    Public Shared Sub TerminateAllUsers()

    End Sub

    ' To get the UserAccount object at a given index of list AllUsers.
    Public Shared Function GetUserByIndex(ByVal index As Integer) As UserAccount

    End Function

    Private Sub Run()

    End Sub
End Class
