USE [Lab2_Home]
GO
/****** Object:  Table [dbo].[Course]    Script Date: 1/28/2024 10:58:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Course](
	[Course_ID] [nchar](10) NULL,
	[Course_Name] [nvarchar](max) NULL,
	[Student_Name] [nvarchar](max) NULL,
	[Teacher_Name] [nvarchar](max) NULL,
	[Semester] [nchar](10) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Result]    Script Date: 1/28/2024 10:58:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Result](
	[Student_ID] [nchar](10) NULL,
	[Student_Name] [nvarchar](max) NULL,
	[Course_Name] [nvarchar](max) NULL,
	[Marks] [nchar](10) NULL,
	[Grade] [nchar](10) NULL,
	[Section] [nchar](10) NULL,
	[Semester] [nchar](10) NULL,
	[Session] [nchar](10) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 1/28/2024 10:58:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[RegistrationNumber] [nvarchar](max) NULL,
	[Name] [nvarchar](max) NULL,
	[Department] [nvarchar](max) NULL,
	[Session] [nvarchar](max) NULL,
	[Address] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[Course] ([Course_ID], [Course_Name], [Student_Name], [Teacher_Name], [Semester]) VALUES (N'232       ', N'CS', N'Waleed Ahmed', N'Saad Malik', N'4th       ')
GO
INSERT [dbo].[Student] ([RegistrationNumber], [Name], [Department], [Session], [Address]) VALUES (N'41', N'Waleed Ahmed', N'CS', N'2022', N'Punjab, Lahore')
GO
