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
        resources.ApplyResources(Me.ListBoxHistory, "ListBoxHistory")
        Me.ListBoxHistory.FormattingEnabled = True
        Me.ListBoxHistory.Name = "ListBoxHistory"
        Me.ListBoxHistory.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        '
        'DeleteEntryButton
        '
        resources.ApplyResources(Me.DeleteEntryButton, "DeleteEntryButton")
        Me.DeleteEntryButton.Name = "DeleteEntryButton"
        Me.DeleteEntryButton.UseVisualStyleBackColor = True
        '
        'SearchAgainButton
        '
        resources.ApplyResources(Me.SearchAgainButton, "SearchAgainButton")
        Me.SearchAgainButton.Name = "SearchAgainButton"
        Me.SearchAgainButton.UseVisualStyleBackColor = True
        '
        'SearchHistoryForm
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SearchAgainButton)
        Me.Controls.Add(Me.DeleteEntryButton)
        Me.Controls.Add(Me.ListBoxHistory)
        Me.Name = "SearchHistoryForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListBoxHistory As ListBox
    Friend WithEvents DeleteEntryButton As Button
    Friend WithEvents SearchAgainButton As Button
End Class
