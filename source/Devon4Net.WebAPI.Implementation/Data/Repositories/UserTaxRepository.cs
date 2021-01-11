using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Devon4Net.Domain.UnitOfWork.Repository;
using Devon4Net.Infrastructure.Log;
using Devon4Net.WebAPI.Implementation.Business.InhabitantsManagement.Exceptions;
using Devon4Net.WebAPI.Implementation.Domain.Database;
using Devon4Net.WebAPI.Implementation.Domain.Entities;
using Devon4Net.WebAPI.Implementation.Domain.RepositoryInterfaces;

namespace Devon4Net.WebAPI.Implementation.Data.Repositories
{
    /// <summary>
    /// Repository implementation for the TODOS
    /// </summary>
    public class UserTaxRepository : Repository<UserTax>, IUserTaxRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"></param>
        public UserTaxRepository(AelContext context) : base(context)
        {
        }

        public async Task CreateUserTax(Guid taxId, Guid userId, DateTime paymentDeadLine, double baseAmount, string reference)
        {
            Devon4NetLogger.Debug($"CreateUserTax method from repository UserTaxRepository with value : {taxId}, {userId}, {paymentDeadLine}, {baseAmount} & {reference}");

            var userTax = new UserTax { TaxId = taxId ,UserId = userId, BaseAmount = baseAmount, AmountToPay = baseAmount, PaymentDeadlineDate = paymentDeadLine, AssignmentDate = DateTime.UtcNow, Reference = reference };

            await Create(userTax).ConfigureAwait(false);
        }

        public Task<IList<UserTax>> GetUserTaxesByUserId(Guid userId)
        {
            Devon4NetLogger.Debug($"GetUserTaxesByUserId method from repository UserTaxRepository with value : {userId}");
            
            return Get(x => x.UserId == userId);
        }

        public Task<UserTax> GetUserTaxesByUserIdAndReference(Guid userId, string reference)
        {
            return GetFirstOrDefault(x => x.UserId == userId && x.Reference == reference);
        }

        public Task<UserTax> GetUserTaxesByUserIdAndReferenceAndTaxId(Guid userId, string reference, Guid taxId)
        {
            return GetFirstOrDefault(x => x.UserId == userId && x.Reference == reference && x.TaxId == taxId);
        }

        public async Task UpdateUserTax(UserTax userTax)
        {
            Devon4NetLogger.Debug($"UpdateUserTax method from repository UserTaxRepository with value : {userTax}");

            await Update(userTax).ConfigureAwait(false);
        }
    }
}
