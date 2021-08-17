using System.Diagnostics.CodeAnalysis;

namespace FunFair.Trulioo.Client.Model
{
    /// <summary>
    ///     Verification request.
    /// </summary>
    [SuppressMessage(category: "ReSharper", checkId: "ClassNeverInstantiated.Global", Justification = "TODO: Review")]
    public class VerifyRequest
    {
        /// <summary>
        ///     Indicate that Trulioo terms and conditions are accepted
        ///     The Verification request will be executed only if the value of this header is passed as 'true'.
        /// </summary>
        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public bool AcceptTruliooTermsAndConditions { get; set; }

        /// <summary>
        ///     Indicate a demo verifications
        ///     If the value of pair is 'true', then the data passed will be matched against pre-configured test entities defined
        ///     through the Trulioo web portal, the verification will not be charged to the customer. Default value for those pairs will be false.
        /// </summary>
        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public bool Demo { get; set; }

        /// <summary>
        ///     set to true if you want to receive address cleanse information,
        ///     This will only change the response if you have address cleansing enabled for the country you are querying for.
        /// </summary>
        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public bool CleansedAddress { get; set; }

        /// <summary>
        ///     Indicate the type of verification
        ///     Default value will be 'Identity Verification'
        /// </summary>
        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public string ConfigurationName { get; set; }

        /// <summary>
        ///     The consent for the data sources which will be interrogated as a part of the request.
        ///     Included only for the data sources which explicitly require consent
        /// </summary>
        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public string[] ConsentForDataSources { get; set; }

        /// <summary>
        ///     The country code for which the verification needs to be performed
        ///     Two-letter alpha code for the country for which the verification needs to be performed.
        ///     Call configuration/v1/countrycodes/{configurationname} to get the countries that are valid for you.
        /// </summary>
        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public string CountryCode { get; set; }

        /// <summary>
        ///     The data field name-value pairs for the data elements on which the verification is to be performed
        /// </summary>
        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public DataFields DataFields { get; set; }

        /// <summary>
        ///     Verbose Mode output flag. Default value will be false.
        /// </summary>
        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public bool VerboseMode { get; set; }
    }
}