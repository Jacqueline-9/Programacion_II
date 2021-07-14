USE [master]
GO
/****** Object:  Database [Punto_Venta_Abarrotes]    Script Date: 14/07/2021 05:09:14 a. m. ******/
CREATE DATABASE [Punto_Venta_Abarrotes]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Punto_Venta_Abarrotes', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLSV\MSSQL\DATA\Punto_Venta_Abarrotes.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Punto_Venta_Abarrotes_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLSV\MSSQL\DATA\Punto_Venta_Abarrotes_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Punto_Venta_Abarrotes] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Punto_Venta_Abarrotes].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Punto_Venta_Abarrotes] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Punto_Venta_Abarrotes] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Punto_Venta_Abarrotes] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Punto_Venta_Abarrotes] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Punto_Venta_Abarrotes] SET ARITHABORT OFF 
GO
ALTER DATABASE [Punto_Venta_Abarrotes] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Punto_Venta_Abarrotes] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Punto_Venta_Abarrotes] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Punto_Venta_Abarrotes] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Punto_Venta_Abarrotes] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Punto_Venta_Abarrotes] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Punto_Venta_Abarrotes] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Punto_Venta_Abarrotes] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Punto_Venta_Abarrotes] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Punto_Venta_Abarrotes] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Punto_Venta_Abarrotes] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Punto_Venta_Abarrotes] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Punto_Venta_Abarrotes] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Punto_Venta_Abarrotes] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Punto_Venta_Abarrotes] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Punto_Venta_Abarrotes] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Punto_Venta_Abarrotes] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Punto_Venta_Abarrotes] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Punto_Venta_Abarrotes] SET  MULTI_USER 
GO
ALTER DATABASE [Punto_Venta_Abarrotes] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Punto_Venta_Abarrotes] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Punto_Venta_Abarrotes] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Punto_Venta_Abarrotes] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Punto_Venta_Abarrotes] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Punto_Venta_Abarrotes] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Punto_Venta_Abarrotes] SET QUERY_STORE = OFF
GO
USE [Punto_Venta_Abarrotes]
GO
/****** Object:  User [amusuario02]    Script Date: 14/07/2021 05:09:14 a. m. ******/
CREATE USER [amusuario02] FOR LOGIN [amusuario02] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [amusuario01]    Script Date: 14/07/2021 05:09:14 a. m. ******/
CREATE USER [amusuario01] FOR LOGIN [amusuario01] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_backupoperator] ADD MEMBER [amusuario02]
GO
ALTER ROLE [db_datareader] ADD MEMBER [amusuario02]
GO
ALTER ROLE [db_datareader] ADD MEMBER [amusuario01]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [amusuario01]
GO
/****** Object:  Table [dbo].[Calle]    Script Date: 14/07/2021 05:09:15 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Calle](
	[idCalle] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](30) NOT NULL,
	[idColonia] [int] NULL,
	[idDomicilio] [int] NULL,
	[status] [bit] NOT NULL,
 CONSTRAINT [PK_idCalle] PRIMARY KEY CLUSTERED 
(
	[idCalle] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 14/07/2021 05:09:15 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[idPersona] [int] NOT NULL,
	[curp] [varchar](18) NOT NULL,
	[status] [bit] NOT NULL,
 CONSTRAINT [PK_idPersonaCliente] PRIMARY KEY CLUSTERED 
(
	[idPersona] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Colonia]    Script Date: 14/07/2021 05:09:15 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Colonia](
	[idColonia] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](30) NOT NULL,
	[idLocalidad] [int] NULL,
	[status] [bit] NOT NULL,
 CONSTRAINT [PK_idColonia] PRIMARY KEY CLUSTERED 
(
	[idColonia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Compra]    Script Date: 14/07/2021 05:09:15 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Compra](
	[idCompra] [int] IDENTITY(1,1) NOT NULL,
	[idProveedor] [int] NULL,
	[idPersonaEmpleado] [int] NULL,
	[subtotal] [decimal](18, 0) NOT NULL,
	[iva] [decimal](18, 0) NOT NULL,
	[total] [decimal](18, 0) NOT NULL,
	[fecha] [datetime] NOT NULL,
	[status] [bit] NOT NULL,
 CONSTRAINT [PK_idCompra] PRIMARY KEY CLUSTERED 
(
	[idCompra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Compra_Auditado]    Script Date: 14/07/2021 05:09:15 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Compra_Auditado](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[operacion] [varchar](10) NULL,
	[usuario] [varchar](40) NULL,
	[host] [varchar](30) NULL,
	[modificado] [datetime] NULL,
	[tabla] [varchar](40) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Detalle_Compra_Productos]    Script Date: 14/07/2021 05:09:15 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Detalle_Compra_Productos](
	[idCompra] [int] NOT NULL,
	[idProducto] [int] NOT NULL,
	[precio] [decimal](18, 0) NOT NULL,
	[cantidad] [int] NOT NULL,
	[subtotal] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_DetalleCompraProducto] PRIMARY KEY CLUSTERED 
(
	[idCompra] ASC,
	[idProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Detalle_Puesto_Turno]    Script Date: 14/07/2021 05:09:15 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Detalle_Puesto_Turno](
	[idPuesto] [int] NOT NULL,
	[idTurno] [int] NOT NULL,
	[asistencia] [bit] NOT NULL,
 CONSTRAINT [PK_idPuestoTurno] PRIMARY KEY CLUSTERED 
(
	[idPuesto] ASC,
	[idTurno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Detalle_Turno_Dia]    Script Date: 14/07/2021 05:09:15 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Detalle_Turno_Dia](
	[idTurno] [int] NOT NULL,
	[idDia] [int] NOT NULL,
 CONSTRAINT [PK_idTurnoDia] PRIMARY KEY CLUSTERED 
(
	[idTurno] ASC,
	[idDia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Detalle_Venta_Productos]    Script Date: 14/07/2021 05:09:15 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Detalle_Venta_Productos](
	[idVenta] [int] NOT NULL,
	[idProducto] [int] NOT NULL,
	[precio] [decimal](18, 0) NOT NULL,
	[cantidad] [int] NOT NULL,
	[subtotal] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_DetalleVentaProducto] PRIMARY KEY CLUSTERED 
(
	[idVenta] ASC,
	[idProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Dia]    Script Date: 14/07/2021 05:09:15 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dia](
	[idDia] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](10) NOT NULL,
	[status] [bit] NOT NULL,
 CONSTRAINT [PK_idDia] PRIMARY KEY CLUSTERED 
(
	[idDia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Domicilio]    Script Date: 14/07/2021 05:09:15 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Domicilio](
	[idDomicilio] [int] IDENTITY(1,1) NOT NULL,
	[numeroExt] [varchar](5) NOT NULL,
	[numeroInt] [varchar](5) NULL,
	[status] [bit] NOT NULL,
 CONSTRAINT [PK_idDomicilio] PRIMARY KEY CLUSTERED 
(
	[idDomicilio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleado]    Script Date: 14/07/2021 05:09:15 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleado](
	[idPersona] [int] NOT NULL,
	[idPuesto] [int] NULL,
	[idUsuario] [int] NULL,
	[rfc] [varchar](13) NULL,
	[status] [bit] NOT NULL,
 CONSTRAINT [PK_idPersonaEmpleado] PRIMARY KEY CLUSTERED 
(
	[idPersona] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Localidad]    Script Date: 14/07/2021 05:09:15 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Localidad](
	[idLocalidad] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](30) NOT NULL,
	[idMunicipio] [int] NULL,
	[status] [bit] NOT NULL,
 CONSTRAINT [PK_idLocalidad] PRIMARY KEY CLUSTERED 
(
	[idLocalidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Modulo]    Script Date: 14/07/2021 05:09:15 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Modulo](
	[idModulo] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_idModulo] PRIMARY KEY CLUSTERED 
(
	[idModulo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Municipio]    Script Date: 14/07/2021 05:09:15 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Municipio](
	[idMunicipio] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](30) NOT NULL,
	[status] [bit] NOT NULL,
 CONSTRAINT [PK_idMunicipio] PRIMARY KEY CLUSTERED 
(
	[idMunicipio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Operaciones]    Script Date: 14/07/2021 05:09:15 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Operaciones](
	[idOperacion] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[idModulo] [int] NOT NULL,
 CONSTRAINT [PK_idOperaciones] PRIMARY KEY CLUSTERED 
(
	[idOperacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Perdida]    Script Date: 14/07/2021 05:09:15 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Perdida](
	[idPerdida] [int] IDENTITY(1,1) NOT NULL,
	[precio] [decimal](18, 0) NOT NULL,
	[cantidad] [int] NOT NULL,
	[causa] [varchar](200) NOT NULL,
	[fechaRegistro] [date] NOT NULL,
	[idProducto] [int] NULL,
	[status] [bit] NOT NULL,
 CONSTRAINT [PK_idPerdida] PRIMARY KEY CLUSTERED 
(
	[idPerdida] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Perfil_Operacion]    Script Date: 14/07/2021 05:09:15 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Perfil_Operacion](
	[idRol] [int] NOT NULL,
	[idOperacion] [int] NOT NULL,
 CONSTRAINT [PK_idRolOperacion] PRIMARY KEY CLUSTERED 
(
	[idRol] ASC,
	[idOperacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Persona]    Script Date: 14/07/2021 05:09:15 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Persona](
	[idPersona] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](25) NOT NULL,
	[apPaterno] [varchar](25) NOT NULL,
	[apMaterno] [varchar](25) NULL,
	[fechaNac] [datetime] NOT NULL,
	[telefono] [varchar](10) NOT NULL,
	[idDomicilio] [int] NULL,
 CONSTRAINT [PK_idPersona] PRIMARY KEY CLUSTERED 
(
	[idPersona] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Productos]    Script Date: 14/07/2021 05:09:15 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos](
	[idProducto] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](30) NOT NULL,
	[precio] [decimal](18, 0) NOT NULL,
	[contenidoNeto] [decimal](18, 0) NOT NULL,
	[idUnidad] [int] NULL,
	[existencia] [int] NOT NULL,
	[fechaCaducidad] [datetime] NOT NULL,
	[idTipo] [int] NULL,
	[status] [bit] NOT NULL,
 CONSTRAINT [PK_idProducto] PRIMARY KEY CLUSTERED 
(
	[idProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proveedor]    Script Date: 14/07/2021 05:09:15 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedor](
	[idProveedor] [int] IDENTITY(1,1) NOT NULL,
	[razonSocial] [varchar](25) NOT NULL,
	[telefono] [varchar](10) NOT NULL,
	[idDomicilio] [int] NULL,
	[status] [bit] NOT NULL,
 CONSTRAINT [PK_idProveedor] PRIMARY KEY CLUSTERED 
(
	[idProveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Puesto]    Script Date: 14/07/2021 05:09:15 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Puesto](
	[idPuesto] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](25) NOT NULL,
	[salario] [int] NOT NULL,
	[descripcion] [varchar](100) NOT NULL,
	[status] [bit] NOT NULL,
 CONSTRAINT [PK_idPuesto] PRIMARY KEY CLUSTERED 
(
	[idPuesto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rol]    Script Date: 14/07/2021 05:09:15 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rol](
	[idRol] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_idRol] PRIMARY KEY CLUSTERED 
(
	[idRol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tipo]    Script Date: 14/07/2021 05:09:15 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipo](
	[idTipo] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](25) NOT NULL,
	[descripcion] [varchar](100) NOT NULL,
	[status] [bit] NOT NULL,
 CONSTRAINT [PK_idTipo] PRIMARY KEY CLUSTERED 
(
	[idTipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Turno]    Script Date: 14/07/2021 05:09:15 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Turno](
	[idTurno] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](25) NOT NULL,
	[horaEntrada] [time](7) NOT NULL,
	[horaSalida] [time](7) NOT NULL,
	[status] [bit] NOT NULL,
 CONSTRAINT [PK_idTurno] PRIMARY KEY CLUSTERED 
(
	[idTurno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Unidad]    Script Date: 14/07/2021 05:09:15 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Unidad](
	[idUnidad] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](25) NOT NULL,
	[descripcion] [varchar](100) NOT NULL,
	[status] [bit] NOT NULL,
 CONSTRAINT [PK_idUnidad] PRIMARY KEY CLUSTERED 
(
	[idUnidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 14/07/2021 05:09:15 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[idUsuario] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](30) NOT NULL,
	[correo] [varchar](50) NULL,
	[contrasenia] [varchar](50) NOT NULL,
	[status] [bit] NOT NULL,
 CONSTRAINT [PK_idUsuario] PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Venta]    Script Date: 14/07/2021 05:09:15 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Venta](
	[idVenta] [int] IDENTITY(1,1) NOT NULL,
	[idPersonaCliente] [int] NULL,
	[idPersonaEmpleado] [int] NULL,
	[subtotal] [decimal](18, 0) NOT NULL,
	[iva] [decimal](18, 0) NOT NULL,
	[total] [decimal](18, 0) NOT NULL,
	[fecha] [date] NOT NULL,
	[status] [bit] NOT NULL,
 CONSTRAINT [PK_idVenta] PRIMARY KEY CLUSTERED 
(
	[idVenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Venta_Auditado]    Script Date: 14/07/2021 05:09:15 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Venta_Auditado](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[operacion] [varchar](10) NULL,
	[usuario] [varchar](40) NULL,
	[host] [varchar](30) NULL,
	[modificado] [datetime] NULL,
	[tabla] [varchar](40) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Venta_Productos]    Script Date: 14/07/2021 05:09:15 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Venta_Productos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[operacion] [varchar](10) NULL,
	[usuario] [varchar](40) NULL,
	[host] [varchar](30) NULL,
	[modificado] [datetime] NULL,
	[tabla] [varchar](40) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Calle] ON 
GO
INSERT [dbo].[Calle] ([idCalle], [nombre], [idColonia], [idDomicilio], [status]) VALUES (1, N'Hidalgo', 1, 3, 1)
GO
INSERT [dbo].[Calle] ([idCalle], [nombre], [idColonia], [idDomicilio], [status]) VALUES (2, N'Demetrio Vallejo', 2, 1, 0)
GO
INSERT [dbo].[Calle] ([idCalle], [nombre], [idColonia], [idDomicilio], [status]) VALUES (3, N'Zaragoza', 3, 2, 1)
GO
INSERT [dbo].[Calle] ([idCalle], [nombre], [idColonia], [idDomicilio], [status]) VALUES (10, N'México', 10, 10, 1)
GO
INSERT [dbo].[Calle] ([idCalle], [nombre], [idColonia], [idDomicilio], [status]) VALUES (26, N'Aquiles', 26, 26, 1)
GO
SET IDENTITY_INSERT [dbo].[Calle] OFF
GO
INSERT [dbo].[Cliente] ([idPersona], [curp], [status]) VALUES (4, N'ROGR820522MNTMSSA7', 1)
GO
INSERT [dbo].[Cliente] ([idPersona], [curp], [status]) VALUES (6, N'GACM831021MNTMSSA7', 1)
GO
INSERT [dbo].[Cliente] ([idPersona], [curp], [status]) VALUES (7, N'ROSA800603MNTHSSA7', 1)
GO
INSERT [dbo].[Cliente] ([idPersona], [curp], [status]) VALUES (8, N'AGRE801123MNTMSSA7', 0)
GO
INSERT [dbo].[Cliente] ([idPersona], [curp], [status]) VALUES (24, N'RARD011009MNTMSSA7', 1)
GO
SET IDENTITY_INSERT [dbo].[Colonia] ON 
GO
INSERT [dbo].[Colonia] ([idColonia], [nombre], [idLocalidad], [status]) VALUES (1, N'8 de mayo', 3, 0)
GO
INSERT [dbo].[Colonia] ([idColonia], [nombre], [idLocalidad], [status]) VALUES (2, N'El Chaleco', 2, 1)
GO
INSERT [dbo].[Colonia] ([idColonia], [nombre], [idLocalidad], [status]) VALUES (3, N'Benito Juarez', 1, 1)
GO
INSERT [dbo].[Colonia] ([idColonia], [nombre], [idLocalidad], [status]) VALUES (10, N'Huertas', 10, 1)
GO
INSERT [dbo].[Colonia] ([idColonia], [nombre], [idLocalidad], [status]) VALUES (26, N'Llano', 26, 1)
GO
SET IDENTITY_INSERT [dbo].[Colonia] OFF
GO
SET IDENTITY_INSERT [dbo].[Compra] ON 
GO
INSERT [dbo].[Compra] ([idCompra], [idProveedor], [idPersonaEmpleado], [subtotal], [iva], [total], [fecha], [status]) VALUES (1, 1, 2, CAST(55 AS Decimal(18, 0)), CAST(13 AS Decimal(18, 0)), CAST(68 AS Decimal(18, 0)), CAST(N'2021-05-10T00:00:00.000' AS DateTime), 1)
GO
INSERT [dbo].[Compra] ([idCompra], [idProveedor], [idPersonaEmpleado], [subtotal], [iva], [total], [fecha], [status]) VALUES (2, 2, 3, CAST(100 AS Decimal(18, 0)), CAST(15 AS Decimal(18, 0)), CAST(115 AS Decimal(18, 0)), CAST(N'2021-05-11T00:00:00.000' AS DateTime), 1)
GO
INSERT [dbo].[Compra] ([idCompra], [idProveedor], [idPersonaEmpleado], [subtotal], [iva], [total], [fecha], [status]) VALUES (3, 3, 1, CAST(50 AS Decimal(18, 0)), CAST(10 AS Decimal(18, 0)), CAST(60 AS Decimal(18, 0)), CAST(N'2021-05-12T00:00:00.000' AS DateTime), 0)
GO
INSERT [dbo].[Compra] ([idCompra], [idProveedor], [idPersonaEmpleado], [subtotal], [iva], [total], [fecha], [status]) VALUES (4, 1, 2, CAST(38 AS Decimal(18, 0)), CAST(8 AS Decimal(18, 0)), CAST(45 AS Decimal(18, 0)), CAST(N'2021-05-10T00:00:00.000' AS DateTime), 1)
GO
INSERT [dbo].[Compra] ([idCompra], [idProveedor], [idPersonaEmpleado], [subtotal], [iva], [total], [fecha], [status]) VALUES (5, 2, 3, CAST(100 AS Decimal(18, 0)), CAST(15 AS Decimal(18, 0)), CAST(115 AS Decimal(18, 0)), CAST(N'2021-05-11T00:00:00.000' AS DateTime), 1)
GO
INSERT [dbo].[Compra] ([idCompra], [idProveedor], [idPersonaEmpleado], [subtotal], [iva], [total], [fecha], [status]) VALUES (6, 3, 1, CAST(50 AS Decimal(18, 0)), CAST(10 AS Decimal(18, 0)), CAST(60 AS Decimal(18, 0)), CAST(N'2021-05-12T00:00:00.000' AS DateTime), 1)
GO
SET IDENTITY_INSERT [dbo].[Compra] OFF
GO
SET IDENTITY_INSERT [dbo].[Compra_Auditado] ON 
GO
INSERT [dbo].[Compra_Auditado] ([id], [operacion], [usuario], [host], [modificado], [tabla]) VALUES (1, N'insert', N'sa', N'DESKTOP-BKOIH1I', CAST(N'2021-07-04T15:43:39.327' AS DateTime), N'Compra')
GO
INSERT [dbo].[Compra_Auditado] ([id], [operacion], [usuario], [host], [modificado], [tabla]) VALUES (2, N'Update', N'sa', N'DESKTOP-BKOIH1I', CAST(N'2021-07-04T16:08:28.480' AS DateTime), N'Compra')
GO
INSERT [dbo].[Compra_Auditado] ([id], [operacion], [usuario], [host], [modificado], [tabla]) VALUES (3, N'Delete', N'sa', N'DESKTOP-BKOIH1I', CAST(N'2021-07-04T16:13:36.140' AS DateTime), N'Compra')
GO
SET IDENTITY_INSERT [dbo].[Compra_Auditado] OFF
GO
INSERT [dbo].[Detalle_Compra_Productos] ([idCompra], [idProducto], [precio], [cantidad], [subtotal]) VALUES (2, 8, CAST(13 AS Decimal(18, 0)), 5, CAST(100 AS Decimal(18, 0)))
GO
INSERT [dbo].[Detalle_Compra_Productos] ([idCompra], [idProducto], [precio], [cantidad], [subtotal]) VALUES (3, 9, CAST(47 AS Decimal(18, 0)), 1, CAST(50 AS Decimal(18, 0)))
GO
INSERT [dbo].[Detalle_Compra_Productos] ([idCompra], [idProducto], [precio], [cantidad], [subtotal]) VALUES (4, 10, CAST(30 AS Decimal(18, 0)), 9, CAST(324 AS Decimal(18, 0)))
GO
INSERT [dbo].[Detalle_Compra_Productos] ([idCompra], [idProducto], [precio], [cantidad], [subtotal]) VALUES (5, 10, CAST(30 AS Decimal(18, 0)), 1, CAST(30 AS Decimal(18, 0)))
GO
INSERT [dbo].[Detalle_Puesto_Turno] ([idPuesto], [idTurno], [asistencia]) VALUES (2, 1, 1)
GO
INSERT [dbo].[Detalle_Puesto_Turno] ([idPuesto], [idTurno], [asistencia]) VALUES (3, 2, 1)
GO
INSERT [dbo].[Detalle_Turno_Dia] ([idTurno], [idDia]) VALUES (1, 2)
GO
INSERT [dbo].[Detalle_Turno_Dia] ([idTurno], [idDia]) VALUES (2, 3)
GO
INSERT [dbo].[Detalle_Venta_Productos] ([idVenta], [idProducto], [precio], [cantidad], [subtotal]) VALUES (1, 7, CAST(15 AS Decimal(18, 0)), 2, CAST(38 AS Decimal(18, 0)))
GO
INSERT [dbo].[Detalle_Venta_Productos] ([idVenta], [idProducto], [precio], [cantidad], [subtotal]) VALUES (1, 10, CAST(38 AS Decimal(18, 0)), 4, CAST(42 AS Decimal(18, 0)))
GO
INSERT [dbo].[Detalle_Venta_Productos] ([idVenta], [idProducto], [precio], [cantidad], [subtotal]) VALUES (3, 9, CAST(47 AS Decimal(18, 0)), 1, CAST(50 AS Decimal(18, 0)))
GO
INSERT [dbo].[Detalle_Venta_Productos] ([idVenta], [idProducto], [precio], [cantidad], [subtotal]) VALUES (7, 11, CAST(6 AS Decimal(18, 0)), 1, CAST(27 AS Decimal(18, 0)))
GO
INSERT [dbo].[Detalle_Venta_Productos] ([idVenta], [idProducto], [precio], [cantidad], [subtotal]) VALUES (15, 7, CAST(15 AS Decimal(18, 0)), 2, CAST(30 AS Decimal(18, 0)))
GO
INSERT [dbo].[Detalle_Venta_Productos] ([idVenta], [idProducto], [precio], [cantidad], [subtotal]) VALUES (16, 7, CAST(15 AS Decimal(18, 0)), 2, CAST(30 AS Decimal(18, 0)))
GO
INSERT [dbo].[Detalle_Venta_Productos] ([idVenta], [idProducto], [precio], [cantidad], [subtotal]) VALUES (17, 7, CAST(15 AS Decimal(18, 0)), 2, CAST(30 AS Decimal(18, 0)))
GO
INSERT [dbo].[Detalle_Venta_Productos] ([idVenta], [idProducto], [precio], [cantidad], [subtotal]) VALUES (18, 13, CAST(15 AS Decimal(18, 0)), 2, CAST(30 AS Decimal(18, 0)))
GO
SET IDENTITY_INSERT [dbo].[Dia] ON 
GO
INSERT [dbo].[Dia] ([idDia], [nombre], [status]) VALUES (1, N'Lunes', 1)
GO
INSERT [dbo].[Dia] ([idDia], [nombre], [status]) VALUES (2, N'Martes', 1)
GO
INSERT [dbo].[Dia] ([idDia], [nombre], [status]) VALUES (3, N'Miercoles', 1)
GO
SET IDENTITY_INSERT [dbo].[Dia] OFF
GO
SET IDENTITY_INSERT [dbo].[Domicilio] ON 
GO
INSERT [dbo].[Domicilio] ([idDomicilio], [numeroExt], [numeroInt], [status]) VALUES (1, N'20A', NULL, 0)
GO
INSERT [dbo].[Domicilio] ([idDomicilio], [numeroExt], [numeroInt], [status]) VALUES (2, N'10', N'110', 1)
GO
INSERT [dbo].[Domicilio] ([idDomicilio], [numeroExt], [numeroInt], [status]) VALUES (3, N'15', NULL, 1)
GO
INSERT [dbo].[Domicilio] ([idDomicilio], [numeroExt], [numeroInt], [status]) VALUES (10, N'30', N'30A', 1)
GO
INSERT [dbo].[Domicilio] ([idDomicilio], [numeroExt], [numeroInt], [status]) VALUES (26, N'20', N'20B', 1)
GO
SET IDENTITY_INSERT [dbo].[Domicilio] OFF
GO
INSERT [dbo].[Empleado] ([idPersona], [idPuesto], [idUsuario], [rfc], [status]) VALUES (1, 2, 1, N'RARD011009IM7', 1)
GO
INSERT [dbo].[Empleado] ([idPersona], [idPuesto], [idUsuario], [rfc], [status]) VALUES (2, 3, 2, N'REAL009159IH7', 1)
GO
INSERT [dbo].[Empleado] ([idPersona], [idPuesto], [idUsuario], [rfc], [status]) VALUES (3, 1, 3, N'LOLG980305TC4', 0)
GO
INSERT [dbo].[Empleado] ([idPersona], [idPuesto], [idUsuario], [rfc], [status]) VALUES (9, 2, 7, N'CHOF750903TH7', 0)
GO
SET IDENTITY_INSERT [dbo].[Localidad] ON 
GO
INSERT [dbo].[Localidad] ([idLocalidad], [nombre], [idMunicipio], [status]) VALUES (1, N'Ahuacatlan', 1, 1)
GO
INSERT [dbo].[Localidad] ([idLocalidad], [nombre], [idMunicipio], [status]) VALUES (2, N'Ixtlán del Rio', 2, 1)
GO
INSERT [dbo].[Localidad] ([idLocalidad], [nombre], [idMunicipio], [status]) VALUES (3, N'Jala', 3, 0)
GO
INSERT [dbo].[Localidad] ([idLocalidad], [nombre], [idMunicipio], [status]) VALUES (10, N'Ahuacatlán', 11, 1)
GO
INSERT [dbo].[Localidad] ([idLocalidad], [nombre], [idMunicipio], [status]) VALUES (26, N'Tepic', 27, 1)
GO
SET IDENTITY_INSERT [dbo].[Localidad] OFF
GO
SET IDENTITY_INSERT [dbo].[Modulo] ON 
GO
INSERT [dbo].[Modulo] ([idModulo], [nombre]) VALUES (1, N'Clientes')
GO
INSERT [dbo].[Modulo] ([idModulo], [nombre]) VALUES (2, N'Compras')
GO
INSERT [dbo].[Modulo] ([idModulo], [nombre]) VALUES (3, N'Domicilios')
GO
INSERT [dbo].[Modulo] ([idModulo], [nombre]) VALUES (4, N'Empleados')
GO
INSERT [dbo].[Modulo] ([idModulo], [nombre]) VALUES (5, N'Perdidas')
GO
INSERT [dbo].[Modulo] ([idModulo], [nombre]) VALUES (6, N'Productos')
GO
INSERT [dbo].[Modulo] ([idModulo], [nombre]) VALUES (7, N'Proveedores')
GO
INSERT [dbo].[Modulo] ([idModulo], [nombre]) VALUES (8, N'Puestos')
GO
INSERT [dbo].[Modulo] ([idModulo], [nombre]) VALUES (9, N'Usuarios')
GO
INSERT [dbo].[Modulo] ([idModulo], [nombre]) VALUES (10, N'Ventas')
GO
INSERT [dbo].[Modulo] ([idModulo], [nombre]) VALUES (11, N'Roles')
GO
INSERT [dbo].[Modulo] ([idModulo], [nombre]) VALUES (12, N'Reportes_Ventas')
GO
SET IDENTITY_INSERT [dbo].[Modulo] OFF
GO
SET IDENTITY_INSERT [dbo].[Municipio] ON 
GO
INSERT [dbo].[Municipio] ([idMunicipio], [nombre], [status]) VALUES (1, N'Ahuacatlán', 1)
GO
INSERT [dbo].[Municipio] ([idMunicipio], [nombre], [status]) VALUES (2, N'Ixtlán del Rio', 1)
GO
INSERT [dbo].[Municipio] ([idMunicipio], [nombre], [status]) VALUES (3, N'Jala', 0)
GO
INSERT [dbo].[Municipio] ([idMunicipio], [nombre], [status]) VALUES (11, N'Nayarit', 1)
GO
INSERT [dbo].[Municipio] ([idMunicipio], [nombre], [status]) VALUES (27, N'Tepic', 1)
GO
SET IDENTITY_INSERT [dbo].[Municipio] OFF
GO
SET IDENTITY_INSERT [dbo].[Operaciones] ON 
GO
INSERT [dbo].[Operaciones] ([idOperacion], [nombre], [idModulo]) VALUES (1, N'Agregar', 1)
GO
INSERT [dbo].[Operaciones] ([idOperacion], [nombre], [idModulo]) VALUES (2, N'Mostrar', 1)
GO
INSERT [dbo].[Operaciones] ([idOperacion], [nombre], [idModulo]) VALUES (3, N'Editar', 1)
GO
INSERT [dbo].[Operaciones] ([idOperacion], [nombre], [idModulo]) VALUES (4, N'Eliminar', 1)
GO
INSERT [dbo].[Operaciones] ([idOperacion], [nombre], [idModulo]) VALUES (5, N'Agregar', 2)
GO
INSERT [dbo].[Operaciones] ([idOperacion], [nombre], [idModulo]) VALUES (6, N'Mostrar', 2)
GO
INSERT [dbo].[Operaciones] ([idOperacion], [nombre], [idModulo]) VALUES (7, N'Editar', 2)
GO
INSERT [dbo].[Operaciones] ([idOperacion], [nombre], [idModulo]) VALUES (8, N'Eliminar', 2)
GO
INSERT [dbo].[Operaciones] ([idOperacion], [nombre], [idModulo]) VALUES (9, N'Agregar', 3)
GO
INSERT [dbo].[Operaciones] ([idOperacion], [nombre], [idModulo]) VALUES (10, N'Mostrar', 3)
GO
INSERT [dbo].[Operaciones] ([idOperacion], [nombre], [idModulo]) VALUES (11, N'Editar', 3)
GO
INSERT [dbo].[Operaciones] ([idOperacion], [nombre], [idModulo]) VALUES (12, N'Eliminar', 3)
GO
INSERT [dbo].[Operaciones] ([idOperacion], [nombre], [idModulo]) VALUES (13, N'Agregar', 4)
GO
INSERT [dbo].[Operaciones] ([idOperacion], [nombre], [idModulo]) VALUES (14, N'Mostrar', 4)
GO
INSERT [dbo].[Operaciones] ([idOperacion], [nombre], [idModulo]) VALUES (15, N'Editar', 4)
GO
INSERT [dbo].[Operaciones] ([idOperacion], [nombre], [idModulo]) VALUES (16, N'Eliminar', 4)
GO
INSERT [dbo].[Operaciones] ([idOperacion], [nombre], [idModulo]) VALUES (17, N'Agregar', 5)
GO
INSERT [dbo].[Operaciones] ([idOperacion], [nombre], [idModulo]) VALUES (18, N'Mostrar', 5)
GO
INSERT [dbo].[Operaciones] ([idOperacion], [nombre], [idModulo]) VALUES (19, N'Editar', 5)
GO
INSERT [dbo].[Operaciones] ([idOperacion], [nombre], [idModulo]) VALUES (20, N'Eliminar', 5)
GO
INSERT [dbo].[Operaciones] ([idOperacion], [nombre], [idModulo]) VALUES (21, N'Agregar', 6)
GO
INSERT [dbo].[Operaciones] ([idOperacion], [nombre], [idModulo]) VALUES (22, N'Mostrar', 6)
GO
INSERT [dbo].[Operaciones] ([idOperacion], [nombre], [idModulo]) VALUES (23, N'Editar', 6)
GO
INSERT [dbo].[Operaciones] ([idOperacion], [nombre], [idModulo]) VALUES (24, N'Eliminar', 6)
GO
INSERT [dbo].[Operaciones] ([idOperacion], [nombre], [idModulo]) VALUES (25, N'Agregar', 7)
GO
INSERT [dbo].[Operaciones] ([idOperacion], [nombre], [idModulo]) VALUES (26, N'Mostrar', 7)
GO
INSERT [dbo].[Operaciones] ([idOperacion], [nombre], [idModulo]) VALUES (27, N'Editar', 7)
GO
INSERT [dbo].[Operaciones] ([idOperacion], [nombre], [idModulo]) VALUES (28, N'Eliminar', 7)
GO
INSERT [dbo].[Operaciones] ([idOperacion], [nombre], [idModulo]) VALUES (29, N'Agregar', 8)
GO
INSERT [dbo].[Operaciones] ([idOperacion], [nombre], [idModulo]) VALUES (30, N'Mostrar', 8)
GO
INSERT [dbo].[Operaciones] ([idOperacion], [nombre], [idModulo]) VALUES (31, N'Editar', 8)
GO
INSERT [dbo].[Operaciones] ([idOperacion], [nombre], [idModulo]) VALUES (32, N'Eliminar', 8)
GO
INSERT [dbo].[Operaciones] ([idOperacion], [nombre], [idModulo]) VALUES (33, N'Agregar', 9)
GO
INSERT [dbo].[Operaciones] ([idOperacion], [nombre], [idModulo]) VALUES (34, N'Mostrar', 9)
GO
INSERT [dbo].[Operaciones] ([idOperacion], [nombre], [idModulo]) VALUES (35, N'Editar', 9)
GO
INSERT [dbo].[Operaciones] ([idOperacion], [nombre], [idModulo]) VALUES (36, N'Eliminar', 9)
GO
INSERT [dbo].[Operaciones] ([idOperacion], [nombre], [idModulo]) VALUES (37, N'Agregar', 10)
GO
INSERT [dbo].[Operaciones] ([idOperacion], [nombre], [idModulo]) VALUES (38, N'Mostrar', 10)
GO
INSERT [dbo].[Operaciones] ([idOperacion], [nombre], [idModulo]) VALUES (39, N'Editar', 10)
GO
INSERT [dbo].[Operaciones] ([idOperacion], [nombre], [idModulo]) VALUES (40, N'Eliminar', 10)
GO
INSERT [dbo].[Operaciones] ([idOperacion], [nombre], [idModulo]) VALUES (41, N'Agregar', 11)
GO
INSERT [dbo].[Operaciones] ([idOperacion], [nombre], [idModulo]) VALUES (42, N'Mostrar', 11)
GO
INSERT [dbo].[Operaciones] ([idOperacion], [nombre], [idModulo]) VALUES (43, N'Editar', 11)
GO
INSERT [dbo].[Operaciones] ([idOperacion], [nombre], [idModulo]) VALUES (44, N'Eliminar', 11)
GO
INSERT [dbo].[Operaciones] ([idOperacion], [nombre], [idModulo]) VALUES (45, N'Mostrar', 12)
GO
SET IDENTITY_INSERT [dbo].[Operaciones] OFF
GO
SET IDENTITY_INSERT [dbo].[Perdida] ON 
GO
INSERT [dbo].[Perdida] ([idPerdida], [precio], [cantidad], [causa], [fechaRegistro], [idProducto], [status]) VALUES (1, CAST(15 AS Decimal(18, 0)), 2, N'El producto se ha quebrado', CAST(N'2021-05-11' AS Date), 7, 0)
GO
INSERT [dbo].[Perdida] ([idPerdida], [precio], [cantidad], [causa], [fechaRegistro], [idProducto], [status]) VALUES (2, CAST(13 AS Decimal(18, 0)), 3, N'El producto ha caducado', CAST(N'2021-05-11' AS Date), 8, 1)
GO
INSERT [dbo].[Perdida] ([idPerdida], [precio], [cantidad], [causa], [fechaRegistro], [idProducto], [status]) VALUES (3, CAST(47 AS Decimal(18, 0)), 1, N'El producto ha caducado', CAST(N'2021-05-11' AS Date), 9, 1)
GO
SET IDENTITY_INSERT [dbo].[Perdida] OFF
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (1, 1)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (1, 2)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (1, 3)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (1, 4)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (1, 5)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (1, 6)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (1, 7)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (1, 8)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (1, 9)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (1, 10)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (1, 11)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (1, 12)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (1, 13)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (1, 14)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (1, 15)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (1, 16)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (1, 17)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (1, 18)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (1, 19)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (1, 20)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (1, 21)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (1, 22)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (1, 23)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (1, 24)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (1, 25)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (1, 26)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (1, 27)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (1, 28)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (1, 29)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (1, 30)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (1, 31)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (1, 32)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (1, 33)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (1, 34)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (1, 35)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (1, 36)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (1, 37)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (1, 38)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (1, 39)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (1, 40)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (1, 41)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (1, 42)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (1, 43)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (1, 44)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (1, 45)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (2, 1)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (2, 2)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (2, 5)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (2, 6)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (2, 9)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (2, 10)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (2, 13)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (2, 14)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (2, 17)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (2, 18)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (2, 21)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (2, 22)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (2, 25)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (2, 26)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (2, 29)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (2, 30)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (2, 33)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (2, 34)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (2, 37)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (2, 38)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (2, 41)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (2, 42)
GO
SET IDENTITY_INSERT [dbo].[Persona] ON 
GO
INSERT [dbo].[Persona] ([idPersona], [nombre], [apPaterno], [apMaterno], [fechaNac], [telefono], [idDomicilio]) VALUES (1, N'Deisi Jacqueline', N'Ramos', N'Rosas', CAST(N'2001-10-09T00:00:00.000' AS DateTime), N'3241336213', 2)
GO
INSERT [dbo].[Persona] ([idPersona], [nombre], [apPaterno], [apMaterno], [fechaNac], [telefono], [idDomicilio]) VALUES (2, N'Luis', N'Rendon', N'Aguirre', CAST(N'2000-09-15T00:00:00.000' AS DateTime), N'3241056413', 1)
GO
INSERT [dbo].[Persona] ([idPersona], [nombre], [apPaterno], [apMaterno], [fechaNac], [telefono], [idDomicilio]) VALUES (3, N'Gerardo', N'Lopez', N'Lopez', CAST(N'1998-03-05T00:00:00.000' AS DateTime), N'3241267890', 3)
GO
INSERT [dbo].[Persona] ([idPersona], [nombre], [apPaterno], [apMaterno], [fechaNac], [telefono], [idDomicilio]) VALUES (4, N'Rita Mayra', N'Rosas', N'Garcia', CAST(N'1982-05-22T00:00:00.000' AS DateTime), N'3241265540', 2)
GO
INSERT [dbo].[Persona] ([idPersona], [nombre], [apPaterno], [apMaterno], [fechaNac], [telefono], [idDomicilio]) VALUES (6, N'Margarita', N'Garcia', N'Cueto', CAST(N'1983-10-20T00:00:00.000' AS DateTime), N'3241278900', 1)
GO
INSERT [dbo].[Persona] ([idPersona], [nombre], [apPaterno], [apMaterno], [fechaNac], [telefono], [idDomicilio]) VALUES (7, N'Antonio', N'Rosas', N'Santos', CAST(N'1980-06-03T00:00:00.000' AS DateTime), N'3241267801', 3)
GO
INSERT [dbo].[Persona] ([idPersona], [nombre], [apPaterno], [apMaterno], [fechaNac], [telefono], [idDomicilio]) VALUES (8, N'Elisa Lorena', N'Rendon', N'Aguirre', CAST(N'1980-11-23T00:00:00.000' AS DateTime), N'3241336213', 2)
GO
INSERT [dbo].[Persona] ([idPersona], [nombre], [apPaterno], [apMaterno], [fechaNac], [telefono], [idDomicilio]) VALUES (9, N'Luis Fernando', N'Ornelas', N'Chavez', CAST(N'1975-09-03T00:00:00.000' AS DateTime), N'3241367809', 2)
GO
INSERT [dbo].[Persona] ([idPersona], [nombre], [apPaterno], [apMaterno], [fechaNac], [telefono], [idDomicilio]) VALUES (24, N'Zaira', N'Gonzalez', N'Lopez', CAST(N'1999-10-22T00:00:00.000' AS DateTime), N'3241567890', 10)
GO
INSERT [dbo].[Persona] ([idPersona], [nombre], [apPaterno], [apMaterno], [fechaNac], [telefono], [idDomicilio]) VALUES (25, N'Noemi', N'Gutierrez', N'Macias', CAST(N'2001-09-28T00:00:00.000' AS DateTime), N'3119098769', 2)
GO
SET IDENTITY_INSERT [dbo].[Persona] OFF
GO
SET IDENTITY_INSERT [dbo].[Productos] ON 
GO
INSERT [dbo].[Productos] ([idProducto], [nombre], [precio], [contenidoNeto], [idUnidad], [existencia], [fechaCaducidad], [idTipo], [status]) VALUES (7, N'Leche', CAST(15 AS Decimal(18, 0)), CAST(150 AS Decimal(18, 0)), 4, 0, CAST(N'2021-05-15T00:00:00.000' AS DateTime), 1, 1)
GO
INSERT [dbo].[Productos] ([idProducto], [nombre], [precio], [contenidoNeto], [idUnidad], [existencia], [fechaCaducidad], [idTipo], [status]) VALUES (8, N'Sabritas', CAST(13 AS Decimal(18, 0)), CAST(250 AS Decimal(18, 0)), 3, 10, CAST(N'2021-06-13T00:00:00.000' AS DateTime), 2, 0)
GO
INSERT [dbo].[Productos] ([idProducto], [nombre], [precio], [contenidoNeto], [idUnidad], [existencia], [fechaCaducidad], [idTipo], [status]) VALUES (9, N'Papas Sabritas', CAST(15 AS Decimal(18, 0)), CAST(1 AS Decimal(18, 0)), 1, 8, CAST(N'2021-05-11T00:00:00.000' AS DateTime), 3, 1)
GO
INSERT [dbo].[Productos] ([idProducto], [nombre], [precio], [contenidoNeto], [idUnidad], [existencia], [fechaCaducidad], [idTipo], [status]) VALUES (10, N'Chuletas', CAST(38 AS Decimal(18, 0)), CAST(1 AS Decimal(18, 0)), 1, 10, CAST(N'2021-05-12T00:00:00.000' AS DateTime), 3, 1)
GO
INSERT [dbo].[Productos] ([idProducto], [nombre], [precio], [contenidoNeto], [idUnidad], [existencia], [fechaCaducidad], [idTipo], [status]) VALUES (11, N'Queso', CAST(27 AS Decimal(18, 0)), CAST(250 AS Decimal(18, 0)), 3, 6, CAST(N'2021-05-27T00:00:00.000' AS DateTime), 1, 1)
GO
INSERT [dbo].[Productos] ([idProducto], [nombre], [precio], [contenidoNeto], [idUnidad], [existencia], [fechaCaducidad], [idTipo], [status]) VALUES (12, N'Galletas Gamesa', CAST(13 AS Decimal(18, 0)), CAST(170 AS Decimal(18, 0)), 3, 10, CAST(N'2021-06-27T00:00:00.000' AS DateTime), 2, 1)
GO
INSERT [dbo].[Productos] ([idProducto], [nombre], [precio], [contenidoNeto], [idUnidad], [existencia], [fechaCaducidad], [idTipo], [status]) VALUES (13, N'GALLETAS MARIAS', CAST(15 AS Decimal(18, 0)), CAST(250 AS Decimal(18, 0)), 3, 1, CAST(N'2021-07-12T12:07:01.380' AS DateTime), 2, 1)
GO
INSERT [dbo].[Productos] ([idProducto], [nombre], [precio], [contenidoNeto], [idUnidad], [existencia], [fechaCaducidad], [idTipo], [status]) VALUES (14, N'PECHUGA DE POLLO', CAST(20 AS Decimal(18, 0)), CAST(250 AS Decimal(18, 0)), 3, 2, CAST(N'2021-07-14T03:40:50.837' AS DateTime), 3, 1)
GO
SET IDENTITY_INSERT [dbo].[Productos] OFF
GO
SET IDENTITY_INSERT [dbo].[Proveedor] ON 
GO
INSERT [dbo].[Proveedor] ([idProveedor], [razonSocial], [telefono], [idDomicilio], [status]) VALUES (1, N'SELLO ROJO', N'3242456789', 1, 1)
GO
INSERT [dbo].[Proveedor] ([idProveedor], [razonSocial], [telefono], [idDomicilio], [status]) VALUES (2, N'MARINELA', N'3242416243', 3, 1)
GO
INSERT [dbo].[Proveedor] ([idProveedor], [razonSocial], [telefono], [idDomicilio], [status]) VALUES (3, N'COCA COLA', N'3242417091', 2, 1)
GO
INSERT [dbo].[Proveedor] ([idProveedor], [razonSocial], [telefono], [idDomicilio], [status]) VALUES (4, N'Pepsi', N'3241567890', 26, 1)
GO
INSERT [dbo].[Proveedor] ([idProveedor], [razonSocial], [telefono], [idDomicilio], [status]) VALUES (5, N'BARCEL', N'3241567890', 2, 1)
GO
SET IDENTITY_INSERT [dbo].[Proveedor] OFF
GO
SET IDENTITY_INSERT [dbo].[Puesto] ON 
GO
INSERT [dbo].[Puesto] ([idPuesto], [nombre], [salario], [descripcion], [status]) VALUES (1, N'Administrador', 1800, N'Administra la tienda', 1)
GO
INSERT [dbo].[Puesto] ([idPuesto], [nombre], [salario], [descripcion], [status]) VALUES (2, N'Cajero', 1200, N'Cobradores de caja', 0)
GO
INSERT [dbo].[Puesto] ([idPuesto], [nombre], [salario], [descripcion], [status]) VALUES (3, N'Promotor', 1400, N'Acomodan productos', 1)
GO
SET IDENTITY_INSERT [dbo].[Puesto] OFF
GO
SET IDENTITY_INSERT [dbo].[Rol] ON 
GO
INSERT [dbo].[Rol] ([idRol], [nombre]) VALUES (1, N'Administrador')
GO
INSERT [dbo].[Rol] ([idRol], [nombre]) VALUES (2, N'Lector')
GO
SET IDENTITY_INSERT [dbo].[Rol] OFF
GO
SET IDENTITY_INSERT [dbo].[Tipo] ON 
GO
INSERT [dbo].[Tipo] ([idTipo], [nombre], [descripcion], [status]) VALUES (1, N'Lácteos', N'Productos elaborados con leche de animal', 1)
GO
INSERT [dbo].[Tipo] ([idTipo], [nombre], [descripcion], [status]) VALUES (2, N'Abarrotes', N'Sabritas, Refrescos y más', 1)
GO
INSERT [dbo].[Tipo] ([idTipo], [nombre], [descripcion], [status]) VALUES (3, N'Carnes', N'Carnes de distintas especies', 0)
GO
SET IDENTITY_INSERT [dbo].[Tipo] OFF
GO
SET IDENTITY_INSERT [dbo].[Turno] ON 
GO
INSERT [dbo].[Turno] ([idTurno], [nombre], [horaEntrada], [horaSalida], [status]) VALUES (1, N'Matutino', CAST(N'08:00:00' AS Time), CAST(N'03:00:00' AS Time), 1)
GO
INSERT [dbo].[Turno] ([idTurno], [nombre], [horaEntrada], [horaSalida], [status]) VALUES (2, N'Vespertino', CAST(N'03:00:00' AS Time), CAST(N'10:00:00' AS Time), 1)
GO
SET IDENTITY_INSERT [dbo].[Turno] OFF
GO
SET IDENTITY_INSERT [dbo].[Unidad] ON 
GO
INSERT [dbo].[Unidad] ([idUnidad], [nombre], [descripcion], [status]) VALUES (1, N'Kg', N'Unidad de medida para masas', 1)
GO
INSERT [dbo].[Unidad] ([idUnidad], [nombre], [descripcion], [status]) VALUES (2, N'Litro', N'Unidad de medida para volúmenes', 1)
GO
INSERT [dbo].[Unidad] ([idUnidad], [nombre], [descripcion], [status]) VALUES (3, N'gramo', N'Unidad de medida para masas', 1)
GO
INSERT [dbo].[Unidad] ([idUnidad], [nombre], [descripcion], [status]) VALUES (4, N'Mililitro', N'Unidad de medida para volúmenes', 0)
GO
SET IDENTITY_INSERT [dbo].[Unidad] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuario] ON 
GO
INSERT [dbo].[Usuario] ([idUsuario], [nombre], [correo], [contrasenia], [status]) VALUES (1, N'Jacqueline_09', N'Jacqueline09@gmail.com', N'Octubre09', 1)
GO
INSERT [dbo].[Usuario] ([idUsuario], [nombre], [correo], [contrasenia], [status]) VALUES (2, N'Luis15', N'LuisRendon@gmail.com', N'Septiembre15', 1)
GO
INSERT [dbo].[Usuario] ([idUsuario], [nombre], [correo], [contrasenia], [status]) VALUES (3, N'Gerardo_Lopez', N'DeisiRamos09@gmail.com', N'LopezLopez', 0)
GO
INSERT [dbo].[Usuario] ([idUsuario], [nombre], [correo], [contrasenia], [status]) VALUES (7, N'Fernando_Orn', N'JACQUELINE9@GMAIL.COM', N'OrnelasFernando', 1)
GO
INSERT [dbo].[Usuario] ([idUsuario], [nombre], [correo], [contrasenia], [status]) VALUES (23, N'ANGELIQUE_10', N'ANGELIQUE10@GMAIL.COM', N'ANGELIQUE10@GMAIL.COM', 0)
GO
INSERT [dbo].[Usuario] ([idUsuario], [nombre], [correo], [contrasenia], [status]) VALUES (24, N'YAEL_ROSAS', N'YAELVARGASROSAS@GMAIL.COM', N'YAELVARGASROSAS@GMAIL.COM', 0)
GO
SET IDENTITY_INSERT [dbo].[Usuario] OFF
GO
SET IDENTITY_INSERT [dbo].[Venta] ON 
GO
INSERT [dbo].[Venta] ([idVenta], [idPersonaCliente], [idPersonaEmpleado], [subtotal], [iva], [total], [fecha], [status]) VALUES (1, 4, 1, CAST(55 AS Decimal(18, 0)), CAST(13 AS Decimal(18, 0)), CAST(68 AS Decimal(18, 0)), CAST(N'2021-05-10' AS Date), 1)
GO
INSERT [dbo].[Venta] ([idVenta], [idPersonaCliente], [idPersonaEmpleado], [subtotal], [iva], [total], [fecha], [status]) VALUES (2, 6, 2, CAST(100 AS Decimal(18, 0)), CAST(15 AS Decimal(18, 0)), CAST(115 AS Decimal(18, 0)), CAST(N'2021-05-11' AS Date), 1)
GO
INSERT [dbo].[Venta] ([idVenta], [idPersonaCliente], [idPersonaEmpleado], [subtotal], [iva], [total], [fecha], [status]) VALUES (3, 7, 3, CAST(50 AS Decimal(18, 0)), CAST(10 AS Decimal(18, 0)), CAST(60 AS Decimal(18, 0)), CAST(N'2021-05-12' AS Date), 0)
GO
INSERT [dbo].[Venta] ([idVenta], [idPersonaCliente], [idPersonaEmpleado], [subtotal], [iva], [total], [fecha], [status]) VALUES (4, 2, 3, CAST(100 AS Decimal(18, 0)), CAST(15 AS Decimal(18, 0)), CAST(115 AS Decimal(18, 0)), CAST(N'2021-05-11' AS Date), 1)
GO
INSERT [dbo].[Venta] ([idVenta], [idPersonaCliente], [idPersonaEmpleado], [subtotal], [iva], [total], [fecha], [status]) VALUES (5, 3, 1, CAST(50 AS Decimal(18, 0)), CAST(10 AS Decimal(18, 0)), CAST(60 AS Decimal(18, 0)), CAST(N'2021-05-12' AS Date), 1)
GO
INSERT [dbo].[Venta] ([idVenta], [idPersonaCliente], [idPersonaEmpleado], [subtotal], [iva], [total], [fecha], [status]) VALUES (6, 4, 3, CAST(122 AS Decimal(18, 0)), CAST(14 AS Decimal(18, 0)), CAST(136 AS Decimal(18, 0)), CAST(N'2021-06-03' AS Date), 0)
GO
INSERT [dbo].[Venta] ([idVenta], [idPersonaCliente], [idPersonaEmpleado], [subtotal], [iva], [total], [fecha], [status]) VALUES (7, 4, 2, CAST(100 AS Decimal(18, 0)), CAST(15 AS Decimal(18, 0)), CAST(115 AS Decimal(18, 0)), CAST(N'2021-06-03' AS Date), 1)
GO
INSERT [dbo].[Venta] ([idVenta], [idPersonaCliente], [idPersonaEmpleado], [subtotal], [iva], [total], [fecha], [status]) VALUES (15, 4, 1, CAST(30 AS Decimal(18, 0)), CAST(5 AS Decimal(18, 0)), CAST(35 AS Decimal(18, 0)), CAST(N'2021-07-13' AS Date), 1)
GO
INSERT [dbo].[Venta] ([idVenta], [idPersonaCliente], [idPersonaEmpleado], [subtotal], [iva], [total], [fecha], [status]) VALUES (16, 8, 1, CAST(30 AS Decimal(18, 0)), CAST(5 AS Decimal(18, 0)), CAST(35 AS Decimal(18, 0)), CAST(N'2021-07-13' AS Date), 1)
GO
INSERT [dbo].[Venta] ([idVenta], [idPersonaCliente], [idPersonaEmpleado], [subtotal], [iva], [total], [fecha], [status]) VALUES (17, 24, 1, CAST(30 AS Decimal(18, 0)), CAST(5 AS Decimal(18, 0)), CAST(35 AS Decimal(18, 0)), CAST(N'2021-07-13' AS Date), 1)
GO
INSERT [dbo].[Venta] ([idVenta], [idPersonaCliente], [idPersonaEmpleado], [subtotal], [iva], [total], [fecha], [status]) VALUES (18, 7, 1, CAST(30 AS Decimal(18, 0)), CAST(5 AS Decimal(18, 0)), CAST(35 AS Decimal(18, 0)), CAST(N'2021-07-14' AS Date), 1)
GO
SET IDENTITY_INSERT [dbo].[Venta] OFF
GO
SET IDENTITY_INSERT [dbo].[Venta_Auditado] ON 
GO
INSERT [dbo].[Venta_Auditado] ([id], [operacion], [usuario], [host], [modificado], [tabla]) VALUES (1, N'insert', N'DESKTOP-BKOIH1I\Jacquilin', N'DESKTOP-BKOIH1I', CAST(N'2021-06-30T17:34:11.193' AS DateTime), N'Venta')
GO
INSERT [dbo].[Venta_Auditado] ([id], [operacion], [usuario], [host], [modificado], [tabla]) VALUES (2, N'insert', N'DESKTOP-BKOIH1I\Jacquilin', N'DESKTOP-BKOIH1I', CAST(N'2021-06-30T17:34:11.250' AS DateTime), N'Venta')
GO
INSERT [dbo].[Venta_Auditado] ([id], [operacion], [usuario], [host], [modificado], [tabla]) VALUES (3, N'Update', N'DESKTOP-BKOIH1I\Jacquilin', N'DESKTOP-BKOIH1I', CAST(N'2021-06-30T17:53:01.367' AS DateTime), N'Venta')
GO
INSERT [dbo].[Venta_Auditado] ([id], [operacion], [usuario], [host], [modificado], [tabla]) VALUES (4, N'Update', N'DESKTOP-BKOIH1I\Jacquilin', N'DESKTOP-BKOIH1I', CAST(N'2021-06-30T17:53:01.370' AS DateTime), N'Venta')
GO
INSERT [dbo].[Venta_Auditado] ([id], [operacion], [usuario], [host], [modificado], [tabla]) VALUES (5, N'Update', N'DESKTOP-BKOIH1I\Jacquilin', N'DESKTOP-BKOIH1I', CAST(N'2021-06-30T18:12:26.260' AS DateTime), N'Venta')
GO
INSERT [dbo].[Venta_Auditado] ([id], [operacion], [usuario], [host], [modificado], [tabla]) VALUES (6, N'insert', N'DESKTOP-BKOIH1I\Jacquilin', N'DESKTOP-BKOIH1I', CAST(N'2021-06-30T18:20:30.440' AS DateTime), N'Venta')
GO
INSERT [dbo].[Venta_Auditado] ([id], [operacion], [usuario], [host], [modificado], [tabla]) VALUES (7, N'insert', N'DESKTOP-BKOIH1I\Jacquilin', N'DESKTOP-BKOIH1I', CAST(N'2021-06-30T18:20:30.443' AS DateTime), N'Venta')
GO
INSERT [dbo].[Venta_Auditado] ([id], [operacion], [usuario], [host], [modificado], [tabla]) VALUES (8, N'Delete', N'DESKTOP-BKOIH1I\Jacquilin', N'DESKTOP-BKOIH1I', CAST(N'2021-06-30T18:20:44.170' AS DateTime), N'Venta')
GO
INSERT [dbo].[Venta_Auditado] ([id], [operacion], [usuario], [host], [modificado], [tabla]) VALUES (9, N'Delete', N'sa', N'DESKTOP-BKOIH1I', CAST(N'2021-07-13T19:05:17.460' AS DateTime), N'Venta')
GO
INSERT [dbo].[Venta_Auditado] ([id], [operacion], [usuario], [host], [modificado], [tabla]) VALUES (10, N'insert', N'DESKTOP-BKOIH1I\Jacquilin', N'DESKTOP-BKOIH1I', CAST(N'2021-07-13T22:38:07.460' AS DateTime), N'Venta')
GO
INSERT [dbo].[Venta_Auditado] ([id], [operacion], [usuario], [host], [modificado], [tabla]) VALUES (11, N'insert', N'DESKTOP-BKOIH1I\Jacquilin', N'DESKTOP-BKOIH1I', CAST(N'2021-07-13T22:38:07.470' AS DateTime), N'Venta')
GO
INSERT [dbo].[Venta_Auditado] ([id], [operacion], [usuario], [host], [modificado], [tabla]) VALUES (12, N'Update', N'DESKTOP-BKOIH1I\Jacquilin', N'DESKTOP-BKOIH1I', CAST(N'2021-07-13T22:38:07.523' AS DateTime), N'Venta')
GO
INSERT [dbo].[Venta_Auditado] ([id], [operacion], [usuario], [host], [modificado], [tabla]) VALUES (13, N'Update', N'DESKTOP-BKOIH1I\Jacquilin', N'DESKTOP-BKOIH1I', CAST(N'2021-07-13T22:38:07.527' AS DateTime), N'Venta')
GO
INSERT [dbo].[Venta_Auditado] ([id], [operacion], [usuario], [host], [modificado], [tabla]) VALUES (14, N'insert', N'DESKTOP-BKOIH1I\Jacquilin', N'DESKTOP-BKOIH1I', CAST(N'2021-07-13T22:41:31.547' AS DateTime), N'Venta')
GO
INSERT [dbo].[Venta_Auditado] ([id], [operacion], [usuario], [host], [modificado], [tabla]) VALUES (15, N'insert', N'DESKTOP-BKOIH1I\Jacquilin', N'DESKTOP-BKOIH1I', CAST(N'2021-07-13T22:41:31.547' AS DateTime), N'Venta')
GO
INSERT [dbo].[Venta_Auditado] ([id], [operacion], [usuario], [host], [modificado], [tabla]) VALUES (16, N'Update', N'DESKTOP-BKOIH1I\Jacquilin', N'DESKTOP-BKOIH1I', CAST(N'2021-07-13T22:41:31.580' AS DateTime), N'Venta')
GO
INSERT [dbo].[Venta_Auditado] ([id], [operacion], [usuario], [host], [modificado], [tabla]) VALUES (17, N'Update', N'DESKTOP-BKOIH1I\Jacquilin', N'DESKTOP-BKOIH1I', CAST(N'2021-07-13T22:41:31.583' AS DateTime), N'Venta')
GO
INSERT [dbo].[Venta_Auditado] ([id], [operacion], [usuario], [host], [modificado], [tabla]) VALUES (18, N'insert', N'DESKTOP-BKOIH1I\Jacquilin', N'DESKTOP-BKOIH1I', CAST(N'2021-07-13T22:42:46.697' AS DateTime), N'Venta')
GO
INSERT [dbo].[Venta_Auditado] ([id], [operacion], [usuario], [host], [modificado], [tabla]) VALUES (19, N'insert', N'DESKTOP-BKOIH1I\Jacquilin', N'DESKTOP-BKOIH1I', CAST(N'2021-07-13T22:42:46.700' AS DateTime), N'Venta')
GO
INSERT [dbo].[Venta_Auditado] ([id], [operacion], [usuario], [host], [modificado], [tabla]) VALUES (20, N'Update', N'DESKTOP-BKOIH1I\Jacquilin', N'DESKTOP-BKOIH1I', CAST(N'2021-07-13T22:42:46.780' AS DateTime), N'Venta')
GO
INSERT [dbo].[Venta_Auditado] ([id], [operacion], [usuario], [host], [modificado], [tabla]) VALUES (21, N'Update', N'DESKTOP-BKOIH1I\Jacquilin', N'DESKTOP-BKOIH1I', CAST(N'2021-07-13T22:42:46.780' AS DateTime), N'Venta')
GO
INSERT [dbo].[Venta_Auditado] ([id], [operacion], [usuario], [host], [modificado], [tabla]) VALUES (22, N'insert', N'DESKTOP-BKOIH1I\Jacquilin', N'DESKTOP-BKOIH1I', CAST(N'2021-07-14T00:29:16.380' AS DateTime), N'Venta')
GO
INSERT [dbo].[Venta_Auditado] ([id], [operacion], [usuario], [host], [modificado], [tabla]) VALUES (23, N'insert', N'DESKTOP-BKOIH1I\Jacquilin', N'DESKTOP-BKOIH1I', CAST(N'2021-07-14T00:29:16.380' AS DateTime), N'Venta')
GO
INSERT [dbo].[Venta_Auditado] ([id], [operacion], [usuario], [host], [modificado], [tabla]) VALUES (24, N'Update', N'DESKTOP-BKOIH1I\Jacquilin', N'DESKTOP-BKOIH1I', CAST(N'2021-07-14T00:29:16.430' AS DateTime), N'Venta')
GO
INSERT [dbo].[Venta_Auditado] ([id], [operacion], [usuario], [host], [modificado], [tabla]) VALUES (25, N'Update', N'DESKTOP-BKOIH1I\Jacquilin', N'DESKTOP-BKOIH1I', CAST(N'2021-07-14T00:29:16.430' AS DateTime), N'Venta')
GO
SET IDENTITY_INSERT [dbo].[Venta_Auditado] OFF
GO
SET IDENTITY_INSERT [dbo].[Venta_Productos] ON 
GO
INSERT [dbo].[Venta_Productos] ([id], [operacion], [usuario], [host], [modificado], [tabla]) VALUES (8, N'insert', N'sa', N'DESKTOP-BKOIH1I', CAST(N'2021-06-03T15:13:36.497' AS DateTime), N'Venta')
GO
INSERT [dbo].[Venta_Productos] ([id], [operacion], [usuario], [host], [modificado], [tabla]) VALUES (9, N'Insert', N'DESKTOP-BKOIH1I\Jacquilin', N'DESKTOP-BKOIH1I', CAST(N'2021-06-30T12:06:50.197' AS DateTime), N'Empleado')
GO
INSERT [dbo].[Venta_Productos] ([id], [operacion], [usuario], [host], [modificado], [tabla]) VALUES (10, N'Insert', N'DESKTOP-BKOIH1I\Jacquilin', N'DESKTOP-BKOIH1I', CAST(N'2021-06-30T12:06:50.213' AS DateTime), N'Venta')
GO
INSERT [dbo].[Venta_Productos] ([id], [operacion], [usuario], [host], [modificado], [tabla]) VALUES (11, N'insert', N'DESKTOP-BKOIH1I\Jacquilin', N'DESKTOP-BKOIH1I', CAST(N'2021-06-30T12:06:50.217' AS DateTime), N'Venta')
GO
INSERT [dbo].[Venta_Productos] ([id], [operacion], [usuario], [host], [modificado], [tabla]) VALUES (12, N'insert', N'DESKTOP-BKOIH1I\Jacquilin', N'DESKTOP-BKOIH1I', CAST(N'2021-06-30T12:06:50.220' AS DateTime), N'Venta')
GO
INSERT [dbo].[Venta_Productos] ([id], [operacion], [usuario], [host], [modificado], [tabla]) VALUES (13, N'insert', N'DESKTOP-BKOIH1I\Jacquilin', N'DESKTOP-BKOIH1I', CAST(N'2021-06-30T12:06:50.220' AS DateTime), N'Venta')
GO
INSERT [dbo].[Venta_Productos] ([id], [operacion], [usuario], [host], [modificado], [tabla]) VALUES (14, N'Insert', N'DESKTOP-BKOIH1I\Jacquilin', N'DESKTOP-BKOIH1I', CAST(N'2021-06-30T12:25:55.220' AS DateTime), N'Empleado')
GO
INSERT [dbo].[Venta_Productos] ([id], [operacion], [usuario], [host], [modificado], [tabla]) VALUES (15, N'Insert', N'DESKTOP-BKOIH1I\Jacquilin', N'DESKTOP-BKOIH1I', CAST(N'2021-06-30T12:25:55.220' AS DateTime), N'Venta')
GO
INSERT [dbo].[Venta_Productos] ([id], [operacion], [usuario], [host], [modificado], [tabla]) VALUES (16, N'insert', N'DESKTOP-BKOIH1I\Jacquilin', N'DESKTOP-BKOIH1I', CAST(N'2021-06-30T12:25:55.220' AS DateTime), N'Venta')
GO
INSERT [dbo].[Venta_Productos] ([id], [operacion], [usuario], [host], [modificado], [tabla]) VALUES (17, N'insert', N'DESKTOP-BKOIH1I\Jacquilin', N'DESKTOP-BKOIH1I', CAST(N'2021-06-30T12:25:55.223' AS DateTime), N'Venta')
GO
INSERT [dbo].[Venta_Productos] ([id], [operacion], [usuario], [host], [modificado], [tabla]) VALUES (18, N'insert', N'DESKTOP-BKOIH1I\Jacquilin', N'DESKTOP-BKOIH1I', CAST(N'2021-06-30T12:25:55.223' AS DateTime), N'Venta')
GO
INSERT [dbo].[Venta_Productos] ([id], [operacion], [usuario], [host], [modificado], [tabla]) VALUES (19, N'Insert', N'DESKTOP-BKOIH1I\Jacquilin', N'DESKTOP-BKOIH1I', CAST(N'2021-06-30T15:23:12.437' AS DateTime), N'Empleado')
GO
INSERT [dbo].[Venta_Productos] ([id], [operacion], [usuario], [host], [modificado], [tabla]) VALUES (20, N'Insert', N'DESKTOP-BKOIH1I\Jacquilin', N'DESKTOP-BKOIH1I', CAST(N'2021-06-30T15:23:12.440' AS DateTime), N'Venta')
GO
INSERT [dbo].[Venta_Productos] ([id], [operacion], [usuario], [host], [modificado], [tabla]) VALUES (21, N'insert', N'DESKTOP-BKOIH1I\Jacquilin', N'DESKTOP-BKOIH1I', CAST(N'2021-06-30T15:23:12.440' AS DateTime), N'Venta')
GO
INSERT [dbo].[Venta_Productos] ([id], [operacion], [usuario], [host], [modificado], [tabla]) VALUES (22, N'insert', N'DESKTOP-BKOIH1I\Jacquilin', N'DESKTOP-BKOIH1I', CAST(N'2021-06-30T15:23:12.443' AS DateTime), N'Venta')
GO
INSERT [dbo].[Venta_Productos] ([id], [operacion], [usuario], [host], [modificado], [tabla]) VALUES (23, N'insert', N'DESKTOP-BKOIH1I\Jacquilin', N'DESKTOP-BKOIH1I', CAST(N'2021-06-30T15:23:12.443' AS DateTime), N'Venta')
GO
INSERT [dbo].[Venta_Productos] ([id], [operacion], [usuario], [host], [modificado], [tabla]) VALUES (24, N'Insert', N'DESKTOP-BKOIH1I\Jacquilin', N'DESKTOP-BKOIH1I', CAST(N'2021-06-30T17:34:11.250' AS DateTime), N'Empleado')
GO
INSERT [dbo].[Venta_Productos] ([id], [operacion], [usuario], [host], [modificado], [tabla]) VALUES (25, N'Insert', N'DESKTOP-BKOIH1I\Jacquilin', N'DESKTOP-BKOIH1I', CAST(N'2021-06-30T17:34:11.253' AS DateTime), N'Venta')
GO
INSERT [dbo].[Venta_Productos] ([id], [operacion], [usuario], [host], [modificado], [tabla]) VALUES (26, N'insert', N'DESKTOP-BKOIH1I\Jacquilin', N'DESKTOP-BKOIH1I', CAST(N'2021-06-30T17:34:11.253' AS DateTime), N'Venta')
GO
INSERT [dbo].[Venta_Productos] ([id], [operacion], [usuario], [host], [modificado], [tabla]) VALUES (27, N'insert', N'DESKTOP-BKOIH1I\Jacquilin', N'DESKTOP-BKOIH1I', CAST(N'2021-06-30T17:34:11.257' AS DateTime), N'Venta')
GO
INSERT [dbo].[Venta_Productos] ([id], [operacion], [usuario], [host], [modificado], [tabla]) VALUES (28, N'insert', N'DESKTOP-BKOIH1I\Jacquilin', N'DESKTOP-BKOIH1I', CAST(N'2021-06-30T17:34:11.257' AS DateTime), N'Venta')
GO
INSERT [dbo].[Venta_Productos] ([id], [operacion], [usuario], [host], [modificado], [tabla]) VALUES (29, N'Insert', N'DESKTOP-BKOIH1I\Jacquilin', N'DESKTOP-BKOIH1I', CAST(N'2021-06-30T18:20:30.443' AS DateTime), N'Empleado')
GO
INSERT [dbo].[Venta_Productos] ([id], [operacion], [usuario], [host], [modificado], [tabla]) VALUES (30, N'Insert', N'DESKTOP-BKOIH1I\Jacquilin', N'DESKTOP-BKOIH1I', CAST(N'2021-06-30T18:20:30.447' AS DateTime), N'Venta')
GO
INSERT [dbo].[Venta_Productos] ([id], [operacion], [usuario], [host], [modificado], [tabla]) VALUES (31, N'insert', N'DESKTOP-BKOIH1I\Jacquilin', N'DESKTOP-BKOIH1I', CAST(N'2021-06-30T18:20:30.447' AS DateTime), N'Venta')
GO
INSERT [dbo].[Venta_Productos] ([id], [operacion], [usuario], [host], [modificado], [tabla]) VALUES (32, N'insert', N'DESKTOP-BKOIH1I\Jacquilin', N'DESKTOP-BKOIH1I', CAST(N'2021-06-30T18:20:30.447' AS DateTime), N'Venta')
GO
INSERT [dbo].[Venta_Productos] ([id], [operacion], [usuario], [host], [modificado], [tabla]) VALUES (33, N'insert', N'DESKTOP-BKOIH1I\Jacquilin', N'DESKTOP-BKOIH1I', CAST(N'2021-06-30T18:20:30.450' AS DateTime), N'Venta')
GO
INSERT [dbo].[Venta_Productos] ([id], [operacion], [usuario], [host], [modificado], [tabla]) VALUES (34, N'Insert', N'DESKTOP-BKOIH1I\Jacquilin', N'DESKTOP-BKOIH1I', CAST(N'2021-07-13T22:38:07.473' AS DateTime), N'Empleado')
GO
INSERT [dbo].[Venta_Productos] ([id], [operacion], [usuario], [host], [modificado], [tabla]) VALUES (35, N'Insert', N'DESKTOP-BKOIH1I\Jacquilin', N'DESKTOP-BKOIH1I', CAST(N'2021-07-13T22:38:07.490' AS DateTime), N'Venta')
GO
INSERT [dbo].[Venta_Productos] ([id], [operacion], [usuario], [host], [modificado], [tabla]) VALUES (36, N'insert', N'DESKTOP-BKOIH1I\Jacquilin', N'DESKTOP-BKOIH1I', CAST(N'2021-07-13T22:38:07.490' AS DateTime), N'Venta')
GO
INSERT [dbo].[Venta_Productos] ([id], [operacion], [usuario], [host], [modificado], [tabla]) VALUES (37, N'insert', N'DESKTOP-BKOIH1I\Jacquilin', N'DESKTOP-BKOIH1I', CAST(N'2021-07-13T22:38:07.490' AS DateTime), N'Venta')
GO
INSERT [dbo].[Venta_Productos] ([id], [operacion], [usuario], [host], [modificado], [tabla]) VALUES (38, N'insert', N'DESKTOP-BKOIH1I\Jacquilin', N'DESKTOP-BKOIH1I', CAST(N'2021-07-13T22:38:07.490' AS DateTime), N'Venta')
GO
INSERT [dbo].[Venta_Productos] ([id], [operacion], [usuario], [host], [modificado], [tabla]) VALUES (39, N'Insert', N'DESKTOP-BKOIH1I\Jacquilin', N'DESKTOP-BKOIH1I', CAST(N'2021-07-13T22:41:31.550' AS DateTime), N'Empleado')
GO
INSERT [dbo].[Venta_Productos] ([id], [operacion], [usuario], [host], [modificado], [tabla]) VALUES (40, N'Insert', N'DESKTOP-BKOIH1I\Jacquilin', N'DESKTOP-BKOIH1I', CAST(N'2021-07-13T22:41:31.553' AS DateTime), N'Venta')
GO
INSERT [dbo].[Venta_Productos] ([id], [operacion], [usuario], [host], [modificado], [tabla]) VALUES (41, N'insert', N'DESKTOP-BKOIH1I\Jacquilin', N'DESKTOP-BKOIH1I', CAST(N'2021-07-13T22:41:31.553' AS DateTime), N'Venta')
GO
INSERT [dbo].[Venta_Productos] ([id], [operacion], [usuario], [host], [modificado], [tabla]) VALUES (42, N'insert', N'DESKTOP-BKOIH1I\Jacquilin', N'DESKTOP-BKOIH1I', CAST(N'2021-07-13T22:41:31.557' AS DateTime), N'Venta')
GO
INSERT [dbo].[Venta_Productos] ([id], [operacion], [usuario], [host], [modificado], [tabla]) VALUES (43, N'insert', N'DESKTOP-BKOIH1I\Jacquilin', N'DESKTOP-BKOIH1I', CAST(N'2021-07-13T22:41:31.557' AS DateTime), N'Venta')
GO
INSERT [dbo].[Venta_Productos] ([id], [operacion], [usuario], [host], [modificado], [tabla]) VALUES (44, N'Insert', N'DESKTOP-BKOIH1I\Jacquilin', N'DESKTOP-BKOIH1I', CAST(N'2021-07-13T22:42:46.700' AS DateTime), N'Empleado')
GO
INSERT [dbo].[Venta_Productos] ([id], [operacion], [usuario], [host], [modificado], [tabla]) VALUES (45, N'Insert', N'DESKTOP-BKOIH1I\Jacquilin', N'DESKTOP-BKOIH1I', CAST(N'2021-07-13T22:42:46.707' AS DateTime), N'Venta')
GO
INSERT [dbo].[Venta_Productos] ([id], [operacion], [usuario], [host], [modificado], [tabla]) VALUES (46, N'insert', N'DESKTOP-BKOIH1I\Jacquilin', N'DESKTOP-BKOIH1I', CAST(N'2021-07-13T22:42:46.710' AS DateTime), N'Venta')
GO
INSERT [dbo].[Venta_Productos] ([id], [operacion], [usuario], [host], [modificado], [tabla]) VALUES (47, N'insert', N'DESKTOP-BKOIH1I\Jacquilin', N'DESKTOP-BKOIH1I', CAST(N'2021-07-13T22:42:46.710' AS DateTime), N'Venta')
GO
INSERT [dbo].[Venta_Productos] ([id], [operacion], [usuario], [host], [modificado], [tabla]) VALUES (48, N'insert', N'DESKTOP-BKOIH1I\Jacquilin', N'DESKTOP-BKOIH1I', CAST(N'2021-07-13T22:42:46.713' AS DateTime), N'Venta')
GO
INSERT [dbo].[Venta_Productos] ([id], [operacion], [usuario], [host], [modificado], [tabla]) VALUES (49, N'Insert', N'DESKTOP-BKOIH1I\Jacquilin', N'DESKTOP-BKOIH1I', CAST(N'2021-07-14T00:29:16.383' AS DateTime), N'Empleado')
GO
INSERT [dbo].[Venta_Productos] ([id], [operacion], [usuario], [host], [modificado], [tabla]) VALUES (50, N'Insert', N'DESKTOP-BKOIH1I\Jacquilin', N'DESKTOP-BKOIH1I', CAST(N'2021-07-14T00:29:16.383' AS DateTime), N'Venta')
GO
INSERT [dbo].[Venta_Productos] ([id], [operacion], [usuario], [host], [modificado], [tabla]) VALUES (51, N'insert', N'DESKTOP-BKOIH1I\Jacquilin', N'DESKTOP-BKOIH1I', CAST(N'2021-07-14T00:29:16.387' AS DateTime), N'Venta')
GO
INSERT [dbo].[Venta_Productos] ([id], [operacion], [usuario], [host], [modificado], [tabla]) VALUES (52, N'insert', N'DESKTOP-BKOIH1I\Jacquilin', N'DESKTOP-BKOIH1I', CAST(N'2021-07-14T00:29:16.387' AS DateTime), N'Venta')
GO
INSERT [dbo].[Venta_Productos] ([id], [operacion], [usuario], [host], [modificado], [tabla]) VALUES (53, N'insert', N'DESKTOP-BKOIH1I\Jacquilin', N'DESKTOP-BKOIH1I', CAST(N'2021-07-14T00:29:16.390' AS DateTime), N'Venta')
GO
SET IDENTITY_INSERT [dbo].[Venta_Productos] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IDX_Calle]    Script Date: 14/07/2021 05:09:15 a. m. ******/
CREATE NONCLUSTERED INDEX [IDX_Calle] ON [dbo].[Calle]
(
	[nombre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [CK_Curp_Unica]    Script Date: 14/07/2021 05:09:15 a. m. ******/
ALTER TABLE [dbo].[Cliente] ADD  CONSTRAINT [CK_Curp_Unica] UNIQUE NONCLUSTERED 
(
	[curp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IDX_Colonia]    Script Date: 14/07/2021 05:09:15 a. m. ******/
CREATE NONCLUSTERED INDEX [IDX_Colonia] ON [dbo].[Colonia]
(
	[nombre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IDX_FechaCompra]    Script Date: 14/07/2021 05:09:15 a. m. ******/
CREATE NONCLUSTERED INDEX [IDX_FechaCompra] ON [dbo].[Compra]
(
	[fecha] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IDX_TotalCompra]    Script Date: 14/07/2021 05:09:15 a. m. ******/
CREATE NONCLUSTERED INDEX [IDX_TotalCompra] ON [dbo].[Compra]
(
	[total] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IDX_NombreDia]    Script Date: 14/07/2021 05:09:15 a. m. ******/
CREATE NONCLUSTERED INDEX [IDX_NombreDia] ON [dbo].[Dia]
(
	[nombre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IDX_Domicilio]    Script Date: 14/07/2021 05:09:15 a. m. ******/
CREATE NONCLUSTERED INDEX [IDX_Domicilio] ON [dbo].[Domicilio]
(
	[numeroExt] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [CK_RFC_Unico]    Script Date: 14/07/2021 05:09:15 a. m. ******/
ALTER TABLE [dbo].[Empleado] ADD  CONSTRAINT [CK_RFC_Unico] UNIQUE NONCLUSTERED 
(
	[rfc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IDX_Localidad]    Script Date: 14/07/2021 05:09:15 a. m. ******/
CREATE NONCLUSTERED INDEX [IDX_Localidad] ON [dbo].[Localidad]
(
	[nombre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IDX_Municipio]    Script Date: 14/07/2021 05:09:15 a. m. ******/
CREATE NONCLUSTERED INDEX [IDX_Municipio] ON [dbo].[Municipio]
(
	[nombre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IDX_PrecioPerdida]    Script Date: 14/07/2021 05:09:15 a. m. ******/
CREATE NONCLUSTERED INDEX [IDX_PrecioPerdida] ON [dbo].[Perdida]
(
	[precio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IDX_ApMaternoPersona]    Script Date: 14/07/2021 05:09:15 a. m. ******/
CREATE NONCLUSTERED INDEX [IDX_ApMaternoPersona] ON [dbo].[Persona]
(
	[apMaterno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IDX_ApPaternoPersona]    Script Date: 14/07/2021 05:09:15 a. m. ******/
CREATE NONCLUSTERED INDEX [IDX_ApPaternoPersona] ON [dbo].[Persona]
(
	[apPaterno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IDX_NombrePersona]    Script Date: 14/07/2021 05:09:15 a. m. ******/
CREATE NONCLUSTERED INDEX [IDX_NombrePersona] ON [dbo].[Persona]
(
	[nombre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IDX_ExistenciaProducto]    Script Date: 14/07/2021 05:09:15 a. m. ******/
CREATE NONCLUSTERED INDEX [IDX_ExistenciaProducto] ON [dbo].[Productos]
(
	[existencia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IDX_NombreProducto]    Script Date: 14/07/2021 05:09:15 a. m. ******/
CREATE NONCLUSTERED INDEX [IDX_NombreProducto] ON [dbo].[Productos]
(
	[nombre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IDX_PrecioProducto]    Script Date: 14/07/2021 05:09:15 a. m. ******/
CREATE NONCLUSTERED INDEX [IDX_PrecioProducto] ON [dbo].[Productos]
(
	[precio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IDX_NombreProveedor]    Script Date: 14/07/2021 05:09:15 a. m. ******/
CREATE NONCLUSTERED INDEX [IDX_NombreProveedor] ON [dbo].[Proveedor]
(
	[razonSocial] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IDX_NombrePuesto]    Script Date: 14/07/2021 05:09:15 a. m. ******/
CREATE NONCLUSTERED INDEX [IDX_NombrePuesto] ON [dbo].[Puesto]
(
	[nombre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IDX_NombreTipo]    Script Date: 14/07/2021 05:09:15 a. m. ******/
CREATE NONCLUSTERED INDEX [IDX_NombreTipo] ON [dbo].[Tipo]
(
	[nombre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IDX_NombreTurno]    Script Date: 14/07/2021 05:09:15 a. m. ******/
CREATE NONCLUSTERED INDEX [IDX_NombreTurno] ON [dbo].[Turno]
(
	[nombre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IDX_NombreUnidad]    Script Date: 14/07/2021 05:09:15 a. m. ******/
CREATE NONCLUSTERED INDEX [IDX_NombreUnidad] ON [dbo].[Unidad]
(
	[nombre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IDX_NombreUsuario]    Script Date: 14/07/2021 05:09:15 a. m. ******/
CREATE NONCLUSTERED INDEX [IDX_NombreUsuario] ON [dbo].[Usuario]
(
	[nombre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IDX_FechaVenta]    Script Date: 14/07/2021 05:09:15 a. m. ******/
CREATE NONCLUSTERED INDEX [IDX_FechaVenta] ON [dbo].[Venta]
(
	[fecha] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IDX_TotalVenta]    Script Date: 14/07/2021 05:09:15 a. m. ******/
CREATE NONCLUSTERED INDEX [IDX_TotalVenta] ON [dbo].[Venta]
(
	[total] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Compra_Auditado] ADD  DEFAULT (NULL) FOR [operacion]
GO
ALTER TABLE [dbo].[Compra_Auditado] ADD  DEFAULT (NULL) FOR [usuario]
GO
ALTER TABLE [dbo].[Compra_Auditado] ADD  DEFAULT (NULL) FOR [host]
GO
ALTER TABLE [dbo].[Compra_Auditado] ADD  DEFAULT (NULL) FOR [modificado]
GO
ALTER TABLE [dbo].[Venta_Auditado] ADD  DEFAULT (NULL) FOR [operacion]
GO
ALTER TABLE [dbo].[Venta_Auditado] ADD  DEFAULT (NULL) FOR [usuario]
GO
ALTER TABLE [dbo].[Venta_Auditado] ADD  DEFAULT (NULL) FOR [host]
GO
ALTER TABLE [dbo].[Venta_Auditado] ADD  DEFAULT (NULL) FOR [modificado]
GO
ALTER TABLE [dbo].[Venta_Productos] ADD  DEFAULT (NULL) FOR [operacion]
GO
ALTER TABLE [dbo].[Venta_Productos] ADD  DEFAULT (NULL) FOR [usuario]
GO
ALTER TABLE [dbo].[Venta_Productos] ADD  DEFAULT (NULL) FOR [host]
GO
ALTER TABLE [dbo].[Venta_Productos] ADD  DEFAULT (NULL) FOR [modificado]
GO
ALTER TABLE [dbo].[Calle]  WITH CHECK ADD  CONSTRAINT [FK_idColonia] FOREIGN KEY([idColonia])
REFERENCES [dbo].[Colonia] ([idColonia])
GO
ALTER TABLE [dbo].[Calle] CHECK CONSTRAINT [FK_idColonia]
GO
ALTER TABLE [dbo].[Calle]  WITH CHECK ADD  CONSTRAINT [FK_idDomicilio] FOREIGN KEY([idDomicilio])
REFERENCES [dbo].[Domicilio] ([idDomicilio])
GO
ALTER TABLE [dbo].[Calle] CHECK CONSTRAINT [FK_idDomicilio]
GO
ALTER TABLE [dbo].[Cliente]  WITH CHECK ADD  CONSTRAINT [FK_idPersonaCliente] FOREIGN KEY([idPersona])
REFERENCES [dbo].[Persona] ([idPersona])
GO
ALTER TABLE [dbo].[Cliente] CHECK CONSTRAINT [FK_idPersonaCliente]
GO
ALTER TABLE [dbo].[Colonia]  WITH CHECK ADD  CONSTRAINT [FK_idLocalidad] FOREIGN KEY([idLocalidad])
REFERENCES [dbo].[Localidad] ([idLocalidad])
GO
ALTER TABLE [dbo].[Colonia] CHECK CONSTRAINT [FK_idLocalidad]
GO
ALTER TABLE [dbo].[Compra]  WITH CHECK ADD  CONSTRAINT [FK_idCompraPersonaCliente] FOREIGN KEY([idProveedor])
REFERENCES [dbo].[Proveedor] ([idProveedor])
GO
ALTER TABLE [dbo].[Compra] CHECK CONSTRAINT [FK_idCompraPersonaCliente]
GO
ALTER TABLE [dbo].[Compra]  WITH CHECK ADD  CONSTRAINT [FK_idCompraPersonaEmpleado] FOREIGN KEY([idPersonaEmpleado])
REFERENCES [dbo].[Empleado] ([idPersona])
GO
ALTER TABLE [dbo].[Compra] CHECK CONSTRAINT [FK_idCompraPersonaEmpleado]
GO
ALTER TABLE [dbo].[Detalle_Compra_Productos]  WITH CHECK ADD  CONSTRAINT [FK_idCompraProducto] FOREIGN KEY([idCompra])
REFERENCES [dbo].[Compra] ([idCompra])
GO
ALTER TABLE [dbo].[Detalle_Compra_Productos] CHECK CONSTRAINT [FK_idCompraProducto]
GO
ALTER TABLE [dbo].[Detalle_Compra_Productos]  WITH CHECK ADD  CONSTRAINT [FK_idProductoCompra] FOREIGN KEY([idProducto])
REFERENCES [dbo].[Productos] ([idProducto])
GO
ALTER TABLE [dbo].[Detalle_Compra_Productos] CHECK CONSTRAINT [FK_idProductoCompra]
GO
ALTER TABLE [dbo].[Detalle_Puesto_Turno]  WITH CHECK ADD  CONSTRAINT [FK_idPuestoTurno] FOREIGN KEY([idPuesto])
REFERENCES [dbo].[Puesto] ([idPuesto])
GO
ALTER TABLE [dbo].[Detalle_Puesto_Turno] CHECK CONSTRAINT [FK_idPuestoTurno]
GO
ALTER TABLE [dbo].[Detalle_Puesto_Turno]  WITH CHECK ADD  CONSTRAINT [FK_idTurnoPuesto] FOREIGN KEY([idTurno])
REFERENCES [dbo].[Turno] ([idTurno])
GO
ALTER TABLE [dbo].[Detalle_Puesto_Turno] CHECK CONSTRAINT [FK_idTurnoPuesto]
GO
ALTER TABLE [dbo].[Detalle_Turno_Dia]  WITH CHECK ADD  CONSTRAINT [FK_idDiaTurno] FOREIGN KEY([idDia])
REFERENCES [dbo].[Dia] ([idDia])
GO
ALTER TABLE [dbo].[Detalle_Turno_Dia] CHECK CONSTRAINT [FK_idDiaTurno]
GO
ALTER TABLE [dbo].[Detalle_Turno_Dia]  WITH CHECK ADD  CONSTRAINT [FK_idTurnoDia] FOREIGN KEY([idTurno])
REFERENCES [dbo].[Turno] ([idTurno])
GO
ALTER TABLE [dbo].[Detalle_Turno_Dia] CHECK CONSTRAINT [FK_idTurnoDia]
GO
ALTER TABLE [dbo].[Detalle_Venta_Productos]  WITH CHECK ADD  CONSTRAINT [FK_idProductoVenta] FOREIGN KEY([idProducto])
REFERENCES [dbo].[Productos] ([idProducto])
GO
ALTER TABLE [dbo].[Detalle_Venta_Productos] CHECK CONSTRAINT [FK_idProductoVenta]
GO
ALTER TABLE [dbo].[Detalle_Venta_Productos]  WITH CHECK ADD  CONSTRAINT [FK_idVentaProducto] FOREIGN KEY([idVenta])
REFERENCES [dbo].[Venta] ([idVenta])
GO
ALTER TABLE [dbo].[Detalle_Venta_Productos] CHECK CONSTRAINT [FK_idVentaProducto]
GO
ALTER TABLE [dbo].[Empleado]  WITH CHECK ADD  CONSTRAINT [FK_idPersonaEmpleado] FOREIGN KEY([idPersona])
REFERENCES [dbo].[Persona] ([idPersona])
GO
ALTER TABLE [dbo].[Empleado] CHECK CONSTRAINT [FK_idPersonaEmpleado]
GO
ALTER TABLE [dbo].[Empleado]  WITH CHECK ADD  CONSTRAINT [FK_idPuesto] FOREIGN KEY([idPuesto])
REFERENCES [dbo].[Puesto] ([idPuesto])
GO
ALTER TABLE [dbo].[Empleado] CHECK CONSTRAINT [FK_idPuesto]
GO
ALTER TABLE [dbo].[Empleado]  WITH CHECK ADD  CONSTRAINT [FK_idUsuario] FOREIGN KEY([idUsuario])
REFERENCES [dbo].[Usuario] ([idUsuario])
GO
ALTER TABLE [dbo].[Empleado] CHECK CONSTRAINT [FK_idUsuario]
GO
ALTER TABLE [dbo].[Localidad]  WITH CHECK ADD  CONSTRAINT [FK_idMunicipio] FOREIGN KEY([idMunicipio])
REFERENCES [dbo].[Municipio] ([idMunicipio])
GO
ALTER TABLE [dbo].[Localidad] CHECK CONSTRAINT [FK_idMunicipio]
GO
ALTER TABLE [dbo].[Operaciones]  WITH CHECK ADD FOREIGN KEY([idModulo])
REFERENCES [dbo].[Modulo] ([idModulo])
GO
ALTER TABLE [dbo].[Operaciones]  WITH CHECK ADD  CONSTRAINT [FK_idModulo] FOREIGN KEY([idModulo])
REFERENCES [dbo].[Modulo] ([idModulo])
GO
ALTER TABLE [dbo].[Operaciones] CHECK CONSTRAINT [FK_idModulo]
GO
ALTER TABLE [dbo].[Perdida]  WITH CHECK ADD  CONSTRAINT [FK_idProducto] FOREIGN KEY([idProducto])
REFERENCES [dbo].[Productos] ([idProducto])
GO
ALTER TABLE [dbo].[Perdida] CHECK CONSTRAINT [FK_idProducto]
GO
ALTER TABLE [dbo].[Perfil_Operacion]  WITH CHECK ADD  CONSTRAINT [FK_idOperacionRol] FOREIGN KEY([idOperacion])
REFERENCES [dbo].[Operaciones] ([idOperacion])
GO
ALTER TABLE [dbo].[Perfil_Operacion] CHECK CONSTRAINT [FK_idOperacionRol]
GO
ALTER TABLE [dbo].[Perfil_Operacion]  WITH CHECK ADD  CONSTRAINT [FK_idRolOperacion] FOREIGN KEY([idRol])
REFERENCES [dbo].[Rol] ([idRol])
GO
ALTER TABLE [dbo].[Perfil_Operacion] CHECK CONSTRAINT [FK_idRolOperacion]
GO
ALTER TABLE [dbo].[Persona]  WITH CHECK ADD  CONSTRAINT [FK_idDomicilioPersona] FOREIGN KEY([idDomicilio])
REFERENCES [dbo].[Domicilio] ([idDomicilio])
GO
ALTER TABLE [dbo].[Persona] CHECK CONSTRAINT [FK_idDomicilioPersona]
GO
ALTER TABLE [dbo].[Proveedor]  WITH CHECK ADD  CONSTRAINT [FK_idDomicilioProveedor] FOREIGN KEY([idDomicilio])
REFERENCES [dbo].[Domicilio] ([idDomicilio])
GO
ALTER TABLE [dbo].[Proveedor] CHECK CONSTRAINT [FK_idDomicilioProveedor]
GO
ALTER TABLE [dbo].[Cliente]  WITH CHECK ADD  CONSTRAINT [CK_Curp] CHECK  (([Curp] like '[A-Z][A-Z][A-Z][A-Z][0-9][0-9][0-9][0-9][0-9][0-9][A-Z][A-Z][A-Z][A-Z][A-Z][A-Z][A-Z][0-9]'))
GO
ALTER TABLE [dbo].[Cliente] CHECK CONSTRAINT [CK_Curp]
GO
ALTER TABLE [dbo].[Compra]  WITH CHECK ADD  CONSTRAINT [CH_IvaCompra] CHECK  (([iva]>(0)))
GO
ALTER TABLE [dbo].[Compra] CHECK CONSTRAINT [CH_IvaCompra]
GO
ALTER TABLE [dbo].[Compra]  WITH CHECK ADD  CONSTRAINT [CH_SubtotalCompra] CHECK  (([subtotal]>(0)))
GO
ALTER TABLE [dbo].[Compra] CHECK CONSTRAINT [CH_SubtotalCompra]
GO
ALTER TABLE [dbo].[Compra]  WITH CHECK ADD  CONSTRAINT [CH_TotalCompra] CHECK  (([total]>(0)))
GO
ALTER TABLE [dbo].[Compra] CHECK CONSTRAINT [CH_TotalCompra]
GO
ALTER TABLE [dbo].[Detalle_Compra_Productos]  WITH CHECK ADD  CONSTRAINT [CH_CompraCantidad] CHECK  (([cantidad]>(0)))
GO
ALTER TABLE [dbo].[Detalle_Compra_Productos] CHECK CONSTRAINT [CH_CompraCantidad]
GO
ALTER TABLE [dbo].[Detalle_Compra_Productos]  WITH CHECK ADD  CONSTRAINT [CH_PrecioCompraProducto] CHECK  (([precio]>(0)))
GO
ALTER TABLE [dbo].[Detalle_Compra_Productos] CHECK CONSTRAINT [CH_PrecioCompraProducto]
GO
ALTER TABLE [dbo].[Detalle_Compra_Productos]  WITH CHECK ADD  CONSTRAINT [CH_SubtotalCompraProductos] CHECK  (([subtotal]>(0)))
GO
ALTER TABLE [dbo].[Detalle_Compra_Productos] CHECK CONSTRAINT [CH_SubtotalCompraProductos]
GO
ALTER TABLE [dbo].[Detalle_Venta_Productos]  WITH CHECK ADD  CONSTRAINT [CH_PrecioVentaProducto] CHECK  (([precio]>(0)))
GO
ALTER TABLE [dbo].[Detalle_Venta_Productos] CHECK CONSTRAINT [CH_PrecioVentaProducto]
GO
ALTER TABLE [dbo].[Detalle_Venta_Productos]  WITH CHECK ADD  CONSTRAINT [CH_SubtotalVentaProductos] CHECK  (([subtotal]>(0)))
GO
ALTER TABLE [dbo].[Detalle_Venta_Productos] CHECK CONSTRAINT [CH_SubtotalVentaProductos]
GO
ALTER TABLE [dbo].[Detalle_Venta_Productos]  WITH CHECK ADD  CONSTRAINT [CH_VentaProductosCantidad] CHECK  (([cantidad]>(0)))
GO
ALTER TABLE [dbo].[Detalle_Venta_Productos] CHECK CONSTRAINT [CH_VentaProductosCantidad]
GO
ALTER TABLE [dbo].[Empleado]  WITH CHECK ADD  CONSTRAINT [CK_RFC] CHECK  (([rfc] like '[A-Z][A-Z][A-Z][A-Z][0-9][0-9][0-9][0-9][0-9][0-9][A-Z][A-Z][0-9]'))
GO
ALTER TABLE [dbo].[Empleado] CHECK CONSTRAINT [CK_RFC]
GO
ALTER TABLE [dbo].[Perdida]  WITH CHECK ADD  CONSTRAINT [CH_Cantidad] CHECK  (([cantidad]>(0)))
GO
ALTER TABLE [dbo].[Perdida] CHECK CONSTRAINT [CH_Cantidad]
GO
ALTER TABLE [dbo].[Perdida]  WITH CHECK ADD  CONSTRAINT [CH_PrecioPerdida] CHECK  (([precio]>(0)))
GO
ALTER TABLE [dbo].[Perdida] CHECK CONSTRAINT [CH_PrecioPerdida]
GO
ALTER TABLE [dbo].[Perdida]  WITH CHECK ADD  CONSTRAINT [CK_FechaRegistro] CHECK  ((datediff(year,[fechaRegistro],getdate())<=(0) AND datediff(month,[fechaRegistro],getdate())<=(0) AND datediff(day,[fechaRegistro],getdate())<=(0)))
GO
ALTER TABLE [dbo].[Perdida] CHECK CONSTRAINT [CK_FechaRegistro]
GO
ALTER TABLE [dbo].[Persona]  WITH CHECK ADD  CONSTRAINT [CH_TelefonoPersona] CHECK  (([telefono] like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'))
GO
ALTER TABLE [dbo].[Persona] CHECK CONSTRAINT [CH_TelefonoPersona]
GO
ALTER TABLE [dbo].[Productos]  WITH CHECK ADD  CONSTRAINT [CH_ContenidoNeto] CHECK  (([contenidoNeto]>(0)))
GO
ALTER TABLE [dbo].[Productos] CHECK CONSTRAINT [CH_ContenidoNeto]
GO
ALTER TABLE [dbo].[Productos]  WITH CHECK ADD  CONSTRAINT [CH_Existencia] CHECK  (([Existencia]>=(0) AND [Existencia]<=(10)))
GO
ALTER TABLE [dbo].[Productos] CHECK CONSTRAINT [CH_Existencia]
GO
ALTER TABLE [dbo].[Productos]  WITH CHECK ADD  CONSTRAINT [CH_PrecioProducto] CHECK  (([precio]>(0)))
GO
ALTER TABLE [dbo].[Productos] CHECK CONSTRAINT [CH_PrecioProducto]
GO
ALTER TABLE [dbo].[Proveedor]  WITH CHECK ADD  CONSTRAINT [CH_TelefonoProveedor] CHECK  (([telefono] like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'))
GO
ALTER TABLE [dbo].[Proveedor] CHECK CONSTRAINT [CH_TelefonoProveedor]
GO
ALTER TABLE [dbo].[Puesto]  WITH CHECK ADD  CONSTRAINT [CH_Salario] CHECK  (([salario]>(0)))
GO
ALTER TABLE [dbo].[Puesto] CHECK CONSTRAINT [CH_Salario]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [CK_Correo01] CHECK  (([correo] like '[a-z,0-9,,-]%@[a-z,0-9,,-]%.[a-z]%'))
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [CK_Correo01]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [CK_Correo02] CHECK  ((NOT [correo] like '%[^a-z0-9@._-]%'))
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [CK_Correo02]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [CK_Correo03] CHECK  ((NOT [correo] like '%@%@%'))
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [CK_Correo03]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [CK_Correo04] CHECK  ((NOT [correo] like '%.@%'))
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [CK_Correo04]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [CK_Correo05] CHECK  ((NOT [correo] like '%..%'))
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [CK_Correo05]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [CK_Correo06] CHECK  ((NOT [correo] like '%.'))
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [CK_Correo06]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [CH_IvaVenta] CHECK  (([iva]>(0)))
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [CH_IvaVenta]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [CH_SubtotalVenta] CHECK  (([subtotal]>(0)))
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [CH_SubtotalVenta]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [CH_TotalVenta] CHECK  (([total]>(0)))
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [CH_TotalVenta]
GO
/****** Object:  StoredProcedure [dbo].[Proc_Producto]    Script Date: 14/07/2021 05:09:15 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[Proc_Producto]
(
  @idP int,
  @nombreP varchar (25)
)
AS 
BEGIN 

Select * from Productos
where idProducto = @idP and nombre = @nombreP 
print 'Los resultados fueron exitosos';

END
GO
/****** Object:  StoredProcedure [dbo].[PROC_Productos]    Script Date: 14/07/2021 05:09:15 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[PROC_Productos]
(
  @idP int,
  @nombreP varchar (25)
)
AS 
BEGIN 

Select * from Productos print 'Los resultados fueron exitosos';

END
GO
/****** Object:  StoredProcedure [dbo].[SP_ACTUALIZARPROVEEDOR]    Script Date: 14/07/2021 05:09:15 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_ACTUALIZARPROVEEDOR]
@IdProveedor INT,
@RazonSocial VARCHAR (25),
@Telefono VARCHAR (10),
@IdDomicilio INT
AS
UPDATE Proveedor SET razonSocial = @RazonSocial, telefono = @Telefono, idDomicilio = @IdDomicilio 
WHERE idProveedor = @IdProveedor
GO
/****** Object:  StoredProcedure [dbo].[SP_BUSCARPRODUCTO]    Script Date: 14/07/2021 05:09:15 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_BUSCARPRODUCTO]
@Nombre VARCHAR (25)
AS
SELECT Productos.nombre Nombre, Tipo.nombre as Tipo, Productos.precio as Precio, Productos.contenidoNeto as Contenido_Neto, Unidad.nombre as Nombre_Unidad, 
       Productos.existencia as Existencia, Productos.fechaCaducidad as Fecha_Caducidad,Productos.status as Status
FROM Productos INNER JOIN Tipo on Productos.idTipo = Tipo.idTipo 
               INNER JOIN Unidad on Productos.idUnidad = Unidad.idUnidad
WHERE Productos.nombre like '%' + @Nombre + '%'
GO
/****** Object:  StoredProcedure [dbo].[SP_BUSCARPRODUCTOPRECIO]    Script Date: 14/07/2021 05:09:15 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_BUSCARPRODUCTOPRECIO]
@Precio decimal
AS
SELECT Productos.precio as Precio, Productos.nombre Nombre, Tipo.nombre as Tipo,  contenidoNeto as Contenido_Neto, Unidad.nombre as Nombre_Unidad, 
       Productos.existencia as Existencia, Productos.fechaCaducidad as Fecha_Caducidad,Productos.status as Status
FROM Productos INNER JOIN Tipo on Productos.idTipo = Tipo.idTipo 
               INNER JOIN Unidad on Productos.idUnidad = Unidad.idUnidad
WHERE Productos.nombre like '%' + @Precio + '%'
GO
/****** Object:  StoredProcedure [dbo].[SP_BUSCARPROVEEDOR]    Script Date: 14/07/2021 05:09:15 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_BUSCARPROVEEDOR]
@RazonSocial VARCHAR (25)
AS
SELECT razonSocial as Razon_Social, telefono as Telefono, Municipio.nombre as Municipio, Localidad.nombre as Localidad, 
       Colonia.nombre as Colonia, Calle.nombre as Calle, numeroExt as Número_Exterior, numeroInt as Número_Interior, Proveedor.status as Status
FROM Proveedor INNER JOIN Domicilio on Proveedor.idDomicilio = Domicilio.idDomicilio
               INNER JOIN Calle on Calle.idDomicilio = Domicilio.idDomicilio
			   INNER JOIN Colonia on Calle.idColonia = Colonia.idColonia
			   INNER JOIN Localidad on Colonia.idLocalidad = Localidad.idLocalidad
			   INNER JOIN Municipio on Localidad.idMunicipio = Municipio.idMunicipio
WHERE Proveedor.razonSocial like '%' + @RazonSocial + '%'
GO
/****** Object:  StoredProcedure [dbo].[SP_BUSCARTIPOPRODUCTO]    Script Date: 14/07/2021 05:09:15 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_BUSCARTIPOPRODUCTO]
@Nombre VARCHAR (25)
AS
SELECT Tipo.nombre as Tipo, Productos.nombre Nombre, Productos.precio as Precio, Productos.contenidoNeto as Contenido_Neto, Unidad.nombre as Nombre_Unidad, 
       Productos.existencia as Existencia, Productos.fechaCaducidad as Fecha_Caducidad,Productos.status as Status
FROM Productos INNER JOIN Tipo on Productos.idTipo = Tipo.idTipo 
               INNER JOIN Unidad on Productos.idUnidad = Unidad.idUnidad
WHERE Productos.nombre like '%' + @Nombre + '%'
GO
/****** Object:  StoredProcedure [dbo].[SP_BUSCARUSUARIO]    Script Date: 14/07/2021 05:09:15 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_BUSCARUSUARIO]
@Nombre VARCHAR (30)
AS
SELECT idUsuario, nombre, correo, contrasenia, status
FROM Usuario
WHERE nombre like '%' + @Nombre + '%'
GO
/****** Object:  StoredProcedure [dbo].[Sp_BusquedaClientes]    Script Date: 14/07/2021 05:09:15 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[Sp_BusquedaClientes] -- Se crea el procedimiento llamado Sp_BusquedaClientes
   @nombreCliente varchar (25) --Se declara el parámetro de entrada llamado @nombreCliente
As
   Select nombre, apPaterno, apMaterno, fechaNac, telefono, curp, numeroExt, numeroInt  -- Se seleccionan los campos a mostrar
	from Persona INNER JOIN Cliente on Cliente.idPersona = Persona.idPersona 
	INNER JOIN Domicilio on Persona.idDomicilio = Domicilio.idDomicilio
   where nombre like '%'+ @nombreCliente +'%' --Se mostrará el nombre como el del parámetro de entrada @nombreCliente*/
GO
/****** Object:  StoredProcedure [dbo].[Sp_BusquedaProveedores]    Script Date: 14/07/2021 05:09:15 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*PROCEDIMIENTO ALMACENADO QUE BUSQUE UN PROVEEDOR POR RAZÓN SOCIAL*/
Create procedure [dbo].[Sp_BusquedaProveedores] -- Se crea el procedimiento llamado Sp_BusquedaClientes
   @razonSocial varchar (25) --Se declara el parámetro de entrada llamado @nombreCliente
As
   Select razonSocial, telefono, numeroExt, numeroInt -- Se seleccionan los campos a mostrar
	from Proveedor INNER JOIN Domicilio on Proveedor.idDomicilio = Domicilio.idDomicilio
   where razonSocial like '%'+ @razonSocial +'%' --Se mostrará la razonSocial como el del parámetro de entrada @razonSocial
GO
/****** Object:  StoredProcedure [dbo].[SP_INSERTARCIENTES]    Script Date: 14/07/2021 05:09:15 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_INSERTARCIENTES]
@Nombre VARCHAR (25),
@ApPaterno VARCHAR (25),
@ApMaterno VARCHAR (25),
@FechaNac datetime, 
@Telefono VARCHAR (10),
@IdDomicilio INT,
@CURP VARCHAR (18),
@Status BIT
AS
INSERT INTO Persona VALUES (@Nombre, @ApPaterno, @ApMaterno, @FechaNac, @Telefono, @IdDomicilio)
INSERT INTO Cliente VALUES (@@IDENTITY, @CURP, @Status)
GO
/****** Object:  StoredProcedure [dbo].[SP_INSERTARPRODUCTOS]    Script Date: 14/07/2021 05:09:15 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_INSERTARPRODUCTOS]
@Nombre VARCHAR (30),
@Precio DECIMAL,
@ContenidoNeto DECIMAL,
@IdUnidad INT,
@Existencia INT,  
@FechaCaducidad DATETIME,
@IdTipo INT,
@Status BIT
AS
INSERT INTO Productos values (@Nombre, @Precio, @ContenidoNeto, @IdUnidad, @Existencia, @FechaCaducidad, @IdTipo, @Status);
GO
/****** Object:  StoredProcedure [dbo].[SP_INSERTARPROVEEDORES]    Script Date: 14/07/2021 05:09:15 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_INSERTARPROVEEDORES]
@RazonSocial VARCHAR (25),
@Telefono VARCHAR (10),
@IdDomicilio Int,
@Status BIT
AS
INSERT INTO Proveedor VALUES (@RazonSocial, @Telefono, @IdDomicilio, @Status)
GO
/****** Object:  StoredProcedure [dbo].[SP_INSERTARTIPOPRODUCTO]    Script Date: 14/07/2021 05:09:15 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_INSERTARTIPOPRODUCTO]
@NombreTipo   VARCHAR (25),
@Descripcion  VARCHAR (100),
@Status BIT
AS
INSERT INTO Tipo VALUES (@NombreTipo, @Descripcion, @Status)
GO
/****** Object:  StoredProcedure [dbo].[SP_INSERTARUNIDADES]    Script Date: 14/07/2021 05:09:15 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_INSERTARUNIDADES]
@NombreUnidad  VARCHAR (25),
@Descripcion  VARCHAR (100),
@Status BIT
AS
INSERT INTO Tipo VALUES (@NombreUnidad, @Descripcion, @Status)
GO
/****** Object:  StoredProcedure [dbo].[SP_MOSTRARCLIENTE]    Script Date: 14/07/2021 05:09:15 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_MOSTRARCLIENTE]
AS
SELECT Cliente.idPersona, Persona.nombre as Nombre, Persona.apPaterno as Apellido_Paterno, Persona.apMaterno as Apellido_Materno, 
       Persona.fechaNac as Fecha_Nacimiento, Persona.telefono as Telefono, 
       Cliente.curp as CURP, Municipio.nombre as Municipio, Localidad.nombre as Localidad, 
       Colonia.nombre as Colonia, Calle.nombre as Calle, numeroExt as Número_Exterior, numeroInt as Número_Interior
FROM Persona INNER JOIN Cliente on Persona.idPersona = Cliente.idPersona 
             INNER JOIN Domicilio on Persona.idDomicilio = Domicilio.idDomicilio
               INNER JOIN Calle on Calle.idDomicilio = Domicilio.idDomicilio
			   INNER JOIN Colonia on Calle.idColonia = Colonia.idColonia
			   INNER JOIN Localidad on Colonia.idLocalidad = Localidad.idLocalidad
			   INNER JOIN Municipio on Localidad.idMunicipio = Municipio.idMunicipio
GO
/****** Object:  StoredProcedure [dbo].[SP_MOSTRARDETALLE]    Script Date: 14/07/2021 05:09:15 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_MOSTRARDETALLE]
AS
SELECT Venta.idVenta, Persona.nombre as Nombre_Cliente, Persona.nombre as Nombre_Empleado, Productos.nombre as Nombre_Producto, 
       Detalle_Venta_Productos.precio as Precio, Detalle_Venta_Productos.cantidad as Cantidad, Venta.subtotal as Subtotal, 
	   Venta.iva as IVA, Venta.total as Total
FROM Venta INNER JOIN Cliente on Venta.idPersonaCliente = Cliente.idPersona 
           INNER JOIN Empleado on  Venta.idPersonaEmpleado = Empleado.idPersona
		   INNER JOIN Persona on Persona.idPersona = Cliente.idPersona
           INNER JOIN Detalle_Venta_Productos on Venta.idVenta = Detalle_Venta_Productos.idVenta 
		   INNER JOIN Productos on Detalle_Venta_Productos.idProducto = Productos.idProducto
		   INNER JOIN Persona as Employee on Employee.idPersona = Empleado.idPersona
GO
/****** Object:  StoredProcedure [dbo].[SP_MOSTRARDVENTAPROCESO]    Script Date: 14/07/2021 05:09:15 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_MOSTRARDVENTAPROCESO] 
AS
SELECT Venta.idVenta, Persona.nombre as Nombre_Cliente, Persona.nombre as Nombre_Empleado, Productos.nombre as Nombre_Producto, 
       Detalle_Venta_Productos.precio as Precio, Detalle_Venta_Productos.cantidad as Cantidad, Venta.subtotal as Subtotal, 
	   Venta.iva as IVA, Venta.total as Total
FROM Venta INNER JOIN Cliente on Venta.idPersonaCliente = Cliente.idPersona 
           INNER JOIN Empleado on  Venta.idPersonaEmpleado = Empleado.idPersona
		   INNER JOIN Persona on Persona.idPersona = Cliente.idPersona
           INNER JOIN Detalle_Venta_Productos on Venta.idVenta = Detalle_Venta_Productos.idVenta 
		   INNER JOIN Productos on Detalle_Venta_Productos.idProducto = Productos.idProducto
		   INNER JOIN Persona as Employee on Employee.idPersona = Empleado.idPersona
WHERE Venta.idVenta = (select max(idVenta) from Venta)
GO
/****** Object:  StoredProcedure [dbo].[SP_MOSTRARPRODUCTOS]    Script Date: 14/07/2021 05:09:15 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_MOSTRARPRODUCTOS]
AS 
SELECT idProducto, Productos.nombre as Nombre, Tipo.nombre as Tipo, Productos.precio as Precio, Productos.contenidoNeto as Contenido_Neto, 
       Unidad.nombre as Unidad, Productos.existencia as Existencia, Productos.fechaCaducidad as Fecha_Caducidad, Productos.status as Status
FROM Productos INNER JOIN Tipo on Productos.idTipo = Tipo.idTipo 
               INNER JOIN Unidad on Productos.idUnidad = Unidad.idUnidad
GO
/****** Object:  StoredProcedure [dbo].[SP_MOSTRARPROVEEDORES]    Script Date: 14/07/2021 05:09:15 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_MOSTRARPROVEEDORES]
AS 
SELECT idProveedor, razonSocial as Razon_Social, telefono as Telefono, Municipio.nombre as Municipio, Localidad.nombre as Localidad, 
       Colonia.nombre as Colonia, Calle.nombre as Calle, numeroExt as Número_Exterior, numeroInt as Número_Interior, Proveedor.status as Status
FROM Proveedor INNER JOIN Domicilio on Proveedor.idDomicilio = Domicilio.idDomicilio
               INNER JOIN Calle on Calle.idDomicilio = Domicilio.idDomicilio
			   INNER JOIN Colonia on Calle.idColonia = Colonia.idColonia
			   INNER JOIN Localidad on Colonia.idLocalidad = Localidad.idLocalidad
			   INNER JOIN Municipio on Localidad.idMunicipio = Municipio.idMunicipio
GO
/****** Object:  StoredProcedure [dbo].[SP_MOSTRARTIPOPRODUCTO]    Script Date: 14/07/2021 05:09:15 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_MOSTRARTIPOPRODUCTO]
AS
SELECT idTipo, nombre, descripcion, status 
FROM Tipo
GO
/****** Object:  StoredProcedure [dbo].[SP_MOSTRARUSUARIOS]    Script Date: 14/07/2021 05:09:15 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_MOSTRARUSUARIOS]
AS 
SELECT idUsuario, nombre, correo, contrasenia, status 
FROM Usuario
GO
/****** Object:  StoredProcedure [dbo].[SP_MOSTRARVENTA]    Script Date: 14/07/2021 05:09:15 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_MOSTRARVENTA] 
AS
SELECT Venta.idVenta, Persona.nombre as Nombre_Cliente, Persona.nombre as Nombre_Empleado, Productos.nombre as Nombre_Producto, 
       Detalle_Venta_Productos.precio as Precio, Detalle_Venta_Productos.cantidad as Cantidad, Venta.subtotal as Subtotal, 
	   Venta.iva as IVA, Venta.total as Total
FROM Venta INNER JOIN Cliente on Venta.idPersonaCliente = Cliente.idPersona 
           INNER JOIN Empleado on  Venta.idPersonaEmpleado = Empleado.idPersona
		   INNER JOIN Persona on Persona.idPersona = Cliente.idPersona
           INNER JOIN Detalle_Venta_Productos on Venta.idVenta = Detalle_Venta_Productos.idVenta 
		   INNER JOIN Productos on Detalle_Venta_Productos.idProducto = Productos.idProducto
		   INNER JOIN Persona as Employee on Employee.idPersona = Empleado.idPersona
GO
/****** Object:  StoredProcedure [dbo].[SP_MOSTRARVENTAPROCESO]    Script Date: 14/07/2021 05:09:15 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_MOSTRARVENTAPROCESO] 
AS
SELECT Venta.idVenta, Persona.nombre as Nombre_Cliente, Persona.nombre as Nombre_Empleado, Productos.nombre as Nombre_Producto, 
       Detalle_Venta_Productos.precio as Precio, Detalle_Venta_Productos.cantidad as Cantidad, Venta.subtotal as Subtotal, 
	   Venta.iva as IVA, Venta.total as Total
FROM Venta INNER JOIN Cliente on Venta.idPersonaCliente = Cliente.idPersona 
           INNER JOIN Empleado on  Venta.idPersonaEmpleado = Empleado.idPersona
		   INNER JOIN Persona on Persona.idPersona = Cliente.idPersona
           INNER JOIN Detalle_Venta_Productos on Venta.idVenta = Detalle_Venta_Productos.idVenta 
		   INNER JOIN Productos on Detalle_Venta_Productos.idProducto = Productos.idProducto
		   INNER JOIN Persona as Employee on Employee.idPersona = Empleado.idPersona
WHERE Venta.idVenta = (select max(idVenta) from Venta)
GO
/****** Object:  StoredProcedure [dbo].[SP_MOSTRARVENTAS]    Script Date: 14/07/2021 05:09:15 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_MOSTRARVENTAS]
AS
SELECT Venta.idVenta, Detalle_Venta_Productos.idProducto, Detalle_Venta_Productos.precio, Detalle_Venta_Productos.cantidad, 
       Detalle_Venta_Productos.subtotal,Venta.iva, Venta.total, Venta.fecha
FROM Venta INNER JOIN Detalle_Venta_Productos on Venta.idVenta = Detalle_Venta_Productos.idVenta
GO
/****** Object:  StoredProcedure [dbo].[SP_MOSTRARVENTITAS]    Script Date: 14/07/2021 05:09:15 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_MOSTRARVENTITAS] 
AS
SELECT Venta.idVenta, Cliente.curp as CURP_Cliente, Empleado.rfc as RFC_Empleado, Productos.nombre as Nombre_Producto, 
       Detalle_Venta_Productos.precio as Precio, Detalle_Venta_Productos.cantidad as Cantidad, Venta.subtotal as Subtotal, 
	   Venta.iva as IVA, Venta.total as Total
FROM Venta INNER JOIN Cliente on Venta.idPersonaCliente = Cliente.idPersona 
           INNER JOIN Empleado on  Venta.idPersonaEmpleado = Empleado.idPersona
           INNER JOIN Detalle_Venta_Productos on Venta.idVenta = Detalle_Venta_Productos.idVenta 
		   INNER JOIN Productos on Detalle_Venta_Productos.idProducto = Productos.idProducto
GO
/****** Object:  StoredProcedure [dbo].[Sp_nuevoCliente]    Script Date: 14/07/2021 05:09:15 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*PROCEDIMIENTOS ALMACENADOS*/
CREATE procedure [dbo].[Sp_nuevoCliente] -- Se crea un procedimiento almacenado llamado sp_nuevoCliente*/

/*Las siguientes variables son para insertar los datos de la dirección*/
@nombreMunicipio varchar (30),
@nombreLocalidad varchar (30),
@nombreColonia   varchar (30),
@numExterior     varchar (5),
@numInterior     varchar (5),
@nombreCalle     varchar (30),

/*Las siguientes variables son para insertar los datos de la persona*/
@nombreCliente varchar (30),
@apPaterno varchar (20),
@apMaterno varchar (20),
@fechaNac date,
@telefono varchar (10),

/*Las siguientes variables son para insertar los datos del cliente*/
@curp varchar (18)

As

declare @Error int --Como se incluirá dentro del procedimiento una transacción, entonces se declara una variable de tipo entera llamada @Error
Begin tran --Se inicia la transacción
  
  --Se hace una inserción a las tablas que componen  la dirección y luego a la tabla Persona y al final a la tabla Cliente*/
  insert into Municipio values (@nombreMunicipio, 1)
  insert into Localidad values (@nombreLocalidad, @@IDENTITY, 1)
  insert into Colonia values (@nombreColonia, @@IDENTITY, 1)
  insert into Domicilio values (@numExterior, @numInterior, 1)
  insert into Calle values (@nombreCalle, @@IDENTITY, @@IDENTITY, 1)
  insert into Persona values (@nombreCliente, @apPaterno, @apMaterno, @fechaNac, @telefono, @@IDENTITY) --@@IDENTITY: devuelve el último ID, esto se necesita devido a que se necesita registrar en la tabla Persona el ID de la domicilio perteneciente al cliente
  insert into Cliente values (@@IDENTITY, @curp, 1) --@@IDENTITY se necesita registrar en la tabla Cliente el ID de la persona
		
   set @Error = @@ERROR  --Se le asigna a la variable Error el posible error que pueda resultar de las consultas anteriores
If(@Error <> 0) --Inicio del if
   begin --Inicia la sentencia dentro del if
   rollback tran --Si sí hay un error entonces aquí regresa a como estaba antes de la transacción
End --Fin del if
Else --Si no pasa lo que hay dentro del if
  commit --entonces el commit confirma las inserciones previas y las guarda de manera permanente en sus respectivas tablas
GO
/****** Object:  StoredProcedure [dbo].[Sp_nuevoEmpleado]    Script Date: 14/07/2021 05:09:15 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Sp_nuevoEmpleado] -- Se crea un procedimiento almacenado llamado sp_nuevoCliente*/

/*Las siguientes variables son para insertar los datos de la dirección*/
@nombreMunicipio varchar (30),
@nombreLocalidad varchar (30),
@nombreColonia   varchar (30),
@numExterior     varchar (5),
@numInterior     varchar (5),
@nombreCalle     varchar (30),

/*Las siguientes variables son para insertar los datos del usuario*/
@nombreUsuario   varchar (30),
@correo          varchar (50),
@contrasenia     varchar (50),

/*Las siguientes variables son para insertar los datos del puesto*/
@nombrePuesto    varchar (25),
@salario         int,
@descripcion     varchar (100),

/*Las siguientes variables son para insertar los datos de la persona*/
@nombreEmpleado varchar (25),
@apPaterno varchar (25),
@apMaterno varchar (25),
@fechaNac  date,
@telefono varchar (10),

/*Las siguientes variables son para insertar los datos del cliente*/
@idPersona int,
@idPuesto int,
@idUsuario int,
@idDomicilio int,
@rfc varchar (13)

As

declare @Error int --Como se incluirá dentro del procedimiento una transacción, entonces se declara una variable de tipo entera llamada @Error
Begin tran --Se inicia la transacción
  --Se hace una inserción a las tablas*/
  -- Los @@IDENTITY son para registrar el último id en la tabla que corresponde

  select @idPersona = @@IDENTITY
  select @idPuesto = @@IDENTITY
  select @idUsuario = @@IDENTITY
  select @idDomicilio = @@IDENTITY
  insert into Municipio values (@nombreMunicipio, 1);
  insert into Localidad values (@nombreLocalidad, @@IDENTITY, 1)
  insert into Colonia values (@nombreColonia, @@IDENTITY, 1)
  insert into Domicilio values (@numExterior, @numInterior, 1)
  insert into Calle values (@nombreCalle, @@IDENTITY, @@IDENTITY, 1)
  insert into Usuario values (@nombreUsuario, @correo, @contrasenia, 1)
  insert into Puesto values (@nombrePuesto, @salario, @descripcion, 1)
  insert into Persona values (@nombreEmpleado, @apPaterno, @apMaterno, @fechaNac, @telefono, @idDomicilio)
  insert into Empleado values (@idPersona, @idPuesto, @idUsuario, @rfc, 1)

   set @Error = @@ERROR  --Se le asigna a la variable Error el posible error que pueda resultar de las consultas anteriores
If(@Error <> 0) --Inicio del if
   begin --Inicia la sentencia dentro del if
   rollback tran --Si sí hay un error entonces aquí regresa a como estaba antes de la transacción
End --Fin del if
Else --Si no pasa lo que hay dentro del if
  commit --entonces el commit confirma las inserciones previas y las guarda de manera permanente en sus respectivas tablas
GO
/****** Object:  StoredProcedure [dbo].[Sp_nuevoProveedor]    Script Date: 14/07/2021 05:09:15 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[Sp_nuevoProveedor] -- Se crea un procedimiento almacenado llamado sp_nuevoCliente*/

/*Las siguientes variables son para insertar los datos de la dirección*/
@nombreMunicipio varchar (30),
@nombreLocalidad varchar (30),
@nombreColonia   varchar (30),
@numExterior     varchar (5),
@numInterior     varchar (5),
@nombreCalle     varchar (30),

/*Las siguientes variables son para insertar los datos de la tabla Proveedor*/
@razonSocial varchar (25),
@telefono varchar (10)

As

declare @Error int --Como se incluirá dentro del procedimiento una transacción, entonces se declara una variable de tipo entera llamada @Error
Begin tran --Se inicia la transacción
  
  --Se hace una inserción a las tablas que componen  la dirección y luego a la tabla Persona y al final a la tabla Cliente*/
  --Los @@IDENTITY devuelven el último valor del id
  insert into Municipio values (@nombreMunicipio, 1)
  insert into Localidad values (@nombreLocalidad, @@IDENTITY, 1)
  insert into Colonia values (@nombreColonia, @@IDENTITY, 1)
  insert into Domicilio values (@numExterior, @numInterior, 1)
  insert into Calle values (@nombreCalle, @@IDENTITY, @@IDENTITY, 1)
  insert into Proveedor values (@razonSocial, @telefono, @@IDENTITY, 1)
		
   set @Error = @@ERROR  --Se le asigna a la variable Error el posible error que pueda resultar de las consultas anteriores
If(@Error <> 0) --Inicio del if
   begin --Inicia la sentencia dentro del if
   rollback tran --Si sí hay un error entonces aquí regresa a como estaba antes de la transacción
End --Fin del if
Else --Si no pasa lo que hay dentro del if
  commit --entonces el commit confirma las inserciones previas y las guarda de manera permanente en sus respectivas tablas
GO
/****** Object:  StoredProcedure [dbo].[SP_Productos]    Script Date: 14/07/2021 05:09:15 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[SP_Productos]
(
  @idP int,
  @nombreP varchar (25),
  @precioP decimal,
  @contenidoNetoP decimal, 
  @idUnidadP int,
  @existenciaP int, 
  @fechaCaducidadP date, 
  @idTipoP int,
  @statusP bit
)
AS 
BEGIN 

Select * from Productos print 'Los resultados fueron exitosos';

END
GO
/****** Object:  StoredProcedure [dbo].[SP_REALIZARVENTA]    Script Date: 14/07/2021 05:09:15 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_REALIZARVENTA]
@IdProducto INT,
@Cantidad INT,
@IdEmpleado INT,
@IdCliente INT
AS
BEGIN
	DECLARE @IdVenta INT
	INSERT INTO Venta VALUES (@IdCliente, @IdEmpleado, 2 , 1, 4, GETDATE(), 1)

SET @IdVenta = SCOPE_IDENTITY()
	
	DECLARE @PrecioVenta FLOAT, @Subtotal FLOAT

SET @PrecioVenta = (select precio from Productos where idProducto = @IdProducto)
set @Subtotal = (@Cantidad * @PrecioVenta)

	INSERT into Detalle_Venta_Productos values (@IdVenta, @IdProducto , @PrecioVenta, @Cantidad, @Subtotal)

	DECLARE @Iva FLOAT

SET @Iva = (@Subtotal * .16)

	UPDATE Venta 
SET subtotal = @Subtotal, iva = @Iva, total = (@Subtotal + @Iva)
	WHERE idVenta = @IdVenta

If(@@error<>0)
begin
   rollback tran
end

end

GO
/****** Object:  StoredProcedure [dbo].[SP_ReporteCompras]    Script Date: 14/07/2021 05:09:15 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_ReporteCompras]
AS 
SELECT Productos.nombre as nombreProducto, Proveedor.razonSocial as nombreProveedor, Compra.subtotal, Compra.iva, Compra.total, Compra.fecha, Detalle_Compra_Productos.cantidad
FROM Compra INNER JOIN Detalle_Compra_Productos on Compra.idCompra = Detalle_Compra_Productos.idCompra
            INNER JOIN Productos on Detalle_Compra_Productos.idProducto = Productos.idProducto
		    INNER JOIN Proveedor on Proveedor.idProveedor = Compra.idProveedor
order by Productos.nombre
GO
/****** Object:  StoredProcedure [dbo].[SP_ReporteVenta]    Script Date: 14/07/2021 05:09:15 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_ReporteVenta] 
@fechaInicio DATE, 
@fechaFin DATE 
AS 
SELECT Productos.nombre, Persona.nombre, Venta.subtotal, Venta.iva, Venta.total, Venta.fecha, Detalle_Venta_Productos.cantidad
FROM Venta INNER JOIN Detalle_Venta_Productos on Venta.idVenta = Detalle_Venta_Productos.idVenta
            INNER JOIN Productos on Detalle_Venta_Productos.idProducto = Productos.idProducto
			INNER JOIN Persona on Persona.idPersona = Venta.idPersonaCliente
WHERE (Venta.fecha between @fechaInicio and @fechaFin)
order by Productos.nombre
GO
/****** Object:  StoredProcedure [dbo].[SP_ReporteVentas]    Script Date: 14/07/2021 05:09:15 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_ReporteVentas]
@fechaInicio DATE, 
@fechaFin DATE 
AS 
SELECT Productos.nombre as nombreProducto, Persona.nombre as nombreCliente, Venta.subtotal, Venta.iva, Venta.total, Venta.fecha, Detalle_Venta_Productos.cantidad
FROM Venta INNER JOIN Detalle_Venta_Productos on Venta.idVenta = Detalle_Venta_Productos.idVenta
            INNER JOIN Productos on Detalle_Venta_Productos.idProducto = Productos.idProducto
			INNER JOIN Persona on Persona.idPersona = Venta.idPersonaCliente
--WHERE (Venta.fecha between @fechaInicio and @fechaFin)
order by Productos.nombre
GO
/****** Object:  StoredProcedure [dbo].[SP_SELECCIONARTIPOPRODUCTO]    Script Date: 14/07/2021 05:09:15 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_SELECCIONARTIPOPRODUCTO]
AS
SELECT idTipo, nombre
FROM Tipo order by nombre asc 
GO
/****** Object:  StoredProcedure [dbo].[SP_USUARIOS]    Script Date: 14/07/2021 05:09:15 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_USUARIOS] 
@nombreUser VARCHAR (30),
@Contrasenia VARCHAR (50)
AS 
SELECT Persona.idPersona, Concat (Persona.nombre, + ' ', Persona.apPaterno, + ' ', Persona.apMaterno) as Nombre, idPuesto
FROM Persona INNER JOIN Empleado on Persona.idPersona = Empleado.idPersona
             INNER JOIN Usuario on Empleado.idUsuario = Usuario.idUsuario
Where Usuario.nombre = @nombreUser and Usuario.contrasenia = @Contrasenia
GO
/****** Object:  StoredProcedure [dbo].[SP_VENTAMOSTRARCLIENTE]    Script Date: 14/07/2021 05:09:15 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_VENTAMOSTRARCLIENTE]
AS 
SELECT Persona.idPersona, Persona.nombre as Nombre, Persona.apPaterno as Apellido_Paterno, 
       Persona.apMaterno as Apellido_Materno, Cliente.curp as Cliente, Cliente.status as Status
FROM Persona INNER JOIN Cliente on Persona.idPersona = Cliente.idPersona
GO
/****** Object:  Trigger [dbo].[Tr_Compra_Delete]    Script Date: 14/07/2021 05:09:15 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE trigger [dbo].[Tr_Compra_Delete]
on [dbo].[Compra]
after Delete
as
begin
  insert into Compra_Auditado (host, usuario, operacion, modificado, tabla)
         values (@@SERVERNAME, SUSER_NAME(), 'Delete', getdate(), 'Compra');
end
GO
ALTER TABLE [dbo].[Compra] ENABLE TRIGGER [Tr_Compra_Delete]
GO
/****** Object:  Trigger [dbo].[Tr_Compra_Insert]    Script Date: 14/07/2021 05:09:16 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE trigger [dbo].[Tr_Compra_Insert]
on [dbo].[Compra]
after insert 
as 
begin 
  insert into Compra_Auditado (host, usuario, operacion, modificado, tabla)
         values (@@SERVERNAME, SUSER_NAME(), 'insert', GETDATE(), 'Compra');
End
GO
ALTER TABLE [dbo].[Compra] ENABLE TRIGGER [Tr_Compra_Insert]
GO
/****** Object:  Trigger [dbo].[Tr_Compra_Update]    Script Date: 14/07/2021 05:09:16 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE trigger [dbo].[Tr_Compra_Update]
on [dbo].[Compra]
after Update
as
begin
  insert into Compra_Auditado (host, usuario, operacion, modificado, tabla)
         values (@@SERVERNAME, SUSER_NAME(), 'Update', getdate(), 'Compra');
end
GO
ALTER TABLE [dbo].[Compra] ENABLE TRIGGER [Tr_Compra_Update]
GO
/****** Object:  Trigger [dbo].[Tr_Aumentar_Existencia]    Script Date: 14/07/2021 05:09:16 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Trigger [dbo].[Tr_Aumentar_Existencia] --Se crea el trigger 
On [dbo].[Detalle_Compra_Productos] --Se hace mención de la tabla sobre la que se utilizará
After insert --Se activará el disparador después de que se relice una inserción en la tabla Detalle_Venta_Productos
As
Begin --Se inicia el control de lo que pasará después de la inserción
  declare @idProducto int --Se declará la variable que guardará el id del producto que se ha vendido
 select  @idProducto = inserted.idProducto from inserted --Se utiliza la tabla inserted
  declare @nombreProducto varchar (20) --Se declará la variable que guardará el nombre del producto que se ha vendido
  set @nombreProducto = (select nombre from Productos where idProducto = @idProducto) --Se le asigna el nombre a la variable
  Update Productos --Se actualiza la existencia del producto	
  set existencia = existencia + inserted.cantidad
  from Productos INNER JOIN inserted on Productos.idProducto = inserted.idProducto
  print ('Ha aumentado la existencia del producto ' + @nombreProducto) --Se muestra el producto al cual se le aumentara la existencia 
  declare @existencia int   --Se declará la variable que guardará la cantidad del producto vendido
  select @existencia = existencia from Productos INNER JOIN inserted on Productos.idProducto = inserted.idProducto --Se le asigna el valor a la variable
  where Productos.idProducto = inserted.idProducto 
If (@existencia >= 10) --If para verificar si la cantidad del producto esta completa
  print ('La existencia del producto se ha completado, se cuenta con: ' + cast (@existencia as char(2)) + 'unidades' ) --Muestra de mensaje en caso de que la existencia del producto se complete
End --Fin del trigger
GO
ALTER TABLE [dbo].[Detalle_Compra_Productos] ENABLE TRIGGER [Tr_Aumentar_Existencia]
GO
/****** Object:  Trigger [dbo].[Tr_Cancelar_ProductoCompra]    Script Date: 14/07/2021 05:09:16 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Trigger [dbo].[Tr_Cancelar_ProductoCompra] --Se crea el trigger 
On [dbo].[Detalle_Compra_Productos] --Se hace mención de la tabla sobre la que se utilizará
After delete --Se activará el disparador después de que se relice una eliminación en la tabla Detalle_Compra_Productos
As
Begin --Se inicia el control de lo que pasará después de la eliminación
  declare @idProducto int, @cantidadCancelada int --Se declará la variable que guardará el id del producto que se ha vendido y otra que guardará la cantidad que se cancela de la venta
  select  @idProducto = deleted.idProducto, @cantidadCancelada = deleted.cantidad --Se utiliza la tabla deleted
  from deleted						
  Update Productos --Se actualiza la existencia del producto
  set existencia = existencia - @cantidadCancelada				
  where idProducto = @idProducto							
  declare @nombreProducto varchar (20) --Se declara la variable que guardará el nombre del producto cancelado
  set @nombreProducto = (select nombre from Productos where idProducto = @idProducto) --Se asigna el nombre a la variable
  print ('Se actualizó la existencia del producto ' + @nombreProducto) --Se muestra el producto al cual se le aumentara la existencia 			 
  print ('Se disminuyerón: ' + cast(@cantidadCancelada as char(2)) + 'unidades' ) --Se muestra la cantidad de productos que se cancelaron 
End--Fin del trigger   
GO
ALTER TABLE [dbo].[Detalle_Compra_Productos] ENABLE TRIGGER [Tr_Cancelar_ProductoCompra]
GO
/****** Object:  Trigger [dbo].[Tr_Cancelar_Producto]    Script Date: 14/07/2021 05:09:16 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Trigger [dbo].[Tr_Cancelar_Producto] --Se crea el trigger 
On [dbo].[Detalle_Venta_Productos] --Se hace mención de la tabla sobre la que se utilizará
After delete --Se activará el disparador después de que se relice una eliminación en la tabla Detalle_Venta_Productos
As
Begin --Se inicia el control de lo que pasará después de la eliminación
  declare @idProducto int, @cantidadCancelada int --Se declará la variable que guardará el id del producto que se ha vendido y otra que guardará la cantidad que se cancela de la venta
  select  @idProducto = deleted.idProducto, @cantidadCancelada = deleted.cantidad --Se utiliza la tabla deleted
  from deleted						
  Update Productos --Se actualiza la existencia del producto
  set existencia = existencia + @cantidadCancelada				
  where idProducto = @idProducto							
  declare @nombreProducto varchar (20) --Se declara la variable que guardará el nombre del producto cancelado
  set @nombreProducto = (select nombre from Productos where idProducto = @idProducto) --Se asigna el nombre a la variable
  print ('Se actualizó la existencia del producto ' + @nombreProducto) --Se muestra el producto al cual se le aumentara la existencia 			 
  print ('Se agregaron: ' + cast(@cantidadCancelada as char(2)) + 'unidades' ) --Se muestra la cantidad de productos que se cancelaron 
End--Fin del trigger  
GO
ALTER TABLE [dbo].[Detalle_Venta_Productos] ENABLE TRIGGER [Tr_Cancelar_Producto]
GO
/****** Object:  Trigger [dbo].[Tr_Disminuir_Existencia]    Script Date: 14/07/2021 05:09:16 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Trigger [dbo].[Tr_Disminuir_Existencia] --Creación del trigger
On [dbo].[Detalle_Venta_Productos]  --Se hace mención de la tabla sobre la que se utilizará
After insert --Se activará el disparador después de que se relice una inserción en la tabla Detalle_Venta_Productos
As
Begin  --Se inicia el control de lo que pasará después de la inserción
  declare @idProducto int, --Se declaran las variables que se utilizarán para llevar acabo la actualización de la existencia
          @cantidadVendida int 
  select -- Selección de las variables dándoles un valor 	
		@idProducto = inserted.idProducto,  --Uso de la tabla Inserted para almacenar los datos insertados
		@cantidadVendida = inserted.cantidad		
  from inserted												
If (@cantidadVendida <= (select existencia from Productos where idProducto = @idProducto)) --If para verificar que si están los productos que se necesitan
Begin --Inicio del if
  declare @nombreProducto varchar (14) --Se declará la variable que guardará el nombre del producto que se ha vendido
  set @nombreProducto = (select nombre from Productos where idProducto = @idProducto) --Se le asigna el nombre a la variable
Update Productos --Se actualiza la existencia del producto					
  set existencia = existencia - @cantidadVendida	
  where idProducto = @idProducto
  print ('Ha disminuido la existencia del producto ' + @nombreProducto) --Se muestra el producto al cual se le disminuyó la existencia
  declare @existencia int   --Se declará la variable que guardará la cantidad del producto vendido
  select @existencia = existencia from Productos INNER JOIN inserted on Productos.idProducto = inserted.idProducto 
  where Productos.idProducto = inserted.idProducto --Se le asigna el a la variable
If (@existencia <= 5) --If para verificar si la cantidad del producto es baja
  print ('La existencia del producto es baja, se cuenta con: ' + cast (@existencia as char(2)) + 'unidades' ) --Muestra de mensaje en caso de que la existencia del producto si sea baja
End --Fin del if que verifica que si están los productos necesarios
Else --Else de if que verifica si están los productos necesarios
Begin --Inicio del else
  raiserror ('Hay menos productos en existencias que los solicitados en la venta', 16, 1) --Muestra el error
  rollback transaction --Regresa la transacción a como estaba antes de la ejecución
End --Fin del else
End --Fin del trigger   
GO
ALTER TABLE [dbo].[Detalle_Venta_Productos] ENABLE TRIGGER [Tr_Disminuir_Existencia]
GO
/****** Object:  Trigger [dbo].[Tr_veenta]    Script Date: 14/07/2021 05:09:16 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Trigger [dbo].[Tr_veenta]
On [dbo].[Venta] 
after insert 
As 
Begin
insert into Venta_Productos (host, usuario, operacion, modificado, tabla) 
       values (@@SERVERNAME, SUSER_NAME(), 'insert', getdate(), 'Venta');

END
GO
ALTER TABLE [dbo].[Venta] ENABLE TRIGGER [Tr_veenta]
GO
/****** Object:  Trigger [dbo].[Tr_vent]    Script Date: 14/07/2021 05:09:16 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Trigger [dbo].[Tr_vent]
On [dbo].[Venta] 
after insert 
As 
Begin
insert into Venta_Productos (host, usuario, operacion, modificado, tabla) 
       values (@@SERVERNAME, SUSER_NAME(), 'insert', getdate(), 'Venta');

END
GO
ALTER TABLE [dbo].[Venta] ENABLE TRIGGER [Tr_vent]
GO
/****** Object:  Trigger [dbo].[TR_Venta]    Script Date: 14/07/2021 05:09:16 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Trigger [dbo].[TR_Venta] 
On [dbo].[Venta] 
after insert 
As 
Begin
insert into Venta_Productos (host, usuario, operacion, modificado, tabla) 
       values (@@SERVERNAME, SUSER_NAME(), 'Insert', getdate(), 'Empleado');

END
GO
ALTER TABLE [dbo].[Venta] ENABLE TRIGGER [TR_Venta]
GO
/****** Object:  Trigger [dbo].[Tr_Venta_Delete]    Script Date: 14/07/2021 05:09:16 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE trigger [dbo].[Tr_Venta_Delete]
on [dbo].[Venta]
after Delete
as
begin
  insert into Venta_Auditado (host, usuario, operacion, modificado, tabla)
         values (@@SERVERNAME, SUSER_NAME(), 'Delete', getdate(), 'Venta');
end
GO
ALTER TABLE [dbo].[Venta] ENABLE TRIGGER [Tr_Venta_Delete]
GO
/****** Object:  Trigger [dbo].[Tr_Venta_Insert]    Script Date: 14/07/2021 05:09:16 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create trigger [dbo].[Tr_Venta_Insert]
on [dbo].[Venta]
after insert 
as 
begin 
  insert into Venta_Auditado (host, usuario, operacion, modificado, tabla)
         values (@@SERVERNAME, SUSER_NAME(), 'insert', GETDATE(), 'Venta');
end 
GO
ALTER TABLE [dbo].[Venta] ENABLE TRIGGER [Tr_Venta_Insert]
GO
/****** Object:  Trigger [dbo].[Tr_Venta_Update]    Script Date: 14/07/2021 05:09:16 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE trigger [dbo].[Tr_Venta_Update]
on [dbo].[Venta]
after Update
as
begin
  insert into Venta_Auditado (host, usuario, operacion, modificado, tabla)
         values (@@SERVERNAME, SUSER_NAME(), 'Update', getdate(), 'Venta');
end
GO
ALTER TABLE [dbo].[Venta] ENABLE TRIGGER [Tr_Venta_Update]
GO
/****** Object:  Trigger [dbo].[Tr_Venta_Updatei]    Script Date: 14/07/2021 05:09:16 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create trigger [dbo].[Tr_Venta_Updatei]
on [dbo].[Venta]
after Update
as
begin
  insert into Venta_Auditado (host, usuario, operacion, modificado, tabla)
         values (@@SERVERNAME, SUSER_NAME(), 'Update', getdate(), 'Venta');
end
GO
ALTER TABLE [dbo].[Venta] ENABLE TRIGGER [Tr_Venta_Updatei]
GO
/****** Object:  Trigger [dbo].[Tr_Venta1]    Script Date: 14/07/2021 05:09:16 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create trigger [dbo].[Tr_Venta1]
on [dbo].[Venta]
after insert 
as 
begin 
  insert into Venta_Auditado (host, usuario, operacion, modificado, tabla)
         values (@@SERVERNAME, SUSER_NAME(), 'insert', GETDATE(), 'Venta');
end 
GO
ALTER TABLE [dbo].[Venta] ENABLE TRIGGER [Tr_Venta1]
GO
/****** Object:  Trigger [dbo].[TR_ventas]    Script Date: 14/07/2021 05:09:16 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Trigger [dbo].[TR_ventas] 
On [dbo].[Venta] 
after insert 
As 
Begin
insert into Venta_Productos (host, usuario, operacion, modificado, tabla) 
       values (@@SERVERNAME, SUSER_NAME(), 'Insert', getdate(), 'Venta');

END
GO
ALTER TABLE [dbo].[Venta] ENABLE TRIGGER [TR_ventas]
GO
/****** Object:  Trigger [dbo].[TR_ventass]    Script Date: 14/07/2021 05:09:16 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Trigger [dbo].[TR_ventass] 
On [dbo].[Venta] 
after insert 
As 
Begin
insert into Venta_Productos (host, usuario, operacion, modificado, tabla) 
       values (@@SERVERNAME, SUSER_NAME(), 'insert', getdate(), 'Venta');

END
GO
ALTER TABLE [dbo].[Venta] ENABLE TRIGGER [TR_ventass]
GO
USE [master]
GO
ALTER DATABASE [Punto_Venta_Abarrotes] SET  READ_WRITE 
GO
