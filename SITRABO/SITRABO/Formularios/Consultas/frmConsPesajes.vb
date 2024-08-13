Public Class frmConsPesajes

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


    Private Sub FrmConsPesajes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim _Dt, _Dt2 As DataTable
        Dim _Ver, _Ver2 As New Mostrar
        Dim _Row, _Row2 As DataRow
        Dim UltFecha, PrimFecha As Date
        Dim x As Integer = 0

        _Dt = _Ver.verMaxFecPesaje()
        _Row = _Dt.Rows(_Dt.Rows.Count - 1)

        If _Row("UltimaFecPeso").ToString = "" Then
            UltFecha = Date.Now.Date
        Else
            UltFecha = _Row("UltimaFecPeso")
        End If

        _Dt2 = _Ver2.verMinFecPesaje()
        _Row2 = _Dt2.Rows(_Dt2.Rows.Count - 1)

        If _Row2("PrimerPesaje").ToString = "" Then
            PrimFecha = Date.Now.Date
        Else
            PrimFecha = _Row2("PrimerPesaje")
        End If

        dtmFdesde.MinDate = PrimFecha
        dtmFdesde.MaxDate = UltFecha

        dtmFdesde.Value = UltFecha
        dtmFdesde.Value = UltFecha

        If frmLogin.txtTipUs.Text = "Super Usuario" Then
            _Dt = _Ver.verProductor()
        Else
            _Dt = _Ver.verProductorUs(frmLogin.txtID.Text)
        End If

        cbxProductor.Items.Clear()
        For Each Fila As DataRow In _Dt.Rows
            cbxProductor.Items.Add(Fila("RazonSocial"))
        Next

        If frmLogin.txtTipUs.Text = "Super Usuario" Then
            _Dt = _Ver.verTropas()
        Else
            _Dt = _Ver.verTropaUs(frmLogin.txtID.Text)
        End If

        cbxTropa.Items.Clear()
        For Each Fila As DataRow In _Dt.Rows
            cbxTropa.Items.Add(Fila("NombreTropa"))
        Next

        If frmLogin.txtTipUs.Text = "Super Usuario" Then
            _Dt = _Ver.verCorrales()
        Else
            _Dt = _Ver.verCorralesUs(frmLogin.txtID.Text)
        End If

        cbxCorral.Items.Clear()
        For Each Fila As DataRow In _Dt.Rows
            cbxCorral.Items.Add(Fila("NombreCorral"))
        Next

        dgvPesos.ColumnHeadersVisible = False
        dgvPesos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells

        Me.Text = "Si.Tra.Bo. - Sistema de Trazabilidad Bovina" & " - USUARIO: " & frmLogin.txtNom.Text & " " & frmLogin.txtAp.Text & " -"
    End Sub

    Private Sub pbxSalir_Click(sender As Object, e As EventArgs) Handles pbxSalir.Click
        Me.Close()
    End Sub

    Private Sub DesCkek()
        cbxTropa.Enabled = False
        cbxProductor.Enabled = False
        cbxCorral.Enabled = False
        txtCaravana.Enabled = False

        cbxTropa.Text = ""
        cbxProductor.Text = ""
        cbxCorral.Text = ""
        txtCaravana.Text = ""
    End Sub

    Private Sub chbFdesde_CheckedChanged(sender As Object, e As EventArgs) Handles chbFdesde.CheckedChanged
        If chbFdesde.Checked = True Then
            dtmFdesde.Enabled = True
            dtmFdesde.Select()
        Else
            dtmFdesde.Enabled = False
            dtmFdesde.Text = dtmFdesde.MaxDate
        End If
    End Sub

    Private Sub chbFhasta_CheckedChanged(sender As Object, e As EventArgs) Handles chbFhasta.CheckedChanged
        If chbFhasta.Checked = True Then
            dtmFhasta.Enabled = True
            dtmFhasta.Select()
        Else
            dtmFhasta.Enabled = False
            dtmFhasta.Text = dtmFdesde.MaxDate
        End If
    End Sub

    Private Sub chbTropa_CheckedChanged(sender As Object, e As EventArgs) Handles chbTropa.CheckedChanged
        If chbTropa.Checked = True Then
            DesCkek()

            chbCorral.Checked = False
            chbProd.Checked = False
            chbCarav.Checked = False

            cbxTropa.Enabled = True
            cbxTropa.Select()
        Else
            cbxTropa.Enabled = False
            cbxTropa.Text = ""
        End If
    End Sub

    Private Sub chbProd_CheckedChanged(sender As Object, e As EventArgs) Handles chbProd.CheckedChanged
        If chbProd.Checked = True Then
            DesCkek()

            chbTropa.Checked = False
            chbCorral.Checked = False
            chbCarav.Checked = False

            cbxProductor.Enabled = True
            cbxProductor.Select()
        Else
            cbxProductor.Enabled = False
            cbxProductor.Text = ""
        End If
    End Sub

    Private Sub chbCorral_CheckedChanged(sender As Object, e As EventArgs) Handles chbCorral.CheckedChanged
        If chbCorral.Checked = True Then
            DesCkek()

            chbTropa.Checked = False
            chbProd.Checked = False
            chbCarav.Checked = False

            cbxCorral.Enabled = True
            cbxCorral.Select()
        Else
            cbxCorral.Enabled = False
            cbxCorral.Text = ""
        End If
    End Sub

    Private Sub chbCarav_CheckedChanged(sender As Object, e As EventArgs) Handles chbCarav.CheckedChanged
        If chbCarav.Checked = True Then
            DesCkek()

            chbTropa.Checked = False
            chbCorral.Checked = False
            chbProd.Checked = False

            txtCaravana.Enabled = True
            txtCaravana.BackColor = Color.SaddleBrown
            frmConsCaravanas.ShowDialog()
            txtCaravana.Select()
        Else
            txtCaravana.Enabled = False
            txtCaravana.BackColor = Color.White
            txtCaravana.Text = ""
        End If
    End Sub

    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click
        If (chbFdesde.Checked = True Or chbFhasta.Checked = True) And (chbProd.Checked = False And chbTropa.Checked = False And chbCorral.Checked = False And chbCarav.Checked = False) Then
            If Format(CDate(dtmFdesde.Text), "yyyy/MM/dd") <= Format(CDate(dtmFhasta.Text), "yyyy/MM/dd") Then

                gbxConsPesaje.Visible = True
                gbxConsPesaje.Enabled = True

                lblDetalleConsulta.Text = "PESAJES POR FECHA, DESDE " & dtmFdesde.Value & " HASTA " & dtmFhasta.Value

                frmFiltrandoAlimentacion.Show()
                frmFiltrandoAlimentacion.Refresh()

                Dim _Dt As New DataTable
                Dim _Ver As New Mostrar

                _Dt = _Ver.verPesajeFecha(dtmFdesde.Value, dtmFhasta.Value)

                PesajeCalcular(_Dt)

                frmFiltrandoAlimentacion.Close()
            Else
                MsgBox("Error: La fecha DESDE no puede ser mayor que la decha HASTA !", vbExclamation, "Servico de Alertas")
            End If

        ElseIf chbProd.Checked = False And chbTropa.Checked = True And chbCorral.Checked = False And chbCarav.Checked = False Then
            gbxConsPesaje.Visible = True
            gbxConsPesaje.Enabled = True

            frmFiltrandoAlimentacion.Show()
            frmFiltrandoAlimentacion.Refresh()

            Dim _Dt As New DataTable
            Dim _Ver As New Mostrar

            _Dt = _Ver.verTropas()

            For Each _Dr As DataRow In _Dt.Rows
                If _Dr("NombreTropa") = cbxTropa.Text Then
                    txtIdT.Text = _Dr("idTropa")
                End If
            Next

            If chbFdesde.Checked = False And chbFhasta.Checked = False Then
                lblDetalleConsulta.Text = "PESAJE POR TROPA: " & cbxTropa.Text
                _Dt = _Ver.verPesajeTropaInicioFin(CInt(txtIdT.Text))
            Else
                If chbFdesde.Checked = True And chbFhasta.Checked = True Then
                    If Format(CDate(dtmFdesde.Text), "yyyy/MM/dd") <= Format(CDate(dtmFhasta.Text), "yyyy/MM/dd") Then
                        lblDetalleConsulta.Text = "PESAJES POR FECHA Y TROPA: DESDE " & dtmFdesde.Value & " HASTA " & dtmFhasta.Value & ", TROPA: " & cbxTropa.Text
                        _Dt = _Ver.verPesajeFechaTropa(dtmFdesde.Value, dtmFhasta.Value, CInt(txtIdT.Text))
                    Else
                        MsgBox("Error: La fecha DESDE no puede ser mayor que la decha HASTA !", vbExclamation, "Servico de Alertas")
                    End If
                Else
                    If chbFdesde.Checked = False Then
                        dtmFdesde.Value = dtmFdesde.MinDate
                    End If
                    lblDetalleConsulta.Text = "PESAJES POR FECHA Y TROPA: DESDE " & dtmFdesde.Value & " HASTA " & dtmFhasta.Value & ", TROPA: " & cbxTropa.Text
                    _Dt = _Ver.verPesajeFechaTropa(dtmFdesde.Value, dtmFhasta.Value, CInt(txtIdT.Text))
                End If
            End If

            PesajeCalcular(_Dt)

            frmFiltrandoAlimentacion.Close()

        ElseIf chbProd.Checked = False And chbTropa.Checked = False And chbCorral.Checked = True And chbCarav.Checked = False Then
            gbxConsPesaje.Visible = True
            gbxConsPesaje.Enabled = True

            frmFiltrandoAlimentacion.Show()
            frmFiltrandoAlimentacion.Refresh()

            Dim _Dt As New DataTable
            Dim _Ver As New Mostrar

            _Dt = _Ver.verCorrales()

            For Each _Dr As DataRow In _Dt.Rows
                If _Dr("NombreCorral") = cbxCorral.Text Then
                    txtIdCrr.Text = _Dr("idCorrales")
                End If
            Next

            If chbFdesde.Checked = False And chbFhasta.Checked = False Then
                lblDetalleConsulta.Text = "PESAJE POR CORRAL: " & cbxCorral.Text
                _Dt = _Ver.verPesajeCorral(CInt(txtIdCrr.Text))
            Else
                If chbFdesde.Checked = True And chbFhasta.Checked = True Then
                    If Format(CDate(dtmFdesde.Text), "yyyy/MM/dd") <= Format(CDate(dtmFhasta.Text), "yyyy/MM/dd") Then
                        lblDetalleConsulta.Text = "PESAJES POR FECHA Y CORRAL: DESDE " & dtmFdesde.Value & " HASTA " & dtmFhasta.Value & ", CORRAL: " & cbxCorral.Text
                        _Dt = _Ver.verPesajeFechaCorral(dtmFdesde.Value, dtmFhasta.Value, CInt(txtIdCrr.Text))
                    Else
                        MsgBox("Error: La fecha DESDE no puede ser mayor que la decha HASTA !", vbExclamation, "Servico de Alertas")
                    End If
                Else
                    If chbFdesde.Checked = False Then
                        dtmFdesde.Value = dtmFdesde.MinDate
                    End If
                    lblDetalleConsulta.Text = "PESAJES POR FECHA Y CORRAL: DESDE " & dtmFdesde.Value & " HASTA " & dtmFhasta.Value & ", CORRAL: " & cbxCorral.Text
                    _Dt = _Ver.verPesajeFechaCorral(dtmFdesde.Value, dtmFhasta.Value, CInt(txtIdCrr.Text))
                End If
            End If

            PesajeCalcular(_Dt)

            frmFiltrandoAlimentacion.Close()
        ElseIf chbProd.Checked = False And chbTropa.Checked = False And chbCorral.Checked = False And chbCarav.Checked = True Then

            gbxConsPesaje.Visible = True
            gbxConsPesaje.Enabled = True

            frmFiltrandoAlimentacion.Show()
            frmFiltrandoAlimentacion.Refresh()

            Dim _Dt As New DataTable
            Dim _Ver As New Mostrar

            If txtCaravana.Text <> "" Then
                If chbFdesde.Checked = False And chbFhasta.Checked = False Then
                    lblDetalleConsulta.Text = "PESAJE POR CARAVANA: " & txtCaravana.Text
                    _Dt = _Ver.verPesajeCaravana(txtCaravana.Text)
                Else
                    If chbFdesde.Checked = True And chbFhasta.Checked = True Then
                        If Format(CDate(dtmFdesde.Text), "yyyy/MM/dd") <= Format(CDate(dtmFhasta.Text), "yyyy/MM/dd") Then
                            lblDetalleConsulta.Text = "PESAJES POR FECHA Y CARAVANA: DESDE " & dtmFdesde.Value & " HASTA " & dtmFhasta.Value & ", CARAVANA: " & txtCaravana.Text
                            _Dt = _Ver.verPesajeFechaCaravana(dtmFdesde.Value, dtmFhasta.Value, txtCaravana.Text)
                        Else
                            MsgBox("Error: La fecha DESDE no puede ser mayor que la decha HASTA !", vbExclamation, "Servico de Alertas")
                        End If
                    Else
                        If chbFdesde.Checked = False Then
                            dtmFdesde.Value = dtmFdesde.MinDate
                        End If
                        lblDetalleConsulta.Text = "PESAJES POR FECHA Y CARAVANA: DESDE " & dtmFdesde.Value & " HASTA " & dtmFhasta.Value & ", CARAVANA: " & txtCaravana.Text
                        _Dt = _Ver.verPesajeFechaCaravana(dtmFdesde.Value, dtmFhasta.Value, txtCaravana.Text)
                    End If
                End If

                PesajeCalcular(_Dt)

                frmFiltrandoAlimentacion.Close()
            Else
                MsgBox("Error: No hay una CARAVANA seleccionada !", vbExclamation, "Servico de Alertas")
            End If


        End If

    End Sub

    Private Sub LabelsTotales(ByVal lblKgGrano As Label, ByVal lblKgConcentrado As Label, ByVal lblKgFibra As Label,
                              ByVal lblKgOtros As Label, ByVal lblKgTotales As Label, ByVal lblImpGrano As Label,
                              ByVal lblImpConcentrado As Label, ByVal lblImpFibra As Label, ByVal lblImpOtros As Label,
                              ByVal lblImpTotal As Label, ByVal lblPorcGrano As Label, ByVal lblPorcConcentrado As Label,
                              ByVal lblPorcFibra As Label, ByVal lblPorcOtros As Label, ByVal Pantalla As String)

        Dim _Dt As DataTable = Nothing
        Dim _Ver As New Mostrar

        Dim FechaH, FechaD As Date

        If dtmFhasta.Enabled = False Then
            FechaH = dtmFhasta.MaxDate
        Else
            FechaH = Format(CDate(dtmFhasta.Text), "yyyy/MM/dd")
        End If

        If dtmFdesde.Enabled = False Then
            FechaD = dtmFdesde.MinDate
        Else
            FechaD = Format(CDate(dtmFdesde.Text), "yyyy/MM/dd")
        End If

        If Pantalla = "Fecha" Then
            If frmLogin.txtTipUs.Text = "Super Usuario" Then
                _Dt = _Ver.sumaAlimentacionProrrateoTodo(FechaD, FechaH)
            Else
                _Dt = _Ver.sumaAlimentacionProrrateoTodoUs(FechaD, FechaH, frmLogin.txtID.Text)
            End If
        ElseIf Pantalla = "Corral" Then
            If frmLogin.txtTipUs.Text = "Super Usuario" Then
                _Dt = _Ver.verCorrales()
            Else
                _Dt = _Ver.verCorralesUs(frmLogin.txtID.Text)
            End If

            txtIdCrr.Text = ""

            For Each _Dr As DataRow In _Dt.Rows
                If _Dr("NombreCorral") = cbxCorral.Text Then
                    txtIdCrr.Text = _Dr("idCorrales")
                End If
            Next

            _Dt = _Ver.sumaAlimentacionProrrateoTodoPorCorral(FechaD, FechaH, txtIdCrr.Text)
        ElseIf Pantalla = "Tropa" Then
            If frmLogin.txtTipUs.Text = "Super Usuario" Then
                _Dt = _Ver.verTropas()
            Else
                _Dt = _Ver.verTropaUs(frmLogin.txtID.Text)
            End If

            txtIdT.Text = ""

            For Each _Dr As DataRow In _Dt.Rows
                If _Dr("NombreTropa") = cbxTropa.Text Then
                    txtIdT.Text = _Dr("idTropa")
                End If
            Next

            _Dt = _Ver.sumaAlimentacionProrrateoTodoPorTropa(FechaD, FechaH, txtIdT.Text)
        ElseIf Pantalla = "Productor" Then
            If frmLogin.txtTipUs.Text = "Super Usuario" Then
                _Dt = _Ver.verProductor()
            Else
                _Dt = _Ver.verProductorUs(frmLogin.txtID.Text)
            End If

            txtIdP.Text = ""

            For Each _Dr As DataRow In _Dt.Rows
                If _Dr("RazonSocial") = cbxProductor.Text Then
                    txtIdP.Text = _Dr("idProductor")
                End If
            Next

            _Dt = _Ver.sumaAlimentacionProrrateoTodoPorProductor(FechaD, FechaH, txtIdP.Text)
        ElseIf Pantalla = "Caravana" Then
            _Dt = _Ver.sumaAlimentacionProrrateoTodoPorDetalleTropa(FechaD, FechaH, txtIdCar.Text)
        End If

        If _Dt.Rows.Count > 0 Then
            For Each _Dr As DataRow In _Dt.Rows
                If _Dr("KgRacion").ToString <> "" Then
                    lblKgGrano.Text = Format(_Dr("KgGrano"), "#,##0")
                    lblKgConcentrado.Text = Format(_Dr("KgConcentrado"), "#,##0")
                    lblKgFibra.Text = Format(_Dr("KgFibra"), "#,##0")
                    lblKgOtros.Text = Format(_Dr("KgOtros"), "#,##0")
                    lblKgTotales.Text = Format(_Dr("KgRacion"), "#,##0")

                    lblImpGrano.Text = Format(_Dr("ImporteGrano"), "$ #,##0.00")
                    lblImpConcentrado.Text = Format(_Dr("ImporteConcentrado"), "$ #,##0.00")
                    lblImpFibra.Text = Format(_Dr("ImporteFibra"), "$ #,##0.00")
                    lblImpOtros.Text = Format(_Dr("ImporteOtros"), "$ #,##0.00")
                    lblImpTotal.Text = Format(_Dr("ImporteTotal"), "$ #,##0.00")

                    lblPorcGrano.Text = Format((lblKgGrano.Text / lblKgTotales.Text) * 100, "#,##0.00")
                    lblPorcConcentrado.Text = Format((lblKgConcentrado.Text / lblKgTotales.Text) * 100, "#,##0.00")
                    lblPorcFibra.Text = Format((lblKgFibra.Text / lblKgTotales.Text) * 100, "#,##0.00")
                    lblPorcOtros.Text = Format((lblKgOtros.Text / lblKgTotales.Text) * 100, "#,##0.00")
                Else
                    lblKgGrano.Text = Format(0, "#,##0")
                    lblKgConcentrado.Text = Format(0, "#,##0")
                    lblKgFibra.Text = Format(0, "#,##0")
                    lblKgOtros.Text = Format(0, "#,##0")
                    lblKgTotales.Text = Format(0, "#,##0")

                    lblImpGrano.Text = Format(0, "$ #,##0.00")
                    lblImpConcentrado.Text = Format(0, "$ #,##0.00")
                    lblImpFibra.Text = Format(0, "$ #,##0.00")
                    lblImpOtros.Text = Format(0, "$ #,##0.00")
                    lblImpTotal.Text = Format(0, "$ #,##0.00")

                    lblPorcGrano.Text = Format(0, "#,##0.00")
                    lblPorcConcentrado.Text = Format(0, "#,##0.00")
                    lblPorcFibra.Text = Format(0, "#,##0.00")
                    lblPorcOtros.Text = Format(0, "#,##0.00")
                End If
            Next
        End If
    End Sub

    Private Sub CargarDGVpesaje(_Dt As DataTable)
        dgvPesos.ColumnHeadersVisible = True
        dgvPesos.RowTemplate.Height = 35
        dgvPesos.DataSource = _Dt
        dgvPesos.ClearSelection()
        dgvPesos.Columns("idPESAJE").Visible = False
        dgvPesos.Columns("idTropa").Visible = False
        dgvPesos.Columns("idDetTropa").Visible = False
        dgvPesos.Columns("Fecha").Visible = True
        dgvPesos.Columns("NombreCorral").Visible = True
        dgvPesos.Columns("NombreTropa").Visible = True
        dgvPesos.Columns("CORRALES_idCorrales").Visible = False
        dgvPesos.Columns("Categoria").Visible = True
        dgvPesos.Columns("Caravana").Visible = True
        dgvPesos.Columns("Descripcion").Visible = True
        dgvPesos.Columns("Peso").Visible = True
        dgvPesos.Columns("PorcDesbaste").Visible = False
        dgvPesos.Columns("Desbaste").Visible = True
        dgvPesos.Columns("PesoFinal").Visible = True
        dgvPesos.Columns("Observaciones").Visible = True
        dgvPesos.Columns("Tipo").Visible = True
        dgvPesos.Columns("Estado").Visible = True


        dgvPesos.Columns("Fecha").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvPesos.Columns("NombreCorral").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvPesos.Columns("NombreTropa").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvPesos.Columns("Categoria").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvPesos.Columns("Caravana").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvPesos.Columns("Descripcion").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvPesos.Columns("Peso").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvPesos.Columns("Desbaste").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvPesos.Columns("PesoFinal").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvPesos.Columns("Observaciones").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvPesos.Columns("Tipo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvPesos.Columns("Estado").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        dgvPesos.Columns("Peso").DefaultCellStyle.Format = "#,##0"
        dgvPesos.Columns("Desbaste").DefaultCellStyle.Format = "#,##0"
        dgvPesos.Columns("PesoFinal").DefaultCellStyle.Format = "#,##0"

    End Sub

    Private Sub PesajeCalcular(_Dt As DataTable)
        Dim cCab, vCab As Integer
        Dim cBal, cDes, cNet As Double
        Dim vBal, vDes, vNet As Double

        If _Dt.Rows.Count > 0 Then
            For Each Item As DataRow In _Dt.Rows
                If Item("Tipo") = "Control" Then
                    cCab = cCab + 1
                    cBal = cBal + Item("Peso")
                    cDes = cDes + Item("Desbaste")
                    cNet = cNet + Item("PesoFinal")
                Else
                    vCab = vCab + 1
                    vBal = vBal + Item("Peso")
                    vDes = vDes + Item("Desbaste")
                    vNet = vNet + Item("PesoFinal")
                End If
            Next

            lblContCab.Text = Format(cCab, "#,##0")
            lblContBal.Text = Format(cBal, "#,##0")
            lblContDes.Text = Format(cDes, "#,##0")
            lblContNet.Text = Format(cNet, "#,##0")

            lblVtaCab.Text = Format(vCab, "#,##0")
            lblVtaBal.Text = Format(vBal, "#,##0")
            lblVtaDes.Text = Format(vDes, "#,##0")
            lblVtaNet.Text = Format(vNet, "#,##0")

            lblTotCab.Text = Format(cCab + vCab, "#,##0")
            lblTotBal.Text = Format(cBal + vBal, "#,##0")
            lblTotDes.Text = Format(cDes + vDes, "#,##0")
            lblTotNet.Text = Format(cNet + vNet, "#,##0")

            If cCab > 0 Then
                lblContPmCab.Text = Format(cBal / cCab, "#,##0")
                lblContPmDes.Text = Format((cBal - cDes) / cCab, "#,##0")
            Else
                lblContPmCab.Text = Format(0, "#,##0")
                lblContPmDes.Text = Format(0, "#,##0")
            End If

            If vCab > 0 Then
                lblVtaPmCab.Text = Format(vBal / vCab, "#,##0")
                lblVtaPmDes.Text = Format((vBal - vDes) / vCab, "#,##0")
            Else
                lblVtaPmCab.Text = Format(0, "#,##0")
                lblVtaPmDes.Text = Format(0, "#,##0")
            End If

            If cCab > 0 And vCab > 0 Then
                lblTotPmCab.Text = Format((CDbl(lblContPmCab.Text) + CDbl(lblVtaPmCab.Text)) / 2, "#,##0")
                lblTotPmDes.Text = Format((CDbl(lblContPmDes.Text) + CDbl(lblVtaPmDes.Text)) / 2, "#,##0")
            ElseIf cCab > 0 And vCab = 0 Then
                lblTotPmCab.Text = Format(CDbl(lblContPmCab.Text), "#,##0")
                lblTotPmDes.Text = Format(CDbl(lblContPmDes.Text), "#,##0")
            ElseIf cCab = 0 And vCab > 0 Then
                lblTotPmCab.Text = Format(CDbl(lblVtaPmCab.Text), "#,##0")
                lblTotPmDes.Text = Format(CDbl(lblVtaPmDes.Text), "#,##0")
            Else
                lblTotPmCab.Text = Format(0, "#,##0")
                lblTotPmDes.Text = Format(0, "#,##0")
            End If

            CargarDGVpesaje(_Dt)
        Else
            dgvPesos.ColumnHeadersVisible = False
            dgvPesos.DataSource = Nothing
        End If
    End Sub

    Private Sub dgvPesos_MouseUp(sender As Object, e As MouseEventArgs) Handles dgvPesos.MouseMove
        Dim sumaPeso As Double = 0
        Dim cant As Integer = 0
        Dim prom As Double = 0

        For Each Item As DataGridViewRow In dgvPesos.SelectedRows
            cant = cant + 1
            sumaPeso = sumaPeso + Item.Cells("Peso").Value
            prom = Format(sumaPeso / cant, "#,##0")

            lblCant.Text = cant
            lblProm.Text = prom
            lblSuma.Text = sumaPeso
        Next
    End Sub
End Class