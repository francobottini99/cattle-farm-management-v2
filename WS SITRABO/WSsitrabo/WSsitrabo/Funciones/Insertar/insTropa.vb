Imports MySql.Data.MySqlClient

Module insTropa
    Public Function Insertar(ByVal Dts As mdlTropa) As String
        Dim Cmd As New MySqlCommand
        Try
            Using Conn As MySqlConnection = New MySqlConnection(Servidor)
                Cmd = New MySqlCommand("feedlot.insTropa")
                Cmd.CommandType = CommandType.StoredProcedure
                Cmd.Connection = Conn

                Cmd.Parameters.AddWithValue("@tNom", Dts.NombreTropa)
                Cmd.Parameters.AddWithValue("@tProc", Dts.Origen)
                Cmd.Parameters.AddWithValue("@tFec", Dts.Fecha)
                Cmd.Parameters.AddWithValue("@tCab", Dts.Cabezas)
                Cmd.Parameters.AddWithValue("@tMu", Dts.Muertes)
                Cmd.Parameters.AddWithValue("@tVta", Dts.Ventas)
                Cmd.Parameters.AddWithValue("@tStkt", Dts.Stock)
                Cmd.Parameters.AddWithValue("@tKgCab", Dts.PesoIngreso)
                Cmd.Parameters.AddWithValue("@tKgt", Dts.KgTropa)
                Cmd.Parameters.AddWithValue("@tObsv", Dts.Observaciones)
                Cmd.Parameters.AddWithValue("@tIdpd", Dts.IdProductor)
                Cmd.Parameters.AddWithValue("@tIdCam", Dts.idCampo)
                Cmd.Parameters.AddWithValue("@tIdpv", Dts.IdProveedor)
                Cmd.Parameters.AddWithValue("@tIdus", Dts.IdUsuario)

                Conn.Open()
                Cmd.ExecuteNonQuery()
            End Using

            Return "Registro insertado"
        Catch ex As Exception
            Return ex.Message.ToString
        End Try
    End Function
End Module
