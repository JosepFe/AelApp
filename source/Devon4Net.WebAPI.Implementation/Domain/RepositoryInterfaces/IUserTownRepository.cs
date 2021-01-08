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
    public interface IUserTownRepository : IRepository<UserTown>
    {
        /// <summary>
        /// GetUserTown
        /// </summary>
        Task<UserTown> GetTodoByUserId(Guid userId);

        /// <summary>
        /// Create
        /// </summary>
        Task<UserTown> Create(Guid userId, Guid townId, DateTime registerDate, string adress);

        /// <summary>
        /// DeleteTodoById
        /// </summary>
        Task<Guid> DeleteTodoById(Guid id);
    }
}
