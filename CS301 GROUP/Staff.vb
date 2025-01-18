Imports System.Data.OleDb

Public Class Staff
    ' Create a property to store the logged-in driver's ID
    Public Shared LoggedInDriverID As String

    Private Function AuthenticateUser(email As String, password As String) As Boolean
        Try
            ' Trim extra spaces
            email = email.Trim()
            password = password.Trim()

            Dim query As String = "SELECT COUNT(*) FROM [Bus_Driver] WHERE [STAFF_ID] = @ID AND [STAFF_IC] = @password"

            Using connection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\toxic\OneDrive\ドキュメント\Database BUS CSC301.accdb;")
                Using command As New OleDbCommand(query, connection)
                    command.Parameters.AddWithValue("@ID", email)
                    command.Parameters.AddWithValue("@password", password)

                    connection.Open()

                    Dim result As Integer = Convert.ToInt32(command.ExecuteScalar())

                    ' If successful, store the logged-in driver's ID
                    If result > 0 Then
                        LoggedInDriverID = email ' Save the driver's ID
                    End If

                    Return result > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
            Return False
        End Try
    End Function

    Private Sub btnLoginC_Click(sender As Object, e As EventArgs) Handles btnLoginC.Click
        Dim email As String = txtEmailC.Text
        Dim password As String = txtPasswordC.Text

        If AuthenticateUser(email, password) Then
            MessageBox.Show("Login successful!")
            Me.Hide()

            ' Show the Details_Driver form
            Dim detailsForm As New Details_Driver()
            detailsForm.Show()
        Else
            MessageBox.Show("Invalid email or password.")
        End If
    End Sub

    Private Sub BACKToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BACKToolStripMenuItem.Click
        HOME.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub txtEmailC_TextChanged(sender As Object, e As EventArgs) Handles txtEmailC.TextChanged

    End Sub
End Class
