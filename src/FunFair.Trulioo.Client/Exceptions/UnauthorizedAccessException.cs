using System;
using System.Diagnostics.CodeAnalysis;

namespace FunFair.Trulioo.Client.Exceptions
{
    /// <inheritdoc />
    public sealed class UnauthorizedAccessException : RequestException
    {
        /// <inheritdoc />
        internal UnauthorizedAccessException(string message, int code, string reason)
            : base(message: message, code: code, reason: reason)
        {
        }

        /// <inheritdoc />


        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public UnauthorizedAccessException()
            : base(message: "", code: -1, reason: "")
        {
        }

        /// <inheritdoc />


        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public UnauthorizedAccessException(string message)
            : base(message: message, code: -1, reason: "")
        {
        }

        /// <inheritdoc />


        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public UnauthorizedAccessException(string message, Exception innerException)
            : base(message: message, code: -1, reason: innerException.Message)
        {
        }
    }
}

