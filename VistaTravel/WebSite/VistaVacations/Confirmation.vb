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

    Public Class Confirmation
        Inherits System.Web.UI.Page
        Public divTotal As System.Web.UI.HtmlControls.HtmlGenericControl
                
        Public txtItineraryID As System.Web.UI.WebControls.TextBox
        Public txtReferer As System.Web.UI.WebControls.TextBox
        Public btnContinue As System.Web.UI.WebControls.Button
        Public btnBack As System.Web.UI.WebControls.Button
        Public Repeater1 As System.Web.UI.WebControls.Repeater

        Public divSubTotal As System.Web.UI.HtmlControls.HtmlGenericControl
    
        Sub Page_Load(ByVal Sender As Object, ByVal e As EventArgs)
            If Not IsPostback Then ' Evals true first time browser hits the page	
                Dim oVista As New VistaSiteMgr.Itinerary()
                Dim dsDetail As DataSet
                Dim iX As Integer
                Dim dblSubTotal As Double
                Dim dblTotal As Double
                Dim ItineraryID As Integer
                Dim objTotalPrice As VistaSiteMgr.TotalPrice

                ItineraryID = CInt(request.QueryString.Item("ItineraryID"))
                dsDetail = oVista.Retrieve(ItineraryID)
                
                repeater1.DataSource = dsDetail.Tables(0).DefaultView
                repeater1.DataBind()
                
                For iX = 0 To dsDetail.tables(0).rows.count - 1
                    If Not isDBnull(dsDetail.Tables(0).Rows(iX).Item("EstimatedCost")) Then
                        dblSubTotal = dblSubTotal + CDbl(dsDetail.Tables(0).Rows(iX).Item("EstimatedCost"))
                    End If
                Next

                'call method to add tax
                dblTotal = dblSubTotal * 1.1 'objTotalPrice.GetPrice(dblSubTotal)

                divSubTotal.InnerHtml = "<b>SubTotal = $" & CStr(dblSubTotal) & "</b>"
                divTotal.InnerHtml = "<b>Total = $" & CStr(dblTotal) & "</b>"

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

        Protected Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
            Me.Navigate(txtReferer.text)
        End Sub

        Protected Sub btnContinue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
            'Dim oItinerary As New VistaSiteMgr.Itinerary()
            'Dim ds As New DataSet()

            'ds = oItinerary.BookIt(1, CInt(txtItineraryID.text))
            Me.Navigate("Complete.aspx")
        End Sub

    End Class

End Namespace
