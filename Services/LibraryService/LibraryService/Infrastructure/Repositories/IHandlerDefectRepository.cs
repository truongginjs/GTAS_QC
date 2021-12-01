using LibraryService.DTOs.Responses;
using LibraryService.Models.L01;
using SINNIKA.EFCore.Initialize;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LibraryService.Infrastructure.Repositories
{
    public interface IHandlerDefectRepository : IRepository<HandlerDefectLib>
    {
        Task<IEnumerable<HandlerDefectLib>> GetsInfoAsync();
    }
}