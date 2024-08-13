Imports MySql.Data.MySqlClient

Module verRacionUsId
    Public Function Ver(ByVal uSiD As Integer, ByVal idR As Integer) As mdlRaciones
        Dim Cmd As New MySqlCommand
        Dim Racion As New mdlRaciones
        Dim Sdr As MySqlDataReader

        Try
            Using Conn As MySqlConnection = New MySqlConnection(Servidor)
                Cmd = New MySqlCommand("feedlot.verRacionUsId")
                Cmd.CommandType = CommandType.StoredProcedure
                Cmd.Connection = Conn

                Cmd.Parameters.AddWithValue("@uID", uSiD)
                Cmd.Parameters.AddWithValue("@idR", idR)

                Conn.Open()
                Sdr = Cmd.ExecuteReader

                If Sdr.Read() = Nothing Then
                    Racion.Err = "No hay Raciones cargadas, ingrese raciones para poder Operar !"
                Else
                    Racion.IdRacion = Sdr("idRaciones")
                    Racion.Nombre = Sdr("NombreRacion")
                    Racion.Grano = Sdr("Grano")
                    Racion.Concentrado = Sdr("Concentrado")
                    Racion.Fibra = Sdr("Fibra")
                    Racion.Otros = Sdr("Otros")
                    Racion.CostoGrano = Sdr("CostoGrano")
                    Racion.CostoConc = Sdr("CostoConcentrado")
                    Racion.CostoFibra = Sdr("CostoFibra")
                    Racion.CostoOtros = Sdr("CostoOtros")
                    Racion.IdUsuario = Sdr("USUARIOS_idUsuario")
                    Racion.Err = "OK"
                End If

                Sdr.Close()
            End Using

            Return Racion
        Catch ex As Exception
            Racion.Err = ex.Message.ToString
            Return Racion
        End Try
    End Function
End Module
