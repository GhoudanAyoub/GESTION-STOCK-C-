USE [HOME]
GO

/****** Object: Table [dbo].[home] Script Date: 9/12/2018 12:02:26 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[home] (
    [Nom]         CHAR (50) NOT NULL,
    [Prenom]      CHAR (50) NOT NULL,
    [Username]    CHAR (50) NOT NULL,
    [gmail]       CHAR (50) NOT NULL,
    [mot_de_pass] CHAR (50) NOT NULL
);


