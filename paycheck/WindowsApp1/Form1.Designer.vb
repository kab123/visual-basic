<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainttitlelbl
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
        Me.titlelbl = New System.Windows.Forms.Label()
        Me.hourslbl = New System.Windows.Forms.Label()
        Me.ratelbl = New System.Windows.Forms.Label()
        Me.hoursbox = New System.Windows.Forms.TextBox()
        Me.ratebox = New System.Windows.Forms.TextBox()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.resultlbl = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'titlelbl
        '
        Me.titlelbl.AutoSize = True
        Me.titlelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titlelbl.Location = New System.Drawing.Point(22, 57)
        Me.titlelbl.Name = "titlelbl"
        Me.titlelbl.Size = New System.Drawing.Size(663, 79)
        Me.titlelbl.TabIndex = 0
        Me.titlelbl.Text = "Paycheck Calculator"
        '
        'hourslbl
        '
        Me.hourslbl.AutoSize = True
        Me.hourslbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hourslbl.Location = New System.Drawing.Point(36, 185)
        Me.hourslbl.Name = "hourslbl"
        Me.hourslbl.Size = New System.Drawing.Size(103, 37)
        Me.hourslbl.TabIndex = 1
        Me.hourslbl.Text = "Hours"
        '
        'ratelbl
        '
        Me.ratelbl.AutoSize = True
        Me.ratelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ratelbl.Location = New System.Drawing.Point(56, 256)
        Me.ratelbl.Name = "ratelbl"
        Me.ratelbl.Size = New System.Drawing.Size(83, 37)
        Me.ratelbl.TabIndex = 2
        Me.ratelbl.Text = "Rate"
        '
        'hoursbox
        '
        Me.hoursbox.Location = New System.Drawing.Point(145, 191)
        Me.hoursbox.Multiline = True
        Me.hoursbox.Name = "hoursbox"
        Me.hoursbox.Size = New System.Drawing.Size(139, 41)
        Me.hoursbox.TabIndex = 3
        '
        'ratebox
        '
        Me.ratebox.Location = New System.Drawing.Point(145, 256)
        Me.ratebox.Multiline = True
        Me.ratebox.Name = "ratebox"
        Me.ratebox.Size = New System.Drawing.Size(139, 37)
        Me.ratebox.TabIndex = 4
        '
        'btnCompute
        '
        Me.btnCompute.Location = New System.Drawing.Point(145, 324)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(139, 58)
        Me.btnCompute.TabIndex = 5
        Me.btnCompute.Text = "Compute"
        Me.btnCompute.UseVisualStyleBackColor = True
        '
        'resultlbl
        '
        Me.resultlbl.AutoSize = True
        Me.resultlbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.resultlbl.Location = New System.Drawing.Point(36, 421)
        Me.resultlbl.MinimumSize = New System.Drawing.Size(400, 80)
        Me.resultlbl.Name = "resultlbl"
        Me.resultlbl.Size = New System.Drawing.Size(400, 80)
        Me.resultlbl.TabIndex = 6
        '
        'mainttitlelbl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(729, 686)
        Me.Controls.Add(Me.resultlbl)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.ratebox)
        Me.Controls.Add(Me.hoursbox)
        Me.Controls.Add(Me.ratelbl)
        Me.Controls.Add(Me.hourslbl)
        Me.Controls.Add(Me.titlelbl)
        Me.Name = "mainttitlelbl"
        Me.Text = "How Much Money Am I Making?"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents titlelbl As Label
    Friend WithEvents hourslbl As Label
    Friend WithEvents ratelbl As Label
    Friend WithEvents hoursbox As TextBox
    Friend WithEvents ratebox As TextBox
    Friend WithEvents btnCompute As Button
    Friend WithEvents resultlbl As Label
End Class
