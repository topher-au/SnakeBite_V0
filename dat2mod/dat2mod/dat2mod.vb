Imports System.Xml
Imports ICSharpCode.SharpZipLib
Imports System.IO
Module dat2mod

    Sub Main()
        Console.WriteLine("dat2mod 0.1")
        Console.WriteLine("-----------")

        If Not My.Computer.FileSystem.FileExists("gzstool.exe") Then
            Console.WriteLine("dat2mod requires gzstool.exe to be present")
            End
        End If

        Dim args = My.Application.CommandLineArgs
        If args.Count = 0 Then
            Console.WriteLine("Please specify dat file: dat2mod <01.dat>")
            End
        End If

        Dim datFile = args(0)
        If Not My.Computer.FileSystem.FileExists(datFile) Then
            Console.WriteLine(String.Format("{0} not found", datFile))
            End
        End If

        'Create copy of dat file
        Console.WriteLine("Creating working copy...")
        Dim sourceDat = String.Format("dat2mod_{0}", TimeOfDay.Ticks)
        My.Computer.FileSystem.CopyFile(datFile, sourceDat & ".dat")

        Console.WriteLine("Extracting mod data...")
        'GzsTool extract dat file
        Dim gzsProcess As New Process
        gzsProcess.StartInfo.FileName = "gzstool.exe"
        gzsProcess.StartInfo.Arguments = sourceDat & ".dat"
        gzsProcess.StartInfo.CreateNoWindow = True
        gzsProcess.Start()

        Do Until gzsProcess.HasExited

        Loop

        'Read xml data
        If Not My.Computer.FileSystem.FileExists(sourceDat & ".dat.xml") Then
            Console.WriteLine("Error extracting mod data: {0}.dat.xml not found")
            End
        End If

        Dim gzsXml As New XmlDocument
        gzsXml.Load(sourceDat & ".dat.xml")
        Dim arcNode = gzsXml.SelectSingleNode("//ArchiveFile")

        If arcNode Is Nothing Then
            Console.WriteLine("Unable to read archive data from xml")
            End
        End If


        Console.WriteLine("Doing the thing...")

        'create mod xml file

        Dim xmlSettings As New XmlWriterSettings
        xmlSettings.Indent = True
        xmlSettings.NewLineChars = vbLf

        Dim xmlWriter As XmlWriter = XmlWriter.Create(sourceDat & ".mod.xml", xmlSettings)
        xmlWriter.WriteStartDocument()
        xmlWriter.WriteStartElement("SnakeBite")

        xmlWriter.WriteStartElement("ModData")
        xmlWriter.WriteElementString("Name", "dat2mod converted mod")
        xmlWriter.WriteElementString("Author", "Topher Sheridan")
        xmlWriter.WriteElementString("Website", "https://www.github.com/topher-au/dat2mod")
        xmlWriter.WriteEndElement()

        xmlWriter.WriteStartElement("GzsXmlData")
        xmlWriter.WriteRaw(arcNode.OuterXml)
        xmlWriter.WriteEndElement()

        xmlWriter.WriteEndElement()
        xmlWriter.WriteEndDocument()

        xmlWriter.Close()
        xmlWriter.Dispose()

        'Move xml file and remove copied dat
        My.Computer.FileSystem.MoveFile(sourceDat & ".mod.xml", sourceDat & "\mod.xml")
        My.Computer.FileSystem.DeleteFile(sourceDat & ".dat")
        My.Computer.FileSystem.DeleteFile(sourceDat & ".dat.xml")

        Console.WriteLine("Creating output file...")
        Dim zipMod As New Zip.FastZip
        zipMod.CreateZip(sourceDat & ".mgsv", sourceDat, True, "(.*?)")

        My.Computer.FileSystem.DeleteDirectory(sourceDat, FileIO.DeleteDirectoryOption.DeleteAllContents)

        Console.WriteLine("Conversion finished: " & sourceDat & ".mgsv may now be loaded into SnakeBite")
    End Sub

End Module
