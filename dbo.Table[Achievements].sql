CREATE TABLE [dbo].[Achievements] (
    [AchievementID]          INT IDENTITY (1, 1) NOT NULL,
    [CompletedGame]          BIT NOT NULL,
    [BetterThanAverageMoves] BIT NOT NULL,
    [BetterThanAverageTime]  BIT NOT NULL,
    [PA_ID]                  INT NOT NULL,
    PRIMARY KEY CLUSTERED ([AchievementID] ASC),
    CONSTRAINT [FK_Achievements_Players] FOREIGN KEY ([PA_ID]) REFERENCES [dbo].[Players] ([PlayerID])
);

