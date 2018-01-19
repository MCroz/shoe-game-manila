<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
    Inherits MetroFramework.Forms.MetroForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.password = New MetroFramework.Controls.MetroTextBox()
        Me.username = New MetroFramework.Controls.MetroTextBox()
        Me.KawsPB = New System.Windows.Forms.PictureBox()
        Me.OffwhitePB = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnLogin = New MetroFramework.Controls.MetroButton()
        CType(Me.KawsPB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OffwhitePB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'password
        '
        '
        '
        '
        Me.password.CustomButton.Image = Nothing
        Me.password.CustomButton.Location = New System.Drawing.Point(301, 1)
        Me.password.CustomButton.Name = ""
        Me.password.CustomButton.Size = New System.Drawing.Size(37, 37)
        Me.password.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.password.CustomButton.TabIndex = 1
        Me.password.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.password.CustomButton.UseSelectable = True
        Me.password.CustomButton.Visible = False
        Me.password.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.password.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.password.Lines = New String(-1) {}
        Me.password.Location = New System.Drawing.Point(545, 530)
        Me.password.MaxLength = 32767
        Me.password.Name = "password"
        Me.password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.password.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.password.SelectedText = ""
        Me.password.SelectionLength = 0
        Me.password.SelectionStart = 0
        Me.password.ShortcutsEnabled = True
        Me.password.Size = New System.Drawing.Size(339, 39)
        Me.password.Style = MetroFramework.MetroColorStyle.White
        Me.password.TabIndex = 25
        Me.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.password.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.password.UseCustomForeColor = True
        Me.password.UseSelectable = True
        Me.password.UseStyleColors = True
        Me.password.UseSystemPasswordChar = True
        Me.password.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.password.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'username
        '
        '
        '
        '
        Me.username.CustomButton.Image = Nothing
        Me.username.CustomButton.Location = New System.Drawing.Point(301, 1)
        Me.username.CustomButton.Name = ""
        Me.username.CustomButton.Size = New System.Drawing.Size(37, 37)
        Me.username.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.username.CustomButton.TabIndex = 1
        Me.username.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.username.CustomButton.UseSelectable = True
        Me.username.CustomButton.Visible = False
        Me.username.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.username.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.username.Lines = New String(-1) {}
        Me.username.Location = New System.Drawing.Point(545, 468)
        Me.username.MaxLength = 32767
        Me.username.Name = "username"
        Me.username.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.username.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.username.SelectedText = ""
        Me.username.SelectionLength = 0
        Me.username.SelectionStart = 0
        Me.username.ShortcutsEnabled = True
        Me.username.Size = New System.Drawing.Size(339, 39)
        Me.username.Style = MetroFramework.MetroColorStyle.White
        Me.username.TabIndex = 24
        Me.username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.username.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.username.UseCustomForeColor = True
        Me.username.UseSelectable = True
        Me.username.UseStyleColors = True
        Me.username.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.username.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'KawsPB
        '
        Me.KawsPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.KawsPB.Location = New System.Drawing.Point(204, 247)
        Me.KawsPB.Name = "KawsPB"
        Me.KawsPB.Size = New System.Drawing.Size(316, 373)
        Me.KawsPB.TabIndex = 23
        Me.KawsPB.TabStop = False
        '
        'OffwhitePB
        '
        Me.OffwhitePB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.OffwhitePB.Location = New System.Drawing.Point(903, 305)
        Me.OffwhitePB.Name = "OffwhitePB"
        Me.OffwhitePB.Size = New System.Drawing.Size(259, 289)
        Me.OffwhitePB.TabIndex = 22
        Me.OffwhitePB.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(565, 88)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(300, 300)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'btnLogin
        '
        Me.btnLogin.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnLogin.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.btnLogin.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.btnLogin.Highlight = True
        Me.btnLogin.Location = New System.Drawing.Point(545, 590)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(339, 52)
        Me.btnLogin.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnLogin.TabIndex = 20
        Me.btnLogin.Text = "Login"
        Me.btnLogin.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnLogin.UseCustomBackColor = True
        Me.btnLogin.UseCustomForeColor = True
        Me.btnLogin.UseSelectable = True
        '
        'frmLogin
        '
        Me.AcceptButton = Me.btnLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1366, 730)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.username)
        Me.Controls.Add(Me.KawsPB)
        Me.Controls.Add(Me.OffwhitePB)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnLogin)
        Me.Name = "frmLogin"
        Me.Style = MetroFramework.MetroColorStyle.Silver
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        CType(Me.KawsPB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OffwhitePB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents password As MetroFramework.Controls.MetroTextBox
    Friend WithEvents username As MetroFramework.Controls.MetroTextBox
    Friend WithEvents KawsPB As System.Windows.Forms.PictureBox
    Friend WithEvents OffwhitePB As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnLogin As MetroFramework.Controls.MetroButton
End Class
