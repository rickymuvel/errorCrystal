Public Class Menu

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If MessageBox.Show("¿Está seguro que desea salir?", "Salir del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.Dispose()
        End If
    End Sub

    Private Sub BCPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BCPToolStripMenuItem.Click
        BCP.Show()
    End Sub

    Private Sub GNBToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GNBToolStripMenuItem.Click
        GNB.Show()
    End Sub

    Private Sub CARTA1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CARTA1ToolStripMenuItem.Click
        SCI1.Show()
    End Sub

    Private Sub CastigoRedesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CastigoRedesToolStripMenuItem.Click
        SCI2.Show()
    End Sub

    Private Sub CSFToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CSFToolStripMenuItem.Click
        SCI3.Show()
    End Sub

    Private Sub CSFToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CSFToolStripMenuItem1.Click
        SCI4.Show()
    End Sub

    Private Sub PropiaCentralizadaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PropiaCentralizadaToolStripMenuItem.Click
        SCI5.Show()
    End Sub

    Private Sub PropiaRedesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PropiaRedesToolStripMenuItem.Click
        SCI6.Show()
    End Sub

    Private Sub SBPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SBPToolStripMenuItem.Click
        SCI7.Show()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        SCI8.Show()
    End Sub

    Private Sub TeleventaTarjetasCPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TeleventaTarjetasCPToolStripMenuItem.Click
        SCI9.Show()
    End Sub

    Private Sub Carta1ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles Carta1ToolStripMenuItem1.Click
        FINANCIERO1.Show()
    End Sub

    Private Sub Carta2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Carta2ToolStripMenuItem.Click
        FINANCIERO2.Show()
    End Sub

    Private Sub Carta3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Carta3ToolStripMenuItem.Click
        FINANCIERO3.Show()
    End Sub

    Private Sub Carta14ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Carta14ToolStripMenuItem.Click
        FINANCIERO4.Show()
    End Sub

    Private Sub Carta5ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Carta5ToolStripMenuItem.Click
        FINANCIERO5.Show()
    End Sub

    Private Sub Carta6ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Carta6ToolStripMenuItem.Click
        FINANCIERO6.Show()
    End Sub

    Private Sub Carta7ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Carta7ToolStripMenuItem.Click
        FINANCIERO7.Show()
    End Sub

    Private Sub Carta1ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles Carta1ToolStripMenuItem2.Click
        DINNERS1.Show()
    End Sub

    Private Sub Carta2ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles Carta2ToolStripMenuItem1.Click
        DINNERS2.Show()
    End Sub

    Private Sub CartasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CartasToolStripMenuItem.Click
        RPP1.Show()
    End Sub
End Class