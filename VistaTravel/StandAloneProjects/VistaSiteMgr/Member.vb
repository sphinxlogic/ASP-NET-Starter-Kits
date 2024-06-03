Imports System
Imports System.Collections
Imports System.Core
Imports System.ComponentModel
Imports System.Configuration
Imports System.Data
Imports System.Web.Services
Imports System.Diagnostics

Namespace VistaSiteMgr

    Public Class Member
        Inherits System.ComponentModel.Component

        'Required by the Component Designer
        Private components As Container
        Private ADOConnection1 As System.Data.ADO.ADOConnection
        Private cmdMemberList As System.Data.ADO.ADODataSetCommand
        

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
            Me.cmdMemberList = New System.Data.ADO.ADODataSetCommand
            Me.ADOConnection1 = New System.Data.ADO.ADOConnection

            '@design Me.SetGenerateDataSet(False)
            '@design Me.SetGenerateCode(True)

            Dim a__1(5) As System.Data.ADO.ADOParameter
            a__1(0) = New System.Data.ADO.ADOParameter("MemberID", System.Data.ADO.ADODBType.Integer, 4, System.Data.ParameterDirection.Input, False, 10, 0, "MemberID", System.Data.DataRowVersion.Current, Nothing)
            a__1(1) = New System.Data.ADO.ADOParameter("First_Name", System.Data.ADO.ADODBType.VarChar, 15, System.Data.ParameterDirection.Input, False, 255, 255, "First_Name", System.Data.DataRowVersion.Current, Nothing)
            a__1(2) = New System.Data.ADO.ADOParameter("Last_Name", System.Data.ADO.ADODBType.VarChar, 20, System.Data.ParameterDirection.Input, False, 255, 255, "Last_Name", System.Data.DataRowVersion.Current, Nothing)
            a__1(3) = New System.Data.ADO.ADOParameter("Key_MemberID", System.Data.ADO.ADODBType.Integer, 4, System.Data.ParameterDirection.Input, False, 10, 0, "MemberID", System.Data.DataRowVersion.Current, Nothing)
            a__1(4) = New System.Data.ADO.ADOParameter("Key2_MemberID", System.Data.ADO.ADODBType.Integer, 4, System.Data.ParameterDirection.Input, False, 10, 0, "MemberID", System.Data.DataRowVersion.Current, Nothing)
            cmdMemberList.UpdateCommand = New System.Data.ADO.ADOCommand(ADOConnection1, "UPDATE Member SET MemberID = ?,  First_Name = ?,  Last_Name = ? WHERE (MemberID = ?) ;SELECT MemberID,  First_Name,  Last_Name FROM Member WHERE (MemberID = ?) ", System.Data.CommandType.Text, False, a__1, System.Data.UpdateRowSource.Both)
            '@design cmdMemberList.SetLocation(New System.Drawing.Point(7, 7))
            Dim a__2(1) As System.Data.ADO.ADOParameter
            a__2(0) = New System.Data.ADO.ADOParameter("MemberID", System.Data.ADO.ADODBType.Integer, 4, System.Data.ParameterDirection.Input, False, 10, 0, "MemberID", System.Data.DataRowVersion.Current, Nothing)
            cmdMemberList.DeleteCommand = New System.Data.ADO.ADOCommand(ADOConnection1, "DELETE FROM Member WHERE (MemberID = ?) ", System.Data.CommandType.Text, False, a__2, System.Data.UpdateRowSource.Both)
            Dim a__3(4) As System.Data.ADO.ADOParameter
            a__3(0) = New System.Data.ADO.ADOParameter("MemberID", System.Data.ADO.ADODBType.Integer, 4, System.Data.ParameterDirection.Input, False, 10, 0, "MemberID", System.Data.DataRowVersion.Current, Nothing)
            a__3(1) = New System.Data.ADO.ADOParameter("First_Name", System.Data.ADO.ADODBType.VarChar, 15, System.Data.ParameterDirection.Input, False, 255, 255, "First_Name", System.Data.DataRowVersion.Current, Nothing)
            a__3(2) = New System.Data.ADO.ADOParameter("Last_Name", System.Data.ADO.ADODBType.VarChar, 20, System.Data.ParameterDirection.Input, False, 255, 255, "Last_Name", System.Data.DataRowVersion.Current, Nothing)
            a__3(3) = New System.Data.ADO.ADOParameter("Key_MemberID", System.Data.ADO.ADODBType.Integer, 4, System.Data.ParameterDirection.Input, False, 10, 0, "MemberID", System.Data.DataRowVersion.Current, Nothing)
            cmdMemberList.InsertCommand = New System.Data.ADO.ADOCommand(ADOConnection1, "INSERT INTO Member( MemberID,  First_Name,  Last_Name ) VALUES( ?,  ?,  ? ) ;SELECT MemberID,  First_Name,  Last_Name FROM Member WHERE (MemberID = ?) ", System.Data.CommandType.Text, False, a__3, System.Data.UpdateRowSource.Both)
            Dim a__4() As System.Data.ADO.ADOParameter
            cmdMemberList.SelectCommand = New System.Data.ADO.ADOCommand(ADOConnection1, "SELECT MemberID,  First_Name,  Last_Name FROM Member ", System.Data.CommandType.Text, False, a__4, System.Data.UpdateRowSource.Both)
            Dim a__5(3) As System.Data.Internal.DataColumnMapping
            a__5(0) = New System.Data.Internal.DataColumnMapping("MemberID", "MemberID")
            a__5(1) = New System.Data.Internal.DataColumnMapping("First_Name", "First_Name")
            a__5(2) = New System.Data.Internal.DataColumnMapping("Last_Name", "Last_Name")
            Dim a__6(1) As System.Data.Internal.DataTableMapping
            a__6(0) = New System.Data.Internal.DataTableMapping("Table", "Member", a__5)
            cmdMemberList.TableMappings.All = a__6

            ADOConnection1.ConnectionString = "Provider=SQLOLEDB.1;Persist Security Info=False;User ID=sa;Initial Catalog=Profile;Data Source=(local);Use Procedure for Prepare=1;Auto Translate=True;Packet Size=4096;Workstation ID=ENWEIX-RI1;Use Encryption for Data=False;Tag with column collation when possible=False"

        End Sub
        Public Function Load(ByVal MemberID As Long) As DataSet
            Dim sSQL As String
            Dim dsLoad As DataSet
            Dim adodscmd As ADO.ADODataSetCommand
            Dim adoconn As ADO.ADOConnection
            dsLoad = New DataSet
            adodscmd = New ADO.ADODataSetCommand
            adoconn = New ADO.ADOConnection
            
            sSQL = "SELECT MemberID, First_Name, Last_Name, Title, Email, Day_Phone, Evening_Phone, Marital_Status,"
            sSQL = sSQL & " Gender, Registration_Date, Login, Password, StreetAddress1, StreetAddress2, City, State, Country, Apartment, PostalCode, BillingStreet1, BillingStreet2, BillingCity, BillingState, BillingCountry, BillingApartment, BillingPostalCode, BillingAddressSame FROM Member WHERE MemberID = "
            sSQL = sSQL & MemberID

            'PrepSelectADODataSetCommand(OrderDSCmd)			
            adoconn.ConnectionString = "Provider=SQLOLEDB.1;Persist Security Info=False;User ID=sa;Initial Catalog=Profile; Data Source=(local);Use Procedure for Prepare=1;Auto Translate=True;Packet Size=4096;Workstation ID=ENWEIX-RI1;Use Encryption for Data=False;Tag with column collation when possible=False;"
            Dim a__10() As System.Data.ADO.ADOParameter
            
            'sSQL = dynamic SQL string 
            adodscmd.SelectCommand = New System.Data.ADO.ADOCommand(adoconn, sSQL, System.Data.CommandType.Text, False, a__10, System.Data.UpdateRowSource.Both)

            Dim a__11(26) As System.Data.Internal.DataColumnMapping
            a__11(0) = New System.Data.Internal.DataColumnMapping("MemberID", "MemberID")
            a__11(1) = New System.Data.Internal.DataColumnMapping("First_Name", "First_Name")
            a__11(2) = New System.Data.Internal.DataColumnMapping("Last_Name", "Last_Name")
            a__11(3) = New System.Data.Internal.DataColumnMapping("Title", "Title")
            a__11(4) = New System.Data.Internal.DataColumnMapping("Email", "Email")
            a__11(5) = New System.Data.Internal.DataColumnMapping("Day_Phone", "Day_Phone")
            a__11(6) = New System.Data.Internal.DataColumnMapping("Evening_Phone", "Evening_Phone")
            a__11(7) = New System.Data.Internal.DataColumnMapping("Marital_Status", "Marital_Status")
            a__11(8) = New System.Data.Internal.DataColumnMapping("Registration_Date", "Registration_Date")
            a__11(9) = New System.Data.Internal.DataColumnMapping("Login", "Login")
            a__11(10) = New System.Data.Internal.DataColumnMapping("Password", "Password")
            a__11(11) = New System.Data.Internal.DataColumnMapping("StreetAddress1", "StreetAddress1")
            a__11(12) = New System.Data.Internal.DataColumnMapping("StreetAddress2", "StreetAddress2")
            a__11(13) = New System.Data.Internal.DataColumnMapping("City", "City")
            a__11(14) = New System.Data.Internal.DataColumnMapping("State", "State")
            a__11(15) = New System.Data.Internal.DataColumnMapping("Country", "Country")
            a__11(16) = New System.Data.Internal.DataColumnMapping("Apartment", "Apartment")
            a__11(17) = New System.Data.Internal.DataColumnMapping("PostalCode", "PostalCode")
            a__11(18) = New System.Data.Internal.DataColumnMapping("BillingStreetAddress1", "BillingStreetAddress1")
            a__11(19) = New System.Data.Internal.DataColumnMapping("BillingStreetAddress2", "BillingStreetAddress2")
            a__11(20) = New System.Data.Internal.DataColumnMapping("BillingCity", "BillingCity")
            a__11(21) = New System.Data.Internal.DataColumnMapping("BillingState", "BillingState")
            a__11(22) = New System.Data.Internal.DataColumnMapping("BillingCountry", "BillingCountry")
            a__11(23) = New System.Data.Internal.DataColumnMapping("BillingApartment", "BillingApartment")
            a__11(24) = New System.Data.Internal.DataColumnMapping("BillingPostalCode", "BillingPostalCode")
            a__11(25) = New System.Data.Internal.DataColumnMapping("BillingSameAddress", "BillingSameAddress")

            Dim a__12(1) As System.Data.Internal.DataTableMapping
            a__12(0) = New System.Data.Internal.DataTableMapping("Table", "Member", a__11)
            adodscmd.TableMappings.All = a__12

            adodscmd.FillDataSet(dsLoad)
			
            'Return the data
            Load = dsLoad

        End Function

        Public Function Login(ByVal UserName As String, ByVal Password As String) As DataSet
            Dim sSQL As String
            Dim dsLogin As DataSet
            Dim adodscmd As ADO.ADODataSetCommand
            Dim adoconn As ADO.ADOConnection
            dsLogin = New DataSet
            adodscmd = New ADO.ADODataSetCommand
            adoconn = New ADO.ADOConnection
            
            sSQL = "SELECT MemberID, First_Name, Last_Name, Title, Email, Day_Phone, Evening_Phone, Marital_Status,"
            sSQL = sSQL & " Gender, Registration_Date, Login, Password, StreetAddress1, StreetAddress2, City, State, Country, Apartment, PostalCode, BillingStreet1, BillingStreet2, BillingCity, BillingState, BillingCountry, BillingApartment, BillingPostalCode, BillingAddressSame FROM Member WHERE Login = "
            sSQL = sSQL & "'" & UserName & "' AND Password = '" & Password & "'"

            'PrepSelectADODataSetCommand(OrderDSCmd)			
            adoconn.ConnectionString = "Provider=SQLOLEDB.1;Persist Security Info=False;User ID=sa;Initial Catalog=Profile; Data Source=(local);Use Procedure for Prepare=1;Auto Translate=True;Packet Size=4096;Workstation ID=ENWEIX-RI1;Use Encryption for Data=False;Tag with column collation when possible=False;"
            Dim a__10() As System.Data.ADO.ADOParameter
            
            'sSQL = dynamic SQL string 
            adodscmd.SelectCommand = New System.Data.ADO.ADOCommand(adoconn, sSQL, System.Data.CommandType.Text, False, a__10, System.Data.UpdateRowSource.Both)

            Dim a__11(26) As System.Data.Internal.DataColumnMapping
            a__11(0) = New System.Data.Internal.DataColumnMapping("MemberID", "MemberID")
            a__11(1) = New System.Data.Internal.DataColumnMapping("First_Name", "First_Name")
            a__11(2) = New System.Data.Internal.DataColumnMapping("Last_Name", "Last_Name")
            a__11(3) = New System.Data.Internal.DataColumnMapping("Title", "Title")
            a__11(4) = New System.Data.Internal.DataColumnMapping("Email", "Email")
            a__11(5) = New System.Data.Internal.DataColumnMapping("Day_Phone", "Day_Phone")
            a__11(6) = New System.Data.Internal.DataColumnMapping("Evening_Phone", "Evening_Phone")
            a__11(7) = New System.Data.Internal.DataColumnMapping("Marital_Status", "Marital_Status")
            a__11(8) = New System.Data.Internal.DataColumnMapping("Registration_Date", "Registration_Date")
            a__11(9) = New System.Data.Internal.DataColumnMapping("Login", "Login")
            a__11(10) = New System.Data.Internal.DataColumnMapping("Password", "Password")
            a__11(11) = New System.Data.Internal.DataColumnMapping("StreetAddress1", "StreetAddress1")
            a__11(12) = New System.Data.Internal.DataColumnMapping("StreetAddress2", "StreetAddress2")
            a__11(13) = New System.Data.Internal.DataColumnMapping("City", "City")
            a__11(14) = New System.Data.Internal.DataColumnMapping("State", "State")
            a__11(15) = New System.Data.Internal.DataColumnMapping("Country", "Country")
            a__11(16) = New System.Data.Internal.DataColumnMapping("Apartment", "Apartment")
            a__11(17) = New System.Data.Internal.DataColumnMapping("PostalCode", "PostalCode")
            a__11(18) = New System.Data.Internal.DataColumnMapping("BillingStreetAddress1", "BillingStreetAddress1")
            a__11(19) = New System.Data.Internal.DataColumnMapping("BillingStreetAddress2", "BillingStreetAddress2")
            a__11(20) = New System.Data.Internal.DataColumnMapping("BillingCity", "BillingCity")
            a__11(21) = New System.Data.Internal.DataColumnMapping("BillingState", "BillingState")
            a__11(22) = New System.Data.Internal.DataColumnMapping("BillingCountry", "BillingCountry")
            a__11(23) = New System.Data.Internal.DataColumnMapping("BillingApartment", "BillingApartment")
            a__11(24) = New System.Data.Internal.DataColumnMapping("BillingPostalCode", "BillingPostalCode")
            a__11(25) = New System.Data.Internal.DataColumnMapping("BillingSameAddress", "BillingSameAddress")
            
            Dim a__12(1) As System.Data.Internal.DataTableMapping
            a__12(0) = New System.Data.Internal.DataTableMapping("Table", "Member", a__11)
            adodscmd.TableMappings.All = a__12

            adodscmd.FillDataSet(dsLogin)
			
            'Return the data
            Login = dsLogin
        End Function

        Public Function Create(ByVal UserName As String, ByVal Password As String) As DataSet
            'NOT IMPLEMENTED
        End Function
    
        Public Function Save(ByVal dsMember As DataSet)
            'NOT IMPLEMENTED                          
        End Function

        Public Function BrowseMembers() As System.Data.DataSet
            'Fill DataSet with data from all adapters
            Dim dataSet As System.Data.DataSet
            dataset = New DataSet
            Me.cmdMemberListFillDataSet(dataSet)

            Return dataSet

        End Function

        Private Function cmdMemberListFillDataSet(ByVal dataSet As System.Data.DataSet) As Integer
            Dim RowsAffected As Integer

            'Create an error handling block in case filldataset throws an exception

            Try
                'Load the dataset from the command
                RowsAffected = Me.cmdMemberList.FillDataSet(dataSet)
            Catch eFillException As System.Exception
                Throw eFillException
            End Try

            Return RowsAffected

        End Function

        Private Function cmdMemberListUpdateDataSource(ByVal updatedDataSet As System.Data.DataSet) As Integer
            Dim DeletedRows As System.Data.DataSet

            Dim UpdatedRows As System.Data.DataSet

            Dim InsertedRows As System.Data.DataSet

            Dim RowsAffected As Integer

            Try
                'Get all of the deleted rows and update the datastore
                DeletedRows = updatedDataSet.GetChanges(System.Data.DataRowState.Deleted)
                RowsAffected = Me.cmdMemberList.Update(DeletedRows)
                'Get all of the updated rows and update the datastore
                UpdatedRows = updatedDataSet.GetChanges(System.Data.DataRowState.Modified)
                RowsAffected = ((RowsAffected) + (Me.cmdMemberList.Update(UpdatedRows)))
                'Get all of the inserted rows and update the datastore
                InsertedRows = updatedDataSet.GetChanges(System.Data.DataRowState.New)
                RowsAffected = ((RowsAffected) + (Me.cmdMemberList.Update(InsertedRows)))
                Return RowsAffected
            Catch eUpdateException As System.Exception
                Throw eUpdateException
            End Try

        End Function

    End Class

End Namespace
