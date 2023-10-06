USE [master]
GO
/****** Object:  Database [Cz.Project]    Script Date: 6/10/2023 18:23:34 ******/
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
/****** Object:  Table [dbo].[AdminUserHistorical]    Script Date: 6/10/2023 18:23:34 ******/
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
/****** Object:  Table [dbo].[AdminUserLicenses]    Script Date: 6/10/2023 18:23:34 ******/
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
/****** Object:  Table [dbo].[AdminUsers]    Script Date: 6/10/2023 18:23:34 ******/
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
/****** Object:  Table [dbo].[Bitacoras]    Script Date: 6/10/2023 18:23:34 ******/
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
/****** Object:  Table [dbo].[DigitColumnVerifications]    Script Date: 6/10/2023 18:23:34 ******/
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
/****** Object:  Table [dbo].[EventTypes]    Script Date: 6/10/2023 18:23:34 ******/
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
/****** Object:  Table [dbo].[FamilyLicenses]    Script Date: 6/10/2023 18:23:34 ******/
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
/****** Object:  Table [dbo].[Languajes]    Script Date: 6/10/2023 18:23:34 ******/
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
/****** Object:  Table [dbo].[LicenseLicense]    Script Date: 6/10/2023 18:23:34 ******/
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
/****** Object:  Table [dbo].[Licenses]    Script Date: 6/10/2023 18:23:34 ******/
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
/****** Object:  Table [dbo].[Logs]    Script Date: 6/10/2023 18:23:34 ******/
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
/****** Object:  Table [dbo].[LogTypes]    Script Date: 6/10/2023 18:23:34 ******/
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
/****** Object:  Table [dbo].[Words]    Script Date: 6/10/2023 18:23:34 ******/
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
SET IDENTITY_INSERT [dbo].[AdminUsers] OFF
GO
SET IDENTITY_INSERT [dbo].[DigitColumnVerifications] ON 
GO
INSERT [dbo].[DigitColumnVerifications] ([Id], [Table], [Column], [VerificationDigit]) VALUES (1, N'AdminUsers', N'Name', N'9swuVZL8VHI=')
GO
INSERT [dbo].[DigitColumnVerifications] ([Id], [Table], [Column], [VerificationDigit]) VALUES (2, N'AdminUsers', N'Key', N'evHGCiZozRY=')
GO
INSERT [dbo].[DigitColumnVerifications] ([Id], [Table], [Column], [VerificationDigit]) VALUES (3, N'AdminUsers', N'CheckDigit', N'Kt1TGCFkVV0=')
GO
INSERT [dbo].[DigitColumnVerifications] ([Id], [Table], [Column], [VerificationDigit]) VALUES (4, N'AdminUsers', N'Password', N'z9Ox4s6jjEQ=')
GO
SET IDENTITY_INSERT [dbo].[DigitColumnVerifications] OFF
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
/****** Object:  Index [IX_AdminUserHistorical_UserId]    Script Date: 6/10/2023 18:23:34 ******/
CREATE NONCLUSTERED INDEX [IX_AdminUserHistorical_UserId] ON [dbo].[AdminUserHistorical]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_AdminUserLicenses_AdminUserId]    Script Date: 6/10/2023 18:23:34 ******/
CREATE NONCLUSTERED INDEX [IX_AdminUserLicenses_AdminUserId] ON [dbo].[AdminUserLicenses]
(
	[AdminUserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_AdminUserLicenses_LicensesId]    Script Date: 6/10/2023 18:23:34 ******/
CREATE NONCLUSTERED INDEX [IX_AdminUserLicenses_LicensesId] ON [dbo].[AdminUserLicenses]
(
	[LicensesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_UQ_NameUniqueColumn]    Script Date: 6/10/2023 18:23:34 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_UQ_NameUniqueColumn] ON [dbo].[AdminUsers]
(
	[Name] ASC
)
WHERE ([Name] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Bitacoras_TypeId]    Script Date: 6/10/2023 18:23:34 ******/
CREATE NONCLUSTERED INDEX [IX_Bitacoras_TypeId] ON [dbo].[Bitacoras]
(
	[TypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Bitacoras_UserId]    Script Date: 6/10/2023 18:23:34 ******/
CREATE NONCLUSTERED INDEX [IX_Bitacoras_UserId] ON [dbo].[Bitacoras]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_LicenseLicense_FamilyLicenseId]    Script Date: 6/10/2023 18:23:34 ******/
CREATE NONCLUSTERED INDEX [IX_LicenseLicense_FamilyLicenseId] ON [dbo].[LicenseLicense]
(
	[FamilyLicenseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Logs_TypeId]    Script Date: 6/10/2023 18:23:34 ******/
CREATE NONCLUSTERED INDEX [IX_Logs_TypeId] ON [dbo].[Logs]
(
	[TypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Words_LanguajeId]    Script Date: 6/10/2023 18:23:34 ******/
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
ALTER TABLE [dbo].[Licenses] ADD  DEFAULT ((0)) FOR [Code]
GO
ALTER TABLE [dbo].[Logs] ADD  DEFAULT ('0001-01-01T00:00:00.0000000') FOR [Date]
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
