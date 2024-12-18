Imports DataAccess
Imports System.ComponentModel.DataAnnotations
Public Class VentaModel
    Private _id As Integer
    Private _idCliente As Integer
    Private _fecha As Date
    Private _total As Double
    Private _state As EntityState
    Private Repository As IVentaRepository

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property IdCliente As Integer
        Get
            Return _idCliente
        End Get
        Set(value As Integer)
            _idCliente = value
        End Set
    End Property
    Public Property Fecha As Date
        Get
            Return _fecha
        End Get
        Set(value As Date)
            _fecha = value
        End Set
    End Property

    Public Property Total As Double
        Get
            Return _total
        End Get
        Set(value As Double)
            _total = value
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
        Repository = New VentaRepository()

    End Sub

    Public Function SaveChanges() As Integer
        Dim response As Integer = Nothing

        Dim ventasDataModel As New Venta()
        ventasDataModel.ID = Id
        ventasDataModel.IdCliente = IdCliente
        ventasDataModel.Fecha = Fecha
        ventasDataModel.Total = Total


        Select Case State
            Case EntityState.Added
                response = Repository.Add(ventasDataModel)

            Case EntityState.Modified
                response = Repository.Edit(ventasDataModel)

            Case EntityState.Deleted
                response = Repository.Remove(Id)

        End Select

        Return response
    End Function


    Public Function GetVentas() As List(Of VentaModel)
        Dim listVentasDataModel = Repository.GetAll
        Dim listVentasViewModel = New List(Of VentaModel)

        For Each item As Venta In listVentasDataModel
            listVentasViewModel.Add(New VentaModel With {
                                     .Id = item.ID,
                                     .IdCliente = item.IdCliente,
                                     .Fecha = item.Fecha,
                                     .Total = item.Total
                                     })
        Next
        Return listVentasViewModel
    End Function

    Public Function FindById(filter As String) As IEnumerable(Of VentaModel)

        Return GetVentas().FindAll(Function(Ventas) Ventas.Id.ToString() = filter)


    End Function

    Public Function FindByIdClient(filter As String) As IEnumerable(Of VentaModel)

        Return GetVentas().FindAll(Function(Ventas) Ventas.IdCliente.ToString() = filter)


    End Function


End Class
