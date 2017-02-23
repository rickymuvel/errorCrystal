Public Class frmReporte

    'Private Sub frmReporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    Dim rpt As New rptCartas
    '    Me.CenterToScreen()
    '    Dim ds As New Base
    '    Try
    '        Dim filas As Integer = Form1.dgListaUnica.Rows.Count - 1
    '        ds.Tables("Cliente").Clear()

    '        For i As Integer = 0 To filas - 2
    '            ' Añadimos a la tabla "Cliente" las filas correspondientes: ds.Tables(1) es la segunda tabla del DataSet
    '            ds.Tables("Cliente").Rows.Add({
    '                                          Form1.dgListaUnica.Rows(i).Cells(0).Value.ToString, _
    '                                          Form1.dgListaUnica.Rows(i).Cells(1).Value.ToString, _
    '                                          Form1.dgListaUnica.Rows(i).Cells(2).Value.ToString, _
    '                                          Form1.dgListaUnica.Rows(i).Cells(3).Value.ToString, _
    '                                          Form1.dgListaUnica.Rows(i).Cells(4).Value.ToString, _
    '                                          Form1.dgListaUnica.Rows(i).Cells(5).Value.ToString})
    '        Next
    '        'For i As Integer = 0 To 50
    '        '    MessageBox.Show(ds.Tables("Cliente").Rows(i)(0).ToString())
    '        'Next
    '        'rpt.SetDataSource(ds.Tables("Cliente"))
    '        rpt.SetDataSource(ds)
    '        CrystalReportViewer1.ReportSource = rpt
    '        'CrystalReportViewer1.Refresh()
    '        CrystalReportViewer1.Show()
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    End Try
    'End Sub

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load

    End Sub
End Class