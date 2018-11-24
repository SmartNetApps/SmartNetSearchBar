Imports System.Net

Public Class UpdateAgent
    Dim MAJ As WebClient
    Dim VersionActuelle As Version
    Dim NTActualVersion As Version

    Public Sub New()
        MAJ = New WebClient()
        VersionActuelle = My.Application.Info.Version
        NTActualVersion = Environment.OSVersion.Version
    End Sub

    ''' <summary>
    ''' Vérifie si une mise à jour du logiciel est disponible et retourne vrai le cas échéant.
    ''' </summary>
    ''' <param name="displayMessageBox">Vrai s'il faut afficher un message à l'utilisateur, faux pour vérifier discrètement.</param>
    ''' <returns>Vrai si une mise à jour est disponible, faux sinon.</returns>
    Public Function IsUpdateAvailable(displayMessageBox As Boolean) As Boolean
        Try
            Dim MiniNTVersion As Version = New Version(MAJ.DownloadString("http://quentinpugeat.pagesperso-orange.fr/smartnetapps/updater/searchbar/windows/MinimumNTVersion.txt"))
            Dim DerniereVersion As Version = New Version(MAJ.DownloadString("http://quentinpugeat.pagesperso-orange.fr/smartnetapps/updater/searchbar/windows/version.txt"))
            Dim SupportStatus As String = MAJ.DownloadString("http://quentinpugeat.pagesperso-orange.fr/smartnetapps/updater/searchbar/windows/support-status.txt")

            If VersionActuelle > DerniereVersion Then
                If displayMessageBox = True Then MsgBox("Vous utilisez une version préliminaire de SmartNet Search Bar. Vous pourriez trouver des beugs ou incohérences, merci de ne pas les signaler tant que cette version n'est pas publiée. Veuillez me contacter si vous pensez qu'il s'agit d'une erreur.", MsgBoxStyle.Exclamation, "Version préliminaire")
                Return False
            End If
            If NTActualVersion < MiniNTVersion Then
                If displayMessageBox = True Then MsgBox("Votre système d'exploitation n'est plus pris en charge par SmartNet Apps. Visitez le site SmartNet Apps pour en savoir plus à ce sujet. La recherche automatique de mises à jour à été désactivée.", MsgBoxStyle.Exclamation, "Avertissement")
                My.Settings.autoupdate = False
                My.Settings.Save()
                FormSearchBar.VérifierLesMisesÀJourToolStripMenuItem.Visible = False
                Return False
            End If
            If SupportStatus = "on" Then
                If VersionActuelle < DerniereVersion Then
                    FormSearchBar.UpdateNotifyIcon.Visible = True
                    FormSearchBar.UpdateNotifyIcon.ShowBalloonTip(1000)
                    FormSearchBar.VérifierLesMisesÀJourToolStripMenuItem.Visible = True
                    FormSearchBar.TéléchargerLaVersionXXXXToolStripMenuItem.Text = "Télécharger la version " + DerniereVersion.ToString
                    If displayMessageBox = True Then FormUpdater.ShowDialog()
                    Return True
                Else
                    FormSearchBar.VérifierLesMisesÀJourToolStripMenuItem.Visible = False
                    If displayMessageBox = True Then MsgBox("Vous utilisez dejà la dernière version de SmartNet Search Bar.", MsgBoxStyle.Information, "SmartNet Apps Updater")
                    Return False
                End If
            Else
                FormSearchBar.VérifierLesMisesÀJourToolStripMenuItem.Visible = False
                If displayMessageBox = True Then MsgBox("Le support et le développement de ce produit ont été interrompus. Visitez le site SmartNet Apps pour en savoir plus.", MsgBoxStyle.Critical, "Service interrompu")
                Return False
            End If
        Catch ex As Exception
            If displayMessageBox = True Then MsgBox("La connexion à SmartNet Apps Updater a échoué : " + ex.Message, MsgBoxStyle.Critical, "SmartNet Apps Updater")
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Demande le dernier numéro de version à SmartNet Apps Updater et le retourne.
    ''' </summary>
    ''' <returns>Le dernier numéro de version disponible.</returns>
    Public Function LastVersionAvailable() As Version
        Try
            Dim DerniereVersion As Version = New Version(MAJ.DownloadString("http://quentinpugeat.pagesperso-orange.fr/smartnetapps/updater/searchbar/windows/version.txt"))
            Return DerniereVersion
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' Demande le dernier numéro de version à SmartNet Apps Updater et le retourne.
    ''' </summary>
    ''' <returns>Le dernier numéro de version disponible.</returns>
    Public Function LastVersionNumberAvailable() As String
        Try
            Return MAJ.DownloadString("http://quentinpugeat.pagesperso-orange.fr/smartnetapps/updater/searchbar/windows/version.txt")
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' Retrouve et retourne le lien vers l'exécutable de la mise à jour.
    ''' </summary>
    ''' <returns></returns>
    Public Function DownloadLink() As String
        Try
            Return MAJ.DownloadString("http://quentinpugeat.pagesperso-orange.fr/smartnetapps/updater/searchbar/windows/download.txt")
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' Télécharge et retourne les dernières notes de version.
    ''' </summary>
    ''' <returns></returns>
    Public Function ReleaseNotes() As String
        Try
            Return MAJ.DownloadString("http://quentinpugeat.pagesperso-orange.fr/smartnetapps/updater/searchbar/windows/releasenotes.txt")
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
End Class

