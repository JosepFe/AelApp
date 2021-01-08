using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Devon4Net.Domain.UnitOfWork.Repository;
using Devon4Net.Infrastructure.Log;
using Devon4Net.WebAPI.Implementation.Business.TodoManagement.Validators;
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

        /// <summary>
        /// Get TODO method
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public Task<IList<Town>> GetTodo(Expression<Func<Town, bool>> predicate = null)
        {
            Devon4NetLogger.Debug("GetTown method from TodoRepository TownService");
            return Get(predicate);
        }

        /// <summary>
        /// Geto the TODO by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task<Town> GetTodoById(Guid id)
        {
            Devon4NetLogger.Debug($"GetTownById method from repository TownService with value : {id}");
            return GetFirstOrDefault(t => t.Id == id);
        }

        /// <summary>
        /// Creates the TODO
        /// </summary>
        /// <param name="description"></param>
        /// <returns></returns>
        public Task<Town> Create(string name, string community)
        {
            Devon4NetLogger.Debug($"SetTown method from repository TownService with value : {name}");

            var Town = new Town { TownName = name, Community = community};

            return Create(Town);
        }

        /// <summary>
        /// Deletes the TODO by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<Guid> DeleteTodoById(Guid id)
        {
            Devon4NetLogger.Debug($"DeleteTownById method from repository TownService with value : {id}");
            var deleted = await Delete(t => t.Id == id).ConfigureAwait(false);

            if (deleted)
            {
                return id;
            }

            throw  new ApplicationException($"The Town entity {id} has not been deleted.");
        }
    }
}
