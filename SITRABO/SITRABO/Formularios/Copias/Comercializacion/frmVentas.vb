Imports MySql.Data.MySqlClient

Public Class frmVentas
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

    Private Sub pbxCancelar_GotFocus(sender As Object, e As EventArgs) Handles pbxCancelar.GotFocus
        pbxCancelar.BackgroundImage = SITRABO.My.Resources.btnCancelarSi
    End Sub

    Private Sub pbxCancelar_LostFocus(sender As Object, e As EventArgs) Handles pbxCancelar.LostFocus
        pbxCancelar.BackgroundImage = SITRABO.My.Resources.btnCancelarNo
    End Sub

    Private Sub pbxCancelar_MouseEnter(sender As Object, e As EventArgs) Handles pbxCancelar.MouseEnter
        pbxCancelar.BackgroundImage = SITRABO.My.Resources.btnCancelarSi
    End Sub

    Private Sub pbxCancelar_MouseLeave(sender As Object, e As EventArgs) Handles pbxCancelar.MouseLeave
        pbxCancelar.BackgroundImage = SITRABO.My.Resources.btnCancelarNo
    End Sub

    Private Sub pbxGuardar_GotFocus(sender As Object, e As EventArgs) Handles pbxGuardar.GotFocus
        pbxGuardar.BackgroundImage = SITRABO.My.Resources.btnGuardarSi
    End Sub

    Private Sub pbxGuardar_LostFocus(sender As Object, e As EventArgs) Handles pbxGuardar.LostFocus
        pbxGuardar.BackgroundImage = SITRABO.My.Resources.btnGuardarNo
    End Sub

    Private Sub pbxGuardar_MouseEnter(sender As Object, e As EventArgs) Handles pbxGuardar.MouseEnter
        pbxGuardar.BackgroundImage = SITRABO.My.Resources.btnGuardarSi
    End Sub

    Private Sub pbxGuardar_MouseLeave(sender As Object, e As EventArgs) Handles pbxGuardar.MouseLeave
        pbxGuardar.BackgroundImage = SITRABO.My.Resources.btnGuardarNo
    End Sub

    Private Sub pbxModificar_GotFocus(sender As Object, e As EventArgs) Handles pbxModificar.GotFocus
        If (pbxModificar.Enabled = True) Then
            pbxModificar.BackgroundImage = SITRABO.My.Resources.btnModificarSi
        End If
    End Sub

    Private Sub pbxModificar_LostFocus(sender As Object, e As EventArgs) Handles pbxModificar.LostFocus
        If (pbxModificar.Enabled = True) Then
            pbxModificar.BackgroundImage = SITRABO.My.Resources.btnModificarNo
        End If
    End Sub

    Private Sub pbxModificar_MouseEnter(sender As Object, e As EventArgs) Handles pbxModificar.MouseEnter
        If (pbxModificar.Enabled = True) Then
            pbxModificar.BackgroundImage = SITRABO.My.Resources.btnModificarSi
        End If
    End Sub

    Private Sub pbxModificar_MouseLeave(sender As Object, e As EventArgs) Handles pbxModificar.MouseLeave
        If (pbxModificar.Enabled = True) Then
            pbxModificar.BackgroundImage = SITRABO.My.Resources.btnModificarNo
        End If
    End Sub

    Private Sub pbxNuevo_GotFocus(sender As Object, e As EventArgs) Handles pbxNuevo.GotFocus
        If (pbxNuevo.Enabled = True) Then
            pbxNuevo.BackgroundImage = SITRABO.My.Resources.btnNuevoSi
        End If
    End Sub

    Private Sub pbxNuevo_LostFocus(sender As Object, e As EventArgs) Handles pbxNuevo.LostFocus
        If (pbxNuevo.Enabled = True) Then
            pbxNuevo.BackgroundImage = SITRABO.My.Resources.btnNuevoNo
        End If
    End Sub

    Private Sub pbxNuevo_MouseEnter(sender As Object, e As EventArgs) Handles pbxNuevo.MouseEnter
        If (pbxNuevo.Enabled = True) Then
            pbxNuevo.BackgroundImage = SITRABO.My.Resources.btnNuevoSi
        End If
    End Sub

    Private Sub pbxNuevo_MouseLeave(sender As Object, e As EventArgs) Handles pbxNuevo.MouseLeave
        If (pbxNuevo.Enabled = True) Then
            pbxNuevo.BackgroundImage = SITRABO.My.Resources.btnNuevoNo
        End If
    End Sub

    Private Sub frmVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ctlNuevo As Control = DirectCast(pbxNuevo, Control)
        Dim keyprNuevo = New KeyPressEventHandler(AddressOf btnNuevo)

        Dim ctlGuardar As Control = DirectCast(pbxGuardar, Control)
        Dim keyprGuardar = New KeyPressEventHandler(AddressOf btnGuardar)

        AddHandler ctlNuevo.KeyPress, keyprNuevo
        AddHandler ctlGuardar.KeyPress, keyprGuardar

        Me.Text = "Si.Tra.Bo. - Sistema de Trazabilidad Bovina" & " - USUARIO: " & frmLogin.txtNom.Text & " " & frmLogin.txtAp.Text & " -"

        dgvFecha.DefaultCellStyle.ForeColor = Color.Black
        dgvProductor.DefaultCellStyle.ForeColor = Color.Black
        dgvAnimSeleccionados.DefaultCellStyle.ForeColor = Color.Black
        dgvAnimSeleccionados.DefaultCellStyle.SelectionForeColor = Color.Black
    End Sub

    Private Sub Activar()
        pbxNuevo.Enabled = False
        pbxGuardar.Enabled = True
        pbxCancelar.Enabled = True
        pbxModificar.Enabled = False
        pbxSalir.Enabled = False
    End Sub


    Private Sub pbxSalir_Click(sender As Object, e As EventArgs) Handles pbxSalir.Click
        Me.Close()
    End Sub

    Private Sub btnNuevo(ByVal sender As System.Object, ByVal e As KeyPressEventArgs)
        If Asc(e.KeyChar) = Keys.Enter Then
            pbxNuevo_Click(1, Nothing)
        End If
    End Sub

    Private Sub btnGuardar(ByVal sender As System.Object, ByVal e As KeyPressEventArgs)
        If Asc(e.KeyChar) = Keys.Enter Then
            pbxGuardar_Click(1, Nothing)
        End If
    End Sub

    Private Sub Cancelar()
        txtOrigen.Text = ""

        pbxNuevo.BackgroundImage = SITRABO.My.Resources.btnNuevoNo
        pbxModificar.BackgroundImage = SITRABO.My.Resources.btnModificarNo

        pbxNuevo.Enabled = True
        pbxGuardar.Enabled = False
        pbxCancelar.Enabled = False
        pbxModificar.Enabled = True
        pbxSalir.Enabled = True

        gbxNuevoUno.Visible = False
        gbxNuevoDos.Visible = False
        gbxPantallaInicio.Visible = True

        lblFechaSeleccionada.Text = ""

        lblTotCab.Text = 0
        lblTotBal.Text = 0
        lblTotDes.Text = 0
        lblTotNet.Text = 0
        lblTotPmCab.Text = 0
        lblTotPmDes.Text = 0

        txtComprador.Text = ""
        txtAlicuotaIva.Text = ""
        txtFlete.Text = ""
        txtPrecioVtaPorKgSinIva.Text = ""
        txtOtrosCostos.Text = ""

        lblImporteNetoVtaFinal.Text = ""
        lblPrecioVtaConIvaPorKg.Text = ""
        lblImporteVtaConIvaPorCabezas.Text = ""
        lblImporteVta.Text = ""

        lblImporteNetoVtaFinal.BackColor = Color.DimGray

        Dim rows As Integer = dgvAnimSeleccionados.Rows.Count - 1

        If dgvAnimSeleccionados.Rows.Count > 0 Then
            For j As Integer = rows To 0 Step -1
                dgvAnimSeleccionados.Rows.Remove(dgvAnimSeleccionados.Rows(j))
            Next
        End If

        dgvFecha.DataSource = Nothing
        dgvProductor.DataSource = Nothing
        dgvAnimVendidos.DataSource = Nothing
    End Sub

    Private Sub pbxCancelar_Click(sender As Object, e As EventArgs) Handles pbxCancelar.Click
        Cancelar()
    End Sub

    Private Sub pbxNuevo_Click(sender As Object, e As EventArgs) Handles pbxNuevo.Click
        Activar()

        pbxNuevo.BackgroundImage = SITRABO.My.Resources.btnNuevoSi
        pbxModificar.BackgroundImage = SITRABO.My.Resources.btnModificarNo

        gbxNuevoUno.Visible = True
        gbxPantallaInicio.Visible = False

        txtOrigen.Text = "Nuevo"

        CargarFechas()

        dgvFecha.CurrentCell = Nothing
        dgvFecha.ClearSelection()
    End Sub

    Private Sub CargarFechas()
        Dim _Dt As DataTable
        Dim _Ver As New Mostrar
        Dim FechaAnterior As Date = "#17/01/1001#"

        If frmLogin.txtTipUs.Text = "Super Usuario" Then
            _Dt = _Ver.VerVentasSinComercializarFecha
        Else
            _Dt = _Ver.VerVentasSinComercializarFechaUs(frmLogin.txtID.Text)
        End If

        For i As Integer = _Dt.Rows.Count - 1 To 0 Step -1
            If _Dt.Rows(i).Item("Fecha") = FechaAnterior Then
                _Dt.Rows.Remove(_Dt.Rows(i))
            Else
                FechaAnterior = _Dt.Rows(i).Item("Fecha")
            End If
        Next

        dgvFecha.RowTemplate.Height = 25
        dgvFecha.DataSource = _Dt
        dgvFecha.Columns("idVentas").Visible = False
    End Sub

    Private Sub CargarAnimelesVendidos()
        Dim _Dt As DataTable
        Dim _Ver As New Mostrar

        If frmLogin.txtTipUs.Text = "Super Usuario" Then
            _Dt = _Ver.consVentasSinComercializar(dgvProductor.CurrentRow.Cells.Item("idProductor").Value, dgvFecha.CurrentRow.Cells.Item("Fecha").Value)
        Else
            _Dt = _Ver.consVentasSinComercializarUs(dgvProductor.CurrentRow.Cells.Item("idProductor").Value, dgvFecha.CurrentRow.Cells.Item("Fecha").Value, frmLogin.txtID.Text)
        End If

        dgvAnimVendidos.RowTemplate.Height = 25
        dgvAnimVendidos.DataSource = _Dt
        dgvAnimVendidos.Columns("idVentas").Visible = False
        dgvAnimVendidos.Columns("Fecha").Visible = False
        dgvAnimVendidos.Columns("Comprador").Visible = False
        dgvAnimVendidos.Columns("Cabezas").Visible = False
        dgvAnimVendidos.Columns("KgVendidos").Visible = False
        dgvAnimVendidos.Columns("KgPorCabeza").Visible = False
        dgvAnimVendidos.Columns("PrecioVtaSinIvaPorKg").Visible = False
        dgvAnimVendidos.Columns("ImporteVtaSinIvaPorCabeza").Visible = False
        dgvAnimVendidos.Columns("AlicuotaIva").Visible = False
        dgvAnimVendidos.Columns("PrecioVtaConIvaPorKg").Visible = False
        dgvAnimVendidos.Columns("ImporteVtaConIvaPorCabeza").Visible = False
        dgvAnimVendidos.Columns("ImporteTotalVenta").Visible = False
        dgvAnimVendidos.Columns("Flete").Visible = False
        dgvAnimVendidos.Columns("OtrosCostos").Visible = False
        dgvAnimVendidos.Columns("ImporteNetoVenta").Visible = False
        dgvAnimVendidos.Columns("idProductor").Visible = False
        dgvAnimVendidos.Columns("RazonSocial").Visible = False
        dgvAnimVendidos.Columns("idDetTropa").Visible = False
        dgvAnimVendidos.Columns("Estado").Visible = False
        dgvAnimVendidos.Columns("idTropa").Visible = False
        dgvAnimVendidos.Columns("idPESAJE").Visible = False

        dgvAnimVendidos.ColumnHeadersVisible = True
        dgvAnimVendidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None

        dgvAnimVendidos.Columns("NombreTropa").HeaderText = "Nombre Tropa"
        dgvAnimVendidos.Columns("PorcDesbaste").HeaderText = "% Desbaste"
        dgvAnimVendidos.Columns("PesoFinal").HeaderText = "Peso Final"

        dgvAnimVendidos.Columns("Caravana").Width = 100
        dgvAnimVendidos.Columns("Descripcion").Width = 330
        dgvAnimVendidos.Columns("NombreTropa").Width = 250
        dgvAnimVendidos.Columns("Peso").Width = 100
        dgvAnimVendidos.Columns("PorcDesbaste").Width = 100
        dgvAnimVendidos.Columns("PesoFinal").Width = 100
    End Sub

    Private Sub CargarProductores()
        Dim _Dt As DataTable
        Dim _Ver As New Mostrar
        Dim ProdAnterior As String = ""

        If frmLogin.txtTipUs.Text = "Super Usuario" Then
            _Dt = _Ver.VerVentasSinComercializarProductorPorFecha(dgvFecha.CurrentRow.Cells.Item("Fecha").Value)
        Else
            _Dt = _Ver.VerVentasSinComercializarProductorPorFechaUs(dgvFecha.CurrentRow.Cells.Item("Fecha").Value, frmLogin.txtID.Text)
        End If

        For i As Integer = _Dt.Rows.Count - 1 To 0 Step -1
            If _Dt.Rows(i).Item("RazonSocial") = ProdAnterior Then
                _Dt.Rows.Remove(_Dt.Rows(i))
            Else
                ProdAnterior = _Dt.Rows(i).Item("RazonSocial")
            End If
        Next

        dgvProductor.RowTemplate.Height = 25
        dgvProductor.DataSource = _Dt
        dgvProductor.Columns("idProductor").Visible = False
    End Sub

    Private Sub pbxGuardar_Click(sender As Object, e As EventArgs) Handles pbxGuardar.Click
        Dim G As New GrabaDatos
        Dim resP As DialogResult

        Try
            If txtComprador.Text = "" Then
                MsgBox("Comprador es un campo obligatorio... !", vbInformation, "Servico de Alertas")
                txtComprador.Select()
            Else
                If txtComprador.Text = "-" Then
                    MsgBox("""-""Este caracter utilizado de manera individual esta reservado para usos del sistema. Ingrese otro nombre para el comprador... !", vbInformation, "Servico de Alertas")
                    txtComprador.Text = ""
                    txtComprador.Select()
                Else
                    If txtOrigen.Text = "Nuevo" Then
                        resP = MessageBox.Show("Grabar Contabilizacion ?", "Servico de Alertas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                    Else
                        resP = MessageBox.Show("Modificar Contabilizacion ?", "Servico de Alertas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                    End If

                    If resP = Windows.Forms.DialogResult.OK Then
                        Dim CostFleteCab, CostOtrosCab As Double

                        If txtPrecioVtaPorKgSinIva.Text = "" Then
                            txtPrecioVtaPorKgSinIva.Text = 0
                        End If

                        If txtAlicuotaIva.Text = "" Then
                            txtAlicuotaIva.Text = 0
                        End If

                        If txtFlete.Text = "" Then
                            txtFlete.Text = 0
                        End If

                        If txtOtrosCostos.Text = "" Then
                            txtOtrosCostos.Text = 0
                        End If

                        Calcular()
                        Costos()

                        If txtFlete.Text <> 0 Then
                            CostFleteCab = txtFlete.Text / lblCabezas.Text
                        Else
                            CostFleteCab = 0
                        End If

                        If txtOtrosCostos.Text <> 0 Then
                            CostOtrosCab = txtOtrosCostos.Text / lblCabezas.Text
                        Else
                            CostOtrosCab = 0
                        End If

                        If txtOrigen.Text = "Nuevo" Then
                            For i As Integer = 0 To dgvAnimSeleccionados.Rows.Count - 1
                                G.Grabar("Ventas", "NoImagen", "feedlot.modVentaContabilidad", dgvAnimSeleccionados.Rows(i).Cells.Item("idVentas").Value, txtComprador.Text, dgvAnimSeleccionados.Rows(i).Cells.Item("PesoFinal").Value, _
                                dgvAnimSeleccionados.Rows(i).Cells.Item("PesoFinal").Value, CDbl(txtPrecioVtaPorKgSinIva.Text), dgvAnimSeleccionados.Rows(i).Cells.Item("PesoFinal").Value * CDbl(txtPrecioVtaPorKgSinIva.Text), _
                                CDbl(txtAlicuotaIva.Text), CDbl(lblPrecioVtaConIvaPorKg.Text), dgvAnimSeleccionados.Rows(i).Cells.Item("PesoFinal").Value * CDbl(lblPrecioVtaConIvaPorKg.Text), _
                                dgvAnimSeleccionados.Rows(i).Cells.Item("PesoFinal").Value * CDbl(lblPrecioVtaConIvaPorKg.Text), CostFleteCab, CostOtrosCab, _
                                ((dgvAnimSeleccionados.Rows(i).Cells.Item("PesoFinal").Value * CDbl(lblPrecioVtaConIvaPorKg.Text)) - CostOtrosCab) - CostFleteCab)
                            Next
                        Else
                            'For i As Integer = 0 To dgvSanidadesModificar.Rows.Count - 1
                            '    G.Grabar("Sanidad", "NoImagen", "feedlot.modSanidad", dgvSanidadesModificar.Rows(i).Cells.Item("idSanidad").Value, dgvSanidadesModificar.Rows(i).Cells.Item("Fecha").Value, _
                            '             dgvSanidadesModificar.Rows(i).Cells.Item("Tratamiento").Value, dgvSanidadesModificar.Rows(i).Cells.Item("Importe").Value, dgvSanidadesModificar.Rows(i).Cells.Item("Observaciones").Value)

                            '    G.Grabar("tropa_bloqueo_mod", "NoImagen", "feedlot.modEstadoMod", "NO", dgvSanidadesModificar.Rows(i).Cells.Item("idTropa").Value)
                            'Next
                        End If

                        CargarFechas()
                        Cancelar()
                    End If
                End If
            End If
        Catch ex As MySqlException
            MsgBox(ex.ToString)
            BDxxx()
        Finally
            BDxxx()
        End Try
    End Sub

    Private Sub dgvFecha_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFecha.CellClick
        If e.RowIndex > -1 Then
            CargarProductores()

            lblFechaSeleccionada.Text = dgvFecha.CurrentRow.Cells.Item("Fecha").Value

            lblTotCab.Text = 0
            lblTotBal.Text = 0
            lblTotDes.Text = 0
            lblTotNet.Text = 0
            lblTotPmCab.Text = 0
            lblTotPmDes.Text = 0

            dgvAnimVendidos.DataSource = Nothing

            dgvProductor.CurrentCell = Nothing
            dgvProductor.ClearSelection()
        End If
    End Sub

    Private Sub dgvProductor_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProductor.CellClick
        If e.RowIndex > -1 Then
            CargarAnimelesVendidos()

            lblTotCab.Text = 0
            lblTotBal.Text = 0
            lblTotDes.Text = 0
            lblTotNet.Text = 0
            lblTotPmCab.Text = 0
            lblTotPmDes.Text = 0

            dgvAnimVendidos.CurrentCell = Nothing
            dgvAnimVendidos.ClearSelection()
        End If
    End Sub

    Private Sub lblValores()
        Dim Count As Integer = 0
        Dim Cab As Integer = 0
        Dim KgBal As Double = 0
        Dim PorcDes As Double = 0
        Dim KgNetos As Double = 0

        For i As Integer = 0 To dgvAnimVendidos.RowCount - 1
            If dgvAnimVendidos.Rows(i).Selected Then
                Cab = Cab + Convert.ToInt64(dgvAnimVendidos.Rows(i).Cells.Item("Cabezas").Value)
                KgBal = KgBal + Convert.ToDouble(dgvAnimVendidos.Rows(i).Cells.Item("Peso").Value)
                PorcDes = PorcDes + Convert.ToDouble(dgvAnimVendidos.Rows(i).Cells.Item("PorcDesbaste").Value)
                KgNetos = KgNetos + Convert.ToDouble(dgvAnimVendidos.Rows(i).Cells.Item("PesoFinal").Value)

                Count = Count + 1
            End If
        Next

        If Cab > 0 Then
            lblTotCab.Text = Cab
            lblTotBal.Text = Format(CInt(KgBal))
            lblTotDes.Text = Format(CInt(KgBal - (KgBal * ((PorcDes / Count) / 100))))
            lblTotNet.Text = Format(CInt(KgNetos))
            lblTotPmCab.Text = CInt(KgBal / Cab)
            lblTotPmDes.Text = CInt(KgNetos / Cab)
        Else
            lblTotCab.Text = 0
            lblTotBal.Text = 0
            lblTotDes.Text = 0
            lblTotNet.Text = 0
            lblTotPmCab.Text = 0
            lblTotPmDes.Text = 0
        End If
    End Sub

    Private Sub dgvAnimVendidos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAnimVendidos.CellClick
        lblValores()
    End Sub

    Private Sub btnContabilizar_Click(sender As Object, e As EventArgs) Handles btnContabilizar.Click
        If dgvAnimVendidos.SelectedRows.Count < 1 Then
            MsgBox("No hay ningun Animal seleccionado... !", vbInformation, "Servico de Alertas")
        Else
            lblValores()

            lblFecha.Text = lblFechaSeleccionada.Text
            lblCabezas.Text = dgvAnimVendidos.SelectedRows.Count
            lblKgVendidos.Text = lblTotNet.Text
            lblKgPorCabeza.Text = lblTotPmDes.Text
            lblProductor.Text = UCase(dgvProductor.CurrentRow.Cells.Item("RazonSocial").Value)

            gbxNuevoUno.Visible = False
            gbxNuevoDos.Visible = True

            dgvAnimSeleccionados.RowTemplate.Height = 25
            dgvAnimSeleccionados.ColumnCount = 8
            dgvAnimSeleccionados.Columns(0).Name = "idVentas"
            dgvAnimSeleccionados.Columns(1).Name = "idProductor"
            dgvAnimSeleccionados.Columns(2).Name = "idDetTropa"
            dgvAnimSeleccionados.Columns(3).Name = "idPESAJE"
            dgvAnimSeleccionados.Columns(4).Name = "idTropa"
            dgvAnimSeleccionados.Columns(5).Name = "Caravana"
            dgvAnimSeleccionados.Columns(6).Name = "NombreTropa"
            dgvAnimSeleccionados.Columns(7).Name = "PesoFinal"

            dgvAnimSeleccionados.Columns("idVentas").Visible = False
            dgvAnimSeleccionados.Columns("idProductor").Visible = False
            dgvAnimSeleccionados.Columns("idDetTropa").Visible = False
            dgvAnimSeleccionados.Columns("idPESAJE").Visible = False
            dgvAnimSeleccionados.Columns("idTropa").Visible = False
            dgvAnimSeleccionados.Columns("PesoFinal").Visible = False

            dgvAnimSeleccionados.Columns("Caravana").Width = 80
            dgvAnimSeleccionados.Columns("NombreTropa").Width = 284

            dgvAnimSeleccionados.Columns("NombreTropa").HeaderText = "Nombre Tropa"

            For i As Integer = 0 To dgvAnimVendidos.RowCount - 1
                If dgvAnimVendidos.Rows(i).Selected Then
                    dgvAnimSeleccionados.Rows.Add(dgvAnimVendidos.Rows(i).Cells.Item("idVentas").Value, dgvAnimVendidos.Rows(i).Cells.Item("idProductor").Value, _
                                                   dgvAnimVendidos.Rows(i).Cells.Item("idDetTropa").Value, dgvAnimVendidos.Rows(i).Cells.Item("idPESAJE").Value, _
                                                   dgvAnimVendidos.Rows(i).Cells.Item("idTropa").Value, dgvAnimVendidos.Rows(i).Cells.Item("Caravana").Value, _
                                                   dgvAnimVendidos.Rows(i).Cells.Item("NombreTropa").Value, dgvAnimVendidos.Rows(i).Cells.Item("PesoFinal").Value)
                End If
            Next

            txtComprador.Select()
        End If
    End Sub

    Private Sub dgvAnimVendidos_MouseEnter(sender As Object, e As EventArgs) Handles dgvAnimVendidos.MouseEnter
        lblValores()
    End Sub

    Private Sub dgvAnimVendidos_MouseLeave(sender As Object, e As EventArgs) Handles dgvAnimVendidos.MouseLeave
        lblValores()
    End Sub

    Private Sub dgvAnimVendidos_MouseMove(sender As Object, e As MouseEventArgs) Handles dgvAnimVendidos.MouseMove
        lblValores()
    End Sub

    Private Sub Costos()
        If txtFlete.Text <> "" Then
            txtFlete.Text = Format(CDbl(txtFlete.Text), "$ #,##0.00")

            If txtOtrosCostos.Text <> "" Then
                txtOtrosCostos.Text = Format(CDbl(txtOtrosCostos.Text), "$ #,##0.00")

                lblImporteNetoVtaFinal.Text = Format(CDbl(lblImporteVta.Text - txtFlete.Text - txtOtrosCostos.Text), "$ #,##0")

                If lblImporteNetoVtaFinal.Text > 0 Then
                    lblImporteNetoVtaFinal.BackColor = Color.DarkGreen
                Else
                    lblImporteNetoVtaFinal.BackColor = Color.DarkRed
                End If
            Else
                txtOtrosCostos.Text = Format(CDbl(0), "$ #,##0.00")

                Costos()
            End If
        Else
            txtFlete.Text = Format(0, "$ #,##0.00")

            Costos()
        End If
    End Sub

    Private Sub Calcular()
        If txtPrecioVtaPorKgSinIva.Text <> "" Then
            txtPrecioVtaPorKgSinIva.Text = Format(CDbl(txtPrecioVtaPorKgSinIva.Text), "$ #,##0.00")

            If txtAlicuotaIva.Text <> "" Then
                txtAlicuotaIva.Text = Format(CDbl(txtAlicuotaIva.Text), "#,##0.00")

                If txtAlicuotaIva.Text = 0 Then
                    lblPrecioVtaConIvaPorKg.Text = Format(CDbl(txtPrecioVtaPorKgSinIva.Text), "$ #,##0.00")
                    lblImporteVtaConIvaPorCabezas.Text = Format(CDbl(txtPrecioVtaPorKgSinIva.Text * lblKgPorCabeza.Text), "$ #,##0.00")
                    lblImporteVta.Text = Format(CDbl(lblImporteVtaConIvaPorCabezas.Text * lblCabezas.Text), "$ #,##0")
                    lblImporteNetoVtaFinal.Text = Format(CDbl(lblImporteVta.Text), "$ #,##0")
                Else
                    lblPrecioVtaConIvaPorKg.Text = Format(CDbl(txtPrecioVtaPorKgSinIva.Text + (txtPrecioVtaPorKgSinIva.Text * (txtAlicuotaIva.Text / 100))), "$ #,##0.00")
                    lblImporteVtaConIvaPorCabezas.Text = Format(CDbl((txtPrecioVtaPorKgSinIva.Text * lblKgPorCabeza.Text) + ((txtPrecioVtaPorKgSinIva.Text * lblKgPorCabeza.Text) * (txtAlicuotaIva.Text / 100))), "$ #,##0.00")
                    lblImporteVta.Text = Format(CDbl(lblImporteVtaConIvaPorCabezas.Text * lblCabezas.Text), "$ #,##0")
                    lblImporteNetoVtaFinal.Text = Format(CDbl(lblImporteVta.Text), "$ #,##0")
                End If

                If lblImporteNetoVtaFinal.Text > 0 Then
                    lblImporteNetoVtaFinal.BackColor = Color.DarkGreen
                Else
                    lblImporteNetoVtaFinal.BackColor = Color.DarkRed
                End If

                If txtFlete.Text <> "" Or txtOtrosCostos.Text <> "" Then
                    Costos()
                End If
            Else
                txtAlicuotaIva.Text = 0

                Calcular()
            End If
        Else
            txtPrecioVtaPorKgSinIva.Text = 0

            Calcular()
        End If
    End Sub

    Private Sub txtFlete_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFlete.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> Keys.Enter And e.KeyChar <> ChrW(8) And e.KeyChar <> ChrW(46) Then
            e.Handled = True
        ElseIf Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            txtOtrosCostos.SelectionLength = Len(txtOtrosCostos.Text)
            txtOtrosCostos.Select()
        End If
    End Sub

    Private Sub txtOtrosCostos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtOtrosCostos.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> Keys.Enter And e.KeyChar <> ChrW(8) And e.KeyChar <> ChrW(46) Then
            e.Handled = True
        ElseIf Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            pbxGuardar.Select()
        End If
    End Sub

    Private Sub txtAlicuotaIva_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAlicuotaIva.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> Keys.Enter And e.KeyChar <> ChrW(8) And e.KeyChar <> ChrW(46) Then
            e.Handled = True
        ElseIf Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            txtFlete.SelectionLength = Len(txtFlete.Text)
            txtFlete.Select()
        End If
    End Sub

    Private Sub txtPrecioVtaPorKgSinIva_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecioVtaPorKgSinIva.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> Keys.Enter And e.KeyChar <> ChrW(8) And e.KeyChar <> ChrW(46) Then
            e.Handled = True
        ElseIf Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            txtAlicuotaIva.SelectionLength = Len(txtAlicuotaIva.Text)
            txtAlicuotaIva.Select()
        End If
    End Sub

    Private Sub txtComprador_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtComprador.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            txtPrecioVtaPorKgSinIva.SelectionLength = Len(txtPrecioVtaPorKgSinIva.Text)
            txtPrecioVtaPorKgSinIva.Select()
        End If
    End Sub

    Private Sub txtPrecioVtaPorKgSinIva_Validated(sender As Object, e As EventArgs) Handles txtPrecioVtaPorKgSinIva.Validated
        Calcular()
    End Sub

    Private Sub txtAlicuotaIva_Validated(sender As Object, e As EventArgs) Handles txtAlicuotaIva.Validated
        Calcular()
    End Sub

    Private Sub txtFlete_Validated(sender As Object, e As EventArgs) Handles txtFlete.Validated
        Costos()
    End Sub

    Private Sub txtOtrosCostos_Validated(sender As Object, e As EventArgs) Handles txtOtrosCostos.Validated
        Costos()
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        txtComprador.Text = ""
        txtAlicuotaIva.Text = ""
        txtFlete.Text = ""
        txtPrecioVtaPorKgSinIva.Text = ""
        txtOtrosCostos.Text = ""

        lblImporteNetoVtaFinal.Text = ""
        lblPrecioVtaConIvaPorKg.Text = ""
        lblImporteVtaConIvaPorCabezas.Text = ""
        lblImporteVta.Text = ""

        lblImporteNetoVtaFinal.BackColor = Color.DimGray

        Dim rows As Integer = dgvAnimSeleccionados.Rows.Count - 1

        If dgvAnimSeleccionados.Rows.Count > 0 Then
            For j As Integer = rows To 0 Step -1
                dgvAnimSeleccionados.Rows.Remove(dgvAnimSeleccionados.Rows(j))
            Next
        End If

        gbxNuevoUno.Visible = True
        gbxNuevoDos.Visible = False
    End Sub
End Class