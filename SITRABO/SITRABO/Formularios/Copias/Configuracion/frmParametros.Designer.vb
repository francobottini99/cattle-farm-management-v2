<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmParametros
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmParametros))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.pbxTablaADPV = New System.Windows.Forms.PictureBox()
        Me.pbxTablaConsumo = New System.Windows.Forms.PictureBox()
        Me.pbxSalir = New System.Windows.Forms.PictureBox()
        Me.gbxDatos = New System.Windows.Forms.GroupBox()
        Me.gbxParametros = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPesoFinal = New System.Windows.Forms.TextBox()
        Me.txtPesoInicial = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCoefConsumo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pbxNuevaTablaADPV = New System.Windows.Forms.PictureBox()
        Me.dgvTablas = New System.Windows.Forms.DataGridView()
        Me.lblMensaje = New System.Windows.Forms.Label()
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pbxTablaADPV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxTablaConsumo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxDatos.SuspendLayout()
        Me.gbxParametros.SuspendLayout()
        CType(Me.pbxNuevaTablaADPV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvTablas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.BackgroundImage = Global.SITRABO.My.Resources.Resources.Panel1
        Me.GroupBox1.Controls.Add(Me.pbxTablaADPV)
        Me.GroupBox1.Controls.Add(Me.pbxTablaConsumo)
        Me.GroupBox1.Controls.Add(Me.pbxSalir)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(207, 636)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        '
        'pbxTablaADPV
        '
        Me.pbxTablaADPV.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbxTablaADPV.BackColor = System.Drawing.Color.Transparent
        Me.pbxTablaADPV.BackgroundImage = Global.SITRABO.My.Resources.Resources.btnADPVNo
        Me.pbxTablaADPV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxTablaADPV.Location = New System.Drawing.Point(23, 18)
        Me.pbxTablaADPV.Name = "pbxTablaADPV"
        Me.pbxTablaADPV.Size = New System.Drawing.Size(160, 116)
        Me.pbxTablaADPV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxTablaADPV.TabIndex = 8
        Me.pbxTablaADPV.TabStop = False
        '
        'pbxTablaConsumo
        '
        Me.pbxTablaConsumo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbxTablaConsumo.BackColor = System.Drawing.Color.Transparent
        Me.pbxTablaConsumo.BackgroundImage = Global.SITRABO.My.Resources.Resources.btnConsumoNo
        Me.pbxTablaConsumo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxTablaConsumo.Location = New System.Drawing.Point(23, 140)
        Me.pbxTablaConsumo.Name = "pbxTablaConsumo"
        Me.pbxTablaConsumo.Size = New System.Drawing.Size(160, 116)
        Me.pbxTablaConsumo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxTablaConsumo.TabIndex = 7
        Me.pbxTablaConsumo.TabStop = False
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
        'gbxDatos
        '
        Me.gbxDatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxDatos.BackColor = System.Drawing.Color.Transparent
        Me.gbxDatos.BackgroundImage = Global.SITRABO.My.Resources.Resources.Panel1
        Me.gbxDatos.Controls.Add(Me.gbxParametros)
        Me.gbxDatos.Controls.Add(Me.pbxNuevaTablaADPV)
        Me.gbxDatos.Controls.Add(Me.dgvTablas)
        Me.gbxDatos.Controls.Add(Me.lblMensaje)
        Me.gbxDatos.Controls.Add(Me.lblMsg)
        Me.gbxDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxDatos.Location = New System.Drawing.Point(225, 12)
        Me.gbxDatos.Name = "gbxDatos"
        Me.gbxDatos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.gbxDatos.Size = New System.Drawing.Size(850, 636)
        Me.gbxDatos.TabIndex = 21
        Me.gbxDatos.TabStop = False
        '
        'gbxParametros
        '
        Me.gbxParametros.Controls.Add(Me.Label4)
        Me.gbxParametros.Controls.Add(Me.txtPesoFinal)
        Me.gbxParametros.Controls.Add(Me.txtPesoInicial)
        Me.gbxParametros.Controls.Add(Me.Label3)
        Me.gbxParametros.Controls.Add(Me.Label2)
        Me.gbxParametros.Controls.Add(Me.txtCoefConsumo)
        Me.gbxParametros.Controls.Add(Me.Label1)
        Me.gbxParametros.Location = New System.Drawing.Point(182, 65)
        Me.gbxParametros.Name = "gbxParametros"
        Me.gbxParametros.Size = New System.Drawing.Size(650, 116)
        Me.gbxParametros.TabIndex = 27
        Me.gbxParametros.TabStop = False
        Me.gbxParametros.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Moccasin
        Me.Label4.Location = New System.Drawing.Point(23, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 16)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Peso Final"
        '
        'txtPesoFinal
        '
        Me.txtPesoFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPesoFinal.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtPesoFinal.Location = New System.Drawing.Point(118, 72)
        Me.txtPesoFinal.MaxLength = 250
        Me.txtPesoFinal.Name = "txtPesoFinal"
        Me.txtPesoFinal.Size = New System.Drawing.Size(109, 22)
        Me.txtPesoFinal.TabIndex = 34
        Me.txtPesoFinal.Text = "0"
        Me.txtPesoFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPesoInicial
        '
        Me.txtPesoInicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPesoInicial.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtPesoInicial.Location = New System.Drawing.Point(118, 30)
        Me.txtPesoInicial.MaxLength = 250
        Me.txtPesoInicial.Name = "txtPesoInicial"
        Me.txtPesoInicial.Size = New System.Drawing.Size(109, 22)
        Me.txtPesoInicial.TabIndex = 33
        Me.txtPesoInicial.Text = "0"
        Me.txtPesoInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Moccasin
        Me.Label3.Location = New System.Drawing.Point(23, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 16)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Peso Inicial"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Moccasin
        Me.Label2.Location = New System.Drawing.Point(493, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 16)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "% Peso Vivo"
        '
        'txtCoefConsumo
        '
        Me.txtCoefConsumo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCoefConsumo.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtCoefConsumo.Location = New System.Drawing.Point(378, 30)
        Me.txtCoefConsumo.MaxLength = 250
        Me.txtCoefConsumo.Name = "txtCoefConsumo"
        Me.txtCoefConsumo.Size = New System.Drawing.Size(109, 22)
        Me.txtCoefConsumo.TabIndex = 30
        Me.txtCoefConsumo.Text = "0.00"
        Me.txtCoefConsumo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Moccasin
        Me.Label1.Location = New System.Drawing.Point(260, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 16)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Coef. Consumo"
        '
        'pbxNuevaTablaADPV
        '
        Me.pbxNuevaTablaADPV.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbxNuevaTablaADPV.BackColor = System.Drawing.Color.Transparent
        Me.pbxNuevaTablaADPV.BackgroundImage = Global.SITRABO.My.Resources.Resources.btnNuevoADPVNo
        Me.pbxNuevaTablaADPV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxNuevaTablaADPV.Location = New System.Drawing.Point(16, 67)
        Me.pbxNuevaTablaADPV.Name = "pbxNuevaTablaADPV"
        Me.pbxNuevaTablaADPV.Size = New System.Drawing.Size(160, 116)
        Me.pbxNuevaTablaADPV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxNuevaTablaADPV.TabIndex = 26
        Me.pbxNuevaTablaADPV.TabStop = False
        Me.pbxNuevaTablaADPV.Visible = False
        '
        'dgvTablas
        '
        Me.dgvTablas.AllowUserToAddRows = False
        Me.dgvTablas.AllowUserToDeleteRows = False
        Me.dgvTablas.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Bisque
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGoldenrod
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvTablas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvTablas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTablas.BackgroundColor = System.Drawing.Color.BurlyWood
        Me.dgvTablas.Cursor = System.Windows.Forms.Cursors.Default
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Tan
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGoldenrod
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTablas.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvTablas.Location = New System.Drawing.Point(12, 191)
        Me.dgvTablas.MultiSelect = False
        Me.dgvTablas.Name = "dgvTablas"
        Me.dgvTablas.ReadOnly = True
        Me.dgvTablas.RowHeadersVisible = False
        Me.dgvTablas.RowHeadersWidth = 100
        Me.dgvTablas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTablas.Size = New System.Drawing.Size(826, 380)
        Me.dgvTablas.TabIndex = 25
        Me.dgvTablas.Visible = False
        '
        'lblMensaje
        '
        Me.lblMensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensaje.ForeColor = System.Drawing.Color.Orange
        Me.lblMensaje.Location = New System.Drawing.Point(9, 586)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMensaje.Size = New System.Drawing.Size(829, 36)
        Me.lblMensaje.TabIndex = 24
        Me.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblMensaje.Visible = False
        '
        'lblMsg
        '
        Me.lblMsg.BackColor = System.Drawing.Color.LightSlateGray
        Me.lblMsg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMsg.Font = New System.Drawing.Font("Hobo Std", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsg.ForeColor = System.Drawing.Color.Moccasin
        Me.lblMsg.Location = New System.Drawing.Point(16, 18)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(816, 38)
        Me.lblMsg.TabIndex = 23
        Me.lblMsg.Text = "PARAMETROS DE SISTEMA"
        Me.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmParametros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(1081, 660)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbxDatos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmParametros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmParametros"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.pbxTablaADPV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxTablaConsumo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxSalir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxDatos.ResumeLayout(False)
        Me.gbxParametros.ResumeLayout(False)
        Me.gbxParametros.PerformLayout()
        CType(Me.pbxNuevaTablaADPV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvTablas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblMsg As System.Windows.Forms.Label
    Friend WithEvents gbxDatos As System.Windows.Forms.GroupBox
    Friend WithEvents lblMensaje As System.Windows.Forms.Label
    Friend WithEvents pbxSalir As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents pbxTablaADPV As System.Windows.Forms.PictureBox
    Friend WithEvents pbxTablaConsumo As System.Windows.Forms.PictureBox
    Friend WithEvents dgvTablas As System.Windows.Forms.DataGridView
    Friend WithEvents pbxNuevaTablaADPV As System.Windows.Forms.PictureBox
    Friend WithEvents gbxParametros As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCoefConsumo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPesoFinal As System.Windows.Forms.TextBox
    Friend WithEvents txtPesoInicial As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
