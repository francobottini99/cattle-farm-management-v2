Imports MySql.Data.MySqlClient

Module verRFIDrepetidos
    Public Function Ver(ByVal Rfid As String) As mdlDetalleTropa
        Dim Cmd As New MySqlCommand
        Dim DetT As New mdlDetalleTropa
        Dim Sdr As MySqlDataReader

        Try
            Using Conn As MySqlConnection = New MySqlConnection(Servidor)
                Cmd = New MySqlCommand("feedlot.verRFIDrepetidos")
                Cmd.CommandType = CommandType.StoredProcedure
                Cmd.Connection = Conn

                Cmd.Parameters.AddWithValue("@Rfid", Rfid)

                Conn.Open()
                Sdr = Cmd.ExecuteReader
                Sdr.Read()

                DetT.IdDetalleTropa = Sdr("idDetTropa")
                DetT.Caravana = Sdr("Caravana")
                DetT.Descripcion = Sdr("Descripcion")
                DetT.Estado = Sdr("Estado")
                DetT.IdTropa = Sdr("TROPA_idTropa")
                DetT.IdCategoria = Sdr("CATEGORIAS_idCategorias")
                DetT.IdCorrales = Sdr("CORRALES_idCorrales")
                DetT.IdUsuario = Sdr("USUARIOS_idUsuario")
                DetT.CaravanaRFID = Sdr("CaravanaRFID")
                DetT.Err = "OK"

                Sdr.Close()
            End Using

            Return DetT
        Catch ex As Exception
            DetT.Err = "Error: " & ex.Message.ToString
            Return DetT
        End Try
    End Function
End Module
