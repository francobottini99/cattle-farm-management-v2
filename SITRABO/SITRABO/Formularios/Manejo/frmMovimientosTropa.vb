Public Class frmMovimientosTropa

    'ANIMACIONES BOTONES -------------------------------------------------------------------------------------

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

    Private Sub pbxEgresos_GotFocus(sender As Object, e As EventArgs) Handles pbxEgresos.GotFocus
        If (pbxEgresos.Enabled = True) Then
            pbxEgresos.BackgroundImage = SITRABO.My.Resources.btnEgresosSi
        End If
    End Sub

    Private Sub pbxEgresos_LostFocus(sender As Object, e As EventArgs) Handles pbxEgresos.LostFocus
        If (pbxEgresos.Enabled = True) Then
            pbxEgresos.BackgroundImage = SITRABO.My.Resources.btnEgresosNo
        End If
    End Sub

    Private Sub pbxEgresos_MouseEnter(sender As Object, e As EventArgs) Handles pbxEgresos.MouseEnter
        If (pbxEgresos.Enabled = True) Then
            pbxEgresos.BackgroundImage = SITRABO.My.Resources.btnEgresosSi
        End If
    End Sub

    Private Sub pbxEgresos_MouseLeave(sender As Object, e As EventArgs) Handles pbxEgresos.MouseLeave
        If (pbxEgresos.Enabled = True) Then
            pbxEgresos.BackgroundImage = SITRABO.My.Resources.btnEgresosNo
        End If
    End Sub

    Private Sub pbxMovInterno_GotFocus(sender As Object, e As EventArgs) Handles pbxMovInterno.GotFocus
        If (pbxMovInterno.Enabled = True) Then
            pbxMovInterno.BackgroundImage = SITRABO.My.Resources.btnMovInternosSi
        End If
    End Sub

    Private Sub pbxMovInterno_LostFocus(sender As Object, e As EventArgs) Handles pbxMovInterno.LostFocus
        If (pbxMovInterno.Enabled = True) Then
            pbxMovInterno.BackgroundImage = SITRABO.My.Resources.btnMovInternosNo
        End If
    End Sub

    Private Sub pbxMovInterno_MouseEnter(sender As Object, e As EventArgs) Handles pbxMovInterno.MouseEnter
        If (pbxMovInterno.Enabled = True) Then
            pbxMovInterno.BackgroundImage = SITRABO.My.Resources.btnMovInternosSi
        End If
    End Sub

    Private Sub pbxMovInterno_MouseLeave(sender As Object, e As EventArgs) Handles pbxMovInterno.MouseLeave
        If (pbxMovInterno.Enabled = True) Then
            pbxMovInterno.BackgroundImage = SITRABO.My.Resources.btnMovInternosNo
        End If
    End Sub

    'ANIMACIONES BOTONES -------------------------------------------------------------------------------------



    'PANTALLA MOV INTERNOS -------------------------------------------------------------------------------------

    Private Sub pbxMovInterno_Click(sender As Object, e As EventArgs) Handles pbxMovInterno.Click
        CargarCorrales(dgvCrrEgr)

        If dgvCrrEgr.Rows.Count <= 0 Then
            MsgBox("Error: No se a encontrado ningun corral con stock disponible... !", vbExclamation, "Servico de Alertas")
            Cancelar()
        Else
            txtOrigen.Text = "MovInterno"
            Activar()
            gbxMovInterno.Visible = True
            gbxPantallaInicio.Visible = False
            pbxMovInterno.BackgroundImage = SITRABO.My.Resources.btnMovInternosSi
            dgvCrrEgr.CurrentCell = Nothing
            rdbAnimal.Checked = True
        End If
    End Sub

    Private Sub dgvCrrEgr_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCrrEgr.CellClick
        Dim _Dt, _Dt2 As New DataTable
        Dim _Ver, _Ver2 As New Mostrar

        If frmLogin.txtTipUs.Text = "Super Usuario" Then
            _Dt2 = _Ver2.verCorrales
            _Dt = _Ver.consDetalleTropaEngorde(dgvCrrEgr.CurrentRow.Cells.Item(0).Value)
        Else
            _Dt2 = _Ver2.verCorralesUs(frmLogin.txtID.Text)
            _Dt = _Ver.consDetalleTropaEngordeUS(frmLogin.txtID.Text, dgvCrrEgr.CurrentRow.Cells.Item(0).Value)
        End If

        dgvDetCrrEgrAnimal.RowTemplate.Height = 25
        dgvDetCrrEgrAnimal.DataSource = _Dt
        dgvDetCrrEgrAnimal.Columns("idDetTropa").Visible = False
        dgvDetCrrEgrAnimal.Columns("Estado").Visible = False
        dgvDetCrrEgrAnimal.Columns("idTropa").Visible = False

        dgvCrrIng.RowTemplate.Height = 25
        dgvCrrIng.DataSource = _Dt2
        dgvCrrIng.Columns("idCorrales").Visible = False
        dgvCrrIng.Columns("Superficie").Visible = False
        dgvCrrIng.Columns("CabezasTotales").Visible = False
        dgvCrrIng.Columns("CAMPO_idCampo").Visible = False
        dgvCrrIng.Columns("USUARIOS_idUsuario").Visible = False

        dgvDetCrrEgrTropa.RowTemplate.Height = 25
        dgvDetCrrEgrTropa.ColumnCount = 2
        dgvDetCrrEgrTropa.Columns(0).Name = "Nombre Tropa"
        dgvDetCrrEgrTropa.Columns(1).Name = "Cabezas"

        dgvDetCrrEgrTropa.ColumnHeadersVisible = True

        Dim rows As Integer = dgvCrrIng.Rows.Count - 1

        For j As Integer = rows To 0 Step -1
            If dgvCrrIng.Rows(j).Cells.Item(1).Value = dgvCrrEgr.CurrentRow.Cells.Item(1).Value Then
                dgvCrrIng.Rows.Remove(dgvCrrIng.Rows(j))
            End If
        Next

        Dim rows6 As Integer = dgvDetCrrEgrTropa.Rows.Count - 1

        For j As Integer = rows6 To 0 Step -1
            dgvDetCrrEgrTropa.Rows.Remove(dgvDetCrrEgrTropa.Rows(j))
        Next

        Dim rows2 As Integer = dgvDetCrrIng.Rows.Count - 1

        For j As Integer = rows2 To 0 Step -1
            Dim rows3 As Integer = dgvDetCrrEgrAnimal.Rows.Count - 1

            For i As Integer = rows3 To 0 Step -1
                If dgvDetCrrIng.Rows(j).Cells.Item(0).Value = dgvDetCrrEgrAnimal.Rows(i).Cells.Item(3).Value Then
                    dgvDetCrrEgrAnimal.Rows.Remove(dgvDetCrrEgrAnimal.Rows(i))
                End If
            Next
        Next

        Dim An As Integer = 0
        Dim rows4 As Integer = dgvDetCrrEgrAnimal.Rows.Count - 1
        Dim Grabar As Boolean = True

        For j As Integer = rows4 To 0 Step -1
            Dim rows5 As Integer = dgvDetCrrEgrTropa.Rows.Count - 1

            For a As Integer = rows5 To 0 Step -1
                If dgvDetCrrEgrAnimal.Rows(j).Cells.Item(4).Value = dgvDetCrrEgrTropa.Rows(a).Cells.Item(0).Value Then
                    Grabar = False
                End If
            Next

            For i As Integer = rows4 To 0 Step -1
                If Grabar = True Then
                    If dgvDetCrrEgrAnimal.Rows(i).Cells.Item(4).Value = dgvDetCrrEgrAnimal.Rows(j).Cells.Item(4).Value Then
                        An = An + 1
                    End If
                Else
                    Exit For
                End If
            Next

            Grabar = True

            If An <> 0 Then
                dgvDetCrrEgrTropa.Rows.Add(dgvDetCrrEgrAnimal.Rows(j).Cells.Item(4).Value, An)
                An = 0
            End If
        Next

        If rdbAnimal.Checked = True Then
            dgvDetCrrEgrAnimal.Visible = True
            dgvDetCrrEgrTropa.Visible = False
        Else
            dgvDetCrrEgrAnimal.Visible = False
            dgvDetCrrEgrTropa.Visible = True
        End If

        txtFechaMov.Enabled = False
        txtFechaMov.Text = ""

        dgvDetCrrEgrAnimal.Sort(dgvDetCrrEgrAnimal.Columns("NombreTropa"), System.ComponentModel.ListSortDirection.Ascending)
        dgvDetCrrEgrAnimal.CurrentCell = Nothing
        dgvDetCrrEgrTropa.CurrentCell = Nothing
        dgvDetCrrEgrAnimal.ClearSelection()
        dgvDetCrrEgrTropa.ClearSelection()
        dgvCrrIng.CurrentCell = Nothing
    End Sub

    Private Sub dgvDetCrrEgrAnimal_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDetCrrEgrAnimal.CellClick
        tmrFecha.Enabled = True
        If e.RowIndex > -1 Then
            txtFechaMov.Enabled = True

            txtFechaMov.SelectionLength = Len(txtFechaMov.Text)
            txtFechaMov.Select()
        End If
    End Sub

    Private Sub rdbTropa_CheckedChanged(sender As Object, e As EventArgs) Handles rdbTropa.CheckedChanged
        If rdbAnimal.Checked = True Then
            dgvDetCrrEgrAnimal.Visible = True
            dgvDetCrrEgrTropa.Visible = False

            rdbTropa.BackColor = Color.LightSlateGray
            rdbTropa.ForeColor = Color.Moccasin

        Else
            dgvDetCrrEgrAnimal.Visible = False
            dgvDetCrrEgrTropa.Visible = True

            rdbTropa.BackColor = Color.Moccasin
            rdbTropa.ForeColor = Color.LightSlateGray
        End If

        txtFechaMov.Enabled = False
        txtFechaMov.Text = ""
        dgvDetCrrEgrAnimal.CurrentCell = Nothing
        dgvDetCrrEgrTropa.CurrentCell = Nothing
        dgvDetCrrEgrAnimal.ClearSelection()
        dgvDetCrrEgrTropa.ClearSelection()
    End Sub

    Private Sub rdbAnimal_CheckedChanged(sender As Object, e As EventArgs) Handles rdbAnimal.CheckedChanged
        If rdbAnimal.Checked = True Then
            dgvDetCrrEgrAnimal.Visible = True
            dgvDetCrrEgrTropa.Visible = False

            rdbAnimal.BackColor = Color.Moccasin
            rdbAnimal.ForeColor = Color.LightSlateGray
        Else
            dgvDetCrrEgrAnimal.Visible = False
            dgvDetCrrEgrTropa.Visible = True

            rdbAnimal.BackColor = Color.LightSlateGray
            rdbAnimal.ForeColor = Color.Moccasin
        End If

        txtFechaMov.Enabled = False
        txtFechaMov.Text = ""
        dgvDetCrrEgrAnimal.CurrentCell = Nothing
        dgvDetCrrEgrTropa.CurrentCell = Nothing
        dgvDetCrrEgrAnimal.ClearSelection()
        dgvDetCrrEgrTropa.ClearSelection()
    End Sub

    Private Sub txtFechaMov_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFechaMov.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> Keys.Enter And e.KeyChar <> ChrW(8) And e.KeyChar <> ChrW(45) And e.KeyChar <> ChrW(45) And e.KeyChar <> ChrW(117) And e.KeyChar <> ChrW(104) And e.KeyChar <> ChrW(72) Then
            e.Handled = True
        ElseIf e.KeyChar = ChrW(117) Or e.KeyChar = ChrW(85) Then
            e.Handled = True
            If dgvDetCrrIng.Rows.Count > 0 Then
                txtFechaMov.Text = dgvDetCrrIng.Rows(dgvDetCrrIng.Rows.Count - 1).Cells.Item(10).Value
                txtFechaMov.SelectionLength = Len(txtFechaMov.Text)
                txtFechaMov.Select()
            End If
        ElseIf e.KeyChar = ChrW(104) Or e.KeyChar = ChrW(72) Then
            e.Handled = True
            txtFechaMov.Text = Date.Now.Date
            txtFechaMov.SelectionLength = Len(txtFechaMov.Text)
            txtFechaMov.Select()
        ElseIf Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            If dgvCrrIng.CurrentRow IsNot Nothing Then
                If Not IsDate(txtFechaMov.Text) Then
                    MsgBox("Error: Formato de Fecha incorrecto.", vbExclamation, "Servico de Alertas")
                    txtFechaMov.Text = ""
                    txtFechaMov.Select()
                Else
                    Dim _Dt As DataTable
                    Dim _Ver As New Mostrar
                    Dim Fecha, FechaI As Date

                    _Dt = _Ver.verStock()

                    If _Dt.Rows.Count < 1 Then
                        Fecha = Format(CDate("01/01/1777"), "dd/MM/yyyy")
                    Else
                        Fecha = _Dt.Rows(_Dt.Rows.Count - 1).Item(1)
                    End If

                    If dgvDetCrrIng.Rows.Count < 1 Then
                        FechaI = Nothing
                    Else
                        FechaI = dgvDetCrrIng.Rows(dgvDetCrrIng.Rows.Count - 1).Cells.Item(10).Value
                    End If

                    If Format(CDate(txtFechaMov.Text), "dd/MM/yyyy") >= Fecha Then
                        If FechaI = txtFechaMov.Text Or FechaI = Nothing Then
                            txtFechaMov.Text = Format(CDate(txtFechaMov.Text), "dd/MM/yyyy")

                            dgvDetCrrIng.RowTemplate.Height = 25
                            dgvDetCrrIng.ColumnCount = 11
                            dgvDetCrrIng.Columns(0).Name = "idDetTropa"
                            dgvDetCrrIng.Columns(1).Name = "Caravana"
                            dgvDetCrrIng.Columns(2).Name = "Descripcion"
                            dgvDetCrrIng.Columns(3).Name = "Tropa"
                            dgvDetCrrIng.Columns(4).Name = "Categoria"
                            dgvDetCrrIng.Columns(5).Name = "Corral Egreso"
                            dgvDetCrrIng.Columns(6).Name = "Corral Ingreso"
                            dgvDetCrrIng.Columns(7).Name = "Estado"
                            dgvDetCrrIng.Columns(8).Name = "idCorralIng"
                            dgvDetCrrIng.Columns(9).Name = "idTropa"
                            dgvDetCrrIng.Columns(10).Name = "Fecha Mov"

                            dgvDetCrrIng.Columns(9).Visible = False
                            dgvDetCrrIng.Columns(8).Visible = False
                            dgvDetCrrIng.Columns(7).Visible = False
                            dgvDetCrrIng.Columns(0).Visible = False
                            dgvDetCrrIng.ColumnHeadersVisible = True
                            dgvDetCrrIng.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None

                            dgvDetCrrIng.Columns("Caravana").Width = 80
                            dgvDetCrrIng.Columns("Descripcion").Width = 250
                            dgvDetCrrIng.Columns("Tropa").Width = 180
                            dgvDetCrrIng.Columns("Categoria").Width = 130
                            dgvDetCrrIng.Columns("Corral Egreso").Width = 200
                            dgvDetCrrIng.Columns("Corral Ingreso").Width = 200
                            dgvDetCrrIng.Columns("Fecha Mov").Width = 100

                            If dgvDetCrrEgrAnimal.Visible = True Then
                                dgvDetCrrIng.Rows.Add(dgvDetCrrEgrAnimal.CurrentRow.Cells.Item(3).Value, dgvDetCrrEgrAnimal.CurrentRow.Cells.Item(0).Value, dgvDetCrrEgrAnimal.CurrentRow.Cells.Item(1).Value, dgvDetCrrEgrAnimal.CurrentRow.Cells.Item(4).Value, dgvDetCrrEgrAnimal.CurrentRow.Cells.Item(5).Value, dgvCrrEgr.CurrentRow.Cells.Item(1).Value, dgvCrrIng.CurrentRow.Cells.Item(1).Value, dgvDetCrrEgrAnimal.CurrentRow.Cells.Item(2).Value, dgvCrrIng.CurrentRow.Cells.Item(0).Value, dgvDetCrrEgrAnimal.CurrentRow.Cells.Item(6).Value, Format(CDate(txtFechaMov.Text), "dd/MM/yyyy"))
                                dgvDetCrrEgrAnimal.Rows.Remove(dgvDetCrrEgrAnimal.CurrentRow)

                                Dim rows6 As Integer = dgvDetCrrEgrTropa.Rows.Count - 1

                                For j As Integer = rows6 To 0 Step -1
                                    dgvDetCrrEgrTropa.Rows.Remove(dgvDetCrrEgrTropa.Rows(j))
                                Next

                                Dim An As Integer = 0
                                Dim rows4 As Integer = dgvDetCrrEgrAnimal.Rows.Count - 1
                                Dim Grabar As Boolean = True

                                For j As Integer = rows4 To 0 Step -1
                                    Dim rows5 As Integer = dgvDetCrrEgrTropa.Rows.Count - 1

                                    For a As Integer = rows5 To 0 Step -1
                                        If dgvDetCrrEgrAnimal.Rows(j).Cells.Item(4).Value = dgvDetCrrEgrTropa.Rows(a).Cells.Item(0).Value Then
                                            Grabar = False
                                        End If
                                    Next

                                    For i As Integer = rows4 To 0 Step -1
                                        If Grabar = True Then
                                            If dgvDetCrrEgrAnimal.Rows(i).Cells.Item(4).Value = dgvDetCrrEgrAnimal.Rows(j).Cells.Item(4).Value Then
                                                An = An + 1
                                            End If
                                        Else
                                            Exit For
                                        End If
                                    Next

                                    Grabar = True

                                    If An <> 0 Then
                                        dgvDetCrrEgrTropa.Rows.Add(dgvDetCrrEgrAnimal.Rows(j).Cells.Item(4).Value, An)
                                        An = 0
                                    End If
                                Next
                            Else
                                Dim rows As Integer = dgvDetCrrEgrAnimal.Rows.Count - 1

                                For j As Integer = rows To 0 Step -1
                                    If dgvDetCrrEgrAnimal.Rows(j).Cells.Item(4).Value = dgvDetCrrEgrTropa.CurrentRow.Cells.Item(0).Value Then
                                        dgvDetCrrIng.Rows.Add(dgvDetCrrEgrAnimal.Rows(j).Cells.Item(3).Value, dgvDetCrrEgrAnimal.Rows(j).Cells.Item(0).Value, dgvDetCrrEgrAnimal.Rows(j).Cells.Item(1).Value, dgvDetCrrEgrAnimal.Rows(j).Cells.Item(4).Value, dgvDetCrrEgrAnimal.Rows(j).Cells.Item(5).Value, dgvCrrEgr.CurrentRow.Cells.Item(1).Value, dgvCrrIng.CurrentRow.Cells.Item(1).Value, dgvDetCrrEgrAnimal.Rows(j).Cells.Item(2).Value, dgvCrrIng.CurrentRow.Cells.Item(0).Value, dgvDetCrrEgrAnimal.Rows(j).Cells.Item(6).Value, Format(CDate(txtFechaMov.Text), "dd/MM/yyyy"))
                                        dgvDetCrrEgrAnimal.Rows.Remove(dgvDetCrrEgrAnimal.Rows(j))
                                    End If
                                Next

                                dgvDetCrrEgrTropa.Rows.Remove(dgvDetCrrEgrTropa.CurrentRow)
                            End If

                            txtFechaMov.Enabled = False
                            txtFechaMov.Text = ""
                            dgvDetCrrIng.CurrentCell = Nothing
                            dgvDetCrrEgrAnimal.CurrentCell = Nothing
                            dgvDetCrrEgrTropa.CurrentCell = Nothing
                        Else
                            MsgBox("Los Movimientos pre-cargardos deben tener todos la misma fecha... !", vbInformation, "Servico de Alertas")
                            txtFechaMov.Text = ""
                            txtFechaMov.Select()
                        End If
                    Else
                        MsgBox("No puedes realizar un movimiento en un dia anterior al ultimo registro de stock... !", vbInformation, "Servico de Alertas")
                        txtFechaMov.Text = ""
                        txtFechaMov.Select()
                    End If
                End If
            Else
                MsgBox("Debes seleccionar un corral de ingreso... !", vbExclamation, "Servico de Alertas")
            End If
        End If
        pbxRecuadro.Visible = False
        pbxRecuadro1.Visible = False
        tmrFecha.Enabled = False
    End Sub

    Private Sub dgvDetCrrEgrTropa_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDetCrrEgrTropa.CellClick
        If e.RowIndex > -1 Then
            txtFechaMov.Enabled = True

            txtFechaMov.SelectionLength = Len(txtFechaMov.Text)
            txtFechaMov.Select()
        End If
    End Sub

    Private Sub dgvDetCrrIng_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDetCrrIng.CellDoubleClick
        If e.RowIndex > -1 Then
            If dgvDetCrrIng.Rows.Count = 1 Then
                dgvDetCrrIng.ColumnHeadersVisible = False
                dgvDetCrrIng.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            End If

            dgvDetCrrIng.Rows.Remove(dgvDetCrrIng.CurrentRow)

            Dim _Dt As New DataTable
            Dim _Ver As New Mostrar

            If frmLogin.txtTipUs.Text = "Super Usuario" Then
                _Dt = _Ver.consDetalleTropaEngorde(dgvCrrEgr.CurrentRow.Cells.Item(0).Value)
            Else
                _Dt = _Ver.consDetalleTropaEngordeUS(frmLogin.txtID.Text, dgvCrrEgr.CurrentRow.Cells.Item(0).Value)
            End If

            dgvDetCrrEgrAnimal.DataSource = _Dt

            Dim rows6 As Integer = dgvDetCrrEgrTropa.Rows.Count - 1

            For j As Integer = rows6 To 0 Step -1
                dgvDetCrrEgrTropa.Rows.Remove(dgvDetCrrEgrTropa.Rows(j))
            Next

            Dim rows2 As Integer = dgvDetCrrIng.Rows.Count - 1

            For j As Integer = rows2 To 0 Step -1
                Dim rows3 As Integer = dgvDetCrrEgrAnimal.Rows.Count - 1

                For i As Integer = rows3 To 0 Step -1
                    If dgvDetCrrIng.Rows(j).Cells.Item(0).Value = dgvDetCrrEgrAnimal.Rows(i).Cells.Item(3).Value Then
                        dgvDetCrrEgrAnimal.Rows.Remove(dgvDetCrrEgrAnimal.Rows(i))
                    End If
                Next
            Next

            Dim An As Integer = 0
            Dim rows4 As Integer = dgvDetCrrEgrAnimal.Rows.Count - 1
            Dim Grabar As Boolean = True

            For j As Integer = rows4 To 0 Step -1
                Dim rows5 As Integer = dgvDetCrrEgrTropa.Rows.Count - 1

                For a As Integer = rows5 To 0 Step -1
                    If dgvDetCrrEgrAnimal.Rows(j).Cells.Item(4).Value = dgvDetCrrEgrTropa.Rows(a).Cells.Item(0).Value Then
                        Grabar = False
                    End If
                Next

                For i As Integer = rows4 To 0 Step -1
                    If Grabar = True Then
                        If dgvDetCrrEgrAnimal.Rows(i).Cells.Item(4).Value = dgvDetCrrEgrAnimal.Rows(j).Cells.Item(4).Value Then
                            An = An + 1
                        End If
                    Else
                        Exit For
                    End If
                Next

                Grabar = True

                If An <> 0 Then
                    dgvDetCrrEgrTropa.Rows.Add(dgvDetCrrEgrAnimal.Rows(j).Cells.Item(4).Value, An)
                    An = 0
                End If
            Next

            dgvDetCrrEgrAnimal.Sort(dgvDetCrrEgrAnimal.Columns("NombreTropa"), System.ComponentModel.ListSortDirection.Ascending)
            dgvDetCrrIng.CurrentCell = Nothing
            dgvDetCrrEgrAnimal.CurrentCell = Nothing
            dgvDetCrrEgrTropa.CurrentCell = Nothing
        End If
    End Sub

    Private Sub pbxEgresos_Click(sender As Object, e As EventArgs) Handles pbxEgresos.Click
        CargarCorrales(dgvCrr)

        If dgvCrr.Rows.Count <= 0 Then
            MsgBox("Error: No se a encontrado ningun corral con stock disponible... !", vbExclamation, "Servico de Alertas")
            Cancelar()
        Else
            txtOrigen.Text = "Egreso"
            Activar()

            gbxEgresos.Visible = True
            gbxPantallaInicio.Visible = False

            pbxEgresos.BackgroundImage = SITRABO.My.Resources.btnEgresosSi
            dgvCrr.CurrentCell = Nothing
        End If
    End Sub

    Dim CrtlT As Boolean = False

    Private Sub frmMovimientosTropa_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control And e.KeyCode = Keys.T Then
            e.Handled = True

            If rdbVenta.Checked = True Then
                If dgvDetCrr.Rows.Count > 0 Then
                    txtFechaEgr.Enabled = True
                    txtFechaEgr.Select()
                    CrtlT = True
                End If
            End If
            tmrFecha.Enabled = True
        End If
    End Sub

    'PANTALLA MOV INTERNOS -------------------------------------------------------------------------------------



    'PROCESOS COMPARTIDOS  -------------------------------------------------------------------------------------

    Private Sub frmMovimientosTropa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ctlNuevo As Control = DirectCast(pbxMovInterno, Control)
        Dim keyprNuevo = New KeyPressEventHandler(AddressOf btnMovInterno)
        Dim ctlGuardar As Control = DirectCast(pbxGuardar, Control)
        Dim keyprGuardar = New KeyPressEventHandler(AddressOf btnGuardar)

        AddHandler ctlNuevo.KeyPress, keyprNuevo
        AddHandler ctlGuardar.KeyPress, keyprGuardar

        Me.Text = "Si.Tra.Bo. - Sistema de Trazabilidad Bovina" & " - USUARIO: " & frmLogin.txtNom.Text & " " & frmLogin.txtAp.Text & " -"

    End Sub

    Private Sub btnMovInterno(ByVal sender As System.Object, ByVal e As KeyPressEventArgs)
        If Asc(e.KeyChar) = Keys.Enter Then
            pbxMovInterno_Click(1, Nothing)
        End If
    End Sub

    Private Sub btnGuardar(ByVal sender As System.Object, ByVal e As KeyPressEventArgs)
        If Asc(e.KeyChar) = Keys.Enter Then
            pbxGuardar_Click(1, Nothing)
        End If
    End Sub

    Private Sub Activar()
        pbxMovInterno.Enabled = False
        pbxGuardar.Enabled = True
        pbxCancelar.Enabled = True
        pbxEgresos.Enabled = False
        pbxSalir.Enabled = False
    End Sub

    Private Sub Cancelar()
        pbxMovInterno.Enabled = True
        pbxGuardar.Enabled = False
        pbxCancelar.Enabled = False
        pbxEgresos.Enabled = True
        pbxSalir.Enabled = True

        CrtlT = False

        gbxEgresos.Visible = False
        gbxMovInterno.Visible = False
        gbxPantallaInicio.Visible = True

        dgvDetCrrEgrAnimal.DataSource = Nothing
        dgvCrrIng.DataSource = Nothing
        dgvCrrEgr.DataSource = Nothing
        dgvAnimEgresados.DataSource = Nothing
        dgvDetCrr.DataSource = Nothing

        btnCancelarMod.Visible = False
        btnModEgr.Visible = True

        dgvCrr.Enabled = True
        dgvDetCrr.Enabled = True
        dgvAnimEgresados.Enabled = False

        dgvAnimEgresados.BackgroundColor = Color.DimGray

        lblLn4.BackColor = Color.DimGray
        lblDetAnimEgr.ForeColor = Color.DimGray
        lblMsgAnimEgr.BackColor = Color.DimGray

        lblLn.BackColor = Color.BurlyWood
        lblCrr.ForeColor = Color.BurlyWood
        lblMsgCrr.BackColor = Color.BurlyWood

        lblLn2.BackColor = Color.BurlyWood
        lblDetR.ForeColor = Color.BurlyWood
        lblMsgDetCrr.BackColor = Color.BurlyWood

        lblMsgCrr.Text = "Nota: ""Sólo Corrales Con Stock"""
        lblMsgDetCrr.Text = ""
        lblMsgAnimEgr.Text = ""
        lblMsgDetEgr.Text = "Nota: ""Animales Seleccionados para Egreso por Muerte ó por Venta"""
        lblDet.Text = "  Detalle de Animales Seleccionados Para Egreso  "

        dgvCrr.BackgroundColor = Color.BurlyWood
        dgvDetCrr.BackgroundColor = Color.BurlyWood

        txtFechaEgr.Text = ""
        txtFechaMov.Text = ""

        txtFechaMov.Enabled = False

        rdbMuerte.Checked = False
        rdbVenta.Checked = False

        Dim rows As Integer = dgvDetCrrIng.Rows.Count - 1

        If dgvDetCrrIng.Rows.Count > 0 Then
            For j As Integer = rows To 0 Step -1
                dgvDetCrrIng.Rows.Remove(dgvDetCrrIng.Rows(j))
            Next
        End If

        Dim rows2 As Integer = dgvDetCrrEgrTropa.Rows.Count - 1

        If dgvDetCrrEgrTropa.Rows.Count > 0 Then
            For j As Integer = rows2 To 0 Step -1
                dgvDetCrrEgrTropa.Rows.Remove(dgvDetCrrEgrTropa.Rows(j))
            Next
        End If

        LimpiarListasEgreso(True, True, True)

        dgvDetCrrEgrTropa.ColumnHeadersVisible = False
        dgvDetCrrIng.ColumnHeadersVisible = False
        dgvDetCrr.ColumnHeadersVisible = False
        dgvDetEgr.ColumnHeadersVisible = False
        dgvAnimEgresados.ColumnHeadersVisible = False

        dgvDetCrrIng.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvDetEgr.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvDetCrr.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvAnimEgresados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        pbxMovInterno.BackgroundImage = SITRABO.My.Resources.btnMovInternosNo
        pbxEgresos.BackgroundImage = SITRABO.My.Resources.btnEgresosNo
    End Sub

    Private Sub pbxCancelar_Click(sender As Object, e As EventArgs) Handles pbxCancelar.Click
        Cancelar()
        pbxRecuadro.Visible = False
        pbxRecuadro1.Visible = False
        tmrFecha.Enabled = False
        pbxMovInterno.BackgroundImage = SITRABO.My.Resources.btnMovInternosNo
        pbxEgresos.BackgroundImage = SITRABO.My.Resources.btnEgresosNo
    End Sub

    Private Sub pbxSalir_Click(sender As Object, e As EventArgs) Handles pbxSalir.Click
        Me.Close()
    End Sub

    Private Sub CargarCorrales(ByVal _Dgv As DataGridView)
        Dim _Dt As New DataTable
        Dim _Ver As New Mostrar

        If frmLogin.txtTipUs.Text = "Super Usuario" Then
            _Dt = _Ver.verCorrales
        Else
            _Dt = _Ver.verCorralesUs(frmLogin.txtID.Text)
        End If

        _Dgv.RowTemplate.Height = 25
        _Dgv.DataSource = _Dt

        Dim rows As Integer = _Dt.Rows.Count - 1

        For j As Integer = rows To 0 Step -1
            If _Dt.Rows(j).Item("CabezasTotales") = 0 Then
                _Dt.Rows.Remove(_Dt.Rows(j))
            End If
        Next

        _Dgv.Columns("idCorrales").Visible = False
        _Dgv.Columns("Superficie").Visible = False
        _Dgv.Columns("CabezasTotales").Visible = False
        _Dgv.Columns("CAMPO_idCampo").Visible = False
        _Dgv.Columns("USUARIOS_idUsuario").Visible = False
    End Sub

    Private Sub pbxGuardar_Click(sender As Object, e As EventArgs) Handles pbxGuardar.Click
        Dim G As New GrabaDatos
        Dim resP As DialogResult
        Dim _Dt4, _Dt5 As DataTable
        Dim _Ver4, _Ver5 As New Mostrar
        Dim _Stk As New Stock

        If dgvDetCrrIng.Rows.Count < 1 And txtOrigen.Text = "MovInterno" Then
            MsgBox("No hay ningun movimiento para guardar... !", vbExclamation, "Servico de Alertas")
        Else
            If dgvDetEgr.Rows.Count < 1 And txtOrigen.Text = "Egreso" Then
                MsgBox("No hay ningun egreso para guardar... !", vbExclamation, "Servico de Alertas")
            Else
                If dgvDetEgr.Rows.Count < 1 And txtOrigen.Text = "ModEgreso" Then
                    MsgBox("No hay ningun reingreso para guardar... !", vbExclamation, "Servico de Alertas")
                Else
                    resP = MessageBox.Show("Grabar Movimiento ?", "Servico de Alertas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                    If resP = Windows.Forms.DialogResult.OK Then
                        If txtOrigen.Text = "MovInterno" Then
                            For i As Integer = 0 To dgvDetCrrIng.Rows.Count - 1
                                G.Grabar("detalle_tropa", "NoImagen", "feedlot.modDetalleTropaCorral", CInt(dgvDetCrrIng.Rows(i).Cells.Item(0).Value), CInt(dgvDetCrrIng.Rows(i).Cells.Item(8).Value))

                                G.Grabar("tropa_bloqueo_mod", "NoImagen", "feedlot.modEstadoMod", "NO", dgvDetCrrIng.Rows(i).Cells.Item(9).Value)

                                If i = dgvDetCrrIng.Rows.Count - 1 Then
                                    _Stk.ManejoStk(dgvDetCrrIng.Rows(i).Cells.Item(10).Value)
                                End If
                            Next
                        ElseIf txtOrigen.Text = "Egreso" Then
                            If rdbVenta.Checked = True Then
                                For i As Integer = 0 To dgvDetEgr.Rows.Count - 1
                                    _Dt5 = _Ver5.verPesajeVenta(CInt(dgvDetEgr.Rows(i).Cells.Item(0).Value))

                                    If _Dt5.Rows.Count > 0 Then
                                        G.Grabar("detalle_tropa", "NoImagen", "feedlot.modDetalleTropaVendido", CInt(dgvDetEgr.Rows(i).Cells.Item(0).Value))

                                        G.Grabar("tropa_bloqueo_mod", "NoImagen", "feedlot.modEstadoMod", "NO", dgvDetEgr.Rows(i).Cells.Item(6).Value)

                                        _Dt4 = _Ver4.consProductorDetalleTropa(CInt(dgvDetEgr.Rows(i).Cells.Item(0).Value))

                                        G.Grabar("Ventas", "NoImagen", "feedlot.insEgreso", Format(CDate(dgvDetEgr.Rows(i).Cells.Item(7).Value), "yyyy/MM/dd"), "-", 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
                                                 CInt(_Dt4.Rows(0).Item(0)), CInt(dgvDetEgr.Rows(i).Cells.Item(0).Value), CInt(frmLogin.txtID.Text), _Dt5.Rows(0).Item(0))

                                        G.Grabar("tropa", "NoImagen", "feedlot.modTropaVta", dgvDetEgr.Rows(i).Cells.Item(6).Value, 1)
                                    Else
                                        MsgBox("No se encontro el peso de venta de uno de los animales por lo tanto se omitio el egreso del mismo... !", vbExclamation, "Servico de Alertas")
                                    End If

                                    If i = dgvDetEgr.Rows.Count - 1 Then
                                        _Stk.ManejoStk(dgvDetEgr.Rows(i).Cells.Item(7).Value)
                                    End If
                                Next
                            Else
                                For i As Integer = 0 To dgvDetEgr.Rows.Count - 1
                                    G.Grabar("detalle_tropa", "NoImagen", "feedlot.modDetalleTropaMuerto", CInt(dgvDetEgr.Rows(i).Cells.Item(0).Value))

                                    G.Grabar("tropa_bloqueo_mod", "NoImagen", "feedlot.modEstadoMod", "NO", dgvDetEgr.Rows(i).Cells.Item(6).Value)

                                    G.Grabar("muertes", "NoImagen", "feedlot.insMuerte", Format(CDate(dgvDetEgr.Rows(i).Cells.Item(7).Value), "yyyy/MM/dd"), CInt(dgvDetEgr.Rows(i).Cells.Item(0).Value), CInt(frmLogin.txtID.Text))

                                    G.Grabar("tropa", "NoImagen", "feedlot.modTropaMuerte", dgvDetEgr.Rows(i).Cells.Item(6).Value, 1)

                                    If dgvDetEgr.Rows.Count - 1 Then
                                        _Stk.ManejoStk(dgvDetEgr.Rows(i).Cells.Item(7).Value)
                                    End If
                                Next
                            End If
                        Else
                            For i As Integer = 0 To dgvDetEgr.Rows.Count - 1
                                G.Grabar("detalle_tropa", "NoImagen", "feedlot.modDetalleTropaEngorde", CInt(dgvDetEgr.Rows(i).Cells.Item(0).Value))

                                G.Grabar("tropa_bloqueo_mod", "NoImagen", "feedlot.modEstadoMod", "NO", dgvDetEgr.Rows(i).Cells.Item(6).Value)

                                If rdbVenta.Checked = True Then
                                    G.Grabar("ventas", "NoImagen", "feedlot.modBorrarEgreso", CInt(dgvDetEgr.Rows(i).Cells.Item(0).Value))
                                ElseIf rdbMuerte.Checked = True Then
                                    G.Grabar("muertes", "NoImagen", "feedlot.modBorrarMuerte", CInt(dgvDetEgr.Rows(i).Cells.Item(0).Value))
                                End If

                                If dgvDetEgr.Rows.Count - 1 Then
                                    _Stk.ManejoStk(dgvDetEgr.Rows(i).Cells.Item(7).Value)
                                End If
                            Next
                        End If

                        Cancelar()
                        txtOrigen.Text = ""
                    End If
                End If
            End If
        End If
    End Sub

    'PROCESOS COMPARTIDOS  -------------------------------------------------------------------------------------



    'PANTALLA EGRESOS -------------------------------------------------------------------------------------

    Private Sub dgvCrr_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCrr.CellClick
        If rdbVenta.Checked = True Or rdbMuerte.Checked = True Then
            AcomodarDetCrr()

            txtFechaEgr.Enabled = False
            txtFechaEgr.Text = ""

            CrtlT = False

            If dgvDetCrr.Rows.Count < 1 Then
                dgvDetCrr.ColumnHeadersVisible = False
            Else
                dgvDetCrr.ColumnHeadersVisible = True
            End If

            dgvDetCrr.Sort(dgvDetCrr.Columns("NombreTropa"), System.ComponentModel.ListSortDirection.Ascending)
            dgvDetCrr.CurrentCell = Nothing
        Else
            MsgBox("Selecciona Primero un 'tipo de Movimiento de egreso'... !", vbInformation, "Servico de Alertas")
            dgvCrr.CurrentCell = Nothing
        End If
    End Sub

    Private Sub AcomodarDetCrr()
        Dim _Dt, _Dt2 As New DataTable
        Dim _Ver, _Ver2 As New Mostrar

        If frmLogin.txtTipUs.Text = "Super Usuario" Then
            _Dt2 = _Ver2.consDetalleTropaEngorde(dgvCrr.CurrentRow.Cells.Item(0).Value)
        Else
            _Dt2 = _Ver2.consDetalleTropaEngordeUS(frmLogin.txtID.Text, dgvCrr.CurrentRow.Cells.Item(0).Value)
        End If

        dgvDetCrr.RowTemplate.Height = 25
        dgvDetCrr.DataSource = _Dt2

        dgvDetCrr.Columns("idDetTropa").Visible = False
        dgvDetCrr.Columns("Estado").Visible = False
        dgvDetCrr.Columns("idTropa").Visible = False

        dgvDetCrr.ColumnHeadersVisible = True

        Dim rowsDetEgr As Integer = dgvDetEgr.Rows.Count - 1

        For j As Integer = rowsDetEgr To 0 Step -1
            Dim rows2 As Integer = dgvDetCrr.Rows.Count - 1

            For i As Integer = rows2 To 0 Step -1
                If dgvDetEgr.Rows(j).Cells.Item(0).Value = dgvDetCrr.Rows(i).Cells.Item(3).Value Then
                    dgvDetCrr.Rows.Remove(dgvDetCrr.Rows(i))
                End If
            Next
        Next

        Dim rowsDetCrr As Integer = dgvDetCrr.Rows.Count - 1

        If rdbMuerte.Checked = True Then
            For j As Integer = rowsDetCrr To 0 Step -1
                _Dt = _Ver.verPesajeVenta(dgvDetCrr.Rows(j).Cells.Item(3).Value)

                If _Dt.Rows.Count > 0 Then
                    dgvDetCrr.Rows.Remove(dgvDetCrr.Rows(j))
                End If
            Next
        ElseIf rdbVenta.Checked = True Then
            For j As Integer = rowsDetCrr To 0 Step -1
                _Dt = _Ver.verPesajeVenta(dgvDetCrr.Rows(j).Cells.Item(3).Value)

                If _Dt.Rows.Count < 1 Then
                    dgvDetCrr.Rows.Remove(dgvDetCrr.Rows(j))
                End If
            Next
        End If
    End Sub

    Private Sub TablaDetEgr()
        dgvDetEgr.RowTemplate.Height = 25
        dgvDetEgr.ColumnCount = 8
        dgvDetEgr.Columns(0).Name = "idDetTropa"
        dgvDetEgr.Columns(1).Name = "Caravana"
        dgvDetEgr.Columns(2).Name = "Descripcion"
        dgvDetEgr.Columns(3).Name = "Tropa"
        dgvDetEgr.Columns(4).Name = "Categoria"
        dgvDetEgr.Columns(5).Name = "Estado"
        dgvDetEgr.Columns(6).Name = "idTropa"
        dgvDetEgr.Columns(7).Name = "Fecha Egr"

        dgvDetEgr.Columns(6).Visible = False
        dgvDetEgr.Columns(5).Visible = False
        dgvDetEgr.Columns(0).Visible = False

        dgvDetEgr.ColumnHeadersVisible = True
        dgvDetEgr.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None

        dgvDetEgr.Columns("Caravana").Width = 80
        dgvDetEgr.Columns("Descripcion").Width = 250
        dgvDetEgr.Columns("Tropa").Width = 180
        dgvDetEgr.Columns("Categoria").Width = 130
        dgvDetEgr.Columns("Fecha Egr").Width = 100
    End Sub

    Private Sub txtFecha_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFechaEgr.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> Keys.Enter And e.KeyChar <> ChrW(8) And e.KeyChar <> ChrW(45) And e.KeyChar <> ChrW(45) And e.KeyChar <> ChrW(117) And e.KeyChar <> ChrW(104) And e.KeyChar <> ChrW(72) Then
            e.Handled = True
        ElseIf e.KeyChar = ChrW(117) Or e.KeyChar = ChrW(85) Then
            e.Handled = True
            If dgvDetEgr.Rows.Count > 0 Then
                txtFechaEgr.Text = dgvDetEgr.Rows(dgvDetEgr.Rows.Count - 1).Cells.Item(7).Value
                txtFechaEgr.SelectionLength = Len(txtFechaEgr.Text)
                txtFechaEgr.Select()
            End If
        ElseIf e.KeyChar = ChrW(104) Or e.KeyChar = ChrW(72) Then
            e.Handled = True
            txtFechaEgr.Text = Date.Now.Date
            txtFechaEgr.SelectionLength = Len(txtFechaEgr.Text)
            txtFechaEgr.Select()
        ElseIf Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            If Not IsDate(txtFechaEgr.Text) Then
                MsgBox("Error: Formato de Fecha incorrecto.", vbExclamation, "Servico de Alertas")
                txtFechaEgr.Text = ""
                txtFechaEgr.Select()
            Else
                Dim _Dt As DataTable
                Dim _Ver As New Mostrar
                Dim Fecha, FechaI As Date

                _Dt = _Ver.verStock()

                If _Dt.Rows.Count < 1 Then
                    Fecha = Format(CDate("01/01/1777"), "dd/MM/yyyy")
                Else
                    Fecha = _Dt.Rows(_Dt.Rows.Count - 1).Item(1)
                End If

                If dgvDetCrrIng.Rows.Count < 1 Then
                    FechaI = Nothing
                Else
                    FechaI = dgvDetCrrIng.Rows(dgvDetCrrIng.Rows.Count - 1).Cells.Item(10).Value
                End If

                If Format(CDate(txtFechaEgr.Text), "dd/MM/yyyy") >= Fecha Then
                    If FechaI = txtFechaEgr.Text Or FechaI = Nothing Then
                        txtFechaEgr.Text = Format(CDate(txtFechaEgr.Text), "dd/MM/yyyy")

                        TablaDetEgr()

                        If CrtlT = False Then
                            dgvDetEgr.Rows.Add(dgvDetCrr.CurrentRow.Cells.Item(3).Value, dgvDetCrr.CurrentRow.Cells.Item(0).Value, dgvDetCrr.CurrentRow.Cells.Item(1).Value, dgvDetCrr.CurrentRow.Cells.Item(4).Value, dgvDetCrr.CurrentRow.Cells.Item(5).Value, dgvDetCrr.CurrentRow.Cells.Item(2).Value, dgvDetCrr.CurrentRow.Cells.Item(6).Value, Format(CDate(txtFechaEgr.Text), "dd/MM/yyyy"))
                            dgvDetCrr.Rows.Remove(dgvDetCrr.CurrentRow)
                        Else
                            Dim rows As Integer = dgvDetCrr.Rows.Count - 1

                            For j As Integer = rows To 0 Step -1
                                dgvDetEgr.Rows.Add(dgvDetCrr.Rows(j).Cells.Item(3).Value, dgvDetCrr.Rows(j).Cells.Item(0).Value, dgvDetCrr.Rows(j).Cells.Item(1).Value, dgvDetCrr.Rows(j).Cells.Item(4).Value, dgvDetCrr.Rows(j).Cells.Item(5).Value, dgvDetCrr.Rows(j).Cells.Item(2).Value, dgvDetCrr.Rows(j).Cells.Item(6).Value, Format(CDate(txtFechaEgr.Text), "dd/MM/yyyy"))
                                dgvDetCrr.Rows.Remove(dgvDetCrr.Rows(j))
                            Next

                            CrtlT = False
                        End If

                        dgvDetCrr.Sort(dgvDetCrr.Columns("NombreTropa"), System.ComponentModel.ListSortDirection.Ascending)
                        dgvDetCrr.CurrentCell = Nothing

                        dgvDetEgr.CurrentCell = Nothing

                        txtFechaEgr.Text = ""
                        txtFechaEgr.Enabled = False

                        If dgvDetCrr.Rows.Count < 1 Then
                            dgvDetCrr.ColumnHeadersVisible = False
                        End If
                    Else
                        MsgBox("Los Movimientos pre-cargardos deben tener todos la misma fecha... !", vbInformation, "Servico de Alertas")
                        txtFechaMov.Text = ""
                        txtFechaMov.Select()
                    End If
                Else
                    MsgBox("No puedes realizar un movimiento en un dia anterior al ultimo registro de stock... !", vbInformation, "Servico de Alertas")
                    txtFechaEgr.Text = ""
                    txtFechaEgr.Select()
                End If
            End If
        End If
        pbxRecuadro.Visible = False
        pbxRecuadro1.Visible = False
        tmrFecha.Enabled = False
    End Sub

    Private Sub dgvDetCrr_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDetCrr.CellClick
        tmrFecha.Enabled = True
        If e.RowIndex > -1 Then
            txtFechaEgr.Enabled = True
            CrtlT = False

            txtFechaEgr.SelectionLength = Len(txtFechaEgr.Text)
            txtFechaEgr.Select()
        End If
    End Sub

    Private Sub dgvDetEgr_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDetEgr.CellDoubleClick
        Dim _Dt As New DataTable
        Dim _Ver As New Mostrar

        If dgvDetEgr.Rows.Count = 1 Then
            dgvDetEgr.ColumnHeadersVisible = False
            dgvDetEgr.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        End If

        If txtOrigen.Text = "Egreso" Then
            dgvDetEgr.Rows.Remove(dgvDetEgr.CurrentRow)

            AcomodarDetCrr()

            dgvDetCrr.Sort(dgvDetCrr.Columns("NombreTropa"), System.ComponentModel.ListSortDirection.Ascending)
            dgvDetEgr.ClearSelection()
            dgvDetCrr.ClearSelection()
        Else
            dgvDetEgr.Rows.Remove(dgvDetEgr.CurrentRow)

            CargarReingreso()

            Dim rows As Integer = dgvDetEgr.Rows.Count - 1

            For j As Integer = rows To 0 Step -1
                Dim rows2 As Integer = dgvAnimEgresados.Rows.Count - 1

                For i As Integer = rows2 To 0 Step -1
                    If dgvDetEgr.Rows(j).Cells.Item(0).Value = dgvAnimEgresados.Rows(i).Cells.Item(0).Value Then
                        dgvAnimEgresados.Rows.Remove(dgvAnimEgresados.Rows(i))
                    End If
                Next
            Next

            dgvAnimEgresados.Sort(dgvAnimEgresados.Columns("Tropa"), System.ComponentModel.ListSortDirection.Ascending)

            dgvAnimEgresados.CurrentCell = Nothing
            dgvDetEgr.CurrentCell = Nothing
        End If
    End Sub

    Private Sub DesabilitarReingreso()
        txtOrigen.Text = "Egreso"

        btnCancelarMod.Visible = False
        btnModEgr.Visible = True

        dgvCrr.Enabled = True
        dgvDetCrr.Enabled = True
        dgvAnimEgresados.Enabled = False

        dgvAnimEgresados.BackgroundColor = Color.DimGray

        lblLn4.BackColor = Color.DimGray
        lblDetAnimEgr.ForeColor = Color.DimGray
        lblMsgAnimEgr.BackColor = Color.DimGray

        lblLn.BackColor = Color.BurlyWood
        lblCrr.ForeColor = Color.BurlyWood
        lblMsgCrr.BackColor = Color.BurlyWood

        lblLn2.BackColor = Color.BurlyWood
        lblDetR.ForeColor = Color.BurlyWood
        lblMsgDetCrr.BackColor = Color.BurlyWood

        lblMsgCrr.Text = "Nota: ""Sólo Corrales Con Stock"""
        lblMsgAnimEgr.Text = ""
        lblMsgDetEgr.Text = "Nota: ""Animales Seleccionados para Egreso por Muerte ó por Venta"""
        lblDet.Text = "  Detalle de Animales Seleccionados Para Egreso  "

        If rdbMuerte.Checked = True Then
            lblMsgDetCrr.Text = "Nota:  ""No se visualizan animales con peso de venta cargado"""
        ElseIf rdbVenta.Checked = True Then
            lblMsgDetCrr.Text = "Nota:  ""Sólo se visualizan animales con peso de venta cargado"" - ""<CTRL+T> = Selecciona todo"""
        End If

        dgvCrr.BackgroundColor = Color.BurlyWood
        dgvDetCrr.BackgroundColor = Color.BurlyWood

        LimpiarListasEgreso(True, True, True)
        CargarCorrales(dgvCrr)
    End Sub

    Private Sub HabilitarReingreso()
        txtOrigen.Text = "ModEgreso"

        btnCancelarMod.Visible = True
        btnModEgr.Visible = False

        dgvCrr.Enabled = False
        dgvDetCrr.Enabled = False
        dgvAnimEgresados.Enabled = True

        dgvAnimEgresados.BackgroundColor = Color.BurlyWood

        lblLn4.BackColor = Color.BurlyWood
        lblDetAnimEgr.ForeColor = Color.BurlyWood
        lblMsgAnimEgr.BackColor = Color.BurlyWood

        lblLn.BackColor = Color.DimGray
        lblCrr.ForeColor = Color.DimGray
        lblMsgCrr.BackColor = Color.DimGray

        lblLn2.BackColor = Color.DimGray
        lblDetR.ForeColor = Color.DimGray
        lblMsgDetCrr.BackColor = Color.DimGray

        lblMsgCrr.Text = ""
        lblMsgDetCrr.Text = ""

        lblMsgDetEgr.Text = "Nota: ""Animales Seleccionados para Reingreso"""

        lblDet.Text = "  Detalle de Animales Seleccionados Para Reingreso  "

        If rdbVenta.Checked = True Then
            lblMsgAnimEgr.Text = "Nota:  ""Animales que Egresaron como Vendidos hasta el ultimo movimiento de stock"""
        ElseIf rdbMuerte.Checked = True Then
            lblMsgAnimEgr.Text = "Nota:  ""Animales que Egresaron como Muertos hasta el ultimo movimiento de stock"""
        End If

        dgvCrr.BackgroundColor = Color.DimGray
        dgvDetCrr.BackgroundColor = Color.DimGray

        LimpiarListasEgreso(True, True, False)

        dgvCrr.DataSource = Nothing

        dgvAnimEgresados.Columns(0).Visible = False
        dgvAnimEgresados.Columns(1).Visible = True
        dgvAnimEgresados.Columns(2).Visible = True
        dgvAnimEgresados.Columns(3).Visible = True
        dgvAnimEgresados.Columns(4).Visible = True
        dgvAnimEgresados.Columns(5).Visible = False
        dgvAnimEgresados.Columns(6).Visible = False
        dgvAnimEgresados.Columns(7).Visible = True

        dgvAnimEgresados.ColumnHeadersVisible = True
        dgvAnimEgresados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None

        dgvAnimEgresados.Columns("Caravana").Width = 100
        dgvAnimEgresados.Columns("Descripcion").Width = 250
        dgvAnimEgresados.Columns("Tropa").Width = 180
        dgvAnimEgresados.Columns("Categoria").Width = 130
        dgvAnimEgresados.Columns("Fecha Egr").Width = 120

        dgvAnimEgresados.Sort(dgvAnimEgresados.Columns("Tropa"), System.ComponentModel.ListSortDirection.Ascending)
        dgvAnimEgresados.ClearSelection()
    End Sub

    Private Sub CargarReingreso()
        Dim _Dt, _Dt2, _Dt3 As New DataTable
        Dim _Ver As New Mostrar

        dgvAnimEgresados.RowTemplate.Height = 25
        dgvAnimEgresados.ColumnCount = 8
        dgvAnimEgresados.Columns(0).Name = "idDetTropa"
        dgvAnimEgresados.Columns(1).Name = "Caravana"
        dgvAnimEgresados.Columns(2).Name = "Descripcion"
        dgvAnimEgresados.Columns(3).Name = "Tropa"
        dgvAnimEgresados.Columns(4).Name = "Categoria"
        dgvAnimEgresados.Columns(5).Name = "Estado"
        dgvAnimEgresados.Columns(6).Name = "idTropa"
        dgvAnimEgresados.Columns(7).Name = "Fecha Egr"

        dgvAnimEgresados.Columns(0).Visible = False
        dgvAnimEgresados.Columns(1).Visible = False
        dgvAnimEgresados.Columns(2).Visible = False
        dgvAnimEgresados.Columns(3).Visible = False
        dgvAnimEgresados.Columns(4).Visible = False
        dgvAnimEgresados.Columns(5).Visible = False
        dgvAnimEgresados.Columns(6).Visible = False
        dgvAnimEgresados.Columns(7).Visible = False

        If rdbVenta.Checked = True Then
            If frmLogin.txtTipUs.Text = "Super Usuario" Then
                _Dt = _Ver.consDetalleTropaVendido()
            Else
                _Dt = _Ver.consDetalleTropaVendidoUS(frmLogin.txtID.Text)
            End If

            _Dt2 = _Ver.verStock()

            Dim rows As Integer = _Dt.Rows.Count - 1
            Dim VenStk As Boolean = False

            _Dt3 = _Ver.verVentas_HastaUltStk(_Dt2.Rows(_Dt2.Rows.Count - 1).Item(1))

            Dim rows2 As Integer = _Dt3.Rows.Count - 1

            For j As Integer = rows2 To 0 Step -1
                For i As Integer = rows To 0 Step -1
                    If _Dt.Rows(i).Item(3) <> _Dt3.Rows(j).Item(16) Then
                        VenStk = True
                    Else
                        VenStk = False
                    End If

                    If VenStk = False Then
                        dgvAnimEgresados.Rows.Add(_Dt.Rows(i).Item(3), _Dt.Rows(i).Item(0), _Dt.Rows(i).Item(1), _Dt.Rows(i).Item(4), _Dt.Rows(i).Item(5), _Dt.Rows(i).Item(2), _Dt.Rows(i).Item(6), Format(CDate(_Dt3.Rows(j).Item(1)), "yyyy/MM/dd"))
                    End If
                Next
            Next
        ElseIf rdbMuerte.Checked = True Then
            If frmLogin.txtTipUs.Text = "Super Usuario" Then
                _Dt = _Ver.consDetalleTropaMuerto()
            Else
                _Dt = _Ver.consDetalleTropaMuertoUS(frmLogin.txtID.Text)
            End If

            _Dt2 = _Ver.verStock()

            Dim rows As Integer = _Dt.Rows.Count - 1
            Dim MuerteStk As Boolean = False

            _Dt3 = _Ver.verMuertes_HastaUltStk(_Dt2.Rows(_Dt2.Rows.Count - 1).Item(1))

            Dim rows2 As Integer = _Dt3.Rows.Count - 1

            For j As Integer = rows2 To 0 Step -1
                For i As Integer = rows To 0 Step -1
                    If _Dt.Rows(i).Item(3) <> _Dt3.Rows(j).Item(2) Then
                        MuerteStk = True
                    Else
                        MuerteStk = False
                    End If

                    If MuerteStk = False Then
                        dgvAnimEgresados.Rows.Add(_Dt.Rows(i).Item(3), _Dt.Rows(i).Item(0), _Dt.Rows(i).Item(1), _Dt.Rows(i).Item(4), _Dt.Rows(i).Item(5), _Dt.Rows(i).Item(2), _Dt.Rows(i).Item(6), Format(CDate(_Dt3.Rows(j).Item(1)), "yyyy/MM/dd"))
                    End If
                Next
            Next
        Else
            MsgBox("Selecciona Primero un 'tipo de Movimiento de egreso'... !", vbInformation, "Servico de Alertas")
        End If

        If dgvAnimEgresados.Rows.Count > 0 Then
            HabilitarReingreso()
        Else
            If rdbVenta.Checked = True Then
                MsgBox("No se encontraron animales egresados como 'Vendidos' con posibilidad de reingreso... !", vbInformation, "Servico de Alertas")
            ElseIf rdbMuerte.Checked = True Then
                MsgBox("No se encontraron animales egresados como 'Muertos' con posibilidad de reingreso... !", vbInformation, "Servico de Alertas")
            End If

            DesabilitarReingreso()
            dgvCrr.ClearSelection()
            dgvCrr.CurrentCell = Nothing
        End If
    End Sub

    Private Sub btnModEgr_Click(sender As Object, e As EventArgs) Handles btnModEgr.Click
        CargarReingreso()
    End Sub

    Private Sub btnCancelarMod_Click(sender As Object, e As EventArgs) Handles btnCancelarMod.Click
        DesabilitarReingreso()
    End Sub

    Private Sub dgvAnimEgresados_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAnimEgresados.CellDoubleClick
        If e.RowIndex > -1 Then
            If dgvAnimEgresados.Rows.Count = 1 Then
                dgvAnimEgresados.ColumnHeadersVisible = False
                dgvAnimEgresados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            End If

            TablaDetEgr()

            dgvDetEgr.Rows.Add(dgvAnimEgresados.CurrentRow.Cells.Item(0).Value, dgvAnimEgresados.CurrentRow.Cells.Item(1).Value, dgvAnimEgresados.CurrentRow.Cells.Item(2).Value, dgvAnimEgresados.CurrentRow.Cells.Item(3).Value, dgvAnimEgresados.CurrentRow.Cells.Item(4).Value, dgvAnimEgresados.CurrentRow.Cells.Item(5).Value, dgvAnimEgresados.CurrentRow.Cells.Item(6).Value, dgvAnimEgresados.CurrentRow.Cells.Item(7).Value)
            dgvAnimEgresados.Rows.Remove(dgvAnimEgresados.CurrentRow)

            dgvAnimEgresados.Sort(dgvAnimEgresados.Columns("Tropa"), System.ComponentModel.ListSortDirection.Ascending)
            dgvAnimEgresados.CurrentCell = Nothing

            dgvDetEgr.CurrentCell = Nothing
        End If
    End Sub

    Private Sub TipoMovEgr_CheckedChanged(sender As Object, e As EventArgs) Handles rdbVenta.CheckedChanged, rdbMuerte.CheckedChanged
        If rdbVenta.Checked = True Then
            rdbVenta.BackColor = Color.Moccasin
            rdbVenta.ForeColor = Color.LightSlateGray
        Else
            rdbVenta.BackColor = Color.LightSlateGray
            rdbVenta.ForeColor = Color.Moccasin
        End If

        If rdbMuerte.Checked = True Then
            rdbMuerte.BackColor = Color.Moccasin
            rdbMuerte.ForeColor = Color.LightSlateGray
        Else
            rdbMuerte.BackColor = Color.LightSlateGray
            rdbMuerte.ForeColor = Color.Moccasin
        End If

        LimpiarListasEgreso(False, True, True)

        txtFechaEgr.Enabled = False
        txtFechaEgr.Text = ""

        CrtlT = False

        If rdbMuerte.Checked = True Or rdbVenta.Checked = True Then
            If txtOrigen.Text = "ModEgreso" Then

                CargarReingreso()
            Else
                If dgvDetCrr.Rows.Count < 1 Then
                    dgvDetCrr.ColumnHeadersVisible = False
                Else
                    dgvDetCrr.ColumnHeadersVisible = True
                End If

                If rdbMuerte.Checked = True Then
                    lblMsgDetCrr.Text = "Nota:  ""No se visualizan animales con peso de venta cargado"""
                ElseIf rdbVenta.Checked = True Then
                    lblMsgDetCrr.Text = "Nota:  ""Sólo se visualizan animales con peso de venta cargado"" - ""<CTRL+T> = Selecciona todo"""
                End If

                If dgvCrr.CurrentCell IsNot Nothing Then
                    AcomodarDetCrr()

                    dgvDetCrr.Sort(dgvDetCrr.Columns("NombreTropa"), System.ComponentModel.ListSortDirection.Ascending)
                    dgvDetCrr.CurrentCell = Nothing
                End If
            End If
        End If
    End Sub

    Private Sub LimpiarListasEgreso(ByVal _DgvDetCrr As Boolean, ByVal _DgvDetEgr As Boolean, ByVal _DgvAnimEgresados As Boolean)
        If _DgvDetCrr = True Then
            Dim rowsDetCrr As Integer = dgvDetCrr.Rows.Count - 1

            If dgvDetCrr.Rows.Count > 0 Then
                For j As Integer = rowsDetCrr To 0 Step -1
                    dgvDetCrr.Rows.Remove(dgvDetCrr.Rows(j))
                Next
            End If

            dgvDetCrr.ColumnHeadersVisible = False
            dgvDetCrr.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        End If

        If _DgvDetEgr = True Then
            Dim rowsDetEgr As Integer = dgvDetEgr.Rows.Count - 1

            If dgvDetEgr.Rows.Count > 0 Then
                For j As Integer = rowsDetEgr To 0 Step -1
                    dgvDetEgr.Rows.Remove(dgvDetEgr.Rows(j))
                Next
            End If

            dgvDetEgr.ColumnHeadersVisible = False
            dgvDetEgr.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        End If

        If _DgvAnimEgresados = True Then
            Dim rowsAnimEgr As Integer = dgvAnimEgresados.Rows.Count - 1

            If dgvAnimEgresados.Rows.Count > 0 Then
                For j As Integer = rowsAnimEgr To 0 Step -1
                    dgvAnimEgresados.Rows.Remove(dgvAnimEgresados.Rows(j))
                Next
            End If

            dgvAnimEgresados.ColumnHeadersVisible = False
            dgvAnimEgresados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        End If
    End Sub

    'PANTALLA EGRESOS -------------------------------------------------------------------------------------

    Private Sub tmrFecha_Tick(sender As Object, e As EventArgs) Handles tmrFecha.Tick
        If gbxEgresos.Visible = True Then
            If pbxRecuadro.Visible = True Then
                pbxRecuadro.Visible = False
            Else
                pbxRecuadro.Visible = True
            End If
        End If
        If gbxMovInterno.Visible = True Then
            If pbxRecuadro1.Visible = True Then
                pbxRecuadro1.Visible = False
            Else
                pbxRecuadro1.Visible = True
            End If
        End If
    End Sub

End Class