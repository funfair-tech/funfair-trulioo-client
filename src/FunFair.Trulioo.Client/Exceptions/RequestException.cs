using System;
using System.Diagnostics.CodeAnalysis;

namespace FunFair.Trulioo.Client.Exceptions
{
    /// <inheritdoc />
    public class RequestException : Exception
    {
        /// <inheritdoc />
        protected internal RequestException(string message, int code, string reason)
            : base(message)
        {
            this.Code = code;
            this.Reason = reason;
        }

        /// <inheritdoc />
        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public RequestException()
        {
        }

        /// <inheritdoc />
        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public RequestException(string message)
            : base(message)
        {
        }

        /// <inheritdoc />
        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public RequestException(string message, Exception innerException)
            : base(message: message, innerException: innerException)
        {
        }

        /// <summary>
        ///     Gets the code of the current <see cref="RequestException" />.
        /// </summary>
        /// <value>
        ///     Code of the current <see cref="RequestException" />.
        /// </value>
        [SuppressMessage(category: "ReSharper", checkId: "UnusedAutoPropertyAccessor.Local", Justification = "TODO: Review")]
        private int Code { get; }

        /// <summary>
        ///     Gets the reason of the current <see cref="RequestException" />.
        /// </summary>
        /// <value>
        ///     Reason of the current <see cref="RequestException" />.
        /// </value>
        private string Reason { get; }

        /// <inheritdoc />
        public override string Message =>
            string.IsNullOrEmpty(base.Message)
                ? this.Reason
                : base.Message;
    }
}