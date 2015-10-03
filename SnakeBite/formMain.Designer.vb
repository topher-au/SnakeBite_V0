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
        Me.panelWelcome = New System.Windows.Forms.Panel()
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
        Me.panelSelectDatfile.SuspendLayout()
        Me.panelSelectModfile.SuspendLayout()
        Me.panelModInfo.SuspendLayout()
        Me.panelInstall.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelWelcome
        '
        Me.panelWelcome.Controls.Add(Me.labelNoUninstall)
        Me.panelWelcome.Controls.Add(Me.labelWelcome)
        Me.panelWelcome.Location = New System.Drawing.Point(12, 12)
        Me.panelWelcome.Name = "panelWelcome"
        Me.panelWelcome.Size = New System.Drawing.Size(293, 161)
        Me.panelWelcome.TabIndex = 0
        '
        'labelNoUninstall
        '
        Me.labelNoUninstall.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelNoUninstall.ForeColor = System.Drawing.Color.Red
        Me.labelNoUninstall.Location = New System.Drawing.Point(17, 76)
        Me.labelNoUninstall.Name = "labelNoUninstall"
        Me.labelNoUninstall.Size = New System.Drawing.Size(258, 73)
        Me.labelNoUninstall.TabIndex = 1
        Me.labelNoUninstall.Text = "NOTE:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SnakeBite does not include an singular" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " uninstall feature. To uninstall A" &
    "LL of your mods, please click Uninstall and reverify the Steam data files for th" &
    "e game."
        '
        'labelWelcome
        '
        Me.labelWelcome.Location = New System.Drawing.Point(17, 17)
        Me.labelWelcome.Name = "labelWelcome"
        Me.labelWelcome.Size = New System.Drawing.Size(258, 47)
        Me.labelWelcome.TabIndex = 0
        Me.labelWelcome.Text = "Welcome to SnakeBite MGSV Patcher, please follow the instructions below to instal" &
    "l your mod for Metal Gear Solid V: The Phantom Pain."
        '
        'buttonContinue
        '
        Me.buttonContinue.Location = New System.Drawing.Point(230, 179)
        Me.buttonContinue.Name = "buttonContinue"
        Me.buttonContinue.Size = New System.Drawing.Size(75, 23)
        Me.buttonContinue.TabIndex = 1
        Me.buttonContinue.Text = "Continue"
        Me.buttonContinue.UseVisualStyleBackColor = True
        '
        'panelSelectDatfile
        '
        Me.panelSelectDatfile.Controls.Add(Me.buttonBrowseMgsV)
        Me.panelSelectDatfile.Controls.Add(Me.textMGSVDir)
        Me.panelSelectDatfile.Controls.Add(Me.labelSelectMgsV)
        Me.panelSelectDatfile.Location = New System.Drawing.Point(12, 12)
        Me.panelSelectDatfile.Name = "panelSelectDatfile"
        Me.panelSelectDatfile.Size = New System.Drawing.Size(293, 161)
        Me.panelSelectDatfile.TabIndex = 2
        '
        'buttonBrowseMgsV
        '
        Me.buttonBrowseMgsV.Location = New System.Drawing.Point(198, 79)
        Me.buttonBrowseMgsV.Name = "buttonBrowseMgsV"
        Me.buttonBrowseMgsV.Size = New System.Drawing.Size(75, 23)
        Me.buttonBrowseMgsV.TabIndex = 3
        Me.buttonBrowseMgsV.Text = "Browse..."
        Me.buttonBrowseMgsV.UseVisualStyleBackColor = True
        '
        'textMGSVDir
        '
        Me.textMGSVDir.Location = New System.Drawing.Point(18, 53)
        Me.textMGSVDir.Name = "textMGSVDir"
        Me.textMGSVDir.Size = New System.Drawing.Size(255, 20)
        Me.textMGSVDir.TabIndex = 2
        '
        'labelSelectMgsV
        '
        Me.labelSelectMgsV.Location = New System.Drawing.Point(15, 17)
        Me.labelSelectMgsV.Name = "labelSelectMgsV"
        Me.labelSelectMgsV.Size = New System.Drawing.Size(258, 33)
        Me.labelSelectMgsV.TabIndex = 1
        Me.labelSelectMgsV.Text = "Please select your Metal Gear Solid V installation directory"
        '
        'panelSelectModfile
        '
        Me.panelSelectModfile.Controls.Add(Me.buttonBrowseMod)
        Me.panelSelectModfile.Controls.Add(Me.textModFile)
        Me.panelSelectModfile.Controls.Add(Me.labelSelectModfile)
        Me.panelSelectModfile.Location = New System.Drawing.Point(12, 12)
        Me.panelSelectModfile.Name = "panelSelectModfile"
        Me.panelSelectModfile.Size = New System.Drawing.Size(293, 161)
        Me.panelSelectModfile.TabIndex = 3
        '
        'buttonBrowseMod
        '
        Me.buttonBrowseMod.Location = New System.Drawing.Point(198, 79)
        Me.buttonBrowseMod.Name = "buttonBrowseMod"
        Me.buttonBrowseMod.Size = New System.Drawing.Size(75, 23)
        Me.buttonBrowseMod.TabIndex = 3
        Me.buttonBrowseMod.Text = "Browse..."
        Me.buttonBrowseMod.UseVisualStyleBackColor = True
        '
        'textModFile
        '
        Me.textModFile.Location = New System.Drawing.Point(18, 53)
        Me.textModFile.Name = "textModFile"
        Me.textModFile.Size = New System.Drawing.Size(255, 20)
        Me.textModFile.TabIndex = 2
        '
        'labelSelectModfile
        '
        Me.labelSelectModfile.Location = New System.Drawing.Point(15, 17)
        Me.labelSelectModfile.Name = "labelSelectModfile"
        Me.labelSelectModfile.Size = New System.Drawing.Size(258, 33)
        Me.labelSelectModfile.TabIndex = 1
        Me.labelSelectModfile.Text = "Please select the mod file you would like to install"
        '
        'panelModInfo
        '
        Me.panelModInfo.Controls.Add(Me.linkModSite)
        Me.panelModInfo.Controls.Add(Me.labelModAuthor)
        Me.panelModInfo.Controls.Add(Me.labelModname)
        Me.panelModInfo.Location = New System.Drawing.Point(12, 12)
        Me.panelModInfo.Name = "panelModInfo"
        Me.panelModInfo.Size = New System.Drawing.Size(293, 161)
        Me.panelModInfo.TabIndex = 4
        '
        'linkModSite
        '
        Me.linkModSite.AutoSize = True
        Me.linkModSite.Location = New System.Drawing.Point(17, 66)
        Me.linkModSite.Name = "linkModSite"
        Me.linkModSite.Size = New System.Drawing.Size(144, 13)
        Me.linkModSite.TabIndex = 2
        Me.linkModSite.TabStop = True
        Me.linkModSite.Text = "http://www.modwebsite.net/"
        '
        'labelModAuthor
        '
        Me.labelModAuthor.AutoSize = True
        Me.labelModAuthor.Location = New System.Drawing.Point(17, 41)
        Me.labelModAuthor.Name = "labelModAuthor"
        Me.labelModAuthor.Size = New System.Drawing.Size(82, 13)
        Me.labelModAuthor.TabIndex = 1
        Me.labelModAuthor.Text = "ModAuthorHere"
        '
        'labelModname
        '
        Me.labelModname.AutoSize = True
        Me.labelModname.Location = New System.Drawing.Point(17, 17)
        Me.labelModname.Name = "labelModname"
        Me.labelModname.Size = New System.Drawing.Size(79, 13)
        Me.labelModname.TabIndex = 0
        Me.labelModname.Text = "ModNameHere"
        '
        'buttonUninstall
        '
        Me.buttonUninstall.Location = New System.Drawing.Point(12, 179)
        Me.buttonUninstall.Name = "buttonUninstall"
        Me.buttonUninstall.Size = New System.Drawing.Size(75, 23)
        Me.buttonUninstall.TabIndex = 5
        Me.buttonUninstall.Text = "Remove All"
        Me.buttonUninstall.UseVisualStyleBackColor = True
        '
        'panelInstall
        '
        Me.panelInstall.Controls.Add(Me.labelInstall)
        Me.panelInstall.Location = New System.Drawing.Point(12, 12)
        Me.panelInstall.Name = "panelInstall"
        Me.panelInstall.Size = New System.Drawing.Size(293, 161)
        Me.panelInstall.TabIndex = 6
        '
        'labelInstall
        '
        Me.labelInstall.AutoSize = True
        Me.labelInstall.Location = New System.Drawing.Point(17, 17)
        Me.labelInstall.Name = "labelInstall"
        Me.labelInstall.Size = New System.Drawing.Size(48, 13)
        Me.labelInstall.TabIndex = 0
        Me.labelInstall.Text = "Installing"
        '
        'formMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(318, 213)
        Me.Controls.Add(Me.panelInstall)
        Me.Controls.Add(Me.panelModInfo)
        Me.Controls.Add(Me.panelSelectModfile)
        Me.Controls.Add(Me.panelSelectDatfile)
        Me.Controls.Add(Me.panelWelcome)
        Me.Controls.Add(Me.buttonUninstall)
        Me.Controls.Add(Me.buttonContinue)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formMain"
        Me.Text = "SnakeBite"
        Me.panelWelcome.ResumeLayout(False)
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
End Class
