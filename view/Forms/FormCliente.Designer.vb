<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCliente))
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.DataGridViewClientes = New System.Windows.Forms.DataGridView()
        Me.lblId = New System.Windows.Forms.Label()
        Me.tbtBuscarClientePorId = New System.Windows.Forms.TextBox()
        Me.tbtId = New System.Windows.Forms.TextBox()
        Me.tbtCliente = New System.Windows.Forms.TextBox()
        Me.tbtTelefono = New System.Windows.Forms.TextBox()
        Me.tbtCorreo = New System.Windows.Forms.TextBox()
        Me.LblCliente = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblCorreo = New System.Windows.Forms.Label()
        Me.lblListaDeClientes = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel = New System.Windows.Forms.Panel()
        Me.btnCrear = New System.Windows.Forms.Button()
        CType(Me.DataGridViewClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel.SuspendLayout()
        Me.SuspendLayout()
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
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.IndianRed
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnEliminar.Location = New System.Drawing.Point(246, 465)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(132, 39)
        Me.btnEliminar.TabIndex = 3
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnEditar.Location = New System.Drawing.Point(384, 465)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(132, 39)
        Me.btnEditar.TabIndex = 4
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'DataGridViewClientes
        '
        Me.DataGridViewClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewClientes.Location = New System.Drawing.Point(12, 113)
        Me.DataGridViewClientes.Name = "DataGridViewClientes"
        Me.DataGridViewClientes.ReadOnly = True
        Me.DataGridViewClientes.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewClientes.Size = New System.Drawing.Size(642, 332)
        Me.DataGridViewClientes.TabIndex = 6
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
        'tbtBuscarClientePorId
        '
        Me.tbtBuscarClientePorId.Location = New System.Drawing.Point(11, 44)
        Me.tbtBuscarClientePorId.Name = "tbtBuscarClientePorId"
        Me.tbtBuscarClientePorId.Size = New System.Drawing.Size(277, 20)
        Me.tbtBuscarClientePorId.TabIndex = 8
        '
        'tbtId
        '
        Me.tbtId.Location = New System.Drawing.Point(27, 64)
        Me.tbtId.Name = "tbtId"
        Me.tbtId.Size = New System.Drawing.Size(186, 20)
        Me.tbtId.TabIndex = 9
        '
        'tbtCliente
        '
        Me.tbtCliente.Location = New System.Drawing.Point(27, 101)
        Me.tbtCliente.Name = "tbtCliente"
        Me.tbtCliente.Size = New System.Drawing.Size(186, 20)
        Me.tbtCliente.TabIndex = 10
        '
        'tbtTelefono
        '
        Me.tbtTelefono.Location = New System.Drawing.Point(27, 141)
        Me.tbtTelefono.Name = "tbtTelefono"
        Me.tbtTelefono.Size = New System.Drawing.Size(186, 20)
        Me.tbtTelefono.TabIndex = 11
        '
        'tbtCorreo
        '
        Me.tbtCorreo.Location = New System.Drawing.Point(27, 178)
        Me.tbtCorreo.Name = "tbtCorreo"
        Me.tbtCorreo.Size = New System.Drawing.Size(186, 20)
        Me.tbtCorreo.TabIndex = 12
        '
        'LblCliente
        '
        Me.LblCliente.AutoSize = True
        Me.LblCliente.Location = New System.Drawing.Point(25, 88)
        Me.LblCliente.Name = "LblCliente"
        Me.LblCliente.Size = New System.Drawing.Size(39, 13)
        Me.LblCliente.TabIndex = 13
        Me.LblCliente.Text = "Cliente"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(25, 126)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(49, 13)
        Me.lblTelefono.TabIndex = 14
        Me.lblTelefono.Text = "Telefono"
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Location = New System.Drawing.Point(25, 165)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(38, 13)
        Me.lblCorreo.TabIndex = 15
        Me.lblCorreo.Text = "Correo"
        '
        'lblListaDeClientes
        '
        Me.lblListaDeClientes.AutoSize = True
        Me.lblListaDeClientes.Location = New System.Drawing.Point(13, 98)
        Me.lblListaDeClientes.Name = "lblListaDeClientes"
        Me.lblListaDeClientes.Size = New System.Drawing.Size(84, 13)
        Me.lblListaDeClientes.TabIndex = 16
        Me.lblListaDeClientes.Text = "Lista de Clientes"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Buscar cliente por id"
        '
        'Panel
        '
        Me.Panel.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel.Controls.Add(Me.btnAceptar)
        Me.Panel.Controls.Add(Me.btnCancelar)
        Me.Panel.Controls.Add(Me.lblId)
        Me.Panel.Controls.Add(Me.lblCorreo)
        Me.Panel.Controls.Add(Me.tbtId)
        Me.Panel.Controls.Add(Me.lblTelefono)
        Me.Panel.Controls.Add(Me.tbtCliente)
        Me.Panel.Controls.Add(Me.LblCliente)
        Me.Panel.Controls.Add(Me.tbtTelefono)
        Me.Panel.Controls.Add(Me.tbtCorreo)
        Me.Panel.Location = New System.Drawing.Point(678, 113)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(244, 400)
        Me.Panel.TabIndex = 18
        '
        'btnCrear
        '
        Me.btnCrear.BackColor = System.Drawing.Color.YellowGreen
        Me.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCrear.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCrear.Location = New System.Drawing.Point(522, 465)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(132, 39)
        Me.btnCrear.TabIndex = 19
        Me.btnCrear.Text = "Crear"
        Me.btnCrear.UseVisualStyleBackColor = False
        '
        'FormCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(934, 525)
        Me.Controls.Add(Me.btnCrear)
        Me.Controls.Add(Me.Panel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblListaDeClientes)
        Me.Controls.Add(Me.tbtBuscarClientePorId)
        Me.Controls.Add(Me.DataGridViewClientes)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnEliminar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FormCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clientes"
        CType(Me.DataGridViewClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel.ResumeLayout(False)
        Me.Panel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents DataGridViewClientes As DataGridView
    Friend WithEvents lblId As Label
    Friend WithEvents tbtBuscarClientePorId As TextBox
    Friend WithEvents tbtId As TextBox
    Friend WithEvents tbtCliente As TextBox
    Friend WithEvents tbtTelefono As TextBox
    Friend WithEvents tbtCorreo As TextBox
    Friend WithEvents LblCliente As Label
    Friend WithEvents lblTelefono As Label
    Friend WithEvents lblCorreo As Label
    Friend WithEvents lblListaDeClientes As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel As Panel
    Friend WithEvents btnCrear As Button
End Class
