using System;
using System.Threading.Tasks;
using Devon4Net.WebAPI.Implementation.Domain.Entities;

namespace Devon4Net.WebAPI.Implementation.Business.InhabitantsManagement.Services
{
    /// <summary>
    /// InhabitantsService interface
    /// </summary>
    public interface IInhabitantsService
    {
        /// <summary>
        /// CreateUser
        /// </summary>
        /// <param name="description"></param>
        /// <returns></returns>
        Task<User> CreateUser(string name);

        /// <summary>
        /// Delete user
        /// </summary>
        /// <param name="description"></param>
        /// <returns></returns>
        Task<Guid> DeleteUser(string name, string surname);

        /// <summary>
        /// Tegister a user in a specific town
        /// </summary>
        /// <param name="description"></param>
        /// <returns></returns>
        Task<User> RegisterUserTown(string name, string surname, string townName);

        /// <summary>
        /// Checks user belongs to a town
        /// </summary>
        /// <param name="description"></param>
        /// <returns></returns>
        Task<User> CheckUserBelongsTown(string name, string surname, string townName);
    }
}