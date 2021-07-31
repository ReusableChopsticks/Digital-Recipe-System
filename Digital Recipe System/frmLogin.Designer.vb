<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Me.lblSetPassword = New System.Windows.Forms.Label()
        Me.lblConfirmPassword = New System.Windows.Forms.Label()
        Me.btnCreatePassword = New System.Windows.Forms.Button()
        Me.txtSetPassword = New System.Windows.Forms.TextBox()
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.lblHeader2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblSetPassword
        '
        Me.lblSetPassword.AutoSize = True
        Me.lblSetPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSetPassword.Location = New System.Drawing.Point(117, 214)
        Me.lblSetPassword.Name = "lblSetPassword"
        Me.lblSetPassword.Size = New System.Drawing.Size(197, 32)
        Me.lblSetPassword.TabIndex = 0
        Me.lblSetPassword.Text = "Set Password:"
        '
        'lblConfirmPassword
        '
        Me.lblConfirmPassword.AutoSize = True
        Me.lblConfirmPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirmPassword.Location = New System.Drawing.Point(63, 277)
        Me.lblConfirmPassword.Name = "lblConfirmPassword"
        Me.lblConfirmPassword.Size = New System.Drawing.Size(253, 32)
        Me.lblConfirmPassword.TabIndex = 1
        Me.lblConfirmPassword.Text = "Confirm Password:"
        '
        'btnCreatePassword
        '
        Me.btnCreatePassword.BackColor = System.Drawing.Color.LightGreen
        Me.btnCreatePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreatePassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreatePassword.Location = New System.Drawing.Point(271, 372)
        Me.btnCreatePassword.Name = "btnCreatePassword"
        Me.btnCreatePassword.Size = New System.Drawing.Size(325, 71)
        Me.btnCreatePassword.TabIndex = 2
        Me.btnCreatePassword.Text = "Create Password"
        Me.btnCreatePassword.UseVisualStyleBackColor = False
        '
        'txtSetPassword
        '
        Me.txtSetPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSetPassword.Location = New System.Drawing.Point(370, 211)
        Me.txtSetPassword.Name = "txtSetPassword"
        Me.txtSetPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSetPassword.Size = New System.Drawing.Size(397, 39)
        Me.txtSetPassword.TabIndex = 3
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmPassword.Location = New System.Drawing.Point(370, 270)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmPassword.Size = New System.Drawing.Size(397, 39)
        Me.txtConfirmPassword.TabIndex = 4
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.LightGreen
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.Location = New System.Drawing.Point(271, 383)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(325, 71)
        Me.btnLogin.TabIndex = 5
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        Me.btnLogin.Visible = False
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Courier New", 32.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblHeader.Location = New System.Drawing.Point(155, 27)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(562, 69)
        Me.lblHeader.TabIndex = 6
        Me.lblHeader.Text = "Digital Recipe"
        '
        'lblHeader2
        '
        Me.lblHeader2.AutoSize = True
        Me.lblHeader2.Font = New System.Drawing.Font("Courier New", 32.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblHeader2.Location = New System.Drawing.Point(319, 96)
        Me.lblHeader2.Name = "lblHeader2"
        Me.lblHeader2.Size = New System.Drawing.Size(258, 69)
        Me.lblHeader2.TabIndex = 7
        Me.lblHeader2.Text = "System"
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(840, 532)
        Me.Controls.Add(Me.lblHeader2)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtConfirmPassword)
        Me.Controls.Add(Me.txtSetPassword)
        Me.Controls.Add(Me.btnCreatePassword)
        Me.Controls.Add(Me.lblConfirmPassword)
        Me.Controls.Add(Me.lblSetPassword)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmLogin"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSetPassword As Label
    Friend WithEvents lblConfirmPassword As Label
    Friend WithEvents btnCreatePassword As Button
    Friend WithEvents txtSetPassword As TextBox
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents lblHeader As Label
    Friend WithEvents lblHeader2 As Label
End Class
