using System;
using System.Threading.Tasks;
using Devon4Net.Domain.UnitOfWork.Service;
using Devon4Net.Domain.UnitOfWork.UnitOfWork;
using Devon4Net.Infrastructure.Log;
using Devon4Net.WebAPI.Implementation.Business.InhabitantsManagement.Dto;
using Devon4Net.WebAPI.Implementation.Business.InhabitantsManagement.Exceptions;
using Devon4Net.WebAPI.Implementation.Domain.Database;
using Devon4Net.WebAPI.Implementation.Domain.RepositoryInterfaces;

namespace Devon4Net.WebAPI.Implementation.Business.InhabitantsManagement.Services
{
    /// <summary>
    /// TODO service implementation
    /// </summary>
    public class InhabitantsService : Service<AelContext>, IInhabitantsService
    {
        private readonly IUserRepository _userRepository;
        private readonly ITownRepository _townRepository;
        private readonly ITaxRepository _taxRepository;
        private readonly IUserTownRepository _userTownRepository;
        private readonly IUserTaxRepository _userTaxRepository;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="uoW"></param>
        public InhabitantsService(IUnitOfWork<AelContext> uoW) : base(uoW)
        {
            _userRepository = uoW.Repository<IUserRepository>();
            _townRepository = uoW.Repository<ITownRepository>();
            _taxRepository = uoW.Repository<ITaxRepository>();
            _userTownRepository = uoW.Repository<IUserTownRepository>();
            _userTaxRepository = uoW.Repository<IUserTaxRepository>();
        }

        /// <summary>
        /// Creates the TODO
        /// </summary>
        /// <param name="description"></param>
        /// <returns></returns>
        public async Task<CreateUserDto> CreateUser(string name, string surname, string dni)
        {
            Devon4NetLogger.Debug($"SetTodo method from service TodoService with value : {name}");

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(surname) || string.IsNullOrWhiteSpace(dni))
            {
                throw new ArgumentException("The 'Description' field can not be null.");
            }

            var user = await _userRepository.Create(name, surname, dni);

            return new CreateUserDto { Name = user.Name, Surname = user.Surname, Dni = user.Dni };
        }

        /// <summary>
        /// Deletes the User by name and surname
        /// </summary>
        public async Task DeleteUser(string name, string surname)
        {
            Devon4NetLogger.Debug($"DeleteUser method from service TodoService with value : {name}, {surname}");

            var user = await _userRepository.GetUserByNameAndSurname(name, surname).ConfigureAwait(false);
            
            if (user == null)
            {
                throw new AelNotFoundException($"The User with name: {name} and surname: {surname} is not registered in the system");
            }

            var userTown = await _userTownRepository.GetUserTownByUserId(user.Id).ConfigureAwait(false);

            if (userTown != null)
            {
                await _userTownRepository.Delete(userTown).ConfigureAwait(false);
            }

            await _userRepository.DeleteUserByNameAndSuername(name, surname).ConfigureAwait(false);
        }

        /// <summary>
        /// Register the User to a town
        /// </summary>
        public async Task RegisterUserTown(string name, string surname, string townName, string adress)
        {
            Devon4NetLogger.Debug($"ModifyTodoById method from service TodoService with value : {name}, {surname}, {townName}");

            var user = await _userRepository.GetUserByNameAndSurname(name, surname).ConfigureAwait(false);

            if (user == null)
            {
                throw new AelNotFoundException($"The User with name: {name} and surname: {surname} is not registered in the system");
            }

            var town = await _townRepository.GetTownByName(townName).ConfigureAwait(false);

            if (town == null)
            {
                throw new AelNotFoundException($"The Town with name: {townName} is not registered in the system");
            }

            var userTown = await _userTownRepository.GetUserTownByUserId(user.Id).ConfigureAwait(false);

            if(userTown == null)
            {
                await _userTownRepository.Create(user.Id, town.Id, DateTime.UtcNow, adress).ConfigureAwait(false);
            }
            else
            {
                userTown.TownId = town.Id;
                userTown.RegisterDate = DateTime.UtcNow;
                userTown.Adress = adress;
                await _userTownRepository.Update(userTown).ConfigureAwait(false);
            }
        }

