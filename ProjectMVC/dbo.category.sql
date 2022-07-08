CREATE TABLE [dbo].[category]
(
[id] [int] NOT NULL IDENTITY(1, 1),
[Category Name] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[category] ADD CONSTRAINT [PK_category] PRIMARY KEY CLUSTERED ([id]) ON [PRIMARY]
GO
