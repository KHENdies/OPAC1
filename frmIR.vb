Imports System.Data.SqlClient
Public Class frmIR
#Region "Methods"
    Sub loadBorrowers()
        Try
            con.Open()
            cmd = New SqlCommand("select sex,dob,contact,address,concat(lname,', ',fname,' ',mname) as name from tblBorrowers where bid like '" & txtBorrowersID.Text & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                txtBorrowersID.Invoke(Sub() txtBorrowersName.Text = dr.Item("name").ToString)
                txtSex.Invoke(Sub() txtSex.Text = dr.Item("sex").ToString)
                txtDOB.Invoke(Sub() txtDOB.Text = Format(dr.Item("dob"), "yyyy-MM-dd"))
                txtContact.Invoke(Sub() txtContact.Text = dr.Item("contact").ToString)
                txtAddress.Invoke(Sub() txtAddress.Text = dr.Item("address").ToString)
            End If
            dr.Close()
            con.Close()
            loadIR()
        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Sub loadBooks()
        Try
            con.Open()
            cmd = New SqlCommand("select book_id,book_title,author,book_price,category from tblBooks where acc_num like '" & txtAccNum.Text & "' and status like 'Active'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                txtBookID.Invoke(Sub() txtBookID.Text = dr.Item("book_id").ToString)
                txtBookTitle.Invoke(Sub() txtBookTitle.Text = dr.Item("book_title").ToString)
                txtAuthor.Invoke(Sub() txtAuthor.Text = dr.Item("author").ToString)
                txtBookPrice.Invoke(Sub() txtBookPrice.Text = Format(CDbl(dr.Item("book_price")), "#,##0.00"))
                txtCategory.Invoke(Sub() txtCategory.Text = dr.Item("category").ToString)
            End If
            con.Close()
        Catch ex As Exception
            con.Close()
        End Try
    End Sub
    Sub clearBook()
        txtAccNum.Clear()
        txtAuthor.Clear()
        txtBookID.Clear()
        txtBookTitle.Clear()
        txtBookPrice.Clear()
        txtCategory.Clear()
        txtDays.Clear()
    End Sub
    Sub loadIR()
        Try
            DataGridView1.Invoke(Sub() DataGridView1.Rows.Clear())
            Dim i As Integer
            con.Open()
            cmd = New SqlCommand("select * from vw_IR where bid like '" & txtBorrowersID.Text & "'", con)
            dr = cmd.ExecuteReader
            While dr.Read
                i += 1
                Dim overdue As String
                Dim penalty As String
                If Not IsDBNull(dr.Item("overdue")) Then overdue = Format(dr.Item("overdue"), "yyyy-MM-dd") Else overdue = "None"
                If Not IsDBNull(dr.Item("overdue")) Then penalty = Format(CDbl(dr.Item("penalty")), "#,##0.00") Else penalty = "None"
                DataGridView1.Invoke(Sub() DataGridView1.Rows.Add(dr.Item("id").ToString, i, dr.Item("book_id").ToString, dr.Item("acc_num").ToString, dr.Item("book_title").ToString, dr.Item("author").ToString, Format(dr.Item("date_borrowed"), "yyyy-MM-dd"), Format(dr.Item("date_due"), "yyyy-MM-dd"), overdue, penalty, dr.Item("borrow_status").ToString))
                DataGridView1.Invoke(Sub() DataGridView1.ClearSelection())
            End While

            con.Close()
        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
#End Region
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub

    Private Sub txtNumDays_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDays.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8, 48 To 58
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub txtBorrowersID_TextChanged(sender As Object, e As EventArgs) Handles txtBorrowersID.TextChanged
        If Not BackgroundWorker1.IsBusy Then BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        loadBorrowers()
    End Sub

    Private Sub txtAccNum_TextChanged(sender As Object, e As EventArgs) Handles txtAccNum.TextChanged
        If Not BackgroundWorker2.IsBusy Then BackgroundWorker2.RunWorkerAsync()
    End Sub

    Private Sub BackgroundWorker2_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker2.DoWork
        loadBooks()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If is_empty(txtBorrowersID.Text) = True Then Return
            If is_empty(txtAccNum.Text) = True Then Return
            If is_empty(txtDays.Text) = True Then Return
            If txtDays.Text = "0" Then Return
            Dim book_allowed As Integer = 0
            For i As Integer = 0 To DataGridView1.Rows.Count - 1
                If DataGridView1.Rows(i).Cells(10).Value = "Borrowed" Then book_allowed += 1
            Next
            If book_allowed >= Int32.Parse(txtBooksAllowed.Text) Then
                MsgBox("Error! Maximum of " & txtBooksAllowed.Text & " books only!", vbExclamation)
                Return
            End If

            If Int32.Parse(txtDays.Text) > Int32.Parse(txtDaysAllowed.Text) Then
                MsgBox("Error! Maximum of " & txtDaysAllowed.Text & " days only!", vbExclamation)
                Return
            End If
            Dim date_borrowed As Date = Now.ToString("yyyy-MM-dd")
            Dim date_due As Date = date_borrowed.AddDays(CDbl(txtDays.Text))
            If MsgBox(txtBookTitle.Text & Environment.NewLine & "Book Id: " & txtBookID.Text & Environment.NewLine & "Acc No.: " & txtAccNum.Text & Environment.NewLine & "Author: " & txtAuthor.Text & Environment.NewLine & "Date borrowed: " & date_borrowed & Environment.NewLine & "Due Date: " & date_due & Environment.NewLine & "Plase confirm transaction", vbQuestion + vbYesNo) = vbYes Then
                con.Open()
                cmd = New SqlCommand(" insert into tblIR (bid,book_id,acc_num,days,date_borrowed,date_due) values (@bid,@book_id,@acc_num,@days,@date_borrowed,@date_due)", con)
                With cmd
                    .Parameters.AddWithValue("@bid", txtBorrowersID.Text)
                    .Parameters.AddWithValue("@book_id", txtBookID.Text)
                    .Parameters.AddWithValue("@acc_num", txtAccNum.Text)
                    .Parameters.AddWithValue("@days", txtDays.Text)
                    .Parameters.AddWithValue("@date_borrowed", Now.ToString("yyyy-MM-dd"))
                    .Parameters.AddWithValue("@date_due", date_due)
                    .ExecuteNonQuery()
                End With
                con.Close()
                updateBooks("update tblBooks set status='Borrowed' where acc_num like '" & txtAccNum.Text & "'")
                MsgBox("Transaction has been completed", vbInformation)
                autoComplete(txtBorrowersID, "select bid from tblBorrowers", "bid")
                autoComplete(txtAccNum, "select acc_num from tblBooks where status like 'Active'", "book_id")
                loadIR()
                clearBook()
            End If

        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        clearBook()
    End Sub
End Class