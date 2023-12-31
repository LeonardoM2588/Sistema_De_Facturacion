USE [master]
GO
/****** Object:  Database [sistema_facturacion]    Script Date: 26/12/2023 20:57:59 ******/
CREATE DATABASE [sistema_facturacion]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'sistema_facturacion', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\sistema_facturacion.mdf' , SIZE = 4288KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'sistema_facturacion_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\sistema_facturacion_log.ldf' , SIZE = 1072KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [sistema_facturacion] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [sistema_facturacion].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [sistema_facturacion] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [sistema_facturacion] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [sistema_facturacion] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [sistema_facturacion] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [sistema_facturacion] SET ARITHABORT OFF 
GO
ALTER DATABASE [sistema_facturacion] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [sistema_facturacion] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [sistema_facturacion] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [sistema_facturacion] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [sistema_facturacion] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [sistema_facturacion] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [sistema_facturacion] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [sistema_facturacion] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [sistema_facturacion] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [sistema_facturacion] SET  ENABLE_BROKER 
GO
ALTER DATABASE [sistema_facturacion] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [sistema_facturacion] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [sistema_facturacion] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [sistema_facturacion] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [sistema_facturacion] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [sistema_facturacion] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [sistema_facturacion] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [sistema_facturacion] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [sistema_facturacion] SET  MULTI_USER 
GO
ALTER DATABASE [sistema_facturacion] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [sistema_facturacion] SET DB_CHAINING OFF 
GO
ALTER DATABASE [sistema_facturacion] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [sistema_facturacion] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [sistema_facturacion] SET DELAYED_DURABILITY = DISABLED 
GO
USE [sistema_facturacion]
GO
/****** Object:  Table [dbo].[Cargo]    Script Date: 26/12/2023 20:57:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cargo](
	[Cod_Cargo] [int] NOT NULL,
	[Cargo] [varchar](50) NOT NULL,
	[FechaCreacion] [datetime] NOT NULL,
	[UsuarioCreacion] [varchar](50) NOT NULL,
	[FechaModificacion] [datetime] NULL,
	[UsuarioModificacion] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Cod_Cargo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Empleados]    Script Date: 26/12/2023 20:57:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Empleados](
	[Cod_Empleado] [int] NOT NULL,
	[IdentidadEmpleado] [varchar](50) NOT NULL,
	[Nombre_Empleado] [varchar](150) NOT NULL,
	[Cod_Cargo] [int] NOT NULL,
	[Estado] [bit] NOT NULL,
	[FechaCreacion] [datetime] NOT NULL,
	[UsuarioCreacion] [varchar](50) NOT NULL,
	[FechaModificacion] [datetime] NULL,
	[UsuarioModificacion] [varchar](50) NULL,
 CONSTRAINT [PK__Empleado__18E39329C41C4AC7] PRIMARY KEY CLUSTERED 
(
	[Cod_Empleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Factura]    Script Date: 26/12/2023 20:57:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Factura](
	[IdFactura] [int] NOT NULL,
	[Rtn_Cliente] [varchar](20) NULL,
	[Fecha_Factura] [date] NOT NULL,
	[Cantidad_Total] [varchar](150) NOT NULL,
	[Impuesto_Total] [varchar](150) NOT NULL,
	[Efectivo] [varchar](150) NOT NULL,
	[Devuelto] [varchar](150) NOT NULL,
	[Estado] [bit] NOT NULL,
	[FechaCreacion] [datetime] NOT NULL,
	[UsuarioCreacion] [varchar](50) NOT NULL,
	[FechaModificacion] [datetime] NULL,
	[UsuarioModificacion] [varchar](50) NULL,
 CONSTRAINT [PK__Factura__50E7BAF1C4401929] PRIMARY KEY CLUSTERED 
(
	[IdFactura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Nivel_Acceso]    Script Date: 26/12/2023 20:57:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Nivel_Acceso](
	[IdNivelUser] [int] NOT NULL,
	[Nivel_Acceso] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdNivelUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 26/12/2023 20:57:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Producto](
	[IdProducto] [int] NOT NULL,
	[Producto] [varchar](150) NOT NULL,
	[Precio] [varchar](150) NOT NULL,
	[Estado] [bit] NOT NULL,
 CONSTRAINT [PK__Producto__098892100248F6AA] PRIMARY KEY CLUSTERED 
(
	[IdProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 26/12/2023 20:57:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuarios](
	[Cod_Usuario] [int] NOT NULL,
	[Cod_Empleado] [int] NOT NULL,
	[IdentidadEmpleado] [varchar](50) NOT NULL,
	[Usuario] [varchar](50) NOT NULL,
	[Contrasena] [varchar](250) NOT NULL,
	[IdNivelUser] [int] NOT NULL,
	[Estado] [bit] NOT NULL,
 CONSTRAINT [PK__Usuarios__D16E26A6A6436D9B] PRIMARY KEY CLUSTERED 
(
	[Cod_Usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Cargo] ([Cod_Cargo], [Cargo], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion]) VALUES (1, N'Ing. Sistemas', CAST(N'2023-12-13 00:00:00.000' AS DateTime), N'LeonardoM', NULL, NULL)
INSERT [dbo].[Cargo] ([Cod_Cargo], [Cargo], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion]) VALUES (2, N'Administrador General', CAST(N'2023-12-13 00:00:00.000' AS DateTime), N'LeonardoM', NULL, NULL)
INSERT [dbo].[Empleados] ([Cod_Empleado], [IdentidadEmpleado], [Nombre_Empleado], [Cod_Cargo], [Estado], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion]) VALUES (1, N'1707-2002-00389', N'Leonardo Molina', 1, 0, CAST(N'2023-12-13 00:00:00.000' AS DateTime), N'LeonardoM', CAST(N'2023-12-24 18:01:24.210' AS DateTime), N'')
INSERT [dbo].[Empleados] ([Cod_Empleado], [IdentidadEmpleado], [Nombre_Empleado], [Cod_Cargo], [Estado], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion]) VALUES (2, N'1709-2001-00128', N'Abner Borjas', 2, 1, CAST(N'2023-12-24 18:01:34.740' AS DateTime), N'LeonardoM', NULL, NULL)
INSERT [dbo].[Factura] ([IdFactura], [Rtn_Cliente], [Fecha_Factura], [Cantidad_Total], [Impuesto_Total], [Efectivo], [Devuelto], [Estado], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion]) VALUES (1, NULL, CAST(N'2023-02-15' AS Date), N'0', N'0', N'0', N'0', 0, CAST(N'2023-02-15 00:00:00.000' AS DateTime), N'Emolina', NULL, NULL)
INSERT [dbo].[Factura] ([IdFactura], [Rtn_Cliente], [Fecha_Factura], [Cantidad_Total], [Impuesto_Total], [Efectivo], [Devuelto], [Estado], [FechaCreacion], [UsuarioCreacion], [FechaModificacion], [UsuarioModificacion]) VALUES (2, N'17072002003891', CAST(N'2023-12-26' AS Date), N'460', N'60', N'500', N'40', 1, CAST(N'2023-12-26 19:19:38.493' AS DateTime), N'Emolina', NULL, NULL)
INSERT [dbo].[Nivel_Acceso] ([IdNivelUser], [Nivel_Acceso]) VALUES (1, N'Sistemas')
INSERT [dbo].[Nivel_Acceso] ([IdNivelUser], [Nivel_Acceso]) VALUES (2, N'Administrador')
INSERT [dbo].[Nivel_Acceso] ([IdNivelUser], [Nivel_Acceso]) VALUES (3, N'Caja Principal')
INSERT [dbo].[Nivel_Acceso] ([IdNivelUser], [Nivel_Acceso]) VALUES (4, N'Empleado')
INSERT [dbo].[Producto] ([IdProducto], [Producto], [Precio], [Estado]) VALUES (1, N'Desayunos tipicos', N'75', 1)
INSERT [dbo].[Producto] ([IdProducto], [Producto], [Precio], [Estado]) VALUES (2, N'Enchiladas Orden (2)', N'60', 1)
INSERT [dbo].[Producto] ([IdProducto], [Producto], [Precio], [Estado]) VALUES (3, N'Chilaquiles pollo/Res', N'80', 1)
INSERT [dbo].[Producto] ([IdProducto], [Producto], [Precio], [Estado]) VALUES (4, N'Tortillas De Quesillo', N'60', 1)
INSERT [dbo].[Producto] ([IdProducto], [Producto], [Precio], [Estado]) VALUES (5, N'Tacos Orden (3)  ', N'70', 1)
INSERT [dbo].[Producto] ([IdProducto], [Producto], [Precio], [Estado]) VALUES (6, N'Baleadas Sencillas', N'15', 1)
INSERT [dbo].[Producto] ([IdProducto], [Producto], [Precio], [Estado]) VALUES (7, N'Baleada con todo', N'75', 1)
INSERT [dbo].[Usuarios] ([Cod_Usuario], [Cod_Empleado], [IdentidadEmpleado], [Usuario], [Contrasena], [IdNivelUser], [Estado]) VALUES (1, 1, N'1707-2002-00389', N'Emolina', N'3BmcIOhB35MaKDY05tj6Ge9+9JiKzVW3ywuTi44zTIsHO24qWX1JMPdbAolgZV31hStrFgH1a/5esxvszwZ4jQ==', 1, 1)
INSERT [dbo].[Usuarios] ([Cod_Usuario], [Cod_Empleado], [IdentidadEmpleado], [Usuario], [Contrasena], [IdNivelUser], [Estado]) VALUES (2, 2, N'1709-2001-00128', N'Aborjas', N'3BmcIOhB35MaKDY05tj6Ge9+9JiKzVW3ywuTi44zTIsHO24qWX1JMPdbAolgZV31hStrFgH1a/5esxvszwZ4jQ==', 2, 1)
ALTER TABLE [dbo].[Empleados]  WITH CHECK ADD  CONSTRAINT [FK__Empleados__Cod_C__145C0A3F] FOREIGN KEY([Cod_Cargo])
REFERENCES [dbo].[Cargo] ([Cod_Cargo])
GO
ALTER TABLE [dbo].[Empleados] CHECK CONSTRAINT [FK__Empleados__Cod_C__145C0A3F]
GO
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD  CONSTRAINT [FK__Usuarios__Cod_Em__173876EA] FOREIGN KEY([Cod_Empleado])
REFERENCES [dbo].[Empleados] ([Cod_Empleado])
GO
ALTER TABLE [dbo].[Usuarios] CHECK CONSTRAINT [FK__Usuarios__Cod_Em__173876EA]
GO
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD  CONSTRAINT [FK__Usuarios__IdNive__182C9B23] FOREIGN KEY([IdNivelUser])
REFERENCES [dbo].[Nivel_Acceso] ([IdNivelUser])
GO
ALTER TABLE [dbo].[Usuarios] CHECK CONSTRAINT [FK__Usuarios__IdNive__182C9B23]
GO
/****** Object:  StoredProcedure [dbo].[sp_Empleados]    Script Date: 26/12/2023 20:57:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_Empleados] @Indicador int, @Cod_Empleado as int, @IdentidadEmpleado varchar(50), 
@Nombre_Empleado varchar(150), @Cod_Cargo int, @Estado bit, @UsuarioCreacion varchar(50),
@UsuarioModificacion varchar(50)

as
begin

if @Indicador = 1

begin
insert into dbo.Empleados select isnull((select max(Cod_Empleado) from dbo.Empleados),0)+1,@IdentidadEmpleado,
@Nombre_Empleado,@Cod_Cargo,@Estado,getdate(),@UsuarioCreacion,null,null

end
 if @Indicador = 2
 begin
 update dbo.Empleados set IdentidadEmpleado = @IdentidadEmpleado, Nombre_Empleado = @Nombre_Empleado,
 Cod_Cargo = @Cod_Cargo,Estado = @Estado, UsuarioModificacion = @UsuarioModificacion, 
 FechaModificacion = getdate() 
 where Cod_Empleado = @Cod_Empleado
end
 if @Indicador = 3

 begin 
 delete dbo.Empleados where Cod_Empleado = @Cod_Empleado

 end

  if @Indicador = 4
  begin 
  select Cod_Empleado,IdentidadEmpleado,Nombre_Empleado,Cod_Cargo,Estado,FechaCreacion,
  UsuarioCreacion,FechaModificacion,UsuarioModificacion
   from dbo.Empleados where Estado = @Estado

end
  if @Indicador = 5
  begin
  select Cod_Empleado,IdentidadEmpleado,Nombre_Empleado,Cod_Cargo,Estado,FechaCreacion,
  UsuarioCreacion,FechaModificacion,UsuarioModificacion
   from dbo.Empleados where Cod_Empleado = @Cod_Empleado

end

  if @Indicador = 6
  begin
  select Cod_Empleado,IdentidadEmpleado,Nombre_Empleado,Cargo.Cargo,Estado,Empleados.FechaCreacion,Empleados.UsuarioCreacion,
  Empleados.FechaModificacion,Empleados.UsuarioModificacion
   from dbo.Empleados 
   INNER JOIN Cargo ON Cargo.Cod_Cargo = Empleados.Cod_Cargo
   where Estado = @Estado

end
end
GO
/****** Object:  StoredProcedure [dbo].[sp_EventosUsuario]    Script Date: 26/12/2023 20:57:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_EventosUsuario] @Indicador int, @Cod_Usuario as int, @Cod_Empleado int,@IdentidadEmpleado varchar(50), @Usuario varchar(75), @Contrasena varchar(200), @IdNivelUser int, @Estado bit

as
begin

if @Indicador = 1

begin
insert into dbo.Usuarios select isnull((select max(Cod_Usuario) from dbo.Usuarios),0)+1,@Cod_Empleado,@IdentidadEmpleado,@Usuario,@Contrasena,@IdNivelUser,@Estado

end
 if @Indicador = 2
 begin
 update dbo.Usuarios set Cod_Empleado = @Cod_Empleado,IdentidadEmpleado=@IdentidadEmpleado, Usuario = @Usuario,Contrasena = Contrasena,IdNivelUser = @IdNivelUser,Estado = @Estado where Cod_Usuario = @Cod_Usuario
end
 if @Indicador = 3

 begin 
 delete dbo.Usuarios where Cod_Usuario = @Cod_Usuario

 end

  if @Indicador = 4
  begin 
  select Cod_Usuario,Cod_Empleado,IdentidadEmpleado,Usuario,Contrasena,IdNivelUser,Estado from dbo.Usuarios where Estado = @Estado

end
  if @Indicador = 5
  begin
   select Cod_Usuario,Cod_Empleado,IdentidadEmpleado,Usuario,Contrasena,IdNivelUser,Estado from dbo.Usuarios where Cod_Usuario = @Cod_Usuario

end

  if @Indicador = 6
  begin
   select Cod_Usuario,Empleados.Nombre_Empleado,Empleados.IdentidadEmpleado,Usuario,Contrasena,Nivel_Acceso.Nivel_Acceso,Usuarios.Estado from dbo.Usuarios 
   inner join Empleados on Empleados.Cod_Empleado = Usuarios.Cod_Empleado
   inner join Nivel_Acceso on Nivel_Acceso.IdNivelUser = Usuarios.IdNivelUser

   where Usuarios.Estado = @Estado

end

  if @Indicador = 7
  begin
  select Cod_Usuario,Empleados.Nombre_Empleado,Empleados.IdentidadEmpleado,Usuario,Contrasena,Nivel_Acceso.Nivel_Acceso,Usuarios.Estado from dbo.Usuarios 
   inner join Empleados on Empleados.Cod_Empleado = Usuarios.Cod_Empleado
   inner join Nivel_Acceso on Nivel_Acceso.IdNivelUser = Usuarios.IdNivelUser
   where Usuarios.Estado = @Estado

end
end
GO
/****** Object:  StoredProcedure [dbo].[sp_factura]    Script Date: 26/12/2023 20:57:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_factura] @Indicador int, @IdFactura as int, @Rtn_Cliente varchar(20),@Fecha_Factura datetime, @Cantidad_Total varchar(150),@Impuesto_Total varchar(150),@Efectivo varchar(150),@Devuelto varchar(150), @Estado bit,@UserCreacion varchar(50), @UserModificacion varchar(50)

as
begin

if @Indicador = 1

begin
insert into dbo.Factura select isnull((select max(IdFactura) from dbo.Factura),0)+1,@Rtn_Cliente,@Fecha_Factura,@Cantidad_Total,@Impuesto_Total,@Efectivo,@Devuelto,@Estado,getdate(),@UserCreacion,null,null

end
 if @Indicador = 2
 begin
 update dbo.Factura set Rtn_Cliente = @Rtn_Cliente,Fecha_Factura = @Fecha_Factura, Cantidad_Total = @Cantidad_Total,Impuesto_Total=@Impuesto_Total,Efectivo=@Efectivo,Devuelto=@Devuelto,Estado = @Estado where IdFactura = @IdFactura
end
 if @Indicador = 3

 begin 
 delete dbo.Factura where IdFactura = @IdFactura

 end

  if @Indicador = 4
  begin 
  select IdFactura,Rtn_Cliente,Fecha_Factura,Cantidad_Total,Impuesto_Total,Efectivo,Devuelto,Estado from dbo.Factura where Estado = 1

end
  if @Indicador = 5
  begin
  select IdFactura,Rtn_Cliente,Fecha_Factura,Cantidad_Total,Impuesto_Total,Efectivo,Devuelto,Estado from dbo.Factura where IdFactura = @IdFactura

end

  if @Indicador = 6
  begin
  select IdFactura,Rtn_Cliente,Fecha_Factura,Cantidad_Total,Impuesto_Total,Efectivo,Devuelto,Estado from dbo.Factura

end


  if @Indicador = 7
  begin 
  select IdFactura,Rtn_Cliente,Fecha_Factura,Cantidad_Total,Impuesto_Total,Efectivo,Devuelto,Estado from dbo.Factura where Fecha_Factura = @Fecha_Factura

end

end
GO
/****** Object:  StoredProcedure [dbo].[sp_Producto]    Script Date: 26/12/2023 20:57:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_Producto] @Indicador int, @IdProducto as int, @Producto varchar(75), @Precio int, @Estado bit

as
begin

if @Indicador = 1

begin
insert into dbo.Producto select isnull((select max(IdProducto) from dbo.Producto),0)+1,@Producto,@Precio,@Estado

end
 if @Indicador = 2
 begin
 update dbo.Producto set Producto = @Producto, Precio = @Precio,Estado = @Estado where IdProducto = @IdProducto
end
 if @Indicador = 3

 begin 
 delete dbo.Producto where IdProducto = @IdProducto

 end

  if @Indicador = 4
  begin 
  select IdProducto,Producto,Precio,Estado from dbo.Producto where Estado = @Estado

end
  if @Indicador = 5
  begin
  select IdProducto,Producto,Precio,Estado from dbo.Producto where IdProducto = @IdProducto

end

  if @Indicador = 6
  begin
  select IdProducto,Producto,Precio,Estado from dbo.Producto

end
end
GO
USE [master]
GO
ALTER DATABASE [sistema_facturacion] SET  READ_WRITE 
GO
