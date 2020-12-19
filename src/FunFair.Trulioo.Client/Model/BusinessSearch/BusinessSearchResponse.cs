using System;
using System.Collections.Generic;
using FunFair.Trulioo.Client.Model.Errors;

namespace FunFair.Trulioo.Client.Model.BusinessSearch
{
    /// <summary>
    ///     Response object returned from Business Search containing metadata and results from search
    /// </summary>
    public class BusinessSearchResponse
    {
        /// <summary>
        ///     The id for the transaction it will be a GUID
        /// </summary>
        // ReSharper disable once InconsistentNaming
        // ReSharper disable once UnusedMember.Global
        public string TransactionID { get; set; }

        /// <summary>
        ///     Time in UTC
        /// </summary>
        // ReSharper disable once UnusedMember.Global
        public DateTime UploadedDt { get; set; }

        /// <summary>
        ///     The country code for which the verification was performed.
        /// </summary>
        // ReSharper disable once UnusedMember.Global
        public string CountryCode { get; set; }

        /// <summary>
        ///     Product Name
        /// </summary>
        // ReSharper disable once UnusedMember.Global
        public string ProductName { get; set; }

        /// <summary>
        ///     RecordResult for the Business Search
        /// </summary>
        // ReSharper disable once UnusedMember.Global
        public BusinessRecord Record { get; set; }

        /// <summary>
        ///     Collection of record errors
        /// </summary>
        // ReSharper disable once UnusedMember.Global
        public List<ServiceError> Errors { get; set; }
    }
}