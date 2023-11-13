Public Class frmQuestion3
    Private Sub frmQuestion3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter



    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If btnAnswer1.Checked Then
            playerScore += 1
        End If
        frmHighScore.Show()
        frmHighScore.doScore()
    End Sub
End Class