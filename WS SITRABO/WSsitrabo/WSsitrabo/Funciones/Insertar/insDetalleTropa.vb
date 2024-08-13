Imports MySql.Data.MySqlClient

Module insDetalleTropa
    Public Function Insertar(ByVal Dts As mdlDetalleTropa) As String
        Dim Cmd As New MySqlCommand
        Try
            Using Conn As MySqlConnection = New MySqlConnection(Servidor)
                Cmd = New MySqlCommand("feedlot.insDetalleTropa")
                Cmd.CommandType = CommandType.StoredProcedure
                Cmd.Connection = Conn

                Cmd.Parameters.AddWithValue("@dtCarv", Dts.Caravana)
                Cmd.Parameters.AddWithValue("@dtDescp", Dts.Descripcion)
                Cmd.Parameters.AddWithValue("@dtEstado", Dts.Estado)
                Cmd.Parameters.AddWithValue("@dtIDTropa", Dts.IdTropa)
                Cmd.Parameters.AddWithValue("@dtIDCatg", Dts.IdCategoria)
                Cmd.Parameters.AddWithValue("@dtIDCorrales", Dts.IdCorrales)
                Cmd.Parameters.AddWithValue("@dtIDus", Dts.IdUsuario)
                Cmd.Parameters.AddWithValue("@dtRF", Dts.CaravanaRFID)

                Conn.Open()
                Cmd.ExecuteNonQuery()
            End Using

            Return "Registro insertado"
        Catch ex As Exception
            Return ex.Message.ToString
        End Try
    End Function
End Module
