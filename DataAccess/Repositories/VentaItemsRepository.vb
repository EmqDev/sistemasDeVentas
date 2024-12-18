Imports System.Data.SqlClient

Public Class VentaItemsRepository
    Inherits MasterRepository
    Implements IVentaItemsRepository

    Private selectAll As String
    Private insert As String
    Private update As String
    Private delete As String

    Public Sub New()
        Me.selectAll = "select * from ventasitems"
        Me.insert = "insert into ventasitems values(@IdVenta,@IdProducto,@PrecioUnitario,@Cantidad,@PrecioTotal)"
        Me.update = "update ventasitems set IdVenta=@IdVenta, IdProducto=@IdProducto, PrecioUnitario=@PrecioUnitario, Cantidad=@Cantidad,PrecioTotal=@PrecioTotal  where ID=@ID"
        Me.delete = "delete from ventasitems where ID=@ID"
    End Sub



    Public Function GetAll() As IEnumerable(Of VentaItems) Implements IGenericRepository(Of VentaItems).GetAll
        Dim resultTable = ExecuteReader(selectAll)
        Dim listVentasItems = New List(Of VentaItems)

        For Each item As DataRow In resultTable.Rows
            listVentasItems.Add(New VentaItems With {
                            .ID = item(0),
                            .IdVenta = item(1),
                            .IdProducto = item(2),
                            .PrecioUnitario = item(3),
                            .Cantidad = item(4),
                            .PrecioTotal = item(5)
                            })
        Next

        Return listVentasItems
    End Function

    Public Function Add(entity As VentaItems) As Integer Implements IGenericRepository(Of VentaItems).Add
        parameters = New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@IdVenta", entity.IdVenta))
        parameters.Add(New SqlParameter("@IdProducto", entity.IdProducto))
        parameters.Add(New SqlParameter("@PrecioUnitario", entity.PrecioUnitario))
        parameters.Add(New SqlParameter("@Cantidad", entity.Cantidad))
        parameters.Add(New SqlParameter("@PrecioTotal", entity.PrecioTotal))
        Return ExecuteNonQuery(insert)
    End Function

    Public Function Edit(entity As VentaItems) As Integer Implements IGenericRepository(Of VentaItems).Edit
        parameters = New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@ID", entity.ID))
        parameters.Add(New SqlParameter("@IdVenta", entity.IdVenta))
        parameters.Add(New SqlParameter("@IdProducto", entity.IdProducto))
        parameters.Add(New SqlParameter("@PrecioUnitario", entity.PrecioUnitario))
        parameters.Add(New SqlParameter("@Cantidad", entity.Cantidad))
        parameters.Add(New SqlParameter("@PrecioTotal", entity.PrecioTotal))
        Return ExecuteNonQuery(update)
    End Function

    Public Function Remove(id As Integer) As Integer Implements IGenericRepository(Of VentaItems).Remove
        parameters = New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@ID", id))
        Return ExecuteNonQuery(delete)
    End Function
End Class
