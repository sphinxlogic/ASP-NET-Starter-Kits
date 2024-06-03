<%@ Page Language="vb" Codebehind="TravelOptions.vb" Inherits="VistaVacations.TravelOptions"%>
<%@ Register Tagprefix="CrystalReports" Namespace="SeagateSoftware.CrystalReports.WebFormsViewer" Assembly="CRWebFormViewer" %>
<HTML><HEAD>
<TITLE>VistaVacations.com</TITLE>
<meta content="Microsoft Visual Studio 7.0" name=GENERATOR>
<meta content="Visual Basic 7.0" name=CODE_LANGUAGE>
<script language=VB runat="server" ID=Script1>

    Function GetSetRegion(Region as String) As String
       Dim OldRegion as string
       
 		OldRegion = txtRegion.text
 		txtRegion.text = Region
 
 		return OldRegion
 		
    End Function    
    
    Function CheckIfNotFirst() As Boolean
		Dim OldValue as boolean
		
		OldValue = cbool(txtBln.text)
		
		If OldValue = True Then
			txtBln.text = "False"
		End If
 
 		return OldValue
 		
    End Function        

    ' Needed for Crystal Reports
    Function LinkToPage(ByVal Region As String) As String
    	Dim url As String
        LinkToPage = url.format("_ShowReport.aspx?region={0}", Region)
    End Function  

</script>

<script language=javascript>
	function GetItinerary(RegionBtn)
	{	
	//function GetItinerary(RegionBtn, StartDate, EndDate)	
		window.navigate("Itinerary.aspx?Region=" + RegionBtn.id + "&StartDate=" + startdate.value + "&EndDate=" + enddate.value + "&City=" + RegionBtn.id + "&State=" + RegionBtn.name);
		//window.navigate("Itinerary.aspx?Region=" + RegionBtn.id + "&StartDate=" + StartDate + "&EndDate=" + EndDate);
	}

</script>
</HEAD>
<body link=#3399cc leftMargin=0 background=img/background.gif topMargin=0 marginheight="0" marginwidth="0">
<!-- logo bar -->
<asp:Textbox id=txtRegion runat="SERVER" Visible="False"></asp:Textbox>

<form id=TravelOptions name=TravelOptions runat="server">
	<asp:textbox id=txtBln runat="SERVER" Visible="False">False</asp:textbox>

<table cellSpacing=0 cellPadding=0 width="100%" border=0>
  <tr>
    <td rowSpan=2><IMG height=52 alt="" src="img/logo.gif" width=217 border=0 ></td>
    <td align=right><font 
      face="Verdana, Arial, Helvetica" size=1><A id=blue href="About.aspx" >About 
      Us</A> · <A id=blue href="NotImplemented.aspx" >Privacy Statement</A> · <A id=blue href="NotImplemented.aspx" >Customer 
      Care</A></font>&nbsp;&nbsp;</td></tr>
  <tr>
    <td align=right><font 
      face="Verdana, Arial, Helvetica" size=1><b 
      >&nbsp;</b></font></td></tr></table>
<!-- top menu bar -->
<table cellSpacing=0 width="100%" bgColor=#3399cc border=0 
  >
  <tr>
    <td align=right><font 
      face="Verdana, Arial, Helvetica" color=#ffffff size=2 
      >&nbsp;&nbsp;<b><A id=wht href="NotImplemented.aspx" ><font 
      color=#ffffff 
      >Flights</font></A></b>&nbsp;&nbsp;|&nbsp;&nbsp;<b 
      ><A id=wht href="NotImplemented.aspx" ><font color=#ffffff 
      >Hotels</font></A></b>&nbsp;&nbsp;|&nbsp;&nbsp;<b 
      ><A id=wht href="NotImplemented.aspx" ><font color=#ffffff>Ground 
      Travel</font></A></b>&nbsp;&nbsp;|&nbsp;&nbsp;<b><A id=wht href="NotImplemented.aspx" ><font color=#ffffff>Dining 
      &amp; Activities</font></A></b>&nbsp;&nbsp;|&nbsp;&nbsp;<b 
      ><A id=wht href="NotImplemented.aspx" ><font color=#ffffff 
      >Deals</font></A></b>&nbsp;&nbsp;|&nbsp;&nbsp;<input 
      style="FONT-SIZE: 7pt; BACKGROUND: #ffffff; COLOR: #000000; FONT-FAMILY: Verdana,Arial" 
      type=text size=12 value=Search name=searchbox> <input 
      type=image src="img/gobutton.gif" align=absMiddle 
      >&nbsp;</font></td></tr></table>
