Public Class printreceiptconfirm
    ' Properties to receive data from other forms
    Public Property cust_email As String
    Public Property Destination As String
    Public Property BusStation As String
    Public Property BusType As String
    Public Property SeatType As String
    Public Property TicketDetails As String
    Public Property TotalPrice As Decimal
    Public Property TravelDate As DateTime

    Private Sub ReceiptForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Display the data in the form's controls
        txtNameCS.Text = cust_email
        lblDestination.Text = Destination
        lblBusType.Text = BusType
        txtbusstation.Text = BusStation
        lblSeatType.Text = SeatType
        Dim ticketDetailsArray() As String = TicketDetails.Split(",")
        For Each detail As String In ticketDetailsArray
            lstTicketDetails.Items.Add(detail.Trim()) ' Add each ticket type to the ListBox
        Next
        lblTotalPrice.Text = $"Total Price: RM {TotalPrice:F2}"
        lblTravelDate.Text = TravelDate.ToString("dd MMM yyyy, hh:mm tt")
    End Sub

    Private Sub lblPhoneNumberCS_Click(sender As Object, e As EventArgs) Handles lblPhoneNumberCS.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub lblTravelDate_TextChanged(sender As Object, e As EventArgs) Handles lblTravelDate.TextChanged

    End Sub

    Private Sub lblAgeCS_Click(sender As Object, e As EventArgs) Handles lblAgeCS.Click

    End Sub

    Private Sub lblDestination_TextChanged(sender As Object, e As EventArgs) Handles lblDestination.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtbusstation.TextChanged

    End Sub

    Private Sub lblTicketDetails_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstTicketDetails.SelectedIndexChanged

    End Sub

    Private Sub txtNameCS_TextChanged(sender As Object, e As EventArgs) Handles txtNameCS.TextChanged

    End Sub

    Private Sub btnSignupCS_Click(sender As Object, e As EventArgs) Handles btnSignupCS.Click
        Application.Exit()
    End Sub
End Class
