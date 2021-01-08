using System.Threading.Tasks;
using Devon4Net.Domain.UnitOfWork.Repository;
using Devon4Net.WebAPI.Implementation.Domain.Entities;

namespace Devon4Net.WebAPI.Implementation.Domain.RepositoryInterfaces
{
    /// <summary>
    /// TodoRepository interface
    /// </summary>
    public interface IUserRepository : IRepository<User>
    {
        /// <summary>
        /// GetUserByNameAndSurname
        /// </summary>
        Task<User> GetUserByNameAndSurname(string name, string surname);

        /// <summary>
        /// Create
        /// </summary>
        Task<User> Create(string name, string surname, string dni);

        /// <summary>
        /// DeleteTodoById
        /// </summary>
        Task DeleteUserByNameAndSuername(string name, string surname);
    }
}
