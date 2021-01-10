using System;
using System.Threading.Tasks;
using Devon4Net.Domain.UnitOfWork.Repository;
using Devon4Net.WebAPI.Implementation.Domain.Entities;

namespace Devon4Net.WebAPI.Implementation.Domain.RepositoryInterfaces
{
    /// <summary>
    /// UserTownRepository interface
    /// </summary>
    public interface IUserTownRepository : IRepository<UserTown>
    {
        /// <summary>
        /// GetUserTown
        /// </summary>
        Task<UserTown> GetUserTownByUserId(Guid userId);

        /// <summary>
        /// Create
        /// </summary>
        Task<UserTown> Create(Guid userId, Guid townId, DateTime registerDate, string adress);

        /// <summary>
        /// DeleteUserTownById
        /// </summary>
        Task<Guid> DeleteUserTownById(Guid id);

        /// <summary>
        /// Get Town By UserId & TownId
        /// </summary>
        Task<UserTown> GetUserTownByUserIdAndTownId(Guid userId, Guid townId);
    }
}
