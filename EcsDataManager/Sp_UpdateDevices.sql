USE [EcsDocs]
GO
/****** Object:  StoredProcedure [dbo].[Sp_UpdateDevice]    Script Date: 2020-12-23 1:47:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[Sp_UpdateDevice]
@Id int,
@CustomerId int,
@RadioName nvarchar (50) = null,
@RadioIp nvarchar (50) = null,
@RadioModel nvarchar (50) = null,
@RadioMetroSite nvarchar (50) = null,
@IsAuto nvarchar (50) = null
AS
BEGIN
UPDATE EcsDocs.dbo.DeviceList 
SET 
CustomerId=@CustomerId
,RadioName=@RadioName
,RadioIp=@RadioIp
,RadioModel=@RadioModel
,RadioMetroSite=@RadioMetroSite
,IsAuto=@IsAuto
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
