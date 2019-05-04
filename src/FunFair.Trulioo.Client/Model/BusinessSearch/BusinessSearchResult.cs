using System.Collections.Generic;
using FunFair.Trulioo.Client.Model.Errors;

namespace FunFair.Trulioo.Client.Model.BusinessSearch
{
    /// <summary>
    ///     Result Object for Business Search containing search results from one datasource
    /// </summary>
    public class BusinessSearchResult
    {
        /// <summary>
        ///     Business Search Result Constructor
        /// </summary>
        public BusinessSearchResult()
        {
            Errors = new List<ServiceError>();
        }

        /// <summary>
        ///     The list of businesses returned from the search
        /// </summary>
        public List<SearchResult> Results { get; set; }

        /// <summary>
        ///     Name of the datasource that was called
        /// </summary>
        public string DatasourceName { get; set; }

        /// <summary>
        ///     List of errors returned from datasource
        /// </summary>
        public List<ServiceError> Errors { get; }
    }
}