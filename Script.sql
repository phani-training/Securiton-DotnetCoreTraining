﻿CREATE TABLE [dbo].[Authors](
	[AuthorID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](500) NOT NULL,
	[LastName] [nvarchar](500) NOT NULL,
 CONSTRAINT [PK_Authors] PRIMARY KEY CLUSTERED 
(
	[AuthorID] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
--------------------------------------------------------------------------------------------
CREATE TABLE [dbo].[Books](
	[BookID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](500) NOT NULL,
	[Year] [int] NOT NULL,
	[ISBN] [bigint] NOT NULL,
	[PublishedDate] [date] NOT NULL,
	[AuthorID] [int] NOT NULL,
	[Price] [smallint] NOT NULL,
 CONSTRAINT [PK_Books] PRIMARY KEY CLUSTERED 
(
	[BookID] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

---------------------------------------------------------------------------

SET IDENTITY_INSERT [dbo].[Authors] ON 
GO
INSERT [dbo].[Authors] ([AuthorID], [FirstName], [LastName]) VALUES (1, N'Hammad', N'Abbasi')
GO
INSERT [dbo].[Authors] ([AuthorID], [FirstName], [LastName]) VALUES (2, N'Matt', N'Haig')
GO
INSERT [dbo].[Authors] ([AuthorID], [FirstName], [LastName]) VALUES (3, N'Brit', N'Bennet')
GO
INSERT [dbo].[Authors] ([AuthorID], [FirstName], [LastName]) VALUES (4, N'Emily ', N'Henry')
GO
INSERT [dbo].[Authors] ([AuthorID], [FirstName], [LastName]) VALUES (5, N'Lucy ', N'Foley')
GO
INSERT [dbo].[Authors] ([AuthorID], [FirstName], [LastName]) VALUES (6, N'Jeanine ', N'Cummins')
GO
INSERT [dbo].[Authors] ([AuthorID], [FirstName], [LastName]) VALUES (7, N'Glennon ', N'Doyle')
GO
INSERT [dbo].[Authors] ([AuthorID], [FirstName], [LastName]) VALUES (8, N'Suzanne ', N'Collins')
GO
INSERT [dbo].[Authors] ([AuthorID], [FirstName], [LastName]) VALUES (9, N'Sarah J. ', N'Mass')
GO
INSERT [dbo].[Authors] ([AuthorID], [FirstName], [LastName]) VALUES (10, N'Rebecca', N'Serle')
GO
SET IDENTITY_INSERT [dbo].[Authors] OFF
GO

----------------------------------------------------------------------------------
SET IDENTITY_INSERT [dbo].[Books] ON 
GO
INSERT [dbo].[Books] ([BookID], [Title], [Year], [ISBN], [PublishedDate], [AuthorID], [Price]) VALUES (1, N'This is edited', 2020, 9782364580640, CAST(N'2020-12-02' AS Date), 1, 20)
GO
INSERT [dbo].[Books] ([BookID], [Title], [Year], [ISBN], [PublishedDate], [AuthorID], [Price]) VALUES (3, N'The Vanishing Half', 2020, 9782364580641, CAST(N'2020-11-03' AS Date), 2, 15)
GO
INSERT [dbo].[Books] ([BookID], [Title], [Year], [ISBN], [PublishedDate], [AuthorID], [Price]) VALUES (4, N'Beach Read', 2019, 9782364580636, CAST(N'2019-05-03' AS Date), 3, 31)
GO
INSERT [dbo].[Books] ([BookID], [Title], [Year], [ISBN], [PublishedDate], [AuthorID], [Price]) VALUES (5, N'The Guest List', 2020, 9782364580650, CAST(N'2020-09-09' AS Date), 4, 20)
GO
INSERT [dbo].[Books] ([BookID], [Title], [Year], [ISBN], [PublishedDate], [AuthorID], [Price]) VALUES (6, N'American Dirt', 2020, 9782364580660, CAST(N'2020-10-10' AS Date), 5, 12)
GO
INSERT [dbo].[Books] ([BookID], [Title], [Year], [ISBN], [PublishedDate], [AuthorID], [Price]) VALUES (7, N'Untamed ', 2020, 9782364580680, CAST(N'2020-07-10' AS Date), 6, 15)
GO
INSERT [dbo].[Books] ([BookID], [Title], [Year], [ISBN], [PublishedDate], [AuthorID], [Price]) VALUES (8, N'The Ballad of Songbirds and Snakes (The Hunger Games)', 2020, 9782364580699, CAST(N'2020-05-05' AS Date), 7, 20)
GO
INSERT [dbo].[Books] ([BookID], [Title], [Year], [ISBN], [PublishedDate], [AuthorID], [Price]) VALUES (9, N'House of Earth and Blood (Crescent City)', 2020, 9782364580666, CAST(N'2020-12-02' AS Date), 8, 22)
GO
INSERT [dbo].[Books] ([BookID], [Title], [Year], [ISBN], [PublishedDate], [AuthorID], [Price]) VALUES (10, N'In Five Years', 2020, 9782364580649, CAST(N'2020-11-03' AS Date), 9, 18)
GO
INSERT [dbo].[Books] ([BookID], [Title], [Year], [ISBN], [PublishedDate], [AuthorID], [Price]) VALUES (11, N'James Bond', 2020, 123456789, CAST(N'2021-11-18' AS Date), 5, 12)
GO
SET IDENTITY_INSERT [dbo].[Books] OFF
GO

---------------------------------------------------------------------
ALTER TABLE [dbo].[Books]  WITH CHECK ADD  CONSTRAINT [FK_Books_Authors] FOREIGN KEY([AuthorID])
REFERENCES [dbo].[Authors] ([AuthorID])
GO
ALTER TABLE [dbo].[Books] CHECK CONSTRAINT [FK_Books_Authors]
GO