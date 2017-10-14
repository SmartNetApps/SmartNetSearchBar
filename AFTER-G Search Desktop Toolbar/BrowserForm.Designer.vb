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
        Me.PreviousButton = New System.Windows.Forms.PictureBox()
        Me.NextButton = New System.Windows.Forms.PictureBox()
        Me.URLTextBox = New System.Windows.Forms.TextBox()
        Me.FaviconPictureBox = New System.Windows.Forms.PictureBox()
        Me.NextButtonDisabled = New System.Windows.Forms.PictureBox()
        Me.PreviousButtonDisabled = New System.Windows.Forms.PictureBox()
        CType(Me.PreviousButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NextButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FaviconPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NextButtonDisabled, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PreviousButtonDisabled, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GeckoWebBrowser1
        '
        Me.GeckoWebBrowser1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GeckoWebBrowser1.FrameEventsPropagateToMainWindow = False
        Me.GeckoWebBrowser1.Location = New System.Drawing.Point(0, 25)
        Me.GeckoWebBrowser1.Name = "GeckoWebBrowser1"
        Me.GeckoWebBrowser1.Size = New System.Drawing.Size(938, 479)
        Me.GeckoWebBrowser1.TabIndex = 0
        Me.GeckoWebBrowser1.UseHttpActivityObserver = False
        '
        'PreviousButton
        '
        Me.PreviousButton.ErrorImage = CType(resources.GetObject("PreviousButton.ErrorImage"), System.Drawing.Image)
        Me.PreviousButton.Image = CType(resources.GetObject("PreviousButton.Image"), System.Drawing.Image)
        Me.PreviousButton.InitialImage = CType(resources.GetObject("PreviousButton.InitialImage"), System.Drawing.Image)
        Me.PreviousButton.Location = New System.Drawing.Point(0, 0)
        Me.PreviousButton.Name = "PreviousButton"
        Me.PreviousButton.Size = New System.Drawing.Size(25, 25)
        Me.PreviousButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PreviousButton.TabIndex = 1
        Me.PreviousButton.TabStop = False
        '
        'NextButton
        '
        Me.NextButton.ErrorImage = CType(resources.GetObject("NextButton.ErrorImage"), System.Drawing.Image)
        Me.NextButton.Image = CType(resources.GetObject("NextButton.Image"), System.Drawing.Image)
        Me.NextButton.InitialImage = CType(resources.GetObject("NextButton.InitialImage"), System.Drawing.Image)
        Me.NextButton.Location = New System.Drawing.Point(25, 0)
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Size = New System.Drawing.Size(25, 25)
        Me.NextButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.NextButton.TabIndex = 2
        Me.NextButton.TabStop = False
        '
        'URLTextBox
        '
        Me.URLTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.URLTextBox.Location = New System.Drawing.Point(78, 1)
        Me.URLTextBox.Name = "URLTextBox"
        Me.URLTextBox.Size = New System.Drawing.Size(859, 23)
        Me.URLTextBox.TabIndex = 3
        '
        'FaviconPictureBox
        '
        Me.FaviconPictureBox.ErrorImage = CType(resources.GetObject("FaviconPictureBox.ErrorImage"), System.Drawing.Image)
        Me.FaviconPictureBox.InitialImage = CType(resources.GetObject("FaviconPictureBox.InitialImage"), System.Drawing.Image)
        Me.FaviconPictureBox.Location = New System.Drawing.Point(56, 4)
        Me.FaviconPictureBox.Name = "FaviconPictureBox"
        Me.FaviconPictureBox.Size = New System.Drawing.Size(16, 16)
        Me.FaviconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.FaviconPictureBox.TabIndex = 4
        Me.FaviconPictureBox.TabStop = False
        '
        'NextButtonDisabled
        '
        Me.NextButtonDisabled.ErrorImage = CType(resources.GetObject("NextButtonDisabled.ErrorImage"), System.Drawing.Image)
        Me.NextButtonDisabled.Image = CType(resources.GetObject("NextButtonDisabled.Image"), System.Drawing.Image)
        Me.NextButtonDisabled.InitialImage = CType(resources.GetObject("NextButtonDisabled.InitialImage"), System.Drawing.Image)
        Me.NextButtonDisabled.Location = New System.Drawing.Point(25, 0)
        Me.NextButtonDisabled.Name = "NextButtonDisabled"
        Me.NextButtonDisabled.Size = New System.Drawing.Size(25, 25)
        Me.NextButtonDisabled.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.NextButtonDisabled.TabIndex = 5
        Me.NextButtonDisabled.TabStop = False
        '
        'PreviousButtonDisabled
        '
        Me.PreviousButtonDisabled.ErrorImage = CType(resources.GetObject("PreviousButtonDisabled.ErrorImage"), System.Drawing.Image)
        Me.PreviousButtonDisabled.Image = CType(resources.GetObject("PreviousButtonDisabled.Image"), System.Drawing.Image)
        Me.PreviousButtonDisabled.InitialImage = CType(resources.GetObject("PreviousButtonDisabled.InitialImage"), System.Drawing.Image)
        Me.PreviousButtonDisabled.Location = New System.Drawing.Point(0, 0)
        Me.PreviousButtonDisabled.Name = "PreviousButtonDisabled"
        Me.PreviousButtonDisabled.Size = New System.Drawing.Size(25, 25)
        Me.PreviousButtonDisabled.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PreviousButtonDisabled.TabIndex = 1
        Me.PreviousButtonDisabled.TabStop = False
        '
        'BrowserForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(938, 504)
        Me.Controls.Add(Me.NextButtonDisabled)
        Me.Controls.Add(Me.FaviconPictureBox)
        Me.Controls.Add(Me.URLTextBox)
        Me.Controls.Add(Me.NextButton)
        Me.Controls.Add(Me.PreviousButtonDisabled)
        Me.Controls.Add(Me.PreviousButton)
        Me.Controls.Add(Me.GeckoWebBrowser1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "BrowserForm"
        Me.Text = "Navigateur SmartNet Search Bar"
        CType(Me.PreviousButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NextButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FaviconPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NextButtonDisabled, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PreviousButtonDisabled, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GeckoWebBrowser1 As Gecko.GeckoWebBrowser
    Friend WithEvents PreviousButton As PictureBox
    Friend WithEvents NextButton As PictureBox
    Friend WithEvents URLTextBox As TextBox
    Friend WithEvents FaviconPictureBox As PictureBox
    Friend WithEvents NextButtonDisabled As PictureBox
    Friend WithEvents PreviousButtonDisabled As PictureBox
End Class
