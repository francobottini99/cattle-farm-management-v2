Imports MySql.Data.MySqlClient

Public Class frmAltasCategorias
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
            _Dt = _Ver.verCategorias
        Else
            _Dt = _Ver.verCategoriasUs(frmLogin.txtID.Text)
        End If

        dgvCategorias.RowTemplate.Height = 35
        dgvCategorias.DataSource = _Dt
        dgvCategorias.Columns("idCategorias").Visible = False
        dgvCategorias.Columns("USUARIOS_idUsuario").Visible = False
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

        lblMsg.Text = "CATEGORIA | NUEVO"

        pbxNuevo.BackgroundImage = SITRABO.My.Resources.btnNuevoSi

        txtCatg.Text = ""

        dgvCategorias.CurrentCell = Nothing

        txtOrigen.Text = "Nuevo"
    End Sub

    Private Sub Activar()
        gbxD.Enabled = True

        pbxNuevo.Enabled = False
        pbxGuardar.Enabled = True
        pbxCancelar.Enabled = True
        pbxModificar.Enabled = False
        pbxSalir.Enabled = False

        dgvCategorias.Enabled = False

        txtCatg.SelectionLength = Len(txtCatg.Text)
        txtCatg.Select()
    End Sub

    Private Sub Cancelar()
        gbxD.Enabled = False

        lblMsg.Text = "CATEGORIA"

        txtOrigen.Text = ""

        pbxNuevo.BackgroundImage = SITRABO.My.Resources.btnNuevoNo
        pbxModificar.BackgroundImage = SITRABO.My.Resources.btnModificarNo

        pbxNuevo.Enabled = True
        pbxGuardar.Enabled = False
        pbxCancelar.Enabled = False
        pbxModificar.Enabled = True
        pbxSalir.Enabled = True

        dgvCategorias.Enabled = True
        dgvCategorias.CurrentCell = Nothing

        txtCatg.Text = ""
    End Sub


    Private Sub pbxGuardar_Click(sender As Object, e As EventArgs) Handles pbxGuardar.Click
        Dim G As New GrabaDatos
        Dim resP As DialogResult

        Try
            If txtCatg.Text = "" Then
                MsgBox("Error: debes ponerle un nombre a la categoria... !", vbExclamation, "Servico de Alertas")
                txtCatg.Select()
            Else
                resP = MessageBox.Show("Grabar Alta de Categoria ?", "Servico de Alertas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

                If resP = Windows.Forms.DialogResult.OK Then
                    If txtOrigen.Text = "Nuevo" Then
                        frmGuardandoAlta.Show()

                        frmGuardandoAlta.pgbGuardando.Value = 100
                        frmGuardandoAlta.lblProgreso.Text = 0 & "%"

                        frmGuardandoAlta.Refresh()

                        G.Grabar("Categorias", "NoImagen", "feedlot.insCategorias", txtCatg.Text, cbxSexo.Text, CInt(frmLogin.txtID.Text))

                        Threading.Thread.Sleep(500)
                    Else
                        frmGuardandoAlta.Show()

                        frmGuardandoAlta.pgbGuardando.Value = 100
                        frmGuardandoAlta.lblProgreso.Text = 0 & "%"

                        frmGuardandoAlta.Refresh()

                        G.Grabar("Categorias", "NoImagen", "feedlot.modCategoria", CInt(txtID.Text), txtCatg.Text, cbxSexo.Text)

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

    Private Sub dgvProductores_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCategorias.CellClick
        If gbxD.Enabled = False Then
            txtID.Text = dgvCategorias.CurrentRow.Cells.Item(0).Value
            txtCatg.Text = dgvCategorias.CurrentRow.Cells.Item(1).Value
        End If
    End Sub

    Private Sub pbxModificar_Click(sender As Object, e As EventArgs) Handles pbxModificar.Click
        If txtCatg.Text <> "" Then
            If dgvCategorias.CurrentRow.Cells.Item(2).Value = frmLogin.txtID.Text Then
                Activar()
                lblMsg.Text = "CATEGORIA | MODIFICAR"
                pbxModificar.BackgroundImage = SITRABO.My.Resources.btnModificarSi
                txtOrigen.Text = "Modificar"
            Else
                MsgBox("No puedes modificar una categoría creada por otro usuario", vbExclamation, "Servico de Alertas")
            End If
        Else
            MsgBox("Primero seleccione un categoría de la lista", vbExclamation, "Servico de Alertas")
        End If
    End Sub

    Private Sub txtCatg_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCatg.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            pbxGuardar.Select()
        End If
    End Sub

End Class