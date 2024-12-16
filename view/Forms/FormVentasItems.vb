Imports Core
Public Class FormVentasItems
    Dim productoModel As New ProductoModel()
    Dim ClienteModel As New ClienteModel()

    Private Sub FormVentasItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarClientes()
        ListarProductos()
        LoadCategory()

    End Sub

    Private Sub ListarClientes()
        Try
            DataGridViewClientes.DataSource = ClienteModel.GetCliente()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub ListarProductos()
        Try
            DataGridViewProductos.DataSource = productoModel.GetProducto()

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub LoadCategory()

        Dim categorias As Array = [Enum].GetValues(GetType(ECategory))


        Dim categoriasConVacio As New List(Of Object)
        categoriasConVacio.Add(String.Empty)
        For Each item In categorias
            categoriasConVacio.Add(item)
        Next
        cmbBuscarCategoria.DataSource = Nothing
        cmbBuscarCategoria.DataSource = categoriasConVacio
    End Sub

End Class