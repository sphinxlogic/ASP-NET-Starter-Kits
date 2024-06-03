<%@ Page Language="vb" Codebehind="Options.vb" Inherits="VistaVacations.Options"%>
<HTML><HEAD>
    <meta name="GENERATOR" content="Microsoft Visual Studio 7.0">
    <meta name="CODE_LANGUAGE" content="Visual Basic 7.0">
<script language=javascript>
	function GetGridValues(Descr, Quant, cost, itemid){
		document.Options.txtDescr.value = Descr;
		document.Options.txtQuant.value = Quant;
		document.Options.txtCost.value = cost;
		document.Options.txtItemID.value = itemid;
		};
</script>
</HEAD>
  <body>

<!-- logo bar -->
<form id=Options name=Options runat="server">
<TABLE cellSpacing=0 cellPadding=0 width="100%" border=0>
<TBODY>
<TR>
<TD rowSpan=2><IMG height=52 alt="" src="img/logo.gif" width=217 border=0></TD>
<TD align=right><FONT face="Verdana, Arial, Helvetica" size=1><A id=blue 
href="About.aspx">About Us</A> · <A id=blue href="NotImplemented.aspx">Privacy Statement</A> · <A 
id=blue href="NotImplemented.aspx">Customer Care</A></FONT>&nbsp;&nbsp;</TD></TR>
<TR>
<TD align=right><FONT face="Verdana, Arial, Helvetica" 
size=1><B>&nbsp;</B></FONT></TD></TR></TBODY></TABLE><!-- top menu bar -->
<TABLE cellSpacing=0 width="100%" bgColor=#3399cc border=0>
<TBODY>
<TR>
<TD align=right><FONT face="Verdana, Arial, Helvetica" color=#ffffff 
size=2>&nbsp;&nbsp;<B><A id=wht href="NotImplemented.aspx"><FONT 
color=#ffffff>Flights</FONT></A></B>&nbsp;&nbsp;|&nbsp;&nbsp;<B><A id=wht href="NotImplemented.aspx"><FONT 
color=#ffffff>Hotels</FONT></A></B>&nbsp;&nbsp;|&nbsp;&nbsp;<B><A id=wht href="NotImplemented.aspx"><FONT 
color=#ffffff>Ground Travel</FONT></A></B>&nbsp;&nbsp;|&nbsp;&nbsp;<B><A id=wht href="NotImplemented.aspx"><FONT 
color=#ffffff>Dining &amp; Activities</FONT></A></B>&nbsp;&nbsp;|&nbsp;&nbsp;<B><A id=wht 
href="NotImplemented.aspx"><FONT color=#ffffff>Deals</FONT></A></B>&nbsp;&nbsp;|&nbsp;&nbsp;<INPUT 
style="FONT-SIZE: 7pt; BACKGROUND: #ffffff; COLOR: #000000; FONT-FAMILY: Verdana,Arial" 
size=12 value=Search name=searchbox> <INPUT type=image cache 
src="img/gobutton.gif" align=absMiddle>&nbsp;</FONT></TD></TR></TBODY></TABLE><!-- left and content -->
<TABLE cellSpacing=0 cellPadding=0 width="100%" border=0>
<TBODY>
<TR>
<TD vAlign=top width=143 bgColor=#006699><!-- left side --><IMG height=210 alt="" 
src="img/leftpic.jpg" width=143 border=0> <FONT face="Verdana, Arial, Helvetica" 
color=#ffffff size=1><BR>
<TABLE cellSpacing=5 cellPadding=0 width=130 border=0>
<TBODY>
<TR>
<TD><FONT face="Verdana, Arial, Helvetica" color=#ffcc66 size=1><B>John 
Doe</B></FONT></TD></TR>
<TR>
<TD><A href="profile.html"><FONT face="Verdana, Arial, Helvetica" color=#ffffff 
size=1>Edit your profile</FONT></A></TD></TR></TBODY></TABLE><BR><BR>
<TABLE cellSpacing=5 cellPadding=0 width=130 border=0>
<TBODY>
<TR>
<TD colSpan=2><FONT face="Verdana, Arial, Helvetica" color=#ffcc66 
size=1><B>Airfare Deals</B></FONT></TD></TR>
<TR>
<TD bgColor=#000000 colSpan=2 height=1><IMG height=1 alt="" src="img/spacer.gif" 
width=1 border=0></TD></TR>
<TR>
<TD><FONT face="Verdana, Arial, Helvetica" color=#ffffff size=1><B>ORD - 
LAX</B></FONT></TD>
<TD><FONT face="Verdana, Arial, Helvetica" color=#ffffff 
size=1><B>$235</B></FONT></TD></TR>
<TR>
<TD><FONT face="Verdana, Arial, Helvetica" color=#ffffff size=1><B>DFW - 
NYL</B></FONT></TD>
<TD><FONT face="Verdana, Arial, Helvetica" color=#ffffff 
size=1><B>$346</B></FONT></TD></TR>
<TR>
<TD><FONT face="Verdana, Arial, Helvetica" color=#ffffff size=1><B>MDW - 
JHY</B></FONT></TD>
<TD><FONT face="Verdana, Arial, Helvetica" color=#ffffff 
size=1><B>$768</B></FONT></TD></TR></TBODY></TABLE><BR><BR>
<TABLE cellSpacing=5 cellPadding=0 width=130 border=0>
<TBODY>
<TR>
<TD colSpan=2><FONT face="Options.aspx" color=#ffcc66 
size=1><B>Check the Weather</B></FONT> </TD></TR>
<TR>
<TD bgColor=#000000 colSpan=2 height=1><IMG height=1 alt="" src="img/spacer.gif" 
width=1 border=0></TD></TR>
<TR>
<TD align=right><FONT face="Verdana, Arial, Helvetica" color=#ffffff 
size=1><B>City:</B></FONT></TD>
<TD><INPUT 
style="FONT-SIZE: 7pt; BACKGROUND: #ffffff; COLOR: #000000; FONT-FAMILY: Verdana,Arial" 
size=12 name=city></TD></TR>
<TR>
<TD align=right><FONT face="Verdana, Arial, Helvetica" color=#ffffff 
size=1><B>Zip:</B></FONT></TD>
<TD><INPUT 
style="FONT-SIZE: 7pt; BACKGROUND: #ffffff; COLOR: #000000; FONT-FAMILY: Verdana,Arial" 
size=7 name=zip> <INPUT type=image cache src="img/gobutton.gif" 
align=absMiddle></TD></TR></TBODY></TABLE></FONT></TD>
<TD vAlign=top align=middle><!-- content  -->
<TABLE cellSpacing=0 cellPadding=0 width="95%" border=0>
<TBODY>
<TR>
<TD bgColor=#000000 height=1><IMG height=1 alt="" src="img/spacer.gif" width=1 
border=0></TD></TR></TBODY></TABLE>
      <p><asp:repeater id=Repeater1 runat="SERVER">
			<template name="HeaderTemplate">
                <table border=0 width=600>
				<tbody>
                  <tr>
                    <td width='70%' align=left><I><b>Description</b></I></td>
                    <td align=middle><i><b>Quantity</b></i></td>
                    <td align=middle><i><b>Cost</b></i></td>
					<td align=middle><i><b>Select</b></i></td>
                  </tr>
				
            </template>            
            <template name="ItemTemplate">
					<tr border=1>
						<td width='70%' align=left><I><%# DataBinder.Eval(Container.DataItem, "Detail") %> </I></td>
						<td width='10%' align=middle><%# DataBinder.Eval(Container.DataItem, "Quantity") %></td>
						<td width='10%' align=middle>$<%# DataBinder.Eval(Container.DataItem, "EstimatedCost") %></td>
						<td width='10%' align='middle'><input type='radio' name='selectOption' id='<%# request.QueryString.Item("DetailID")%>' onclick='GetGridValues("<%# DataBinder.Eval(Container.DataItem, "Detail") %>","<%# DataBinder.Eval(Container.DataItem, "Quantity") %>","<%# DataBinder.Eval(Container.DataItem, "EstimatedCost")%>","<%# DataBinder.Eval(Container.DataItem, "ItemID") %>");'></td>
			        </tr>
			</template>
			
			<TEMPLATE name="FooterTemplate"></TBODY>          
                </TABLE></TEMPLATE></asp:repeater></P>
      <p><asp:Button id='btnBack' runat='SERVER' text='Back' style='FONT-SIZE:7pt;BACKGROUND:#3399cc;COLOR:#ffffff;FONT-FAMILY:verdana'></asp:Button>&nbsp; 
<asp:Button id="btnSave" onclick="btnSave_Click" runat="SERVER" text="Save" style="FONT-SIZE:7pt;BACKGROUND:#3399cc;COLOR:#ffffff;FONT-FAMILY:verdana"></asp:Button></p>
      <p><asp:TextBox id="txtReferer" runat="SERVER" Width="32" Height="24" Visible="False"></asp:TextBox><asp:TextBox id=txtDetailID runat="SERVER" Visible="False" Height="24" Width="33"></asp:TextBox></p>
      <p>
<input type="hidden" name="txtDescr">
<input type="hidden" name="txtQuant"></p>
      <p>
<input type="hidden" name="txtCost">
<input type="hidden" name="txtItemID"></p></TD></TR></TBODY></TABLE></form>
    

  </body></html>
