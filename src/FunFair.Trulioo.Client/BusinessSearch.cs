using System;
using System.Threading.Tasks;
using FunFair.Trulioo.Client.Model.BusinessSearch;
using FunFair.Trulioo.Client.URI;

namespace FunFair.Trulioo.Client
{
    public class BusinessSearch
    {
        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="BusinessSearch" /> class.
        /// </summary>
        /// <param name="service">
        ///     An object representing the root of Trulioo configuration service.
        /// </param>
        /// <exception cref="ArgumentNullException">
        ///     <paramref name="service" /> is <c>null</c>.
        /// </exception>
        protected internal BusinessSearch(TruliooApiClient service)
        {
            if (service == null)
            {
                throw new ArgumentNullException(nameof(service));
            }

            this._service = service;
        }

        #endregion

        #region Methods

        /// <summary>
        ///     Business Search call for Trulioo API Client V1
        /// </summary>
        /// <param name="request"> Request object containing parameters to search for </param>
        /// <returns> Contains the List of possible businesses from search </returns>
        public async Task<BusinessSearchResponse> BusinessSearchAsync(BusinessSearchRequest request)
        {
            ResourceName resource = new ResourceName("search");
            BusinessSearchResponse response = await this._context.PostAsync<BusinessSearchResponse>(ns: this._businessNamespace, resource: resource, content: request)
                                                        .ConfigureAwait(continueOnCapturedContext: false);

            return response;
        }

        /// <summary>
        ///     Gets Business Search transaction information
        /// </summary>
        /// <param name="transactionId"> TransactionRecordID of Business Search to retreive </param>
        /// <returns> Contains the Business Search transaction result </returns>
        public async Task<BusinessSearchResponse> BusinessSearchResultAsync(string id)
        {
            ResourceName resource = new ResourceName("search", "transactionrecord", id);
            BusinessSearchResponse response = await this._context.GetAsync<BusinessSearchResponse>(ns: this._businessNamespace, resource: resource)
                                                        .ConfigureAwait(continueOnCapturedContext: false);

            return response;
        }

        #endregion

        #region Privates/internals

        private readonly TruliooApiClient _service;

        private Context _context => this._service?.Context;

        private readonly Namespace _businessNamespace = new Namespace(value: "business");

        #endregion
    }
}