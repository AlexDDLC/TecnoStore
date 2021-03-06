USE [master]
GO
/****** Object:  Database [TecnoStore]    Script Date: 22/8/2020 3:13:06 p. m. ******/
CREATE DATABASE [TecnoStore]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TecnoStore', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\TecnoStore.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TecnoStore_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\TecnoStore_log.ldf' , SIZE = 73728KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [TecnoStore] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TecnoStore].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TecnoStore] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TecnoStore] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TecnoStore] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TecnoStore] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TecnoStore] SET ARITHABORT OFF 
GO
ALTER DATABASE [TecnoStore] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TecnoStore] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TecnoStore] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TecnoStore] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TecnoStore] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TecnoStore] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TecnoStore] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TecnoStore] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TecnoStore] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TecnoStore] SET  ENABLE_BROKER 
GO
ALTER DATABASE [TecnoStore] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TecnoStore] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TecnoStore] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TecnoStore] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TecnoStore] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TecnoStore] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TecnoStore] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TecnoStore] SET RECOVERY FULL 
GO
ALTER DATABASE [TecnoStore] SET  MULTI_USER 
GO
ALTER DATABASE [TecnoStore] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TecnoStore] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TecnoStore] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TecnoStore] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TecnoStore] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'TecnoStore', N'ON'
GO
ALTER DATABASE [TecnoStore] SET QUERY_STORE = OFF
GO
USE [TecnoStore]
GO
/****** Object:  Table [dbo].[TablaCargo]    Script Date: 22/8/2020 3:13:06 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TablaCargo](
	[IDCargo] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDCargo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TablaCategoria]    Script Date: 22/8/2020 3:13:06 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TablaCategoria](
	[ID_Categoria] [int] IDENTITY(1,1) NOT NULL,
	[Categorias] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Categoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TablaCliente]    Script Date: 22/8/2020 3:13:06 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TablaCliente](
	[IDCliente] [int] IDENTITY(1,1) NOT NULL,
	[Cedula] [char](11) NOT NULL,
	[Nombres] [varchar](50) NOT NULL,
	[Apellidos] [varchar](50) NOT NULL,
	[Direccion] [varchar](100) NOT NULL,
	[Telefono] [varchar](11) NULL,
PRIMARY KEY CLUSTERED 
(
	[IDCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TablaDetalleVenta]    Script Date: 22/8/2020 3:13:06 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TablaDetalleVenta](
	[IDDetalleVenta] [int] IDENTITY(1,1) NOT NULL,
	[IDProducto] [int] NOT NULL,
	[IDVenta] [int] NOT NULL,
	[Cantidad] [int] NOT NULL,
	[PrecioUnitario] [decimal](6, 2) NOT NULL,
	[ITBIS] [money] NOT NULL,
	[SubTotal] [money] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDDetalleVenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TablaEmpleado]    Script Date: 22/8/2020 3:13:06 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TablaEmpleado](
	[IDEmpleado] [int] IDENTITY(1,1) NOT NULL,
	[IDCargo] [int] NOT NULL,
	[Cedula] [char](11) NOT NULL,
	[Nombres] [varchar](30) NOT NULL,
	[Apellidos] [varchar](30) NOT NULL,
	[Sexo] [char](1) NOT NULL,
	[FechaNacimiento] [date] NOT NULL,
	[Direccion] [varchar](80) NOT NULL,
	[EstadoCivil] [char](1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDEmpleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TablaMarca]    Script Date: 22/8/2020 3:13:06 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TablaMarca](
	[ID_Marca] [int] IDENTITY(1,1) NOT NULL,
	[Marca] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Marca] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TablaProducto]    Script Date: 22/8/2020 3:13:06 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TablaProducto](
	[IDproducto] [int] IDENTITY(1,1) NOT NULL,
	[IDCategoria] [int] NOT NULL,
	[Marca] [varchar](50) NOT NULL,
	[Modelo] [varchar](80) NULL,
	[Stock] [int] NOT NULL,
	[PrecioCompra] [int] NOT NULL,
	[PrecioVenta] [int] NOT NULL,
 CONSTRAINT [PK__TablaPro__A543D3ED87289D9B] PRIMARY KEY CLUSTERED 
(
	[IDproducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TablaProducto2]    Script Date: 22/8/2020 3:13:06 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TablaProducto2](
	[ID_Producto] [int] IDENTITY(1,1) NOT NULL,
	[ID_Categoria] [int] NULL,
	[ID_Marca] [int] NULL,
	[Modelo] [varchar](20) NULL,
	[Descripcion] [varchar](200) NULL,
	[Stock] [int] NULL,
	[PrecioCompra] [float] NULL,
	[PrecioVenta] [float] NULL,
 CONSTRAINT [PK__TablaPro__9B4120E242AF16B5] PRIMARY KEY CLUSTERED 
(
	[ID_Producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TablaUsuario]    Script Date: 22/8/2020 3:13:06 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TablaUsuario](
	[IDUsuario] [int] IDENTITY(1,1) NOT NULL,
	[IDEmpleado] [int] NOT NULL,
	[Usuario] [varchar](20) NOT NULL,
	[Contraseña] [varchar](20) NOT NULL,
	[Cargo] [varchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[IDUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TablaVenta]    Script Date: 22/8/2020 3:13:06 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TablaVenta](
	[IDVenta] [int] IDENTITY(1,1) NOT NULL,
	[IDEmpleado] [int] NOT NULL,
	[IDCliente] [int] NOT NULL,
	[Serie] [char](5) NOT NULL,
	[NumeroDocumento] [char](7) NOT NULL,
	[TipoDocumento] [varchar](11) NULL,
	[FechaVenta] [date] NOT NULL,
	[Total] [money] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDVenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[TablaCargo] ON 

INSERT [dbo].[TablaCargo] ([IDCargo], [Descripcion]) VALUES (1, N'Administrador')
INSERT [dbo].[TablaCargo] ([IDCargo], [Descripcion]) VALUES (2, N'Usuario')
SET IDENTITY_INSERT [dbo].[TablaCargo] OFF
GO
SET IDENTITY_INSERT [dbo].[TablaCategoria] ON 

INSERT [dbo].[TablaCategoria] ([ID_Categoria], [Categorias]) VALUES (1, N'Desktop')
INSERT [dbo].[TablaCategoria] ([ID_Categoria], [Categorias]) VALUES (2, N'LapTop')
INSERT [dbo].[TablaCategoria] ([ID_Categoria], [Categorias]) VALUES (3, N'Tablets')
INSERT [dbo].[TablaCategoria] ([ID_Categoria], [Categorias]) VALUES (4, N'Bocinas')
INSERT [dbo].[TablaCategoria] ([ID_Categoria], [Categorias]) VALUES (5, N'Mouse')
INSERT [dbo].[TablaCategoria] ([ID_Categoria], [Categorias]) VALUES (6, N'Teclado')
INSERT [dbo].[TablaCategoria] ([ID_Categoria], [Categorias]) VALUES (7, N'Pantalla')
INSERT [dbo].[TablaCategoria] ([ID_Categoria], [Categorias]) VALUES (8, N'Consolas')
INSERT [dbo].[TablaCategoria] ([ID_Categoria], [Categorias]) VALUES (9, N'Juegos de consola')
INSERT [dbo].[TablaCategoria] ([ID_Categoria], [Categorias]) VALUES (10, N'Partes de consolas')
INSERT [dbo].[TablaCategoria] ([ID_Categoria], [Categorias]) VALUES (11, N'Piezas para Desktop')
INSERT [dbo].[TablaCategoria] ([ID_Categoria], [Categorias]) VALUES (12, N'Piezas para laptop')
SET IDENTITY_INSERT [dbo].[TablaCategoria] OFF
GO
SET IDENTITY_INSERT [dbo].[TablaCliente] ON 

INSERT [dbo].[TablaCliente] ([IDCliente], [Cedula], [Nombres], [Apellidos], [Direccion], [Telefono]) VALUES (1, N'80975389567', N'Juan Manuel', N'Vásquez Ventura', N'Urb. Mirasol', N'8097569000')
SET IDENTITY_INSERT [dbo].[TablaCliente] OFF
GO
SET IDENTITY_INSERT [dbo].[TablaEmpleado] ON 

INSERT [dbo].[TablaEmpleado] ([IDEmpleado], [IDCargo], [Cedula], [Nombres], [Apellidos], [Sexo], [FechaNacimiento], [Direccion], [EstadoCivil]) VALUES (1, 1, N'34004387   ', N'Nelson Alexander', N'Diaz De La Cruz', N'M', CAST(N'1996-09-13' AS Date), N'El Eden de Villa Mella', N'S')
INSERT [dbo].[TablaEmpleado] ([IDEmpleado], [IDCargo], [Cedula], [Nombres], [Apellidos], [Sexo], [FechaNacimiento], [Direccion], [EstadoCivil]) VALUES (2, 2, N'34004387   ', N'Genesis Marlenis', N'Bido Rodriguez', N'F', CAST(N'1996-06-11' AS Date), N'Mirador Isabela', N'S')
SET IDENTITY_INSERT [dbo].[TablaEmpleado] OFF
GO
SET IDENTITY_INSERT [dbo].[TablaMarca] ON 

INSERT [dbo].[TablaMarca] ([ID_Marca], [Marca]) VALUES (1, N'Lexus')
INSERT [dbo].[TablaMarca] ([ID_Marca], [Marca]) VALUES (2, N'HP')
INSERT [dbo].[TablaMarca] ([ID_Marca], [Marca]) VALUES (3, N'LG')
INSERT [dbo].[TablaMarca] ([ID_Marca], [Marca]) VALUES (4, N'Samsung')
INSERT [dbo].[TablaMarca] ([ID_Marca], [Marca]) VALUES (5, N'Lenovo')
INSERT [dbo].[TablaMarca] ([ID_Marca], [Marca]) VALUES (6, N'Asus')
INSERT [dbo].[TablaMarca] ([ID_Marca], [Marca]) VALUES (7, N'Dell')
INSERT [dbo].[TablaMarca] ([ID_Marca], [Marca]) VALUES (8, N'MSI')
INSERT [dbo].[TablaMarca] ([ID_Marca], [Marca]) VALUES (9, N'Epson')
INSERT [dbo].[TablaMarca] ([ID_Marca], [Marca]) VALUES (10, N'Nvidia')
SET IDENTITY_INSERT [dbo].[TablaMarca] OFF
GO
SET IDENTITY_INSERT [dbo].[TablaProducto] ON 

INSERT [dbo].[TablaProducto] ([IDproducto], [IDCategoria], [Marca], [Modelo], [Stock], [PrecioCompra], [PrecioVenta]) VALUES (1, 1, N'TOYOTA', N'RAV4', 1, 25000, 35000)
INSERT [dbo].[TablaProducto] ([IDproducto], [IDCategoria], [Marca], [Modelo], [Stock], [PrecioCompra], [PrecioVenta]) VALUES (2, 5, N'LEXUX', N'LX570', 1, 90000, 125000)
INSERT [dbo].[TablaProducto] ([IDproducto], [IDCategoria], [Marca], [Modelo], [Stock], [PrecioCompra], [PrecioVenta]) VALUES (4, 5, N'JUJU', N'djh52', 25, 442, 588)
SET IDENTITY_INSERT [dbo].[TablaProducto] OFF
GO
SET IDENTITY_INSERT [dbo].[TablaProducto2] ON 

INSERT [dbo].[TablaProducto2] ([ID_Producto], [ID_Categoria], [ID_Marca], [Modelo], [Descripcion], [Stock], [PrecioCompra], [PrecioVenta]) VALUES (1, 4, 6, N'lol', N'Laptop core i5', 50, 4500, 5000)
INSERT [dbo].[TablaProducto2] ([ID_Producto], [ID_Categoria], [ID_Marca], [Modelo], [Descripcion], [Stock], [PrecioCompra], [PrecioVenta]) VALUES (2, 7, 2, N'ala', N'ubsbcbbusb', 25, 25, 50)
INSERT [dbo].[TablaProducto2] ([ID_Producto], [ID_Categoria], [ID_Marca], [Modelo], [Descripcion], [Stock], [PrecioCompra], [PrecioVenta]) VALUES (4, 7, 2, N'PH2', N'16'''' 1080p', 30, 1500, 3500)
INSERT [dbo].[TablaProducto2] ([ID_Producto], [ID_Categoria], [ID_Marca], [Modelo], [Descripcion], [Stock], [PrecioCompra], [PrecioVenta]) VALUES (5, 7, 9, N'elo', N'Laser', 14, 230, 400)
INSERT [dbo].[TablaProducto2] ([ID_Producto], [ID_Categoria], [ID_Marca], [Modelo], [Descripcion], [Stock], [PrecioCompra], [PrecioVenta]) VALUES (6, 1, 1, N'eva', N'Limited', 2, 2500, 6000)
INSERT [dbo].[TablaProducto2] ([ID_Producto], [ID_Categoria], [ID_Marca], [Modelo], [Descripcion], [Stock], [PrecioCompra], [PrecioVenta]) VALUES (7, 4, 6, N'kk', N'i5 4 nucleos', 18, 25000, 35000)
INSERT [dbo].[TablaProducto2] ([ID_Producto], [ID_Categoria], [ID_Marca], [Modelo], [Descripcion], [Stock], [PrecioCompra], [PrecioVenta]) VALUES (9, 2, 2, N'JJ', N'16'''' 1080p', 25, 3500, 6500)
INSERT [dbo].[TablaProducto2] ([ID_Producto], [ID_Categoria], [ID_Marca], [Modelo], [Descripcion], [Stock], [PrecioCompra], [PrecioVenta]) VALUES (1008, 2, 7, N'Inspiron', N'16"', 25, 15000, 20000)
INSERT [dbo].[TablaProducto2] ([ID_Producto], [ID_Categoria], [ID_Marca], [Modelo], [Descripcion], [Stock], [PrecioCompra], [PrecioVenta]) VALUES (1009, 8, 4, N'x263', N'64GB', 20, 5000, 10000)
INSERT [dbo].[TablaProducto2] ([ID_Producto], [ID_Categoria], [ID_Marca], [Modelo], [Descripcion], [Stock], [PrecioCompra], [PrecioVenta]) VALUES (1010, 7, 2, N'DX', N'16" 1080P', 25, 1500, 5000)
SET IDENTITY_INSERT [dbo].[TablaProducto2] OFF
GO
SET IDENTITY_INSERT [dbo].[TablaUsuario] ON 

INSERT [dbo].[TablaUsuario] ([IDUsuario], [IDEmpleado], [Usuario], [Contraseña], [Cargo]) VALUES (1, 1, N'A', N'123', N'Administrador')
INSERT [dbo].[TablaUsuario] ([IDUsuario], [IDEmpleado], [Usuario], [Contraseña], [Cargo]) VALUES (2, 2, N'E', N'147', N'Caja')
SET IDENTITY_INSERT [dbo].[TablaUsuario] OFF
GO
ALTER TABLE [dbo].[TablaDetalleVenta]  WITH CHECK ADD  CONSTRAINT [FK__TablaDeta__IDPro__47DBAE45] FOREIGN KEY([IDProducto])
REFERENCES [dbo].[TablaProducto] ([IDproducto])
GO
ALTER TABLE [dbo].[TablaDetalleVenta] CHECK CONSTRAINT [FK__TablaDeta__IDPro__47DBAE45]
GO
ALTER TABLE [dbo].[TablaDetalleVenta]  WITH CHECK ADD FOREIGN KEY([IDVenta])
REFERENCES [dbo].[TablaVenta] ([IDVenta])
GO
ALTER TABLE [dbo].[TablaEmpleado]  WITH CHECK ADD FOREIGN KEY([IDCargo])
REFERENCES [dbo].[TablaCargo] ([IDCargo])
GO
ALTER TABLE [dbo].[TablaProducto]  WITH CHECK ADD  CONSTRAINT [FK__TablaProd__IDCat__398D8EEE] FOREIGN KEY([IDCategoria])
REFERENCES [dbo].[TablaCategoria] ([ID_Categoria])
GO
ALTER TABLE [dbo].[TablaProducto] CHECK CONSTRAINT [FK__TablaProd__IDCat__398D8EEE]
GO
ALTER TABLE [dbo].[TablaProducto2]  WITH CHECK ADD  CONSTRAINT [relacion_a_categoria] FOREIGN KEY([ID_Categoria])
REFERENCES [dbo].[TablaCategoria] ([ID_Categoria])
GO
ALTER TABLE [dbo].[TablaProducto2] CHECK CONSTRAINT [relacion_a_categoria]
GO
ALTER TABLE [dbo].[TablaProducto2]  WITH CHECK ADD  CONSTRAINT [relacion_a_marca] FOREIGN KEY([ID_Marca])
REFERENCES [dbo].[TablaMarca] ([ID_Marca])
GO
ALTER TABLE [dbo].[TablaProducto2] CHECK CONSTRAINT [relacion_a_marca]
GO
ALTER TABLE [dbo].[TablaUsuario]  WITH CHECK ADD FOREIGN KEY([IDEmpleado])
REFERENCES [dbo].[TablaEmpleado] ([IDEmpleado])
GO
ALTER TABLE [dbo].[TablaVenta]  WITH CHECK ADD FOREIGN KEY([IDCliente])
REFERENCES [dbo].[TablaCliente] ([IDCliente])
GO
ALTER TABLE [dbo].[TablaVenta]  WITH CHECK ADD FOREIGN KEY([IDEmpleado])
REFERENCES [dbo].[TablaEmpleado] ([IDEmpleado])
GO
ALTER TABLE [dbo].[TablaVenta]  WITH CHECK ADD CHECK  (([TipoDocumento]='Factura' OR [TipoDocumento]='Comprobante'))
GO
/****** Object:  StoredProcedure [dbo].[EP_EDITAR_PRODUCTO]    Script Date: 22/8/2020 3:13:06 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EP_EDITAR_PRODUCTO]
@ID_CATEGORIA int,
@ID_MARCA int,
@MODELO VARCHAR(20),
@DESCRIPCION varchar(200),
@STOCK INT,
@PRECIO_COMPRA float,
@PRECIO_VENTA FLOAT,
@ID_PRODUCTO INT
AS
UPDATE TablaProducto2 SET ID_Categoria = @ID_CATEGORIA, ID_Marca = @ID_MARCA, Modelo = @MODELO, Descripcion = @DESCRIPCION, 
Stock = @STOCK, PrecioCompra = @PRECIO_COMPRA, PrecioVenta = @PRECIO_VENTA  WHERE ID_producto = @ID_Producto
GO
/****** Object:  StoredProcedure [dbo].[EP_ELIMINAR_PRODUCTO]    Script Date: 22/8/2020 3:13:06 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EP_ELIMINAR_PRODUCTO]
@ID_Producto int
AS
DELETE FROM TablaProducto2 WHERE ID_Producto = @ID_Producto
GO
/****** Object:  StoredProcedure [dbo].[EP_INSERTAR_CLIENTE]    Script Date: 22/8/2020 3:13:06 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EP_INSERTAR_CLIENTE]
@CEDURA_CLIENTE VARCHAR(11),
@Nombre_CLIENTE VARCHAR(50),
@APELLIDO_CLIENTE VARCHAR(50),
@DIRECCION_CLIENTE VARCHAR(100),
@TELEFONO_CLIENTE VARCHAR(11)
AS
INSERT INTO TablaCliente VALUES(@CEDURA_CLIENTE, @Nombre_CLIENTE,@APELLIDO_CLIENTE,@DIRECCION_CLIENTE,@TELEFONO_CLIENTE)
GO
/****** Object:  StoredProcedure [dbo].[EP_INSERTAR_PRODUCTOS]    Script Date: 22/8/2020 3:13:06 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[EP_INSERTAR_PRODUCTOS]
@ID_CATEGORIA int,
@ID_MARCA int,
@MODELO VARCHAR(20),
@DESCRIPCION varchar(200),
@STOCK INT,
@PRECIO_COMPRA float,
@PRECIO_VENTA FLOAT 
as
insert into TablaProducto2 values(@ID_CATEGORIA,@ID_MARCA,@MODELO,@DESCRIPCION,@STOCK,@PRECIO_COMPRA,@PRECIO_VENTA)
GO
/****** Object:  StoredProcedure [dbo].[EP_LISTAR_CATEGORIA]    Script Date: 22/8/2020 3:13:06 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EP_LISTAR_CATEGORIA]
AS
SELECT * FROM TablaCategoria ORDER BY Categorias ASC 
GO
/****** Object:  StoredProcedure [dbo].[EP_LISTAR_MARCA]    Script Date: 22/8/2020 3:13:06 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[EP_LISTAR_MARCA]
as
select * from TablaMarca order by Marca asc
GO
/****** Object:  StoredProcedure [dbo].[EP_LOGUEAR_USUARIO]    Script Date: 22/8/2020 3:13:06 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EP_LOGUEAR_USUARIO]
@Usuario VARCHAR(20), @Contrasena VARCHAR(12) 
AS SELECT * FROM TablaUsuario WHERE Usuario = @Usuario AND Contraseña = @Contrasena; 
GO
/****** Object:  StoredProcedure [dbo].[EP_MOSTRA_PRODUCTOS_ADMI]    Script Date: 22/8/2020 3:13:06 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EP_MOSTRA_PRODUCTOS_ADMI]
as
select P.ID_Producto, C.Categorias, M.Marca, P.Modelo, P.Descripcion, P.Stock, P.PrecioCompra, P.PrecioVenta
FROM TablaProducto2 P 
INNER JOIN TablaCategoria C ON P.ID_Categoria = C.ID_Categoria 
INNER JOIN TablaMarca M ON P.ID_Marca = M.ID_Marca 
GO
/****** Object:  StoredProcedure [dbo].[EP_MOSTRAR_CLIENTE]    Script Date: 22/8/2020 3:13:06 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EP_MOSTRAR_CLIENTE]
AS
SELECT * FROM TablaCliente
GO
/****** Object:  StoredProcedure [dbo].[EP_MOSTRAR_PRODUCTOS_CAJ]    Script Date: 22/8/2020 3:13:06 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EP_MOSTRAR_PRODUCTOS_CAJ]
as
select P.ID_Producto, C.Categorias, M.Marca, P.Modelo, P.Descripcion, P.Stock, P.PrecioVenta
FROM TablaProducto2 P 
INNER JOIN TablaCategoria C ON P.ID_Categoria = C.ID_Categoria 
INNER JOIN TablaMarca M ON P.ID_Marca = M.ID_Marca 
GO
USE [master]
GO
ALTER DATABASE [TecnoStore] SET  READ_WRITE 
GO
