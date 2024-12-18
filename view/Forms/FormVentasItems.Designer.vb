<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormVentasItems
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormVentasItems))
        Me.gbBuscarProducto = New System.Windows.Forms.GroupBox()
        Me.txtBuscarProductoPorId = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbBuscarCategoria = New System.Windows.Forms.ComboBox()
        Me.btnCargarProducto = New System.Windows.Forms.Button()
        Me.lblListaDeClientes = New System.Windows.Forms.Label()
        Me.DataGridViewProductos = New System.Windows.Forms.DataGridView()
        Me.btnBorrarProducto = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBuscarClientePorId = New System.Windows.Forms.TextBox()
        Me.DataGridViewClientes = New System.Windows.Forms.DataGridView()
        Me.btnCargarCliente = New System.Windows.Forms.Button()
        Me.btnBorrarCliente = New System.Windows.Forms.Button()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.gbBuscarClientePorId = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.gbFacturacion = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.dtpVenta = New System.Windows.Forms.DateTimePicker()
        Me.txtPrecioTotal = New System.Windows.Forms.TextBox()
        Me.gbImportes = New System.Windows.Forms.GroupBox()
        Me.lblPrecioFinal = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.DataGridViewFacturacion = New System.Windows.Forms.DataGridView()
        Me.btnEliminarDatos = New System.Windows.Forms.Button()
        Me.btnGenerarVenta = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnCargarDatos = New System.Windows.Forms.Button()
        Me.txtCorreoCliente = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPrecioUnitario = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtIdProducto = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNombreCliente = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtIdCliente = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtValorCantidad = New System.Windows.Forms.TextBox()
        Me.gbBuscarProducto.SuspendLayout()
        CType(Me.DataGridViewProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbBuscarClientePorId.SuspendLayout()
        Me.gbFacturacion.SuspendLayout()
        Me.gbImportes.SuspendLayout()
        CType(Me.DataGridViewFacturacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbBuscarProducto
        '
        Me.gbBuscarProducto.Controls.Add(Me.txtBuscarProductoPorId)
        Me.gbBuscarProducto.Controls.Add(Me.Label2)
        Me.gbBuscarProducto.Controls.Add(Me.Label1)
        Me.gbBuscarProducto.Controls.Add(Me.cmbBuscarCategoria)
        Me.gbBuscarProducto.Location = New System.Drawing.Point(762, 9)
        Me.gbBuscarProducto.Name = "gbBuscarProducto"
        Me.gbBuscarProducto.Size = New System.Drawing.Size(746, 66)
        Me.gbBuscarProducto.TabIndex = 35
        Me.gbBuscarProducto.TabStop = False
        Me.gbBuscarProducto.Text = "Buscar Producto"
        '
        'txtBuscarProductoPorId
        '
        Me.txtBuscarProductoPorId.Location = New System.Drawing.Point(11, 35)
        Me.txtBuscarProductoPorId.Name = "txtBuscarProductoPorId"
        Me.txtBuscarProductoPorId.Size = New System.Drawing.Size(277, 20)
        Me.txtBuscarProductoPorId.TabIndex = 29
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(342, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Elegi Categoria"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Ingresa ID"
        '
        'cmbBuscarCategoria
        '
        Me.cmbBuscarCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBuscarCategoria.FormattingEnabled = True
        Me.cmbBuscarCategoria.Location = New System.Drawing.Point(345, 35)
        Me.cmbBuscarCategoria.Name = "cmbBuscarCategoria"
        Me.cmbBuscarCategoria.Size = New System.Drawing.Size(304, 21)
        Me.cmbBuscarCategoria.TabIndex = 27
        '
        'btnCargarProducto
        '
        Me.btnCargarProducto.BackColor = System.Drawing.Color.YellowGreen
        Me.btnCargarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCargarProducto.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCargarProducto.Location = New System.Drawing.Point(1375, 205)
        Me.btnCargarProducto.Name = "btnCargarProducto"
        Me.btnCargarProducto.Size = New System.Drawing.Size(132, 31)
        Me.btnCargarProducto.TabIndex = 34
        Me.btnCargarProducto.Text = "Cargar Producto"
        Me.btnCargarProducto.UseVisualStyleBackColor = False
        '
        'lblListaDeClientes
        '
        Me.lblListaDeClientes.AutoSize = True
        Me.lblListaDeClientes.Location = New System.Drawing.Point(765, 78)
        Me.lblListaDeClientes.Name = "lblListaDeClientes"
        Me.lblListaDeClientes.Size = New System.Drawing.Size(95, 13)
        Me.lblListaDeClientes.TabIndex = 33
        Me.lblListaDeClientes.Text = "Lista de Productos"
        '
        'DataGridViewProductos
        '
        Me.DataGridViewProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewProductos.Location = New System.Drawing.Point(764, 93)
        Me.DataGridViewProductos.Name = "DataGridViewProductos"
        Me.DataGridViewProductos.ReadOnly = True
        Me.DataGridViewProductos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewProductos.Size = New System.Drawing.Size(744, 107)
        Me.DataGridViewProductos.TabIndex = 32
        '
        'btnBorrarProducto
        '
        Me.btnBorrarProducto.BackColor = System.Drawing.Color.IndianRed
        Me.btnBorrarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrarProducto.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBorrarProducto.Location = New System.Drawing.Point(1261, 205)
        Me.btnBorrarProducto.Name = "btnBorrarProducto"
        Me.btnBorrarProducto.Size = New System.Drawing.Size(108, 31)
        Me.btnBorrarProducto.TabIndex = 30
        Me.btnBorrarProducto.Text = "Borrar"
        Me.btnBorrarProducto.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 13)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Lista de Clientes"
        '
        'txtBuscarClientePorId
        '
        Me.txtBuscarClientePorId.Location = New System.Drawing.Point(6, 34)
        Me.txtBuscarClientePorId.Name = "txtBuscarClientePorId"
        Me.txtBuscarClientePorId.Size = New System.Drawing.Size(277, 20)
        Me.txtBuscarClientePorId.TabIndex = 39
        '
        'DataGridViewClientes
        '
        Me.DataGridViewClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewClientes.Location = New System.Drawing.Point(14, 93)
        Me.DataGridViewClientes.Name = "DataGridViewClientes"
        Me.DataGridViewClientes.ReadOnly = True
        Me.DataGridViewClientes.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewClientes.Size = New System.Drawing.Size(731, 107)
        Me.DataGridViewClientes.TabIndex = 38
        '
        'btnCargarCliente
        '
        Me.btnCargarCliente.BackColor = System.Drawing.Color.YellowGreen
        Me.btnCargarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCargarCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCargarCliente.Location = New System.Drawing.Point(612, 206)
        Me.btnCargarCliente.Name = "btnCargarCliente"
        Me.btnCargarCliente.Size = New System.Drawing.Size(132, 30)
        Me.btnCargarCliente.TabIndex = 43
        Me.btnCargarCliente.Text = "Cargar Cliente"
        Me.btnCargarCliente.UseVisualStyleBackColor = False
        '
        'btnBorrarCliente
        '
        Me.btnBorrarCliente.BackColor = System.Drawing.Color.IndianRed
        Me.btnBorrarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrarCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBorrarCliente.Location = New System.Drawing.Point(498, 206)
        Me.btnBorrarCliente.Name = "btnBorrarCliente"
        Me.btnBorrarCliente.Size = New System.Drawing.Size(108, 30)
        Me.btnBorrarCliente.TabIndex = 42
        Me.btnBorrarCliente.Text = "Borrar"
        Me.btnBorrarCliente.UseVisualStyleBackColor = False
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidad.Location = New System.Drawing.Point(773, 210)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(81, 20)
        Me.lblCantidad.TabIndex = 45
        Me.lblCantidad.Text = "Cantidad"
        '
        'gbBuscarClientePorId
        '
        Me.gbBuscarClientePorId.Controls.Add(Me.Label14)
        Me.gbBuscarClientePorId.Controls.Add(Me.txtBuscarClientePorId)
        Me.gbBuscarClientePorId.Location = New System.Drawing.Point(12, 10)
        Me.gbBuscarClientePorId.Name = "gbBuscarClientePorId"
        Me.gbBuscarClientePorId.Size = New System.Drawing.Size(733, 65)
        Me.gbBuscarClientePorId.TabIndex = 46
        Me.gbBuscarClientePorId.TabStop = False
        Me.gbBuscarClientePorId.Text = "Buscar cliente "
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 19)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(56, 13)
        Me.Label14.TabIndex = 30
        Me.Label14.Text = "Ingresa ID"
        '
        'gbFacturacion
        '
        Me.gbFacturacion.Controls.Add(Me.Label15)
        Me.gbFacturacion.Controls.Add(Me.dtpVenta)
        Me.gbFacturacion.Controls.Add(Me.txtPrecioTotal)
        Me.gbFacturacion.Controls.Add(Me.gbImportes)
        Me.gbFacturacion.Controls.Add(Me.Label11)
        Me.gbFacturacion.Controls.Add(Me.txtCantidad)
        Me.gbFacturacion.Controls.Add(Me.Label10)
        Me.gbFacturacion.Controls.Add(Me.btnCargarDatos)
        Me.gbFacturacion.Controls.Add(Me.txtCorreoCliente)
        Me.gbFacturacion.Controls.Add(Me.Label9)
        Me.gbFacturacion.Controls.Add(Me.txtPrecioUnitario)
        Me.gbFacturacion.Controls.Add(Me.Label8)
        Me.gbFacturacion.Controls.Add(Me.txtDescripcion)
        Me.gbFacturacion.Controls.Add(Me.Label7)
        Me.gbFacturacion.Controls.Add(Me.txtIdProducto)
        Me.gbFacturacion.Controls.Add(Me.Label6)
        Me.gbFacturacion.Controls.Add(Me.txtNombreCliente)
        Me.gbFacturacion.Controls.Add(Me.Label5)
        Me.gbFacturacion.Controls.Add(Me.txtIdCliente)
        Me.gbFacturacion.Controls.Add(Me.Label3)
        Me.gbFacturacion.Location = New System.Drawing.Point(11, 256)
        Me.gbFacturacion.Name = "gbFacturacion"
        Me.gbFacturacion.Size = New System.Drawing.Size(1497, 504)
        Me.gbFacturacion.TabIndex = 47
        Me.gbFacturacion.TabStop = False
        Me.gbFacturacion.Text = "Datos de facturación"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(13, 88)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(82, 13)
        Me.Label15.TabIndex = 69
        Me.Label15.Text = "Fecha de venta"
        '
        'dtpVenta
        '
        Me.dtpVenta.Location = New System.Drawing.Point(15, 104)
        Me.dtpVenta.Name = "dtpVenta"
        Me.dtpVenta.Size = New System.Drawing.Size(200, 20)
        Me.dtpVenta.TabIndex = 68
        '
        'txtPrecioTotal
        '
        Me.txtPrecioTotal.Location = New System.Drawing.Point(1382, 60)
        Me.txtPrecioTotal.Name = "txtPrecioTotal"
        Me.txtPrecioTotal.ReadOnly = True
        Me.txtPrecioTotal.Size = New System.Drawing.Size(107, 20)
        Me.txtPrecioTotal.TabIndex = 64
        '
        'gbImportes
        '
        Me.gbImportes.Controls.Add(Me.lblPrecioFinal)
        Me.gbImportes.Controls.Add(Me.Label13)
        Me.gbImportes.Controls.Add(Me.DataGridViewFacturacion)
        Me.gbImportes.Controls.Add(Me.btnEliminarDatos)
        Me.gbImportes.Controls.Add(Me.btnGenerarVenta)
        Me.gbImportes.Controls.Add(Me.btnCancelar)
        Me.gbImportes.Location = New System.Drawing.Point(10, 152)
        Me.gbImportes.Name = "gbImportes"
        Me.gbImportes.Size = New System.Drawing.Size(1481, 343)
        Me.gbImportes.TabIndex = 67
        Me.gbImportes.TabStop = False
        Me.gbImportes.Text = "Importe "
        '
        'lblPrecioFinal
        '
        Me.lblPrecioFinal.AutoSize = True
        Me.lblPrecioFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecioFinal.Location = New System.Drawing.Point(1334, 277)
        Me.lblPrecioFinal.Name = "lblPrecioFinal"
        Me.lblPrecioFinal.Size = New System.Drawing.Size(80, 37)
        Me.lblPrecioFinal.TabIndex = 68
        Me.lblPrecioFinal.Text = "0,00"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(1189, 277)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(116, 37)
        Me.Label13.TabIndex = 67
        Me.Label13.Text = "Total $"
        '
        'DataGridViewFacturacion
        '
        Me.DataGridViewFacturacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewFacturacion.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewFacturacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewFacturacion.Location = New System.Drawing.Point(6, 19)
        Me.DataGridViewFacturacion.Name = "DataGridViewFacturacion"
        Me.DataGridViewFacturacion.ReadOnly = True
        Me.DataGridViewFacturacion.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewFacturacion.Size = New System.Drawing.Size(1468, 238)
        Me.DataGridViewFacturacion.TabIndex = 48
        '
        'btnEliminarDatos
        '
        Me.btnEliminarDatos.BackColor = System.Drawing.Color.IndianRed
        Me.btnEliminarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarDatos.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnEliminarDatos.Location = New System.Drawing.Point(6, 269)
        Me.btnEliminarDatos.Name = "btnEliminarDatos"
        Me.btnEliminarDatos.Size = New System.Drawing.Size(174, 64)
        Me.btnEliminarDatos.TabIndex = 65
        Me.btnEliminarDatos.Text = "Eliminar Item"
        Me.btnEliminarDatos.UseVisualStyleBackColor = False
        '
        'btnGenerarVenta
        '
        Me.btnGenerarVenta.BackColor = System.Drawing.Color.ForestGreen
        Me.btnGenerarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerarVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerarVenta.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnGenerarVenta.Location = New System.Drawing.Point(391, 268)
        Me.btnGenerarVenta.Name = "btnGenerarVenta"
        Me.btnGenerarVenta.Size = New System.Drawing.Size(199, 64)
        Me.btnGenerarVenta.TabIndex = 66
        Me.btnGenerarVenta.Text = "Generar Venta"
        Me.btnGenerarVenta.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnCancelar.Location = New System.Drawing.Point(186, 268)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(199, 64)
        Me.btnCancelar.TabIndex = 65
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(1379, 45)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 13)
        Me.Label11.TabIndex = 63
        Me.Label11.Text = "Precio Total"
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(1269, 60)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.ReadOnly = True
        Me.txtCantidad.Size = New System.Drawing.Size(107, 20)
        Me.txtCantidad.TabIndex = 62
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(1266, 45)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 13)
        Me.Label10.TabIndex = 61
        Me.Label10.Text = "Cantidad"
        '
        'btnCargarDatos
        '
        Me.btnCargarDatos.BackColor = System.Drawing.Color.YellowGreen
        Me.btnCargarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCargarDatos.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCargarDatos.Location = New System.Drawing.Point(1354, 96)
        Me.btnCargarDatos.Name = "btnCargarDatos"
        Me.btnCargarDatos.Size = New System.Drawing.Size(132, 28)
        Me.btnCargarDatos.TabIndex = 49
        Me.btnCargarDatos.Text = "Cargar Datos"
        Me.btnCargarDatos.UseVisualStyleBackColor = False
        '
        'txtCorreoCliente
        '
        Me.txtCorreoCliente.Location = New System.Drawing.Point(389, 60)
        Me.txtCorreoCliente.Name = "txtCorreoCliente"
        Me.txtCorreoCliente.ReadOnly = True
        Me.txtCorreoCliente.Size = New System.Drawing.Size(333, 20)
        Me.txtCorreoCliente.TabIndex = 60
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(386, 44)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 13)
        Me.Label9.TabIndex = 59
        Me.Label9.Text = "Correo Cliente"
        '
        'txtPrecioUnitario
        '
        Me.txtPrecioUnitario.Location = New System.Drawing.Point(1156, 60)
        Me.txtPrecioUnitario.Name = "txtPrecioUnitario"
        Me.txtPrecioUnitario.ReadOnly = True
        Me.txtPrecioUnitario.Size = New System.Drawing.Size(107, 20)
        Me.txtPrecioUnitario.TabIndex = 58
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(1153, 45)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 13)
        Me.Label8.TabIndex = 57
        Me.Label8.Text = "Precio Unitario"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(896, 60)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.ReadOnly = True
        Me.txtDescripcion.Size = New System.Drawing.Size(254, 20)
        Me.txtDescripcion.TabIndex = 56
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(893, 45)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 55
        Me.Label7.Text = "Descripción"
        '
        'txtIdProducto
        '
        Me.txtIdProducto.Location = New System.Drawing.Point(783, 60)
        Me.txtIdProducto.Name = "txtIdProducto"
        Me.txtIdProducto.ReadOnly = True
        Me.txtIdProducto.Size = New System.Drawing.Size(107, 20)
        Me.txtIdProducto.TabIndex = 54
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(780, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "ID Producto"
        '
        'txtNombreCliente
        '
        Me.txtNombreCliente.Location = New System.Drawing.Point(129, 60)
        Me.txtNombreCliente.Name = "txtNombreCliente"
        Me.txtNombreCliente.ReadOnly = True
        Me.txtNombreCliente.Size = New System.Drawing.Size(254, 20)
        Me.txtNombreCliente.TabIndex = 52
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(126, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 13)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "Nombre Cliente"
        '
        'txtIdCliente
        '
        Me.txtIdCliente.Location = New System.Drawing.Point(16, 60)
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.ReadOnly = True
        Me.txtIdCliente.Size = New System.Drawing.Size(107, 20)
        Me.txtIdCliente.TabIndex = 50
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "ID Cliente"
        '
        'txtValorCantidad
        '
        Me.txtValorCantidad.Location = New System.Drawing.Point(860, 210)
        Me.txtValorCantidad.Name = "txtValorCantidad"
        Me.txtValorCantidad.Size = New System.Drawing.Size(107, 20)
        Me.txtValorCantidad.TabIndex = 68
        '
        'FormVentasItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1520, 772)
        Me.Controls.Add(Me.txtValorCantidad)
        Me.Controls.Add(Me.gbFacturacion)
        Me.Controls.Add(Me.gbBuscarClientePorId)
        Me.Controls.Add(Me.lblCantidad)
        Me.Controls.Add(Me.btnCargarCliente)
        Me.Controls.Add(Me.btnBorrarCliente)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DataGridViewClientes)
        Me.Controls.Add(Me.gbBuscarProducto)
        Me.Controls.Add(Me.btnCargarProducto)
        Me.Controls.Add(Me.lblListaDeClientes)
        Me.Controls.Add(Me.DataGridViewProductos)
        Me.Controls.Add(Me.btnBorrarProducto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FormVentasItems"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Facturación"
        Me.gbBuscarProducto.ResumeLayout(False)
        Me.gbBuscarProducto.PerformLayout()
        CType(Me.DataGridViewProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbBuscarClientePorId.ResumeLayout(False)
        Me.gbBuscarClientePorId.PerformLayout()
        Me.gbFacturacion.ResumeLayout(False)
        Me.gbFacturacion.PerformLayout()
        Me.gbImportes.ResumeLayout(False)
        Me.gbImportes.PerformLayout()
        CType(Me.DataGridViewFacturacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbBuscarProducto As GroupBox
    Friend WithEvents txtBuscarProductoPorId As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbBuscarCategoria As ComboBox
    Friend WithEvents btnCargarProducto As Button
    Friend WithEvents lblListaDeClientes As Label
    Friend WithEvents DataGridViewProductos As DataGridView
    Friend WithEvents btnBorrarProducto As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtBuscarClientePorId As TextBox
    Friend WithEvents DataGridViewClientes As DataGridView
    Friend WithEvents btnCargarCliente As Button
    Friend WithEvents btnBorrarCliente As Button
    Friend WithEvents lblCantidad As Label
    Friend WithEvents gbBuscarClientePorId As GroupBox
    Friend WithEvents gbFacturacion As GroupBox
    Friend WithEvents btnCargarDatos As Button
    Friend WithEvents txtCorreoCliente As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtPrecioUnitario As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtIdProducto As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNombreCliente As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtIdCliente As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridViewFacturacion As DataGridView
    Friend WithEvents txtPrecioTotal As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btnGenerarVenta As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents gbImportes As GroupBox
    Friend WithEvents lblPrecioFinal As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents btnEliminarDatos As Button
    Friend WithEvents txtValorCantidad As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents dtpVenta As DateTimePicker
End Class
