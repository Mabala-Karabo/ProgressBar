Public Class Form1
    Private Sub txtStart_Click(sender As Object, e As EventArgs) Handles txtStart.Click
        Timer1.Start()
    End Sub

    Private Sub txtStop_Click(sender As Object, e As EventArgs) Handles txtStop.Click
        Timer1.Stop()
    End Sub

    Private Sub txtClear_Click(sender As Object, e As EventArgs) Handles txtClear.Click
        Timer1.Stop()
        txtProgressBar1.Value = 0
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txtProgressBar1.Increment(txtIncrement.Text)
        Timer1.Interval = (txtInterval.Text)
    End Sub
End Class
