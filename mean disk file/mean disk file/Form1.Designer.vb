<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.btnSearchFile = New System.Windows.Forms.Button()
        Me.btnSearchArray = New System.Windows.Forms.Button()
        Me.txtsearchString = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.ofdGetFileName = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 25
        Me.ListBox1.Location = New System.Drawing.Point(29, 39)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(450, 204)
        Me.ListBox1.TabIndex = 0
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 25
        Me.ListBox2.Location = New System.Drawing.Point(607, 39)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(450, 204)
        Me.ListBox2.TabIndex = 1
        '
        'btnSearchFile
        '
        Me.btnSearchFile.Location = New System.Drawing.Point(29, 261)
        Me.btnSearchFile.Name = "btnSearchFile"
        Me.btnSearchFile.Size = New System.Drawing.Size(162, 49)
        Me.btnSearchFile.TabIndex = 2
        Me.btnSearchFile.Text = "Search File"
        Me.btnSearchFile.UseVisualStyleBackColor = True
        '
        'btnSearchArray
        '
        Me.btnSearchArray.Location = New System.Drawing.Point(607, 261)
        Me.btnSearchArray.Name = "btnSearchArray"
        Me.btnSearchArray.Size = New System.Drawing.Size(162, 49)
        Me.btnSearchArray.TabIndex = 3
        Me.btnSearchArray.Text = "Search Array"
        Me.btnSearchArray.UseVisualStyleBackColor = True
        '
        'txtsearchString
        '
        Me.txtsearchString.Location = New System.Drawing.Point(280, 404)
        Me.txtsearchString.Multiline = True
        Me.txtsearchString.Name = "txtsearchString"
        Me.txtsearchString.Size = New System.Drawing.Size(518, 42)
        Me.txtsearchString.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(475, 366)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Search String"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(917, 404)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(122, 51)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'ofdGetFileName
        '
        Me.ofdGetFileName.FileName = "OpenFileDialog2"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1079, 487)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtsearchString)
        Me.Controls.Add(Me.btnSearchArray)
        Me.Controls.Add(Me.btnSearchFile)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "Form1"
        Me.Text = "search a file/array v1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents btnSearchFile As Button
    Friend WithEvents btnSearchArray As Button
    Friend WithEvents txtsearchString As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ofdGetFileName As OpenFileDialog
End Class
