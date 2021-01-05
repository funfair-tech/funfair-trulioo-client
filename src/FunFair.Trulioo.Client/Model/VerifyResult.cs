using System;
using System.Collections.Generic;
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

        // ReSharper disable once InconsistentNaming
        // ReSharper disable once UnusedMember.Global
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        // ReSharper disable once AutoPropertyCanBeMadeGetOnly.Global
        public string TransactionID { get; set; }

        /// <summary>
        ///     Time in UTC
        /// </summary>

        // ReSharper disable once UnusedMember.Global
        public DateTime UploadedDt { get; set; }

        /// <summary>
        ///     Record.
        /// </summary>

        // ReSharper disable once UnusedMember.Global
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

        // ReSharper disable once UnusedMember.Global
        public IEnumerable<ServiceError> Errors { get; set; }

        /// <summary>
        ///     Country code
        /// </summary>

        // ReSharper disable once UnusedMember.Global
        public string CountryCode { get; set; }

        /// <summary>
        ///     Product Name.
        /// </summary>

        // ReSharper disable once UnusedMember.Global
        public string ProductName { get; set; }
    }
}