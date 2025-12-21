CREATE TABLE [dbo].[Category] (
    [ID]          INT           IDENTITY (1, 1) NOT NULL,
    [Category]    VARCHAR (100) NOT NULL,
    [Subcategory] VARCHAR (100) NOT NULL,
    [UOM]         VARCHAR (50)  NOT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);

