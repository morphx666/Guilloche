<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tbScale = New System.Windows.Forms.TrackBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbSteps = New System.Windows.Forms.TrackBar()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbMultiplier = New System.Windows.Forms.TrackBar()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbRadius = New System.Windows.Forms.TrackBar()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbMinorRipple = New System.Windows.Forms.TrackBar()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbMajorRipple = New System.Windows.Forms.TrackBar()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbThickness = New System.Windows.Forms.TrackBar()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbOpacity = New System.Windows.Forms.TrackBar()
        Me.cbColor1 = New ColorButton.ColorButton()
        Me.cbColor2 = New ColorButton.ColorButton()
        Me.cbBackColor = New ColorButton.ColorButton()
        CType(Me.tbScale, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbSteps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbMultiplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbRadius, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbMinorRipple, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbMajorRipple, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbThickness, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbOpacity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbScale
        '
        Me.tbScale.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbScale.AutoSize = False
        Me.tbScale.Location = New System.Drawing.Point(86, 12)
        Me.tbScale.Maximum = 150
        Me.tbScale.Minimum = 10
        Me.tbScale.Name = "tbScale"
        Me.tbScale.Size = New System.Drawing.Size(186, 21)
        Me.tbScale.TabIndex = 0
        Me.tbScale.TickStyle = System.Windows.Forms.TickStyle.None
        Me.tbScale.Value = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Scale"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Steps"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbSteps
        '
        Me.tbSteps.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbSteps.AutoSize = False
        Me.tbSteps.Location = New System.Drawing.Point(86, 39)
        Me.tbSteps.Maximum = 3000
        Me.tbSteps.Minimum = 10
        Me.tbSteps.Name = "tbSteps"
        Me.tbSteps.Size = New System.Drawing.Size(186, 21)
        Me.tbSteps.TabIndex = 2
        Me.tbSteps.TickStyle = System.Windows.Forms.TickStyle.None
        Me.tbSteps.Value = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Multiplier"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbMultiplier
        '
        Me.tbMultiplier.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbMultiplier.AutoSize = False
        Me.tbMultiplier.Location = New System.Drawing.Point(86, 66)
        Me.tbMultiplier.Maximum = 500
        Me.tbMultiplier.Minimum = 1
        Me.tbMultiplier.Name = "tbMultiplier"
        Me.tbMultiplier.Size = New System.Drawing.Size(186, 21)
        Me.tbMultiplier.TabIndex = 4
        Me.tbMultiplier.TickStyle = System.Windows.Forms.TickStyle.None
        Me.tbMultiplier.Value = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(40, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Radius"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbRadius
        '
        Me.tbRadius.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbRadius.AutoSize = False
        Me.tbRadius.Location = New System.Drawing.Point(86, 147)
        Me.tbRadius.Maximum = 100
        Me.tbRadius.Name = "tbRadius"
        Me.tbRadius.Size = New System.Drawing.Size(186, 21)
        Me.tbRadius.TabIndex = 10
        Me.tbRadius.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Minor Ripple"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbMinorRipple
        '
        Me.tbMinorRipple.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbMinorRipple.AutoSize = False
        Me.tbMinorRipple.Location = New System.Drawing.Point(86, 120)
        Me.tbMinorRipple.Maximum = 500
        Me.tbMinorRipple.Name = "tbMinorRipple"
        Me.tbMinorRipple.Size = New System.Drawing.Size(186, 21)
        Me.tbMinorRipple.TabIndex = 8
        Me.tbMinorRipple.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 97)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Major Ripple"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbMajorRipple
        '
        Me.tbMajorRipple.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbMajorRipple.AutoSize = False
        Me.tbMajorRipple.Location = New System.Drawing.Point(86, 93)
        Me.tbMajorRipple.Maximum = 100
        Me.tbMajorRipple.Name = "tbMajorRipple"
        Me.tbMajorRipple.Size = New System.Drawing.Size(186, 21)
        Me.tbMajorRipple.TabIndex = 6
        Me.tbMajorRipple.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(24, 205)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Thickness"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbThickness
        '
        Me.tbThickness.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbThickness.AutoSize = False
        Me.tbThickness.Location = New System.Drawing.Point(86, 201)
        Me.tbThickness.Maximum = 50
        Me.tbThickness.Minimum = 1
        Me.tbThickness.Name = "tbThickness"
        Me.tbThickness.Size = New System.Drawing.Size(186, 21)
        Me.tbThickness.TabIndex = 14
        Me.tbThickness.TickStyle = System.Windows.Forms.TickStyle.None
        Me.tbThickness.Value = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(37, 178)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Opacity"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbOpacity
        '
        Me.tbOpacity.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbOpacity.AutoSize = False
        Me.tbOpacity.Location = New System.Drawing.Point(86, 174)
        Me.tbOpacity.Maximum = 1000
        Me.tbOpacity.Minimum = 1
        Me.tbOpacity.Name = "tbOpacity"
        Me.tbOpacity.Size = New System.Drawing.Size(186, 21)
        Me.tbOpacity.TabIndex = 12
        Me.tbOpacity.TickStyle = System.Windows.Forms.TickStyle.None
        Me.tbOpacity.Value = 1
        '
        'cbColor1
        '
        Me.cbColor1.Color.Alpha = CType(255, Byte)
        Me.cbColor1.Color.Blue = CType(240, Byte)
        Me.cbColor1.Color.Color = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.cbColor1.Color.Green = CType(240, Byte)
        Me.cbColor1.Color.Hue = 0.0!
        Me.cbColor1.Color.Luminance = 0.9411765!
        Me.cbColor1.Color.Red = CType(240, Byte)
        Me.cbColor1.Color.Saturation = 0.0!
        Me.cbColor1.ColorBoxPadding = 0
        Me.cbColor1.Location = New System.Drawing.Point(86, 228)
        Me.cbColor1.MaximumSize = New System.Drawing.Size(85, 19)
        Me.cbColor1.MinimumSize = New System.Drawing.Size(85, 19)
        Me.cbColor1.Name = "cbColor1"
        Me.cbColor1.Size = New System.Drawing.Size(85, 19)
        Me.cbColor1.TabIndex = 16
        Me.cbColor1.Text = "Line Color 1"
        '
        'cbColor2
        '
        Me.cbColor2.Color.Alpha = CType(255, Byte)
        Me.cbColor2.Color.Blue = CType(240, Byte)
        Me.cbColor2.Color.Color = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.cbColor2.Color.Green = CType(240, Byte)
        Me.cbColor2.Color.Hue = 0.0!
        Me.cbColor2.Color.Luminance = 0.9411765!
        Me.cbColor2.Color.Red = CType(240, Byte)
        Me.cbColor2.Color.Saturation = 0.0!
        Me.cbColor2.ColorBoxPadding = 0
        Me.cbColor2.Location = New System.Drawing.Point(86, 252)
        Me.cbColor2.MaximumSize = New System.Drawing.Size(85, 19)
        Me.cbColor2.MinimumSize = New System.Drawing.Size(85, 19)
        Me.cbColor2.Name = "cbColor2"
        Me.cbColor2.Size = New System.Drawing.Size(85, 19)
        Me.cbColor2.TabIndex = 17
        Me.cbColor2.Text = "Line Color 2"
        '
        'cbBackColor
        '
        Me.cbBackColor.Color.Alpha = CType(255, Byte)
        Me.cbBackColor.Color.Blue = CType(240, Byte)
        Me.cbBackColor.Color.Color = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.cbBackColor.Color.Green = CType(240, Byte)
        Me.cbBackColor.Color.Hue = 0.0!
        Me.cbBackColor.Color.Luminance = 0.9411765!
        Me.cbBackColor.Color.Red = CType(240, Byte)
        Me.cbBackColor.Color.Saturation = 0.0!
        Me.cbBackColor.ColorBoxPadding = 0
        Me.cbBackColor.Location = New System.Drawing.Point(90, 276)
        Me.cbBackColor.MaximumSize = New System.Drawing.Size(81, 19)
        Me.cbBackColor.MinimumSize = New System.Drawing.Size(81, 19)
        Me.cbBackColor.Name = "cbBackColor"
        Me.cbBackColor.Size = New System.Drawing.Size(81, 19)
        Me.cbBackColor.TabIndex = 18
        Me.cbBackColor.Text = "Back Color"
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 302)
        Me.ControlBox = False
        Me.Controls.Add(Me.cbBackColor)
        Me.Controls.Add(Me.cbColor2)
        Me.Controls.Add(Me.cbColor1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tbThickness)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tbOpacity)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbRadius)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbMinorRipple)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tbMajorRipple)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbMultiplier)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbSteps)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbScale)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MaximumSize = New System.Drawing.Size(2048, 336)
        Me.MinimumSize = New System.Drawing.Size(300, 336)
        Me.Name = "frmSettings"
        Me.Text = "Settings"
        CType(Me.tbScale, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbSteps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbMultiplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbRadius, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbMinorRipple, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbMajorRipple, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbThickness, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbOpacity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbScale As System.Windows.Forms.TrackBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbSteps As System.Windows.Forms.TrackBar
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbMultiplier As System.Windows.Forms.TrackBar
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbRadius As System.Windows.Forms.TrackBar
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbMinorRipple As System.Windows.Forms.TrackBar
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tbMajorRipple As System.Windows.Forms.TrackBar
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tbThickness As System.Windows.Forms.TrackBar
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tbOpacity As System.Windows.Forms.TrackBar
    Friend WithEvents cbColor1 As ColorButton.ColorButton
    Friend WithEvents cbColor2 As ColorButton.ColorButton
    Friend WithEvents cbBackColor As ColorButton.ColorButton
End Class
