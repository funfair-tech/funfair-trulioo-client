namespace FunFair.Trulioo.Client
{
    /// <summary>
    /// </summary>
    public interface IContextAware
    {
        /// <summary>
        ///     Gets the <see cref="Context" /> instance for this <see cref="ITruliooApiClient" />.
        /// </summary>
        Context Context { get; }
    }
}