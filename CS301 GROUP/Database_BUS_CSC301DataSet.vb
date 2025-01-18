Partial Class Database_BUS_CSC301DataSet
    Partial Public Class customerDataTable
        Private Sub customerDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.CUST_ICColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Public Class staffDataTable
        Private Sub staffDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.STAFF_IDColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Public Class customer_orderDataTable
        Private Sub customer_orderDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.CUST_ICColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub



    End Class
End Class
