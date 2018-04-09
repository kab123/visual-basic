<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTickets
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDays = New System.Windows.Forms.TextBox()
        Me.txtTickets = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chkParking = New System.Windows.Forms.CheckBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.lblTicketSubtotal = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(116, 135)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Days"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(116, 198)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(333, 42)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "# Tickets $95/each"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(124, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(202, 61)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tickets"
        '
        'txtDays
        '
        Me.txtDays.Location = New System.Drawing.Point(27, 135)
        Me.txtDays.Multiline = True
        Me.txtDays.Name = "txtDays"
        Me.txtDays.Size = New System.Drawing.Size(73, 42)
        Me.txtDays.TabIndex = 3
        '
        'txtTickets
        '
        Me.txtTickets.Location = New System.Drawing.Point(27, 198)
        Me.txtTickets.Multiline = True
        Me.txtTickets.Name = "txtTickets"
        Me.txtTickets.Size = New System.Drawing.Size(73, 42)
        Me.txtTickets.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(87, 271)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(227, 33)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "$15 Service Fee"
        '
        'chkParking
        '
        Me.chkParking.AutoSize = True
        Me.chkParking.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkParking.Location = New System.Drawing.Point(57, 317)
        Me.chkParking.Name = "chkParking"
        Me.chkParking.Size = New System.Drawing.Size(257, 37)
        Me.chkParking.TabIndex = 6
        Me.chkParking.Text = "$20 Parking/day"
        Me.chkParking.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(57, 393)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(142, 58)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnDone
        '
        Me.btnDone.Location = New System.Drawing.Point(57, 471)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(142, 58)
        Me.btnDone.TabIndex = 8
        Me.btnDone.Text = "Done"
        Me.btnDone.UseVisualStyleBackColor = True
        '
        'lblTicketSubtotal
        '
        Me.lblTicketSubtotal.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblTicketSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTicketSubtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTicketSubtotal.Location = New System.Drawing.Point(248, 471)
        Me.lblTicketSubtotal.Name = "lblTicketSubtotal"
        Me.lblTicketSubtotal.Size = New System.Drawing.Size(182, 58)
        Me.lblTicketSubtotal.TabIndex = 9
        Me.lblTicketSubtotal.Text = "$0.00"
        Me.lblTicketSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmTickets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 556)
        Me.Controls.Add(Me.lblTicketSubtotal)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.chkParking)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTickets)
        Me.Controls.Add(Me.txtDays)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmTickets"
        Me.Text = "frmTickets"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDays As TextBox
    Friend WithEvents txtTickets As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents chkParking As CheckBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnDone As Button
    Friend WithEvents lblTicketSubtotal As Label
End Class
