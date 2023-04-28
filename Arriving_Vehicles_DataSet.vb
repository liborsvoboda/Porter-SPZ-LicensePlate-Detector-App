Partial Class Arriving_Vehicles_DataSet
    Partial Class Arriving_VehiclesDataTable

        Private Sub Arriving_VehiclesDataTable_ColumnChanging(sender As Object, e As Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.movement_dateColumn.ColumnName) Then
                'Zde přidejte uživatelský kód
            End If

        End Sub

    End Class

End Class
