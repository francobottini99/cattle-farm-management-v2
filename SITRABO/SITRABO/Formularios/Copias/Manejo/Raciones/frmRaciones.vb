Public Class frmRaciones
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

    Private Sub pbxAggAliemnto_GotFocus(sender As Object, e As EventArgs) Handles pbxAggAliemnto.GotFocus
        pbxAggAliemnto.BackgroundImage = SITRABO.My.Resources.btnAlimentosSi
    End Sub

    Private Sub pbxAggAliemnto_LostFocus(sender As Object, e As EventArgs) Handles pbxAggAliemnto.LostFocus
        pbxAggAliemnto.BackgroundImage = SITRABO.My.Resources.btnAlimentosNo
    End Sub

    Private Sub pbxAggAliemnto_MouseEnter(sender As Object, e As EventArgs) Handles pbxAggAliemnto.MouseEnter
        pbxAggAliemnto.BackgroundImage = SITRABO.My.Resources.btnAlimentosSi
    End Sub

    Private Sub pbxAggAliemnto_MouseLeave(sender As Object, e As EventArgs) Handles pbxAggAliemnto.MouseLeave
        pbxAggAliemnto.BackgroundImage = SITRABO.My.Resources.btnAlimentosNo
    End Sub

    Private Sub pbxAggRestricciones_GotFocus(sender As Object, e As EventArgs) Handles pbxAggRestricciones.GotFocus
        pbxAggRestricciones.BackgroundImage = SITRABO.My.Resources.btnRestriccionesSi
    End Sub

    Private Sub pbxAggRestricciones_LostFocus(sender As Object, e As EventArgs) Handles pbxAggRestricciones.LostFocus
        pbxAggRestricciones.BackgroundImage = SITRABO.My.Resources.btnRestriccionesNo
    End Sub

    Private Sub pbxAggRestricciones_MouseEnter(sender As Object, e As EventArgs) Handles pbxAggRestricciones.MouseEnter
        pbxAggRestricciones.BackgroundImage = SITRABO.My.Resources.btnRestriccionesSi
    End Sub

    Private Sub pbxAggRestricciones_MouseLeave(sender As Object, e As EventArgs) Handles pbxAggRestricciones.MouseLeave
        pbxAggRestricciones.BackgroundImage = SITRABO.My.Resources.btnRestriccionesNo
    End Sub

    Private Sub pbxFormular_GotFocus(sender As Object, e As EventArgs) Handles pbxFormular.GotFocus
        pbxFormular.BackgroundImage = SITRABO.My.Resources.btnFormularSi
    End Sub

    Private Sub pbxFormular_LostFocus(sender As Object, e As EventArgs) Handles pbxFormular.LostFocus
        pbxFormular.BackgroundImage = SITRABO.My.Resources.btnFormularNo
    End Sub

    Private Sub pbxFormular_MouseEnter(sender As Object, e As EventArgs) Handles pbxFormular.MouseEnter
        pbxFormular.BackgroundImage = SITRABO.My.Resources.btnFormularSi
    End Sub

    Private Sub pbxFormular_MouseLeave(sender As Object, e As EventArgs) Handles pbxFormular.MouseLeave
        pbxFormular.BackgroundImage = SITRABO.My.Resources.btnFormularNo
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

    Private Sub PbxAggAliemnto_Click(sender As Object, e As EventArgs) Handles pbxAggAliemnto.Click
        frmListaAlimentos.ShowDialog()
        FormatoDgv()
    End Sub

    Private Sub dgvRacion_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRacion.CellClick
        If e.RowIndex > -1 Then
            If e.ColumnIndex = dgvRacion.Columns("btnElim").Index Then
                Dim _Dt As DataTable

                _Dt = dgvRacion.DataSource
                _Dt.Rows.RemoveAt(dgvRacion.CurrentRow.Index)

                dgvRacion.DataSource = Nothing
                dgvRacion.Update()
                dgvRacion.DataSource = _Dt

                FormatoDgv()

                If dgvRacion.Rows.Count > 0 Then
                    dgvRacion.ColumnHeadersVisible = True
                Else
                    dgvRacion.DataSource = Nothing
                    dgvRacion.Columns.Clear()
                    dgvRacion.ColumnHeadersVisible = False
                End If
            End If
        End If
    End Sub

    Private Sub FormatoDgv()
        dgvRacion.Columns("idAlimentos").Visible = False

        dgvRacion.Columns("Tipo").HeaderText = "TIPO"
        dgvRacion.Columns("NombreComun").HeaderText = "NOMBRE COMÚN"
        dgvRacion.Columns("Fenologia").HeaderText = "EST. FENOLÓGICO"
        dgvRacion.Columns("%MateriaSeca").HeaderText = "% M.S."
        dgvRacion.Columns("%Digestibilidad").HeaderText = "% DIGESTIB"
        dgvRacion.Columns("EnergiaMetabolica").HeaderText = "E.M. (Mcal/Kg)"
        dgvRacion.Columns("%ProteinaBruta").HeaderText = "% P.B."
        dgvRacion.Columns("%Calcio").HeaderText = "% CALCIO"
        dgvRacion.Columns("%Fosforo").HeaderText = "% FOSFORO"
        dgvRacion.Columns("%Magnesio").HeaderText = "% MAGNECIO"
        dgvRacion.Columns("FDA").HeaderText = "% F.D.A."
        dgvRacion.Columns("LDA").HeaderText = "% L.D.A."
        dgvRacion.Columns("Costo").HeaderText = "COSTO ($)"

        dgvRacion.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        dgvRacion.Columns("Tipo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
        dgvRacion.Columns("Fenologia").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvRacion.Columns("%MateriaSeca").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        dgvRacion.Columns("%Digestibilidad").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight

        dgvRacion.Columns("EnergiaMetabolica").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        dgvRacion.Columns("%ProteinaBruta").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        dgvRacion.Columns("%Calcio").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        dgvRacion.Columns("%Fosforo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        dgvRacion.Columns("%Magnesio").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        dgvRacion.Columns("FND").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        dgvRacion.Columns("FDA").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        dgvRacion.Columns("LDA").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        dgvRacion.Columns("Costo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight

        dgvRacion.CurrentCell = Nothing
    End Sub

    Private Sub FrmRaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ctlNuevo As Control = DirectCast(pbxNuevo, Control)
        Dim keyprNuevo = New KeyPressEventHandler(AddressOf btnNuevo)
        Dim ctlGuardar As Control = DirectCast(pbxGuardar, Control)
        Dim keyprGuardar = New KeyPressEventHandler(AddressOf btnGuardar)

        AddHandler ctlNuevo.KeyPress, keyprNuevo
        AddHandler ctlGuardar.KeyPress, keyprGuardar

        Me.Text = "Si.Tra.Bo. - Sistema de Trazabilidad Bovina" & " - USUARIO: " & frmLogin.txtNom.Text & " " & frmLogin.txtAp.Text & " -"

        Dim _Ver As New Mostrar
        Dim _Dt As DataTable

        _Dt = _Ver.verTablaAlimentos()

        dgvRestricciones.DataSource = _Dt

        pbxNuevo.Select()
    End Sub

    Private Sub btnNuevo(ByVal sender As System.Object, ByVal e As KeyPressEventArgs)
        If Asc(e.KeyChar) = Keys.Enter Then
            PbxNuevo_Click(1, Nothing)
        End If
    End Sub

    Private Sub btnGuardar(ByVal sender As System.Object, ByVal e As KeyPressEventArgs)
        If Asc(e.KeyChar) = Keys.Enter Then
            PbxGuardar_Click(1, Nothing)
        End If
    End Sub

    Private Sub Activar()
        gbxPantallaInicio.Visible = False
        gbxRaciones.Visible = True
        pbxNuevo.Enabled = False
        pbxGuardar.Enabled = True
        pbxCancelar.Enabled = True
        pbxModificar.Enabled = False
        pbxSalir.Enabled = False
    End Sub

    Private Sub Cancelar()
        gbxPantallaInicio.Visible = True
        gbxRaciones.Visible = False
        pbxNuevo.Enabled = True
        pbxGuardar.Enabled = False
        pbxCancelar.Enabled = False
        pbxModificar.Enabled = True
        pbxSalir.Enabled = True
    End Sub


    Private Sub PbxSalir_Click(sender As Object, e As EventArgs) Handles pbxSalir.Click
        Me.Close()
    End Sub

    Private Sub PbxNuevo_Click(sender As Object, e As EventArgs) Handles pbxNuevo.Click
        Activar()
        pbxNuevo.BackgroundImage = SITRABO.My.Resources.btnNuevoSi

        txtKGTotales.Select()
    End Sub

    Private Sub PbxGuardar_Click(sender As Object, e As EventArgs) Handles pbxGuardar.Click

    End Sub

    Private Sub PbxCancelar_Click(sender As Object, e As EventArgs) Handles pbxCancelar.Click
        Cancelar()
    End Sub

End Class