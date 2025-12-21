CREATE TABLE [dbo].[OrderDetail] (
    [Id]          INT             IDENTITY (1, 1) NOT NULL,
    [OrderId]     INT             NOT NULL,
    [ProductId]   INT             NOT NULL,
    [Price]       DECIMAL (18, 2) NOT NULL,
    [Qty]         INT             NOT NULL,
    [Status]      VARCHAR (50)    NOT NULL,
    [CreatedBy]   VARCHAR (50)    NOT NULL,
    [CreatedDate] DATETIME        DEFAULT (getdate()) NOT NULL,
    [UpdatedBy]   VARCHAR (50)    NOT NULL,
    [UpdatedDate] DATETIME        DEFAULT (getdate()) NOT NULL,
    [IsDeleted]   BIT             DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

