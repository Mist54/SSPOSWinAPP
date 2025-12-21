CREATE TABLE [dbo].[DeletedProduct] (
    [ID]           INT             NULL,
    [ProductName]  VARCHAR (255)   NULL,
    [Code]         INT             NULL,
    [MRP]          DECIMAL (10, 2) NULL,
    [CategoryID]   INT             NULL,
    [RegularPrice] DECIMAL (10, 2) NULL,
    [DirectPrice]  DECIMAL (10, 2) NULL,
    [OutsidePrice] DECIMAL (10, 2) NULL,
    [CreatedBy]    VARCHAR (100)   NULL,
    [CreatedDate]  DATETIME        NULL,
    [ModifiedBy]   VARCHAR (100)   NULL,
    [ModifiedDate] DATETIME        NULL
);

