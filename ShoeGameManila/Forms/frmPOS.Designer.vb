<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPOS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPOS))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.POSSearchBox = New System.Windows.Forms.TextBox()
        Me.MetroRadioButton1 = New MetroFramework.Controls.MetroRadioButton()
        Me.MetroRadioButton2 = New MetroFramework.Controls.MetroRadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblOrigPrice = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblSubTotal = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnMenu = New MetroFramework.Controls.MetroTile()
        Me.btnVoidOrder = New MetroFramework.Controls.MetroTile()
        Me.btnPayment = New MetroFramework.Controls.MetroTile()
        Me.btnDiscount = New MetroFramework.Controls.MetroTile()
        Me.btnClear = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnQuantity = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnSearch = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnDelete = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuCustomDataGrid1 = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.btnClear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuCustomDataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'POSSearchBox
        '
        Me.POSSearchBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.POSSearchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.POSSearchBox.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.POSSearchBox.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.POSSearchBox.Location = New System.Drawing.Point(217, 22)
        Me.POSSearchBox.Name = "POSSearchBox"
        Me.POSSearchBox.Size = New System.Drawing.Size(1084, 33)
        Me.POSSearchBox.TabIndex = 2
        '
        'MetroRadioButton1
        '
        Me.MetroRadioButton1.AutoSize = True
        Me.MetroRadioButton1.FontSize = MetroFramework.MetroCheckBoxSize.Tall
        Me.MetroRadioButton1.ForeColor = System.Drawing.Color.White
        Me.MetroRadioButton1.Location = New System.Drawing.Point(12, 26)
        Me.MetroRadioButton1.Name = "MetroRadioButton1"
        Me.MetroRadioButton1.Size = New System.Drawing.Size(99, 25)
        Me.MetroRadioButton1.TabIndex = 3
        Me.MetroRadioButton1.Text = "By Name"
        Me.MetroRadioButton1.UseCustomBackColor = True
        Me.MetroRadioButton1.UseCustomForeColor = True
        Me.MetroRadioButton1.UseSelectable = True
        Me.MetroRadioButton1.UseStyleColors = True
        '
        'MetroRadioButton2
        '
        Me.MetroRadioButton2.AutoSize = True
        Me.MetroRadioButton2.FontSize = MetroFramework.MetroCheckBoxSize.Tall
        Me.MetroRadioButton2.ForeColor = System.Drawing.Color.White
        Me.MetroRadioButton2.Location = New System.Drawing.Point(117, 26)
        Me.MetroRadioButton2.Name = "MetroRadioButton2"
        Me.MetroRadioButton2.Size = New System.Drawing.Size(94, 25)
        Me.MetroRadioButton2.TabIndex = 4
        Me.MetroRadioButton2.Text = "By Code"
        Me.MetroRadioButton2.UseCustomBackColor = True
        Me.MetroRadioButton2.UseCustomForeColor = True
        Me.MetroRadioButton2.UseSelectable = True
        Me.MetroRadioButton2.UseStyleColors = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblOrigPrice)
        Me.Panel1.Controls.Add(Me.lblTotal)
        Me.Panel1.Controls.Add(Me.lblTax)
        Me.Panel1.Controls.Add(Me.lblSubTotal)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.BunifuCustomDataGrid1)
        Me.Panel1.Controls.Add(Me.ShapeContainer1)
        Me.Panel1.Location = New System.Drawing.Point(-1, 73)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1369, 657)
        Me.Panel1.TabIndex = 6
        '
        'lblOrigPrice
        '
        Me.lblOrigPrice.AutoSize = True
        Me.lblOrigPrice.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrigPrice.ForeColor = System.Drawing.Color.White
        Me.lblOrigPrice.Location = New System.Drawing.Point(866, 477)
        Me.lblOrigPrice.Name = "lblOrigPrice"
        Me.lblOrigPrice.Size = New System.Drawing.Size(50, 21)
        Me.lblOrigPrice.TabIndex = 9
        Me.lblOrigPrice.Text = "00.00"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.White
        Me.lblTotal.Location = New System.Drawing.Point(835, 585)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(87, 36)
        Me.lblTotal.TabIndex = 8
        Me.lblTotal.Text = "00.00"
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTax.ForeColor = System.Drawing.Color.White
        Me.lblTax.Location = New System.Drawing.Point(853, 529)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(63, 24)
        Me.lblTax.TabIndex = 7
        Me.lblTax.Text = "00.00"
        '
        'lblSubTotal
        '
        Me.lblSubTotal.AutoSize = True
        Me.lblSubTotal.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTotal.ForeColor = System.Drawing.Color.White
        Me.lblSubTotal.Location = New System.Drawing.Point(853, 498)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(63, 24)
        Me.lblSubTotal.TabIndex = 6
        Me.lblSubTotal.Text = "00.00"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(592, 585)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 36)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Total"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(594, 529)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Tax"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(594, 498)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Sub Total"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnMenu)
        Me.Panel2.Controls.Add(Me.btnVoidOrder)
        Me.Panel2.Controls.Add(Me.btnPayment)
        Me.Panel2.Controls.Add(Me.btnDiscount)
        Me.Panel2.Controls.Add(Me.btnClear)
        Me.Panel2.Controls.Add(Me.btnQuantity)
        Me.Panel2.Controls.Add(Me.btnSearch)
        Me.Panel2.Controls.Add(Me.btnDelete)
        Me.Panel2.Location = New System.Drawing.Point(938, -1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(430, 657)
        Me.Panel2.TabIndex = 1
        '
        'btnMenu
        '
        Me.btnMenu.ActiveControl = Nothing
        Me.btnMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.btnMenu.Location = New System.Drawing.Point(305, 519)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(114, 105)
        Me.btnMenu.TabIndex = 23
        Me.btnMenu.Text = ". . . "
        Me.btnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnMenu.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.btnMenu.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular
        Me.btnMenu.UseCustomBackColor = True
        Me.btnMenu.UseSelectable = True
        Me.btnMenu.UseStyleColors = True
        '
        'btnVoidOrder
        '
        Me.btnVoidOrder.ActiveControl = Nothing
        Me.btnVoidOrder.BackColor = System.Drawing.Color.Firebrick
        Me.btnVoidOrder.Location = New System.Drawing.Point(8, 518)
        Me.btnVoidOrder.Name = "btnVoidOrder"
        Me.btnVoidOrder.Size = New System.Drawing.Size(292, 107)
        Me.btnVoidOrder.TabIndex = 22
        Me.btnVoidOrder.Text = "Void Order"
        Me.btnVoidOrder.UseCustomBackColor = True
        Me.btnVoidOrder.UseSelectable = True
        Me.btnVoidOrder.UseStyleColors = True
        '
        'btnPayment
        '
        Me.btnPayment.ActiveControl = Nothing
        Me.btnPayment.BackColor = System.Drawing.Color.SeaGreen
        Me.btnPayment.Location = New System.Drawing.Point(8, 404)
        Me.btnPayment.Name = "btnPayment"
        Me.btnPayment.Size = New System.Drawing.Size(411, 107)
        Me.btnPayment.TabIndex = 0
        Me.btnPayment.Text = "Payment"
        Me.btnPayment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnPayment.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.btnPayment.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular
        Me.btnPayment.UseCustomBackColor = True
        Me.btnPayment.UseSelectable = True
        Me.btnPayment.UseStyleColors = True
        '
        'btnDiscount
        '
        Me.btnDiscount.ActiveControl = Nothing
        Me.btnDiscount.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.btnDiscount.Location = New System.Drawing.Point(8, 290)
        Me.btnDiscount.Name = "btnDiscount"
        Me.btnDiscount.Size = New System.Drawing.Size(411, 108)
        Me.btnDiscount.TabIndex = 21
        Me.btnDiscount.Text = "Discount"
        Me.btnDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnDiscount.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnDiscount.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.btnDiscount.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular
        Me.btnDiscount.UseCustomBackColor = True
        Me.btnDiscount.UseSelectable = True
        Me.btnDiscount.UseStyleColors = True
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnClear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btnClear.Image = CType(resources.GetObject("btnClear.Image"), System.Drawing.Image)
        Me.btnClear.ImageActive = Nothing
        Me.btnClear.Location = New System.Drawing.Point(320, 7)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(99, 106)
        Me.btnClear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnClear.TabIndex = 20
        Me.btnClear.TabStop = False
        Me.btnClear.Zoom = 10
        '
        'btnQuantity
        '
        Me.btnQuantity.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btnQuantity.Image = CType(resources.GetObject("btnQuantity.Image"), System.Drawing.Image)
        Me.btnQuantity.ImageActive = Nothing
        Me.btnQuantity.Location = New System.Drawing.Point(217, 7)
        Me.btnQuantity.Name = "btnQuantity"
        Me.btnQuantity.Size = New System.Drawing.Size(99, 106)
        Me.btnQuantity.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnQuantity.TabIndex = 19
        Me.btnQuantity.TabStop = False
        Me.btnQuantity.Zoom = 10
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageActive = Nothing
        Me.btnSearch.Location = New System.Drawing.Point(113, 7)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(99, 106)
        Me.btnSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnSearch.TabIndex = 18
        Me.btnSearch.TabStop = False
        Me.btnSearch.Zoom = 10
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnDelete.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.ImageActive = Nothing
        Me.btnDelete.Location = New System.Drawing.Point(8, 7)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(99, 106)
        Me.btnDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnDelete.TabIndex = 17
        Me.btnDelete.TabStop = False
        Me.btnDelete.Zoom = 10
        '
        'BunifuCustomDataGrid1
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.BunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.BunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.BunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BunifuCustomDataGrid1.DoubleBuffered = True
        Me.BunifuCustomDataGrid1.EnableHeadersVisualStyles = False
        Me.BunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.SeaGreen
        Me.BunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuCustomDataGrid1.Location = New System.Drawing.Point(-1, 0)
        Me.BunifuCustomDataGrid1.Name = "BunifuCustomDataGrid1"
        Me.BunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.BunifuCustomDataGrid1.Size = New System.Drawing.Size(939, 474)
        Me.BunifuCustomDataGrid1.TabIndex = 0
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1367, 655)
        Me.ShapeContainer1.TabIndex = 5
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.DimGray
        Me.LineShape1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.LineShape1.BorderWidth = 3
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 597
        Me.LineShape1.X2 = 914
        Me.LineShape1.Y1 = 573
        Me.LineShape1.Y2 = 573
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.BunifuImageButton1.Image = CType(resources.GetObject("BunifuImageButton1.Image"), System.Drawing.Image)
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(1307, 22)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(37, 33)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 5
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'frmPOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1366, 730)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BunifuImageButton1)
        Me.Controls.Add(Me.MetroRadioButton2)
        Me.Controls.Add(Me.MetroRadioButton1)
        Me.Controls.Add(Me.POSSearchBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "v"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.btnClear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnDelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuCustomDataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents POSSearchBox As System.Windows.Forms.TextBox
    Friend WithEvents MetroRadioButton1 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents MetroRadioButton2 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BunifuCustomDataGrid1 As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnQuantity As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnSearch As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnDelete As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnClear As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnMenu As MetroFramework.Controls.MetroTile
    Friend WithEvents btnVoidOrder As MetroFramework.Controls.MetroTile
    Friend WithEvents btnPayment As MetroFramework.Controls.MetroTile
    Friend WithEvents btnDiscount As MetroFramework.Controls.MetroTile
    Friend WithEvents lblOrigPrice As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblTax As System.Windows.Forms.Label
    Friend WithEvents lblSubTotal As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
End Class
