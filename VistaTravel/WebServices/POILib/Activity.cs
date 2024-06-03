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

/// <summary>
///    Summary description for Activity
/// </summary>
public class Activity : System.Web.Services.WebService
{
    public Activity()
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

		/// <summary>BrowseByLocationID - browses activities at a particular location</summary>	
		/// <param name="StartDate">Indicates StartDate</param>
		/// <param name="EndDate">Indicates EndDate</param>
		/// <param name="LocationID">Indicates the locationid</param>
		/// <param name="Categories">Indicates a list of Categories</param>
		[WebMethod]
		public DataSet BrowseByLocationID(string StartDate,
								         string EndDate, 
			 					         long LocationID,  
										 string Categories) 
		{
			//Given a specific Activity location, get all of the possible
			//activities availabe, matching specific categories if given
			DataSet POIDataSet;
			ADODataSetCommand POIDSCmd;
			System.Data.ADO.ADOConnection adoCon;

			POIDataSet = new DataSet();
			POIDSCmd = new ADODataSetCommand();
			adoCon = new System.Data.ADO.ADOConnection();

			string sSQL = "";
			string sSelect = "";
			string sFrom = "";
			string sWhere = "";			
			string sIN = "";
			string[] CategoryArray;			

			//Build the dynamic SQL statement
			//create SQL statement
			sSelect = sSelect + "SELECT DISTINCT ";
			sSelect = sSelect + "a.ActivityID, ";
			sSelect = sSelect + "a.ActivityLocationID, ";
			sSelect = sSelect + "a.Name, ";
			sSelect = sSelect + "a.Description, ";
			sSelect = sSelect + "a.ReservationRequired, ";
			sSelect = sSelect + "a.Price, ";
			sSelect = sSelect + "a.StartDate, ";
			sSelect = sSelect + "a.EndDate, ";
			sSelect = sSelect + "a.KeyAttraction, ";			
			sSelect = sSelect + "a.ServicesOffered, ";
			sSelect = sSelect + "a.RequiredTime, ";
			sSelect = sSelect + "a.LocalInfoDetails ";
			
			sFrom = sFrom + "FROM ";
			sFrom = sFrom + "Activities a, ";
			sFrom = sFrom + "ActivityCategory ac, ";
			sFrom = sFrom + "Category c ";
			
			sWhere = sWhere + "WHERE ";
			sWhere = sWhere + "a.ActivityLocationID = " + LocationID + " ";
			sWhere = sWhere + " AND '" + StartDate + "' BETWEEN a.StartDate AND a.EndDate ";

			sWhere = sWhere + "AND a.ActivityID=ac.ActivityID ";
			sWhere = sWhere + "AND ac.CategoryID=c.CategoryID ";				


			if (Categories.Length > 0)
			{
				CategoryArray = ConvertStringToArray(Categories);
				
				//we could have gotten one or more categories to look up
				for ( int i = 0; i < CategoryArray.Length; i++ )
				{
					//If there is only one or this is the first time through,
					//don't append a comma		
					if (i == 0)
					{
						sIN = sIN + "'" + CategoryArray[i] + "'";
					}
					else {
						sIN = sIN + ", '" + CategoryArray[i] + "'";	
					}
				}
				

					sWhere = sWhere + "AND c.CategoryType IN ( " + sIN + ")";
			}

			sSQL = sSelect + sFrom + sWhere;
			

			adoCon.ConnectionString = "Provider=SQLOLEDB.1;Persist Security Info=False;User ID=sa;Initial Catalog=PointsOfInterest;Data Source=(local);Use Procedure for Prepare=1;Auto Translate=True;Packet Size=4096;Use Encryption for Data=False;Tag with column collation when possible=False";
			POIDSCmd.SelectCommand = new System.Data.ADO.ADOCommand(adoCon, sSQL, System.Data.CommandType.Text, false, new System.Data.ADO.ADOParameter[] {}, System.Data.UpdateRowSource.Both);		
			POIDSCmd.TableMappings.All = new System.Data.Internal.DataTableMapping[] {new System.Data.Internal.DataTableMapping("Table", "Activities", new System.Data.Internal.DataColumnMapping[] {new System.Data.Internal.DataColumnMapping("ActivityID", "ActivityID"), new System.Data.Internal.DataColumnMapping("ActivityLocationID", "ActivityLocationID"), new System.Data.Internal.DataColumnMapping("Name", "Name"), new System.Data.Internal.DataColumnMapping("Description", "Description"), new System.Data.Internal.DataColumnMapping("ReservationRequired", "ReservationRequired"), new System.Data.Internal.DataColumnMapping("Price", "Price"), new System.Data.Internal.DataColumnMapping("StartDate", "StartDate"), new System.Data.Internal.DataColumnMapping("EndDate", "EndDate"), new System.Data.Internal.DataColumnMapping("LocalInfoDetails", "LocalInfoDetails"), new System.Data.Internal.DataColumnMapping("KeyAttraction", "KeyAttraction"), new System.Data.Internal.DataColumnMapping("RequiredTime", "RequiredTime"), new System.Data.Internal.DataColumnMapping("ServicesOffered", "ServicesOffered")})};

			//Get the data which be stuffed in the DataSet object			
			POIDSCmd.FillDataSet(POIDataSet);
			
			/// <returns>Returns DataSet of activities at a particular location</returns>
			//Return the data
			return POIDataSet;
		}					

