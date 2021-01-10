using Devon4Net.Domain.UnitOfWork.Repository;
using Devon4Net.WebAPI.Implementation.Domain.Entities;
using System.Threading.Tasks;

namespace Devon4Net.WebAPI.Implementation.Domain.RepositoryInterfaces
{
    /// <summary>
    /// UserTownRepository interface
    /// </summary>
    public interface ITaxRepository : IRepository<Tax>
    {
        Task<Tax> GetTownByNameAndYear(string taxName, int taxYear);
    }
}
