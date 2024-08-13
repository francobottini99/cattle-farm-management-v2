Imports MySql.Data.MySqlClient

Module verPesajeDtalleTropa
    Public Function Ver(ByVal dtUs As Integer, ByVal idDtcrr As Integer) As mdlPesaje
        Dim Cmd As New MySqlCommand
        Dim PesoDT As New mdlPesaje
        Dim E As New mdlPesaje
        Dim Sdr As MySqlDataReader

        Try
            Using Conn As MySqlConnection = New MySqlConnection(Servidor)
                Cmd = New MySqlCommand("feedlot.verPesajeDtalleTropa")
                Cmd.CommandType = CommandType.StoredProcedure
                Cmd.Connection = Conn

                Cmd.Parameters.AddWithValue("@dtUs", dtUs)
                Cmd.Parameters.AddWithValue("@idDtcrr", idDtcrr)

                Conn.Open()
                Sdr = Cmd.ExecuteReader

                Sdr.Read()

                PesoDT.IdPesaje = Sdr("idPESAJE")
                PesoDT.Fecha = Sdr("Fecha")
                PesoDT.Tipo = Sdr("Tipo")
                PesoDT.Peso = Sdr("Peso")
                PesoDT.PorcDesbate = Sdr("PorcDesbaste")
                PesoDT.Desbaste = Sdr("Desbaste")
                PesoDT.PesoFinal = Sdr("PesoFinal")
                PesoDT.Observaciones = Sdr("Observaciones")
                PesoDT.IdDetTropa = Sdr("DETALLE_TROPA_idDetTropa")
                PesoDT.IdTropa = Sdr("TROPA_idTropa")
                PesoDT.IdUsuario = Sdr("USUARIOS_idUsuario")
                PesoDT.Err = "OK"

                Sdr.Close()
            End Using

            Return PesoDT
        Catch ex As Exception
            E.Err = ex.Message.ToString
            Return E
        End Try
    End Function
End Module
