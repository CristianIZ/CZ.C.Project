USE [master]
GO
/****** Object:  Database [Cz.Project]    Script Date: 22/3/2024 18:35:40 ******/
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
/****** Object:  Table [dbo].[AdminUserHistorical]    Script Date: 22/3/2024 18:35:40 ******/
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
/****** Object:  Table [dbo].[AdminUserLicenses]    Script Date: 22/3/2024 18:35:40 ******/
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
/****** Object:  Table [dbo].[AdminUsers]    Script Date: 22/3/2024 18:35:40 ******/
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
/****** Object:  Table [dbo].[Bitacoras]    Script Date: 22/3/2024 18:35:40 ******/
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
/****** Object:  Table [dbo].[DigitColumnVerifications]    Script Date: 22/3/2024 18:35:40 ******/
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
/****** Object:  Table [dbo].[Dishes]    Script Date: 22/3/2024 18:35:40 ******/
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
	[IsDeleted] [bit] NOT NULL,
 CONSTRAINT [PK_Dishes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DishOrders]    Script Date: 22/3/2024 18:35:40 ******/
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
/****** Object:  Table [dbo].[EventTypes]    Script Date: 22/3/2024 18:35:40 ******/
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
/****** Object:  Table [dbo].[FamilyLicenses]    Script Date: 22/3/2024 18:35:40 ******/
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
/****** Object:  Table [dbo].[FoodPoints]    Script Date: 22/3/2024 18:35:40 ******/
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
/****** Object:  Table [dbo].[Languajes]    Script Date: 22/3/2024 18:35:40 ******/
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
/****** Object:  Table [dbo].[LicenseLicense]    Script Date: 22/3/2024 18:35:40 ******/
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
/****** Object:  Table [dbo].[Licenses]    Script Date: 22/3/2024 18:35:40 ******/
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
/****** Object:  Table [dbo].[Logs]    Script Date: 22/3/2024 18:35:40 ******/
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
/****** Object:  Table [dbo].[LogTypes]    Script Date: 22/3/2024 18:35:40 ******/
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
/****** Object:  Table [dbo].[Menus]    Script Date: 22/3/2024 18:35:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Menus](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[FoodPointId] [int] NULL,
	[IsDeleted] [bit] NOT NULL,
 CONSTRAINT [PK_Menus] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 22/3/2024 18:35:40 ******/
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
/****** Object:  Table [dbo].[Sections]    Script Date: 22/3/2024 18:35:40 ******/
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
	[IsDeleted] [bit] NOT NULL,
 CONSTRAINT [PK_Sections] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Status]    Script Date: 22/3/2024 18:35:40 ******/
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
/****** Object:  Table [dbo].[Tables]    Script Date: 22/3/2024 18:35:40 ******/
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
/****** Object:  Table [dbo].[Words]    Script Date: 22/3/2024 18:35:40 ******/
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
INSERT [dbo].[Dishes] ([Id], [Name], [Description], [SectionId], [Price], [IsDeleted]) VALUES (1, N'Carne al horno', N'Carne al horno con agregado de papas al horno', 1, 2866, 0)
GO
INSERT [dbo].[Dishes] ([Id], [Name], [Description], [SectionId], [Price], [IsDeleted]) VALUES (2, N'Hamburguesa con queso', N'Carne, queso, lechuga', 1, 9245, 0)
GO
INSERT [dbo].[Dishes] ([Id], [Name], [Description], [SectionId], [Price], [IsDeleted]) VALUES (3, N'Fideos con tuco', N'Fideos caseros con tuco', 2, 2235, 0)
GO
INSERT [dbo].[Dishes] ([Id], [Name], [Description], [SectionId], [Price], [IsDeleted]) VALUES (4, N'Coca cola', N'Clasica bebida adictiva', 3, 84, 0)
GO
INSERT [dbo].[Dishes] ([Id], [Name], [Description], [SectionId], [Price], [IsDeleted]) VALUES (5, N'Pepsi', N'Otra clasica bebida adictiva', 3, 4395, 0)
GO
INSERT [dbo].[Dishes] ([Id], [Name], [Description], [SectionId], [Price], [IsDeleted]) VALUES (6, N'Carne al horno', N'Carne al horno con agregado de papas al horno', 4, 2426, 0)
GO
INSERT [dbo].[Dishes] ([Id], [Name], [Description], [SectionId], [Price], [IsDeleted]) VALUES (7, N'Empanad de carne', N'Empanada de carne al horno sin papas', 4, 3429, 0)
GO
INSERT [dbo].[Dishes] ([Id], [Name], [Description], [SectionId], [Price], [IsDeleted]) VALUES (8, N'Fideos con albondingas', N'Fideos con tuco y albondigas', 5, 2170, 0)
GO
INSERT [dbo].[Dishes] ([Id], [Name], [Description], [SectionId], [Price], [IsDeleted]) VALUES (9, N'Sorrentinos', N'Con salsa blanca', 6, 4320, 0)
GO
INSERT [dbo].[Dishes] ([Id], [Name], [Description], [SectionId], [Price], [IsDeleted]) VALUES (10, N'Asado', N'A la parrilla', 6, 9736, 0)
GO
INSERT [dbo].[Dishes] ([Id], [Name], [Description], [SectionId], [Price], [IsDeleted]) VALUES (11, N'Churrasco', N'Carne a la plancha', 7, 3061, 0)
GO
INSERT [dbo].[Dishes] ([Id], [Name], [Description], [SectionId], [Price], [IsDeleted]) VALUES (12, N'Ñoquis', N'Con salsa mixta', 7, 2816, 0)
GO
INSERT [dbo].[Dishes] ([Id], [Name], [Description], [SectionId], [Price], [IsDeleted]) VALUES (13, N'Costillas de cerdo', N'Recien extraidas de dicho animal', 8, 3939, 0)
GO
INSERT [dbo].[Dishes] ([Id], [Name], [Description], [SectionId], [Price], [IsDeleted]) VALUES (14, N'Milanesa', N'Tipica milanesa Argentina', 8, 7687, 0)
GO
INSERT [dbo].[Dishes] ([Id], [Name], [Description], [SectionId], [Price], [IsDeleted]) VALUES (15, N'Ravioles', N'De verdura como le gustan a mi amigo el tano', 9, 4477, 0)
GO
INSERT [dbo].[Dishes] ([Id], [Name], [Description], [SectionId], [Price], [IsDeleted]) VALUES (16, N'Canelones', N'Con verdura o de jamon y queso', 9, 4721, 0)
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
INSERT [dbo].[FoodPoints] ([Id], [Name], [Key], [UserId]) VALUES (1, N'Barba roja', N'F2455280-F173-49C5-9527-8BC7C4406D8C', 1)
GO
INSERT [dbo].[FoodPoints] ([Id], [Name], [Key], [UserId]) VALUES (2, N'Checka', N'B69D00D0-FE61-4933-B6EE-D0117A768021', 1)
GO
INSERT [dbo].[FoodPoints] ([Id], [Name], [Key], [UserId]) VALUES (3, N'MC Donald', N'E2FFEA28-C917-4DEA-B627-CA172B82ACD8', 1)
GO
INSERT [dbo].[FoodPoints] ([Id], [Name], [Key], [UserId]) VALUES (4, N'Burguer King', N'69A4A5C1-960C-454D-8135-20F6314F806E', 1)
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
INSERT [dbo].[Menus] ([Id], [Description], [FoodPointId], [IsDeleted]) VALUES (1, N'Menu del bar Barba Roja', 1, 0)
GO
INSERT [dbo].[Menus] ([Id], [Description], [FoodPointId], [IsDeleted]) VALUES (2, N'Menu del bar Checka', 2, 0)
GO
INSERT [dbo].[Menus] ([Id], [Description], [FoodPointId], [IsDeleted]) VALUES (3, N'Menu de MacDonalds', 3, 0)
GO
INSERT [dbo].[Menus] ([Id], [Description], [FoodPointId], [IsDeleted]) VALUES (4, N'Menu de Burguer King', 4, 0)
GO
SET IDENTITY_INSERT [dbo].[Menus] OFF
GO
SET IDENTITY_INSERT [dbo].[Sections] ON 
GO
INSERT [dbo].[Sections] ([Id], [Name], [Description], [Position], [MenuId], [IsDeleted]) VALUES (1, N'Carnes', N'Seccion de carnes del menu', 1, 1, 0)
GO
INSERT [dbo].[Sections] ([Id], [Name], [Description], [Position], [MenuId], [IsDeleted]) VALUES (2, N'Pastas', N'Seccion de pastas del menu', 2, 1, 0)
GO
INSERT [dbo].[Sections] ([Id], [Name], [Description], [Position], [MenuId], [IsDeleted]) VALUES (3, N'Bebidas', N'Seccion de bebidas del menu', 3, 1, 0)
GO
INSERT [dbo].[Sections] ([Id], [Name], [Description], [Position], [MenuId], [IsDeleted]) VALUES (4, N'Carnes', N'Seccion de carnes del menu', 1, 2, 0)
GO
INSERT [dbo].[Sections] ([Id], [Name], [Description], [Position], [MenuId], [IsDeleted]) VALUES (5, N'Pastas', N'Seccion de pastas del menu', 2, 2, 0)
GO
INSERT [dbo].[Sections] ([Id], [Name], [Description], [Position], [MenuId], [IsDeleted]) VALUES (6, N'Carnes', N'Seccion de carnes del menu', 1, 3, 0)
GO
INSERT [dbo].[Sections] ([Id], [Name], [Description], [Position], [MenuId], [IsDeleted]) VALUES (7, N'Pastas', N'Seccion de pastas del menu', 2, 3, 0)
GO
INSERT [dbo].[Sections] ([Id], [Name], [Description], [Position], [MenuId], [IsDeleted]) VALUES (8, N'Carnes', N'Seccion de carnes del menu', 1, 4, 0)
GO
INSERT [dbo].[Sections] ([Id], [Name], [Description], [Position], [MenuId], [IsDeleted]) VALUES (9, N'Pastas', N'Seccion de pastas del menu', 2, 4, 0)
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
INSERT [dbo].[Tables] ([Id], [QR], [FoodPointId]) VALUES (1, N'194a0d86-ada4-4ac2-8a2f-b93dd11b61ed', 1)
GO
INSERT [dbo].[Tables] ([Id], [QR], [FoodPointId]) VALUES (2, N'a959d1ea-6103-4fb4-abfc-e0b450547f01', 1)
GO
INSERT [dbo].[Tables] ([Id], [QR], [FoodPointId]) VALUES (3, N'8dbf0480-8d96-427d-9294-a5b5d303e29f', 1)
GO
INSERT [dbo].[Tables] ([Id], [QR], [FoodPointId]) VALUES (4, N'dc797add-74a1-4f27-8a95-9eaf3f155976', 2)
GO
INSERT [dbo].[Tables] ([Id], [QR], [FoodPointId]) VALUES (5, N'9aee03c0-ed77-4b7a-9b2a-16338bdd0be7', 2)
GO
INSERT [dbo].[Tables] ([Id], [QR], [FoodPointId]) VALUES (6, N'910f29f9-d23b-4594-8f3e-54d77039310a', 3)
GO
INSERT [dbo].[Tables] ([Id], [QR], [FoodPointId]) VALUES (7, N'869fc4e6-84df-4c14-81bf-6ef4438c9456', 3)
GO
INSERT [dbo].[Tables] ([Id], [QR], [FoodPointId]) VALUES (8, N'f5baf69f-4846-413f-9812-41c53f871ab6', 4)
GO
INSERT [dbo].[Tables] ([Id], [QR], [FoodPointId]) VALUES (9, N'ac695f9b-e52c-4cc5-af65-9bc8c349d874', 4)
GO
INSERT [dbo].[Tables] ([Id], [QR], [FoodPointId]) VALUES (10, N'2a3b3386-67ff-4f9d-a2f9-0237874a7a1d', 4)
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
INSERT [dbo].[Words] ([Id], [LanguajeId], [Text], [Code]) VALUES (11, 1, N'Add Languaje', 6)
GO
INSERT [dbo].[Words] ([Id], [LanguajeId], [Text], [Code]) VALUES (12, 1, N'Make Order', 7)
GO
INSERT [dbo].[Words] ([Id], [LanguajeId], [Text], [Code]) VALUES (13, 1, N'Order Management', 8)
GO
INSERT [dbo].[Words] ([Id], [LanguajeId], [Text], [Code]) VALUES (14, 1, N'View Orders', 9)
GO
INSERT [dbo].[Words] ([Id], [LanguajeId], [Text], [Code]) VALUES (15, 1, N'Menu Management', 10)
GO
INSERT [dbo].[Words] ([Id], [LanguajeId], [Text], [Code]) VALUES (16, 2, N'Nuevo Lenguaje', 6)
GO
INSERT [dbo].[Words] ([Id], [LanguajeId], [Text], [Code]) VALUES (17, 2, N'Realizar Pedido', 7)
GO
INSERT [dbo].[Words] ([Id], [LanguajeId], [Text], [Code]) VALUES (18, 2, N'Gestionar Pedido', 8)
GO
INSERT [dbo].[Words] ([Id], [LanguajeId], [Text], [Code]) VALUES (19, 2, N'Visualizar Pedido', 9)
GO
INSERT [dbo].[Words] ([Id], [LanguajeId], [Text], [Code]) VALUES (20, 2, N'Gestionar Menu', 10)
GO
SET IDENTITY_INSERT [dbo].[Words] OFF
GO
/****** Object:  Index [IX_AdminUserHistorical_UserId]    Script Date: 22/3/2024 18:35:40 ******/
CREATE NONCLUSTERED INDEX [IX_AdminUserHistorical_UserId] ON [dbo].[AdminUserHistorical]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_AdminUserLicenses_AdminUserId]    Script Date: 22/3/2024 18:35:40 ******/
CREATE NONCLUSTERED INDEX [IX_AdminUserLicenses_AdminUserId] ON [dbo].[AdminUserLicenses]
(
	[AdminUserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_AdminUserLicenses_LicensesId]    Script Date: 22/3/2024 18:35:40 ******/
CREATE NONCLUSTERED INDEX [IX_AdminUserLicenses_LicensesId] ON [dbo].[AdminUserLicenses]
(
	[LicensesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_UQ_NameUniqueColumn]    Script Date: 22/3/2024 18:35:40 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_UQ_NameUniqueColumn] ON [dbo].[AdminUsers]
(
	[Name] ASC
)
WHERE ([Name] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Bitacoras_TypeId]    Script Date: 22/3/2024 18:35:40 ******/
CREATE NONCLUSTERED INDEX [IX_Bitacoras_TypeId] ON [dbo].[Bitacoras]
(
	[TypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Bitacoras_UserId]    Script Date: 22/3/2024 18:35:40 ******/
CREATE NONCLUSTERED INDEX [IX_Bitacoras_UserId] ON [dbo].[Bitacoras]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Dishes_SectionId]    Script Date: 22/3/2024 18:35:40 ******/
CREATE NONCLUSTERED INDEX [IX_Dishes_SectionId] ON [dbo].[Dishes]
(
	[SectionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_DishOrders_DishId]    Script Date: 22/3/2024 18:35:40 ******/
CREATE NONCLUSTERED INDEX [IX_DishOrders_DishId] ON [dbo].[DishOrders]
(
	[DishId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_DishOrders_OrderId]    Script Date: 22/3/2024 18:35:40 ******/
CREATE NONCLUSTERED INDEX [IX_DishOrders_OrderId] ON [dbo].[DishOrders]
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_FoodPoints_UserId]    Script Date: 22/3/2024 18:35:40 ******/
CREATE NONCLUSTERED INDEX [IX_FoodPoints_UserId] ON [dbo].[FoodPoints]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_LicenseLicense_FamilyLicenseId]    Script Date: 22/3/2024 18:35:40 ******/
CREATE NONCLUSTERED INDEX [IX_LicenseLicense_FamilyLicenseId] ON [dbo].[LicenseLicense]
(
	[FamilyLicenseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Logs_TypeId]    Script Date: 22/3/2024 18:35:40 ******/
CREATE NONCLUSTERED INDEX [IX_Logs_TypeId] ON [dbo].[Logs]
(
	[TypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Menus_FoodPointId]    Script Date: 22/3/2024 18:35:40 ******/
CREATE NONCLUSTERED INDEX [IX_Menus_FoodPointId] ON [dbo].[Menus]
(
	[FoodPointId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Orders_AdminUsersId]    Script Date: 22/3/2024 18:35:40 ******/
CREATE NONCLUSTERED INDEX [IX_Orders_AdminUsersId] ON [dbo].[Orders]
(
	[AdminUsersId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Orders_FoodPointId]    Script Date: 22/3/2024 18:35:40 ******/
CREATE NONCLUSTERED INDEX [IX_Orders_FoodPointId] ON [dbo].[Orders]
(
	[FoodPointId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Orders_StatusId]    Script Date: 22/3/2024 18:35:40 ******/
CREATE NONCLUSTERED INDEX [IX_Orders_StatusId] ON [dbo].[Orders]
(
	[StatusId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Sections_MenuId]    Script Date: 22/3/2024 18:35:40 ******/
CREATE NONCLUSTERED INDEX [IX_Sections_MenuId] ON [dbo].[Sections]
(
	[MenuId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Tables_FoodPointId]    Script Date: 22/3/2024 18:35:40 ******/
CREATE NONCLUSTERED INDEX [IX_Tables_FoodPointId] ON [dbo].[Tables]
(
	[FoodPointId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Words_LanguajeId]    Script Date: 22/3/2024 18:35:40 ******/
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
ALTER TABLE [dbo].[Dishes] ADD  DEFAULT (CONVERT([bit],(0))) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[FoodPoints] ADD  DEFAULT ((0)) FOR [UserId]
GO
ALTER TABLE [dbo].[Licenses] ADD  DEFAULT ((0)) FOR [Code]
GO
ALTER TABLE [dbo].[Logs] ADD  DEFAULT ('0001-01-01T00:00:00.0000000') FOR [Date]
GO
ALTER TABLE [dbo].[Menus] ADD  DEFAULT (CONVERT([bit],(0))) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[Orders] ADD  DEFAULT ((0)) FOR [StatusId]
GO
ALTER TABLE [dbo].[Orders] ADD  DEFAULT ((0)) FOR [AdminUsersId]
GO
ALTER TABLE [dbo].[Orders] ADD  DEFAULT ((0)) FOR [FoodPointId]
GO
ALTER TABLE [dbo].[Sections] ADD  DEFAULT ((0)) FOR [MenuId]
GO
ALTER TABLE [dbo].[Sections] ADD  DEFAULT (CONVERT([bit],(0))) FOR [IsDeleted]
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
