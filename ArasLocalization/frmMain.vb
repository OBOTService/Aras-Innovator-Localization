Imports Aras.IOM
Imports System.Xml
Imports bwCoreFuncs.CsGeneric
Imports System.Threading
Imports System.IO

Public Class frmMain
    Public Shared inn As Innovator = Nothing
    Public Shared Lang As String = "en"


    Private Sub btnStart_Click(sender As System.Object, e As System.EventArgs) Handles btnCheck.Click
        Dim LangId As String = ""
        '判定Language和Local是否已经存在
        Dim isok As Boolean = ExecLang(LangId)
        If String.IsNullOrEmpty(LangId) Then
            'RBAppText("获取Language失败，已停止执行")
            Return
        End If

        isok = ExecLoacl(LangId)
        If isok = True Then
            lblState.Text = "校验完成，可以执行汉化"
            btnHH.Enabled = True
        Else
            lblState.Text = "校验失败，不可以执行汉化"
        End If
    End Sub

    Public Function ExecLang(ByRef LangId As String) As Boolean
        Try
            Dim strAML As String = "<AML><Item type='Language' action='get'><code>zh</code><collation>简体中文</collation><direction>ltr</direction><name>Simplified Chinese</name><suffix>_zh</suffix></Item></AML>"
            Dim langItem As Item = inn.applyAML(strAML)
            If langItem.isError Then RBAppText("获取Language警告：" & langItem.getErrorString())

            If langItem.getItemCount() < 1 Then
                'RBAppText("未发现简体中文Language，正在添加....")

                strAML = "<AML><Item type='Language' action='add'><code>zh</code><collation>简体中文</collation><direction>ltr</direction><name>Simplified Chinese</name><suffix>_zh</suffix></Item></AML>"
                langItem = inn.applyAML(strAML)
                If langItem.isError Then
                    'RBAppText("添加Language失败：" & langItem.getErrorString())
                    MsgBox("添加Language失败：" & langItem.getErrorString())
                    Return False
                    'Else
                    '    RBAppText("简体中文Language添加成功")
                End If

            Else
                'RBAppText("简体中文Language，已经存在....")
            End If

            LangId = langItem.getID()
            Return True
        Catch ex As Exception
            RBAppText("异常" & ex.Message)
            Return False
        End Try
    End Function

    Public Function ExecLoacl(ByVal LangId As String) As Boolean
        Try
            Dim strAML As String = "<AML><Item type='Locale' action='get'><code>zh-cn</code><name>China</name></Item></AML>"
            Dim localItem As Item = inn.applyAML(strAML)
            If localItem.isError Then RBAppText("获取Locale警告：" & localItem.getErrorString())

            If localItem.getItemCount() < 1 Then
                ' RBAppText("未发现简体中文Locale，正在添加....")

                strAML = "<AML><Item type='Locale' action='add'><code>zh-cn</code><language keyed_name='Simplified Chinese' type='Language'>" & LangId & "</language><name>China</name></Item></AML>"
                localItem = inn.applyAML(strAML)
                If localItem.isError Then
                    ' RBAppText("添加Locale失败：" & localItem.getErrorString()) 
                    MsgBox("添加Locale失败：" & localItem.getErrorString())
                    Return False
                Else
                    RBAppText("简体中文Locale添加成功")
                End If
            Else
                RBAppText("简体中文Locale，已经存在....")
            End If

            Return True
        Catch ex As Exception
            Return False
            RBAppText("异常" & ex.Message)
        End Try
    End Function

    Private Sub RBAppText(ByVal value As String)
        Dim StartLength As Integer = rbError.Text.Length
        rbError.AppendText("[" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:fff") + "]" + value + Environment.NewLine)
        Dim Length As Integer = ("[" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:fff") + "]" + value).Length

        If value.Contains("错误") Then
            rbError.Select(StartLength, Length)
            rbError.SelectionColor = Color.Red
            rbError.SelectionFont = New Font("微软雅黑", 9, FontStyle.Bold)
        ElseIf value.Contains("异常") Then
            rbError.Select(StartLength, Length)
            rbError.SelectionColor = Color.Red
            rbError.SelectionFont = New Font("微软雅黑", 9, FontStyle.Bold)
        ElseIf value.Contains("警告") Then
            rbError.Select(StartLength, Length)
            rbError.SelectionColor = Color.Yellow
            rbError.SelectionFont = New Font("微软雅黑", 9, FontStyle.Bold)
        ElseIf value.Contains("成功") Then
            rbError.Select(StartLength, Length)
            rbError.SelectionColor = Color.Green
            rbError.SelectionFont = New Font("微软雅黑", 9, FontStyle.Bold)
        ElseIf value.Contains("提示") Then
            rbError.Select(StartLength, Length)
            rbError.SelectionColor = Color.Green
            rbError.SelectionFont = New Font("微软雅黑", 9, FontStyle.Bold)
        End If
        rbError.ScrollToCaret()
    End Sub

    Private Sub btnHH_Click(sender As System.Object, e As System.EventArgs) Handles btnHH.Click
        Dim runThread As Thread = New Thread(AddressOf Start)
        runThread.IsBackground = True
        runThread.Start()
    End Sub

    Public Sub Start()
        Dim mi As MethodInvoker = New MethodInvoker(AddressOf Me.Run)
        Me.BeginInvoke(mi)
    End Sub

    Public Sub Run()
        lblState.Text = "正在汉化..."
        btnHH.Enabled = False

        Try
            '汉化客户端
            If String.IsNullOrEmpty(txtDir.Text) Or Not Directory.Exists(txtDir.Text) Then
                If Not MsgBox("客户端安装目录未选取或者选择错误，将需要你手动汉化Client端，是否继续", MsgBoxStyle.OkCancel, "警告") = MsgBoxResult.Ok Then
                    lblState.Text = "已取消汉化..."
                    Return
                End If
            Else
                Dim Client As String = New System.IO.FileInfo(System.Reflection.Assembly.GetExecutingAssembly().Location).Directory.FullName + "\Chinese_Simplified\Client"
                copyDirectory(Client, txtDir.Text & "\Innovator\Client")
            End If

        Catch ex As Exception
            MsgBox("处理Client端出错,需要您手动更新Client,此报错不影响数据库汉化，即将开始数据库汉化")
        End Try

        System.Windows.Forms.Application.DoEvents()
        Thread.Sleep(100)

        Dim Index As Integer = 1
        Dim Total As Integer = LV.Items.Count
        For Each lvItm As ListViewItem In LV.Items
            Try
                lvItm.BackColor = Color.Yellow
                System.Windows.Forms.Application.DoEvents()
                Thread.Sleep(100)

                RBAppText("=========汉化第" & Index.ToString() & "步,总计" & Total.ToString() & "步============")
                HH(lvItm.Text)

                lvItm.BackColor = Color.Green
                Index += 1
            Catch ex As Exception
                Continue For
            End Try         
        Next

        btnHH.Enabled = True
        lblState.Text = "汉化完成，请清除浏览器缓存并重新打开Innovator"
    End Sub

    Private Sub copyDirectory(ByVal sPath As String, ByVal DPath As String)
        Dim directories As String() = System.IO.Directory.GetDirectories(sPath)
        If Not System.IO.Directory.Exists(DPath) Then
            System.IO.Directory.CreateDirectory(DPath)
        End If

        Dim dir As System.IO.DirectoryInfo = New System.IO.DirectoryInfo(sPath)
        Dim dirs As System.IO.DirectoryInfo() = dir.GetDirectories()
        CopyFile(dir, DPath)
        If dirs.Length > 0 Then
            For Each temDirectoryInfo As System.IO.DirectoryInfo In dirs
                Dim sourceDirectoryFullName As String = temDirectoryInfo.FullName
                Dim destDirectoryFullName As String = sourceDirectoryFullName.Replace(sPath, DPath)
                If Not System.IO.Directory.Exists(destDirectoryFullName) Then
                    System.IO.Directory.CreateDirectory(destDirectoryFullName)
                End If
                CopyFile(temDirectoryInfo, destDirectoryFullName)
                copyDirectory(sourceDirectoryFullName, destDirectoryFullName)
            Next
        End If
    End Sub

    Private Sub CopyFile(ByVal path As System.IO.DirectoryInfo, ByVal desPath As String)
        Dim sourcePath As String = path.FullName
        Dim files As System.IO.FileInfo() = path.GetFiles()
        For Each File As System.IO.FileInfo In files
            Dim sourceFileFullName As String = File.FullName
            Dim destFileFullName As String = sourceFileFullName.Replace(sourcePath, desPath)
            File.CopyTo(destFileFullName, True)
        Next
    End Sub

    Public Sub HH(ByVal Type As String)

        PB.Visible = True
        RBAppText("=========" & Type & "============")

        Dim ResourcesFilePath As String = New System.IO.FileInfo(System.Reflection.Assembly.GetExecutingAssembly().Location).Directory.FullName + "\\Chinese_Simplified\\xml\\" & Type & ".xml"
        If Not File.Exists(ResourcesFilePath) Then Return

        Dim LoXMl As XmlDocument
        Dim LoRoot As XmlNode = Nothing, LoItems As XmlNodeList = Nothing, LoProprtys As XmlNodeList = Nothing
        Dim CoCommon As Common = New Common
        Dim LoPName As String = "", zcValue As String = ""
        Dim TJ As String = "name"
        Dim FJ As String = ""

        If Type = "Value" Then TJ = "value"
        If Type = "Grid Column" Or Type = "PM_ProjectGridLayout" Then TJ = "keyed_name"

        LoXMl = New XmlDocument()
        LoXMl.Load(ResourcesFilePath)
        LoRoot = LoXMl.SelectSingleNode("export")
        LoItems = LoRoot.SelectNodes("Item")

        Dim setUp As Integer = 0
        PB.Maximum = LoItems.Count
        PB.Value = 0
        For Each itm As XmlNode In LoItems
            setUp += 1
            PB.Value = setUp
            Dim kName As String = CoCommon.GetXMLAttribute(itm, "keyed_name")
            Dim ConfigId As String = CoCommon.GetXMLAttribute(itm, "config_id")
            If String.IsNullOrEmpty(kName) Then Continue For

            If Type = "Property" Then
                Dim sid As String = CoCommon.GetXMLAttribute(itm, "source_id")
                If String.IsNullOrEmpty("sid") Then Continue For
                FJ = "<source_id>" & sid & "</source_id>"
            End If

            System.Windows.Forms.Application.DoEvents()
            Thread.Sleep(100)

            Dim strAML As String = "<AML><Item type='" & Type & "' action='get'><" & TJ & ">" & kName.Replace("&", "&amp;") & "</" & TJ & ">" & FJ & "</Item></AML>"
            Dim rootItem As Item = inn.applyAML(strAML)
            If rootItem.getItemCount() < 1 Then
                RBAppText("错误:" & Type & "未找到," & kName)
                Continue For
            End If

            System.Windows.Forms.Application.DoEvents()
            Thread.Sleep(100)

            If rootItem.getItemCount() > 1 Then
                For i As Integer = 0 To rootItem.getItemCount() - 1
                    If rootItem.getItemByIndex(i).getProperty("config_id") = ConfigId Then
                        rootItem = rootItem.getItemByIndex(i) : Exit For
                    End If
                Next
            End If
            If rootItem.getItemCount() > 1 Then
                RBAppText("错误:" & Type & "发现多条," & kName)
                Continue For
            End If

            System.Windows.Forms.Application.DoEvents()
            Thread.Sleep(100)
            '获取属性
            Dim isEdit As Boolean = False
            LoProprtys = itm.SelectNodes("property")
            If LoProprtys.Count > 0 Then
                For Each pItm In LoProprtys
                    LoPName = CoCommon.GetXMLAttribute(pItm, "__name")
                    If String.IsNullOrEmpty(LoPName) Then Continue For

                    zcValue = CoCommon.GetXMLAttribute(pItm, "zh")
                    If String.IsNullOrEmpty(zcValue) Then
                        RBAppText("警告:ZH值为空," & LoPName)
                        Continue For
                    End If

                    'label_plural xml:lang="zc"

                    isEdit = True
                    rootItem.setProperty(LoPName, zcValue, "zh")
                Next

                System.Windows.Forms.Application.DoEvents()
                Thread.Sleep(100)

                If isEdit Then
                    Dim resItem = rootItem.apply("edit")
                    If resItem.isError Then
                        RBAppText("错误:" & Type & "汉化时," & kName & " 原因，" & resItem.getErrorString())
                    End If
                Else
                    RBAppText("警告:没有需要汉化的内容," & LoPName)
                End If
            End If
        Next
        RBAppText(Type & "处理完成")
        PB.Visible = False
    End Sub

    Private Sub frmMain_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        RBAppText("警告：因本人很懒，没大量的时间优化汉化整个过程，汉化耗时在20分钟-30分钟之间，不要骂娘，耐心等待，有问题请联系我优化，谢谢！")
        RBAppText("Pending...")
        Dim NameList As List(Of String) = GetCurrentXML()
        For Each itm As String In NameList
            LV.Items.Add(itm)
        Next
    End Sub

    Public Shared Function GetCurrentXML() As List(Of String)
        Dim ResourcesFilePath As String = New System.IO.FileInfo(System.Reflection.Assembly.GetExecutingAssembly().Location).Directory.FullName + "\\Chinese_Simplified\\ImportConfig.xml"
        Dim LoXMl As XmlDocument
        Dim LoRoot As XmlNode = Nothing, LoItems As XmlNodeList = Nothing
        Dim CoCommon As Common = New Common
        Dim NameList As List(Of String) = New List(Of String)()

        LoXMl = New XmlDocument()
        LoXMl.Load(ResourcesFilePath)
        LoRoot = LoXMl.SelectSingleNode("import")
        LoItems = LoRoot.SelectNodes("itemtype")
        If LoItems Is Nothing Then Return NameList

        For Each itm As XmlNode In LoItems
            NameList.Add(CoCommon.GetXMLAttribute(itm, "name"))
        Next

        Return NameList
    End Function

    Private Sub pictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles pictureBox1.Click
        Process.Start("http://www.obotservice.com")
    End Sub

    Private Sub txtDir_Click(sender As System.Object, e As System.EventArgs) Handles txtDir.Click
        If FB.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtDir.Text = FB.SelectedPath
        End If
    End Sub

    Private Sub frmMain_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub
End Class