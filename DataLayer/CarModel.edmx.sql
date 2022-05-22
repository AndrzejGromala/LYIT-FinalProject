
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/19/2022 09:27:27
-- Generated from EDMX file: C:\Users\Andrzej\Desktop\Copy-TestingProjectForCollege - Copy\CarCollectionWithDB\DataLayer\CarModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [CarCollectionWithDB_db];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[tblCarCollections]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tblCarCollections];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'tblCarCollections'
CREATE TABLE [dbo].[tblCarCollections] (
    [CarId] int IDENTITY(1,1) NOT NULL,
    [CarMkModel] varchar(50)  NOT NULL,
    [Engine] varchar(50)  NOT NULL,
    [BodyType] varchar(50)  NOT NULL,
    [Transmission] varchar(50)  NOT NULL,
    [Year] int  NOT NULL,
    [Color] varchar(50)  NOT NULL,
    [Value] varchar(50)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [CarId] in table 'tblCarCollections'
ALTER TABLE [dbo].[tblCarCollections]
ADD CONSTRAINT [PK_tblCarCollections]
    PRIMARY KEY CLUSTERED ([CarId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------