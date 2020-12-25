USE [EcsDocs]
GO

/****** Object:  Table [dbo].[CustomerUrl]    Script Date: 12/25/2020 5:23:16 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO
--drop table [CustomerUrl]
CREATE TABLE [dbo].[CustomerUrl](
	[id] [int] NOT NULL,
	[customerId] [int] NOT NULL,
	[link] [varchar](2083) NULL,
	isMain tinyint
) ON [PRIMARY]
GO


