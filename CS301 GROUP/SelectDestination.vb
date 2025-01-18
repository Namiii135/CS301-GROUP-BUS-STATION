Public Class SelectDestination
    Public SelectedDestination As String
    Public strBusStation As String

    Private Sub RadioButtonJohor_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonJohor.CheckedChanged
        SelectedDestination = "Johor"
        ComboBoxJohor.Visible = RadioButtonJohor.Checked
    End Sub

    Private Sub RadioButtonKelantan_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonKelantan.CheckedChanged
        SelectedDestination = "Kelantan"
        comboBoxKelantan.Visible = RadioButtonKelantan.Checked
    End Sub

    Private Sub RadioButtonKedah_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonKedah.CheckedChanged
        SelectedDestination = "Kedah"
        ComboBoxKedah.Visible = RadioButtonKedah.Checked
    End Sub

    Private Sub RadioButtonNS_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonNS.CheckedChanged
        SelectedDestination = "Negeri Sembilan"
        ComboBoxNS.Visible = RadioButtonNS.Checked
    End Sub

    Private Sub RadioButtonPahang_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonPahang.CheckedChanged
        SelectedDestination = "Pahang"
        ComboBoxPahang.Visible = RadioButtonPahang.Checked
    End Sub

    Private Sub RadioButtonTerengganu_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonTerengganu.CheckedChanged
        SelectedDestination = "Terengganu"
        ComboBoxTerengganu.Visible = RadioButtonTerengganu.Checked
    End Sub

    Private Sub RadioButtonSelangor_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonSelangor.CheckedChanged
        SelectedDestination = "Selangor"
        ComboBoxSelangor.Visible = RadioButtonSelangor.Checked
    End Sub

    Private Sub RadioButtonPerlis_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonPerlis.CheckedChanged
        SelectedDestination = "Perlis"
        ComboBoxPerlis.Visible = RadioButtonPerlis.Checked
    End Sub

    Private Sub RadioButtonPerak_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonPerak.CheckedChanged
        SelectedDestination = "Perak"
        ComboBoxPerak.Visible = RadioButtonPerak.Checked
    End Sub

    Private Sub RadioButtonPenang_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonPenang.CheckedChanged
        SelectedDestination = "Penang"
        ComboBoxPenang.Visible = RadioButtonPenang.Checked
    End Sub

    Private Sub RadioButtonKL_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonKL.CheckedChanged
        SelectedDestination = "Kuala Lumpur"
        ComboBoxKL.Visible = RadioButtonKL.Checked
    End Sub

    Private Sub RadioButtonPutrajaya_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonPutrajaya.CheckedChanged
        SelectedDestination = "Putrajaya"
        ComboBoxPutrajaya.Visible = RadioButtonPutrajaya.Checked
    End Sub

    Private Sub comboBoxKelantan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBoxKelantan.SelectedIndexChanged
        If comboBoxKelantan.SelectedIndex <> -1 Then
            strBusStation = comboBoxKelantan.Items(comboBoxKelantan.SelectedIndex).ToString()
        End If
    End Sub

    Private Sub ComboBoxJohor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxJohor.SelectedIndexChanged
        If ComboBoxJohor.SelectedIndex <> -1 Then
            strBusStation = ComboBoxJohor.Items(ComboBoxJohor.SelectedIndex).ToString()
        End If
    End Sub

    Private Sub ComboBoxPahang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxPahang.SelectedIndexChanged
        If ComboBoxPahang.SelectedIndex <> -1 Then
            strBusStation = ComboBoxPahang.Items(ComboBoxPahang.SelectedIndex).ToString()
        End If
    End Sub

    Private Sub ComboBoxTerengganu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxTerengganu.SelectedIndexChanged
        If ComboBoxTerengganu.SelectedIndex <> -1 Then
            strBusStation = ComboBoxTerengganu.Items(ComboBoxTerengganu.SelectedIndex).ToString()
        End If
    End Sub

    Private Sub ComboBoxNS_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxNS.SelectedIndexChanged
        If ComboBoxNS.SelectedIndex <> -1 Then
            strBusStation = ComboBoxNS.Items(ComboBoxNS.SelectedIndex).ToString()
        End If
    End Sub

    Private Sub ComboBoxKedah_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxKedah.SelectedIndexChanged
        If ComboBoxKedah.SelectedIndex <> -1 Then
            strBusStation = ComboBoxKedah.Items(ComboBoxKedah.SelectedIndex).ToString()
        End If
    End Sub

    Private Sub ComboBoxSelangor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxSelangor.SelectedIndexChanged
        If ComboBoxSelangor.SelectedIndex <> -1 Then
            strBusStation = ComboBoxSelangor.Items(ComboBoxSelangor.SelectedIndex).ToString()
        End If
    End Sub

    Private Sub ComboBoxPerlis_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxPerlis.SelectedIndexChanged
        If ComboBoxPerlis.SelectedIndex <> -1 Then
            strBusStation = ComboBoxPerlis.Items(ComboBoxPerlis.SelectedIndex).ToString()
        End If
    End Sub

    Private Sub ComboBoxPerak_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxPerak.SelectedIndexChanged
        If ComboBoxPerak.SelectedIndex <> -1 Then
            strBusStation = ComboBoxPerak.Items(ComboBoxPerak.SelectedIndex).ToString()
        End If
    End Sub

    Private Sub ComboBoxKL_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxKL.SelectedIndexChanged
        If ComboBoxKL.SelectedIndex <> -1 Then
            strBusStation = ComboBoxKL.Items(ComboBoxKL.SelectedIndex).ToString()
        End If
    End Sub

    Private Sub ComboBoxPenang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxPenang.SelectedIndexChanged
        If ComboBoxPenang.SelectedIndex <> -1 Then
            strBusStation = ComboBoxPenang.Items(ComboBoxPenang.SelectedIndex).ToString()
        End If
    End Sub

    Private Sub ComboBoxPutrajaya_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxPutrajaya.SelectedIndexChanged
        If ComboBoxPutrajaya.SelectedIndex <> -1 Then
            strBusStation = ComboBoxPutrajaya.Items(ComboBoxPutrajaya.SelectedIndex).ToString()
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Me.Hide()
        SelectBusType.Show()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Customer.Show()
    End Sub


End Class
