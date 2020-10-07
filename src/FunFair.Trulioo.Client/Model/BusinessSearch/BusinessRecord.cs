﻿using System.Collections.Generic;
using FunFair.Trulioo.Client.Model.Errors;

namespace FunFair.Trulioo.Client.Model.BusinessSearch
{
    /// <summary>
    ///     Business Record containing information on Business Search Results
    /// </summary>
    public class BusinessRecord
    {
        /// <summary>
        ///     Business Record Constructor
        /// </summary>
        public BusinessRecord()
        {
            this.Errors = new List<ServiceError>();
            this.DatasourceResults = new List<BusinessSearchResult>();
        }

        /// <summary>
        ///     The TransactionRecordID, this is the ID you will use to fetch the transaction again.
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public string TransactionRecordID { get; set; }

        /// <summary>
        ///     'match' or 'nomatch' if the verification passed the rules configured on your account this will be 'match'.
        /// </summary>
        public string RecordStatus { get; set; }

        /// <summary>
        ///     Results for each datasource that was queried
        /// </summary>
        public List<BusinessSearchResult> DatasourceResults { get; set; }

        /// <summary>
        ///     Errors that occurred, refer to Service Errors to see the errors that appear
        /// </summary>
        public List<ServiceError> Errors { get; set; }
    }
}