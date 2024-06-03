' ******************** ****************************************
' create a new vdir for this project
'
' set vName to name of folder on disk that holds the bits
' set vWeb  to name of virtual dir you want to publish
'
' *************************************************************


Option Explicit

dim vPath, scriptPath,vName
dim i
dim oArgs

Set oArgs = WScript.Arguments
For i=0 to oArgs.Count - 1
	if i = 0 then
		vName=oArgs(i)
	else
		vPath=oArgs(i)
	end if
Next

' get current path to folder and add web name to it!
scriptPath = left(Wscript.ScriptFullName,len(Wscript.ScriptFullName ) -len(Wscript.ScriptName))
vPath = vPath & vName

'call to create vDir
CreateVDir(vPath)


'code taken from mkwebdir.vbs and changed for single vDir creation.
Sub CreateVDir(vPath)

	Dim vRoot,vDir,webSite
	On Error Resume Next

	' get the local host default web
	set webSite = findWeb("localhost", "Default Web Site")
	if IsObject(webSite)=False then
		Display "Unable to locate the Default Web Site"
		exit sub
	else
		'display webSite.name
	end if

	' get the root
	set vRoot = webSite.GetObject("IIsWebVirtualDir", "Root")
	If (Err <> 0) Then
		Display "Unable to access root for " & webSite.ADsPath
		Exit sub
	else
		'display vRoot.name
	End IF

	' delete existing web if needed
	vRoot.Delete "IIsWebVirtualDir",vName
	vRoot.SetInfo
	Err=0 ' reset error	

	' create the new web
	Set vDir = vRoot.Create("IIsWebVirtualDir",vName)
	If (Err <> 0) Then
		Display "Unable to create " & vRoot.ADsPath & "/" & vName & "."
		exit sub
	else
		'display vdir.name
	end if

	' set properties on the new web	
	vDir.AccessRead = true
	vDir.Path = vPath
	vDir.Accessflags = 529
        VDir.AppCreate False
	If (Err <> 0) Then
		Display "Unable to bind path " & vPath & " to " & vRoot.Name & "/" & vName & ". Path may be invalid."
		exit sub
	end If

	' commit changes
	vDir.SetInfo
	If (Err <> 0) Then
		Display "Unable to save changes for " & vRoot.Name & "/" & vName & "."
		exit sub
	end if

	' report all ok
	'WScript.Echo Now & " " & vName & " virtual directory " & vRoot.Name & "/" & vname & " created successfully."
End Sub

Function findWeb(computer, webname)
	On Error Resume Next

	Dim websvc, site
	dim webinfo
	Dim aBinding, binding

	set websvc = GetObject("IIS://"&computer&"/W3svc")
	if (Err <> 0) then
		exit function
	end if
	' First try to open the webname.
	set site = websvc.GetObject("IIsWebServer", webname)
	if (Err = 0) and (not isNull(site)) then
		if (site.class = "IIsWebServer") then
			' Here we found a site that is a web server.
			set findWeb = site
			exit function
		end if
	end if
	err.clear
	for each site in websvc
		if site.class = "IIsWebServer" then
			'
			' First, check to see if the ServerComment
			' matches
			'
			If site.ServerComment = webname Then
				set findWeb = site
				exit function
			End If
			aBinding=site.ServerBindings
			if (IsArray(aBinding)) then
				if aBinding(0) = "" then
					binding = Null
				else
					binding = getBinding(aBinding(0))
				end if
			else 
				if aBinding = "" then
					binding = Null
				else
					binding = getBinding(aBinding)
				end if
			end if
			if IsArray(binding) then
				if (binding(2) = webname) or (binding(0) = webname) then
					set findWeb = site
					exit function
				End If
			end if 
		end if
	next
End Function

function getBinding(bindstr)

	Dim one, two, ia, ip, hn
	
	one=Instr(bindstr,":")
	two=Instr((one+1),bindstr,":")
	
	ia=Mid(bindstr,1,(one-1))
	ip=Mid(bindstr,(one+1),((two-one)-1))
	hn=Mid(bindstr,(two+1))
	
	getBinding=Array(ia,ip,hn)
end function

Sub Display(Msg)
	WScript.Echo Now & ". Error Code: " & Hex(Err) & " - " & Msg
End Sub

Sub Trace(Msg)
	WScript.Echo Now & " : " & Msg	
End Sub

Sub DeleteWeb(WebServer, WebName)
	' delete the exsiting web (ignore error if missing)
	On Error Resume Next
	Dim vDir
	display "deleting " & WebName

	WebServer.Delete "IISWebVirtualDir",WebName
	WebServer.SetInfo
	If Err=0 Then
		DISPLAY "WEB " & WebName & " deleted."
	else
		display "can't find " & webname
	End If
	
End Sub

