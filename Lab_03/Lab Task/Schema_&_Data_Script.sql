USE [Lab_03]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 1/30/2024 9:14:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[RegNo] [nvarchar](max) NULL,
	[FirstName] [nvarchar](max) NULL,
	[LastName] [nvarchar](max) NULL,
	[GPA] [nvarchar](max) NULL,
	[Contact] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[Student] ([RegNo], [FirstName], [LastName], [GPA], [Contact]) VALUES (N'2022-CS-01', N'Saad', N'Malik', N'3.9', N'+92 320 1479325')
INSERT [dbo].[Student] ([RegNo], [FirstName], [LastName], [GPA], [Contact]) VALUES (N'2022-CS-41', N'Waleed', N'Ahmed', NULL, N'+92 319 4674268')
INSERT [dbo].[Student] ([RegNo], [FirstName], [LastName], [GPA], [Contact]) VALUES (N'2022-CS-46', N'Muhammad', N'Danish', N'3.5', N'+92 312 4778735')
INSERT [dbo].[Student] ([RegNo], [FirstName], [LastName], [GPA], [Contact]) VALUES (N'2022-CS-47', N'Arsal', N'Noor', NULL, N'+92 355 8560921')
INSERT [dbo].[Student] ([RegNo], [FirstName], [LastName], [GPA], [Contact]) VALUES (N'2022-CS-48', N'Khurram', N'Gill', N'3.1', N'+92 307 8014754')
GO
