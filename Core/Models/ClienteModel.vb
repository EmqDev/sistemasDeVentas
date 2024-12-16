Imports DataAccess
Imports System.ComponentModel.DataAnnotations


Public Class ClienteModel
    Private _id As Integer
    Private _cliente As String
    Private _telefono As String
    Private _correo As String
    Private _state As EntityState
    Private Repository As IClienteRepository


    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    <Required>
    <RegularExpression("^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$", ErrorMessage:="Ingresar solo letras, espacios y caracteres con acentos")>
    Public Property Cliente As String
        Get
            Return _cliente
        End Get
        Set(value As String)
            _cliente = value
        End Set
    End Property

    <Required>
    <RegularExpression("([0-9])+", ErrorMessage:="Ingresar solo numeros")>
    Public Property Telefono As String
        Get
            Return _telefono
        End Get
        Set(value As String)
            _telefono = value
        End Set
    End Property
    <Required>
    <EmailAddress>
    Public Property Correo As String
        Get
            Return _correo
        End Get
        Set(value As String)
            _correo = value
        End Set
    End Property

    Public Property State As EntityState
        Private Get
            Return _state
        End Get
        Set(value As EntityState)
            _state = value
        End Set
    End Property

    Public Sub New()
        Repository = New ClienteRepository()

    End Sub

    Public Function SaveChanges() As String
        Dim message As String = Nothing
        Try
            Dim clienteDataModel As New Cliente()
            clienteDataModel.Id = Id
            clienteDataModel.Cliente = Cliente
            clienteDataModel.Telefono = Telefono
            clienteDataModel.Correo = Correo

            Select Case State
                Case EntityState.Added
                    Repository.Add(clienteDataModel)
                    message = "Registro con exito"
                Case EntityState.Modified
                    Repository.Edit(clienteDataModel)
                    message = "Modificado con exito"
                Case EntityState.Deleted
                    Repository.Remove(Id)
                    message = "Se Elimino con exito"
            End Select
        Catch ex As Exception
            message = ex.ToString()
        End Try
        Return message
    End Function

    Public Function GetCliente() As List(Of ClienteModel)
        Dim listClienteDataModel = Repository.GetAll
        Dim listClienteViewModel = New List(Of ClienteModel)

        For Each item As Cliente In listClienteDataModel
            listClienteViewModel.Add(New ClienteModel With {
                                     .Id = item.Id,
                                     .Cliente = item.Cliente,
                                     .Telefono = item.Telefono,
                                     .Correo = item.Correo
                                     })
        Next
        Return listClienteViewModel
    End Function

    Public Function FindById(filter As String) As IEnumerable(Of ClienteModel)

        Return GetCliente().FindAll(Function(emp) emp.Id.ToString() = filter)


    End Function

End Class
