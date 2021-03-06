USE [PSI]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 2022/2/14 下午 04:05:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ID] [varchar](3) NOT NULL,
	[Name] [nvarchar](10) NOT NULL,
	[Price] [decimal](18, 0) NOT NULL,
	[Type] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Purchase]    Script Date: 2022/2/14 下午 04:05:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Purchase](
	[ID] [char](10) NOT NULL,
	[ProductID] [varchar](3) NOT NULL,
	[Count] [int] NOT NULL,
	[Date] [datetime] NOT NULL,
	[Total] [decimal](18, 0) NOT NULL,
	[Creator] [nvarchar](10) NOT NULL,
	[CreateTime] [datetime] NOT NULL,
	[Isdelete] [bit] NOT NULL,
	[SerialNumber] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_Purchase] PRIMARY KEY CLUSTERED 
(
	[SerialNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 2022/2/14 下午 04:05:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Account] [nchar](10) NOT NULL,
	[PWD] [nchar](10) NOT NULL,
	[Name] [nchar](10) NOT NULL,
	[Level] [int] NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Products] ([ID], [Name], [Price], [Type]) VALUES (N'P01', N'肥皂', CAST(100 AS Decimal(18, 0)), N'A')
INSERT [dbo].[Products] ([ID], [Name], [Price], [Type]) VALUES (N'P02', N'手機', CAST(200 AS Decimal(18, 0)), N'A')
INSERT [dbo].[Products] ([ID], [Name], [Price], [Type]) VALUES (N'P03', N'水壺', CAST(300 AS Decimal(18, 0)), N'B')
INSERT [dbo].[Products] ([ID], [Name], [Price], [Type]) VALUES (N'P04', N'衛生紙', CAST(400 AS Decimal(18, 0)), N'B')
INSERT [dbo].[Products] ([ID], [Name], [Price], [Type]) VALUES (N'P05', N'紅茶', CAST(500 AS Decimal(18, 0)), N'C')
INSERT [dbo].[Products] ([ID], [Name], [Price], [Type]) VALUES (N'P06', N'綠茶', CAST(600 AS Decimal(18, 0)), N'C')
INSERT [dbo].[Products] ([ID], [Name], [Price], [Type]) VALUES (N'P07', N'烏龍茶', CAST(700 AS Decimal(18, 0)), N'D')
INSERT [dbo].[Products] ([ID], [Name], [Price], [Type]) VALUES (N'P08', N'背包', CAST(800 AS Decimal(18, 0)), N'D')
INSERT [dbo].[Products] ([ID], [Name], [Price], [Type]) VALUES (N'P09', N'行李箱', CAST(900 AS Decimal(18, 0)), N'E')
INSERT [dbo].[Products] ([ID], [Name], [Price], [Type]) VALUES (N'P10', N'電扇', CAST(1000 AS Decimal(18, 0)), N'E')
GO
SET IDENTITY_INSERT [dbo].[Purchase] ON 

INSERT [dbo].[Purchase] ([ID], [ProductID], [Count], [Date], [Total], [Creator], [CreateTime], [Isdelete], [SerialNumber]) VALUES (N'ASN-001   ', N'P01', 1, CAST(N'2021-07-03T10:12:00.000' AS DateTime), CAST(100 AS Decimal(18, 0)), N'Jack      ', CAST(N'2021-07-03T10:12:43.000' AS DateTime), 1, 1039)
INSERT [dbo].[Purchase] ([ID], [ProductID], [Count], [Date], [Total], [Creator], [CreateTime], [Isdelete], [SerialNumber]) VALUES (N'ASN-002   ', N'P01', 3, CAST(N'2021-07-03T10:12:00.000' AS DateTime), CAST(300 AS Decimal(18, 0)), N'Jack      ', CAST(N'2021-07-03T10:12:59.000' AS DateTime), 1, 1040)
INSERT [dbo].[Purchase] ([ID], [ProductID], [Count], [Date], [Total], [Creator], [CreateTime], [Isdelete], [SerialNumber]) VALUES (N'ASN-002   ', N'P02', 1, CAST(N'2021-07-03T10:12:00.000' AS DateTime), CAST(200 AS Decimal(18, 0)), N'Jack      ', CAST(N'2021-07-03T10:12:59.000' AS DateTime), 1, 1041)
INSERT [dbo].[Purchase] ([ID], [ProductID], [Count], [Date], [Total], [Creator], [CreateTime], [Isdelete], [SerialNumber]) VALUES (N'ASN-003   ', N'P01', 1, CAST(N'2021-07-03T10:13:00.000' AS DateTime), CAST(100 AS Decimal(18, 0)), N'Jack      ', CAST(N'2021-07-03T10:13:40.000' AS DateTime), 1, 1042)
INSERT [dbo].[Purchase] ([ID], [ProductID], [Count], [Date], [Total], [Creator], [CreateTime], [Isdelete], [SerialNumber]) VALUES (N'ASN-003   ', N'P07', 4, CAST(N'2021-07-03T10:13:00.000' AS DateTime), CAST(2800 AS Decimal(18, 0)), N'Jack      ', CAST(N'2021-07-03T10:13:40.000' AS DateTime), 1, 1043)
INSERT [dbo].[Purchase] ([ID], [ProductID], [Count], [Date], [Total], [Creator], [CreateTime], [Isdelete], [SerialNumber]) VALUES (N'ASN-004   ', N'P01', 1, CAST(N'2021-07-03T10:15:00.000' AS DateTime), CAST(100 AS Decimal(18, 0)), N'Jack      ', CAST(N'2021-07-03T10:15:46.000' AS DateTime), 0, 1044)
SET IDENTITY_INSERT [dbo].[Purchase] OFF
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([ID], [Account], [PWD], [Name], [Level]) VALUES (1, N'Manager   ', N'123456    ', N'Jack      ', 0)
INSERT [dbo].[User] ([ID], [Account], [PWD], [Name], [Level]) VALUES (2, N'Staff     ', N'123456    ', N'Jeff      ', 1)
SET IDENTITY_INSERT [dbo].[User] OFF
GO
ALTER TABLE [dbo].[Purchase]  WITH CHECK ADD  CONSTRAINT [FK_Purchase_Products1] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Products] ([ID])
GO
ALTER TABLE [dbo].[Purchase] CHECK CONSTRAINT [FK_Purchase_Products1]
GO
