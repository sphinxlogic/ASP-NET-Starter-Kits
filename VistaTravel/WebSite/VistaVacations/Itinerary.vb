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

Namespace VistaVacations

    Public Class Itinerary
        Inherits System.Web.UI.Page
        Public Button3 As System.Web.UI.HtmlControls.HtmlInputButton
        Public Button2 As System.Web.UI.HtmlControls.HtmlInputButton
        Public cmdBookTrip As System.Web.UI.HtmlControls.HtmlInputButton
        Public tdFirstDay As System.Web.UI.HtmlControls.HtmlTableCell
        Public txtItineraryID As System.Web.UI.WebControls.TextBox
        Public txtDepartDate As System.Web.UI.WebControls.TextBox
        Public txtReturnDate As System.Web.UI.WebControls.TextBox
        Public txtRequestedDate As System.Web.UI.WebControls.TextBox
        Public txtLastRequestedDate As System.Web.UI.WebControls.TextBox
        Public txtMemberID As System.Web.UI.WebControls.TextBox
        Public DataGrid1 As System.Web.UI.WebControls.DataGrid
                
        Private dvCalendarView As New DataView()
        Private dsItinerary As New DataSet()
        Private m_ItineraryID As Long
        Private m_MemberID As Long



        Sub Page_Load(ByVal Sender As Object, ByVal e As EventArgs)
            If Not IsPostback Then ' Evals true first time browser hits the page	
                Dim oVistaItinerary As VistaSiteMgr.Itinerary
                Dim sRegion As String
                Dim dStartDate As Date
                Dim dEndDate As Date
                Dim sCity As String
                Dim sState As String


                sRegion = request.QueryString.Item("Region")
                dStartDate = CDate(request.QueryString.Item("StartDate"))
                dEndDate = CDate(request.QueryString.Item("EndDate"))
                sCity = request.QueryString.Item("City")
                sState = request.QueryString.Item("State")
                oVistaItinerary = New VistaSiteMgr.Itinerary
                    
                
                dsItinerary = oVistaItinerary.BuildItinerary(1, 2, 0, "Vacation", sCity, sState, dStartDate, dEndDate, sRegion)
                m_MemberID = 1
                '               ItineraryID = dsItinerary.Tables("ItineraryDetail").Rows(0).Item("ItineraryID")
                '                dvCalendarView = New dataview(dsItinerary.Tables("ItineraryDetail"))

                                
                m_ItineraryID = dsItinerary.Tables(0).Rows(0).Item(0)

                
                dvCalendarView = New dataview(dsItinerary.Tables(0))

                dvCalendarView.Table.Columns.Remove(0)
                dvCalendarView.Table.Columns.Remove(0)
                dvCalendarView.Table.Columns.Item(1).ColumnName = "Time of Day"


                DataGrid1.DataSource = dvCalendarView
                                
                datagrid1.DataBind()
                Me.DataGrid1.Style.Item("Width") = "650"
                
                txtMemberID.Text = CStr(m_MemberID)
                txtMemberID.Visible = False

                txtItineraryID.Text = CStr(m_ItineraryID)
                txtItineraryID.Visible = False

                txtDepartDate.Text = CStr(dStartDate)
                txtDepartDate.Visible = False

                txtReturnDate.Text = CStr(dEndDate)
                txtReturnDate.Visible = False

                txtRequestedDate.Text = CStr(dStartDate)
                txtRequestedDate.Visible = False

                txtLastRequestedDate.Text = CStr(dStartDate)
                txtLastRequestedDate.Visible = False

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

        Protected Sub cmdBookTrip_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
            response.Redirect("Confirmation.aspx?MemberID=" & CStr(Me.txtMemberID.Text) & "&ItineraryID=" & CStr(Me.txtItineraryID.Text))
        End Sub

        Protected Sub Next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
            Dim objVMgr As New VistaSiteMgr.Itinerary()
            Dim dsDailyDetail As New DataSet()
            Dim dv As New DataView()
            Dim OldRequestedDate As Date
            Dim NewRequestedDate As Date

            system.Diagnostics.Debug.Write(Me.txtRequestedDate.Text)
            system.Diagnostics.Debug.Write(Me.txtLastRequestedDate.Text)
            system.Diagnostics.Debug.Write(Me.txtReturnDate.Text)

            'If (strComp(Me.txtRequestedDate.Text, Me.txtReturnDate.text) = -1) Then
            'If dateandtime.DateDiff(DateInterval.Day, CDate(Me.txtRequestedDate.Text), CDate(Me.txtReturnDate.text)) = -1 Then
            OldRequestedDate = CDate(Me.txtRequestedDate.Text)
            NewRequestedDate = dateandtime.DateAdd(DateInterval.Day, 1, OldRequestedDate)
            
            Me.txtLastRequestedDate.text = CStr(OldRequestedDate)
            Me.txtRequestedDate.Text = CStr(NewRequestedDate)



            system.Diagnostics.Debug.Write("inside function")
            dsDailyDetail = objVMgr.LoadDailyDetail(CInt(txtItineraryID.Text), CDate(Me.txtRequestedDate.Text))
            dv = New DataView(dsDailyDetail.Tables(0))
            dv.Table.Columns.Remove(0)
            dv.Table.Columns.Remove(0)
            dv.Table.Columns.Item(1).ColumnName = "Time of Day"

            Me.DataGrid1.DataSource = dv
            Me.DataGrid1.DataBind()
            Me.DataGrid1.Style.Item("Width") = "650"
            
            'End If


        End Sub

        Protected Sub Prev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
            Dim objVMgr As New VistaSiteMgr.Itinerary()
            Dim dsDailyDetail As New DataSet()
            Dim dv As New DataView()
            Dim OldDate As Date
            Dim NewDate As Date

            'If StrComp(Me.txtLastRequestedDate.Text, Me.txtDepartDate.text,1) = 0) Then

            dsDailyDetail = objvmgr.LoadDailyDetail(CInt(txtItineraryID.Text), CDate(Me.txtLastRequestedDate.Text))
            dv = New DataView(dsDailyDetail.Tables(0))
            dv.Table.Columns.Remove(0)
            dv.Table.Columns.Remove(0)
            dv.Table.Columns.Item(1).ColumnName = "Time of Day"

            Me.DataGrid1.DataSource = dv
            Me.DataGrid1.DataBind()
            Me.DataGrid1.Style.Item("Width") = "650"
            
            Me.txtRequestedDate.Text = Me.txtLastRequestedDate.text

            'take one away from lastrequested dat to reset the current
            'lastrequesteddate
            OldDate = CDate(Me.txtLastRequestedDate.Text)
            NewDate = dateandtime.DateAdd(DateInterval.Day, -1, OldDate)
                
            Me.txtLastRequestedDate.Text = CStr(NewDate)




            'End If


        End Sub

        Protected Sub DataGrid1_Page(ByVal source As System.Object, ByVal e As System.Web.UI.WebControls.DataGridPageChangedEventArgs)
            'WHY DOESN'T THIS WORK?  IT IS JUST LIKE THE SAMPLE...
            'DOES THE DATAVIEW LOOSE SCOPE AND GET TOSSED???            
            'DataGrid1.DataSource = dvCalendarView
            'DataGrid1.DataBind()
        End Sub

    End Class

End Namespace
