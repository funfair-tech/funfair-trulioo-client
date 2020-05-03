using System;

namespace FunFair.Trulioo.Client.Exceptions
{
    public sealed class BadRequestException : RequestException
    {
        internal BadRequestException(string message, int code, string reason)
            : base(message: message, code: code, reason: reason)
        {
        }

        /// <inheritdoc />
        public BadRequestException()
            : base(message: "", code: -1, reason: "")
        {
        }

        /// <inheritdoc />
        public BadRequestException(string message)
            : base(message: message, code: -1, reason: "")
        {
        }

        /// <inheritdoc />
        public BadRequestException(string message, Exception innerException)
            : base(message: message, code: -1, reason: innerException.Message)
        {
        }
    }
}