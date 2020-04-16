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
        /// </summary>
        public string DatasourceStatus { get; set; }

        /// <summary>
        /// </summary>
        public string DatasourceName { get; set; }

        /// <summary>
        /// </summary>
        public IEnumerable<DatasourceField> DatasourceFields { get; set; }

        /// <summary>
        /// </summary>
        public IEnumerable<AppendedField> AppendedFields { get; set; }

        /// <summary>
        /// </summary>
        public IEnumerable<ServiceError> Errors { get; set; }

        /// <summary>
        /// </summary>
        public IEnumerable<string> FieldGroups { get; set; }
    }
}