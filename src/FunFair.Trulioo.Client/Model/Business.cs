namespace FunFair.Trulioo.Client.Model
{
    /// <summary>
    ///     Business class to hold name value pair to be passed for verification
    /// </summary>
    // ReSharper disable once UnusedType.Global
    public class Business
    {
        /// <summary>
        ///     Name of the business to be verified
        /// </summary>
        // ReSharper disable once UnusedMember.Global
        public string BusinessName { get; set; }

        /// <summary>
        ///     Registration number of business to be verified
        /// </summary>
        // ReSharper disable once UnusedMember.Global
        public string BusinessRegistrationNumber { get; set; }

        /// <summary>
        ///     Day of incorporation of the business to be verified
        /// </summary>
        // ReSharper disable once UnusedMember.Global
        public int? DayOfIncorporation { get; set; }

        /// <summary>
        ///     Month of incorporation of the business to be verified
        /// </summary>
        // ReSharper disable once UnusedMember.Global
        public int? MonthOfIncorporation { get; set; }

        /// <summary>
        ///     Year of incorporation of the business to be verified
        /// </summary>
        // ReSharper disable once UnusedMember.Global
        public int? YearOfIncorporation { get; set; }

        /// <summary>
        ///     Jurisdiction Of Incorporation of the business to be verified
        /// </summary>
        // ReSharper disable once UnusedMember.Global
        public string JurisdictionOfIncorporation { get; set; }

        /// <summary>
        ///     Whether or not to retrieve shareholderList document
        /// </summary>
        // ReSharper disable once UnusedMember.Global
        public bool? ShareholderListDocument { get; set; }

        /// <summary>
        ///     Whether or not to retrieve financial information document
        /// </summary>
        // ReSharper disable once UnusedMember.Global
        public bool? FinancialInformationDocument { get; set; }

        /// <summary>
        ///     Whether or not to retrieve enhanced profile
        /// </summary>
        // ReSharper disable once UnusedMember.Global
        public bool? EnhancedProfile { get; set; }

        /// <summary>
        ///     Duns Number
        /// </summary>
        // ReSharper disable once UnusedMember.Global
        public string DunsNumber { get; set; }

        /// <summary>
        ///     Whether or not to retrieve entity detail
        /// </summary>
        // ReSharper disable once UnusedMember.Global
        public bool? Entities { get; set; }
    }
}