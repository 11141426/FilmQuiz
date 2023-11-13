Public Class frmQuestion1
    Public Sub initi()
        progressCount = 0
        tmrQuestion1.Enabled = True
        ProgressBarQ1.Value = 0
        btnAnswer1.Checked = False
        btnAnswer2.Checked = False
        btnAnswer3.Checked = False


    End Sub
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        tmrQuestion1.Enabled = False
        If btnAnswer2.Checked Then
            playerScore += 1
        End If
        frmQuestion2.Show()

        Me.Hide()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub ProgressBarQ_Click(sender As Object, e As EventArgs) Handles ProgressBarQ1.Click

    End Sub
End Class