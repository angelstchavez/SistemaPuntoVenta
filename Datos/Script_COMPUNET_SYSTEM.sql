USE [master]
GO
/****** Object:  Database [DB_PUNTOVENTA]    Script Date: 28/11/2022 13:11:45 ******/
CREATE DATABASE [DB_PUNTOVENTA]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DB_PUNTOVENTA', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\DB_PUNTOVENTA.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DB_PUNTOVENTA_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\DB_PUNTOVENTA_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [DB_PUNTOVENTA] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DB_PUNTOVENTA].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DB_PUNTOVENTA] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DB_PUNTOVENTA] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DB_PUNTOVENTA] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DB_PUNTOVENTA] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DB_PUNTOVENTA] SET ARITHABORT OFF 
GO
ALTER DATABASE [DB_PUNTOVENTA] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [DB_PUNTOVENTA] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DB_PUNTOVENTA] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DB_PUNTOVENTA] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DB_PUNTOVENTA] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DB_PUNTOVENTA] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DB_PUNTOVENTA] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DB_PUNTOVENTA] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DB_PUNTOVENTA] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DB_PUNTOVENTA] SET  ENABLE_BROKER 
GO
ALTER DATABASE [DB_PUNTOVENTA] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DB_PUNTOVENTA] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DB_PUNTOVENTA] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DB_PUNTOVENTA] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DB_PUNTOVENTA] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DB_PUNTOVENTA] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DB_PUNTOVENTA] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DB_PUNTOVENTA] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DB_PUNTOVENTA] SET  MULTI_USER 
GO
ALTER DATABASE [DB_PUNTOVENTA] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DB_PUNTOVENTA] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DB_PUNTOVENTA] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DB_PUNTOVENTA] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DB_PUNTOVENTA] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DB_PUNTOVENTA] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [DB_PUNTOVENTA] SET QUERY_STORE = OFF
GO
USE [DB_PUNTOVENTA]
GO
/****** Object:  UserDefinedTableType [dbo].[EDetalle_Compra]    Script Date: 28/11/2022 13:11:45 ******/
CREATE TYPE [dbo].[EDetalle_Compra] AS TABLE(
	[IdProducto] [int] NULL,
	[PrecioCompra] [decimal](18, 2) NULL,
	[Precioventa] [decimal](18, 2) NULL,
	[Cantidad] [int] NULL,
	[MontoTotal] [decimal](18, 2) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[EDetalle_Venta]    Script Date: 28/11/2022 13:11:45 ******/
CREATE TYPE [dbo].[EDetalle_Venta] AS TABLE(
	[IdProducto] [int] NULL,
	[PrecioVenta] [decimal](18, 2) NULL,
	[Cantidad] [int] NULL,
	[SubTotal] [decimal](18, 2) NULL
)
GO
/****** Object:  Table [dbo].[CATEGORIA]    Script Date: 28/11/2022 13:11:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CATEGORIA](
	[IdCategoria] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](100) NULL,
	[Estado] [bit] NULL,
	[FechaRegistro] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdCategoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CLIENTE]    Script Date: 28/11/2022 13:11:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CLIENTE](
	[IdCliente] [int] IDENTITY(1,1) NOT NULL,
	[Documento] [varchar](50) NULL,
	[NombreCompleto] [varchar](50) NULL,
	[Correo] [varchar](50) NULL,
	[Telefono] [varchar](50) NULL,
	[Estado] [bit] NULL,
	[FechaRegistro] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[COMPRA]    Script Date: 28/11/2022 13:11:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[COMPRA](
	[IdCompra] [int] IDENTITY(1,1) NOT NULL,
	[IdUsuario] [int] NULL,
	[IdProveedor] [int] NULL,
	[TipoDocumento] [varchar](50) NULL,
	[NumeroDocumento] [varchar](50) NULL,
	[MontoTotal] [decimal](10, 2) NULL,
	[FechaRegistro] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdCompra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DETALLE_COMPRA]    Script Date: 28/11/2022 13:11:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DETALLE_COMPRA](
	[IdDetalleCompra] [int] IDENTITY(1,1) NOT NULL,
	[IdCompra] [int] NULL,
	[IdProducto] [int] NULL,
	[PrecioCompra] [decimal](10, 2) NULL,
	[PrecioVenta] [decimal](10, 2) NULL,
	[Cantidad] [int] NULL,
	[MontoTotal] [decimal](10, 2) NULL,
	[FechaRegistro] [datetime] NULL,
 CONSTRAINT [PK__DETALLE___E046CCBBAB574D22] PRIMARY KEY CLUSTERED 
(
	[IdDetalleCompra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DETALLE_VENTA]    Script Date: 28/11/2022 13:11:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DETALLE_VENTA](
	[IdDetalleVenta] [int] IDENTITY(1,1) NOT NULL,
	[IdVenta] [int] NULL,
	[IdProducto] [int] NULL,
	[PrecioVenta] [decimal](10, 2) NULL,
	[Cantidad] [int] NULL,
	[SubTotal] [decimal](10, 2) NULL,
	[FechaRegistro] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdDetalleVenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PAGINA]    Script Date: 28/11/2022 13:11:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PAGINA](
	[IdPagina] [int] IDENTITY(1,1) NOT NULL,
	[Link] [varchar](max) NULL,
 CONSTRAINT [PK_PAGINA] PRIMARY KEY CLUSTERED 
(
	[IdPagina] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PERMISO]    Script Date: 28/11/2022 13:11:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PERMISO](
	[IdPermiso] [int] IDENTITY(1,1) NOT NULL,
	[IdRol] [int] NULL,
	[NombreMenu] [varchar](100) NULL,
	[FechaRegistro] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdPermiso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PRODUCTO]    Script Date: 28/11/2022 13:11:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PRODUCTO](
	[IdProducto] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [varchar](50) NULL,
	[Nombre] [varchar](50) NULL,
	[Descripcion] [varchar](50) NULL,
	[IdCategoria] [int] NULL,
	[Stock] [int] NOT NULL,
	[PrecioCompra] [decimal](10, 2) NULL,
	[PrecioVenta] [decimal](10, 2) NULL,
	[Estado] [bit] NULL,
	[FechaRegistro] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PROVEEDOR]    Script Date: 28/11/2022 13:11:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PROVEEDOR](
	[IdProveedor] [int] IDENTITY(1,1) NOT NULL,
	[Documento] [varchar](50) NULL,
	[RazonSocial] [varchar](50) NULL,
	[Telefono] [varchar](50) NULL,
	[Estado] [bit] NULL,
	[FechaRegistro] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdProveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ROL]    Script Date: 28/11/2022 13:11:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ROL](
	[IdRol] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NULL,
	[FechaRegistro] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdRol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[USUARIO]    Script Date: 28/11/2022 13:11:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[USUARIO](
	[IdUsuario] [int] IDENTITY(1,1) NOT NULL,
	[Documento] [varchar](50) NULL,
	[NombreCompleto] [varchar](50) NULL,
	[Correo] [varchar](50) NULL,
	[Clave] [varchar](50) NULL,
	[IdRol] [int] NULL,
	[Estado] [bit] NULL,
	[FechaRegistro] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VENTA]    Script Date: 28/11/2022 13:11:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VENTA](
	[IdVenta] [int] IDENTITY(1,1) NOT NULL,
	[IdUsuario] [int] NULL,
	[TipoDocumento] [varchar](50) NULL,
	[NumeroDocumento] [varchar](50) NULL,
	[NombreCliente] [varchar](100) NULL,
	[DocumentoCliente] [varchar](50) NULL,
	[MontoPago] [decimal](10, 2) NULL,
	[MontoCambio] [decimal](10, 2) NULL,
	[MontoTotal] [decimal](10, 2) NULL,
	[FechaRegistro] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdVenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[CATEGORIA] ON 
GO
INSERT [dbo].[CATEGORIA] ([IdCategoria], [Descripcion], [Estado], [FechaRegistro]) VALUES (1, N'Teclado', 0, CAST(N'2022-11-18T17:15:38.860' AS DateTime))
GO
INSERT [dbo].[CATEGORIA] ([IdCategoria], [Descripcion], [Estado], [FechaRegistro]) VALUES (2, N'Mouse', 1, CAST(N'2022-11-18T17:15:38.867' AS DateTime))
GO
INSERT [dbo].[CATEGORIA] ([IdCategoria], [Descripcion], [Estado], [FechaRegistro]) VALUES (3, N'Unidad almacenamiento', 1, CAST(N'2022-11-18T17:15:38.867' AS DateTime))
GO
INSERT [dbo].[CATEGORIA] ([IdCategoria], [Descripcion], [Estado], [FechaRegistro]) VALUES (4, N'Procesador', 0, CAST(N'2022-11-18T17:15:38.867' AS DateTime))
GO
INSERT [dbo].[CATEGORIA] ([IdCategoria], [Descripcion], [Estado], [FechaRegistro]) VALUES (5, N'Board', 1, CAST(N'2022-11-18T17:15:38.870' AS DateTime))
GO
INSERT [dbo].[CATEGORIA] ([IdCategoria], [Descripcion], [Estado], [FechaRegistro]) VALUES (6, N'Memoria RAM', 1, CAST(N'2022-11-18T17:15:38.870' AS DateTime))
GO
INSERT [dbo].[CATEGORIA] ([IdCategoria], [Descripcion], [Estado], [FechaRegistro]) VALUES (7, N'Tarjeta grafica', 1, CAST(N'2022-11-18T17:15:38.870' AS DateTime))
GO
INSERT [dbo].[CATEGORIA] ([IdCategoria], [Descripcion], [Estado], [FechaRegistro]) VALUES (8, N'Chasis', 1, CAST(N'2022-11-18T17:15:38.870' AS DateTime))
GO
INSERT [dbo].[CATEGORIA] ([IdCategoria], [Descripcion], [Estado], [FechaRegistro]) VALUES (9, N'Monitor', 1, CAST(N'2022-11-18T17:39:21.217' AS DateTime))
GO
INSERT [dbo].[CATEGORIA] ([IdCategoria], [Descripcion], [Estado], [FechaRegistro]) VALUES (10, N'Ventilador', 1, CAST(N'2022-11-19T16:37:03.030' AS DateTime))
GO
INSERT [dbo].[CATEGORIA] ([IdCategoria], [Descripcion], [Estado], [FechaRegistro]) VALUES (14, N'Cascos', 0, CAST(N'2022-11-21T19:01:29.657' AS DateTime))
GO
INSERT [dbo].[CATEGORIA] ([IdCategoria], [Descripcion], [Estado], [FechaRegistro]) VALUES (15, N'Adaptador', 1, CAST(N'2022-11-23T15:04:46.123' AS DateTime))
GO
INSERT [dbo].[CATEGORIA] ([IdCategoria], [Descripcion], [Estado], [FechaRegistro]) VALUES (16, N'Parlantes', 1, CAST(N'2022-11-28T12:30:44.630' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[CATEGORIA] OFF
GO
SET IDENTITY_INSERT [dbo].[CLIENTE] ON 
GO
INSERT [dbo].[CLIENTE] ([IdCliente], [Documento], [NombreCompleto], [Correo], [Telefono], [Estado], [FechaRegistro]) VALUES (111, N'16788982', N'Jane Yang', N'janeyang7373@protonmail.couk', N'(817) 731-5681', 1, CAST(N'2022-11-20T16:57:48.197' AS DateTime))
GO
INSERT [dbo].[CLIENTE] ([IdCliente], [Documento], [NombreCompleto], [Correo], [Telefono], [Estado], [FechaRegistro]) VALUES (112, N'5667419', N'Ishmael Glenn', N'ishmaelglenn@protonmail.com', N'(747) 906-7139', 0, CAST(N'2022-11-20T16:57:48.197' AS DateTime))
GO
INSERT [dbo].[CLIENTE] ([IdCliente], [Documento], [NombreCompleto], [Correo], [Telefono], [Estado], [FechaRegistro]) VALUES (113, N'25212925', N'Alana Kidd', N'alanakidd1252@yahoo.edu', N'(401) 593-2227', 1, CAST(N'2022-11-20T16:57:48.197' AS DateTime))
GO
INSERT [dbo].[CLIENTE] ([IdCliente], [Documento], [NombreCompleto], [Correo], [Telefono], [Estado], [FechaRegistro]) VALUES (114, N'72609007', N'Galena Roberts', N'galenaroberts9360@hotmail.edu', N'(959) 469-7445', 0, CAST(N'2022-11-20T16:57:48.197' AS DateTime))
GO
INSERT [dbo].[CLIENTE] ([IdCliente], [Documento], [NombreCompleto], [Correo], [Telefono], [Estado], [FechaRegistro]) VALUES (115, N'67547028', N'Trevor Calderon', N'trevorcalderon@outlook.net', N'(993) 915-2282', 1, CAST(N'2022-11-20T16:57:48.197' AS DateTime))
GO
INSERT [dbo].[CLIENTE] ([IdCliente], [Documento], [NombreCompleto], [Correo], [Telefono], [Estado], [FechaRegistro]) VALUES (116, N'28858011', N'Justine Gaines', N'justinegaines856@outlook.org', N'(319) 199-1671', 1, CAST(N'2022-11-20T16:57:48.197' AS DateTime))
GO
INSERT [dbo].[CLIENTE] ([IdCliente], [Documento], [NombreCompleto], [Correo], [Telefono], [Estado], [FechaRegistro]) VALUES (120, N'3739310', N'Plato Mckee', N'platomckee@protonmail.ca', N'(663) 928-4393', 1, CAST(N'2022-11-20T16:57:48.197' AS DateTime))
GO
INSERT [dbo].[CLIENTE] ([IdCliente], [Documento], [NombreCompleto], [Correo], [Telefono], [Estado], [FechaRegistro]) VALUES (121, N'83022750', N'Tanek Puckett', N'tanekpuckett6691@aol.com', N'(451) 828-3365', 0, CAST(N'2022-11-20T16:57:48.197' AS DateTime))
GO
INSERT [dbo].[CLIENTE] ([IdCliente], [Documento], [NombreCompleto], [Correo], [Telefono], [Estado], [FechaRegistro]) VALUES (122, N'98988189', N'Belle Christensen', N'bellechristensen@aol.org', N'(884) 921-4262', 1, CAST(N'2022-11-20T16:57:48.197' AS DateTime))
GO
INSERT [dbo].[CLIENTE] ([IdCliente], [Documento], [NombreCompleto], [Correo], [Telefono], [Estado], [FechaRegistro]) VALUES (124, N'71998405', N'Rae Bishop', N'raebishop2485@hotmail.couk', N'(386) 948-7757', 1, CAST(N'2022-11-20T16:57:48.197' AS DateTime))
GO
INSERT [dbo].[CLIENTE] ([IdCliente], [Documento], [NombreCompleto], [Correo], [Telefono], [Estado], [FechaRegistro]) VALUES (125, N'39295584', N'Buckminster Clarke', N'buckminsterclarke@outlook.net', N'(713) 894-4764', 1, CAST(N'2022-11-20T16:57:48.197' AS DateTime))
GO
INSERT [dbo].[CLIENTE] ([IdCliente], [Documento], [NombreCompleto], [Correo], [Telefono], [Estado], [FechaRegistro]) VALUES (126, N'66906732', N'Xantha Powers', N'xanthapowers6530@yahoo.org', N'(301) 586-9284', 0, CAST(N'2022-11-20T16:57:48.197' AS DateTime))
GO
INSERT [dbo].[CLIENTE] ([IdCliente], [Documento], [NombreCompleto], [Correo], [Telefono], [Estado], [FechaRegistro]) VALUES (128, N'59854559', N'Chaney Howard', N'chaneyhoward@icloud.org', N'(494) 865-6923', 0, CAST(N'2022-11-20T16:57:48.197' AS DateTime))
GO
INSERT [dbo].[CLIENTE] ([IdCliente], [Documento], [NombreCompleto], [Correo], [Telefono], [Estado], [FechaRegistro]) VALUES (130, N'2542040', N'Rae Prince', N'raeprince@hotmail.com', N'(728) 664-8094', 1, CAST(N'2022-11-20T16:57:48.197' AS DateTime))
GO
INSERT [dbo].[CLIENTE] ([IdCliente], [Documento], [NombreCompleto], [Correo], [Telefono], [Estado], [FechaRegistro]) VALUES (131, N'27055352', N'Ronan Barry', N'ronanbarry5116@icloud.ca', N'(767) 285-1505', 0, CAST(N'2022-11-20T16:57:48.197' AS DateTime))
GO
INSERT [dbo].[CLIENTE] ([IdCliente], [Documento], [NombreCompleto], [Correo], [Telefono], [Estado], [FechaRegistro]) VALUES (132, N'27100516', N'Lionel Shaw', N'lionelshaw@yahoo.org', N'(619) 274-1405', 0, CAST(N'2022-11-20T16:57:48.197' AS DateTime))
GO
INSERT [dbo].[CLIENTE] ([IdCliente], [Documento], [NombreCompleto], [Correo], [Telefono], [Estado], [FechaRegistro]) VALUES (133, N'13666704', N'Vladimir Hernandez', N'vladimirhernandez@icloud.ca', N'(149) 576-2535', 0, CAST(N'2022-11-20T16:57:48.197' AS DateTime))
GO
INSERT [dbo].[CLIENTE] ([IdCliente], [Documento], [NombreCompleto], [Correo], [Telefono], [Estado], [FechaRegistro]) VALUES (134, N'80037364', N'Rudyard Barlow', N'rudyardbarlow331@outlook.couk', N'(523) 497-1446', 1, CAST(N'2022-11-20T16:57:48.197' AS DateTime))
GO
INSERT [dbo].[CLIENTE] ([IdCliente], [Documento], [NombreCompleto], [Correo], [Telefono], [Estado], [FechaRegistro]) VALUES (136, N'4216029', N'Risa Thomas', N'risathomas@protonmail.edu', N'(666) 572-3815', 1, CAST(N'2022-11-20T16:57:48.197' AS DateTime))
GO
INSERT [dbo].[CLIENTE] ([IdCliente], [Documento], [NombreCompleto], [Correo], [Telefono], [Estado], [FechaRegistro]) VALUES (137, N'41692719', N'Prescott Sargent', N'prescottsargent6553@outlook.edu', N'(283) 127-7273', 1, CAST(N'2022-11-20T16:57:48.197' AS DateTime))
GO
INSERT [dbo].[CLIENTE] ([IdCliente], [Documento], [NombreCompleto], [Correo], [Telefono], [Estado], [FechaRegistro]) VALUES (138, N'26758494', N'Jarrod Rivas', N'jarrodrivas2158@protonmail.edu', N'(661) 251-1459', 1, CAST(N'2022-11-20T16:57:48.197' AS DateTime))
GO
INSERT [dbo].[CLIENTE] ([IdCliente], [Documento], [NombreCompleto], [Correo], [Telefono], [Estado], [FechaRegistro]) VALUES (139, N'10092477', N'Declan Richmond', N'declanrichmond6761@icloud.net', N'(345) 628-5725', 1, CAST(N'2022-11-20T16:57:48.197' AS DateTime))
GO
INSERT [dbo].[CLIENTE] ([IdCliente], [Documento], [NombreCompleto], [Correo], [Telefono], [Estado], [FechaRegistro]) VALUES (140, N'51310133', N'Freya Ross', N'freyaross7072@google.com', N'(338) 616-1819', 1, CAST(N'2022-11-20T16:57:48.197' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[CLIENTE] OFF
GO
SET IDENTITY_INSERT [dbo].[COMPRA] ON 
GO
INSERT [dbo].[COMPRA] ([IdCompra], [IdUsuario], [IdProveedor], [TipoDocumento], [NumeroDocumento], [MontoTotal], [FechaRegistro]) VALUES (17, 16, 44, N'Boleta', N'00001', CAST(3500.00 AS Decimal(10, 2)), CAST(N'2022-11-28T12:44:20.330' AS DateTime))
GO
INSERT [dbo].[COMPRA] ([IdCompra], [IdUsuario], [IdProveedor], [TipoDocumento], [NumeroDocumento], [MontoTotal], [FechaRegistro]) VALUES (18, 16, 44, N'Boleta', N'00002', CAST(106770.00 AS Decimal(10, 2)), CAST(N'2022-11-28T12:49:54.710' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[COMPRA] OFF
GO
SET IDENTITY_INSERT [dbo].[DETALLE_COMPRA] ON 
GO
INSERT [dbo].[DETALLE_COMPRA] ([IdDetalleCompra], [IdCompra], [IdProducto], [PrecioCompra], [PrecioVenta], [Cantidad], [MontoTotal], [FechaRegistro]) VALUES (19, 17, 90, CAST(350.00 AS Decimal(10, 2)), CAST(400.00 AS Decimal(10, 2)), 10, CAST(3500.00 AS Decimal(10, 2)), CAST(N'2022-11-28T12:44:20.330' AS DateTime))
GO
INSERT [dbo].[DETALLE_COMPRA] ([IdDetalleCompra], [IdCompra], [IdProducto], [PrecioCompra], [PrecioVenta], [Cantidad], [MontoTotal], [FechaRegistro]) VALUES (20, 18, 81, CAST(560.00 AS Decimal(10, 2)), CAST(720.00 AS Decimal(10, 2)), 43, CAST(24080.00 AS Decimal(10, 2)), CAST(N'2022-11-28T12:49:54.710' AS DateTime))
GO
INSERT [dbo].[DETALLE_COMPRA] ([IdDetalleCompra], [IdCompra], [IdProducto], [PrecioCompra], [PrecioVenta], [Cantidad], [MontoTotal], [FechaRegistro]) VALUES (21, 18, 82, CAST(345.00 AS Decimal(10, 2)), CAST(400.00 AS Decimal(10, 2)), 12, CAST(4140.00 AS Decimal(10, 2)), CAST(N'2022-11-28T12:49:54.710' AS DateTime))
GO
INSERT [dbo].[DETALLE_COMPRA] ([IdDetalleCompra], [IdCompra], [IdProducto], [PrecioCompra], [PrecioVenta], [Cantidad], [MontoTotal], [FechaRegistro]) VALUES (22, 18, 84, CAST(1230.00 AS Decimal(10, 2)), CAST(1300.00 AS Decimal(10, 2)), 45, CAST(55350.00 AS Decimal(10, 2)), CAST(N'2022-11-28T12:49:54.710' AS DateTime))
GO
INSERT [dbo].[DETALLE_COMPRA] ([IdDetalleCompra], [IdCompra], [IdProducto], [PrecioCompra], [PrecioVenta], [Cantidad], [MontoTotal], [FechaRegistro]) VALUES (23, 18, 77, CAST(400.00 AS Decimal(10, 2)), CAST(430.00 AS Decimal(10, 2)), 58, CAST(23200.00 AS Decimal(10, 2)), CAST(N'2022-11-28T12:49:54.710' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[DETALLE_COMPRA] OFF
GO
SET IDENTITY_INSERT [dbo].[DETALLE_VENTA] ON 
GO
INSERT [dbo].[DETALLE_VENTA] ([IdDetalleVenta], [IdVenta], [IdProducto], [PrecioVenta], [Cantidad], [SubTotal], [FechaRegistro]) VALUES (33, 16, 90, CAST(0.00 AS Decimal(10, 2)), 2, CAST(700.00 AS Decimal(10, 2)), CAST(N'2022-11-28T12:45:14.990' AS DateTime))
GO
INSERT [dbo].[DETALLE_VENTA] ([IdDetalleVenta], [IdVenta], [IdProducto], [PrecioVenta], [Cantidad], [SubTotal], [FechaRegistro]) VALUES (34, 17, 77, CAST(0.00 AS Decimal(10, 2)), 2, CAST(800.00 AS Decimal(10, 2)), CAST(N'2022-11-28T12:51:59.600' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[DETALLE_VENTA] OFF
GO
SET IDENTITY_INSERT [dbo].[PERMISO] ON 
GO
INSERT [dbo].[PERMISO] ([IdPermiso], [IdRol], [NombreMenu], [FechaRegistro]) VALUES (1, 1, N'ventas', CAST(N'2022-11-17T20:47:19.020' AS DateTime))
GO
INSERT [dbo].[PERMISO] ([IdPermiso], [IdRol], [NombreMenu], [FechaRegistro]) VALUES (2, 1, N'compras', CAST(N'2022-11-17T20:47:19.020' AS DateTime))
GO
INSERT [dbo].[PERMISO] ([IdPermiso], [IdRol], [NombreMenu], [FechaRegistro]) VALUES (3, 1, N'categorias', CAST(N'2022-11-17T20:47:19.020' AS DateTime))
GO
INSERT [dbo].[PERMISO] ([IdPermiso], [IdRol], [NombreMenu], [FechaRegistro]) VALUES (4, 1, N'clientes', CAST(N'2022-11-17T20:47:19.020' AS DateTime))
GO
INSERT [dbo].[PERMISO] ([IdPermiso], [IdRol], [NombreMenu], [FechaRegistro]) VALUES (5, 1, N'usuarios', CAST(N'2022-11-17T20:47:19.020' AS DateTime))
GO
INSERT [dbo].[PERMISO] ([IdPermiso], [IdRol], [NombreMenu], [FechaRegistro]) VALUES (6, 1, N'proveedores', CAST(N'2022-11-17T20:47:19.020' AS DateTime))
GO
INSERT [dbo].[PERMISO] ([IdPermiso], [IdRol], [NombreMenu], [FechaRegistro]) VALUES (7, 1, N'reportes', CAST(N'2022-11-17T20:47:19.020' AS DateTime))
GO
INSERT [dbo].[PERMISO] ([IdPermiso], [IdRol], [NombreMenu], [FechaRegistro]) VALUES (8, 1, N'configuracion', CAST(N'2022-11-17T20:47:19.020' AS DateTime))
GO
INSERT [dbo].[PERMISO] ([IdPermiso], [IdRol], [NombreMenu], [FechaRegistro]) VALUES (9, 1, N'acercaDe', CAST(N'2022-11-17T20:47:19.020' AS DateTime))
GO
INSERT [dbo].[PERMISO] ([IdPermiso], [IdRol], [NombreMenu], [FechaRegistro]) VALUES (10, 2, N'ventas', CAST(N'2022-11-17T20:49:47.873' AS DateTime))
GO
INSERT [dbo].[PERMISO] ([IdPermiso], [IdRol], [NombreMenu], [FechaRegistro]) VALUES (11, 2, N'compras', CAST(N'2022-11-17T20:49:47.873' AS DateTime))
GO
INSERT [dbo].[PERMISO] ([IdPermiso], [IdRol], [NombreMenu], [FechaRegistro]) VALUES (12, 2, N'clientes', CAST(N'2022-11-17T20:49:47.873' AS DateTime))
GO
INSERT [dbo].[PERMISO] ([IdPermiso], [IdRol], [NombreMenu], [FechaRegistro]) VALUES (13, 2, N'proveedores', CAST(N'2022-11-17T20:49:47.873' AS DateTime))
GO
INSERT [dbo].[PERMISO] ([IdPermiso], [IdRol], [NombreMenu], [FechaRegistro]) VALUES (14, 2, N'configuracion', CAST(N'2022-11-17T20:49:47.873' AS DateTime))
GO
INSERT [dbo].[PERMISO] ([IdPermiso], [IdRol], [NombreMenu], [FechaRegistro]) VALUES (15, 2, N'acercaDe', CAST(N'2022-11-17T20:49:47.873' AS DateTime))
GO
INSERT [dbo].[PERMISO] ([IdPermiso], [IdRol], [NombreMenu], [FechaRegistro]) VALUES (16, 1, N'cerrarSesion', CAST(N'2022-11-20T15:57:14.837' AS DateTime))
GO
INSERT [dbo].[PERMISO] ([IdPermiso], [IdRol], [NombreMenu], [FechaRegistro]) VALUES (17, 2, N'cerrarSesion', CAST(N'2022-11-20T15:57:23.780' AS DateTime))
GO
INSERT [dbo].[PERMISO] ([IdPermiso], [IdRol], [NombreMenu], [FechaRegistro]) VALUES (18, 1, N'productos', CAST(N'2022-11-21T14:48:57.160' AS DateTime))
GO
INSERT [dbo].[PERMISO] ([IdPermiso], [IdRol], [NombreMenu], [FechaRegistro]) VALUES (19, 1, N'registros', CAST(N'2022-11-25T00:17:24.033' AS DateTime))
GO
INSERT [dbo].[PERMISO] ([IdPermiso], [IdRol], [NombreMenu], [FechaRegistro]) VALUES (20, 2, N'registros', CAST(N'2022-11-25T00:17:26.980' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[PERMISO] OFF
GO
SET IDENTITY_INSERT [dbo].[PRODUCTO] ON 
GO
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Descripcion], [IdCategoria], [Stock], [PrecioCompra], [PrecioVenta], [Estado], [FechaRegistro]) VALUES (71, N'2090775', N'G203 RGB', N'mouse inalambrico', 2, 0, CAST(0.00 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), 0, CAST(N'2022-11-28T12:38:56.157' AS DateTime))
GO
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Descripcion], [IdCategoria], [Stock], [PrecioCompra], [PrecioVenta], [Estado], [FechaRegistro]) VALUES (72, N'139823516', N'LOGITECH G915 TKL RGB', N'penatibus et magnis', 2, 0, CAST(0.00 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), 1, CAST(N'2022-11-28T12:38:56.157' AS DateTime))
GO
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Descripcion], [IdCategoria], [Stock], [PrecioCompra], [PrecioVenta], [Estado], [FechaRegistro]) VALUES (73, N'1691430', N'GIGABYTE B660M', N'Maecenas iaculis aliquet', 10, 0, CAST(0.00 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), 0, CAST(N'2022-11-28T12:38:56.157' AS DateTime))
GO
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Descripcion], [IdCategoria], [Stock], [PrecioCompra], [PrecioVenta], [Estado], [FechaRegistro]) VALUES (74, N'4076013K', N'ASUS ROG STRIX Z690-F', N'sapien, cursus in,', 9, 0, CAST(0.00 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), 1, CAST(N'2022-11-28T12:38:56.157' AS DateTime))
GO
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Descripcion], [IdCategoria], [Stock], [PrecioCompra], [PrecioVenta], [Estado], [FechaRegistro]) VALUES (75, N'271502362', N'Z690 AERO G', N'nec, malesuada ut,', 3, 0, CAST(0.00 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), 1, CAST(N'2022-11-28T12:38:56.157' AS DateTime))
GO
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Descripcion], [IdCategoria], [Stock], [PrecioCompra], [PrecioVenta], [Estado], [FechaRegistro]) VALUES (76, N'102177428', N'RAZER BLACKWIDOW V3', N'a neque. Nullam', 2, 0, CAST(0.00 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), 0, CAST(N'2022-11-28T12:38:56.157' AS DateTime))
GO
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Descripcion], [IdCategoria], [Stock], [PrecioCompra], [PrecioVenta], [Estado], [FechaRegistro]) VALUES (77, N'21969362', N'CORSAIR CRYSTAL 280X', N'euismod mauris eu', 10, 56, CAST(400.00 AS Decimal(10, 2)), CAST(430.00 AS Decimal(10, 2)), 1, CAST(N'2022-11-28T12:38:56.157' AS DateTime))
GO
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Descripcion], [IdCategoria], [Stock], [PrecioCompra], [PrecioVenta], [Estado], [FechaRegistro]) VALUES (78, N'221508831', N'SAMSUNG ODYSSEY G5 34"', N'natoque penatibus et', 9, 0, CAST(0.00 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), 0, CAST(N'2022-11-28T12:38:56.157' AS DateTime))
GO
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Descripcion], [IdCategoria], [Stock], [PrecioCompra], [PrecioVenta], [Estado], [FechaRegistro]) VALUES (79, N'153691835', N'CORSAIR K83', N'euismod in, dolor.', 6, 0, CAST(0.00 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), 1, CAST(N'2022-11-28T12:38:56.157' AS DateTime))
GO
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Descripcion], [IdCategoria], [Stock], [PrecioCompra], [PrecioVenta], [Estado], [FechaRegistro]) VALUES (80, N'67458249', N'ASUS 27" ROG STRIX', N'convallis, ante lectus', 9, 0, CAST(0.00 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), 1, CAST(N'2022-11-28T12:38:56.157' AS DateTime))
GO
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Descripcion], [IdCategoria], [Stock], [PrecioCompra], [PrecioVenta], [Estado], [FechaRegistro]) VALUES (81, N'292661223', N'32 GB DDR5 4800 MHZ 32X1 CORSAIR', N'lorem, vehicula et,', 5, 43, CAST(560.00 AS Decimal(10, 2)), CAST(720.00 AS Decimal(10, 2)), 1, CAST(N'2022-11-28T12:38:56.157' AS DateTime))
GO
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Descripcion], [IdCategoria], [Stock], [PrecioCompra], [PrecioVenta], [Estado], [FechaRegistro]) VALUES (82, N'38315420', N'1TB SSD M.2 KINGSTON RENEGADE', N'elit, pretium et,', 3, 12, CAST(345.00 AS Decimal(10, 2)), CAST(400.00 AS Decimal(10, 2)), 1, CAST(N'2022-11-28T12:38:56.157' AS DateTime))
GO
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Descripcion], [IdCategoria], [Stock], [PrecioCompra], [PrecioVenta], [Estado], [FechaRegistro]) VALUES (83, N'46862284K', N'INTEL CORE I5 11400F 2.6 4.4 GHZ', N'suscipit, est ac', 10, 0, CAST(0.00 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), 1, CAST(N'2022-11-28T12:38:56.157' AS DateTime))
GO
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Descripcion], [IdCategoria], [Stock], [PrecioCompra], [PrecioVenta], [Estado], [FechaRegistro]) VALUES (84, N'417003681', N'AMD RYZEN 5 4600G', N'Maecenas ornare egestas', 9, 45, CAST(1230.00 AS Decimal(10, 2)), CAST(1300.00 AS Decimal(10, 2)), 1, CAST(N'2022-11-28T12:38:56.157' AS DateTime))
GO
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Descripcion], [IdCategoria], [Stock], [PrecioCompra], [PrecioVenta], [Estado], [FechaRegistro]) VALUES (85, N'7422687', N'500 GB SSD KINGSTON RENEGADE', N'Sed eu eros.', 10, 0, CAST(0.00 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), 0, CAST(N'2022-11-28T12:38:56.157' AS DateTime))
GO
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Descripcion], [IdCategoria], [Stock], [PrecioCompra], [PrecioVenta], [Estado], [FechaRegistro]) VALUES (86, N'231193928', N'ASROCK X670E PRO', N'ante lectus convallis', 8, 0, CAST(0.00 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), 1, CAST(N'2022-11-28T12:38:56.157' AS DateTime))
GO
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Descripcion], [IdCategoria], [Stock], [PrecioCompra], [PrecioVenta], [Estado], [FechaRegistro]) VALUES (87, N'225197717', N'CORSAIR 450W 80+ BRONCE', N'ornare placerat, orci', 10, 0, CAST(0.00 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), 0, CAST(N'2022-11-28T12:38:56.157' AS DateTime))
GO
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Descripcion], [IdCategoria], [Stock], [PrecioCompra], [PrecioVenta], [Estado], [FechaRegistro]) VALUES (88, N'61082271', N'XPG 750W GOLD CORE', N'arcu. Sed eu', 9, 0, CAST(0.00 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), 0, CAST(N'2022-11-28T12:38:56.157' AS DateTime))
GO
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Descripcion], [IdCategoria], [Stock], [PrecioCompra], [PrecioVenta], [Estado], [FechaRegistro]) VALUES (89, N'66248585', N'TRUST GXT 863 MECANICO', N'tempor augue ac', 3, 0, CAST(0.00 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), 1, CAST(N'2022-11-28T12:38:56.157' AS DateTime))
GO
INSERT [dbo].[PRODUCTO] ([IdProducto], [Codigo], [Nombre], [Descripcion], [IdCategoria], [Stock], [PrecioCompra], [PrecioVenta], [Estado], [FechaRegistro]) VALUES (90, N'24125246', N'RAZER HAMMERHEAD X', N'consectetuer adipiscing elit.', 2, 8, CAST(350.00 AS Decimal(10, 2)), CAST(400.00 AS Decimal(10, 2)), 1, CAST(N'2022-11-28T12:38:56.157' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[PRODUCTO] OFF
GO
SET IDENTITY_INSERT [dbo].[PROVEEDOR] ON 
GO
INSERT [dbo].[PROVEEDOR] ([IdProveedor], [Documento], [RazonSocial], [Telefono], [Estado], [FechaRegistro]) VALUES (41, N'2431', N'Asus', N'7912824855', 0, CAST(N'2022-11-28T12:02:43.090' AS DateTime))
GO
INSERT [dbo].[PROVEEDOR] ([IdProveedor], [Documento], [RazonSocial], [Telefono], [Estado], [FechaRegistro]) VALUES (42, N'5901', N'NVIDIA', N'5793328687', 1, CAST(N'2022-11-28T12:02:43.090' AS DateTime))
GO
INSERT [dbo].[PROVEEDOR] ([IdProveedor], [Documento], [RazonSocial], [Telefono], [Estado], [FechaRegistro]) VALUES (43, N'1788', N'Logitech', N'4988622112', 0, CAST(N'2022-11-28T12:02:43.090' AS DateTime))
GO
INSERT [dbo].[PROVEEDOR] ([IdProveedor], [Documento], [RazonSocial], [Telefono], [Estado], [FechaRegistro]) VALUES (44, N'6084', N'Razer', N'6056762716', 1, CAST(N'2022-11-28T12:02:43.090' AS DateTime))
GO
INSERT [dbo].[PROVEEDOR] ([IdProveedor], [Documento], [RazonSocial], [Telefono], [Estado], [FechaRegistro]) VALUES (45, N'8702', N'HiperX', N'7706669339', 0, CAST(N'2022-11-28T12:02:43.090' AS DateTime))
GO
INSERT [dbo].[PROVEEDOR] ([IdProveedor], [Documento], [RazonSocial], [Telefono], [Estado], [FechaRegistro]) VALUES (46, N'9908', N'Corsair', N'8487627818', 0, CAST(N'2022-11-28T12:02:43.090' AS DateTime))
GO
INSERT [dbo].[PROVEEDOR] ([IdProveedor], [Documento], [RazonSocial], [Telefono], [Estado], [FechaRegistro]) VALUES (47, N'2268', N'SteelSeries', N'5524420212', 1, CAST(N'2022-11-28T12:02:43.090' AS DateTime))
GO
INSERT [dbo].[PROVEEDOR] ([IdProveedor], [Documento], [RazonSocial], [Telefono], [Estado], [FechaRegistro]) VALUES (48, N'7811', N'AMD', N'8875487476', 1, CAST(N'2022-11-28T12:02:43.090' AS DateTime))
GO
INSERT [dbo].[PROVEEDOR] ([IdProveedor], [Documento], [RazonSocial], [Telefono], [Estado], [FechaRegistro]) VALUES (49, N'3324', N'Cooler Master', N'5484426273', 1, CAST(N'2022-11-28T12:02:43.090' AS DateTime))
GO
INSERT [dbo].[PROVEEDOR] ([IdProveedor], [Documento], [RazonSocial], [Telefono], [Estado], [FechaRegistro]) VALUES (50, N'3644', N'Intel', N'6626125593', 0, CAST(N'2022-11-28T12:02:43.090' AS DateTime))
GO
INSERT [dbo].[PROVEEDOR] ([IdProveedor], [Documento], [RazonSocial], [Telefono], [Estado], [FechaRegistro]) VALUES (51, N'9220', N'LG', N'5525333657', 1, CAST(N'2022-11-28T12:02:43.090' AS DateTime))
GO
INSERT [dbo].[PROVEEDOR] ([IdProveedor], [Documento], [RazonSocial], [Telefono], [Estado], [FechaRegistro]) VALUES (52, N'1637', N'ASRock', N'5912472221', 1, CAST(N'2022-11-28T12:02:43.090' AS DateTime))
GO
INSERT [dbo].[PROVEEDOR] ([IdProveedor], [Documento], [RazonSocial], [Telefono], [Estado], [FechaRegistro]) VALUES (53, N'4790', N'Gigabyte', N'2177170172', 1, CAST(N'2022-11-28T12:02:43.090' AS DateTime))
GO
INSERT [dbo].[PROVEEDOR] ([IdProveedor], [Documento], [RazonSocial], [Telefono], [Estado], [FechaRegistro]) VALUES (54, N'6354', N'MSI', N'3009888563', 1, CAST(N'2022-11-28T12:02:43.090' AS DateTime))
GO
INSERT [dbo].[PROVEEDOR] ([IdProveedor], [Documento], [RazonSocial], [Telefono], [Estado], [FechaRegistro]) VALUES (55, N'2198', N'ROG', N'7078432675', 0, CAST(N'2022-11-28T12:02:43.090' AS DateTime))
GO
INSERT [dbo].[PROVEEDOR] ([IdProveedor], [Documento], [RazonSocial], [Telefono], [Estado], [FechaRegistro]) VALUES (56, N'2792', N'Lenovo', N'6973613766', 1, CAST(N'2022-11-28T12:02:43.090' AS DateTime))
GO
INSERT [dbo].[PROVEEDOR] ([IdProveedor], [Documento], [RazonSocial], [Telefono], [Estado], [FechaRegistro]) VALUES (57, N'9563', N'Noctua', N'6442154657', 0, CAST(N'2022-11-28T12:02:43.090' AS DateTime))
GO
INSERT [dbo].[PROVEEDOR] ([IdProveedor], [Documento], [RazonSocial], [Telefono], [Estado], [FechaRegistro]) VALUES (58, N'3978', N'G-Skill', N'7386894837', 1, CAST(N'2022-11-28T12:02:43.090' AS DateTime))
GO
INSERT [dbo].[PROVEEDOR] ([IdProveedor], [Documento], [RazonSocial], [Telefono], [Estado], [FechaRegistro]) VALUES (59, N'9124', N'Hyper-x', N'6774558293', 1, CAST(N'2022-11-28T12:02:43.090' AS DateTime))
GO
INSERT [dbo].[PROVEEDOR] ([IdProveedor], [Documento], [RazonSocial], [Telefono], [Estado], [FechaRegistro]) VALUES (60, N'7997', N'Thermatake', N'6837699761', 1, CAST(N'2022-11-28T12:02:43.090' AS DateTime))
GO
INSERT [dbo].[PROVEEDOR] ([IdProveedor], [Documento], [RazonSocial], [Telefono], [Estado], [FechaRegistro]) VALUES (61, N'7994', N'Sony', N'1437699761', 1, CAST(N'2022-11-28T12:02:43.090' AS DateTime))
GO
INSERT [dbo].[PROVEEDOR] ([IdProveedor], [Documento], [RazonSocial], [Telefono], [Estado], [FechaRegistro]) VALUES (62, N'4396', N'Presonus', N'4437699462', 1, CAST(N'2022-11-28T12:02:43.090' AS DateTime))
GO
INSERT [dbo].[PROVEEDOR] ([IdProveedor], [Documento], [RazonSocial], [Telefono], [Estado], [FechaRegistro]) VALUES (63, N'4396', N'JBL', N'633769-3468', 1, CAST(N'2022-11-28T12:02:43.090' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[PROVEEDOR] OFF
GO
SET IDENTITY_INSERT [dbo].[ROL] ON 
GO
INSERT [dbo].[ROL] ([IdRol], [Descripcion], [FechaRegistro]) VALUES (1, N'Administrador', CAST(N'2022-11-17T13:43:59.430' AS DateTime))
GO
INSERT [dbo].[ROL] ([IdRol], [Descripcion], [FechaRegistro]) VALUES (2, N'Empleado', CAST(N'2022-11-17T20:48:21.780' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[ROL] OFF
GO
SET IDENTITY_INSERT [dbo].[USUARIO] ON 
GO
INSERT [dbo].[USUARIO] ([IdUsuario], [Documento], [NombreCompleto], [Correo], [Clave], [IdRol], [Estado], [FechaRegistro]) VALUES (16, N'1111', N'Administrador', N'admin@gmail.com', N'admin', 1, 1, CAST(N'2022-11-19T16:10:03.627' AS DateTime))
GO
INSERT [dbo].[USUARIO] ([IdUsuario], [Documento], [NombreCompleto], [Correo], [Clave], [IdRol], [Estado], [FechaRegistro]) VALUES (17, N'2222', N'Empleado', N'empleado@gmail.com', N'empleado', 2, 1, CAST(N'2022-11-19T16:10:36.527' AS DateTime))
GO
INSERT [dbo].[USUARIO] ([IdUsuario], [Documento], [NombreCompleto], [Correo], [Clave], [IdRol], [Estado], [FechaRegistro]) VALUES (18, N'3030', N'prueba', N'prueba@gmail.com', N'3030', 2, 0, CAST(N'2022-11-24T03:38:05.180' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[USUARIO] OFF
GO
SET IDENTITY_INSERT [dbo].[VENTA] ON 
GO
INSERT [dbo].[VENTA] ([IdVenta], [IdUsuario], [TipoDocumento], [NumeroDocumento], [NombreCliente], [DocumentoCliente], [MontoPago], [MontoCambio], [MontoTotal], [FechaRegistro]) VALUES (16, 16, N'Boleta', N'00001', N'Plato Mckee', N'3739310', CAST(0.00 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(700.00 AS Decimal(10, 2)), CAST(N'2022-11-28T12:45:14.990' AS DateTime))
GO
INSERT [dbo].[VENTA] ([IdVenta], [IdUsuario], [TipoDocumento], [NumeroDocumento], [NombreCliente], [DocumentoCliente], [MontoPago], [MontoCambio], [MontoTotal], [FechaRegistro]) VALUES (17, 16, N'Boleta', N'00002', N'Plato Mckee', N'3739310', CAST(0.00 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(800.00 AS Decimal(10, 2)), CAST(N'2022-11-28T12:51:59.600' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[VENTA] OFF
GO
ALTER TABLE [dbo].[CATEGORIA] ADD  DEFAULT (getdate()) FOR [FechaRegistro]
GO
ALTER TABLE [dbo].[CLIENTE] ADD  DEFAULT (getdate()) FOR [FechaRegistro]
GO
ALTER TABLE [dbo].[COMPRA] ADD  DEFAULT (getdate()) FOR [FechaRegistro]
GO
ALTER TABLE [dbo].[DETALLE_COMPRA] ADD  CONSTRAINT [DF__DETALLE_C__Preci__44FF419A]  DEFAULT ((0)) FOR [PrecioCompra]
GO
ALTER TABLE [dbo].[DETALLE_COMPRA] ADD  CONSTRAINT [DF__DETALLE_C__Fecha__45F365D3]  DEFAULT (getdate()) FOR [FechaRegistro]
GO
ALTER TABLE [dbo].[DETALLE_VENTA] ADD  DEFAULT ((0)) FOR [PrecioVenta]
GO
ALTER TABLE [dbo].[DETALLE_VENTA] ADD  DEFAULT (getdate()) FOR [FechaRegistro]
GO
ALTER TABLE [dbo].[PERMISO] ADD  DEFAULT (getdate()) FOR [FechaRegistro]
GO
ALTER TABLE [dbo].[PRODUCTO] ADD  DEFAULT ((0)) FOR [Stock]
GO
ALTER TABLE [dbo].[PRODUCTO] ADD  DEFAULT ((0)) FOR [PrecioCompra]
GO
ALTER TABLE [dbo].[PRODUCTO] ADD  DEFAULT ((0)) FOR [PrecioVenta]
GO
ALTER TABLE [dbo].[PRODUCTO] ADD  DEFAULT (getdate()) FOR [FechaRegistro]
GO
ALTER TABLE [dbo].[PROVEEDOR] ADD  DEFAULT (getdate()) FOR [FechaRegistro]
GO
ALTER TABLE [dbo].[ROL] ADD  DEFAULT (getdate()) FOR [FechaRegistro]
GO
ALTER TABLE [dbo].[USUARIO] ADD  DEFAULT (getdate()) FOR [FechaRegistro]
GO
ALTER TABLE [dbo].[VENTA] ADD  DEFAULT (getdate()) FOR [FechaRegistro]
GO
ALTER TABLE [dbo].[COMPRA]  WITH CHECK ADD FOREIGN KEY([IdProveedor])
REFERENCES [dbo].[PROVEEDOR] ([IdProveedor])
GO
ALTER TABLE [dbo].[COMPRA]  WITH CHECK ADD FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[USUARIO] ([IdUsuario])
GO
ALTER TABLE [dbo].[DETALLE_COMPRA]  WITH CHECK ADD  CONSTRAINT [FK__DETALLE_C__IdCom__4316F928] FOREIGN KEY([IdCompra])
REFERENCES [dbo].[COMPRA] ([IdCompra])
GO
ALTER TABLE [dbo].[DETALLE_COMPRA] CHECK CONSTRAINT [FK__DETALLE_C__IdCom__4316F928]
GO
ALTER TABLE [dbo].[DETALLE_COMPRA]  WITH CHECK ADD  CONSTRAINT [FK__DETALLE_C__IdPro__440B1D61] FOREIGN KEY([IdProducto])
REFERENCES [dbo].[PRODUCTO] ([IdProducto])
GO
ALTER TABLE [dbo].[DETALLE_COMPRA] CHECK CONSTRAINT [FK__DETALLE_C__IdPro__440B1D61]
GO
ALTER TABLE [dbo].[DETALLE_VENTA]  WITH CHECK ADD FOREIGN KEY([IdProducto])
REFERENCES [dbo].[PRODUCTO] ([IdProducto])
GO
ALTER TABLE [dbo].[DETALLE_VENTA]  WITH CHECK ADD FOREIGN KEY([IdVenta])
REFERENCES [dbo].[VENTA] ([IdVenta])
GO
ALTER TABLE [dbo].[PERMISO]  WITH CHECK ADD FOREIGN KEY([IdRol])
REFERENCES [dbo].[ROL] ([IdRol])
GO
ALTER TABLE [dbo].[PRODUCTO]  WITH CHECK ADD FOREIGN KEY([IdCategoria])
REFERENCES [dbo].[CATEGORIA] ([IdCategoria])
GO
ALTER TABLE [dbo].[USUARIO]  WITH CHECK ADD FOREIGN KEY([IdRol])
REFERENCES [dbo].[ROL] ([IdRol])
GO
ALTER TABLE [dbo].[VENTA]  WITH CHECK ADD FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[USUARIO] ([IdUsuario])
GO
/****** Object:  StoredProcedure [dbo].[EditarCategoria]    Script Date: 28/11/2022 13:11:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[EditarCategoria]
@IdCategoria int,
@Descripcion varchar(50),
@Estado bit,
@Resultado int output,
@Mensaje varchar(500) output
as
begin
	set @Resultado = 1
	if not exists(select * from CATEGORIA where Descripcion = @Descripcion and IdCategoria != @IdCategoria)
	update CATEGORIA set
	Descripcion = @Descripcion,
	Estado = @Estado
	where IdCategoria = @IdCategoria
	else
		BEGIN
			set @Resultado = 0
			set @Mensaje = 'Ya existe esta categoria en los registros.'
		END
	END
GO
/****** Object:  StoredProcedure [dbo].[EditarCliente]    Script Date: 28/11/2022 13:11:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[EditarCliente](
	@Idcliente int,
	@Documento varchar(50),
	@NombreCompleto varchar(50),
	@correo varchar(50),
	@Telefono varchar(50),
	@Estado bit,
	@Resultado bit output,
	@Mensaje varchar(500) output
	)
as
begin
	SET @Resultado = 1
	DECLARE @IDPERSONA INT
	IF NOT EXISTS (SELECT * FROM CLIENTE WHERE Documento = @Documento and IdCliente != @IdCliente)
	begin
		update CLIENTE set
		Documento = @Documento,
		NombreCompleto = @NombreCompleto,
		Correo = @Correo,
		Telefono = @Telefono,
		Estado = @Estado
		where IdCliente = @IdCliente
	end
else
	begin
		SET @Resultado = 0
		set @Mensaje = 'El documento ya se encuentra registrado.'
	end
end
GO
/****** Object:  StoredProcedure [dbo].[EditarProducto]    Script Date: 28/11/2022 13:11:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[EditarProducto](
@IdProducto int,
@Codigo varchar(20),
@Nombre varchar(30),
@Descripcion varchar(30),
@IdCategoria int,
@estado bit,
@Resultado bit output,
@Mensaje varchar(500) output
)as
begin
	SET @Resultado = 1
	IF NOT EXISTS (SELECT * FROM PRODUCTO WHERE codigo = @Codigo and IdProducto != @IdProducto)
		update PRODUCTO set
		codigo = @Codigo,
		Nombre = @Nombre,
		Descripcion = @Descripcion,
		IdCategoria = @IdCategoria,
		Estado = @estado
		where IdProducto = @IdProducto
		ELSE
			begin
				SET @Resultado = 0
				SET @Mensaje = 'Ya existe un producto con este codigo.'
			end
end
GO
/****** Object:  StoredProcedure [dbo].[EditarProveedor]    Script Date: 28/11/2022 13:11:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[EditarProveedor](
	@IdProveedor int,
	@Documento varchar(50),
	@RazonSocial varchar(50),
	@Telefono varchar(50),
	@Estado bit,
	@Resultado int output,
	@Mensaje varchar(500) output
	)
as
begin
	SET @Resultado = 1
	DECLARE @IDPERSONA INT
	IF NOT EXISTS (SELECT * FROM PROVEEDOR WHERE Documento = @Documento and IdProveedor != @IdProveedor)
	begin
		update PROVEEDOR set
		Documento = @Documento,
		RazonSocial = @RazonSocial,
		Telefono = @Telefono,
		Estado = @Estado
		where IdProveedor = @IdProveedor
	end
	else
	begin
		set @Resultado = 0
		set @Mensaje = 'El documento ya se encuentra registrado.'
	end
end
GO
/****** Object:  StoredProcedure [dbo].[EditarUsuario]    Script Date: 28/11/2022 13:11:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[EditarUsuario](
@IdUsuario int,
@Documento varchar(50),
@NombreCompleto varchar(100),
@Correo varchar(100),
@Clave varchar(100),
@IdRol int,
@Estado bit,
@Respuesta bit output,
@Mensaje varchar(500) output)
as
begin
set @Respuesta = 0
set @Mensaje = ''
if not exists(select * from USUARIO where Documento = @Documento and IdUsuario != @IdUsuario)
begin
update USUARIO set
Documento = @Documento,
NombreCompleto = @NombreCompleto,
Correo = @Correo,
Clave = @Clave,
IdRol= @IdRol,
Estado = @Estado
where IdUsuario = @IdUsuario
set @Respuesta = 1
end
else
set @Mensaje = 'El documento ingresado ya se encuentra registrado.'
end
GO
/****** Object:  StoredProcedure [dbo].[EliminarCategoria]    Script Date: 28/11/2022 13:11:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[EliminarCategoria]
@IdCategoria int,
@Resultado int output,
@Mensaje varchar(500) output
as
begin
	set @Resultado = 1
	if not exists(
	select * from CATEGORIA c
	inner join PRODUCTO p on p.IdCategoria = c.IdCategoria
	where c.IdCategoria != @IdCategoria)
	begin
		delete top(1) from CATEGORIA where IdCategoria = @IdCategoria
		end
	else
		BEGIN
			set @Resultado = 0
			set @Mensaje = 'Esta categoría se encuentra relacionada con un producto.'
		end
	END
GO
/****** Object:  StoredProcedure [dbo].[EliminarProducto]    Script Date: 28/11/2022 13:11:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[EliminarProducto](
@IdProducto int,
@Respuesta bit output,
@Mensaje varchar(500) output
)as
begin
	set @Respuesta = 0
	set @Mensaje = ''
	declare @PasoReglas bit = 1
	if exists(select * from DETALLE_COMPRA dc
	inner join PRODUCTO p on p.IdProducto = dc.IdProducto
	where p.IdProducto = @IdProducto
	)
	begin
		set @PasoReglas = 0
		set @Respuesta = 0
		set @Mensaje = @Mensaje + 'No se puede eliminar este producto porque se encuentra relacionado a una COMPRA.\n'
	end

	if exists(select * from DETALLE_VENTA dv
	inner join PRODUCTO p on p.IdProducto = dv.IdProducto
	where p.IdProducto = @IdProducto
	)
	begin
		set @PasoReglas = 0
		set @Respuesta = 0
		set @Mensaje = @Mensaje + 'No se puede eliminar este producto porque se encuentra relacionado a una VENTA.\n'
	end

	if(@PasoReglas = 1)
	begin
		delete from PRODUCTO where @IdProducto = @IdProducto
		set @Respuesta = 1
	end
end
GO
/****** Object:  StoredProcedure [dbo].[EliminarProveedor]    Script Date: 28/11/2022 13:11:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[EliminarProveedor](
	@IdProveedor int,
	@Resultado bit output,
	@Mensaje varchar(500) output
	)
as
begin
	SET @Resultado = 1
	IF NOT EXISTS (
	select * from PROVEEDOR p
	inner join COMPRA c on p.IdProveedor = c.IdProveedor
	where p.IdProveedor = @IdProveedor
	)
begin
delete top(1) from PROVEEDOR where IdProveedor = @IdProveedor
end
ELSE
	begin
		SET @Resultado = 0
		set @Mensaje = 'El proveedor se encuentara relacionado a una compra.'
	end
end
GO
/****** Object:  StoredProcedure [dbo].[EliminarUsuario]    Script Date: 28/11/2022 13:11:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[EliminarUsuario](
@IdUsuario int,
@Respuesta bit output,
@Mensaje varchar(500) output)
as
begin
set @Respuesta = 0
set @Mensaje = ''
declare @PasoReglas bit = 1

IF EXISTS (SELECT * FROM COMPRA C
INNER JOIN USUARIO U ON U.IdUsuario = C.IdUsuario
WHERE U.IDUSUARIO = @IdUsuario)

BEGIN
	set @PasoReglas = 0
	set @Respuesta = 0
	set @Mensaje = @Mensaje + 'No se puede eliminar porque el usuario se encuentra relacionado a una COMPRA.\n'
END

IF EXISTS (SELECT * FROM VENTA V
INNER JOIN USUARIO U ON U.IdUsuario = V.IdUsuario
WHERE U.IDUSUARIO = @IdUsuario
)
BEGIN
	set @PasoReglas = 0
	set @Respuesta = 0
	set @Mensaje = @Mensaje + 'No se puede eliminar porque el usuario se encuentra relacionado a una VENTA.\n'
END

if(@PasoReglas = 1)
	begin
		delete from USUARIO where IdUsuario = @IdUsuario
		set @Respuesta = 1
	end
end
GO
/****** Object:  StoredProcedure [dbo].[InsertarCategoria]    Script Date: 28/11/2022 13:11:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[InsertarCategoria]
@Descripcion varchar(50),
@Resultado int output,
@Estado bit,
@Mensaje varchar(500) output
as
begin
	set @Resultado = 0
	if not exists(select * from CATEGORIA where Descripcion = @Descripcion)
		BEGIN
			insert into CATEGORIA(Descripcion,Estado) values (@Descripcion, @Estado)
			set @Resultado = SCOPE_IDENTITY()
		END
		ELSE
			set @Mensaje = 'Ya existe esta categoria en los registros.'
	END
GO
/****** Object:  StoredProcedure [dbo].[InsertarCliente]    Script Date: 28/11/2022 13:11:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[InsertarCliente](
	@Documento varchar (50),
	@NombreCompleto varchar(50),
	@Correo varchar(50),
	@Telefono varchar(50),
	@Estado bit,
	@Resultado int output,
	@Mensaje varchar(500) output
	)
as
begin
	SET @Resultado = 0
	DECLARE @IDPERSONA INT
	IF NOT EXISTS (SELECT * FROM CLIENTE WHERE Documento = @Documento)
	begin
		insert into CLIENTE(Documento,NombreCompleto, Correo, Telefono, Estado) values (
		@Documento, @NombreCompleto, @Correo,@Telefono,@Estado)
		set @Resultado = SCOPE_IDENTITY()
	end
	else
		set @Mensaje = 'Este documento ya se encuentra registrado.'
end
GO
/****** Object:  StoredProcedure [dbo].[InsertarCompra]    Script Date: 28/11/2022 13:11:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[InsertarCompra](
@IdUsuario int,
@IdProveedor int,
@TipoDocumento varchar(500),
@NumeroDocumento varchar (500),
@MontoTotal decimal(18,2),
@DetalleCompra [EDetalle_Compra] READONLY,
@Resultado bit output,
@Mensaje varchar(500) output
)
as
begin
	begin try
		declare @IdCompra int = 0
		set @Resultado = 1
		set @Mensaje = ''

		begin transaction registro
		
		insert into COMPRA(IdUsuario, IdProveedor, TipoDocumento, NumeroDocumento, MontoTotal)
		values (@IdUsuario, @IdProveedor, @TipoDocumento, @NumeroDocumento, @MontoTotal)
			
		set @IdCompra = SCOPE_IDENTITY()	
			
		insert into DETALLE_COMPRA(IdCompra, IdProducto, PrecioCompra, PrecioVenta, Cantidad, MontoTotal)
		select @idcompra,IdProducto,PrecioCompra,PrecioVenta,Cantidad,MontoTotal from @DetalleCompra

		update p set p.Stock = p.Stock + dc.Cantidad,
		p.PrecioCompra = dc.PrecioCompra,
		p.PrecioVenta = dc.PrecioVenta
		from PRODUCTO p
		inner join @DetalleCompra dc on dc.IdProducto = p.IdProducto

		commit transaction registro
	end try

	begin catch
		set @Resultado = 0
		set @Mensaje = ERROR_MESSAGE()
		rollback transaction registro
	end catch
end
GO
/****** Object:  StoredProcedure [dbo].[InsertarProducto]    Script Date: 28/11/2022 13:11:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[InsertarProducto] (
	@Codigo varchar(20),
	@Nombre varchar(30),
	@Descripcion varchar (30),
	@IdCategoria int,
	@Estado bit,
	@Resultado bit output,
	@Mensaje varchar(500) output
	)
as

begin
	set @Resultado = 0
	IF NOT EXISTS (SELECT * FROM PRODUCTO WHERE Codigo = @Codigo)
	begin
		insert into PRODUCTO(Codigo,Nombre,Descripcion,IdCategoria,Estado) values (@Codigo, @Nombre, @Descripcion, @IdCategoria, @Estado)
		set @Resultado = SCOPE_IDENTITY()
	end
	ELSE
		SET @Mensaje = 'Ya existe un producto con este codigo.'
end

GO
/****** Object:  StoredProcedure [dbo].[InsertarProveedor]    Script Date: 28/11/2022 13:11:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[InsertarProveedor] (
	@Documento varchar(50),
	@RazonSocial varchar(50),
	@Telefono varchar(50),
	@Estado bit,
	@Resultado int output,
	@Mensaje varchar(500) output
	)
as
begin
	set @Resultado = 0
	declare @IOPERSONA int
	if NOT EXISTS (SELECT * FROM PROVEEDOR WHERE Documento = @Documento)
	begin
		insert into PROVEEDOR (Documento,RazonSocial,Telefono, Estado) values (
		@Documento, @RazonSocial, @Telefono, @Estado)
		set @Resultado = SCOPE_IDENTITY()
	end
	else
		set @Mensaje = 'Este numero de documento ya se encuentra registrado.'
end
GO
/****** Object:  StoredProcedure [dbo].[InsertarUsuario]    Script Date: 28/11/2022 13:11:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[InsertarUsuario](
@Documento varchar(50),
@NombreCompleto varchar(100),
@Correo varchar(100),
@Clave varchar(100),
@IdRol int,
@Estado bit,
@IdUsuarioResultado int output,
@Mensaje varchar(500) output)
as
begin
set @IdUsuarioResultado = 0
set @Mensaje = ''
if not exists(select * from USUARIO where Documento = @Documento)
begin
insert into USUARIO(Documento,NombreCompleto,Correo,Clave,IdRol,Estado)
values (@Documento,@NombreCompleto,@Correo,@Clave,@IdRol,@Estado)

set @IdUsuarioResultado = SCOPE_IDENTITY()
end
else
set @Mensaje = 'El documento ingresado ya se encuentra registrado.'
end
GO
/****** Object:  StoredProcedure [dbo].[InsertarVenta]    Script Date: 28/11/2022 13:11:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[InsertarVenta](
@IdUsuario int,
@TipoDocumento varchar (50),
@NumeroDocumento varchar(500),
@DocumentoCliente varchar(500),
@NombreCliente varchar (500),
@MontoPago decimal(18,2),
@MontoCambio decimal (18,2),
@MontoTotal decimal (18,2),
@Detalleventa [EDetalle_venta] READONLY,
@Resultado bit output,
@Mensaje varchar(500) output
)as

begin
	begin try
		declare @IdVenta int = 0
		set @Resultado = 1
		set @Mensaje = ''
	begin transaction registro
		insert into VENTA(IdUsuario, TipoDocumento ,NumeroDocumento , DocumentoCliente , NombreCliente ,MontoPago,MontoCambio,MontoTotal)
		values (@IdUsuario, @TipoDocumento, @NumeroDocumento, @DocumentoCliente, @NombreCliente,@MontoPago, @MontoCambio, @MontoTotal)

		set @idventa = SCOPE_IDENTITY()

		insert into DETALLE_VENTA(IdVenta, IdProducto, PrecioVenta, Cantidad, SubTotal)
		select @IdVenta, IdProducto, PrecioVenta, Cantidad, SubTotal from @DetalleVenta

	commit transaction registro
	end try
	begin catch
		set @Resultado = 0
		set @Mensaje = ERROR_MESSAGE()
		rollback transaction registro
	end catch
end
GO
USE [master]
GO
ALTER DATABASE [DB_PUNTOVENTA] SET  READ_WRITE 
GO
