USE [Cz.Project]
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
SET IDENTITY_INSERT [dbo].[AdminUsers] ON 
GO
INSERT [dbo].[AdminUsers] ([Id], [Name], [Password], [Key], [CheckDigit]) VALUES (1, N'Admin', N'WDJIcOK+M7SHQmUCmL/mBWFI5LXAYCT7V/n2S8pXnQtlQ9f2AGakXgDU4061IC1iOsbAgNseVq7+PF2dwlTn3MRQesJs', N'27b2feeb-71de-4994-8e10-e22f867ce6d1', N'dDcGzWRR2R0=')
GO
SET IDENTITY_INSERT [dbo].[AdminUsers] OFF
GO
SET IDENTITY_INSERT [dbo].[FoodPoints] ON 
GO
INSERT [dbo].[FoodPoints] ([Id], [Name], [Key]) VALUES (1, N'Barba roja', N'BB1A16CD-EB5B-4850-AB1B-7B491940B6DE')
GO
INSERT [dbo].[FoodPoints] ([Id], [Name], [Key]) VALUES (2, N'Checka', N'FD2F4061-BCA9-420A-B928-8C7A643B409E')
GO
INSERT [dbo].[FoodPoints] ([Id], [Name], [Key]) VALUES (3, N'MC Donald', N'E5D35EB0-2913-494E-A5AC-222F3CF50163')
GO
INSERT [dbo].[FoodPoints] ([Id], [Name], [Key]) VALUES (4, N'Burguer King', N'A4528820-E3E1-4456-9820-B3C06A5EC57F')
GO
SET IDENTITY_INSERT [dbo].[FoodPoints] OFF
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
SET IDENTITY_INSERT [dbo].[Orders] ON 
GO
INSERT [dbo].[Orders] ([Id], [Number], [Detail], [Amount], [StatusId], [ChangeStatusDate], [StartDate], [EndDate], [AdminUsersId], [FoodPointId], [Key]) VALUES (1, 1, N'', 20273, 9, CAST(N'2023-11-20T18:18:48.7600000' AS DateTime2), CAST(N'2023-11-20T14:56:16.8300000' AS DateTime2), NULL, 1, 1, N'FC16E053-159C-4000-A702-8DE471DDF283')
GO
INSERT [dbo].[Orders] ([Id], [Number], [Detail], [Amount], [StatusId], [ChangeStatusDate], [StartDate], [EndDate], [AdminUsersId], [FoodPointId], [Key]) VALUES (2, 2, N'', 899, 5, CAST(N'2023-11-20T14:57:25.4900000' AS DateTime2), CAST(N'2023-11-20T14:56:27.8433333' AS DateTime2), NULL, 1, 4, N'62B87F8F-274A-45DA-9F09-7EB2AF7C1BF7')
GO
INSERT [dbo].[Orders] ([Id], [Number], [Detail], [Amount], [StatusId], [ChangeStatusDate], [StartDate], [EndDate], [AdminUsersId], [FoodPointId], [Key]) VALUES (3, 3, N'', 899, 1, CAST(N'2023-11-20T14:56:29.6600000' AS DateTime2), CAST(N'2023-11-20T14:56:29.6600000' AS DateTime2), NULL, 1, 4, N'A0A450EB-E820-4F2D-8AF6-93133FDE9E63')
GO
INSERT [dbo].[Orders] ([Id], [Number], [Detail], [Amount], [StatusId], [ChangeStatusDate], [StartDate], [EndDate], [AdminUsersId], [FoodPointId], [Key]) VALUES (4, 4, N'', 2552, 1, CAST(N'2023-11-20T14:56:39.0166667' AS DateTime2), CAST(N'2023-11-20T14:56:39.0166667' AS DateTime2), NULL, 1, 4, N'E3AD1E4A-8A39-467B-9B13-DD9CE12A735A')
GO
SET IDENTITY_INSERT [dbo].[Orders] OFF
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
SET IDENTITY_INSERT [dbo].[Bitacoras] ON 
GO
INSERT [dbo].[Bitacoras] ([Id], [TypeId], [Text], [UserId], [Date]) VALUES (1, 1, N'El usuario Admin inicio sesion', 1, CAST(N'2023-11-20T14:55:58.2566667' AS DateTime2))
GO
INSERT [dbo].[Bitacoras] ([Id], [TypeId], [Text], [UserId], [Date]) VALUES (2, 1, N'El usuario Admin inicio sesion', 1, CAST(N'2023-11-20T15:11:47.6233333' AS DateTime2))
GO
INSERT [dbo].[Bitacoras] ([Id], [TypeId], [Text], [UserId], [Date]) VALUES (3, 1, N'El usuario Admin inicio sesion', 1, CAST(N'2023-11-20T17:48:13.5266667' AS DateTime2))
GO
INSERT [dbo].[Bitacoras] ([Id], [TypeId], [Text], [UserId], [Date]) VALUES (4, 1, N'El usuario Admin inicio sesion', 1, CAST(N'2023-11-20T17:51:31.4166667' AS DateTime2))
GO
INSERT [dbo].[Bitacoras] ([Id], [TypeId], [Text], [UserId], [Date]) VALUES (5, 1, N'El usuario Admin inicio sesion', 1, CAST(N'2023-11-20T17:51:56.5200000' AS DateTime2))
GO
INSERT [dbo].[Bitacoras] ([Id], [TypeId], [Text], [UserId], [Date]) VALUES (6, 1, N'El usuario Admin inicio sesion', 1, CAST(N'2023-11-20T17:53:22.5200000' AS DateTime2))
GO
INSERT [dbo].[Bitacoras] ([Id], [TypeId], [Text], [UserId], [Date]) VALUES (7, 1, N'El usuario Admin inicio sesion', 1, CAST(N'2023-11-20T17:53:53.3500000' AS DateTime2))
GO
INSERT [dbo].[Bitacoras] ([Id], [TypeId], [Text], [UserId], [Date]) VALUES (8, 1, N'El usuario Admin inicio sesion', 1, CAST(N'2023-11-20T17:55:59.6466667' AS DateTime2))
GO
INSERT [dbo].[Bitacoras] ([Id], [TypeId], [Text], [UserId], [Date]) VALUES (9, 1, N'El usuario Admin inicio sesion', 1, CAST(N'2023-11-20T17:56:36.5600000' AS DateTime2))
GO
INSERT [dbo].[Bitacoras] ([Id], [TypeId], [Text], [UserId], [Date]) VALUES (10, 1, N'El usuario Admin inicio sesion', 1, CAST(N'2023-11-20T18:01:39.5766667' AS DateTime2))
GO
INSERT [dbo].[Bitacoras] ([Id], [TypeId], [Text], [UserId], [Date]) VALUES (11, 1, N'El usuario Admin inicio sesion', 1, CAST(N'2023-11-20T18:01:57.9000000' AS DateTime2))
GO
INSERT [dbo].[Bitacoras] ([Id], [TypeId], [Text], [UserId], [Date]) VALUES (12, 1, N'El usuario Admin inicio sesion', 1, CAST(N'2023-11-20T18:13:07.2900000' AS DateTime2))
GO
INSERT [dbo].[Bitacoras] ([Id], [TypeId], [Text], [UserId], [Date]) VALUES (13, 1, N'El usuario Admin inicio sesion', 1, CAST(N'2023-11-20T18:17:28.2766667' AS DateTime2))
GO
INSERT [dbo].[Bitacoras] ([Id], [TypeId], [Text], [UserId], [Date]) VALUES (14, 1, N'El usuario Admin inicio sesion', 1, CAST(N'2023-11-20T18:18:43.1966667' AS DateTime2))
GO
INSERT [dbo].[Bitacoras] ([Id], [TypeId], [Text], [UserId], [Date]) VALUES (15, 1, N'El usuario Admin inicio sesion', 1, CAST(N'2023-11-20T18:20:41.7400000' AS DateTime2))
GO
INSERT [dbo].[Bitacoras] ([Id], [TypeId], [Text], [UserId], [Date]) VALUES (16, 1, N'El usuario Admin inicio sesion', 1, CAST(N'2023-11-20T18:21:15.8400000' AS DateTime2))
GO
INSERT [dbo].[Bitacoras] ([Id], [TypeId], [Text], [UserId], [Date]) VALUES (17, 1, N'El usuario Admin inicio sesion', 1, CAST(N'2023-11-20T18:21:45.7900000' AS DateTime2))
GO
INSERT [dbo].[Bitacoras] ([Id], [TypeId], [Text], [UserId], [Date]) VALUES (18, 1, N'El usuario Admin inicio sesion', 1, CAST(N'2023-11-20T18:22:36.0866667' AS DateTime2))
GO
INSERT [dbo].[Bitacoras] ([Id], [TypeId], [Text], [UserId], [Date]) VALUES (19, 1, N'El usuario Admin inicio sesion', 1, CAST(N'2023-11-21T01:25:10.7733333' AS DateTime2))
GO
INSERT [dbo].[Bitacoras] ([Id], [TypeId], [Text], [UserId], [Date]) VALUES (20, 1, N'El usuario Admin inicio sesion', 1, CAST(N'2023-11-21T01:33:40.9566667' AS DateTime2))
GO
INSERT [dbo].[Bitacoras] ([Id], [TypeId], [Text], [UserId], [Date]) VALUES (1002, 1, N'El usuario Admin inicio sesion', 1, CAST(N'2023-11-29T15:22:33.3666667' AS DateTime2))
GO
SET IDENTITY_INSERT [dbo].[Bitacoras] OFF
GO
SET IDENTITY_INSERT [dbo].[Languajes] ON 
GO
INSERT [dbo].[Languajes] ([Id], [Name], [Code]) VALUES (1, N'English', 1)
GO
INSERT [dbo].[Languajes] ([Id], [Name], [Code]) VALUES (2, N'Español', 2)
GO
SET IDENTITY_INSERT [dbo].[Languajes] OFF
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
SET IDENTITY_INSERT [dbo].[Logs] ON 
GO
INSERT [dbo].[Logs] ([Id], [TypeId], [Message], [Date]) VALUES (1, 1, N'Se esta intentando iniciar sesion con el usuario: Admin', CAST(N'2023-11-20T14:55:58.1866667' AS DateTime2))
GO
INSERT [dbo].[Logs] ([Id], [TypeId], [Message], [Date]) VALUES (2, 1, N'Usuario Admin Key: 27b2feeb-71de-4994-8e10-e22f867ce6d1 Inicio sesion', CAST(N'2023-11-20T14:55:58.2500000' AS DateTime2))
GO
INSERT [dbo].[Logs] ([Id], [TypeId], [Message], [Date]) VALUES (3, 1, N'Se esta intentando iniciar sesion con el usuario: Admin', CAST(N'2023-11-20T15:11:47.5666667' AS DateTime2))
GO
INSERT [dbo].[Logs] ([Id], [TypeId], [Message], [Date]) VALUES (4, 1, N'Usuario Admin Key: 27b2feeb-71de-4994-8e10-e22f867ce6d1 Inicio sesion', CAST(N'2023-11-20T15:11:47.6200000' AS DateTime2))
GO
INSERT [dbo].[Logs] ([Id], [TypeId], [Message], [Date]) VALUES (5, 1, N'Se esta intentando iniciar sesion con el usuario: Admin', CAST(N'2023-11-20T17:48:13.4666667' AS DateTime2))
GO
INSERT [dbo].[Logs] ([Id], [TypeId], [Message], [Date]) VALUES (6, 1, N'Usuario Admin Key: 27b2feeb-71de-4994-8e10-e22f867ce6d1 Inicio sesion', CAST(N'2023-11-20T17:48:13.5233333' AS DateTime2))
GO
INSERT [dbo].[Logs] ([Id], [TypeId], [Message], [Date]) VALUES (7, 1, N'Se esta intentando iniciar sesion con el usuario: Admin', CAST(N'2023-11-20T17:51:31.3633333' AS DateTime2))
GO
INSERT [dbo].[Logs] ([Id], [TypeId], [Message], [Date]) VALUES (8, 1, N'Usuario Admin Key: 27b2feeb-71de-4994-8e10-e22f867ce6d1 Inicio sesion', CAST(N'2023-11-20T17:51:31.4100000' AS DateTime2))
GO
INSERT [dbo].[Logs] ([Id], [TypeId], [Message], [Date]) VALUES (9, 1, N'Se esta intentando iniciar sesion con el usuario: Admin', CAST(N'2023-11-20T17:51:56.4466667' AS DateTime2))
GO
INSERT [dbo].[Logs] ([Id], [TypeId], [Message], [Date]) VALUES (10, 1, N'Usuario Admin Key: 27b2feeb-71de-4994-8e10-e22f867ce6d1 Inicio sesion', CAST(N'2023-11-20T17:51:56.4966667' AS DateTime2))
GO
INSERT [dbo].[Logs] ([Id], [TypeId], [Message], [Date]) VALUES (11, 1, N'Se esta intentando iniciar sesion con el usuario: Admin', CAST(N'2023-11-20T17:53:22.4566667' AS DateTime2))
GO
INSERT [dbo].[Logs] ([Id], [TypeId], [Message], [Date]) VALUES (12, 1, N'Usuario Admin Key: 27b2feeb-71de-4994-8e10-e22f867ce6d1 Inicio sesion', CAST(N'2023-11-20T17:53:22.5133333' AS DateTime2))
GO
INSERT [dbo].[Logs] ([Id], [TypeId], [Message], [Date]) VALUES (13, 1, N'Se esta intentando iniciar sesion con el usuario: Admin', CAST(N'2023-11-20T17:53:53.2933333' AS DateTime2))
GO
INSERT [dbo].[Logs] ([Id], [TypeId], [Message], [Date]) VALUES (14, 1, N'Usuario Admin Key: 27b2feeb-71de-4994-8e10-e22f867ce6d1 Inicio sesion', CAST(N'2023-11-20T17:53:53.3466667' AS DateTime2))
GO
INSERT [dbo].[Logs] ([Id], [TypeId], [Message], [Date]) VALUES (15, 1, N'Se esta intentando iniciar sesion con el usuario: Admin', CAST(N'2023-11-20T17:55:59.5866667' AS DateTime2))
GO
INSERT [dbo].[Logs] ([Id], [TypeId], [Message], [Date]) VALUES (16, 1, N'Usuario Admin Key: 27b2feeb-71de-4994-8e10-e22f867ce6d1 Inicio sesion', CAST(N'2023-11-20T17:55:59.6400000' AS DateTime2))
GO
INSERT [dbo].[Logs] ([Id], [TypeId], [Message], [Date]) VALUES (17, 1, N'Se esta intentando iniciar sesion con el usuario: Admin', CAST(N'2023-11-20T17:56:36.5033333' AS DateTime2))
GO
INSERT [dbo].[Logs] ([Id], [TypeId], [Message], [Date]) VALUES (18, 1, N'Usuario Admin Key: 27b2feeb-71de-4994-8e10-e22f867ce6d1 Inicio sesion', CAST(N'2023-11-20T17:56:36.5533333' AS DateTime2))
GO
INSERT [dbo].[Logs] ([Id], [TypeId], [Message], [Date]) VALUES (19, 1, N'Se esta intentando iniciar sesion con el usuario: Admin', CAST(N'2023-11-20T18:01:39.5233333' AS DateTime2))
GO
INSERT [dbo].[Logs] ([Id], [TypeId], [Message], [Date]) VALUES (20, 1, N'Usuario Admin Key: 27b2feeb-71de-4994-8e10-e22f867ce6d1 Inicio sesion', CAST(N'2023-11-20T18:01:39.5733333' AS DateTime2))
GO
INSERT [dbo].[Logs] ([Id], [TypeId], [Message], [Date]) VALUES (21, 1, N'Se esta intentando iniciar sesion con el usuario: Admin', CAST(N'2023-11-20T18:01:57.8433333' AS DateTime2))
GO
INSERT [dbo].[Logs] ([Id], [TypeId], [Message], [Date]) VALUES (22, 1, N'Usuario Admin Key: 27b2feeb-71de-4994-8e10-e22f867ce6d1 Inicio sesion', CAST(N'2023-11-20T18:01:57.8966667' AS DateTime2))
GO
INSERT [dbo].[Logs] ([Id], [TypeId], [Message], [Date]) VALUES (23, 1, N'Se esta intentando iniciar sesion con el usuario: Admin', CAST(N'2023-11-20T18:13:07.2333333' AS DateTime2))
GO
INSERT [dbo].[Logs] ([Id], [TypeId], [Message], [Date]) VALUES (24, 1, N'Usuario Admin Key: 27b2feeb-71de-4994-8e10-e22f867ce6d1 Inicio sesion', CAST(N'2023-11-20T18:13:07.2833333' AS DateTime2))
GO
INSERT [dbo].[Logs] ([Id], [TypeId], [Message], [Date]) VALUES (25, 1, N'Se esta intentando iniciar sesion con el usuario: Admin', CAST(N'2023-11-20T18:17:28.2066667' AS DateTime2))
GO
INSERT [dbo].[Logs] ([Id], [TypeId], [Message], [Date]) VALUES (26, 1, N'Usuario Admin Key: 27b2feeb-71de-4994-8e10-e22f867ce6d1 Inicio sesion', CAST(N'2023-11-20T18:17:28.2700000' AS DateTime2))
GO
INSERT [dbo].[Logs] ([Id], [TypeId], [Message], [Date]) VALUES (27, 1, N'Se esta intentando iniciar sesion con el usuario: Admin', CAST(N'2023-11-20T18:18:43.1366667' AS DateTime2))
GO
INSERT [dbo].[Logs] ([Id], [TypeId], [Message], [Date]) VALUES (28, 1, N'Usuario Admin Key: 27b2feeb-71de-4994-8e10-e22f867ce6d1 Inicio sesion', CAST(N'2023-11-20T18:18:43.1933333' AS DateTime2))
GO
INSERT [dbo].[Logs] ([Id], [TypeId], [Message], [Date]) VALUES (29, 1, N'Se esta intentando iniciar sesion con el usuario: Admin', CAST(N'2023-11-20T18:20:41.6800000' AS DateTime2))
GO
INSERT [dbo].[Logs] ([Id], [TypeId], [Message], [Date]) VALUES (30, 1, N'Usuario Admin Key: 27b2feeb-71de-4994-8e10-e22f867ce6d1 Inicio sesion', CAST(N'2023-11-20T18:20:41.7333333' AS DateTime2))
GO
INSERT [dbo].[Logs] ([Id], [TypeId], [Message], [Date]) VALUES (31, 1, N'Se esta intentando iniciar sesion con el usuario: Admin', CAST(N'2023-11-20T18:21:15.7900000' AS DateTime2))
GO
INSERT [dbo].[Logs] ([Id], [TypeId], [Message], [Date]) VALUES (32, 1, N'Usuario Admin Key: 27b2feeb-71de-4994-8e10-e22f867ce6d1 Inicio sesion', CAST(N'2023-11-20T18:21:15.8366667' AS DateTime2))
GO
INSERT [dbo].[Logs] ([Id], [TypeId], [Message], [Date]) VALUES (33, 1, N'Se esta intentando iniciar sesion con el usuario: Admin', CAST(N'2023-11-20T18:21:45.7366667' AS DateTime2))
GO
INSERT [dbo].[Logs] ([Id], [TypeId], [Message], [Date]) VALUES (34, 1, N'Usuario Admin Key: 27b2feeb-71de-4994-8e10-e22f867ce6d1 Inicio sesion', CAST(N'2023-11-20T18:21:45.7833333' AS DateTime2))
GO
INSERT [dbo].[Logs] ([Id], [TypeId], [Message], [Date]) VALUES (35, 1, N'Se esta intentando iniciar sesion con el usuario: Admin', CAST(N'2023-11-20T18:22:36.0333333' AS DateTime2))
GO
INSERT [dbo].[Logs] ([Id], [TypeId], [Message], [Date]) VALUES (36, 1, N'Usuario Admin Key: 27b2feeb-71de-4994-8e10-e22f867ce6d1 Inicio sesion', CAST(N'2023-11-20T18:22:36.0833333' AS DateTime2))
GO
INSERT [dbo].[Logs] ([Id], [TypeId], [Message], [Date]) VALUES (37, 1, N'Se esta intentando iniciar sesion con el usuario: Admin', CAST(N'2023-11-21T01:25:10.7100000' AS DateTime2))
GO
INSERT [dbo].[Logs] ([Id], [TypeId], [Message], [Date]) VALUES (38, 1, N'Usuario Admin Key: 27b2feeb-71de-4994-8e10-e22f867ce6d1 Inicio sesion', CAST(N'2023-11-21T01:25:10.7633333' AS DateTime2))
GO
INSERT [dbo].[Logs] ([Id], [TypeId], [Message], [Date]) VALUES (39, 1, N'Se esta intentando iniciar sesion con el usuario: Admin', CAST(N'2023-11-21T01:33:40.9033333' AS DateTime2))
GO
INSERT [dbo].[Logs] ([Id], [TypeId], [Message], [Date]) VALUES (40, 1, N'Usuario Admin Key: 27b2feeb-71de-4994-8e10-e22f867ce6d1 Inicio sesion', CAST(N'2023-11-21T01:33:40.9500000' AS DateTime2))
GO
INSERT [dbo].[Logs] ([Id], [TypeId], [Message], [Date]) VALUES (1002, 1, N'Se esta intentando iniciar sesion con el usuario: Admin', CAST(N'2023-11-29T15:22:33.2066667' AS DateTime2))
GO
INSERT [dbo].[Logs] ([Id], [TypeId], [Message], [Date]) VALUES (1003, 1, N'Usuario Admin Key: 27b2feeb-71de-4994-8e10-e22f867ce6d1 Inicio sesion', CAST(N'2023-11-29T15:22:33.3033333' AS DateTime2))
GO
SET IDENTITY_INSERT [dbo].[Logs] OFF
GO
SET IDENTITY_INSERT [dbo].[FamilyLicenses] ON 
GO
INSERT [dbo].[FamilyLicenses] ([Id], [Name]) VALUES (1, N'Default Family')
GO
SET IDENTITY_INSERT [dbo].[FamilyLicenses] OFF
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
SET IDENTITY_INSERT [dbo].[Tables] ON 
GO
INSERT [dbo].[Tables] ([Id], [QR], [FoodPointId]) VALUES (1, N'8cb8ca28-03f0-4a66-b2aa-d2292e2e6a75', 1)
GO
INSERT [dbo].[Tables] ([Id], [QR], [FoodPointId]) VALUES (2, N'ac1f39d5-7224-45cb-a2de-5b780962bcb4', 1)
GO
INSERT [dbo].[Tables] ([Id], [QR], [FoodPointId]) VALUES (3, N'73ba34c5-2d92-4c28-a522-449aa8921d5d', 1)
GO
INSERT [dbo].[Tables] ([Id], [QR], [FoodPointId]) VALUES (4, N'11ec4a9b-f1e9-4d33-b237-3f717fb3862a', 2)
GO
INSERT [dbo].[Tables] ([Id], [QR], [FoodPointId]) VALUES (5, N'6fd4f657-fe1c-4956-a1dd-4a9a59eae05f', 2)
GO
INSERT [dbo].[Tables] ([Id], [QR], [FoodPointId]) VALUES (6, N'b5a06175-ce30-4a07-a3d1-3c898a54d5bc', 3)
GO
INSERT [dbo].[Tables] ([Id], [QR], [FoodPointId]) VALUES (7, N'4704ec2d-10b7-4243-a99a-dddb91942dd1', 3)
GO
INSERT [dbo].[Tables] ([Id], [QR], [FoodPointId]) VALUES (8, N'b5942954-0349-4efc-af43-0d0c48202727', 4)
GO
INSERT [dbo].[Tables] ([Id], [QR], [FoodPointId]) VALUES (9, N'f2f74a7b-882d-450c-baf3-c0d7ddbdf53d', 4)
GO
INSERT [dbo].[Tables] ([Id], [QR], [FoodPointId]) VALUES (10, N'f30be126-14e9-4600-a47f-f6cc3c4adb01', 4)
GO
SET IDENTITY_INSERT [dbo].[Tables] OFF
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
SET IDENTITY_INSERT [dbo].[Dishes] ON 
GO
INSERT [dbo].[Dishes] ([Id], [Name], [Description], [SectionId], [Price]) VALUES (1, N'Carne al horno', N'Carne al horno con agregado de papas al horno', 1, 3709)
GO
INSERT [dbo].[Dishes] ([Id], [Name], [Description], [SectionId], [Price]) VALUES (2, N'Hamburguesa con queso', N'Carne, queso, lechuga', 1, 4850)
GO
INSERT [dbo].[Dishes] ([Id], [Name], [Description], [SectionId], [Price]) VALUES (3, N'Fideos con tuco', N'Fideos caseros con tuco', 2, 7232)
GO
INSERT [dbo].[Dishes] ([Id], [Name], [Description], [SectionId], [Price]) VALUES (4, N'Coca cola', N'Clasica bebida adictiva', 3, 9332)
GO
INSERT [dbo].[Dishes] ([Id], [Name], [Description], [SectionId], [Price]) VALUES (5, N'Pepsi', N'Otra clasica bebida adictiva', 3, 6642)
GO
INSERT [dbo].[Dishes] ([Id], [Name], [Description], [SectionId], [Price]) VALUES (6, N'Carne al horno', N'Carne al horno con agregado de papas al horno', 4, 4025)
GO
INSERT [dbo].[Dishes] ([Id], [Name], [Description], [SectionId], [Price]) VALUES (7, N'Empanad de carne', N'Empanada de carne al horno sin papas', 4, 8003)
GO
INSERT [dbo].[Dishes] ([Id], [Name], [Description], [SectionId], [Price]) VALUES (8, N'Fideos con albondingas', N'Fideos con tuco y albondigas', 5, 3966)
GO
INSERT [dbo].[Dishes] ([Id], [Name], [Description], [SectionId], [Price]) VALUES (9, N'Sorrentinos', N'Con salsa blanca', 6, 7070)
GO
INSERT [dbo].[Dishes] ([Id], [Name], [Description], [SectionId], [Price]) VALUES (10, N'Asado', N'A la parrilla', 6, 2672)
GO
INSERT [dbo].[Dishes] ([Id], [Name], [Description], [SectionId], [Price]) VALUES (11, N'Churrasco', N'Carne a la plancha', 7, 6435)
GO
INSERT [dbo].[Dishes] ([Id], [Name], [Description], [SectionId], [Price]) VALUES (12, N'Ñoquis', N'Con salsa mixta', 7, 8983)
GO
INSERT [dbo].[Dishes] ([Id], [Name], [Description], [SectionId], [Price]) VALUES (13, N'Costillas de cerdo', N'Recien extraidas de dicho animal', 8, 262)
GO
INSERT [dbo].[Dishes] ([Id], [Name], [Description], [SectionId], [Price]) VALUES (14, N'Milanesa', N'Tipica milanesa Argentina', 8, 3152)
GO
INSERT [dbo].[Dishes] ([Id], [Name], [Description], [SectionId], [Price]) VALUES (15, N'Ravioles', N'De verdura como le gustan a mi amigo el tano', 9, 2290)
GO
INSERT [dbo].[Dishes] ([Id], [Name], [Description], [SectionId], [Price]) VALUES (16, N'Canelones', N'Con verdura o de jamon y queso', 9, 637)
GO
SET IDENTITY_INSERT [dbo].[Dishes] OFF
GO
SET IDENTITY_INSERT [dbo].[DishOrders] ON 
GO
INSERT [dbo].[DishOrders] ([Id], [DishId], [OrderId]) VALUES (1, 1, 1)
GO
INSERT [dbo].[DishOrders] ([Id], [DishId], [OrderId]) VALUES (2, 3, 1)
GO
INSERT [dbo].[DishOrders] ([Id], [DishId], [OrderId]) VALUES (3, 4, 1)
GO
INSERT [dbo].[DishOrders] ([Id], [DishId], [OrderId]) VALUES (4, 13, 2)
GO
INSERT [dbo].[DishOrders] ([Id], [DishId], [OrderId]) VALUES (5, 16, 2)
GO
INSERT [dbo].[DishOrders] ([Id], [DishId], [OrderId]) VALUES (6, 13, 3)
GO
INSERT [dbo].[DishOrders] ([Id], [DishId], [OrderId]) VALUES (7, 16, 3)
GO
INSERT [dbo].[DishOrders] ([Id], [DishId], [OrderId]) VALUES (8, 13, 4)
GO
INSERT [dbo].[DishOrders] ([Id], [DishId], [OrderId]) VALUES (9, 15, 4)
GO
SET IDENTITY_INSERT [dbo].[DishOrders] OFF
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
