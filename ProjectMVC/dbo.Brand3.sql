CREATE TABLE [dbo].[Brand3]
(
[id] [int] NOT NULL IDENTITY(1, 1),
[Brand Name] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Brand3] ADD CONSTRAINT [PK_Brand3] PRIMARY KEY CLUSTERED ([id]) ON [PRIMARY]
GO
