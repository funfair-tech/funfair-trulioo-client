namespace FunFair.Trulioo.Client.Model
{
    /// <summary>
    ///     ISO 3166-2 break down of the country
    /// </summary>

    // ReSharper disable once ClassNeverInstantiated.Global
    public class CountrySubdivision
    {
        /// <summary>
        ///     Name of the area, in English or one of the languages of the country
        /// </summary>

        // ReSharper disable once UnusedMember.Global
        public string Name { get; set; }

        /// <summary>
        ///     Code for the area
        /// </summary>

        // ReSharper disable once UnusedMember.Global
        public string Code { get; set; }

        /// <summary>
        ///     Code of the parent entity
        /// </summary>

        // ReSharper disable once UnusedMember.Global
        public string ParentCode { get; set; }
    }
}