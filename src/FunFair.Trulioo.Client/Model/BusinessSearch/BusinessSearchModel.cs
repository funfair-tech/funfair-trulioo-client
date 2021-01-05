namespace FunFair.Trulioo.Client.Model.BusinessSearch
{
    /// <summary>
    ///     Search Model containing name-value pairs to be used for Business Search
    /// </summary>

    // ReSharper disable once ClassNeverInstantiated.Global
    public class BusinessSearchModel
    {
        /// <summary>
        ///     Name of the business to be verified
        /// </summary>

        // ReSharper disable once UnusedMember.Global
        public string BusinessName { get; set; }

        /// <summary>
        ///     Jurisdiction Of Incorporation of the business to be verified
        /// </summary>

        // ReSharper disable once UnusedMember.Global
        public string JurisdictionOfIncorporation { get; set; }

        /// <summary>
        ///     Duns Number
        /// </summary>

        // ReSharper disable once InconsistentNaming
        // ReSharper disable once UnusedMember.Global
        public string DUNSNumber { get; set; }

        /// <summary>
        ///     Location of the Business
        /// </summary>

        // ReSharper disable once UnusedMember.Global
        public Location Location { get; set; }
    }
}