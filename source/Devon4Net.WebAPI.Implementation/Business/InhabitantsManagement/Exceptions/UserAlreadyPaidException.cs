using Devon4Net.Infrastructure.Common.Exceptions;
using Microsoft.AspNetCore.Http;
using System;

namespace Devon4Net.WebAPI.Implementation.Business.InhabitantsManagement.Exceptions
{
    /// <summary>
    /// Custom exception UserAlreadyPaidException
    /// </summary>
    [Serializable]
    public class UserAlreadyPaidException : Exception, IWebApiException
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
        /// Initializes a new instance of the <see cref="UserAlreadyPaidException"/> class.
        /// </summary>
        public UserAlreadyPaidException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserAlreadyPaidException"/> class.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public UserAlreadyPaidException(string message)
            : base(message)
        {
        }
    }
}
