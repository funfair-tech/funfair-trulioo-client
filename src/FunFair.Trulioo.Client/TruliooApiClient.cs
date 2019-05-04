using System;

namespace FunFair.Trulioo.Client
{
    /// <summary>
    ///     Provides access to the Trulioo API V1 offered.
    /// </summary>
    public class TruliooApiClient : ITruliooApiClient, IContextAware
    {
        private Configuration _configuration;

        private Connection _connection;

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
            Context = context ?? throw new ArgumentNullException(nameof(context));
        }

        /// <inheritdoc />
        public Context Context { get; }

        /// <inheritdoc />
        public IConfiguration Configuration => _configuration ?? (_configuration = new Configuration(this));

        /// <inheritdoc />
        public IVerification Verification => _verification ?? (_verification = new Verification(this));

        /// <inheritdoc />
        public Connection Connection => _connection ?? (_connection = new Connection(this));

        /// <summary>
        ///     Gets the URI string for this <see cref="TruliooApiClient" /> instance.
        /// </summary>
        /// <returns>
        ///     A string that represents this object.
        /// </returns>
        public override string ToString()
        {
            return Context.ToString();
        }
    }
}