namespace VistaAgent
{
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.WinForms;

/// <summary>
///    Summary description for Profile.
/// </summary>
public class Profile : VistaAgent.BaseForm
{
    /// <summary> 
    ///    Required designer variable
    /// </summary>
    private System.ComponentModel.Container components;

    public Profile()
    {
        //
        // Required for Win Form Designer support
        //
        InitializeComponent();

        //
        // TODO: Add any constructor code after InitializeComponent call
        //
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
		
		
		
		this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
		this.Text = "Profile";
		this.MaximizeBox = false;
		//@design this.TrayLargeIcon = true;
		this.BorderStyle = System.WinForms.FormBorderStyle.FixedSingle;
		//@design this.TrayHeight = 0;
		
		
		
	}
}
}
