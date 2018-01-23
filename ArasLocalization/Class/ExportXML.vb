Imports System.Xml

Public Class ExportXML
    Private thetreeview As TreeView
    Private savefilepath As String
    Dim textWriter As XmlTextWriter
    Dim textdoc As XmlDocument

    Public Sub New()
        textdoc = New XmlDocument()
    End Sub

    Public Function TreeToXML(ByVal TheTreeView As TreeView, ByVal XMLFilePath As String) As Integer

        TheTreeView = TheTreeView
        savefilepath = XMLFilePath

        textWriter = New XmlTextWriter(XMLFilePath, Nothing)
        textWriter.Formatting = Formatting.Indented
        textWriter.WriteStartDocument()
        textWriter.WriteComment("This XML is created from a tree")
        textWriter.WriteComment("By Bordrin" & Date.Now.ToString("yyyy-MM-dd"))
        textWriter.WriteStartElement("sections")
        textWriter.WriteEndElement()
        textWriter.WriteEndDocument()
        textWriter.Close()

        textdoc.Load(savefilepath)

        Dim Xmlnode As XmlElement = textdoc.SelectSingleNode("sections")
        Xmlnode.SetAttribute("name", TheTreeView.Nodes(0).Text)

        If TheTreeView.Nodes.Count > 0 Then
            TransTreeSav(TheTreeView.Nodes, Xmlnode)
        Else
            textdoc.Save(savefilepath)
        End If
        Return 0
    End Function

    Private Function TransTreeSav(ByVal nodes As TreeNodeCollection, ByVal ParXmlnode As XmlElement) As Integer
        Try
            Dim xmlnode As XmlElement
            For Each node As TreeNode In nodes
                xmlnode = textdoc.CreateElement("section")
                xmlnode.SetAttribute("name", IIf(String.IsNullOrEmpty(node.Text), "Null", node.Text))
                ParXmlnode.AppendChild(xmlnode)

                If node.Nodes.Count > 0 Then
                    TransTreeSav(node.Nodes, xmlnode)
                End If
            Next
            textdoc.Save(savefilepath)
            Return 0
        Catch ex As Exception
            MsgBox(ex.Message)
            Return 1
        End Try      
    End Function
End Class
