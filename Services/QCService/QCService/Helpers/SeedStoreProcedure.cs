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
