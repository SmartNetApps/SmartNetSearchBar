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
        Me.RestoreDefaultColorLinkLabel = New System.Windows.Forms.LinkLabel()
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
        Me.BuiltInBrowserCheckBox = New System.Windows.Forms.CheckBox()
        Me.AdvancedSettingsTabPage = New System.Windows.Forms.TabPage()
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
        resources.ApplyResources(Me.AutoLaunchCheckBox, "AutoLaunchCheckBox")
        Me.AutoLaunchCheckBox.Name = "AutoLaunchCheckBox"
        Me.AutoLaunchCheckBox.UseVisualStyleBackColor = True
        '
        'GeneralSettingsGroupBox
        '
        resources.ApplyResources(Me.GeneralSettingsGroupBox, "GeneralSettingsGroupBox")
        Me.GeneralSettingsGroupBox.Controls.Add(Me.AutoLaunchCheckBox)
        Me.GeneralSettingsGroupBox.Name = "GeneralSettingsGroupBox"
        Me.GeneralSettingsGroupBox.TabStop = False
        '
        'SearchBarColorGroupBox
        '
        resources.ApplyResources(Me.SearchBarColorGroupBox, "SearchBarColorGroupBox")
        Me.SearchBarColorGroupBox.Controls.Add(Me.RestoreDefaultColorLinkLabel)
        Me.SearchBarColorGroupBox.Controls.Add(Me.ChangeBarColorButton)
        Me.SearchBarColorGroupBox.Name = "SearchBarColorGroupBox"
        Me.SearchBarColorGroupBox.TabStop = False
        '
        'RestoreDefaultColorLinkLabel
        '
        resources.ApplyResources(Me.RestoreDefaultColorLinkLabel, "RestoreDefaultColorLinkLabel")
        Me.RestoreDefaultColorLinkLabel.ActiveLinkColor = System.Drawing.SystemColors.HotTrack
        Me.RestoreDefaultColorLinkLabel.LinkColor = System.Drawing.SystemColors.HotTrack
        Me.RestoreDefaultColorLinkLabel.Name = "RestoreDefaultColorLinkLabel"
        Me.RestoreDefaultColorLinkLabel.TabStop = True
        Me.RestoreDefaultColorLinkLabel.VisitedLinkColor = System.Drawing.SystemColors.HotTrack
        '
        'ChangeBarColorButton
        '
        resources.ApplyResources(Me.ChangeBarColorButton, "ChangeBarColorButton")
        Me.ChangeBarColorButton.Name = "ChangeBarColorButton"
        Me.ChangeBarColorButton.UseVisualStyleBackColor = True
        '
        'OKButton
        '
        resources.ApplyResources(Me.OKButton, "OKButton")
        Me.OKButton.Name = "OKButton"
        Me.OKButton.UseVisualStyleBackColor = True
        '
        'ImportExportSettingsGroupBox
        '
        resources.ApplyResources(Me.ImportExportSettingsGroupBox, "ImportExportSettingsGroupBox")
        Me.ImportExportSettingsGroupBox.Controls.Add(Me.ImportFromPreviousVersionButton)
        Me.ImportExportSettingsGroupBox.Name = "ImportExportSettingsGroupBox"
        Me.ImportExportSettingsGroupBox.TabStop = False
        '
        'ImportFromPreviousVersionButton
        '
        resources.ApplyResources(Me.ImportFromPreviousVersionButton, "ImportFromPreviousVersionButton")
        Me.ImportFromPreviousVersionButton.Name = "ImportFromPreviousVersionButton"
        Me.ImportFromPreviousVersionButton.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        resources.ApplyResources(Me.OpenFileDialog1, "OpenFileDialog1")
        '
        'FolderBrowserDialog1
        '
        resources.ApplyResources(Me.FolderBrowserDialog1, "FolderBrowserDialog1")
        '
        'SearchEngineGroupBox
        '
        resources.ApplyResources(Me.SearchEngineGroupBox, "SearchEngineGroupBox")
        Me.SearchEngineGroupBox.Controls.Add(Me.RadioButtonQwant)
        Me.SearchEngineGroupBox.Controls.Add(Me.RadioButtonDuckDuckGo)
        Me.SearchEngineGroupBox.Controls.Add(Me.RadioButtonYahoo)
        Me.SearchEngineGroupBox.Controls.Add(Me.RadioButtonBing)
        Me.SearchEngineGroupBox.Controls.Add(Me.RadioButtonGoogle)
        Me.SearchEngineGroupBox.Name = "SearchEngineGroupBox"
        Me.SearchEngineGroupBox.TabStop = False
        '
        'RadioButtonQwant
        '
        resources.ApplyResources(Me.RadioButtonQwant, "RadioButtonQwant")
        Me.RadioButtonQwant.Name = "RadioButtonQwant"
        Me.RadioButtonQwant.TabStop = True
        Me.RadioButtonQwant.UseVisualStyleBackColor = True
        '
        'RadioButtonDuckDuckGo
        '
        resources.ApplyResources(Me.RadioButtonDuckDuckGo, "RadioButtonDuckDuckGo")
        Me.RadioButtonDuckDuckGo.Name = "RadioButtonDuckDuckGo"
        Me.RadioButtonDuckDuckGo.TabStop = True
        Me.RadioButtonDuckDuckGo.UseVisualStyleBackColor = True
        '
        'RadioButtonYahoo
        '
        resources.ApplyResources(Me.RadioButtonYahoo, "RadioButtonYahoo")
        Me.RadioButtonYahoo.Name = "RadioButtonYahoo"
        Me.RadioButtonYahoo.TabStop = True
        Me.RadioButtonYahoo.UseVisualStyleBackColor = True
        '
        'RadioButtonBing
        '
        resources.ApplyResources(Me.RadioButtonBing, "RadioButtonBing")
        Me.RadioButtonBing.Name = "RadioButtonBing"
        Me.RadioButtonBing.TabStop = True
        Me.RadioButtonBing.UseVisualStyleBackColor = True
        '
        'RadioButtonGoogle
        '
        resources.ApplyResources(Me.RadioButtonGoogle, "RadioButtonGoogle")
        Me.RadioButtonGoogle.Name = "RadioButtonGoogle"
        Me.RadioButtonGoogle.TabStop = True
        Me.RadioButtonGoogle.UseVisualStyleBackColor = True
        '
        'SettingsTabControl
        '
        resources.ApplyResources(Me.SettingsTabControl, "SettingsTabControl")
        Me.SettingsTabControl.Controls.Add(Me.MainTabPage)
        Me.SettingsTabControl.Controls.Add(Me.UpdatesTabPage)
        Me.SettingsTabControl.Controls.Add(Me.BrowserTabPage)
        Me.SettingsTabControl.Controls.Add(Me.AdvancedSettingsTabPage)
        Me.SettingsTabControl.Name = "SettingsTabControl"
        Me.SettingsTabControl.SelectedIndex = 0
        '
        'MainTabPage
        '
        resources.ApplyResources(Me.MainTabPage, "MainTabPage")
        Me.MainTabPage.Controls.Add(Me.SearchEngineGroupBox)
        Me.MainTabPage.Controls.Add(Me.GeneralSettingsGroupBox)
        Me.MainTabPage.Controls.Add(Me.SearchBarColorGroupBox)
        Me.MainTabPage.Name = "MainTabPage"
        Me.MainTabPage.UseVisualStyleBackColor = True
        '
        'UpdatesTabPage
        '
        resources.ApplyResources(Me.UpdatesTabPage, "UpdatesTabPage")
        Me.UpdatesTabPage.Controls.Add(Me.UpdatesManagementGroupBox)
        Me.UpdatesTabPage.Controls.Add(Me.AutomaticUpdatesGroupBox)
        Me.UpdatesTabPage.Name = "UpdatesTabPage"
        Me.UpdatesTabPage.UseVisualStyleBackColor = True
        '
        'UpdatesManagementGroupBox
        '
        resources.ApplyResources(Me.UpdatesManagementGroupBox, "UpdatesManagementGroupBox")
        Me.UpdatesManagementGroupBox.Controls.Add(Me.CheckUpdatesNowButton)
        Me.UpdatesManagementGroupBox.Controls.Add(Me.CurrentVersionLabel)
        Me.UpdatesManagementGroupBox.Name = "UpdatesManagementGroupBox"
        Me.UpdatesManagementGroupBox.TabStop = False
        '
        'CheckUpdatesNowButton
        '
        resources.ApplyResources(Me.CheckUpdatesNowButton, "CheckUpdatesNowButton")
        Me.CheckUpdatesNowButton.Name = "CheckUpdatesNowButton"
        Me.CheckUpdatesNowButton.UseVisualStyleBackColor = True
        '
        'CurrentVersionLabel
        '
        resources.ApplyResources(Me.CurrentVersionLabel, "CurrentVersionLabel")
        Me.CurrentVersionLabel.Name = "CurrentVersionLabel"
        '
        'AutomaticUpdatesGroupBox
        '
        resources.ApplyResources(Me.AutomaticUpdatesGroupBox, "AutomaticUpdatesGroupBox")
        Me.AutomaticUpdatesGroupBox.Controls.Add(Me.AutoUpdatesCheckBox)
        Me.AutomaticUpdatesGroupBox.Name = "AutomaticUpdatesGroupBox"
        Me.AutomaticUpdatesGroupBox.TabStop = False
        '
        'AutoUpdatesCheckBox
        '
        resources.ApplyResources(Me.AutoUpdatesCheckBox, "AutoUpdatesCheckBox")
        Me.AutoUpdatesCheckBox.Name = "AutoUpdatesCheckBox"
        Me.AutoUpdatesCheckBox.UseVisualStyleBackColor = True
        '
        'BrowserTabPage
        '
        resources.ApplyResources(Me.BrowserTabPage, "BrowserTabPage")
        Me.BrowserTabPage.Controls.Add(Me.BrowserDataGroupBox)
        Me.BrowserTabPage.Controls.Add(Me.BuiltInBrowserCheckBox)
        Me.BrowserTabPage.Name = "BrowserTabPage"
        Me.BrowserTabPage.UseVisualStyleBackColor = True
        '
        'BrowserDataGroupBox
        '
        resources.ApplyResources(Me.BrowserDataGroupBox, "BrowserDataGroupBox")
        Me.BrowserDataGroupBox.Controls.Add(Me.DeleteCookiesButton)
        Me.BrowserDataGroupBox.Controls.Add(Me.DeleteCache)
        Me.BrowserDataGroupBox.Name = "BrowserDataGroupBox"
        Me.BrowserDataGroupBox.TabStop = False
        '
        'DeleteCookiesButton
        '
        resources.ApplyResources(Me.DeleteCookiesButton, "DeleteCookiesButton")
        Me.DeleteCookiesButton.Name = "DeleteCookiesButton"
        Me.DeleteCookiesButton.UseVisualStyleBackColor = True
        '
        'DeleteCache
        '
        resources.ApplyResources(Me.DeleteCache, "DeleteCache")
        Me.DeleteCache.Name = "DeleteCache"
        Me.DeleteCache.UseVisualStyleBackColor = True
        '
        'BuiltInBrowserCheckBox
        '
        resources.ApplyResources(Me.BuiltInBrowserCheckBox, "BuiltInBrowserCheckBox")
        Me.BuiltInBrowserCheckBox.Name = "BuiltInBrowserCheckBox"
        Me.BuiltInBrowserCheckBox.UseVisualStyleBackColor = True
        '
        'AdvancedSettingsTabPage
        '
        resources.ApplyResources(Me.AdvancedSettingsTabPage, "AdvancedSettingsTabPage")
        Me.AdvancedSettingsTabPage.Controls.Add(Me.ImportExportSettingsGroupBox)
        Me.AdvancedSettingsTabPage.Name = "AdvancedSettingsTabPage"
        Me.AdvancedSettingsTabPage.UseVisualStyleBackColor = True
        '
        'FormSettings
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.OKButton)
        Me.Controls.Add(Me.SettingsTabControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormSettings"
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
    Friend WithEvents RestoreDefaultColorLinkLabel As LinkLabel
End Class