		/// <summary>BrowseByLocation - browses activityLocations and key attractions</summary>	
		/// <param name="StartDate">Indicates StartDate</param>
		/// <param name="EndDate">Indicates EndDate</param>
		/// <param name="City">Indicates an optional city</param>
		/// <param name="Region">Indicates an optional region</param>
		/// <param name="StateAbbr">Indicates an optional StateAbbr</param>
		/// <param name="CountryAbbr">Indicates an optional CountryAbbr</param>
		/// <param name="Continent">Indicates an optional Continent</param>
		/// <param name="Categories">Indicates an optional list of Categories</param>
		[WebMethod]
		public DataSet BrowseByLocation(string StartDate, 
									    string EndDate, 
								        string City, 
									    string Region, 
									    string StateAbbr, 
									    string CountryAbbr, 
									    string Continent, 
									    string Categories) 
		{
			DataSet POIDataSet;
			ADODataSetCommand POIDSCmd;
			System.Data.ADO.ADOConnection adoCon;

			POIDataSet = new DataSet();
			POIDSCmd = new ADODataSetCommand();
			adoCon = new System.Data.ADO.ADOConnection();
			
			string sSQL = "";
			string sSelect = "";
			string sFrom = "";
			string sWhere = "";			
			string sIN = "";
			string[] CategoryArray;			

			
			//Build the dynamic SQL statement
			sSelect = sSelect + "SELECT DISTINCT ";
			sSelect = sSelect + "al.ActivityLocationID, ";			
			sSelect = sSelect + "al.LocationName, ";
			sSelect = sSelect + "al.Address, ";
			sSelect = sSelect + "al.PostalCode, ";
			sSelect = sSelect + "al.City, ";
			sSelect = sSelect + "al.Region, ";
			sSelect = sSelect + "al.StateAbbr, ";
			sSelect = sSelect + "al.CountryAbbr, ";
			sSelect = sSelect + "al.Continent, ";			
			sSelect = sSelect + "al.Rating, ";		
			sSelect = sSelect + "a.ActivityID, ";
			sSelect = sSelect + "a.Name, ";
			sSelect = sSelect + "a.Description, ";
			sSelect = sSelect + "a.ReservationRequired, ";
			sSelect = sSelect + "a.Price, ";
			sSelect = sSelect + "a.StartDate, ";
			sSelect = sSelect + "a.EndDate, ";
			sSelect = sSelect + "a.KeyAttraction, ";			
			sSelect = sSelect + "a.ServicesOffered, ";
			sSelect = sSelect + "a.RequiredTime, ";
			sSelect = sSelect + "a.LocalInfoDetails, ";		
			sSelect = sSelect + "a.DiningAvailable ";		
			
			sFrom = sFrom + "FROM ";
			sFrom = sFrom + "ActivityLocation al, ";			
			sFrom = sFrom + "Activities a ";
			
			sWhere = sWhere + "WHERE ";
			sWhere = sWhere + " '" + StartDate + "' BETWEEN a.StartDate AND a.EndDate ";
			
			if (Continent.Length > 0)
			{
				sWhere = sWhere + "AND al.Continent = " + "'" + Continent + "' ";
			}

			if (CountryAbbr.Length > 0)
			{
				sWhere = sWhere + "AND al.CountryAbbr = " + "'" + CountryAbbr + "' ";
			}

			if (StateAbbr.Length > 0)
			{
				sWhere = sWhere + "AND al.StateAbbr = " + "'" + StateAbbr + "' ";
			}
			if (Region.Length > 0)
			{
				sWhere = sWhere + "AND al.Region = " + "'" + Region + "' ";	
			}
			if (City.Length > 0)
			{
				sWhere = sWhere + "AND al.City = " + "'" + City + "' ";	
			}


			sWhere = sWhere + "AND a.ActivityLocationID=al.ActivityLocationID ";

			if (Categories.Length > 0)
			{
				CategoryArray = ConvertStringToArray(Categories);
				
				//we could have gotten one or more categories to look up
				for ( int i = 0; i < CategoryArray.Length; i++ )
				{
					//If there is only one or this is the first time through,
					//don't append a comma		
					if (i == 0)
					{
						sIN = sIN + "'" + CategoryArray[i] + "'";
					}
					else {
						sIN = sIN + ", '" + CategoryArray[i] + "'";	
					}
				}
			}

			if (Categories.Length > 0)
			{
				sWhere = sWhere + "AND al.Region IN (select al.Region ";
				sWhere = sWhere + "from ActivityLocation al, Activities a, ActivityCategory ac, Category c where ";
				sWhere = sWhere + "al.ActivityLocationID = a.ActivityLocationID AND a.ActivityID = ac.ActivityID AND ac.CategoryID = c.CategoryID ";
				sWhere = sWhere + "AND c.CategoryType IN ( " + sIN + "))";

			}
			else
			{
				sFrom = sFrom + ", ActivityCategory ac, ";			
				sFrom = sFrom + "Category c " ;

				sWhere = sWhere + "AND a.ActivityID=ac.ActivityID ";
				sWhere = sWhere + "AND ac.CategoryID=c.CategoryID ";				
			}

			sSQL = sSelect + sFrom + sWhere + " ORDER BY al.Region ASC";
			
			adoCon.ConnectionString = "Provider=SQLOLEDB.1;Persist Security Info=False;User ID=sa;Initial Catalog=PointsOfInterest;Data Source=(local);Use Procedure for Prepare=1;Auto Translate=True;Packet Size=4096;Use Encryption for Data=False;Tag with column collation when possible=False";
			POIDSCmd.SelectCommand = new System.Data.ADO.ADOCommand(adoCon, sSQL, System.Data.CommandType.Text, false, new System.Data.ADO.ADOParameter[] {}, System.Data.UpdateRowSource.Both);		
			POIDSCmd.TableMappings.All = new System.Data.Internal.DataTableMapping[] {new System.Data.Internal.DataTableMapping("Table", "ActivityLocation", new System.Data.Internal.DataColumnMapping[] {new System.Data.Internal.DataColumnMapping("ActivityLocationID", "ActivityLocationID"), new System.Data.Internal.DataColumnMapping("LocationName", "LocationName"), new System.Data.Internal.DataColumnMapping("Latitude", "Latitude"), new System.Data.Internal.DataColumnMapping("Longitude", "Longitude"), new System.Data.Internal.DataColumnMapping("Address", "Address"), new System.Data.Internal.DataColumnMapping("PostalCode", "PostalCode"), new System.Data.Internal.DataColumnMapping("City", "City"), new System.Data.Internal.DataColumnMapping("Region", "Region"), new System.Data.Internal.DataColumnMapping("StateAbbr", "StateAbbr"), new System.Data.Internal.DataColumnMapping("CountryAbbr", "CountryAbbr"), new System.Data.Internal.DataColumnMapping("Continent", "Continent")})};

			//Get the data which be stuffed in the DataSet object			
			POIDSCmd.FillDataSet(POIDataSet);
			
			/// <returns>Returns DataSet ActivityLocations and key attractions</returns>
			//Return the data
			return POIDataSet;
			}

