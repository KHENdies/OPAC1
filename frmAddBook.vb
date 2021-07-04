Imports System.Data.SqlClient
Public Class frmAddBook
#Region "Methods"
    Sub Auto_ID()
        Dim id As String
        Dim int As Integer
        con.Open()
        cmd = New SqlCommand("select max(substring(book_id,3,LEN(book_id))) as book_id from tblBooks", con) 'ID0000001'
        id = cmd.ExecuteScalar.ToString
        If String.IsNullOrEmpty(id) Then
            id = "ID0000001"
        Else
            id.Substring(3)
            Int32.TryParse(id, int)
            int = id + 1
            id = "ID" + int.ToString("D7")
        End If

        txtID.Text = id
        con.Close()
    End Sub

    Sub loadcategory()
        Try
            cboCategory.Items.Clear()
            con.Open()
            cmd = New SqlCommand("select * from tblcategory", con)
            dr = cmd.ExecuteReader
            While dr.Read
                cboCategory.Items.Add(dr.Item("category").ToString)
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
        txtAccNum.Text = id
        con.Close()
    End Sub

    Sub clear()
        Auto_ID()
        Auto_acc_num()
        cboCategory.SelectedIndex = -1
        txtTitle.Clear()
        txtAuthor.Clear()
        txtYrPublished.Clear()
        txtPublished.Clear()
        txtPrice.Clear()
        btnSave.Enabled = True
        btnUpdate.Enabled = False
    End Sub
#End Region
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Dispose()
    End Sub

    Private Sub ComboBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboCategory.KeyPress
        e.Handled = True
    End Sub

    Private Sub txtPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrice.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8, 47 To 58
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub btnCatSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If is_empty(cboCategory.Text) = True Then Return
            If is_empty(txtTitle.Text) = True Then Return
            If is_empty(txtAuthor.Text) = True Then Return
            If is_empty(txtYrPublished.Text) = True Then Return
            If is_empty(txtPublished.Text) = True Then Return
            If is_empty(txtPrice.Text) = True Then Return

            If MsgBox("Do you want to add this book?", vbQuestion + vbYesNo) = vbYes Then
                con.Open()
                cmd = New SqlCommand("insert into tblBooks (book_id,acc_num,category,book_title,author,yr_pub,publisher,book_price) values (@book_id,@acc_num,@category,@book_title,@author,@yr_pub,@publisher,@book_price)", con)
                With cmd
                    .Parameters.AddWithValue("@book_id", txtID.Text)
                    .Parameters.AddWithValue("@acc_num", txtAccNum.Text)
                    .Parameters.AddWithValue("@category", cboCategory.Text)
                    .Parameters.AddWithValue("@book_title", Trim(txtTitle.Text))
                    .Parameters.AddWithValue("@author", Trim(txtAuthor.Text))
                    .Parameters.AddWithValue("@yr_pub", txtYrPublished.Text)
                    .Parameters.AddWithValue("@publisher", Trim(txtPublished.Text))
                    .Parameters.AddWithValue("@book_price", CInt(txtPrice.Text))
                    .ExecuteNonQuery()
                End With
                con.Close()
                MsgBox("New book is added", vbInformation)
                clear()
                frmBookEntry.loadBooks()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
            con.Close()
        End Try
    End Sub

    Private Sub txtYrPublished_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtYrPublished.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8, 47 To 58
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        clear()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            If is_empty(cboCategory.Text) = True Then Return
            If is_empty(txtTitle.Text) = True Then Return
            If is_empty(txtAuthor.Text) = True Then Return
            If is_empty(txtYrPublished.Text) = True Then Return
            If is_empty(txtPublished.Text) = True Then Return
            If is_empty(txtPrice.Text) = True Then Return

            If MsgBox("Do you want to update this book?", vbQuestion + vbYesNo) = vbYes Then
                con.Open()
                cmd = New SqlCommand("update tblBooks set category=@category,book_title=@book_title,author=@author,yr_pub=@yr_pub,publisher=@publisher,book_price=@book_price where book_id like '" & txtID.Text & "'", con)
                With cmd
                    .Parameters.AddWithValue("@category", cboCategory.Text)
                    .Parameters.AddWithValue("@book_title", Trim(txtTitle.Text))
                    .Parameters.AddWithValue("@author", Trim(txtAuthor.Text))
                    .Parameters.AddWithValue("@yr_pub", txtYrPublished.Text)
                    .Parameters.AddWithValue("@publisher", Trim(txtPublished.Text))
                    .Parameters.AddWithValue("@book_price", CInt(txtPrice.Text))
                    .ExecuteNonQuery()
                End With
                con.Close()
                MsgBox(txtID.Text & Environment.NewLine &
                    "Has been updated", vbInformation)
                Me.Dispose()
                frmBookEntry.loadBooks()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
            con.Close()
        End Try
    End Sub

    Private Sub txtAccNum_TextChanged(sender As Object, e As EventArgs) Handles txtAccNum.TextChanged
        QRCode(PictureBox2, txtAccNum)
    End Sub
End Class