using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Devon4Net.Domain.UnitOfWork.Repository;
using Devon4Net.Infrastructure.Log;
using Devon4Net.WebAPI.Implementation.Domain.Database;
using Devon4Net.WebAPI.Implementation.Domain.Entities;
using Devon4Net.WebAPI.Implementation.Domain.RepositoryInterfaces;

namespace Devon4Net.WebAPI.Implementation.Data.Repositories
{
    /// <summary>
    /// Repository implementation for the Taxes
    /// </summary>
    public class TaxRepository : Repository<Tax>, ITaxRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"></param>
        public TaxRepository(AelContext context) : base(context)
        {
        }

        public Task<Tax> GetTaxById(Guid taxId)
        {
            Devon4NetLogger.Debug($"GetTaxById method from repository TaxesRepository with value : {taxId}");
            return GetFirstOrDefault(t => t.Id == taxId);
        }

        /// <summary>
        /// Get the Tax by name and year
        /// </summary>
        public Task<Tax> GetTaxByNameAndYear(string taxName, int taxYear)
        {
            Devon4NetLogger.Debug($"GetTownByNameAndYear method from repository TaxesRepository with value : {taxName} & {taxYear}");
            return GetFirstOrDefault(t => t.TaxName == taxName && t.Year == taxYear);
        }
    }
}
