<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.btnCheck = New DevComponents.DotNetBar.ButtonX()
        Me.rbError = New System.Windows.Forms.RichTextBox()
        Me.btnHH = New DevComponents.DotNetBar.ButtonX()
        Me.LV = New DevComponents.DotNetBar.Controls.ListViewEx()
        Me.Type = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PB = New System.Windows.Forms.ProgressBar()
        Me.lblState = New DevComponents.DotNetBar.LabelX()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtDir = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.FB = New System.Windows.Forms.FolderBrowserDialog()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.GroupPanel1.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCheck
        '
        Me.btnCheck.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCheck.Location = New System.Drawing.Point(3, 12)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(103, 23)
        Me.btnCheck.TabIndex = 0
        Me.btnCheck.Text = "校验前期条件"
        '
        'rbError
        '
        Me.rbError.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbError.BackColor = System.Drawing.Color.Black
        Me.rbError.Font = New System.Drawing.Font("微软雅黑", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbError.ForeColor = System.Drawing.Color.White
        Me.rbError.HideSelection = False
        Me.rbError.Location = New System.Drawing.Point(232, 1)
        Me.rbError.Name = "rbError"
        Me.rbError.Size = New System.Drawing.Size(515, 691)
        Me.rbError.TabIndex = 12
        Me.rbError.Text = ""
        '
        'btnHH
        '
        Me.btnHH.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnHH.Enabled = False
        Me.btnHH.Location = New System.Drawing.Point(124, 12)
        Me.btnHH.Name = "btnHH"
        Me.btnHH.Size = New System.Drawing.Size(102, 23)
        Me.btnHH.TabIndex = 13
        Me.btnHH.Text = "开始汉化"
        '
        'LV
        '
        '
        '
        '
        Me.LV.Border.Class = "ListViewBorder"
        Me.LV.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Type})
        Me.LV.Font = New System.Drawing.Font("微软雅黑", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LV.FullRowSelect = True
        Me.LV.Location = New System.Drawing.Point(6, 463)
        Me.LV.Name = "LV"
        Me.LV.Size = New System.Drawing.Size(217, 229)
        Me.LV.TabIndex = 46
        Me.LV.UseCompatibleStateImageBehavior = False
        Me.LV.View = System.Windows.Forms.View.Details
        '
        'Type
        '
        Me.Type.Text = "汉化对象"
        Me.Type.Width = 350
        '
        'PB
        '
        Me.PB.Location = New System.Drawing.Point(3, 67)
        Me.PB.Name = "PB"
        Me.PB.Size = New System.Drawing.Size(223, 21)
        Me.PB.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.PB.TabIndex = 47
        '
        'lblState
        '
        Me.lblState.BorderType = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.lblState.Location = New System.Drawing.Point(6, 345)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(217, 77)
        Me.lblState.TabIndex = 48
        Me.lblState.WordWrap = True
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.pictureBox1)
        Me.GroupPanel1.Location = New System.Drawing.Point(3, 94)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(223, 236)
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
        Me.GroupPanel1.TabIndex = 49
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
        Me.pictureBox1.Size = New System.Drawing.Size(217, 212)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox1.TabIndex = 41
        Me.pictureBox1.TabStop = False
        '
        'txtDir
        '
        '
        '
        '
        Me.txtDir.Border.Class = "TextBoxBorder"
        Me.txtDir.Location = New System.Drawing.Point(3, 42)
        Me.txtDir.Name = "txtDir"
        Me.txtDir.Size = New System.Drawing.Size(223, 18)
        Me.txtDir.TabIndex = 50
        Me.txtDir.WatermarkText = "点击选择Innovator安装目录"
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.BurlyWood
        Me.LabelX1.ForeColor = System.Drawing.Color.White
        Me.LabelX1.Location = New System.Drawing.Point(6, 427)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(217, 33)
        Me.LabelX1.TabIndex = 51
        Me.LabelX1.Text = "版权所有 @ OBOT" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "问题请联系作者QQ 404474757改善"
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(747, 694)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.txtDir)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Controls.Add(Me.lblState)
        Me.Controls.Add(Me.PB)
        Me.Controls.Add(Me.LV)
        Me.Controls.Add(Me.btnHH)
        Me.Controls.Add(Me.rbError)
        Me.Controls.Add(Me.btnCheck)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aras汉化"
        Me.GroupPanel1.ResumeLayout(False)
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCheck As DevComponents.DotNetBar.ButtonX
    Private WithEvents rbError As System.Windows.Forms.RichTextBox
    Friend WithEvents btnHH As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LV As DevComponents.DotNetBar.Controls.ListViewEx
    Friend WithEvents Type As System.Windows.Forms.ColumnHeader
    Friend WithEvents PB As System.Windows.Forms.ProgressBar
    Friend WithEvents lblState As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Private WithEvents pictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtDir As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents FB As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
End Class
