<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Customer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Customer))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnSignupC = New System.Windows.Forms.Button()
        Me.lblORC = New System.Windows.Forms.Label()
        Me.btnLoginC = New System.Windows.Forms.Button()
        Me.txtPasswordC = New System.Windows.Forms.TextBox()
        Me.txtEmailC = New System.Windows.Forms.TextBox()
        Me.lblPasswordC = New System.Windows.Forms.Label()
        Me.lblEmailC = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MENUToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BACKToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EXITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(267, 325)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(192, 17)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Don't have any? Sign up now"
        '
        'btnSignupC
        '
        Me.btnSignupC.Location = New System.Drawing.Point(331, 361)
        Me.btnSignupC.Name = "btnSignupC"
        Me.btnSignupC.Size = New System.Drawing.Size(86, 35)
        Me.btnSignupC.TabIndex = 26
        Me.btnSignupC.Text = "SIGN UP"
        Me.btnSignupC.UseVisualStyleBackColor = True
        '
        'lblORC
        '
        Me.lblORC.AutoSize = True
        Me.lblORC.BackColor = System.Drawing.Color.Transparent
        Me.lblORC.Location = New System.Drawing.Point(58, 271)
        Me.lblORC.Name = "lblORC"
        Me.lblORC.Size = New System.Drawing.Size(619, 17)
        Me.lblORC.TabIndex = 25
        Me.lblORC.Text = "--------------------------------------------------------------OR-----------------" &
    "---------------------------------------"
        '
        'btnLoginC
        '
        Me.btnLoginC.Location = New System.Drawing.Point(331, 206)
        Me.btnLoginC.Name = "btnLoginC"
        Me.btnLoginC.Size = New System.Drawing.Size(75, 33)
        Me.btnLoginC.TabIndex = 24
        Me.btnLoginC.Text = "LOG IN"
        Me.btnLoginC.UseVisualStyleBackColor = True
        '
        'txtPasswordC
        '
        Me.txtPasswordC.Location = New System.Drawing.Point(331, 121)
        Me.txtPasswordC.Name = "txtPasswordC"
        Me.txtPasswordC.Size = New System.Drawing.Size(253, 22)
        Me.txtPasswordC.TabIndex = 23
        '
        'txtEmailC
        '
        Me.txtEmailC.Location = New System.Drawing.Point(331, 78)
        Me.txtEmailC.Name = "txtEmailC"
        Me.txtEmailC.Size = New System.Drawing.Size(253, 22)
        Me.txtEmailC.TabIndex = 22
        '
        'lblPasswordC
        '
        Me.lblPasswordC.AutoSize = True
        Me.lblPasswordC.Location = New System.Drawing.Point(196, 126)
        Me.lblPasswordC.Name = "lblPasswordC"
        Me.lblPasswordC.Size = New System.Drawing.Size(92, 17)
        Me.lblPasswordC.TabIndex = 21
        Me.lblPasswordC.Text = "PASSWORD:"
        '
        'lblEmailC
        '
        Me.lblEmailC.AutoSize = True
        Me.lblEmailC.Location = New System.Drawing.Point(196, 78)
        Me.lblEmailC.Name = "lblEmailC"
        Me.lblEmailC.Size = New System.Drawing.Size(52, 17)
        Me.lblEmailC.TabIndex = 20
        Me.lblEmailC.Text = "EMAIL:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(4, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(736, 491)
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MENUToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(752, 28)
        Me.MenuStrip1.TabIndex = 29
        Me.MenuStrip1.Text = "MenuStrip1"
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
        Me.BACKToolStripMenuItem.Size = New System.Drawing.Size(121, 26)
        Me.BACKToolStripMenuItem.Text = "BACK"
        '
        'EXITToolStripMenuItem
        '
        Me.EXITToolStripMenuItem.Name = "EXITToolStripMenuItem"
        Me.EXITToolStripMenuItem.Size = New System.Drawing.Size(121, 26)
        Me.EXITToolStripMenuItem.Text = "EXIT"
        '
        'Customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(752, 494)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnSignupC)
        Me.Controls.Add(Me.lblORC)
        Me.Controls.Add(Me.btnLoginC)
        Me.Controls.Add(Me.txtPasswordC)
        Me.Controls.Add(Me.txtEmailC)
        Me.Controls.Add(Me.lblPasswordC)
        Me.Controls.Add(Me.lblEmailC)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Customer"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents btnSignupC As Button
    Friend WithEvents lblORC As Label
    Friend WithEvents btnLoginC As Button
    Friend WithEvents txtPasswordC As TextBox
    Friend WithEvents txtEmailC As TextBox
    Friend WithEvents lblPasswordC As Label
    Friend WithEvents lblEmailC As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MENUToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BACKToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EXITToolStripMenuItem As ToolStripMenuItem
End Class
