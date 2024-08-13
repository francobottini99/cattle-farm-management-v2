Imports MySql.Data.MySqlClient

Module verProveedorUs
    Public Function Ver(ByVal idUs As Integer) As List(Of mdlProveedor)
        Dim Cmd As New MySqlCommand
        Dim Lista As New List(Of mdlProveedor)
        Dim E As New mdlProveedor
        Dim Sdr As MySqlDataReader

        Try
            Using Conn As MySqlConnection = New MySqlConnection(Servidor)
                Cmd = New MySqlCommand("feedlot.verProveedorUs")
                Cmd.CommandType = CommandType.StoredProcedure
                Cmd.Connection = Conn

                Cmd.Parameters.AddWithValue("@pUs", idUs)

                Conn.Open()
                Sdr = Cmd.ExecuteReader

                Lista.Clear()
                While Sdr.Read
                    Lista.Add(New mdlProveedor(
                        Sdr("idProveedor"),
                        Sdr("RazonSocial"),
                        Sdr("Direccion"),
                        Sdr("Localidad"),
                        Sdr("Provincia"),
                        Sdr("CP"),
                        Sdr("CUIT"),
                        Sdr("TE"),
                        Sdr("Mail"),
                        Sdr("USUARIOS_idUsuario"),
                        "OK"))
                End While

                If Lista.Count = 0 Then
                    E.Err = "No hay Proveedores cargados, ingrese Proveedor para poder Operar !"
                    Lista.Insert(0, E)
                Else
                    Return Lista
                End If

                Sdr.Close()
            End Using

            Return Lista
        Catch ex As Exception
            E.Err = "Error: " & ex.Message.ToString
            Lista.Insert(0, E)
            Return Lista
        End Try
    End Function
End Module
