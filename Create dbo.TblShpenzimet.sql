USE [C:\USERS\NEX\SOURCE\REPOS\RUBY\RUBY\RUBYDB.MDF]
GO

/****** Object: Table [dbo].[TblShpenzimet] Script Date: 08/06/2017 9:22:26 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TblShpenzimet] (
    [ShiID]        INT            IDENTITY (1, 1) NOT NULL,
    [Rryma_fat]    FLOAT (53)     NOT NULL,
    [Uji_fat]      FLOAT (53)     NOT NULL,
    [Tatimi_fat]   FLOAT (53)     NOT NULL,
    [Data_fatures] DATETIME       NULL,
    [Pershkrimi]   NVARCHAR (MAX) NULL
);


