Imports System.Data.OleDb
Public Class frmCalculator

    'Initializing Class From CalculatorClass.vb
    Dim CALCULATOR As New CalculatorClass
    Dim Result As New Result

    'Gobal Variables for accessing all function/sub inside this Class
    Dim CountA As Integer
    Dim CountF As Integer
    Dim moduleAverage As Double
    Dim Average As Integer
    Dim alert As String = "Error"
    Dim ID As Integer = 1

    Private Sub frmCalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    '///////////////////////////////////
    'Btn Class


    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click 'Class btn for removing the text box
        ClearTextBox()
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click



        Dim Test, Quizzes, Project, Exam, CAScore_Var, Module_M As Integer

        Name = txtFullname.Text
        Test = CInt(CALCULATOR.EmptyCheck(txtTest.Text, "Test"))
        Quizzes = CInt(CALCULATOR.EmptyCheck(txtQuizzes.Text, "Quizzes"))
        Project = CInt(CALCULATOR.EmptyCheck(txtProject.Text, "Project"))

        'CA Mark
        txtCAMark.Text = CStr(CALCULATOR.CA_Mark(Test, Project, Quizzes))
        CAScore_Var = txtCAMark.Text

        'Exam Mark
        Exam = CInt(CALCULATOR.EmptyCheck(txtExam.Text, "Exam"))

        'Moudle Mark
        txtModule_Marks.Text = CStr(CALCULATOR.Module_Mark(CAScore_Var, Exam))
        Module_M = txtModule_Marks.Text

        'Module Grade
        txtModule_Grade.Text = CALCULATOR.Module_Grade(CAScore_Var, Exam, Module_M)

        'Remarks
        txtRemarks.Text = CALCULATOR.Remark(Module_M, CALCULATOR.Module_Grade(CAScore_Var, Exam, Module_M))

        'Add "Name" the list
        lstStudent_Record.Items.Add(Name)

        'To Calculate the Average
        Average += Module_M
        moduleAverage = Average / lstStudent_Record.Items.Count()

        'Add 1 to Count A Or F 
        If txtModule_Grade.Text = Result.A() Then
            CountA += 1
        ElseIf txtModule_Grade.Text = Result.F() Then
            CountF += 1
        End If



    End Sub

    Private Sub btnShowStats_Click(sender As Object, e As EventArgs) Handles btnShowStats.Click

        txtCountToA.Text = CountA
        txtCountToF.Text = CountF
        txtModule_Average.Text = CStr(Math.Round(moduleAverage, 2))
        txtNoStudents.Text = lstStudent_Record.Items.Count()

    End Sub

    'Find Student Name
    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        Dim n As Integer = -1
        Dim i As Integer = Nothing

        For i = 0 To lstStudent_Record.Items.Count - 1 Step 1
            If lstStudent_Record.Items(i) = txtNameFinder.Text Then

                n = i + 1
                MessageBox.Show(txtNameFinder.Text & " is on line " & n)
            End If
        Next

        If txtNameFinder.Text = "" Then

            MessageBox.Show("Please input a name")
        Else
            If n = -1 Then
                MessageBox.Show(txtNameFinder.Text & " not found")
            End If
        End If
    End Sub

    'Function to Clear txtBox
    Public Sub ClearTextBox()

        txtModule_Grade.Clear()
        txtModule_Marks.Clear()
        txtCAMark.Clear()
        txtRemarks.Clear()
        txtTest.Clear()
        txtQuizzes.Clear()
        txtProject.Clear()
        txtExam.Clear()
        txtFullname.Clear()
    End Sub

    Private Sub BarResultIndicator_Click(sender As Object, e As EventArgs) Handles BarResultIndicator.Click

        Dim Conversion As Int32 = CInt(txtModule_Average.Text)
        BarResultIndicator.Value = Conversion

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click


        'Adding Data to Access
        Dim Provider, DataFile, connstring, InsertSQL As String
        
        Dim MyConnection As OleDbConnection = New OleDbConnection

        Provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        DataFile = "D:\SchoolWork\Database Applications Development 1A\Project\VB Project\Project2021\StudentRecord.accdb"
        connstring = Provider & DataFile
        MyConnection.ConnectionString = connstring
        MyConnection.Open()
        InsertSQL = "Insert into [Student Record](StudentID, FullName, CA_Mark, Module_Grade, Module_Mark, Remark) Values (?,?,?,?,?,?)"
        Dim DataConnRef As OleDbCommand = New OleDbCommand(InsertSQL, MyConnection)
        DataConnRef.Parameters.Add(New OleDbParameter("StudentID", CType(txtSTUID.Text, Integer)))
        DataConnRef.Parameters.Add(New OleDbParameter("FullName", CType(txtFullname.Text, String)))
        DataConnRef.Parameters.Add(New OleDbParameter("CA_Mark", CType(txtCAMark.Text, Integer)))
        DataConnRef.Parameters.Add(New OleDbParameter("Module_Grade", CType(txtModule_Grade.Text, String)))
        DataConnRef.Parameters.Add(New OleDbParameter("Module_Mark", CType(txtModule_Marks.Text, Integer)))
        DataConnRef.Parameters.Add(New OleDbParameter("Remark", CType(txtRemarks.Text, String)))

        Try
            DataConnRef.ExecuteNonQuery()
            DataConnRef.Dispose()
            MyConnection.Close()


        Catch Errors As Exception
            MsgBox(Errors.Message)
        End Try





    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click

        For i = 0 To 2 Step 1
            'TODO: This line of code loads data into the 'StudentRecordDataSet.Student_Record' table. You can move, or remove it, as needed.
            Me.Student_RecordTableAdapter.Fill(Me.StudentRecordDataSet.Student_Record)
        Next

    End Sub

    '///////////////////////////////////
