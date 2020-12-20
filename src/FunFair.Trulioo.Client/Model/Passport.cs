namespace FunFair.Trulioo.Client.Model
{
    /// <summary>
    /// Passport details.
    /// </summary>
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Passport
    {
        /// <summary>
        ///     Line 1 of the passport MRZ
        /// </summary>
        // ReSharper disable once UnusedMember.Global
        public string Mrz1 { get; set; }

        /// <summary>
        ///     line 2 of the passport MRZ
        /// </summary>
        // ReSharper disable once UnusedMember.Global
        public string Mrz2 { get; set; }

        /// <summary>
        ///     Passport Number
        /// </summary>
        // ReSharper disable once UnusedMember.Global
        public string Number { get; set; }

        /// <summary>
        ///     Passport's Licence day of expiry of the individual to be verified
        /// </summary>
        // ReSharper disable once UnusedMember.Global
        public int? DayOfExpiry { get; set; }

        /// <summary>
        ///     Passport's Licence month of expiry of the individual to be verified
        /// </summary>
        // ReSharper disable once UnusedMember.Global
        public int? MonthOfExpiry { get; set; }

        /// <summary>
        ///     Passport's Licence year of expiry of the individual to be verified
        /// </summary>
        // ReSharper disable once UnusedMember.Global
        public int? YearOfExpiry { get; set; }
    }
}