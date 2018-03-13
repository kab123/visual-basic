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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnScissors1 = New System.Windows.Forms.Button()
        Me.btnPaper1 = New System.Windows.Forms.Button()
        Me.btnRock1 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnScissors2 = New System.Windows.Forms.Button()
        Me.btnPaper2 = New System.Windows.Forms.Button()
        Me.btnRock2 = New System.Windows.Forms.Button()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.lblWinner = New System.Windows.Forms.Label()
        Me.btnNewGame = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnWhoWon = New System.Windows.Forms.Button()
        Me.btnRandomPlayer1 = New System.Windows.Forms.Button()
        Me.btnRandomPlayer2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LawnGreen
        Me.GroupBox1.Controls.Add(Me.btnScissors1)
        Me.GroupBox1.Controls.Add(Me.btnPaper1)
        Me.GroupBox1.Controls.Add(Me.btnRock1)
        Me.GroupBox1.Location = New System.Drawing.Point(37, 200)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(659, 293)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "player 1"
        '
        'btnScissors1
        '
        Me.btnScissors1.BackgroundImage = CType(resources.GetObject("btnScissors1.BackgroundImage"), System.Drawing.Image)
        Me.btnScissors1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnScissors1.Location = New System.Drawing.Point(436, 97)
        Me.btnScissors1.Name = "btnScissors1"
        Me.btnScissors1.Size = New System.Drawing.Size(170, 128)
        Me.btnScissors1.TabIndex = 2
        Me.btnScissors1.UseVisualStyleBackColor = True
        '
        'btnPaper1
        '
        Me.btnPaper1.BackgroundImage = CType(resources.GetObject("btnPaper1.BackgroundImage"), System.Drawing.Image)
        Me.btnPaper1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPaper1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPaper1.Location = New System.Drawing.Point(232, 97)
        Me.btnPaper1.Name = "btnPaper1"
        Me.btnPaper1.Size = New System.Drawing.Size(170, 128)
        Me.btnPaper1.TabIndex = 1
        Me.btnPaper1.UseVisualStyleBackColor = True
        '
        'btnRock1
        '
        Me.btnRock1.BackgroundImage = CType(resources.GetObject("btnRock1.BackgroundImage"), System.Drawing.Image)
        Me.btnRock1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRock1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRock1.Location = New System.Drawing.Point(34, 97)
        Me.btnRock1.Name = "btnRock1"
        Me.btnRock1.Size = New System.Drawing.Size(170, 128)
        Me.btnRock1.TabIndex = 0
        Me.btnRock1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.LawnGreen
        Me.GroupBox2.Controls.Add(Me.btnScissors2)
        Me.GroupBox2.Controls.Add(Me.btnPaper2)
        Me.GroupBox2.Controls.Add(Me.btnRock2)
        Me.GroupBox2.Location = New System.Drawing.Point(757, 200)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(659, 293)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "player 2"
        '
        'btnScissors2
        '
        Me.btnScissors2.BackgroundImage = CType(resources.GetObject("btnScissors2.BackgroundImage"), System.Drawing.Image)
        Me.btnScissors2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnScissors2.Location = New System.Drawing.Point(31, 97)
        Me.btnScissors2.Name = "btnScissors2"
        Me.btnScissors2.Size = New System.Drawing.Size(170, 128)
        Me.btnScissors2.TabIndex = 5
        Me.btnScissors2.UseVisualStyleBackColor = True
        '
        'btnPaper2
        '
        Me.btnPaper2.BackgroundImage = CType(resources.GetObject("btnPaper2.BackgroundImage"), System.Drawing.Image)
        Me.btnPaper2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPaper2.Location = New System.Drawing.Point(227, 97)
        Me.btnPaper2.Name = "btnPaper2"
        Me.btnPaper2.Size = New System.Drawing.Size(170, 128)
        Me.btnPaper2.TabIndex = 4
        Me.btnPaper2.UseVisualStyleBackColor = True
        '
        'btnRock2
        '
        Me.btnRock2.BackgroundImage = CType(resources.GetObject("btnRock2.BackgroundImage"), System.Drawing.Image)
        Me.btnRock2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRock2.Location = New System.Drawing.Point(432, 97)
        Me.btnRock2.Name = "btnRock2"
        Me.btnRock2.Size = New System.Drawing.Size(170, 128)
        Me.btnRock2.TabIndex = 3
        Me.btnRock2.UseVisualStyleBackColor = True
        '
        'lbltitle
        '
        Me.lbltitle.AutoSize = True
        Me.lbltitle.BackColor = System.Drawing.Color.LawnGreen
        Me.lbltitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitle.Location = New System.Drawing.Point(116, 76)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(1237, 55)
        Me.lbltitle.TabIndex = 3
        Me.lbltitle.Text = "ROCK PAPER SCISSORS SHOWDOWN EXTREME!!!"
        '
        'lblWinner
        '
        Me.lblWinner.AutoSize = True
        Me.lblWinner.BackColor = System.Drawing.Color.Snow
        Me.lblWinner.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWinner.ForeColor = System.Drawing.Color.DeepPink
        Me.lblWinner.Location = New System.Drawing.Point(425, 594)
        Me.lblWinner.MinimumSize = New System.Drawing.Size(700, 100)
        Me.lblWinner.Name = "lblWinner"
        Me.lblWinner.Size = New System.Drawing.Size(700, 100)
        Me.lblWinner.TabIndex = 4
        Me.lblWinner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnNewGame
        '
        Me.btnNewGame.Location = New System.Drawing.Point(506, 728)
        Me.btnNewGame.Name = "btnNewGame"
        Me.btnNewGame.Size = New System.Drawing.Size(190, 62)
        Me.btnNewGame.TabIndex = 5
        Me.btnNewGame.Text = "New Game"
        Me.btnNewGame.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(757, 728)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(190, 62)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnWhoWon
        '
        Me.btnWhoWon.Location = New System.Drawing.Point(182, 594)
        Me.btnWhoWon.Name = "btnWhoWon"
        Me.btnWhoWon.Size = New System.Drawing.Size(197, 100)
        Me.btnWhoWon.TabIndex = 7
        Me.btnWhoWon.Text = "Who Won?"
        Me.btnWhoWon.UseVisualStyleBackColor = True
        '
        'btnRandomPlayer1
        '
        Me.btnRandomPlayer1.Location = New System.Drawing.Point(269, 508)
        Me.btnRandomPlayer1.Name = "btnRandomPlayer1"
        Me.btnRandomPlayer1.Size = New System.Drawing.Size(197, 55)
        Me.btnRandomPlayer1.TabIndex = 8
        Me.btnRandomPlayer1.Text = "pick for me!"
        Me.btnRandomPlayer1.UseVisualStyleBackColor = True
        '
        'btnRandomPlayer2
        '
        Me.btnRandomPlayer2.Location = New System.Drawing.Point(957, 508)
        Me.btnRandomPlayer2.Name = "btnRandomPlayer2"
        Me.btnRandomPlayer2.Size = New System.Drawing.Size(197, 55)
        Me.btnRandomPlayer2.TabIndex = 9
        Me.btnRandomPlayer2.Text = "pick for me!"
        Me.btnRandomPlayer2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkRed
        Me.ClientSize = New System.Drawing.Size(1494, 840)
        Me.Controls.Add(Me.btnRandomPlayer2)
        Me.Controls.Add(Me.btnRandomPlayer1)
        Me.Controls.Add(Me.btnWhoWon)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnNewGame)
        Me.Controls.Add(Me.lblWinner)
        Me.Controls.Add(Me.lbltitle)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnScissors1 As Button
    Friend WithEvents btnPaper1 As Button
    Friend WithEvents btnRock1 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnScissors2 As Button
    Friend WithEvents btnPaper2 As Button
    Friend WithEvents btnRock2 As Button
    Friend WithEvents lbltitle As Label
    Friend WithEvents lblWinner As Label
    Friend WithEvents btnNewGame As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnWhoWon As Button
    Friend WithEvents btnRandomPlayer1 As Button
    Friend WithEvents btnRandomPlayer2 As Button
End Class
