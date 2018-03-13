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
        Me.grpHoursEachDay = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtMonday = New System.Windows.Forms.TextBox()
        Me.txtTuesday = New System.Windows.Forms.TextBox()
        Me.txtSaturday = New System.Windows.Forms.TextBox()
        Me.txtFriday = New System.Windows.Forms.TextBox()
        Me.txtThursday = New System.Windows.Forms.TextBox()
        Me.txtWednesday = New System.Windows.Forms.TextBox()
        Me.txtSunday = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblPayCheckAmount = New System.Windows.Forms.Label()
        Me.lblPayCheckName = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblPayCheckDate = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtPayrate = New System.Windows.Forms.TextBox()
        Me.lblRegular = New System.Windows.Forms.Label()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblOverTime = New System.Windows.Forms.Label()
        Me.lblTotalHours = New System.Windows.Forms.Label()
        Me.lblAmountPaid = New System.Windows.Forms.Label()
        Me.grpHoursEachDay.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpHoursEachDay
        '
        Me.grpHoursEachDay.BackColor = System.Drawing.Color.Salmon
        Me.grpHoursEachDay.Controls.Add(Me.Label13)
        Me.grpHoursEachDay.Controls.Add(Me.Label19)
        Me.grpHoursEachDay.Controls.Add(Me.Label17)
        Me.grpHoursEachDay.Controls.Add(Me.Label16)
        Me.grpHoursEachDay.Controls.Add(Me.Label15)
        Me.grpHoursEachDay.Controls.Add(Me.Label14)
        Me.grpHoursEachDay.Controls.Add(Me.Label12)
        Me.grpHoursEachDay.Controls.Add(Me.txtMonday)
        Me.grpHoursEachDay.Controls.Add(Me.txtTuesday)
        Me.grpHoursEachDay.Controls.Add(Me.txtSaturday)
        Me.grpHoursEachDay.Controls.Add(Me.txtFriday)
        Me.grpHoursEachDay.Controls.Add(Me.txtThursday)
        Me.grpHoursEachDay.Controls.Add(Me.txtWednesday)
        Me.grpHoursEachDay.Controls.Add(Me.txtSunday)
        Me.grpHoursEachDay.Location = New System.Drawing.Point(38, 44)
        Me.grpHoursEachDay.Name = "grpHoursEachDay"
        Me.grpHoursEachDay.Size = New System.Drawing.Size(353, 438)
        Me.grpHoursEachDay.TabIndex = 0
        Me.grpHoursEachDay.TabStop = False
        Me.grpHoursEachDay.Text = "Hours Each Day"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(54, 349)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(98, 25)
        Me.Label13.TabIndex = 37
        Me.Label13.Text = "Saturday"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(54, 99)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(89, 25)
        Me.Label19.TabIndex = 36
        Me.Label19.Text = "Monday"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(54, 149)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(95, 25)
        Me.Label17.TabIndex = 34
        Me.Label17.Text = "Tuesday"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(54, 199)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(126, 25)
        Me.Label16.TabIndex = 33
        Me.Label16.Text = "Wednesday"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(54, 249)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(102, 25)
        Me.Label15.TabIndex = 32
        Me.Label15.Text = "Thursday"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(54, 299)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 25)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "Friday"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(54, 49)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(85, 25)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "Sunday"
        '
        'txtMonday
        '
        Me.txtMonday.Location = New System.Drawing.Point(186, 96)
        Me.txtMonday.Multiline = True
        Me.txtMonday.Name = "txtMonday"
        Me.txtMonday.Size = New System.Drawing.Size(124, 44)
        Me.txtMonday.TabIndex = 28
        '
        'txtTuesday
        '
        Me.txtTuesday.Location = New System.Drawing.Point(186, 146)
        Me.txtTuesday.Multiline = True
        Me.txtTuesday.Name = "txtTuesday"
        Me.txtTuesday.Size = New System.Drawing.Size(124, 44)
        Me.txtTuesday.TabIndex = 27
        '
        'txtSaturday
        '
        Me.txtSaturday.Location = New System.Drawing.Point(186, 346)
        Me.txtSaturday.Multiline = True
        Me.txtSaturday.Name = "txtSaturday"
        Me.txtSaturday.Size = New System.Drawing.Size(124, 44)
        Me.txtSaturday.TabIndex = 26
        '
        'txtFriday
        '
        Me.txtFriday.Location = New System.Drawing.Point(186, 296)
        Me.txtFriday.Multiline = True
        Me.txtFriday.Name = "txtFriday"
        Me.txtFriday.Size = New System.Drawing.Size(124, 44)
        Me.txtFriday.TabIndex = 25
        '
        'txtThursday
        '
        Me.txtThursday.Location = New System.Drawing.Point(186, 246)
        Me.txtThursday.Multiline = True
        Me.txtThursday.Name = "txtThursday"
        Me.txtThursday.Size = New System.Drawing.Size(124, 44)
        Me.txtThursday.TabIndex = 24
        '
        'txtWednesday
        '
        Me.txtWednesday.Location = New System.Drawing.Point(186, 196)
        Me.txtWednesday.Multiline = True
        Me.txtWednesday.Name = "txtWednesday"
        Me.txtWednesday.Size = New System.Drawing.Size(124, 44)
        Me.txtWednesday.TabIndex = 23
        '
        'txtSunday
        '
        Me.txtSunday.Location = New System.Drawing.Point(186, 49)
        Me.txtSunday.Multiline = True
        Me.txtSunday.Name = "txtSunday"
        Me.txtSunday.Size = New System.Drawing.Size(124, 44)
        Me.txtSunday.TabIndex = 22
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Controls.Add(Me.lblPayCheckAmount)
        Me.GroupBox2.Controls.Add(Me.lblPayCheckName)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.lblPayCheckDate)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(60, 527)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(946, 318)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'lblPayCheckAmount
        '
        Me.lblPayCheckAmount.BackColor = System.Drawing.Color.White
        Me.lblPayCheckAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPayCheckAmount.Location = New System.Drawing.Point(748, 167)
        Me.lblPayCheckAmount.Name = "lblPayCheckAmount"
        Me.lblPayCheckAmount.Size = New System.Drawing.Size(103, 43)
        Me.lblPayCheckAmount.TabIndex = 4
        '
        'lblPayCheckName
        '
        Me.lblPayCheckName.BackColor = System.Drawing.Color.White
        Me.lblPayCheckName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPayCheckName.Location = New System.Drawing.Point(23, 167)
        Me.lblPayCheckName.Name = "lblPayCheckName"
        Me.lblPayCheckName.Size = New System.Drawing.Size(642, 43)
        Me.lblPayCheckName.TabIndex = 3
        Me.lblPayCheckName.Text = "Employee Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Monotype Corsiva", 16.125!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(659, 251)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(281, 52)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Enkido Betmallo"
        '
        'lblPayCheckDate
        '
        Me.lblPayCheckDate.AutoSize = True
        Me.lblPayCheckDate.Location = New System.Drawing.Point(813, 27)
        Me.lblPayCheckDate.Name = "lblPayCheckDate"
        Me.lblPayCheckDate.Size = New System.Drawing.Size(57, 25)
        Me.lblPayCheckDate.TabIndex = 1
        Me.lblPayCheckDate.Text = "Date"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(23, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 111)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pear Inc." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "12355 North Pole" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Planet Earth" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "99004455"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(466, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 25)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(466, 109)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 25)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Pay Rate"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(444, 278)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 25)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Regular"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(444, 326)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 25)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Overtime"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(444, 376)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 25)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "TOTAL"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(456, 467)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(55, 25)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "PAY"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(575, 54)
        Me.txtName.Multiline = True
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(260, 37)
        Me.txtName.TabIndex = 11
        '
        'txtPayrate
        '
        Me.txtPayrate.Location = New System.Drawing.Point(575, 109)
        Me.txtPayrate.Multiline = True
        Me.txtPayrate.Name = "txtPayrate"
        Me.txtPayrate.Size = New System.Drawing.Size(124, 44)
        Me.txtPayrate.TabIndex = 12
        '
        'lblRegular
        '
        Me.lblRegular.BackColor = System.Drawing.Color.White
        Me.lblRegular.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRegular.Location = New System.Drawing.Point(562, 278)
        Me.lblRegular.Name = "lblRegular"
        Me.lblRegular.Size = New System.Drawing.Size(113, 36)
        Me.lblRegular.TabIndex = 13
        '
        'btnCompute
        '
        Me.btnCompute.Location = New System.Drawing.Point(426, 192)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(151, 52)
        Me.btnCompute.TabIndex = 17
        Me.btnCompute.Text = "Compute"
        Me.btnCompute.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(668, 192)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(151, 52)
        Me.btnClear.TabIndex = 18
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblOverTime
        '
        Me.lblOverTime.BackColor = System.Drawing.Color.White
        Me.lblOverTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOverTime.Location = New System.Drawing.Point(562, 326)
        Me.lblOverTime.Name = "lblOverTime"
        Me.lblOverTime.Size = New System.Drawing.Size(113, 36)
        Me.lblOverTime.TabIndex = 19
        '
        'lblTotalHours
        '
        Me.lblTotalHours.BackColor = System.Drawing.Color.White
        Me.lblTotalHours.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalHours.Location = New System.Drawing.Point(562, 376)
        Me.lblTotalHours.Name = "lblTotalHours"
        Me.lblTotalHours.Size = New System.Drawing.Size(113, 36)
        Me.lblTotalHours.TabIndex = 20
        '
        'lblAmountPaid
        '
        Me.lblAmountPaid.BackColor = System.Drawing.Color.White
        Me.lblAmountPaid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAmountPaid.Location = New System.Drawing.Point(531, 467)
        Me.lblAmountPaid.Name = "lblAmountPaid"
        Me.lblAmountPaid.Size = New System.Drawing.Size(216, 36)
        Me.lblAmountPaid.TabIndex = 21
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(1038, 857)
        Me.Controls.Add(Me.lblAmountPaid)
        Me.Controls.Add(Me.lblTotalHours)
        Me.Controls.Add(Me.lblOverTime)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.lblRegular)
        Me.Controls.Add(Me.txtPayrate)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.grpHoursEachDay)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.grpHoursEachDay.ResumeLayout(False)
        Me.grpHoursEachDay.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpHoursEachDay As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblPayCheckAmount As Label
    Friend WithEvents lblPayCheckName As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblPayCheckDate As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtPayrate As TextBox
    Friend WithEvents lblRegular As Label
    Friend WithEvents btnCompute As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblOverTime As Label
    Friend WithEvents lblTotalHours As Label
    Friend WithEvents lblAmountPaid As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtMonday As TextBox
    Friend WithEvents txtTuesday As TextBox
    Friend WithEvents txtSaturday As TextBox
    Friend WithEvents txtFriday As TextBox
    Friend WithEvents txtThursday As TextBox
    Friend WithEvents txtWednesday As TextBox
    Friend WithEvents txtSunday As TextBox
End Class
