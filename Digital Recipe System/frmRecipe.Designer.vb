<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRecipe
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblRecipeName = New System.Windows.Forms.Label()
        Me.txtIngredients = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.txtMethod = New System.Windows.Forms.TextBox()
        Me.lblIngredients = New System.Windows.Forms.Label()
        Me.lblMethod = New System.Windows.Forms.Label()
        Me.btnChangeName = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblRecipeName
        '
        Me.lblRecipeName.AutoSize = True
        Me.lblRecipeName.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecipeName.Location = New System.Drawing.Point(46, 44)
        Me.lblRecipeName.Name = "lblRecipeName"
        Me.lblRecipeName.Size = New System.Drawing.Size(156, 37)
        Me.lblRecipeName.TabIndex = 2
        Me.lblRecipeName.Text = "Filler Text"
        '
        'txtIngredients
        '
        Me.txtIngredients.BackColor = System.Drawing.SystemColors.Control
        Me.txtIngredients.Location = New System.Drawing.Point(55, 156)
        Me.txtIngredients.Multiline = True
        Me.txtIngredients.Name = "txtIngredients"
        Me.txtIngredients.ReadOnly = True
        Me.txtIngredients.Size = New System.Drawing.Size(234, 413)
        Me.txtIngredients.TabIndex = 3
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(453, 681)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(360, 58)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "Save Changes"
        Me.btnSave.UseVisualStyleBackColor = True
        Me.btnSave.Visible = False
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(55, 681)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(375, 58)
        Me.btnDelete.TabIndex = 5
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        Me.btnDelete.Visible = False
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(704, 590)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(109, 73)
        Me.btnBack.TabIndex = 6
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'txtMethod
        '
        Me.txtMethod.BackColor = System.Drawing.SystemColors.Control
        Me.txtMethod.Location = New System.Drawing.Point(316, 156)
        Me.txtMethod.Multiline = True
        Me.txtMethod.Name = "txtMethod"
        Me.txtMethod.ReadOnly = True
        Me.txtMethod.Size = New System.Drawing.Size(497, 413)
        Me.txtMethod.TabIndex = 7
        '
        'lblIngredients
        '
        Me.lblIngredients.AutoSize = True
        Me.lblIngredients.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIngredients.Location = New System.Drawing.Point(48, 107)
        Me.lblIngredients.Name = "lblIngredients"
        Me.lblIngredients.Size = New System.Drawing.Size(133, 29)
        Me.lblIngredients.TabIndex = 8
        Me.lblIngredients.Text = "Ingredients"
        '
        'lblMethod
        '
        Me.lblMethod.AutoSize = True
        Me.lblMethod.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMethod.Location = New System.Drawing.Point(311, 107)
        Me.lblMethod.Name = "lblMethod"
        Me.lblMethod.Size = New System.Drawing.Size(94, 29)
        Me.lblMethod.TabIndex = 9
        Me.lblMethod.Text = "Method"
        '
        'btnChangeName
        '
        Me.btnChangeName.Location = New System.Drawing.Point(681, 44)
        Me.btnChangeName.Name = "btnChangeName"
        Me.btnChangeName.Size = New System.Drawing.Size(132, 37)
        Me.btnChangeName.TabIndex = 10
        Me.btnChangeName.Text = "Change Name"
        Me.btnChangeName.UseVisualStyleBackColor = True
        Me.btnChangeName.Visible = False
        '
        'btnEdit
        '
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(55, 590)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(630, 73)
        Me.btnEdit.TabIndex = 11
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'frmRecipe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(877, 795)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnChangeName)
        Me.Controls.Add(Me.lblMethod)
        Me.Controls.Add(Me.lblIngredients)
        Me.Controls.Add(Me.txtMethod)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtIngredients)
        Me.Controls.Add(Me.lblRecipeName)
        Me.Name = "frmRecipe"
        Me.Padding = New System.Windows.Forms.Padding(0, 0, 50, 50)
        Me.Text = "frmRecipe"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblRecipeName As Label
    Friend WithEvents txtIngredients As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents txtMethod As TextBox
    Friend WithEvents lblIngredients As Label
    Friend WithEvents lblMethod As Label
    Friend WithEvents btnChangeName As Button
    Friend WithEvents btnEdit As Button
End Class
