Public Class frmListaAlimentos
    Private Sub FrmListaAlimentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim _Dt As DataTable
        Dim _Ver As New Mostrar

        _Dt = _Ver.verTablaAlimentos()
        dgvAlimentos.DataSource = _Dt

        'CONFIGURACION DE TABLA -----------------------------------------------------------------------------------------

        dgvAlimentos.Columns("idAlimentos").Visible = False

        dgvAlimentos.Columns("Tipo").HeaderText = "TIPO"
        dgvAlimentos.Columns("NombreComun").HeaderText = "NOMBRE COMÚN"
        dgvAlimentos.Columns("Fenologia").HeaderText = "EST. FENOLÓGICO"
        dgvAlimentos.Columns("%MateriaSeca").HeaderText = "% M.S."
        dgvAlimentos.Columns("%Digestibilidad").HeaderText = "% DIGESTIB"
        dgvAlimentos.Columns("EnergiaMetabolica").HeaderText = "E.M. (Mcal/Kg)"
        dgvAlimentos.Columns("%ProteinaBruta").HeaderText = "% P.B."
        dgvAlimentos.Columns("%Calcio").HeaderText = "% CALCIO"
        dgvAlimentos.Columns("%Fosforo").HeaderText = "% FOSFORO"
        dgvAlimentos.Columns("%Magnesio").HeaderText = "% MAGNECIO"
        dgvAlimentos.Columns("FND").HeaderText = "% F.D.N."
        dgvAlimentos.Columns("FDA").HeaderText = "% F.D.A."
        dgvAlimentos.Columns("LDA").HeaderText = "% L.D.A."
        dgvAlimentos.Columns("Costo").HeaderText = "COSTO ($)"

        dgvAlimentos.Columns(1).DisplayIndex = 0
        dgvAlimentos.Columns(2).DisplayIndex = 1
        dgvAlimentos.Columns(3).DisplayIndex = 2
        dgvAlimentos.Columns(4).DisplayIndex = 3
        dgvAlimentos.Columns(5).DisplayIndex = 4
        dgvAlimentos.Columns(6).DisplayIndex = 5
        dgvAlimentos.Columns(7).DisplayIndex = 6
        dgvAlimentos.Columns(8).DisplayIndex = 7
        dgvAlimentos.Columns(9).DisplayIndex = 8
        dgvAlimentos.Columns(10).DisplayIndex = 9
        dgvAlimentos.Columns(11).DisplayIndex = 10
        dgvAlimentos.Columns(12).DisplayIndex = 11
        dgvAlimentos.Columns(13).DisplayIndex = 12
        dgvAlimentos.Columns(14).DisplayIndex = 13

        dgvAlimentos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        dgvAlimentos.Columns("Tipo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
        dgvAlimentos.Columns("NombreComun").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvAlimentos.Columns("Fenologia").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvAlimentos.Columns("%MateriaSeca").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        dgvAlimentos.Columns("%Digestibilidad").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        dgvAlimentos.Columns("EnergiaMetabolica").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        dgvAlimentos.Columns("%ProteinaBruta").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        dgvAlimentos.Columns("%Calcio").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        dgvAlimentos.Columns("%Fosforo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        dgvAlimentos.Columns("%Magnesio").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        dgvAlimentos.Columns("FND").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        dgvAlimentos.Columns("FDA").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        dgvAlimentos.Columns("LDA").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        dgvAlimentos.Columns("Costo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight

        dgvAlimentos.Columns("%MateriaSeca").DefaultCellStyle.Format = "#,##0.00"
        dgvAlimentos.Columns("%Digestibilidad").DefaultCellStyle.Format = "#,##0.00"
        dgvAlimentos.Columns("EnergiaMetabolica").DefaultCellStyle.Format = "#,##0.00"
        dgvAlimentos.Columns("%ProteinaBruta").DefaultCellStyle.Format = "#,##0.00"
        dgvAlimentos.Columns("%Calcio").DefaultCellStyle.Format = "#,##0.00"
        dgvAlimentos.Columns("%Fosforo").DefaultCellStyle.Format = "#,##0.00"
        dgvAlimentos.Columns("%Magnesio").DefaultCellStyle.Format = "#,##0.00"
        dgvAlimentos.Columns("FND").DefaultCellStyle.Format = "#,##0.00"
        dgvAlimentos.Columns("FDA").DefaultCellStyle.Format = "#,##0.00"
        dgvAlimentos.Columns("LDA").DefaultCellStyle.Format = "#,##0.00"
        dgvAlimentos.Columns("Costo").DefaultCellStyle.Format = "$ #,##0.00"

        '---------------------------------------------------------------------------------------------------------------------------------------------

        Tmr.Enabled = True

    End Sub

    Private Sub BtnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        If dgvAlimentos.CurrentCell IsNot Nothing Then
            Dim _Dgv As New DataGridView
            Dim _Dt As DataTable

            If frmRaciones.dgvRacion.DataSource IsNot Nothing Then
                _Dt = frmRaciones.dgvRacion.DataSource

                Dim i As Integer = _Dt.Rows.Count - 1

                For Each Row As DataGridViewRow In dgvAlimentos.SelectedRows
                    Dim Agg = True

                    For Each _Row As DataRow In _Dt.Rows
                        If _Row.Item("idAlimentos") = Row.Cells("idAlimentos").Value Then
                            Agg = False
                        End If
                    Next

                    If Agg Then
                        Dim j As Integer = 0
                        _Dt.Rows.Add()

                        For Each Cel As DataGridViewCell In Row.Cells
                            If IsNumeric(Cel.Value) Then
                                _Dt.Rows(i + 1).Item(j) = Format(Cel.Value, "#,##0.00")
                            Else
                                _Dt.Rows(i + 1).Item(j) = Cel.Value
                            End If

                            j += 1

                        Next
                    End If

                    i += 1
                Next

                frmRaciones.dgvRacion.DataSource = _Dt
            Else
                Dim btnElim As DataGridViewButtonColumn = New DataGridViewButtonColumn

                _Dgv.ColumnCount = dgvAlimentos.ColumnCount

                For k As Integer = 0 To dgvAlimentos.ColumnCount - 1
                    _Dgv.Columns(k).Name = dgvAlimentos.Columns(k).Name
                Next

                Dim i As Integer = 0

                For Each Row As DataGridViewRow In dgvAlimentos.SelectedRows
                    Dim j As Integer = 0
                    _Dgv.Rows.Add()

                    For Each Cel As DataGridViewCell In Row.Cells
                        If IsNumeric(Cel.Value) Then
                            _Dgv.Rows(i).Cells(j).Value = Format(Cel.Value, "#,##0.00")
                        Else
                            _Dgv.Rows(i).Cells(j).Value = Cel.Value
                        End If

                        j += 1

                    Next

                    i += 1
                Next

                _Dt = DataGridViewToDataTable(_Dgv)

                _Dt.Rows.RemoveAt(_Dt.Rows.Count - 1)

                frmRaciones.dgvRacion.DataSource = _Dt

                btnElim.Name = "btnElim"
                btnElim.HeaderText = "ELIMINAR"
                btnElim.Text = "X"
                btnElim.UseColumnTextForButtonValue = True

                frmRaciones.dgvRacion.Columns.Insert(0, btnElim)

                frmRaciones.dgvRacion.ColumnHeadersVisible = True
            End If

            Me.Close()
        Else
            MsgBox("No seleccionaste ningun alimento", vbExclamation, "Servico de Alertas")
        End If
    End Sub

    Private Function DataGridViewToDataTable(dgv As DataGridView) As DataTable
        If (dgv Is Nothing) Then Return Nothing

        Dim dt As New DataTable

        For Each col As DataGridViewColumn In dgv.Columns
            Dim column As New DataColumn(col.Name, Type.GetType("System.String"))
            dt.Columns.Add(column)
        Next

        For Each viewRow As DataGridViewRow In dgv.Rows
            Dim row As DataRow = dt.NewRow()

            For Each col As DataGridViewColumn In dgv.Columns
                Dim value As Object = viewRow.Cells(col.Name).Value

                row.Item(col.Name) = If(value Is Nothing, DBNull.Value, value)
            Next

            dt.Rows.Add(row)
        Next

        Return dt
    End Function

    Private Sub Tmr_Tick(sender As Object, e As EventArgs) Handles Tmr.Tick
        Tmr.Enabled = False
        dgvAlimentos.CurrentCell = Nothing
    End Sub
End Class