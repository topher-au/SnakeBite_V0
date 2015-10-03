Imports ICSharpCode.SharpZipLib
Imports System.Xml
Imports <xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">
Imports System.Threading.Thread
Public Class formMain
    Private Sub formMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        textMGSVDir.Text = My.Settings.MgsV
        panelWelcome.Visible = True
        panelSelectDatfile.Visible = False
        panelSelectModfile.Visible = False
        panelModInfo.Visible = False
        panelInstall.Visible = False
        buttonUninstall.Visible = False
    End Sub

    Private Sub buttonBrowseMgsV_Click(sender As Object, e As EventArgs) Handles buttonBrowseMgsV.Click
        ' Browse for MGSV folder
        Dim mgsvDirDialog As New FolderBrowserDialog
        mgsvDirDialog.SelectedPath = textMGSVDir.Text
        Dim dirResult = mgsvDirDialog.ShowDialog
        If dirResult = DialogResult.OK Then
            Dim mgsvDir = mgsvDirDialog.SelectedPath
            ' Check for existence of MGSVTPP.EXE
            If My.Computer.FileSystem.FileExists(mgsvDir & "\mgsvtpp.exe") Then
                'update text box and settings
                textMGSVDir.Text = mgsvDir
                My.Settings.MgsV = mgsvDir
            Else
                MsgBox("Unable to find MGSV, please check the folder and try again.", vbOKOnly + vbCritical, "SnakeBite")
            End If
        End If
    End Sub

    Private Sub buttonBrowseMod_Click(sender As Object, e As EventArgs) Handles buttonBrowseMod.Click
        ' Browse for mod file
        Dim openModDialog As New OpenFileDialog
        openModDialog.Filter = "MGSV Mod Files|*.mgsv|All Files|*.*"
        Dim openResult = openModDialog.ShowDialog
        If openResult = DialogResult.OK Then
            textModFile.Text = openModDialog.FileName
        End If
    End Sub

    Private Function ExtractModfile(Filename As String)
        ' Extract the mod to a temp directory

        ' Delete existing temp data
        If My.Computer.FileSystem.FileExists("temp") Then My.Computer.FileSystem.DeleteFile("temp")
        If My.Computer.FileSystem.DirectoryExists("_extr") Then My.Computer.FileSystem.DeleteDirectory("_extr", FileIO.DeleteDirectoryOption.DeleteAllContents)

        ' Check mod file exists
        If Not My.Computer.FileSystem.FileExists(Filename) Then
            ' File doesn't exist, return false
            Return False
        End If

        ' Copy file and extract
        My.Computer.FileSystem.CopyFile(Filename, "temp")
        Dim unzipper As New Zip.FastZip
        Try
            unzipper.ExtractZip("temp", "_extr", "(.*?)")
        Catch
            Return False
        End Try
        Return True
    End Function

    Private Sub buttonContinue_Click(sender As Object, e As EventArgs) Handles buttonContinue.Click
        If panelInstall.Visible Then
            End
        End If
        If panelModInfo.Visible Then
            panelInstall.Visible = True
            panelModInfo.Visible = False
            buttonContinue.Visible = False
            InstallModFile()

        End If
        If panelSelectModfile.Visible Then
            Dim modFile = textModFile.Text
            If Not ExtractModfile(modFile) Then
                MsgBox("Invalid or corrupt mod file")
                Exit Sub
            End If
            Dim modXml As New XmlDocument
            Try
                modXml.Load("_extr\mod.xml")
            Catch
                MsgBox("Unable to load mod metadata")
                My.Computer.FileSystem.DeleteDirectory(modFile & "_extr", FileIO.DeleteDirectoryOption.DeleteAllContents)
                Exit Sub
            End Try
            Dim modMeta = modXml.SelectSingleNode("//SnakeBite/ModData")
            Dim modGzsData = modXml.SelectSingleNode("//GzsXmlData")

            labelModname.Text = modMeta.Item("Name").InnerText
            labelModAuthor.Text = modMeta.Item("Author").InnerText
            linkModSite.Text = modMeta.Item("Website").InnerText

            panelModInfo.Visible = True
            panelSelectModfile.Visible = False
            buttonUninstall.Visible = False
        End If
        If panelSelectDatfile.Visible Then
            If Not My.Computer.FileSystem.FileExists(textMGSVDir.Text & "\MGSVTPP.EXE") Then
                MsgBox("Unable to find MGSV. Check the folder or rebuild Steam data for the game.", vbOKOnly + vbCritical, "SnakeBite")
                Exit Sub
            End If
            panelSelectModfile.Visible = True
            panelSelectDatfile.Visible = False
        End If
        If panelWelcome.Visible Then
            panelSelectDatfile.Visible = True
            panelWelcome.Visible = False
            buttonUninstall.Visible = True
        End If
    End Sub
    Private Function InstallModFile()
        Dim overFiles As Integer = 0 ' files that are likely to be overwritten
        Dim datHashList As New List(Of String)
        Dim datEntries As XmlNode = Nothing

        Dim xmlSettings As New XmlWriterSettings
        xmlSettings.Indent = True

        Dim dat01File = My.Settings.MgsV & "\master\0\01.dat"
        Dim dat01Dir = My.Settings.MgsV & "\master\0\01\"

        If My.Computer.FileSystem.DirectoryExists(dat01Dir) Then
            My.Computer.FileSystem.DeleteDirectory(dat01Dir, FileIO.DeleteDirectoryOption.DeleteAllContents)
        End If

        'Extract existing 01.dat
        Dim gzsProcess As New Process
        gzsProcess.StartInfo.FileName = "gzstool.exe"
        gzsProcess.StartInfo.UseShellExecute = False
        gzsProcess.StartInfo.CreateNoWindow = True

        ' Load xml data
        Dim modXml As New XmlDocument
        modXml.Load(textModFile.Text & "_extr\mod.xml")
        Dim modEntries = modXml.SelectSingleNode("//SnakeBite/GzsXmlData/ArchiveFile/Entries")

        ' Load mod hashes
        Dim modHashList As New List(Of String)
        For Each moe As XmlNode In modEntries.ChildNodes
            modHashList.Add(moe.Attributes("Hash").Value)
        Next

        If My.Computer.FileSystem.FileExists(dat01File) Then
            ' Extract 01.dat
            gzsProcess.StartInfo.Arguments = dat01File
            gzsProcess.Start()

            labelInstall.Text = "Unpacking game data..."
            Do Until gzsProcess.HasExited
                Application.DoEvents()
            Loop

            ' Open 01.dat.xml
            Dim datXml As New XmlDocument
            datXml.Load(dat01File & ".xml")
            datEntries = datXml.SelectSingleNode("//ArchiveFile/Entries")

            ' Load dat hashes
            For Each moe As XmlNode In datEntries.ChildNodes
                datHashList.Add(moe.Attributes("Hash").Value)
            Next

            'Compare extracted hashes to mod hashes
            For Each mhe In modHashList
                If datHashList.Contains(mhe) Then
                    overFiles += 1
                End If
            Next

            My.Computer.FileSystem.DeleteFile(dat01File & ".xml")
        End If

        'If any files matched , warn user they may be incompatible
        If overFiles > 0 Then
            Dim overFile = MsgBox("Some files in the mod you have selected may overwrite files for an existing mod. Click OK to install anyway, or cancel to exit SnakeBite.", vbOKCancel + vbExclamation, "SnakeBite")
            If overFile = MsgBoxResult.Cancel Then
                End
            End If
        End If

        ' Check for fpk files inside mod archive
        Dim fpksToMerge As New List(Of String)
        For Each modEntry As XmlNode In modEntries.ChildNodes
            Dim filePath As String = modEntry.Attributes("FilePath").Value
            Dim fileType = filePath.Substring(filePath.LastIndexOf(".") + 1).ToLower
            Dim fileHash = modEntry.Attributes("Hash").Value
            If fileType = "fpk" Or fileType = "fpkd" Then
                ' If the FPK already existed, it will be merged
                If datHashList.Contains(fileHash) Then
                    fpksToMerge.Add(filePath)
                End If
            End If
        Next

        'Extract fpk files
        labelInstall.Text = "Unpacking mod data..."
        For Each fpkfile In fpksToMerge
            gzsProcess.StartInfo.Arguments = dat01Dir & fpkfile
            gzsProcess.Start()
            gzsProcess.StartInfo.Arguments = "_extr\" & fpkfile
            gzsProcess.Start()
            Do Until gzsProcess.HasExited
                Application.DoEvents()
            Loop
        Next

        'copy files
        labelInstall.Text = "Applying mod changes..."
        My.Computer.FileSystem.CopyDirectory("_extr", dat01Dir, True)

        'rebuild fpk xml
        labelInstall.Text = "Rebuilding mod data..."
        For Each fpkfile In fpksToMerge
            Dim fpkdir As String = dat01Dir & fpkfile.Replace(".", "_")
            Dim filetype = fpkfile.Substring(fpkfile.LastIndexOf(".") + 1).ToLower
            Dim fpkfilename = fpkfile.Substring(fpkfile.LastIndexOf("\") + 1).ToLower
            Dim fpkxmlw As XmlWriter = XmlWriter.Create(dat01Dir & fpkfile & ".xml")

            fpkxmlw.WriteStartDocument()
            fpkxmlw.WriteStartElement("ArchiveFile")

            fpkxmlw.WriteAttributeString("Name", fpkfilename)
            fpkxmlw.WriteAttributeString("FpkType", filetype)

            fpkxmlw.WriteStartElement("Entries")

            Dim dirfiles = My.Computer.FileSystem.GetDirectoryInfo(fpkdir).GetFiles("*.*", IO.SearchOption.AllDirectories)
            For Each f In dirfiles
                fpkxmlw.WriteStartElement("Entry")
                Dim fpath = f.FullName
                Dim endpath = fpath.Substring(fpath.LastIndexOf("\Assets"))
                endpath = endpath.Replace("\", "/")
                fpkxmlw.WriteAttributeString("FilePath", endpath)
                fpkxmlw.WriteEndElement()
            Next

            fpkxmlw.WriteEndElement()
            fpkxmlw.WriteEndElement()

            fpkxmlw.WriteEndDocument()

            fpkxmlw.Close()
            fpkxmlw.Dispose()

            gzsProcess.StartInfo.Arguments = fpkfile & ".xml"
            gzsProcess.Start()
            Do Until gzsProcess.HasExited
                Application.DoEvents()
            Loop
        Next

        'rebuild 01.dat xml
        labelInstall.Text = "Rebuilding game archive..."
        Dim datXmlWriter As XmlWriter = XmlWriter.Create(dat01File & ".xml", xmlSettings)
        datXmlWriter.WriteStartDocument()
        datXmlWriter.WriteStartElement("ArchiveFile")
        datXmlWriter.WriteAttributeString("xsi", "type", "http://www.w3.org/2001/XMLSchema-instance", "QarFile")
        datXmlWriter.WriteAttributeString("Name", "01.dat")
        datXmlWriter.WriteAttributeString("Flags", "3150048")

        datXmlWriter.WriteStartElement("Entries")
        If datEntries IsNot Nothing Then
            For Each datEntry As XmlNode In datEntries.ChildNodes
                datXmlWriter.WriteRaw(datEntry.OuterXml)
            Next
        End If

        For Each modEntry As XmlNode In modEntries.ChildNodes
            If Not datHashList.Contains(modEntry.Attributes("Hash").Value) Then
                datXmlWriter.WriteRaw(modEntry.OuterXml & vbNewLine)
            End If
        Next
        datXmlWriter.WriteEndElement()
        datXmlWriter.WriteEndElement()
        datXmlWriter.WriteEndDocument()
        datXmlWriter.Close()
        datXmlWriter.Dispose()

        'repack 01.dat
        gzsProcess.StartInfo.Arguments = dat01File & ".xml"
        gzsProcess.Start()

        Do Until gzsProcess.HasExited
            Application.DoEvents()
        Loop

        ' remove leftover files
        Try
            My.Computer.FileSystem.DeleteFile(dat01File & ".xml")
            My.Computer.FileSystem.DeleteDirectory(dat01Dir, FileIO.DeleteDirectoryOption.DeleteAllContents)
            My.Computer.FileSystem.DeleteDirectory("_extr", FileIO.DeleteDirectoryOption.DeleteAllContents)
        Catch ex As Exception

        End Try

        labelInstall.Text = "Installation complete"
        buttonContinue.Text = "Close"
        buttonContinue.Visible = True
    End Function

    Private Sub buttonUninstall_Click(sender As Object, e As EventArgs) Handles buttonUninstall.Click
        Dim youSure = MsgBox("This will remove all SnakeBite mods, are you sure?", vbYesNo + vbQuestion, "SnakeBite")
        If youSure = MsgBoxResult.Yes Then

        End If
    End Sub
End Class
