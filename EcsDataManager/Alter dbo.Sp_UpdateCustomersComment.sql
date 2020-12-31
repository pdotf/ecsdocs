USE [EcsDocs]
GO

/****** Object: SqlProcedure [dbo].[Sp_UpdateCustomersComment] Script Date: 12/31/2020 7:45:00 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

 
ALTER PROCEDURE dbo.Sp_UpdateCustomersComment
    @id int ,
    @COMMENT nvarchar(max)=NULL,@CustomerType int
AS
IF @CustomerType=1
BEGIN
UPDATE EcsDocs.dbo.Customers 
			SET 
			Comment=@Comment
Where Id=@Id 
END
ELSE
BEGIN
UPDATE EcsDocs.dbo.ApnCustomers 
			SET 
			Comment=@Comment
Where Id=@Id 
END
