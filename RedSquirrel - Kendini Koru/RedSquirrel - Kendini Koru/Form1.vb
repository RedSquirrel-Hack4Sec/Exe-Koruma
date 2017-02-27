Public Class Form1
    Private Sub btnKorumaya_Al_Click(sender As Object, e As EventArgs) Handles btnKorumaya_Al.Click
        If btnKorumaya_Al.Text = "Korumaya Al" Then
            btnKorumaya_Al.Text = "Korumayı Kapat"
            btnKorumaya_Al.ForeColor = Color.Lime
            RedSquirrel.Apply()
        Else
            btnKorumaya_Al.Text = "Korumaya Al"
            btnKorumaya_Al.ForeColor = Color.Red
            RedSquirrel.Disable()
        End If
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.TaskManagerClosing Then
            e.Cancel = True
            MsgBox("Erişim engelli.")
        End If
    End Sub
End Class
