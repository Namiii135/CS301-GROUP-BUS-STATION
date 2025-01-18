<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DateForm
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
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CancelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstTime = New System.Windows.Forms.ListBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DateTimePicker1.Location = New System.Drawing.Point(395, 213)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(223, 22)
        Me.DateTimePicker1.TabIndex = 7
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearToolStripMenuItem, Me.ExitToolStripMenuItem, Me.CancelToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(128, 26)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(128, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'CancelToolStripMenuItem
        '
        Me.CancelToolStripMenuItem.Name = "CancelToolStripMenuItem"
        Me.CancelToolStripMenuItem.Size = New System.Drawing.Size(128, 26)
        Me.CancelToolStripMenuItem.Text = "Cancel"
        '
        'btnReturn
        '
        Me.btnReturn.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReturn.Location = New System.Drawing.Point(552, 299)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(141, 57)
        Me.btnReturn.TabIndex = 13
        Me.btnReturn.Text = "Return "
        Me.btnReturn.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(370, 177)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 24)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Choose Date"
        '
        'btnConfirm
        '
        Me.btnConfirm.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnConfirm.Location = New System.Drawing.Point(395, 299)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(141, 57)
        Me.btnConfirm.TabIndex = 11
        Me.btnConfirm.Text = "Confirm Selection"
        Me.btnConfirm.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(196, 155)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 24)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Available Timeslot"
        '
        'lstTime
        '
        Me.lstTime.FormattingEnabled = True
        Me.lstTime.ItemHeight = 16
        Me.lstTime.Location = New System.Drawing.Point(222, 192)
        Me.lstTime.Name = "lstTime"
        Me.lstTime.Size = New System.Drawing.Size(128, 164)
        Me.lstTime.TabIndex = 9
        '
        'Dateform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstTime)
        Me.Name = "Dateform"
        Me.Text = "Dateform"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CancelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnReturn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnConfirm As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lstTime As ListBox
End Class
