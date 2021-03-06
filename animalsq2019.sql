USE [animal_db]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 10/22/2019 1:31:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 10/22/2019 1:31:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 10/22/2019 1:31:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 10/22/2019 1:31:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 10/22/2019 1:31:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](128) NOT NULL,
	[ProviderKey] [nvarchar](128) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 10/22/2019 1:31:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 10/22/2019 1:31:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 10/22/2019 1:31:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](128) NOT NULL,
	[Name] [nvarchar](128) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[dbug_ai]    Script Date: 10/22/2019 1:31:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dbug_ai](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[earTagId] [nvarchar](max) NULL,
	[semenBatchNo] [nvarchar](max) NULL,
	[bullId] [nvarchar](max) NULL,
	[semenDoseWasted] [nvarchar](max) NULL,
	[inSemnatorId] [nvarchar](max) NULL,
	[amounReceived] [nvarchar](max) NULL,
	[recepitNo] [nvarchar](max) NULL,
	[inSeminationPatch] [nvarchar](max) NULL,
	[previousInseminationDate] [datetime2](7) NOT NULL,
	[locationNo] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbug_ai] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[dbug_animal]    Script Date: 10/22/2019 1:31:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dbug_animal](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[earTagNo] [nvarchar](max) NULL,
	[weight] [nvarchar](max) NULL,
	[breedId] [int] NULL,
	[age] [nvarchar](max) NULL,
	[dob] [nvarchar](max) NULL,
	[sireId] [int] NOT NULL,
	[damId] [int] NOT NULL,
	[noOfCalving] [nvarchar](max) NULL,
	[lastCalvingDate] [nvarchar](max) NULL,
	[pregnencyStatus] [bit] NOT NULL,
	[pregnencyDuration] [nvarchar](max) NULL,
	[milkingStatus] [bit] NOT NULL,
	[createdAt] [nvarchar](max) NULL,
	[updatedBy] [nvarchar](max) NULL,
	[ownerId] [int] NULL,
	[keeperId] [int] NULL,
	[farmId] [int] NULL,
	[gender] [nvarchar](max) NULL,
	[declaredBy] [nvarchar](max) NULL,
	[declaredDate] [datetime2](7) NOT NULL,
	[speciesId] [int] NULL,
	[earTagId] [int] NOT NULL,
	[ImageName] [nvarchar](max) NULL,
	[latitude] [nvarchar](max) NULL,
	[longitude] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbug_animal] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[dbug_animalOwner]    Script Date: 10/22/2019 1:31:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dbug_animalOwner](
	[AnimalId] [int] NOT NULL,
	[OwnerId] [int] NOT NULL,
 CONSTRAINT [PK_dbug_animalOwner] PRIMARY KEY CLUSTERED 
(
	[AnimalId] ASC,
	[OwnerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[dbug_animalSelection]    Script Date: 10/22/2019 1:31:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dbug_animalSelection](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[animalId] [nvarchar](max) NULL,
	[ownerId] [nvarchar](max) NULL,
	[farmId] [nvarchar](max) NULL,
	[selectionDate] [datetime2](7) NOT NULL,
	[shortNotes] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbug_animalSelection] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[dbug_breedAnimal]    Script Date: 10/22/2019 1:31:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dbug_breedAnimal](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[breedNameShort] [nvarchar](max) NULL,
	[breedNamelong] [nvarchar](max) NULL,
	[shortDetail] [nvarchar](max) NULL,
	[originFrom] [nvarchar](max) NULL,
	[registeredBy] [nvarchar](max) NULL,
	[updatedBy] [nvarchar](max) NULL,
	[registeredDate] [datetime2](7) NOT NULL,
	[speciesId] [int] NULL,
 CONSTRAINT [PK_dbug_breedAnimal] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[dbug_calfReg]    Script Date: 10/22/2019 1:31:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dbug_calfReg](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[earTag] [nvarchar](max) NULL,
	[gender] [nvarchar](max) NULL,
	[weight] [nvarchar](max) NULL,
	[geneticDefect] [nvarchar](max) NULL,
	[organizationalId] [nvarchar](max) NULL,
	[ownerId] [nvarchar](max) NULL,
	[keeperId] [nvarchar](max) NULL,
	[dob] [datetime2](7) NOT NULL,
	[shortNotes] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbug_calfReg] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[dbug_calving]    Script Date: 10/22/2019 1:31:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dbug_calving](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[earTagNo] [nvarchar](max) NULL,
	[serviceProviderId] [nvarchar](max) NULL,
	[calvingDate] [datetime2](7) NOT NULL,
	[calvingType] [nvarchar](max) NULL,
	[calvingCase] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbug_calving] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[dbug_diseases]    Script Date: 10/22/2019 1:31:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dbug_diseases](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[diseasesNameEng] [nvarchar](max) NULL,
	[diseasesNameNep] [nvarchar](max) NULL,
	[symptom] [nvarchar](max) NULL,
	[shortNote] [nvarchar](max) NULL,
	[AnimalRegistrationid] [int] NULL,
 CONSTRAINT [PK_dbug_diseases] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[dbug_farm]    Script Date: 10/22/2019 1:31:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dbug_farm](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[orgtanizationName] [nvarchar](max) NULL,
	[shortDetail] [nvarchar](max) NULL,
	[dateOfRegistration] [nvarchar](max) NULL,
	[regCertification] [nvarchar](max) NULL,
	[mobile1] [nvarchar](max) NULL,
	[mobile] [nvarchar](max) NULL,
	[email] [nvarchar](max) NULL,
	[url] [nvarchar](max) NULL,
	[address] [nvarchar](max) NULL,
	[municipility] [nvarchar](max) NULL,
	[ward] [nvarchar](max) NULL,
	[longitude] [nvarchar](max) NULL,
	[latitude] [nvarchar](max) NULL,
	[farmType] [nvarchar](max) NULL,
	[land] [nvarchar](max) NULL,
	[area] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbug_farm] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[dbug_FeedFooder]    Script Date: 10/22/2019 1:31:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dbug_FeedFooder](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[fooderNameNep] [nvarchar](max) NULL,
	[fooderNameEng] [nvarchar](max) NULL,
	[address] [nvarchar](max) NULL,
	[municipility] [nvarchar](max) NULL,
	[district] [nvarchar](max) NULL,
	[state] [nvarchar](max) NULL,
	[shortNote] [nvarchar](max) NULL,
	[cultivation] [nvarchar](max) NULL,
	[seedingMethod] [nvarchar](max) NULL,
	[seedHarvestingStorage] [nvarchar](max) NULL,
	[grassProduct] [nvarchar](max) NULL,
	[dm] [nvarchar](max) NULL,
	[cp] [nvarchar](max) NULL,
	[tdn] [nvarchar](max) NULL,
	[ndf] [nvarchar](max) NULL,
	[c] [nvarchar](max) NULL,
	[p] [nvarchar](max) NULL,
	[df] [nvarchar](max) NULL,
	[adl] [nvarchar](max) NULL,
	[tanni] [nvarchar](max) NULL,
	[nitrateScore] [nvarchar](max) NULL,
	[remarks] [nvarchar](max) NULL,
	[price] [nvarchar](max) NULL,
	[category] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbug_FeedFooder] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[dbug_GeneralNutration]    Script Date: 10/22/2019 1:31:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dbug_GeneralNutration](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[animalSpecies] [nvarchar](max) NULL,
	[weight] [nvarchar](max) NULL,
	[snf] [nvarchar](max) NULL,
	[dm] [nvarchar](max) NULL,
	[dcp] [nvarchar](max) NULL,
	[tdn] [nvarchar](max) NULL,
	[ndf] [nvarchar](max) NULL,
	[c] [nvarchar](max) NULL,
	[p] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbug_GeneralNutration] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[dbug_growthMonitoring]    Script Date: 10/22/2019 1:31:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dbug_growthMonitoring](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[earTagNo] [nvarchar](max) NULL,
	[length] [nvarchar](max) NULL,
	[girth] [nvarchar](max) NULL,
	[weight] [nvarchar](max) NULL,
	[shortNote] [nvarchar](max) NULL,
	[monitoredBy] [nvarchar](max) NULL,
	[animalRegistrationid] [int] NULL,
 CONSTRAINT [PK_dbug_growthMonitoring] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[dbug_healthCheckUp]    Script Date: 10/22/2019 1:31:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dbug_healthCheckUp](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[earTagNo] [nvarchar](max) NULL,
	[diseasesId] [int] NULL,
	[serviceProviderId] [int] NULL,
	[sampleTakenDate] [datetime2](7) NOT NULL,
	[sampleBoxNo] [nvarchar](max) NULL,
	[laboratoryId] [int] NULL,
	[charge] [nvarchar](max) NULL,
	[receiptNo] [nvarchar](max) NULL,
	[anlyzeReport] [nvarchar](max) NULL,
	[reportExpDate] [datetime2](7) NOT NULL,
	[animalRegistrationid] [int] NULL,
 CONSTRAINT [PK_dbug_healthCheckUp] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[dbug_milkBaseNutrition]    Script Date: 10/22/2019 1:31:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dbug_milkBaseNutrition](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[fatPercentage] [nvarchar](max) NULL,
	[snf] [nvarchar](max) NULL,
	[dp] [nvarchar](max) NULL,
	[cp] [nvarchar](max) NULL,
	[tdn] [nvarchar](max) NULL,
	[ndf] [nvarchar](max) NULL,
	[c] [nvarchar](max) NULL,
	[p] [nvarchar](max) NULL,
	[dm] [nvarchar](max) NULL,
	[weight] [nvarchar](max) NULL,
	[SpeciesId] [int] NULL,
	[milkVolumn] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbug_milkBaseNutrition] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[dbug_milkRecord]    Script Date: 10/22/2019 1:31:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dbug_milkRecord](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[earTagNumber] [nvarchar](max) NULL,
	[milkingStatus] [nvarchar](max) NULL,
	[recordingPeriod] [nvarchar](max) NULL,
	[recordingDate] [datetime2](7) NOT NULL,
	[milkVolume] [nvarchar](max) NULL,
	[milkSampleBoxNo] [nvarchar](max) NULL,
	[labId] [int] NULL,
	[testingCharge] [nvarchar](max) NULL,
	[receiptNo] [nvarchar](max) NULL,
	[genericProblem] [nvarchar](max) NULL,
	[vacination] [nvarchar](max) NULL,
	[shortNote] [nvarchar](max) NULL,
	[animalRegistrationid] [int] NULL,
	[fatPercentage] [nvarchar](max) NULL,
	[snf] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbug_milkRecord] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[dbug_ownerKeeper]    Script Date: 10/22/2019 1:31:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dbug_ownerKeeper](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[category] [nvarchar](max) NULL,
	[fullName] [nvarchar](max) NULL,
	[occupation] [nvarchar](max) NULL,
	[address] [nvarchar](max) NULL,
	[municipililty] [nvarchar](max) NULL,
	[wardNo] [nvarchar](max) NULL,
	[state] [nvarchar](max) NULL,
	[latitude] [nvarchar](max) NULL,
	[logitude] [nvarchar](max) NULL,
	[dob] [nvarchar](max) NULL,
	[academicQualification] [nvarchar](max) NULL,
	[finantanceStatus] [nvarchar](max) NULL,
	[mobileNumber] [nvarchar](max) NULL,
	[otherNumber] [nvarchar](max) NULL,
	[email] [nvarchar](max) NULL,
	[url] [nvarchar](max) NULL,
	[farmid] [int] NULL,
 CONSTRAINT [PK_dbug_ownerKeeper] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[dbug_pregnancyBaseNutrition]    Script Date: 10/22/2019 1:31:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dbug_pregnancyBaseNutrition](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[speciesId] [int] NULL,
	[breed] [nvarchar](max) NULL,
	[weight] [nvarchar](max) NULL,
	[PregrenencyType] [nvarchar](max) NULL,
	[ageOfAnimal] [nvarchar](max) NULL,
	[fatPercentage] [nvarchar](max) NULL,
	[snf] [nvarchar](max) NULL,
	[dm] [nvarchar](max) NULL,
	[cp] [nvarchar](max) NULL,
	[tdn] [nvarchar](max) NULL,
	[ndf] [nvarchar](max) NULL,
	[c] [nvarchar](max) NULL,
	[p] [nvarchar](max) NULL,
	[milkVolumn] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbug_pregnancyBaseNutrition] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[dbug_pregnancyDiagnosis]    Script Date: 10/22/2019 1:31:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dbug_pregnancyDiagnosis](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[earTagId] [nvarchar](max) NULL,
	[serviceProviderId] [nvarchar](max) NULL,
	[naturalService] [nvarchar](max) NULL,
	[otherServices] [nvarchar](max) NULL,
	[serviceName] [nvarchar](max) NULL,
	[diagnosisDate] [datetime2](7) NOT NULL,
	[result] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbug_pregnancyDiagnosis] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[dbug_pregnancyTermination]    Script Date: 10/22/2019 1:31:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dbug_pregnancyTermination](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[earTagNo] [nvarchar](max) NULL,
	[serviceProvidedId] [nvarchar](max) NULL,
	[terminationDate] [datetime2](7) NOT NULL,
	[terminationType] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbug_pregnancyTermination] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[dbug_registerServiceProvider]    Script Date: 10/22/2019 1:31:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dbug_registerServiceProvider](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[fullName] [nvarchar](max) NULL,
	[address] [nvarchar](max) NULL,
	[professionType] [nvarchar](max) NULL,
	[mub] [nvarchar](max) NULL,
	[wardNo] [nvarchar](max) NULL,
	[state] [nvarchar](max) NULL,
	[provenDocument] [nvarchar](max) NULL,
	[academicQualification] [nvarchar](max) NULL,
	[certificate] [nvarchar](max) NULL,
	[license] [nvarchar](max) NULL,
	[phone1] [nvarchar](max) NULL,
	[phone2] [nvarchar](max) NULL,
	[email] [nvarchar](max) NULL,
	[idCardNo] [nvarchar](max) NULL,
	[Aiid] [int] NULL,
	[PregnencyDiagnosisid] [int] NULL,
	[Calvingid] [int] NULL,
	[PregnencyTerminationid] [int] NULL,
 CONSTRAINT [PK_dbug_registerServiceProvider] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[dbug_responsibleCollectorRegister]    Script Date: 10/22/2019 1:31:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dbug_responsibleCollectorRegister](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[collectionCenterOrganizationId] [nvarchar](max) NULL,
	[fullName] [nvarchar](max) NULL,
	[phone1] [nvarchar](max) NULL,
	[phone2] [nvarchar](max) NULL,
	[email] [nvarchar](max) NULL,
	[address] [nvarchar](max) NULL,
	[ward] [nvarchar](max) NULL,
	[mun] [nvarchar](max) NULL,
	[state] [nvarchar](max) NULL,
	[academicQualification] [nvarchar](max) NULL,
	[document] [nvarchar](max) NULL,
	[licenseNo] [nvarchar](max) NULL,
	[licenseImg] [nvarchar](max) NULL,
	[citizenImg] [nvarchar](max) NULL,
	[SemenCollectionid] [int] NULL,
 CONSTRAINT [PK_dbug_responsibleCollectorRegister] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[dbug_semenCollection]    Script Date: 10/22/2019 1:31:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dbug_semenCollection](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[collectionCenterId] [nvarchar](max) NULL,
	[bullId] [nvarchar](max) NULL,
	[batchNo] [nvarchar](max) NULL,
	[collectionDate] [datetime2](7) NOT NULL,
	[shortNote] [nvarchar](max) NULL,
	[responsibleCollectorId] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbug_semenCollection] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[dbug_semenCollectionCenter]    Script Date: 10/22/2019 1:31:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dbug_semenCollectionCenter](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[collectionCenterName] [nvarchar](max) NULL,
	[registerNo] [nvarchar](max) NULL,
	[address] [nvarchar](max) NULL,
	[mun] [nvarchar](max) NULL,
	[ward] [nvarchar](max) NULL,
	[state] [nvarchar](max) NULL,
	[SemenCollectionid] [int] NULL,
 CONSTRAINT [PK_dbug_semenCollectionCenter] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[dbug_Species]    Script Date: 10/22/2019 1:31:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dbug_Species](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[speciesName] [nvarchar](max) NULL,
	[originFrom] [nvarchar](max) NULL,
	[shortNotes] [nvarchar](max) NULL,
	[Speciesid] [int] NULL,
 CONSTRAINT [PK_dbug_Species] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[dbug_vaccination]    Script Date: 10/22/2019 1:31:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dbug_vaccination](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[vaccinName] [nvarchar](max) NULL,
	[vaccinTypeId] [int] NULL,
	[vaccinationSubTypeId] [int] NULL,
	[vaccinForm] [nvarchar](max) NULL,
	[manufacturedBy] [nvarchar](max) NULL,
	[vaccinationTypeid] [int] NULL,
 CONSTRAINT [PK_dbug_vaccination] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[dbug_vaccinationAnimal]    Script Date: 10/22/2019 1:31:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dbug_vaccinationAnimal](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[earTagNo] [nvarchar](max) NULL,
	[serviceProviderId] [int] NOT NULL,
	[vaccinId] [int] NOT NULL,
	[vaccinationid] [int] NULL,
	[diseasesId] [int] NOT NULL,
	[vaccinationDate] [datetime2](7) NOT NULL,
	[dosage] [nvarchar](max) NULL,
	[batchNo] [nvarchar](max) NULL,
	[charge] [nvarchar](max) NULL,
	[receiptNo] [nvarchar](max) NULL,
	[animalId] [int] NOT NULL,
	[animalRegistrationid] [int] NULL,
 CONSTRAINT [PK_dbug_vaccinationAnimal] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[dbug_vaccinationSubType]    Script Date: 10/22/2019 1:31:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dbug_vaccinationSubType](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[SubTypeName] [nvarchar](max) NULL,
	[VaccinationTypeId] [int] NOT NULL,
 CONSTRAINT [PK_dbug_vaccinationSubType] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[dbug_vaccinationType]    Script Date: 10/22/2019 1:31:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dbug_vaccinationType](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[vaccinationName] [nvarchar](max) NULL,
	[shortNote] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbug_vaccinationType] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[EarTags]    Script Date: 10/22/2019 1:31:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EarTags](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[earTagNo] [bigint] NOT NULL,
	[earTagNoStr] [nvarchar](max) NULL,
 CONSTRAINT [PK_EarTags] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[institutionRegForServices]    Script Date: 10/22/2019 1:31:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[institutionRegForServices](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[serviceType] [nvarchar](max) NULL,
	[institutionName] [nvarchar](max) NULL,
	[address] [nvarchar](max) NULL,
	[phone] [nvarchar](max) NULL,
	[email] [nvarchar](max) NULL,
	[url] [nvarchar](max) NULL,
	[Detail] [nvarchar](max) NULL,
 CONSTRAINT [PK_institutionRegForServices] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[keeper]    Script Date: 10/22/2019 1:31:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[keeper](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[category] [nvarchar](max) NULL,
	[fullName] [nvarchar](max) NULL,
	[occupation] [nvarchar](max) NULL,
	[address] [nvarchar](max) NULL,
	[municipililty] [nvarchar](max) NULL,
	[wardNo] [nvarchar](max) NULL,
	[state] [nvarchar](max) NULL,
	[latitude] [nvarchar](max) NULL,
	[logitude] [nvarchar](max) NULL,
	[dob] [nvarchar](max) NULL,
	[academicQualification] [nvarchar](max) NULL,
	[finantanceStatus] [nvarchar](max) NULL,
	[mobileNumber] [nvarchar](max) NULL,
	[otherNumber] [nvarchar](max) NULL,
	[email] [nvarchar](max) NULL,
	[url] [nvarchar](max) NULL,
	[farmid] [int] NULL,
 CONSTRAINT [PK_keeper] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[lab]    Script Date: 10/22/2019 1:31:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[lab](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](max) NULL,
	[address] [nvarchar](max) NULL,
	[email] [nvarchar](max) NULL,
	[proprietor] [nvarchar](max) NULL,
 CONSTRAINT [PK_lab] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[login]    Script Date: 10/22/2019 1:31:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[login](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Email] [nvarchar](max) NULL,
	[PasswordHash] [varbinary](max) NULL,
	[PasswordSalt] [varbinary](max) NULL,
	[Role] [nvarchar](max) NULL,
 CONSTRAINT [PK_login] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Users]    Script Date: 10/22/2019 1:31:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[UserName] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[PhoneNo] [nvarchar](max) NULL,
	[Address] [nvarchar](max) NULL,
	[Role] [nvarchar](max) NULL,
	[passwordHash] [varbinary](max) NULL,
	[passwordSalt] [varbinary](max) NULL,
	[permission] [bit] NOT NULL,
	[ResetPasswordCode] [nvarchar](max) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'00000000000000_CreateIdentitySchema', N'2.1.11-servicing-32099')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190613094420_initial', N'2.1.11-servicing-32099')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190613104321_newdb', N'2.1.11-servicing-32099')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190614004257_TableName_changed_animalowner', N'2.1.11-servicing-32099')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190619010049_FewItemsAddedToMilkRecord', N'2.1.11-servicing-32099')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190619102957_newspecies', N'2.1.11-servicing-32099')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190619103235_rupak', N'2.1.11-servicing-32099')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190619113213_abc', N'2.1.11-servicing-32099')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190620085351_newcategoryinserted', N'2.1.11-servicing-32099')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190620092923_newdatabase', N'2.1.11-servicing-32099')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190620121111_dm', N'2.1.11-servicing-32099')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190621055304_new', N'2.1.11-servicing-32099')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190621062001_newlyadded', N'2.1.11-servicing-32099')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190621090905_migarationchanged', N'2.1.11-servicing-32099')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190621091449_newadd', N'2.1.11-servicing-32099')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190621091640_newnwe', N'2.1.11-servicing-32099')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190621112343_breed', N'2.1.11-servicing-32099')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190621115457_general', N'2.1.11-servicing-32099')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190623115450_earTagTable', N'2.1.11-servicing-32099')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190623115718_general-updated', N'2.1.11-servicing-32099')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190624083343_dpChangedToDmPregnancy', N'2.1.11-servicing-32099')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190624094115_newadded', N'2.1.11-servicing-32099')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190624095609_migrated', N'2.1.11-servicing-32099')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190624101717_newnew', N'2.1.11-servicing-32099')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190624104044_new-userLogin', N'2.1.11-servicing-32099')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190625023935_pregnancy', N'2.1.11-servicing-32099')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190625024314_preg', N'2.1.11-servicing-32099')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190625024630_preg', N'2.1.11-servicing-32099')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190625025816_newpreg', N'2.1.11-servicing-32099')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190625030237_sadfsa', N'2.1.11-servicing-32099')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190625030403_newad', N'2.1.11-servicing-32099')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190625075216_someItemsAddedToUser', N'2.1.11-servicing-32099')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190625075443_someItemsAddedToUserPermission', N'2.1.11-servicing-32099')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190625094011_test', N'2.1.11-servicing-32099')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190625094805_tests', N'2.1.11-servicing-32099')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190625095117_milk-base', N'2.1.11-servicing-32099')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190625100658_PasswordFieldRemoveFromUser', N'2.1.11-servicing-32099')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190628061345_resetpasswordcode', N'2.1.11-servicing-32099')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190629160434_milkVolumnAdded', N'2.1.11-servicing-32099')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190703000216_realtion-with-lab-to-milkRecord', N'2.1.11-servicing-32099')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190703112334_keeper', N'2.1.11-servicing-32099')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190704071457_animalimage]', N'2.1.11-servicing-32099')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190704110516_latitude', N'2.1.11-servicing-32099')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190704115434_virtualfarm', N'2.1.11-servicing-32099')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190704121524_labid', N'2.1.11-servicing-32099')
