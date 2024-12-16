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
        Me.insert = "insert into ventasitems values(@IdCliente,@IdVenta,@IdPrecioUnitario,@Cantidad,@PrecioTotal)"
        Me.update = "update ventasitems set IdCliente=@IdCliente, IdVenta=@IdVenta, IdPrecioUnitario=@IdPrecioUnitario, Cantidad=@Cantidad,PrecioTotal=@PrecioTotal  where ID=@ID"
        Me.delete = "delete from ventasitems where ID=@ID"
    End Sub



    Public Function GetAll() As IEnumerable(Of VentaItems) Implements IGenericRepository(Of VentaItems).GetAll
        Throw New NotImplementedException()
    End Function

    Public Function Add(entity As VentaItems) As Integer Implements IGenericRepository(Of VentaItems).Add
        Throw New NotImplementedException()
    End Function

    Public Function Edit(entity As VentaItems) As Integer Implements IGenericRepository(Of VentaItems).Edit
        Throw New NotImplementedException()
    End Function

    Public Function Remove(id As Integer) As Integer Implements IGenericRepository(Of VentaItems).Remove
        Throw New NotImplementedException()
    End Function
End Class
