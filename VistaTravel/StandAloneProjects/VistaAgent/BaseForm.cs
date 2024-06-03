namespace VistaAgent
{
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.WinForms;

/// <summary>
///    Summary description for BaseForm.
/// </summary>
public class BaseForm : System.WinForms.Form
{
    /// <summary> 
    ///    Required designer variable
    /// </summary>
    private System.ComponentModel.Container components;
	private System.WinForms.PictureBox picLogo;
	private System.WinForms.Button cmdCancel;
	private System.WinForms.Button cmdOK;

    public BaseForm()
    {
        //
        // Required for Win Form Designer support
        //
        InitializeComponent();

        //
        // TODO: Add any constructor code after InitializeComponent call
        //

		// Load the Logo Image
		picLogo.Image = new Bitmap("logo.gif");
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
		this.cmdCancel = new System.WinForms.Button();
		this.cmdOK = new System.WinForms.Button();
		this.picLogo = new System.WinForms.PictureBox();
		
		cmdCancel.Location = new System.Drawing.Point(376, 328);
		cmdCancel.Size = new System.Drawing.Size(75, 23);
		cmdCancel.TabIndex = 1;
		cmdCancel.Text = "Cancel";
		
		cmdOK.Location = new System.Drawing.Point(464, 328);
		cmdOK.Size = new System.Drawing.Size(75, 23);
		cmdOK.TabIndex = 0;
		cmdOK.Text = "OK";
		
		this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
		this.Text = "BaseForm";
		//@design this.TrayLargeIcon = true;
		//@design this.TrayHeight = 0;
		this.ClientSize = new System.Drawing.Size(552, 365);
		
		picLogo.Size = new System.Drawing.Size(224, 64);
		picLogo.TabIndex = 2;
		picLogo.TabStop = false;
		picLogo.Text = "pictureBox1";
		
		this.Controls.Add(picLogo);
		this.Controls.Add(cmdCancel);
		this.Controls.Add(cmdOK);
		
	}
}
}
