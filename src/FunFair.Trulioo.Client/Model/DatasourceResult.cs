using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using FunFair.Trulioo.Client.Model.Errors;

namespace FunFair.Trulioo.Client.Model
{
    /// <summary>
    ///     A result from a particular datasource
    /// </summary>
    [SuppressMessage(category: "ReSharper", checkId: "ClassNeverInstantiated.Global", Justification = "TODO: Review")]
    public class DatasourceResult
    {
        /// <summary>
        ///     The data source status.
        /// </summary>
        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public string DatasourceStatus { get; set; }

        /// <summary>
        ///     The data source name.
        /// </summary>
        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public string DatasourceName { get; set; }

        /// <summary>
        ///     The data source fields.
        /// </summary>
        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public IEnumerable<DatasourceField> DatasourceFields { get; set; }

        /// <summary>
        ///     The appended fields.
        /// </summary>
        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public IEnumerable<AppendedField> AppendedFields { get; set; }

        /// <summary>
        ///     The Errors.
        /// </summary>
        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public IEnumerable<ServiceError> Errors { get; set; }

        /// <summary>
        ///     The field groups.
        /// </summary>
        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public IEnumerable<string> FieldGroups { get; set; }
    }
}