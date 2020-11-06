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
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtFullname = New System.Windows.Forms.TextBox()
        Me.lblHeader1 = New System.Windows.Forms.Label()
        Me.lblHeader2 = New System.Windows.Forms.Label()
        Me.lblSubHeader1 = New System.Windows.Forms.Label()
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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.lblSubHeader2 = New System.Windows.Forms.Label()
        Me.lblHeader3 = New System.Windows.Forms.Label()
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
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.ForeColor = System.Drawing.Color.Snow
        Me.lblName.Location = New System.Drawing.Point(28, 80)
        Me.lblName.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(59, 20)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Name :"
        '
        'txtFullname
        '
        Me.txtFullname.BackColor = System.Drawing.Color.RosyBrown
        Me.txtFullname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFullname.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtFullname.Location = New System.Drawing.Point(84, 80)
        Me.txtFullname.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtFullname.Name = "txtFullname"
        Me.txtFullname.Size = New System.Drawing.Size(261, 16)
        Me.txtFullname.TabIndex = 2
        '
        'lblHeader1
        '
        Me.lblHeader1.AutoSize = True
        Me.lblHeader1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.lblHeader1.ForeColor = System.Drawing.Color.Snow
        Me.lblHeader1.Location = New System.Drawing.Point(27, 31)
        Me.lblHeader1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblHeader1.Name = "lblHeader1"
        Me.lblHeader1.Size = New System.Drawing.Size(434, 29)
        Me.lblHeader1.TabIndex = 3
        Me.lblHeader1.Text = "Marks and Grades For Indiviual Student"
        '
        'lblHeader2
        '
        Me.lblHeader2.AutoSize = True
        Me.lblHeader2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.lblHeader2.Location = New System.Drawing.Point(27, 111)
        Me.lblHeader2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblHeader2.Name = "lblHeader2"
        Me.lblHeader2.Size = New System.Drawing.Size(274, 29)
        Me.lblHeader2.TabIndex = 4
        Me.lblHeader2.Text = "Input CA and Exam Mark"
        '
        'lblSubHeader1
        '
        Me.lblSubHeader1.AutoSize = True
        Me.lblSubHeader1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.lblSubHeader1.Location = New System.Drawing.Point(23, 165)
        Me.lblSubHeader1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSubHeader1.Name = "lblSubHeader1"
        Me.lblSubHeader1.Size = New System.Drawing.Size(147, 22)
        Me.lblSubHeader1.TabIndex = 5
        Me.lblSubHeader1.Text = "CA Componenet:"
        '
        'lblQuizzes
        '
        Me.lblQuizzes.AutoSize = True
        Me.lblQuizzes.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.lblQuizzes.Location = New System.Drawing.Point(23, 247)
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
        Me.lblTest.Location = New System.Drawing.Point(23, 216)
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
        Me.lblProject.Location = New System.Drawing.Point(23, 279)
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
        Me.lblExam.Location = New System.Drawing.Point(23, 311)
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
        Me.txtQuizzes.Location = New System.Drawing.Point(150, 247)
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
        Me.txtTest.Location = New System.Drawing.Point(150, 216)
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
        Me.txtExam.Location = New System.Drawing.Point(150, 311)
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
        Me.txtProject.Location = New System.Drawing.Point(150, 279)
        Me.txtProject.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtProject.Name = "txtProject"
        Me.txtProject.Size = New System.Drawing.Size(96, 16)
        Me.txtProject.TabIndex = 13
        '
        'lblCAmark
        '
        Me.lblCAmark.AutoSize = True
        Me.lblCAmark.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.lblCAmark.Location = New System.Drawing.Point(290, 211)
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
        Me.lblModule_Grade.Location = New System.Drawing.Point(290, 242)
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
        Me.lblModule_Marks.Location = New System.Drawing.Point(290, 274)
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
        Me.lblRemarks.Location = New System.Drawing.Point(290, 306)
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
        Me.txtModule_Marks.Location = New System.Drawing.Point(443, 279)
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
        Me.txtRemarks.Location = New System.Drawing.Point(443, 310)
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
        Me.txtCAMark.Location = New System.Drawing.Point(443, 215)
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
        Me.txtModule_Grade.Location = New System.Drawing.Point(443, 247)
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
        Me.lstStudent_Record.Location = New System.Drawing.Point(1085, -2)
        Me.lstStudent_Record.Name = "lstStudent_Record"
        Me.lstStudent_Record.Size = New System.Drawing.Size(307, 680)
        Me.lstStudent_Record.TabIndex = 22
        '
        'btnExit
        '
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(787, 692)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(299, 45)
        Me.btnExit.TabIndex = 23
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(177, 396)
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
        Me.btnConfirm.Location = New System.Drawing.Point(177, 359)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(204, 31)
        Me.btnConfirm.TabIndex = 25
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'lblSubHeader2
        '
        Me.lblSubHeader2.AutoSize = True
        Me.lblSubHeader2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.lblSubHeader2.Location = New System.Drawing.Point(290, 165)
        Me.lblSubHeader2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSubHeader2.Name = "lblSubHeader2"
        Me.lblSubHeader2.Size = New System.Drawing.Size(129, 22)
        Me.lblSubHeader2.TabIndex = 26
        Me.lblSubHeader2.Text = "Module Result:"
        '
        'lblHeader3
        '
        Me.lblHeader3.AutoSize = True
        Me.lblHeader3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.lblHeader3.Location = New System.Drawing.Point(599, 31)
        Me.lblHeader3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblHeader3.Name = "lblHeader3"
        Me.lblHeader3.Size = New System.Drawing.Size(183, 29)
        Me.lblHeader3.TabIndex = 28
        Me.lblHeader3.Text = "Module Statistic"
        '
        'txtCountToF
        '
        Me.txtCountToF.BackColor = System.Drawing.Color.RosyBrown
        Me.txtCountToF.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCountToF.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtCountToF.Location = New System.Drawing.Point(859, 250)
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
        Me.txtModule_Average.Location = New System.Drawing.Point(859, 301)
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
        Me.txtNoStudents.Location = New System.Drawing.Point(859, 143)
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
        Me.txtCountToA.Location = New System.Drawing.Point(859, 199)
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
        Me.lblModule_Average.Location = New System.Drawing.Point(598, 301)
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
        Me.lblCountF.Location = New System.Drawing.Point(599, 253)
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
        Me.lblCountA.Location = New System.Drawing.Point(599, 199)
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
        Me.lblNoStudents.Location = New System.Drawing.Point(599, 143)
        Me.lblNoStudents.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNoStudents.Name = "lblNoStudents"
        Me.lblNoStudents.Size = New System.Drawing.Size(190, 25)
        Me.lblNoStudents.TabIndex = 29
        Me.lblNoStudents.Text = "Number Of Students"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Location = New System.Drawing.Point(562, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(32, 437)
        Me.Panel1.TabIndex = 37
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gray
        Me.Panel2.Location = New System.Drawing.Point(0, 432)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1086, 18)
        Me.Panel2.TabIndex = 38
        '
        'btnShowStats
        '
        Me.btnShowStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShowStats.ForeColor = System.Drawing.Color.White
        Me.btnShowStats.Location = New System.Drawing.Point(704, 396)
        Me.btnShowStats.Name = "btnShowStats"
        Me.btnShowStats.Size = New System.Drawing.Size(261, 30)
        Me.btnShowStats.TabIndex = 39
        Me.btnShowStats.Text = "Show Statistic"
        Me.btnShowStats.UseVisualStyleBackColor = True
        '
        'txtNameFinder
        '
        Me.txtNameFinder.BackColor = System.Drawing.Color.LightCoral
        Me.txtNameFinder.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNameFinder.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtNameFinder.Location = New System.Drawing.Point(1085, 655)
        Me.txtNameFinder.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtNameFinder.Name = "txtNameFinder"
        Me.txtNameFinder.Size = New System.Drawing.Size(307, 23)
        Me.txtNameFinder.TabIndex = 40
        '
        'btnFind
        '
        Me.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFind.ForeColor = System.Drawing.Color.White
        Me.btnFind.Location = New System.Drawing.Point(1085, 678)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(307, 59)
        Me.btnFind.TabIndex = 41
        Me.btnFind.Text = "Find"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'frmCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1392, 737)
        Me.Controls.Add(Me.btnFind)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.txtNameFinder)
        Me.Controls.Add(Me.btnShowStats)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtCountToF)
        Me.Controls.Add(Me.txtModule_Average)
        Me.Controls.Add(Me.txtNoStudents)
        Me.Controls.Add(Me.txtCountToA)
        Me.Controls.Add(Me.lblModule_Average)
        Me.Controls.Add(Me.lblCountF)
        Me.Controls.Add(Me.lblCountA)
        Me.Controls.Add(Me.lblNoStudents)
        Me.Controls.Add(Me.lblHeader3)
        Me.Controls.Add(Me.lblSubHeader2)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lstStudent_Record)
        Me.Controls.Add(Me.txtModule_Marks)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.txtCAMark)
        Me.Controls.Add(Me.txtModule_Grade)
        Me.Controls.Add(Me.lblRemarks)
        Me.Controls.Add(Me.lblModule_Marks)
        Me.Controls.Add(Me.lblModule_Grade)
        Me.Controls.Add(Me.lblCAmark)
        Me.Controls.Add(Me.txtProject)
        Me.Controls.Add(Me.txtExam)
        Me.Controls.Add(Me.txtTest)
        Me.Controls.Add(Me.txtQuizzes)
        Me.Controls.Add(Me.lblExam)
        Me.Controls.Add(Me.lblProject)
        Me.Controls.Add(Me.lblTest)
        Me.Controls.Add(Me.lblQuizzes)
        Me.Controls.Add(Me.lblSubHeader1)
        Me.Controls.Add(Me.lblHeader2)
        Me.Controls.Add(Me.lblHeader1)
        Me.Controls.Add(Me.txtFullname)
        Me.Controls.Add(Me.lblName)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ForeColor = System.Drawing.Color.Snow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "frmCalculator"
        Me.Text = "Calculation of Module Grade"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents txtFullname As TextBox
    Friend WithEvents lblHeader1 As Label
    Friend WithEvents lblHeader2 As Label
    Friend WithEvents lblSubHeader1 As Label
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
    Friend WithEvents btnExit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnConfirm As Button
    Friend WithEvents lblSubHeader2 As Label
    Friend WithEvents lblHeader3 As Label
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
End Class
