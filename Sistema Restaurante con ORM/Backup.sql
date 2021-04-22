USE [master]
GO
/****** Object:  Database [BAE_Restaurante]    Script Date: 31/03/2021 14:54:39 ******/
CREATE DATABASE [BAE_Restaurante]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BAE_Restaurante', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\BAE_Restaurante.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BAE_Restaurante_log', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\BAE_Restaurante_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [BAE_Restaurante] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BAE_Restaurante].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BAE_Restaurante] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BAE_Restaurante] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BAE_Restaurante] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BAE_Restaurante] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BAE_Restaurante] SET ARITHABORT OFF 
GO
ALTER DATABASE [BAE_Restaurante] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BAE_Restaurante] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BAE_Restaurante] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BAE_Restaurante] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BAE_Restaurante] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BAE_Restaurante] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BAE_Restaurante] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BAE_Restaurante] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BAE_Restaurante] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BAE_Restaurante] SET  ENABLE_BROKER 
GO
ALTER DATABASE [BAE_Restaurante] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BAE_Restaurante] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BAE_Restaurante] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BAE_Restaurante] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BAE_Restaurante] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BAE_Restaurante] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BAE_Restaurante] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BAE_Restaurante] SET RECOVERY FULL 
GO
ALTER DATABASE [BAE_Restaurante] SET  MULTI_USER 
GO
ALTER DATABASE [BAE_Restaurante] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BAE_Restaurante] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BAE_Restaurante] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BAE_Restaurante] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BAE_Restaurante] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'BAE_Restaurante', N'ON'
GO
ALTER DATABASE [BAE_Restaurante] SET QUERY_STORE = OFF
GO
USE [BAE_Restaurante]
GO
/****** Object:  Table [dbo].[Caja]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Caja](
	[id_caja] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [date] NOT NULL,
	[reserva] [numeric](10, 2) NOT NULL,
	[ingreso] [numeric](10, 2) NULL,
	[egreso] [numeric](10, 2) NULL,
	[comentario] [text] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_caja] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cargo]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cargo](
	[id_cargo] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](45) NOT NULL,
	[sueldo] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_cargo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[nombre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[id_cliente] [int] IDENTITY(1,1) NOT NULL,
	[num_documento] [varchar](13) NULL,
	[tipo_documento] [varchar](30) NOT NULL,
	[nombres] [varchar](45) NOT NULL,
	[apellidos] [varchar](45) NULL,
	[direccion] [text] NULL,
	[celular] [varchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[num_documento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Comida]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comida](
	[id_comida] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](100) NOT NULL,
	[precio] [numeric](10, 2) NULL,
	[cantidad] [int] NOT NULL,
	[comentario] [text] NULL,
	[id_tipo_comida] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_comida] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Contactos]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contactos](
	[id_contactos] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](100) NOT NULL,
	[tipo_contacto] [varchar](50) NOT NULL,
	[celular] [varchar](15) NULL,
	[email] [text] NULL,
	[fecha] [date] NOT NULL,
	[comentario] [text] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_contactos] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Control]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Control](
	[id_control] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [date] NOT NULL,
	[hora_inicio] [time](7) NOT NULL,
	[hora_fin] [time](7) NULL,
	[falta] [bit] NULL,
	[id_empleado] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_control] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Doc_compra]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Doc_compra](
	[id_doc_compra] [int] IDENTITY(1,1) NOT NULL,
	[tipo_doc_compra] [varchar](20) NOT NULL,
	[num_doc_compra] [int] NOT NULL,
	[venta_total] [numeric](10, 3) NOT NULL,
	[fecha] [date] NOT NULL,
	[comentario] [text] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_doc_compra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[num_doc_compra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Doc_venta]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Doc_venta](
	[id_doc_venta] [int] IDENTITY(1,1) NOT NULL,
	[tipo_doc_venta] [varchar](20) NOT NULL,
	[num_doc_venta] [int] NOT NULL,
	[venta_total] [numeric](10, 3) NOT NULL,
	[fecha] [date] NOT NULL,
	[comentario] [text] NULL,
	[id_pedido] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_doc_venta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[id_pedido] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[num_doc_venta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleado]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleado](
	[id_empleado] [int] IDENTITY(1,1) NOT NULL,
	[dni] [varchar](8) NOT NULL,
	[nombres] [varchar](45) NOT NULL,
	[apellidos] [varchar](45) NOT NULL,
	[fecha_nacimiento] [date] NULL,
	[direccion] [text] NULL,
	[celular] [varchar](15) NULL,
	[email] [text] NULL,
	[estado] [bit] NOT NULL,
	[id_cargo] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_empleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[dni] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empresa]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empresa](
	[id_empresa] [int] IDENTITY(1,1) NOT NULL,
	[caracteristica] [text] NOT NULL,
	[descripcion] [text] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_empresa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ingrediente]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ingrediente](
	[id_ingrediente] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](100) NOT NULL,
	[precio] [numeric](10, 3) NOT NULL,
	[cantidad] [int] NULL,
	[comentario] [text] NULL,
	[id_tipo_medida] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_ingrediente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Menu]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Menu](
	[id_menu] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [date] NOT NULL,
	[comentario] [text] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_menu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Menu_Comida]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Menu_Comida](
	[id_menu] [int] NOT NULL,
	[id_comida] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_menu] ASC,
	[id_comida] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mesa]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mesa](
	[id_mesa] [int] IDENTITY(1,1) NOT NULL,
	[codigo] [varchar](50) NOT NULL,
	[estado] [bit] NOT NULL,
	[asientos] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_mesa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pedido]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pedido](
	[id_pedido] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [date] NOT NULL,
	[tipo_pedido] [varchar](30) NOT NULL,
	[tipo_pago] [varchar](30) NOT NULL,
	[imagen_pago] [int] NULL,
	[estado] [varchar](1) NULL,
	[comentario] [text] NULL,
	[id_empleado] [int] NULL,
	[id_cliente] [int] NOT NULL,
	[id_mesa] [int] NULL,
	[direccion_envio] [text] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_pedido] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pedido_Comida]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pedido_Comida](
	[id_pedido] [int] NOT NULL,
	[id_comida] [int] NOT NULL,
	[cantidad] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_comida] ASC,
	[id_pedido] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pedido_Producto]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pedido_Producto](
	[id_pedido] [int] NOT NULL,
	[id_producto] [int] NOT NULL,
	[cantidad] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_producto] ASC,
	[id_pedido] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[id_producto] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](100) NOT NULL,
	[precio] [numeric](10, 3) NOT NULL,
	[cantidad] [int] NOT NULL,
	[fecha_vencimiento] [date] NOT NULL,
	[num_medida] [numeric](10, 3) NOT NULL,
	[comentario] [text] NULL,
	[id_tipo_producto] [int] NOT NULL,
	[id_tipo_medida] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producto_Doc_compra]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto_Doc_compra](
	[id_doc_compra] [int] NOT NULL,
	[id_producto] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_producto] ASC,
	[id_doc_compra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reserva]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reserva](
	[id_reserva] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [date] NOT NULL,
	[hora_inicio] [time](7) NOT NULL,
	[hora_fin] [time](7) NULL,
	[id_cliente] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_reserva] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reserva_Mesa]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reserva_Mesa](
	[id_mesa] [int] NOT NULL,
	[id_reserva] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_reserva] ASC,
	[id_mesa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tipo_comida]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipo_comida](
	[id_tipo_comida] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](35) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_tipo_comida] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tipo_medida]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipo_medida](
	[id_tipo_medida] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](35) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_tipo_medida] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tipo_producto]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipo_producto](
	[id_tipo_producto] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](35) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_tipo_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[usuario] [varchar](50) NOT NULL,
	[contrasena] [varchar](30) NOT NULL,
	[rol] [varchar](30) NOT NULL,
	[estado] [bit] NOT NULL,
	[id_empleado] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[id_empleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Comida]  WITH CHECK ADD FOREIGN KEY([id_tipo_comida])
REFERENCES [dbo].[Tipo_comida] ([id_tipo_comida])
GO
ALTER TABLE [dbo].[Control]  WITH CHECK ADD FOREIGN KEY([id_empleado])
REFERENCES [dbo].[Empleado] ([id_empleado])
GO
ALTER TABLE [dbo].[Doc_venta]  WITH CHECK ADD FOREIGN KEY([id_pedido])
REFERENCES [dbo].[Pedido] ([id_pedido])
GO
ALTER TABLE [dbo].[Empleado]  WITH CHECK ADD FOREIGN KEY([id_cargo])
REFERENCES [dbo].[Cargo] ([id_cargo])
GO
ALTER TABLE [dbo].[Ingrediente]  WITH CHECK ADD FOREIGN KEY([id_tipo_medida])
REFERENCES [dbo].[Tipo_medida] ([id_tipo_medida])
GO
ALTER TABLE [dbo].[Menu_Comida]  WITH CHECK ADD FOREIGN KEY([id_comida])
REFERENCES [dbo].[Comida] ([id_comida])
GO
ALTER TABLE [dbo].[Menu_Comida]  WITH CHECK ADD FOREIGN KEY([id_menu])
REFERENCES [dbo].[Menu] ([id_menu])
GO
ALTER TABLE [dbo].[Pedido]  WITH CHECK ADD FOREIGN KEY([id_cliente])
REFERENCES [dbo].[Cliente] ([id_cliente])
GO
ALTER TABLE [dbo].[Pedido]  WITH CHECK ADD FOREIGN KEY([id_empleado])
REFERENCES [dbo].[Empleado] ([id_empleado])
GO
ALTER TABLE [dbo].[Pedido]  WITH CHECK ADD FOREIGN KEY([id_mesa])
REFERENCES [dbo].[Mesa] ([id_mesa])
GO
ALTER TABLE [dbo].[Pedido_Comida]  WITH CHECK ADD FOREIGN KEY([id_comida])
REFERENCES [dbo].[Comida] ([id_comida])
GO
ALTER TABLE [dbo].[Pedido_Comida]  WITH CHECK ADD FOREIGN KEY([id_pedido])
REFERENCES [dbo].[Pedido] ([id_pedido])
GO
ALTER TABLE [dbo].[Pedido_Producto]  WITH CHECK ADD FOREIGN KEY([id_pedido])
REFERENCES [dbo].[Pedido] ([id_pedido])
GO
ALTER TABLE [dbo].[Pedido_Producto]  WITH CHECK ADD FOREIGN KEY([id_producto])
REFERENCES [dbo].[Producto] ([id_producto])
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD FOREIGN KEY([id_tipo_producto])
REFERENCES [dbo].[Tipo_producto] ([id_tipo_producto])
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD FOREIGN KEY([id_tipo_medida])
REFERENCES [dbo].[Tipo_medida] ([id_tipo_medida])
GO
ALTER TABLE [dbo].[Producto_Doc_compra]  WITH CHECK ADD FOREIGN KEY([id_doc_compra])
REFERENCES [dbo].[Doc_compra] ([id_doc_compra])
GO
ALTER TABLE [dbo].[Producto_Doc_compra]  WITH CHECK ADD FOREIGN KEY([id_producto])
REFERENCES [dbo].[Producto] ([id_producto])
GO
ALTER TABLE [dbo].[Reserva]  WITH CHECK ADD FOREIGN KEY([id_cliente])
REFERENCES [dbo].[Cliente] ([id_cliente])
GO
ALTER TABLE [dbo].[Reserva_Mesa]  WITH CHECK ADD FOREIGN KEY([id_mesa])
REFERENCES [dbo].[Mesa] ([id_mesa])
GO
ALTER TABLE [dbo].[Reserva_Mesa]  WITH CHECK ADD FOREIGN KEY([id_reserva])
REFERENCES [dbo].[Reserva] ([id_reserva])
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD FOREIGN KEY([id_empleado])
REFERENCES [dbo].[Empleado] ([id_empleado])
GO
/****** Object:  StoredProcedure [dbo].[usp_Caja_D]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


--Procedimiento almacenado de Eliminar
CREATE PROCEDURE [dbo].[usp_Caja_D]
	@pid_caja int
as
begin
	begin tran
		begin try
			DELETE Caja
			Where id_caja=@pid_caja
	commit
		end try
		begin catch
			rollback
		end catch
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Caja_egresos]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[usp_Caja_egresos]
	@pbusqueda1 date,
	@pbusqueda2 date
as
	select CONVERT(varchar,fecha,1) as fecha, ingreso, egreso, ingreso-egreso as Ganancia
	from Caja
		where fecha between @pbusqueda1 and @pbusqueda2
	order by fecha desc
GO
/****** Object:  StoredProcedure [dbo].[usp_Caja_I]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Creación de Procedimientos Almacenados 
-- ERICKA MARTINEZ YUFRA 29 DIC 2020

------------------------------------------------------------------
-------------------------- CAJA ----------------------------------
------------------------------------------------------------------

-- Procedimiento almacenado de insertar
CREATE PROCEDURE [dbo].[usp_Caja_I]
	@pfecha date  ,
	@preserva numeric(10,2)  ,
	@pingreso numeric(10,2),
	@pegreso	numeric(10,2),
	@pcomentario text 
as
begin
	begin tran
		begin try
			insert into Caja
			values(@pfecha,@preserva,@pingreso,@pegreso,@pcomentario)
	commit
		end try
		begin catch
			rollback
		end catch
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Caja_S]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Procedimiento almacenado de Listar
CREATE PROCEDURE [dbo].[usp_Caja_S]
as
begin
	select *from Caja
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Caja_U]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Procedimiento almacenado de actualizar
CREATE PROCEDURE [dbo].[usp_Caja_U]
	@pid_caja int,
	@pfecha date  ,
	@preserva numeric(10,2)  ,
	@pingreso numeric(10,2),
	@pegreso	numeric(10,2),
	@pcomentario text 
as
begin
	begin tran
		begin try
			update Caja
				set
					fecha=@pfecha,
					reserva=@preserva,
					ingreso=@pingreso,
					egreso=@pegreso,
					comentario=@pcomentario

			Where id_caja=@pid_caja
	commit
		end try
		begin catch
			rollback
		end catch
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Caja_U2]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Caja_U2]
	@pfecha date  ,
	@pingreso numeric(10,2)
as
begin
	begin tran
		begin try
			update Caja
				set
					fecha=@pfecha,
					ingreso=ingreso + @pingreso

			Where fecha=@pfecha
	commit
		end try
		begin catch
			rollback
		end catch
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Caja_U3]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_Caja_U3]
	@pfecha date  ,
	@pegreso numeric(10,2)
as
begin
	begin tran
		begin try
			update Caja
				set
					fecha=@pfecha,
					egreso=egreso + @pegreso

			Where fecha=@pfecha
	commit
		end try
		begin catch
			rollback
		end catch
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Caja_Verificar]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


--Procedimiento almacenado de Verificar
CREATE PROCEDURE [dbo].[usp_Caja_Verificar]
	@pvalor date,
	@existe bit output
as
begin
	begin tran
		begin try
			if EXISTS (select fecha from Caja
				where fecha=LTRIM(rtrim(@pvalor)))
				begin
					set @existe=1
				end
			else
				begin
					set @existe=0
				end
	commit
		end try
		begin catch
			rollback
		end catch
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Cantidades_totales]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_Cantidades_totales]
@totVenta float out,
@totCompra float out,
@cantCliente int out,
@cantComida int out,
@cantContactos int out,
@cantEmpleado int out,
@cantPedido int out,
@cantProducto int out,
@cantReserva int out
as
	set @totVenta = (select sum(venta_total) as VentaTotal from Doc_venta)
	set @totCompra = (select sum(venta_total) as CompraTotal from Doc_compra)
	set @cantCliente = (select count(id_cliente) as CantCliente from Cliente)
	set @cantComida = (select count(id_comida) as CantComida from Comida)
	set @cantContactos = (select count(id_contactos) as CantContacto from Contactos)
	set @cantEmpleado = (select count(id_empleado) as CantEmpleado from Empleado)
	set @cantPedido = (select count(id_pedido) as CantPedido from Pedido)
	set @cantProducto = (select count(id_producto) as CantProducto from Producto)
	set @cantReserva = (select count(id_reserva) as CantReserva from Reserva)
GO
/****** Object:  StoredProcedure [dbo].[usp_Cargo_D]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


--Procedimiento almacenado de Eliminar
CREATE PROCEDURE [dbo].[usp_Cargo_D]
	@pidCargo int
as
begin
	begin tran
		begin try
			DELETE Cargo 
			Where id_cargo=@pidCargo
	commit
		end try
		begin catch
			rollback
		end catch
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Cargo_I]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Creación de Procedimientos Almacenados 
-- ERICKA MARTINEZ YUFRA 27 DIC 2020

------------------------------------------------------------------
------------------------- CARGO-----------------------------------
------------------------------------------------------------------

-- Procedimiento almacenado de insertar
CREATE PROCEDURE [dbo].[usp_Cargo_I]
	@pnombre varchar(45),
	@psueldo int
as
begin
	begin tran
		begin try
			insert into Cargo
			values(@pnombre,@psueldo)
	commit
		end try
		begin catch
			rollback
		end catch
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Cargo_S]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Procedimiento almacenado de Listar
CREATE PROCEDURE [dbo].[usp_Cargo_S]
as
begin
	SELECT *FROM Cargo
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Cargo_S_Buscar]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


--Procedimiento almacenado de Buscar
CREATE PROCEDURE [dbo].[usp_Cargo_S_Buscar]
	@pbusqueda varchar(150)
as
begin
	select c.id_cargo,c.nombre,c.sueldo
	from Cargo as c
	where c.nombre like '%'+@pbusqueda+'%'
	or c.nombre=@pbusqueda
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Cargo_U]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


--Procedimiento almacenado de actualizar
CREATE PROCEDURE [dbo].[usp_Cargo_U]
	@pidCargo int,
	@pnombre varchar(45),
	@psueldo int
as
begin
	begin tran
		begin try
			update Cargo 
				set
					nombre=@pnombre,
					sueldo=@psueldo
			Where id_cargo=@pidCargo
	commit
		end try
		begin catch
			rollback
		end catch
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Cargo_Verificar]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Procedimiento almacenado de Verificar 
CREATE PROCEDURE [dbo].[usp_Cargo_Verificar]
	@pvalor varchar(100),
	@existe bit output
as
begin
	begin tran
		begin try
			if EXISTS (select nombre from Cargo 
				where nombre=LTRIM(rtrim(@pvalor)))
				begin
					set @existe=1
				end
			else
				begin
					set @existe=0
				end
	commit
		end try
		begin catch
			rollback
		end catch
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Cliente_D]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


--Procedimiento almacenado de Eliminar
CREATE PROCEDURE [dbo].[usp_Cliente_D]
	@pid_cliente int
as
begin
	begin tran
		begin try
			DELETE Cliente
			Where id_cliente=@pid_cliente
	commit
		end try
		begin catch
			rollback
		end catch
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Cliente_I]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Creación de Procedimientos Almacenados 
-- ERICKA MARTINEZ YUFRA 27 DIC 2020

------------------------------------------------------------------
----------------------- CLIENTE ----------------------------------
------------------------------------------------------------------

-- Procedimiento almacenado de insertar
CREATE PROCEDURE [dbo].[usp_Cliente_I]
	@pnum_documento varchar(13),
	@ptipo_documento varchar(30),
	@pnombres varchar(45),
	@papellidos varchar(45),
	@pdireccion text,
	@pcelular varchar(15)
as
begin
	begin tran
		begin try
			insert into Cliente
			values(@pnum_documento,@ptipo_documento,@pnombres,@papellidos,@pdireccion,@pcelular)
	commit
		end try
		begin catch
			rollback
		end catch
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Cliente_S]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Procedimiento almacenado de Listar
CREATE PROCEDURE [dbo].[usp_Cliente_S]
as
begin
	select * from Cliente
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Cliente_S_Buscar]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Procedimiento almacenado de Buscar
CREATE PROCEDURE [dbo].[usp_Cliente_S_Buscar]
	@pbusqueda varchar(150)
as
begin
	select id_cliente,num_documento,tipo_documento,nombres,apellidos,direccion,celular
	from Cliente
	where nombres like '%'+@pbusqueda+'%'
	or apellidos like '%'+@pbusqueda+'%'
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Cliente_S_Buscar_Mejores]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Cliente_S_Buscar_Mejores]
as
begin
	select c.num_documento as 'DNI Cliente',
	 sum(dv.venta_total)[Compra total]
	from Doc_venta as dv
	
	inner join Pedido as p
	on dv.id_pedido=p.id_pedido

	inner join Cliente as c
	on p.id_cliente=c.id_cliente

	group by c.num_documento
	order by [Compra total] desc;
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Cliente_U]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Procedimiento almacenado de actualizar
CREATE PROCEDURE [dbo].[usp_Cliente_U]
	@pid_cliente int,
	@pnum_documento varchar(13),
	@ptipo_documento varchar(30),
	@pnombres varchar(45),
	@papellidos varchar(45),
	@pdireccion text,
	@pcelular varchar(15)
as
begin
	begin tran
		begin try
			update Cliente
				set
					num_documento=@pnum_documento,
					tipo_documento=@ptipo_documento,
					nombres=@pnombres,
					apellidos=@papellidos,
					direccion=@pdireccion,
					celular=@pcelular
			Where id_cliente=@pid_cliente
	commit
		end try
		begin catch
			rollback
		end catch
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Cliente_Verificar]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Procedimiento almacenado de Verificar
CREATE PROCEDURE [dbo].[usp_Cliente_Verificar]
	@pvalor varchar(100),
	@existe bit output
as
begin
	begin tran
		begin try
			if EXISTS (select num_documento from Cliente
				where num_documento=LTRIM(rtrim(@pvalor)))
				begin
					set @existe=1
				end
			else
				begin
					set @existe=0
				end
	commit
		end try
		begin catch
			rollback
		end catch
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Comida_D]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


--Procedimiento almacenado de Eliminar
CREATE PROCEDURE [dbo].[usp_Comida_D]
	@pid_comida int
as
begin
	begin tran
		begin try
			DELETE Comida
			Where id_comida=@pid_comida
	commit
		end try
		begin catch
			rollback
		end catch
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Comida_I]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Creación de Procedimientos Almacenados 
-- ERICKA MARTINEZ YUFRA 27 DIC 2020

------------------------------------------------------------------
------------------------ COMIDA ----------------------------------
------------------------------------------------------------------

-- Procedimiento almacenado de insertar
CREATE PROCEDURE [dbo].[usp_Comida_I]
	@pnombre varchar(100),
	@pprecio numeric(10,3),
	@pcantidad int,
	@pcomentario text,
	@pid_tipo_comida int
as
begin
	begin tran
		begin try
			insert into Comida
			values(@pnombre,@pprecio,@pcantidad,@pcomentario,@pid_tipo_comida)
	commit
		end try
		begin catch
			rollback
		end catch
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Comida_S]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Procedimiento almacenado de Listar
CREATE PROCEDURE [dbo].[usp_Comida_S]
as
begin
	select c.id_comida,c.nombre,c.precio,c.cantidad,c.comentario,tc.nombre,tc.id_tipo_comida
	from Comida as c
	inner join Tipo_comida as tc
	on c.id_tipo_comida=tc.id_tipo_comida
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Comida_S_Buscar]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Procedimiento almacenado de Buscar
CREATE PROCEDURE [dbo].[usp_Comida_S_Buscar]
	@pbusqueda varchar(150)
as
begin
	select c.id_comida,c.nombre,c.precio,c.cantidad,c.comentario,tc.nombre
	from Comida as c
	inner join Tipo_comida as tc
	on c.id_tipo_comida=tc.id_tipo_comida
	where c.nombre like '%'+@pbusqueda+'%'
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Comida_U]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Procedimiento almacenado de actualizar
CREATE PROCEDURE [dbo].[usp_Comida_U]
	@pid_comida INT,
	@pnombre varchar(100),
	@pprecio numeric(10,3),
	@pcantidad int,
	@pcomentario text,
	@pid_tipo_comida int
as
begin
	begin tran
		begin try
			update Comida
				set
					nombre=@pnombre,
					precio=@pprecio,
					cantidad=@pcantidad,
					comentario=@pcomentario,
					id_tipo_comida=@pid_tipo_comida

			Where id_comida=@pid_comida
	commit
		end try
		begin catch
			rollback
		end catch
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Comida_Verificar]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


--Procedimiento almacenado de Verificar
CREATE PROCEDURE [dbo].[usp_Comida_Verificar]
	@pvalor varchar(100),
	@existe bit output
as
begin
	begin tran
		begin try
			if EXISTS (select nombre from Comida
				where nombre=LTRIM(rtrim(@pvalor)))
				begin
					set @existe=1
				end
			else
				begin
					set @existe=0
				end
	commit
		end try
		begin catch
			rollback
		end catch
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Comidas_favoritas]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Comida preferida
create proc [dbo].[usp_Comidas_favoritas]
	@pbusqueda1 date,
	@pbusqueda2 date
as
	select top 5 c.nombre as Comida, sum(pc.cantidad) as Cantidad
	from Pedido_Comida as pc
		inner join Comida as c on c.id_comida=pc.id_comida
		inner join Pedido as p on p.id_pedido=pc.id_pedido
	where p.fecha between @pbusqueda1 and @pbusqueda2
	group by pc.id_comida,c.nombre
	order by Cantidad desc
GO
/****** Object:  StoredProcedure [dbo].[usp_Comidas_por_Categoria]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Cantidad de comidas por categorias
create proc [dbo].[usp_Comidas_por_Categoria]
as
	select tc.nombre as 'Tipo de comida', count(c.id_tipo_comida) as Cantidad
	from Comida as c
			inner join Tipo_comida as tc on c.id_tipo_comida=tc.id_tipo_comida
	group by c.id_tipo_comida,tc.nombre
	order by Cantidad
GO
/****** Object:  StoredProcedure [dbo].[usp_Contactos_D]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


--Procedimiento almacenado de Eliminar
CREATE PROCEDURE [dbo].[usp_Contactos_D]
	@id_contactos int
as
begin
	begin tran
		begin try
			DELETE Contactos
			Where id_contactos=@id_contactos
	commit
		end try
		begin catch
			rollback
		end catch
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Contactos_I]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Creación de Procedimientos Almacenados 
-- ERICKA MARTINEZ YUFRA 29 DIC 2020

------------------------------------------------------------------
----------------------- CONTACTOS --------------------------------
------------------------------------------------------------------

-- Procedimiento almacenado de insertar
CREATE PROCEDURE [dbo].[usp_Contactos_I]
	@pnombre varchar(100)  ,
	@ptipo_contacto varchar(50)  ,
	@pcelular varchar(15),
	@pemail text,
	@pfecha date  ,
	@pcomentario text
as
begin
	begin tran
		begin try
			insert into Contactos
			values(@pnombre,@ptipo_contacto,@pcelular,@pemail,@pfecha,@pcomentario)
	commit
		end try
		begin catch
			rollback
		end catch
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Contactos_S]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Procedimiento almacenado de Listar
CREATE PROCEDURE [dbo].[usp_Contactos_S]
as
begin
	select *from Contactos 
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Contactos_S_Buscar]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Procedimiento almacenado de Buscar
CREATE PROCEDURE [dbo].[usp_Contactos_S_Buscar]
	@pbusqueda varchar(150)
as
begin
	select id_contactos,nombre,tipo_contacto,celular,email,fecha,comentario
	from Contactos
	where nombre like '%'+@pbusqueda+'%'
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Contactos_U]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Procedimiento almacenado de actualizar
CREATE PROCEDURE [dbo].[usp_Contactos_U]
	@id_contactos int,
	@pnombre varchar(100)  ,
	@ptipo_contacto varchar(50)  ,
	@pcelular varchar(15),
	@pemail text,
	@pfecha date  ,
	@pcomentario text
as
begin
	begin tran
		begin try
			update Contactos
				set
					nombre=@pnombre,
					tipo_contacto=@ptipo_contacto,
					celular=@pcelular,
					email=@pemail,
					fecha=@pfecha,
					comentario=@pcomentario

			Where id_contactos=@id_contactos
		end try
		begin catch
			rollback
		end catch
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Contactos_Verificar]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


--Procedimiento almacenado de Verificar
CREATE PROCEDURE [dbo].[usp_Contactos_Verificar]
	@pvalor varchar(100),
	@existe bit output
as
begin
	begin tran
		begin try
			if EXISTS (select nombre from Contactos
				where nombre=LTRIM(rtrim(@pvalor)))
				begin
					set @existe=1
				end
			else
				begin
					set @existe=0
				end
	commit
		end try
		begin catch
			rollback
		end catch
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Control_D]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Procedimiento almacenado de Eliminar
CREATE PROCEDURE [dbo].[usp_Control_D]
	@id_control int
as
begin
	begin tran
		begin try
			DELETE Control 
			Where id_control=@id_control
	commit
		end try
		begin catch
			rollback
		end catch
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Control_I]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Creación de Procedimientos Almacenados 
-- ERICKA MARTINEZ YUFRA 27 DIC 2020

------------------------------------------------------------------
----------------------- CONTROL ---------------------------------
------------------------------------------------------------------

-- Procedimiento almacenado de insertar
CREATE PROCEDURE [dbo].[usp_Control_I]
	@pfecha date,
	@phora_inicio time,
	@phora_fin time,
	@pfalta bit,
	@pid_empleado int
as
begin
	begin tran
		begin try
			insert into Control
			values(@pfecha,@phora_inicio,@phora_fin,@pfalta,@pid_empleado)
	commit
		end try
		begin catch
			rollback
		end catch
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Control_S]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Control_S]
as
begin
	select c.id_control,c.fecha,c.hora_inicio,c.hora_fin,c.falta,e.nombres,e.apellidos,e.id_empleado
	from Control as c
	inner join Empleado as e
	on e.id_empleado=c.id_empleado
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Control_S_Buscar]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Procedimiento almacenado de Buscar
CREATE PROCEDURE [dbo].[usp_Control_S_Buscar]
	@pbusqueda varchar(150)
as
begin
	select c.id_control,c.fecha,c.hora_inicio,c.hora_fin,c.falta,e.nombres,e.apellidos
	from Control as c
	inner join Empleado as e
	on e.id_empleado=c.id_empleado
	where e.nombres like '%'+@pbusqueda+'%'
	or e.apellidos like '%'+@pbusqueda+'%'
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Control_U]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Procedimiento almacenado de actualizar
CREATE PROCEDURE [dbo].[usp_Control_U]
	@id_control int,
	@pfecha date,
	@phora_inicio time,
	@phora_fin time,
	@pfalta bit,
	@pid_empleado int
as
begin
	begin tran
		begin try
			update Control
				set
					fecha= @pfecha,
					hora_inicio=@phora_inicio,
					hora_fin=@phora_fin,
					falta=@pfalta,
					id_empleado=@pid_empleado
			Where id_control=@id_control
	commit
		end try
		begin catch
			rollback
		end catch
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Doc_compra_D]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


--Procedimiento almacenado de Eliminar
CREATE PROCEDURE [dbo].[usp_Doc_compra_D]
	@pid_doc_compra int
as
begin
	begin tran
		begin try
			DELETE Doc_compra
			Where id_doc_compra=@pid_doc_compra
	commit
		end try
		begin catch
			rollback
		end catch
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Doc_compra_I]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Creación de Procedimientos Almacenados 
-- ERICKA MARTINEZ YUFRA 29 DIC 2020

------------------------------------------------------------------
----------------------- DOC_COMPRA --------------------------------
------------------------------------------------------------------

-- Procedimiento almacenado de insertar
CREATE PROCEDURE [dbo].[usp_Doc_compra_I]
	@ptipo_doc_compra varchar(20),
	@pnum_doc_compra int,
	@pventa_total numeric(10,3),
	@pfecha date,
	@pcomentario text
as
begin
	begin tran
		begin try
			insert into Doc_compra
			values(@ptipo_doc_compra,@pnum_doc_compra,@pventa_total,@pfecha,@pcomentario)
	commit
		end try
		begin catch
			rollback
		end catch
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Doc_compra_S]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Procedimiento almacenado de Listar
CREATE PROCEDURE [dbo].[usp_Doc_compra_S]
as
begin
	select *from Doc_compra
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Doc_compra_S_Buscar]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Procedimiento almacenado de Buscar
CREATE PROCEDURE [dbo].[usp_Doc_compra_S_Buscar]
	@pbusqueda int
as
begin
	select *from Doc_compra
	where num_doc_compra=@pbusqueda
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Doc_compra_U]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Procedimiento almacenado de actualizar
CREATE PROCEDURE [dbo].[usp_Doc_compra_U]
	@pid_doc_compra int,
	@ptipo_doc_compra varchar(20),
	@pnum_doc_compra int,
	@pventa_total numeric(10,3),
	@pfecha date,
	@pcomentario text
as
begin
	begin tran
		begin try
			update Doc_compra
				set
					tipo_doc_compra=@ptipo_doc_compra,
					num_doc_compra=@pnum_doc_compra,
					venta_total=@pventa_total,
					fecha=@pfecha,
					comentario=@pcomentario

			Where id_doc_compra=@pid_doc_compra
	commit
		end try
		begin catch
			rollback
		end catch
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Doc_compra_Verificar]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Procedimiento almacenado de Verificar
CREATE PROCEDURE [dbo].[usp_Doc_compra_Verificar]
	@pvalor varchar(100),
	@existe bit output
as
begin
	begin tran
		begin try
			if EXISTS (select num_doc_compra from Doc_compra
				where num_doc_compra=LTRIM(rtrim(@pvalor)))
				begin
					set @existe=1
				end
			else
				begin
					set @existe=0
				end
	commit
		end try
		begin catch
			rollback
		end catch
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Doc_venta_D]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


--Procedimiento almacenado de Eliminar
CREATE PROCEDURE [dbo].[usp_Doc_venta_D]
	@pid_doc_venta int
as
begin
	begin tran
		begin try
			DELETE Doc_venta
			Where id_doc_venta=@pid_doc_venta
	commit
		end try
		begin catch
			rollback
		end catch
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Doc_venta_I]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Creación de Procedimientos Almacenados 
-- ERICKA MARTINEZ YUFRA 28 DIC 2020

------------------------------------------------------------------
----------------------- DOC_VENTA --------------------------------
------------------------------------------------------------------

-- Procedimiento almacenado de insertar
CREATE PROCEDURE [dbo].[usp_Doc_venta_I]
	@ptipo_doc_venta varchar(20),
	@pnum_doc_venta int,
	@pventa_total numeric(10,3),
	@pfecha date,
	@pcomentario text,
	@pid_pedido int
as
begin
	begin tran
		begin try
			insert into Doc_venta
			values(@ptipo_doc_venta,@pnum_doc_venta,@pventa_total,@pfecha,@pcomentario,@pid_pedido)
	commit
		end try
		begin catch
			rollback
		end catch
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Doc_venta_S]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Procedimiento almacenado de Listar
CREATE PROCEDURE [dbo].[usp_Doc_venta_S]
as
begin
	select dv.id_pedido,dv.tipo_doc_venta,dv.num_doc_venta,dv.venta_total,dv.fecha,dv.comentario,
	c.num_documento as 'DNI Cliente',c.nombres as 'Nombres cliente',c.apellidos as 'Apellidos cliente',p.id_pedido,c.id_cliente
	from Doc_venta as dv
	
	inner join Pedido as p
	on dv.id_pedido=p.id_pedido

	inner join Cliente as c
	on p.id_cliente=c.id_cliente
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Doc_venta_S_Buscar]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Procedimiento almacenado de Buscar
CREATE PROCEDURE [dbo].[usp_Doc_venta_S_Buscar]
	@pbusqueda varchar(150)
as
begin
	select dv.id_pedido,dv.tipo_doc_venta,dv.num_doc_venta,dv.venta_total,dv.fecha,dv.comentario,
	c.num_documento as 'DNI Cliente',c.nombres as 'Nombres cliente',c.apellidos as 'Apellidos cliente'
	from Doc_venta as dv
	
	inner join Pedido as p
	on dv.id_pedido=p.id_pedido

	inner join Cliente as c
	on p.id_cliente=c.id_cliente

	where c.nombres like '%'+@pbusqueda+'%'
	or c.apellidos like '%'+@pbusqueda+'%'
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Doc_venta_U]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Procedimiento almacenado de actualizar
CREATE PROCEDURE [dbo].[usp_Doc_venta_U]
	@pid_doc_venta int,
	@ptipo_doc_venta varchar(20),
	@pnum_doc_venta int,
	@pventa_total numeric(10,3),
	@pfecha date,
	@pcomentario text,
	@pid_pedido int
as
begin
	begin tran
		begin try
			update Doc_venta
				set
					tipo_doc_venta=@ptipo_doc_venta,
					num_doc_venta=@pnum_doc_venta,
					venta_total=@pventa_total,
					fecha=@pfecha,
					comentario=@pcomentario,
					id_pedido=@pid_pedido

			Where id_pedido=@pid_doc_venta
	commit
		end try
		begin catch
			rollback
		end catch
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Doc_venta_Verificar]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Procedimiento almacenado de Verificar
CREATE PROCEDURE [dbo].[usp_Doc_venta_Verificar]
	@pvalor int,
	@existe bit output
as
begin
	begin tran
		begin try
			if EXISTS (select num_doc_venta from Doc_venta
				where num_doc_venta=LTRIM(rtrim(@pvalor)))
				begin
					set @existe=1
				end
			else
				begin
					set @existe=0
				end
	commit
		end try
		begin catch
			rollback
		end catch
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Empleado_Activar]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


--Procedimiento almacenado de activar
CREATE PROCEDURE [dbo].[usp_Empleado_Activar]
	@pid_empleado int
as
begin
	begin tran
		begin try
			update Empleado
				set
					estado=1
			Where id_empleado=@pid_empleado
	commit
		end try
		begin catch
			rollback
		end catch
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Empleado_D]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


--Procedimiento almacenado de Eliminar
CREATE PROCEDURE [dbo].[usp_Empleado_D]
	@pid_empleado int
as
begin
	begin tran
		begin try
			DELETE Empleado
			Where id_empleado=@pid_empleado
	commit
		end try
		begin catch
			rollback
		end catch
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Empleado_Desactivar]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Procedimiento almacenado de desactivar
CREATE PROCEDURE [dbo].[usp_Empleado_Desactivar]
	@pid_empleado int
as
begin
	begin tran
		begin try
			update Empleado 
				set
					estado=0
			Where id_empleado=@pid_empleado
	commit
		end try
		begin catch
			rollback
		end catch
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Empleado_I]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Creación de Procedimientos Almacenados 
-- ERICKA MARTINEZ YUFRA 27 DIC 2020

------------------------------------------------------------------
----------------------- EMPLEADO ---------------------------------
------------------------------------------------------------------

-- Procedimiento almacenado de insertar
CREATE PROCEDURE [dbo].[usp_Empleado_I]
	@pdni varchar(8),
	@pnombres varchar(45),
	@papellidos varchar(45),
	@pfecha_nacimiento date,
	@pdireccion text,
	@pcelular varchar(15),
	@pemail text,
	@pestado bit,
    @pid_cargo int
as
begin
	begin tran
		begin try
			insert into Empleado
			values(@pdni,@pnombres,@papellidos,@pfecha_nacimiento,@pdireccion,@pcelular,@pemail,@pestado,@pid_cargo)
	commit
		end try
		begin catch
			rollback
		end catch
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Empleado_S]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Empleado_S]
as
begin
	select e.id_empleado,e.dni,e.nombres,e.apellidos,e.fecha_nacimiento,e.direccion,e.celular,e.email,e.estado,c.nombre,c.id_cargo
	from Empleado as e
	inner join Cargo as c
	on e.id_cargo=c.id_cargo
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Empleado_S_Buscar]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Procedimiento almacenado de Buscar
CREATE PROCEDURE [dbo].[usp_Empleado_S_Buscar]
	@pbusqueda varchar(150)
as
begin
	select e.id_empleado,e.dni,e.nombres,e.apellidos,e.fecha_nacimiento,e.direccion,e.celular,e.email,e.estado,c.nombre
	from Empleado as e
	inner join Cargo as c
	on e.id_cargo=c.id_cargo
	where e.nombres like '%'+@pbusqueda+'%'
	or e.apellidos like '%'+@pbusqueda+'%'
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Empleado_U]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Procedimiento almacenado de actualizar
CREATE PROCEDURE [dbo].[usp_Empleado_U]
	@pid_empleado int,
	@pdni varchar(8),
	@pnombres varchar(45),
	@papellidos varchar(45),
	@pfecha_nacimiento date,
	@pdireccion text,
	@pcelular varchar(15),
	@pemail text,
	@pestado bit,
    @pid_cargo int
as
begin
	begin tran
		begin try
			update Empleado
				set
					dni=@pdni,
					nombres=@pnombres,
					apellidos=@papellidos,
					fecha_nacimiento=@pfecha_nacimiento,
					direccion=@pdireccion,
					celular=@pcelular,
					email=@pemail,
					estado=@pestado,
					id_cargo=@pid_cargo
			Where id_empleado=@pid_empleado
	commit
		end try
		begin catch
			rollback
		end catch
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Empleado_Verificar]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


--Procedimiento almacenado de Verificar
CREATE PROCEDURE [dbo].[usp_Empleado_Verificar]
	@pvalor varchar(100),
	@existe bit output
as
begin
	begin tran
		begin try
			if EXISTS (select dni from Empleado
				where dni=LTRIM(rtrim(@pvalor)))
				begin
					set @existe=1
				end
			else
				begin
					set @existe=0
				end
	commit
		end try
		begin catch
			rollback
		end catch
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Empresa_D]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


--Procedimiento almacenado de Eliminar
CREATE PROCEDURE [dbo].[usp_Empresa_D]
	@pid_empresa int
as
begin
	begin tran
		begin try
			DELETE Empresa
			Where id_empresa=@pid_empresa
	commit
		end try
		begin catch
			rollback
		end catch
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Empresa_I]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Creación de Procedimientos Almacenados 
-- ERICKA MARTINEZ YUFRA 29 DIC 2020

------------------------------------------------------------------
------------------------ EMPRESA ---------------------------------
------------------------------------------------------------------

-- Procedimiento almacenado de insertar
CREATE PROCEDURE [dbo].[usp_Empresa_I]
	@pcaracteristica text,
	@pdescripcion text 
as
begin
	begin tran
		begin try
			insert into Empresa
			values(@pcaracteristica,@pdescripcion)
	commit
		end try
		begin catch
			rollback
		end catch
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Empresa_S]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Procedimiento almacenado de Listar
CREATE PROCEDURE [dbo].[usp_Empresa_S]
as
begin
	select *from Empresa
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Empresa_U]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Procedimiento almacenado de actualizar
CREATE PROCEDURE [dbo].[usp_Empresa_U]
	@id_empresa int,
	@pcaracteristica text,
	@pdescripcion text 
as
begin
	begin tran
		begin try
			update Empresa
				set
					caracteristica=@pcaracteristica,
					descripcion=@pdescripcion

			Where id_empresa=@id_empresa
	commit
		end try
		begin catch
			rollback
		end catch
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Ingrediente_D]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


--Procedimiento almacenado de Eliminar
CREATE PROCEDURE [dbo].[usp_Ingrediente_D]
	@pid_ingrediente int
as
begin
	begin tran
		begin try
			DELETE Ingrediente
			Where id_ingrediente=@pid_ingrediente
	commit
		end try
		begin catch
			rollback
		end catch
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Ingrediente_I]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Creación de Procedimientos Almacenados 
-- ERICKA MARTINEZ YUFRA 29 DIC 2020

------------------------------------------------------------------
---------------------- INGREDIENTE -------------------------------
------------------------------------------------------------------

-- Procedimiento almacenado de insertar
CREATE PROCEDURE [dbo].[usp_Ingrediente_I]
	@pnombre varchar(100),
	@pprecio numeric(10,3)  ,
	@pcantidad int,
	@pcomentario text,
	@pid_tipo_medida int
as
begin
	begin tran
		begin try
			insert into Ingrediente
			values(@pnombre,@pprecio,@pcantidad,@pcomentario,@pid_tipo_medida)
	commit
		end try
		begin catch
			rollback
		end catch
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Ingrediente_S]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Procedimiento almacenado de Listar
CREATE PROCEDURE [dbo].[usp_Ingrediente_S]
as
begin
	select i.nombre,i.precio,i.cantidad,tm.nombre,i.comentario,tm.id_tipo_medida
	from Ingrediente as i
	inner join Tipo_medida as tm
	on i.id_tipo_medida=tm.id_tipo_medida
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Ingrediente_S_Buscar]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Procedimiento almacenado de Buscar
CREATE PROCEDURE [dbo].[usp_Ingrediente_S_Buscar]
	@pbusqueda varchar(150)
as
begin
	select i.nombre,i.precio,i.cantidad,tm.nombre,i.comentario
	from Ingrediente as i
	inner join Tipo_medida as tm
	on i.id_tipo_medida=tm.id_tipo_medida
	where i.nombre like '%'+@pbusqueda+'%'
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Ingrediente_U]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Procedimiento almacenado de actualizar
CREATE PROCEDURE [dbo].[usp_Ingrediente_U]
	@pid_ingrediente int,
	@pnombre varchar(100),
	@pprecio numeric(10,3)  ,
	@pcantidad int,
	@pcomentario text,
	@pid_tipo_medida int
as
begin
	begin tran
		begin try
			update Ingrediente
				set
					nombre=@pnombre,
					precio=@pprecio,
					cantidad=@pcantidad,
					comentario=@pcomentario,
					id_tipo_medida=@pid_tipo_medida

			Where id_ingrediente=@pid_ingrediente
	commit
		end try
		begin catch
			rollback
		end catch
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Menu_Comida_D]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Procedimiento almacenado de Eliminar
CREATE PROCEDURE [dbo].[usp_Menu_Comida_D]
	@pid_menu INT,
	@pid_comida INT
as
begin
	begin tran
		begin try
			DELETE Menu_Comida
			Where id_menu=@pid_menu
			and id_comida=@pid_comida
	commit
		end try
		begin catch
			rollback
		end catch
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Menu_Comida_I]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Creación de Procedimientos Almacenados 
-- ERICKA MARTINEZ YUFRA 29 DIC 2020

------------------------------------------------------------------
---------------------- MENU_COMIDA -------------------------------
------------------------------------------------------------------

-- Procedimiento almacenado de insertar
CREATE PROCEDURE [dbo].[usp_Menu_Comida_I]
	@pid_menu INT,
	@pid_comida INT
as
begin
	begin tran
		begin try
			insert into Menu_Comida
			values(@pid_menu,@pid_comida)
	commit
		end try
		begin catch
			rollback
		end catch
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Menu_Comida_S]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Procedimiento almacenado de Listar
CREATE PROCEDURE  [dbo].[usp_Menu_Comida_S]
as
begin
	select *from Menu_Comida
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Menu_D]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


--Procedimiento almacenado de Eliminar
CREATE PROCEDURE [dbo].[usp_Menu_D]
	@pid_menu int
as
begin
	begin tran
		begin try
			DELETE Menu
			Where id_menu=@pid_menu
	commit
		end try
		begin catch
			rollback
		end catch
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Menu_I]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Creación de Procedimientos Almacenados 
-- ERICKA MARTINEZ YUFRA 29 DIC 2020

------------------------------------------------------------------
-------------------------- MENU ----------------------------------
------------------------------------------------------------------

-- Procedimiento almacenado de insertar
CREATE PROCEDURE [dbo].[usp_Menu_I]
	@pfecha date,
	@pcomentario text
as
begin
	begin tran
		begin try
			insert into Menu
			values(@pfecha,@pcomentario)
	commit
		end try
		begin catch
			rollback
		end catch
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Menu_S]    Script Date: 31/03/2021 14:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Procedimiento almacenado de Listar
CREATE PROCEDURE [dbo].[usp_Menu_S]
as
begin
	select * from Menu
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Menu_U]    Script Date: 31/03/2021 14:54:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Procedimiento almacenado de actualizar
CREATE PROCEDURE [dbo].[usp_Menu_U]
	@pid_menu int,
	@pfecha date,
	@pcomentario text
as
begin
	begin tran
		begin try
			update Menu
				set
					fecha=@pfecha,
					comentario=@pcomentario

			Where id_menu=@pid_menu
	commit
		end try
		begin catch
			rollback
		end catch
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Mesa_Activar]    Script Date: 31/03/2021 14:54:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


--Procedimiento almacenado de activar
CREATE PROCEDURE  [dbo].[usp_Mesa_Activar]
	@pid_mesa int
as
begin
	begin tran
		begin try
			update Mesa
				set
					estado=1
			Where id_mesa=@pid_mesa
	commit
		end try
		begin catch
			rollback
		end catch
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Mesa_D]    Script Date: 31/03/2021 14:54:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


--Procedimiento almacenado de Eliminar
CREATE PROCEDURE [dbo].[usp_Mesa_D]
	@pid_mesa int
as
begin
	begin tran
		begin try
			DELETE Mesa 
			Where id_mesa=@pid_mesa
	commit
		end try
		begin catch
			rollback
		end catch
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Mesa_Desactivar]    Script Date: 31/03/2021 14:54:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Procedimiento almacenado de desactivar
CREATE PROCEDURE [dbo].[usp_Mesa_Desactivar]
	@pid_mesa int
as
begin
	begin tran
		begin try
			update Mesa 
				set
					estado=0
			Where id_mesa=@pid_mesa
	commit
		end try
		begin catch
			rollback
		end catch
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Mesa_I]    Script Date: 31/03/2021 14:54:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Creación de Procedimientos Almacenados 
-- ERICKA MARTINEZ YUFRA 28 DIC 2020

------------------------------------------------------------------
----------------------- MESA -------------------------------------
------------------------------------------------------------------

-- Procedimiento almacenado de insertar
CREATE PROCEDURE [dbo].[usp_Mesa_I]
	@pcodigo varchar(50),
	@pestado bit,
	@pasientos int
as
begin
	begin tran
		begin try
			insert into Mesa
			values(@pcodigo,@pestado,@pasientos)
	commit
		end try
		begin catch
			rollback
		end catch
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Mesa_S]    Script Date: 31/03/2021 14:54:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Procedimiento almacenado de Listar
CREATE PROCEDURE [dbo].[usp_Mesa_S]
as
begin
	select * FROM Mesa
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Mesa_S_Buscar]    Script Date: 31/03/2021 14:54:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


--Procedimiento almacenado de Buscar
CREATE PROCEDURE [dbo].[usp_Mesa_S_Buscar]
	@pbusqueda varchar(150)
as
begin
	select id_mesa,codigo,estado,asientos
	from Mesa
	where codigo=@pbusqueda
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Mesa_S_Buscar_False]    Script Date: 31/03/2021 14:54:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Mesa_S_Buscar_False]
as
begin
	select id_mesa,codigo,estado,asientos
	from Mesa
	where estado=0
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Mesa_S_Buscar_True]    Script Date: 31/03/2021 14:54:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Mesa_S_Buscar_True]
as
begin
	select id_mesa,codigo,estado,asientos
	from Mesa
	where estado=1
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Mesa_U]    Script Date: 31/03/2021 14:54:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Procedimiento almacenado de actualizar
CREATE PROCEDURE [dbo].[usp_Mesa_U]
	@pid_mesa int,
	@pcodigo varchar(50),
	@pestado bit,
	@pasientos int
as
begin
	begin tran
		begin try
			update Mesa
				set
					codigo=@pcodigo,
					estado=@pestado,
					asientos=@pasientos
			Where id_mesa=@pid_mesa
	commit
		end try
		begin catch
			rollback
		end catch
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Mesa_Verificar]    Script Date: 31/03/2021 14:54:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


--Procedimiento almacenado de Verificar
CREATE PROCEDURE [dbo].[usp_Mesa_Verificar]
	@pvalor varchar(100),
	@existe bit output
as
begin
	begin tran
		begin try
			if EXISTS (select codigo from Mesa
				where codigo=LTRIM(rtrim(@pvalor)))
				begin
					set @existe=1
				end
			else
				begin
					set @existe=0
				end

	commit
		end try
		begin catch
			rollback
		end catch
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Pedido_Activar]    Script Date: 31/03/2021 14:54:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


--Procedimiento almacenado de activar
CREATE PROCEDURE [dbo].[usp_Pedido_Activar]
	@pid_pedido int
as
begin
	begin tran
		begin try
			update Pedido
				set
					estado=1
			Where id_pedido=@pid_pedido
	commit
		end try
		begin catch
			rollback
		end catch
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Pedido_Comida_D]    Script Date: 31/03/2021 14:54:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


--Procedimiento almacenado de Eliminar
CREATE PROCEDURE [dbo].[usp_Pedido_Comida_D]
	@pid_pedido INT,
	@pid_comida INT
as
begin
	begin tran
		begin try
			DELETE Pedido_Comida
			Where id_pedido=@pid_pedido
			and id_comida=@pid_comida
	commit
		end try
		begin catch
			rollback
		end catch
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Pedido_Comida_I]    Script Date: 31/03/2021 14:54:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Creación de Procedimientos Almacenados 
-- ERICKA MARTINEZ YUFRA 29 DIC 2020

------------------------------------------------------------------
--------------------- PEDIDO_COMIDA ------------------------------
------------------------------------------------------------------

-- Procedimiento almacenado de insertar
CREATE PROCEDURE [dbo].[usp_Pedido_Comida_I]
	@pid_pedido INT,
	@pid_comida INT,
	@pcantidad int
as
begin
	begin tran
		begin try
			insert into Pedido_Comida
			values(@pid_pedido,@pid_comida,@pcantidad)
	commit
		end try
		begin catch
			rollback
		end catch
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Pedido_Comida_S]    Script Date: 31/03/2021 14:54:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Procedimiento almacenado de Listar
CREATE PROCEDURE [dbo].[usp_Pedido_Comida_S]
as
begin
	select * from Pedido_Comida
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Pedido_Comida_S_Mas_vendido]    Script Date: 31/03/2021 14:54:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Pedido_Comida_S_Mas_vendido]
as
begin
	select top(5) with ties c.nombre, sum(pc.cantidad)[Ventas]
	from Pedido_Comida as pc
		inner join Comida as c
		on pc.id_comida=c.id_comida
	group by c.nombre
	order by Ventas desc;
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Pedido_Comida_U]    Script Date: 31/03/2021 14:54:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Procedimiento almacenado de actualizar
CREATE PROCEDURE [dbo].[usp_Pedido_Comida_U]
	@pid_pedido INT,
	@pid_comida INT,
	@pcantidad int
as
begin
	begin tran
		begin try
			update Pedido_Comida
				set
					id_pedido=@pid_pedido,
					id_comida=@pid_comida,
					cantidad=@pcantidad

			Where id_pedido=@pid_pedido
			and id_comida=@pid_comida
	commit
		end try
		begin catch
			rollback
		end catch
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Pedido_D]    Script Date: 31/03/2021 14:54:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



--Procedimiento almacenado de Eliminar
CREATE PROCEDURE [dbo].[usp_Pedido_D]
	@pid_pedido int
as
begin
	begin tran
		begin try
			DELETE Pedido
			Where id_pedido=@pid_pedido
	commit
		end try
		begin catch
			rollback
		end catch
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Pedido_Desactivar]    Script Date: 31/03/2021 14:54:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Procedimiento almacenado de desactivar
CREATE PROCEDURE [dbo].[usp_Pedido_Desactivar]
	@pid_pedido int
as
begin
	begin tran
		begin try
			update Pedido 
				set
					estado=0
			Where id_pedido=@pid_pedido
	commit
		end try
		begin catch
			rollback
		end catch
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Pedido_I]    Script Date: 31/03/2021 14:54:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Creación de Procedimientos Almacenados 
-- ERICKA MARTINEZ YUFRA 27 DIC 2020

------------------------------------------------------------------
----------------------- PEDIDO ---------------------------------
------------------------------------------------------------------

-- Procedimiento almacenado de insertar
CREATE PROCEDURE [dbo].[usp_Pedido_I]
	@pfecha date,
	@ptipo_pedido varchar(30),
	@ptipo_pago varchar(30),
	@pimagen_pago varbinary(max),
	@pestado varchar,
	@pcomentario text,
	@pid_empleado int,
	@pid_cliente int,
	@pid_mesa int,
	@direccion_envio text
as
begin
	begin tran
		begin try
			insert into Pedido
			values(@pfecha,@ptipo_pedido,@ptipo_pago,@pimagen_pago,@pestado,@pcomentario,
			@pid_empleado,@pid_cliente,@pid_mesa,@direccion_envio)
	commit
		end try
		begin catch
			rollback
		end catch
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Pedido_Producto_D]    Script Date: 31/03/2021 14:54:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


--Procedimiento almacenado de Eliminar
CREATE PROCEDURE [dbo].[usp_Pedido_Producto_D]
	@pid_pedido INT,
	@pid_producto INT
as
begin
	begin tran
		begin try
			DELETE Pedido_Producto
			Where id_pedido=@pid_pedido
			and id_producto=@pid_producto
	commit
		end try
		begin catch
			rollback
		end catch
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Pedido_Producto_I]    Script Date: 31/03/2021 14:54:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Creación de Procedimientos Almacenados 
-- ERICKA MARTINEZ YUFRA 29 DIC 2020

------------------------------------------------------------------
--------------------- PEDIDO_PRODUCTO ----------------------------
------------------------------------------------------------------

-- Procedimiento almacenado de insertar
CREATE PROCEDURE [dbo].[usp_Pedido_Producto_I]
	@pid_pedido INT,
	@pid_producto INT,
	@pcantidad int
as
begin
	begin tran
		begin try
			insert into Pedido_Producto
			values(@pid_pedido,@pid_producto,@pcantidad)
	commit
		end try
		begin catch
			rollback
		end catch
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Pedido_Producto_S]    Script Date: 31/03/2021 14:54:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Procedimiento almacenado de Listar
CREATE PROCEDURE [dbo].[usp_Pedido_Producto_S]
as
begin
	select * from Pedido_Producto
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Pedido_Producto_S_Mas_vendido]    Script Date: 31/03/2021 14:54:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Pedido_Producto_S_Mas_vendido]
as
begin
	select top(5) with ties p.nombre, sum(pp.cantidad)[Ventas]
	from Pedido_Producto as pp
		inner join Producto as p
		on pp.id_producto=p.id_producto
	group by p.nombre
	order by Ventas desc;
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Pedido_Producto_U]    Script Date: 31/03/2021 14:54:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Pedido_Producto_U]
	@pid_pedido INT,
	@pid_producto INT,
	@pcantidad int
as
begin
	begin tran
		begin try
			update Pedido_Producto
				set
					id_pedido=@pid_pedido,
					id_producto=@pid_producto,
					cantidad=@pcantidad

			Where id_pedido=@pid_pedido
			and id_producto=@pid_producto
	commit
		end try
		begin catch
			rollback
		end catch
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Pedido_S]    Script Date: 31/03/2021 14:54:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Procedimiento almacenado de Listar
CREATE PROCEDURE [dbo].[usp_Pedido_S]
as
begin
	select p.id_pedido,p.fecha,p.tipo_pedido,p.tipo_pago,p.imagen_pago,p.estado,p.direccion_envio,p.comentario,
	e.nombres as 'Nombre Empleado',e.apellidos as 'Apellido Empleado',
	c.num_documento as 'DNI Cliente',c.nombres as 'Nombre Cliente',c.apellidos as 'Apellido Cliente', 
	m.codigo as 'Codigo mesa', p.id_cliente, p.id_empleado, p.id_mesa

	from Pedido as p
	inner join Cliente as c
	on p.id_cliente=c.id_cliente

	inner join Empleado as e
	on p.id_empleado=e.id_empleado

	inner join Mesa as m
	on p.id_mesa=m.id_mesa
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Pedido_S_Buscar]    Script Date: 31/03/2021 14:54:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Procedimiento almacenado de Buscar
CREATE PROCEDURE [dbo].[usp_Pedido_S_Buscar]
	@pbusqueda varchar(150)
as
begin
	select p.id_pedido,p.fecha,p.tipo_pedido,p.tipo_pago,p.imagen_pago,p.estado,p.direccion_envio,p.comentario,
	e.nombres as 'Nombre Empleado',e.apellidos as 'Apellido Empleado',
	c.num_documento as 'DNI Cliente',c.nombres as 'Nombre Cliente',c.apellidos as 'Apellido Cliente',
	m.codigo as 'Codigo mesa'

	from Pedido as p
	inner join Cliente as c
	on p.id_cliente=c.id_cliente

	inner join Empleado as e
	on p.id_empleado=e.id_empleado

	inner join Mesa as m
	on p.id_mesa=m.id_mesa

	where e.nombres like '%'+@pbusqueda+'%'
	or e.apellidos like '%'+@pbusqueda+'%'
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Pedido_S_Buscar_A]    Script Date: 31/03/2021 14:54:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Pedido_S_Buscar_A]
as
begin
	select p.id_pedido,p.fecha,p.tipo_pedido,p.tipo_pago,p.imagen_pago,p.estado,p.direccion_envio,p.comentario,
	e.nombres as 'Nombre Empleado',e.apellidos as 'Apellido Empleado',
	c.num_documento as 'DNI Cliente',c.nombres as 'Nombre Cliente',c.apellidos as 'Apellido Cliente',
	m.codigo as 'Codigo mesa',c.id_cliente,e.id_empleado,m.id_mesa

	from Pedido as p
	inner join Cliente as c
	on p.id_cliente=c.id_cliente

	inner join Empleado as e
	on p.id_empleado=e.id_empleado

	inner join Mesa as m
	on p.id_mesa=m.id_mesa

	where p.estado='A'
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Pedido_S_Buscar_Fechas]    Script Date: 31/03/2021 14:54:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Pedido_S_Buscar_Fechas]
	@pbusqueda1 date,
	@pbusqueda2 date
as
begin
	select p.fecha as 'Fecha',p.tipo_pedido as 'Tipo del pedido',p.tipo_pago as 'Tipo de pago',p.estado as 'Estado',p.direccion_envio as 'Dirección del envío',p.comentario as 'Comentario',
	e.nombres as 'Nombre del empleado',e.apellidos as 'Apellido del empleado',
	c.num_documento as 'DNI Cliente',c.nombres as 'Nombre del cliente',c.apellidos as 'Apellido del cliente',
	m.codigo as 'Codigo mesa'

	from Pedido as p
	inner join Cliente as c
	on p.id_cliente=c.id_cliente

	inner join Empleado as e
	on p.id_empleado=e.id_empleado

	inner join Mesa as m
	on p.id_mesa=m.id_mesa

	where p.fecha>@pbusqueda1 and p.fecha <@pbusqueda2
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Pedido_U]    Script Date: 31/03/2021 14:54:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Procedimiento almacenado de actualizar
CREATE PROCEDURE [dbo].[usp_Pedido_U]
	@pid_pedido int,
	@pfecha date,
	@ptipo_pedido varchar(30),
	@ptipo_pago varchar(30),
	@pimagen_pago int,
	@pestado varchar,
	@pcomentario text,
	@pid_empleado int,
	@pid_cliente int,
	@pid_mesa int,
	@direccion_envio text
as
begin
	begin tran
		begin try
			update Pedido
				set
					fecha=@pfecha,
					tipo_pedido=@ptipo_pedido,
					tipo_pago=@ptipo_pago,
					imagen_pago=@pimagen_pago,
					estado=@pestado,
					comentario=@pcomentario,
					id_empleado=@pid_empleado,
					id_cliente=@pid_cliente,
					id_mesa=@pid_mesa,
					direccion_envio= @direccion_envio

			Where id_pedido=@pid_pedido
	commit
		end try
		begin catch
			rollback
		end catch
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Pedido_Venta_Comida]    Script Date: 31/03/2021 14:54:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Pedido_Venta_Comida]
@pid_pedido int
as
begin
	select pc.cantidad,c.nombre,c.precio, pc.cantidad*c.precio as 'Valor Venta'
	from Pedido as p
	inner join Pedido_Comida as pc
	on p.id_pedido=pc.id_pedido
	inner join Comida as c
	on pc.id_comida=c.id_comida
	where p.id_pedido=@pid_pedido
	UNION
	select pd.cantidad,c.nombre,c.precio, pd.cantidad*c.precio as 'Valor Venta'
	from Pedido as p
	inner join Pedido_Producto as pd
	on p.id_pedido=pd.id_pedido
	inner join Producto as c
	on pd.id_producto=c.id_producto
	where p.id_pedido=@pid_pedido
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Pedidos_Empleados]    Script Date: 31/03/2021 14:54:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[usp_Pedidos_Empleados]
	@pbusqueda1 date,
	@pbusqueda2 date
as
	select  e.nombres+' '+e.apellidos as Nombre, count(p.id_empleado) as CantVentas
	from Pedido as p
		inner join Empleado as e on e.id_empleado=p.id_empleado
	where p.fecha between @pbusqueda1 and @pbusqueda2
	group by p.id_empleado, e.nombres,e.apellidos
GO
/****** Object:  StoredProcedure [dbo].[usp_Pedidos_Fechas]    Script Date: 31/03/2021 14:54:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_Pedidos_Fechas]
	@pbusqueda1 date,
	@pbusqueda2 date
as
	select CONVERT(varchar,p.fecha,1) as fecha, p.tipo_pedido, p.tipo_pago, e.nombres+' '+e.apellidos as Empleado, c.nombres+' '+c.apellidos as Cliente, m.codigo,p.direccion_envio
	from Pedido as p
	left join Empleado as e on e.id_empleado=p.id_empleado
	left join Cliente as c on c.id_cliente=p.id_cliente
	left join Mesa as m on m.id_mesa=p.id_mesa
		where fecha between @pbusqueda1 and @pbusqueda2
	order by fecha 
GO
/****** Object:  StoredProcedure [dbo].[usp_Producto_D]    Script Date: 31/03/2021 14:54:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



--Procedimiento almacenado de Eliminar
CREATE PROCEDURE [dbo].[usp_Producto_D]
	@pid_producto int
as
begin
	begin tran
		begin try
			DELETE Producto
			Where id_producto=@pid_producto
	commit
		end try
		begin catch
			rollback
		end catch
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Producto_Doc_compra_D]    Script Date: 31/03/2021 14:54:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Procedimiento almacenado de Eliminar
CREATE PROCEDURE [dbo].[usp_Producto_Doc_compra_D]
	@pid_producto INT,
	@pid_doc_compra INT
as
begin
	begin tran
		begin try
			DELETE Producto_Doc_compra
			Where id_producto=@pid_producto
			and id_doc_compra=@pid_doc_compra
	commit
		end try
		begin catch
			rollback
		end catch
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Producto_Doc_compra_I]    Script Date: 31/03/2021 14:54:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Creación de Procedimientos Almacenados 
-- ERICKA MARTINEZ YUFRA 29 DIC 2020

------------------------------------------------------------------
------------------- PRODUCTO_DOC_COMPRA --------------------------
------------------------------------------------------------------

-- Procedimiento almacenado de insertar
CREATE PROCEDURE [dbo].[usp_Producto_Doc_compra_I]
	@pid_producto INT,
	@pid_doc_compra INT
as
begin
	begin tran
		begin try
			insert into Producto_Doc_compra
			values(@pid_producto,@pid_doc_compra)
	commit
		end try
		begin catch
			rollback
		end catch
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Producto_Doc_compra_S]    Script Date: 31/03/2021 14:54:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Procedimiento almacenado de Listar
CREATE PROCEDURE  [dbo].[usp_Producto_Doc_compra_S]
as
begin
	select *from Producto_Doc_compra
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Producto_I]    Script Date: 31/03/2021 14:54:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Creación de Procedimientos Almacenados 
-- ERICKA MARTINEZ YUFRA 27 DIC 2020

------------------------------------------------------------------
----------------------- PRODUCTO ---------------------------------
------------------------------------------------------------------

-- Procedimiento almacenado de insertar
CREATE PROCEDURE [dbo].[usp_Producto_I]
	@pnombre varchar(100),
	@pprecio numeric(10,3) ,
	@pcantidad int  ,
	@pfecha_vencimiento date  ,
	@pnum_medida numeric (10,3) ,
	@pcomentario text,
	@pid_tipo_producto int ,
	@pid_tipo_medida int
as
begin
	begin tran
		begin try
			insert into Producto
			values(@pnombre,@pprecio,@pcantidad,@pfecha_vencimiento,@pnum_medida,@pcomentario,@pid_tipo_producto,@pid_tipo_medida)
	commit
		end try
		begin catch
			rollback
		end catch
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Producto_por_Categoria]    Script Date: 31/03/2021 14:54:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



--Cantidad de productos por categorias
create proc [dbo].[usp_Producto_por_Categoria]
as
	select tp.nombre as 'Tipo de producto', count(p.id_tipo_producto) as Cantidad
	from Producto as p
			inner join Tipo_producto as tp on p.id_tipo_producto=tp.id_tipo_producto
	group by p.id_tipo_producto,tp.nombre
	order by Cantidad
GO
/****** Object:  StoredProcedure [dbo].[usp_Producto_S]    Script Date: 31/03/2021 14:54:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Procedimiento almacenado de Listar
CREATE PROCEDURE [dbo].[usp_Producto_S]
as
begin
	select p.nombre,p.precio,p.cantidad,p.fecha_vencimiento,p.num_medida,tm.nombre,tp.nombre,p.comentario,tm.id_tipo_medida,tp.id_tipo_producto, p.id_producto
	from Producto as p
	inner join Tipo_producto as tp
	on p.id_tipo_producto=tp.id_tipo_producto
	inner join Tipo_medida as tm
	on p.id_tipo_medida=tm.id_tipo_medida
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Producto_S_Buscar]    Script Date: 31/03/2021 14:54:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Procedimiento almacenado de Buscar
CREATE PROCEDURE [dbo].[usp_Producto_S_Buscar]
	@pbusqueda varchar(150)
as
begin
	select p.nombre,p.precio,p.cantidad,p.fecha_vencimiento,p.num_medida,tm.nombre,tp.nombre,p.comentario
	from Producto as p
	inner join Tipo_producto as tp
	on p.id_tipo_producto=tp.id_tipo_producto
	inner join Tipo_medida as tm
	on p.id_tipo_medida=tm.id_tipo_medida
	where p.nombre like '%'+@pbusqueda+'%'
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Producto_U]    Script Date: 31/03/2021 14:54:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Procedimiento almacenado de actualizar
CREATE PROCEDURE [dbo].[usp_Producto_U]
	@pid_producto int,
	@pnombre varchar(100),
	@pprecio numeric(10,3) ,
	@pcantidad int  ,
	@pfecha_vencimiento date  ,
	@pnum_medida numeric (10,3) ,
	@pcomentario text,
	@pid_tipo_producto int ,
	@pid_tipo_medida int
as
begin
	begin tran
		begin try
			update Producto
				set
					nombre=@pnombre,
					precio=@pprecio,
					cantidad=@pcantidad,
					fecha_vencimiento=@pfecha_vencimiento,
					num_medida=@pnum_medida,
					comentario=@pcomentario,
					id_tipo_producto=@pid_tipo_producto,
					id_tipo_medida=@pid_tipo_medida

			Where id_producto=@pid_producto
	commit
		end try
		begin catch
			rollback
		end catch
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Productos_favoritos]    Script Date: 31/03/2021 14:54:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Producto preferido
create proc [dbo].[usp_Productos_favoritos]
	@pbusqueda1 date,
	@pbusqueda2 date
as
	select top 5 tp.nombre+' '+ p.nombre+' ' +convert(varchar(10), p.num_medida)+' ' + tm.nombre as Producto, sum(pp.cantidad) as Cantidad
	from Pedido_Producto as pp
		inner join Producto as p on p.id_producto=pp.id_producto
		inner join Tipo_producto as tp on p.id_tipo_producto=tp.id_tipo_producto
		inner join Tipo_medida as tm on p.id_tipo_medida=tm.id_tipo_medida
		inner join Pedido as pe on pe.id_pedido=pp.id_pedido
	where pe.fecha between @pbusqueda1 and @pbusqueda2
	group by pp.id_producto,tp.nombre,p.nombre,p.num_medida,tm.nombre
	order by Cantidad desc
GO
/****** Object:  StoredProcedure [dbo].[usp_Reserva_D]    Script Date: 31/03/2021 14:54:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


--Procedimiento almacenado de Eliminar
CREATE PROCEDURE [dbo].[usp_Reserva_D]
	@pid_reserva int
as
begin
	begin tran
		begin try
			DELETE Reserva
			Where id_reserva=@pid_reserva
	commit
		end try
		begin catch
			rollback
		end catch
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Reserva_I]    Script Date: 31/03/2021 14:54:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Creación de Procedimientos Almacenados 
-- ERICKA MARTINEZ YUFRA 29 DIC 2020

------------------------------------------------------------------
----------------------- RESERVA ----------------------------------
------------------------------------------------------------------

-- Procedimiento almacenado de insertar
CREATE PROCEDURE [dbo].[usp_Reserva_I]
	@pfecha date,
	@phora_inicio time,
	@phora_fin time,
	@pid_cliente int
as
begin
	begin tran
		begin try
			insert into Reserva
			values(@pfecha,@phora_inicio,@phora_fin,@pid_cliente)
	commit
		end try
		begin catch
			rollback
		end catch
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Reserva_Mesa_D]    Script Date: 31/03/2021 14:54:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Procedimiento almacenado de Eliminar
CREATE PROCEDURE [dbo].[usp_Reserva_Mesa_D]
	@pid_mesa INT,
	@pid_reserva INT
as
begin
	begin tran
		begin try
			DELETE Reserva_Mesa
			Where id_mesa=@pid_mesa
			and id_reserva=@pid_reserva
	commit
		end try
		begin catch
			rollback
		end catch
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Reserva_Mesa_I]    Script Date: 31/03/2021 14:54:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Creación de Procedimientos Almacenados 
-- ERICKA MARTINEZ YUFRA 29 DIC 2020

------------------------------------------------------------------
--------------------- RESERVA_MESA -------------------------------
------------------------------------------------------------------

-- Procedimiento almacenado de insertar
CREATE PROCEDURE [dbo].[usp_Reserva_Mesa_I]
	@pid_mesa INT,
	@pid_reserva INT
as
begin
	begin tran
		begin try
			insert into Reserva_Mesa
			values(@pid_mesa,@pid_reserva)
	commit
		end try
		begin catch
			rollback
		end catch
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Reserva_Mesa_S]    Script Date: 31/03/2021 14:54:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Procedimiento almacenado de Listar
CREATE PROCEDURE  [dbo].[usp_Reserva_Mesa_S]
as
begin
	select *from Reserva_Mesa
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Reserva_S]    Script Date: 31/03/2021 14:54:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Reserva_S]
as
begin
	select r.id_reserva,r.fecha,r.hora_inicio,r.hora_fin,c.num_documento,c.nombres,c.apellidos, c.id_cliente
	from Reserva as r
	inner join Cliente as c
	on r.id_cliente=c.id_cliente
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Reserva_S_Buscar]    Script Date: 31/03/2021 14:54:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


--Procedimiento almacenado de Buscar
CREATE PROCEDURE [dbo].[usp_Reserva_S_Buscar]
	@pbusqueda varchar(150)
as
begin
	select r.id_reserva,r.fecha,r.hora_inicio,r.hora_fin,c.num_documento,c.nombres,c.apellidos
	from Reserva as r
	inner join Cliente as c
	on r.id_cliente=c.id_cliente
	where c.nombres like '%'+@pbusqueda+'%'
	or c.apellidos like '%'+@pbusqueda+'%'
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Reserva_S_Buscar_Fecha]    Script Date: 31/03/2021 14:54:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Reserva_S_Buscar_Fecha]
	@pbusqueda date
as
begin
	select r.id_reserva,r.fecha,r.hora_inicio,r.hora_fin,c.num_documento,c.nombres,c.apellidos
	from Reserva as r
	inner join Cliente as c
	on r.id_cliente=c.id_cliente
	where r.fecha=@pbusqueda
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Reserva_S_Buscar_Fechas]    Script Date: 31/03/2021 14:54:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Reserva_S_Buscar_Fechas]
	@pbusqueda1 date,
	@pbusqueda2 date
as
begin
	select r.id_reserva,r.fecha,r.hora_inicio,r.hora_fin,c.num_documento,c.nombres,c.apellidos,c.id_cliente
	from Reserva as r
	inner join Cliente as c
	on r.id_cliente=c.id_cliente
	where r.fecha>@pbusqueda1 and r.fecha<@pbusqueda2
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Reserva_U]    Script Date: 31/03/2021 14:54:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- Procedimiento almacenado de actualizar
CREATE PROCEDURE [dbo].[usp_Reserva_U]
	@pid_reserva int,
	@pfecha date,
	@phora_inicio time,
	@phora_fin time,
	@pid_cliente int
as
begin
	begin tran
		begin try
			update Reserva
				set
					fecha=@pfecha,
					hora_inicio=@phora_inicio,
					hora_fin=@phora_fin,
					id_cliente=@pid_cliente

			Where id_reserva=@pid_reserva
	commit
		end try
		begin catch
			rollback
		end catch
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Tipo_comida_D]    Script Date: 31/03/2021 14:54:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


--Procedimiento almacenado de Eliminar
CREATE PROCEDURE [dbo].[usp_Tipo_comida_D]
	@pid_tipo_comida int
as
begin
	begin tran
		begin try
			DELETE Tipo_comida
			Where id_tipo_comida=@pid_tipo_comida
	commit
		end try
		begin catch
			rollback
		end catch
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Tipo_comida_I]    Script Date: 31/03/2021 14:54:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Creación de Procedimientos Almacenados 
-- ERICKA MARTINEZ YUFRA 29 DIC 2020

------------------------------------------------------------------
--------------------- TIPO_COMIDA --------------------------------
------------------------------------------------------------------

-- Procedimiento almacenado de insertar
CREATE PROCEDURE [dbo].[usp_Tipo_comida_I]
	@pnombre varchar(35)
as
begin
	begin tran
		begin try
			insert into Tipo_comida
			values(@pnombre)
	commit
		end try
		begin catch
			rollback
		end catch
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Tipo_comida_S]    Script Date: 31/03/2021 14:54:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Procedimiento almacenado de Listar
CREATE PROCEDURE [dbo].[usp_Tipo_comida_S]
as
begin
	select * from Tipo_comida
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Tipo_comida_S_Buscar]    Script Date: 31/03/2021 14:54:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Procedimiento almacenado de Buscar
CREATE PROCEDURE [dbo].[usp_Tipo_comida_S_Buscar]
	@pbusqueda varchar(150)
as
begin
	select id_tipo_comida,nombre
	from Tipo_comida
	where nombre like '%'+@pbusqueda+'%'
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Tipo_comida_U]    Script Date: 31/03/2021 14:54:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Procedimiento almacenado de actualizar
CREATE PROCEDURE [dbo].[usp_Tipo_comida_U]
	@pid_tipo_comida int,
	@pnombre varchar(35)
as
begin
	begin tran
		begin try
			update Tipo_comida
				set
					nombre=@pnombre

			Where id_tipo_comida=@pid_tipo_comida
	commit
		end try
		begin catch
			rollback
		end catch
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Tipo_comida_Ventas]    Script Date: 31/03/2021 14:54:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Tipo_comida_Ventas]
as
begin
	select tc.nombre as 'Nombre', sum(c.precio*pc.cantidad) as 'Venta total'
	from Tipo_comida as tc
	inner join Comida as c
		on tc.id_tipo_comida=c.id_tipo_comida
	inner join Pedido_comida as pc
		on pc.id_comida=c.id_comida
	group by tc.nombre
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Tipo_comida_Verificar]    Script Date: 31/03/2021 14:54:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Procedimiento almacenado de Verificar
CREATE PROCEDURE [dbo].[usp_Tipo_comida_Verificar]
	@pvalor varchar(100),
	@existe bit output
as
begin
	begin tran
		begin try
			if EXISTS (select nombre from Tipo_comida
				where nombre=LTRIM(rtrim(@pvalor)))
				begin
					set @existe=1
				end
			else
				begin
					set @existe=0
				end
	commit
		end try
		begin catch
			rollback
		end catch
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Tipo_medida_D]    Script Date: 31/03/2021 14:54:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


--Procedimiento almacenado de Eliminar
CREATE PROCEDURE [dbo].[usp_Tipo_medida_D]
	@pid_tipo_medida int
as
begin
	begin tran
		begin try
			DELETE Tipo_medida
			Where id_tipo_medida=@pid_tipo_medida
	commit
		end try
		begin catch
			rollback
		end catch
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Tipo_medida_I]    Script Date: 31/03/2021 14:54:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Creación de Procedimientos Almacenados 
-- ERICKA MARTINEZ YUFRA 29 DIC 2020

------------------------------------------------------------------
--------------------- TIPO_MEDIDA --------------------------------
------------------------------------------------------------------

-- Procedimiento almacenado de insertar
CREATE PROCEDURE [dbo].[usp_Tipo_medida_I]
	@pnombre varchar(35)
as
begin
	begin tran
		begin try
			insert into Tipo_medida
			values(@pnombre)
	commit
		end try
		begin catch
			rollback
		end catch
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Tipo_medida_S]    Script Date: 31/03/2021 14:54:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Procedimiento almacenado de Listar
CREATE PROCEDURE [dbo].[usp_Tipo_medida_S]
as
begin
	select * from Tipo_medida
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Tipo_medida_S_Buscar]    Script Date: 31/03/2021 14:54:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Procedimiento almacenado de Buscar
CREATE PROCEDURE [dbo].[usp_Tipo_medida_S_Buscar]
	@pbusqueda varchar(150)
as
begin
	select id_tipo_medida,nombre
	from Tipo_medida
	where nombre like '%'+@pbusqueda+'%'
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Tipo_medida_U]    Script Date: 31/03/2021 14:54:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Procedimiento almacenado de actualizar
CREATE PROCEDURE [dbo].[usp_Tipo_medida_U]
	@pid_tipo_medida int,
	@pnombre varchar(35)
as
begin
	begin tran
		begin try
			update Tipo_medida
				set
					nombre=@pnombre

			Where id_tipo_medida=@pid_tipo_medida
	commit
		end try
		begin catch
			rollback
		end catch
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Tipo_medida_Verificar]    Script Date: 31/03/2021 14:54:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Procedimiento almacenado de Verificar
CREATE PROCEDURE [dbo].[usp_Tipo_medida_Verificar]
	@pvalor varchar(100),
	@existe bit output
as
begin
	begin tran
		begin try
			if EXISTS (select nombre from Tipo_medida
				where nombre=LTRIM(rtrim(@pvalor)))
				begin
					set @existe=1
				end
			else
				begin
					set @existe=0
				end
	commit
		end try
		begin catch
			rollback
		end catch
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Tipo_producto_D]    Script Date: 31/03/2021 14:54:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


--Procedimiento almacenado de Eliminar
CREATE PROCEDURE [dbo].[usp_Tipo_producto_D]
	@pid_tipo_producto int
as
begin
	begin tran
		begin try
			DELETE Tipo_producto
			Where id_tipo_producto=@pid_tipo_producto
	commit
		end try
		begin catch
			rollback
		end catch
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Tipo_producto_I]    Script Date: 31/03/2021 14:54:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Creación de Procedimientos Almacenados 
-- ERICKA MARTINEZ YUFRA 29 DIC 2020

------------------------------------------------------------------
-------------------- TIPO_PRODUCTO -------------------------------
------------------------------------------------------------------

-- Procedimiento almacenado de insertar
CREATE PROCEDURE [dbo].[usp_Tipo_producto_I]
	@pnombre varchar(35)
as
begin
	begin tran
		begin try
			insert into Tipo_producto
			values(@pnombre)
	commit
		end try
		begin catch
			rollback
		end catch
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Tipo_producto_S]    Script Date: 31/03/2021 14:54:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Procedimiento almacenado de Listar
CREATE PROCEDURE [dbo].[usp_Tipo_producto_S]
as
begin
	select * from Tipo_producto
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Tipo_producto_S_Buscar]    Script Date: 31/03/2021 14:54:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Procedimiento almacenado de Buscar
CREATE PROCEDURE [dbo].[usp_Tipo_producto_S_Buscar]
	@pbusqueda varchar(150)
as
begin
	select id_tipo_producto,nombre
	from Tipo_producto
	where nombre like '%'+@pbusqueda+'%'
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Tipo_producto_U]    Script Date: 31/03/2021 14:54:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Procedimiento almacenado de actualizar
CREATE PROCEDURE [dbo].[usp_Tipo_producto_U]
	@pid_tipo_producto int,
	@pnombre varchar(35)
as
begin
	begin tran
		begin try
			update Tipo_producto
				set
					nombre=@pnombre

			Where id_tipo_producto=@pid_tipo_producto
	commit
		end try
		begin catch
			rollback
		end catch
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Tipo_producto_Verificar]    Script Date: 31/03/2021 14:54:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Procedimiento almacenado de Verificar
CREATE PROCEDURE [dbo].[usp_Tipo_producto_Verificar]
	@pvalor varchar(100),
	@existe bit output
as
begin
	begin tran
		begin try
			if EXISTS (select nombre from Tipo_producto
				where nombre=LTRIM(rtrim(@pvalor)))
				begin
					set @existe=1
				end
			else
				begin
					set @existe=0
				end
	commit
		end try
		begin catch
			rollback
		end catch
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Usuario_Activar]    Script Date: 31/03/2021 14:54:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


--Procedimiento almacenado de activar
CREATE PROCEDURE  [dbo].[usp_Usuario_Activar]
	@pid_usuario int
as
begin
	begin tran
		begin try
			update Usuario
				set
					estado=1
			Where id_usuario=@pid_usuario
	commit
		end try
		begin catch
			rollback
		end catch
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Usuario_D]    Script Date: 31/03/2021 14:54:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


--Procedimiento almacenado de Eliminar
CREATE PROCEDURE [dbo].[usp_Usuario_D]
	@pid_usuario int
as
begin
	begin tran
		begin try
			DELETE Usuario 
			Where id_usuario=@pid_usuario
	commit
		end try
		begin catch
			rollback
		end catch
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Usuario_Desactivar]    Script Date: 31/03/2021 14:54:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Procedimiento almacenado de desactivar
CREATE PROCEDURE [dbo].[usp_Usuario_Desactivar]
	@pid_usuario int
as
begin
	begin tran
		begin try
			update Usuario 
				set
					estado=0
			Where id_usuario=@pid_usuario
	commit
		end try
		begin catch
			rollback
		end catch
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Usuario_I]    Script Date: 31/03/2021 14:54:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Creación de Procedimientos Almacenados 
-- ERICKA MARTINEZ YUFRA 27 DIC 2020

------------------------------------------------------------------
----------------------- USUARIO ----------------------------------
------------------------------------------------------------------

-- Procedimiento almacenado de insertar
CREATE PROCEDURE [dbo].[usp_Usuario_I]
	@pusuario varchar(50),
	@pcontrasena varchar(30),
	@prol varchar(30),
	@pestado bit,
	@pid_empleado int
as
begin
	begin tran
		begin try
			insert into Usuario
			values(@pusuario,@pcontrasena,@prol,@pestado,@pid_empleado)
	commit
		end try
		begin catch
			rollback
		end catch
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Usuario_S]    Script Date: 31/03/2021 14:54:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Procedimiento almacenado de Listar
CREATE PROCEDURE [dbo].[usp_Usuario_S]
as
begin
	select u.id_usuario,u.usuario,u.contrasena,u.rol,u.estado,e.nombres,e.apellidos,e.id_empleado
	from Usuario as u
	inner join Empleado as e
	on e.id_empleado=u.id_empleado
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Usuario_S_Buscar]    Script Date: 31/03/2021 14:54:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


--Procedimiento almacenado de Buscar
CREATE PROCEDURE [dbo].[usp_Usuario_S_Buscar]
	@pbusqueda varchar(150)
as
begin
	select u.id_usuario,u.usuario,u.contrasena,u.rol,u.estado,e.nombres,e.apellidos
	from Usuario as u
	inner join Empleado as e
	on e.id_empleado=u.id_empleado
	where u.usuario like '%'+@pbusqueda+'%'
	or e.nombres like '%'+@pbusqueda+'%'
	or e.apellidos like '%'+@pbusqueda+'%'
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Usuario_U]    Script Date: 31/03/2021 14:54:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Procedimiento almacenado de actualizar
CREATE PROCEDURE [dbo].[usp_Usuario_U]
	@pid_usuario int,
	@pusuario varchar(50),
	@pcontrasena varchar(30),
	@prol varchar(30),
	@pestado bit,
	@pid_empleado int
as
begin
	begin tran
		begin try
			update Usuario
				set
					usuario=@pusuario,
					contrasena=@pcontrasena,
					rol=@prol,
					estado=@pestado,
					id_empleado=@pid_empleado
			Where id_usuario=@pid_usuario
	commit
		end try
		begin catch
			rollback
		end catch
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Usuario_Verificar]    Script Date: 31/03/2021 14:54:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


--Procedimiento almacenado de Verificar
CREATE PROCEDURE [dbo].[usp_Usuario_Verificar]
	@pvalor varchar(100),
	@existe bit output
as
begin
	begin tran
		begin try
			if EXISTS (select usuario from Usuario
				where usuario=LTRIM(rtrim(@pvalor)))
				begin
					set @existe=1
				end
			else
				begin
					set @existe=0
				end

	commit
		end try
		begin catch
			rollback
		end catch
	end
GO
USE [master]
GO
ALTER DATABASE [BAE_Restaurante] SET  READ_WRITE 
GO
