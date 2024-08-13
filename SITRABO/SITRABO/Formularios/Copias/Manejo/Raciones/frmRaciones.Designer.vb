<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRaciones
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRaciones))
        Me.gbxRaciones = New System.Windows.Forms.GroupBox()
        Me.txtKGTotales = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgvRestricciones = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgvRacion = New System.Windows.Forms.DataGridView()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pbxAggAliemnto = New System.Windows.Forms.PictureBox()
        Me.pbxAggRestricciones = New System.Windows.Forms.PictureBox()
        Me.pbxFormular = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gbxPantallaInicio = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.pbxLogo = New System.Windows.Forms.PictureBox()
        Me.pbxSalir = New System.Windows.Forms.PictureBox()
        Me.pbxModificar = New System.Windows.Forms.PictureBox()
        Me.pbxGuardar = New System.Windows.Forms.PictureBox()
        Me.pbxCancelar = New System.Windows.Forms.PictureBox()
        Me.pbxNuevo = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.gbxRaciones.SuspendLayout()
        CType(Me.dgvRestricciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvRacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxAggAliemnto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxAggRestricciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxFormular, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxPantallaInicio.SuspendLayout()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxModificar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxGuardar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxCancelar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxNuevo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxRaciones
        '
        Me.gbxRaciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxRaciones.BackColor = System.Drawing.Color.Transparent
        Me.gbxRaciones.BackgroundImage = Global.SITRABO.My.Resources.Resources.Panel1
        Me.gbxRaciones.Controls.Add(Me.txtKGTotales)
        Me.gbxRaciones.Controls.Add(Me.Label6)
        Me.gbxRaciones.Controls.Add(Me.Label4)
        Me.gbxRaciones.Controls.Add(Me.dgvRestricciones)
        Me.gbxRaciones.Controls.Add(Me.Label3)
        Me.gbxRaciones.Controls.Add(Me.Label5)
        Me.gbxRaciones.Controls.Add(Me.dgvRacion)
        Me.gbxRaciones.Controls.Add(Me.Label13)
        Me.gbxRaciones.Controls.Add(Me.lblMsg)
        Me.gbxRaciones.Controls.Add(Me.Label1)
        Me.gbxRaciones.Controls.Add(Me.pbxAggAliemnto)
        Me.gbxRaciones.Controls.Add(Me.pbxAggRestricciones)
        Me.gbxRaciones.Controls.Add(Me.pbxFormular)
        Me.gbxRaciones.Controls.Add(Me.Label2)
        Me.gbxRaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxRaciones.Location = New System.Drawing.Point(220, 12)
        Me.gbxRaciones.Name = "gbxRaciones"
        Me.gbxRaciones.Size = New System.Drawing.Size(850, 636)
        Me.gbxRaciones.TabIndex = 75
        Me.gbxRaciones.TabStop = False
        Me.gbxRaciones.Visible = False
        '
        'txtKGTotales
        '
        Me.txtKGTotales.BackColor = System.Drawing.Color.Black
        Me.txtKGTotales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtKGTotales.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKGTotales.ForeColor = System.Drawing.Color.Orange
        Me.txtKGTotales.Location = New System.Drawing.Point(682, 19)
        Me.txtKGTotales.MaxLength = 45
        Me.txtKGTotales.Name = "txtKGTotales"
        Me.txtKGTotales.Size = New System.Drawing.Size(77, 26)
        Me.txtKGTotales.TabIndex = 67
        Me.txtKGTotales.Text = "0.00"
        Me.txtKGTotales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Moccasin
        Me.Label6.Location = New System.Drawing.Point(34, 316)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 16)
        Me.Label6.TabIndex = 87
        Me.Label6.Text = "  Restricciones  "
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Moccasin
        Me.Label4.Location = New System.Drawing.Point(5, 323)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(832, 5)
        Me.Label4.TabIndex = 86
        '
        'dgvRestricciones
        '
        Me.dgvRestricciones.AllowUserToAddRows = False
        Me.dgvRestricciones.AllowUserToDeleteRows = False
        Me.dgvRestricciones.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Tomato
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvRestricciones.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvRestricciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvRestricciones.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.dgvRestricciones.Cursor = System.Windows.Forms.Cursors.Default
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Snow
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Tomato
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Snow
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvRestricciones.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvRestricciones.Location = New System.Drawing.Point(6, 337)
        Me.dgvRestricciones.MultiSelect = False
        Me.dgvRestricciones.Name = "dgvRestricciones"
        Me.dgvRestricciones.ReadOnly = True
        Me.dgvRestricciones.RowHeadersVisible = False
        Me.dgvRestricciones.RowHeadersWidth = 40
        Me.dgvRestricciones.RowTemplate.Height = 25
        Me.dgvRestricciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRestricciones.Size = New System.Drawing.Size(836, 227)
        Me.dgvRestricciones.TabIndex = 85
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Moccasin
        Me.Label3.Location = New System.Drawing.Point(34, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(200, 16)
        Me.Label3.TabIndex = 83
        Me.Label3.Text = "  Alimentos Seleccionados  "
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Moccasin
        Me.Label5.Location = New System.Drawing.Point(10, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(832, 5)
        Me.Label5.TabIndex = 82
        '
        'dgvRacion
        '
        Me.dgvRacion.AllowUserToAddRows = False
        Me.dgvRacion.AllowUserToDeleteRows = False
        Me.dgvRacion.AllowUserToResizeRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Green
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.dgvRacion.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvRacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvRacion.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.dgvRacion.Cursor = System.Windows.Forms.Cursors.Default
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Snow
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Green
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Snow
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvRacion.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvRacion.Location = New System.Drawing.Point(6, 79)
        Me.dgvRacion.MultiSelect = False
        Me.dgvRacion.Name = "dgvRacion"
        Me.dgvRacion.ReadOnly = True
        Me.dgvRacion.RowHeadersVisible = False
        Me.dgvRacion.RowHeadersWidth = 40
        Me.dgvRacion.RowTemplate.Height = 25
        Me.dgvRacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRacion.Size = New System.Drawing.Size(837, 224)
        Me.dgvRacion.TabIndex = 81
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.LightSlateGray
        Me.Label13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Moccasin
        Me.Label13.Location = New System.Drawing.Point(756, 18)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(81, 25)
        Me.Label13.TabIndex = 79
        Me.Label13.Text = "Kg/Anim/Día"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMsg
        '
        Me.lblMsg.BackColor = System.Drawing.Color.LightSlateGray
        Me.lblMsg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMsg.Font = New System.Drawing.Font("Hobo Std", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsg.ForeColor = System.Drawing.Color.Moccasin
        Me.lblMsg.Location = New System.Drawing.Point(6, 12)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(569, 40)
        Me.lblMsg.TabIndex = 74
        Me.lblMsg.Text = "RACIONES"
        Me.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.LightSlateGray
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Moccasin
        Me.Label1.Location = New System.Drawing.Point(587, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 24)
        Me.Label1.TabIndex = 73
        Me.Label1.Text = "GPV Objetivo"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pbxAggAliemnto
        '
        Me.pbxAggAliemnto.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbxAggAliemnto.BackColor = System.Drawing.Color.Transparent
        Me.pbxAggAliemnto.BackgroundImage = Global.SITRABO.My.Resources.Resources.btnAlimentosNo
        Me.pbxAggAliemnto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxAggAliemnto.Location = New System.Drawing.Point(541, 570)
        Me.pbxAggAliemnto.Name = "pbxAggAliemnto"
        Me.pbxAggAliemnto.Size = New System.Drawing.Size(91, 60)
        Me.pbxAggAliemnto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxAggAliemnto.TabIndex = 27
        Me.pbxAggAliemnto.TabStop = False
        '
        'pbxAggRestricciones
        '
        Me.pbxAggRestricciones.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbxAggRestricciones.BackColor = System.Drawing.Color.Transparent
        Me.pbxAggRestricciones.BackgroundImage = Global.SITRABO.My.Resources.Resources.btnRestriccionesNo
        Me.pbxAggRestricciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxAggRestricciones.Location = New System.Drawing.Point(649, 570)
        Me.pbxAggRestricciones.Name = "pbxAggRestricciones"
        Me.pbxAggRestricciones.Size = New System.Drawing.Size(90, 60)
        Me.pbxAggRestricciones.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxAggRestricciones.TabIndex = 26
        Me.pbxAggRestricciones.TabStop = False
        '
        'pbxFormular
        '
        Me.pbxFormular.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbxFormular.BackColor = System.Drawing.Color.Transparent
        Me.pbxFormular.BackgroundImage = Global.SITRABO.My.Resources.Resources.btnFormularNo
        Me.pbxFormular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxFormular.Location = New System.Drawing.Point(754, 570)
        Me.pbxFormular.Name = "pbxFormular"
        Me.pbxFormular.Size = New System.Drawing.Size(88, 60)
        Me.pbxFormular.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxFormular.TabIndex = 11
        Me.pbxFormular.TabStop = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.LightSlateGray
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Hobo Std", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Moccasin
        Me.Label2.Location = New System.Drawing.Point(581, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(261, 40)
        Me.Label2.TabIndex = 84
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gbxPantallaInicio
        '
        Me.gbxPantallaInicio.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxPantallaInicio.BackColor = System.Drawing.Color.Transparent
        Me.gbxPantallaInicio.BackgroundImage = Global.SITRABO.My.Resources.Resources.Panel1
        Me.gbxPantallaInicio.Controls.Add(Me.Label9)
        Me.gbxPantallaInicio.Controls.Add(Me.Label8)
        Me.gbxPantallaInicio.Controls.Add(Me.pbxLogo)
        Me.gbxPantallaInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxPantallaInicio.Location = New System.Drawing.Point(219, 12)
        Me.gbxPantallaInicio.Name = "gbxPantallaInicio"
        Me.gbxPantallaInicio.Size = New System.Drawing.Size(850, 636)
        Me.gbxPantallaInicio.TabIndex = 43
        Me.gbxPantallaInicio.TabStop = False
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Gray
        Me.Label9.Location = New System.Drawing.Point(210, 591)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(443, 20)
        Me.Label9.TabIndex = 74
        Me.Label9.Text = "*Presiona ""Modificar"" para editar una alimentacion existente"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Gray
        Me.Label8.Location = New System.Drawing.Point(210, 562)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(443, 20)
        Me.Label8.TabIndex = 73
        Me.Label8.Text = "*Presiona ""Nuevo"" para registrar una alimentacion nueva"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbxLogo
        '
        Me.pbxLogo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbxLogo.BackColor = System.Drawing.Color.Transparent
        Me.pbxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pbxLogo.Image = Global.SITRABO.My.Resources.Resources.Logo1
        Me.pbxLogo.Location = New System.Drawing.Point(62, 238)
        Me.pbxLogo.Name = "pbxLogo"
        Me.pbxLogo.Size = New System.Drawing.Size(751, 172)
        Me.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxLogo.TabIndex = 7
        Me.pbxLogo.TabStop = False
        '
        'pbxSalir
        '
        Me.pbxSalir.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbxSalir.BackColor = System.Drawing.Color.Transparent
        Me.pbxSalir.BackgroundImage = Global.SITRABO.My.Resources.Resources.btnSalirNo
        Me.pbxSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxSalir.Location = New System.Drawing.Point(23, 506)
        Me.pbxSalir.Name = "pbxSalir"
        Me.pbxSalir.Size = New System.Drawing.Size(160, 116)
        Me.pbxSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxSalir.TabIndex = 6
        Me.pbxSalir.TabStop = False
        '
        'pbxModificar
        '
        Me.pbxModificar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbxModificar.BackColor = System.Drawing.Color.Transparent
        Me.pbxModificar.BackgroundImage = Global.SITRABO.My.Resources.Resources.btnModificarNo
        Me.pbxModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxModificar.Location = New System.Drawing.Point(23, 140)
        Me.pbxModificar.Name = "pbxModificar"
        Me.pbxModificar.Size = New System.Drawing.Size(160, 116)
        Me.pbxModificar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxModificar.TabIndex = 7
        Me.pbxModificar.TabStop = False
        '
        'pbxGuardar
        '
        Me.pbxGuardar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbxGuardar.BackColor = System.Drawing.Color.Transparent
        Me.pbxGuardar.BackgroundImage = Global.SITRABO.My.Resources.Resources.btnGuardarNo
        Me.pbxGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxGuardar.Enabled = False
        Me.pbxGuardar.Location = New System.Drawing.Point(23, 262)
        Me.pbxGuardar.Name = "pbxGuardar"
        Me.pbxGuardar.Size = New System.Drawing.Size(160, 116)
        Me.pbxGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxGuardar.TabIndex = 9
        Me.pbxGuardar.TabStop = False
        '
        'pbxCancelar
        '
        Me.pbxCancelar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbxCancelar.BackColor = System.Drawing.Color.Transparent
        Me.pbxCancelar.BackgroundImage = Global.SITRABO.My.Resources.Resources.btnCancelarNo
        Me.pbxCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxCancelar.Enabled = False
        Me.pbxCancelar.Location = New System.Drawing.Point(23, 384)
        Me.pbxCancelar.Name = "pbxCancelar"
        Me.pbxCancelar.Size = New System.Drawing.Size(160, 116)
        Me.pbxCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxCancelar.TabIndex = 10
        Me.pbxCancelar.TabStop = False
        '
        'pbxNuevo
        '
        Me.pbxNuevo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbxNuevo.BackColor = System.Drawing.Color.Transparent
        Me.pbxNuevo.BackgroundImage = Global.SITRABO.My.Resources.Resources.btnNuevoNo
        Me.pbxNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxNuevo.Location = New System.Drawing.Point(23, 18)
        Me.pbxNuevo.Name = "pbxNuevo"
        Me.pbxNuevo.Size = New System.Drawing.Size(160, 116)
        Me.pbxNuevo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxNuevo.TabIndex = 8
        Me.pbxNuevo.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.BackgroundImage = Global.SITRABO.My.Resources.Resources.Panel1
        Me.GroupBox1.Controls.Add(Me.pbxNuevo)
        Me.GroupBox1.Controls.Add(Me.pbxCancelar)
        Me.GroupBox1.Controls.Add(Me.pbxGuardar)
        Me.GroupBox1.Controls.Add(Me.pbxModificar)
        Me.GroupBox1.Controls.Add(Me.pbxSalir)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(207, 636)
        Me.GroupBox1.TabIndex = 44
        Me.GroupBox1.TabStop = False
        '
        'frmRaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(1081, 660)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbxRaciones)
        Me.Controls.Add(Me.gbxPantallaInicio)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmRaciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmRaciones"
        Me.gbxRaciones.ResumeLayout(False)
        Me.gbxRaciones.PerformLayout()
        CType(Me.dgvRestricciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvRacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxAggAliemnto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxAggRestricciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxFormular, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxPantallaInicio.ResumeLayout(False)
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxSalir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxModificar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxGuardar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxCancelar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxNuevo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label9 As Label
    Friend WithEvents pbxLogo As PictureBox
    Friend WithEvents gbxPantallaInicio As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents gbxRaciones As GroupBox
    Friend WithEvents pbxAggAliemnto As PictureBox
    Friend WithEvents pbxAggRestricciones As PictureBox
    Friend WithEvents pbxFormular As PictureBox
    Friend WithEvents txtKGTotales As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblMsg As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents dgvRacion As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dgvRestricciones As DataGridView
    Friend WithEvents pbxSalir As PictureBox
    Friend WithEvents pbxModificar As PictureBox
    Friend WithEvents pbxGuardar As PictureBox
    Friend WithEvents pbxCancelar As PictureBox
    Friend WithEvents pbxNuevo As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
End Class
