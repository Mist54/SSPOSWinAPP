CREATE TABLE [dbo].[Seating] (
    [ID]              INT          IDENTITY (1, 1) NOT NULL,
    [TableNumber]     VARCHAR (10) NOT NULL,
    [Capacity]        INT          NOT NULL,
    [IsReserved]      BIT          DEFAULT ((0)) NOT NULL,
    [ReservationTime] DATETIME     NULL,
    [Status]          VARCHAR (20) DEFAULT ('Available') NULL,
    [CreatedBy]       VARCHAR (50) NOT NULL,
    [CreatedDate]     DATETIME     DEFAULT (getdate()) NULL,
    [UpdatedBy]       VARCHAR (50) NULL,
    [UpdatedDate]     DATETIME     NULL,
    [IsDeleted]       BIT          DEFAULT ((0)) NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);

