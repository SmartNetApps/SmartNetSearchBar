<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormUpdater
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormUpdater))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonDownloadNow = New System.Windows.Forms.Button()
        Me.ButtonRemindMeLater = New System.Windows.Forms.Button()
        Me.RichTextBoxReleaseNotes = New System.Windows.Forms.RichTextBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'ButtonDownloadNow
        '
        resources.ApplyResources(Me.ButtonDownloadNow, "ButtonDownloadNow")
        Me.ButtonDownloadNow.Name = "ButtonDownloadNow"
        Me.ButtonDownloadNow.UseVisualStyleBackColor = True
        '
        'ButtonRemindMeLater
        '
        resources.ApplyResources(Me.ButtonRemindMeLater, "ButtonRemindMeLater")
        Me.ButtonRemindMeLater.Name = "ButtonRemindMeLater"
        Me.ButtonRemindMeLater.UseVisualStyleBackColor = True
        '
        'RichTextBoxReleaseNotes
        '
        Me.RichTextBoxReleaseNotes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBoxReleaseNotes.Cursor = System.Windows.Forms.Cursors.Arrow
        resources.ApplyResources(Me.RichTextBoxReleaseNotes, "RichTextBoxReleaseNotes")
        Me.RichTextBoxReleaseNotes.Name = "RichTextBoxReleaseNotes"
        Me.RichTextBoxReleaseNotes.ReadOnly = True
        '
        'ProgressBar1
        '
        resources.ApplyResources(Me.ProgressBar1, "ProgressBar1")
        Me.ProgressBar1.Name = "ProgressBar1"
        '
        'FormUpdater
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.RichTextBoxReleaseNotes)
        Me.Controls.Add(Me.ButtonRemindMeLater)
        Me.Controls.Add(Me.ButtonDownloadNow)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormUpdater"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonDownloadNow As System.Windows.Forms.Button
    Friend WithEvents ButtonRemindMeLater As System.Windows.Forms.Button
    Friend WithEvents RichTextBoxReleaseNotes As System.Windows.Forms.RichTextBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
End Class
