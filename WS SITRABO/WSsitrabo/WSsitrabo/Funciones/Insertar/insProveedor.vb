Imports MySql.Data.MySqlClient

Module insProveedor
    Public Function Insertar(ByVal Dts As mdlProveedor) As String
        Dim Cmd As New MySqlCommand
        Try
            Using Conn As MySqlConnection = New MySqlConnection(Servidor)
                Cmd = New MySqlCommand("feedlot.insProveedor")
                Cmd.CommandType = CommandType.StoredProcedure
                Cmd.Connection = Conn

                Cmd.Parameters.AddWithValue("@pNom", Dts.RazonSocial)
                Cmd.Parameters.AddWithValue("@pDir", Dts.Direccion)
                Cmd.Parameters.AddWithValue("@pLoc", Dts.Localidad)
                Cmd.Parameters.AddWithValue("@pProv", Dts.Provincia)
                Cmd.Parameters.AddWithValue("@pCP", Dts.CodPostal)
                Cmd.Parameters.AddWithValue("@pCuit", Dts.CUIT)
                Cmd.Parameters.AddWithValue("@pTe", Dts.Telefono)
                Cmd.Parameters.AddWithValue("@pMail", Dts.eMail)
                Cmd.Parameters.AddWithValue("@pIDUs", Dts.IdUsuario)

                Conn.Open()
                Cmd.ExecuteNonQuery()
            End Using

            Return "Registro insertado"
        Catch ex As Exception
            Return ex.Message.ToString
        End Try
    End Function
End Module
