'Imports System.Data.SqlClient
Imports System.Data.SQLite
Imports System.Runtime.InteropServices

Public Class Form1
    Dim dbpath As String
    Dim TableName As String = "DCPmembers"
    Dim snum, fname, mname, lname, bday, comm, gender, data As String
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

        If MsgBox("Delete record permanently?", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, "Confirmation") = MsgBoxResult.Cancel Then Return

        Try
            If AllCellsSelected(DataGridView1) = True Then
                ExecuteNonQuery("delete from " & TableName & "", SQLiteCon)
                SQLiteCon.Close()
                SQLiteCon.Dispose()
                SQLiteCon = Nothing

                btnRefresh1_Click(sender, e)
                Return
            End If

            For Each row As DataGridViewRow In DataGridView1.SelectedRows
                If row.Selected = True Then
                    Dim value As String = row.DataBoundItem(0).ToString
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

        btnRefresh1_Click(sender, e)
    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim SearchCMD As String
        If TextBox1.Text = Nothing Then
            TextBox1.CharacterCasing = CharacterCasing.Normal
            SendMessage(Me.TextBox1.Handle, &H1501, 0, "Search by Student Number")
        Else
            TextBox1.CharacterCasing = CharacterCasing.Upper
        End If
        'If CheckBoxSearchbySnum.Checked = True Then
        '    If TextBox1.Text = Nothing Then
        '        SearchCMD = "select*from " & TableName & " order by FirstName"
        '    Else
        SearchCMD = "select*from " & TableName & " where snum like'" & TextBox1.Text & "%'"
        'End If
        'End If

        Dim SQLiteCon As New SQLiteConnection(dbpath)

        Try
            SQLiteCon.Open()
        Catch ex As Exception
            SQLiteCon.Dispose()
            SQLiteCon = Nothing
            MsgBox(ex.Message)
            Exit Sub
        End Try

        Dim DCPmembers As New DataTable

        Try
            LoadDB(SearchCMD, DCPmembers, SQLiteCon)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        If DCPmembers.Rows.Count > 0 Then
            DataGridView1.DataSource = Nothing
            DataGridView1.DataSource = DCPmembers
        End If
        DCPmembers.Dispose()
        DCPmembers = Nothing
        SQLiteCon.Close()
        SQLiteCon.Dispose()
        SQLiteCon = Nothing
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs)

        If AllCellsSelected(DataGridView1) = False Then;
            btnAddd.Enabled = False
            pnlInfo.Show()
            btnDelete.Enabled = False
            'no, fname, mname, lname, bday, comm, gender, data
            txtSnum.Text = snum
            txtFname.Text = fname
            txtMname.Text = mname
            txtLname.Text = lname
            DateTimePicker1.Text = bday
            cmbGender.Text = gender
            cmbComm.Text = comm
        Else
            MsgBox("Can not edit because table row is selected all. Please choose one to edit.", MsgBoxStyle.Critical, "Failed")
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs)
        txtSnum.Clear()
        txtFname.Clear()
        txtMname.Clear()
        txtLname.Clear()
        DateTimePicker1.Text = "12/6/2022 11:33 PM"
        cmbGender.SelectedItem = "- choose gender -"
        cmbComm.SelectedItem = "- choose committee -"
        btnDelete.Enabled = True
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        DataGridView1.SelectAll()
    End Sub

    Private Sub CheckBoxSearchbySnum_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxSearchbySnum.CheckedChanged
        'If CheckBoxSearchbySnum.Checked = True Then
        '    CheckBoxSearchbyName.Checked = False
        TextBox1.Enabled = True
        'End If
        'If CheckBoxSearchbySnum.Checked = False Then
        '    CheckBoxSearchbyName.Checked = True
        '    TextBox1.Enabled = True
        'End If
    End Sub

    Private Sub cViewRecord_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick
        DataGridView1.ClearSelection()
        SendMessage(Me.TextBox1.Handle, &H1501, 0, "Search...")
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        btnDelete.Enabled = True
    End Sub


    Private Sub btnUpdate_Click(sender As Object, e As EventArgs)
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

        If DateTimePicker1.Text = "12/6/2022 11:33 PM" Then
            MessageBox.Show("Birthday has not been filled, please fill in Birthday ", "Failed")
            Return
        End If

        If cmbGender.Text = "- choose gender -" Then
            MessageBox.Show("Gender not selected, please select Gender", "Failed")
            Return
        End If

        If cmbComm.Text = "- choose committee -" Then
            MessageBox.Show("Committee not selected, please select Committee", "Failed")
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

        'snum, fname, mname, lname, bday, comm, gender, data
        Try
            ExecuteNonQuery("update " & TableName & " set FirstName='" & txtFname.Text _
                            & "',MiddleName='" & txtMname.Text & "',LastName='" & txtLname.Text & "',Birthday='" & DateTimePicker1.Text & "',Gender='" & cmbGender.Text _
                            & "',Committee='" & cmbComm.Text & "' where snum='" & txtSnum.Text _
                            & "'", SQLiteCon)
            MsgBox("Update Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        SQLiteCon.Close()
        SQLiteCon.Dispose()
        SQLiteCon = Nothing

        pnlInfo.Visible = False
        btnRefresh1_Click(sender, e)
        btnClear_Click(sender, e)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = DateTime.Now.ToString("h: mm : ss tt")
        lblDate.Text = DateTime.Now.ToLongDateString
        'btnRefresh1_Click(sender, e)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'back
        'baOptions.Show()
        'Me.Hide()
    End Sub

    Private Sub btnRestore_Click(sender As Object, e As EventArgs) Handles btnRestore.Click
        Dim SQLiteCon As New SQLiteConnection(dbpath)
        TextBox3.Text = "0"
        Try
            SQLiteCon.Open()
        Catch ex As Exception
            SQLiteCon.Dispose()
            SQLiteCon = Nothing
            MsgBox(ex.Message)
            Exit Sub
        End Try
        If MsgBox("Restored record?", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, "Confirmation") = MsgBoxResult.Cancel Then Return
        Try
            ExecuteNonQuery("update " & TableName & " set data='" & "1" & "' where snum='" & txtSnum.Text & "'", SQLiteCon)
            MsgBox("Restored Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        btnRefresh1_Click(sender, e)
        btnRestore.Enabled = False
        'btnarch.Visible = False
        pnlInfo.Visible = False
    End Sub
    Private Sub btnRefresh1_Click(sender As Object, e As EventArgs) Handles btnRefresh1.Click
        TextBox1.Text = ""
        TextBox1.CharacterCasing = CharacterCasing.Normal
        SendMessage(Me.TextBox1.Handle, &H1501, 0, "Search by Student Number...")

        Dim SQLiteCon As New SQLiteConnection(dbpath)
        Try
            SQLiteCon.Open()
        Catch ex As Exception
            SQLiteCon.Dispose()
            SQLiteCon = Nothing
            MsgBox(ex.Message)
            Exit Sub
        End Try

        pnlInfo.Hide()
        'TextBox1.Enabled = False

        Dim DCPmembers As New DataTable
        Dim SearchCMD As String
        'Try
        'LoadDB("select*from " & TableName & " where data like'" & TextBox2.Text & , TableDB, SQLiteCon)
        'LoadDB("select*from " & TableName & " where data like='1'", TableDB, SQLiteCon)
        SearchCMD = "select*from " & TableName & " where data like'" & TextBox3.Text & "%'"
        'LoadDB("select*from " & TableName & " order by snum", TableDB, SQLiteCon)
        'DataGridView1.DataSource = Nothing
        'DataGridView1.DataSource = TableDB
        'DataGridView1.ClearSelection()

        'Dim DCPmembers As New DataTable

        Try
            LoadDB(SearchCMD, DCPmembers, SQLiteCon)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        If DCPmembers.Rows.Count > 0 Then
            DataGridView1.DataSource = Nothing
            DataGridView1.DataSource = DCPmembers
        End If
        DCPmembers.Dispose()
        DCPmembers = Nothing
        SQLiteCon.Close()
        SQLiteCon.Dispose()
        SQLiteCon = Nothing
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlInfo.Hide()
        'TextBox1.Enabled = False

        Me.CenterToScreen()
        TextBox1.CharacterCasing = CharacterCasing.Normal
        SendMessage(Me.TextBox1.Handle, &H1501, 0, "Search by Student Number")

        dbpath = "Data Source=" & Application.StartupPath & "\databasesqlite.db;"
        cmbGender.SelectedItem = "- choose gender -"
        cmbComm.SelectedItem = "- choose committee -"

        Dim SQLiteCon As New SQLiteConnection(dbpath)
        Try
            SQLiteCon.Open()
        Catch ex As Exception
            SQLiteCon.Dispose()
            SQLiteCon = Nothing
            MsgBox(ex.Message)
            Exit Sub
        End Try

        Dim DCPmembers As New DataTable
        Dim SearchCMD As String
        'Try
        'LoadDB("select*from " & TableName & " where data like'" & TextBox2.Text & , TableDB, SQLiteCon)
        'LoadDB("select*from " & TableName & " where data like='1'", TableDB, SQLiteCon)
        SearchCMD = "select*from " & TableName & " where data like'" & TextBox3.Text & "%'"
        'LoadDB("select*from " & TableName & " order by snum", TableDB, SQLiteCon)
        'DataGridView1.DataSource = Nothing
        'DataGridView1.DataSource = TableDB
        'DataGridView1.ClearSelection()

        'Dim DCPmembers As New DataTable

        Try
            LoadDB(SearchCMD, DCPmembers, SQLiteCon)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        If DCPmembers.Rows.Count > 0 Then
            DataGridView1.DataSource = Nothing
            DataGridView1.DataSource = DCPmembers
        End If
        DCPmembers.Dispose()
        DCPmembers = Nothing
        SQLiteCon.Close()
        SQLiteCon.Dispose()
        SQLiteCon = Nothing

        'Catch ex As Exception
        'MsgBox(ex.Message)
        'End Try

        'TableDB.Dispose()
        'TableDB = Nothing
        'SQLiteCon.Close()
        'SQLiteCon.Dispose()
        'SQLiteCon = Nothing
    End Sub

    Private Sub btnSW_Click(sender As Object, e As EventArgs) Handles btnSW.Click
        Dim TableDB As New DataTable
        Dim SQLiteCon As New SQLiteConnection(dbpath)
        Try
            LoadDB("select*from " & TableName & " where Committee = 'Script Writing'", TableDB, SQLiteCon)
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

    Private Sub btnD_Click(sender As Object, e As EventArgs) Handles btnD.Click
        Dim TableDB As New DataTable
        Dim SQLiteCon As New SQLiteConnection(dbpath)
        Try
            LoadDB("select*from " & TableName & " where Committee = 'Directing'", TableDB, SQLiteCon)
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

    Private Sub btnA_Click(sender As Object, e As EventArgs) Handles btnA.Click
        Dim TableDB As New DataTable
        Dim SQLiteCon As New SQLiteConnection(dbpath)
        Try
            LoadDB("select*from " & TableName & " where Committee = 'Artist'", TableDB, SQLiteCon)
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

    Private Sub btnL_Click(sender As Object, e As EventArgs) Handles btnL.Click
        Dim TableDB As New DataTable
        Dim SQLiteCon As New SQLiteConnection(dbpath)
        Try
            LoadDB("select*from " & TableName & " where Committee = 'Layout'", TableDB, SQLiteCon)
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

    Private Sub btnPVE_Click(sender As Object, e As EventArgs) Handles btnPVE.Click
        Dim TableDB As New DataTable
        Dim SQLiteCon As New SQLiteConnection(dbpath)
        Try
            LoadDB("select*from " & TableName & " where Committee = 'Photo and Video Editing'", TableDB, SQLiteCon)
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

    Private Sub btnSM_Click(sender As Object, e As EventArgs) Handles btnSM.Click
        Dim TableDB As New DataTable
        Dim SQLiteCon As New SQLiteConnection(dbpath)
        Try
            LoadDB("select*from " & TableName & " where Committee = 'Social Media'", TableDB, SQLiteCon)
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

    Private Sub btnRecord_Click(sender As Object, e As EventArgs) Handles btnRecord.Click
        fordatest.Show()
        Me.Hide()
    End Sub

    Private Sub btnArchive_Click(sender As Object, e As EventArgs)
        Dim SQLiteCon As New SQLiteConnection(dbpath)
        Try
            SQLiteCon.Open()
        Catch ex As Exception
            SQLiteCon.Dispose()
            SQLiteCon = Nothing
            MsgBox(ex.Message)
            Exit Sub
        End Try
        If MsgBox("Archive record?", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, "Confirmation") = MsgBoxResult.Cancel Then Return
        Try
            ExecuteNonQuery("update " & TableName & " set data='" & "1" & "' where snum='" & txtSnum.Text & "'", SQLiteCon)
            MsgBox("Archived Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        btnRefresh1_Click(sender, e)
    End Sub

    Private Sub RestoreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestoreToolStripMenuItem.Click
        If AllCellsSelected(DataGridView1) = False Then
            pnlInfo.Show()
            btnRestore.Enabled = True
            'btnarch.Visible = True
            '    'no, fname, mname, lname, bday, comm, gender, data
            txtSnum.Text = snum
            txtFname.Text = fname
            txtMname.Text = mname
            txtLname.Text = lname
            DateTimePicker1.Text = bday
            cmbGender.Text = gender
            cmbComm.Text = comm
        Else
            MsgBox("Can not edit because table row is selected all. Please choose one to edit.", MsgBoxStyle.Critical, "Failed")
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub btnDAsh_Click(sender As Object, e As EventArgs) Handles btnDash.Click
        'Dashboard
        bDashboard.Show()
        Me.Hide()
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs)
        'Show Panel of Informationa nd Hide Button
        pnlInfo.Show()
        btnDelete.Hide()
        btnAddd.Enabled = True

    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        pnlInfo.Hide()
        btnDelete.Show()

        btnarch.Visible = False
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
                        fname = .Rows(i).Cells("FirstName").Value.ToString
                        mname = .Rows(i).Cells("MiddleName").Value.ToString
                        lname = .Rows(i).Cells("LastName").Value.ToString
                        bday = .Rows(i).Cells("Birthday").Value.ToString
                        gender = .Rows(i).Cells("Gender").Value.ToString
                        comm = .Rows(i).Cells("Committee").Value.ToString
                    End If
                End With
            End If
        End If
    End Sub
    Private Function AllCellsSelected(dgv As DataGridView) As Boolean
        AllCellsSelected = (DataGridView1.SelectedCells.Count = (DataGridView1.RowCount + 1 * DataGridView1.Columns.GetColumnCount(DataGridViewElementStates.Visible)))
    End Function

End Class