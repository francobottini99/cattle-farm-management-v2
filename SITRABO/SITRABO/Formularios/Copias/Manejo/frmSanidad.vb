Imports MySql.Data.MySqlClient

Public Class frmSanidad
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

    Private Sub frmSanidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim _Dt As DataTable
        Dim _Ver As New Mostrar

        _Dt = _Ver.verStockUs(frmLogin.txtID.Text)

        Dim ctlNuevo As Control = DirectCast(pbxNuevo, Control)
        Dim keyprNuevo = New KeyPressEventHandler(AddressOf btnNuevo)

        Dim ctlGuardar As Control = DirectCast(pbxGuardar, Control)
        Dim keyprGuardar = New KeyPressEventHandler(AddressOf btnGuardar)

        AddHandler ctlNuevo.KeyPress, keyprNuevo
        AddHandler ctlGuardar.KeyPress, keyprGuardar

        Me.Text = "Si.Tra.Bo. - Sistema de Trazabilidad Bovina" & " - USUARIO: " & frmLogin.txtNom.Text & " " & frmLogin.txtAp.Text & " -"

        lblFecha.Text = Date.Now.Date

        mtcFecha.MaxDate = Date.Now.Date

        If _Dt.Rows.Count > 0 Then
            mtcFecha.MinDate = _Dt.Rows(0).Item(1)
        Else
            MsgBox("No existen animales en el sistema... !", vbInformation, "Servico de Alertas")
            Me.Close()
        End If

        FechaStock(lblFecha.Text)

        pbxNuevo.Select()
    End Sub

    Private Sub CargarTropas()
        Dim _DtStk, _DtT, _DtFin As New DataTable
        Dim FechaStk As Date
        Dim _Ver As New Mostrar

        _DtT = _Ver.verTropaUs(frmLogin.txtID.Text)

        _DtFin.Columns.Add()
        _DtFin.Columns.Add()
        _DtFin.Columns.Add()

        For Each _Dr As DataRow In _DtT.Rows
            If FechaStk = Nothing Then
                FechaStk = FechaStock(lblFecha.Text)
            End If

            _DtStk = _Ver.verStock_Fecha_Tropa_Us(FechaStk, _Dr("idTropa"), frmLogin.txtID.Text)

            If _DtStk.Rows.Count > 0 Then
                _DtFin.Rows.Add(_Dr("idTropa"), _Dr("NombreTropa"), _DtStk.Rows.Count)
            End If
        Next

        dgvTropa.RowTemplate.Height = 25
        dgvTropa.DataSource = _DtFin
        dgvTropa.ClearSelection()
        dgvTropa.Columns(0).Visible = False
        dgvTropa.Columns(2).Visible = False

        dgvTropa.CurrentCell = Nothing
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

    Dim CrtlT As Boolean = False

    Private Sub CargarDetalleTropa()
        Dim _DtStk, _DtFin As New DataTable
        Dim _Ver As New Mostrar

        _DtFin.Columns.Add()
        _DtFin.Columns.Add()

        _DtStk = _Ver.verStocFechaUs(frmLogin.txtID.Text, FechaStock(lblFecha.Text))

        For Each _Dr As DataRow In _DtStk.Rows
            If CrtlT = False Then
                If _Dr("TROPA_idTropa") = dgvTropa.CurrentRow.Cells.Item(0).Value Then
                    _DtFin.Rows.Add(_Dr("DETALLE_TROPA_idDetTropa"), _Dr("Caravana"))
                End If
            Else
                _DtFin.Rows.Add(_Dr("DETALLE_TROPA_idDetTropa"), _Dr("Caravana"))
            End If
        Next

        dgvDetTropa.RowTemplate.Height = 25
        dgvDetTropa.DataSource = _DtFin

        dgvDetTropa.ClearSelection()
        dgvDetTropa.Columns(0).Visible = False

        dgvDetTropa.CurrentCell = Nothing
    End Sub

    Private Sub Activar()
        pbxNuevo.Enabled = False
        pbxGuardar.Enabled = True
        pbxCancelar.Enabled = True
        pbxModificar.Enabled = False
        pbxSalir.Enabled = False
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

        gbxNuevo.Visible = False
        gbxModificar.Visible = False
        gbxPantallaInicio.Visible = True

        dgvTropa.Visible = True
        dgvDetTropa.Visible = True

        lblLineDT.Visible = True
        lblLineT.Visible = True

        lblTituloDT.Visible = True
        lblTituloT.Visible = True

        lblNotaDT.Visible = True
        lblNotaTTodas.Visible = True
        lblNotaTUna.Visible = True

        dgvSanidadesModificar.Visible = False

        lblLineSM.Visible = False

        lblTituloSM.Visible = False

        btnCancelarDetalles.Enabled = True

        Dim rows As Integer = dgvSanidadesModificar.Rows.Count - 1

        If dgvSanidadesModificar.Rows.Count > 0 Then
            For j As Integer = rows To 0 Step -1
                dgvSanidadesModificar.Rows.Remove(dgvSanidadesModificar.Rows(j))
            Next
        End If

        CancelarDetalles()

        dgvTropa.DataSource = Nothing
    End Sub

    Private Sub pbxCancelar_Click(sender As Object, e As EventArgs) Handles pbxCancelar.Click
        Cancelar()
    End Sub

    Private Sub pbxNuevo_Click(sender As Object, e As EventArgs) Handles pbxNuevo.Click
        Activar()

        pbxNuevo.BackgroundImage = SITRABO.My.Resources.btnNuevoSi
        pbxModificar.BackgroundImage = SITRABO.My.Resources.btnModificarNo

        gbxNuevo.Visible = True
        gbxPantallaInicio.Visible = False

        txtOrigen.Text = "Nuevo"

        CargarTropas()
    End Sub

    Private Sub pbxGuardar_Click(sender As Object, e As EventArgs) Handles pbxGuardar.Click
        Dim G As New GrabaDatos
        Dim resP As DialogResult

        Try
            If txtTratamiento.Text = "" Then
                MsgBox("Tratamiento es un campo obligatorio... !", vbInformation, "Servico de Alertas")
                txtTratamiento.Select()
            Else
                If txtImp.Text = "" Then
                    MsgBox("Importe es un campo obligatorio... !", vbInformation, "Servico de Alertas")
                    txtImp.Select()
                Else
                    If txtOrigen.Text = "Nuevo" Then
                        resP = MessageBox.Show("Grabar Sanidad ?", "Servico de Alertas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                    Else
                        resP = MessageBox.Show("Modificar Sanidad ?", "Servico de Alertas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                    End If

                    If resP = Windows.Forms.DialogResult.OK Then
                        If txtObs.Text = "" Then
                            txtObs.Text = "-"
                        End If

                        If txtOrigen.Text = "Nuevo" Then
                            If lblAnimales.Text = "Todos" Then
                                For i As Integer = 0 To dgvDetTropa.Rows.Count - 1
                                    G.Grabar("Sanidad", "NoImagen", "feedlot.insSanidad", Format(CDate(lblFecha.Text), "yyyy/MM/dd"), txtTratamiento.Text, CDbl(lblImpCab.Text), txtObs.Text, _
                                    CInt(dgvDetTropa.Rows(i).Cells.Item(0).Value), CInt(frmLogin.txtID.Text))
                                Next
                            Else
                                G.Grabar("Sanidad", "NoImagen", "feedlot.insSanidad", Format(CDate(lblFecha.Text), "yyyy/MM/dd"), txtTratamiento.Text, CDbl(txtImp.Text), txtObs.Text, _
                                    CInt(dgvDetTropa.CurrentRow.Cells.Item(0).Value), CInt(frmLogin.txtID.Text))
                            End If

                            For i As Integer = 0 To dgvTropa.RowCount - 1
                                If dgvTropa.Rows(i).Selected Then
                                    G.Grabar("tropa_bloqueo_mod", "NoImagen", "feedlot.modEstadoMod", "NO", dgvTropa.Rows(i).Cells.Item(0).Value)
                                End If
                            Next
                        Else
                            For i As Integer = 0 To dgvSanidadesModificar.Rows.Count - 1
                                G.Grabar("Sanidad", "NoImagen", "feedlot.modSanidad", CInt(dgvSanidadesModificar.Rows(i).Cells.Item("idSanidad").Value), Format(CDate(dgvSanidadesModificar.Rows(i).Cells.Item("Fecha").Value), "yyyy/MM/dd"),
                                         txtTratamiento.Text, CDbl(txtImp.Text), txtObs.Text)

                                G.Grabar("tropa_bloqueo_mod", "NoImagen", "feedlot.modEstadoMod", "NO", dgvSanidadesModificar.Rows(i).Cells.Item("idTropa").Value)
                            Next
                        End If

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

    Private Sub dgvTropa_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTropa.CellClick
        CargarDetalleTropa()
    End Sub

    Private Sub CancelarDetalles()
        gbxDetalles.Enabled = False

        dgvTropa.Enabled = True
        dgvDetTropa.Enabled = True

        mtcFecha.Enabled = True

        mtcFecha.SetDate(Date.Now.Date)

        lblFecha.Text = Date.Now.Date

        lblTropa.Text = ""
        lblAnimales.Text = ""
        lblCab.Text = ""
        lblImpCab.Text = ""

        txtTratamiento.Text = ""
        txtImp.Text = ""
        txtObs.Text = ""

        CrtlT = False

        dgvTropa.MultiSelect = False
        dgvDetTropa.MultiSelect = False

        CargarTropas()

        dgvDetTropa.DataSource = Nothing

        dgvTropa.CurrentCell = Nothing
    End Sub

    Private Sub dgvTropa_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTropa.CellDoubleClick
        gbxDetalles.Enabled = True

        dgvTropa.Enabled = False
        dgvDetTropa.Enabled = False

        mtcFecha.Enabled = False

        lblTropa.Text = dgvTropa.CurrentRow.Cells.Item(1).Value
        lblAnimales.Text = "Todos"
        lblCab.Text = dgvTropa.CurrentRow.Cells.Item(2).Value
        lblImpCab.Text = "?"

        dgvDetTropa.MultiSelect = True

        dgvDetTropa.SelectAll()

        txtTratamiento.Select()
    End Sub

    Private Sub mtcFecha_DateSelected(sender As Object, e As DateRangeEventArgs) Handles mtcFecha.DateSelected
        If txtOrigen.Text = "Nuevo" Then
            lblFecha.Text = mtcFecha.SelectionRange.Start.ToShortDateString()

            dgvDetTropa.DataSource = Nothing

            CargarTropas()
        Else
            Dim _Dt As DataTable
            Dim _Ver As New Mostrar
            Dim AnimalStk As Boolean = True

            lblFecha.Text = mtcFecha.SelectionRange.Start.ToShortDateString()

            FechaStock(mtcFecha.SelectionRange.Start.ToShortDateString())

            For j As Integer = 0 To dgvSanidadesModificar.RowCount - 1
                _Dt = _Ver.verStockDetalleTropaFecha(dgvSanidadesModificar.Rows(j).Cells.Item("idDetTropa").Value, lblFechaStock.Text)

                If _Dt.Rows.Count < 1 Then
                    AnimalStk = False
                End If
            Next

            If AnimalStk = False Then
                MsgBox("Los Animales de la Sanidad que desea modificar no existian en Stock en la fecha que acaba de seleccionar. Por favor selecciona una fecha valida... !", vbInformation, "Servico de Alertas")
                lblFecha.Text = dgvSanidadesModificar.Rows(0).Cells.Item("Fecha").Value

                mtcFecha.SetDate(lblFecha.Text)

                FechaStock(mtcFecha.SelectionRange.Start.ToShortDateString())
            End If
        End If
    End Sub

    Private Sub btnCancelarDetalles_Click(sender As Object, e As EventArgs) Handles btnCancelarDetalles.Click
        CancelarDetalles()
    End Sub

    Private Sub dgvDetTropa_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDetTropa.CellDoubleClick
        gbxDetalles.Enabled = True

        dgvTropa.Enabled = False
        dgvDetTropa.Enabled = False

        mtcFecha.Enabled = False

        lblTropa.Text = dgvTropa.CurrentRow.Cells.Item(1).Value
        lblAnimales.Text = dgvDetTropa.CurrentRow.Cells.Item(1).Value
        lblCab.Text = 1
        lblImpCab.Text = "?"

        txtTratamiento.Select()
    End Sub

    Private Sub txtTratamiento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTratamiento.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtImp.SelectionLength = Len(txtImp.Text)
            txtImp.Select()
        End If
    End Sub

    Private Sub txtImp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtImp.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> Keys.Enter And e.KeyChar <> ChrW(8) And e.KeyChar <> ChrW(46) Then
            e.Handled = True
        ElseIf Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtObs.SelectionLength = Len(txtObs.Text)
            txtObs.Select()
        End If
    End Sub

    Private Sub txtObs_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtObs.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            pbxGuardar.Select()
        End If
    End Sub

    Private Sub txtImp_Validated(sender As Object, e As EventArgs) Handles txtImp.Validated
        If txtImp.Text <> "" Then
            txtImp.Text = Format(CDbl(txtImp.Text), "$ #,##0.00")
            lblImpCab.Text = Format(CDbl(txtImp.Text / lblCab.Text), "$ #,##0.00")
        End If
    End Sub

    Private Sub txtImp_TextChanged(sender As Object, e As EventArgs) Handles txtImp.TextChanged
        If txtImp.Text <> "" Then
            lblImpCab.Text = Format(CDbl(txtImp.Text / lblCab.Text), "$ #,##0.00")
        End If
    End Sub

    Private Sub CargarSanidades()
        Dim _Dt As New DataTable
        Dim _Ver As New Mostrar

        If frmLogin.txtTipUs.Text = "Super Usuario" Then
            _Dt = _Ver.consSanidadDetalleTropa
        Else
            _Dt = _Ver.consSanidadDetalleTropaUs(frmLogin.txtID.Text)
        End If

        dgvSanidades.RowTemplate.Height = 35
        dgvSanidades.DataSource = _Dt
        dgvSanidades.Columns("idSanidad").Visible = False
        dgvSanidades.Columns("idDetTropa").Visible = False
        dgvSanidades.Columns("idTropa").Visible = False
        dgvSanidades.Columns("Estado").Visible = False
        dgvSanidades.Columns("Descripcion").Visible = False

        If dgvSanidades.RowCount > 0 Then
            dgvSanidades.ColumnHeadersVisible = True
            dgvSanidades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
        Else
            dgvSanidades.ColumnHeadersVisible = False
            dgvSanidades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        End If

        dgvSanidades.Columns("Fecha").Width = 90
        dgvSanidades.Columns("Tratamiento").Width = 330
        dgvSanidades.Columns("Importe").Width = 70
        dgvSanidades.Columns("Observaciones").Width = 220
        dgvSanidades.Columns("Caravana").Width = 90
        dgvSanidades.Columns("NombreTropa").Width = 250

        dgvSanidades.CurrentCell = Nothing
        dgvSanidades.ClearSelection()
    End Sub

    Private Sub pbxModificar_Click(sender As Object, e As EventArgs) Handles pbxModificar.Click
        Activar()

        pbxModificar.BackgroundImage = SITRABO.My.Resources.btnModificarSi
        pbxNuevo.BackgroundImage = SITRABO.My.Resources.btnNuevoNo

        gbxModificar.Visible = True
        gbxPantallaInicio.Visible = False

        txtOrigen.Text = "Modificar"

        CargarSanidades()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If dgvSanidades.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Sanidad seleccionada... !", vbInformation, "Servico de Alertas")
        Else
            Dim Continuar As Boolean = True
            Dim Count As Integer = 0
            Dim Datos(dgvSanidades.SelectedRows.Count, 5) As String

            For i As Integer = 0 To dgvSanidades.RowCount - 1
                If dgvSanidades.Rows(i).Selected Then
                    Datos(Count, 1) = dgvSanidades.Rows(i).Cells.Item("Fecha").Value
                    Datos(Count, 2) = dgvSanidades.Rows(i).Cells.Item("Tratamiento").Value
                    Datos(Count, 3) = dgvSanidades.Rows(i).Cells.Item("Importe").Value
                    Datos(Count, 4) = dgvSanidades.Rows(i).Cells.Item("Observaciones").Value
                    Datos(Count, 5) = dgvSanidades.Rows(i).Cells.Item("NombreTropa").Value

                    Count = Count + 1
                End If
            Next

            For i As Integer = 0 To dgvSanidades.SelectedRows.Count - 1
                If Datos(0, 1) <> Datos(i, 1) Or Datos(0, 2) <> Datos(i, 2) Or Datos(0, 3) <> Datos(i, 3) Or Datos(0, 4) <> Datos(i, 4) Then
                    Continuar = False
                End If
            Next

            If Continuar = False Then
                MsgBox("No puedes modificar simultaneamente aplicaciones distintas... !", vbInformation, "Servico de Alertas")
            Else
                gbxModificar.Visible = False
                gbxNuevo.Visible = True

                dgvTropa.Visible = False
                dgvDetTropa.Visible = False

                lblLineDT.Visible = False
                lblLineT.Visible = False

                lblTituloDT.Visible = False
                lblTituloT.Visible = False

                lblNotaDT.Visible = False
                lblNotaTTodas.Visible = False
                lblNotaTUna.Visible = False

                dgvSanidadesModificar.Visible = True

                lblLineSM.Visible = True

                lblTituloSM.Visible = True
                lblTituloSM.BringToFront()

                gbxDetalles.Enabled = True

                btnCancelarDetalles.Enabled = False

                dgvSanidadesModificar.RowTemplate.Height = 25
                dgvSanidadesModificar.ColumnCount = 11
                dgvSanidadesModificar.Columns(0).Name = "idSanidad"
                dgvSanidadesModificar.Columns(1).Name = "Fecha"
                dgvSanidadesModificar.Columns(2).Name = "Tratamiento"
                dgvSanidadesModificar.Columns(3).Name = "Importe"
                dgvSanidadesModificar.Columns(4).Name = "Observaciones"
                dgvSanidadesModificar.Columns(5).Name = "idDetTropa"
                dgvSanidadesModificar.Columns(6).Name = "Caravana"
                dgvSanidadesModificar.Columns(7).Name = "Descripcion"
                dgvSanidadesModificar.Columns(8).Name = "Estado"
                dgvSanidadesModificar.Columns(9).Name = "idTropa"
                dgvSanidadesModificar.Columns(10).Name = "NombreTropa"

                dgvSanidadesModificar.Columns("idSanidad").Visible = False
                dgvSanidadesModificar.Columns("idDetTropa").Visible = False
                dgvSanidadesModificar.Columns("Descripcion").Visible = False
                dgvSanidadesModificar.Columns("Estado").Visible = False
                dgvSanidadesModificar.Columns("idTropa").Visible = False

                dgvSanidadesModificar.ColumnHeadersVisible = True
                dgvSanidadesModificar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None

                dgvSanidadesModificar.Columns("Fecha").Width = 90
                dgvSanidadesModificar.Columns("Tratamiento").Width = 330
                dgvSanidadesModificar.Columns("Importe").Width = 70
                dgvSanidadesModificar.Columns("Observaciones").Width = 220
                dgvSanidadesModificar.Columns("Caravana").Width = 90
                dgvSanidadesModificar.Columns("NombreTropa").Width = 250

                Dim txtGrabados As Boolean = False
                Dim Tropa As Boolean = True

                For i As Integer = 0 To dgvSanidades.RowCount - 1
                    If dgvSanidades.Rows(i).Selected Then
                        dgvSanidadesModificar.Rows.Add(dgvSanidades.Rows(i).Cells.Item("idSanidad").Value, dgvSanidades.Rows(i).Cells.Item("Fecha").Value, _
                                                       dgvSanidades.Rows(i).Cells.Item("Tratamiento").Value, dgvSanidades.Rows(i).Cells.Item("Importe").Value, _
                                                       dgvSanidades.Rows(i).Cells.Item("Observaciones").Value, dgvSanidades.Rows(i).Cells.Item("idDetTropa").Value, _
                                                       dgvSanidades.Rows(i).Cells.Item("Caravana").Value, dgvSanidades.Rows(i).Cells.Item("Descripcion").Value, _
                                                       dgvSanidades.Rows(i).Cells.Item("Estado").Value, dgvSanidades.Rows(i).Cells.Item("idTropa").Value, _
                                                       dgvSanidades.Rows(i).Cells.Item("NombreTropa").Value)

                        If txtGrabados = False Then
                            lblCab.Text = dgvSanidades.SelectedRows.Count

                            For j As Integer = 0 To dgvSanidades.SelectedRows.Count - 1
                                If Datos(0, 5) <> Datos(j, 5) Then
                                    Tropa = False
                                End If
                            Next

                            If Tropa = True Then
                                lblTropa.Text = dgvSanidades.Rows(i).Cells.Item("NombreTropa").Value
                            Else
                                lblTropa.Text = "-"
                            End If

                            lblAnimales.Text = "-"

                            txtTratamiento.Text = dgvSanidades.Rows(i).Cells.Item("Tratamiento").Value
                            txtImp.Text = dgvSanidades.Rows(i).Cells.Item("Importe").Value
                            txtObs.Text = dgvSanidades.Rows(i).Cells.Item("Observaciones").Value

                            mtcFecha.SetDate(Format(CDate(dgvSanidades.Rows(i).Cells.Item("Fecha").Value), "dd/MM/yyyy"))

                            lblFecha.Text = mtcFecha.SelectionRange.Start.ToShortDateString()

                            FechaStock(lblFecha.Text)

                            txtGrabados = True
                        End If
                    End If
                Next

                txtTratamiento.SelectionLength = Len(txtTratamiento.Text)
                txtTratamiento.Select()
            End If
        End If
    End Sub

    Private Sub frmSanidad_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control And e.KeyCode = Keys.T Then
            e.Handled = True

            If dgvTropa.Visible = True And dgvTropa.Enabled = True Then
                If dgvTropa.Rows.Count > 0 Then
                    CrtlT = True

                    gbxDetalles.Enabled = True

                    dgvTropa.Enabled = False
                    dgvDetTropa.Enabled = False

                    mtcFecha.Enabled = False

                    CargarDetalleTropa()

                    lblTropa.Text = "Todos"
                    lblAnimales.Text = "Todos"
                    lblCab.Text = dgvDetTropa.RowCount
                    lblImpCab.Text = "?"

                    dgvTropa.MultiSelect = True
                    dgvDetTropa.MultiSelect = True

                    dgvDetTropa.SelectAll()
                    dgvTropa.SelectAll()

                    txtTratamiento.Select()
                    txtTratamiento.Focus()
                End If
            End If
        End If
    End Sub
End Class