using Devon4Net.Domain.UnitOfWork.Repository;
using Devon4Net.WebAPI.Implementation.Domain.Entities;
using System;
using System.Threading.Tasks;

namespace Devon4Net.WebAPI.Implementation.Domain.RepositoryInterfaces
{
    /// <summary>
    /// UserTownRepository interface
    /// </summary>
    public interface ITaxRepository : IRepository<Tax>
    {
        Task<Tax> GetTaxByNameAndYear(string taxName, int taxYear);
        Task<Tax> GetTaxById(Guid taxId);
    }
}
