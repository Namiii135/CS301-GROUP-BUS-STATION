Imports System.Data.OleDb

Public Class Details_Driver
    ' Subroutine to load passengers for the given driver ID
    Private Sub LoadPassengers(driverID As String)
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\toxic\Downloads\INPUT DATA CSC301\Database BUS CSC301.accdb;"
        Dim query As String = "SELECT c.[NAME], c.[PHONENUM]
                               FROM ([customer] AS c
                               INNER JOIN [customer_order] AS co ON c.[CUST_IC] = co.[CUST_IC])
                               INNER JOIN [staff] AS s ON co.[STAFF_ID] = s.[STAFF_ID]
                               WHERE s.[STAFF_ID] = @DriverID;"

        ' Clear the ListBox before loading new data
        ListBoxPassengers.Items.Clear()

        Using connection As New OleDbConnection(connectionString)
            Try
                connection.Open()

                ' Create the command and set the parameter
                Using command As New OleDbCommand(query, connection)
                    command.Parameters.AddWithValue("@DriverID", driverID)

                    ' Execute the command and read results
                    Using reader As OleDbDataReader = command.ExecuteReader()
                        If reader.HasRows Then
                            While reader.Read()
                                Dim passengerInfo As String = $"Name: {reader("NAME")}, Phone: {reader("PHONENUM")}"
                                ListBoxPassengers.Items.Add(passengerInfo)
                            End While

                            ' Notify user if passengers are successfully loaded
                            If ListBoxPassengers.Items.Count > 0 Then
                                MessageBox.Show("Passengers loaded successfully!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        Else
                            MessageBox.Show("No customers assigned to this driver.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End Using
                End Using

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' Event handler for form load
    Private Sub Details_Driver_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load passengers for the logged-in driver ID by default
        Dim driverID As String = Staff.LoggedInDriverID
        txtDriverID.Text = "DRIVER ID IS" & driverID ' Display the current driver ID in the text box
        LoadPassengers(driverID)
    End Sub



    ' Event handler for "Back" button to return to the login form
    Private Sub button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Staff.Show()
    End Sub
End Class
