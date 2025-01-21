<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class printreceiptconfirm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(printreceiptconfirm))
        Me.lblEmailCS = New System.Windows.Forms.Label()
        Me.lblDestination = New System.Windows.Forms.TextBox()
        Me.lblAgeCS = New System.Windows.Forms.Label()
        Me.lblNameCS = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblBusType = New System.Windows.Forms.TextBox()
        Me.lblPhoneNumberCS = New System.Windows.Forms.Label()
        Me.btnSignupCS = New System.Windows.Forms.Button()
        Me.lblPasswordCS = New System.Windows.Forms.Label()
        Me.lblTravelDate = New System.Windows.Forms.TextBox()
        Me.txtNameCS = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstTicketDetails = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTotalPrice = New System.Windows.Forms.TextBox()
        Me.lblSeatType = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtbusstation = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblEmailCS
        '
        Me.lblEmailCS.AutoSize = True
        Me.lblEmailCS.Location = New System.Drawing.Point(95, 249)
        Me.lblEmailCS.Name = "lblEmailCS"
        Me.lblEmailCS.Size = New System.Drawing.Size(114, 17)
        Me.lblEmailCS.TabIndex = 60
        Me.lblEmailCS.Text = "TIME AND DATE"
        '
        'lblDestination
        '
        Me.lblDestination.Location = New System.Drawing.Point(328, 124)
        Me.lblDestination.Name = "lblDestination"
        Me.lblDestination.ReadOnly = True
        Me.lblDestination.Size = New System.Drawing.Size(301, 22)
        Me.lblDestination.TabIndex = 59
        '
        'lblAgeCS
        '
        Me.lblAgeCS.AutoSize = True
        Me.lblAgeCS.Location = New System.Drawing.Point(95, 127)
        Me.lblAgeCS.Name = "lblAgeCS"
        Me.lblAgeCS.Size = New System.Drawing.Size(100, 17)
        Me.lblAgeCS.TabIndex = 58
        Me.lblAgeCS.Text = "DESTINATION"
        '
        'lblNameCS
        '
        Me.lblNameCS.AutoSize = True
        Me.lblNameCS.Location = New System.Drawing.Point(98, 86)
        Me.lblNameCS.Name = "lblNameCS"
        Me.lblNameCS.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNameCS.Size = New System.Drawing.Size(54, 17)
        Me.lblNameCS.TabIndex = 56
        Me.lblNameCS.Text = "GMAIL:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-7, -5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(809, 490)
        Me.PictureBox1.TabIndex = 71
        Me.PictureBox1.TabStop = False
        '
        'lblBusType
        '
        Me.lblBusType.Location = New System.Drawing.Point(328, 187)
        Me.lblBusType.Name = "lblBusType"
        Me.lblBusType.ReadOnly = True
        Me.lblBusType.Size = New System.Drawing.Size(301, 22)
        Me.lblBusType.TabIndex = 69
        '
        'lblPhoneNumberCS
        '
        Me.lblPhoneNumberCS.AutoSize = True
        Me.lblPhoneNumberCS.Location = New System.Drawing.Point(95, 187)
        Me.lblPhoneNumberCS.Name = "lblPhoneNumberCS"
        Me.lblPhoneNumberCS.Size = New System.Drawing.Size(80, 17)
        Me.lblPhoneNumberCS.TabIndex = 68
        Me.lblPhoneNumberCS.Text = "BUS TYPE:"
        '
        'btnSignupCS
        '
        Me.btnSignupCS.Location = New System.Drawing.Point(301, 404)
        Me.btnSignupCS.Name = "btnSignupCS"
        Me.btnSignupCS.Size = New System.Drawing.Size(89, 34)
        Me.btnSignupCS.TabIndex = 67
        Me.btnSignupCS.Text = "EXIT"
        Me.btnSignupCS.UseVisualStyleBackColor = True
        '
        'lblPasswordCS
        '
        Me.lblPasswordCS.AutoSize = True
        Me.lblPasswordCS.Location = New System.Drawing.Point(95, 306)
        Me.lblPasswordCS.Name = "lblPasswordCS"
        Me.lblPasswordCS.Size = New System.Drawing.Size(100, 17)
        Me.lblPasswordCS.TabIndex = 62
        Me.lblPasswordCS.Text = "TICKET TYPE:"
        '
        'lblTravelDate
        '
        Me.lblTravelDate.Location = New System.Drawing.Point(328, 249)
        Me.lblTravelDate.Name = "lblTravelDate"
        Me.lblTravelDate.ReadOnly = True
        Me.lblTravelDate.Size = New System.Drawing.Size(301, 22)
        Me.lblTravelDate.TabIndex = 61
        '
        'txtNameCS
        '
        Me.txtNameCS.Location = New System.Drawing.Point(328, 86)
        Me.txtNameCS.Name = "txtNameCS"
        Me.txtNameCS.ReadOnly = True
        Me.txtNameCS.Size = New System.Drawing.Size(301, 22)
        Me.txtNameCS.TabIndex = 57
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(249, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(199, 42)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "RECEIPT  "
        '
        'lstTicketDetails
        '
        Me.lstTicketDetails.FormattingEnabled = True
        Me.lstTicketDetails.ItemHeight = 16
        Me.lstTicketDetails.Location = New System.Drawing.Point(328, 294)
        Me.lstTicketDetails.Name = "lstTicketDetails"
        Me.lstTicketDetails.Size = New System.Drawing.Size(301, 52)
        Me.lstTicketDetails.TabIndex = 73
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(98, 370)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 17)
        Me.Label2.TabIndex = 74
        Me.Label2.Text = "TOTAL PRICE:"
        '
        'lblTotalPrice
        '
        Me.lblTotalPrice.Location = New System.Drawing.Point(328, 376)
        Me.lblTotalPrice.Name = "lblTotalPrice"
        Me.lblTotalPrice.ReadOnly = True
        Me.lblTotalPrice.Size = New System.Drawing.Size(301, 22)
        Me.lblTotalPrice.TabIndex = 75
        '
        'lblSeatType
        '
        Me.lblSeatType.Location = New System.Drawing.Point(328, 220)
        Me.lblSeatType.Name = "lblSeatType"
        Me.lblSeatType.ReadOnly = True
        Me.lblSeatType.Size = New System.Drawing.Size(301, 22)
        Me.lblSeatType.TabIndex = 77
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(95, 220)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 17)
        Me.Label3.TabIndex = 76
        Me.Label3.Text = "SEAT TYPE:"
        '
        'txtbusstation
        '
        Me.txtbusstation.Location = New System.Drawing.Point(328, 154)
        Me.txtbusstation.Name = "txtbusstation"
        Me.txtbusstation.ReadOnly = True
        Me.txtbusstation.Size = New System.Drawing.Size(301, 22)
        Me.txtbusstation.TabIndex = 79
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(95, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 17)
        Me.Label4.TabIndex = 78
        Me.Label4.Text = "BUS STATION"
        '
        'printreceiptconfirm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(725, 450)
        Me.Controls.Add(Me.txtbusstation)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblSeatType)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblTotalPrice)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lstTicketDetails)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblEmailCS)
        Me.Controls.Add(Me.lblDestination)
        Me.Controls.Add(Me.lblAgeCS)
        Me.Controls.Add(Me.lblNameCS)
        Me.Controls.Add(Me.lblBusType)
        Me.Controls.Add(Me.lblPhoneNumberCS)
        Me.Controls.Add(Me.btnSignupCS)
        Me.Controls.Add(Me.lblPasswordCS)
        Me.Controls.Add(Me.lblTravelDate)
        Me.Controls.Add(Me.txtNameCS)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "printreceiptconfirm"
        Me.Text = "printreceiptconfirm"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblEmailCS As Label
    Friend WithEvents lblDestination As TextBox
    Friend WithEvents lblAgeCS As Label
    Friend WithEvents lblNameCS As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblBusType As TextBox
    Friend WithEvents lblPhoneNumberCS As Label
    Friend WithEvents btnSignupCS As Button
    Friend WithEvents lblPasswordCS As Label
    Friend WithEvents lblTravelDate As TextBox
    Friend WithEvents txtNameCS As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lstTicketDetails As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTotalPrice As TextBox
    Friend WithEvents lblSeatType As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtbusstation As TextBox
    Friend WithEvents Label4 As Label
End Class
