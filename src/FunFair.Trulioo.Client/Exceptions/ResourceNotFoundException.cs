using System;

namespace FunFair.Trulioo.Client.Exceptions
{
    /// <inheritdoc />
    public sealed class ResourceNotFoundException : RequestException
    {
        /// <inheritdoc />
        internal ResourceNotFoundException(string message, int code, string reason)
            : base(message, code, reason)
        {
        }

        /// <inheritdoc />
        public ResourceNotFoundException()
            : base("", -1, "")
        {
        }

        /// <inheritdoc />
        public ResourceNotFoundException(string message)
            : base(message, -1, "")
        {
        }

        /// <inheritdoc />
        public ResourceNotFoundException(string message, Exception innerException)
            : base(message, -1, innerException?.Message)
        {
        }
    }
}