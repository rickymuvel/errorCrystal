<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FINANCIERO5
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
        Me.dgExcel = New System.Windows.Forms.DataGridView()
        Me.btnCargar = New System.Windows.Forms.Button()
        Me.txtRuta = New System.Windows.Forms.TextBox()
        Me.cboHojas = New System.Windows.Forms.ComboBox()
        Me.gbCarta = New System.Windows.Forms.GroupBox()
        Me.lblTotalListaUnica = New System.Windows.Forms.Label()
        Me.btnListaUnica = New System.Windows.Forms.Button()
        Me.dgListaUnica = New System.Windows.Forms.DataGridView()
        Me.documento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dep = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cartera = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblRestantes = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboOrden = New System.Windows.Forms.ComboBox()
        Me.lblFilasCarta = New System.Windows.Forms.Label()
        Me.lblColumnasCarta = New System.Windows.Forms.Label()
        Me.lblMensaje = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.txtCriterio = New System.Windows.Forms.TextBox()
        Me.cboFiltros = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dgExcel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbCarta.SuspendLayout()
        CType(Me.dgListaUnica, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgExcel
        '
        Me.dgExcel.AllowUserToAddRows = False
        Me.dgExcel.AllowUserToDeleteRows = False
        Me.dgExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgExcel.Enabled = False
        Me.dgExcel.Location = New System.Drawing.Point(21, 67)
        Me.dgExcel.Name = "dgExcel"
        Me.dgExcel.ReadOnly = True
        Me.dgExcel.Size = New System.Drawing.Size(968, 175)
        Me.dgExcel.TabIndex = 0
        '
        'btnCargar
        '
        Me.btnCargar.Location = New System.Drawing.Point(21, 24)
        Me.btnCargar.Name = "btnCargar"
        Me.btnCargar.Size = New System.Drawing.Size(172, 23)
        Me.btnCargar.TabIndex = 1
        Me.btnCargar.Text = "Seleccionar archivo..."
        Me.btnCargar.UseVisualStyleBackColor = True
        '
        'txtRuta
        '
        Me.txtRuta.Enabled = False
        Me.txtRuta.Location = New System.Drawing.Point(228, 27)
        Me.txtRuta.Name = "txtRuta"
        Me.txtRuta.Size = New System.Drawing.Size(267, 20)
        Me.txtRuta.TabIndex = 2
        '
        'cboHojas
        '
        Me.cboHojas.Enabled = False
        Me.cboHojas.FormattingEnabled = True
        Me.cboHojas.Location = New System.Drawing.Point(516, 26)
        Me.cboHojas.Name = "cboHojas"
        Me.cboHojas.Size = New System.Drawing.Size(176, 21)
        Me.cboHojas.TabIndex = 3
        '
        'gbCarta
        '
        Me.gbCarta.Controls.Add(Me.txtCriterio)
        Me.gbCarta.Controls.Add(Me.cboFiltros)
        Me.gbCarta.Controls.Add(Me.Label2)
        Me.gbCarta.Controls.Add(Me.lblTotalListaUnica)
        Me.gbCarta.Controls.Add(Me.btnListaUnica)
        Me.gbCarta.Controls.Add(Me.dgListaUnica)
        Me.gbCarta.Controls.Add(Me.lblRestantes)
        Me.gbCarta.Controls.Add(Me.Label1)
        Me.gbCarta.Controls.Add(Me.cboOrden)
        Me.gbCarta.Controls.Add(Me.lblFilasCarta)
        Me.gbCarta.Controls.Add(Me.lblColumnasCarta)
        Me.gbCarta.Controls.Add(Me.dgExcel)
        Me.gbCarta.Location = New System.Drawing.Point(21, 65)
        Me.gbCarta.Name = "gbCarta"
        Me.gbCarta.Size = New System.Drawing.Size(1004, 520)
        Me.gbCarta.TabIndex = 6
        Me.gbCarta.TabStop = False
        Me.gbCarta.Text = "Configurar Carta"
        '
        'lblTotalListaUnica
        '
        Me.lblTotalListaUnica.AutoSize = True
        Me.lblTotalListaUnica.Location = New System.Drawing.Point(18, 495)
        Me.lblTotalListaUnica.Name = "lblTotalListaUnica"
        Me.lblTotalListaUnica.Size = New System.Drawing.Size(0, 13)
        Me.lblTotalListaUnica.TabIndex = 12
        '
        'btnListaUnica
        '
        Me.btnListaUnica.Enabled = False
        Me.btnListaUnica.Location = New System.Drawing.Point(862, 255)
        Me.btnListaUnica.Name = "btnListaUnica"
        Me.btnListaUnica.Size = New System.Drawing.Size(127, 23)
        Me.btnListaUnica.TabIndex = 11
        Me.btnListaUnica.Text = "Generar lista única"
        Me.btnListaUnica.UseVisualStyleBackColor = True
        '
        'dgListaUnica
        '
        Me.dgListaUnica.AllowDrop = True
        Me.dgListaUnica.AllowUserToAddRows = False
        Me.dgListaUnica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgListaUnica.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.documento, Me.nombre, Me.direccion, Me.dep, Me.pro, Me.dis, Me.cartera})
        Me.dgListaUnica.Location = New System.Drawing.Point(22, 298)
        Me.dgListaUnica.Name = "dgListaUnica"
        Me.dgListaUnica.ReadOnly = True
        Me.dgListaUnica.Size = New System.Drawing.Size(967, 182)
        Me.dgListaUnica.TabIndex = 10
        '
        'documento
        '
        Me.documento.HeaderText = "Documento"
        Me.documento.Name = "documento"
        Me.documento.ReadOnly = True
        '
        'nombre
        '
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        '
        'direccion
        '
        Me.direccion.HeaderText = "Direccion"
        Me.direccion.Name = "direccion"
        Me.direccion.ReadOnly = True
        '
        'dep
        '
        Me.dep.HeaderText = "Dep"
        Me.dep.Name = "dep"
        Me.dep.ReadOnly = True
        '
        'pro
        '
        Me.pro.HeaderText = "Pro"
        Me.pro.Name = "pro"
        Me.pro.ReadOnly = True
        '
        'dis
        '
        Me.dis.HeaderText = "Dis"
        Me.dis.Name = "dis"
        Me.dis.ReadOnly = True
        '
        'cartera
        '
        Me.cartera.HeaderText = "Cartera"
        Me.cartera.Name = "cartera"
        Me.cartera.ReadOnly = True
        '
        'lblRestantes
        '
        Me.lblRestantes.AutoSize = True
        Me.lblRestantes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblRestantes.Location = New System.Drawing.Point(163, 240)
        Me.lblRestantes.Name = "lblRestantes"
        Me.lblRestantes.Size = New System.Drawing.Size(0, 13)
        Me.lblRestantes.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(666, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Seleccionar Documento"
        '
        'cboOrden
        '
        Me.cboOrden.AllowDrop = True
        Me.cboOrden.Enabled = False
        Me.cboOrden.FormattingEnabled = True
        Me.cboOrden.Location = New System.Drawing.Point(793, 34)
        Me.cboOrden.Name = "cboOrden"
        Me.cboOrden.Size = New System.Drawing.Size(196, 21)
        Me.cboOrden.TabIndex = 4
        '
        'lblFilasCarta
        '
        Me.lblFilasCarta.AutoSize = True
        Me.lblFilasCarta.Location = New System.Drawing.Point(19, 257)
        Me.lblFilasCarta.Name = "lblFilasCarta"
        Me.lblFilasCarta.Size = New System.Drawing.Size(0, 13)
        Me.lblFilasCarta.TabIndex = 3
        '
        'lblColumnasCarta
        '
        Me.lblColumnasCarta.AutoSize = True
        Me.lblColumnasCarta.Location = New System.Drawing.Point(19, 240)
        Me.lblColumnasCarta.Name = "lblColumnasCarta"
        Me.lblColumnasCarta.Size = New System.Drawing.Size(0, 13)
        Me.lblColumnasCarta.TabIndex = 2
        '
        'lblMensaje
        '
        Me.lblMensaje.AutoSize = True
        Me.lblMensaje.ForeColor = System.Drawing.Color.Red
        Me.lblMensaje.Location = New System.Drawing.Point(639, 613)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(0, 13)
        Me.lblMensaje.TabIndex = 14
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(43, 603)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 15
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.Location = New System.Drawing.Point(847, 603)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(64, 23)
        Me.btnGuardar.TabIndex = 13
        Me.btnGuardar.Text = "Insertar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnGenerar
        '
        Me.btnGenerar.Enabled = False
        Me.btnGenerar.Location = New System.Drawing.Point(917, 603)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(93, 23)
        Me.btnGenerar.TabIndex = 1
        Me.btnGenerar.Text = "Generar cartas"
        Me.btnGenerar.UseVisualStyleBackColor = True
        '
        'txtCriterio
        '
        Me.txtCriterio.Enabled = False
        Me.txtCriterio.Location = New System.Drawing.Point(22, 34)
        Me.txtCriterio.Name = "txtCriterio"
        Me.txtCriterio.Size = New System.Drawing.Size(178, 20)
        Me.txtCriterio.TabIndex = 36
        '
        'cboFiltros
        '
        Me.cboFiltros.AllowDrop = True
        Me.cboFiltros.Enabled = False
        Me.cboFiltros.FormattingEnabled = True
        Me.cboFiltros.Location = New System.Drawing.Point(253, 33)
        Me.cboFiltros.Name = "cboFiltros"
        Me.cboFiltros.Size = New System.Drawing.Size(196, 21)
        Me.cboFiltros.TabIndex = 35
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(215, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Filtrar"
        '
        'FINANCIERO5
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1060, 653)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.lblMensaje)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.gbCarta)
        Me.Controls.Add(Me.cboHojas)
        Me.Controls.Add(Me.txtRuta)
        Me.Controls.Add(Me.btnCargar)
        Me.Controls.Add(Me.btnGenerar)
        Me.MaximizeBox = False
        Me.Name = "FINANCIERO5"
        Me.Text = ":: Banco BCP - Generar Cartas - Kobsa ::"
        CType(Me.dgExcel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbCarta.ResumeLayout(False)
        Me.gbCarta.PerformLayout()
        CType(Me.dgListaUnica, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgExcel As System.Windows.Forms.DataGridView
    Friend WithEvents btnCargar As System.Windows.Forms.Button
    Friend WithEvents txtRuta As System.Windows.Forms.TextBox
    Friend WithEvents cboHojas As System.Windows.Forms.ComboBox
    Friend WithEvents gbCarta As System.Windows.Forms.GroupBox
    Friend WithEvents btnGenerar As System.Windows.Forms.Button
    Friend WithEvents lblColumnasCarta As System.Windows.Forms.Label
    Friend WithEvents lblFilasCarta As System.Windows.Forms.Label
    Friend WithEvents cboOrden As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblRestantes As System.Windows.Forms.Label
    Friend WithEvents dgListaUnica As System.Windows.Forms.DataGridView
    Friend WithEvents btnListaUnica As System.Windows.Forms.Button
    Friend WithEvents lblTotalListaUnica As System.Windows.Forms.Label
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents lblMensaje As System.Windows.Forms.Label
    Friend WithEvents documento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents direccion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dep As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dis As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cartera As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents txtCriterio As System.Windows.Forms.TextBox
    Friend WithEvents cboFiltros As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
