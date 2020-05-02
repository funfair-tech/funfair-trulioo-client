using System;

namespace FunFair.Trulioo.Client.Exceptions
{
    /// <inheritdoc />
    public sealed class ResourceNotFoundException : RequestException
    {
        /// <inheritdoc />
        internal ResourceNotFoundException(string message, int code, string reason)
            : base(message: message, code: code, reason: reason)
        {
        }

        /// <inheritdoc />
        public ResourceNotFoundException()
            : base(message: "", code: -1, reason: "")
        {
        }

        /// <inheritdoc />
        public ResourceNotFoundException(string message)
            : base(message: message, code: -1, reason: "")
        {
        }

        /// <inheritdoc />
        public ResourceNotFoundException(string message, Exception innerException)
            : base(message: message, code: -1, reason: innerException.Message)
        {
        }
    }
}