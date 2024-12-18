<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProducto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormProducto))
        Me.Panel = New System.Windows.Forms.Panel()
        Me.cmbCategoria = New System.Windows.Forms.ComboBox()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.lblId = New System.Windows.Forms.Label()
        Me.lblCategoria = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.btnCrear = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblListaDeClientes = New System.Windows.Forms.Label()
        Me.DataGridViewProductos = New System.Windows.Forms.DataGridView()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.cmbBuscarCategoria = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gbBuscarProducto = New System.Windows.Forms.GroupBox()
        Me.txtBuscarProductoPorId = New System.Windows.Forms.TextBox()
        Me.Panel.SuspendLayout()
        CType(Me.DataGridViewProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbBuscarProducto.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel
        '
        Me.Panel.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel.Controls.Add(Me.cmbCategoria)
        Me.Panel.Controls.Add(Me.btnAceptar)
        Me.Panel.Controls.Add(Me.btnCancelar)
        Me.Panel.Controls.Add(Me.lblId)
        Me.Panel.Controls.Add(Me.lblCategoria)
        Me.Panel.Controls.Add(Me.txtId)
        Me.Panel.Controls.Add(Me.lblPrecio)
        Me.Panel.Controls.Add(Me.txtNombre)
        Me.Panel.Controls.Add(Me.LblNombre)
        Me.Panel.Controls.Add(Me.txtPrecio)
        Me.Panel.Location = New System.Drawing.Point(686, 112)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(244, 400)
        Me.Panel.TabIndex = 19
        '
        'cmbCategoria
        '
        Me.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCategoria.FormattingEnabled = True
        Me.cmbCategoria.Location = New System.Drawing.Point(27, 185)
        Me.cmbCategoria.Name = "cmbCategoria"
        Me.cmbCategoria.Size = New System.Drawing.Size(186, 21)
        Me.cmbCategoria.TabIndex = 29
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAceptar.Location = New System.Drawing.Point(27, 232)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(199, 45)
        Me.btnAceptar.TabIndex = 2
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnCancelar.Location = New System.Drawing.Point(27, 296)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(199, 45)
        Me.btnCancelar.TabIndex = 1
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Location = New System.Drawing.Point(24, 48)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(18, 13)
        Me.lblId.TabIndex = 7
        Me.lblId.Text = "ID"
        '
        'lblCategoria
        '
        Me.lblCategoria.AutoSize = True
        Me.lblCategoria.Location = New System.Drawing.Point(25, 165)
        Me.lblCategoria.Name = "lblCategoria"
        Me.lblCategoria.Size = New System.Drawing.Size(52, 13)
        Me.lblCategoria.TabIndex = 15
        Me.lblCategoria.Text = "Categoria"
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(27, 64)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(186, 20)
        Me.txtId.TabIndex = 9
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Location = New System.Drawing.Point(25, 126)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(37, 13)
        Me.lblPrecio.TabIndex = 14
        Me.lblPrecio.Text = "Precio"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(27, 101)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(186, 20)
        Me.txtNombre.TabIndex = 10
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Location = New System.Drawing.Point(25, 88)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(44, 13)
        Me.LblNombre.TabIndex = 13
        Me.LblNombre.Text = "Nombre"
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(27, 141)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(186, 20)
        Me.txtPrecio.TabIndex = 11
        '
        'btnCrear
        '
        Me.btnCrear.BackColor = System.Drawing.Color.YellowGreen
        Me.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCrear.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCrear.Location = New System.Drawing.Point(524, 464)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(132, 39)
        Me.btnCrear.TabIndex = 26
        Me.btnCrear.Text = "Crear"
        Me.btnCrear.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Ingresa ID"
        '
        'lblListaDeClientes
        '
        Me.lblListaDeClientes.AutoSize = True
        Me.lblListaDeClientes.Location = New System.Drawing.Point(15, 97)
        Me.lblListaDeClientes.Name = "lblListaDeClientes"
        Me.lblListaDeClientes.Size = New System.Drawing.Size(95, 13)
        Me.lblListaDeClientes.TabIndex = 24
        Me.lblListaDeClientes.Text = "Lista de Productos"
        '
        'DataGridViewProductos
        '
        Me.DataGridViewProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewProductos.Location = New System.Drawing.Point(14, 112)
        Me.DataGridViewProductos.Name = "DataGridViewProductos"
        Me.DataGridViewProductos.ReadOnly = True
        Me.DataGridViewProductos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewProductos.Size = New System.Drawing.Size(642, 332)
        Me.DataGridViewProductos.TabIndex = 22
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnEditar.Location = New System.Drawing.Point(386, 464)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(132, 39)
        Me.btnEditar.TabIndex = 21
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.IndianRed
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnEliminar.Location = New System.Drawing.Point(248, 464)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(132, 39)
        Me.btnEliminar.TabIndex = 20
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'cmbBuscarCategoria
        '
        Me.cmbBuscarCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBuscarCategoria.FormattingEnabled = True
        Me.cmbBuscarCategoria.Location = New System.Drawing.Point(345, 43)
        Me.cmbBuscarCategoria.Name = "cmbBuscarCategoria"
        Me.cmbBuscarCategoria.Size = New System.Drawing.Size(304, 21)
        Me.cmbBuscarCategoria.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(342, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Elegi Categoria"
        '
        'gbBuscarProducto
        '
        Me.gbBuscarProducto.Controls.Add(Me.txtBuscarProductoPorId)
        Me.gbBuscarProducto.Controls.Add(Me.Label2)
        Me.gbBuscarProducto.Controls.Add(Me.Label1)
        Me.gbBuscarProducto.Controls.Add(Me.cmbBuscarCategoria)
        Me.gbBuscarProducto.Location = New System.Drawing.Point(12, 12)
        Me.gbBuscarProducto.Name = "gbBuscarProducto"
        Me.gbBuscarProducto.Size = New System.Drawing.Size(666, 82)
        Me.gbBuscarProducto.TabIndex = 29
        Me.gbBuscarProducto.TabStop = False
        Me.gbBuscarProducto.Text = "Buscar Producto"
        '
        'txtBuscarProductoPorId
        '
        Me.txtBuscarProductoPorId.Location = New System.Drawing.Point(11, 43)
        Me.txtBuscarProductoPorId.Name = "txtBuscarProductoPorId"
        Me.txtBuscarProductoPorId.Size = New System.Drawing.Size(277, 20)
        Me.txtBuscarProductoPorId.TabIndex = 29
        '
        'FormProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(945, 537)
        Me.Controls.Add(Me.gbBuscarProducto)
        Me.Controls.Add(Me.btnCrear)
        Me.Controls.Add(Me.lblListaDeClientes)
        Me.Controls.Add(Me.DataGridViewProductos)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.Panel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FormProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Productos"
        Me.Panel.ResumeLayout(False)
        Me.Panel.PerformLayout()
        CType(Me.DataGridViewProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbBuscarProducto.ResumeLayout(False)
        Me.gbBuscarProducto.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel As Panel
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents lblId As Label
    Friend WithEvents lblCategoria As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents lblPrecio As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents LblNombre As Label
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents btnCrear As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblListaDeClientes As Label
    Friend WithEvents DataGridViewProductos As DataGridView
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents gbBuscarProducto As GroupBox
    Friend WithEvents cmbCategoria As ComboBox
    Friend WithEvents txtBuscarProductoPorId As TextBox
    Friend WithEvents cmbBuscarCategoria As ComboBox
End Class
