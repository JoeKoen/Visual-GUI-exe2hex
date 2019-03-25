Imports System.IO

Public Class Form1

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

        If ExePath.Text = "" Then
            MessageBox.Show("Nothing is selected.")

        Else
            Vargs = " -x """ + ExePath.Text + """" + " "

            If Not Directory.Exists(".\output") Then
                Directory.CreateDirectory(".\output")
            End If



            If VarB.CheckState = CheckState.Checked Then
                Vargs = Vargs + " -b " + """" + Application.StartupPath + "\output\" + batout.Text + """"
            End If
            If VarP.CheckState = CheckState.Checked Then
                Vargs = Vargs + " -p " + """" + Application.StartupPath + "\output\" + poshout.Text + """"
            End If
            If VarE.CheckState = CheckState.Checked Then
                Vargs = Vargs + " -e " + " "
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
            If VarT.CheckState = CheckState.Checked Then
                Vargs = Vargs + " -t "
            End If
            If VarW.CheckState = CheckState.Checked Then
                Vargs = Vargs + " -w "
            End If

            Dim proc As New Process

            Try
                proc.StartInfo.FileName = PythonPath.Text
                proc.StartInfo.Arguments = """" + exe2hexPath.Text + """" + " " + Vargs
                proc.Start()

            Catch ex As Exception
                MessageBox.Show(ex.StackTrace)
                MessageBox.Show(ex.ToString)
            End Try

        End If



    End Sub
End Class
