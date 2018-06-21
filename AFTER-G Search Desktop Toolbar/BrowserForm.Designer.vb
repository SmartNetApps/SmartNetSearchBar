<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BrowserForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BrowserForm))
        Me.GeckoWebBrowser1 = New Gecko.GeckoWebBrowser()
        Me.URLTextBox = New System.Windows.Forms.TextBox()
        Me.FaviconPictureBox = New System.Windows.Forms.PictureBox()
        Me.NextButton = New System.Windows.Forms.Button()
        Me.PreviousButton = New System.Windows.Forms.Button()
        CType(Me.FaviconPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GeckoWebBrowser1
        '
        resources.ApplyResources(Me.GeckoWebBrowser1, "GeckoWebBrowser1")
        Me.GeckoWebBrowser1.Name = "GeckoWebBrowser1"
        Me.GeckoWebBrowser1.UseHttpActivityObserver = False
        '
        'URLTextBox
        '
        resources.ApplyResources(Me.URLTextBox, "URLTextBox")
        Me.URLTextBox.Name = "URLTextBox"
        '
        'FaviconPictureBox
        '
        resources.ApplyResources(Me.FaviconPictureBox, "FaviconPictureBox")
        Me.FaviconPictureBox.Name = "FaviconPictureBox"
        Me.FaviconPictureBox.TabStop = False
        '
        'NextButton
        '
        resources.ApplyResources(Me.NextButton, "NextButton")
        Me.NextButton.FlatAppearance.BorderSize = 0
        Me.NextButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray
        Me.NextButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.NextButton.Image = Global.SmartNet_Search_Bar.My.Resources.Resources.NextBlack
        Me.NextButton.Name = "NextButton"
        Me.NextButton.UseVisualStyleBackColor = True
        '
        'PreviousButton
        '
        resources.ApplyResources(Me.PreviousButton, "PreviousButton")
        Me.PreviousButton.FlatAppearance.BorderSize = 0
        Me.PreviousButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray
        Me.PreviousButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.PreviousButton.Image = Global.SmartNet_Search_Bar.My.Resources.Resources.PreviousBlack
        Me.PreviousButton.Name = "PreviousButton"
        Me.PreviousButton.UseVisualStyleBackColor = True
        '
        'BrowserForm
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PreviousButton)
        Me.Controls.Add(Me.NextButton)
        Me.Controls.Add(Me.FaviconPictureBox)
        Me.Controls.Add(Me.URLTextBox)
        Me.Controls.Add(Me.GeckoWebBrowser1)
        Me.Name = "BrowserForm"
        CType(Me.FaviconPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GeckoWebBrowser1 As Gecko.GeckoWebBrowser
    Friend WithEvents URLTextBox As TextBox
    Friend WithEvents FaviconPictureBox As PictureBox
    Friend WithEvents NextButton As Button
    Friend WithEvents PreviousButton As Button
End Class
