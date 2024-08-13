Imports MySql.Data.MySqlClient

Module insCorrales
    Public Function Insertar(ByVal Dts As mdlCorrales) As String
        Dim Cmd As New MySqlCommand
        Try
            Using Conn As MySqlConnection = New MySqlConnection(Servidor)
                Cmd = New MySqlCommand("feedlot.insCorrales")
                Cmd.CommandType = CommandType.StoredProcedure
                Cmd.Connection = Conn

                Cmd.Parameters.AddWithValue("@cNom", Dts.Nombre)
                Cmd.Parameters.AddWithValue("@cSup", Dts.Superficie)
                Cmd.Parameters.AddWithValue("@cCab", Dts.Cabezas)
                Cmd.Parameters.AddWithValue("@cIdCam", Dts.IdCampo)
                Cmd.Parameters.AddWithValue("@cIDu", Dts.IdUsuario)

                Conn.Open()
                Cmd.ExecuteNonQuery()
            End Using

            Return "Registro insertado"
        Catch ex As Exception
            Return ex.Message.ToString
        End Try
    End Function
End Module
