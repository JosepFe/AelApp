using Devon4Net.Infrastructure.Common.Exceptions;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Devon4Net.WebAPI.Implementation.Business.InhabitantsManagement.Exceptions
{
    /// <summary>
    /// Custom exception UserAlreadyExistException
    /// </summary>
    [Serializable]
    public class UserAlreadyExistException : Exception, IWebApiException
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
        /// Initializes a new instance of the <see cref="UserAlreadyExistException"/> class.
        /// </summary>
        public UserAlreadyExistException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserAlreadyExistException"/> class.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public UserAlreadyExistException(string message)
            : base(message)
        {
        }
    }
}
