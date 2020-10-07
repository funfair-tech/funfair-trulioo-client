namespace FunFair.Trulioo.Client.Model.BusinessSearch
{
    /// <summary>
    ///     Name-value pairs returned from Business Search returned from one datasource
    /// </summary>
    public class SearchResult
    {
        /// <summary>
        ///     Index in the SearchResult
        /// </summary>
        public string Index { get; set; }

        /// <summary>
        ///     Name of the Business
        /// </summary>
        public string BusinessName { get; set; }

        /// <summary>
        ///     Business Name Matching Score
        /// </summary>
        public string MatchingScore { get; set; }

        /// <summary>
        ///     Registration Number of the Business
        /// </summary>
        public string BusinessRegistrationNumber { get; set; }

        /// <summary>
        ///     Duns Number
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public string DUNSNumber { get; set; }

        /// <summary>
        ///     TaxIDNumber of the Business
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public string BusinessTaxIDNumber { get; set; }

        /// <summary>
        ///     Licence Number of the Business
        /// </summary>
        public string BusinessLicenseNumber { get; set; }

        /// <summary>
        ///     Jurisdiction of Incorporation of the Business
        /// </summary>
        public string JurisdictionOfIncorporation { get; set; }

        /// <summary>
        ///     Full Address
        /// </summary>
        public string FullAddress { get; set; }

        /// <summary>
        ///     Business Status
        /// </summary>
        public string BusinessStatus { get; set; }

        /// <summary>
        ///     Trade Style Name
        /// </summary>
        public string TradeStyleName { get; set; }

        /// <summary>
        ///     Business Type
        /// </summary>
        public string BusinessType { get; set; }

        /// <summary>
        ///     Address Components
        /// </summary>
        public SearchResultAddress Address { get; set; }
    }
}