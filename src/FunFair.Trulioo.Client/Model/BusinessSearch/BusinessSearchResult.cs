using System.Collections.Generic;
using FunFair.Trulioo.Client.Model.Errors;

namespace FunFair.Trulioo.Client.Model.BusinessSearch
{
    /// <summary>
    ///     Result Object for Business Search containing search results from one datasource
    /// </summary>

    // ReSharper disable once ClassNeverInstantiated.Global
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

        // ReSharper disable once UnusedMember.Global
        public List<SearchResult> Results { get; set; }

        /// <summary>
        ///     Name of the datasource that was called
        /// </summary>

        // ReSharper disable once UnusedMember.Global
        public string DatasourceName { get; set; }

        /// <summary>
        ///     List of errors returned from datasource
        /// </summary>

        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        public List<ServiceError> Errors { get; }
    }
}