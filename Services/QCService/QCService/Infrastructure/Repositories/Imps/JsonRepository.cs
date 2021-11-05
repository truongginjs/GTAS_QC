using Microsoft.EntityFrameworkCore;
using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Linq;
using Microsoft.AspNetCore.Http;
using QCService.Infrastructure.Repositories;
using QCService.Helpers.Enums;
using QCService.Helpers.Extensions;
using QCService.Infrastructure;
using System.Text.Json;

namespace IED.Server.Repositories
{
    public class JsonRepository : IJsonRepository
    {
        private readonly QCContext _context;
        private readonly IHttpContextAccessor _accessor;

        public JsonRepository(QCContext context, IHttpContextAccessor accessor)
        {
            _context = context;
            _accessor = accessor;
        }

        public T ExecuteData<T>(StoreProcedureType storeProcedure, ActiveType active, out string Message_out, string JSParam = null) where T : class
        {
            try
            {
                var outParam = new SqlParameter()
                {
                    ParameterName = "@ReturnMess",
                    DbType = DbType.String,
                    Size = 255,
                    Direction = ParameterDirection.Output
                };

                //_accessor.HttpContext.Request.Headers.TryGetValue("Authorization", out StringValues authValue);
                //var token = authValue.ToString().Split(' ', StringSplitOptions.RemoveEmptyEntries)[1];

                var data = _accessor.HttpContext.User.ParseUserFromClaimsServer();
                var userId = data?.UserId;

                string script = $"exec [{storeProcedure}] @Active={{0}}, @jsParam={{1}}, @userId={{2}}, @ReturnMess={{3}} output";
                byte[] jsParam = JSParam.Compress();
                var Active = active.ToString();
                var rs = _context.JsonResponse.FromSqlRaw(script, Active, jsParam, userId, outParam).AsEnumerable().FirstOrDefault();
                if (rs == null)
                {
                    Message_out = (string)(outParam.Value ?? "can't find");
                    return null;
                }
                var json = rs.jsbData.Decompress();
                var result = JsonSerializer.Deserialize<T>(json);
                if (outParam.Value == DBNull.Value)
                    Message_out = "success";
                else
                    Message_out = (string)outParam.Value ?? "success";

                return result;
            }
            catch (Exception e)
            {
                Message_out = e.Message;
                Console.WriteLine("loi: ", e.Message);
                return null;
            }
        }

        public T ExecuteFromRawScript<T>(string script, out string Message_out) where T : class
        {
            try
            {
                var rs = _context.JsonResponse.FromSqlRaw(script).AsEnumerable().FirstOrDefault();
                var json = rs.jsbData.Decompress();
                var result = JsonSerializer.Deserialize<T>(json);
                Message_out = json;
                return result;
            }
            catch (Exception e)
            {
                Message_out = e.Message;
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public string GetJson(StoreProcedureType storeProcedure, ActiveType active, out string Message_out, string JSParam = null)
        {
            try
            {
                var outParam = new SqlParameter()
                {
                    ParameterName = "@ReturnMess",
                    DbType = DbType.String,
                    Size = 255,
                    Direction = ParameterDirection.Output
                };
                var data = _accessor.HttpContext.User.ParseUserFromClaimsServer();
                var userId = data?.UserId;

                string script = $"exec [{storeProcedure}] @Active={{0}}, @jsParam={{1}}, @userId={{2}}, @ReturnMess={{3}} output";
                byte[] jsParam = JSParam.Compress();
                var Active = active.ToString();
                var rs = _context.JsonResponse.FromSqlRaw(script, Active, jsParam, userId, outParam).AsEnumerable().FirstOrDefault();
                if (outParam.Value == DBNull.Value)
                    Message_out = "success";
                else
                    Message_out = (string)outParam.Value ?? "success";

                var json = rs.jsbData.Decompress();
                return json;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Message_out = e.Message;
                return string.Empty;
            }
        }
    }
}
