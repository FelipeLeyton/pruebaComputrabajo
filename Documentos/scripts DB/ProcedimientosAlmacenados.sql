USE [Redarbor]
GO
/****** Object:  StoredProcedure [dbo].[SP_DeleteEmployee]    Script Date: 3/10/2022 12:22:21 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_DeleteEmployee]
	@EmployeeId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	DELETE FROM [dbo].[Employees] WHERE [EmployeeId] = @EmployeeId
END
GO
/****** Object:  StoredProcedure [dbo].[SP_GetEmployee]    Script Date: 3/10/2022 12:22:21 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_GetEmployee] 
	@EmployeeId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT 
	   [EmployeeId]
	  ,[CompanyId]
      ,[CreatedOn]
      ,[DeletedOn]
      ,[Email]
      ,[Fax]
      ,[Name]
      ,[Lastlogin]
      ,[Password]
      ,[PortalId]
      ,[RoleId]
      ,[StatusId]
      ,[Telephone]
      ,[UpdatedOn]
      ,[Username]
	FROM
		[dbo].[Employees]
	WHERE
		[EmployeeId] = @EmployeeId
END
GO
/****** Object:  StoredProcedure [dbo].[SP_GetEmployeeId]    Script Date: 3/10/2022 12:22:21 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_GetEmployeeId]
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT TOP 1
		[EmployeeId]
	FROM
		[dbo].[Employees]
	ORDER BY 1 DESC
END
GO
/****** Object:  StoredProcedure [dbo].[SP_GetEmployees]    Script Date: 3/10/2022 12:22:21 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_GetEmployees] 
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT 
	   [EmployeeId]
	  ,[CompanyId]
      ,[CreatedOn]
      ,[DeletedOn]
      ,[Email]
      ,[Fax]
      ,[Name]
      ,[Lastlogin]
      ,[Password]
      ,[PortalId]
      ,[RoleId]
      ,[StatusId]
      ,[Telephone]
      ,[UpdatedOn]
      ,[Username]
	FROM
		[dbo].[Employees]
END
GO
/****** Object:  StoredProcedure [dbo].[SP_PostEmployee]    Script Date: 3/10/2022 12:22:21 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_PostEmployee]
	@CompanyId int,
    @CreatedOn date,
    @DeletedOn date,
    @Email varchar(50),
    @Fax varchar(20),
    @Name varchar(50),
    @Lastlogin date,
    @Password varchar(50),
    @PortalId int,
    @RoleId int,
    @StatusId int,
    @Telephone varchar(20),
    @UpdatedOn date,
    @Username varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO [dbo].[Employees]
	(
		[CompanyId]
       ,[CreatedOn]
       ,[DeletedOn]
       ,[Email]
       ,[Fax]
       ,[Name]
       ,[Lastlogin]
       ,[Password]
       ,[PortalId]
       ,[RoleId]
       ,[StatusId]
       ,[Telephone]
       ,[UpdatedOn]
       ,[Username]
	)
	VALUES
	(
		@CompanyId,
		@CreatedOn,
		@DeletedOn,
		@Email,
		@Fax,
		@Name,
		@Lastlogin,
		@Password,
		@PortalId,
		@RoleId,
		@StatusId,
		@Telephone,
		@UpdatedOn,
		@Username
	)
END
GO
/****** Object:  StoredProcedure [dbo].[SP_PutEmployee]    Script Date: 3/10/2022 12:22:21 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_PutEmployee] 
	@EmployeeId int,
	@CompanyId int,
	@CreatedOn date,
    @DeletedOn date,
    @Email varchar(50),
    @Fax varchar(20),
    @Name varchar(50),
    @Lastlogin date,
    @Password varchar(50),
    @PortalId int,
    @RoleId int,
    @StatusId int,
    @Telephone varchar(20),
    @UpdatedOn date,
    @Username varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE [dbo].[Employees]
	SET 
		[CompanyId] = @CompanyId
       ,[CreatedOn] = @CreatedOn
       ,[DeletedOn] = @DeletedOn
       ,[Email] = @Email
       ,[Fax] = @Fax
       ,[Name] = @Name
       ,[Lastlogin] = @Lastlogin
       ,[Password] = @Password
       ,[PortalId] = @PortalId
       ,[RoleId] = @RoleId
       ,[StatusId] = @StatusId
       ,[Telephone] = @Telephone
       ,[UpdatedOn] = @UpdatedOn
       ,[Username] = @Username
	WHERE
		[EmployeeId] = @EmployeeId
END
GO
