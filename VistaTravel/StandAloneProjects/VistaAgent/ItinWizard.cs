namespace VistaAgent
{
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.WinForms;

/// <summary>
///    Summary description for ItinWizard.
/// </summary>
public class ItinWizard : System.WinForms.Form
{
    /// <summary> 
    ///    Required designer variable
    /// </summary>
    private System.ComponentModel.Container components;
	private System.WinForms.GroupBox grpStep3;
	
	
	private System.WinForms.TabPage tabPage3;
	private System.WinForms.TabPage tabPage2;
	private System.WinForms.TabPage tabPage1;
	private System.WinForms.TabControl tabDestinations;
	
	private System.WinForms.GroupBox grpStep2;
	private System.WinForms.ComboBox cboMonth;
	private System.WinForms.ComboBox cboDestination;
	private System.WinForms.ComboBox cboDuration;
	private System.WinForms.ComboBox cboPrice;
	private System.WinForms.ComboBox cboWith;
	private System.WinForms.ComboBox cboToDo;
	private System.WinForms.ComboBox cboFrom;
	private System.WinForms.Label label3;
	private System.WinForms.Label label2;
	private System.WinForms.Label label1;
	private System.WinForms.PictureBox pictureBox1;
	private System.WinForms.GroupBox grpWizard;
	private System.WinForms.Button cmdCancel;
	private System.WinForms.Button cmdBack;
	private System.WinForms.Button cmdNext;

	// let's try to add class level vars here
	private int liCurPage;

	// wizard page constants
	private const int WIZARD_PAGE_1 = 1;
	private const int WIZARD_PAGE_2 = 2;
	private const int WIZARD_PAGE_3 = 3;

    public ItinWizard()
    {
        //
        // Required for Win Form Designer support
        //
        InitializeComponent();

        //
        // TODO: Add any constructor code after InitializeComponent call
        //
		//initialize to page 1
		liCurPage = 1;
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
		System.Resources.ResourceManager resources = new System.Resources.ResourceManager("ItinWizard", typeof(ItinWizard), null, true);
		
		this.components = new System.ComponentModel.Container();
		this.tabPage3 = new System.WinForms.TabPage();
		this.tabPage1 = new System.WinForms.TabPage();
		this.tabPage2 = new System.WinForms.TabPage();
		this.cmdCancel = new System.WinForms.Button();
		this.cmdBack = new System.WinForms.Button();
		this.grpStep3 = new System.WinForms.GroupBox();
		this.cboMonth = new System.WinForms.ComboBox();
		this.cboWith = new System.WinForms.ComboBox();
		this.tabDestinations = new System.WinForms.TabControl();
		this.cboDuration = new System.WinForms.ComboBox();
		this.cboPrice = new System.WinForms.ComboBox();
		this.cboToDo = new System.WinForms.ComboBox();
		this.cmdNext = new System.WinForms.Button();
		this.cboFrom = new System.WinForms.ComboBox();
		this.grpWizard = new System.WinForms.GroupBox();
		this.pictureBox1 = new System.WinForms.PictureBox();
		this.grpStep2 = new System.WinForms.GroupBox();
		this.cboDestination = new System.WinForms.ComboBox();
		this.label3 = new System.WinForms.Label();
		this.label1 = new System.WinForms.Label();
		this.label2 = new System.WinForms.Label();
		
		tabPage3.Text = "Hike the Grand Canyon";
		tabPage3.Size = new System.Drawing.Size(516, 207);
		tabPage3.TabIndex = 2;
		
		tabPage1.Text = "Cabo San Lucas";
		tabPage1.Size = new System.Drawing.Size(516, 207);
		tabPage1.TabIndex = 0;
		
		tabPage2.Text = "Ski Tahoe";
		tabPage2.Size = new System.Drawing.Size(516, 207);
		tabPage2.TabIndex = 1;
		
		cmdCancel.Location = new System.Drawing.Point(284, 332);
		cmdCancel.Size = new System.Drawing.Size(75, 23);
		cmdCancel.TabIndex = 2;
		cmdCancel.Text = "Cancel";
		
		cmdBack.Location = new System.Drawing.Point(392, 332);
		cmdBack.Size = new System.Drawing.Size(75, 23);
		cmdBack.TabIndex = 1;
		cmdBack.Text = "Back";
		
		grpStep3.Location = new System.Drawing.Point(4, 56);
		grpStep3.TabIndex = 0;
		grpStep3.TabStop = false;
		grpStep3.Text = "Step 3 - Finalize the Itinerary";
		grpStep3.Size = new System.Drawing.Size(540, 268);
		
		cboMonth.Location = new System.Drawing.Point(40, 176);
		cboMonth.Text = "";
		cboMonth.Size = new System.Drawing.Size(152, 21);
		cboMonth.Style = System.WinForms.ComboBoxStyle.DropDownList;
		cboMonth.TabIndex = 9;
		
		this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
		this.Text = "Vista Itinerary Wizard";
		//@design this.TrayLargeIcon = true;
		//@design this.TrayHeight = 0;
		this.ClientSize = new System.Drawing.Size(552, 361);
		//@design this.GridSize = new System.Drawing.Size(4, 4);
		
		cboWith.Text = "";
		cboWith.Location = new System.Drawing.Point(220, 100);
		cboWith.Size = new System.Drawing.Size(184, 21);
		cboWith.Style = System.WinForms.ComboBoxStyle.DropDownList;
		cboWith.TabIndex = 5;
		
		tabDestinations.Location = new System.Drawing.Point(8, 24);
		tabDestinations.Text = "tabControl1";
		tabDestinations.Size = new System.Drawing.Size(524, 236);
		tabDestinations.SelectedIndex = 0;
		tabDestinations.TabIndex = 0;
		
		cboDuration.Text = "";
		cboDuration.Location = new System.Drawing.Point(220, 176);
		cboDuration.Size = new System.Drawing.Size(152, 21);
		cboDuration.Style = System.WinForms.ComboBoxStyle.DropDownList;
		cboDuration.TabIndex = 7;
		
		cboPrice.Text = "";
		cboPrice.Location = new System.Drawing.Point(220, 140);
		cboPrice.Size = new System.Drawing.Size(152, 21);
		cboPrice.Style = System.WinForms.ComboBoxStyle.DropDownList;
		cboPrice.TabIndex = 6;
		
		cboToDo.Text = "";
		cboToDo.Location = new System.Drawing.Point(220, 64);
		cboToDo.Size = new System.Drawing.Size(184, 21);
		cboToDo.Style = System.WinForms.ComboBoxStyle.DropDownList;
		cboToDo.TabIndex = 4;
		
		cmdNext.Location = new System.Drawing.Point(468, 332);
		cmdNext.Size = new System.Drawing.Size(75, 23);
		cmdNext.TabIndex = 0;
		cmdNext.Text = "Next";
		cmdNext.AddOnClick(new System.EventHandler(cmdNext_Click));
		
		cboFrom.Text = "";
		cboFrom.Location = new System.Drawing.Point(220, 28);
		cboFrom.Size = new System.Drawing.Size(184, 21);
		cboFrom.Style = System.WinForms.ComboBoxStyle.DropDownList;
		cboFrom.TabIndex = 3;
		
		//@design grpWizard.GridSize = new System.Drawing.Size(4, 4);
		grpWizard.Location = new System.Drawing.Point(8, 56);
		grpWizard.TabIndex = 3;
		grpWizard.TabStop = false;
		grpWizard.Text = "Step 1";
		grpWizard.Size = new System.Drawing.Size(536, 268);
		
		pictureBox1.Location = new System.Drawing.Point(-4, 0);
		pictureBox1.Size = new System.Drawing.Size(220, 56);
		pictureBox1.TabIndex = 4;
		pictureBox1.TabStop = false;
		pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		pictureBox1.Text = "pictureBox1";
		
		//@design grpStep2.GridSize = new System.Drawing.Size(4, 4);
		grpStep2.Location = new System.Drawing.Point(4, 56);
		grpStep2.TabIndex = 5;
		grpStep2.TabStop = false;
		grpStep2.Text = "Step 2 - Choose a Destination";
		grpStep2.Size = new System.Drawing.Size(540, 268);
		
		cboDestination.Text = "";
		cboDestination.Location = new System.Drawing.Point(40, 140);
		cboDestination.Size = new System.Drawing.Size(152, 21);
		cboDestination.Style = System.WinForms.ComboBoxStyle.DropDownList;
		cboDestination.TabIndex = 8;
		
		label3.Location = new System.Drawing.Point(36, 108);
		label3.Text = "Who are they escaping with?";
		label3.Size = new System.Drawing.Size(168, 12);
		label3.TabIndex = 2;
		
		label1.Location = new System.Drawing.Point(32, 36);
		label1.Text = "What\'s the client escaping from?";
		label1.Size = new System.Drawing.Size(168, 12);
		label1.TabIndex = 0;
		
		label2.Location = new System.Drawing.Point(32, 72);
		label2.Text = "What\'s the client escaping to do?";
		label2.Size = new System.Drawing.Size(172, 12);
		label2.TabIndex = 1;
		
		grpWizard.Controls.Add(cboMonth);
		grpWizard.Controls.Add(cboDestination);
		grpWizard.Controls.Add(cboDuration);
		grpWizard.Controls.Add(cboPrice);
		grpWizard.Controls.Add(cboWith);
		grpWizard.Controls.Add(cboToDo);
		grpWizard.Controls.Add(cboFrom);
		grpWizard.Controls.Add(label3);
		grpWizard.Controls.Add(label2);
		grpWizard.Controls.Add(label1);
		grpStep2.Controls.Add(tabDestinations);
		tabDestinations.Controls.Add(tabPage1);
		tabDestinations.Controls.Add(tabPage2);
		tabDestinations.Controls.Add(tabPage3);
		this.Controls.Add(grpWizard);
		this.Controls.Add(grpStep3);
		this.Controls.Add(grpStep2);
		this.Controls.Add(pictureBox1);
		this.Controls.Add(cmdCancel);
		this.Controls.Add(cmdBack);
		this.Controls.Add(cmdNext);
		
	}
	protected void cmdNext_Click(object sender, System.EventArgs e)
	{
		//Move to the next wizard page
		switch (liCurPage) {
			case WIZARD_PAGE_1:
				//shouldn't get here
				break;
			case WIZARD_PAGE_2:
				grpStep2.Visible = true;
				grpWizard.Visible = false;
				break;
			case WIZARD_PAGE_3:
				grpStep3.Visible = true;
				grpStep2.Visible = false;
				break;
			default:
				// should throw an error
				break;
		} //end switch

	}
}
}
