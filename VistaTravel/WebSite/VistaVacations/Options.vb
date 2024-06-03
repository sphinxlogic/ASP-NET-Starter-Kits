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

    Public Class Options
        Inherits System.Web.UI.Page
        Public txtDetailID As System.Web.UI.WebControls.TextBox
        Public txtReferer As System.Web.UI.WebControls.TextBox
        Public btnSave As System.Web.UI.WebControls.Button
        Public btnBack As System.Web.UI.WebControls.Button
        
        
        
        Public Repeater1 As System.Web.UI.WebControls.Repeater
        
        
        
        
        
        
        
        
        
        Sub Page_Load(ByVal Sender As Object, ByVal e As EventArgs)
            If Not IsPostback Then ' Evals true first time browser hits the page
                Dim oDetail As VistaSiteMgr.ItineraryDetail
                Dim dsDetail As Dataset
                Dim ItineraryID As Long
                Dim ItineraryDetailID As Long
                ItineraryDetailID = CLng(request.QueryString.Item("DetailID"))
                ItineraryID = CLng(request.QueryString.Item("ItineraryID"))

                oDetail = New VistaSiteMgr.ItineraryDetail
                dsDetail = oDetail.RetrieveOptions(ItineraryID, ItineraryDetailID)
                repeater1.DataSource = New DataView(dsDetail.Tables(0))
                repeater1.DataBind()
                txtReferer.Text = request.ServerVariables("HTTP_REFERER")
                txtDetailID.text = CStr(ItineraryDetailID)
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

        Protected Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
            Dim dsItineraryDetail As New DataSet()
            Dim oItineraryDetail As New VistaSiteMgr.ItineraryDetail()
            Dim drNew As DataRow
            
            dsItineraryDetail = oItineraryDetail.Load(CLng(txtDetailID.text))
            drnew = dsItineraryDetail.Tables(0).NewRow
            dsItineraryDetail.Tables(0).Rows(0).Item("Detail") = Request.Form.Item("txtDescr")
            
            If Request.Form.Item("txtQuantity") = "" Then
                dsItineraryDetail.Tables(0).Rows(0).Item("Quantity") = 1
            Else
                dsItineraryDetail.Tables(0).Rows(0).Item("Quantity") = CLng(Request.Form.Item("txtQuant"))
            End If
            If Request.Form.Item("txtCost") = "" Then
                dsItineraryDetail.Tables(0).Rows(0).Item("EstimatedCost") = 0
                dsItineraryDetail.Tables(0).Rows(0).Item("PricePerItem") = 0
            Else
                dsItineraryDetail.Tables(0).Rows(0).Item("EstimatedCost") = CDbl(Request.Form.Item("txtCost"))
                dsItineraryDetail.Tables(0).Rows(0).Item("PricePerItem") = CDbl(Request.Form.Item("txtCost"))
            End If
            If request.Form.Item("txtItemID") <> "" Then
                dsItineraryDetail.Tables(0).Rows(0).Item("ItemID") = CLng(Request.Form.Item("txtItemID"))
            Else
                dsItineraryDetail.Tables(0).Rows(0).Item("ItemID") = 0
            End If
            oItineraryDetail.SaveUpdate(dsItineraryDetail)
            Me.Navigate(txtReferer.text)

        End Sub

        Protected Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
            Me.Navigate(txtReferer.text)
        End Sub
        'Protected Sub GetGridValues(ByVal Description As String, ByVal Quantity As Double, ByVal Cost As Double, ByVal ItemID As Long)
        '    txtDescription.Text = Description
        '    txtQuantity.text = CStr(Quantity)
        '    txtCost.text = CStr(Cost)
        '    txtItemID.text = CStr(ItemID)
        'End Sub
    End Class

End Namespace