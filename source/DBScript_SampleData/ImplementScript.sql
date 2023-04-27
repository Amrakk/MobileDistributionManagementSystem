USE [master]
GO
/****** Object:  Database [MobileDistributionManagement]    Script Date: 4/27/2023 9:09:23 PM ******/
CREATE DATABASE [MobileDistributionManagement]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MobileDistributionManagement', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\MobileDistributionManagement.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'MobileDistributionManagement_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\MobileDistributionManagement_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [MobileDistributionManagement] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MobileDistributionManagement].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MobileDistributionManagement] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MobileDistributionManagement] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MobileDistributionManagement] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MobileDistributionManagement] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MobileDistributionManagement] SET ARITHABORT OFF 
GO
ALTER DATABASE [MobileDistributionManagement] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [MobileDistributionManagement] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MobileDistributionManagement] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MobileDistributionManagement] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MobileDistributionManagement] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MobileDistributionManagement] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MobileDistributionManagement] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MobileDistributionManagement] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MobileDistributionManagement] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MobileDistributionManagement] SET  ENABLE_BROKER 
GO
ALTER DATABASE [MobileDistributionManagement] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MobileDistributionManagement] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MobileDistributionManagement] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MobileDistributionManagement] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MobileDistributionManagement] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MobileDistributionManagement] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MobileDistributionManagement] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MobileDistributionManagement] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [MobileDistributionManagement] SET  MULTI_USER 
GO
ALTER DATABASE [MobileDistributionManagement] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MobileDistributionManagement] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MobileDistributionManagement] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MobileDistributionManagement] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [MobileDistributionManagement] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [MobileDistributionManagement] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [MobileDistributionManagement] SET QUERY_STORE = ON
GO
ALTER DATABASE [MobileDistributionManagement] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [MobileDistributionManagement]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 4/27/2023 9:09:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[account_id] [int] NOT NULL,
	[username] [varchar](50) NULL,
	[password] [varchar](100) NULL,
	[isActivated] [bit] NULL,
	[created_date] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[account_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Profile]    Script Date: 4/27/2023 9:09:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Profile](
	[profile_id] [int] IDENTITY(10000,1) NOT NULL,
	[first_name] [nvarchar](50) NULL,
	[last_name] [nvarchar](50) NULL,
	[email] [varchar](50) NULL,
	[phone] [varchar](20) NULL,
	[role_id] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[profile_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reseller]    Script Date: 4/27/2023 9:09:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reseller](
	[reseller_id] [int] NOT NULL,
	[reseller_name] [nvarchar](100) NULL,
	[address] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[reseller_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 4/27/2023 9:09:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[role_id] [int] NOT NULL,
	[role_name] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[role_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Account] ADD  DEFAULT ((0)) FOR [isActivated]
GO
ALTER TABLE [dbo].[Account]  WITH CHECK ADD FOREIGN KEY([account_id])
REFERENCES [dbo].[Profile] ([profile_id])
GO
ALTER TABLE [dbo].[Profile]  WITH CHECK ADD FOREIGN KEY([role_id])
REFERENCES [dbo].[Role] ([role_id])
GO
ALTER TABLE [dbo].[Reseller]  WITH CHECK ADD FOREIGN KEY([reseller_id])
REFERENCES [dbo].[Profile] ([profile_id])
GO
USE [master]
GO
ALTER DATABASE [MobileDistributionManagement] SET  READ_WRITE 
GO
