Imports Core
Public Class FormProducto
    Dim productoModel As New ProductoModel()
    Private Sub FormProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarProductos()
        LoadCategory()
        Panel.Enabled = False
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
        cmbCategoria.DataSource = categorias

        cmbBuscarCategoria.DataSource = Nothing
        cmbBuscarCategoria.DataSource = categoriasConVacio
    End Sub

    Private Sub Restart()
        Panel.Enabled = False
        txtId.Clear()
        txtNombre.Clear()
        txtPrecio.Clear()

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

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        Panel.Enabled = True
        txtId.Enabled = False
        productoModel.State = EntityState.Added
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If DataGridViewProductos.SelectedRows.Count > 0 Then
            Panel.Enabled = True
            productoModel.Id = DataGridViewProductos.CurrentRow.Cells(0).Value
            txtId.Text = DataGridViewProductos.CurrentRow.Cells(0).Value
            txtId.Enabled = False
            productoModel.State = EntityState.Modified
            txtNombre.Text = DataGridViewProductos.CurrentRow.Cells(1).Value
            txtPrecio.Text = DataGridViewProductos.CurrentRow.Cells(2).Value
        Else
            MessageBox.Show("elija un fila a modificar")

        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If DataGridViewProductos.SelectedRows.Count > 0 Then
            Panel.Enabled = True
            productoModel.Id = DataGridViewProductos.CurrentRow.Cells(0).Value
            productoModel.State = EntityState.Deleted
            Dim result = productoModel.SaveChanges()
            MessageBox.Show(result)
            ListarProductos()
            Restart()
        Else
            MessageBox.Show("elija un fila a Eliminar")

        End If

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try
            Dim precio As Double

            productoModel.Nombre = txtNombre.Text

            If Double.TryParse(txtPrecio.Text, precio) Then
                productoModel.Precio = precio
                productoModel.Categoria = cmbCategoria.SelectedItem.ToString()
                Dim valid = New DataValidation(productoModel).validate()
                If valid = True Then
                    Dim result = productoModel.SaveChanges()
                    MessageBox.Show(result)
                    ListarProductos()
                    Restart()
                End If
            Else
                MessageBox.Show("no es un valor valido")
                txtPrecio.Clear()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Restart()
    End Sub
End Class