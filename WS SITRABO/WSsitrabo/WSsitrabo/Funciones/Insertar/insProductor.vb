Imports MySql.Data.MySqlClient

Module insProductor
    Public Function Insertar(ByVal Dts As mdlProductor) As String
        Dim Cmd As New MySqlCommand
        Try
            Using Conn As MySqlConnection = New MySqlConnection(Servidor)
                Cmd = New MySqlCommand("feedlot.insProductor")
                Cmd.CommandType = CommandType.StoredProcedure
                Cmd.Connection = Conn

                Cmd.Parameters.AddWithValue("@pNom", Dts.RazonSocial)
                Cmd.Parameters.AddWithValue("@pDir", Dts.Direccion)
                Cmd.Parameters.AddWithValue("@pLoc", Dts.Localidad)
                Cmd.Parameters.AddWithValue("@pCP", Dts.CodPostal)
                Cmd.Parameters.AddWithValue("@pCuit", Dts.CUIT)
                Cmd.Parameters.AddWithValue("@pUs", Dts.IdUsuario)

                Conn.Open()
                Cmd.ExecuteNonQuery()
            End Using

            Return "Registro insertado"
        Catch ex As Exception
            Return ex.Message.ToString
        End Try
    End Function
End Module
