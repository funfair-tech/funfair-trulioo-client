using System.Diagnostics.CodeAnalysis;

namespace FunFair.Trulioo.Client.Model
{
    /// <summary>
    ///     Passport details.
    /// </summary>

    [SuppressMessage(category: "ReSharper", checkId: "ClassNeverInstantiated.Global", Justification = "TODO: Review")]
    public class Passport
    {
        /// <summary>
        ///     Line 1 of the passport MRZ
        /// </summary>


        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public string Mrz1 { get; set; }

        /// <summary>
        ///     line 2 of the passport MRZ
        /// </summary>


        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public string Mrz2 { get; set; }

        /// <summary>
        ///     Passport Number
        /// </summary>


        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public string Number { get; set; }

        /// <summary>
        ///     Passport's Licence day of expiry of the individual to be verified
        /// </summary>


        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public int? DayOfExpiry { get; set; }

        /// <summary>
        ///     Passport's Licence month of expiry of the individual to be verified
        /// </summary>


        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public int? MonthOfExpiry { get; set; }

        /// <summary>
        ///     Passport's Licence year of expiry of the individual to be verified
        /// </summary>


        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public int? YearOfExpiry { get; set; }
    }
}
