Option Strict Off
Imports System
Imports System.Collections
Imports System.Core
Imports System.ComponentModel
Imports System.Configuration
Imports System.Data
Imports System.Web.Services
Imports System.Diagnostics
Imports System.Data.XML

Namespace VistaSiteMgr

    Public Class Itinerary
        Inherits System.ComponentModel.Component
        
        'Required by the Component Designer
        Private components As Container
        Private ItinCon As System.Data.ADO.ADOConnection
        Private ItinDSCmd As System.Data.ADO.ADODataSetCommand
        Private ItinDetCon As System.Data.ADO.ADOConnection
        Private ItinDetDSCmd As System.Data.ADO.ADODataSetCommand

        Public Function BrowseByMember(ByVal MemberID As Long) As DataSet

            Dim sSQL As String
            Dim dsMemberInfo As DataSet
            Dim adodscmd As ADO.ADODataSetCommand
            Dim adoconn As ADO.ADOConnection

            Try
                dsMemberInfo = New DataSet
                adodscmd = New ADO.ADODataSetCommand
                adoconn = New ADO.ADOConnection
            
                sSQL = "SELECT ItineraryID, MemberID, StartDate, EndDate, Origin, Destination,"
                sSQL = sSQL & " NumberofPeople, Children, TravelOccassion FROM Itinerary WHERE MemberID = "
                sSQL = sSQL & MemberID

                'PrepSelectADODataSetCommand(OrderDSCmd)			
                adoconn.ConnectionString = "Provider=SQLOLEDB.1;Persist Security Info=False;User ID=sa;Initial Catalog=Profile; Data Source=(local);Use Procedure for Prepare=1;Auto Translate=True;Packet Size=4096;Workstation ID=ENWEIX-RI1;Use Encryption for Data=False;Tag with column collation when possible=False;"
            
                Dim a__10() As System.Data.ADO.ADOParameter
            
                'sSQL = dynamic SQL string 
                adodscmd.SelectCommand = New System.Data.ADO.ADOCommand(adoconn, sSQL, System.Data.CommandType.Text, False, a__10, System.Data.UpdateRowSource.Both)

                Dim a__11(11) As System.Data.Internal.DataColumnMapping
                a__11(0) = New System.Data.Internal.DataColumnMapping("ItineraryID", "ItineraryID")
                a__11(1) = New System.Data.Internal.DataColumnMapping("MemberID", "MemberID")
                a__11(2) = New System.Data.Internal.DataColumnMapping("StartDate", "StartDate")
                a__11(3) = New System.Data.Internal.DataColumnMapping("EndDate", "EndDate")
                a__11(4) = New System.Data.Internal.DataColumnMapping("Origin", "Origin")
                a__11(5) = New System.Data.Internal.DataColumnMapping("Destination", "Destination")

                a__11(6) = New System.Data.Internal.DataColumnMapping("NumberofPeople", "NumberofPeople")
                a__11(7) = New System.Data.Internal.DataColumnMapping("Children", "Children")
                a__11(8) = New System.Data.Internal.DataColumnMapping("TravelOccassion", "TravelOccassion")

                Dim a__12(1) As System.Data.Internal.DataTableMapping
                a__12(0) = New System.Data.Internal.DataTableMapping("Table", "Itinerary", a__11)
                adodscmd.TableMappings.All = a__12

                'Get the data which be stuffed in the DataSet object			
                adodscmd.FillDataSet(dsMemberInfo)

            Catch e As Exception

                General.RaiseException(e)

            End Try

            'Return the data
            BrowseByMember = dsMemberInfo
        
        End Function


        Public Function LoadDailyDetail(ByVal ItineraryID As Long, ByVal Day As Date) As DataSet
            Dim dsDailyDetail As New DataSet()

            Try
                'load the detail for this day
                Me.FillItinDetDataSet(dsDailyDetail, ItineraryID, Day)

            Catch e As Exception

                General.RaiseException(e)

            End Try

            'return the detail for this day
            Return dsDailyDetail

        End Function
        



        Public Function FilteredRetrieve(ByVal ItineraryID As Long) As DataSet

            Dim sSQL As String
            Dim dsRetrieve As DataSet
            Dim adodscmd As ADO.ADODataSetCommand
            Dim adoconn As ADO.ADOConnection
            Try
                dsRetrieve = New DataSet
                adodscmd = New ADO.ADODataSetCommand
                adoconn = New ADO.ADOConnection
            
                sSQL = "SELECT ItineraryDetailID, ItineraryID, ConfirmationNumber, Quantity, PricePerItem, StartDate, EndDate,"
                sSQL = sSQL & " EstimatedCost, Detail, ProviderType, ProviderID, Vendor, ItemID, Status FROM ItineraryDetail WHERE ItineraryID = "
                sSQL = sSQL & ItineraryID & " ORDER BY StartDate"

                'PrepSelectADODataSetCommand(OrderDSCmd)			
                adoconn.ConnectionString = "Provider=SQLOLEDB.1;Persist Security Info=False;User ID=sa;Initial Catalog=Profile; Data Source=(local);Use Procedure for Prepare=1;Auto Translate=True;Packet Size=4096;Workstation ID=ENWEIX-RI1;Use Encryption for Data=False;Tag with column collation when possible=False;"
                Dim a__10() As System.Data.ADO.ADOParameter
            
                'sSQL = dynamic SQL string 
                adodscmd.SelectCommand = New System.Data.ADO.ADOCommand(adoconn, sSQL, System.Data.CommandType.Text, False, a__10, System.Data.UpdateRowSource.Both)

                Dim a__11(14) As System.Data.Internal.DataColumnMapping
                a__11(0) = New System.Data.Internal.DataColumnMapping("ItineraryDetailID", "ItineraryDetailID")
                a__11(1) = New System.Data.Internal.DataColumnMapping("ItineraryID", "ItineraryID")
                a__11(2) = New System.Data.Internal.DataColumnMapping("ConfirmationNumber", "ConfirmationNumber")
                a__11(3) = New System.Data.Internal.DataColumnMapping("Quantity", "Quantity")
                a__11(4) = New System.Data.Internal.DataColumnMapping("PricePerItem", "PricePerItem")
                a__11(5) = New System.Data.Internal.DataColumnMapping("StartDate", "StartDate")
                a__11(6) = New System.Data.Internal.DataColumnMapping("EndDate", "EndDate")
                a__11(7) = New System.Data.Internal.DataColumnMapping("EstimatedCost", "EstimatedCost")
                a__11(8) = New System.Data.Internal.DataColumnMapping("Detail", "Detail")
                a__11(9) = New System.Data.Internal.DataColumnMapping("ProviderType", "ProviderType")
                a__11(10) = New System.Data.Internal.DataColumnMapping("ProviderID", "ProviderID")
                a__11(11) = New System.Data.Internal.DataColumnMapping("Vendor", "Vendor")
                a__11(12) = New System.Data.Internal.DataColumnMapping("ItemID", "ItemID")
                a__11(13) = New System.Data.Internal.DataColumnMapping("Status", "Status")

                Dim a__12(1) As System.Data.Internal.DataTableMapping
                a__12(0) = New System.Data.Internal.DataTableMapping("Table", "ItineraryDetail", a__11)
                adodscmd.TableMappings.All = a__12

                'Get the data which be stuffed in the DataSet object			
                adodscmd.FillDataSet(dsRetrieve)
			
                'Filter dataset.
                FilterItineraryDataSet(dsRetrieve)

            Catch e As Exception

                General.RaiseException(e)

            End Try

            'Return the data
            FilteredRetrieve = dsRetrieve

        End Function

        Public Function Retrieve(ByVal ItineraryID As Long) As DataSet

            Dim sSQL As String
            Dim dsRetrieve As DataSet
            Dim adodscmd As ADO.ADODataSetCommand
            Dim adoconn As ADO.ADOConnection

            Try
                dsRetrieve = New DataSet
                adodscmd = New ADO.ADODataSetCommand
                adoconn = New ADO.ADOConnection
            
                sSQL = "SELECT ItineraryDetailID, ItineraryID, ConfirmationNumber, Quantity, PricePerItem, StartDate, EndDate,"
                sSQL = sSQL & " EstimatedCost, Detail, ProviderType, ProviderID, Vendor, ItemID, Status FROM ItineraryDetail WHERE ItineraryID = "
                sSQL = sSQL & ItineraryID & " ORDER BY StartDate"

                'PrepSelectADODataSetCommand(OrderDSCmd)			
                adoconn.ConnectionString = "Provider=SQLOLEDB.1;Persist Security Info=False;User ID=sa;Initial Catalog=Profile; Data Source=(local);Use Procedure for Prepare=1;Auto Translate=True;Packet Size=4096;Workstation ID=ENWEIX-RI1;Use Encryption for Data=False;Tag with column collation when possible=False;"
                Dim a__10() As System.Data.ADO.ADOParameter
            
                'sSQL = dynamic SQL string 
                adodscmd.SelectCommand = New System.Data.ADO.ADOCommand(adoconn, sSQL, System.Data.CommandType.Text, False, a__10, System.Data.UpdateRowSource.Both)

                Dim a__11(14) As System.Data.Internal.DataColumnMapping
                a__11(0) = New System.Data.Internal.DataColumnMapping("ItineraryDetailID", "ItineraryDetailID")
                a__11(1) = New System.Data.Internal.DataColumnMapping("ItineraryID", "ItineraryID")
                a__11(2) = New System.Data.Internal.DataColumnMapping("ConfirmationNumber", "ConfirmationNumber")
                a__11(3) = New System.Data.Internal.DataColumnMapping("Quantity", "Quantity")
                a__11(4) = New System.Data.Internal.DataColumnMapping("PricePerItem", "PricePerItem")
                a__11(5) = New System.Data.Internal.DataColumnMapping("StartDate", "StartDate")
                a__11(6) = New System.Data.Internal.DataColumnMapping("EndDate", "EndDate")
                a__11(7) = New System.Data.Internal.DataColumnMapping("EstimatedCost", "EstimatedCost")
                a__11(8) = New System.Data.Internal.DataColumnMapping("Detail", "Detail")
                a__11(9) = New System.Data.Internal.DataColumnMapping("ProviderType", "ProviderType")
                a__11(10) = New System.Data.Internal.DataColumnMapping("ProviderID", "ProviderID")
                a__11(11) = New System.Data.Internal.DataColumnMapping("Vendor", "Vendor")
                a__11(12) = New System.Data.Internal.DataColumnMapping("ItemID", "ItemID")
                a__11(13) = New System.Data.Internal.DataColumnMapping("Status", "Status")

                Dim a__12(1) As System.Data.Internal.DataTableMapping
                a__12(0) = New System.Data.Internal.DataTableMapping("Table", "ItineraryDetail", a__11)
                adodscmd.TableMappings.All = a__12

                'Get the data which be stuffed in the DataSet object			
                adodscmd.FillDataSet(dsRetrieve)
			
            Catch e As Exception

                General.RaiseException(e)

            End Try

            'Return the data
            Retrieve = dsRetrieve

        End Function

        Public Function BrowseDestinations(ByVal MemberID As Long, ByVal StartDate As Date, ByVal EndDate As Date, ByVal City As String, ByVal Region As String, ByVal State As String, ByVal Country As String, ByVal Continent As String, ByVal Categories As String) As DataSet
            Dim dsMemberPref As DataSet
            Dim oMemberPref As VistaSiteMgr.MemberPref
            Dim dsDestinations As DataSet
            Dim oActivity As Activity
            Dim sCategories As String
            Dim iX As Integer
            Dim iCounter As Integer

            Try
                oMemberPref = New VistaSiteMgr.MemberPref
                dsMemberPref = New DataSet
                dsDestinations = New DataSet
                oActivity = New Activity

                'Get the Member's Preferences they filled out when they first signed up.
                dsMemberPref = oMemberPref.BrowseByMember(MemberID)
                iCounter = 0
                If Categories = "" Then
                    For iX = 0 To dsMemberPref.tables(0).rows.count - 1
                        If dsMemberPref.Tables(0).Rows(iX).Item("PrefType") = "Activity" Then
                            'Get the member's prefered Activities...
                            If iCounter > 0 Then
                                sCategories = sCategories & "|" & dsMemberPref.Tables(0).Rows(iX).Item("Description")
                            Else
                                sCategories = dsMemberPref.Tables(0).Rows(iX).Item("Description")
                            End If
                            iCounter = iCounter + 1
                        End If
                    Next
                Else
                    sCategories = Categories
                End If
                dsDestinations = oActivity.BrowseByLocation(CStr(StartDate), CStr(EndDate), City, Region, State, Country, Continent, sCategories)
            
            Catch e As Exception

                General.RaiseException(e)

            End Try
         
            'Return a dataset with filtered results.
            BrowseDestinations = dsDestinations
        End Function

        Public Function BuildItinerary(ByVal MemberID As Long, ByVal NumberOfPeople As Integer, ByVal Children As Integer, ByVal TravelOccassion As String, ByVal ArrivalCity As String, ByVal ArrivalState As String, ByVal DepartingDate As Date, ByVal ReturningDate As Date, ByVal Region As String) As DataSet
            Dim oItineraryDetail As VistaSiteMgr.ItineraryDetail
            Dim dsItineraryDetail As New DataSet()
            Dim drNewRow As DataRow
            Dim dsItinerary As DataSet
            Dim oMemberPref As VistaSiteMgr.MemberPref
            Dim dsMemberPrefs As DataSet
            Dim oMember As VistaSiteMgr.Member
            Dim dsMember As DataSet
            Dim dsAirline As DataSet
            Dim sAirline As String
            Dim oHotel As LodgingReservation
            Dim dsHotel As Dataset
            Dim sHotel As String
            Dim oActivity As Activity
            Dim dsActivity As DataSet
            Dim sActivity As String
            Dim sCategories As String
            Dim dblHotelCost As Double
            Dim dsPOI As Dataset
            Dim bHotelFound As Boolean
            Dim bAirlineFound As Boolean
            Dim dDepartureDateTime As Date
            Dim iMAXAirCounter As Long
            Dim iX As Integer
            Dim iY As Integer
            Dim iZ As Integer
            Dim DetailTemplateDS As New DataSet()
            Dim iCurRow As Integer
            Dim iItineraryID As Integer

            Try
                'Initialize flags
                bHotelFound = False
                bAirlineFound = False

                'Get all the Member's Preferences they filled out when they first signed up.
                oMemberPref = New vistasitemgr.MemberPref
                oMember = New VistaSiteMgr.Member
                dsMemberPrefs = oMemberPref.BrowseByMember(MemberID)
                dsMember = oMember.Load(MemberID)
            
                'Pickup variables from Member dataset
                Dim sPassedDepartingCity As String
                Dim sPassedDepartingState As String
            
                sPassedDepartingCity = dsMember.Tables(0).Rows(0).Item("City")
                sPassedDepartingState = dsMember.Tables(0).Rows(0).Item("State")
            
                'Find Member Preferences....
                Dim bAirPrefFound As Boolean
                Dim bHotelPrefFound As Boolean
                Dim bHotelMaxCostFound As Boolean
                bAirPrefFound = False
                bHotelPrefFound = False
                bHotelMaxCostFound = False
                For iX = 0 To dsMemberPrefs.tables(0).rows.count - 1
                    If dsMemberPrefs.Tables(0).Rows(iX).Item("PrefType") = "Airline" Then
                        If bAirPrefFound = False Then
                            'Get the member's prefered airline...
                            sAirline = dsMemberPrefs.Tables(0).Rows(iX).Item("Description")
                            bAirPrefFound = True
                        End If
                    End If
                    If dsMemberPrefs.Tables(0).Rows(iX).Item("PrefType") = "Hotel" Then
                        If bHotelPrefFound = False Then
                            'Get the member's prefered hotel...
                            sHotel = dsMemberPrefs.Tables(0).Rows(iX).Item("Description")
                            dblHotelCost = dsMemberPrefs.Tables(0).Rows(iX).Item("MemberPrefValue")
                            bHotelPrefFound = True
                        End If
                    End If
                    If dsMemberPrefs.Tables(0).Rows(iX).Item("PrefType") = "Hotel" Then
                        If bHotelPrefFound = False Then
                            'Get the max price a person will pay for a hotel...
                            dsMemberPrefs.Tables(0).Rows(iX).Item("Description") = "MaxCost"
                            dblHotelCost = dsMemberPrefs.Tables(0).Rows(iX).Item("MemberPrefValue")
                            bHotelMaxCostFound = True
                        End If
                    End If
                    If iX > 0 Then
                        sCategories = sCategories & "|" & trim(dsMemberPrefs.Tables(0).Rows(iX).Item("Description"))
                    Else
                        sCategories = trim(dsMemberPrefs.Tables(0).Rows(iX).Item("Description"))
                    End If
                Next
            
                'Create New Itinerary header
                dsItinerary = New DataSet
                FillItinDataSet(dsItinerary, 0)
                drNewRow = dsItinerary.Tables(0).NewRow
                drNewRow.Item("MemberID") = MemberID
                drNewRow.Item("StartDate") = DepartingDate
                drNewRow.Item("EndDate") = ReturningDate
                drNewRow.Item("Origin") = sPassedDepartingCity
                drNewRow.Item("Destination") = ArrivalCity
                drNewRow.Item("NumberofPeople") = NumberOfPeople
                drNewRow.Item("Children") = Children
                drNewRow.Item("TravelOccassion") = TravelOccassion
                dsItinerary.Tables(0).Rows.Add(drNewRow)
                'Save high-level itinerary
                dsItinerary = updateitindatasource(dsItinerary)

                'grab the ItinID
                iItineraryID = dsItinerary.Tables(0).Rows(0).Item("ItineraryID")

                'Create an outline of the ItineraryDetail Dataset 
                oItineraryDetail = New VistaSiteMgr.ItineraryDetail
                oItineraryDetail.FillItinDetailDataSet(dsItineraryDetail, 0)

                'Build the shell of the Itinerary Detail Dataset that you are going to fill.
                'Use the departure date and return date as "bookends" to build the dataset.
                Call BuildDetailShell(dsItinerary.Tables(0).Rows(0).Item("ItineraryID"), DepartingDate, ReturningDate, dsItineraryDetail, DetailTemplateDS)

                iCurRow = 0
                If FindFlight(dsItineraryDetail, iCurRow, dsMemberPrefs, sPassedDepartingCity, ArrivalCity, sAirline, iItineraryID, DepartingDate) Then

                End If

                iCurRow = iCurRow + 1
                If FindFlight(dsItineraryDetail, iCurRow, dsMemberPrefs, ArrivalCity, sPassedDepartingCity, sAirline, iItineraryID, ReturningDate) Then

                End If

                'Get Hotel info...
                'Assume that you want to put the Hotel after the airline (checkin...)
                oHotel = New LodgingReservation
                dsHotel = oHotel.Browse(ArrivalCity, ArrivalState, dblHotelCost, DepartingDate, "")
                For iX = 0 To dsHotel.Tables(0).Rows.Count - 1
                    For iY = 0 To dsMemberPrefs.Tables(0).Rows.COunt - 1
                        If sHotel = dsHotel.Tables(0).Rows(iX).Item("Chain") Then
                            'Populate ItineraryDetail dataset with first hotel that matches prefs.
                            drNewRow.Item("ConfirmationNumber") = 0 'Not Set Yet.
                            dsItineraryDetail.Tables(0).Rows(iCurRow + 1).Item("Quantity") = 1 'Quantity
                            dsItineraryDetail.Tables(0).Rows(iCurRow + 1).Item("PricePerItem") = dsHotel.Tables(0).Rows(iX).Item("MaxRate") 'PricePerItem
                            dsItineraryDetail.Tables(0).Rows(iCurRow + 1).Item("EstimatedCost") = dsHotel.Tables(0).Rows(iX).Item("MaxRate")
                            dsItineraryDetail.Tables(0).Rows(iCurRow + 1).Item("Detail") = dsHotel.Tables(0).Rows(iX).Item("Chain") & " in " & trim(dsHotel.Tables(0).Rows(iX).Item("City")) & ", " & dsHotel.Tables(0).Rows(iX).Item("State") & " at " & dsHotel.Tables(0).Rows(iX).Item("Address")
                            dsItineraryDetail.Tables(0).Rows(iCurRow + 1).Item("ProviderType") = "Hotel"
                            dsItineraryDetail.Tables(0).Rows(iCurRow + 1).Item("ProviderID") = 1 ' Lodging Provider
                            dsItineraryDetail.Tables(0).Rows(iCurRow + 1).Item("Vendor") = dsHotel.Tables(0).Rows(iX).Item("Chain")
                            dsItineraryDetail.Tables(0).Rows(iCurRow + 1).Item("StartDate") = DepartingDate & " 12:00:00 PM "
                            dsItineraryDetail.Tables(0).Rows(iCurRow + 1).Item("EndDate") = DepartingDate & " 12:00:00 PM "
                            dsItineraryDetail.Tables(0).Rows(iCurRow + 1).Item("ItemID") = 0
                            dsItineraryDetail.Tables(0).Rows(iCurRow + 1).Item("Status") = "NB"
                            bHotelFound = True
                        End If
                    Next iY
                Next iX
                If bHotelFound = False Then
                    'Take the first hotel listed in the dataset - should be the cheepest.                
                    dsItineraryDetail.Tables(0).Rows(iCurRow + 1).Item("ConfirmationNumber") = 0 'Not Set Yet.
                    dsItineraryDetail.Tables(0).Rows(iCurRow + 1).Item("Quantity") = 1 'Quantity
                    dsItineraryDetail.Tables(0).Rows(iCurRow + 1).Item("PricePerItem") = dsHotel.Tables(0).Rows(0).Item("MaxRate") 'PricePerItem
                    dsItineraryDetail.Tables(0).Rows(iCurRow + 1).Item("EstimatedCost") = dsHotel.Tables(0).Rows(0).Item("MaxRate")
                    dsItineraryDetail.Tables(0).Rows(iCurRow + 1).Item("Detail") = dsHotel.Tables(0).Rows(0).Item("Chain") & " in " & trim(dsHotel.Tables(0).Rows(0).Item("City")) & ", " & dsHotel.Tables(0).Rows(0).Item("State") & " at " & dsHotel.Tables(0).Rows(0).Item("Address")
                    dsItineraryDetail.Tables(0).Rows(iCurRow + 1).Item("ProviderType") = "Hotel"
                    dsItineraryDetail.Tables(0).Rows(iCurRow + 1).Item("ProviderID") = 1 ' Lodging Provider                
                    dsItineraryDetail.Tables(0).Rows(iCurRow + 1).Item("Vendor") = dsHotel.Tables(0).Rows(0).Item("Chain")
                    dsItineraryDetail.Tables(0).Rows(iCurRow + 1).Item("ItemID") = dsHotel.Tables(0).Rows(0).Item("FacilityID")
                    dsItineraryDetail.Tables(0).Rows(iCurRow + 1).Item("Status") = "NB"
                    dsItineraryDetail.Tables(0).Rows(iCurRow + 1).Item("StartDate") = DepartingDate & " 12:00:00 PM "
                    dsItineraryDetail.Tables(0).Rows(iCurRow + 1).Item("EndDate") = DepartingDate & " 12:00:00 PM "
                    bHotelFound = True
                End If
               
                'POINTS OF INTEREST
                oActivity = New activity
                dsActivity = oActivity.BrowseByLocation(CStr(DepartingDate), CStr(ReturningDate), "", Region, "", "", "", "")
                
                Dim iProximityID As Long
                Dim sCollection As New Collections.StringCollection()
                Dim iC As Long
                Dim blnAddIt As Boolean
                Dim blnFirst As Boolean
                Dim r As Integer
                Dim t As Integer
                Dim v As Integer
                Dim CurrentDate As String
                Dim blnGoToNextDay As Boolean
                Dim tempDate As String
                Dim blnHaveDinnerForDay As Boolean

                CurrentDate = CStr(DepartingDate)
                iY = iCurRow + 2
                blnFirst = True
                blnHaveDinnerForDay = False
                blnGoToNextDay = False
                v = 0
                'do # of days in trip
                
                For t = 0 To DateDiff(6, DepartingDate, ReturningDate)
                
                    If blnFirst = True Then
                        'we always start the first day at 2 PM because of flights and checking
                        'into hotels
                        r = 14
                        blnFirst = False
                    Else
                        'start every other day at 8 AM
                        r = 8
                    End If
                          
                    'loop through hours in the day to do stuff
                    Do While r < 20
                        'do hours in a day
                        Do While v < dsActivity.Tables(0).Rows.Count - 1
                            'Don't schedule dining activities during the day
                            If dsActivity.Tables(0).Rows(v).Item("DiningAvailable") = False Then
                                'if there is not enough time today - do this first thing tomorrow moring
                                If r + CInt(CInt(dsActivity.Tables(0).Rows(v).Item("RequiredTime"))) < 22 Then
                                    'finally schedule this activity in our itinerary!!
                                    dsItineraryDetail.Tables(0).Rows(iY).Item("ConfirmationNumber") = 0 'Not Set Yet.
                                    dsItineraryDetail.Tables(0).Rows(iY).Item("Quantity") = 1 'Quantity
                                    dsItineraryDetail.Tables(0).Rows(iY).Item("PricePerItem") = 0 'dsActivity.Tables(0).Rows(0).Item("MaxRate") 'PricePerItem                                    dsItineraryDetail.Tables(0).Rows(iY).Item("EndDate") = CurrentDate & " " & r & ":00:00" 'dsItineraryDetail.tables(0).rows(iX).Item("EndDate")
                                    dsItineraryDetail.Tables(0).Rows(iY).Item("EstimatedCost") = 0 'dsActivity.Tables(0).Rows(0).Item("MaxRate")
                                    dsItineraryDetail.Tables(0).Rows(iY).Item("Detail") = dsActivity.Tables(0).Rows(v).Item("Name")
                                    dsItineraryDetail.Tables(0).Rows(iY).Item("ProviderType") = "Activity"
                                    dsItineraryDetail.Tables(0).Rows(iY).Item("ProviderID") = 3 ' Lodging Provider
                                    dsItineraryDetail.Tables(0).Rows(iY).Item("Vendor") = dsActivity.Tables(0).Rows(v).Item("LocationName")
                                    dsItineraryDetail.Tables(0).Rows(iY).Item("ItemID") = dsActivity.Tables(0).Rows(v).Item("ActivityLocationID")
                                    dsItineraryDetail.Tables(0).Rows(iY).Item("Status") = "NB"
                                    tempDate = ""
                                    tempDate = CurrentDate & " " & r & ":00:00"
                                    dsItineraryDetail.Tables(0).Rows(iY).Item("StartDate") = CDate(tempDate)
                                    tempDate = ""
                                    tempDate = CurrentDate & " " & (r + CInt(dsActivity.Tables(0).Rows(v).Item("RequiredTime"))) & ":00:00"
                                    dsItineraryDetail.Tables(0).Rows(iY).Item("EndDate") = CDate(tempDate)

                                    iProximityID = dsActivity.tables(0).rows(v).Item("ActivityLocationID")
                                    sCollection.Add(dsActivity.tables(0).rows(v).Item("ActivityID"))
                                    
                                    v = v + 1
                                    iY = iY + 1
                                    'this will set the value of when we can start our next activity
                                    r = r + CInt(CInt(dsActivity.Tables(0).Rows(v).Item("RequiredTime")))
                                    'get the next activity to do today        
                                    Exit Do
                                                       
                                Else
                                    'skip to tomorrow somehow
                                    blnGoToNextDay = True
                                    Exit Do
                                End If
                            End If

                            v = v + 1
                        Loop

                        'we didn't have enought tim this particular day to comlete this activity
                        'so schedule it first thing tomorrow moring
                        If blnGoToNextDay = True Then
                            Exit Do
                        End If
                    
                    Loop
                    'don't add adinner option for the last night
                    If Not CDate(ReturningDate) = CDate(CurrentDate) Then
                        'add dinner options for each night
                        dsItineraryDetail.Tables(0).Rows(iY).Item("ConfirmationNumber") = 0 'Not Set Yet.
                        dsItineraryDetail.Tables(0).Rows(iY).Item("Quantity") = 0 'Quantity
                        dsItineraryDetail.Tables(0).Rows(iY).Item("PricePerItem") = 0 'PricePerItem
                        dsItineraryDetail.Tables(0).Rows(iY).Item("EstimatedCost") = 0
                        dsItineraryDetail.Tables(0).Rows(iY).Item("Detail") = "Dining Options..."
                        dsItineraryDetail.Tables(0).Rows(iY).Item("ItemID") = iProximityID
                        dsItineraryDetail.Tables(0).Rows(iY).Item("Status") = "BD"
                        tempDate = ""
                        tempDate = CurrentDate & " 20:00:00"
                        dsItineraryDetail.Tables(0).Rows(iY).Item("StartDate") = CDate(tempDate)
                        tempDate = ""
                        tempDate = CurrentDate & " 22:00:00"
                        dsItineraryDetail.Tables(0).Rows(iY).Item("EndDate") = CDate(tempDate)

                        iY = iY + 1

                    End If

                    'increment the current day
                    CurrentDate = CStr(dateandtime.DateAdd(DateInterval.Day, 1, CDate(CurrentDate)))
                    'increment the ItineraryDetail row we are on                
                Next t
                'Only save times that have been populated...filter out others...
                'Copy built itinerarydetail with place holders to the
                'Dataset that is going to be returned.
                Dim dsReturnItineraryDetail As New DataSet()
                dsReturnItineraryDetail = dsItineraryDetail.GetChanges
                Dim bDoneFlag As Boolean
                bDoneFlag = False
                'Recursively call to clean out place holders.
                While bDoneFlag = False
                    CleanPlaceHolders(dsItineraryDetail, bDoneFlag)
                End While
                'Save the dataset you have dynamically created...without placeholders!!!
                dsItineraryDetail = oItineraryDetail.Save(dsItineraryDetail)


                FillItinDetDataSet(DetailTemplateDS, dsItinerary.Tables(0).Rows(0).Item("ItineraryID"), CDate(DepartingDate))


            Catch e As Exception

                General.RaiseException(e)

            End Try

            'Return the saved dataset...
            'this will return the itinerary for the first day
            'every day after this, another methods will be called to load it's daily detail
            Return DetailTemplateDS
            'BuildItinerary = dsReturnItineraryDetail
    

        End Function
        
        Private Function FindFlight(ByRef dsItineraryDetail as DataSet, byval CurRow as integer, byref dsMemberPrefs as DataSet, _
                                    byval DepartureCity as String, ByVal ArrivalCity as String, ByVal Airline as String, _                                   
                                    ByVal ItineraryID as Integer, ByVal DepartureDate as Date) as Boolean

            'Given the dsDestinationInfo dataset get Flight info...
            'Define variables to hold elements of XML string            
            Dim oAirline As AirlineServiceServiceService
            Dim oXML As New MSXML2.DOMDocument26()
            Dim xmlAirline As String
            Dim xmlFlightID As String
            Dim xmlAirlineName As String
            Dim xmlFlightNumber As String
            Dim xmlDepartureTime As String
            Dim xmlDepartureAirport As String
            Dim xmlDepartureCity As String
            Dim xmlArrivalAirport As String
            Dim xmlArrivalCity As String
            Dim xmlCost As String
            Dim xmlFlightTime As String
            Dim xmlFlightMiles As String
            Dim iCurRow As Integer
            Dim x As Integer
            Dim y As Integer
            Dim bAirlineFound As Boolean

            oAirline = New AirlineServiceServiceService
            xmlAirline = oAirline.FindFlight(DepartureCity, ArrivalCity, Airline)
                        
            If oXML.loadXML(xmlAirline) = True Then
                'can grab the first flight since it's the lowest fare ince case
                'we don't find our preferred carrier
                xmlFlightID = oXML.selectSingleNode("//FlightID").text
                xmlAirlineName = oXML.selectSingleNode("//Airline").text
                xmlFlightNumber = oXML.selectSingleNode("//FlightNumber").text
                xmlDepartureTime = oXML.selectSingleNode("//DepartureTime").text
                xmlDepartureAirport = oXML.selectSingleNode("//DepartureAirport").text
                xmlDepartureCity = oXML.selectSingleNode("//DepartureCity ").text
                xmlArrivalAirport = oXML.selectSingleNode("//ArrivalAirport").text
                xmlArrivalCity = oXML.selectSingleNode("//ArrivalCity").text
                xmlCost = oXML.selectSingleNode("//Cost").text
                xmlFlightTime = oXML.selectSingleNode("//FlightTime").text
                xmlFlightMiles = oXML.selectSingleNode("//FlightMiles").text

                'now check for our preferred airlines
                x = 0
                y = 0
                Do While X < oXML.childnodes.length
                    Do While y < dsMemberPrefs.Tables(0).Rows.COunt
                        If dsMemberPrefs.Tables(0).Rows(Y).Item("Description") = oXML.selectSingleNode("//Airline").text Then
                            'iFill variables with elements from resulting XML string.
                            xmlFlightID = oXML.selectSingleNode("//FlightID").text
                            xmlAirlineName = oXML.selectSingleNode("//Airline").text
                            xmlFlightNumber = oXML.selectSingleNode("//FlightNumber").text
                            xmlDepartureTime = oXML.selectSingleNode("//DepartureTime").text
                            xmlDepartureAirport = oXML.selectSingleNode("//DepartureAirport").text
                            xmlDepartureCity = oXML.selectSingleNode("//DepartureCity ").text
                            xmlArrivalAirport = oXML.selectSingleNode("//ArrivalAirport").text
                            xmlArrivalCity = oXML.selectSingleNode("//ArrivalCity").text
                            xmlCost = oXML.selectSingleNode("//Cost").text
                            xmlFlightTime = oXML.selectSingleNode("//FlightTime").text
                            xmlFlightMiles = oXML.selectSingleNode("//FlightMiles").text
                            Exit Do
                        End If
                        y = y + 1
                    Loop
                    x = x + 1
                Loop

                'add the flight info into our itinerary
                'need to make sure we are adding this to the right place
                dsItineraryDetail.Tables(0).Rows(CurRow).Item("ItineraryID") = ItineraryID
                dsItineraryDetail.Tables(0).Rows(CurRow).Item("ConfirmationNumber") = 0 'Not Set Yet.
                dsItineraryDetail.Tables(0).Rows(CurRow).Item("Quantity") = 1 'Quantity
                dsItineraryDetail.Tables(0).Rows(CurRow).Item("PricePerItem") = xmlCost 'PricePerItem
                'still need to get the times correct
                dsItineraryDetail.Tables(0).Rows(CurRow).Item("StartDate") = DepartureDate & " " & xmlDepartureTime
                dsItineraryDetail.Tables(0).Rows(CurRow).Item("EndDate") = DepartureDate & " " & xmlDepartureTime
                dsItineraryDetail.Tables(0).Rows(CurRow).Item("EstimatedCost") = xmlCost
                dsItineraryDetail.Tables(0).Rows(CurRow).Item("Detail") = Airline & " " & xmlFlightNumber & " " & xmlDepartureAirport & " TO " & xmlArrivalAirport
                dsItineraryDetail.Tables(0).Rows(CurRow).Item("ProviderType") = "Airline"
                dsItineraryDetail.Tables(0).Rows(CurRow).Item("ProviderID") = 2 'Airline reservations
                dsItineraryDetail.Tables(0).Rows(CurRow).Item("Vendor") = Airline
                dsItineraryDetail.Tables(0).Rows(CurRow).Item("ItemID") = 0
                dsItineraryDetail.Tables(0).Rows(CurRow).Item("Status") = "NB"

                FindFlight = True
            Else
                'we didn't find any flights
                FindFlight = False
            End If
        End Function

        Private Sub CleanPlaceHolders(ByRef dsItineraryDetail As DataSet, ByRef bDoneFlag As Boolean)
            Dim iX As Long
            Try
                bDoneFlag = True
                For iX = 0 To dsItineraryDetail.tables(0).rows.count - 1
                    If isdbnull(dsItineraryDetail.tables(0).rows(iX).item("Detail")) Then
                        dsItineraryDetail.Tables(0).Rows.Remove(iX)
                        bDoneFlag = False
                        Exit Sub
                    Else
                        If CStr(dsItineraryDetail.tables(0).rows(iX).item("Detail")) = "" Then
                            dsItineraryDetail.Tables(0).Rows.Remove(iX)
                            bDoneFlag = False
                            Exit Sub
                        End If
                    End If
                Next

            Catch e As Exception

                General.RaiseException(e)

            End Try

        End Sub

        Public Sub BuildDetailShell(ByVal ItineraryID As Integer, ByVal DepartureDate As Date, ByVal ReturnDate As Date, ByRef dsItineraryDetail As DataSet, ByVal DetailTemplateDS As DataSet)
            Dim iX As Integer
            Dim iY As Integer
            Dim tCurTime As Date
            Dim tStopTime As Date
            Dim dCurDate As Date
            Dim drRow As DataRow
            Dim i As Integer

            Try
                dCurDate = DepartureDate
                While dCurDate <= ReturnDate
                    tCurTime = CDate(FormatDateTime(dCurDate, DateFormat.ShortDate))
                    tStopTime = DateAndTime.DateAdd(DateInterval.Hour, 22, tCurTime)
                    tCurTime = DateAndTime.DateAdd(DateInterval.Hour, 6, tCurTime)
                    'For i = 1 To DetailTemplateDS.tables(0).rows.count
                    While dateandtime.TimeValue(CStr(tCurTime)) <= dateandtime.TimeValue(CStr(tStopTime))
                        drRow = dsItineraryDetail.Tables(0).NewRow
                        drRow.Item("ItineraryID") = ItineraryID
                        drRow.Item("StartDate") = dateandtime.TimeValue(CStr(tCurTime))
                        dsItineraryDetail.Tables(0).Rows.Add(drRow)
                        tCurTime = dateandtime.DateAdd(DateInterval.Hour, 2, tCurTime)
                    End While
                    'Next i
                    dCurDate = dateandtime.DateAdd(DateInterval.Day, 1, dCurDate)
                End While

            Catch e As Exception

                General.RaiseException(e)

            End Try
   

        End Sub

        Private Function FilterItineraryDataSet(ByRef dsItinerary As DataSet)
            Dim dtNew As DataTable
            Dim dcNew As DataColumn
            Dim drNew As DataRow
            Dim iY As Integer
            Dim iZ As Integer
            Dim bFound As Boolean
            Dim dtMaxDate As Date
            Dim dtMinDate As Date
            Dim dtCounter As Date
            Dim lTempTime As Long
            Dim iX As Long

            'Now call ItineraryDetail_LoadNew stored proc to grab a template IntineraryDetail dataset
            Try
                dtNew = New DataTable
            
                dcNew = New DataColumn
                dcNew.ColumnName = "ItineraryDetailID"
                dcNew.Unique = False
                dcNew.AllowNull = True
                dcNew.DefaultValue = 0
                'Add the column
                dtNew.Columns().Add(dcNew)

                dcNew = New DataColumn
                dcNew.ColumnName = "Time"
                dcNew.Unique = False
                dcNew.AllowNull = True
                dcNew.DefaultValue = "8:00:00 AM"
                'Add the column
                dtNew.Columns.Add(dcNew)
    
                dcNew = New DataColumn
                dcNew.ColumnName = "Information"
                dcNew.Unique = False
                dcNew.AllowNull = True
                dcNew.DefaultValue = ""
                'Add the column
                dtNew.Columns().Add(dcNew)

                dcNew = New DataColumn
                dcNew.ColumnName = "ConfirmationNumber"
                dcNew.Unique = False
                dcNew.AllowNull = True
                dcNew.DefaultValue = ""
                'Add the column
                dtNew.Columns().Add(dcNew)
                If dsItinerary.Tables(0).Rows.Count > 0 Then
                    dtMaxDate = CDate(dsItinerary.Tables(0).Rows(0).Item(5))
                    dtMinDate = CDate(dsItinerary.Tables(0).Rows(0).Item(5))
                End If
                For iZ = 0 To dsItinerary.Tables(0).Rows.Count - 1
                    If FormatDateTime(CDate(dsItinerary.Tables(0).Rows(iZ).Item(5)), Microsoft.VisualBasic.DateFormat.ShortDate) > FormatDateTime(CDate(dtMaxDate), Microsoft.VisualBasic.DateFormat.ShortDate) Then
                        dtMaxDate = CDate(FormatDateTime(CDate(dsItinerary.Tables(0).Rows(iZ).Item(5)), Microsoft.VisualBasic.DateFormat.ShortDate))
                    ElseIf FormatDateTime(CDate(dsItinerary.Tables(0).Rows(iZ).Item(5)), Microsoft.VisualBasic.DateFormat.ShortDate) < FormatDateTime(CDate(dtMinDate), Microsoft.VisualBasic.DateFormat.ShortDate) Then
                        dtMinDate = CDate(FormatDateTime(CDate(dsItinerary.Tables(0).Rows(iZ).Item(5)), Microsoft.VisualBasic.DateFormat.ShortDate))
                    End If
                Next iZ

                dtNew.TableName = "CalendarView"

                dtCounter = CDate(FormatDateTime(dtMinDate, Microsoft.VisualBasic.DateFormat.ShortDate))

                Do While CDate(dtCounter) <= CDate(dtMaxDate)
                    bFound = False
                    For iX = 0 To 7 'Populate each period of the day...
                        drNew = dtNew.NewRow
                        lTempTime = (8 + (iX * 2))
                        If lTempTime < 12 Then
                            drNew(1) = lTempTime & ":00:00 AM"
                        ElseIf lTempTime = 12 Then
                            drNew(1) = "12:00:00 PM"
                        Else
                            drNew(1) = (lTempTime - 12) & ":00:00 PM"
                        End If
                   
                        For iY = 0 To dsItinerary.Tables(0).Rows.Count - 1
                            If CDate(FormatDateTime(CDate(dsItinerary.Tables(0).Rows(iY).Item(5)), Microsoft.VisualBasic.DateFormat.ShortDate)) = CDate(FormatDateTime(dtCounter, Microsoft.VisualBasic.DateFormat.ShortDate)) Then
                                If FormatDateTime(dsItinerary.Tables(0).Rows(iY).Item(5), Microsoft.VisualBasic.DateFormat.ShortTime) >= formatdatetime(CDate(8 + (iX * 2) & ":00"), Microsoft.VisualBasic.DateFormat.ShortTime) Then
                                    If iX < 7 Then
                                        If FormatDateTime(CDate(10 + (iX * 2) & ":00"), Microsoft.VisualBasic.DateFormat.ShortTime) > FormatDateTime(CDate(dsItinerary.Tables(0).Rows(iY).Item(5)), Microsoft.VisualBasic.DateFormat.ShortTime) Then
                                            'ItineraryDetailID
                                            drNew(0) = dsItinerary.Tables(0).Rows(iY).Item(0)
                                            'Detail                                        
                                            drNew(2) = dsItinerary.Tables(0).Rows(iY).Item(8)
                                            'ConfirmationNumber - should this be here yet???????                                        
                                            drNew(3) = dsItinerary.Tables(0).Rows(iY).Item(2)
                                            bFound = True
                                            dtNew.Rows.Add(drNew)
                                            Exit For
                                        End If
                                    End If
                                End If
                            End If
                        Next iY
                    
                        If bFound = False Then
                            drNew(0) = 0
                            drNew(2) = " "
                            drNew(3) = " "
                            dtNew.Rows.Add(drNew)
                        Else
                            bFound = False
                        End If
                    Next iX
        
                    dtCounter = dateandtime.DateAdd(Microsoft.VisualBasic.DateInterval.Day, 1, dtcounter)
                Loop

            Catch e As Exception

                General.RaiseException(e)

            End Try

            dsItinerary = dtNew.DataSet
        End Function

        Public Function BookIt(ByVal MemberID As Long, ByVal ItineraryID As Long, ByVal CreditCardType As String, ByVal CreditCardNumber As String, ByVal CreditCardExpireDate As Date)
            Dim dsMember As DataSet
            Dim oMember As VistaSiteMgr.Member
            Dim dsDetail As DataSet
            Dim dsMemberPrefs As DataSet
            Dim oMemberPrefs As VistaSiteMgr.MemberPref
            Dim oDetail As VistaSiteMgr.ItineraryDetail
            Dim dsItineraryDetail As DataSet
            Dim iX As Integer
            Dim iY As Integer
          
            Try
                dsDetail = Retrieve(ItineraryID)
                oMemberPrefs = New vistasitemgr.MemberPref
                dsMemberPrefs = oMemberPrefs.BrowseByMember(MemberID)
                oMember = New VistaSiteMgr.Member
                dsMember = oMember.Load(MemberID)
                oDetail = New VistaSiteMgr.ItineraryDetail
                
                For iX = 0 To dsDetail.tables(0).rows.count - 1
                    If Not dsDetail.Tables(0).Rows(iX).Item("ProviderID").isnull Then
                        Select Case CInt(dsDetail.Tables(0).Rows(iX).Item("ProviderID"))
                            Case 1
                                'Airline
                                'Check to make sure that the detail has not been booked yet.
                                If dsItineraryDetail.Tables(0).Rows(iX).Item("Status") = "NB" Then
                                    'NOT IMPLEMENTED
                                    'Dim oAirline As AirReservation
                                    'Dim sAirline As String
                                    'Dim lRC As Long
                                    'oAirline = New AirReservation
                                    'sAirline = oAirline.Load(0)
                                    'TODO: Figure out how to populate the XML string...
                                    'lrc = oAirline.Save()
                                    'NOT IMPLEMENTED
                                End If

                            Case 2
                                'Check to make sure that the detail has not been booked yet.
                                If dsItineraryDetail.Tables(0).Rows(iX).Item("Status") = "NB" Then
                                    'Hotel
                                    Dim oHotel As LodgingReservation
                                    Dim dsHotel As DataSet
                                    Dim drRow As DataRow
                                    Dim lRC As Long
                                    oHotel = New LodgingReservation
                                    dsHotel = oHotel.Create
                                    drRow = dsHotel.Tables(0).NewRow
                                    drRow.Item("FacilityID") = dsItineraryDetail.Tables(0).Rows(iX).Item("ProviderID")
                                    drRow.Item("ArrivalDate") = dsItineraryDetail.Tables(0).Rows(iX).Item("StartDate")
                                    drRow.Item("Nights") = dateandtime.DateDiff(DateInterval.Day, CDate(dsItineraryDetail.Tables(0).Rows(iX).Item("StartDate")), CDate(dsItineraryDetail.Tables(0).Rows(iX).Item("EndDate")))
                                    drRow.Item("BillingContact") = dsMember.Tables(0).Rows(0).Item("Title") & " " & dsMember.Tables(0).Rows(0).Item("First_Name") & " " & dsMember.Tables(0).Rows(0).Item("Last_Name")
                                    If dsMember.Tables(0).Rows(0).Item("BillingAddressSame") = 1 Then
                                        drRow.Item("BillingAddress") = dsMember.Tables(0).Rows(0).Item("StreetAddress1") & " " & dsMember.Tables(0).Rows(0).Item("StreetAddress2") & " " & dsMember.Tables(0).Rows(0).Item("Apartment")
                                        drRow.Item("BillingCity") = dsMember.Tables(0).Rows(0).Item("City")
                                        drRow.Item("BillingState") = dsMember.Tables(0).Rows(0).Item("State")
                                        drRow.Item("BillingPostalCode") = dsMember.Tables(0).Rows(0).Item("PostalCode")
                                    Else
                                        drRow.Item("BillingAddress") = dsMember.Tables(0).Rows(0).Item("BillingStreet1") & " " & dsMember.Tables(0).Rows(0).Item("BillingStreet2") & " " & dsMember.Tables(0).Rows(0).Item("BillingApartment")
                                        drRow.Item("BillingCity") = dsMember.Tables(0).Rows(0).Item("BillingCity")
                                        drRow.Item("BillingState") = dsMember.Tables(0).Rows(0).Item("BillingState")
                                        drRow.Item("BillingPostalCode") = dsMember.Tables(0).Rows(0).Item("BillingPostalCode")
                                    End If
                                    For iY = 0 To dsMemberPrefs.tables(0).rows.count - 1
                                        If dsMemberPrefs.Tables(0).Rows(iY).Item("PrefType") = "HotelSmoking" Then
                                            drRow.Item("Smoking") = dsMemberPrefs.Tables(0).Rows(iX).Item("MemberPrefValue")
                                        End If
                                        If dsMemberPrefs.Tables(0).Rows(iY).Item("PrefType") = "HotelBedType" Then
                                            drRow.Item("BedType") = dsMemberPrefs.Tables(0).Rows(iX).Item("MemberPrefValue")
                                        End If
                                    Next
                                    drRow.Item("CardType") = Creditcardtype
                                    drRow.Item("CardNumber") = CreditcardNumber
                                    drRow.Item("ExpirationDate") = CStr(CreditcardExpireDate)
                                    dsHotel.Tables(0).Rows.Add(drRow)
                                    'LRC = Confirmation Number
                                    lrc = oHotel.Save(dsHotel)
                                    dsItineraryDetail.Tables(0).Rows(iX).Item("ConfirmationNumber") = lrc
                                    dsItineraryDetail.Tables(0).Rows(iX).Item("Status") = "B"
                                End If
                            Case 3
                                'POI
                                Dim oPOI As Order
                                Dim dsPOI As DataSet
                                Dim drRow As DataRow
                                Dim lRC As Long
                                oPOI = New Order
                                dsPoi = oPoi.Create
                                drRow = dsPOI.Tables(0).NewRow
                                drRow.Item("ServiceID") = "1"
                                drRow.Item("ConfirmationNumber") = "1"
                                drRow.Item("DateTime") = now
                                drRow.Item("FName") = dsItineraryDetail.Tables(0).Rows(iX).Item("First_Name")
                                drRow.Item("lName") = dsItineraryDetail.Tables(0).Rows(iX).Item("Last_Name")
                                drRow.Item("CCType") = CreditCardType
                                drRow.Item("CCNumber") = CreditCardNumber
                                drRow.Item("CCExpDate") = CreditCardExpireDate
                                If dsMember.Tables(0).Rows(0).Item("BillingAddressSame") = 1 Then
                                    drRow.Item("Address") = dsMember.Tables(0).Rows(0).Item("StreetAddress1") & " " & dsMember.Tables(0).Rows(0).Item("StreetAddress2") & " " & dsMember.Tables(0).Rows(0).Item("Apartment") & " " & dsMember.Tables(0).Rows(0).Item("City") & " " & dsMember.Tables(0).Rows(0).Item("State") & " " & dsMember.Tables(0).Rows(0).Item("PostalCode")
                                Else
                                    drRow.Item("BillingAddress") = dsMember.Tables(0).Rows(0).Item("BillingStreet1") & " " & dsMember.Tables(0).Rows(0).Item("BillingStreet2") & " " & dsMember.Tables(0).Rows(0).Item("BillingApartment") & " " & dsMember.Tables(0).Rows(0).Item("BillingCity") & " " & dsMember.Tables(0).Rows(0).Item("BillingState") & " " & dsMember.Tables(0).Rows(0).Item("BillingPostalCode")
                                End If
                                dsPoi.Tables(0).Rows.Add(drRow)
                                lrc = oPOI.Save(dsPoi)
                                dsItineraryDetail.Tables(0).Rows(iX).Item("ConfirmationNumber") = lrc
                                dsItineraryDetail.Tables(0).Rows(iX).Item("Status") = "B"
                            
                            Case 4
                                'Products
                        case else
                                
                        End Select
                    End If
                Next

            Catch e As Exception

                General.RaiseException(e)

            End Try


        End Function

        Public Function UpdateItinDataSource(ByVal updatedDataSet As System.Data.DataSet) As System.Data.DataSet
            'Update DataSet with data from all adapters
            Try
                Me.ItinDSCmdUpdateDataSource(updatedDataSet)

                Return updatedDataSet


            Catch e As Exception

                General.RaiseException(e)

            End Try
   
        End Function



        Private Function ItinDSCmdUpdateDataSource(ByRef updatedDataSet As System.Data.DataSet) As Integer
            Dim DeletedRows As System.Data.DataSet

            Dim UpdatedRows As System.Data.DataSet

            Dim InsertedRows As System.Data.DataSet

            Dim RowsAffected As Integer

            Try
                InsertedRows = updatedDataSet.GetChanges(System.Data.DataRowState.New)
                RowsAffected = Me.ItinDSCmd.Update(InsertedRows)
                updatedDataSet = InsertedRows
                Return RowsAffected

            Catch eUpdateException As System.Exception
                Throw eUpdateException
            End Try

        End Function

        Private Function ItinDSCmdFillDataSet(ByVal dataSet As System.Data.DataSet, ByVal Parameter1 As Integer) As Integer
            Dim RowsAffected As Integer

            Try
                'Load the dataset from the command
                Me.ItinDSCmd.SelectCommand.Parameters("Parameter1").Value = Parameter1
                RowsAffected = Me.ItinDSCmd.FillDataSet(dataSet)
            Catch eFillException As System.Exception
                Throw eFillException
            End Try

            Return RowsAffected

        End Function

        Public Function FillItinDataSet(ByVal dataSet As System.Data.DataSet, ByVal Parameter1 As Integer) As System.Data.DataSet
            'Open connections for database adapters

            Try
                Me.ItinCon.Open()

                'Fill DataSet with data from all adapters

                Me.ItinDSCmdFillDataSet(dataSet, Parameter1)

                'Close connections for database adapters

            Catch eFillException As System.Exception
                Throw eFillException

            Finally
                Me.ItinCon.Close()
            End Try

            Return dataSet

        End Function


        Private Function ItinDetDSCmdFillDataSet(ByVal dataSet As System.Data.DataSet, ByVal Parameter1 As Integer, ByVal Parameter2 As Date) As Integer
            Dim RowsAffected As Integer

            'Create an error handling block in case filldataset throws an exception

            Try
                'Load the dataset from the command
                Me.ItinDetDSCmd.SelectCommand.Parameters("Parameter1").Value = Parameter1
                Me.ItinDetDSCmd.SelectCommand.Parameters("Parameter2").Value = Parameter2
                RowsAffected = Me.ItinDetDSCmd.FillDataSet(dataSet)
            Catch eFillException As System.Exception
                Throw eFillException
            End Try

            Return RowsAffected

        End Function

        Public Function FillItinDetDataSet(ByVal dataSet As System.Data.DataSet, ByVal Parameter1 As Integer, ByVal Parameter2 As Date) As System.Data.DataSet
            'Open connections for database adapters

            Me.ItinDetCon.Open()

            'Fill DataSet with data from all adapters

            Me.ItinDetDSCmdFillDataSet(dataSet, Parameter1, Parameter2)

            'Close connections for database adapters

            Me.ItinDetCon.Close()

            Return dataSet

        End Function

        Public Sub New()
            MyBase.New()

            'This call is required by the Component Designer.
            InitializeComponent()

        End Sub

        'NOTE: The following procedure is required by the Component Designer
        'It can be modified using the Component Designer.  
        'Do not modify it using the code editor.
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container
            Me.ItinDSCmd = New System.Data.ADO.ADODataSetCommand
            Me.ItinCon = New System.Data.ADO.ADOConnection
            Me.ItinDetDSCmd = New System.Data.ADO.ADODataSetCommand
            Me.ItinDetCon = New System.Data.ADO.ADOConnection

            Dim a__1(11) As System.Data.ADO.ADOParameter
            a__1(0) = New System.Data.ADO.ADOParameter("ItineraryID", System.Data.ADO.ADODBType.Integer, 4, System.Data.ParameterDirection.Input, False, 10, 0, "ItineraryID", System.Data.DataRowVersion.Current, Nothing)
            a__1(1) = New System.Data.ADO.ADOParameter("MemberID", System.Data.ADO.ADODBType.Integer, 4, System.Data.ParameterDirection.Input, False, 10, 0, "MemberID", System.Data.DataRowVersion.Current, Nothing)
            a__1(2) = New System.Data.ADO.ADOParameter("StartDate", System.Data.ADO.ADODBType.DBTimeStamp, 16, System.Data.ParameterDirection.Input, False, 23, 3, "StartDate", System.Data.DataRowVersion.Current, Nothing)
            a__1(3) = New System.Data.ADO.ADOParameter("EndDate", System.Data.ADO.ADODBType.DBTimeStamp, 16, System.Data.ParameterDirection.Input, False, 23, 3, "EndDate", System.Data.DataRowVersion.Current, Nothing)
            a__1(4) = New System.Data.ADO.ADOParameter("Origin", System.Data.ADO.ADODBType.VarChar, 50, System.Data.ParameterDirection.Input, False, 255, 255, "Origin", System.Data.DataRowVersion.Current, Nothing)
            a__1(5) = New System.Data.ADO.ADOParameter("Destination", System.Data.ADO.ADODBType.VarChar, 50, System.Data.ParameterDirection.Input, False, 255, 255, "Destination", System.Data.DataRowVersion.Current, Nothing)
            a__1(6) = New System.Data.ADO.ADOParameter("NumberOfPeople", System.Data.ADO.ADODBType.Integer, 4, System.Data.ParameterDirection.Input, False, 10, 0, "NumberOfPeople", System.Data.DataRowVersion.Current, Nothing)
            a__1(7) = New System.Data.ADO.ADOParameter("Children", System.Data.ADO.ADODBType.Integer, 4, System.Data.ParameterDirection.Input, False, 10, 0, "Children", System.Data.DataRowVersion.Current, Nothing)
            a__1(8) = New System.Data.ADO.ADOParameter("TravelOccassion", System.Data.ADO.ADODBType.VarChar, 50, System.Data.ParameterDirection.Input, False, 255, 255, "TravelOccassion", System.Data.DataRowVersion.Current, Nothing)
            a__1(9) = New System.Data.ADO.ADOParameter("Key_ItineraryID", System.Data.ADO.ADODBType.Integer, 4, System.Data.ParameterDirection.Input, False, 10, 0, "ItineraryID", System.Data.DataRowVersion.Current, Nothing)
            a__1(10) = New System.Data.ADO.ADOParameter("Key2_ItineraryID", System.Data.ADO.ADODBType.Integer, 4, System.Data.ParameterDirection.Input, False, 10, 0, "ItineraryID", System.Data.DataRowVersion.Current, Nothing)
            ItinDSCmd.UpdateCommand = New System.Data.ADO.ADOCommand(ItinCon, "UPDATE Itinerary SET ItineraryID = ?,  MemberID = ?,  StartDate = ?,  EndDate = ?,  Origin = ?,  Destination = ?,  NumberOfPeople = ?,  Children = ?,  TravelOccassion = ? WHERE (ItineraryID = ?) ;SELECT ItineraryID,  MemberID,  StartDate,  EndDate,  Origin,  Destination,  NumberOfPeople,  Children,  TravelOccassion FROM Itinerary WHERE (ItineraryID = ?) ", System.Data.CommandType.Text, False, a__1, System.Data.UpdateRowSource.Both)
            '@design ItinDSCmd.SetLocation(New System.Drawing.Point(7, 7))

            Dim a__2(1) As System.Data.ADO.ADOParameter
            a__2(0) = New System.Data.ADO.ADOParameter("ItineraryID", System.Data.ADO.ADODBType.Integer, 4, System.Data.ParameterDirection.Input, False, 10, 0, "ItineraryID", System.Data.DataRowVersion.Current, Nothing)
            ItinDSCmd.DeleteCommand = New System.Data.ADO.ADOCommand(ItinCon, "DELETE FROM Itinerary WHERE (ItineraryID = ?) ", System.Data.CommandType.Text, False, a__2, System.Data.UpdateRowSource.Both)

            Dim a__3(9) As System.Data.ADO.ADOParameter
            a__3(0) = New System.Data.ADO.ADOParameter("MemberID", System.Data.ADO.ADODBType.Integer, 4, System.Data.ParameterDirection.Input, False, 10, 0, "MemberID", System.Data.DataRowVersion.Current, Nothing)
            a__3(1) = New System.Data.ADO.ADOParameter("StartDate", System.Data.ADO.ADODBType.DBTimeStamp, 16, System.Data.ParameterDirection.Input, False, 23, 3, "StartDate", System.Data.DataRowVersion.Current, Nothing)
            a__3(2) = New System.Data.ADO.ADOParameter("EndDate", System.Data.ADO.ADODBType.DBTimeStamp, 16, System.Data.ParameterDirection.Input, False, 23, 3, "EndDate", System.Data.DataRowVersion.Current, Nothing)
            a__3(3) = New System.Data.ADO.ADOParameter("Origin", System.Data.ADO.ADODBType.VarChar, 50, System.Data.ParameterDirection.Input, False, 255, 255, "Origin", System.Data.DataRowVersion.Current, Nothing)
            a__3(4) = New System.Data.ADO.ADOParameter("Destination", System.Data.ADO.ADODBType.VarChar, 50, System.Data.ParameterDirection.Input, False, 255, 255, "Destination", System.Data.DataRowVersion.Current, Nothing)
            a__3(5) = New System.Data.ADO.ADOParameter("NumberOfPeople", System.Data.ADO.ADODBType.Integer, 4, System.Data.ParameterDirection.Input, False, 10, 0, "NumberOfPeople", System.Data.DataRowVersion.Current, Nothing)
            a__3(6) = New System.Data.ADO.ADOParameter("Children", System.Data.ADO.ADODBType.Integer, 4, System.Data.ParameterDirection.Input, False, 10, 0, "Children", System.Data.DataRowVersion.Current, Nothing)
            a__3(7) = New System.Data.ADO.ADOParameter("TravelOccassion", System.Data.ADO.ADODBType.VarChar, 50, System.Data.ParameterDirection.Input, False, 255, 255, "TravelOccassion", System.Data.DataRowVersion.Current, Nothing)
            a__3(8) = New System.Data.ADO.ADOParameter("RETURN_VALUE", System.Data.ADO.ADODBType.Integer, 4, System.Data.ParameterDirection.Output, False, 10, 0, "ItineraryID", System.Data.DataRowVersion.Current, Nothing)

            ItinDSCmd.InsertCommand = New System.Data.ADO.ADOCommand(ItinCon, "INSERT INTO Itinerary(MemberID,  StartDate,  EndDate,  Origin,  Destination,  NumberOfPeople,  Children,  TravelOccassion ) VALUES(?,  ?,  ?,  ?,  ?,  ?,  ?,  ? ) ;SELECT ? = (@@IDENTITY) ", System.Data.CommandType.Text, False, a__3, System.Data.UpdateRowSource.Both)

            Dim a__4(1) As System.Data.ADO.ADOParameter
            a__4(0) = New System.Data.ADO.ADOParameter("Parameter1", System.Data.ADO.ADODBType.Integer, 4, System.Data.ParameterDirection.Input, False, 10, 0, "", System.Data.DataRowVersion.Current, Nothing)
            ItinDSCmd.SelectCommand = New System.Data.ADO.ADOCommand(ItinCon, "SELECT ItineraryID,  MemberID,  StartDate,  EndDate,  Origin,  Destination,  NumberOfPeople,  Children,  TravelOccassion FROM Itinerary WHERE (ItineraryID = ?) ", System.Data.CommandType.Text, False, a__4, System.Data.UpdateRowSource.Both)

            Dim a__5(9) As System.Data.Internal.DataColumnMapping
            a__5(0) = New System.Data.Internal.DataColumnMapping("ItineraryID", "ItineraryID")
            a__5(1) = New System.Data.Internal.DataColumnMapping("MemberID", "MemberID")
            a__5(2) = New System.Data.Internal.DataColumnMapping("StartDate", "StartDate")
            a__5(3) = New System.Data.Internal.DataColumnMapping("EndDate", "EndDate")
            a__5(4) = New System.Data.Internal.DataColumnMapping("Origin", "Origin")
            a__5(5) = New System.Data.Internal.DataColumnMapping("Destination", "Destination")
            a__5(6) = New System.Data.Internal.DataColumnMapping("NumberOfPeople", "NumberOfPeople")
            a__5(7) = New System.Data.Internal.DataColumnMapping("Children", "Children")
            a__5(8) = New System.Data.Internal.DataColumnMapping("TravelOccassion", "TravelOccassion")

            Dim a__6(1) As System.Data.Internal.DataTableMapping
            a__6(0) = New System.Data.Internal.DataTableMapping("Table", "Itinerary", a__5)
            ItinDSCmd.TableMappings.All = a__6


            Me.ItinDetDSCmd = New System.Data.ADO.ADODataSetCommand
            Me.ItinDetCon = New System.Data.ADO.ADOConnection
            Dim b__4(2) As System.Data.ADO.ADOParameter
            b__4(0) = New System.Data.ADO.ADOParameter("Parameter1", System.Data.ADO.ADODBType.Integer, 4, System.Data.ParameterDirection.Input, False, 10, 0, "", System.Data.DataRowVersion.Current, Nothing)
            b__4(1) = New System.Data.ADO.ADOParameter("Parameter2", System.Data.ADO.ADODBType.DBDate, 10, System.Data.ParameterDirection.Input, False, 10, 0, "", System.Data.DataRowVersion.Current, Nothing)
            ItinDetDSCmd.SelectCommand = New System.Data.ADO.ADOCommand(ItinDetCon, "itinerarydetail_loadexistingday", System.Data.CommandType.StoredProcedure, False, b__4, System.Data.UpdateRowSource.Both)
            Dim b__5(3) As System.Data.Internal.DataColumnMapping
            b__5(0) = New System.Data.Internal.DataColumnMapping("ItineraryDetailID", "ItineraryDetailID")
            b__5(1) = New System.Data.Internal.DataColumnMapping("Time", "Time")
            b__5(2) = New System.Data.Internal.DataColumnMapping("Detail", "Detail")
            Dim b__6(1) As System.Data.Internal.DataTableMapping
            b__6(0) = New System.Data.Internal.DataTableMapping("Table", "ItineraryDet", b__5)
            ItinDetDSCmd.TableMappings.All = b__6



            '@design Me.SetGenerateDataSet(False)
            '@design Me.SetGenerateCode(True)

            '@design ItinCon.SetLocation(New System.Drawing.Point(166, 7))
            ItinCon.ConnectionString = "Provider=SQLOLEDB.1;Persist Security Info=False;User ID=sa;Initial Catalog=Profile;Data Source=(local);Use Procedure for Prepare=1;Auto Translate=True;Packet Size=4096;Workstation ID=ENWEIX-RI1;Use Encryption for Data=False;Tag with column collation when possible=False"
            ItinDetCon.ConnectionString = "Provider=SQLOLEDB.1;Persist Security Info=False;User ID=sa;Initial Catalog=Profile;Data Source=(local);Use Procedure for Prepare=1;Auto Translate=True;Packet Size=4096;Workstation ID=ENWEIX-RI1;Use Encryption for Data=False;Tag with column collation when possible=False"
        End Sub

    End Class

End Namespace
