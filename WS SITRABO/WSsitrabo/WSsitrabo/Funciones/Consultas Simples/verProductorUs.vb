Imports MySql.Data.MySqlClient

Module verProductorUs
    Public Function Ver(ByVal idUs As Integer) As List(Of mdlProductor)
        Dim Cmd As New MySqlCommand
        Dim Lista As New List(Of mdlProductor)
        Dim E As New mdlProductor
        Dim Sdr As MySqlDataReader

        Try
            Using Conn As MySqlConnection = New MySqlConnection(Servidor)
                Cmd = New MySqlCommand("feedlot.verProductorUs")
                Cmd.CommandType = CommandType.StoredProcedure
                Cmd.Connection = Conn

                Cmd.Parameters.AddWithValue("@pUs", idUs)

                Conn.Open()
                Sdr = Cmd.ExecuteReader

                Lista.Clear()
                While Sdr.Read
                    Lista.Add(New mdlProductor(
                        Sdr("idProductor"),
                        Sdr("RazonSocial"),
                        Sdr("Direccion"),
                        Sdr("Localidad"),
                        Sdr("CP"),
                        Sdr("CUIT"),
                        Sdr("USUARIOS_idUsuario"),
                        "OK"))
                End While

                If Lista.Count = 0 Then
                    E.Err = "No hay Productores cargados, ingrese Productor para poder Operar !"
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
