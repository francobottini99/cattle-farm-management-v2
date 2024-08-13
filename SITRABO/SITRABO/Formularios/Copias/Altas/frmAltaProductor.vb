Imports MySql.Data.MySqlClient

Public Class frmAltaProductor
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

    Private Sub CargarDGV()
        Dim _Dt As New DataTable
        Dim _Ver As New Mostrar

        If frmLogin.txtTipUs.Text = "Super Usuario" Then
            _Dt = _Ver.verProductor
        Else
            _Dt = _Ver.verProductorUs(frmLogin.txtID.Text)
        End If
        dgvProductores.RowTemplate.Height = 35
        dgvProductores.DataSource = _Dt
        dgvProductores.Columns("idProductor").Visible = False
        dgvProductores.Columns("Direccion").Visible = False
        dgvProductores.Columns("Localidad").Visible = False
        dgvProductores.Columns("CP").Visible = False
        dgvProductores.Columns("CUIT").Visible = False
        dgvProductores.Columns("USUARIOS_idUsuario").Visible = False
    End Sub

    Private Sub LimpiarTXT()
        txtNombre.Text = ""
        txtDir.Text = ""
        txtLoc.Text = ""
        txtCP.Text = ""
        txtCuit.Text = ""
    End Sub

    Private Sub pbxNuevo_Click(sender As Object, e As EventArgs) Handles pbxNuevo.Click
        Activar()

        lblMsg.Text = "PRODUCTOR | NUEVO"

        pbxNuevo.BackgroundImage = SITRABO.My.Resources.btnNuevoSi

        LimpiarTXT()

        dgvProductores.CurrentCell = Nothing

        txtOrigen.Text = "Nuevo"
    End Sub

    Private Sub Activar()
        gbxD.Enabled = True

        pbxNuevo.Enabled = False
        pbxGuardar.Enabled = True
        pbxCancelar.Enabled = True
        pbxModificar.Enabled = False
        pbxSalir.Enabled = False

        dgvProductores.Enabled = False

        txtNombre.SelectionLength = Len(txtNombre.Text)
        txtNombre.Select()
    End Sub

    Private Sub Cancelar()
        gbxD.Enabled = False

        lblMsg.Text = "PRODUCTOR"

        txtOrigen.Text = ""

        pbxNuevo.BackgroundImage = SITRABO.My.Resources.btnNuevoNo
        pbxModificar.BackgroundImage = SITRABO.My.Resources.btnModificarNo

        pbxNuevo.Enabled = True
        pbxGuardar.Enabled = False
        pbxCancelar.Enabled = False
        pbxModificar.Enabled = True
        pbxSalir.Enabled = True

        LimpiarTXT()

        dgvProductores.CurrentCell = Nothing

        dgvProductores.Enabled = True
    End Sub


    Private Sub pbxGuardar_Click(sender As Object, e As EventArgs) Handles pbxGuardar.Click
        Dim G As New GrabaDatos
        Dim resP As DialogResult
        Dim _Ver As New Mostrar
        Dim _Dt As New DataTable

        Try
            If txtNombre.Text = "" Then
                MsgBox("Error: Razón Social es un campo obligatorio... !", vbExclamation, "Servico de Alertas")
                txtNombre.Select()
            Else
                If txtDir.Text = "" Then
                    txtDir.Text = "-"
                End If

                If txtLoc.Text = "" Then
                    txtLoc.Text = "-"
                End If

                If txtCP.Text = "" Then
                    txtCP.Text = "-"
                End If

                If txtCuit.Text = "" Then
                    txtCuit.Text = "-"
                End If

                resP = MessageBox.Show("Grabar Alta del Productor ?", "Servico de Alertas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

                If resP = Windows.Forms.DialogResult.OK Then
                    If txtOrigen.Text = "Nuevo" Then
                        frmGuardandoAlta.Show()

                        frmGuardandoAlta.pgbGuardando.Value = 100
                        frmGuardandoAlta.lblProgreso.Text = 0 & "%"

                        frmGuardandoAlta.Refresh()

                        G.Grabar("Productor", "NoImagen", "feedlot.insProductor", txtNombre.Text, txtDir.Text, txtLoc.Text, txtCP.Text, _
                                 txtCuit.Text, CInt(frmLogin.txtID.Text))

                        Threading.Thread.Sleep(500)
                    Else
                        frmGuardandoAlta.Show()

                        frmGuardandoAlta.pgbGuardando.Value = 100
                        frmGuardandoAlta.lblProgreso.Text = 0 & "%"

                        frmGuardandoAlta.Refresh()

                        G.Grabar("Productor", "NoImagen", "feedlot.modProductor", CInt(txtID.Text), txtNombre.Text, txtDir.Text, txtLoc.Text, txtCP.Text, _
                        txtCuit.Text)

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

    Private Sub txtCuit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCuit.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            pbxGuardar.Select()
        End If
    End Sub

    Private Sub txtCuit_Validated(sender As Object, e As EventArgs) Handles txtCuit.Validated
        Dim X As Integer
        Dim cuitSinGuion As String = ""
        Dim caracTer As String = ""
        Dim valCuit As New ValidaCUIT

        If txtCuit.Text <> "" Then
            For X = 1 To Len(txtCuit.Text)
                caracTer = Mid(txtCuit.Text, X, 1)
                If IsNumeric(caracTer) Then
                    cuitSinGuion = cuitSinGuion & caracTer
                End If
            Next X

            If Len(cuitSinGuion) <> 11 Then
                MsgBox("Error: Cuit Inválido... !", vbExclamation, "Servico de Alertas")
                txtCuit.Text = ""
                txtCuit.Select()
            Else
                If valCuit.CUIT(cuitSinGuion) Then
                    Dim Ct1, Ct2, Ct3 As String
                    Ct1 = Mid(cuitSinGuion, 1, 2)
                    Ct2 = Mid(cuitSinGuion, 3, 8)
                    Ct3 = Mid(cuitSinGuion, 11, 1)
                    txtCuit.Text = Ct1 & "-" & Ct2 & "-" & Ct3
                Else
                    MsgBox("Error: Cuit Inválido... !", vbExclamation, "Servico de Alertas")
                    txtCuit.Text = ""
                    txtCuit.Select()
                End If
            End If
        End If
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtDir.SelectionLength = Len(txtDir.Text)
            txtDir.Select()
        End If
    End Sub

    Private Sub txtDir_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDir.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtLoc.SelectionLength = Len(txtLoc.Text)
            txtLoc.Select()
        End If
    End Sub

    Private Sub txtLoc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLoc.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtCP.SelectionLength = Len(txtCP.Text)
            txtCP.Select()
        End If
    End Sub

    Private Sub txtCP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCP.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtCuit.SelectionLength = Len(txtCuit.Text)
            txtCuit.Select()
        End If
    End Sub

    Private Sub dgvProductores_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProductores.CellClick
        If gbxD.Enabled = False Then
            txtID.Text = dgvProductores.CurrentRow.Cells.Item(0).Value
            txtNombre.Text = dgvProductores.CurrentRow.Cells.Item(1).Value
            txtDir.Text = dgvProductores.CurrentRow.Cells.Item(2).Value
            txtLoc.Text = dgvProductores.CurrentRow.Cells.Item(3).Value
            txtCP.Text = dgvProductores.CurrentRow.Cells.Item(4).Value
            txtCuit.Text = dgvProductores.CurrentRow.Cells.Item(5).Value
        End If
    End Sub

    Private Sub pbxModificar_Click(sender As Object, e As EventArgs) Handles pbxModificar.Click
        If txtNombre.Text <> "" Then
            If dgvProductores.CurrentRow.Cells.Item(6).Value = frmLogin.txtID.Text Then
                Activar()
                lblMsg.Text = "PRODUCTOR | MODIFICAR"
                pbxModificar.BackgroundImage = SITRABO.My.Resources.btnModificarSi
                txtOrigen.Text = "Modificar"
            Else
                MsgBox("No puedes modificar un productor creado por otro usuario", vbExclamation, "Servico de Alertas")
            End If
        Else
            MsgBox("Primero seleccione un productor de la lista !", vbExclamation, "Servico de Alertas")
        End If
    End Sub
End Class