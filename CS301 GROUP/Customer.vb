﻿Imports System.Data.OleDb

Public Class Customer



    Private Function AuthenticateUser(email As String, password As String) As Boolean
        Try
            ' Trim any extra spaces
            email = email.Trim()
            password = password.Trim()

            ' Use SQL query to find a user with matching email and password
            Dim query As String = "SELECT COUNT(*) FROM [customer] WHERE [EMAIL] = @EMAIL AND [PASSWORD] = @password"

            ' Open database connection
            Using connection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\toxic\Downloads\INPUT DATA CSC301\Database BUS CSC301.accdb;")
                Using command As New OleDbCommand(query, connection)
                    ' Add parameters to prevent SQL injection
                    command.Parameters.AddWithValue("@EMAIL", email)
                    command.Parameters.AddWithValue("@password", password)

                    connection.Open()

                    ' Execute the query
                    Dim result As Integer = Convert.ToInt32(command.ExecuteScalar())

                    ' Return true if a match is found
                    Return result > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
            Return False
        End Try
    End Function

    Private Sub btnSignupC_Click(sender As Object, e As EventArgs) Handles btnSignupC.Click
        ' Open Customer Signup Form
        Customer_Sign_Up.Show()
        Me.Hide()  ' Hide current form
    End Sub

    Private Sub txtPasswordC_TextChanged(sender As Object, e As EventArgs) Handles txtPasswordC.TextChanged
        ' Handle password input change if needed
    End Sub

    Private Sub BACKToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BACKToolStripMenuItem.Click
        HOME.Show()
        Me.Hide()
    End Sub

    Private Sub EXITToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EXITToolStripMenuItem.Click
        Application.Exit()
    End Sub


    Private Sub btnLoginC_Click(sender As Object, e As EventArgs) Handles btnLoginC.Click
        Dim email As String = txtEmailC.Text
        Dim password As String = txtPasswordC.Text

        If AuthenticateUser(email, password) Then
            MessageBox.Show("Login successful!")
            Me.Hide()
        Else
            MessageBox.Show("Invalid email or password.")
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblORC_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtEmailC_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblPasswordC_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblEmailC_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub
End Class
