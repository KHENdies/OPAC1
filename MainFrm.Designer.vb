<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainFrm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainFrm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnIssuedReturn = New System.Windows.Forms.Button()
        Me.btnPulloutBooks = New System.Windows.Forms.Button()
        Me.btnBookEntry = New System.Windows.Forms.Button()
        Me.btnBooksAcquired = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnRecords = New System.Windows.Forms.Button()
        Me.btnBorrowers = New System.Windows.Forms.Button()
        Me.btnPayment = New System.Windows.Forms.Button()
        Me.btnStats = New System.Windows.Forms.Button()
        Me.btnUserAccnt = New System.Windows.Forms.Button()
        Me.btnMaintenance = New System.Windows.Forms.Button()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblRole = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.OrangeRed
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1534, 14)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gray
        Me.Panel2.Controls.Add(Me.btnIssuedReturn)
        Me.Panel2.Controls.Add(Me.btnPulloutBooks)
        Me.Panel2.Controls.Add(Me.btnBookEntry)
        Me.Panel2.Controls.Add(Me.btnBooksAcquired)
        Me.Panel2.Controls.Add(Me.btnLogout)
        Me.Panel2.Controls.Add(Me.btnRecords)
        Me.Panel2.Controls.Add(Me.btnBorrowers)
        Me.Panel2.Controls.Add(Me.btnPayment)
        Me.Panel2.Controls.Add(Me.btnStats)
        Me.Panel2.Controls.Add(Me.btnUserAccnt)
        Me.Panel2.Controls.Add(Me.btnMaintenance)
        Me.Panel2.Controls.Add(Me.btnDashboard)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 14)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(326, 806)
        Me.Panel2.TabIndex = 1
        '
        'btnIssuedReturn
        '
        Me.btnIssuedReturn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIssuedReturn.FlatAppearance.BorderSize = 0
        Me.btnIssuedReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIssuedReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIssuedReturn.Image = CType(resources.GetObject("btnIssuedReturn.Image"), System.Drawing.Image)
        Me.btnIssuedReturn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIssuedReturn.Location = New System.Drawing.Point(0, 630)
        Me.btnIssuedReturn.Name = "btnIssuedReturn"
        Me.btnIssuedReturn.Size = New System.Drawing.Size(326, 35)
        Me.btnIssuedReturn.TabIndex = 16
        Me.btnIssuedReturn.Text = "Issued/Return"
        Me.btnIssuedReturn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnIssuedReturn.UseVisualStyleBackColor = True
        '
        'btnPulloutBooks
        '
        Me.btnPulloutBooks.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPulloutBooks.FlatAppearance.BorderSize = 0
        Me.btnPulloutBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPulloutBooks.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPulloutBooks.Image = CType(resources.GetObject("btnPulloutBooks.Image"), System.Drawing.Image)
        Me.btnPulloutBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPulloutBooks.Location = New System.Drawing.Point(0, 595)
        Me.btnPulloutBooks.Name = "btnPulloutBooks"
        Me.btnPulloutBooks.Size = New System.Drawing.Size(326, 35)
        Me.btnPulloutBooks.TabIndex = 15
        Me.btnPulloutBooks.Text = "Pullout Books"
        Me.btnPulloutBooks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPulloutBooks.UseVisualStyleBackColor = True
        '
        'btnBookEntry
        '
        Me.btnBookEntry.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBookEntry.FlatAppearance.BorderSize = 0
        Me.btnBookEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBookEntry.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBookEntry.Image = CType(resources.GetObject("btnBookEntry.Image"), System.Drawing.Image)
        Me.btnBookEntry.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBookEntry.Location = New System.Drawing.Point(0, 665)
        Me.btnBookEntry.Name = "btnBookEntry"
        Me.btnBookEntry.Size = New System.Drawing.Size(326, 35)
        Me.btnBookEntry.TabIndex = 17
        Me.btnBookEntry.Text = "Book Entry"
        Me.btnBookEntry.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBookEntry.UseVisualStyleBackColor = True
        '
        'btnBooksAcquired
        '
        Me.btnBooksAcquired.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBooksAcquired.FlatAppearance.BorderSize = 0
        Me.btnBooksAcquired.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBooksAcquired.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBooksAcquired.Image = CType(resources.GetObject("btnBooksAcquired.Image"), System.Drawing.Image)
        Me.btnBooksAcquired.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBooksAcquired.Location = New System.Drawing.Point(0, 562)
        Me.btnBooksAcquired.Name = "btnBooksAcquired"
        Me.btnBooksAcquired.Size = New System.Drawing.Size(326, 35)
        Me.btnBooksAcquired.TabIndex = 14
        Me.btnBooksAcquired.Text = "Books Acquired"
        Me.btnBooksAcquired.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBooksAcquired.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Image = CType(resources.GetObject("btnLogout.Image"), System.Drawing.Image)
        Me.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.Location = New System.Drawing.Point(0, 771)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(326, 35)
        Me.btnLogout.TabIndex = 12
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'btnRecords
        '
        Me.btnRecords.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRecords.FlatAppearance.BorderSize = 0
        Me.btnRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRecords.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecords.Image = CType(resources.GetObject("btnRecords.Image"), System.Drawing.Image)
        Me.btnRecords.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRecords.Location = New System.Drawing.Point(0, 531)
        Me.btnRecords.Name = "btnRecords"
        Me.btnRecords.Size = New System.Drawing.Size(326, 35)
        Me.btnRecords.TabIndex = 8
        Me.btnRecords.Text = "Records"
        Me.btnRecords.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRecords.UseVisualStyleBackColor = True
        '
        'btnBorrowers
        '
        Me.btnBorrowers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBorrowers.FlatAppearance.BorderSize = 0
        Me.btnBorrowers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrowers.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrowers.Image = CType(resources.GetObject("btnBorrowers.Image"), System.Drawing.Image)
        Me.btnBorrowers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBorrowers.Location = New System.Drawing.Point(0, 496)
        Me.btnBorrowers.Name = "btnBorrowers"
        Me.btnBorrowers.Size = New System.Drawing.Size(326, 35)
        Me.btnBorrowers.TabIndex = 7
        Me.btnBorrowers.Text = "Borrowers"
        Me.btnBorrowers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBorrowers.UseVisualStyleBackColor = True
        '
        'btnPayment
        '
        Me.btnPayment.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPayment.FlatAppearance.BorderSize = 0
        Me.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPayment.Image = CType(resources.GetObject("btnPayment.Image"), System.Drawing.Image)
        Me.btnPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPayment.Location = New System.Drawing.Point(0, 461)
        Me.btnPayment.Name = "btnPayment"
        Me.btnPayment.Size = New System.Drawing.Size(326, 35)
        Me.btnPayment.TabIndex = 6
        Me.btnPayment.Text = "Payment"
        Me.btnPayment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPayment.UseVisualStyleBackColor = True
        '
        'btnStats
        '
        Me.btnStats.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStats.FlatAppearance.BorderSize = 0
        Me.btnStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStats.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStats.Image = CType(resources.GetObject("btnStats.Image"), System.Drawing.Image)
        Me.btnStats.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStats.Location = New System.Drawing.Point(0, 426)
        Me.btnStats.Name = "btnStats"
        Me.btnStats.Size = New System.Drawing.Size(326, 35)
        Me.btnStats.TabIndex = 5
        Me.btnStats.Text = "Statistical"
        Me.btnStats.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnStats.UseVisualStyleBackColor = True
        '
        'btnUserAccnt
        '
        Me.btnUserAccnt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUserAccnt.FlatAppearance.BorderSize = 0
        Me.btnUserAccnt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUserAccnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUserAccnt.Image = CType(resources.GetObject("btnUserAccnt.Image"), System.Drawing.Image)
        Me.btnUserAccnt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUserAccnt.Location = New System.Drawing.Point(0, 391)
        Me.btnUserAccnt.Name = "btnUserAccnt"
        Me.btnUserAccnt.Size = New System.Drawing.Size(326, 35)
        Me.btnUserAccnt.TabIndex = 4
        Me.btnUserAccnt.Text = "User Account"
        Me.btnUserAccnt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUserAccnt.UseVisualStyleBackColor = True
        '
        'btnMaintenance
        '
        Me.btnMaintenance.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMaintenance.FlatAppearance.BorderSize = 0
        Me.btnMaintenance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaintenance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMaintenance.Image = CType(resources.GetObject("btnMaintenance.Image"), System.Drawing.Image)
        Me.btnMaintenance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMaintenance.Location = New System.Drawing.Point(0, 356)
        Me.btnMaintenance.Name = "btnMaintenance"
        Me.btnMaintenance.Size = New System.Drawing.Size(326, 35)
        Me.btnMaintenance.TabIndex = 3
        Me.btnMaintenance.Text = "Maintenance"
        Me.btnMaintenance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMaintenance.UseVisualStyleBackColor = True
        '
        'btnDashboard
        '
        Me.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashboard.Image = CType(resources.GetObject("btnDashboard.Image"), System.Drawing.Image)
        Me.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.Location = New System.Drawing.Point(0, 321)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(326, 35)
        Me.btnDashboard.TabIndex = 2
        Me.btnDashboard.Text = "Dashboard"
        Me.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDashboard.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel3.Controls.Add(Me.lblDate)
        Me.Panel3.Controls.Add(Me.lblRole)
        Me.Panel3.Controls.Add(Me.lblName)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(326, 321)
        Me.Panel3.TabIndex = 2
        '
        'lblDate
        '
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.White
        Me.lblDate.Location = New System.Drawing.Point(-3, 264)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(326, 29)
        Me.lblDate.TabIndex = 4
        Me.lblDate.Text = "mm/dd/yyyy 00:00"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRole
        '
        Me.lblRole.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRole.ForeColor = System.Drawing.Color.White
        Me.lblRole.Location = New System.Drawing.Point(-3, 235)
        Me.lblRole.Name = "lblRole"
        Me.lblRole.Size = New System.Drawing.Size(326, 29)
        Me.lblRole.TabIndex = 3
        Me.lblRole.Text = "Administrator"
        Me.lblRole.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblName
        '
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.White
        Me.lblName.Location = New System.Drawing.Point(0, 206)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(326, 29)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "Khen Chee Calimlim"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(54, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(215, 155)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'MainPanel
        '
        Me.MainPanel.BackColor = System.Drawing.Color.White
        Me.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainPanel.Location = New System.Drawing.Point(326, 14)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(1208, 806)
        Me.MainPanel.TabIndex = 2
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'MainFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1534, 820)
        Me.ControlBox = False
        Me.Controls.Add(Me.MainPanel)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "MainFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblRole As Label
    Friend WithEvents btnRecords As Button
    Friend WithEvents btnBorrowers As Button
    Friend WithEvents btnPayment As Button
    Friend WithEvents btnStats As Button
    Friend WithEvents btnUserAccnt As Button
    Friend WithEvents btnMaintenance As Button
    Friend WithEvents btnDashboard As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents MainPanel As Panel
    Friend WithEvents btnIssuedReturn As Button
    Friend WithEvents btnPulloutBooks As Button
    Friend WithEvents btnBookEntry As Button
    Friend WithEvents btnBooksAcquired As Button
    Friend WithEvents Timer1 As Timer
End Class
