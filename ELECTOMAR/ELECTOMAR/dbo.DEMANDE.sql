USE [DEMANDE]
GO

/****** Object: Table [dbo].[DEMANDE] Script Date: 9/12/2018 12:04:03 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[DEMANDE] (
    [Nom]        CHAR (30) NOT NULL,
    [Prenom]     CHAR (30) NOT NULL,
    [Tel]        INT       NOT NULL,
    [Nomsocieté] CHAR (30) NOT NULL,
    [adresse]    CHAR (30) NOT NULL,
    [ti]         BIT       NOT NULL,
    [tx]         BIT       NOT NULL,
    [tp]         BIT       NOT NULL,
    [cf]         BIT       NOT NULL
);


