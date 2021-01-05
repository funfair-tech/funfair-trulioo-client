namespace FunFair.Trulioo.Client.Model.BusinessSearch
{
    /// <summary>
    ///     Name-value pairs returned from Business Search returned from one datasource
    /// </summary>

    // ReSharper disable once ClassNeverInstantiated.Global
    public class SearchResult
    {
        /// <summary>
        ///     Index in the SearchResult
        /// </summary>

        // ReSharper disable once UnusedMember.Global
        public string Index { get; set; }

        /// <summary>
        ///     Name of the Business
        /// </summary>

        // ReSharper disable once UnusedMember.Global
        public string BusinessName { get; set; }

        /// <summary>
        ///     Business Name Matching Score
        /// </summary>

        // ReSharper disable once UnusedMember.Global
        public string MatchingScore { get; set; }

        /// <summary>
        ///     Registration Number of the Business
        /// </summary>

        // ReSharper disable once UnusedMember.Global
        public string BusinessRegistrationNumber { get; set; }

        /// <summary>
        ///     Duns Number
        /// </summary>

        // ReSharper disable once InconsistentNaming
        // ReSharper disable once UnusedMember.Global
        public string DUNSNumber { get; set; }

        /// <summary>
        ///     TaxIDNumber of the Business
        /// </summary>

        // ReSharper disable once InconsistentNaming
        // ReSharper disable once UnusedMember.Global
        public string BusinessTaxIDNumber { get; set; }

        /// <summary>
        ///     Licence Number of the Business
        /// </summary>

        // ReSharper disable once UnusedMember.Global
        public string BusinessLicenseNumber { get; set; }

        /// <summary>
        ///     Jurisdiction of Incorporation of the Business
        /// </summary>

        // ReSharper disable once UnusedMember.Global
        public string JurisdictionOfIncorporation { get; set; }

        /// <summary>
        ///     Full Address
        /// </summary>

        // ReSharper disable once UnusedMember.Global
        public string FullAddress { get; set; }

        /// <summary>
        ///     Business Status
        /// </summary>

        // ReSharper disable once UnusedMember.Global
        public string BusinessStatus { get; set; }

        /// <summary>
        ///     Trade Style Name
        /// </summary>

        // ReSharper disable once UnusedMember.Global
        public string TradeStyleName { get; set; }

        /// <summary>
        ///     Business Type
        /// </summary>

        // ReSharper disable once UnusedMember.Global
        public string BusinessType { get; set; }

        /// <summary>
        ///     Address Components
        /// </summary>

        // ReSharper disable once UnusedMember.Global
        public SearchResultAddress Address { get; set; }
    }
}