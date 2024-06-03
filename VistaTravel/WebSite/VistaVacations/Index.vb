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

    Public Class Index
        Inherits System.Web.UI.Page
                Public cmdEscape As System.Web.UI.HtmlControls.HtmlInputButton
                Public MemberName1 As System.Web.UI.HtmlControls.HtmlGenericControl
                Public MemberName As System.Web.UI.HtmlControls.HtmlGenericControl
                Public travelguides As System.Web.UI.WebControls.DropDownList
                Public reservations As System.Web.UI.WebControls.DropDownList
                Public txtReturn As System.Web.UI.WebControls.TextBox
                Public txtLeave As System.Web.UI.WebControls.TextBox
                Public price As System.Web.UI.WebControls.DropDownList
                Public destination As System.Web.UI.WebControls.DropDownList
                Public escapewith As System.Web.UI.WebControls.DropDownList
                Public escapingto As System.Web.UI.WebControls.DropDownList
                Public escapingfrom As System.Web.UI.WebControls.DropDownList
                Public zip As System.Web.UI.WebControls.TextBox
                Public city As System.Web.UI.WebControls.TextBox
                Public Image1 As System.Web.UI.WebControls.Image
                Public searchbox As System.Web.UI.WebControls.TextBox
        
        
        
        
        
                
                
        
        
        
        
        
        
        
        
        
        
        

        Sub Page_Load(ByVal Sender As Object, ByVal e As EventArgs)
            If Not IsPostback Then ' Evals true first time browser hits the page	

                'Populate all combos here based on who the member is...
                Dim oItinerary As VistaSiteMgr.Itinerary
                Dim oMemberPrefs As New vistasitemgr.memberpref()
                Dim dsMemberPref As New dataset()
                Dim dsDataset As New dataset()
                Dim iX As Integer
                Dim iY As Integer
                'Div tags containing the member's name
                MemberName.innerHtml = "<font face='Verdana, Arial, Helvetica' color=#ffcc66 size=1><b>Chris Miller</b></font>"
                MemberName1.innerHtml = "<b>Welcome Chris Miller!</b>"
                
                dsDataset = oItinerary.BrowseByMember(1)
                dsMemberPref = oMemberPrefs.BrowseByMemberPrefType(1, "Activity")
                'Populate Destinations combo
                escapingto.Items.Add("<-EscapingToDo->")
                For iX = 0 To dsMemberPref.Tables(0).Rows.count - 1
                    escapingto.Items.Add(CStr(dsMemberPref.Tables(0).rows(iX).item("Description")))
                    'escapingto.Items.Add(dsMemberPref.Tables(0).rows(iX).item("Description").ToString())
                    'escapingto.Items(iX).Value = dsMemberPref.Tables(0).rows(iX).item("Description")
                Next iX
                'Populate Prices combo
                With price.Items
                    .add("<-EscapingPrice->")
                    .Add("< $250")
                    .Add("< $500")
                    .Add("< $750")
                    .Add("< $1000")
                    .Add("< $1250")
                    .Add("< $1500")
                    .Add("< $1750")
                    .Add("< $2000")
                    .Add("< $2500")
                    .Add("< $3000")
                    .Add("< $4000")
                    .Add("> $4000")
                End With
                'Populate Month Combo
                With destination.Items
                    .add("<-EscapingTo->")
                    .add("Grand Canyon")
                    .add("Lake Tahoe")
                    .add("Vail")
                    .add("The Caribbean")
                    .add("Florida Keys")
                    .add("New York City")
                End With

                With escapewith.Items
                    .add("<-EscapingWith->")
                    .add("Significant Other")
                    .add("Family with Children")
                    .add("Friends")
                    .add("Business Associates")
                    .add("By Yourself")
                End With
                With escapingfrom.Items
                    .add("<-EscapingFrom->")
                    .add("Weather")
                    .add("Work")
                    .add("Children")
                    .add("City Life")
                    .add("Country Life")
                    .add("School")

                End With

                'Format(CStr(Today.AddDays(5 - (Today.DayOfWeek)), "mm/dd/yyyy"))
                txtLeave.Text = CStr(Today.AddDays(5 - (Today.DayOfWeek)))
                txtReturn.Text = CStr(Today.AddDays(7 - (Today.DayOfWeek)))
                'txtLeave.Text = Format(Today.AddDays(5 - (Today.DayOfWeek)), "mm/dd/yyyy")
                'txtReturn.Text = Format(Today.AddDays(7 - (Today.DayOfWeek)), "mm/dd/yyyy")

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

        Protected Sub cmdEscape_ServerClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
    
        End Sub

    End Class

End Namespace
