<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Staff
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Staff))
        Me.MENUToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BACKToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EXITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblEmailC = New System.Windows.Forms.Label()
        Me.lblPasswordC = New System.Windows.Forms.Label()
        Me.txtEmailC = New System.Windows.Forms.TextBox()
        Me.txtPasswordC = New System.Windows.Forms.TextBox()
        Me.btnLoginC = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MENUToolStripMenuItem
        '
        Me.MENUToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BACKToolStripMenuItem, Me.EXITToolStripMenuItem})
        Me.MENUToolStripMenuItem.Name = "MENUToolStripMenuItem"
        Me.MENUToolStripMenuItem.Size = New System.Drawing.Size(63, 24)
        Me.MENUToolStripMenuItem.Text = "MENU"
        '
        'BACKToolStripMenuItem
        '
        Me.BACKToolStripMenuItem.Name = "BACKToolStripMenuItem"
        Me.BACKToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.BACKToolStripMenuItem.Text = "BACK"
        '
        'EXITToolStripMenuItem
        '
        Me.EXITToolStripMenuItem.Name = "EXITToolStripMenuItem"
        Me.EXITToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.EXITToolStripMenuItem.Text = "EXIT"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MENUToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(736, 28)
        Me.MenuStrip1.TabIndex = 29
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(736, 491)
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'lblEmailC
        '
        Me.lblEmailC.AutoSize = True
        Me.lblEmailC.Location = New System.Drawing.Point(196, 164)
        Me.lblEmailC.Name = "lblEmailC"
        Me.lblEmailC.Size = New System.Drawing.Size(29, 17)
        Me.lblEmailC.TabIndex = 20
        Me.lblEmailC.Text = "ID :"
        '
        'lblPasswordC
        '
        Me.lblPasswordC.AutoSize = True
        Me.lblPasswordC.Location = New System.Drawing.Point(196, 222)
        Me.lblPasswordC.Name = "lblPasswordC"
        Me.lblPasswordC.Size = New System.Drawing.Size(92, 17)
        Me.lblPasswordC.TabIndex = 21
        Me.lblPasswordC.Text = "PASSWORD:"
        '
        'txtEmailC
        '
        Me.txtEmailC.Location = New System.Drawing.Point(331, 161)
        Me.txtEmailC.Name = "txtEmailC"
        Me.txtEmailC.Size = New System.Drawing.Size(253, 22)
        Me.txtEmailC.TabIndex = 22
        '
        'txtPasswordC
        '
        Me.txtPasswordC.Location = New System.Drawing.Point(331, 217)
        Me.txtPasswordC.Name = "txtPasswordC"
        Me.txtPasswordC.Size = New System.Drawing.Size(253, 22)
        Me.txtPasswordC.TabIndex = 23
        '
        'btnLoginC
        '
        Me.btnLoginC.Location = New System.Drawing.Point(331, 279)
        Me.btnLoginC.Name = "btnLoginC"
        Me.btnLoginC.Size = New System.Drawing.Size(75, 33)
        Me.btnLoginC.TabIndex = 24
        Me.btnLoginC.Text = "LOG IN"
        Me.btnLoginC.UseVisualStyleBackColor = True
        '
        'Staff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(736, 495)
        Me.Controls.Add(Me.btnLoginC)
        Me.Controls.Add(Me.txtPasswordC)
        Me.Controls.Add(Me.txtEmailC)
        Me.Controls.Add(Me.lblPasswordC)
        Me.Controls.Add(Me.lblEmailC)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Staff"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MENUToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BACKToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EXITToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblEmailC As Label
    Friend WithEvents lblPasswordC As Label
    Friend WithEvents txtEmailC As TextBox
    Friend WithEvents txtPasswordC As TextBox
    Friend WithEvents btnLoginC As Button
End Class
