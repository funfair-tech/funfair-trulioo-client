using System;

namespace FunFair.Trulioo.Client.Exceptions
{
    /// <inheritdoc />
    public sealed class UnauthorizedAccessException : RequestException
    {
        /// <inheritdoc />
        internal UnauthorizedAccessException(string message, int code, string reason)
            : base(message, code, reason)
        {
        }

        /// <inheritdoc />
        public UnauthorizedAccessException()
            : base("", -1, "")
        {
        }

        /// <inheritdoc />
        public UnauthorizedAccessException(string message)
            : base(message, -1, "")
        {
        }

        /// <inheritdoc />
        public UnauthorizedAccessException(string message, Exception innerException)
            : base(message, -1, innerException?.Message)
        {
        }
    }
}