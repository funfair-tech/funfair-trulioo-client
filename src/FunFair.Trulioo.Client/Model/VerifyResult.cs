using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using FunFair.Trulioo.Client.Model.Errors;

namespace FunFair.Trulioo.Client.Model
{
    /// <summary>
    ///     Verification result.
    /// </summary>
    public class VerifyResult
    {
        /// <summary>
        ///     Constructor.
        /// </summary>
        /// <param name="transactionId">Transaction id.</param>
        public VerifyResult(string transactionId)
        {
            this.TransactionID = transactionId;
        }

        /// <summary>
        ///     Transaction Id.
        /// </summary>
        [SuppressMessage(category: "ReSharper", checkId: "InconsistentNaming", Justification = "TODO: Review")]
        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        [SuppressMessage(category: "ReSharper", checkId: "UnusedAutoPropertyAccessor.Global", Justification = "TODO: Review")]
        [SuppressMessage(category: "ReSharper", checkId: "AutoPropertyCanBeMadeGetOnly.Global", Justification = "TODO: Review")]
        public string TransactionID { get; set; }

        /// <summary>
        ///     Time in UTC
        /// </summary>
        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public DateTime UploadedDt { get; set; }

        /// <summary>
        ///     Record.
        /// </summary>
        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public Record Record { get; set; }

        /// <summary>
        ///     <ul>
        ///         <li>1000 : Provider Error - There was an error connecting to the source</li>
        ///         <li>1001 : Missing Required Field</li>
        ///         <li>1002 : Datasource Unavailable - The source did not respond</li>
        ///         <li>1003 : Datasource Error - The source returned an error</li>
        ///         <li>1004 : State not supported (AU driver licence)</li>
        ///         <li>1005 : Missing Consent - consent not sent for the source</li>
        ///         <li>1008 : Invalid Field Format</li>
        ///         <li>2000 : Unrecognized Error</li>
        ///     </ul>
        /// </summary>
        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public IEnumerable<ServiceError> Errors { get; set; }

        /// <summary>
        ///     Country code
        /// </summary>
        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public string CountryCode { get; set; }

        /// <summary>
        ///     Product Name.
        /// </summary>
        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public string ProductName { get; set; }
    }
}


