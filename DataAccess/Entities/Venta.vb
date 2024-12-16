Public Class Venta
    Private id As Integer
    Private idCliente As Integer
    Private fecha As Date
    Private total As Double


    Public Property Id1 As Integer
        Get
            Return id
        End Get
        Set(value As Integer)
            id = value
        End Set
    End Property

    Public Property IdCliente1 As Integer
        Get
            Return idCliente
        End Get
        Set(value As Integer)
            idCliente = value
        End Set
    End Property

    Public Property Fecha1 As Date
        Get
            Return fecha
        End Get
        Set(value As Date)
            fecha = value
        End Set
    End Property

    Public Property Total1 As Double
        Get
            Return total
        End Get
        Set(value As Double)
            total = value
        End Set
    End Property
End Class
