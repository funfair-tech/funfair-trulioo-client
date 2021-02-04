using System.Diagnostics.CodeAnalysis;

namespace FunFair.Trulioo.Client.Model
{
    /// <summary>
    ///     Record  rule.
    /// </summary>
    [SuppressMessage(category: "ReSharper", checkId: "ClassNeverInstantiated.Global", Justification = "TODO: Review")]
    public class RecordRule
    {
        /// <summary>
        ///     Rule Name.
        /// </summary>

        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public string RuleName { get; set; }

        /// <summary>
        ///     Notes
        /// </summary>

        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public string Note { get; set; }
    }
}