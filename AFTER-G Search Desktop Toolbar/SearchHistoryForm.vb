Public Class SearchHistoryForm
    ''' <summary>
    ''' Recharge tous les éléments de My.Settings.SearchHistory dans ListBoxHistory.
    ''' </summary>
    Private Sub RefreshListBox()
        ListBoxHistory.Items.Clear()
        For Each entry In My.Settings.SearchHistory
            ListBoxHistory.Items.Add(entry)
        Next
    End Sub

    Private Sub SearchHistoryForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        RefreshListBox()
    End Sub

    Private Sub ListBoxHistory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxHistory.SelectedIndexChanged
        If ListBoxHistory.SelectedIndex <> -1 Then
            SearchAgainButton.Enabled = True
            DeleteEntryButton.Enabled = True
        Else
            SearchAgainButton.Enabled = True
            DeleteEntryButton.Enabled = True
        End If
    End Sub

    Private Sub SearchAgainButton_Click(sender As Object, e As EventArgs) Handles SearchAgainButton.Click
        Dim url As String
        Select Case My.Settings.searchengine
            Case 1
                url = "https://www.google.fr/search?q=" + ListBoxHistory.Items.Item(ListBoxHistory.SelectedIndex).ToString()
            Case 2
                url = "http://www.bing.com/search?q=" + ListBoxHistory.Items.Item(ListBoxHistory.SelectedIndex).ToString()
            Case 3
                url = "https://fr.search.yahoo.com/search?q=" + ListBoxHistory.Items.Item(ListBoxHistory.SelectedIndex).ToString()
            Case 4
                url = "https://duckduckgo.com/?q=" + ListBoxHistory.Items.Item(ListBoxHistory.SelectedIndex).ToString()
            Case 5
                url = "https://www.qwant.com/?q=" + ListBoxHistory.Items.Item(ListBoxHistory.SelectedIndex).ToString()
            Case Else
                My.Settings.searchengine = 5
                url = "https://www.qwant.com/?q=" + ListBoxHistory.Items.Item(ListBoxHistory.SelectedIndex).ToString()
        End Select

        If My.Settings.OpenBuiltInBrowser = True Then
            BrowserForm.GeckoWebBrowser1.Navigate(url)
            BrowserForm.Show()
        Else
            Process.Start(url)
        End If

        My.Settings.SearchHistory.Add(ListBoxHistory.Items.Item(ListBoxHistory.SelectedIndex).ToString())
        My.Settings.Save()
        RefreshListBox()
    End Sub

    Private Sub DeleteEntryButton_Click(sender As Object, e As EventArgs) Handles DeleteEntryButton.Click
        For index = (ListBoxHistory.SelectedIndices.Count - 1) To 0 Step -1
            My.Settings.SearchHistory.RemoveAt(ListBoxHistory.SelectedIndices.Item(index))
        Next
        RefreshListBox()
    End Sub
End Class