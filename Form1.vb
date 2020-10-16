Public Class frmCalculator
    Private alert As MsgBoxResult

    Private Sub frmCalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    '///////////////////////////////////
    'Btn Class
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Console.WriteLine()
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click

        Dim Test, Quizzes, Project, Exam As Integer

        Test = CDbl(EmptyCheck(txtTest.Text))
        Quizzes = CDbl(EmptyCheck(txtQuizzes.Text))
        Project = CDbl(EmptyCheck(txtProject.Text))

        txtCAMark.Text = CStr(CA_Mark(Test, Project, Quizzes))

    End Sub

    Private Sub btnShowStats_Click(sender As Object, e As EventArgs) Handles btnShowStats.Click

    End Sub
    '///////////////////////////////////

    'Function For CA Mark Calculation
    Public Function CA_Mark(ByVal Test As Double, ByVal Project As Double, ByVal Quizzes As Double) As Double
        Dim CA, Final As Double
        Const TEST_PERCENTAGE As Double = 0.5
        Const TEST_PROJECT As Double = 0.3
        Const TEST_QUIZZES As Double = 0.2
        Dim Alert As String = "Error"

        If Test >= 0 And Test <= 100 AndAlso Project >= 0 And Project <= 100 AndAlso Quizzes >= 0 And Quizzes <= 100 Then

            CA = Test * TEST_PERCENTAGE + Project * TEST_PROJECT + Quizzes * TEST_QUIZZES

        Else
            MsgBox("Please input 0 to 100 only", MsgBoxStyle.Information, Alert)
        End If

        Return CA

    End Function

    Function EmptyCheck(ByVal text As String)
        If text = "" Then
            alert = MsgBox("Please input every Box", MsgBoxStyle.Information, "Error")
        End If
        Return alert
    End Function

End Class







