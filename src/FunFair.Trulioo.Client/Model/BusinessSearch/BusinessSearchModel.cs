using System.Diagnostics.CodeAnalysis;

namespace FunFair.Trulioo.Client.Model.BusinessSearch
{
    /// <summary>
    ///     Search Model containing name-value pairs to be used for Business Search
    /// </summary>
    [SuppressMessage(category: "ReSharper", checkId: "ClassNeverInstantiated.Global", Justification = "TODO: Review")]
    public class BusinessSearchModel
    {
        /// <summary>
        ///     Name of the business to be verified
        /// </summary>
        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public string BusinessName { get; set; }

        /// <summary>
        ///     Jurisdiction Of Incorporation of the business to be verified
        /// </summary>
        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public string JurisdictionOfIncorporation { get; set; }

        /// <summary>
        ///     Duns Number
        /// </summary>
        [SuppressMessage(category: "ReSharper", checkId: "InconsistentNaming", Justification = "TODO: Review")]
        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public string DUNSNumber { get; set; }

        /// <summary>
        ///     Location of the Business
        /// </summary>
        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public Location Location { get; set; }
    }
}