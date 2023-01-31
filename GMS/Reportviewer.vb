Imports System.IO
Imports Microsoft.Reporting.WinForms

Public Class Reportviewer
    Public Shared Fullname, ImageNo1, ImageNo2, ImageNo3, ImageNo4, Quantity1, Quantity2, Quantity3, Quantity4, TotalQuantity, ControlNo, TotalPrice As String


    Private Sub Reportviewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As New DataTable()
        'dt = dbConnection.GetStudentViolationlist(id)
        ReportViewer1.LocalReport.Refresh()
        Dim ds As New System.Data.DataSet
        ds.Tables.Add(dt)
        'ReportViewer1.LocalReport.ReportPath = "C:\Users\Anthony\Downloads\SYSTEM(1)\SYSTEM\GMS\GMS\Reportreceipt.rdlc"
        ReportViewer1.LocalReport.ReportPath = Directory.GetCurrentDirectory() & "\Reportreceipt.rdlc"
        Dim repdate As Date = System.DateTime.Now.ToShortDateString()
        Dim params(0), myparam As ReportParameter
        '++++++++++++++++++try2
        Dim myparams As New List(Of ReportParameter)
        myparam = New ReportParameter("Name", Fullname)
        myparams.Add(myparam)
        myparam = New ReportParameter("IMGNO1", ImageNo1)
        myparams.Add(myparam)
        myparam = New ReportParameter("IMGNO2", ImageNo2)
        myparams.Add(myparam)
        myparam = New ReportParameter("IMGNO3", ImageNo3)
        myparams.Add(myparam)
        myparam = New ReportParameter("IMGNO4", ImageNo4)
        myparams.Add(myparam)
        myparam = New ReportParameter("QTY1", Quantity1)
        myparams.Add(myparam)
        myparam = New ReportParameter("QTY2", Quantity2)
        myparams.Add(myparam)
        myparam = New ReportParameter("QTY3", Quantity3)
        myparams.Add(myparam)
        myparam = New ReportParameter("QTY4", Quantity4)
        myparams.Add(myparam)
        myparam = New ReportParameter("TOTALQTY", TotalQuantity)
        myparams.Add(myparam)
        myparam = New ReportParameter("CTRLNO", ControlNo)
        myparams.Add(myparam)
        myparam = New ReportParameter("DATE", Date.Now.ToString("MM/dd/yyyy"))
        myparams.Add(myparam)
        myparam = New ReportParameter("TOTALPRICE", TotalPrice)
        myparams.Add(myparam)
        'Report_Parameter_1
        ReportViewer1.LocalReport.SetParameters(myparams)

        Dim rds As ReportDataSource = New ReportDataSource("DataSet1", ds.Tables(0))

        'Me.ReportViewer1.LocalReport.DataSources.Clear()
        Me.ReportViewer1.LocalReport.DataSources.Add(rds)
        Me.ReportViewer1.RefreshReport()


    End Sub
End Class