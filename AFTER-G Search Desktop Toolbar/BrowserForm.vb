Imports System.ComponentModel
Imports System.Net
Imports Gecko
Imports Gecko.Events

Public Class BrowserForm
    Public Sub New()
        InitializeComponent()
        Xpcom.Initialize("Firefox")
        Gecko.GeckoPreferences.User("intl.accept_languages") = "fr"
        Gecko.GeckoPreferences.User("general.useragent.locale") = "fr"
        If Environment.Is64BitOperatingSystem = True Then
            Gecko.GeckoPreferences.User("general.useragent.override") = "Mozilla/5.0 (Windows NT " + Environment.OSVersion.Version.Major.ToString + "." + Environment.OSVersion.Version.Minor.ToString + "; Win64; x64; rv:45.0) Gecko/20100101 Firefox/45.0  SmartNetSearchBar/" + My.Application.Info.Version.ToString
        Else
            Gecko.GeckoPreferences.User("general.useragent.override") = "Mozilla/5.0 (Windows NT " + Environment.OSVersion.Version.Major.ToString + "." + Environment.OSVersion.Version.Minor.ToString + "; rv45.0) Gecko/20100101 Firefox/45.0  SmartNetSearchBar/" + My.Application.Info.Version.ToString
        End If
        Gecko.GeckoPreferences.Default("media.fragmented-mp4.ffmpeg.enabled") = True
        Gecko.GeckoPreferences.Default("media.mediasource.enabled") = True
        Gecko.GeckoPreferences.Default("media.mediasource.ignore_codecs") = True
        Gecko.GeckoPreferences.Default("extensions.blocklist.enabled") = False
    End Sub

    Private Sub PreviousButton_Click(sender As Object, e As EventArgs) Handles PreviousButton.Click
        GeckoWebBrowser1.GoBack()
    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        GeckoWebBrowser1.GoForward()
    End Sub

    Private Sub GeckoWebBrowser1_CreateWindow(sender As Object, e As GeckoCreateWindowEventArgs) Handles GeckoWebBrowser1.CreateWindow
        e.Cancel = True
        If MessageBox.Show("Cette page cherche à ouvrir une nouvelle fenêtre. Voulez-vous continuer ?", "Confirmer la navigation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Process.Start(e.Uri)
        End If
    End Sub

    Private Sub URLTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles URLTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            GeckoWebBrowser1.Navigate(URLTextBox.Text)
        End If
    End Sub

    Private Sub GeckoWebBrowser1_CanGoForwardChanged(sender As Object, e As EventArgs) Handles GeckoWebBrowser1.CanGoForwardChanged
        NextButton.Enabled = GeckoWebBrowser1.CanGoForward
    End Sub

    Private Sub GeckoWebBrowser1_CanGoBackChanged(sender As Object, e As EventArgs) Handles GeckoWebBrowser1.CanGoBackChanged
        PreviousButton.Enabled = GeckoWebBrowser1.CanGoBack
    End Sub

    Private Sub GeckoWebBrowser1_DocumentTitleChanged(sender As Object, e As EventArgs) Handles GeckoWebBrowser1.DocumentTitleChanged
        Me.Text = GeckoWebBrowser1.DocumentTitle & " - Navigateur SmartNet Search Bar"
    End Sub

    Private Sub BrowserForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        GeckoWebBrowser1.Dispose()
    End Sub

    Private Sub GeckoWebBrowser1_Navigating(sender As Object, e As GeckoNavigatingEventArgs) Handles GeckoWebBrowser1.Navigating
        URLTextBox.Text = e.Uri.ToString()
        FaviconPictureBox.Image = My.Resources.ErrorFavicon
    End Sub

    Private Sub GeckoWebBrowser1_DOMContentLoaded(sender As Object, e As DomEventArgs) Handles GeckoWebBrowser1.DOMContentLoaded
        Console.WriteLine("favicon")
        Dim faviconPath As String
        Try
            Try
                Dim metaLinks As GeckoElementCollection = GeckoWebBrowser1.DomDocument.GetElementsByTagName("LINK")
                For Each element In metaLinks
                    If element.GetAttribute("REL").ToUpper() = "ICON" Then
                        faviconPath = element.GetAttribute("HREF")
                        If faviconPath.Contains("://") = False Then
                            If GeckoWebBrowser1.Url.Host.Contains("/") Or faviconPath.Substring(0, 1) = "/" Then
                                faviconPath = "http://" + GeckoWebBrowser1.Url.Host + faviconPath
                            Else
                                faviconPath = "http://" + GeckoWebBrowser1.Url.Host + "/" + faviconPath
                            End If
                        End If
                        GoTo FaviconFound
                    End If
                Next
            Catch ex As Exception
                GoTo FaviconNotFound
            End Try
FaviconNotFound:
            If GeckoWebBrowser1.Url.HostNameType = UriHostNameType.Dns Then
                faviconPath = "http://" & GeckoWebBrowser1.Url.Host & "/favicon.ico"
            Else
                FaviconPictureBox.Image = My.Resources.ErrorFavicon
                Exit Sub
            End If
FaviconFound:
            Dim request As System.Net.WebRequest = System.Net.HttpWebRequest.Create(faviconPath)
            Dim response As System.Net.HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
            Dim stream As System.IO.Stream = response.GetResponseStream()
            Dim favicon = Image.FromStream(stream)
            FaviconPictureBox.Image = favicon

        Catch ex As Exception
            FaviconPictureBox.Image = My.Resources.ErrorFavicon
            Exit Sub
        End Try
    End Sub
End Class