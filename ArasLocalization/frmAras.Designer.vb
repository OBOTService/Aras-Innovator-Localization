<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAras
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAras))
        Me.btnLogin = New DevComponents.DotNetBar.ButtonX()
        Me.txtServerURL = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.btnGetDB = New DevComponents.DotNetBar.ButtonX()
        Me.cmbDB = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.txtPassword = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtUserName = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.GB = New System.Windows.Forms.GroupBox()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pictureBox = New System.Windows.Forms.PictureBox()
        Me.EN = New DevComponents.Editors.ComboItem()
        Me.CN = New DevComponents.Editors.ComboItem()
        Me.bt = New DevComponents.DotNetBar.BalloonTip()
        Me.timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GB.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLogin
        '
        Me.btnLogin.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnLogin.Font = New System.Drawing.Font("微软雅黑", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.Location = New System.Drawing.Point(51, 191)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(170, 40)
        Me.btnLogin.TabIndex = 1
        Me.btnLogin.Text = "登入"
        '
        'txtServerURL
        '
        '
        '
        '
        Me.txtServerURL.Border.Class = "TextBoxBorder"
        Me.txtServerURL.Font = New System.Drawing.Font("微软雅黑", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtServerURL.Location = New System.Drawing.Point(9, 85)
        Me.txtServerURL.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtServerURL.Name = "txtServerURL"
        Me.txtServerURL.Size = New System.Drawing.Size(237, 19)
        Me.txtServerURL.TabIndex = 3
        Me.txtServerURL.Text = "http://localhost/InnovatorServer"
        Me.txtServerURL.WatermarkText = "服务器URL"
        '
        'btnGetDB
        '
        Me.btnGetDB.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnGetDB.Location = New System.Drawing.Point(243, 85)
        Me.btnGetDB.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnGetDB.Name = "btnGetDB"
        Me.btnGetDB.Size = New System.Drawing.Size(22, 19)
        Me.btnGetDB.TabIndex = 4
        Me.btnGetDB.Text = "."
        '
        'cmbDB
        '
        Me.cmbDB.DisplayMember = "Text"
        Me.cmbDB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbDB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDB.Font = New System.Drawing.Font("微软雅黑", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDB.FormattingEnabled = True
        Me.cmbDB.ItemHeight = 15
        Me.cmbDB.Location = New System.Drawing.Point(9, 111)
        Me.cmbDB.Name = "cmbDB"
        Me.cmbDB.Size = New System.Drawing.Size(256, 21)
        Me.cmbDB.TabIndex = 7
        Me.cmbDB.WatermarkText = "数据库"
        '
        'txtPassword
        '
        '
        '
        '
        Me.txtPassword.Border.Class = "TextBoxBorder"
        Me.txtPassword.Font = New System.Drawing.Font("微软雅黑", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(9, 164)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(256, 19)
        Me.txtPassword.TabIndex = 10
        Me.txtPassword.Text = "innovator"
        Me.txtPassword.WatermarkText = "密码"
        '
        'txtUserName
        '
        '
        '
        '
        Me.txtUserName.Border.Class = "TextBoxBorder"
        Me.txtUserName.Font = New System.Drawing.Font("微软雅黑", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserName.Location = New System.Drawing.Point(9, 138)
        Me.txtUserName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(256, 19)
        Me.txtUserName.TabIndex = 9
        Me.txtUserName.Text = "root"
        Me.txtUserName.WatermarkText = "用户名"
        '
        'GB
        '
        Me.GB.BackColor = System.Drawing.Color.Transparent
        Me.GB.Controls.Add(Me.GroupPanel1)
        Me.GB.Controls.Add(Me.pictureBox)
        Me.GB.Controls.Add(Me.cmbDB)
        Me.GB.Controls.Add(Me.txtPassword)
        Me.GB.Controls.Add(Me.btnLogin)
        Me.GB.Controls.Add(Me.txtUserName)
        Me.GB.Controls.Add(Me.txtServerURL)
        Me.GB.Controls.Add(Me.btnGetDB)
        Me.GB.Location = New System.Drawing.Point(0, 0)
        Me.GB.Name = "GB"
        Me.GB.Size = New System.Drawing.Size(271, 458)
        Me.GB.TabIndex = 42
        Me.GB.TabStop = False
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.pictureBox1)
        Me.GroupPanel1.Location = New System.Drawing.Point(6, 237)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(256, 215)
        '
        '
        '
        Me.GroupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel1.Style.BackColorGradientAngle = 90
        Me.GroupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderBottomWidth = 1
        Me.GroupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderLeftWidth = 1
        Me.GroupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderRightWidth = 1
        Me.GroupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderTopWidth = 1
        Me.GroupPanel1.Style.CornerDiameter = 4
        Me.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.GroupPanel1.TabIndex = 44
        Me.GroupPanel1.Text = "点击进入官网"
        '
        'pictureBox1
        '
        Me.pictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(250, 191)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox1.TabIndex = 41
        Me.pictureBox1.TabStop = False
        '
        'pictureBox
        '
        Me.pictureBox.BackColor = System.Drawing.Color.Transparent
        Me.pictureBox.Image = CType(resources.GetObject("pictureBox.Image"), System.Drawing.Image)
        Me.pictureBox.Location = New System.Drawing.Point(61, 18)
        Me.pictureBox.Name = "pictureBox"
        Me.pictureBox.Size = New System.Drawing.Size(150, 61)
        Me.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pictureBox.TabIndex = 43
        Me.pictureBox.TabStop = False
        '
        'EN
        '
        Me.EN.Image = CType(resources.GetObject("EN.Image"), System.Drawing.Image)
        Me.EN.Text = "English"
        Me.EN.TextLineAlignment = System.Drawing.StringAlignment.Center
        '
        'CN
        '
        Me.CN.Image = CType(resources.GetObject("CN.Image"), System.Drawing.Image)
        Me.CN.Text = "中文简体"
        Me.CN.TextLineAlignment = System.Drawing.StringAlignment.Center
        '
        'bt
        '
        Me.bt.AlertAnimation = DevComponents.DotNetBar.eAlertAnimation.TopToBottom
        Me.bt.AutoCloseTimeOut = 2
        Me.bt.DefaultBalloonWidth = 100
        '
        'timer1
        '
        Me.timer1.Interval = 3000
        '
        'frmAras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(273, 461)
        Me.Controls.Add(Me.GB)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aras登入"
        Me.GB.ResumeLayout(False)
        Me.GB.PerformLayout()
        Me.GroupPanel1.ResumeLayout(False)
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents pictureBox As System.Windows.Forms.PictureBox
    Private WithEvents btnLogin As DevComponents.DotNetBar.ButtonX
    Private WithEvents txtServerURL As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents btnGetDB As DevComponents.DotNetBar.ButtonX
    Private WithEvents pictureBox1 As System.Windows.Forms.PictureBox
    Private WithEvents cmbDB As DevComponents.DotNetBar.Controls.ComboBoxEx
    Private WithEvents txtPassword As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents txtUserName As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents GB As System.Windows.Forms.GroupBox
    Private WithEvents EN As DevComponents.Editors.ComboItem
    Private WithEvents CN As DevComponents.Editors.ComboItem
    Private WithEvents bt As DevComponents.DotNetBar.BalloonTip
    Private WithEvents timer1 As System.Windows.Forms.Timer
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
End Class
