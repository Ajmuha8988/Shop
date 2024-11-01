USE [shop]
GO
/****** Object:  Table [dbo].[ORDERS]    Script Date: 28.10.2024 16:03:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ORDERS](
	[ID_ORDER] [int] IDENTITY(1,1) NOT NULL,
	[ID_USER] [int] NOT NULL,
	[ORDERTIME] [datetime2](7) NOT NULL,
	[NUMBER] [int] NOT NULL,
	[ID_PRODUCT] [int] NOT NULL,
 CONSTRAINT [PK_ORDERS] PRIMARY KEY CLUSTERED 
(
	[ID_ORDER] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PRODUCTS]    Script Date: 28.10.2024 16:03:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PRODUCTS](
	[ID_PRODUCT] [int] IDENTITY(1,1) NOT NULL,
	[NAME] [nchar](30) NOT NULL,
	[PRICE] [int] NOT NULL,
	[COUNT] [int] NOT NULL,
	[MARK] [int] NOT NULL,
	[DESCRIPTION] [nchar](100) NOT NULL,
	[ID_CATALOG] [int] NOT NULL,
 CONSTRAINT [PK_PRODUCTS] PRIMARY KEY CLUSTERED 
(
	[ID_PRODUCT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[USERS]    Script Date: 28.10.2024 16:03:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[USERS](
	[ID_USER] [int] IDENTITY(1,1) NOT NULL,
	[SURNAME] [nchar](30) NOT NULL,
	[PATRONYMIC] [nchar](30) NOT NULL,
	[NAME] [nchar](30) NOT NULL,
	[PHONE] [int] NULL,
	[EMAIL] [nchar](30) NULL,
	[URL] [nchar](30) NULL,
	[USERSTATUS] [nchar](7) NOT NULL,
 CONSTRAINT [PK_USERS] PRIMARY KEY CLUSTERED 
(
	[ID_USER] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[ViewORDER]    Script Date: 28.10.2024 16:03:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[ViewORDER]
AS
SELECT dbo.PRODUCTS.NAME, dbo.PRODUCTS.DESCRIPTION, dbo.PRODUCTS.PRICE, dbo.PRODUCTS.COUNT, dbo.ORDERS.ORDERTIME, dbo.USERS.SURNAME, dbo.USERS.NAME AS Expr1, dbo.USERS.PATRONYMIC, 
                  dbo.USERS.PHONE
FROM     dbo.PRODUCTS INNER JOIN
                  dbo.ORDERS ON dbo.PRODUCTS.ID_PRODUCT = dbo.ORDERS.ID_PRODUCT INNER JOIN
                  dbo.USERS ON dbo.ORDERS.ID_USER = dbo.USERS.ID_USER
GO
/****** Object:  Table [dbo].[CATALOGS]    Script Date: 28.10.2024 16:03:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CATALOGS](
	[ID_CATALOG] [int] IDENTITY(1,1) NOT NULL,
	[NAME] [nchar](30) NOT NULL,
 CONSTRAINT [PK_CATALOGS] PRIMARY KEY CLUSTERED 
(
	[ID_CATALOG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[CATALOGS] ON 

INSERT [dbo].[CATALOGS] ([ID_CATALOG], [NAME]) VALUES (1, N'Материнская плата             ')
INSERT [dbo].[CATALOGS] ([ID_CATALOG], [NAME]) VALUES (2, N'Видеокарта                    ')
INSERT [dbo].[CATALOGS] ([ID_CATALOG], [NAME]) VALUES (1002, N'Оперативная память            ')
INSERT [dbo].[CATALOGS] ([ID_CATALOG], [NAME]) VALUES (2002, N'Монитор                       ')
SET IDENTITY_INSERT [dbo].[CATALOGS] OFF
GO
SET IDENTITY_INSERT [dbo].[ORDERS] ON 

INSERT [dbo].[ORDERS] ([ID_ORDER], [ID_USER], [ORDERTIME], [NUMBER], [ID_PRODUCT]) VALUES (6, 1, CAST(N'2025-10-25T14:00:02.0000000' AS DateTime2), 412421, 2)
INSERT [dbo].[ORDERS] ([ID_ORDER], [ID_USER], [ORDERTIME], [NUMBER], [ID_PRODUCT]) VALUES (9, 2, CAST(N'2004-10-20T19:20:02.0000000' AS DateTime2), 42352, 3)
SET IDENTITY_INSERT [dbo].[ORDERS] OFF
GO
SET IDENTITY_INSERT [dbo].[PRODUCTS] ON 

INSERT [dbo].[PRODUCTS] ([ID_PRODUCT], [NAME], [PRICE], [COUNT], [MARK], [DESCRIPTION], [ID_CATALOG]) VALUES (2, N'Gigabyte                      ', 99, 10, 4, N'flansdfna                                                                                           ', 1)
INSERT [dbo].[PRODUCTS] ([ID_PRODUCT], [NAME], [PRICE], [COUNT], [MARK], [DESCRIPTION], [ID_CATALOG]) VALUES (3, N'Msi                           ', 100, 40, 4, N'asdsa                                                                                               ', 2)
INSERT [dbo].[PRODUCTS] ([ID_PRODUCT], [NAME], [PRICE], [COUNT], [MARK], [DESCRIPTION], [ID_CATALOG]) VALUES (1002, N'AMD                           ', 100, 50, 3, N'fdsfa                                                                                               ', 1)
SET IDENTITY_INSERT [dbo].[PRODUCTS] OFF
GO
SET IDENTITY_INSERT [dbo].[USERS] ON 

INSERT [dbo].[USERS] ([ID_USER], [SURNAME], [PATRONYMIC], [NAME], [PHONE], [EMAIL], [URL], [USERSTATUS]) VALUES (1, N'Борлаков                      ', N'Курманалиевич                 ', N'Мухамат                       ', 124412, N'Borlakovmuhammad@mail.ru      ', NULL, N'active ')
INSERT [dbo].[USERS] ([ID_USER], [SURNAME], [PATRONYMIC], [NAME], [PHONE], [EMAIL], [URL], [USERSTATUS]) VALUES (2, N'Дурсунов                      ', N'Елчинович                     ', N'Орхан                         ', 322352, N'Dursunov@mail.ru              ', NULL, N'passive')
INSERT [dbo].[USERS] ([ID_USER], [SURNAME], [PATRONYMIC], [NAME], [PHONE], [EMAIL], [URL], [USERSTATUS]) VALUES (4, N'Салпагаров                    ', N'Курманалиевич                 ', N'Ахмат                         ', 412512, N'Salpagarov@mail.ru            ', NULL, N'active ')
INSERT [dbo].[USERS] ([ID_USER], [SURNAME], [PATRONYMIC], [NAME], [PHONE], [EMAIL], [URL], [USERSTATUS]) VALUES (1003, N'EQW                           ', N'FAS                           ', N'ASD                           ', 12312, N'ASCA                          ', NULL, N'ACTIVE ')
SET IDENTITY_INSERT [dbo].[USERS] OFF
GO
ALTER TABLE [dbo].[ORDERS]  WITH CHECK ADD  CONSTRAINT [FK_ORDERS_PRODUCTS] FOREIGN KEY([ID_PRODUCT])
REFERENCES [dbo].[PRODUCTS] ([ID_PRODUCT])
GO
ALTER TABLE [dbo].[ORDERS] CHECK CONSTRAINT [FK_ORDERS_PRODUCTS]
GO
ALTER TABLE [dbo].[ORDERS]  WITH CHECK ADD  CONSTRAINT [FK_ORDERS_USERS] FOREIGN KEY([ID_USER])
REFERENCES [dbo].[USERS] ([ID_USER])
GO
ALTER TABLE [dbo].[ORDERS] CHECK CONSTRAINT [FK_ORDERS_USERS]
GO
ALTER TABLE [dbo].[PRODUCTS]  WITH CHECK ADD  CONSTRAINT [FK_PRODUCTS_CATALOGS] FOREIGN KEY([ID_CATALOG])
REFERENCES [dbo].[CATALOGS] ([ID_CATALOG])
GO
ALTER TABLE [dbo].[PRODUCTS] CHECK CONSTRAINT [FK_PRODUCTS_CATALOGS]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "PRODUCTS"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 249
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "USERS"
            Begin Extent = 
               Top = 7
               Left = 297
               Bottom = 170
               Right = 498
            End
            DisplayFlags = 280
            TopColumn = 4
         End
         Begin Table = "ORDERS"
            Begin Extent = 
               Top = 7
               Left = 546
               Bottom = 170
               Right = 747
            End
            DisplayFlags = 280
            TopColumn = 1
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 10
         Width = 284
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ViewORDER'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ViewORDER'
GO
