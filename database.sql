USE [college]
GO

/****** Object:  Table [dbo].[Courses]    Script Date: 09/11/2020 17:02:04 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Courses](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[Credits] [int] NOT NULL
) ON [PRIMARY]
GO

USE [college]
GO

/****** Object:  Table [dbo].[Enrolments]    Script Date: 09/11/2020 17:03:56 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Enrolments](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[StudentID] [int] NOT NULL,
	[CourseID] [int] NOT NULL,
	[Grade] [int] NULL
) ON [PRIMARY]
GO

USE [college]
GO

/****** Object:  Table [dbo].[Students]    Script Date: 09/11/2020 17:05:44 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Students](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[LastName] [nvarchar](max) NULL,
	[FirstName] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.Students] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

