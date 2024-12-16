Imports System.Configuration
Imports System.Data.SqlClient

Public MustInherit Class Repository
    Private ReadOnly connectionsString As String

    Public Sub New()
        Me.connectionsString = ConfigurationManager.ConnectionStrings("pruebademo").ToString()
    End Sub

    Protected Function GetConnection() As SqlConnection
        Return New SqlConnection(connectionsString)
    End Function

End Class
