using System.Diagnostics.CodeAnalysis;

namespace FunFair.Trulioo.Client.Model
{
    /// <summary>
    ///     A data source field.
    /// </summary>
    [SuppressMessage(category: "ReSharper", checkId: "ClassNeverInstantiated.Global", Justification = "TODO: Review")]
    public class DatasourceField
    {
        /// <summary>
        ///     The field name.
        /// </summary>
        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public string FieldName { get; set; }

        /// <summary>
        ///     The status.
        /// </summary>
        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public string Status { get; set; }

        /// <summary>
        ///     THe field group.
        /// </summary>
        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public string FieldGroup { get; set; }
    }
}


