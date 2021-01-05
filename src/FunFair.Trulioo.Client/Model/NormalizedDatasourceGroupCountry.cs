using System.Collections.Generic;

namespace FunFair.Trulioo.Client.Model
{
    /// <summary>
    ///     Datasource model for information returned on a specific datasource
    /// </summary>

    // ReSharper disable once ClassNeverInstantiated.Global
    public class NormalizedDatasourceGroupCountry
    {
        /// <summary>
        ///     Name
        /// </summary>

        // ReSharper disable once UnusedMember.Global
        public string Name { get; set; }

        /// <summary>
        ///     Description
        /// </summary>

        // ReSharper disable once UnusedMember.Global
        public string Description { get; set; }

        /// <summary>
        ///     Required Fields
        /// </summary>

        // ReSharper disable once UnusedMember.Global
        public List<NormalizedDatasourceField> RequiredFields { get; set; }

        /// <summary>
        ///     Optional Fields
        /// </summary>

        // ReSharper disable once UnusedMember.Global
        public List<NormalizedDatasourceField> OptionalFields { get; set; }

        /// <summary>
        ///     Appended Fields
        /// </summary>

        // ReSharper disable once UnusedMember.Global
        public List<NormalizedDatasourceField> AppendedFields { get; set; }

        /// <summary>
        ///     Output Fields
        /// </summary>

        // ReSharper disable once UnusedMember.Global
        public List<NormalizedDatasourceField> OutputFields { get; set; }

        /// <summary>
        ///     Source Type
        /// </summary>

        // ReSharper disable once UnusedMember.Global
        public string SourceType { get; set; }

        /// <summary>
        ///     Update Frequency
        /// </summary>

        // ReSharper disable once UnusedMember.Global
        public string UpdateFrequency { get; set; }

        /// <summary>
        ///     Coverage
        /// </summary>

        // ReSharper disable once UnusedMember.Global
        public string Coverage { get; set; }
    }
}