Imports System.IO
Imports System.Text.RegularExpressions
Imports System.IO.Compression

Public Class Form1

    Dim ExeFileName As String
    Dim ExeFileExt As String

    Private Sub BtnPython_Click(sender As Object, e As EventArgs) Handles BtnPython.Click
        SetPyPathofd.ShowDialog()
        PythonPath.Text = SetPyPathofd.FileName.ToString
        My.Settings.PythonPath = PythonPath.Text.ToString
        My.Settings.Save()
    End Sub

    Private Sub BtnExe2Hex_Click(sender As Object, e As EventArgs) Handles BtnExe2Hex.Click
        exe2hexpathofd.ShowDialog()
        exe2hexPath.Text = exe2hexpathofd.FileName.ToString
        My.Settings.exe2hexpath = exe2hexPath.Text.ToString
        My.Settings.Save()
    End Sub

    Private Sub ExePathBtn_Click(sender As Object, e As EventArgs) Handles ExePathBtn.Click
        exepathofd.ShowDialog()
        ExePath.Text = exepathofd.FileName.ToString
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PythonPath.Text = My.Settings.PythonPath

        exe2hexPath.Text = My.Settings.exe2hexpath

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DownLoadPyFile.ShowDialog()
    End Sub
    Dim Vargs As String = ""

    Private Sub BuildFile_Click(sender As Object, e As EventArgs) Handles BuildFile.Click


        'compress the file to reduce time



        If Not Directory.Exists(ExePath.Text + "_o") Then
            Directory.CreateDirectory(ExePath.Text + "_o")
        End If
        If Not Directory.Exists(ExePath.Text + "_otmp") Then
            Directory.CreateDirectory(ExePath.Text + "_otmp")
        End If
        Try
            System.IO.File.Copy(ExePath.Text, ExePath.Text + "_otmp\" + ExeFileName)
        Catch ex As Exception

        End Try


        Dim startPath As String = ExePath.Text + "_otmp\"
        Dim zipPath As String = ExePath.Text + "_o\file" + ExeFileExt + ".zip"
        Try
            ZipFile.CreateFromDirectory(startPath, zipPath, CompressionLevel.Optimal, True)
        Catch ex As Exception
        End Try

        If nameout.Text = "" Then
            MessageBox.Show("A Output file is required.")
        Else
            If Method.SelectedIndex.ToString = "" Then
                MessageBox.Show("No method was selected.")
            Else
                If ExePath.Text = "" Then
                    MessageBox.Show("Nothing is selected.")
                Else
                    Vargs = " -v -x """ + zipPath + """" + " "
                    'MessageBox.Show(Vargs)
                    If Not Directory.Exists(".\output") Then
                        Directory.CreateDirectory(".\output")
                    End If

                    ' Setting Name
                    Vargs = Vargs + " -o " + """" + Application.StartupPath + "\output\" + nameout.Text + """"

                    If VarE.CheckState = CheckState.Checked Then
                        Vargs = Vargs + " -e " + " "
                    End If
                    If Method.SelectedIndex = 1 Then
                        Vargs = Vargs + " -m 1" + " "
                    End If
                    If Method.SelectedIndex = 2 Then
                        Vargs = Vargs + " -m 2" + " "
                    End If
                    If Method.SelectedIndex = 3 Then
                        Vargs = Vargs + " -m 3" + " "
                    End If
                    If VarR.CheckState = CheckState.Checked Then
                        Vargs = Vargs + " -r """ + prefix.Text + """ "
                    End If
                    If VarF.CheckState = CheckState.Checked Then
                        Vargs = Vargs + " -f """ + suffix.Text + """ "
                    End If
                    If VarL.CheckState = CheckState.Checked Then
                        Vargs = Vargs + " -l """ + VarLnumber.Text + """ "
                    End If
                    If VarC.CheckState = CheckState.Checked Then
                        Vargs = Vargs + " -c "
                    End If
                    If VarCC.CheckState = CheckState.Checked Then
                        Vargs = Vargs + " -cc "
                    End If
                    'If VarT.CheckState = CheckState.Checked Then
                    '    Vargs = Vargs + " -t "
                    'End If
                    'If VarW.CheckState = CheckState.Checked Then
                    '    Vargs = Vargs + " -w "
                    'End If

                    Dim proc As New Process

                    Try
                        'MessageBox.Show(PythonPath.Text + " " + """" + exe2hexPath.Text + """" + " " + Vargs)
                        proc.StartInfo.FileName = PythonPath.Text
                        proc.StartInfo.Arguments = """" + exe2hexPath.Text + """" + " " + Vargs
                        proc.WaitForExit(proc.Start)

                        My.Computer.FileSystem.DeleteDirectory(ExePath.Text + "_otmp", FileIO.DeleteDirectoryOption.DeleteAllContents)
                        My.Computer.FileSystem.DeleteDirectory(ExePath.Text + "_o", FileIO.DeleteDirectoryOption.DeleteAllContents)

                    Catch ex As Exception
                        MessageBox.Show(ex.StackTrace)
                        MessageBox.Show(ex.ToString)
                    End Try

                End If
            End If
        End If

        'Try
        '    My.Computer.FileSystem.DeleteDirectory(ExePath.Text + "_otmp", FileIO.DeleteDirectoryOption.DeleteAllContents)
        '    My.Computer.FileSystem.DeleteDirectory(ExePath.Text + "_o", FileIO.DeleteDirectoryOption.DeleteAllContents)
        'Catch ex As Exception

        'End Try






    End Sub

    Private Sub ExePathBtn_DragDrop(sender As Object, e As DragEventArgs) Handles ExePathBtn.DragDrop
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
        For Each path In files
            ExePath.Text = path
        Next
    End Sub

    Private Sub ExePath_DragDrop(sender As Object, e As DragEventArgs) Handles ExePath.DragDrop
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
        For Each path In files
            ExePath.Text = path

            ExeFileName = System.IO.Path.GetFileName(files(0))
            ExeFileExt = System.IO.Path.GetExtension(files(0))
        Next
    End Sub

    Private Sub ExePathBtn_DragEnter(sender As Object, e As DragEventArgs) Handles ExePathBtn.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub ExePath_DragEnter(sender As Object, e As DragEventArgs) Handles ExePath.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub
End Class
