Public Class Stock
    Public Function ManejoStk(ByVal Fecha As Date)
        Dim _Dt, _Dt2, _Dt3, _DtF As New DataTable
        Dim _Ver, _Ver2, _Ver3, _VerF As New Mostrar
        Dim G As New GrabaDatos
        Dim BorrarStk As Boolean = False

        _DtF = _VerF.verStkDia(Format(Fecha, "yyyy/MM/dd"), frmLogin.txtID.Text)

        If _DtF.Rows.Count < 1 Then
            BorrarStk = False
        Else
            BorrarStk = True
        End If

        If BorrarStk = True Then
            G.Grabar("Stock", "NoImagen", "feedlot.modBorrarStock", Format(Fecha, "yyyy/MM/dd"), frmLogin.txtID.Text)
        End If

        _Dt = _Ver.verStocCorralesUs(frmLogin.txtID.Text, "Engorde")

        For Each _Dr As DataRow In _Dt.Rows
            G.Grabar("Stock", "NoImagen", "feedlot.insStock", Format(Fecha, "yyyy/MM/dd"), _Dr("Caravana"), _
                  _Dr("Descripcion"), 1, _Dr("TROPA_idTropa"), _Dr("idDetTropa"), _Dr("CORRALES_idCorrales"), _Dr("CATEGORIAS_idCategorias"), CInt(frmLogin.txtID.Text))
        Next

        _Dt2 = _Ver2.verCorralesUs(frmLogin.txtID.Text)

        For i As Integer = 0 To _Dt2.Rows.Count - 1
            _Dt3 = _Ver3.verStocDiariokUs(_Dt2.Rows(i).Item("idCorrales"), frmLogin.txtID.Text, "Engorde")

            G.Grabar("Corrales", "NoImagen", "feedlot.modCorral", _Dt2.Rows(i).Item("idCorrales"), _Dt3.Rows.Count)
        Next

        Return Nothing
    End Function
End Class
