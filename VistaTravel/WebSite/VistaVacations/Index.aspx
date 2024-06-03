<%@ Page Language="vb" Codebehind="Index.vb" Inherits="VistaVacations.Index"%>
<HTML><HEAD>
<meta content="Microsoft Visual Studio 7.0" name=GENERATOR>
<meta content="Visual Basic 7.0" name=CODE_LANGUAGE></HEAD>
<body>
<form id=Index method=post runat="server">
<table cellSpacing=0 cellPadding=0 width="706" border=0 style="WIDTH: 706px; HEIGHT: 52px">
  <tr>
    <td rowSpan=2 style="WIDTH: 85px"><img height=52 
      alt="" src="img/logo.gif" width=217 border=0></td>
    <td align=right></td></tr>
  <tr>
    <td align=right><font 
      face="Verdana, Arial, Helvetica" size=1><a id=blue1 
      href="About.aspx">About Us</a> · <a id=blue2 href="NotImplemented.aspx">Privacy 
      Statement</a> · <a id=blue href="NotImplemented.aspx">Customer 
      Care</a><strong>&nbsp;</strong></font></td></tr></table><!-- top menu bar -->
<table cellSpacing=0 width="722" bgColor=#3399cc border=0 
  style="WIDTH: 722px; HEIGHT: 20px">
  <tr>
    <td align=right><font 
      face="Verdana, Arial, Helvetica" color=#ffffff size=2 
      >&nbsp;&nbsp;<b><A id=wht1 href="NotImplemented.aspx" ><font 
      color=#ffffff 
      >Flights</font></A></b>&nbsp;&nbsp;|&nbsp;&nbsp;<b 
      ><A id=wht2 href="NotImplemented.aspx" ><font color=#ffffff 
      >Hotels</font></A></b>&nbsp;&nbsp;|&nbsp;&nbsp;<b 
      ><A id=wht3 href="Index.aspx" ><font color=#ffffff>Ground 
      Travel</font></A></b>&nbsp;&nbsp;|&nbsp;&nbsp;<b><A id=wht4 href="NotImplemented.aspx" ><font 
      color=#ffffff>Dining &amp; 
      Activities</font></A></b>&nbsp;&nbsp;|&nbsp;&nbsp;<b 
      ><A id=wht5 href="NotImplemented.aspx" ><font color=#ffffff 
      >Deals</font></A></b>&nbsp;&nbsp;|&nbsp;&nbsp;<asp:TextBox id=searchbox runat="SERVER" Width="74" Height="19"></asp:TextBox>&nbsp; 
      <input 
      type=image src="img/gobutton.gif" align=absMiddle 
      >&nbsp;</font></td></tr></table><!-- left and content -->
