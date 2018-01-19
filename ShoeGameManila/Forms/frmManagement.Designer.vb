<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManagement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmManagement))
        Me.headerPanel = New System.Windows.Forms.Panel()
        Me.headerLabel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.headerLine = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.navPanel = New System.Windows.Forms.Panel()
        Me.mainContainer = New System.Windows.Forms.Panel()
        Me.navTaxRates = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.navCategory = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.navUserInfo = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.navCustomers = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.navReports = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.navStock = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.navProducts = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.navDashboard = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.headerPanel.SuspendLayout()
        Me.navPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'headerPanel
        '
        Me.headerPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.headerPanel.Controls.Add(Me.BunifuFlatButton1)
        Me.headerPanel.Controls.Add(Me.headerLabel)
        Me.headerPanel.Controls.Add(Me.Label4)
        Me.headerPanel.Controls.Add(Me.ShapeContainer1)
        Me.headerPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.headerPanel.Location = New System.Drawing.Point(0, 0)
        Me.headerPanel.Name = "headerPanel"
        Me.headerPanel.Size = New System.Drawing.Size(1200, 50)
        Me.headerPanel.TabIndex = 0
        '
        'headerLabel
        '
        Me.headerLabel.AutoSize = True
        Me.headerLabel.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.headerLabel.ForeColor = System.Drawing.Color.White
        Me.headerLabel.Location = New System.Drawing.Point(192, 16)
        Me.headerLabel.Name = "headerLabel"
        Me.headerLabel.Size = New System.Drawing.Size(90, 20)
        Me.headerLabel.TabIndex = 23
        Me.headerLabel.Text = "Dashboard"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(54, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 20)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Management   ●"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.headerLine})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1200, 50)
        Me.ShapeContainer1.TabIndex = 24
        Me.ShapeContainer1.TabStop = False
        '
        'headerLine
        '
        Me.headerLine.BorderColor = System.Drawing.Color.White
        Me.headerLine.Name = "headerLine"
        Me.headerLine.X1 = 0
        Me.headerLine.X2 = 1200
        Me.headerLine.Y1 = 49
        Me.headerLine.Y2 = 49
        '
        'navPanel
        '
        Me.navPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.navPanel.Controls.Add(Me.navTaxRates)
        Me.navPanel.Controls.Add(Me.navCategory)
        Me.navPanel.Controls.Add(Me.navUserInfo)
        Me.navPanel.Controls.Add(Me.navCustomers)
        Me.navPanel.Controls.Add(Me.navReports)
        Me.navPanel.Controls.Add(Me.navStock)
        Me.navPanel.Controls.Add(Me.navProducts)
        Me.navPanel.Controls.Add(Me.navDashboard)
        Me.navPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.navPanel.Location = New System.Drawing.Point(0, 50)
        Me.navPanel.Name = "navPanel"
        Me.navPanel.Size = New System.Drawing.Size(200, 550)
        Me.navPanel.TabIndex = 1
        '
        'mainContainer
        '
        Me.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainContainer.Location = New System.Drawing.Point(200, 50)
        Me.mainContainer.Name = "mainContainer"
        Me.mainContainer.Size = New System.Drawing.Size(1000, 550)
        Me.mainContainer.TabIndex = 2
        '
        'navTaxRates
        '
        Me.navTaxRates.Activecolor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.navTaxRates.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.navTaxRates.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.navTaxRates.BorderRadius = 0
        Me.navTaxRates.ButtonText = "Tax Rates"
        Me.navTaxRates.Cursor = System.Windows.Forms.Cursors.Hand
        Me.navTaxRates.DisabledColor = System.Drawing.Color.Gray
        Me.navTaxRates.Dock = System.Windows.Forms.DockStyle.Top
        Me.navTaxRates.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.navTaxRates.Iconcolor = System.Drawing.Color.Transparent
        Me.navTaxRates.Iconimage = CType(resources.GetObject("navTaxRates.Iconimage"), System.Drawing.Image)
        Me.navTaxRates.Iconimage_right = Nothing
        Me.navTaxRates.Iconimage_right_Selected = Nothing
        Me.navTaxRates.Iconimage_Selected = Nothing
        Me.navTaxRates.IconMarginLeft = 0
        Me.navTaxRates.IconMarginRight = 0
        Me.navTaxRates.IconRightVisible = True
        Me.navTaxRates.IconRightZoom = 0.0R
        Me.navTaxRates.IconVisible = True
        Me.navTaxRates.IconZoom = 90.0R
        Me.navTaxRates.IsTab = True
        Me.navTaxRates.Location = New System.Drawing.Point(0, 336)
        Me.navTaxRates.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.navTaxRates.Name = "navTaxRates"
        Me.navTaxRates.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.navTaxRates.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.navTaxRates.OnHoverTextColor = System.Drawing.Color.White
        Me.navTaxRates.selected = False
        Me.navTaxRates.Size = New System.Drawing.Size(200, 48)
        Me.navTaxRates.TabIndex = 8
        Me.navTaxRates.Text = "Tax Rates"
        Me.navTaxRates.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.navTaxRates.Textcolor = System.Drawing.Color.White
        Me.navTaxRates.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'navCategory
        '
        Me.navCategory.Activecolor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.navCategory.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.navCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.navCategory.BorderRadius = 0
        Me.navCategory.ButtonText = "Brand"
        Me.navCategory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.navCategory.DisabledColor = System.Drawing.Color.Gray
        Me.navCategory.Dock = System.Windows.Forms.DockStyle.Top
        Me.navCategory.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.navCategory.Iconcolor = System.Drawing.Color.Transparent
        Me.navCategory.Iconimage = CType(resources.GetObject("navCategory.Iconimage"), System.Drawing.Image)
        Me.navCategory.Iconimage_right = Nothing
        Me.navCategory.Iconimage_right_Selected = Nothing
        Me.navCategory.Iconimage_Selected = Nothing
        Me.navCategory.IconMarginLeft = 0
        Me.navCategory.IconMarginRight = 0
        Me.navCategory.IconRightVisible = True
        Me.navCategory.IconRightZoom = 0.0R
        Me.navCategory.IconVisible = True
        Me.navCategory.IconZoom = 90.0R
        Me.navCategory.IsTab = True
        Me.navCategory.Location = New System.Drawing.Point(0, 288)
        Me.navCategory.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.navCategory.Name = "navCategory"
        Me.navCategory.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.navCategory.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.navCategory.OnHoverTextColor = System.Drawing.Color.White
        Me.navCategory.selected = False
        Me.navCategory.Size = New System.Drawing.Size(200, 48)
        Me.navCategory.TabIndex = 7
        Me.navCategory.Text = "Brand"
        Me.navCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.navCategory.Textcolor = System.Drawing.Color.White
        Me.navCategory.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'navUserInfo
        '
        Me.navUserInfo.Activecolor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.navUserInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.navUserInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.navUserInfo.BorderRadius = 0
        Me.navUserInfo.ButtonText = "User Info"
        Me.navUserInfo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.navUserInfo.DisabledColor = System.Drawing.Color.Gray
        Me.navUserInfo.Dock = System.Windows.Forms.DockStyle.Top
        Me.navUserInfo.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.navUserInfo.Iconcolor = System.Drawing.Color.Transparent
        Me.navUserInfo.Iconimage = CType(resources.GetObject("navUserInfo.Iconimage"), System.Drawing.Image)
        Me.navUserInfo.Iconimage_right = Nothing
        Me.navUserInfo.Iconimage_right_Selected = Nothing
        Me.navUserInfo.Iconimage_Selected = Nothing
        Me.navUserInfo.IconMarginLeft = 0
        Me.navUserInfo.IconMarginRight = 0
        Me.navUserInfo.IconRightVisible = True
        Me.navUserInfo.IconRightZoom = 0.0R
        Me.navUserInfo.IconVisible = True
        Me.navUserInfo.IconZoom = 90.0R
        Me.navUserInfo.IsTab = True
        Me.navUserInfo.Location = New System.Drawing.Point(0, 240)
        Me.navUserInfo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.navUserInfo.Name = "navUserInfo"
        Me.navUserInfo.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.navUserInfo.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.navUserInfo.OnHoverTextColor = System.Drawing.Color.White
        Me.navUserInfo.selected = False
        Me.navUserInfo.Size = New System.Drawing.Size(200, 48)
        Me.navUserInfo.TabIndex = 6
        Me.navUserInfo.Text = "User Info"
        Me.navUserInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.navUserInfo.Textcolor = System.Drawing.Color.White
        Me.navUserInfo.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'navCustomers
        '
        Me.navCustomers.Activecolor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.navCustomers.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.navCustomers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.navCustomers.BorderRadius = 0
        Me.navCustomers.ButtonText = "Customers"
        Me.navCustomers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.navCustomers.DisabledColor = System.Drawing.Color.Gray
        Me.navCustomers.Dock = System.Windows.Forms.DockStyle.Top
        Me.navCustomers.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.navCustomers.Iconcolor = System.Drawing.Color.Transparent
        Me.navCustomers.Iconimage = CType(resources.GetObject("navCustomers.Iconimage"), System.Drawing.Image)
        Me.navCustomers.Iconimage_right = Nothing
        Me.navCustomers.Iconimage_right_Selected = Nothing
        Me.navCustomers.Iconimage_Selected = Nothing
        Me.navCustomers.IconMarginLeft = 0
        Me.navCustomers.IconMarginRight = 0
        Me.navCustomers.IconRightVisible = True
        Me.navCustomers.IconRightZoom = 0.0R
        Me.navCustomers.IconVisible = True
        Me.navCustomers.IconZoom = 90.0R
        Me.navCustomers.IsTab = True
        Me.navCustomers.Location = New System.Drawing.Point(0, 192)
        Me.navCustomers.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.navCustomers.Name = "navCustomers"
        Me.navCustomers.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.navCustomers.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.navCustomers.OnHoverTextColor = System.Drawing.Color.White
        Me.navCustomers.selected = False
        Me.navCustomers.Size = New System.Drawing.Size(200, 48)
        Me.navCustomers.TabIndex = 5
        Me.navCustomers.Text = "Customers"
        Me.navCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.navCustomers.Textcolor = System.Drawing.Color.White
        Me.navCustomers.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'navReports
        '
        Me.navReports.Activecolor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.navReports.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.navReports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.navReports.BorderRadius = 0
        Me.navReports.ButtonText = "Reports"
        Me.navReports.Cursor = System.Windows.Forms.Cursors.Hand
        Me.navReports.DisabledColor = System.Drawing.Color.Gray
        Me.navReports.Dock = System.Windows.Forms.DockStyle.Top
        Me.navReports.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.navReports.Iconcolor = System.Drawing.Color.Transparent
        Me.navReports.Iconimage = CType(resources.GetObject("navReports.Iconimage"), System.Drawing.Image)
        Me.navReports.Iconimage_right = Nothing
        Me.navReports.Iconimage_right_Selected = Nothing
        Me.navReports.Iconimage_Selected = Nothing
        Me.navReports.IconMarginLeft = 0
        Me.navReports.IconMarginRight = 0
        Me.navReports.IconRightVisible = True
        Me.navReports.IconRightZoom = 0.0R
        Me.navReports.IconVisible = True
        Me.navReports.IconZoom = 90.0R
        Me.navReports.IsTab = True
        Me.navReports.Location = New System.Drawing.Point(0, 144)
        Me.navReports.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.navReports.Name = "navReports"
        Me.navReports.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.navReports.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.navReports.OnHoverTextColor = System.Drawing.Color.White
        Me.navReports.selected = False
        Me.navReports.Size = New System.Drawing.Size(200, 48)
        Me.navReports.TabIndex = 4
        Me.navReports.Text = "Reports"
        Me.navReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.navReports.Textcolor = System.Drawing.Color.White
        Me.navReports.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'navStock
        '
        Me.navStock.Activecolor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.navStock.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.navStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.navStock.BorderRadius = 0
        Me.navStock.ButtonText = "Stock"
        Me.navStock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.navStock.DisabledColor = System.Drawing.Color.Gray
        Me.navStock.Dock = System.Windows.Forms.DockStyle.Top
        Me.navStock.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.navStock.Iconcolor = System.Drawing.Color.Transparent
        Me.navStock.Iconimage = CType(resources.GetObject("navStock.Iconimage"), System.Drawing.Image)
        Me.navStock.Iconimage_right = Nothing
        Me.navStock.Iconimage_right_Selected = Nothing
        Me.navStock.Iconimage_Selected = Nothing
        Me.navStock.IconMarginLeft = 0
        Me.navStock.IconMarginRight = 0
        Me.navStock.IconRightVisible = True
        Me.navStock.IconRightZoom = 0.0R
        Me.navStock.IconVisible = True
        Me.navStock.IconZoom = 90.0R
        Me.navStock.IsTab = True
        Me.navStock.Location = New System.Drawing.Point(0, 96)
        Me.navStock.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.navStock.Name = "navStock"
        Me.navStock.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.navStock.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.navStock.OnHoverTextColor = System.Drawing.Color.White
        Me.navStock.selected = False
        Me.navStock.Size = New System.Drawing.Size(200, 48)
        Me.navStock.TabIndex = 3
        Me.navStock.Text = "Stock"
        Me.navStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.navStock.Textcolor = System.Drawing.Color.White
        Me.navStock.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'navProducts
        '
        Me.navProducts.Activecolor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.navProducts.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.navProducts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.navProducts.BorderRadius = 0
        Me.navProducts.ButtonText = "Products"
        Me.navProducts.Cursor = System.Windows.Forms.Cursors.Hand
        Me.navProducts.DisabledColor = System.Drawing.Color.Gray
        Me.navProducts.Dock = System.Windows.Forms.DockStyle.Top
        Me.navProducts.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.navProducts.Iconcolor = System.Drawing.Color.Transparent
        Me.navProducts.Iconimage = CType(resources.GetObject("navProducts.Iconimage"), System.Drawing.Image)
        Me.navProducts.Iconimage_right = Nothing
        Me.navProducts.Iconimage_right_Selected = Nothing
        Me.navProducts.Iconimage_Selected = Nothing
        Me.navProducts.IconMarginLeft = 0
        Me.navProducts.IconMarginRight = 0
        Me.navProducts.IconRightVisible = True
        Me.navProducts.IconRightZoom = 0.0R
        Me.navProducts.IconVisible = True
        Me.navProducts.IconZoom = 90.0R
        Me.navProducts.IsTab = True
        Me.navProducts.Location = New System.Drawing.Point(0, 48)
        Me.navProducts.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.navProducts.Name = "navProducts"
        Me.navProducts.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.navProducts.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.navProducts.OnHoverTextColor = System.Drawing.Color.White
        Me.navProducts.selected = False
        Me.navProducts.Size = New System.Drawing.Size(200, 48)
        Me.navProducts.TabIndex = 2
        Me.navProducts.Text = "Products"
        Me.navProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.navProducts.Textcolor = System.Drawing.Color.White
        Me.navProducts.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'navDashboard
        '
        Me.navDashboard.Activecolor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.navDashboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.navDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.navDashboard.BorderRadius = 0
        Me.navDashboard.ButtonText = "Dashboard"
        Me.navDashboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.navDashboard.DisabledColor = System.Drawing.Color.Gray
        Me.navDashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.navDashboard.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.navDashboard.Iconcolor = System.Drawing.Color.Transparent
        Me.navDashboard.Iconimage = Global.ShoeGameManila.My.Resources.Resources.CUSTOMERS_AND_SUPPLIERS
        Me.navDashboard.Iconimage_right = Nothing
        Me.navDashboard.Iconimage_right_Selected = Nothing
        Me.navDashboard.Iconimage_Selected = Nothing
        Me.navDashboard.IconMarginLeft = 0
        Me.navDashboard.IconMarginRight = 0
        Me.navDashboard.IconRightVisible = True
        Me.navDashboard.IconRightZoom = 0.0R
        Me.navDashboard.IconVisible = True
        Me.navDashboard.IconZoom = 50.0R
        Me.navDashboard.IsTab = True
        Me.navDashboard.Location = New System.Drawing.Point(0, 0)
        Me.navDashboard.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.navDashboard.Name = "navDashboard"
        Me.navDashboard.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.navDashboard.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.navDashboard.OnHoverTextColor = System.Drawing.Color.White
        Me.navDashboard.selected = False
        Me.navDashboard.Size = New System.Drawing.Size(200, 48)
        Me.navDashboard.TabIndex = 0
        Me.navDashboard.Text = "Dashboard"
        Me.navDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.navDashboard.Textcolor = System.Drawing.Color.White
        Me.navDashboard.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 0
        Me.BunifuFlatButton1.ButtonText = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.Iconimage = CType(resources.GetObject("BunifuFlatButton1.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton1.Iconimage_right = Nothing
        Me.BunifuFlatButton1.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton1.Iconimage_Selected = Nothing
        Me.BunifuFlatButton1.IconMarginLeft = 0
        Me.BunifuFlatButton1.IconMarginRight = 0
        Me.BunifuFlatButton1.IconRightVisible = True
        Me.BunifuFlatButton1.IconRightZoom = 0.0R
        Me.BunifuFlatButton1.IconVisible = True
        Me.BunifuFlatButton1.IconZoom = 90.0R
        Me.BunifuFlatButton1.IsTab = False
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(12, 12)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(36, 29)
        Me.BunifuFlatButton1.TabIndex = 0
        Me.BunifuFlatButton1.Text = "BunifuFlatButton1"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'frmManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1200, 600)
        Me.Controls.Add(Me.mainContainer)
        Me.Controls.Add(Me.navPanel)
        Me.Controls.Add(Me.headerPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmManagement"
        Me.Text = "frmManagement"
        Me.headerPanel.ResumeLayout(False)
        Me.headerPanel.PerformLayout()
        Me.navPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents headerPanel As System.Windows.Forms.Panel
    Friend WithEvents navPanel As System.Windows.Forms.Panel
    Friend WithEvents mainContainer As System.Windows.Forms.Panel
    Friend WithEvents headerLabel As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents headerLine As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents navDashboard As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents navTaxRates As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents navCategory As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents navUserInfo As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents navCustomers As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents navReports As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents navStock As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents navProducts As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
End Class
