<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProducts
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProducts))
        Me.productsGrid = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.searchTxtbox = New MetroFramework.Controls.MetroTextBox()
        Me.byNameButton = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.byCodeButton = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.byCodePanel = New System.Windows.Forms.Panel()
        Me.byNamePanel = New System.Windows.Forms.Panel()
        Me.btnRefresh = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnAddNew = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnEdit = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnDelete = New Bunifu.Framework.UI.BunifuImageButton()
        Me.countPanel = New System.Windows.Forms.Panel()
        Me.countLabel = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.productsGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.byCodePanel.SuspendLayout()
        Me.byNamePanel.SuspendLayout()
        CType(Me.btnRefresh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAddNew, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.countPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'productsGrid
        '
        Me.productsGrid.AllowUserToAddRows = False
        Me.productsGrid.AllowUserToDeleteRows = False
        Me.productsGrid.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.productsGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.productsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.productsGrid.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.productsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.productsGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.productsGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.productsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.productsGrid.DefaultCellStyle = DataGridViewCellStyle3
        Me.productsGrid.DoubleBuffered = True
        Me.productsGrid.EnableHeadersVisualStyles = False
        Me.productsGrid.HeaderBgColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.productsGrid.HeaderForeColor = System.Drawing.Color.White
        Me.productsGrid.Location = New System.Drawing.Point(10, 136)
        Me.productsGrid.MultiSelect = False
        Me.productsGrid.Name = "productsGrid"
        Me.productsGrid.ReadOnly = True
        Me.productsGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.productsGrid.RowHeadersVisible = False
        Me.productsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.productsGrid.Size = New System.Drawing.Size(1180, 652)
        Me.productsGrid.TabIndex = 0
        '
        'searchTxtbox
        '
        '
        '
        '
        Me.searchTxtbox.CustomButton.Image = Nothing
        Me.searchTxtbox.CustomButton.Location = New System.Drawing.Point(698, 1)
        Me.searchTxtbox.CustomButton.Name = ""
        Me.searchTxtbox.CustomButton.Size = New System.Drawing.Size(37, 37)
        Me.searchTxtbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.searchTxtbox.CustomButton.TabIndex = 1
        Me.searchTxtbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.searchTxtbox.CustomButton.UseSelectable = True
        Me.searchTxtbox.DisplayIcon = True
        Me.searchTxtbox.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.searchTxtbox.FontWeight = MetroFramework.MetroTextBoxWeight.Light
        Me.searchTxtbox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.searchTxtbox.Lines = New String(-1) {}
        Me.searchTxtbox.Location = New System.Drawing.Point(86, 91)
        Me.searchTxtbox.MaxLength = 32767
        Me.searchTxtbox.Multiline = True
        Me.searchTxtbox.Name = "searchTxtbox"
        Me.searchTxtbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.searchTxtbox.PromptText = "Search product by name"
        Me.searchTxtbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.searchTxtbox.SelectedText = ""
        Me.searchTxtbox.SelectionLength = 0
        Me.searchTxtbox.SelectionStart = 0
        Me.searchTxtbox.ShortcutsEnabled = True
        Me.searchTxtbox.ShowButton = True
        Me.searchTxtbox.Size = New System.Drawing.Size(736, 39)
        Me.searchTxtbox.Style = MetroFramework.MetroColorStyle.Silver
        Me.searchTxtbox.TabIndex = 9
        Me.searchTxtbox.UseCustomBackColor = True
        Me.searchTxtbox.UseCustomForeColor = True
        Me.searchTxtbox.UseSelectable = True
        Me.searchTxtbox.UseStyleColors = True
        Me.searchTxtbox.WaterMark = "Search product by name"
        Me.searchTxtbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.searchTxtbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'byNameButton
        '
        Me.byNameButton.Activecolor = System.Drawing.SystemColors.Highlight
        Me.byNameButton.BackColor = System.Drawing.SystemColors.Highlight
        Me.byNameButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.byNameButton.BorderRadius = 0
        Me.byNameButton.ButtonText = ""
        Me.byNameButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.byNameButton.DisabledColor = System.Drawing.Color.Gray
        Me.byNameButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.byNameButton.Iconcolor = System.Drawing.Color.Transparent
        Me.byNameButton.Iconimage = Nothing
        Me.byNameButton.Iconimage_right = Nothing
        Me.byNameButton.Iconimage_right_Selected = Nothing
        Me.byNameButton.Iconimage_Selected = Nothing
        Me.byNameButton.IconMarginLeft = 0
        Me.byNameButton.IconMarginRight = 0
        Me.byNameButton.IconRightVisible = True
        Me.byNameButton.IconRightZoom = 0.0R
        Me.byNameButton.IconVisible = True
        Me.byNameButton.IconZoom = 90.0R
        Me.byNameButton.IsTab = True
        Me.byNameButton.Location = New System.Drawing.Point(0, 0)
        Me.byNameButton.Name = "byNameButton"
        Me.byNameButton.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.byNameButton.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.byNameButton.OnHoverTextColor = System.Drawing.Color.White
        Me.byNameButton.selected = True
        Me.byNameButton.Size = New System.Drawing.Size(37, 37)
        Me.byNameButton.TabIndex = 12
        Me.byNameButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.byNameButton.Textcolor = System.Drawing.Color.White
        Me.byNameButton.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'byCodeButton
        '
        Me.byCodeButton.Activecolor = System.Drawing.SystemColors.Highlight
        Me.byCodeButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.byCodeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.byCodeButton.BorderRadius = 0
        Me.byCodeButton.ButtonText = ""
        Me.byCodeButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.byCodeButton.DisabledColor = System.Drawing.Color.Gray
        Me.byCodeButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.byCodeButton.Iconcolor = System.Drawing.Color.Transparent
        Me.byCodeButton.Iconimage = Nothing
        Me.byCodeButton.Iconimage_right = Nothing
        Me.byCodeButton.Iconimage_right_Selected = Nothing
        Me.byCodeButton.Iconimage_Selected = Nothing
        Me.byCodeButton.IconMarginLeft = 0
        Me.byCodeButton.IconMarginRight = 0
        Me.byCodeButton.IconRightVisible = True
        Me.byCodeButton.IconRightZoom = 0.0R
        Me.byCodeButton.IconVisible = True
        Me.byCodeButton.IconZoom = 90.0R
        Me.byCodeButton.IsTab = False
        Me.byCodeButton.Location = New System.Drawing.Point(0, 0)
        Me.byCodeButton.Name = "byCodeButton"
        Me.byCodeButton.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.byCodeButton.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.byCodeButton.OnHoverTextColor = System.Drawing.Color.White
        Me.byCodeButton.selected = False
        Me.byCodeButton.Size = New System.Drawing.Size(37, 37)
        Me.byCodeButton.TabIndex = 13
        Me.byCodeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.byCodeButton.Textcolor = System.Drawing.Color.White
        Me.byCodeButton.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'byCodePanel
        '
        Me.byCodePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.byCodePanel.Controls.Add(Me.byCodeButton)
        Me.byCodePanel.Location = New System.Drawing.Point(48, 91)
        Me.byCodePanel.Name = "byCodePanel"
        Me.byCodePanel.Size = New System.Drawing.Size(39, 39)
        Me.byCodePanel.TabIndex = 14
        '
        'byNamePanel
        '
        Me.byNamePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.byNamePanel.Controls.Add(Me.byNameButton)
        Me.byNamePanel.Location = New System.Drawing.Point(10, 91)
        Me.byNamePanel.Name = "byNamePanel"
        Me.byNamePanel.Size = New System.Drawing.Size(39, 39)
        Me.byNamePanel.TabIndex = 15
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Image)
        Me.btnRefresh.ImageActive = Nothing
        Me.btnRefresh.Location = New System.Drawing.Point(10, 10)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(70, 70)
        Me.btnRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnRefresh.TabIndex = 16
        Me.btnRefresh.TabStop = False
        Me.btnRefresh.Zoom = 10
        '
        'btnAddNew
        '
        Me.btnAddNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnAddNew.Image = CType(resources.GetObject("btnAddNew.Image"), System.Drawing.Image)
        Me.btnAddNew.ImageActive = Nothing
        Me.btnAddNew.Location = New System.Drawing.Point(86, 10)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(70, 70)
        Me.btnAddNew.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnAddNew.TabIndex = 17
        Me.btnAddNew.TabStop = False
        Me.btnAddNew.Zoom = 10
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
        Me.btnEdit.ImageActive = Nothing
        Me.btnEdit.Location = New System.Drawing.Point(162, 10)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(70, 70)
        Me.btnEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnEdit.TabIndex = 18
        Me.btnEdit.TabStop = False
        Me.btnEdit.Zoom = 10
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.ImageActive = Nothing
        Me.btnDelete.Location = New System.Drawing.Point(238, 10)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(70, 70)
        Me.btnDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnDelete.TabIndex = 19
        Me.btnDelete.TabStop = False
        Me.btnDelete.Zoom = 10
        '
        'countPanel
        '
        Me.countPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.countPanel.Controls.Add(Me.countLabel)
        Me.countPanel.Location = New System.Drawing.Point(820, 91)
        Me.countPanel.Name = "countPanel"
        Me.countPanel.Size = New System.Drawing.Size(370, 38)
        Me.countPanel.TabIndex = 20
        '
        'countLabel
        '
        Me.countLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.countLabel.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.countLabel.ForeColor = System.Drawing.Color.White
        Me.countLabel.Location = New System.Drawing.Point(25, 7)
        Me.countLabel.Name = "countLabel"
        Me.countLabel.Size = New System.Drawing.Size(340, 20)
        Me.countLabel.TabIndex = 24
        Me.countLabel.Text = "Products Count: 0"
        Me.countLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frmProducts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1200, 780)
        Me.Controls.Add(Me.countPanel)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAddNew)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.byNamePanel)
        Me.Controls.Add(Me.byCodePanel)
        Me.Controls.Add(Me.searchTxtbox)
        Me.Controls.Add(Me.productsGrid)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmProducts"
        CType(Me.productsGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.byCodePanel.ResumeLayout(False)
        Me.byNamePanel.ResumeLayout(False)
        CType(Me.btnRefresh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAddNew, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnDelete, System.ComponentModel.ISupportInitialize).EndInit()
        Me.countPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents productsGrid As Bunifu.Framework.UI.BunifuCustomDataGrid
    Private WithEvents searchTxtbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents byNameButton As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents byCodeButton As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents byCodePanel As System.Windows.Forms.Panel
    Friend WithEvents byNamePanel As System.Windows.Forms.Panel
    Friend WithEvents btnRefresh As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnAddNew As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnEdit As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnDelete As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents countPanel As System.Windows.Forms.Panel
    Friend WithEvents countLabel As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
