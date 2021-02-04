using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using FunFair.Trulioo.Client.Model.Errors;

namespace FunFair.Trulioo.Client.Model.BusinessSearch
{
    /// <summary>
    ///     Business Record containing information on Business Search Results
    /// </summary>
    [SuppressMessage(category: "ReSharper", checkId: "ClassNeverInstantiated.Global", Justification = "TODO: Review")]
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

        [SuppressMessage(category: "ReSharper", checkId: "InconsistentNaming", Justification = "TODO: Review")]
        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public string TransactionRecordID { get; set; }

        /// <summary>
        ///     'match' or 'nomatch' if the verification passed the rules configured on your account this will be 'match'.
        /// </summary>

        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public string RecordStatus { get; set; }

        /// <summary>
        ///     Results for each datasource that was queried
        /// </summary>

        [SuppressMessage(category: "ReSharper", checkId: "UnusedAutoPropertyAccessor.Global", Justification = "TODO: Review")]
        [SuppressMessage(category: "ReSharper", checkId: "AutoPropertyCanBeMadeGetOnly.Global", Justification = "TODO: Review")]
        public List<BusinessSearchResult> DatasourceResults { get; set; }

        /// <summary>
        ///     Errors that occurred, refer to Service Errors to see the errors that appear
        /// </summary>

        [SuppressMessage(category: "ReSharper", checkId: "UnusedAutoPropertyAccessor.Global", Justification = "TODO: Review")]
        [SuppressMessage(category: "ReSharper", checkId: "AutoPropertyCanBeMadeGetOnly.Global", Justification = "TODO: Review")]
        public List<ServiceError> Errors { get; set; }
    }
}