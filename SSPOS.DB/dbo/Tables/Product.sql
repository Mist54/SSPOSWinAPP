CREATE TABLE [dbo].[Product] (
    [ID]           INT             IDENTITY (1, 1) NOT NULL,
    [ProductName]  VARCHAR (255)   NOT NULL,
    [Code]         INT             NULL,
    [MRP]          DECIMAL (10, 2) DEFAULT ((0.00)) NULL,
    [CategoryID]   INT             NOT NULL,
    [RegularPrice] DECIMAL (10, 2) DEFAULT ((0.00)) NULL,
    [DirectPrice]  DECIMAL (10, 2) DEFAULT ((0.00)) NULL,
    [OutsidePrice] DECIMAL (10, 2) DEFAULT ((0.00)) NULL,
    [CreatedBy]    VARCHAR (100)   NOT NULL,
    [CreatedDate]  DATETIME        DEFAULT (getdate()) NOT NULL,
    [ModifiedBy]   VARCHAR (100)   NOT NULL,
    [ModifiedDate] DATETIME        DEFAULT (getdate()) NOT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC),
    UNIQUE NONCLUSTERED ([Code] ASC)
);