SET IDENTITY_INSERT [dbo].[dbug_animal] ON 

INSERT [dbo].[dbug_animal] ([id], [earTagNo], [weight], [breedId], [age], [dob], [sireId], [damId], [noOfCalving], [lastCalvingDate], [pregnencyStatus], [pregnencyDuration], [milkingStatus], [createdAt], [updatedBy], [ownerId], [keeperId], [farmId], [gender], [declaredBy], [declaredDate], [speciesId], [earTagId], [ImageName], [latitude], [longitude]) VALUES (1010, N'11', N'400', 15, N'1', N'2019-07-04', 0, 0, NULL, NULL, 0, NULL, 0, NULL, N'admin', 1, 1, 1, N'Female', NULL, CAST(0x070000000000DB3F0B AS DateTime2), 1, 301, NULL, N'sdf', N'sdfsd')
INSERT [dbo].[dbug_animal] ([id], [earTagNo], [weight], [breedId], [age], [dob], [sireId], [damId], [noOfCalving], [lastCalvingDate], [pregnencyStatus], [pregnencyDuration], [milkingStatus], [createdAt], [updatedBy], [ownerId], [keeperId], [farmId], [gender], [declaredBy], [declaredDate], [speciesId], [earTagId], [ImageName], [latitude], [longitude]) VALUES (1011, N'77', NULL, 15, NULL, N'2019-07-09', 0, 0, NULL, NULL, 0, NULL, 0, NULL, N'admin', 1, 1, 1, N'Female', NULL, CAST(0x070000000000DB3F0B AS DateTime2), 1, 307, NULL, NULL, NULL)
INSERT [dbo].[dbug_animal] ([id], [earTagNo], [weight], [breedId], [age], [dob], [sireId], [damId], [noOfCalving], [lastCalvingDate], [pregnencyStatus], [pregnencyDuration], [milkingStatus], [createdAt], [updatedBy], [ownerId], [keeperId], [farmId], [gender], [declaredBy], [declaredDate], [speciesId], [earTagId], [ImageName], [latitude], [longitude]) VALUES (1012, N'88', NULL, 16, NULL, N'2019-07-18', 0, 0, NULL, NULL, 0, NULL, 0, NULL, N'admin', 2, 1, 1, N'Female', NULL, CAST(0x070000000000DB3F0B AS DateTime2), 1, 308, NULL, NULL, NULL)
INSERT [dbo].[dbug_animal] ([id], [earTagNo], [weight], [breedId], [age], [dob], [sireId], [damId], [noOfCalving], [lastCalvingDate], [pregnencyStatus], [pregnencyDuration], [milkingStatus], [createdAt], [updatedBy], [ownerId], [keeperId], [farmId], [gender], [declaredBy], [declaredDate], [speciesId], [earTagId], [ImageName], [latitude], [longitude]) VALUES (1013, N'44', N'400', 16, N'4', N'2019-07-10', 1011, 0, NULL, NULL, 0, NULL, 0, NULL, N'admin', 1, 1, 1, N'Female', N'assd', CAST(0x070000000000DB3F0B AS DateTime2), 1, 304, NULL, N'434', N'34')
INSERT [dbo].[dbug_animal] ([id], [earTagNo], [weight], [breedId], [age], [dob], [sireId], [damId], [noOfCalving], [lastCalvingDate], [pregnencyStatus], [pregnencyDuration], [milkingStatus], [createdAt], [updatedBy], [ownerId], [keeperId], [farmId], [gender], [declaredBy], [declaredDate], [speciesId], [earTagId], [ImageName], [latitude], [longitude]) VALUES (1015, N'33', N'400', 16, N'1', N'2019-07-05', 1011, 1013, NULL, NULL, 0, NULL, 0, NULL, N'admin', 2, 1, 1, N'Female', NULL, CAST(0x070000000000DB3F0B AS DateTime2), 1, 303, NULL, N'34', N'345')
INSERT [dbo].[dbug_animal] ([id], [earTagNo], [weight], [breedId], [age], [dob], [sireId], [damId], [noOfCalving], [lastCalvingDate], [pregnencyStatus], [pregnencyDuration], [milkingStatus], [createdAt], [updatedBy], [ownerId], [keeperId], [farmId], [gender], [declaredBy], [declaredDate], [speciesId], [earTagId], [ImageName], [latitude], [longitude]) VALUES (1016, N'22', N'400', 17, N'2', N'2019-07-16', 0, 0, NULL, NULL, 0, NULL, 0, N'7/4/2019', NULL, 1, 1, 1, N'Female', NULL, CAST(0x070000000000DB3F0B AS DateTime2), 1, 302, NULL, NULL, NULL)
INSERT [dbo].[dbug_animal] ([id], [earTagNo], [weight], [breedId], [age], [dob], [sireId], [damId], [noOfCalving], [lastCalvingDate], [pregnencyStatus], [pregnencyDuration], [milkingStatus], [createdAt], [updatedBy], [ownerId], [keeperId], [farmId], [gender], [declaredBy], [declaredDate], [speciesId], [earTagId], [ImageName], [latitude], [longitude]) VALUES (1017, N'102', N'400', 17, N'1', NULL, 1016, 0, NULL, NULL, 0, N'2', 0, N'7/4/2019', NULL, 2, 1, 1, N'Female', NULL, CAST(0x070000000000DB3F0B AS DateTime2), 1, 310, NULL, NULL, NULL)
INSERT [dbo].[dbug_animal] ([id], [earTagNo], [weight], [breedId], [age], [dob], [sireId], [damId], [noOfCalving], [lastCalvingDate], [pregnencyStatus], [pregnencyDuration], [milkingStatus], [createdAt], [updatedBy], [ownerId], [keeperId], [farmId], [gender], [declaredBy], [declaredDate], [speciesId], [earTagId], [ImageName], [latitude], [longitude]) VALUES (1018, N'113', N'350', 15, N'4', NULL, 1016, 0, NULL, NULL, 0, NULL, 0, N'7/4/2019', NULL, 2, 1, 1, N'Male', NULL, CAST(0x070000000000DB3F0B AS DateTime2), 1, 311, NULL, NULL, NULL)
INSERT [dbo].[dbug_animal] ([id], [earTagNo], [weight], [breedId], [age], [dob], [sireId], [damId], [noOfCalving], [lastCalvingDate], [pregnencyStatus], [pregnencyDuration], [milkingStatus], [createdAt], [updatedBy], [ownerId], [keeperId], [farmId], [gender], [declaredBy], [declaredDate], [speciesId], [earTagId], [ImageName], [latitude], [longitude]) VALUES (1019, N'294', N'400', 15, N'1', N'2019-07-04', 1012, 1018, NULL, NULL, 0, NULL, 0, N'7/4/2019', NULL, 1, 1, 1, N'Male', NULL, CAST(0x070000000000DB3F0B AS DateTime2), 1, 329, NULL, NULL, NULL)
INSERT [dbo].[dbug_animal] ([id], [earTagNo], [weight], [breedId], [age], [dob], [sireId], [damId], [noOfCalving], [lastCalvingDate], [pregnencyStatus], [pregnencyDuration], [milkingStatus], [createdAt], [updatedBy], [ownerId], [keeperId], [farmId], [gender], [declaredBy], [declaredDate], [speciesId], [earTagId], [ImageName], [latitude], [longitude]) VALUES (1020, N'306', N'400', 15, N'1', NULL, 1010, 1018, NULL, NULL, 0, NULL, 0, N'7/4/2019', NULL, 2, 1, 1, N'Male', NULL, CAST(0x070000000000DB3F0B AS DateTime2), 1, 330, NULL, NULL, NULL)
INSERT [dbo].[dbug_animal] ([id], [earTagNo], [weight], [breedId], [age], [dob], [sireId], [damId], [noOfCalving], [lastCalvingDate], [pregnencyStatus], [pregnencyDuration], [milkingStatus], [createdAt], [updatedBy], [ownerId], [keeperId], [farmId], [gender], [declaredBy], [declaredDate], [speciesId], [earTagId], [ImageName], [latitude], [longitude]) VALUES (1021, N'135', N'500', 16, N'5', NULL, 1013, 1018, NULL, NULL, 0, NULL, 0, N'7/5/2019', NULL, 1, 1, 1, NULL, NULL, CAST(0x070000000000DC3F0B AS DateTime2), 1, 313, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[dbug_animal] OFF
INSERT [dbo].[dbug_animalOwner] ([AnimalId], [OwnerId]) VALUES (1010, 1)
INSERT [dbo].[dbug_animalOwner] ([AnimalId], [OwnerId]) VALUES (1011, 1)
INSERT [dbo].[dbug_animalOwner] ([AnimalId], [OwnerId]) VALUES (1012, 2)
INSERT [dbo].[dbug_animalOwner] ([AnimalId], [OwnerId]) VALUES (1013, 1)
INSERT [dbo].[dbug_animalOwner] ([AnimalId], [OwnerId]) VALUES (1015, 2)
INSERT [dbo].[dbug_animalOwner] ([AnimalId], [OwnerId]) VALUES (1016, 1)
INSERT [dbo].[dbug_animalOwner] ([AnimalId], [OwnerId]) VALUES (1017, 2)
INSERT [dbo].[dbug_animalOwner] ([AnimalId], [OwnerId]) VALUES (1018, 2)
INSERT [dbo].[dbug_animalOwner] ([AnimalId], [OwnerId]) VALUES (1019, 1)
INSERT [dbo].[dbug_animalOwner] ([AnimalId], [OwnerId]) VALUES (1020, 2)
INSERT [dbo].[dbug_animalOwner] ([AnimalId], [OwnerId]) VALUES (1021, 1)
SET IDENTITY_INSERT [dbo].[dbug_breedAnimal] ON 

INSERT [dbo].[dbug_breedAnimal] ([id], [breedNameShort], [breedNamelong], [shortDetail], [originFrom], [registeredBy], [updatedBy], [registeredDate], [speciesId]) VALUES (14, N'Murra Cross', NULL, NULL, NULL, N'admin', NULL, CAST(0x070000000000000000 AS DateTime2), 2)
INSERT [dbo].[dbug_breedAnimal] ([id], [breedNameShort], [breedNamelong], [shortDetail], [originFrom], [registeredBy], [updatedBy], [registeredDate], [speciesId]) VALUES (15, N'lulu', NULL, NULL, NULL, N'admin', N'admin', CAST(0x076B7A419694DB3F0B AS DateTime2), 1)
INSERT [dbo].[dbug_breedAnimal] ([id], [breedNameShort], [breedNamelong], [shortDetail], [originFrom], [registeredBy], [updatedBy], [registeredDate], [speciesId]) VALUES (16, N'hf', NULL, NULL, NULL, N'admin', N'admin', CAST(0x075C80859A94DB3F0B AS DateTime2), 1)
INSERT [dbo].[dbug_breedAnimal] ([id], [breedNameShort], [breedNamelong], [shortDetail], [originFrom], [registeredBy], [updatedBy], [registeredDate], [speciesId]) VALUES (17, N'jersy', NULL, NULL, NULL, N'admin', N'admin', CAST(0x073C9699DC94DB3F0B AS DateTime2), 1)
INSERT [dbo].[dbug_breedAnimal] ([id], [breedNameShort], [breedNamelong], [shortDetail], [originFrom], [registeredBy], [updatedBy], [registeredDate], [speciesId]) VALUES (1001, N'LuLu', NULL, NULL, NULL, N'admin', N'admin', CAST(0x07E52EF60451DB3F0B AS DateTime2), 1)
SET IDENTITY_INSERT [dbo].[dbug_breedAnimal] OFF
SET IDENTITY_INSERT [dbo].[dbug_diseases] ON 

INSERT [dbo].[dbug_diseases] ([id], [diseasesNameEng], [diseasesNameNep], [symptom], [shortNote], [AnimalRegistrationid]) VALUES (1, N'Fiver', N'joro', N'Hot body temperature', NULL, NULL)
SET IDENTITY_INSERT [dbo].[dbug_diseases] OFF
SET IDENTITY_INSERT [dbo].[dbug_farm] ON 

INSERT [dbo].[dbug_farm] ([id], [orgtanizationName], [shortDetail], [dateOfRegistration], [regCertification], [mobile1], [mobile], [email], [url], [address], [municipility], [ward], [longitude], [latitude], [farmType], [land], [area]) VALUES (1, N'Golok farm', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[dbug_farm] OFF
SET IDENTITY_INSERT [dbo].[dbug_FeedFooder] ON 

INSERT [dbo].[dbug_FeedFooder] ([id], [fooderNameNep], [fooderNameEng], [address], [municipility], [district], [state], [shortNote], [cultivation], [seedingMethod], [seedHarvestingStorage], [grassProduct], [dm], [cp], [tdn], [ndf], [c], [p], [df], [adl], [tanni], [nitrateScore], [remarks], [price], [category]) VALUES (1, N'asdf', N'asdf', N'asdf', N'asdf', N'asdf', N'lkjh', N';lkj', N';lkj', N';lkj', N';lkj', N';klj', N';lkj', N';lkj', N';lkj', N'1', N'1', N'1', N'1', N'1', N'1', N'1', N'1', N'1', N'Green')
INSERT [dbo].[dbug_FeedFooder] ([id], [fooderNameNep], [fooderNameEng], [address], [municipility], [district], [state], [shortNote], [cultivation], [seedingMethod], [seedHarvestingStorage], [grassProduct], [dm], [cp], [tdn], [ndf], [c], [p], [df], [adl], [tanni], [nitrateScore], [remarks], [price], [category]) VALUES (2, N'अर्चल', N'archal', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'13.2', N'11.6', NULL, N'39.36', N'1.12', N'0.23', NULL, N'16.58', N'2.2', NULL, NULL, NULL, N'Green')
INSERT [dbo].[dbug_FeedFooder] ([id], [fooderNameNep], [fooderNameEng], [address], [municipility], [district], [state], [shortNote], [cultivation], [seedingMethod], [seedHarvestingStorage], [grassProduct], [dm], [cp], [tdn], [ndf], [c], [p], [df], [adl], [tanni], [nitrateScore], [remarks], [price], [category]) VALUES (3, N'अगस्ती', N'Agasti', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'17.87', NULL, NULL, N'1.25', N'0.2', NULL, NULL, NULL, NULL, NULL, NULL, N'Green')
INSERT [dbo].[dbug_FeedFooder] ([id], [fooderNameNep], [fooderNameEng], [address], [municipility], [district], [state], [shortNote], [cultivation], [seedingMethod], [seedHarvestingStorage], [grassProduct], [dm], [cp], [tdn], [ndf], [c], [p], [df], [adl], [tanni], [nitrateScore], [remarks], [price], [category]) VALUES (4, N'अखाने', N'akhane', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'27.5', N'17.1', NULL, NULL, N'1.76', N'0.3', NULL, N'3.5', N'0.9', NULL, NULL, NULL, N'Green')
INSERT [dbo].[dbug_FeedFooder] ([id], [fooderNameNep], [fooderNameEng], [address], [municipility], [district], [state], [shortNote], [cultivation], [seedingMethod], [seedHarvestingStorage], [grassProduct], [dm], [cp], [tdn], [ndf], [c], [p], [df], [adl], [tanni], [nitrateScore], [remarks], [price], [category]) VALUES (5, N'असारे', N'Asare', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'12.70', N'17.10', NULL, NULL, N'1.53', N'0.3', NULL, N'15.40', N'2', NULL, NULL, NULL, N'Green')
INSERT [dbo].[dbug_FeedFooder] ([id], [fooderNameNep], [fooderNameEng], [address], [municipility], [district], [state], [shortNote], [cultivation], [seedingMethod], [seedHarvestingStorage], [grassProduct], [dm], [cp], [tdn], [ndf], [c], [p], [df], [adl], [tanni], [nitrateScore], [remarks], [price], [category]) VALUES (6, N'अम्रिसो', N'Amriso', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'20.6', N'6.7', NULL, N'76', N'0.42', N'0.22', NULL, NULL, NULL, NULL, NULL, NULL, N'Green')
INSERT [dbo].[dbug_FeedFooder] ([id], [fooderNameNep], [fooderNameEng], [address], [municipility], [district], [state], [shortNote], [cultivation], [seedingMethod], [seedHarvestingStorage], [grassProduct], [dm], [cp], [tdn], [ndf], [c], [p], [df], [adl], [tanni], [nitrateScore], [remarks], [price], [category]) VALUES (7, N'काने झार', N'Kane Jhar', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'12.65', NULL, N'61.22', N'1.61', N'0.66', NULL, NULL, NULL, NULL, NULL, NULL, N'Green')
INSERT [dbo].[dbug_FeedFooder] ([id], [fooderNameNep], [fooderNameEng], [address], [municipility], [district], [state], [shortNote], [cultivation], [seedingMethod], [seedHarvestingStorage], [grassProduct], [dm], [cp], [tdn], [ndf], [c], [p], [df], [adl], [tanni], [nitrateScore], [remarks], [price], [category]) VALUES (8, N'कनिका', N'kanika', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'85.1', N'7.5', NULL, NULL, N'0.1', N'0.11', NULL, NULL, NULL, NULL, NULL, NULL, N'Mineral')
INSERT [dbo].[dbug_FeedFooder] ([id], [fooderNameNep], [fooderNameEng], [address], [municipility], [district], [state], [shortNote], [cultivation], [seedingMethod], [seedHarvestingStorage], [grassProduct], [dm], [cp], [tdn], [ndf], [c], [p], [df], [adl], [tanni], [nitrateScore], [remarks], [price], [category]) VALUES (9, N'कोदो को गेडा', N'Kodo ko geda', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'76.20', N'6.30', NULL, NULL, N'0.22', N'0.23', NULL, NULL, NULL, NULL, NULL, NULL, N'Mineral')
INSERT [dbo].[dbug_FeedFooder] ([id], [fooderNameNep], [fooderNameEng], [address], [municipility], [district], [state], [shortNote], [cultivation], [seedingMethod], [seedHarvestingStorage], [grassProduct], [dm], [cp], [tdn], [ndf], [c], [p], [df], [adl], [tanni], [nitrateScore], [remarks], [price], [category]) VALUES (10, N'अदुवा को पात', N'Aduwa ko pat', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'9.24', N'10.67', NULL, N'61.91', N'0.82', N'0.45', NULL, N'26.82', NULL, NULL, NULL, NULL, N'Green')
INSERT [dbo].[dbug_FeedFooder] ([id], [fooderNameNep], [fooderNameEng], [address], [municipility], [district], [state], [shortNote], [cultivation], [seedingMethod], [seedHarvestingStorage], [grassProduct], [dm], [cp], [tdn], [ndf], [c], [p], [df], [adl], [tanni], [nitrateScore], [remarks], [price], [category]) VALUES (11, N'आरु को pat', N'Aaru ko pat', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'10.73', N'16.37', NULL, N'33.32', N'1.13', N'0.23', NULL, N'16.82', NULL, NULL, NULL, NULL, N'Green')
INSERT [dbo].[dbug_FeedFooder] ([id], [fooderNameNep], [fooderNameEng], [address], [municipility], [district], [state], [shortNote], [cultivation], [seedingMethod], [seedHarvestingStorage], [grassProduct], [dm], [cp], [tdn], [ndf], [c], [p], [df], [adl], [tanni], [nitrateScore], [remarks], [price], [category]) VALUES (12, N'अन्जान घाँस', N'Anzan ghans', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'83.18', N'9.41', NULL, N'65.69', N'0.29', N'0.36', NULL, N'16.26', NULL, NULL, NULL, NULL, N'Green')
INSERT [dbo].[dbug_FeedFooder] ([id], [fooderNameNep], [fooderNameEng], [address], [municipility], [district], [state], [shortNote], [cultivation], [seedingMethod], [seedHarvestingStorage], [grassProduct], [dm], [cp], [tdn], [ndf], [c], [p], [df], [adl], [tanni], [nitrateScore], [remarks], [price], [category]) VALUES (13, N'कानबुची', N'kanbuchi', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'87.37', N'18.99', NULL, N'31.32', N'0.41', N'0.33', NULL, N'16.93', NULL, NULL, NULL, NULL, N'Green')
INSERT [dbo].[dbug_FeedFooder] ([id], [fooderNameNep], [fooderNameEng], [address], [municipility], [district], [state], [shortNote], [cultivation], [seedingMethod], [seedHarvestingStorage], [grassProduct], [dm], [cp], [tdn], [ndf], [c], [p], [df], [adl], [tanni], [nitrateScore], [remarks], [price], [category]) VALUES (14, N' कोदो को नाल', N'kodo ko nal', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'88.32', N'3.37', NULL, N'60.50', N'0.99', N'0.44', NULL, N'6.57', NULL, NULL, NULL, NULL, N'Dry')
INSERT [dbo].[dbug_FeedFooder] ([id], [fooderNameNep], [fooderNameEng], [address], [municipility], [district], [state], [shortNote], [cultivation], [seedingMethod], [seedHarvestingStorage], [grassProduct], [dm], [cp], [tdn], [ndf], [c], [p], [df], [adl], [tanni], [nitrateScore], [remarks], [price], [category]) VALUES (15, N'मकै को खोस्टा', N'Makai ko khosta', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'90.63', N'1.58', NULL, N'77.80', N'0.06', NULL, NULL, N'6.39', NULL, NULL, NULL, NULL, N'Dry')
INSERT [dbo].[dbug_FeedFooder] ([id], [fooderNameNep], [fooderNameEng], [address], [municipility], [district], [state], [shortNote], [cultivation], [seedingMethod], [seedHarvestingStorage], [grassProduct], [dm], [cp], [tdn], [ndf], [c], [p], [df], [adl], [tanni], [nitrateScore], [remarks], [price], [category]) VALUES (16, N'मकै को ढोड', N'Makai ko Dhod', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'89.31', N'2.59', NULL, N'78.75', NULL, NULL, NULL, N'5.68', NULL, NULL, NULL, NULL, N'Dry')
SET IDENTITY_INSERT [dbo].[dbug_FeedFooder] OFF
SET IDENTITY_INSERT [dbo].[dbug_GeneralNutration] ON 

INSERT [dbo].[dbug_GeneralNutration] ([id], [animalSpecies], [weight], [snf], [dm], [dcp], [tdn], [ndf], [c], [p]) VALUES (1, N'1', N'400', NULL, N'0.75', N'0.235', N'0.355', NULL, N'0.0028', N'0.002')
INSERT [dbo].[dbug_GeneralNutration] ([id], [animalSpecies], [weight], [snf], [dm], [dcp], [tdn], [ndf], [c], [p]) VALUES (2, N'1', N'300', NULL, N'.74', NULL, N'0.433', NULL, N'0.0023', N'0.0018')
INSERT [dbo].[dbug_GeneralNutration] ([id], [animalSpecies], [weight], [snf], [dm], [dcp], [tdn], [ndf], [c], [p]) VALUES (3, N'1', N'350', NULL, N'.83', NULL, N'0.44', NULL, N'0.0025', N'0.0018')
INSERT [dbo].[dbug_GeneralNutration] ([id], [animalSpecies], [weight], [snf], [dm], [dcp], [tdn], [ndf], [c], [p]) VALUES (4, N'1', N'450', NULL, N'.1', NULL, N'0.59', NULL, N'0.0026', N'0.0023')
INSERT [dbo].[dbug_GeneralNutration] ([id], [animalSpecies], [weight], [snf], [dm], [dcp], [tdn], [ndf], [c], [p]) VALUES (5, N'1', N'500', NULL, N'.108', NULL, N'0.64', NULL, N'0.0027', N'0.0024')
INSERT [dbo].[dbug_GeneralNutration] ([id], [animalSpecies], [weight], [snf], [dm], [dcp], [tdn], [ndf], [c], [p]) VALUES (6, N'1', N'200', NULL, N'.54', NULL, N'0.32', NULL, N'0.0021', N'0.0015')
INSERT [dbo].[dbug_GeneralNutration] ([id], [animalSpecies], [weight], [snf], [dm], [dcp], [tdn], [ndf], [c], [p]) VALUES (7, N'1', N'250', NULL, N'.64', NULL, N'0.38', NULL, N'0.0021', N'0.0017')
SET IDENTITY_INSERT [dbo].[dbug_GeneralNutration] OFF
SET IDENTITY_INSERT [dbo].[dbug_milkBaseNutrition] ON 

INSERT [dbo].[dbug_milkBaseNutrition] ([id], [fatPercentage], [snf], [dp], [cp], [tdn], [ndf], [c], [p], [dm], [weight], [SpeciesId], [milkVolumn]) VALUES (1, N'5', NULL, NULL, NULL, N'0.4', NULL, N'0.003', N'0.0023', N'0.33', N'400', 1, NULL)
INSERT [dbo].[dbug_milkBaseNutrition] ([id], [fatPercentage], [snf], [dp], [cp], [tdn], [ndf], [c], [p], [dm], [weight], [SpeciesId], [milkVolumn]) VALUES (2, N'4', NULL, NULL, NULL, N'0.36', NULL, N'0.0027', N'0.002', N'0.30', N'400', 1, NULL)
INSERT [dbo].[dbug_milkBaseNutrition] ([id], [fatPercentage], [snf], [dp], [cp], [tdn], [ndf], [c], [p], [dm], [weight], [SpeciesId], [milkVolumn]) VALUES (3, N'6', NULL, NULL, NULL, N'0.42', NULL, N'0.0032', N'0.0025', N'0.35', N'400', 1, NULL)
INSERT [dbo].[dbug_milkBaseNutrition] ([id], [fatPercentage], [snf], [dp], [cp], [tdn], [ndf], [c], [p], [dm], [weight], [SpeciesId], [milkVolumn]) VALUES (4, N'3', NULL, NULL, NULL, N'0.31', NULL, N'0.0025', N'0.0018', N'0.3', N'400', 1, NULL)
SET IDENTITY_INSERT [dbo].[dbug_milkBaseNutrition] OFF
SET IDENTITY_INSERT [dbo].[dbug_milkRecord] ON 

INSERT [dbo].[dbug_milkRecord] ([id], [earTagNumber], [milkingStatus], [recordingPeriod], [recordingDate], [milkVolume], [milkSampleBoxNo], [labId], [testingCharge], [receiptNo], [genericProblem], [vacination], [shortNote], [animalRegistrationid], [fatPercentage], [snf]) VALUES (1002, N'11', NULL, N'Morning', CAST(0x070000000000DB3F0B AS DateTime2), N'10', NULL, 1, NULL, NULL, NULL, NULL, NULL, 1010, N'6', NULL)
INSERT [dbo].[dbug_milkRecord] ([id], [earTagNumber], [milkingStatus], [recordingPeriod], [recordingDate], [milkVolume], [milkSampleBoxNo], [labId], [testingCharge], [receiptNo], [genericProblem], [vacination], [shortNote], [animalRegistrationid], [fatPercentage], [snf]) VALUES (1004, N'77', N'Yes', N'Morning', CAST(0x070000000000DB3F0B AS DateTime2), N'15', NULL, 1, NULL, NULL, NULL, NULL, NULL, 1011, N'3', N'5.5')
INSERT [dbo].[dbug_milkRecord] ([id], [earTagNumber], [milkingStatus], [recordingPeriod], [recordingDate], [milkVolume], [milkSampleBoxNo], [labId], [testingCharge], [receiptNo], [genericProblem], [vacination], [shortNote], [animalRegistrationid], [fatPercentage], [snf]) VALUES (1005, N'88', N'Yes', N'Morning', CAST(0x070000000000DB3F0B AS DateTime2), N'12', NULL, 1, NULL, NULL, NULL, NULL, NULL, 1012, N'4', N'5.7')
INSERT [dbo].[dbug_milkRecord] ([id], [earTagNumber], [milkingStatus], [recordingPeriod], [recordingDate], [milkVolume], [milkSampleBoxNo], [labId], [testingCharge], [receiptNo], [genericProblem], [vacination], [shortNote], [animalRegistrationid], [fatPercentage], [snf]) VALUES (1006, N'44', N'Yes', N'Morning', CAST(0x070000000000DB3F0B AS DateTime2), N'9', NULL, 1, NULL, NULL, NULL, NULL, NULL, 1013, N'2', NULL)
INSERT [dbo].[dbug_milkRecord] ([id], [earTagNumber], [milkingStatus], [recordingPeriod], [recordingDate], [milkVolume], [milkSampleBoxNo], [labId], [testingCharge], [receiptNo], [genericProblem], [vacination], [shortNote], [animalRegistrationid], [fatPercentage], [snf]) VALUES (1008, N'33', N'Yes', N'Morning', CAST(0x070000000000DB3F0B AS DateTime2), N'8', NULL, 1, NULL, NULL, NULL, NULL, NULL, 1015, N'5', NULL)
INSERT [dbo].[dbug_milkRecord] ([id], [earTagNumber], [milkingStatus], [recordingPeriod], [recordingDate], [milkVolume], [milkSampleBoxNo], [labId], [testingCharge], [receiptNo], [genericProblem], [vacination], [shortNote], [animalRegistrationid], [fatPercentage], [snf]) VALUES (1009, N'22', N'Yes', N'Morning', CAST(0x070000000000DB3F0B AS DateTime2), N'14', NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1016, N'4', NULL)
INSERT [dbo].[dbug_milkRecord] ([id], [earTagNumber], [milkingStatus], [recordingPeriod], [recordingDate], [milkVolume], [milkSampleBoxNo], [labId], [testingCharge], [receiptNo], [genericProblem], [vacination], [shortNote], [animalRegistrationid], [fatPercentage], [snf]) VALUES (1010, N'102', N'Yes', N'Morning', CAST(0x070000000000DB3F0B AS DateTime2), N'7', NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1017, N'2', NULL)
SET IDENTITY_INSERT [dbo].[dbug_milkRecord] OFF
SET IDENTITY_INSERT [dbo].[dbug_ownerKeeper] ON 

INSERT [dbo].[dbug_ownerKeeper] ([id], [category], [fullName], [occupation], [address], [municipililty], [wardNo], [state], [latitude], [logitude], [dob], [academicQualification], [finantanceStatus], [mobileNumber], [otherNumber], [email], [url], [farmid]) VALUES (1, NULL, N'Dhanbar', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[dbug_ownerKeeper] ([id], [category], [fullName], [occupation], [address], [municipililty], [wardNo], [state], [latitude], [logitude], [dob], [academicQualification], [finantanceStatus], [mobileNumber], [otherNumber], [email], [url], [farmid]) VALUES (2, NULL, N'sita', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
SET IDENTITY_INSERT [dbo].[dbug_ownerKeeper] OFF
SET IDENTITY_INSERT [dbo].[dbug_pregnancyBaseNutrition] ON 

INSERT [dbo].[dbug_pregnancyBaseNutrition] ([id], [speciesId], [breed], [weight], [PregrenencyType], [ageOfAnimal], [fatPercentage], [snf], [dm], [cp], [tdn], [ndf], [c], [p], [milkVolumn]) VALUES (1, 1, NULL, N'400', N'Early', N'1', N'5', N'1', N'0.2', N'0.2', N'0.2', N'0.2', N'0.003', N'0.001', N'5')
INSERT [dbo].[dbug_pregnancyBaseNutrition] ([id], [speciesId], [breed], [weight], [PregrenencyType], [ageOfAnimal], [fatPercentage], [snf], [dm], [cp], [tdn], [ndf], [c], [p], [milkVolumn]) VALUES (2, 1, NULL, N'400', N'Mid', N'1', N'5', N'1', N'0.2', N'0.3', N'0.6', N'0.7', N'0.08', N'0.01', N'5')
INSERT [dbo].[dbug_pregnancyBaseNutrition] ([id], [speciesId], [breed], [weight], [PregrenencyType], [ageOfAnimal], [fatPercentage], [snf], [dm], [cp], [tdn], [ndf], [c], [p], [milkVolumn]) VALUES (3, 1, NULL, N'400', N'Late', N'1', N'5', N'5', N'0.5', N'0.5', N'0.6', N'0.4', N'0.02', N'0.08', N'5')
INSERT [dbo].[dbug_pregnancyBaseNutrition] ([id], [speciesId], [breed], [weight], [PregrenencyType], [ageOfAnimal], [fatPercentage], [snf], [dm], [cp], [tdn], [ndf], [c], [p], [milkVolumn]) VALUES (4, 2, NULL, N'400', N'Early', N'1', N'5', N'5', N'0.6', N'0.9', N'0.8', N'0.6', N'0.05', N'0.02', N'5')
SET IDENTITY_INSERT [dbo].[dbug_pregnancyBaseNutrition] OFF
SET IDENTITY_INSERT [dbo].[dbug_Species] ON 

INSERT [dbo].[dbug_Species] ([id], [speciesName], [originFrom], [shortNotes], [Speciesid]) VALUES (1, N'Cattle', N'Nepal', N'this is a note', NULL)
INSERT [dbo].[dbug_Species] ([id], [speciesName], [originFrom], [shortNotes], [Speciesid]) VALUES (2, N'buffalo', N'Nepal', N'this is also ma mplkskop', NULL)
SET IDENTITY_INSERT [dbo].[dbug_Species] OFF
SET IDENTITY_INSERT [dbo].[EarTags] ON 

INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (301, 11, N'11')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (302, 22, N'22')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (303, 33, N'33')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (304, 44, N'44')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (305, 55, N'55')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (306, 66, N'66')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (307, 77, N'77')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (308, 88, N'88')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (309, 90, N'90')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (310, 102, N'102')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (311, 113, N'113')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (312, 124, N'124')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (313, 135, N'135')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (314, 146, N'146')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (315, 157, N'157')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (316, 168, N'168')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (317, 170, N'170')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (318, 181, N'181')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (319, 192, N'192')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (320, 204, N'204')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (321, 215, N'215')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (322, 226, N'226')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (323, 237, N'237')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (324, 248, N'248')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (325, 250, N'250')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (326, 261, N'261')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (327, 272, N'272')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (328, 283, N'283')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (329, 294, N'294')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (330, 306, N'306')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (331, 317, N'317')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (332, 328, N'328')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (333, 330, N'330')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (334, 341, N'341')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (335, 352, N'352')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (336, 363, N'363')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (337, 374, N'374')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (338, 385, N'385')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (339, 396, N'396')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (340, 408, N'408')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (341, 410, N'410')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (342, 421, N'421')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (343, 432, N'432')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (344, 443, N'443')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (345, 454, N'454')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (346, 465, N'465')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (347, 476, N'476')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (348, 487, N'487')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (349, 498, N'498')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (350, 501, N'501')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (351, 512, N'512')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (352, 523, N'523')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (353, 534, N'534')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (354, 545, N'545')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (355, 556, N'556')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (356, 567, N'567')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (357, 578, N'578')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (358, 580, N'580')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (359, 591, N'591')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (360, 603, N'603')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (361, 614, N'614')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (362, 625, N'625')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (363, 636, N'636')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (364, 647, N'647')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (365, 658, N'658')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (366, 660, N'660')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (367, 671, N'671')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (368, 682, N'682')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (369, 693, N'693')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (370, 705, N'705')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (371, 716, N'716')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (372, 727, N'727')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (373, 738, N'738')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (374, 740, N'740')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (375, 751, N'751')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (376, 762, N'762')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (377, 773, N'773')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (378, 784, N'784')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (379, 795, N'795')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (380, 807, N'807')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (381, 818, N'818')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (382, 820, N'820')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (383, 831, N'831')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (384, 842, N'842')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (385, 853, N'853')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (386, 864, N'864')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (387, 875, N'875')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (388, 886, N'886')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (389, 897, N'897')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (390, 900, N'900')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (391, 911, N'911')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (392, 922, N'922')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (393, 933, N'933')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (394, 944, N'944')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (395, 955, N'955')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (396, 966, N'966')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (397, 977, N'977')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (398, 988, N'988')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (399, 990, N'990')
GO
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (400, 1003, N'1003')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (401, 1014, N'1014')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (402, 0, N'0')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1402, 11, N'11')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1403, 22, N'22')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1404, 33, N'33')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1405, 44, N'44')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1406, 55, N'55')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1407, 66, N'66')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1408, 77, N'77')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1409, 88, N'88')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1410, 90, N'90')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1411, 102, N'102')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1412, 113, N'113')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1413, 124, N'124')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1414, 135, N'135')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1415, 146, N'146')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1416, 157, N'157')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1417, 168, N'168')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1418, 170, N'170')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1419, 181, N'181')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1420, 192, N'192')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1421, 204, N'204')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1422, 215, N'215')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1423, 226, N'226')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1424, 237, N'237')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1425, 248, N'248')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1426, 250, N'250')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1427, 261, N'261')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1428, 272, N'272')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1429, 283, N'283')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1430, 294, N'294')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1431, 306, N'306')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1432, 317, N'317')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1433, 328, N'328')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1434, 330, N'330')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1435, 341, N'341')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1436, 352, N'352')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1437, 363, N'363')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1438, 374, N'374')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1439, 385, N'385')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1440, 396, N'396')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1441, 408, N'408')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1442, 410, N'410')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1443, 421, N'421')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1444, 432, N'432')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1445, 443, N'443')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1446, 454, N'454')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1447, 465, N'465')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1448, 476, N'476')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1449, 487, N'487')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1450, 498, N'498')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1451, 501, N'501')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1452, 512, N'512')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1453, 523, N'523')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1454, 534, N'534')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1455, 545, N'545')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1456, 556, N'556')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1457, 567, N'567')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1458, 578, N'578')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1459, 580, N'580')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1460, 591, N'591')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1461, 603, N'603')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1462, 614, N'614')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1463, 625, N'625')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1464, 636, N'636')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1465, 647, N'647')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1466, 658, N'658')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1467, 660, N'660')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1468, 671, N'671')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1469, 682, N'682')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1470, 693, N'693')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1471, 705, N'705')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1472, 716, N'716')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1473, 727, N'727')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1474, 738, N'738')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1475, 740, N'740')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1476, 751, N'751')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1477, 762, N'762')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1478, 773, N'773')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1479, 784, N'784')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1480, 795, N'795')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1481, 807, N'807')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1482, 818, N'818')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1483, 820, N'820')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1484, 831, N'831')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1485, 842, N'842')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1486, 853, N'853')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1487, 864, N'864')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1488, 875, N'875')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1489, 886, N'886')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1490, 897, N'897')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1491, 900, N'900')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1492, 911, N'911')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1493, 922, N'922')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1494, 933, N'933')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1495, 944, N'944')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1496, 955, N'955')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1497, 966, N'966')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1498, 977, N'977')
GO
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1499, 988, N'988')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1500, 990, N'990')
INSERT [dbo].[EarTags] ([id], [earTagNo], [earTagNoStr]) VALUES (1501, 1003, N'1003')
SET IDENTITY_INSERT [dbo].[EarTags] OFF
SET IDENTITY_INSERT [dbo].[keeper] ON 

