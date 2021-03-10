'This form allows the program to be remotely shut down

Imports System.Windows.Forms

Public Class RemoteShutDown

    Private TargetDT As DateTime
    Private CountDownFrom As TimeSpan = TimeSpan.FromMinutes(3) 'countdown 3 min

    Private Sub tmrCountdown_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmrCountdown.Tick
        Dim ts As TimeSpan = TargetDT.Subtract(DateTime.Now)
        If ts.TotalMilliseconds > 0 Then
            lblTime.Text = String.Format("{0:00}:{1:00}", ts.Minutes, ts.Seconds)
        Else
            lblTime.Text = "00:00"
            tmrCountdown.Stop()
            BackUp()
            Main.Close()
        End If
    End Sub

    Private Sub RemoteShutDown_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tmrCountdown.Interval = 500
        TargetDT = DateTime.Now.Add(CountDownFrom)
        tmrCountdown.Start()
        Me.CenterToScreen()
        Me.TopMost = True
    End Sub
End Class
