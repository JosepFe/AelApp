using Devon4Net.Domain.UnitOfWork.Repository;
using Devon4Net.WebAPI.Implementation.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Devon4Net.WebAPI.Implementation.Domain.RepositoryInterfaces
{
    /// <summary>
    /// UserTownRepository interface
    /// </summary>
    public interface IUserTaxRepository : IRepository<UserTax>
    {
        Task CreateUserTax(Guid taxId, Guid userId, Guid townId, DateTime paymentDeadLine, double baseAmount, string reference);
        Task<IList<UserTax>> GetUserTaxesByUserId(Guid userId);
        Task<UserTax> GetUserTaxesByUserIdAndReferenceAndTaxId(Guid userId, string reference, Guid taxId);
        Task<UserTax> GetUserTaxesByUserIdAndReference(Guid userId, string reference);
        Task UpdateUserTax(UserTax userTax);
    }
}
