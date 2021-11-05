
using QCService.Helpers.Enums;

namespace QCService.Infrastructure.Repositories
{
    public interface IJsonRepository
    {
        T ExecuteData<T>(StoreProcedureType storeProcedure, ActiveType active, out string Message_out, string JSParam = null) where T : class;
        T ExecuteFromRawScript<T>(string script, out string Message_out) where T : class;
        string GetJson(StoreProcedureType storeProcedure, ActiveType active, out string Message_out, string JSParam = null);
    }
}