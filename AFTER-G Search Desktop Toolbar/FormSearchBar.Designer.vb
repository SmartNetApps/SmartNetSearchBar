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
        Me.NotifyIcon1.BalloonTipText = "Double-cliquez sur l'icône SmartNet Search Bar pour afficher la barre d'outils."
        Me.NotifyIcon1.BalloonTipTitle = "La barre d'outils est opérationnelle."
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "SmartNet Search Bar"
        Me.NotifyIcon1.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AffichermasquerToolStripMenuItem, Me.FermerLaBarreDoutilsAFTERGSearchToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(252, 70)
        '
        'AffichermasquerToolStripMenuItem
        '
        Me.AffichermasquerToolStripMenuItem.Name = "AffichermasquerToolStripMenuItem"
        Me.AffichermasquerToolStripMenuItem.Size = New System.Drawing.Size(251, 22)
        Me.AffichermasquerToolStripMenuItem.Text = "Afficher/masquer la barre d'outils"
        '
        'FermerLaBarreDoutilsAFTERGSearchToolStripMenuItem
        '
        Me.FermerLaBarreDoutilsAFTERGSearchToolStripMenuItem.Image = Global.SmartNet_Search_Bar.My.Resources.Resources.Close
        Me.FermerLaBarreDoutilsAFTERGSearchToolStripMenuItem.Name = "FermerLaBarreDoutilsAFTERGSearchToolStripMenuItem"
        Me.FermerLaBarreDoutilsAFTERGSearchToolStripMenuItem.Size = New System.Drawing.Size(251, 22)
        Me.FermerLaBarreDoutilsAFTERGSearchToolStripMenuItem.Text = "Quitter"
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ParamètresToolStripMenuItem, Me.SupportSurAFTERGAppsToolStripMenuItem, Me.ToolStripSeparator1, Me.VérifierLesMisesÀJourToolStripMenuItem, Me.QuitterToolStripMenuItem})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(219, 98)
        '
        'ParamètresToolStripMenuItem
        '
        Me.ParamètresToolStripMenuItem.Image = Global.SmartNet_Search_Bar.My.Resources.Resources.Settings
        Me.ParamètresToolStripMenuItem.Name = "ParamètresToolStripMenuItem"
        Me.ParamètresToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.ParamètresToolStripMenuItem.Text = "Paramètres..."
        '
        'SupportSurAFTERGAppsToolStripMenuItem
        '
        Me.SupportSurAFTERGAppsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CentreDaideEnLigneToolStripMenuItem, Me.ContacterLéquipeToolStripMenuItem, Me.ToolStripSeparator2, Me.AProposDeAFTERGDesktopToolbarToolStripMenuItem, Me.EnvoyerVosCommentairesToolStripMenuItem})
        Me.SupportSurAFTERGAppsToolStripMenuItem.Image = Global.SmartNet_Search_Bar.My.Resources.Resources.Help
        Me.SupportSurAFTERGAppsToolStripMenuItem.Name = "SupportSurAFTERGAppsToolStripMenuItem"
        Me.SupportSurAFTERGAppsToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.SupportSurAFTERGAppsToolStripMenuItem.Text = "Support sur SmartNet Apps"
        '
        'CentreDaideEnLigneToolStripMenuItem
        '
        Me.CentreDaideEnLigneToolStripMenuItem.Name = "CentreDaideEnLigneToolStripMenuItem"
        Me.CentreDaideEnLigneToolStripMenuItem.Size = New System.Drawing.Size(258, 22)
        Me.CentreDaideEnLigneToolStripMenuItem.Text = "Aide en ligne..."
        '
        'ContacterLéquipeToolStripMenuItem
        '
        Me.ContacterLéquipeToolStripMenuItem.Name = "ContacterLéquipeToolStripMenuItem"
        Me.ContacterLéquipeToolStripMenuItem.Size = New System.Drawing.Size(258, 22)
        Me.ContacterLéquipeToolStripMenuItem.Text = "Contacter l'équipe"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(255, 6)
        '
        'AProposDeAFTERGDesktopToolbarToolStripMenuItem
        '
        Me.AProposDeAFTERGDesktopToolbarToolStripMenuItem.Name = "AProposDeAFTERGDesktopToolbarToolStripMenuItem"
        Me.AProposDeAFTERGDesktopToolbarToolStripMenuItem.Size = New System.Drawing.Size(258, 22)
        Me.AProposDeAFTERGDesktopToolbarToolStripMenuItem.Text = "À propos de SmartNet Search Bar..."
        '
        'EnvoyerVosCommentairesToolStripMenuItem
        '
        Me.EnvoyerVosCommentairesToolStripMenuItem.Image = Global.SmartNet_Search_Bar.My.Resources.Resources.SendFeedback
        Me.EnvoyerVosCommentairesToolStripMenuItem.Name = "EnvoyerVosCommentairesToolStripMenuItem"
        Me.EnvoyerVosCommentairesToolStripMenuItem.Size = New System.Drawing.Size(258, 22)
        Me.EnvoyerVosCommentairesToolStripMenuItem.Text = "Envoyer vos commentaires..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(215, 6)
        '
        'VérifierLesMisesÀJourToolStripMenuItem
        '
        Me.VérifierLesMisesÀJourToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TéléchargerLaVersionXXXXToolStripMenuItem})
        Me.VérifierLesMisesÀJourToolStripMenuItem.Image = CType(resources.GetObject("VérifierLesMisesÀJourToolStripMenuItem.Image"), System.Drawing.Image)
        Me.VérifierLesMisesÀJourToolStripMenuItem.Name = "VérifierLesMisesÀJourToolStripMenuItem"
        Me.VérifierLesMisesÀJourToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.VérifierLesMisesÀJourToolStripMenuItem.Text = "Mise à jour disponible"
        '
        'TéléchargerLaVersionXXXXToolStripMenuItem
        '
        Me.TéléchargerLaVersionXXXXToolStripMenuItem.Image = CType(resources.GetObject("TéléchargerLaVersionXXXXToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TéléchargerLaVersionXXXXToolStripMenuItem.Name = "TéléchargerLaVersionXXXXToolStripMenuItem"
        Me.TéléchargerLaVersionXXXXToolStripMenuItem.Size = New System.Drawing.Size(228, 22)
        Me.TéléchargerLaVersionXXXXToolStripMenuItem.Text = "Télécharger la version X.X.X.X"
        '
        'QuitterToolStripMenuItem
        '
        Me.QuitterToolStripMenuItem.Image = Global.SmartNet_Search_Bar.My.Resources.Resources.Close
        Me.QuitterToolStripMenuItem.Name = "QuitterToolStripMenuItem"
        Me.QuitterToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.QuitterToolStripMenuItem.Text = "Quitter"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Black
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(39, 5)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(261, 25)
        Me.TextBox1.TabIndex = 2
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.ErrorImage = CType(resources.GetObject("PictureBox2.ErrorImage"), System.Drawing.Image)
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.InitialImage = CType(resources.GetObject("PictureBox2.InitialImage"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(301, 6)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(23, 23)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.ErrorImage = CType(resources.GetObject("PictureBox3.ErrorImage"), System.Drawing.Image)
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.InitialImage = CType(resources.GetObject("PictureBox3.InitialImage"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(334, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 4
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.ContextMenuStrip = Me.ContextMenuStrip2
        Me.PictureBox4.ErrorImage = Global.SmartNet_Search_Bar.My.Resources.Resources.MenuWhite
        Me.PictureBox4.Image = Global.SmartNet_Search_Bar.My.Resources.Resources.MenuWhite
        Me.PictureBox4.InitialImage = Global.SmartNet_Search_Bar.My.Resources.Resources.MenuWhite
        Me.PictureBox4.Location = New System.Drawing.Point(334, 16)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox4.TabIndex = 5
        Me.PictureBox4.TabStop = False
        '
        'UpdateNotifyIcon
        '
        Me.UpdateNotifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.UpdateNotifyIcon.BalloonTipText = "Une mise à jour est disponible pour SmartNet Search Bar"
        Me.UpdateNotifyIcon.BalloonTipTitle = "SmartNet Apps Updater"
        Me.UpdateNotifyIcon.Icon = CType(resources.GetObject("UpdateNotifyIcon.Icon"), System.Drawing.Icon)
        Me.UpdateNotifyIcon.Text = "Mise à jour disponible"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(39, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(285, 1)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'PictureBoxSearchEngineLogo
        '
        Me.PictureBoxSearchEngineLogo.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxSearchEngineLogo.ContextMenuStrip = Me.ContextMenuStrip2
        Me.PictureBoxSearchEngineLogo.ErrorImage = Global.SmartNet_Search_Bar.My.Resources.Resources.google
        Me.PictureBoxSearchEngineLogo.Image = Global.SmartNet_Search_Bar.My.Resources.Resources.google
        Me.PictureBoxSearchEngineLogo.InitialImage = Global.SmartNet_Search_Bar.My.Resources.Resources.google
        Me.PictureBoxSearchEngineLogo.Location = New System.Drawing.Point(3, 2)
        Me.PictureBoxSearchEngineLogo.Name = "PictureBoxSearchEngineLogo"
        Me.PictureBoxSearchEngineLogo.Size = New System.Drawing.Size(32, 32)
        Me.PictureBoxSearchEngineLogo.TabIndex = 7
        Me.PictureBoxSearchEngineLogo.TabStop = False
        '
        'FormSearchBar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(350, 36)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PictureBoxSearchEngineLogo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FormSearchBar"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Text = "SmartNet Search Bar"
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
End Class
