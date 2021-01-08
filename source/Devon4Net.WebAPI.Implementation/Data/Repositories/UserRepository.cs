using System;
using System.Threading.Tasks;
using Devon4Net.Domain.UnitOfWork.Repository;
using Devon4Net.Infrastructure.Log;
using Devon4Net.WebAPI.Implementation.Business.EmployeeManagement.Exceptions;
using Devon4Net.WebAPI.Implementation.Domain.Database;
using Devon4Net.WebAPI.Implementation.Domain.Entities;
using Devon4Net.WebAPI.Implementation.Domain.RepositoryInterfaces;

namespace Devon4Net.WebAPI.Implementation.Data.Repositories
{
    /// <summary>
    /// Repository implementation for the TODOS
    /// </summary>
    public class UserRepository : Repository<User>, IUserRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"></param>
        public UserRepository(AelContext context) : base(context)
        {
        }

        /// <summary>
        /// Geto the TODO by id
        /// </summary>
        public Task<User> GetUserByNameAndSurname(string name, string surname)
        {
            Devon4NetLogger.Debug($"GetUserByNameAndSurname method from repository UserService with value : {name} & {surname}");
            return GetFirstOrDefault(t => t.Name == name && t.Surname == surname);
        }

        /// <summary>
        /// Creates User
        /// </summary>
        public async Task<User> Create(string name, string surname, string dni)
        {
            Devon4NetLogger.Debug($"SetUser method from repository UserService with value : {name}");

            var user = await GetUserByNameAndSurname(name, surname);

            if (user != null) throw new UserAlreadyExistException("User already exists");

            var createUser = new User { Name = name, Surname = surname, Dni = dni};

            return await Create(createUser);
        }

        /// <summary>
        /// Deletes the User by id
        /// </summary>
        public async Task DeleteUserByNameAndSuername(string name, string surname)
        {
            Devon4NetLogger.Debug($"DeleteUserById method from repository UserService with value : {name} & {surname}");

            var user = await GetUserByNameAndSurname(name, surname).ConfigureAwait(false);
            
            if(user == null)
            {
                throw new UserNotFoundException($"The User with name: {name} and surname: {surname} is not registered in the system");
            }

            var deleted = await Delete(t => t.Id == user.Id).ConfigureAwait(false);

            if (!deleted)
            {
                throw  new ApplicationException($"The User entity with name: {name} and surname: {surname} has not been deleted.");
            }
        }
    }
}
