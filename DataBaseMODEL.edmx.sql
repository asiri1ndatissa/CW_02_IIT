
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/16/2021 14:45:24
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


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


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