Imports System.Data.SqlClient
Public Class frmMaintenance
    Dim id As String
    'connecctions'
#Region "Load Data"
    Sub loadcategory()
        Try
            DataGridView1.Rows.Clear()
            Dim i As Integer
            con.Open()
            cmd = New SqlCommand("select * from tblCategory", con)
            dr = cmd.ExecuteReader
            While dr.Read
                i += 1
                DataGridView1.Rows.Add(i, dr.Item("category").ToString)
                DataGridView1.ClearSelection()
            End While
            dr.Close()
            con.Close()
        Catch ex As Exception
            con.Close()
        End Try
    End Sub

    Sub loadProgram()

        Try
            DataGridView2.Rows.Clear()
            Dim i As Integer
            con.Open()
            cmd = New SqlCommand("select * from tblProgram", con)
            dr = cmd.ExecuteReader
            While dr.Read
                i += 1
                DataGridView2.Rows.Add(i, dr.Item("program").ToString, dr.Item("description").ToString)
                DataGridView2.ClearSelection()
            End While
            dr.Close()
            con.Close()
        Catch ex As Exception
            con.Close()
        End Try
    End Sub

    Sub loadSetting()
        Try
            con.Open()
            cmd = New SqlCommand("select * from tblSettings", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                txtDaysAllowed.Text = dr.Item("day_allowed").ToString
                txtBooksAllowed.Text = dr.Item("books_allowed").ToString
                txtPenalty.Text = Format(dr.Item("penalty"), "#.##0.00").ToString
            End If
            dr.Close()
            con.Close()
        Catch ex As Exception
            con.Close()
        End Try
    End Sub
#End Region
    'end connnections'

    'Start of Category option'
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCatSave.Click
        Try
            If is_empty(txtCategory.Text) = True Then Return
            If MsgBox("Do you want to save this category?", vbQuestion + vbYesNo) = vbYes Then
                con.Open()
                cmd = New SqlCommand("insert into tblCategory values (@category)", con)
                cmd.Parameters.AddWithValue("@category", Trim(txtCategory.Text))
                cmd.ExecuteNonQuery()
                con.Close()
                MsgBox("Category has been saved!", vbInformation)
                txtCategory.Clear()
                loadcategory()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
            con.Close()
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try
            Dim colname As String = DataGridView1.Columns(e.ColumnIndex).Name
            If colname = "colEdit" Then
                btnCatSave.Enabled = False
                btnCatUpdate.Enabled = True
                txtCategory.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
                id = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
            ElseIf colname = "colDel" Then
                If MsgBox("Delete this record?", vbQuestion + vbYesNo) = vbYes Then
                    con.Open()
                    cmd = New SqlCommand("delete from tblCategory where category like '" & DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString & "'", con)
                    cmd.ExecuteNonQuery()
                    con.Close()
                    MsgBox("Record has been deleted", vbInformation)
                    Button2.PerformClick()
                    loadcategory()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
            con.Close()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtCategory.Clear()
        btnCatSave.Enabled = True
        btnCatUpdate.Enabled = False

    End Sub

    Private Sub btnCatUpdate_Click(sender As Object, e As EventArgs) Handles btnCatUpdate.Click
        Try
            If is_empty(txtCategory.Text) = True Then Return
            If MsgBox("Do you want to update this category?", vbQuestion + vbYesNo) = vbYes Then
                con.Open()
                cmd = New SqlCommand("update tblCategory set category=@category where category like '" & id & "' ", con)
                    cmd.Parameters.AddWithValue("@category", Trim(txtCategory.Text))
                cmd.ExecuteNonQuery()
                con.Close()
                MsgBox("Category has been updated!", vbInformation)
                Button2.PerformClick()
                loadcategory()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
            con.Close()
        End Try
    End Sub

    'End of Category'

    'Start of Program'
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btnProgSave.Click
        Try
            If is_empty(txtProgram.Text) = True Then Return
            If MsgBox("Do you want to save this program", vbQuestion + vbYesNo) = vbYes Then
                con.Open()
                cmd = New SqlCommand("insert into tblProgram values (@program,@description)", con)
                With cmd
                    .Parameters.AddWithValue("@program", Trim(txtProgram.Text))
                    .Parameters.AddWithValue("@description", Trim(txtDescription.Text))
                    .ExecuteNonQuery()
                End With
                MsgBox("Program has been saved", vbInformation)
                con.Close()
                Button3.PerformClick()
                loadProgram()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
            con.Close()
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        txtProgram.Clear()
        txtDescription.Clear()
        btnProgSave.Enabled = True
        btnProgUpdate.Enabled = False
    End Sub

    Private Sub datagridview2_cellcontentclick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        Try
            Dim colname As String = DataGridView2.Columns(e.ColumnIndex).Name
            If colname = "clmEdit" Then
                txtProgram.Text = DataGridView2.Rows(e.RowIndex).Cells(1).Value.ToString
                txtDescription.Text = DataGridView2.Rows(e.RowIndex).Cells(2).Value.ToString
                id = DataGridView2.Rows(e.RowIndex).Cells(1).Value.ToString
                btnProgSave.Enabled = False
                btnProgUpdate.Enabled = True
            ElseIf colname = "clmDel" Then
                If MsgBox("Delete this Record", vbQuestion + vbYesNo) = vbYes Then
                    con.Open()
                    cmd = New SqlCommand("delete from tblProgram where program like'" & DataGridView2.Rows(e.RowIndex).Cells(1).Value.ToString & "'", con)
                    cmd.ExecuteNonQuery()
                    con.Close()
                    MsgBox("Record has been deleted", vbInformation)
                    Button3.PerformClick()
                    loadProgram()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
            con.Close()
        End Try
    End Sub

    Private Sub btnProgUpdate_Click(sender As Object, e As EventArgs) Handles btnProgUpdate.Click
        Try
            If is_empty(txtProgram.Text) = True Then Return
            If is_empty(txtDescription.Text) = True Then Return
            If MsgBox("Do you want to update this program", vbQuestion + vbYesNo) = vbYes Then
                con.Open()
                cmd = New SqlCommand("update tblProgram set program=@program,description=@description where program like'" & id & "' ", con)
                With cmd
                    .Parameters.AddWithValue("@program", Trim(txtProgram.Text))
                    .Parameters.AddWithValue("@description", Trim(txtDescription.Text))
                    .ExecuteNonQuery()
                End With
                MsgBox("Program has been updated", vbInformation)
                con.Close()
                Button3.PerformClick()
                loadProgram()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
            con.Close()
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        txtDaysAllowed.Clear()
        txtBooksAllowed.Clear()
        txtPenalty.Clear()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            If is_empty(txtDaysAllowed.Text) = True Then Return
            If is_empty(txtBooksAllowed.Text) = True Then Return
            If is_empty(txtPenalty.Text) = True Then Return
            If MsgBox("Do you want to update setting?", vbQuestion + vbYesNo) = vbYes Then
                con.Open()
                cmd = New SqlCommand("update tblSettings set day_allowed=@day_allowed,books_allowed=@books_allowed,penalty=@penalty", con)
                With cmd
                    .Parameters.AddWithValue("@day_allowed", CInt(txtDaysAllowed.Text))
                    .Parameters.AddWithValue("@books_allowed", CInt(txtBooksAllowed.Text))
                    .Parameters.AddWithValue("@penalty", CDbl(txtPenalty.Text))
                    .ExecuteNonQuery()
                End With
                MsgBox("Settings has been updated", vbInformation)
                con.Close()
                loadSetting()
                frmIR.txtDaysAllowed.Text = txtDaysAllowed.Text
                frmIR.txtBooksAllowed.Text = txtBooksAllowed.Text
                frmIR.txtPenalty.Text = txtPenalty.Text
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
            con.Close()
        End Try
    End Sub

    Private Sub txtBooksAllowed_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPenalty.KeyPress, txtDaysAllowed.KeyPress, txtBooksAllowed.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8, 46, 48 To 57
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Dispose()
    End Sub
End Class
