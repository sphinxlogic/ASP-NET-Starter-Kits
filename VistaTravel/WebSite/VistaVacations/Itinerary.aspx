<%@ Page Language="vb" Codebehind="Itinerary.vb" Inherits="VistaVacations.Itinerary"%>
<HTML><HEAD>
<TITLE>Vista Vacations</TITLE>
<META content="Microsoft Visual Studio 7.0" name=GENERATOR>
<META content="Visual Basic 7.0" name=CODE_LANGUAGE></HEAD>
<BODY>
<form id="Itinerary" method=post runat="server"><!-- logo bar -->&nbsp;


<table cellSpacing=0 cellPadding=0 width="100%" border=0>
  <tr>
    <td rowSpan=2><img height=52 alt="" src="img/logo.gif" width=217 
    border=0></td>
    <td align=right><font face="Verdana, Arial, Helvetica" size=1><a id=blue 
      href="About.aspx">About Us</a> · <a id=blue 
      href="NotImplemented.aspx">Privacy Statement</a> · <a id=blue 
      href="NotImplemented.aspx">Customer Care</a></font>&nbsp;&nbsp;</td></tr>
  <tr>
    <td align=right><font face="Verdana, Arial, Helvetica" 
      size=1><b>&nbsp;</b></font></td></tr></table><!-- top menu bar -->
<table cellSpacing=0 width="100%" bgColor=#3399cc border=0>
  <tr>
    <td align=right><font face="Verdana, Arial, Helvetica" color=#ffffff 
      size=2>&nbsp;&nbsp;<b><a id=wht href="NotImplemented.aspx"><font 
      color=#ffffff>Flights</font></a></b>&nbsp;&nbsp;|&nbsp;&nbsp;<b><a id=wht 
      href="NotImplemented.aspx"><font 
      color=#ffffff>Hotels</font></a></b>&nbsp;&nbsp;|&nbsp;&nbsp;<b><a id=wht 
      href="NotImplemented.aspx"><font color=#ffffff>Ground 
      Travel</font></a></b>&nbsp;&nbsp;|&nbsp;&nbsp;<b><a id=wht 
      href="Index.aspx"><font color=#ffffff>Dining &amp; 
      Activities</font></a></b>&nbsp;&nbsp;|&nbsp;&nbsp;<b><a id=wht 
      href="NotImplemented.aspx"><font 
      color=#ffffff>Deals</font></a></b>&nbsp;&nbsp;|&nbsp;&nbsp;
<input 
      style="FONT-SIZE: 7pt; BACKGROUND: #ffffff; COLOR: #000000; FONT-FAMILY: Verdana,Arial" 
      type=text size=12 value=Search name=searchbox> 
<input type=image 
      src="img/gobutton.gif" align=absMiddle>&nbsp;</font></td></tr></table><!-- left and content -->
<table cellSpacing=0 cellPadding=0 width="100%" border=0>
  <tr>
    <td vAlign=top width=143 bgColor=#006699><!-- left side --><img height=210 
      alt="" src="img/leftpic.jpg" width=143 border=0> <font 
      face="Verdana, Arial, Helvetica" color=#ffffff size=1><br></font>
      <table cellSpacing=5 cellPadding=0 width=130 border=0>
        <tr>
          <td><font face="Verdana, Arial, Helvetica" color=#ffcc66 
            size=1><b>John Doe</b></font></td></tr>
        <tr>
          <td><a href="profile.aspx"><font face="Verdana, Arial, Helvetica" 
            color=#ffffff size=1>Edit your 
      profile</font></a></td></tr></table><br><br></FONT>
      <table cellSpacing=5 cellPadding=0 width=130 border=0>
        <tr>
          <td colSpan=2><font face="Verdana, Arial, Helvetica" color=#ffcc66 
            size=1><b>Airfare Deals</b></font></td></tr>
        <tr>
          <td bgColor=#000000 colSpan=2 height=1><img height=1 alt="" 
            src="img/spacer.gif" width=1 border=0></td></tr>
        <tr>
          <td><font face="Verdana, Arial, Helvetica" color=#ffffff 
            size=1><b>ORD - LAX</b></font></td>
          <td><font face="Verdana, Arial, Helvetica" color=#ffffff 
            size=1><b>$235</b></font></td></tr>
        <tr>
          <td><font face="Verdana, Arial, Helvetica" color=#ffffff 
            size=1><b>DFW - NYL</b></font></td>
          <td><font face="Verdana, Arial, Helvetica" color=#ffffff 
            size=1><b>$346</b></font></td></tr>
        <tr>
          <td><font face="Verdana, Arial, Helvetica" color=#ffffff 
            size=1><b>MDW - JHY</b></font></td>
          <td><font face="Verdana, Arial, Helvetica" color=#ffffff 
            size=1><b>$768</b></font></td></tr></table><br><br></FONT><form 
      method="post" action="weather.asp">
      <table cellSpacing=5 cellPadding=0 width=130 border=0>
        <tr>
          <td colSpan=2><font face=Itinerary2.aspx color=#ffcc66 
            size=1><b>Check the Weather</b></font> </td></tr>
        <tr>
          <td bgColor=#000000 colSpan=2 height=1><img height=1 alt="" 
            src="img/spacer.gif" width=1 border=0></td></tr>
        <tr>
          <td align=right><font face="Verdana, Arial, Helvetica" color=#ffffff 
            size=1><b>City:</b></font></td>
          <td>
