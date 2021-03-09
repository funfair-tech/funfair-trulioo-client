using System.Diagnostics.CodeAnalysis;

namespace FunFair.Trulioo.Client.Model
{
    /// <summary>
    ///     Drivers license.
    /// </summary>

    [SuppressMessage(category: "ReSharper", checkId: "ClassNeverInstantiated.Global", Justification = "TODO: Review")]
    public class DriverLicence
    {
        /// <summary>
        ///     Driver's Licence Number of the individual to be verified
        /// </summary>


        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public string Number { get; set; }

        /// <summary>
        ///     State of issue for driver's Licence
        /// </summary>


        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public string State { get; set; }

        /// <summary>
        ///     Driver's Licence day of expiry of the individual to be verified
        /// </summary>


        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public int? DayOfExpiry { get; set; }

        /// <summary>
        ///     Driver's Licence month of expiry of the individual to be verified
        /// </summary>


        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public int? MonthOfExpiry { get; set; }

        /// <summary>
        ///     Driver's Licence year of expiry of the individual to be verified
        /// </summary>


        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public int? YearOfExpiry { get; set; }
    }
}
