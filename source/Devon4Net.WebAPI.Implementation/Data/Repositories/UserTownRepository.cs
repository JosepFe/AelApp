using System;
using System.Threading.Tasks;
using Devon4Net.Domain.UnitOfWork.Repository;
using Devon4Net.Infrastructure.Log;
using Devon4Net.WebAPI.Implementation.Domain.Database;
using Devon4Net.WebAPI.Implementation.Domain.Entities;
using Devon4Net.WebAPI.Implementation.Domain.RepositoryInterfaces;

namespace Devon4Net.WebAPI.Implementation.Data.Repositories
{
    /// <summary>
    /// Repository implementation for the UserTownS
    /// </summary>
    public class UserTownRepository : Repository<UserTown>, IUserTownRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"></param>
        public UserTownRepository(AelContext context) : base(context)
        {
        }

        /// <summary>
        /// Get the UserTown by userId
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task<UserTown> GetUserTownByUserId(Guid userId)
        {
            Devon4NetLogger.Debug($"GetUserTownById method from repository UserTownService with value : {userId}");
            return GetFirstOrDefault(t => t.UserId == userId);
        }

        /// <summary>
        /// Creates the UserTown
        /// </summary>
        /// <param name="description"></param>
        /// <returns></returns>
        public Task<UserTown> Create(Guid userId, Guid townId, DateTime registerDate, string adress)
        {
            Devon4NetLogger.Debug($"SetUserTown method from repository UserTownService with value : {userId}");

            var UserTown = new UserTown { UserId = userId, TownId = townId, RegisterDate = registerDate, Adress = adress};

            return Create(UserTown);
        }

        /// <summary>
        /// Deletes the UserTown by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<Guid> DeleteUserTownById(Guid id)
        {
            Devon4NetLogger.Debug($"DeleteUserTownById method from repository UserTownService with value : {id}");
            var deleted = await Delete(t => t.Id == id).ConfigureAwait(false);

            if (deleted)
            {
                return id;
            }

            throw  new ApplicationException($"The UserTown entity {id} has not been deleted.");
        }

        public async Task<UserTown> GetUserTownByUserIdAndTownId(Guid userId, Guid townId)
        {
            return await GetFirstOrDefault(x => x.UserId == userId && x.TownId == townId).ConfigureAwait(false);
        }
    }
}
