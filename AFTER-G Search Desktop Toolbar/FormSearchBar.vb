Imports System.Net

Public Class FormSearchBar
    Dim IsDraggingForm As Boolean = False
    Private MousePos As New System.Drawing.Point(0, 0)
    Dim VersionActuelle As String = My.Application.Info.Version.ToString

    Private Sub QuitSearchBar(sender As Object, e As EventArgs) Handles FermerLaBarreDoutilsAFTERGSearchToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AffichermasquerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AffichermasquerToolStripMenuItem.Click
        If Me.Visible = True Then
            Me.Visible = False
            If My.Settings.balloontip = "0" Then
                NotifyIcon1.ShowBalloonTip(1000)
                My.Settings.balloontip = "1"
            End If
        Else
            Me.Visible = True
        End If
    End Sub

    Private Sub FormSearchBar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.autoupdate = True Then
            CheckUpdates()
        End If
        Try
            Me.BackColor = My.Settings.color
            TextBox1.BackColor = My.Settings.color
        Catch ex As exception
        End Try
        Select Case My.Settings.searchengine
            Case 1
                PictureBoxSearchEngineLogo.Image = My.Resources.google
            Case 2
                PictureBoxSearchEngineLogo.Image = My.Resources.bing
            Case 3
                PictureBoxSearchEngineLogo.Image = My.Resources.yahoo
            Case 4
                PictureBoxSearchEngineLogo.Image = My.Resources.duckduckgo
            Case 5
                PictureBoxSearchEngineLogo.Image = My.Resources.qwant
        End Select
    End Sub

    Private Sub SearchButtonClick(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Select Case My.Settings.searchengine
            Case 1
                If My.Settings.OpenBuiltInBrowser = True Then
                    BrowserForm.GeckoWebBrowser1.Navigate("https://www.google.fr/search?q=" + TextBox1.Text)
                    BrowserForm.Show()
                Else
                    Process.Start("https://www.google.fr/search?q=" + TextBox1.Text)
                End If
            Case 2
                If My.Settings.OpenBuiltInBrowser = True Then
                    BrowserForm.GeckoWebBrowser1.Navigate("http://www.bing.com/search?q=" + TextBox1.Text)
                    BrowserForm.Show()
                Else
                    Process.Start("http://www.bing.com/search?q=" + TextBox1.Text)
                End If
            Case 3
                If My.Settings.OpenBuiltInBrowser = True Then
                    BrowserForm.GeckoWebBrowser1.Navigate("https://fr.search.yahoo.com/search?q=" + TextBox1.Text)
                    BrowserForm.Show()
                Else
                    Process.Start("https://fr.search.yahoo.com/search?q=" + TextBox1.Text)
                End If
            Case 4
                If My.Settings.OpenBuiltInBrowser = True Then
                    BrowserForm.GeckoWebBrowser1.Navigate("https://duckduckgo.com/?q=" + TextBox1.Text)
                    BrowserForm.Show()
                Else
                    Process.Start("https://duckduckgo.com/?q=" + TextBox1.Text)
                End If
            Case 5
                If My.Settings.OpenBuiltInBrowser = True Then
                    BrowserForm.GeckoWebBrowser1.Navigate("https://www.qwant.com/?q=" + TextBox1.Text)
                    BrowserForm.Show()
                Else
                    Process.Start("https://www.qwant.com/?q=" + TextBox1.Text)
                End If
        End Select
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Select Case My.Settings.searchengine
                Case 1
                    If My.Settings.OpenBuiltInBrowser = True Then
                        BrowserForm.GeckoWebBrowser1.Navigate("https://www.google.fr/search?q=" + TextBox1.Text)
                        BrowserForm.Show()
                    Else
                        Process.Start("https://www.google.fr/search?q=" + TextBox1.Text)
                    End If
                Case 2
                    If My.Settings.OpenBuiltInBrowser = True Then
                        BrowserForm.GeckoWebBrowser1.Navigate("http://www.bing.com/search?q=" + TextBox1.Text)
                        BrowserForm.Show()
                    Else
                        Process.Start("http://www.bing.com/search?q=" + TextBox1.Text)
                    End If
                Case 3
                    If My.Settings.OpenBuiltInBrowser = True Then
                        BrowserForm.GeckoWebBrowser1.Navigate("https://fr.search.yahoo.com/search?q=" + TextBox1.Text)
                        BrowserForm.Show()
                    Else
                        Process.Start("https://fr.search.yahoo.com/search?q=" + TextBox1.Text)
                    End If
                Case 4
                    If My.Settings.OpenBuiltInBrowser = True Then
                        BrowserForm.GeckoWebBrowser1.Navigate("https://duckduckgo.com/?q=" + TextBox1.Text)
                        BrowserForm.Show()
                    Else
                        Process.Start("https://duckduckgo.com/?q=" + TextBox1.Text)
                    End If
                Case 5
                    If My.Settings.OpenBuiltInBrowser = True Then
                        BrowserForm.GeckoWebBrowser1.Navigate("https://www.qwant.com/?q=" + TextBox1.Text)
                        BrowserForm.Show()
                    Else
                        Process.Start("https://www.qwant.com/?q=" + TextBox1.Text)
                    End If
            End Select
        End If
    End Sub

    Private Sub HideSearchBar(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Visible = False
        If My.Settings.balloontip = "0" Then
            NotifyIcon1.ShowBalloonTip(1000)
            My.Settings.balloontip = "1"
        End If
    End Sub

    Private Sub UpdaterNotifyIconClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.Visible = True
    End Sub

    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseDown
        If e.Button = MouseButtons.Left Then
            IsDraggingForm = True
            MousePos = e.Location
        End If
    End Sub

    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseUp
        If e.Button = MouseButtons.Left Then IsDraggingForm = False
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseMove
        If IsDraggingForm Then
            Dim temp As Point = New Point(Me.Location + (e.Location - MousePos))
            Me.Location = temp
            temp = Nothing
        End If
    End Sub

    Private Sub StartDraggingForm(ByVal sender As Object, ByVal e As MouseEventArgs) Handles PictureBoxSearchEngineLogo.MouseDown
        If e.Button = MouseButtons.Left Then
            IsDraggingForm = True
            MousePos = e.Location
        End If
    End Sub

    Private Sub StopDraggingForm(ByVal sender As Object, ByVal e As MouseEventArgs) Handles PictureBoxSearchEngineLogo.MouseUp
        If e.Button = MouseButtons.Left Then IsDraggingForm = False
    End Sub

    Private Sub DraggingForm(ByVal sender As Object, ByVal e As MouseEventArgs) Handles PictureBoxSearchEngineLogo.MouseMove
        If IsDraggingForm Then
            Dim temp As Point = New Point(Me.Location + (e.Location - MousePos))
            Me.Location = temp
            temp = Nothing
        End If
    End Sub

    Private Sub ShowSettingsForm(sender As Object, e As EventArgs) Handles ParamètresToolStripMenuItem.Click
        FormSettings.Show()
    End Sub

    Private Sub ShowMenu(sender As Object, e As EventArgs) Handles PictureBox4.Click
        ContextMenuStrip2.Show(Me, PointToClient(New Point(MousePosition.X, MousePosition.Y)))
    End Sub

    Sub CheckUpdates()
        Try
            Dim MiniNTVersionChecker As New WebClient
            Dim NTActualVersion As Version = Environment.OSVersion.Version
            Dim MiniNTVersion As Version = New Version(MiniNTVersionChecker.DownloadString("http://quentinpugeat.pagesperso-orange.fr/smartnetapps/updater/searchbar/windows/MinimumNTVersion.txt"))
            Dim MAJ As New WebClient
            Dim VersionActuelle As Version = My.Application.Info.Version
            Dim DerniereVersion As Version = New Version(MAJ.DownloadString("http://quentinpugeat.pagesperso-orange.fr/smartnetapps/updater/searchbar/windows/version.txt"))
            Dim SupportStatus As String = MAJ.DownloadString("http://quentinpugeat.pagesperso-orange.fr/smartnetapps/updater/searchbar/windows/support-status.txt")
            If VersionActuelle > DerniereVersion Then
                MsgBox("Vous utilisez une version de SmartNet Search Bar qui n'a pas encore été publiée. Par conséquent, elle peut contenir des incohérences et des beugs. Merci de ne pas les signaler tant que cette version n'aura pas été publiée.", MsgBoxStyle.Exclamation, "Version non publiée")
            End If
            If My.Settings.autoupdate = True Then
                If NTActualVersion < MiniNTVersion Then
                    MsgBox("Votre système d'exploitation n'est plus pris en charge par SmartNet Apps. Visitez le site SmartNet Apps pour en savoir plus à ce sujet. La recherche automatique de mises à jour à été désactivée.", MsgBoxStyle.Exclamation, "Avertissement")
                    My.Settings.autoupdate = False
                    My.Settings.Save()
                    VérifierLesMisesÀJourToolStripMenuItem.Visible = False
                    GoTo StopVersionChecking
                End If
                If SupportStatus = "on" Then
                    If VersionActuelle < DerniereVersion Then
                        UpdateNotifyIcon.Visible = True
                        UpdateNotifyIcon.ShowBalloonTip(1000)
                        VérifierLesMisesÀJourToolStripMenuItem.Visible = True
                        TéléchargerLaVersionXXXXToolStripMenuItem.Text = "Télécharger la version " + DerniereVersion.ToString
                    Else
                        VérifierLesMisesÀJourToolStripMenuItem.Visible = False
                        GoTo StopVersionChecking
                    End If
                Else
                    VérifierLesMisesÀJourToolStripMenuItem.Visible = False
                    MsgBox("Le support et le développement de ce produit ont été interrompus. Visitez le site SmartNet Apps pour en savoir plus.", MsgBoxStyle.Critical, "Service interrompu")
                    GoTo StopVersionChecking
                End If
            End If
StopVersionChecking:
        Catch ex As Exception
            MsgBox("La connexion à SmartNet Apps Updater a échoué : " + ex.Message, MsgBoxStyle.Critical, "SmartNet Apps Updater")
        End Try
    End Sub

    Private Sub AProposDeAFTERGDesktopToolbarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AProposDeAFTERGDesktopToolbarToolStripMenuItem.Click
        FormAbout.ShowDialog()
    End Sub

    Private Sub ContacterLéquipeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContacterLéquipeToolStripMenuItem.Click
        Process.Start("http://quentinpugeat.wixsite.com/lesiteofficiel/contact")
    End Sub

    Private Sub QuitterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitterToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub TéléchargerLaVersionXXXXToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TéléchargerLaVersionXXXXToolStripMenuItem.Click
        FormUpdater.ShowDialog()
    End Sub

    Private Sub EnvoyerVosCommentairesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnvoyerVosCommentairesToolStripMenuItem.Click
        Process.Start("https://docs.google.com/forms/d/e/1FAIpQLSfDOtJCgxLRUBP4sx_BZVBJ2tHNzzWwxAYTmsMlhQzQUGNlaw/viewform?usp=sf_link")
    End Sub

    Private Sub CentreDaideEnLigneToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CentreDaideEnLigneToolStripMenuItem.Click
        Process.Start("http://quentinpugeat.pagesperso-orange.fr/smartnetapps/searchbar/support/")
    End Sub
End Class
