<%@ Page Language="vb" Codebehind="Profile.vb" Inherits="VistaVacations.Profile"%>
<HTML><HEAD>
    <meta name="GENERATOR" content="Microsoft Visual Studio 7.0">
    <meta name="CODE_LANGUAGE" content="Visual Basic 7.0"></HEAD>
  <body link="#3399cc">

    <form id="Profile" method="post" runat="server">

<table cellSpacing=0 cellPadding=0 width="100%" border=0>
  <tr>
    <td rowSpan=2><IMG height=52 alt="" src="img/logo.gif" width=217 border=0 ></td>
    <td align=right><font 
      face="Verdana, Arial, Helvetica" size=1><A id=blue1 href="About.aspx" >About Us</A> · <A id=blue2 href="NotImplemented.aspx" >Privacy 
      Statement</A> · <A id=blue href="NotImplemented.aspx" >Customer Care</A></font>&nbsp;&nbsp;</td></tr>
  <tr>
    <td align=right><font 
      face="Verdana, Arial, Helvetica" size=1><b 
      >&nbsp;</b></font></td></tr></table><!-- top menu bar -->
<table cellSpacing=0 width="100%" bgColor=#3399cc border=0 
  >
  <tr>
    <td align=right><font 
      face="Verdana, Arial, Helvetica" color=#ffffff size=2 
      >&nbsp;&nbsp;<b><A id=wht1 href="NotImplemented.aspx" ><font 
      color=#ffffff 
      >Flights</font></A></b>&nbsp;&nbsp;|&nbsp;&nbsp;<b 
      ><A id=wht2 href="NotImplemented.aspx" ><font color=#ffffff 
      >Hotels</font></A></b>&nbsp;&nbsp;|&nbsp;&nbsp;<b 
      ><A id=wht3 href="NotImplemented.aspx" ><font color=#ffffff>Ground 
      Travel</font></A></b>&nbsp;&nbsp;|&nbsp;&nbsp;<b><A id=wht4 href="NotImplemented.aspx" ><font 
      color=#ffffff>Dining &amp; 
      Activities</font></A></b>&nbsp;&nbsp;|&nbsp;&nbsp;<b 
      ><A id=wht5 href="NotImplemented.aspx" ><font color=#ffffff 
      >Deals</font></A></b>&nbsp;&nbsp;|&nbsp;&nbsp; <input 
      type=text size=12 value=Search name=searchbox> <input 
      type=image src="img/gobutton.gif" align=absMiddle 
      >&nbsp;</font></td></tr></table><!-- left and content -->
<table cellSpacing=0 cellPadding=0 width="100%" border=0>
  <TBODY>
  <tr>
    <td vAlign=top width=145 bgColor=#006699 
    style="WIDTH: 145px"><IMG height=210 alt="" src="img/leftpic.jpg" width=150 border=0 style="WIDTH: 142px; HEIGHT: 210px"><!-- left side -->&nbsp; 
      
		<font face="Verdana, Arial, Helvetica" size="1" color="#ffffff">
		<br>
			<table border="0" width="130" cellspacing="5" cellpadding="0">
				<tr>
					<td><font face="Verdana, Arial, Helvetica" size="1" color="#ffcc66"><b>John Doe</b></font></td>
				</tr>
				<tr>
					<td><a href="profile.aspx"><font face="Verdana, Arial, Helvetica" size="1" color="#ffffff">Edit your profile</font></a></td>
				</tr>
			</table><br><br>
			<table border="0" width="130" cellspacing="5" cellpadding="0">
				<tr>
					<td colspan="2"><font face="Verdana, Arial, Helvetica" size="1" color="#ffcc66"><b>Airfare Deals</b></font></td>
				</tr>
				<tr>
					<td height="1" bgcolor="#000000" colspan="2"><img src="img/spacer.gif" width=1 height=1 border=0 alt=""></td>
				</tr>
				<tr>
					<td><font face="Verdana, Arial, Helvetica" size="1" color="#ffffff"><b>ORD - LAX</b></font></td>
					<td><font face="Verdana, Arial, Helvetica" size="1" color="#ffffff"><b>$235</b></font></td>
				</tr>
				<tr>
					<td><font face="Verdana, Arial, Helvetica" size="1" color="#ffffff"><b>DFW - NYL</b></font></td>
					<td><font face="Verdana, Arial, Helvetica" size="1" color="#ffffff"><b>$346</b></font></td>
				</tr>
				<tr>
					<td><font face="Verdana, Arial, Helvetica" size="1" color="#ffffff"><b>MDW - JHY</b></font></td>
					<td><font face="Verdana, Arial, Helvetica" size="1" color="#ffffff"><b>$768</b></font></td>
				</tr>
			</table>
			<br><br>
			
		<form method="get" action="weather.asp">
		<table border="0" width="130" cellspacing="5" cellpadding="0">
			<tr>
				<td colspan="2"><font face="Verdana, Arial, Helvetica" size="1" color="#ffcc66"><b>Check the Weather</b></font>
				</td>
			</tr>
			<tr>
			<td colspan="2" height="1" bgcolor="#000000"><img src="img/spacer.gif" width=1 height=1 border=0 alt=""></td>
			</tr>
			<tr>
				<td align="right"><font face="Verdana, Arial, Helvetica" size="1" color="#ffffff"><b>City:</b></font></td>
				<td><input type="text" name="city" size="12" style="FONT-SIZE:7pt;BACKGROUND:#ffffff;COLOR:#000000;FONT-FAMILY:Verdana,Arial"></td>
			</tr>
			<tr>
				<td align="right"><font face="Verdana, Arial, Helvetica" size="1" color="#ffffff"><b>Zip:</b></font></td>
				<td><input type="text" name="zip" size="7" style="FONT-SIZE:7pt;BACKGROUND:#ffffff;COLOR:#000000;FONT-FAMILY:Verdana,Arial"> <input type="image" src="img/gobutton.gif" align="absMiddle"></td>
			</tr>
		</table>
		</form>
		
