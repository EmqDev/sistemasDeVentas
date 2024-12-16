Imports Core

Public Class FormCliente
    Dim ClienteModel As New ClienteModel()
    Private Sub FormCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarClientes()
        Panel.Enabled = False
    End Sub
    Private Sub ListarClientes()
        Try
            DataGridViewClientes.DataSource = ClienteModel.GetCliente()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub tbtBuscarClientePorId_TextChanged(sender As Object, e As EventArgs) Handles tbtBuscarClientePorId.TextChanged
        If String.IsNullOrWhiteSpace(tbtBuscarClientePorId.Text) Then
            ListarClientes()
        Else
            DataGridViewClientes.DataSource = ClienteModel.FindById(tbtBuscarClientePorId.Text)
        End If
    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        Panel.Enabled = True
        tbtId.Enabled = False
        ClienteModel.State = EntityState.Added

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If DataGridViewClientes.SelectedRows.Count > 0 Then
            Panel.Enabled = True
            ClienteModel.Id = DataGridViewClientes.CurrentRow.Cells(0).Value
            tbtId.Text = DataGridViewClientes.CurrentRow.Cells(0).Value
            tbtId.Enabled = False
            ClienteModel.State = EntityState.Modified
            tbtCliente.Text = DataGridViewClientes.CurrentRow.Cells(1).Value
            tbtTelefono.Text = DataGridViewClientes.CurrentRow.Cells(2).Value
            tbtCorreo.Text = DataGridViewClientes.CurrentRow.Cells(3).Value


        Else
            MessageBox.Show("elija un fila a modificar")

        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If DataGridViewClientes.SelectedRows.Count > 0 Then
            Panel.Enabled = True
            ClienteModel.Id = DataGridViewClientes.CurrentRow.Cells(0).Value
            ClienteModel.State = EntityState.Deleted
            Dim result = ClienteModel.SaveChanges()
            MessageBox.Show(result)
            ListarClientes()
            Restart()
        Else
            MessageBox.Show("elija un fila a modificar")

        End If

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try
            ClienteModel.Cliente = tbtCliente.Text
            ClienteModel.Telefono = tbtTelefono.Text
            ClienteModel.Correo = tbtCorreo.Text
            Dim valid = New DataValidation(ClienteModel).validate()
            If valid = True Then
                Dim result = ClienteModel.SaveChanges()
                MessageBox.Show(result)
                ListarClientes()
                Restart()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try

    End Sub

    Private Sub Restart()
        Panel.Enabled = False
        tbtId.Clear()
        tbtCliente.Clear()
        tbtTelefono.Clear()
        tbtCorreo.Clear()

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Restart()
    End Sub


End Class