Module Module1
    Friend Const MENU_HEIGHT As Integer = 24
    Friend Const MIN_MARGIN As Integer = 20
    Friend Const MIN_SPACE_BETWEEN As Integer = 20
    Friend Const EXTRA_SPACE_DIVIDE_BY As Integer = 6
    Friend Const DeductionRate As Double = 0.33
    Friend Const regularHours As Double = 40.0
    Friend Const overTimeRate As Double = 1.5
    Friend frmPayRoll As New PayForm()
    Friend frmStats As New StatsForm()
    Friend Count As Integer = 0
    Friend Lowest As Double
    Friend Highest As Double
    Friend Average As Double
    Private Sum As Double = 0

    Sub Main()
        frmPayRoll = New PayForm
        frmStats = New StatsForm

        Application.Run(frmPayRoll)

    End Sub

    Friend Sub Compute(ByVal rate As Double, ByVal hours As Double, _
    ByRef gross As Double, ByRef deduction As Double, _
    ByRef net As Double)

    End Sub

    Friend Sub UpdateStats(ByVal NewGross As Double)

    End Sub

End Module
