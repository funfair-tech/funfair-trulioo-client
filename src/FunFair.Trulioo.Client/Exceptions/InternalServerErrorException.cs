using System;

namespace FunFair.Trulioo.Client.Exceptions
{
    /// <inheritdoc />
    public sealed class InternalServerErrorException : RequestException
    {
        /// <inheritdoc />
        internal InternalServerErrorException(string message, int code, string reason)
            : base(message: message, code: code, reason: reason)
        {
        }

        /// <inheritdoc />
        public InternalServerErrorException()
            : base(message: "", code: -1, reason: "")
        {
        }

        /// <inheritdoc />
        public InternalServerErrorException(string message)
            : base(message: message, code: -1, reason: "")
        {
        }

        /// <inheritdoc />
        public InternalServerErrorException(string message, Exception innerException)
            : base(message: message, code: -1, reason: innerException.Message)
        {
        }
    }
}