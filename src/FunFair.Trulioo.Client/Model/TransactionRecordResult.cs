using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace FunFair.Trulioo.Client.Model
{
    /// <summary>
    ///     Transaction record result.
    /// </summary>
    [SuppressMessage(category: "ReSharper", checkId: "ClassNeverInstantiated.Global", Justification = "TODO: Review")]
    public class TransactionRecordResult : VerifyResult
    {
        /// <summary>
        ///     Constructor.
        /// </summary>
        /// <param name="transactionId">Transaction Id</param>
        public TransactionRecordResult(string transactionId)
            : base(transactionId)
        {
        }

        /// <summary>
        ///     Input fields.
        /// </summary>
        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public List<DataField> InputFields { get; set; }
    }
}


