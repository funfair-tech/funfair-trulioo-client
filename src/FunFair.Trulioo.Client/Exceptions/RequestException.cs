﻿using System;

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
        // ReSharper disable once UnusedMember.Global
        public RequestException()
        {
        }

        /// <inheritdoc />
        // ReSharper disable once UnusedMember.Global
        public RequestException(string message)
            : base(message)
        {
        }

        /// <inheritdoc />
        // ReSharper disable once UnusedMember.Global
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

        // ReSharper disable once UnusedAutoPropertyAccessor.Local
        private int Code { get; }

        /// <summary>
        ///     Gets the reason of the current <see cref="RequestException" />.
        /// </summary>
        /// <value>
        ///     Reason of the current <see cref="RequestException" />.
        /// </value>
        private string Reason { get; }

        /// <inheritdoc />
        public override string Message => string.IsNullOrEmpty(base.Message) ? this.Reason : base.Message;
    }
}