<%@ Page Language="vb" Codebehind="BookTrip.vb" Inherits="VistaVacations.BookTrip"%>
<HTML><HEAD>
<title>myEscape.com</title>
    <meta name="GENERATOR" content="Microsoft Visual Studio 7.0">
    <meta name="CODE_LANGUAGE" content="Visual Basic 7.0"></HEAD>
<body background="img/background.gif" marginwidth="0" marginheight="0" topmargin="0" leftmargin="0" link="#3399cc">
<!-- logo bar -->
<table border="0" cellspacing="0" cellpadding="0" width="100%">
	<tr>
		<td rowspan="2"><img src="img/logo.gif" width=217 height=52 border=0 alt=""></td>
		<td align="right"><font face="Verdana, Arial, Helvetica" size="1"><a href="About.aspx" id=blue>About Us</a> · <a href="NotImplemented.aspx" id=blue>Privacy Statement</a> · <a href="NotImplemented.aspx" id=blue>Customer Care</a></font>&nbsp;&nbsp;</td>
	</tr>
	<tr>
		<td align="right"><font face="Verdana, Arial, Helvetica" size="1"><b>&nbsp;</b></font></td>
	</tr>
</table>
<!-- top menu bar -->
<table border="0" width="100%" bgcolor="#3399cc" cellspacing="0">
	<tr>
		<td align="right"><font face="Verdana, Arial, Helvetica" size="2" color="#ffffff">&nbsp;&nbsp;<b><a href="NotImplemented.aspx" id=wht><font color="#ffffff">Flights</font></a></b>&nbsp;&nbsp;|&nbsp;&nbsp;<b><a href="NotImplemented.aspx" id=wht><font color="#ffffff">Hotels</font></a></b>&nbsp;&nbsp;|&nbsp;&nbsp;<b><a href="NotImplemented.aspx" id=wht><font color="#ffffff">Ground Travel</font></a></b>&nbsp;&nbsp;|&nbsp;&nbsp;<b><a href="NotImplemented.aspx" id=wht><font color="#ffffff">Dining &amp; Activities</font></a></b>&nbsp;&nbsp;|&nbsp;&nbsp;<b><a href="NotImplemented.aspx" id=wht><font color="#ffffff">Deals</font></a></b>&nbsp;&nbsp;|&nbsp;&nbsp;<input type="text" name="searchbox" value="Search" size=12 style="FONT-SIZE:7pt;BACKGROUND:#ffffff;COLOR:#000000;FONT-FAMILY:Verdana,Arial"> <input type="image" src="img/gobutton.gif" align="absMiddle">&nbsp;</font></td>
	</tr>
</table>
<!-- left and content -->
<table border="0" width="100%" cellspacing="0" cellpadding="0">
	<tr>
		<td width="143" valign="top"><!-- left side -->
		<img src="img/leftpic.jpg" width=143 height=210 border=0 alt="">
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
			
		<form method="post" action="weather.asp">
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
					<td height="16"><img src="img/travelacc.gif" width=147 height=16 border=0 alt=""></td>
				</tr>
				<tr>
					<td height="1" bgcolor="#000000"><img src="img/spacer.gif" width=1 height=1 border=0 alt=""></td>
				</tr>
			</table><img src="img/spacer.gif" width=1 height=5 border=0 alt=""><br>
			<table border="0" width="95%" cellspacing="0" cellpadding="0">
				<tr>
					<td><font face="Arial, Helvetica" size="2">Travel Site is offering great deals on the following ski products... </font><br><br></td>
				</tr>
				<tr>
					<td height="1" bgcolor="#000000"><img src="img/spacer.gif" width=1 height=1 border=0 alt=""></td>
				</tr>
			</table>
	<img src="img/spacer.gif" width=1 height=5 border=0 alt=""><br>
			
			<table border="0" width="95%" cellspacing="0" cellpadding="0">
				<tr>
					<td width="50%" valign="top"><font face="Arial, Helvetica" size="2"><br>
<ul>
<i>K2 Fatty Bag</i>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<i>Sug. Retail: $34.95</i><br>
	<li type="square">Specially designed to fit new generation skiboards
  <li type="square">Padding protects bindings and 
              skis</li>    
</ul>
<center>
Quantity: <input type="text" name="quantity" value="1" size="2" style="FONT-SIZE:7pt;BACKGROUND:#ffffff;COLOR:#000000;FONT-FAMILY:verdana">
<input type="submit" value="I want it!" style="FONT-SIZE:7pt;BACKGROUND:#cccccc;COLOR:#000000;FONT-FAMILY:verdana">
</center><br>
</font>
					</td>
					<td align="middle"><br>
					<img src="img/k2fattybag.gif" width=200 height=56 border=0 alt="">
					</td>
				</tr>
			</table>
			<table border="0" width="95%" cellspacing="0" cellpadding="0">
				<tr>
					<td height="1" bgcolor="#000000"><img src="img/spacer.gif" width=1 height=1 border=0 alt=""></td>
				</tr>
			</table><img src="img/spacer.gif" width=1 height=5 border=0 alt=""><br>
			
			<table border="0" width="95%" cellspacing="0" cellpadding="0">
				<tr>
					<td width="50%" valign="top"><font face="Arial, Helvetica" size="2"><br>
<ul>
<i>Leather Spring Glove</i>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<i>Sug. Retail: $34.95</i><br>
	<li type="square">Smooth grain genuine leather
  <li type="square">Nylon back of hand and forchettes
  <li type="square">Thinsulate® thermal insulation
  <li type="square">Elastic Velcro® wrist strap 
              with K2 thumb pad</li>       
</ul>
<center>
Quantity: <input type="text" name="quantity" value="1" size="2" style="FONT-SIZE:7pt;BACKGROUND:#ffffff;COLOR:#000000;FONT-FAMILY:verdana">
<input type="submit" value="I want it!" style="FONT-SIZE:7pt;BACKGROUND:#cccccc;COLOR:#000000;FONT-FAMILY:verdana">
</center><br>
</font>
					</td>
					<td align="middle"><br>
					<img src="img/k2leatherglove.gif" width=110 height=144 border=0 alt="">
					</td>
				</tr>
			</table><img src="img/spacer.gif" width=1 height=5 border=0 alt=""><br>
			<table border="0" width="95%" cellspacing="0" cellpadding="0">
				<tr>
					<td height="1" bgcolor="#000000"><img src="img/spacer.gif" width=1 height=1 border=0 alt=""></td>
				</tr>
			</table><img src="img/spacer.gif" width=1 height=5 border=0 alt=""><br>
		<input type="button" value="Back" style="FONT-SIZE:7pt;BACKGROUND:#3399cc;COLOR:#ffffff;FONT-FAMILY:verdana" onclick="window.navigate('itinerary.aspx');"> <input type="submit" value="Continue" style="FONT-SIZE:7pt;BACKGROUND:#3399cc;COLOR:#ffffff;FONT-FAMILY:verdana">
			</form>
			
			
			
		</td>
	</tr>
</table></FORM>

  </body></html>
