using System.Collections.Generic;
using FunFair.Trulioo.Client.Model.Errors;

namespace FunFair.Trulioo.Client.Model
{
    /// <summary>
    /// A Transaction record.
    /// </summary>
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Record
    {
        /// <summary>
        /// Record Id
        /// </summary>
        // ReSharper disable once InconsistentNaming
        // ReSharper disable once UnusedMember.Global
        public string TransactionRecordID { get; set; }

        /// <summary>
        /// Record status.
        /// </summary>
        // ReSharper disable once UnusedMember.Global
        public string RecordStatus { get; set; }

        /// <summary>
        /// Results.
        /// </summary>
        // ReSharper disable once UnusedMember.Global
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
        // ReSharper disable once UnusedMember.Global
        public IEnumerable<ServiceError> Errors { get; set; }

        /// <summary>
        /// Rule.
        /// </summary>
        // ReSharper disable once UnusedMember.Global
        public RecordRule Rule { get; set; }
    }
}