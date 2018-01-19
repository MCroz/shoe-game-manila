<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStocks
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStocks))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnQuckInventory = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnRefresh = New Bunifu.Framework.UI.BunifuImageButton()
        Me.byNamePanel = New System.Windows.Forms.Panel()
        Me.byNameButton = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.byCodePanel = New System.Windows.Forms.Panel()
        Me.byCodeButton = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.searchTxtbox = New MetroFramework.Controls.MetroTextBox()
        Me.stocksGrid = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        CType(Me.btnQuckInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnRefresh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.byNamePanel.SuspendLayout()
        Me.byCodePanel.SuspendLayout()
        CType(Me.stocksGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnQuckInventory
        '
        Me.btnQuckInventory.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnQuckInventory.Image = CType(resources.GetObject("btnQuckInventory.Image"), System.Drawing.Image)
        Me.btnQuckInventory.ImageActive = Nothing
        Me.btnQuckInventory.Location = New System.Drawing.Point(86, 10)
        Me.btnQuckInventory.Name = "btnQuckInventory"
        Me.btnQuckInventory.Size = New System.Drawing.Size(70, 70)
        Me.btnQuckInventory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnQuckInventory.TabIndex = 27
        Me.btnQuckInventory.TabStop = False
        Me.btnQuckInventory.Zoom = 10
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
        Me.btnRefresh.TabIndex = 26
        Me.btnRefresh.TabStop = False
        Me.btnRefresh.Zoom = 10
        '
        'byNamePanel
        '
        Me.byNamePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.byNamePanel.Controls.Add(Me.byNameButton)
        Me.byNamePanel.Location = New System.Drawing.Point(10, 91)
        Me.byNamePanel.Name = "byNamePanel"
        Me.byNamePanel.Size = New System.Drawing.Size(39, 39)
        Me.byNamePanel.TabIndex = 25
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
        'byCodePanel
        '
        Me.byCodePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.byCodePanel.Controls.Add(Me.byCodeButton)
        Me.byCodePanel.Location = New System.Drawing.Point(48, 91)
        Me.byCodePanel.Name = "byCodePanel"
        Me.byCodePanel.Size = New System.Drawing.Size(39, 39)
        Me.byCodePanel.TabIndex = 24
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
        Me.searchTxtbox.TabIndex = 23
        Me.searchTxtbox.UseCustomBackColor = True
        Me.searchTxtbox.UseCustomForeColor = True
        Me.searchTxtbox.UseSelectable = True
        Me.searchTxtbox.UseStyleColors = True
        Me.searchTxtbox.WaterMark = "Search product by name"
        Me.searchTxtbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.searchTxtbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'stocksGrid
        '
        Me.stocksGrid.AllowUserToAddRows = False
        Me.stocksGrid.AllowUserToDeleteRows = False
        Me.stocksGrid.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.stocksGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.stocksGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.stocksGrid.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.stocksGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.stocksGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.stocksGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.stocksGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.stocksGrid.DefaultCellStyle = DataGridViewCellStyle3
        Me.stocksGrid.DoubleBuffered = True
        Me.stocksGrid.EnableHeadersVisualStyles = False
        Me.stocksGrid.HeaderBgColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.stocksGrid.HeaderForeColor = System.Drawing.Color.White
        Me.stocksGrid.Location = New System.Drawing.Point(10, 136)
        Me.stocksGrid.MultiSelect = False
        Me.stocksGrid.Name = "stocksGrid"
        Me.stocksGrid.ReadOnly = True
        Me.stocksGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.stocksGrid.RowHeadersVisible = False
        Me.stocksGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.stocksGrid.Size = New System.Drawing.Size(1180, 652)
        Me.stocksGrid.TabIndex = 22
        '
        'frmStocks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1200, 780)
        Me.Controls.Add(Me.btnQuckInventory)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.byNamePanel)
        Me.Controls.Add(Me.byCodePanel)
        Me.Controls.Add(Me.searchTxtbox)
        Me.Controls.Add(Me.stocksGrid)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmStocks"
        Me.Text = "a"
        CType(Me.btnQuckInventory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnRefresh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.byNamePanel.ResumeLayout(False)
        Me.byCodePanel.ResumeLayout(False)
        CType(Me.stocksGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnQuckInventory As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnRefresh As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents byNamePanel As System.Windows.Forms.Panel
    Friend WithEvents byNameButton As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents byCodePanel As System.Windows.Forms.Panel
    Friend WithEvents byCodeButton As Bunifu.Framework.UI.BunifuFlatButton
    Private WithEvents searchTxtbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents stocksGrid As Bunifu.Framework.UI.BunifuCustomDataGrid
End Class