<table cellSpacing=0 cellPadding=0 width="722" border=0 style="WIDTH: 722px; HEIGHT: 692px">
  <TBODY>
  <tr>
    <td vAlign=top width=143 bgColor=#006699 
    ><!-- left side --><asp:Image id=Image1 runat="SERVER" Height="214" Width="145" ImageUrl="img/leftpic.jpg"></asp:Image><br 
      >
      <table cellSpacing=5 cellPadding=0 width=130 border=0>
        <tr>
          <td><div id=MemberName runat=server></div></td></tr>
        <tr>
          <td><A href="profile.aspx" ><font 
            face="Verdana, Arial, Helvetica" color=#ffffff size=1 
            >Edit your 
      profile</font></A></td></tr></table><br><br 
      >
      <table cellSpacing=5 cellPadding=0 width=130 border=0>
        <tr>
          <td colSpan=2><font 
            face="Verdana, Arial, Helvetica" color=#ffcc66 size=1 
            ><b>Airfare 
          Deals</b></font></td></tr>
        <tr>
          <td bgColor=#000000 colSpan=2 height=1><IMG height=1 alt="" src="img/spacer.gif" width=1 border=0 ></td></tr>
        <tr>
          <td><font face="Verdana, Arial, Helvetica" 
            color=#ffffff size=1><b 
            >ORD - LAX</b></font></td>
          <td><font face="Verdana, Arial, Helvetica" 
            color=#ffffff size=1><b 
            >$235</b></font></td></tr>
        <tr>
          <td><font face="Verdana, Arial, Helvetica" 
            color=#ffffff size=1><b 
            >DFW - NYL</b></font></td>
          <td><font face="Verdana, Arial, Helvetica" 
            color=#ffffff size=1><b 
            >$346</b></font></td></tr>
        <tr>
          <td><font face="Verdana, Arial, Helvetica" 
            color=#ffffff size=1><b 
            >MDW - JHY</b></font></td>
          <td><font face="Verdana, Arial, Helvetica" 
            color=#ffffff size=1><b 
            >$768</b></font></td></tr></table><br 
      ><br></form>
      <form action=weather.asp method=get>
      <table cellSpacing=5 cellPadding=0 width=130 border=0>
        <tr>
          <td colSpan=2 style="WIDTH: 131px"><font 
            face="Verdana, Arial, Helvetica" color=#ffcc66 size=1 
            ><b>Check the 
            Weather</b></font> </td></tr>
        <tr>
          <td bgColor=#000000 colSpan=2 height=1 style="WIDTH: 131px"><IMG height=1 alt="" src="img/spacer.gif" width=1 border=0 ></td></tr>
        <tr>
          <td align=right style="HEIGHT: 14px"><font 
            face="Verdana, Arial, Helvetica" color=#ffffff size=1 
            ><b>City:</b></font></td>
          <td style="WIDTH: 102px; HEIGHT: 14px">&nbsp;<asp:TextBox id=city runat="SERVER" Width="80px" Height="22px"></asp:TextBox> </td></tr>
        <tr>
          <td align=right><font 
            face="Verdana, Arial, Helvetica" color=#ffffff size=1 
            ><b>Zip:</b></font></td>
          <td style="WIDTH: 102px">&nbsp;<asp:TextBox id=zip runat="SERVER" Width="57px" Height="22px"></asp:TextBox> <input type=image src="img/gobutton.gif" 
            align=absMiddle> 
      </td></tr></table></form></FONT></TD>
    <td vAlign=top align=middle><!-- content  -->
      <form action=traveloptions.aspx method=post>
      <table cellSpacing=0 cellPadding=0 width="95%" border=0 
      >
        <tr>
          <td><div id=MemberName1 runat=server></div> Would you like to <A href="profile.aspx" >change your profile</A>?<br 
            ><br></FONT></td></tr>
        <tr>
          <td height=16><IMG height=16 alt="" src="img/escapeplans.gif" width=128 border=0 ></td></tr>
        <tr>
          <td bgColor=#000000 height=1><IMG height=1 alt="" src="img/spacer.gif" width=1 border=0 ></td></tr>
        <tr>
          <td><IMG height=5 alt="" src="img/spacer.gif" width=1 border=0 > <font face="Arial, Verdana, Helvetica" size=2 
            >Search great escapes by selecting any 
            combination of the following options: </font><br 
            ><br></td></tr></table>
      <table cellSpacing=0 cellPadding=0 width="95%" bgColor=#ffffcc border=0 
      >
        <tr>
          <td vAlign=top>
            <table cellSpacing=0 cellPadding=3 bgColor=#ffffcc border=0 
            style="WIDTH: 533px; HEIGHT: 259px">
              <tr>
                <td width=14><IMG height=14 alt="" src="img/arrow.gif" width=14 align=middle border=0 ></td>
                <td style="WIDTH: 204px"><font 
                  face="Verdana, Arial, Helvetica" size=1 
                  >From what are you escaping?</font> </td>
                <td style="WIDTH: 158px"><asp:DropDownList id=escapingfrom runat="SERVER" Width="135px" Height="22"></asp:DropDownList> 
                </td></tr>
              <tr>
                <td><IMG height=14 alt="" src="img/arrow.gif" width=14 align=middle border=0 ></td>
                <td style="WIDTH: 204px"><font 
                  face="Verdana, Arial, Helvetica" size=1 
                  >What are you escaping to do?</font> </td>
                <td style="WIDTH: 142px"><asp:DropDownList id=escapingto runat="SERVER" Width="135px" Height="22"></asp:DropDownList> 
                </td></tr>
              <tr>
                <td><IMG height=14 alt="" src="img/arrow.gif" width=14 align=middle border=0 ></td>
                <td style="WIDTH: 204px"><font 
                  face="Verdana, Arial, Helvetica" size=1 
                  >With whom are you escaping?</font> </td>
                <td style="WIDTH: 142px"><asp:DropDownList id=escapewith runat="SERVER" Width="135px" Height="22"></asp:DropDownList> 
