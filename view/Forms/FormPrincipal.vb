﻿Public Class FormPrincipal
    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        Dim formCliente = New FormCliente()

        formCliente.ShowDialog()

    End Sub

    Private Sub btnProductos_Click(sender As Object, e As EventArgs) Handles btnProductos.Click
        Dim formProducto = New FormProducto()
        formProducto.ShowDialog()
    End Sub

    Private Sub btnVender_Click(sender As Object, e As EventArgs) Handles btnVender.Click
        Dim formVentaItems = New FormVentasItems()
        FormVentasItems.ShowDialog()
    End Sub
End Class