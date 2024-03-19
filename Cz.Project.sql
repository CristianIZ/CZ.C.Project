USE [master]
GO
/****** Object:  Database [Cz.Project]    Script Date: 19/3/2024 12:34:32 ******/
CREATE DATABASE [Cz.Project]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Cz.Project', FILENAME = N'F:\Instalaciones\Dev\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Cz.Project.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Cz.Project_log', FILENAME = N'F:\Instalaciones\Dev\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Cz.Project_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
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
/****** Object:  Table [dbo].[AdminUserHistorical]    Script Date: 19/3/2024 12:34:32 ******/
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
/****** Object:  Table [dbo].[AdminUserLicenses]    Script Date: 19/3/2024 12:34:32 ******/
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
/****** Object:  Table [dbo].[AdminUsers]    Script Date: 19/3/2024 12:34:32 ******/
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
/****** Object:  Table [dbo].[Bitacoras]    Script Date: 19/3/2024 12:34:32 ******/
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
/****** Object:  Table [dbo].[DigitColumnVerifications]    Script Date: 19/3/2024 12:34:32 ******/
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
/****** Object:  Table [dbo].[Dishes]    Script Date: 19/3/2024 12:34:32 ******/
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
/****** Object:  Table [dbo].[DishOrders]    Script Date: 19/3/2024 12:34:32 ******/
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
/****** Object:  Table [dbo].[EventTypes]    Script Date: 19/3/2024 12:34:32 ******/
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
/****** Object:  Table [dbo].[FamilyLicenses]    Script Date: 19/3/2024 12:34:32 ******/
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
/****** Object:  Table [dbo].[FoodPoints]    Script Date: 19/3/2024 12:34:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FoodPoints](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Key] [nvarchar](36) NOT NULL,
	[UserId] [int] NOT NULL,
 CONSTRAINT [PK_FoodPoints] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Languajes]    Script Date: 19/3/2024 12:34:32 ******/
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
/****** Object:  Table [dbo].[LicenseLicense]    Script Date: 19/3/2024 12:34:32 ******/
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
/****** Object:  Table [dbo].[Licenses]    Script Date: 19/3/2024 12:34:32 ******/
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
/****** Object:  Table [dbo].[Logs]    Script Date: 19/3/2024 12:34:32 ******/
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
/****** Object:  Table [dbo].[LogTypes]    Script Date: 19/3/2024 12:34:32 ******/
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
/****** Object:  Table [dbo].[Menus]    Script Date: 19/3/2024 12:34:32 ******/
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
/****** Object:  Table [dbo].[Orders]    Script Date: 19/3/2024 12:34:32 ******/
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
/****** Object:  Table [dbo].[Sections]    Script Date: 19/3/2024 12:34:32 ******/
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
/****** Object:  Table [dbo].[Status]    Script Date: 19/3/2024 12:34:32 ******/
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
/****** Object:  Table [dbo].[Tables]    Script Date: 19/3/2024 12:34:32 ******/
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
/****** Object:  Table [dbo].[Words]    Script Date: 19/3/2024 12:34:32 ******/
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
GO
INSERT [dbo].[AdminUsers] ([Id], [Name], [Password], [Key], [CheckDigit]) VALUES (1, N'Admin', N'WDJIcOK+M7SHQmUCmL/mBWFI5LXAYCT7V/n2S8pXnQtlQ9f2AGakXgDU4061IC1iOsbAgNseVq7+PF2dwlTn3MRQesJs', N'27b2feeb-71de-4994-8e10-e22f867ce6d1', N'dDcGzWRR2R0=')
GO
INSERT [dbo].[AdminUsers] ([Id], [Name], [Password], [Key], [CheckDigit]) VALUES (2, N'Test', N'450Lb0j16huoNYN015Cvvk0Sc+bM67qVwhJ5AHvfsl1vXLO4oKBHGT+DTGI8MJohCQXWQBo52zC+ljvgWXYj13DmNlOCkQ==', N'3fdb1845-1ffa-4bd6-b856-a3fd74975dc0', N'SSodMKdsT78=')
GO
SET IDENTITY_INSERT [dbo].[AdminUsers] OFF
GO
SET IDENTITY_INSERT [dbo].[Bitacoras] ON 
GO
INSERT [dbo].[Bitacoras] ([Id], [TypeId], [Text], [UserId], [Date]) VALUES (1, 1, N'El usuario Admin inicio sesion', 1, CAST(N'2024-03-19T12:32:12.3400000' AS DateTime2))
GO
SET IDENTITY_INSERT [dbo].[Bitacoras] OFF
GO
SET IDENTITY_INSERT [dbo].[DigitColumnVerifications] ON 
GO
INSERT [dbo].[DigitColumnVerifications] ([Id], [Table], [Column], [VerificationDigit]) VALUES (1, N'AdminUsers', N'Name', N'U2n6xCxzuj4=')
GO
INSERT [dbo].[DigitColumnVerifications] ([Id], [Table], [Column], [VerificationDigit]) VALUES (2, N'AdminUsers', N'Key', N'IVe4ZFA79ms=')
GO
INSERT [dbo].[DigitColumnVerifications] ([Id], [Table], [Column], [VerificationDigit]) VALUES (3, N'AdminUsers', N'CheckDigit', N'eEZP0VmpN4c=')
GO
INSERT [dbo].[DigitColumnVerifications] ([Id], [Table], [Column], [VerificationDigit]) VALUES (4, N'AdminUsers', N'Password', N'HrNBUa9XEbM=')
GO
SET IDENTITY_INSERT [dbo].[DigitColumnVerifications] OFF
GO
SET IDENTITY_INSERT [dbo].[Dishes] ON 
GO
INSERT [dbo].[Dishes] ([Id], [Name], [Description], [SectionId], [Price]) VALUES (1, N'Carne al horno', N'Carne al horno con agregado de papas al horno', 1, 2916)
GO
INSERT [dbo].[Dishes] ([Id], [Name], [Description], [SectionId], [Price]) VALUES (2, N'Hamburguesa con queso', N'Carne, queso, lechuga', 1, 204)
GO
INSERT [dbo].[Dishes] ([Id], [Name], [Description], [SectionId], [Price]) VALUES (3, N'Fideos con tuco', N'Fideos caseros con tuco', 2, 1792)
GO
INSERT [dbo].[Dishes] ([Id], [Name], [Description], [SectionId], [Price]) VALUES (4, N'Coca cola', N'Clasica bebida adictiva', 3, 717)
GO
INSERT [dbo].[Dishes] ([Id], [Name], [Description], [SectionId], [Price]) VALUES (5, N'Pepsi', N'Otra clasica bebida adictiva', 3, 4577)
GO
INSERT [dbo].[Dishes] ([Id], [Name], [Description], [SectionId], [Price]) VALUES (6, N'Carne al horno', N'Carne al horno con agregado de papas al horno', 4, 4800)
GO
INSERT [dbo].[Dishes] ([Id], [Name], [Description], [SectionId], [Price]) VALUES (7, N'Empanad de carne', N'Empanada de carne al horno sin papas', 4, 3717)
GO
INSERT [dbo].[Dishes] ([Id], [Name], [Description], [SectionId], [Price]) VALUES (8, N'Fideos con albondingas', N'Fideos con tuco y albondigas', 5, 5828)
GO
INSERT [dbo].[Dishes] ([Id], [Name], [Description], [SectionId], [Price]) VALUES (9, N'Sorrentinos', N'Con salsa blanca', 6, 2402)
GO
INSERT [dbo].[Dishes] ([Id], [Name], [Description], [SectionId], [Price]) VALUES (10, N'Asado', N'A la parrilla', 6, 9103)
GO
INSERT [dbo].[Dishes] ([Id], [Name], [Description], [SectionId], [Price]) VALUES (11, N'Churrasco', N'Carne a la plancha', 7, 4679)
GO
INSERT [dbo].[Dishes] ([Id], [Name], [Description], [SectionId], [Price]) VALUES (12, N'Ñoquis', N'Con salsa mixta', 7, 6348)
GO
INSERT [dbo].[Dishes] ([Id], [Name], [Description], [SectionId], [Price]) VALUES (13, N'Costillas de cerdo', N'Recien extraidas de dicho animal', 8, 8843)
GO
INSERT [dbo].[Dishes] ([Id], [Name], [Description], [SectionId], [Price]) VALUES (14, N'Milanesa', N'Tipica milanesa Argentina', 8, 6976)
GO
INSERT [dbo].[Dishes] ([Id], [Name], [Description], [SectionId], [Price]) VALUES (15, N'Ravioles', N'De verdura como le gustan a mi amigo el tano', 9, 3263)
GO
INSERT [dbo].[Dishes] ([Id], [Name], [Description], [SectionId], [Price]) VALUES (16, N'Canelones', N'Con verdura o de jamon y queso', 9, 5163)
GO
SET IDENTITY_INSERT [dbo].[Dishes] OFF
GO
SET IDENTITY_INSERT [dbo].[EventTypes] ON 
GO
INSERT [dbo].[EventTypes] ([Id], [Code], [Name]) VALUES (1, 1, N'Log In')
GO
INSERT [dbo].[EventTypes] ([Id], [Code], [Name]) VALUES (2, 2, N'Log Off')
GO
INSERT [dbo].[EventTypes] ([Id], [Code], [Name]) VALUES (3, 3, N'Grant Access to user')
GO
INSERT [dbo].[EventTypes] ([Id], [Code], [Name]) VALUES (4, 4, N'Data modified')
GO
INSERT [dbo].[EventTypes] ([Id], [Code], [Name]) VALUES (5, 5, N'Delete Data')
GO
SET IDENTITY_INSERT [dbo].[EventTypes] OFF
GO
SET IDENTITY_INSERT [dbo].[FamilyLicenses] ON 
GO
INSERT [dbo].[FamilyLicenses] ([Id], [Name]) VALUES (1, N'Default Family')
GO
SET IDENTITY_INSERT [dbo].[FamilyLicenses] OFF
GO
SET IDENTITY_INSERT [dbo].[FoodPoints] ON 
GO
INSERT [dbo].[FoodPoints] ([Id], [Name], [Key], [UserId]) VALUES (1, N'Barba roja', N'31C163A7-0A73-45C3-922A-09B4F3A53365', 1)
GO
INSERT [dbo].[FoodPoints] ([Id], [Name], [Key], [UserId]) VALUES (2, N'Checka', N'A868C9D0-6ED7-40CE-B290-0C693009BDF5', 1)
GO
INSERT [dbo].[FoodPoints] ([Id], [Name], [Key], [UserId]) VALUES (3, N'MC Donald', N'D633DC80-EF1A-4769-9B0B-4ED972E982C9', 1)
GO
INSERT [dbo].[FoodPoints] ([Id], [Name], [Key], [UserId]) VALUES (4, N'Burguer King', N'AFACC120-1152-4241-BB8E-D9D01CC5E976', 1)
GO
SET IDENTITY_INSERT [dbo].[FoodPoints] OFF
GO
SET IDENTITY_INSERT [dbo].[Languajes] ON 
GO
INSERT [dbo].[Languajes] ([Id], [Name], [Code]) VALUES (1, N'English', 1)
GO
INSERT [dbo].[Languajes] ([Id], [Name], [Code]) VALUES (2, N'Español', 2)
GO
SET IDENTITY_INSERT [dbo].[Languajes] OFF
GO
SET IDENTITY_INSERT [dbo].[LicenseLicense] ON 
GO
INSERT [dbo].[LicenseLicense] ([Id], [IdPadre], [IdHijo], [FamilyLicenseId]) VALUES (1, 0, 1, 1)
GO
INSERT [dbo].[LicenseLicense] ([Id], [IdPadre], [IdHijo], [FamilyLicenseId]) VALUES (2, 1, 2, 1)
GO
INSERT [dbo].[LicenseLicense] ([Id], [IdPadre], [IdHijo], [FamilyLicenseId]) VALUES (3, 2, 3, 1)
GO
INSERT [dbo].[LicenseLicense] ([Id], [IdPadre], [IdHijo], [FamilyLicenseId]) VALUES (4, 2, 7, 1)
GO
INSERT [dbo].[LicenseLicense] ([Id], [IdPadre], [IdHijo], [FamilyLicenseId]) VALUES (5, 3, 4, 1)
GO
INSERT [dbo].[LicenseLicense] ([Id], [IdPadre], [IdHijo], [FamilyLicenseId]) VALUES (6, 3, 5, 1)
GO
INSERT [dbo].[LicenseLicense] ([Id], [IdPadre], [IdHijo], [FamilyLicenseId]) VALUES (7, 3, 6, 1)
GO
INSERT [dbo].[LicenseLicense] ([Id], [IdPadre], [IdHijo], [FamilyLicenseId]) VALUES (8, 7, 8, 1)
GO
INSERT [dbo].[LicenseLicense] ([Id], [IdPadre], [IdHijo], [FamilyLicenseId]) VALUES (9, 7, 9, 1)
GO
INSERT [dbo].[LicenseLicense] ([Id], [IdPadre], [IdHijo], [FamilyLicenseId]) VALUES (10, 7, 10, 1)
GO
SET IDENTITY_INSERT [dbo].[LicenseLicense] OFF
GO
SET IDENTITY_INSERT [dbo].[Licenses] ON 
GO
INSERT [dbo].[Licenses] ([Id], [Name], [Code]) VALUES (1, N'All', 1)
GO
INSERT [dbo].[Licenses] ([Id], [Name], [Code]) VALUES (2, N'Restorant', 2)
GO
INSERT [dbo].[Licenses] ([Id], [Name], [Code]) VALUES (3, N'Edit menu', 3)
GO
INSERT [dbo].[Licenses] ([Id], [Name], [Code]) VALUES (4, N'Name', 4)
GO
INSERT [dbo].[Licenses] ([Id], [Name], [Code]) VALUES (5, N'Price', 5)
GO
INSERT [dbo].[Licenses] ([Id], [Name], [Code]) VALUES (6, N'Section', 6)
GO
INSERT [dbo].[Licenses] ([Id], [Name], [Code]) VALUES (7, N'Schedule', 7)
GO
INSERT [dbo].[Licenses] ([Id], [Name], [Code]) VALUES (8, N'Week days', 8)
GO
INSERT [dbo].[Licenses] ([Id], [Name], [Code]) VALUES (9, N'Open time', 9)
GO
INSERT [dbo].[Licenses] ([Id], [Name], [Code]) VALUES (10, N'Close time', 10)
GO
SET IDENTITY_INSERT [dbo].[Licenses] OFF
GO
SET IDENTITY_INSERT [dbo].[Logs] ON 
GO
INSERT [dbo].[Logs] ([Id], [TypeId], [Message], [Date]) VALUES (1, 1, N'Se esta intentando iniciar sesion con el usuario: Admin', CAST(N'2024-03-19T12:32:12.2633333' AS DateTime2))
GO
INSERT [dbo].[Logs] ([Id], [TypeId], [Message], [Date]) VALUES (2, 1, N'Usuario Admin Key: 27b2feeb-71de-4994-8e10-e22f867ce6d1 Inicio sesion', CAST(N'2024-03-19T12:32:12.3333333' AS DateTime2))
GO
SET IDENTITY_INSERT [dbo].[Logs] OFF
GO
SET IDENTITY_INSERT [dbo].[LogTypes] ON 
GO
INSERT [dbo].[LogTypes] ([Id], [Code], [Name]) VALUES (1, 1, N'Info')
GO
INSERT [dbo].[LogTypes] ([Id], [Code], [Name]) VALUES (2, 2, N'Warning')
GO
INSERT [dbo].[LogTypes] ([Id], [Code], [Name]) VALUES (3, 3, N'Error')
GO
SET IDENTITY_INSERT [dbo].[LogTypes] OFF
GO
SET IDENTITY_INSERT [dbo].[Menus] ON 
GO
INSERT [dbo].[Menus] ([Id], [Description], [FoodPointId]) VALUES (1, N'Menu del bar Barba Roja', 1)
GO
INSERT [dbo].[Menus] ([Id], [Description], [FoodPointId]) VALUES (2, N'Menu del bar Checka', 2)
GO
INSERT [dbo].[Menus] ([Id], [Description], [FoodPointId]) VALUES (3, N'Menu de MacDonalds', 3)
GO
INSERT [dbo].[Menus] ([Id], [Description], [FoodPointId]) VALUES (4, N'Menu de Burguer King', 4)
GO
SET IDENTITY_INSERT [dbo].[Menus] OFF
GO
SET IDENTITY_INSERT [dbo].[Sections] ON 
GO
INSERT [dbo].[Sections] ([Id], [Name], [Description], [Position], [MenuId]) VALUES (1, N'Carnes', N'Seccion de carnes del menu', 1, 1)
GO
INSERT [dbo].[Sections] ([Id], [Name], [Description], [Position], [MenuId]) VALUES (2, N'Pastas', N'Seccion de pastas del menu', 2, 1)
GO
INSERT [dbo].[Sections] ([Id], [Name], [Description], [Position], [MenuId]) VALUES (3, N'Bebidas', N'Seccion de bebidas del menu', 3, 1)
GO
INSERT [dbo].[Sections] ([Id], [Name], [Description], [Position], [MenuId]) VALUES (4, N'Carnes', N'Seccion de carnes del menu', 1, 2)
GO
INSERT [dbo].[Sections] ([Id], [Name], [Description], [Position], [MenuId]) VALUES (5, N'Pastas', N'Seccion de pastas del menu', 2, 2)
GO
INSERT [dbo].[Sections] ([Id], [Name], [Description], [Position], [MenuId]) VALUES (6, N'Carnes', N'Seccion de carnes del menu', 1, 3)
GO
INSERT [dbo].[Sections] ([Id], [Name], [Description], [Position], [MenuId]) VALUES (7, N'Pastas', N'Seccion de pastas del menu', 2, 3)
GO
INSERT [dbo].[Sections] ([Id], [Name], [Description], [Position], [MenuId]) VALUES (8, N'Carnes', N'Seccion de carnes del menu', 1, 4)
GO
INSERT [dbo].[Sections] ([Id], [Name], [Description], [Position], [MenuId]) VALUES (9, N'Pastas', N'Seccion de pastas del menu', 2, 4)
GO
SET IDENTITY_INSERT [dbo].[Sections] OFF
GO
SET IDENTITY_INSERT [dbo].[Status] ON 
GO
INSERT [dbo].[Status] ([Id], [Code], [Name]) VALUES (1, 1, N'En proceso de confirmacion')
GO
INSERT [dbo].[Status] ([Id], [Code], [Name]) VALUES (2, 2, N'Aceptado')
GO
INSERT [dbo].[Status] ([Id], [Code], [Name]) VALUES (3, 3, N'Rechazado')
GO
INSERT [dbo].[Status] ([Id], [Code], [Name]) VALUES (4, 4, N'En proceso de coccion')
GO
INSERT [dbo].[Status] ([Id], [Code], [Name]) VALUES (5, 5, N'En espera para entrega')
GO
INSERT [dbo].[Status] ([Id], [Code], [Name]) VALUES (6, 6, N'En espera')
GO
INSERT [dbo].[Status] ([Id], [Code], [Name]) VALUES (7, 7, N'Finalizado correctamente')
GO
INSERT [dbo].[Status] ([Id], [Code], [Name]) VALUES (8, 8, N'Cancelado')
GO
INSERT [dbo].[Status] ([Id], [Code], [Name]) VALUES (9, 9, N'Entregado correctamente')
GO
INSERT [dbo].[Status] ([Id], [Code], [Name]) VALUES (10, 10, N'Fallo la entrega')
GO
SET IDENTITY_INSERT [dbo].[Status] OFF
GO
SET IDENTITY_INSERT [dbo].[Tables] ON 
GO
INSERT [dbo].[Tables] ([Id], [QR], [FoodPointId]) VALUES (1, N'80a4447e-b663-4f7b-b2f4-4f30dab174ad', 1)
GO
INSERT [dbo].[Tables] ([Id], [QR], [FoodPointId]) VALUES (2, N'5c7ea574-c135-4cde-acd4-b68fc323b82a', 1)
GO
INSERT [dbo].[Tables] ([Id], [QR], [FoodPointId]) VALUES (3, N'54044ced-7da7-4a0b-8e2d-d7b774419524', 1)
GO
INSERT [dbo].[Tables] ([Id], [QR], [FoodPointId]) VALUES (4, N'635d7923-2c10-4ac2-8cda-d55d1cfc6604', 2)
GO
INSERT [dbo].[Tables] ([Id], [QR], [FoodPointId]) VALUES (5, N'1c05e797-4430-4503-a09f-5340b58351cd', 2)
GO
INSERT [dbo].[Tables] ([Id], [QR], [FoodPointId]) VALUES (6, N'8c739832-694c-4ce8-a7a7-ae5a795aba5c', 3)
GO
INSERT [dbo].[Tables] ([Id], [QR], [FoodPointId]) VALUES (7, N'cc565416-18fe-4544-a704-0343c98cfe19', 3)
GO
INSERT [dbo].[Tables] ([Id], [QR], [FoodPointId]) VALUES (8, N'cb1f7fd3-bf92-4514-989c-e4aa6dda9c2e', 4)
GO
INSERT [dbo].[Tables] ([Id], [QR], [FoodPointId]) VALUES (9, N'c67001c8-9d18-4b77-8009-2152bb932a34', 4)
GO
INSERT [dbo].[Tables] ([Id], [QR], [FoodPointId]) VALUES (10, N'936d3751-0fbe-4872-a61b-26e7e8a60e79', 4)
GO
SET IDENTITY_INSERT [dbo].[Tables] OFF
GO
SET IDENTITY_INSERT [dbo].[Words] ON 
GO
INSERT [dbo].[Words] ([Id], [LanguajeId], [Text], [Code]) VALUES (1, 1, N'Home', 1)
GO
INSERT [dbo].[Words] ([Id], [LanguajeId], [Text], [Code]) VALUES (2, 1, N'Users', 2)
GO
INSERT [dbo].[Words] ([Id], [LanguajeId], [Text], [Code]) VALUES (3, 1, N'Config', 3)
GO
INSERT [dbo].[Words] ([Id], [LanguajeId], [Text], [Code]) VALUES (4, 1, N'Permissions Assignments', 4)
GO
INSERT [dbo].[Words] ([Id], [LanguajeId], [Text], [Code]) VALUES (5, 1, N'Permissions', 5)
GO
INSERT [dbo].[Words] ([Id], [LanguajeId], [Text], [Code]) VALUES (6, 2, N'Principal', 1)
GO
INSERT [dbo].[Words] ([Id], [LanguajeId], [Text], [Code]) VALUES (7, 2, N'Usuarios', 2)
GO
INSERT [dbo].[Words] ([Id], [LanguajeId], [Text], [Code]) VALUES (8, 2, N'Config', 3)
GO
INSERT [dbo].[Words] ([Id], [LanguajeId], [Text], [Code]) VALUES (9, 2, N'Asignar permisos', 4)
GO
INSERT [dbo].[Words] ([Id], [LanguajeId], [Text], [Code]) VALUES (10, 2, N'Permisos', 5)
GO
SET IDENTITY_INSERT [dbo].[Words] OFF
GO
/****** Object:  Index [IX_AdminUserHistorical_UserId]    Script Date: 19/3/2024 12:34:32 ******/
CREATE NONCLUSTERED INDEX [IX_AdminUserHistorical_UserId] ON [dbo].[AdminUserHistorical]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_AdminUserLicenses_AdminUserId]    Script Date: 19/3/2024 12:34:32 ******/
CREATE NONCLUSTERED INDEX [IX_AdminUserLicenses_AdminUserId] ON [dbo].[AdminUserLicenses]
(
	[AdminUserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_AdminUserLicenses_LicensesId]    Script Date: 19/3/2024 12:34:32 ******/
CREATE NONCLUSTERED INDEX [IX_AdminUserLicenses_LicensesId] ON [dbo].[AdminUserLicenses]
(
	[LicensesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_UQ_NameUniqueColumn]    Script Date: 19/3/2024 12:34:32 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_UQ_NameUniqueColumn] ON [dbo].[AdminUsers]
(
	[Name] ASC
)
WHERE ([Name] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Bitacoras_TypeId]    Script Date: 19/3/2024 12:34:32 ******/
CREATE NONCLUSTERED INDEX [IX_Bitacoras_TypeId] ON [dbo].[Bitacoras]
(
	[TypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Bitacoras_UserId]    Script Date: 19/3/2024 12:34:32 ******/
CREATE NONCLUSTERED INDEX [IX_Bitacoras_UserId] ON [dbo].[Bitacoras]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Dishes_SectionId]    Script Date: 19/3/2024 12:34:32 ******/
CREATE NONCLUSTERED INDEX [IX_Dishes_SectionId] ON [dbo].[Dishes]
(
	[SectionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_DishOrders_DishId]    Script Date: 19/3/2024 12:34:32 ******/
CREATE NONCLUSTERED INDEX [IX_DishOrders_DishId] ON [dbo].[DishOrders]
(
	[DishId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_DishOrders_OrderId]    Script Date: 19/3/2024 12:34:32 ******/
CREATE NONCLUSTERED INDEX [IX_DishOrders_OrderId] ON [dbo].[DishOrders]
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_FoodPoints_UserId]    Script Date: 19/3/2024 12:34:32 ******/
CREATE NONCLUSTERED INDEX [IX_FoodPoints_UserId] ON [dbo].[FoodPoints]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_LicenseLicense_FamilyLicenseId]    Script Date: 19/3/2024 12:34:32 ******/
CREATE NONCLUSTERED INDEX [IX_LicenseLicense_FamilyLicenseId] ON [dbo].[LicenseLicense]
(
	[FamilyLicenseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Logs_TypeId]    Script Date: 19/3/2024 12:34:32 ******/
CREATE NONCLUSTERED INDEX [IX_Logs_TypeId] ON [dbo].[Logs]
(
	[TypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Menus_FoodPointId]    Script Date: 19/3/2024 12:34:32 ******/
CREATE NONCLUSTERED INDEX [IX_Menus_FoodPointId] ON [dbo].[Menus]
(
	[FoodPointId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Orders_AdminUsersId]    Script Date: 19/3/2024 12:34:32 ******/
CREATE NONCLUSTERED INDEX [IX_Orders_AdminUsersId] ON [dbo].[Orders]
(
	[AdminUsersId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Orders_FoodPointId]    Script Date: 19/3/2024 12:34:32 ******/
CREATE NONCLUSTERED INDEX [IX_Orders_FoodPointId] ON [dbo].[Orders]
(
	[FoodPointId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Orders_StatusId]    Script Date: 19/3/2024 12:34:32 ******/
CREATE NONCLUSTERED INDEX [IX_Orders_StatusId] ON [dbo].[Orders]
(
	[StatusId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Sections_MenuId]    Script Date: 19/3/2024 12:34:32 ******/
CREATE NONCLUSTERED INDEX [IX_Sections_MenuId] ON [dbo].[Sections]
(
	[MenuId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Tables_FoodPointId]    Script Date: 19/3/2024 12:34:32 ******/
CREATE NONCLUSTERED INDEX [IX_Tables_FoodPointId] ON [dbo].[Tables]
(
	[FoodPointId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Words_LanguajeId]    Script Date: 19/3/2024 12:34:32 ******/
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
ALTER TABLE [dbo].[FoodPoints] ADD  DEFAULT ((0)) FOR [UserId]
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
ALTER TABLE [dbo].[FoodPoints]  WITH CHECK ADD  CONSTRAINT [FK_FoodPoints_AdminUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AdminUsers] ([Id])
GO
ALTER TABLE [dbo].[FoodPoints] CHECK CONSTRAINT [FK_FoodPoints_AdminUsers_UserId]
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
