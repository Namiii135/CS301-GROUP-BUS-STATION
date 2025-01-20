Public Class Form1
    Private SelectedOption As String


    Private Sub DateForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If SelectedOption = "option1" Then
            lstTime.Items.AddRange({"7:30 AM", "8:00 AM", "8:30 AM", "9:00 AM", "9:30 AM", "10:00 AM", "10:30 AM", "11:00 AM", "11:30 AM", "12:00 PM", "12:30 PM", "13:00 PM", "13:30 PM", "14:00 PM", "14:30 PM", "15:00 PM", "15:30 PM", "16:00 PM", "16:30 PM", "17:00 PM", "17:30 PM", "18:00 PM", "18:30 PM", "19:00 PM", "19:30 PM"})
        ElseIf SelectedOption = "option2" Then
            lstTime.Items.AddRange({"7:00 AM", "7:15 AM", "7:30 AM", "7:45 AM", "8:00 AM", "8:15 AM", "8:30 AM", "8:45 AM", "9:00 AM", "9:15 AM", "9:30 AM", "9:45 AM", "10:00 AM", "10:15 AM", "10:30 AM", "10:45 AM", "11:00 AM", "11:15 AM", "11:30 AM", "11:45 AM", "12:00 PM"})
        End If
        If lstTime.Items.Count > 0 Then
            lstTime.SelectedIndex = 0
        End If
    End Sub

    Public Sub New(form As SelectBusType)
        InitializeComponent()
        If form Is Nothing Then
            Throw New ArgumentNullException(NameOf(form), "The form argument cannot be null.")
        End If
        SelectedOption = form.SelectedOption
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        If lstTime.SelectedIndex = -1 Then
            MsgBox("Please Select A TimeSlot/Date", , "Error")
            Exit Sub
        End If

        Me.Hide()
        ticketform.Show()
    End Sub

    Private Sub lstTime_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstTime.SelectedIndexChanged
        updateLabel()
    End Sub

    Public Sub updateLabel()
        Dim selectedDate As String = dtpDate.Value.ToString("dddd, MMMM dd, yyyy")
        Dim selectedTimeslot As String = If(lstTime.SelectedItem?.ToString(), "No timeslot selected")

        lblPreview.Text = $"You Selected: {Environment.NewLine} {selectedDate} {Environment.NewLine} {selectedTimeslot}"
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Me.Close()
        SelectBusType.Show()
    End Sub

End Class
