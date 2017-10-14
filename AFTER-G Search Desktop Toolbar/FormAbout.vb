Public Class FormAbout

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles Me.Load
        Label3.Text = "Version " + My.Application.Info.Version.ToString
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("http://quentinpugeat.wixsite.com/apps/search-bar")
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Process.Start("http://quentinpugeat.wixsite.com/lesiteofficiel/declaration-de-confidentialite")
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Process.Start("notepad.exe", My.Application.Info.DirectoryPath + "\COPYING.txt")
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Process.Start("notepad.exe", My.Application.Info.DirectoryPath + "\COPYING.txt")
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Process.Start("https://www.mozilla.org/en-US/MPL/2.0/")
    End Sub
End Class