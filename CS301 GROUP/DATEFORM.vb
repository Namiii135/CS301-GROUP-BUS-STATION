Public Class DATEFORM
    ' List of available bus timeslots
    Public Property DateTimePicker1 As Object

    Private BusTimeslots As List(Of String) = New List(Of String) From {
        "7:30 AM", "8:00 AM", "8:30 AM", "9:00 AM", "9:30 AM", "10:00 AM", "10:30 AM", "11:00 AM",
        "11:30 AM", "12:00 PM", "12:30 PM", "1:00 PM", "1:30 PM", "2:00 PM", "2:30 PM", "3:00 PM",
        "3:30 PM", "4:00 PM", "4:30 PM", "5:00 PM", "5:30 PM", "6:00 PM", "6:30 PM", "7:00 PM", "7:30 PM"
    }

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Populate the timeslot listbox
        For Each timeslot As String In BusTimeslots
            lstTime.Items.Add(timeslot)
        Next

        ' Set the default date to today's date
        dtpDate.Value = Date.Today
    End Sub

    Private Sub btnConfirmSelection_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        ' Check if a timeslot is selected
        If lstTime.SelectedIndex = -1 Then
            MessageBox.Show("Please select a bus timeslot.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Get the selected date and timeslot
        Dim selectedDate As String = dtpDate.Value.ToString("dddd, dd MMMM yyyy")
        Dim selectedTimeslot As String = lstTime.SelectedItem.ToString()

        ' Update the order preview label
        lblPreview.Text = $"Date: {selectedDate}{Environment.NewLine}Time: {selectedTimeslot}"
        Dim receiptForm As New printreceiptconfirm
        printreceiptconfirm.TravelDate = dtpDate.Value

    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        ' Close the current form (you can replace this with navigation to another form if needed)
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Payment_Method.Show()
    End Sub
End Class
