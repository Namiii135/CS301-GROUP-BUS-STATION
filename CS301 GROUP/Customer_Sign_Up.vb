Imports System.Data.OleDb

Public Class Customer_Sign_Up


    Private Sub btnSignupCS_Click(sender As Object, e As EventArgs) Handles btnSignupCS.Click



        ' Connection string to the database
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\toxic\Downloads\INPUT DATA CSC301\Database BUS CSC301.accdb;"
        Dim query As String = "INSERT INTO customer ([Name], [PHONENUM], [IC], [EMAIL], [PASSWORD]) 
        VALUES (@Name, @PhoneNumber, @ICNumber, @Email, @Password);"

        ' Validate user input
        ' Validate user input
        If String.IsNullOrWhiteSpace(txtICCS.Text) Or String.IsNullOrWhiteSpace(txtNameCS.Text) Or
           String.IsNullOrWhiteSpace(txtPhoneNumberCS.Text) Or String.IsNullOrWhiteSpace(txtEmailCS.Text) Or
           String.IsNullOrWhiteSpace(txtPasswordCS.Text) Then
            MessageBox.Show("Please enter all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If String.IsNullOrWhiteSpace(txtICCS.Text) Then
            MessageBox.Show("IC Number is required and cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If


        Using connection As New OleDbConnection(connectionString)
            Try
                connection.Open()

                ' Create the command with parameters
                Using command As New OleDbCommand(query, connection)
                    ' Replace parameters with user input
                    command.Parameters.AddWithValue("@Name", txtNameCS.Text)
                    command.Parameters.AddWithValue("@PhoneNumber", txtPhoneNumberCS.Text)
                    command.Parameters.AddWithValue("@ICNumber", txtICCS.Text)
                    command.Parameters.AddWithValue("@Email", txtEmailCS.Text)
                    command.Parameters.AddWithValue("@Password", txtPasswordCS.Text)

                    ' Execute the query
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    ' Check if the insertion was successful
                    If rowsAffected > 0 Then
                        MessageBox.Show("Sign-up successful! You can now log in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Sign-up failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class

