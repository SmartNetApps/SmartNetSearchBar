Imports System.Net

Public Class FormUpdater
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub FormUpdater_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RichTextBoxReleaseNotes.Text = UpdateAgent.ReleaseNotes()
    End Sub

    Private Sub ButtonRemindMeLater_Click(sender As Object, e As EventArgs) Handles ButtonRemindMeLater.Click
        Me.Close()
    End Sub

    Private Sub ButtonDownloadNow_Click(sender As Object, e As EventArgs) Handles ButtonDownloadNow.Click
BeginDownload:
        Dim downloader As New WebClient()
        AddHandler downloader.DownloadProgressChanged, AddressOf downloader_ProgressChanged
        AddHandler downloader.DownloadFileCompleted, AddressOf downloader_DownloadCompleted
        Try
            ButtonDownloadNow.Enabled = False
            ButtonRemindMeLater.Enabled = False
            ProgressBar1.Visible = True

            downloader.DownloadFileAsync(New Uri(UpdateAgent.DownloadLink()), My.Computer.FileSystem.SpecialDirectories.Temp + "\smartnetsearchbar-update-" + UpdateAgent.LastVersionNumberAvailable + ".exe")
        Catch ex As Exception
            If MessageBox.Show("Le téléchargement a échoué. " + ex.Message, "SmartNet Apps Updater", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation) = DialogResult.Retry Then
                GoTo BeginDownload
            End If
        End Try
    End Sub

    Private Sub downloader_ProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs)
        Dim bytesIn As Double = Double.Parse(e.BytesReceived.ToString())
        Dim totalBytes As Double = Double.Parse(e.TotalBytesToReceive.ToString())
        Dim percentage As Double = bytesIn / totalBytes * 100
        ProgressBar1.Value = Int32.Parse(Math.Truncate(percentage).ToString())
    End Sub

    Private Sub downloader_DownloadCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
        Process.Start(My.Computer.FileSystem.SpecialDirectories.Temp + "\smartnetsearchbar-update-" + UpdateAgent.LastVersionNumberAvailable() + ".exe", "/SILENT /NOCANCEL /CLOSEAPPLICATIONS /RESTARTAPPLICATIONS")
        Me.Close()
        Environment.Exit(0)
    End Sub
End Class