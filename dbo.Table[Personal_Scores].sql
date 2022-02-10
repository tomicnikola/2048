CREATE TABLE [dbo].[Personal_Scores] (
    [PersonalScoreID] INT           IDENTITY (1, 1) NOT NULL,
    [Score]           INT           NOT NULL,
    [DateAndTime]     DATETIME2 (7) NOT NULL,
    [NumberOfMoves]   INT           NOT NULL,
    [TimePlayed]      NVARCHAR (50) NOT NULL,
    [PL_ID]           INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([PersonalScoreID] ASC),
    CONSTRAINT [FK_Personal_Scores_Players] FOREIGN KEY ([PL_ID]) REFERENCES [dbo].[Players] ([PlayerID])
);

