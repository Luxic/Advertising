
CREATE TABLE  [DCForm](
	[ID] [INT] IDENTITY(1,1) NOT NULL,
	[Name] [VARCHAR](255) NULL,
	[LinkID] [INT] NOT NULL,
	[Active] [BIT] NOT NULL,
 CONSTRAINT [PK_Form] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE .[DCForm] ADD  CONSTRAINT [DF_Form_Active]  DEFAULT ((1)) FOR [Active]
GO

ALTER TABLE [DCForm]  WITH CHECK ADD  CONSTRAINT [FK_Form_Link] FOREIGN KEY([LinkID])
REFERENCES  [DCLink] ([ID])
GO

ALTER TABLE dbo.[DCForm] CHECK CONSTRAINT [FK_Form_Link]
GO


INSERT INTO  [dbo].[DCForm] (Name,DCLinkID,Active) VALUES ('Moji oglasi', 8,1)

SELECT TOP 1000 * FROM [dbo].[DCForm]