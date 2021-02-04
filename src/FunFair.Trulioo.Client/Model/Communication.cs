using System.Diagnostics.CodeAnalysis;

namespace FunFair.Trulioo.Client.Model
{
    /// <summary>
    ///     Communication details.
    /// </summary>
    [SuppressMessage(category: "ReSharper", checkId: "ClassNeverInstantiated.Global", Justification = "TODO: Review")]
    public class Communication
    {
        /// <summary>
        ///     Mobile phone number
        /// </summary>

        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public string MobileNumber { get; set; }

        /// <summary>
        ///     Telephone number of the individual to be verified
        /// </summary>

        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public string Telephone { get; set; }

        /// <summary>
        ///     Email address of the individual to be verified
        /// </summary>

        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public string EmailAddress { get; set; }
    }
}