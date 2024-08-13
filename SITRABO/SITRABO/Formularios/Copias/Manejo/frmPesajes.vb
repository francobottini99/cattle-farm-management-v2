Public Class frmPesajes
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

    Private Sub frmPesajes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ctlNuevo As Control = DirectCast(pbxNuevo, Control)
        Dim keyprNuevo = New KeyPressEventHandler(AddressOf btnNuevo)
        Dim ctlGuardar As Control = DirectCast(pbxGuardar, Control)
        Dim keyprGuardar = New KeyPressEventHandler(AddressOf btnGuardar)

        AddHandler ctlNuevo.KeyPress, keyprNuevo
        AddHandler ctlGuardar.KeyPress, keyprGuardar

        Me.Text = "Si.Tra.Bo. - Sistema de Trazabilidad Bovina" & " - USUARIO: " & frmLogin.txtNom.Text & " " & frmLogin.txtAp.Text & " -"
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

    Private Sub pbxNuevo_Click(sender As Object, e As EventArgs) Handles pbxNuevo.Click
        Dim _Dt2 As New DataTable
        Dim _Ver2 As New Mostrar

        If frmLogin.txtTipUs.Text = "Super Usuario" Then
            _Dt2 = _Ver2.verCorrales
        Else
            _Dt2 = _Ver2.verCorralesUs(frmLogin.txtID.Text)
        End If

        dgvCrr.RowTemplate.Height = 25
        dgvCrr.DataSource = _Dt2

        Dim rows As Integer = _Dt2.Rows.Count - 1

        For j As Integer = rows To 0 Step -1
            If _Dt2.Rows(j).Item("CabezasTotales") = 0 Then
                _Dt2.Rows.Remove(_Dt2.Rows(j))
            End If
        Next

        dgvCrr.Columns("idCorrales").Visible = False
        dgvCrr.Columns("Superficie").Visible = False
        dgvCrr.Columns("CabezasTotales").Visible = False
        dgvCrr.Columns("CAMPO_idCampo").Visible = False
        dgvCrr.Columns("USUARIOS_idUsuario").Visible = False

        If dgvCrr.Rows.Count <= 0 Then
            MsgBox("Error: No se a encontrado ningun corral con stock disponible... !", vbExclamation, "Servico de Alertas")
            Cancelar()
        Else
            txtOrigen.Text = "Nuevo"
            Activar()
            lblMsg.Text = "PESAJE | NUEVO"
            gbxNuevo.Visible = True
            gbxModificar.Visible = False
            gbxPantallaInicio.Visible = False
            pbxNuevo.BackgroundImage = SITRABO.My.Resources.btnNuevoSi
            dgvCrr.CurrentCell = Nothing
        End If
    End Sub

    Private Sub Activar()
        pbxNuevo.Enabled = False
        pbxGuardar.Enabled = True
        pbxCancelar.Enabled = True
        pbxModificar.Enabled = False
        pbxSalir.Enabled = False
    End Sub

    Private Sub Cancelar()
        pbxNuevo.Enabled = True
        pbxGuardar.Enabled = False
        pbxCancelar.Enabled = False
        pbxModificar.Enabled = True
        pbxSalir.Enabled = True

        gbxNuevo.Visible = False
        gbxModificar.Visible = False
        gbxPantallaInicio.Visible = True

        lblContCab.Text = 0
        lblContBal.Text = 0
        lblContDes.Text = 0
        lblContNet.Text = 0
        lblContPmCab.Text = 0
        lblContPmDes.Text = 0

        lblVtaCab.Text = 0
        lblVtaBal.Text = 0
        lblVtaDes.Text = 0
        lblVtaNet.Text = 0
        lblVtaPmCab.Text = 0
        lblVtaPmDes.Text = 0

        lblTotCab.Text = 0
        lblTotBal.Text = 0
        lblTotDes.Text = 0
        lblTotNet.Text = 0
        lblTotPmCab.Text = 0
        lblTotPmDes.Text = 0

        Label3.ForeColor = Color.BurlyWood
        Label5.BackColor = Color.BurlyWood
        Label4.ForeColor = Color.BurlyWood
        Label6.BackColor = Color.BurlyWood
        Label13.BackColor = Color.BurlyWood
        Label12.ForeColor = Color.BurlyWood

        dgvDetCrrAnimal.BackgroundColor = Color.BurlyWood
        dgvCrr.BackgroundColor = Color.BurlyWood
        dgvAnimPesados.BackgroundColor = Color.BurlyWood

        dgvPesajes.DataSource = Nothing

        Dim rows As Integer = dgvCrr.Rows.Count - 1

        If dgvCrr.Rows.Count > 0 Then
            For j As Integer = rows To 0 Step -1
                dgvCrr.Rows.Remove(dgvCrr.Rows(j))
            Next
        End If

        Dim rows2 As Integer = dgvDetCrrAnimal.Rows.Count - 1

        If dgvDetCrrAnimal.Rows.Count > 0 Then
            For j As Integer = rows2 To 0 Step -1
                dgvDetCrrAnimal.Rows.Remove(dgvDetCrrAnimal.Rows(j))
            Next
        End If

        Dim rows3 As Integer = dgvAnimPesados.Rows.Count - 1

        If dgvAnimPesados.Rows.Count > 0 Then
            For j As Integer = rows3 To 0 Step -1
                dgvAnimPesados.Rows.Remove(dgvAnimPesados.Rows(j))
            Next
        End If

        BorrarDetAnimal()

        dgvCrr.ColumnHeadersVisible = False
        dgvCrr.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvDetCrrAnimal.ColumnHeadersVisible = False
        dgvDetCrrAnimal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvAnimPesados.ColumnHeadersVisible = False
        dgvAnimPesados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvPesajes.ColumnHeadersVisible = False
        dgvPesajes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        pbxNuevo.BackgroundImage = SITRABO.My.Resources.btnNuevoNo
        pbxModificar.BackgroundImage = SITRABO.My.Resources.btnModificarNo
    End Sub

    Private Sub pbxCancelar_Click(sender As Object, e As EventArgs) Handles pbxCancelar.Click
        Cancelar()
        lblMsg.Text = "PESAJE"
    End Sub

    Private Sub dgvCrr_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCrr.CellClick
        Dim _Dt, _Dt2, _Dt3 As New DataTable
        Dim _Ver, _Ver2, _Ver3 As New Mostrar

        If frmLogin.txtTipUs.Text = "Super Usuario" Then
            _Dt2 = _Ver2.verCorrales
            _Dt = _Ver.consDetalleTropaEngorde(dgvCrr.CurrentRow.Cells.Item(0).Value)
        Else
            _Dt2 = _Ver2.verCorralesUs(frmLogin.txtID.Text)
            _Dt = _Ver.consDetalleTropaEngordeUS(frmLogin.txtID.Text, dgvCrr.CurrentRow.Cells.Item(0).Value)
        End If

        dgvDetCrrAnimal.RowTemplate.Height = 25
        dgvDetCrrAnimal.DataSource = _Dt
        dgvDetCrrAnimal.Columns("idDetTropa").Visible = False
        dgvDetCrrAnimal.Columns("Estado").Visible = False
        dgvDetCrrAnimal.Columns("idTropa").Visible = False

        Dim rows As Integer = dgvAnimPesados.Rows.Count - 1

        For j As Integer = rows To 0 Step -1
            Dim rows2 As Integer = dgvDetCrrAnimal.Rows.Count - 1

            For i As Integer = rows2 To 0 Step -1
                If dgvAnimPesados.Rows(j).Cells.Item(0).Value = dgvDetCrrAnimal.Rows(i).Cells.Item(3).Value Then
                    dgvDetCrrAnimal.Rows.Remove(dgvDetCrrAnimal.Rows(i))
                End If
            Next
        Next

        Dim rows3 As Integer = dgvDetCrrAnimal.Rows.Count - 1

        For j As Integer = rows3 To 0 Step -1
            _Dt2 = _Ver2.verPesajeVenta(dgvDetCrrAnimal.Rows(j).Cells.Item(3).Value)

            If _Dt2.Rows.Count > 0 Then
                dgvDetCrrAnimal.Rows.Remove(dgvDetCrrAnimal.Rows(j))
            End If
        Next

        dgvDetCrrAnimal.Sort(dgvDetCrrAnimal.Columns("NombreTropa"), System.ComponentModel.ListSortDirection.Ascending)
        dgvDetCrrAnimal.CurrentCell = Nothing
    End Sub

    Private Sub dgvDetCrrAnimal_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDetCrrAnimal.CellDoubleClick
        If e.RowIndex > -1 Then
            Dim _Dt As New DataTable
            Dim _Ver As New Mostrar

            If frmLogin.txtTipUs.Text = "Super Usuario" Then
                _Dt = _Ver.verTropaPesoIngreso(dgvDetCrrAnimal.CurrentRow.Cells.Item(6).Value)
            Else
                _Dt = _Ver.verTropaPesoIngresoUs(frmLogin.txtID.Text, dgvDetCrrAnimal.CurrentRow.Cells.Item(6).Value)
            End If

            dgvCrr.Enabled = False
            dgvDetCrrAnimal.Enabled = False

            gbxFecha.Enabled = True
            gbxAnimal.Enabled = True

            btnGrabar.Enabled = True
            btnCancelar.Enabled = True

            btnCancelar.BackColor = Color.SlateGray
            btnGrabar.BackColor = Color.Sienna

            lblTropa.Text = dgvDetCrrAnimal.CurrentRow.Cells.Item(4).Value
            lblPesoIng.Text = _Dt.Rows(0).Item(8).ToString + " KG"
            lblFecIng.Text = Format(CDate(_Dt.Rows(0).Item(3).ToString), "dd/MM/yyyy")
            lblCat.Text = dgvDetCrrAnimal.CurrentRow.Cells.Item(5).Value
            lblDetalle.Text = dgvDetCrrAnimal.CurrentRow.Cells.Item(1).Value

            txtFecha.Text = Date.Now.Date

            If dgvDetCrrAnimal.CurrentRow.Cells.Item(0).Value <> "***" Then
                txtCaravana.Text = dgvDetCrrAnimal.CurrentRow.Cells.Item(0).Value
            End If

            dgvAnimPesados.CurrentCell = Nothing

            txtFecha.SelectionLength = Len(txtFecha.Text)
            txtFecha.Focus()
        End If
    End Sub

    Private Sub txtFecha_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFecha.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> Keys.Enter And e.KeyChar <> ChrW(8) And e.KeyChar <> ChrW(45) And e.KeyChar <> ChrW(117) And e.KeyChar <> ChrW(85) And e.KeyChar <> ChrW(104) And e.KeyChar <> ChrW(72) Then
            e.Handled = True
        ElseIf e.KeyChar = ChrW(117) Or e.KeyChar = ChrW(85) Then
            e.Handled = True
            If dgvAnimPesados.Rows.Count > 0 Then
                txtFecha.Text = dgvAnimPesados.Rows(dgvAnimPesados.Rows.Count - 1).Cells.Item(2).Value
                txtFecha.SelectionLength = Len(txtFecha.Text)
                txtFecha.Select()
            End If
        ElseIf e.KeyChar = ChrW(104) Or e.KeyChar = ChrW(72) Then
            e.Handled = True
            txtFecha.Text = Date.Now.Date
            txtFecha.SelectionLength = Len(txtFecha.Text)
            txtFecha.Select()
        ElseIf Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtCaravana.SelectionLength = Len(txtCaravana.Text)
            txtCaravana.Select()
        End If
    End Sub

    Private Sub txtFecha_Validated(sender As Object, e As EventArgs) Handles txtFecha.Validated
        If Not txtFecha.Text = "" Then
            If Not IsDate(txtFecha.Text) Then
                MsgBox("Error: Formato de Fecha incorrecto.", vbExclamation, "Servico de Alertas")
                txtFecha.Text = ""
                txtFecha.Select()
            Else
                txtFecha.Text = Format(CDate(txtFecha.Text), "dd/MM/yyyy")
            End If
        End If
    End Sub

    Private Sub txtCaravana_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCaravana.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            rdbControl.Select()
        End If
    End Sub

    Private Sub rdbControl_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rdbControl.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtKG.SelectionLength = Len(txtKG.Text)
            txtKG.Select()
        End If
    End Sub

    Private Sub rdbVenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rdbVenta.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtKG.SelectionLength = Len(txtKG.Text)
            txtKG.Select()
        End If
    End Sub

    Private Sub txtKG_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKG.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> Keys.Enter And e.KeyChar <> ChrW(8) And e.KeyChar <> ChrW(45) Then
            e.Handled = True
        ElseIf Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            If rdbVenta.Checked = True Then
                txtPorDesb.SelectionLength = Len(txtPorDesb.Text)
                txtPorDesb.Select()
            Else
                txtObsrv.SelectionLength = Len(txtObsrv.Text)
                txtObsrv.Select()
            End If
        End If
    End Sub

    Private Sub txtPorDesb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPorDesb.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> Keys.Enter And e.KeyChar <> ChrW(8) And e.KeyChar <> ChrW(45) Then
            e.Handled = True
        ElseIf Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtObsrv.SelectionLength = Len(txtObsrv.Text)
            txtObsrv.Select()
        End If
    End Sub

    Private Sub txtKgNeto_Validated(sender As Object, e As EventArgs) Handles txtPorDesb.Validated, txtKG.Validated, txtFecha.Validated, txtCaravana.Validated, txtObsrv.Validated
        If rdbVenta.Checked = True Then
            If txtKG.Text <> "" And txtPorDesb.Text <> "" Then
                txtKgNetos.Text = txtKG.Text * (txtPorDesb.Text / 100)
            End If
        Else
            If txtKG.Text <> "" Then
                txtKgNetos.Text = txtKG.Text
            End If
        End If
    End Sub

    Private Sub txtObsrv_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtObsrv.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            If txtOrigen.Text = "Nuevo" Then
                btnGrabar.Select()
            Else
                pbxGuardar.Select()
            End If
        End If
    End Sub

    Private Sub pbxGuardar_Click(sender As Object, e As EventArgs) Handles pbxGuardar.Click
        If gbxNuevo.Visible = True Then
            If dgvAnimPesados.Rows.Count < 1 And txtOrigen.Text = "Nuevo" Then
                MsgBox("No hay ningun peso para guardar... !", vbExclamation, "Servico de Alertas")
            Else
                Dim G As New GrabaDatos
                Dim resP As DialogResult

                If txtOrigen.Text = "Nuevo" Then

                    resP = MessageBox.Show("Grabar pesos ?", "Servico de Alertas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

                    If resP = Windows.Forms.DialogResult.OK Then
                        For i As Integer = 0 To dgvAnimPesados.Rows.Count - 1
                            G.Grabar("pesaje", "NoImagen", "feedlot.insPesaje", Format(CDate(dgvAnimPesados.Rows(i).Cells.Item(2).Value), "yyyy/MM/dd"), dgvAnimPesados.Rows(i).Cells.Item(4).Value, _
                                     dgvAnimPesados.Rows(i).Cells.Item(5).Value, dgvAnimPesados.Rows(i).Cells.Item(6).Value, dgvAnimPesados.Rows(i).Cells.Item(7).Value, dgvAnimPesados.Rows(i).Cells.Item(8).Value, _
                                     dgvAnimPesados.Rows(i).Cells.Item(9).Value, dgvAnimPesados.Rows(i).Cells.Item(0).Value, dgvAnimPesados.Rows(i).Cells.Item(1).Value, _
                                     CInt(frmLogin.txtID.Text))

                            G.Grabar("detalle_tropa", "NoImagen", "feedlot.modDetalleTropaCaravana", dgvAnimPesados.Rows(i).Cells.Item(0).Value, dgvAnimPesados.Rows(i).Cells.Item(3).Value)

                            G.Grabar("tropa_bloqueo_mod", "NoImagen", "feedlot.modEstadoMod", "NO", dgvAnimPesados.Rows(i).Cells.Item(1).Value)
                        Next

                        Cancelar()
                        txtOrigen.Text = ""
                    End If
                Else
                    If txtFecha.Text = "" Then
                        MsgBox("Error: El campo Fecha es obligatorio... !", vbExclamation, "Servico de Alertas")
                        txtFecha.Select()
                    Else
                        If txtKG.Text = "" Then
                            MsgBox("Error: El campo Peso es obligatorio... !", vbExclamation, "Servico de Alertas")
                            txtKG.Select()
                        Else
                            If rdbControl.Checked = False And rdbVenta.Checked = False Then
                                MsgBox("Error: Debes seleccionar el tipo de peso... !", vbExclamation, "Servico de Alertas")
                            Else
                                If txtPorDesb.Text = "" And txtPorDesb.Enabled = True Then
                                    MsgBox("Error: El campo % Desba. es obligatorio para realizar un peso de venta... !", vbExclamation, "Servico de Alertas")
                                    txtPorDesb.Select()
                                Else

                                    resP = MessageBox.Show("Modificar peso ?", "Servico de Alertas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

                                    If resP = Windows.Forms.DialogResult.OK Then
                                        Dim Tipo As String

                                        If rdbControl.Checked = True Then
                                            Tipo = "Control"
                                        Else
                                            Tipo = "Venta"
                                        End If

                                        If txtPorDesb.Text = "" Then
                                            txtPorDesb.Text = 0
                                        End If


                                        If txtObsrv.Text = "" Then
                                            txtObsrv.Text = "-"
                                        End If

                                        G.Grabar("pesaje", "NoImagen", "feedlot.modPesaje", dgvPesajes.CurrentRow.Cells.Item(0).Value, Format(CDate(txtFecha.Text), "yyyy/MM/dd"), Tipo, _
                                                CDbl(txtKG.Text), CDbl(txtPorDesb.Text), CDbl(txtKG.Text - txtKgNetos.Text), CDbl(txtKgNetos.Text), txtObsrv.Text, dgvPesajes.CurrentRow.Cells.Item(2).Value, dgvPesajes.CurrentRow.Cells.Item(1).Value, _
                                                CInt(frmLogin.txtID.Text))

                                        G.Grabar("detalle_tropa", "NoImagen", "feedlot.modDetalleTropaCaravana", dgvPesajes.CurrentRow.Cells.Item(2).Value, txtCaravana.Text)

                                        G.Grabar("tropa_bloqueo_mod", "NoImagen", "feedlot.modEstadoMod", "NO", dgvPesajes.CurrentRow.Cells.Item(1).Value)


                                        Cancelar()
                                        txtOrigen.Text = ""
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        BorrarDetAnimal()

        If txtOrigen.Text = "Modificar" Then
            Cancelar()
        End If
    End Sub

    Private Sub BorrarDetAnimal()
        lblTropa.Text = "-"
        lblPesoIng.Text = "-"
        lblFecIng.Text = "-"
        lblCat.Text = "-"
        lblDetalle.Text = "-"

        txtFecha.Text = ""
        txtCaravana.Text = ""
        txtKG.Text = ""
        txtObsrv.Text = ""
        txtPorDesb.Text = ""
        txtKgNetos.Text = ""

        txtPorDesb.Enabled = False

        rdbControl.Checked = False
        rdbVenta.Checked = False

        gbxFecha.Enabled = False
        gbxAnimal.Enabled = False

        btnGrabar.Enabled = False
        btnCancelar.Enabled = False
        btnCancelar.BackColor = Color.DimGray
        btnGrabar.BackColor = Color.DimGray

        dgvCrr.Enabled = True
        dgvDetCrrAnimal.Enabled = True

        dgvDetCrrAnimal.CurrentCell = Nothing
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        If txtFecha.Text = "" Then
            MsgBox("Error: El campo Fecha es obligatorio... !", vbExclamation, "Servico de Alertas")
            txtFecha.Select()
        Else
            If txtKG.Text = "" Then
                MsgBox("Error: El campo Peso es obligatorio... !", vbExclamation, "Servico de Alertas")
                txtKG.Select()
            Else
                If rdbControl.Checked = False And rdbVenta.Checked = False Then
                    MsgBox("Error: Debes seleccionar el tipo de peso... !", vbExclamation, "Servico de Alertas")
                Else
                    If txtPorDesb.Text = "" And txtPorDesb.Enabled = True Then
                        MsgBox("Error: El campo % Desba. es obligatorio para realizar un peso de venta... !", vbExclamation, "Servico de Alertas")
                        txtPorDesb.Select()
                    Else
                        Dim Tipo As String
                        Dim rows As Integer
                        Dim Desb, KGBalanzaCtrl, XcabCtrl, KGBalanzaVenta, KGDesbVenta, KGNetosVenta, XcabVenta, XcabDesbVenta As Double
                        Dim CabCtrl, CabVenta As Integer

                        CabCtrl = 0
                        CabVenta = 0
                        KGDesbVenta = 0
                        KGBalanzaCtrl = 0
                        KGBalanzaVenta = 0
                        KGNetosVenta = 0
                        XcabDesbVenta = 0
                        XcabCtrl = 0
                        XcabVenta = 0

                        dgvAnimPesados.RowTemplate.Height = 25
                        dgvAnimPesados.ColumnCount = 10
                        dgvAnimPesados.Columns(0).Name = "idDetTropa"
                        dgvAnimPesados.Columns(1).Name = "idTropa"
                        dgvAnimPesados.Columns(2).Name = "Fecha"
                        dgvAnimPesados.Columns(3).Name = "Caravana"
                        dgvAnimPesados.Columns(4).Name = "Tipo"
                        dgvAnimPesados.Columns(5).Name = "Peso"
                        dgvAnimPesados.Columns(6).Name = "% Desbaste"
                        dgvAnimPesados.Columns(7).Name = "Desbaste"
                        dgvAnimPesados.Columns(8).Name = "Peso Final"
                        dgvAnimPesados.Columns(9).Name = "Observaciones"

                        dgvAnimPesados.Columns(0).Visible = False
                        dgvAnimPesados.Columns(1).Visible = False
                        dgvAnimPesados.ColumnHeadersVisible = True
                        dgvAnimPesados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None

                        dgvAnimPesados.Columns("Fecha").Width = 110
                        dgvAnimPesados.Columns("Caravana").Width = 100
                        dgvAnimPesados.Columns("Tipo").Width = 80
                        dgvAnimPesados.Columns("Peso").Width = 100
                        dgvAnimPesados.Columns("% Desbaste").Width = 100
                        dgvAnimPesados.Columns("Peso Final").Width = 100
                        dgvAnimPesados.Columns("Desbaste").Width = 100
                        dgvAnimPesados.Columns("Observaciones").Width = 200

                        dgvAnimPesados.Columns("Peso").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                        dgvAnimPesados.Columns("% Desbaste").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                        dgvAnimPesados.Columns("Peso Final").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                        dgvAnimPesados.Columns("Desbaste").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                        If rdbControl.Checked = True Then
                            Tipo = "Control"
                        Else
                            Tipo = "Venta"
                        End If

                        If txtCaravana.Text = "" Then
                            txtCaravana.Text = "***"
                        End If

                        If txtObsrv.Text = "" Then
                            txtObsrv.Text = "-"
                        End If

                        If txtPorDesb.Enabled = False Then
                            txtPorDesb.Text = 0
                            Desb = 0
                        Else
                            Desb = txtKG.Text - txtKgNetos.Text
                        End If

                        dgvAnimPesados.Rows.Add(dgvDetCrrAnimal.CurrentRow.Cells.Item(3).Value, dgvDetCrrAnimal.CurrentRow.Cells.Item(6).Value, txtFecha.Text, txtCaravana.Text, Tipo, txtKG.Text, txtPorDesb.Text, Desb, txtKgNetos.Text, txtObsrv.Text)
                        dgvDetCrrAnimal.Rows.Remove(dgvDetCrrAnimal.CurrentRow)

                        rows = dgvAnimPesados.Rows.Count - 1

                        For j As Integer = rows To 0 Step -1
                            If dgvAnimPesados.Rows(j).Cells.Item(4).Value = "Control" Then
                                CabCtrl = CabCtrl + 1
                                KGBalanzaCtrl = KGBalanzaCtrl + dgvAnimPesados.Rows(j).Cells.Item(5).Value
                                XcabCtrl = KGBalanzaCtrl / CabCtrl
                            Else
                                CabVenta = CabVenta + 1
                                KGBalanzaVenta = KGBalanzaVenta + dgvAnimPesados.Rows(j).Cells.Item(5).Value
                                KGDesbVenta = KGDesbVenta + dgvAnimPesados.Rows(j).Cells.Item(7).Value
                                KGNetosVenta = KGBalanzaVenta - KGDesbVenta
                                XcabVenta = KGBalanzaVenta / CabVenta
                                XcabDesbVenta = KGNetosVenta / CabVenta
                            End If
                        Next

                        lblContCab.Text = Format(CabCtrl, "#,#00")
                        lblContBal.Text = Format(KGBalanzaCtrl, "#,#00")
                        lblContDes.Text = 0
                        lblContNet.Text = Format(KGBalanzaCtrl, "#,#00")
                        lblContPmCab.Text = Format(XcabCtrl, "#,#00")
                        lblContPmDes.Text = 0

                        lblVtaCab.Text = Format(CabVenta, "#,#00")
                        lblVtaBal.Text = Format(KGBalanzaVenta, "#,#00")
                        lblVtaDes.Text = Format(KGDesbVenta, "#,#00")
                        lblVtaNet.Text = Format(KGNetosVenta, "#,#00")
                        lblVtaPmCab.Text = Format(XcabVenta, "#,#00")
                        lblVtaPmDes.Text = Format(XcabDesbVenta, "#,#00")

                        lblTotCab.Text = Format(CabCtrl + CabVenta, "#,#00")
                        lblTotBal.Text = Format(KGBalanzaCtrl + KGBalanzaVenta, "#,#00")
                        lblTotDes.Text = Format(KGDesbVenta, "#,#00")
                        lblTotNet.Text = Format(KGNetosVenta + KGBalanzaCtrl, "#,#00")
                        lblTotPmCab.Text = Format(XcabCtrl + XcabVenta, "#,#00")
                        lblTotPmDes.Text = Format(XcabDesbVenta, "#,#00")

                        BorrarDetAnimal()

                        dgvAnimPesados.CurrentCell = Nothing
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub dgvAnimPesados_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAnimPesados.CellDoubleClick
        If e.RowIndex > -1 Then
            Dim _Dt As New DataTable
            Dim _Ver As New Mostrar

            If frmLogin.txtTipUs.Text = "Super Usuario" Then
                _Dt = _Ver.consDetalleTropaEngorde(dgvCrr.CurrentRow.Cells.Item(0).Value)
            Else
                _Dt = _Ver.consDetalleTropaEngordeUS(frmLogin.txtID.Text, dgvCrr.CurrentRow.Cells.Item(0).Value)
            End If

            dgvDetCrrAnimal.DataSource = _Dt

            If dgvAnimPesados.Rows.Count = 1 Then
                dgvAnimPesados.ColumnHeadersVisible = False
                dgvAnimPesados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            End If

            dgvAnimPesados.Rows.Remove(dgvAnimPesados.CurrentRow)

            Dim rows As Integer = dgvAnimPesados.Rows.Count - 1

            For j As Integer = rows To 0 Step -1
                Dim rows2 As Integer = dgvDetCrrAnimal.Rows.Count - 1

                For i As Integer = rows2 To 0 Step -1
                    If dgvAnimPesados.Rows(j).Cells.Item(0).Value = dgvDetCrrAnimal.Rows(i).Cells.Item(3).Value Then
                        dgvDetCrrAnimal.Rows.Remove(dgvDetCrrAnimal.Rows(i))
                    End If
                Next
            Next

            dgvDetCrrAnimal.Sort(dgvDetCrrAnimal.Columns("NombreTropa"), System.ComponentModel.ListSortDirection.Ascending)
            dgvDetCrrAnimal.CurrentCell = Nothing
        End If
    End Sub

    Private Sub pbxModificar_Click(sender As Object, e As EventArgs) Handles pbxModificar.Click
        gbxNuevo.Visible = False
        gbxModificar.Visible = True
        gbxPantallaInicio.Visible = False

        Activar()
        lblMsg.Text = "PESAJE | MODIFICAR"
        pbxModificar.BackgroundImage = SITRABO.My.Resources.btnModificarSi
        txtOrigen.Text = "Modificar"

        Dim _Dt As New DataTable
        Dim _Ver As New Mostrar

        If frmLogin.txtTipUs.Text = "Super Usuario" Then
            _Dt = _Ver.consPesaje
        Else
            _Dt = _Ver.consPesajeUS(frmLogin.txtID.Text)
        End If

        dgvPesajes.RowTemplate.Height = 25
        dgvPesajes.DataSource = _Dt
        dgvPesajes.Columns("idPESAJE").Visible = False
        dgvPesajes.Columns("idTropa").Visible = False
        dgvPesajes.Columns("idDetTropa").Visible = False
        dgvPesajes.Columns("PorcDesbaste").Visible = False
        dgvPesajes.Columns("Desbaste").Visible = False
        dgvPesajes.Columns("Peso").Visible = False

        dgvPesajes.ColumnHeadersVisible = True
        dgvPesajes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None

        dgvPesajes.Columns("Fecha").Width = 90
        dgvPesajes.Columns("NombreTropa").Width = 160
        dgvPesajes.Columns("Caravana").Width = 100
        dgvPesajes.Columns("Descripcion").Width = 150
        dgvPesajes.Columns("Tipo").Width = 80
        dgvPesajes.Columns("Categoria").Width = 110
        dgvPesajes.Columns("PesoFinal").Width = 100
        dgvPesajes.Columns("Observaciones").Width = 190
        dgvPesajes.Columns("Estado").Width = 90

        dgvPesajes.Sort(dgvPesajes.Columns("Fecha"), System.ComponentModel.ListSortDirection.Descending)

        dgvPesajes.CurrentCell = Nothing
    End Sub

    Private Sub mtcFiltro_DateSelected(sender As Object, e As DateRangeEventArgs) Handles mtcFiltro.DateSelected
        Dim _Dt As New DataTable
        Dim _Ver As New Mostrar

        lblFechaMod.Text = mtcFiltro.SelectionRange.Start.ToShortDateString()

        If frmLogin.txtTipUs.Text = "Super Usuario" Then
            _Dt = _Ver.consPesajeFecha(Format(CDate(lblFechaMod.Text), "yyyy/MM/dd"))
        Else
            _Dt = _Ver.consPesajeFechaUS(frmLogin.txtID.Text, Format(CDate(lblFechaMod.Text), "yyyy/MM/dd"))
        End If

        dgvPesajes.DataSource = _Dt
        dgvPesajes.CurrentCell = Nothing
    End Sub

    Private Sub btnLimpiarFiltro_Click(sender As Object, e As EventArgs) Handles btnLimpiarFiltro.Click
        Dim _Dt As New DataTable
        Dim _Ver As New Mostrar

        If frmLogin.txtTipUs.Text = "Super Usuario" Then
            _Dt = _Ver.consPesaje
        Else
            _Dt = _Ver.consPesajeUS(frmLogin.txtID.Text)
        End If

        dgvPesajes.DataSource = _Dt
        dgvPesajes.Sort(dgvPesajes.Columns("Fecha"), System.ComponentModel.ListSortDirection.Descending)

        mtcFiltro.SetDate(Nothing)
        dgvPesajes.CurrentCell = Nothing
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If dgvPesajes.CurrentCell IsNot Nothing Then
            Dim _Dt As New DataTable
            Dim _Ver As New Mostrar

            If frmLogin.txtTipUs.Text = "Super Usuario" Then
                _Dt = _Ver.verTropaPesoIngreso(dgvPesajes.CurrentRow.Cells.Item(1).Value)
            Else
                _Dt = _Ver.verTropaPesoIngresoUs(frmLogin.txtID.Text, dgvPesajes.CurrentRow.Cells.Item(1).Value)
            End If

            gbxNuevo.Visible = True
            gbxModificar.Visible = False
            gbxPantallaInicio.Visible = False

            dgvDetCrrAnimal.Enabled = False
            dgvCrr.Enabled = False
            dgvAnimPesados.Enabled = False

            dgvDetCrrAnimal.BackgroundColor = Color.DimGray
            dgvCrr.BackgroundColor = Color.DimGray
            dgvAnimPesados.BackgroundColor = Color.DimGray

            Label3.ForeColor = Color.DimGray
            Label5.BackColor = Color.DimGray
            Label4.ForeColor = Color.DimGray
            Label6.BackColor = Color.DimGray
            Label13.BackColor = Color.DimGray
            Label12.ForeColor = Color.DimGray

            btnCancelar.Enabled = True

            btnCancelar.BackColor = Color.Sienna

            gbxAnimal.Enabled = True
            gbxFecha.Enabled = True

            dgvDetCrrAnimal.BackgroundColor = Color.DimGray

            txtFecha.Text = dgvPesajes.CurrentRow.Cells.Item(3).Value
            txtKG.Text = dgvPesajes.CurrentRow.Cells.Item(9).Value
            txtObsrv.Text = dgvPesajes.CurrentRow.Cells.Item(13).Value
            txtCaravana.Text = dgvPesajes.CurrentRow.Cells.Item(5).Value
            txtPorDesb.Text = dgvPesajes.CurrentRow.Cells.Item(10).Value
            txtKgNetos.Text = dgvPesajes.CurrentRow.Cells.Item(12).Value

            lblTropa.Text = dgvPesajes.CurrentRow.Cells.Item(4).Value
            lblPesoIng.Text = _Dt.Rows(0).Item(8).ToString + " KG"
            lblFecIng.Text = Format(CDate(_Dt.Rows(0).Item(3).ToString), "dd/MM/yyyy")
            lblCat.Text = dgvPesajes.CurrentRow.Cells.Item(8).Value
            lblDetalle.Text = dgvPesajes.CurrentRow.Cells.Item(6).Value

            If IsDBNull(dgvPesajes.CurrentRow.Cells.Item(7).Value) Then
                rdbControl.Checked = False
                rdbVenta.Checked = False
            ElseIf dgvPesajes.CurrentRow.Cells.Item(7).Value = "Venta" Then
                rdbVenta.Checked = True
                rdbControl.Checked = False
            Else
                rdbControl.Checked = True
                rdbVenta.Checked = False
            End If

            txtFecha.SelectionLength = Len(txtFecha.Text)
            txtFecha.Select()
        End If
    End Sub

    Private Sub rdbVenta_CheckedChanged(sender As Object, e As EventArgs) Handles rdbVenta.CheckedChanged
        If rdbVenta.Checked = True Then
            txtPorDesb.Text = 92
            txtPorDesb.Enabled = True

            If txtKG.Text <> "" And txtPorDesb.Text <> "" Then
                txtKgNetos.Text = txtKG.Text * (txtPorDesb.Text / 100)
            End If
        Else
            txtPorDesb.Text = ""
            txtPorDesb.Enabled = False

            If txtKG.Text <> "" Then
                txtKgNetos.Text = txtKG.Text
            End If
        End If
    End Sub

    Private Sub rdbControl_CheckedChanged(sender As Object, e As EventArgs) Handles rdbControl.CheckedChanged
        If rdbVenta.Checked = True Then
            txtPorDesb.Text = 80
            txtPorDesb.Enabled = True

            If txtKG.Text <> "" And txtPorDesb.Text <> "" Then
                txtKgNetos.Text = txtKG.Text * (txtPorDesb.Text / 100)
            End If
        Else
            txtPorDesb.Text = ""
            txtPorDesb.Enabled = False

            If txtKG.Text <> "" Then
                txtKgNetos.Text = txtKG.Text
            End If
        End If
    End Sub

    Private Sub DgvCrr_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCrr.CellContentClick

    End Sub
End Class