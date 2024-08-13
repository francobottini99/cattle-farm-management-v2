Imports MySql.Data.MySqlClient

Module insSanidad
    Public Function Insertar(ByVal Dts As mdlSanidad) As String
        Dim Cmd As New MySqlCommand
        Try
            Using Conn As MySqlConnection = New MySqlConnection(Servidor)
                Cmd = New MySqlCommand("feedlot.insSanidad")
                Cmd.CommandType = CommandType.StoredProcedure
                Cmd.Connection = Conn

                Cmd.Parameters.AddWithValue("@sFec", Dts.Fecha)
                Cmd.Parameters.AddWithValue("@sTrat", Dts.Tratamiento)
                Cmd.Parameters.AddWithValue("@sImp", Dts.Importe)
                Cmd.Parameters.AddWithValue("@sObs", Dts.Observaciones)
                Cmd.Parameters.AddWithValue("@sidDT", Dts.IdDetalleTropa)
                Cmd.Parameters.AddWithValue("@sIdU", Dts.IdUsuario)

                Conn.Open()
                Cmd.ExecuteNonQuery()
            End Using

            Return "Registro insertado"
        Catch ex As Exception
            Return ex.Message.ToString
        End Try
    End Function
End Module