End Class

'All Calcutor Function 
Public Class CalculatorClass

    Public Property alert As MsgBoxResult
    Const TEST_PERCENTAGE As Double = 0.5
    Const TEST_PROJECT As Double = 0.3
    Const TEST_QUIZZES As Double = 0.2
    Const TEST_CAMark As Double = 0.4
    Const TEST_Exam_Mark As Double = 0.6

    'Function For CA Mark Calculation
    Public Function CA_Mark(ByVal Test As Double, ByVal Project As Double, ByVal Quizzes As Double) As Integer

        Dim CA As Double
        Dim alert As String = "Error"

        If Test >= 0 And Test <= 100 AndAlso Project >= 0 And Project <= 100 AndAlso Quizzes >= 0 And Quizzes <= 100 Then

            CA = Test * TEST_PERCENTAGE + Project * TEST_PROJECT + Quizzes * TEST_QUIZZES
            Return CA

        Else
            alert = MsgBox("Please input 0 to 100 only", MsgBoxStyle.Information, alert)
            Return 0
        End If

    End Function

    'Function For Module Mark
    Public Function Module_Mark(ByVal CAMark As Double, ByVal Exam_Mark As Double) As Integer
        Dim ModuleMark As Double

        ModuleMark = CAMark * TEST_CAMark + Exam_Mark * TEST_Exam_Mark
        Return ModuleMark

    End Function

    'Function For Remarks
    Public Function Remark(ByVal MMark As Integer, ByVal MGrade As String) As String
        Dim Result As New Result

        If MGrade = "A" Or MGrade = "B" Or MGrade = "C" Then
            Return Result.Pass()
        ElseIf MGrade = "F" And MMark < 30 Then
            Return Result.Resit_Exam()
        ElseIf MGrade = "F" And MMark >= 30 Then
            Return Result.ReStudy()
        Else
            Return 0 'Error Message
        End If

    End Function

    'Function for Module Grade
    Public Function Module_Grade(ByVal CAMark As Integer, ByVal Exam_Mark As Integer, MMark As Integer)
        Dim Result As New Result

        If CAMark < 40 Or Exam_Mark < 40 Then
            Return Result.F()
        ElseIf CAMark >= 40 Or Exam_Mark >= 40 Then

            If MMark >= 75 And MMark <= 100 Then
                Return Result.A()

            ElseIf MMark < 75 And MMark >= 65 Then
                Return Result.B()

            ElseIf MMark < 65 And MMark >= 40 Then

                Return Result.C()
            Else
                Return 0 'Error
            End If

        Else
            alert = MsgBox("Error", MsgBoxStyle.Information, alert)
            Return alert
        End If

    End Function

    'Function to Check empty text box
    Public Function EmptyCheck(ByVal text As String, ByVal Warning As String)
        If text = "" Then
            Return MsgBox("Please input " & Warning & " box", MsgBoxStyle.Information, "Error")
        Else
            Return text
        End If

    End Function


End Class

'GET for the Module Result
Public Class Result

    Public Function Pass() As String
        Return "Pass"
    End Function

    Public Function Resit_Exam() As String
        Return "Resit Exam"
    End Function

    Public Function ReStudy() As String
        Return "ReStudy"
    End Function

    Public Function A() As String
        Return "A"
    End Function

    Public Function B() As String
        Return "B"
    End Function

    Public Function C() As String
        Return "C"
    End Function

    Public Function F() As String
        Return "F"
    End Function
End Class











