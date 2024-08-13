Imports MySql.Data.MySqlClient

Module verPesoEstimadoPorAnimal
    Public Function Ver(ByVal Pes As Integer) As mdlPesosEstimados
        Dim Cmd As New MySqlCommand
        Dim PesoEstimado As New mdlPesosEstimados
        Dim E As New mdlPesosEstimados
        Dim Sdr As MySqlDataReader

        Try
            Using Conn As MySqlConnection = New MySqlConnection(Servidor)
                Cmd = New MySqlCommand("feedlot.verPesoEstimadoPorAnimal")
                Cmd.CommandType = CommandType.StoredProcedure
                Cmd.Connection = Conn

                Cmd.Parameters.AddWithValue("@Pes", Pes)

                Conn.Open()
                Sdr = Cmd.ExecuteReader

                Sdr.Read()

                PesoEstimado.IdPesoEstimado = Sdr("idPeso")
                PesoEstimado.KgPesoVivo = Sdr("KGPV")
                PesoEstimado.Dia001 = Sdr("Dia001")
                PesoEstimado.Dia002 = Sdr("Dia002")
                PesoEstimado.Dia003 = Sdr("Dia003")
                PesoEstimado.Dia004 = Sdr("Dia004")
                PesoEstimado.Dia005 = Sdr("Dia005")
                PesoEstimado.Dia006 = Sdr("Dia006")
                PesoEstimado.Dia007 = Sdr("Dia007")
                PesoEstimado.Dia008 = Sdr("Dia008")
                PesoEstimado.Dia009 = Sdr("Dia009")
                PesoEstimado.Dia010 = Sdr("Dia010")
                PesoEstimado.Dia011 = Sdr("Dia011")
                PesoEstimado.Dia012 = Sdr("Dia012")
                PesoEstimado.Dia013 = Sdr("Dia013")
                PesoEstimado.Dia014 = Sdr("Dia014")
                PesoEstimado.Dia015 = Sdr("Dia015")
                PesoEstimado.Dia016 = Sdr("Dia016")
                PesoEstimado.Dia017 = Sdr("Dia017")
                PesoEstimado.Dia018 = Sdr("Dia018")
                PesoEstimado.Dia019 = Sdr("Dia019")
                PesoEstimado.Dia020 = Sdr("Dia020")
                PesoEstimado.Dia021 = Sdr("Dia021")
                PesoEstimado.Dia022 = Sdr("Dia022")
                PesoEstimado.Dia023 = Sdr("Dia023")
                PesoEstimado.Dia024 = Sdr("Dia024")
                PesoEstimado.Dia025 = Sdr("Dia025")
                PesoEstimado.Dia026 = Sdr("Dia026")
                PesoEstimado.Dia027 = Sdr("Dia027")
                PesoEstimado.Dia028 = Sdr("Dia028")
                PesoEstimado.Dia029 = Sdr("Dia029")
                PesoEstimado.Dia030 = Sdr("Dia030")
                PesoEstimado.Dia031 = Sdr("Dia031")
                PesoEstimado.Dia032 = Sdr("Dia032")
                PesoEstimado.Dia033 = Sdr("Dia033")
                PesoEstimado.Dia034 = Sdr("Dia034")
                PesoEstimado.Dia035 = Sdr("Dia035")
                PesoEstimado.Dia036 = Sdr("Dia036")
                PesoEstimado.Dia037 = Sdr("Dia037")
                PesoEstimado.Dia038 = Sdr("Dia038")
                PesoEstimado.Dia039 = Sdr("Dia039")
                PesoEstimado.Dia040 = Sdr("Dia040")
                PesoEstimado.Dia041 = Sdr("Dia041")
                PesoEstimado.Dia042 = Sdr("Dia042")
                PesoEstimado.Dia043 = Sdr("Dia043")
                PesoEstimado.Dia044 = Sdr("Dia044")
                PesoEstimado.Dia045 = Sdr("Dia045")
                PesoEstimado.Dia046 = Sdr("Dia046")
                PesoEstimado.Dia047 = Sdr("Dia047")
                PesoEstimado.Dia048 = Sdr("Dia048")
                PesoEstimado.Dia049 = Sdr("Dia049")
                PesoEstimado.Dia050 = Sdr("Dia050")
                PesoEstimado.Dia051 = Sdr("Dia051")
                PesoEstimado.Dia052 = Sdr("Dia052")
                PesoEstimado.Dia053 = Sdr("Dia053")
                PesoEstimado.Dia054 = Sdr("Dia054")
                PesoEstimado.Dia055 = Sdr("Dia055")
                PesoEstimado.Dia056 = Sdr("Dia056")
                PesoEstimado.Dia057 = Sdr("Dia057")
                PesoEstimado.Dia058 = Sdr("Dia058")
                PesoEstimado.Dia059 = Sdr("Dia059")
                PesoEstimado.Dia060 = Sdr("Dia060")
                PesoEstimado.Dia061 = Sdr("Dia061")
                PesoEstimado.Dia062 = Sdr("Dia062")
                PesoEstimado.Dia063 = Sdr("Dia063")
                PesoEstimado.Dia064 = Sdr("Dia064")
                PesoEstimado.Dia065 = Sdr("Dia065")
                PesoEstimado.Dia066 = Sdr("Dia066")
                PesoEstimado.Dia067 = Sdr("Dia067")
                PesoEstimado.Dia068 = Sdr("Dia068")
                PesoEstimado.Dia069 = Sdr("Dia069")
                PesoEstimado.Dia070 = Sdr("Dia070")
                PesoEstimado.Dia071 = Sdr("Dia071")
                PesoEstimado.Dia072 = Sdr("Dia072")
                PesoEstimado.Dia073 = Sdr("Dia073")
                PesoEstimado.Dia074 = Sdr("Dia074")
                PesoEstimado.Dia075 = Sdr("Dia075")
                PesoEstimado.Dia076 = Sdr("Dia076")
                PesoEstimado.Dia077 = Sdr("Dia077")
                PesoEstimado.Dia078 = Sdr("Dia078")
                PesoEstimado.Dia079 = Sdr("Dia079")
                PesoEstimado.Dia080 = Sdr("Dia080")
                PesoEstimado.Dia081 = Sdr("Dia081")
                PesoEstimado.Dia082 = Sdr("Dia082")
                PesoEstimado.Dia083 = Sdr("Dia083")
                PesoEstimado.Dia084 = Sdr("Dia084")
                PesoEstimado.Dia085 = Sdr("Dia085")
                PesoEstimado.Dia086 = Sdr("Dia086")
                PesoEstimado.Dia087 = Sdr("Dia087")
                PesoEstimado.Dia088 = Sdr("Dia088")
                PesoEstimado.Dia089 = Sdr("Dia089")
                PesoEstimado.Dia090 = Sdr("Dia090")
                PesoEstimado.Dia091 = Sdr("Dia091")
                PesoEstimado.Dia092 = Sdr("Dia092")
                PesoEstimado.Dia093 = Sdr("Dia093")
                PesoEstimado.Dia094 = Sdr("Dia094")
                PesoEstimado.Dia095 = Sdr("Dia095")
                PesoEstimado.Dia096 = Sdr("Dia096")
                PesoEstimado.Dia097 = Sdr("Dia097")
                PesoEstimado.Dia098 = Sdr("Dia098")
                PesoEstimado.Dia099 = Sdr("Dia099")
                PesoEstimado.Dia100 = Sdr("Dia100")
                PesoEstimado.Err = "OK"

                Sdr.Close()
            End Using

            Return PesoEstimado
        Catch ex As Exception
            E.Err = ex.Message.ToString

            Return E
        End Try
    End Function
End Module
