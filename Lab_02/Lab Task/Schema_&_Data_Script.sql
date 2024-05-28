USE [Lab2]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 1/27/2024 8:15:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[RegistrationNumber] [nvarchar](max) NULL,
	[Name] [nvarchar](max) NULL,
	[Department] [nvarchar](max) NULL,
	[Session] [nvarchar](max) NULL,
	[CGPA] [nvarchar](max) NULL,
	[Address] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[Student] ([RegistrationNumber], [Name], [Department], [Session], [CGPA], [Address]) VALUES (N'01', N'Saad Malik', N'Computer Science', N'2022', N'3.9', N'Punjab, Lahore')
GO
