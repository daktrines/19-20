USE [master]
GO
/****** Object:  Database [Factory]    Script Date: 03.05.2022 18:38:32 ******/
CREATE DATABASE [Factory]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Factory', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Factory.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Factory_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Factory_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Factory] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Factory].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Factory] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Factory] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Factory] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Factory] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Factory] SET ARITHABORT OFF 
GO
ALTER DATABASE [Factory] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Factory] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Factory] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Factory] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Factory] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Factory] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Factory] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Factory] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Factory] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Factory] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Factory] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Factory] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Factory] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Factory] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Factory] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Factory] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Factory] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Factory] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Factory] SET  MULTI_USER 
GO
ALTER DATABASE [Factory] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Factory] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Factory] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Factory] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Factory] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Factory] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Factory] SET QUERY_STORE = OFF
GO
USE [Factory]
GO
/****** Object:  Table [dbo].[Factory]    Script Date: 03.05.2022 18:38:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Factory](
	[Number] [int] NOT NULL,
	[SurnameCollector] [nvarchar](50) NOT NULL,
	[NameCollector] [nvarchar](50) NOT NULL,
	[PatronymicCollector] [nvarchar](50) NULL,
	[CountOfManufacturedDetailsMonday] [int] NULL,
	[CountOfManufacturedDetailsTuesday] [int] NULL,
	[CountOfManufacturedDetailsWednesday] [int] NULL,
	[CountOfManufacturedDetailsThursday] [int] NULL,
	[CountOfManufacturedDetailsFriday] [int] NULL,
	[CountOfManufacturedDetailsSaturday] [int] NULL,
	[CountOfManufacturedDetailsSunday] [int] NULL,
	[NameFactory] [nvarchar](50) NOT NULL,
	[TypeDetails] [nvarchar](50) NOT NULL,
	[PriceDetails] [money] NOT NULL,
 CONSTRAINT [PK_Factory] PRIMARY KEY CLUSTERED 
(
	[Number] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Password]    Script Date: 03.05.2022 18:38:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Password](
	[Код] [int] NOT NULL,
	[Логин] [nvarchar](50) NOT NULL,
	[Пароль] [nvarchar](50) NOT NULL,
	[Доступ] [nvarchar](50) NOT NULL,
	[Почта] [nvarchar](50) NULL,
	[Фамилия] [nvarchar](50) NULL,
	[Имя] [nvarchar](50) NULL,
 CONSTRAINT [PK_Password] PRIMARY KEY CLUSTERED 
(
	[Код] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Factory] ([Number], [SurnameCollector], [NameCollector], [PatronymicCollector], [CountOfManufacturedDetailsMonday], [CountOfManufacturedDetailsTuesday], [CountOfManufacturedDetailsWednesday], [CountOfManufacturedDetailsThursday], [CountOfManufacturedDetailsFriday], [CountOfManufacturedDetailsSaturday], [CountOfManufacturedDetailsSunday], [NameFactory], [TypeDetails], [PriceDetails]) VALUES (1, N'Фисенко', N'Иван', N'Иванович', 120, 78, 450, 256, 562, 652, 785, N'Толгхолл', N'Холодильник', 30000.0000)
INSERT [dbo].[Factory] ([Number], [SurnameCollector], [NameCollector], [PatronymicCollector], [CountOfManufacturedDetailsMonday], [CountOfManufacturedDetailsTuesday], [CountOfManufacturedDetailsWednesday], [CountOfManufacturedDetailsThursday], [CountOfManufacturedDetailsFriday], [CountOfManufacturedDetailsSaturday], [CountOfManufacturedDetailsSunday], [NameFactory], [TypeDetails], [PriceDetails]) VALUES (2, N'Калион', N'Екатерина', N'Максимовна', 41, 20, 32, 63, 96, 52, 41, N'Тортолетка', N'Торт', 800.0000)
INSERT [dbo].[Factory] ([Number], [SurnameCollector], [NameCollector], [PatronymicCollector], [CountOfManufacturedDetailsMonday], [CountOfManufacturedDetailsTuesday], [CountOfManufacturedDetailsWednesday], [CountOfManufacturedDetailsThursday], [CountOfManufacturedDetailsFriday], [CountOfManufacturedDetailsSaturday], [CountOfManufacturedDetailsSunday], [NameFactory], [TypeDetails], [PriceDetails]) VALUES (3, N'Митрохина', N'Ксения', N'Михайловна', 85, 69, 199, 786, 586, 547, 578, N'ТОПОружие', N'Оружие', 27000.0000)
INSERT [dbo].[Factory] ([Number], [SurnameCollector], [NameCollector], [PatronymicCollector], [CountOfManufacturedDetailsMonday], [CountOfManufacturedDetailsTuesday], [CountOfManufacturedDetailsWednesday], [CountOfManufacturedDetailsThursday], [CountOfManufacturedDetailsFriday], [CountOfManufacturedDetailsSaturday], [CountOfManufacturedDetailsSunday], [NameFactory], [TypeDetails], [PriceDetails]) VALUES (4, N'Баева', N'Ирина', N'Александровна', 789, 1489, 6985, 7856, 5745, 55, 5556, N'Айфонорай', N'Айфон', 90000.0000)
INSERT [dbo].[Factory] ([Number], [SurnameCollector], [NameCollector], [PatronymicCollector], [CountOfManufacturedDetailsMonday], [CountOfManufacturedDetailsTuesday], [CountOfManufacturedDetailsWednesday], [CountOfManufacturedDetailsThursday], [CountOfManufacturedDetailsFriday], [CountOfManufacturedDetailsSaturday], [CountOfManufacturedDetailsSunday], [NameFactory], [TypeDetails], [PriceDetails]) VALUES (5, N'Дмитриенко', N'Иван', N'Алекандрович', 89, 69, 96, 36, 85, 36, 56, N'Швея', N'Сумка', 12000.0000)
INSERT [dbo].[Factory] ([Number], [SurnameCollector], [NameCollector], [PatronymicCollector], [CountOfManufacturedDetailsMonday], [CountOfManufacturedDetailsTuesday], [CountOfManufacturedDetailsWednesday], [CountOfManufacturedDetailsThursday], [CountOfManufacturedDetailsFriday], [CountOfManufacturedDetailsSaturday], [CountOfManufacturedDetailsSunday], [NameFactory], [TypeDetails], [PriceDetails]) VALUES (6, N'Мунько', N'Давид', N'Александрович', 69, 96, 89, 58, 78, 98, 98, N'Куртки Для Всей Семьи', N'Куртка', 8000.0000)
INSERT [dbo].[Factory] ([Number], [SurnameCollector], [NameCollector], [PatronymicCollector], [CountOfManufacturedDetailsMonday], [CountOfManufacturedDetailsTuesday], [CountOfManufacturedDetailsWednesday], [CountOfManufacturedDetailsThursday], [CountOfManufacturedDetailsFriday], [CountOfManufacturedDetailsSaturday], [CountOfManufacturedDetailsSunday], [NameFactory], [TypeDetails], [PriceDetails]) VALUES (7, N'Гудилин', N'Петр', N'Иванович', 96, 36, 56, 125, 145, 78, 96, N'ФлешкаМод', N'Флешка', 1000.0000)
INSERT [dbo].[Factory] ([Number], [SurnameCollector], [NameCollector], [PatronymicCollector], [CountOfManufacturedDetailsMonday], [CountOfManufacturedDetailsTuesday], [CountOfManufacturedDetailsWednesday], [CountOfManufacturedDetailsThursday], [CountOfManufacturedDetailsFriday], [CountOfManufacturedDetailsSaturday], [CountOfManufacturedDetailsSunday], [NameFactory], [TypeDetails], [PriceDetails]) VALUES (8, N'Рудкова', N'Анастасия', N'Максимовна', 785, 456, 365, 985, 256, 254, 365, N'Парик Всем', N'Парик', 3000.0000)
INSERT [dbo].[Factory] ([Number], [SurnameCollector], [NameCollector], [PatronymicCollector], [CountOfManufacturedDetailsMonday], [CountOfManufacturedDetailsTuesday], [CountOfManufacturedDetailsWednesday], [CountOfManufacturedDetailsThursday], [CountOfManufacturedDetailsFriday], [CountOfManufacturedDetailsSaturday], [CountOfManufacturedDetailsSunday], [NameFactory], [TypeDetails], [PriceDetails]) VALUES (9, N'Ярычкин', N'Алексей', N'Петрович', 56, 25, 145, 200, 201, 203, 230, N'Клава07', N'Клавиатура', 2000.0000)
INSERT [dbo].[Factory] ([Number], [SurnameCollector], [NameCollector], [PatronymicCollector], [CountOfManufacturedDetailsMonday], [CountOfManufacturedDetailsTuesday], [CountOfManufacturedDetailsWednesday], [CountOfManufacturedDetailsThursday], [CountOfManufacturedDetailsFriday], [CountOfManufacturedDetailsSaturday], [CountOfManufacturedDetailsSunday], [NameFactory], [TypeDetails], [PriceDetails]) VALUES (10, N'Никулин', N'Иван', N'Андреевич', 59, 36, 45, 65, 85, 85, 78, N'НоутТоут', N'Ноутбуки', 80000.0000)
INSERT [dbo].[Factory] ([Number], [SurnameCollector], [NameCollector], [PatronymicCollector], [CountOfManufacturedDetailsMonday], [CountOfManufacturedDetailsTuesday], [CountOfManufacturedDetailsWednesday], [CountOfManufacturedDetailsThursday], [CountOfManufacturedDetailsFriday], [CountOfManufacturedDetailsSaturday], [CountOfManufacturedDetailsSunday], [NameFactory], [TypeDetails], [PriceDetails]) VALUES (11, N'Борзак', N'Кирилл', N'Денисович', 96, 854, 756, 365, 452, 635, 145, N'НаушникиОпт', N'Наушники', 3500.0000)
INSERT [dbo].[Factory] ([Number], [SurnameCollector], [NameCollector], [PatronymicCollector], [CountOfManufacturedDetailsMonday], [CountOfManufacturedDetailsTuesday], [CountOfManufacturedDetailsWednesday], [CountOfManufacturedDetailsThursday], [CountOfManufacturedDetailsFriday], [CountOfManufacturedDetailsSaturday], [CountOfManufacturedDetailsSunday], [NameFactory], [TypeDetails], [PriceDetails]) VALUES (12, N'Чумаченко', N'Яна', N'Олеговна', 789, 698, 365, 256, 452, 632, 652, N'Модная Семья', N'Джинсы', 5000.0000)
INSERT [dbo].[Factory] ([Number], [SurnameCollector], [NameCollector], [PatronymicCollector], [CountOfManufacturedDetailsMonday], [CountOfManufacturedDetailsTuesday], [CountOfManufacturedDetailsWednesday], [CountOfManufacturedDetailsThursday], [CountOfManufacturedDetailsFriday], [CountOfManufacturedDetailsSaturday], [CountOfManufacturedDetailsSunday], [NameFactory], [TypeDetails], [PriceDetails]) VALUES (13, N'Иванов', N'Иван', N'Иванович', 587, 652, 123, 145, 632, 589, 623, N'Кроссы Нов', N'Кроссовки', 12000.0000)
INSERT [dbo].[Factory] ([Number], [SurnameCollector], [NameCollector], [PatronymicCollector], [CountOfManufacturedDetailsMonday], [CountOfManufacturedDetailsTuesday], [CountOfManufacturedDetailsWednesday], [CountOfManufacturedDetailsThursday], [CountOfManufacturedDetailsFriday], [CountOfManufacturedDetailsSaturday], [CountOfManufacturedDetailsSunday], [NameFactory], [TypeDetails], [PriceDetails]) VALUES (14, N'Никон', N'Федо', N'Иванович', 54, 54, 85, 963, 785, 698, 685, N'ТетрадиВсем', N'Тетради', 12.0000)
INSERT [dbo].[Factory] ([Number], [SurnameCollector], [NameCollector], [PatronymicCollector], [CountOfManufacturedDetailsMonday], [CountOfManufacturedDetailsTuesday], [CountOfManufacturedDetailsWednesday], [CountOfManufacturedDetailsThursday], [CountOfManufacturedDetailsFriday], [CountOfManufacturedDetailsSaturday], [CountOfManufacturedDetailsSunday], [NameFactory], [TypeDetails], [PriceDetails]) VALUES (15, N'Прунич', N'Ирина', N'Михайловна', 78, 65, 32, 56, 45, 232, 14, N'OverКольца', N'Кольцо', 12000.0000)
GO
INSERT [dbo].[Password] ([Код], [Логин], [Пароль], [Доступ], [Почта], [Фамилия], [Имя]) VALUES (1, N'daktrines', N'1234', N'Администратор', NULL, N'Калион', N'Екатерина')
INSERT [dbo].[Password] ([Код], [Логин], [Пароль], [Доступ], [Почта], [Фамилия], [Имя]) VALUES (2, N'ИСП-31', N'1234567890', N'Пользователь', NULL, N'ИСП-31', NULL)
INSERT [dbo].[Password] ([Код], [Логин], [Пароль], [Доступ], [Почта], [Фамилия], [Имя]) VALUES (3, N'sa', N'1234', N'Пользователь', NULL, N'sa', NULL)
INSERT [dbo].[Password] ([Код], [Логин], [Пароль], [Доступ], [Почта], [Фамилия], [Имя]) VALUES (4, N'1', N'1', N'Администратор', NULL, N'Калион', N'Екатерина')
GO
USE [master]
GO
ALTER DATABASE [Factory] SET  READ_WRITE 
GO
