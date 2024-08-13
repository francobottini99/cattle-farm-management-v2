Imports MySql.Data.MySqlClient

Public Class frmManejoAlimentacion
    Private Const V As Boolean = False

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

    Private Sub pbxAgregar_GotFocus(sender As Object, e As EventArgs) Handles pbxAgregar.GotFocus
        pbxAgregar.BackgroundImage = SITRABO.My.Resources.btnAgregarSeleccionVerde
    End Sub

    Private Sub pbxAgregar_LostFocus(sender As Object, e As EventArgs) Handles pbxAgregar.LostFocus
        pbxAgregar.BackgroundImage = SITRABO.My.Resources.btnAgregarSeleccionVerdeNo
    End Sub

    Private Sub pbxAgregar_MouseEnter(sender As Object, e As EventArgs) Handles pbxAgregar.MouseEnter
        pbxAgregar.BackgroundImage = SITRABO.My.Resources.btnAgregarSeleccionVerde
    End Sub

    Private Sub pbxAgregar_MouseLeave(sender As Object, e As EventArgs) Handles pbxAgregar.MouseLeave
        pbxAgregar.BackgroundImage = SITRABO.My.Resources.btnAgregarSeleccionVerdeNo
    End Sub

    Private Sub pbxQuitar_GotFocus(sender As Object, e As EventArgs) Handles pbxQuitar.GotFocus
        pbxQuitar.BackgroundImage = SITRABO.My.Resources.btnQuitarSeleccionRojo
    End Sub

    Private Sub pbxQuitar_LostFocus(sender As Object, e As EventArgs) Handles pbxQuitar.LostFocus
        pbxQuitar.BackgroundImage = SITRABO.My.Resources.btnQuitarSeleccionRojoNo
    End Sub

    Private Sub pbxQuitar_MouseEnter(sender As Object, e As EventArgs) Handles pbxQuitar.MouseEnter
        pbxQuitar.BackgroundImage = SITRABO.My.Resources.btnQuitarSeleccionRojo
    End Sub

    Private Sub pbxQuitar_MouseLeave(sender As Object, e As EventArgs) Handles pbxQuitar.MouseLeave
        pbxQuitar.BackgroundImage = SITRABO.My.Resources.btnQuitarSeleccionRojoNo
    End Sub

    Private Sub pbxSalir_Click(sender As Object, e As EventArgs) Handles pbxSalir.Click
        Me.Close()
    End Sub

    Private Sub frmAltaProductor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim _Dt As DataTable
        Dim _Ver As New Mostrar

        _Dt = _Ver.verStockUs(frmLogin.txtID.Text)

        Dim ctlNuevo As Control = DirectCast(pbxNuevo, Control)
        Dim keyprNuevo = New KeyPressEventHandler(AddressOf btnNuevo)
        Dim ctlGuardar As Control = DirectCast(pbxGuardar, Control)
        Dim keyprGuardar = New KeyPressEventHandler(AddressOf btnGuardar)
        Dim ctlAgregar As Control = DirectCast(pbxAgregar, Control)
        Dim keyprAgregar = New KeyPressEventHandler(AddressOf btnAgregar)

        AddHandler ctlNuevo.KeyPress, keyprNuevo
        AddHandler ctlGuardar.KeyPress, keyprGuardar
        AddHandler ctlAgregar.KeyPress, keyprAgregar

        Me.Text = "Si.Tra.Bo. - Sistema de Trazabilidad Bovina" & " - USUARIO: " & frmLogin.txtNom.Text & " " & frmLogin.txtAp.Text & " -"

        txtKGTotales.Text = Format(0, "#,##0")
        txtKGGrano.Text = Format(0, "#,##0")
        txtKGSilo.Text = Format(0, "#,##0")
        txtKGConcentrado.Text = Format(0, "#,##0")
        txtKGFibra.Text = Format(0, "#,##0")
        txtKGOtros.Text = Format(0, "#,##0")
        txtKGDif.Text = Format(0, "#,##0")

        If _Dt.Rows.Count > 0 Then
            MonthCalendar1.MinDate = _Dt.Rows(0).Item(1)
            mtcFiltro.MinDate = _Dt.Rows(0).Item(1)
        Else
            MsgBox("No existen animales en el sistema... !", vbInformation, "Servico de Alertas")
            Me.Close()
        End If

        mtcFiltro.MaxDate = Date.Now.Date
        MonthCalendar1.MaxDate = Date.Now.Date
        lblFecha.Text = MonthCalendar1.TodayDate
    End Sub

    Private Sub btnNuevo(ByVal sender As System.Object, ByVal e As KeyPressEventArgs)
        If Asc(e.KeyChar) = Keys.Enter Then
            pbxNuevo_Click(1, Nothing)
        End If
    End Sub

    Private Sub btnAgregar(ByVal sender As System.Object, ByVal e As KeyPressEventArgs)
        If Asc(e.KeyChar) = Keys.Enter Then
            pbxAgregar_Click(1, Nothing)
        End If
    End Sub

    Private Sub btnGuardar(ByVal sender As System.Object, ByVal e As KeyPressEventArgs)
        If Asc(e.KeyChar) = Keys.Enter Then
            pbxGuardar_Click(1, Nothing)
        End If
    End Sub

    Private Sub pbxNuevo_Click(sender As Object, e As EventArgs) Handles pbxNuevo.Click
        Activar()
        lblMsg.Text = "ALIMENTACION"
        pbxNuevo.BackgroundImage = SITRABO.My.Resources.btnNuevoSi

        FechaStock(Date.Now.Date)

        Dim _Dt, _Dt2, _Dt3, _DTM As New DataTable
        Dim _Ver, _Ver2, _Ver3, _VerM As New Mostrar

        _DTM = _VerM.verMaxIdAlimentacion()

        If _DTM.Rows.Count = 0 Then
            lblFechaUltAlim.Text = Date.Now.Date
        Else
            Dim row As DataRow = _DTM.Rows(_DTM.Rows.Count - 1)
            _Dt3 = _Ver3.verAlimentacionID(row("UltimoId"))

            Dim rwF As DataRow = _Dt3.Rows(_Dt3.Rows.Count - 1)
            lblFechaUltAlim.Text = Format(rwF("Fecha"), "dd/MM/yyyy")
        End If

        If frmLogin.txtTipUs.Text = "Super Usuario" Then
            _Dt = _Ver.verRaciones
            _Dt2 = _Ver2.verCorrales
        Else
            _Dt = _Ver.verRacionesUs(frmLogin.txtID.Text)
            _Dt2 = _Ver2.verCorralesUs(frmLogin.txtID.Text)
        End If

        dgvRacion.RowTemplate.Height = 25
        dgvRacion.DataSource = _Dt
        dgvRacion.Columns("idRaciones").Visible = False
        dgvRacion.Columns("Grano").Visible = False
        dgvRacion.Columns("Silo").Visible = False
        dgvRacion.Columns("Concentrado").Visible = False
        dgvRacion.Columns("Fibra").Visible = False
        dgvRacion.Columns("Otros").Visible = False
        dgvRacion.Columns("CostoGrano").Visible = False
        dgvRacion.Columns("CostoSilo").Visible = False
        dgvRacion.Columns("CostoConcentrado").Visible = False
        dgvRacion.Columns("CostoFibra").Visible = False
        dgvRacion.Columns("CostoOtros").Visible = False
        dgvRacion.Columns("USUARIOS_idUsuario").Visible = False

        dgvCorralesDisp.RowTemplate.Height = 25
        dgvCorralesDisp.DataSource = _Dt2


        Dim rows As Integer = _Dt2.Rows.Count - 1

        For j As Integer = rows To 0 Step -1
            If _Dt2.Rows(j).Item("CabezasTotales") = 0 Then
                _Dt2.Rows.Remove(_Dt2.Rows(j))
            End If
        Next

        dgvCorralesDisp.Columns("idCorrales").Visible = False
        dgvCorralesDisp.Columns("Superficie").Visible = False
        dgvCorralesDisp.Columns("CabezasTotales").Visible = False
        dgvCorralesDisp.Columns("CAMPO_idCampo").Visible = False
        dgvCorralesDisp.Columns("USUARIOS_idUsuario").Visible = False

        If dgvCorralesDisp.Rows.Count <= 0 Then
            MsgBox("Error: No se a encontrado ningun corral con stock disponible... !", vbExclamation, "Servico de Alertas")
            Cancelar()
        Else
            txtOrigen.Text = "Nuevo"

            gbxNuevo.Visible = True

            dgvCorralesDisp.CurrentCell = Nothing
            dgvCorralesDisp.Refresh()
            dgvRacion.CurrentCell = Nothing
            dgvRacion.Refresh()
        End If
    End Sub

    Private Sub Activar()
        gbxPantallaInicio.Visible = False
        pbxNuevo.Enabled = False
        pbxGuardar.Enabled = True
        pbxCancelar.Enabled = True
        pbxModificar.Enabled = False
        pbxSalir.Enabled = False
    End Sub

    Private Sub Cancelar()
        gbxPantallaInicio.Visible = True
        gbxNuevo.Visible = False
        gbxModificar.Visible = False
        pbxNuevo.Enabled = True
        pbxGuardar.Enabled = False
        pbxCancelar.Enabled = False
        pbxModificar.Enabled = True
        pbxSalir.Enabled = True
        gbxNuevo.Enabled = True
        frmGuardarAlimentacion.lblAlimentacion.Visible = True
        frmGuardarAlimentacion.lblRegistro.Visible = True
        'frmGuardarAlimentacion.Label7.Visible = True
        frmGuardarAlimentacion.pgbRegistros.Visible = True
        frmGuardarAlimentacion.pgbAlimentacion.Visible = True
        frmGuardarAlimentacion.lblGuardado.Visible = V
        dgvCorralesSel.Visible = True
        pbxAgregar.Visible = True
        pbxQuitar.Visible = True
        PictureBox3.Visible = True

        lblFecha.Text = MonthCalendar1.TodayDate
        txtInformacionMod.Text = ""
        txtInformacion.Text = ""
        lblFechaStock.Text = ""
        txtKGTotales.Text = Format(0, "#,##0")
        txtKGGrano.Text = Format(0, "#,##0")
        txtKGConcentrado.Text = Format(0, "#,##0")
        txtKGFibra.Text = Format(0, "#,##0")
        txtKGOtros.Text = Format(0, "#,##0")
        txtKGDif.Text = Format(0, "#,##0")
        gbxKGAlimentacion.Enabled = V
        dgvCorralesDisp.DataSource = Nothing
        dgvRacion.DataSource = Nothing
        dgvAlimentaciones.DataSource = Nothing

        Dim rows As Integer = dgvCorralesSel.Rows.Count - 1

        If dgvCorralesSel.Rows.Count > 0 Then
            For j As Integer = rows To 0 Step -1
                dgvCorralesSel.Rows.Remove(dgvCorralesSel.Rows(j))
            Next
        End If

        dgvCorralesSel.ColumnHeadersVisible = V
        dgvCorralesSel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub pbxGuardar_Click(sender As Object, e As EventArgs) Handles pbxGuardar.Click
        Dim G As New GrabaDatos
        Dim resP As DialogResult
        Dim _Ver, _Ver2, _Ver3, _ver4, _Ver5, _Ver6, _Ver7, _VerM As New Mostrar
        Dim _Dt, _Dt2, _Dt3, _Dt4, _Dt5, _Dt6, _Dt7, _DtM As New DataTable

        Try
            Dim CostG, CostS, CostF, CostC, CostO, PGr, PSi, PCo, PFb, POt, Peso, ConsumoT, TotalConsT, PorCons As Double
            Dim Dias, x As Integer
            Dim Consumo(1, 2) As Double
            Dim rows As Integer = dgvRacion.Rows.Count - 1
            Dim _Row As DataRow
            Dim ulTid As Integer

            If txtOrigen.Text = "Nuevo" Then
                If dgvCorralesSel.Rows.Count < 1 Then
                    MsgBox("Error: No hay ninguna alimentacion cargada para guardar... !", vbExclamation, "Servico de Alertas")
                Else
                    resP = MessageBox.Show("Grabar Alimentacion ?", "Servico de Alertas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                    If resP = Windows.Forms.DialogResult.OK Then

                        frmGuardarAlimentacion.Show()
                        frmGuardarAlimentacion.Refresh()
                        gbxNuevo.Enabled = False

                        frmGuardarAlimentacion.pgbAlimentacion.Maximum = dgvCorralesSel.Rows.Count

                        _Dt6 = _Ver6.verStocCorralesUs(CInt(frmLogin.txtID.Text), "Engorde")

                        ReDim Consumo(_Dt6.Rows.Count, 2)
                        x = 0

                        For i As Integer = 0 To dgvCorralesSel.Rows.Count - 1
                            frmGuardarAlimentacion.lblAlimentacion.Text = "Alimentacion:" + i.ToString + "/" + dgvCorralesSel.Rows.Count.ToString
                            frmGuardarAlimentacion.lblAlimentacion.Refresh()

                            For j As Integer = rows To 0 Step -1
                                If dgvRacion.Rows(j).Cells.Item(1).Value = dgvCorralesSel.Rows(i).Cells.Item(2).Value Then
                                    CostG = dgvCorralesSel.Rows(i).Cells.Item(4).Value * CDbl(dgvRacion.Rows(j).Cells.Item(7).Value)
                                    CostS = dgvCorralesSel.Rows(i).Cells.Item(5).Value * CDbl(dgvRacion.Rows(j).Cells.Item(8).Value)
                                    CostC = dgvCorralesSel.Rows(i).Cells.Item(6).Value * CDbl(dgvRacion.Rows(j).Cells.Item(9).Value)
                                    CostF = dgvCorralesSel.Rows(i).Cells.Item(7).Value * CDbl(dgvRacion.Rows(j).Cells.Item(10).Value)
                                    CostO = dgvCorralesSel.Rows(i).Cells.Item(8).Value * CDbl(dgvRacion.Rows(j).Cells.Item(11).Value)
                                End If
                            Next

                            PGr = (dgvCorralesSel.Rows(i).Cells.Item(4).Value / dgvCorralesSel.Rows(i).Cells.Item(3).Value) * 100
                            PSi = (dgvCorralesSel.Rows(i).Cells.Item(5).Value / dgvCorralesSel.Rows(i).Cells.Item(3).Value) * 100
                            PCo = (dgvCorralesSel.Rows(i).Cells.Item(6).Value / dgvCorralesSel.Rows(i).Cells.Item(3).Value) * 100
                            PFb = (dgvCorralesSel.Rows(i).Cells.Item(7).Value / dgvCorralesSel.Rows(i).Cells.Item(3).Value) * 100
                            POt = (dgvCorralesSel.Rows(i).Cells.Item(8).Value / dgvCorralesSel.Rows(i).Cells.Item(3).Value) * 100

                            G.Grabar("Alimentacion", "NoImagen", "feedlot.insAlimentacion", Format(CDate(dgvCorralesSel.Rows(i).Cells.Item(0).Value), "yyyy/MM/dd"), CDbl(dgvCorralesSel.Rows(i).Cells.Item(3).Value),
                                     "-", CDbl(dgvCorralesSel.Rows(i).Cells.Item(4).Value), CDbl(dgvCorralesSel.Rows(i).Cells.Item(5).Value), CDbl(dgvCorralesSel.Rows(i).Cells.Item(6).Value), CDbl(dgvCorralesSel.Rows(i).Cells.Item(7).Value),
                                     CDbl(dgvCorralesSel.Rows(i).Cells.Item(8).Value), CostG, CostS, CostC, CostF, CostO, (CostG + CostS + CostC + +CostF + CostO),
                                     Format(PGr, "#,##0.00"), Format(PSi, "#,##0.00"), Format(PCo, "#,##0.00"), Format(PFb, "#,##0.00"), Format(POt, "#,##0.00"), "-",
                                     CInt(dgvCorralesSel.Rows(i).Cells.Item(9).Value), CInt(dgvCorralesSel.Rows(i).Cells.Item(10).Value), CInt(frmLogin.txtID.Text))

                            _DtM = _VerM.verMaxIdAlimentacion()
                            _Row = _DtM.Rows(_DtM.Rows.Count - 1)

                            If _Row("UltimoId").ToString = "" Then
                                ulTid = 0
                            Else
                                ulTid = _Row("UltimoId")
                            End If

                            Dim Fecha As Date = dgvCorralesSel.Rows(i).Cells.Item(0).Value

                            _Dt7 = _Ver7.verStkDia(Fecha, CInt(frmLogin.txtID.Text))

                            If _Dt7.Rows.Count <= 0 Then
                                Fecha = FechaStock(Fecha)
                            End If

                            _Dt2 = _Ver2.verStkCorralFec(CInt(frmLogin.txtID.Text), dgvCorralesSel.Rows(i).Cells.Item(9).Value, Fecha)
                            frmGuardarAlimentacion.pgbRegistros.Maximum = _Dt2.Rows.Count - 1

                            For Each _Dr As DataRow In _Dt2.Rows
                                _Dt3 = _Ver3.verPesajeDtalleTropa(CInt(frmLogin.txtID.Text), _Dr("DETALLE_TROPA_idDetTropa"))
                                _Dt4 = _ver4.verTropaPesoIngresoUs(CInt(frmLogin.txtID.Text), _Dr("TROPA_idTropa"))
                                frmGuardarAlimentacion.lblRegistro.Text = "Estimando Pesos: " + x.ToString + "/" + (_Dt2.Rows.Count - 1).ToString
                                frmGuardarAlimentacion.lblRegistro.Refresh()

                                G.Grabar("tropa_bloqueo_mod", "NoImagen", "feedlot.modEstadoMod", "NO", _Dr("TROPA_idTropa"))

                                If _Dt3.Rows.Count > 0 Then
                                    If DateDiff(DateInterval.Day, _Dt3.Rows(0).Item(1), dgvCorralesSel.Rows(i).Cells.Item(0).Value) > 0 Then
                                        Peso = _Dt3.Rows(0).Item(3)
                                        Dias = DateDiff(DateInterval.Day, _Dt3.Rows(0).Item(1), dgvCorralesSel.Rows(i).Cells.Item(0).Value)
                                    Else
                                        Peso = _Dt4.Rows(0).Item(8)
                                        Dias = DateDiff(DateInterval.Day, _Dt4.Rows(0).Item(3), dgvCorralesSel.Rows(i).Cells.Item(0).Value)
                                    End If
                                Else
                                    Peso = _Dt4.Rows(0).Item(8)
                                    Dias = DateDiff(DateInterval.Day, _Dt4.Rows(0).Item(3), dgvCorralesSel.Rows(i).Cells.Item(0).Value)
                                End If


                                'For j As Integer = 0 To Dias
                                '    Peso += (Peso * 0.03 / (5 + 10.35 * (Peso / 800)))
                                'Next

                                Peso += ((0.03 - 0.02 / (1 + (Dias ^ 3))) * Peso * Dias) / (15.35 - 10.35 / (1 + (Peso / 600)))

                                TotalConsT = TotalConsT + (Peso * 0.03)
                                Consumo(x, 1) = _Dr("DETALLE_TROPA_idDetTropa")
                                Consumo(x, 2) = Peso * 0.03

                                x = x + 1
                                frmGuardarAlimentacion.pgbRegistros.Increment(1)
                                frmGuardarAlimentacion.Refresh()
                            Next

                            frmGuardarAlimentacion.pgbRegistros.Value = 0
                            frmGuardarAlimentacion.pgbRegistros.Maximum = x - 1
                            frmGuardarAlimentacion.Refresh()

                            For j As Integer = 0 To x - 1
                                PorCons = Consumo(j, 2) / TotalConsT
                                frmGuardarAlimentacion.lblRegistro.Text = "Grabando Registros: " + j.ToString + "/" + (x - 1).ToString
                                frmGuardarAlimentacion.lblRegistro.Refresh()

                                G.Grabar("alimentacion_prorrateo", "NoImagen", "feedlot.insAlimentacionProrrateo", Format(CDate(dgvCorralesSel.Rows(i).Cells.Item(0).Value), "yyyy/MM/dd"), CDbl(dgvCorralesSel.Rows(i).Cells.Item(3).Value) * PorCons,
                                       CDbl(dgvCorralesSel.Rows(i).Cells.Item(4).Value) * PorCons, CDbl(dgvCorralesSel.Rows(i).Cells.Item(5).Value) * PorCons, CDbl(dgvCorralesSel.Rows(i).Cells.Item(6).Value) * PorCons, CDbl(dgvCorralesSel.Rows(i).Cells.Item(7).Value) * PorCons,
                                        CDbl(dgvCorralesSel.Rows(i).Cells.Item(8).Value) * PorCons, CostG * PorCons, CostS * PorCons, CostC * PorCons, CostF * PorCons, CostO * PorCons, (CostG + CostS + CostC + CostF + CostO) * PorCons,
                                        Format(PGr, "#,##0.00"), Format(PSi, "#,##0.00"), Format(PCo, "#,##0.00"), Format(PFb, "#,##0.00"), Format(POt, "#,##0.00"), CInt(dgvCorralesSel.Rows(i).Cells.Item(10).Value), CInt(Consumo(j, 1)),
                                        CInt(frmLogin.txtID.Text), ulTid)

                                frmGuardarAlimentacion.pgbRegistros.Increment(1)
                                frmGuardarAlimentacion.Refresh()
                            Next

                            TotalConsT = 0
                            x = 0
                            frmGuardarAlimentacion.pgbAlimentacion.Increment(1)
                            frmGuardarAlimentacion.Refresh()
                        Next

                        'System.Threading.Thread.Sleep(300)
                        frmGuardarAlimentacion.lblAlimentacion.Visible = False
                        frmGuardarAlimentacion.lblRegistro.Visible = False
                        'frmGuardarAlimentacion.Label7.Visible = False
                        frmGuardarAlimentacion.pgbRegistros.Visible = False
                        frmGuardarAlimentacion.pgbAlimentacion.Visible = False
                        frmGuardarAlimentacion.lblGuardado.Visible = True
                        frmGuardarAlimentacion.Refresh()
                        frmGuardarAlimentacion.lblGuardado.Refresh()
                        System.Threading.Thread.Sleep(2000)
                        Cancelar()
                        pbxNuevo.BackgroundImage = SITRABO.My.Resources.btnNuevoNo
                        lblMsg.Text = "ALIMENTACION"
                        txtOrigen.Text = ""
                        frmGuardarAlimentacion.pgbAlimentacion.Value = 0
                        frmGuardarAlimentacion.pgbRegistros.Value = 0
                        frmGuardarAlimentacion.Hide()
                    End If
                End If
            Else
                If txtIDCrr.Text = "" Then
                    MsgBox("No hay ningun corral seleccionado... !", vbExclamation, "Servico de Alertas")
                Else
                    If txtIDRac.Text = "" Then
                        MsgBox("No hay ningun corral seleccionado... !", vbExclamation, "Servico de Alertas")
                    Else
                        If txtKGTotales.Text = "" Or txtKGTotales.Text = 0 Then
                            MsgBox("Error: No has especificado los KG totales de la alimentacion... !", vbExclamation, "Servico de Alertas")
                            txtKGTotales.SelectionLength = Len(txtKGTotales.Text)
                            txtKGTotales.Select()
                        Else
                            If txtKGDif.Text > 0 Then
                                MsgBox("Quedan KG sin asignar... !", vbExclamation, "Servico de Alertas")
                                txtKGTotales.SelectionLength = Len(txtKGTotales.Text)
                                txtKGTotales.Select()
                            Else
                                If txtKGDif.Text < 0 Then
                                    MsgBox("La alimentacion se execede de los KG asignados... !", vbExclamation, "Servico de Alertas")
                                    txtKGTotales.SelectionLength = Len(txtKGTotales.Text)
                                    txtKGTotales.Select()
                                Else
                                    resP = MessageBox.Show("Modificar Alimentacion ?", "Servico de Alertas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                                    If resP = Windows.Forms.DialogResult.OK Then
                                        G.Grabar("Alimentacion", "NoImagen", "feedlot.modBorrarAlimentacion", txtIDModAlim.Text)

                                        _Dt6 = _Ver6.verStocCorralesUs(CInt(frmLogin.txtID.Text), "Engorde")

                                        ReDim Consumo(_Dt6.Rows.Count, 2)
                                        x = 0

                                        For j As Integer = rows To 0 Step -1
                                            If dgvRacion.Rows(j).Cells.Item(0).Value = txtIDRac.Text Then
                                                CostG = txtKGGrano.Text * CDbl(dgvRacion.Rows(j).Cells.Item(7).Value)
                                                CostS = txtKGSilo.Text * CDbl(dgvRacion.Rows(j).Cells.Item(8).Value)
                                                CostC = txtKGConcentrado.Text * CDbl(dgvRacion.Rows(j).Cells.Item(9).Value)
                                                CostF = txtKGFibra.Text * CDbl(dgvRacion.Rows(j).Cells.Item(10).Value)
                                                CostO = txtKGOtros.Text * CDbl(dgvRacion.Rows(j).Cells.Item(11).Value)
                                            End If
                                        Next

                                        PGr = (txtKGGrano.Text / txtKGTotales.Text) * 100
                                        PSi = (txtKGSilo.Text / txtKGTotales.Text) * 100
                                        PCo = (txtKGConcentrado.Text / txtKGTotales.Text) * 100
                                        PFb = (txtKGFibra.Text / txtKGTotales.Text) * 100
                                        POt = (txtKGOtros.Text / txtKGTotales.Text) * 100

                                        G.Grabar("Alimentacion", "NoImagen", "feedlot.modAlimentacion", txtIDModAlim.Text, Format(CDate(lblFecha.Text), "yyyy/MM/dd"), CDbl(txtKGTotales.Text),
                                                 "-", CDbl(txtKGGrano.Text), CDbl(txtKGSilo.Text), CDbl(txtKGConcentrado.Text), CDbl(txtKGFibra.Text),
                                                 CDbl(txtKGOtros.Text), CostG, CostS, CostC, CostF, CostO, (CostG + CostS + CostC + CostF + CostO),
                                                 Format(PGr, "#,##0.00"), Format(PCo, "#,##0.00"), Format(PSi, "#,##0.00"), Format(PFb, "#,##0.00"), Format(POt, "#,##0.00"), "-",
                                                 CInt(txtIDCrr.Text), CInt(txtIDRac.Text), CInt(frmLogin.txtID.Text))

                                        Dim Fecha As Date = lblFecha.Text

                                        _Dt7 = _Ver7.verStkDia(Fecha, CInt(frmLogin.txtID.Text))

                                        If _Dt7.Rows.Count <= 0 Then
                                            Fecha = FechaStock(Fecha)
                                        End If

                                        _Dt2 = _Ver2.verStkCorralFec(CInt(frmLogin.txtID.Text), txtIDCrr.Text, Fecha)

                                        For Each _Dr As DataRow In _Dt2.Rows
                                            _Dt3 = _Ver3.verPesajeDtalleTropa(CInt(frmLogin.txtID.Text), _Dr("DETALLE_TROPA_idDetTropa"))
                                            _Dt4 = _ver4.verTropaPesoIngresoUs(CInt(frmLogin.txtID.Text), _Dr("TROPA_idTropa"))

                                            G.Grabar("tropa_bloqueo_mod", "NoImagen", "feedlot.modEstadoMod", "NO", _Dr("TROPA_idTropa"))

                                            If _Dt3.Rows.Count > 0 Then
                                                Peso = _Dt3.Rows(0).Item(3)
                                                Dias = DateDiff(DateInterval.Day, _Dt3.Rows(0).Item(1), CDate(lblFecha.Text))
                                            Else
                                                Peso = _Dt4.Rows(0).Item(8)
                                                Dias = DateDiff(DateInterval.Day, _Dt4.Rows(0).Item(3), CDate(lblFecha.Text))
                                            End If

                                            While Dias > 0
                                                _Dt5 = _Ver5.verPesoEstimadoPorAnimal(Peso)

                                                If _Dt5.Rows.Count > 0 Then
                                                    If Dias >= 100 Then
                                                        Peso = _Dt5.Rows(0).Item(101)
                                                        Dias = Dias - 100
                                                    Else
                                                        Peso = _Dt5.Rows(0).Item(Dias + 1)
                                                        Dias = Dias - Dias
                                                    End If
                                                Else
                                                    If Peso > 800 Then
                                                        Peso = 800
                                                        Dias = 0
                                                    ElseIf Peso < 60 Then
                                                        Peso = 60
                                                    Else
                                                        Peso = _Dt4.Rows(0).Item(8)
                                                        Dias = DateDiff(DateInterval.Day, _Dt4.Rows(0).Item(3), CDate(lblFecha.Text))
                                                    End If
                                                End If
                                            End While

                                            If Peso > 500 Then
                                                ConsumoT = Peso * 0.027
                                            Else
                                                ConsumoT = Peso * 0.03
                                            End If

                                            TotalConsT = TotalConsT + ConsumoT
                                            Consumo(x, 1) = _Dr("DETALLE_TROPA_idDetTropa")
                                            Consumo(x, 2) = ConsumoT

                                            x = x + 1
                                        Next

                                        For j As Integer = 0 To x - 1
                                            PorCons = Consumo(j, 2) / TotalConsT

                                            G.Grabar("alimentacion_prorrateo", "NoImagen", "feedlot.insAlimentacionProrrateo", Format(CDate(lblFecha.Text), "yyyy/MM/dd"), CDbl(txtKGTotales.Text) * PorCons,
                                                CDbl(txtKGGrano.Text) * PorCons, CDbl(txtKGSilo.Text) * PorCons, CDbl(txtKGConcentrado.Text) * PorCons, CDbl(txtKGFibra.Text) * PorCons,
                                                CDbl(txtKGOtros.Text) * PorCons, CostG * PorCons, CostS * PorCons, CostC * PorCons, CostF * PorCons, CostO * PorCons, (CostG + CostS + CostC + CostF + CostO) * PorCons,
                                                Format(PGr, "#,##0.00"), Format(PSi, "#,##0.00"), Format(PCo, "#,##0.00"), Format(PFb, "#,##0.00"), Format(POt, "#,##0.00"), CInt(txtIDRac.Text), CInt(Consumo(j, 1)),
                                                CInt(frmLogin.txtID.Text), txtIDModAlim.Text)
                                        Next

                                        TotalConsT = 0

                                        Cancelar()
                                        pbxNuevo.BackgroundImage = SITRABO.My.Resources.btnNuevoNo
                                        lblMsg.Text = "ALIMENTACION"
                                        txtOrigen.Text = ""
                                    End If
                                End If
                            End If
                        End If
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

    Function FechaStock(ByVal Fecha As Date) As Date
        Dim _Dt As New DataTable
        Dim _Ver As New Mostrar

        While _Dt.Rows.Count <= 0
            _Dt = _Ver.verStkDia(Fecha, CInt(frmLogin.txtID.Text))

            If _Dt.Rows.Count > 0 Then
                Fecha = _Dt.Rows(0).Item(1)
                lblFechaStock.Text = Fecha
                Exit While
            Else
                Fecha = DateAdd(DateInterval.Day, -1, Fecha)
            End If
        End While

        Return Fecha
    End Function

    Private Sub pbxCancelar_Click(sender As Object, e As EventArgs) Handles pbxCancelar.Click
        Cancelar()
        lblMsg.Text = "ALIMENTACION"
        pbxNuevo.BackgroundImage = SITRABO.My.Resources.btnNuevoNo
        pbxModificar.BackgroundImage = SITRABO.My.Resources.btnModificarNo
    End Sub

    Private Sub dgvRacion_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRacion.CellClick
        txtInformacion.Text = "--------------------- RACION -----------------------" + vbNewLine +
        vbNewLine + "Grano       : " + dgvRacion.CurrentRow.Cells.Item(2).Value + vbNewLine + "Silo         : " + dgvRacion.CurrentRow.Cells.Item(3).Value + vbNewLine +
        "Concent.  : " + dgvRacion.CurrentRow.Cells.Item(4).Value + vbNewLine + "Fibra        : " + dgvRacion.CurrentRow.Cells.Item(5).Value +
        vbNewLine + "Otros        : " + dgvRacion.CurrentRow.Cells.Item(6).Value

        txtKGTotales.Text = Format(0, "#,##0")
        txtKGGrano.Text = Format(0, "#,##0")
        txtKGSilo.Text = Format(0, "#,##0")
        txtKGConcentrado.Text = Format(0, "#,##0")
        txtKGFibra.Text = Format(0, "#,##0")
        txtKGOtros.Text = Format(0, "#,##0")
        txtKGDif.Text = Format(0, "#,##0")

        If dgvRacion.CurrentRow.Cells.Item(2).Value = "-" Then
            txtKGGrano.Enabled = False
        Else
            txtKGGrano.Enabled = True
        End If

        If dgvRacion.CurrentRow.Cells.Item(3).Value = "-" Then
            txtKGSilo.Enabled = False
        Else
            txtKGSilo.Enabled = True
        End If

        If dgvRacion.CurrentRow.Cells.Item(4).Value = "-" Then
            txtKGConcentrado.Enabled = False
        Else
            txtKGConcentrado.Enabled = True
        End If

        If dgvRacion.CurrentRow.Cells.Item(5).Value = "-" Then
            txtKGFibra.Enabled = False
        Else
            txtKGFibra.Enabled = True
        End If

        If dgvRacion.CurrentRow.Cells.Item(6).Value = "-" Then
            txtKGOtros.Enabled = False
        Else
            txtKGOtros.Enabled = True
        End If

        dgvCorralesSel.CurrentCell = Nothing
    End Sub

    Private Sub dgvCorralesDisp_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCorralesDisp.CellClick
        If dgvRacion.CurrentRow IsNot Nothing Then
            Dim _Dt, _Dt2 As New DataTable
            Dim _Ver, _Ver2 As New Mostrar
            Dim Fecha As Date = lblFecha.Text

            _Dt2 = _Ver2.verStkDia(Fecha, CInt(frmLogin.txtID.Text))

            If _Dt2.Rows.Count <= 0 Then
                Fecha = FechaStock(Fecha)
            End If

            _Dt = _Ver.verStkCorralFec(CInt(frmLogin.txtID.Text), dgvCorralesDisp.CurrentRow.Cells.Item(0).Value, Fecha)

            txtInformacion.Text = "--------------------- CORRAL ----------------------" + vbNewLine + vbNewLine +
                "Total Cabezas :    " + CStr(_Dt.Rows.Count)

            gbxKGAlimentacion.Enabled = True

            txtKGTotales.Text = Format(0, "#,##0")
            txtKGGrano.Text = Format(0, "#,##0")
            txtKGConcentrado.Text = Format(0, "#,##0")
            txtKGFibra.Text = Format(0, "#,##0")
            txtKGOtros.Text = Format(0, "#,##0")
            txtKGDif.Text = Format(0, "#,##0")

            dgvCorralesSel.CurrentCell = Nothing
            txtKGTotales.SelectionLength = Len(txtKGTotales.Text)
            txtKGTotales.Select()
        Else
            MsgBox("Error: Primero selecciona una racion... !", vbExclamation, "Servico de Alertas")
            dgvCorralesDisp.CurrentCell = Nothing
        End If
    End Sub

    Private Sub pbxModificar_Click(sender As Object, e As EventArgs) Handles pbxModificar.Click
        gbxModificar.Visible = True
        Activar()
        lblMsg.Text = "ALIMENTACION"
        pbxModificar.BackgroundImage = SITRABO.My.Resources.btnModificarSi
        txtOrigen.Text = "Modificar"

        Dim _Dt As New DataTable
        Dim _Ver As New Mostrar

        If frmLogin.txtTipUs.Text = "Super Usuario" Then
            _Dt = _Ver.consAlimentacion
        Else
            _Dt = _Ver.consAlimentacionUS(frmLogin.txtID.Text)
        End If

        Dim rows As Integer = _Dt.Rows.Count - 1

        If _Dt.Rows.Count > 0 Then
            For j As Integer = rows To 0 Step -1
                If Format(CDate(_Dt.Rows(j).Item(0)), "yyyy/MM/dd") < Format(CDate("04/12/2017"), "yyyy/MM/dd") Then
                    _Dt.Rows.Remove(_Dt.Rows(j))
                End If
            Next
        End If

        dgvAlimentaciones.RowTemplate.Height = 25
        dgvAlimentaciones.DataSource = _Dt
        dgvAlimentaciones.Columns("KgRacion").Visible = False
        dgvAlimentaciones.Columns("Turno").Visible = False
        dgvAlimentaciones.Columns("KgGrano").Visible = False
        dgvAlimentaciones.Columns("KgSilo").Visible = False
        dgvAlimentaciones.Columns("KgConcentrado").Visible = False
        dgvAlimentaciones.Columns("KgFibra").Visible = False
        dgvAlimentaciones.Columns("KgOtros").Visible = False
        dgvAlimentaciones.Columns("ImporteGrano").Visible = False
        dgvAlimentaciones.Columns("ImporteSilo").Visible = False
        dgvAlimentaciones.Columns("ImporteConcentrado").Visible = False
        dgvAlimentaciones.Columns("ImporteFibra").Visible = False
        dgvAlimentaciones.Columns("ImporteOtros").Visible = False
        dgvAlimentaciones.Columns("ImporteTotal").Visible = False
        dgvAlimentaciones.Columns("PorcentajeGrano").Visible = False
        dgvAlimentaciones.Columns("PorcentajeSilo").Visible = False
        dgvAlimentaciones.Columns("PorcentajeConc").Visible = False
        dgvAlimentaciones.Columns("PorcentajeFibra").Visible = False
        dgvAlimentaciones.Columns("PorcentajeOtros").Visible = False
        dgvAlimentaciones.Columns("Observaciones").Visible = False
        dgvAlimentaciones.Columns("idCorrales").Visible = False
        dgvAlimentaciones.Columns("NombreRacion").Visible = False
        dgvAlimentaciones.Columns("idRaciones").Visible = False
        dgvAlimentaciones.Columns("idAlimentacion").Visible = False

        dgvAlimentaciones.Columns(18).HeaderCell.Value = "Nombre Corral"

        dgvAlimentaciones.Columns("Fecha").Width = 90
        dgvAlimentaciones.Sort(dgvAlimentaciones.Columns("Fecha"), System.ComponentModel.ListSortDirection.Descending)

        dgvAlimentaciones.CurrentCell = Nothing
        dgvAlimentaciones.Refresh()
    End Sub

    Private Sub pbxAgregar_Click(sender As Object, e As EventArgs) Handles pbxAgregar.Click
        If dgvCorralesDisp.CurrentRow IsNot Nothing Then
            If txtKGTotales.Text = "" Or txtKGTotales.Text = 0 Then
                MsgBox("Error: No has especificado los KG totales de la alimentacion... !", vbExclamation, "Servico de Alertas")
                txtKGTotales.SelectionLength = Len(txtKGTotales.Text)
                txtKGTotales.Select()
            Else
                If txtKGDif.Text > 0 Then
                    MsgBox("Quedan KG sin asignar... !", vbExclamation, "Servico de Alertas")
                    txtKGTotales.SelectionLength = Len(txtKGTotales.Text)
                    txtKGTotales.Select()
                Else
                    If txtKGDif.Text < 0 Then
                        MsgBox("La alimentacion se execede de los KG asignados... !", vbExclamation, "Servico de Alertas")
                        txtKGTotales.SelectionLength = Len(txtKGTotales.Text)
                        txtKGTotales.Select()
                    Else
                        dgvCorralesSel.RowTemplate.Height = 25
                        dgvCorralesSel.ColumnCount = 11
                        dgvCorralesSel.Columns(0).Name = "Fecha"
                        dgvCorralesSel.Columns(1).Name = "Corral"
                        dgvCorralesSel.Columns(2).Name = "Racion"
                        dgvCorralesSel.Columns(3).Name = "KG Totales"
                        dgvCorralesSel.Columns(4).Name = "KG Grano"
                        dgvCorralesSel.Columns(5).Name = "KG Silo"
                        dgvCorralesSel.Columns(6).Name = "KG Concentrado"
                        dgvCorralesSel.Columns(7).Name = "KG Fibra"
                        dgvCorralesSel.Columns(8).Name = "KG Otros"
                        dgvCorralesSel.Columns(9).Name = "IDCrr"
                        dgvCorralesSel.Columns(10).Name = "IDRac"

                        dgvCorralesSel.Columns(9).Visible = False
                        dgvCorralesSel.Columns(10).Visible = False
                        dgvCorralesSel.ColumnHeadersVisible = True
                        dgvCorralesSel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None

                        dgvCorralesSel.Columns("Fecha").Width = 120
                        dgvCorralesSel.Columns("Corral").Width = 250
                        dgvCorralesSel.Columns("Racion").Width = 350
                        dgvCorralesSel.Columns("KG Totales").Width = 130
                        dgvCorralesSel.Columns("KG Grano").Width = 130
                        dgvCorralesSel.Columns("KG Silo").Width = 130
                        dgvCorralesSel.Columns("KG Concentrado").Width = 130
                        dgvCorralesSel.Columns("KG Fibra").Width = 130
                        dgvCorralesSel.Columns("KG Otros").Width = 130

                        dgvCorralesSel.Columns("Fecha").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                        dgvCorralesSel.Columns("Corral").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        dgvCorralesSel.Columns("KG Totales").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                        dgvCorralesSel.Columns("KG Grano").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                        dgvCorralesSel.Columns("KG Silo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                        dgvCorralesSel.Columns("KG Concentrado").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                        dgvCorralesSel.Columns("KG Fibra").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                        dgvCorralesSel.Columns("KG Otros").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                        Dim rows As Integer = dgvCorralesSel.Rows.Count - 1
                        Dim Msg As Boolean = False
                        Dim resP As DialogResult

                        For j As Integer = rows To 0 Step -1
                            If dgvCorralesSel.Rows(j).Cells.Item(1).Value = dgvCorralesDisp.CurrentRow.Cells.Item(1).Value And dgvCorralesSel.Rows(j).Cells.Item(0).Value = lblFecha.Text Then
                                Msg = True
                            End If
                        Next

                        If Msg = False Then
                            resP = Windows.Forms.DialogResult.OK
                        Else
                            resP = MessageBox.Show("El corral Seleccionado ya contiene una Alimentacion pre-cargada en esa fecha, desea continuar de todas formas ?", "Servico de Alertas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                        End If

                        If resP = Windows.Forms.DialogResult.OK Then
                            dgvCorralesSel.Rows.Add(lblFecha.Text, dgvCorralesDisp.CurrentRow.Cells.Item(1).Value, dgvRacion.CurrentRow.Cells.Item(1).Value, txtKGTotales.Text, txtKGGrano.Text, txtKGSilo.Text, txtKGConcentrado.Text, txtKGFibra.Text, txtKGOtros.Text, dgvCorralesDisp.CurrentRow.Cells.Item(0).Value, dgvRacion.CurrentRow.Cells.Item(0).Value)

                            gbxKGAlimentacion.Enabled = False
                            dgvCorralesDisp.CurrentCell = Nothing
                            dgvCorralesSel.CurrentCell = Nothing
                            dgvRacion.CurrentCell = Nothing

                            txtInformacion.Text = ""

                            txtKGTotales.Text = Format(0, "#,##0")
                            txtKGGrano.Text = Format(0, "#,##0")
                            txtKGSilo.Text = Format(0, "#,##0")
                            txtKGConcentrado.Text = Format(0, "#,##0")
                            txtKGFibra.Text = Format(0, "#,##0")
                            txtKGOtros.Text = Format(0, "#,##0")
                            txtKGDif.Text = Format(0, "#,##0")
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub MonthCalendar1_DateSelected(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateSelected
        Dim Fecha As Date = MonthCalendar1.SelectionRange.Start.ToShortDateString()
        Dim _Dt, _Dt2, _Dt3 As New DataTable
        Dim _Ver, _Ver2, _Ver3 As New Mostrar

        _Dt = _Ver.verStkDia(Fecha, CInt(frmLogin.txtID.Text))

        If _Dt.Rows.Count <= 0 Then
            Fecha = FechaStock(Fecha)
        End If

        If frmLogin.txtTipUs.Text = "Super Usuario" Then
            _Dt2 = _Ver2.verCorrales
        Else
            _Dt2 = _Ver2.verCorralesUs(frmLogin.txtID.Text)
        End If

        Dim rows As Integer = _Dt2.Rows.Count - 1

        For j As Integer = rows To 0 Step -1
            _Dt3 = _Ver3.verStkCorralFec(CInt(frmLogin.txtID.Text), _Dt2.Rows(j).Item("idCorrales"), Fecha)

            If _Dt3.Rows.Count <= 0 Then
                _Dt2.Rows.Remove(_Dt2.Rows(j))
            End If
        Next

        dgvCorralesDisp.DataSource = _Dt2

        dgvCorralesDisp.CurrentCell = Nothing

        lblFecha.Text = MonthCalendar1.SelectionRange.Start.ToShortDateString()
    End Sub

    Private Sub txtKGTotales_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKGTotales.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> Keys.Enter And e.KeyChar <> ChrW(8) Then
            e.Handled = True
        ElseIf Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            If txtKGGrano.Enabled = False And txtKGSilo.Enabled = False And txtKGConcentrado.Enabled = False And txtKGFibra.Enabled = False And txtKGOtros.Enabled = False Then
                If txtOrigen.Text = "Nuefalseo" Then
                    pbxAgregar.Select()
                Else
                    pbxGuardar.Select()
                End If
            ElseIf txtKGGrano.Enabled = False And txtKGSilo.Enabled = False And txtKGConcentrado.Enabled = False And txtKGFibra.Enabled = False Then
                txtKGOtros.Text = txtKGTotales.Text
                lblOtrPorc.Text = Format(100, "#,##0.00")
                txtKGOtros.SelectionLength = Len(txtKGOtros.Text)
                txtKGOtros.Select()
            ElseIf txtKGGrano.Enabled = False And txtKGSilo.Enabled = False And txtKGConcentrado.Enabled = False Then
                txtKGFibra.SelectionLength = Len(txtKGFibra.Text)
                txtKGFibra.Select()

                If txtKGOtros.Enabled = False Then
                    txtKGFibra.Text = txtKGTotales.Text
                    lblFibPorc.Text = Format(100, "#,##0.00")
                End If
            ElseIf txtKGGrano.Enabled = False And txtKGSilo.Enabled = False Then
                txtKGConcentrado.SelectionLength = Len(txtKGConcentrado.Text)
                txtKGConcentrado.Select()

                If txtKGOtros.Enabled = False And txtKGFibra.Enabled = False Then
                    txtKGConcentrado.Text = txtKGTotales.Text
                    lblConcPorc.Text = Format(100, "#,##0.00")
                End If
            ElseIf txtKGGrano.Enabled = False Then
                txtKGSilo.SelectionLength = Len(txtKGSilo.Text)
                txtKGSilo.Select()

                If txtKGOtros.Enabled = False And txtKGFibra.Enabled = False And txtKGSilo.Enabled = False Then
                    txtKGConcentrado.Text = txtKGTotales.Text
                    lblConcPorc.Text = Format(100, "#,##0.00")
                End If
            Else
                txtKGGrano.SelectionLength = Len(txtKGGrano.Text)
                txtKGGrano.Select()

                If txtKGOtros.Enabled = False And txtKGSilo.Enabled = False And txtKGFibra.Enabled = False And txtKGConcentrado.Enabled = False Then
                    txtKGGrano.Text = txtKGTotales.Text
                    lblGrPorc.Text = Format(100, "#,##0.00")
                End If
            End If
            lblTotPorc.Text = Format(100, "#,##0.00")
            lblGrPorc.Text = Format(txtKGGrano.Text / txtKGTotales.Text * 100, "#,##0.00")
            lblSilPorc.Text = Format(lblSilPorc.Text / txtKGTotales.Text * 100, "#,##0.00")
            lblConcPorc.Text = Format(txtKGConcentrado.Text / txtKGTotales.Text * 100, "#,##0.00")
            lblFibPorc.Text = Format(txtKGFibra.Text / txtKGTotales.Text * 100, "#,##0.00")
            lblOtrPorc.Text = Format(txtKGOtros.Text / txtKGTotales.Text * 100, "#,##0.00")
            lblDifPorc.Text = Format(lblTotPorc.Text - lblGrPorc.Text - lblSilPorc.Text - lblConcPorc.Text - lblFibPorc.Text - lblOtrPorc.Text, "#,##0.00")
        End If
    End Sub

    Private Sub txtKGGrano_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKGGrano.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> Keys.Enter And e.KeyChar <> ChrW(8) Then
            e.Handled = True
        ElseIf Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            If txtKGSilo.Enabled = False And txtKGConcentrado.Enabled = False And txtKGFibra.Enabled = False And txtKGOtros.Enabled = False Then
                If txtOrigen.Text = "Nuevo" Then
                    pbxAgregar.Select()
                Else
                    pbxGuardar.Select()
                End If
            ElseIf txtKGConcentrado.Enabled = False And txtKGFibra.Enabled = False And txtKGOtros.Enabled = False Then
                txtKGSilo.SelectionLength = Len(txtKGSilo.Text)
                txtKGSilo.Select()
            ElseIf txtKGFibra.Enabled = False And txtKGOtros.Enabled = False Then
                txtKGSilo.SelectionLength = Len(txtKGSilo.Text)
                txtKGSilo.Select()
            ElseIf txtKGOtros.Enabled = False Then
                txtKGSilo.SelectionLength = Len(txtKGSilo.Text)
                txtKGSilo.Select()
            Else
                txtKGSilo.SelectionLength = Len(txtKGSilo.Text)
                txtKGSilo.Select()
            End If
            lblGrPorc.Text = Format(txtKGGrano.Text / txtKGTotales.Text * 100, "#,##0.00")
            lblDifPorc.Text = Format(lblTotPorc.Text - lblGrPorc.Text - lblSilPorc.Text - lblConcPorc.Text - lblFibPorc.Text - lblOtrPorc.Text, "#,##0.00")
        End If
    End Sub

    Private Sub txtKGSilo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKGSilo.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> Keys.Enter And e.KeyChar <> ChrW(8) Then
            e.Handled = True
        ElseIf Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            If txtKGGrano.Enabled = False And txtKGConcentrado.Enabled = False And txtKGFibra.Enabled = False And txtKGOtros.Enabled = False Then
                If txtOrigen.Text = "Nuevo" Then
                    pbxAgregar.Select()
                Else
                    pbxGuardar.Select()
                End If
            ElseIf txtKGGrano.Enabled = False And txtKGConcentrado.Enabled = False And txtKGFibra.Enabled = False Then
                txtKGOtros.SelectionLength = Len(txtKGOtros.Text)
                txtKGOtros.Select()
            ElseIf txtKGGrano.Enabled = False And txtKGConcentrado.Enabled = False Then
                txtKGFibra.SelectionLength = Len(txtKGFibra.Text)
                txtKGFibra.Select()
            ElseIf txtKGGrano.Enabled = False Then
                txtKGConcentrado.SelectionLength = Len(txtKGConcentrado.Text)
                txtKGConcentrado.Select()
            Else
                txtKGConcentrado.SelectionLength = Len(txtKGConcentrado.Text)
                txtKGConcentrado.Select()
            End If
            lblSilPorc.Text = Format(txtKGSilo.Text / txtKGTotales.Text * 100, "#,##0.00")
            lblDifPorc.Text = Format(lblTotPorc.Text - lblGrPorc.Text - lblSilPorc.Text - lblConcPorc.Text - lblFibPorc.Text - lblOtrPorc.Text, "#,##0.00")
        End If
    End Sub


    Private Sub txtKGConcentrado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKGConcentrado.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> Keys.Enter And e.KeyChar <> ChrW(8) Then
            e.Handled = True
        ElseIf Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            If txtKGFibra.Enabled = False And txtKGOtros.Enabled = False Then
                If txtOrigen.Text = "Nuevo" Then
                    pbxAgregar.Select()
                Else
                    pbxGuardar.Select()
                End If
            ElseIf txtKGFibra.Enabled = False Then
                txtKGOtros.SelectionLength = Len(txtKGOtros.Text)
                txtKGOtros.Select()
            Else
                txtKGFibra.SelectionLength = Len(txtKGFibra.Text)
                txtKGFibra.Select()
            End If
            lblConcPorc.Text = Format(txtKGConcentrado.Text / txtKGTotales.Text * 100, "#,##0.00")
            lblDifPorc.Text = Format(lblTotPorc.Text - lblGrPorc.Text - lblSilPorc.Text - lblConcPorc.Text - lblFibPorc.Text - lblOtrPorc.Text, "#,##0.00")
        End If
    End Sub

    Private Sub txtKGFibra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKGFibra.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> Keys.Enter And e.KeyChar <> ChrW(8) Then
            e.Handled = True
        ElseIf Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            If txtKGOtros.Enabled = False Then
                If txtOrigen.Text = "Nuevo" Then
                    pbxAgregar.Select()
                Else
                    pbxGuardar.Select()
                End If
            Else
                txtKGOtros.SelectionLength = Len(txtKGOtros.Text)
                txtKGOtros.Select()
            End If
            lblFibPorc.Text = Format(txtKGFibra.Text / txtKGTotales.Text * 100, "#,##0.00")
            lblDifPorc.Text = Format(lblTotPorc.Text - lblGrPorc.Text - lblSilPorc.Text - lblConcPorc.Text - lblFibPorc.Text - lblOtrPorc.Text, "#,##0.00")
        End If
    End Sub

    Private Sub txtKGOtros_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKGOtros.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> Keys.Enter And e.KeyChar <> ChrW(8) Then
            e.Handled = True
        ElseIf Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            If txtOrigen.Text = "Nuevo" Then
                pbxAgregar.Select()
            Else
                pbxGuardar.Select()
            End If
            lblOtrPorc.Text = Format(txtKGOtros.Text / txtKGTotales.Text * 100, "#,##0.00")
            lblDifPorc.Text = Format(lblTotPorc.Text - lblGrPorc.Text - lblSilPorc.Text - lblConcPorc.Text - lblFibPorc.Text - lblOtrPorc.Text, "#,##0.00")
        End If
    End Sub

    Private Sub txtKGDif_Validated(sender As Object, e As EventArgs) Handles txtKGTotales.Validated, txtKGGrano.Validated, txtKGSilo.Validated, txtKGConcentrado.Validated, txtKGFibra.Validated, txtKGOtros.Validated
        If txtKGTotales.Text = "" Then
            txtKGTotales.Text = 0
        End If

        If txtKGGrano.Text = "" Then
            txtKGGrano.Text = 0
        End If

        If txtKGSilo.Text = "" Then
            txtKGSilo.Text = 0
        End If

        If txtKGFibra.Text = "" Then
            txtKGFibra.Text = 0
        End If

        If txtKGOtros.Text = "" Then
            txtKGOtros.Text = 0
        End If

        txtKGDif.Text = txtKGTotales.Text - txtKGGrano.Text - txtKGSilo.Text - txtKGConcentrado.Text - txtKGFibra.Text - txtKGOtros.Text
        lblDifPorc.Text = Format(lblTotPorc.Text - lblGrPorc.Text - lblSilPorc.Text - lblConcPorc.Text - lblFibPorc.Text - lblOtrPorc.Text, "#,##0.00")
    End Sub

    Private Sub dgvCorralesSel_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCorralesSel.CellClick
        If dgvCorralesDisp.CurrentRow IsNot Nothing Then
            If dgvCorralesSel.CurrentRow.Cells.Item(2).Value = dgvRacion.CurrentRow.Cells.Item(1).Value Then
                txtKGTotales.Text = dgvCorralesSel.CurrentRow.Cells.Item(3).Value
                txtKGGrano.Text = dgvCorralesSel.CurrentRow.Cells.Item(4).Value
                txtKGSilo.Text = dgvCorralesSel.CurrentRow.Cells.Item(5).Value
                txtKGConcentrado.Text = dgvCorralesSel.CurrentRow.Cells.Item(6).Value
                txtKGFibra.Text = dgvCorralesSel.CurrentRow.Cells.Item(7).Value
                txtKGOtros.Text = dgvCorralesSel.CurrentRow.Cells.Item(8).Value
            End If
        End If
        Dim CostG, CostF, CostC, CostO As Double

        Dim rows As Integer = dgvRacion.Rows.Count - 1

        For j As Integer = rows To 0 Step -1
            If dgvRacion.Rows(j).Cells.Item(1).Value = dgvCorralesSel.CurrentRow.Cells.Item(2).Value Then
                CostG = dgvCorralesSel.CurrentRow.Cells.Item(4).Value * CDbl(dgvRacion.Rows(j).Cells.Item(6).Value)
                CostC = dgvCorralesSel.CurrentRow.Cells.Item(5).Value * CDbl(dgvRacion.Rows(j).Cells.Item(7).Value)
                CostF = dgvCorralesSel.CurrentRow.Cells.Item(6).Value * CDbl(dgvRacion.Rows(j).Cells.Item(8).Value)
                CostO = dgvCorralesSel.CurrentRow.Cells.Item(7).Value * CDbl(dgvRacion.Rows(j).Cells.Item(9).Value)
            End If
        Next

        txtInformacion.Text = "-------- DETALLE ALIMENTACION -------" +
        vbNewLine +
        vbNewLine + "Grano        : " + CStr(dgvCorralesSel.CurrentRow.Cells.Item(4).Value) + " KG  -->  " + CStr(Format(CostG, "$ #,##0")) +
        vbNewLine + "Concent.   : " + CStr(dgvCorralesSel.CurrentRow.Cells.Item(5).Value) + " KG  -->  " + CStr(Format(CostC, "$ #,##0")) +
        vbNewLine + "Fibra         : " + CStr(dgvCorralesSel.CurrentRow.Cells.Item(6).Value) + " KG  -->  " + CStr(Format(CostF, "$ #,##0")) +
        vbNewLine + "Otros         : " + CStr(dgvCorralesSel.CurrentRow.Cells.Item(7).Value) + " KG  -->  " + CStr(Format(CostO, "$ #,##0")) +
        vbNewLine + vbNewLine + "Total         : " + CStr(dgvCorralesSel.CurrentRow.Cells.Item(3).Value) + " KG  -->  " + CStr(Format((CostG + CostC + CostF + CostO), "$ #,##0"))
    End Sub

    Private Sub pbxQuitar_Click(sender As Object, e As EventArgs) Handles pbxQuitar.Click
        If dgvCorralesSel.SelectedRows.Count > 0 Then
            dgvCorralesSel.Rows.Remove(Me.dgvCorralesSel.CurrentRow)

            If dgvCorralesSel.Rows.Count <= 0 Then
                dgvCorralesSel.ColumnHeadersVisible = False
                dgvCorralesSel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            End If
        End If
    End Sub

    Private Sub mtcFiltro_DateSelected(sender As Object, e As DateRangeEventArgs) Handles mtcFiltro.DateSelected
        Dim _Dt As New DataTable
        Dim _Ver As New Mostrar

        lblFechaMod.Text = mtcFiltro.SelectionRange.Start.ToShortDateString()

        If frmLogin.txtTipUs.Text = "Super Usuario" Then
            _Dt = _Ver.consAlimentacionFecha(Format(CDate(lblFechaMod.Text), "yyyy/MM/dd"))
        Else
            _Dt = _Ver.consAlimentacionFechaUS(Format(CDate(lblFechaMod.Text), "yyyy/MM/dd"), frmLogin.txtID.Text)
        End If

        dgvAlimentaciones.DataSource = _Dt
        dgvAlimentaciones.CurrentCell = Nothing
    End Sub

    Private Sub btnLimpiarFiltro_Click(sender As Object, e As EventArgs) Handles btnLimpiarFiltro.Click
        Dim _Dt As New DataTable
        Dim _Ver As New Mostrar

        If frmLogin.txtTipUs.Text = "Super Usuario" Then
            _Dt = _Ver.consAlimentacion
        Else
            _Dt = _Ver.consAlimentacionUS(frmLogin.txtID.Text)
        End If

        dgvAlimentaciones.DataSource = _Dt
        dgvAlimentaciones.Sort(dgvAlimentaciones.Columns("Fecha"), System.ComponentModel.ListSortDirection.Descending)

        mtcFiltro.SetDate(Nothing)
    End Sub

    Private Sub dgvAlimentaciones_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAlimentaciones.CellClick
        txtInformacionMod.Text = "------- DETALLE ALIMENTACION ---------" +
            vbNewLine +
            vbNewLine + "Racion: " + CStr(dgvAlimentaciones.CurrentRow.Cells.Item(19).Value) +
            vbNewLine +
            vbNewLine + "Grano        : " + CStr(dgvAlimentaciones.CurrentRow.Cells.Item(3).Value) + " KG  -->  " + CStr(Format(dgvAlimentaciones.CurrentRow.Cells.Item(11).Value, "$ #,##0")) +
            vbNewLine + "Concent.   : " + CStr(dgvAlimentaciones.CurrentRow.Cells.Item(4).Value) + " KG  -->  " + CStr(Format(dgvAlimentaciones.CurrentRow.Cells.Item(12).Value, "$ #,##0")) +
            vbNewLine + "Fibra         : " + CStr(dgvAlimentaciones.CurrentRow.Cells.Item(5).Value) + " KG  -->  " + CStr(Format(dgvAlimentaciones.CurrentRow.Cells.Item(13).Value, "$ #,##0")) +
            vbNewLine + "Otros         : " + CStr(dgvAlimentaciones.CurrentRow.Cells.Item(6).Value) + " KG  -->  " + CStr(Format(dgvAlimentaciones.CurrentRow.Cells.Item(14).Value, "$ #,##0")) +
            vbNewLine + vbNewLine + "Total         : " + CStr(dgvAlimentaciones.CurrentRow.Cells.Item(1).Value) + " KG  -->  " + CStr(Format(dgvAlimentaciones.CurrentRow.Cells.Item(15).Value, "$ #,##0"))

        txtIDRac.Text = dgvAlimentaciones.CurrentRow.Cells.Item(20).Value
        txtIDCrr.Text = dgvAlimentaciones.CurrentRow.Cells.Item(17).Value
    End Sub


    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If dgvAlimentaciones.CurrentCell IsNot Nothing Then
            Dim Fecha As Date = dgvAlimentaciones.CurrentRow.Cells.Item(0).Value
            Dim _Dt, _Dt2, _Dt3, _Dt4 As New DataTable
            Dim _Ver, _Ver2, _Ver3, _Ver4 As New Mostrar

            FechaStock(Fecha)

            If frmLogin.txtTipUs.Text = "Super Usuario" Then
                _Dt = _Ver.verRaciones
                _Dt2 = _Ver2.verCorrales
            Else
                _Dt = _Ver.verRacionesUs(frmLogin.txtID.Text)
                _Dt2 = _Ver2.verCorralesUs(frmLogin.txtID.Text)
            End If

            gbxNuevo.Visible = True
            gbxModificar.Visible = False

            dgvRacion.RowTemplate.Height = 25
            dgvRacion.DataSource = _Dt
            dgvRacion.Columns("idRaciones").Visible = False
            dgvRacion.Columns("Grano").Visible = False
            dgvRacion.Columns("Concentrado").Visible = False
            dgvRacion.Columns("Fibra").Visible = False
            dgvRacion.Columns("Otros").Visible = False
            dgvRacion.Columns("CostoGrano").Visible = False
            dgvRacion.Columns("CostoConcentrado").Visible = False
            dgvRacion.Columns("CostoFibra").Visible = False
            dgvRacion.Columns("CostoOtros").Visible = False
            dgvRacion.Columns("USUARIOS_idUsuario").Visible = False

            _Dt3 = _Ver3.verStkDia(Fecha, CInt(frmLogin.txtID.Text))

            If _Dt3.Rows.Count <= 0 Then
                Fecha = FechaStock(Fecha)

                MsgBox("No se a encontrado un registro de stock en la fecha " + dgvAlimentaciones.CurrentRow.Cells.Item(0).Value + " si se realizas una modificacion sobre este registro se le asignaran al stock mas cercano encontrado el " + Fecha, vbInformation, "Servico de Alertas")
            End If

            Dim rows As Integer = _Dt2.Rows.Count - 1

            For j As Integer = rows To 0 Step -1
                _Dt4 = _Ver4.verStkCorralFec(CInt(frmLogin.txtID.Text), _Dt2.Rows(j).Item("idCorrales"), Fecha)

                If _Dt4.Rows.Count <= 0 Then
                    _Dt2.Rows.Remove(_Dt2.Rows(j))
                End If
            Next

            dgvCorralesDisp.RowTemplate.Height = 25
            dgvCorralesDisp.DataSource = _Dt2
            dgvCorralesDisp.Columns("idCorrales").Visible = False
            dgvCorralesDisp.Columns("Superficie").Visible = False
            dgvCorralesDisp.Columns("CabezasTotales").Visible = False
            dgvCorralesDisp.Columns("CAMPO_idCampo").Visible = False
            dgvCorralesDisp.Columns("USUARIOS_idUsuario").Visible = False

            If dgvCorralesDisp.Rows.Count <= 0 Then
                MsgBox("Error: No se a encontrado ningun corral con stock disponible... !", vbExclamation, "Servico de Alertas")
                Cancelar()
            End If

            dgvCorralesDisp.CurrentCell = Nothing
            dgvRacion.CurrentCell = Nothing

            lblFecha.Text = dgvAlimentaciones.CurrentRow.Cells.Item(0).Value
            MonthCalendar1.SetDate(dgvAlimentaciones.CurrentRow.Cells.Item(0).Value)

            dgvCorralesSel.Visible = False
            pbxAgregar.Visible = False
            pbxQuitar.Visible = False
            PictureBox3.Visible = False

            gbxKGAlimentacion.Enabled = True

            txtKGTotales.Text = Format(dgvAlimentaciones.CurrentRow.Cells.Item(1).Value, "#,##0")
            txtKGGrano.Text = Format(dgvAlimentaciones.CurrentRow.Cells.Item(3).Value, "#,##0")
            txtKGConcentrado.Text = Format(dgvAlimentaciones.CurrentRow.Cells.Item(4).Value, "#,##0")
            txtKGFibra.Text = Format(dgvAlimentaciones.CurrentRow.Cells.Item(5).Value, "#,##0")
            txtKGOtros.Text = Format(dgvAlimentaciones.CurrentRow.Cells.Item(6).Value, "#,##0")
            txtKGDif.Text = Format(0, "#,##0")
            txtIDModAlim.Text = dgvAlimentaciones.CurrentRow.Cells.Item(21).Value

            If dgvAlimentaciones.CurrentRow.Cells.Item(3).Value = 0 Then
                txtKGGrano.Enabled = False
            Else
                txtKGGrano.Enabled = True
            End If

            If dgvAlimentaciones.CurrentRow.Cells.Item(4).Value = 0 Then
                txtKGConcentrado.Enabled = False
            Else
                txtKGConcentrado.Enabled = True
            End If

            If dgvAlimentaciones.CurrentRow.Cells.Item(5).Value = 0 Then
                txtKGFibra.Enabled = False
            Else
                txtKGFibra.Enabled = True
            End If

            If dgvAlimentaciones.CurrentRow.Cells.Item(6).Value = 0 Then
                txtKGOtros.Enabled = False
            Else
                txtKGOtros.Enabled = True
            End If

            txtKGTotales.SelectionLength = Len(txtKGTotales.Text)
            txtKGTotales.Select()

            Dim i As Integer = 0

            For Each _Dr As DataRow In _Dt2.Rows
                If _Dr("idCorrales") = dgvAlimentaciones.CurrentRow.Cells.Item(17).Value Then
                    dgvCorralesDisp.Rows(i).Selected = True
                End If

                i = i + 1
            Next

            i = 0

            For Each _Dr As DataRow In _Dt.Rows
                If _Dr("idRaciones") = dgvAlimentaciones.CurrentRow.Cells.Item(20).Value Then
                    dgvRacion.Rows(i).Selected = True
                End If

                i = i + 1
            Next
        End If
    End Sub
End Class