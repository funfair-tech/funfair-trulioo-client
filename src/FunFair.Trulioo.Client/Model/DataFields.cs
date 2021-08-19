using System.Diagnostics.CodeAnalysis;

namespace FunFair.Trulioo.Client.Model
{
    /// <summary>
    ///     The data field name-value pairs for the data elements on which the verification is to be performed
    /// </summary>
    [SuppressMessage(category: "ReSharper", checkId: "ClassNeverInstantiated.Global", Justification = "TODO: Review")]
    public class DataFields
    {
        /// <summary>
        ///     Personal Information
        /// </summary>
        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public PersonInfo PersonInfo { get; set; }

        /// <summary>
        ///     Location Information
        /// </summary>
        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public Location Location { get; set; }

        /// <summary>
        ///     Communication Information
        /// </summary>
        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public Communication Communication { get; set; }

        /// <summary>
        ///     Driver Licence Information
        /// </summary>
        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public DriverLicence DriverLicence { get; set; }

        /// <summary>
        ///     National Identification Information
        ///     Supported Types: NationalID, Health, SocialService
        /// </summary>
        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public NationalId[] NationalIds { get; set; }

        /// <summary>
        ///     Passport information
        /// </summary>
        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public Passport Passport { get; set; }

        /// <summary>
        ///     Country Specific fields {"CountryCode" : "Field1" : "Value", "Field2" : "Value" }
        /// </summary>
        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public CountrySpecific CountrySpecific { get; set; }

        /// <summary>
        ///     Document Information for Document Verification
        /// </summary>
        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public Document Document { get; set; }
    }
}