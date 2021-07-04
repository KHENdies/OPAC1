<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBookAcquired
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBookAcquired))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSearch = New MetroFramework.Controls.MetroTextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblRecords = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAuthor = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.nCopies = New System.Windows.Forms.NumericUpDown()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnAddCop = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSelect = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.nCopies, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1202, 49)
        Me.Panel1.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(1082, 9)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(108, 30)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Close"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Book Acquired"
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtSearch.CustomButton.Image = Nothing
        Me.txtSearch.CustomButton.Location = New System.Drawing.Point(386, 1)
        Me.txtSearch.CustomButton.Name = ""
        Me.txtSearch.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtSearch.CustomButton.TabIndex = 1
        Me.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtSearch.CustomButton.UseSelectable = True
        Me.txtSearch.CustomButton.Visible = False
        Me.txtSearch.DisplayIcon = True
        Me.txtSearch.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtSearch.FontWeight = MetroFramework.MetroTextBoxWeight.Light
        Me.txtSearch.Icon = CType(resources.GetObject("txtSearch.Icon"), System.Drawing.Image)
        Me.txtSearch.Lines = New String(-1) {}
        Me.txtSearch.Location = New System.Drawing.Point(778, 55)
        Me.txtSearch.MaxLength = 32767
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearch.PromptText = "Enter Book Title and press[enter] to search"
        Me.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.SelectionLength = 0
        Me.txtSearch.SelectionStart = 0
        Me.txtSearch.ShortcutsEnabled = True
        Me.txtSearch.Size = New System.Drawing.Size(412, 27)
        Me.txtSearch.TabIndex = 6
        Me.txtSearch.UseCustomBackColor = True
        Me.txtSearch.UseSelectable = True
        Me.txtSearch.WaterMark = "Enter Book Title and press[enter] to search"
        Me.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSearch.WaterMarkFont = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeight = 30
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column3, Me.Column1, Me.Column2, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.colSelect})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(7, 55)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(766, 690)
        Me.DataGridView1.TabIndex = 7
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.lblRecords)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 798)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1202, 34)
        Me.Panel2.TabIndex = 8
        '
        'lblRecords
        '
        Me.lblRecords.AutoSize = True
        Me.lblRecords.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblRecords.ForeColor = System.Drawing.Color.Red
        Me.lblRecords.Location = New System.Drawing.Point(135, 4)
        Me.lblRecords.Name = "lblRecords"
        Me.lblRecords.Size = New System.Drawing.Size(0, 21)
        Me.lblRecords.TabIndex = 10
        Me.lblRecords.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 21)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Record(s) Found:"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(774, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 23)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Book ID"
        '
        'txtID
        '
        Me.txtID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtID.Enabled = False
        Me.txtID.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(778, 120)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(412, 29)
        Me.txtID.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(774, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 23)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Book Title"
        '
        'txtTitle
        '
        Me.txtTitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTitle.Enabled = False
        Me.txtTitle.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitle.Location = New System.Drawing.Point(778, 178)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(412, 29)
        Me.txtTitle.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(774, 210)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 23)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Author(s)"
        '
        'txtAuthor
        '
        Me.txtAuthor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAuthor.Enabled = False
        Me.txtAuthor.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAuthor.Location = New System.Drawing.Point(778, 236)
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Size = New System.Drawing.Size(412, 29)
        Me.txtAuthor.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(775, 268)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 23)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Copies"
        '
        'nCopies
        '
        Me.nCopies.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nCopies.Location = New System.Drawing.Point(779, 295)
        Me.nCopies.Name = "nCopies"
        Me.nCopies.Size = New System.Drawing.Size(411, 28)
        Me.nCopies.TabIndex = 16
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(897, 329)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 30)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnAddCop
        '
        Me.btnAddCop.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddCop.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnAddCop.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddCop.FlatAppearance.BorderSize = 0
        Me.btnAddCop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddCop.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddCop.ForeColor = System.Drawing.Color.White
        Me.btnAddCop.Location = New System.Drawing.Point(779, 329)
        Me.btnAddCop.Name = "btnAddCop"
        Me.btnAddCop.Size = New System.Drawing.Size(113, 30)
        Me.btnAddCop.TabIndex = 17
        Me.btnAddCop.Text = "Add Copies"
        Me.btnAddCop.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Location = New System.Drawing.Point(779, 381)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(412, 398)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 19
        Me.PictureBox2.TabStop = False
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column3.HeaderText = "#"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column3.Width = 27
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.HeaderText = "Book ID"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column1.Width = 72
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "Book Title"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column5
        '
        Me.Column5.HeaderText = "Author(s)"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Visible = False
        Me.Column5.Width = 125
        '
        'Column6
        '
        Me.Column6.HeaderText = "Category"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Visible = False
        Me.Column6.Width = 125
        '
        'Column7
        '
        Me.Column7.HeaderText = "Year Pub"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Visible = False
        Me.Column7.Width = 125
        '
        'Column8
        '
        Me.Column8.HeaderText = "Publisher"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Visible = False
        Me.Column8.Width = 125
        '
        'Column9
        '
        Me.Column9.HeaderText = "Book Price"
        Me.Column9.MinimumWidth = 6
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Visible = False
        Me.Column9.Width = 125
        '
        'colSelect
        '
        Me.colSelect.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colSelect.HeaderText = ""
        Me.colSelect.Image = CType(resources.GetObject("colSelect.Image"), System.Drawing.Image)
        Me.colSelect.MinimumWidth = 6
        Me.colSelect.Name = "colSelect"
        Me.colSelect.ReadOnly = True
        Me.colSelect.Width = 6
        '
        'frmBookAcquired
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1202, 832)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnAddCop)
        Me.Controls.Add(Me.nCopies)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtAuthor)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmBookAcquired"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.nCopies, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtSearch As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblRecords As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtAuthor As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents nCopies As NumericUpDown
    Friend WithEvents Button1 As Button
    Friend WithEvents btnAddCop As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents colSelect As DataGridViewImageColumn
End Class
