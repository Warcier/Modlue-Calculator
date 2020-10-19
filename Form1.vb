Public Class frmCalculator

    'Initializing Class From CalculatorClass.vb
    Dim CALCULATOR = New CalculatorClass

    Private Sub frmCalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    '///////////////////////////////////
    'Btn Class
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click 'Class btn for removing the text box
        CALCULATOR.ClearTextBox()
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click

        Dim Test, Quizzes, Project, Exam, CAScore_Var, Module_M As Integer
        Dim alert As String = "Error"

        Name = txtFullname.Text

        Test = CInt(CALCULATOR.EmptyCheck(txtTest.Text))
        Quizzes = CInt(CALCULATOR.EmptyCheck(txtQuizzes.Text))
        Project = CInt(CALCULATOR.EmptyCheck(txtProject.Text))

        txtCAMark.Text = CStr(CALCULATOR.CA_Mark(Test, Project, Quizzes))

        'CA Mark
        CAScore_Var = txtCAMark.Text

        'Exam Mark
        Exam = CInt(CALCULATOR.EmptyCheck(txtExam.Text))

        'Moudle Mark
        txtModule_Marks.Text = CStr(CALCULATOR.Module_Mark(CAScore_Var, Exam))
        Module_M = txtModule_Marks.Text

        'Module Grade
        txtModule_Grade.Text = CALCULATOR.Module_Grade(CAScore_Var, Exam, Module_M)

        'Remarks
        txtRemarks.Text = CALCULATOR.Remark(Module_M, CALCULATOR.Module_Grade(CAScore_Var, Exam, Module_M))

    End Sub

    Private Sub btnShowStats_Click(sender As Object, e As EventArgs) Handles btnShowStats.Click

    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click

    End Sub

    '///////////////////////////////////
End Class