        /// <summary>
        /// Check if user belongs to a town
        /// </summary>
        public async Task CheckUserBelongsTown(string name, string surname, string townName)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(surname) || string.IsNullOrEmpty(townName))
            {
                throw new ArgumentException($"Invalid data provided");
            }

            var user = await _userRepository.GetUserByNameAndSurname(name, surname).ConfigureAwait(false);

            if (user == null)
            {
                throw new AelNotFoundException($"The User with name: {name} and surname: {surname} is not registered in the system");
            }

            var town = await _townRepository.GetTownByName(townName).ConfigureAwait(false);

            if (town == null)
            {
                throw new AelNotFoundException($"The Town with name: {townName} is not registered in the system");
            }

            var userTown = await _userTownRepository.GetUserTownByUserIdAndTownId(user.Id, town.Id).ConfigureAwait(false);

            if (userTown == null)
            {
                throw new AelNotFoundException($"The Register for user with name: {name} and surname: {surname} does not exist");
            }
        }

        /// <summary>
        /// Assign Tax to User
        /// </summary>
        public async Task AssignTaxToUser(string userName, string userSurname, string taxName, int taxYear, int baseAmount, string reference)
        {
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(userSurname) || string.IsNullOrEmpty(taxName) || taxYear == 0 || string.IsNullOrEmpty(reference))
            {
                throw new ArgumentException($"Invalid data provided");
            }

            var user = await _userRepository.GetUserByNameAndSurname(userName, userSurname).ConfigureAwait(false);

            if (user == null)
            {
                throw new AelNotFoundException($"The User with name: {userName} and surname: {userSurname} is not registered in the system");
            }

            var tax = await _taxRepository.GetTownByNameAndYear(taxName, taxYear).ConfigureAwait(false);

            if (tax == null)
            {
                throw new AelNotFoundException($"The Tax with name: {taxName} from year: {taxYear} is not registered in the system");
            }

            var userTax = await _userTaxRepository.GetUserTaxesByUserIdAndReference(user.Id, reference).ConfigureAwait(false); 

            if(userTax != null)
            {
                throw new UserTaxAlreadyAssignedException($"The Tax with name: {taxName} from year: {taxYear} and reference {reference} already assigned to user with name {userName} and surname {userSurname}");
            }

            await _userTaxRepository.CreateUserTax(tax.Id, user.Id, tax.TaxDeadlineDate, baseAmount, reference);
        }

        /// <summary>
        /// Pay Tax
        /// </summary>
        public async Task PayTax(string userName, string userSurname, string taxName, int taxYear, string reference)
        {
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(userSurname) || string.IsNullOrEmpty(taxName) || taxYear == 0 || string.IsNullOrEmpty(reference))
            {
                throw new ArgumentException($"Invalid data provided");
            }

            var user = await _userRepository.GetUserByNameAndSurname(userName, userSurname).ConfigureAwait(false);

            if (user == null)
            {
                throw new AelNotFoundException($"The User with name: {userName} and surname: {userSurname} is not registered in the system");
            }

            var tax = await _taxRepository.GetTownByNameAndYear(taxName, taxYear).ConfigureAwait(false);

            if (tax == null)
            {
                throw new AelNotFoundException($"The Tax with name: {taxName} from year: {taxYear} is not registered in the system");
            }

            var userTax = await _userTaxRepository.GetUserTaxesByUserIdAndReference(user.Id, reference).ConfigureAwait(false);

            if (userTax == null)
            {
                throw new AelNotFoundException($"The Tax with name: {taxName} from year: {taxYear} is not assigned to user with name {userName} and surname {userSurname}");
            }

            if(userTax.PaymentDeadlineDate < DateTime.UtcNow)
            {
                throw new UserTaxPaymentExpiredException($"The Payment Day has expired, please get the new amount");
            }

            userTax.PaymentDate = DateTime.UtcNow;
            userTax.Paid = true;
            await _userTaxRepository.UpdateUserTax(userTax).ConfigureAwait(false);
        }
    }
}