</font>
		</td>
		<td valign="top" align="middle"><!-- content  -->
		<form method="post" action="confirmation.aspx">
		<br>
			<table border="0" width="95%" cellspacing="0" cellpadding="0">
				<tr>
					<td height="16"><img src="img/editprofile.gif" width=128 height=16 border=0 alt=""></td>
				</tr>
				<tr>
					<td height="1" bgcolor="#000000"><img src="img/spacer.gif" width=1 height=1 border=0 alt=""></td>
				</tr>
			</table><img src="img/spacer.gif" width=1 height=5 border=0 alt=""><br>
			<table border="0" width="95%" cellspacing="0" cellpadding="0">
				<tr>
					<td align="middle" valign="top"><font face="Verdana, Arial, Helvetica" size="1"><a href="#personalinfo">Personal<br>Info</a></font><br></td>
					<td align="middle">|</td>
					<td align="middle" valign="top"><font face="Verdana, Arial, Helvetica" size="1"><a href="#airlineprefs">Airline<br>Preferences</a></font></td>
					<td align="middle">|</td>
					<td align="middle" valign="top"><font face="Verdana, Arial, Helvetica" size="1"><a href="#activityprefs">Activity<br>Preferences</a></font></td>
					<td align="middle">|</td>
					<td align="middle" valign="top"><font face="Verdana, Arial, Helvetica" size="1"><a href="#hotelprefs">Hotel<br>Preferences</a></font></td>
					<td align="middle">|</td>
					<td align="middle" valign="top"><font face="Verdana, Arial, Helvetica" size="1"><a href="#paymentprefs">Payment<br>Preferences</a></font></td>
					<td align="middle">|</td>
					<td align="middle" valign="top"><font face="Verdana, Arial, Helvetica" size="1"><a href="#carprefs">Car Rental<br>Preferences</a></font></td>
				</tr>
			</table>
			<table border="0" width="95%" cellspacing="0" cellpadding="0">
				<img src="img/spacer.gif" width=1 height=5 border=0 alt=""><br>
				<tr>
					<td height="1" bgcolor="#000000"><img src="img/spacer.gif" width=1 height=1 border=0 alt=""></td>
				</tr>
			</table><a name="personalinfo"></a>
			<table border="0" width="95%" cellspacing="0" cellpadding="0">
        <TBODY>
				<tr>
					<td><font face="Arial, Helvetica" size="2"><img src="img/spacer.gif" width=1 height=5 border=0 alt=""><br>
					<b>Personal Information</b><br><br></font>
					</td>
					<td valign="top" rowspan="12" align="middle"><br><input type="submit" value="Submit changes" style="FONT-SIZE:7pt;BACKGROUND:#cccccc;COLOR:#000000;FONT-FAMILY:verdana" onClick="alert('Your changes have been saved')"><br>
