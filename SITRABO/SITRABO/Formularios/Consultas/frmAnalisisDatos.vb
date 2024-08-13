Public Class frmAnalisisDatos
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

    Private Sub pbxGenerar_GotFocus(sender As Object, e As EventArgs) Handles pbxGenerar.GotFocus
        pbxGenerar.BackgroundImage = SITRABO.My.Resources.btnTransferirSi
    End Sub

    Private Sub pbxGenerar_LostFocus(sender As Object, e As EventArgs) Handles pbxGenerar.LostFocus
        pbxGenerar.BackgroundImage = SITRABO.My.Resources.btnTransferirNo
    End Sub

    Private Sub pbxGenerar_MouseEnter(sender As Object, e As EventArgs) Handles pbxGenerar.MouseEnter
        pbxGenerar.BackgroundImage = SITRABO.My.Resources.btnTransferirSi
    End Sub

    Private Sub pbxGenerar_MouseLeave(sender As Object, e As EventArgs) Handles pbxGenerar.MouseLeave
        pbxGenerar.BackgroundImage = SITRABO.My.Resources.btnTransferirNo
    End Sub

    Private Sub PbxGenerar_Click(sender As Object, e As EventArgs) Handles pbxGenerar.Click
        Dim _DtPesajes As New DataTable
        Dim _Ver As New Mostrar
        Dim Filtro As String = ""

        If DateDiff(DateInterval.Day, CDate(dtmFdesde.Value), CDate(dtmFhasta.Value)) <= 365 And (chbFdesde.Enabled = True Or chbFhasta.Enabled = True) Then
            If chbFdesde.Checked = True Then
                If Filtro <> "" Then
                    Filtro += " And "
                End If

                Filtro += "pesaje.Fecha >= '" + Format(CDate(dtmFdesde.Text), "yyyy/MM/dd") + "'"
            End If

            If chbFhasta.Checked = True Then
                If Filtro <> "" Then
                    Filtro += " AND "
                End If

                Filtro += "pesaje.Fecha <= '" + Format(CDate(dtmFhasta.Text), "yyyy/MM/dd") + "'"
            End If

            If chbProd.Checked = True Then
                If cbxProductor.Text <> "" Then
                    If Filtro <> "" Then
                        Filtro += " AND "
                    End If

                    'Filtro += "tropa.idTropa = " + txtIdT.Text
                End If
            End If

            If chbTropa.Checked = True Then
                If cbxTropa.Text <> "" Then
                    If Filtro <> "" Then
                        Filtro += " AND "
                    End If

                    Filtro += "tropa.idTropa = " + txtIdT.Text
                End If
            End If

            If chbCorral.Checked = True Then
                If cbxCorral.Text <> "" Then
                    If Filtro <> "" Then
                        Filtro += " AND "
                    End If

                    'Filtro += "tropa.NombreTropa = " + cbxTropa.Text
                End If
            End If

            If Filtro <> "" Then
                If rdbPeso.Checked Then
                    _DtPesajes = _Ver.consPesajeDinamico(Filtro)

                    If _DtPesajes.Rows.Count > 0 Then
                        gbxExportacion.Visible = True
                        gbxInformes.Visible = False

                        pbrExportacion.Value = 0

                        pbrExportacion.Minimum = 0
                        pbrExportacion.Maximum = 100
                        pbrExportacion.Step = 100 / (158 + _DtPesajes.Rows.Count * 2)

                        BackgroundWorker.RunWorkerAsync(_DtPesajes)
                    End If
                End If
            Else
                MsgBox("Selecciona al menos un criterio de filtro... !", vbExclamation, "Servico de Alertas")
            End If
        Else
            MsgBox("El intervalo de Fecha en la consulta no puede superar los 365 días... !", vbExclamation, "Servico de Alertas")
        End If

    End Sub

    Function ExportarDataTableAExcel(ByVal Nombre As String, ByVal Tabla As DataTable) As Boolean
        Dim exApp As New Microsoft.Office.Interop.Excel.Application
        Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
        Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet
        Dim filaTabla As System.Data.DataRow

        Try
            'Añadimos el Libro al programa, y la hoja al libro
            exLibro = exApp.Workbooks.Add
            exHoja = exLibro.Worksheets.Add
            exHoja = exLibro.Worksheets(1)
            exHoja.Name = "DATOS"
            exHoja = exLibro.Worksheets(2)
            exHoja.Name = "GRAFICOS"

            exHoja = exLibro.Worksheets(1)

            '¿Cuantas columnas y cuantas filas?
            Dim NCol As Integer = Tabla.Columns.Count
            Dim NRow As Integer = Tabla.Rows.Count

            'Aqui recorremos todas las filas, y por cada fila todas las columnas y vamos escribiendo.
            For i As Integer = 1 To NCol
                exHoja.Cells.Item(3, i) = Tabla.Columns(i - 1).Caption

                BackgroundWorker.ReportProgress(pbrExportacion.Step)
            Next

            For Fila As Integer = 0 To NRow - 1
                filaTabla = Tabla.Rows(Fila)
                For Col As Integer = 0 To NCol - 1
                    If Col > 3 Then
                        If IsNumeric(filaTabla(Col)) Then
                            exHoja.Cells.Item(Fila + 4, Col + 1) = CDbl(filaTabla(Col))
                        End If
                    Else
                        exHoja.Cells.Item(Fila + 4, Col + 1) = filaTabla(Col)
                    End If
                Next

                BackgroundWorker.ReportProgress(pbrExportacion.Step)
            Next

            exLibro.SaveAs(Nombre)
            exLibro.Close()
            exApp.Quit()

            exHoja = Nothing
            exLibro = Nothing
            exApp = Nothing

            ExportarDataTableAExcel = True
        Catch ex As Exception
            MessageBox.Show(" ERROR : " & ex.Message, "Administrador", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ExportarDataTableAExcel = False
            exApp.Quit()
        Finally
            Tabla = Nothing
        End Try
    End Function

    Private Sub PbxSalir_Click(sender As Object, e As EventArgs) Handles pbxSalir.Click
        Me.Hide()
    End Sub

    Private Sub BackgroundWorker_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker.DoWork
        If rdbPeso.Checked Then
            Dim _DtPesajes As New DataTable
            Dim _DtFinal As New DataTable
            Dim DiasDif(0) As Integer

            _DtPesajes = e.Argument
            _DtFinal.Columns.Add("ANIMAL")

            For i As Integer = 50 To 800 Step 10
                _DtFinal.Columns.Add(i)

                BackgroundWorker.ReportProgress(pbrExportacion.Step)
            Next

            Dim _view As DataView = New DataView(_DtPesajes)
            _view.Sort = "idDetTropa"

            _DtPesajes = _view.ToTable

            Dim indice As Integer = 0
            Dim _DtTemp As New DataTable
            Dim row_a As DataRow = _DtPesajes.Rows(0)

            _DtTemp = _DtPesajes.Copy
            _DtTemp.Rows.Clear()

            For Each row As DataRow In _DtPesajes.Rows
                If row.Item("idDetTropa") <> row_a.Item("idDetTropa") Then
                    _DtFinal.Rows.Add()
                    _DtFinal.Rows(indice).Item("ANIMAL") = row_a.Item("NombreTropa") & " - " & row_a.Item("Caravana")

                    Dim _view2 As DataView = New DataView(_DtTemp)
                    _view2.Sort = "Fecha"

                    _DtTemp = _view2.ToTable

                    Dim row_a2 As DataRow = _DtTemp.Rows(0)

                    For Each row2 As DataRow In _DtTemp.Rows
                        If row2.Item("Fecha") <> row_a2.Item("Fecha") Or row2.Item("Tipo") = "Venta" Then
                            Dim Col As String = row2.Item("Peso").ToString
                            Dim Agg = True

                            If Col.Length > 2 Then
                                Col = Col.Substring(0, 2) + "0"
                            Else
                                Col = Col.Substring(0, 1) + "0"
                            End If

                            If row2.Item("Tipo") = "Venta" Then
                                'row_a2 = _DtTemp.Rows(_DtTemp.Rows.IndexOf(row_a2) - 1)
                            ElseIf _DtTemp.Rows(_DtTemp.Rows.IndexOf(row_a2) + 1).Item("Tipo") = "Venta" Then
                                Agg = False
                            End If

                            If Agg Then
                                Dim GPV As Double = (row2.Item("Peso") - row_a2.Item("Peso")) / DateDiff(DateInterval.Day, row_a2.Item("Fecha"), row2.Item("Fecha"))

                                If GPV > -0.5 And GPV < 3 Then
                                    _DtFinal.Rows(indice).Item(Col) = Math.Round(GPV, 3)
                                End If
                            End If
                        End If

                        row_a2 = row2
                    Next

                    indice += 1
                    _DtTemp.Rows.Clear()
                End If

                _DtTemp.Rows.Add(row.ItemArray)
                BackgroundWorker.ReportProgress(pbrExportacion.Step)
                row_a = row
            Next

            Dim DIA As Integer
            Dim MES As String
            Dim AÑO As Integer
            Dim H As String = Now.ToString("HHmmss")

            DIA = DateTime.Now.ToString("dd")
            MES = DateTime.Now.ToString("MMMM")
            AÑO = DateTime.Now.ToString("yyyy")

            ExportarDataTableAExcel("D:\001) DOCUMENTOS\001) PRODUCCION PROPIA\002) Feed Lot\Informes SiTraBo\SiTraBo Reporte ADPV  " & DIA & "-" & MES & "-" & AÑO & " " & H.ToString & ".xlsx", _DtFinal)

        End If
    End Sub

    Private Sub BackgroundWorker_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker.ProgressChanged
        'pbrExportacion.Value += e.ProgressPercentage
    End Sub

    Private Sub BackgroundWorker_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker.RunWorkerCompleted
        gbxExportacion.Visible = False
        gbxInformes.Visible = True
    End Sub

    Private Sub ChbFdesde_CheckedChanged(sender As Object, e As EventArgs) Handles chbFdesde.CheckedChanged
        If chbFdesde.Checked = True Then
            dtmFdesde.Enabled = True
            dtmFdesde.Select()
        Else
            dtmFdesde.Enabled = False
            dtmFdesde.Text = dtmFdesde.MinDate
        End If
    End Sub

    Private Sub ChbFhasta_CheckedChanged(sender As Object, e As EventArgs) Handles chbFhasta.CheckedChanged
        If chbFhasta.Checked = True Then
            dtmFhasta.Enabled = True
            dtmFhasta.Select()
        Else
            dtmFhasta.Enabled = False
            dtmFhasta.Text = dtmFdesde.MaxDate
        End If
    End Sub

    Private Sub FrmAnalisisDatos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim _Dt, _Dt2 As DataTable
        Dim _Ver, _Ver2 As New Mostrar
        Dim _Row, _Row2 As DataRow
        Dim UltFecha, PrimFecha As Date
        Dim x As Integer = 0

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

        gbxInformes.Visible = True
        gbxExportacion.Visible = False

        Me.Text = "Si.Tra.Bo. - Sistema de Trazabilidad Bovina" & " - USUARIO: " & frmLogin.txtNom.Text & " " & frmLogin.txtAp.Text & " -"
    End Sub

    Private Sub chbProd_CheckedChanged(sender As Object, e As EventArgs) Handles chbProd.CheckedChanged
        If chbProd.Checked = True Then
            chbTropa.Checked = False
            chbCorral.Checked = False

            cbxProductor.Enabled = True
            cbxProductor.Select()
        Else
            cbxProductor.Enabled = False
            cbxProductor.Text = ""
        End If
    End Sub

    Private Sub chbTropa_CheckedChanged(sender As Object, e As EventArgs) Handles chbTropa.CheckedChanged
        If chbTropa.Checked = True Then
            chbCorral.Checked = False
            chbProd.Checked = False

            cbxTropa.Enabled = True
            cbxTropa.Select()
        Else
            cbxTropa.Enabled = False
            cbxTropa.Text = ""
        End If
    End Sub


    Private Sub chbCorral_CheckedChanged(sender As Object, e As EventArgs) Handles chbCorral.CheckedChanged
        If chbCorral.Checked = True Then
            chbTropa.Checked = False
            chbProd.Checked = False

            cbxCorral.Enabled = True
            cbxCorral.Select()
        Else
            cbxCorral.Enabled = False
            cbxCorral.Text = ""
        End If
    End Sub

    Private Sub cbxNoEscribir_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxTropa.KeyPress, cbxCorral.KeyPress, cbxProductor.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbxTropa_TextChanged(sender As Object, e As EventArgs) Handles cbxTropa.TextChanged
        Dim _Dt As New DataTable
        Dim _Ver As New Mostrar

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
    End Sub

    Private Sub cbxProductor_TextChanged(sender As Object, e As EventArgs) Handles cbxProductor.TextChanged
        Dim _Dt As New DataTable
        Dim _Ver As New Mostrar

        If frmLogin.txtTipUs.Text = "Super Usuario" Then
            _Dt = _Ver.verProductor()
        Else
            _Dt = _Ver.verProductorUs(frmLogin.txtID.Text)
        End If

        txtIdP.Text = ""

        For Each _Dr As DataRow In _Dt.Rows
            If _Dr("RazonSocial") = cbxTropa.Text Then
                txtIdP.Text = _Dr("idProductor")
            End If
        Next
    End Sub

    Private Sub cbxCorral_TextChanged(sender As Object, e As EventArgs) Handles cbxCorral.TextChanged
        Dim _Dt As New DataTable
        Dim _Ver As New Mostrar

        If frmLogin.txtTipUs.Text = "Super Usuario" Then
            _Dt = _Ver.verCorrales()
        Else
            _Dt = _Ver.verCorralesUs(frmLogin.txtID.Text)
        End If

        txtIdCrr.Text = ""

        For Each _Dr As DataRow In _Dt.Rows
            If _Dr("NombreCorral") = cbxTropa.Text Then
                txtIdCrr.Text = _Dr("idCorrales")
            End If
        Next
    End Sub
End Class