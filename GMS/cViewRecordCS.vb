'Imports System.Data.SqlClient
Imports System.Data.SQLite
Imports System.Runtime.InteropServices

Public Class cViewRecordCS
    Dim dbpath As String
    Dim TableName As String = "tableCS"
    Dim snum, fname, mname, lname, cccemail, gender, ylvl, section, stat As String
    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim SQLiteCon As New SQLiteConnection(dbpath)

        Try
            SQLiteCon.Open()
        Catch ex As Exception
            SQLiteCon.Dispose()
            SQLiteCon = Nothing
            MsgBox(ex.Message)
            Exit Sub
        End Try

        If DataGridView1.RowCount = 0 Then
            MsgBox("Cannot delete, table data is empty", MsgBoxStyle.Critical, "Failed")
            Return
        End If

        If DataGridView1.SelectedRows.Count = 0 Then
            MsgBox("Cannot delete, select the table data to be deleted", MsgBoxStyle.Critical, "Failed")
            Return
        End If

        If MsgBox("Delete record?", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, "Confirmation") = MsgBoxResult.Cancel Then Return

        Try
            If AllCellsSelected(DataGridView1) = True Then
                ExecuteNonQuery("delete from " & TableName & "", SQLiteCon)
                SQLiteCon.Close()
                SQLiteCon.Dispose()
                SQLiteCon = Nothing

                btnRefresh_Click(sender, e)
                Return
            End If

            For Each row As DataGridViewRow In DataGridView1.SelectedRows
                If row.Selected = True Then
                    ExecuteNonQuery("delete from " & TableName & " where snum='" & row.DataBoundItem(0).ToString & "'", SQLiteCon)
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        MessageBox.Show("Deleted Successfully!")
        SQLiteCon.Close()
        SQLiteCon.Dispose()
        SQLiteCon = Nothing

        btnRefresh_Click(sender, e)
    End Sub

    Private Sub btnAddd_Click(sender As Object, e As EventArgs) Handles btnAddd.Click
        If txtSnum.Text = "" And txtFname.Text = "" And txtLname.Text = "" And txtCCCemail.Text = "" And cmbGender.Text = "- choose gender -" And cmbYear.Text = "- choose year level -" And cmbStatus.Text = "- choose student status -" Then
            MessageBox.Show("All data has not been filled, please fill in", "Failed")
            Return
        End If

        If txtSnum.Text = "" Then
            MessageBox.Show("Student Number has not been filled, please fill in Student Number", "Failed")
            Return
        End If

        If txtFname.Text = "" Then
            MessageBox.Show("First Name has not been filled, please fill in First Name", "Failed")
            Return
        End If

        If txtLname.Text = "" Then
            MessageBox.Show("Last Name has not been filled, please fill in Last Name", "Failed")
            Return
        End If

        If txtCCCemail.Text = "" Then
            MessageBox.Show("CCC Email has not been filled, please fill in CCC Email", "Failed")
            Return
        End If

        If cmbGender.Text = "- choose gender -" Then
            MessageBox.Show("Gender not selected, please select Gender", "Failed")
            Return
        End If

        If cmbYear.Text = "- choose year level -" Then
            MessageBox.Show("Year Level not selected, please select Year Level", "Failed")
            Return
        End If

        If txtSection.Text = "" Then
            MessageBox.Show("Section not selected, please select Section", "Failed")
            Return
        End If

        If cmbStatus.Text = "- choose student status -" Then
            MessageBox.Show("Student Status not selected, please select Student Status", "Failed")
            Return
        End If

        Dim SQLiteCon As New SQLiteConnection(dbpath)

        Try
            SQLiteCon.Open()
        Catch ex As Exception
            SQLiteCon.Dispose()
            SQLiteCon = Nothing
            MsgBox(ex.Message)
            Exit Sub
        End Try

        'Try
        '    ExecuteNonQuery("insert into " & TableName & " set snum='" & txtSnum.Text & "',fname='" & txtFname.Text _
        '                    & "',mname='" & txtMname.Text & "',lname='" & txtLname.Text & "',cccemail='" & txtCCCemail.Text & "',Gender='" & cmbGender.Text & "',ylevel='" & cmbYear.Text & "',section='" & txtSection.Text & "',sstat='" & cmbStatus.Text & "'", SQLiteCon)
        '    MsgBox("Insert Data Successfully")
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try

        Try
            ExecuteNonQuery("insert into " & TableName & " (snum,fname,mname,lname,cccemail,gender,ylevel,section,sstat) values ('" & txtSnum.Text & "','" & txtFname.Text _
                            & "','" & txtMname.Text & "','" & txtLname.Text & "','" & txtCCCemail.Text & "','" & cmbGender.Text & "','" & cmbYear.Text & "','" & txtSection.Text & "','" & cmbStatus.Text & "')", SQLiteCon)
            MsgBox("Insert Data Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        SQLiteCon.Close()
        SQLiteCon.Dispose()
        SQLiteCon = Nothing

        btnRefresh_Click(sender, e)
        btnClear_Click(sender, e)
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        TextBox1.Text = ""
        TextBox1.CharacterCasing = CharacterCasing.Normal
        SendMessage(Me.TextBox1.Handle, &H1501, 0, "Search...")

        Dim SQLiteCon As New SQLiteConnection(dbpath)

        Try
            SQLiteCon.Open()
        Catch ex As Exception
            SQLiteCon.Dispose()
            SQLiteCon = Nothing
            MsgBox(ex.Message)
            Exit Sub
        End Try

        Dim TableDB As New DataTable

        Try
            LoadDB("select*from " & TableName & " order by snum", TableDB, SQLiteCon)
            DataGridView1.DataSource = Nothing
            DataGridView1.DataSource = TableDB
            DataGridView1.ClearSelection()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        TableDB.Dispose()
        TableDB = Nothing
        SQLiteCon.Close()
        SQLiteCon.Dispose()
        SQLiteCon = Nothing
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim SearchCMD As String
        If TextBox1.Text = Nothing Then
            TextBox1.CharacterCasing = CharacterCasing.Normal
            SendMessage(Me.TextBox1.Handle, &H1501, 0, "Search...")
        Else
            TextBox1.CharacterCasing = CharacterCasing.Upper
        End If

        If CheckBoxSearchbyName.Checked = True Then
            If TextBox1.Text = Nothing Then
                SearchCMD = "select*from " & TableName & " order by fname'" & TextBox1.Text & "%'"
            Else
                SearchCMD = "select*from " & TableName & " where fname like'" & TextBox1.Text & "%'"
                SearchCMD = "select*from " & TableName & " where mname like'" & TextBox1.Text & "%'"
                SearchCMD = "select*from " & TableName & " where lname like'" & TextBox1.Text & "%'"
            End If
        End If

        If CheckBoxSearchbySnum.Checked = True Then
            If TextBox1.Text = Nothing Then
                SearchCMD = "select*from " & TableName & " order by fname"
            Else
                SearchCMD = "select*from " & TableName & " where snum like'" & TextBox1.Text & "%'"
            End If
        End If

        Dim SQLiteCon As New SQLiteConnection(dbpath)

        Try
            SQLiteCon.Open()
        Catch ex As Exception
            SQLiteCon.Dispose()
            SQLiteCon = Nothing
            MsgBox(ex.Message)
            Exit Sub
        End Try

        Dim TableCS As New DataTable

        Try
            LoadDB(SearchCMD, TableCS, SQLiteCon)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        If TableCS.Rows.Count > 0 Then
            DataGridView1.DataSource = Nothing
            DataGridView1.DataSource = TableCS
        End If
        TableCS.Dispose()
        TableCS = Nothing
        SQLiteCon.Close()
        SQLiteCon.Dispose()
        SQLiteCon = Nothing
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        If AllCellsSelected(DataGridView1) = False Then
            btnAddd.Enabled = False
            btnUpdate.Enabled = True
            pnlInfo.Show()
            btnAddd.Enabled = False

            txtSnum.Text = snum
            txtFname.Text = fname
            txtMname.Text = mname
            txtLname.Text = lname
            txtCCCemail.Text = cccemail
            cmbGender.Text = gender
            cmbYear.Text = ylvl
            txtSection.Text = section
            cmbStatus.Text = stat
        Else
            MsgBox("Can not edit because table row is selected all. Please choose one to edit.", MsgBoxStyle.Critical, "Failed")
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtSnum.Clear()
        txtFname.Clear()
        txtMname.Clear()
        txtLname.Clear()
        txtCCCemail.Clear()
        cmbGender.SelectedItem = "- choose gender -"
        cmbYear.SelectedItem = "- choose year level -"
        txtSection.Clear()
        cmbStatus.SelectedItem = "- choose student status -"
        btnAdd.Enabled = True
        btnUpdate.Enabled = False
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        DataGridView1.SelectAll()
    End Sub

    Private Sub CheckBoxSearchbySnum_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxSearchbySnum.CheckedChanged
        If CheckBoxSearchbySnum.Checked = True Then
            CheckBoxSearchbyName.Checked = False
            TextBox1.Enabled = True
        End If
        If CheckBoxSearchbySnum.Checked = False Then
            CheckBoxSearchbyName.Checked = True
            TextBox1.Enabled = True
        End If
    End Sub

    Private Sub CheckBoxSearchbyName_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxSearchbyName.CheckedChanged
        If CheckBoxSearchbyName.Checked = True Then
            CheckBoxSearchbySnum.Checked = False
            TextBox1.Enabled = True
        End If
        If CheckBoxSearchbyName.Checked = False Then
            CheckBoxSearchbySnum.Checked = True
            TextBox1.Enabled = True
        End If
    End Sub

    Private Sub cViewRecord_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick
        DataGridView1.ClearSelection()
        SendMessage(Me.TextBox1.Handle, &H1501, 0, "Search...")
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        btnDelete_Click(sender, e)
    End Sub

    Private Sub btn1st_Click(sender As Object, e As EventArgs) Handles btn1st.Click
        'Dim SearchCMD As String
        'SearchCMD = "select*from " & TableName & "First Year"

        Dim TableDB As New DataTable
        Dim SQLiteCon As New SQLiteConnection(dbpath)
        Try
            LoadDB("select*from " & TableName & " where ylevel = 'First Year'", TableDB, SQLiteCon)
            DataGridView1.DataSource = Nothing
            DataGridView1.DataSource = TableDB
            DataGridView1.ClearSelection()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        TableDB.Dispose()
        TableDB = Nothing
        SQLiteCon.Close()
        SQLiteCon.Dispose()
        SQLiteCon = Nothing
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtSnum.Text = "" Then
            MessageBox.Show("Student Number has not been filled, please fill in Student Number", "Failed")
            Return
        End If

        If txtFname.Text = "" Then
            MessageBox.Show("First Name has not been filled, please fill in First Name", "Failed")
            Return
        End If

        If txtLname.Text = "" Then
            MessageBox.Show("Last Name has not been filled, please fill in Last Name", "Failed")
            Return
        End If

        If txtCCCemail.Text = "" Then
            MessageBox.Show("CCC Email has not been filled, please fill in CCC Email", "Failed")
            Return
        End If

        If cmbGender.Text = "- choose gender -" Then
            MessageBox.Show("Gender not selected, please select Gender", "Failed")
            Return
        End If

        If cmbYear.Text = "- choose year level -" Then
            MessageBox.Show("Year Level not selected, please select Year Level", "Failed")
            Return
        End If

        If txtSection.Text = "" Then
            MessageBox.Show("Section not selected, please select Section", "Failed")
            Return
        End If

        If cmbStatus.Text = "- choose student status -" Then
            MessageBox.Show("Student Status not selected, please select Student Status", "Failed")
            Return
        End If

        Dim SQLiteCon As New SQLiteConnection(dbpath)

        Try
            SQLiteCon.Open()
        Catch ex As Exception
            SQLiteCon.Dispose()
            SQLiteCon = Nothing
            MsgBox(ex.Message)
            Exit Sub
        End Try

        Try
            ExecuteNonQuery("update " & TableName & " set fname='" & txtFname.Text _
                            & "',mname='" & txtMname.Text & "',lname='" & txtLname.Text & "',cccemail='" & txtCCCemail.Text & "',gender='" & cmbGender.Text _
                            & "',ylevel='" & cmbYear.Text & "',section='" & txtSection.Text & "',sstat='" & cmbStatus.Text & "' where snum='" & txtSnum.Text _
                            & "'", SQLiteCon)
            MsgBox("Update Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        SQLiteCon.Close()
        SQLiteCon.Dispose()
        SQLiteCon = Nothing


        btnRefresh_Click(sender, e)
        btnClear_Click(sender, e)
    End Sub

    Private Sub btn2nd_Click(sender As Object, e As EventArgs) Handles btn2nd.Click
        Dim TableDB As New DataTable
        Dim SQLiteCon As New SQLiteConnection(dbpath)
        Try
            LoadDB("select*from " & TableName & " where ylevel = 'Second Year'", TableDB, SQLiteCon)
            DataGridView1.DataSource = Nothing
            DataGridView1.DataSource = TableDB
            DataGridView1.ClearSelection()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        TableDB.Dispose()
        TableDB = Nothing
        SQLiteCon.Close()
        SQLiteCon.Dispose()
        SQLiteCon = Nothing
    End Sub

    Private Sub btn3rd_Click(sender As Object, e As EventArgs) Handles btn3rd.Click
        Dim TableDB As New DataTable
        Dim SQLiteCon As New SQLiteConnection(dbpath)
        Try
            LoadDB("select*from " & TableName & " where ylevel = 'Third Year'", TableDB, SQLiteCon)
            DataGridView1.DataSource = Nothing
            DataGridView1.DataSource = TableDB
            DataGridView1.ClearSelection()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        TableDB.Dispose()
        TableDB = Nothing
        SQLiteCon.Close()
        SQLiteCon.Dispose()
        SQLiteCon = Nothing
    End Sub

    Private Sub btn4th_Click(sender As Object, e As EventArgs) Handles btn4th.Click
        Dim TableDB As New DataTable
        Dim SQLiteCon As New SQLiteConnection(dbpath)
        Try
            LoadDB("select*from " & TableName & " where ylevel = 'Fourth Year'", TableDB, SQLiteCon)
            DataGridView1.DataSource = Nothing
            DataGridView1.DataSource = TableDB
            DataGridView1.ClearSelection()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        TableDB.Dispose()
        TableDB = Nothing
        SQLiteCon.Close()
        SQLiteCon.Dispose()
        SQLiteCon = Nothing
    End Sub

    Private Sub btnRegular_Click(sender As Object, e As EventArgs) Handles btnRegular.Click
        Dim TableDB As New DataTable
        Dim SQLiteCon As New SQLiteConnection(dbpath)
        Try
            LoadDB("select*from " & TableName & " where sstat = 'Regular'", TableDB, SQLiteCon)
            DataGridView1.DataSource = Nothing
            DataGridView1.DataSource = TableDB
            DataGridView1.ClearSelection()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        TableDB.Dispose()
        TableDB = Nothing
        SQLiteCon.Close()
        SQLiteCon.Dispose()
        SQLiteCon = Nothing
    End Sub

    Private Sub btnWorking_Click(sender As Object, e As EventArgs) Handles btnWorking.Click
        Dim TableDB As New DataTable
        Dim SQLiteCon As New SQLiteConnection(dbpath)
        Try
            LoadDB("select*from " & TableName & " where sstat = 'Irregular'", TableDB, SQLiteCon)
            DataGridView1.DataSource = Nothing
            DataGridView1.DataSource = TableDB
            DataGridView1.ClearSelection()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        TableDB.Dispose()
        TableDB = Nothing
        SQLiteCon.Close()
        SQLiteCon.Dispose()
        SQLiteCon = Nothing
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim TableDB As New DataTable
        Dim SQLiteCon As New SQLiteConnection(dbpath)
        Try
            LoadDB("select*from " & TableName & " where sstat = 'Working'", TableDB, SQLiteCon)
            DataGridView1.DataSource = Nothing
            DataGridView1.DataSource = TableDB
            DataGridView1.ClearSelection()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        TableDB.Dispose()
        TableDB = Nothing
        SQLiteCon.Close()
        SQLiteCon.Dispose()
        SQLiteCon = Nothing
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = DateTime.Now.ToString("h: mm : ss tt")
        lblDate.Text = DateTime.Now.ToLongDateString
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'back
        baOptions.Show()
        Me.Hide()
    End Sub

    Private Sub cViewRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlInfo.Hide()
        TextBox1.Enabled = False

        Me.CenterToScreen()
        TextBox1.CharacterCasing = CharacterCasing.Normal
        SendMessage(Me.TextBox1.Handle, &H1501, 0, "Search...")


        dbpath = "Data Source=" & Application.StartupPath & "\databasesqlite.db;"
        cmbGender.SelectedItem = "- choose gender -"
        cmbYear.SelectedItem = "- choose year level -"
        cmbStatus.SelectedItem = "- choose student status -"
        btnUpdate.Enabled = False

        Dim SQLiteCon As New SQLiteConnection(dbpath)
        Try
            SQLiteCon.Open()
        Catch ex As Exception
            SQLiteCon.Dispose()
            SQLiteCon = Nothing
            MsgBox(ex.Message)
            Exit Sub
        End Try

        Dim TableDB As New DataTable

        Try
            LoadDB("select*from " & TableName & " order by snum", TableDB, SQLiteCon)
            DataGridView1.DataSource = Nothing
            DataGridView1.DataSource = TableDB
            DataGridView1.ClearSelection()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        TableDB.Dispose()
        TableDB = Nothing
        SQLiteCon.Close()
        SQLiteCon.Dispose()
        SQLiteCon = Nothing
    End Sub

    Private Sub btnDAsh_Click(sender As Object, e As EventArgs) Handles btnDash.Click
        'Dashboard
        bDashboardCS.Show()
        Me.Hide()
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'Show Panel of Informationa nd Hide Button
        pnlInfo.Show()
        btnAdd.Hide()
        btnAddd.Enabled = True
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        pnlInfo.Hide()
        btnAdd.Show()
        btnUpdate.Enabled = False
    End Sub
    Private Sub ExecuteNonQuery(ByVal query As String, ByVal cn As SQLiteConnection)
        Dim SQLiteCM As New SQLiteCommand(query, cn)
        SQLiteCM.ExecuteNonQuery()
        SQLiteCM.Dispose()
        SQLiteCM = Nothing
    End Sub
    Private Sub LoadDB(ByVal q As String, ByVal tbl As DataTable, ByVal cn As SQLiteConnection)
        Dim SQLiteDA As New SQLiteDataAdapter(q, cn)
        SQLiteDA.Fill(tbl)
        SQLiteDA.Dispose()
        SQLiteDA = Nothing
    End Sub

    Private Sub DataGridView1_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDown
        If AllCellsSelected(DataGridView1) = False Then
            If e.Button = MouseButtons.Right Then
                DataGridView1.CurrentCell = DataGridView1(e.ColumnIndex, e.RowIndex)
                Dim i As Integer
                With DataGridView1
                    If e.RowIndex >= 0 Then
                        i = .CurrentRow.Index

                        snum = .Rows(i).Cells("snum").Value.ToString
                        fname = .Rows(i).Cells("fname").Value.ToString
                        mname = .Rows(i).Cells("mname").Value.ToString
                        lname = .Rows(i).Cells("lname").Value.ToString
                        cccemail = .Rows(i).Cells("cccemail").Value.ToString
                        gender = .Rows(i).Cells("gender").Value.ToString
                        ylvl = .Rows(i).Cells("ylevel").Value.ToString
                        section = .Rows(i).Cells("section").Value.ToString
                        stat = .Rows(i).Cells("sstat").Value.ToString
                    End If
                End With
            End If
        End If
    End Sub
    Private Function AllCellsSelected(dgv As DataGridView) As Boolean
        AllCellsSelected = (DataGridView1.SelectedCells.Count = (DataGridView1.RowCount * DataGridView1.Columns.GetColumnCount(DataGridViewElementStates.Visible)))
    End Function
End Class