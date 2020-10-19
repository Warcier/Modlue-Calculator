Public Class frmCalculator
    Private alert As MsgBoxResult
    Public Property Error_PopUp As MsgBoxResult

    Const TEST_PERCENTAGE As Double = 0.5
    Const TEST_PROJECT As Double = 0.3
    Const TEST_QUIZZES As Double = 0.2
    Const TEST_CAMark As Double = 0.4
    Const TEST_Exam_Mark As Double = 0.6

    Private Sub frmCalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    '///////////////////////////////////
    'Btn Class
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click 'Class btn for removing the text box
        ClearTextBox()
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click

        Dim Test, Quizzes, Project, Exam, CAScore_Var, Module_Var As Integer
        Dim alert As String = "Error"

        Name = txtFullname.Text

        Test = CDbl(EmptyCheck(txtTest.Text))
        Quizzes = CDbl(EmptyCheck(txtQuizzes.Text))
        Project = CDbl(EmptyCheck(txtProject.Text))

        txtCAMark.Text = CStr(CA_Mark(Test, Project, Quizzes))

        CAScore_Var = txtCAMark.Text
        Exam = CDbl(EmptyCheck(txtExam.Text))
        txtModule_Marks.Text = CStr(Module_Mark(CAScore_Var, Exam))
        Module_Var = txtModule_Marks.Text


        If CAScore_Var < 40 Or Exam < 40 Then
            txtModule_Grade.Text = "F"
        ElseIf CAScore_Var >= 40 Or Exam >= 40 Then
            If Module_Var >= 75 And Module_Var <= 100 Then
                txtModule_Grade.Text = "A"
            ElseIf Module_Var < 75 And Module_Var >= 65 Then
                txtModule_Grade.Text = "B"
            ElseIf Module_Var < 65 And Module_Var >= 40 Then
                txtModule_Grade.Text = "C"
            End If
        Else
            MsgBox("Error", MsgBoxStyle.Information, alert)
        End If

        If txtModule_Grade.Text = "A" Or txtModule_Grade.Text = "B" Or txtModule_Grade.Text = "C" Then
            txtRemarks.Text = "Pass"
        ElseIf txtModule_Grade.Text = "F" And Module_Var < 30 Then
            txtRemarks.Text = "Resit Exam"
        ElseIf txtModule_Grade.Text = "F" And Module_Var >= 30 Then
            txtRemarks.Text = "Restudy"
        End If

        'Dim Remark As String
        'Dim MGrade As String
        'Remark = txtRemarks.Text
        'MGrade = txtModule_Grade.Text

        AddRecord(Name)


    End Sub

    Private Sub btnShowStats_Click(sender As Object, e As EventArgs) Handles btnShowStats.Click

    End Sub
    '///////////////////////////////////

    '///////////////////////////////////

    'Function For CA Mark Calculation
    Public Function CA_Mark(ByVal Test As Double, ByVal Project As Double, ByVal Quizzes As Double) As Integer


        Dim CA As Double


        Dim Alert As String = "Error"

        If Test >= 0 And Test <= 100 AndAlso Project >= 0 And Project <= 100 AndAlso Quizzes >= 0 And Quizzes <= 100 Then

            CA = Test * TEST_PERCENTAGE + Project * TEST_PROJECT + Quizzes * TEST_QUIZZES
            Return CA

        Else
            Error_PopUp = MsgBox("Please input 0 to 100 only", MsgBoxStyle.Information, Alert)
            Return 0
        End If

    End Function

    'Function For Module Mark
    Public Function Module_Mark(ByVal CAMark As Double, ByVal Exam_Mark As Double) As Integer
        Dim ModuleMark As Double


        ModuleMark = CAMark * TEST_CAMark + Exam_Mark * TEST_Exam_Mark
        Return ModuleMark


    End Function

    'Function to Check empty text box
    Function EmptyCheck(ByVal text As String)
        If text = "" Then
            Return MsgBox("Please input every Box", MsgBoxStyle.Information, "Error")
        Else
            Return text
        End If

    End Function

    Public Sub ClearTextBox()
        txtModule_Grade.Clear()
        txtModule_Marks.Clear()
        txtCAMark.Clear()
        txtRemarks.Clear()
        txtTest.Clear()
        txtQuizzes.Clear()
        txtProject.Clear()
        txtExam.Clear()
    End Sub

    Sub AddRecord(ByVal Name As String)
        lstStudent_Record.Items.Add(Name)
    End Sub

    '///////////////////////////////////
End Class









