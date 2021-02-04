using System.Diagnostics.CodeAnalysis;

namespace FunFair.Trulioo.Client.Model.Errors
{
    /// <summary>
    ///     A Service error.
    /// </summary>
    [SuppressMessage(category: "ReSharper", checkId: "ClassNeverInstantiated.Global", Justification = "TODO: Review")]
    public class ServiceError
    {
        /// <summary>
        ///     Error code.
        /// </summary>

        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public string Code { get; set; }

        /// <summary>
        ///     Error message.
        /// </summary>

        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public string Message { get; set; }
    }
}