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
            : base(message: "", code: -1, reason: "")
        {
        }

        /// <inheritdoc />
        public UnauthorizedAccessException(string message)
            : base(message, code: -1, reason: "")
        {
        }

        /// <inheritdoc />
        public UnauthorizedAccessException(string message, Exception innerException)
            : base(message, code: -1, innerException.Message)
        {
        }
    }
}