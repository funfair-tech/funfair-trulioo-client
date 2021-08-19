using System.Diagnostics.CodeAnalysis;

namespace FunFair.Trulioo.Client.Model.Errors
{
    /// <summary>
    ///     Provides a class that represents a Trulioo service response error message.
    /// </summary>
    [SuppressMessage(category: "ReSharper", checkId: "ClassCanBeSealed.Global", Justification = "TODO: Review")]
    public class Error
    {
        /// <summary>
        ///     Gets the code of the current <see cref="Error" />.
        /// </summary>
        /// <value>
        ///     Code of the current <see cref="Error" />.
        /// </value>

        public int Code { get; init; }

        /// <summary>
        ///     Gets the reason of the current <see cref="Error" />.
        /// </summary>
        /// <value>
        ///     Reason of the current <see cref="Error" />.
        /// </value>

        public string Reason { get; init; }

        /// <summary>
        ///     Gets the message of the current <see cref="Error" />.
        /// </summary>
        /// <value>
        ///     Message of the current <see cref="Error" />.
        /// </value>

        public string Message { get; init; }

        /// <summary>
        ///     Gets a string representation for the current <see cref="Error" />.
        /// </summary>
        /// <returns>
        ///     A string representation of the current <see cref="Error" />.
        /// </returns>
        public override string ToString()
        {
            return $"{this.Code}:{this.Message}";
        }
    }
}