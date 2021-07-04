<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMaintenance
    Inherits MetroFramework.Forms.MetroForm

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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMaintenance))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.MetroTabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.btnCatUpdate = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEdit = New System.Windows.Forms.DataGridViewImageColumn()
        Me.colDel = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnCatSave = New System.Windows.Forms.Button()
        Me.txtCategory = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MetroTabPage2 = New MetroFramework.Controls.MetroTabPage()
        Me.btnProgSave = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmEdit = New System.Windows.Forms.DataGridViewImageColumn()
        Me.clmDel = New System.Windows.Forms.DataGridViewImageColumn()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnProgUpdate = New System.Windows.Forms.Button()
        Me.txtProgram = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MetroTabPage3 = New MetroFramework.Controls.MetroTabPage()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.txtDaysAllowed = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtBooksAllowed = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPenalty = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MetroTabControl1.SuspendLayout()
        Me.MetroTabPage1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroTabPage2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroTabPage3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage1)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage2)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage3)
        Me.MetroTabControl1.Location = New System.Drawing.Point(4, 100)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 2
        Me.MetroTabControl1.Size = New System.Drawing.Size(892, 474)
        Me.MetroTabControl1.TabIndex = 0
        Me.MetroTabControl1.UseSelectable = True
        '
        'MetroTabPage1
        '
        Me.MetroTabPage1.Controls.Add(Me.btnCatUpdate)
        Me.MetroTabPage1.Controls.Add(Me.DataGridView1)
        Me.MetroTabPage1.Controls.Add(Me.Button2)
        Me.MetroTabPage1.Controls.Add(Me.btnCatSave)
        Me.MetroTabPage1.Controls.Add(Me.txtCategory)
        Me.MetroTabPage1.Controls.Add(Me.Label1)
        Me.MetroTabPage1.HorizontalScrollbarBarColor = True
        Me.MetroTabPage1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.HorizontalScrollbarSize = 1
        Me.MetroTabPage1.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage1.Name = "MetroTabPage1"
        Me.MetroTabPage1.Size = New System.Drawing.Size(884, 432)
        Me.MetroTabPage1.TabIndex = 0
        Me.MetroTabPage1.Text = "Category"
        Me.MetroTabPage1.VerticalScrollbarBarColor = True
        Me.MetroTabPage1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.VerticalScrollbarSize = 2
        '
        'btnCatUpdate
        '
        Me.btnCatUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnCatUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCatUpdate.Enabled = False
        Me.btnCatUpdate.FlatAppearance.BorderSize = 0
        Me.btnCatUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCatUpdate.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCatUpdate.ForeColor = System.Drawing.Color.White
        Me.btnCatUpdate.Location = New System.Drawing.Point(277, 54)
        Me.btnCatUpdate.Name = "btnCatUpdate"
        Me.btnCatUpdate.Size = New System.Drawing.Size(75, 30)
        Me.btnCatUpdate.TabIndex = 9
        Me.btnCatUpdate.Text = "Update"
        Me.btnCatUpdate.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column3, Me.Column1, Me.colEdit, Me.colDel})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(0, 90)
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
        Me.DataGridView1.Size = New System.Drawing.Size(881, 342)
        Me.DataGridView1.TabIndex = 6
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column3.HeaderText = "#"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column3.Width = 24
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = "Category"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colEdit
        '
        Me.colEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colEdit.HeaderText = ""
        Me.colEdit.Image = CType(resources.GetObject("colEdit.Image"), System.Drawing.Image)
        Me.colEdit.MinimumWidth = 6
        Me.colEdit.Name = "colEdit"
        Me.colEdit.ReadOnly = True
        Me.colEdit.Width = 6
        '
        'colDel
        '
        Me.colDel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colDel.HeaderText = ""
        Me.colDel.Image = CType(resources.GetObject("colDel.Image"), System.Drawing.Image)
        Me.colDel.MinimumWidth = 6
        Me.colDel.Name = "colDel"
        Me.colDel.ReadOnly = True
        Me.colDel.Width = 6
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(358, 54)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 30)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnCatSave
        '
        Me.btnCatSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnCatSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCatSave.FlatAppearance.BorderSize = 0
        Me.btnCatSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCatSave.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCatSave.ForeColor = System.Drawing.Color.White
        Me.btnCatSave.Location = New System.Drawing.Point(196, 54)
        Me.btnCatSave.Name = "btnCatSave"
        Me.btnCatSave.Size = New System.Drawing.Size(75, 30)
        Me.btnCatSave.TabIndex = 4
        Me.btnCatSave.Text = "Save"
        Me.btnCatSave.UseVisualStyleBackColor = False
        '
        'txtCategory
        '
        Me.txtCategory.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCategory.Location = New System.Drawing.Point(155, 19)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Size = New System.Drawing.Size(278, 25)
        Me.txtCategory.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Enter Category"
        '
        'MetroTabPage2
        '
        Me.MetroTabPage2.Controls.Add(Me.btnProgSave)
        Me.MetroTabPage2.Controls.Add(Me.DataGridView2)
        Me.MetroTabPage2.Controls.Add(Me.txtDescription)
        Me.MetroTabPage2.Controls.Add(Me.Label3)
        Me.MetroTabPage2.Controls.Add(Me.Button3)
        Me.MetroTabPage2.Controls.Add(Me.btnProgUpdate)
        Me.MetroTabPage2.Controls.Add(Me.txtProgram)
        Me.MetroTabPage2.Controls.Add(Me.Label2)
        Me.MetroTabPage2.HorizontalScrollbarBarColor = True
        Me.MetroTabPage2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.HorizontalScrollbarSize = 1
        Me.MetroTabPage2.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage2.Name = "MetroTabPage2"
        Me.MetroTabPage2.Size = New System.Drawing.Size(884, 432)
        Me.MetroTabPage2.TabIndex = 1
        Me.MetroTabPage2.Text = "Program"
        Me.MetroTabPage2.VerticalScrollbarBarColor = True
        Me.MetroTabPage2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.VerticalScrollbarSize = 2
        '
        'btnProgSave
        '
        Me.btnProgSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnProgSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProgSave.FlatAppearance.BorderSize = 0
        Me.btnProgSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProgSave.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProgSave.ForeColor = System.Drawing.Color.White
        Me.btnProgSave.Location = New System.Drawing.Point(628, 19)
        Me.btnProgSave.Name = "btnProgSave"
        Me.btnProgSave.Size = New System.Drawing.Size(75, 30)
        Me.btnProgSave.TabIndex = 13
        Me.btnProgSave.Text = "Save"
        Me.btnProgSave.UseVisualStyleBackColor = False
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView2.ColumnHeadersHeight = 30
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column4, Me.DataGridViewTextBoxColumn1, Me.Column2, Me.clmEdit, Me.clmDel})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle5.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView2.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView2.EnableHeadersVisualStyles = False
        Me.DataGridView2.Location = New System.Drawing.Point(0, 90)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.RowHeadersWidth = 51
        Me.DataGridView2.RowTemplate.Height = 25
        Me.DataGridView2.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(884, 342)
        Me.DataGridView2.TabIndex = 12
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column4.HeaderText = "#"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column4.Width = 24
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.HeaderText = "Program"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn1.Width = 66
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "Description"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'clmEdit
        '
        Me.clmEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.clmEdit.HeaderText = ""
        Me.clmEdit.Image = CType(resources.GetObject("clmEdit.Image"), System.Drawing.Image)
        Me.clmEdit.MinimumWidth = 6
        Me.clmEdit.Name = "clmEdit"
        Me.clmEdit.ReadOnly = True
        Me.clmEdit.Width = 6
        '
        'clmDel
        '
        Me.clmDel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.clmDel.HeaderText = ""
        Me.clmDel.Image = CType(resources.GetObject("clmDel.Image"), System.Drawing.Image)
        Me.clmDel.MinimumWidth = 6
        Me.clmDel.Name = "clmDel"
        Me.clmDel.ReadOnly = True
        Me.clmDel.Width = 6
        '
        'txtDescription
        '
        Me.txtDescription.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Location = New System.Drawing.Point(155, 54)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(711, 25)
        Me.txtDescription.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(43, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 18)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Description"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(791, 19)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 30)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Cancel"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'btnProgUpdate
        '
        Me.btnProgUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnProgUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProgUpdate.Enabled = False
        Me.btnProgUpdate.FlatAppearance.BorderSize = 0
        Me.btnProgUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProgUpdate.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProgUpdate.ForeColor = System.Drawing.Color.White
        Me.btnProgUpdate.Location = New System.Drawing.Point(709, 19)
        Me.btnProgUpdate.Name = "btnProgUpdate"
        Me.btnProgUpdate.Size = New System.Drawing.Size(75, 30)
        Me.btnProgUpdate.TabIndex = 8
        Me.btnProgUpdate.Text = "Update"
        Me.btnProgUpdate.UseVisualStyleBackColor = False
        '
        'txtProgram
        '
        Me.txtProgram.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProgram.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProgram.Location = New System.Drawing.Point(155, 19)
        Me.txtProgram.Name = "txtProgram"
        Me.txtProgram.Size = New System.Drawing.Size(467, 25)
        Me.txtProgram.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 18)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Enter Program"
        '
        'MetroTabPage3
        '
        Me.MetroTabPage3.Controls.Add(Me.Button5)
        Me.MetroTabPage3.Controls.Add(Me.Button6)
        Me.MetroTabPage3.Controls.Add(Me.txtDaysAllowed)
        Me.MetroTabPage3.Controls.Add(Me.Label6)
        Me.MetroTabPage3.Controls.Add(Me.txtBooksAllowed)
        Me.MetroTabPage3.Controls.Add(Me.Label5)
        Me.MetroTabPage3.Controls.Add(Me.txtPenalty)
        Me.MetroTabPage3.Controls.Add(Me.Label4)
        Me.MetroTabPage3.HorizontalScrollbarBarColor = True
        Me.MetroTabPage3.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage3.HorizontalScrollbarSize = 1
        Me.MetroTabPage3.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage3.Name = "MetroTabPage3"
        Me.MetroTabPage3.Size = New System.Drawing.Size(884, 432)
        Me.MetroTabPage3.TabIndex = 2
        Me.MetroTabPage3.Text = "Settings"
        Me.MetroTabPage3.VerticalScrollbarBarColor = True
        Me.MetroTabPage3.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage3.VerticalScrollbarSize = 2
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(575, 240)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 30)
        Me.Button5.TabIndex = 15
        Me.Button5.Text = "Cancel"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Button6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(493, 240)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 30)
        Me.Button6.TabIndex = 14
        Me.Button6.Text = "Save"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'txtDaysAllowed
        '
        Me.txtDaysAllowed.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDaysAllowed.Location = New System.Drawing.Point(372, 135)
        Me.txtDaysAllowed.Name = "txtDaysAllowed"
        Me.txtDaysAllowed.Size = New System.Drawing.Size(278, 25)
        Me.txtDaysAllowed.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(191, 141)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(130, 18)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "No. of days allowed"
        '
        'txtBooksAllowed
        '
        Me.txtBooksAllowed.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBooksAllowed.Location = New System.Drawing.Point(372, 170)
        Me.txtBooksAllowed.Name = "txtBooksAllowed"
        Me.txtBooksAllowed.Size = New System.Drawing.Size(278, 25)
        Me.txtBooksAllowed.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(158, 173)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(162, 18)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Books allowed to borrow"
        '
        'txtPenalty
        '
        Me.txtPenalty.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPenalty.Location = New System.Drawing.Point(372, 205)
        Me.txtPenalty.Name = "txtPenalty"
        Me.txtPenalty.Size = New System.Drawing.Size(278, 25)
        Me.txtPenalty.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(285, 208)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 18)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Penalty"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(861, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(28, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'frmMaintenance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(900, 591)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MetroTabControl1)
        Me.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmMaintenance"
        Me.Padding = New System.Windows.Forms.Padding(23, 78, 23, 27)
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.None
        Me.Text = "Maintenance"
        Me.MetroTabControl1.ResumeLayout(False)
        Me.MetroTabPage1.ResumeLayout(False)
        Me.MetroTabPage1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroTabPage2.ResumeLayout(False)
        Me.MetroTabPage2.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroTabPage3.ResumeLayout(False)
        Me.MetroTabPage3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents MetroTabPage1 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTabPage2 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTabPage3 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents btnCatSave As Button
    Friend WithEvents txtCategory As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents btnProgUpdate As Button
    Friend WithEvents txtProgram As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents txtDaysAllowed As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtBooksAllowed As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPenalty As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents btnCatUpdate As Button
    Friend WithEvents btnProgSave As Button
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents colEdit As DataGridViewImageColumn
    Friend WithEvents colDel As DataGridViewImageColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents clmEdit As DataGridViewImageColumn
    Friend WithEvents clmDel As DataGridViewImageColumn
    Friend WithEvents PictureBox1 As PictureBox
End Class
