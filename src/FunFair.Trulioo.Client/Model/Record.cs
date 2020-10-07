using System.Collections.Generic;
using FunFair.Trulioo.Client.Model.Errors;

namespace FunFair.Trulioo.Client.Model
{
    /// <summary>
    /// A Transaction record.
    /// </summary>
    public class Record
    {
        /// <summary>
        /// Record Id
        /// </summary>

        // ReSharper disable once InconsistentNaming Not our code
        public string TransactionRecordID { get; set; }

        /// <summary>
        /// Record status.
        /// </summary>
        public string RecordStatus { get; set; }

        /// <summary>
        /// Results.
        /// </summary>
        public IEnumerable<DatasourceResult> DatasourceResults { get; set; }

        /// <summary>
        ///     <ul>
        ///         <li>1002 : Datasource Unavailable - The source did not respond</li>
        ///         <li>1006 : Unrecognized Field Name</li>
        ///         <li>1007 : Consent datasource not recognized</li>
        ///         <li>1008 : Invalid Field Format</li>
        ///         <li>1009 : Unrecognized Field group</li>
        ///         <li>1010 : Request Timed Out</li>
        ///         <li>1011 : Duplicate Field received</li>
        ///         <li>2000 : Unrecognized Error</li>
        ///     </ul>
        /// </summary>
        public IEnumerable<ServiceError> Errors { get; set; }

        /// <summary>
        /// Rule.
        /// </summary>
        public RecordRule Rule { get; set; }
    }
}