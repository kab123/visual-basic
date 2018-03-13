<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.GroupBox = New System.Windows.Forms.GroupBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btncompute = New System.Windows.Forms.Button()
        Me.lblnettosellers = New System.Windows.Forms.Label()
        Me.lblcommison = New System.Windows.Forms.Label()
        Me.lblgrosssales = New System.Windows.Forms.Label()
        Me.lblitemssold = New System.Windows.Forms.Label()
        Me.VideoTxt = New System.Windows.Forms.TextBox()
        Me.musicTxt = New System.Windows.Forms.TextBox()
        Me.videos = New System.Windows.Forms.Label()
        Me.music = New System.Windows.Forms.Label()
        Me.GroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbltitle
        '
        Me.lbltitle.AutoSize = True
        Me.lbltitle.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lbltitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitle.Location = New System.Drawing.Point(187, 37)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(379, 51)
        Me.lbltitle.TabIndex = 0
        Me.lbltitle.Text = "yu hu online store"
        '
        'GroupBox
        '
        Me.GroupBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox.Controls.Add(Me.btnExit)
        Me.GroupBox.Controls.Add(Me.btnClear)
        Me.GroupBox.Controls.Add(Me.btncompute)
        Me.GroupBox.Controls.Add(Me.lblnettosellers)
        Me.GroupBox.Controls.Add(Me.lblcommison)
        Me.GroupBox.Controls.Add(Me.lblgrosssales)
        Me.GroupBox.Controls.Add(Me.lblitemssold)
        Me.GroupBox.Controls.Add(Me.VideoTxt)
        Me.GroupBox.Controls.Add(Me.musicTxt)
        Me.GroupBox.Controls.Add(Me.videos)
        Me.GroupBox.Controls.Add(Me.music)
        Me.GroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox.Location = New System.Drawing.Point(35, 132)
        Me.GroupBox.Name = "GroupBox"
        Me.GroupBox.Size = New System.Drawing.Size(677, 577)
        Me.GroupBox.TabIndex = 1
        Me.GroupBox.TabStop = False
        Me.GroupBox.Text = "Music && Video sales"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(445, 436)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(160, 54)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(245, 436)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(160, 54)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btncompute
        '
        Me.btncompute.Location = New System.Drawing.Point(51, 436)
        Me.btncompute.Name = "btncompute"
        Me.btncompute.Size = New System.Drawing.Size(160, 54)
        Me.btncompute.TabIndex = 8
        Me.btncompute.Text = "Compute"
        Me.btncompute.UseVisualStyleBackColor = True
        '
        'lblnettosellers
        '
        Me.lblnettosellers.AutoSize = True
        Me.lblnettosellers.Location = New System.Drawing.Point(44, 340)
        Me.lblnettosellers.Name = "lblnettosellers"
        Me.lblnettosellers.Size = New System.Drawing.Size(219, 37)
        Me.lblnettosellers.TabIndex = 7
        Me.lblnettosellers.Text = "Net To Sellers"
        '
        'lblcommison
        '
        Me.lblcommison.AutoSize = True
        Me.lblcommison.Location = New System.Drawing.Point(44, 281)
        Me.lblcommison.Name = "lblcommison"
        Me.lblcommison.Size = New System.Drawing.Size(167, 37)
        Me.lblcommison.TabIndex = 6
        Me.lblcommison.Text = "Comission"
        '
        'lblgrosssales
        '
        Me.lblgrosssales.AutoSize = True
        Me.lblgrosssales.Location = New System.Drawing.Point(44, 226)
        Me.lblgrosssales.Name = "lblgrosssales"
        Me.lblgrosssales.Size = New System.Drawing.Size(191, 37)
        Me.lblgrosssales.TabIndex = 5
        Me.lblgrosssales.Text = "Gross Sales"
        '
        'lblitemssold
        '
        Me.lblitemssold.AutoSize = True
        Me.lblitemssold.Location = New System.Drawing.Point(44, 171)
        Me.lblitemssold.Name = "lblitemssold"
        Me.lblitemssold.Size = New System.Drawing.Size(167, 37)
        Me.lblitemssold.TabIndex = 4
        Me.lblitemssold.Text = "Items Sold"
        '
        'VideoTxt
        '
        Me.VideoTxt.Location = New System.Drawing.Point(460, 90)
        Me.VideoTxt.Name = "VideoTxt"
        Me.VideoTxt.Size = New System.Drawing.Size(145, 44)
        Me.VideoTxt.TabIndex = 3
        '
        'musicTxt
        '
        Me.musicTxt.Location = New System.Drawing.Point(143, 90)
        Me.musicTxt.Name = "musicTxt"
        Me.musicTxt.Size = New System.Drawing.Size(145, 44)
        Me.musicTxt.TabIndex = 2
        '
        'videos
        '
        Me.videos.AutoSize = True
        Me.videos.Location = New System.Drawing.Point(339, 90)
        Me.videos.Name = "videos"
        Me.videos.Size = New System.Drawing.Size(115, 37)
        Me.videos.TabIndex = 1
        Me.videos.Text = "Videos"
        '
        'music
        '
        Me.music.AutoSize = True
        Me.music.Location = New System.Drawing.Point(37, 90)
        Me.music.Name = "music"
        Me.music.Size = New System.Drawing.Size(100, 37)
        Me.music.TabIndex = 0
        Me.music.Text = "Music"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(760, 784)
        Me.Controls.Add(Me.GroupBox)
        Me.Controls.Add(Me.lbltitle)
        Me.Name = "Form1"
        Me.Text = "Music and Videos"
        Me.GroupBox.ResumeLayout(False)
        Me.GroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbltitle As Label
    Friend WithEvents GroupBox As GroupBox
    Friend WithEvents lblnettosellers As Label
    Friend WithEvents lblcommison As Label
    Friend WithEvents lblgrosssales As Label
    Friend WithEvents lblitemssold As Label
    Friend WithEvents VideoTxt As TextBox
    Friend WithEvents musicTxt As TextBox
    Friend WithEvents videos As Label
    Friend WithEvents music As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btncompute As Button
End Class
