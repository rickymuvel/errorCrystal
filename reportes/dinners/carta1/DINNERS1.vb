Imports System.Data.OleDb
Imports System.Data.DataTableExtensions
Imports System.Data.DataRowExtensions
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Imports MySql.Data.MySqlClient


Public Class DINNERS1
    Dim cn As OleDbConnection
    Dim ruta As String
    Dim restantes As Integer = 15 ' variable que controla las cadenas restantes.
    Dim cont As Integer = 0 'este contador lo creé porque en tres oportunidades me carga el dgColumn, quiero evitar varios messagesbox.show
    Dim cadena As String = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source={0}; Extended Properties='Excel 12.0; HDR=Yes'"

    Dim conn As New MySqlConnection
    Dim ds As New DataSet
    Sub Cargar(etiqueta As String)
        ' MessageBox.Show("select * from [" & etiqueta & "]")
        Try
            ' Preguntamos "si no es" DataRowView entonces quiere decir que estamos hablando de hojas que sí existen.
            If Not (etiqueta = "System.Data.DataRowView") Then
                ' Dim cmd As New OleDbCommand("select top 1 * from [" & etiqueta & "]", cn)
                Dim cmd As New OleDbCommand("select * from [" & etiqueta & "]", cn)

                Dim da As New OleDbDataAdapter

                cn.Open()
                da.SelectCommand = cmd
                cn.Close()

                da.Fill(ds)
                dv.Table = ds.Tables(0)
                dgExcel.Columns.Clear()
                dgExcel.DataSource = dv

                'cargarCampos()
                'gbCampos.Enabled = True
                gbCarta.Enabled = True
                lblColumnasCarta.Text = "0 Columnas"
                lblFilasCarta.Text = "0 Filas"
                txtCriterio.Enabled = True
                'For col As Integer = 0 To dgExcel.Columns.Count - 1
                '    dgExcel.Columns(col).Visible = False
                '    dgExcel.Columns(col).SortMode = DataGridViewColumnSortMode.NotSortable 'Lo configuramos para que no se ordene al hacer click
                'Next
                'dgColumnas.Enabled = True
                cboHojas.Enabled = True
                cboOrden.Enabled = True
                For i As Integer = 0 To dgExcel.Columns.Count - 1
                    limpiarDatos(dgExcel.Columns(i).Index)
                    'MessageBox.Show(dgExcel.Columns(i).Index)
                Next
                btnListaUnica.Enabled = True
                lblColumnasCarta.Text = dgExcel.Columns.Count & " Columnas devueltas"
                lblFilasCarta.Text = dgExcel.Rows.Count & " Filas devueltas"
                'MessageBox.Show("Se ha limpiado el elemento")
                ' Llenamos el Dataset con la información para el subinforme.
                'subInforme()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub connect()
        Try
            Dim Database As String = "test"
            Dim server As String = "localhost"
            Dim username As String = "root"
            Dim password As String = ""
            conn.ConnectionString = String.Format("Server={0}; user id={1};password={2}; database={3};pooling=false", server, username, password, Database)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'Sub cargarCampos()
    '    ' Obtener el número de columnas de un DataGridView
    '    ' Dim num As Integer = dgExcel.Columns.Count
    '    ' dgExcel.Columns(0).Name.ToString
    '    ' MessageBox.Show(dgExcel.Columns(0).HeaderCell.Value)
    '    dgColumnas.Rows.Clear()
    '    For col As Integer = 0 To dgExcel.Columns.Count - 1
    '        dgColumnas.Rows.Add(dgExcel.Columns(col).HeaderCell.Value)
    '    Next

    '    cont = cont + 1
    '    If (cont = 2 And (dgColumnas.Rows.Count - 1) < 15) Then
    '        MessageBox.Show("El Excel que intenta cargar tiene menos de 15 columnas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    Else
    '        lblColumnas.Text = dgColumnas.Rows.Count - 1 & " Columnas en total"
    '    End If
    'End Sub

    ' Función que es utilizada para cargar las etiquetas en el combobox.
    Sub Etiquetas()
        Try
            Dim filePath As String = txtRuta.Text
            Dim connString As String = String.Empty
            If filePath.EndsWith(".xlsx") Then            '2007 Format            
                connString = String.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR=No'", filePath)
            Else            '2003 Format            
                connString = String.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties='Excel 8.0;HDR=No'", filePath)
            End If         'Get the Sheets in Excel WorkBook        
            Dim connExcel As New OleDbConnection(connString)
            Dim cmdExcel As New OleDbCommand()
            Dim oda As New OleDbDataAdapter()
            cmdExcel.Connection = connExcel
            connExcel.Open()
            cboHojas.DataSource = connExcel.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, Nothing)
            cboHojas.DisplayMember = "TABLE_NAME"
            cboHojas.ValueMember = "TABLE_NAME"
            connExcel.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        Try
            Dim op As New OpenFileDialog
            op.Filter = "archivo de excel 12.0|*.xlsx"
            If op.ShowDialog = DialogResult.OK Then
                cadena = String.Format(cadena, op.FileName)
                ruta = op.FileName
                txtRuta.Text = ruta
                cn = New OleDbConnection(cadena)
                ' Buscamos las etiquetas
                Etiquetas()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cboHojas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboHojas.SelectedIndexChanged
        Try
            ' Obtenemos la etiqueta del combobox para luego cargar su contenido.
            Dim etiqueta As String = cboHojas.Text.ToString
            Cargar(etiqueta)
            For i As Integer = 0 To dgExcel.Columns.Count - 1
                cboOrden.Items.Add(dgExcel.Columns(i).HeaderCell.Value)
                cboFiltros.Items.Add(dgExcel.Columns(i).HeaderCell.Value)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'cargarCampos()
    End Sub

    'Sub contarColVisibles()
    '    Dim totCol As Integer = 0

    '    For col As Integer = 0 To dgExcel.Columns.Count - 1
    '        If (dgExcel.Columns(col).Visible = True) Then
    '            totCol = totCol + 1
    '        End If
    '    Next
    '    Dim res As Integer = restantes - totCol
    '    If Not res = 0 Then
    '        lblRestantes.Text = res & " Restantes (Obligatorio)"
    '        'btnGuardar.Enabled = False
    '    Else
    '        lblRestantes.Text = ""
    '        'btnGuardar.Enabled = True
    '    End If
    '    lblColumnasCarta.Text = totCol & " Columnas seleccionadas"
    '    lblFilasCarta.Text = dgExcel.Rows.Count & " Filas devueltas"
    'End Sub

    'Private Sub dgColumnas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgColumnas.CellClick
    '    Try
    '        Dim fila As Integer
    '        dgColumnas.Rows(e.RowIndex).Cells(1).Value = Not dgColumnas.Rows(e.RowIndex).Cells(1).Value
    '        ' dgColumnas.Rows(e.RowIndex).Cells(0).RowIndex <- Conocer la fila del DataGridView que fue seleccionada.
    '        fila = dgColumnas.Rows(e.RowIndex).Cells(0).RowIndex
    '        If (dgColumnas.Rows(e.RowIndex).Cells(1).Value = True) Then
    '            dgExcel.Columns(fila).Visible = True
    '            ' Añadimos el header de dgColumnas al ComboBox
    '            cboOrden.Items.Add(dgColumnas.Rows(e.RowIndex).Cells(0).Value)
    '            ' Aquí hay que proporcionar el nombre de la columna o número de columna para luego iterar sobre ella.
    '            limpiarDatos(dgExcel.Columns(fila).Index)
    '        Else
    '            cboOrden.Items.Remove(dgColumnas.Rows(e.RowIndex).Cells(0).Value)
    '            dgExcel.Columns(fila).Visible = False
    '        End If
    '        contarColVisibles()
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    End Try
    'End Sub

    ' limpiarDatos()
    Sub limpiarDatos(col)
        Try
            For fil As Integer = 0 To dgExcel.Rows.Count - 1
                Dim valor As String = Trim(dgExcel.Rows(fil).Cells(col).Value)
                If Not (dgExcel.Rows(fil).Cells(col).Value = Nothing) Then
                    ReemplazosChars(valor, fil, col)
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub ReemplazosChars(ByVal valor As String, ByVal fil As Integer, ByVal col As Integer)
        Try
            dgExcel.Rows(fil).Cells(col).Value = valor.Replace("""", "")
            valor = dgExcel.Rows(fil).Cells(col).Value
            dgExcel.Rows(fil).Cells(col).Value = valor.Replace("'", "")
            valor = dgExcel.Rows(fil).Cells(col).Value
            dgExcel.Rows(fil).Cells(col).Value = valor.Replace("{", "")
            valor = dgExcel.Rows(fil).Cells(col).Value
            dgExcel.Rows(fil).Cells(col).Value = valor.Replace("}", "")
            valor = dgExcel.Rows(fil).Cells(col).Value
            dgExcel.Rows(fil).Cells(col).Value = valor.Replace("  ", " ")
            valor = dgExcel.Rows(fil).Cells(col).Value
            dgExcel.Rows(fil).Cells(col).Value = UCase(valor)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cboOrden_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboOrden.SelectedIndexChanged
        Try
            dgExcel.Enabled = True
            dgExcel.ReadOnly = True
            dgExcel.Sort(dgExcel.Columns(cboOrden.Text), System.ComponentModel.ListSortDirection.Ascending)
            If btnGenerar.Enabled = True Then
                btnGuardar.Enabled = False
            Else
                btnGuardar.Enabled = True
            End If
            Dim col As Integer = dgExcel.Columns(cboOrden.Text).Index
            dgExcel.Columns(col).DefaultCellStyle.Format = "00000000"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Resize
        Try
            connect()
            Me.CenterToScreen()
            dgExcel.AllowUserToOrderColumns = True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ' ####################### TRABAJANDO CON FICHEROS

    'Sub Fichero()
    '    Dim ruta As String = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
    '    Dim archivo As String = ruta & "\datos.txt"
    '    ' Verificar la existencia del fichero
    '    Try
    '        If System.IO.File.Exists(archivo) = False Then
    '            ' crear el archivo
    '            System.IO.File.Create(archivo).Dispose()
    '        End If
    '        Dim lineas As List(Of String) = IO.File.ReadAllLines(archivo).ToList
    '        lineas.Insert(archivo.Count, "Hola mundo")
    '        IO.File.WriteAllLines(archivo, lineas)
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    End Try
    'End Sub


    'Sub logError(ByVal ahora As DateTime, ByVal msj As String)
    '    Dim ruta As String = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
    '    Dim archivo As String = ruta & "\errores.txt"
    '    ' Verificar la existencia del fichero
    '    Try
    '        If System.IO.File.Exists(archivo) = False Then
    '            ' crear el archivo
    '            System.IO.File.Create(archivo).Dispose()
    '        End If
    '        Dim lineas As List(Of String) = IO.File.ReadAllLines(archivo).ToList
    '        lineas.Insert(0, "[" & ahora.ToString & "] - " & msj)
    '        IO.File.WriteAllLines(archivo, lineas)
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    End Try
    'End Sub

    ' ####################### FIN DEL TRABAJO CON FICHEROS

    Private Sub dgExcel_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgExcel.CellDoubleClick
        Try
            Dim nombre_header As String = Nothing
            nombre_header = InputBox("Escriba el nuevo nombre del encabezado:", "Cambiar nombre al encabezado", , , )
            If Not nombre_header = Nothing Then
                ' Asignamos el nuevo nombre formateando a tipo "Titulo".
                dgExcel.Columns(e.ColumnIndex).HeaderCell.Value = StrConv(nombre_header, VbStrConv.ProperCase)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Structure Clientes
        Dim documento As String
        Dim nombre As String
        Dim direccion As String
        Dim dep As String
        Dim pro As String
        Dim dis As String
        Dim cartera As String
    End Structure

    Private Sub btnListaUnica_Click(sender As Object, e As EventArgs) Handles btnListaUnica.Click
        Try
            dgListaUnica.Rows.Clear()
            dgListaUnica.Columns(0).Name = "Documento"
            dgListaUnica.Columns(1).Name = "Cliente"
            dgListaUnica.Columns(2).Name = "Dirección"
            dgListaUnica.Columns(3).Name = "Dep"
            dgListaUnica.Columns(4).Name = "Pro"
            dgListaUnica.Columns(5).Name = "Dis"


            Dim listaClientes As New List(Of Clientes)

            If (cboOrden.Text = Nothing) Then
                cboOrden.BackColor = Color.Red
            Else
                cboOrden.BackColor = Color.White
            End If

            Dim cliente As New Clientes
            For i As Integer = 0 To dgExcel.Rows.Count - 1
                cliente.documento = dgExcel.Rows(i).Cells(0).Value
                cliente.nombre = dgExcel.Rows(i).Cells(1).Value
                cliente.direccion = dgExcel.Rows(i).Cells(2).Value
                cliente.dep = dgExcel.Rows(i).Cells(3).Value
                cliente.pro = dgExcel.Rows(i).Cells(4).Value
                cliente.dis = dgExcel.Rows(i).Cells(5).Value
                cliente.cartera = dgExcel.Rows(i).Cells(12).Value

                listaClientes.Add(cliente)
            Next

            Dim resultados As List(Of Clientes) = listaClientes.Distinct().ToList
            For Each cli As Clientes In resultados
                dgListaUnica.Rows.Add(cli.documento, cli.nombre, cli.direccion, cli.dep, cli.pro, cli.dis, cli.cartera)
            Next
            ' Remover la última fila del datagrid si es vacía.
            dgListaUnica.Rows.RemoveAt(dgListaUnica.Rows.Count - 1)
            dgListaUnica.Columns(1).Width = 350

            lblTotalListaUnica.Text = dgListaUnica.Rows.Count - 1 & " Filas devueltas"
            Dim msj As Integer = MessageBox.Show("¿Desea preparar la información?", "Preparar data", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If msj = DialogResult.Yes Then
                btnGuardar.Enabled = True
                btnGenerar.Enabled = False
            Else
                btnGuardar.Enabled = False
                btnGenerar.Enabled = True
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        Try
            Dim dtLU As New DataTable
            With dtLU
                .Columns.Add("Documento")
                .Columns.Add("Nombre")
                .Columns.Add("Direccion")
                .Columns.Add("Dep")
                .Columns.Add("Pro")
                .Columns.Add("Dis")
                .Columns.Add("Cartera")
            End With

            ' Llenar el DataTable de los datos únicos
            For Each dr As DataGridViewRow In Me.dgListaUnica.Rows
                dtLU.Rows.Add(dr.Cells(0).Value, dr.Cells(1).Value, dr.Cells(2).Value, dr.Cells(3).Value, dr.Cells(4).Value, dr.Cells(5).Value, dr.Cells(6).Value)
            Next


            Dim rptLUni As CrystalDecisions.CrystalReports.Engine.ReportDocument

            rptLUni = New rptCarta1Dinners

            rptLUni.SetDataSource(dtLU)
            frmReporte.CrystalReportViewer1.ReportSource = rptLUni
            frmReporte.ShowDialog()
            frmReporte.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            btnGuardar.Enabled = False
            lblMensaje.Text = "Este proceso podría tomar algunos minutos..."
            conn.Open()
            Dim cmdLimpiar As New MySqlCommand("TRUNCATE TABLE registros", conn)
            cmdLimpiar.ExecuteNonQuery()
            For i As Integer = 0 To dgExcel.Rows.Count - 1
                Dim cmd As New MySqlCommand(
                String.Format("INSERT INTO registros (documento,nombre,direccion,departamento,provincia,distrito,num_cuenta,producto,dias_mora,moneda,deuda_total,campana,cartera,subcartera,plaza,direccionOfsede,telefonoOfSede) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}')", _
                            dgExcel.Rows(i).Cells(0).Value,
                            dgExcel.Rows(i).Cells(1).Value,
                            dgExcel.Rows(i).Cells(2).Value,
                            dgExcel.Rows(i).Cells(3).Value,
                            dgExcel.Rows(i).Cells(4).Value,
                            dgExcel.Rows(i).Cells(5).Value,
                            dgExcel.Rows(i).Cells(6).Value,
                            dgExcel.Rows(i).Cells(7).Value,
                            dgExcel.Rows(i).Cells(8).Value,
                            dgExcel.Rows(i).Cells(9).Value,
                            dgExcel.Rows(i).Cells(10).Value,
                            dgExcel.Rows(i).Cells(11).Value,
                            dgExcel.Rows(i).Cells(12).Value,
                            dgExcel.Rows(i).Cells(13).Value,
                            dgExcel.Rows(i).Cells(14).Value,
                            dgExcel.Rows(i).Cells(15).Value,
                            dgExcel.Rows(i).Cells(16).Value), conn)
                cmd.ExecuteNonQuery()
            Next
            If Not (dgListaUnica.Enabled = False) Then
                btnGenerar.Enabled = True
            End If
            lblMensaje.Text = ""
            MessageBox.Show("Hemos preparado la información para generar las cartas", "Preparar información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Try
            If MessageBox.Show("¿Desea cerrar esta ventana?", "Cerrar ventana", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Dim dv As New DataView
    Dim SQL As String
    Private Sub cboFiltros_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFiltros.SelectedIndexChanged
        Try
            SQL = cboFiltros.Text & " like '%" & txtCriterio.Text.Trim & "%'"
            'MessageBox.Show(SQL)
            dv.RowFilter = SQL
            dgExcel.DataSource = dv
            dgExcel.Update()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txtCriterio_TextChanged(sender As Object, e As EventArgs) Handles txtCriterio.TextChanged
        If (txtCriterio.Text.Trim.Length > 0) Then
            cboFiltros.Enabled = True
        Else
            cboFiltros.Enabled = False
        End If
    End Sub
End Class