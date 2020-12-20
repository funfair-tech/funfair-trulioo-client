using System;

namespace FunFair.Trulioo.Client.Exceptions
{
    /// <inheritdoc />
    public sealed class AuthenticationFailureException : RequestException
    {
        /// <inheritdoc />
        internal AuthenticationFailureException(string message, int code, string reason)
            : base(message: message, code: code, reason: reason)
        {
        }

        /// <inheritdoc />
        // ReSharper disable once UnusedMember.Global
        public AuthenticationFailureException()
            : base(message: "", code: -1, reason: "")
        {
        }

        /// <inheritdoc />
        // ReSharper disable once UnusedMember.Global
        public AuthenticationFailureException(string message)
            : base(message: message, code: -1, reason: "")
        {
        }

        /// <inheritdoc />
        // ReSharper disable once UnusedMember.Global
        public AuthenticationFailureException(string message, Exception innerException)
            : base(message: message, code: -1, reason: innerException.Message)
        {
        }
    }
}