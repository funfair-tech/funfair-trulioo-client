namespace FunFair.Trulioo.Client.Model
{
    /// <summary>
    /// Drivers license.
    /// </summary>
    // ReSharper disable once ClassNeverInstantiated.Global
    public class DriverLicence
    {
        /// <summary>
        ///     Driver's Licence Number of the individual to be verified
        /// </summary>
        // ReSharper disable once UnusedMember.Global
        public string Number { get; set; }

        /// <summary>
        ///     State of issue for driver's Licence
        /// </summary>
        // ReSharper disable once UnusedMember.Global
        public string State { get; set; }

        /// <summary>
        ///     Driver's Licence day of expiry of the individual to be verified
        /// </summary>
        // ReSharper disable once UnusedMember.Global
        public int? DayOfExpiry { get; set; }

        /// <summary>
        ///     Driver's Licence month of expiry of the individual to be verified
        /// </summary>
        // ReSharper disable once UnusedMember.Global
        public int? MonthOfExpiry { get; set; }

        /// <summary>
        ///     Driver's Licence year of expiry of the individual to be verified
        /// </summary>
        // ReSharper disable once UnusedMember.Global
        public int? YearOfExpiry { get; set; }
    }
}