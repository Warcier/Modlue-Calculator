<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCalculator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.blName = New System.Windows.Forms.Label()
        Me.txtFullname = New System.Windows.Forms.TextBox()
        Me.lblQuizzes = New System.Windows.Forms.Label()
        Me.lblTest = New System.Windows.Forms.Label()
        Me.lblProject = New System.Windows.Forms.Label()
        Me.lblExam = New System.Windows.Forms.Label()
        Me.txtQuizzes = New System.Windows.Forms.TextBox()
        Me.txtTest = New System.Windows.Forms.TextBox()
        Me.txtExam = New System.Windows.Forms.TextBox()
        Me.txtProject = New System.Windows.Forms.TextBox()
        Me.lblCAmark = New System.Windows.Forms.Label()
        Me.lblModule_Grade = New System.Windows.Forms.Label()
        Me.lblModule_Marks = New System.Windows.Forms.Label()
        Me.lblRemarks = New System.Windows.Forms.Label()
        Me.txtModule_Marks = New System.Windows.Forms.TextBox()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.txtCAMark = New System.Windows.Forms.TextBox()
        Me.txtModule_Grade = New System.Windows.Forms.TextBox()
        Me.lstStudent_Record = New System.Windows.Forms.ListBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.txtCountToF = New System.Windows.Forms.TextBox()
        Me.txtModule_Average = New System.Windows.Forms.TextBox()
        Me.txtNoStudents = New System.Windows.Forms.TextBox()
        Me.txtCountToA = New System.Windows.Forms.TextBox()
        Me.lblModule_Average = New System.Windows.Forms.Label()
        Me.lblCountF = New System.Windows.Forms.Label()
        Me.lblCountA = New System.Windows.Forms.Label()
        Me.lblNoStudents = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnShowStats = New System.Windows.Forms.Button()
        Me.txtNameFinder = New System.Windows.Forms.TextBox()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.GrpCA = New System.Windows.Forms.GroupBox()
        Me.GrpMR = New System.Windows.Forms.GroupBox()
        Me.GrpInputExam = New System.Windows.Forms.GroupBox()
        Me.lblStdID = New System.Windows.Forms.Label()
        Me.txtSTUID = New System.Windows.Forms.TextBox()
        Me.GrpMarksGrade = New System.Windows.Forms.GroupBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GrpModuleStatistic = New System.Windows.Forms.GroupBox()
        Me.BarResultIndicator = New System.Windows.Forms.ProgressBar()
        Me.StudentRecordDataGrid = New System.Windows.Forms.DataGridView()
        Me.StudentIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FullNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CAMarkDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModuleGradeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModuleMarkDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RemarkDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentRecordBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindSutdent_Record_Data = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentRecordDataSet = New Project2021.StudentRecordDataSet()
        Me.StudentRecordDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Student_RecordTableAdapter = New Project2021.StudentRecordDataSetTableAdapters.Student_RecordTableAdapter()
        Me.GrpCA.SuspendLayout()
        Me.GrpMR.SuspendLayout()
        Me.GrpInputExam.SuspendLayout()
        Me.GrpMarksGrade.SuspendLayout()
        Me.GrpModuleStatistic.SuspendLayout()
        CType(Me.StudentRecordDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentRecordBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindSutdent_Record_Data, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentRecordDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentRecordDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'blName
        '
        Me.blName.AutoSize = True
        Me.blName.ForeColor = System.Drawing.Color.Snow
        Me.blName.Location = New System.Drawing.Point(18, 30)
        Me.blName.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.blName.Name = "blName"
        Me.blName.Size = New System.Drawing.Size(59, 20)
        Me.blName.TabIndex = 1
        Me.blName.Text = "Name :"
        '
        'txtFullname
        '
        Me.txtFullname.BackColor = System.Drawing.Color.RosyBrown
        Me.txtFullname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFullname.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtFullname.Location = New System.Drawing.Point(77, 34)
        Me.txtFullname.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtFullname.Name = "txtFullname"
        Me.txtFullname.Size = New System.Drawing.Size(271, 16)
        Me.txtFullname.TabIndex = 2
        '
        'lblQuizzes
        '
        Me.lblQuizzes.AutoSize = True
        Me.lblQuizzes.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.lblQuizzes.Location = New System.Drawing.Point(9, 67)
        Me.lblQuizzes.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblQuizzes.Name = "lblQuizzes"
        Me.lblQuizzes.Size = New System.Drawing.Size(73, 22)
        Me.lblQuizzes.TabIndex = 6
        Me.lblQuizzes.Text = "Quizzes"
        '
        'lblTest
        '
        Me.lblTest.AutoSize = True
        Me.lblTest.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.lblTest.Location = New System.Drawing.Point(9, 34)
        Me.lblTest.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTest.Name = "lblTest"
        Me.lblTest.Size = New System.Drawing.Size(46, 22)
        Me.lblTest.TabIndex = 7
        Me.lblTest.Text = "Test"
        '
        'lblProject
        '
        Me.lblProject.AutoSize = True
        Me.lblProject.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.lblProject.Location = New System.Drawing.Point(9, 101)
        Me.lblProject.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblProject.Name = "lblProject"
        Me.lblProject.Size = New System.Drawing.Size(66, 22)
        Me.lblProject.TabIndex = 8
        Me.lblProject.Text = "Project"
        '
        'lblExam
        '
        Me.lblExam.AutoSize = True
        Me.lblExam.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.lblExam.Location = New System.Drawing.Point(9, 134)
        Me.lblExam.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblExam.Name = "lblExam"
        Me.lblExam.Size = New System.Drawing.Size(55, 22)
        Me.lblExam.TabIndex = 9
        Me.lblExam.Text = "Exam"
        '
        'txtQuizzes
        '
        Me.txtQuizzes.BackColor = System.Drawing.Color.RosyBrown
        Me.txtQuizzes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtQuizzes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtQuizzes.Location = New System.Drawing.Point(100, 70)
        Me.txtQuizzes.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtQuizzes.Name = "txtQuizzes"
        Me.txtQuizzes.Size = New System.Drawing.Size(96, 16)
        Me.txtQuizzes.TabIndex = 10
        '
        'txtTest
        '
        Me.txtTest.BackColor = System.Drawing.Color.RosyBrown
        Me.txtTest.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTest.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtTest.Location = New System.Drawing.Point(100, 37)
        Me.txtTest.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtTest.Name = "txtTest"
        Me.txtTest.Size = New System.Drawing.Size(96, 16)
        Me.txtTest.TabIndex = 11
        '
        'txtExam
        '
        Me.txtExam.BackColor = System.Drawing.Color.RosyBrown
        Me.txtExam.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtExam.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtExam.Location = New System.Drawing.Point(100, 137)
        Me.txtExam.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtExam.Name = "txtExam"
        Me.txtExam.Size = New System.Drawing.Size(96, 16)
        Me.txtExam.TabIndex = 12
        '
        'txtProject
        '
        Me.txtProject.BackColor = System.Drawing.Color.RosyBrown
        Me.txtProject.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtProject.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtProject.Location = New System.Drawing.Point(100, 104)
        Me.txtProject.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtProject.Name = "txtProject"
        Me.txtProject.Size = New System.Drawing.Size(96, 16)
        Me.txtProject.TabIndex = 13
        '
        'lblCAmark
        '
        Me.lblCAmark.AutoSize = True
        Me.lblCAmark.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.lblCAmark.Location = New System.Drawing.Point(5, 31)
        Me.lblCAmark.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCAmark.Name = "lblCAmark"
        Me.lblCAmark.Size = New System.Drawing.Size(79, 22)
        Me.lblCAmark.TabIndex = 14
        Me.lblCAmark.Text = "CA Mark"
        '
        'lblModule_Grade
        '
        Me.lblModule_Grade.AutoSize = True
        Me.lblModule_Grade.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.lblModule_Grade.Location = New System.Drawing.Point(5, 62)
        Me.lblModule_Grade.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblModule_Grade.Name = "lblModule_Grade"
        Me.lblModule_Grade.Size = New System.Drawing.Size(123, 22)
        Me.lblModule_Grade.TabIndex = 15
        Me.lblModule_Grade.Text = "Module Grade"
        '
        'lblModule_Marks
        '
        Me.lblModule_Marks.AutoSize = True
        Me.lblModule_Marks.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.lblModule_Marks.Location = New System.Drawing.Point(5, 94)
        Me.lblModule_Marks.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblModule_Marks.Name = "lblModule_Marks"
        Me.lblModule_Marks.Size = New System.Drawing.Size(121, 22)
        Me.lblModule_Marks.TabIndex = 16
        Me.lblModule_Marks.Text = "Module Marks"
        '
        'lblRemarks
        '
        Me.lblRemarks.AutoSize = True
        Me.lblRemarks.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.lblRemarks.Location = New System.Drawing.Point(5, 126)
        Me.lblRemarks.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRemarks.Name = "lblRemarks"
        Me.lblRemarks.Size = New System.Drawing.Size(81, 22)
        Me.lblRemarks.TabIndex = 17
        Me.lblRemarks.Text = "Remarks"
        '
        'txtModule_Marks
        '
        Me.txtModule_Marks.BackColor = System.Drawing.Color.RosyBrown
        Me.txtModule_Marks.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtModule_Marks.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtModule_Marks.Location = New System.Drawing.Point(133, 102)
        Me.txtModule_Marks.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtModule_Marks.Name = "txtModule_Marks"
        Me.txtModule_Marks.ReadOnly = True
        Me.txtModule_Marks.Size = New System.Drawing.Size(96, 16)
        Me.txtModule_Marks.TabIndex = 21
        '
        'txtRemarks
        '
        Me.txtRemarks.BackColor = System.Drawing.Color.RosyBrown
        Me.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRemarks.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtRemarks.Location = New System.Drawing.Point(133, 133)
        Me.txtRemarks.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.ReadOnly = True
        Me.txtRemarks.Size = New System.Drawing.Size(96, 16)
        Me.txtRemarks.TabIndex = 20
        '
        'txtCAMark
        '
        Me.txtCAMark.BackColor = System.Drawing.Color.RosyBrown
        Me.txtCAMark.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCAMark.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtCAMark.Location = New System.Drawing.Point(133, 38)
        Me.txtCAMark.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtCAMark.Name = "txtCAMark"
        Me.txtCAMark.ReadOnly = True
        Me.txtCAMark.Size = New System.Drawing.Size(96, 16)
        Me.txtCAMark.TabIndex = 19
        '
        'txtModule_Grade
        '
        Me.txtModule_Grade.BackColor = System.Drawing.Color.RosyBrown
        Me.txtModule_Grade.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtModule_Grade.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtModule_Grade.Location = New System.Drawing.Point(133, 70)
        Me.txtModule_Grade.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtModule_Grade.Name = "txtModule_Grade"
        Me.txtModule_Grade.ReadOnly = True
        Me.txtModule_Grade.Size = New System.Drawing.Size(96, 16)
        Me.txtModule_Grade.TabIndex = 18
        '
        'lstStudent_Record
        '
        Me.lstStudent_Record.BackColor = System.Drawing.Color.RosyBrown
        Me.lstStudent_Record.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstStudent_Record.FormattingEnabled = True
        Me.lstStudent_Record.ItemHeight = 20
        Me.lstStudent_Record.Location = New System.Drawing.Point(1090, 1)
        Me.lstStudent_Record.Name = "lstStudent_Record"
        Me.lstStudent_Record.Size = New System.Drawing.Size(333, 660)
        Me.lstStudent_Record.TabIndex = 22
        '
        'btnClear
        '
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(280, 240)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(204, 30)
        Me.btnClear.TabIndex = 24
        Me.btnClear.Text = "Clear All"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnConfirm
        '
        Me.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirm.ForeColor = System.Drawing.Color.White
        Me.btnConfirm.Location = New System.Drawing.Point(29, 239)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(204, 31)
        Me.btnConfirm.TabIndex = 25
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'txtCountToF
        '
        Me.txtCountToF.BackColor = System.Drawing.Color.RosyBrown
        Me.txtCountToF.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCountToF.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtCountToF.Location = New System.Drawing.Point(299, 217)
        Me.txtCountToF.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtCountToF.Name = "txtCountToF"
        Me.txtCountToF.ReadOnly = True
        Me.txtCountToF.Size = New System.Drawing.Size(146, 23)
        Me.txtCountToF.TabIndex = 36
        '
        'txtModule_Average
        '
        Me.txtModule_Average.BackColor = System.Drawing.Color.RosyBrown
        Me.txtModule_Average.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtModule_Average.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtModule_Average.Location = New System.Drawing.Point(299, 268)
        Me.txtModule_Average.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtModule_Average.Name = "txtModule_Average"
        Me.txtModule_Average.ReadOnly = True
        Me.txtModule_Average.Size = New System.Drawing.Size(146, 23)
        Me.txtModule_Average.TabIndex = 35
        '
        'txtNoStudents
        '
        Me.txtNoStudents.BackColor = System.Drawing.Color.RosyBrown
        Me.txtNoStudents.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNoStudents.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtNoStudents.Location = New System.Drawing.Point(299, 110)
        Me.txtNoStudents.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtNoStudents.Name = "txtNoStudents"
        Me.txtNoStudents.ReadOnly = True
        Me.txtNoStudents.Size = New System.Drawing.Size(146, 23)
        Me.txtNoStudents.TabIndex = 34
        '
        'txtCountToA
        '
        Me.txtCountToA.BackColor = System.Drawing.Color.RosyBrown
        Me.txtCountToA.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCountToA.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtCountToA.Location = New System.Drawing.Point(299, 166)
        Me.txtCountToA.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtCountToA.Name = "txtCountToA"
        Me.txtCountToA.ReadOnly = True
        Me.txtCountToA.Size = New System.Drawing.Size(146, 23)
        Me.txtCountToA.TabIndex = 33
        '
        'lblModule_Average
        '
        Me.lblModule_Average.AutoSize = True
        Me.lblModule_Average.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lblModule_Average.Location = New System.Drawing.Point(38, 268)
        Me.lblModule_Average.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblModule_Average.Name = "lblModule_Average"
        Me.lblModule_Average.Size = New System.Drawing.Size(156, 25)
        Me.lblModule_Average.TabIndex = 32
        Me.lblModule_Average.Text = "Module Average"
        '
        'lblCountF
        '
        Me.lblCountF.AutoSize = True
        Me.lblCountF.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lblCountF.Location = New System.Drawing.Point(39, 220)
        Me.lblCountF.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCountF.Name = "lblCountF"
        Me.lblCountF.Size = New System.Drawing.Size(103, 25)
        Me.lblCountF.TabIndex = 31
        Me.lblCountF.Text = "Count to F"
        '
        'lblCountA
        '
        Me.lblCountA.AutoSize = True
        Me.lblCountA.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lblCountA.Location = New System.Drawing.Point(39, 166)
        Me.lblCountA.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCountA.Name = "lblCountA"
        Me.lblCountA.Size = New System.Drawing.Size(105, 25)
        Me.lblCountA.TabIndex = 30
        Me.lblCountA.Text = "Count to A"
        '
        'lblNoStudents
        '
        Me.lblNoStudents.AutoSize = True
        Me.lblNoStudents.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lblNoStudents.Location = New System.Drawing.Point(39, 110)
        Me.lblNoStudents.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNoStudents.Name = "lblNoStudents"
        Me.lblNoStudents.Size = New System.Drawing.Size(190, 25)
        Me.lblNoStudents.TabIndex = 29
        Me.lblNoStudents.Text = "Number Of Students"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Location = New System.Drawing.Point(567, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(22, 451)
        Me.Panel1.TabIndex = 37
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gray
        Me.Panel2.Location = New System.Drawing.Point(-7, 446)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1097, 36)
        Me.Panel2.TabIndex = 38
        '
        'btnShowStats
        '
        Me.btnShowStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShowStats.ForeColor = System.Drawing.Color.White
        Me.btnShowStats.Location = New System.Drawing.Point(115, 331)
        Me.btnShowStats.Name = "btnShowStats"
        Me.btnShowStats.Size = New System.Drawing.Size(245, 44)
        Me.btnShowStats.TabIndex = 39
        Me.btnShowStats.Text = "Show Statistic"
        Me.btnShowStats.UseVisualStyleBackColor = True
        '
        'txtNameFinder
        '
        Me.txtNameFinder.BackColor = System.Drawing.Color.LightCoral
        Me.txtNameFinder.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNameFinder.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtNameFinder.Location = New System.Drawing.Point(1090, 650)
        Me.txtNameFinder.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtNameFinder.Name = "txtNameFinder"
        Me.txtNameFinder.Size = New System.Drawing.Size(333, 23)
        Me.txtNameFinder.TabIndex = 40
        '
        'btnFind
        '
        Me.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFind.ForeColor = System.Drawing.Color.White
        Me.btnFind.Location = New System.Drawing.Point(1080, 671)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(343, 97)
        Me.btnFind.TabIndex = 41
        Me.btnFind.Text = "Find"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'GrpCA
        '
        Me.GrpCA.Controls.Add(Me.lblProject)
        Me.GrpCA.Controls.Add(Me.lblTest)
        Me.GrpCA.Controls.Add(Me.lblQuizzes)
        Me.GrpCA.Controls.Add(Me.lblExam)
        Me.GrpCA.Controls.Add(Me.txtQuizzes)
        Me.GrpCA.Controls.Add(Me.txtTest)
        Me.GrpCA.Controls.Add(Me.txtExam)
        Me.GrpCA.Controls.Add(Me.txtProject)
        Me.GrpCA.ForeColor = System.Drawing.Color.Gainsboro
        Me.GrpCA.Location = New System.Drawing.Point(16, 45)
        Me.GrpCA.Name = "GrpCA"
        Me.GrpCA.Size = New System.Drawing.Size(233, 188)
        Me.GrpCA.TabIndex = 42
        Me.GrpCA.TabStop = False
        Me.GrpCA.Text = "CA Component"
        '
        'GrpMR
        '
        Me.GrpMR.Controls.Add(Me.lblCAmark)
        Me.GrpMR.Controls.Add(Me.lblModule_Grade)
        Me.GrpMR.Controls.Add(Me.lblModule_Marks)
        Me.GrpMR.Controls.Add(Me.lblRemarks)
        Me.GrpMR.Controls.Add(Me.txtModule_Grade)
        Me.GrpMR.Controls.Add(Me.txtCAMark)
        Me.GrpMR.Controls.Add(Me.txtRemarks)
        Me.GrpMR.Controls.Add(Me.txtModule_Marks)
        Me.GrpMR.ForeColor = System.Drawing.Color.Silver
        Me.GrpMR.Location = New System.Drawing.Point(255, 45)
        Me.GrpMR.Name = "GrpMR"
        Me.GrpMR.Size = New System.Drawing.Size(262, 188)
        Me.GrpMR.TabIndex = 43
        Me.GrpMR.TabStop = False
        Me.GrpMR.Text = "Module Result:"
        '
        'GrpInputExam
        '
        Me.GrpInputExam.Controls.Add(Me.lblStdID)
        Me.GrpInputExam.Controls.Add(Me.txtSTUID)
        Me.GrpInputExam.Controls.Add(Me.GrpCA)
        Me.GrpInputExam.Controls.Add(Me.GrpMR)
        Me.GrpInputExam.Controls.Add(Me.btnConfirm)
        Me.GrpInputExam.Controls.Add(Me.btnClear)
        Me.GrpInputExam.ForeColor = System.Drawing.Color.Silver
        Me.GrpInputExam.Location = New System.Drawing.Point(6, 76)
        Me.GrpInputExam.Name = "GrpInputExam"
        Me.GrpInputExam.Size = New System.Drawing.Size(524, 290)
        Me.GrpInputExam.TabIndex = 44
        Me.GrpInputExam.TabStop = False
        Me.GrpInputExam.Text = "Input CA and Exam Mark"
        '
        'lblStdID
        '
        Me.lblStdID.AutoSize = True
        Me.lblStdID.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.lblStdID.Location = New System.Drawing.Point(287, 16)
        Me.lblStdID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblStdID.Name = "lblStdID"
        Me.lblStdID.Size = New System.Drawing.Size(94, 22)
        Me.lblStdID.TabIndex = 45
        Me.lblStdID.Text = "StudentID:"
        '
        'txtSTUID
        '
        Me.txtSTUID.BackColor = System.Drawing.Color.RosyBrown
        Me.txtSTUID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSTUID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtSTUID.Location = New System.Drawing.Point(388, 22)
        Me.txtSTUID.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtSTUID.Name = "txtSTUID"
        Me.txtSTUID.Size = New System.Drawing.Size(96, 16)
        Me.txtSTUID.TabIndex = 44
        '
        'GrpMarksGrade
        '
        Me.GrpMarksGrade.Controls.Add(Me.btnAdd)
        Me.GrpMarksGrade.Controls.Add(Me.blName)
        Me.GrpMarksGrade.Controls.Add(Me.GrpInputExam)
        Me.GrpMarksGrade.Controls.Add(Me.txtFullname)
        Me.GrpMarksGrade.ForeColor = System.Drawing.Color.Silver
        Me.GrpMarksGrade.Location = New System.Drawing.Point(12, 32)
        Me.GrpMarksGrade.Name = "GrpMarksGrade"
        Me.GrpMarksGrade.Size = New System.Drawing.Size(549, 408)
        Me.GrpMarksGrade.TabIndex = 45
        Me.GrpMarksGrade.TabStop = False
        Me.GrpMarksGrade.Text = "Marks and Grades For Indiviual Student"
        '
        'btnAdd
        '
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(161, 372)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(204, 30)
        Me.btnAdd.TabIndex = 45
        Me.btnAdd.Text = "Add to Data"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Gray
        Me.Panel3.Location = New System.Drawing.Point(0, 1)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1090, 31)
        Me.Panel3.TabIndex = 46
        '
        'GrpModuleStatistic
        '
        Me.GrpModuleStatistic.Controls.Add(Me.BarResultIndicator)
        Me.GrpModuleStatistic.Controls.Add(Me.lblNoStudents)
        Me.GrpModuleStatistic.Controls.Add(Me.lblCountA)
        Me.GrpModuleStatistic.Controls.Add(Me.lblCountF)
        Me.GrpModuleStatistic.Controls.Add(Me.lblModule_Average)
        Me.GrpModuleStatistic.Controls.Add(Me.txtCountToA)
        Me.GrpModuleStatistic.Controls.Add(Me.btnShowStats)
        Me.GrpModuleStatistic.Controls.Add(Me.txtNoStudents)
        Me.GrpModuleStatistic.Controls.Add(Me.txtModule_Average)
        Me.GrpModuleStatistic.Controls.Add(Me.txtCountToF)
        Me.GrpModuleStatistic.ForeColor = System.Drawing.Color.Silver
        Me.GrpModuleStatistic.Location = New System.Drawing.Point(595, 32)
        Me.GrpModuleStatistic.Name = "GrpModuleStatistic"
        Me.GrpModuleStatistic.Size = New System.Drawing.Size(493, 408)
        Me.GrpModuleStatistic.TabIndex = 47
        Me.GrpModuleStatistic.TabStop = False
        Me.GrpModuleStatistic.Text = "Module Statistic"
        '
        'BarResultIndicator
        '
        Me.BarResultIndicator.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BarResultIndicator.Location = New System.Drawing.Point(43, 35)
        Me.BarResultIndicator.Name = "BarResultIndicator"
        Me.BarResultIndicator.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BarResultIndicator.Size = New System.Drawing.Size(402, 23)
        Me.BarResultIndicator.Step = 1
        Me.BarResultIndicator.TabIndex = 40
        '
        'StudentRecordDataGrid
        '
        Me.StudentRecordDataGrid.AllowUserToAddRows = False
        Me.StudentRecordDataGrid.AllowUserToDeleteRows = False
        Me.StudentRecordDataGrid.AutoGenerateColumns = False
        Me.StudentRecordDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.StudentRecordDataGrid.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark
        Me.StudentRecordDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.StudentRecordDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.StudentRecordDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.StudentRecordDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StudentRecordDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StudentIDDataGridViewTextBoxColumn, Me.FullNameDataGridViewTextBoxColumn, Me.CAMarkDataGridViewTextBoxColumn, Me.ModuleGradeDataGridViewTextBoxColumn, Me.ModuleMarkDataGridViewTextBoxColumn, Me.RemarkDataGridViewTextBoxColumn})
        Me.StudentRecordDataGrid.DataSource = Me.StudentRecordBindingSource
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Snow
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.StudentRecordDataGrid.DefaultCellStyle = DataGridViewCellStyle5
        Me.StudentRecordDataGrid.Location = New System.Drawing.Point(1, 470)
        Me.StudentRecordDataGrid.Name = "StudentRecordDataGrid"
        Me.StudentRecordDataGrid.ReadOnly = True
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        Me.StudentRecordDataGrid.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.StudentRecordDataGrid.Size = New System.Drawing.Size(1089, 295)
        Me.StudentRecordDataGrid.TabIndex = 48
        '
        'StudentIDDataGridViewTextBoxColumn
        '
        Me.StudentIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.StudentIDDataGridViewTextBoxColumn.DataPropertyName = "StudentID"
        Me.StudentIDDataGridViewTextBoxColumn.HeaderText = "StudentID"
        Me.StudentIDDataGridViewTextBoxColumn.Name = "StudentIDDataGridViewTextBoxColumn"
        Me.StudentIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.StudentIDDataGridViewTextBoxColumn.Width = 108
        '
        'FullNameDataGridViewTextBoxColumn
        '
        Me.FullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName"
        Me.FullNameDataGridViewTextBoxColumn.HeaderText = "FullName"
        Me.FullNameDataGridViewTextBoxColumn.Name = "FullNameDataGridViewTextBoxColumn"
        Me.FullNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CAMarkDataGridViewTextBoxColumn
        '
        Me.CAMarkDataGridViewTextBoxColumn.DataPropertyName = "CA_Mark"
        Me.CAMarkDataGridViewTextBoxColumn.HeaderText = "CA_Mark"
        Me.CAMarkDataGridViewTextBoxColumn.Name = "CAMarkDataGridViewTextBoxColumn"
        Me.CAMarkDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ModuleGradeDataGridViewTextBoxColumn
        '
        Me.ModuleGradeDataGridViewTextBoxColumn.DataPropertyName = "Module_Grade"
        Me.ModuleGradeDataGridViewTextBoxColumn.HeaderText = "Module_Grade"
        Me.ModuleGradeDataGridViewTextBoxColumn.Name = "ModuleGradeDataGridViewTextBoxColumn"
        Me.ModuleGradeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ModuleMarkDataGridViewTextBoxColumn
        '
        Me.ModuleMarkDataGridViewTextBoxColumn.DataPropertyName = "Module_Mark"
        Me.ModuleMarkDataGridViewTextBoxColumn.HeaderText = "Module_Mark"
        Me.ModuleMarkDataGridViewTextBoxColumn.Name = "ModuleMarkDataGridViewTextBoxColumn"
        Me.ModuleMarkDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RemarkDataGridViewTextBoxColumn
        '
        Me.RemarkDataGridViewTextBoxColumn.DataPropertyName = "Remark"
        Me.RemarkDataGridViewTextBoxColumn.HeaderText = "Remark"
        Me.RemarkDataGridViewTextBoxColumn.Name = "RemarkDataGridViewTextBoxColumn"
        Me.RemarkDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StudentRecordBindingSource
        '
        Me.StudentRecordBindingSource.DataMember = "Student Record"
        Me.StudentRecordBindingSource.DataSource = Me.BindSutdent_Record_Data
        '
        'BindSutdent_Record_Data
        '
        Me.BindSutdent_Record_Data.DataSource = Me.StudentRecordDataSet
        Me.BindSutdent_Record_Data.Position = 0
        '
        'StudentRecordDataSet
        '
        Me.StudentRecordDataSet.DataSetName = "StudentRecordDataSet"
        Me.StudentRecordDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StudentRecordDataSetBindingSource
        '
        Me.StudentRecordDataSetBindingSource.DataSource = Me.StudentRecordDataSet
        Me.StudentRecordDataSetBindingSource.Position = 0
        '
        'Student_RecordTableAdapter
        '
        Me.Student_RecordTableAdapter.ClearBeforeFill = True
        '
        'frmCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1417, 763)
        Me.Controls.Add(Me.GrpModuleStatistic)
        Me.Controls.Add(Me.StudentRecordDataGrid)
        Me.Controls.Add(Me.GrpMarksGrade)
        Me.Controls.Add(Me.txtNameFinder)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.lstStudent_Record)
        Me.Controls.Add(Me.btnFind)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ForeColor = System.Drawing.Color.Snow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "frmCalculator"
        Me.Text = "Calculation of Module Grade"
        Me.GrpCA.ResumeLayout(False)
        Me.GrpCA.PerformLayout()
        Me.GrpMR.ResumeLayout(False)
        Me.GrpMR.PerformLayout()
        Me.GrpInputExam.ResumeLayout(False)
        Me.GrpInputExam.PerformLayout()
        Me.GrpMarksGrade.ResumeLayout(False)
        Me.GrpMarksGrade.PerformLayout()
        Me.GrpModuleStatistic.ResumeLayout(False)
        Me.GrpModuleStatistic.PerformLayout()
        CType(Me.StudentRecordDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentRecordBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindSutdent_Record_Data, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentRecordDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentRecordDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents blName As Label
    Friend WithEvents txtFullname As TextBox
    Friend WithEvents lblQuizzes As Label
    Friend WithEvents lblTest As Label
    Friend WithEvents lblProject As Label
    Friend WithEvents lblExam As Label
    Friend WithEvents txtQuizzes As TextBox
    Friend WithEvents txtTest As TextBox
    Friend WithEvents txtExam As TextBox
    Friend WithEvents txtProject As TextBox
    Friend WithEvents lblCAmark As Label
    Friend WithEvents lblModule_Grade As Label
    Friend WithEvents lblModule_Marks As Label
    Friend WithEvents lblRemarks As Label
    Friend WithEvents txtModule_Marks As TextBox
    Friend WithEvents txtRemarks As TextBox
    Friend WithEvents txtCAMark As TextBox
    Friend WithEvents txtModule_Grade As TextBox
    Friend WithEvents lstStudent_Record As ListBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnConfirm As Button
    Friend WithEvents txtCountToF As TextBox
    Friend WithEvents txtModule_Average As TextBox
    Friend WithEvents txtNoStudents As TextBox
    Friend WithEvents txtCountToA As TextBox
    Friend WithEvents lblModule_Average As Label
    Friend WithEvents lblCountF As Label
    Friend WithEvents lblCountA As Label
    Friend WithEvents lblNoStudents As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnShowStats As Button
    Friend WithEvents txtNameFinder As TextBox
    Friend WithEvents btnFind As Button
    Friend WithEvents GrpCA As GroupBox
    Friend WithEvents GrpMR As GroupBox
    Friend WithEvents GrpInputExam As GroupBox
    Friend WithEvents GrpMarksGrade As GroupBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents GrpModuleStatistic As GroupBox
    Friend WithEvents BarResultIndicator As ProgressBar
    Friend WithEvents BindSutdent_Record_Data As BindingSource
    Friend WithEvents StudentRecordDataSet As StudentRecordDataSet
    Friend WithEvents StudentRecordDataGrid As DataGridView
    Friend WithEvents StudentRecordDataSetBindingSource As BindingSource
    Friend WithEvents StudentRecordBindingSource As BindingSource
    Friend WithEvents Student_RecordTableAdapter As StudentRecordDataSetTableAdapters.Student_RecordTableAdapter
    Friend WithEvents StudentIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FullNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CAMarkDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ModuleGradeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ModuleMarkDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RemarkDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtSTUID As TextBox
    Friend WithEvents lblStdID As Label
End Class
