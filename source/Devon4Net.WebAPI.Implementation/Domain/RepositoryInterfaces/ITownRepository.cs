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
        /// 
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        Task<IList<Town>> GetTodo(Expression<Func<Town, bool>> predicate = null);

        /// <summary>
        /// GetTodoById
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Town> GetTodoById(Guid id);

        /// <summary>
        /// Create
        /// </summary>
        /// <param name="description"></param>
        /// <returns></returns>
        Task<Town> Create(string name, string community);

        /// <summary>
        /// DeleteTodoById
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Guid> DeleteTodoById(Guid id);
    }
}
