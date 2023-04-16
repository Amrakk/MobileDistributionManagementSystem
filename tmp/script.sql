USE [master]
GO
/****** Object:  Database [MobilePhoneDistributorSoftware]    Script Date: 4/14/2023 11:15:32 PM ******/
CREATE DATABASE [MobilePhoneDistributorSoftware]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MobilePhoneDistributorSoftware', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\MobilePhoneDistributorSoftware.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'MobilePhoneDistributorSoftware_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\MobilePhoneDistributorSoftware_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [MobilePhoneDistributorSoftware] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MobilePhoneDistributorSoftware].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MobilePhoneDistributorSoftware] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MobilePhoneDistributorSoftware] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MobilePhoneDistributorSoftware] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MobilePhoneDistributorSoftware] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MobilePhoneDistributorSoftware] SET ARITHABORT OFF 
GO
ALTER DATABASE [MobilePhoneDistributorSoftware] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [MobilePhoneDistributorSoftware] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MobilePhoneDistributorSoftware] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MobilePhoneDistributorSoftware] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MobilePhoneDistributorSoftware] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MobilePhoneDistributorSoftware] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MobilePhoneDistributorSoftware] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MobilePhoneDistributorSoftware] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MobilePhoneDistributorSoftware] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MobilePhoneDistributorSoftware] SET  ENABLE_BROKER 
GO
ALTER DATABASE [MobilePhoneDistributorSoftware] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MobilePhoneDistributorSoftware] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MobilePhoneDistributorSoftware] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MobilePhoneDistributorSoftware] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MobilePhoneDistributorSoftware] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MobilePhoneDistributorSoftware] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MobilePhoneDistributorSoftware] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MobilePhoneDistributorSoftware] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [MobilePhoneDistributorSoftware] SET  MULTI_USER 
GO
ALTER DATABASE [MobilePhoneDistributorSoftware] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MobilePhoneDistributorSoftware] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MobilePhoneDistributorSoftware] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MobilePhoneDistributorSoftware] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [MobilePhoneDistributorSoftware] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [MobilePhoneDistributorSoftware] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [MobilePhoneDistributorSoftware] SET QUERY_STORE = ON
GO
ALTER DATABASE [MobilePhoneDistributorSoftware] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [MobilePhoneDistributorSoftware]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 4/14/2023 11:15:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[account_id] [int] NOT NULL,
	[profile_id] [int] NULL,
	[username] [varchar](50) NULL,
	[password] [varchar](50) NULL,
	[created_date] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[account_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Delivery_ITEM]    Script Date: 4/14/2023 11:15:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Delivery_ITEM](
	[delivery_item_id] [int] NOT NULL,
	[delivery_note_id] [int] NULL,
	[product_id] [int] NULL,
	[quantity] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[delivery_item_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Goods_Delivery_Note]    Script Date: 4/14/2023 11:15:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Goods_Delivery_Note](
	[delivery_note_id] [int] NOT NULL,
	[delivery_date] [datetime] NULL,
	[reseller_id] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[delivery_note_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Goods_Received_Note]    Script Date: 4/14/2023 11:15:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Goods_Received_Note](
	[received_id] [int] NOT NULL,
	[received_date] [datetime] NULL,
	[received_from] [varchar](50) NULL,
	[total_quantity] [int] NULL,
	[total_cost] [decimal](18, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[received_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order_Item]    Script Date: 4/14/2023 11:15:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order_Item](
	[order_item_id] [int] NOT NULL,
	[order_id] [int] NULL,
	[product_id] [int] NULL,
	[quantity] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[order_item_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order_Note]    Script Date: 4/14/2023 11:15:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order_Note](
	[order_id] [int] NOT NULL,
	[status_id] [int] NULL,
	[reseller_id] [int] NULL,
	[order_date] [datetime] NULL,
	[total_price] [decimal](18, 2) NULL,
	[payment_method] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[order_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 4/14/2023 11:15:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[product_id] [int] NOT NULL,
	[product_name] [varchar](50) NULL,
	[brand] [varchar](50) NULL,
	[model] [varchar](50) NULL,
	[product_description] [varchar](255) NULL,
	[product_price] [decimal](18, 2) NULL,
	[product_quantity] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[product_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Profile]    Script Date: 4/14/2023 11:15:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Profile](
	[profile_id] [int] NOT NULL,
	[first_name] [varchar](50) NULL,
	[last_name] [varchar](50) NULL,
	[email] [varchar](50) NULL,
	[phone] [varchar](20) NULL,
	[role_id] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[profile_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Received_Item]    Script Date: 4/14/2023 11:15:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Received_Item](
	[received_item_id] [int] NOT NULL,
	[received_id] [int] NULL,
	[product_id] [int] NULL,
	[quantity] [int] NULL,
	[cost_per_unit] [decimal](18, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[received_item_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reseller]    Script Date: 4/14/2023 11:15:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reseller](
	[reseller_id] [int] NOT NULL,
	[profile_id] [int] NULL,
	[reseller_name] [varchar](50) NULL,
	[address] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[reseller_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 4/14/2023 11:15:32 PM ******/
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
/****** Object:  Table [dbo].[Status]    Script Date: 4/14/2023 11:15:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Status](
	[status_id] [int] NOT NULL,
	[status_name] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[status_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Account]  WITH CHECK ADD FOREIGN KEY([profile_id])
REFERENCES [dbo].[Profile] ([profile_id])
GO
ALTER TABLE [dbo].[Delivery_ITEM]  WITH CHECK ADD FOREIGN KEY([delivery_note_id])
REFERENCES [dbo].[Goods_Delivery_Note] ([delivery_note_id])
GO
ALTER TABLE [dbo].[Delivery_ITEM]  WITH CHECK ADD FOREIGN KEY([product_id])
REFERENCES [dbo].[Product] ([product_id])
GO
ALTER TABLE [dbo].[Goods_Delivery_Note]  WITH CHECK ADD FOREIGN KEY([reseller_id])
REFERENCES [dbo].[Reseller] ([reseller_id])
GO
ALTER TABLE [dbo].[Order_Item]  WITH CHECK ADD FOREIGN KEY([order_id])
REFERENCES [dbo].[Order_Note] ([order_id])
GO
ALTER TABLE [dbo].[Order_Item]  WITH CHECK ADD FOREIGN KEY([product_id])
REFERENCES [dbo].[Product] ([product_id])
GO
ALTER TABLE [dbo].[Order_Note]  WITH CHECK ADD FOREIGN KEY([reseller_id])
REFERENCES [dbo].[Reseller] ([reseller_id])
GO
ALTER TABLE [dbo].[Order_Note]  WITH CHECK ADD FOREIGN KEY([status_id])
REFERENCES [dbo].[Status] ([status_id])
GO
ALTER TABLE [dbo].[Profile]  WITH CHECK ADD FOREIGN KEY([role_id])
REFERENCES [dbo].[Role] ([role_id])
GO
ALTER TABLE [dbo].[Received_Item]  WITH CHECK ADD FOREIGN KEY([product_id])
REFERENCES [dbo].[Product] ([product_id])
GO
ALTER TABLE [dbo].[Received_Item]  WITH CHECK ADD FOREIGN KEY([received_id])
REFERENCES [dbo].[Goods_Received_Note] ([received_id])
GO
ALTER TABLE [dbo].[Reseller]  WITH CHECK ADD FOREIGN KEY([profile_id])
REFERENCES [dbo].[Profile] ([profile_id])
GO
USE [master]
GO
ALTER DATABASE [MobilePhoneDistributorSoftware] SET  READ_WRITE 
GO
