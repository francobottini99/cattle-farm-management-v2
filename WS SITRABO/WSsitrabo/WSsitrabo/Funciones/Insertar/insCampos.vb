Imports MySql.Data.MySqlClient

Module insCampos
    Public Function Insertar(ByVal Dts As mdlCampo) As String
        Dim Cmd As New MySqlCommand
        Try
            Using Conn As MySqlConnection = New MySqlConnection(Servidor)
                Cmd = New MySqlCommand("feedlot.insCampos")
                Cmd.CommandType = CommandType.StoredProcedure
                Cmd.Connection = Conn

                Cmd.Parameters.AddWithValue("@pNom", Dts.Nombre)
                Cmd.Parameters.AddWithValue("@pProp", Dts.Propietario)
                Cmd.Parameters.AddWithValue("@pLoc", Dts.Localidad)
                Cmd.Parameters.AddWithValue("@pProv", Dts.Provincia)
                Cmd.Parameters.AddWithValue("@pSup", Dts.Superficie)
                Cmd.Parameters.AddWithValue("@pIDu", Dts.IdUsuario)

                Conn.Open()
                Cmd.ExecuteNonQuery()
            End Using

            Return "Registro insertado"
        Catch ex As Exception
            Return ex.Message.ToString
        End Try
    End Function
End Module
