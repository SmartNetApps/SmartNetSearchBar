Imports System.Net
Imports System.Drawing

Public Class FormSearchBar
    Dim IsDraggingForm As Boolean
    Private MousePos As Point

    Public Sub New()
        InitializeComponent()
        IsDraggingForm = False
        MousePos = New Point(0, 0)
    End Sub

    Private Sub FormSearchBar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.autoupdate = True And UpdateAgent.IsUpdateAvailable() = UpdateAgent.UpdateStatus.UpdateAvailable Then
            UpdateNotifyIcon.Visible = True
            UpdateNotifyIcon.ShowBalloonTip(10000)
            VérifierLesMisesÀJourToolStripMenuItem.Visible = True
            TéléchargerLaVersionXXXXToolStripMenuItem.Text = "Mettre à jour vers la version " + UpdateAgent.LastVersionNumberAvailable()
        Else
            UpdateNotifyIcon.Visible = False
            VérifierLesMisesÀJourToolStripMenuItem.Visible = False
        End If

        Me.BackColor = My.Settings.color
        TextBox1.BackColor = My.Settings.color
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

    Private Sub FermerLaBarreDoutilsAFTERGSearchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FermerLaBarreDoutilsAFTERGSearchToolStripMenuItem.Click
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


    Private Sub SearchButtonClick(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim url As String
        Select Case My.Settings.searchengine
            Case 1
                url = "https://www.google.fr/search?q=" + TextBox1.Text
            Case 2
                url = "http://www.bing.com/search?q=" + TextBox1.Text
            Case 3
                url = "https://fr.search.yahoo.com/search?q=" + TextBox1.Text
            Case 4
                url = "https://duckduckgo.com/?q=" + TextBox1.Text
            Case 5
                url = "https://www.qwant.com/?q=" + TextBox1.Text
            Case Else
                My.Settings.searchengine = 5
                url = "https://www.qwant.com/?q=" + TextBox1.Text
        End Select

        If My.Settings.OpenBuiltInBrowser = True Then
            BrowserForm.GeckoWebBrowser1.Navigate(url)
            BrowserForm.Show()
        Else
            Process.Start(url)
        End If
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

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.Visible = True
        Me.Activate()
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

    Private Sub AProposDeAFTERGDesktopToolbarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AProposDeAFTERGDesktopToolbarToolStripMenuItem.Click
        FormAbout.ShowDialog()
    End Sub

    Private Sub ContacterLéquipeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContacterLéquipeToolStripMenuItem.Click
        Process.Start("https://smartnetapps.quentinpugeat.fr/contact.html")
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
        Process.Start("https://smartnetapps.quentinpugeat.fr/searchbar/support/")
    End Sub
End Class
