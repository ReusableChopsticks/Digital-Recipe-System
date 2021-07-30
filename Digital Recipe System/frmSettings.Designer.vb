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
        Me.lblThemeColour = New System.Windows.Forms.Label()
        Me.lblLanguage = New System.Windows.Forms.Label()
        Me.grpThemeColour = New System.Windows.Forms.GroupBox()
        Me.rbLight = New System.Windows.Forms.RadioButton()
        Me.rbDark = New System.Windows.Forms.RadioButton()
        Me.grpLanguage = New System.Windows.Forms.GroupBox()
        Me.rbIndonesian = New System.Windows.Forms.RadioButton()
        Me.rbEnglish = New System.Windows.Forms.RadioButton()
        Me.btnFinish = New System.Windows.Forms.Button()
        Me.grpThemeColour.SuspendLayout()
        Me.grpLanguage.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblThemeColour
        '
        Me.lblThemeColour.AutoSize = True
        Me.lblThemeColour.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblThemeColour.Location = New System.Drawing.Point(52, 53)
        Me.lblThemeColour.Name = "lblThemeColour"
        Me.lblThemeColour.Size = New System.Drawing.Size(220, 37)
        Me.lblThemeColour.TabIndex = 1
        Me.lblThemeColour.Text = "Theme Colour"
        '
        'lblLanguage
        '
        Me.lblLanguage.AutoSize = True
        Me.lblLanguage.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLanguage.Location = New System.Drawing.Point(52, 254)
        Me.lblLanguage.Name = "lblLanguage"
        Me.lblLanguage.Size = New System.Drawing.Size(160, 37)
        Me.lblLanguage.TabIndex = 2
        Me.lblLanguage.Text = "Language"
        '
        'grpThemeColour
        '
        Me.grpThemeColour.Controls.Add(Me.rbDark)
        Me.grpThemeColour.Controls.Add(Me.rbLight)
        Me.grpThemeColour.Location = New System.Drawing.Point(59, 105)
        Me.grpThemeColour.Name = "grpThemeColour"
        Me.grpThemeColour.Size = New System.Drawing.Size(485, 95)
        Me.grpThemeColour.TabIndex = 3
        Me.grpThemeColour.TabStop = False
        Me.grpThemeColour.Text = "GroupBox1"
        '
        'rbLight
        '
        Me.rbLight.AutoSize = True
        Me.rbLight.Location = New System.Drawing.Point(40, 42)
        Me.rbLight.Name = "rbLight"
        Me.rbLight.Size = New System.Drawing.Size(69, 24)
        Me.rbLight.TabIndex = 0
        Me.rbLight.TabStop = True
        Me.rbLight.Text = "Light"
        Me.rbLight.UseVisualStyleBackColor = True
        '
        'rbDark
        '
        Me.rbDark.AutoSize = True
        Me.rbDark.Location = New System.Drawing.Point(232, 42)
        Me.rbDark.Name = "rbDark"
        Me.rbDark.Size = New System.Drawing.Size(68, 24)
        Me.rbDark.TabIndex = 1
        Me.rbDark.TabStop = True
        Me.rbDark.Text = "Dark"
        Me.rbDark.UseVisualStyleBackColor = True
        '
        'grpLanguage
        '
        Me.grpLanguage.Controls.Add(Me.rbIndonesian)
        Me.grpLanguage.Controls.Add(Me.rbEnglish)
        Me.grpLanguage.Location = New System.Drawing.Point(59, 304)
        Me.grpLanguage.Name = "grpLanguage"
        Me.grpLanguage.Size = New System.Drawing.Size(485, 95)
        Me.grpLanguage.TabIndex = 4
        Me.grpLanguage.TabStop = False
        Me.grpLanguage.Text = "GroupBox2"
        '
        'rbIndonesian
        '
        Me.rbIndonesian.AutoSize = True
        Me.rbIndonesian.Location = New System.Drawing.Point(232, 42)
        Me.rbIndonesian.Name = "rbIndonesian"
        Me.rbIndonesian.Size = New System.Drawing.Size(113, 24)
        Me.rbIndonesian.TabIndex = 1
        Me.rbIndonesian.TabStop = True
        Me.rbIndonesian.Text = "Indonesian"
        Me.rbIndonesian.UseVisualStyleBackColor = True
        '
        'rbEnglish
        '
        Me.rbEnglish.AutoSize = True
        Me.rbEnglish.Location = New System.Drawing.Point(40, 42)
        Me.rbEnglish.Name = "rbEnglish"
        Me.rbEnglish.Size = New System.Drawing.Size(86, 24)
        Me.rbEnglish.TabIndex = 0
        Me.rbEnglish.TabStop = True
        Me.rbEnglish.Text = "English"
        Me.rbEnglish.UseVisualStyleBackColor = True
        '
        'btnFinish
        '
        Me.btnFinish.Location = New System.Drawing.Point(364, 433)
        Me.btnFinish.Name = "btnFinish"
        Me.btnFinish.Size = New System.Drawing.Size(180, 71)
        Me.btnFinish.TabIndex = 5
        Me.btnFinish.Text = "Finish"
        Me.btnFinish.UseVisualStyleBackColor = True
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(609, 538)
        Me.Controls.Add(Me.btnFinish)
        Me.Controls.Add(Me.grpLanguage)
        Me.Controls.Add(Me.grpThemeColour)
        Me.Controls.Add(Me.lblLanguage)
        Me.Controls.Add(Me.lblThemeColour)
        Me.Name = "frmSettings"
        Me.Text = "frmSettings"
        Me.grpThemeColour.ResumeLayout(False)
        Me.grpThemeColour.PerformLayout()
        Me.grpLanguage.ResumeLayout(False)
        Me.grpLanguage.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblThemeColour As Label
    Friend WithEvents lblLanguage As Label
    Friend WithEvents grpThemeColour As GroupBox
    Friend WithEvents rbDark As RadioButton
    Friend WithEvents rbLight As RadioButton
    Friend WithEvents grpLanguage As GroupBox
    Friend WithEvents rbIndonesian As RadioButton
    Friend WithEvents rbEnglish As RadioButton
    Friend WithEvents btnFinish As Button
End Class
