/****** Object:  Table [dbo].[UserEvent]    Script Date: 10/21/2021 9:18:17 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UserEvent]') AND type in (N'U'))
DROP TABLE [dbo].[UserEvent]
GO
/****** Object:  Table [dbo].[SupportType]    Script Date: 10/21/2021 9:18:17 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SupportType]') AND type in (N'U'))
DROP TABLE [dbo].[SupportType]
GO
/****** Object:  Table [dbo].[PostType]    Script Date: 10/21/2021 9:18:17 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PostType]') AND type in (N'U'))
DROP TABLE [dbo].[PostType]
GO
/****** Object:  Table [dbo].[Post]    Script Date: 10/21/2021 9:18:17 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Post]') AND type in (N'U'))
DROP TABLE [dbo].[Post]
GO
/****** Object:  Table [dbo].[ParticipantPost]    Script Date: 10/21/2021 9:18:17 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ParticipantPost]') AND type in (N'U'))
DROP TABLE [dbo].[ParticipantPost]
GO
/****** Object:  Table [dbo].[ParticipantEvent]    Script Date: 10/21/2021 9:18:17 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ParticipantEvent]') AND type in (N'U'))
DROP TABLE [dbo].[ParticipantEvent]
GO
/****** Object:  Table [dbo].[ParticipantCommunity]    Script Date: 10/21/2021 9:18:17 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ParticipantCommunity]') AND type in (N'U'))
DROP TABLE [dbo].[ParticipantCommunity]
GO
/****** Object:  Table [dbo].[Participant]    Script Date: 10/21/2021 9:18:17 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Participant]') AND type in (N'U'))
DROP TABLE [dbo].[Participant]
GO
/****** Object:  Table [dbo].[ManagerPost]    Script Date: 10/21/2021 9:18:17 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ManagerPost]') AND type in (N'U'))
DROP TABLE [dbo].[ManagerPost]
GO
/****** Object:  Table [dbo].[ManagerEvent]    Script Date: 10/21/2021 9:18:17 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ManagerEvent]') AND type in (N'U'))
DROP TABLE [dbo].[ManagerEvent]
GO
/****** Object:  Table [dbo].[ManagerCommunity]    Script Date: 10/21/2021 9:18:17 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ManagerCommunity]') AND type in (N'U'))
DROP TABLE [dbo].[ManagerCommunity]
GO
/****** Object:  Table [dbo].[Manager]    Script Date: 10/21/2021 9:18:17 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Manager]') AND type in (N'U'))
DROP TABLE [dbo].[Manager]
GO
/****** Object:  Table [dbo].[Local]    Script Date: 10/21/2021 9:18:17 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Local]') AND type in (N'U'))
DROP TABLE [dbo].[Local]
GO
/****** Object:  Table [dbo].[Event]    Script Date: 10/21/2021 9:18:17 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Event]') AND type in (N'U'))
DROP TABLE [dbo].[Event]
GO
/****** Object:  Table [dbo].[Donor]    Script Date: 10/21/2021 9:18:17 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Donor]') AND type in (N'U'))
DROP TABLE [dbo].[Donor]
GO
/****** Object:  Table [dbo].[CommunityDonate]    Script Date: 10/21/2021 9:18:17 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CommunityDonate]') AND type in (N'U'))
DROP TABLE [dbo].[CommunityDonate]
GO
/****** Object:  Table [dbo].[CharityFund]    Script Date: 10/21/2021 9:18:17 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CharityFund]') AND type in (N'U'))
DROP TABLE [dbo].[CharityFund]
GO
/****** Object:  Table [dbo].[CharityFund]    Script Date: 10/21/2021 9:18:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CharityFund](
	[FundId] [int] IDENTITY(1,1) NOT NULL,
	[FundName] [nvarchar](max) NULL,
	[TotalAmount] [decimal](18, 0) NULL,
	[SupportTypeId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[FundId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CommunityDonate]    Script Date: 10/21/2021 9:18:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CommunityDonate](
	[CommunityId] [int] IDENTITY(1,1) NOT NULL,
	[CommunityName] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[Url] [nvarchar](max) NULL,
	[Slot] [int] NULL,
	[TotalAmount] [decimal](18, 0) NULL,
	[SupportTypeId] [int] NULL,
	[LocalId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[CommunityId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Donor]    Script Date: 10/21/2021 9:18:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Donor](
	[DonorId] [int] IDENTITY(1,1) NOT NULL,
	[Address] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[Phone] [nvarchar](20) NULL,
	[ToTalAmount] [decimal](18, 0) NULL,
	[Status] [int] NULL,
	[SupportTypeId] [int] NULL,
	[LocalId] [int] NULL,
	[DonorName] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[DonorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Event]    Script Date: 10/21/2021 9:18:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Event](
	[EventId] [int] IDENTITY(1,1) NOT NULL,
	[EventName] [nvarchar](max) NULL,
	[FromDate] [datetime] NULL,
	[ToDate] [datetime] NULL,
	[Content] [nvarchar](max) NULL,
	[Slot] [int] NULL,
	[DesiredAmount] [decimal](18, 0) NULL,
	[DonateAmount] [decimal](18, 0) NULL,
	[SupportTypeId] [int] NULL,
	[LocalId] [int] NULL,
	[Status] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[EventId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Local]    Script Date: 10/21/2021 9:18:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Local](
	[LocalId] [int] IDENTITY(1,1) NOT NULL,
	[LocalCode] [nvarchar](max) NULL,
	[LocalName] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[LocalId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Manager]    Script Date: 10/21/2021 9:18:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Manager](
	[ManagerId] [int] IDENTITY(1,1) NOT NULL,
	[ManagerName] [nvarchar](max) NULL,
	[Address] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[Phone] [nvarchar](max) NULL,
	[Gender] [bit] NULL,
	[Birth] [date] NULL,
	[UserId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ManagerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ManagerCommunity]    Script Date: 10/21/2021 9:18:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ManagerCommunity](
	[ManagerId] [int] NULL,
	[CommunityId] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ManagerEvent]    Script Date: 10/21/2021 9:18:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ManagerEvent](
	[ManagerId] [int] NULL,
	[EventId] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ManagerPost]    Script Date: 10/21/2021 9:18:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ManagerPost](
	[ManagerId] [int] NULL,
	[PostId] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Participant]    Script Date: 10/21/2021 9:18:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Participant](
	[ParticipantId] [int] IDENTITY(1,1) NOT NULL,
	[ParticipantName] [nvarchar](max) NULL,
	[Address] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[Phone] [nvarchar](max) NULL,
	[Gender] [bit] NULL,
	[DonateAmount] [decimal](18, 0) NULL,
	[Birth] [date] NULL,
	[UserId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ParticipantId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ParticipantCommunity]    Script Date: 10/21/2021 9:18:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ParticipantCommunity](
	[ParticipantId] [int] NULL,
	[CommunityId] [int] NULL,
	[Money] [decimal](18, 0) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ParticipantEvent]    Script Date: 10/21/2021 9:18:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ParticipantEvent](
	[ParticipantId] [int] NULL,
	[EventId] [int] NULL,
	[Money] [decimal](18, 0) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ParticipantPost]    Script Date: 10/21/2021 9:18:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ParticipantPost](
	[ParticipantId] [int] NULL,
	[PostId] [int] NULL,
	[Money] [decimal](18, 0) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Post]    Script Date: 10/21/2021 9:18:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Post](
	[PostId] [int] IDENTITY(1,1) NOT NULL,
	[PostName] [nvarchar](max) NULL,
	[Slot] [int] NULL,
	[Content] [nvarchar](max) NULL,
	[Image] [nvarchar](max) NULL,
	[Status] [int] NULL,
	[TotalAmount] [decimal](18, 0) NULL,
	[SupportTypeId] [int] NULL,
	[PostTypeId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[PostId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PostType]    Script Date: 10/21/2021 9:18:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PostType](
	[PostTypeId] [int] IDENTITY(1,1) NOT NULL,
	[PostTypeName] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[PostTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SupportType]    Script Date: 10/21/2021 9:18:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SupportType](
	[SupportTypeId] [int] IDENTITY(1,1) NOT NULL,
	[SupportTypeName] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[SupportTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserEvent]    Script Date: 10/21/2021 9:18:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserEvent](
	[UserEventId] [int] IDENTITY(1,1) NOT NULL,
	[TypeEvent] [int] NULL,
	[Perform] [int] NULL,
	[Content] [nvarchar](max) NULL,
	[Moment] [datetime] NULL,
	[IPAddress] [nvarchar](max) NULL,
	[UserName] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[UserEventId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
