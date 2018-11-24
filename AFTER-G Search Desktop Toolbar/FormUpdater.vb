Imports System.Net

Public Class FormUpdater
    Dim agent As UpdateAgent

    Public Sub New()
        InitializeComponent()
        agent = New UpdateAgent()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Button1.Enabled = False
            Button2.Enabled = False
            ProgressBar1.Visible = True
            'Dim MAJ As New WebClient
            Dim MAJ2 As New WebClient
            AddHandler MAJ2.DownloadProgressChanged, AddressOf MAJ2_ProgressChanged
            AddHandler MAJ2.DownloadFileCompleted, AddressOf MAJ2_DownloadCompleted
            Dim DownloadLink As String = agent.DownloadLink()
            'Dim DownloadLink As String = MAJ.DownloadString("http://quentinpugeat.pagesperso-orange.fr/smartnetapps/updater/searchbar/windows/download.txt")
            Dim DerniereVersion As String = agent.LastVersionNumberAvailable()
            'Dim DerniereVersion As String = MAJ.DownloadString("http://quentinpugeat.pagesperso-orange.fr/smartnetapps/updater/searchbar/windows/version.txt")
            MAJ2.DownloadFileAsync(New Uri(DownloadLink), My.Computer.FileSystem.SpecialDirectories.Temp + "\smartnetsearchbar-update-" + DerniereVersion + ".exe")
        Catch ex As Exception
            MsgBox("Téléchargement impossible : " + ex.Message, MsgBoxStyle.Critical, "Téléchargement de la mise à jour")
        End Try
    End Sub

    Private Sub MAJ2_ProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs)
        Dim bytesIn As Double = Double.Parse(e.BytesReceived.ToString())
        Dim totalBytes As Double = Double.Parse(e.TotalBytesToReceive.ToString())
        Dim percentage As Double = bytesIn / totalBytes * 100
        ProgressBar1.Value = Int32.Parse(Math.Truncate(percentage).ToString())
    End Sub

    Private Sub MAJ2_DownloadCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
        Dim MAJ As New WebClient
        Dim DerniereVersion As String = agent.LastVersionNumberAvailable()
        'Dim DerniereVersion As String = MAJ.DownloadString("http://quentinpugeat.pagesperso-orange.fr/smartnetapps/updater/searchbar/windows/version.txt")
        Process.Start(My.Computer.FileSystem.SpecialDirectories.Temp + "\smartnetsearchbar-update-" + DerniereVersion + ".exe", "/SILENT /NOCANCEL /CLOSEAPPLICATIONS /RESTARTAPPLICATIONS")
        Me.Close()
        Application.Exit()
    End Sub

    Private Sub FormUpdater_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim MAJ As New WebClient
        Dim Nouveautes = agent.ReleaseNotes()
        'Dim Nouveautes As String = MAJ.DownloadString("http://quentinpugeat.pagesperso-orange.fr/smartnetapps/updater/searchbar/windows/releasenotes.txt")
        RichTextBox1.Text = Nouveautes
    End Sub
End Class