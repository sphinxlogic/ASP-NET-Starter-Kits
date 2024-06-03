Imports System
Imports System.Collections
Imports System.Core
Imports System.ComponentModel
Imports System.Configuration
Imports System.Web.Services
Imports System.Diagnostics
Imports System.Data

Namespace LodgingMgr

    Public Class LodgingReservation
        Inherits System.Web.Services.WebService

        'Required by the WebServices Designer
        Private components As System.ComponentModel.Container
                
        Private FacilityCon As System.Data.ADO.ADOConnection
        Private FacilityDSCmd As System.Data.ADO.ADODataSetCommand
        Private ReservationCon As System.Data.ADO.ADOConnection
        Private ReservationDSCmd As System.Data.ADO.ADODataSetCommand

 
        Public Function  <WebMethod()> Browse(ByVal City As String, ByVal State As String, ByVal RateLimit As Double, ByVal TravelDate As Date, ByVal Chain As String) As DataSet
            Dim DSet As New DataSet()
            
            Me.FacilityDSCmdFillDataSet(DSet, City, State, RateLimit, Chain)

            Return DSet

        End Function

        Public Function  <WebMethod()> Load(ByVal ConfirmationNumber As Long) As DataSet
            Dim DSet As New DataSet()

            Me.ReservationDSCmdFillDataSet(DSet, ConfirmationNumber)
            Return DSet

        End Function

        Public Function  <WebMethod()> Create() As DataSet
            Dim DSet As New DataSet()

            Me.ReservationDSCmdFillDataSet(DSet, 0)
            Return DSet

        End Function

        Public Function  <WebMethod()> Save(ByVal ReservationInfo As DataSet) As Long
            Dim DSet As New DataSet()
                      

            If (ReservationInfo.Tables(0).Rows(0).Item(0)) > 0 Then
                'We have a ReservationID, so update
                DSet = Me.UpdateReservationDataSource(ReservationInfo)
                Return (System.Convert.ToInt16(DSet.Tables(0).Rows(0).Item(0)))
            Else
                'this is a new reservation, so insert the new item
                DSet = Me.InsertReservationDataSource(ReservationInfo)
                Return CLng(ReservationDSCmd.InsertCommand.Parameters(13).Value)
            End If

            'Return System.Convert.ToInt32(ReservationDSCmd.InsertCommand.Parameters("Key_ReservationID").Value)
            

        End Function


        Public Sub New()
            MyBase.New()

            'CODEGEN: This procedure is required by the WebServices Designer
            'Do not modify it using the code editor.
            InitializeComponent()

            'Add your own initialization code after the InitializeComponent call
        End Sub

        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container
            Me.ReservationCon = New System.Data.ADO.ADOConnection
            Me.ReservationDSCmd = New System.Data.ADO.ADODataSetCommand
            Me.FacilityCon = New System.Data.ADO.ADOConnection
            Me.FacilityDSCmd = New System.Data.ADO.ADODataSetCommand

            '@design ReservationCon.SetLocation(New System.Drawing.Point(236, 7))
            ReservationCon.ConnectionString = "Provider=SQLOLEDB.1;Persist Security Info=False;User ID=sa;Initial Catalog=LodgingMgr;Data Source=(local);Use Procedure for Prepare=1;Auto Translate=True;Packet Size=4096;Workstation ID=ENWEIX-RI1;Use Encryption for Data=False;Tag with column collation when possible=False"

            Dim a__1(15) As System.Data.ADO.ADOParameter
            a__1(0) = New System.Data.ADO.ADOParameter("FacilityID", System.Data.ADO.ADODBType.Integer, 4, System.Data.ParameterDirection.Input, False, 10, 0, "FacilityID", System.Data.DataRowVersion.Current, Nothing)
            a__1(1) = New System.Data.ADO.ADOParameter("ArrivalDate", System.Data.ADO.ADODBType.DBTimeStamp, 16, System.Data.ParameterDirection.Input, False, 23, 3, "ArrivalDate", System.Data.DataRowVersion.Current, Nothing)
            a__1(2) = New System.Data.ADO.ADOParameter("Nights", System.Data.ADO.ADODBType.Integer, 4, System.Data.ParameterDirection.Input, False, 10, 0, "Nights", System.Data.DataRowVersion.Current, Nothing)
            a__1(3) = New System.Data.ADO.ADOParameter("BillingAddress", System.Data.ADO.ADODBType.VarChar, 200, System.Data.ParameterDirection.Input, False, 255, 255, "BillingAddress", System.Data.DataRowVersion.Current, Nothing)
            a__1(4) = New System.Data.ADO.ADOParameter("BillingContact", System.Data.ADO.ADODBType.VarChar, 50, System.Data.ParameterDirection.Input, False, 255, 255, "BillingContact", System.Data.DataRowVersion.Current, Nothing)
            a__1(5) = New System.Data.ADO.ADOParameter("BillingCity", System.Data.ADO.ADODBType.VarChar, 60, System.Data.ParameterDirection.Input, False, 255, 255, "BillingCity", System.Data.DataRowVersion.Current, Nothing)
            a__1(6) = New System.Data.ADO.ADOParameter("BillingState", System.Data.ADO.ADODBType.VarChar, 50, System.Data.ParameterDirection.Input, False, 255, 255, "BillingState", System.Data.DataRowVersion.Current, Nothing)
            a__1(7) = New System.Data.ADO.ADOParameter("BillingPostalCode", System.Data.ADO.ADODBType.VarChar, 10, System.Data.ParameterDirection.Input, False, 255, 255, "BillingPostalCode", System.Data.DataRowVersion.Current, Nothing)
            a__1(8) = New System.Data.ADO.ADOParameter("Smoking", System.Data.ADO.ADODBType.VarChar, 10, System.Data.ParameterDirection.Input, False, 255, 255, "Smoking", System.Data.DataRowVersion.Current, Nothing)
            a__1(9) = New System.Data.ADO.ADOParameter("BedType", System.Data.ADO.ADODBType.VarChar, 10, System.Data.ParameterDirection.Input, False, 255, 255, "BedType", System.Data.DataRowVersion.Current, Nothing)
            a__1(10) = New System.Data.ADO.ADOParameter("CardType", System.Data.ADO.ADODBType.VarChar, 50, System.Data.ParameterDirection.Input, False, 255, 255, "CardType", System.Data.DataRowVersion.Current, Nothing)
            a__1(11) = New System.Data.ADO.ADOParameter("CardNumber", System.Data.ADO.ADODBType.VarChar, 30, System.Data.ParameterDirection.Input, False, 255, 255, "CardNumber", System.Data.DataRowVersion.Current, Nothing)
            a__1(12) = New System.Data.ADO.ADOParameter("ExpirationDate", System.Data.ADO.ADODBType.DBTimeStamp, 16, System.Data.ParameterDirection.Input, False, 23, 3, "ExpirationDate", System.Data.DataRowVersion.Current, Nothing)
            a__1(13) = New System.Data.ADO.ADOParameter("Key_ReservationID", System.Data.ADO.ADODBType.Integer, 4, System.Data.ParameterDirection.Input, False, 10, 0, "ReservationID", System.Data.DataRowVersion.Current, Nothing)
            a__1(14) = New System.Data.ADO.ADOParameter("Key2_ReservationID", System.Data.ADO.ADODBType.Integer, 4, System.Data.ParameterDirection.Input, False, 10, 0, "ReservationID", System.Data.DataRowVersion.Current, Nothing)
            ReservationDSCmd.UpdateCommand = New System.Data.ADO.ADOCommand(ReservationCon, "UPDATE Reservation SET FacilityID = ?,  ArrivalDate = ?,  Nights = ?,  BillingAddress = ?,  BillingContact = ?,  BillingCity = ?,  BillingState = ?,  BillingPostalCode = ?,  Smoking = ?,  BedType = ?,  CardType = ?,  CardNumber = ?,  ExpirationDate = ? WHERE (ReservationID = ?) ;SELECT ReservationID,  FacilityID,  ArrivalDate,  Nights,  BillingAddress,  BillingContact,  BillingCity,  BillingState,  BillingPostalCode,  Smoking,  BedType,  CardType,  CardNumber,  ExpirationDate FROM Reservation WHERE (ReservationID = ?) ", System.Data.CommandType.Text, False, a__1, System.Data.UpdateRowSource.Both)
            '@design ReservationDSCmd.SetLocation(New System.Drawing.Point(7, 7))
            Dim a__2(1) As System.Data.ADO.ADOParameter
            a__2(0) = New System.Data.ADO.ADOParameter("ReservationID", System.Data.ADO.ADODBType.Integer, 4, System.Data.ParameterDirection.Input, False, 10, 0, "ReservationID", System.Data.DataRowVersion.Current, Nothing)
            ReservationDSCmd.DeleteCommand = New System.Data.ADO.ADOCommand(ReservationCon, "DELETE FROM Reservation WHERE (ReservationID = ?) ", System.Data.CommandType.Text, False, a__2, System.Data.UpdateRowSource.Both)
            Dim a__3(14) As System.Data.ADO.ADOParameter
            a__3(0) = New System.Data.ADO.ADOParameter("FacilityID", System.Data.ADO.ADODBType.Integer, 4, System.Data.ParameterDirection.Input, False, 10, 0, "FacilityID", System.Data.DataRowVersion.Current, Nothing)
            a__3(1) = New System.Data.ADO.ADOParameter("ArrivalDate", System.Data.ADO.ADODBType.DBTimeStamp, 16, System.Data.ParameterDirection.Input, False, 23, 3, "ArrivalDate", System.Data.DataRowVersion.Current, Nothing)
            a__3(2) = New System.Data.ADO.ADOParameter("Nights", System.Data.ADO.ADODBType.Integer, 4, System.Data.ParameterDirection.Input, False, 10, 0, "Nights", System.Data.DataRowVersion.Current, Nothing)
            a__3(3) = New System.Data.ADO.ADOParameter("BillingAddress", System.Data.ADO.ADODBType.VarChar, 200, System.Data.ParameterDirection.Input, False, 255, 255, "BillingAddress", System.Data.DataRowVersion.Current, Nothing)
            a__3(4) = New System.Data.ADO.ADOParameter("BillingContact", System.Data.ADO.ADODBType.VarChar, 50, System.Data.ParameterDirection.Input, False, 255, 255, "BillingContact", System.Data.DataRowVersion.Current, Nothing)
            a__3(5) = New System.Data.ADO.ADOParameter("BillingCity", System.Data.ADO.ADODBType.VarChar, 60, System.Data.ParameterDirection.Input, False, 255, 255, "BillingCity", System.Data.DataRowVersion.Current, Nothing)
            a__3(6) = New System.Data.ADO.ADOParameter("BillingState", System.Data.ADO.ADODBType.VarChar, 50, System.Data.ParameterDirection.Input, False, 255, 255, "BillingState", System.Data.DataRowVersion.Current, Nothing)
            a__3(7) = New System.Data.ADO.ADOParameter("BillingPostalCode", System.Data.ADO.ADODBType.VarChar, 10, System.Data.ParameterDirection.Input, False, 255, 255, "BillingPostalCode", System.Data.DataRowVersion.Current, Nothing)
            a__3(8) = New System.Data.ADO.ADOParameter("Smoking", System.Data.ADO.ADODBType.VarChar, 10, System.Data.ParameterDirection.Input, False, 255, 255, "Smoking", System.Data.DataRowVersion.Current, Nothing)
            a__3(9) = New System.Data.ADO.ADOParameter("BedType", System.Data.ADO.ADODBType.VarChar, 10, System.Data.ParameterDirection.Input, False, 255, 255, "BedType", System.Data.DataRowVersion.Current, Nothing)
            a__3(10) = New System.Data.ADO.ADOParameter("CardType", System.Data.ADO.ADODBType.VarChar, 50, System.Data.ParameterDirection.Input, False, 255, 255, "CardType", System.Data.DataRowVersion.Current, Nothing)
            a__3(11) = New System.Data.ADO.ADOParameter("CardNumber", System.Data.ADO.ADODBType.VarChar, 30, System.Data.ParameterDirection.Input, False, 255, 255, "CardNumber", System.Data.DataRowVersion.Current, Nothing)
            a__3(12) = New System.Data.ADO.ADOParameter("ExpirationDate", System.Data.ADO.ADODBType.DBTimeStamp, 16, System.Data.ParameterDirection.Input, False, 23, 3, "ExpirationDate", System.Data.DataRowVersion.Current, Nothing)
            a__3(13) = New System.Data.ADO.ADOParameter("RETURN_VALUE", System.Data.ADO.ADODBType.Integer, 4, System.Data.ParameterDirection.Output, False, 10, 0, "ReservationID", System.Data.DataRowVersion.Current, Nothing)
            ReservationDSCmd.InsertCommand = New System.Data.ADO.ADOCommand(ReservationCon, "INSERT INTO Reservation( FacilityID,  ArrivalDate,  Nights,  BillingAddress,  BillingContact,  BillingCity,  BillingState,  BillingPostalCode,  Smoking,  BedType,  CardType,  CardNumber,  ExpirationDate ) VALUES( ?,  ?,  ?,  ?,  ?,  ?,  ?,  ?,  ?,  ?,  ?,  ?,  ? ) ;SELECT ? = (@@IDENTITY) ", System.Data.CommandType.Text, False, a__3, System.Data.UpdateRowSource.Both)
            Dim a__4(1) As System.Data.ADO.ADOParameter
            a__4(0) = New System.Data.ADO.ADOParameter("Parameter1", System.Data.ADO.ADODBType.Integer, 4, System.Data.ParameterDirection.Input, False, 10, 0, "", System.Data.DataRowVersion.Current, Nothing)
            ReservationDSCmd.SelectCommand = New System.Data.ADO.ADOCommand(ReservationCon, "SELECT ReservationID,  FacilityID,  ArrivalDate,  Nights,  BillingAddress,  BillingContact,  BillingCity,  BillingState,  BillingPostalCode,  Smoking,  BedType,  CardType,  CardNumber,  ExpirationDate FROM Reservation WHERE (ReservationID = ?) ", System.Data.CommandType.Text, False, a__4, System.Data.UpdateRowSource.Both)
            Dim a__5(14) As System.Data.Internal.DataColumnMapping
            a__5(0) = New System.Data.Internal.DataColumnMapping("ReservationID", "ReservationID")
            a__5(1) = New System.Data.Internal.DataColumnMapping("FacilityID", "FacilityID")
            a__5(2) = New System.Data.Internal.DataColumnMapping("ArrivalDate", "ArrivalDate")
            a__5(3) = New System.Data.Internal.DataColumnMapping("Nights", "Nights")
            a__5(4) = New System.Data.Internal.DataColumnMapping("BillingAddress", "BillingAddress")
            a__5(5) = New System.Data.Internal.DataColumnMapping("BillingContact", "BillingContact")
            a__5(6) = New System.Data.Internal.DataColumnMapping("BillingCity", "BillingCity")
            a__5(7) = New System.Data.Internal.DataColumnMapping("BillingState", "BillingState")
            a__5(8) = New System.Data.Internal.DataColumnMapping("BillingPostalCode", "BillingPostalCode")
            a__5(9) = New System.Data.Internal.DataColumnMapping("Smoking", "Smoking")
            a__5(10) = New System.Data.Internal.DataColumnMapping("BedType", "BedType")
            a__5(11) = New System.Data.Internal.DataColumnMapping("CardType", "CardType")
            a__5(12) = New System.Data.Internal.DataColumnMapping("CardNumber", "CardNumber")
            a__5(13) = New System.Data.Internal.DataColumnMapping("ExpirationDate", "ExpirationDate")
            Dim a__6(1) As System.Data.Internal.DataTableMapping
            a__6(0) = New System.Data.Internal.DataTableMapping("Table", "Reservation", a__5)
            ReservationDSCmd.TableMappings.All = a__6

            '@design Me.SetGenerateCode(True)
            '@design Me.SetGenerateDataSet(False)

            '@design FacilityCon.SetLocation(New System.Drawing.Point(142, 7))
            FacilityCon.ConnectionString = "Provider=SQLOLEDB.1;Persist Security Info=False;User ID=sa;Initial Catalog=LodgingMgr;Data Source=(local);Use Procedure for Prepare=1;Auto Translate=True;Packet Size=4096;Workstation ID=ENWEIX-RI1;Use Encryption for Data=False;Tag with column collation when possible=False"

            Dim a__7(12) As System.Data.ADO.ADOParameter
            a__7(0) = New System.Data.ADO.ADOParameter("Chain", System.Data.ADO.ADODBType.VarChar, 50, System.Data.ParameterDirection.Input, False, 255, 255, "Chain", System.Data.DataRowVersion.Current, Nothing)
            a__7(1) = New System.Data.ADO.ADOParameter("FacilityID", System.Data.ADO.ADODBType.Integer, 4, System.Data.ParameterDirection.Input, False, 10, 0, "FacilityID", System.Data.DataRowVersion.Current, Nothing)
            a__7(2) = New System.Data.ADO.ADOParameter("Address", System.Data.ADO.ADODBType.VarChar, 300, System.Data.ParameterDirection.Input, False, 255, 255, "Address", System.Data.DataRowVersion.Current, Nothing)
            a__7(3) = New System.Data.ADO.ADOParameter("PostalCode", System.Data.ADO.ADODBType.VarChar, 10, System.Data.ParameterDirection.Input, False, 255, 255, "PostalCode", System.Data.DataRowVersion.Current, Nothing)
            a__7(4) = New System.Data.ADO.ADOParameter("City", System.Data.ADO.ADODBType.VarChar, 50, System.Data.ParameterDirection.Input, False, 255, 255, "City", System.Data.DataRowVersion.Current, Nothing)
            a__7(5) = New System.Data.ADO.ADOParameter("State", System.Data.ADO.ADODBType.VarChar, 50, System.Data.ParameterDirection.Input, False, 255, 255, "State", System.Data.DataRowVersion.Current, Nothing)
            a__7(6) = New System.Data.ADO.ADOParameter("Country", System.Data.ADO.ADODBType.VarChar, 50, System.Data.ParameterDirection.Input, False, 255, 255, "Country", System.Data.DataRowVersion.Current, Nothing)
            a__7(7) = New System.Data.ADO.ADOParameter("Detail", System.Data.ADO.ADODBType.VarChar, 3000, System.Data.ParameterDirection.Input, False, 255, 255, "Detail", System.Data.DataRowVersion.Current, Nothing)
            a__7(8) = New System.Data.ADO.ADOParameter("MinRate", System.Data.ADO.ADODBType.Currency, 8, System.Data.ParameterDirection.Input, False, 19, 4, "MinRate", System.Data.DataRowVersion.Current, Nothing)
            a__7(9) = New System.Data.ADO.ADOParameter("MaxRate", System.Data.ADO.ADODBType.Currency, 8, System.Data.ParameterDirection.Input, False, 19, 4, "MaxRate", System.Data.DataRowVersion.Current, Nothing)
            a__7(10) = New System.Data.ADO.ADOParameter("Key_FacilityID", System.Data.ADO.ADODBType.Integer, 4, System.Data.ParameterDirection.Input, False, 10, 0, "FacilityID", System.Data.DataRowVersion.Current, Nothing)
            a__7(11) = New System.Data.ADO.ADOParameter("Key2_FacilityID", System.Data.ADO.ADODBType.Integer, 4, System.Data.ParameterDirection.Input, False, 10, 0, "FacilityID", System.Data.DataRowVersion.Current, Nothing)
            FacilityDSCmd.UpdateCommand = New System.Data.ADO.ADOCommand(FacilityCon, "UPDATE Facility SET Chain = ?,  FacilityID = ?,  Address = ?,  PostalCode = ?,  City = ?,  State = ?,  Country = ?,  Detail = ?,  MinRate = ?,  MaxRate = ? WHERE (FacilityID = ?) ;SELECT Chain,  FacilityID,  Address,  PostalCode,  City,  State,  Country,  Detail,  MinRate,  MaxRate FROM Facility WHERE (FacilityID = ?) ", System.Data.CommandType.Text, False, a__7, System.Data.UpdateRowSource.Both)
            '@design FacilityDSCmd.SetLocation(New System.Drawing.Point(354, 7))
            Dim a__8(1) As System.Data.ADO.ADOParameter
            a__8(0) = New System.Data.ADO.ADOParameter("FacilityID", System.Data.ADO.ADODBType.Integer, 4, System.Data.ParameterDirection.Input, False, 10, 0, "FacilityID", System.Data.DataRowVersion.Current, Nothing)
            FacilityDSCmd.DeleteCommand = New System.Data.ADO.ADOCommand(FacilityCon, "DELETE FROM Facility WHERE (FacilityID = ?) ", System.Data.CommandType.Text, False, a__8, System.Data.UpdateRowSource.Both)
            Dim a__9(11) As System.Data.ADO.ADOParameter
            a__9(0) = New System.Data.ADO.ADOParameter("Chain", System.Data.ADO.ADODBType.VarChar, 50, System.Data.ParameterDirection.Input, False, 255, 255, "Chain", System.Data.DataRowVersion.Current, Nothing)
            a__9(1) = New System.Data.ADO.ADOParameter("FacilityID", System.Data.ADO.ADODBType.Integer, 4, System.Data.ParameterDirection.Input, False, 10, 0, "FacilityID", System.Data.DataRowVersion.Current, Nothing)
            a__9(2) = New System.Data.ADO.ADOParameter("Address", System.Data.ADO.ADODBType.VarChar, 300, System.Data.ParameterDirection.Input, False, 255, 255, "Address", System.Data.DataRowVersion.Current, Nothing)
            a__9(3) = New System.Data.ADO.ADOParameter("PostalCode", System.Data.ADO.ADODBType.VarChar, 10, System.Data.ParameterDirection.Input, False, 255, 255, "PostalCode", System.Data.DataRowVersion.Current, Nothing)
            a__9(4) = New System.Data.ADO.ADOParameter("City", System.Data.ADO.ADODBType.VarChar, 50, System.Data.ParameterDirection.Input, False, 255, 255, "City", System.Data.DataRowVersion.Current, Nothing)
            a__9(5) = New System.Data.ADO.ADOParameter("State", System.Data.ADO.ADODBType.VarChar, 50, System.Data.ParameterDirection.Input, False, 255, 255, "State", System.Data.DataRowVersion.Current, Nothing)
            a__9(6) = New System.Data.ADO.ADOParameter("Country", System.Data.ADO.ADODBType.VarChar, 50, System.Data.ParameterDirection.Input, False, 255, 255, "Country", System.Data.DataRowVersion.Current, Nothing)
            a__9(7) = New System.Data.ADO.ADOParameter("Detail", System.Data.ADO.ADODBType.VarChar, 3000, System.Data.ParameterDirection.Input, False, 255, 255, "Detail", System.Data.DataRowVersion.Current, Nothing)
            a__9(8) = New System.Data.ADO.ADOParameter("MinRate", System.Data.ADO.ADODBType.Currency, 8, System.Data.ParameterDirection.Input, False, 19, 4, "MinRate", System.Data.DataRowVersion.Current, Nothing)
            a__9(9) = New System.Data.ADO.ADOParameter("MaxRate", System.Data.ADO.ADODBType.Currency, 8, System.Data.ParameterDirection.Input, False, 19, 4, "MaxRate", System.Data.DataRowVersion.Current, Nothing)
            a__9(10) = New System.Data.ADO.ADOParameter("Key_FacilityID", System.Data.ADO.ADODBType.Integer, 4, System.Data.ParameterDirection.Input, False, 10, 0, "FacilityID", System.Data.DataRowVersion.Current, Nothing)
            FacilityDSCmd.InsertCommand = New System.Data.ADO.ADOCommand(FacilityCon, "INSERT INTO Facility( Chain,  FacilityID,  Address,  PostalCode,  City,  State,  Country,  Detail,  MinRate,  MaxRate ) VALUES( ?,  ?,  ?,  ?,  ?,  ?,  ?,  ?,  ?,  ? ) ;SELECT Chain,  FacilityID,  Address,  PostalCode,  City,  State,  Country,  Detail,  MinRate,  MaxRate FROM Facility WHERE (FacilityID = ?) ", System.Data.CommandType.Text, False, a__9, System.Data.UpdateRowSource.Both)
            Dim a__10(4) As System.Data.ADO.ADOParameter
            a__10(0) = New System.Data.ADO.ADOParameter("Parameter1", System.Data.ADO.ADODBType.VarChar, 50, System.Data.ParameterDirection.Input, False, 255, 255, "", System.Data.DataRowVersion.Current, Nothing)
            a__10(1) = New System.Data.ADO.ADOParameter("Parameter2", System.Data.ADO.ADODBType.VarChar, 50, System.Data.ParameterDirection.Input, False, 255, 255, "", System.Data.DataRowVersion.Current, Nothing)
            a__10(2) = New System.Data.ADO.ADOParameter("Parameter3", System.Data.ADO.ADODBType.Currency, 8, System.Data.ParameterDirection.Input, False, 19, 4, "", System.Data.DataRowVersion.Current, Nothing)
            a__10(3) = New System.Data.ADO.ADOParameter("Parameter4", System.Data.ADO.ADODBType.VarChar, 50, System.Data.ParameterDirection.Input, False, 255, 255, "", System.Data.DataRowVersion.Current, Nothing)
            FacilityDSCmd.SelectCommand = New System.Data.ADO.ADOCommand(FacilityCon, "SELECT Chain,  FacilityID,  Address,  PostalCode,  City,  State,  Country,  Detail,  MinRate,  MaxRate FROM Facility WHERE (City = ?) AND  (State = ?) AND  (MaxRate <= ?) AND  (Chain LIKE ?) ORDER BY MaxRate ASC", System.Data.CommandType.Text, False, a__10, System.Data.UpdateRowSource.Both)
            Dim a__11(10) As System.Data.Internal.DataColumnMapping
            a__11(0) = New System.Data.Internal.DataColumnMapping("Chain", "Chain")
            a__11(1) = New System.Data.Internal.DataColumnMapping("FacilityID", "FacilityID")
            a__11(2) = New System.Data.Internal.DataColumnMapping("Address", "Address")
            a__11(3) = New System.Data.Internal.DataColumnMapping("PostalCode", "PostalCode")
            a__11(4) = New System.Data.Internal.DataColumnMapping("City", "City")
            a__11(5) = New System.Data.Internal.DataColumnMapping("State", "State")
            a__11(6) = New System.Data.Internal.DataColumnMapping("Country", "Country")
            a__11(7) = New System.Data.Internal.DataColumnMapping("Detail", "Detail")
            a__11(8) = New System.Data.Internal.DataColumnMapping("MinRate", "MinRate")
            a__11(9) = New System.Data.Internal.DataColumnMapping("MaxRate", "MaxRate")
            Dim a__12(1) As System.Data.Internal.DataTableMapping
            a__12(0) = New System.Data.Internal.DataTableMapping("Table", "Facility", a__11)
            FacilityDSCmd.TableMappings.All = a__12

        End Sub

        Overrides Sub Dispose()
            'CODEGEN: This procedure is required by the WebServices Designer
            'Do not modify it using the code editor.
        End Sub

        Private Function UpdateReservationDataSource(ByRef updatedDataSet As System.Data.DataSet) As System.Data.DataSet
            'Update DataSet with data from all adapters

            Me.ReservationDSCmdUpdateDataSource(updatedDataSet)

            Return updatedDataSet

        End Function

        Private Function ReservationDSCmdUpdateDataSource(ByRef updatedDataSet As System.Data.DataSet) As Integer
            Dim UpdatedRows As System.Data.DataSet

            Dim RowsAffected As Integer

            Try
                'Get all of the updated rows and update the datastore
                UpdatedRows = updatedDataSet.GetChanges(System.Data.DataRowState.Modified)
                RowsAffected = Me.ReservationDSCmd.Update(UpdatedRows)
                Return RowsAffected
            Catch eUpdateException As System.Exception
                Throw eUpdateException
            End Try

        End Function

        Private Function InsertReservationDataSource(ByRef insertedDataSet As System.Data.DataSet) As System.Data.DataSet
            'Update DataSet with data from all adapters

            Me.ReservationDSCmdInsertDataSource(insertedDataSet)

            Return insertedDataSet

        End Function

        Private Function ReservationDSCmdInsertDataSource(ByRef insertedDataSet As System.Data.DataSet) As Integer
            Dim InsertedRows As System.Data.DataSet
            Dim RowsAffected As Integer

            Try
                'Get all of the inserted rows and update the datastore
                InsertedRows = insertedDataSet.GetChanges(System.Data.DataRowState.New)
                RowsAffected = Me.ReservationDSCmd.Update(InsertedRows)
                Return RowsAffected

            Catch eUpdateException As System.Exception
                Throw eUpdateException
            End Try

        End Function

        Private Function ReservationDSCmdFillDataSet(ByVal dataSet As System.Data.DataSet, ByVal Parameter1 As Long) As Integer
            Dim RowsAffected As Integer

            'Create an error handling block in case filldataset throws an exception

            Try
                'Load the dataset from the command
                Me.ReservationDSCmd.SelectCommand.Parameters("Parameter1").Value = Parameter1
                RowsAffected = Me.ReservationDSCmd.FillDataSet(dataSet)
            Catch eFillException As System.Exception
                'TODO: Handle errors here
                Throw eFillException
            End Try

            Return RowsAffected

        End Function


        Private Function FacilityDSCmdFillDataSet(ByVal dataSet As System.Data.DataSet, ByVal Parameter1 As String, ByVal Parameter2 As String, ByVal Parameter3 As Double, ByVal Parameter4 As String) As Integer
            Dim RowsAffected As Integer

            'Create an error handling block in case filldataset throws an exception

            Try
                'Load the dataset from the command
                Me.FacilityDSCmd.SelectCommand.Parameters("Parameter1").Value = Parameter1
                Me.FacilityDSCmd.SelectCommand.Parameters("Parameter2").Value = Parameter2
                Me.FacilityDSCmd.SelectCommand.Parameters("Parameter3").Value = Parameter3
                Me.FacilityDSCmd.SelectCommand.Parameters("Parameter4").Value = Parameter4 & "%"
                RowsAffected = Me.FacilityDSCmd.FillDataSet(dataSet)
            Catch eFillException As System.Exception
                'TODO: Handle errors here
                Throw eFillException
            End Try

            Return RowsAffected

        End Function



        Private Function FillReservationDataSet(ByVal dataSet As System.Data.DataSet, ByVal Parameter1 As Long) As System.Data.DataSet
            'Open connections for database adapters

            Me.ReservationCon.Open()

            'Fill DataSet with data from all adapters

            Me.ReservationDSCmdFillDataSet(dataSet, Parameter1)

            'Close connections for database adapters

            Me.ReservationCon.Close()

            Return dataSet

        End Function


        Public Function FillFacilityDataSet(ByVal dataSet As System.Data.DataSet, ByVal Parameter1 As String, ByVal Parameter2 As String, ByVal Parameter3 As Double, ByVal Parameter4 As String) As System.Data.DataSet
            'Open connections for database adapters

            Me.FacilityCon.Open()

            'Fill DataSet with data from all adapters
            
            Me.FacilityDSCmdFillDataSet(dataSet, Parameter1, Parameter2, Parameter3, Parameter4)

            'Close connections for database adapters

            Me.FacilityCon.Close()

            Return dataSet

        End Function

    End Class


End Namespace