		/// <summary>BrowseServices - browses availble services at a given location</summary>	
		/// <param name="ActivityID">Indicates the ActivityID</param>
		[WebMethod]
		public DataSet BrowseServices(long ActivityID) 
		{
			//Given one or many ActivityIDs, return the services that may be
			//provided (i.e., dinner reservations, tee-times, etc.)
			//we are assuming that a location has already been selected, 
			//so the ActivityLocationID is not required.
			
			DataSet ServiceDataSet;
			ADODataSetCommand ServicesDSCmd;
			System.Data.ADO.ADOConnection adoCon;

			ServiceDataSet = new DataSet();
			ServicesDSCmd = new ADODataSetCommand();
			adoCon = new System.Data.ADO.ADOConnection();
			
			string sSQL = "";
			string sSelect = "";
			string sFrom = "";
			string sWhere = "";			
			//string sIN = "";
			
			//make sure they gave us something
			//ActivityIDs.Count > 0 ? sWhere = "" : ThrowException;
						
			//Build the dynamic SQL statement
			//create SQL statement
			sSelect = sSelect + "SELECT DISTINCT ";
			sSelect = sSelect + "ActivityID, ";
			sSelect = sSelect + "ServiceID, ";
			sSelect = sSelect + "Name, ";
			sSelect = sSelect + "Description, ";
			sSelect = sSelect + "Price, ";
			sSelect = sSelect + "StartDate, ";
			sSelect = sSelect + "EndDate ";
			
			sFrom = sFrom + "FROM ";
			sFrom = sFrom + "Service ";
			
			sWhere = sWhere + "WHERE ";			
			sWhere = sWhere + "ActivityID = " + ActivityID + " ";
			
		
			sSQL = sSelect + sFrom + sWhere;
			
			adoCon.ConnectionString = "Provider=SQLOLEDB.1;Persist Security Info=False;User ID=sa;Initial Catalog=PointsOfInterest;Data Source=(local);Use Procedure for Prepare=1;Auto Translate=True;Packet Size=4096;Use Encryption for Data=False;Tag with column collation when possible=False";
			ServicesDSCmd.SelectCommand = new System.Data.ADO.ADOCommand(adoCon, sSQL, System.Data.CommandType.Text, false, new System.Data.ADO.ADOParameter[] {}, System.Data.UpdateRowSource.Both);		
			ServicesDSCmd.TableMappings.All = new System.Data.Internal.DataTableMapping[] {new System.Data.Internal.DataTableMapping("Table", "Service", new System.Data.Internal.DataColumnMapping[] {new System.Data.Internal.DataColumnMapping("ServiceID", "ServiceID"), new System.Data.Internal.DataColumnMapping("ActivityID", "ActivityID"), new System.Data.Internal.DataColumnMapping("Name", "Name"), new System.Data.Internal.DataColumnMapping("Description", "Description"), new System.Data.Internal.DataColumnMapping("Price", "Price"), new System.Data.Internal.DataColumnMapping("StartDate", "StartDate"), new System.Data.Internal.DataColumnMapping("EndDate", "EndDate")})};

			//Get the data which be stuffed in the DataSet object			
			ServicesDSCmd.FillDataSet(ServiceDataSet);

			/// <returns>Returns DataSet of availble services at a given location</returns>			
			//Return the data
			return ServiceDataSet;
		}
		

