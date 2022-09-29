CREATE TABLE [dbo].[Documents] (
    Id BIGINT NOT NULL IDENTITY(1,1),
    Title VARCHAR(255) NOT NULL,
    Section VARCHAR(255) NOT NULL,
    Position VARCHAR(255) NOT NULL,
    Author VARCHAR(255) NOT NULL,
    ReleaseYear INT NOT NULL,
     CONSTRAINT [PK_Documents] PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[Dvd](
    Id BIGINT NOT NULL,
    duration INT NOT NULL,
    CONSTRAINT [PK_Dvd] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Dvd_Documents_Id] FOREIGN KEY ([Id]) REFERENCES [dbo].[Documents] ([Id])
);

CREATE TABLE [dbo].[Books](
    Id BIGINT NOT NULL,
    Page_number INT NOT NULL,
    CONSTRAINT [PK_Books] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Books_Documents_Id] FOREIGN KEY ([Id]) REFERENCES [dbo].[Documents] ([Id])
);
