using System.Collections.Generic;

namespace FunFair.Trulioo.Client.Model
{
    /// <summary>
    /// Transaction record result.
    /// </summary>
    public class TransactionRecordResult : VerifyResult
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="transactionId">Transaction Id</param>
        public TransactionRecordResult(string transactionId)
            : base(transactionId)
        {
        }

        /// <summary>
        /// Input fields.
        /// </summary>
        // ReSharper disable once UnusedMember.Global
        public List<DataField> InputFields { get; set; }
    }
}