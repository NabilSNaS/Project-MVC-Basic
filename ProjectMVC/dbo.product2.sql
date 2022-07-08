CREATE TABLE [dbo].[product2]
(
[id] [int] NOT NULL IDENTITY(1, 1),
[proname] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[cat_id] [int] NULL,
[brand_id] [int] NULL,
[quntity] [decimal] (18, 2) NULL,
[price] [decimal] (18, 2) NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[product2] ADD CONSTRAINT [PK_product2] PRIMARY KEY CLUSTERED ([id]) ON [PRIMARY]
GO
ALTER TABLE [dbo].[product2] ADD CONSTRAINT [FK_product2_Brand3] FOREIGN KEY ([brand_id]) REFERENCES [dbo].[Brand3] ([id])
GO
ALTER TABLE [dbo].[product2] ADD CONSTRAINT [FK_product2_category] FOREIGN KEY ([cat_id]) REFERENCES [dbo].[category] ([id])
GO