</td></tr>
              <tr>
                <td vAlign=center><img height=14 alt="" src="img/arrow.gif" 
                  width=14 align=middle border=0></td>
                <td style="WIDTH: 204px" colSpan=1><font face=Verdana 
                  size=1>What is your destination?</font></td>
                <td><asp:DropDownList id=destination runat="SERVER" Width="135px" Height="22"></asp:DropDownList></td></tr>
              <tr>
                <td vAlign=center><img height=14 alt="" src="img/arrow.gif" 
                  width=14 align=middle border=0></td>
                <td style="WIDTH: 204px" colSpan=1><font face=Verdana 
                  size=1>What is your maximum price?</font></td>
                <td><asp:DropDownList id=price runat="SERVER" Width="135px" Height="22"></asp:DropDownList></td></tr>
              <tr>
                <td vAlign=center><img height=14 alt="" src="img/arrow.gif" 
                  width=14 align=middle border=0></td>
                <td style="WIDTH: 204px" colSpan=1><font face=Verdana 
                  size=1>   When will you leave? (mm/dd/yyyy)</font></td>
                <td><asp:TextBox id=txtLeave runat="SERVER" Height="24" Width="135"></asp:TextBox></td></tr>
              <tr>
                <td vAlign=top style="HEIGHT: 27px"><IMG height=14 alt="" src="img/arrow.gif" width=14 align=middle border=0 ></td>
                <td colSpan=1 style="WIDTH: 204px; HEIGHT: 27px"><font face=Verdana size=1>  When 
                  will you return? (mm/dd/yyyy)</font></td>
                <td style="HEIGHT: 27px"><asp:TextBox id=txtReturn runat="SERVER" Height="24" Width="135"></asp:TextBox></td></tr>
              <tr>
                <td align=right colSpan=3></td></tr>
              <tr>
                <td align=right colSpan=2 style="WIDTH: 234px"> 
                </td>
                <td align=left>
<input id=cmdEscape style="WIDTH: 133px; HEIGHT: 24px" type=submit size=26 value="Escape Now!" name=cmdEscape RUNAT="SERVER" onServerClick="cmdEscape_ServerClick"></td></tr></table></td></tr></table><br 
      >
      <table cellSpacing=0 cellPadding=0 width="95%" border=0 
      >
        <tr>
          <td height=16><IMG height=16 alt="" src="img/travelhelpers.gif" width=128 border=0 ></td></tr>
        <tr>
          <td bgColor=#000000 height=1><IMG height=1 alt="" src="img/spacer.gif" width=1 border=0 ></td></tr>
        <tr>
          <td><IMG height=5 alt="" src="img/spacer.gif" width=1 border=0 ><br>&nbsp;<asp:DropDownList id=reservations runat="SERVER" Width="123" Height="22"></asp:DropDownList> 
<asp:DropDownList id=travelguides runat="SERVER" Width="120" Height="22"></asp:DropDownList> <input 
            type=image src="img/gobutton.gif" align=absMiddle 
            > </td></tr></table><br 
      ><br>
      <table cellSpacing=0 cellPadding=0 width="95%" border=0 
      >
        <tr>
          <td height=16><IMG height=16 alt="" src="img/featuredtips.gif" width=128 border=0 ></td></tr>
        <tr>
          <td bgColor=#000000 height=1><IMG height=1 alt="" src="img/spacer.gif" width=1 border=0 ></td></tr>
        <tr>
          <td>
            <ul>
              <li type=square><A href="NotImplemented.aspx" >Carnival 
              Cruise to the Bahamas 6 days/7 nights - $989 per person</A> 
              <li type=square><A href="NotImplemented.aspx" >Ski the Alps for 
              $1398 - airfare included</A> 
              <li type=square><A href="NotImplemented.aspx" >Celebrate the 
              New Year in Style - New Orleans Package</A> </li></ul></FONT><br 
            ><br 
      ></td></tr></table></form></td></TR></TBODY></TABLE>
      
  </body></html>
