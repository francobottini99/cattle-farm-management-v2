Imports MySql.Data.MySqlClient

Public Class frmAltasTropa
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

    Private Sub pbxSalir_Click(sender As Object, e As EventArgs) Handles pbxSalir.Click
        Me.Close()
    End Sub

    Private Sub frmAltaProductor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ctlNuevo As Control = DirectCast(pbxNuevo, Control)
        Dim keyprNuevo = New KeyPressEventHandler(AddressOf btnNuevo)

        Dim ctlGuardar As Control = DirectCast(pbxGuardar, Control)
        Dim keyprGuardar = New KeyPressEventHandler(AddressOf btnGuardar)

        AddHandler ctlNuevo.KeyPress, keyprNuevo
        AddHandler ctlGuardar.KeyPress, keyprGuardar

        Me.Text = "Si.Tra.Bo. - Sistema de Trazabilidad Bovina" & " - USUARIO: " & frmLogin.txtNom.Text & " " & frmLogin.txtAp.Text & " -"

        CargarDGVTropas()

        pbxNuevo.Select()
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

        If frmLogin.txtTipUs.Text = "Super Usuario" Then
            _Dt = _Ver.verCategorias
        Else
            _Dt = _Ver.verCategoriasUs(frmLogin.txtID.Text)
        End If

        cbxCategorias.Items.Clear()
        For Each _Dr As DataRow In _Dt.Rows
            cbxCategorias.Items.Add(_Dr("Categoria"))
        Next
    End Sub

    Private Sub CargarDGVS()
        Dim _Dt, _Dt2, _Dt3, _Dt4 As New DataTable
        Dim _Ver, _Ver2, _Ver3, _Ver4 As New Mostrar

        If frmLogin.txtTipUs.Text = "Super Usuario" Then
            _Dt = _Ver.verProductor
            _Dt2 = _Ver2.verProveedor
            _Dt3 = _Ver3.verCampos
            _Dt4 = _Ver4.verCorrales
        Else
            _Dt = _Ver.verProductorUs(frmLogin.txtID.Text)
            _Dt2 = _Ver2.verProveedorUs(frmLogin.txtID.Text)
            _Dt3 = _Ver3.verCamposUs(frmLogin.txtID.Text)
            _Dt4 = _Ver4.verCorralesUs(frmLogin.txtID.Text)
        End If
        dgvProductor.RowTemplate.Height = 25
        dgvProductor.DataSource = _Dt
        dgvProductor.ClearSelection()
        dgvProductor.Columns("idProductor").Visible = False
        dgvProductor.Columns("Direccion").Visible = False
        dgvProductor.Columns("Localidad").Visible = False
        dgvProductor.Columns("CP").Visible = False
        dgvProductor.Columns("CUIT").Visible = False
        dgvProductor.Columns("USUARIOS_idUsuario").Visible = False

        dgvProveedor.RowTemplate.Height = 25
        dgvProveedor.DataSource = _Dt2
        dgvProveedor.ClearSelection()
        dgvProveedor.Columns("idProveedor").Visible = False
        dgvProveedor.Columns("Direccion").Visible = False
        dgvProveedor.Columns("Localidad").Visible = False
        dgvProveedor.Columns("Provincia").Visible = False
        dgvProveedor.Columns("CP").Visible = False
        dgvProveedor.Columns("CUIT").Visible = False
        dgvProveedor.Columns("TE").Visible = False
        dgvProveedor.Columns("Mail").Visible = False
        dgvProveedor.Columns("USUARIOS_idUsuario").Visible = False

        dgvCampo.RowTemplate.Height = 25
        dgvCampo.DataSource = _Dt3
        dgvCampo.ClearSelection()
        dgvCampo.Columns("idCampo").Visible = False
        dgvCampo.Columns("Propietario").Visible = False
        dgvCampo.Columns("Localidad").Visible = False
        dgvCampo.Columns("Provincia").Visible = False
        dgvCampo.Columns("Superficie").Visible = False
        dgvCampo.Columns("USUARIOS_idUsuario").Visible = False

        dgvCorral.RowTemplate.Height = 25
        dgvCorral.DataSource = _Dt4
        dgvCorral.ClearSelection()
        dgvCorral.Columns("idCorrales").Visible = False
        dgvCorral.Columns("Superficie").Visible = False
        dgvCorral.Columns("CabezasTotales").Visible = False
        dgvCorral.Columns("CAMPO_idCampo").Visible = False
        dgvCorral.Columns("USUARIOS_idUsuario").Visible = False
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

    Private Sub LimpiarTXT()
        txtNombre.Text = ""
        txtProcedencia.Text = ""
        txtFechaIng.Text = ""
        txtCab.Text = ""
        txtKGCab.Text = ""
        txtKGTotal.Text = ""
        txtObservaciones.Text = ""
        txtIDCampo.Text = ""
        txtIDCorral.Text = ""
        txtIDProductor.Text = ""
        txtIDProveedor.Text = ""
        cbxCategorias.Text = ""
        txtCantidad.Text = ""
    End Sub

    Private Sub pbxNuevo_Click(sender As Object, e As EventArgs) Handles pbxNuevo.Click
        Activar()

        lblMsg.Text = "TROPA | NUEVO"

        pbxNuevo.BackgroundImage = SITRABO.My.Resources.btnNuevoSi

        LimpiarTXT()

        txtOrigen.Text = "Nuevo"

        CargarDGVS()

        VaciarCategorias()

        dgvTropas.CurrentCell = Nothing
    End Sub

    Private Sub Activar()
        gbxDatos1.Enabled = True

        pbxNuevo.Enabled = False
        pbxGuardar.Enabled = True
        pbxCancelar.Enabled = True
        pbxModificar.Enabled = False
        pbxSalir.Enabled = False

        dgvTropas.Enabled = False

        btnSiguiente.Enabled = False
        btnSiguiente2.Enabled = False
    End Sub

    Private Sub VaciarCategorias()
        Dim rows As Integer = dgvCategorias.Rows.Count - 1

        If dgvCategorias.Rows.Count > 0 Then
            For j As Integer = rows To 0 Step -1
                dgvCategorias.Rows.Remove(dgvCategorias.Rows(j))
            Next
        End If
    End Sub

    Private Sub Cancelar()
        gbxDatos1.Enabled = False

        lblMsg.Text = "TROPA"

        txtOrigen.Text = ""

        pbxNuevo.BackgroundImage = SITRABO.My.Resources.btnNuevoNo
        pbxModificar.BackgroundImage = SITRABO.My.Resources.btnModificarNo

        pbxNuevo.Enabled = True
        pbxGuardar.Enabled = False
        pbxCancelar.Enabled = False
        pbxModificar.Enabled = True
        pbxSalir.Enabled = True

        LimpiarTXT()

        VaciarCategorias()

        gbxDatos1.Visible = True
        gbxDatos2.Visible = False
        gbxDatos3.Visible = False

        dgvProductor.DataSource = Nothing
        dgvCampo.DataSource = Nothing
        dgvProveedor.DataSource = Nothing
        dgvCorral.DataSource = Nothing

        dgvTropas.CurrentCell = Nothing
        dgvTropas.Enabled = True
    End Sub


    Private Sub pbxGuardar_Click(sender As Object, e As EventArgs) Handles pbxGuardar.Click
        Dim G As New GrabaDatos
        Dim resP As DialogResult
        Dim _Ver, _VerM, _Ver2, _Ver3, _Ver4, _Ver5 As New Mostrar
        Dim _Dt, _DtM, _Dt2, _Dt3, _Dt4, _Dt5 As New DataTable
        Dim _Row As DataRow
        Dim _Stk As New Stock
        Dim ulTid As Integer
        Dim Fing As Date = Date.Now.Date

        Try
            If txtNombre.Text = "" Then
                MsgBox("Error: El campo Nombre Tropa es obligatorio... !", vbExclamation, "Servico de Alertas")
                txtNombre.Select()
                gbxDatos1.Visible = False
                gbxDatos2.Visible = True
                gbxDatos3.Visible = False
            Else
                If txtProcedencia.Text = "" Then
                    MsgBox("Error: El campo Procedencia es obligatorio... !", vbExclamation, "Servico de Alertas")
                    txtProcedencia.Select()
                    gbxDatos1.Visible = False
                    gbxDatos2.Visible = True
                    gbxDatos3.Visible = False
                Else
                    If txtFechaIng.Text = "" Then
                        MsgBox("Error: El campo Fecha Ingreso es obligatorio... !", vbExclamation, "Servico de Alertas")
                        txtFechaIng.Select()
                        gbxDatos1.Visible = False
                        gbxDatos2.Visible = True
                        gbxDatos3.Visible = False
                    Else
                        Dim Fecha As Date

                        _Dt = _Ver.verStock()

                        If _Dt.Rows.Count < 1 Then
                            Fecha = Format(CDate("01/01/1777"), "dd/MM/yyyy")
                        Else
                            Fecha = _Dt.Rows(_Dt.Rows.Count - 1).Item(1)
                        End If

                        If Format(CDate(txtFechaIng.Text), "dd/MM/yyyy") < Fecha Then
                            MsgBox("No puedes realizar un movimiento en un dia anterior al ultimo registro de stock... !", vbInformation, "Servico de Alertas")
                            txtFechaIng.Select()
                            gbxDatos1.Visible = False
                            gbxDatos2.Visible = True
                            gbxDatos3.Visible = False
                        Else
                            If txtCab.Text = "" Then
                                MsgBox("Error: El campo Cabezas es obligatorio... !", vbExclamation, "Servico de Alertas")
                                txtCab.Select()
                                gbxDatos1.Visible = False
                                gbxDatos2.Visible = True
                                gbxDatos3.Visible = False
                            Else
                                If txtKGCab.Text = "" Then
                                    MsgBox("Error: El campo Peso / Cab Ingreso es obligatorio... !", vbExclamation, "Servico de Alertas")
                                    txtKGCab.Select()
                                    gbxDatos1.Visible = False
                                    gbxDatos2.Visible = True
                                    gbxDatos3.Visible = False
                                Else
                                    Dim Cant As Integer = CInt(txtCab.Text)

                                    For i As Integer = 0 To dgvCategorias.Rows.Count - 1
                                        dgvCategorias.CurrentCell = dgvCategorias.Rows(i).Cells(1)
                                        Cant = Cant - CInt(dgvCategorias.Item("Cantidad", dgvCategorias.CurrentRow.Index).Value())
                                    Next

                                    If Cant > 0 Then
                                        MsgBox("Error: Quedan cabezan sin categoria... !", vbExclamation, "Servico de Alertas")
                                        cbxCategorias.Select()
                                        gbxDatos1.Visible = False
                                        gbxDatos2.Visible = False
                                        gbxDatos3.Visible = True
                                    Else
                                        If txtObservaciones.Text = "" Then
                                            txtObservaciones.Text = "-"
                                        End If

                                        resP = MessageBox.Show("Grabar Alta de Tropa ?", "Servico de Alertas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

                                        If resP = Windows.Forms.DialogResult.OK Then
                                            Fing = CDate(txtFechaIng.Text)
                                            Dim Porc, Aum As Integer

                                            If txtOrigen.Text = "Nuevo" Then
                                                frmGuardandoAlta.Show()

                                                frmGuardandoAlta.pgbGuardando.Maximum = CInt(txtCab.Text) + 4
                                                Aum = 100 / (CInt(txtCab.Text) + 3)
                                                Porc = 0
                                                frmGuardandoAlta.pgbGuardando.Increment(1)
                                                frmGuardandoAlta.lblProgreso.Text = 0 & "%"

                                                frmGuardandoAlta.Refresh()

                                                G.Grabar("Tropa", "NoImagen", "feedlot.insTropa", txtNombre.Text, txtProcedencia.Text, _
                                                    Format(CDate(txtFechaIng.Text), "yyyy/MM/dd"), CInt(txtCab.Text), 0, 0, CInt(txtCab.Text), CDbl(txtKGCab.Text), _
                                                     CInt(txtKGTotal.Text), txtObservaciones.Text, CInt(txtIDProductor.Text), CInt(txtIDCampo.Text), CInt(txtIDProveedor.Text), CInt(frmLogin.txtID.Text))

                                                frmGuardandoAlta.pgbGuardando.Increment(1)
                                                Porc = Porc + Aum
                                                frmGuardandoAlta.lblProgreso.Text = Porc & "%"

                                                frmGuardandoAlta.Refresh()

                                                _DtM = _VerM.verMaxIdTropa()
                                                _Row = _DtM.Rows(_DtM.Rows.Count - 1)

                                                If _Row("UltimoId").ToString = "" Then
                                                    ulTid = 0
                                                Else
                                                    ulTid = _Row("UltimoId")
                                                End If

                                                G.Grabar("tropa_bloqueo_mod", "NoImagen", "feedlot.insEstadoMod", "SI", ulTid)

                                                frmGuardandoAlta.pgbGuardando.Increment(1)
                                                Porc = Porc + Aum
                                                frmGuardandoAlta.lblProgreso.Text = Porc & "%"

                                                frmGuardandoAlta.Refresh()

                                                For i As Integer = 0 To dgvCategorias.Rows.Count - 1
                                                    For j As Integer = 1 To dgvCategorias.Rows(i).Cells(1).Value()
                                                        G.Grabar("Detalle_Tropa", "NoImagen", "feedlot.insDetalleTropa", "***", "-",
                                                              "Engorde", ulTid, CInt(dgvCategorias.Rows(i).Cells(2).Value()), CInt(txtIDCorral.Text), CInt(frmLogin.txtID.Text),
                                                              "00 00 00 00 00 00 00")

                                                        frmGuardandoAlta.pgbGuardando.Increment(1)
                                                        Porc = Porc + Aum
                                                        frmGuardandoAlta.lblProgreso.Text = Porc & "%"

                                                        frmGuardandoAlta.Refresh()
                                                    Next
                                                Next

                                                G.Grabar("compras", "NoImagen", "feedlot.insIngreso", Format(CDate(txtFechaIng.Text), "yyyy/MM/dd"), 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "-", _
                                                         ulTid, CInt(txtIDProveedor.Text), CInt(txtIDProductor.Text), CInt(frmLogin.txtID.Text))

                                                frmGuardandoAlta.pgbGuardando.Increment(1)
                                                Porc = Porc + Aum
                                                frmGuardandoAlta.lblProgreso.Text = Porc & "%"

                                                frmGuardandoAlta.Refresh()

                                                Threading.Thread.Sleep(500)
                                            Else
                                                frmGuardandoAlta.Show()

                                                frmGuardandoAlta.pgbGuardando.Maximum = CInt(txtCab.Text) + 6
                                                Aum = 100 / (CInt(txtCab.Text) + 5)
                                                Porc = 0
                                                frmGuardandoAlta.pgbGuardando.Increment(1)
                                                frmGuardandoAlta.lblProgreso.Text = 0 & "%"

                                                frmGuardandoAlta.Refresh()

                                                G.Grabar("Stock", "NoImagen", "feedlot.modBorrarStock", Format(CDate(Fing), "yyyy/MM/dd"), frmLogin.txtID.Text)

                                                frmGuardandoAlta.pgbGuardando.Increment(1)
                                                Porc = Porc + Aum
                                                frmGuardandoAlta.lblProgreso.Text = Porc & "%"

                                                frmGuardandoAlta.Refresh()

                                                G.Grabar("Detalle_Tropa", "NoImagen", "feedlot.modDetalleTropa", CInt(txtIDTropa.Text))

                                                frmGuardandoAlta.pgbGuardando.Increment(1)
                                                Porc = Porc + Aum
                                                frmGuardandoAlta.lblProgreso.Text = Porc & "%"

                                                frmGuardandoAlta.Refresh()

                                                G.Grabar("compras", "NoImagen", "feedlot.modBorrarIngreso", CInt(txtIDTropa.Text))

                                                frmGuardandoAlta.pgbGuardando.Increment(1)
                                                Porc = Porc + Aum
                                                frmGuardandoAlta.lblProgreso.Text = Porc & "%"

                                                frmGuardandoAlta.Refresh()

                                                G.Grabar("Tropa", "NoImagen", "feedlot.modTropa", CInt(txtIDTropa.Text), txtNombre.Text, txtProcedencia.Text, _
                                                    Format(CDate(txtFechaIng.Text), "yyyy/MM/dd"), CInt(txtCab.Text), 0, 0, CInt(txtCab.Text), CDbl(txtKGCab.Text), _
                                                    CInt(txtKGTotal.Text), txtObservaciones.Text, CInt(txtIDProductor.Text), CInt(txtIDCampo.Text), CInt(txtIDProveedor.Text), CInt(frmLogin.txtID.Text))

                                                frmGuardandoAlta.pgbGuardando.Increment(1)
                                                Porc = Porc + Aum
                                                frmGuardandoAlta.lblProgreso.Text = Porc & "%"

                                                frmGuardandoAlta.Refresh()

                                                For i As Integer = 0 To dgvCategorias.Rows.Count - 1
                                                    For j As Integer = 1 To dgvCategorias.Rows(i).Cells(1).Value()
                                                        G.Grabar("Detalle_Tropa", "NoImagen", "feedlot.insDetalleTropa", "***", "-", _
                                                              "Engorde", CInt(txtIDTropa.Text), CInt(dgvCategorias.Rows(i).Cells(2).Value()), CInt(txtIDCorral.Text), CInt(frmLogin.txtID.Text))

                                                        frmGuardandoAlta.pgbGuardando.Increment(1)
                                                        Porc = Porc + Aum
                                                        frmGuardandoAlta.lblProgreso.Text = Porc & "%"

                                                        frmGuardandoAlta.Refresh()
                                                    Next
                                                Next

                                                G.Grabar("compras", "NoImagen", "feedlot.insIngreso", Format(CDate(txtFechaIng.Text), "yyyy/MM/dd"), 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "-", _
                                                    CInt(txtIDTropa.Text), CInt(txtIDProveedor.Text), CInt(txtIDProductor.Text), CInt(frmLogin.txtID.Text))

                                                frmGuardandoAlta.pgbGuardando.Increment(1)
                                                Porc = Porc + Aum
                                                frmGuardandoAlta.lblProgreso.Text = Porc & "%"

                                                frmGuardandoAlta.Refresh()

                                                Threading.Thread.Sleep(500)
                                            End If

                                            _Stk.ManejoStk(Fing)

                                            frmGuardandoAlta.pgbGuardando.Increment(1)
                                            frmGuardandoAlta.lblProgreso.Text = 100 & "%"

                                            frmGuardandoAlta.Refresh()
                                            frmGuardandoAlta.pgbGuardando.Refresh()

                                            Threading.Thread.Sleep(500)

                                            frmGuardandoAlta.pgbGuardando.Visible = False
                                            frmGuardandoAlta.lblProgreso.Visible = False
                                            frmGuardandoAlta.lblCabProgreso.Visible = False
                                            frmGuardandoAlta.lblTitulo.Visible = False

                                            frmGuardandoAlta.lblListo.Visible = True

                                            frmGuardandoAlta.Refresh()

                                            Threading.Thread.Sleep(1000)

                                            frmGuardandoAlta.Close()

                                            frmGuardandoAlta.pgbGuardando.Visible = True
                                            frmGuardandoAlta.lblProgreso.Visible = True
                                            frmGuardandoAlta.lblCabProgreso.Visible = True
                                            frmGuardandoAlta.lblTitulo.Visible = True

                                            frmGuardandoAlta.lblListo.Visible = False

                                            CargarDGVTropas()

                                            Cancelar()
                                        End If
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

    Private Sub pbxCancelar_Click(sender As Object, e As EventArgs) Handles pbxCancelar.Click
        Cancelar()
    End Sub

    Private Sub dgvTropas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTropas.CellClick
        If gbxDatos1.Enabled = False Then
            Dim _Dt, _Dt2, _Dt3, _Dt4, _Dt5, _Dt6, _DT7 As New DataTable
            Dim _Ver, _Ver2, _Ver3, _Ver4, _Ver5, _Ver6, _Ver7 As New Mostrar

            If frmLogin.txtTipUs.Text = "Super Usuario" Then
                _Dt = _Ver.verProductor
                _Dt2 = _Ver2.verProveedor
                _Dt3 = _Ver3.verCampos
                _Dt6 = _Ver6.verCorrales
            Else
                _Dt = _Ver.verProductorUs(frmLogin.txtID.Text)
                _Dt2 = _Ver2.verProveedorUs(frmLogin.txtID.Text)
                _Dt3 = _Ver3.verCamposUs(frmLogin.txtID.Text)
                _Dt6 = _Ver6.verCorralesUs(frmLogin.txtID.Text)
            End If
            dgvProductor.RowTemplate.Height = 25
            dgvProductor.DataSource = _Dt
            dgvProductor.ClearSelection()
            dgvProductor.Columns("idProductor").Visible = False
            dgvProductor.Columns("Direccion").Visible = False
            dgvProductor.Columns("Localidad").Visible = False
            dgvProductor.Columns("CP").Visible = False
            dgvProductor.Columns("CUIT").Visible = False
            dgvProductor.Columns("USUARIOS_idUsuario").Visible = False

            dgvProveedor.RowTemplate.Height = 25
            dgvProveedor.DataSource = _Dt2
            dgvProveedor.ClearSelection()
            dgvProveedor.Columns("idProveedor").Visible = False
            dgvProveedor.Columns("Direccion").Visible = False
            dgvProveedor.Columns("Localidad").Visible = False
            dgvProveedor.Columns("Provincia").Visible = False
            dgvProveedor.Columns("CP").Visible = False
            dgvProveedor.Columns("CUIT").Visible = False
            dgvProveedor.Columns("TE").Visible = False
            dgvProveedor.Columns("Mail").Visible = False
            dgvProveedor.Columns("USUARIOS_idUsuario").Visible = False

            dgvCampo.RowTemplate.Height = 25
            dgvCampo.DataSource = _Dt3
            dgvCampo.ClearSelection()
            dgvCampo.Columns("idCampo").Visible = False
            dgvCampo.Columns("Propietario").Visible = False
            dgvCampo.Columns("Localidad").Visible = False
            dgvCampo.Columns("Provincia").Visible = False
            dgvCampo.Columns("Superficie").Visible = False
            dgvCampo.Columns("USUARIOS_idUsuario").Visible = False

            dgvCorral.RowTemplate.Height = 25
            dgvCorral.DataSource = _Dt6
            dgvCorral.ClearSelection()
            dgvCorral.Columns("idCorrales").Visible = False
            dgvCorral.Columns("Superficie").Visible = False
            dgvCorral.Columns("CabezasTotales").Visible = False
            dgvCorral.Columns("CAMPO_idCampo").Visible = False
            dgvCorral.Columns("USUARIOS_idUsuario").Visible = False

            _DT7 = _Ver7.verDetalleTropaCorralesID(dgvTropas.CurrentRow.Cells.Item(0).Value)

            For Each _Dr As DataRow In _DT7.Rows
                txtIDCorral.Text = _Dr("CORRALES_idCorrales")
            Next

            txtIDTropa.Text = dgvTropas.CurrentRow.Cells.Item(0).Value
            txtIDProductor.Text = dgvTropas.CurrentRow.Cells.Item(11).Value
            txtIDCampo.Text = dgvTropas.CurrentRow.Cells.Item(12).Value
            txtIDProveedor.Text = dgvTropas.CurrentRow.Cells.Item(13).Value
            txtNombre.Text = dgvTropas.CurrentRow.Cells.Item(1).Value
            txtProcedencia.Text = dgvTropas.CurrentRow.Cells.Item(2).Value
            txtFechaIng.Text = dgvTropas.CurrentRow.Cells.Item(3).Value
            txtCab.Text = dgvTropas.CurrentRow.Cells.Item(4).Value
            txtKGCab.Text = dgvTropas.CurrentRow.Cells.Item(8).Value
            txtKGTotal.Text = dgvTropas.CurrentRow.Cells.Item(9).Value
            txtObservaciones.Text = dgvTropas.CurrentRow.Cells.Item(10).Value

            Dim i As Integer = 0

            For Each _Dr As DataRow In _Dt.Rows
                If _Dr("idProductor") = txtIDProductor.Text Then
                    dgvProductor.Rows(i).Selected = True
                End If

                i = i + 1
            Next

            i = 0

            For Each _Dr As DataRow In _Dt2.Rows
                If _Dr("idProveedor") = txtIDProveedor.Text Then
                    dgvProveedor.Rows(i).Selected = True
                End If

                i = i + 1
            Next

            i = 0

            For Each _Dr As DataRow In _Dt3.Rows
                If _Dr("idCampo") = txtIDCampo.Text Then
                    dgvCampo.Rows(i).Selected = True
                End If

                i = i + 1
            Next

            i = 0

            For Each _Dr As DataRow In _Dt6.Rows
                If _Dr("idCorrales") = txtIDCorral.Text Then
                    dgvCorral.Rows(i).Selected = True
                End If

                i = i + 1
            Next

            Dim btn As New DataGridViewButtonColumn()
            Dim An As Integer = 0

            dgvCategorias.ColumnCount = 3
            dgvCategorias.RowTemplate.Height = 30
            dgvCategorias.Columns(0).Name = "Categoria"
            dgvCategorias.Columns(1).Name = "Cantidad"
            dgvCategorias.Columns(2).Name = "ID"
            dgvCategorias.Columns(2).Visible = False

            dgvCategorias.Columns.Add(btn)
            btn.Text = "X"
            btn.UseColumnTextForButtonValue = True

            Dim rows As Integer = dgvCategorias.Rows.Count - 1

            If dgvCategorias.Rows.Count > 0 Then
                For j As Integer = rows To 0 Step -1
                    dgvCategorias.Rows.Remove(dgvCategorias.Rows(j))
                Next
            End If

            _Dt4 = _Ver4.verDetalleTropa
            _Dt5 = _Ver5.verCategorias
            For Each _Dr As DataRow In _Dt5.Rows
                For Each _Dr2 As DataRow In _Dt4.Rows
                    If _Dr2("TROPA_idTropa") = txtIDTropa.Text Then
                        If _Dr("idCategorias") = _Dr2("CATEGORIAS_idCategorias") Then
                            An = An + 1
                        End If
                    End If
                Next
                If An <> 0 Then
                    dgvCategorias.Rows.Add(_Dr("Categoria"), An, _Dr("idCategorias"))
                    An = 0
                End If
            Next
        End If
    End Sub

    Private Sub pbxModificar_Click(sender As Object, e As EventArgs) Handles pbxModificar.Click
        Dim _Dt As New DataTable
        Dim _Ver As New Mostrar
        Dim _Row As DataRow

        If dgvProductor.DataSource IsNot Nothing Then
            If dgvTropas.CurrentRow.Cells.Item(14).Value = frmLogin.txtID.Text Then
                _Dt = _Ver.verEstadoModTropa(dgvTropas.CurrentRow.Cells.Item(0).Value)
                _Row = _Dt.Rows(_Dt.Rows.Count - 1)

                If _Row("HabilitaMod") = "SI" Then
                    Activar()

                    btnSiguiente.Enabled = True
                    btnSiguiente2.Enabled = True

                    lblMsg.Text = "TROPA | MODIFICAR"

                    pbxModificar.BackgroundImage = SITRABO.My.Resources.btnModificarSi

                    txtOrigen.Text = "Modificar"

                    txtFechaIng.Select()

                    dgvTropas.Enabled = False
                Else
                    MsgBox("La tropa seleccionada ya contiene movimientos asentados, por lo tanto no puede ser modificada", vbExclamation, "Servico de Alertas")
                End If
            Else
                MsgBox("No puedes modificar una tropa creada por otro usuario", vbExclamation, "Servico de Alertas")
            End If
        Else
            MsgBox("Primero seleccione una tropa de la lista", vbExclamation, "Servico de Alertas")
        End If
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        gbxDatos1.Visible = False
        gbxDatos2.Visible = True
        gbxDatos3.Visible = False

        txtNombre.SelectionLength = Len(txtNombre.Text)
        txtNombre.Select()
    End Sub

    Private Sub txtVolver2_Click(sender As Object, e As EventArgs) Handles txtVolver2.Click
        gbxDatos2.Visible = False
        gbxDatos1.Visible = True
        gbxDatos3.Visible = False
    End Sub

    Private Sub dgvCorral_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCorral.CellClick
        txtIDCorral.Text = dgvCorral.CurrentRow.Cells.Item(0).Value

        If dgvProductor.CurrentRow IsNot Nothing And dgvProveedor.CurrentRow IsNot Nothing And dgvCampo.CurrentRow IsNot Nothing And dgvCorral.CurrentRow IsNot Nothing Then
            btnSiguiente.Enabled = True
        End If
    End Sub
    Private Sub dgvProductor_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProductor.CellClick
        txtIDProductor.Text = dgvProductor.CurrentRow.Cells.Item(0).Value

        If dgvProductor.CurrentRow IsNot Nothing And dgvProveedor.CurrentRow IsNot Nothing And dgvCampo.CurrentRow IsNot Nothing And dgvCorral.CurrentRow IsNot Nothing Then
            btnSiguiente.Enabled = True
        End If
    End Sub
    Private Sub dgvProveedor_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProveedor.CellClick
        txtIDProveedor.Text = dgvProveedor.CurrentRow.Cells.Item(0).Value

        If dgvProductor.CurrentRow IsNot Nothing And dgvProveedor.CurrentRow IsNot Nothing And dgvCampo.CurrentRow IsNot Nothing And dgvCorral.CurrentRow IsNot Nothing Then
            btnSiguiente.Enabled = True
        End If
    End Sub

    Private Sub dgvCampo_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCampo.CellClick
        txtIDCampo.Text = dgvCampo.CurrentRow.Cells.Item(0).Value

        If dgvProductor.CurrentRow IsNot Nothing And dgvProveedor.CurrentRow IsNot Nothing And dgvCampo.CurrentRow IsNot Nothing And dgvCorral.CurrentRow IsNot Nothing Then
            btnSiguiente.Enabled = True
        End If
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtProcedencia.SelectionLength = Len(txtProcedencia.Text)
            txtProcedencia.Select()
        End If
    End Sub

    Private Sub txtProcedencia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtProcedencia.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtFechaIng.SelectionLength = Len(txtFechaIng.Text)
            txtFechaIng.Select()
        End If
    End Sub

    Private Sub txtFechaIng_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFechaIng.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> Keys.Enter And e.KeyChar <> ChrW(8) And e.KeyChar <> ChrW(45) And e.KeyChar <> ChrW(104) And e.KeyChar <> ChrW(72) Then
            e.Handled = True
        ElseIf e.KeyChar = ChrW(104) Or e.KeyChar = ChrW(72) Then
            e.Handled = True
            txtFechaIng.Text = Date.Now.Date
            txtFechaIng.SelectionLength = Len(txtFechaIng.Text)
            txtFechaIng.Select()
        ElseIf Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtCab.SelectionLength = Len(txtCab.Text)
            txtCab.Select()
        End If
    End Sub

    Private Sub txtCab_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCab.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> Keys.Enter And e.KeyChar <> ChrW(8) Then
            e.Handled = True
        ElseIf Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtKGCab.SelectionLength = Len(txtKGCab.Text)
            txtKGCab.Select()
        End If
    End Sub

    Private Sub txtKGCab_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKGCab.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> Keys.Enter And e.KeyChar <> ChrW(8) Then
            e.Handled = True
        ElseIf Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtObservaciones.SelectionLength = Len(txtObservaciones.Text)
            txtObservaciones.Select()
            If txtKGCab.Text <> "" Then
                txtKGTotal.Text = CDbl(txtKGCab.Text) * CDbl(txtCab.Text)
            End If
        End If
    End Sub

    Private Sub txtObservaciones_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtObservaciones.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            btnSiguiente2.Select()
        End If
    End Sub

    Private Sub txtFechaIng_Validated(sender As Object, e As EventArgs) Handles txtFechaIng.Validated
        If Not txtFechaIng.Text = "" Then
            If Not IsDate(txtFechaIng.Text) Then
                MsgBox("Error: Formato de Fecha incorrecto.", vbExclamation, "Servico de Alertas")
                txtFechaIng.Text = ""
                txtFechaIng.Select()
            Else
                txtFechaIng.Text = Format(CDate(txtFechaIng.Text), "dd/MM/yyyy")
            End If
        End If
    End Sub

    Private Sub txt_Validated(sender As Object, e As EventArgs) Handles txtNombre.Validated, txtFechaIng.Validated, txtProcedencia.Validated, txtCab.Validated, txtKGCab.Validated, txtObservaciones.Validated
        If txtNombre.Text <> "" And txtProcedencia.Text <> "" And txtFechaIng.Text <> "" And txtKGCab.Text <> "" And txtCab.Text <> "" Then
            btnSiguiente2.Enabled = True
        End If
    End Sub

    Private Sub btnSiguiente2_Click(sender As Object, e As EventArgs) Handles btnSiguiente2.Click
        gbxDatos1.Visible = False
        gbxDatos2.Visible = False
        gbxDatos3.Visible = True

        cbxCategorias.SelectionLength = Len(cbxCategorias.Text)
        cbxCategorias.Select()
    End Sub

    Private Sub btnVolver2_Click(sender As Object, e As EventArgs) Handles btnVolver2.Click
        gbxDatos1.Visible = False
        gbxDatos2.Visible = True
        gbxDatos3.Visible = False

        txtNombre.SelectionLength = Len(txtNombre.Text)
        txtNombre.Select()
    End Sub

    Private Sub cbxCategorias_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxCategorias.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtCantidad.SelectionLength = Len(txtCantidad.Text)
            txtCantidad.Select()
        End If
    End Sub

    Private Sub dgvCategorias_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCategorias.CellClick
        If Me.dgvCategorias.CurrentCell.GetType.ToString Like "*Button*" Then
            dgvCategorias.Rows.Remove(dgvCategorias.CurrentRow)
            dgvCategorias.Refresh()
        End If
    End Sub

    Private Sub cbxCategorias_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCategorias.SelectedIndexChanged
        Dim _Dt As New DataTable
        Dim _Ver As New Mostrar

        If frmLogin.txtTipUs.Text = "Super Usuario" Then
            _Dt = _Ver.verCategorias
        Else
            _Dt = _Ver.verCategoriasUs(frmLogin.txtID.Text)
        End If

        txtIDCatg.Text = ""
        For Each _Dr As DataRow In _Dt.Rows
            If _Dr("Categoria") = cbxCategorias.Text Then
                txtIDCatg.Text = _Dr("idCategorias")
            End If
        Next
    End Sub

    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> Keys.Enter And e.KeyChar <> ChrW(8) And Asc(e.KeyChar) <> Keys.Delete Then
            e.Handled = True
        ElseIf Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            cbxCategorias.SelectionLength = Len(cbxCategorias.Text)
            cbxCategorias.Select()
        End If
    End Sub

    Private Sub txtCantidad_Validated(sender As Object, e As EventArgs) Handles txtCantidad.Validated
        If Not txtCantidad.Text = "" Then
            If Not cbxCategorias.Text = "" Then
                If Not txtIDCatg.Text = "" Then
                    If CInt(txtCantidad.Text) <= CInt(txtCab.Text) Then
                        Dim Cant As Integer = CInt(txtCab.Text)
                        Dim btn As New DataGridViewButtonColumn()

                        Cant = Cant - CInt(txtCantidad.Text)

                        dgvCategorias.ColumnCount = 3
                        dgvCategorias.RowTemplate.Height = 30
                        dgvCategorias.Columns(0).Name = "Categoria"
                        dgvCategorias.Columns(1).Name = "Cantidad"
                        dgvCategorias.Columns(2).Name = "ID"
                        dgvCategorias.Columns(2).Visible = False

                        dgvCategorias.Columns.Add(btn)
                        btn.Text = "X"
                        btn.UseColumnTextForButtonValue = True

                        If dgvCategorias.Rows.Count > 0 Then
                            For i As Integer = 0 To dgvCategorias.Rows.Count - 1
                                dgvCategorias.CurrentCell = dgvCategorias.Rows(i).Cells(0)
                                If dgvCategorias.Item("Categoria", dgvCategorias.CurrentRow.Index).Value() = cbxCategorias.Text Then
                                    dgvCategorias.Rows.Remove(Me.dgvCategorias.CurrentRow)
                                    dgvCategorias.Refresh()
                                    Exit For
                                End If
                            Next
                        End If

                        If dgvCategorias.Rows.Count > 0 Then
                            For i As Integer = 0 To dgvCategorias.Rows.Count - 1
                                dgvCategorias.CurrentCell = dgvCategorias.Rows(i).Cells(1)
                                Cant = Cant - CInt(dgvCategorias.Item("Cantidad", dgvCategorias.CurrentRow.Index).Value())
                            Next
                        End If

                        If Cant >= 0 Then
                            dgvCategorias.Rows.Add(cbxCategorias.Text, txtCantidad.Text, txtIDCatg.Text)
                            dgvCategorias.Refresh()
                            txtCantidad.Text = ""
                        Else
                            MsgBox("Error: No hay ese numero de cabezas", vbExclamation, "Servico de Alertas")
                            txtCantidad.Text = ""
                            txtCantidad.Select()
                        End If
                    End If
                Else
                    MsgBox("Error: esa categoria no existe en la base de datos", vbExclamation, "Servico de Alertas")
                    cbxCategorias.Text = ""
                    cbxCategorias.Select()
                End If
            Else
                MsgBox("Error: No hay Categoria seleccionada", vbExclamation, "Servico de Alertas")
                cbxCategorias.Text = ""
                cbxCategorias.Select()
            End If
        End If
    End Sub

    Private Sub txtCab_GotFocus(sender As Object, e As EventArgs) Handles txtCab.GotFocus
        If txtOrigen.Text = "Modificar" Then
            txtCabAnterior.Text = txtCab.Text
        End If
    End Sub

    Private Sub txtCab_LostFocus(sender As Object, e As EventArgs) Handles txtCab.LostFocus
        If txtOrigen.Text = "Modificar" Then
            If txtCabAnterior.Text <> txtCab.Text Then
                Dim rows As Integer = dgvCategorias.Rows.Count - 1

                If dgvCategorias.Rows.Count > 0 Then
                    For j As Integer = rows To 0 Step -1
                        dgvCategorias.Rows.Remove(dgvCategorias.Rows(j))
                    Next
                End If

                If txtKGCab.Text <> "" Then
                    txtKGTotal.Text = CDbl(txtKGCab.Text) * CDbl(txtCab.Text)
                End If
            End If
        End If
    End Sub

    Private Sub cbxCategorias_TextChanged(sender As Object, e As EventArgs) Handles cbxCategorias.TextChanged
        txtIDCatg.Text = ""
    End Sub

End Class