Public Class TicketForm
    Private Const AdultTicketPrice As Decimal = 14D
    Private Const ElderlyTicketPrice As Decimal = 8D
    Private Const StudentTicketPrice As Decimal = 5D
    Private Const ChildTicketPrice As Decimal = 2D
    Private decTotPrice As Decimal = 0.0D

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim confirmation As DialogResult = DialogResult = MessageBox.Show("Are you sure you want to confirm this order?{Environment.Newline}" & $"Total Ticket Price: ${decTotPrice: F2}", "Confirm Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirmation = DialogResult.Yes Then
            MessageBox.Show("Order has been confirmed successfully!", "Order Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf confirmation = DialogResult.No Then
            MessageBox.Show("Order confirmation has been canceled.", "Order Canceled", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        Me.Hide()
        Payment_Method.Show()

    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Me.Close()
        DateForm.Show()
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

    Private Sub TicketForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class