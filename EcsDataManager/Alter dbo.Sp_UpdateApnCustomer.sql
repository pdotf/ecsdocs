USE [EcsDocs]
GO

/****** Object: SqlProcedure [dbo].[Sp_UpdateApnCustomer] Script Date: 12/31/2020 5:12:31 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[Sp_UpdateApnCustomer]
@Id int,
@CustomerName nvarchar(50)=null,
@Tell nvarchar(4000)=null,
@Mobile nvarchar(4000)=null,
@OwnerTeam nvarchar(50)=null,
@AccessList nvarchar(500)=null,
@NumberOfSimCard int=null,
@WanIpRange nvarchar(500)=null,@Comment nvarchar(4000) =null
AS
BEGIN
		UPDATE EcsDocs.dbo.ApnCustomers 
					SET 
					CustomerName=@CustomerName ,
					Tell=@Tell,
					Mobile=@Mobile,
					OwnerTeam=@OwnerTeam,
					WanIpRange=@WanIpRange,
					AccessList=@AccessList,
					NumberOfSimCard=@NumberOfSimCard,
					Comment=@Comment
		Where Id=@Id 
END
