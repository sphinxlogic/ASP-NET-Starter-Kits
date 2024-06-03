namespace VistaAgent
{
    using System;
    using System.Collections;
    using System.Core;
    using System.ComponentModel;
    using System.Drawing;
    
    using System.WinForms;
    
    
    public class ItinDetail : VistaAgent.BaseForm
    {
    
        private System.ComponentModel.IContainer components;
		private System.WinForms.DataGrid grdDetail;

        public ItinDetail()
        {
	        // This call is required by the WinForm Designer.
	        InitializeComponent();

	        // TODO: Add any initialization after the InitializeComponent call
        }

        // Form overrides dispose to clean up the component list.
        public override void Dispose()
        {
	        base.Dispose();
	        components.Dispose();
        }

        // NOTE: The following procedure is required by the WinForm Designer
        // It can be modified using the WinForm Designer.  
        // Do not modify it using the code editor.
        private void InitializeComponent()
	{
		this.components = new System.ComponentModel.Container();
		this.grdDetail = new System.WinForms.DataGrid();
		
		grdDetail.BeginInit();
		
		
		grdDetail.Location = new System.Drawing.Point(8, 72);
		grdDetail.Size = new System.Drawing.Size(536, 248);
		grdDetail.PreferredColumnWidth = 50;
		grdDetail.DataMember = "";
		grdDetail.ForeColor = System.Drawing.SystemColors.WindowText;
		grdDetail.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
		grdDetail.TabIndex = 3;
		grdDetail.BackColor = System.Drawing.SystemColors.Window;
		grdDetail.GridTables.All = new System.WinForms.DataGridTable[] {};
		
		
		
		this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
		this.Text = "ItinDetail";
		//@design this.TrayLargeIcon = true;
		//@design this.TrayHeight = 0;
		//this.AddOnClick(new System.EventHandler(ItinDetail_Click));
		
		this.Controls.Add(grdDetail);
		
		grdDetail.EndInit();
	}

	public void LoadDetail(int ItineraryID)
	{
		// Load the daily detail 
		VistaSiteMgr.Itinerary objItin;
		System.Data.DataSet dsDetail;

		// Update the form Caption
		this.Text = "Daily Detail for ItineraryID - " + ItineraryID;

		// Create an instance of the component
		objItin = new VistaSiteMgr.Itinerary();

		// Load the data
		dsDetail = objItin.Retrieve(ItineraryID);

		// Kill the columns we don't need
		dsDetail.Tables[0].Columns.Remove("ConfirmationNumber");
		dsDetail.Tables[0].Columns.Remove("Quantity");
		dsDetail.Tables[0].Columns.Remove("PricePerItem");
		dsDetail.Tables[0].Columns.Remove("EndDate");
		dsDetail.Tables[0].Columns.Remove("ProviderType");
		dsDetail.Tables[0].Columns.Remove("ProviderID");
		dsDetail.Tables[0].Columns.Remove("ItemID");

		// Bind the grid to the DataSet
		grdDetail.DataSource = dsDetail.Tables[0];
		grdDetail.GridColumns.Remove(0);
		grdDetail.GridColumns.Remove(0);
	}
    }
}

