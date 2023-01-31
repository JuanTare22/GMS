Public Class aIndex
    Private Sub aIndex_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim i As Integer = 30
        i += i
        ProgressBar1.Increment(i)
        If ProgressBar1.Value = ProgressBar1.Maximum Then

            Timer1.Stop()
            Me.Hide()
            'bDashboard.Show()
            bDashboard.Show()
        End If
    End Sub
End Class