<input type="button" value="Cancel" style="FONT-SIZE:7pt;BACKGROUND:#cccccc;COLOR:#000000;FONT-FAMILY:verdana">
					</td>
				</tr>
				<tr>
					<td><font face="Arial, Helvetica" size="2">
			First Name:&nbsp;&nbsp;<asp:TextBox id=txtFirstName runat="SERVER" Width="131" Height="21" CssClass="ProfileTextbox"></asp:TextBox>&nbsp;&nbsp;&nbsp;Last 
            Name: <asp:TextBox id=txtLastName runat="SERVER" CssClass="ProfileTextbox"></asp:TextBox><br><br></font></td>
				</tr>
				<tr>
					<td><font face="Arial, Helvetica" size="2">
					<i>Mailing Address</i><br></font></td>
				<tr>
					<td>
						<table border="0" style="WIDTH: 230px; HEIGHT: 184px">
              <TBODY>
							<tr>
								<td style="WIDTH: 57px" colSpan=2><font face="Arial, Helvetica" size="2">Street 1:</font></td>
								<td colSpan=2><asp:TextBox id=txtStreet1 runat="SERVER" CssClass="ProfileTextBox"></asp:TextBox></td>
					</td>
							</tr>
							<tr>
								<td style="WIDTH: 57px" colSpan=2><font face="Arial, Helvetica" size="2">Street 2:</font></td>
								<td colSpan=2><asp:TextBox id=txtStreet2 runat="SERVER" CssClass="ProfileTextBox"></asp:TextBox></td>
					</td>
							</tr>
							<tr>
								<td style="WIDTH: 57px" colSpan=2><font face="Arial, Helvetica" size="2">City:</font></td>
								<td colSpan=2><asp:TextBox id=txtCity runat="SERVER" CssClass="ProfileTextBox"></asp:TextBox></td></TD>
							</tr>
							<tr>
								<td colSpan=2 style="WIDTH: 57px"><font face="Arial, Helvetica" size="2">State:</font></td>
								<td style="WIDTH: 34px"><font face="Arial, Helvetica" size="2"><asp:TextBox id=txtState runat="SERVER" Width="46" Height="24"></asp:TextBox></font></td></TD>
							</tr>
              <tr>
                <td colSpan=2>Zip:&nbsp;&nbsp;</td>
                <td><asp:TextBox id=txtZip runat="SERVER" Height="23" Width="154"></asp:TextBox></td></tr>
              <tr>
                <td colSpan=2 style="WIDTH: 57px">Country:</td>
                <td style="WIDTH: 34px"><asp:TextBox id=txtCountry runat="SERVER" CssClass="ProfileTextBox"></asp:TextBox></td></tr></TBODY>
						</table><br></TD>
				<tr>
					<td><font face="Arial, Helvetica" size="2">
					<i>Billing Address</i>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:CheckBox id=chkSameasMailing runat="SERVER" Checked="True" Text="Same as mailing address"></asp:CheckBox></font></td>
				<tr>
					<td>
						<table border="0">
              <TBODY>
							<tr>
								<td><font face="Arial, Helvetica" size="2">Street 1:</font></td>
								<td colSpan=2><asp:TextBox id=txtBillStreet1 runat="SERVER"></asp:TextBox></td>
					</td>
							</tr>
							<tr>
								<td><font face="Arial, Helvetica" size="2">Street 2:</font></td>
								<td colSpan=2><asp:TextBox id=txtBillStreet2 runat="SERVER"></asp:TextBox></td></TD>
							</tr>
							<tr>
								<td><font face="Arial, Helvetica" size="2">City:</font></td>
								<td colSpan=2><asp:TextBox id=txtBillCity runat="SERVER"></asp:TextBox></td></TD>
							</tr>
							<tr>
								<td><font face="Arial, Helvetica" size="2">State:</font></td>
								<td style="WIDTH: 37px"><font face="Arial, Helvetica" size="2"><asp:TextBox id=txtBillState runat="SERVER" Height="24" Width="47"></asp:TextBox></font></td></TD>
							</tr>
              <tr>
                <td>Zip:</td>
                <td><asp:TextBox id=txtBillZip runat="SERVER" Height="26" Width="154"></asp:TextBox></td></tr>
              <tr>
                <td>Country:&nbsp; </td>
                <td><asp:TextBox id=txtBillCountry runat="SERVER" CssClass="ProfileTextBox"></asp:TextBox></td></tr></TBODY></TABLE></TD>
				</tr></TBODY></TABLE>
			
			<table border="0" width="95%" cellspacing="0" cellpadding="0">
				<img src="img/spacer.gif" width=1 height=5 border=0 alt=""><br>
				<tr>
					<td height="1" bgcolor="#000000"><img src="img/spacer.gif" width=1 height=1 border=0 alt=""></td>
				</tr>
			</table><a name="airlineprefs"></a>
			<table border="0" width="95%" cellspacing="0" cellpadding="0">
				<tr>
					<td><font face="Arial, Helvetica" size="2"><img src="img/spacer.gif" width=1 height=5 border=0 alt=""><br>
					<b>Airline Preferences</b><br><br></font>
					</td>
				</tr>
				<tr>
					<td><font face="Arial, Helvetica" size="2">
					<i>Please enter your frequent flyer information</i><br></font>
					</td>
				</tr>
				<tr>
					<td>
						<table border="0">
              <TBODY>
							<tr>
								<td><font face="Arial, Helvetica" size="2">&nbsp;</font></td>
								<td valign="bottom"><font face="Arial, Helvetica" size="2">Airline(s)</font></td>
								<td valign="bottom"><font face="Arial, Helvetica" size="2">Number(s)</font></td>
								<td valign="bottom"><font face="Arial, Helvetica" size="2">Only show me flights on this airline</font></td>
							</tr>
							<tr>
								<td><font face="Arial, Helvetica" size="2">1:</font></td>
								<td>&nbsp;<asp:TextBox id=txtAirline1 runat="SERVER"></asp:TextBox>
								</td>
								<td>&nbsp;<asp:TextBox id=txtAirline1Num runat="SERVER"></asp:TextBox>
					</td>
					</td>
					<td align="middle"><asp:CheckBox id=chkAirline1 runat="SERVER"></asp:CheckBox></td>
							</tr>
							<tr>
								<td><font face="Arial, Helvetica" size="2">2:</font></td>
								<td>&nbsp;<asp:TextBox id=txtAirline2 runat="SERVER"></asp:TextBox>
								</td>
								<td>&nbsp;<asp:TextBox id=txtAirline2Num runat="SERVER"></asp:TextBox></td></TD>
					<td align="middle"><asp:CheckBox id=chkAirline2 runat="SERVER"></asp:CheckBox></td>
							</tr>
							<tr>
								<td><font face="Arial, Helvetica" size="2">3:</font></td>
								<td>&nbsp;<asp:TextBox id=txtAirline3 runat="SERVER"></asp:TextBox></td>
								<td>&nbsp;<asp:TextBox id=txtAirline3Num runat="SERVER"></asp:TextBox></td></TD>
					<td align="middle"><asp:CheckBox id=chkAirline3 runat="SERVER"></asp:CheckBox></td>
							</tr>
						</table><br></TD>
				<tr>
					<td><font face="Arial, Helvetica" size="2">Preferred travel class: <asp:DropDownList id=cboTravelClass runat="SERVER" Width="115" Height="22"></asp:DropDownList><br>&nbsp;<asp:CheckBox id=chkUseFFifMoreThan runat="SERVER"></asp:CheckBox>Use 
            frequent flyer miles if ticket price is more than&nbsp; <asp:TextBox id=txtUseFFifMoreThan runat="SERVER" Width="70" Height="22px"></asp:TextBox>
