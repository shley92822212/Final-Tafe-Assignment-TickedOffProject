<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Statistics
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Statistics))
        Me.lblShortestStay = New System.Windows.Forms.Label()
        Me.lblLongestStay = New System.Windows.Forms.Label()
        Me.lblAverageStay = New System.Windows.Forms.Label()
        Me.lblShortestStayVar = New System.Windows.Forms.Label()
        Me.lblLongestStayVar = New System.Windows.Forms.Label()
        Me.lblAverageStayVar = New System.Windows.Forms.Label()
        Me.lbl = New System.Windows.Forms.Label()
        Me.lblLowestCost = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblHighestCost = New System.Windows.Forms.Label()
        Me.lblAverageCost = New System.Windows.Forms.Label()
        Me.lblAverageBoardingCost = New System.Windows.Forms.Label()
        Me.lblSpecies = New System.Windows.Forms.Label()
        Me.cmbSpecies = New System.Windows.Forms.ComboBox()
        Me.SpeciesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TickedoffDataSet = New TickedOffProject.tickedoffDataSet()
        Me.lblNumOfStays = New System.Windows.Forms.Label()
        Me.PetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PetTableAdapter = New TickedOffProject.tickedoffDataSetTableAdapters.petTableAdapter()
        Me.SpeciesTableAdapter = New TickedOffProject.tickedoffDataSetTableAdapters.speciesTableAdapter()
        Me.lblTotalStays = New System.Windows.Forms.Label()
        Me.lblTotalAmountPaid = New System.Windows.Forms.Label()
        Me.lblTotalPaid = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.StayTableAdapter1 = New TickedOffProject.tickedoffDataSetTableAdapters.stayTableAdapter()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripDropDownButton2 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.AboutThisCompanyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutThisApplicationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblStatistics = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnBack = New System.Windows.Forms.Button()
        CType(Me.SpeciesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TickedoffDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblShortestStay
        '
        Me.lblShortestStay.AutoSize = True
        Me.lblShortestStay.Font = New System.Drawing.Font("Verdana", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShortestStay.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblShortestStay.Location = New System.Drawing.Point(84, 346)
        Me.lblShortestStay.Name = "lblShortestStay"
        Me.lblShortestStay.Size = New System.Drawing.Size(162, 25)
        Me.lblShortestStay.TabIndex = 0
        Me.lblShortestStay.Text = "Shortest stay:"
        '
        'lblLongestStay
        '
        Me.lblLongestStay.AutoSize = True
        Me.lblLongestStay.Font = New System.Drawing.Font("Verdana", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLongestStay.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblLongestStay.Location = New System.Drawing.Point(87, 412)
        Me.lblLongestStay.Name = "lblLongestStay"
        Me.lblLongestStay.Size = New System.Drawing.Size(156, 25)
        Me.lblLongestStay.TabIndex = 1
        Me.lblLongestStay.Text = "Longest stay:"
        '
        'lblAverageStay
        '
        Me.lblAverageStay.AutoSize = True
        Me.lblAverageStay.Font = New System.Drawing.Font("Verdana", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverageStay.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblAverageStay.Location = New System.Drawing.Point(84, 476)
        Me.lblAverageStay.Name = "lblAverageStay"
        Me.lblAverageStay.Size = New System.Drawing.Size(159, 25)
        Me.lblAverageStay.TabIndex = 2
        Me.lblAverageStay.Text = "Average stay:"
        '
        'lblShortestStayVar
        '
        Me.lblShortestStayVar.AutoSize = True
        Me.lblShortestStayVar.Font = New System.Drawing.Font("Verdana", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShortestStayVar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.lblShortestStayVar.Location = New System.Drawing.Point(267, 345)
        Me.lblShortestStayVar.Name = "lblShortestStayVar"
        Me.lblShortestStayVar.Size = New System.Drawing.Size(80, 25)
        Me.lblShortestStayVar.TabIndex = 3
        Me.lblShortestStayVar.Text = "x days"
        '
        'lblLongestStayVar
        '
        Me.lblLongestStayVar.AutoSize = True
        Me.lblLongestStayVar.Font = New System.Drawing.Font("Verdana", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLongestStayVar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.lblLongestStayVar.Location = New System.Drawing.Point(267, 411)
        Me.lblLongestStayVar.Name = "lblLongestStayVar"
        Me.lblLongestStayVar.Size = New System.Drawing.Size(80, 25)
        Me.lblLongestStayVar.TabIndex = 4
        Me.lblLongestStayVar.Text = "x days"
        '
        'lblAverageStayVar
        '
        Me.lblAverageStayVar.AutoSize = True
        Me.lblAverageStayVar.Font = New System.Drawing.Font("Verdana", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverageStayVar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.lblAverageStayVar.Location = New System.Drawing.Point(267, 475)
        Me.lblAverageStayVar.Name = "lblAverageStayVar"
        Me.lblAverageStayVar.Size = New System.Drawing.Size(80, 25)
        Me.lblAverageStayVar.TabIndex = 5
        Me.lblAverageStayVar.Text = "x days"
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Font = New System.Drawing.Font("Verdana", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl.Location = New System.Drawing.Point(527, 346)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(246, 25)
        Me.lbl.TabIndex = 6
        Me.lbl.Text = "Lowest boarding cost:"
        '
        'lblLowestCost
        '
        Me.lblLowestCost.AutoSize = True
        Me.lblLowestCost.Font = New System.Drawing.Font("Verdana", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLowestCost.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.lblLowestCost.Location = New System.Drawing.Point(780, 345)
        Me.lblLowestCost.Name = "lblLowestCost"
        Me.lblLowestCost.Size = New System.Drawing.Size(85, 25)
        Me.lblLowestCost.TabIndex = 7
        Me.lblLowestCost.Text = "$XX.xx"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(522, 411)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(252, 25)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Highest boarding cost:"
        '
        'lblHighestCost
        '
        Me.lblHighestCost.AutoSize = True
        Me.lblHighestCost.Font = New System.Drawing.Font("Verdana", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHighestCost.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.lblHighestCost.Location = New System.Drawing.Point(780, 412)
        Me.lblHighestCost.Name = "lblHighestCost"
        Me.lblHighestCost.Size = New System.Drawing.Size(85, 25)
        Me.lblHighestCost.TabIndex = 9
        Me.lblHighestCost.Text = "$XX.xx"
        '
        'lblAverageCost
        '
        Me.lblAverageCost.AutoSize = True
        Me.lblAverageCost.Font = New System.Drawing.Font("Verdana", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverageCost.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.lblAverageCost.Location = New System.Drawing.Point(780, 476)
        Me.lblAverageCost.Name = "lblAverageCost"
        Me.lblAverageCost.Size = New System.Drawing.Size(85, 25)
        Me.lblAverageCost.TabIndex = 10
        Me.lblAverageCost.Text = "$XX.xx"
        '
        'lblAverageBoardingCost
        '
        Me.lblAverageBoardingCost.AutoSize = True
        Me.lblAverageBoardingCost.Font = New System.Drawing.Font("Verdana", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverageBoardingCost.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblAverageBoardingCost.Location = New System.Drawing.Point(515, 476)
        Me.lblAverageBoardingCost.Name = "lblAverageBoardingCost"
        Me.lblAverageBoardingCost.Size = New System.Drawing.Size(258, 25)
        Me.lblAverageBoardingCost.TabIndex = 11
        Me.lblAverageBoardingCost.Text = "Average boarding cost:"
        '
        'lblSpecies
        '
        Me.lblSpecies.AutoSize = True
        Me.lblSpecies.Font = New System.Drawing.Font("Verdana", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpecies.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblSpecies.Location = New System.Drawing.Point(139, 567)
        Me.lblSpecies.Name = "lblSpecies"
        Me.lblSpecies.Size = New System.Drawing.Size(103, 25)
        Me.lblSpecies.TabIndex = 12
        Me.lblSpecies.Text = "Species:"
        '
        'cmbSpecies
        '
        Me.cmbSpecies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSpecies.Font = New System.Drawing.Font("Verdana", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSpecies.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.cmbSpecies.FormattingEnabled = True
        Me.cmbSpecies.Location = New System.Drawing.Point(272, 564)
        Me.cmbSpecies.Name = "cmbSpecies"
        Me.cmbSpecies.Size = New System.Drawing.Size(170, 33)
        Me.cmbSpecies.TabIndex = 13
        '
        'SpeciesBindingSource
        '
        Me.SpeciesBindingSource.DataMember = "species"
        Me.SpeciesBindingSource.DataSource = Me.TickedoffDataSet
        '
        'TickedoffDataSet
        '
        Me.TickedoffDataSet.DataSetName = "tickedoffDataSet"
        Me.TickedoffDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblNumOfStays
        '
        Me.lblNumOfStays.AutoSize = True
        Me.lblNumOfStays.Font = New System.Drawing.Font("Verdana", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumOfStays.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblNumOfStays.Location = New System.Drawing.Point(54, 624)
        Me.lblNumOfStays.Name = "lblNumOfStays"
        Me.lblNumOfStays.Size = New System.Drawing.Size(195, 25)
        Me.lblNumOfStays.TabIndex = 14
        Me.lblNumOfStays.Text = "Number of stays:"
        '
        'PetBindingSource
        '
        Me.PetBindingSource.DataMember = "pet"
        Me.PetBindingSource.DataSource = Me.TickedoffDataSet
        '
        'PetTableAdapter
        '
        Me.PetTableAdapter.ClearBeforeFill = True
        '
        'SpeciesTableAdapter
        '
        Me.SpeciesTableAdapter.ClearBeforeFill = True
        '
        'lblTotalStays
        '
        Me.lblTotalStays.AutoSize = True
        Me.lblTotalStays.Font = New System.Drawing.Font("Verdana", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalStays.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.lblTotalStays.Location = New System.Drawing.Point(267, 624)
        Me.lblTotalStays.Name = "lblTotalStays"
        Me.lblTotalStays.Size = New System.Drawing.Size(160, 25)
        Me.lblTotalStays.TabIndex = 15
        Me.lblTotalStays.Text = "XX Total stays"
        '
        'lblTotalAmountPaid
        '
        Me.lblTotalAmountPaid.AutoSize = True
        Me.lblTotalAmountPaid.Font = New System.Drawing.Font("Verdana", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAmountPaid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTotalAmountPaid.Location = New System.Drawing.Point(38, 683)
        Me.lblTotalAmountPaid.Name = "lblTotalAmountPaid"
        Me.lblTotalAmountPaid.Size = New System.Drawing.Size(212, 25)
        Me.lblTotalAmountPaid.TabIndex = 16
        Me.lblTotalAmountPaid.Text = "Total amount paid:"
        '
        'lblTotalPaid
        '
        Me.lblTotalPaid.AutoSize = True
        Me.lblTotalPaid.Font = New System.Drawing.Font("Verdana", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPaid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.lblTotalPaid.Location = New System.Drawing.Point(267, 682)
        Me.lblTotalPaid.Name = "lblTotalPaid"
        Me.lblTotalPaid.Size = New System.Drawing.Size(273, 25)
        Me.lblTotalPaid.TabIndex = 17
        Me.lblTotalPaid.Text = "$XX.XX Total amout paid"
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Verdana", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCalculate.Location = New System.Drawing.Point(641, 615)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(190, 43)
        Me.btnCalculate.TabIndex = 18
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'StayTableAdapter1
        '
        Me.StayTableAdapter1.ClearBeforeFill = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton1, Me.ToolStripDropDownButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(911, 36)
        Me.ToolStrip1.TabIndex = 19
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.ToolStripDropDownButton1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(75, 33)
        Me.ToolStripDropDownButton1.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(155, 38)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ToolStripDropDownButton2
        '
        Me.ToolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButton2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutThisCompanyToolStripMenuItem, Me.AboutThisApplicationToolStripMenuItem})
        Me.ToolStripDropDownButton2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripDropDownButton2.Image = CType(resources.GetObject("ToolStripDropDownButton2.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton2.Name = "ToolStripDropDownButton2"
        Me.ToolStripDropDownButton2.Size = New System.Drawing.Size(88, 33)
        Me.ToolStripDropDownButton2.Text = "Help"
        '
        'AboutThisCompanyToolStripMenuItem
        '
        Me.AboutThisCompanyToolStripMenuItem.Name = "AboutThisCompanyToolStripMenuItem"
        Me.AboutThisCompanyToolStripMenuItem.Size = New System.Drawing.Size(368, 38)
        Me.AboutThisCompanyToolStripMenuItem.Text = "About this company"
        '
        'AboutThisApplicationToolStripMenuItem
        '
        Me.AboutThisApplicationToolStripMenuItem.Name = "AboutThisApplicationToolStripMenuItem"
        Me.AboutThisApplicationToolStripMenuItem.Size = New System.Drawing.Size(368, 38)
        Me.AboutThisApplicationToolStripMenuItem.Text = "About this application"
        '
        'lblStatistics
        '
        Me.lblStatistics.AutoSize = True
        Me.lblStatistics.Font = New System.Drawing.Font("Arial Rounded MT Bold", 19.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatistics.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.lblStatistics.Location = New System.Drawing.Point(598, 126)
        Me.lblStatistics.Name = "lblStatistics"
        Me.lblStatistics.Size = New System.Drawing.Size(267, 61)
        Me.lblStatistics.TabIndex = 21
        Me.lblStatistics.Text = "Statistics"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(243, 39)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(338, 172)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Verdana", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnBack.Location = New System.Drawing.Point(28, 60)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(137, 73)
        Me.btnBack.TabIndex = 27
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Statistics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(911, 761)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblStatistics)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblTotalPaid)
        Me.Controls.Add(Me.lblTotalAmountPaid)
        Me.Controls.Add(Me.lblTotalStays)
        Me.Controls.Add(Me.lblNumOfStays)
        Me.Controls.Add(Me.cmbSpecies)
        Me.Controls.Add(Me.lblSpecies)
        Me.Controls.Add(Me.lblAverageBoardingCost)
        Me.Controls.Add(Me.lblAverageCost)
        Me.Controls.Add(Me.lblHighestCost)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblLowestCost)
        Me.Controls.Add(Me.lbl)
        Me.Controls.Add(Me.lblAverageStayVar)
        Me.Controls.Add(Me.lblLongestStayVar)
        Me.Controls.Add(Me.lblShortestStayVar)
        Me.Controls.Add(Me.lblAverageStay)
        Me.Controls.Add(Me.lblLongestStay)
        Me.Controls.Add(Me.lblShortestStay)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Statistics"
        Me.Text = "TickedOff"
        CType(Me.SpeciesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TickedoffDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblShortestStay As Label
    Friend WithEvents lblLongestStay As Label
    Friend WithEvents lblAverageStay As Label
    Friend WithEvents lblShortestStayVar As Label
    Friend WithEvents lblLongestStayVar As Label
    Friend WithEvents lblAverageStayVar As Label
    Friend WithEvents lbl As Label
    Friend WithEvents lblLowestCost As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblHighestCost As Label
    Friend WithEvents lblAverageCost As Label
    Friend WithEvents lblAverageBoardingCost As Label
    Friend WithEvents lblSpecies As Label
    Friend WithEvents cmbSpecies As ComboBox
    Friend WithEvents lblNumOfStays As Label
    Friend WithEvents TickedoffDataSet As tickedoffDataSet
    Friend WithEvents PetBindingSource As BindingSource
    Friend WithEvents PetTableAdapter As tickedoffDataSetTableAdapters.petTableAdapter
    Friend WithEvents SpeciesBindingSource As BindingSource
    Friend WithEvents SpeciesTableAdapter As tickedoffDataSetTableAdapters.speciesTableAdapter
    Friend WithEvents lblTotalStays As Label
    Friend WithEvents lblTotalAmountPaid As Label
    Friend WithEvents lblTotalPaid As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents StayTableAdapter1 As tickedoffDataSetTableAdapters.stayTableAdapter
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripDropDownButton2 As ToolStripDropDownButton
    Friend WithEvents AboutThisCompanyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutThisApplicationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblStatistics As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnBack As Button
End Class
