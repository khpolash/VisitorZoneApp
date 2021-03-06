USE [master]
GO
/****** Object:  Database [VisitorZoneDB]    Script Date: 26-May-15 11:08:06 PM ******/
CREATE DATABASE [VisitorZoneDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'VisitorZoneDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\VisitorZoneDB.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'VisitorZoneDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\VisitorZoneDB_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [VisitorZoneDB] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [VisitorZoneDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [VisitorZoneDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [VisitorZoneDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [VisitorZoneDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [VisitorZoneDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [VisitorZoneDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [VisitorZoneDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [VisitorZoneDB] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [VisitorZoneDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [VisitorZoneDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [VisitorZoneDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [VisitorZoneDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [VisitorZoneDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [VisitorZoneDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [VisitorZoneDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [VisitorZoneDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [VisitorZoneDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [VisitorZoneDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [VisitorZoneDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [VisitorZoneDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [VisitorZoneDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [VisitorZoneDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [VisitorZoneDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [VisitorZoneDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [VisitorZoneDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [VisitorZoneDB] SET  MULTI_USER 
GO
ALTER DATABASE [VisitorZoneDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [VisitorZoneDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [VisitorZoneDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [VisitorZoneDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [VisitorZoneDB]
GO
/****** Object:  Table [dbo].[tbl_joint_visitor_zone]    Script Date: 26-May-15 11:08:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_joint_visitor_zone](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[visitorid] [int] NOT NULL,
	[zoneid] [int] NOT NULL,
 CONSTRAINT [PK_tbl_joint_visitor_zone] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_visitor]    Script Date: 26-May-15 11:08:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_visitor](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[phone] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tbl_visitor] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_zone]    Script Date: 26-May-15 11:08:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_zone](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[zoneName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tbl_zone] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_joint_visitor_zone] ON 

INSERT [dbo].[tbl_joint_visitor_zone] ([id], [visitorid], [zoneid]) VALUES (1, 1, 1)
INSERT [dbo].[tbl_joint_visitor_zone] ([id], [visitorid], [zoneid]) VALUES (2, 1, 2)
INSERT [dbo].[tbl_joint_visitor_zone] ([id], [visitorid], [zoneid]) VALUES (3, 1, 3)
INSERT [dbo].[tbl_joint_visitor_zone] ([id], [visitorid], [zoneid]) VALUES (4, 1, 4)
INSERT [dbo].[tbl_joint_visitor_zone] ([id], [visitorid], [zoneid]) VALUES (5, 2, 1)
INSERT [dbo].[tbl_joint_visitor_zone] ([id], [visitorid], [zoneid]) VALUES (6, 2, 2)
INSERT [dbo].[tbl_joint_visitor_zone] ([id], [visitorid], [zoneid]) VALUES (7, 3, 1)
INSERT [dbo].[tbl_joint_visitor_zone] ([id], [visitorid], [zoneid]) VALUES (8, 3, 2)
INSERT [dbo].[tbl_joint_visitor_zone] ([id], [visitorid], [zoneid]) VALUES (9, 3, 3)
INSERT [dbo].[tbl_joint_visitor_zone] ([id], [visitorid], [zoneid]) VALUES (10, 3, 4)
INSERT [dbo].[tbl_joint_visitor_zone] ([id], [visitorid], [zoneid]) VALUES (11, 4, 3)
INSERT [dbo].[tbl_joint_visitor_zone] ([id], [visitorid], [zoneid]) VALUES (12, 4, 4)
INSERT [dbo].[tbl_joint_visitor_zone] ([id], [visitorid], [zoneid]) VALUES (13, 4, 5)
SET IDENTITY_INSERT [dbo].[tbl_joint_visitor_zone] OFF
SET IDENTITY_INSERT [dbo].[tbl_visitor] ON 

INSERT [dbo].[tbl_visitor] ([id], [name], [email], [phone]) VALUES (1, N'Polash', N'polash@mail.com', N'01915358878')
INSERT [dbo].[tbl_visitor] ([id], [name], [email], [phone]) VALUES (2, N'Robin', N'robin@mail.com', N'40928402842')
INSERT [dbo].[tbl_visitor] ([id], [name], [email], [phone]) VALUES (3, N'Rpm', N'rpm@mail.com', N'019843823909')
INSERT [dbo].[tbl_visitor] ([id], [name], [email], [phone]) VALUES (4, N'Adil', N'adil@mail.com', N'409234802344')
SET IDENTITY_INSERT [dbo].[tbl_visitor] OFF
SET IDENTITY_INSERT [dbo].[tbl_zone] ON 

INSERT [dbo].[tbl_zone] ([id], [zoneName]) VALUES (1, N'Robin Zone')
INSERT [dbo].[tbl_zone] ([id], [zoneName]) VALUES (2, N'Rpm Zone')
INSERT [dbo].[tbl_zone] ([id], [zoneName]) VALUES (3, N'Sabbir Zone')
INSERT [dbo].[tbl_zone] ([id], [zoneName]) VALUES (4, N'Lash Zone')
INSERT [dbo].[tbl_zone] ([id], [zoneName]) VALUES (5, N'Mobile Zone')
SET IDENTITY_INSERT [dbo].[tbl_zone] OFF
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_tbl_visitor]    Script Date: 26-May-15 11:08:06 PM ******/
CREATE NONCLUSTERED INDEX [IX_tbl_visitor] ON [dbo].[tbl_visitor]
(
	[email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tbl_joint_visitor_zone]  WITH CHECK ADD  CONSTRAINT [FK_tbl_joint_visitor_zone_tbl_visitor] FOREIGN KEY([visitorid])
REFERENCES [dbo].[tbl_visitor] ([id])
GO
ALTER TABLE [dbo].[tbl_joint_visitor_zone] CHECK CONSTRAINT [FK_tbl_joint_visitor_zone_tbl_visitor]
GO
ALTER TABLE [dbo].[tbl_joint_visitor_zone]  WITH CHECK ADD  CONSTRAINT [FK_tbl_joint_visitor_zone_tbl_zone] FOREIGN KEY([zoneid])
REFERENCES [dbo].[tbl_zone] ([id])
GO
ALTER TABLE [dbo].[tbl_joint_visitor_zone] CHECK CONSTRAINT [FK_tbl_joint_visitor_zone_tbl_zone]
GO
USE [master]
GO
ALTER DATABASE [VisitorZoneDB] SET  READ_WRITE 
GO
