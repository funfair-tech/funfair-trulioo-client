using System;
using System.Diagnostics.CodeAnalysis;

namespace FunFair.Trulioo.Client.Exceptions
{
    /// <inheritdoc />
    public sealed class AuthenticationFailureException : RequestException
    {
        /// <inheritdoc />
        internal AuthenticationFailureException(string message, int code, string reason)
            : base(message, code, reason)
        {
        }

        /// <inheritdoc />
        public AuthenticationFailureException()
            : base("", -1, "")
        {
        }

        /// <inheritdoc />
        public AuthenticationFailureException(string message)
            : base(message, -1, "")
        {
        }

        /// <inheritdoc />
        public AuthenticationFailureException(string message, Exception innerException)
            : base(message, -1, innerException?.Message)
        {
        }
    }
}