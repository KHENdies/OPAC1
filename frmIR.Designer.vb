<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmIR
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIR))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBorrowersID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBorrowersName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDOB = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSex = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtBookTitle = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtBookID = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtAccNum = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtAuthor = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtBookPrice = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtCategory = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtDays = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtDaysAllowed = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtBooksAllowed = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtPenalty = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colExtend = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.colReturn = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1188, 49)
        Me.Panel1.TabIndex = 2
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
        Me.Button2.Location = New System.Drawing.Point(1068, 9)
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
        Me.Label1.Size = New System.Drawing.Size(105, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Issued/Return"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 18)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Borrowers ID"
        '
        'txtBorrowersID
        '
        Me.txtBorrowersID.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBorrowersID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBorrowersID.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBorrowersID.Location = New System.Drawing.Point(106, 106)
        Me.txtBorrowersID.Name = "txtBorrowersID"
        Me.txtBorrowersID.Size = New System.Drawing.Size(435, 25)
        Me.txtBorrowersID.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 18)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Name"
        '
        'txtBorrowersName
        '
        Me.txtBorrowersName.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBorrowersName.Enabled = False
        Me.txtBorrowersName.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBorrowersName.Location = New System.Drawing.Point(106, 141)
        Me.txtBorrowersName.Name = "txtBorrowersName"
        Me.txtBorrowersName.Size = New System.Drawing.Size(435, 25)
        Me.txtBorrowersName.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 284)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 18)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Address"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 249)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 18)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Contact"
        '
        'txtContact
        '
        Me.txtContact.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtContact.Enabled = False
        Me.txtContact.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact.Location = New System.Drawing.Point(106, 246)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(435, 25)
        Me.txtContact.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(9, 214)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 18)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Date of Birth"
        '
        'txtDOB
        '
        Me.txtDOB.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDOB.Enabled = False
        Me.txtDOB.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDOB.Location = New System.Drawing.Point(106, 211)
        Me.txtDOB.Name = "txtDOB"
        Me.txtDOB.Size = New System.Drawing.Size(435, 25)
        Me.txtDOB.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(9, 179)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 18)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Sex"
        '
        'txtSex
        '
        Me.txtSex.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSex.Enabled = False
        Me.txtSex.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSex.Location = New System.Drawing.Point(106, 176)
        Me.txtSex.Name = "txtSex"
        Me.txtSex.Size = New System.Drawing.Size(435, 25)
        Me.txtSex.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(9, 68)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(169, 19)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Borrower's Information"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel2.Image = CType(resources.GetObject("LinkLabel2.Image"), System.Drawing.Image)
        Me.LinkLabel2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LinkLabel2.LinkColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.LinkLabel2.Location = New System.Drawing.Point(1072, 62)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(108, 32)
        Me.LinkLabel2.TabIndex = 31
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Browse Book"
        Me.LinkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LinkLabel2.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(48, Byte), Integer))
        '
        'Label9
        '
        Me.Label9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(625, 68)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(129, 19)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Book Information"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(625, 179)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 18)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "Book Title"
        '
        'txtBookTitle
        '
        Me.txtBookTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBookTitle.Enabled = False
        Me.txtBookTitle.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBookTitle.Location = New System.Drawing.Point(745, 176)
        Me.txtBookTitle.Multiline = True
        Me.txtBookTitle.Name = "txtBookTitle"
        Me.txtBookTitle.Size = New System.Drawing.Size(435, 56)
        Me.txtBookTitle.TabIndex = 29
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(625, 144)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(55, 18)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "Book ID"
        '
        'txtBookID
        '
        Me.txtBookID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBookID.Enabled = False
        Me.txtBookID.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBookID.Location = New System.Drawing.Point(745, 141)
        Me.txtBookID.Name = "txtBookID"
        Me.txtBookID.Size = New System.Drawing.Size(435, 25)
        Me.txtBookID.TabIndex = 20
        '
        'Label15
        '
        Me.Label15.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(625, 109)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(94, 18)
        Me.Label15.TabIndex = 19
        Me.Label15.Text = "Accession No."
        '
        'txtAccNum
        '
        Me.txtAccNum.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAccNum.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAccNum.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccNum.Location = New System.Drawing.Point(745, 106)
        Me.txtAccNum.Name = "txtAccNum"
        Me.txtAccNum.Size = New System.Drawing.Size(435, 25)
        Me.txtAccNum.TabIndex = 18
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(625, 249)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 18)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "Author"
        '
        'txtAuthor
        '
        Me.txtAuthor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAuthor.Enabled = False
        Me.txtAuthor.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAuthor.Location = New System.Drawing.Point(745, 246)
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Size = New System.Drawing.Size(435, 25)
        Me.txtAuthor.TabIndex = 32
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(625, 284)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(73, 18)
        Me.Label12.TabIndex = 35
        Me.Label12.Text = "Book Price"
        '
        'txtBookPrice
        '
        Me.txtBookPrice.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBookPrice.Enabled = False
        Me.txtBookPrice.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBookPrice.Location = New System.Drawing.Point(745, 281)
        Me.txtBookPrice.Name = "txtBookPrice"
        Me.txtBookPrice.Size = New System.Drawing.Size(435, 25)
        Me.txtBookPrice.TabIndex = 34
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(625, 315)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(63, 18)
        Me.Label13.TabIndex = 37
        Me.Label13.Text = "Category"
        '
        'txtCategory
        '
        Me.txtCategory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCategory.Enabled = False
        Me.txtCategory.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCategory.Location = New System.Drawing.Point(745, 312)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Size = New System.Drawing.Size(435, 25)
        Me.txtCategory.TabIndex = 36
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(625, 346)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(111, 18)
        Me.Label16.TabIndex = 39
        Me.Label16.Text = "Number of Days:"
        '
        'txtDays
        '
        Me.txtDays.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDays.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDays.Location = New System.Drawing.Point(745, 343)
        Me.txtDays.MaxLength = 4
        Me.txtDays.Name = "txtDays"
        Me.txtDays.Size = New System.Drawing.Size(230, 25)
        Me.txtDays.TabIndex = 38
        '
        'Label17
        '
        Me.Label17.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(9, 347)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(96, 18)
        Me.Label17.TabIndex = 41
        Me.Label17.Text = "Days Allowed:"
        '
        'txtDaysAllowed
        '
        Me.txtDaysAllowed.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDaysAllowed.Enabled = False
        Me.txtDaysAllowed.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDaysAllowed.Location = New System.Drawing.Point(106, 344)
        Me.txtDaysAllowed.Name = "txtDaysAllowed"
        Me.txtDaysAllowed.Size = New System.Drawing.Size(42, 25)
        Me.txtDaysAllowed.TabIndex = 40
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(1106, 343)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 25)
        Me.btnCancel.TabIndex = 44
        Me.btnCancel.Text = "Delete"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(1025, 344)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 25)
        Me.btnSave.TabIndex = 42
        Me.btnSave.Text = "Borrow"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Label18
        '
        Me.Label18.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(184, 346)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(104, 18)
        Me.Label18.TabIndex = 46
        Me.Label18.Text = "Books Allowed:"
        '
        'txtBooksAllowed
        '
        Me.txtBooksAllowed.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBooksAllowed.Enabled = False
        Me.txtBooksAllowed.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBooksAllowed.Location = New System.Drawing.Point(294, 344)
        Me.txtBooksAllowed.Name = "txtBooksAllowed"
        Me.txtBooksAllowed.Size = New System.Drawing.Size(36, 25)
        Me.txtBooksAllowed.TabIndex = 45
        '
        'Label19
        '
        Me.Label19.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(371, 345)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(59, 18)
        Me.Label19.TabIndex = 48
        Me.Label19.Text = "Penalty:"
        '
        'txtPenalty
        '
        Me.txtPenalty.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPenalty.Enabled = False
        Me.txtPenalty.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPenalty.Location = New System.Drawing.Point(436, 343)
        Me.txtPenalty.Name = "txtPenalty"
        Me.txtPenalty.Size = New System.Drawing.Size(105, 25)
        Me.txtPenalty.TabIndex = 47
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column4, Me.Column3, Me.Column1, Me.Column2, Me.Column10, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column11, Me.colExtend, Me.colReturn})
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
        Me.DataGridView1.Location = New System.Drawing.Point(12, 375)
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
        Me.DataGridView1.Size = New System.Drawing.Size(1169, 302)
        Me.DataGridView1.TabIndex = 49
        '
        'Column4
        '
        Me.Column4.HeaderText = "id"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column4.Visible = False
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
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.HeaderText = "Book ID"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column1.Width = 61
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column2.HeaderText = "Accesion No."
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column2.Width = 89
        '
        'Column10
        '
        Me.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column10.HeaderText = "Book Title"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column5.HeaderText = "Author(s)"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column5.Width = 69
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column6.HeaderText = "Date Borrowed"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column6.Width = 104
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column7.HeaderText = "Date Due"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column7.Width = 71
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column8.HeaderText = "Overdue"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column8.Width = 65
        '
        'Column9
        '
        Me.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column9.HeaderText = "Penalty"
        Me.Column9.MinimumWidth = 6
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column9.Width = 59
        '
        'Column11
        '
        Me.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column11.HeaderText = "Status"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        Me.Column11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column11.Width = 52
        '
        'colExtend
        '
        Me.colExtend.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.colExtend.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colExtend.HeaderText = ""
        Me.colExtend.LinkColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.colExtend.Name = "colExtend"
        Me.colExtend.ReadOnly = True
        Me.colExtend.Text = "Extend"
        Me.colExtend.ToolTipText = "Extend Days"
        Me.colExtend.UseColumnTextForLinkValue = True
        Me.colExtend.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.colExtend.Width = 6
        '
        'colReturn
        '
        Me.colReturn.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.colReturn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colReturn.HeaderText = ""
        Me.colReturn.LinkColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.colReturn.Name = "colReturn"
        Me.colReturn.ReadOnly = True
        Me.colReturn.Text = "Return"
        Me.colReturn.ToolTipText = "Return Book"
        Me.colReturn.UseColumnTextForLinkValue = True
        Me.colReturn.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.colReturn.Width = 6
        '
        'txtAddress
        '
        Me.txtAddress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAddress.Enabled = False
        Me.txtAddress.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(106, 281)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(435, 56)
        Me.txtAddress.TabIndex = 51
        '
        'LinkLabel1
        '
        Me.LinkLabel1.ActiveLinkColor = System.Drawing.Color.Red
        Me.LinkLabel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel1.Image = CType(resources.GetObject("LinkLabel1.Image"), System.Drawing.Image)
        Me.LinkLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LinkLabel1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.LinkLabel1.Location = New System.Drawing.Point(407, 62)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(134, 32)
        Me.LinkLabel1.TabIndex = 52
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Browse Borrowers"
        Me.LinkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LinkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(48, Byte), Integer))
        '
        'BackgroundWorker1
        '
        '
        'BackgroundWorker2
        '
        '
        'frmIR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1188, 868)
        Me.ControlBox = False
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txtPenalty)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtBooksAllowed)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtDaysAllowed)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtDays)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtCategory)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtBookPrice)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtAuthor)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtBookTitle)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtBookID)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtAccNum)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtSex)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtDOB)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtContact)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtBorrowersName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBorrowersID)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmIR"
        Me.RightToLeftLayout = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBorrowersID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtBorrowersName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtContact As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDOB As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtSex As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtBookTitle As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtBookID As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtAccNum As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtAuthor As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtBookPrice As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtCategory As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtDays As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtDaysAllowed As TextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents txtBooksAllowed As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txtPenalty As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents colExtend As DataGridViewLinkColumn
    Friend WithEvents colReturn As DataGridViewLinkColumn
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
End Class
