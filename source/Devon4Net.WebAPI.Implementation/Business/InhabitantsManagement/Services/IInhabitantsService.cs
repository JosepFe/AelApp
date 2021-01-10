using System.Threading.Tasks;
using Devon4Net.WebAPI.Implementation.Business.InhabitantsManagement.Controller;
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
        Task<CreateUserDto> CreateUser(string name, string surname, string dni);

        /// <summary>
        /// Delete user
        /// </summary>
        Task DeleteUser(string name, string surname);

        /// <summary>
        /// Register a user in a specific town
        /// </summary>
        Task RegisterUserTown(string name, string surname, string townName, string adress);

        /// <summary>
        /// Checks user belongs to a town
        /// </summary>
        Task CheckUserBelongsTown(string name, string surname, string townName);
    }
}