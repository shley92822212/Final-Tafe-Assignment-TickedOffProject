<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class boardingCostCalculator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(boardingCostCalculator))
        Me.lblSpecies = New System.Windows.Forms.Label()
        Me.lblPetWeight = New System.Windows.Forms.Label()
        Me.lblStayLength = New System.Windows.Forms.Label()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.lblCalculatedCost = New System.Windows.Forms.Label()
        Me.cmbSpecies = New System.Windows.Forms.ComboBox()
        Me.SpeciesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TickedoffDataSet = New TickedOffProject.tickedoffDataSet()
        Me.PetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtPetWeight = New System.Windows.Forms.TextBox()
        Me.txtStayLength = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.SpeciesTableAdapter1 = New TickedOffProject.tickedoffDataSetTableAdapters.speciesTableAdapter()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripDropDownButton2 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.AboutThisCompanyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutThisApplicationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblBoardingCostCAlculaor = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnBack = New System.Windows.Forms.Button()
        CType(Me.SpeciesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TickedoffDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSpecies
        '
        Me.lblSpecies.AutoSize = True
        Me.lblSpecies.Font = New System.Drawing.Font("Verdana", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpecies.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblSpecies.Location = New System.Drawing.Point(273, 379)
        Me.lblSpecies.Name = "lblSpecies"
        Me.lblSpecies.Size = New System.Drawing.Size(103, 25)
        Me.lblSpecies.TabIndex = 0
        Me.lblSpecies.Text = "Species:"
        '
        'lblPetWeight
        '
        Me.lblPetWeight.AutoSize = True
        Me.lblPetWeight.Font = New System.Drawing.Font("Verdana", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPetWeight.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblPetWeight.Location = New System.Drawing.Point(250, 449)
        Me.lblPetWeight.Name = "lblPetWeight"
        Me.lblPetWeight.Size = New System.Drawing.Size(132, 25)
        Me.lblPetWeight.TabIndex = 1
        Me.lblPetWeight.Text = "Pet weight:"
        '
        'lblStayLength
        '
        Me.lblStayLength.AutoSize = True
        Me.lblStayLength.Font = New System.Drawing.Font("Verdana", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStayLength.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblStayLength.Location = New System.Drawing.Point(242, 526)
        Me.lblStayLength.Name = "lblStayLength"
        Me.lblStayLength.Size = New System.Drawing.Size(142, 25)
        Me.lblStayLength.TabIndex = 2
        Me.lblStayLength.Text = "Stay length:"
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Font = New System.Drawing.Font("Verdana", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCost.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTotalCost.Location = New System.Drawing.Point(256, 597)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(123, 25)
        Me.lblTotalCost.TabIndex = 3
        Me.lblTotalCost.Text = "Total cost:"
        '
        'lblCalculatedCost
        '
        Me.lblCalculatedCost.AutoSize = True
        Me.lblCalculatedCost.Font = New System.Drawing.Font("Verdana", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCalculatedCost.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.lblCalculatedCost.Location = New System.Drawing.Point(391, 597)
        Me.lblCalculatedCost.Name = "lblCalculatedCost"
        Me.lblCalculatedCost.Size = New System.Drawing.Size(25, 25)
        Me.lblCalculatedCost.TabIndex = 4
        Me.lblCalculatedCost.Text = "$"
        '
        'cmbSpecies
        '
        Me.cmbSpecies.DataSource = Me.SpeciesBindingSource
        Me.cmbSpecies.DisplayMember = "description"
        Me.cmbSpecies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSpecies.Font = New System.Drawing.Font("Verdana", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSpecies.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.cmbSpecies.FormattingEnabled = True
        Me.cmbSpecies.Location = New System.Drawing.Point(396, 370)
        Me.cmbSpecies.Name = "cmbSpecies"
        Me.cmbSpecies.Size = New System.Drawing.Size(242, 33)
        Me.cmbSpecies.TabIndex = 5
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
        'PetBindingSource
        '
        Me.PetBindingSource.DataMember = "pet"
        Me.PetBindingSource.DataSource = Me.TickedoffDataSet
        '
        'txtPetWeight
        '
        Me.txtPetWeight.Font = New System.Drawing.Font("Verdana", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPetWeight.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.txtPetWeight.Location = New System.Drawing.Point(396, 443)
        Me.txtPetWeight.Name = "txtPetWeight"
        Me.txtPetWeight.Size = New System.Drawing.Size(242, 33)
        Me.txtPetWeight.TabIndex = 6
        '
        'txtStayLength
        '
        Me.txtStayLength.Font = New System.Drawing.Font("Verdana", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStayLength.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.txtStayLength.Location = New System.Drawing.Point(396, 519)
        Me.txtStayLength.Name = "txtStayLength"
        Me.txtStayLength.Size = New System.Drawing.Size(242, 33)
        Me.txtStayLength.TabIndex = 7
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Verdana", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCalculate.Location = New System.Drawing.Point(743, 436)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(266, 51)
        Me.btnCalculate.TabIndex = 8
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'SpeciesTableAdapter1
        '
        Me.SpeciesTableAdapter1.ClearBeforeFill = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton1, Me.ToolStripDropDownButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1094, 36)
        Me.ToolStrip1.TabIndex = 20
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
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Font = New System.Drawing.Font("Verdana", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblDescription.Location = New System.Drawing.Point(93, 242)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(850, 100)
        Me.lblDescription.TabIndex = 21
        Me.lblDescription.Text = resources.GetString("lblDescription.Text")
        '
        'lblBoardingCostCAlculaor
        '
        Me.lblBoardingCostCAlculaor.AutoSize = True
        Me.lblBoardingCostCAlculaor.Font = New System.Drawing.Font("Arial Rounded MT Bold", 19.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBoardingCostCAlculaor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.lblBoardingCostCAlculaor.Location = New System.Drawing.Point(585, 74)
        Me.lblBoardingCostCAlculaor.Name = "lblBoardingCostCAlculaor"
        Me.lblBoardingCostCAlculaor.Size = New System.Drawing.Size(395, 122)
        Me.lblBoardingCostCAlculaor.TabIndex = 23
        Me.lblBoardingCostCAlculaor.Text = "Boarding Cost" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   Calculator"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(216, 39)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(338, 172)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Verdana", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnBack.Location = New System.Drawing.Point(24, 57)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(137, 73)
        Me.btnBack.TabIndex = 28
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'boardingCostCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1094, 714)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblBoardingCostCAlculaor)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtStayLength)
        Me.Controls.Add(Me.txtPetWeight)
        Me.Controls.Add(Me.cmbSpecies)
        Me.Controls.Add(Me.lblCalculatedCost)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.lblStayLength)
        Me.Controls.Add(Me.lblPetWeight)
        Me.Controls.Add(Me.lblSpecies)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "boardingCostCalculator"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowIcon = False
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

    Friend WithEvents lblSpecies As Label
    Friend WithEvents lblPetWeight As Label
    Friend WithEvents lblStayLength As Label
    Friend WithEvents lblTotalCost As Label
    Friend WithEvents lblCalculatedCost As Label
    Friend WithEvents cmbSpecies As ComboBox
    Friend WithEvents txtPetWeight As TextBox
    Friend WithEvents txtStayLength As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents TickedoffDataSet As tickedoffDataSet
    Friend WithEvents PetBindingSource As BindingSource
    Friend WithEvents SpeciesTableAdapter1 As tickedoffDataSetTableAdapters.speciesTableAdapter
    Friend WithEvents SpeciesBindingSource As BindingSource
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripDropDownButton2 As ToolStripDropDownButton
    Friend WithEvents AboutThisCompanyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutThisApplicationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblDescription As Label
    Friend WithEvents lblBoardingCostCAlculaor As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnBack As Button
End Class
