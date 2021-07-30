<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInput
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
        Me.lblRecipeName = New System.Windows.Forms.Label()
        Me.txtRecipeName = New System.Windows.Forms.TextBox()
        Me.lblIngredients = New System.Windows.Forms.Label()
        Me.txtIngredients = New System.Windows.Forms.TextBox()
        Me.lblMethod = New System.Windows.Forms.Label()
        Me.txtMethod = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbDessert = New System.Windows.Forms.RadioButton()
        Me.rbIndo = New System.Windows.Forms.RadioButton()
        Me.rbDinner = New System.Windows.Forms.RadioButton()
        Me.rbLunch = New System.Windows.Forms.RadioButton()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblRecipeName
        '
        Me.lblRecipeName.AutoSize = True
        Me.lblRecipeName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecipeName.Location = New System.Drawing.Point(28, 30)
        Me.lblRecipeName.Name = "lblRecipeName"
        Me.lblRecipeName.Size = New System.Drawing.Size(161, 29)
        Me.lblRecipeName.TabIndex = 6
        Me.lblRecipeName.Text = "Recipe Name"
        '
        'txtRecipeName
        '
        Me.txtRecipeName.Location = New System.Drawing.Point(206, 34)
        Me.txtRecipeName.Name = "txtRecipeName"
        Me.txtRecipeName.Size = New System.Drawing.Size(532, 26)
        Me.txtRecipeName.TabIndex = 7
        '
        'lblIngredients
        '
        Me.lblIngredients.AutoSize = True
        Me.lblIngredients.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIngredients.Location = New System.Drawing.Point(28, 96)
        Me.lblIngredients.Name = "lblIngredients"
        Me.lblIngredients.Size = New System.Drawing.Size(133, 29)
        Me.lblIngredients.TabIndex = 8
        Me.lblIngredients.Text = "Ingredients"
        '
        'txtIngredients
        '
        Me.txtIngredients.Location = New System.Drawing.Point(206, 100)
        Me.txtIngredients.Multiline = True
        Me.txtIngredients.Name = "txtIngredients"
        Me.txtIngredients.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtIngredients.Size = New System.Drawing.Size(532, 272)
        Me.txtIngredients.TabIndex = 9
        '
        'lblMethod
        '
        Me.lblMethod.AutoSize = True
        Me.lblMethod.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMethod.Location = New System.Drawing.Point(28, 408)
        Me.lblMethod.Name = "lblMethod"
        Me.lblMethod.Size = New System.Drawing.Size(94, 29)
        Me.lblMethod.TabIndex = 10
        Me.lblMethod.Text = "Method"
        '
        'txtMethod
        '
        Me.txtMethod.Location = New System.Drawing.Point(206, 412)
        Me.txtMethod.Multiline = True
        Me.txtMethod.Name = "txtMethod"
        Me.txtMethod.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMethod.Size = New System.Drawing.Size(532, 265)
        Me.txtMethod.TabIndex = 11
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(775, 412)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(302, 171)
        Me.btnAdd.TabIndex = 12
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbDessert)
        Me.GroupBox1.Controls.Add(Me.rbIndo)
        Me.GroupBox1.Controls.Add(Me.rbDinner)
        Me.GroupBox1.Controls.Add(Me.rbLunch)
        Me.GroupBox1.Location = New System.Drawing.Point(775, 100)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(302, 272)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'rbDessert
        '
        Me.rbDessert.AutoSize = True
        Me.rbDessert.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbDessert.Location = New System.Drawing.Point(25, 187)
        Me.rbDessert.Name = "rbDessert"
        Me.rbDessert.Size = New System.Drawing.Size(104, 29)
        Me.rbDessert.TabIndex = 7
        Me.rbDessert.TabStop = True
        Me.rbDessert.Text = "Dessert"
        Me.rbDessert.UseVisualStyleBackColor = True
        '
        'rbIndo
        '
        Me.rbIndo.AutoSize = True
        Me.rbIndo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbIndo.Location = New System.Drawing.Point(25, 35)
        Me.rbIndo.Name = "rbIndo"
        Me.rbIndo.Size = New System.Drawing.Size(208, 29)
        Me.rbIndo.TabIndex = 4
        Me.rbIndo.TabStop = True
        Me.rbIndo.Text = "Indonesian Recipes"
        Me.rbIndo.UseVisualStyleBackColor = True
        '
        'rbDinner
        '
        Me.rbDinner.AutoSize = True
        Me.rbDinner.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbDinner.Location = New System.Drawing.Point(25, 136)
        Me.rbDinner.Name = "rbDinner"
        Me.rbDinner.Size = New System.Drawing.Size(94, 29)
        Me.rbDinner.TabIndex = 6
        Me.rbDinner.TabStop = True
        Me.rbDinner.Text = "Dinner"
        Me.rbDinner.UseVisualStyleBackColor = True
        '
        'rbLunch
        '
        Me.rbLunch.AutoSize = True
        Me.rbLunch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbLunch.Location = New System.Drawing.Point(25, 85)
        Me.rbLunch.Name = "rbLunch"
        Me.rbLunch.Size = New System.Drawing.Size(91, 29)
        Me.rbLunch.TabIndex = 5
        Me.rbLunch.TabStop = True
        Me.rbLunch.Text = "Lunch"
        Me.rbLunch.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(775, 604)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(302, 73)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmInput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1118, 724)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtMethod)
        Me.Controls.Add(Me.lblMethod)
        Me.Controls.Add(Me.txtIngredients)
        Me.Controls.Add(Me.lblIngredients)
        Me.Controls.Add(Me.txtRecipeName)
        Me.Controls.Add(Me.lblRecipeName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmInput"
        Me.Text = "Add Recipe"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblRecipeName As Label
    Friend WithEvents txtRecipeName As TextBox
    Friend WithEvents lblIngredients As Label
    Friend WithEvents txtIngredients As TextBox
    Friend WithEvents lblMethod As Label
    Friend WithEvents txtMethod As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbDessert As RadioButton
    Friend WithEvents rbIndo As RadioButton
    Friend WithEvents rbDinner As RadioButton
    Friend WithEvents rbLunch As RadioButton
    Friend WithEvents btnExit As Button
End Class
