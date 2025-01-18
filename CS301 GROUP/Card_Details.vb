Public Class Card_Details
    Private Sub txtCardHolderName_TextChanged(sender As Object, e As EventArgs) Handles txtCardHolderName.TextChanged

    End Sub

    Private Sub txtCardNumber_TextChanged(sender As Object, e As EventArgs) Handles txtCardNumber.TextChanged
        If txtCardNumber.Text.Length > 16 Then
            MessageBox.Show("Card number cannot be more than 16 digits.")
            txtCardNumber.Text = txtCardNumber.Text.Substring(0, 16)
        End If
    End Sub

    Private Sub txtExpDate_TextChanged(sender As Object, e As EventArgs) Handles txtExpDate.TextChanged
        If txtExpDate.Text.Length > 5 Then
            MessageBox.Show("Expiration date must follow MM/YY format.")
            txtExpDate.Text = txtExpDate.Text.Substring(0, 5) ' Limit input to MM/YY
        End If
    End Sub

    Private Sub txtCode_TextChanged(sender As Object, e As EventArgs) Handles txtCode.TextChanged
        If txtCode.Text.Length > 3 Then
            MessageBox.Show("Security code must be 3 digits.")
            txtCode.Text = txtCode.Text.Substring(0, 3)
        End If
    End Sub

    Private Sub btnClearP_Click(sender As Object, e As EventArgs) Handles btnClearP.Click
        txtCardHolderName.Clear()
        txtCardNumber.Clear()
        txtExpDate.Clear()
        txtCode.Clear()
    End Sub

    Private Sub btnNextP_Click(sender As Object, e As EventArgs) Handles btnNextP.Click
        If ValidateCardDetails() Then
            MessageBox.Show("Payment details are valid. Proceeding with payment.")
            ' You can proceed to the next step, e.g., confirmation screen or payment processing
        End If
        Me.Hide()
        printreceipt.Show()
    End Sub

    ' Function to validate all card details
    Private Function ValidateCardDetails() As Boolean
        ' Ensure all fields are filled
        If String.IsNullOrEmpty(txtCardHolderName.Text) Then
            MessageBox.Show("Card holder name is required.")
            Return False
        End If

        If String.IsNullOrEmpty(txtCardNumber.Text) OrElse txtCardNumber.Text.Length <> 16 Then
            MessageBox.Show("Please enter a valid 16-digit card number.")
            Return False
        End If

        If String.IsNullOrEmpty(txtExpDate.Text) OrElse txtExpDate.Text.Length <> 5 Then
            MessageBox.Show("Please enter a valid expiration date in MM/YY format.")
            Return False
        End If

        If String.IsNullOrEmpty(txtCode.Text) OrElse txtCode.Text.Length <> 3 Then
            MessageBox.Show("Please enter a valid 3-digit security code.")
            Return False
        End If

        Return True
    End Function

    Private Sub BACKToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BACKToolStripMenuItem.Click

    End Sub

    Private Sub EXITToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EXITToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub Card_Details_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class