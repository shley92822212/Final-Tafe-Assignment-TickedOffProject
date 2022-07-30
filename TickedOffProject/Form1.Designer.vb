<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PetTableAdapter = New TickedOffProject.tickedoffDataSetTableAdapters.petTableAdapter()
        Me.CustomerTableAdapter1 = New TickedOffProject.tickedoffDataSetTableAdapters.customerTableAdapter()
        Me.TickedoffDataSet = New TickedOffProject.tickedoffDataSet()
        Me.PetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New TickedOffProject.tickedoffDataSetTableAdapters.TableAdapterManager()
        Me.StayTableAdapter1 = New TickedOffProject.tickedoffDataSetTableAdapters.stayTableAdapter()
        Me.BookingTableAdapter1 = New TickedOffProject.tickedoffDataSetTableAdapters.bookingTableAdapter()
        Me.btnPetInfo = New System.Windows.Forms.Button()
        Me.btnStatistics = New System.Windows.Forms.Button()
        Me.btnCostCalculator = New System.Windows.Forms.Button()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.btnPromo = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblMainMenu = New System.Windows.Forms.Label()
        Me.lblCopyRight = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripDropDownButton2 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.AboutThisCompanyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutThisApplicationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.TickedoffDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PetTableAdapter
        '
        Me.PetTableAdapter.ClearBeforeFill = True
        '
        'CustomerTableAdapter1
        '
        Me.CustomerTableAdapter1.ClearBeforeFill = True
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.bookingTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.customerTableAdapter = Nothing
        Me.TableAdapterManager.inventoryTableAdapter = Nothing
        Me.TableAdapterManager.petTableAdapter = Nothing
        Me.TableAdapterManager.speciesTableAdapter = Nothing
        Me.TableAdapterManager.staffTableAdapter = Nothing
        Me.TableAdapterManager.stateTableAdapter = Nothing
        Me.TableAdapterManager.stayTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = TickedOffProject.tickedoffDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'StayTableAdapter1
        '
        Me.StayTableAdapter1.ClearBeforeFill = True
        '
        'BookingTableAdapter1
        '
        Me.BookingTableAdapter1.ClearBeforeFill = True
        '
        'btnPetInfo
        '
        Me.btnPetInfo.Font = New System.Drawing.Font("Verdana", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPetInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPetInfo.Location = New System.Drawing.Point(60, 276)
        Me.btnPetInfo.Name = "btnPetInfo"
        Me.btnPetInfo.Size = New System.Drawing.Size(261, 139)
        Me.btnPetInfo.TabIndex = 0
        Me.btnPetInfo.Text = "Manage" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "pet" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Information"
        Me.btnPetInfo.UseVisualStyleBackColor = True
        '
        'btnStatistics
        '
        Me.btnStatistics.Font = New System.Drawing.Font("Verdana", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStatistics.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnStatistics.Location = New System.Drawing.Point(372, 276)
        Me.btnStatistics.Name = "btnStatistics"
        Me.btnStatistics.Size = New System.Drawing.Size(261, 139)
        Me.btnStatistics.TabIndex = 1
        Me.btnStatistics.Text = "Statistics"
        Me.btnStatistics.UseVisualStyleBackColor = True
        '
        'btnCostCalculator
        '
        Me.btnCostCalculator.Font = New System.Drawing.Font("Verdana", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCostCalculator.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCostCalculator.Location = New System.Drawing.Point(60, 450)
        Me.btnCostCalculator.Name = "btnCostCalculator"
        Me.btnCostCalculator.Size = New System.Drawing.Size(261, 139)
        Me.btnCostCalculator.TabIndex = 2
        Me.btnCostCalculator.Text = "Boarding" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "cost" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "calculator"
        Me.btnCostCalculator.UseVisualStyleBackColor = True
        '
        'btnExport
        '
        Me.btnExport.Font = New System.Drawing.Font("Verdana", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExport.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnExport.Location = New System.Drawing.Point(372, 450)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(261, 139)
        Me.btnExport.TabIndex = 3
        Me.btnExport.Text = "Quick export pet information (CSV)"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'btnPromo
        '
        Me.btnPromo.Font = New System.Drawing.Font("Verdana", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPromo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPromo.Location = New System.Drawing.Point(60, 634)
        Me.btnPromo.Name = "btnPromo"
        Me.btnPromo.Size = New System.Drawing.Size(573, 87)
        Me.btnPromo.TabIndex = 4
        Me.btnPromo.Text = "Watch the new promo video!"
        Me.btnPromo.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 64)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(338, 172)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'lblMainMenu
        '
        Me.lblMainMenu.AutoSize = True
        Me.lblMainMenu.Font = New System.Drawing.Font("Arial Rounded MT Bold", 19.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMainMenu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.lblMainMenu.Location = New System.Drawing.Point(378, 149)
        Me.lblMainMenu.Name = "lblMainMenu"
        Me.lblMainMenu.Size = New System.Drawing.Size(300, 61)
        Me.lblMainMenu.TabIndex = 6
        Me.lblMainMenu.Text = "Main Menu"
        '
        'lblCopyRight
        '
        Me.lblCopyRight.AutoSize = True
        Me.lblCopyRight.Font = New System.Drawing.Font("Verdana", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCopyRight.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblCopyRight.Location = New System.Drawing.Point(192, 745)
        Me.lblCopyRight.Name = "lblCopyRight"
        Me.lblCopyRight.Size = New System.Drawing.Size(307, 25)
        Me.lblCopyRight.TabIndex = 7
        Me.lblCopyRight.Text = "Copyright ©2017 Ticked Off"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton1, Me.ToolStripDropDownButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(702, 36)
        Me.ToolStrip1.TabIndex = 8
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(702, 779)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.lblCopyRight)
        Me.Controls.Add(Me.lblMainMenu)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnPromo)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.btnCostCalculator)
        Me.Controls.Add(Me.btnStatistics)
        Me.Controls.Add(Me.btnPetInfo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "TickedOff"
        CType(Me.TickedoffDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TickedoffDataSet As tickedoffDataSet
    Friend WithEvents PetBindingSource As BindingSource
    Friend WithEvents PetTableAdapter As tickedoffDataSetTableAdapters.petTableAdapter
    Friend WithEvents TableAdapterManager As tickedoffDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CustomerTableAdapter1 As tickedoffDataSetTableAdapters.customerTableAdapter
    Friend WithEvents StayTableAdapter1 As tickedoffDataSetTableAdapters.stayTableAdapter
    Friend WithEvents BookingTableAdapter1 As tickedoffDataSetTableAdapters.bookingTableAdapter
    Friend WithEvents btnPetInfo As Button
    Friend WithEvents btnStatistics As Button
    Friend WithEvents btnCostCalculator As Button
    Friend WithEvents btnExport As Button
    Friend WithEvents btnPromo As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblMainMenu As Label
    Friend WithEvents lblCopyRight As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripDropDownButton2 As ToolStripDropDownButton
    Friend WithEvents AboutThisCompanyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutThisApplicationToolStripMenuItem As ToolStripMenuItem
End Class
