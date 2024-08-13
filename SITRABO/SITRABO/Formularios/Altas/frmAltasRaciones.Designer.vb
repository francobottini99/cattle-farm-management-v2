<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAltasRaciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAltasRaciones))
        Me.dgvRaciones = New System.Windows.Forms.DataGridView()
        Me.gbxDatos = New System.Windows.Forms.GroupBox()
        Me.lblDetR = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.gbxD = New System.Windows.Forms.GroupBox()
        Me.txtCostoSilo = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtSilo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCostGrano = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtRacion = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtGrano = New System.Windows.Forms.TextBox()
        Me.txtCostOtros = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtOtros = New System.Windows.Forms.TextBox()
        Me.txtConcentrado = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCostConcentrado = New System.Windows.Forms.TextBox()
        Me.txtCostFibra = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFibra = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtOrigen = New System.Windows.Forms.TextBox()
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.pbxNuevo = New System.Windows.Forms.PictureBox()
        Me.pbxCancelar = New System.Windows.Forms.PictureBox()
        Me.pbxGuardar = New System.Windows.Forms.PictureBox()
        Me.pbxModificar = New System.Windows.Forms.PictureBox()
        Me.pbxSalir = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.dgvRaciones,System.ComponentModel.ISupportInitialize).BeginInit
        Me.gbxDatos.SuspendLayout
        Me.gbxD.SuspendLayout
        CType(Me.pbxNuevo,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.pbxCancelar,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.pbxGuardar,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.pbxModificar,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.pbxSalir,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox1.SuspendLayout
        Me.SuspendLayout
        '
        'dgvRaciones
        '
        Me.dgvRaciones.AllowUserToAddRows = false
        Me.dgvRaciones.AllowUserToDeleteRows = false
        Me.dgvRaciones.AllowUserToResizeRows = false
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Bisque
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGoldenrod
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvRaciones.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvRaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvRaciones.BackgroundColor = System.Drawing.Color.BurlyWood
        Me.dgvRaciones.ColumnHeadersVisible = false
        Me.dgvRaciones.Cursor = System.Windows.Forms.Cursors.Default
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Tan
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGoldenrod
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvRaciones.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvRaciones.Location = New System.Drawing.Point(6, 84)
        Me.dgvRaciones.MultiSelect = false
        Me.dgvRaciones.Name = "dgvRaciones"
        Me.dgvRaciones.ReadOnly = true
        Me.dgvRaciones.RowHeadersVisible = false
        Me.dgvRaciones.RowHeadersWidth = 100
        Me.dgvRaciones.Size = New System.Drawing.Size(832, 240)
        Me.dgvRaciones.TabIndex = 0
        '
        'gbxDatos
        '
        Me.gbxDatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.gbxDatos.BackColor = System.Drawing.Color.Transparent
        Me.gbxDatos.BackgroundImage = Global.SITRABO.My.Resources.Resources.Panel1
        Me.gbxDatos.Controls.Add(Me.lblDetR)
        Me.gbxDatos.Controls.Add(Me.Label16)
        Me.gbxDatos.Controls.Add(Me.gbxD)
        Me.gbxDatos.Controls.Add(Me.dgvRaciones)
        Me.gbxDatos.Controls.Add(Me.txtID)
        Me.gbxDatos.Controls.Add(Me.txtOrigen)
        Me.gbxDatos.Controls.Add(Me.lblMsg)
        Me.gbxDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.gbxDatos.Location = New System.Drawing.Point(225, 12)
        Me.gbxDatos.Name = "gbxDatos"
        Me.gbxDatos.Size = New System.Drawing.Size(844, 636)
        Me.gbxDatos.TabIndex = 24
        Me.gbxDatos.TabStop = false
        '
        'lblDetR
        '
        Me.lblDetR.AutoSize = true
        Me.lblDetR.ForeColor = System.Drawing.Color.Moccasin
        Me.lblDetR.Location = New System.Drawing.Point(27, 63)
        Me.lblDetR.Name = "lblDetR"
        Me.lblDetR.Size = New System.Drawing.Size(233, 16)
        Me.lblDetR.TabIndex = 50
        Me.lblDetR.Text = " Listado De Raciones Cargados "
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Moccasin
        Me.Label16.Location = New System.Drawing.Point(12, 69)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(825, 5)
        Me.Label16.TabIndex = 51
        '
        'gbxD
        '
        Me.gbxD.Controls.Add(Me.txtCostoSilo)
        Me.gbxD.Controls.Add(Me.Label11)
        Me.gbxD.Controls.Add(Me.Label13)
        Me.gbxD.Controls.Add(Me.txtSilo)
        Me.gbxD.Controls.Add(Me.Label1)
        Me.gbxD.Controls.Add(Me.txtCostGrano)
        Me.gbxD.Controls.Add(Me.Label10)
        Me.gbxD.Controls.Add(Me.Label2)
        Me.gbxD.Controls.Add(Me.Label9)
        Me.gbxD.Controls.Add(Me.txtRacion)
        Me.gbxD.Controls.Add(Me.Label8)
        Me.gbxD.Controls.Add(Me.Label5)
        Me.gbxD.Controls.Add(Me.Label7)
        Me.gbxD.Controls.Add(Me.txtGrano)
        Me.gbxD.Controls.Add(Me.txtCostOtros)
        Me.gbxD.Controls.Add(Me.Label3)
        Me.gbxD.Controls.Add(Me.txtOtros)
        Me.gbxD.Controls.Add(Me.txtConcentrado)
        Me.gbxD.Controls.Add(Me.Label6)
        Me.gbxD.Controls.Add(Me.txtCostConcentrado)
        Me.gbxD.Controls.Add(Me.txtCostFibra)
        Me.gbxD.Controls.Add(Me.Label4)
        Me.gbxD.Controls.Add(Me.txtFibra)
        Me.gbxD.Enabled = false
        Me.gbxD.Location = New System.Drawing.Point(6, 317)
        Me.gbxD.Name = "gbxD"
        Me.gbxD.Size = New System.Drawing.Size(832, 305)
        Me.gbxD.TabIndex = 44
        Me.gbxD.TabStop = false
        '
        'txtCostoSilo
        '
        Me.txtCostoSilo.BackColor = System.Drawing.Color.Wheat
        Me.txtCostoSilo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtCostoSilo.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtCostoSilo.Location = New System.Drawing.Point(669, 120)
        Me.txtCostoSilo.MaxLength = 45
        Me.txtCostoSilo.Name = "txtCostoSilo"
        Me.txtCostoSilo.Size = New System.Drawing.Size(104, 22)
        Me.txtCostoSilo.TabIndex = 4
        Me.txtCostoSilo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = true
        Me.Label11.ForeColor = System.Drawing.Color.Moccasin
        Me.Label11.Location = New System.Drawing.Point(32, 104)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(35, 16)
        Me.Label11.TabIndex = 44
        Me.Label11.Text = "Silo"
        '
        'Label13
        '
        Me.Label13.AutoSize = true
        Me.Label13.ForeColor = System.Drawing.Color.Moccasin
        Me.Label13.Location = New System.Drawing.Point(779, 123)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(16, 16)
        Me.Label13.TabIndex = 48
        Me.Label13.Text = "$"
        '
        'txtSilo
        '
        Me.txtSilo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtSilo.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtSilo.Location = New System.Drawing.Point(35, 123)
        Me.txtSilo.MaxLength = 250
        Me.txtSilo.Name = "txtSilo"
        Me.txtSilo.Size = New System.Drawing.Size(536, 22)
        Me.txtSilo.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.ForeColor = System.Drawing.Color.Moccasin
        Me.Label1.Location = New System.Drawing.Point(32, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 16)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Nombre Racion"
        '
        'txtCostGrano
        '
        Me.txtCostGrano.BackColor = System.Drawing.Color.Wheat
        Me.txtCostGrano.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtCostGrano.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtCostGrano.Location = New System.Drawing.Point(669, 73)
        Me.txtCostGrano.MaxLength = 45
        Me.txtCostGrano.Name = "txtCostGrano"
        Me.txtCostGrano.Size = New System.Drawing.Size(104, 22)
        Me.txtCostGrano.TabIndex = 2
        Me.txtCostGrano.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = true
        Me.Label10.ForeColor = System.Drawing.Color.Moccasin
        Me.Label10.Location = New System.Drawing.Point(779, 267)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(16, 16)
        Me.Label10.TabIndex = 43
        Me.Label10.Text = "$"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.ForeColor = System.Drawing.Color.Moccasin
        Me.Label2.Location = New System.Drawing.Point(32, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 16)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Grano"
        '
        'Label9
        '
        Me.Label9.AutoSize = true
        Me.Label9.ForeColor = System.Drawing.Color.Moccasin
        Me.Label9.Location = New System.Drawing.Point(779, 218)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(16, 16)
        Me.Label9.TabIndex = 42
        Me.Label9.Text = "$"
        '
        'txtRacion
        '
        Me.txtRacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtRacion.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtRacion.Location = New System.Drawing.Point(35, 30)
        Me.txtRacion.MaxLength = 250
        Me.txtRacion.Name = "txtRacion"
        Me.txtRacion.Size = New System.Drawing.Size(760, 22)
        Me.txtRacion.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = true
        Me.Label8.ForeColor = System.Drawing.Color.Moccasin
        Me.Label8.Location = New System.Drawing.Point(779, 169)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(16, 16)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "$"
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.ForeColor = System.Drawing.Color.Moccasin
        Me.Label5.Location = New System.Drawing.Point(692, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 16)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Costos"
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.ForeColor = System.Drawing.Color.Moccasin
        Me.Label7.Location = New System.Drawing.Point(779, 90)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(16, 16)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "$"
        '
        'txtGrano
        '
        Me.txtGrano.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtGrano.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtGrano.Location = New System.Drawing.Point(35, 76)
        Me.txtGrano.MaxLength = 250
        Me.txtGrano.Name = "txtGrano"
        Me.txtGrano.Size = New System.Drawing.Size(536, 22)
        Me.txtGrano.TabIndex = 1
        '
        'txtCostOtros
        '
        Me.txtCostOtros.BackColor = System.Drawing.Color.Wheat
        Me.txtCostOtros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtCostOtros.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtCostOtros.Location = New System.Drawing.Point(669, 264)
        Me.txtCostOtros.MaxLength = 45
        Me.txtCostOtros.Name = "txtCostOtros"
        Me.txtCostOtros.Size = New System.Drawing.Size(104, 22)
        Me.txtCostOtros.TabIndex = 10
        Me.txtCostOtros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.ForeColor = System.Drawing.Color.Moccasin
        Me.Label3.Location = New System.Drawing.Point(32, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 16)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Concentrado"
        '
        'txtOtros
        '
        Me.txtOtros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtOtros.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtOtros.Location = New System.Drawing.Point(35, 267)
        Me.txtOtros.MaxLength = 250
        Me.txtOtros.Name = "txtOtros"
        Me.txtOtros.Size = New System.Drawing.Size(536, 22)
        Me.txtOtros.TabIndex = 9
        '
        'txtConcentrado
        '
        Me.txtConcentrado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtConcentrado.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtConcentrado.Location = New System.Drawing.Point(35, 169)
        Me.txtConcentrado.MaxLength = 250
        Me.txtConcentrado.Name = "txtConcentrado"
        Me.txtConcentrado.Size = New System.Drawing.Size(536, 22)
        Me.txtConcentrado.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.ForeColor = System.Drawing.Color.Moccasin
        Me.Label6.Location = New System.Drawing.Point(32, 248)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 16)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Otros"
        '
        'txtCostConcentrado
        '
        Me.txtCostConcentrado.BackColor = System.Drawing.Color.Wheat
        Me.txtCostConcentrado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtCostConcentrado.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtCostConcentrado.Location = New System.Drawing.Point(669, 166)
        Me.txtCostConcentrado.MaxLength = 45
        Me.txtCostConcentrado.Name = "txtCostConcentrado"
        Me.txtCostConcentrado.Size = New System.Drawing.Size(104, 22)
        Me.txtCostConcentrado.TabIndex = 6
        Me.txtCostConcentrado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCostFibra
        '
        Me.txtCostFibra.BackColor = System.Drawing.Color.Wheat
        Me.txtCostFibra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtCostFibra.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtCostFibra.Location = New System.Drawing.Point(669, 215)
        Me.txtCostFibra.MaxLength = 45
        Me.txtCostFibra.Name = "txtCostFibra"
        Me.txtCostFibra.Size = New System.Drawing.Size(104, 22)
        Me.txtCostFibra.TabIndex = 8
        Me.txtCostFibra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.ForeColor = System.Drawing.Color.Moccasin
        Me.Label4.Location = New System.Drawing.Point(32, 199)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 16)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Fibra"
        '
        'txtFibra
        '
        Me.txtFibra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtFibra.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtFibra.Location = New System.Drawing.Point(35, 218)
        Me.txtFibra.MaxLength = 250
        Me.txtFibra.Name = "txtFibra"
        Me.txtFibra.Size = New System.Drawing.Size(536, 22)
        Me.txtFibra.TabIndex = 7
        '
        'txtID
        '
        Me.txtID.BackColor = System.Drawing.Color.LightCoral
        Me.txtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtID.Location = New System.Drawing.Point(730, 33)
        Me.txtID.MaxLength = 10
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(46, 20)
        Me.txtID.TabIndex = 25
        Me.txtID.Visible = false
        '
        'txtOrigen
        '
        Me.txtOrigen.BackColor = System.Drawing.Color.LightCoral
        Me.txtOrigen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtOrigen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtOrigen.Location = New System.Drawing.Point(783, 33)
        Me.txtOrigen.MaxLength = 10
        Me.txtOrigen.Name = "txtOrigen"
        Me.txtOrigen.Size = New System.Drawing.Size(46, 20)
        Me.txtOrigen.TabIndex = 24
        Me.txtOrigen.Visible = false
        '
        'lblMsg
        '
        Me.lblMsg.BackColor = System.Drawing.Color.LightSlateGray
        Me.lblMsg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMsg.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblMsg.ForeColor = System.Drawing.Color.Moccasin
        Me.lblMsg.Location = New System.Drawing.Point(6, 18)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(832, 38)
        Me.lblMsg.TabIndex = 23
        Me.lblMsg.Text = "RACION"
        Me.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.pbxNuevo.TabStop = false
        '
        'pbxCancelar
        '
        Me.pbxCancelar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbxCancelar.BackColor = System.Drawing.Color.Transparent
        Me.pbxCancelar.BackgroundImage = Global.SITRABO.My.Resources.Resources.btnCancelarNo
        Me.pbxCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxCancelar.Enabled = false
        Me.pbxCancelar.Location = New System.Drawing.Point(23, 384)
        Me.pbxCancelar.Name = "pbxCancelar"
        Me.pbxCancelar.Size = New System.Drawing.Size(160, 116)
        Me.pbxCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxCancelar.TabIndex = 10
        Me.pbxCancelar.TabStop = false
        '
        'pbxGuardar
        '
        Me.pbxGuardar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbxGuardar.BackColor = System.Drawing.Color.Transparent
        Me.pbxGuardar.BackgroundImage = Global.SITRABO.My.Resources.Resources.btnGuardarNo
        Me.pbxGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxGuardar.Enabled = false
        Me.pbxGuardar.Location = New System.Drawing.Point(23, 262)
        Me.pbxGuardar.Name = "pbxGuardar"
        Me.pbxGuardar.Size = New System.Drawing.Size(160, 116)
        Me.pbxGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxGuardar.TabIndex = 9
        Me.pbxGuardar.TabStop = false
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
        Me.pbxModificar.TabStop = false
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
        Me.pbxSalir.TabStop = false
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.BackgroundImage = Global.SITRABO.My.Resources.Resources.Panel1
        Me.GroupBox1.Controls.Add(Me.pbxNuevo)
        Me.GroupBox1.Controls.Add(Me.pbxCancelar)
        Me.GroupBox1.Controls.Add(Me.pbxGuardar)
        Me.GroupBox1.Controls.Add(Me.pbxModificar)
        Me.GroupBox1.Controls.Add(Me.pbxSalir)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(207, 636)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = false
        '
        'frmAltasRaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(1081, 660)
        Me.Controls.Add(Me.gbxDatos)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximizeBox = false
        Me.Name = "frmAltasRaciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAltasRaciones"
        CType(Me.dgvRaciones,System.ComponentModel.ISupportInitialize).EndInit
        Me.gbxDatos.ResumeLayout(false)
        Me.gbxDatos.PerformLayout
        Me.gbxD.ResumeLayout(false)
        Me.gbxD.PerformLayout
        CType(Me.pbxNuevo,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.pbxCancelar,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.pbxGuardar,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.pbxModificar,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.pbxSalir,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox1.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents dgvRaciones As System.Windows.Forms.DataGridView
    Friend WithEvents gbxDatos As System.Windows.Forms.GroupBox
    Friend WithEvents txtCostOtros As System.Windows.Forms.TextBox
    Friend WithEvents txtOtros As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCostFibra As System.Windows.Forms.TextBox
    Friend WithEvents txtFibra As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCostConcentrado As System.Windows.Forms.TextBox
    Friend WithEvents txtConcentrado As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtGrano As System.Windows.Forms.TextBox
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents txtOrigen As System.Windows.Forms.TextBox
    Friend WithEvents lblMsg As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtRacion As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCostGrano As System.Windows.Forms.TextBox
    Friend WithEvents pbxNuevo As System.Windows.Forms.PictureBox
    Friend WithEvents pbxCancelar As System.Windows.Forms.PictureBox
    Friend WithEvents pbxGuardar As System.Windows.Forms.PictureBox
    Friend WithEvents pbxModificar As System.Windows.Forms.PictureBox
    Friend WithEvents pbxSalir As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents gbxD As System.Windows.Forms.GroupBox
    Friend WithEvents lblDetR As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtCostoSilo As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtSilo As TextBox
End Class
