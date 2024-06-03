namespace POILib
{
using System;
using System.Collections;
using System.Configuration;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Web;
using System.Web.Services;
using System.Data.ADO;
using System.Data.Internal;
using System.Runtime.InteropServices;


/// <summary>
///    The order class provides means to Create, Load, and Save Order information
/// </summary>
public class Order : System.Web.Services.WebService
{
	

//****	
//****
		//ADD PInvoke CODE
	[DllImport("kernel32.dll")]
	public static extern long GetCurrentProcessId();


    public Order()
    {
        //CODEGEN: This call is required by the ASP+ Web Services Designer
        InitializeComponent();
    }

    /// <summary>
    ///    Required method for Designer support - do not modify
    ///    the contents of this method with the code editor
    /// </summary>
    private void InitializeComponent()
    {
    }

    /// <summary>
    ///    Clean up any resources being used
    /// </summary>
    public override void Dispose()
    {
    }


		/// <summary>Create is called by a client to grab a template of order information that is accepted while saving</summary>
		[WebMethod]
		public DataSet Create() 
		{
			//Declarations
			DataSet OrderDataSet;
			ADODataSetCommand OrderDSCmd;
			System.Data.ADO.ADOConnection adoCon;

			OrderDataSet = new DataSet();
			OrderDSCmd = new ADODataSetCommand();
			adoCon = new System.Data.ADO.ADOConnection();
			
			string sSQL = "";
				
			//create SQL statement		
			sSQL = "SELECT * FROM [Order] where OrderID = 0";		
			
			adoCon.ConnectionString = "Provider=SQLOLEDB.1;Persist Security Info=False;User ID=sa;Initial Catalog=PointsOfInterest;Data Source=(local);Use Procedure for Prepare=1;Auto Translate=True;Packet Size=4096;Use Encryption for Data=False;Tag with column collation when possible=False";
			OrderDSCmd.SelectCommand = new System.Data.ADO.ADOCommand(adoCon, sSQL, System.Data.CommandType.Text, false, new System.Data.ADO.ADOParameter[] {}, System.Data.UpdateRowSource.Both);		
			OrderDSCmd.TableMappings.All = new System.Data.Internal.DataTableMapping[] {new System.Data.Internal.DataTableMapping("Table", "Order", new System.Data.Internal.DataColumnMapping[] {new System.Data.Internal.DataColumnMapping("OrderID", "OrderID"), new System.Data.Internal.DataColumnMapping("ServiceID", "ServiceID"), new System.Data.Internal.DataColumnMapping("DateTime", "DateTime"), new System.Data.Internal.DataColumnMapping("FName", "FName"), new System.Data.Internal.DataColumnMapping("LName", "LName"), new System.Data.Internal.DataColumnMapping("CCType", "CCType"), new System.Data.Internal.DataColumnMapping("CCNumber", "CCNumber"), new System.Data.Internal.DataColumnMapping("CCExpDate", "CCExpDate"), new System.Data.Internal.DataColumnMapping("Address", "Address")})};

			//Get the data which be stuffed in the DataSet object			
			OrderDSCmd.FillDataSet(OrderDataSet);
			
			/// <returns>Returns Empty DataSet of Order Fields</returns>
			//Return the data
			return OrderDataSet;

		}

//****	
//****
		//ADD XML Document Attributes Summary and Params tag for Load
		/// <summary>Load takes an existing ConfirmationNumber to retrun Order information</summary>	
		/// <param name="ConfirmationNumber">Used to indicate an order ConfirmationNumber</param>


//****	
//****
		//ADD LOAD CODE
		[WebMethod]
		public DataSet load(long ConfirmationNumber){
			//Declarations
			DataSet OrderDataSet;
			ADODataSetCommand OrderDSCmd;
			System.Data.ADO.ADOConnection adoCon;

			OrderDataSet = new DataSet();
			OrderDSCmd = new ADODataSetCommand();			
			adoCon = new System.Data.ADO.ADOConnection();
          			
			string sSQL = "";
			string sSelect = "";
			string sFrom = "";
			string sWhere = "";							
						
			//Build the dynamic SQL statement
			//create SQL statement
			sSelect = sSelect + "SELECT ";

			sSelect = sSelect + "OrderID, ";
			sSelect = sSelect + "ServiceID, ";
			sSelect = sSelect + "DateTime, ";
			sSelect = sSelect + "FName, ";
			sSelect = sSelect + "LName, ";
			sSelect = sSelect + "CCType, ";
			sSelect = sSelect + "CCNumber, ";
			sSelect = sSelect + "CCExpDate, ";
			sSelect = sSelect + "Address ";
			
			sFrom = sFrom + "FROM ";
			sFrom = sFrom + "[Order] ";
			
			sWhere = sWhere + "WHERE ";
			sWhere = sWhere + "OrderID = '" + ConfirmationNumber + "' ";
		
			sSQL = sSelect + sFrom + sWhere;		
						
			adoCon.ConnectionString = "Provider=SQLOLEDB.1;Persist Security Info=False;User ID=sa;Initial Catalog=PointsOfInterest;Data Source=(local);Use Procedure for Prepare=1;Auto Translate=True;Packet Size=4096;Workstation ID=(local);Use Encryption for Data=False;Tag with column collation when possible=False";			
			OrderDSCmd.SelectCommand = new System.Data.ADO.ADOCommand(adoCon, sSQL, System.Data.CommandType.Text, false, new System.Data.ADO.ADOParameter[] {}, System.Data.UpdateRowSource.Both);		
			OrderDSCmd.TableMappings.All = new System.Data.Internal.DataTableMapping[] {new System.Data.Internal.DataTableMapping("Table", "Order", new System.Data.Internal.DataColumnMapping[] {new System.Data.Internal.DataColumnMapping("OrderID", "OrderID"), new System.Data.Internal.DataColumnMapping("ServiceID", "ServiceID"), new System.Data.Internal.DataColumnMapping("DateTime", "DateTime"), new System.Data.Internal.DataColumnMapping("FName", "FName"), new System.Data.Internal.DataColumnMapping("LName", "LName"), new System.Data.Internal.DataColumnMapping("CCType", "CCType"), new System.Data.Internal.DataColumnMapping("CCNumber", "CCNumber"), new System.Data.Internal.DataColumnMapping("CCExpDate", "CCExpDate"), new System.Data.Internal.DataColumnMapping("Address", "Address")})};

			//Get the data which be stuffed in the DataSet object			
			OrderDSCmd.FillDataSet(OrderDataSet);
			
			//Return the data
			return OrderDataSet;
}





		/// <summary>Save accepts a populated dataset of order information used to insert or update an order</summary>
		/// <param name="OrderInfo">Used to indicate a populated dataset of Order information</param>		
		[WebMethod]		
		public long Save(DataSet OrderInfo) 
		//public string Save(string OrderInfo) 
		{
			//Declarations
			DataSet SaveDataSet;
			ADODataSetCommand OrderDSCmd;
			ADOConnection adoCon;
			CreditCardMgr.CheckCredit objCCMgr;
			bool blnValidCC;

			SaveDataSet = new DataSet();
			OrderDSCmd = new ADODataSetCommand();
			adoCon = new ADOConnection();
			objCCMgr = new CreditCardMgr.CheckCredit();

			//set the value of the incoming xml data to be updated
			SaveDataSet = OrderInfo;

			adoCon.ConnectionString = "Provider=SQLOLEDB.1;Persist Security Info=False;User ID=sa;Initial Catalog=PointsOfInterest;Data Source=(local);Use Procedure for Prepare=1;Auto Translate=True;Packet Size=4096;Use Encryption for Data=False;Tag with column collation when possible=False";			
			OrderDSCmd.MissingMappingAction = MissingMappingAction.Error;
			OrderDSCmd.MissingSchemaAction = MissingSchemaAction.Error;

			OrderDSCmd.TableMappings.All = new System.Data.Internal.DataTableMapping[] {new System.Data.Internal.DataTableMapping("Table", "ORDER", new System.Data.Internal.DataColumnMapping[] {new System.Data.Internal.DataColumnMapping("OrderID", "OrderID"), new System.Data.Internal.DataColumnMapping("ServiceID", "ServiceID"), new System.Data.Internal.DataColumnMapping("DateTime", "DateTime"), new System.Data.Internal.DataColumnMapping("FName", "FName"), new System.Data.Internal.DataColumnMapping("LName", "LName"), new System.Data.Internal.DataColumnMapping("CCType", "CCType"), new System.Data.Internal.DataColumnMapping("CCNumber", "CCNumber"), new System.Data.Internal.DataColumnMapping("CCExpDate", "CCExpDate"), new System.Data.Internal.DataColumnMapping("Address", "Address")})};
			
			//Before saving the info, first validate the Credit Card
			//info to make sure it's valid
			//we'll use a VB CreditCardMgr component
			//Parameters from DataSet are FName, LName, CCType, CCNumber, CCExpDate
			blnValidCC = objCCMgr.IsCardValid(System.Convert.ToString(SaveDataSet.Tables[0].Rows[0].ItemArray[3]),System.Convert.ToString(SaveDataSet.Tables[0].Rows[0].ItemArray[4]),System.Convert.ToString(SaveDataSet.Tables[0].Rows[0].ItemArray[5]),System.Convert.ToInt32(SaveDataSet.Tables[0].Rows[0].ItemArray[6]),System.Convert.ToDateTime(SaveDataSet.Tables[0].Rows[0].ItemArray[7]));
			
			if (blnValidCC)
			{
				//if the id is 0, assume this is a new one
				if (System.Convert.ToInt32(SaveDataSet.Tables[0].Rows[0].ItemArray[0]) == 0)
				{
					ADOParameter[] a__4  = new ADOParameter[9] {new ADOParameter("@orderid", ADODBType.Integer, 4, ParameterDirection.Output, false, 0, 0, "OrderID", DataRowVersion.Current, null),new ADOParameter("@serviceid", ADODBType.Integer, 4, ParameterDirection.Input, false, 0, 0, "ServiceID", DataRowVersion.Current, null),new ADOParameter("@datetime", ADODBType.Date, 8, ParameterDirection.Input, false, 0, 0, "DateTime", DataRowVersion.Current, null),new ADOParameter("@fname", ADODBType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "FName", DataRowVersion.Current, null),new ADOParameter("@lname", ADODBType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "LName", DataRowVersion.Current, null),new ADOParameter("@cctype", ADODBType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "CCType", DataRowVersion.Current, null),new ADOParameter("@ccnumber", ADODBType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "CCNumber", DataRowVersion.Current, null),new ADOParameter("@ccexpdate", ADODBType.Date, 8, ParameterDirection.Input, false, 0, 0, "CCExpDate", DataRowVersion.Current, null),new ADOParameter("@address", ADODBType.VarChar, 300, ParameterDirection.Input, false, 0, 0, "Address", DataRowVersion.Current, null)};	
					OrderDSCmd.InsertCommand = new ADOCommand(adoCon, "csOrderInsert", CommandType.StoredProcedure, false, a__4, UpdateRowSource.Both);
				}			
				//we have an existing id, so udpate the record
				else 				
				{
					ADOParameter[] a__3  = new ADOParameter[10] {new ADOParameter("@orderid", ADODBType.Integer, 4, ParameterDirection.Output, false, 0, 0, "OrderID", DataRowVersion.Current, null),new ADOParameter("@serviceid", ADODBType.Integer, 4, ParameterDirection.Input, false, 0, 0, "ServiceID", DataRowVersion.Current, null),new ADOParameter("@datetime", ADODBType.Date, 8, ParameterDirection.Input, false, 0, 0, "DateTime", DataRowVersion.Current, null),new ADOParameter("@fname", ADODBType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "FName", DataRowVersion.Current, null),new ADOParameter("@lname", ADODBType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "LName", DataRowVersion.Current, null),new ADOParameter("@cctype", ADODBType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "CCType", DataRowVersion.Current, null),new ADOParameter("@ccnumber", ADODBType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "CCNumber", DataRowVersion.Current, null),new ADOParameter("@ccexpdate", ADODBType.Date, 8, ParameterDirection.Input, false, 0, 0, "CCExpDate", DataRowVersion.Current, null),new ADOParameter("@address", ADODBType.VarChar, 300, ParameterDirection.Input, false, 0, 0, "Address", DataRowVersion.Current, null),new ADOParameter("@param10", ADODBType.Integer, 4, ParameterDirection.Input, false, 0, 0, "OrderID", DataRowVersion.Original, null)};
					//ADOParameter[] a__3  = new ADOParameter[11] {new ADOParameter("@orderid", ADODBType.Integer, 4,"OrderID"), new ADOParameter("@serviceid", ADODBType.Integer, 4,"ServiceID"), new ADOParameter("@datetime", ADODBType.DBTimeStamp, 8, "DateTime"), new ADOParameter("@fname", ADODBType.VarChar, 50, "FName"), new ADOParameter("@lname", ADODBType.VarChar, 50, "LName"), new ADOParameter("@cctype", ADODBType.VarChar, 50, "CCType"), new ADOParameter("@ccnumber", ADODBType.VarChar, 50, "CCNumber"), new ADOParameter("@ccexpdate", ADODBType.Date, 8, "CCExpDate"), new ADOParameter("@address", ADODBType.VarChar, 300, "Address"), new ADOParameter("@param11", ADODBType.Integer, 4, "OrderID")};
					OrderDSCmd.UpdateCommand = new ADOCommand(adoCon, "csOrderUpdate", CommandType.StoredProcedure, false, a__3, UpdateRowSource.Both);
				}
			}
			else
			{
				//Throw error - invalid credit card
				//First Grab the processid
				
			}
			//this update uses a stored procedure which
			//deletes and then re-inserts a new row in the OrderTable
			OrderDSCmd.Update (SaveDataSet);

			return System.Convert.ToInt32(OrderDSCmd.UpdateCommand.Parameters[0].Value);
		}	

	}
}
