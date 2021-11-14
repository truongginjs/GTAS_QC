using QCService.Models.D01;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QCService.Helpers
{
    public static class SeedStoreProcedure
    {

		public static string CreateSP_QCDetail()
        {
			var sql = @"
CREATE PROCEDURE [dbo].[sp_QCDetail]
(
    @Active VARCHAR(255),
    @UserID VARCHAR(36) = NULL,
    @jsParam VARBINARY(MAX) = NULL,
    @IsCompress INT = 1,
    @ReturnMess NVARCHAR(255) = NULL OUTPUT
)
AS
BEGIN
    DECLARE @jsonResult NVARCHAR(MAX);
	DECLARE @js NVARCHAR(MAX);
    SET DATEFORMAT MDY;

	DECLARE @Id UNIQUEIDENTIFIER;

    IF (@Active = 'Find')
    BEGIN
        DECLARE @ZoneTypeId UNIQUEIDENTIFIER,
                @StringSearch NVARCHAR(125) = N'',
                @FromDate DATE,
                @ToDate DATE;

        SET @js = CAST(DECOMPRESS(@jsParam) AS NVARCHAR(MAX));


        SELECT @ZoneTypeId = ZoneTypeId,
               @StringSearch = StringSearch,
               @FromDate = FromDate,
               @ToDate = ToDate
        FROM
            OPENJSON(@js)
            WITH
            (
                ZoneTypeId UNIQUEIDENTIFIER '$.ZoneTypeId',
                StringSearch NVARCHAR(MAX) '$.StringSearch',
                FromDate DATETIME '$.FromDate',
                ToDate DATETIME '$.ToDate'
            );


        IF NOT OBJECT_ID('tempdb.dbo.#Filtered', 'U') IS NULL
            DROP TABLE #Filtered;
        SELECT a.Id
        INTO #Filtered
        FROM dbo.D01_QCDetail a (NOLOCK)
            LEFT JOIN dbo.D01_QCRequest b (NOLOCK)
                ON b.Id = a.Id
        WHERE 1 = 1
              AND (CONVERT(DATE, b.QCRequestDate)
              BETWEEN CONVERT(DATE, @FromDate) AND CONVERT(DATE, @ToDate)
                  )
              AND b.ZoneTypeId = @ZoneTypeId
              AND b.IsDeleted = 0
              AND
              (
                  a.Code LIKE '%' + @StringSearch + '%'
                  OR a.Name LIKE '%' + @StringSearch + '%'
                  OR b.QCNumber LIKE '%' + @StringSearch + '%'
              );


        SET @jsonResult =
        (
            SELECT a.Id,
                   (
                       SELECT *
                       FROM dbo.D01_QCRequest AS QCRequest
                       WHERE QCRequest.Id = a.Id
                       FOR JSON PATH
                   ) AS QCRequestJson,
                   a.Code,
                   a.Name,
                   a.ProductLine,
                   a.DefectAQLJson,
                   a.DefectSizeBreakDownJson,
                   a.DefectsReasonAndSolutionsJson,
                   a.PrivateDetailJson,
                   (
                       SELECT a1.IsDeleted FROM dbo.D01_QCRequest AS a1 WHERE a1.Id = a.Id
                   ) AS IsDeleted
            FROM dbo.D01_QCDetail a (NOLOCK)
            WHERE a.Id IN
                  (
                      SELECT b.Id FROM #Filtered AS b
                  )
            FOR JSON PATH
        );

        IF (@IsCompress = CAST(1 AS BIT))
            SELECT JsbData = COMPRESS(@jsonResult);
        ELSE
            SELECT JsbData = @jsonResult;
    END;

	IF (@Active = 'Get')
    BEGIN
        SET @js = CAST(DECOMPRESS(@jsParam) AS NVARCHAR(MAX));


        SELECT @Id = Id
        FROM
            OPENJSON(@js)
            WITH
            (
                Id UNIQUEIDENTIFIER '$.Id'
            );

        SET @jsonResult =
        (
            SELECT a.Id,
                   (
                       SELECT *
                       FROM dbo.D01_QCRequest AS QCRequest
                       WHERE QCRequest.Id = a.Id
                       FOR JSON PATH
                   ) AS QCRequestJson,
                   a.Code,
                   a.Name,
                   a.ProductLine,
                   a.DefectAQLJson,
                   a.DefectSizeBreakDownJson,
                   a.DefectsReasonAndSolutionsJson,
                   a.PrivateDetailJson,
                   (
                       SELECT a1.IsDeleted FROM dbo.D01_QCRequest AS a1 WHERE a1.Id = a.Id
                   ) AS IsDeleted
            FROM dbo.D01_QCDetail a (NOLOCK)
            WHERE a.Id = @Id
            FOR JSON PATH
        );

        IF (@IsCompress = CAST(1 AS BIT))
            SELECT JsbData = COMPRESS(@jsonResult);
        ELSE
            SELECT JsbData = @jsonResult;
    END;

	IF (@Active = 'Delete')
    BEGIN
        SET @js = CAST(DECOMPRESS(@jsParam) AS NVARCHAR(MAX));


        SELECT @Id = Id
        FROM
            OPENJSON(@js)
            WITH
            (
                Id UNIQUEIDENTIFIER '$.Id'
            );

        IF NOT OBJECT_ID('tempdb.dbo.#SourceTbl', 'U') IS NULL
            DROP TABLE #SourceTbl;
        SELECT Id,
               UpdateUserId,
               UpdateDate,
               IsDeleted
        INTO #SourceTbl
        FROM dbo.D01_QCRequest
        WHERE Id = @Id;

        BEGIN TRY
            BEGIN TRANSACTION;
            UPDATE dbo.D01_QCRequest SET IsDeleted = 1 WHERE Id = @Id;
			UPDATE dbo.D01_QCRequest SET UpdateUserId = @UserID WHERE Id = @Id;
			UPDATE dbo.D01_QCRequest SET UpdateDate = GETDATE() WHERE Id = @Id;

            SET @jsonResult =
            (
                SELECT a.Id,
                       (
                           SELECT *
                           FROM dbo.D01_QCRequest AS QCRequest
                           WHERE QCRequest.Id = a.Id
                           FOR JSON PATH
                       ) AS QCRequestJson,
                       a.Code,
                       a.Name,
                       a.ProductLine,
                       a.DefectAQLJson,
                       a.DefectSizeBreakDownJson,
                       a.DefectsReasonAndSolutionsJson,
                       a.PrivateDetailJson,
                       (
                           SELECT a1.IsDeleted FROM dbo.D01_QCRequest AS a1 WHERE a1.Id = a.Id
                       ) AS IsDeleted
                FROM dbo.D01_QCDetail a (NOLOCK)
                WHERE a.Id = @Id
                FOR JSON PATH
            );
            IF (@IsCompress = CAST(1 AS BIT))
                SELECT JsbData = COMPRESS(@jsonResult);
            ELSE
                SELECT JsbData = @jsonResult;
            COMMIT TRANSACTION;

        END TRY
        BEGIN CATCH
            --select SUSER_SNAME(),ERROR_NUMBER(),ERROR_STATE(),ERROR_SEVERITY(),ERROR_LINE(),ERROR_PROCEDURE(),ERROR_MESSAGE(),GETDATE();
            IF (XACT_STATE()) = -1
                ROLLBACK TRANSACTION;
            IF (XACT_STATE()) = 1
                COMMIT TRANSACTION;
        END CATCH;
    END;

	IF (@Active = 'Save')
    BEGIN
        SET @js = CAST(DECOMPRESS(@jsParam) AS NVARCHAR(MAX));

        IF NOT OBJECT_ID('tempdb.dbo.#QCDetail', 'U') IS NULL
            DROP TABLE #QCDetail;
        SELECT TOP 1
               Id,
               QCRequestJson,
               Code,
               Name,
               ProductLine,
               DefectAQLJson,
               DefectSizeBreakDownJson,
               DefectsReasonAndSolutionsJson,
               PrivateDetailJson
        INTO #QCDetail
        FROM
            OPENJSON(@js)
            WITH
            (
                Id UNIQUEIDENTIFIER '$.Id',
                QCRequestJson NVARCHAR(MAX) '$.QCRequestJson',
                Code NVARCHAR(255) '$.Code',
                Name NVARCHAR(500) '$.Name',
                ProductLine NVARCHAR(MAX) '$.ProductLine',
                DefectAQLJson NVARCHAR(MAX) '$.DefectAQLJson',
                DefectSizeBreakDownJson NVARCHAR(MAX) '$.DefectSizeBreakDownJson',
                DefectsReasonAndSolutionsJson NVARCHAR(MAX) '$.DefectsReasonAndSolutionsJson',
                PrivateDetailJson NVARCHAR(MAX) '$.PrivateDetailJson'
            );

        DECLARE @jsQCRequest NVARCHAR(MAX);
        SELECT @jsQCRequest = QCDetail.QCRequestJson
        FROM #QCDetail QCDetail;

        IF NOT OBJECT_ID('tempdb.dbo.#QCRequest', 'U') IS NULL
            DROP TABLE #QCRequest;
        SELECT Id,
               ZoneTypeId,
               QCNumber,
               GRNNumber,
               Category,
               ArticleCode,
               ArticleName,
               QCRequestDate,
               StyleName,
               StyleCode,
               OCNumber,
               QCDefinition,
               SamplePlan,
               SamplePercentage,
               ColorCode,
               ColorName,
               QCType,
               SizeBreakDownsJson,
               UserApproveId,
               Status,
               Description,
               CreateUserId,
               CreateDate,
               UpdateUserId,
               UpdateDate,
               IsDeleted
        INTO #QCRequest
        FROM
            OPENJSON(@js)
            WITH
            (
                Id UNIQUEIDENTIFIER '$.Id',
                ZoneTypeId UNIQUEIDENTIFIER '$.ZoneTypeId',
                QCNumber NVARCHAR(25) '$.QCNumber',
                GRNNumber NVARCHAR(25) '$.GRNNumber',
                Category NVARCHAR(25) '$.Category',
                ArticleCode NVARCHAR(255) '$.ArticleCode',
                ArticleName NVARCHAR(255) '$.ArticleName',
                QCRequestDate DATETIME2(7) '$.QCRequestDate',
                StyleName NVARCHAR(255) '$.StyleName',
                StyleCode NVARCHAR(255) '$.StyleCode',
                OCNumber NVARCHAR(255) '$.OCNumber',
                QCDefinition NVARCHAR(255) '$.QCDefinition',
                SamplePlan NVARCHAR(255) '$.SamplePlan',
                SamplePercentage INT '$.SamplePercentage',
                ColorCode NVARCHAR(255) '$.ColorCode',
                ColorName NVARCHAR(25) '$.ColorName',
                QCType NVARCHAR(15) '$.QCType',
                SizeBreakDownsJson NVARCHAR(MAX) '$.SizeBreakDownsJson',
                UserApproveId INT '$.UserApproveId',
                Status INT '$.Status',
                Description NVARCHAR(500) '$.Description',
                CreateUserId INT '$.CreateUserId',
                CreateDate DATETIME2(7) '$.CreateDate',
                UpdateUserId INT '$.UpdateUserId',
                UpdateDate DATETIME2(7) '$.UpdateDate',
                IsDeleted BIT '$.IsDeleted'
            );

        SELECT @Id = QCDetail.Id
        FROM #QCDetail QCDetail;



        --------------------------Check lock on JsOperationList -Group Operation----------------------------------------



        ----------------------------------------------------------------------------------------------------------------
        BEGIN TRY
            BEGIN TRANSACTION;
            WITH QCDetailTarget
            AS (SELECT qct.Id,
                       qct.Code,
                       qct.Name,
                       qct.ProductLine,
                       qct.DefectAQLJson,
                       qct.DefectSizeBreakDownJson,
                       qct.DefectsReasonAndSolutionsJson,
                       qct.PrivateDetailJson
                FROM dbo.D01_QCDetail qct WITH (NOLOCK)
                WHERE qct.Id = @Id)
            MERGE QCDetailTarget AS TARGET
            USING #QCDetail AS SOURCE
            ON (TARGET.Id = SOURCE.Id)
            WHEN MATCHED AND (SOURCE.Code IS NOT NULL) THEN
                UPDATE SET TARGET.Code = ISNULL(SOURCE.Code, TARGET.Code),
                           TARGET.Name = ISNULL(SOURCE.Name, TARGET.Name),
                           TARGET.ProductLine = ISNULL(SOURCE.ProductLine, TARGET.ProductLine),
                           TARGET.DefectAQLJson = ISNULL(SOURCE.DefectAQLJson, TARGET.DefectAQLJson),
                           TARGET.DefectSizeBreakDownJson = ISNULL(
                                                                      SOURCE.DefectSizeBreakDownJson,
                                                                      TARGET.DefectSizeBreakDownJson
                                                                  ),
                           TARGET.DefectsReasonAndSolutionsJson = ISNULL(
                                                                            SOURCE.DefectsReasonAndSolutionsJson,
                                                                            TARGET.DefectsReasonAndSolutionsJson
                                                                        ),
                           TARGET.PrivateDetailJson = ISNULL(SOURCE.PrivateDetailJson, TARGET.PrivateDetailJson)
            WHEN NOT MATCHED BY TARGET AND (SOURCE.Code IS NOT NULL) THEN
                INSERT
                (
                    Id,
                    Code,
                    Name,
                    ProductLine,
                    DefectAQLJson,
                    DefectSizeBreakDownJson,
                    DefectsReasonAndSolutionsJson,
                    PrivateDetailJson
                )
                VALUES
                (SOURCE.Id, SOURCE.Code, SOURCE.Name, SOURCE.ProductLine, SOURCE.DefectAQLJson,
                 SOURCE.DefectSizeBreakDownJson, SOURCE.DefectsReasonAndSolutionsJson, SOURCE.PrivateDetailJson)
            OUTPUT $action;
            --INTO @tblOutput
            --(
            --    TAction
            --);

            --OUTPUT DELETED., $action AS [Action], INSERTED. into ##TY


            --COMMIT TRANSACTION

            --SELECT @ReturnMess = TAction
            --FROM @tblOutput;
            --SELECT @jsFilter = CONCAT(N'{""processId"":""', @processId, '""}');


            WITH QCRequestTarget
            AS(SELECT qcr.Id,
                       qcr.ZoneTypeId,
                       qcr.QCNumber,
                       qcr.GRNNumber,
                       qcr.Category,
                       qcr.ArticleCode,
                       qcr.ArticleName,
                       qcr.QCRequestDate,
                       qcr.StyleName,
                       qcr.StyleCode,
                       qcr.OCNumber,
                       qcr.QCDefinition,
                       qcr.SamplePlan,
                       qcr.SamplePercentage,
                       qcr.ColorCode,
                       qcr.ColorName,
                       qcr.QCType,
                       qcr.SizeBreakDownsJson,
                       qcr.UserApproveId,
                       qcr.Status,
                       qcr.Description,
                       qcr.CreateUserId,
                       qcr.CreateDate,
                       qcr.UpdateUserId,
                       qcr.UpdateDate,
                       qcr.IsDeleted
                FROM dbo.D01_QCRequest qcr WITH(NOLOCK)
                WHERE qcr.Id = @Id)
            MERGE QCRequestTarget AS TARGET
            USING #QCRequest AS SOURCE
            ON(TARGET.Id = SOURCE.Id)
            WHEN MATCHED AND(SOURCE.QCNumber IS NOT NULL) THEN
               UPDATE SET TARGET.QCNumber = ISNULL(SOURCE.QCNumber, TARGET.QCNumber),
                           TARGET.GRNNumber = ISNULL(SOURCE.GRNNumber, TARGET.GRNNumber),
                           TARGET.Category = ISNULL(SOURCE.Category, TARGET.Category),
                           TARGET.ArticleCode = ISNULL(SOURCE.ArticleCode, TARGET.ArticleCode),
                           TARGET.ArticleName = ISNULL(SOURCE.ArticleName, TARGET.ArticleName),
                           TARGET.QCRequestDate = ISNULL(SOURCE.QCRequestDate, TARGET.QCRequestDate),
                           TARGET.StyleName = ISNULL(SOURCE.StyleName, TARGET.StyleName),
                           TARGET.StyleCode = ISNULL(SOURCE.StyleCode, TARGET.StyleCode),
                           TARGET.OCNumber = ISNULL(SOURCE.OCNumber, TARGET.OCNumber),
                           TARGET.QCDefinition = ISNULL(SOURCE.QCDefinition, TARGET.QCDefinition),
                           TARGET.SamplePlan = ISNULL(SOURCE.SamplePlan, TARGET.SamplePlan),
                           TARGET.SamplePercentage = ISNULL(SOURCE.SamplePercentage, TARGET.SamplePercentage),
                           TARGET.ColorCode = ISNULL(SOURCE.ColorCode, TARGET.ColorCode),
                           TARGET.ColorName = ISNULL(SOURCE.ColorName, TARGET.ColorName),
                           TARGET.QCType = ISNULL(SOURCE.QCType, TARGET.QCType),
                           TARGET.SizeBreakDownsJson = ISNULL(SOURCE.SizeBreakDownsJson, TARGET.SizeBreakDownsJson),
                           TARGET.UserApproveId = ISNULL(SOURCE.UserApproveId, TARGET.UserApproveId),
                           TARGET.Status = ISNULL(SOURCE.Status, TARGET.Status),
                           TARGET.Description = ISNULL(SOURCE.Description, TARGET.Description),
                           TARGET.CreateUserId = ISNULL(SOURCE.CreateUserId, TARGET.CreateUserId),
                           TARGET.CreateDate = ISNULL(SOURCE.CreateDate, TARGET.CreateDate),
                           TARGET.UpdateUserId = @UserID,
                           TARGET.UpdateDate = GETDATE(),
                           TARGET.IsDeleted = ISNULL(SOURCE.IsDeleted, TARGET.IsDeleted)
            WHEN NOT MATCHED BY TARGET AND(SOURCE.Code IS NOT NULL) THEN
                INSERT
                (
                    Id,
                    ZoneTypeId,
                    QCNumber,
                    GRNNumber,
                    Category,
                    ArticleCode,
                    ArticleName,
                    QCRequestDate,
                    StyleName,
                    StyleCode,
                    OCNumber,
                    QCDefinition,
                    SamplePlan,
                    SamplePercentage,
                    ColorCode,
                    ColorName,
                    QCType,
                    SizeBreakDownsJson,
                    UserApproveId,
                    Status,
                    Description,
                    CreateUserId,
                    CreateDate,
                    UpdateUserId,
                    UpdateDate,
                    IsDeleted
                )
                VALUES
                (SOURCE.Id, SOURCE.ZoneTypeId, SOURCE.QCNumber, SOURCE.GRNNumber, SOURCE.Category, SOURCE.ArticleCode,
                 SOURCE.ArticleName, SOURCE.QCRequestDate, SOURCE.StyleName, SOURCE.StyleCode, SOURCE.OCNumber,
                 SOURCE.QCDefinition, SOURCE.SamplePlan, SOURCE.SamplePercentage, SOURCE.ColorCode, SOURCE.ColorName,
                 SOURCE.QCType, SOURCE.SizeBreakDownsJson, SOURCE.UserApproveId, SOURCE.Status, SOURCE.Description,
                 @UserID, GETDATE(), @UserID, GETDATE(), 0)
            OUTPUT $action;
            --INTO @tblOutput
            --(
            --TAction
            --);

            --OUTPUT DELETED., $action AS[Action], INSERTED. into ##TY


            --COMMIT TRANSACTION

            --SELECT @ReturnMess = TAction
            --FROM @tblOutput;
            --SELECT @jsFilter = CONCAT(N'{""processId"":""', @processId, '""}');





            SELECT @jsonResult =
            (
                SELECT a.Id,
            (
                SELECT *
                FROM dbo.D01_QCRequest AS QCRequest
                WHERE QCRequest.Id = a.Id
                FOR JSON PATH
            )          AS QCRequestJson,
                       a.Code,
                       a.Name,
                       a.ProductLine,
                       a.DefectAQLJson,
                       a.DefectSizeBreakDownJson,
                       a.DefectsReasonAndSolutionsJson,
                       a.PrivateDetailJson,
            (
                SELECT a1.IsDeleted FROM dbo.D01_QCRequest AS a1 WHERE a1.Id = a.Id
            )          AS IsDeleted
                FROM dbo.D01_QCDetail a(NOLOCK)
                WHERE a.Id = @Id
                FOR JSON PATH
            );
            IF(@IsCompress = CAST(1 AS BIT))
                SELECT JsbData = COMPRESS(@jsonResult);
            ELSE
                SELECT JsbData = @jsonResult;
            COMMIT TRANSACTION;

            END TRY
        BEGIN CATCH
            --select SUSER_SNAME(),ERROR_NUMBER(),ERROR_STATE(),ERROR_SEVERITY(),ERROR_LINE(),ERROR_PROCEDURE(),ERROR_MESSAGE(),GETDATE();
            IF(XACT_STATE()) = -1
                ROLLBACK TRANSACTION;
            IF(XACT_STATE()) = 1
                COMMIT TRANSACTION;
            END CATCH;
            END;
            END;
            ";
			return sql;
        }

        public static string CreateSPQCRequest()
        {
            var type = typeof(QCRequest);
            var fields = new string[] {
                "Id",
                "ZoneTypeId",
                "QCNumber",
                "GRNNumber",
                "Category",
                "ArticleCode",
                "ArticleName",
                "QCRequestDate",
                "StyleName",
                "StyleCode",
                "OCNumber",
                "QCDefinition",
                "SamplePlan",
                "SamplePercentage",
                "ColorCode",
                "ColorName",
                "QCType",
                "SizeBreakDownsJson",
                "UserApproveId",
                "Status",
                "Description",
                "CreateUserId",
                "CreateDate",
                "UpdateUserId",
                "UpdateDate"
            };
            fields = fields.Select(x => $"[{x}]").ToArray();
            var saveFields = fields;
            var updateFields = fields;
            var addFields = fields;
            var tableName = (type.GetCustomAttributes(typeof(TableAttribute), false).FirstOrDefault() as TableAttribute)?.Name;    //    var templateField = col.GetCustomAttributes(typeof(TemplateFieldAttribute), false).FirstOrDefault() as TemplateFieldAttribute;

            var sql = $@"
CREATE proc [dbo].[sp_{type.Name}] (
	@Active			varchar(255)      
	,@UserID		varchar(36) = null  
	,@jsParam		varbinary (max) = null
	,@IsCompress	int = 1
	,@ReturnMess	nvarchar(255)=null output
	)

AS
BEGIN
declare @tblOutput as table ( TAction nvarchar(400))
 declare @FromDate varchar(8),
 @ToDate varchar(8),
@QCNumber varchar(125),
@OCNumber varchar(125);

	Declare @Id nvarchar(50);
	DECLARE @jsInput nvarchar(max) = CAST(DECOMPRESS(@jsParam) as NVARCHAR(MAX));
	DECLARE @jsData nvarchar(Max)
	IF(@Active = 'Gets')
	BEGIN
		select	@FromDate = FromDate,
				@ToDate = ToDate,
				@QCNumber = QCNumber, 
				@OCNumber = OCNumber
		from  dbo.fn_Filter_Param(@jsInput)
		Select {string.Join(", ", fields)}
		into #ResultGets
		from {tableName}
		where 1=1
		and QCNumber like concat('%',@QCNumber,'%')
		and OCNumber like concat('%',@OCNumber,'%')
		and cast(FORMAT(QCRequestDate,'yyyyMMdd') as int) between @FromDate and @ToDate

		select @jsData = (select * from #ResultGets FOR JSON PATH)	

		IF(@ISCOMPRESS= cast (1 as bit ))   
			select JsbData=COMPRESS(@jsData) 
		ELSE 
			select JsbData=@JsData 
	END
	IF(@Active = 'Get')
	BEGIN
			select	@FromDate = FromDate,
				@ToDate = ToDate,
				@QCNumber = QCNumber, 
				@OCNumber = OCNumber
		from  dbo.fn_Filter_Param(@jsInput)
		Select {string.Join(", ", fields)}
		into #ResultGet
		from {tableName}
		where 1=1
		and QCNumber like concat('%',@QCNumber,'%')
		and OCNumber like concat('%',@OCNumber,'%')
		and cast(FORMAT(CreateDate,'yyyyMMdd') as int) between @FromDate and @ToDate

		select @jsData = (select * from #ResultGet FOR JSON PATH, WITHOUT_ARRAY_WRAPPER)	

		IF(@ISCOMPRESS= cast (1 as bit ))   
			select JsbData=COMPRESS(@jsData) 
		ELSE 
			select JsbData=@JsData 	
	END
	IF(@Active = 'Save')
	BEGIN
		drop table if exists #SaveSource;
		set @jsdata=cast(DECOMPRESS(@jsParam) as nvarchar(max));


		select {string.Join(", ", saveFields)}
		into #SaveSource
		from [dbo].[fn_{type.Name}Data](@jsdata)

		select top 1 @Id = [Id] from #SaveSource; 
		----------------------------------------------------------------------------------------------------------------
		BEGIN TRY
			BEGIN TRANSACTION
		
				;with SaveTarget as 
				(
					select {string.Join(",\n", saveFields)}
					from		{tableName} as ST with (nolock) 
					where		ST.Id=@Id
				)
				MERGE			SaveTarget	AS TARGET
				USING			#SaveSource	AS SOURCE  
				ON				(TARGET.[Id] = SOURCE.[Id])
					WHEN MATCHED and 1=1
						THEN UPDATE set 
							{string.Join(",\n", updateFields.Select(x => $"TARGET.{x}= ISNULL(SOURCE.{x}, TARGET.{x})"))}
					WHEN NOT MATCHED BY TARGET and 1=1
						THEN
							INSERT (
								{string.Join(",\n", addFields)}
							)
							Values (
								{string.Join(",\n", addFields.Select(x => $"SOURCE.{x}"))}
							)
				OUTPUT $action into @tblOutput(TAction);

				--OUTPUT DELETED.*, $action AS [Action], INSERTED.* into ##TY


				--COMMIT TRANSACTION

				select @ReturnMess=TAction from @tblOutput;


				select @jsData = (select top 1
										{string.Join(", ", fields)}
									FROM {tableName} 
									WHERE Id=@Id
									FOR JSON PATH, WITHOUT_ARRAY_WRAPPER
								);
			IF(@ISCOMPRESS = cast(1 as bit))  select JsbData = COMPRESS(@jsData) ELSE select JsbData = @JsData;
			COMMIT TRANSACTION


		END TRY
		BEGIN CATCH
			--select SUSER_SNAME(),ERROR_NUMBER(),ERROR_STATE(),ERROR_SEVERITY(),ERROR_LINE(),ERROR_PROCEDURE(),ERROR_MESSAGE(),GETDATE();
			IF(XACT_STATE()) = -1  ROLLBACK TRANSACTION;
			IF(XACT_STATE()) = 1   COMMIT TRANSACTION;
			END CATCH
	END
END
";
            return sql;
        }

        public static string CreateSP_FindFromWFX()
        {
            var sql = @"
/*
declare @b nvarchar(max)=N'{""FromDate"":""2021 - 09 - 01"",""Todate"":""2021 - 10 - 30"",""QCNumber"":""QC - FGFWPY2 - 1""}'
			--select *
			--from[fn_Filter_Param](@b)
declare @a varbinary(max) = COMPRESS(@b)
exec[sp_WFXQCRequest] @Active = 'Find', @jsParam = @a
 */

 create proc[dbo].[sp_WFXQCRequest](
	 @Active         varchar(255)
	 , @UserID        varchar(36) = null
	 , @jsParam       varbinary(max) = null
	 , @IsCompress    int = 1
	 , @ReturnMess    nvarchar(255) = null output
	 )

AS
BEGIN

	IF(@Active = 'Find')
	BEGIN
		SET DATEFORMAT MDY

		DROP TABLE IF EXISTS #T
		Create table #T (
			QCNumber varchar(100),
			GRNNumber varchar(100),
			Category nvarchar(max),
			ArticleCode varchar(60),
			ArticleName nvarchar(4000),
			QCRequestDate datetime,
			StyleName nvarchar(4000),
			StyleCode varchar(60),
			OCNumber varchar(50),
			QCDefinition varchar(50),
			SamplePlan varchar(50),
			SamplePercentage int,
			ColorCode varchar(50),
			ColorName varchar(120),
			SizeCode varchar(50),
			SizeName varchar(50),
			Shade varchar(50),
			QCQty decimal(38, 4),
			InspectionQty decimal(38, 4),
			QCType varchar(50)
		)
		DECLARE @sqlCommand nvarchar(MAX)
		DECLARE @QCNumber nvarchar(75),@QCStatus nvarchar(125),@QCCreatedFrom date, @QCCreatedTill date

		 declare @js nvarchar(max) = decompress(@jsParam)

		 -------------------------------------------------------------------------------------------------------- -


		 select @QCNumber = 'QC-FGFWPY2-1',
		@QCStatus = 'InProgress,Pending',
		@QCCreatedFrom = '2021-09-01',
		@QCCreatedTill = '2021-10-29'

		select
		@QCNumber = QCNumber,
		@QCCreatedFrom = FromDate,
		@QCCreatedTill = ToDate
		from[fn_Filter_Param](@js)

		SET @sqlCommand = 'Exec [172.16.39.173].[WFXPPJTEST].dbo.[xspAPIQCRequestGetDetail1] @QCStatus,@QCCreatedFrom,@QCCreatedTill,@Category,@QCNumber'

		insert into #T ([QCNumber],[GRNNumber],[Category],[ArticleCode],[ArticleName],[QCRequestDate],[StyleName],[StyleCode],[OCNumber],[QCDefinition],[SamplePlan],[SamplePercentage],[ColorCode],[ColorName],[SizeCode],[SizeName],[Shade],[QCQty],[InspectionQty],[QCType])
				
		EXECUTE sp_executesql @sqlCommand, N'@QCNumber varchar(75),@QCStatus varchar(125),@QCCreatedFrom datetime,@QCCreatedTill datetime,@Category varchar(25)',@QCNumber,@QCStatus,@QCCreatedFrom,@QCCreatedTill,@Category = ''


		select QCNumber, GRNNumber, Category, ArticleCode, ArticleName, QCRequestDate, StyleName, StyleCode, OCNumber
		, QCDefinition, SamplePlan, SamplePercentage, ColorCode, ColorName, QCType
		, SizeBreakDownsJson = concat('[', string_agg(CONCAT('{""SizeCode"":""', SizeCode, '"", ""SizeName"": ""', SizeName, '"", ""Shade"": ""', Shade, '"", ""QCQty"": ', QCQty, ', ""InspectionQty"": ', InspectionQty, '}'), ','), ']')
		from #T
		group by QCNumber,GRNNumber,Category,ArticleCode,ArticleName,QCRequestDate,StyleName,StyleCode,OCNumber
		,QCDefinition,SamplePlan,SamplePercentage,ColorCode,ColorName,QCType
	END
END
";
            return sql;
        }

		public static string DropSP_FindFromWFX()=> $"drop proc [dbo].[sp_WFXQCRequest]";

		public static string DropSP(Type type)
        {
            return $"drop proc [dbo].[sp_{type.Name}]";
        }
    }
}
