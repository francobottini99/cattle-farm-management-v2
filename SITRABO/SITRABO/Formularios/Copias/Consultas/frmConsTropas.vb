Public Class frmConsTropas

    Private Sub pbxSalir_GotFocus(sender As Object, e As EventArgs) Handles pbxSalir.GotFocus
        pbxSalir.BackgroundImage = SITRABO.My.Resources.btnSalirSi
    End Sub

    Private Sub pbxSalir_LostFocus(sender As Object, e As EventArgs) Handles pbxSalir.LostFocus
        pbxSalir.BackgroundImage = SITRABO.My.Resources.btnSalirNo
    End Sub

    Private Sub pbxSalir_MouseEnter(sender As Object, e As EventArgs) Handles pbxSalir.MouseEnter
        pbxSalir.BackgroundImage = SITRABO.My.Resources.btnSalirSi
    End Sub

    Private Sub pbxSalir_MouseLeave(sender As Object, e As EventArgs) Handles pbxSalir.MouseLeave
        pbxSalir.BackgroundImage = SITRABO.My.Resources.btnSalirNo
    End Sub

    Private Sub frmConsTropas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Si.Tra.Bo. - Sistema de Trazabilidad Bovina" & " - USUARIO: " & frmLogin.txtNom.Text & " " & frmLogin.txtAp.Text & " -"

        CargarDGVTropas()
        btnFiltrar.Select()
    End Sub

    Private Sub CargarDGVTropas()
        Dim _Dt As New DataTable
        Dim _Ver As New Mostrar

        If frmLogin.txtTipUs.Text = "Super Usuario" Then
            _Dt = _Ver.verTropas
        Else
            _Dt = _Ver.verTropaUs(frmLogin.txtID.Text)
        End If

        dgvTropas.RowTemplate.Height = 35
        dgvTropas.DataSource = _Dt
        dgvTropas.ClearSelection()
        dgvTropas.Columns("idTropa").Visible = False
        dgvTropas.Columns("OrigenProcedencia").Visible = False
        dgvTropas.Columns("FechaIngreso").Visible = False
        dgvTropas.Columns("Cabezas").Visible = False
        dgvTropas.Columns("Muertes").Visible = False
        dgvTropas.Columns("Ventas").Visible = False
        dgvTropas.Columns("Stock").Visible = False
        dgvTropas.Columns("PesoIngreso").Visible = False
        dgvTropas.Columns("TotalKgTropa").Visible = False
        dgvTropas.Columns("Observaciones").Visible = False
        dgvTropas.Columns("PRODUCTOR_idProductor").Visible = False
        dgvTropas.Columns("CAMPO_idCampo").Visible = False
        dgvTropas.Columns("PROVEEDOR_idProveedor").Visible = False
        dgvTropas.Columns("USUARIOS_idUsuario").Visible = False

        '_Dt = _Ver.verCategorias
        'cbxCategorias.Items.Clear()
        'For Each _Dr As DataRow In _Dt.Rows
        ' cbxCategorias.Items.Add(_Dr("Categoria"))
        ' Next
    End Sub

    Private Sub pbxSalir_Click(sender As Object, e As EventArgs) Handles pbxSalir.Click
        Me.Close()
    End Sub

    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click
        If dgvTropas.CurrentRow IsNot Nothing Then
            Dim _Dt As New DataTable
            Dim _Ver As New Mostrar

            If frmLogin.txtTipUs.Text = "Super Usuario" Then
                _Dt = _Ver.consTropasDetalle(dgvTropas.CurrentRow.Cells.Item(0).Value)
            Else
                _Dt = _Ver.consTropasDetalleUs(dgvTropas.CurrentRow.Cells.Item(0).Value, CInt(frmLogin.txtID.Text))
            End If

            dgvDetalle.DataSource = _Dt
            dgvDetalle.Columns("idTropa").Visible = False
            dgvDetalle.Columns("NombreTropa").Visible = False
            dgvDetalle.Columns("Productor").Visible = False
            dgvDetalle.Columns("Proveedor").Visible = False
            dgvDetalle.Columns("Procedencia").Visible = False
            dgvDetalle.Columns("Destino").Visible = False
            dgvDetalle.Columns("Ingreso").Visible = False
            dgvDetalle.Columns("Ingreso").Visible = False
            dgvDetalle.Columns("Cab_Tropa").Visible = False
            dgvDetalle.Columns("Muertes").Visible = False
            dgvDetalle.Columns("Ventas").Visible = False
            dgvDetalle.Columns("Stk_Tropa").Visible = False
            dgvDetalle.Columns("PesoIngreso").Visible = False
            dgvDetalle.Columns("TotalKgTropa").Visible = False

            For Each Fila As DataRow In _Dt.Rows
                lblTropa.Text = Fila("NombreTropa")
                lblProd.Text = Fila("Productor")
                lblProv.Text = Fila("Proveedor")
                lblProced.Text = Fila("Procedencia")
                lblDestino.Text = Fila("Destino")
                lblFecIng.Text = Format(CDate(Fila("Ingreso")), "dd/MM/yyyy")
                lblCabTropa.Text = Format(CInt(Fila("Cab_Tropa")), "#,##0")
                lblMuertes.Text = Format(CInt(Fila("Muertes")), "#,##0")
                lblVentas.Text = Format(CInt(Fila("Ventas")), "#,##0")
                lblStockTropa.Text = Format(CInt(Fila("Stk_Tropa")), "#,##0")
                lblKgIng.Text = Format(CInt(Fila("TotalKgTropa")), "#,##0")
                lblKgCab.Text = Format(CInt(Fila("TotalKgTropa")) / CInt(Fila("Cab_Tropa")), "#,##0")
            Next

            If frmLogin.txtTipUs.Text = "Super Usuario" Then
                _Dt = _Ver.verMaxFecAlimporTropa(dgvTropas.CurrentRow.Cells.Item(0).Value)
            Else
                _Dt = _Ver.verMaxFecAlimporTropaUs(dgvTropas.CurrentRow.Cells.Item(0).Value, CInt(frmLogin.txtID.Text))
            End If

            For Each Fila As DataRow In _Dt.Rows
                If Fila("UltimaAlim").ToString <> "" Then
                    lblUltDia.Text = Fila("UltimaAlim")
                Else
                    lblUltDia.Text = "-"
                End If
            Next

            If lblUltDia.Text <> "-" Then
                lblDiasAlim.Text = Format(DateDiff(DateInterval.Day, CDate(lblFecIng.Text), CDate(lblUltDia.Text)), "#,##0")
            Else
                lblDiasAlim.Text = 0
            End If

            'Calculo de días de engorde



            If frmLogin.txtTipUs.Text = "Super Usuario" Then
                _Dt = _Ver.consComprasTropa(dgvTropas.CurrentRow.Cells.Item(0).Value)
            Else
                _Dt = _Ver.consComprasTropaUs(dgvTropas.CurrentRow.Cells.Item(0).Value, CInt(frmLogin.txtID.Text))
            End If

            For Each Fila As DataRow In _Dt.Rows
                lblImporteTropa.Text = Format(Fila("CostoTotalTropa"), "$ #,##0.00")
            Next
            lblImpCab.Text = Format(CDbl(lblImporteTropa.Text) / CInt(lblCabTropa.Text), "$ #,##0.00")
            lblImpKg.Text = Format(CDbl(lblImporteTropa.Text) / CInt(lblKgIng.Text), "$ #,##0.00")

            If frmLogin.txtTipUs.Text = "Super Usuario" Then
                _Dt = _Ver.sumaAlimetacionPorTropa(dgvTropas.CurrentRow.Cells.Item(0).Value)
            Else
                _Dt = _Ver.sumaAlimentacionPorTropaUs(dgvTropas.CurrentRow.Cells.Item(0).Value, CInt(frmLogin.txtID.Text))
            End If

            For Each Fila As DataRow In _Dt.Rows
                If Fila("SumaTotAlim").ToString <> "" Then
                    lblConsumoKg.Text = Format(Fila("TotKgRac"), "#,##0")
                    lblConsumoPesos.Text = Format(Fila("SumaTotAlim"), "$ #,##0.00")
                Else
                    lblConsumoKg.Text = Format(0, "#,##0")
                    lblConsumoPesos.Text = Format(0, "$ #,##0.00")
                End If
            Next

            gbxConsTropas.Visible = True
            gbxPantallaInicio.Visible = False

            dgvDetalle.CurrentCell = Nothing
        Else
            MsgBox("Error: Primero selecciona una tropa... !", vbExclamation, "Servico de Alertas")
        End If
    End Sub
End Class