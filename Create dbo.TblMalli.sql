USE [C:\USERS\NEX\SOURCE\REPOS\RUBY\RUBY\RUBYDB.MDF]
GO

/****** Object: Table [dbo].[TblMalli] Script Date: 08/06/2017 9:22:20 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TblMalli] (
    [Mid]          INT            IDENTITY (1, 1) NOT NULL,
    [Malli_Emri]   NVARCHAR (50)  NOT NULL,
    [Malli_Cmimi]  FLOAT (53)     NOT NULL,
    [Data_Shitjes] DATETIME       NOT NULL,
    [Pershkrimi]   NVARCHAR (MAX) NULL
);


