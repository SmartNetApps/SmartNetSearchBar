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
            Gecko.Xpcom.Initialize("Firefox")
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
    End Class
End Namespace