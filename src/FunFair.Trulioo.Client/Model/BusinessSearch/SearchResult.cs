using System.Diagnostics.CodeAnalysis;

namespace FunFair.Trulioo.Client.Model.BusinessSearch
{
    /// <summary>
    ///     Name-value pairs returned from Business Search returned from one datasource
    /// </summary>
    [SuppressMessage(category: "ReSharper", checkId: "ClassNeverInstantiated.Global", Justification = "TODO: Review")]
    public class SearchResult
    {
        /// <summary>
        ///     Index in the SearchResult
        /// </summary>
        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public string Index { get; set; }

        /// <summary>
        ///     Name of the Business
        /// </summary>
        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public string BusinessName { get; set; }

        /// <summary>
        ///     Business Name Matching Score
        /// </summary>
        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public string MatchingScore { get; set; }

        /// <summary>
        ///     Registration Number of the Business
        /// </summary>
        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public string BusinessRegistrationNumber { get; set; }

        /// <summary>
        ///     Duns Number
        /// </summary>
        [SuppressMessage(category: "ReSharper", checkId: "InconsistentNaming", Justification = "TODO: Review")]
        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public string DUNSNumber { get; set; }

        /// <summary>
        ///     TaxIDNumber of the Business
        /// </summary>
        [SuppressMessage(category: "ReSharper", checkId: "InconsistentNaming", Justification = "TODO: Review")]
        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public string BusinessTaxIDNumber { get; set; }

        /// <summary>
        ///     Licence Number of the Business
        /// </summary>
        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public string BusinessLicenseNumber { get; set; }

        /// <summary>
        ///     Jurisdiction of Incorporation of the Business
        /// </summary>
        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public string JurisdictionOfIncorporation { get; set; }

        /// <summary>
        ///     Full Address
        /// </summary>
        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public string FullAddress { get; set; }

        /// <summary>
        ///     Business Status
        /// </summary>
        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public string BusinessStatus { get; set; }

        /// <summary>
        ///     Trade Style Name
        /// </summary>
        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public string TradeStyleName { get; set; }

        /// <summary>
        ///     Business Type
        /// </summary>
        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public string BusinessType { get; set; }

        /// <summary>
        ///     Address Components
        /// </summary>
        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public SearchResultAddress Address { get; set; }
    }
}