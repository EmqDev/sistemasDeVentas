Imports DataAccess
Imports System.ComponentModel.DataAnnotations
Public Class ProductoModel
    Private _id As Integer
    Private _nombre As String
    Private _precio As Double
    Private _categoria As String
    Private _state As EntityState
    Private Repository As IProductoRepository


    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    <Required>
    <RegularExpression("^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$", ErrorMessage:="Ingresar solo letras")>
    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    <Required>
    Public Property Precio As Double
        Get
            Return _precio
        End Get
        Set(value As Double)
            _precio = value
        End Set
    End Property

    <Required>
    Public Property Categoria As String
        Get
            Return _categoria
        End Get
        Set(value As String)
            _categoria = value
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
        Repository = New ProductoRepository()

    End Sub

    Public Function SaveChanges() As String
        Dim message As String = Nothing
        Try
            Dim productoDataModel As New Producto()
            productoDataModel.ID = Id
            productoDataModel.Nombre = Nombre
            productoDataModel.Precio = Precio
            productoDataModel.Categoria = Categoria


            Select Case State
                Case EntityState.Added
                    Repository.Add(productoDataModel)
                    message = "Registro con exito"
                Case EntityState.Modified
                    Repository.Edit(productoDataModel)
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

    Public Function GetProducto() As List(Of ProductoModel)
        Dim listProductoDataModel = Repository.GetAll
        Dim listProductoViewModel = New List(Of ProductoModel)

        For Each item As Producto In listProductoDataModel
            listProductoViewModel.Add(New ProductoModel With {
                                     .Id = item.ID,
                                     .Nombre = item.Nombre,
                                     .Precio = item.Precio,
                                     .Categoria = item.Categoria
                                     })
        Next
        Return listProductoViewModel
    End Function

    Public Function FindById(filter As String) As ProductoModel

        Return GetProducto().Find(Function(prod) prod.Id.ToString() = filter)

    End Function

    Public Function FindByCategory(filter As String) As IEnumerable(Of ProductoModel)

        Return GetProducto().FindAll(Function(prod) prod.Categoria.Contains(filter))

    End Function

End Class
