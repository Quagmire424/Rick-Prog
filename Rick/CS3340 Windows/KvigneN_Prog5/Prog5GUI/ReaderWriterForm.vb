Imports UWPCS3340
Imports System.Threading

Public Class ReaderWriterForm

    Private readOrWrite As ReaderWriter

    Private Sub btnReader_Click(sender As Object, e As EventArgs) Handles btnReader.Click
        readOrWrite = New Reader()
        readOrWrite.MainForm = Me
        readOrWrite.SpinUp()

    End Sub

    Private Sub btnWriter_Click(sender As Object, e As EventArgs) Handles btnWriter.Click
        readOrWrite = New Writer()
        readOrWrite.MainForm = Me
        readOrWrite.SpinUp()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

    End Sub

    Private Sub ReaderWriterForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class