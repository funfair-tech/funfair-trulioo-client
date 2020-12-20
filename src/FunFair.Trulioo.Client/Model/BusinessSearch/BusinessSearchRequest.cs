using System.Diagnostics.CodeAnalysis;

namespace FunFair.Trulioo.Client.Model.BusinessSearch
{
    /// <summary>
    ///     The request to be passed to Client for a business search
    /// </summary>
    // ReSharper disable once ClassNeverInstantiated.Global
    public class BusinessSearchRequest
    {
        /// <summary>
        ///     Indicate that Trulioo terms and conditions are accepted
        ///     The Verification request will be executed only if the value of this header is passed as 'true'.
        /// </summary>
        // ReSharper disable once UnusedMember.Global
        public bool AcceptTruliooTermsAndConditions { get; set; }

        /// <summary>
        ///     If set, the transaction will run asyncronously and trulioo will try to update the client with transaction state
        ///     updates until completed.
        /// </summary>
        [SuppressMessage(category: "CA1056", checkId: "CA1056", Justification = "Third party code")]
        // ReSharper disable once UnusedMember.Global
        public string CallBackUrl { get; set; }

        /// <summary>
        ///     The consent for the data sources which will be interrogated as a part of the request.
        ///     Included only for the data sources which explicitly require consent
        /// </summary>
        // ReSharper disable once UnusedMember.Global
        public string[] ConsentForDataSources { get; set; }

        /// <summary>
        ///     The country code for which the verification needs to be performed
        ///     Two-letter alpha code for the country for which the verification needs to be performed.
        ///     Call configuration/v1/countrycodes/{configurationname} to get the countries that are valid for you.
        /// </summary>
        // ReSharper disable once UnusedMember.Global
        public string CountryCode { get; set; }

        // ReSharper disable once UnusedMember.Global
        public BusinessSearchModel Business { get; set; }
    }
}