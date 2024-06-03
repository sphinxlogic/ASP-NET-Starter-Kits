--
-- Safely drop database if it exists
-- Copyright © 2000 Vertigo Software, Inc.
--


Declare @dbid int

select @dbid = null
select @dbid = dbid from master.dbo.sysdatabases where name='LodgingMgr'
if @dbid is NOT null
	begin
		drop database LodgingMgr
	end

select @dbid = null
select @dbid = dbid from master.dbo.sysdatabases where name='AirlineService'
if @dbid is NOT null
	begin
		drop database AirlineService
	end

select @dbid = null
select @dbid = dbid from master.dbo.sysdatabases where name='Profile'
if @dbid is NOT null
	begin
		drop database Profile
	end

select @dbid = null
select @dbid = dbid from master.dbo.sysdatabases where name='PointsOfInterest'
if @dbid is NOT null
	begin
		drop database PointsOfInterest
	end

select @dbid = null
select @dbid = dbid from master.dbo.sysdatabases where name='Ratings'
if @dbid is NOT null
	begin
		drop database Ratings
	end
