using System;
using System.Threading.Tasks;
using FunFair.Trulioo.Client.Model;
using FunFair.Trulioo.Client.URI;
using TransactionStatus = System.Transactions.TransactionStatus;

namespace FunFair.Trulioo.Client
{
    /// <summary>
    ///     Provides a class for working with Trulioo Verification.
    /// </summary>
    public class Verification : IVerification
    {
        private readonly TruliooApiClient _service;

        private readonly Namespace _verificationNamespace = new(value: "verifications");

        /// <summary>
        ///     Initializes a new instance of the <see cref="Verification" /> class.
        /// </summary>
        /// <param name="service">
        ///     An object representing the root of Trulioo configuration service.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        ///     <paramref name="service" /> is <c>null</c>.
        /// </exception>
        protected internal Verification(TruliooApiClient service)
        {
            this._service = service ?? throw new ArgumentNullException(nameof(service));
        }

        private Context Context => this._service?.Context;

        /// <summary>
        ///     The verification call for the Trulioo API V1
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<VerifyResult> VerifyAsync(VerifyRequest request)
        {
            ResourceName resource = new("verify");
            VerifyResult response = await this.Context.PostAsync<VerifyResult>(ns: this._verificationNamespace, resource: resource, content: request);

            return response;
        }

        /// <summary>
        ///     Gets transaction record information
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<TransactionRecordResult> GetTransactionRecordAsync(string id)
        {
            ResourceName resource = new("transactionrecord", id);
            TransactionRecordResult response = await this.Context.GetAsync<TransactionRecordResult>(ns: this._verificationNamespace, resource: resource);

            return response;
        }

        /// <summary>
        ///     Gets verbose transaction record information
        /// </summary>
        /// <param name="id"> TransactionRecordID of Transaction Record to be retreived </param>
        /// <returns> Verbose Transaction Record Result of the TransactionRecordID </returns>
        public async Task<TransactionRecordResult> GetTransactionRecordVerboseAsync(string id)
        {
            ResourceName resource = new("transactionrecord", id, "verbose");
            TransactionRecordResult response = await this.Context.GetAsync<TransactionRecordResult>(ns: this._verificationNamespace, resource: resource);

            return response;
        }

        /// <summary>
        ///     Gets a transaction record with address cleansing information
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<TransactionRecordResult> GetTransactionRecordAddressAsync(string id)
        {
            ResourceName resource = new("transactionrecord", id, "withaddress");
            TransactionRecordResult response = await this.Context.GetAsync<TransactionRecordResult>(ns: this._verificationNamespace, resource: resource);

            return response;
        }

        /// <summary>
        ///     Gets the status of a transaction
        /// </summary>
        /// <param name="id">TransactionID of the Transaction Status to be retreived </param>
        /// <returns> Transaction Status of the transactionID </returns>
        public async Task<TransactionStatus> GetTransactionStatusAsync(string id)
        {
            ResourceName resource = new("transaction", id, "status");
            TransactionStatus response = await this.Context.GetAsync<TransactionStatus>(ns: this._verificationNamespace, resource: resource);

            return response;
        }
    }

    public interface IVerification
    {
        Task<VerifyResult> VerifyAsync(VerifyRequest request);
    }
}