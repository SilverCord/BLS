USE [master]
GO
/****** Object:  Database [BLS]    Script Date: 01/18/2015 19:32:48 ******/
CREATE DATABASE [BLS] ON  PRIMARY 
( NAME = N'BLS', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\BLS.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'BLS_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\BLS_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [BLS] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BLS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BLS] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [BLS] SET ANSI_NULLS OFF
GO
ALTER DATABASE [BLS] SET ANSI_PADDING OFF
GO
ALTER DATABASE [BLS] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [BLS] SET ARITHABORT OFF
GO
ALTER DATABASE [BLS] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [BLS] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [BLS] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [BLS] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [BLS] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [BLS] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [BLS] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [BLS] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [BLS] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [BLS] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [BLS] SET  DISABLE_BROKER
GO
ALTER DATABASE [BLS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [BLS] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [BLS] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [BLS] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [BLS] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [BLS] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [BLS] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [BLS] SET  READ_WRITE
GO
ALTER DATABASE [BLS] SET RECOVERY SIMPLE
GO
ALTER DATABASE [BLS] SET  MULTI_USER
GO
ALTER DATABASE [BLS] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [BLS] SET DB_CHAINING OFF
GO
USE [BLS]
GO
/****** Object:  UserDefinedTableType [dbo].[UDTTransactionHistory]    Script Date: 01/18/2015 19:32:48 ******/
CREATE TYPE [dbo].[UDTTransactionHistory] AS TABLE(
	[HistoryUID] [uniqueidentifier] NOT NULL,
	[HistoryDate] [date] NULL,
	[IssueDate] [date] NULL,
	[ReturnDate] [date] NULL,
	[Type] [varchar](3) NULL,
	[CustomerID] [varchar](20) NULL,
	[Title] [varchar](500) NULL,
	[Author] [varchar](200) NULL,
	[Edition] [varchar](20) NULL,
	[Publisher] [varchar](200) NULL,
	[PurchasePrice] [float] NULL,
	[AmountIN] [float] NULL,
	[AmountOut] [float] NULL,
	[RecieptNumber] [varchar](20) NULL,
	[CheckNumber] [varchar](30) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTStock]    Script Date: 01/18/2015 19:32:48 ******/
CREATE TYPE [dbo].[UDTStock] AS TABLE(
	[ISBN] [varchar](25) NOT NULL,
	[Title] [varchar](500) NULL,
	[Author] [varchar](200) NULL,
	[Year] [varchar](4) NULL,
	[Edition] [varchar](20) NULL,
	[Publisher] [varchar](200) NULL,
	[Count] [int] NULL,
	[PriceChangable] [bit] NULL,
	[OriginalPrice] [float] NULL,
	[Discount] [float] NULL,
	[PurchasePrice] [float] NULL,
	[LastUpdated] [date] NULL,
	[OutCount] [int] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTOrder]    Script Date: 01/18/2015 19:32:49 ******/
CREATE TYPE [dbo].[UDTOrder] AS TABLE(
	[CustomerID] [varchar](15) NOT NULL,
	[Date] [date] NULL,
	[ISBN] [varchar](25) NULL,
	[Count] [int] NOT NULL,
	[DepositAmount] [float] NOT NULL,
	[OrderClearanceDate] [date] NULL,
	[Mobile] [varchar](12) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTIssue]    Script Date: 01/18/2015 19:32:49 ******/
CREATE TYPE [dbo].[UDTIssue] AS TABLE(
	[CustomerID] [varchar](20) NOT NULL,
	[Title] [varchar](300) NULL,
	[Author] [varchar](150) NULL,
	[Edition] [varchar](20) NULL,
	[Publisher] [varchar](150) NOT NULL,
	[IssueDate] [date] NOT NULL,
	[BookCount] [int] NOT NULL,
	[BookPrice] [float] NOT NULL,
	[RecieptNumber] [varchar](20) NOT NULL,
	[HistoryUID] [uniqueidentifier] NOT NULL,
	[IssueType] [varchar](25) NOT NULL,
	[ReturnDate] [date] NOT NULL,
	[EarlyIssue] [bit] NOT NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTCustomerBooks]    Script Date: 01/18/2015 19:32:49 ******/
CREATE TYPE [dbo].[UDTCustomerBooks] AS TABLE(
	[CustBookID] [int] NOT NULL,
	[CustomerID] [int] NOT NULL,
	[Title] [varchar](500) NULL,
	[Author] [varchar](200) NULL,
	[Edition] [varchar](20) NULL,
	[OriginalPrice] [float] NULL,
	[Count] [int] NOT NULL,
	[Date] [date] NULL,
	[HistoryUID] [uniqueidentifier] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDTCustomer]    Script Date: 01/18/2015 19:32:49 ******/
CREATE TYPE [dbo].[UDTCustomer] AS TABLE(
	[CustomerID] [varchar](20) NOT NULL,
	[Name] [varchar](150) NOT NULL,
	[Father Name] [varchar](100) NOT NULL,
	[DOB] [date] NOT NULL,
	[Parent Phone] [varchar](20) NOT NULL,
	[Parent Mobile] [varchar](20) NOT NULL,
	[Student Mobile] [varchar](20) NOT NULL,
	[Address] [varchar](500) NOT NULL,
	[CollegeName] [varchar](300) NOT NULL,
	[Course] [varchar](200) NOT NULL,
	[CourseDuration] [int] NOT NULL,
	[EmailID] [varchar](150) NOT NULL,
	[MembershipDate] [date] NOT NULL,
	[MembershipType] [varchar](50) NOT NULL,
	[MembershipPeriod] [int] NOT NULL,
	[Activation] [bit] NULL,
	[BookCount] [int] NOT NULL,
	[DepositAmount] [float] NOT NULL,
	[AdvanceAmount] [float] NULL,
	[BalanceAmount] [float] NULL,
	[RefundAmount] [float] NULL,
	[RecieptNumber] [varchar](20) NULL,
	[MaxLimit] [float] NOT NULL,
	[UsedLimit] [float] NOT NULL,
	[EarlyActivation] [bit] NULL,
	[CreatedDatetime] [datetime] NULL,
	[ImagePath] [varchar](400) NULL
)
GO
/****** Object:  Table [dbo].[TblTransactionHistory]    Script Date: 01/18/2015 19:32:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TblTransactionHistory](
	[HistoryUID] [uniqueidentifier] NOT NULL,
	[HistoryDate] [date] NULL,
	[IssueDate] [date] NULL,
	[ReturnDate] [date] NULL,
	[Type] [varchar](3) NULL,
	[CustomerID] [varchar](20) NULL,
	[Title] [varchar](500) NULL,
	[Author] [varchar](200) NULL,
	[Edition] [varchar](20) NULL,
	[Publisher] [varchar](200) NULL,
	[PurchasePrice] [float] NULL,
	[AmountIN] [float] NULL,
	[AmountOut] [float] NULL,
	[RecieptNumber] [varchar](20) NULL,
	[CheckNumber] [varchar](30) NULL,
 CONSTRAINT [PK_TblTransactionHistory] PRIMARY KEY CLUSTERED 
(
	[HistoryUID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[TblTransactionHistory] ([HistoryUID], [HistoryDate], [IssueDate], [ReturnDate], [Type], [CustomerID], [Title], [Author], [Edition], [Publisher], [PurchasePrice], [AmountIN], [AmountOut], [RecieptNumber], [CheckNumber]) VALUES (N'a755caff-532e-4516-8e52-25b60ecb81ff', CAST(0x7F390B00 AS Date), CAST(0x7F390B00 AS Date), CAST(0x413A0B00 AS Date), N'R', N'404', N'g', N'g', N'g', N'g', 900, 900, 0, N'TRLND01000', N'')
INSERT [dbo].[TblTransactionHistory] ([HistoryUID], [HistoryDate], [IssueDate], [ReturnDate], [Type], [CustomerID], [Title], [Author], [Edition], [Publisher], [PurchasePrice], [AmountIN], [AmountOut], [RecieptNumber], [CheckNumber]) VALUES (N'dd30f9f7-af8d-438d-832b-2cc4300131af', CAST(0x7F390B00 AS Date), CAST(0x7F390B00 AS Date), CAST(0x413A0B00 AS Date), N'R', N'404', N'a', N'a', N'a', N'a', 460, 460, 0, N'TRLND01000', N'')
INSERT [dbo].[TblTransactionHistory] ([HistoryUID], [HistoryDate], [IssueDate], [ReturnDate], [Type], [CustomerID], [Title], [Author], [Edition], [Publisher], [PurchasePrice], [AmountIN], [AmountOut], [RecieptNumber], [CheckNumber]) VALUES (N'8da02bb7-d85d-423e-9284-2d83d217f601', CAST(0x7F390B00 AS Date), CAST(0x7F390B00 AS Date), CAST(0x043A0B00 AS Date), N'R', N'407', N'b', N'b', N'b', N'b', 1500, 1500, 0, N'TRLND01000', N'')
INSERT [dbo].[TblTransactionHistory] ([HistoryUID], [HistoryDate], [IssueDate], [ReturnDate], [Type], [CustomerID], [Title], [Author], [Edition], [Publisher], [PurchasePrice], [AmountIN], [AmountOut], [RecieptNumber], [CheckNumber]) VALUES (N'18cbff05-21e8-4ba0-9429-37dc9e32ae29', CAST(0x7F390B00 AS Date), CAST(0x7F390B00 AS Date), CAST(0x043A0B00 AS Date), N'R', N'407', N'c', N'c', N'c', N'c', 2300, 2300, 0, N'TRLND01000', N'')
INSERT [dbo].[TblTransactionHistory] ([HistoryUID], [HistoryDate], [IssueDate], [ReturnDate], [Type], [CustomerID], [Title], [Author], [Edition], [Publisher], [PurchasePrice], [AmountIN], [AmountOut], [RecieptNumber], [CheckNumber]) VALUES (N'73aa76ef-6b0b-4e15-a176-394253fb3327', CAST(0x7F390B00 AS Date), CAST(0x7F390B00 AS Date), CAST(0x043A0B00 AS Date), N'R', N'407', N'b', N'b', N'b', N'b', 1500, 1500, 0, N'TRLND01000', N'')
INSERT [dbo].[TblTransactionHistory] ([HistoryUID], [HistoryDate], [IssueDate], [ReturnDate], [Type], [CustomerID], [Title], [Author], [Edition], [Publisher], [PurchasePrice], [AmountIN], [AmountOut], [RecieptNumber], [CheckNumber]) VALUES (N'479eb598-1590-40a3-9944-42b0a2ae9bd3', CAST(0x7F390B00 AS Date), CAST(0x7F390B00 AS Date), CAST(0x413A0B00 AS Date), N'R', N'404', N'd', N'd', N'd', N'd', 2800, 2800, 0, N'TRLND01000', N'')
INSERT [dbo].[TblTransactionHistory] ([HistoryUID], [HistoryDate], [IssueDate], [ReturnDate], [Type], [CustomerID], [Title], [Author], [Edition], [Publisher], [PurchasePrice], [AmountIN], [AmountOut], [RecieptNumber], [CheckNumber]) VALUES (N'9386191e-5e19-40e0-8b2d-52df99d46e57', CAST(0x7F390B00 AS Date), CAST(0x7F390B00 AS Date), CAST(0x043A0B00 AS Date), N'R', N'407', N'b', N'b', N'b', N'b', 1500, 1500, 0, N'TRLND01000', N'')
INSERT [dbo].[TblTransactionHistory] ([HistoryUID], [HistoryDate], [IssueDate], [ReturnDate], [Type], [CustomerID], [Title], [Author], [Edition], [Publisher], [PurchasePrice], [AmountIN], [AmountOut], [RecieptNumber], [CheckNumber]) VALUES (N'179396af-2c7b-4d54-8b24-55f4479c6897', CAST(0x7F390B00 AS Date), CAST(0x7F390B00 AS Date), CAST(0x043A0B00 AS Date), N'R', N'407', N'a', N'a', N'a', N'a', 460, 460, 0, N'TRLND01000', N'')
INSERT [dbo].[TblTransactionHistory] ([HistoryUID], [HistoryDate], [IssueDate], [ReturnDate], [Type], [CustomerID], [Title], [Author], [Edition], [Publisher], [PurchasePrice], [AmountIN], [AmountOut], [RecieptNumber], [CheckNumber]) VALUES (N'3a821822-3c79-4dc9-a5db-5d1c482d2eae', CAST(0x7F390B00 AS Date), CAST(0x7F390B00 AS Date), CAST(0x043A0B00 AS Date), N'R', N'407', N'd', N'd', N'd', N'd', 2800, 2800, 0, N'TRLND01000', N'')
INSERT [dbo].[TblTransactionHistory] ([HistoryUID], [HistoryDate], [IssueDate], [ReturnDate], [Type], [CustomerID], [Title], [Author], [Edition], [Publisher], [PurchasePrice], [AmountIN], [AmountOut], [RecieptNumber], [CheckNumber]) VALUES (N'2c4aa0d4-1e6a-4f75-9551-63ab4d4efea8', CAST(0x7F390B00 AS Date), CAST(0x7F390B00 AS Date), CAST(0x413A0B00 AS Date), N'R', N'404', N'c', N'c', N'c', N'c', 2300, 2300, 0, N'TRLND01000', N'')
INSERT [dbo].[TblTransactionHistory] ([HistoryUID], [HistoryDate], [IssueDate], [ReturnDate], [Type], [CustomerID], [Title], [Author], [Edition], [Publisher], [PurchasePrice], [AmountIN], [AmountOut], [RecieptNumber], [CheckNumber]) VALUES (N'faa050e9-8521-4b79-88f1-7fa44601ee89', CAST(0x7F390B00 AS Date), CAST(0x7F390B00 AS Date), CAST(0x413A0B00 AS Date), N'R', N'404', N'sha', N'sha', N'sha', N'sha', 3000, 3000, 0, N'TRLND01000', N'')
INSERT [dbo].[TblTransactionHistory] ([HistoryUID], [HistoryDate], [IssueDate], [ReturnDate], [Type], [CustomerID], [Title], [Author], [Edition], [Publisher], [PurchasePrice], [AmountIN], [AmountOut], [RecieptNumber], [CheckNumber]) VALUES (N'b6ed38e8-b216-4e96-b29a-7fd6e2646948', CAST(0x7F390B00 AS Date), CAST(0x7F390B00 AS Date), CAST(0x043A0B00 AS Date), N'R', N'407', N'sha', N'sha', N'sha', N'sha', 3000, 3000, 0, N'TRLND01000', N'')
INSERT [dbo].[TblTransactionHistory] ([HistoryUID], [HistoryDate], [IssueDate], [ReturnDate], [Type], [CustomerID], [Title], [Author], [Edition], [Publisher], [PurchasePrice], [AmountIN], [AmountOut], [RecieptNumber], [CheckNumber]) VALUES (N'479e8a73-bdf4-42fc-af2d-8662c62de9a1', CAST(0x7F390B00 AS Date), CAST(0x7F390B00 AS Date), CAST(0x413A0B00 AS Date), N'R', N'404', N'o', N'o', N'o', N'o', 600, 600, 0, N'TRLND01000', N'')
INSERT [dbo].[TblTransactionHistory] ([HistoryUID], [HistoryDate], [IssueDate], [ReturnDate], [Type], [CustomerID], [Title], [Author], [Edition], [Publisher], [PurchasePrice], [AmountIN], [AmountOut], [RecieptNumber], [CheckNumber]) VALUES (N'4e7d4cc7-1f99-4baf-a621-dbe431e6a4b5', CAST(0x7F390B00 AS Date), CAST(0x7F390B00 AS Date), CAST(0x413A0B00 AS Date), N'R', N'404', N'b', N'b', N'b', N'b', 1500, 1500, 0, N'TRLND01000', N'')
INSERT [dbo].[TblTransactionHistory] ([HistoryUID], [HistoryDate], [IssueDate], [ReturnDate], [Type], [CustomerID], [Title], [Author], [Edition], [Publisher], [PurchasePrice], [AmountIN], [AmountOut], [RecieptNumber], [CheckNumber]) VALUES (N'51b68920-a153-4ce7-be62-e16d5c9e342e', CAST(0x7F390B00 AS Date), CAST(0x7F390B00 AS Date), CAST(0x043A0B00 AS Date), N'R', N'407', N'g', N'g', N'g', N'g', 900, 900, 0, N'TRLND01000', N'')
INSERT [dbo].[TblTransactionHistory] ([HistoryUID], [HistoryDate], [IssueDate], [ReturnDate], [Type], [CustomerID], [Title], [Author], [Edition], [Publisher], [PurchasePrice], [AmountIN], [AmountOut], [RecieptNumber], [CheckNumber]) VALUES (N'ef8b10ec-0a5c-4be8-8ff4-ed5d89549182', CAST(0x7F390B00 AS Date), CAST(0x7F390B00 AS Date), CAST(0x043A0B00 AS Date), N'R', N'407', N'd', N'd', N'd', N'd', 2800, 2800, 0, N'TRLND01000', N'')
INSERT [dbo].[TblTransactionHistory] ([HistoryUID], [HistoryDate], [IssueDate], [ReturnDate], [Type], [CustomerID], [Title], [Author], [Edition], [Publisher], [PurchasePrice], [AmountIN], [AmountOut], [RecieptNumber], [CheckNumber]) VALUES (N'd83d90da-5fc0-4858-a6e3-f7718d30d694', CAST(0x7F390B00 AS Date), CAST(0x7F390B00 AS Date), CAST(0x413A0B00 AS Date), N'R', N'404', N'd', N'd', N'd', N'd', 2800, 2800, 0, N'TRLND01000', N'')
/****** Object:  Table [dbo].[TblSupplier]    Script Date: 01/18/2015 19:32:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TblSupplier](
	[SupplierID] [int] NOT NULL,
	[ShortName] [varchar](50) NOT NULL,
	[FullName] [varchar](250) NULL,
	[City] [varchar](50) NOT NULL,
	[Phone] [varchar](12) NULL,
	[Address] [varchar](500) NULL,
 CONSTRAINT [PK_TblSupplier] PRIMARY KEY CLUSTERED 
(
	[SupplierID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TblStock]    Script Date: 01/18/2015 19:32:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TblStock](
	[ISBN] [varchar](25) NOT NULL,
	[Title] [varchar](300) NOT NULL,
	[Author] [varchar](200) NOT NULL,
	[Year] [varchar](4) NULL,
	[Edition] [varchar](20) NOT NULL,
	[Publisher] [varchar](200) NOT NULL,
	[Count] [int] NULL,
	[PriceChangable] [bit] NULL,
	[OriginalPrice] [float] NULL,
	[Discount] [float] NULL,
	[PurchasePrice] [float] NOT NULL,
	[LastUpdated] [date] NULL,
	[OutCount] [int] NULL,
 CONSTRAINT [PK_TblStock] PRIMARY KEY CLUSTERED 
(
	[Title] ASC,
	[Author] ASC,
	[Edition] ASC,
	[Publisher] ASC,
	[PurchasePrice] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[TblStock] ([ISBN], [Title], [Author], [Year], [Edition], [Publisher], [Count], [PriceChangable], [OriginalPrice], [Discount], [PurchasePrice], [LastUpdated], [OutCount]) VALUES (N'', N'a', N'a', N'2003', N'a', N'a', 0, 1, 460, 0, 460, CAST(0x7F390B00 AS Date), 5)
INSERT [dbo].[TblStock] ([ISBN], [Title], [Author], [Year], [Edition], [Publisher], [Count], [PriceChangable], [OriginalPrice], [Discount], [PurchasePrice], [LastUpdated], [OutCount]) VALUES (N'', N'b', N'b', N'2003', N'b', N'b', 2, 1, 1500, 0, 1500, CAST(0x7F390B00 AS Date), 6)
INSERT [dbo].[TblStock] ([ISBN], [Title], [Author], [Year], [Edition], [Publisher], [Count], [PriceChangable], [OriginalPrice], [Discount], [PurchasePrice], [LastUpdated], [OutCount]) VALUES (N'', N'c', N'c', N'2003', N'c', N'c', 5, 1, 2300, 0, 2300, CAST(0x7F390B00 AS Date), 4)
INSERT [dbo].[TblStock] ([ISBN], [Title], [Author], [Year], [Edition], [Publisher], [Count], [PriceChangable], [OriginalPrice], [Discount], [PurchasePrice], [LastUpdated], [OutCount]) VALUES (N'', N'd', N'd', N'2003', N'd', N'd', 8, 1, 2800, 0, 2800, CAST(0x7F390B00 AS Date), 7)
INSERT [dbo].[TblStock] ([ISBN], [Title], [Author], [Year], [Edition], [Publisher], [Count], [PriceChangable], [OriginalPrice], [Discount], [PurchasePrice], [LastUpdated], [OutCount]) VALUES (N'', N'g', N'g', N'2014', N'g', N'g', 40, 1, 900, 2, 882, CAST(0x5F390B00 AS Date), 0)
INSERT [dbo].[TblStock] ([ISBN], [Title], [Author], [Year], [Edition], [Publisher], [Count], [PriceChangable], [OriginalPrice], [Discount], [PurchasePrice], [LastUpdated], [OutCount]) VALUES (N'', N'h', N'h', N'1992', N'h', N'h', 0, 1, 800, 0, 800, CAST(0x7B390B00 AS Date), 1)
INSERT [dbo].[TblStock] ([ISBN], [Title], [Author], [Year], [Edition], [Publisher], [Count], [PriceChangable], [OriginalPrice], [Discount], [PurchasePrice], [LastUpdated], [OutCount]) VALUES (N'', N'k', N'k', N'2003', N'k', N'k', 0, 1, 900, 0, 900, CAST(0x7B390B00 AS Date), 2)
INSERT [dbo].[TblStock] ([ISBN], [Title], [Author], [Year], [Edition], [Publisher], [Count], [PriceChangable], [OriginalPrice], [Discount], [PurchasePrice], [LastUpdated], [OutCount]) VALUES (N'', N'o', N'o', N'2014', N'o', N'o', 10, 1, 600, 0, 600, CAST(0x7F390B00 AS Date), 5)
INSERT [dbo].[TblStock] ([ISBN], [Title], [Author], [Year], [Edition], [Publisher], [Count], [PriceChangable], [OriginalPrice], [Discount], [PurchasePrice], [LastUpdated], [OutCount]) VALUES (N'', N'sha', N'sha', N'2014', N'sha', N'sha', 3, 1, 3000, 0, 3000, CAST(0x7F390B00 AS Date), 2)
/****** Object:  Table [dbo].[TblShankar]    Script Date: 01/18/2015 19:32:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TblShankar](
	[CustomerID] [varchar](20) NOT NULL,
	[Name] [varchar](150) NOT NULL,
	[Father Name] [varchar](100) NOT NULL,
	[DOB] [date] NOT NULL,
	[Parent Phone] [varchar](20) NOT NULL,
	[Parent Mobile] [varchar](20) NOT NULL,
	[Student Mobile] [varchar](20) NOT NULL,
	[Address] [varchar](500) NOT NULL,
	[CollegeName] [varchar](300) NOT NULL,
	[Course] [varchar](200) NOT NULL,
	[CourseDuration] [int] NOT NULL,
	[EmailID] [varchar](150) NOT NULL,
	[MembershipDate] [date] NOT NULL,
	[MembershipType] [varchar](50) NOT NULL,
	[MembershipPeriod] [int] NOT NULL,
	[Activation] [bit] NULL,
	[BookCount] [int] NOT NULL,
	[DepositAmount] [float] NOT NULL,
	[AdvanceAmount] [float] NULL,
	[BalanceAmount] [float] NULL,
	[RefundAmount] [float] NULL,
	[RecieptNumber] [varchar](20) NULL,
	[MaxLimit] [float] NOT NULL,
	[UsedLimit] [float] NOT NULL,
	[EarlyActivation] [bit] NULL,
	[CreatedDatetime] [datetime] NULL,
	[ImagePath] [varchar](400) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'401', N'Abhishek.M.Patil', N'Maheshbhai Patel', CAST(0x4A1A0B00 AS Date), N'', N'8469697433', N'7795972013', N'405,Mayur Park,Kadri Road,Mangalore,Karnataka', N'Srinivas School Of Engineering Mukka', N'BE', 48, N'', CAST(0xDC380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40E00C686FD AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'402', N'K.V.Sudheshna Rao', N'.Vadhiraja Rao', CAST(0x601E0B00 AS Date), N'08242483600', N'9449208135', N'9880785414', N'Hayavadana,Maladi Courts,Ambika Nagar,Kavoor,Mangalore-15', N'NMAMIT Nitte', N'BE', 48, N'kvsudeshnarao@gmail.com', CAST(0xDC380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40E00C75A49 AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'403', N'Zaki Farhan', N'Sakeena.K.M', CAST(0x5E1D0B00 AS Date), N'', N'9036483068', N'7760921101', N'S.L Mathias Road,Falnir,Mangalore', N'Sri Devi Institute Of TechnologyKanajar', N'BE', 48, N'jeffh316@gmail.com', CAST(0xDC380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40E00C81D34 AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'404', N'Chaya', N'Sundhar .K.S', CAST(0xA11C0B00 AS Date), N'', N'9740600602', N'9611247101', N'Bavaka Compound,Near Kukkodi stores,Baikampady', N'MITE Moodabidri', N'BE', 48, N'chaya.sunder66@gmail.com', CAST(0xDC380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40E00C89F7A AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'405', N'Ashik.I.Rauther', N'Ismail.K.Rauther', CAST(0x211E0B00 AS Date), N'', N'9686960879', N'9740580786', N'shivaji Nagar,First Lane,Nippani,Belgum-591237', N'Karavali Institute of Technology', N'BE', 48, N'ashikrauther80@gmail.com', CAST(0xDC380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40E00C986CC AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'406', N'Jevita.J.Tellis', N'Joe M Tellis', CAST(0x321D0B00 AS Date), N'08242400831', N'9980037466', N'9980037466', N'Tellis,Gurunagar,Konchady Post,Mangalore-8', N'Alvas Mijar', N'BE', 48, N'joemtellis@yahoo.com', CAST(0xDC380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40E00CA5AAE AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'407', N'Manjunath.S.P', N'Padmanaba.S.C', CAST(0x3F1E0B00 AS Date), N'', N'7760008560', N'8880822223', N'Shivapura,Eppadi Post,Kunigal Taluk,Karnataka', N'Karavali Institute of Technology', N'BE', 48, N'msaaratheep@gmail.com', CAST(0xDC380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40E00CB56F5 AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'408', N'ChethanR.Kanameshwar', N'Rajendra S Kanameshwar', CAST(0x281E0B00 AS Date), N'', N'7760953506', N'7204886815', N'Lig-147,Jalangar Bijapur(Present)David Thachil House,Kalpane,Kulshekar,Mangalore', N'Karavali Institute of Technology', N'BE', 48, N'chethankanameshwar@gmail.com', CAST(0xDC380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40E00CC0916 AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'409', N'Ian Melwil dsouza', N'NA', CAST(0xEF1B0B00 AS Date), N'', N'', N'7259336856', N'C/o Anni Dsouza,Panir House,Perlahatte Post,Mangalore-574160', N'NMAMIT Nitte', N'BE', 48, N'', CAST(0xDC380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40E00CC9466 AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'410', N'Prakyath', N'Reksha', CAST(0xAF1C0B00 AS Date), N'', N'988074611', N'9880974611', N'Prakyath Nilaya,Near Guttige House,Nagakannika Temple Road,Derebail,Konchady,Mangalore-575008', N'NMAMIT Nitte', N'BE', 48, N'prakyathR@yahoo.com', CAST(0xDC380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40E00CF1C88 AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'001', N'Rosita Meena Misquith', N'Joyce Misquith', CAST(0xF4200B00 AS Date), N'08242451376', N'', N'0000000000', N'Matadakami,1st cross road,Boloor,Mangalore-6', N'St.Aloysius P.U College', N'PUC', 24, N'', CAST(0x8F380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A4000139769A AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'001A', N'Raihan', N'T.Ahmed', CAST(0xC5200B00 AS Date), N'', N'9743701336', N'9844501783', N'Site No 411,7th block,Krishnapura,Surathkal-15', N'B.G.S Composite P U College', N'PUC', 24, N'', CAST(0x8E380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40100EFCC70 AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'002', N'Aishwarya Alva K', N'Muralidhar.Alva.K', CAST(0xE01B0B00 AS Date), N'', N'9448869413', N'9480220433', N'Kukkaje House,Manchi Post,Ira Bantwal Taluk-574323', N'Sahyadri College of Engineering', N'BE', 48, N'aishwarya_alva@yahoo.com', CAST(0x8F380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A400013C7E2B AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'003', N'Delwin Winston Saldanha', N'Diana Saldanha', CAST(0x9B1F0B00 AS Date), N'08242262724', N'9945773138', N'9945773138', N'Saldanha villa,Taipakal House,Vamanjoor post,Mangalore-575028', N'St.Aloysius P.U College', N'PUC', 24, N'', CAST(0x22370B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A400013D9360 AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'004', N'Nidheesh.B.N', N'Narasimha Bhat B', CAST(0xE1200B00 AS Date), N'08251287796', N'', N'9446437796', N'Sannidhi Balemoole Post,Balemoole Kasaragod Tq,Kasargod-671552', N'Sri Sathaya Sai P U College Alike', N'PUC', 24, N'', CAST(0x8F380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A400014025D0 AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'005', N'Vandana Ananda Hegde', N'Vijayalaxmi', CAST(0xE91C0B00 AS Date), N'', N'9482965769', N'9945964093', N'Kerehadi House,Bairampalli Village,Harikandige Post,Udupi', N'MITE', N'BE', 48, N'', CAST(0x8F380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40001412D3A AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'006', N'Sanketh', N'Krishnappa Bangera', CAST(0x3C1D0B00 AS Date), N'', N'9945288764', N'9900926647', N'Banglegudde,Panemanglur,Bantwal Taluk-574231', N'Sahyadri College of Engineering', N'BE', 48, N'sankethbangera2014@gmail.com', CAST(0x8F380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40001421943 AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'007', N'Vikas.B', N'Suresh.B', CAST(0x0D1D0B00 AS Date), N'', N'9946757292', N'9740866235', N'S/o Suresh B,kurtargaradka,kumpta,671321,Kasargod', N'Sahyadri College of Engineering', N'BE', 48, N'vikasb113@gmail.com', CAST(0x8F380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A400014306A9 AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'008', N'Abhishek k', N'P.M.Krishnananda', CAST(0xA41D0B00 AS Date), N'08255280687', N'9448121687', N'7411082809', N'P.M.Krishnanda,Narikombu post,Manimajul House,Bantwal Taluk-874231', N'Sahyadri College of Engineering', N'BE', 48, N'abhishekabhi.11071999@gmail.com', CAST(0x8F380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A4000144505F AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'009', N'Abdul Atish Mohammed', N'Rahmatul Sameena', CAST(0x8F200B00 AS Date), N'', N'', N'8943365774', N'Thoufeeq mahaal Kudukoli Post,Perla,Kasargod dist,Kerala', N'Sri Sathaya Sai P U College Alike', N'PUC', 24, N'', CAST(0x90380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40001464B1D AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'010', N'Aadesh D.Shetty', N'Deepak.N.Shetty', CAST(0xD2210B00 AS Date), N'', N'9980310943', N'8197005121', N'Behind old municipal office,Goodshed road,Bunder,Mangalore-01', N'St.Aloysius P.U College', N'PUC', 24, N'', CAST(0x94380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A400016DA72B AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'011', N'Melissa Benadicta Saldanha', N'Melroy Saldanha', CAST(0x42220B00 AS Date), N'08242211017', N'9880379752', N'9036692704', N'Manu nivas,Maryhill,Mangalore-575008', N'St.Agnes P.U College', N'PUC', 24, N'saldanhamalissa1998@gmail.com', CAST(0x94380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A400016EA9D7 AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'012', N'Swathi.K', N'L.D.Krishnamurthy', CAST(0xFB1D0B00 AS Date), N'08242464962', N'9481760200', N'8105894775', N'L.D.Krishnamurthy,Near CRS,First cross,Kodialbail Mangalore', N'Sahyadri College of Engineering', N'BE', 48, N'swathi0695@gmail.com', CAST(0x94380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A400017015DF AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'013', N'Rakshith', N'Shashikala', CAST(0x2B200B00 AS Date), N'', N'', N'9741000267', N'Kotekar Post,Near travels Banglow,Mangalore-575021', N'St.Aloysius P.U College', N'PUC', 24, N'', CAST(0x94380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A4000170E219 AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'014', N'Akshatha.K', N'Kamalaksha', CAST(0x08220B00 AS Date), N'', N'9900458829', N'9611415591', N'Suvarna Compound,Near Vishranthi church,Bockapatna Mangalore-575003', N'Canara PU College', N'PUC', 24, N'akshatha8898@gmail.com', CAST(0x95380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A4000171F912 AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'015', N'Shefali.B.S', N'B.Sheena', CAST(0xD9200B00 AS Date), N'', N'9448503040', N'9480487282', N'sRI dEVI kRIPA,2-66/3,J.M.Road,Alape,Bajal,Mangalore,575007', N'St.Agnes P.U College', N'PUC', 24, N'shefali.sharel@gmail.com', CAST(0x95380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A4000172D0C2 AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'016', N'Mark Gonsalves', N'Sujith.K.Gonsalves', CAST(0x400F0B00 AS Date), N'', N'9611773319', N'9611773319', N'Leon Villa,Althotte road,Bondel Post,Mangalore-575008', N'St.Aloysius P.U College', N'PUC', 24, N'', CAST(0x94380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40001737F71 AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'017', N'Avinash.C.Karkera', N'Raghav', CAST(0x0E220B00 AS Date), N'', N'9964277034', N'8105093850', N'Ananda Nagar Complex,Santhekatte Post,Udupi', N'Canara Engineering College Benjanapadav', N'BE', 48, N'avinashkarkera859@gmail.com', CAST(0x94380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A400017480D0 AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'018', N'Lawrence Fernandes', N'B.D.Fernandes', CAST(0xDD1A0B00 AS Date), N'', N'9448729288', N'9483668958', N'St.Sabestian Villa,Palya Road,Honnawar', N'St.Joseph Engineering College Vamanjoor', N'BE', 48, N'fernandeslawrenceb@gmail.com', CAST(0x96380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40001756EE8 AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'019', N'Roshan Shetty.N.H', N'Harish Shetty', CAST(0x0B1C0B00 AS Date), N'', N'9845580298', N'8147657060', N'Jeswin Apartment,Flat No.402,Bejai new road,Mangalore', N'Vivekananda College of Engineering', N'BE', 48, N'', CAST(0x96380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40001761BEE AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'020', N'Krithika.S.Upadyaya', N'S.M.Udupa', CAST(0xFB1F0B00 AS Date), N'08242495599', N'9480532999', N'9480532999', N'Sri Raksha,301,Advaith Apartments,Kodialguthu(W) ,Mangalore-575003', N'Canara PU College', N'PUC', 24, N'', CAST(0x96380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A4000176E2E2 AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'021', N'Amina Rukhiya', N'Umar Farooq', CAST(0x6C210B00 AS Date), N'08244268383', N'9845118383', N'7847818383', N'Flat No.501,Vishwas Kalandan Court,Rosario Church road,Mangalore-575001', N'St.Agnes P.U College', N'PUC', 24, N'gsaamira@gmail.com', CAST(0x97380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40100AFEF0B AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'022', N'Chaithra.M.Shetty', N'Monappa Shetty', CAST(0x5B390B00 AS Date), N'08242200507', N'9448445461', N'9448445461', N'Sindura Badagaekkaru,Ekkaru Post,574509,Mangalore,D.K', N'Sri Devi Technology Kenjaaru', N'BE', 48, N'', CAST(0x97380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40100B1C5CD AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'023', N'Nishal', N'Naveen', CAST(0x311C0B00 AS Date), N'', N'8123720281', N'9036403503', N'Laxmi Narasimha,Kanakanady,Shenoy Complex,Kankanady Post,Mangalore', N'St.Joseph Engineering College Vamanjoor', N'BE', 48, N'', CAST(0x97380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40100B28014 AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'024', N'Bibin.S.Vayhev', N'Scaria Vayhev', CAST(0x1F1A0B00 AS Date), N'', N'', N'8141190471', N'', N'Sri Devi Technology Kenjaaru', N'BE', 48, N'', CAST(0x97380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40100B40EC1 AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'024/5201', N'Abhijeeth.V.Kumar', N'B.Vasanth Kumar', CAST(0x85210B00 AS Date), N'', N'9449081660', N'9480761032', N'S/o B.Vasanth Kumar,D.No 23-11-972/4,Abhi Harsh', N'Sharada PU College', N'PUC', 24, N'', CAST(0x97380B00 AS Date), N'N', 24, 1, 0, 0, 0, 0, 0, N'', 0, 0, 1, CAST(0x0000A40100B4FFCB AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'025', N'Vindhya Shetty', N'Yashawantha.G.Shetty', CAST(0x70210B00 AS Date), N'', N'9739251454', N'8792279959', N'Yashasvi,Palimar House,Church road,Bejai,Mangalore', N'Canara PU College', N'PG', 24, N'vindhmount@yahoo.co.in', CAST(0x97380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40100B5B4C7 AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'026', N'Sinan Muhiuddeen', N'Usman', CAST(0x931A0B00 AS Date), N'', N'', N'8147637019', N'301,Casa lavina,Vacalane,575002', N'St.Joseph Engineering College Vamanjoor', N'BE', 48, N'funkybay267@gmail.com', CAST(0x99380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40100BA73AA AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'027', N'Sonali.P.Rao', N'Anupama Rao', CAST(0x771B0B00 AS Date), N'', N'9341797888', N'7760611201', N'Nithya Kutira,Narayana Karkera Complex,Bolar,Mulihithlu,Mangalore', N'Sahyadri College of Engineering', N'BE', 48, N'sonalirao31@yahoo.com', CAST(0x99380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40100BBA4CE AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'028', N'Deekshith.B.Shetty', N'Shakila.B.Shetty', CAST(0x491D0B00 AS Date), N'08242414339', N'9663837490', N'8971923670', N'Saraswathi Nilaya,Hanikere Tailory Road,Mulihithlu,Mangalore-575001', N'MITE', N'BE', 48, N'shetty_deekshiv11@yahoo.co.in', CAST(0x99380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40100BDB2DB AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'029', N'Mohamad Faizan', N'Farida Parvin', CAST(0xA91B0B00 AS Date), N'08242252165', N'9945311384', N'9902660682', N'Faizan Manzeel,Kattalsar Road,Permude Post,574509', N'Sri Devi Technology Kenjaaru', N'BE', 48, N'faizanmohammed70@yahoo.com', CAST(0x99380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40100BE9173 AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'030', N'Parvathi.K', N'Kadresha', CAST(0x1E1D0B00 AS Date), N'', N'9482618634', N'8762057450', N'Parvathi.K,Kudmul Rangarav Hostel,Kodialbail,PVS,Mangalore', N'Sahyadri College of Engineering', N'BE', 48, N'', CAST(0x99380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40100BF2C02 AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'031', N'Suraj Suresh Shetty', N'Divya Shetty', CAST(0xFA200B00 AS Date), N'', N'9008915326', N'9008939869', N'Flat No.601,6th Floor,Venkataramana Towers,Car Street,Mangalore', N'St.Aloysius P.U College', N'PUC', 24, N'Suraj1197@yahoo.com', CAST(0x98380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40100BFCD13 AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'032', N'Prakrithi.Rao.T', N'Nagaraj Rao', CAST(0xF11F0B00 AS Date), N'', N'', N'9448992165', N'Sri Sharada Nivas,Planters Home,Bunts Hostel,Mangalore-575003', N'Sharada PU College', N'PUC', 24, N'', CAST(0x99380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40100C0755C AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'033', N'Roshin Baby Varghese', N'Baby Verghese', CAST(0xF31B0B00 AS Date), N'', N'9796375764', N'9591667875', N'D.No 6-112/27(1),Nethravathi Layout,Capithanio,Mangalore-575002', N'Sahyadri College of Engineering', N'BE', 48, N'theroshin@gmail.com', CAST(0x99380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40100C10F8B AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'034', N'Divya Madonna Dsouza', N'Mark Dsouza', CAST(0xB8210B00 AS Date), N'08242222233', N'9964280840', N'9480156647', N'Divya Sadhan,Behind Nantoor Cross,Karavali Lane,Mangalore-575002', N'St.Agnes P.U College', N'PUC', 24, N'', CAST(0x99380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40100C1A2A5 AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'035', N'Meghashree', N'T.Balakrishna', CAST(0x6B200B00 AS Date), N'', N'9945897720', N'9945897720', N'Krithika house,Near Ladies Hostel,Mahakaali Temple Road,Derebail,Kankanady,Mangalore-575008', N'NA', N'PUC', 24, N'', CAST(0x99380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40100C22C87 AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'036', N'Ahmad Shakeel', N'Mohamad.P', CAST(0xF91F0B00 AS Date), N'08255281075', N'9480862425', N'9742452575', N'opp BJM Aladka,Panemangalore-574231', N'B.A PU College', N'PUC', 24, N'', CAST(0x99380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40100C2BE81 AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'037', N'Wasiq', N'Mohamad.P.A', CAST(0xFF1E0B00 AS Date), N'', N'9620773755', N'9986322800', N'B-104,Casa Grande Apartments,starrock Road,Attavar,Mangalore', N'Mahesh PU College', N'PUC', 24, N'wasiq.ibrahim@yahoo.com', CAST(0x9A380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40100C382F4 AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'038', N'Sidharth.P.N', N'P.Narayanan', CAST(0x981B0B00 AS Date), N'04994223303', N'9446044203', N'8089375016', N'Nellikannu,Ambedkar road,Kasaragod-671121,Kerala', N'Karavali College Mangalore', N'BE', 48, N'sidhuksdqe@gmail.com', CAST(0x9A380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40100C43834 AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'040', N'Aishwari Deona Rebello', N'Deena Rebello', CAST(0x90220B00 AS Date), N'08242443383', N'9880802383', N'9880802383', N'201 Padma Emclave,Coelho Lane,Falneer,Mangalore', N'St.Agnes P.U College', N'PUC', 24, N'deevee04@hotmail.com', CAST(0x9A380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40100C5E0B9 AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'041', N'Nitish Kumar baliga', N'Namratha Baliga', CAST(0x95210B00 AS Date), N'', N'9741393777', N'9741393777', N'Flat No.102,PVS Kalakunja Road,Mangalore-575003', N'S.A.C', N'PUC', 24, N'baliga100@gmail.com', CAST(0x9A380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40100F07E09 AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'042', N'Vishal.K.S', N'K.V.Shridhar', CAST(0x36210B00 AS Date), N'', N'', N'9449589026', N'3-129/1(4),Thodlagudda Road,Kunjathabail Post,Kavoor,Mangalore', N'Canara PU College', N'PUC', 24, N'vishalks.jan10@gmail.com', CAST(0x9A380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40100F13D71 AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'043', N'Dhanush', N'L.Yashwanth Kumar', CAST(0x87200B00 AS Date), N'', N'9448104467', N'9448104467', N'Bhavani Ganesh Complex,Bejai,Mangalore', N'Sharada PU College', N'PUC', 24, N'dhanushyash@yahoo.com', CAST(0x9A380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40100F1CF06 AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'044', N'Sheetal', N'Chandrashekar', CAST(0x23230B00 AS Date), N'', N'', N'9900829956', N'Sheethal Nivas,Shivajinagar Post,Bondel,Pachanady Mangalore-575008', N'St.Agnes P.U College', N'PUC', 24, N'', CAST(0x9A380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40100F24FFD AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'045', N'Ashmitha', N'Chandrakala.D', CAST(0xD81F0B00 AS Date), N'', N'8792393567', N'8050222763', N'Divyashree,Near Baliga Stores.', N'Canara PU College', N'PUC', 24, N'', CAST(0x9A380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40100F3817F AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'046', N'Seema Melody', N'Gregory Noronha', CAST(0x99380B00 AS Date), N'', N'9480035043', N'8496013257', N'Ajekala House,Amtady Post,Bantwal', N'S.V.S College Bantwal', N'Degree', 36, N'', CAST(0x9B380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40100F304D7 AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'047', N'Ajay Kumar.K.V', N'Vishwanath Jogi', CAST(0x99380B00 AS Date), N'', N'9972043847', N'8722821977', N'Ashritha,Near Kordabbu Temple,Kajila,Thenkulipady Village,Malali Post Mangalore', N'S.Joseph P.U.College Bajpe', N'PUC', 24, N'', CAST(0x9A380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40100F46975 AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'048', N'Ustav', N'Umesh', CAST(0x4A210B00 AS Date), N'', N'9880988148', N'9880988148', N'Doomapaas House,Old Kent Road,Pandeshwar,Mangalore-575001', N'St.Aloysius P.U College', N'PUC', 24, N'ustavkarkera@gmail.com', CAST(0x9B380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40100F50712 AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'049', N'Rajath', N'Jagdish', CAST(0x26210B00 AS Date), N'', N'9611005769', N'9611065769', N'S.r.Nilaya,Adimar Gorigudda,Kankanady,Mangalore', N'NITTE PU CollegeNantoor', N'PUC', 24, N'', CAST(0x9B380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40100F58CCC AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'050', N'Alison Lobo', N'Wilma Lobo', CAST(0xED210B00 AS Date), N'', N'9739354557', N'9739354557', N'Near Maryhill Convent,Konchady Post,Mangalore-575008', N'St.Agnes P.U College', N'PUC', 24, N'', CAST(0x9C380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40100F61088 AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'051', N'Deeksha Prabhu', N'NA', CAST(0x35230B00 AS Date), N'', N'9448108217', N'9448108217', N'Haribettu House,Veerakamba Village,Bantwal Taluk-574222', N'Sri Rama PU College Kalladka', N'PUC', 24, N'', CAST(0x9C380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40100F9B6EA AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'052', N'Sahil.N.Raj', N'B.V.Nagaraj', CAST(0x42210B00 AS Date), N'08242244751', N'9343567728', N'9343567728', N'B.V.Nagaraj,D.No 130/70,Bollagudda,Kuthadka,Bajal,Mangalore-575007', N'Sharada PU College', N'PUC', 24, N'', CAST(0x9B380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40100F6D4E9 AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'053', N'Ritwic', N'Geetha.r.Salian', CAST(0x71200B00 AS Date), N'08242212363', N'9986567763', N'7353830398', N'Suvarna Nilaya,Bharathi Nagar,Bejai,Mangalore', N'Sharada PU College', N'PUC', 24, N'rit356@gmail.com', CAST(0x9B380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40100F76343 AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'054', N'Yamen Akthar Mohammed', N'Asiya Akthar', CAST(0x56200B00 AS Date), N'08242424954', N'966191000', N'9844569231', N'Ali Bagh Mansion,Britto Lane,Falnir,Mangalore-575002', N'St.Aloysius P.U College', N'PUC', 24, N'yamenns@gmail.com', CAST(0x9B380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40100F8238F AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'055', N'Kalpana.K', N'Shambayya', CAST(0x39220B00 AS Date), N'08256264022', N'8494850436', N'8494850436', N'Sri Durga Kripa,Ballamanja post,Mattina,Belthangady-574224', N'Sacred Heart PU College Madanthyar', N'PUC', 24, N'', CAST(0x9C380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40100FA8CAE AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'056', N'Suma', N'Hanumantha', CAST(0xD0200B00 AS Date), N'08242221301', N'9591715125', N'8151824318', N'Ujwala Apartment,Opp Syndicate Bank,Kadri road,Mangalore', N'Govt.PU College for womensBalmatta', N'PUC', 24, N'', CAST(0x9C380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40100FB5769 AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'057', N'Shravan.K.Das', N'Shanmuga Das', CAST(0xC91C0B00 AS Date), N'', N'9744508060', N'8951471721', N'Room No-003,Saalwyyn,Near bharath Mall,Kapikad ', N'Sri Devi Technology Kenjaaru', N'BE', 48, N'shravankdas007@gmail.com', CAST(0x9C380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40100FC1F4C AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'058', N'Ganapathi Ragoba Tamse', N'Raghoba Tamse', CAST(0xE71A0B00 AS Date), N'', N'', N'7259340486', N'At Post,Hankon,Hotegali,Karrnar', N'Canara Engineering College Benjanapadav', N'BE', 48, N'ganapatitamse@gmail.com', CAST(0x9D380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40100FCD15F AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'059', N'Praful Kumar.A', N'Prakash', CAST(0xB81D0B00 AS Date), N'', N'9480206066', N'8970877410', N'Bhramari House,Subramanya Nagara,Neermarga,Mangalore-575024', N'Sri Devi Technology Kenjaaru', N'BE', 48, N'', CAST(0x9D380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40100FD4A3F AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'060', N'Smitha Rebello', N'Joyce Rebello', CAST(0x5B210B00 AS Date), N'', N'9483202041', N'9481848703', N'Flat no.103,Ford Mansion,New Balmatta road,Mangalore-575001', N'St.Agnes P.U College', N'PUC', 24, N'smireb123@gmail.com', CAST(0x9D380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40100FDE55C AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'061', N'Kishan.C.D', N'Divijaksha.C.D', CAST(0x76040B00 AS Date), N'', N'9945371127', N'9741630911', N'S.K.Chambers,Jyothinagar,Marakada Village,Kunjathabail post,Mangalore', N'NITTE PU College Nantoor', N'PUC', 24, N'', CAST(0x9D380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A401013CFC4D AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'062', N'Supritha', N'Ramesh shetty', CAST(0x08210B00 AS Date), N'', N'9945856772', N'9743114975', N'Kattinja house,Kodman Village,Bantwal Taluk,Farangipet', N'Govt.PU College for womensBalmatta', N'PUC', 24, N'', CAST(0x9E380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A401013D87FF AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'063', N'Ayisha', N'Abdul Basheer', CAST(0xAF200B00 AS Date), N'', N'9663334523', N'9972119529', N'Baliyur residency,Kalladka House,Golthamajal Village,Bantwal', N'Govt.PU College for womensBalmatta', N'PUC', 24, N'', CAST(0x9E380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A401013E0AFD AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'064', N'Gayathri', N'Monappa Shettigar', CAST(0x40210B00 AS Date), N'', N'9964604454', N'9964604454', N'Ashirvadha House,Mariyamma Croli,Konaje post,Mangalore', N'Govt.PU College for womens Balmatta', N'PUC', 24, N'', CAST(0x9E380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40101429A76 AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'066', N'Karthik Bhat Adyathimar', N'Gopalkrishna Bhat', CAST(0xD6200B00 AS Date), N'', N'9980546290', N'9591892816', N'Adhyathimar House,Bettenapady,Puttur-574259', N'Vivekananda PU College Puttur', N'PUC', 24, N'karthik.bhata7@gmail.com', CAST(0x9E380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40101456107 AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'067', N'Jewer Mercy Fernandes', N'NA', CAST(0x701C0B00 AS Date), N'08242221856', N'', N'8197806127', N'Bikarnakatte,Bajjodi,Mangalore', N'St.Joseph Engineering College Vamanjoor', N'BE', 48, N'', CAST(0x9E380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A4010145F58E AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'067A', N'Rachna Shetty', N'Rekha Shetty', CAST(0x411D0B00 AS Date), N'', N'9663087184', N'7795956275', N'Ashraya,Near Jarandaya temple,Barebail,Yeyyadi,Mangalore', N'St.Joseph Engineering College Vamanjoor', N'BE', 48, N'rachushetty18@gmail.com', CAST(0xCE380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A4010146D841 AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'068', N'Swathi.K', N'Radhakrishna Shetty', CAST(0x66220B00 AS Date), N'', N'', N'8495855208', N'Kuriya House,Kurudapadavu Post,Uppala via Kasargod', N'Vivekananda PU College Puttur', N'PUC', 24, N'swathishetty75@gmail.com', CAST(0xA0380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40101478F67 AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'069', N'Sachin Mallya K', N'Suresh mallya', CAST(0xEE1B0B00 AS Date), N'08251234767', N'9483292277', N'8749007414', N'Dsouza compound,Pallaki House,L.P layout,Puttur-574202', N'Vivekananda College of Engineering', N'BE', 48, N'sachinmal09@gmail.com', CAST(0xA0380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40101488FEA AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'070', N'Rithik rai', N'Jaikishan Rai', CAST(0x6C1C0B00 AS Date), N'', N'8971153472', N'8971153472', N'Flat No-G4 ,Sharada Residency,Matadakani,3rd cross,Ashoknagar,Mangalore-575006', N'Sahyadri College of Engineering', N'BE', 48, N'rithikrai.rai@gmail.com', CAST(0xA0380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A401014C187D AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'071', N'Ajay.B', N'Govinda Nayak', CAST(0x921A0B00 AS Date), N'', N'9480240635', N'9663999343', N'Baleguli House,Irde Post,Puttur taluk', N'St.Joseph Engineering College Vamanjoor', N'BE', 48, N'ajaybo793@gmail.com', CAST(0xA0380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A401014DDAB5 AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'072', N'Akash', N'Harishchandra Shettigar', CAST(0xC3210B00 AS Date), N'', N'8747857103', N'8722618169', N'Near Marlyne Apartments,Bejai,Battagudda', N'NITTE PU College Nantoor', N'PUC', 24, N'', CAST(0xA0380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A401014E76AF AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'073', N'Rakshith S Hegde', N'Lalitha', CAST(0x88220B00 AS Date), N'08242281501', N'', N'9741074772', N'Santyaguthu,Kinya Post,Talapaddy Mangalore', N'NITTE PU College Nantoor', N'PUC', 24, N'rakshithhegde1998@gmail.com', CAST(0xA0380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A401014F20D3 AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'074', N'Smitha.S.M', N'Leelavathi', CAST(0x8D220B00 AS Date), N'', N'9980951659', N'9980951659', N'D.No 1/4,Kuntikan,Mangalore', N'Canara PU College', N'PUC', 24, N'', CAST(0xA0380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A401014FAE58 AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'075', N'Fathima Nihala Sulthana', N'Mohammas Abbas Koppala', CAST(0xA61F0B00 AS Date), N'', N'', N'8277427295', N'C.P.C Compound,Kudroli Mangalore', N'Canara PU College', N'PUC', 24, N'', CAST(0xA0380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A4010161048C AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'076', N'Prathiksha', N'Keshava.b.Shettigar', CAST(0x59210B00 AS Date), N'', N'9481607992', N'9972163115', N'Ganesh Kripa,Mogrody,Padavinangady,Mangalore', N'NITTE PU College Nantoor', N'PUC', 24, N'', CAST(0xA0380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40101617BD8 AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'077', N'Sharadda Shetty', N'Vijaya Shetty', CAST(0x67210B00 AS Date), N'', N'7204062943', N'9901741274', N'Canara Building,Room No.405,Near Sharavu Temple,Mangalore-575001', N'St.Agnes P.U College', N'PUC', 24, N'', CAST(0xA0380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40101620CF0 AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'078', N'Ankitha Dewasi', N'Mrs.Usha Hegde', CAST(0x21200B00 AS Date), N'', N'9449101870', N'9449101870', N'No.407,4th Floor,Shankambari Apartments,Near KSRTC Bustand,Bejai,Mangalore', N'Mahesh PU College', N'PUC', 24, N'ankitadewasi@yahoo.in', CAST(0xA0380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40101631A34 AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'079', N'Roshni.P.S', N'Sunil.P.A', CAST(0xA2210B00 AS Date), N'', N'9845269402', N'9845269402', N'Jeeth Nilaya,Thilak Nagar,Boloor,Mangalore', N'Canara PU College', N'PUC', 24, N'', CAST(0xA0380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40101638C30 AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'080', N'Afia Fathima', N'Abdul Hameed', CAST(0x3D210B00 AS Date), N'', N'9686926138', N'9686926138', N'#34,Happy Home Apartments,Arya Samaja Road,Balmata,Mangalore', N'St.Aloysius P.U College', N'PUC', 24, N'afia_nabeel@yahoo.com', CAST(0xA1380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40101642B65 AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'081', N'Navya.N.Kotian', N'Naveen Chandra', CAST(0x5A210B00 AS Date), N'', N'9448058274', N'9886800580', N'D.No 4-130/4,Chandrodaya,Malemar,Derebail,Mangalore-575006', N'Canara PU College', N'PUC', 24, N'', CAST(0xA1380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A4010164C767 AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'082', N'Shamseena', N'NA', CAST(0x00210B00 AS Date), N'', N'9880345095', N'9880345095', N'Haneef Manzil,Marakada,Millathnagar,Mangalore', N'Dadyhill Victoria', N'PUC', 24, N'', CAST(0xA1380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A4010165487D AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'083', N'Bindiya', N'Sunitha Lokesh', CAST(0x46210B00 AS Date), N'', N'', N'9008724248', N'Kokesh Bindiya,Kodikal,Jokatte,Mangalore-575006', N'Canara PU College', N'PUC', 24, N'', CAST(0xA1380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A4010165C290 AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'084', N'Prajwal.M.J', N'Janardhan.G', CAST(0xBC210B00 AS Date), N'', N'8762025639', N'9448541560', N'E.S.I Hospital,No.23,Kadri,Shivabagh,Mangalore-575002', N'Sharada PU College', N'PUC', 24, N'', CAST(0xA1380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40101663CF5 AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'085', N'Amulya.A.Shetty', N'Arun.M.Shetty', CAST(0x68210B00 AS Date), N'', N'9591264035', N'9632342965', N'Kappettre House,Ambalapady,N.H 66,Udupi', N'St.Cecielys PU College', N'PUC', 24, N'', CAST(0xA1380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A4010166E72F AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'086', N'Nikitha.H.Amin', N'Harish', CAST(0xF5220B00 AS Date), N'', N'9845494799', N'9845494799', N'Nishu Niki Nivas,Baidrapa,Near Ganapathi Temple,Masthikatte,Ullal', N'Sharada PU College', N'PUC', 24, N'', CAST(0xA1380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A4010167D447 AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'087', N'Megharaj', N'Bhavani', CAST(0x68220B00 AS Date), N'', N'9686628564', N'9686628564', N'8-105/1,Kanadka House,Shakthinagar,Mangalore', N'NITTE PU College Nantoor', N'PUC', 24, N'', CAST(0xA2380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A401016D31DE AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'088', N'Rakshith.S.Salian', N'M.Sheera', CAST(0x25210B00 AS Date), N'08242400748', N'9964867889', N'9964867889', N'1-102/4(7),Suraksha,Kerekadu,Kulai Post,Hosabettu,Mangalore-575026', N'Canara PU College', N'PUC', 24, N'', CAST(0xA2380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A401016DE845 AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'089', N'Nishith.J', N'Jayakar', CAST(0x1F210B00 AS Date), N'', N'9880611504', N'9880611504', N'Sri Devi Kripa,rainbow Lane,Naguri,Mangalore-575002', N'Sharada Vidyalaya Kodialbail', N'PUC', 24, N'', CAST(0xA2380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A401016E6226 AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'090', N'Rakshitha', N'NA', CAST(0x0C380B00 AS Date), N'', N'', N'9620920923', N'Nagamma Nivas,Second cross,Anegundi,Bejai,Mangalore-575003', N'Canara PU College', N'PUC', 24, N'', CAST(0xA2380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A401016ED36E AS DateTime), N'N/A')
GO
print 'Processed 100 total records'
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'090A/5202', N'Sushmitha', N'Naveen Kumar B', CAST(0xFF210B00 AS Date), N'', N'9686053508', N'9880149655', N'Sanidhya,First cross,Kodikal,Mangalore', N'Sharada Vidyalaya Kodialbail', N'PUC', 24, N'', CAST(0xA3380B00 AS Date), N'N', 24, 1, 0, 0, 0, 0, 0, N'', 0, 0, 1, CAST(0x0000A401016F77DB AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'091', N'Prathvi Mendon', N'Ramesh Mendon', CAST(0xB6210B00 AS Date), N'08242464243', N'9731614243', N'9731614243', N'Bhoomika Complex,Third Floor,University road,Thokkottu', N'St.Agnes P.U College', N'PUC', 24, N'prathvimendon@yahoo.com', CAST(0xA3380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A401017039F9 AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'092', N'Shreevathsa.T.Rao', N'Thippoji.M.Y', CAST(0x08220B00 AS Date), N'08242288179', N'9844288132', N'9164828197', N'Dasara mule,Konaje,Mangalore', N'NITTE PU College Nantoor', N'PUC', 24, N'vathsa.shree8@gmail.com', CAST(0xA3380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A4010171384F AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'093', N'Karthik.K', N'Avinash', CAST(0x78380B00 AS Date), N'', N'9164969066', N'9164969066', N'D.No 13,Veeramutthu,Labour Colony,Kuduremuka,Chikmagalur District', N'MGC PU College bondel', N'PUC', 24, N'', CAST(0xA3380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A4010172353C AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'094', N'Ayesha Afreen Sheikh', N'Nasheera S', CAST(0x8C200B00 AS Date), N'0824240601', N'9742332317', N'8971162195', N'Indus Home Apartments,Flat no.102,sulthan road,Falnir,Mangalore', N'St.Agnes P.U College', N'PUC', 24, N'', CAST(0xA4380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A4010172F3EF AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'095', N'Harshith', N'K.Vaman Gujarah', CAST(0xCC200B00 AS Date), N'', N'9945742771', N'9663657271', N'2-132/5,Baghavathi Nilaya,Acchukodi,Bondel,Mangalore', N'NITTE PU College Nantoor', N'PUC', 24, N'', CAST(0xA4380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40101737947 AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'096', N'Delman', N'NA', CAST(0x01380B00 AS Date), N'', N'', N'9902361297', N'Mangalore', N'Srinivas Institute of Technology', N'BE', 48, N'', CAST(0xA5380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40101741076 AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'097', N'Seema.C.S', N'Shivanarayana Bhat', CAST(0x5D200B00 AS Date), N'04998252202', N'', N'8547122202', N'Sri Raksha House,Miyapadav Post,via Manjeswar-671323', N'Sharada PU College', N'PUC', 24, N'', CAST(0xA5380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A4010174A214 AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'098', N'Akshay.C.Devadiga', N'Jayashri Devadiga', CAST(0x751F0B00 AS Date), N'', N'9763382459', N'8105171418', N'Sharu Mane,Landlinks,Near Ganesh hanuman Rice Mill, Konchadi', N'St.Aloysius P.U College', N'Degree', 36, N'akshaydevadiga4@gmail.com', CAST(0xA5380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A401017556DB AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'099', N'Swapna', N'Srinivas', CAST(0x97200B00 AS Date), N'08242223930', N'9483933095', N'9980932287', N'Sri Katileshwari Kripa,Behind Maha Kaali Temple,Derebail,Konchadi,Mangalore', N'Padua PU College Nantoor', N'PUC', 24, N'', CAST(0xA5380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A4010175F842 AS DateTime), N'N/A')
INSERT [dbo].[TblShankar] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'100', N'Nihal.M.Naik', N'Madhusudhan Naik', CAST(0x9F210B00 AS Date), N'08242435922', N'8197972375', N'8197972375', N'Shantha Durga Nilaya,Near S.N Temple Maroli Village', N'NITTE PU College Nantoor', N'PUC', 24, N'', CAST(0xA5380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40101769A96 AS DateTime), N'N/A')
/****** Object:  Table [dbo].[TblReceipt]    Script Date: 01/18/2015 19:32:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TblReceipt](
	[ReceiptNumber] [varchar](10) NOT NULL,
	[ReceiptDate] [datetime] NOT NULL,
	[HistoryUID] [varchar](100) NOT NULL,
	[PrintedFlag] [bit] NOT NULL,
 CONSTRAINT [PK_TblReceipt] PRIMARY KEY CLUSTERED 
(
	[ReceiptNumber] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[TblReceipt] ([ReceiptNumber], [ReceiptDate], [HistoryUID], [PrintedFlag]) VALUES (N'TRLND00888', CAST(0x0000A3FB0163E63D AS DateTime), N'', 0)
INSERT [dbo].[TblReceipt] ([ReceiptNumber], [ReceiptDate], [HistoryUID], [PrintedFlag]) VALUES (N'TRLND00999', CAST(0x0000A3FB0163E63D AS DateTime), N'', 0)
/****** Object:  Table [dbo].[TblOrders]    Script Date: 01/18/2015 19:32:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TblOrders](
	[CustomerID] [varchar](15) NOT NULL,
	[Date] [date] NULL,
	[ISBN] [varchar](25) NULL,
	[Count] [int] NOT NULL,
	[DepositAmount] [float] NOT NULL,
	[OrderClearanceDate] [date] NULL,
	[Mobile] [varchar](12) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TblIssue]    Script Date: 01/18/2015 19:32:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TblIssue](
	[CustomerID] [varchar](20) NOT NULL,
	[Title] [varchar](300) NOT NULL,
	[Author] [varchar](150) NOT NULL,
	[Edition] [varchar](20) NOT NULL,
	[Publisher] [varchar](150) NOT NULL,
	[IssueDate] [date] NOT NULL,
	[BookCount] [int] NOT NULL,
	[BookPrice] [float] NOT NULL,
	[RecieptNumber] [varchar](20) NOT NULL,
	[HistoryUID] [uniqueidentifier] NOT NULL,
	[IssueType] [varchar](25) NOT NULL,
	[ReturnDate] [date] NOT NULL,
	[EarlyIssue] [bit] NOT NULL,
 CONSTRAINT [PK_TblIssue] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC,
	[Title] ASC,
	[Author] ASC,
	[Edition] ASC,
	[Publisher] ASC,
	[BookPrice] ASC,
	[IssueDate] ASC,
	[HistoryUID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[TblIssue] ([CustomerID], [Title], [Author], [Edition], [Publisher], [IssueDate], [BookCount], [BookPrice], [RecieptNumber], [HistoryUID], [IssueType], [ReturnDate], [EarlyIssue]) VALUES (N'404', N'a', N'a', N'a', N'a', CAST(0x7F390B00 AS Date), 1, 460, N'TRLND01000', N'dd30f9f7-af8d-438d-832b-2cc4300131af', N'R', CAST(0x413A0B00 AS Date), 0)
INSERT [dbo].[TblIssue] ([CustomerID], [Title], [Author], [Edition], [Publisher], [IssueDate], [BookCount], [BookPrice], [RecieptNumber], [HistoryUID], [IssueType], [ReturnDate], [EarlyIssue]) VALUES (N'404', N'b', N'b', N'b', N'b', CAST(0x7F390B00 AS Date), 1, 1500, N'TRLND01000', N'4e7d4cc7-1f99-4baf-a621-dbe431e6a4b5', N'R', CAST(0x413A0B00 AS Date), 0)
INSERT [dbo].[TblIssue] ([CustomerID], [Title], [Author], [Edition], [Publisher], [IssueDate], [BookCount], [BookPrice], [RecieptNumber], [HistoryUID], [IssueType], [ReturnDate], [EarlyIssue]) VALUES (N'404', N'c', N'c', N'c', N'c', CAST(0x7F390B00 AS Date), 1, 2300, N'TRLND01000', N'2c4aa0d4-1e6a-4f75-9551-63ab4d4efea8', N'R', CAST(0x413A0B00 AS Date), 0)
INSERT [dbo].[TblIssue] ([CustomerID], [Title], [Author], [Edition], [Publisher], [IssueDate], [BookCount], [BookPrice], [RecieptNumber], [HistoryUID], [IssueType], [ReturnDate], [EarlyIssue]) VALUES (N'404', N'd', N'd', N'd', N'd', CAST(0x7F390B00 AS Date), 1, 2800, N'TRLND01000', N'479eb598-1590-40a3-9944-42b0a2ae9bd3', N'R', CAST(0x413A0B00 AS Date), 0)
INSERT [dbo].[TblIssue] ([CustomerID], [Title], [Author], [Edition], [Publisher], [IssueDate], [BookCount], [BookPrice], [RecieptNumber], [HistoryUID], [IssueType], [ReturnDate], [EarlyIssue]) VALUES (N'404', N'd', N'd', N'd', N'd', CAST(0x7F390B00 AS Date), 1, 2800, N'TRLND01000', N'd83d90da-5fc0-4858-a6e3-f7718d30d694', N'R', CAST(0x413A0B00 AS Date), 0)
INSERT [dbo].[TblIssue] ([CustomerID], [Title], [Author], [Edition], [Publisher], [IssueDate], [BookCount], [BookPrice], [RecieptNumber], [HistoryUID], [IssueType], [ReturnDate], [EarlyIssue]) VALUES (N'404', N'g', N'g', N'g', N'g', CAST(0x7F390B00 AS Date), 1, 900, N'TRLND01000', N'a755caff-532e-4516-8e52-25b60ecb81ff', N'R', CAST(0x413A0B00 AS Date), 0)
INSERT [dbo].[TblIssue] ([CustomerID], [Title], [Author], [Edition], [Publisher], [IssueDate], [BookCount], [BookPrice], [RecieptNumber], [HistoryUID], [IssueType], [ReturnDate], [EarlyIssue]) VALUES (N'404', N'o', N'o', N'o', N'o', CAST(0x7F390B00 AS Date), 1, 600, N'TRLND01000', N'479e8a73-bdf4-42fc-af2d-8662c62de9a1', N'R', CAST(0x413A0B00 AS Date), 0)
INSERT [dbo].[TblIssue] ([CustomerID], [Title], [Author], [Edition], [Publisher], [IssueDate], [BookCount], [BookPrice], [RecieptNumber], [HistoryUID], [IssueType], [ReturnDate], [EarlyIssue]) VALUES (N'404', N'sha', N'sha', N'sha', N'sha', CAST(0x7F390B00 AS Date), 1, 3000, N'TRLND01000', N'faa050e9-8521-4b79-88f1-7fa44601ee89', N'R', CAST(0x413A0B00 AS Date), 0)
INSERT [dbo].[TblIssue] ([CustomerID], [Title], [Author], [Edition], [Publisher], [IssueDate], [BookCount], [BookPrice], [RecieptNumber], [HistoryUID], [IssueType], [ReturnDate], [EarlyIssue]) VALUES (N'407', N'a', N'a', N'a', N'a', CAST(0x7F390B00 AS Date), 1, 460, N'TRLND01000', N'179396af-2c7b-4d54-8b24-55f4479c6897', N'R', CAST(0x043A0B00 AS Date), 0)
INSERT [dbo].[TblIssue] ([CustomerID], [Title], [Author], [Edition], [Publisher], [IssueDate], [BookCount], [BookPrice], [RecieptNumber], [HistoryUID], [IssueType], [ReturnDate], [EarlyIssue]) VALUES (N'407', N'b', N'b', N'b', N'b', CAST(0x7F390B00 AS Date), 1, 1500, N'TRLND01000', N'8da02bb7-d85d-423e-9284-2d83d217f601', N'R', CAST(0x043A0B00 AS Date), 0)
INSERT [dbo].[TblIssue] ([CustomerID], [Title], [Author], [Edition], [Publisher], [IssueDate], [BookCount], [BookPrice], [RecieptNumber], [HistoryUID], [IssueType], [ReturnDate], [EarlyIssue]) VALUES (N'407', N'b', N'b', N'b', N'b', CAST(0x7F390B00 AS Date), 1, 1500, N'TRLND01000', N'73aa76ef-6b0b-4e15-a176-394253fb3327', N'R', CAST(0x043A0B00 AS Date), 0)
INSERT [dbo].[TblIssue] ([CustomerID], [Title], [Author], [Edition], [Publisher], [IssueDate], [BookCount], [BookPrice], [RecieptNumber], [HistoryUID], [IssueType], [ReturnDate], [EarlyIssue]) VALUES (N'407', N'b', N'b', N'b', N'b', CAST(0x7F390B00 AS Date), 1, 1500, N'TRLND01000', N'9386191e-5e19-40e0-8b2d-52df99d46e57', N'R', CAST(0x043A0B00 AS Date), 0)
INSERT [dbo].[TblIssue] ([CustomerID], [Title], [Author], [Edition], [Publisher], [IssueDate], [BookCount], [BookPrice], [RecieptNumber], [HistoryUID], [IssueType], [ReturnDate], [EarlyIssue]) VALUES (N'407', N'c', N'c', N'c', N'c', CAST(0x7F390B00 AS Date), 1, 2300, N'TRLND01000', N'18cbff05-21e8-4ba0-9429-37dc9e32ae29', N'R', CAST(0x043A0B00 AS Date), 0)
INSERT [dbo].[TblIssue] ([CustomerID], [Title], [Author], [Edition], [Publisher], [IssueDate], [BookCount], [BookPrice], [RecieptNumber], [HistoryUID], [IssueType], [ReturnDate], [EarlyIssue]) VALUES (N'407', N'd', N'd', N'd', N'd', CAST(0x7F390B00 AS Date), 1, 2800, N'TRLND01000', N'3a821822-3c79-4dc9-a5db-5d1c482d2eae', N'R', CAST(0x043A0B00 AS Date), 0)
INSERT [dbo].[TblIssue] ([CustomerID], [Title], [Author], [Edition], [Publisher], [IssueDate], [BookCount], [BookPrice], [RecieptNumber], [HistoryUID], [IssueType], [ReturnDate], [EarlyIssue]) VALUES (N'407', N'd', N'd', N'd', N'd', CAST(0x7F390B00 AS Date), 1, 2800, N'TRLND01000', N'ef8b10ec-0a5c-4be8-8ff4-ed5d89549182', N'R', CAST(0x043A0B00 AS Date), 0)
INSERT [dbo].[TblIssue] ([CustomerID], [Title], [Author], [Edition], [Publisher], [IssueDate], [BookCount], [BookPrice], [RecieptNumber], [HistoryUID], [IssueType], [ReturnDate], [EarlyIssue]) VALUES (N'407', N'g', N'g', N'g', N'g', CAST(0x7F390B00 AS Date), 1, 900, N'TRLND01000', N'51b68920-a153-4ce7-be62-e16d5c9e342e', N'R', CAST(0x043A0B00 AS Date), 0)
INSERT [dbo].[TblIssue] ([CustomerID], [Title], [Author], [Edition], [Publisher], [IssueDate], [BookCount], [BookPrice], [RecieptNumber], [HistoryUID], [IssueType], [ReturnDate], [EarlyIssue]) VALUES (N'407', N'sha', N'sha', N'sha', N'sha', CAST(0x7F390B00 AS Date), 1, 3000, N'TRLND01000', N'b6ed38e8-b216-4e96-b29a-7fd6e2646948', N'R', CAST(0x043A0B00 AS Date), 0)
/****** Object:  Table [dbo].[TblID]    Script Date: 01/18/2015 19:32:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TblID](
	[IDDate] [date] NOT NULL,
	[ID] [varchar](20) NOT NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[TblID] ([IDDate], [ID]) VALUES (CAST(0x5B390B00 AS Date), N'2014150002')
/****** Object:  Table [dbo].[TblGsrReceipt]    Script Date: 01/18/2015 19:32:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TblGsrReceipt](
	[ReceiptNumber] [varchar](10) NOT NULL,
	[ReceiptDate] [datetime] NOT NULL,
	[HistoryUID] [varchar](100) NOT NULL,
	[PrintedFlag] [bit] NOT NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[TblGsrReceipt] ([ReceiptNumber], [ReceiptDate], [HistoryUID], [PrintedFlag]) VALUES (N'TRLND00999', CAST(0x0000A3FB0163E63D AS DateTime), N'', 0)
INSERT [dbo].[TblGsrReceipt] ([ReceiptNumber], [ReceiptDate], [HistoryUID], [PrintedFlag]) VALUES (N'TRLND00888', CAST(0x0000A3FB0163E63D AS DateTime), N'', 0)
INSERT [dbo].[TblGsrReceipt] ([ReceiptNumber], [ReceiptDate], [HistoryUID], [PrintedFlag]) VALUES (N'', CAST(0x0000A3FE0171C9CA AS DateTime), N'', 0)
INSERT [dbo].[TblGsrReceipt] ([ReceiptNumber], [ReceiptDate], [HistoryUID], [PrintedFlag]) VALUES (N'TRLND00001', CAST(0x0000A3FB01609BE3 AS DateTime), N'', 0)
INSERT [dbo].[TblGsrReceipt] ([ReceiptNumber], [ReceiptDate], [HistoryUID], [PrintedFlag]) VALUES (N'TRLND00002', CAST(0x0000A3FB0160F2BD AS DateTime), N'', 0)
INSERT [dbo].[TblGsrReceipt] ([ReceiptNumber], [ReceiptDate], [HistoryUID], [PrintedFlag]) VALUES (N'TRLND00003', CAST(0x0000A3FB0163977C AS DateTime), N'', 0)
INSERT [dbo].[TblGsrReceipt] ([ReceiptNumber], [ReceiptDate], [HistoryUID], [PrintedFlag]) VALUES (N'TRLND00004', CAST(0x0000A3FB0163E63D AS DateTime), N'', 0)
INSERT [dbo].[TblGsrReceipt] ([ReceiptNumber], [ReceiptDate], [HistoryUID], [PrintedFlag]) VALUES (N'TRLND00005', CAST(0x0000A3FE008C0689 AS DateTime), N'', 0)
INSERT [dbo].[TblGsrReceipt] ([ReceiptNumber], [ReceiptDate], [HistoryUID], [PrintedFlag]) VALUES (N'TRLND00006', CAST(0x0000A3FE008C5AC4 AS DateTime), N'', 0)
INSERT [dbo].[TblGsrReceipt] ([ReceiptNumber], [ReceiptDate], [HistoryUID], [PrintedFlag]) VALUES (N'TRLND00007', CAST(0x0000A3FE016C4251 AS DateTime), N'', 0)
/****** Object:  Table [dbo].[TblCustomerBooks]    Script Date: 01/18/2015 19:32:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TblCustomerBooks](
	[CustBookID] [int] NOT NULL,
	[CustomerID] [int] NOT NULL,
	[Title] [varchar](500) NULL,
	[Author] [varchar](200) NULL,
	[Edition] [varchar](20) NULL,
	[OriginalPrice] [float] NULL,
	[Count] [int] NOT NULL,
	[Date] [date] NULL,
	[HistoryUID] [uniqueidentifier] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TblCustomer_bckp]    Script Date: 01/18/2015 19:32:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TblCustomer_bckp](
	[CustomerID] [varchar](20) NOT NULL,
	[Name] [varchar](150) NOT NULL,
	[Father Name] [varchar](100) NOT NULL,
	[DOB] [date] NOT NULL,
	[Parent Phone] [varchar](20) NOT NULL,
	[Parent Mobile] [varchar](20) NOT NULL,
	[Student Mobile] [varchar](20) NOT NULL,
	[Address] [varchar](500) NOT NULL,
	[CollegeName] [varchar](300) NOT NULL,
	[Course] [varchar](200) NOT NULL,
	[CourseDuration] [int] NOT NULL,
	[EmailID] [varchar](150) NOT NULL,
	[MembershipDate] [date] NOT NULL,
	[MembershipType] [varchar](50) NOT NULL,
	[MembershipPeriod] [int] NOT NULL,
	[Activation] [bit] NULL,
	[BookCount] [int] NOT NULL,
	[DepositAmount] [float] NOT NULL,
	[AdvanceAmount] [float] NULL,
	[BalanceAmount] [float] NULL,
	[RefundAmount] [float] NULL,
	[RecieptNumber] [varchar](20) NULL,
	[MaxLimit] [float] NOT NULL,
	[UsedLimit] [float] NOT NULL,
	[EarlyActivation] [bit] NULL,
	[CreatedDatetime] [datetime] NULL,
	[ImagePath] [varchar](400) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'401', N'Abhishek.M.Patil', N'Maheshbhai Patel', CAST(0x4A1A0B00 AS Date), N'', N'8469697433', N'7795972013', N'405,Mayur Park,Kadri Road,Mangalore,Karnataka', N'Srinivas School Of Engineering Mukka', N'BE', 48, N'', CAST(0xDC380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40E00C686FD AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'402', N'K.V.Sudheshna Rao', N'.Vadhiraja Rao', CAST(0x601E0B00 AS Date), N'08242483600', N'9449208135', N'9880785414', N'Hayavadana,Maladi Courts,Ambika Nagar,Kavoor,Mangalore-15', N'NMAMIT Nitte', N'BE', 48, N'kvsudeshnarao@gmail.com', CAST(0xDC380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40E00C75A49 AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'081', N'Navya.N.Kotian', N'Naveen Chandra', CAST(0x5A210B00 AS Date), N'', N'9448058274', N'9886800580', N'D.No 4-130/4,Chandrodaya,Malemar,Derebail,Mangalore-575006', N'Canara PU College', N'PUC', 24, N'', CAST(0xA1380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A4010164C767 AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'082', N'Shamseena', N'NA', CAST(0x00210B00 AS Date), N'', N'9880345095', N'9880345095', N'Haneef Manzil,Marakada,Millathnagar,Mangalore', N'Dadyhill Victoria', N'PUC', 24, N'', CAST(0xA1380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A4010165487D AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'083', N'Bindiya', N'Sunitha Lokesh', CAST(0x46210B00 AS Date), N'', N'', N'9008724248', N'Kokesh Bindiya,Kodikal,Jokatte,Mangalore-575006', N'Canara PU College', N'PUC', 24, N'', CAST(0xA1380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A4010165C290 AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'084', N'Prajwal.M.J', N'Janardhan.G', CAST(0xBC210B00 AS Date), N'', N'8762025639', N'9448541560', N'E.S.I Hospital,No.23,Kadri,Shivabagh,Mangalore-575002', N'Sharada PU College', N'PUC', 24, N'', CAST(0xA1380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40101663CF5 AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'085', N'Amulya.A.Shetty', N'Arun.M.Shetty', CAST(0x68210B00 AS Date), N'', N'9591264035', N'9632342965', N'Kappettre House,Ambalapady,N.H 66,Udupi', N'St.Cecielys PU College', N'PUC', 24, N'', CAST(0xA1380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A4010166E72F AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'086', N'Nikitha.H.Amin', N'Harish', CAST(0xF5220B00 AS Date), N'', N'9845494799', N'9845494799', N'Nishu Niki Nivas,Baidrapa,Near Ganapathi Temple,Masthikatte,Ullal', N'Sharada PU College', N'PUC', 24, N'', CAST(0xA1380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A4010167D447 AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'087', N'Megharaj', N'Bhavani', CAST(0x68220B00 AS Date), N'', N'9686628564', N'9686628564', N'8-105/1,Kanadka House,Shakthinagar,Mangalore', N'NITTE PU College Nantoor', N'PUC', 24, N'', CAST(0xA2380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A401016D31DE AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'088', N'Rakshith.S.Salian', N'M.Sheera', CAST(0x25210B00 AS Date), N'08242400748', N'9964867889', N'9964867889', N'1-102/4(7),Suraksha,Kerekadu,Kulai Post,Hosabettu,Mangalore-575026', N'Canara PU College', N'PUC', 24, N'', CAST(0xA2380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A401016DE845 AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'089', N'Nishith.J', N'Jayakar', CAST(0x1F210B00 AS Date), N'', N'9880611504', N'9880611504', N'Sri Devi Kripa,rainbow Lane,Naguri,Mangalore-575002', N'Sharada Vidyalaya Kodialbail', N'PUC', 24, N'', CAST(0xA2380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A401016E6226 AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'090', N'Rakshitha', N'NA', CAST(0x0C380B00 AS Date), N'', N'', N'9620920923', N'Nagamma Nivas,Second cross,Anegundi,Bejai,Mangalore-575003', N'Canara PU College', N'PUC', 24, N'', CAST(0xA2380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A401016ED36E AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'090A/5202', N'Sushmitha', N'Naveen Kumar B', CAST(0xFF210B00 AS Date), N'', N'9686053508', N'9880149655', N'Sanidhya,First cross,Kodikal,Mangalore', N'Sharada Vidyalaya Kodialbail', N'PUC', 24, N'', CAST(0xA3380B00 AS Date), N'N', 24, 1, 0, 0, 0, 0, 0, N'', 0, 0, 1, CAST(0x0000A401016F77DB AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'091', N'Prathvi Mendon', N'Ramesh Mendon', CAST(0xB6210B00 AS Date), N'08242464243', N'9731614243', N'9731614243', N'Bhoomika Complex,Third Floor,University road,Thokkottu', N'St.Agnes P.U College', N'PUC', 24, N'prathvimendon@yahoo.com', CAST(0xA3380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A401017039F9 AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'092', N'Shreevathsa.T.Rao', N'Thippoji.M.Y', CAST(0x08220B00 AS Date), N'08242288179', N'9844288132', N'9164828197', N'Dasara mule,Konaje,Mangalore', N'NITTE PU College Nantoor', N'PUC', 24, N'vathsa.shree8@gmail.com', CAST(0xA3380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A4010171384F AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'093', N'Karthik.K', N'Avinash', CAST(0x78380B00 AS Date), N'', N'9164969066', N'9164969066', N'D.No 13,Veeramutthu,Labour Colony,Kuduremuka,Chikmagalur District', N'MGC PU College bondel', N'PUC', 24, N'', CAST(0xA3380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A4010172353C AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'094', N'Ayesha Afreen Sheikh', N'Nasheera S', CAST(0x8C200B00 AS Date), N'0824240601', N'9742332317', N'8971162195', N'Indus Home Apartments,Flat no.102,sulthan road,Falnir,Mangalore', N'St.Agnes P.U College', N'PUC', 24, N'', CAST(0xA4380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A4010172F3EF AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'095', N'Harshith', N'K.Vaman Gujarah', CAST(0xCC200B00 AS Date), N'', N'9945742771', N'9663657271', N'2-132/5,Baghavathi Nilaya,Acchukodi,Bondel,Mangalore', N'NITTE PU College Nantoor', N'PUC', 24, N'', CAST(0xA4380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40101737947 AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'096', N'Delman', N'NA', CAST(0x01380B00 AS Date), N'', N'', N'9902361297', N'Mangalore', N'Srinivas Institute of Technology', N'BE', 48, N'', CAST(0xA5380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40101741076 AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'097', N'Seema.C.S', N'Shivanarayana Bhat', CAST(0x5D200B00 AS Date), N'04998252202', N'', N'8547122202', N'Sri Raksha House,Miyapadav Post,via Manjeswar-671323', N'Sharada PU College', N'PUC', 24, N'', CAST(0xA5380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A4010174A214 AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'098', N'Akshay.C.Devadiga', N'Jayashri Devadiga', CAST(0x751F0B00 AS Date), N'', N'9763382459', N'8105171418', N'Sharu Mane,Landlinks,Near Ganesh hanuman Rice Mill, Konchadi', N'St.Aloysius P.U College', N'Degree', 36, N'akshaydevadiga4@gmail.com', CAST(0xA5380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A401017556DB AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'099', N'Swapna', N'Srinivas', CAST(0x97200B00 AS Date), N'08242223930', N'9483933095', N'9980932287', N'Sri Katileshwari Kripa,Behind Maha Kaali Temple,Derebail,Konchadi,Mangalore', N'Padua PU College Nantoor', N'PUC', 24, N'', CAST(0xA5380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A4010175F842 AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'100', N'Nihal.M.Naik', N'Madhusudhan Naik', CAST(0x9F210B00 AS Date), N'08242435922', N'8197972375', N'8197972375', N'Shantha Durga Nilaya,Near S.N Temple Maroli Village', N'NITTE PU College Nantoor', N'PUC', 24, N'', CAST(0xA5380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40101769A96 AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'403', N'Zaki Farhan', N'Sakeena.K.M', CAST(0x5E1D0B00 AS Date), N'', N'9036483068', N'7760921101', N'S.L Mathias Road,Falnir,Mangalore', N'Sri Devi Institute Of TechnologyKanajar', N'BE', 48, N'jeffh316@gmail.com', CAST(0xDC380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40E00C81D34 AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'404', N'Chaya', N'Sundhar .K.S', CAST(0xA11C0B00 AS Date), N'', N'9740600602', N'9611247101', N'Bavaka Compound,Near Kukkodi stores,Baikampady', N'MITE Moodabidri', N'BE', 48, N'chaya.sunder66@gmail.com', CAST(0xDC380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40E00C89F7A AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'405', N'Ashik.I.Rauther', N'Ismail.K.Rauther', CAST(0x211E0B00 AS Date), N'', N'9686960879', N'9740580786', N'shivaji Nagar,First Lane,Nippani,Belgum-591237', N'Karavali Institute of Technology', N'BE', 48, N'ashikrauther80@gmail.com', CAST(0xDC380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40E00C986CC AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'406', N'Jevita.J.Tellis', N'Joe M Tellis', CAST(0x321D0B00 AS Date), N'08242400831', N'9980037466', N'9980037466', N'Tellis,Gurunagar,Konchady Post,Mangalore-8', N'Alvas Mijar', N'BE', 48, N'joemtellis@yahoo.com', CAST(0xDC380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40E00CA5AAE AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'407', N'Manjunath.S.P', N'Padmanaba.S.C', CAST(0x3F1E0B00 AS Date), N'', N'7760008560', N'8880822223', N'Shivapura,Eppadi Post,Kunigal Taluk,Karnataka', N'Karavali Institute of Technology', N'BE', 48, N'msaaratheep@gmail.com', CAST(0xDC380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40E00CB56F5 AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'408', N'ChethanR.Kanameshwar', N'Rajendra S Kanameshwar', CAST(0x281E0B00 AS Date), N'', N'7760953506', N'7204886815', N'Lig-147,Jalangar Bijapur(Present)David Thachil House,Kalpane,Kulshekar,Mangalore', N'Karavali Institute of Technology', N'BE', 48, N'chethankanameshwar@gmail.com', CAST(0xDC380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40E00CC0916 AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'409', N'Ian Melwil dsouza', N'NA', CAST(0xEF1B0B00 AS Date), N'', N'', N'7259336856', N'C/o Anni Dsouza,Panir House,Perlahatte Post,Mangalore-574160', N'NMAMIT Nitte', N'BE', 48, N'', CAST(0xDC380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40E00CC9466 AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'410', N'Prakyath', N'Reksha', CAST(0xAF1C0B00 AS Date), N'', N'988074611', N'9880974611', N'Prakyath Nilaya,Near Guttige House,Nagakannika Temple Road,Derebail,Konchady,Mangalore-575008', N'NMAMIT Nitte', N'BE', 48, N'prakyathR@yahoo.com', CAST(0xDC380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40E00CF1C88 AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'001', N'Rosita Meena Misquith', N'Joyce Misquith', CAST(0xF4200B00 AS Date), N'08242451376', N'', N'0000000000', N'Matadakami,1st cross road,Boloor,Mangalore-6', N'St.Aloysius P.U College', N'PUC', 24, N'', CAST(0x8F380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A4000139769A AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'001A', N'Raihan', N'T.Ahmed', CAST(0xC5200B00 AS Date), N'', N'9743701336', N'9844501783', N'Site No 411,7th block,Krishnapura,Surathkal-15', N'B.G.S Composite P U College', N'PUC', 24, N'', CAST(0x8E380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40100EFCC70 AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'002', N'Aishwarya Alva K', N'Muralidhar.Alva.K', CAST(0xE01B0B00 AS Date), N'', N'9448869413', N'9480220433', N'Kukkaje House,Manchi Post,Ira Bantwal Taluk-574323', N'Sahyadri College of Engineering', N'BE', 48, N'aishwarya_alva@yahoo.com', CAST(0x8F380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A400013C7E2B AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'003', N'Delwin Winston Saldanha', N'Diana Saldanha', CAST(0x9B1F0B00 AS Date), N'08242262724', N'9945773138', N'9945773138', N'Saldanha villa,Taipakal House,Vamanjoor post,Mangalore-575028', N'St.Aloysius P.U College', N'PUC', 24, N'', CAST(0x22370B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A400013D9360 AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'004', N'Nidheesh.B.N', N'Narasimha Bhat B', CAST(0xE1200B00 AS Date), N'08251287796', N'', N'9446437796', N'Sannidhi Balemoole Post,Balemoole Kasaragod Tq,Kasargod-671552', N'Sri Sathaya Sai P U College Alike', N'PUC', 24, N'', CAST(0x8F380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A400014025D0 AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'005', N'Vandana Ananda Hegde', N'Vijayalaxmi', CAST(0xE91C0B00 AS Date), N'', N'9482965769', N'9945964093', N'Kerehadi House,Bairampalli Village,Harikandige Post,Udupi', N'MITE', N'BE', 48, N'', CAST(0x8F380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40001412D3A AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'006', N'Sanketh', N'Krishnappa Bangera', CAST(0x3C1D0B00 AS Date), N'', N'9945288764', N'9900926647', N'Banglegudde,Panemanglur,Bantwal Taluk-574231', N'Sahyadri College of Engineering', N'BE', 48, N'sankethbangera2014@gmail.com', CAST(0x8F380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40001421943 AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'007', N'Vikas.B', N'Suresh.B', CAST(0x0D1D0B00 AS Date), N'', N'9946757292', N'9740866235', N'S/o Suresh B,kurtargaradka,kumpta,671321,Kasargod', N'Sahyadri College of Engineering', N'BE', 48, N'vikasb113@gmail.com', CAST(0x8F380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A400014306A9 AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'008', N'Abhishek k', N'P.M.Krishnananda', CAST(0xA41D0B00 AS Date), N'08255280687', N'9448121687', N'7411082809', N'P.M.Krishnanda,Narikombu post,Manimajul House,Bantwal Taluk-874231', N'Sahyadri College of Engineering', N'BE', 48, N'abhishekabhi.11071999@gmail.com', CAST(0x8F380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A4000144505F AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'009', N'Abdul Atish Mohammed', N'Rahmatul Sameena', CAST(0x8F200B00 AS Date), N'', N'', N'8943365774', N'Thoufeeq mahaal Kudukoli Post,Perla,Kasargod dist,Kerala', N'Sri Sathaya Sai P U College Alike', N'PUC', 24, N'', CAST(0x90380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40001464B1D AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'010', N'Aadesh D.Shetty', N'Deepak.N.Shetty', CAST(0xD2210B00 AS Date), N'', N'9980310943', N'8197005121', N'Behind old municipal office,Goodshed road,Bunder,Mangalore-01', N'St.Aloysius P.U College', N'PUC', 24, N'', CAST(0x94380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A400016DA72B AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'011', N'Melissa Benadicta Saldanha', N'Melroy Saldanha', CAST(0x42220B00 AS Date), N'08242211017', N'9880379752', N'9036692704', N'Manu nivas,Maryhill,Mangalore-575008', N'St.Agnes P.U College', N'PUC', 24, N'saldanhamalissa1998@gmail.com', CAST(0x94380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A400016EA9D7 AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'012', N'Swathi.K', N'L.D.Krishnamurthy', CAST(0xFB1D0B00 AS Date), N'08242464962', N'9481760200', N'8105894775', N'L.D.Krishnamurthy,Near CRS,First cross,Kodialbail Mangalore', N'Sahyadri College of Engineering', N'BE', 48, N'swathi0695@gmail.com', CAST(0x94380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A400017015DF AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'013', N'Rakshith', N'Shashikala', CAST(0x2B200B00 AS Date), N'', N'', N'9741000267', N'Kotekar Post,Near travels Banglow,Mangalore-575021', N'St.Aloysius P.U College', N'PUC', 24, N'', CAST(0x94380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A4000170E219 AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'014', N'Akshatha.K', N'Kamalaksha', CAST(0x08220B00 AS Date), N'', N'9900458829', N'9611415591', N'Suvarna Compound,Near Vishranthi church,Bockapatna Mangalore-575003', N'Canara PU College', N'PUC', 24, N'akshatha8898@gmail.com', CAST(0x95380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A4000171F912 AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'015', N'Shefali.B.S', N'B.Sheena', CAST(0xD9200B00 AS Date), N'', N'9448503040', N'9480487282', N'sRI dEVI kRIPA,2-66/3,J.M.Road,Alape,Bajal,Mangalore,575007', N'St.Agnes P.U College', N'PUC', 24, N'shefali.sharel@gmail.com', CAST(0x95380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A4000172D0C2 AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'016', N'Mark Gonsalves', N'Sujith.K.Gonsalves', CAST(0x400F0B00 AS Date), N'', N'9611773319', N'9611773319', N'Leon Villa,Althotte road,Bondel Post,Mangalore-575008', N'St.Aloysius P.U College', N'PUC', 24, N'', CAST(0x94380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40001737F71 AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'017', N'Avinash.C.Karkera', N'Raghav', CAST(0x0E220B00 AS Date), N'', N'9964277034', N'8105093850', N'Ananda Nagar Complex,Santhekatte Post,Udupi', N'Canara Engineering College Benjanapadav', N'BE', 48, N'avinashkarkera859@gmail.com', CAST(0x94380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A400017480D0 AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'018', N'Lawrence Fernandes', N'B.D.Fernandes', CAST(0xDD1A0B00 AS Date), N'', N'9448729288', N'9483668958', N'St.Sabestian Villa,Palya Road,Honnawar', N'St.Joseph Engineering College Vamanjoor', N'BE', 48, N'fernandeslawrenceb@gmail.com', CAST(0x96380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40001756EE8 AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'019', N'Roshan Shetty.N.H', N'Harish Shetty', CAST(0x0B1C0B00 AS Date), N'', N'9845580298', N'8147657060', N'Jeswin Apartment,Flat No.402,Bejai new road,Mangalore', N'Vivekananda College of Engineering', N'BE', 48, N'', CAST(0x96380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40001761BEE AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'020', N'Krithika.S.Upadyaya', N'S.M.Udupa', CAST(0xFB1F0B00 AS Date), N'08242495599', N'9480532999', N'9480532999', N'Sri Raksha,301,Advaith Apartments,Kodialguthu(W) ,Mangalore-575003', N'Canara PU College', N'PUC', 24, N'', CAST(0x96380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A4000176E2E2 AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'021', N'Amina Rukhiya', N'Umar Farooq', CAST(0x6C210B00 AS Date), N'08244268383', N'9845118383', N'7847818383', N'Flat No.501,Vishwas Kalandan Court,Rosario Church road,Mangalore-575001', N'St.Agnes P.U College', N'PUC', 24, N'gsaamira@gmail.com', CAST(0x97380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40100AFEF0B AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'022', N'Chaithra.M.Shetty', N'Monappa Shetty', CAST(0x5B390B00 AS Date), N'08242200507', N'9448445461', N'9448445461', N'Sindura Badagaekkaru,Ekkaru Post,574509,Mangalore,D.K', N'Sri Devi Technology Kenjaaru', N'BE', 48, N'', CAST(0x97380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40100B1C5CD AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'023', N'Nishal', N'Naveen', CAST(0x311C0B00 AS Date), N'', N'8123720281', N'9036403503', N'Laxmi Narasimha,Kanakanady,Shenoy Complex,Kankanady Post,Mangalore', N'St.Joseph Engineering College Vamanjoor', N'BE', 48, N'', CAST(0x97380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40100B28014 AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'024', N'Bibin.S.Vayhev', N'Scaria Vayhev', CAST(0x1F1A0B00 AS Date), N'', N'', N'8141190471', N'', N'Sri Devi Technology Kenjaaru', N'BE', 48, N'', CAST(0x97380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40100B40EC1 AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'024/5201', N'Abhijeeth.V.Kumar', N'B.Vasanth Kumar', CAST(0x85210B00 AS Date), N'', N'9449081660', N'9480761032', N'S/o B.Vasanth Kumar,D.No 23-11-972/4,Abhi Harsh', N'Sharada PU College', N'PUC', 24, N'', CAST(0x97380B00 AS Date), N'N', 24, 1, 0, 0, 0, 0, 0, N'', 0, 0, 1, CAST(0x0000A40100B4FFCB AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'025', N'Vindhya Shetty', N'Yashawantha.G.Shetty', CAST(0x70210B00 AS Date), N'', N'9739251454', N'8792279959', N'Yashasvi,Palimar House,Church road,Bejai,Mangalore', N'Canara PU College', N'PG', 24, N'vindhmount@yahoo.co.in', CAST(0x97380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40100B5B4C7 AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'026', N'Sinan Muhiuddeen', N'Usman', CAST(0x931A0B00 AS Date), N'', N'', N'8147637019', N'301,Casa lavina,Vacalane,575002', N'St.Joseph Engineering College Vamanjoor', N'BE', 48, N'funkybay267@gmail.com', CAST(0x99380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40100BA73AA AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'027', N'Sonali.P.Rao', N'Anupama Rao', CAST(0x771B0B00 AS Date), N'', N'9341797888', N'7760611201', N'Nithya Kutira,Narayana Karkera Complex,Bolar,Mulihithlu,Mangalore', N'Sahyadri College of Engineering', N'BE', 48, N'sonalirao31@yahoo.com', CAST(0x99380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40100BBA4CE AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'028', N'Deekshith.B.Shetty', N'Shakila.B.Shetty', CAST(0x491D0B00 AS Date), N'08242414339', N'9663837490', N'8971923670', N'Saraswathi Nilaya,Hanikere Tailory Road,Mulihithlu,Mangalore-575001', N'MITE', N'BE', 48, N'shetty_deekshiv11@yahoo.co.in', CAST(0x99380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40100BDB2DB AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'029', N'Mohamad Faizan', N'Farida Parvin', CAST(0xA91B0B00 AS Date), N'08242252165', N'9945311384', N'9902660682', N'Faizan Manzeel,Kattalsar Road,Permude Post,574509', N'Sri Devi Technology Kenjaaru', N'BE', 48, N'faizanmohammed70@yahoo.com', CAST(0x99380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40100BE9173 AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'030', N'Parvathi.K', N'Kadresha', CAST(0x1E1D0B00 AS Date), N'', N'9482618634', N'8762057450', N'Parvathi.K,Kudmul Rangarav Hostel,Kodialbail,PVS,Mangalore', N'Sahyadri College of Engineering', N'BE', 48, N'', CAST(0x99380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40100BF2C02 AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'031', N'Suraj Suresh Shetty', N'Divya Shetty', CAST(0xFA200B00 AS Date), N'', N'9008915326', N'9008939869', N'Flat No.601,6th Floor,Venkataramana Towers,Car Street,Mangalore', N'St.Aloysius P.U College', N'PUC', 24, N'Suraj1197@yahoo.com', CAST(0x98380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40100BFCD13 AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'032', N'Prakrithi.Rao.T', N'Nagaraj Rao', CAST(0xF11F0B00 AS Date), N'', N'', N'9448992165', N'Sri Sharada Nivas,Planters Home,Bunts Hostel,Mangalore-575003', N'Sharada PU College', N'PUC', 24, N'', CAST(0x99380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40100C0755C AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'033', N'Roshin Baby Varghese', N'Baby Verghese', CAST(0xF31B0B00 AS Date), N'', N'9796375764', N'9591667875', N'D.No 6-112/27(1),Nethravathi Layout,Capithanio,Mangalore-575002', N'Sahyadri College of Engineering', N'BE', 48, N'theroshin@gmail.com', CAST(0x99380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40100C10F8B AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'034', N'Divya Madonna Dsouza', N'Mark Dsouza', CAST(0xB8210B00 AS Date), N'08242222233', N'9964280840', N'9480156647', N'Divya Sadhan,Behind Nantoor Cross,Karavali Lane,Mangalore-575002', N'St.Agnes P.U College', N'PUC', 24, N'', CAST(0x99380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40100C1A2A5 AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'035', N'Meghashree', N'T.Balakrishna', CAST(0x6B200B00 AS Date), N'', N'9945897720', N'9945897720', N'Krithika house,Near Ladies Hostel,Mahakaali Temple Road,Derebail,Kankanady,Mangalore-575008', N'NA', N'PUC', 24, N'', CAST(0x99380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40100C22C87 AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'036', N'Ahmad Shakeel', N'Mohamad.P', CAST(0xF91F0B00 AS Date), N'08255281075', N'9480862425', N'9742452575', N'opp BJM Aladka,Panemangalore-574231', N'B.A PU College', N'PUC', 24, N'', CAST(0x99380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40100C2BE81 AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'037', N'Wasiq', N'Mohamad.P.A', CAST(0xFF1E0B00 AS Date), N'', N'9620773755', N'9986322800', N'B-104,Casa Grande Apartments,starrock Road,Attavar,Mangalore', N'Mahesh PU College', N'PUC', 24, N'wasiq.ibrahim@yahoo.com', CAST(0x9A380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40100C382F4 AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'038', N'Sidharth.P.N', N'P.Narayanan', CAST(0x981B0B00 AS Date), N'04994223303', N'9446044203', N'8089375016', N'Nellikannu,Ambedkar road,Kasaragod-671121,Kerala', N'Karavali College Mangalore', N'BE', 48, N'sidhuksdqe@gmail.com', CAST(0x9A380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40100C43834 AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'040', N'Aishwari Deona Rebello', N'Deena Rebello', CAST(0x90220B00 AS Date), N'08242443383', N'9880802383', N'9880802383', N'201 Padma Emclave,Coelho Lane,Falneer,Mangalore', N'St.Agnes P.U College', N'PUC', 24, N'deevee04@hotmail.com', CAST(0x9A380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40100C5E0B9 AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'041', N'Nitish Kumar baliga', N'Namratha Baliga', CAST(0x95210B00 AS Date), N'', N'9741393777', N'9741393777', N'Flat No.102,PVS Kalakunja Road,Mangalore-575003', N'S.A.C', N'PUC', 24, N'baliga100@gmail.com', CAST(0x9A380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40100F07E09 AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'042', N'Vishal.K.S', N'K.V.Shridhar', CAST(0x36210B00 AS Date), N'', N'', N'9449589026', N'3-129/1(4),Thodlagudda Road,Kunjathabail Post,Kavoor,Mangalore', N'Canara PU College', N'PUC', 24, N'vishalks.jan10@gmail.com', CAST(0x9A380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40100F13D71 AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'043', N'Dhanush', N'L.Yashwanth Kumar', CAST(0x87200B00 AS Date), N'', N'9448104467', N'9448104467', N'Bhavani Ganesh Complex,Bejai,Mangalore', N'Sharada PU College', N'PUC', 24, N'dhanushyash@yahoo.com', CAST(0x9A380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40100F1CF06 AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'044', N'Sheetal', N'Chandrashekar', CAST(0x23230B00 AS Date), N'', N'', N'9900829956', N'Sheethal Nivas,Shivajinagar Post,Bondel,Pachanady Mangalore-575008', N'St.Agnes P.U College', N'PUC', 24, N'', CAST(0x9A380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40100F24FFD AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'045', N'Ashmitha', N'Chandrakala.D', CAST(0xD81F0B00 AS Date), N'', N'8792393567', N'8050222763', N'Divyashree,Near Baliga Stores.', N'Canara PU College', N'PUC', 24, N'', CAST(0x9A380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40100F3817F AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'046', N'Seema Melody', N'Gregory Noronha', CAST(0x99380B00 AS Date), N'', N'9480035043', N'8496013257', N'Ajekala House,Amtady Post,Bantwal', N'S.V.S College Bantwal', N'Degree', 36, N'', CAST(0x9B380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40100F304D7 AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'047', N'Ajay Kumar.K.V', N'Vishwanath Jogi', CAST(0x99380B00 AS Date), N'', N'9972043847', N'8722821977', N'Ashritha,Near Kordabbu Temple,Kajila,Thenkulipady Village,Malali Post Mangalore', N'S.Joseph P.U.College Bajpe', N'PUC', 24, N'', CAST(0x9A380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40100F46975 AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'048', N'Ustav', N'Umesh', CAST(0x4A210B00 AS Date), N'', N'9880988148', N'9880988148', N'Doomapaas House,Old Kent Road,Pandeshwar,Mangalore-575001', N'St.Aloysius P.U College', N'PUC', 24, N'ustavkarkera@gmail.com', CAST(0x9B380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40100F50712 AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'049', N'Rajath', N'Jagdish', CAST(0x26210B00 AS Date), N'', N'9611005769', N'9611065769', N'S.r.Nilaya,Adimar Gorigudda,Kankanady,Mangalore', N'NITTE PU CollegeNantoor', N'PUC', 24, N'', CAST(0x9B380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40100F58CCC AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'050', N'Alison Lobo', N'Wilma Lobo', CAST(0xED210B00 AS Date), N'', N'9739354557', N'9739354557', N'Near Maryhill Convent,Konchady Post,Mangalore-575008', N'St.Agnes P.U College', N'PUC', 24, N'', CAST(0x9C380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40100F61088 AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'051', N'Deeksha Prabhu', N'NA', CAST(0x35230B00 AS Date), N'', N'9448108217', N'9448108217', N'Haribettu House,Veerakamba Village,Bantwal Taluk-574222', N'Sri Rama PU College Kalladka', N'PUC', 24, N'', CAST(0x9C380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40100F9B6EA AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'052', N'Sahil.N.Raj', N'B.V.Nagaraj', CAST(0x42210B00 AS Date), N'08242244751', N'9343567728', N'9343567728', N'B.V.Nagaraj,D.No 130/70,Bollagudda,Kuthadka,Bajal,Mangalore-575007', N'Sharada PU College', N'PUC', 24, N'', CAST(0x9B380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40100F6D4E9 AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'053', N'Ritwic', N'Geetha.r.Salian', CAST(0x71200B00 AS Date), N'08242212363', N'9986567763', N'7353830398', N'Suvarna Nilaya,Bharathi Nagar,Bejai,Mangalore', N'Sharada PU College', N'PUC', 24, N'rit356@gmail.com', CAST(0x9B380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40100F76343 AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'054', N'Yamen Akthar Mohammed', N'Asiya Akthar', CAST(0x56200B00 AS Date), N'08242424954', N'966191000', N'9844569231', N'Ali Bagh Mansion,Britto Lane,Falnir,Mangalore-575002', N'St.Aloysius P.U College', N'PUC', 24, N'yamenns@gmail.com', CAST(0x9B380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40100F8238F AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'055', N'Kalpana.K', N'Shambayya', CAST(0x39220B00 AS Date), N'08256264022', N'8494850436', N'8494850436', N'Sri Durga Kripa,Ballamanja post,Mattina,Belthangady-574224', N'Sacred Heart PU College Madanthyar', N'PUC', 24, N'', CAST(0x9C380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40100FA8CAE AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'056', N'Suma', N'Hanumantha', CAST(0xD0200B00 AS Date), N'08242221301', N'9591715125', N'8151824318', N'Ujwala Apartment,Opp Syndicate Bank,Kadri road,Mangalore', N'Govt.PU College for womensBalmatta', N'PUC', 24, N'', CAST(0x9C380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40100FB5769 AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'057', N'Shravan.K.Das', N'Shanmuga Das', CAST(0xC91C0B00 AS Date), N'', N'9744508060', N'8951471721', N'Room No-003,Saalwyyn,Near bharath Mall,Kapikad ', N'Sri Devi Technology Kenjaaru', N'BE', 48, N'shravankdas007@gmail.com', CAST(0x9C380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40100FC1F4C AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'058', N'Ganapathi Ragoba Tamse', N'Raghoba Tamse', CAST(0xE71A0B00 AS Date), N'', N'', N'7259340486', N'At Post,Hankon,Hotegali,Karrnar', N'Canara Engineering College Benjanapadav', N'BE', 48, N'ganapatitamse@gmail.com', CAST(0x9D380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40100FCD15F AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'059', N'Praful Kumar.A', N'Prakash', CAST(0xB81D0B00 AS Date), N'', N'9480206066', N'8970877410', N'Bhramari House,Subramanya Nagara,Neermarga,Mangalore-575024', N'Sri Devi Technology Kenjaaru', N'BE', 48, N'', CAST(0x9D380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40100FD4A3F AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'060', N'Smitha Rebello', N'Joyce Rebello', CAST(0x5B210B00 AS Date), N'', N'9483202041', N'9481848703', N'Flat no.103,Ford Mansion,New Balmatta road,Mangalore-575001', N'St.Agnes P.U College', N'PUC', 24, N'smireb123@gmail.com', CAST(0x9D380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40100FDE55C AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'061', N'Kishan.C.D', N'Divijaksha.C.D', CAST(0x76040B00 AS Date), N'', N'9945371127', N'9741630911', N'S.K.Chambers,Jyothinagar,Marakada Village,Kunjathabail post,Mangalore', N'NITTE PU College Nantoor', N'PUC', 24, N'', CAST(0x9D380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A401013CFC4D AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'062', N'Supritha', N'Ramesh shetty', CAST(0x08210B00 AS Date), N'', N'9945856772', N'9743114975', N'Kattinja house,Kodman Village,Bantwal Taluk,Farangipet', N'Govt.PU College for womensBalmatta', N'PUC', 24, N'', CAST(0x9E380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A401013D87FF AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'063', N'Ayisha', N'Abdul Basheer', CAST(0xAF200B00 AS Date), N'', N'9663334523', N'9972119529', N'Baliyur residency,Kalladka House,Golthamajal Village,Bantwal', N'Govt.PU College for womensBalmatta', N'PUC', 24, N'', CAST(0x9E380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A401013E0AFD AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'064', N'Gayathri', N'Monappa Shettigar', CAST(0x40210B00 AS Date), N'', N'9964604454', N'9964604454', N'Ashirvadha House,Mariyamma Croli,Konaje post,Mangalore', N'Govt.PU College for womens Balmatta', N'PUC', 24, N'', CAST(0x9E380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40101429A76 AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'066', N'Karthik Bhat Adyathimar', N'Gopalkrishna Bhat', CAST(0xD6200B00 AS Date), N'', N'9980546290', N'9591892816', N'Adhyathimar House,Bettenapady,Puttur-574259', N'Vivekananda PU College Puttur', N'PUC', 24, N'karthik.bhata7@gmail.com', CAST(0x9E380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40101456107 AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'067', N'Jewer Mercy Fernandes', N'NA', CAST(0x701C0B00 AS Date), N'08242221856', N'', N'8197806127', N'Bikarnakatte,Bajjodi,Mangalore', N'St.Joseph Engineering College Vamanjoor', N'BE', 48, N'', CAST(0x9E380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A4010145F58E AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'067A', N'Rachna Shetty', N'Rekha Shetty', CAST(0x411D0B00 AS Date), N'', N'9663087184', N'7795956275', N'Ashraya,Near Jarandaya temple,Barebail,Yeyyadi,Mangalore', N'St.Joseph Engineering College Vamanjoor', N'BE', 48, N'rachushetty18@gmail.com', CAST(0xCE380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A4010146D841 AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'068', N'Swathi.K', N'Radhakrishna Shetty', CAST(0x66220B00 AS Date), N'', N'', N'8495855208', N'Kuriya House,Kurudapadavu Post,Uppala via Kasargod', N'Vivekananda PU College Puttur', N'PUC', 24, N'swathishetty75@gmail.com', CAST(0xA0380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40101478F67 AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'069', N'Sachin Mallya K', N'Suresh mallya', CAST(0xEE1B0B00 AS Date), N'08251234767', N'9483292277', N'8749007414', N'Dsouza compound,Pallaki House,L.P layout,Puttur-574202', N'Vivekananda College of Engineering', N'BE', 48, N'sachinmal09@gmail.com', CAST(0xA0380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40101488FEA AS DateTime), N'N/A')
GO
print 'Processed 100 total records'
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'070', N'Rithik rai', N'Jaikishan Rai', CAST(0x6C1C0B00 AS Date), N'', N'8971153472', N'8971153472', N'Flat No-G4 ,Sharada Residency,Matadakani,3rd cross,Ashoknagar,Mangalore-575006', N'Sahyadri College of Engineering', N'BE', 48, N'rithikrai.rai@gmail.com', CAST(0xA0380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A401014C187D AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'071', N'Ajay.B', N'Govinda Nayak', CAST(0x921A0B00 AS Date), N'', N'9480240635', N'9663999343', N'Baleguli House,Irde Post,Puttur taluk', N'St.Joseph Engineering College Vamanjoor', N'BE', 48, N'ajaybo793@gmail.com', CAST(0xA0380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A401014DDAB5 AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'072', N'Akash', N'Harishchandra Shettigar', CAST(0xC3210B00 AS Date), N'', N'8747857103', N'8722618169', N'Near Marlyne Apartments,Bejai,Battagudda', N'NITTE PU College Nantoor', N'PUC', 24, N'', CAST(0xA0380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A401014E76AF AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'073', N'Rakshith S Hegde', N'Lalitha', CAST(0x88220B00 AS Date), N'08242281501', N'', N'9741074772', N'Santyaguthu,Kinya Post,Talapaddy Mangalore', N'NITTE PU College Nantoor', N'PUC', 24, N'rakshithhegde1998@gmail.com', CAST(0xA0380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A401014F20D3 AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'074', N'Smitha.S.M', N'Leelavathi', CAST(0x8D220B00 AS Date), N'', N'9980951659', N'9980951659', N'D.No 1/4,Kuntikan,Mangalore', N'Canara PU College', N'PUC', 24, N'', CAST(0xA0380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A401014FAE58 AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'075', N'Fathima Nihala Sulthana', N'Mohammas Abbas Koppala', CAST(0xA61F0B00 AS Date), N'', N'', N'8277427295', N'C.P.C Compound,Kudroli Mangalore', N'Canara PU College', N'PUC', 24, N'', CAST(0xA0380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A4010161048C AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'076', N'Prathiksha', N'Keshava.b.Shettigar', CAST(0x59210B00 AS Date), N'', N'9481607992', N'9972163115', N'Ganesh Kripa,Mogrody,Padavinangady,Mangalore', N'NITTE PU College Nantoor', N'PUC', 24, N'', CAST(0xA0380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40101617BD8 AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'077', N'Sharadda Shetty', N'Vijaya Shetty', CAST(0x67210B00 AS Date), N'', N'7204062943', N'9901741274', N'Canara Building,Room No.405,Near Sharavu Temple,Mangalore-575001', N'St.Agnes P.U College', N'PUC', 24, N'', CAST(0xA0380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40101620CF0 AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'078', N'Ankitha Dewasi', N'Mrs.Usha Hegde', CAST(0x21200B00 AS Date), N'', N'9449101870', N'9449101870', N'No.407,4th Floor,Shankambari Apartments,Near KSRTC Bustand,Bejai,Mangalore', N'Mahesh PU College', N'PUC', 24, N'ankitadewasi@yahoo.in', CAST(0xA0380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40101631A34 AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'079', N'Roshni.P.S', N'Sunil.P.A', CAST(0xA2210B00 AS Date), N'', N'9845269402', N'9845269402', N'Jeeth Nilaya,Thilak Nagar,Boloor,Mangalore', N'Canara PU College', N'PUC', 24, N'', CAST(0xA0380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40101638C30 AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer_bckp] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'080', N'Afia Fathima', N'Abdul Hameed', CAST(0x3D210B00 AS Date), N'', N'9686926138', N'9686926138', N'#34,Happy Home Apartments,Arya Samaja Road,Balmata,Mangalore', N'St.Aloysius P.U College', N'PUC', 24, N'afia_nabeel@yahoo.com', CAST(0xA1380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40101642B65 AS DateTime), N'N/A')
/****** Object:  Table [dbo].[TblCustomer]    Script Date: 01/18/2015 19:32:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TblCustomer](
	[CustomerID] [varchar](20) NOT NULL,
	[Name] [varchar](150) NOT NULL,
	[Father Name] [varchar](100) NOT NULL,
	[DOB] [date] NOT NULL,
	[Parent Phone] [varchar](20) NOT NULL,
	[Parent Mobile] [varchar](20) NOT NULL,
	[Student Mobile] [varchar](20) NOT NULL,
	[Address] [varchar](500) NOT NULL,
	[CollegeName] [varchar](300) NOT NULL,
	[Course] [varchar](200) NOT NULL,
	[CourseDuration] [int] NOT NULL,
	[EmailID] [varchar](150) NOT NULL,
	[MembershipDate] [date] NOT NULL,
	[MembershipType] [varchar](50) NOT NULL,
	[MembershipPeriod] [int] NOT NULL,
	[Activation] [bit] NULL,
	[BookCount] [int] NOT NULL,
	[DepositAmount] [float] NOT NULL,
	[AdvanceAmount] [float] NULL,
	[BalanceAmount] [float] NULL,
	[RefundAmount] [float] NULL,
	[RecieptNumber] [varchar](20) NULL,
	[MaxLimit] [float] NOT NULL,
	[UsedLimit] [float] NOT NULL,
	[EarlyActivation] [bit] NULL,
	[CreatedDatetime] [datetime] NULL,
	[ImagePath] [varchar](400) NULL,
 CONSTRAINT [PK_TblCustomer] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[TblCustomer] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'401', N'Abhishek.M.Patil', N'Maheshbhai Patel', CAST(0x4A1A0B00 AS Date), N'', N'8469697433', N'7795972013', N'405,Mayur Park,Kadri Road,Mangalore,Karnataka', N'Srinivas School Of Engineering Mukka', N'BE', 48, N'', CAST(0xDC380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40E00C686FD AS DateTime), N'D:\BLSProject\BLSImages\401.jpg')
INSERT [dbo].[TblCustomer] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'402', N'K.V.Sudheshna Rao', N'.Vadhiraja Rao', CAST(0x601E0B00 AS Date), N'08242483600', N'9449208135', N'9880785414', N'Hayavadana,Maladi Courts,Ambika Nagar,Kavoor,Mangalore-15', N'NMAMIT Nitte', N'BE', 48, N'kvsudeshnarao@gmail.com', CAST(0xDC380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40E00C75A49 AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'403', N'Zaki Farhan', N'Sakeena.K.M', CAST(0x5E1D0B00 AS Date), N'', N'9036483068', N'7760921101', N'S.L Mathias Road,Falnir,Mangalore', N'Sri Devi Institute Of TechnologyKanajar', N'BE', 48, N'jeffh316@gmail.com', CAST(0xDC380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40E00C81D34 AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'404', N'Chaya', N'Sundhar .K.S', CAST(0xA11C0B00 AS Date), N'', N'9740600602', N'9611247101', N'Bavaka Compound,Near Kukkodi stores,Baikampady', N'MITE Moodabidri', N'BE', 48, N'chaya.sunder66@gmail.com', CAST(0xDC380B00 AS Date), N'R', -1, 1, 8, 0, 300, 0, 0, N'', 0, -1, 1, CAST(0x0000A40E00C89F7A AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'405', N'Ashik.I.Rauther', N'Ismail.K.Rauther', CAST(0x211E0B00 AS Date), N'', N'9686960879', N'9740580786', N'shivaji Nagar,First Lane,Nippani,Belgum-591237', N'Karavali Institute of Technology', N'BE', 48, N'ashikrauther80@gmail.com', CAST(0xDC380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40E00C986CC AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'406', N'Jevita.J.Tellis', N'Joe M Tellis', CAST(0x321D0B00 AS Date), N'08242400831', N'9980037466', N'9980037466', N'Tellis,Gurunagar,Konchady Post,Mangalore-8', N'Alvas Mijar', N'BE', 48, N'joemtellis@yahoo.com', CAST(0xDC380B00 AS Date), N'R', -1, 1, 2, 0, 0, 300, 0, N'', 0, -1, 1, CAST(0x0000A40E00CA5AAE AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'407', N'Manjunath.S.P', N'Padmanaba.S.C', CAST(0x3F1E0B00 AS Date), N'', N'7760008560', N'8880822223', N'Shivapura,Eppadi Post,Kunigal Taluk,Karnataka', N'Karavali Institute of Technology', N'BE', 48, N'msaaratheep@gmail.com', CAST(0xDC380B00 AS Date), N'R', -1, 1, 12, 0, 0, 2960, 0, N'', 0, -1, 1, CAST(0x0000A40E00CB56F5 AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'408', N'ChethanR.Kanameshwar', N'Rajendra S Kanameshwar', CAST(0x281E0B00 AS Date), N'', N'7760953506', N'7204886815', N'Lig-147,Jalangar Bijapur(Present)David Thachil House,Kalpane,Kulshekar,Mangalore', N'Karavali Institute of Technology', N'BE', 48, N'chethankanameshwar@gmail.com', CAST(0xDC380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40E00CC0916 AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'409', N'Ian Melwil dsouza', N'NA', CAST(0xEF1B0B00 AS Date), N'', N'', N'7259336856', N'C/o Anni Dsouza,Panir House,Perlahatte Post,Mangalore-574160', N'NMAMIT Nitte', N'BE', 48, N'', CAST(0xDC380B00 AS Date), N'R', -1, 1, 0, 0, 0, 0, 0, N'', 0, -1, 1, CAST(0x0000A40E00CC9466 AS DateTime), N'N/A')
INSERT [dbo].[TblCustomer] ([CustomerID], [Name], [Father Name], [DOB], [Parent Phone], [Parent Mobile], [Student Mobile], [Address], [CollegeName], [Course], [CourseDuration], [EmailID], [MembershipDate], [MembershipType], [MembershipPeriod], [Activation], [BookCount], [DepositAmount], [AdvanceAmount], [BalanceAmount], [RefundAmount], [RecieptNumber], [MaxLimit], [UsedLimit], [EarlyActivation], [CreatedDatetime], [ImagePath]) VALUES (N'410', N'Prakyath', N'Reksha', CAST(0xAF1C0B00 AS Date), N'', N'988074611', N'9880974611', N'Prakyath Nilaya,Near Guttige House,Nagakannika Temple Road,Derebail,Konchady,Mangalore-575008', N'NMAMIT Nitte', N'BE', 48, N'prakyathR@yahoo.com', CAST(0xDC380B00 AS Date), N'N', -1, 1, 6, 0, 0, 0, 0, N'', 10000, 8560, 1, CAST(0x0000A40E00CF1C88 AS DateTime), N'N/A')
/****** Object:  Table [dbo].[TblCheckDetails]    Script Date: 01/18/2015 19:32:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TblCheckDetails](
	[CustomerID] [varchar](20) NOT NULL,
	[CheckNumber] [varchar](20) NOT NULL,
	[CheckAmount] [float] NOT NULL,
	[CheckIssueDate] [date] NOT NULL,
	[CheckClearanceDate] [date] NOT NULL,
	[CheckStatus] [varchar](5) NOT NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[TblCheckDetails] ([CustomerID], [CheckNumber], [CheckAmount], [CheckIssueDate], [CheckClearanceDate], [CheckStatus]) VALUES (N'401', N'11896', 375, CAST(0x74390B00 AS Date), CAST(0x83390B00 AS Date), N'PND')
INSERT [dbo].[TblCheckDetails] ([CustomerID], [CheckNumber], [CheckAmount], [CheckIssueDate], [CheckClearanceDate], [CheckStatus]) VALUES (N'401', N'13535', 750, CAST(0x75390B00 AS Date), CAST(0x89390B00 AS Date), N'PNDNG')
INSERT [dbo].[TblCheckDetails] ([CustomerID], [CheckNumber], [CheckAmount], [CheckIssueDate], [CheckClearanceDate], [CheckStatus]) VALUES (N'401', N'25768', 750, CAST(0x76390B00 AS Date), CAST(0x83390B00 AS Date), N'PNDNG')
INSERT [dbo].[TblCheckDetails] ([CustomerID], [CheckNumber], [CheckAmount], [CheckIssueDate], [CheckClearanceDate], [CheckStatus]) VALUES (N'401', N'78659', 750, CAST(0x78390B00 AS Date), CAST(0x7B390B00 AS Date), N'PNDNG')
/****** Object:  StoredProcedure [dbo].[up_usr_select_customerDetailsForAutoComplete]    Script Date: 01/18/2015 19:32:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-------------------------------------------------
-- Author       : Shankar
-- Created Date : 10th Dec 2014
-- Description  : Selects Customer table details for Autocomplete
-------------------------------------------------

CREATE PROCEDURE [dbo].[up_usr_select_customerDetailsForAutoComplete]
(
	@FilterName VARCHAR(50),
	@FilterValue VARCHAR(500)
)
AS
BEGIN
    
    DECLARE @sqlstmt VARCHAR(1000) 
    
    SET @sqlstmt = '';   
       
    SET @sqlstmt = 'SELECT TOP 5 (' + @FilterName + ') FROM
					  (SELECT DISTINCT(' + @FilterName + ') 
					  FROM TblCustomer WITH(NOLOCK)
					  WHERE ' + @FilterName + ' LIKE ''' + @FilterValue +'%'') AS temp'		
				  
	EXEC(@sqlstmt)
	
END
GO
/****** Object:  StoredProcedure [dbo].[up_usr_Select_CustomerCount]    Script Date: 01/18/2015 19:32:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-------------------------------------------------
-- Author       : Gratian Ruzario
-- Created Date : 13 July 2013
-- Description  : Selects Customer based on FirstName and Mobile Number
-------------------------------------------------

CREATE PROCEDURE [dbo].[up_usr_Select_CustomerCount]
    @Name VARCHAR(100) ,
	@Mobile VARCHAR(10),
	@Count int OUT
	

AS
BEGIN
    
    SET @Count = 0
    SELECT @Count = COUNT(CustomerID)	
	FROM TblCustomer WITH(NOLOCK)
	WHERE Name = @Name and [Student Mobile] = @Mobile		
	
END
GO
/****** Object:  StoredProcedure [dbo].[up_usr_select_CustomerBookID]    Script Date: 01/18/2015 19:32:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-------------------------------------------------
-- Author       : Gratian Ruzario
-- Created Date : 13 July 2013
-- Description  : Selects Customer based on FirstName and Mobile Number
-------------------------------------------------

CREATE PROCEDURE [dbo].[up_usr_select_CustomerBookID]
    @ID int OUT
	

AS
BEGIN
    
    SELECT @ID = MAX(CustBookID)	
	FROM TblCustomerBooks WITH(NOLOCK)	
	
END
GO
/****** Object:  StoredProcedure [dbo].[up_usr_insert_StockOnEarlyIssue]    Script Date: 01/18/2015 19:32:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[up_usr_insert_StockOnEarlyIssue]
(
	@Title Varchar(100),
	@Author Varchar(100),
	@Edition Varchar(100),
	@Price float,
	@BookCount int,
	@StockTable AS UDTStock READONLY
          
)
AS
BEGIN
	SET NOCOUNT ON
	
	DECLARE @RowCount INT
	
	SELECT @RowCount=COUNT(*) FROM TblStock WHERE [Title] = @Title AND [Author] = @Author AND [Edition] = @Edition And [PurchasePrice] = @Price
	
IF(@RowCount = 0)
BEGIN
	
INSERT INTO [BLS].[dbo].[TblStock]
           ([ISBN]
           ,[Title]
           ,[Author]
           ,[Year]
           ,[Edition]
           ,[Publisher]
           ,[Count]
           ,[PriceChangable]
           ,[OriginalPrice]
           ,[Discount]
           ,[PurchasePrice]
           ,[LastUpdated]
           ,[OutCount])
   
    SELECT  [ISBN]
           ,[Title]
           ,[Author]
           ,[Year]
           ,[Edition]
           ,[Publisher]
           ,[Count]
           ,[PriceChangable]
           ,[OriginalPrice]
           ,[Discount]
           ,[PurchasePrice]
           ,[LastUpdated]
           ,[OutCount]
           FROM @StockTable
END
ELSE IF(@RowCount > 0)
BEGIN

     DECLARE @Count INT    
       
           
     UPDATE TblStock          
     SET [Count]  = [Count] - @BookCount,[OutCount] = [OutCount] + @BookCount
     WHERE [Title] = @Title AND [Author] = @Author AND [Edition] = @Edition And [PurchasePrice] = @Price
     
END      
    	

END
GO
/****** Object:  StoredProcedure [dbo].[up_usr_insert_Stock]    Script Date: 01/18/2015 19:32:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[up_usr_insert_Stock]
(
	@Title Varchar(100),
	@Author Varchar(100),
	@Edition Varchar(100),
	@Price float,
	@BookCount int,
	@StockTable AS UDTStock READONLY
          
)
AS
BEGIN
	SET NOCOUNT ON
	
	DECLARE @RowCount INT
	DECLARE @Publisher VARCHAR(100)
	
	-- Get the values from user defined table.
	SELECT @Title = Title, @Author = Author, @Edition = Edition, @Price = PurchasePrice, @Publisher = Publisher  FROM @StockTable
	
	SELECT @RowCount=COUNT(*) FROM TblStock WHERE [Title] = @Title AND [Author] = @Author AND [Edition] = @Edition And [Publisher] = @Publisher  And [PurchasePrice] = @Price
	AND [Publisher] = @Publisher
	
IF(@RowCount = 0)
BEGIN
	
INSERT INTO [BLS].[dbo].[TblStock]
           ([ISBN]
           ,[Title]
           ,[Author]
           ,[Year]
           ,[Edition]
           ,[Publisher]
           ,[Count]
           ,[PriceChangable]
           ,[OriginalPrice]
           ,[Discount]
           ,[PurchasePrice]
           ,[LastUpdated]
           ,[OutCount])
   
    SELECT  [ISBN]
           ,[Title]
           ,[Author]
           ,[Year]
           ,[Edition]
           ,[Publisher]
           ,[Count]
           ,[PriceChangable]
           ,[OriginalPrice]
           ,[Discount]
           ,[PurchasePrice]
           ,[LastUpdated]
           ,[OutCount]
           FROM @StockTable
END
ELSE IF(@RowCount > 0)
BEGIN

     DECLARE @Count INT
     
     SELECT @Count = [Count] FROM TblStock WHERE [Title] = @Title AND [Author] = @Author AND [Edition] = @Edition And [Publisher] = @Publisher 
     And [PurchasePrice] = @Price
     
     SET @BookCount = @BookCount + @Count 
     
     UPDATE TblStock
     SET [Count]  = @BookCount
     WHERE [Title] = @Title AND [Author] = @Author AND [Edition] = @Edition And [Publisher] = @Publisher And [PurchasePrice] = @Price
     
END      
    	

END
GO
/****** Object:  StoredProcedure [dbo].[up_usr_insert_Receipt]    Script Date: 01/18/2015 19:32:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-------------------------------------------------
-- Author       : Gratian Ruzario
-- Created Date : 13 July 2013
-- Description  : Selects Customer based on FirstName and Mobile Number
-------------------------------------------------

CREATE PROCEDURE [dbo].[up_usr_insert_Receipt]
    @ReceiptNumber varchar(10),
    @ReceiptDate datetime,
    @HistoryID varchar(100),
    @printedFlag bit
	

AS
BEGIN
    
    INSERT INTO [BLS].[dbo].[TblReceipt]
           ([ReceiptNumber]
           ,[ReceiptDate]
           ,[HistoryUID]
           ,[PrintedFlag])
     VALUES
           (@ReceiptNumber
           ,@ReceiptDate
           ,@HistoryID
           ,@printedFlag)
	
END
GO
/****** Object:  StoredProcedure [dbo].[up_usr_insert_OutStock]    Script Date: 01/18/2015 19:32:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[up_usr_insert_OutStock]
(
	@StockTable AS UDTStock READONLY
          
)
AS
BEGIN
	SET NOCOUNT ON
	
	DECLARE @RowCount INT
	DECLARE @Title VARCHAR(100)
    DECLARE @Author VARCHAR(100)
    DECLARE @Edition VARCHAR(100)
    DECLARE @Publisher VARCHAR(100)
    DECLARE @PurchasePrice float
    DECLARE @BookCount INT
    
    -- Get the values from user defined table.
	SELECT @Title = Title, @BookCount = OutCount, @Author = Author, @Edition = Edition, @PurchasePrice = PurchasePrice, @Publisher = Publisher  FROM @StockTable
	
	
	
	SELECT @RowCount=COUNT(*) FROM TblStock WHERE [Title] = @Title AND [Author] = @Author AND [Edition] = @Edition 
	And [Publisher]=@Publisher And [PurchasePrice] = @PurchasePrice
	
IF(@RowCount = 0)
BEGIN
	
INSERT INTO [BLS].[dbo].[TblStock]
           ([ISBN]
           ,[Title]
           ,[Author]
           ,[Year]
           ,[Edition]
           ,[Publisher]
           ,[Count]
           ,[PriceChangable]
           ,[OriginalPrice]
           ,[Discount]
           ,[PurchasePrice]
           ,[LastUpdated]
           ,[OutCount])
   
    SELECT  [ISBN]
           ,[Title]
           ,[Author]
           ,[Year]
           ,[Edition]
           ,[Publisher]
           ,[Count]
           ,[PriceChangable]
           ,[OriginalPrice]
           ,[Discount]
           ,[PurchasePrice]
           ,[LastUpdated]
           ,[OutCount]
           FROM @StockTable
END
ELSE IF(@RowCount > 0)
BEGIN

     DECLARE @Count INT
     DECLARE @OutCount INT
     
     SELECT @Count = [Count], @OutCount = [OutCount] FROM TblStock WHERE [Title] = @Title AND [Author] = @Author 
     AND [Edition] = @Edition And [Publisher]=@Publisher And [PurchasePrice] = @PurchasePrice     
     
     SET @OutCount =  @OutCount + @BookCount
          
     UPDATE TblStock
     SET [OutCount] = @OutCount
     WHERE [Title] = @Title AND [Author] = @Author AND [Edition] = @Edition And [Publisher]=@Publisher 
     And [PurchasePrice] = @PurchasePrice 
     
END      
    	

END
GO
/****** Object:  StoredProcedure [dbo].[up_usr_insert_Order]    Script Date: 01/18/2015 19:32:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[up_usr_insert_Order]
(
	@ISBN Varchar(25),
	@CustomerID Varchar(25),
	@Count int,	
    @OrderTable AS UDTOrder READONLY      
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE  @RowCount AS int
	SET @RowCount = 0
	
	SELECT @RowCount=COUNT(*) FROM TblOrders  WHERE ISBN = @ISBN and CustomerID = @CustomerID
	
IF(@RowCount = 0)
BEGIN
	
INSERT INTO [BLS].[dbo].[TblOrders]   
           ([CustomerID]
           ,[Date]
           ,[ISBN]
           ,[Count]
           ,[DepositAmount]
           ,[OrderClearanceDate]
           ,[Mobile])
   
    SELECT  [CustomerID]
           ,[Date]
           ,[ISBN]
           ,[Count]
           ,[DepositAmount]
           ,[OrderClearanceDate]
           ,[Mobile]
           FROM @OrderTable
END

ELSE

BEGIN
	UPDATE TblOrders 
	SET [Count] = [Count] + @Count
	WHERE ISBN = @ISBN and CustomerID = @CustomerID
END    	

END
GO
/****** Object:  StoredProcedure [dbo].[up_usr_insert_Issue]    Script Date: 01/18/2015 19:32:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[up_usr_insert_Issue]
(	
	@RowCount int OUT,
    @IssueTable AS UDTIssue READONLY      
)
AS
BEGIN
	SET NOCOUNT ON
	
	DECLARE @CustomerID Varchar(20)
	DECLARE @Title Varchar(100)
	DECLARE @Author Varchar(100)
	DECLARE @Edition Varchar(100)
	DECLARE @Publisher Varchar(100)
	DECLARE @Count INT
	DECLARE @Price float
	DECLARE @issueDate DateTime
	DECLARE @HistoryID VarChar(100)
	
	SET @RowCount = 0
	
	-- Get the values from user defined table.
	SELECT @CustomerID = [CustomerID],@Count = [BookCount],  @Title = Title, @Author = Author, @Edition = Edition, 
	@Publisher =[Publisher] ,@Price = BookPrice , @issueDate = [IssueDate] FROM @IssueTable
	
	SELECT @RowCount=COUNT(*) FROM TblIssue  WHERE [Title] = @Title and [Author] = @Author and [Edition] = @Edition 
	and [Publisher] = @Publisher and [BookPrice] = @price and CustomerID = @CustomerID and [IssueDate] = @issueDate
	and [HistoryUID] = @HistoryID
	
IF(@RowCount = 0)
BEGIN
	
INSERT INTO [BLS].[dbo].[TblIssue]    
           ([CustomerID]
           ,[Title] 
	       ,[Author]
	       ,[Edition]
	       ,[Publisher] 
           ,[IssueDate]
           ,[BookCount]
           ,[BookPrice]
           ,[RecieptNumber]
           ,[HistoryUID]
           ,[IssueType]
           ,[ReturnDate]
           ,[EarlyIssue])
   
    SELECT [CustomerID]
           ,[Title] 
	       ,[Author]
	       ,[Edition]
	       ,[Publisher] 
           ,[IssueDate]
           ,[BookCount]
           ,[BookPrice]
           ,[RecieptNumber]
           ,[HistoryUID]
           ,[IssueType]
           ,[ReturnDate]
           ,[EarlyIssue]
           FROM @IssueTable
END

ELSE
BEGIN
   DECLARE @CurrentCount INT
   SELECT @CurrentCount = BookCount FROM TblIssue WHERE [Title] = @Title and [Author] = @Author and [Edition] = @Edition 
   and @Publisher =[Publisher] and [BookPrice] = @price and CustomerID = @CustomerID and [IssueDate] = @issueDate
    
   UPDATE TblIssue SET BookCount = @CurrentCount + @Count 
   WHERE [Title] = @Title and [Author] = @Author and [Edition] = @Edition and [BookPrice] = @price  
   and [Publisher]= @Publisher and CustomerID = @CustomerID and [IssueDate] = @issueDate
END

END
GO
/****** Object:  StoredProcedure [dbo].[up_usr_insert_History]    Script Date: 01/18/2015 19:32:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[up_usr_insert_History]
(
	@id Varchar(50),
	@RowCount int OUT,
    @TransactionTable AS UDTTransactionHistory READONLY      
)
AS
BEGIN
	SET NOCOUNT ON
	
	SET @RowCount = 0
	
	SELECT @RowCount=COUNT(*) FROM TblTransactionHistory WHERE HistoryUID  = @id 
	
IF(@RowCount = 0)
BEGIN
	
INSERT INTO [BLS].[dbo].[TblTransactionHistory]  
           ([HistoryUID]
           ,[HistoryDate]
           ,[IssueDate]
           ,[ReturnDate]
           ,[Type]
           ,[CustomerID]
           ,[Title]
           ,[Author]
           ,[Edition]
           ,[Publisher] 
           ,[PurchasePrice]
           ,[AmountIN]
           ,[AmountOut]          
           ,[RecieptNumber]
           ,[CheckNumber])
   
    SELECT  [HistoryUID]
           ,[HistoryDate]
           ,[IssueDate]
           ,[ReturnDate]
           ,[Type]
           ,[CustomerID]
           ,[Title]
           ,[Author]
           ,[Edition]
           ,[Publisher] 
           ,[PurchasePrice]
           ,[AmountIN]
           ,[AmountOut]           
           ,[RecieptNumber]
           ,[CheckNumber]           
           FROM @TransactionTable
END    	

END
GO
/****** Object:  StoredProcedure [dbo].[up_usr_insert_CustomerBooks]    Script Date: 01/18/2015 19:32:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[up_usr_insert_CustomerBooks]
(
	@CustBooksTable AS UDTCustomerBooks READONLY,
	@Title Varchar(100),
	@Author Varchar(100),
	@Edition Varchar(100),
	@Price float,
	@Count int
          
)
AS

BEGIN
	SET NOCOUNT ON
	
	DECLARE @RowCount INT
	
	SELECT @RowCount=COUNT(*) FROM TblCustomerBooks WHERE [Title] = @Title AND [Author] = @Author AND [Edition] = @Edition And [OriginalPrice] = @Price
	
	IF(@RowCount = 0)
		BEGIN
			INSERT INTO [BLS].[dbo].[TblCustomerBooks]
				   ([CustBookID]
				   ,[CustomerID]
				   ,[Title]
				   ,[Author]
				   ,[Edition]
				   ,[OriginalPrice]
				   ,[Count]
				   ,[Date]
				   ,[HistoryUID])
		   
			SELECT  [CustBookID]
				   ,[CustomerID]
				   ,[Title]
				   ,[Author]
				   ,[Edition]
				   ,[OriginalPrice]
				   ,[Count]
				   ,[Date]
				   ,[HistoryUID]
				   FROM @CustBooksTable
		END
	 ELSE IF(@RowCount > 0)
		BEGIN
			 UPDATE TblCustomerBooks
			 SET [Count] = [Count] + @Count
			 WHERE [Title] = @Title AND [Author] = @Author AND [Edition] = @Edition And [OriginalPrice] = @Price
     
		END   
END
GO
/****** Object:  StoredProcedure [dbo].[up_usr_insert_Customer]    Script Date: 01/18/2015 19:32:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[up_usr_insert_Customer]
(
	
	@Name VARCHAR(100) ,
	@Mobile VARCHAR(10),
	@CustTable AS UDTCustomer READONLY,
	@Status bit OUT
          
)
AS
BEGIN
	SET NOCOUNT ON
	
	DECLARE @Count int
	SET @Count = 0;	
	
	SELECT @Count = COUNT(CustomerID)	
	FROM TblCustomer WITH(NOLOCK)
	WHERE Name = @Name and [Student Mobile] = @Mobile	
    
    IF(@Count = 0)
		BEGIN
			SET @Status = 1;
			
			INSERT INTO [BLS].[dbo].[TblCustomer] 
				   ([CustomerID]
				  ,[Name]		  
				  ,[Father Name]
				  ,[DOB]
				  ,[Parent Phone] 
				  ,[Parent Mobile]
				  ,[Student Mobile] 
				  ,[Address]
				  ,[CollegeName]
				  ,[Course]
				  ,[CourseDuration]
				  ,[EmailID]
				  ,[MembershipDate]
				  ,[MembershipType]
				  ,[MembershipPeriod]
				  ,[Activation]
				  ,[BookCount]
				  ,[DepositAmount]
				  ,[AdvanceAmount]
				  ,[BalanceAmount]
				  ,[RefundAmount]
				  ,[RecieptNumber]
				  ,[MaxLimit]
				  ,[UsedLimit]
				  ,[EarlyActivation]
				  ,CreatedDatetime
				  ,[ImagePath])
		   
			SELECT [CustomerID]
				  ,[Name]
				  ,[Father Name]
				  ,[DOB]
				  ,[Parent Phone] 
				  ,[Parent Mobile]
				  ,[Student Mobile] 
				  ,[Address]
				  ,[CollegeName]
				  ,[Course]
				  ,[CourseDuration]
				  ,[EmailID]
				  ,[MembershipDate]
				  ,[MembershipType]
				  ,[MembershipPeriod]
				  ,[Activation]
				  ,[BookCount]
				  ,[DepositAmount]
				  ,[AdvanceAmount]
				  ,[BalanceAmount]
				  ,[RefundAmount]
				  ,[RecieptNumber]
				  ,[MaxLimit]
				  ,[UsedLimit]
				  ,[EarlyActivation]
				  ,GETDATE()
				  ,[ImagePath]
				   FROM @CustTable 
				   
		DECLARE @EActivation As BIT
		DECLARE @MembDate AS DATE
		DECLARE @CustID AS VARCHAR(20)
		SELECT @CustID = [CustomerID] ,@EActivation = [EarlyActivation],@MembDate = [MembershipDate]
		FROM @CustTable
		
		IF(@EActivation = 0)
		BEGIN
		 DECLARE @RowCount As INT 
		   SELECT  @RowCount = COUNT(ID) FROM TblID
		   IF(@RowCount = 0)
			 BEGIN
			    INSERT INTO [BLS].[dbo].[TblID]
                ([IDDate]
                 ,[ID])
                VALUES
					(@MembDate
					,@CustID)
			 END
		   ELSE
		     BEGIN
		        UPDATE [TblID]
                SET [IDDate] = @MembDate, ID =@CustID    
		     END	 
				   
		END		   
				   
		END
    ELSE
		BEGIN
				SET @Status = 0;
		END
	
       
    	

END
GO
/****** Object:  StoredProcedure [dbo].[up_usr_Get_Issue_Count]    Script Date: 01/18/2015 19:32:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[up_usr_Get_Issue_Count]
(
	@CustomerID Varchar(20),
	@Title Varchar(100),
	@Author Varchar(100),
	@Edition Varchar(100),
	@Publisher Varchar(100),
	@price float,	
	@RowCount int OUT          
)
AS
BEGIN
	SET NOCOUNT ON
	
	SET @RowCount = 0
	
	SELECT @RowCount=COUNT(*) FROM TblIssue  WHERE [Title] = @Title and [Author] = @Author and [Edition] = @Edition
	and [Publisher] =@Publisher and [BookPrice]  = @price and CustomerID = @CustomerID
	

END
GO
/****** Object:  StoredProcedure [dbo].[up_usr_Delete_stock]    Script Date: 01/18/2015 19:32:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[up_usr_Delete_stock]
(	
	@Title Varchar(100),
	@Author Varchar(100),
	@Edition Varchar(100),
	@Price float,	
	@Status int OUTPUT
     
)
AS
BEGIN
	SET NOCOUNT ON
	
	SET @Status = 0
	
	SELECT @Status =COUNT(*) FROM TblStock  WHERE [Title] = @Title AND [Author] = @Author AND [Edition] = @Edition And [PurchasePrice] = @Price
	
IF(@Status > 0)
BEGIN
	DELETE FROM [BLS].[dbo].[TblStock]
	WHERE [Title] = @Title AND [Author] = @Author AND [Edition] = @Edition And [PurchasePrice] = @Price
END



END
GO
/****** Object:  StoredProcedure [dbo].[up_usr_Delete_Issue_OnCustID]    Script Date: 01/18/2015 19:32:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[up_usr_Delete_Issue_OnCustID]
(
	@CustomerID Varchar(20),	
	@Status int OUTPUT
     
)
AS
BEGIN
	SET NOCOUNT ON
	
	SET @Status = 0
	
	SELECT @Status =COUNT(*) FROM TblIssue  WHERE CustomerID = @CustomerID 
	
IF(@Status > 0)
BEGIN
	DELETE FROM [BLS].[dbo].[TblIssue]
	WHERE [CustomerID] = @CustomerID 
END



END
GO
/****** Object:  StoredProcedure [dbo].[up_usr_Delete_Issue]    Script Date: 01/18/2015 19:32:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[up_usr_Delete_Issue]
(
	@CustomerID Varchar(20),
	@Title Varchar(100),
	@Author Varchar(100),
	@Edition Varchar(100),
	@Publisher Varchar(100),
	@price float,
	@HistoryUID VarChar(100),
	@Status int OUTPUT
     
)
AS
BEGIN
	SET NOCOUNT ON
	
	SET @Status = 0
	
	SELECT @Status =COUNT(*) FROM TblIssue  WHERE [Title] = @Title and [Author] = @Author and [Edition] = @Edition 
	and [Publisher] = @Publisher and [BookPrice] = @price and CustomerID = @CustomerID and [HistoryUID] = @HistoryUID
	
IF(@Status > 0)
BEGIN
	DELETE FROM [BLS].[dbo].[TblIssue]
	WHERE [Title] = @Title and [Author] = @Author and [Edition] = @Edition and [BookPrice] = @price and CustomerID = @CustomerID and [HistoryUID] = @HistoryUID 
END



END
GO
/****** Object:  StoredProcedure [dbo].[up_usr_Delete_History_OnCustomerID]    Script Date: 01/18/2015 19:32:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[up_usr_Delete_History_OnCustomerID]
(
	@CustomerID VARCHAR(20),
	@Status Bit OUTPUT
     
)
AS
BEGIN
	SET NOCOUNT ON
	
	DECLARE @Count AS Int;
	SET @Count = 0	
	SELECT @Count =COUNT(*) FROM [TblTransactionHistory]  WHERE [CustomerID]  = @CustomerID
	
    IF(@Count > 0)
		BEGIN
		    DELETE FROM [BLS].[dbo].[TblTransactionHistory]
			WHERE [CustomerID]  = @CustomerID
			SET @Status = 1;
		END
	ELSE
		BEGIN
			SET @Status = 0;
		END


END
GO
/****** Object:  StoredProcedure [dbo].[up_usr_Delete_History]    Script Date: 01/18/2015 19:32:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[up_usr_Delete_History]
(
	@HistoryUID VarChar(100),
	@Status Bit OUTPUT
     
)
AS
BEGIN
	SET NOCOUNT ON
	
	DECLARE @Count AS Int;
	SET @Count = 0
	
	SELECT @Count =COUNT(*) FROM [TblTransactionHistory]  WHERE [HistoryUID] = @HistoryUID
	print @Count
    IF(@Count > 0)
		BEGIN		    
			DELETE FROM [BLS].[dbo].[TblTransactionHistory]
			WHERE [HistoryUID] = @HistoryUID
			SET @Status = 1;
		END
	ELSE
		BEGIN
			SET @Status = 0;
		END


END
GO
/****** Object:  StoredProcedure [dbo].[up_usr_Stock_Exist]    Script Date: 01/18/2015 19:32:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[up_usr_Stock_Exist]
(
	@Title Varchar(100),
	@Author Varchar(100),
	@Edition Varchar(100),
	@Publisher Varchar(100),
	@price float,	
	@RowCount int OUT,
	@Book_Number Varchar(4) OUT          
)
AS
BEGIN
	SET NOCOUNT ON
	
	SET @RowCount = 0
	SELECT @RowCount=COUNT(*) FROM TblStock  WHERE [Title] = @Title and [Author] = @Author and [Edition] = @Edition 
						and [Publisher]  = @Publisher and  [PurchasePrice] = @price  
						
	IF(@RowCount > 0)
	BEGIN
	SELECT @Book_Number = [ISBN] FROM TblStock  WHERE [Title] = @Title and [Author] = @Author and [Edition] = @Edition 
						and [Publisher]  = @Publisher and  [PurchasePrice] = @price
	END
END
GO
/****** Object:  StoredProcedure [dbo].[up_usr_select_UserIssues]    Script Date: 01/18/2015 19:32:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[up_usr_select_UserIssues]
(
	@CustID Varchar(20)
	
          
)
AS
BEGIN
	SET NOCOUNT ON
	
	SELECT *
    FROM TblIssue 
    WHERE [CustomerID] = @CustID
END
GO
/****** Object:  StoredProcedure [dbo].[up_usr_select_UserEarlyIssues]    Script Date: 01/18/2015 19:32:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[up_usr_select_UserEarlyIssues]
(
	@CustID Varchar(20)
	
          
)
AS
BEGIN
	SET NOCOUNT ON
	SELECT *
    FROM TblIssue 
    WHERE [CustomerID] = @CustID AND [EarlyIssue] = 1
END
GO
/****** Object:  StoredProcedure [dbo].[up_usr_select_Suppliers]    Script Date: 01/18/2015 19:32:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-------------------------------------------------
-- Author       : Gratian Ruzario
-- Created Date : 02 June 2013
-- Description  : Selects supplier list
-------------------------------------------------

CREATE PROCEDURE [dbo].[up_usr_select_Suppliers]
AS
BEGIN
	SELECT 
		[ShortName],
		[FullName],
		[City],
		[Phone],
		[Address]		
	FROM TblSupplier WITH(NOLOCK)
END
GO
/****** Object:  StoredProcedure [dbo].[up_usr_select_ReceiptNumber]    Script Date: 01/18/2015 19:32:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-------------------------------------------------
-- Author       : Gratian Ruzario
-- Created Date : 13 July 2013
-- Description  : Selects Customer based on FirstName and Mobile Number
-------------------------------------------------

CREATE PROCEDURE [dbo].[up_usr_select_ReceiptNumber]
    @ReceiptNumber varchar(10) OUT
	

AS
BEGIN
    
    SELECT TOP(1) @ReceiptNumber = [ReceiptNumber]	
	FROM TblReceipt WITH(NOLOCK) Order by [ReceiptDate] desc
		
	
END
GO
/****** Object:  StoredProcedure [dbo].[up_usr_Select_GetCustomerLimits]    Script Date: 01/18/2015 19:32:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-------------------------------------------------
-- Author       : Gratian Ruzario
-- Created Date : 13 July 2013
-- Description  : Selects Customer based on FirstName and Mobile Number
-------------------------------------------------

CREATE PROCEDURE [dbo].[up_usr_Select_GetCustomerLimits]
    @ID varchar(20) ,
    @MaxLimit float OUT,
    @LimitUsed float OUT
	

AS
BEGIN
    
    SELECT @MaxLimit = 	[MaxLimit] , @LimitUsed = [UsedLimit]
	FROM TblCustomer WITH(NOLOCK)
	WHERE [CustomerID]	= @ID
	
END
GO
/****** Object:  StoredProcedure [dbo].[up_usr_select_customerID]    Script Date: 01/18/2015 19:32:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-------------------------------------------------
-- Author       : Gratian Ruzario
-- Created Date : 13 July 2013
-- Description  : Selects Customer based on FirstName and Mobile Number
-------------------------------------------------

CREATE PROCEDURE [dbo].[up_usr_select_customerID]
    @StartValue int,
    @ID int OUT
	

AS
BEGIN
    
    
    
 --   SELECT @ID = MAX(CustomerID)	
	--FROM TblCustomer WITH(NOLOCK)
	--WHERE CustomerID >= @StartValue
	
	SELECT TOP(1)@ID = [CustomerID]
	FROM TblCustomer WITH(NOLOCK)
	WHERE [EarlyActivation] = 0
	order by [CreatedDatetime] desc
	
	
	IF(@ID IS NULL)
		BEGIN		   
		   RETURN @StartValue;
		END
	ELSE
		BEGIN		    
			RETURN @ID;
		END
	
END
GO
/****** Object:  StoredProcedure [dbo].[up_usr_Delete_Customer]    Script Date: 01/18/2015 19:32:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[up_usr_Delete_Customer]
(
	@CustomerID varchar(20),	
	@Status int OUTPUT
     
)
AS
BEGIN
	SET NOCOUNT ON
	
	SET @Status = 0
	
	SELECT @Status =COUNT(*) FROM TblCustomer  WHERE [CustomerID] = @CustomerID 
	
IF(@Status > 0)
BEGIN
	DELETE FROM [BLS].[dbo].[TblCustomer]
	WHERE [CustomerID] = @CustomerID 
END



END
GO
/****** Object:  StoredProcedure [dbo].[up_usr_Check_Customer_Exist]    Script Date: 01/18/2015 19:32:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[up_usr_Check_Customer_Exist]
(
	@CustomerID VARCHAR(20),		
	@RowCount int OUT          
)
AS
BEGIN
	SET NOCOUNT ON
	
	SET @RowCount = 0
	
	SELECT @RowCount=COUNT(*) FROM TblCustomer WHERE  [CustomerID] = @CustomerID
	

END
GO
/****** Object:  StoredProcedure [dbo].[up_usr_Execute_Insert_Check_Details]    Script Date: 01/18/2015 19:32:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[up_usr_Execute_Insert_Check_Details]
(	
	  @CustomerID varchar(20),      
      @CheckNumber varchar(12),
      @CheckAmount float,
      @ClearanceDate date,
      @CheckIssueDate date,
      @CheckStatus varchar(5)
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @RowCount INT
	SET @RowCount = 0
	
	-- Get the values from user defined table.
	SELECT @RowCount=COUNT(*) FROM TblCheckDetails WHERE [CheckNumber] = @CheckNumber
	
IF(@RowCount = 0)
BEGIN
	
INSERT INTO [BLS].[dbo].[TblCheckDetails]
           ([CustomerID]
           ,[CheckNumber]
           ,[CheckAmount]
           ,[CheckIssueDate]
           ,[CheckClearanceDate]
           ,[CheckStatus])
     VALUES
           (@CustomerID 
           ,@CheckNumber
           ,@CheckAmount
           ,@CheckIssueDate 
           ,@ClearanceDate
           ,@CheckStatus)       
END

END
GO
/****** Object:  StoredProcedure [dbo].[up_usr_Update_StockonIssue]    Script Date: 01/18/2015 19:32:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[up_usr_Update_StockonIssue]
(
	@Title Varchar(100),
	@Author Varchar(100),
	@Edition Varchar(25),
	@Publisher Varchar(100),
	@price float,
	@BookCount int
          
)
AS
BEGIN
	SET NOCOUNT ON
	
	UPDATE TblStock 
	SET [Count] = [Count] -  @BookCount,[OutCount] = [OutCount] + @BookCount
	WHERE [Title] = @Title AND [Author] = @Author AND [Edition] = @Edition And [Publisher] = @Publisher And [PurchasePrice] = @price
   
    	

END
GO
/****** Object:  StoredProcedure [dbo].[up_usr_Update_StockForIssueDelete]    Script Date: 01/18/2015 19:32:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[up_usr_Update_StockForIssueDelete]
(
	@Title Varchar(100),
	@Author Varchar(100),
	@Edition Varchar(25),
	@price float,
	@BookCount int,
	@EarlyIssue bit
          
)
AS
BEGIN
	SET NOCOUNT ON
	
	DECLARE @i AS int
	SELECT @i=[OutCount] FROM TblStock
	WHERE [Title] = @Title AND [Author] = @Author AND [Edition] = @Edition And [PurchasePrice] = @price
	
	IF(@BookCount > @i)
	  BEGIN
	    SET @i = 0;
	  END
	ELSE
	  BEGIN
	    SET @i = @i - @BookCount;
	  END 
	
	
	IF(@EarlyIssue = 1)
		BEGIN
			UPDATE TblStock 
			SET [OutCount] = @i
			WHERE [Title] = @Title AND [Author] = @Author AND [Edition] = @Edition And [PurchasePrice] = @price	
		END
	ELSE
		BEGIN
			UPDATE TblStock 
			SET [Count] = [Count] +  @BookCount,[OutCount] = @i
			WHERE [Title] = @Title AND [Author] = @Author AND [Edition] = @Edition And [PurchasePrice] = @price		
		END	
	
	
	
	
	
   
    	

END
GO
/****** Object:  StoredProcedure [dbo].[up_usr_Update_StockDtail]    Script Date: 01/18/2015 19:32:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[up_usr_Update_StockDtail]
(
	@Title Varchar(100),
	@Author Varchar(100),
	@Edition Varchar(25),
	@oldPurchasePrice float,
	@price float,
	@StockTable AS UDTStock READONLY
	          
)
AS
BEGIN
	SET NOCOUNT ON
	
	SET NOCOUNT ON
	
	DECLARE @i AS int
	SELECT @i=COUNT(ISBN) FROM TblStock
	WHERE [Title] = @Title AND [Author] = @Author AND [Edition] = @Edition And [PurchasePrice] = @price
	
	IF(@i = 0)
	  BEGIN
	    DELETE from TblStock WHERE [Title] = @Title AND [Author] = @Author AND [Edition] = @Edition And [PurchasePrice] = @oldPurchasePrice
	    INSERT INTO [BLS].[dbo].[TblStock]
           ([ISBN]
           ,[Title]
           ,[Author]
           ,[Year]
           ,[Edition]
           ,[Publisher]
           ,[Count]
           ,[PriceChangable]
           ,[OriginalPrice]
           ,[Discount]
           ,[PurchasePrice]
           ,[LastUpdated]
           ,[OutCount])
   
    SELECT  [ISBN]
           ,[Title]
           ,[Author]
           ,[Year]
           ,[Edition]
           ,[Publisher]
           ,[Count]
           ,[PriceChangable]
           ,[OriginalPrice]
           ,[Discount]
           ,[PurchasePrice]
           ,[LastUpdated]
           ,[OutCount]
           FROM @StockTable
	  
    END
	ELSE
	  BEGIN
	    
	    UPDATE TblStock 
		SET [Count] = dc.[Count],OriginalPrice = dc.OriginalPrice,OutCount = dc.OutCount,PurchasePrice = dc.PurchasePrice,PriceChangable = dc.PriceChangable
		FROM TblStock s INNER JOIN @StockTable dc 
		ON  s.[Title] = @Title AND s.[Author] = @Author AND s.[Edition] = @Edition And s.[PurchasePrice] = @price
	  END     
	
	
	
   
    	

END
GO
/****** Object:  StoredProcedure [dbo].[up_usr_Update_Stock]    Script Date: 01/18/2015 19:32:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[up_usr_Update_Stock]
(
	@Title Varchar(100),
	@Author Varchar(100),
	@Edition Varchar(25),
	@Publisher Varchar(100),
	@price float,
	@BookCount int
          
)
AS
BEGIN
	SET NOCOUNT ON
	
	DECLARE @i AS int
	SELECT @i=[OutCount] FROM TblStock
	WHERE [Title] = @Title AND [Author] = @Author AND [Edition] = @Edition And [Publisher] = @Publisher 
	And [PurchasePrice]  = @price
	
	IF(@BookCount > @i)
	  BEGIN
	    SET @i = 0;
	  END
	ELSE
	  BEGIN
	    SET @i = @i - @BookCount;
	  END     
	
	
	UPDATE TblStock 
	SET [Count] = [Count] +  @BookCount,[OutCount] = @i
	WHERE [Title] = @Title AND [Author] = @Author AND [Edition] = @Edition And [Publisher] = @Publisher 
	 And [PurchasePrice] = @price
   
    	

END
GO
/****** Object:  StoredProcedure [dbo].[up_usr_Update_Limit]    Script Date: 01/18/2015 19:32:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[up_usr_Update_Limit]
(
	@CustomerID Varchar(25),
	@BookCount int,
	@price float
          
)
AS
BEGIN
	SET NOCOUNT ON
	
		BEGIN
			UPDATE TblCustomer  
			SET [BookCount] = [BookCount] -  @BookCount,
			[UsedLimit]  = [UsedLimit] - (@price * @BookCount)
			WHERE [CustomerID] = @CustomerID
		END
END
GO
/****** Object:  StoredProcedure [dbo].[up_usr_Update_History_On_Return]    Script Date: 01/18/2015 19:32:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[up_usr_Update_History_On_Return]
(
	@HistoryID varchar(50),
	@CheckNumber varchar(20),
	@AmountOut Float
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @RowCount INT
	SET @RowCount = 0
	
	SELECT @RowCount= COUNT(*) FROM TblTransactionHistory  WHERE [HistoryUID] = @HistoryID 
	
IF(@RowCount > 0)
BEGIN
    UPDATE [BLS].[dbo].[TblTransactionHistory]
    SET [AmountOut]  = @AmountOut,
    [CheckNumber] = @CheckNumber
    WHERE [HistoryUID] = @HistoryID 
      

END



END
GO
/****** Object:  StoredProcedure [dbo].[up_usr_Update_CustomerDetailsOnReturn]    Script Date: 01/18/2015 19:32:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[up_usr_Update_CustomerDetailsOnReturn]
(
	@CustomerID Varchar(25),
	@BookCount int,
	@price float,
	@Advance float,
	@Balance float
          
)
AS
BEGIN
	SET NOCOUNT ON
	
		BEGIN
			UPDATE TblCustomer  
			SET [BookCount] = [BookCount] -  @BookCount,
			[AdvanceAmount] = @Advance,
			[BalanceAmount] = @Balance
			WHERE [CustomerID] = @CustomerID
		END
END
GO
/****** Object:  StoredProcedure [dbo].[up_usr_Update_CustomerDetailsOnNonRentalIssue]    Script Date: 01/18/2015 19:32:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[up_usr_Update_CustomerDetailsOnNonRentalIssue]
(
	@CustomerID Varchar(25),
	@BookCount int,
	@LimitUsed float          
)
AS
BEGIN
	SET NOCOUNT ON
	
		BEGIN
			UPDATE TblCustomer  
			SET [BookCount] = [BookCount] +  @BookCount,
			[UsedLimit]  = [UsedLimit] + @LimitUsed
			WHERE [CustomerID] = @CustomerID
		END
END
GO
/****** Object:  StoredProcedure [dbo].[up_usr_Update_CustomerDetails]    Script Date: 01/18/2015 19:32:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[up_usr_Update_CustomerDetails]
(
	@CustomerID varchar(20),	
    @CustomerTable AS UDTCustomer READONLY,
    @RowCount int OUT
)
AS
BEGIN
	SET NOCOUNT ON
	
	SET @RowCount = 0
	
	SELECT @RowCount= COUNT(*) FROM TblCustomer  WHERE [CustomerID] = @CustomerID 
	
IF(@RowCount > 0)
BEGIN
    UPDATE [BLS].[dbo].[TblCustomer]
    SET [CustomerID] = dc.[CustomerID]
      ,[Name] = dc.[Name]      
      ,[Father Name] = dc.[Father Name]
      ,[DOB] = dc.[DOB]
      ,[Parent Phone] = dc.[Parent Phone]
      ,[Parent Mobile] = dc.[Parent Mobile]
      ,[Student Mobile] = dc.[Student Mobile]
      ,[Address] = dc.[Address]
      ,[CollegeName] = dc.[CollegeName]
      ,[Course] = dc.[Course]
      ,[CourseDuration] = dc.[CourseDuration]
      ,[EmailID] = dc.[EmailID]
      ,[MembershipDate] = dc.[MembershipDate]
      ,[MembershipType] = dc.[MembershipType]
      ,[MembershipPeriod] = dc.[MembershipPeriod]
      ,[Activation] = dc.[Activation]
      ,[BookCount] = dc.[BookCount]
      ,[DepositAmount] = dc.[DepositAmount]
      ,[AdvanceAmount] = dc.[AdvanceAmount]
      ,[BalanceAmount] = dc.[BalanceAmount]
      ,[RefundAmount] = dc.[RefundAmount]
      ,[RecieptNumber] = dc.[RecieptNumber]
      ,[MaxLimit] = dc.[MaxLimit]
      ,[UsedLimit] = dc.[UsedLimit]
      ,[EarlyActivation] = dc.[EarlyActivation]
      ,[ImagePath] = dc.[ImagePath]
      FROM TblCustomer c
      INNER JOIN @CustomerTable dc
      ON  c.CustomerID = dc.CustomerID

END



END
GO
/****** Object:  StoredProcedure [dbo].[up_usr_Update_Customer]    Script Date: 01/18/2015 19:32:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[up_usr_Update_Customer]
(
	@CustomerID Varchar(25),
	@BookCount int,
	@AdvanceAmount float,
	@BalanceAmount float,
	@LimitUsed float
          
)
AS
BEGIN
	SET NOCOUNT ON
	IF(@LimitUsed = -1)
		BEGIN
			UPDATE TblCustomer  
			SET [BookCount] = [BookCount] +  @BookCount,[AdvanceAmount] = @AdvanceAmount,[BalanceAmount]  = @BalanceAmount
			WHERE [CustomerID] = @CustomerID
		END
	ELSE
		BEGIN
			UPDATE TblCustomer  
			SET [BookCount] = [BookCount] +  @BookCount,[AdvanceAmount] = @AdvanceAmount,[BalanceAmount]  = @BalanceAmount,
			[UsedLimit] = [UsedLimit] + @LimitUsed
			WHERE [CustomerID] = @CustomerID
		END
    	

END
GO
/****** Object:  StoredProcedure [dbo].[up_usr_Undo_Issue_Rental]    Script Date: 01/18/2015 19:32:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[up_usr_Undo_Issue_Rental]
(           
            @CustomerID VARCHAR(20),
            @Title VARCHAR(100),
            @Author VARCHAR(100),
            @Edition VARCHAR(100),
            @Publisher VARCHAR(100),
            @price float,
            @HistoryUID VarChar(100),
            @BookCount int,
            @EarlyIssue bit,            
            @Status bit OUT
          
)
AS
BEGIN
	
	BEGIN TRY	
	
	DECLARE @RowCount AS int
	
	IF(@EarlyIssue = 1)--Early ISSUE
		BEGIN
		    BEGIN TRANSACTION
		    
		    EXEC up_usr_Delete_Issue @customerID,@Title,@Author,@Edition,@Publisher,@price,@HistoryUID,@Status;
					
			EXEC up_usr_Update_StockForIssueDelete @Title,@Author,@Edition,@Price,@BookCount,@EarlyIssue;
					
			UPDATE TblCustomer SET [BookCount] = [BookCount] -  @BookCount WHERE [CustomerID] = @CustomerID
					
			SET @Status = 1;	
				
			COMMIT					
		    
		END
	ELSE --Normal ISSUE	
	    BEGIN
			BEGIN TRANSACTION
			
			
	
				   DECLARE @Count AS INT
                   
                   SELECT @Count =COUNT(*) FROM [TblTransactionHistory]  WHERE [HistoryUID] = @HistoryUID                  				   
				  		
					IF(@Count > 0)
					BEGIN
						EXEC up_usr_Delete_History @HistoryUID ,@Status;
						
						EXEC up_usr_Delete_Issue @customerID,@Title,@Author,@Edition,@Publisher,@price,@HistoryUID,@Status;
					
						EXEC up_usr_Update_StockForIssueDelete @Title,@Author,@Edition,@Price,@BookCount,@EarlyIssue;
					
						UPDATE TblCustomer SET [BookCount] = [BookCount] -  @BookCount WHERE [CustomerID] = @CustomerID
					
						SET @Status = 1;	
				
						
					END
				ELSE
					BEGIN
						SET @Status = 0;
					END
			COMMIT		
	    END
	END TRY
	
	BEGIN CATCH	
	
	SET @Status = 0;
	IF @@TRANCOUNT > 0
	ROLLBACK TRANSACTION 
		
	-- Raise an error with the details of the exception   
	DECLARE @ErrMsg nvarchar(4000), @ErrSeverity int  
	SELECT @ErrMsg = ERROR_MESSAGE(),   
	@ErrSeverity = ERROR_SEVERITY()   
		  
	RAISERROR(@ErrMsg, @ErrSeverity, 1)
	
	END CATCH

END
GO
/****** Object:  StoredProcedure [dbo].[up_usr_Undo_Issue_NonRental]    Script Date: 01/18/2015 19:32:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[up_usr_Undo_Issue_NonRental]
(           
            @CustomerID VARCHAR(20),
            @Title VARCHAR(100),
            @Author VARCHAR(100),
            @Edition VARCHAR(100),
            @Publisher VARCHAR(100),
            @price float,
            @HistoryUID VarChar(100),
            @BookCount int,
            @EarlyIssue bit,            
            @Status bit OUT
          
)
AS
BEGIN
	
	BEGIN TRY	
	
	DECLARE @RowCount AS int
	
	IF(@EarlyIssue = 1)--Early ISSUE
		BEGIN
		    BEGIN TRANSACTION
		    
		    EXEC up_usr_Delete_Issue @customerID,@Title,@Author,@Edition,@Publisher,@price,@HistoryUID,@Status;
					
			EXEC up_usr_Update_StockForIssueDelete @Title,@Author,@Edition,@Price,@BookCount,@EarlyIssue;
					
			EXEC up_usr_Update_Limit @CustomerID,@BookCount,@price;
					
			SET @Status = 1;	
				
			COMMIT					
		    
		END
	ELSE --Normal ISSUE	
	    BEGIN
			BEGIN TRANSACTION		
			
                   DECLARE @Count AS INT
                   
                   SELECT @Count =COUNT(*) FROM [TblTransactionHistory]  WHERE [HistoryUID] = @HistoryUID                  				   
				  		
					IF(@Count > 0)
						BEGIN
							EXEC up_usr_Delete_History @HistoryUID ,@Status;
							
							EXEC up_usr_Delete_Issue @customerID,@Title,@Author,@Edition,@Publisher,@price,@HistoryUID,@Status;
						
							EXEC up_usr_Update_StockForIssueDelete @Title,@Author,@Edition,@Price,@BookCount,@EarlyIssue;
						
							EXEC up_usr_Update_Limit @CustomerID,@BookCount,@price;
						
							SET @Status = 1;	
					
							
						END
					ELSE
						BEGIN
							SET @Status = 0;
						END
			COMMIT
	    END
	END TRY
	
	BEGIN CATCH	
	
	SET @Status = 0;
	IF @@TRANCOUNT > 0
	ROLLBACK TRANSACTION 
		
	-- Raise an error with the details of the exception   
	DECLARE @ErrMsg nvarchar(4000), @ErrSeverity int  
	SELECT @ErrMsg = ERROR_MESSAGE(),   
	@ErrSeverity = ERROR_SEVERITY()   
		  
	RAISERROR(@ErrMsg, @ErrSeverity, 1)
	
	END CATCH

END
GO
/****** Object:  StoredProcedure [dbo].[up_usr_Undo_Issue]    Script Date: 01/18/2015 19:32:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[up_usr_Undo_Issue]
(           
            @CustomerID VARCHAR(20),
            @Title VARCHAR(100),
            @Author VARCHAR(100),
            @Edition VARCHAR(100),
            @Publisher VARCHAR(100),
            @price float,
            @HistoryUID VarChar(100),
            @BookCount int,            
            @Status bit OUT
          
)
AS
BEGIN
	
	BEGIN TRY
	
	BEGIN TRANSACTION
	
	DECLARE @RowCount AS int
	
	
	EXEC up_usr_Delete_History @HistoryUID ,@Status;
	
	IF(@Status = 1)
		BEGIN
			EXEC up_usr_Delete_Issue @customerID,@Title,@Author,@Edition,@Publisher,@price,@HistoryUID,@Status;
		
			EXEC up_usr_Update_Stock @Title,@Author,@Edition,@Publisher,@Price,@BookCount;
		
			EXEC up_usr_Update_Limit @CustomerID,@BookCount,@price;
		
			SET @Status = 1;	
	
			COMMIT
		END
	ELSE
		BEGIN
		    SET @Status = 0;
		END
	
	END TRY
	
	BEGIN CATCH	
	
	SET @Status = 0;
	IF @@TRANCOUNT > 0
	ROLLBACK TRANSACTION 
		
	-- Raise an error with the details of the exception   
	DECLARE @ErrMsg nvarchar(4000), @ErrSeverity int  
	SELECT @ErrMsg = ERROR_MESSAGE(),   
	@ErrSeverity = ERROR_SEVERITY()   
		  
	RAISERROR(@ErrMsg, @ErrSeverity, 1)
	
	END CATCH

END
GO
/****** Object:  StoredProcedure [dbo].[up_usr_Execute_EarlyIssue]    Script Date: 01/18/2015 19:32:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[up_usr_Execute_EarlyIssue]
(	
	        @CustomerID VARCHAR(20),            
            @BookCount int,            
            @AdvanceAmount float,
            @BalanceAmount float,
            @LimitUsed float,
            @StockTable AS UDTStock READONLY,
            @IssueTable AS UDTIssue READONLY,
            @Status bit OUT
          
)
AS
BEGIN
	
	BEGIN TRY
	
	BEGIN TRANSACTION
	
	DECLARE @RowCount AS int
	
	EXEC up_usr_insert_OutStock @StockTable;
	
	EXEC up_usr_insert_Issue @RowCount,@IssueTable;
	
	EXEC up_usr_Update_Customer @CustomerID,@BookCount,@AdvanceAmount,@BalanceAmount,@LimitUsed;
	
	SET @Status = 1;	
	
	COMMIT
	
	END TRY
	
	BEGIN CATCH
	
	SET @Status = 0;
	IF @@TRANCOUNT > 0
	ROLLBACK TRANSACTION 
		
	-- Raise an error with the details of the exception   
	DECLARE @ErrMsg nvarchar(4000), @ErrSeverity int  
	SELECT @ErrMsg = ERROR_MESSAGE(),   
	@ErrSeverity = ERROR_SEVERITY()   
		  
	RAISERROR(@ErrMsg, @ErrSeverity, 1)
	
	END CATCH

END
GO
/****** Object:  StoredProcedure [dbo].[up_usr_Delete_Customer_details]    Script Date: 01/18/2015 19:32:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[up_usr_Delete_Customer_details]
(
	
	
	
	        @CustomerID VARCHAR(20),            
            @Status bit OUT
          
)
AS
BEGIN
	
	BEGIN TRY
	
	BEGIN TRANSACTION
	
	EXEC up_usr_Delete_Customer	 @CustomerID, @Status;
	
	/*****************************************************************	
	Modified by : shankar
	Customer ID datatype is not changed from int to varchar(20) in the below 2 sp's.
	******************************************************************/
	--EXEC up_usr_Delete_Issue_OnCustID @CustomerID, @Status;	
	--EXEC up_usr_Delete_History_OnCustomerID @CustomerID, @Status;
	
	SET @Status = 1;	
	
	COMMIT
	
	END TRY
	
	BEGIN CATCH
	SET @Status = 0;
	
	IF @@TRANCOUNT > 0
	ROLLBACK TRANSACTION 
		
	-- Raise an error with the details of the exception   
	DECLARE @ErrMsg nvarchar(4000), @ErrSeverity int  
	SELECT @ErrMsg = ERROR_MESSAGE(),   
	@ErrSeverity = ERROR_SEVERITY()   
		  
	RAISERROR(@ErrMsg, @ErrSeverity, 1) 	
	
	END CATCH

END
GO
/****** Object:  StoredProcedure [dbo].[up_usr_Execute_Return_Rental]    Script Date: 01/18/2015 19:32:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[up_usr_Execute_Return_Rental]
(           
            @CustomerID VARCHAR(20),
            @Title VARCHAR(100),
            @Author VARCHAR(100),
            @Edition VARCHAR(100),
            @Publisher VARCHAR(100),
            @price float,
            @HistoryUID VarChar(100),
            @BookCount int,
            @AdvanceAmount float,
            @BalanceAmount float, 
            @RefundAmount float, 
            @CheckNumber VarChar(20),         
            @Status bit OUT       
)
AS
BEGIN
	
	BEGIN TRY
	
	BEGIN TRANSACTION
	
	DECLARE @RowCount AS int
	
	EXEC up_usr_Delete_Issue @customerID,@Title,@Author,@Edition,@Publisher,@price,@HistoryUID,@Status;
	
	EXEC up_usr_Update_CustomerDetailsOnReturn @CustomerID,@BookCount,@price,@AdvanceAmount,@BalanceAmount;
	
	EXEC up_usr_Update_Stock @Title,@Author,@Edition,@Publisher,@Price,@BookCount;
	
	EXEC up_usr_Update_History_On_Return @HistoryUID,@CheckNumber,@RefundAmount;
	
	SET @Status = 1;	
	
	COMMIT
	
	END TRY
	
	BEGIN CATCH	
	
	SET @Status = 0;
	IF @@TRANCOUNT > 0
	ROLLBACK TRANSACTION 
		
	-- Raise an error with the details of the exception   
	DECLARE @ErrMsg nvarchar(4000), @ErrSeverity int  
	SELECT @ErrMsg = ERROR_MESSAGE(),   
	@ErrSeverity = ERROR_SEVERITY()   
		  
	RAISERROR(@ErrMsg, @ErrSeverity, 1)
	
	END CATCH

END
GO
/****** Object:  StoredProcedure [dbo].[up_usr_Execute_Return_Other]    Script Date: 01/18/2015 19:32:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[up_usr_Execute_Return_Other]
(           
            @CustomerID VARCHAR(20),
            @Title VARCHAR(100),
            @Author VARCHAR(100),
            @Edition VARCHAR(100),
            @Publisher VARCHAR(100),
            @price float,
            @HistoryUID VarChar(100),
            @BookCount int,
            @AdvanceAmount float,
            @BalanceAmount float,            
            @Status bit OUT
          
)
AS
BEGIN
	
	BEGIN TRY
	
	BEGIN TRANSACTION
	
	DECLARE @RowCount AS int
	
	EXEC up_usr_Delete_Issue @customerID,@Title,@Author,@Edition,@Publisher,@price,@HistoryUID,@Status;
	
	EXEC up_usr_Update_CustomerDetailsOnReturn @CustomerID,@BookCount,@price,@AdvanceAmount,@BalanceAmount;
	
	EXEC up_usr_Update_Limit @CustomerID,@BookCount,@price;
	
	SET @Status = 1;	
	
	COMMIT
	
	END TRY
	
	BEGIN CATCH	
	
	SET @Status = 0;
	
	IF @@TRANCOUNT > 0
	ROLLBACK TRANSACTION 
		
	-- Raise an error with the details of the exception   
	DECLARE @ErrMsg nvarchar(4000), @ErrSeverity int  
	SELECT @ErrMsg = ERROR_MESSAGE(),   
	@ErrSeverity = ERROR_SEVERITY()   
		  
	RAISERROR(@ErrMsg, @ErrSeverity, 1)
	
	END CATCH

END
GO
/****** Object:  StoredProcedure [dbo].[up_usr_Execute_Return]    Script Date: 01/18/2015 19:32:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[up_usr_Execute_Return]
(           
            @CustomerID VARCHAR(20),
            @Title VARCHAR(100),
            @Author VARCHAR(100),
            @Edition VARCHAR(100),
            @Publisher VARCHAR(100),
            @price float,
            @HistoryUID VarChar(100),
            @BookCount int,
            @AmountOut float,            
            @Status bit OUT
          
)
AS
BEGIN
	
	BEGIN TRY
	
	BEGIN TRANSACTION
	
	DECLARE @RowCount AS int
	
	EXEC up_usr_Delete_Issue @customerID,@Title,@Author,@Edition,@Publisher,@price,@HistoryUID,@Status;
	
	EXEC up_usr_Update_Stock @Title,@Author,@Edition,@Publisher,@Price,@BookCount;
	
	EXEC up_usr_Update_Limit @CustomerID,@BookCount,@price;
	
	EXEC up_usr_Update_History_On_Return @HistoryUID,0,@AmountOut;
	
	SET @Status = 1;	
	
	COMMIT
	
	END TRY
	
	BEGIN CATCH
	
	SET @Status = 0;
	
	IF @@TRANCOUNT > 0
	ROLLBACK TRANSACTION 
		
	-- Raise an error with the details of the exception   
	DECLARE @ErrMsg nvarchar(4000), @ErrSeverity int  
	SELECT @ErrMsg = ERROR_MESSAGE(),   
	@ErrSeverity = ERROR_SEVERITY()   
		  
	RAISERROR(@ErrMsg, @ErrSeverity, 1)
	
	END CATCH

END
GO
/****** Object:  StoredProcedure [dbo].[up_usr_Execute_Regular_Issue_FOr_NonRental]    Script Date: 01/18/2015 19:32:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[up_usr_Execute_Regular_Issue_FOr_NonRental]
(           
            @CustomerID VARCHAR(20),
            @Title VARCHAR(100),
            @Author VARCHAR(100),
            @Edition VARCHAR(100),
            @Publisher VARCHAR(100),
            @price float,
            @BookCount int,
            @issueDate DateTime,                       
            @HistoryUID varchar(200),
            @TransactionTable AS UDTTransactionHistory READONLY,
            @IssueTable AS UDTIssue READONLY,            
            @Status bit OUT
          
)
AS
BEGIN
	
	BEGIN TRY
	
	BEGIN TRANSACTION
	
	DECLARE @RowCount AS int
	
	EXEC up_usr_insert_History @HistoryUID,@RowCount,@TransactionTable;
	
	EXEC up_usr_insert_Issue @RowCount,@IssueTable;
	
	EXEC up_usr_Update_StockonIssue @Title,@Author,@Edition,@Publisher,@price,@BookCount;
	
	SET @Status = 1;	
	
	COMMIT
	
	END TRY
	
	BEGIN CATCH
	
	SET @Status = 0;
	IF @@TRANCOUNT > 0
	ROLLBACK TRANSACTION 
		
	-- Raise an error with the details of the exception   
	DECLARE @ErrMsg nvarchar(4000), @ErrSeverity int  
	SELECT @ErrMsg = ERROR_MESSAGE(),   
	@ErrSeverity = ERROR_SEVERITY()   
		  
	RAISERROR(@ErrMsg, @ErrSeverity, 1)
	
	END CATCH

END
GO
/****** Object:  StoredProcedure [dbo].[up_usr_Execute_Regular_Issue]    Script Date: 01/18/2015 19:32:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[up_usr_Execute_Regular_Issue]
(           
            @CustomerID VARCHAR(20),
            @Title VARCHAR(100),
            @Author VARCHAR(100),
            @Edition VARCHAR(100),
            @Publisher VARCHAR(100),
            @price float,
            @BookCount int,
            @issueDate DateTime,
            @AdvanceAmount float,
            @BalanceAmount float,
            @LimitUsed float,
            @HistoryUID varchar(200),
            @TransactionTable AS UDTTransactionHistory READONLY,
            @IssueTable AS UDTIssue READONLY,            
            @Status bit OUT
          
)
AS
BEGIN
	
	BEGIN TRY
	
	BEGIN TRANSACTION
	
	DECLARE @RowCount AS int
	
	EXEC up_usr_insert_History @HistoryUID,@RowCount,@TransactionTable;
	
	EXEC up_usr_insert_Issue @RowCount,@IssueTable;
	
	EXEC up_usr_Update_StockonIssue @Title,@Author,@Edition,@Publisher,@price,@BookCount;
	
	EXEC up_usr_Update_Customer @CustomerID,@BookCount,@AdvanceAmount,@BalanceAmount,@LimitUsed;
	
	SET @Status = 1;	
	
	COMMIT
	
	END TRY
	
	BEGIN CATCH
	
	SET @Status = 0;
	IF @@TRANCOUNT > 0
	ROLLBACK TRANSACTION 
		
	-- Raise an error with the details of the exception   
	DECLARE @ErrMsg nvarchar(4000), @ErrSeverity int  
	SELECT @ErrMsg = ERROR_MESSAGE(),   
	@ErrSeverity = ERROR_SEVERITY()   
		  
	RAISERROR(@ErrMsg, @ErrSeverity, 1)
	
	END CATCH

END
GO
