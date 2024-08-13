Public Class frmParametros

    Private Sub txtPesoInicial_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPesoInicial.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> Keys.Enter And e.KeyChar <> ChrW(8) Then
            e.Handled = True
        ElseIf Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtPesoFinal.SelectionLength = Len(txtPesoFinal.Text)
            txtPesoFinal.Select()
        End If
    End Sub

    Private Sub txtPesoFinal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPesoFinal.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> Keys.Enter And e.KeyChar <> ChrW(8) Then
            e.Handled = True
        ElseIf Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtCoefConsumo.SelectionLength = Len(txtCoefConsumo.Text)
            txtCoefConsumo.Select()
        End If
    End Sub

    Private Sub txtCoefConsumo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCoefConsumo.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> Keys.Enter And e.KeyChar <> ChrW(8) And e.KeyChar <> ChrW(46) Then
            e.Handled = True
        ElseIf Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            pbxNuevaTablaADPV.Select()
        End If
    End Sub

    Private Sub btnADVP(ByVal sender As System.Object, ByVal e As KeyPressEventArgs)
        If Asc(e.KeyChar) = Keys.Enter Then
            pbxTablaADPV_Click(1, Nothing)
        End If
    End Sub

    Private Sub btnNuevoADVP(ByVal sender As System.Object, ByVal e As KeyPressEventArgs)
        If Asc(e.KeyChar) = Keys.Enter Then
            pbxNuevaTablaADPV_Click(1, Nothing)
        End If
    End Sub

    Private Sub btnConsumo(ByVal sender As System.Object, ByVal e As KeyPressEventArgs)
        If Asc(e.KeyChar) = Keys.Enter Then
            pbxTablaConsumo_Click(1, Nothing)
        End If
    End Sub

    Private Sub frmParametros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim _Ver As New Mostrar
        Dim _Dt As New DataTable
        Dim ctlADVP As Control = DirectCast(pbxTablaADPV, Control)
        Dim keyprADVP = New KeyPressEventHandler(AddressOf btnADVP)
        Dim ctlNuevoADVP As Control = DirectCast(pbxNuevaTablaADPV, Control)
        Dim keyprNuevoADVP = New KeyPressEventHandler(AddressOf btnNuevoADVP)
        Dim ctlConsumo As Control = DirectCast(pbxTablaConsumo, Control)
        Dim keyprConsumo = New KeyPressEventHandler(AddressOf btnConsumo)

        AddHandler ctlADVP.KeyPress, keyprADVP
        AddHandler ctlNuevoADVP.KeyPress, keyprNuevoADVP
        AddHandler ctlConsumo.KeyPress, keyprConsumo

        _Dt = _Ver.verADPV()
        dgvTablas.DataSource = _Dt

        lblMensaje.Text = "TABLA AUMENTO DIARIO DE PESO VIVVO..."
        dgvTablas.Columns("idADPV").Visible = False
        dgvTablas.Columns("PESO").HeaderText = "PESO VIVO"
        dgvTablas.Columns("PESO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvTablas.Columns("PESO").DefaultCellStyle.Format = "#,##0"
        dgvTablas.Columns("GPV").HeaderText = "GANANCIA DE PESO VIVO (GRS)"
        dgvTablas.Columns("GPV").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvTablas.Columns("GPV").DefaultCellStyle.Format = "#,##0.000"

        pbxTablaADPV.Select()
    End Sub

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

    Private Sub pbxTablaADPV_GotFocus(sender As Object, e As EventArgs) Handles pbxTablaADPV.GotFocus
        If (pbxTablaADPV.Enabled = True) Then
            pbxTablaADPV.BackgroundImage = SITRABO.My.Resources.btnADPVSi
        End If
    End Sub

    Private Sub pbxTablaADPV_LostFocus(sender As Object, e As EventArgs) Handles pbxTablaADPV.LostFocus
        If (pbxTablaADPV.Enabled = True) Then
            pbxTablaADPV.BackgroundImage = SITRABO.My.Resources.btnADPVNo
        End If
    End Sub

    Private Sub pbxTablaADPV_MouseEnter(sender As Object, e As EventArgs) Handles pbxTablaADPV.MouseEnter
        If (pbxTablaADPV.Enabled = True) Then
            pbxTablaADPV.BackgroundImage = SITRABO.My.Resources.btnADPVSi
        End If
    End Sub

    Private Sub pbxTablaADPV_MouseLeave(sender As Object, e As EventArgs) Handles pbxTablaADPV.MouseLeave
        If (pbxTablaADPV.Enabled = True) Then
            pbxTablaADPV.BackgroundImage = SITRABO.My.Resources.btnADPVNo
        End If
    End Sub

    Private Sub pbxTablaConsumo_GotFocus(sender As Object, e As EventArgs) Handles pbxTablaConsumo.GotFocus
        If (pbxTablaConsumo.Enabled = True) Then
            pbxTablaConsumo.BackgroundImage = SITRABO.My.Resources.btnConsumoSi
        End If
    End Sub

    Private Sub pbxTablaConsumo_LostFocus(sender As Object, e As EventArgs) Handles pbxTablaConsumo.LostFocus
        If (pbxTablaConsumo.Enabled = True) Then
            pbxTablaConsumo.BackgroundImage = SITRABO.My.Resources.btnConsumoNo
        End If
    End Sub

    Private Sub pbxTablaConsumo_MouseEnter(sender As Object, e As EventArgs) Handles pbxTablaConsumo.MouseEnter
        If (pbxTablaConsumo.Enabled = True) Then
            pbxTablaConsumo.BackgroundImage = SITRABO.My.Resources.btnConsumoSi
        End If
    End Sub

    Private Sub pbxTablaConsumo_MouseLeave(sender As Object, e As EventArgs) Handles pbxTablaConsumo.MouseLeave
        If (pbxTablaConsumo.Enabled = True) Then
            pbxTablaConsumo.BackgroundImage = SITRABO.My.Resources.btnConsumoNo
        End If
    End Sub

    Private Sub pbxNuevaTablaADPV_GotFocus(sender As Object, e As EventArgs) Handles pbxNuevaTablaADPV.GotFocus
        pbxNuevaTablaADPV.BackgroundImage = SITRABO.My.Resources.btnNuevoADPVSi
    End Sub

    Private Sub pbxNuevaTablaADPV_LostFocus(sender As Object, e As EventArgs) Handles pbxNuevaTablaADPV.LostFocus
        pbxNuevaTablaADPV.BackgroundImage = SITRABO.My.Resources.btnNuevoADPVNo
    End Sub

    Private Sub pbxNuevaTablaADPV_MouseEnter(sender As Object, e As EventArgs) Handles pbxNuevaTablaADPV.MouseEnter
        pbxNuevaTablaADPV.BackgroundImage = SITRABO.My.Resources.btnNuevoADPVSi
    End Sub

    Private Sub pbxNuevaTablaADPV_MouseLeave(sender As Object, e As EventArgs) Handles pbxNuevaTablaADPV.MouseLeave
        pbxNuevaTablaADPV.BackgroundImage = SITRABO.My.Resources.btnNuevoADPVNo
    End Sub

    Private Sub pbxSalir_Click(sender As Object, e As EventArgs) Handles pbxSalir.Click
        Me.Close()
    End Sub

    Private Sub pbxTablaADPV_Click(sender As Object, e As EventArgs) Handles pbxTablaADPV.Click
        pbxTablaADPV.BackgroundImage = SITRABO.My.Resources.btnADPVSi
        pbxTablaConsumo.BackgroundImage = SITRABO.My.Resources.btnConsumoNo
        pbxTablaADPV.Enabled = False
        pbxTablaConsumo.Enabled = True

        pbxNuevaTablaADPV.Visible = True
        lblMensaje.Visible = True
        dgvTablas.Visible = True
        gbxParametros.Visible = True
        dgvTablas.CurrentCell = Nothing
    End Sub

    Private Sub pbxNuevaTablaADPV_Click(sender As Object, e As EventArgs) Handles pbxNuevaTablaADPV.Click
        Dim resP As DialogResult
        Dim G As New GrabaDatos
        Dim _Ver As New Mostrar
        Dim _Dt As New DataTable

        If txtPesoFinal.Text = 0 Then
            MsgBox("Error: El peso final no puede ser 0... !", vbExclamation, "Servico de Alertas")
            txtPesoFinal.Select()
        Else
            If txtPesoInicial.Text = 0 Then
                MsgBox("Error: El peso inicial no puede ser 0... !", vbExclamation, "Servico de Alertas")
                txtPesoInicial.Select()
            Else
                If CDbl(txtPesoInicial.Text) >= CDbl(txtPesoFinal.Text) Then
                    MsgBox("Error: El peso final no puede ser menor al peso inicial... !", vbExclamation, "Servico de Alertas")
                    txtPesoFinal.Select()
                Else
                    If txtCoefConsumo.Text = 0 Then
                        MsgBox("Error: El coeficiente de consumo no puede ser de 0%... !", vbExclamation, "Servico de Alertas")
                        txtCoefConsumo.Select()
                    Else
                        resP = MessageBox.Show("Actualizar tabla de Aumento Diario de Peso Vivo ?", "Servico de Alertas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

                        If resP = Windows.Forms.DialogResult.OK Then
                            Dim pI, adP, CG, PesIn, PesFin, CoefCon As Double
                            gbxParametros.Enabled = False
                            lblMensaje.Text = "ACTUALIZANDO TABLA ADPV..."
                            lblMensaje.Refresh()

                            G.Grabar("adpv", "NoImagen", "feedlot.eliTablaADPV")
                            G.Grabar("peso_dias_consumo_0_100", "NoImagen", "feedlot.eliTablaPesoEstimado")

                            _Dt = _Ver.verADPV()
                            dgvTablas.DataSource = _Dt
                            dgvTablas.Refresh()

                            PesIn = txtPesoInicial.Text
                            PesFin = txtPesoFinal.Text
                            CoefCon = txtCoefConsumo.Text / 100

                            CG = 6

                            For x = PesIn To PesFin
                                pI = x
                                adP = (pI * CoefCon) / CG

                                If x < 140 Then
                                    CG = CG + 0.017
                                ElseIf x < 200 Then
                                    CG = CG + 0.009
                                ElseIf x < 300 Then
                                    CG = CG + 0.001
                                ElseIf x < 400 Then
                                    CG = CG + 0.0006
                                ElseIf x > 500 Then
                                    CG = CG + 0.006
                                End If

                                If x = 500 Then
                                    CoefCon = (CoefCon * 100) - 0.3
                                    CoefCon = CoefCon / 100
                                End If

                                G.Grabar("adpv", "NoImagen", "feedlot.insADPV", CInt(pI), Format(adP, "#,##0.000"))
                            Next

                            _Dt = _Ver.verADPV()
                            dgvTablas.DataSource = _Dt
                            lblMensaje.Text = "ACTUALIZANDO TABLA DE PESOS ESTIMADOS..."
                            lblMensaje.Refresh()

                            Dim j As Integer
                            Dim Val As Double
                            Dim Pesos(100) As Integer

                            For i = PesIn To PesFin
                                Val = i
                                j = 0

                                For Each _Dr As DataRow In _Dt.Rows
                                    If _Dr("PESO") >= i And j < 100 Then
                                        Val = Val + _Dr("GPV")
                                        Pesos(j) = Val
                                        j = j + 1
                                    End If
                                Next

                                G.Grabar("pesos_estimados", "NoImagen", "feedlot.insTablaPesoEstimado", i, Pesos(0), Pesos(1), Pesos(2), Pesos(3), Pesos(4), Pesos(5), _
                                         Pesos(6), Pesos(7), Pesos(8), Pesos(9), Pesos(10), Pesos(11), Pesos(12), Pesos(13), Pesos(14), Pesos(15), Pesos(16), Pesos(17), _
                                         Pesos(18), Pesos(19), Pesos(20), Pesos(21), Pesos(22), Pesos(23), Pesos(24), Pesos(25), Pesos(26), Pesos(27), Pesos(28), Pesos(29), _
                                         Pesos(30), Pesos(31), Pesos(32), Pesos(33), Pesos(34), Pesos(35), Pesos(36), Pesos(37), Pesos(38), Pesos(39), Pesos(40), Pesos(41), _
                                         Pesos(42), Pesos(43), Pesos(44), Pesos(45), Pesos(46), Pesos(47), Pesos(48), Pesos(49), Pesos(50), Pesos(51), Pesos(52), Pesos(53), _
                                         Pesos(54), Pesos(55), Pesos(56), Pesos(57), Pesos(58), Pesos(59), Pesos(60), Pesos(61), Pesos(62), Pesos(63), Pesos(64), Pesos(65), _
                                         Pesos(66), Pesos(67), Pesos(68), Pesos(69), Pesos(70), Pesos(71), Pesos(72), Pesos(73), Pesos(74), Pesos(75), Pesos(76), Pesos(77), _
                                         Pesos(78), Pesos(79), Pesos(80), Pesos(81), Pesos(82), Pesos(83), Pesos(84), Pesos(85), Pesos(86), Pesos(87), Pesos(88), Pesos(89), _
                                         Pesos(90), Pesos(91), Pesos(92), Pesos(93), Pesos(94), Pesos(95), Pesos(96), Pesos(97), Pesos(98), Pesos(99))
                            Next

                            lblMensaje.Text = "TABLAS ACTUALIZADAS !"

                            txtPesoFinal.Text = "0"
                            txtPesoInicial.Text = "0"
                            txtCoefConsumo.Text = "0.00"

                            dgvTablas.Visible = True
                            gbxParametros.Enabled = True
                            dgvTablas.CurrentCell = Nothing

                            txtPesoInicial.SelectionLength = Len(txtPesoInicial.Text)
                            txtPesoInicial.Select()
                        Else
                            lblMensaje.Text = "OPERACION CANCELADA POR USUSARIO..."
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub pbxTablaConsumo_Click(sender As Object, e As EventArgs) Handles pbxTablaConsumo.Click
        pbxTablaConsumo.BackgroundImage = SITRABO.My.Resources.btnConsumoSi
        pbxTablaADPV.BackgroundImage = SITRABO.My.Resources.btnADPVNo
        pbxTablaADPV.Enabled = True
        pbxTablaConsumo.Enabled = False
    End Sub
End Class