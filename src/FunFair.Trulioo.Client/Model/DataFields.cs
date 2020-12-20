namespace FunFair.Trulioo.Client.Model
{
    /// <summary>
    ///     The data field name-value pairs for the data elements on which the verification is to be performed
    /// </summary>
    // ReSharper disable once ClassNeverInstantiated.Global
    public class DataFields
    {
        /// <summary>
        ///     Personal Information
        /// </summary>
        // ReSharper disable once UnusedMember.Global
        public PersonInfo PersonInfo { get; set; }

        /// <summary>
        ///     Location Information
        /// </summary>
        // ReSharper disable once UnusedMember.Global
        public Location Location { get; set; }

        /// <summary>
        ///     Communication Information
        /// </summary>
        // ReSharper disable once UnusedMember.Global
        public Communication Communication { get; set; }

        /// <summary>
        ///     Driver Licence Information
        /// </summary>
        // ReSharper disable once UnusedMember.Global
        public DriverLicence DriverLicence { get; set; }

        /// <summary>
        ///     National Identification Information
        ///     Supported Types: NationalID, Health, SocialService
        /// </summary>
        // ReSharper disable once UnusedMember.Global
        public NationalId[] NationalIds { get; set; }

        /// <summary>
        ///     Passport information
        /// </summary>
        // ReSharper disable once UnusedMember.Global
        public Passport Passport { get; set; }

        /// <summary>
        ///     Country Specific fields {"CountryCode" : "Field1" : "Value", "Field2" : "Value" }
        /// </summary>
        // ReSharper disable once UnusedMember.Global
        public CountrySpecific CountrySpecific { get; set; }

        /// <summary>
        ///     Document Information for Document Verification
        /// </summary>
        // ReSharper disable once UnusedMember.Global
        public Document Document { get; set; }
    }
}