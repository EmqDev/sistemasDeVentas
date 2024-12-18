Imports DataAccess
Public Class VentaItemsModel
    Private _ID As Integer
    Private _idVenta As Integer
    Private _idProducto As Integer
    Private _nombreProducto As String
    Private _precioUnitario As Double
    Private _Cantidad As Integer
    Private _precioTotal As Double

    Private _state As EntityState
    Private Repository As IVentaItemsRepository

    Public Property ID As Integer
        Get
            Return _ID
        End Get
        Set(value As Integer)
            _ID = value
        End Set
    End Property

    Public Property IdVenta As Integer
        Get
            Return _idVenta
        End Get
        Set(value As Integer)
            _idVenta = value
        End Set
    End Property

    Public Property IdProducto As Integer
        Get
            Return _idProducto
        End Get
        Set(value As Integer)
            _idProducto = value
        End Set
    End Property

    Public Property NombreProducto As String
        Get
            Return _nombreProducto
        End Get
        Set(value As String)
            _nombreProducto = value
        End Set
    End Property


    Public Property PrecioUnitario As Double
        Get
            Return _precioUnitario
        End Get
        Set(value As Double)
            _precioUnitario = value
        End Set
    End Property

    Public Property Cantidad As Integer
        Get
            Return _Cantidad
        End Get
        Set(value As Integer)
            _Cantidad = value
        End Set
    End Property

    Public Property PrecioTotal As Double
        Get
            Return _precioTotal
        End Get
        Set(value As Double)
            _precioTotal = value
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
        Repository = New VentaItemsRepository()
    End Sub

    Public Function SaveChanges() As String
        Dim message As String = Nothing
        Try
            Dim ventasItemDataModel As New VentaItems()
            ventasItemDataModel.ID = ID
            ventasItemDataModel.IdProducto = IdProducto
            ventasItemDataModel.IdVenta = IdVenta
            ventasItemDataModel.PrecioUnitario = PrecioUnitario
            ventasItemDataModel.Cantidad = Cantidad
            ventasItemDataModel.PrecioTotal = PrecioTotal

            Select Case State
                Case EntityState.Added
                    Repository.Add(ventasItemDataModel)
                    message = "Registro con exito"
                Case EntityState.Modified
                    Repository.Edit(ventasItemDataModel)
                    message = "Modificado con exito"
                Case EntityState.Deleted
                    Repository.Remove(ID)
                    message = "Se Elimino con exito"
            End Select
        Catch ex As Exception
            message = ex.ToString()
        End Try
        Return message
    End Function


    Public Function GetVentasItems() As List(Of VentaItemsModel)
        Dim listVentasDataModel = Repository.GetAll
        Dim listVentasItemsViewModel = New List(Of VentaItemsModel)

        For Each item As VentaItems In listVentasDataModel
            listVentasItemsViewModel.Add(New VentaItemsModel With {
                                         .ID = item.ID,
                                         .IdVenta = item.IdVenta,
                                         .IdProducto = item.IdProducto,
                                         .PrecioUnitario = item.PrecioUnitario,
                                         .Cantidad = item.Cantidad,
                                         .PrecioTotal = item.PrecioTotal
                                     })
        Next
        Return listVentasItemsViewModel
    End Function

    Public Function FindByIdVenta(filter As String) As IEnumerable(Of VentaItemsModel)

        Return GetVentasItems().FindAll(Function(ventas) ventas.IdVenta.ToString() = filter)


    End Function


End Class