		/// <summary>BrowseByProximity - browses Activity locations within a certain distance of a given LocationID</summary>	
		/// <param name="StartDate">Indicates StartDate</param>
		/// <param name="EndDate">Indicates EndDate</param>
		/// <param name="LocationID">Indicates the LocationID</param>
		/// <param name="Distance">Indicates the Distance</param>
		/// <param name="Category">Indicates the Category to look up</param>
		[WebMethod]
		public DataSet BrowseByProximity(string StartDate,
								         string EndDate, 
			 						     long LocationID,  
										 long Distance,  
										 string Category) 
		{
		//Given a specific Activity location, get all of the possible
		//activities availabe, matching specific categories if given

			//Declarations
			DataSet ActivityLocationDataSet;
			DataSet TempDataSet;
			DataSet OriginDataSet;
			DataSet ReturnDataSet;
			ADODataSetCommand ActivityLocationDSCmd;
			System.Data.ADO.ADOConnection adoCon;

			double Lat;
			double Lon;
			double StartLat;
			double StartLon;
			string sSQL = "";
			string sSelect = "";
			string sFrom = "";
			string sWhere = "";			
			string sOriginSQL = "";
			double Result;
			
			ActivityLocationDataSet = new DataSet();
			TempDataSet = new DataSet();
			OriginDataSet = new DataSet();
			ReturnDataSet = new DataSet();
			ActivityLocationDSCmd = new ADODataSetCommand();
			adoCon = new System.Data.ADO.ADOConnection();
			
			//create SQL statement
			sSelect = sSelect + "SELECT DISTINCT ";
			sSelect = sSelect + "al.ActivityLocationID, ";			
			sSelect = sSelect + "al.LocationName, ";
			sSelect = sSelect + "al.Latitude, ";
			sSelect = sSelect + "al.Longitude, ";
			sSelect = sSelect + "al.Address, ";
			sSelect = sSelect + "al.PostalCode, ";
			sSelect = sSelect + "al.City, ";
			sSelect = sSelect + "al.Region, ";		
			sSelect = sSelect + "al.Rating, ";		
			sSelect = sSelect + "a.ActivityID, ";
			sSelect = sSelect + "a.Name, ";
			sSelect = sSelect + "a.Description, ";
			sSelect = sSelect + "a.ReservationRequired, ";
			sSelect = sSelect + "a.Price, ";
			sSelect = sSelect + "a.StartDate, ";
			sSelect = sSelect + "a.EndDate, ";
			sSelect = sSelect + "a.KeyAttraction, ";			
			sSelect = sSelect + "a.ServicesOffered, ";
			sSelect = sSelect + "a.RequiredTime, ";
			sSelect = sSelect + "a.LocalInfoDetails, ";		
			sSelect = sSelect + "a.DiningAvailable ";		


			sFrom = sFrom + "FROM ";
			sFrom = sFrom + "ActivityLocation al, ";			
			sFrom = sFrom + "Activities a, ";
			sFrom = sFrom + "ActivityCategory ac, ";
			sFrom = sFrom + "Category c ";
			
			sWhere = sWhere + "WHERE ";
			sWhere = sWhere + " '" + StartDate + "' BETWEEN a.StartDate AND a.EndDate ";

			sWhere = sWhere + "AND al.Region=(Select Region from ActivityLocation where ActivityLocationID = " + LocationID + ") ";

			sWhere = sWhere + "AND a.ActivityLocationID=al.ActivityLocationID ";			
			sWhere = sWhere + "AND a.ActivityID=ac.ActivityID ";
			sWhere = sWhere + "AND ac.CategoryID=c.CategoryID ";					
			sWhere = sWhere + "AND c.CategoryType= " + "'" + Category + "' ";
				
			sSQL = sSelect + sFrom + sWhere;
			
			//PrepSelectADODataSetCommand(OrderDSCmd);			
			adoCon.ConnectionString = "Provider=SQLOLEDB.1;Persist Security Info=False;User ID=sa;Initial Catalog=PointsOfInterest;Data Source=(local);Use Procedure for Prepare=1;Auto Translate=True;Packet Size=4096;Use Encryption for Data=False;Tag with column collation when possible=False";
			ActivityLocationDSCmd.SelectCommand = new System.Data.ADO.ADOCommand(adoCon, sSQL, System.Data.CommandType.Text, false, new System.Data.ADO.ADOParameter[] {}, System.Data.UpdateRowSource.Both);		
			ActivityLocationDSCmd.TableMappings.All = new System.Data.Internal.DataTableMapping[] {new System.Data.Internal.DataTableMapping("Table", "ActivityLocation", new System.Data.Internal.DataColumnMapping[] {new System.Data.Internal.DataColumnMapping("ActivityLocationID", "ActivityLocationID"), new System.Data.Internal.DataColumnMapping("LocationName", "LocationName"), new System.Data.Internal.DataColumnMapping("Latitude", "Latitude"), new System.Data.Internal.DataColumnMapping("Longitude", "Longitude"), new System.Data.Internal.DataColumnMapping("Address", "Address"), new System.Data.Internal.DataColumnMapping("PostalCode", "PostalCode"), new System.Data.Internal.DataColumnMapping("City", "City"), new System.Data.Internal.DataColumnMapping("Region", "Region"), new System.Data.Internal.DataColumnMapping("StateAbbr", "StateAbbr"), new System.Data.Internal.DataColumnMapping("CountryAbbr", "CountryAbbr"), new System.Data.Internal.DataColumnMapping("Continent", "Continent")})};

			ActivityLocationDSCmd.FillDataSet(ActivityLocationDataSet);
			
			
			sOriginSQL = sOriginSQL + "SELECT Latitude, Longitude FROM ActivityLocation WHERE ActivityLocationID = " + LocationID + " ";
			
			ActivityLocationDSCmd.SelectCommand = new System.Data.ADO.ADOCommand(adoCon, sOriginSQL, System.Data.CommandType.Text, false, new System.Data.ADO.ADOParameter[] {}, System.Data.UpdateRowSource.Both);					
			ActivityLocationDSCmd.FillDataSet(OriginDataSet);

			StartLat = System.Convert.ToDouble(OriginDataSet.Tables[0].Rows[0].ItemArray[0]);
			StartLon = System.Convert.ToDouble(OriginDataSet.Tables[0].Rows[0].ItemArray[1]);
			
				//If a Distance value was provided, use it, else, default the value to
				//look for places within 15 miles of starting point
				if (Distance <= 0)
				{
					Distance = 25;
				}
		
			for (int i = 0;i < ActivityLocationDataSet.Tables[0].Rows.Count; i++)
			{
				//Set the temp Latitude to check
				Lat = System.Convert.ToDouble(ActivityLocationDataSet.Tables[0].Rows[i].ItemArray[2]);
				//Set the temp Longitude to check
				Lon = System.Convert.ToDouble(ActivityLocationDataSet.Tables[0].Rows[i].ItemArray[3]);

				
				Result = LatLonDistance(StartLat,StartLon,Lat,Lon);
				if (Result > Distance)
				{
					//this row does not fall within our range, so delete from the 
					//dataset that will be returned					
					ActivityLocationDataSet.Tables[0].Rows.Remove(i);
					//ActivityLocationDataSet.Tables[0].Rows[i].Delete();
				}
			}

			/// <returns>Returns DataSet of a Activity locations within a certain distance of a given LocationID</returns>
			//Return the data
			return ActivityLocationDataSet;
		}

