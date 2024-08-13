Imports MySql.Data.MySqlClient

Module insIngreso
    Public Function Insertar(ByVal Dts As mdlCompras) As String
        Dim Cmd As New MySqlCommand
        Try
            Using Conn As MySqlConnection = New MySqlConnection(Servidor)
                Cmd = New MySqlCommand("feedlot.insIngreso")
                Cmd.CommandType = CommandType.StoredProcedure
                Cmd.Connection = Conn

                Cmd.Parameters.AddWithValue("@cFecha", Dts.Fecha)
                Cmd.Parameters.AddWithValue("@cCostSinIvaKg", Dts.CostoSinIvaKg)
                Cmd.Parameters.AddWithValue("@cCostSinIvaCab", Dts.CostoSinIvaCabeza)
                Cmd.Parameters.AddWithValue("@cAlicuotaIVA", Dts.AlicuotaIVA)
                Cmd.Parameters.AddWithValue("@cCostConIvaKg", Dts.CostoConIvaKg)
                Cmd.Parameters.AddWithValue("@cCostConIvaCab", Dts.CostoConIvaCabeza)
                Cmd.Parameters.AddWithValue("@cCostConIvaFlete", Dts.CostoConIvaFlete)
                Cmd.Parameters.AddWithValue("@cOtrosCostos", Dts.OtrosCostos)
                Cmd.Parameters.AddWithValue("@cCostFinalKg", Dts.CostoFinalKg)
                Cmd.Parameters.AddWithValue("@cCostFinalCab", Dts.CostoFinalCabeza)
                Cmd.Parameters.AddWithValue("@cCostTotalTropa", Dts.CostoTotalTropa)
                Cmd.Parameters.AddWithValue("@cFormaPago", Dts.FormaPago)
                Cmd.Parameters.AddWithValue("@cIdTropa", Dts.IdTropa)
                Cmd.Parameters.AddWithValue("@cIdProv", Dts.IdProveedor)
                Cmd.Parameters.AddWithValue("@cIdProd", Dts.IdProductor)
                Cmd.Parameters.AddWithValue("@cIdUS", Dts.IdUsuario)

                Conn.Open()
                Cmd.ExecuteNonQuery()
            End Using

            Return "Registro insertado"
        Catch ex As Exception
            Return ex.Message.ToString
        End Try
    End Function
End Module
