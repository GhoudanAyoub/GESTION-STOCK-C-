USE [HOME]
GO

/****** Object: Table [dbo].[empoyes] Script Date: 9/12/2018 12:03:45 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[empoyes] (
    [Nom]              VARCHAR (30)  NOT NULL,
    [Prenom]           VARCHAR (30)  NOT NULL,
    [Gmail]            NVARCHAR (30) NOT NULL,
    [Telephone]        NUMERIC (18)  NOT NULL,
    [Adresse]          TEXT          NOT NULL,
    [CIN]              TEXT          NOT NULL,
    [CODE]             INT           NOT NULL,
    [Salaire]          INT           NOT NULL,
    [Fonctions]        NVARCHAR (30) NOT NULL,
    [Nomber_enfants]   INT           NOT NULL,
    [Genre]            VARCHAR (50)  NOT NULL,
    [Date_naissance]   DATETIME      NOT NULL,
    [Date_integration] DATETIME      NOT NULL
);


