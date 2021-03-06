USE [GTAS_QC]
GO
/****** Object:  StoredProcedure [dbo].[sp_FindQCRequest]    Script Date: 11/23/2021 8:44:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[sp_FindQCRequest]
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

    --DECLARE @Id UNIQUEIDENTIFIER;

    IF (@Active = 'Find')
    BEGIN

        DECLARE @OCNumber NVARCHAR(MAX) = N'',
                @Buyer NVARCHAR(MAX) = N'';

        SET @js = CAST(DECOMPRESS(@jsParam) AS NVARCHAR(MAX));


        IF NOT OBJECT_ID('tempdb.dbo.#FilterTable', 'U') IS NULL
            DROP TABLE #FilterTable;
        SELECT OCNumber,
               Buyer
        INTO #FilterTable
        FROM
            OPENJSON(@js)
            WITH
            (
                OCNumber NVARCHAR(MAX) '$.OCNumber',
                Buyer NVARCHAR(MAX) '$.Buyer'
            );

        SELECT TOP 1
               @OCNumber = ISNULL(a.OCNumber, ''),
               @Buyer = ISNULL(a.Buyer, '')
        FROM #FilterTable a;

        SET @jsonResult =
        (
            SELECT a.Site,
                   a.Buyer,
                   a.QCNumber,
                   a.GRNNumber,
                   a.PONo,
                   a.OCNumber,
                   a.Category,
                   a.ArticleName,
                   a.StyleName,
                   a.QCQty
            FROM dbo.D01_QCRequest AS a
            WHERE 1 = 1
                  AND a.TransferStatus = 1
                  AND a.IsDeleted = 0
                  AND a.OCNumber LIKE '%' + @OCNumber + '%'
                  AND a.Buyer LIKE '%' + @Buyer + '%'
            ORDER BY a.QCRequestDate DESC,
                     a.QCNumber ASC
            FOR JSON PATH
        );

        IF (@IsCompress = CAST(1 AS BIT))
            SELECT JsbData = COMPRESS(@jsonResult);
        ELSE
            SELECT JsbData = @jsonResult;
    END;
END;