using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace FunFair.Trulioo.Client.Model
{
    /// <summary>
    ///     Datasource model for information returned on a specific datasource
    /// </summary>
    [SuppressMessage(category: "ReSharper", checkId: "ClassNeverInstantiated.Global", Justification = "TODO: Review")]
    public class NormalizedDatasourceGroupCountry
    {
        /// <summary>
        ///     Name
        /// </summary>
        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public string Name { get; set; }

        /// <summary>
        ///     Description
        /// </summary>
        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public string Description { get; set; }

        /// <summary>
        ///     Required Fields
        /// </summary>
        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public List<NormalizedDatasourceField> RequiredFields { get; set; }

        /// <summary>
        ///     Optional Fields
        /// </summary>
        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public List<NormalizedDatasourceField> OptionalFields { get; set; }

        /// <summary>
        ///     Appended Fields
        /// </summary>
        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public List<NormalizedDatasourceField> AppendedFields { get; set; }

        /// <summary>
        ///     Output Fields
        /// </summary>
        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public List<NormalizedDatasourceField> OutputFields { get; set; }

        /// <summary>
        ///     Source Type
        /// </summary>
        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public string SourceType { get; set; }

        /// <summary>
        ///     Update Frequency
        /// </summary>
        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public string UpdateFrequency { get; set; }

        /// <summary>
        ///     Coverage
        /// </summary>
        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public string Coverage { get; set; }
    }
}