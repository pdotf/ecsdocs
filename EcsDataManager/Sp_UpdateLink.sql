USE [EcsDocs]
GO

/****** Object:  StoredProcedure [dbo].[Sp_UpdateDevice]    Script Date: 12/25/2020 6:00:17 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[Sp_UpdateUrl]
@id int,
@customerId int,
@link nvarchar (2083) = null
AS
BEGIN
UPDATE EcsDocs.dbo.CustomerUrl 
SET 
CustomerId=@CustomerId
,link=@link
Where Id=@Id 
END
GO


