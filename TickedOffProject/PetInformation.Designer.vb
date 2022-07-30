<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PetInformation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PetInformation))
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblCopyRight = New System.Windows.Forms.Label()
        Me.lblPetInfoInfo = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblManagePets = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripDropDownButton2 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.AboutThisCompanyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutThisApplicationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnAcsDes = New System.Windows.Forms.Button()
        Me.cmbSort = New System.Windows.Forms.ComboBox()
        Me.lblSort = New System.Windows.Forms.Label()
        Me.btnDeletePet = New System.Windows.Forms.Button()
        Me.btnAddPetData = New System.Windows.Forms.Button()
        Me.btnCancelPetData = New System.Windows.Forms.Button()
        Me.btnSavePetData = New System.Windows.Forms.Button()
        Me.petDataGridView = New System.Windows.Forms.DataGridView()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.PetTableAdapter1 = New TickedOffProject.tickedoffDataSetTableAdapters.petTableAdapter()
        Me.StayTableAdapter1 = New TickedOffProject.tickedoffDataSetTableAdapters.stayTableAdapter()
        Me.BookingTableAdapter1 = New TickedOffProject.tickedoffDataSetTableAdapters.bookingTableAdapter()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.petDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCopyRight
        '
        Me.lblCopyRight.AutoSize = True
        Me.lblCopyRight.Font = New System.Drawing.Font("Verdana", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCopyRight.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblCopyRight.Location = New System.Drawing.Point(661, 1120)
        Me.lblCopyRight.Name = "lblCopyRight"
        Me.lblCopyRight.Size = New System.Drawing.Size(307, 25)
        Me.lblCopyRight.TabIndex = 28
        Me.lblCopyRight.Text = "Copyright ©2017 Ticked Off"
        '
        'lblPetInfoInfo
        '
        Me.lblPetInfoInfo.AutoSize = True
        Me.lblPetInfoInfo.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPetInfoInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblPetInfoInfo.Location = New System.Drawing.Point(19, 342)
        Me.lblPetInfoInfo.Name = "lblPetInfoInfo"
        Me.lblPetInfoInfo.Size = New System.Drawing.Size(562, 29)
        Me.lblPetInfoInfo.TabIndex = 27
        Me.lblPetInfoInfo.Text = "This area allows you to merge pet information"
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Verdana", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnBack.Location = New System.Drawing.Point(24, 88)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(137, 73)
        Me.btnBack.TabIndex = 26
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'lblManagePets
        '
        Me.lblManagePets.AutoSize = True
        Me.lblManagePets.Font = New System.Drawing.Font("Arial Rounded MT Bold", 19.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblManagePets.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.lblManagePets.Location = New System.Drawing.Point(998, 198)
        Me.lblManagePets.Name = "lblManagePets"
        Me.lblManagePets.Size = New System.Drawing.Size(354, 61)
        Me.lblManagePets.TabIndex = 25
        Me.lblManagePets.Text = "Manage pets"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(234, 66)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(660, 233)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton1, Me.ToolStripDropDownButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1661, 36)
        Me.ToolStrip1.TabIndex = 23
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
        'btnAcsDes
        '
        Me.btnAcsDes.Font = New System.Drawing.Font("Verdana", 7.875!)
        Me.btnAcsDes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAcsDes.Location = New System.Drawing.Point(768, 402)
        Me.btnAcsDes.Name = "btnAcsDes"
        Me.btnAcsDes.Size = New System.Drawing.Size(249, 48)
        Me.btnAcsDes.TabIndex = 22
        Me.btnAcsDes.Text = "Ascending"
        Me.btnAcsDes.UseVisualStyleBackColor = True
        '
        'cmbSort
        '
        Me.cmbSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSort.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.cmbSort.FormattingEnabled = True
        Me.cmbSort.Items.AddRange(New Object() {"petID", "petName", "species", "breed", "gender", "weight", "customerID", "DOB", "customerName"})
        Me.cmbSort.Location = New System.Drawing.Point(450, 411)
        Me.cmbSort.Name = "cmbSort"
        Me.cmbSort.Size = New System.Drawing.Size(280, 33)
        Me.cmbSort.TabIndex = 21
        '
        'lblSort
        '
        Me.lblSort.AutoSize = True
        Me.lblSort.Font = New System.Drawing.Font("Verdana", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSort.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblSort.Location = New System.Drawing.Point(121, 414)
        Me.lblSort.Name = "lblSort"
        Me.lblSort.Size = New System.Drawing.Size(297, 25)
        Me.lblSort.TabIndex = 20
        Me.lblSort.Text = "Select Column For Sorting:"
        '
        'btnDeletePet
        '
        Me.btnDeletePet.Font = New System.Drawing.Font("Verdana", 7.875!)
        Me.btnDeletePet.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDeletePet.Location = New System.Drawing.Point(1090, 1006)
        Me.btnDeletePet.Name = "btnDeletePet"
        Me.btnDeletePet.Size = New System.Drawing.Size(200, 90)
        Me.btnDeletePet.TabIndex = 19
        Me.btnDeletePet.Text = "Delete"
        Me.btnDeletePet.UseVisualStyleBackColor = True
        '
        'btnAddPetData
        '
        Me.btnAddPetData.Font = New System.Drawing.Font("Verdana", 7.875!)
        Me.btnAddPetData.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAddPetData.Location = New System.Drawing.Point(716, 1006)
        Me.btnAddPetData.Name = "btnAddPetData"
        Me.btnAddPetData.Size = New System.Drawing.Size(200, 90)
        Me.btnAddPetData.TabIndex = 18
        Me.btnAddPetData.Text = "Add"
        Me.btnAddPetData.UseVisualStyleBackColor = True
        '
        'btnCancelPetData
        '
        Me.btnCancelPetData.Font = New System.Drawing.Font("Verdana", 7.875!)
        Me.btnCancelPetData.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCancelPetData.Location = New System.Drawing.Point(369, 1006)
        Me.btnCancelPetData.Name = "btnCancelPetData"
        Me.btnCancelPetData.Size = New System.Drawing.Size(200, 90)
        Me.btnCancelPetData.TabIndex = 17
        Me.btnCancelPetData.Text = "Cancel"
        Me.btnCancelPetData.UseVisualStyleBackColor = True
        '
        'btnSavePetData
        '
        Me.btnSavePetData.Font = New System.Drawing.Font("Verdana", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSavePetData.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSavePetData.Location = New System.Drawing.Point(24, 1006)
        Me.btnSavePetData.Name = "btnSavePetData"
        Me.btnSavePetData.Size = New System.Drawing.Size(200, 90)
        Me.btnSavePetData.TabIndex = 16
        Me.btnSavePetData.Text = "Save"
        Me.btnSavePetData.UseVisualStyleBackColor = True
        '
        'petDataGridView
        '
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Verdana", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(45, Byte), Integer))
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.petDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.petDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.petDataGridView.GridColor = System.Drawing.SystemColors.ControlLight
        Me.petDataGridView.Location = New System.Drawing.Point(24, 456)
        Me.petDataGridView.Name = "petDataGridView"
        Me.petDataGridView.RowTemplate.Height = 33
        Me.petDataGridView.Size = New System.Drawing.Size(1604, 520)
        Me.petDataGridView.TabIndex = 15
        '
        'btnRefresh
        '
        Me.btnRefresh.Font = New System.Drawing.Font("Verdana", 7.875!)
        Me.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRefresh.Location = New System.Drawing.Point(1428, 1006)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(200, 90)
        Me.btnRefresh.TabIndex = 29
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'PetTableAdapter1
        '
        Me.PetTableAdapter1.ClearBeforeFill = True
        '
        'StayTableAdapter1
        '
        Me.StayTableAdapter1.ClearBeforeFill = True
        '
        'BookingTableAdapter1
        '
        Me.BookingTableAdapter1.ClearBeforeFill = True
        '
        'PetInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1661, 1170)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.lblCopyRight)
        Me.Controls.Add(Me.lblPetInfoInfo)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblManagePets)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.btnAcsDes)
        Me.Controls.Add(Me.cmbSort)
        Me.Controls.Add(Me.lblSort)
        Me.Controls.Add(Me.btnDeletePet)
        Me.Controls.Add(Me.btnAddPetData)
        Me.Controls.Add(Me.btnCancelPetData)
        Me.Controls.Add(Me.btnSavePetData)
        Me.Controls.Add(Me.petDataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "PetInformation"
        Me.ShowIcon = False
        Me.Text = "PetInformation"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.petDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCopyRight As Label
    Friend WithEvents lblPetInfoInfo As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents lblManagePets As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripDropDownButton2 As ToolStripDropDownButton
    Friend WithEvents AboutThisCompanyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutThisApplicationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnAcsDes As Button
    Friend WithEvents cmbSort As ComboBox
    Friend WithEvents lblSort As Label
    Friend WithEvents btnDeletePet As Button
    Friend WithEvents btnAddPetData As Button
    Friend WithEvents btnCancelPetData As Button
    Friend WithEvents btnSavePetData As Button
    Friend WithEvents petDataGridView As DataGridView
    Friend WithEvents btnRefresh As Button
    Friend WithEvents PetTableAdapter1 As tickedoffDataSetTableAdapters.petTableAdapter
    Friend WithEvents StayTableAdapter1 As tickedoffDataSetTableAdapters.stayTableAdapter
    Friend WithEvents BookingTableAdapter1 As tickedoffDataSetTableAdapters.bookingTableAdapter
End Class
