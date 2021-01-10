using Devon4Net.Infrastructure.Common.Exceptions;
using Microsoft.AspNetCore.Http;
using System;

namespace Devon4Net.WebAPI.Implementation.Business.InhabitantsManagement.Exceptions
{
    /// <summary>
    /// Custom exception UserTaxPaymentExpiredException
    /// </summary>
    [Serializable]
    public class UserTaxPaymentExpiredException : Exception, IWebApiException
    {
        /// <summary>
        /// The forced http status code to be fired on the exception manager
        /// </summary>
        public int StatusCode => StatusCodes.Status400BadRequest;

        /// <summary>
        /// Show the message on the response?
        /// </summary>
        public bool ShowMessage => true;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserTaxPaymentExpiredException"/> class.
        /// </summary>
        public UserTaxPaymentExpiredException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserTaxPaymentExpiredException"/> class.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public UserTaxPaymentExpiredException(string message)
            : base(message)
        {
        }
    }
}
