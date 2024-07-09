USE [master]
GO
/****** Object:  Database [FaturamentoFornecedores]    Script Date: 09/07/2024 16:18:29 ******/
CREATE DATABASE [FaturamentoFornecedores]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'FaturamentoFornecedores', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\FaturamentoFornecedores.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'FaturamentoFornecedores_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\FaturamentoFornecedores_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [FaturamentoFornecedores] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [FaturamentoFornecedores].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [FaturamentoFornecedores] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [FaturamentoFornecedores] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [FaturamentoFornecedores] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [FaturamentoFornecedores] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [FaturamentoFornecedores] SET ARITHABORT OFF 
GO
ALTER DATABASE [FaturamentoFornecedores] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [FaturamentoFornecedores] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [FaturamentoFornecedores] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [FaturamentoFornecedores] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [FaturamentoFornecedores] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [FaturamentoFornecedores] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [FaturamentoFornecedores] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [FaturamentoFornecedores] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [FaturamentoFornecedores] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [FaturamentoFornecedores] SET  ENABLE_BROKER 
GO
ALTER DATABASE [FaturamentoFornecedores] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [FaturamentoFornecedores] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [FaturamentoFornecedores] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [FaturamentoFornecedores] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [FaturamentoFornecedores] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [FaturamentoFornecedores] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [FaturamentoFornecedores] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [FaturamentoFornecedores] SET RECOVERY FULL 
GO
ALTER DATABASE [FaturamentoFornecedores] SET  MULTI_USER 
GO
ALTER DATABASE [FaturamentoFornecedores] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [FaturamentoFornecedores] SET DB_CHAINING OFF 
GO
ALTER DATABASE [FaturamentoFornecedores] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [FaturamentoFornecedores] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [FaturamentoFornecedores] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [FaturamentoFornecedores] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'FaturamentoFornecedores', N'ON'
GO
ALTER DATABASE [FaturamentoFornecedores] SET QUERY_STORE = ON
GO
ALTER DATABASE [FaturamentoFornecedores] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [FaturamentoFornecedores]
GO
/****** Object:  Table [dbo].[Fornecedores]    Script Date: 09/07/2024 16:18:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fornecedores](
	[FornecedorID] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [nvarchar](100) NOT NULL,
	[Endereco] [nvarchar](200) NOT NULL,
	[Bairro] [nvarchar](100) NOT NULL,
	[Cidade] [nvarchar](100) NOT NULL,
	[CEP] [nvarchar](20) NOT NULL,
	[Telefone] [nvarchar](20) NOT NULL,
	[Email] [nvarchar](100) NULL,
	[CPF] [nvarchar](14) NOT NULL,
	[RG] [nvarchar](20) NOT NULL,
	[Modalidade] [nvarchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[FornecedorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HistoricoArrendamentos]    Script Date: 09/07/2024 16:18:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HistoricoArrendamentos](
	[HistoricoID] [int] IDENTITY(1,1) NOT NULL,
	[FornecedorID] [int] NOT NULL,
	[Alqueires] [decimal](10, 2) NOT NULL,
	[ToneladasPorAlqueire] [decimal](10, 2) NOT NULL,
	[ValorAno] [decimal](10, 2) NOT NULL,
	[ValorPorMes] [decimal](10, 2) NOT NULL,
	[ATRMes] [decimal](10, 2) NOT NULL,
	[TotalReceber] [decimal](10, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[HistoricoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HistoricoEntregas]    Script Date: 09/07/2024 16:18:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HistoricoEntregas](
	[HistoricoID] [int] IDENTITY(1,1) NOT NULL,
	[FornecedorID] [int] NOT NULL,
	[Mes] [int] NOT NULL,
	[Ano] [int] NOT NULL,
	[Toneladas] [decimal](10, 2) NOT NULL,
	[ATR] [decimal](10, 2) NOT NULL,
	[ValorTotal] [decimal](10, 2) NOT NULL,
	[ValorReceberDesconto] [decimal](10, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[HistoricoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[HistoricoArrendamentos]  WITH CHECK ADD FOREIGN KEY([FornecedorID])
REFERENCES [dbo].[Fornecedores] ([FornecedorID])
GO
ALTER TABLE [dbo].[HistoricoEntregas]  WITH CHECK ADD FOREIGN KEY([FornecedorID])
REFERENCES [dbo].[Fornecedores] ([FornecedorID])
GO
USE [master]
GO
ALTER DATABASE [FaturamentoFornecedores] SET  READ_WRITE 
GO
