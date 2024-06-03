Option Strict Off
Imports System
Imports System.Collections
Imports System.Core
Imports System.ComponentModel
Imports System.Configuration
Imports System.Data
Imports System.Web.Services
Imports System.Diagnostics

Namespace VistaSiteMgr

    Public Class ItineraryDetail
        Inherits System.ComponentModel.Component

        'Required by the Component Designer
        Private components As Container
        'Required by the Component Designer
        Private ItinDetailCon As System.Data.ADO.ADOConnection
        Private ItinDetailDSCmd As System.Data.ADO.ADODataSetCommand

        Public Sub New()
            MyBase.New()

            'This call is required by the Component Designer.
            InitializeComponent()

            ' TODO: Add any initialization after the InitComponent call

        End Sub

        'NOTE: The following procedure is required by the Component Designer
        'It can be modified using the Component Designer.  
        'Do not modify it using the code editor.
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container
            Me.ItinDetailDSCmd = New System.Data.ADO.ADODataSetCommand
            Me.ItinDetailCon = New System.Data.ADO.ADOConnection

            Dim a__1(14) As System.Data.ADO.ADOParameter
            a__1(0) = New System.Data.ADO.ADOParameter("ItineraryID", System.Data.ADO.ADODBType.Integer, 4, System.Data.ParameterDirection.Input, False, 0, 0, "ItineraryID", System.Data.DataRowVersion.Current, Nothing)
            a__1(1) = New System.Data.ADO.ADOParameter("ConfirmationNumber", System.Data.ADO.ADODBType.VarChar, 50, System.Data.ParameterDirection.Input, False, 0, 0, "ConfirmationNumber", System.Data.DataRowVersion.Current, Nothing)
            a__1(2) = New System.Data.ADO.ADOParameter("Quantity", System.Data.ADO.ADODBType.Integer, 4, System.Data.ParameterDirection.Input, False, 0, 0, "Quantity", System.Data.DataRowVersion.Current, Nothing)
            a__1(3) = New System.Data.ADO.ADOParameter("PricePerItem", System.Data.ADO.ADODBType.Currency, 8, System.Data.ParameterDirection.Input, False, 0, 0, "PricePerItem", System.Data.DataRowVersion.Current, Nothing)
            a__1(4) = New System.Data.ADO.ADOParameter("StartDate", System.Data.ADO.ADODBType.DBTimeStamp, 16, System.Data.ParameterDirection.Input, False, 0, 0, "StartDate", System.Data.DataRowVersion.Current, Nothing)
            a__1(5) = New System.Data.ADO.ADOParameter("EndDate", System.Data.ADO.ADODBType.DBTimeStamp, 16, System.Data.ParameterDirection.Input, False, 0, 0, "EndDate", System.Data.DataRowVersion.Current, Nothing)
            a__1(6) = New System.Data.ADO.ADOParameter("EstimatedCost", System.Data.ADO.ADODBType.Double, 8, System.Data.ParameterDirection.Input, False, 0, 0, "EstimatedCost", System.Data.DataRowVersion.Current, Nothing)
            a__1(7) = New System.Data.ADO.ADOParameter("Detail", System.Data.ADO.ADODBType.VarChar, 1000, System.Data.ParameterDirection.Input, False, 0, 0, "Detail", System.Data.DataRowVersion.Current, Nothing)
            a__1(8) = New System.Data.ADO.ADOParameter("ProviderType", System.Data.ADO.ADODBType.VarChar, 50, System.Data.ParameterDirection.Input, False, 0, 0, "ProviderType", System.Data.DataRowVersion.Current, Nothing)
            a__1(9) = New System.Data.ADO.ADOParameter("ProviderID", System.Data.ADO.ADODBType.Integer, 4, System.Data.ParameterDirection.Input, False, 0, 0, "ProviderID", System.Data.DataRowVersion.Current, Nothing)
            a__1(10) = New System.Data.ADO.ADOParameter("Vendor", System.Data.ADO.ADODBType.VarChar, 50, System.Data.ParameterDirection.Input, False, 0, 0, "Vendor", System.Data.DataRowVersion.Current, Nothing)
            a__1(11) = New System.Data.ADO.ADOParameter("ItemID", System.Data.ADO.ADODBType.Integer, 4, System.Data.ParameterDirection.Input, False, 0, 0, "ItemID", System.Data.DataRowVersion.Current, Nothing)
            a__1(12) = New System.Data.ADO.ADOParameter("Status", System.Data.ADO.ADODBType.VarChar, 10, System.Data.ParameterDirection.Input, False, 0, 0, "Status", System.Data.DataRowVersion.Current, Nothing)
            a__1(13) = New System.Data.ADO.ADOParameter("ItineraryDetailID_Original", System.Data.ADO.ADODBType.Integer, 4, System.Data.ParameterDirection.Input, False, 0, 0, "ItineraryDetailID", System.Data.DataRowVersion.Original, Nothing)
            
            ItinDetailDSCmd.UpdateCommand = New System.Data.ADO.ADOCommand(ItinDetailCon, "UPDATE ""ItineraryDetail"" SET ""ItineraryID"" = ? , ""ConfirmationNumber"" = ? , ""Quantity"" = ? , ""PricePerItem"" = ? , ""StartDate"" = ? , ""EndDate"" = ? , ""EstimatedCost"" = ? , ""Detail"" = ? , ""ProviderType"" = ? , ""ProviderID"" = ? , ""Vendor"" = ? , ""ItemID"" = ? , ""Status"" = ? WHERE ( ""ItineraryDetailID"" = ? )", System.Data.CommandType.Text, False, a__1, System.Data.UpdateRowSource.Both)
            '@design ItinDetailDSCmd.SetLocation(New System.Drawing.Point(7, 7))

            Dim a__2(1) As System.Data.ADO.ADOParameter
            a__2(0) = New System.Data.ADO.ADOParameter("ItineraryDetailID", System.Data.ADO.ADODBType.Integer, 4, System.Data.ParameterDirection.Input, False, 10, 0, "ItineraryDetailID", System.Data.DataRowVersion.Current, Nothing)
            ItinDetailDSCmd.DeleteCommand = New System.Data.ADO.ADOCommand(ItinDetailCon, "DELETE FROM ItineraryDetail WHERE (ItineraryDetailID = ?) ", System.Data.CommandType.Text, False, a__2, System.Data.UpdateRowSource.Both)

            Dim a__3(14) As System.Data.ADO.ADOParameter
            a__3(0) = New System.Data.ADO.ADOParameter("ItineraryID", System.Data.ADO.ADODBType.Integer, 4, System.Data.ParameterDirection.Input, False, 10, 0, "ItineraryID", System.Data.DataRowVersion.Current, Nothing)
            a__3(1) = New System.Data.ADO.ADOParameter("ConfirmationNumber", System.Data.ADO.ADODBType.VarChar, 50, System.Data.ParameterDirection.Input, False, 255, 255, "ConfirmationNumber", System.Data.DataRowVersion.Current, Nothing)
            a__3(2) = New System.Data.ADO.ADOParameter("Quantity", System.Data.ADO.ADODBType.Integer, 4, System.Data.ParameterDirection.Input, False, 10, 0, "Quantity", System.Data.DataRowVersion.Current, Nothing)
            a__3(3) = New System.Data.ADO.ADOParameter("PricePerItem", System.Data.ADO.ADODBType.Currency, 8, System.Data.ParameterDirection.Input, False, 19, 4, "PricePerItem", System.Data.DataRowVersion.Current, Nothing)
            a__3(4) = New System.Data.ADO.ADOParameter("StartDate", System.Data.ADO.ADODBType.DBTimeStamp, 16, System.Data.ParameterDirection.Input, False, 23, 3, "StartDate", System.Data.DataRowVersion.Current, Nothing)
            a__3(5) = New System.Data.ADO.ADOParameter("EndDate", System.Data.ADO.ADODBType.DBTimeStamp, 16, System.Data.ParameterDirection.Input, False, 23, 3, "EndDate", System.Data.DataRowVersion.Current, Nothing)
            a__3(6) = New System.Data.ADO.ADOParameter("EstimatedCost", System.Data.ADO.ADODBType.Double, 8, System.Data.ParameterDirection.Input, False, 15, 255, "EstimatedCost", System.Data.DataRowVersion.Current, Nothing)
            a__3(7) = New System.Data.ADO.ADOParameter("Detail", System.Data.ADO.ADODBType.VarChar, 1000, System.Data.ParameterDirection.Input, False, 255, 255, "Detail", System.Data.DataRowVersion.Current, Nothing)
            a__3(8) = New System.Data.ADO.ADOParameter("ProviderType", System.Data.ADO.ADODBType.VarChar, 50, System.Data.ParameterDirection.Input, False, 255, 255, "ProviderType", System.Data.DataRowVersion.Current, Nothing)
            a__3(9) = New System.Data.ADO.ADOParameter("ProviderID", System.Data.ADO.ADODBType.Integer, 4, System.Data.ParameterDirection.Input, False, 10, 0, "ProviderID", System.Data.DataRowVersion.Current, Nothing)
            a__3(10) = New System.Data.ADO.ADOParameter("Vendor", System.Data.ADO.ADODBType.VarChar, 50, System.Data.ParameterDirection.Input, False, 255, 255, "Vendor", System.Data.DataRowVersion.Current, Nothing)
            a__3(11) = New System.Data.ADO.ADOParameter("ItemID", System.Data.ADO.ADODBType.Integer, 4, System.Data.ParameterDirection.Input, False, 10, 0, "ItemID", System.Data.DataRowVersion.Current, Nothing)
            a__3(12) = New System.Data.ADO.ADOParameter("Status", System.Data.ADO.ADODBType.VarChar, 10, System.Data.ParameterDirection.Input, False, 255, 255, "Status", System.Data.DataRowVersion.Current, Nothing)
            a__3(13) = New System.Data.ADO.ADOParameter("RETURN_VALUE", System.Data.ADO.ADODBType.Integer, 4, System.Data.ParameterDirection.Output, False, 10, 0, "ItineraryDetailID", System.Data.DataRowVersion.Current, Nothing)
            ItinDetailDSCmd.InsertCommand = New System.Data.ADO.ADOCommand(ItinDetailCon, "INSERT INTO ItineraryDetail( ItineraryID,  ConfirmationNumber,  Quantity,  PricePerItem,  StartDate,  EndDate,  EstimatedCost,  Detail,  ProviderType,  ProviderID,  Vendor,  ItemID,  Status ) VALUES( ?,  ?,  ?,  ?,  ?,  ?,  ?,  ?,  ?,  ?,  ?,  ?,  ? ) ;SELECT ? = (@@IDENTITY) ", System.Data.CommandType.Text, False, a__3, System.Data.UpdateRowSource.Both)
            
            Dim a__4(1) As System.Data.ADO.ADOParameter
            a__4(0) = New System.Data.ADO.ADOParameter("Parameter1", System.Data.ADO.ADODBType.Integer, 4, System.Data.ParameterDirection.Input, False, 10, 0, "", System.Data.DataRowVersion.Current, Nothing)
            ItinDetailDSCmd.SelectCommand = New System.Data.ADO.ADOCommand(ItinDetailCon, "SELECT ItineraryDetailID,  ItineraryID,  ConfirmationNumber,  Quantity,  PricePerItem,  StartDate,  EndDate,  EstimatedCost,  Detail,  ProviderType,  ProviderID,  Vendor,  ItemID,  Status FROM ItineraryDetail WHERE (ItineraryDetailID = ?) ", System.Data.CommandType.Text, False, a__4, System.Data.UpdateRowSource.Both)

            Dim a__5(14) As System.Data.Internal.DataColumnMapping
            a__5(0) = New System.Data.Internal.DataColumnMapping("ItineraryDetailID", "ItineraryDetailID")
            a__5(1) = New System.Data.Internal.DataColumnMapping("ItineraryID", "ItineraryID")
            a__5(2) = New System.Data.Internal.DataColumnMapping("ConfirmationNumber", "ConfirmationNumber")
            a__5(3) = New System.Data.Internal.DataColumnMapping("Quantity", "Quantity")
            a__5(4) = New System.Data.Internal.DataColumnMapping("PricePerItem", "PricePerItem")
            a__5(5) = New System.Data.Internal.DataColumnMapping("StartDate", "StartDate")
            a__5(6) = New System.Data.Internal.DataColumnMapping("EndDate", "EndDate")
            a__5(7) = New System.Data.Internal.DataColumnMapping("EstimatedCost", "EstimatedCost")
            a__5(8) = New System.Data.Internal.DataColumnMapping("Detail", "Detail")
            a__5(9) = New System.Data.Internal.DataColumnMapping("ProviderType", "ProviderType")
            a__5(10) = New System.Data.Internal.DataColumnMapping("ProviderID", "ProviderID")
            a__5(11) = New System.Data.Internal.DataColumnMapping("Vendor", "Vendor")
            a__5(12) = New System.Data.Internal.DataColumnMapping("ItemID", "ItemID")
            a__5(13) = New System.Data.Internal.DataColumnMapping("Status", "Status")
            Dim a__6(1) As System.Data.Internal.DataTableMapping
            a__6(0) = New System.Data.Internal.DataTableMapping("Table", "ItineraryDetail", a__5)
            ItinDetailDSCmd.TableMappings.All = a__6

            '@design ItinDetailCon.SetLocation(New System.Drawing.Point(166, 7))
            ItinDetailCon.ConnectionString = "Provider=SQLOLEDB.1;Persist Security Info=False;User ID=sa;Initial Catalog=Profile;Data Source=(local);Use Procedure for Prepare=1;Auto Translate=True;Packet Size=4096;Workstation ID=ENWEIX-RI1;Use Encryption for Data=False;Tag with column collation when possible=False"

            '@design Me.SetGenerateDataSet(False)
            '@design Me.SetGenerateCode(True)
        End Sub

        Public Function UpdateItinDetailDataSource(ByVal updatedDataSet As System.Data.DataSet) As System.Data.DataSet
            'Update DataSet with data from all adapters

            Me.ItinDetailDSCmdUpdateDataSource(updatedDataSet)

            Return updatedDataSet

        End Function
        Public Function UpdateItinDetailDataSourceUpdate(ByVal updatedDataSet As System.Data.DataSet) As System.Data.DataSet
            'Update DataSet with data from all adapters

            Me.ItinDetailDSCmdUpdateDataSourceUpdate(updatedDataSet)

            Return updatedDataSet

        End Function

        Private Function ItinDetailDSCmdUpdateDataSource(ByVal updatedDataSet As System.Data.DataSet) As Integer
            Dim DeletedRows As System.Data.DataSet

            Dim UpdatedRows As System.Data.DataSet

            Dim InsertedRows As System.Data.DataSet

            Dim RowsAffected As Integer

            Try
                InsertedRows = updatedDataSet.GetChanges(System.Data.DataRowState.New)
                RowsAffected = Me.ItinDetailDSCmd.Update(InsertedRows)
                Return RowsAffected
            Catch eUpdateException As System.Exception
                Throw eUpdateException
            End Try

        End Function
        Private Function ItinDetailDSCmdUpdateDataSourceUpdate(ByVal updatedDataSet As System.Data.DataSet) As Integer
            Dim DeletedRows As System.Data.DataSet

            Dim UpdatedRows As System.Data.DataSet

            Dim InsertedRows As System.Data.DataSet

            Dim RowsAffected As Integer

            Try
                UpdatedRows = updatedDataSet.GetChanges(System.Data.DataRowState.Modified)
                RowsAffected = Me.ItinDetailDSCmd.Update(UpdatedRows)
                Return RowsAffected
            Catch eUpdateException As System.Exception
                Throw eUpdateException
            End Try

        End Function
        Private Function ItinDetailDSCmdFillDataSet(ByVal dataSet As System.Data.DataSet, ByVal Parameter1 As Integer) As Integer
            Dim RowsAffected As Integer

            'Create an error handling block in case filldataset throws an exception

            Try
                'Load the dataset from the command
                Me.ItinDetailDSCmd.SelectCommand.Parameters("Parameter1").Value = Parameter1
                RowsAffected = Me.ItinDetailDSCmd.FillDataSet(dataSet)
            Catch eFillException As System.Exception
                Throw eFillException
            End Try

            Return RowsAffected

        End Function

        Public Function FillItinDetailDataSet(ByVal dataSet As System.Data.DataSet, ByVal Parameter1 As Integer) As System.Data.DataSet
            'Open connections for database adapters

            Me.ItinDetailCon.Open()

            'Fill DataSet with data from all adapters

            Me.ItinDetailDSCmdFillDataSet(dataSet, Parameter1)

            'Close connections for database adapters

            Me.ItinDetailCon.Close()

            Return dataSet

        End Function

        Public Function Load(ByVal ItineraryDetailID As Long) As DataSet
            Dim sSQL As String
            Dim dsLoad As DataSet
            Dim adodscmd As ADO.ADODataSetCommand
            Dim adoconn As ADO.ADOConnection
            dsLoad = New DataSet
            adodscmd = New ADO.ADODataSetCommand
            adoconn = New ADO.ADOConnection
            
            sSQL = "SELECT ItineraryDetailID, ItineraryID, ConfirmationNumber, Quantity, PricePerItem, StartDate, EndDate,"
            sSQL = sSQL & " EstimatedCost, Detail, ProviderType, ProviderID, Vendor, ItemID, Status FROM ItineraryDetail WHERE ItineraryDetailID = "
            sSQL = sSQL & ItineraryDetailID

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
            adodscmd.FillDataSet(dsLoad)

            'Return the data
            Load = dsLoad
        End Function

        Public Function Save(ByVal dsDetail As DataSet) As DataSet
            
            Save = UpdateItinDetailDataSource(dsDetail)
                
        End Function

        Public Function SaveUpdate(ByVal dsDetail As DataSet) As DataSet
            
            SaveUpdate = UpdateItinDetailDataSourceUpdate(dsDetail)
                
        End Function

        Public Function RetrieveOptions(ByVal ItineraryID As Long, Optional ByVal ItineraryDetailID As Long = 0) As DataSet
            Dim oActivity As Activity
            Dim dsActivity As DataSet
            Dim sSQL As String
            Dim dsRetrieveOptions As DataSet
            Dim adodscmd As ADO.ADODataSetCommand
            Dim adoconn As ADO.ADOConnection
            dsRetrieveOptions = New DataSet
            adodscmd = New ADO.ADODataSetCommand
            adoconn = New ADO.ADOConnection
            
            sSQL = "SELECT ItineraryDetailID, ItineraryID, ConfirmationNumber, Quantity, PricePerItem, StartDate, EndDate,"
            sSQL = sSQL & " EstimatedCost, Detail, ProviderType, ProviderID, Vendor, ItemID, Status FROM ItineraryDetail WHERE ItineraryDetailID = "
            sSQL = sSQL & ItineraryDetailID

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

            adodscmd.FillDataSet(dsRetrieveOptions)

            'Get the data to be stuffed in the DataSet object
            Dim oItinerary As New VistaSiteMgr.Itinerary()
            Dim dsItin As New DataSet()
            Dim Region As String
            oItinerary.FillItinDataSet(dsItin, ItineraryID)

            Region = dsItin.Tables(0).Rows(0).Item("Destination")

            Dim sDinnerOpt As String
            'Initialize
            sDinnerOpt = "Dining"
            
            If dsRetrieveOptions.Tables(0).Rows.Count = 0 Then
                oActivity = New Activity
                dsActivity = oActivity.BrowseByLocation(CStr(dsItin.Tables(0).rows(0).Item("StartDate")), CStr(dsItin.Tables(0).Rows(0).Item("EndDate")), "", region, "", "", "", sDinnerOpt)
                Dim drRow As DataRow
                Dim iX As Long
                Dim iCOunter As Long

                If dsActivity.Tables.Count > 0 Then
                    For ix = 0 To dsActivity.Tables(0).Rows.Count - 1
                        If iCounter < 3 Then
                            If CBool(dsActivity.Tables(0).rows(iX).Item("DiningAvailable")) = True Then
                                drRow = dsRetrieveOptions.Tables(0).NewRow
                                drRow.Item("ItineraryID") = dsItin.tables(0).rows(0).item("ItineraryID")
                                drRow.Item("Quantity") = 1
                                drRow.Item("Detail") = dsActivity.Tables(0).Rows(iX).Item("Name") & " - " & dsActivity.Tables(0).Rows(iX).Item("LocalInfoDetails")
                                drRow.Item("PricePerItem") = dsActivity.Tables(0).Rows(iX).Item("Price")
                                drRow.Item("StartDate") = dsActivity.Tables(0).Rows(iX).Item("StartDate")
                                drRow.Item("EndDate") = dsActivity.Tables(0).Rows(iX).Item("EndDate")
                                drRow.Item("ItemID") = dsActivity.Tables(0).Rows(iX).Item("ActivityLocationID")
                                drRow.Item("Vendor") = dsActivity.Tables(0).Rows(iX).Item("LocationName")
                                drRow.Item("Status") = "NB"
                                dsRetrieveOptions.Tables(0).Rows.Add(drRow)
                                iCounter = iCOunter + 1
                            End If
                        End If
                    Next
                End If
            Else
                oActivity = New Activity
                dsActivity = New Dataset
                Dim drRow As DataRow
                Dim iX As Long
                Dim iCounter As Long
                Dim sStart As String
                Dim sEnd As String
                Dim lLocation As Long
                lLocation = CLng(dsRetrieveOptions.Tables(0).Rows(0).Item("ItemID"))
                sEnd = CStr(dsItin.Tables(0).rows(0).Item("EndDate"))
                sStart = CStr(dsItin.Tables(0).rows(0).Item("StartDate"))
                dsActivity = oActivity.BrowseByProximity(sStart, sEnd, lLocation, 50, sDinnerOpt)

                If dsActivity.Tables.Count > 0 Then
                    For ix = 0 To dsActivity.Tables(0).Rows.Count - 1
                        If iCounter < 3 Then
                            drRow = dsRetrieveOptions.Tables(0).NewRow
                            drRow.Item("ItineraryID") = dsItin.tables(0).rows(0).item("ItineraryID")
                            drRow.Item("Quantity") = 1
                            drRow.Item("Detail") = dsActivity.Tables(0).Rows(iX).Item("Name") & " - " & dsActivity.Tables(0).Rows(iX).Item("LocalInfoDetails")
                            drRow.Item("PricePerItem") = dsActivity.Tables(0).Rows(iX).Item("Price")
                            drRow.Item("StartDate") = dsActivity.Tables(0).Rows(iX).Item("StartDate")
                            drRow.Item("EndDate") = dsActivity.Tables(0).Rows(iX).Item("EndDate")
                            drRow.Item("ItemID") = dsActivity.Tables(0).Rows(iX).Item("ActivityLocationID")
                            drRow.Item("Vendor") = dsActivity.Tables(0).Rows(iX).Item("LocationName")
                            drRow.Item("Status") = "NB"
                            dsRetrieveOptions.Tables(0).Rows.Add(drRow)
                            iCounter = iCOunter + 1
                        End If
                    Next
                End If
            End If

            Dim iC As Long
            For iC = 0 To dsRetrieveOptions.tables(0).rows.count - 1
                If CStr(dsRetrieveOptions.Tables(0).Rows(iC).Item("Detail")) = "Dining Options..." Then
                    dsRetrieveOptions.Tables(0).Rows.Remove(iC)
                    Exit For
                End If
            Next
            debug.Write(dsRetrieveOptions.Xml)
            'Return the data
            RetrieveOptions = dsRetrieveOptions.GetChanges

        End Function
    End Class

End Namespace
