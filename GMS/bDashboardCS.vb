Imports System.Data.SQLite
Imports System.Runtime.InteropServices
Public Class bDashboardCS
    Dim dbpath As String
    'Dim TableName As String = "tableIT"
    'Dim snum, fname, mname, lname, cccemail, gender, ylvl, section, stat As String
    Private Sub bDashboardCS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'dbpath = "Data Source=" & Application.StartupPath & "\databasesqlite.db;"
        'Dim dt As New DataTable
        'Dim con As New SQLiteConnection(dbpath)

        'Dim cmd As New SQLiteCommand

        'con.Open()
        ''total IT
        'Dim cmdd As New SQLiteCommand("select count(*) from tableIT", con)
        'Dim countIT = Convert.ToString(cmdd.ExecuteScalar)
        'lblIT.Text = countIT

        ''total reg
        'Dim cmdreg As New SQLiteCommand("select count(*) from tableIT where sstat= 'Regular'", con)
        'Dim countreg = Convert.ToString(cmdreg.ExecuteScalar)
        'lblReg.Text = countreg

        ''total irreg
        'Dim cmdire As New SQLiteCommand("select count(*) from tableIT where sstat= 'Irregular'", con)
        'Dim countire = Convert.ToString(cmdire.ExecuteScalar)
        'lblIrreg.Text = countire

        ''total working
        'Dim cmdwo As New SQLiteCommand("select count(*) from tableIT where sstat= 'Working'", con)
        'Dim countwo = Convert.ToString(cmdwo.ExecuteScalar)
        'lblWork.Text = countwo

        'con.Close()


    End Sub
    Private Sub btnDash_Click(sender As Object, e As EventArgs)
        'Dashboard (Here)
        MessageBox.Show("You're here")
    End Sub

    Private Sub btnRecord_Click(sender As Object, e As EventArgs) Handles btnRecord.Click, btnDash.Click
        'Record
        Me.Hide()
        cViewRecordCS.Show()
    End Sub

    Private Sub lblDCI_Click(sender As Object, e As EventArgs) Handles lblDCI.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = DateTime.Now.ToString("h: mm : ss tt")
        lblDate.Text = DateTime.Now.ToLongDateString

        dbpath = "Data Source=" & Application.StartupPath & "\databasesqlite.db;"

        Dim con As New SQLiteConnection(dbpath)


        con.Open()
        'total DCI
        Dim cmdI As New SQLiteCommand("select count(*) from tableIT", con)
        Dim countI = Convert.ToString(cmdI.ExecuteScalar)

        Dim it As Integer
        it = countI

        Dim cmdC As New SQLiteCommand("select count(*) from tableCS", con)
        Dim countC = Convert.ToString(cmdC.ExecuteScalar)

        Dim cs As Integer
        cs = countC

        Dim total As Integer
        total = (it + cs)


        lblDCI.Text = total


        'total IT
        Dim cmdd As New SQLiteCommand("Select count(*) From tableCS", con)
        Dim countIT = Convert.ToString(cmdd.ExecuteScalar)
        lblIT.Text = countIT

        'total reg
        Dim cmdreg As New SQLiteCommand("select count(*) from tableCS where sstat= 'Regular'", con)
        Dim countreg = Convert.ToString(cmdreg.ExecuteScalar)


        lblReg.Text = countreg

        'total irreg
        Dim cmdire As New SQLiteCommand("select count(*) from tableCS where sstat= 'Irregular'", con)
        Dim countire = Convert.ToString(cmdire.ExecuteScalar)
        lblIrreg.Text = countire

        'total working
        Dim cmdwo As New SQLiteCommand("select count(*) from tableCS where sstat= 'Working'", con)
        Dim countwo = Convert.ToString(cmdwo.ExecuteScalar)
        lblWork.Text = countwo

        con.Close()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'back
        baOptions.Show()
        Me.Hide()
    End Sub
End Class