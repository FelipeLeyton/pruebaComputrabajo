USE [Redarbor]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 3/10/2022 12:21:32 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[EmployeeId] [int] IDENTITY(1,1) NOT NULL,
	[CompanyId] [int] NULL,
	[CreatedOn] [date] NULL,
	[DeletedOn] [date] NULL,
	[Email] [varchar](100) NULL,
	[Fax] [varchar](20) NULL,
	[Name] [varchar](50) NULL,
	[Lastlogin] [date] NULL,
	[Password] [varchar](50) NULL,
	[PortalId] [int] NULL,
	[RoleId] [int] NULL,
	[StatusId] [int] NULL,
	[Telephone] [varchar](20) NULL,
	[UpdatedOn] [date] NULL,
	[Username] [varchar](50) NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[EmployeeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
