Imports System
Imports System.Collections
Imports System.Core
Imports System.ComponentModel
Imports System.Configuration
Imports System.Data
Imports System.Web.Services
Imports System.Diagnostics

Namespace VistaSiteMgr

    Public Class MemberPref
        Inherits System.ComponentModel.Component

        'Required by the Component Designer
        Private components As Container

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

        End Sub
        Public Function Create() As DataSet
            'NOT IMPLEMENTED
        End Function
    
        Public Function Save(ByVal dsMember As DataSet)
            'NOT IMPLEMENTED                          
        End Function

        Public Function BrowseByMemberPrefType(ByVal MemberID As Long, ByVal PrefType As String) As DataSet
            Dim sSQL As String
            Dim dsMemberPref As DataSet
            Dim adodscmd As ADO.ADODataSetCommand
            Dim adoconn As ADO.ADOConnection
            dsMemberPref = New DataSet
            adodscmd = New ADO.ADODataSetCommand
            adoconn = New ADO.ADOConnection
            
            sSQL = "SELECT mp.MemberPrefID, mp.MemberID, mp.PrefID, mp.MemberPrefValue, mp.MemberPrefOrder"
            sSQL = sSQL & ", p.PrefType, p.Description, p.RequiresValue FROM MemberPref mp, Preference p WHERE mp.MemberID = " & MemberID
            sSQL = sSQL & " AND mp.PrefID = p.PrefID AND p.PrefType = '" & PrefType & "' ORDER BY mp.MemberPrefOrder"

            'PrepSelectADODataSetCommand(OrderDSCmd)			
            adoconn.ConnectionString = "Provider=SQLOLEDB.1;Persist Security Info=False;User ID=sa;Initial Catalog=Profile; Data Source=(local);Use Procedure for Prepare=1;Auto Translate=True;Packet Size=4096;Workstation ID=ENWEIX-RI1;Use Encryption for Data=False;Tag with column collation when possible=False;"
            Dim a__10() As System.Data.ADO.ADOParameter
            
            'sSQL = dynamic SQL string 
            adodscmd.SelectCommand = New System.Data.ADO.ADOCommand(adoconn, sSQL, System.Data.CommandType.Text, False, a__10, System.Data.UpdateRowSource.Both)

            Dim a__11(5) As System.Data.Internal.DataColumnMapping
            a__11(0) = New System.Data.Internal.DataColumnMapping("MemberPrefID", "MemberPrefID")
            a__11(1) = New System.Data.Internal.DataColumnMapping("MemberID", "MemberID")
            a__11(2) = New System.Data.Internal.DataColumnMapping("PrefID", "PrefID")
            a__11(3) = New System.Data.Internal.DataColumnMapping("MemberPrefValue", "MemberPrefValue")
            a__11(4) = New System.Data.Internal.DataColumnMapping("MemberPrefOrder", "MemberPrefOrder")

            Dim a__12(1) As System.Data.Internal.DataTableMapping
            a__12(0) = New System.Data.Internal.DataTableMapping("Table", "MemberPref", a__11)
            adodscmd.TableMappings.All = a__12

            'Get the data which be stuffed in the DataSet object			
            adodscmd.FillDataSet(dsMemberPref)

            'Return the data
            BrowseByMemberPrefType = dsMemberPref
        End Function

        Public Function BrowseByMember(ByVal MemberID As Long) As DataSet
            Dim sSQL As String
            Dim dsMemberPref As DataSet
            Dim adodscmd As ADO.ADODataSetCommand
            Dim adoconn As ADO.ADOConnection
            dsMemberPref = New DataSet
            adodscmd = New ADO.ADODataSetCommand
            adoconn = New ADO.ADOConnection
            
            sSQL = "SELECT mp.MemberPrefID, mp.MemberID, mp.PrefID, mp.MemberPrefValue, mp.MemberPrefOrder"
            sSQL = sSQL & ", p.PrefType, p.Description, p.RequiresValue FROM MemberPref mp, Preference p WHERE mp.MemberID = " & MemberID
            sSQL = sSQL & " AND mp.PrefID = p.PrefID ORDER BY p.PrefType, mp.MemberPrefOrder"

            'PrepSelectADODataSetCommand(OrderDSCmd)			
            adoconn.ConnectionString = "Provider=SQLOLEDB.1;Persist Security Info=False;User ID=sa;Initial Catalog=Profile; Data Source=(local);Use Procedure for Prepare=1;Auto Translate=True;Packet Size=4096;Workstation ID=ENWEIX-RI1;Use Encryption for Data=False;Tag with column collation when possible=False;"
            Dim a__10() As System.Data.ADO.ADOParameter
            
            'sSQL = dynamic SQL string 
            adodscmd.SelectCommand = New System.Data.ADO.ADOCommand(adoconn, sSQL, System.Data.CommandType.Text, False, a__10, System.Data.UpdateRowSource.Both)

            Dim a__11(5) As System.Data.Internal.DataColumnMapping
            a__11(0) = New System.Data.Internal.DataColumnMapping("MemberPrefID", "MemberPrefID")
            a__11(1) = New System.Data.Internal.DataColumnMapping("MemberID", "MemberID")
            a__11(2) = New System.Data.Internal.DataColumnMapping("PrefID", "PrefID")
            a__11(3) = New System.Data.Internal.DataColumnMapping("MemberPrefValue", "MemberPrefValue")
            a__11(4) = New System.Data.Internal.DataColumnMapping("MemberPrefOrder", "MemberPrefOrder")

            Dim a__12(1) As System.Data.Internal.DataTableMapping
            a__12(0) = New System.Data.Internal.DataTableMapping("Table", "MemberPref", a__11)
            adodscmd.TableMappings.All = a__12

            'Get the data which be stuffed in the DataSet object			
            adodscmd.FillDataSet(dsMemberPref)

            'Return the data
            BrowseByMember = dsMemberPref
        End Function

        Public Function BrowseByPrefType(ByVal PrefType As String) As DataSet
            Dim sSQL As String
            Dim dsPref As DataSet
            Dim adodscmd As ADO.ADODataSetCommand
            Dim adoconn As ADO.ADOConnection
            dsPref = New DataSet
            adodscmd = New ADO.ADODataSetCommand
            adoconn = New ADO.ADOConnection
            
            sSQL = "SELECT p.PrefID, p.PrefType, p.Description, p.RequiresValue FROM Preference p WHERE "
            sSQL = sSQL & "p.PrefType = '" & PrefType & "' ORDER BY p.Description"

            'PrepSelectADODataSetCommand(OrderDSCmd)			
            adoconn.ConnectionString = "Provider=SQLOLEDB.1;Persist Security Info=False;User ID=sa;Initial Catalog=Profile;Data Source=(local);Use Procedure for Prepare=1;Auto Translate=True;Packet Size=4096;Workstation ID=ENWEIX-RI1;Use Encryption for Data=False;Tag with column collation when possible=False;"
            Dim a__10() As System.Data.ADO.ADOParameter
            
            'sSQL = dynamic SQL string 
            adodscmd.SelectCommand = New System.Data.ADO.ADOCommand(adoconn, sSQL, System.Data.CommandType.Text, False, a__10, System.Data.UpdateRowSource.Both)

            Dim a__11(4) As System.Data.Internal.DataColumnMapping
            a__11(0) = New System.Data.Internal.DataColumnMapping("PrefID", "PrefID")
            a__11(1) = New System.Data.Internal.DataColumnMapping("PrefType", "PrefType")
            a__11(2) = New System.Data.Internal.DataColumnMapping("Description", "Description")
            a__11(3) = New System.Data.Internal.DataColumnMapping("RequiresValue", "RequiresValue")

            Dim a__12(1) As System.Data.Internal.DataTableMapping
            a__12(0) = New System.Data.Internal.DataTableMapping("Table", "Preference", a__11)
            adodscmd.TableMappings.All = a__12

            'Get the data which be stuffed in the DataSet object			
            adodscmd.FillDataSet(dsPref)

            'Return the data
            BrowseByPrefType = dsPref
        End Function
    End Class

End Namespace
