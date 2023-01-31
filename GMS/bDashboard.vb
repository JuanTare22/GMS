Imports System.Data.SQLite
Imports System.Runtime.InteropServices
Public Class bDashboard
    Dim dbpath As String
    'Dim TableName As String = "tableIT"
    'Dim snum, fname, mname, lname, cccemail, gender, ylvl, section, stat As String
    Private Sub bDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    Private Sub btnDash_Click(sender As Object, e As EventArgs) Handles btnDash.Click
        'Dashboard (Here)
        MessageBox.Show("You're here")
    End Sub

    Private Sub btnRecord_Click(sender As Object, e As EventArgs) Handles btnRecord.Click
        'Record
        Me.Hide()
        'cViewRecord.Show()
        fordatest.Show()

    End Sub

    Private Sub lblDCI_Click(sender As Object, e As EventArgs) Handles lblDCP.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = DateTime.Now.ToString("h: mm : ss tt")
        lblDate.Text = DateTime.Now.ToLongDateString

        dbpath = "Data Source=" & Application.StartupPath & "\databasesqlite.db;"

        Dim con As New SQLiteConnection(dbpath)


        con.Open()
        'total DCI
        'Dim cmdI As New SQLiteCommand("select count(*) from tableIT", con)
        'Dim countI = Convert.ToString(cmdI.ExecuteScalar)

        'Dim it As Integer
        'it = countI

        'Dim cmdC As New SQLiteCommand("select count(*) from tableCS", con)
        'Dim countC = Convert.ToString(cmdC.ExecuteScalar)

        'Dim cs As Integer
        'cs = countC

        'Dim total As Integer
        'total = (it + cs)


        'lblDCP.Text = total


        'total DCP
        Dim cmd As New SQLiteCommand("Select count(*) From DCPmembers where data='1'", con)
        Dim countDCP = Convert.ToString(cmd.ExecuteScalar)
        lblDCP.Text = countDCP

        'total SW
        'Dim cmdsw As New SQLiteCommand
        'Dim cmdSWd As New SQLiteCommand("select count(*) from DCPmembers where data= '1'", con)
        Dim cmdSW As New SQLiteCommand("select count(*) from DCPmembers where Committee= 'Script Writing'", con)
        'cmdsw = cmdSWd & cmdSWc
        Dim countSW = Convert.ToString(cmdSW.ExecuteScalar)
        lblSW.Text = countSW

        'total D
        Dim cmdD As New SQLiteCommand("select count(*) from DCPmembers where Committee= 'Directing'", con)
        Dim countD = Convert.ToString(cmdd.ExecuteScalar)
        lblD.Text = countD

        'total A
        Dim cmdA As New SQLiteCommand("select count(*) from DCPmembers where Committee= 'Artist'", con)
        Dim countA = Convert.ToString(cmdA.ExecuteScalar)
        lblA.Text = countA

        'total L
        Dim cmdL As New SQLiteCommand("select count(*) from DCPmembers where Committee= 'Layout'", con)
        Dim countL = Convert.ToString(cmdL.ExecuteScalar)
        lblL.Text = countL

        'total PVE
        Dim cmdPVE As New SQLiteCommand("select count(*) from DCPmembers where Committee= 'Photo and Video Editing'", con)
        Dim countPVE = Convert.ToString(cmdPVE.ExecuteScalar)
        lblPVE.Text = countPVE

        'total SM
        Dim cmdSM As New SQLiteCommand("select count(*) from DCPmembers where Committee= 'Social Media'", con)
        Dim countSM = Convert.ToString(cmdSM.ExecuteScalar)
        lblSM.Text = countSM

        con.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'baOptions.Show()
        'Me.Hide()
    End Sub

    Private Sub btnDash_Click_1(sender As Object, e As EventArgs) Handles btnDash.Click

    End Sub
End Class