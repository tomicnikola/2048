CREATE TABLE [dbo].[Players] (
    [PlayerID] INT           IDENTITY (1, 1) NOT NULL,
    [Username] NVARCHAR (50) NOT NULL,
    [Password] NVARCHAR (50) NOT NULL,
    [IGN]      NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([PlayerID] ASC)
);