</font></td>
				</tr></TBODY></TABLE>
			
			<table border="0" width="95%" cellspacing="0" cellpadding="0">
				<img src="img/spacer.gif" width=1 height=5 border=0 alt=""><br>
				<tr>
					<td height="1" bgcolor="#000000"><img src="img/spacer.gif" width=1 height=1 border=0 alt=""></td>
				</tr>
			</table><a name="activityprefs"></a>
			<table border="0" width="95%" cellspacing="0" cellpadding="0">
				<tr>
					<td><font face="Arial, Helvetica" size="2"><img src="img/spacer.gif" width=1 height=5 border=0 alt=""><br>
					<b>Activity Preferences</b><br><br></font>
					</td>
				</tr>
				<tr>
					<td><font face="Arial, Helvetica" size="2">
					<i>Please select your favorite activities</i><br></font>
					</td>
				</tr>
				<tr>
					<td><asp:Table id=tblActivity runat="SERVER"></asp:Table>
					</td>
				</tr>
        <tr>
          <td>
            <p><strong>
            <hr width="100%" SIZE=1>

            <p></p>
            <p><font face=Arial size=2>Dining 
        Preferences</font></strong>
            </p></td></tr>
							<tr>
					<td><font face="Arial, Helvetica" size="2"><br>
					<i>Please select your favorite cuisine</i><br></font>
					</td>
				</tr>
				<tr>
					<td><asp:Table id=tblCuisine runat="SERVER"></asp:Table>
					</td>
				</tr>
			</table>
			
			<table border="0" width="95%" cellspacing="0" cellpadding="0">
				<img src="img/spacer.gif" width=1 height=5 border=0 alt=""><br>
				<tr>
					<td height="1" bgcolor="#000000"><img src="img/spacer.gif" width=1 height=1 border=0 alt=""></td>
				</tr>
			</table><a name="hotelprefs"></a>
			<table border="0" width="95%" cellspacing="0" cellpadding="0">
				<tr>
					<td><font face="Arial, Helvetica" size="2"><img src="img/spacer.gif" width=1 height=5 border=0 alt=""><br>
					<b>Hotel Preferences</b><br><br></font>
					</td>
				</tr>
				<tr>
					<td><font face="Arial, Helvetica" size="2">
					<i>Please enter your hotel rewards information</i><br></font>
					</td>
				</tr>
				<tr>
					<td>
						<table border="0">
              <TBODY>
							<tr>
								<td><font face="Arial, Helvetica" size="2">&nbsp;</font></td>
								<td valign="bottom"><font face="Arial, Helvetica" size="2">Hotel(s)</font></td>
								<td valign="bottom"><font face="Arial, Helvetica" size="2">Number(s)</font></td>
								<td valign="bottom"><font face="Arial, Helvetica" size="2">Only show me rooms in this hotel</font></td>
							</tr>
							<tr>
								<td><font face="Arial, Helvetica" size="2">1:</font></td>
								<td>&nbsp;<asp:TextBox id=txtHotel1 runat="SERVER"></asp:TextBox>
								</td>
								<td>&nbsp;<asp:TextBox id=txtHotel1Num runat="SERVER"></asp:TextBox>
					</td>
					</td>
					<td align="middle"><asp:CheckBox id=chkHotel1 runat="SERVER"></asp:CheckBox></td>
							</tr>
							<tr>
								<td><font face="Arial, Helvetica" size="2">2:</font></td>
								<td>&nbsp;<asp:TextBox id=txtHotel2 runat="SERVER"></asp:TextBox>
								</td>
								<td>&nbsp;<asp:TextBox id=txtHotel2Num runat="SERVER"></asp:TextBox></td></TD>
					<td align="middle"><asp:CheckBox id=chkHotel2 runat="SERVER"></asp:CheckBox></td>
							</tr>
							<tr>
								<td><font face="Arial, Helvetica" size="2">3:</font></td>
								<td>&nbsp;<asp:TextBox id=txtHotel3 runat="SERVER"></asp:TextBox></td>
								<td>&nbsp;<asp:TextBox id=txtHotel3Num runat="SERVER"></asp:TextBox></td></TD>
					<td align="middle"><asp:CheckBox id=chkHotel3 runat="SERVER"></asp:CheckBox></td>
							</tr>
						</table><br></TD>
				<tr>
					<td><font face="Arial, Helvetica" size="2">Room Preferences:&nbsp;<asp:DropDownList id=cboSmokePref runat="SERVER"></asp:DropDownList>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:DropDownList id=cboRoomTypePref runat="SERVER"></asp:DropDownList><br>&nbsp;<asp:CheckBox id=chkUseRoomPts runat="SERVER"></asp:CheckBox>Use 
            rewards points if room price is more than&nbsp;<asp:TextBox id=txtUsePtsHotelPrice runat="SERVER" Width="80px" Height="22px"></asp:TextBox>
</font></td>
				</tr></TBODY></TABLE>
			
			</form></TD></TR></TBODY></TABLE></FORM>

  </body></html>
