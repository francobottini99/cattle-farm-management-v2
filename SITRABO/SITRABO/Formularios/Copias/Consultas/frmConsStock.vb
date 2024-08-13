Public Class frmConsStock
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

    Private Sub pbxFiltar_GotFocus(sender As Object, e As EventArgs) Handles pbxFiltar.GotFocus
        pbxFiltar.BackgroundImage = SITRABO.My.Resources.btnFiltrarSi
    End Sub

    Private Sub pbxFiltar_LostFocus(sender As Object, e As EventArgs) Handles pbxFiltar.LostFocus
        pbxFiltar.BackgroundImage = SITRABO.My.Resources.btnFiltrarNo1
    End Sub

    Private Sub pbxFiltar_MouseEnter(sender As Object, e As EventArgs) Handles pbxFiltar.MouseEnter
        pbxFiltar.BackgroundImage = SITRABO.My.Resources.btnFiltrarSi
    End Sub

    Private Sub pbxFiltar_MouseLeave(sender As Object, e As EventArgs) Handles pbxFiltar.MouseLeave
        pbxFiltar.BackgroundImage = SITRABO.My.Resources.btnFiltrarNo1
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

    Private Sub btnFiltrar(ByVal sender As System.Object, ByVal e As KeyPressEventArgs)
        If Asc(e.KeyChar) = Keys.Enter Then
            PbxFiltar_Click(1, Nothing)
        End If
    End Sub

    Private Sub FrmConsStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ctlFiltrar As Control = DirectCast(pbxFiltar, Control)
        Dim keyprFiltrar = New KeyPressEventHandler(AddressOf btnFiltrar)

        AddHandler ctlFiltrar.KeyPress, keyprFiltrar

        Me.Text = "Si.Tra.Bo. - Sistema de Trazabilidad Bovina" & " - USUARIO: " & frmLogin.txtNom.Text & " " & frmLogin.txtAp.Text & " -"

        dtmFstk.MinDate = "2017-12-04"

        FechaStock(Date.Now.Date)

        dtmFstk.Value = Date.Now.Date

        pbxFiltar.Select()
    End Sub

    Private Sub PbxSalir_Click(sender As Object, e As EventArgs) Handles pbxSalir.Click
        Me.Close()
    End Sub

    Private Sub PbxFiltar_Click(sender As Object, e As EventArgs) Handles pbxFiltar.Click
        pnlCorrales.AutoScroll = False

        Dim num_controles As Int32 = pnlCorrales.Controls.Count - 1

        For n As Integer = num_controles To 0 Step -1
            Dim ctrl As Windows.Forms.Control = pnlCorrales.Controls(n)

            pnlCorrales.Controls.Remove(ctrl)

            ctrl.Dispose()
        Next

        pnlCorrales.AutoScroll = True

        Dim _Dt As DataTable
        Dim _Ver As New Mostrar

        _Dt = _Ver.consStockPorFecha(lblFechaStock.Text)

        If _Dt.Rows.Count > 0 Then
            Dim view As DataView = New DataView(_Dt)

            Dim numCorrales As Integer = 1
            Dim titCorrales(1) As String
            Dim idCorrales(1) As Integer

            view.Sort = "idCorrales"
            _Dt = view.ToTable()

            titCorrales(0) = _Dt.Rows(0).Item("NombreCorral")
            idCorrales(0) = _Dt.Rows(0).Item("idCorrales")

            For i As Integer = 1 To _Dt.Rows.Count - 1
                If _Dt.Rows(i).Item("idCorrales") <> _Dt.Rows(i - 1).Item("idCorrales") Then
                    numCorrales += 1

                    ReDim Preserve titCorrales(numCorrales)
                    ReDim Preserve idCorrales(numCorrales)

                    titCorrales(numCorrales - 1) = _Dt.Rows(i).Item("NombreCorral")
                    idCorrales(numCorrales - 1) = _Dt.Rows(i).Item("idCorrales")
                End If
            Next

            Dim Corral As New List(Of Corrales)

            For i As Integer = 0 To numCorrales - 1
                Corral.Add(New Corrales(idCorrales(i), titCorrales(i), New List(Of Tropas)))

                For j As Integer = 0 To _Dt.Rows.Count - 1
                    If _Dt.Rows(j).Item("idCorrales") = Corral.Item(i).idCorral Then
                        Dim AggT As Boolean = True

                        For k As Integer = 0 To Corral.Item(i).Tropa.Count - 1
                            If Corral.Item(i).Tropa(k).idTropa = _Dt.Rows(j).Item("idTropa") Then
                                AggT = False
                            End If
                        Next

                        If AggT Then
                            Corral.Item(i).Tropa.Add(New Tropas(_Dt.Rows(j).Item("idTropa"), _Dt.Rows(j).Item("NombreTropa"), New List(Of Categorias)))

                            For k As Integer = 0 To _Dt.Rows.Count - 1
                                If _Dt.Rows(k).Item("idTropa") = Corral.Item(i).Tropa.Last.idTropa And _Dt.Rows(k).Item("idCorrales") = Corral.Item(i).idCorral Then
                                    Dim AggC As Boolean = True

                                    For m As Integer = 0 To Corral.Item(i).Tropa.Last.Categoria.Count - 1
                                        If Corral.Item(i).Tropa.Last.Categoria.Item(m).idCategoria = _Dt.Rows(k).Item("idCategorias") Then
                                            AggC = False
                                        End If
                                    Next

                                    If AggC Then
                                        Dim count As Integer = 0

                                        Corral.Item(i).Tropa.Last.Categoria.Add(New Categorias(_Dt.Rows(k).Item("idCategorias"), _Dt.Rows(k).Item("Categoria"), 0))

                                        For m As Integer = 0 To _Dt.Rows.Count - 1
                                            If _Dt.Rows(m).Item("idCategorias") = Corral.Item(i).Tropa.Last.Categoria.Last.idCategoria And _Dt.Rows(m).Item("idTropa") = Corral.Item(i).Tropa.Last.idTropa And _Dt.Rows(m).Item("idCorrales") = Corral.Item(i).idCorral Then
                                                count += 1
                                            End If
                                        Next

                                        Corral.Item(i).Tropa.Last.Categoria.Last.canCategoria = count
                                    End If
                                End If
                            Next
                        End If
                    End If
                Next
            Next

            Dim trjCrr As New List(Of TarjetaStkCorral)
            Dim CatTot As New List(Of Categorias)
            Dim numCabCorr(numCorrales) As Integer

            Dim posX As Integer = 19
            Dim posY As Integer = 17

            Dim Num As Integer = 1
            Dim totCab As Integer = 0

            For Each crr In Corral
                Dim nomTrop(crr.Tropa.Count) As String
                Dim Cat As New List(Of Categorias)
                Dim totCabCrr As Integer = 0

                For i As Integer = 0 To crr.Tropa.Count - 1
                    nomTrop(i) = crr.Tropa.Item(i).nomTropa
                Next

                trjCrr.Add(New TarjetaStkCorral(crr.Tropa.Count, posX, posY, crr.nomCorral, nomTrop))

                For i As Integer = 0 To crr.Tropa.Count - 1
                    For j As Integer = 0 To crr.Tropa.Item(i).Categoria.Count - 1
                        Dim Agg As Boolean = True

                        trjCrr.Last.ascTarjetaDetalleTropa.Item(i).dgvDetalleTropa.Rows.Add(crr.Tropa.Item(i).Categoria.Item(j).nomCategoria, crr.Tropa.Item(i).Categoria.Item(j).canCategoria)

                        For k As Integer = 0 To Cat.Count - 1
                            If crr.Tropa.Item(i).Categoria.Item(j).idCategoria = Cat.Item(k).idCategoria Then
                                Cat.Item(k).canCategoria += crr.Tropa.Item(i).Categoria.Item(j).canCategoria

                                Agg = False
                            End If
                        Next

                        If Agg Then
                            Cat.Add(New Categorias(crr.Tropa.Item(i).Categoria.Item(j).idCategoria, crr.Tropa.Item(i).Categoria.Item(j).nomCategoria, crr.Tropa.Item(i).Categoria.Item(j).canCategoria))
                        End If
                    Next
                Next

                For Each item In Cat
                    Dim Agg As Boolean = True

                    trjCrr.Last.dgvTotales.Rows.Add(item.nomCategoria, item.canCategoria)

                    totCabCrr += item.canCategoria

                    For Each item2 In CatTot
                        If item.idCategoria = item2.idCategoria Then
                            item2.canCategoria += item.canCategoria

                            Agg = False
                        End If
                    Next

                    If Agg Then
                        CatTot.Add(New Categorias(item.idCategoria, item.nomCategoria, item.canCategoria))
                    End If
                Next

                trjCrr.Last.lblTituloPPal.Text &= " - Total: " & totCabCrr

                totCab += totCabCrr
                numCabCorr(Num - 1) = totCabCrr

                If Num Mod 2 = 0 Then
                    posX = 19
                    posY += 377
                Else
                    posX = 604
                End If

                Num += 1
            Next

            For Each trj In trjCrr
                pnlCorrales.Controls.Add(trj.pnlTarjetaCorral)
            Next

            If frmLogin.txtTipUs.Text = "Super Usuario" Then
                _Dt = _Ver.verCorrales()
            Else
                _Dt = _Ver.verCorralesUs(frmLogin.txtID.Text)
            End If

            lblCorrConAnim.Text = numCorrales
            lblCLib.Text = _Dt.Rows.Count - numCorrales
            lblTotalCorr.Text = _Dt.Rows.Count
            lblStkTotal.Text = totCab

            _Dt = _Ver.consStockPorFechaMH(lblFechaStock.Text, "Macho")

            lblStkMachos.Text = _Dt.Rows.Count
            lblStkHembras.Text = totCab - _Dt.Rows.Count

            grpCategorias.Series("Categorias").Points.Clear()

            grpCategorias.Titles.Clear()

            For i As Integer = 0 To CatTot.Count - 1
                grpCategorias.Series("Categorias").Points.Add(CatTot.Item(i).canCategoria)
                grpCategorias.Series("Categorias").Points(i).LegendText = CatTot.Item(i).nomCategoria
                grpCategorias.Series("Categorias").Points(i).IsVisibleInLegend = True
            Next

            grpCategorias.Titles.Add("CATEGORIAS")

            grpCategorias.Titles(0).Font = New Font("Arial", 12, FontStyle.Bold)

            grpCategorias.Titles(0).ForeColor = Color.DarkRed

            grpCorrales.Series("Corrales").Points.Clear()

            grpCorrales.Titles.Clear()

            For i As Integer = 0 To numCorrales - 1
                grpCorrales.Series("Corrales").Points.Add(numCabCorr(i))
                grpCorrales.Series("Corrales").Points(i).LegendText = titCorrales(i)
                grpCorrales.Series("Corrales").Points(i).IsVisibleInLegend = True
            Next

            grpCorrales.Titles.Add("CORRALES")

            grpCorrales.Titles(0).Font = New Font("Arial", 12, FontStyle.Bold)

            grpCorrales.Titles(0).ForeColor = Color.DarkRed

            pnlIncial2.Visible = False
            pnlInicial1.Visible = False

            pnlTotales.Visible = True
            pnlCorrales.Visible = True
        End If
    End Sub

    Private Sub GraficarRacion(ByVal grp As System.Windows.Forms.DataVisualization.Charting.Chart,
                               ByVal porcGrano As Double, ByVal porcConcentrado As Double, ByVal porcFibra As Double, ByVal porcOtros As Double,
                               ByVal KgTot As Double)

    End Sub


    Private Class Corrales
        Public Property idCorral As Integer
        Public Property nomCorral As String
        Public Property Tropa As List(Of Tropas)

        Public Sub New(ByVal id As Integer, ByVal nom As String, ByVal trop As List(Of Tropas))
            idCorral = id
            nomCorral = nom
            Tropa = trop
        End Sub
    End Class

    Private Class Tropas
        Public Property idTropa As Integer
        Public Property nomTropa As String
        Public Property Categoria As List(Of Categorias)

        Public Sub New(ByVal id As Integer, ByVal nom As String, ByVal cat As List(Of Categorias))
            idTropa = id
            nomTropa = nom
            Categoria = cat
        End Sub
    End Class

    Private Class Categorias
        Public Property idCategoria As Integer
        Public Property nomCategoria As String
        Public Property canCategoria As Integer

        Public Sub New(ByVal id As Integer, ByVal nom As String, ByVal can As Integer)
            idCategoria = id
            nomCategoria = nom
            canCategoria = can
        End Sub
    End Class

    Private Sub DtmFstk_ValueChanged(sender As Object, e As EventArgs) Handles dtmFstk.ValueChanged
        FechaStock(dtmFstk.Value)
    End Sub
End Class