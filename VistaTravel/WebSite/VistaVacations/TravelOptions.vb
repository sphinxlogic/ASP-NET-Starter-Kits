Option Strict Off

Imports System
Imports System.Collections
Imports System.ComponentModel.Design
Imports System.Data
Imports System.Drawing
Imports System.Web
Imports System.Web.SessionState
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.HtmlControls
Imports Microsoft.VisualBasic
Imports SeagateSoftware.CrystalReports
Imports SeagateSoftware.CrystalReports.CREngine

Namespace VistaVacations

    Public Class TravelOptions
        Inherits System.Web.UI.Page
                Public CrystalReportViewer1 As SeagateSoftware.CrystalReports.WebFormsViewer.CrystalReportViewer
        Public OptionRepeater As System.Web.UI.WebControls.Repeater
                
        
                
                Public txtBln As System.Web.UI.WebControls.TextBox
                Public txtRegion As System.Web.UI.WebControls.TextBox
        
                
        
        
        
        
        Public dsOptions As New System.Data.DataSet()
        
        
	Public Report As New SeagateSoftware.CrystalReports.CREngine.SCRReport()        
	Public App As New SeagateSoftware.CrystalReports.CREngine.SCRApplication()
                
        
                
        
        
                
        
        
                
        
        
                
        
        
                
        
        
        
                
        
        
        
        
                
        
        
        
        
        
        
        

        Sub Page_Load(ByVal Sender As Object, ByVal e As EventArgs)
            If Not IsPostback Then ' Evals true first time browser hits the page	
                Dim objVistaMgr As New VistaSiteMgr.Activity()
                
                Dim strFrom As String
                Dim strTo As String
                Dim strWith As String
                Dim strDestination As String
                Dim strCategories As String
                Dim strStartDate As String
                Dim strEndDate As String

                strFrom = Request.Form("escapingfrom") & "|"
                strWith = Request.Form("escapingwith") & "|"
                strTo = Request.Form.Item("escapingto") & "|"
                strDestination = Request.Form("destination")
                strStartDate = Request.Form.Item("txtLeave")
                strEndDate = Request.Form.Item("txtReturn")
                
                
                'strStartDate = CDate(Format(strStartDate, "mm/dd/yyyy"))
                'strEndDate = CDate(Format(strEndDate, "mm/dd/yyyy"))
                If Instr(strDestination, "<-") Then
                    strDestination = ""
                End If

                If Not Instr(strFrom, "<-") Then
                    'If len(Left(strFrom, InStr(1, strFrom, "|") - 1)) > 0 Then
                    'we have a value, add it to our string
                    strCategories = strCategories & strFrom
                    'End If
                End If

                If Not Instr(strWith, "<-") Then
                    'If len(Left(strWith, len(strWith) - 1)) > 0 Then
                    'we have a value, add it to our string
                    strCategories = strCategories & strWith
                    'End If
                End If
     
                'we have a value, add it to our string
                If Not Instr(strTo, "<-") Then
                    'If len(Left(strTo, len(strTo) - 1)) > 0 Then
                    strCategories = strCategories & strTo
                    'End If
                End If

                If len(strCategories) > 0 Then
                    'take off any trailing "|"
                    strCategories = left(strCategories, (len(strCategories) - 1))
                Else
                    strCategories = ""
                End If

                dsOptions = objVistaMgr.BrowseByLocation(strStartDate, strStartDate, "", strDestination, "", "", "", strCategories)


                Report.Load(Server.MapPath("_OverallRatings.rpt"), CREngine.SCROpenReportMethod.scrOpenReportByDefault, 0)
                Report.DataSource = dsOptions
                CrystalReportViewer1.ReportSource = Report

                OptionRepeater.DataSource = New DataView(dsOptions.Tables(0))
                OptionRepeater.DataBind()

		

            End If


           
        End Sub

        Overrides Protected Sub Init()
            'CODEGEN: This method call is required by the Web Form Designer
            'Do not modify it using the code editor.
            InitializeComponent()
        End Sub

        'CODEGEN: This procedure is required by the Web Form Designer
        'Do not modify it using the code editor.
        Private Sub InitializeComponent() 









        End Sub

    End Class

End Namespace
