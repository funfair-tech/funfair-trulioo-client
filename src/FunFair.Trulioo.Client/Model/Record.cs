using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using FunFair.Trulioo.Client.Model.Errors;

namespace FunFair.Trulioo.Client.Model
{
    /// <summary>
    ///     A Transaction record.
    /// </summary>


    [SuppressMessage(category: "ReSharper", checkId: "ClassNeverInstantiated.Global", Justification = "TODO: Review")]
    public class Record
    {
        /// <summary>
        ///     Record Id
        /// </summary>



        [SuppressMessage(category: "ReSharper", checkId: "InconsistentNaming", Justification = "TODO: Review")]
        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public string TransactionRecordID { get; set; }

        /// <summary>
        ///     Record status.
        /// </summary>



        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public string RecordStatus { get; set; }

        /// <summary>
        ///     Results.
        /// </summary>



        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
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



        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public IEnumerable<ServiceError> Errors { get; set; }

        /// <summary>
        ///     Rule.
        /// </summary>



        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public RecordRule Rule { get; set; }
    }
}

