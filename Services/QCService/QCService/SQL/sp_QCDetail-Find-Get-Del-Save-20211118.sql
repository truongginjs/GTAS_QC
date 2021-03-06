USE [GTAS_QC]
GO
/****** Object:  StoredProcedure [dbo].[sp_QCDetail]    Script Date: 11/18/2021 11:12:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
        DECLARE @FromDate DATE,
                @ToDate DATE,
                @ZoneTypeIdJson NVARCHAR(MAX),
                @SiteCodeJson NVARCHAR(MAX),
                @StringSearch NVARCHAR(MAX) = N'';

        SET @js = CAST(DECOMPRESS(@jsParam) AS NVARCHAR(MAX));


        IF NOT OBJECT_ID('tempdb.dbo.#FilterTable', 'U') IS NULL
            DROP TABLE #FilterTable;
        SELECT FromDate,
               ToDate,
               ZoneTypeIdJson,
               SiteCodeJson,
               StringSearch,
               SiteCode,
               ZoneTypeId
        INTO #FilterTable
        FROM
            OPENJSON(@js)
            WITH
            (
                FromDate DATETIME2 '$.FromDate',
                ToDate DATETIME2 '$.ToDate',
                ZoneTypeIdJson NVARCHAR(MAX) '$.ZoneTypeIds' AS JSON,
                SiteCodeJson NVARCHAR(MAX) '$.SiteCodes' AS JSON,
                StringSearch NVARCHAR(MAX) '$.StringSearch'
            )
            OUTER APPLY
            OPENJSON(SiteCodeJson)
            WITH
            (
                SiteCode NVARCHAR(MAX) '$'
            )
            OUTER APPLY
            OPENJSON(ZoneTypeIdJson)
            WITH
            (
                ZoneTypeId UNIQUEIDENTIFIER '$'
            );

        SELECT TOP 1
               @FromDate = a.FromDate,
               @ToDate = a.ToDate,
               @ZoneTypeIdJson = a.ZoneTypeIdJson,
               @SiteCodeJson = a.SiteCodeJson,
               @StringSearch = ISNULL(a.StringSearch, '')
        FROM #FilterTable a;

        SET @jsonResult =
        (
            SELECT a.Id,
                   a.ZoneTypeId,
                   a.QCNumber,
                   a.GRNNumber,
                   a.Category,
                   a.ArticleCode,
                   a.ArticleName,
                   a.QCRequestDate,
                   a.StyleName,
                   a.StyleCode,
                   a.OCNumber,
                   a.QCDefinition,
                   a.SamplePlan,
                   a.SamplePercentage,
                   a.ColorCode,
                   a.ColorName,
                   a.QCType,
                   a.UserApproveId,
                   a.TransferStatus,
                   a.Description,
                   a.CreateUserId,
                   a.CreateDate,
                   a.UpdateUserId,
                   a.UpdateDate,
                   a.IsDeleted,
                   a.Buyer,
                   a.DeliveryBuyerOrderRef,
                   a.DocStatus,
                   a.PONo,
                   a.QCQty,
                   a.Site,
                   a.Supplier
            FROM dbo.D01_QCRequest a
            WHERE 1 = 1
                  AND a.IsDeleted = 0
                  AND (CONVERT(DATE, a.QCRequestDate)
                  BETWEEN CONVERT(DATE, @FromDate) AND CONVERT(DATE, @ToDate)
                      )
                  AND a.ZoneTypeId IN (   IIF(@ZoneTypeIdJson IS NOT NULL,
                                          (
                                              SELECT DISTINCT filterTable.ZoneTypeId FROM #FilterTable filterTable
                                          ),
                                              a.ZoneTypeId)
                                      )
                  AND a.Site IN ((IIF(@SiteCodeJson IS NOT NULL,
                                  (SELECT DISTINCT filterTable.SiteCode FROM #FilterTable filterTable),
                                      a.Site)
                                 )
                                )
                  AND A.IsDeleted = 0
                  AND
                  (
                      A.QCNumber LIKE '%' + @StringSearch + '%'
                      OR A.GRNNumber LIKE '%' + @StringSearch + '%'
                      OR A.PONo LIKE '%' + @StringSearch + '%'
                      OR A.OCNumber LIKE '%' + @StringSearch + '%'
                  )
            ORDER BY A.QCRequestDate DESC,
                     A.QCNumber ASC
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
                Id UNIQUEIDENTIFIER '$.id'
            );

        SET @jsonResult =
        (
            SELECT A.Id,
                   A.ZoneTypeId,
                   A.QCNumber,
                   A.GRNNumber,
                   A.Category,
                   A.ArticleCode,
                   A.ArticleName,
                   A.QCRequestDate,
                   A.StyleName,
                   A.StyleCode,
                   A.OCNumber,
                   A.QCDefinition,
                   A.SamplePlan,
                   A.SamplePercentage,
                   A.ColorCode,
                   A.ColorName,
                   A.QCType,
                   A.UserApproveId,
                   A.TransferStatus,
                   A.DESCRIPTION,
                   A.CreateUserId,
                   A.CreateDate,
                   A.UpdateUserId,
                   A.UpdateDate,
                   A.IsDeleted,
                   A.Buyer,
                   A.DeliveryBuyerOrderRef,
                   A.DocStatus,
                   A.PONo,
                   A.QCQty,
                   A.SITE,
                   A.Supplier,
                   B.Code,
                   B.NAME,
                   B.ProductLine,
                   JSON_QUERY(   CASE B.InspectionBySizesJson
                                     WHEN '' THEN
                                         NULL
                                     ELSE
                                         B.InspectionBySizesJson
                                 END
                             ) InspectionBySizes,
                   JSON_QUERY(   CASE B.InspectionBySizesPerOCJson
                                     WHEN '' THEN
                                         NULL
                                     ELSE
                                         B.InspectionBySizesPerOCJson
                                 END
                             ) InspectionBySizesPerOC,
                   JSON_QUERY(B.DefectDetailJson) DefectDetail,
                   JSON_QUERY(B.PrivateDetailJson) PrivateDetail
            FROM dbo.D01_QCRequest A
                JOIN dbo.D01_QCDetail B
                    ON B.Id = A.Id
            WHERE 1 = 1
                  AND A.Id = @Id
            FOR JSON PATH, WITHOUT_ARRAY_WRAPPER
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
                Id UNIQUEIDENTIFIER '$.id'
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
            UPDATE dbo.D01_QCRequest
            SET IsDeleted = 1
            WHERE Id = @Id;
            UPDATE dbo.D01_QCRequest
            SET UpdateUserId = @UserID
            WHERE Id = @Id;
            UPDATE dbo.D01_QCRequest
            SET UpdateDate = GETDATE()
            WHERE Id = @Id;

            UPDATE dbo.D01_QCDetail
            SET IsDeleted = 1
            WHERE Id = @Id;

            COMMIT TRANSACTION;




        END TRY
        BEGIN CATCH
            --select SUSER_SNAME(),ERROR_NUMBER(),ERROR_STATE(),ERROR_SEVERITY(),ERROR_LINE(),ERROR_PROCEDURE(),ERROR_MESSAGE(),GETDATE();
            IF (XACT_STATE()) = -1
                ROLLBACK TRANSACTION;
            IF (XACT_STATE()) = 1
                COMMIT TRANSACTION;
        END CATCH;

        SET @jsonResult =
        (
            SELECT A.Id,
                   A.ZoneTypeId,
                   A.QCNumber,
                   A.GRNNumber,
                   A.Category,
                   A.ArticleCode,
                   A.ArticleName,
                   A.QCRequestDate,
                   A.StyleName,
                   A.StyleCode,
                   A.OCNumber,
                   A.QCDefinition,
                   A.SamplePlan,
                   A.SamplePercentage,
                   A.ColorCode,
                   A.ColorName,
                   A.QCType,
                   A.UserApproveId,
                   A.TransferStatus,
                   A.DESCRIPTION,
                   A.CreateUserId,
                   A.CreateDate,
                   A.UpdateUserId,
                   A.UpdateDate,
                   A.IsDeleted,
                   A.Buyer,
                   A.DeliveryBuyerOrderRef,
                   A.DocStatus,
                   A.PONo,
                   A.QCQty,
                   A.SITE,
                   A.Supplier,
                   B.Code,
                   B.NAME,
                   B.ProductLine,
                   JSON_QUERY(   CASE B.InspectionBySizesJson
                                     WHEN '' THEN
                                         NULL
                                     ELSE
                                         B.InspectionBySizesJson
                                 END
                             ) InspectionBySizes,
                   JSON_QUERY(   CASE B.InspectionBySizesPerOCJson
                                     WHEN '' THEN
                                         NULL
                                     ELSE
                                         B.InspectionBySizesPerOCJson
                                 END
                             ) InspectionBySizesPerOC,
                   JSON_QUERY(B.DefectDetailJson) DefectDetail,
                   JSON_QUERY(B.PrivateDetailJson) PrivateDetail
            FROM dbo.D01_QCRequest A
                JOIN dbo.D01_QCDetail B
                    ON B.Id = A.Id
            WHERE 1 = 1
                  AND A.Id = @Id
            FOR JSON PATH, WITHOUT_ARRAY_WRAPPER
        );
        IF (@IsCompress = CAST(1 AS BIT))
            SELECT JsbData = COMPRESS(@jsonResult);
        ELSE
            SELECT JsbData = @jsonResult;

    END;

    IF (@Active = 'Save')
    BEGIN
        SET @js = CAST(DECOMPRESS(@jsParam) AS NVARCHAR(MAX));

        SELECT @Id = Id
        FROM
            OPENJSON(@js)
            WITH
            (
                Id UNIQUEIDENTIFIER '$.Id'
            );

        IF NOT OBJECT_ID('tempdb.dbo.#QCDetail', 'U') IS NULL
            DROP TABLE #QCDetail;
        SELECT TOP 1
               Id,
               Code,
               NAME,
               ProductLine,
               InspectionBySizesJson,
               InspectionBySizesPerOCJson,
               DefectDetailJson,
               PrivateDetailJson,
               IsDeleted
        INTO #QCDetail
        FROM
            OPENJSON(@js)
            WITH
            (
                Id UNIQUEIDENTIFIER '$.Id',
                Code NVARCHAR(255) '$.Code',
                NAME NVARCHAR(500) '$.Name',
                ProductLine NVARCHAR(MAX) '$.ProductLine',
                InspectionBySizesJson NVARCHAR(MAX) '$.InspectionBySizes' AS JSON,
                InspectionBySizesPerOCJson NVARCHAR(MAX) '$.InspectionBySizesPerOC' AS JSON,
                DefectDetailJson NVARCHAR(MAX) '$.DefectDetail' AS JSON,
                PrivateDetailJson NVARCHAR(MAX) '$.PrivateDetail' AS JSON,
                IsDeleted BIT '$.IsDeleted'
            );

        --DECLARE @jsQCRequest NVARCHAR(MAX);
        --SELECT @jsQCRequest = QCDetail.QCRequestJson
        --FROM #QCDetail QCDetail;

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
               UserApproveId,
               TransferStatus,
               DESCRIPTION,
               CreateUserId,
               CreateDate,
               UpdateUserId,
               UpdateDate,
               IsDeleted,
               Buyer,
               DeliveryBuyerOrderRef,
               DocStatus,
               PONo,
               QCQty,
               SITE,
               Supplier
        INTO #QCRequest
        FROM
            OPENJSON(@js)
            WITH
            (
                Id UNIQUEIDENTIFIER '$.Id',
                ZoneTypeId UNIQUEIDENTIFIER '$.ZoneTypeId',
                QCNumber NVARCHAR(255) '$.QCNumber',
                GRNNumber NVARCHAR(255) '$.GRNNumber',
                Category NVARCHAR(255) '$.Category',
                ArticleCode NVARCHAR(255) '$.ArticleCode',
                ArticleName NVARCHAR(255) '$.ArticleName',
                QCRequestDate DATETIME2(7) '$.QCRequestDate',
                StyleName NVARCHAR(255) '$.StyleName',
                StyleCode NVARCHAR(255) '$.StyleCode',
                OCNumber NVARCHAR(255) '$.OCNumber',
                QCDefinition NVARCHAR(255) '$.QCDefinition',
                SamplePlan NVARCHAR(255) '$.SamplePlan',
                SamplePercentage FLOAT '$.SamplePercentage',
                ColorCode NVARCHAR(255) '$.ColorCode',
                ColorName NVARCHAR(25) '$.ColorName',
                QCType NVARCHAR(15) '$.QCType',
                UserApproveId INT '$.UserApproveId',
                TransferStatus INT '$.TransferStatus',
                DESCRIPTION NVARCHAR(500) '$.Description',
                CreateUserId INT '$.CreateUserId',
                CreateDate DATETIME2(7) '$.CreateDate',
                UpdateUserId INT '$.UpdateUserId',
                UpdateDate DATETIME2(7) '$.UpdateDate',
                IsDeleted BIT '$.IsDeleted',
                Buyer NVARCHAR(255) '$.Buyer',
                DeliveryBuyerOrderRef NVARCHAR(255) '$.DeliveryBuyerOrderRef',
                DocStatus INT '$.DocStatus',
                PONo NVARCHAR(255) '$.PONo',
                QCQty INT '$.QCQty',
                SITE NVARCHAR(255) '$.Site',
                Supplier NVARCHAR(255) '$.Supplier'
            );



        ----------------------------------------------------------------------------------------------------------------
        BEGIN TRY
            BEGIN TRANSACTION;
            WITH QCRequestTarget
            AS (SELECT qcr.Id,
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
                       qcr.UserApproveId,
                       qcr.TransferStatus,
                       qcr.DESCRIPTION,
                       qcr.CreateUserId,
                       qcr.CreateDate,
                       qcr.UpdateUserId,
                       qcr.UpdateDate,
                       qcr.IsDeleted,
                       qcr.Buyer,
                       qcr.DeliveryBuyerOrderRef,
                       qcr.DocStatus,
                       qcr.PONo,
                       qcr.QCQty,
                       qcr.SITE,
                       qcr.Supplier
                FROM dbo.D01_QCRequest qcr WITH (NOLOCK)
                WHERE qcr.Id = @Id)
            MERGE QCRequestTarget AS TARGET
            USING #QCRequest AS SOURCE
            ON (TARGET.Id = SOURCE.Id)
            WHEN MATCHED AND (SOURCE.QCNumber IS NOT NULL) THEN
                UPDATE SET TARGET.ZoneTypeId = ISNULL(SOURCE.ZoneTypeId, TARGET.ZoneTypeId),
                           TARGET.QCNumber = ISNULL(SOURCE.QCNumber, TARGET.QCNumber),
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
                           TARGET.UserApproveId = ISNULL(SOURCE.UserApproveId, TARGET.UserApproveId),
                           TARGET.TransferStatus = ISNULL(SOURCE.TransferStatus, TARGET.TransferStatus),
                           TARGET.DESCRIPTION = ISNULL(SOURCE.DESCRIPTION, TARGET.DESCRIPTION),
                           TARGET.CreateUserId = ISNULL(SOURCE.CreateUserId, TARGET.CreateUserId),
                           TARGET.CreateDate = ISNULL(SOURCE.CreateDate, TARGET.CreateDate),
                           TARGET.UpdateUserId = @UserID,
                           TARGET.UpdateDate = GETDATE(),
                           TARGET.IsDeleted = ISNULL(SOURCE.IsDeleted, TARGET.IsDeleted),
                           TARGET.Buyer = ISNULL(SOURCE.Buyer, TARGET.Buyer),
                           TARGET.DeliveryBuyerOrderRef = ISNULL(
                                                                    SOURCE.DeliveryBuyerOrderRef,
                                                                    TARGET.DeliveryBuyerOrderRef
                                                                ),
                           TARGET.DocStatus = ISNULL(SOURCE.DocStatus, TARGET.DocStatus),
                           TARGET.PONo = ISNULL(SOURCE.PONo, TARGET.PONo),
                           TARGET.QCQty = ISNULL(SOURCE.QCQty, TARGET.QCQty),
                           TARGET.SITE = ISNULL(SOURCE.SITE, TARGET.SITE),
                           TARGET.Supplier = ISNULL(SOURCE.Supplier, TARGET.Supplier)
            WHEN NOT MATCHED BY TARGET AND (SOURCE.QCNumber IS NOT NULL) THEN
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
                    UserApproveId,
                    TransferStatus,
                    DESCRIPTION,
                    CreateUserId,
                    CreateDate,
                    UpdateUserId,
                    UpdateDate,
                    IsDeleted,
                    Buyer,
                    DeliveryBuyerOrderRef,
                    DocStatus,
                    PONo,
                    QCQty,
                    SITE,
                    Supplier
                )
                VALUES
                (SOURCE.Id, SOURCE.ZoneTypeId, SOURCE.QCNumber, SOURCE.GRNNumber, SOURCE.Category, SOURCE.ArticleCode,
                 SOURCE.ArticleName, SOURCE.QCRequestDate, SOURCE.StyleName, SOURCE.StyleCode, SOURCE.OCNumber,
                 SOURCE.QCDefinition, SOURCE.SamplePlan, SOURCE.SamplePercentage, SOURCE.ColorCode, SOURCE.ColorName,
                 SOURCE.QCType, SOURCE.UserApproveId, SOURCE.TransferStatus, SOURCE.DESCRIPTION, @UserID, GETDATE(),
                 @UserID, GETDATE(), 0, SOURCE.Buyer, SOURCE.DeliveryBuyerOrderRef, SOURCE.DocStatus, SOURCE.PONo,
                 SOURCE.QCQty, SOURCE.SITE, SOURCE.Supplier);


            WITH QCDetailTarget
            AS (SELECT qcd.Id,
                       qcd.Code,
                       qcd.NAME,
                       qcd.ProductLine,
                       qcd.InspectionBySizesJson,
                       qcd.InspectionBySizesPerOCJson,
                       qcd.DefectDetailJson,
                       qcd.PrivateDetailJson,
                       qcd.IsDeleted
                FROM dbo.D01_QCDetail qcd WITH (NOLOCK)
                WHERE qcd.Id = @Id)
            MERGE QCDetailTarget AS TARGET
            USING #QCDetail AS SOURCE
            ON (TARGET.Id = SOURCE.Id)
            WHEN MATCHED AND (SOURCE.Code IS NOT NULL) THEN
                UPDATE SET TARGET.Code = ISNULL(SOURCE.Code, TARGET.Code),
                           TARGET.NAME = ISNULL(SOURCE.NAME, TARGET.NAME),
                           TARGET.ProductLine = ISNULL(SOURCE.ProductLine, TARGET.ProductLine),
                           TARGET.InspectionBySizesJson = ISNULL(
                                                                    SOURCE.InspectionBySizesJson,
                                                                    TARGET.InspectionBySizesJson
                                                                ),
                           TARGET.InspectionBySizesPerOCJson = ISNULL(
                                                                         SOURCE.InspectionBySizesPerOCJson,
                                                                         TARGET.InspectionBySizesPerOCJson
                                                                     ),
                           TARGET.DefectDetailJson = ISNULL(SOURCE.DefectDetailJson, TARGET.DefectDetailJson),
                           TARGET.PrivateDetailJson = ISNULL(SOURCE.PrivateDetailJson, TARGET.PrivateDetailJson),
                           TARGET.IsDeleted = ISNULL(SOURCE.IsDeleted, TARGET.IsDeleted)
            WHEN NOT MATCHED BY TARGET AND (SOURCE.Code IS NOT NULL) THEN
                INSERT
                (
                    Id,
                    Code,
                    NAME,
                    ProductLine,
                    InspectionBySizesJson,
                    InspectionBySizesPerOCJson,
                    DefectDetailJson,
                    PrivateDetailJson,
                    IsDeleted
                )
                VALUES
                (SOURCE.Id, SOURCE.Code, SOURCE.NAME, SOURCE.ProductLine, SOURCE.InspectionBySizesJson,
                 SOURCE.InspectionBySizesPerOCJson, SOURCE.DefectDetailJson, SOURCE.PrivateDetailJson, 0);
            --OUTPUT $action;
            --OUTPUT $action;
            --INTO @tblOutput
            --(
            --    TAction
            --);

            --OUTPUT DELETED., $action AS [Action], INSERTED. into ##TY


            --COMMIT TRANSACTION

            --SELECT @ReturnMess = TAction
            --FROM @tblOutput;
            --SELECT @jsFilter = CONCAT(N'{"processId":"', @processId, '"}');

            --UPDATE dbo.D01_QCRequest
            --SET SizeBreakDownsJson =
            --    (
            --        SELECT TOP 1
            --               a.InspectionBySizesJson
            --        FROM dbo.D01_QCDetail a
            --        WHERE a.Id = @Id
            --    )
            --WHERE D01_QCRequest.Id = @Id;

            COMMIT TRANSACTION;


        END TRY
        BEGIN CATCH
            --select SUSER_SNAME(),ERROR_NUMBER(),ERROR_STATE(),ERROR_SEVERITY(),ERROR_LINE(),ERROR_PROCEDURE(),ERROR_MESSAGE(),GETDATE();
            IF (XACT_STATE()) = -1
                ROLLBACK TRANSACTION;
            IF (XACT_STATE()) = 1
                COMMIT TRANSACTION;
        END CATCH;

        SELECT @jsonResult =
        (
            SELECT A.Id,
                   A.ZoneTypeId,
                   A.QCNumber,
                   A.GRNNumber,
                   A.Category,
                   A.ArticleCode,
                   A.ArticleName,
                   A.QCRequestDate,
                   A.StyleName,
                   A.StyleCode,
                   A.OCNumber,
                   A.QCDefinition,
                   A.SamplePlan,
                   A.SamplePercentage,
                   A.ColorCode,
                   A.ColorName,
                   A.QCType,
                   A.UserApproveId,
                   A.TransferStatus,
                   A.DESCRIPTION,
                   A.CreateUserId,
                   A.CreateDate,
                   A.UpdateUserId,
                   A.UpdateDate,
                   A.IsDeleted,
                   A.Buyer,
                   A.DeliveryBuyerOrderRef,
                   A.DocStatus,
                   A.PONo,
                   A.QCQty,
                   A.SITE,
                   A.Supplier,
                   B.Code,
                   B.NAME,
                   B.ProductLine,
                   JSON_QUERY(   CASE B.InspectionBySizesJson
                                     WHEN '' THEN
                                         NULL
                                     ELSE
                                         B.InspectionBySizesJson
                                 END
                             ) InspectionBySizes,
                   JSON_QUERY(   CASE B.InspectionBySizesPerOCJson
                                     WHEN '' THEN
                                         NULL
                                     ELSE
                                         B.InspectionBySizesPerOCJson
                                 END
                             ) InspectionBySizesPerOC,
                   JSON_QUERY(B.DefectDetailJson) DefectDetail,
                   JSON_QUERY(B.PrivateDetailJson) PrivateDetail
            FROM dbo.D01_QCRequest A
                JOIN dbo.D01_QCDetail B
                    ON B.Id = A.Id
            WHERE 1 = 1
                  AND A.Id = @Id
            FOR JSON PATH, WITHOUT_ARRAY_WRAPPER
        );
        IF (@IsCompress = CAST(1 AS BIT))
            SELECT JsbData = COMPRESS(@jsonResult);
        ELSE
            SELECT JsbData = @jsonResult;
    END;
END;