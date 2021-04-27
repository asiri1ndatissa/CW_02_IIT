
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/27/2021 14:55:04
-- Generated from EDMX file: C:\Users\Asiri\source\repos\CW_02\DataBaseMODEL.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [MyDatabase];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_TransactionPartyTransaction]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Transactions] DROP CONSTRAINT [FK_TransactionPartyTransaction];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[TransactionParties]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TransactionParties];
GO
IF OBJECT_ID(N'[dbo].[Transactions]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Transactions];
GO
IF OBJECT_ID(N'[dbo].[Events]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Events];
GO
IF OBJECT_ID(N'[dbo].[Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'TransactionParties'
CREATE TABLE [dbo].[TransactionParties] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Description] nvarchar(100)  NOT NULL,
    [JoiningDate] datetime  NOT NULL,
    [TransactionPartyName] nvarchar(35)  NOT NULL
);
GO

-- Creating table 'Transactions'
CREATE TABLE [dbo].[Transactions] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Amount] float  NOT NULL,
    [Date] datetime  NOT NULL,
    [TransactionType] nvarchar(max)  NOT NULL,
    [RecurrentType] nvarchar(max)  NOT NULL,
    [TransactionPartyId] int  NOT NULL
);
GO

-- Creating table 'Events'
CREATE TABLE [dbo].[Events] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Amount] float  NOT NULL,
    [Interval] nvarchar(max)  NOT NULL,
    [Type] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [Date] datetime  NOT NULL
);
GO

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [Id] int IDENTITY(1,1) NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'TransactionParties'
ALTER TABLE [dbo].[TransactionParties]
ADD CONSTRAINT [PK_TransactionParties]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Transactions'
ALTER TABLE [dbo].[Transactions]
ADD CONSTRAINT [PK_Transactions]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Events'
ALTER TABLE [dbo].[Events]
ADD CONSTRAINT [PK_Events]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [TransactionPartyId] in table 'Transactions'
ALTER TABLE [dbo].[Transactions]
ADD CONSTRAINT [FK_TransactionPartyTransaction]
    FOREIGN KEY ([TransactionPartyId])
    REFERENCES [dbo].[TransactionParties]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TransactionPartyTransaction'
CREATE INDEX [IX_FK_TransactionPartyTransaction]
ON [dbo].[Transactions]
    ([TransactionPartyId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------