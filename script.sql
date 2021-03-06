USE [master]
GO
CREATE DATABASE [deneme]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'deneme', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\deneme.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'deneme_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\deneme_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [deneme] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [deneme].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [deneme] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [deneme] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [deneme] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [deneme] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [deneme] SET ARITHABORT OFF 
GO
ALTER DATABASE [deneme] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [deneme] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [deneme] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [deneme] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [deneme] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [deneme] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [deneme] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [deneme] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [deneme] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [deneme] SET  DISABLE_BROKER 
GO
ALTER DATABASE [deneme] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [deneme] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [deneme] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [deneme] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [deneme] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [deneme] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [deneme] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [deneme] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [deneme] SET  MULTI_USER 
GO
ALTER DATABASE [deneme] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [deneme] SET DB_CHAINING OFF 
GO
ALTER DATABASE [deneme] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [deneme] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [deneme] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'deneme', N'ON'
GO
ALTER DATABASE [deneme] SET QUERY_STORE = OFF
GO
USE [deneme]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Doktor](
	[doktorNumara] [nvarchar](15) NOT NULL,
	[doktorAdı] [nvarchar](50) NOT NULL,
	[klinikAdı] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hastane](
	[hastaneKodu] [nvarchar](10) NOT NULL,
	[hastaneAdı] [nvarchar](50) NULL,
	[ılceAdı] [nvarchar](50) NULL,
 CONSTRAINT [PK_Hastane] PRIMARY KEY CLUSTERED 
(
	[hastaneKodu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IL](
	[ılKodları] [nvarchar](3) NOT NULL,
	[ılAdı] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ilac](
	[receteNumarası] [nvarchar](20) NOT NULL,
	[hastaTc] [nvarchar](11) NOT NULL,
	[ilacAdı] [nvarchar](20) NOT NULL,
	[tarih] [nvarchar](10) NULL,
 CONSTRAINT [PK_Ilac] PRIMARY KEY CLUSTERED 
(
	[receteNumarası] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ilce](
	[ılceKodu] [nvarchar](6) NOT NULL,
	[ılAdı] [nvarchar](50) NOT NULL,
	[ılceAdı] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Ilce] PRIMARY KEY CLUSTERED 
(
	[ılceKodu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kisi](
	[kisiNumara] [nvarchar](50) NULL,
	[ad] [nvarchar](20) NULL,
	[soyad] [nvarchar](20) NULL,
	[numara] [nvarchar](11) NULL,
	[eposta] [nvarchar](20) NULL,
	[adres] [nvarchar](50) NULL,
	[cinsiyet] [nvarchar](5) NULL,
	[yas] [nvarchar](3) NULL
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Klinik](
	[klinikNumara] [nvarchar](15) NOT NULL,
	[klinikAdı] [nvarchar](50) NOT NULL,
	[hastaneAdı] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Klinik] PRIMARY KEY CLUSTERED 
(
	[klinikNumara] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Randevular](
	[randevuNumara] [int] IDENTITY(1,1) NOT NULL,
	[hastaneAdı] [nvarchar](50) NULL,
	[klinikAdı] [nvarchar](50) NULL,
	[yerAdı] [nvarchar](50) NULL,
	[doktorAdı] [nvarchar](50) NULL,
	[tarih] [nvarchar](50) NULL,
	[hastaAdı] [nvarchar](50) NULL,
	[hastaSoyadı] [nvarchar](50) NULL,
	[hastaCinsiyet] [nvarchar](50) NULL,
	[hastaDoğumTarihi] [nvarchar](50) NULL,
	[hastaTelefon] [nvarchar](50) NULL,
	[hastaEposta] [nvarchar](50) NULL,
	[hastaTc] [nvarchar](50) NULL,
 CONSTRAINT [PK_Randevular] PRIMARY KEY CLUSTERED 
(
	[randevuNumara] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Uye](
	[kullanıcı_numara] [int] NULL,
	[kullanıcı_adı] [nvarchar](50) NULL,
	[kullanıcı_soyadı] [nvarchar](50) NULL,
	[kullanıcı_sifre] [nvarchar](50) NULL,
	[kullanıcı_tc] [nvarchar](50) NULL,
	[kullanıcı_doğumtarihi] [nvarchar](50) NULL,
	[kullanıcı_doğumyeri] [nvarchar](50) NULL,
	[kullanıcı_eposta] [nvarchar](50) NULL,
	[kullanıcı_anneadı] [nvarchar](50) NULL,
	[kullanıcı_babaadı] [nvarchar](50) NULL,
	[kullanıcı_telefon] [nvarchar](50) NULL,
	[kullanıcı_cinsiyet] [nvarchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Yer](
	[yerNumarası] [nvarchar](15) NOT NULL,
	[yerAdı] [nvarchar](50) NOT NULL,
	[klinikAdı] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Yer_1] PRIMARY KEY CLUSTERED 
(
	[yerNumarası] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Doktor_Secim](
@val nvarchar(max)
)
AS
BEGIN
SELECT doktorAdı FROM Doktor WHERE klinikAdı IN(SELECT klinikAdı FROM Klinik WHERE klinikAdı=@val)
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Hastane_Secim](
@val nvarchar (max)

)
AS
BEGIN
SELECT hastaneAdı FROM Hastane WHERE ılceAdı IN(SELECT ılceAdı FROM Ilce WHERE ılceAdı=@val)
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Hatane_Secim](
@val nvarchar (max)

)
AS
BEGIN
SELECT hastaneAdı FROM Hastane WHERE ılceAdı IN(SELECT ılceAdı FROM Ilce WHERE ılceAdı=@val)
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[IL_SECIM](
 @val nvarchar(MAX)
)
AS
BEGIN
SELECT ılAdı FROM IL WHERE ılKodları IN(SELECT ılKodları FROM IL WHERE ılAdı=@val)
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[IL_SECİM](
 @val nvarchar(MAX)
)
AS
BEGIN
SELECT ılAdı FROM IL WHERE ılKodları IN(SELECT ılAdı FROM IL WHERE ılAdı=@val)
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Il_Secimi](
@val nvarchar(max)
)
AS
BEGIN
SELECT ılAdı FROM IL WHERE ılAdı=@val
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ILCE_SECIM](
@val nvarchar(max)
)
AS
BEGIN
SELECT ılceAdı FROM Ilce WHERE ılAdı IN (SELECT ılAdı FROM IL WHERE ılKodları=@val)
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Ilce_Secımı](
@val nvarchar(max)
)
AS
BEGIN
SELECT ılceAdı FROM Ilce WHERE ılAdı IN (SELECT ılAdı FROM IL WHERE ılAdı=@val)
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Klinik_Secim](
@val nvarchar(max)
)
AS
BEGIN
SELECT klinikadı FROM Klinik WHERE hastaneAdı IN(SELECT hastaneAdı FROM Hastane WHERE hastaneAdı=@val)
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Klinilk_Secim](
@val nvarchar(max)
)
AS
BEGIN
SELECT klinikadı FROM Klinik WHERE hastaneAdı IN(SELECT hastaneAdı FROM Hastane WHERE hastaneAdı=@val)
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Yer_Secim](
@val nvarchar(max)
)
AS
BEGIN
SELECT yerAdı FROM Yer WHERE klinikAdı IN(SELECT klinikAdı FROM Klinik WHERE klinikAdı=@val)
END
GO
USE [master]
GO
ALTER DATABASE [deneme] SET  READ_WRITE 
GO
