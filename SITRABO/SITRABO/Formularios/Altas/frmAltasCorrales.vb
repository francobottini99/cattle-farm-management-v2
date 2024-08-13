Imports MySql.Data.MySqlClient

Public Class frmAltasCorrales
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

        CargarDGV_CBX()

        pbxNuevo.Select()
    End Sub

    Private Sub CargarDGV_CBX()
        Dim _Dt As New DataTable
        Dim _Ver As New Mostrar

        If frmLogin.txtTipUs.Text = "Super Usuario" Then
            _Dt = _Ver.verCorrales
        Else
            _Dt = _Ver.verCorralesUs(frmLogin.txtID.Text)
        End If

        dgvCorrales.RowTemplate.Height = 35
        dgvCorrales.DataSource = _Dt
        dgvCorrales.Columns("idCorrales").Visible = False
        dgvCorrales.Columns("Superficie").Visible = False
        dgvCorrales.Columns("CabezasTotales").Visible = False
        dgvCorrales.Columns("CAMPO_idCampo").Visible = False
        dgvCorrales.Columns("USUARIOS_idUsuario").Visible = False

        _Dt = _Ver.verCamposUs(frmLogin.txtID.Text)

        For Each _Dr As DataRow In _Dt.Rows
            cbxCampo.Items.Add(_Dr("NombreCampo"))
        Next
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

        dgvCorrales.CurrentCell = Nothing

        txtOrigen.Text = "Nuevo"
    End Sub

    Private Sub LimpiarTXT()
        cbxCampo.Text = ""
        txtNombreCorral.Text = ""
        txtSup.Text = ""
        txtCab.Text = ""
        txtIDCampo.Text = ""
    End Sub

    Private Sub Activar()
        gbxD.Enabled = True

        pbxNuevo.Enabled = False
        pbxGuardar.Enabled = True
        pbxCancelar.Enabled = True
        pbxModificar.Enabled = False
        pbxSalir.Enabled = False

        dgvCorrales.Enabled = False

        cbxCampo.SelectionLength = Len(cbxCampo.Text)
        cbxCampo.Select()
    End Sub

    Private Sub Cancelar()
        gbxD.Enabled = False

        lblMsg.Text = "CORRAL"

        txtOrigen.Text = ""

        pbxNuevo.BackgroundImage = SITRABO.My.Resources.btnNuevoNo
        pbxModificar.BackgroundImage = SITRABO.My.Resources.btnModificarNo

        pbxNuevo.Enabled = True
        pbxGuardar.Enabled = False
        pbxCancelar.Enabled = False
        pbxModificar.Enabled = True
        pbxSalir.Enabled = True

        LimpiarTXT()

        dgvCorrales.CurrentCell = Nothing
        dgvCorrales.Enabled = True
    End Sub


    Private Sub pbxGuardar_Click(sender As Object, e As EventArgs) Handles pbxGuardar.Click
        Dim G As New GrabaDatos
        Dim resP As DialogResult

        Try
            If cbxCampo.Text = "" Then
                MsgBox("Error: debes seleccionar un campo... !", vbExclamation, "Servico de Alertas")
                cbxCampo.Select()
            Else
                If txtNombreCorral.Text = "" Then
                    MsgBox("Error: El corral debe tener un nombre... !", vbExclamation, "Servico de Alertas")
                    txtNombreCorral.Select()
                Else
                    If txtIDCampo.Text = "" Then
                        MsgBox("Error: El campo no existe... !", vbExclamation, "Servico de Alertas")
                        cbxCampo.Select()
                    Else
                        If txtSup.Text = "" Then
                            txtSup.Text = "0"
                        End If

                        If txtCab.Text = "" Then
                            txtCab.Text = "0"
                        End If

                        resP = MessageBox.Show("Grabar Alta del Corral ?", "Servico de Alertas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

                        If resP = Windows.Forms.DialogResult.OK Then
                            If txtOrigen.Text = "Nuevo" Then
                                frmGuardandoAlta.Show()

                                frmGuardandoAlta.pgbGuardando.Value = 100
                                frmGuardandoAlta.lblProgreso.Text = 0 & "%"

                                frmGuardandoAlta.Refresh()

                                G.Grabar("Corrales", "NoImagen", "feedlot.insCorrales", txtNombreCorral.Text, CInt(txtSup.Text), CInt(txtCab.Text), CInt(txtIDCampo.Text), _
                                         CInt(frmLogin.txtID.Text))

                                Threading.Thread.Sleep(500)
                            Else
                                frmGuardandoAlta.Show()

                                frmGuardandoAlta.pgbGuardando.Value = 100
                                frmGuardandoAlta.lblProgreso.Text = 0 & "%"

                                frmGuardandoAlta.Refresh()

                                G.Grabar("Corrales", "NoImagen", "feedlot.modCorrales", CInt(txtID.Text), txtNombreCorral.Text, CInt(txtSup.Text), CInt(txtCab.Text))

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

                            CargarDGV_CBX()

                            Cancelar()
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

    Private Sub cbxCampo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxCampo.KeyPress
        e.Handled = True

        If Asc(e.KeyChar) = Keys.Enter Then
            txtNombreCorral.SelectionLength = Len(txtNombreCorral.Text)
            txtNombreCorral.Select()
        End If
    End Sub

    Private Sub cbxCampo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCampo.SelectedIndexChanged
        Dim _Dt As New DataTable
        Dim _Ver As New Mostrar

        _Dt = _Ver.verCamposUs(frmLogin.txtID.Text)
        txtIDCampo.Text = ""
        For Each _Dr As DataRow In _Dt.Rows
            If _Dr("NombreCampo") = cbxCampo.Text Then
                txtIDCampo.Text = _Dr("IdCampo")
            End If
        Next
    End Sub

    Private Sub pbxCancelar_Click(sender As Object, e As EventArgs) Handles pbxCancelar.Click
        Cancelar()
    End Sub

    Private Sub txtCuit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSup.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> Keys.Enter And e.KeyChar <> ChrW(8) Then
            e.Handled = True
        ElseIf Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtCab.SelectionLength = Len(txtCab.Text)
            txtCab.Select()
        End If
    End Sub
    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombreCorral.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtSup.SelectionLength = Len(txtSup.Text)
            txtSup.Select()
        End If
    End Sub


    Private Sub dgvCorrales_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCorrales.CellClick
        If gbxD.Enabled = False Then
            txtID.Text = dgvCorrales.CurrentRow.Cells.Item(0).Value
            txtNombreCorral.Text = dgvCorrales.CurrentRow.Cells.Item(1).Value
            txtSup.Text = dgvCorrales.CurrentRow.Cells.Item(2).Value
            txtCab.Text = dgvCorrales.CurrentRow.Cells.Item(3).Value

            Dim _Dt As New DataTable
            Dim _Ver As New Mostrar

            _Dt = _Ver.verCamposUs(frmLogin.txtID.Text)
            For Each _Dr As DataRow In _Dt.Rows
                If _Dr("idCampo") = dgvCorrales.CurrentRow.Cells.Item(4).Value Then
                    cbxCampo.Text = _Dr("NombreCampo")
                    txtIDCampo.Text = _Dr("idCampo")
                End If
            Next
        End If
    End Sub

    Private Sub pbxModificar_Click(sender As Object, e As EventArgs) Handles pbxModificar.Click
        If cbxCampo.Text <> "" Then
            If dgvCorrales.CurrentRow.Cells.Item(5).Value = frmLogin.txtID.Text Then
                Activar()
                lblMsg.Text = "CORRAL | MODIFICAR"
                pbxModificar.BackgroundImage = SITRABO.My.Resources.btnModificarSi
                txtOrigen.Text = "Modificar"
            Else
                MsgBox("No puedes modificar un corral creado por otro usuario", vbExclamation, "Servico de Alertas")
            End If
        Else
            MsgBox("Primero seleccione un corral de la lista", vbExclamation, "Servico de Alertas")
        End If
    End Sub

    Private Sub txtCab_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCab.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> Keys.Enter And e.KeyChar <> ChrW(8) Then
            e.Handled = True
        ElseIf Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            pbxGuardar.Select()
        End If
    End Sub

    Private Sub cbxCampo_TextChanged(sender As Object, e As EventArgs) Handles cbxCampo.TextChanged
        txtIDCampo.Text = ""
    End Sub
End Class