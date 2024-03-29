USE [master]
GO
/****** Object:  Database [Cz.Project]    Script Date: 24/11/2023 21:07:26 ******/
CREATE DATABASE [Cz.Project]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Cz.Project', FILENAME = N'F:\SQL2022\MSSQL16.MSSQLSERVER\MSSQL\DATA\Cz.Project.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Cz.Project_log', FILENAME = N'F:\SQL2022\MSSQL16.MSSQLSERVER\MSSQL\DATA\Cz.Project_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Cz.Project] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Cz.Project].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Cz.Project] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Cz.Project] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Cz.Project] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Cz.Project] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Cz.Project] SET ARITHABORT OFF 
GO
ALTER DATABASE [Cz.Project] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Cz.Project] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Cz.Project] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Cz.Project] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Cz.Project] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Cz.Project] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Cz.Project] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Cz.Project] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Cz.Project] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Cz.Project] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Cz.Project] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Cz.Project] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Cz.Project] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Cz.Project] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Cz.Project] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Cz.Project] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Cz.Project] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Cz.Project] SET RECOVERY FULL 
GO
ALTER DATABASE [Cz.Project] SET  MULTI_USER 
GO
ALTER DATABASE [Cz.Project] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Cz.Project] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Cz.Project] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Cz.Project] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Cz.Project] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Cz.Project] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Cz.Project', N'ON'
GO
ALTER DATABASE [Cz.Project] SET QUERY_STORE = ON
GO
ALTER DATABASE [Cz.Project] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Cz.Project]
GO
/****** Object:  Table [dbo].[AdminUserHistorical]    Script Date: 24/11/2023 21:07:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AdminUserHistorical](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NULL,
	[CheckDigit] [nvarchar](max) NULL,
	[Name] [nvarchar](150) NOT NULL,
	[Password] [nvarchar](200) NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_AdminUserHistorical] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AdminUserLicenses]    Script Date: 24/11/2023 21:07:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AdminUserLicenses](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AdminUserId] [int] NULL,
	[LicensesId] [int] NULL,
 CONSTRAINT [PK_AdminUserLicenses] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AdminUsers]    Script Date: 24/11/2023 21:07:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AdminUsers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](150) NOT NULL,
	[Password] [nvarchar](200) NOT NULL,
	[Key] [nvarchar](36) NOT NULL,
	[CheckDigit] [nvarchar](max) NULL,
 CONSTRAINT [PK_AdminUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bitacoras]    Script Date: 24/11/2023 21:07:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bitacoras](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TypeId] [int] NULL,
	[Text] [nvarchar](max) NULL,
	[UserId] [int] NOT NULL,
	[Date] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Bitacoras] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DigitColumnVerifications]    Script Date: 24/11/2023 21:07:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DigitColumnVerifications](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Table] [nvarchar](max) NULL,
	[Column] [nvarchar](max) NULL,
	[VerificationDigit] [nvarchar](max) NULL,
 CONSTRAINT [PK_DigitColumnVerifications] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Dishes]    Script Date: 24/11/2023 21:07:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dishes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[SectionId] [int] NOT NULL,
	[Price] [float] NOT NULL,
 CONSTRAINT [PK_Dishes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DishOrders]    Script Date: 24/11/2023 21:07:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DishOrders](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DishId] [int] NOT NULL,
	[OrderId] [int] NOT NULL,
 CONSTRAINT [PK_DishOrders] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EventTypes]    Script Date: 24/11/2023 21:07:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EventTypes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Code] [int] NOT NULL,
	[Name] [nvarchar](max) NULL,
 CONSTRAINT [PK_EventTypes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FamilyLicenses]    Script Date: 24/11/2023 21:07:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FamilyLicenses](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
 CONSTRAINT [PK_FamilyLicenses] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FoodPoints]    Script Date: 24/11/2023 21:07:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FoodPoints](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Key] [nvarchar](36) NOT NULL,
 CONSTRAINT [PK_FoodPoints] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Languajes]    Script Date: 24/11/2023 21:07:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Languajes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Code] [int] NOT NULL,
 CONSTRAINT [PK_Languajes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LicenseLicense]    Script Date: 24/11/2023 21:07:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LicenseLicense](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdPadre] [int] NOT NULL,
	[IdHijo] [int] NOT NULL,
	[FamilyLicenseId] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Licenses]    Script Date: 24/11/2023 21:07:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Licenses](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Code] [int] NOT NULL,
 CONSTRAINT [PK_Licenses] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Logs]    Script Date: 24/11/2023 21:07:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Logs](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TypeId] [int] NULL,
	[Message] [nvarchar](max) NULL,
	[Date] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Logs] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LogTypes]    Script Date: 24/11/2023 21:07:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LogTypes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Code] [int] NOT NULL,
	[Name] [nvarchar](max) NULL,
 CONSTRAINT [PK_LogTypes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Menus]    Script Date: 24/11/2023 21:07:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Menus](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[FoodPointId] [int] NULL,
 CONSTRAINT [PK_Menus] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 24/11/2023 21:07:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Number] [bigint] NOT NULL,
	[Detail] [nvarchar](max) NULL,
	[Amount] [float] NOT NULL,
	[StatusId] [int] NOT NULL,
	[ChangeStatusDate] [datetime2](7) NOT NULL,
	[StartDate] [datetime2](7) NOT NULL,
	[EndDate] [datetime2](7) NULL,
	[AdminUsersId] [int] NOT NULL,
	[FoodPointId] [int] NOT NULL,
	[Key] [nvarchar](36) NOT NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sections]    Script Date: 24/11/2023 21:07:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sections](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[Position] [int] NOT NULL,
	[MenuId] [int] NOT NULL,
 CONSTRAINT [PK_Sections] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Status]    Script Date: 24/11/2023 21:07:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Status](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Code] [int] NOT NULL,
	[Name] [nvarchar](max) NULL,
 CONSTRAINT [PK_Status] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tables]    Script Date: 24/11/2023 21:07:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tables](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[QR] [uniqueidentifier] NOT NULL,
	[FoodPointId] [int] NOT NULL,
 CONSTRAINT [PK_Tables] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Words]    Script Date: 24/11/2023 21:07:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Words](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[LanguajeId] [int] NOT NULL,
	[Text] [nvarchar](max) NOT NULL,
	[Code] [int] NOT NULL,
 CONSTRAINT [PK_Words] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[AdminUsers] ON 

INSERT [dbo].[AdminUsers] ([Id], [Name], [Password], [Key], [CheckDigit]) VALUES (1, N'Admin', N'WDJIcOK+M7SHQmUCmL/mBWFI5LXAYCT7V/n2S8pXnQtlQ9f2AGakXgDU4061IC1iOsbAgNseVq7+PF2dwlTn3MRQesJs', N'27b2feeb-71de-4994-8e10-e22f867ce6d1', N'dDcGzWRR2R0=')
SET IDENTITY_INSERT [dbo].[AdminUsers] OFF
GO
SET IDENTITY_INSERT [dbo].[Bitacoras] ON 

INSERT [dbo].[Bitacoras] ([Id], [TypeId], [Text], [UserId], [Date]) VALUES (1, 1, N'El usuario Admin inicio sesion', 1, CAST(N'2023-11-20T14:55:58.2566667' AS DateTime2))
INSERT [dbo].[Bitacoras] ([Id], [TypeId], [Text], [UserId], [Date]) VALUES (2, 1, N'El usuario Admin inicio sesion', 1, CAST(N'2023-11-20T15:11:47.6233333' AS DateTime2))
INSERT [dbo].[Bitacoras] ([Id], [TypeId], [Text], [UserId], [Date]) VALUES (3, 1, N'El usuario Admin inicio sesion', 1, CAST(N'2023-11-20T17:48:13.5266667' AS DateTime2))
INSERT [dbo].[Bitacoras] ([Id], [TypeId], [Text], [UserId], [Date]) VALUES (4, 1, N'El usuario Admin inicio sesion', 1, CAST(N'2023-11-20T17:51:31.4166667' AS DateTime2))
INSERT [dbo].[Bitacoras] ([Id], [TypeId], [Text], [UserId], [Date]) VALUES (5, 1, N'El usuario Admin inicio sesion', 1, CAST(N'2023-11-20T17:51:56.5200000' AS DateTime2))
INSERT [dbo].[Bitacoras] ([Id], [TypeId], [Text], [UserId], [Date]) VALUES (6, 1, N'El usuario Admin inicio sesion', 1, CAST(N'2023-11-20T17:53:22.5200000' AS DateTime2))
INSERT [dbo].[Bitacoras] ([Id], [TypeId], [Text], [UserId], [Date]) VALUES (7, 1, N'El usuario Admin inicio sesion', 1, CAST(N'2023-11-20T17:53:53.3500000' AS DateTime2))
INSERT [dbo].[Bitacoras] ([Id], [TypeId], [Text], [UserId], [Date]) VALUES (8, 1, N'El usuario Admin inicio sesion', 1, CAST(N'2023-11-20T17:55:59.6466667' AS DateTime2))
INSERT [dbo].[Bitacoras] ([Id], [TypeId], [Text], [UserId], [Date]) VALUES (9, 1, N'El usuario Admin inicio sesion', 1, CAST(N'2023-11-20T17:56:36.5600000' AS DateTime2))
INSERT [dbo].[Bitacoras] ([Id], [TypeId], [Text], [UserId], [Date]) VALUES (10, 1, N'El usuario Admin inicio sesion', 1, CAST(N'2023-11-20T18:01:39.5766667' AS DateTime2))
INSERT [dbo].[Bitacoras] ([Id], [TypeId], [Text], [UserId], [Date]) VALUES (11, 1, N'El usuario Admin inicio sesion', 1, CAST(N'2023-11-20T18:01:57.9000000' AS DateTime2))
INSERT [dbo].[Bitacoras] ([Id], [TypeId], [Text], [UserId], [Date]) VALUES (12, 1, N'El usuario Admin inicio sesion', 1, CAST(N'2023-11-20T18:13:07.2900000' AS DateTime2))
INSERT [dbo].[Bitacoras] ([Id], [TypeId], [Text], [UserId], [Date]) VALUES (13, 1, N'El usuario Admin inicio sesion', 1, CAST(N'2023-11-20T18:17:28.2766667' AS DateTime2))
INSERT [dbo].[Bitacoras] ([Id], [TypeId], [Text], [UserId], [Date]) VALUES (14, 1, N'El usuario Admin inicio sesion', 1, CAST(N'2023-11-20T18:18:43.1966667' AS DateTime2))
INSERT [dbo].[Bitacoras] ([Id], [TypeId], [Text], [UserId], [Date]) VALUES (15, 1, N'El usuario Admin inicio sesion', 1, CAST(N'2023-11-20T18:20:41.7400000' AS DateTime2))
INSERT [dbo].[Bitacoras] ([Id], [TypeId], [Text], [UserId], [Date]) VALUES (16, 1, N'El usuario Admin inicio sesion', 1, CAST(N'2023-11-20T18:21:15.8400000' AS DateTime2))
INSERT [dbo].[Bitacoras] ([Id], [TypeId], [Text], [UserId], [Date]) VALUES (17, 1, N'El usuario Admin inicio sesion', 1, CAST(N'2023-11-20T18:21:45.7900000' AS DateTime2))
INSERT [dbo].[Bitacoras] ([Id], [TypeId], [Text], [UserId], [Date]) VALUES (18, 1, N'El usuario Admin inicio sesion', 1, CAST(N'2023-11-20T18:22:36.0866667' AS DateTime2))
INSERT [dbo].[Bitacoras] ([Id], [TypeId], [Text], [UserId], [Date]) VALUES (19, 1, N'El usuario Admin inicio sesion', 1, CAST(N'2023-11-21T01:25:10.7733333' AS DateTime2))
INSERT [dbo].[Bitacoras] ([Id], [TypeId], [Text], [UserId], [Date]) VALUES (20, 1, N'El usuario Admin inicio sesion', 1, CAST(N'2023-11-21T01:33:40.9566667' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Bitacoras] OFF
GO
SET IDENTITY_INSERT [dbo].[DigitColumnVerifications] ON 

INSERT [dbo].[DigitColumnVerifications] ([Id], [Table], [Column], [VerificationDigit]) VALUES (1, N'AdminUsers', N'Name', N'9swuVZL8VHI=')
INSERT [dbo].[DigitColumnVerifications] ([Id], [Table], [Column], [VerificationDigit]) VALUES (2, N'AdminUsers', N'Key', N'evHGCiZozRY=')
INSERT [dbo].[DigitColumnVerifications] ([Id], [Table], [Column], [VerificationDigit]) VALUES (3, N'AdminUsers', N'CheckDigit', N'Kt1TGCFkVV0=')
INSERT [dbo].[DigitColumnVerifications] ([Id], [Table], [Column], [VerificationDigit]) VALUES (4, N'AdminUsers', N'Password', N'z9Ox4s6jjEQ=')
SET IDENTITY_INSERT [dbo].[DigitColumnVerifications] OFF
GO
SET IDENTITY_INSERT [dbo].[Dishes] ON 

INSERT [dbo].[Dishes] ([Id], [Name], [Description], [SectionId], [Price]) VALUES (1, N'Carne al horno', N'Carne al horno con agregado de papas al horno', 1, 3709)
INSERT [dbo].[Dishes] ([Id], [Name], [Description], [SectionId], [Price]) VALUES (2, N'Hamburguesa con queso', N'Carne, queso, lechuga', 1, 4850)
INSERT [dbo].[Dishes] ([Id], [Name], [Description], [SectionId], [Price]) VALUES (3, N'Fideos con tuco', N'Fideos caseros con tuco', 2, 7232)
INSERT [dbo].[Dishes] ([Id], [Name], [Description], [SectionId], [Price]) VALUES (4, N'Coca cola', N'Clasica bebida adictiva', 3, 9332)
INSERT [dbo].[Dishes] ([Id], [Name], [Description], [SectionId], [Price]) VALUES (5, N'Pepsi', N'Otra clasica bebida adictiva', 3, 6642)
INSERT [dbo].[Dishes] ([Id], [Name], [Description], [SectionId], [Price]) VALUES (6, N'Carne al horno', N'Carne al horno con agregado de papas al horno', 4, 4025)
INSERT [dbo].[Dishes] ([Id], [Name], [Description], [SectionId], [Price]) VALUES (7, N'Empanad de carne', N'Empanada de carne al horno sin papas', 4, 8003)
INSERT [dbo].[Dishes] ([Id], [Name], [Description], [SectionId], [Price]) VALUES (8, N'Fideos con albondingas', N'Fideos con tuco y albondigas', 5, 3966)
INSERT [dbo].[Dishes] ([Id], [Name], [Description], [SectionId], [Price]) VALUES (9, N'Sorrentinos', N'Con salsa blanca', 6, 7070)
INSERT [dbo].[Dishes] ([Id], [Name], [Description], [SectionId], [Price]) VALUES (10, N'Asado', N'A la parrilla', 6, 2672)
INSERT [dbo].[Dishes] ([Id], [Name], [Description], [SectionId], [Price]) VALUES (11, N'Churrasco', N'Carne a la plancha', 7, 6435)
INSERT [dbo].[Dishes] ([Id], [Name], [Description], [SectionId], [Price]) VALUES (12, N'Ñoquis', N'Con salsa mixta', 7, 8983)
INSERT [dbo].[Dishes] ([Id], [Name], [Description], [SectionId], [Price]) VALUES (13, N'Costillas de cerdo', N'Recien extraidas de dicho animal', 8, 262)
INSERT [dbo].[Dishes] ([Id], [Name], [Description], [SectionId], [Price]) VALUES (14, N'Milanesa', N'Tipica milanesa Argentina', 8, 3152)
INSERT [dbo].[Dishes] ([Id], [Name], [Description], [SectionId], [Price]) VALUES (15, N'Ravioles', N'De verdura como le gustan a mi amigo el tano', 9, 2290)
INSERT [dbo].[Dishes] ([Id], [Name], [Description], [SectionId], [Price]) VALUES (16, N'Canelones', N'Con verdura o de jamon y queso', 9, 637)
SET IDENTITY_INSERT [dbo].[Dishes] OFF
GO
SET IDENTITY_INSERT [dbo].[DishOrders] ON 

INSERT [dbo].[DishOrders] ([Id], [DishId], [OrderId]) VALUES (1, 1, 1)
INSERT [dbo].[DishOrders] ([Id], [DishId], [OrderId]) VALUES (2, 3, 1)
INSERT [dbo].[DishOrders] ([Id], [DishId], [OrderId]) VALUES (3, 4, 1)
INSERT [dbo].[DishOrders] ([Id], [DishId], [OrderId]) VALUES (4, 13, 2)
INSERT [dbo].[DishOrders] ([Id], [DishId], [OrderId]) VALUES (5, 16, 2)
INSERT [dbo].[DishOrders] ([Id], [DishId], [OrderId]) VALUES (6, 13, 3)
INSERT [dbo].[DishOrders] ([Id], [DishId], [OrderId]) VALUES (7, 16, 3)
INSERT [dbo].[DishOrders] ([Id], [DishId], [OrderId]) VALUES (8, 13, 4)
INSERT [dbo].[DishOrders] ([Id], [DishId], [OrderId]) VALUES (9, 15, 4)
SET IDENTITY_INSERT [dbo].[DishOrders] OFF
GO
SET IDENTITY_INSERT [dbo].[EventTypes] ON 

INSERT [dbo].[EventTypes] ([Id], [Code], [Name]) VALUES (1, 1, N'Log In')
INSERT [dbo].[EventTypes] ([Id], [Code], [Name]) VALUES (2, 2, N'Log Off')
INSERT [dbo].[EventTypes] ([Id], [Code], [Name]) VALUES (3, 3, N'Grant Access to user')
INSERT [dbo].[EventTypes] ([Id], [Code], [Name]) VALUES (4, 4, N'Data modified')
INSERT [dbo].[EventTypes] ([Id], [Code], [Name]) VALUES (5, 5, N'Delete Data')
SET IDENTITY_INSERT [dbo].[EventTypes] OFF
GO
SET IDENTITY_INSERT [dbo].[FamilyLicenses] ON 

INSERT [dbo].[FamilyLicenses] ([Id], [Name]) VALUES (1, N'Default Family')
SET IDENTITY_INSERT [dbo].[FamilyLicenses] OFF
GO
SET IDENTITY_INSERT [dbo].[FoodPoints] ON 

INSERT [dbo].[FoodPoints] ([Id], [Name], [Key]) VALUES (1, N'Barba roja', N'BB1A16CD-EB5B-4850-AB1B-7B491940B6DE')
INSERT [dbo].[FoodPoints] ([Id], [Name], [Key]) VALUES (2, N'Checka', N'FD2F4061-BCA9-420A-B928-8C7A643B409E')
INSERT [dbo].[FoodPoints] ([Id], [Name], [Key]) VALUES (3, N'MC Donald', N'E5D35EB0-2913-494E-A5AC-222F3CF50163')
INSERT [dbo].[FoodPoints] ([Id], [Name], [Key]) VALUES (4, N'Burguer King', N'A4528820-E3E1-4456-9820-B3C06A5EC57F')
SET IDENTITY_INSERT [dbo].[FoodPoints] OFF
GO
SET IDENTITY_INSERT [dbo].[Languajes] ON 

INSERT [dbo].[Languajes] ([Id], [Name], [Code]) VALUES (1, N'English', 1)
INSERT [dbo].[Languajes] ([Id], [Name], [Code]) VALUES (2, N'Español', 2)
SET IDENTITY_INSERT [dbo].[Languajes] OFF
GO
SET IDENTITY_INSERT [dbo].[LicenseLicense] ON 

INSERT [dbo].[LicenseLicense] ([Id], [IdPadre], [IdHijo], [FamilyLicenseId]) VALUES (1, 0, 1, 1)
INSERT [dbo].[LicenseLicense] ([Id], [IdPadre], [IdHijo], [FamilyLicenseId]) VALUES (2, 1, 2, 1)
INSERT [dbo].[LicenseLicense] ([Id], [IdPadre], [IdHijo], [FamilyLicenseId]) VALUES (3, 2, 3, 1)
INSERT [dbo].[LicenseLicense] ([Id], [IdPadre], [IdHijo], [FamilyLicenseId]) VALUES (4, 2, 7, 1)
INSERT [dbo].[LicenseLicense] ([Id], [IdPadre], [IdHijo], [FamilyLicenseId]) VALUES (5, 3, 4, 1)
INSERT [dbo].[LicenseLicense] ([Id], [IdPadre], [IdHijo], [FamilyLicenseId]) VALUES (6, 3, 5, 1)
INSERT [dbo].[LicenseLicense] ([Id], [IdPadre], [IdHijo], [FamilyLicenseId]) VALUES (7, 3, 6, 1)
INSERT [dbo].[LicenseLicense] ([Id], [IdPadre], [IdHijo], [FamilyLicenseId]) VALUES (8, 7, 8, 1)
INSERT [dbo].[LicenseLicense] ([Id], [IdPadre], [IdHijo], [FamilyLicenseId]) VALUES (9, 7, 9, 1)
INSERT [dbo].[LicenseLicense] ([Id], [IdPadre], [IdHijo], [FamilyLicenseId]) VALUES (10, 7, 10, 1)
SET IDENTITY_INSERT [dbo].[LicenseLicense] OFF
GO
SET IDENTITY_INSERT [dbo].[Licenses] ON 

INSERT [dbo].[Licenses] ([Id], [Name], [Code]) VALUES (1, N'All', 1)
INSERT [dbo].[Licenses] ([Id], [Name], [Code]) VALUES (2, N'Restorant', 2)
INSERT [dbo].[Licenses] ([Id], [Name], [Code]) VALUES (3, N'Edit menu', 3)
INSERT [dbo].[Licenses] ([Id], [Name], [Code]) VALUES (4, N'Name', 4)
INSERT [dbo].[Licenses] ([Id], [Name], [Code]) VALUES (5, N'Price', 5)
INSERT [dbo].[Licenses] ([Id], [Name], [Code]) VALUES (6, N'Section', 6)
INSERT [dbo].[Licenses] ([Id], [Name], [Code]) VALUES (7, N'Schedule', 7)
INSERT [dbo].[Licenses] ([Id], [Name], [Code]) VALUES (8, N'Week days', 8)
INSERT [dbo].[Licenses] ([Id], [Name], [Code]) VALUES (9, N'Open time', 9)
INSERT [dbo].[Licenses] ([Id], [Name], [Code]) VALUES (10, N'Close time', 10)
SET IDENTITY_INSERT [dbo].[Licenses] OFF
GO
SET IDENTITY_INSERT [dbo].[Logs] ON 

INSERT [dbo].[Logs] ([Id], [TypeId], [Message], [Date]) VALUES (1, 1, N'Se esta intentando iniciar sesion con el usuario: Admin', CAST(N'2023-11-20T14:55:58.1866667' AS DateTime2))
INSERT [dbo].[Logs] ([Id], [TypeId], [Message], [Date]) VALUES (2, 1, N'Usuario Admin Key: 27b2feeb-71de-4994-8e10-e22f867ce6d1 Inicio sesion', CAST(N'2023-11-20T14:55:58.2500000' AS DateTime2))
INSERT [dbo].[Logs] ([Id], [TypeId], [Message], [Date]) VALUES (3, 1, N'Se esta intentando iniciar sesion con el usuario: Admin', CAST(N'2023-11-20T15:11:47.5666667' AS DateTime2))
INSERT [dbo].[Logs] ([Id], [TypeId], [Message], [Date]) VALUES (4, 1, N'Usuario Admin Key: 27b2feeb-71de-4994-8e10-e22f867ce6d1 Inicio sesion', CAST(N'2023-11-20T15:11:47.6200000' AS DateTime2))
INSERT [dbo].[Logs] ([Id], [TypeId], [Message], [Date]) VALUES (5, 1, N'Se esta intentando iniciar sesion con el usuario: Admin', CAST(N'2023-11-20T17:48:13.4666667' AS DateTime2))
INSERT [dbo].[Logs] ([Id], [TypeId], [Message], [Date]) VALUES (6, 1, N'Usuario Admin Key: 27b2feeb-71de-4994-8e10-e22f867ce6d1 Inicio sesion', CAST(N'2023-11-20T17:48:13.5233333' AS DateTime2))
INSERT [dbo].[Logs] ([Id], [TypeId], [Message], [Date]) VALUES (7, 1, N'Se esta intentando iniciar sesion con el usuario: Admin', CAST(N'2023-11-20T17:51:31.3633333' AS DateTime2))
INSERT [dbo].[Logs] ([Id], [TypeId], [Message], [Date]) VALUES (8, 1, N'Usuario Admin Key: 27b2feeb-71de-4994-8e10-e22f867ce6d1 Inicio sesion', CAST(N'2023-11-20T17:51:31.4100000' AS DateTime2))
INSERT [dbo].[Logs] ([Id], [TypeId], [Message], [Date]) VALUES (9, 1, N'Se esta intentando iniciar sesion con el usuario: Admin', CAST(N'2023-11-20T17:51:56.4466667' AS DateTime2))
INSERT [dbo].[Logs] ([Id], [TypeId], [Message], [Date]) VALUES (10, 1, N'Usuario Admin Key: 27b2feeb-71de-4994-8e10-e22f867ce6d1 Inicio sesion', CAST(N'2023-11-20T17:51:56.4966667' AS DateTime2))
INSERT [dbo].[Logs] ([Id], [TypeId], [Message], [Date]) VALUES (11, 1, N'Se esta intentando iniciar sesion con el usuario: Admin', CAST(N'2023-11-20T17:53:22.4566667' AS DateTime2))
INSERT [dbo].[Logs] ([Id], [TypeId], [Message], [Date]) VALUES (12, 1, N'Usuario Admin Key: 27b2feeb-71de-4994-8e10-e22f867ce6d1 Inicio sesion', CAST(N'2023-11-20T17:53:22.5133333' AS DateTime2))
INSERT [dbo].[Logs] ([Id], [TypeId], [Message], [Date]) VALUES (13, 1, N'Se esta intentando iniciar sesion con el usuario: Admin', CAST(N'2023-11-20T17:53:53.2933333' AS DateTime2))
INSERT [dbo].[Logs] ([Id], [TypeId], [Message], [Date]) VALUES (14, 1, N'Usuario Admin Key: 27b2feeb-71de-4994-8e10-e22f867ce6d1 Inicio sesion', CAST(N'2023-11-20T17:53:53.3466667' AS DateTime2))
INSERT [dbo].[Logs] ([Id], [TypeId], [Message], [Date]) VALUES (15, 1, N'Se esta intentando iniciar sesion con el usuario: Admin', CAST(N'2023-11-20T17:55:59.5866667' AS DateTime2))
INSERT [dbo].[Logs] ([Id], [TypeId], [Message], [Date]) VALUES (16, 1, N'Usuario Admin Key: 27b2feeb-71de-4994-8e10-e22f867ce6d1 Inicio sesion', CAST(N'2023-11-20T17:55:59.6400000' AS DateTime2))
INSERT [dbo].[Logs] ([Id], [TypeId], [Message], [Date]) VALUES (17, 1, N'Se esta intentando iniciar sesion con el usuario: Admin', CAST(N'2023-11-20T17:56:36.5033333' AS DateTime2))
INSERT [dbo].[Logs] ([Id], [TypeId], [Message], [Date]) VALUES (18, 1, N'Usuario Admin Key: 27b2feeb-71de-4994-8e10-e22f867ce6d1 Inicio sesion', CAST(N'2023-11-20T17:56:36.5533333' AS DateTime2))
INSERT [dbo].[Logs] ([Id], [TypeId], [Message], [Date]) VALUES (19, 1, N'Se esta intentando iniciar sesion con el usuario: Admin', CAST(N'2023-11-20T18:01:39.5233333' AS DateTime2))
INSERT [dbo].[Logs] ([Id], [TypeId], [Message], [Date]) VALUES (20, 1, N'Usuario Admin Key: 27b2feeb-71de-4994-8e10-e22f867ce6d1 Inicio sesion', CAST(N'2023-11-20T18:01:39.5733333' AS DateTime2))
INSERT [dbo].[Logs] ([Id], [TypeId], [Message], [Date]) VALUES (21, 1, N'Se esta intentando iniciar sesion con el usuario: Admin', CAST(N'2023-11-20T18:01:57.8433333' AS DateTime2))
INSERT [dbo].[Logs] ([Id], [TypeId], [Message], [Date]) VALUES (22, 1, N'Usuario Admin Key: 27b2feeb-71de-4994-8e10-e22f867ce6d1 Inicio sesion', CAST(N'2023-11-20T18:01:57.8966667' AS DateTime2))
INSERT [dbo].[Logs] ([Id], [TypeId], [Message], [Date]) VALUES (23, 1, N'Se esta intentando iniciar sesion con el usuario: Admin', CAST(N'2023-11-20T18:13:07.2333333' AS DateTime2))
INSERT [dbo].[Logs] ([Id], [TypeId], [Message], [Date]) VALUES (24, 1, N'Usuario Admin Key: 27b2feeb-71de-4994-8e10-e22f867ce6d1 Inicio sesion', CAST(N'2023-11-20T18:13:07.2833333' AS DateTime2))
INSERT [dbo].[Logs] ([Id], [TypeId], [Message], [Date]) VALUES (25, 1, N'Se esta intentando iniciar sesion con el usuario: Admin', CAST(N'2023-11-20T18:17:28.2066667' AS DateTime2))
INSERT [dbo].[Logs] ([Id], [TypeId], [Message], [Date]) VALUES (26, 1, N'Usuario Admin Key: 27b2feeb-71de-4994-8e10-e22f867ce6d1 Inicio sesion', CAST(N'2023-11-20T18:17:28.2700000' AS DateTime2))
INSERT [dbo].[Logs] ([Id], [TypeId], [Message], [Date]) VALUES (27, 1, N'Se esta intentando iniciar sesion con el usuario: Admin', CAST(N'2023-11-20T18:18:43.1366667' AS DateTime2))
INSERT [dbo].[Logs] ([Id], [TypeId], [Message], [Date]) VALUES (28, 1, N'Usuario Admin Key: 27b2feeb-71de-4994-8e10-e22f867ce6d1 Inicio sesion', CAST(N'2023-11-20T18:18:43.1933333' AS DateTime2))
INSERT [dbo].[Logs] ([Id], [TypeId], [Message], [Date]) VALUES (29, 1, N'Se esta intentando iniciar sesion con el usuario: Admin', CAST(N'2023-11-20T18:20:41.6800000' AS DateTime2))
INSERT [dbo].[Logs] ([Id], [TypeId], [Message], [Date]) VALUES (30, 1, N'Usuario Admin Key: 27b2feeb-71de-4994-8e10-e22f867ce6d1 Inicio sesion', CAST(N'2023-11-20T18:20:41.7333333' AS DateTime2))
INSERT [dbo].[Logs] ([Id], [TypeId], [Message], [Date]) VALUES (31, 1, N'Se esta intentando iniciar sesion con el usuario: Admin', CAST(N'2023-11-20T18:21:15.7900000' AS DateTime2))
INSERT [dbo].[Logs] ([Id], [TypeId], [Message], [Date]) VALUES (32, 1, N'Usuario Admin Key: 27b2feeb-71de-4994-8e10-e22f867ce6d1 Inicio sesion', CAST(N'2023-11-20T18:21:15.8366667' AS DateTime2))
INSERT [dbo].[Logs] ([Id], [TypeId], [Message], [Date]) VALUES (33, 1, N'Se esta intentando iniciar sesion con el usuario: Admin', CAST(N'2023-11-20T18:21:45.7366667' AS DateTime2))
INSERT [dbo].[Logs] ([Id], [TypeId], [Message], [Date]) VALUES (34, 1, N'Usuario Admin Key: 27b2feeb-71de-4994-8e10-e22f867ce6d1 Inicio sesion', CAST(N'2023-11-20T18:21:45.7833333' AS DateTime2))
INSERT [dbo].[Logs] ([Id], [TypeId], [Message], [Date]) VALUES (35, 1, N'Se esta intentando iniciar sesion con el usuario: Admin', CAST(N'2023-11-20T18:22:36.0333333' AS DateTime2))
INSERT [dbo].[Logs] ([Id], [TypeId], [Message], [Date]) VALUES (36, 1, N'Usuario Admin Key: 27b2feeb-71de-4994-8e10-e22f867ce6d1 Inicio sesion', CAST(N'2023-11-20T18:22:36.0833333' AS DateTime2))
INSERT [dbo].[Logs] ([Id], [TypeId], [Message], [Date]) VALUES (37, 1, N'Se esta intentando iniciar sesion con el usuario: Admin', CAST(N'2023-11-21T01:25:10.7100000' AS DateTime2))
INSERT [dbo].[Logs] ([Id], [TypeId], [Message], [Date]) VALUES (38, 1, N'Usuario Admin Key: 27b2feeb-71de-4994-8e10-e22f867ce6d1 Inicio sesion', CAST(N'2023-11-21T01:25:10.7633333' AS DateTime2))
INSERT [dbo].[Logs] ([Id], [TypeId], [Message], [Date]) VALUES (39, 1, N'Se esta intentando iniciar sesion con el usuario: Admin', CAST(N'2023-11-21T01:33:40.9033333' AS DateTime2))
INSERT [dbo].[Logs] ([Id], [TypeId], [Message], [Date]) VALUES (40, 1, N'Usuario Admin Key: 27b2feeb-71de-4994-8e10-e22f867ce6d1 Inicio sesion', CAST(N'2023-11-21T01:33:40.9500000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Logs] OFF
GO
SET IDENTITY_INSERT [dbo].[LogTypes] ON 

INSERT [dbo].[LogTypes] ([Id], [Code], [Name]) VALUES (1, 1, N'Info')
INSERT [dbo].[LogTypes] ([Id], [Code], [Name]) VALUES (2, 2, N'Warning')
INSERT [dbo].[LogTypes] ([Id], [Code], [Name]) VALUES (3, 3, N'Error')
SET IDENTITY_INSERT [dbo].[LogTypes] OFF
GO
SET IDENTITY_INSERT [dbo].[Menus] ON 

INSERT [dbo].[Menus] ([Id], [Description], [FoodPointId]) VALUES (1, N'Menu del bar Barba Roja', 1)
INSERT [dbo].[Menus] ([Id], [Description], [FoodPointId]) VALUES (2, N'Menu del bar Checka', 2)
INSERT [dbo].[Menus] ([Id], [Description], [FoodPointId]) VALUES (3, N'Menu de MacDonalds', 3)
INSERT [dbo].[Menus] ([Id], [Description], [FoodPointId]) VALUES (4, N'Menu de Burguer King', 4)
SET IDENTITY_INSERT [dbo].[Menus] OFF
GO
SET IDENTITY_INSERT [dbo].[Orders] ON 

INSERT [dbo].[Orders] ([Id], [Number], [Detail], [Amount], [StatusId], [ChangeStatusDate], [StartDate], [EndDate], [AdminUsersId], [FoodPointId], [Key]) VALUES (1, 1, N'', 20273, 9, CAST(N'2023-11-20T18:18:48.7600000' AS DateTime2), CAST(N'2023-11-20T14:56:16.8300000' AS DateTime2), NULL, 1, 1, N'FC16E053-159C-4000-A702-8DE471DDF283')
INSERT [dbo].[Orders] ([Id], [Number], [Detail], [Amount], [StatusId], [ChangeStatusDate], [StartDate], [EndDate], [AdminUsersId], [FoodPointId], [Key]) VALUES (2, 2, N'', 899, 5, CAST(N'2023-11-20T14:57:25.4900000' AS DateTime2), CAST(N'2023-11-20T14:56:27.8433333' AS DateTime2), NULL, 1, 4, N'62B87F8F-274A-45DA-9F09-7EB2AF7C1BF7')
INSERT [dbo].[Orders] ([Id], [Number], [Detail], [Amount], [StatusId], [ChangeStatusDate], [StartDate], [EndDate], [AdminUsersId], [FoodPointId], [Key]) VALUES (3, 3, N'', 899, 1, CAST(N'2023-11-20T14:56:29.6600000' AS DateTime2), CAST(N'2023-11-20T14:56:29.6600000' AS DateTime2), NULL, 1, 4, N'A0A450EB-E820-4F2D-8AF6-93133FDE9E63')
INSERT [dbo].[Orders] ([Id], [Number], [Detail], [Amount], [StatusId], [ChangeStatusDate], [StartDate], [EndDate], [AdminUsersId], [FoodPointId], [Key]) VALUES (4, 4, N'', 2552, 1, CAST(N'2023-11-20T14:56:39.0166667' AS DateTime2), CAST(N'2023-11-20T14:56:39.0166667' AS DateTime2), NULL, 1, 4, N'E3AD1E4A-8A39-467B-9B13-DD9CE12A735A')
SET IDENTITY_INSERT [dbo].[Orders] OFF
GO
SET IDENTITY_INSERT [dbo].[Sections] ON 

INSERT [dbo].[Sections] ([Id], [Name], [Description], [Position], [MenuId]) VALUES (1, N'Carnes', N'Seccion de carnes del menu', 1, 1)
INSERT [dbo].[Sections] ([Id], [Name], [Description], [Position], [MenuId]) VALUES (2, N'Pastas', N'Seccion de pastas del menu', 2, 1)
INSERT [dbo].[Sections] ([Id], [Name], [Description], [Position], [MenuId]) VALUES (3, N'Bebidas', N'Seccion de bebidas del menu', 3, 1)
INSERT [dbo].[Sections] ([Id], [Name], [Description], [Position], [MenuId]) VALUES (4, N'Carnes', N'Seccion de carnes del menu', 1, 2)
INSERT [dbo].[Sections] ([Id], [Name], [Description], [Position], [MenuId]) VALUES (5, N'Pastas', N'Seccion de pastas del menu', 2, 2)
INSERT [dbo].[Sections] ([Id], [Name], [Description], [Position], [MenuId]) VALUES (6, N'Carnes', N'Seccion de carnes del menu', 1, 3)
INSERT [dbo].[Sections] ([Id], [Name], [Description], [Position], [MenuId]) VALUES (7, N'Pastas', N'Seccion de pastas del menu', 2, 3)
INSERT [dbo].[Sections] ([Id], [Name], [Description], [Position], [MenuId]) VALUES (8, N'Carnes', N'Seccion de carnes del menu', 1, 4)
INSERT [dbo].[Sections] ([Id], [Name], [Description], [Position], [MenuId]) VALUES (9, N'Pastas', N'Seccion de pastas del menu', 2, 4)
SET IDENTITY_INSERT [dbo].[Sections] OFF
GO
SET IDENTITY_INSERT [dbo].[Status] ON 

INSERT [dbo].[Status] ([Id], [Code], [Name]) VALUES (1, 1, N'En proceso de confirmacion')
INSERT [dbo].[Status] ([Id], [Code], [Name]) VALUES (2, 2, N'Aceptado')
INSERT [dbo].[Status] ([Id], [Code], [Name]) VALUES (3, 3, N'Rechazado')
INSERT [dbo].[Status] ([Id], [Code], [Name]) VALUES (4, 4, N'En proceso de coccion')
INSERT [dbo].[Status] ([Id], [Code], [Name]) VALUES (5, 5, N'En espera para entrega')
INSERT [dbo].[Status] ([Id], [Code], [Name]) VALUES (6, 6, N'En espera')
INSERT [dbo].[Status] ([Id], [Code], [Name]) VALUES (7, 7, N'Finalizado correctamente')
INSERT [dbo].[Status] ([Id], [Code], [Name]) VALUES (8, 8, N'Cancelado')
INSERT [dbo].[Status] ([Id], [Code], [Name]) VALUES (9, 9, N'Entregado correctamente')
INSERT [dbo].[Status] ([Id], [Code], [Name]) VALUES (10, 10, N'Fallo la entrega')
SET IDENTITY_INSERT [dbo].[Status] OFF
GO
SET IDENTITY_INSERT [dbo].[Tables] ON 

INSERT [dbo].[Tables] ([Id], [QR], [FoodPointId]) VALUES (1, N'8cb8ca28-03f0-4a66-b2aa-d2292e2e6a75', 1)
INSERT [dbo].[Tables] ([Id], [QR], [FoodPointId]) VALUES (2, N'ac1f39d5-7224-45cb-a2de-5b780962bcb4', 1)
INSERT [dbo].[Tables] ([Id], [QR], [FoodPointId]) VALUES (3, N'73ba34c5-2d92-4c28-a522-449aa8921d5d', 1)
INSERT [dbo].[Tables] ([Id], [QR], [FoodPointId]) VALUES (4, N'11ec4a9b-f1e9-4d33-b237-3f717fb3862a', 2)
INSERT [dbo].[Tables] ([Id], [QR], [FoodPointId]) VALUES (5, N'6fd4f657-fe1c-4956-a1dd-4a9a59eae05f', 2)
INSERT [dbo].[Tables] ([Id], [QR], [FoodPointId]) VALUES (6, N'b5a06175-ce30-4a07-a3d1-3c898a54d5bc', 3)
INSERT [dbo].[Tables] ([Id], [QR], [FoodPointId]) VALUES (7, N'4704ec2d-10b7-4243-a99a-dddb91942dd1', 3)
INSERT [dbo].[Tables] ([Id], [QR], [FoodPointId]) VALUES (8, N'b5942954-0349-4efc-af43-0d0c48202727', 4)
INSERT [dbo].[Tables] ([Id], [QR], [FoodPointId]) VALUES (9, N'f2f74a7b-882d-450c-baf3-c0d7ddbdf53d', 4)
INSERT [dbo].[Tables] ([Id], [QR], [FoodPointId]) VALUES (10, N'f30be126-14e9-4600-a47f-f6cc3c4adb01', 4)
SET IDENTITY_INSERT [dbo].[Tables] OFF
GO
SET IDENTITY_INSERT [dbo].[Words] ON 

INSERT [dbo].[Words] ([Id], [LanguajeId], [Text], [Code]) VALUES (1, 1, N'Home', 1)
INSERT [dbo].[Words] ([Id], [LanguajeId], [Text], [Code]) VALUES (2, 1, N'Users', 2)
INSERT [dbo].[Words] ([Id], [LanguajeId], [Text], [Code]) VALUES (3, 1, N'Config', 3)
INSERT [dbo].[Words] ([Id], [LanguajeId], [Text], [Code]) VALUES (4, 1, N'Permissions Assignments', 4)
INSERT [dbo].[Words] ([Id], [LanguajeId], [Text], [Code]) VALUES (5, 1, N'Permissions', 5)
INSERT [dbo].[Words] ([Id], [LanguajeId], [Text], [Code]) VALUES (6, 2, N'Principal', 1)
INSERT [dbo].[Words] ([Id], [LanguajeId], [Text], [Code]) VALUES (7, 2, N'Usuarios', 2)
INSERT [dbo].[Words] ([Id], [LanguajeId], [Text], [Code]) VALUES (8, 2, N'Config', 3)
INSERT [dbo].[Words] ([Id], [LanguajeId], [Text], [Code]) VALUES (9, 2, N'Asignar permisos', 4)
INSERT [dbo].[Words] ([Id], [LanguajeId], [Text], [Code]) VALUES (10, 2, N'Permisos', 5)
SET IDENTITY_INSERT [dbo].[Words] OFF
GO
/****** Object:  Index [IX_AdminUserHistorical_UserId]    Script Date: 24/11/2023 21:07:26 ******/
CREATE NONCLUSTERED INDEX [IX_AdminUserHistorical_UserId] ON [dbo].[AdminUserHistorical]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_AdminUserLicenses_AdminUserId]    Script Date: 24/11/2023 21:07:26 ******/
CREATE NONCLUSTERED INDEX [IX_AdminUserLicenses_AdminUserId] ON [dbo].[AdminUserLicenses]
(
	[AdminUserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_AdminUserLicenses_LicensesId]    Script Date: 24/11/2023 21:07:26 ******/
CREATE NONCLUSTERED INDEX [IX_AdminUserLicenses_LicensesId] ON [dbo].[AdminUserLicenses]
(
	[LicensesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_UQ_NameUniqueColumn]    Script Date: 24/11/2023 21:07:26 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_UQ_NameUniqueColumn] ON [dbo].[AdminUsers]
(
	[Name] ASC
)
WHERE ([Name] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Bitacoras_TypeId]    Script Date: 24/11/2023 21:07:26 ******/
CREATE NONCLUSTERED INDEX [IX_Bitacoras_TypeId] ON [dbo].[Bitacoras]
(
	[TypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Bitacoras_UserId]    Script Date: 24/11/2023 21:07:26 ******/
CREATE NONCLUSTERED INDEX [IX_Bitacoras_UserId] ON [dbo].[Bitacoras]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Dishes_SectionId]    Script Date: 24/11/2023 21:07:26 ******/
CREATE NONCLUSTERED INDEX [IX_Dishes_SectionId] ON [dbo].[Dishes]
(
	[SectionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_DishOrders_DishId]    Script Date: 24/11/2023 21:07:26 ******/
CREATE NONCLUSTERED INDEX [IX_DishOrders_DishId] ON [dbo].[DishOrders]
(
	[DishId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_DishOrders_OrderId]    Script Date: 24/11/2023 21:07:26 ******/
CREATE NONCLUSTERED INDEX [IX_DishOrders_OrderId] ON [dbo].[DishOrders]
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_LicenseLicense_FamilyLicenseId]    Script Date: 24/11/2023 21:07:26 ******/
CREATE NONCLUSTERED INDEX [IX_LicenseLicense_FamilyLicenseId] ON [dbo].[LicenseLicense]
(
	[FamilyLicenseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Logs_TypeId]    Script Date: 24/11/2023 21:07:26 ******/
CREATE NONCLUSTERED INDEX [IX_Logs_TypeId] ON [dbo].[Logs]
(
	[TypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Menus_FoodPointId]    Script Date: 24/11/2023 21:07:26 ******/
CREATE NONCLUSTERED INDEX [IX_Menus_FoodPointId] ON [dbo].[Menus]
(
	[FoodPointId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Orders_AdminUsersId]    Script Date: 24/11/2023 21:07:26 ******/
CREATE NONCLUSTERED INDEX [IX_Orders_AdminUsersId] ON [dbo].[Orders]
(
	[AdminUsersId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Orders_FoodPointId]    Script Date: 24/11/2023 21:07:26 ******/
CREATE NONCLUSTERED INDEX [IX_Orders_FoodPointId] ON [dbo].[Orders]
(
	[FoodPointId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Orders_StatusId]    Script Date: 24/11/2023 21:07:26 ******/
CREATE NONCLUSTERED INDEX [IX_Orders_StatusId] ON [dbo].[Orders]
(
	[StatusId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Sections_MenuId]    Script Date: 24/11/2023 21:07:26 ******/
CREATE NONCLUSTERED INDEX [IX_Sections_MenuId] ON [dbo].[Sections]
(
	[MenuId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Tables_FoodPointId]    Script Date: 24/11/2023 21:07:26 ******/
CREATE NONCLUSTERED INDEX [IX_Tables_FoodPointId] ON [dbo].[Tables]
(
	[FoodPointId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Words_LanguajeId]    Script Date: 24/11/2023 21:07:26 ******/
CREATE NONCLUSTERED INDEX [IX_Words_LanguajeId] ON [dbo].[Words]
(
	[LanguajeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AdminUsers] ADD  DEFAULT (N'') FOR [Name]
GO
ALTER TABLE [dbo].[Bitacoras] ADD  DEFAULT ((0)) FOR [UserId]
GO
ALTER TABLE [dbo].[Bitacoras] ADD  DEFAULT ('0001-01-01T00:00:00.0000000') FOR [Date]
GO
ALTER TABLE [dbo].[Dishes] ADD  DEFAULT ((0)) FOR [SectionId]
GO
ALTER TABLE [dbo].[Dishes] ADD  DEFAULT ((0.0000000000000000e+000)) FOR [Price]
GO
ALTER TABLE [dbo].[Licenses] ADD  DEFAULT ((0)) FOR [Code]
GO
ALTER TABLE [dbo].[Logs] ADD  DEFAULT ('0001-01-01T00:00:00.0000000') FOR [Date]
GO
ALTER TABLE [dbo].[Orders] ADD  DEFAULT ((0)) FOR [StatusId]
GO
ALTER TABLE [dbo].[Orders] ADD  DEFAULT ((0)) FOR [AdminUsersId]
GO
ALTER TABLE [dbo].[Orders] ADD  DEFAULT ((0)) FOR [FoodPointId]
GO
ALTER TABLE [dbo].[Sections] ADD  DEFAULT ((0)) FOR [MenuId]
GO
ALTER TABLE [dbo].[Tables] ADD  DEFAULT ((0)) FOR [FoodPointId]
GO
ALTER TABLE [dbo].[Words] ADD  DEFAULT ((0)) FOR [LanguajeId]
GO
ALTER TABLE [dbo].[AdminUserHistorical]  WITH CHECK ADD  CONSTRAINT [FK_AdminUserHistorical_AdminUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AdminUsers] ([Id])
GO
ALTER TABLE [dbo].[AdminUserHistorical] CHECK CONSTRAINT [FK_AdminUserHistorical_AdminUsers_UserId]
GO
ALTER TABLE [dbo].[AdminUserLicenses]  WITH CHECK ADD  CONSTRAINT [FK_AdminUserLicenses_AdminUsers_AdminUserId] FOREIGN KEY([AdminUserId])
REFERENCES [dbo].[AdminUsers] ([Id])
GO
ALTER TABLE [dbo].[AdminUserLicenses] CHECK CONSTRAINT [FK_AdminUserLicenses_AdminUsers_AdminUserId]
GO
ALTER TABLE [dbo].[AdminUserLicenses]  WITH CHECK ADD  CONSTRAINT [FK_AdminUserLicenses_Licenses_LicensesId] FOREIGN KEY([LicensesId])
REFERENCES [dbo].[Licenses] ([Id])
GO
ALTER TABLE [dbo].[AdminUserLicenses] CHECK CONSTRAINT [FK_AdminUserLicenses_Licenses_LicensesId]
GO
ALTER TABLE [dbo].[Bitacoras]  WITH CHECK ADD  CONSTRAINT [FK_Bitacoras_AdminUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AdminUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Bitacoras] CHECK CONSTRAINT [FK_Bitacoras_AdminUsers_UserId]
GO
ALTER TABLE [dbo].[Bitacoras]  WITH CHECK ADD  CONSTRAINT [FK_Bitacoras_EventTypes_TypeId] FOREIGN KEY([TypeId])
REFERENCES [dbo].[EventTypes] ([Id])
GO
ALTER TABLE [dbo].[Bitacoras] CHECK CONSTRAINT [FK_Bitacoras_EventTypes_TypeId]
GO
ALTER TABLE [dbo].[Dishes]  WITH CHECK ADD  CONSTRAINT [FK_Dishes_Sections_SectionId] FOREIGN KEY([SectionId])
REFERENCES [dbo].[Sections] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Dishes] CHECK CONSTRAINT [FK_Dishes_Sections_SectionId]
GO
ALTER TABLE [dbo].[DishOrders]  WITH CHECK ADD  CONSTRAINT [FK_DishOrders_Dishes_DishId] FOREIGN KEY([DishId])
REFERENCES [dbo].[Dishes] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DishOrders] CHECK CONSTRAINT [FK_DishOrders_Dishes_DishId]
GO
ALTER TABLE [dbo].[DishOrders]  WITH CHECK ADD  CONSTRAINT [FK_DishOrders_Orders_OrderId] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Orders] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DishOrders] CHECK CONSTRAINT [FK_DishOrders_Orders_OrderId]
GO
ALTER TABLE [dbo].[LicenseLicense]  WITH CHECK ADD  CONSTRAINT [FK_LicenseLicense_FamilyLicenses_FamilyLicenseId] FOREIGN KEY([FamilyLicenseId])
REFERENCES [dbo].[FamilyLicenses] ([Id])
GO
ALTER TABLE [dbo].[LicenseLicense] CHECK CONSTRAINT [FK_LicenseLicense_FamilyLicenses_FamilyLicenseId]
GO
ALTER TABLE [dbo].[Logs]  WITH CHECK ADD  CONSTRAINT [FK_Logs_LogTypes_TypeId] FOREIGN KEY([TypeId])
REFERENCES [dbo].[LogTypes] ([Id])
GO
ALTER TABLE [dbo].[Logs] CHECK CONSTRAINT [FK_Logs_LogTypes_TypeId]
GO
ALTER TABLE [dbo].[Menus]  WITH CHECK ADD  CONSTRAINT [FK_Menus_FoodPoints_FoodPointId] FOREIGN KEY([FoodPointId])
REFERENCES [dbo].[FoodPoints] ([Id])
GO
ALTER TABLE [dbo].[Menus] CHECK CONSTRAINT [FK_Menus_FoodPoints_FoodPointId]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_AdminUsers_AdminUsersId] FOREIGN KEY([AdminUsersId])
REFERENCES [dbo].[AdminUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_AdminUsers_AdminUsersId]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_FoodPoints_FoodPointId] FOREIGN KEY([FoodPointId])
REFERENCES [dbo].[FoodPoints] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_FoodPoints_FoodPointId]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Status_StatusId] FOREIGN KEY([StatusId])
REFERENCES [dbo].[Status] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Status_StatusId]
GO
ALTER TABLE [dbo].[Sections]  WITH CHECK ADD  CONSTRAINT [FK_Sections_Menus_MenuId] FOREIGN KEY([MenuId])
REFERENCES [dbo].[Menus] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Sections] CHECK CONSTRAINT [FK_Sections_Menus_MenuId]
GO
ALTER TABLE [dbo].[Tables]  WITH CHECK ADD  CONSTRAINT [FK_Tables_FoodPoints_FoodPointId] FOREIGN KEY([FoodPointId])
REFERENCES [dbo].[FoodPoints] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Tables] CHECK CONSTRAINT [FK_Tables_FoodPoints_FoodPointId]
GO
ALTER TABLE [dbo].[Words]  WITH CHECK ADD  CONSTRAINT [FK_Words_Languajes_LanguajeId] FOREIGN KEY([LanguajeId])
REFERENCES [dbo].[Languajes] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Words] CHECK CONSTRAINT [FK_Words_Languajes_LanguajeId]
GO
USE [master]
GO
ALTER DATABASE [Cz.Project] SET  READ_WRITE 
GO
