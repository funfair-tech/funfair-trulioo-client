using System.Diagnostics.CodeAnalysis;
using FunFair.Trulioo.Client.Model.PersonalInfoFields;

namespace FunFair.Trulioo.Client.Model
{
    /// <summary>
    ///     Details about a person.
    /// </summary>
    [SuppressMessage(category: "ReSharper", checkId: "ClassNeverInstantiated.Global", Justification = "TODO: Review")]
    public class PersonInfo
    {
        /// <summary>
        ///     First name of the individual to be verified
        ///     Dual purpose First Name or Initial
        /// </summary>

        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public string FirstGivenName { get; set; }

        /// <summary>
        ///     Second given name of the individual to be verified
        ///     Dual purpose Middle Name or Initial
        /// </summary>

        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public string MiddleName { get; set; }

        /// <summary>
        ///     First (paternal) family name of the individual to be verified
        /// </summary>

        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public string FirstSurName { get; set; }

        /// <summary>
        ///     second family name of the individual to be verified
        /// </summary>

        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public string SecondSurname { get; set; }

        /// <summary>
        ///     Enter full name in ISO Latin-1 character set
        ///     Used for data sources that require the person’s name in ISO Latin-1 format (i.e. as Passport MRZ)
        /// </summary>

        [SuppressMessage(category: "ReSharper", checkId: "InconsistentNaming", Justification = "TODO: Review")]
        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public string ISOLatin1Name { get; set; }

        /// <summary>
        ///     Day of birth date (i.e. 23 for a date of birth of 23/11/1975)
        /// </summary>

        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public int? DayOfBirth { get; set; }

        /// <summary>
        ///     Month of birth date (i.e. 11 for a date of birth of 23/11/1975)
        /// </summary>

        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public int? MonthOfBirth { get; set; }

        /// <summary>
        ///     Year of birth date (i.e. 1975 for a date of birth of 23/11/1975)
        /// </summary>

        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public int? YearOfBirth { get; set; }

        /// <summary>
        ///     Minimum permitted age of the individual
        ///     GlobalGateway calculates age of individual and compares it to this number
        /// </summary>

        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public int? MinimumAge { get; set; }

        /// <summary>
        ///     Single character M / F (M = Male, F = Female)
        /// </summary>

        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public string Gender { get; set; }

        /// <summary>
        ///     Not part of trulioo v1 API spec
        /// </summary>

        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public AdditionalFields AdditionalFields { get; set; } = new();
    }
}