Public Class ticketform
    Private Const AdultTicketPrice As Decimal = 14D
    Private Const ElderlyTicketPrice As Decimal = 8D
    Private Const StudentTicketPrice As Decimal = 5D
    Private Const ChildTicketPrice As Decimal = 2D
    Private decTotPrice As Decimal = 0.0D

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        If decTotPrice = 0 Then
            MsgBox("Please enter a ticket before proceeding.", , "Error")
            Exit Sub
        End If

        Dim confirmation As DialogResult = MessageBox.Show($"Are you sure you want to confirm this order? {Environment.NewLine}" &
                                                       $"Total Ticket Price: RM {decTotPrice:F2}", "Confirm Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirmation = DialogResult.Yes Then
            Dim receiptForm As New printreceiptconfirm

            ' Create ticket details string
            Dim ticketDetails As String = $"Adult: {numAdult.Value}, Elderly: {numElderly.Value}, Student: {numStudent.Value}, Child: {numChild.Value}"


            ' Pass the data to ReceiptForm
            printreceiptconfirm.TicketDetails = ticketDetails
            printreceiptconfirm.TotalPrice = decTotPrice

            ' Display a confirmation message
            MessageBox.Show("Order has been confirmed successfully!", "Order Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Show ReceiptForm
            Me.Hide()
            DATEFORM.Show()
        Else
            MessageBox.Show("Order confirmation has been canceled.", "Order Canceled", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Me.Close()
        SelectBusType.Show()
    End Sub

    Private Sub ticketCalculation()

        Dim totAdultTicket As Decimal = numAdult.Value * AdultTicketPrice
        Dim totElderlyTicket As Decimal = numElderly.Value * ElderlyTicketPrice
        Dim totStudentTicket As Decimal = numStudent.Value * StudentTicketPrice
        Dim totChildTicket As Decimal = numChild.Value * ChildTicketPrice

        decTotPrice = totAdultTicket + totElderlyTicket + totStudentTicket + totChildTicket

        lblTotPrice.Text = $"Total price: ${decTotPrice:F2}"
    End Sub

    Private Sub numAdult_ValueChanged(sender As Object, e As EventArgs) Handles numAdult.ValueChanged
        ticketCalculation()
    End Sub

    Private Sub numElderly_ValueChanged(sender As Object, e As EventArgs) Handles numElderly.ValueChanged
        ticketCalculation()
    End Sub

    Private Sub numStudent_ValueChanged(sender As Object, e As EventArgs) Handles numStudent.ValueChanged
        ticketCalculation()
    End Sub

    Private Sub numChild_ValueChanged(sender As Object, e As EventArgs) Handles numChild.ValueChanged
        ticketCalculation()
    End Sub

    Private Sub Panel7_Paint(sender As Object, e As PaintEventArgs) Handles Panel7.Paint

    End Sub
End Class