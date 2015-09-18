Public Class Traffic
    'Dim trafficOff As Image = Image.FromFile("images\TrafficLight_OFF.bmp")
    'Dim trafficGreen As Image = Image.FromFile("images\TrafficLight_GREEN.bmp")
    'Dim trafficYellow As Image = Image.FromFile("images\TrafficLight_YELLOW.bmp")
    'Dim trafficRed As Image = Image.FromFile("images\TrafficLight_RED.bmp")
    Dim counter As Integer = 0
    Dim trafficOff As Image = Image.FromFile(Application.StartupPath & "\..\..\images\TrafficLight_OFF.bmp")
    Dim trafficGreen As Image = Image.FromFile(Application.StartupPath & "\..\..\images\TrafficLight_GREEN.bmp")
    Dim trafficYellow As Image = Image.FromFile(Application.StartupPath & "\..\..\images\TrafficLight_YELLOW.bmp")
    Dim trafficRed As Image = Image.FromFile(Application.StartupPath & "\..\..\images\TrafficLight_RED.bmp")
    Dim video1 As String = "Wildlife.wmv"
    Dim video2 As String = "Wildlife.wmv"
    Dim video3 As String = "Wildlife.wmv"
    Dim video4 As String = "Wildlife.wmv"

    Private Sub Traffic_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Traffic1.Image = trafficOff
        Traffic2.Image = trafficOff
        Traffic3.Image = trafficOff
        Traffic4.Image = trafficOff

        StopBtn.Enabled = False
        mediaPlayer1.URL = video1
        mediaPlayer1.Ctlcontrols.stop()
        mediaPlayer2.URL = video1
        mediaPlayer2.Ctlcontrols.stop()
        mediaPlayer3.URL = video1
        mediaPlayer3.Ctlcontrols.stop()
        mediaPlayer4.URL = video1
        mediaPlayer4.Ctlcontrols.stop()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        counter = counter + 1
        If (counter = 281) Then
            counter = 1 'reset counter
        End If

        Traffic1.Image = trafficRed
        Traffic2.Image = trafficRed
        Traffic3.Image = trafficRed
        Traffic4.Image = trafficRed

        Select Case counter
            Case 1 To 60  'state 1
                Traffic1.Image = trafficGreen
                'player 1 start
                mediaPlayer1.Ctlcontrols.play()
                mediaPlayer2.Ctlcontrols.stop()
                mediaPlayer3.Ctlcontrols.stop()
                mediaPlayer4.Ctlcontrols.stop()
            Case 61 To 70 'state2
                Traffic1.Image = trafficYellow
                'all stop
                mediaPlayer1.Ctlcontrols.stop()
                mediaPlayer2.Ctlcontrols.stop()
                mediaPlayer3.Ctlcontrols.stop()
                mediaPlayer4.Ctlcontrols.stop()
            Case 71 To 130 'state 3
                Traffic2.Image = trafficGreen
                mediaPlayer1.Ctlcontrols.stop()
                mediaPlayer2.Ctlcontrols.play()
                mediaPlayer3.Ctlcontrols.stop()
                mediaPlayer4.Ctlcontrols.stop()
            Case 131 To 140 'state 4
                Traffic2.Image = trafficYellow
                mediaPlayer1.Ctlcontrols.stop()
                mediaPlayer2.Ctlcontrols.stop()
                mediaPlayer3.Ctlcontrols.stop()
                mediaPlayer4.Ctlcontrols.stop()
            Case 141 To 200 'state 5
                Traffic3.Image = trafficGreen
                mediaPlayer1.Ctlcontrols.stop()
                mediaPlayer2.Ctlcontrols.stop()
                mediaPlayer3.Ctlcontrols.play()
                mediaPlayer4.Ctlcontrols.stop()
            Case 201 To 210 'state 6
                Traffic3.Image = trafficYellow
                mediaPlayer1.Ctlcontrols.stop()
                mediaPlayer2.Ctlcontrols.stop()
                mediaPlayer3.Ctlcontrols.stop()
                mediaPlayer4.Ctlcontrols.stop()
            Case 211 To 270 'state 7
                Traffic4.Image = trafficGreen
                mediaPlayer1.Ctlcontrols.stop()
                mediaPlayer2.Ctlcontrols.stop()
                mediaPlayer3.Ctlcontrols.stop()
                mediaPlayer4.Ctlcontrols.play()
            Case 271 To 280 'state 8
                Traffic4.Image = trafficYellow
                mediaPlayer1.Ctlcontrols.stop()
                mediaPlayer2.Ctlcontrols.stop()
                mediaPlayer3.Ctlcontrols.stop()
                mediaPlayer4.Ctlcontrols.stop()
        End Select
    End Sub

    Private Sub StartBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartBtn.Click
        Timer1.Enabled = True
        StartBtn.Enabled = False
        StopBtn.Enabled = True
    End Sub

    Private Sub StopBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StopBtn.Click
        Timer1.Enabled = False
        StopBtn.Enabled = False
        StartBtn.Enabled = True
    End Sub

    Private Sub ResetBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetBtn.Click
        counter = 0
        Traffic1.Image = trafficOff
        Traffic2.Image = trafficOff
        Traffic3.Image = trafficOff
        Traffic4.Image = trafficOff
    End Sub
End Class
