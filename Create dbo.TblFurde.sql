USE [C:\USERS\NEX\SOURCE\REPOS\RUBY\RUBY\RUBYDB.MDF]
GO

/****** Object: Table [dbo].[TblFurde] Script Date: 08/06/2017 9:21:51 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TblFurde] (
    [Fid]                INT            IDENTITY (1, 1) NOT NULL,
    [Sasia_gr_furde]     FLOAT (53)     NULL,
    [Cmimi_per_gr_furde] FLOAT (53)     NULL,
    [Cmimi_total_furde]  FLOAT (53)     NULL,
    [Data_blerjes]       DATETIME       NULL,
    [Pershkrimi]         NVARCHAR (MAX) NULL
);


