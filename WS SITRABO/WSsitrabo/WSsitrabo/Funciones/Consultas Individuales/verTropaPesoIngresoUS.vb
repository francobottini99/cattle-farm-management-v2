Imports MySql.Data.MySqlClient

Module verTropaPesoIngresoUS
    Public Function Ver(ByVal dtUs As Integer, ByVal idT As Integer) As mdlTropa
        Dim Cmd As New MySqlCommand
        Dim PesoT As New mdlTropa
        Dim E As New mdlTropa
        Dim Sdr As MySqlDataReader

        Try
            Using Conn As MySqlConnection = New MySqlConnection(Servidor)
                Cmd = New MySqlCommand("feedlot.verTropaPesoIngresoUS")
                Cmd.CommandType = CommandType.StoredProcedure
                Cmd.Connection = Conn

                Cmd.Parameters.AddWithValue("@dtUs", dtUs)
                Cmd.Parameters.AddWithValue("@idT", idT)

                Conn.Open()
                Sdr = Cmd.ExecuteReader

                Sdr.Read()

                PesoT.IdTropa = Sdr("idTropa")
                PesoT.NombreTropa = Sdr("NombreTropa")
                PesoT.Origen = Sdr("OrigenProcedencia")
                PesoT.Fecha = Sdr("FechaIngreso")
                PesoT.Cabezas = Sdr("Cabezas")
                PesoT.Muertes = Sdr("Muertes")
                PesoT.Ventas = Sdr("Ventas")
                PesoT.Stock = Sdr("Stock")
                PesoT.PesoIngreso = Sdr("PesoIngreso")
                PesoT.KgTropa = Sdr("TotalKgTropa")
                PesoT.Observaciones = Sdr("Observaciones")
                PesoT.IdProductor = Sdr("PRODUCTOR_idProductor")
                PesoT.idCampo = Sdr("CAMPO_idCampo")
                PesoT.IdProveedor = Sdr("PROVEEDOR_idProveedor")
                PesoT.IdUsuario = Sdr("USUARIOS_idUsuario")
                PesoT.Err = "OK"

                Sdr.Close()
            End Using

            Return PesoT
        Catch ex As Exception
            E.Err = ex.Message.ToString
            Return E
        End Try
    End Function

End Module
