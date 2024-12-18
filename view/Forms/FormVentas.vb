Imports Core
Public Class FormVentas
    Dim ventasModel As New VentaModel()
    Dim listVentaModel As New List(Of VentaModel)
    Dim clientesModel As New ClienteModel()
    Dim clienteAux As New ClienteModel
    Dim ventaItems As New VentaItemsModel
    Dim productoModel As New ProductoModel
    Dim listVentaItemsAux As New List(Of VentaItemsModel)

    Private Sub FormVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarVentas()
    End Sub
    Private Sub ListarVentas()
        Try
            DataGridViewVentas.DataSource = ventasModel.GetVentas()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Private Sub txtBuscarVentaPorId_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarVentaPorId.TextChanged
        If String.IsNullOrWhiteSpace(txtBuscarVentaPorId.Text) Then
            ListarVentas()
        Else
            DataGridViewVentas.DataSource = ventasModel.FindById(txtBuscarVentaPorId.Text)
        End If
    End Sub

    Private Sub txtBuscarVentaPorIdCLiente_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarVentaPorIdCLiente.TextChanged
        If String.IsNullOrWhiteSpace(txtBuscarVentaPorIdCLiente.Text) Then
            ListarVentas()
        Else
            DataGridViewVentas.DataSource = ventasModel.FindByIdClient(txtBuscarVentaPorIdCLiente.Text)
        End If
    End Sub

    Private Sub btnCargarDetalles_Click(sender As Object, e As EventArgs) Handles btnCargarDetalles.Click
        If DataGridViewVentas.SelectedRows.Count > 0 Then
            Dim idCliente As String = DataGridViewVentas.SelectedCells(1).Value
            Dim idVenta As String = DataGridViewVentas.SelectedCells(0).Value

            clienteAux = clientesModel.FindById(idCliente)
            txtIdCliente.Text = clienteAux.Id
            txtNombreCliente.Text = clienteAux.Cliente
            txtCorreoCliente.Text = clienteAux.Correo
            lblPrecioFinal.Text = DataGridViewVentas.SelectedCells(3).Value

            listVentaItemsAux = ventaItems.FindByIdVenta(idVenta)

            For Each item As VentaItemsModel In listVentaItemsAux
                Dim productoAux As ProductoModel = productoModel.FindById(item.IdProducto)
                item.NombreProducto = productoAux.Nombre
            Next

            DataGridViewDetalleItems.DataSource = listVentaItemsAux

        Else
            MessageBox.Show("elija un fila para ver los detalles", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If


    End Sub

    Private Sub btnBorrarDetalles_Click(sender As Object, e As EventArgs) Handles btnBorrarDetalles.Click
        txtIdCliente.Clear()
        txtNombreCliente.Clear()
        txtCorreoCliente.Clear()
        lblPrecioFinal.Text = 0
        listVentaItemsAux.Clear()
        DataGridViewDetalleItems.DataSource = Nothing
        DataGridViewDetalleItems.Rows.Clear()
        DataGridViewDetalleItems.Columns.Clear()

    End Sub
End Class