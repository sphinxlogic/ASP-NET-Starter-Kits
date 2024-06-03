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

    Public Class Profile
        Inherits System.Web.UI.Page
        Public txtBillZip As System.Web.UI.WebControls.TextBox
        Public txtZip As System.Web.UI.WebControls.TextBox
        Public txtBillCountry As System.Web.UI.WebControls.TextBox
                
        Public txtBillState As System.Web.UI.WebControls.TextBox

        Public txtCountry As System.Web.UI.WebControls.TextBox
        Public txtUsePtsHotelPrice As System.Web.UI.WebControls.TextBox
        Public chkUseRoomPts As System.Web.UI.WebControls.CheckBox
        Public cboRoomTypePref As System.Web.UI.WebControls.DropDownList
        Public cboSmokePref As System.Web.UI.WebControls.DropDownList
        Public chkHotel3 As System.Web.UI.WebControls.CheckBox
        Public chkHotel2 As System.Web.UI.WebControls.CheckBox
        Public chkHotel1 As System.Web.UI.WebControls.CheckBox
        Public txtHotel3Num As System.Web.UI.WebControls.TextBox
        Public txtHotel2Num As System.Web.UI.WebControls.TextBox
        Public txtHotel1Num As System.Web.UI.WebControls.TextBox
        Public txtHotel3 As System.Web.UI.WebControls.TextBox
        Public txtHotel2 As System.Web.UI.WebControls.TextBox
        Public txtHotel1 As System.Web.UI.WebControls.TextBox
        Public tblCuisine As System.Web.UI.WebControls.Table
        Public tblActivity As System.Web.UI.WebControls.Table
        Public txtUseFFifMoreThan As System.Web.UI.WebControls.TextBox
        Public chkUseFFifMoreThan As System.Web.UI.WebControls.CheckBox
        Public cboTravelClass As System.Web.UI.WebControls.DropDownList
        Public chkAirline3 As System.Web.UI.WebControls.CheckBox
        Public chkAirline2 As System.Web.UI.WebControls.CheckBox
        Public chkAirline1 As System.Web.UI.WebControls.CheckBox
        Public txtAirline3Num As System.Web.UI.WebControls.TextBox
        Public txtAirline2Num As System.Web.UI.WebControls.TextBox
        Public txtAirline1Num As System.Web.UI.WebControls.TextBox
        Public txtAirline3 As System.Web.UI.WebControls.TextBox
        Public txtAirline2 As System.Web.UI.WebControls.TextBox
        Public txtAirline1 As System.Web.UI.WebControls.TextBox
        
        
        Public txtBillCity As System.Web.UI.WebControls.TextBox
        Public txtBillStreet2 As System.Web.UI.WebControls.TextBox
        Public txtBillStreet1 As System.Web.UI.WebControls.TextBox
        Public chkSameasMailing As System.Web.UI.WebControls.CheckBox
        
        Public txtState As System.Web.UI.WebControls.TextBox
        Public txtCity As System.Web.UI.WebControls.TextBox
        Public txtStreet2 As System.Web.UI.WebControls.TextBox
        Public txtStreet1 As System.Web.UI.WebControls.TextBox
        Public txtLastName As System.Web.UI.WebControls.TextBox
        Public txtFirstName As System.Web.UI.WebControls.TextBox

        Sub Page_Load(ByVal Sender As Object, ByVal e As EventArgs)
            If Not IsPostback Then ' Evals true first time browser hits the page	
                Dim oVistaMemberPref As VistaSiteMgr.MemberPref
                Dim oVistaMember As VistaSiteMgr.Member
                Dim dsMember As DataSet
                Dim dsActivities As DataSet
                Dim dsCuisine As DataSet
                Dim dsMemberActivities As DataSet
                Dim dsMemberCuisine As DataSet
                Dim dsAirlineNumber As DataSet
                Dim dsHotelNumber As DataSet

                Dim tblRow As System.Web.UI.WebControls.TableRow
                Dim tblCell As System.Web.UI.WebControls.TableCell
                Dim chkBox As System.Web.UI.WebControls.CheckBox
                Dim iX As Integer
                Dim iY As Integer

                oVistaMemberPref = New VistaSiteMgr.MemberPref
                dsActivities = New DataSet
                dsCuisine = New DataSet
                dsMember = New DataSet
                dsMemberActivities = New DataSet
                dsMemberCuisine = New DataSet
                dsAirlineNumber = New DataSet
                dsHotelNumber = New DataSet

                dsCuisine = oVistaMemberPref.BrowseByPrefType("Cuisine")
                dsActivities = oVistaMemberPref.BrowseByPrefType("Activity")
                dsMemberActivities = oVistaMemberPref.BrowseByMemberPrefType(1, "Activity")
                dsMemberCuisine = oVistaMemberPref.BrowseByMemberPrefType(1, "Cuisine")
                dsAirlineNumber = oVistaMemberPref.BrowseByMemberPrefType(1, "Airline")
                dsHotelNumber = oVistaMemberPref.BrowseByMemberPrefType(1, "Hotel")

                '*************************************************************                
                'TODO: Do some checking here to see if member already exists
                '      and has logged in or if they are a new member                
                '*************************************************************                
                dsMember = oVistaMember.Load(1)

                For iX = 0 To dsActivities.tables(0).rows.count - 1
                    chkBox = New System.Web.UI.WebControls.CheckBox
                    chkBox.ID = CStr(dsActivities.Tables(0).Rows(iX).Item(0))
                    chkBox.Text = CStr(dsActivities.Tables(0).Rows(iX).Item(2))
                    For iY = 0 To dsMemberActivities.tables(0).rows.count - 1
                        If dsMemberActivities.tables(0).rows(iY).Item("PrefID") = dsActivities.tables(0).rows(iX).Item("PrefID") Then
                            chkBox.Checked = True
                        End If
                    Next iY
                    tblCell = New System.Web.UI.WebControls.Tablecell
                    tblCell.Controls.Add(chkBox)
                    tblRow = New System.Web.UI.WebControls.TableRow
                    tblRow.Cells.Add(tblCell)
                    tblActivity.Rows.Add(tblRow)
                Next iX
                For iX = 0 To dsCuisine.tables(0).rows.count - 1
                    chkBox = New System.Web.UI.WebControls.CheckBox
                    chkBox.ID = CStr(dsCuisine.Tables(0).Rows(iX).Item(0))
                    chkBox.Text = CStr(dsCuisine.Tables(0).Rows(iX).Item(2))
                    For iY = 0 To dsMemberCuisine.tables(0).rows.count - 1
                        If dsMemberCuisine.tables(0).rows(iY).Item("PrefID") = dsCuisine.tables(0).rows(iX).Item("PrefID") Then
                            chkBox.Checked = True
                        End If
                    Next iY
                    tblCell = New System.Web.UI.WebControls.Tablecell
                    tblCell.Controls.Add(chkBox)
                    tblRow = New System.Web.UI.WebControls.TableRow
                    tblRow.Cells.Add(tblCell)
                    tblCuisine.Rows.Add(tblRow)
                Next iX
                
                txtFirstName.Text = dsMember.Tables("Member").Rows(0).Item("First_Name").ToString
                txtLastName.Text = dsMember.Tables("Member").Rows(0).Item("Last_Name").ToString
                txtStreet1.text = dsMember.Tables("Member").Rows(0).Item("StreetAddress1").ToString
                txtStreet2.text = dsMember.Tables("Member").Rows(0).Item("StreetAddress2").ToString
                txtCity.Text = dsMember.Tables("Member").Rows(0).Item("City").ToString
                txtState.Text = dsMember.Tables("Member").Rows(0).Item("State").ToString
                txtZip.Text = dsMember.Tables("Member").Rows(0).Item("PostalCode").ToString
                txtCountry.Text = dsMember.Tables("Member").Rows(0).Item("Country").ToString
                If CBool(dsMember.Tables("Member").Rows(0).Item("BillingAddressSame")) = True Then
                    chkSameasMailing.Checked = True
                Else
                    chkSameasMailing.Checked = False
                    txtBillStreet1.Text = dsMember.Tables("Member").Rows(0).Item("BillingStreetAddress1").ToString
                    txtBillStreet2.text = dsMember.Tables("Member").Rows(0).Item("BillingStreetAddress2").ToString
                    txtBillCity.Text = dsMember.Tables("Member").Rows(0).Item("BillingCity").ToString
                    txtBillState.Text = dsMember.Tables("Member").Rows(0).Item("BillingState").ToString
                    txtBillZip.Text = dsMember.Tables("Member").Rows(0).Item("BillingPostalCode").ToString
                    txtBillCountry.Text = dsMember.Tables("Member").Rows(0).Item("BillingCountry").ToString
                End If
                For iX = 0 To dsAirlineNumber.Tables(0).Rows.count - 1
                    Select Case iX
                        Case 0
                            txtAirline1Num.Text = dsAirlineNumber.Tables(0).Rows(0).Item("MemberPrefValue")
                            txtAirline1.Text = dsAirlineNumber.Tables(0).Rows(0).Item("Description")
                        Case 1
                            txtAirline2Num.Text = dsAirlineNumber.Tables(0).Rows(1).Item("MemberPrefValue")
                            txtAirline2.Text = dsAirlineNumber.Tables(0).Rows(1).Item("Description")
                        Case 2
                            txtAirline3Num.Text = dsAirlineNumber.Tables(0).Rows(2).Item("MemberPrefValue")
                            txtAirline3.Text = dsAirlineNumber.Tables(0).Rows(2).Item("Description")
                    End Select
                Next iX
                For iX = 0 To dsHotelNumber.Tables(0).Rows.count - 1
                    Select Case iX
                        Case 0
                            txtHotel1Num.Text = dsHotelNumber.Tables(0).Rows(0).Item("MemberPrefValue")
                            txtHotel1.Text = dsHotelNumber.Tables(0).Rows(0).Item("Description")
                        Case 1
                            txtHotel2Num.Text = dsHotelNumber.Tables(0).Rows(1).Item("MemberPrefValue")
                            txtHotel2.Text = dsHotelNumber.Tables(0).Rows(1).Item("Description")
                        Case 2
                            txtHotel3Num.Text = dsHotelNumber.Tables(0).Rows(2).Item("MemberPrefValue")
                            txtHotel3.Text = dsHotelNumber.Tables(0).Rows(2).Item("Description")
                    End Select
                Next iX

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
