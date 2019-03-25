Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports System.Threading

Public Class DownLoadPyFile

    Private WithEvents HTTPCLIENT As WebClient

    Private Sub DownLoadPyFile_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Try
                'TempN = Rnd()
                HTTPCLIENT = New WebClient
                Dim Download As String = "https://raw.githubusercontent.com/g0tmi1k/exe2hex/master/exe2hex.py"
                Dim USER = Environment.UserName
                Dim SAVE As String = ".\exe2hex.py"
                Try
                    HTTPCLIENT.DownloadFileAsync(New Uri(Download), SAVE)
                    Form1.exe2hexPath.Text = Application.StartupPath + "\exe2hex.py"
                    My.Settings.exe2hexpath = Form1.exe2hexPath.Text.ToString
                    My.Settings.Save()
                    Me.Hide()
                Catch ex As Exception

                End Try
            Catch ex As Exception

            End Try
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.CheckState = CheckState.Checked Then
            Button1.Enabled = 1
        Else
            Button1.Enabled = 0
        End If
    End Sub
End Class