Imports MySql.Data.MySqlClient

Public Class frmAltaCampo
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
            _Dt = _Ver.verCampos
        Else
            _Dt = _Ver.verCamposUs(frmLogin.txtID.Text)
        End If

        dgvCampos.RowTemplate.Height = 35
        dgvCampos.DataSource = _Dt
        dgvCampos.Columns("idCampo").Visible = False
        dgvCampos.Columns("Propietario").Visible = False
        dgvCampos.Columns("Localidad").Visible = False
        dgvCampos.Columns("Provincia").Visible = False
        dgvCampos.Columns("Superficie").Visible = False
        dgvCampos.Columns("USUARIOS_idUsuario").Visible = False
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
        Activar()

        lblMsg.Text = "CAMPO | NUEVO"

        pbxNuevo.BackgroundImage = SITRABO.My.Resources.btnNuevoSi

        LimpiarTXT()

        dgvCampos.CurrentCell = Nothing

        txtOrigen.Text = "Nuevo"
    End Sub

    Private Sub Activar()
        gbxD.Enabled = True

        pbxNuevo.Enabled = False
        pbxGuardar.Enabled = True
        pbxCancelar.Enabled = True
        pbxModificar.Enabled = False
        pbxSalir.Enabled = False

        txtCampo.SelectionLength = Len(txtCampo.Text)
        txtCampo.Select()

        dgvCampos.Enabled = False
    End Sub

    Private Sub LimpiarTXT()
        txtCampo.Text = ""
        txtPropietario.Text = ""
        txtLoc.Text = ""
        txtProv.Text = ""
        txtSup.Text = ""
    End Sub

    Private Sub Cancelar()
        gbxD.Enabled = False

        lblMsg.Text = "CAMPO"

        txtOrigen.Text = ""

        pbxNuevo.Enabled = True
        pbxGuardar.Enabled = False
        pbxCancelar.Enabled = False
        pbxModificar.Enabled = True
        pbxSalir.Enabled = True

        pbxNuevo.BackgroundImage = SITRABO.My.Resources.btnNuevoNo
        pbxModificar.BackgroundImage = SITRABO.My.Resources.btnModificarNo

        dgvCampos.Enabled = True
        dgvCampos.CurrentCell = Nothing

        LimpiarTXT()
    End Sub


    Private Sub pbxGuardar_Click(sender As Object, e As EventArgs) Handles pbxGuardar.Click
        Dim G As New GrabaDatos
        Dim resP As DialogResult
        Dim _Ver As New Mostrar
        Dim _Dt As New DataTable

        Try
            If txtCampo.Text = "" Then
                MsgBox("Error: Nombre Campo es un campo obligatorio... !", vbInformation, "Servico de Alertas")
                txtCampo.Select()
            Else
                If txtPropietario.Text = "" Then
                    MsgBox("Error: Propietario es un campo obligatorio... !", vbInformation, "Servico de Alertas")
                    txtPropietario.Select()
                Else
                    If txtLoc.Text = "" Then
                        MsgBox("Error: Localidad es un campo obligatorio... !", vbInformation, "Servico de Alertas")
                        txtLoc.Select()
                    Else
                        If txtProv.Text = "" Then
                            MsgBox("Error: Provincia es un campo obligatorio... !", vbInformation, "Servico de Alertas")
                            txtProv.Select()
                        Else
                            If txtSup.Text = "" Then
                                MsgBox("Error: Superficie es un campo obligatorio... !", vbInformation, "Servico de Alertas")
                                txtSup.Select()
                            Else
                                If txtOrigen.Text = "Nuevo" Then
                                    resP = MessageBox.Show("Grabar Alta del Campo ?", "Servico de Alertas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

                                    If resP = Windows.Forms.DialogResult.OK Then
                                        frmGuardandoAlta.Show()

                                        frmGuardandoAlta.pgbGuardando.Value = 100
                                        frmGuardandoAlta.lblProgreso.Text = 0 & "%"

                                        frmGuardandoAlta.Refresh()

                                        G.Grabar("Campo", "NoImagen", "feedlot.insCampos", txtCampo.Text, txtPropietario.Text, txtLoc.Text, txtProv.Text, _
                                                 txtSup.Text, CInt(frmLogin.txtID.Text))

                                        Threading.Thread.Sleep(500)
                                    End If
                                Else
                                    resP = MessageBox.Show("Grabar Modificacion del Campo ?", "Servico de Alertas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

                                    If resP = Windows.Forms.DialogResult.OK Then
                                        frmGuardandoAlta.Show()

                                        frmGuardandoAlta.pgbGuardando.Value = 100
                                        frmGuardandoAlta.lblProgreso.Text = 0 & "%"

                                        frmGuardandoAlta.Refresh()

                                        G.Grabar("Campo", "NoImagen", "feedlot.modCampo", CInt(txtID.Text), txtCampo.Text, txtPropietario.Text, txtLoc.Text, txtProv.Text, _
                                        txtSup.Text)

                                        Threading.Thread.Sleep(500)
                                    End If
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

    Private Sub txtCampo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCampo.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtPropietario.SelectionLength = Len(txtPropietario.Text)
            txtPropietario.Select()
        End If
    End Sub
    Private Sub txtPropietario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPropietario.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtLoc.SelectionLength = Len(txtLoc.Text)
            txtLoc.Select()
        End If
    End Sub

    Private Sub txtLoc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLoc.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtProv.SelectionLength = Len(txtProv.Text)
            txtProv.Select()
        End If
    End Sub

    Private Sub txtProv_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtProv.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtSup.SelectionLength = Len(txtSup.Text)
            txtSup.Select()
        End If
    End Sub

    Private Sub txtSup_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSup.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> Keys.Enter And e.KeyChar <> ChrW(8) Then
            e.Handled = True
        ElseIf Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            pbxGuardar.Select()
        End If
    End Sub

    Private Sub dgvProductores_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCampos.CellClick
        If e.RowIndex > -1 Then
            If gbxD.Enabled = False Then
                txtID.Text = dgvCampos.CurrentRow.Cells.Item(0).Value
                txtCampo.Text = dgvCampos.CurrentRow.Cells.Item(1).Value
                txtPropietario.Text = dgvCampos.CurrentRow.Cells.Item(2).Value
                txtLoc.Text = dgvCampos.CurrentRow.Cells.Item(3).Value
                txtProv.Text = dgvCampos.CurrentRow.Cells.Item(4).Value
                txtSup.Text = dgvCampos.CurrentRow.Cells.Item(5).Value
            End If
        End If
    End Sub

    Private Sub pbxModificar_Click(sender As Object, e As EventArgs) Handles pbxModificar.Click
        If txtCampo.Text <> "" Then
            If dgvCampos.CurrentRow.Cells.Item(6).Value = frmLogin.txtID.Text Then
                Activar()

                lblMsg.Text = "CAMPO | MODIFICAR"

                pbxModificar.BackgroundImage = SITRABO.My.Resources.btnModificarSi

                txtOrigen.Text = "Modificar"
            Else
                MsgBox("No puedes modificar un campo creado por otro usuario", vbInformation, "Servico de Alertas")
            End If
        Else
            MsgBox("Primero seleccione un campo de la lista", vbInformation, "Servico de Alertas")
        End If
    End Sub

End Class