<!-- left and content -->
<table cellSpacing=0 cellPadding=0 width="100%" border=0>
  <TBODY>
  <tr>
    <td vAlign=top width=143><!-- left side --><IMG height=210 alt="" src="img/leftpic.jpg" width=143 border=0 > <font 
      face="Verdana, Arial, Helvetica" color=#ffffff size=1 
      ><br>
      <table cellSpacing=5 cellPadding=0 width=130 border=0>
        <tr>
          <td><font face="Verdana, Arial, Helvetica" 
            color=#ffcc66 size=1><b 
            >John Doe</b></font></td></tr>
        <tr>
          <td><A href="profile.aspx" ><font face="Verdana, Arial, Helvetica" 
            color=#ffffff size=1>Edit your 
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
      ><br><form 
      action="weather.asp" method="post">
      <table cellSpacing=5 cellPadding=0 width=130 border=0>
        <tr>
          <td colSpan=2><font 
            face="Verdana, Arial, Helvetica" color=#ffcc66 size=1 
            ><b>Check the 
            Weather</b></font> </td></tr>
        <tr>
          <td bgColor=#000000 colSpan=2 height=1><IMG height=1 alt="" src="img/spacer.gif" width=1 border=0 ></td></tr>
        <tr>
          <td align=right><font 
            face="Verdana, Arial, Helvetica" color=#ffffff size=1 
            ><b>City:</b></font></td>
          <td><input 
            style="FONT-SIZE: 7pt; BACKGROUND: #ffffff; COLOR: #000000; FONT-FAMILY: Verdana,Arial" 
            type=text size=12 name=city></td></tr>
        <tr>
          <td align=right><font 
            face="Verdana, Arial, Helvetica" color=#ffffff size=1 
            ><b>Zip:</b></font></td>
          <td><input 
            style="FONT-SIZE: 7pt; BACKGROUND: #ffffff; COLOR: #000000; FONT-FAMILY: Verdana,Arial" 
            type=text size=7 name=zip> <input type=image 
            src="img/gobutton.gif" align=absMiddle 
        ></td></tr></table></form></font></td>
    <td vAlign=top align=middle><!-- content  -->
      <p align=left><crystalreports:CrystalReportViewer id=CrystalReportViewer1 runat="SERVER" ReportName="C:\Inetpub\wwwroot\VistaVacations\_OverallRatings.rpt" ShowToolbar="False" ShowTreeView="False" Width="460" Height="127"></crystalreports:CrystalReportViewer></p>

<%
	Response.Write  ("<input type=hidden id=startdate name=startdate value='" & Request.Form.Item("txtLeave") & "'>")
	Response.Write ("<input type=hidden id=enddate name=enddate value='" & Request.Form.Item("txtReturn") & "'>")
