Imports System.Net
Imports System.Web.Http

Namespace Controllers
    Public Class MovimientosTropaController
        Inherits ApiController

        <HttpGet>
        <Route("MovimientosTropa/movInterno/{IdDT}/{Crr}")>
        Public Function grabarCorral(ByVal IdDT As Integer, ByVal Crr As Integer) As String

            Dim Corr As New mdlCorrales

            Try
                'Corr.Nombre = nC
                'Corr.Superficie = Sup
                'Corr.Cabezas = Cab
                'Corr.IdCampo = idCam
                'Corr.IdUsuario = idUs

                Dim Resp As String = insCorrales.Insertar(Corr)

                If Resp = "Registro insertado" Then
                    Return "Corral Ingresado !"
                Else
                    Return "Error al guardar Corral"
                End If
            Catch ex As Exception
                Return ex.Message.ToString
            End Try
        End Function









        'If txtOrigen.Text = "MovInterno" Then
        'For i As Integer = 0 To dgvDetCrrIng.Rows.Count - 1
        '                        G.Grabar("detalle_tropa", "NoImagen", "feedlot.modDetalleTropaCorral", CInt(dgvDetCrrIng.Rows(i).Cells.Item(0).Value), CInt(dgvDetCrrIng.Rows(i).Cells.Item(8).Value))

        '                        G.Grabar("tropa_bloqueo_mod", "NoImagen", "feedlot.modEstadoMod", "NO", dgvDetCrrIng.Rows(i).Cells.Item(9).Value)

        '                        If i = dgvDetCrrIng.Rows.Count - 1 Then
        '                            _Stk.ManejoStk(dgvDetCrrIng.Rows(i).Cells.Item(10).Value)
        '                        End If
        'Next
        'ElseIf txtOrigen.Text = "Egreso" Then
        'If rdbVenta.Checked = True Then
        'For i As Integer = 0 To dgvDetEgr.Rows.Count - 1
        '                            _Dt5 = _Ver5.verPesajeVenta(CInt(dgvDetEgr.Rows(i).Cells.Item(0).Value))

        '                            If _Dt5.Rows.Count > 0 Then
        '                                G.Grabar("detalle_tropa", "NoImagen", "feedlot.modDetalleTropaVendido", CInt(dgvDetEgr.Rows(i).Cells.Item(0).Value))

        '                                G.Grabar("tropa_bloqueo_mod", "NoImagen", "feedlot.modEstadoMod", "NO", dgvDetEgr.Rows(i).Cells.Item(6).Value)

        '                                _Dt4 = _Ver4.consProductorDetalleTropa(CInt(dgvDetEgr.Rows(i).Cells.Item(0).Value))

        '                                G.Grabar("Ventas", "NoImagen", "feedlot.insEgreso", Format(CDate(dgvDetEgr.Rows(i).Cells.Item(7).Value), "yyyy/MM/dd"), "-", 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, _
        '                                         CInt(_Dt4.Rows(0).Item(0)), CInt(dgvDetEgr.Rows(i).Cells.Item(0).Value), CInt(frmLogin.txtID.Text), _Dt5.Rows(0).Item(0))

        '                                G.Grabar("tropa", "NoImagen", "feedlot.modTropaVta", dgvDetEgr.Rows(i).Cells.Item(6).Value, 1)
        '                            Else
        '                                MsgBox("No se encontro el peso de venta de uno de los animales por lo tanto se omitio el egreso del mismo... !", vbExclamation, "Servico de Alertas")
        '                            End If

        'If i = dgvDetEgr.Rows.Count - 1 Then
        '                                _Stk.ManejoStk(dgvDetEgr.Rows(i).Cells.Item(7).Value)
        '                            End If
        'Next
        'Else
        'For i As Integer = 0 To dgvDetEgr.Rows.Count - 1
        '                            G.Grabar("detalle_tropa", "NoImagen", "feedlot.modDetalleTropaMuerto", CInt(dgvDetEgr.Rows(i).Cells.Item(0).Value))

        '                            G.Grabar("tropa_bloqueo_mod", "NoImagen", "feedlot.modEstadoMod", "NO", dgvDetEgr.Rows(i).Cells.Item(6).Value)

        '                            G.Grabar("muertes", "NoImagen", "feedlot.insMuerte", Format(CDate(dgvDetEgr.Rows(i).Cells.Item(7).Value), "yyyy/MM/dd"), CInt(dgvDetEgr.Rows(i).Cells.Item(0).Value), CInt(frmLogin.txtID.Text))

        '                            G.Grabar("tropa", "NoImagen", "feedlot.modTropaMuerte", dgvDetEgr.Rows(i).Cells.Item(6).Value, 1)

        '                            If dgvDetEgr.Rows.Count - 1 Then
        '                                _Stk.ManejoStk(dgvDetEgr.Rows(i).Cells.Item(7).Value)
        '                            End If
        'Next
        'End If
        'Else
        'For i As Integer = 0 To dgvDetEgr.Rows.Count - 1
        '                        G.Grabar("detalle_tropa", "NoImagen", "feedlot.modDetalleTropaEngorde", CInt(dgvDetEgr.Rows(i).Cells.Item(0).Value))

        '                        G.Grabar("tropa_bloqueo_mod", "NoImagen", "feedlot.modEstadoMod", "NO", dgvDetEgr.Rows(i).Cells.Item(6).Value)

        '                        If rdbVenta.Checked = True Then
        '                            G.Grabar("ventas", "NoImagen", "feedlot.modBorrarEgreso", CInt(dgvDetEgr.Rows(i).Cells.Item(0).Value))
        '                        ElseIf rdbMuerte.Checked = True Then
        '                            G.Grabar("muertes", "NoImagen", "feedlot.modBorrarMuerte", CInt(dgvDetEgr.Rows(i).Cells.Item(0).Value))
        '                        End If

        'If dgvDetEgr.Rows.Count - 1 Then
        '                            _Stk.ManejoStk(dgvDetEgr.Rows(i).Cells.Item(7).Value)
        '                        End If
        'Next
        'End If





    End Class
End Namespace