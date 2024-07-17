CREATE TABLE [dbo].[Student] (
    [Id]         INT           IDENTITY (1, 1) NOT NULL,
    [AddedDate]  DATETIME      NULL,
    [FirstName]  VARCHAR (50)  NULL,
    [LastName]   VARCHAR (50)  NULL,
    [Gender]     VARCHAR (10)  NULL,
    [FatherName] VARCHAR (50)  NULL,
    [MotherName] VARCHAR (50)  NULL,
    [Address]    VARCHAR (500) NULL,
    [City]       VARCHAR (50)  NULL,
    [Country]    VARCHAR (50)  NULL,
    [Phone]      BIGINT        NULL,
    [Status]     CHAR (1)      NULL,
    CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED ([Id] ASC)
);

