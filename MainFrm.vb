Public Class MainFrm
#Region "Methods"
    Sub Close_All_Forms()
        For i = My.Application.OpenForms.Count - 1 To 0 Step -1
            If My.Application.OpenForms(i) IsNot Me Then
                My.Application.OpenForms(i).Dispose()
            End If
        Next
    End Sub
#End Region

    Private Sub MainFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = Screen.PrimaryScreen.WorkingArea.Width
        Me.Height = Screen.PrimaryScreen.WorkingArea.Height
        Timer1.Enabled = True
        opencon()
    End Sub

    Private Sub btnMaintenance_Click(sender As Object, e As EventArgs) Handles btnMaintenance.Click
        With frmMaintenance
            .loadcategory()
            .loadProgram()
            .loadSetting()
            .ShowDialog()

        End With
    End Sub

    Private Sub btnBookEntry_Click(sender As Object, e As EventArgs) Handles btnBookEntry.Click
        For Each f As Form In My.Application.OpenForms
            If f.Name = "frmBookEntry" Then Return
        Next
        Close_All_Forms()
        With frmBookEntry
            .TopLevel = False
            MainPanel.Controls.Add(frmBookEntry)
            .loadBooks()
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnBooksAcquired_Click(sender As Object, e As EventArgs) Handles btnBooksAcquired.Click
        For Each f As Form In My.Application.OpenForms
            If f.Name = "frmBookAcquired" Then Return
        Next
        Close_All_Forms()
        With frmBookAcquired
            .TopLevel = False
            MainPanel.Controls.Add(frmBookAcquired)
            .loadBooks()
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnBorrowers_Click(sender As Object, e As EventArgs) Handles btnBorrowers.Click
        For Each f As Form In My.Application.OpenForms
            If f.Name = "frmBorrower" Then Return
        Next
        Close_All_Forms()
        With frmBorrower
            .TopLevel = False
            MainPanel.Controls.Add(frmBorrower)
            .loadBorrowers()
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnIssuedReturn_Click(sender As Object, e As EventArgs) Handles btnIssuedReturn.Click
        For Each f As Form In My.Application.OpenForms
            If f.Name = "frmIR" Then Return
        Next
        Close_All_Forms()
        With frmIR
            .TopLevel = False
            MainPanel.Controls.Add(frmIR)
            loadSettings(.txtDaysAllowed.Text, .txtBooksAllowed.Text, .txtPenalty.Text)
            autoComplete(.txtBorrowersID, "select bid from tblBorrowers", "bid")
            autoComplete(.txtAccNum, "select acc_num from tblBooks where status like 'Active'", "book_id")
            .txtBorrowersID.Select()
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDate.Text = Date.Now.ToString("MM-dd-yyyy hh:mm:ss")
    End Sub
End Class