		/// <summary>RefreshCategories - browses all available categories of activities</summary>
		[WebMethod]
		public DataSet RefreshCategories() 
		{
			//this function returns all Category types
			
			DataSet CategoryDataSet;
			ADODataSetCommand CategoryDSCmd;
			System.Data.ADO.ADOConnection adoCon;

			CategoryDataSet = new DataSet();
			CategoryDSCmd = new ADODataSetCommand();
			adoCon = new System.Data.ADO.ADOConnection();
			
			string sSQL = "";
			string sSelect = "";
			string sFrom = "";
									
			//create SQL statement
			sSelect = sSelect + "SELECT ";
			sSelect = sSelect + "CategoryID, ";
			sSelect = sSelect + "CategoryType, ";
			sSelect = sSelect + "Description ";
			
			sFrom = sFrom + "FROM ";
			sFrom = sFrom + "Category";
		
			sSQL = sSelect + sFrom;
			
			adoCon.ConnectionString = "Provider=SQLOLEDB.1;Persist Security Info=False;User ID=sa;Initial Catalog=PointsOfInterest;Data Source=(local);Use Procedure for Prepare=1;Auto Translate=True;Packet Size=4096;Use Encryption for Data=False;Tag with column collation when possible=False";
			CategoryDSCmd.SelectCommand = new System.Data.ADO.ADOCommand(adoCon, sSQL, System.Data.CommandType.Text, false, new System.Data.ADO.ADOParameter[] {}, System.Data.UpdateRowSource.Both);		
			CategoryDSCmd.TableMappings.All = new System.Data.Internal.DataTableMapping[] {new System.Data.Internal.DataTableMapping("Table", "Category", new System.Data.Internal.DataColumnMapping[] {new System.Data.Internal.DataColumnMapping("CategoryID", "CategoryID"), new System.Data.Internal.DataColumnMapping("CategoryType", "CategoryType"), new System.Data.Internal.DataColumnMapping("Description", "Description")})};

			//Get the data which be stuffed in the DataSet object			
			CategoryDSCmd.FillDataSet(CategoryDataSet);

			/// <returns>Returns DataSet of all available categories of activities</returns>
			//Return the data			
			return CategoryDataSet;
	    }				
		
