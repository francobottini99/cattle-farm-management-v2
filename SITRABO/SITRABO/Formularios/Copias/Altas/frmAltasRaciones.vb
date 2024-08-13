Imports MySql.Data.MySqlClient

Public Class frmAltasRaciones
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

        CargarDGV()

        pbxNuevo.Select()
    End Sub

    Private Sub CargarDGV()
        Dim _Dt As New DataTable
        Dim _Ver As New Mostrar

        If frmLogin.txtTipUs.Text = "Super Usuario" Then
            _Dt = _Ver.verRaciones
        Else
            _Dt = _Ver.verRacionesUs(frmLogin.txtID.Text)
        End If

        dgvRaciones.RowTemplate.Height = 35
        dgvRaciones.DataSource = _Dt
        dgvRaciones.Columns("idRaciones").Visible = False
        dgvRaciones.Columns("Grano").Visible = False
        dgvRaciones.Columns("Concentrado").Visible = False
        dgvRaciones.Columns("Fibra").Visible = False
        dgvRaciones.Columns("Otros").Visible = False
        dgvRaciones.Columns("CostoGrano").Visible = False
        dgvRaciones.Columns("CostoConcentrado").Visible = False
        dgvRaciones.Columns("CostoFibra").Visible = False
        dgvRaciones.Columns("CostoOtros").Visible = False
        dgvRaciones.Columns("USUARIOS_idUsuario").Visible = False
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
        txtGrano.Text = ""
        txtRacion.Text = ""
        txtCostGrano.Text = ""
        txtConcentrado.Text = ""
        txtCostConcentrado.Text = ""
        txtFibra.Text = ""
        txtCostFibra.Text = ""
        txtOtros.Text = ""
        txtCostOtros.Text = ""
    End Sub

    Private Sub pbxNuevo_Click(sender As Object, e As EventArgs) Handles pbxNuevo.Click
        Activar()

        lblMsg.Text = "RACION | NUEVO"

        pbxNuevo.BackgroundImage = SITRABO.My.Resources.btnNuevoSi

        LimpiarTXT()

        dgvRaciones.CurrentCell = Nothing

        txtOrigen.Text = "Nuevo"
    End Sub

    Private Sub Activar()
        gbxD.Enabled = True

        pbxNuevo.Enabled = False
        pbxGuardar.Enabled = True
        pbxCancelar.Enabled = True
        pbxModificar.Enabled = False
        pbxSalir.Enabled = False

        dgvRaciones.Enabled = False

        txtRacion.SelectionLength = Len(txtRacion.Text)
        txtRacion.Select()
    End Sub

    Private Sub Cancelar()
        gbxD.Enabled = False

        lblMsg.Text = "RACION"

        txtOrigen.Text = ""

        pbxNuevo.BackgroundImage = SITRABO.My.Resources.btnNuevoNo
        pbxModificar.BackgroundImage = SITRABO.My.Resources.btnModificarNo

        pbxNuevo.Enabled = True
        pbxGuardar.Enabled = False
        pbxCancelar.Enabled = False
        pbxModificar.Enabled = True
        pbxSalir.Enabled = True

        LimpiarTXT()

        dgvRaciones.Enabled = True
        dgvRaciones.CurrentCell = Nothing
    End Sub


    Private Sub pbxGuardar_Click(sender As Object, e As EventArgs) Handles pbxGuardar.Click
        Dim G As New GrabaDatos
        Dim resP As DialogResult

        Try
            If txtRacion.Text = "" Then
                MsgBox("Error: debes ponerle nombre a la racion... !", vbExclamation, "Servico de Alertas")
                txtRacion.Select()
            Else
                If txtCostGrano.Text <> "" And txtGrano.Text = "" Then
                    MsgBox("No has especificado el Grano pero has puesto un precio... !", vbExclamation, "Servico de Alertas")
                    txtGrano.Select()
                Else
                    If txtCostConcentrado.Text <> "" And txtConcentrado.Text = "" Then
                        MsgBox("No has especificado el Concentrado pero has puesto un precio... !", vbExclamation, "Servico de Alertas")
                        txtConcentrado.Select()
                    Else
                        If txtCostFibra.Text <> "" And txtFibra.Text = "" Then
                            MsgBox("No has especificado la Fibra pero has puesto un precio... !", vbExclamation, "Servico de Alertas")
                            txtFibra.Select()
                        Else
                            If txtCostOtros.Text <> "" And txtOtros.Text = "" Then
                                MsgBox("No has especificado Otros pero has puesto un precio... !", vbExclamation, "Servico de Alertas")
                                txtOtros.Select()
                            Else
                                If txtGrano.Text = "" Then
                                    txtCostGrano.Text = "-"
                                End If

                                If txtCostGrano.Text = "" Then
                                    txtCostGrano.Text = "0"
                                End If

                                If txtFibra.Text = "" Then
                                    txtFibra.Text = "-"
                                End If

                                If txtCostFibra.Text = "" Then
                                    txtCostFibra.Text = "0"
                                End If

                                If txtConcentrado.Text = "" Then
                                    txtConcentrado.Text = "-"
                                End If

                                If txtCostConcentrado.Text = "" Then
                                    txtCostConcentrado.Text = "0"
                                End If

                                If txtOtros.Text = "" Then
                                    txtOtros.Text = "-"
                                End If

                                If txtCostOtros.Text = "" Then
                                    txtCostOtros.Text = "0"
                                End If

                                resP = MessageBox.Show("Grabar Alta de Racion ?", "Servico de Alertas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

                                If resP = Windows.Forms.DialogResult.OK Then
                                    If txtOrigen.Text = "Nuevo" Then
                                        frmGuardandoAlta.Show()

                                        frmGuardandoAlta.pgbGuardando.Value = 100
                                        frmGuardandoAlta.lblProgreso.Text = 0 & "%"

                                        frmGuardandoAlta.Refresh()

                                        G.Grabar("Raciones", "NoImagen", "feedlot.insRacion", txtRacion.Text, txtGrano.Text, txtConcentrado.Text, txtFibra.Text, _
                                                 txtOtros.Text, CInt(txtCostGrano.Text), CInt(txtCostConcentrado.Text), CInt(txtCostFibra.Text), _
                                                 CInt(txtCostOtros.Text), CInt(frmLogin.txtID.Text))

                                        Threading.Thread.Sleep(500)
                                    Else
                                        frmGuardandoAlta.Show()

                                        frmGuardandoAlta.pgbGuardando.Value = 100
                                        frmGuardandoAlta.lblProgreso.Text = 0 & "%"

                                        frmGuardandoAlta.Refresh()

                                        G.Grabar("Raciones", "NoImagen", "feedlot.modRacion", CInt(txtID.Text), txtRacion.Text, txtGrano.Text, txtConcentrado.Text, txtFibra.Text, _
                                                 txtOtros.Text, CDbl(txtCostGrano.Text), CDbl(txtCostConcentrado.Text), CDbl(txtCostFibra.Text), _
                                                 CDbl(txtCostOtros.Text))

                                        Threading.Thread.Sleep(500)
                                    End If

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

                                    CargarDGV()

                                    Cancelar()
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

    Private Sub txtRacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRacion.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtGrano.SelectionLength = Len(txtGrano.Text)
            txtGrano.Select()
        End If
    End Sub

    Private Sub txtGrano_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGrano.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtCostGrano.SelectionLength = Len(txtCostGrano.Text)
            txtCostGrano.Select()
        End If
    End Sub

    Private Sub pbxCancelar_Click(sender As Object, e As EventArgs) Handles pbxCancelar.Click
        Cancelar()
    End Sub

    Private Sub txtCostGrano_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCostGrano.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> Keys.Enter And e.KeyChar <> ChrW(8) And e.KeyChar <> ChrW(46) Then
            e.Handled = True
        ElseIf Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtConcentrado.SelectionLength = Len(txtConcentrado.Text)
            txtConcentrado.Select()
        End If
    End Sub

    Private Sub txtConcentrado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtConcentrado.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtCostConcentrado.SelectionLength = Len(txtCostConcentrado.Text)
            txtCostConcentrado.Select()
        End If
    End Sub

    Private Sub txtCostConcentrado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCostConcentrado.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> Keys.Enter And e.KeyChar <> ChrW(8) And e.KeyChar <> ChrW(46) Then
            e.Handled = True
        ElseIf Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtFibra.SelectionLength = Len(txtFibra.Text)
            txtFibra.Select()
        End If
    End Sub

    Private Sub txtFibra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFibra.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtCostFibra.SelectionLength = Len(txtCostFibra.Text)
            txtCostFibra.Select()
        End If
    End Sub

    Private Sub txtCostFibra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCostFibra.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> Keys.Enter And e.KeyChar <> ChrW(8) And e.KeyChar <> ChrW(46) Then
            e.Handled = True
        ElseIf Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtOtros.SelectionLength = Len(txtOtros.Text)
            txtOtros.Select()
        End If
    End Sub

    Private Sub txtOtros_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtOtros.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtCostOtros.SelectionLength = Len(txtCostOtros.Text)
            txtCostOtros.Select()
        End If
    End Sub

    Private Sub txtCostOtros_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCostOtros.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> Keys.Enter And e.KeyChar <> ChrW(8) And e.KeyChar <> ChrW(46) Then
            e.Handled = True
        ElseIf Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            pbxGuardar.Select()
        End If
    End Sub

    Private Sub dgvProductores_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRaciones.CellClick
        If gbxD.Enabled = False Then
            txtID.Text = dgvRaciones.CurrentRow.Cells.Item(0).Value
            txtRacion.Text = dgvRaciones.CurrentRow.Cells.Item(1).Value
            txtGrano.Text = dgvRaciones.CurrentRow.Cells.Item(2).Value
            txtConcentrado.Text = dgvRaciones.CurrentRow.Cells.Item(3).Value
            txtFibra.Text = dgvRaciones.CurrentRow.Cells.Item(4).Value
            txtOtros.Text = dgvRaciones.CurrentRow.Cells.Item(5).Value
            txtCostGrano.Text = dgvRaciones.CurrentRow.Cells.Item(6).Value
            txtCostConcentrado.Text = dgvRaciones.CurrentRow.Cells.Item(7).Value
            txtCostFibra.Text = dgvRaciones.CurrentRow.Cells.Item(8).Value
            txtCostOtros.Text = dgvRaciones.CurrentRow.Cells.Item(9).Value

            If txtCostGrano.Text <> "" Then
                txtCostGrano.Text = Format(CDbl(txtCostGrano.Text), "$ #,##0.00")
            End If

            If txtCostOtros.Text <> "" Then
                txtCostOtros.Text = Format(CDbl(txtCostOtros.Text), "$ #,##0.00")
            End If

            If txtCostFibra.Text <> "" Then
                txtCostFibra.Text = Format(CDbl(txtCostFibra.Text), "$ #,##0.00")
            End If

            If txtCostConcentrado.Text <> "" Then
                txtCostConcentrado.Text = Format(CDbl(txtCostConcentrado.Text), "$ #,##0.00")
            End If
        End If
    End Sub

    Private Sub pbxModificar_Click(sender As Object, e As EventArgs) Handles pbxModificar.Click
        If txtRacion.Text <> "" Then
            If dgvRaciones.CurrentRow.Cells.Item(10).Value = frmLogin.txtID.Text Then
                Activar()
                lblMsg.Text = "RACION | MODIFICAR"
                pbxModificar.BackgroundImage = SITRABO.My.Resources.btnModificarSi
                txtOrigen.Text = "Modificar"

                If txtCostGrano.Text <> "" Then
                    txtCostGrano.Text = Format(CDbl(txtCostGrano.Text), "$ #,##0.00")
                End If

                If txtCostOtros.Text <> "" Then
                    txtCostOtros.Text = Format(CDbl(txtCostOtros.Text), "$ #,##0.00")
                End If

                If txtCostFibra.Text <> "" Then
                    txtCostFibra.Text = Format(CDbl(txtCostFibra.Text), "$ #,##0.00")
                End If

                If txtCostConcentrado.Text <> "" Then
                    txtCostConcentrado.Text = Format(CDbl(txtCostConcentrado.Text), "$ #,##0.00")
                End If
            Else
                MsgBox("No puedes modificar una racion creada por otro usuario", vbExclamation, "Servico de Alertas")
            End If
        Else
            MsgBox("Primero seleccione una ración de la lista... !", vbExclamation, "Servico de Alertas")
        End If
    End Sub

    Private Sub txtCostGrano_Validated(sender As Object, e As EventArgs) Handles txtCostGrano.Validated
        If txtCostGrano.Text <> "" Then
            txtCostGrano.Text = Format(CDbl(txtCostGrano.Text), "$ #,##0.00")
        End If
    End Sub

    Private Sub txtCostOtros_Validated(sender As Object, e As EventArgs) Handles txtCostOtros.Validated
        If txtCostOtros.Text <> "" Then
            txtCostOtros.Text = Format(CDbl(txtCostOtros.Text), "$ #,##0.00")
        End If
    End Sub

    Private Sub txtCostFibra_Validated(sender As Object, e As EventArgs) Handles txtCostFibra.Validated
        If txtCostFibra.Text <> "" Then
            txtCostFibra.Text = Format(CDbl(txtCostFibra.Text), "$ #,##0.00")
        End If
    End Sub

    Private Sub txtCostConcentrado_Validated(sender As Object, e As EventArgs) Handles txtCostConcentrado.Validated
        If txtCostConcentrado.Text <> "" Then
            txtCostConcentrado.Text = Format(CDbl(txtCostConcentrado.Text), "$ #,##0.00")
        End If
    End Sub

End Class