using System;
using System.Diagnostics.CodeAnalysis;

namespace FunFair.Trulioo.Client.Model
{
    /// <summary>
    ///     Metadata on transaction status
    /// </summary>

    // ReSharper disable once UnusedType.Global
    public class TransactionStatus
    {
        /// <summary>
        ///     Transaction ID of the transaction
        /// </summary>


        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public string TransactionId { get; set; }

        /// <summary>
        ///     Transaction Record ID of the transaction available once the transaction has finished processing
        /// </summary>


        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public string TransactionRecordId { get; set; }

        /// <summary>
        ///     Status of the transaction. Possible Values: Uploading, Processing, Completed, InProgress, Failed, WaitAsync, ToBeResumed, Canceled, TimeoutCanceled. Call GetTransactionRecord when status changes
        ///     to Completed, Failed, Canceled or TimeoutCanceled to get the verification results.
        /// </summary>


        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public string Status { get; set; }

        /// <summary>
        ///     Uploaded date for transaction
        /// </summary>


        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public DateTime UploadedDt { get; set; }

        /// <summary>
        ///     Set to true when transaction has timed out
        /// </summary>


        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public bool IsTimedOut { get; set; }
    }
}
