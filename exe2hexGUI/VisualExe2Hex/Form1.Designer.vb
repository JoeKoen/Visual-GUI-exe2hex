<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.BtnPython = New System.Windows.Forms.Button()
        Me.VarB = New System.Windows.Forms.CheckBox()
        Me.batout = New System.Windows.Forms.TextBox()
        Me.poshout = New System.Windows.Forms.TextBox()
        Me.VarP = New System.Windows.Forms.CheckBox()
        Me.VarE = New System.Windows.Forms.CheckBox()
        Me.prefix = New System.Windows.Forms.TextBox()
        Me.VarR = New System.Windows.Forms.CheckBox()
        Me.suffix = New System.Windows.Forms.TextBox()
        Me.VarF = New System.Windows.Forms.CheckBox()
        Me.VarL = New System.Windows.Forms.CheckBox()
        Me.VarLnumber = New System.Windows.Forms.NumericUpDown()
        Me.VarC = New System.Windows.Forms.CheckBox()
        Me.VarCC = New System.Windows.Forms.CheckBox()
        Me.VarT = New System.Windows.Forms.CheckBox()
        Me.VarW = New System.Windows.Forms.CheckBox()
        Me.BtnExe2Hex = New System.Windows.Forms.Button()
        Me.PythonPath = New System.Windows.Forms.TextBox()
        Me.exe2hexPath = New System.Windows.Forms.TextBox()
        Me.ExePathBtn = New System.Windows.Forms.Button()
        Me.ExePath = New System.Windows.Forms.TextBox()
        Me.BuildFile = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SetPyPathofd = New System.Windows.Forms.OpenFileDialog()
        Me.exe2hexpathofd = New System.Windows.Forms.OpenFileDialog()
        Me.exepathofd = New System.Windows.Forms.OpenFileDialog()
        CType(Me.VarLnumber, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnPython
        '
        Me.BtnPython.Location = New System.Drawing.Point(12, 12)
        Me.BtnPython.Name = "BtnPython"
        Me.BtnPython.Size = New System.Drawing.Size(109, 20)
        Me.BtnPython.TabIndex = 1
        Me.BtnPython.Text = "Set Python Path"
        Me.BtnPython.UseVisualStyleBackColor = True
        '
        'VarB
        '
        Me.VarB.AutoSize = True
        Me.VarB.Location = New System.Drawing.Point(12, 126)
        Me.VarB.Name = "VarB"
        Me.VarB.Size = New System.Drawing.Size(96, 17)
        Me.VarB.TabIndex = 4
        Me.VarB.Text = "BAT output file"
        Me.VarB.UseVisualStyleBackColor = True
        '
        'batout
        '
        Me.batout.Location = New System.Drawing.Point(165, 124)
        Me.batout.Name = "batout"
        Me.batout.Size = New System.Drawing.Size(132, 20)
        Me.batout.TabIndex = 3
        Me.batout.Text = "output.bat"
        '
        'poshout
        '
        Me.poshout.Location = New System.Drawing.Point(165, 150)
        Me.poshout.Name = "poshout"
        Me.poshout.Size = New System.Drawing.Size(132, 20)
        Me.poshout.TabIndex = 3
        Me.poshout.Text = "output.cmd"
        '
        'VarP
        '
        Me.VarP.AutoSize = True
        Me.VarP.Location = New System.Drawing.Point(12, 152)
        Me.VarP.Name = "VarP"
        Me.VarP.Size = New System.Drawing.Size(101, 17)
        Me.VarP.TabIndex = 4
        Me.VarP.Text = "PoSh output file"
        Me.VarP.UseVisualStyleBackColor = True
        '
        'VarE
        '
        Me.VarE.AutoSize = True
        Me.VarE.Location = New System.Drawing.Point(12, 178)
        Me.VarE.Name = "VarE"
        Me.VarE.Size = New System.Drawing.Size(138, 17)
        Me.VarE.TabIndex = 4
        Me.VarE.Text = "URL encode the output"
        Me.VarE.UseVisualStyleBackColor = True
        '
        'prefix
        '
        Me.prefix.Location = New System.Drawing.Point(165, 202)
        Me.prefix.Name = "prefix"
        Me.prefix.Size = New System.Drawing.Size(132, 20)
        Me.prefix.TabIndex = 3
        '
        'VarR
        '
        Me.VarR.AutoSize = True
        Me.VarR.Location = New System.Drawing.Point(12, 204)
        Me.VarR.Name = "VarR"
        Me.VarR.Size = New System.Drawing.Size(52, 17)
        Me.VarR.TabIndex = 4
        Me.VarR.Text = "Prefix"
        Me.VarR.UseVisualStyleBackColor = True
        '
        'suffix
        '
        Me.suffix.Location = New System.Drawing.Point(165, 228)
        Me.suffix.Name = "suffix"
        Me.suffix.Size = New System.Drawing.Size(132, 20)
        Me.suffix.TabIndex = 3
        '
        'VarF
        '
        Me.VarF.AutoSize = True
        Me.VarF.Location = New System.Drawing.Point(12, 230)
        Me.VarF.Name = "VarF"
        Me.VarF.Size = New System.Drawing.Size(52, 17)
        Me.VarF.TabIndex = 4
        Me.VarF.Text = "Suffix"
        Me.VarF.UseVisualStyleBackColor = True
        '
        'VarL
        '
        Me.VarL.AutoSize = True
        Me.VarL.Location = New System.Drawing.Point(12, 256)
        Me.VarL.Name = "VarL"
        Me.VarL.Size = New System.Drawing.Size(166, 17)
        Me.VarL.TabIndex = 4
        Me.VarL.Text = "Maximum HEX values per line"
        Me.VarL.UseVisualStyleBackColor = True
        '
        'VarLnumber
        '
        Me.VarLnumber.Location = New System.Drawing.Point(193, 255)
        Me.VarLnumber.Maximum = New Decimal(New Integer() {5000, 0, 0, 0})
        Me.VarLnumber.Name = "VarLnumber"
        Me.VarLnumber.Size = New System.Drawing.Size(104, 20)
        Me.VarLnumber.TabIndex = 5
        Me.VarLnumber.Value = New Decimal(New Integer() {256, 0, 0, 0})
        '
        'VarC
        '
        Me.VarC.AutoSize = True
        Me.VarC.Enabled = False
        Me.VarC.Location = New System.Drawing.Point(12, 281)
        Me.VarC.Name = "VarC"
        Me.VarC.Size = New System.Drawing.Size(242, 17)
        Me.VarC.TabIndex = 4
        Me.VarC.Text = "Clone and compress the file before converting"
        Me.VarC.UseVisualStyleBackColor = True
        '
        'VarCC
        '
        Me.VarCC.AutoSize = True
        Me.VarCC.Enabled = False
        Me.VarCC.Location = New System.Drawing.Point(31, 304)
        Me.VarCC.Name = "VarCC"
        Me.VarCC.Size = New System.Drawing.Size(273, 17)
        Me.VarCC.TabIndex = 4
        Me.VarCC.Text = "Higher Compression - Disabled on Windows for now."
        Me.VarCC.UseVisualStyleBackColor = True
        '
        'VarT
        '
        Me.VarT.AutoSize = True
        Me.VarT.Location = New System.Drawing.Point(12, 327)
        Me.VarT.Name = "VarT"
        Me.VarT.Size = New System.Drawing.Size(275, 17)
        Me.VarT.TabIndex = 4
        Me.VarT.Text = "Create a Expect file, to automate to a Telnet session."
        Me.VarT.UseVisualStyleBackColor = True
        '
        'VarW
        '
        Me.VarW.AutoSize = True
        Me.VarW.Location = New System.Drawing.Point(12, 350)
        Me.VarW.Name = "VarW"
        Me.VarW.Size = New System.Drawing.Size(285, 17)
        Me.VarW.TabIndex = 4
        Me.VarW.Text = "Create a Expect file, to automate to a WinEXE session."
        Me.VarW.UseVisualStyleBackColor = True
        '
        'BtnExe2Hex
        '
        Me.BtnExe2Hex.Location = New System.Drawing.Point(12, 38)
        Me.BtnExe2Hex.Name = "BtnExe2Hex"
        Me.BtnExe2Hex.Size = New System.Drawing.Size(109, 20)
        Me.BtnExe2Hex.TabIndex = 6
        Me.BtnExe2Hex.Text = "exe2hex File"
        Me.BtnExe2Hex.UseVisualStyleBackColor = True
        '
        'PythonPath
        '
        Me.PythonPath.Location = New System.Drawing.Point(127, 13)
        Me.PythonPath.Name = "PythonPath"
        Me.PythonPath.ReadOnly = True
        Me.PythonPath.Size = New System.Drawing.Size(170, 20)
        Me.PythonPath.TabIndex = 7
        '
        'exe2hexPath
        '
        Me.exe2hexPath.Location = New System.Drawing.Point(127, 39)
        Me.exe2hexPath.Name = "exe2hexPath"
        Me.exe2hexPath.ReadOnly = True
        Me.exe2hexPath.Size = New System.Drawing.Size(170, 20)
        Me.exe2hexPath.TabIndex = 7
        '
        'ExePathBtn
        '
        Me.ExePathBtn.Location = New System.Drawing.Point(12, 98)
        Me.ExePathBtn.Name = "ExePathBtn"
        Me.ExePathBtn.Size = New System.Drawing.Size(109, 20)
        Me.ExePathBtn.TabIndex = 6
        Me.ExePathBtn.Text = "File to Convert"
        Me.ExePathBtn.UseVisualStyleBackColor = True
        '
        'ExePath
        '
        Me.ExePath.Location = New System.Drawing.Point(127, 98)
        Me.ExePath.Name = "ExePath"
        Me.ExePath.ReadOnly = True
        Me.ExePath.Size = New System.Drawing.Size(170, 20)
        Me.ExePath.TabIndex = 7
        '
        'BuildFile
        '
        Me.BuildFile.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BuildFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BuildFile.Location = New System.Drawing.Point(0, 373)
        Me.BuildFile.Name = "BuildFile"
        Me.BuildFile.Size = New System.Drawing.Size(305, 31)
        Me.BuildFile.TabIndex = 8
        Me.BuildFile.Text = "Build File"
        Me.BuildFile.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(201, 65)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 26)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Download"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 26)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "If you don't have the python file," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "You may download the latest version."
        '
        'SetPyPathofd
        '
        Me.SetPyPathofd.FileName = "python.exe"
        Me.SetPyPathofd.Filter = "Python Program|*.exe"
        Me.SetPyPathofd.Title = "Set Python Patch"
        '
        'exe2hexpathofd
        '
        Me.exe2hexpathofd.FileName = "exe2hex.py"
        Me.exe2hexpathofd.Filter = "exe2hex.py|exe2hex.py"
        Me.exe2hexpathofd.Title = "exe2hex Path"
        '
        'exepathofd
        '
        Me.exepathofd.Title = "Open File"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(305, 404)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BuildFile)
        Me.Controls.Add(Me.ExePath)
        Me.Controls.Add(Me.exe2hexPath)
        Me.Controls.Add(Me.ExePathBtn)
        Me.Controls.Add(Me.PythonPath)
        Me.Controls.Add(Me.BtnExe2Hex)
        Me.Controls.Add(Me.VarLnumber)
        Me.Controls.Add(Me.VarL)
        Me.Controls.Add(Me.VarCC)
        Me.Controls.Add(Me.VarW)
        Me.Controls.Add(Me.VarT)
        Me.Controls.Add(Me.VarC)
        Me.Controls.Add(Me.VarF)
        Me.Controls.Add(Me.VarR)
        Me.Controls.Add(Me.VarE)
        Me.Controls.Add(Me.VarP)
        Me.Controls.Add(Me.suffix)
        Me.Controls.Add(Me.prefix)
        Me.Controls.Add(Me.poshout)
        Me.Controls.Add(Me.VarB)
        Me.Controls.Add(Me.batout)
        Me.Controls.Add(Me.BtnPython)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Visual exe2hex"
        CType(Me.VarLnumber, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnPython As Button
    Friend WithEvents VarB As CheckBox
    Friend WithEvents batout As TextBox
    Friend WithEvents poshout As TextBox
    Friend WithEvents VarP As CheckBox
    Friend WithEvents VarE As CheckBox
    Friend WithEvents prefix As TextBox
    Friend WithEvents VarR As CheckBox
    Friend WithEvents suffix As TextBox
    Friend WithEvents VarF As CheckBox
    Friend WithEvents VarL As CheckBox
    Friend WithEvents VarLnumber As NumericUpDown
    Friend WithEvents VarC As CheckBox
    Friend WithEvents VarCC As CheckBox
    Friend WithEvents VarT As CheckBox
    Friend WithEvents VarW As CheckBox
    Friend WithEvents BtnExe2Hex As Button
    Friend WithEvents PythonPath As TextBox
    Friend WithEvents exe2hexPath As TextBox
    Friend WithEvents ExePathBtn As Button
    Friend WithEvents ExePath As TextBox
    Friend WithEvents BuildFile As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents SetPyPathofd As OpenFileDialog
    Friend WithEvents exe2hexpathofd As OpenFileDialog
    Friend WithEvents exepathofd As OpenFileDialog
End Class
