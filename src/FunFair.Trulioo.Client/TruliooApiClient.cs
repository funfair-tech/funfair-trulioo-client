using System;
using System.Diagnostics.CodeAnalysis;

namespace FunFair.Trulioo.Client
{
    /// <summary>
    ///     Provides access to the Trulioo API V1 offered.
    /// </summary>
    [SuppressMessage(category: "ReSharper", checkId: "ClassNeverInstantiated.Global", Justification = "TODO: Review")]
    public class TruliooApiClient : ITruliooApiClient, IContextAware
    {
        private Configuration _configuration;

        private Verification _verification;

        /// <summary>
        ///     Initializes a new instance of the <see cref="TruliooApiClient" /> class.
        /// </summary>
        /// <param name="context">
        ///     The context for requests by the new <see cref="TruliooApiClient" />.
        /// </param>
        /// ###
        /// <exception cref="ArgumentNullException">
        ///     <paramref name="context" /> is <c>null</c>.
        /// </exception>
        public TruliooApiClient(Context context)
        {
            this.Context = context ?? throw new ArgumentNullException(nameof(context));
        }

        /// <inheritdoc />
        public Context Context { get; }

        /// <inheritdoc />
        public IConfiguration Configuration => this._configuration ??= new(this);

        /// <inheritdoc />
        public IVerification Verification => this._verification ??= new(this);

        /// <summary>
        ///     Gets the URI string for this <see cref="TruliooApiClient" /> instance.
        /// </summary>
        /// <returns>
        ///     A string that represents this object.
        /// </returns>
        [SuppressMessage(category: "ToStringWithoutOverrideAnalyzer",
                         checkId: "ExplicitToStringWithoutOverrideAnalyzer: Calling ToString() on object of type 'T' but it does not override ToString()",
                         Justification = "Required in this case")]
        public override string ToString()
        {
            return this.Context.ToString();
        }
    }
}