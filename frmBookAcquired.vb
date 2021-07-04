Imports System.Data.SqlClient
Public Class frmBookAcquired
    Dim acc_num As String
    Dim category As String
    Dim year_pub As String
    Dim publisher As String
    Dim book_price As String
#Region "Methods"
    Sub loadBooks()
        Try
            DataGridView1.Rows.Clear()
            Dim i As Integer
            con.Open()
            cmd = New SqlCommand("select distinct book_id,book_title,category,author,yr_pub,publisher,book_price from tblBooks where status = 'Active' and book_title like '" & txtSearch.Text & "%'", con)
            dr = cmd.ExecuteReader
            While dr.Read
                i += 1
                DataGridView1.Rows.Add(i, dr.Item("book_id").ToString, dr.Item("book_title").ToString, dr.Item("author").ToString, dr.Item("category").ToString, dr.Item("yr_pub").ToString, dr.Item("publisher").ToString, dr.Item("book_price").ToString)
                DataGridView1.ClearSelection()
                lblRecords.Text = DataGridView1.Rows.Count
            End While
            dr.Close()
            con.Close()
        Catch ex As Exception
            con.Close()
        End Try
    End Sub
    Sub Auto_acc_num()
        Dim id As String
        Dim int As Integer
        con.Open()
        cmd = New SqlCommand("select max(substring(acc_num,3,LEN(book_id))) as acc_num from tblBooks", con) 'AN0000001'
        id = cmd.ExecuteScalar.ToString
        If String.IsNullOrEmpty(id) Then
            id = "AN0000001"
        Else
            id.Substring(3)
            Int32.TryParse(id, int)
            int = id + 1
            id = "AN" + int.ToString("D7")
        End If
        acc_num = id
        con.Close()
    End Sub
    Sub clear()
        txtAuthor.Clear()
        txtID.Clear()
        txtTitle.Clear()
        category = Nothing
        year_pub = Nothing
        publisher = Nothing
        book_price = Nothing
        nCopies.Value = 0
    End Sub

#End Region
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try
            Dim colname As String = DataGridView1.Columns(e.ColumnIndex).Name
            If colname = "colSelect" Then
                txtID.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
                txtTitle.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString
                txtAuthor.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString
                category = DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString
                year_pub = DataGridView1.Rows(e.RowIndex).Cells(5).Value.ToString
                publisher = DataGridView1.Rows(e.RowIndex).Cells(6).Value.ToString
                book_price = DataGridView1.Rows(e.RowIndex).Cells(7).Value.ToString
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub txtID_TextChanged(sender As Object, e As EventArgs) Handles txtID.TextChanged
        QRCode(PictureBox2, txtID)
    End Sub

    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            loadBooks()
        End If
    End Sub

    Private Sub btnAddCop_Click(sender As Object, e As EventArgs) Handles btnAddCop.Click
        Try
            If is_empty(txtID.Text) = True Then Return
            If nCopies.Value <= 1 Then Return
            If MsgBox("Book ID: " & txtID.Text & Environment.NewLine & "Book Title:  " & txtTitle.Text & Environment.NewLine & "Do you want to add copies of this book?", vbQuestion + vbYesNo) = vbYes Then
                For i As Integer = 1 To CInt(nCopies.Value)
                    Auto_acc_num()
                    con.Open()
                    cmd = New SqlCommand("insert into tblBooks (book_id,acc_num,category,book_title,author,yr_pub,publisher,book_price) values (@book_id,@acc_num,@category,@book_title,@author,@yr_pub,@publisher,@book_price)", con)
                    With cmd
                        .Parameters.AddWithValue("@book_id", txtID.Text)
                        .Parameters.AddWithValue("@acc_num", acc_num)
                        .Parameters.AddWithValue("@category", category)
                        .Parameters.AddWithValue("@book_title", Trim(txtTitle.Text))
                        .Parameters.AddWithValue("@author", Trim(txtAuthor.Text))
                        .Parameters.AddWithValue("@yr_pub", year_pub)
                        .Parameters.AddWithValue("@publisher", publisher)
                        .Parameters.AddWithValue("@book_price", book_price)
                        .ExecuteNonQuery()
                    End With
                    con.Close()
                Next
                MsgBox("Book ID: " & txtID.Text & Environment.NewLine & "Book Title:  " & txtTitle.Text & Environment.NewLine & "Copies has been added", vbInformation)
                clear()
            End If
        Catch ex As Exception
            con.Close()
        End Try
    End Sub
End Class