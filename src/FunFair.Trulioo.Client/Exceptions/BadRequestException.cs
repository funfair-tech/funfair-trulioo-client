using System;

namespace FunFair.Trulioo.Client.Exceptions
{
    public sealed class BadRequestException : RequestException
    {
        internal BadRequestException(string message, int code, string reason)
            : base(message, code, reason)
        {
        }

        /// <inheritdoc />
        public BadRequestException()
            : base("", -1, "")
        {
        }

        /// <inheritdoc />
        public BadRequestException(string message)
            : base(message, -1, "")
        {
        }

        /// <inheritdoc />
        public BadRequestException(string message, Exception innerException)
            : base(message, -1, innerException?.Message)
        {
        }
    }
}