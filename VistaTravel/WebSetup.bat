cd %2
net stop IISAdmin
Set folder=%1
attrib -R *.* /S /D
del %folder%AirlineService\*.* /F /Q
xcopy .\StandAloneProjects\AirlineService\*.* %folder%AirlineService\*.* /Q /Y
wscript _SetupWeb.vbs AirlineService %folder%
attrib -R *.* /S /D
del %folder%LodgingMgr\*.* /F /S /Q
xcopy .\WebServices\LodgingMgr\*.* %folder%LodgingMgr\*.* /E /S /Q /Y
wscript _SetupWeb.vbs LodgingMgr %folder%
attrib -R *.* /S /D
del %folder%POILib\*.* /F /S /Q
xcopy .\WebServices\POILib\*.* %folder%POILib\*.* /E /S /Q /Y
wscript _SetupWeb.vbs POILib %folder%
attrib -R *.* /S /D
del %folder%VistaVacations\*.* /F /S /Q
xcopy .\WebSite\VistaVacations\*.* %folder%VistaVacations\*.* /E /S /Q /Y
wscript _SetupWeb.vbs VistaVacations %folder%
xcopy .\Dll\*.* %folder%VistaVacations\bin\*.* /E /S /Q /Y
net Start IISAdmin
pause
