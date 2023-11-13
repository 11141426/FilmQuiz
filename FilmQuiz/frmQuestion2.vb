Public Class frmQuestion2
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblQuestion2.Click

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext2.Click
        If btnAnswer3.Checked Then
            playerScore = playerScore + 1
        End If
        frmQuestion3.Show()


        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class