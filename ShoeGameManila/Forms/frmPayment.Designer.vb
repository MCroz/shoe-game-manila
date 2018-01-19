<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayment
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.JuvyCustomList1 = New JuvyCustomControls.JuvyCustomList()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.OrigPriceTxt = New System.Windows.Forms.Label()
        Me.taxTxt = New System.Windows.Forms.Label()
        Me.subTotalTxt = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.grandTotalTxt = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.pnlMainContainer = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.grandTotalTxt)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.OrigPriceTxt)
        Me.Panel1.Controls.Add(Me.taxTxt)
        Me.Panel1.Controls.Add(Me.subTotalTxt)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.ShapeContainer2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(320, 730)
        Me.Panel1.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(12, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 24)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Items"
        '
        'JuvyCustomList1
        '
        Me.JuvyCustomList1.AutoScroll = True
        Me.JuvyCustomList1.Location = New System.Drawing.Point(-1, -1)
        Me.JuvyCustomList1.Name = "JuvyCustomList1"
        Me.JuvyCustomList1.Size = New System.Drawing.Size(320, 62)
        Me.JuvyCustomList1.TabIndex = 24
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.JuvyCustomList1)
        Me.Panel2.Location = New System.Drawing.Point(-1, 57)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(320, 490)
        Me.Panel2.TabIndex = 24
        '
        'OrigPriceTxt
        '
        Me.OrigPriceTxt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OrigPriceTxt.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrigPriceTxt.ForeColor = System.Drawing.Color.DarkGray
        Me.OrigPriceTxt.Location = New System.Drawing.Point(131, 557)
        Me.OrigPriceTxt.Name = "OrigPriceTxt"
        Me.OrigPriceTxt.Size = New System.Drawing.Size(177, 21)
        Me.OrigPriceTxt.TabIndex = 67
        Me.OrigPriceTxt.Text = "Original Price"
        Me.OrigPriceTxt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.OrigPriceTxt.Visible = False
        '
        'taxTxt
        '
        Me.taxTxt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.taxTxt.BackColor = System.Drawing.Color.Transparent
        Me.taxTxt.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.taxTxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.taxTxt.Location = New System.Drawing.Point(131, 605)
        Me.taxTxt.Name = "taxTxt"
        Me.taxTxt.Size = New System.Drawing.Size(177, 24)
        Me.taxTxt.TabIndex = 66
        Me.taxTxt.Text = "0.00"
        Me.taxTxt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'subTotalTxt
        '
        Me.subTotalTxt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.subTotalTxt.BackColor = System.Drawing.Color.Transparent
        Me.subTotalTxt.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subTotalTxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.subTotalTxt.Location = New System.Drawing.Point(131, 585)
        Me.subTotalTxt.Name = "subTotalTxt"
        Me.subTotalTxt.Size = New System.Drawing.Size(177, 24)
        Me.subTotalTxt.TabIndex = 65
        Me.subTotalTxt.Text = "0.00"
        Me.subTotalTxt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(12, 605)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 24)
        Me.Label6.TabIndex = 64
        Me.Label6.Text = "Tax"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(12, 585)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 24)
        Me.Label8.TabIndex = 63
        Me.Label8.Text = "Subtotal"
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.White
        Me.LineShape1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.LineShape1.BorderWidth = 2
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 13
        Me.LineShape1.X2 = 300
        Me.LineShape1.Y1 = 636
        Me.LineShape1.Y2 = 636
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer2.Size = New System.Drawing.Size(318, 728)
        Me.ShapeContainer2.TabIndex = 68
        Me.ShapeContainer2.TabStop = False
        '
        'grandTotalTxt
        '
        Me.grandTotalTxt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grandTotalTxt.BackColor = System.Drawing.Color.Transparent
        Me.grandTotalTxt.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grandTotalTxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.grandTotalTxt.Location = New System.Drawing.Point(115, 657)
        Me.grandTotalTxt.Name = "grandTotalTxt"
        Me.grandTotalTxt.Size = New System.Drawing.Size(195, 36)
        Me.grandTotalTxt.TabIndex = 70
        Me.grandTotalTxt.Text = "0.00"
        Me.grandTotalTxt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(11, 657)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 36)
        Me.Label10.TabIndex = 69
        Me.Label10.Text = "Total"
        '
        'pnlMainContainer
        '
        Me.pnlMainContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlMainContainer.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlMainContainer.Location = New System.Drawing.Point(320, 58)
        Me.pnlMainContainer.Name = "pnlMainContainer"
        Me.pnlMainContainer.Size = New System.Drawing.Size(1046, 672)
        Me.pnlMainContainer.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(332, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 24)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "Actions"
        '
        'frmPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1366, 730)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pnlMainContainer)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPayment"
        Me.Text = "frmPayment"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents grandTotalTxt As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents OrigPriceTxt As System.Windows.Forms.Label
    Friend WithEvents taxTxt As System.Windows.Forms.Label
    Friend WithEvents subTotalTxt As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents JuvyCustomList1 As JuvyCustomControls.JuvyCustomList
    Friend WithEvents ShapeContainer2 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents pnlMainContainer As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
