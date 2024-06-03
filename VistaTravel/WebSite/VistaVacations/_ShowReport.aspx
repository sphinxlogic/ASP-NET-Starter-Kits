<%@ Register TagPrefix="CrystalReports" Namespace="SeagateSoftware.CrystalReports.WebFormsViewer" Assembly="CRWebFormViewer" %>
<%@ Import Namespace="SeagateSoftware.CrystalReports.Shared" %>

<html>
<head>

<script language="javascript">
function ShowComments()
{
   var win = window.open("_Comments.html",null,"status=no,height=250,width=450")
}
</script>

<script language="vb" runat="server">
   Sub Page_Init(ByVal sender as Object, ByVal e as EventArgs)
      If Not IsPostback Then
         Viewer1.ReportSource = Server.MapPath("_Satisfaction.rpt")
         Dim scrParams as new SCRParameterFields
         Dim scrParam as new SCRParameterField
         scrParam.Name = "RegionParameter"
         Dim scrDiscreteVal as new SCRParameterDiscreteValue
         scrDiscreteVal.Value = Request.QueryString("region").ToString()
         scrParam.CurrentValues.Add(scrDiscreteVal)
         scrParams.Add(scrParam)
         Viewer1.ParameterFieldInfo = scrParams
      Else
         Viewer1.ReportSource = Server.MapPath("_Satisfaction.rpt")
      End If
   End Sub
</script>

</head>
<body>
<form runat="server" action="_ShowReport.aspx" method="post">
<CrystalReports:CrystalReportViewer id=Viewer1 runat="server"	
	TargetSchema="HTML40"
	SeparatePages="TRUE"
	PageToTreeRatio="5"
	ShowToolBar="FALSE"
	ShowTreeView="FALSE"
	Height="150px" 
	Width="300px">
</CrystalReports:CrystalReportViewer>
</form>
</body>
</html>
