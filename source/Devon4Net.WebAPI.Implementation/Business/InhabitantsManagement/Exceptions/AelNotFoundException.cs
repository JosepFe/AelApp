using Devon4Net.Infrastructure.Common.Exceptions;
using Microsoft.AspNetCore.Http;
using System;

namespace Devon4Net.WebAPI.Implementation.Business.InhabitantsManagement.Exceptions
{
    /// <summary>
    /// Custom exception AelNotFoundException
    /// </summary>
    [Serializable]
    public class AelNotFoundException : Exception, IWebApiException
    {
        /// <summary>
        /// The forced http status code to be fired on the exception manager
        /// </summary>
        public int StatusCode => StatusCodes.Status404NotFound;

        /// <summary>
        /// Show the message on the response?
        /// </summary>
        public bool ShowMessage => true;

        /// <summary>
        /// Initializes a new instance of the <see cref="AelNotFoundException"/> class.
        /// </summary>
        public AelNotFoundException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AelNotFoundException"/> class.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public AelNotFoundException(string message)
            : base(message)
        {
        }
    }
}
