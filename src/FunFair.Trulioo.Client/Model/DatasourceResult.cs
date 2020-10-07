using System.Collections.Generic;
using FunFair.Trulioo.Client.Model.Errors;

namespace FunFair.Trulioo.Client.Model
{
    /// <summary>
    ///     A result from a particular datasource
    /// </summary>
    public class DatasourceResult
    {
        /// <summary>
        ///     The data source status.
        /// </summary>
        public string DatasourceStatus { get; set; }

        /// <summary>
        ///     The data source name.
        /// </summary>
        public string DatasourceName { get; set; }

        /// <summary>
        ///     The data source fields.
        /// </summary>
        public IEnumerable<DatasourceField> DatasourceFields { get; set; }

        /// <summary>
        ///     The appended fields.
        /// </summary>
        public IEnumerable<AppendedField> AppendedFields { get; set; }

        /// <summary>
        ///     The Errors.
        /// </summary>
        public IEnumerable<ServiceError> Errors { get; set; }

        /// <summary>
        ///     The field groups.
        /// </summary>
        public IEnumerable<string> FieldGroups { get; set; }
    }
}