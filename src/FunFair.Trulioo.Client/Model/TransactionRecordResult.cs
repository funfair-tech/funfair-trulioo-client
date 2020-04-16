using System.Collections.Generic;

namespace FunFair.Trulioo.Client.Model
{
    /// <summary>
    /// </summary>
    public class TransactionRecordResult : VerifyResult
    {
        /// <summary>
        /// </summary>
        /// <param name="transactionId"></param>
        public TransactionRecordResult(string transactionId)
            : base(transactionId)
        {
        }

        /// <summary>
        /// </summary>
        public List<DataField> InputFields { get; set; }
    }
}