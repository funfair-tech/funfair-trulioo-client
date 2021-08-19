using System.Diagnostics.CodeAnalysis;

namespace FunFair.Trulioo.Client
{
    /// <summary>
    ///     Context.
    /// </summary>
    public interface IContextAware
    {
        /// <summary>
        ///     Gets the <see cref="Context" /> instance for this <see cref="ITruliooApiClient" />.
        /// </summary>
        [SuppressMessage(category: "ReSharper", checkId: "UnusedMemberInSuper.Global", Justification = "Not our code")]
        Context Context { get; }
    }
}