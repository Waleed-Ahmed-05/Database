USE [TestDB_2020_CS_41]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 1/27/2024 12:42:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[Id] [nchar](10) NULL,
	[Name] [nchar](10) NULL,
	[Department] [nchar](10) NULL,
	[Session] [nchar](10) NULL,
	[Section] [nchar](10) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Student] ([Id], [Name], [Department], [Session], [Section]) VALUES (N'01        ', N'Saad      ', N'CS        ', N'2022      ', N'A         ')
INSERT [dbo].[Student] ([Id], [Name], [Department], [Session], [Section]) VALUES (N'41        ', N'Waleed    ', N'CS        ', N'2022      ', N'A         ')
INSERT [dbo].[Student] ([Id], [Name], [Department], [Session], [Section]) VALUES (N'46        ', N'Danish    ', N'CS        ', N'2022      ', N'A         ')
INSERT [dbo].[Student] ([Id], [Name], [Department], [Session], [Section]) VALUES (N'47        ', N'Arsal     ', N'CS        ', N'2022      ', N'A         ')
INSERT [dbo].[Student] ([Id], [Name], [Department], [Session], [Section]) VALUES (N'48        ', N'Khurram   ', N'CS        ', N'2022      ', N'A         ')
GO
