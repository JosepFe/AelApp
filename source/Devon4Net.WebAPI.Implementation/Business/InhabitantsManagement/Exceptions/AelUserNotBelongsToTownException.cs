using Devon4Net.Infrastructure.Common.Exceptions;
using Microsoft.AspNetCore.Http;
using System;

namespace Devon4Net.WebAPI.Implementation.Business.InhabitantsManagement.Exceptions
{
    /// <summary>
    /// Custom exception AelUserNotBelongsToTownException
    /// </summary>
    [Serializable]
    public class AelUserNotBelongsToTownException : Exception, IWebApiException
    {
        /// <summary>
        /// The forced http status code to be fired on the exception manager
        /// </summary>
        public int StatusCode => StatusCodes.Status409Conflict;

        /// <summary>
        /// Show the message on the response?
        /// </summary>
        public bool ShowMessage => true;

        /// <summary>
        /// Initializes a new instance of the <see cref="AelUserNotBelongsToTownException"/> class.
        /// </summary>
        public AelUserNotBelongsToTownException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AelUserNotBelongsToTownException"/> class.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public AelUserNotBelongsToTownException(string message)
            : base(message)
        {
        }
    }
}
