<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class printreceipt
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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnPrintReceipt = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(441, 297)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(129, 80)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnPrintReceipt
        '
        Me.btnPrintReceipt.Location = New System.Drawing.Point(229, 297)
        Me.btnPrintReceipt.Name = "btnPrintReceipt"
        Me.btnPrintReceipt.Size = New System.Drawing.Size(129, 80)
        Me.btnPrintReceipt.TabIndex = 8
        Me.btnPrintReceipt.Text = "Print Receipt"
        Me.btnPrintReceipt.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Impact", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(222, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(356, 41)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Melaka Ticketing System"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Impact", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(387, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 41)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "for using "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Impact", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(239, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 41)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Thank you "
        '
        'printreceipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnPrintReceipt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "printreceipt"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents btnPrintReceipt As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
