<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddRecipeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UploadFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.gobTags = New System.Windows.Forms.GroupBox()
        Me.rbDessert = New System.Windows.Forms.RadioButton()
        Me.rbIndo = New System.Windows.Forms.RadioButton()
        Me.rbDinner = New System.Windows.Forms.RadioButton()
        Me.rbLunch = New System.Windows.Forms.RadioButton()
        Me.lsbResults = New System.Windows.Forms.ListBox()
        Me.lblSearchResearch = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.ofdMain = New System.Windows.Forms.OpenFileDialog()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnSort = New System.Windows.Forms.Button()
        Me.MenuStrip.SuspendLayout()
        Me.gobTags.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(936, 33)
        Me.MenuStrip.TabIndex = 0
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddRecipeToolStripMenuItem, Me.UploadFileToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(54, 29)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'AddRecipeToolStripMenuItem
        '
        Me.AddRecipeToolStripMenuItem.Name = "AddRecipeToolStripMenuItem"
        Me.AddRecipeToolStripMenuItem.Size = New System.Drawing.Size(204, 34)
        Me.AddRecipeToolStripMenuItem.Text = "Add Recipe"
        '
        'UploadFileToolStripMenuItem
        '
        Me.UploadFileToolStripMenuItem.Name = "UploadFileToolStripMenuItem"
        Me.UploadFileToolStripMenuItem.Size = New System.Drawing.Size(204, 34)
        Me.UploadFileToolStripMenuItem.Text = "Upload File"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(65, 29)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(176, 119)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(690, 44)
        Me.txtSearch.TabIndex = 2
        '
        'gobTags
        '
        Me.gobTags.Controls.Add(Me.rbDessert)
        Me.gobTags.Controls.Add(Me.rbIndo)
        Me.gobTags.Controls.Add(Me.rbDinner)
        Me.gobTags.Controls.Add(Me.rbLunch)
        Me.gobTags.Location = New System.Drawing.Point(58, 200)
        Me.gobTags.Name = "gobTags"
        Me.gobTags.Size = New System.Drawing.Size(808, 100)
        Me.gobTags.TabIndex = 3
        Me.gobTags.TabStop = False
        Me.gobTags.Text = "Tags"
        '
        'rbDessert
        '
        Me.rbDessert.AutoSize = True
        Me.rbDessert.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbDessert.Location = New System.Drawing.Point(619, 38)
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
        Me.rbIndo.Location = New System.Drawing.Point(72, 38)
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
        Me.rbDinner.Location = New System.Drawing.Point(475, 38)
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
        Me.rbLunch.Location = New System.Drawing.Point(317, 38)
        Me.rbLunch.Name = "rbLunch"
        Me.rbLunch.Size = New System.Drawing.Size(91, 29)
        Me.rbLunch.TabIndex = 5
        Me.rbLunch.TabStop = True
        Me.rbLunch.Text = "Lunch"
        Me.rbLunch.UseVisualStyleBackColor = True
        '
        'lsbResults
        '
        Me.lsbResults.FormattingEnabled = True
        Me.lsbResults.ItemHeight = 20
        Me.lsbResults.Location = New System.Drawing.Point(58, 398)
        Me.lsbResults.Name = "lsbResults"
        Me.lsbResults.Size = New System.Drawing.Size(808, 284)
        Me.lsbResults.TabIndex = 4
        Me.ToolTip.SetToolTip(Me.lsbResults, "Double click on a recipe to view it")
        '
        'lblSearchResearch
        '
        Me.lblSearchResearch.AutoSize = True
        Me.lblSearchResearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchResearch.Location = New System.Drawing.Point(352, 348)
        Me.lblSearchResearch.Name = "lblSearchResearch"
        Me.lblSearchResearch.Size = New System.Drawing.Size(232, 37)
        Me.lblSearchResearch.TabIndex = 5
        Me.lblSearchResearch.Text = "Search Results"
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.Transparent
        Me.btnSearch.BackgroundImage = Global.Digital_Recipe_System.My.Resources.Resources.manifying_glass_icon
        Me.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnSearch.Location = New System.Drawing.Point(58, 98)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(84, 84)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'ofdMain
        '
        Me.ofdMain.FileName = "OpenFileDialog"
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(729, 703)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(137, 57)
        Me.btnQuit.TabIndex = 6
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(573, 703)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(137, 57)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSort
        '
        Me.btnSort.Location = New System.Drawing.Point(414, 703)
        Me.btnSort.Name = "btnSort"
        Me.btnSort.Size = New System.Drawing.Size(137, 57)
        Me.btnSort.TabIndex = 8
        Me.btnSort.Text = "Sort"
        Me.btnSort.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(936, 790)
        Me.Controls.Add(Me.btnSort)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.lblSearchResearch)
        Me.Controls.Add(Me.lsbResults)
        Me.Controls.Add(Me.gobTags)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.MenuStrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "frmMain"
        Me.Padding = New System.Windows.Forms.Padding(0, 0, 0, 30)
        Me.Text = "Digital Recipe System"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.gobTags.ResumeLayout(False)
        Me.gobTags.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddRecipeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents gobTags As GroupBox
    Friend WithEvents rbDessert As RadioButton
    Friend WithEvents rbIndo As RadioButton
    Friend WithEvents rbDinner As RadioButton
    Friend WithEvents rbLunch As RadioButton
    Friend WithEvents lsbResults As ListBox
    Friend WithEvents lblSearchResearch As Label
    Friend WithEvents UploadFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ofdMain As OpenFileDialog
    Friend WithEvents btnQuit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents btnSort As Button
End Class
