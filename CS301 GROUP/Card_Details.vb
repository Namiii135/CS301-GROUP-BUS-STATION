Imports System.Data.OleDb

Public Class Card_Details

    ' Authenticate the user's card details based on email
    Private Function AuthenticateUser(card_number As String, expiry_date As String, cvv_cvc As String) As Boolean
        Dim email As String = Customer.LoggedInCustomeremail

        Try
            ' Trim any extra spaces from inputs
            card_number = card_number.Trim()
            expiry_date = expiry_date.Trim()
            cvv_cvc = cvv_cvc.Trim()

            ' Correct SQL query to check all card details for the logged-in customer
            Dim query As String = "SELECT COUNT(*) 
                                    FROM [CARD_DETAILS] AS c
                                    INNER JOIN [customer] AS co ON c.[EMAIL] = co.[EMAIL]
                                    WHERE co.[EMAIL] = @EMAIL 
                                    AND c.[card_number] = @cardnum
                                    AND c.[expiry_date] = @expiredate
                                    AND c.[cvv_cvc] = @CVV;"

            ' Database connection
            Using connection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\toxic\Downloads\INPUT DATA CSC301 (1)\DATABASE BUS STATION  CSC 301.accdb")
                Using command As New OleDbCommand(query, connection)
                    ' Add parameters to prevent SQL injection
                    command.Parameters.AddWithValue("@EMAIL", email)
                    command.Parameters.AddWithValue("@cardnum", card_number)
                    command.Parameters.AddWithValue("@expiredate", expiry_date)
                    command.Parameters.AddWithValue("@CVV", cvv_cvc)

                    ' Open the database connection
                    connection.Open()

                    ' Execute the query and get the result
                    Dim result As Integer = Convert.ToInt32(command.ExecuteScalar())

                    ' If the result is greater than 0, it means matching card details were found
                    Return result > 0
                End Using
            End Using
        Catch ex As Exception
            ' Show detailed error message for debugging
            MessageBox.Show("Error: " & ex.Message)
            Return False
        End Try
    End Function

    ' Event handler for the Next button click
    Private Sub btnNextP_Click(sender As Object, e As EventArgs) Handles btnNextP.Click
        ' Fetch input values from textboxes
        Dim card_number As String = txtCardNumber.Text
        Dim expiry_date As String = expired_date.Text
        Dim cvv_cvc As String = txtCvvCvc.Text

        ' Authenticate user
        If AuthenticateUser(card_number, expiry_date, cvv_cvc) Then
            MessageBox.Show("Card details verified successfully!")
            Me.Hide()  ' Hide the current form or proceed to next form
            printreceipt.Show()
        Else
            MessageBox.Show("Invalid card details. Please check and try again.")
        End If
    End Sub

    ' Event handler for form load (if needed)
    Private Sub Card_Details_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialization code if needed
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub
End Class
