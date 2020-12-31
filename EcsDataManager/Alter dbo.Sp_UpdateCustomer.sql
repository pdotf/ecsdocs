USE [EcsDocs]
GO

/****** Object: SqlProcedure [dbo].[Sp_UpdateCustomer] Script Date: 12/31/2020 6:54:52 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO




ALTER PROCEDURE [dbo].[Sp_UpdateCustomer]
@Id int,
@CustomerName nvarchar(50)=null,
@Tel nvarchar(4000)=null,
@Mobile nvarchar(4000)=null,
@OwnerTeam nvarchar(50)=null,
@ServiceType nvarchar(50)=null,
@ServiceTopology nvarchar(50)=null,@AccountManager nvarchar(50)=null,@IpHQ nvarchar(200)=null,@AAAGroup nvarchar(50)=null,@IpTunnel nvarchar(50)=null,@WanIpRange nvarchar(500)=null,@LanIpRange nvarchar(500)=null,@VRF nvarchar(50)=null,@VpnToolsName nvarchar(50)=null,@APN nvarchar(50)=null,@AccessList nvarchar(500)=null
AS
BEGIN
UPDATE EcsDocs.dbo.Customers 
			SET 
			CustomerName=@CustomerName ,
			Tel=@Tel,
			Mobile=@Mobile,
			OwnerTeam=@OwnerTeam,
			ServiceType=@ServiceType,
			ServiceTopology=@ServiceTopology,
			AccountManager=@AccountManager,
			IpHQ=@IpHQ,
			AAAGroup=@AAAGroup,
			IpTunnel=@IpTunnel,
			WanIpRange=@WanIpRange,
			LanIpRange=@LanIpRange,
			VRF=@VRF,
			VpnToolsName=@VpnToolsName ,
			APN=@APN,
			AccessList=@AccessList
Where Id=@Id 
--AND (@CustomerName IS  NULL OR CustomerName=@CustomerName)
--             AND(@Tel IS  NULL OR Tel=@Tel)
--                AND(@Mobile IS  NULL OR Mobile=@Mobile)
--               AND(@OwnerTeam IS  NULL OR OwnerTeam=OwnerTeam)
--              AND(@ServiceTopology IS  NULL OR ServiceTopology=@ServiceTopology)
--              AND(@ServiceType IS  NULL OR ServiceType=@ServiceType)
--              AND(@AccountManager IS  NULL OR AccountManager=@AccountManager)
--               AND(@IpHQ IS  NULL OR IpHQ=@IpHQ)
--              AND(@AAAGroup IS  NULL OR AAAGroup=@AAAGroup)
--                 AND(@IpTunnel IS  NULL OR IpTunnel=@IpTunnel)
--                 AND(@WanIpRange IS  NULL OR WanIpRange=@WanIpRange)
--                 AND(@LanIpRange IS  NULL OR LanIpRange=@LanIpRange)
--                 AND(@VRF IS  NULL OR VRF=@VRF)
--                 AND(@VpnToolsName IS  NULL OR VpnToolsName=@VpnToolsName)
END
--Select * from Devices where id=26