INSERT [dbo].[keeper] ([id], [category], [fullName], [occupation], [address], [municipililty], [wardNo], [state], [latitude], [logitude], [dob], [academicQualification], [finantanceStatus], [mobileNumber], [otherNumber], [email], [url], [farmid]) VALUES (1, NULL, N'Bhahadur', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
SET IDENTITY_INSERT [dbo].[keeper] OFF
SET IDENTITY_INSERT [dbo].[lab] ON 

INSERT [dbo].[lab] ([id], [name], [address], [email], [proprietor]) VALUES (1, N'animal Laboratory', N'kathmandu', N'dbugsoft@gmail.com', N'suresh')
SET IDENTITY_INSERT [dbo].[lab] OFF
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([Id], [Name], [UserName], [Email], [PhoneNo], [Address], [Role], [passwordHash], [passwordSalt], [permission], [ResetPasswordCode]) VALUES (1, N'admin', N'admin', N'maharjanakancha@gmail.com', NULL, NULL, N'Admin', 0x7AD498AD9AD35A681D9218D3CE5A005B908B133F1851F544020BBF29BAEFDF3AB61BC51EA7A353B5D62606614C79B7F3F334ECF24F76CBDF4C823E404D02167D, 0xA66AE15C691D9520A25488A436D38C2A8D1DB80D4D8BCF9107791CA256EE1D7A91D5E4715258ED2A7D5C1B55BDE660A84F6A50ED5D56B40F62A036A98C501D0C7E827532430B4A1FB985B6DD6EDB4ACA21A60BECF4AF0356EF0EE4650BA1CB609DF371803E2650E3D8DAFBF47532C48AC8A5FBE08E6D8F8DDE0231056828D808, 1, NULL)
INSERT [dbo].[Users] ([Id], [Name], [UserName], [Email], [PhoneNo], [Address], [Role], [passwordHash], [passwordSalt], [permission], [ResetPasswordCode]) VALUES (1004, N'admin', N'admin', NULL, NULL, NULL, N'Admin', 0x1057F4CE7A4E233E0B545A0E08ABE6CEB8CD97D5DDB7451EA7CFBD079A530B4892800C4F930F2E3BE0A4BF3F963523F69389E2F7A34393BF7509E65684449050, 0xD61A8DDDC588897153AE2BF76FF5CD42D2A68B223B3872FB8C0646123B5210F6F4CFA6E3886091B8C657E6BC95DEDC6315A1671FAF6532BAAA576EDB28FFEBDA72F8445A34FFA9167DD6E93CFB4996839A664548ABC9D2AA709EB8027662DDF78DE157423157FBFB800E830213C95470AE39CDB85304FFF65686A3B87F268A9E, 0, NULL)
SET IDENTITY_INSERT [dbo].[Users] OFF
ALTER TABLE [dbo].[dbug_animal] ADD  DEFAULT ((0)) FOR [earTagId]
GO
ALTER TABLE [dbo].[Users] ADD  DEFAULT ((0)) FOR [permission]
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[dbug_animal]  WITH CHECK ADD  CONSTRAINT [FK_dbug_animal_dbug_breedAnimal_breedId] FOREIGN KEY([breedId])
REFERENCES [dbo].[dbug_breedAnimal] ([id])
GO
ALTER TABLE [dbo].[dbug_animal] CHECK CONSTRAINT [FK_dbug_animal_dbug_breedAnimal_breedId]
GO
ALTER TABLE [dbo].[dbug_animal]  WITH CHECK ADD  CONSTRAINT [FK_dbug_animal_dbug_farm_farmId] FOREIGN KEY([farmId])
REFERENCES [dbo].[dbug_farm] ([id])
GO
ALTER TABLE [dbo].[dbug_animal] CHECK CONSTRAINT [FK_dbug_animal_dbug_farm_farmId]
GO
ALTER TABLE [dbo].[dbug_animal]  WITH CHECK ADD  CONSTRAINT [FK_dbug_animal_dbug_Species_speciesId] FOREIGN KEY([speciesId])
REFERENCES [dbo].[dbug_Species] ([id])
GO
ALTER TABLE [dbo].[dbug_animal] CHECK CONSTRAINT [FK_dbug_animal_dbug_Species_speciesId]
GO
ALTER TABLE [dbo].[dbug_animal]  WITH CHECK ADD  CONSTRAINT [FK_dbug_animal_EarTags_earTagId] FOREIGN KEY([earTagId])
REFERENCES [dbo].[EarTags] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[dbug_animal] CHECK CONSTRAINT [FK_dbug_animal_EarTags_earTagId]
GO
ALTER TABLE [dbo].[dbug_animal]  WITH CHECK ADD  CONSTRAINT [FK_dbug_animal_keeper_keeperId] FOREIGN KEY([keeperId])
REFERENCES [dbo].[keeper] ([id])
GO
ALTER TABLE [dbo].[dbug_animal] CHECK CONSTRAINT [FK_dbug_animal_keeper_keeperId]
GO
ALTER TABLE [dbo].[dbug_animalOwner]  WITH CHECK ADD  CONSTRAINT [FK_dbug_animalOwner_dbug_animal_AnimalId] FOREIGN KEY([AnimalId])
REFERENCES [dbo].[dbug_animal] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[dbug_animalOwner] CHECK CONSTRAINT [FK_dbug_animalOwner_dbug_animal_AnimalId]
GO
ALTER TABLE [dbo].[dbug_animalOwner]  WITH CHECK ADD  CONSTRAINT [FK_dbug_animalOwner_dbug_ownerKeeper_OwnerId] FOREIGN KEY([OwnerId])
REFERENCES [dbo].[dbug_ownerKeeper] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[dbug_animalOwner] CHECK CONSTRAINT [FK_dbug_animalOwner_dbug_ownerKeeper_OwnerId]
GO
ALTER TABLE [dbo].[dbug_breedAnimal]  WITH CHECK ADD  CONSTRAINT [FK_dbug_breedAnimal_dbug_Species_speciesId] FOREIGN KEY([speciesId])
REFERENCES [dbo].[dbug_Species] ([id])
GO
ALTER TABLE [dbo].[dbug_breedAnimal] CHECK CONSTRAINT [FK_dbug_breedAnimal_dbug_Species_speciesId]
GO
ALTER TABLE [dbo].[dbug_diseases]  WITH CHECK ADD  CONSTRAINT [FK_dbug_diseases_dbug_animal_AnimalRegistrationid] FOREIGN KEY([AnimalRegistrationid])
REFERENCES [dbo].[dbug_animal] ([id])
GO
ALTER TABLE [dbo].[dbug_diseases] CHECK CONSTRAINT [FK_dbug_diseases_dbug_animal_AnimalRegistrationid]
GO
ALTER TABLE [dbo].[dbug_growthMonitoring]  WITH CHECK ADD  CONSTRAINT [FK_dbug_growthMonitoring_dbug_animal_animalRegistrationid] FOREIGN KEY([animalRegistrationid])
REFERENCES [dbo].[dbug_animal] ([id])
GO
ALTER TABLE [dbo].[dbug_growthMonitoring] CHECK CONSTRAINT [FK_dbug_growthMonitoring_dbug_animal_animalRegistrationid]
GO
ALTER TABLE [dbo].[dbug_healthCheckUp]  WITH CHECK ADD  CONSTRAINT [FK_dbug_healthCheckUp_dbug_animal_animalRegistrationid] FOREIGN KEY([animalRegistrationid])
REFERENCES [dbo].[dbug_animal] ([id])
GO
ALTER TABLE [dbo].[dbug_healthCheckUp] CHECK CONSTRAINT [FK_dbug_healthCheckUp_dbug_animal_animalRegistrationid]
GO
ALTER TABLE [dbo].[dbug_milkBaseNutrition]  WITH CHECK ADD  CONSTRAINT [FK_dbug_milkBaseNutrition_dbug_Species_SpeciesId] FOREIGN KEY([SpeciesId])
REFERENCES [dbo].[dbug_Species] ([id])
GO
ALTER TABLE [dbo].[dbug_milkBaseNutrition] CHECK CONSTRAINT [FK_dbug_milkBaseNutrition_dbug_Species_SpeciesId]
GO
ALTER TABLE [dbo].[dbug_milkRecord]  WITH CHECK ADD  CONSTRAINT [FK_dbug_milkRecord_dbug_animal_animalRegistrationid] FOREIGN KEY([animalRegistrationid])
REFERENCES [dbo].[dbug_animal] ([id])
GO
ALTER TABLE [dbo].[dbug_milkRecord] CHECK CONSTRAINT [FK_dbug_milkRecord_dbug_animal_animalRegistrationid]
GO
ALTER TABLE [dbo].[dbug_milkRecord]  WITH CHECK ADD  CONSTRAINT [FK_dbug_milkRecord_lab_labId] FOREIGN KEY([labId])
REFERENCES [dbo].[lab] ([id])
GO
ALTER TABLE [dbo].[dbug_milkRecord] CHECK CONSTRAINT [FK_dbug_milkRecord_lab_labId]
GO
ALTER TABLE [dbo].[dbug_ownerKeeper]  WITH CHECK ADD  CONSTRAINT [FK_dbug_ownerKeeper_dbug_farm_farmid] FOREIGN KEY([farmid])
REFERENCES [dbo].[dbug_farm] ([id])
GO
ALTER TABLE [dbo].[dbug_ownerKeeper] CHECK CONSTRAINT [FK_dbug_ownerKeeper_dbug_farm_farmid]
GO
ALTER TABLE [dbo].[dbug_pregnancyBaseNutrition]  WITH CHECK ADD  CONSTRAINT [FK_dbug_pregnancyBaseNutrition_dbug_Species_speciesId] FOREIGN KEY([speciesId])
REFERENCES [dbo].[dbug_Species] ([id])
GO
ALTER TABLE [dbo].[dbug_pregnancyBaseNutrition] CHECK CONSTRAINT [FK_dbug_pregnancyBaseNutrition_dbug_Species_speciesId]
GO
ALTER TABLE [dbo].[dbug_registerServiceProvider]  WITH CHECK ADD  CONSTRAINT [FK_dbug_registerServiceProvider_dbug_ai_Aiid] FOREIGN KEY([Aiid])
REFERENCES [dbo].[dbug_ai] ([id])
GO
ALTER TABLE [dbo].[dbug_registerServiceProvider] CHECK CONSTRAINT [FK_dbug_registerServiceProvider_dbug_ai_Aiid]
GO
ALTER TABLE [dbo].[dbug_registerServiceProvider]  WITH CHECK ADD  CONSTRAINT [FK_dbug_registerServiceProvider_dbug_calving_Calvingid] FOREIGN KEY([Calvingid])
REFERENCES [dbo].[dbug_calving] ([id])
GO
ALTER TABLE [dbo].[dbug_registerServiceProvider] CHECK CONSTRAINT [FK_dbug_registerServiceProvider_dbug_calving_Calvingid]
GO
ALTER TABLE [dbo].[dbug_registerServiceProvider]  WITH CHECK ADD  CONSTRAINT [FK_dbug_registerServiceProvider_dbug_pregnancyDiagnosis_PregnencyDiagnosisid] FOREIGN KEY([PregnencyDiagnosisid])
REFERENCES [dbo].[dbug_pregnancyDiagnosis] ([id])
GO
ALTER TABLE [dbo].[dbug_registerServiceProvider] CHECK CONSTRAINT [FK_dbug_registerServiceProvider_dbug_pregnancyDiagnosis_PregnencyDiagnosisid]
GO
ALTER TABLE [dbo].[dbug_registerServiceProvider]  WITH CHECK ADD  CONSTRAINT [FK_dbug_registerServiceProvider_dbug_pregnancyTermination_PregnencyTerminationid] FOREIGN KEY([PregnencyTerminationid])
REFERENCES [dbo].[dbug_pregnancyTermination] ([id])
GO
ALTER TABLE [dbo].[dbug_registerServiceProvider] CHECK CONSTRAINT [FK_dbug_registerServiceProvider_dbug_pregnancyTermination_PregnencyTerminationid]
GO
ALTER TABLE [dbo].[dbug_responsibleCollectorRegister]  WITH CHECK ADD  CONSTRAINT [FK_dbug_responsibleCollectorRegister_dbug_semenCollection_SemenCollectionid] FOREIGN KEY([SemenCollectionid])
REFERENCES [dbo].[dbug_semenCollection] ([id])
GO
ALTER TABLE [dbo].[dbug_responsibleCollectorRegister] CHECK CONSTRAINT [FK_dbug_responsibleCollectorRegister_dbug_semenCollection_SemenCollectionid]
GO
ALTER TABLE [dbo].[dbug_semenCollectionCenter]  WITH CHECK ADD  CONSTRAINT [FK_dbug_semenCollectionCenter_dbug_semenCollection_SemenCollectionid] FOREIGN KEY([SemenCollectionid])
REFERENCES [dbo].[dbug_semenCollection] ([id])
GO
ALTER TABLE [dbo].[dbug_semenCollectionCenter] CHECK CONSTRAINT [FK_dbug_semenCollectionCenter_dbug_semenCollection_SemenCollectionid]
GO
ALTER TABLE [dbo].[dbug_Species]  WITH CHECK ADD  CONSTRAINT [FK_dbug_Species_dbug_Species_Speciesid] FOREIGN KEY([Speciesid])
REFERENCES [dbo].[dbug_Species] ([id])
GO
ALTER TABLE [dbo].[dbug_Species] CHECK CONSTRAINT [FK_dbug_Species_dbug_Species_Speciesid]
GO
ALTER TABLE [dbo].[dbug_vaccination]  WITH CHECK ADD  CONSTRAINT [FK_dbug_vaccination_dbug_vaccinationSubType_vaccinationSubTypeId] FOREIGN KEY([vaccinationSubTypeId])
REFERENCES [dbo].[dbug_vaccinationSubType] ([id])
GO
ALTER TABLE [dbo].[dbug_vaccination] CHECK CONSTRAINT [FK_dbug_vaccination_dbug_vaccinationSubType_vaccinationSubTypeId]
GO
ALTER TABLE [dbo].[dbug_vaccination]  WITH CHECK ADD  CONSTRAINT [FK_dbug_vaccination_dbug_vaccinationType_vaccinationTypeid] FOREIGN KEY([vaccinationTypeid])
REFERENCES [dbo].[dbug_vaccinationType] ([id])
GO
ALTER TABLE [dbo].[dbug_vaccination] CHECK CONSTRAINT [FK_dbug_vaccination_dbug_vaccinationType_vaccinationTypeid]
GO
ALTER TABLE [dbo].[dbug_vaccinationAnimal]  WITH CHECK ADD  CONSTRAINT [FK_dbug_vaccinationAnimal_dbug_animal_animalRegistrationid] FOREIGN KEY([animalRegistrationid])
REFERENCES [dbo].[dbug_animal] ([id])
GO
ALTER TABLE [dbo].[dbug_vaccinationAnimal] CHECK CONSTRAINT [FK_dbug_vaccinationAnimal_dbug_animal_animalRegistrationid]
GO
ALTER TABLE [dbo].[dbug_vaccinationAnimal]  WITH CHECK ADD  CONSTRAINT [FK_dbug_vaccinationAnimal_dbug_diseases_diseasesId] FOREIGN KEY([diseasesId])
REFERENCES [dbo].[dbug_diseases] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[dbug_vaccinationAnimal] CHECK CONSTRAINT [FK_dbug_vaccinationAnimal_dbug_diseases_diseasesId]
GO
ALTER TABLE [dbo].[dbug_vaccinationAnimal]  WITH CHECK ADD  CONSTRAINT [FK_dbug_vaccinationAnimal_dbug_vaccination_vaccinationid] FOREIGN KEY([vaccinationid])
REFERENCES [dbo].[dbug_vaccination] ([id])
GO
ALTER TABLE [dbo].[dbug_vaccinationAnimal] CHECK CONSTRAINT [FK_dbug_vaccinationAnimal_dbug_vaccination_vaccinationid]
GO
ALTER TABLE [dbo].[dbug_vaccinationSubType]  WITH CHECK ADD  CONSTRAINT [FK_dbug_vaccinationSubType_dbug_vaccinationType_VaccinationTypeId] FOREIGN KEY([VaccinationTypeId])
REFERENCES [dbo].[dbug_vaccinationType] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[dbug_vaccinationSubType] CHECK CONSTRAINT [FK_dbug_vaccinationSubType_dbug_vaccinationType_VaccinationTypeId]
GO
ALTER TABLE [dbo].[keeper]  WITH CHECK ADD  CONSTRAINT [FK_keeper_dbug_farm_farmid] FOREIGN KEY([farmid])
REFERENCES [dbo].[dbug_farm] ([id])
GO
ALTER TABLE [dbo].[keeper] CHECK CONSTRAINT [FK_keeper_dbug_farm_farmid]
GO
