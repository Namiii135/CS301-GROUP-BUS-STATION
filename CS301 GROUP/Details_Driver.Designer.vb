<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Details_Driver
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Details_Driver))
        Me.txtDriverID = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ListBoxPassengers = New System.Windows.Forms.ListBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDriverID
        '
        Me.txtDriverID.AutoSize = True
        Me.txtDriverID.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDriverID.Location = New System.Drawing.Point(201, 29)
        Me.txtDriverID.Name = "txtDriverID"
        Me.txtDriverID.Size = New System.Drawing.Size(114, 38)
        Me.txtDriverID.TabIndex = 0
        Me.txtDriverID.Text = "Label1"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(316, 287)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(89, 61)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "EXIT"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ListBoxPassengers
        '
        Me.ListBoxPassengers.FormattingEnabled = True
        Me.ListBoxPassengers.ItemHeight = 16
        Me.ListBoxPassengers.Location = New System.Drawing.Point(88, 70)
        Me.ListBoxPassengers.Name = "ListBoxPassengers"
        Me.ListBoxPassengers.Size = New System.Drawing.Size(539, 180)
        Me.ListBoxPassengers.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(4, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(796, 488)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Details_Driver
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(787, 473)
        Me.Controls.Add(Me.ListBoxPassengers)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtDriverID)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Details_Driver"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtDriverID As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents ListBoxPassengers As ListBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
