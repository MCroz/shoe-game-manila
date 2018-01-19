<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearchProducts
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
        Dim DataGridViewCellStyle82 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle83 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle84 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnProceed = New MetroFramework.Controls.MetroTile()
        Me.btnCancel = New MetroFramework.Controls.MetroTile()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblCustname = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.AljonCustomUnderlineTextbox3 = New AljonCustomControl.Controls.AljonCustomUnderlineTextbox()
        Me.AljonCustomUnderlineTextbox2 = New AljonCustomControl.Controls.AljonCustomUnderlineTextbox()
        Me.byNameSearchBox = New AljonCustomControl.Controls.AljonCustomUnderlineTextbox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.productsGrid = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.productsGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(16, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 24)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Selected Product"
        '
        'btnProceed
        '
        Me.btnProceed.ActiveControl = Nothing
        Me.btnProceed.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProceed.BackColor = System.Drawing.Color.ForestGreen
        Me.btnProceed.Location = New System.Drawing.Point(133, 533)
        Me.btnProceed.Name = "btnProceed"
        Me.btnProceed.Size = New System.Drawing.Size(273, 56)
        Me.btnProceed.TabIndex = 30
        Me.btnProceed.Text = "Proceed"
        Me.btnProceed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnProceed.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.btnProceed.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular
        Me.btnProceed.UseCustomBackColor = True
        Me.btnProceed.UseSelectable = True
        '
        'btnCancel
        '
        Me.btnCancel.ActiveControl = Nothing
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.BackColor = System.Drawing.Color.Firebrick
        Me.btnCancel.Location = New System.Drawing.Point(134, 595)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(272, 56)
        Me.btnCancel.TabIndex = 31
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnCancel.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnCancel.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.btnCancel.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular
        Me.btnCancel.UseCustomBackColor = True
        Me.btnCancel.UseSelectable = True
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Controls.Add(Me.Label15)
        Me.Panel3.Controls.Add(Me.Label16)
        Me.Panel3.Controls.Add(Me.Label17)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Controls.Add(Me.btnProceed)
        Me.Panel3.Controls.Add(Me.btnCancel)
        Me.Panel3.Controls.Add(Me.lblAddress)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.lblCustname)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(829, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(419, 665)
        Me.Panel3.TabIndex = 3
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.ForeColor = System.Drawing.Color.White
        Me.lblAddress.Location = New System.Drawing.Point(129, 268)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(141, 20)
        Me.lblAddress.TabIndex = 27
        Me.lblAddress.Text = "Customer Address"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(16, 268)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 20)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Price :"
        '
        'lblCustname
        '
        Me.lblCustname.AutoSize = True
        Me.lblCustname.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustname.ForeColor = System.Drawing.Color.White
        Me.lblCustname.Location = New System.Drawing.Point(16, 226)
        Me.lblCustname.Name = "lblCustname"
        Me.lblCustname.Size = New System.Drawing.Size(167, 29)
        Me.lblCustname.TabIndex = 23
        Me.lblCustname.Text = "Product Name"
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(417, 65)
        Me.Panel4.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(10, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(175, 24)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Search Products"
        '
        'AljonCustomUnderlineTextbox3
        '
        Me.AljonCustomUnderlineTextbox3.CustomBackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.AljonCustomUnderlineTextbox3.CustomFocusedUnderlineColor = System.Drawing.Color.DeepSkyBlue
        Me.AljonCustomUnderlineTextbox3.CustomFont = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AljonCustomUnderlineTextbox3.CustomFontColor = System.Drawing.Color.White
        Me.AljonCustomUnderlineTextbox3.CustomTextboxMode = AljonCustomControl.TextboxMode.[STRING]
        Me.AljonCustomUnderlineTextbox3.CustomUnfocusedUnderlineColor = System.Drawing.Color.Gray
        Me.AljonCustomUnderlineTextbox3.Depth = 0
        Me.AljonCustomUnderlineTextbox3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AljonCustomUnderlineTextbox3.ForeColor = System.Drawing.Color.White
        Me.AljonCustomUnderlineTextbox3.Hint = "Email"
        Me.AljonCustomUnderlineTextbox3.Location = New System.Drawing.Point(-1, 226)
        Me.AljonCustomUnderlineTextbox3.MaxLength = 32767
        Me.AljonCustomUnderlineTextbox3.MouseState = AljonCustomControl.MouseState.HOVER
        Me.AljonCustomUnderlineTextbox3.Name = "AljonCustomUnderlineTextbox3"
        Me.AljonCustomUnderlineTextbox3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.AljonCustomUnderlineTextbox3.SelectedText = ""
        Me.AljonCustomUnderlineTextbox3.SelectionLength = 0
        Me.AljonCustomUnderlineTextbox3.SelectionStart = 0
        Me.AljonCustomUnderlineTextbox3.Size = New System.Drawing.Size(829, 29)
        Me.AljonCustomUnderlineTextbox3.TabIndex = 9
        Me.AljonCustomUnderlineTextbox3.TabStop = False
        Me.AljonCustomUnderlineTextbox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.AljonCustomUnderlineTextbox3.UseSystemPasswordChar = False
        '
        'AljonCustomUnderlineTextbox2
        '
        Me.AljonCustomUnderlineTextbox2.CustomBackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.AljonCustomUnderlineTextbox2.CustomFocusedUnderlineColor = System.Drawing.Color.DeepSkyBlue
        Me.AljonCustomUnderlineTextbox2.CustomFont = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AljonCustomUnderlineTextbox2.CustomFontColor = System.Drawing.Color.White
        Me.AljonCustomUnderlineTextbox2.CustomTextboxMode = AljonCustomControl.TextboxMode.[STRING]
        Me.AljonCustomUnderlineTextbox2.CustomUnfocusedUnderlineColor = System.Drawing.Color.Gray
        Me.AljonCustomUnderlineTextbox2.Depth = 0
        Me.AljonCustomUnderlineTextbox2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AljonCustomUnderlineTextbox2.ForeColor = System.Drawing.Color.White
        Me.AljonCustomUnderlineTextbox2.Hint = "Contact No"
        Me.AljonCustomUnderlineTextbox2.Location = New System.Drawing.Point(-1, 171)
        Me.AljonCustomUnderlineTextbox2.MaxLength = 32767
        Me.AljonCustomUnderlineTextbox2.MouseState = AljonCustomControl.MouseState.HOVER
        Me.AljonCustomUnderlineTextbox2.Name = "AljonCustomUnderlineTextbox2"
        Me.AljonCustomUnderlineTextbox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.AljonCustomUnderlineTextbox2.SelectedText = ""
        Me.AljonCustomUnderlineTextbox2.SelectionLength = 0
        Me.AljonCustomUnderlineTextbox2.SelectionStart = 0
        Me.AljonCustomUnderlineTextbox2.Size = New System.Drawing.Size(828, 29)
        Me.AljonCustomUnderlineTextbox2.TabIndex = 8
        Me.AljonCustomUnderlineTextbox2.TabStop = False
        Me.AljonCustomUnderlineTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.AljonCustomUnderlineTextbox2.UseSystemPasswordChar = False
        '
        'byNameSearchBox
        '
        Me.byNameSearchBox.CustomBackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.byNameSearchBox.CustomFocusedUnderlineColor = System.Drawing.Color.DeepSkyBlue
        Me.byNameSearchBox.CustomFont = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.byNameSearchBox.CustomFontColor = System.Drawing.Color.White
        Me.byNameSearchBox.CustomTextboxMode = AljonCustomControl.TextboxMode.[STRING]
        Me.byNameSearchBox.CustomUnfocusedUnderlineColor = System.Drawing.Color.Gray
        Me.byNameSearchBox.Depth = 0
        Me.byNameSearchBox.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.byNameSearchBox.ForeColor = System.Drawing.Color.White
        Me.byNameSearchBox.Hint = "Name"
        Me.byNameSearchBox.Location = New System.Drawing.Point(-1, 115)
        Me.byNameSearchBox.MaxLength = 32767
        Me.byNameSearchBox.MouseState = AljonCustomControl.MouseState.HOVER
        Me.byNameSearchBox.Name = "byNameSearchBox"
        Me.byNameSearchBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.byNameSearchBox.SelectedText = ""
        Me.byNameSearchBox.SelectionLength = 0
        Me.byNameSearchBox.SelectionStart = 0
        Me.byNameSearchBox.Size = New System.Drawing.Size(828, 29)
        Me.byNameSearchBox.TabIndex = 7
        Me.byNameSearchBox.TabStop = False
        Me.byNameSearchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.byNameSearchBox.UseSystemPasswordChar = False
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(827, 65)
        Me.Panel2.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.productsGrid)
        Me.Panel1.Controls.Add(Me.AljonCustomUnderlineTextbox3)
        Me.Panel1.Controls.Add(Me.AljonCustomUnderlineTextbox2)
        Me.Panel1.Controls.Add(Me.byNameSearchBox)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(829, 665)
        Me.Panel1.TabIndex = 2
        '
        'productsGrid
        '
        Me.productsGrid.AllowUserToAddRows = False
        Me.productsGrid.AllowUserToDeleteRows = False
        Me.productsGrid.AllowUserToResizeRows = False
        DataGridViewCellStyle82.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        DataGridViewCellStyle82.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle82.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle82.SelectionForeColor = System.Drawing.Color.White
        Me.productsGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle82
        Me.productsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader
        Me.productsGrid.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.productsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.productsGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle83.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle83.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        DataGridViewCellStyle83.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle83.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle83.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle83.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle83.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.productsGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle83
        Me.productsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.productsGrid.ColumnHeadersVisible = False
        DataGridViewCellStyle84.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle84.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        DataGridViewCellStyle84.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle84.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle84.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle84.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle84.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.productsGrid.DefaultCellStyle = DataGridViewCellStyle84
        Me.productsGrid.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.productsGrid.DoubleBuffered = True
        Me.productsGrid.EnableHeadersVisualStyles = False
        Me.productsGrid.HeaderBgColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.productsGrid.HeaderForeColor = System.Drawing.Color.White
        Me.productsGrid.Location = New System.Drawing.Point(0, 386)
        Me.productsGrid.MultiSelect = False
        Me.productsGrid.Name = "productsGrid"
        Me.productsGrid.ReadOnly = True
        Me.productsGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.productsGrid.RowHeadersVisible = False
        Me.productsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.productsGrid.Size = New System.Drawing.Size(827, 277)
        Me.productsGrid.TabIndex = 10
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(21, 71)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(203, 152)
        Me.PictureBox1.TabIndex = 32
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(129, 298)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 20)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Customer Address"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(16, 298)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 20)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Product Code :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(129, 358)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(141, 20)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Customer Address"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(16, 358)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 20)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Brand :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(129, 328)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(141, 20)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Customer Address"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(16, 328)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(97, 20)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Description :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(129, 478)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(141, 20)
        Me.Label10.TabIndex = 46
        Me.Label10.Text = "Customer Address"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(16, 478)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 20)
        Me.Label11.TabIndex = 45
        Me.Label11.Text = "Price :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(129, 448)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(141, 20)
        Me.Label12.TabIndex = 44
        Me.Label12.Text = "Customer Address"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(16, 448)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(52, 20)
        Me.Label13.TabIndex = 43
        Me.Label13.Text = "Price :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(129, 418)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(141, 20)
        Me.Label14.TabIndex = 42
        Me.Label14.Text = "Customer Address"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(16, 418)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(54, 20)
        Me.Label15.TabIndex = 41
        Me.Label15.Text = "Color :"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(129, 388)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(141, 20)
        Me.Label16.TabIndex = 40
        Me.Label16.Text = "Customer Address"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(16, 388)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(71, 20)
        Me.Label17.TabIndex = 39
        Me.Label17.Text = "Gender :"
        '
        'frmSearchProducts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1248, 665)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSearchProducts"
        Me.Text = "frmSearchProducts"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.productsGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnProceed As MetroFramework.Controls.MetroTile
    Friend WithEvents btnCancel As MetroFramework.Controls.MetroTile
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblCustname As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents AljonCustomUnderlineTextbox3 As AljonCustomControl.Controls.AljonCustomUnderlineTextbox
    Friend WithEvents AljonCustomUnderlineTextbox2 As AljonCustomControl.Controls.AljonCustomUnderlineTextbox
    Friend WithEvents byNameSearchBox As AljonCustomControl.Controls.AljonCustomUnderlineTextbox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents productsGrid As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
End Class
