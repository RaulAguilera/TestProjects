--To create alumno user

USE [master]

CREATE LOGIN [alumno] WITH PASSWORD=N'UT_tics2903'
CREATE USER [alumno] WITH DEFAULT_SCHEMA=[db_datareader]

USE [Utmart2018]

CREATE USER [alumno] FOR LOGIN alumno WITH DEFAULT_SCHEMA = [SalesLT]
EXEC sp_addrolemember N'db_datareader', N'alumno'