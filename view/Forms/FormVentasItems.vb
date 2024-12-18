Imports Core


Public Class FormVentasItems
    Dim productoModel As New ProductoModel()
    Dim ClienteModel As New ClienteModel()
    Dim ventasItems As New VentaItemsModel()
    Dim listVentaItems As New List(Of VentaItemsModel)


    Private Sub FormVentasItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarClientes()
        ListarProductos()
        LoadCategory()
        lblPrecioFinal.Text = 0

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

    Private Sub MostrarProductosEnFacturacion()
        DataGridViewFacturacion.DataSource = Nothing
        DataGridViewFacturacion.DataSource = listVentaItems


        With DataGridViewFacturacion
            .Columns("ID").Visible = False
            .Columns("IdVenta").Visible = False
            .Columns("IdProducto").Visible = True
            .Columns("NombreProducto").Visible = True
            .Columns("PrecioUnitario").Visible = True
            .Columns("Cantidad").Visible = True
            .Columns("PrecioTotal").Visible = True
        End With
        DataGridViewFacturacion.Columns("IdProducto").HeaderText = "Id"
        DataGridViewFacturacion.Columns("NombreProducto").HeaderText = "Producto"
        DataGridViewFacturacion.Columns("PrecioUnitario").HeaderText = "Precio Unitario"
        DataGridViewFacturacion.Columns("Cantidad").HeaderText = "Cantidad"
        DataGridViewFacturacion.Columns("PrecioTotal").HeaderText = "Precio Total"
    End Sub


    Private Sub btnCargarCliente_Click(sender As Object, e As EventArgs) Handles btnCargarCliente.Click
        If DataGridViewClientes.SelectedRows.Count > 0 Then

            txtIdCliente.Text = DataGridViewClientes.CurrentRow.Cells(0).Value
            txtNombreCliente.Text = DataGridViewClientes.CurrentRow.Cells(1).Value
            txtCorreoCliente.Text = DataGridViewClientes.CurrentRow.Cells(3).Value

        Else
            MessageBox.Show("Elija un cliente de la lista", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If
    End Sub

    Private Sub BorrarCliente()
        txtIdCliente.Clear()
        txtNombreCliente.Clear()
        txtCorreoCliente.Clear()
    End Sub

    Private Sub BorrarProducto()
        txtIdProducto.Clear()
        txtDescripcion.Clear()
        txtPrecioUnitario.Clear()
        txtCantidad.Clear()
        txtPrecioTotal.Clear()
    End Sub


    Private Sub btnBorrarCliente_Click(sender As Object, e As EventArgs) Handles btnBorrarCliente.Click
        BorrarCliente()
    End Sub

    Private Sub btnCargarProducto_Click(sender As Object, e As EventArgs) Handles btnCargarProducto.Click
        If DataGridViewProductos.SelectedRows.Count > 0 Then
            Dim cantidad = 0
            If Integer.TryParse(txtValorCantidad.Text, cantidad) And cantidad > 0 Then
                txtIdProducto.Text = DataGridViewProductos.CurrentRow.Cells(0).Value
                txtDescripcion.Text = DataGridViewProductos.CurrentRow.Cells(1).Value
                txtPrecioUnitario.Text = DataGridViewProductos.CurrentRow.Cells(2).Value
                txtCantidad.Text = cantidad
                Dim precioUnitario = Double.Parse(txtPrecioUnitario.Text)
                txtPrecioTotal.Text = precioUnitario * cantidad
                txtValorCantidad.Clear()
            Else
                MessageBox.Show("La cantidad debe ser un numero mayor a cero", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            End If

        Else
            MessageBox.Show("Elija un producto de la lista", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If
    End Sub

    Private Sub btnBorrarProducto_Click(sender As Object, e As EventArgs) Handles btnBorrarProducto.Click
        BorrarProducto()
    End Sub

    Private Sub tbtBuscarClientePorId_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarClientePorId.TextChanged
        If String.IsNullOrWhiteSpace(txtBuscarClientePorId.Text) Then
            ListarClientes()
        Else
            DataGridViewClientes.DataSource = ClienteModel.FindById(txtBuscarClientePorId.Text)
        End If
    End Sub

    Private Sub txtBuscarProductoPorId_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarProductoPorId.TextChanged
        If String.IsNullOrWhiteSpace(txtBuscarProductoPorId.Text) Then
            ListarProductos()
        Else
            Dim listProductoAux As New List(Of ProductoModel)
            listProductoAux.Add(productoModel.FindById(txtBuscarProductoPorId.Text))
            DataGridViewProductos.DataSource = listProductoAux
        End If
    End Sub

    Private Sub cmbBuscarCategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBuscarCategoria.SelectedIndexChanged
        If cmbBuscarCategoria.SelectedIndex = -1 Then
            ListarProductos()
        Else
            Dim selectedItem As String = cmbBuscarCategoria.SelectedItem.ToString()

            DataGridViewProductos.DataSource = productoModel.FindByCategory(selectedItem)
        End If
    End Sub

    Private Sub btnCargarDatos_Click(sender As Object, e As EventArgs) Handles btnCargarDatos.Click

        Dim ventasItems As New VentaItemsModel()
        Dim totalGeneral As Double = 0
            If DataValidation.ValidarTextBoxEnGroupBox(gbFacturacion) Then
                ventasItems.IdProducto = CInt(txtIdProducto.Text)
                ventasItems.PrecioUnitario = CDbl(txtPrecioUnitario.Text)
                ventasItems.Cantidad = CInt(txtCantidad.Text)
                ventasItems.PrecioTotal = CDbl(txtPrecioTotal.Text)
                ventasItems.State = EntityState.Added
                listVentaItems.Add(ventasItems)
            End If

            For Each item As VentaItemsModel In listVentaItems
                Dim productoAux As ProductoModel = productoModel.FindById(item.IdProducto)
                item.NombreProducto = productoAux.Nombre
            Next


            MostrarProductosEnFacturacion()

            For Each item As VentaItemsModel In listVentaItems
                totalGeneral += item.PrecioTotal
            Next

            lblPrecioFinal.Text = totalGeneral

    End Sub

    Private Sub btnEliminarDatos_Click(sender As Object, e As EventArgs) Handles btnEliminarDatos.Click


        If DataGridViewFacturacion.SelectedRows.Count > 0 Then
            Dim indice As Integer = DataGridViewFacturacion.SelectedCells(3).RowIndex
            listVentaItems.RemoveAt(indice)
            MessageBox.Show("exito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            MostrarProductosEnFacturacion()
        Else
            MessageBox.Show("elija un fila a Eliminar", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If
    End Sub

    Private Sub btnGenerarVenta_Click(sender As Object, e As EventArgs) Handles btnGenerarVenta.Click
        If listVentaItems.Count() > 0 Then
            Dim ventaModels As New VentaModel()
            ventaModels.IdCliente = CInt(txtIdCliente.Text)
            ventaModels.Fecha = dtpVenta.Value
            ventaModels.Total = CDbl(lblPrecioFinal.Text)
            ventaModels.State = EntityState.Added
            ControlllerVentaGenerada.AddVentaYItems(ventaModels, listVentaItems)
            MessageBox.Show("La venta ha sido generada con exito.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            BorrarCliente()
            BorrarProducto()
            listVentaItems.Clear()
            MostrarProductosEnFacturacion()
            lblPrecioFinal.Text = 0
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click

        Dim result As DialogResult = MessageBox.Show("¿Está seguro de cancelar la venta?", "Confirmar Cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)


        If result = DialogResult.Yes Then
            BorrarCliente()
            BorrarProducto()
            listVentaItems.Clear()
            Me.Close()
        Else

            MessageBox.Show("La venta no ha sido cancelada.", "Cancelación Abandonada", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub


End Class