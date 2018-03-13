<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WorkShopForm
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
        Me.grWorkShop = New System.Windows.Forms.GroupBox()
        Me.lsWorkShop = New System.Windows.Forms.ListBox()
        Me.grLocation = New System.Windows.Forms.GroupBox()
        Me.lsLocation = New System.Windows.Forms.ListBox()
        Me.grCosts = New System.Windows.Forms.GroupBox()
        Me.lsCosts = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnAddWorkshop = New System.Windows.Forms.Button()
        Me.btnTotal = New System.Windows.Forms.Button()
        Me.btnRest = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grWorkShop.SuspendLayout()
        Me.grLocation.SuspendLayout()
        Me.grCosts.SuspendLayout()
        Me.SuspendLayout()
        '
        'grWorkShop
        '
        Me.grWorkShop.BackColor = System.Drawing.SystemColors.ControlDark
        Me.grWorkShop.Controls.Add(Me.lsWorkShop)
        Me.grWorkShop.Location = New System.Drawing.Point(41, 42)
        Me.grWorkShop.Name = "grWorkShop"
        Me.grWorkShop.Size = New System.Drawing.Size(340, 330)
        Me.grWorkShop.TabIndex = 0
        Me.grWorkShop.TabStop = False
        Me.grWorkShop.Text = "Pick A WorkShop"
        '
        'lsWorkShop
        '
        Me.lsWorkShop.FormattingEnabled = True
        Me.lsWorkShop.ItemHeight = 25
        Me.lsWorkShop.Location = New System.Drawing.Point(19, 31)
        Me.lsWorkShop.Name = "lsWorkShop"
        Me.lsWorkShop.Size = New System.Drawing.Size(300, 279)
        Me.lsWorkShop.TabIndex = 0
        '
        'grLocation
        '
        Me.grLocation.BackColor = System.Drawing.SystemColors.ControlDark
        Me.grLocation.Controls.Add(Me.lsLocation)
        Me.grLocation.Location = New System.Drawing.Point(432, 42)
        Me.grLocation.Name = "grLocation"
        Me.grLocation.Size = New System.Drawing.Size(340, 330)
        Me.grLocation.TabIndex = 1
        Me.grLocation.TabStop = False
        Me.grLocation.Text = "Pick A Location"
        '
        'lsLocation
        '
        Me.lsLocation.FormattingEnabled = True
        Me.lsLocation.ItemHeight = 25
        Me.lsLocation.Location = New System.Drawing.Point(21, 31)
        Me.lsLocation.Name = "lsLocation"
        Me.lsLocation.Size = New System.Drawing.Size(300, 279)
        Me.lsLocation.TabIndex = 1
        '
        'grCosts
        '
        Me.grCosts.BackColor = System.Drawing.SystemColors.ControlDark
        Me.grCosts.Controls.Add(Me.lsCosts)
        Me.grCosts.Location = New System.Drawing.Point(826, 42)
        Me.grCosts.Name = "grCosts"
        Me.grCosts.Size = New System.Drawing.Size(355, 447)
        Me.grCosts.TabIndex = 1
        Me.grCosts.TabStop = False
        Me.grCosts.Text = "List Of Costs"
        '
        'lsCosts
        '
        Me.lsCosts.FormattingEnabled = True
        Me.lsCosts.ItemHeight = 25
        Me.lsCosts.Location = New System.Drawing.Point(16, 31)
        Me.lsCosts.Name = "lsCosts"
        Me.lsCosts.Size = New System.Drawing.Size(322, 404)
        Me.lsCosts.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(326, 440)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 37)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Total Cost:"
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Location = New System.Drawing.Point(505, 431)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(248, 58)
        Me.lblTotal.TabIndex = 3
        '
        'btnAddWorkshop
        '
        Me.btnAddWorkshop.Location = New System.Drawing.Point(164, 558)
        Me.btnAddWorkshop.Name = "btnAddWorkshop"
        Me.btnAddWorkshop.Size = New System.Drawing.Size(196, 62)
        Me.btnAddWorkshop.TabIndex = 4
        Me.btnAddWorkshop.Text = "Add Workshop"
        Me.btnAddWorkshop.UseVisualStyleBackColor = True
        '
        'btnTotal
        '
        Me.btnTotal.Location = New System.Drawing.Point(379, 558)
        Me.btnTotal.Name = "btnTotal"
        Me.btnTotal.Size = New System.Drawing.Size(196, 62)
        Me.btnTotal.TabIndex = 5
        Me.btnTotal.Text = "Calculate Total"
        Me.btnTotal.UseVisualStyleBackColor = True
        '
        'btnRest
        '
        Me.btnRest.Location = New System.Drawing.Point(593, 558)
        Me.btnRest.Name = "btnRest"
        Me.btnRest.Size = New System.Drawing.Size(196, 62)
        Me.btnRest.TabIndex = 6
        Me.btnRest.Text = "Reset"
        Me.btnRest.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(805, 558)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(196, 62)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'WorkShopForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1228, 693)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnRest)
        Me.Controls.Add(Me.btnTotal)
        Me.Controls.Add(Me.btnAddWorkshop)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grLocation)
        Me.Controls.Add(Me.grCosts)
        Me.Controls.Add(Me.grWorkShop)
        Me.Name = "WorkShopForm"
        Me.Text = "Workshop v1"
        Me.grWorkShop.ResumeLayout(False)
        Me.grLocation.ResumeLayout(False)
        Me.grCosts.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grWorkShop As GroupBox
    Friend WithEvents lsWorkShop As ListBox
    Friend WithEvents grLocation As GroupBox
    Friend WithEvents lsLocation As ListBox
    Friend WithEvents grCosts As GroupBox
    Friend WithEvents lsCosts As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnAddWorkshop As Button
    Friend WithEvents btnTotal As Button
    Friend WithEvents btnRest As Button
    Friend WithEvents btnExit As Button
End Class
