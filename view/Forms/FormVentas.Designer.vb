<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormVentas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormVentas))
        Me.gbBuscarProducto = New System.Windows.Forms.GroupBox()
        Me.txtBuscarVentaPorIdCLiente = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBuscarVentaPorId = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridViewDetalleItems = New System.Windows.Forms.DataGridView()
        Me.gbDetallesVenta = New System.Windows.Forms.GroupBox()
        Me.lblPrecioFinal = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtCorreoCliente = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtNombreCliente = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtIdCliente = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnCargarDetalles = New System.Windows.Forms.Button()
        Me.btnBorrarDetalles = New System.Windows.Forms.Button()
        Me.DataGridViewVentas = New System.Windows.Forms.DataGridView()
        Me.gbBuscarProducto.SuspendLayout()
        CType(Me.DataGridViewDetalleItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDetallesVenta.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridViewVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbBuscarProducto
        '
        Me.gbBuscarProducto.Controls.Add(Me.txtBuscarVentaPorIdCLiente)
        Me.gbBuscarProducto.Controls.Add(Me.Label2)
        Me.gbBuscarProducto.Controls.Add(Me.txtBuscarVentaPorId)
        Me.gbBuscarProducto.Controls.Add(Me.Label1)
        Me.gbBuscarProducto.Location = New System.Drawing.Point(12, 12)
        Me.gbBuscarProducto.Name = "gbBuscarProducto"
        Me.gbBuscarProducto.Size = New System.Drawing.Size(1240, 82)
        Me.gbBuscarProducto.TabIndex = 30
        Me.gbBuscarProducto.TabStop = False
        Me.gbBuscarProducto.Text = "Buscar Venta"
        '
        'txtBuscarVentaPorIdCLiente
        '
        Me.txtBuscarVentaPorIdCLiente.Location = New System.Drawing.Point(639, 39)
        Me.txtBuscarVentaPorIdCLiente.Name = "txtBuscarVentaPorIdCLiente"
        Me.txtBuscarVentaPorIdCLiente.Size = New System.Drawing.Size(277, 20)
        Me.txtBuscarVentaPorIdCLiente.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(636, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Ingresa ID Cliente"
        '
        'txtBuscarVentaPorId
        '
        Me.txtBuscarVentaPorId.Location = New System.Drawing.Point(330, 38)
        Me.txtBuscarVentaPorId.Name = "txtBuscarVentaPorId"
        Me.txtBuscarVentaPorId.Size = New System.Drawing.Size(277, 20)
        Me.txtBuscarVentaPorId.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(327, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Ingresa ID de Venta"
        '
        'DataGridViewDetalleItems
        '
        Me.DataGridViewDetalleItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewDetalleItems.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewDetalleItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewDetalleItems.Location = New System.Drawing.Point(15, 84)
        Me.DataGridViewDetalleItems.Name = "DataGridViewDetalleItems"
        Me.DataGridViewDetalleItems.ReadOnly = True
        Me.DataGridViewDetalleItems.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewDetalleItems.Size = New System.Drawing.Size(1211, 180)
        Me.DataGridViewDetalleItems.TabIndex = 33
        '
        'gbDetallesVenta
        '
        Me.gbDetallesVenta.Controls.Add(Me.lblPrecioFinal)
        Me.gbDetallesVenta.Controls.Add(Me.Label13)
        Me.gbDetallesVenta.Controls.Add(Me.txtCorreoCliente)
        Me.gbDetallesVenta.Controls.Add(Me.Label9)
        Me.gbDetallesVenta.Controls.Add(Me.txtNombreCliente)
        Me.gbDetallesVenta.Controls.Add(Me.Label5)
        Me.gbDetallesVenta.Controls.Add(Me.txtIdCliente)
        Me.gbDetallesVenta.Controls.Add(Me.Label4)
        Me.gbDetallesVenta.Controls.Add(Me.DataGridViewDetalleItems)
        Me.gbDetallesVenta.Location = New System.Drawing.Point(12, 403)
        Me.gbDetallesVenta.Name = "gbDetallesVenta"
        Me.gbDetallesVenta.Size = New System.Drawing.Size(1240, 369)
        Me.gbDetallesVenta.TabIndex = 35
        Me.gbDetallesVenta.TabStop = False
        Me.gbDetallesVenta.Text = "Detalles de la venta"
        '
        'lblPrecioFinal
        '
        Me.lblPrecioFinal.AutoSize = True
        Me.lblPrecioFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecioFinal.Location = New System.Drawing.Point(1142, 281)
        Me.lblPrecioFinal.Name = "lblPrecioFinal"
        Me.lblPrecioFinal.Size = New System.Drawing.Size(80, 37)
        Me.lblPrecioFinal.TabIndex = 77
        Me.lblPrecioFinal.Text = "0,00"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(997, 281)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(116, 37)
        Me.Label13.TabIndex = 76
        Me.Label13.Text = "Total $"
        '
        'txtCorreoCliente
        '
        Me.txtCorreoCliente.Location = New System.Drawing.Point(388, 45)
        Me.txtCorreoCliente.Name = "txtCorreoCliente"
        Me.txtCorreoCliente.ReadOnly = True
        Me.txtCorreoCliente.Size = New System.Drawing.Size(333, 20)
        Me.txtCorreoCliente.TabIndex = 75
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(385, 29)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 13)
        Me.Label9.TabIndex = 74
        Me.Label9.Text = "Correo Cliente"
        '
        'txtNombreCliente
        '
        Me.txtNombreCliente.Location = New System.Drawing.Point(128, 45)
        Me.txtNombreCliente.Name = "txtNombreCliente"
        Me.txtNombreCliente.ReadOnly = True
        Me.txtNombreCliente.Size = New System.Drawing.Size(254, 20)
        Me.txtNombreCliente.TabIndex = 73
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(125, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 13)
        Me.Label5.TabIndex = 72
        Me.Label5.Text = "Nombre Cliente"
        '
        'txtIdCliente
        '
        Me.txtIdCliente.Location = New System.Drawing.Point(15, 45)
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.ReadOnly = True
        Me.txtIdCliente.Size = New System.Drawing.Size(107, 20)
        Me.txtIdCliente.TabIndex = 71
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 70
        Me.Label4.Text = "ID Cliente"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnCargarDetalles)
        Me.GroupBox2.Controls.Add(Me.btnBorrarDetalles)
        Me.GroupBox2.Controls.Add(Me.DataGridViewVentas)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 113)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1240, 272)
        Me.GroupBox2.TabIndex = 36
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Lista de Ventas"
        '
        'btnCargarDetalles
        '
        Me.btnCargarDetalles.BackColor = System.Drawing.Color.YellowGreen
        Me.btnCargarDetalles.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCargarDetalles.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCargarDetalles.Location = New System.Drawing.Point(129, 227)
        Me.btnCargarDetalles.Name = "btnCargarDetalles"
        Me.btnCargarDetalles.Size = New System.Drawing.Size(132, 31)
        Me.btnCargarDetalles.TabIndex = 36
        Me.btnCargarDetalles.Text = "Cargar Detalles"
        Me.btnCargarDetalles.UseVisualStyleBackColor = False
        '
        'btnBorrarDetalles
        '
        Me.btnBorrarDetalles.BackColor = System.Drawing.Color.IndianRed
        Me.btnBorrarDetalles.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrarDetalles.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBorrarDetalles.Location = New System.Drawing.Point(15, 227)
        Me.btnBorrarDetalles.Name = "btnBorrarDetalles"
        Me.btnBorrarDetalles.Size = New System.Drawing.Size(108, 31)
        Me.btnBorrarDetalles.TabIndex = 35
        Me.btnBorrarDetalles.Text = "Borrar"
        Me.btnBorrarDetalles.UseVisualStyleBackColor = False
        '
        'DataGridViewVentas
        '
        Me.DataGridViewVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewVentas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewVentas.Location = New System.Drawing.Point(15, 28)
        Me.DataGridViewVentas.Name = "DataGridViewVentas"
        Me.DataGridViewVentas.ReadOnly = True
        Me.DataGridViewVentas.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewVentas.Size = New System.Drawing.Size(1211, 193)
        Me.DataGridViewVentas.TabIndex = 33
        '
        'FormVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 797)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.gbDetallesVenta)
        Me.Controls.Add(Me.gbBuscarProducto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FormVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ventas"
        Me.gbBuscarProducto.ResumeLayout(False)
        Me.gbBuscarProducto.PerformLayout()
        CType(Me.DataGridViewDetalleItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDetallesVenta.ResumeLayout(False)
        Me.gbDetallesVenta.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridViewVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbBuscarProducto As GroupBox
    Friend WithEvents txtBuscarVentaPorIdCLiente As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBuscarVentaPorId As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridViewDetalleItems As DataGridView
    Friend WithEvents gbDetallesVenta As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataGridViewVentas As DataGridView
    Friend WithEvents txtCorreoCliente As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtNombreCliente As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtIdCliente As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblPrecioFinal As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents btnCargarDetalles As Button
    Friend WithEvents btnBorrarDetalles As Button
End Class
