<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TicketForm
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTotPrice = New System.Windows.Forms.Label()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.numChild = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.numElderly = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.numStudent = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.numAdult = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.numChild, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numElderly, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numStudent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numAdult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(150, 106)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(125, 133)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ticket Price"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Children: RM"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Student: RM"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Elderly: RM"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Adult: RM"
        '
        'lblTotPrice
        '
        Me.lblTotPrice.AutoSize = True
        Me.lblTotPrice.Location = New System.Drawing.Point(599, 170)
        Me.lblTotPrice.Name = "lblTotPrice"
        Me.lblTotPrice.Size = New System.Drawing.Size(51, 17)
        Me.lblTotPrice.TabIndex = 24
        Me.lblTotPrice.Text = "Label9"
        '
        'btnReturn
        '
        Me.btnReturn.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReturn.Location = New System.Drawing.Point(354, 281)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(130, 63)
        Me.btnReturn.TabIndex = 23
        Me.btnReturn.Text = "Return"
        Me.btnReturn.UseVisualStyleBackColor = False
        '
        'btnConfirm
        '
        Me.btnConfirm.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnConfirm.Location = New System.Drawing.Point(199, 281)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(130, 63)
        Me.btnConfirm.TabIndex = 22
        Me.btnConfirm.Text = "Confirm Tickets"
        Me.btnConfirm.UseVisualStyleBackColor = False
        '
        'numChild
        '
        Me.numChild.Location = New System.Drawing.Point(420, 202)
        Me.numChild.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.numChild.Name = "numChild"
        Me.numChild.Size = New System.Drawing.Size(51, 22)
        Me.numChild.TabIndex = 21
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(339, 202)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 17)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Children"
        '
        'numElderly
        '
        Me.numElderly.Location = New System.Drawing.Point(420, 146)
        Me.numElderly.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.numElderly.Name = "numElderly"
        Me.numElderly.Size = New System.Drawing.Size(51, 22)
        Me.numElderly.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(339, 146)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 17)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Elderly"
        '
        'numStudent
        '
        Me.numStudent.Location = New System.Drawing.Point(420, 174)
        Me.numStudent.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.numStudent.Name = "numStudent"
        Me.numStudent.Size = New System.Drawing.Size(51, 22)
        Me.numStudent.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(339, 174)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 17)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Student"
        '
        'numAdult
        '
        Me.numAdult.Location = New System.Drawing.Point(420, 118)
        Me.numAdult.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.numAdult.Name = "numAdult"
        Me.numAdult.Size = New System.Drawing.Size(51, 22)
        Me.numAdult.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(339, 118)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 17)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Adult"
        '
        'ticketform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblTotPrice)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.numChild)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.numElderly)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.numStudent)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.numAdult)
        Me.Controls.Add(Me.Label6)
        Me.Name = "ticketform"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.numChild, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numElderly, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numStudent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numAdult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTotPrice As Label
    Friend WithEvents btnReturn As Button
    Friend WithEvents btnConfirm As Button
    Friend WithEvents numChild As NumericUpDown
    Friend WithEvents Label8 As Label
    Friend WithEvents numElderly As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents numStudent As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents numAdult As NumericUpDown
    Friend WithEvents Label6 As Label
End Class
