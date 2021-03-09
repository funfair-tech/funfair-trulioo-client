using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using FunFair.Trulioo.Client.Model;
using FunFair.Trulioo.Client.URI;

namespace FunFair.Trulioo.Client
{
    /// <summary>
    ///     Provides a class for working with Trulioo Configuration.
    /// </summary>


    [SuppressMessage(category: "ReSharper", checkId: "ClassCanBeSealed.Global", Justification = "TODO: Review")]
    [SuppressMessage(category: "ReSharper", checkId: "ClassNeverInstantiated.Global", Justification = "TODO: Review")]
    public class Configuration : IConfiguration
    {
        private readonly Namespace _configurationNamespace = new(value: "configuration");

        private readonly TruliooApiClient _service;

        /// <summary>
        ///     Initializes a new instance of the <see cref="Configuration" /> class.
        /// </summary>
        /// <param name="service">
        ///     An object representing the root of Trulioo configuration service.
        /// </param>
        /// <exception cref="ArgumentNullException">
        ///     <paramref name="service" /> is <c>null</c>.
        /// </exception>
        protected internal Configuration(TruliooApiClient service)
        {
            this._service = service ?? throw new ArgumentNullException(nameof(service));
        }

        private Context Context => this._service?.Context;

        /// <summary>
        ///     Consents required for the provided country and configuration
        /// </summary>
        /// <param name="countryCode"></param>
        /// <param name="configurationName"></param>
        public async Task<IEnumerable<string>> GetСonsentsAsync(string countryCode, string configurationName)
        {
            ResourceName resource = new("consents", configurationName, countryCode);
            IEnumerable<string> response = await this.Context.GetAsync<IEnumerable<string>>(ns: this._configurationNamespace, resource: resource);

            return response;
        }

        /// <summary>
        ///     Get Country Codes configured for your account
        /// </summary>
        /// <param name="configurationName"></param>
        public async Task<IEnumerable<string>> GetCountryCodesAsync(string configurationName)
        {
            ResourceName resource = new("countrycodes", configurationName);
            IEnumerable<string> response = await this.Context.GetAsync<IEnumerable<string>>(ns: this._configurationNamespace, resource: resource);

            return response;
        }

        /// <summary>
        ///     Generates json schema for the API, the schema is dynamic based on the country and configuration you are using.
        /// </summary>
        /// <param name="countryCode"></param>
        /// <param name="configurationName"></param>
        /// <returns></returns>
        public async Task<Dictionary<string, dynamic>> GetFieldsAsync(string countryCode, string configurationName)
        {
            ResourceName resource = new("fields", configurationName, countryCode);
            Dictionary<string, dynamic> response = await this.Context.GetAsync<Dictionary<string, dynamic>>(ns: this._configurationNamespace, resource: resource);

            return response;
        }

        /// <summary>
        ///     Gets the provinces states or other subdivisions for a country, mostly matches ISO 3166-2
        /// </summary>
        /// <param name="countryCode"></param>


        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public async Task<IEnumerable<CountrySubdivision>> GetCountrySubdivisionsAsync(string countryCode)
        {
            ResourceName resource = new("countrysubdivisions", countryCode);
            IList<CountrySubdivision> response = await this.Context.GetAsync<IList<CountrySubdivision>>(ns: this._configurationNamespace, resource: resource);

            return response;
        }

        /// <summary>
        ///     Gets a list of TestEntities as a list of DataFields objects
        /// </summary>
        /// <param name="countryCode"></param>
        /// <param name="configurationName"></param>
        /// <returns>List of Datafields object</returns>


        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public async Task<IEnumerable<DataFields>> GetTestEntitiesAsync(string countryCode, string configurationName)
        {
            ResourceName resource = new("testentities", configurationName, countryCode);
            IList<DataFields> response = await this.Context.GetAsync<IList<DataFields>>(ns: this._configurationNamespace, resource: resource);

            return response;
        }

        /// <summary>
        ///     Gets a list of Data sources
        /// </summary>
        /// <param name="countryCode"></param>
        /// <param name="configurationName"></param>
        /// <returns> List of Data source Group Countries </returns>


        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public async Task<IEnumerable<NormalizedDatasourceGroupCountry>> GetDatasourcesAsync(string countryCode, string configurationName)
        {
            ResourceName resource = new("datasources", configurationName, countryCode);
            IList<NormalizedDatasourceGroupCountry> response =
                await this.Context.GetAsync<IList<NormalizedDatasourceGroupCountry>>(ns: this._configurationNamespace, resource: resource);

            return response;
        }

        /// <summary>
        ///     Gets a list of document types
        /// </summary>
        /// <param name="countryCode"></param>
        /// <returns> Dictionary with Keys as the Country Codes and Values as list of document types for that country </returns>


        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        public async Task<Dictionary<string, IList<string>>> GetDocumentTypesAsync(string countryCode = null)
        {
            ResourceName resource = countryCode != null ? new ResourceName("documentTypes", countryCode) : new ResourceName("documentTypes");

            Dictionary<string, IList<string>> response = await this.Context.GetAsync<Dictionary<string, IList<string>>>(ns: this._configurationNamespace, resource: resource);

            return response;
        }
    }

    public interface IConfiguration
    {
        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        Task<Dictionary<string, dynamic>> GetFieldsAsync(string countryCode, string configurationName);

        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        Task<IEnumerable<string>> GetСonsentsAsync(string countryCode, string configurationName);

        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        Task<IEnumerable<string>> GetCountryCodesAsync(string configurationName);
    }
}

