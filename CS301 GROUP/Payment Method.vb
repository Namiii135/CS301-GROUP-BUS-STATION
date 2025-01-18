Public Class Payment_Method
    Private Sub Payment_Method_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCash_Click(sender As Object, e As EventArgs) Handles btnCash.Click

    End Sub

    Private Sub btnCard_Click(sender As Object, e As EventArgs) Handles btnCard.Click
        Me.Hide()
        Card_Details.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub
End Class