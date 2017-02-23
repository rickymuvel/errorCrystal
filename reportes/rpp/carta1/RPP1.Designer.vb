<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RPP1
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
        Me.txtCriterio3 = New System.Windows.Forms.TextBox()
        Me.cboFiltro3 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCriterio2 = New System.Windows.Forms.TextBox()
        Me.cboFiltro2 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCriterio = New System.Windows.Forms.TextBox()
        Me.cboFiltros = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
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
        Me.lblFilasCarta = New System.Windows.Forms.Label()
        Me.lblColumnasCarta = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboOrden = New System.Windows.Forms.ComboBox()
        Me.lblMensaje = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnGenerar = New System.Windows.Forms.Button()
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
        Me.dgExcel.Location = New System.Drawing.Point(20, 117)
        Me.dgExcel.Name = "dgExcel"
        Me.dgExcel.ReadOnly = True
        Me.dgExcel.Size = New System.Drawing.Size(968, 175)
        Me.dgExcel.TabIndex = 0
        '
        'btnCargar
        '
        Me.btnCargar.Location = New System.Drawing.Point(22, 29)
        Me.btnCargar.Name = "btnCargar"
        Me.btnCargar.Size = New System.Drawing.Size(172, 23)
        Me.btnCargar.TabIndex = 1
        Me.btnCargar.Text = "Seleccionar archivo..."
        Me.btnCargar.UseVisualStyleBackColor = True
        '
        'txtRuta
        '
        Me.txtRuta.Enabled = False
        Me.txtRuta.Location = New System.Drawing.Point(229, 32)
        Me.txtRuta.Name = "txtRuta"
        Me.txtRuta.Size = New System.Drawing.Size(267, 20)
        Me.txtRuta.TabIndex = 2
        '
        'cboHojas
        '
        Me.cboHojas.Enabled = False
        Me.cboHojas.FormattingEnabled = True
        Me.cboHojas.Location = New System.Drawing.Point(517, 31)
        Me.cboHojas.Name = "cboHojas"
        Me.cboHojas.Size = New System.Drawing.Size(176, 21)
        Me.cboHojas.TabIndex = 3
        '
        'gbCarta
        '
        Me.gbCarta.Controls.Add(Me.txtCriterio3)
        Me.gbCarta.Controls.Add(Me.cboFiltro3)
        Me.gbCarta.Controls.Add(Me.Label4)
        Me.gbCarta.Controls.Add(Me.txtCriterio2)
        Me.gbCarta.Controls.Add(Me.cboFiltro2)
        Me.gbCarta.Controls.Add(Me.Label3)
        Me.gbCarta.Controls.Add(Me.txtCriterio)
        Me.gbCarta.Controls.Add(Me.cboFiltros)
        Me.gbCarta.Controls.Add(Me.Label2)
        Me.gbCarta.Controls.Add(Me.lblTotalListaUnica)
        Me.gbCarta.Controls.Add(Me.btnListaUnica)
        Me.gbCarta.Controls.Add(Me.dgListaUnica)
        Me.gbCarta.Controls.Add(Me.lblRestantes)
        Me.gbCarta.Controls.Add(Me.lblFilasCarta)
        Me.gbCarta.Controls.Add(Me.lblColumnasCarta)
        Me.gbCarta.Controls.Add(Me.dgExcel)
        Me.gbCarta.Location = New System.Drawing.Point(21, 59)
        Me.gbCarta.Name = "gbCarta"
        Me.gbCarta.Size = New System.Drawing.Size(1004, 564)
        Me.gbCarta.TabIndex = 6
        Me.gbCarta.TabStop = False
        Me.gbCarta.Text = "Configurar Carta"
        '
        'txtCriterio3
        '
        Me.txtCriterio3.Enabled = False
        Me.txtCriterio3.Location = New System.Drawing.Point(298, 82)
        Me.txtCriterio3.Name = "txtCriterio3"
        Me.txtCriterio3.Size = New System.Drawing.Size(178, 20)
        Me.txtCriterio3.TabIndex = 54
        '
        'cboFiltro3
        '
        Me.cboFiltro3.AllowDrop = True
        Me.cboFiltro3.Enabled = False
        Me.cboFiltro3.FormattingEnabled = True
        Me.cboFiltro3.Location = New System.Drawing.Point(73, 82)
        Me.cboFiltro3.Name = "cboFiltro3"
        Me.cboFiltro3.Size = New System.Drawing.Size(196, 21)
        Me.cboFiltro3.TabIndex = 53
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Tipo Carta"
        '
        'txtCriterio2
        '
        Me.txtCriterio2.Enabled = False
        Me.txtCriterio2.Location = New System.Drawing.Point(298, 56)
        Me.txtCriterio2.Name = "txtCriterio2"
        Me.txtCriterio2.Size = New System.Drawing.Size(178, 20)
        Me.txtCriterio2.TabIndex = 51
        '
        'cboFiltro2
        '
        Me.cboFiltro2.AllowDrop = True
        Me.cboFiltro2.Enabled = False
        Me.cboFiltro2.FormattingEnabled = True
        Me.cboFiltro2.Location = New System.Drawing.Point(73, 56)
        Me.cboFiltro2.Name = "cboFiltro2"
        Me.cboFiltro2.Size = New System.Drawing.Size(196, 21)
        Me.cboFiltro2.TabIndex = 50
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "IdCartera"
        '
        'txtCriterio
        '
        Me.txtCriterio.Enabled = False
        Me.txtCriterio.Location = New System.Drawing.Point(298, 30)
        Me.txtCriterio.Name = "txtCriterio"
        Me.txtCriterio.Size = New System.Drawing.Size(178, 20)
        Me.txtCriterio.TabIndex = 48
        '
        'cboFiltros
        '
        Me.cboFiltros.AllowDrop = True
        Me.cboFiltros.Enabled = False
        Me.cboFiltros.FormattingEnabled = True
        Me.cboFiltros.Location = New System.Drawing.Point(73, 30)
        Me.cboFiltros.Name = "cboFiltros"
        Me.cboFiltros.Size = New System.Drawing.Size(196, 21)
        Me.cboFiltros.TabIndex = 47
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Plaza"
        '
        'lblTotalListaUnica
        '
        Me.lblTotalListaUnica.AutoSize = True
        Me.lblTotalListaUnica.Location = New System.Drawing.Point(24, 535)
        Me.lblTotalListaUnica.Name = "lblTotalListaUnica"
        Me.lblTotalListaUnica.Size = New System.Drawing.Size(0, 13)
        Me.lblTotalListaUnica.TabIndex = 12
        '
        'btnListaUnica
        '
        Me.btnListaUnica.Enabled = False
        Me.btnListaUnica.Location = New System.Drawing.Point(861, 307)
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
        Me.dgListaUnica.Location = New System.Drawing.Point(22, 350)
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
        Me.lblRestantes.Location = New System.Drawing.Point(165, 328)
        Me.lblRestantes.Name = "lblRestantes"
        Me.lblRestantes.Size = New System.Drawing.Size(0, 13)
        Me.lblRestantes.TabIndex = 7
        '
        'lblFilasCarta
        '
        Me.lblFilasCarta.AutoSize = True
        Me.lblFilasCarta.Location = New System.Drawing.Point(24, 326)
        Me.lblFilasCarta.Name = "lblFilasCarta"
        Me.lblFilasCarta.Size = New System.Drawing.Size(0, 13)
        Me.lblFilasCarta.TabIndex = 3
        '
        'lblColumnasCarta
        '
        Me.lblColumnasCarta.AutoSize = True
        Me.lblColumnasCarta.Location = New System.Drawing.Point(24, 309)
        Me.lblColumnasCarta.Name = "lblColumnasCarta"
        Me.lblColumnasCarta.Size = New System.Drawing.Size(0, 13)
        Me.lblColumnasCarta.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(705, 35)
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
        Me.cboOrden.Location = New System.Drawing.Point(832, 32)
        Me.cboOrden.Name = "cboOrden"
        Me.cboOrden.Size = New System.Drawing.Size(196, 21)
        Me.cboOrden.TabIndex = 4
        '
        'lblMensaje
        '
        Me.lblMensaje.AutoSize = True
        Me.lblMensaje.ForeColor = System.Drawing.Color.Red
        Me.lblMensaje.Location = New System.Drawing.Point(639, 644)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(0, 13)
        Me.lblMensaje.TabIndex = 14
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(43, 634)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 15
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.Location = New System.Drawing.Point(832, 638)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(73, 23)
        Me.btnGuardar.TabIndex = 13
        Me.btnGuardar.Text = "Insertar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnGenerar
        '
        Me.btnGenerar.Enabled = False
        Me.btnGenerar.Location = New System.Drawing.Point(910, 638)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(100, 24)
        Me.btnGenerar.TabIndex = 1
        Me.btnGenerar.Text = "Generar cartas"
        Me.btnGenerar.UseVisualStyleBackColor = True
        '
        'RPP1
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1060, 708)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.lblMensaje)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.gbCarta)
        Me.Controls.Add(Me.cboHojas)
        Me.Controls.Add(Me.txtRuta)
        Me.Controls.Add(Me.btnCargar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnGenerar)
        Me.Controls.Add(Me.cboOrden)
        Me.MaximizeBox = False
        Me.Name = "RPP1"
        Me.Text = ":: GRUPO RPP - Generar Cartas - Kobsa ::"
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
    Friend WithEvents txtCriterio3 As System.Windows.Forms.TextBox
    Friend WithEvents cboFiltro3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCriterio2 As System.Windows.Forms.TextBox
    Friend WithEvents cboFiltro2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