		private string[] ConvertStringToArray(string CategoryString)
		{
			int j;
			int k;
			char PipeChar = '|';		
			char cChar;
			string TempString = "";
			j=0;
			k=0;

			for (int i = 0;i < CategoryString.Length; i++)
			{
				cChar = CategoryString[i];

				if (cChar == PipeChar) 
				{
					j+=1;
				}

			}

			string[] ResultString = new string[j+1];			

			CategoryString+="|";

			for (int i = 0;i < CategoryString.Length; i++)
			{
				cChar = CategoryString[i];
				
				if (cChar == PipeChar) 
				{
					ResultString[k] = TempString;
					TempString="";
					k+=1;
				}
				else
				{
					TempString+=System.Convert.ToString(cChar);
				}

			}			

			return ResultString;
		}

		private double LatLonDistance(double Lat1, double Lon1, double Lat2, double Lon2)
		{
		                          
			long R;         //Radius of Earth = 6367 km = 3956 mi
			double deltaLat;
			double deltaLon;
			double a;
			double c;

			//Set the radius of the earth in the desired units...miles
			R = 3956;

			//Calculate the Deltas...
			deltaLon = AsRadians(Lon2) - AsRadians(Lon1);
			deltaLat = AsRadians(Lat2) - AsRadians(Lat1);

			//Intermediate values...
			a = Sin2(deltaLat / 2) + Math.Cos(AsRadians(Lat1)) * Math.Cos(AsRadians(Lat2)) * Sin2(deltaLon / 2);
			//Cos (AsRadians(pDb_Lat1)) * Cos(AsRadians(pDb_Lat2)) * Sin2(lDb_deltaLon / 2)
			//Cos (AsRadians(pDb_Lat2)) * Sin2(lDb_deltaLon / 2)
			//Sin2 (lDb_deltaLon / 2)
			
			//Intermediate result c is the great circle distance in radians...
			c = 2 * Arcsin(GetMin(1, Math.Sqrt(a)));

			//Multiply the radians by the radius to get the distance in specified units...
			return R * c;

		}

		private double Arcsin(double X)
		{
			//Arcsin(X) = Atn(X / Sqr(-X * X + 1)) [from MS Help - VB4, 1995]
			return Math.Atan(X / Math.Sqrt(-X * X + 1));	
		}

		private double AsRadians(double Degrees)
		{
			//To convert decimal degrees to radians, multiply
			//the number of degrees by pi/180 = 0.017453293 radians/degree
		    return Degrees * (Math.PI / 180);
		}

		private double GetMin(double X, double Y)
		{
		//The min() function protects against possible roundoff errors that
		//could sabotage computation of the arcsine if the two points are
		//very nearly antipodal (that is, on opposide sides of the Earth)
		//                                       - RGC, 1996
		
			double ReturnValue;
			
			//X <= Y ? ReturnValue = X : ReturnValue = Y;	
			
			if (X <=Y)
			{
				 ReturnValue = X;
			}
			else
			{
				 ReturnValue = Y;
			}

			return ReturnValue;
		}

		private double Sin2(double X)
		{
			//sin^2(X) = (1 - cos(2X))/2 [from Greer and Hancox, 1991]
			return (1 - Math.Cos(2 * X)) / 2;
		}	
	}
}
