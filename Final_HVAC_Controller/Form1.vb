Option Strict On
Option Explicit On

'TODO
'1) Day?
'2)Serial port connect and file save - hw graph temp
'3)talk to qy@ board - hw qy@ board

Public Class HVACControllerForm

    Private Sub TempUpButton_Click(sender As Object, e As EventArgs) Handles TempUpButton.Click

    End Sub

    Private Sub TempDownButton_Click(sender As Object, e As EventArgs) Handles TempDownButton.Click

    End Sub

    Private Sub HVACControllerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub SelectSerialPortToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectSerialPortToolStripMenuItem.Click

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    'How show day???? by self????
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim timeTemp As String
        Dim dayTemp As Date

        timeTemp = TimeString
        TimeLabel.Text = DateTime.Now.ToShortTimeString
        'dayTemp = DateString
        'DayLabel.Text = dayTemp
        dayTemp = DateTime.Now
        Label15.Text = CStr(Now)
        Label16.Text = CStr(TimeOfDay)
        Label17.Text = timeTemp
        Label18.Text = DateTime.Now.ToLongDateString
        Label19.Text = DateString
        Label1.Text = DateTime.Now.ToString("hh:mm:ss:tt")
        Label2.Text = DateTime.Now.ToString("hh:mm:tt")
    End Sub
End Class
