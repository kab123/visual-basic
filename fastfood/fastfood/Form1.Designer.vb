<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFastFood
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFastFood))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboxBacon = New System.Windows.Forms.CheckBox()
        Me.cboxCheese = New System.Windows.Forms.CheckBox()
        Me.rbChickenSandwich = New System.Windows.Forms.RadioButton()
        Me.rbSteakSandwich = New System.Windows.Forms.RadioButton()
        Me.rbBurger = New System.Windows.Forms.RadioButton()
        Me.rbNone = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cboxRings = New System.Windows.Forms.CheckBox()
        Me.cboxFries = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rbDrinksNone = New System.Windows.Forms.RadioButton()
        Me.rbBeer = New System.Windows.Forms.RadioButton()
        Me.rbOrangeSoda = New System.Windows.Forms.RadioButton()
        Me.rbCoke = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lsOrderRecipt = New System.Windows.Forms.ListBox()
        Me.lsTotal = New System.Windows.Forms.ListBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Red
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.cboxBacon)
        Me.GroupBox1.Controls.Add(Me.cboxCheese)
        Me.GroupBox1.Controls.Add(Me.rbChickenSandwich)
        Me.GroupBox1.Controls.Add(Me.rbSteakSandwich)
        Me.GroupBox1.Controls.Add(Me.rbBurger)
        Me.GroupBox1.Controls.Add(Me.rbNone)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(41, 97)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(472, 407)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Manwich"
        '
        'cboxBacon
        '
        Me.cboxBacon.AutoSize = True
        Me.cboxBacon.Location = New System.Drawing.Point(19, 339)
        Me.cboxBacon.Name = "cboxBacon"
        Me.cboxBacon.Size = New System.Drawing.Size(201, 41)
        Me.cboxBacon.TabIndex = 5
        Me.cboxBacon.Text = "Bacon 20c"
        Me.cboxBacon.UseVisualStyleBackColor = True
        '
        'cboxCheese
        '
        Me.cboxCheese.AutoSize = True
        Me.cboxCheese.Location = New System.Drawing.Point(19, 292)
        Me.cboxCheese.Name = "cboxCheese"
        Me.cboxCheese.Size = New System.Drawing.Size(216, 41)
        Me.cboxCheese.TabIndex = 4
        Me.cboxCheese.Text = "Cheese 10c"
        Me.cboxCheese.UseVisualStyleBackColor = True
        '
        'rbChickenSandwich
        '
        Me.rbChickenSandwich.AutoSize = True
        Me.rbChickenSandwich.BackColor = System.Drawing.Color.Transparent
        Me.rbChickenSandwich.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbChickenSandwich.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rbChickenSandwich.Location = New System.Drawing.Point(17, 195)
        Me.rbChickenSandwich.Name = "rbChickenSandwich"
        Me.rbChickenSandwich.Size = New System.Drawing.Size(410, 41)
        Me.rbChickenSandwich.TabIndex = 3
        Me.rbChickenSandwich.TabStop = True
        Me.rbChickenSandwich.Text = "Chicken Sandwich $2.49 "
        Me.rbChickenSandwich.UseVisualStyleBackColor = False
        '
        'rbSteakSandwich
        '
        Me.rbSteakSandwich.AutoSize = True
        Me.rbSteakSandwich.BackColor = System.Drawing.Color.Transparent
        Me.rbSteakSandwich.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbSteakSandwich.Location = New System.Drawing.Point(19, 148)
        Me.rbSteakSandwich.Name = "rbSteakSandwich"
        Me.rbSteakSandwich.Size = New System.Drawing.Size(415, 41)
        Me.rbSteakSandwich.TabIndex = 2
        Me.rbSteakSandwich.TabStop = True
        Me.rbSteakSandwich.Text = "Philly Cheesesteak $3.25 "
        Me.rbSteakSandwich.UseVisualStyleBackColor = False
        '
        'rbBurger
        '
        Me.rbBurger.AutoSize = True
        Me.rbBurger.BackColor = System.Drawing.Color.Transparent
        Me.rbBurger.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbBurger.ForeColor = System.Drawing.Color.Black
        Me.rbBurger.Location = New System.Drawing.Point(17, 101)
        Me.rbBurger.Name = "rbBurger"
        Me.rbBurger.Size = New System.Drawing.Size(339, 41)
        Me.rbBurger.TabIndex = 1
        Me.rbBurger.TabStop = True
        Me.rbBurger.Text = "Cheeseburger $2.57"
        Me.rbBurger.UseVisualStyleBackColor = False
        '
        'rbNone
        '
        Me.rbNone.AutoSize = True
        Me.rbNone.BackColor = System.Drawing.Color.Transparent
        Me.rbNone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbNone.Location = New System.Drawing.Point(19, 54)
        Me.rbNone.Name = "rbNone"
        Me.rbNone.Size = New System.Drawing.Size(119, 41)
        Me.rbNone.TabIndex = 0
        Me.rbNone.TabStop = True
        Me.rbNone.Text = "none"
        Me.rbNone.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Yellow
        Me.GroupBox2.Controls.Add(Me.cboxRings)
        Me.GroupBox2.Controls.Add(Me.cboxFries)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(519, 348)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(334, 156)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Sides"
        '
        'cboxRings
        '
        Me.cboxRings.AutoSize = True
        Me.cboxRings.Location = New System.Drawing.Point(28, 91)
        Me.cboxRings.Name = "cboxRings"
        Me.cboxRings.Size = New System.Drawing.Size(304, 41)
        Me.cboxRings.TabIndex = 4
        Me.cboxRings.Text = "Onion rings $2.30"
        Me.cboxRings.UseVisualStyleBackColor = True
        '
        'cboxFries
        '
        Me.cboxFries.AutoSize = True
        Me.cboxFries.Location = New System.Drawing.Point(28, 44)
        Me.cboxFries.Name = "cboxFries"
        Me.cboxFries.Size = New System.Drawing.Size(208, 41)
        Me.cboxFries.TabIndex = 0
        Me.cboxFries.Text = "Fries $1.29"
        Me.cboxFries.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.rbDrinksNone)
        Me.GroupBox3.Controls.Add(Me.rbBeer)
        Me.GroupBox3.Controls.Add(Me.rbOrangeSoda)
        Me.GroupBox3.Controls.Add(Me.rbCoke)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(519, 97)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(334, 245)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Drinks $1.25"
        '
        'rbDrinksNone
        '
        Me.rbDrinksNone.AutoSize = True
        Me.rbDrinksNone.Location = New System.Drawing.Point(30, 43)
        Me.rbDrinksNone.Name = "rbDrinksNone"
        Me.rbDrinksNone.Size = New System.Drawing.Size(119, 41)
        Me.rbDrinksNone.TabIndex = 3
        Me.rbDrinksNone.TabStop = True
        Me.rbDrinksNone.Text = "none"
        Me.rbDrinksNone.UseVisualStyleBackColor = True
        '
        'rbBeer
        '
        Me.rbBeer.AutoSize = True
        Me.rbBeer.Location = New System.Drawing.Point(30, 195)
        Me.rbBeer.Name = "rbBeer"
        Me.rbBeer.Size = New System.Drawing.Size(268, 41)
        Me.rbBeer.TabIndex = 2
        Me.rbBeer.TabStop = True
        Me.rbBeer.Text = "Beer(yes Beer!)"
        Me.rbBeer.UseVisualStyleBackColor = True
        '
        'rbOrangeSoda
        '
        Me.rbOrangeSoda.AutoSize = True
        Me.rbOrangeSoda.Location = New System.Drawing.Point(30, 148)
        Me.rbOrangeSoda.Name = "rbOrangeSoda"
        Me.rbOrangeSoda.Size = New System.Drawing.Size(239, 41)
        Me.rbOrangeSoda.TabIndex = 1
        Me.rbOrangeSoda.TabStop = True
        Me.rbOrangeSoda.Text = "Orange Soda"
        Me.rbOrangeSoda.UseVisualStyleBackColor = True
        '
        'rbCoke
        '
        Me.rbCoke.AutoSize = True
        Me.rbCoke.Location = New System.Drawing.Point(30, 101)
        Me.rbCoke.Name = "rbCoke"
        Me.rbCoke.Size = New System.Drawing.Size(122, 41)
        Me.rbCoke.TabIndex = 0
        Me.rbCoke.TabStop = True
        Me.rbCoke.Text = "Coke"
        Me.rbCoke.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(138, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(604, 73)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Manly Men Burgers"
        '
        'btnEnter
        '
        Me.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnEnter.Location = New System.Drawing.Point(41, 510)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(195, 83)
        Me.btnEnter.TabIndex = 4
        Me.btnEnter.Text = "Enter"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnClear.Location = New System.Drawing.Point(41, 599)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(195, 83)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnExit.Location = New System.Drawing.Point(41, 688)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(195, 83)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lsOrderRecipt
        '
        Me.lsOrderRecipt.FormattingEnabled = True
        Me.lsOrderRecipt.ItemHeight = 25
        Me.lsOrderRecipt.Location = New System.Drawing.Point(519, 510)
        Me.lsOrderRecipt.Name = "lsOrderRecipt"
        Me.lsOrderRecipt.Size = New System.Drawing.Size(334, 254)
        Me.lsOrderRecipt.TabIndex = 7
        '
        'lsTotal
        '
        Me.lsTotal.FormattingEnabled = True
        Me.lsTotal.ItemHeight = 25
        Me.lsTotal.Location = New System.Drawing.Point(519, 770)
        Me.lsTotal.Name = "lsTotal"
        Me.lsTotal.Size = New System.Drawing.Size(334, 79)
        Me.lsTotal.TabIndex = 8
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(242, 510)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(271, 238)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'frmFastFood
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(892, 870)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lsTotal)
        Me.Controls.Add(Me.lsOrderRecipt)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmFastFood"
        Me.Text = "Manly"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cboxBacon As CheckBox
    Friend WithEvents cboxCheese As CheckBox
    Friend WithEvents rbChickenSandwich As RadioButton
    Friend WithEvents rbSteakSandwich As RadioButton
    Friend WithEvents rbBurger As RadioButton
    Friend WithEvents rbNone As RadioButton
    Friend WithEvents rbDrinksNone As RadioButton
    Friend WithEvents rbBeer As RadioButton
    Friend WithEvents rbOrangeSoda As RadioButton
    Friend WithEvents rbCoke As RadioButton
    Friend WithEvents cboxRings As CheckBox
    Friend WithEvents cboxFries As CheckBox
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lsOrderRecipt As ListBox
    Friend WithEvents lsTotal As ListBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
