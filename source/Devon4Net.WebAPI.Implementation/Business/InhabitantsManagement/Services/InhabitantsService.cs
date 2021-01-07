using System;
using System.Threading.Tasks;
using Devon4Net.Domain.UnitOfWork.Service;
using Devon4Net.Domain.UnitOfWork.UnitOfWork;
using Devon4Net.Infrastructure.Log;
using Devon4Net.WebAPI.Implementation.Domain.Database;
using Devon4Net.WebAPI.Implementation.Domain.Entities;
using Devon4Net.WebAPI.Implementation.Domain.RepositoryInterfaces;

namespace Devon4Net.WebAPI.Implementation.Business.InhabitantsManagement.Services
{
    /// <summary>
    /// TODO service implementation
    /// </summary>
    public class InhabitantsService : Service<AelContext>, IInhabitantsService
    {
        private readonly IUserRepository _userRepository;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="uoW"></param>
        public InhabitantsService(IUnitOfWork<AelContext> uoW) : base(uoW)
        {
            _userRepository = uoW.Repository<IUserRepository>();
        }

        public Task<User> CheckUserBelongsTown(string name, string surname, string townName)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates the TODO
        /// </summary>
        /// <param name="description"></param>
        /// <returns></returns>
        public Task<User> CreateUser(string description)
        {
            Devon4NetLogger.Debug($"SetTodo method from service TodoService with value : {description}");

            if (string.IsNullOrEmpty(description) || string.IsNullOrWhiteSpace(description))
            {
                throw new ArgumentException("The 'Description' field can not be null.");
            }

            return _userRepository.Create("Josep", "Ferrandis", "21013404Y", "Calle");
        }

        /// <summary>
        /// Deletes the User by name and surname
        /// </summary>
        public async Task<Guid> DeleteUser(string name, string surname)
        {
            Devon4NetLogger.Debug($"DeleteTodoById method from service TodoService with value : {name}, {surname}");
            var user = await _userRepository.GetFirstOrDefault(t => t.Name == name && t.Surname == surname).ConfigureAwait(false);

            if (user == null)
            {
                throw new ArgumentException($"The provided Id {user.Id} does not exists");
            }

            return await _userRepository.DeleteTodoById(user.Id).ConfigureAwait(false);
        }

        public Task<User> RegisterUserTown(string name, string surname, string townName)
        {
            Devon4NetLogger.Debug($"ModifyTodoById method from service TodoService with value : {name}, {surname}, {townName}");

            //    var todo = await _todoRepository.GetFirstOrDefault(t => t.Id == id).ConfigureAwait(false);

            //    if (todo == null)
            //    {
            //        throw new ArgumentException($"The provided Id {id} does not exists");
            //    }

            //    todo.Done = !todo.Done;

            //    return await _todoRepository.Update(todo).ConfigureAwait(false);
            throw new NotImplementedException();
        }
    }
}
