using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QCService.Helpers
{
    public static class SeedFunction
    {
		public static string DropFunctionQCRequest()
        {
			var name = "QCRequest";
			return $"CREATE FUNCTION [dbo].[fn_parse_{name}]";

		}
		public static string CreateFunctionQCRequest()
        {
			var name = "QCRequest";

			var sql = $@"
CREATE FUNCTION [dbo].[fn_parse_{name}](@JsParam nvarchar(max)=null)
RETURNS @T TABLE(

				----------------- USER INFO------------------------------------
				[Username]			NVARCHAR(25)
				,[Password]			NVARCHAR(25)
				,[Userid]			uniqueidentifier
				,[IsLock]			bit

				----------------- ENTRY DATA------------------------------------
				,EntryID			UNIQUEIDENTIFIER
				
				--------------------SYSTEM CONFIG---------------------------
				,PageNumber			INT
				,PageSize			INT

				--------------------LAUNDRY CONFIG---------------------------
				,LaundryID			UNIQUEIDENTIFIER

				--------------------DATE CONFIG---------------------------
				,FromDate			VARCHAR(10)
				,ToDate				VARCHAR(10)
				
				--------------------PARAM SYSTEM-----------------------------
				,QCNumber			NVARCHAR(125)
				,OCNumber			NVARCHAR(125)
				,[ProductCode]		NVARCHAR(80)
				,[ProductName]		NVARCHAR(255)


				)
--WITH ENCRYPTION
AS
BEGIN 

END
";

			return sql;
        }
        public static string CreateFunctionFilterParam()
        {
            var sql = @"
CREATE function [dbo].[fn_Filter_Param](@JsFilter nvarchar(2000)=null)

RETURNS @T TABLE(

				----------------- USER INFO------------------------------------
				[Username]			NVARCHAR(25)
				,[Password]			NVARCHAR(25)
				,[Userid]			uniqueidentifier
				,[IsLock]			bit

				----------------- ENTRY DATA------------------------------------
				,EntryID			UNIQUEIDENTIFIER
				
				--------------------SYSTEM CONFIG---------------------------
				,PageNumber			INT
				,PageSize			INT

				--------------------LAUNDRY CONFIG---------------------------
				,LaundryID			UNIQUEIDENTIFIER

				--------------------DATE CONFIG---------------------------
				,FromDate			VARCHAR(10)
				,ToDate				VARCHAR(10)
				
				--------------------PARAM SYSTEM-----------------------------
				,QCNumber			NVARCHAR(125)
				,OCNumber			NVARCHAR(125)
				,[ProductCode]		NVARCHAR(80)
				,[ProductName]		NVARCHAR(255)


				)
--WITH ENCRYPTION
AS
BEGIN 
	
		DECLARE @EntryID		uniqueidentifier,@LaundryID uniqueidentifier; 
		DECLARE @Password		NVARCHAR(25)
				,@Username		NVARCHAR(25),@Userid uniqueidentifier
				,@ProductCode	NVARCHAR(255),@ProductName	NVARCHAR(255),@OperationCode VARCHAR(25)
				,@QCNumber		NVARCHAR(125),@OCNumber		NVARCHAR(125)
		
		DECLARE @PageNumber int=1,@PageSize int =20,@FromDate int=19000101,@ToDate int=99999999,@IsLock bit
		
		;With tblFilter as 
			(
				SELECT [key] COLLATE SQL_Latin1_General_CP1_CI_AS AS KeyDesc,[value] COLLATE SQL_Latin1_General_CP1_CI_AS AS ValueDesc
				FROM OPENJSON(@JsFilter)
			)		
		
		select 
				----------------- USER INFO------------------------------------
				
				@Username	= cast (Username as nvarchar(25)) 
				,@Password	= cast ([Password] as nvarchar(25)) 
				,@Userid	= cast (Userid as uniqueidentifier) 
				,@IsLock	= cast (IsLock as bit) 
				
				----------------- ENTRY DATA------------------------------------
				,@EntryID = cast ([FolderId] as uniqueidentifier)

				--------------------LAUNDRY CONFIG---------------------------
				,@LaundryID=cast(LaundryID as uniqueidentifier)
				----------------- SYSTEM CONFIG ---------------------------
				,@PageNumber=ISNULL(PageNumber,1), @PageSize=ISNULL(PageSize,25)

				--------------------DATE CONFIG---------------------------
				,@FromDate = ISNULL(FromDate,19000101), @ToDate	= ISNULL(ToDate,99999999)

				--------------------PARAM SYSTEM-----------------------------
				,@ProductCode	=ISNULL(ProductCode,''),@ProductName	=ISNULL(ProductName,'')
				,@QCNumber		=ISNULL(QCNumber,'')	,@OCNumber		=ISNULL(OCNumber,'')

		from (select KeyDesc,ValueDesc from tblFilter )P
		PIVOT (MAX( ValueDesc) FOR [KeyDesc] 
		in (	[FolderId],[PageNumber],[PageSize]
				,[Username],[Userid],[Password],[FromDate],[ToDate],[ProductCode],[ProductName]
				,[LaundryID],[IsLock]
				,QCNumber,OCNumber
			))as PVT


		--------------------------------------------------------------------------------------------------------------------------------------

		Insert into @T([EntryID],[Userid],[Username],[Password]
					,[PageNumber],[PageSize]
					,FromDate,ToDate,[ProductCode],[ProductName]
					,[LaundryID],[IsLock],QCNumber,OCNumber
					)
		select @EntryID,@Userid,@Username,@Password,@PageNumber,@PageSize,@FromDate,@ToDate
				,@ProductCode,@ProductName,@LaundryID,@IsLock,@QCNumber,@OCNumber
		RETURN;
END
";
			return sql;
        }

		public static string DropFunctionFilterParam()
        {
			return "DROP FUNCTION [dbo].[fn_Filter_Param]";
		}
    }
}
