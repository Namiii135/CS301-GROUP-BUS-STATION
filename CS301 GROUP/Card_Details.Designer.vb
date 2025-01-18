<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Card_Details
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
        Me.btnNextP = New System.Windows.Forms.Button()
        Me.btnClearP = New System.Windows.Forms.Button()
        Me.txtCardNumber = New System.Windows.Forms.TextBox()
        Me.txtExpDate = New System.Windows.Forms.TextBox()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.txtCardHolderName = New System.Windows.Forms.TextBox()
        Me.lblCode = New System.Windows.Forms.Label()
        Me.lblExpDate = New System.Windows.Forms.Label()
        Me.lblCardNumber = New System.Windows.Forms.Label()
        Me.lblCardHolderName = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MENUToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BACKToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CANCELToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EXITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnNextP
        '
        Me.btnNextP.Location = New System.Drawing.Point(493, 374)
        Me.btnNextP.Name = "btnNextP"
        Me.btnNextP.Size = New System.Drawing.Size(75, 41)
        Me.btnNextP.TabIndex = 24
        Me.btnNextP.Text = "NEXT"
        Me.btnNextP.UseVisualStyleBackColor = True
        '
        'btnClearP
        '
        Me.btnClearP.Location = New System.Drawing.Point(242, 374)
        Me.btnClearP.Name = "btnClearP"
        Me.btnClearP.Size = New System.Drawing.Size(75, 41)
        Me.btnClearP.TabIndex = 23
        Me.btnClearP.Text = "CLEAR"
        Me.btnClearP.UseVisualStyleBackColor = True
        '
        'txtCardNumber
        '
        Me.txtCardNumber.Location = New System.Drawing.Point(394, 164)
        Me.txtCardNumber.Name = "txtCardNumber"
        Me.txtCardNumber.Size = New System.Drawing.Size(276, 22)
        Me.txtCardNumber.TabIndex = 22
        '
        'txtExpDate
        '
        Me.txtExpDate.Location = New System.Drawing.Point(394, 223)
        Me.txtExpDate.Name = "txtExpDate"
        Me.txtExpDate.Size = New System.Drawing.Size(100, 22)
        Me.txtExpDate.TabIndex = 21
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(394, 285)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(66, 22)
        Me.txtCode.TabIndex = 20
        '
        'txtCardHolderName
        '
        Me.txtCardHolderName.Location = New System.Drawing.Point(394, 113)
        Me.txtCardHolderName.Name = "txtCardHolderName"
        Me.txtCardHolderName.Size = New System.Drawing.Size(276, 22)
        Me.txtCardHolderName.TabIndex = 19
        '
        'lblCode
        '
        Me.lblCode.AutoSize = True
        Me.lblCode.Location = New System.Drawing.Point(176, 285)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(113, 17)
        Me.lblCode.TabIndex = 18
        Me.lblCode.Text = "CVV/CVC CODE:"
        '
        'lblExpDate
        '
        Me.lblExpDate.AutoSize = True
        Me.lblExpDate.Location = New System.Drawing.Point(176, 223)
        Me.lblExpDate.Name = "lblExpDate"
        Me.lblExpDate.Size = New System.Drawing.Size(102, 17)
        Me.lblExpDate.TabIndex = 17
        Me.lblExpDate.Text = "EXPIRY DATE:"
        '
        'lblCardNumber
        '
        Me.lblCardNumber.AutoSize = True
        Me.lblCardNumber.Location = New System.Drawing.Point(176, 169)
        Me.lblCardNumber.Name = "lblCardNumber"
        Me.lblCardNumber.Size = New System.Drawing.Size(113, 17)
        Me.lblCardNumber.TabIndex = 16
        Me.lblCardNumber.Text = "CARD NUMBER:"
        '
        'lblCardHolderName
        '
        Me.lblCardHolderName.AutoSize = True
        Me.lblCardHolderName.Location = New System.Drawing.Point(176, 113)
        Me.lblCardHolderName.Name = "lblCardHolderName"
        Me.lblCardHolderName.Size = New System.Drawing.Size(155, 17)
        Me.lblCardHolderName.TabIndex = 15
        Me.lblCardHolderName.Text = "CARD HOLDER NAME:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MENUToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 25
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MENUToolStripMenuItem
        '
        Me.MENUToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BACKToolStripMenuItem, Me.CANCELToolStripMenuItem})
        Me.MENUToolStripMenuItem.Name = "MENUToolStripMenuItem"
        Me.MENUToolStripMenuItem.Size = New System.Drawing.Size(63, 24)
        Me.MENUToolStripMenuItem.Text = "MENU"
        '
        'BACKToolStripMenuItem
        '
        Me.BACKToolStripMenuItem.Name = "BACKToolStripMenuItem"
        Me.BACKToolStripMenuItem.Size = New System.Drawing.Size(138, 26)
        Me.BACKToolStripMenuItem.Text = "BACK"
        '
        'CANCELToolStripMenuItem
        '
        Me.CANCELToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EXITToolStripMenuItem})
        Me.CANCELToolStripMenuItem.Name = "CANCELToolStripMenuItem"
        Me.CANCELToolStripMenuItem.Size = New System.Drawing.Size(138, 26)
        Me.CANCELToolStripMenuItem.Text = "CANCEL"
        '
        'EXITToolStripMenuItem
        '
        Me.EXITToolStripMenuItem.Name = "EXITToolStripMenuItem"
        Me.EXITToolStripMenuItem.Size = New System.Drawing.Size(113, 26)
        Me.EXITToolStripMenuItem.Text = "EXIT"
        '
        'Card_Details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnNextP)
        Me.Controls.Add(Me.btnClearP)
        Me.Controls.Add(Me.txtCardNumber)
        Me.Controls.Add(Me.txtExpDate)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.txtCardHolderName)
        Me.Controls.Add(Me.lblCode)
        Me.Controls.Add(Me.lblExpDate)
        Me.Controls.Add(Me.lblCardNumber)
        Me.Controls.Add(Me.lblCardHolderName)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Card_Details"
        Me.Text = "Card_Details"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnNextP As Button
    Friend WithEvents btnClearP As Button
    Friend WithEvents txtCardNumber As TextBox
    Friend WithEvents txtExpDate As TextBox
    Friend WithEvents txtCode As TextBox
    Friend WithEvents txtCardHolderName As TextBox
    Friend WithEvents lblCode As Label
    Friend WithEvents lblExpDate As Label
    Friend WithEvents lblCardNumber As Label
    Friend WithEvents lblCardHolderName As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MENUToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BACKToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CANCELToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EXITToolStripMenuItem As ToolStripMenuItem
End Class
