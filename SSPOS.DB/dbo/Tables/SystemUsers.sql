CREATE TABLE [dbo].[SystemUsers] (
    [Id]           INT            IDENTITY (1, 1) NOT NULL,
    [Name]         NVARCHAR (100) NOT NULL,
    [Password]     NVARCHAR (255) NOT NULL,
    [Email]        NVARCHAR (255) NOT NULL,
    [Company]      NVARCHAR (255) NULL,
    [Role]         INT            NULL,
    [IsActive]     BIT            DEFAULT ((1)) NOT NULL,
    [CreatedBy]    NVARCHAR (100) NULL,
    [CreatedDate]  DATETIME       DEFAULT (getdate()) NULL,
    [ModifiedBy]   NVARCHAR (100) NULL,
    [ModifiedDate] DATETIME       NULL,
    [IsDeleted]    BIT            DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CHECK ([Role]>=(0) AND [Role]<=(10)),
    UNIQUE NONCLUSTERED ([Email] ASC)
);