%>      
      <asp:repeater id=OptionRepeater runat="SERVER">
            <template name="HeaderTemplate">                                   	
				
				<table border="0" width="95%" cellspacing="0" cellpadding="0">
				<tbody>
            </template>
            
            <template name="ItemTemplate">
						
			<%		
				Dim CurrentRegion
				dim Nights as integer
				dim Days as integer

				Nights = DateDiff(6, DateTime.Parse(Request.Form.Item("txtLeave")), DateTime.Parse(Request.Form.Item("txtReturn")))
				Days = Nights + 1
				
				CurrentRegion = ""
				CurrentRegion = DataBinder.Eval(Container.DataItem , "Region") 
				
				If (GetSetRegion(CurrentRegion) = CurrentRegion) then
					'the region is the same, so just add to the list of items
					Response.Write ("<li type='square'>" & DataBinder.Eval(Container.DataItem , "LocationName") & "  -  " & DataBinder.Eval(Container.DataItem , "Name") & " ")
				Else
					'this is the first Region or a new one
					'add another parent row and start the list
					If CheckIfNotFirst = True then
						Response.Write ("</ul></font>")												
					End If					
               					
					
					Response.Write ("<tr height='15'></tr>")
					Response.Write ("<tr><td bgcolor=#ffcc66 width='210' align='left' vAlign=top height=16 colspan=1><!-- left side ><font face='Arial, Helvetica' size='2'><b>" & LTrim(DataBinder.Eval(Container.DataItem , "Region")) & "</b></font></td>")
					Response.Write ("<td height=16><IMG height=19 alt='' src='img/rounder.gif' width='12' border=0 ></td>")
					Response.Write ("<td valign='top' align='right'>")
						'Response.Write ("<input type='submit' value='View/Edit Full Itinerary' style='FONT-SIZE:7pt;BACKGROUND:#cccccc;COLOR:#000000;FONT-FAMILY:verdana' id='" & DataBinder.Eval(Container.DataItem , "Region") & "' name=Submit1 RUNAT='CLIENT' onClick='GetItinerary(this)'></td></tr>")
					Response.Write ("<input type='submit' value='View/Edit Full Itinerary' style='FONT-SIZE:7pt;BACKGROUND:#cccccc;COLOR:#000000;FONT-FAMILY:verdana' id='" & DataBinder.Eval(Container.DataItem , "Region") & "' name='" & DataBinder.Eval(Container.DataItem , "StateAbbr") & "'  RUNAT='CLIENT' onClick='GetItinerary(this)'></td></tr>")					
						'Response.Write ("<input type='submit' value='View/Edit Full Itinerary' style='FONT-SIZE:7pt;BACKGROUND:#cccccc;COLOR:#000000;FONT-FAMILY:verdana' id='" & DataBinder.Eval(Container.DataItem , "Region") & "' name=Submit1 RUNAT='CLIENT' onClick='GetItinerary(this,"  & Request.Form.Item("txtLeave") & "," & Request.Form.Item("txtReturn") & ")'></td></tr>")
					Response.Write ("<tr><td height='1' bgcolor='#000000' colspan=3><img src='img/spacer.gif' width=1 height=1 border=0 alt=''></td></tr>") 
						'Response.Write ("<tr><td width='210' align='left' vAlign=top height=16 colspan=1><!-- left side ><i>" & Days & " Days / " & Nights & " Nights  - $" & DataBinder.Eval(Container.DataItem , "AvePrice") & "per adult</i></td></tr>")
					Response.Write ("<tr><td width='210' align='left' vAlign=top height=16 colspan=1><!-- left side ><i>" & Days & " Days " & Nights & " Nights </i></td></tr>")				
					Response.Write ("<tr><td colspan=3><font face='Arial, Helvetica' size='2'><br>")					
			%>
					<iframe align='right' frameborder="0" src='<%# LinkToPage(DataBinder.Eval(Container.DataItem,"Region").ToString())%>'></iframe>
			<%
					Response.Write ("<ul>")
					Response.Write ("<li type='square'>" & DataBinder.Eval(Container.DataItem , "LocationName") & "  -  " & DataBinder.Eval(Container.DataItem , "Name")  & " ") 
				End If
			%>
              
              </template>
              
        <TEMPLATE name="FooterTemplate">
        <ul></ul></FONT></td></tr></TBODY></table></TEMPLATE></asp:repeater>
      <p></p></TD></TR></TBODY></TABLE></form></body></html>
