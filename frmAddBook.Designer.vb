<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddBook
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddBook))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboCategory = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAuthor = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtYrPublished = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPublished = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtAccNum = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(865, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(28, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(134, 123)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(401, 25)
        Me.txtID.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 18)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Book ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 187)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 18)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Category"
        '
        'cboCategory
        '
        Me.cboCategory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cboCategory.FormattingEnabled = True
        Me.cboCategory.Location = New System.Drawing.Point(134, 185)
        Me.cboCategory.Name = "cboCategory"
        Me.cboCategory.Size = New System.Drawing.Size(401, 25)
        Me.cboCategory.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 341)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 18)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Author(s)"
        '
        'txtAuthor
        '
        Me.txtAuthor.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAuthor.Location = New System.Drawing.Point(134, 338)
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Size = New System.Drawing.Size(401, 25)
        Me.txtAuthor.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 223)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 18)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Book Title"
        '
        'txtTitle
        '
        Me.txtTitle.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitle.Location = New System.Drawing.Point(134, 223)
        Me.txtTitle.Multiline = True
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(401, 109)
        Me.txtTitle.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(14, 376)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 18)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Yr. Published"
        '
        'txtYrPublished
        '
        Me.txtYrPublished.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYrPublished.Location = New System.Drawing.Point(134, 373)
        Me.txtYrPublished.MaxLength = 4
        Me.txtYrPublished.Name = "txtYrPublished"
        Me.txtYrPublished.Size = New System.Drawing.Size(401, 25)
        Me.txtYrPublished.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(14, 411)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 18)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Publisher"
        '
        'txtPublished
        '
        Me.txtPublished.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPublished.Location = New System.Drawing.Point(134, 408)
        Me.txtPublished.Name = "txtPublished"
        Me.txtPublished.Size = New System.Drawing.Size(401, 25)
        Me.txtPublished.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(14, 446)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 18)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Book Price"
        '
        'txtPrice
        '
        Me.txtPrice.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.Location = New System.Drawing.Point(134, 443)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(401, 25)
        Me.txtPrice.TabIndex = 15
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Location = New System.Drawing.Point(555, 123)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(334, 322)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 17
        Me.PictureBox2.TabStop = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.Enabled = False
        Me.btnUpdate.FlatAppearance.BorderSize = 0
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(213, 478)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 30)
        Me.btnUpdate.TabIndex = 20
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(294, 478)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 30)
        Me.btnCancel.TabIndex = 19
        Me.btnCancel.Text = "Cancel"
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
        Me.btnSave.Location = New System.Drawing.Point(132, 478)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 30)
        Me.btnSave.TabIndex = 18
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(14, 157)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 18)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Accesion No."
        '
        'txtAccNum
        '
        Me.txtAccNum.Enabled = False
        Me.txtAccNum.Font = New System.Drawing.Font("Calibri", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccNum.Location = New System.Drawing.Point(134, 154)
        Me.txtAccNum.Name = "txtAccNum"
        Me.txtAccNum.Size = New System.Drawing.Size(401, 25)
        Me.txtAccNum.TabIndex = 21
        '
        'frmAddBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(912, 556)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtAccNum)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtYrPublished)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtPublished)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtAuthor)
        Me.Controls.Add(Me.cboCategory)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmAddBook"
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.None
        Me.Text = "Add Book"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cboCategory As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtAuthor As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtYrPublished As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPublished As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents txtAccNum As TextBox
End Class
