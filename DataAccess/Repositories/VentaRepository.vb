Imports System.Data.SqlClient

Public Class VentaRepository
    Inherits MasterRepository
    Implements IVentaRepository

    Private selectAll As String
    Private insert As String
    Private update As String
    Private delete As String

    Public Sub New()
        Me.selectAll = "select * from ventas"
        Me.insert = "insert into ventas OUTPUT INSERTED.ID values(@IdCliente,@fecha,@total)"
        Me.update = "update ventasitems set IdCliente=@IdCliente, fecha=@fecha, total=@total  where ID=@ID"
        Me.delete = "delete from ventas where ID=@ID"
    End Sub

    Public Function GetAll() As IEnumerable(Of Venta) Implements IGenericRepository(Of Venta).GetAll
        Dim resultTable = ExecuteReader(selectAll)
        Dim listVentas = New List(Of Venta)

        For Each item As DataRow In resultTable.Rows
            listVentas.Add(New Venta With {
                            .ID = item(0),
                            .IdCliente = item(1),
                            .Fecha = item(2),
                            .Total = item(3)
                            })
        Next

        Return listVentas
    End Function

    Public Function Add(entity As Venta) As Integer Implements IGenericRepository(Of Venta).Add
        parameters = New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@IdCliente", entity.IdCliente))
        parameters.Add(New SqlParameter("@fecha", entity.Fecha))
        parameters.Add(New SqlParameter("@total", entity.Total))
        Return ExecuteNonQuery(insert)
    End Function

    Public Function Edit(entity As Venta) As Integer Implements IGenericRepository(Of Venta).Edit
        parameters = New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@ID", entity.ID))
        parameters.Add(New SqlParameter("@IdCliente", entity.IdCliente))
        parameters.Add(New SqlParameter("@fecha", entity.Fecha))
        parameters.Add(New SqlParameter("@total", entity.Total))
        Return ExecuteNonQuery(update)
    End Function

    Public Function Remove(id As Integer) As Integer Implements IGenericRepository(Of Venta).Remove
        parameters = New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@ID", id))
        Return ExecuteNonQuery(delete)
    End Function
End Class
