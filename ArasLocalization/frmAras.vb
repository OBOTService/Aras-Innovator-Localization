Imports Aras.IOM
Imports DevComponents.DotNetBar.Controls

Public Class frmAras
    Public Shared inn As Innovator = Nothing
    Dim connection As HttpServerConnection = Nothing
    Public Lang As String = "en"
    Dim m_OpaqueLayer As Helper.OpaqueLayerHelper = Nothing


    Public Sub ShowOpaqueLayer(ByVal control As Control, ByVal alpha As Integer, ByVal showLoadingImage As Boolean)
        If Me.m_OpaqueLayer Is Nothing Then
            Me.m_OpaqueLayer = New Helper.OpaqueLayerHelper(alpha, showLoadingImage)
            control.Controls.Add(Me.m_OpaqueLayer)
            Me.m_OpaqueLayer.Dock = DockStyle.Fill
            Me.m_OpaqueLayer.BringToFront()

            Me.m_OpaqueLayer.Enabled = True
            Me.m_OpaqueLayer.Visible = True
        End If
    End Sub

    Protected Sub HideOpaqueLayer()
        If Not Me.m_OpaqueLayer Is Nothing Then
            Me.m_OpaqueLayer.Enabled = False
            Me.m_OpaqueLayer.Visible = False
        End If
    End Sub

    Private Sub btnGetDB_Click(sender As System.Object, e As System.EventArgs) Handles btnGetDB.Click
        Me.ShowOpaqueLayer(Me.GB, 125, True)
        Dim strServerURL As String = txtServerURL.Text
        If String.IsNullOrEmpty(strServerURL) Then bt.SetBalloonText(txtServerURL, "不能为空") : bt.ShowBalloon(txtServerURL) : bt.RemoveAll() : Return

        cmbDB.Items.Clear()
        Dim dbs As String() = GetDataBase(strServerURL)
        If dbs Is Nothing Then Return
        For Each item As String In dbs
            cmbDB.Items.Add(item)
        Next
        If cmbDB.Items.Count > 0 Then cmbDB.SelectedIndex = 0

        Me.HideOpaqueLayer()
    End Sub

    Private Sub btnLogin_Click(sender As System.Object, e As System.EventArgs) Handles btnLogin.Click
        Login()
    End Sub

    Public Function GetDataBase(ByVal pServerURL As String) As String()
        Try
            Return IomFactory.CreateHttpServerConnection(pServerURL).GetDatabases()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        Finally
            Me.HideOpaqueLayer()
        End Try
    End Function


    Private Sub Login()
        Dim strServerURL As String = txtServerURL.Text
        If String.IsNullOrEmpty(strServerURL) Then bt.SetBalloonText(txtServerURL, "不能为空") : bt.ShowBalloon(txtServerURL) : bt.RemoveAll() : Return

        Dim strDB As String = cmbDB.Text
        If String.IsNullOrEmpty(strDB) Then bt.SetBalloonText(cmbDB, "不能为空") : bt.ShowBalloon(cmbDB) : bt.RemoveAll() : Return

        Dim strUserName As String = txtUserName.Text
        If String.IsNullOrEmpty(strUserName) Then bt.SetBalloonText(txtUserName, "不能为空") : bt.ShowBalloon(txtUserName) : bt.RemoveAll() : Return

        Dim strPassword As String = txtPassword.Text
        If String.IsNullOrEmpty(strServerURL) Then bt.SetBalloonText(txtPassword, "不能为空") : bt.ShowBalloon(txtPassword) : bt.RemoveAll() : Return

        connection = IomFactory.CreateHttpServerConnection(strServerURL, strDB, strUserName, strPassword)
        Dim item As Item = connection.Login
        If item.isError Then
            If (Not connection Is Nothing) Then
                connection.Logout()
            End If
            Dim str As String = item.getErrorString
            Dim startIndex As Integer = (str.IndexOf(":") + 1)
            If (startIndex > 0) Then
                str = str.Substring(startIndex)
            End If
            If str.Contains("Authentication") Then
                str = "Invalid user or password"
            End If
            If str.Contains("Database") Then
                str = "Database not available"
            End If
            MessageBox.Show(("Login failed!" & ChrW(13) & ChrW(10) & ChrW(13) & ChrW(10) & str), "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            inn = IomFactory.CreateInnovator(connection)
            frmMain.inn = inn
            Me.Hide()
            frmMain.Show()
        End If
    End Sub

    Private Sub GroupPanel1_Click(sender As System.Object, e As System.EventArgs) Handles GroupPanel1.Click
        Process.Start("http://www.obotservice.com")
    End Sub

    Private Sub pictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles pictureBox1.Click
        Process.Start("http://www.obotservice.com")
    End Sub
End Class