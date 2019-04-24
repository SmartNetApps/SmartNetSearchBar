<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchHistoryForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SearchHistoryForm))
        Me.ListBoxHistory = New System.Windows.Forms.ListBox()
        Me.DeleteEntryButton = New System.Windows.Forms.Button()
        Me.SearchAgainButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListBoxHistory
        '
        Me.ListBoxHistory.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListBoxHistory.FormattingEnabled = True
        Me.ListBoxHistory.ItemHeight = 15
        Me.ListBoxHistory.Location = New System.Drawing.Point(0, 0)
        Me.ListBoxHistory.Name = "ListBoxHistory"
        Me.ListBoxHistory.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.ListBoxHistory.Size = New System.Drawing.Size(736, 349)
        Me.ListBoxHistory.TabIndex = 0
        '
        'DeleteEntryButton
        '
        Me.DeleteEntryButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DeleteEntryButton.Enabled = False
        Me.DeleteEntryButton.Location = New System.Drawing.Point(644, 362)
        Me.DeleteEntryButton.Name = "DeleteEntryButton"
        Me.DeleteEntryButton.Size = New System.Drawing.Size(80, 27)
        Me.DeleteEntryButton.TabIndex = 1
        Me.DeleteEntryButton.Text = "Supprimer"
        Me.DeleteEntryButton.UseVisualStyleBackColor = True
        '
        'SearchAgainButton
        '
        Me.SearchAgainButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SearchAgainButton.Enabled = False
        Me.SearchAgainButton.Location = New System.Drawing.Point(499, 362)
        Me.SearchAgainButton.Name = "SearchAgainButton"
        Me.SearchAgainButton.Size = New System.Drawing.Size(139, 27)
        Me.SearchAgainButton.TabIndex = 2
        Me.SearchAgainButton.Text = "Chercher à nouveau"
        Me.SearchAgainButton.UseVisualStyleBackColor = True
        '
        'SearchHistoryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(736, 401)
        Me.Controls.Add(Me.SearchAgainButton)
        Me.Controls.Add(Me.DeleteEntryButton)
        Me.Controls.Add(Me.ListBoxHistory)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(500, 300)
        Me.Name = "SearchHistoryForm"
        Me.Text = "Historique de recherche - SmartNet Search Bar"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListBoxHistory As ListBox
    Friend WithEvents DeleteEntryButton As Button
    Friend WithEvents SearchAgainButton As Button
End Class
