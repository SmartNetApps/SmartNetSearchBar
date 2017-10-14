Imports System.Net
Imports Gecko
Imports Gecko.Events

Public Class BrowserForm
    Private Sub NextButton_MouseEnter(sender As Object, e As EventArgs) Handles NextButton.MouseEnter
        NextButton.Image = NextButton.InitialImage
        NextButton.BackColor = SystemColors.MenuHighlight
    End Sub

    Private Sub NextButton_MouseLeave(sender As Object, e As EventArgs) Handles NextButton.MouseLeave
        NextButton.Image = NextButton.ErrorImage
        NextButton.BackColor = SystemColors.Control
    End Sub

    Private Sub PreviousButton_MouseEnter(sender As Object, e As EventArgs) Handles PreviousButton.MouseEnter
        PreviousButton.Image = PreviousButton.InitialImage
        PreviousButton.BackColor = SystemColors.MenuHighlight
    End Sub

    Private Sub PreviousButton_MouseLeave(sender As Object, e As EventArgs) Handles PreviousButton.MouseLeave
        PreviousButton.Image = PreviousButton.ErrorImage
        PreviousButton.BackColor = SystemColors.Control
    End Sub

    Private Sub PreviousButton_Click(sender As Object, e As EventArgs) Handles PreviousButton.Click
        GeckoWebBrowser1.GoBack()
    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        GeckoWebBrowser1.GoForward()
    End Sub

    Private Sub GeckoWebBrowser1_CreateWindow(sender As Object, e As GeckoCreateWindowEventArgs) Handles GeckoWebBrowser1.CreateWindow
        Process.Start(e.Uri)
    End Sub

    Private Sub GeckoWebBrowser1_Navigating(sender As Object, e As GeckoNavigatingEventArgs) Handles GeckoWebBrowser1.Navigating
        Try
            Dim url As Uri = New Uri(e.Uri.ToString)
            If url.HostNameType = UriHostNameType.Dns Then
                Dim iconURL = "http://" & url.Host & "/favicon.ico"
                Dim request As System.Net.WebRequest = System.Net.HttpWebRequest.Create(iconURL)
                Dim response As System.Net.HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
                Dim stream As System.IO.Stream = response.GetResponseStream()
                Dim favicon = Image.FromStream(stream)
                FaviconPictureBox.Image = favicon
            End If
        Catch ex As Exception
            FaviconPictureBox.Image = FaviconPictureBox.ErrorImage
        End Try
        URLTextBox.Text = e.Uri.ToString
    End Sub

    Private Sub URLTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles URLTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            GeckoWebBrowser1.Navigate(URLTextBox.Text)
        End If
    End Sub

    Private Sub GeckoWebBrowser1_CanGoForwardChanged(sender As Object, e As EventArgs) Handles GeckoWebBrowser1.CanGoForwardChanged
        If GeckoWebBrowser1.CanGoForward = True Then
            NextButton.Visible = True
            NextButtonDisabled.Visible = False
        Else
            NextButton.Visible = False
            NextButtonDisabled.Visible = True
        End If
    End Sub

    Private Sub GeckoWebBrowser1_CanGoBackChanged(sender As Object, e As EventArgs) Handles GeckoWebBrowser1.CanGoBackChanged
        If GeckoWebBrowser1.CanGoBack = True Then
            PreviousButton.Visible = True
            PreviousButtonDisabled.Visible = False
        Else
            PreviousButton.Visible = False
            PreviousButtonDisabled.Visible = True
        End If
    End Sub
End Class