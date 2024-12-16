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
        Me.gbBuscarProducto = New System.Windows.Forms.GroupBox()
        Me.txtBuscarProductoPorId = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbBuscarCategoria = New System.Windows.Forms.ComboBox()
        Me.btnCrear = New System.Windows.Forms.Button()
        Me.lblListaDeClientes = New System.Windows.Forms.Label()
        Me.DataGridViewProductos = New System.Windows.Forms.DataGridView()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbtBuscarClientePorId = New System.Windows.Forms.TextBox()
        Me.DataGridViewClientes = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.gbBuscarClientePorId = New System.Windows.Forms.GroupBox()
        Me.gbFacturacion = New System.Windows.Forms.GroupBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.gbImportes = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.gbBuscarProducto.SuspendLayout()
        CType(Me.DataGridViewProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbBuscarClientePorId.SuspendLayout()
        Me.gbFacturacion.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbImportes.SuspendLayout()
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
        Me.gbBuscarProducto.Size = New System.Drawing.Size(733, 66)
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
        'btnCrear
        '
        Me.btnCrear.BackColor = System.Drawing.Color.YellowGreen
        Me.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCrear.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCrear.Location = New System.Drawing.Point(1364, 332)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(132, 26)
        Me.btnCrear.TabIndex = 34
        Me.btnCrear.Text = "Cargar Producto"
        Me.btnCrear.UseVisualStyleBackColor = False
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
        Me.DataGridViewProductos.Size = New System.Drawing.Size(731, 234)
        Me.DataGridViewProductos.TabIndex = 32
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.IndianRed
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnEliminar.Location = New System.Drawing.Point(1250, 332)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(108, 26)
        Me.btnEliminar.TabIndex = 30
        Me.btnEliminar.Text = "Borrar"
        Me.btnEliminar.UseVisualStyleBackColor = False
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
        'tbtBuscarClientePorId
        '
        Me.tbtBuscarClientePorId.Location = New System.Drawing.Point(6, 34)
        Me.tbtBuscarClientePorId.Name = "tbtBuscarClientePorId"
        Me.tbtBuscarClientePorId.Size = New System.Drawing.Size(277, 20)
        Me.tbtBuscarClientePorId.TabIndex = 39
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
        Me.DataGridViewClientes.Size = New System.Drawing.Size(731, 234)
        Me.DataGridViewClientes.TabIndex = 38
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.YellowGreen
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(613, 333)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(132, 26)
        Me.Button1.TabIndex = 43
        Me.Button1.Text = "Cargar Cliente"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.IndianRed
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button3.Location = New System.Drawing.Point(499, 333)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(108, 26)
        Me.Button3.TabIndex = 42
        Me.Button3.Text = "Borrar"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Location = New System.Drawing.Point(765, 339)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(49, 13)
        Me.lblCantidad.TabIndex = 45
        Me.lblCantidad.Text = "Cantidad"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(820, 337)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(230, 20)
        Me.TextBox1.TabIndex = 44
        '
        'gbBuscarClientePorId
        '
        Me.gbBuscarClientePorId.Controls.Add(Me.Label14)
        Me.gbBuscarClientePorId.Controls.Add(Me.tbtBuscarClientePorId)
        Me.gbBuscarClientePorId.Location = New System.Drawing.Point(12, 10)
        Me.gbBuscarClientePorId.Name = "gbBuscarClientePorId"
        Me.gbBuscarClientePorId.Size = New System.Drawing.Size(733, 65)
        Me.gbBuscarClientePorId.TabIndex = 46
        Me.gbBuscarClientePorId.TabStop = False
        Me.gbBuscarClientePorId.Text = "Buscar cliente "
        '
        'gbFacturacion
        '
        Me.gbFacturacion.Controls.Add(Me.btnEditar)
        Me.gbFacturacion.Controls.Add(Me.Button2)
        Me.gbFacturacion.Controls.Add(Me.TextBox9)
        Me.gbFacturacion.Controls.Add(Me.Label11)
        Me.gbFacturacion.Controls.Add(Me.TextBox8)
        Me.gbFacturacion.Controls.Add(Me.Label10)
        Me.gbFacturacion.Controls.Add(Me.Button4)
        Me.gbFacturacion.Controls.Add(Me.TextBox7)
        Me.gbFacturacion.Controls.Add(Me.Label9)
        Me.gbFacturacion.Controls.Add(Me.TextBox6)
        Me.gbFacturacion.Controls.Add(Me.Label8)
        Me.gbFacturacion.Controls.Add(Me.TextBox5)
        Me.gbFacturacion.Controls.Add(Me.Label7)
        Me.gbFacturacion.Controls.Add(Me.TextBox4)
        Me.gbFacturacion.Controls.Add(Me.Label6)
        Me.gbFacturacion.Controls.Add(Me.TextBox3)
        Me.gbFacturacion.Controls.Add(Me.Label5)
        Me.gbFacturacion.Controls.Add(Me.TextBox2)
        Me.gbFacturacion.Controls.Add(Me.Label3)
        Me.gbFacturacion.Location = New System.Drawing.Point(12, 369)
        Me.gbFacturacion.Name = "gbFacturacion"
        Me.gbFacturacion.Size = New System.Drawing.Size(733, 380)
        Me.gbFacturacion.TabIndex = 47
        Me.gbFacturacion.TabStop = False
        Me.gbFacturacion.Text = "Datos de facturación"
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(615, 116)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.ReadOnly = True
        Me.TextBox9.Size = New System.Drawing.Size(107, 20)
        Me.TextBox9.TabIndex = 64
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(612, 101)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 13)
        Me.Label11.TabIndex = 63
        Me.Label11.Text = "Precio Total"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(502, 116)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.ReadOnly = True
        Me.TextBox8.Size = New System.Drawing.Size(107, 20)
        Me.TextBox8.TabIndex = 62
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(499, 101)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 13)
        Me.Label10.TabIndex = 61
        Me.Label10.Text = "Cantidad"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.YellowGreen
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button4.Location = New System.Drawing.Point(590, 169)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(132, 28)
        Me.Button4.TabIndex = 49
        Me.Button4.Text = "Cargar Datos"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(389, 60)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(333, 20)
        Me.TextBox7.TabIndex = 60
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
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(389, 116)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ReadOnly = True
        Me.TextBox6.Size = New System.Drawing.Size(107, 20)
        Me.TextBox6.TabIndex = 58
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(386, 101)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 13)
        Me.Label8.TabIndex = 57
        Me.Label8.Text = "Precio Unitario"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(129, 116)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(254, 20)
        Me.TextBox5.TabIndex = 56
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(126, 101)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 55
        Me.Label7.Text = "Descripción"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(16, 116)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(107, 20)
        Me.TextBox4.TabIndex = 54
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 101)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "ID Producto"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(129, 60)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(254, 20)
        Me.TextBox3.TabIndex = 52
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
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(16, 60)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(107, 20)
        Me.TextBox2.TabIndex = 50
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
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(16, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.Size = New System.Drawing.Size(706, 263)
        Me.DataGridView1.TabIndex = 48
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAceptar.Location = New System.Drawing.Point(524, 299)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(199, 70)
        Me.btnAceptar.TabIndex = 66
        Me.btnAceptar.Text = "Generar Venta"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnCancelar.Location = New System.Drawing.Point(319, 299)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(199, 70)
        Me.btnCancelar.TabIndex = 65
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'gbImportes
        '
        Me.gbImportes.Controls.Add(Me.Label12)
        Me.gbImportes.Controls.Add(Me.Label13)
        Me.gbImportes.Controls.Add(Me.DataGridView1)
        Me.gbImportes.Controls.Add(Me.btnAceptar)
        Me.gbImportes.Controls.Add(Me.btnCancelar)
        Me.gbImportes.Location = New System.Drawing.Point(762, 369)
        Me.gbImportes.Name = "gbImportes"
        Me.gbImportes.Size = New System.Drawing.Size(733, 380)
        Me.gbImportes.TabIndex = 67
        Me.gbImportes.TabStop = False
        Me.gbImportes.Text = "Importe "
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(122, 314)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 37)
        Me.Label12.TabIndex = 68
        Me.Label12.Text = "0,00"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(9, 314)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(116, 37)
        Me.Label13.TabIndex = 67
        Me.Label13.Text = "Total $"
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnEditar.Location = New System.Drawing.Point(451, 169)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(132, 28)
        Me.btnEditar.TabIndex = 66
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.IndianRed
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(313, 169)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(132, 28)
        Me.Button2.TabIndex = 65
        Me.Button2.Text = "Eliminar"
        Me.Button2.UseVisualStyleBackColor = False
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
        'FormVentasItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1583, 761)
        Me.Controls.Add(Me.gbImportes)
        Me.Controls.Add(Me.gbFacturacion)
        Me.Controls.Add(Me.gbBuscarClientePorId)
        Me.Controls.Add(Me.lblCantidad)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DataGridViewClientes)
        Me.Controls.Add(Me.gbBuscarProducto)
        Me.Controls.Add(Me.btnCrear)
        Me.Controls.Add(Me.lblListaDeClientes)
        Me.Controls.Add(Me.DataGridViewProductos)
        Me.Controls.Add(Me.btnEliminar)
        Me.MaximizeBox = False
        Me.Name = "FormVentasItems"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generar Venta"
        Me.gbBuscarProducto.ResumeLayout(False)
        Me.gbBuscarProducto.PerformLayout()
        CType(Me.DataGridViewProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbBuscarClientePorId.ResumeLayout(False)
        Me.gbBuscarClientePorId.PerformLayout()
        Me.gbFacturacion.ResumeLayout(False)
        Me.gbFacturacion.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbImportes.ResumeLayout(False)
        Me.gbImportes.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbBuscarProducto As GroupBox
    Friend WithEvents txtBuscarProductoPorId As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbBuscarCategoria As ComboBox
    Friend WithEvents btnCrear As Button
    Friend WithEvents lblListaDeClientes As Label
    Friend WithEvents DataGridViewProductos As DataGridView
    Friend WithEvents btnEliminar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents tbtBuscarClientePorId As TextBox
    Friend WithEvents DataGridViewClientes As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents lblCantidad As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents gbBuscarClientePorId As GroupBox
    Friend WithEvents gbFacturacion As GroupBox
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents gbImportes As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents btnEditar As Button
    Friend WithEvents Button2 As Button
End Class
