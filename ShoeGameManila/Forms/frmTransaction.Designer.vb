<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTransaction
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.idPesoTxtbox = New Syncfusion.Windows.Forms.Tools.CurrencyTextBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblChange = New System.Windows.Forms.Label()
        Me.MetroTile3 = New MetroFramework.Controls.MetroTile()
        Me.MetroTile4 = New MetroFramework.Controls.MetroTile()
        Me.ButtonAdv1 = New Syncfusion.Windows.Forms.ButtonAdv()
        Me.ButtonAdv2 = New Syncfusion.Windows.Forms.ButtonAdv()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.idPesoTxtbox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblChange)
        Me.Panel1.Controls.Add(Me.lblTotal)
        Me.Panel1.Controls.Add(Me.idPesoTxtbox)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 110)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1046, 413)
        Me.Panel1.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(39, 171)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 29)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Change   :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(39, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 29)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Paid         :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(39, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 29)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Total        :"
        '
        'idPesoTxtbox
        '
        Me.idPesoTxtbox.BackGroundColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.idPesoTxtbox.BeforeTouchSize = New System.Drawing.Size(100, 20)
        Me.idPesoTxtbox.BorderColor = System.Drawing.Color.DeepSkyBlue
        Me.idPesoTxtbox.BorderSides = System.Windows.Forms.Border3DSide.Bottom
        Me.idPesoTxtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.idPesoTxtbox.Culture = New System.Globalization.CultureInfo("en-PH")
        Me.idPesoTxtbox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.idPesoTxtbox.DecimalValue = New Decimal(New Integer() {100, 0, 0, 131072})
        Me.idPesoTxtbox.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idPesoTxtbox.ForeColor = System.Drawing.Color.White
        Me.idPesoTxtbox.Location = New System.Drawing.Point(209, 86)
        Me.idPesoTxtbox.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.idPesoTxtbox.MinValue = New Decimal(New Integer() {100, 0, 0, 131072})
        Me.idPesoTxtbox.Name = "idPesoTxtbox"
        Me.idPesoTxtbox.NullString = ""
        Me.idPesoTxtbox.PositiveColor = System.Drawing.Color.White
        Me.idPesoTxtbox.Size = New System.Drawing.Size(812, 43)
        Me.idPesoTxtbox.SpecialCultureValue = Syncfusion.Windows.Forms.Tools.SpecialCultureValues.None
        Me.idPesoTxtbox.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.idPesoTxtbox.TabIndex = 24
        Me.idPesoTxtbox.Text = "₱1.00"
        Me.idPesoTxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.White
        Me.lblTotal.Location = New System.Drawing.Point(950, 45)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(71, 29)
        Me.lblTotal.TabIndex = 25
        Me.lblTotal.Text = "00.00"
        '
        'lblChange
        '
        Me.lblChange.AutoSize = True
        Me.lblChange.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChange.ForeColor = System.Drawing.Color.White
        Me.lblChange.Location = New System.Drawing.Point(950, 171)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(71, 29)
        Me.lblChange.TabIndex = 26
        Me.lblChange.Text = "00.00"
        '
        'MetroTile3
        '
        Me.MetroTile3.ActiveControl = Nothing
        Me.MetroTile3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroTile3.BackColor = System.Drawing.Color.ForestGreen
        Me.MetroTile3.Location = New System.Drawing.Point(749, 14)
        Me.MetroTile3.Name = "MetroTile3"
        Me.MetroTile3.Size = New System.Drawing.Size(273, 56)
        Me.MetroTile3.TabIndex = 7
        Me.MetroTile3.Text = "Proceed"
        Me.MetroTile3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroTile3.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.MetroTile3.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular
        Me.MetroTile3.UseCustomBackColor = True
        Me.MetroTile3.UseSelectable = True
        '
        'MetroTile4
        '
        Me.MetroTile4.ActiveControl = Nothing
        Me.MetroTile4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroTile4.BackColor = System.Drawing.Color.Firebrick
        Me.MetroTile4.Location = New System.Drawing.Point(750, 76)
        Me.MetroTile4.Name = "MetroTile4"
        Me.MetroTile4.Size = New System.Drawing.Size(272, 56)
        Me.MetroTile4.TabIndex = 8
        Me.MetroTile4.Text = "Cancel"
        Me.MetroTile4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroTile4.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroTile4.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.MetroTile4.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular
        Me.MetroTile4.UseCustomBackColor = True
        Me.MetroTile4.UseSelectable = True
        '
        'ButtonAdv1
        '
        Me.ButtonAdv1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonAdv1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ButtonAdv1.BeforeTouchSize = New System.Drawing.Size(253, 64)
        Me.ButtonAdv1.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Flat
        Me.ButtonAdv1.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue
        Me.ButtonAdv1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAdv1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAdv1.ForeColor = System.Drawing.Color.White
        Me.ButtonAdv1.Image = Global.ShoeGameManila.My.Resources.Resources.DASHBOARD
        Me.ButtonAdv1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonAdv1.IsBackStageButton = False
        Me.ButtonAdv1.Location = New System.Drawing.Point(506, 22)
        Me.ButtonAdv1.Name = "ButtonAdv1"
        Me.ButtonAdv1.Size = New System.Drawing.Size(253, 64)
        Me.ButtonAdv1.TabIndex = 9
        Me.ButtonAdv1.Text = "Discount"
        '
        'ButtonAdv2
        '
        Me.ButtonAdv2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonAdv2.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ButtonAdv2.BeforeTouchSize = New System.Drawing.Size(253, 64)
        Me.ButtonAdv2.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Flat
        Me.ButtonAdv2.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue
        Me.ButtonAdv2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAdv2.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAdv2.ForeColor = System.Drawing.Color.White
        Me.ButtonAdv2.Image = Global.ShoeGameManila.My.Resources.Resources.DASHBOARD
        Me.ButtonAdv2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonAdv2.IsBackStageButton = False
        Me.ButtonAdv2.Location = New System.Drawing.Point(769, 22)
        Me.ButtonAdv2.Name = "ButtonAdv2"
        Me.ButtonAdv2.Size = New System.Drawing.Size(253, 64)
        Me.ButtonAdv2.TabIndex = 10
        Me.ButtonAdv2.Text = "Customer"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.ButtonAdv2)
        Me.Panel2.Controls.Add(Me.ButtonAdv1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1046, 110)
        Me.Panel2.TabIndex = 9
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.MetroTile3)
        Me.Panel3.Controls.Add(Me.MetroTile4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 523)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1046, 149)
        Me.Panel3.TabIndex = 10
        '
        'frmTransaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1046, 672)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmTransaction"
        Me.Text = "frmTransaction"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.idPesoTxtbox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblChange As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents idPesoTxtbox As Syncfusion.Windows.Forms.Tools.CurrencyTextBox
    Friend WithEvents MetroTile3 As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroTile4 As MetroFramework.Controls.MetroTile
    Friend WithEvents ButtonAdv1 As Syncfusion.Windows.Forms.ButtonAdv
    Friend WithEvents ButtonAdv2 As Syncfusion.Windows.Forms.ButtonAdv
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
End Class
