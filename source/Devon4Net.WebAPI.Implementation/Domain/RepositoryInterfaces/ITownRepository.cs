using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Devon4Net.Domain.UnitOfWork.Repository;
using Devon4Net.WebAPI.Implementation.Domain.Entities;

namespace Devon4Net.WebAPI.Implementation.Domain.RepositoryInterfaces
{
    /// <summary>
    /// TodoRepository interface
    /// </summary>
    public interface ITownRepository : IRepository<Town>
    {
        /// <summary>
        /// GetTownByName
        /// </summary>
        Task<Town> GetTownByName(string townName);

        /// <summary>
        /// GetTownById
        /// </summary>
        Task<Town> GetTownById(Guid townId);
    }
}
