using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using FunFair.Trulioo.Client.Model.Errors;

namespace FunFair.Trulioo.Client.Model.BusinessSearch
{
    /// <summary>
    ///     Response object returned from Business Search containing metadata and results from search
    /// </summary>
    [SuppressMessage(category: "ReSharper", checkId: "ClassNeverInstantiated.Global", Justification = "TODO: Review")]
    public class BusinessSearchResponse
    {
        /// <summary>
        ///     The id for the transaction it will be a GUID
        /// </summary>
        [SuppressMessage(category: "ReSharper", checkId: "InconsistentNaming", Justification = "TODO: Review")]
        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public string TransactionID { get; set; }

        /// <summary>
        ///     Time in UTC
        /// </summary>
        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public DateTime UploadedDt { get; set; }

        /// <summary>
        ///     The country code for which the verification was performed.
        /// </summary>
        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public string CountryCode { get; set; }

        /// <summary>
        ///     Product Name
        /// </summary>
        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public string ProductName { get; set; }

        /// <summary>
        ///     RecordResult for the Business Search
        /// </summary>
        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public BusinessRecord Record { get; set; }

        /// <summary>
        ///     Collection of record errors
        /// </summary>
        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public List<ServiceError> Errors { get; set; }
    }
}


