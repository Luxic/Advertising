--   DROP TABLE [Menu.Form]

CREATE TABLE  [Menu.Form](
	[ID] [INT] IDENTITY(1,1) NOT NULL,
	[FormID] [INT] NULL, 
	[ParentID] [INT] NULL,
	[Text] [VARCHAR](255) NULL,
	[Group] [SMALLINT] NULL,
	[Order] [SMALLINT] NULL,
	[Active] [BIT] NOT NULL,
 CONSTRAINT [PK_Form.Menu] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE  [Menu.Form] ADD  CONSTRAINT [DF_Form.Menu_Active]  DEFAULT ((1)) FOR [Active]
GO

ALTER TABLE  [Menu.Form]  WITH CHECK ADD  CONSTRAINT [FK_Menu.Form_Form] FOREIGN KEY([FormID])
REFERENCES  [DCForm] ([ID])
GO

ALTER TABLE  [Menu.Form] CHECK CONSTRAINT [FK_Menu.Form_Form]
GO

ALTER TABLE  [Menu.Form]  WITH CHECK ADD  CONSTRAINT [FK_Menu.Form_Menu.Form] FOREIGN KEY([ParentID])
REFERENCES  [Menu.Form] ([ID])
GO

ALTER TABLE  [Menu.Form] CHECK CONSTRAINT [FK_Menu.Form_Menu.Form]
GO

INSERT INTO [dbo].[MenuForm]  ([DCFormID],[ParentID],[Text],[Group],[Order],[Active]) VALUES(8,3,'Child od 3',NULL,NULL,1)
 

 UPDATE  [dbo].[MenuForm]
 SET Text = '6 - 4', [ParentID] = 4
 WHERE ID = 6


 SELECT TOP 1000 * 
 FROM  [dbo].[MenuForm] as mf
 INNER JOIN  [dbo].[DCForm] AS f
	ON f.ID = mf.DCFormId

	DELETE FROM [dbo].[MenuForm]
	WHERE ID = 5