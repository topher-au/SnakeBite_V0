<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formMain))
        Me.panelWelcome = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.labelNoUninstall = New System.Windows.Forms.Label()
        Me.labelWelcome = New System.Windows.Forms.Label()
        Me.buttonContinue = New System.Windows.Forms.Button()
        Me.panelSelectDatfile = New System.Windows.Forms.Panel()
        Me.buttonBrowseMgsV = New System.Windows.Forms.Button()
        Me.textMGSVDir = New System.Windows.Forms.TextBox()
        Me.labelSelectMgsV = New System.Windows.Forms.Label()
        Me.panelSelectModfile = New System.Windows.Forms.Panel()
        Me.buttonBrowseMod = New System.Windows.Forms.Button()
        Me.textModFile = New System.Windows.Forms.TextBox()
        Me.labelSelectModfile = New System.Windows.Forms.Label()
        Me.panelModInfo = New System.Windows.Forms.Panel()
        Me.linkModSite = New System.Windows.Forms.LinkLabel()
        Me.labelModAuthor = New System.Windows.Forms.Label()
        Me.labelModname = New System.Windows.Forms.Label()
        Me.buttonUninstall = New System.Windows.Forms.Button()
        Me.panelInstall = New System.Windows.Forms.Panel()
        Me.labelInstall = New System.Windows.Forms.Label()
        Me.panelWelcome.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelSelectDatfile.SuspendLayout()
        Me.panelSelectModfile.SuspendLayout()
        Me.panelModInfo.SuspendLayout()
        Me.panelInstall.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelWelcome
        '
        Me.panelWelcome.Controls.Add(Me.PictureBox1)
        Me.panelWelcome.Controls.Add(Me.labelNoUninstall)
        Me.panelWelcome.Controls.Add(Me.labelWelcome)
        Me.panelWelcome.Location = New System.Drawing.Point(14, 16)
        Me.panelWelcome.Name = "panelWelcome"
        Me.panelWelcome.Size = New System.Drawing.Size(342, 211)
        Me.panelWelcome.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SnakeBite.My.Resources.Resources.snake2
        Me.PictureBox1.Location = New System.Drawing.Point(15, 23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'labelNoUninstall
        '
        Me.labelNoUninstall.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelNoUninstall.ForeColor = System.Drawing.Color.Red
        Me.labelNoUninstall.Location = New System.Drawing.Point(17, 150)
        Me.labelNoUninstall.Name = "labelNoUninstall"
        Me.labelNoUninstall.Size = New System.Drawing.Size(301, 48)
        Me.labelNoUninstall.TabIndex = 1
        Me.labelNoUninstall.Text = "To uninstall ALL of your mods, please click Remove All on the next page."
        '
        'labelWelcome
        '
        Me.labelWelcome.Location = New System.Drawing.Point(94, 11)
        Me.labelWelcome.Name = "labelWelcome"
        Me.labelWelcome.Size = New System.Drawing.Size(226, 92)
        Me.labelWelcome.TabIndex = 0
        Me.labelWelcome.Text = "Welcome to SnakeBite" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Please click continue and follow the instructions to inst" &
    "all your mod for Metal Gear Solid V: The Phantom Pain"
        '
        'buttonContinue
        '
        Me.buttonContinue.Location = New System.Drawing.Point(268, 235)
        Me.buttonContinue.Name = "buttonContinue"
        Me.buttonContinue.Size = New System.Drawing.Size(87, 31)
        Me.buttonContinue.TabIndex = 1
        Me.buttonContinue.Text = "Continue"
        Me.buttonContinue.UseVisualStyleBackColor = True
        '
        'panelSelectDatfile
        '
        Me.panelSelectDatfile.Controls.Add(Me.buttonBrowseMgsV)
        Me.panelSelectDatfile.Controls.Add(Me.textMGSVDir)
        Me.panelSelectDatfile.Controls.Add(Me.labelSelectMgsV)
        Me.panelSelectDatfile.Location = New System.Drawing.Point(14, 16)
        Me.panelSelectDatfile.Name = "panelSelectDatfile"
        Me.panelSelectDatfile.Size = New System.Drawing.Size(342, 211)
        Me.panelSelectDatfile.TabIndex = 2
        '
        'buttonBrowseMgsV
        '
        Me.buttonBrowseMgsV.Location = New System.Drawing.Point(231, 103)
        Me.buttonBrowseMgsV.Name = "buttonBrowseMgsV"
        Me.buttonBrowseMgsV.Size = New System.Drawing.Size(87, 31)
        Me.buttonBrowseMgsV.TabIndex = 3
        Me.buttonBrowseMgsV.Text = "Browse..."
        Me.buttonBrowseMgsV.UseVisualStyleBackColor = True
        '
        'textMGSVDir
        '
        Me.textMGSVDir.Location = New System.Drawing.Point(21, 69)
        Me.textMGSVDir.Name = "textMGSVDir"
        Me.textMGSVDir.Size = New System.Drawing.Size(297, 25)
        Me.textMGSVDir.TabIndex = 2
        '
        'labelSelectMgsV
        '
        Me.labelSelectMgsV.Location = New System.Drawing.Point(17, 23)
        Me.labelSelectMgsV.Name = "labelSelectMgsV"
        Me.labelSelectMgsV.Size = New System.Drawing.Size(301, 43)
        Me.labelSelectMgsV.TabIndex = 1
        Me.labelSelectMgsV.Text = "Please select your Metal Gear Solid V installation directory"
        '
        'panelSelectModfile
        '
        Me.panelSelectModfile.Controls.Add(Me.buttonBrowseMod)
        Me.panelSelectModfile.Controls.Add(Me.textModFile)
        Me.panelSelectModfile.Controls.Add(Me.labelSelectModfile)
        Me.panelSelectModfile.Location = New System.Drawing.Point(14, 16)
        Me.panelSelectModfile.Name = "panelSelectModfile"
        Me.panelSelectModfile.Size = New System.Drawing.Size(342, 211)
        Me.panelSelectModfile.TabIndex = 3
        '
        'buttonBrowseMod
        '
        Me.buttonBrowseMod.Location = New System.Drawing.Point(231, 103)
        Me.buttonBrowseMod.Name = "buttonBrowseMod"
        Me.buttonBrowseMod.Size = New System.Drawing.Size(87, 31)
        Me.buttonBrowseMod.TabIndex = 3
        Me.buttonBrowseMod.Text = "Browse..."
        Me.buttonBrowseMod.UseVisualStyleBackColor = True
        '
        'textModFile
        '
        Me.textModFile.Location = New System.Drawing.Point(21, 69)
        Me.textModFile.Name = "textModFile"
        Me.textModFile.Size = New System.Drawing.Size(297, 25)
        Me.textModFile.TabIndex = 2
        '
        'labelSelectModfile
        '
        Me.labelSelectModfile.Location = New System.Drawing.Point(17, 23)
        Me.labelSelectModfile.Name = "labelSelectModfile"
        Me.labelSelectModfile.Size = New System.Drawing.Size(301, 43)
        Me.labelSelectModfile.TabIndex = 1
        Me.labelSelectModfile.Text = "Please select the mod file you would like to install"
        '
        'panelModInfo
        '
        Me.panelModInfo.Controls.Add(Me.linkModSite)
        Me.panelModInfo.Controls.Add(Me.labelModAuthor)
        Me.panelModInfo.Controls.Add(Me.labelModname)
        Me.panelModInfo.Location = New System.Drawing.Point(14, 16)
        Me.panelModInfo.Name = "panelModInfo"
        Me.panelModInfo.Size = New System.Drawing.Size(342, 211)
        Me.panelModInfo.TabIndex = 4
        '
        'linkModSite
        '
        Me.linkModSite.AutoSize = True
        Me.linkModSite.Location = New System.Drawing.Point(12, 66)
        Me.linkModSite.Name = "linkModSite"
        Me.linkModSite.Size = New System.Drawing.Size(171, 17)
        Me.linkModSite.TabIndex = 2
        Me.linkModSite.TabStop = True
        Me.linkModSite.Text = "http://www.modwebsite.net/"
        '
        'labelModAuthor
        '
        Me.labelModAuthor.AutoSize = True
        Me.labelModAuthor.Location = New System.Drawing.Point(20, 36)
        Me.labelModAuthor.Name = "labelModAuthor"
        Me.labelModAuthor.Size = New System.Drawing.Size(103, 17)
        Me.labelModAuthor.TabIndex = 1
        Me.labelModAuthor.Text = "ModAuthorHere"
        '
        'labelModname
        '
        Me.labelModname.AutoSize = True
        Me.labelModname.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelModname.Location = New System.Drawing.Point(10, 11)
        Me.labelModname.Name = "labelModname"
        Me.labelModname.Size = New System.Drawing.Size(149, 25)
        Me.labelModname.TabIndex = 0
        Me.labelModname.Text = "ModNameHere"
        '
        'buttonUninstall
        '
        Me.buttonUninstall.Location = New System.Drawing.Point(14, 235)
        Me.buttonUninstall.Name = "buttonUninstall"
        Me.buttonUninstall.Size = New System.Drawing.Size(87, 31)
        Me.buttonUninstall.TabIndex = 5
        Me.buttonUninstall.Text = "Remove All"
        Me.buttonUninstall.UseVisualStyleBackColor = True
        '
        'panelInstall
        '
        Me.panelInstall.Controls.Add(Me.labelInstall)
        Me.panelInstall.Location = New System.Drawing.Point(14, 16)
        Me.panelInstall.Name = "panelInstall"
        Me.panelInstall.Size = New System.Drawing.Size(342, 211)
        Me.panelInstall.TabIndex = 6
        '
        'labelInstall
        '
        Me.labelInstall.AutoSize = True
        Me.labelInstall.Location = New System.Drawing.Point(20, 23)
        Me.labelInstall.Name = "labelInstall"
        Me.labelInstall.Size = New System.Drawing.Size(59, 17)
        Me.labelInstall.TabIndex = 0
        Me.labelInstall.Text = "Installing"
        '
        'formMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(371, 279)
        Me.Controls.Add(Me.buttonUninstall)
        Me.Controls.Add(Me.buttonContinue)
        Me.Controls.Add(Me.panelModInfo)
        Me.Controls.Add(Me.panelSelectModfile)
        Me.Controls.Add(Me.panelSelectDatfile)
        Me.Controls.Add(Me.panelWelcome)
        Me.Controls.Add(Me.panelInstall)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SnakeBite"
        Me.panelWelcome.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelSelectDatfile.ResumeLayout(False)
        Me.panelSelectDatfile.PerformLayout()
        Me.panelSelectModfile.ResumeLayout(False)
        Me.panelSelectModfile.PerformLayout()
        Me.panelModInfo.ResumeLayout(False)
        Me.panelModInfo.PerformLayout()
        Me.panelInstall.ResumeLayout(False)
        Me.panelInstall.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelWelcome As Panel
    Friend WithEvents labelNoUninstall As Label
    Friend WithEvents labelWelcome As Label
    Friend WithEvents buttonContinue As Button
    Friend WithEvents panelSelectDatfile As Panel
    Friend WithEvents buttonBrowseMgsV As Button
    Friend WithEvents textMGSVDir As TextBox
    Friend WithEvents labelSelectMgsV As Label
    Friend WithEvents panelSelectModfile As Panel
    Friend WithEvents buttonBrowseMod As Button
    Friend WithEvents textModFile As TextBox
    Friend WithEvents labelSelectModfile As Label
    Friend WithEvents panelModInfo As Panel
    Friend WithEvents labelModname As Label
    Friend WithEvents buttonUninstall As Button
    Friend WithEvents linkModSite As LinkLabel
    Friend WithEvents labelModAuthor As Label
    Friend WithEvents panelInstall As Panel
    Friend WithEvents labelInstall As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
