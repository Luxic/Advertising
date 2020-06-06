
CREATE TABLE [DCLink](
	[ID] [INT] IDENTITY(1,1) NOT NULL,
	[Controller] [VARCHAR](1000) NOT NULL,
	[Action] [VARCHAR](1000) NOT NULL,
	[Name] [VARCHAR](100) NOT NULL,
	[Description] [VARCHAR](250) NULL,
	[DateCreated] [SMALLDATETIME] NOT NULL,
	[Active] [BIT] NOT NULL,
 CONSTRAINT [PK_Page] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [DCLink] ADD  CONSTRAINT [DF_Page_DateCreated]  DEFAULT (GETDATE()) FOR [DateCreated]
GO

ALTER TABLE [DCLink] ADD  CONSTRAINT [DF_Page_Active]  DEFAULT ((1)) FOR [Active]
GO


INSERT INTO [dbo].[DCLink] (controller, [Action],[Name],[Description],[DateCreated],[Active])
VALUES ( 'Home','Index','Home','',GETDATE(),1)
INSERT INTO [dbo].[DCLink] (controller, [Action],[Name],[Description],[DateCreated],[Active])
VALUES ( 'Home','Index','Home','',GETDATE(),1)
SELECT SCOPE_IDENTITY()