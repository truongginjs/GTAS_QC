using LibraryService.Models.L01;
using SINNIKA.EFCore.Initialize;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LibraryService.Infrastructure.Repositories
{
    public interface IDefectRepository : IRepository<DefectLib>
    {
        Task<IEnumerable<DefectLib>> GetsInfoAsync();
    }
}