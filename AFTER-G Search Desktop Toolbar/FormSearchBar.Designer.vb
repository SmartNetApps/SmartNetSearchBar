<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormSearchBar
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSearchBar))
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AffichermasquerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FermerLaBarreDoutilsAFTERGSearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.HistoriqueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ParamètresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupportSurAFTERGAppsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CentreDaideEnLigneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContacterLéquipeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.AProposDeAFTERGDesktopToolbarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnvoyerVosCommentairesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.VérifierLesMisesÀJourToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TéléchargerLaVersionXXXXToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.UpdateNotifyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBoxSearchEngineLogo = New System.Windows.Forms.PictureBox()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.ContextMenuStrip2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxSearchEngineLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        resources.ApplyResources(Me.NotifyIcon1, "NotifyIcon1")
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AffichermasquerToolStripMenuItem, Me.FermerLaBarreDoutilsAFTERGSearchToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        resources.ApplyResources(Me.ContextMenuStrip1, "ContextMenuStrip1")
        '
        'AffichermasquerToolStripMenuItem
        '
        Me.AffichermasquerToolStripMenuItem.Name = "AffichermasquerToolStripMenuItem"
        resources.ApplyResources(Me.AffichermasquerToolStripMenuItem, "AffichermasquerToolStripMenuItem")
        '
        'FermerLaBarreDoutilsAFTERGSearchToolStripMenuItem
        '
        Me.FermerLaBarreDoutilsAFTERGSearchToolStripMenuItem.Image = Global.SmartNet_Search_Bar.My.Resources.Resources.Close
        Me.FermerLaBarreDoutilsAFTERGSearchToolStripMenuItem.Name = "FermerLaBarreDoutilsAFTERGSearchToolStripMenuItem"
        resources.ApplyResources(Me.FermerLaBarreDoutilsAFTERGSearchToolStripMenuItem, "FermerLaBarreDoutilsAFTERGSearchToolStripMenuItem")
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HistoriqueToolStripMenuItem, Me.ParamètresToolStripMenuItem, Me.SupportSurAFTERGAppsToolStripMenuItem, Me.ToolStripSeparator1, Me.VérifierLesMisesÀJourToolStripMenuItem, Me.QuitterToolStripMenuItem})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        resources.ApplyResources(Me.ContextMenuStrip2, "ContextMenuStrip2")
        '
        'HistoriqueToolStripMenuItem
        '
        Me.HistoriqueToolStripMenuItem.Image = Global.SmartNet_Search_Bar.My.Resources.Resources.History
        Me.HistoriqueToolStripMenuItem.Name = "HistoriqueToolStripMenuItem"
        resources.ApplyResources(Me.HistoriqueToolStripMenuItem, "HistoriqueToolStripMenuItem")
        '
        'ParamètresToolStripMenuItem
        '
        Me.ParamètresToolStripMenuItem.Image = Global.SmartNet_Search_Bar.My.Resources.Resources.Settings
        Me.ParamètresToolStripMenuItem.Name = "ParamètresToolStripMenuItem"
        resources.ApplyResources(Me.ParamètresToolStripMenuItem, "ParamètresToolStripMenuItem")
        '
        'SupportSurAFTERGAppsToolStripMenuItem
        '
        Me.SupportSurAFTERGAppsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CentreDaideEnLigneToolStripMenuItem, Me.ContacterLéquipeToolStripMenuItem, Me.ToolStripSeparator2, Me.AProposDeAFTERGDesktopToolbarToolStripMenuItem, Me.EnvoyerVosCommentairesToolStripMenuItem})
        Me.SupportSurAFTERGAppsToolStripMenuItem.Image = Global.SmartNet_Search_Bar.My.Resources.Resources.Help
        Me.SupportSurAFTERGAppsToolStripMenuItem.Name = "SupportSurAFTERGAppsToolStripMenuItem"
        resources.ApplyResources(Me.SupportSurAFTERGAppsToolStripMenuItem, "SupportSurAFTERGAppsToolStripMenuItem")
        '
        'CentreDaideEnLigneToolStripMenuItem
        '
        Me.CentreDaideEnLigneToolStripMenuItem.Name = "CentreDaideEnLigneToolStripMenuItem"
        resources.ApplyResources(Me.CentreDaideEnLigneToolStripMenuItem, "CentreDaideEnLigneToolStripMenuItem")
        '
        'ContacterLéquipeToolStripMenuItem
        '
        Me.ContacterLéquipeToolStripMenuItem.Name = "ContacterLéquipeToolStripMenuItem"
        resources.ApplyResources(Me.ContacterLéquipeToolStripMenuItem, "ContacterLéquipeToolStripMenuItem")
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        resources.ApplyResources(Me.ToolStripSeparator2, "ToolStripSeparator2")
        '
        'AProposDeAFTERGDesktopToolbarToolStripMenuItem
        '
        Me.AProposDeAFTERGDesktopToolbarToolStripMenuItem.Name = "AProposDeAFTERGDesktopToolbarToolStripMenuItem"
        resources.ApplyResources(Me.AProposDeAFTERGDesktopToolbarToolStripMenuItem, "AProposDeAFTERGDesktopToolbarToolStripMenuItem")
        '
        'EnvoyerVosCommentairesToolStripMenuItem
        '
        Me.EnvoyerVosCommentairesToolStripMenuItem.Image = Global.SmartNet_Search_Bar.My.Resources.Resources.SendFeedback
        Me.EnvoyerVosCommentairesToolStripMenuItem.Name = "EnvoyerVosCommentairesToolStripMenuItem"
        resources.ApplyResources(Me.EnvoyerVosCommentairesToolStripMenuItem, "EnvoyerVosCommentairesToolStripMenuItem")
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        resources.ApplyResources(Me.ToolStripSeparator1, "ToolStripSeparator1")
        '
        'VérifierLesMisesÀJourToolStripMenuItem
        '
        Me.VérifierLesMisesÀJourToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TéléchargerLaVersionXXXXToolStripMenuItem})
        resources.ApplyResources(Me.VérifierLesMisesÀJourToolStripMenuItem, "VérifierLesMisesÀJourToolStripMenuItem")
        Me.VérifierLesMisesÀJourToolStripMenuItem.Name = "VérifierLesMisesÀJourToolStripMenuItem"
        '
        'TéléchargerLaVersionXXXXToolStripMenuItem
        '
        resources.ApplyResources(Me.TéléchargerLaVersionXXXXToolStripMenuItem, "TéléchargerLaVersionXXXXToolStripMenuItem")
        Me.TéléchargerLaVersionXXXXToolStripMenuItem.Name = "TéléchargerLaVersionXXXXToolStripMenuItem"
        '
        'QuitterToolStripMenuItem
        '
        Me.QuitterToolStripMenuItem.Image = Global.SmartNet_Search_Bar.My.Resources.Resources.Close
        Me.QuitterToolStripMenuItem.Name = "QuitterToolStripMenuItem"
        resources.ApplyResources(Me.QuitterToolStripMenuItem, "QuitterToolStripMenuItem")
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Black
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        resources.ApplyResources(Me.TextBox1, "TextBox1")
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Name = "TextBox1"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.PictureBox2, "PictureBox2")
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        resources.ApplyResources(Me.PictureBox3, "PictureBox3")
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.ContextMenuStrip = Me.ContextMenuStrip2
        Me.PictureBox4.ErrorImage = Global.SmartNet_Search_Bar.My.Resources.Resources.MenuWhite
        Me.PictureBox4.Image = Global.SmartNet_Search_Bar.My.Resources.Resources.MenuWhite
        Me.PictureBox4.InitialImage = Global.SmartNet_Search_Bar.My.Resources.Resources.MenuWhite
        resources.ApplyResources(Me.PictureBox4, "PictureBox4")
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.TabStop = False
        '
        'UpdateNotifyIcon
        '
        Me.UpdateNotifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        resources.ApplyResources(Me.UpdateNotifyIcon, "UpdateNotifyIcon")
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = False
        '
        'PictureBoxSearchEngineLogo
        '
        Me.PictureBoxSearchEngineLogo.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxSearchEngineLogo.ContextMenuStrip = Me.ContextMenuStrip2
        Me.PictureBoxSearchEngineLogo.ErrorImage = Global.SmartNet_Search_Bar.My.Resources.Resources.google
        Me.PictureBoxSearchEngineLogo.Image = Global.SmartNet_Search_Bar.My.Resources.Resources.google
        Me.PictureBoxSearchEngineLogo.InitialImage = Global.SmartNet_Search_Bar.My.Resources.Resources.google
        resources.ApplyResources(Me.PictureBoxSearchEngineLogo, "PictureBoxSearchEngineLogo")
        Me.PictureBoxSearchEngineLogo.Name = "PictureBoxSearchEngineLogo"
        Me.PictureBoxSearchEngineLogo.TabStop = False
        '
        'FormSearchBar
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PictureBoxSearchEngineLogo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "FormSearchBar"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ContextMenuStrip2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxSearchEngineLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents FermerLaBarreDoutilsAFTERGSearchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AffichermasquerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents QuitterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateNotifyIcon As System.Windows.Forms.NotifyIcon
    Friend WithEvents ParamètresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SupportSurAFTERGAppsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContacterLéquipeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents AProposDeAFTERGDesktopToolbarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents VérifierLesMisesÀJourToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TéléchargerLaVersionXXXXToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CentreDaideEnLigneToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnvoyerVosCommentairesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBoxSearchEngineLogo As PictureBox
    Friend WithEvents HistoriqueToolStripMenuItem As ToolStripMenuItem
End Class
