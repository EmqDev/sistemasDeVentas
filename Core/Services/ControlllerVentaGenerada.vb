Imports DataAccess
Public Module ControlllerVentaGenerada

    Public Function AddVentaYItems(venta As VentaModel, items As List(Of VentaItemsModel)) As String

        Try
            Dim respuesta As String
            Dim idVentaGenerado As Integer = venta.SaveChanges()

            For Each item As VentaItemsModel In items
                item.IdVenta = idVentaGenerado
                item.SaveChanges()

            Next

            respuesta = "Venta y items guardados correctamente."
            Return respuesta
        Catch ex As Exception
            Return ex.Message
        End Try

    End Function




End Module
