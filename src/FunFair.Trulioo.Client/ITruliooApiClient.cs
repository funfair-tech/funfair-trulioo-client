using System.Diagnostics.CodeAnalysis;

namespace FunFair.Trulioo.Client
{
    /// <summary>
    ///     Provides an operational interface to the Trulioo API V1.
    /// </summary>
    public interface ITruliooApiClient
    {
        /// <summary>
        ///     Gets the <see cref="Configuration" /> instance for this <see cref="ITruliooApiClient" />.
        /// </summary>

        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        IConfiguration Configuration { get; }

        /// <summary>
        ///     Gets the <see cref="Verification" /> instance for this <see cref="ITruliooApiClient" />.
        /// </summary>

        [SuppressMessage(category: "ReSharper", checkId: "UnusedMember.Global", Justification = "TODO: Review")]
        IVerification Verification { get; }
    }
}