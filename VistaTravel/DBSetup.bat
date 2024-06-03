cd %4
ISQL -U%1 -P%2 -iDB\DBS_REMOVE.SQL

XCOPY .\DB\*.mdf %3 /Y /Q /S /E /I
XCOPY .\DB\*.ldf %3 /Y /Q /S /E /I

ISQL -U%1 -P%2 -Q"sp_attach_db @dbname=N'LodgingMgr',@filename1=N'%3LodgingMgr_Data.mdf',@filename2=N'%3LodgingMgr_Log.ldf'"
ISQL -U%1 -P%2 -Q"sp_attach_db @dbname=N'AirlineService',@filename1=N'%3AirlineService_Data.mdf',@filename2=N'%3AirlineService_Log.ldf'"
ISQL -U%1 -P%2 -Q"sp_attach_db @dbname=N'PointsOfInterest',@filename1=N'%3PointsOfInterest_Data.mdf',@filename2=N'%3PointsOfInterest_Log.ldf'"
ISQL -U%1 -P%2 -Q"sp_attach_db @dbname=N'Profile',@filename1=N'%3Profile_Data.mdf',@filename2=N'%3Profile_Log.ldf'"
ISQL -U%1 -P%2 -Q"sp_attach_db @dbname=N'Ratings',@filename1=N'%3Ratings_Data.mdf',@filename2=N'%3Ratings_Log.ldf'"
