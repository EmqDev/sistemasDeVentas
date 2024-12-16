
Imports System.Data.SqlClient


Public Class ProductoRepository
    Inherits MasterRepository
    Implements IProductoRepository

    Private selectAll As String
    Private insert As String
    Private update As String
    Private delete As String

    Public Sub New()
        Me.selectAll = "select * from productos"
        Me.insert = "insert into productos values(@Nombre,@Precio,@Categoria)"
        Me.update = "update productos set Nombre=@Nombre, Precio=@Precio, Categoria=@Categoria where ID=@ID"
        Me.delete = "delete from productos where ID=@ID"
    End Sub


    Public Function GetAll() As IEnumerable(Of Producto) Implements IGenericRepository(Of Producto).GetAll
        Dim resultTable = ExecuteReader(selectAll)
        Dim listProducto = New List(Of Producto)

        For Each item As DataRow In resultTable.Rows
            listProducto.Add(New Producto With {
                            .ID = item(0),
                            .Nombre = item(1),
                            .Precio = item(2),
                            .Categoria = item(3)
                            })
        Next

        Return listProducto
    End Function

    Public Function Add(entity As Producto) As Integer Implements IGenericRepository(Of Producto).Add
        parameters = New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@Nombre", entity.Nombre))
        parameters.Add(New SqlParameter("@Precio", entity.Precio))
        parameters.Add(New SqlParameter("@Categoria", entity.Categoria))
        Return ExecuteNonQuery(insert)
    End Function

    Public Function Edit(entity As Producto) As Integer Implements IGenericRepository(Of Producto).Edit
        parameters = New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@ID", entity.ID))
        parameters.Add(New SqlParameter("@Nombre", entity.Nombre))
        parameters.Add(New SqlParameter("@Precio", entity.Precio))
        parameters.Add(New SqlParameter("@Categoria", entity.Categoria))
        Return ExecuteNonQuery(update)
    End Function

    Public Function Remove(id As Integer) As Integer Implements IGenericRepository(Of Producto).Remove
        parameters = New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@ID", id))
        Return ExecuteNonQuery(delete)
    End Function



End Class