<input type=text size=12 name=city></td></tr>
        <tr>
          <td align=right><font face="Verdana, Arial, Helvetica" color=#ffffff 
            size=1><b>Zip:</b></font></td>
          <td>
<input type=text size=7 name=zip> 
<input type=image 
            src="img/gobutton.gif" 
      align=absMiddle></td></tr></table></form></FONT></td>
    <td vAlign=top align=middle><!-- content  -->
      <form method=post><br>
      <table cellSpacing=0 cellPadding=0 width="95%" border=0>
        <tr>
          <td height=16><img height=16 alt="" src="img/itinerary.gif" 
            width=128 border=0></td></tr>
        <tr>
          <td bgColor=#000000 height=1><img height=1 alt="" 
            src="img/spacer.gif" width=1 border=0></td></tr></table><img 
      height=5 alt="" src="img/spacer.gif" width=1 border=0><br>
      <table cellSpacing=0 cellPadding=0 width="95%" border=0>
        <tr>
          <td colSpan=7><font face="Verdana, Arial, Helvetica" size=1>
<input type=submit value=Day> 
<input type=submit value=Week> 
            &nbsp;&nbsp; <img height=15 alt="" src="img/sqccccff.gif" width=15 
            align=absMiddle border=0> Scheduled for Booking &nbsp;&nbsp; <img 
            height=15 alt="" src="img/sqcccccc.gif" width=15 align=absMiddle 
            border=0> Optional, click for more info </font><br><img height=5 
            alt="" src="img/spacer.gif" width=1 border=0><br></td></tr>
        <tr>
          <td bgColor=#000000 colSpan=7 height=1><img height=1 alt="" 
            src="img/spacer.gif" width=1 border=0></td></tr></table>

      <p>&nbsp;</p>
      <p>&nbsp;</p>
      <p>
      <p><ASP:DataGrid id=DataGrid1 runat="server" ConfigurableProperties="System.Configuration.Design.ComponentSettings" onPageIndexChanged="DataGrid1_Page" AlternatingItemStyle-BackColor="#eeeeee" HeaderStyle-BackColor="#aaaadd" Font-Size="8pt" Font-Name="Verdana" CellSpacing="0" CellPadding="3" BorderWidth="1px" BorderColor="Black" PagerStyle-PrevPageText="Prev" PagerStyle-NextPageText="Next" PagerStyle-HorizontalAlign="Right" PagerStyle-Mode="NextPrev" PageSize="10" AllowPaging="False">
<property name=PagerStyle>
<asp:datagridpagerstyle NextPageText=" " PrevPageText=" " HorizontalAlign="Right" >

</asp:datagridpagerstyle>
</property>

<property name=AlternatingItemStyle>
<asp:tableitemstyle BackColor="#EEEEEE" >

</asp:tableitemstyle>
</property>

<property name=FooterStyle>
<asp:tableitemstyle BackColor="#3366FF" >

</asp:tableitemstyle>
</property>

<property name=HeaderStyle>
<asp:tableitemstyle BackColor="#3399CC" >

</asp:tableitemstyle>
</property>
      </ASP:DataGrid></p>
      <p>
      

<input id=Button2 type=button value="Back" name=cmdBack RUNAT="SERVER" onServerClick="Prev_Click">
<input id=Button3 type=button value="Next" name=cmdNext RUNAT="SERVER" onServerClick="Next_Click">
      <p></p>      
	<p></p>
<input id=cmdBookTrip type=button value="Book this Trip!" name=cmdBookTrip RUNAT="SERVER" onServerClick="cmdBookTrip_ServerClick">
      <p>
      <asp:TextBox id=txtMemberID runat="SERVER" Width="39" Height="24" Visible="False"></asp:TextBox>
      <asp:TextBox id=txtItineraryID runat="SERVER" Width="36" Height="24" Visible="False"></asp:TextBox></p>
      <asp:TextBox id=txtDepartDate runat="SERVER" Width="39" Height="24" Visible="False"></asp:TextBox>
      <asp:TextBox id=txtReturnDate runat="SERVER" Width="39" Height="24" Visible="False"></asp:TextBox>
      <asp:TextBox id=txtLastRequestedDate runat="SERVER" Width="39" Height="24" Visible="False"></asp:TextBox>
      <asp:TextBox id=txtRequestedDate runat="SERVER" Width="39" Height="24" Visible="False"></asp:TextBox>      
      <p></p>
      <p>&nbsp;</p></form></td></tr></table>

      <!--TODO: Add HTML Content and Server Controls--></form></BODY></html>
