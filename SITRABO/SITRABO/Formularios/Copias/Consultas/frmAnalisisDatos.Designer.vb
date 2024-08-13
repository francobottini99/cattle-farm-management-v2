<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAnalisisDatos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAnalisisDatos))
        Me.BackgroundWorker = New System.ComponentModel.BackgroundWorker()
        Me.gbxPantallaInicio = New System.Windows.Forms.GroupBox()
        Me.lblCorral = New System.Windows.Forms.Label()
        Me.lblTropa = New System.Windows.Forms.Label()
        Me.lblProd = New System.Windows.Forms.Label()
        Me.lblFhasta = New System.Windows.Forms.Label()
        Me.lblFdesde = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chbFdesde = New System.Windows.Forms.CheckBox()
        Me.txtIdP = New System.Windows.Forms.TextBox()
        Me.dtmFdesde = New System.Windows.Forms.DateTimePicker()
        Me.txtIdCrr = New System.Windows.Forms.TextBox()
        Me.dtmFhasta = New System.Windows.Forms.DateTimePicker()
        Me.txtIdT = New System.Windows.Forms.TextBox()
        Me.chbFhasta = New System.Windows.Forms.CheckBox()
        Me.chbCorral = New System.Windows.Forms.CheckBox()
        Me.cbxProductor = New System.Windows.Forms.ComboBox()
        Me.chbTropa = New System.Windows.Forms.CheckBox()
        Me.cbxTropa = New System.Windows.Forms.ComboBox()
        Me.chbProd = New System.Windows.Forms.CheckBox()
        Me.cbxCorral = New System.Windows.Forms.ComboBox()
        Me.pbxSalir = New System.Windows.Forms.PictureBox()
        Me.pbxGenerar = New System.Windows.Forms.PictureBox()
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.gbxInformes = New System.Windows.Forms.GroupBox()
        Me.rdbSanidad = New System.Windows.Forms.RadioButton()
        Me.rdbEngorde = New System.Windows.Forms.RadioButton()
        Me.rdbConsumo = New System.Windows.Forms.RadioButton()
        Me.rdbPeso = New System.Windows.Forms.RadioButton()
        Me.msgInforme = New System.Windows.Forms.Label()
        Me.gbxExportacion = New System.Windows.Forms.GroupBox()
        Me.pbrExportacion = New System.Windows.Forms.ProgressBar()
        Me.msgExp = New System.Windows.Forms.Label()
        Me.gbxPantallaInicio.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pbxSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxGenerar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxInformes.SuspendLayout()
        Me.gbxExportacion.SuspendLayout()
        Me.SuspendLayout()
        '
        'BackgroundWorker
        '
        Me.BackgroundWorker.WorkerReportsProgress = True
        '
        'gbxPantallaInicio
        '
        Me.gbxPantallaInicio.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxPantallaInicio.BackColor = System.Drawing.Color.Transparent
        Me.gbxPantallaInicio.BackgroundImage = Global.SITRABO.My.Resources.Resources.Panel1
        Me.gbxPantallaInicio.Controls.Add(Me.lblCorral)
        Me.gbxPantallaInicio.Controls.Add(Me.lblTropa)
        Me.gbxPantallaInicio.Controls.Add(Me.lblProd)
        Me.gbxPantallaInicio.Controls.Add(Me.lblFhasta)
        Me.gbxPantallaInicio.Controls.Add(Me.lblFdesde)
        Me.gbxPantallaInicio.Controls.Add(Me.GroupBox1)
        Me.gbxPantallaInicio.Controls.Add(Me.pbxSalir)
        Me.gbxPantallaInicio.Controls.Add(Me.pbxGenerar)
        Me.gbxPantallaInicio.Controls.Add(Me.lblMsg)
        Me.gbxPantallaInicio.Controls.Add(Me.gbxInformes)
        Me.gbxPantallaInicio.Controls.Add(Me.gbxExportacion)
        Me.gbxPantallaInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxPantallaInicio.Location = New System.Drawing.Point(3, 2)
        Me.gbxPantallaInicio.Name = "gbxPantallaInicio"
        Me.gbxPantallaInicio.Size = New System.Drawing.Size(620, 474)
        Me.gbxPantallaInicio.TabIndex = 76
        Me.gbxPantallaInicio.TabStop = False
        '
        'lblCorral
        '
        Me.lblCorral.BackColor = System.Drawing.Color.Salmon
        Me.lblCorral.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorral.ForeColor = System.Drawing.Color.White
        Me.lblCorral.Location = New System.Drawing.Point(167, 446)
        Me.lblCorral.Name = "lblCorral"
        Me.lblCorral.Size = New System.Drawing.Size(160, 21)
        Me.lblCorral.TabIndex = 121
        Me.lblCorral.Text = "CORRAL 1"
        Me.lblCorral.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblCorral.Visible = False
        '
        'lblTropa
        '
        Me.lblTropa.BackColor = System.Drawing.Color.Salmon
        Me.lblTropa.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTropa.ForeColor = System.Drawing.Color.White
        Me.lblTropa.Location = New System.Drawing.Point(6, 446)
        Me.lblTropa.Name = "lblTropa"
        Me.lblTropa.Size = New System.Drawing.Size(155, 21)
        Me.lblTropa.TabIndex = 120
        Me.lblTropa.Text = "016 - Rabbia (C)"
        Me.lblTropa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblTropa.Visible = False
        '
        'lblProd
        '
        Me.lblProd.BackColor = System.Drawing.Color.Salmon
        Me.lblProd.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProd.ForeColor = System.Drawing.Color.White
        Me.lblProd.Location = New System.Drawing.Point(167, 416)
        Me.lblProd.Name = "lblProd"
        Me.lblProd.Size = New System.Drawing.Size(201, 21)
        Me.lblProd.TabIndex = 119
        Me.lblProd.Text = "BOTTINI CRISTIAN Y MAURO"
        Me.lblProd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblProd.Visible = False
        '
        'lblFhasta
        '
        Me.lblFhasta.BackColor = System.Drawing.Color.Salmon
        Me.lblFhasta.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFhasta.ForeColor = System.Drawing.Color.White
        Me.lblFhasta.Location = New System.Drawing.Point(86, 416)
        Me.lblFhasta.Name = "lblFhasta"
        Me.lblFhasta.Size = New System.Drawing.Size(75, 21)
        Me.lblFhasta.TabIndex = 118
        Me.lblFhasta.Text = "05/05/2018"
        Me.lblFhasta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblFhasta.Visible = False
        '
        'lblFdesde
        '
        Me.lblFdesde.BackColor = System.Drawing.Color.Salmon
        Me.lblFdesde.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFdesde.ForeColor = System.Drawing.Color.White
        Me.lblFdesde.Location = New System.Drawing.Point(7, 416)
        Me.lblFdesde.Name = "lblFdesde"
        Me.lblFdesde.Size = New System.Drawing.Size(73, 21)
        Me.lblFdesde.TabIndex = 117
        Me.lblFdesde.Text = "05/05/2018"
        Me.lblFdesde.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblFdesde.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chbFdesde)
        Me.GroupBox1.Controls.Add(Me.txtIdP)
        Me.GroupBox1.Controls.Add(Me.dtmFdesde)
        Me.GroupBox1.Controls.Add(Me.txtIdCrr)
        Me.GroupBox1.Controls.Add(Me.dtmFhasta)
        Me.GroupBox1.Controls.Add(Me.txtIdT)
        Me.GroupBox1.Controls.Add(Me.chbFhasta)
        Me.GroupBox1.Controls.Add(Me.chbCorral)
        Me.GroupBox1.Controls.Add(Me.cbxProductor)
        Me.GroupBox1.Controls.Add(Me.chbTropa)
        Me.GroupBox1.Controls.Add(Me.cbxTropa)
        Me.GroupBox1.Controls.Add(Me.chbProd)
        Me.GroupBox1.Controls.Add(Me.cbxCorral)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(5, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(608, 141)
        Me.GroupBox1.TabIndex = 115
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " Parámetros de Consulta "
        '
        'chbFdesde
        '
        Me.chbFdesde.AutoSize = True
        Me.chbFdesde.ForeColor = System.Drawing.Color.Moccasin
        Me.chbFdesde.Location = New System.Drawing.Point(9, 22)
        Me.chbFdesde.Name = "chbFdesde"
        Me.chbFdesde.Size = New System.Drawing.Size(120, 20)
        Me.chbFdesde.TabIndex = 96
        Me.chbFdesde.Text = "Fecha Desde"
        Me.chbFdesde.UseVisualStyleBackColor = True
        '
        'txtIdP
        '
        Me.txtIdP.BackColor = System.Drawing.Color.LightCoral
        Me.txtIdP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtIdP.Location = New System.Drawing.Point(528, 47)
        Me.txtIdP.MaxLength = 10
        Me.txtIdP.Name = "txtIdP"
        Me.txtIdP.Size = New System.Drawing.Size(44, 20)
        Me.txtIdP.TabIndex = 114
        Me.txtIdP.Visible = False
        '
        'dtmFdesde
        '
        Me.dtmFdesde.CustomFormat = "dd/MM/yyyy"
        Me.dtmFdesde.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtmFdesde.Enabled = False
        Me.dtmFdesde.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtmFdesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtmFdesde.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dtmFdesde.Location = New System.Drawing.Point(6, 45)
        Me.dtmFdesde.MaximumSize = New System.Drawing.Size(200, 22)
        Me.dtmFdesde.Name = "dtmFdesde"
        Me.dtmFdesde.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dtmFdesde.Size = New System.Drawing.Size(150, 22)
        Me.dtmFdesde.TabIndex = 94
        Me.dtmFdesde.Value = New Date(2018, 4, 30, 17, 41, 0, 0)
        '
        'txtIdCrr
        '
        Me.txtIdCrr.BackColor = System.Drawing.Color.LightCoral
        Me.txtIdCrr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdCrr.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtIdCrr.Location = New System.Drawing.Point(526, 102)
        Me.txtIdCrr.MaxLength = 10
        Me.txtIdCrr.Name = "txtIdCrr"
        Me.txtIdCrr.Size = New System.Drawing.Size(44, 20)
        Me.txtIdCrr.TabIndex = 112
        Me.txtIdCrr.Visible = False
        '
        'dtmFhasta
        '
        Me.dtmFhasta.CustomFormat = "dd/MM/yyyy"
        Me.dtmFhasta.Enabled = False
        Me.dtmFhasta.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtmFhasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtmFhasta.Location = New System.Drawing.Point(169, 45)
        Me.dtmFhasta.MaximumSize = New System.Drawing.Size(200, 22)
        Me.dtmFhasta.Name = "dtmFhasta"
        Me.dtmFhasta.Size = New System.Drawing.Size(151, 22)
        Me.dtmFhasta.TabIndex = 95
        '
        'txtIdT
        '
        Me.txtIdT.BackColor = System.Drawing.Color.LightCoral
        Me.txtIdT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtIdT.Location = New System.Drawing.Point(201, 100)
        Me.txtIdT.MaxLength = 10
        Me.txtIdT.Name = "txtIdT"
        Me.txtIdT.Size = New System.Drawing.Size(44, 20)
        Me.txtIdT.TabIndex = 111
        Me.txtIdT.Visible = False
        '
        'chbFhasta
        '
        Me.chbFhasta.AutoSize = True
        Me.chbFhasta.ForeColor = System.Drawing.Color.Moccasin
        Me.chbFhasta.Location = New System.Drawing.Point(169, 22)
        Me.chbFhasta.Name = "chbFhasta"
        Me.chbFhasta.Size = New System.Drawing.Size(115, 20)
        Me.chbFhasta.TabIndex = 97
        Me.chbFhasta.Text = "Fecha Hasta"
        Me.chbFhasta.UseVisualStyleBackColor = True
        '
        'chbCorral
        '
        Me.chbCorral.AutoSize = True
        Me.chbCorral.ForeColor = System.Drawing.Color.Moccasin
        Me.chbCorral.Location = New System.Drawing.Point(335, 76)
        Me.chbCorral.Name = "chbCorral"
        Me.chbCorral.Size = New System.Drawing.Size(69, 20)
        Me.chbCorral.TabIndex = 109
        Me.chbCorral.Text = "Corral"
        Me.chbCorral.UseVisualStyleBackColor = True
        '
        'cbxProductor
        '
        Me.cbxProductor.BackColor = System.Drawing.Color.SaddleBrown
        Me.cbxProductor.Enabled = False
        Me.cbxProductor.ForeColor = System.Drawing.Color.Moccasin
        Me.cbxProductor.FormattingEnabled = True
        Me.cbxProductor.Location = New System.Drawing.Point(335, 45)
        Me.cbxProductor.Name = "cbxProductor"
        Me.cbxProductor.Size = New System.Drawing.Size(258, 24)
        Me.cbxProductor.TabIndex = 103
        '
        'chbTropa
        '
        Me.chbTropa.AutoSize = True
        Me.chbTropa.ForeColor = System.Drawing.Color.Moccasin
        Me.chbTropa.Location = New System.Drawing.Point(6, 76)
        Me.chbTropa.Name = "chbTropa"
        Me.chbTropa.Size = New System.Drawing.Size(69, 20)
        Me.chbTropa.TabIndex = 108
        Me.chbTropa.Text = "Tropa"
        Me.chbTropa.UseVisualStyleBackColor = True
        '
        'cbxTropa
        '
        Me.cbxTropa.BackColor = System.Drawing.Color.SaddleBrown
        Me.cbxTropa.Enabled = False
        Me.cbxTropa.ForeColor = System.Drawing.Color.Moccasin
        Me.cbxTropa.FormattingEnabled = True
        Me.cbxTropa.Location = New System.Drawing.Point(5, 98)
        Me.cbxTropa.Name = "cbxTropa"
        Me.cbxTropa.Size = New System.Drawing.Size(261, 24)
        Me.cbxTropa.TabIndex = 104
        '
        'chbProd
        '
        Me.chbProd.AutoSize = True
        Me.chbProd.ForeColor = System.Drawing.Color.Moccasin
        Me.chbProd.Location = New System.Drawing.Point(335, 22)
        Me.chbProd.Name = "chbProd"
        Me.chbProd.Size = New System.Drawing.Size(94, 20)
        Me.chbProd.TabIndex = 107
        Me.chbProd.Text = "Productor"
        Me.chbProd.UseVisualStyleBackColor = True
        '
        'cbxCorral
        '
        Me.cbxCorral.BackColor = System.Drawing.Color.SaddleBrown
        Me.cbxCorral.Enabled = False
        Me.cbxCorral.ForeColor = System.Drawing.Color.Moccasin
        Me.cbxCorral.FormattingEnabled = True
        Me.cbxCorral.Location = New System.Drawing.Point(335, 98)
        Me.cbxCorral.Name = "cbxCorral"
        Me.cbxCorral.Size = New System.Drawing.Size(258, 24)
        Me.cbxCorral.TabIndex = 105
        '
        'pbxSalir
        '
        Me.pbxSalir.BackColor = System.Drawing.Color.Transparent
        Me.pbxSalir.BackgroundImage = Global.SITRABO.My.Resources.Resources.btnSalirNo
        Me.pbxSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxSalir.Location = New System.Drawing.Point(528, 416)
        Me.pbxSalir.Name = "pbxSalir"
        Me.pbxSalir.Size = New System.Drawing.Size(81, 52)
        Me.pbxSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxSalir.TabIndex = 76
        Me.pbxSalir.TabStop = False
        '
        'pbxGenerar
        '
        Me.pbxGenerar.BackColor = System.Drawing.Color.Transparent
        Me.pbxGenerar.BackgroundImage = Global.SITRABO.My.Resources.Resources.btnTransferirNo
        Me.pbxGenerar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxGenerar.Location = New System.Drawing.Point(421, 416)
        Me.pbxGenerar.Name = "pbxGenerar"
        Me.pbxGenerar.Size = New System.Drawing.Size(81, 52)
        Me.pbxGenerar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxGenerar.TabIndex = 9
        Me.pbxGenerar.TabStop = False
        '
        'lblMsg
        '
        Me.lblMsg.BackColor = System.Drawing.Color.LightSlateGray
        Me.lblMsg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMsg.Font = New System.Drawing.Font("Hobo Std", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsg.ForeColor = System.Drawing.Color.Moccasin
        Me.lblMsg.Location = New System.Drawing.Point(5, 12)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(608, 40)
        Me.lblMsg.TabIndex = 75
        Me.lblMsg.Text = "EXPORTAR DATOS DE PESAJES"
        Me.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gbxInformes
        '
        Me.gbxInformes.Controls.Add(Me.rdbSanidad)
        Me.gbxInformes.Controls.Add(Me.rdbEngorde)
        Me.gbxInformes.Controls.Add(Me.rdbConsumo)
        Me.gbxInformes.Controls.Add(Me.rdbPeso)
        Me.gbxInformes.Controls.Add(Me.msgInforme)
        Me.gbxInformes.ForeColor = System.Drawing.Color.White
        Me.gbxInformes.Location = New System.Drawing.Point(5, 200)
        Me.gbxInformes.Name = "gbxInformes"
        Me.gbxInformes.Size = New System.Drawing.Size(608, 210)
        Me.gbxInformes.TabIndex = 117
        Me.gbxInformes.TabStop = False
        Me.gbxInformes.Text = " Seleccione un Informe "
        Me.gbxInformes.Visible = False
        '
        'rdbSanidad
        '
        Me.rdbSanidad.AutoSize = True
        Me.rdbSanidad.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbSanidad.ForeColor = System.Drawing.Color.Moccasin
        Me.rdbSanidad.Location = New System.Drawing.Point(231, 135)
        Me.rdbSanidad.Name = "rdbSanidad"
        Me.rdbSanidad.Size = New System.Drawing.Size(90, 23)
        Me.rdbSanidad.TabIndex = 78
        Me.rdbSanidad.TabStop = True
        Me.rdbSanidad.Text = "Sanidad"
        Me.rdbSanidad.UseVisualStyleBackColor = True
        '
        'rdbEngorde
        '
        Me.rdbEngorde.AutoSize = True
        Me.rdbEngorde.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbEngorde.ForeColor = System.Drawing.Color.Moccasin
        Me.rdbEngorde.Location = New System.Drawing.Point(231, 95)
        Me.rdbEngorde.Name = "rdbEngorde"
        Me.rdbEngorde.Size = New System.Drawing.Size(154, 23)
        Me.rdbEngorde.TabIndex = 77
        Me.rdbEngorde.TabStop = True
        Me.rdbEngorde.Text = "Días de Engorde"
        Me.rdbEngorde.UseVisualStyleBackColor = True
        '
        'rdbConsumo
        '
        Me.rdbConsumo.AutoSize = True
        Me.rdbConsumo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbConsumo.ForeColor = System.Drawing.Color.Moccasin
        Me.rdbConsumo.Location = New System.Drawing.Point(231, 56)
        Me.rdbConsumo.Name = "rdbConsumo"
        Me.rdbConsumo.Size = New System.Drawing.Size(102, 23)
        Me.rdbConsumo.TabIndex = 76
        Me.rdbConsumo.TabStop = True
        Me.rdbConsumo.Text = "Consumo"
        Me.rdbConsumo.UseVisualStyleBackColor = True
        '
        'rdbPeso
        '
        Me.rdbPeso.AutoSize = True
        Me.rdbPeso.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbPeso.ForeColor = System.Drawing.Color.Moccasin
        Me.rdbPeso.Location = New System.Drawing.Point(231, 20)
        Me.rdbPeso.Name = "rdbPeso"
        Me.rdbPeso.Size = New System.Drawing.Size(66, 23)
        Me.rdbPeso.TabIndex = 75
        Me.rdbPeso.TabStop = True
        Me.rdbPeso.Text = "Peso"
        Me.rdbPeso.UseVisualStyleBackColor = True
        '
        'msgInforme
        '
        Me.msgInforme.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msgInforme.ForeColor = System.Drawing.Color.Gray
        Me.msgInforme.Location = New System.Drawing.Point(95, 174)
        Me.msgInforme.Name = "msgInforme"
        Me.msgInforme.Size = New System.Drawing.Size(390, 20)
        Me.msgInforme.TabIndex = 74
        Me.msgInforme.Text = """Presiona EXPORTAR para comezar transferencia de datos """
        Me.msgInforme.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'gbxExportacion
        '
        Me.gbxExportacion.Controls.Add(Me.pbrExportacion)
        Me.gbxExportacion.Controls.Add(Me.msgExp)
        Me.gbxExportacion.ForeColor = System.Drawing.Color.White
        Me.gbxExportacion.Location = New System.Drawing.Point(5, 200)
        Me.gbxExportacion.Name = "gbxExportacion"
        Me.gbxExportacion.Size = New System.Drawing.Size(608, 210)
        Me.gbxExportacion.TabIndex = 116
        Me.gbxExportacion.TabStop = False
        Me.gbxExportacion.Text = " Exportación De Datos "
        Me.gbxExportacion.Visible = False
        '
        'pbrExportacion
        '
        Me.pbrExportacion.Location = New System.Drawing.Point(9, 85)
        Me.pbrExportacion.Name = "pbrExportacion"
        Me.pbrExportacion.Size = New System.Drawing.Size(584, 23)
        Me.pbrExportacion.TabIndex = 10
        '
        'msgExp
        '
        Me.msgExp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msgExp.ForeColor = System.Drawing.Color.Gray
        Me.msgExp.Location = New System.Drawing.Point(172, 151)
        Me.msgExp.Name = "msgExp"
        Me.msgExp.Size = New System.Drawing.Size(255, 20)
        Me.msgExp.TabIndex = 74
        Me.msgExp.Text = """Transferencia de datos en progreso..."""
        Me.msgExp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmAnalisisDatos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(626, 478)
        Me.Controls.Add(Me.gbxPantallaInicio)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmAnalisisDatos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAnalisisDatos"
        Me.gbxPantallaInicio.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pbxSalir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxGenerar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxInformes.ResumeLayout(False)
        Me.gbxInformes.PerformLayout()
        Me.gbxExportacion.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pbxGenerar As PictureBox
    Friend WithEvents dgvPrueba As DataGridView
    Friend WithEvents pbrExportacion As ProgressBar
    Friend WithEvents lblMsg As Label
    Friend WithEvents gbxPantallaInicio As GroupBox
    Friend WithEvents pbxSalir As PictureBox
    Friend WithEvents BackgroundWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents chbFhasta As CheckBox
    Friend WithEvents chbFdesde As CheckBox
    Friend WithEvents dtmFhasta As DateTimePicker
    Friend WithEvents dtmFdesde As DateTimePicker
    Friend WithEvents txtIdP As TextBox
    Friend WithEvents txtIdCrr As TextBox
    Friend WithEvents txtIdT As TextBox
    Friend WithEvents chbCorral As CheckBox
    Friend WithEvents chbTropa As CheckBox
    Friend WithEvents chbProd As CheckBox
    Friend WithEvents cbxCorral As ComboBox
    Friend WithEvents cbxTropa As ComboBox
    Friend WithEvents cbxProductor As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents gbxExportacion As GroupBox
    Friend WithEvents lblCorral As Label
    Friend WithEvents lblTropa As Label
    Friend WithEvents lblProd As Label
    Friend WithEvents lblFhasta As Label
    Friend WithEvents lblFdesde As Label
    Friend WithEvents gbxInformes As GroupBox
    Friend WithEvents msgInforme As Label
    Friend WithEvents msgExp As Label
    Friend WithEvents rdbSanidad As RadioButton
    Friend WithEvents rdbEngorde As RadioButton
    Friend WithEvents rdbConsumo As RadioButton
    Friend WithEvents rdbPeso As RadioButton
End Class
