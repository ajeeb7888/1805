CREATE TABLE [dbo].[Claim Details]
(
	[Claim No] INT NOT NULL PRIMARY KEY, 
    [Policy No] INT NULL, 
    [Policy Start Date] VARCHAR(50) NULL, 
    [Policy End Date] VARCHAR(50) NULL, 
    [Customer Name] VARCHAR(50) NULL, 
    [Place of Accident ] VARCHAR(50) NULL, 
    [Date of Accident] VARCHAR(50) NULL, 
    [Insured Amount] INT NULL, 
    [Claimable Amount] INT NULL
)
