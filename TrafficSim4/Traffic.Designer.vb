<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Traffic
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Traffic))
        Me.Traffic1 = New System.Windows.Forms.PictureBox()
        Me.Traffic4 = New System.Windows.Forms.PictureBox()
        Me.Traffic2 = New System.Windows.Forms.PictureBox()
        Me.Traffic3 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.StartBtn = New System.Windows.Forms.Button()
        Me.StopBtn = New System.Windows.Forms.Button()
        Me.ResetBtn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.mediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.mediaPlayer2 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.mediaPlayer3 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.mediaPlayer4 = New AxWMPLib.AxWindowsMediaPlayer()
        CType(Me.Traffic1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Traffic4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Traffic2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Traffic3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mediaPlayer2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mediaPlayer3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mediaPlayer4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Traffic1
        '
        Me.Traffic1.Location = New System.Drawing.Point(159, 190)
        Me.Traffic1.Name = "Traffic1"
        Me.Traffic1.Size = New System.Drawing.Size(88, 147)
        Me.Traffic1.TabIndex = 0
        Me.Traffic1.TabStop = False
        '
        'Traffic4
        '
        Me.Traffic4.Location = New System.Drawing.Point(445, 374)
        Me.Traffic4.Name = "Traffic4"
        Me.Traffic4.Size = New System.Drawing.Size(88, 147)
        Me.Traffic4.TabIndex = 1
        Me.Traffic4.TabStop = False
        '
        'Traffic2
        '
        Me.Traffic2.Location = New System.Drawing.Point(445, 28)
        Me.Traffic2.Name = "Traffic2"
        Me.Traffic2.Size = New System.Drawing.Size(88, 147)
        Me.Traffic2.TabIndex = 2
        Me.Traffic2.TabStop = False
        '
        'Traffic3
        '
        Me.Traffic3.Location = New System.Drawing.Point(729, 190)
        Me.Traffic3.Name = "Traffic3"
        Me.Traffic3.Size = New System.Drawing.Size(88, 147)
        Me.Traffic3.TabIndex = 3
        Me.Traffic3.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'StartBtn
        '
        Me.StartBtn.Location = New System.Drawing.Point(29, 28)
        Me.StartBtn.Name = "StartBtn"
        Me.StartBtn.Size = New System.Drawing.Size(75, 23)
        Me.StartBtn.TabIndex = 4
        Me.StartBtn.Text = "Start"
        Me.StartBtn.UseVisualStyleBackColor = True
        '
        'StopBtn
        '
        Me.StopBtn.Location = New System.Drawing.Point(29, 58)
        Me.StopBtn.Name = "StopBtn"
        Me.StopBtn.Size = New System.Drawing.Size(75, 23)
        Me.StopBtn.TabIndex = 5
        Me.StopBtn.Text = "Stop"
        Me.StopBtn.UseVisualStyleBackColor = True
        '
        'ResetBtn
        '
        Me.ResetBtn.Location = New System.Drawing.Point(29, 88)
        Me.ResetBtn.Name = "ResetBtn"
        Me.ResetBtn.Size = New System.Drawing.Size(75, 23)
        Me.ResetBtn.TabIndex = 6
        Me.ResetBtn.Text = "Reset"
        Me.ResetBtn.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(-23, -45)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'mediaPlayer1
        '
        Me.mediaPlayer1.Enabled = True
        Me.mediaPlayer1.Location = New System.Drawing.Point(29, 374)
        Me.mediaPlayer1.Name = "mediaPlayer1"
        Me.mediaPlayer1.OcxState = CType(resources.GetObject("mediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.mediaPlayer1.Size = New System.Drawing.Size(189, 182)
        Me.mediaPlayer1.TabIndex = 9
        '
        'mediaPlayer2
        '
        Me.mediaPlayer2.Enabled = True
        Me.mediaPlayer2.Location = New System.Drawing.Point(235, 374)
        Me.mediaPlayer2.Name = "mediaPlayer2"
        Me.mediaPlayer2.OcxState = CType(resources.GetObject("mediaPlayer2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.mediaPlayer2.Size = New System.Drawing.Size(189, 182)
        Me.mediaPlayer2.TabIndex = 10
        '
        'mediaPlayer3
        '
        Me.mediaPlayer3.Enabled = True
        Me.mediaPlayer3.Location = New System.Drawing.Point(575, 374)
        Me.mediaPlayer3.Name = "mediaPlayer3"
        Me.mediaPlayer3.OcxState = CType(resources.GetObject("mediaPlayer3.OcxState"), System.Windows.Forms.AxHost.State)
        Me.mediaPlayer3.Size = New System.Drawing.Size(189, 182)
        Me.mediaPlayer3.TabIndex = 11
        '
        'mediaPlayer4
        '
        Me.mediaPlayer4.Enabled = True
        Me.mediaPlayer4.Location = New System.Drawing.Point(778, 374)
        Me.mediaPlayer4.Name = "mediaPlayer4"
        Me.mediaPlayer4.OcxState = CType(resources.GetObject("mediaPlayer4.OcxState"), System.Windows.Forms.AxHost.State)
        Me.mediaPlayer4.Size = New System.Drawing.Size(189, 182)
        Me.mediaPlayer4.TabIndex = 12
        '
        'Traffic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(979, 582)
        Me.Controls.Add(Me.mediaPlayer4)
        Me.Controls.Add(Me.mediaPlayer3)
        Me.Controls.Add(Me.mediaPlayer2)
        Me.Controls.Add(Me.mediaPlayer1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ResetBtn)
        Me.Controls.Add(Me.StopBtn)
        Me.Controls.Add(Me.StartBtn)
        Me.Controls.Add(Me.Traffic3)
        Me.Controls.Add(Me.Traffic2)
        Me.Controls.Add(Me.Traffic4)
        Me.Controls.Add(Me.Traffic1)
        Me.Name = "Traffic"
        Me.Text = "Form1"
        CType(Me.Traffic1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Traffic4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Traffic2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Traffic3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mediaPlayer2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mediaPlayer3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mediaPlayer4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Traffic1 As System.Windows.Forms.PictureBox
    Friend WithEvents Traffic4 As System.Windows.Forms.PictureBox
    Friend WithEvents Traffic2 As System.Windows.Forms.PictureBox
    Friend WithEvents Traffic3 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents StartBtn As System.Windows.Forms.Button
    Friend WithEvents StopBtn As System.Windows.Forms.Button
    Friend WithEvents ResetBtn As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents mediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents mediaPlayer2 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents mediaPlayer3 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents mediaPlayer4 As AxWMPLib.AxWindowsMediaPlayer

End Class
