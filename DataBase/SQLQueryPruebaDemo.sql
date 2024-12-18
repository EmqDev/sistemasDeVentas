USE [master]
GO
/****** Object:  Database [pruebademo]    Script Date: 18/12/2024 11:33:41 ******/
CREATE DATABASE [pruebademo]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'pruebademo', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\pruebademo.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'pruebademo_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\pruebademo_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [pruebademo] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [pruebademo].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [pruebademo] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [pruebademo] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [pruebademo] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [pruebademo] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [pruebademo] SET ARITHABORT OFF 
GO
ALTER DATABASE [pruebademo] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [pruebademo] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [pruebademo] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [pruebademo] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [pruebademo] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [pruebademo] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [pruebademo] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [pruebademo] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [pruebademo] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [pruebademo] SET  DISABLE_BROKER 
GO
ALTER DATABASE [pruebademo] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [pruebademo] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [pruebademo] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [pruebademo] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [pruebademo] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [pruebademo] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [pruebademo] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [pruebademo] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [pruebademo] SET  MULTI_USER 
GO
ALTER DATABASE [pruebademo] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [pruebademo] SET DB_CHAINING OFF 
GO
ALTER DATABASE [pruebademo] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [pruebademo] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [pruebademo] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [pruebademo] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [pruebademo] SET QUERY_STORE = OFF
GO
USE [pruebademo]
GO
/****** Object:  Table [dbo].[clientes]    Script Date: 18/12/2024 11:33:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[clientes](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Cliente] [varchar](255) NOT NULL,
	[Telefono] [varchar](255) NULL,
	[Correo] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[productos]    Script Date: 18/12/2024 11:33:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[productos](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](255) NOT NULL,
	[Precio] [float] NULL,
	[Categoria] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ventas]    Script Date: 18/12/2024 11:33:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ventas](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDCliente] [int] NOT NULL,
	[Fecha] [datetime] NULL,
	[Total] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ventasitems]    Script Date: 18/12/2024 11:33:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ventasitems](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDVenta] [int] NOT NULL,
	[IDProducto] [int] NOT NULL,
	[PrecioUnitario] [float] NULL,
	[Cantidad] [float] NULL,
	[PrecioTotal] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[clientes] ON 
GO
INSERT [dbo].[clientes] ([ID], [Cliente], [Telefono], [Correo]) VALUES (1, N'Juan Pérez', N'1234567890', N'juan.perez@example.com')
GO
INSERT [dbo].[clientes] ([ID], [Cliente], [Telefono], [Correo]) VALUES (2, N'cari López', N'9876543210', N'maria.lopez@example.com')
GO
INSERT [dbo].[clientes] ([ID], [Cliente], [Telefono], [Correo]) VALUES (3, N'Carlos García', N'4567891234', N'carlos.garcia@example.com')
GO
INSERT [dbo].[clientes] ([ID], [Cliente], [Telefono], [Correo]) VALUES (4, N'Ana Martínez', N'6543219870', N'ana.martinez@example.com')
GO
INSERT [dbo].[clientes] ([ID], [Cliente], [Telefono], [Correo]) VALUES (5, N'Luis Rodríguez', N'7891234560', N'luis.rodriguez@example.com')
GO
INSERT [dbo].[clientes] ([ID], [Cliente], [Telefono], [Correo]) VALUES (6, N'Sofía Hernández', N'3216549870', N'sofia.hernandez@example.com')
GO
INSERT [dbo].[clientes] ([ID], [Cliente], [Telefono], [Correo]) VALUES (7, N'Pedro Fernández', N'1478523690', N'pedro.fernandez@example.com')
GO
INSERT [dbo].[clientes] ([ID], [Cliente], [Telefono], [Correo]) VALUES (8, N'Lucía Gómez', N'9632587410', N'lucia.gomez@example.com')
GO
INSERT [dbo].[clientes] ([ID], [Cliente], [Telefono], [Correo]) VALUES (9, N'Miguel Ramírez', N'8529637410', N'miguel.ramirez@example.com')
GO
INSERT [dbo].[clientes] ([ID], [Cliente], [Telefono], [Correo]) VALUES (14, N'Mati quir', N'546546', N'kasjdl@alksjdlk')
GO
SET IDENTITY_INSERT [dbo].[clientes] OFF
GO
SET IDENTITY_INSERT [dbo].[productos] ON 
GO
INSERT [dbo].[productos] ([ID], [Nombre], [Precio], [Categoria]) VALUES (1, N'Lápiz HB', 0.5, N'Papelería')
GO
INSERT [dbo].[productos] ([ID], [Nombre], [Precio], [Categoria]) VALUES (2, N'Cuaderno Universitario', 2.75, N'Papelería')
GO
INSERT [dbo].[productos] ([ID], [Nombre], [Precio], [Categoria]) VALUES (3, N'Bolígrafo Azul', 0.8, N'Papelería')
GO
INSERT [dbo].[productos] ([ID], [Nombre], [Precio], [Categoria]) VALUES (5, N'Calculadora Científica', 25.5, N'Electrónica')
GO
INSERT [dbo].[productos] ([ID], [Nombre], [Precio], [Categoria]) VALUES (6, N'Memoria USB 16GB', 10, N'Electrónica')
GO
INSERT [dbo].[productos] ([ID], [Nombre], [Precio], [Categoria]) VALUES (7, N'Escritorio de Oficina', 120, N'Muebles')
GO
INSERT [dbo].[productos] ([ID], [Nombre], [Precio], [Categoria]) VALUES (8, N'Silla Giratoria', 85, N'Muebles')
GO
INSERT [dbo].[productos] ([ID], [Nombre], [Precio], [Categoria]) VALUES (9, N'Impresora Multifuncional', 199.99, N'Electrónica')
GO
INSERT [dbo].[productos] ([ID], [Nombre], [Precio], [Categoria]) VALUES (10, N'Papel Resma Carta', 5.5, N'Papelería')
GO
INSERT [dbo].[productos] ([ID], [Nombre], [Precio], [Categoria]) VALUES (11, N'Mouse Inalámbrico', 12.99, N'Hogar')
GO
SET IDENTITY_INSERT [dbo].[productos] OFF
GO
SET IDENTITY_INSERT [dbo].[ventas] ON 
GO
INSERT [dbo].[ventas] ([ID], [IDCliente], [Fecha], [Total]) VALUES (1, 2, CAST(N'2024-12-18T01:39:41.000' AS DateTime), 8.25)
GO
INSERT [dbo].[ventas] ([ID], [IDCliente], [Fecha], [Total]) VALUES (2, 3, CAST(N'2024-12-18T02:45:33.533' AS DateTime), 76.5)
GO
INSERT [dbo].[ventas] ([ID], [IDCliente], [Fecha], [Total]) VALUES (3, 1, CAST(N'2024-12-18T10:36:17.907' AS DateTime), 1)
GO
INSERT [dbo].[ventas] ([ID], [IDCliente], [Fecha], [Total]) VALUES (4, 1, CAST(N'2024-12-18T11:19:40.143' AS DateTime), 97.25)
GO
SET IDENTITY_INSERT [dbo].[ventas] OFF
GO
SET IDENTITY_INSERT [dbo].[ventasitems] ON 
GO
INSERT [dbo].[ventasitems] ([ID], [IDVenta], [IDProducto], [PrecioUnitario], [Cantidad], [PrecioTotal]) VALUES (1, 1, 2, 2.75, 3, 8.25)
GO
INSERT [dbo].[ventasitems] ([ID], [IDVenta], [IDProducto], [PrecioUnitario], [Cantidad], [PrecioTotal]) VALUES (2, 2, 5, 25.5, 3, 76.5)
GO
INSERT [dbo].[ventasitems] ([ID], [IDVenta], [IDProducto], [PrecioUnitario], [Cantidad], [PrecioTotal]) VALUES (3, 3, 1, 0.5, 2, 1)
GO
INSERT [dbo].[ventasitems] ([ID], [IDVenta], [IDProducto], [PrecioUnitario], [Cantidad], [PrecioTotal]) VALUES (4, 4, 2, 2.75, 2, 5.5)
GO
INSERT [dbo].[ventasitems] ([ID], [IDVenta], [IDProducto], [PrecioUnitario], [Cantidad], [PrecioTotal]) VALUES (5, 4, 1, 0.5, 3, 1.5)
GO
INSERT [dbo].[ventasitems] ([ID], [IDVenta], [IDProducto], [PrecioUnitario], [Cantidad], [PrecioTotal]) VALUES (6, 4, 5, 25.5, 3, 76.5)
GO
INSERT [dbo].[ventasitems] ([ID], [IDVenta], [IDProducto], [PrecioUnitario], [Cantidad], [PrecioTotal]) VALUES (7, 4, 2, 2.75, 5, 13.75)
GO
SET IDENTITY_INSERT [dbo].[ventasitems] OFF
GO
USE [master]
GO
ALTER DATABASE [pruebademo] SET  READ_WRITE 
GO
