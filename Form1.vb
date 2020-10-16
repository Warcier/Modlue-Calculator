Public Class frmCalculator
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

    End Sub

    Private Sub btnShowStats_Click(sender As Object, e As EventArgs) Handles btnShowStats.Click

    End Sub
    '///////////////////////////////////
End Class
