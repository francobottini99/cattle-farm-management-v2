<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConcAlimDetalle
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series5 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConcAlimDetalle))
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.gbxConsFechas = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblPorTot = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblImpTot = New System.Windows.Forms.Label()
        Me.lblKgTot = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblPorOtr = New System.Windows.Forms.Label()
        Me.lblPorFib = New System.Windows.Forms.Label()
        Me.lblPorConc = New System.Windows.Forms.Label()
        Me.lblPorGrano = New System.Windows.Forms.Label()
        Me.lblImpOtr = New System.Windows.Forms.Label()
        Me.lblImpFib = New System.Windows.Forms.Label()
        Me.lblImpConc = New System.Windows.Forms.Label()
        Me.lblImpGrano = New System.Windows.Forms.Label()
        Me.lblKgOtr = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.lblKgFib = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.lblKgConc = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.lblKgGrano = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.grpGrafico = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.gbxConsFechas.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grpGrafico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMsg
        '
        Me.lblMsg.BackColor = System.Drawing.Color.SaddleBrown
        Me.lblMsg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMsg.Font = New System.Drawing.Font("Hobo Std", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsg.ForeColor = System.Drawing.Color.Moccasin
        Me.lblMsg.Location = New System.Drawing.Point(-2, -3)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(1203, 46)
        Me.lblMsg.TabIndex = 94
        Me.lblMsg.Text = "CONSULTAS - ALIMENTACION : GRAFICO - CONSUMO POR TROPA"
        Me.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gbxConsFechas
        '
        Me.gbxConsFechas.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.gbxConsFechas.BackColor = System.Drawing.Color.Transparent
        Me.gbxConsFechas.BackgroundImage = Global.SITRABO.My.Resources.Resources.Panel1
        Me.gbxConsFechas.Controls.Add(Me.GroupBox1)
        Me.gbxConsFechas.Controls.Add(Me.grpGrafico)
        Me.gbxConsFechas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxConsFechas.ForeColor = System.Drawing.Color.White
        Me.gbxConsFechas.Location = New System.Drawing.Point(-2, 41)
        Me.gbxConsFechas.Name = "gbxConsFechas"
        Me.gbxConsFechas.Size = New System.Drawing.Size(1203, 590)
        Me.gbxConsFechas.TabIndex = 95
        Me.gbxConsFechas.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.lblPorTot)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.lblImpTot)
        Me.GroupBox1.Controls.Add(Me.lblKgTot)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lblPorOtr)
        Me.GroupBox1.Controls.Add(Me.lblPorFib)
        Me.GroupBox1.Controls.Add(Me.lblPorConc)
        Me.GroupBox1.Controls.Add(Me.lblPorGrano)
        Me.GroupBox1.Controls.Add(Me.lblImpOtr)
        Me.GroupBox1.Controls.Add(Me.lblImpFib)
        Me.GroupBox1.Controls.Add(Me.lblImpConc)
        Me.GroupBox1.Controls.Add(Me.lblImpGrano)
        Me.GroupBox1.Controls.Add(Me.lblKgOtr)
        Me.GroupBox1.Controls.Add(Me.Label36)
        Me.GroupBox1.Controls.Add(Me.lblKgFib)
        Me.GroupBox1.Controls.Add(Me.Label38)
        Me.GroupBox1.Controls.Add(Me.lblKgConc)
        Me.GroupBox1.Controls.Add(Me.Label40)
        Me.GroupBox1.Controls.Add(Me.lblKgGrano)
        Me.GroupBox1.Controls.Add(Me.Label42)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkOrange
        Me.GroupBox1.Location = New System.Drawing.Point(8, 421)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1188, 161)
        Me.GroupBox1.TabIndex = 91
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "  Totales Generales  "
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Moccasin
        Me.Label6.Location = New System.Drawing.Point(113, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(146, 29)
        Me.Label6.TabIndex = 122
        Me.Label6.Text = "IMPORTE ($)"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPorTot
        '
        Me.lblPorTot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPorTot.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPorTot.ForeColor = System.Drawing.Color.Red
        Me.lblPorTot.Location = New System.Drawing.Point(873, 84)
        Me.lblPorTot.Name = "lblPorTot"
        Me.lblPorTot.Size = New System.Drawing.Size(198, 29)
        Me.lblPorTot.TabIndex = 121
        Me.lblPorTot.Text = "0.00"
        Me.lblPorTot.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Moccasin
        Me.Label10.Location = New System.Drawing.Point(113, 84)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(146, 29)
        Me.Label10.TabIndex = 120
        Me.Label10.Text = "PORCENTAJE"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Moccasin
        Me.Label7.Location = New System.Drawing.Point(113, 49)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(146, 29)
        Me.Label7.TabIndex = 119
        Me.Label7.Text = "KILOGRAMOS"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblImpTot
        '
        Me.lblImpTot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblImpTot.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImpTot.ForeColor = System.Drawing.Color.Red
        Me.lblImpTot.Location = New System.Drawing.Point(873, 120)
        Me.lblImpTot.Name = "lblImpTot"
        Me.lblImpTot.Size = New System.Drawing.Size(198, 29)
        Me.lblImpTot.TabIndex = 118
        Me.lblImpTot.Text = "0.00"
        Me.lblImpTot.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblKgTot
        '
        Me.lblKgTot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblKgTot.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKgTot.ForeColor = System.Drawing.Color.Red
        Me.lblKgTot.Location = New System.Drawing.Point(873, 49)
        Me.lblKgTot.Name = "lblKgTot"
        Me.lblKgTot.Size = New System.Drawing.Size(198, 29)
        Me.lblKgTot.TabIndex = 116
        Me.lblKgTot.Text = "0.00"
        Me.lblKgTot.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Moccasin
        Me.Label4.Location = New System.Drawing.Point(873, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(198, 29)
        Me.Label4.TabIndex = 115
        Me.Label4.Text = "TOTALES"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPorOtr
        '
        Me.lblPorOtr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPorOtr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPorOtr.ForeColor = System.Drawing.Color.DarkOrange
        Me.lblPorOtr.Location = New System.Drawing.Point(721, 84)
        Me.lblPorOtr.Name = "lblPorOtr"
        Me.lblPorOtr.Size = New System.Drawing.Size(146, 29)
        Me.lblPorOtr.TabIndex = 114
        Me.lblPorOtr.Text = "0.00"
        Me.lblPorOtr.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPorFib
        '
        Me.lblPorFib.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPorFib.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPorFib.ForeColor = System.Drawing.Color.DarkOrange
        Me.lblPorFib.Location = New System.Drawing.Point(569, 84)
        Me.lblPorFib.Name = "lblPorFib"
        Me.lblPorFib.Size = New System.Drawing.Size(146, 29)
        Me.lblPorFib.TabIndex = 112
        Me.lblPorFib.Text = "0.00"
        Me.lblPorFib.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPorConc
        '
        Me.lblPorConc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPorConc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPorConc.ForeColor = System.Drawing.Color.DarkOrange
        Me.lblPorConc.Location = New System.Drawing.Point(417, 84)
        Me.lblPorConc.Name = "lblPorConc"
        Me.lblPorConc.Size = New System.Drawing.Size(146, 29)
        Me.lblPorConc.TabIndex = 110
        Me.lblPorConc.Text = "0.00"
        Me.lblPorConc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPorGrano
        '
        Me.lblPorGrano.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPorGrano.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPorGrano.ForeColor = System.Drawing.Color.DarkOrange
        Me.lblPorGrano.Location = New System.Drawing.Point(265, 84)
        Me.lblPorGrano.Name = "lblPorGrano"
        Me.lblPorGrano.Size = New System.Drawing.Size(146, 29)
        Me.lblPorGrano.TabIndex = 108
        Me.lblPorGrano.Text = "0.00"
        Me.lblPorGrano.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblImpOtr
        '
        Me.lblImpOtr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblImpOtr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImpOtr.ForeColor = System.Drawing.Color.DarkOrange
        Me.lblImpOtr.Location = New System.Drawing.Point(721, 120)
        Me.lblImpOtr.Name = "lblImpOtr"
        Me.lblImpOtr.Size = New System.Drawing.Size(146, 29)
        Me.lblImpOtr.TabIndex = 106
        Me.lblImpOtr.Text = "0.00"
        Me.lblImpOtr.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblImpFib
        '
        Me.lblImpFib.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblImpFib.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImpFib.ForeColor = System.Drawing.Color.DarkOrange
        Me.lblImpFib.Location = New System.Drawing.Point(569, 120)
        Me.lblImpFib.Name = "lblImpFib"
        Me.lblImpFib.Size = New System.Drawing.Size(146, 29)
        Me.lblImpFib.TabIndex = 104
        Me.lblImpFib.Text = "0.00"
        Me.lblImpFib.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblImpConc
        '
        Me.lblImpConc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblImpConc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImpConc.ForeColor = System.Drawing.Color.DarkOrange
        Me.lblImpConc.Location = New System.Drawing.Point(417, 120)
        Me.lblImpConc.Name = "lblImpConc"
        Me.lblImpConc.Size = New System.Drawing.Size(146, 29)
        Me.lblImpConc.TabIndex = 102
        Me.lblImpConc.Text = "0.00"
        Me.lblImpConc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblImpGrano
        '
        Me.lblImpGrano.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblImpGrano.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImpGrano.ForeColor = System.Drawing.Color.DarkOrange
        Me.lblImpGrano.Location = New System.Drawing.Point(265, 120)
        Me.lblImpGrano.Name = "lblImpGrano"
        Me.lblImpGrano.Size = New System.Drawing.Size(146, 29)
        Me.lblImpGrano.TabIndex = 100
        Me.lblImpGrano.Text = "0.00"
        Me.lblImpGrano.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblKgOtr
        '
        Me.lblKgOtr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblKgOtr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKgOtr.ForeColor = System.Drawing.Color.DarkOrange
        Me.lblKgOtr.Location = New System.Drawing.Point(721, 49)
        Me.lblKgOtr.Name = "lblKgOtr"
        Me.lblKgOtr.Size = New System.Drawing.Size(146, 29)
        Me.lblKgOtr.TabIndex = 98
        Me.lblKgOtr.Text = "0.00"
        Me.lblKgOtr.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label36
        '
        Me.Label36.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.Moccasin
        Me.Label36.Location = New System.Drawing.Point(721, 16)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(146, 29)
        Me.Label36.TabIndex = 97
        Me.Label36.Text = "OTROS"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblKgFib
        '
        Me.lblKgFib.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblKgFib.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKgFib.ForeColor = System.Drawing.Color.DarkOrange
        Me.lblKgFib.Location = New System.Drawing.Point(569, 49)
        Me.lblKgFib.Name = "lblKgFib"
        Me.lblKgFib.Size = New System.Drawing.Size(146, 29)
        Me.lblKgFib.TabIndex = 96
        Me.lblKgFib.Text = "0.00"
        Me.lblKgFib.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label38
        '
        Me.Label38.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.Moccasin
        Me.Label38.Location = New System.Drawing.Point(569, 16)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(146, 29)
        Me.Label38.TabIndex = 95
        Me.Label38.Text = "FIBRA"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblKgConc
        '
        Me.lblKgConc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblKgConc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKgConc.ForeColor = System.Drawing.Color.DarkOrange
        Me.lblKgConc.Location = New System.Drawing.Point(417, 49)
        Me.lblKgConc.Name = "lblKgConc"
        Me.lblKgConc.Size = New System.Drawing.Size(146, 29)
        Me.lblKgConc.TabIndex = 94
        Me.lblKgConc.Text = "0.00"
        Me.lblKgConc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label40
        '
        Me.Label40.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.Color.Moccasin
        Me.Label40.Location = New System.Drawing.Point(417, 15)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(146, 29)
        Me.Label40.TabIndex = 93
        Me.Label40.Text = "CONCENTRADO"
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblKgGrano
        '
        Me.lblKgGrano.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblKgGrano.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKgGrano.ForeColor = System.Drawing.Color.DarkOrange
        Me.lblKgGrano.Location = New System.Drawing.Point(265, 49)
        Me.lblKgGrano.Name = "lblKgGrano"
        Me.lblKgGrano.Size = New System.Drawing.Size(146, 29)
        Me.lblKgGrano.TabIndex = 92
        Me.lblKgGrano.Text = "0.00"
        Me.lblKgGrano.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label42
        '
        Me.Label42.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.Color.Moccasin
        Me.Label42.Location = New System.Drawing.Point(265, 16)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(146, 29)
        Me.Label42.TabIndex = 91
        Me.Label42.Text = "GRANOS"
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpGrafico
        '
        ChartArea1.AxisX.InterlacedColor = System.Drawing.Color.Moccasin
        ChartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount
        ChartArea1.AxisX.IsInterlaced = True
        ChartArea1.AxisX.IsLabelAutoFit = False
        ChartArea1.AxisX.LabelStyle.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea1.AxisX.MaximumAutoSize = 100.0!
        ChartArea1.AxisX.ScaleBreakStyle.Spacing = 1.0R
        ChartArea1.AxisX.Title = "Tropa"
        ChartArea1.AxisY.IsLabelAutoFit = False
        ChartArea1.AxisY.LabelStyle.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea1.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal
        ChartArea1.AxisY.Title = "$"
        ChartArea1.Name = "ChartArea1"
        Me.grpGrafico.ChartAreas.Add(ChartArea1)
        Legend1.Alignment = System.Drawing.StringAlignment.Center
        Legend1.Name = "Legend1"
        Me.grpGrafico.Legends.Add(Legend1)
        Me.grpGrafico.Location = New System.Drawing.Point(6, 14)
        Me.grpGrafico.Name = "grpGrafico"
        Me.grpGrafico.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate
        Series1.ChartArea = "ChartArea1"
        Series1.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series1.IsVisibleInLegend = False
        Series1.Legend = "Legend1"
        Series1.Name = "ConsTotal"
        Series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.[Double]
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "ConsGrano"
        Series3.ChartArea = "ChartArea1"
        Series3.Legend = "Legend1"
        Series3.Name = "ConsConc"
        Series4.ChartArea = "ChartArea1"
        Series4.Legend = "Legend1"
        Series4.Name = "ConsFibra"
        Series5.ChartArea = "ChartArea1"
        Series5.Legend = "Legend1"
        Series5.Name = "ConsOtros"
        Me.grpGrafico.Series.Add(Series1)
        Me.grpGrafico.Series.Add(Series2)
        Me.grpGrafico.Series.Add(Series3)
        Me.grpGrafico.Series.Add(Series4)
        Me.grpGrafico.Series.Add(Series5)
        Me.grpGrafico.Size = New System.Drawing.Size(1190, 401)
        Me.grpGrafico.TabIndex = 24
        Me.grpGrafico.Text = "Chart3"
        '
        'frmConcAlimDetalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(1199, 631)
        Me.Controls.Add(Me.gbxConsFechas)
        Me.Controls.Add(Me.lblMsg)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConcAlimDetalle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmConcAlimDetalle"
        Me.gbxConsFechas.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.grpGrafico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblPorTot As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblImpTot As System.Windows.Forms.Label
    Friend WithEvents lblKgTot As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblPorOtr As System.Windows.Forms.Label
    Friend WithEvents lblPorFib As System.Windows.Forms.Label
    Friend WithEvents lblPorConc As System.Windows.Forms.Label
    Friend WithEvents lblPorGrano As System.Windows.Forms.Label
    Friend WithEvents lblImpOtr As System.Windows.Forms.Label
    Friend WithEvents lblImpFib As System.Windows.Forms.Label
    Friend WithEvents lblImpConc As System.Windows.Forms.Label
    Friend WithEvents grpGrafico As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents lblImpGrano As System.Windows.Forms.Label
    Friend WithEvents lblKgOtr As System.Windows.Forms.Label
    Friend WithEvents lblKgFib As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents lblKgConc As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents lblKgGrano As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents gbxConsFechas As System.Windows.Forms.GroupBox
    Friend WithEvents lblMsg As System.Windows.Forms.Label
End Class
