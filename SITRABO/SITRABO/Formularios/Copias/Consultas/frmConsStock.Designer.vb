<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmConsStock
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsStock))
        Me.lblConsulta = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dtmFstk = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaStock = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.pbxFiltar = New System.Windows.Forms.PictureBox()
        Me.pbxSalir = New System.Windows.Forms.PictureBox()
        Me.pbxEncabezado = New System.Windows.Forms.PictureBox()
        Me.pnlInicial1 = New System.Windows.Forms.Panel()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.pbxLogo = New System.Windows.Forms.PictureBox()
        Me.pnlIncial2 = New System.Windows.Forms.Panel()
        Me.pnlCorrales = New System.Windows.Forms.Panel()
        Me.pnlTotales = New System.Windows.Forms.Panel()
        Me.grpCorrales = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.lblStkHembras = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblStkMachos = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblStkTotal = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblTotalCorr = New System.Windows.Forms.Label()
        Me.lblCLib = New System.Windows.Forms.Label()
        Me.grpCategorias = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblCorrConAnim = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.pbxFiltar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxEncabezado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlInicial1.SuspendLayout()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTotales.SuspendLayout()
        CType(Me.grpCorrales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpCategorias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblConsulta
        '
        Me.lblConsulta.BackColor = System.Drawing.Color.Gainsboro
        Me.lblConsulta.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConsulta.ForeColor = System.Drawing.Color.SaddleBrown
        Me.lblConsulta.Location = New System.Drawing.Point(16, 14)
        Me.lblConsulta.Name = "lblConsulta"
        Me.lblConsulta.Size = New System.Drawing.Size(651, 20)
        Me.lblConsulta.TabIndex = 129
        Me.lblConsulta.Text = "CONSULTA DE STOCK"
        Me.lblConsulta.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel4
        '
        Me.Panel4.AutoScroll = True
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.BackgroundImage = Global.SITRABO.My.Resources.Resources.Panel1
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Controls.Add(Me.dtmFstk)
        Me.Panel4.Controls.Add(Me.lblFechaStock)
        Me.Panel4.Location = New System.Drawing.Point(673, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(533, 42)
        Me.Panel4.TabIndex = 173
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(269, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 18)
        Me.Label3.TabIndex = 101
        Me.Label3.Text = "Fec Cons Stk"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(3, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(119, 18)
        Me.Label10.TabIndex = 100
        Me.Label10.Text = "Ultimo Mov. Stk"
        '
        'dtmFstk
        '
        Me.dtmFstk.CustomFormat = "dd/MM/yyyy"
        Me.dtmFstk.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtmFstk.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtmFstk.Location = New System.Drawing.Point(377, 7)
        Me.dtmFstk.MaximumSize = New System.Drawing.Size(200, 22)
        Me.dtmFstk.Name = "dtmFstk"
        Me.dtmFstk.Size = New System.Drawing.Size(140, 22)
        Me.dtmFstk.TabIndex = 28
        '
        'lblFechaStock
        '
        Me.lblFechaStock.BackColor = System.Drawing.Color.Black
        Me.lblFechaStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFechaStock.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaStock.ForeColor = System.Drawing.Color.White
        Me.lblFechaStock.Location = New System.Drawing.Point(128, 7)
        Me.lblFechaStock.Name = "lblFechaStock"
        Me.lblFechaStock.Size = New System.Drawing.Size(119, 22)
        Me.lblFechaStock.TabIndex = 99
        Me.lblFechaStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.AutoScroll = True
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.BackgroundImage = Global.SITRABO.My.Resources.Resources.Panel1
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.pbxFiltar)
        Me.Panel3.Controls.Add(Me.pbxSalir)
        Me.Panel3.Location = New System.Drawing.Point(10, 449)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(157, 217)
        Me.Panel3.TabIndex = 173
        '
        'pbxFiltar
        '
        Me.pbxFiltar.BackColor = System.Drawing.Color.Transparent
        Me.pbxFiltar.BackgroundImage = Global.SITRABO.My.Resources.Resources.btnFiltrarNo1
        Me.pbxFiltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxFiltar.Location = New System.Drawing.Point(11, 11)
        Me.pbxFiltar.Name = "pbxFiltar"
        Me.pbxFiltar.Size = New System.Drawing.Size(132, 92)
        Me.pbxFiltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxFiltar.TabIndex = 8
        Me.pbxFiltar.TabStop = False
        '
        'pbxSalir
        '
        Me.pbxSalir.BackColor = System.Drawing.Color.Transparent
        Me.pbxSalir.BackgroundImage = Global.SITRABO.My.Resources.Resources.btnSalirNo
        Me.pbxSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxSalir.Location = New System.Drawing.Point(11, 111)
        Me.pbxSalir.Name = "pbxSalir"
        Me.pbxSalir.Size = New System.Drawing.Size(132, 92)
        Me.pbxSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxSalir.TabIndex = 7
        Me.pbxSalir.TabStop = False
        '
        'pbxEncabezado
        '
        Me.pbxEncabezado.BackColor = System.Drawing.Color.Gainsboro
        Me.pbxEncabezado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbxEncabezado.Location = New System.Drawing.Point(7, 3)
        Me.pbxEncabezado.Name = "pbxEncabezado"
        Me.pbxEncabezado.Size = New System.Drawing.Size(660, 42)
        Me.pbxEncabezado.TabIndex = 128
        Me.pbxEncabezado.TabStop = False
        '
        'pnlInicial1
        '
        Me.pnlInicial1.AutoScroll = True
        Me.pnlInicial1.AutoScrollMargin = New System.Drawing.Size(0, 20)
        Me.pnlInicial1.BackColor = System.Drawing.Color.Transparent
        Me.pnlInicial1.BackgroundImage = Global.SITRABO.My.Resources.Resources.Panel1
        Me.pnlInicial1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlInicial1.Controls.Add(Me.Label44)
        Me.pnlInicial1.Controls.Add(Me.pbxLogo)
        Me.pnlInicial1.Location = New System.Drawing.Point(9, 52)
        Me.pnlInicial1.Name = "pnlInicial1"
        Me.pnlInicial1.Size = New System.Drawing.Size(1197, 394)
        Me.pnlInicial1.TabIndex = 171
        '
        'Label44
        '
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.ForeColor = System.Drawing.Color.Gray
        Me.Label44.Location = New System.Drawing.Point(360, 303)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(516, 32)
        Me.Label44.TabIndex = 75
        Me.Label44.Text = "* Selecciona una Fecha y dale a filtrar para ver el Stock disponible ese día."
        Me.Label44.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbxLogo
        '
        Me.pbxLogo.BackColor = System.Drawing.Color.Transparent
        Me.pbxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pbxLogo.Image = Global.SITRABO.My.Resources.Resources.Logo1
        Me.pbxLogo.Location = New System.Drawing.Point(235, 89)
        Me.pbxLogo.Name = "pbxLogo"
        Me.pbxLogo.Size = New System.Drawing.Size(751, 172)
        Me.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxLogo.TabIndex = 74
        Me.pbxLogo.TabStop = False
        '
        'pnlIncial2
        '
        Me.pnlIncial2.AutoScroll = True
        Me.pnlIncial2.BackColor = System.Drawing.Color.Transparent
        Me.pnlIncial2.BackgroundImage = Global.SITRABO.My.Resources.Resources.Panel1
        Me.pnlIncial2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlIncial2.Location = New System.Drawing.Point(174, 450)
        Me.pnlIncial2.Name = "pnlIncial2"
        Me.pnlIncial2.Size = New System.Drawing.Size(1033, 217)
        Me.pnlIncial2.TabIndex = 173
        '
        'pnlCorrales
        '
        Me.pnlCorrales.AutoScroll = True
        Me.pnlCorrales.AutoScrollMargin = New System.Drawing.Size(0, 15)
        Me.pnlCorrales.BackColor = System.Drawing.Color.Transparent
        Me.pnlCorrales.BackgroundImage = Global.SITRABO.My.Resources.Resources.Panel1
        Me.pnlCorrales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlCorrales.Location = New System.Drawing.Point(8, 52)
        Me.pnlCorrales.Name = "pnlCorrales"
        Me.pnlCorrales.Size = New System.Drawing.Size(1198, 394)
        Me.pnlCorrales.TabIndex = 172
        Me.pnlCorrales.Visible = False
        '
        'pnlTotales
        '
        Me.pnlTotales.AutoScroll = True
        Me.pnlTotales.BackColor = System.Drawing.Color.Transparent
        Me.pnlTotales.BackgroundImage = Global.SITRABO.My.Resources.Resources.Panel1
        Me.pnlTotales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlTotales.Controls.Add(Me.grpCorrales)
        Me.pnlTotales.Controls.Add(Me.lblStkHembras)
        Me.pnlTotales.Controls.Add(Me.Label5)
        Me.pnlTotales.Controls.Add(Me.lblStkMachos)
        Me.pnlTotales.Controls.Add(Me.Label8)
        Me.pnlTotales.Controls.Add(Me.lblStkTotal)
        Me.pnlTotales.Controls.Add(Me.Label4)
        Me.pnlTotales.Controls.Add(Me.lblTotalCorr)
        Me.pnlTotales.Controls.Add(Me.lblCLib)
        Me.pnlTotales.Controls.Add(Me.grpCategorias)
        Me.pnlTotales.Controls.Add(Me.Label6)
        Me.pnlTotales.Controls.Add(Me.lblCorrConAnim)
        Me.pnlTotales.Controls.Add(Me.Label2)
        Me.pnlTotales.Controls.Add(Me.Label1)
        Me.pnlTotales.Location = New System.Drawing.Point(173, 449)
        Me.pnlTotales.Name = "pnlTotales"
        Me.pnlTotales.Size = New System.Drawing.Size(1033, 217)
        Me.pnlTotales.TabIndex = 172
        Me.pnlTotales.Visible = False
        '
        'grpCorrales
        '
        Me.grpCorrales.BorderlineColor = System.Drawing.Color.Black
        Me.grpCorrales.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        Me.grpCorrales.BorderlineWidth = 3
        Me.grpCorrales.BorderSkin.BackColor = System.Drawing.Color.Sienna
        ChartArea1.Area3DStyle.Enable3D = True
        ChartArea1.Area3DStyle.IsRightAngleAxes = False
        ChartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic
        ChartArea1.Name = "ChartArea1"
        Me.grpCorrales.ChartAreas.Add(ChartArea1)
        Legend1.Alignment = System.Drawing.StringAlignment.Center
        Legend1.AutoFitMinFontSize = 5
        Legend1.DockedToChartArea = "ChartArea1"
        Legend1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend1.ForeColor = System.Drawing.Color.SaddleBrown
        Legend1.HeaderSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.Line
        Legend1.InterlacedRows = True
        Legend1.InterlacedRowsColor = System.Drawing.Color.Transparent
        Legend1.IsDockedInsideChartArea = False
        Legend1.IsTextAutoFit = False
        Legend1.LegendItemOrder = System.Windows.Forms.DataVisualization.Charting.LegendItemOrder.SameAsSeriesOrder
        Legend1.Name = "Legend1"
        Legend1.TitleBackColor = System.Drawing.Color.Transparent
        Legend1.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend1.TitleForeColor = System.Drawing.Color.SaddleBrown
        Legend1.TitleSeparatorColor = System.Drawing.Color.White
        Me.grpCorrales.Legends.Add(Legend1)
        Me.grpCorrales.Location = New System.Drawing.Point(508, 11)
        Me.grpCorrales.Name = "grpCorrales"
        Me.grpCorrales.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series1.IsValueShownAsLabel = True
        Series1.LabelFormat = "#,##0"
        Series1.Legend = "Legend1"
        Series1.Name = "Corrales"
        Series1.SmartLabelStyle.AllowOutsidePlotArea = System.Windows.Forms.DataVisualization.Charting.LabelOutsidePlotAreaStyle.Yes
        Series1.SmartLabelStyle.IsOverlappedHidden = False
        Series1.SmartLabelStyle.MaxMovingDistance = 100.0R
        Me.grpCorrales.Series.Add(Series1)
        Me.grpCorrales.Size = New System.Drawing.Size(326, 192)
        Me.grpCorrales.TabIndex = 35
        Me.grpCorrales.Text = "Chart4"
        '
        'lblStkHembras
        '
        Me.lblStkHembras.BackColor = System.Drawing.Color.Black
        Me.lblStkHembras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStkHembras.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStkHembras.ForeColor = System.Drawing.Color.DarkOrange
        Me.lblStkHembras.Location = New System.Drawing.Point(869, 99)
        Me.lblStkHembras.Name = "lblStkHembras"
        Me.lblStkHembras.Size = New System.Drawing.Size(145, 23)
        Me.lblStkHembras.TabIndex = 34
        Me.lblStkHembras.Text = "0"
        Me.lblStkHembras.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(869, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(145, 23)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "STOCK HEMBRAS"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblStkMachos
        '
        Me.lblStkMachos.BackColor = System.Drawing.Color.Black
        Me.lblStkMachos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStkMachos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStkMachos.ForeColor = System.Drawing.Color.DarkOrange
        Me.lblStkMachos.Location = New System.Drawing.Point(872, 34)
        Me.lblStkMachos.Name = "lblStkMachos"
        Me.lblStkMachos.Size = New System.Drawing.Size(145, 23)
        Me.lblStkMachos.TabIndex = 32
        Me.lblStkMachos.Text = "0"
        Me.lblStkMachos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(872, 11)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(145, 23)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "STOCK MACHOS"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblStkTotal
        '
        Me.lblStkTotal.BackColor = System.Drawing.Color.Black
        Me.lblStkTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStkTotal.Font = New System.Drawing.Font("Arial Black", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStkTotal.ForeColor = System.Drawing.Color.Lime
        Me.lblStkTotal.Location = New System.Drawing.Point(852, 162)
        Me.lblStkTotal.Name = "lblStkTotal"
        Me.lblStkTotal.Size = New System.Drawing.Size(165, 40)
        Me.lblStkTotal.TabIndex = 30
        Me.lblStkTotal.Text = "0"
        Me.lblStkTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(848, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(166, 23)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "STOCK TOTAL"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalCorr
        '
        Me.lblTotalCorr.BackColor = System.Drawing.Color.Black
        Me.lblTotalCorr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalCorr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCorr.ForeColor = System.Drawing.Color.DarkOrange
        Me.lblTotalCorr.Location = New System.Drawing.Point(14, 162)
        Me.lblTotalCorr.Name = "lblTotalCorr"
        Me.lblTotalCorr.Size = New System.Drawing.Size(145, 23)
        Me.lblTotalCorr.TabIndex = 28
        Me.lblTotalCorr.Text = "0"
        Me.lblTotalCorr.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCLib
        '
        Me.lblCLib.BackColor = System.Drawing.Color.Black
        Me.lblCLib.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCLib.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCLib.ForeColor = System.Drawing.Color.DarkOrange
        Me.lblCLib.Location = New System.Drawing.Point(14, 99)
        Me.lblCLib.Name = "lblCLib"
        Me.lblCLib.Size = New System.Drawing.Size(145, 23)
        Me.lblCLib.TabIndex = 27
        Me.lblCLib.Text = "0"
        Me.lblCLib.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'grpCategorias
        '
        Me.grpCategorias.BorderlineColor = System.Drawing.Color.Black
        Me.grpCategorias.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        Me.grpCategorias.BorderlineWidth = 3
        Me.grpCategorias.BorderSkin.BackColor = System.Drawing.Color.Sienna
        ChartArea2.Area3DStyle.Enable3D = True
        ChartArea2.Area3DStyle.IsRightAngleAxes = False
        ChartArea2.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic
        ChartArea2.Name = "ChartArea1"
        Me.grpCategorias.ChartAreas.Add(ChartArea2)
        Legend2.Alignment = System.Drawing.StringAlignment.Center
        Legend2.AutoFitMinFontSize = 5
        Legend2.DockedToChartArea = "ChartArea1"
        Legend2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend2.ForeColor = System.Drawing.Color.SaddleBrown
        Legend2.HeaderSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.Line
        Legend2.InterlacedRows = True
        Legend2.InterlacedRowsColor = System.Drawing.Color.Transparent
        Legend2.IsDockedInsideChartArea = False
        Legend2.IsTextAutoFit = False
        Legend2.LegendItemOrder = System.Windows.Forms.DataVisualization.Charting.LegendItemOrder.SameAsSeriesOrder
        Legend2.Name = "Legend1"
        Legend2.TitleBackColor = System.Drawing.Color.Transparent
        Legend2.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend2.TitleForeColor = System.Drawing.Color.SaddleBrown
        Legend2.TitleSeparatorColor = System.Drawing.Color.White
        Me.grpCategorias.Legends.Add(Legend2)
        Me.grpCategorias.Location = New System.Drawing.Point(176, 10)
        Me.grpCategorias.Name = "grpCategorias"
        Me.grpCategorias.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series2.IsValueShownAsLabel = True
        Series2.LabelFormat = "#,##0"
        Series2.Legend = "Legend1"
        Series2.Name = "Categorias"
        Series2.SmartLabelStyle.AllowOutsidePlotArea = System.Windows.Forms.DataVisualization.Charting.LabelOutsidePlotAreaStyle.Yes
        Series2.SmartLabelStyle.IsOverlappedHidden = False
        Series2.SmartLabelStyle.MaxMovingDistance = 100.0R
        Me.grpCategorias.Series.Add(Series2)
        Me.grpCategorias.Size = New System.Drawing.Size(326, 192)
        Me.grpCategorias.TabIndex = 26
        Me.grpCategorias.Text = "Chart4"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(17, 139)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(142, 23)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "TOTAL CORRALES"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCorrConAnim
        '
        Me.lblCorrConAnim.BackColor = System.Drawing.Color.Black
        Me.lblCorrConAnim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCorrConAnim.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorrConAnim.ForeColor = System.Drawing.Color.DarkOrange
        Me.lblCorrConAnim.Location = New System.Drawing.Point(14, 34)
        Me.lblCorrConAnim.Name = "lblCorrConAnim"
        Me.lblCorrConAnim.Size = New System.Drawing.Size(145, 23)
        Me.lblCorrConAnim.TabIndex = 2
        Me.lblCorrConAnim.Text = "0"
        Me.lblCorrConAnim.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(14, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "CORRALES LIBRES"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(14, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CORRALES CON ANIM."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmConsStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(1215, 670)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.lblConsulta)
        Me.Controls.Add(Me.pbxEncabezado)
        Me.Controls.Add(Me.pnlInicial1)
        Me.Controls.Add(Me.pnlIncial2)
        Me.Controls.Add(Me.pnlCorrales)
        Me.Controls.Add(Me.pnlTotales)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmConsStock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmConsStock"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.pbxFiltar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxSalir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxEncabezado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlInicial1.ResumeLayout(False)
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTotales.ResumeLayout(False)
        CType(Me.grpCorrales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpCategorias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblConsulta As Label
    Friend WithEvents dtmFstk As DateTimePicker
    Friend WithEvents pbxEncabezado As PictureBox
    Friend WithEvents pnlInicial1 As Panel
    Friend WithEvents Label44 As Label
    Friend WithEvents pbxLogo As PictureBox
    Friend WithEvents pnlTotales As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents pbxSalir As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents pnlCorrales As Panel
    Friend WithEvents pbxFiltar As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lblCorrConAnim As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTotalCorr As Label
    Friend WithEvents lblCLib As Label
    Friend WithEvents lblStkTotal As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblStkMachos As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblStkHembras As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblFechaStock As Label
    Friend WithEvents pnlIncial2 As Panel
    Friend WithEvents grpCorrales As DataVisualization.Charting.Chart
    Friend WithEvents grpCategorias As DataVisualization.Charting.Chart
End Class
