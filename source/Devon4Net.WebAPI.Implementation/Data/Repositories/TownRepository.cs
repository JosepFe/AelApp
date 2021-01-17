using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Devon4Net.Domain.UnitOfWork.Repository;
using Devon4Net.Infrastructure.Log;
using Devon4Net.WebAPI.Implementation.Domain.Database;
using Devon4Net.WebAPI.Implementation.Domain.Entities;
using Devon4Net.WebAPI.Implementation.Domain.RepositoryInterfaces;

namespace Devon4Net.WebAPI.Implementation.Data.Repositories
{
    /// <summary>
    /// Repository implementation for the TODOS
    /// </summary>
    public class TownRepository : Repository<Town>, ITownRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"></param>
        public TownRepository(AelContext context) : base(context)
        {
        }

        /// <summary>
        /// Get the Town by name
        /// </summary>
        public Task<Town> GetTownByName(string townName)
        {
            Devon4NetLogger.Debug($"GetTownByName method from repository UserService with value : {townName}");
            return GetFirstOrDefault(t => t.TownName == townName);
        }

        public Task<Town> GetTownById(Guid townId)
        {
            Devon4NetLogger.Debug($"GetTownById method from repository UserService with value : {townId}");
            return GetFirstOrDefault(t => t.Id == townId);
        }
    }
}
