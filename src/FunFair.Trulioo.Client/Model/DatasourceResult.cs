using System.Collections.Generic;
using FunFair.Trulioo.Client.Model.Errors;

namespace FunFair.Trulioo.Client.Model
{
    /// <summary>
    ///     A result from a particular datasource
    /// </summary>

    // ReSharper disable once ClassNeverInstantiated.Global
    public class DatasourceResult
    {
        /// <summary>
        ///     The data source status.
        /// </summary>

        // ReSharper disable once UnusedMember.Global
        public string DatasourceStatus { get; set; }

        /// <summary>
        ///     The data source name.
        /// </summary>

        // ReSharper disable once UnusedMember.Global
        public string DatasourceName { get; set; }

        /// <summary>
        ///     The data source fields.
        /// </summary>

        // ReSharper disable once UnusedMember.Global
        public IEnumerable<DatasourceField> DatasourceFields { get; set; }

        /// <summary>
        ///     The appended fields.
        /// </summary>

        // ReSharper disable once UnusedMember.Global
        public IEnumerable<AppendedField> AppendedFields { get; set; }

        /// <summary>
        ///     The Errors.
        /// </summary>

        // ReSharper disable once UnusedMember.Global
        public IEnumerable<ServiceError> Errors { get; set; }

        /// <summary>
        ///     The field groups.
        /// </summary>

        // ReSharper disable once UnusedMember.Global
        public IEnumerable<string> FieldGroups { get; set; }
    }
}