Public Class frmConsAlimentacion
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


    Private Sub frmConsAlimentacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim _Dt, _Dt2 As DataTable
        Dim _Ver, _Ver2 As New Mostrar
        Dim _Row, _Row2 As DataRow
        Dim UltFecha, PrimFecha As Date
        Dim x As Integer = 0

        lblFdesde.Text = ""
        lblFhasta.Text = ""
        lblProd.Text = ""
        lblTropa.Text = ""
        lblCorral.Text = ""
        lblCaravana.Text = ""

        _Dt = _Ver.verMaxFecAlim()
        _Row = _Dt.Rows(_Dt.Rows.Count - 1)

        If _Row("UltimaAlim").ToString = "" Then
            UltFecha = Date.Now.Date
        Else
            UltFecha = _Row("UltimaAlim")
        End If

        _Dt2 = _Ver2.verMinFecAlim()
        _Row2 = _Dt2.Rows(_Dt2.Rows.Count - 1)

        If _Row2("PrimeraAlim").ToString = "" Then
            PrimFecha = Date.Now.Date
        Else
            PrimFecha = _Row2("PrimeraAlim")
        End If

        dtmFdesde.MinDate = PrimFecha
        dtmFdesde.MaxDate = UltFecha

        dtmFhasta.MinDate = PrimFecha
        dtmFhasta.MaxDate = UltFecha

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

        Me.Text = "Si.Tra.Bo. - Sistema de Trazabilidad Bovina" & " - USUARIO: " & frmLogin.txtNom.Text & " " & frmLogin.txtAp.Text & " -"
    End Sub

    Private Sub pbxSalir_Click(sender As Object, e As EventArgs) Handles pbxSalir.Click
        GBXOcultar()

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

    Private Sub GBXOcultar()
        gbxAlimInicial.Visible = True
        gbxConsTropas.Visible = False
        gbxConsFechas.Visible = False
        gbxConsProductor.Visible = False
        gbxConsCorr.Visible = False
        gbxCarav.Visible = False
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

    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click
        ' FECHA DESDE - HASTA
        If (chbFdesde.Checked = True Or chbFhasta.Checked = True) And (chbProd.Checked = False And chbTropa.Checked = False And chbCorral.Checked = False And chbCarav.Checked = False) Then
            If Format(CDate(dtmFdesde.Text), "yyyy/MM/dd") <= Format(CDate(dtmFhasta.Text), "yyyy/MM/dd") Then
                GBXOcultar()
                Me.Refresh()
                frmFiltrandoAlimentacion.Show()
                frmFiltrandoAlimentacion.Refresh()
                If chbFdesde.Checked = True Then
                    lblFdesde.Text = dtmFdesde.Value
                Else
                    lblFdesde.Text = "Inicio"
                End If
                If chbFhasta.Checked = True Then
                    lblFhasta.Text = dtmFhasta.Value
                Else
                    lblFhasta.Text = "Final"
                End If
                lblProd.Text = "Todos"
                lblTropa.Text = "Todas"
                lblCorral.Text = "Todos"
                lblCaravana.Text = "Todas"

                LabelsTotales(lblKgran, lblKSil, lblKconc, lblKfib, lblKotr, lblKtot, lblImpGr, lblImpSil, lblImpConc, lblImpFib, lblImpOtr, lblImpTot, lblPorGr, lblPorSil, lblPorcConc, lblPorFib, lblPorOtro, "Fecha")

                If lblKtot.Text <> 0 Then
                    gbxConsFechas.Enabled = True

                    GraficarRacion(grpRacion, lblPorGr.Text, lblPorcConc.Text, lblPorFib.Text, lblPorOtro.Text, lblKtot.Text)
                    GraficarTropas(grpConsTropa, "Todas", lblKtot.Text)
                    GraficarProductor(grpConsProductor, "Todos", lblKtot.Text)
                    GraficarDia(grpConsDia, lblKtot.Text)
                Else
                    gbxConsFechas.Enabled = False

                    grpRacion.Series("Raciones").Points.Clear()
                    grpConsTropa.Series("TropaCons").Points.Clear()
                    grpConsProductor.Series("ProductorCons").Points.Clear()
                    grpConsDia.Series("ConsDia").Points.Clear()

                    grpConsDia.Titles.Clear()
                    grpConsTropa.Titles.Clear()
                    grpConsProductor.Titles.Clear()
                    grpRacion.Titles.Clear()
                End If

                frmFiltrandoAlimentacion.Close()
                gbxAlimInicial.Visible = False
                gbxConsFechas.Visible = True
            Else
                MsgBox("""Fecha Hasta"" no puede ser menor que ""Fecha Desde""... !", vbExclamation, "Servico de Alertas")
            End If
        ElseIf ((chbFdesde.Checked = False And chbFhasta.Checked = False) Or (chbFdesde.Checked = True Or chbFhasta.Checked = True)) And (chbProd.Checked = False And chbTropa.Checked = True And chbCarav.Checked = False And chbCorral.Checked = False) Then
            ' TROPA O FECHA Y TROPA
            If cbxTropa.Text <> "" Then
                GBXOcultar()
                Me.Refresh()
                frmFiltrandoAlimentacion.Show()
                frmFiltrandoAlimentacion.Refresh()

                If chbFdesde.Checked = True Then
                    lblFdesde.Text = dtmFdesde.Value
                Else
                    lblFdesde.Text = "Inicio"
                End If
                If chbFhasta.Checked = True Then
                    lblFhasta.Text = dtmFhasta.Value
                Else
                    lblFhasta.Text = "Final"
                End If

                lblProd.Text = "Todos"
                lblTropa.Text = cbxTropa.Text
                lblCorral.Text = "Todos"
                lblCaravana.Text = "Todas"

                LabelsTotales(lblKgGrT, lblKgSilT, lblKgConcT, lblKgFibT, lblKgOtrT, lblKgTotT, lblImpGrT, lblImpSilT, lblImpConcT, lblImpFibT, lblImpOtrT, lblImpTotT, lblPorGrT, lblPorSilT, lblPorConcT, lblPorFibT, lblPorOtrT, "Tropa")

                If lblKgTotT.Text <> 0 Then
                    gbxConsTropas.Enabled = True

                    GraficarRacion(grpRacionT, lblPorGrT.Text, lblPorConcT.Text, lblPorFibT.Text, lblPorOtrT.Text, lblKgTotT.Text)
                    GraficarTropas(grpTropa, cbxTropa.Text, lblKgTotT.Text)
                Else
                    gbxConsTropas.Enabled = False

                    grpRacionT.Series("Raciones").Points.Clear()
                    grpTropa.Series("TropaCons").Points.Clear()

                    grpTropa.Titles.Clear()
                    grpRacionT.Titles.Clear()

                    txtIdT.Text = ""
                    lblFecIngTropa.Text = ""
                    lblKgIngTropa.Text = ""
                    lblDiasEng.Text = ""
                    lblCabTropa.Text = ""
                    lblCabEng.Text = ""
                End If

                frmFiltrandoAlimentacion.Close()
                gbxAlimInicial.Visible = False
                gbxConsTropas.Visible = True
            End If
        ElseIf ((chbFdesde.Checked = False And chbFhasta.Checked = False) Or (chbFdesde.Checked = True Or chbFhasta.Checked = True)) And (chbProd.Checked = True And chbTropa.Checked = False And chbCarav.Checked = False And chbCorral.Checked = False) Then
            ' PRODUCTOR O FECHA Y PRODUCTOR
            If cbxProductor.Text <> "" Then
                GBXOcultar()
                Me.Refresh()
                frmFiltrandoAlimentacion.Show()
                frmFiltrandoAlimentacion.Refresh()

                If chbFdesde.Checked = True Then
                    lblFdesde.Text = dtmFdesde.Value
                Else
                    lblFdesde.Text = "Inicio"
                End If

                If chbFhasta.Checked = True Then
                    lblFhasta.Text = dtmFhasta.Value
                Else
                    lblFhasta.Text = "Final"
                End If

                lblProd.Text = cbxProductor.Text
                lblTropa.Text = "Todas"
                lblCorral.Text = "Todos"
                lblCaravana.Text = "Todas"

                LabelsTotales(lblKgGr, lblKgSil, lblKgConc, lblKgFib, lblKgOtr, lblKgT, lblImGr, lblImSil, lblImCon, lblImFib, lblImOtr, lblImTot, lblPgr, lblPsil, lblPconc, lblPfib, lblPotr, "Productor")

                If lblKgT.Text <> 0 Then
                    gbxConsProductor.Enabled = True

                    GraficarRacion(grpRacionP, lblPgr.Text, lblPconc.Text, lblPfib.Text, lblPotr.Text, lblKgT.Text)
                    GraficarProductor(grpProductor, cbxProductor.Text, lblKgT.Text)
                Else
                    gbxConsProductor.Enabled = False

                    grpRacionP.Series("Raciones").Points.Clear()
                    grpProductor.Series("TropaCons").Points.Clear()

                    grpProductor.Titles.Clear()
                    grpRacionP.Titles.Clear()
                End If

                frmFiltrandoAlimentacion.Close()
                gbxAlimInicial.Visible = False
                gbxConsProductor.Visible = True
            End If
        ElseIf ((chbFdesde.Checked = False And chbFhasta.Checked = False) Or (chbFdesde.Checked = True Or chbFhasta.Checked = True)) And (chbProd.Checked = False And chbTropa.Checked = False And chbCarav.Checked = False And chbCorral.Checked = True) Then
            ' CORRAL O FECHA Y CORRAL
            If cbxCorral.Text <> "" Then
                GBXOcultar()
                Me.Refresh()
                frmFiltrandoAlimentacion.Show()
                frmFiltrandoAlimentacion.Refresh()

                If chbFdesde.Checked = True Then
                    lblFdesde.Text = dtmFdesde.Value
                Else
                    lblFdesde.Text = "Inicio"
                End If

                If chbFhasta.Checked = True Then
                    lblFhasta.Text = dtmFhasta.Value
                Else
                    lblFhasta.Text = "Final"
                End If

                lblTropa.Text = "Todos"
                lblCorral.Text = cbxCorral.Text
                lblProd.Text = "Todos"
                lblCaravana.Text = "Todas"

                LabelsTotales(lblKgG, lblKgGS, lblKgC, lblKgF, lblKgO, lblKgTT, lblImG, lblImS, lblImC, lblImF, lblImO, lblImTT, lblPG, lblPS, lblPC, lblPF, lblPO, "Corral")

                If lblKgTT.Text <> 0 Then
                    gbxConsCorr.Enabled = True

                    GraficarRacion(grpRacionC, lblPG.Text, lblPC.Text, lblPF.Text, lblPO.Text, lblKgTT.Text)
                    GraficarCorral(grpTropasCrr, grpProductorCrr, lblKgTT.Text)
                Else
                    gbxConsCorr.Enabled = False

                    grpRacionC.Series("Raciones").Points.Clear()
                    grpTropasCrr.Series("ProductorCons").Points.Clear()
                    grpProductorCrr.Series("ProductorCons").Points.Clear()

                    grpTropasCrr.Titles.Clear()
                    grpProductorCrr.Titles.Clear()
                    grpRacionC.Titles.Clear()
                End If

                frmFiltrandoAlimentacion.Close()
                gbxAlimInicial.Visible = False
                gbxConsCorr.Visible = True
            End If
        ElseIf ((chbFdesde.Checked = False And chbFhasta.Checked = False) Or (chbFdesde.Checked = True Or chbFhasta.Checked = True)) And (chbProd.Checked = False And chbTropa.Checked = False And chbCarav.Checked = True And chbCorral.Checked = False) Then
            ' CARAVANA O FECHA Y CARAVANA
            If txtCaravana.Text <> "" Then
                GBXOcultar()
                Me.Refresh()
                frmFiltrandoAlimentacion.Show()
                frmFiltrandoAlimentacion.Refresh()

                If chbFdesde.Checked = True Then
                    lblFdesde.Text = dtmFdesde.Value
                Else
                    lblFdesde.Text = "Inicio"
                End If

                If chbFhasta.Checked = True Then
                    lblFhasta.Text = dtmFhasta.Value
                Else
                    lblFhasta.Text = "Final"
                End If

                Dim _Dt As DataTable
                Dim _Ver As New Mostrar

                _Dt = _Ver.consDetalleTropa_Corral_Tropa_Productor(txtIdCar.Text)

                For Each _Dr As DataRow In _Dt.Rows
                    lblTropa.Text = _Dr("NombreTropa")
                    lblCorral.Text = _Dr("NombreCorral")
                    lblProd.Text = _Dr("RazonSocial")
                Next

                lblCaravana.Text = txtCaravana.Text

                LabelsTotales(lblCarKgGr, lblCarKgSil, lblCarKgCon, lblCarKgFib, lblCarKgOtr, lblCarKgTot, lblCarImGr, lblCarImSil, lblCarImCon, lblCarImFib, lblCarImOtr, lblCarImTot, lblCarPorGr, lblCarPorSil, lblCarPorConc, lblCarPorFib, lblCarPorOtr, "Caravana")

                If lblCarKgTot.Text <> 0 Then
                    gbxCarav.Enabled = True

                    GraficarRacion(grpRacionCarv, lblCarPorGr.Text, lblCarPorConc.Text, lblCarPorFib.Text, lblCarPorOtr.Text, lblCarKgTot.Text)
                    GraficarCaravana(grpCarv, lblCarKgTot.Text)
                Else
                    gbxCarav.Enabled = False

                    grpRacionCarv.Series("Raciones").Points.Clear()
                    grpCarv.Series("Caravana").Points.Clear()

                    grpCarv.Titles.Clear()
                    grpRacionCarv.Titles.Clear()
                End If

                frmFiltrandoAlimentacion.Close()
                gbxAlimInicial.Visible = False
                gbxCarav.Visible = True
            End If
        End If
    End Sub

    Private Sub GraficarRacion(ByVal grp As System.Windows.Forms.DataVisualization.Charting.Chart, _
                               ByVal porcGrano As Double, ByVal porcConcentrado As Double, ByVal porcFibra As Double, ByVal porcOtros As Double, _
                               ByVal KgTot As Double)

        grp.Series("Raciones").Points.Clear()

        grp.Titles.Clear()

        grp.Series("Raciones").Points.Add(porcGrano)
        grp.Series("Raciones").Points.Add(porcConcentrado)
        grp.Series("Raciones").Points.Add(porcFibra)
        grp.Series("Raciones").Points.Add(porcOtros)

        grp.Series("Raciones").Points(0).LegendText = "Grano"
        grp.Series("Raciones").Points(1).LegendText = "Conc."
        grp.Series("Raciones").Points(2).LegendText = "Fibra"
        grp.Series("Raciones").Points(3).LegendText = "Otros"

        If KgTot <> 0 Then
            grp.Series("Raciones").Points(0).IsVisibleInLegend = True
            grp.Series("Raciones").Points(1).IsVisibleInLegend = True
            grp.Series("Raciones").Points(2).IsVisibleInLegend = True
            grp.Series("Raciones").Points(3).IsVisibleInLegend = True

            grp.Titles.Add("RACIÓN")

            grp.Titles(0).Font = New Font("Arial", 12, FontStyle.Bold)

            grp.Titles(0).ForeColor = Color.SaddleBrown
        Else
            grp.Series("Raciones").Points(0).IsVisibleInLegend = False
            grp.Series("Raciones").Points(1).IsVisibleInLegend = False
            grp.Series("Raciones").Points(2).IsVisibleInLegend = False
            grp.Series("Raciones").Points(3).IsVisibleInLegend = False
        End If
    End Sub

    Private Sub GraficarCorral(ByVal grpT As System.Windows.Forms.DataVisualization.Charting.Chart, ByVal grpP As System.Windows.Forms.DataVisualization.Charting.Chart, _
                               ByVal KgTot As Double)
        Dim _Dt, _Dt2 As DataTable
        Dim _Ver As New Mostrar

        Dim Count As Integer = 0

        Dim FechaH, FechaD As Date

        grpT.Series("ProductorCons").Points.Clear()
        grpP.Series("ProductorCons").Points.Clear()

        grpT.Titles.Clear()
        grpP.Titles.Clear()

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

        If frmLogin.txtTipUs.Text = "Super Usuario" Then
            _Dt = _Ver.verTropas()
        Else
            _Dt = _Ver.verTropaUs(frmLogin.txtID.Text)
        End If

        If _Dt.Rows.Count > 0 Then
            For Each _Dr As DataRow In _Dt.Rows
                _Dt2 = _Ver.sumaAlimentacionProrrateoPorTropaYCorralFechaDH(FechaD, FechaH, _Dr("idTropa"), txtIdCrr.Text)

                If _Dt2.Rows.Count > 0 Then
                    For Each _Dr2 As DataRow In _Dt2.Rows
                        If _Dr2("TotKgRac").ToString <> "" Then
                            If rdbKg.Checked = True Then
                                grpT.Series("ProductorCons").Points.Add(_Dr2("TotKgRac"))
                            Else
                                grpT.Series("ProductorCons").Points.Add(_Dr2("SumaTotAlim"))
                            End If

                            grpT.Series("ProductorCons").Points(Count).Label = _Dr("NombreTropa")

                            Count = Count + 1
                        End If
                    Next
                End If
            Next

            Count = 0

            If frmLogin.txtTipUs.Text = "Super Usuario" Then
                _Dt = _Ver.verProductor()
            Else
                _Dt = _Ver.verProductorUs(frmLogin.txtID.Text)
            End If

            For Each _Dr As DataRow In _Dt.Rows
                _Dt2 = _Ver.sumaAlimentacionProrrateoPorProductorYCorralFechaDH(FechaD, FechaH, _Dr("idProductor"), txtIdCrr.Text)

                If _Dt2.Rows.Count > 0 Then
                    For Each _Dr2 As DataRow In _Dt2.Rows
                        If _Dr2("TotKgRac").ToString <> "" Then
                            If rdbKg.Checked = True Then
                                grpP.Series("ProductorCons").Points.Add(_Dr2("TotKgRac"))
                            Else
                                grpP.Series("ProductorCons").Points.Add(_Dr2("SumaTotAlim"))
                            End If

                            grpP.Series("ProductorCons").Points(Count).Label = _Dr("RazonSocial")

                            Count = Count + 1
                        End If
                    Next
                End If
            Next

            If KgTot <> 0 Then
                If rdbKg.Checked = True Then
                    grpP.Titles.Add("CONSUMO")
                    grpT.Titles.Add("CONSUMO")

                    grpP.ChartAreas("ChartArea1").AxisY.Title = "KG"
                    grpT.ChartAreas("ChartArea1").AxisY.Title = "KG"
                Else
                    grpP.Titles.Add("IMPORTE")
                    grpT.Titles.Add("IMPORTE")

                    grpP.ChartAreas("ChartArea1").AxisY.Title = "$"
                    grpT.ChartAreas("ChartArea1").AxisY.Title = "$"
                End If

                grpP.Titles(0).Font = New Font("Arial", 12, FontStyle.Bold)
                grpT.Titles(0).Font = New Font("Arial", 12, FontStyle.Bold)

                grpP.Titles(0).ForeColor = Color.SaddleBrown
                grpT.Titles(0).ForeColor = Color.SaddleBrown
            End If
        End If
    End Sub

    Private Sub GraficarCaravana(ByVal grp As System.Windows.Forms.DataVisualization.Charting.Chart, ByVal KgTot As Double)
        Dim _Dt As DataTable
        Dim _Ver As New Mostrar

        Dim Count As Integer = 0

        Dim Cons As Double = 0

        Dim FechaH, FechaD As Date

        grp.Series("Caravana").Points.Clear()

        grp.Titles.Clear()

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

        Do
            _Dt = _Ver.verAlimentacionFechaDetalleTropa(FechaD, txtIdCar.Text)

            If _Dt.Rows.Count > 0 Then
                For Each _Dr As DataRow In _Dt.Rows
                    If rdbKg.Checked = True Then
                        Cons = Cons + _Dr("KgRacion")
                    Else
                        Cons = Cons + _Dr("ImporteTotal")
                    End If
                Next

                grp.Series("Caravana").Points.Add(Cons)
                grp.Series("Caravana").Points(Count).AxisLabel = FechaD
                grp.Series("Caravana").Points(Count).BorderWidth = 3

                Cons = 0
                Count = Count + 1
            End If

            FechaD = FechaD.AddDays(1)
        Loop While FechaD <= FechaH

        If KgTot <> 0 Then
            If rdbKg.Checked = True Then
                grp.Titles.Add("CONSUMO X DIA")

                grp.ChartAreas("ChartArea1").AxisY.Title = "KG"
            Else
                grp.Titles.Add("IMPORTE X DIA")

                grp.ChartAreas("ChartArea1").AxisY.Title = "$"
            End If

            grp.Titles(0).Font = New Font("Arial", 12, FontStyle.Bold)

            grp.Titles(0).ForeColor = Color.SaddleBrown
        End If
    End Sub

    Private Sub GraficarDia(ByVal grp As System.Windows.Forms.DataVisualization.Charting.Chart, ByVal KgTot As Double)
        Dim _Dt As DataTable
        Dim _Ver As New Mostrar

        Dim Cons As Double = 0

        Dim Count As Integer = 0

        Dim FechaH, FechaD As Date

        grp.Series("ConsDia").Points.Clear()

        grp.Titles.Clear()

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

        Do
            If frmLogin.txtTipUs.Text = "Super Usuario" Then
                _Dt = _Ver.verAlimentacion_Fecha(FechaD)
            Else
                _Dt = _Ver.verAlimentacion_Fecha_Us(frmLogin.txtID.Text, FechaD)
            End If

            If _Dt.Rows.Count > 0 Then
                For Each _Dr As DataRow In _Dt.Rows
                    If rdbKg.Checked = True Then
                        Cons = Cons + _Dr("KgRacion")
                    Else
                        Cons = Cons + _Dr("ImporteTotal")
                    End If
                Next

                grp.Series("ConsDia").Points.Add(Cons)
                grp.Series("ConsDia").Points(Count).AxisLabel = FechaD

                Cons = 0
                Count = Count + 1
            End If

            FechaD = FechaD.AddDays(1)
        Loop While FechaD <= FechaH

        If KgTot <> 0 Then
            If rdbKg.Checked = True Then
                grp.Titles.Add("CONSUMO X DIA")

                grp.ChartAreas("ChartArea1").AxisY.Title = "KG"
            Else
                grp.Titles.Add("IMPORTE X DIA")

                grp.ChartAreas("ChartArea1").AxisY.Title = "$"
            End If

            grp.Titles(0).Font = New Font("Arial", 12, FontStyle.Bold)

            grp.Titles(0).ForeColor = Color.SaddleBrown
        End If
    End Sub

    Private Sub GraficarProductor(ByVal grp As System.Windows.Forms.DataVisualization.Charting.Chart, ByVal Productor As String, ByVal KgTot As Double)
        Dim _Dt, _Dt2 As DataTable
        Dim _Ver As New Mostrar

        Dim Count As Integer = 0

        Dim FechaH, FechaD As Date

        grp.Series("ProductorCons").Points.Clear()

        grp.Titles.Clear()

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

        If frmLogin.txtTipUs.Text = "Super Usuario" Then
            _Dt = _Ver.verProductor()
        Else
            _Dt = _Ver.verProductorUs(frmLogin.txtID.Text)
        End If

        If Productor = "Todos" Then
            If _Dt.Rows.Count > 0 Then
                For Each _Dr As DataRow In _Dt.Rows
                    _Dt2 = _Ver.sumaAlimentacionProrrateoPorProductorFechaDH(FechaD, FechaH, _Dr("idProductor"))

                    If _Dt2.Rows.Count > 0 Then
                        For Each _Dr2 As DataRow In _Dt2.Rows
                            If _Dr2("TotKgRac").ToString <> "" Then
                                If rdbKg.Checked = True Then
                                    grp.Series("ProductorCons").Points.Add(_Dr2("TotKgRac"))
                                Else
                                    grp.Series("ProductorCons").Points.Add(_Dr2("SumaTotAlim"))
                                End If

                                grp.Series("ProductorCons").Points(Count).AxisLabel = _Dr("RazonSocial")

                                Count = Count + 1
                            End If
                        Next
                    End If
                Next
            End If
        Else
            txtIdP.Text = ""

            For Each _Dr As DataRow In _Dt.Rows
                If _Dr("RazonSocial") = cbxProductor.Text Then
                    txtIdP.Text = _Dr("idProductor")
                End If
            Next

            _Dt = _Ver.verTropa_Productor_Us(frmLogin.txtID.Text, txtIdP.Text)

            If _Dt.Rows.Count > 0 Then
                For Each _Dr As DataRow In _Dt.Rows
                    _Dt2 = _Ver.sumaAlimentacionProrrateoPorTropaFechaDH(FechaD, FechaH, _Dr("idTropa"))

                    If _Dt2.Rows.Count > 0 Then
                        For Each _Dr2 As DataRow In _Dt2.Rows
                            If _Dr2("TotKgRac").ToString <> "" Then
                                If rdbKg.Checked = True Then
                                    grp.Series("ProductorCons").Points.Add(_Dr2("TotKgRac"))
                                Else
                                    grp.Series("ProductorCons").Points.Add(_Dr2("SumaTotAlim"))
                                End If

                                grp.Series("ProductorCons").Points(Count).Label = _Dr("NombreTropa")

                                Count = Count + 1
                            End If
                        Next
                    End If
                Next
            End If
        End If

        If KgTot <> 0 Then
            If rdbKg.Checked = True Then
                grp.Titles.Add("CONSUMO")

                grp.ChartAreas("ChartArea1").AxisY.Title = "KG"
            Else
                grp.Titles.Add("IMPORTE")

                grp.ChartAreas("ChartArea1").AxisY.Title = "$"
            End If

            grp.Titles(0).Font = New Font("Arial", 12, FontStyle.Bold)

            grp.Titles(0).ForeColor = Color.SaddleBrown
        End If
    End Sub

    Private Sub GraficarTropas(ByVal grp As System.Windows.Forms.DataVisualization.Charting.Chart, ByVal Tropa As String, ByVal KgTot As Double)
        Dim _Dt, _Dt2 As DataTable
        Dim _Ver As New Mostrar

        Dim Count As Integer = 0

        Dim FechaH, FechaD As Date

        grp.Series("TropaCons").Points.Clear()

        grp.Titles.Clear()

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

        If frmLogin.txtTipUs.Text = "Super Usuario" Then
            _Dt = _Ver.verTropas()
        Else
            _Dt = _Ver.verTropaUs(frmLogin.txtID.Text)
        End If

        If Tropa = "Todas" Then
            If _Dt.Rows.Count > 0 Then
                For Each _Dr As DataRow In _Dt.Rows
                    _Dt2 = _Ver.sumaAlimentacionProrrateoPorTropaFechaDH(FechaD, FechaH, _Dr("idTropa"))

                    If _Dt2.Rows.Count > 0 Then
                        For Each _Dr2 As DataRow In _Dt2.Rows
                            If _Dr2("TotKgRac").ToString <> "" Then
                                If rdbKg.Checked = True Then
                                    grp.Series("TropaCons").Points.Add(_Dr2("TotKgRac"))
                                Else
                                    grp.Series("TropaCons").Points.Add(_Dr2("SumaTotAlim"))
                                End If

                                grp.Series("TropaCons").Points(Count).Label = _Dr("NombreTropa")

                                Count = Count + 1
                            End If
                        Next
                    End If
                Next
            End If
        Else
            txtIdT.Text = ""

            Dim idP As Integer = 0

            For Each _Dr As DataRow In _Dt.Rows
                If _Dr("NombreTropa") = Tropa Then
                    txtIdT.Text = _Dr("idTropa")
                    lblFecIngTropa.Text = Format(CDate(_Dr("FechaIngreso")), "dd/MM/yyyy")
                    lblKgIngTropa.Text = Format(_Dr("PesoIngreso"), "#,##0")
                    lblDiasEng.Text = DateDiff("d", Format(_Dr("FechaIngreso"), "dd/MM/yyyy"), Format(dtmFhasta.Value, "dd/MM/yyyy"))
                    lblCabTropa.Text = Format(_Dr("Cabezas"), "#,##0")
                    idP = _Dr("PRODUCTOR_idProductor")
                End If
            Next

            _Dt = _Ver.verProductorPorID(idP)

            For Each _Dr As DataRow In _Dt.Rows
                lblProd.Text = _Dr("RazonSocial")
            Next

            _Dt = _Ver.verStockCorrDia(Format(dtmFhasta.Value, "dd/MM/yyyy"), CInt(txtIdT.Text))

            lblCabEng.Text = 0

            For Each _Dr As DataRow In _Dt.Rows
                lblCabEng.Text = CInt(lblCabEng.Text) + CInt(_Dr("CabezasTropa"))
            Next

            If CInt(lblCabEng.Text) = 0 Then
                Dim Fal As Date

                _Dt = _Ver.consAlimentacionProrateoPorTropa(CInt(txtIdT.Text))
                Fal = _Dt.Rows(_Dt.Rows.Count - 1).Item(0)
                lblDiasEng.Text = DateDiff("d", Format(CDate(lblFecIngTropa.Text), "dd/MM/yyyy"), Format(Fal, "dd/MM/yyyy"))
            End If

            _Dt = _Ver.verDetalleTropaCorralesID(txtIdT.Text)

            If _Dt.Rows.Count > 0 Then
                For Each _Dr As DataRow In _Dt.Rows
                    _Dt2 = _Ver.sumaAlimentacionProrrateoPorDetalleTropaFechaDH(FechaD, FechaH, _Dr("idDetTropa"))

                    If _Dt2.Rows.Count > 0 Then
                        For Each _Dr2 As DataRow In _Dt2.Rows
                            If _Dr2("TotKgRac").ToString <> "" Then
                                If rdbKg.Checked = True Then
                                    grp.Series("TropaCons").Points.Add(_Dr2("TotKgRac"))
                                Else
                                    grp.Series("TropaCons").Points.Add(_Dr2("SumaTotAlim"))
                                End If

                                grp.Series("TropaCons").Points(Count).Label = _Dr("Caravana")

                                Count = Count + 1
                            End If
                        Next
                    End If
                Next
            End If
        End If

        If KgTot <> 0 Then
            If rdbKg.Checked = True Then
                grp.Titles.Add("CONSUMO")

                grp.ChartAreas("ChartArea1").AxisY.Title = "KG"
            Else
                grp.Titles.Add("IMPORTE")

                grp.ChartAreas("ChartArea1").AxisY.Title = "$"
            End If

            grp.Titles(0).Font = New Font("Arial", 12, FontStyle.Bold)

            grp.Titles(0).ForeColor = Color.SaddleBrown
        End If
    End Sub

    Private Sub LabelsTotales(ByVal lblKgGrano As Label, ByVal lblKgSilo As Label, ByVal lblKgConcentrado As Label, ByVal lblKgFibra As Label,
                              ByVal lblKgOtros As Label, ByVal lblKgTotales As Label, ByVal lblImpGrano As Label, ByVal lblImpSilo As Label,
                              ByVal lblImpConcentrado As Label, ByVal lblImpFibra As Label, ByVal lblImpOtros As Label,
                              ByVal lblImpTotal As Label, ByVal lblPorcGrano As Label, ByVal lblPorcSilo As Label, ByVal lblPorcConcentrado As Label,
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
                    lblKgSilo.Text = Format(_Dr("KgSilo"), "#,##0")
                    lblKgConcentrado.Text = Format(_Dr("KgConcentrado"), "#,##0")
                    lblKgFibra.Text = Format(_Dr("KgFibra"), "#,##0")
                    lblKgOtros.Text = Format(_Dr("KgOtros"), "#,##0")
                    lblKgTotales.Text = Format(_Dr("KgRacion"), "#,##0")

                    lblImpGrano.Text = Format(_Dr("ImporteGrano"), "$ #,##0.00")
                    lblImpSilo.Text = Format(_Dr("ImporteSilo"), "$ #,##0.00")
                    lblImpConcentrado.Text = Format(_Dr("ImporteConcentrado"), "$ #,##0.00")
                    lblImpFibra.Text = Format(_Dr("ImporteFibra"), "$ #,##0.00")
                    lblImpOtros.Text = Format(_Dr("ImporteOtros"), "$ #,##0.00")
                    lblImpTotal.Text = Format(_Dr("ImporteTotal"), "$ #,##0.00")

                    lblPorcGrano.Text = Format((lblKgGrano.Text / lblKgTotales.Text) * 100, "#,##0.00")
                    lblPorcSilo.Text = Format((lblKgSilo.Text / lblKgTotales.Text) * 100, "#,##0.00")
                    lblPorcConcentrado.Text = Format((lblKgConcentrado.Text / lblKgTotales.Text) * 100, "#,##0.00")
                    lblPorcFibra.Text = Format((lblKgFibra.Text / lblKgTotales.Text) * 100, "#,##0.00")
                    lblPorcOtros.Text = Format((lblKgOtros.Text / lblKgTotales.Text) * 100, "#,##0.00")
                Else
                    lblKgGrano.Text = Format(0, "#,##0")
                    lblKgSilo.Text = Format(0, "#,##0")
                    lblKgConcentrado.Text = Format(0, "#,##0")
                    lblKgFibra.Text = Format(0, "#,##0")
                    lblKgOtros.Text = Format(0, "#,##0")
                    lblKgTotales.Text = Format(0, "#,##0")

                    lblImpGrano.Text = Format(0, "$ #,##0.00")
                    lblImpSilo.Text = Format(0, "$ #,##0.00")
                    lblImpConcentrado.Text = Format(0, "$ #,##0.00")
                    lblImpFibra.Text = Format(0, "$ #,##0.00")
                    lblImpOtros.Text = Format(0, "$ #,##0.00")
                    lblImpTotal.Text = Format(0, "$ #,##0.00")

                    lblPorcGrano.Text = Format(0, "#,##0.00")
                    lblPorcSilo.Text = Format(0, "#,##0.00")
                    lblPorcConcentrado.Text = Format(0, "#,##0.00")
                    lblPorcFibra.Text = Format(0, "#,##0.00")
                    lblPorcOtros.Text = Format(0, "#,##0.00")
                End If
            Next
        End If
    End Sub

    Private Sub grpConsTropa_DoubleClick(sender As Object, e As EventArgs) Handles grpConsTropa.DoubleClick
        Dim _Dt, _Dt2 As DataTable
        Dim _Ver, _Ver2 As New Mostrar

        Dim cosnGrano, cosnConcentrado, cosnFibra, cosnOtros, cosnTotal As Double

        Dim Count As Integer = 0

        frmConcAlimDetalle.grpGrafico.Series("ConsTotal").Points.Clear()
        frmConcAlimDetalle.grpGrafico.Series("ConsGrano").Points.Clear()
        frmConcAlimDetalle.grpGrafico.Series("ConsConc").Points.Clear()
        frmConcAlimDetalle.grpGrafico.Series("ConsFibra").Points.Clear()
        frmConcAlimDetalle.grpGrafico.Series("ConsOtros").Points.Clear()

        frmConcAlimDetalle.grpGrafico.Titles.Clear()

        frmConcAlimDetalle.lblMsg.Text = "GRAFICO - CONSUMO POR TROPA"

        frmConcAlimDetalle.grpGrafico.ChartAreas("ChartArea1").AxisX.LabelStyle.Enabled = False

        Dim FechaH As Date

        If dtmFhasta.Enabled = False Then
            FechaH = dtmFhasta.MaxDate
        Else
            FechaH = Format(CDate(dtmFhasta.Text), "yyyy/MM/dd")
        End If

        cosnGrano = 0
        cosnConcentrado = 0
        cosnFibra = 0
        cosnTotal = 0
        cosnOtros = 0

        _Dt = _Ver.verTropaUs(frmLogin.txtID.Text)

        If _Dt.Rows.Count > 0 Then
            For Each _Dr As DataRow In _Dt.Rows
                _Dt2 = _Ver2.verAlimentacionProRateo_FechaDH_Tropa_Us(frmLogin.txtID.Text, Format(CDate(dtmFdesde.Text), "yyyy/MM/dd"), FechaH, _Dr("idTropa"))

                If _Dt2.Rows.Count > 0 Then
                    For Each _Dr2 As DataRow In _Dt2.Rows
                        If rdbKg.Checked = True Then
                            cosnTotal = cosnTotal + _Dr2("KgRacion")
                            cosnGrano = cosnGrano + _Dr2("KgGrano")
                            cosnConcentrado = cosnConcentrado + _Dr2("KgConcentrado")
                            cosnFibra = cosnFibra + _Dr2("KgFibra")
                            cosnOtros = cosnOtros + _Dr2("KgOtros")
                        Else
                            cosnTotal = cosnTotal + _Dr2("ImporteTotal")
                            cosnGrano = cosnGrano + _Dr2("ImporteGrano")
                            cosnConcentrado = cosnConcentrado + _Dr2("ImporteConcentrado")
                            cosnFibra = cosnFibra + _Dr2("ImporteFibra")
                            cosnOtros = cosnOtros + _Dr2("ImporteOtros")
                        End If
                    Next

                    'frmConcAlimDetalle.grpGrafico.Series("ConsTotal").Points.Add(cosnTotal)
                    frmConcAlimDetalle.grpGrafico.Series("ConsGrano").Points.Add(cosnGrano)
                    frmConcAlimDetalle.grpGrafico.Series("ConsConc").Points.Add(cosnConcentrado)
                    frmConcAlimDetalle.grpGrafico.Series("ConsFibra").Points.Add(cosnFibra)
                    frmConcAlimDetalle.grpGrafico.Series("ConsOtros").Points.Add(cosnOtros)

                    frmConcAlimDetalle.grpGrafico.Series("ConsGrano").LegendText = "Grano"
                    frmConcAlimDetalle.grpGrafico.Series("ConsConc").LegendText = "Concentrado"
                    frmConcAlimDetalle.grpGrafico.Series("ConsFibra").LegendText = "Fibra"
                    frmConcAlimDetalle.grpGrafico.Series("ConsOtros").LegendText = "Otros"

                    frmConcAlimDetalle.grpGrafico.Series("ConsGrano").Points(Count).Label = _Dr("NombreTropa")

                    cosnGrano = 0
                    cosnConcentrado = 0
                    cosnFibra = 0
                    cosnTotal = 0
                    cosnOtros = 0

                    Count = Count + 1
                End If
            Next
        End If

        If grpConsProductor.Titles(0).Text = "CONSUMO X PRODUCTOR" Then
            frmConcAlimDetalle.grpGrafico.Titles.Add("CONSUMO X TROPA")
            frmConcAlimDetalle.grpGrafico.ChartAreas("ChartArea1").AxisY.Title = "KG"
        Else
            frmConcAlimDetalle.grpGrafico.Titles.Add("IMPORTE X TROPA")
            frmConcAlimDetalle.grpGrafico.ChartAreas("ChartArea1").AxisY.Title = "$"
        End If

        frmConcAlimDetalle.grpGrafico.ChartAreas("ChartArea1").AxisX.Title = "Tropa"

        frmConcAlimDetalle.grpGrafico.Titles(0).Font = New Font("Arial", 12, FontStyle.Bold)

        frmConcAlimDetalle.grpGrafico.Titles(0).ForeColor = Color.SaddleBrown

        CargarDetalleAlim()

        frmConcAlimDetalle.ShowDialog()
        frmConcAlimDetalle.Refresh()
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
            frmConsCaravanas.lblOrigen.Text = "CONSULTA ALIMENTACION"
            frmConsCaravanas.ShowDialog()
            txtCaravana.Select()
        Else
            txtCaravana.Enabled = False
            txtCaravana.BackColor = Color.White
            txtCaravana.Text = ""
        End If
    End Sub

    Private Sub grpConsProductor_Click(sender As Object, e As EventArgs) Handles grpConsProductor.Click
        Dim _Dt, _Dt2 As DataTable
        Dim _Ver, _Ver2 As New Mostrar

        Dim cosnGrano, cosnConcentrado, cosnFibra, cosnOtros, cosnTotal As Double

        Dim Count As Integer = 0

        frmConcAlimDetalle.grpGrafico.Series("ConsTotal").Points.Clear()
        frmConcAlimDetalle.grpGrafico.Series("ConsGrano").Points.Clear()
        frmConcAlimDetalle.grpGrafico.Series("ConsConc").Points.Clear()
        frmConcAlimDetalle.grpGrafico.Series("ConsFibra").Points.Clear()
        frmConcAlimDetalle.grpGrafico.Series("ConsOtros").Points.Clear()

        frmConcAlimDetalle.grpGrafico.Titles.Clear()

        frmConcAlimDetalle.grpGrafico.ChartAreas("ChartArea1").AxisX.LabelStyle.Enabled = False

        frmConcAlimDetalle.lblMsg.Text = "GRAFICO - CONSUMO POR PRODUCTOR"

        Dim FechaH As Date

        If dtmFhasta.Enabled = False Then
            FechaH = dtmFhasta.MaxDate
        Else
            FechaH = Format(CDate(dtmFhasta.Text), "yyyy/MM/dd")
        End If

        cosnGrano = 0
        cosnConcentrado = 0
        cosnFibra = 0
        cosnTotal = 0
        cosnOtros = 0

        _Dt = _Ver.verProductorUs(frmLogin.txtID.Text)

        If _Dt.Rows.Count > 0 Then
            For Each _Dr As DataRow In _Dt.Rows
                _Dt2 = _Ver2.verAlimentacionProRateo_FechaDH_Productor_Us(frmLogin.txtID.Text, Format(CDate(dtmFdesde.Text), "yyyy/MM/dd"), FechaH, _Dr("idProductor"))

                If _Dt2.Rows.Count > 0 Then
                    For Each _Dr2 As DataRow In _Dt2.Rows
                        If rdbKg.Checked = True Then
                            cosnTotal = cosnTotal + _Dr2("KgRacion")
                            cosnGrano = cosnGrano + _Dr2("KgGrano")
                            cosnConcentrado = cosnConcentrado + _Dr2("KgConcentrado")
                            cosnFibra = cosnFibra + _Dr2("KgFibra")
                            cosnOtros = cosnOtros + _Dr2("KgOtros")
                        Else
                            cosnTotal = cosnTotal + _Dr2("ImporteTotal")
                            cosnGrano = cosnGrano + _Dr2("ImporteGrano")
                            cosnConcentrado = cosnConcentrado + _Dr2("ImporteConcentrado")
                            cosnFibra = cosnFibra + _Dr2("ImporteFibra")
                            cosnOtros = cosnOtros + _Dr2("ImporteOtros")
                        End If
                    Next

                    'frmConcAlimDetalle.grpGrafico.Series("ConsTotal").Points.Add(cosnTotal)
                    frmConcAlimDetalle.grpGrafico.Series("ConsGrano").Points.Add(cosnGrano)
                    frmConcAlimDetalle.grpGrafico.Series("ConsConc").Points.Add(cosnConcentrado)
                    frmConcAlimDetalle.grpGrafico.Series("ConsFibra").Points.Add(cosnFibra)
                    frmConcAlimDetalle.grpGrafico.Series("ConsOtros").Points.Add(cosnOtros)

                    frmConcAlimDetalle.grpGrafico.Series("ConsGrano").LegendText = "Grano"
                    frmConcAlimDetalle.grpGrafico.Series("ConsConc").LegendText = "Concentrado"
                    frmConcAlimDetalle.grpGrafico.Series("ConsFibra").LegendText = "Fibra"
                    frmConcAlimDetalle.grpGrafico.Series("ConsOtros").LegendText = "Otros"

                    frmConcAlimDetalle.grpGrafico.Series("ConsGrano").Points(Count).Label = _Dr("RazonSocial")

                    cosnGrano = 0
                    cosnConcentrado = 0
                    cosnFibra = 0
                    cosnTotal = 0
                    cosnOtros = 0

                    Count = Count + 1
                End If
            Next
        End If

        If grpConsProductor.Titles(0).Text = "CONSUMO X PRODUCTOR" Then
            frmConcAlimDetalle.grpGrafico.Titles.Add("CONSUMO X PRODUCTOR")
            frmConcAlimDetalle.grpGrafico.ChartAreas("ChartArea1").AxisY.Title = "KG"
        Else
            frmConcAlimDetalle.grpGrafico.Titles.Add("IMPORTE X PRODUCTOR")
            frmConcAlimDetalle.grpGrafico.ChartAreas("ChartArea1").AxisY.Title = "$"
        End If

        frmConcAlimDetalle.grpGrafico.ChartAreas("ChartArea1").AxisX.Title = "Productor"

        frmConcAlimDetalle.grpGrafico.Titles(0).Font = New Font("Arial", 12, FontStyle.Bold)

        frmConcAlimDetalle.grpGrafico.Titles(0).ForeColor = Color.SaddleBrown

        CargarDetalleAlim()

        frmConcAlimDetalle.ShowDialog()
        frmConcAlimDetalle.Refresh()
    End Sub

    Private Sub CargarDetalleAlim()
        Dim _Dt As DataTable
        Dim _Ver As New Mostrar

        Dim FechaH As Date

        If dtmFhasta.Enabled = False Then
            FechaH = dtmFhasta.MaxDate
        Else
            FechaH = Format(CDate(dtmFhasta.Text), "yyyy/MM/dd")
        End If

        Dim kgGrano, kgSilo, kgConcentrado, kgFibra, kgOtros, kgTotales As Double
        Dim costGrano, costSilo, costConcentrado, costFibra, costOtros, costTotal As Double
        Dim porcGrano, porcSilo, porcConcentrado, porcFibra, porcOtros As Double

        kgGrano = 0
        kgSilo = 0
        kgConcentrado = 0
        kgFibra = 0
        kgOtros = 0
        kgTotales = 0

        costGrano = 0
        costSilo = 0
        costConcentrado = 0
        costFibra = 0
        costOtros = 0
        costTotal = 0

        porcGrano = 0
        porcSilo = 0
        porcConcentrado = 0
        porcFibra = 0
        porcOtros = 0

        _Dt = _Ver.verAlimentacion_FechaDH_Us(frmLogin.txtID.Text, Format(CDate(dtmFdesde.Text), "yyyy/MM/dd"), FechaH)

        If _Dt.Rows.Count > 0 Then
            For Each _Dr As DataRow In _Dt.Rows
                kgGrano = kgGrano + _Dr("KgGrano")
                kgSilo = kgSilo + _Dr("KgSilo")
                kgConcentrado = kgConcentrado + _Dr("KgConcentrado")
                kgFibra = kgFibra + _Dr("KgFibra")
                kgOtros = kgOtros + _Dr("KgOtros")
                kgTotales = kgTotales + _Dr("KgRacion")

                costGrano = costGrano + _Dr("ImporteGrano")
                costSilo = costSilo + _Dr("ImporteSilo")
                costConcentrado = costConcentrado + _Dr("ImporteConcentrado")
                costFibra = costFibra + _Dr("ImporteFibra")
                costOtros = costOtros + _Dr("ImporteOtros")
                costTotal = costTotal + _Dr("ImporteTotal")

                porcGrano = (kgGrano / kgTotales) * 100
                porcSilo = (kgSilo / kgTotales) * 100
                porcConcentrado = (kgConcentrado / kgTotales) * 100
                porcFibra = (kgFibra / kgTotales) * 100
                porcOtros = (kgOtros / kgTotales) * 100
            Next
        End If

        frmConcAlimDetalle.lblKgGrano.Text = Format(kgGrano, "#,##0.00")
        frmConcAlimDetalle.lblKgGrano.Text = Format(kgSilo, "#,##0.00")
        frmConcAlimDetalle.lblKgConc.Text = Format(kgConcentrado, "#,##0.00")
        frmConcAlimDetalle.lblKgFib.Text = Format(kgFibra, "#,##0.00")
        frmConcAlimDetalle.lblKgOtr.Text = Format(kgOtros, "#,##0.00")
        frmConcAlimDetalle.lblKgTot.Text = Format(kgTotales, "#,##0.00")

        frmConcAlimDetalle.lblImpGrano.Text = Format(costGrano, "#,##0.00")
        frmConcAlimDetalle.lblImpGrano.Text = Format(costSilo, "#,##0.00")
        frmConcAlimDetalle.lblImpConc.Text = Format(costConcentrado, "#,##0.00")
        frmConcAlimDetalle.lblImpFib.Text = Format(costFibra, "#,##0.00")
        frmConcAlimDetalle.lblImpOtr.Text = Format(costOtros, "#,##0.00")
        frmConcAlimDetalle.lblImpTot.Text = Format(costTotal, "#,##0.00")

        frmConcAlimDetalle.lblPorGrano.Text = Format(porcGrano, "#,##0.00")
        frmConcAlimDetalle.lblPorGrano.Text = Format(porcSilo, "#,##0.00")
        frmConcAlimDetalle.lblPorConc.Text = Format(porcConcentrado, "#,##0.00")
        frmConcAlimDetalle.lblPorFib.Text = Format(porcFibra, "#,##0.00")
        frmConcAlimDetalle.lblPorOtr.Text = Format(porcOtros, "#,##0.00")
        frmConcAlimDetalle.lblPorTot.Text = Format(100, "#,##0.00")
    End Sub

    Private Sub grpConsDia_DoubleClick(sender As Object, e As EventArgs) Handles grpConsDia.DoubleClick
        Dim _Dt As DataTable
        Dim _Ver As New Mostrar

        Dim cosnGrano, conSilo, cosnConcentrado, cosnFibra, cosnOtros, cosnTotal As Double

        Dim Count As Integer = 0

        frmConcAlimDetalle.grpGrafico.Series("ConsTotal").Points.Clear()
        frmConcAlimDetalle.grpGrafico.Series("ConsGrano").Points.Clear()
        frmConcAlimDetalle.grpGrafico.Series("ConsConc").Points.Clear()
        frmConcAlimDetalle.grpGrafico.Series("ConsFibra").Points.Clear()
        frmConcAlimDetalle.grpGrafico.Series("ConsOtros").Points.Clear()

        frmConcAlimDetalle.grpGrafico.Titles.Clear()

        frmConcAlimDetalle.lblMsg.Text = "GRAFICO - CONSUMO POR DIA"

        frmConcAlimDetalle.grpGrafico.ChartAreas("ChartArea1").AxisX.LabelStyle.Enabled = True

        Dim FechaH As Date

        If dtmFhasta.Enabled = False Then
            FechaH = dtmFhasta.MaxDate
        Else
            FechaH = Format(CDate(dtmFhasta.Text), "yyyy/MM/dd")
        End If

        cosnGrano = 0
        conSilo = 0
        cosnConcentrado = 0
        cosnFibra = 0
        cosnTotal = 0
        cosnOtros = 0

        Dim FechaCons As Date = Format(CDate(dtmFdesde.Text), "yyyy/MM/dd")

        Do
            _Dt = _Ver.verAlimentacion_Fecha_Us(frmLogin.txtID.Text, FechaCons)

            If _Dt.Rows.Count > 0 Then
                For Each _Dr As DataRow In _Dt.Rows
                    If rdbKg.Checked = True Then
                        cosnTotal = cosnTotal + _Dr("KgRacion")
                        cosnGrano = cosnGrano + _Dr("KgGrano")
                        conSilo = conSilo + _Dr("KgSilo")
                        cosnConcentrado = cosnConcentrado + _Dr("KgConcentrado")
                        cosnFibra = cosnFibra + _Dr("KgFibra")
                        cosnOtros = cosnOtros + _Dr("KgOtros")
                    Else
                        cosnTotal = cosnTotal + _Dr("ImporteTotal")
                        cosnGrano = cosnGrano + _Dr("ImporteGrano")
                        conSilo = conSilo + _Dr("ImporteSilo")
                        cosnConcentrado = cosnConcentrado + _Dr("ImporteConcentrado")
                        cosnFibra = cosnFibra + _Dr("ImporteFibra")
                        cosnOtros = cosnOtros + _Dr("ImporteOtros")
                    End If
                Next
            End If

            'frmConcAlimDetalle.grpGrafico.Series("ConsTotal").Points.Add(cosnTotal)
            frmConcAlimDetalle.grpGrafico.Series("ConsGrano").Points.Add(cosnGrano)
            frmConcAlimDetalle.grpGrafico.Series("ConsSilo").Points.Add(conSilo)
            frmConcAlimDetalle.grpGrafico.Series("ConsConc").Points.Add(cosnConcentrado)
            frmConcAlimDetalle.grpGrafico.Series("ConsFibra").Points.Add(cosnFibra)
            frmConcAlimDetalle.grpGrafico.Series("ConsOtros").Points.Add(cosnOtros)

            frmConcAlimDetalle.grpGrafico.Series("ConsGrano").LegendText = "Grano"
            frmConcAlimDetalle.grpGrafico.Series("ConsSilo").LegendText = "Silo"
            frmConcAlimDetalle.grpGrafico.Series("ConsConc").LegendText = "Concentrado"
            frmConcAlimDetalle.grpGrafico.Series("ConsFibra").LegendText = "Fibra"
            frmConcAlimDetalle.grpGrafico.Series("ConsOtros").LegendText = "Otros"

            frmConcAlimDetalle.grpGrafico.Series("ConsGrano").Points(Count).AxisLabel = FechaCons
            frmConcAlimDetalle.grpGrafico.Series("ConsSilo").Points(Count).AxisLabel = FechaCons
            frmConcAlimDetalle.grpGrafico.Series("ConsConc").Points(Count).AxisLabel = FechaCons
            frmConcAlimDetalle.grpGrafico.Series("ConsFibra").Points(Count).AxisLabel = FechaCons
            frmConcAlimDetalle.grpGrafico.Series("ConsOtros").Points(Count).AxisLabel = FechaCons

            cosnGrano = 0
            conSilo = 0
            cosnConcentrado = 0
            cosnFibra = 0
            cosnTotal = 0
            cosnOtros = 0

            Count = Count + 1

            FechaCons = FechaCons.AddDays(1)
        Loop While FechaCons <= FechaH

        If grpConsProductor.Titles(0).Text = "CONSUMO X PRODUCTOR" Then
            frmConcAlimDetalle.grpGrafico.Titles.Add("CONSUMO X DIA")
            frmConcAlimDetalle.grpGrafico.ChartAreas("ChartArea1").AxisY.Title = "KG"
        Else
            frmConcAlimDetalle.grpGrafico.Titles.Add("IMPORTE X DIA")
            frmConcAlimDetalle.grpGrafico.ChartAreas("ChartArea1").AxisY.Title = "$"
        End If

        frmConcAlimDetalle.grpGrafico.ChartAreas("ChartArea1").AxisX.Title = "Fecha"

        frmConcAlimDetalle.grpGrafico.Titles(0).Font = New Font("Arial", 12, FontStyle.Bold)

        frmConcAlimDetalle.grpGrafico.Titles(0).ForeColor = Color.SaddleBrown

        CargarDetalleAlim()

        frmConcAlimDetalle.ShowDialog()
        frmConcAlimDetalle.Refresh()
    End Sub

    Private Sub cbxNoEscribir_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxTropa.KeyPress, cbxCorral.KeyPress, cbxProductor.KeyPress, txtCaravana.KeyPress
        e.Handled = True
    End Sub

    Private Sub txtCaravana_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCaravana.KeyPress
        If Asc(e.KeyChar) <> Keys.Delete Then
            txtIdCar.Text = ""
            txtCaravana.Text = ""
            frmConsCaravanas.ShowDialog()
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub grpCarv_Click(sender As Object, e As EventArgs) Handles grpCarv.Click
        If grpCarv.Series("Caravana").ChartType = DataVisualization.Charting.SeriesChartType.Spline Then
            grpCarv.Series("Caravana").ChartType = DataVisualization.Charting.SeriesChartType.Column
        Else
            grpCarv.Series("Caravana").ChartType = DataVisualization.Charting.SeriesChartType.Spline
        End If
    End Sub
End Class