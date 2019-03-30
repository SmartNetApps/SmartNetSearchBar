Imports Microsoft.VisualBasic.ApplicationServices

Namespace My
    ' Les événements suivants sont disponibles pour MyApplication :
    ' Startup : déclenché au démarrage de l'application avant la création du formulaire de démarrage.
    ' Shutdown : déclenché après la fermeture de tous les formulaires de l'application. Cet événement n'est pas déclenché si l'application se termine de façon anormale.
    ' UnhandledException : déclenché si l'application rencontre une exception non gérée.
    ' StartupNextInstance : déclenché lors du lancement d'une application à instance unique et si cette application est déjà active. 
    ' NetworkAvailabilityChanged : déclenché lorsque la connexion réseau est connectée ou déconnectée.
    Partial Friend Class MyApplication
        Private Sub MyApplication_Startup(sender As Object, e As StartupEventArgs) Handles Me.Startup
            If My.Settings.firststart = True Then
                My.Settings.Upgrade()
                My.Settings.firststart = False
            End If

            If My.Settings.autoupdate = True Then
                Select Case UpdateAgent.IsUpdateAvailable()
                    Case UpdateAgent.UpdateStatus.OSNotSupported
                        MessageBox.Show("Votre système d'exploitation n'étant plus pris en charge, les futures mises à jour ne vous seront pas proposées sur cette machine. Consultez le site d'assistance SmartNet Apps pour en savoir plus.", "SmartNet Apps Updater", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        My.Settings.autoupdate = False
                    Case UpdateAgent.UpdateStatus.SupportStatusOff
                        MessageBox.Show("Ce logiciel a été abandonné et ne sera plus mis à jour. Consultez le site d'assistance SmartNet Apps pour en savoir plus.", "SmartNet Apps Updater", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        My.Settings.autoupdate = False
                End Select
            End If
        End Sub
    End Class
End Namespace