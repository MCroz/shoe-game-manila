<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDiscount
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.AljonCustomTabControl1 = New AljonCustomControl.Controls.AljonCustomTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.cdHeaderLbl = New System.Windows.Forms.Label()
        Me.cdPercentTxtbox = New Syncfusion.Windows.Forms.Tools.PercentTextBox()
        Me.cdPesoTxtbox = New Syncfusion.Windows.Forms.Tools.CurrencyTextBox()
        Me.byNamePanel = New System.Windows.Forms.Panel()
        Me.cdPercentBtn = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.byCodePanel = New System.Windows.Forms.Panel()
        Me.cdPesoBtn = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.idHeaderLbl = New System.Windows.Forms.Label()
        Me.idPercentTxtbox = New Syncfusion.Windows.Forms.Tools.PercentTextBox()
        Me.idPesoTxtbox = New Syncfusion.Windows.Forms.Tools.CurrencyTextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.idPercentBtn = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.idPesoBtn = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.AljonCustomTabSelector1 = New AljonCustomControl.Controls.AljonCustomTabSelector()
        Me.AljonCustomTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.cdPercentTxtbox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cdPesoTxtbox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.byNamePanel.SuspendLayout()
        Me.byCodePanel.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.idPercentTxtbox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.idPesoTxtbox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(-3, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(1049, 24)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Discount"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AljonCustomTabControl1
        '
        Me.AljonCustomTabControl1.Controls.Add(Me.TabPage1)
        Me.AljonCustomTabControl1.Controls.Add(Me.TabPage2)
        Me.AljonCustomTabControl1.Depth = 0
        Me.AljonCustomTabControl1.Location = New System.Drawing.Point(-3, 132)
        Me.AljonCustomTabControl1.MouseState = AljonCustomControl.MouseState.HOVER
        Me.AljonCustomTabControl1.Name = "AljonCustomTabControl1"
        Me.AljonCustomTabControl1.SelectedIndex = 0
        Me.AljonCustomTabControl1.Size = New System.Drawing.Size(1049, 541)
        Me.AljonCustomTabControl1.TabIndex = 25
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.cdHeaderLbl)
        Me.TabPage1.Controls.Add(Me.cdPercentTxtbox)
        Me.TabPage1.Controls.Add(Me.cdPesoTxtbox)
        Me.TabPage1.Controls.Add(Me.byNamePanel)
        Me.TabPage1.Controls.Add(Me.byCodePanel)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1041, 515)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Cart Discount"
        '
        'cdHeaderLbl
        '
        Me.cdHeaderLbl.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cdHeaderLbl.ForeColor = System.Drawing.Color.Silver
        Me.cdHeaderLbl.Location = New System.Drawing.Point(0, 54)
        Me.cdHeaderLbl.Name = "cdHeaderLbl"
        Me.cdHeaderLbl.Size = New System.Drawing.Size(1038, 30)
        Me.cdHeaderLbl.TabIndex = 28
        Me.cdHeaderLbl.Text = "Add discount to "
        Me.cdHeaderLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cdPercentTxtbox
        '
        Me.cdPercentTxtbox.BackGroundColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.cdPercentTxtbox.BeforeTouchSize = New System.Drawing.Size(204, 43)
        Me.cdPercentTxtbox.BorderColor = System.Drawing.Color.DeepSkyBlue
        Me.cdPercentTxtbox.BorderSides = System.Windows.Forms.Border3DSide.Bottom
        Me.cdPercentTxtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cdPercentTxtbox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.cdPercentTxtbox.DoubleValue = 1.0R
        Me.cdPercentTxtbox.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cdPercentTxtbox.ForeColor = System.Drawing.Color.White
        Me.cdPercentTxtbox.Location = New System.Drawing.Point(420, 220)
        Me.cdPercentTxtbox.MaxValue = 100.0R
        Me.cdPercentTxtbox.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.cdPercentTxtbox.MinValue = 1.0R
        Me.cdPercentTxtbox.Name = "cdPercentTxtbox"
        Me.cdPercentTxtbox.NullString = ""
        Me.cdPercentTxtbox.PositiveColor = System.Drawing.Color.White
        Me.cdPercentTxtbox.Size = New System.Drawing.Size(204, 43)
        Me.cdPercentTxtbox.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.cdPercentTxtbox.TabIndex = 20
        Me.cdPercentTxtbox.Text = "100.00 %"
        Me.cdPercentTxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cdPesoTxtbox
        '
        Me.cdPesoTxtbox.BackGroundColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.cdPesoTxtbox.BeforeTouchSize = New System.Drawing.Size(204, 43)
        Me.cdPesoTxtbox.BorderColor = System.Drawing.Color.DeepSkyBlue
        Me.cdPesoTxtbox.BorderSides = System.Windows.Forms.Border3DSide.Bottom
        Me.cdPesoTxtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cdPesoTxtbox.Culture = New System.Globalization.CultureInfo("en-PH")
        Me.cdPesoTxtbox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.cdPesoTxtbox.DecimalValue = New Decimal(New Integer() {100, 0, 0, 131072})
        Me.cdPesoTxtbox.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cdPesoTxtbox.ForeColor = System.Drawing.Color.White
        Me.cdPesoTxtbox.Location = New System.Drawing.Point(420, 220)
        Me.cdPesoTxtbox.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.cdPesoTxtbox.MinValue = New Decimal(New Integer() {100, 0, 0, 131072})
        Me.cdPesoTxtbox.Name = "cdPesoTxtbox"
        Me.cdPesoTxtbox.NullString = ""
        Me.cdPesoTxtbox.PositiveColor = System.Drawing.Color.White
        Me.cdPesoTxtbox.Size = New System.Drawing.Size(204, 43)
        Me.cdPesoTxtbox.SpecialCultureValue = Syncfusion.Windows.Forms.Tools.SpecialCultureValues.None
        Me.cdPesoTxtbox.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.cdPesoTxtbox.TabIndex = 19
        Me.cdPesoTxtbox.Text = "₱1.00"
        Me.cdPesoTxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.cdPesoTxtbox.Visible = False
        '
        'byNamePanel
        '
        Me.byNamePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.byNamePanel.Controls.Add(Me.cdPercentBtn)
        Me.byNamePanel.Location = New System.Drawing.Point(444, 134)
        Me.byNamePanel.Name = "byNamePanel"
        Me.byNamePanel.Size = New System.Drawing.Size(74, 58)
        Me.byNamePanel.TabIndex = 17
        '
        'cdPercentBtn
        '
        Me.cdPercentBtn.Activecolor = System.Drawing.SystemColors.Highlight
        Me.cdPercentBtn.BackColor = System.Drawing.SystemColors.Highlight
        Me.cdPercentBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cdPercentBtn.BorderRadius = 0
        Me.cdPercentBtn.ButtonText = ""
        Me.cdPercentBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cdPercentBtn.DisabledColor = System.Drawing.Color.Gray
        Me.cdPercentBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cdPercentBtn.Iconcolor = System.Drawing.Color.Transparent
        Me.cdPercentBtn.Iconimage = Nothing
        Me.cdPercentBtn.Iconimage_right = Nothing
        Me.cdPercentBtn.Iconimage_right_Selected = Nothing
        Me.cdPercentBtn.Iconimage_Selected = Nothing
        Me.cdPercentBtn.IconMarginLeft = 0
        Me.cdPercentBtn.IconMarginRight = 0
        Me.cdPercentBtn.IconRightVisible = False
        Me.cdPercentBtn.IconRightZoom = 0.0R
        Me.cdPercentBtn.IconVisible = False
        Me.cdPercentBtn.IconZoom = 90.0R
        Me.cdPercentBtn.IsTab = True
        Me.cdPercentBtn.Location = New System.Drawing.Point(0, 0)
        Me.cdPercentBtn.Name = "cdPercentBtn"
        Me.cdPercentBtn.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.cdPercentBtn.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.cdPercentBtn.OnHoverTextColor = System.Drawing.Color.White
        Me.cdPercentBtn.selected = True
        Me.cdPercentBtn.Size = New System.Drawing.Size(72, 56)
        Me.cdPercentBtn.TabIndex = 12
        Me.cdPercentBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cdPercentBtn.Textcolor = System.Drawing.Color.White
        Me.cdPercentBtn.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'byCodePanel
        '
        Me.byCodePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.byCodePanel.Controls.Add(Me.cdPesoBtn)
        Me.byCodePanel.Location = New System.Drawing.Point(514, 134)
        Me.byCodePanel.Name = "byCodePanel"
        Me.byCodePanel.Size = New System.Drawing.Size(74, 58)
        Me.byCodePanel.TabIndex = 16
        '
        'cdPesoBtn
        '
        Me.cdPesoBtn.Activecolor = System.Drawing.SystemColors.Highlight
        Me.cdPesoBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.cdPesoBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cdPesoBtn.BorderRadius = 0
        Me.cdPesoBtn.ButtonText = ""
        Me.cdPesoBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cdPesoBtn.DisabledColor = System.Drawing.Color.Gray
        Me.cdPesoBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cdPesoBtn.Iconcolor = System.Drawing.Color.Transparent
        Me.cdPesoBtn.Iconimage = Nothing
        Me.cdPesoBtn.Iconimage_right = Nothing
        Me.cdPesoBtn.Iconimage_right_Selected = Nothing
        Me.cdPesoBtn.Iconimage_Selected = Nothing
        Me.cdPesoBtn.IconMarginLeft = 0
        Me.cdPesoBtn.IconMarginRight = 0
        Me.cdPesoBtn.IconRightVisible = False
        Me.cdPesoBtn.IconRightZoom = 0.0R
        Me.cdPesoBtn.IconVisible = False
        Me.cdPesoBtn.IconZoom = 90.0R
        Me.cdPesoBtn.IsTab = False
        Me.cdPesoBtn.Location = New System.Drawing.Point(0, 0)
        Me.cdPesoBtn.Name = "cdPesoBtn"
        Me.cdPesoBtn.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.cdPesoBtn.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.cdPesoBtn.OnHoverTextColor = System.Drawing.Color.White
        Me.cdPesoBtn.selected = False
        Me.cdPesoBtn.Size = New System.Drawing.Size(72, 56)
        Me.cdPesoBtn.TabIndex = 13
        Me.cdPesoBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cdPesoBtn.Textcolor = System.Drawing.Color.White
        Me.cdPesoBtn.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.idHeaderLbl)
        Me.TabPage2.Controls.Add(Me.idPercentTxtbox)
        Me.TabPage2.Controls.Add(Me.idPesoTxtbox)
        Me.TabPage2.Controls.Add(Me.Panel1)
        Me.TabPage2.Controls.Add(Me.Panel2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1041, 515)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Item Discount"
        '
        'idHeaderLbl
        '
        Me.idHeaderLbl.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idHeaderLbl.ForeColor = System.Drawing.Color.Silver
        Me.idHeaderLbl.Location = New System.Drawing.Point(-4, 54)
        Me.idHeaderLbl.Name = "idHeaderLbl"
        Me.idHeaderLbl.Size = New System.Drawing.Size(1049, 30)
        Me.idHeaderLbl.TabIndex = 27
        Me.idHeaderLbl.Text = "Add discount to "
        Me.idHeaderLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'idPercentTxtbox
        '
        Me.idPercentTxtbox.BackGroundColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.idPercentTxtbox.BeforeTouchSize = New System.Drawing.Size(204, 43)
        Me.idPercentTxtbox.BorderColor = System.Drawing.Color.DeepSkyBlue
        Me.idPercentTxtbox.BorderSides = System.Windows.Forms.Border3DSide.Bottom
        Me.idPercentTxtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.idPercentTxtbox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.idPercentTxtbox.DoubleValue = 1.0R
        Me.idPercentTxtbox.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idPercentTxtbox.ForeColor = System.Drawing.Color.White
        Me.idPercentTxtbox.Location = New System.Drawing.Point(420, 220)
        Me.idPercentTxtbox.MaxValue = 100.0R
        Me.idPercentTxtbox.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.idPercentTxtbox.MinValue = 1.0R
        Me.idPercentTxtbox.Name = "idPercentTxtbox"
        Me.idPercentTxtbox.NullString = ""
        Me.idPercentTxtbox.PositiveColor = System.Drawing.Color.White
        Me.idPercentTxtbox.Size = New System.Drawing.Size(204, 43)
        Me.idPercentTxtbox.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.idPercentTxtbox.TabIndex = 24
        Me.idPercentTxtbox.Text = "100.00 %"
        Me.idPercentTxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'idPesoTxtbox
        '
        Me.idPesoTxtbox.BackGroundColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.idPesoTxtbox.BeforeTouchSize = New System.Drawing.Size(204, 43)
        Me.idPesoTxtbox.BorderColor = System.Drawing.Color.DeepSkyBlue
        Me.idPesoTxtbox.BorderSides = System.Windows.Forms.Border3DSide.Bottom
        Me.idPesoTxtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.idPesoTxtbox.Culture = New System.Globalization.CultureInfo("en-PH")
        Me.idPesoTxtbox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.idPesoTxtbox.DecimalValue = New Decimal(New Integer() {100, 0, 0, 131072})
        Me.idPesoTxtbox.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idPesoTxtbox.ForeColor = System.Drawing.Color.White
        Me.idPesoTxtbox.Location = New System.Drawing.Point(420, 220)
        Me.idPesoTxtbox.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.idPesoTxtbox.MinValue = New Decimal(New Integer() {100, 0, 0, 131072})
        Me.idPesoTxtbox.Name = "idPesoTxtbox"
        Me.idPesoTxtbox.NullString = ""
        Me.idPesoTxtbox.PositiveColor = System.Drawing.Color.White
        Me.idPesoTxtbox.Size = New System.Drawing.Size(204, 43)
        Me.idPesoTxtbox.SpecialCultureValue = Syncfusion.Windows.Forms.Tools.SpecialCultureValues.None
        Me.idPesoTxtbox.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.idPesoTxtbox.TabIndex = 23
        Me.idPesoTxtbox.Text = "₱1.00"
        Me.idPesoTxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.idPesoTxtbox.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.idPercentBtn)
        Me.Panel1.Location = New System.Drawing.Point(444, 134)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(74, 58)
        Me.Panel1.TabIndex = 22
        '
        'idPercentBtn
        '
        Me.idPercentBtn.Activecolor = System.Drawing.SystemColors.Highlight
        Me.idPercentBtn.BackColor = System.Drawing.SystemColors.Highlight
        Me.idPercentBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.idPercentBtn.BorderRadius = 0
        Me.idPercentBtn.ButtonText = ""
        Me.idPercentBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.idPercentBtn.DisabledColor = System.Drawing.Color.Gray
        Me.idPercentBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.idPercentBtn.Iconcolor = System.Drawing.Color.Transparent
        Me.idPercentBtn.Iconimage = Nothing
        Me.idPercentBtn.Iconimage_right = Nothing
        Me.idPercentBtn.Iconimage_right_Selected = Nothing
        Me.idPercentBtn.Iconimage_Selected = Nothing
        Me.idPercentBtn.IconMarginLeft = 0
        Me.idPercentBtn.IconMarginRight = 0
        Me.idPercentBtn.IconRightVisible = True
        Me.idPercentBtn.IconRightZoom = 0.0R
        Me.idPercentBtn.IconVisible = True
        Me.idPercentBtn.IconZoom = 90.0R
        Me.idPercentBtn.IsTab = True
        Me.idPercentBtn.Location = New System.Drawing.Point(0, 0)
        Me.idPercentBtn.Name = "idPercentBtn"
        Me.idPercentBtn.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.idPercentBtn.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.idPercentBtn.OnHoverTextColor = System.Drawing.Color.White
        Me.idPercentBtn.selected = True
        Me.idPercentBtn.Size = New System.Drawing.Size(72, 56)
        Me.idPercentBtn.TabIndex = 12
        Me.idPercentBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.idPercentBtn.Textcolor = System.Drawing.Color.White
        Me.idPercentBtn.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.idPesoBtn)
        Me.Panel2.Location = New System.Drawing.Point(514, 134)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(74, 58)
        Me.Panel2.TabIndex = 21
        '
        'idPesoBtn
        '
        Me.idPesoBtn.Activecolor = System.Drawing.SystemColors.Highlight
        Me.idPesoBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.idPesoBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.idPesoBtn.BorderRadius = 0
        Me.idPesoBtn.ButtonText = ""
        Me.idPesoBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.idPesoBtn.DisabledColor = System.Drawing.Color.Gray
        Me.idPesoBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.idPesoBtn.Iconcolor = System.Drawing.Color.Transparent
        Me.idPesoBtn.Iconimage = Nothing
        Me.idPesoBtn.Iconimage_right = Nothing
        Me.idPesoBtn.Iconimage_right_Selected = Nothing
        Me.idPesoBtn.Iconimage_Selected = Nothing
        Me.idPesoBtn.IconMarginLeft = 0
        Me.idPesoBtn.IconMarginRight = 0
        Me.idPesoBtn.IconRightVisible = False
        Me.idPesoBtn.IconRightZoom = 0.0R
        Me.idPesoBtn.IconVisible = False
        Me.idPesoBtn.IconZoom = 90.0R
        Me.idPesoBtn.IsTab = False
        Me.idPesoBtn.Location = New System.Drawing.Point(0, 0)
        Me.idPesoBtn.Name = "idPesoBtn"
        Me.idPesoBtn.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.idPesoBtn.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.idPesoBtn.OnHoverTextColor = System.Drawing.Color.White
        Me.idPesoBtn.selected = False
        Me.idPesoBtn.Size = New System.Drawing.Size(72, 56)
        Me.idPesoBtn.TabIndex = 13
        Me.idPesoBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.idPesoBtn.Textcolor = System.Drawing.Color.White
        Me.idPesoBtn.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'AljonCustomTabSelector1
        '
        Me.AljonCustomTabSelector1.BaseTabControl = Me.AljonCustomTabControl1
        Me.AljonCustomTabSelector1.Depth = 0
        Me.AljonCustomTabSelector1.Location = New System.Drawing.Point(321, 91)
        Me.AljonCustomTabSelector1.MouseState = AljonCustomControl.MouseState.HOVER
        Me.AljonCustomTabSelector1.Name = "AljonCustomTabSelector1"
        Me.AljonCustomTabSelector1.Size = New System.Drawing.Size(397, 35)
        Me.AljonCustomTabSelector1.TabIndex = 26
        Me.AljonCustomTabSelector1.TabSelectorFont = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AljonCustomTabSelector1.TabSelectorFontColor = System.Drawing.Color.White
        Me.AljonCustomTabSelector1.Text = "AljonCustomTabSelector1"
        Me.AljonCustomTabSelector1.UnderLineColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        '
        'frmDiscount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1046, 672)
        Me.Controls.Add(Me.AljonCustomTabSelector1)
        Me.Controls.Add(Me.AljonCustomTabControl1)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDiscount"
        Me.Text = "frmDiscount"
        Me.AljonCustomTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.cdPercentTxtbox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cdPesoTxtbox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.byNamePanel.ResumeLayout(False)
        Me.byCodePanel.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.idPercentTxtbox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.idPesoTxtbox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents AljonCustomTabControl1 As AljonCustomControl.Controls.AljonCustomTabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents AljonCustomTabSelector1 As AljonCustomControl.Controls.AljonCustomTabSelector
    Friend WithEvents byNamePanel As System.Windows.Forms.Panel
    Friend WithEvents cdPercentBtn As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents byCodePanel As System.Windows.Forms.Panel
    Friend WithEvents cdPesoBtn As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents cdPercentTxtbox As Syncfusion.Windows.Forms.Tools.PercentTextBox
    Friend WithEvents cdPesoTxtbox As Syncfusion.Windows.Forms.Tools.CurrencyTextBox
    Friend WithEvents cdHeaderLbl As System.Windows.Forms.Label
    Friend WithEvents idHeaderLbl As System.Windows.Forms.Label
    Friend WithEvents idPercentTxtbox As Syncfusion.Windows.Forms.Tools.PercentTextBox
    Friend WithEvents idPesoTxtbox As Syncfusion.Windows.Forms.Tools.CurrencyTextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents idPercentBtn As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents idPesoBtn As Bunifu.Framework.UI.BunifuFlatButton
End Class
