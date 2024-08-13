Imports MySql.Data.MySqlClient

Module verCampos
    Public Function Ver() As List(Of mdlCampo)
        Dim Cmd As New MySqlCommand
        Dim Lista As New List(Of mdlCampo)
        Dim E As New mdlCampo
        Dim Sdr As MySqlDataReader

        Try
            Using Conn As MySqlConnection = New MySqlConnection(Servidor)
                Cmd = New MySqlCommand("feedlot.verProveedor")
                Cmd.CommandType = CommandType.StoredProcedure
                Cmd.Connection = Conn

                Conn.Open()
                Sdr = Cmd.ExecuteReader

                Lista.Clear()
                While Sdr.Read
                    Lista.Add(New mdlCampo(
                        Sdr("idCampo"),
                        Sdr("NombreCampo"),
                        Sdr("Propietario"),
                        Sdr("Localidad"),
                        Sdr("Provincia"),
                        Sdr("Superficie"),
                        Sdr("CUSUARIOS_idUsuarioUIT"),
                        "OK"))
                End While

                If Lista.Count = 0 Then
                    E.Err = "No hay Campos cargados, ingrese Campos para poder Operar !"
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
