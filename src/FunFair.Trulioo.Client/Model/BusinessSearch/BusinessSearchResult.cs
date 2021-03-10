using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using FunFair.Trulioo.Client.Model.Errors;

namespace FunFair.Trulioo.Client.Model.BusinessSearch
{
    /// <summary>
    ///     Result Object for Business Search containing search results from one datasource
    /// </summary>
    [SuppressMessage(category: "ReSharper", checkId: "ClassNeverInstantiated.Global", Justification = "TODO: Review")]
    public class BusinessSearchResult
    {
        /// <summary>
        ///     Business Search Result Constructor
        /// </summary>
        public BusinessSearchResult()
        {
            this.Errors = new List<ServiceError>();
        }

        /// <summary>
        ///     The list of businesses returned from the search
        /// </summary>
        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public List<SearchResult> Results { get; set; }

        /// <summary>
        ///     Name of the datasource that was called
        /// </summary>
        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public string DatasourceName { get; set; }

        /// <summary>
        ///     List of errors returned from datasource
        /// </summary>
        [SuppressMessage(category: "ReSharper", checkId: "UnusedAutoPropertyAccessor.Global", Justification = "TODO: Review")]
        public List<ServiceError> Errors { get; }
    }
}


