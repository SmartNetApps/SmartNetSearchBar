<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSettings
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSettings))
        Me.AutoLaunchCheckBox = New System.Windows.Forms.CheckBox()
        Me.GeneralSettingsGroupBox = New System.Windows.Forms.GroupBox()
        Me.SearchBarColorGroupBox = New System.Windows.Forms.GroupBox()
        Me.ChangeBarColorButton = New System.Windows.Forms.Button()
        Me.OKButton = New System.Windows.Forms.Button()
        Me.ImportExportSettingsGroupBox = New System.Windows.Forms.GroupBox()
        Me.ImportFromPreviousVersionButton = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.SearchEngineGroupBox = New System.Windows.Forms.GroupBox()
        Me.RadioButtonQwant = New System.Windows.Forms.RadioButton()
        Me.RadioButtonDuckDuckGo = New System.Windows.Forms.RadioButton()
        Me.RadioButtonYahoo = New System.Windows.Forms.RadioButton()
        Me.RadioButtonBing = New System.Windows.Forms.RadioButton()
        Me.RadioButtonGoogle = New System.Windows.Forms.RadioButton()
        Me.SettingsTabControl = New System.Windows.Forms.TabControl()
        Me.MainTabPage = New System.Windows.Forms.TabPage()
        Me.UpdatesTabPage = New System.Windows.Forms.TabPage()
        Me.UpdatesManagementGroupBox = New System.Windows.Forms.GroupBox()
        Me.CheckUpdatesNowButton = New System.Windows.Forms.Button()
        Me.CurrentVersionLabel = New System.Windows.Forms.Label()
        Me.AutomaticUpdatesGroupBox = New System.Windows.Forms.GroupBox()
        Me.AutoUpdatesCheckBox = New System.Windows.Forms.CheckBox()
        Me.BrowserTabPage = New System.Windows.Forms.TabPage()
        Me.BrowserDataGroupBox = New System.Windows.Forms.GroupBox()
        Me.DeleteCookiesButton = New System.Windows.Forms.Button()
        Me.DeleteCache = New System.Windows.Forms.Button()
        Me.DeleteHistoryButton = New System.Windows.Forms.Button()
        Me.BuiltInBrowserCheckBox = New System.Windows.Forms.CheckBox()
        Me.AdvancedSettingsTabPage = New System.Windows.Forms.TabPage()
        Me.RestoreDefaultColorLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.GeneralSettingsGroupBox.SuspendLayout()
        Me.SearchBarColorGroupBox.SuspendLayout()
        Me.ImportExportSettingsGroupBox.SuspendLayout()
        Me.SearchEngineGroupBox.SuspendLayout()
        Me.SettingsTabControl.SuspendLayout()
        Me.MainTabPage.SuspendLayout()
        Me.UpdatesTabPage.SuspendLayout()
        Me.UpdatesManagementGroupBox.SuspendLayout()
        Me.AutomaticUpdatesGroupBox.SuspendLayout()
        Me.BrowserTabPage.SuspendLayout()
        Me.BrowserDataGroupBox.SuspendLayout()
        Me.AdvancedSettingsTabPage.SuspendLayout()
        Me.SuspendLayout()
        '
        'AutoLaunchCheckBox
        '
        Me.AutoLaunchCheckBox.AutoSize = True
        Me.AutoLaunchCheckBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AutoLaunchCheckBox.Location = New System.Drawing.Point(12, 20)
        Me.AutoLaunchCheckBox.Name = "AutoLaunchCheckBox"
        Me.AutoLaunchCheckBox.Size = New System.Drawing.Size(330, 19)
        Me.AutoLaunchCheckBox.TabIndex = 0
        Me.AutoLaunchCheckBox.Text = "Lancer la barre de recherche au démarrage de l'ordinateur"
        Me.AutoLaunchCheckBox.UseVisualStyleBackColor = True
        '
        'GeneralSettingsGroupBox
        '
        Me.GeneralSettingsGroupBox.Controls.Add(Me.AutoLaunchCheckBox)
        Me.GeneralSettingsGroupBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GeneralSettingsGroupBox.Location = New System.Drawing.Point(6, 6)
        Me.GeneralSettingsGroupBox.Name = "GeneralSettingsGroupBox"
        Me.GeneralSettingsGroupBox.Size = New System.Drawing.Size(391, 49)
        Me.GeneralSettingsGroupBox.TabIndex = 1
        Me.GeneralSettingsGroupBox.TabStop = False
        Me.GeneralSettingsGroupBox.Text = "Paramètres généraux"
        '
        'SearchBarColorGroupBox
        '
        Me.SearchBarColorGroupBox.Controls.Add(Me.RestoreDefaultColorLinkLabel)
        Me.SearchBarColorGroupBox.Controls.Add(Me.ChangeBarColorButton)
        Me.SearchBarColorGroupBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchBarColorGroupBox.Location = New System.Drawing.Point(6, 61)
        Me.SearchBarColorGroupBox.Name = "SearchBarColorGroupBox"
        Me.SearchBarColorGroupBox.Size = New System.Drawing.Size(391, 71)
        Me.SearchBarColorGroupBox.TabIndex = 2
        Me.SearchBarColorGroupBox.TabStop = False
        Me.SearchBarColorGroupBox.Text = "Couleur de la barre de recherche"
        '
        'ChangeBarColorButton
        '
        Me.ChangeBarColorButton.Location = New System.Drawing.Point(12, 22)
        Me.ChangeBarColorButton.Name = "ChangeBarColorButton"
        Me.ChangeBarColorButton.Size = New System.Drawing.Size(255, 23)
        Me.ChangeBarColorButton.TabIndex = 4
        Me.ChangeBarColorButton.Text = "Changer la couleur de la barre de recherche..."
        Me.ChangeBarColorButton.UseVisualStyleBackColor = True
        '
        'OKButton
        '
        Me.OKButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OKButton.Location = New System.Drawing.Point(343, 284)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(75, 23)
        Me.OKButton.TabIndex = 3
        Me.OKButton.Text = "OK"
        Me.OKButton.UseVisualStyleBackColor = True
        '
        'ImportExportSettingsGroupBox
        '
        Me.ImportExportSettingsGroupBox.Controls.Add(Me.ImportFromPreviousVersionButton)
        Me.ImportExportSettingsGroupBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ImportExportSettingsGroupBox.Location = New System.Drawing.Point(6, 6)
        Me.ImportExportSettingsGroupBox.Name = "ImportExportSettingsGroupBox"
        Me.ImportExportSettingsGroupBox.Size = New System.Drawing.Size(391, 50)
        Me.ImportExportSettingsGroupBox.TabIndex = 4
        Me.ImportExportSettingsGroupBox.TabStop = False
        Me.ImportExportSettingsGroupBox.Text = "Importer/Exporter les paramètres"
        '
        'ImportFromPreviousVersionButton
        '
        Me.ImportFromPreviousVersionButton.Location = New System.Drawing.Point(12, 22)
        Me.ImportFromPreviousVersionButton.Name = "ImportFromPreviousVersionButton"
        Me.ImportFromPreviousVersionButton.Size = New System.Drawing.Size(335, 23)
        Me.ImportFromPreviousVersionButton.TabIndex = 5
        Me.ImportFromPreviousVersionButton.Text = "Importer mes paramètres depuis une ancienne version..."
        Me.ImportFromPreviousVersionButton.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'FolderBrowserDialog1
        '
        Me.FolderBrowserDialog1.Description = "Veuillez sélectionner le dossier où vous souhaitez enregistrer les fichiers. Le f" &
    "ichier se nommera ""AFTER-G Search Desktop Toolbar.exe.config""."
        '
        'SearchEngineGroupBox
        '
        Me.SearchEngineGroupBox.Controls.Add(Me.RadioButtonQwant)
        Me.SearchEngineGroupBox.Controls.Add(Me.RadioButtonDuckDuckGo)
        Me.SearchEngineGroupBox.Controls.Add(Me.RadioButtonYahoo)
        Me.SearchEngineGroupBox.Controls.Add(Me.RadioButtonBing)
        Me.SearchEngineGroupBox.Controls.Add(Me.RadioButtonGoogle)
        Me.SearchEngineGroupBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchEngineGroupBox.Location = New System.Drawing.Point(6, 138)
        Me.SearchEngineGroupBox.Name = "SearchEngineGroupBox"
        Me.SearchEngineGroupBox.Size = New System.Drawing.Size(391, 103)
        Me.SearchEngineGroupBox.TabIndex = 5
        Me.SearchEngineGroupBox.TabStop = False
        Me.SearchEngineGroupBox.Text = "Moteur de recherche"
        '
        'RadioButtonQwant
        '
        Me.RadioButtonQwant.AutoSize = True
        Me.RadioButtonQwant.Location = New System.Drawing.Point(197, 46)
        Me.RadioButtonQwant.Name = "RadioButtonQwant"
        Me.RadioButtonQwant.Size = New System.Drawing.Size(60, 19)
        Me.RadioButtonQwant.TabIndex = 5
        Me.RadioButtonQwant.TabStop = True
        Me.RadioButtonQwant.Text = "Qwant"
        Me.RadioButtonQwant.UseVisualStyleBackColor = True
        '
        'RadioButtonDuckDuckGo
        '
        Me.RadioButtonDuckDuckGo.AutoSize = True
        Me.RadioButtonDuckDuckGo.Location = New System.Drawing.Point(197, 23)
        Me.RadioButtonDuckDuckGo.Name = "RadioButtonDuckDuckGo"
        Me.RadioButtonDuckDuckGo.Size = New System.Drawing.Size(94, 19)
        Me.RadioButtonDuckDuckGo.TabIndex = 4
        Me.RadioButtonDuckDuckGo.TabStop = True
        Me.RadioButtonDuckDuckGo.Text = "DuckDuckGo"
        Me.RadioButtonDuckDuckGo.UseVisualStyleBackColor = True
        '
        'RadioButtonYahoo
        '
        Me.RadioButtonYahoo.AutoSize = True
        Me.RadioButtonYahoo.Location = New System.Drawing.Point(12, 71)
        Me.RadioButtonYahoo.Name = "RadioButtonYahoo"
        Me.RadioButtonYahoo.Size = New System.Drawing.Size(61, 19)
        Me.RadioButtonYahoo.TabIndex = 3
        Me.RadioButtonYahoo.TabStop = True
        Me.RadioButtonYahoo.Text = "Yahoo!"
        Me.RadioButtonYahoo.UseVisualStyleBackColor = True
        '
        'RadioButtonBing
        '
        Me.RadioButtonBing.AutoSize = True
        Me.RadioButtonBing.Location = New System.Drawing.Point(12, 46)
        Me.RadioButtonBing.Name = "RadioButtonBing"
        Me.RadioButtonBing.Size = New System.Drawing.Size(49, 19)
        Me.RadioButtonBing.TabIndex = 2
        Me.RadioButtonBing.TabStop = True
        Me.RadioButtonBing.Text = "Bing"
        Me.RadioButtonBing.UseVisualStyleBackColor = True
        '
        'RadioButtonGoogle
        '
        Me.RadioButtonGoogle.AutoSize = True
        Me.RadioButtonGoogle.Location = New System.Drawing.Point(12, 23)
        Me.RadioButtonGoogle.Name = "RadioButtonGoogle"
        Me.RadioButtonGoogle.Size = New System.Drawing.Size(63, 19)
        Me.RadioButtonGoogle.TabIndex = 1
        Me.RadioButtonGoogle.TabStop = True
        Me.RadioButtonGoogle.Text = "Google"
        Me.RadioButtonGoogle.UseVisualStyleBackColor = True
        '
        'SettingsTabControl
        '
        Me.SettingsTabControl.Controls.Add(Me.MainTabPage)
        Me.SettingsTabControl.Controls.Add(Me.UpdatesTabPage)
        Me.SettingsTabControl.Controls.Add(Me.BrowserTabPage)
        Me.SettingsTabControl.Controls.Add(Me.AdvancedSettingsTabPage)
        Me.SettingsTabControl.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SettingsTabControl.Location = New System.Drawing.Point(8, 8)
        Me.SettingsTabControl.Name = "SettingsTabControl"
        Me.SettingsTabControl.SelectedIndex = 0
        Me.SettingsTabControl.Size = New System.Drawing.Size(411, 275)
        Me.SettingsTabControl.TabIndex = 6
        '
        'MainTabPage
        '
        Me.MainTabPage.Controls.Add(Me.SearchEngineGroupBox)
        Me.MainTabPage.Controls.Add(Me.GeneralSettingsGroupBox)
        Me.MainTabPage.Controls.Add(Me.SearchBarColorGroupBox)
        Me.MainTabPage.Location = New System.Drawing.Point(4, 24)
        Me.MainTabPage.Name = "MainTabPage"
        Me.MainTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.MainTabPage.Size = New System.Drawing.Size(403, 247)
        Me.MainTabPage.TabIndex = 0
        Me.MainTabPage.Text = "Barre d'outils"
        Me.MainTabPage.UseVisualStyleBackColor = True
        '
        'UpdatesTabPage
        '
        Me.UpdatesTabPage.Controls.Add(Me.UpdatesManagementGroupBox)
        Me.UpdatesTabPage.Controls.Add(Me.AutomaticUpdatesGroupBox)
        Me.UpdatesTabPage.Location = New System.Drawing.Point(4, 24)
        Me.UpdatesTabPage.Name = "UpdatesTabPage"
        Me.UpdatesTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.UpdatesTabPage.Size = New System.Drawing.Size(403, 247)
        Me.UpdatesTabPage.TabIndex = 1
        Me.UpdatesTabPage.Text = "Mises à jour"
        Me.UpdatesTabPage.UseVisualStyleBackColor = True
        '
        'UpdatesManagementGroupBox
        '
        Me.UpdatesManagementGroupBox.Controls.Add(Me.CheckUpdatesNowButton)
        Me.UpdatesManagementGroupBox.Controls.Add(Me.CurrentVersionLabel)
        Me.UpdatesManagementGroupBox.Location = New System.Drawing.Point(6, 59)
        Me.UpdatesManagementGroupBox.Name = "UpdatesManagementGroupBox"
        Me.UpdatesManagementGroupBox.Size = New System.Drawing.Size(391, 71)
        Me.UpdatesManagementGroupBox.TabIndex = 0
        Me.UpdatesManagementGroupBox.TabStop = False
        Me.UpdatesManagementGroupBox.Text = "Gérer les mises à jour"
        '
        'CheckUpdatesNowButton
        '
        Me.CheckUpdatesNowButton.Location = New System.Drawing.Point(12, 40)
        Me.CheckUpdatesNowButton.Name = "CheckUpdatesNowButton"
        Me.CheckUpdatesNowButton.Size = New System.Drawing.Size(200, 23)
        Me.CheckUpdatesNowButton.TabIndex = 1
        Me.CheckUpdatesNowButton.Text = "Vérifier les mises à jour maintenant"
        Me.CheckUpdatesNowButton.UseVisualStyleBackColor = True
        '
        'CurrentVersionLabel
        '
        Me.CurrentVersionLabel.AutoSize = True
        Me.CurrentVersionLabel.Location = New System.Drawing.Point(9, 22)
        Me.CurrentVersionLabel.Name = "CurrentVersionLabel"
        Me.CurrentVersionLabel.Size = New System.Drawing.Size(131, 15)
        Me.CurrentVersionLabel.TabIndex = 0
        Me.CurrentVersionLabel.Text = "Version actuelle : 0.0.0.0"
        '
        'AutomaticUpdatesGroupBox
        '
        Me.AutomaticUpdatesGroupBox.Controls.Add(Me.AutoUpdatesCheckBox)
        Me.AutomaticUpdatesGroupBox.Location = New System.Drawing.Point(6, 6)
        Me.AutomaticUpdatesGroupBox.Name = "AutomaticUpdatesGroupBox"
        Me.AutomaticUpdatesGroupBox.Size = New System.Drawing.Size(391, 47)
        Me.AutomaticUpdatesGroupBox.TabIndex = 0
        Me.AutomaticUpdatesGroupBox.TabStop = False
        Me.AutomaticUpdatesGroupBox.Text = "Vérification automatique"
        '
        'AutoUpdatesCheckBox
        '
        Me.AutoUpdatesCheckBox.AutoSize = True
        Me.AutoUpdatesCheckBox.Location = New System.Drawing.Point(12, 20)
        Me.AutoUpdatesCheckBox.Name = "AutoUpdatesCheckBox"
        Me.AutoUpdatesCheckBox.Size = New System.Drawing.Size(326, 19)
        Me.AutoUpdatesCheckBox.TabIndex = 0
        Me.AutoUpdatesCheckBox.Text = "Vérifier automatiquement les mises à jour (recommandé)"
        Me.AutoUpdatesCheckBox.UseVisualStyleBackColor = True
        '
        'BrowserTabPage
        '
        Me.BrowserTabPage.Controls.Add(Me.BrowserDataGroupBox)
        Me.BrowserTabPage.Controls.Add(Me.BuiltInBrowserCheckBox)
        Me.BrowserTabPage.Location = New System.Drawing.Point(4, 24)
        Me.BrowserTabPage.Name = "BrowserTabPage"
        Me.BrowserTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.BrowserTabPage.Size = New System.Drawing.Size(403, 247)
        Me.BrowserTabPage.TabIndex = 3
        Me.BrowserTabPage.Text = "Navigateur"
        Me.BrowserTabPage.UseVisualStyleBackColor = True
        '
        'BrowserDataGroupBox
        '
        Me.BrowserDataGroupBox.Controls.Add(Me.DeleteCookiesButton)
        Me.BrowserDataGroupBox.Controls.Add(Me.DeleteCache)
        Me.BrowserDataGroupBox.Controls.Add(Me.DeleteHistoryButton)
        Me.BrowserDataGroupBox.Location = New System.Drawing.Point(6, 31)
        Me.BrowserDataGroupBox.Name = "BrowserDataGroupBox"
        Me.BrowserDataGroupBox.Size = New System.Drawing.Size(391, 106)
        Me.BrowserDataGroupBox.TabIndex = 5
        Me.BrowserDataGroupBox.TabStop = False
        Me.BrowserDataGroupBox.Text = "Gestion des données de navigation"
        '
        'DeleteCookiesButton
        '
        Me.DeleteCookiesButton.Location = New System.Drawing.Point(9, 46)
        Me.DeleteCookiesButton.Name = "DeleteCookiesButton"
        Me.DeleteCookiesButton.Size = New System.Drawing.Size(206, 23)
        Me.DeleteCookiesButton.TabIndex = 3
        Me.DeleteCookiesButton.Text = "Supprimer les cookies"
        Me.DeleteCookiesButton.UseVisualStyleBackColor = True
        '
        'DeleteCache
        '
        Me.DeleteCache.Location = New System.Drawing.Point(9, 70)
        Me.DeleteCache.Name = "DeleteCache"
        Me.DeleteCache.Size = New System.Drawing.Size(206, 23)
        Me.DeleteCache.TabIndex = 4
        Me.DeleteCache.Text = "Supprimer le cache"
        Me.DeleteCache.UseVisualStyleBackColor = True
        '
        'DeleteHistoryButton
        '
        Me.DeleteHistoryButton.Location = New System.Drawing.Point(9, 22)
        Me.DeleteHistoryButton.Name = "DeleteHistoryButton"
        Me.DeleteHistoryButton.Size = New System.Drawing.Size(206, 23)
        Me.DeleteHistoryButton.TabIndex = 2
        Me.DeleteHistoryButton.Text = "Supprimer l'historique de la session"
        Me.DeleteHistoryButton.UseVisualStyleBackColor = True
        '
        'BuiltInBrowserCheckBox
        '
        Me.BuiltInBrowserCheckBox.AutoSize = True
        Me.BuiltInBrowserCheckBox.Location = New System.Drawing.Point(6, 6)
        Me.BuiltInBrowserCheckBox.Name = "BuiltInBrowserCheckBox"
        Me.BuiltInBrowserCheckBox.Size = New System.Drawing.Size(262, 19)
        Me.BuiltInBrowserCheckBox.TabIndex = 1
        Me.BuiltInBrowserCheckBox.Text = "Ouvrir les résultats dans le navigateur intégré"
        Me.BuiltInBrowserCheckBox.UseVisualStyleBackColor = True
        '
        'AdvancedSettingsTabPage
        '
        Me.AdvancedSettingsTabPage.Controls.Add(Me.ImportExportSettingsGroupBox)
        Me.AdvancedSettingsTabPage.Location = New System.Drawing.Point(4, 24)
        Me.AdvancedSettingsTabPage.Name = "AdvancedSettingsTabPage"
        Me.AdvancedSettingsTabPage.Size = New System.Drawing.Size(403, 247)
        Me.AdvancedSettingsTabPage.TabIndex = 2
        Me.AdvancedSettingsTabPage.Text = "Paramètres avancés"
        Me.AdvancedSettingsTabPage.UseVisualStyleBackColor = True
        '
        'RestoreDefaultColorLinkLabel
        '
        Me.RestoreDefaultColorLinkLabel.ActiveLinkColor = System.Drawing.SystemColors.HotTrack
        Me.RestoreDefaultColorLinkLabel.AutoSize = True
        Me.RestoreDefaultColorLinkLabel.LinkColor = System.Drawing.SystemColors.HotTrack
        Me.RestoreDefaultColorLinkLabel.Location = New System.Drawing.Point(9, 48)
        Me.RestoreDefaultColorLinkLabel.Name = "RestoreDefaultColorLinkLabel"
        Me.RestoreDefaultColorLinkLabel.Size = New System.Drawing.Size(168, 15)
        Me.RestoreDefaultColorLinkLabel.TabIndex = 5
        Me.RestoreDefaultColorLinkLabel.TabStop = True
        Me.RestoreDefaultColorLinkLabel.Text = "Restaurer la couleur par défaut"
        Me.RestoreDefaultColorLinkLabel.VisitedLinkColor = System.Drawing.SystemColors.HotTrack
        '
        'FormSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 310)
        Me.Controls.Add(Me.OKButton)
        Me.Controls.Add(Me.SettingsTabControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormSettings"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Paramètres de SmartNet Search Bar"
        Me.GeneralSettingsGroupBox.ResumeLayout(False)
        Me.GeneralSettingsGroupBox.PerformLayout()
        Me.SearchBarColorGroupBox.ResumeLayout(False)
        Me.SearchBarColorGroupBox.PerformLayout()
        Me.ImportExportSettingsGroupBox.ResumeLayout(False)
        Me.SearchEngineGroupBox.ResumeLayout(False)
        Me.SearchEngineGroupBox.PerformLayout()
        Me.SettingsTabControl.ResumeLayout(False)
        Me.MainTabPage.ResumeLayout(False)
        Me.UpdatesTabPage.ResumeLayout(False)
        Me.UpdatesManagementGroupBox.ResumeLayout(False)
        Me.UpdatesManagementGroupBox.PerformLayout()
        Me.AutomaticUpdatesGroupBox.ResumeLayout(False)
        Me.AutomaticUpdatesGroupBox.PerformLayout()
        Me.BrowserTabPage.ResumeLayout(False)
        Me.BrowserTabPage.PerformLayout()
        Me.BrowserDataGroupBox.ResumeLayout(False)
        Me.AdvancedSettingsTabPage.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AutoLaunchCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents GeneralSettingsGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents SearchBarColorGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents OKButton As System.Windows.Forms.Button
    Friend WithEvents ImportExportSettingsGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents ImportFromPreviousVersionButton As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents SearchEngineGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButtonBing As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonGoogle As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonDuckDuckGo As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonYahoo As System.Windows.Forms.RadioButton
    Friend WithEvents SettingsTabControl As System.Windows.Forms.TabControl
    Friend WithEvents MainTabPage As System.Windows.Forms.TabPage
    Friend WithEvents UpdatesTabPage As System.Windows.Forms.TabPage
    Friend WithEvents UpdatesManagementGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents CheckUpdatesNowButton As System.Windows.Forms.Button
    Friend WithEvents CurrentVersionLabel As System.Windows.Forms.Label
    Friend WithEvents AutomaticUpdatesGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents AutoUpdatesCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents AdvancedSettingsTabPage As System.Windows.Forms.TabPage
    Friend WithEvents ChangeBarColorButton As Button
    Friend WithEvents RadioButtonQwant As RadioButton
    Friend WithEvents BrowserTabPage As TabPage
    Friend WithEvents BuiltInBrowserCheckBox As CheckBox
    Friend WithEvents BrowserDataGroupBox As GroupBox
    Friend WithEvents DeleteCookiesButton As Button
    Friend WithEvents DeleteCache As Button
    Friend WithEvents DeleteHistoryButton As Button
    Friend WithEvents RestoreDefaultColorLinkLabel As LinkLabel
End Class
