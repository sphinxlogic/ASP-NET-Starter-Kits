namespace VistaAgent
{
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.WinForms;
using System.Data;

/// <summary>
///    Summary description for Form1.
/// </summary>
public class frmMain : System.WinForms.Form
{
    /// <summary> 
    ///    Required designer variable
    /// </summary>
    private System.ComponentModel.Container components;
	
	private System.WinForms.DataGrid grdItin;
	
	
	
	
	
	private System.WinForms.TreeView tvwClients;
	private System.WinForms.StatusBar stsMain;
	private System.WinForms.MenuItem mnuHelpAbout;
	private System.WinForms.MenuItem mnuHelp;
	private System.WinForms.MenuItem mnuView;
	private System.WinForms.MenuItem mnuFileItin;
	private System.WinForms.MenuItem mnuFileClient;
	private System.WinForms.MenuItem menuItem1;
	private System.WinForms.MenuItem mnuFileExit;
	private System.WinForms.MenuItem mnuFileNew;
	private System.WinForms.MenuItem mnuFile;
	private System.WinForms.MainMenu mnuMain;

    public frmMain()
    {
        //
        // Required for Win Form Designer support
        //
        InitializeComponent();

        //
        // TODO: Add any constructor code after InitializeComponent call
        //
		// Load the members
		VistaSiteMgr.Member objMember;
		System.Data.DataSet dsMember;
		System.WinForms.TreeNode objNode;
		System.WinForms.TreeNode objChild;
		objNode = new System.WinForms.TreeNode();
		objChild = new System.WinForms.TreeNode();
		int i = 0;

		objMember = new VistaSiteMgr.Member();

		dsMember = objMember.BrowseMembers();
		tvwClients.Nodes.Clear();
		// Add the parent node back in
		objNode.Text = "Current Clients";
		tvwClients.Nodes.Add(0, objNode);
		while ( i < dsMember.Tables[0].Rows.Count ) {
			objChild.Text = System.Convert.ToString(dsMember.Tables[0].Rows[i].ItemArray[2]);
			// objChild.Index = System.Convert.ToInt16(dsMember.Tables[0].Rows[i].ItemArray[0]);
			objNode.Nodes.Add(objChild);
			i++;
		}
    }

    /// <summary>
    ///    Clean up any resources being used
    /// </summary>
    public override void Dispose()
    {
        base.Dispose();
        components.Dispose();
    }

    /// <summary>
    ///    Required method for Designer support - do not modify
    ///    the contents of this method with the code editor
    /// </summary>
    private void InitializeComponent()
	{
		this.components = new System.ComponentModel.Container();
		this.mnuHelpAbout = new System.WinForms.MenuItem();
		this.tvwClients = new System.WinForms.TreeView();
		this.stsMain = new System.WinForms.StatusBar();
		this.mnuView = new System.WinForms.MenuItem();
		this.mnuFileNew = new System.WinForms.MenuItem();
		this.mnuFile = new System.WinForms.MenuItem();
		this.grdItin = new System.WinForms.DataGrid();
		this.menuItem1 = new System.WinForms.MenuItem();
		this.mnuFileItin = new System.WinForms.MenuItem();
		this.mnuFileClient = new System.WinForms.MenuItem();
		this.mnuHelp = new System.WinForms.MenuItem();
		this.mnuFileExit = new System.WinForms.MenuItem();
		this.mnuMain = new System.WinForms.MainMenu();
		
		grdItin.BeginInit();
		
		mnuHelpAbout.Text = "&About Vista Agent";
		mnuHelpAbout.Index = 0;
		
		tvwClients.Location = new System.Drawing.Point(4, 8);
		tvwClients.Text = "treeView1";
		tvwClients.Size = new System.Drawing.Size(184, 352);
		tvwClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 11f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
		tvwClients.TabIndex = 1;
		tvwClients.AddOnAfterSelect(new System.WinForms.TreeViewEventHandler(tvwClients_AfterSelect));
		tvwClients.Nodes.All = new System.WinForms.TreeNode[] {new System.WinForms.TreeNode("Existing Clients", new System.WinForms.TreeNode[] {new System.WinForms.TreeNode("Dave Mendlen"),
			new System.WinForms.TreeNode("Jay Schmelzer")})};
		
		stsMain.BackColor = System.Drawing.SystemColors.Control;
		stsMain.Location = new System.Drawing.Point(0, 361);
		stsMain.Size = new System.Drawing.Size(720, 20);
		stsMain.TabIndex = 0;
		stsMain.Text = "Ready.";
		
		mnuView.Text = "&View";
		mnuView.Index = 1;
		
		mnuFileNew.Text = "&New";
		mnuFileNew.Index = 0;
		mnuFileNew.MenuItems.All = new System.WinForms.MenuItem[] {mnuFileClient,
			mnuFileItin};
		
		mnuFile.Text = "&File";
		mnuFile.Index = 0;
		mnuFile.MenuItems.All = new System.WinForms.MenuItem[] {mnuFileNew,
			menuItem1,
			mnuFileExit};
		
		grdItin.Location = new System.Drawing.Point(192, 8);
		grdItin.ReadOnly = true;
		grdItin.CaptionVisible = false;
		grdItin.Size = new System.Drawing.Size(524, 352);
		grdItin.PreferredColumnWidth = 50;
		grdItin.DataMember = "";
		grdItin.NavigationMode = System.WinForms.DataGridNavigationModes.None;
		grdItin.ForeColor = System.Drawing.SystemColors.WindowText;
		grdItin.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
		grdItin.TabIndex = 2;
		grdItin.BackColor = System.Drawing.SystemColors.Window;
		grdItin.RowHeadersVisible = false;
		grdItin.AddOnDoubleClick(new System.EventHandler(grdItin_DoubleClick));
		grdItin.GridTables.All = new System.WinForms.DataGridTable[] {};
		
		menuItem1.Text = "-";
		menuItem1.Index = 1;
		
		mnuFileItin.Text = "Itinerary";
		mnuFileItin.Index = 1;
		mnuFileItin.AddOnClick(new System.EventHandler(mnuFileItin_Click));
		
		mnuFileClient.Text = "Client";
		mnuFileClient.Index = 0;
		mnuFileClient.AddOnClick(new System.EventHandler(mnuFileClient_Click));
		
		mnuHelp.Text = "&Help";
		mnuHelp.Index = 2;
		mnuHelp.MenuItems.All = new System.WinForms.MenuItem[] {mnuHelpAbout};
		
		mnuFileExit.Text = "E&xit";
		mnuFileExit.Index = 2;
		
		//@design mnuMain.SetLocation(new System.Drawing.Point(7, 7));
		mnuMain.MenuItems.All = new System.WinForms.MenuItem[] {mnuFile,
			mnuView,
			mnuHelp};
		
		this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
		this.Text = "Vista Agent";
		this.MaximizeBox = false;
		//@design this.TrayLargeIcon = true;
		//@design this.TrayHeight = 93;
		this.Menu = mnuMain;
		this.ClientSize = new System.Drawing.Size(720, 381);
		//@design this.GridSize = new System.Drawing.Size(4, 4);
		
		this.Controls.Add(grdItin);
		this.Controls.Add(tvwClients);
		this.Controls.Add(stsMain);
		
		grdItin.EndInit();
	}
	protected void mnuFileClient_Click(object sender, System.EventArgs e)
	{
		// Display the Not Implemented dialog
		DisplayNotImplemented();
	}
	protected void grdItin_DoubleClick(object sender, System.EventArgs e)
	{
		// TODO: Still need to figure out how to grab a value from the grid

		// Display the detail for this item
		VistaAgent.ItinDetail frmDetail;

		frmDetail = new VistaAgent.ItinDetail();
		frmDetail.Show();
		frmDetail.LoadDetail(425);
		
	}
	protected void mnuFileItin_Click(object sender, System.EventArgs e)
	{
		// Start the Itinerary Wizard
		VistaAgent.ItinWizard frmWiz;
		frmWiz = new ItinWizard();

		frmWiz.Show();
	}
	protected void tvwClients_AfterSelect(object sender, System.WinForms.TreeViewEventArgs e)
	{
		// Load the Itineraries for the selected client
		System.Data.DataSet dsItin;
		VistaSiteMgr.Itinerary objItin;

		// make sure this is a valid node
		if (e.node.Text == "Miller") {
			// Grab the Itineraries for this client
			objItin = new VistaSiteMgr.Itinerary();
			dsItin = objItin.BrowseByMember(1);
			
			// Get rid of what we don't want
			// dvItin = dsItin.DefaultView;
			dsItin.Tables[0].Columns.Remove("MemberID");
			dsItin.Tables[0].Columns.Remove("NumberOfPeople");
			dsItin.Tables[0].Columns.Remove("Children");
			dsItin.Tables[0].Columns.Remove("TravelOccassion");

			// Bind it to the grid
			grdItin.DataSource = dsItin.Tables[0];
		}
	}
	protected void DisplayNotImplemented()
	{
		// Display a message box 
		System.WinForms.MessageBox.Show("Feature Not Implemented.", "Vista Agent");
	}

    /*
     * The main entry point for the application.
     *
     */
    public static void Main(string[] args) 
    {
        Application.Run(new frmMain());
    }
}
}
