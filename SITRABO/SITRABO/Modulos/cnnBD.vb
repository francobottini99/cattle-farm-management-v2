Imports MySql.Data.MySqlClient

Module cnnBD
    Public _cX As New MySqlConnection

    Public Sub BDcnn()
        Try
            Dim caDena As String
            If frmLogin.rbtServidor.Checked = True Then
                caDena = My.Computer.FileSystem.ReadAllText(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\FeedLot_Conn_Servidor.txt")
            Else
                caDena = My.Computer.FileSystem.ReadAllText(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\FeedLot_Conn_Local.txt")
            End If
            _cX = New MySqlConnection(caDena)
            _cX.Open()
        Catch ex As MySqlException
            MsgBox("Error de Conexión!" & vbCrLf & vbCrLf & ex.ToString, vbCritical, "Servicio de Alertas")
        End Try
    End Sub

    Public Sub BDxxx()
        Try
            If _cX.State = ConnectionState.Open Then
                _cX.Close()
            End If
        Catch ex As MySqlException
            MsgBox("Error de Desconexión!" & vbCrLf & vbCrLf & ex.ToString, vbCritical, "Servicio de Alertas")
        End Try
    End Sub
End Module
