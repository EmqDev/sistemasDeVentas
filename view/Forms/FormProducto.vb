Imports Core
Public Class FormProducto
    Dim productoModel As New ProductoModel()
    Private Sub FormProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarProductos()
        cmbCategoria.DataSource = [Enum].GetValues(GetType(ECategory))
        cmbBuscarCategoria.DataSource = [Enum].GetValues(GetType(ECategory))

        Panel.Enabled = False
    End Sub

    Private Sub ListarProductos()
        Try
            DataGridViewProductos.DataSource = productoModel.GetProducto()

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub


End Class