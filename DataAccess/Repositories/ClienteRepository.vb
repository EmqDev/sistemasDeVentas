Imports System.Data
Imports System.Data.SqlClient
Imports DataAccess
Public Class ClienteRepository
    Inherits MasterRepository
    Implements IClienteRepository

    Private selectAll As String
    Private insert As String
    Private update As String
    Private delete As String

    Public Sub New()
        Me.selectAll = "select * from clientes"
        Me.insert = "insert into clientes values(@Cliente,@Telefono,@Correo)"
        Me.update = "update clientes set Cliente=@CLiente, Telefono=@Telefono, Correo=@Correo where ID=@ID"
        Me.delete = "delete from clientes where ID=@ID"
    End Sub


    Public Function GetAll() As IEnumerable(Of Cliente) Implements IGenericRepository(Of Cliente).GetAll
        Dim resultTable = ExecuteReader(selectAll)
        Dim listCliente = New List(Of Cliente)

        For Each item As DataRow In resultTable.Rows
            listCliente.Add(New Cliente With {
                            .Id = item(0),
                            .Cliente = item(1),
                            .Telefono = item(2),
                            .Correo = item(3)
                            })
        Next

        Return listCliente
    End Function

    Public Function Add(entity As Cliente) As Integer Implements IGenericRepository(Of Cliente).Add
        parameters = New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@Cliente", entity.Cliente))
        parameters.Add(New SqlParameter("@Telefono", entity.Telefono))
        parameters.Add(New SqlParameter("@Correo", entity.Correo))
        Return ExecuteNonQuery(insert)
    End Function

    Public Function Edit(entity As Cliente) As Integer Implements IGenericRepository(Of Cliente).Edit
        parameters = New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@ID", entity.Id))
        parameters.Add(New SqlParameter("@Cliente", entity.Cliente))
        parameters.Add(New SqlParameter("@Telefono", entity.Telefono))
        parameters.Add(New SqlParameter("@Correo", entity.Correo))
        Return ExecuteNonQuery(update)
    End Function

    Public Function Remove(id As Integer) As Integer Implements IGenericRepository(Of Cliente).Remove
        parameters = New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@ID", id))
        Return ExecuteNonQuery(delete)
    End Function
End Class
