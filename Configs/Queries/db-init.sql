create database TestDB
go
CREATE LOGIN tlogin   
    WITH PASSWORD = 'P@55work';  
CREATE USER tuser FOR LOGIN tlogin  
    WITH DEFAULT_SCHEMA = TestDB;  
GO  