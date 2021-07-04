Imports System.Data.SqlClient
Public Class frmBookEntry
#Region "Methods"
    Sub loadBooks()
        Try
            DataGridView1.Rows.Clear()
            Dim i As Integer
            con.Open()
            cmd = New SqlCommand("select book_id,book_title,category,author,yr_pub,publisher,book_price,count(book_id) as copies from tblBooks where status = 'Active' and book_title like '" & txtSearch.Text & "%'group by book_id,book_title,category,author,yr_pub,publisher,book_price", con)
            dr = cmd.ExecuteReader
            While dr.Read
                i += 1
                DataGridView1.Rows.Add(i, dr.Item("book_id").ToString, dr.Item("book_title").ToString, dr.Item("author").ToString, dr.Item("yr_pub").ToString, dr.Item("publisher").ToString, dr.Item("copies").ToString, dr.Item("category").ToString, dr.Item("book_price").ToString)
                DataGridView1.ClearSelection()
                lblRecords.Text = DataGridView1.Rows.Count
            End While
            dr.Close()
            con.Close()
        Catch ex As Exception

        End Try
    End Sub
#End Region

    Private Sub btnCatSave_Click(sender As Object, e As EventArgs) Handles btnCatSave.Click
        With frmAddBook
            .Auto_ID()
            .Auto_acc_num()
            .loadcategory()
            .ShowDialog()
        End With
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try
            Dim colname As String = DataGridView1.Columns(e.ColumnIndex).Name
            If colname = "colEdit" Then
                With frmAddBook
                    .Text = "Update Book"
                    .txtID.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
                    .cboCategory.Text = DataGridView1.Rows(e.RowIndex).Cells(7).Value.ToString
                    .txtTitle.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString
                    .txtAuthor.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString
                    .txtYrPublished.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString
                    .txtPublished.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value.ToString
                    .txtPrice.Text = DataGridView1.Rows(e.RowIndex).Cells(8).Value.ToString
                    .Label1.Select()
                    .btnSave.Enabled = False
                    .btnUpdate.Enabled = True
                    .loadcategory()
                    .ShowDialog()
                End With
            ElseIf colname = "colDel" Then
                If MsgBox("Do you want to remove this book?", vbQuestion + vbYesNo) = vbYes Then
                    con.Open()
                    cmd = New SqlCommand("delete from tblBooks where book_id like '" & DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString & "'", con)
                    cmd.ExecuteNonQuery()
                    con.Close()
                    MsgBox(DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString & Environment.NewLine & "Book has been deleted", vbInformation)
                    loadBooks()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            loadBooks()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub
End Class